using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using System.Data;

namespace mz.erp.ui.forms
{
    public class mzProductosSearchForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.ImageList imglStandar;
        private System.Windows.Forms.ToolBar toolBarStandar;
        private System.Windows.Forms.ToolBarButton tbSearchNow;
        private System.Windows.Forms.ToolBarButton tbNewSearch;
        private System.Windows.Forms.ToolBarButton tbRefresh;
        private System.Windows.Forms.ToolBarButton tbSep;
        private System.Windows.Forms.ToolBarButton tbDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCodigo;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchDescripcion;
        private Janus.Windows.GridEX.GridEX gridEx;
        private Infragistics.Win.UltraWinGrid.UltraGrid gridStock;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCampoAuxiliar5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCampoAuxiliar4;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCampoAuxiliar3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCampoAuxiliar2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCampoAuxiliar1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCampoAuxiliar4;
        private System.Windows.Forms.Label labelCampoAuxiliar5;
        private System.Windows.Forms.Label labelCampoAuxiliar3;
        private System.Windows.Forms.Label labelCampoAuxiliar1;
        private System.Windows.Forms.Label labelCampoAuxiliar2;
        internal System.Windows.Forms.Button buttonCancel;
        internal System.Windows.Forms.Button buttonOK;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDescripcion1;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecionFinal1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage HojaStock;
        private System.Windows.Forms.TabPage HojaPrecios;
        private System.Windows.Forms.TabPage HojaMedidas;
        private System.Windows.Forms.TabPage HojaAgrupamientos;
        private System.Windows.Forms.TabPage HojaProductosAsociados;
        private System.Windows.Forms.TabPage HojaBuscadorGenerico;
        private System.Windows.Forms.TabPage HojaBuscadorJerarquico;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioNetoMO;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioNetoMD;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMD;
        private System.Windows.Forms.Label labelPrecioNetoMO;
        private System.Windows.Forms.Label labelPrecioFinalMO;
        private System.Windows.Forms.Label labelPrecioNetoMD;
        private System.Windows.Forms.Label labelPrecioFinalMD;
        private System.Windows.Forms.TabPage HojaPreciosMediosDePago;
        private System.Windows.Forms.Label labelPrecioFinal1;
        private Janus.Windows.GridEX.GridEX gridFormasDePago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPrecioFinalMD1;
        private System.Windows.Forms.Label labelPrecioFinalMO1;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMD1;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMO1;

        private ISearchObjectListener _searchObjectListener;

        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCodigoSec;
        private System.Windows.Forms.Label labelCodigoSec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage HojaPreciosCondicionesDeVenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelPrecioFinalMD2;
        private System.Windows.Forms.Label labelPrecioFinalMO2;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMD2;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinalMO2;
        private Janus.Windows.GridEX.GridEX gridCondicionesDeVenta;
        private mz.erp.ui.controls.AcceptButton acceptButton1;
        private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
        private System.Windows.Forms.TabPage HojaImagenes;
        private System.Windows.Forms.PictureBox pictureBoxThumb;
        private mz.erp.ui.controls.GridManagerView gridManagerView1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TabPage HojaBuscadorAuxiliares;
        private System.Windows.Forms.Label labelFiltroCampoAuxiliar1;
        private System.Windows.Forms.Label labelFiltroCampoAuxiliar2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCampoAuxiliar1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCampoAuxiliar2;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage HojaLinks;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCampoAuxiliar3;
        private System.Windows.Forms.Label labelFiltroCampoAuxiliar3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCampoAuxiliar5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCampoAuxiliar4;
        private System.Windows.Forms.Label labelFiltroCampoAuxiliar5;
        private System.Windows.Forms.Label labelFiltroCampoAuxiliar4;
        private mz.erp.ui.controls.mzComboEditor mzComboListaDePrecios;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboTipoDePrecioDeCosto;
        private System.Windows.Forms.TabPage HojaProductosPendientesEntrega;
        private Janus.Windows.GridEX.GridEX gridPpp;
        private System.Windows.Forms.TabPage HojaUltimaModificacionPrecios;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaUltimaModifPcioVta;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaUltimaModifPcioCosto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private mz.erp.ui.controls.GridManagerView gridManagerView2;

        private System.Windows.Forms.Label label19;
        private mz.erp.ui.controls.mzComboEditor mzCETipoProducto;
        private mz.erp.ui.controls.mzSearchTextBox mzSearchTextBox1;
        private System.Windows.Forms.Label labelFiltroCampoAuxiliar6;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtCampoAuxiliar6;
        private System.Windows.Forms.Label labelCampoAuxiliar6;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceEntreFechas;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaHasta;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaDesde;
        private System.Windows.Forms.Label lFecha;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceResponsable;
        private mz.erp.ui.controls.mzComboEditor mzCEResponsable;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage HojaListasDePrecios;
        private mz.erp.ui.controls.GridManagerView gridManagerView3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtSearchCodProveedor;
        private Label label22;
        private mz.erp.ui.controls.mzComboEditor mzCTipoProducto;
        private TabPage HojaDetalleCombo;
        private Janus.Windows.GridEX.GridEX gridListasDePrecios;
        private controls.GridManagerView gridManagerView4;
        private Janus.Windows.GridEX.GridEX gridDetalleCombo;
        private CheckBox chkPermiteCambio;
        private TabPage tabBonificaciones;
        private Janus.Windows.GridEX.GridEX gridBonificaciones;
        private Label label23;
        private Label label24;
        private controls.mzComboEditor mzCEBonificacion;


        public ISearchObjectListener SearchObjectListener
        {
            get { return _searchObjectListener; }
            set
            {
                _searchObjectListener = value;

            }
        }

        private bool _cierreAutomatico = true;
        public mzProductosSearchForm()
        {
            InitializeComponent();
        }

        public mzProductosSearchForm(bool CierreAutomatico, string VienePor)
        {
            _cierreAutomatico = CierreAutomatico;
            InitializeComponent();
            if (VienePor == "F3")
                AnularEnter();
        }

        public mzProductosSearchForm(bool CierreAutomatico)
        {
            _cierreAutomatico = CierreAutomatico;
            InitializeComponent();
        }

        public mzProductosSearchForm(bool CierreAutomatico, bool SeleccionMultiple)
        {
            _cierreAutomatico = CierreAutomatico;
            InitializeComponent();
            if (!SeleccionMultiple)
                this.gridEx.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
        }

        private string _idProveedor = "";
        public void SetIdProveedor(string IdProveedor)
        {
            _idProveedor = IdProveedor;
            _uicontroller.SetIdProveedor(IdProveedor);

            cboTipoDePrecioDeCosto.Items.Clear();
            cboTipoDePrecioDeCosto.Items.AddRange(_uicontroller.TiposDePrecioDeCosto.ToArray());
            cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCostoDefault;
            this.cboTipoDePrecioDeCosto.Enabled = cboTipoDePrecioDeCosto.Items.Count > 1;
        }

        //Sabrina: Tarea 1080. 20110326
        public bool PermiteProductosCombo
        {
            get { return _uicontroller.PermiteProductosCombo; }
            set { _uicontroller.PermiteProductosCombo = value; }

        }
        //Fin Sabrina: Tarea 1080. 20110326

        private string _taskName = "";
        private string _processName = "";
        //esta variable indica si el control esta en un form de compras (C) o ventas (V)
        private string _tipoDeFormularioPadre = "V";
        public void SetProcess(string ProcessName, string TaskName, string TipoDeFormularioPadre)
        {
            _processName = ProcessName;
            _taskName = TaskName;
            _tipoDeFormularioPadre = TipoDeFormularioPadre;
            _uicontroller.SetProcess(_processName, _taskName, _tipoDeFormularioPadre);
            if (_tipoDeFormularioPadre.Equals("C"))
            {
                label15.Text = "Tipo de Precio";
                mzComboListaDePrecios.Visible = false;
                cboTipoDePrecioDeCosto.Visible = true;
            }
        }

        private void CloseUI(object panel, EventArgs args)
        {
            this.Visible = false;
        }
        private void ShowUI(object panel, EventArgs args)
        {
        }

        #region Dispose
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion




        #region Código generado por el Diseñador de Windows Forms
        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mzProductosSearchForm));
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2");
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Sucursal");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad");
            Infragistics.Win.UltraWinDataSource.UltraDataBand ultraDataBand3 = new Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1");
            Infragistics.Win.UltraWinDataSource.UltraDataBand ultraDataBand4 = new Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sucursal");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn8 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn9 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn10 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn11 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn12 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad");
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbSearchNow = new System.Windows.Forms.ToolBarButton();
            this.tbNewSearch = new System.Windows.Forms.ToolBarButton();
            this.tbRefresh = new System.Windows.Forms.ToolBarButton();
            this.tbSep = new System.Windows.Forms.ToolBarButton();
            this.tbDetail = new System.Windows.Forms.ToolBarButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HojaPrecios = new System.Windows.Forms.TabPage();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.labelPrecioFinalMD = new System.Windows.Forms.Label();
            this.labelPrecioNetoMD = new System.Windows.Forms.Label();
            this.labelPrecioFinalMO = new System.Windows.Forms.Label();
            this.labelPrecioNetoMO = new System.Windows.Forms.Label();
            this.unePrecioFinalMD = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioNetoMD = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioNetoMO = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar5 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCampoAuxiliar4 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCampoAuxiliar3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCampoAuxiliar2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtCampoAuxiliar1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtDescripcion = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.unePrecioFinalMO = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCampoAuxiliar4 = new System.Windows.Forms.Label();
            this.labelCampoAuxiliar5 = new System.Windows.Forms.Label();
            this.labelCampoAuxiliar3 = new System.Windows.Forms.Label();
            this.labelCampoAuxiliar1 = new System.Windows.Forms.Label();
            this.labelCampoAuxiliar2 = new System.Windows.Forms.Label();
            this.HojaListasDePrecios = new System.Windows.Forms.TabPage();
            this.gridListasDePrecios = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView3 = new mz.erp.ui.controls.GridManagerView();
            this.HojaPreciosCondicionesDeVenta = new System.Windows.Forms.TabPage();
            this.pictureBoxThumb = new System.Windows.Forms.PictureBox();
            this.labelPrecioFinalMD2 = new System.Windows.Forms.Label();
            this.labelPrecioFinalMO2 = new System.Windows.Forms.Label();
            this.unePrecioFinalMD2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioFinalMO2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label16 = new System.Windows.Forms.Label();
            this.gridCondicionesDeVenta = new Janus.Windows.GridEX.GridEX();
            this.HojaUltimaModificacionPrecios = new System.Windows.Forms.TabPage();
            this.uccFechaUltimaModifPcioVta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.uccFechaUltimaModifPcioCosto = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.HojaProductosAsociados = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.HojaStock = new System.Windows.Forms.TabPage();
            this.labelPrecioFinal1 = new System.Windows.Forms.Label();
            this.unePrecionFinal1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.gridStock = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.HojaMedidas = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.HojaPreciosMediosDePago = new System.Windows.Forms.TabPage();
            this.labelPrecioFinalMD1 = new System.Windows.Forms.Label();
            this.labelPrecioFinalMO1 = new System.Windows.Forms.Label();
            this.unePrecioFinalMD1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioFinalMO1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label13 = new System.Windows.Forms.Label();
            this.gridFormasDePago = new Janus.Windows.GridEX.GridEX();
            this.HojaProductosPendientesEntrega = new System.Windows.Forms.TabPage();
            this.gridManagerView2 = new mz.erp.ui.controls.GridManagerView();
            this.gridPpp = new Janus.Windows.GridEX.GridEX();
            this.HojaLinks = new System.Windows.Forms.TabPage();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.HojaImagenes = new System.Windows.Forms.TabPage();
            this.HojaAgrupamientos = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.HojaDetalleCombo = new System.Windows.Forms.TabPage();
            this.gridDetalleCombo = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView4 = new mz.erp.ui.controls.GridManagerView();
            this.tabBonificaciones = new System.Windows.Forms.TabPage();
            this.gridBonificaciones = new Janus.Windows.GridEX.GridEX();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.mzCEBonificacion = new mz.erp.ui.controls.mzComboEditor();
            this.txtCampoAuxiliar6 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.labelCampoAuxiliar6 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.HojaBuscadorGenerico = new System.Windows.Forms.TabPage();
            this.chkPermiteCambio = new System.Windows.Forms.CheckBox();
            this.mzCTipoProducto = new mz.erp.ui.controls.mzComboEditor();
            this.txtSearchCodProveedor = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.uceEntreFechas = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.udtFechaAltaHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.udtFechaAltaDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.lFecha = new System.Windows.Forms.Label();
            this.uceResponsable = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.mzCEResponsable = new mz.erp.ui.controls.mzComboEditor();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtSearchDescripcion = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtSearchCodigo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtSearchCodigoSec = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCodigoSec = new System.Windows.Forms.Label();
            this.mzComboListaDePrecios = new mz.erp.ui.controls.mzComboEditor();
            this.cboTipoDePrecioDeCosto = new System.Windows.Forms.ComboBox();
            this.HojaBuscadorJerarquico = new System.Windows.Forms.TabPage();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.HojaBuscadorAuxiliares = new System.Windows.Forms.TabPage();
            this.labelFiltroCampoAuxiliar6 = new System.Windows.Forms.Label();
            this.txtSearchCampoAuxiliar5 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtSearchCampoAuxiliar4 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.labelFiltroCampoAuxiliar5 = new System.Windows.Forms.Label();
            this.labelFiltroCampoAuxiliar4 = new System.Windows.Forms.Label();
            this.txtSearchCampoAuxiliar3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.labelFiltroCampoAuxiliar3 = new System.Windows.Forms.Label();
            this.txtSearchCampoAuxiliar2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtSearchCampoAuxiliar1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.labelFiltroCampoAuxiliar2 = new System.Windows.Forms.Label();
            this.labelFiltroCampoAuxiliar1 = new System.Windows.Forms.Label();
            this.mzSearchTextBox1 = new mz.erp.ui.controls.mzSearchTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gridEx = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.mzCETipoProducto = new mz.erp.ui.controls.mzComboEditor();
            this.acceptButton1 = new mz.erp.ui.controls.AcceptButton(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.HojaPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioNetoMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioNetoMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMO)).BeginInit();
            this.HojaListasDePrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListasDePrecios)).BeginInit();
            this.HojaPreciosCondicionesDeVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCondicionesDeVenta)).BeginInit();
            this.HojaUltimaModificacionPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaUltimaModifPcioVta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaUltimaModifPcioCosto)).BeginInit();
            this.HojaProductosAsociados.SuspendLayout();
            this.HojaStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecionFinal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            this.HojaMedidas.SuspendLayout();
            this.HojaPreciosMediosDePago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormasDePago)).BeginInit();
            this.HojaProductosPendientesEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPpp)).BeginInit();
            this.HojaLinks.SuspendLayout();
            this.HojaAgrupamientos.SuspendLayout();
            this.HojaDetalleCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCombo)).BeginInit();
            this.tabBonificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBonificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar6)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.HojaBuscadorGenerico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCTipoProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCodProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCodigoSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).BeginInit();
            this.HojaBuscadorJerarquico.SuspendLayout();
            this.HojaBuscadorAuxiliares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem6});
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "&Ver Más Info ...";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Enabled = false;
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "&Seleccionar";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.Text = "";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = -1;
            this.menuItem2.Text = "";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.Text = "";
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
            this.tbSearchNow,
            this.tbNewSearch,
            this.tbRefresh,
            this.tbSep,
            this.tbDetail});
            this.toolBarStandar.Divider = false;
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(794, 26);
            this.toolBarStandar.TabIndex = 1;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
            // 
            // tbSearchNow
            // 
            this.tbSearchNow.ImageIndex = 2;
            this.tbSearchNow.Name = "tbSearchNow";
            this.tbSearchNow.Text = "[F2] Buscar ahora";
            // 
            // tbNewSearch
            // 
            this.tbNewSearch.ImageIndex = 1;
            this.tbNewSearch.Name = "tbNewSearch";
            this.tbNewSearch.Text = "Nueva búsqueda";
            // 
            // tbRefresh
            // 
            this.tbRefresh.ImageIndex = 0;
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Text = "[F5] Actualizar";
            this.tbRefresh.Visible = false;
            // 
            // tbSep
            // 
            this.tbSep.Name = "tbSep";
            this.tbSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbSep.Visible = false;
            // 
            // tbDetail
            // 
            this.tbDetail.ImageIndex = 5;
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Text = "Detalle";
            this.tbDetail.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 40);
            this.panel2.TabIndex = 1808;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(653, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 24);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "&Cancelar";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(533, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 24);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "&Aceptar";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 272);
            this.groupBox1.TabIndex = 1810;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HojaPrecios);
            this.tabControl1.Controls.Add(this.HojaListasDePrecios);
            this.tabControl1.Controls.Add(this.HojaPreciosCondicionesDeVenta);
            this.tabControl1.Controls.Add(this.HojaUltimaModificacionPrecios);
            this.tabControl1.Controls.Add(this.HojaProductosAsociados);
            this.tabControl1.Controls.Add(this.HojaStock);
            this.tabControl1.Controls.Add(this.HojaMedidas);
            this.tabControl1.Controls.Add(this.HojaPreciosMediosDePago);
            this.tabControl1.Controls.Add(this.HojaProductosPendientesEntrega);
            this.tabControl1.Controls.Add(this.HojaLinks);
            this.tabControl1.Controls.Add(this.HojaImagenes);
            this.tabControl1.Controls.Add(this.HojaAgrupamientos);
            this.tabControl1.Controls.Add(this.HojaDetalleCombo);
            this.tabControl1.Controls.Add(this.tabBonificaciones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 253);
            this.tabControl1.TabIndex = 1805;
            this.tabControl1.TabStop = false;
            // 
            // HojaPrecios
            // 
            this.HojaPrecios.Controls.Add(this.lblObservaciones);
            this.HojaPrecios.Controls.Add(this.txtObservaciones);
            this.HojaPrecios.Controls.Add(this.labelPrecioFinalMD);
            this.HojaPrecios.Controls.Add(this.labelPrecioNetoMD);
            this.HojaPrecios.Controls.Add(this.labelPrecioFinalMO);
            this.HojaPrecios.Controls.Add(this.labelPrecioNetoMO);
            this.HojaPrecios.Controls.Add(this.unePrecioFinalMD);
            this.HojaPrecios.Controls.Add(this.unePrecioNetoMD);
            this.HojaPrecios.Controls.Add(this.unePrecioNetoMO);
            this.HojaPrecios.Controls.Add(this.label7);
            this.HojaPrecios.Controls.Add(this.label8);
            this.HojaPrecios.Controls.Add(this.label5);
            this.HojaPrecios.Controls.Add(this.txtCampoAuxiliar5);
            this.HojaPrecios.Controls.Add(this.txtCampoAuxiliar4);
            this.HojaPrecios.Controls.Add(this.txtCampoAuxiliar3);
            this.HojaPrecios.Controls.Add(this.txtCampoAuxiliar2);
            this.HojaPrecios.Controls.Add(this.txtCampoAuxiliar1);
            this.HojaPrecios.Controls.Add(this.txtDescripcion);
            this.HojaPrecios.Controls.Add(this.unePrecioFinalMO);
            this.HojaPrecios.Controls.Add(this.label6);
            this.HojaPrecios.Controls.Add(this.label9);
            this.HojaPrecios.Controls.Add(this.labelCampoAuxiliar4);
            this.HojaPrecios.Controls.Add(this.labelCampoAuxiliar5);
            this.HojaPrecios.Controls.Add(this.labelCampoAuxiliar3);
            this.HojaPrecios.Controls.Add(this.labelCampoAuxiliar1);
            this.HojaPrecios.Controls.Add(this.labelCampoAuxiliar2);
            this.HojaPrecios.Location = new System.Drawing.Point(4, 22);
            this.HojaPrecios.Name = "HojaPrecios";
            this.HojaPrecios.Size = new System.Drawing.Size(780, 227);
            this.HojaPrecios.TabIndex = 4;
            this.HojaPrecios.Text = "Precios, Descripciones";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Location = new System.Drawing.Point(14, 174);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(94, 16);
            this.lblObservaciones.TabIndex = 1843;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.txtObservaciones.Location = new System.Drawing.Point(115, 159);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Scrollbars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservaciones.Size = new System.Drawing.Size(629, 56);
            this.txtObservaciones.TabIndex = 1842;
            this.txtObservaciones.ValueChanged += new System.EventHandler(this.txtObservaciones_ValueChanged);
            // 
            // labelPrecioFinalMD
            // 
            this.labelPrecioFinalMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioFinalMD.Location = new System.Drawing.Point(560, 38);
            this.labelPrecioFinalMD.Name = "labelPrecioFinalMD";
            this.labelPrecioFinalMD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelPrecioFinalMD.Size = new System.Drawing.Size(56, 16);
            this.labelPrecioFinalMD.TabIndex = 1841;
            this.labelPrecioFinalMD.Text = "Moneda";
            // 
            // labelPrecioNetoMD
            // 
            this.labelPrecioNetoMD.Location = new System.Drawing.Point(584, 67);
            this.labelPrecioNetoMD.Name = "labelPrecioNetoMD";
            this.labelPrecioNetoMD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrecioNetoMD.Size = new System.Drawing.Size(48, 16);
            this.labelPrecioNetoMD.TabIndex = 1840;
            this.labelPrecioNetoMD.Text = "Moneda";
            this.labelPrecioNetoMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrecioFinalMO
            // 
            this.labelPrecioFinalMO.Location = new System.Drawing.Point(584, 90);
            this.labelPrecioFinalMO.Name = "labelPrecioFinalMO";
            this.labelPrecioFinalMO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrecioFinalMO.Size = new System.Drawing.Size(48, 16);
            this.labelPrecioFinalMO.TabIndex = 1839;
            this.labelPrecioFinalMO.Text = "Moneda";
            this.labelPrecioFinalMO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrecioNetoMO
            // 
            this.labelPrecioNetoMO.Location = new System.Drawing.Point(584, 113);
            this.labelPrecioNetoMO.Name = "labelPrecioNetoMO";
            this.labelPrecioNetoMO.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrecioNetoMO.Size = new System.Drawing.Size(48, 16);
            this.labelPrecioNetoMO.TabIndex = 1838;
            this.labelPrecioNetoMO.Text = "Moneda";
            this.labelPrecioNetoMO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unePrecioFinalMD
            // 
            this.unePrecioFinalMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unePrecioFinalMD.FormatString = "";
            this.unePrecioFinalMD.Location = new System.Drawing.Point(624, 32);
            this.unePrecioFinalMD.MaxValue = 47483647.99D;
            this.unePrecioFinalMD.MinValue = -47483648.99D;
            this.unePrecioFinalMD.Name = "unePrecioFinalMD";
            this.unePrecioFinalMD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMD.ReadOnly = true;
            this.unePrecioFinalMD.Size = new System.Drawing.Size(120, 28);
            this.unePrecioFinalMD.TabIndex = 1837;
            // 
            // unePrecioNetoMD
            // 
            this.unePrecioNetoMD.Location = new System.Drawing.Point(648, 65);
            this.unePrecioNetoMD.MaxValue = 2147483647.99D;
            this.unePrecioNetoMD.MinValue = -2147483648.99D;
            this.unePrecioNetoMD.Name = "unePrecioNetoMD";
            this.unePrecioNetoMD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioNetoMD.ReadOnly = true;
            this.unePrecioNetoMD.Size = new System.Drawing.Size(96, 21);
            this.unePrecioNetoMD.TabIndex = 1836;
            // 
            // unePrecioNetoMO
            // 
            this.unePrecioNetoMO.Location = new System.Drawing.Point(648, 112);
            this.unePrecioNetoMO.MaxValue = 2147483647.99D;
            this.unePrecioNetoMO.MinValue = -2147483648.99D;
            this.unePrecioNetoMO.Name = "unePrecioNetoMO";
            this.unePrecioNetoMO.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioNetoMO.ReadOnly = true;
            this.unePrecioNetoMO.Size = new System.Drawing.Size(96, 21);
            this.unePrecioNetoMO.TabIndex = 1835;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(408, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 1834;
            this.label7.Text = "Precio Neto";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(408, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 40);
            this.label8.TabIndex = 1833;
            this.label8.Text = "Precio Final Impuestos Incluidos";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(408, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 1829;
            this.label5.Text = "Precio Neto Moneda Origen";
            // 
            // txtCampoAuxiliar5
            // 
            this.txtCampoAuxiliar5.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.txtCampoAuxiliar5.Location = new System.Drawing.Point(115, 137);
            this.txtCampoAuxiliar5.Name = "txtCampoAuxiliar5";
            this.txtCampoAuxiliar5.ReadOnly = true;
            this.txtCampoAuxiliar5.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar5.Size = new System.Drawing.Size(288, 21);
            this.txtCampoAuxiliar5.TabIndex = 1828;
            // 
            // txtCampoAuxiliar4
            // 
            this.txtCampoAuxiliar4.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.txtCampoAuxiliar4.Location = new System.Drawing.Point(115, 115);
            this.txtCampoAuxiliar4.Name = "txtCampoAuxiliar4";
            this.txtCampoAuxiliar4.ReadOnly = true;
            this.txtCampoAuxiliar4.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar4.Size = new System.Drawing.Size(288, 21);
            this.txtCampoAuxiliar4.TabIndex = 1827;
            // 
            // txtCampoAuxiliar3
            // 
            this.txtCampoAuxiliar3.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.txtCampoAuxiliar3.Location = new System.Drawing.Point(115, 93);
            this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
            this.txtCampoAuxiliar3.ReadOnly = true;
            this.txtCampoAuxiliar3.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar3.Size = new System.Drawing.Size(288, 21);
            this.txtCampoAuxiliar3.TabIndex = 1826;
            // 
            // txtCampoAuxiliar2
            // 
            this.txtCampoAuxiliar2.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.txtCampoAuxiliar2.Location = new System.Drawing.Point(115, 71);
            this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
            this.txtCampoAuxiliar2.ReadOnly = true;
            this.txtCampoAuxiliar2.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar2.Size = new System.Drawing.Size(288, 21);
            this.txtCampoAuxiliar2.TabIndex = 1825;
            // 
            // txtCampoAuxiliar1
            // 
            this.txtCampoAuxiliar1.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.txtCampoAuxiliar1.Location = new System.Drawing.Point(115, 49);
            this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
            this.txtCampoAuxiliar1.ReadOnly = true;
            this.txtCampoAuxiliar1.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar1.Size = new System.Drawing.Size(288, 21);
            this.txtCampoAuxiliar1.TabIndex = 1824;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Location = new System.Drawing.Point(115, 8);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(288, 40);
            this.txtDescripcion.TabIndex = 1823;
            // 
            // unePrecioFinalMO
            // 
            this.unePrecioFinalMO.Location = new System.Drawing.Point(648, 88);
            this.unePrecioFinalMO.MaxValue = 2147483647.99D;
            this.unePrecioFinalMO.MinValue = -2147483648.99D;
            this.unePrecioFinalMO.Name = "unePrecioFinalMO";
            this.unePrecioFinalMO.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMO.ReadOnly = true;
            this.unePrecioFinalMO.Size = new System.Drawing.Size(96, 21);
            this.unePrecioFinalMO.TabIndex = 1822;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(408, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 1821;
            this.label6.Text = "Precio Final Imp. Incluidos";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 1820;
            this.label9.Text = "Descripción";
            // 
            // labelCampoAuxiliar4
            // 
            this.labelCampoAuxiliar4.Location = new System.Drawing.Point(14, 119);
            this.labelCampoAuxiliar4.Name = "labelCampoAuxiliar4";
            this.labelCampoAuxiliar4.Size = new System.Drawing.Size(94, 16);
            this.labelCampoAuxiliar4.TabIndex = 1819;
            this.labelCampoAuxiliar4.Text = "Campo Auxiliar 4";
            // 
            // labelCampoAuxiliar5
            // 
            this.labelCampoAuxiliar5.Location = new System.Drawing.Point(14, 141);
            this.labelCampoAuxiliar5.Name = "labelCampoAuxiliar5";
            this.labelCampoAuxiliar5.Size = new System.Drawing.Size(94, 16);
            this.labelCampoAuxiliar5.TabIndex = 1818;
            this.labelCampoAuxiliar5.Text = "Campo Auxiliar 5";
            // 
            // labelCampoAuxiliar3
            // 
            this.labelCampoAuxiliar3.Location = new System.Drawing.Point(14, 97);
            this.labelCampoAuxiliar3.Name = "labelCampoAuxiliar3";
            this.labelCampoAuxiliar3.Size = new System.Drawing.Size(94, 16);
            this.labelCampoAuxiliar3.TabIndex = 1817;
            this.labelCampoAuxiliar3.Text = "Campo Auxiliar 3";
            // 
            // labelCampoAuxiliar1
            // 
            this.labelCampoAuxiliar1.Location = new System.Drawing.Point(14, 53);
            this.labelCampoAuxiliar1.Name = "labelCampoAuxiliar1";
            this.labelCampoAuxiliar1.Size = new System.Drawing.Size(94, 16);
            this.labelCampoAuxiliar1.TabIndex = 1816;
            this.labelCampoAuxiliar1.Text = "Campo Auxiliar 1";
            // 
            // labelCampoAuxiliar2
            // 
            this.labelCampoAuxiliar2.Location = new System.Drawing.Point(14, 75);
            this.labelCampoAuxiliar2.Name = "labelCampoAuxiliar2";
            this.labelCampoAuxiliar2.Size = new System.Drawing.Size(94, 16);
            this.labelCampoAuxiliar2.TabIndex = 1815;
            this.labelCampoAuxiliar2.Text = "Campo Auxiliar 2";
            // 
            // HojaListasDePrecios
            // 
            this.HojaListasDePrecios.Controls.Add(this.gridListasDePrecios);
            this.HojaListasDePrecios.Controls.Add(this.gridManagerView3);
            this.HojaListasDePrecios.Location = new System.Drawing.Point(4, 22);
            this.HojaListasDePrecios.Name = "HojaListasDePrecios";
            this.HojaListasDePrecios.Size = new System.Drawing.Size(780, 227);
            this.HojaListasDePrecios.TabIndex = 11;
            this.HojaListasDePrecios.Text = "Listas de Precios";
            // 
            // gridListasDePrecios
            // 
            this.gridListasDePrecios.AllowCardSizing = false;
            this.gridListasDePrecios.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridListasDePrecios.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridListasDePrecios.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridListasDePrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListasDePrecios.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridListasDePrecios.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridListasDePrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridListasDePrecios.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridListasDePrecios.Location = new System.Drawing.Point(0, 0);
            this.gridListasDePrecios.Name = "gridListasDePrecios";
            this.gridListasDePrecios.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridListasDePrecios.Size = new System.Drawing.Size(780, 227);
            this.gridListasDePrecios.TabIndex = 1851;
            this.gridListasDePrecios.TabStop = false;
            // 
            // gridManagerView3
            // 
            this.gridManagerView3.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView3.Location = new System.Drawing.Point(-17, 101);
            this.gridManagerView3.Name = "gridManagerView3";
            this.gridManagerView3.Size = new System.Drawing.Size(814, 24);
            this.gridManagerView3.TabIndex = 1850;
            this.gridManagerView3.Visible = false;
            // 
            // HojaPreciosCondicionesDeVenta
            // 
            this.HojaPreciosCondicionesDeVenta.Controls.Add(this.pictureBoxThumb);
            this.HojaPreciosCondicionesDeVenta.Controls.Add(this.labelPrecioFinalMD2);
            this.HojaPreciosCondicionesDeVenta.Controls.Add(this.labelPrecioFinalMO2);
            this.HojaPreciosCondicionesDeVenta.Controls.Add(this.unePrecioFinalMD2);
            this.HojaPreciosCondicionesDeVenta.Controls.Add(this.unePrecioFinalMO2);
            this.HojaPreciosCondicionesDeVenta.Controls.Add(this.label16);
            this.HojaPreciosCondicionesDeVenta.Controls.Add(this.gridCondicionesDeVenta);
            this.HojaPreciosCondicionesDeVenta.Location = new System.Drawing.Point(4, 22);
            this.HojaPreciosCondicionesDeVenta.Name = "HojaPreciosCondicionesDeVenta";
            this.HojaPreciosCondicionesDeVenta.Size = new System.Drawing.Size(780, 227);
            this.HojaPreciosCondicionesDeVenta.TabIndex = 6;
            this.HojaPreciosCondicionesDeVenta.Text = "Precios por Condiciones de venta";
            // 
            // pictureBoxThumb
            // 
            this.pictureBoxThumb.Location = new System.Drawing.Point(584, 96);
            this.pictureBoxThumb.Name = "pictureBoxThumb";
            this.pictureBoxThumb.Size = new System.Drawing.Size(160, 120);
            this.pictureBoxThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThumb.TabIndex = 1854;
            this.pictureBoxThumb.TabStop = false;
            // 
            // labelPrecioFinalMD2
            // 
            this.labelPrecioFinalMD2.Location = new System.Drawing.Point(570, 65);
            this.labelPrecioFinalMD2.Name = "labelPrecioFinalMD2";
            this.labelPrecioFinalMD2.Size = new System.Drawing.Size(72, 16);
            this.labelPrecioFinalMD2.TabIndex = 1853;
            this.labelPrecioFinalMD2.Text = "Moneda";
            // 
            // labelPrecioFinalMO2
            // 
            this.labelPrecioFinalMO2.Location = new System.Drawing.Point(570, 41);
            this.labelPrecioFinalMO2.Name = "labelPrecioFinalMO2";
            this.labelPrecioFinalMO2.Size = new System.Drawing.Size(72, 16);
            this.labelPrecioFinalMO2.TabIndex = 1852;
            this.labelPrecioFinalMO2.Text = "Moneda";
            // 
            // unePrecioFinalMD2
            // 
            this.unePrecioFinalMD2.Location = new System.Drawing.Point(650, 60);
            this.unePrecioFinalMD2.Name = "unePrecioFinalMD2";
            this.unePrecioFinalMD2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMD2.ReadOnly = true;
            this.unePrecioFinalMD2.Size = new System.Drawing.Size(96, 21);
            this.unePrecioFinalMD2.TabIndex = 1851;
            this.unePrecioFinalMD2.TabStop = false;
            // 
            // unePrecioFinalMO2
            // 
            this.unePrecioFinalMO2.Location = new System.Drawing.Point(650, 35);
            this.unePrecioFinalMO2.Name = "unePrecioFinalMO2";
            this.unePrecioFinalMO2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMO2.ReadOnly = true;
            this.unePrecioFinalMO2.Size = new System.Drawing.Size(96, 21);
            this.unePrecioFinalMO2.TabIndex = 1850;
            this.unePrecioFinalMO2.TabStop = false;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(530, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 16);
            this.label16.TabIndex = 1849;
            this.label16.Text = "Precio Final Imp. Incluidos";
            // 
            // gridCondicionesDeVenta
            // 
            this.gridCondicionesDeVenta.AllowCardSizing = false;
            this.gridCondicionesDeVenta.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridCondicionesDeVenta.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridCondicionesDeVenta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridCondicionesDeVenta.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridCondicionesDeVenta.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridCondicionesDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCondicionesDeVenta.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridCondicionesDeVenta.Location = new System.Drawing.Point(10, 9);
            this.gridCondicionesDeVenta.Name = "gridCondicionesDeVenta";
            this.gridCondicionesDeVenta.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridCondicionesDeVenta.Size = new System.Drawing.Size(504, 208);
            this.gridCondicionesDeVenta.TabIndex = 1848;
            this.gridCondicionesDeVenta.TabStop = false;
            // 
            // HojaUltimaModificacionPrecios
            // 
            this.HojaUltimaModificacionPrecios.Controls.Add(this.uccFechaUltimaModifPcioVta);
            this.HojaUltimaModificacionPrecios.Controls.Add(this.uccFechaUltimaModifPcioCosto);
            this.HojaUltimaModificacionPrecios.Controls.Add(this.label17);
            this.HojaUltimaModificacionPrecios.Controls.Add(this.label18);
            this.HojaUltimaModificacionPrecios.Location = new System.Drawing.Point(4, 22);
            this.HojaUltimaModificacionPrecios.Name = "HojaUltimaModificacionPrecios";
            this.HojaUltimaModificacionPrecios.Size = new System.Drawing.Size(780, 227);
            this.HojaUltimaModificacionPrecios.TabIndex = 10;
            this.HojaUltimaModificacionPrecios.Text = "Modificación de Precios";
            // 
            // uccFechaUltimaModifPcioVta
            // 
            this.uccFechaUltimaModifPcioVta.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaUltimaModifPcioVta.DateButtons.Add(dateButton3);
            this.uccFechaUltimaModifPcioVta.Location = new System.Drawing.Point(264, 56);
            this.uccFechaUltimaModifPcioVta.Name = "uccFechaUltimaModifPcioVta";
            this.uccFechaUltimaModifPcioVta.NonAutoSizeHeight = 23;
            this.uccFechaUltimaModifPcioVta.ReadOnly = true;
            this.uccFechaUltimaModifPcioVta.Size = new System.Drawing.Size(96, 21);
            this.uccFechaUltimaModifPcioVta.TabIndex = 10;
            this.uccFechaUltimaModifPcioVta.Value = ((object)(resources.GetObject("uccFechaUltimaModifPcioVta.Value")));
            // 
            // uccFechaUltimaModifPcioCosto
            // 
            this.uccFechaUltimaModifPcioCosto.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaUltimaModifPcioCosto.DateButtons.Add(dateButton4);
            this.uccFechaUltimaModifPcioCosto.Location = new System.Drawing.Point(264, 32);
            this.uccFechaUltimaModifPcioCosto.Name = "uccFechaUltimaModifPcioCosto";
            this.uccFechaUltimaModifPcioCosto.NonAutoSizeHeight = 23;
            this.uccFechaUltimaModifPcioCosto.ReadOnly = true;
            this.uccFechaUltimaModifPcioCosto.Size = new System.Drawing.Size(96, 21);
            this.uccFechaUltimaModifPcioCosto.TabIndex = 9;
            this.uccFechaUltimaModifPcioCosto.Value = ((object)(resources.GetObject("uccFechaUltimaModifPcioCosto.Value")));
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(24, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(216, 16);
            this.label17.TabIndex = 12;
            this.label17.Text = "Fecha Última Modificación Pcio. de Venta";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(24, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(232, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "Fecha Última Modificación Pcio. de Costo";
            // 
            // HojaProductosAsociados
            // 
            this.HojaProductosAsociados.Controls.Add(this.label10);
            this.HojaProductosAsociados.Location = new System.Drawing.Point(4, 22);
            this.HojaProductosAsociados.Name = "HojaProductosAsociados";
            this.HojaProductosAsociados.Size = new System.Drawing.Size(780, 227);
            this.HojaProductosAsociados.TabIndex = 1;
            this.HojaProductosAsociados.Text = "Productos Asociados";
            this.HojaProductosAsociados.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(250, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Funcionalidad No Habilitada";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HojaStock
            // 
            this.HojaStock.Controls.Add(this.labelPrecioFinal1);
            this.HojaStock.Controls.Add(this.unePrecionFinal1);
            this.HojaStock.Controls.Add(this.label4);
            this.HojaStock.Controls.Add(this.txtDescripcion1);
            this.HojaStock.Controls.Add(this.label3);
            this.HojaStock.Controls.Add(this.gridStock);
            this.HojaStock.Location = new System.Drawing.Point(4, 22);
            this.HojaStock.Name = "HojaStock";
            this.HojaStock.Size = new System.Drawing.Size(780, 227);
            this.HojaStock.TabIndex = 0;
            this.HojaStock.Text = "Stock";
            // 
            // labelPrecioFinal1
            // 
            this.labelPrecioFinal1.Location = new System.Drawing.Point(567, 104);
            this.labelPrecioFinal1.Name = "labelPrecioFinal1";
            this.labelPrecioFinal1.Size = new System.Drawing.Size(72, 16);
            this.labelPrecioFinal1.TabIndex = 1828;
            this.labelPrecioFinal1.Text = "Moneda";
            // 
            // unePrecionFinal1
            // 
            this.unePrecionFinal1.Location = new System.Drawing.Point(642, 104);
            this.unePrecionFinal1.Name = "unePrecionFinal1";
            this.unePrecionFinal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecionFinal1.ReadOnly = true;
            this.unePrecionFinal1.Size = new System.Drawing.Size(100, 21);
            this.unePrecionFinal1.TabIndex = 1827;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(504, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 1826;
            this.label4.Text = "Precio Final Imp. Incluidos";
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Location = new System.Drawing.Point(504, 24);
            this.txtDescripcion1.Multiline = true;
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.ReadOnly = true;
            this.txtDescripcion1.Scrollbars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion1.Size = new System.Drawing.Size(240, 56);
            this.txtDescripcion1.TabIndex = 1825;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(504, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 1824;
            this.label3.Text = "Descripción";
            // 
            // gridStock
            // 
            this.gridStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridStock.DataSource = this.ultraDataSource1;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn4.Header.VisiblePosition = 0;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn5.Header.VisiblePosition = 1;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn6.Header.VisiblePosition = 2;
            ultraGridBand2.Columns.AddRange(new object[] {
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            ultraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn7.Header.VisiblePosition = 0;
            ultraGridColumn8.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn8.Header.VisiblePosition = 1;
            ultraGridBand3.Columns.AddRange(new object[] {
            ultraGridColumn7,
            ultraGridColumn8});
            this.gridStock.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.gridStock.DisplayLayout.BandsSerializer.Add(ultraGridBand2);
            this.gridStock.DisplayLayout.BandsSerializer.Add(ultraGridBand3);
            this.gridStock.Location = new System.Drawing.Point(8, 8);
            this.gridStock.Name = "gridStock";
            this.gridStock.Size = new System.Drawing.Size(480, 208);
            this.gridStock.TabIndex = 1815;
            this.gridStock.Text = "Stock";
            // 
            // ultraDataSource1
            // 
            ultraDataColumn8.DataType = typeof(decimal);
            ultraDataBand4.Columns.AddRange(new object[] {
            ultraDataColumn7,
            ultraDataColumn8});
            ultraDataBand3.ChildBands.AddRange(new object[] {
            ultraDataBand4});
            ultraDataColumn10.DataType = typeof(decimal);
            ultraDataBand3.Columns.AddRange(new object[] {
            ultraDataColumn9,
            ultraDataColumn10});
            this.ultraDataSource1.Band.ChildBands.AddRange(new object[] {
            ultraDataBand3});
            ultraDataColumn12.DataType = typeof(decimal);
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn11,
            ultraDataColumn12});
            // 
            // HojaMedidas
            // 
            this.HojaMedidas.Controls.Add(this.label12);
            this.HojaMedidas.Location = new System.Drawing.Point(4, 22);
            this.HojaMedidas.Name = "HojaMedidas";
            this.HojaMedidas.Size = new System.Drawing.Size(780, 227);
            this.HojaMedidas.TabIndex = 2;
            this.HojaMedidas.Text = "Medidas y Conversiones";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(250, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Funcionalidad No Habilitada";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HojaPreciosMediosDePago
            // 
            this.HojaPreciosMediosDePago.Controls.Add(this.labelPrecioFinalMD1);
            this.HojaPreciosMediosDePago.Controls.Add(this.labelPrecioFinalMO1);
            this.HojaPreciosMediosDePago.Controls.Add(this.unePrecioFinalMD1);
            this.HojaPreciosMediosDePago.Controls.Add(this.unePrecioFinalMO1);
            this.HojaPreciosMediosDePago.Controls.Add(this.label13);
            this.HojaPreciosMediosDePago.Controls.Add(this.gridFormasDePago);
            this.HojaPreciosMediosDePago.Location = new System.Drawing.Point(4, 22);
            this.HojaPreciosMediosDePago.Name = "HojaPreciosMediosDePago";
            this.HojaPreciosMediosDePago.Size = new System.Drawing.Size(780, 227);
            this.HojaPreciosMediosDePago.TabIndex = 5;
            this.HojaPreciosMediosDePago.Text = "Precios por Medio de Pago";
            // 
            // labelPrecioFinalMD1
            // 
            this.labelPrecioFinalMD1.Location = new System.Drawing.Point(568, 64);
            this.labelPrecioFinalMD1.Name = "labelPrecioFinalMD1";
            this.labelPrecioFinalMD1.Size = new System.Drawing.Size(72, 16);
            this.labelPrecioFinalMD1.TabIndex = 1847;
            this.labelPrecioFinalMD1.Text = "Moneda";
            // 
            // labelPrecioFinalMO1
            // 
            this.labelPrecioFinalMO1.Location = new System.Drawing.Point(568, 40);
            this.labelPrecioFinalMO1.Name = "labelPrecioFinalMO1";
            this.labelPrecioFinalMO1.Size = new System.Drawing.Size(72, 16);
            this.labelPrecioFinalMO1.TabIndex = 1846;
            this.labelPrecioFinalMO1.Text = "Moneda";
            // 
            // unePrecioFinalMD1
            // 
            this.unePrecioFinalMD1.Location = new System.Drawing.Point(648, 59);
            this.unePrecioFinalMD1.Name = "unePrecioFinalMD1";
            this.unePrecioFinalMD1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMD1.ReadOnly = true;
            this.unePrecioFinalMD1.Size = new System.Drawing.Size(96, 21);
            this.unePrecioFinalMD1.TabIndex = 1845;
            // 
            // unePrecioFinalMO1
            // 
            this.unePrecioFinalMO1.Location = new System.Drawing.Point(648, 34);
            this.unePrecioFinalMO1.Name = "unePrecioFinalMO1";
            this.unePrecioFinalMO1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioFinalMO1.ReadOnly = true;
            this.unePrecioFinalMO1.Size = new System.Drawing.Size(96, 21);
            this.unePrecioFinalMO1.TabIndex = 1843;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(528, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 16);
            this.label13.TabIndex = 1842;
            this.label13.Text = "Precio Final Imp. Incluidos";
            // 
            // gridFormasDePago
            // 
            this.gridFormasDePago.AllowCardSizing = false;
            this.gridFormasDePago.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridFormasDePago.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridFormasDePago.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridFormasDePago.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridFormasDePago.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridFormasDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridFormasDePago.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridFormasDePago.Location = new System.Drawing.Point(8, 8);
            this.gridFormasDePago.Name = "gridFormasDePago";
            this.gridFormasDePago.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridFormasDePago.Size = new System.Drawing.Size(504, 208);
            this.gridFormasDePago.TabIndex = 4;
            this.gridFormasDePago.TabStop = false;
            // 
            // HojaProductosPendientesEntrega
            // 
            this.HojaProductosPendientesEntrega.Controls.Add(this.gridManagerView2);
            this.HojaProductosPendientesEntrega.Controls.Add(this.gridPpp);
            this.HojaProductosPendientesEntrega.Location = new System.Drawing.Point(4, 22);
            this.HojaProductosPendientesEntrega.Name = "HojaProductosPendientesEntrega";
            this.HojaProductosPendientesEntrega.Size = new System.Drawing.Size(780, 227);
            this.HojaProductosPendientesEntrega.TabIndex = 9;
            this.HojaProductosPendientesEntrega.Text = "Pendientes de Recepcion";
            // 
            // gridManagerView2
            // 
            this.gridManagerView2.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView2.Location = new System.Drawing.Point(208, 24);
            this.gridManagerView2.Name = "gridManagerView2";
            this.gridManagerView2.Size = new System.Drawing.Size(536, 24);
            this.gridManagerView2.TabIndex = 12;
            this.gridManagerView2.Visible = false;
            // 
            // gridPpp
            // 
            this.gridPpp.AllowCardSizing = false;
            this.gridPpp.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridPpp.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridPpp.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPpp.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridPpp.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridPpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPpp.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridPpp.Location = new System.Drawing.Point(8, 10);
            this.gridPpp.Name = "gridPpp";
            this.gridPpp.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridPpp.Size = new System.Drawing.Size(600, 208);
            this.gridPpp.TabIndex = 5;
            this.gridPpp.TabStop = false;
            // 
            // HojaLinks
            // 
            this.HojaLinks.Controls.Add(this.linkLabel5);
            this.HojaLinks.Controls.Add(this.linkLabel4);
            this.HojaLinks.Controls.Add(this.linkLabel3);
            this.HojaLinks.Controls.Add(this.linkLabel2);
            this.HojaLinks.Controls.Add(this.linkLabel1);
            this.HojaLinks.Location = new System.Drawing.Point(4, 22);
            this.HojaLinks.Name = "HojaLinks";
            this.HojaLinks.Size = new System.Drawing.Size(780, 227);
            this.HojaLinks.TabIndex = 8;
            this.HojaLinks.Text = "Links";
            // 
            // linkLabel5
            // 
            this.linkLabel5.Location = new System.Drawing.Point(24, 144);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(736, 24);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "linkLabel5";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Location = new System.Drawing.Point(24, 112);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(736, 24);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "linkLabel4";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Location = new System.Drawing.Point(24, 80);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(736, 24);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(24, 48);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(736, 24);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(24, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(736, 24);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel2";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HojaImagenes
            // 
            this.HojaImagenes.Location = new System.Drawing.Point(4, 22);
            this.HojaImagenes.Name = "HojaImagenes";
            this.HojaImagenes.Size = new System.Drawing.Size(780, 227);
            this.HojaImagenes.TabIndex = 7;
            this.HojaImagenes.Text = "Imágenes";
            // 
            // HojaAgrupamientos
            // 
            this.HojaAgrupamientos.Controls.Add(this.label11);
            this.HojaAgrupamientos.Location = new System.Drawing.Point(4, 22);
            this.HojaAgrupamientos.Name = "HojaAgrupamientos";
            this.HojaAgrupamientos.Size = new System.Drawing.Size(780, 227);
            this.HojaAgrupamientos.TabIndex = 3;
            this.HojaAgrupamientos.Text = "Agrupamientos";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(250, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Funcionalidad No Habilitada";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HojaDetalleCombo
            // 
            this.HojaDetalleCombo.Controls.Add(this.gridDetalleCombo);
            this.HojaDetalleCombo.Controls.Add(this.gridManagerView4);
            this.HojaDetalleCombo.Location = new System.Drawing.Point(4, 22);
            this.HojaDetalleCombo.Name = "HojaDetalleCombo";
            this.HojaDetalleCombo.Size = new System.Drawing.Size(780, 227);
            this.HojaDetalleCombo.TabIndex = 12;
            this.HojaDetalleCombo.Text = "Detalle Combo";
            this.HojaDetalleCombo.UseVisualStyleBackColor = true;
            // 
            // gridDetalleCombo
            // 
            this.gridDetalleCombo.AllowCardSizing = false;
            this.gridDetalleCombo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridDetalleCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDetalleCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetalleCombo.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridDetalleCombo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridDetalleCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetalleCombo.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridDetalleCombo.Location = new System.Drawing.Point(0, 0);
            this.gridDetalleCombo.Name = "gridDetalleCombo";
            this.gridDetalleCombo.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridDetalleCombo.Size = new System.Drawing.Size(780, 227);
            this.gridDetalleCombo.TabIndex = 1854;
            this.gridDetalleCombo.TabStop = false;
            // 
            // gridManagerView4
            // 
            this.gridManagerView4.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView4.Location = new System.Drawing.Point(-17, 101);
            this.gridManagerView4.Name = "gridManagerView4";
            this.gridManagerView4.Size = new System.Drawing.Size(814, 24);
            this.gridManagerView4.TabIndex = 1853;
            this.gridManagerView4.Visible = false;
            // 
            // tabBonificaciones
            // 
            this.tabBonificaciones.Controls.Add(this.gridBonificaciones);
            this.tabBonificaciones.Controls.Add(this.label23);
            this.tabBonificaciones.Controls.Add(this.label24);
            this.tabBonificaciones.Controls.Add(this.mzCEBonificacion);
            this.tabBonificaciones.Location = new System.Drawing.Point(4, 22);
            this.tabBonificaciones.Name = "tabBonificaciones";
            this.tabBonificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabBonificaciones.Size = new System.Drawing.Size(780, 227);
            this.tabBonificaciones.TabIndex = 13;
            this.tabBonificaciones.Text = "Bonificaciones";
            this.tabBonificaciones.UseVisualStyleBackColor = true;
            // 
            // gridBonificaciones
            // 
            this.gridBonificaciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridBonificaciones.AlternatingColors = true;
            this.gridBonificaciones.AutomaticSort = false;
            this.gridBonificaciones.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridBonificaciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridBonificaciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridBonificaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridBonificaciones.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridBonificaciones.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridBonificaciones.GroupByBoxVisible = false;
            this.gridBonificaciones.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridBonificaciones.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridBonificaciones.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridBonificaciones.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridBonificaciones.Location = new System.Drawing.Point(77, 40);
            this.gridBonificaciones.Name = "gridBonificaciones";
            this.gridBonificaciones.RecordNavigator = true;
            this.gridBonificaciones.RecordNavigatorText = "Registro:|de";
            this.gridBonificaciones.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridBonificaciones.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridBonificaciones.ShowEmptyFields = false;
            this.gridBonificaciones.Size = new System.Drawing.Size(697, 181);
            this.gridBonificaciones.TabIndex = 82;
            this.gridBonificaciones.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(6, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 34);
            this.label23.TabIndex = 81;
            this.label23.Text = "Detalle de Bonificacion";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(6, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 23);
            this.label24.TabIndex = 80;
            this.label24.Text = "Bonificacion";
            // 
            // mzCEBonificacion
            // 
            this.mzCEBonificacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEBonificacion.DisplayMember = "";
            this.mzCEBonificacion.DisplayMemberCaption = "";
            this.mzCEBonificacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEBonificacion.ImageTransparentColor = System.Drawing.Color.Violet;
            this.mzCEBonificacion.Location = new System.Drawing.Point(77, 13);
            this.mzCEBonificacion.MaxItemsDisplay = 7;
            this.mzCEBonificacion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEBonificacion.Name = "mzCEBonificacion";
            this.mzCEBonificacion.Size = new System.Drawing.Size(214, 21);
            this.mzCEBonificacion.SorterMember = "";
            this.mzCEBonificacion.TabIndex = 79;
            this.mzCEBonificacion.ValueMember = "";
            this.mzCEBonificacion.ValueMemberCaption = "";
            // 
            // txtCampoAuxiliar6
            // 
            this.txtCampoAuxiliar6.Location = new System.Drawing.Point(0, 0);
            this.txtCampoAuxiliar6.Name = "txtCampoAuxiliar6";
            this.txtCampoAuxiliar6.Size = new System.Drawing.Size(100, 21);
            this.txtCampoAuxiliar6.TabIndex = 0;
            // 
            // labelCampoAuxiliar6
            // 
            this.labelCampoAuxiliar6.Location = new System.Drawing.Point(0, 0);
            this.labelCampoAuxiliar6.Name = "labelCampoAuxiliar6";
            this.labelCampoAuxiliar6.Size = new System.Drawing.Size(100, 23);
            this.labelCampoAuxiliar6.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.HojaBuscadorGenerico);
            this.tabControl2.Controls.Add(this.HojaBuscadorJerarquico);
            this.tabControl2.Controls.Add(this.HojaBuscadorAuxiliares);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 26);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(794, 120);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.TabStop = false;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // HojaBuscadorGenerico
            // 
            this.HojaBuscadorGenerico.Controls.Add(this.chkPermiteCambio);
            this.HojaBuscadorGenerico.Controls.Add(this.mzCTipoProducto);
            this.HojaBuscadorGenerico.Controls.Add(this.txtSearchCodProveedor);
            this.HojaBuscadorGenerico.Controls.Add(this.label22);
            this.HojaBuscadorGenerico.Controls.Add(this.label21);
            this.HojaBuscadorGenerico.Controls.Add(this.uceEntreFechas);
            this.HojaBuscadorGenerico.Controls.Add(this.udtFechaAltaHasta);
            this.HojaBuscadorGenerico.Controls.Add(this.udtFechaAltaDesde);
            this.HojaBuscadorGenerico.Controls.Add(this.lFecha);
            this.HojaBuscadorGenerico.Controls.Add(this.uceResponsable);
            this.HojaBuscadorGenerico.Controls.Add(this.mzCEResponsable);
            this.HojaBuscadorGenerico.Controls.Add(this.label20);
            this.HojaBuscadorGenerico.Controls.Add(this.label15);
            this.HojaBuscadorGenerico.Controls.Add(this.label14);
            this.HojaBuscadorGenerico.Controls.Add(this.chkActivo);
            this.HojaBuscadorGenerico.Controls.Add(this.txtSearchDescripcion);
            this.HojaBuscadorGenerico.Controls.Add(this.txtSearchCodigo);
            this.HojaBuscadorGenerico.Controls.Add(this.txtSearchCodigoSec);
            this.HojaBuscadorGenerico.Controls.Add(this.label1);
            this.HojaBuscadorGenerico.Controls.Add(this.label2);
            this.HojaBuscadorGenerico.Controls.Add(this.labelCodigoSec);
            this.HojaBuscadorGenerico.Controls.Add(this.mzComboListaDePrecios);
            this.HojaBuscadorGenerico.Controls.Add(this.cboTipoDePrecioDeCosto);
            this.HojaBuscadorGenerico.Location = new System.Drawing.Point(4, 22);
            this.HojaBuscadorGenerico.Name = "HojaBuscadorGenerico";
            this.HojaBuscadorGenerico.Size = new System.Drawing.Size(786, 94);
            this.HojaBuscadorGenerico.TabIndex = 0;
            this.HojaBuscadorGenerico.Text = "Buscador genérico";
            this.HojaBuscadorGenerico.Click += new System.EventHandler(this.HojaBuscadorGenerico_Click);
            // 
            // chkPermiteCambio
            // 
            this.chkPermiteCambio.Checked = true;
            this.chkPermiteCambio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPermiteCambio.Location = new System.Drawing.Point(699, 3);
            this.chkPermiteCambio.Name = "chkPermiteCambio";
            this.chkPermiteCambio.Size = new System.Drawing.Size(78, 24);
            this.chkPermiteCambio.TabIndex = 1827;
            this.chkPermiteCambio.Text = "P/Cambio";
            // 
            // mzCTipoProducto
            // 
            this.mzCTipoProducto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCTipoProducto.DisplayMember = "";
            this.mzCTipoProducto.DisplayMemberCaption = "";
            this.mzCTipoProducto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCTipoProducto.Location = new System.Drawing.Point(158, 47);
            this.mzCTipoProducto.MaxItemsDisplay = 7;
            this.mzCTipoProducto.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCTipoProducto.Name = "mzCTipoProducto";
            this.mzCTipoProducto.Size = new System.Drawing.Size(144, 21);
            this.mzCTipoProducto.SorterMember = "";
            this.mzCTipoProducto.TabIndex = 1826;
            this.mzCTipoProducto.ValueMember = "";
            this.mzCTipoProducto.ValueMemberCaption = "";
            // 
            // txtSearchCodProveedor
            // 
            this.txtSearchCodProveedor.Location = new System.Drawing.Point(563, 25);
            this.txtSearchCodProveedor.Name = "txtSearchCodProveedor";
            this.txtSearchCodProveedor.Size = new System.Drawing.Size(130, 21);
            this.txtSearchCodProveedor.TabIndex = 1825;
            this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCodProveedor, false);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(469, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 16);
            this.label22.TabIndex = 1824;
            this.label22.Text = "Codigo Proveedor";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(120, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 16);
            this.label21.TabIndex = 1823;
            this.label21.Text = "Tipo";
            // 
            // uceEntreFechas
            // 
            this.uceEntreFechas.BackColor = System.Drawing.Color.Transparent;
            this.uceEntreFechas.BackColorInternal = System.Drawing.Color.Transparent;
            this.uceEntreFechas.Location = new System.Drawing.Point(700, 74);
            this.uceEntreFechas.Name = "uceEntreFechas";
            this.uceEntreFechas.Size = new System.Drawing.Size(13, 15);
            this.uceEntreFechas.TabIndex = 10;
            // 
            // udtFechaAltaHasta
            // 
            this.udtFechaAltaHasta.Location = new System.Drawing.Point(590, 71);
            this.udtFechaAltaHasta.Name = "udtFechaAltaHasta";
            this.udtFechaAltaHasta.Size = new System.Drawing.Size(104, 21);
            this.udtFechaAltaHasta.TabIndex = 9;
            // 
            // udtFechaAltaDesde
            // 
            this.udtFechaAltaDesde.Location = new System.Drawing.Point(472, 71);
            this.udtFechaAltaDesde.Name = "udtFechaAltaDesde";
            this.udtFechaAltaDesde.Size = new System.Drawing.Size(104, 21);
            this.udtFechaAltaDesde.TabIndex = 8;
            // 
            // lFecha
            // 
            this.lFecha.BackColor = System.Drawing.Color.Transparent;
            this.lFecha.Location = new System.Drawing.Point(360, 73);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(104, 16);
            this.lFecha.TabIndex = 1820;
            this.lFecha.Text = "Fecha de alta";
            this.lFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uceResponsable
            // 
            this.uceResponsable.BackColor = System.Drawing.Color.Transparent;
            this.uceResponsable.BackColorInternal = System.Drawing.Color.Transparent;
            this.uceResponsable.Location = new System.Drawing.Point(308, 74);
            this.uceResponsable.Name = "uceResponsable";
            this.uceResponsable.Size = new System.Drawing.Size(16, 16);
            this.uceResponsable.TabIndex = 5;
            // 
            // mzCEResponsable
            // 
            this.mzCEResponsable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsable.DisplayMember = "";
            this.mzCEResponsable.DisplayMemberCaption = "";
            this.mzCEResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsable.Location = new System.Drawing.Point(80, 71);
            this.mzCEResponsable.MaxItemsDisplay = 7;
            this.mzCEResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsable.Name = "mzCEResponsable";
            this.mzCEResponsable.Size = new System.Drawing.Size(222, 21);
            this.mzCEResponsable.SorterMember = "";
            this.mzCEResponsable.TabIndex = 4;
            this.mzCEResponsable.ValueMember = "";
            this.mzCEResponsable.ValueMemberCaption = "";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 16);
            this.label20.TabIndex = 1816;
            this.label20.Text = "Resp. de alta";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(360, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 16);
            this.label15.TabIndex = 1813;
            this.label15.Text = "Lista de Precios";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 1811;
            this.label14.Text = "Activo";
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(80, 47);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(17, 24);
            this.chkActivo.TabIndex = 2;
            // 
            // txtSearchDescripcion
            // 
            this.txtSearchDescripcion.Location = new System.Drawing.Point(80, 3);
            this.txtSearchDescripcion.Name = "txtSearchDescripcion";
            this.txtSearchDescripcion.Size = new System.Drawing.Size(614, 21);
            this.txtSearchDescripcion.TabIndex = 0;
            this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchDescripcion, false);
            // 
            // txtSearchCodigo
            // 
            this.txtSearchCodigo.Location = new System.Drawing.Point(80, 25);
            this.txtSearchCodigo.Name = "txtSearchCodigo";
            this.txtSearchCodigo.Size = new System.Drawing.Size(155, 21);
            this.txtSearchCodigo.TabIndex = 1;
            this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCodigo, false);
            // 
            // txtSearchCodigoSec
            // 
            this.txtSearchCodigoSec.Location = new System.Drawing.Point(337, 25);
            this.txtSearchCodigoSec.Name = "txtSearchCodigoSec";
            this.txtSearchCodigoSec.Size = new System.Drawing.Size(129, 21);
            this.txtSearchCodigoSec.TabIndex = 6;
            this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCodigoSec, false);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1806;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1807;
            this.label2.Text = "Código";
            // 
            // labelCodigoSec
            // 
            this.labelCodigoSec.Location = new System.Drawing.Point(241, 32);
            this.labelCodigoSec.Name = "labelCodigoSec";
            this.labelCodigoSec.Size = new System.Drawing.Size(104, 16);
            this.labelCodigoSec.TabIndex = 1809;
            this.labelCodigoSec.Text = "Codigo secundario";
            // 
            // mzComboListaDePrecios
            // 
            this.mzComboListaDePrecios.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboListaDePrecios.DisplayMember = "";
            this.mzComboListaDePrecios.DisplayMemberCaption = "";
            this.mzComboListaDePrecios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboListaDePrecios.Location = new System.Drawing.Point(472, 48);
            this.mzComboListaDePrecios.MaxItemsDisplay = 7;
            this.mzComboListaDePrecios.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboListaDePrecios.Name = "mzComboListaDePrecios";
            this.mzComboListaDePrecios.Size = new System.Drawing.Size(221, 21);
            this.mzComboListaDePrecios.SorterMember = "";
            this.mzComboListaDePrecios.TabIndex = 7;
            this.mzComboListaDePrecios.ValueMember = "";
            this.mzComboListaDePrecios.ValueMemberCaption = "";
            // 
            // cboTipoDePrecioDeCosto
            // 
            this.cboTipoDePrecioDeCosto.Location = new System.Drawing.Point(472, 48);
            this.cboTipoDePrecioDeCosto.Name = "cboTipoDePrecioDeCosto";
            this.cboTipoDePrecioDeCosto.Size = new System.Drawing.Size(222, 21);
            this.cboTipoDePrecioDeCosto.TabIndex = 7;
            this.cboTipoDePrecioDeCosto.Tag = "TiposDeComprobantes";
            this.cboTipoDePrecioDeCosto.Visible = false;
            // 
            // HojaBuscadorJerarquico
            // 
            this.HojaBuscadorJerarquico.Controls.Add(this.hierarchicalSearchControl1);
            this.HojaBuscadorJerarquico.Location = new System.Drawing.Point(4, 22);
            this.HojaBuscadorJerarquico.Name = "HojaBuscadorJerarquico";
            this.HojaBuscadorJerarquico.Size = new System.Drawing.Size(786, 94);
            this.HojaBuscadorJerarquico.TabIndex = 1;
            this.HojaBuscadorJerarquico.Text = "Buscador jerárquico";
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.SystemColors.Control;
            this.hierarchicalSearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(786, 96);
            this.hierarchicalSearchControl1.TabIndex = 9;
            // 
            // HojaBuscadorAuxiliares
            // 
            this.HojaBuscadorAuxiliares.Controls.Add(this.labelFiltroCampoAuxiliar6);
            this.HojaBuscadorAuxiliares.Controls.Add(this.txtSearchCampoAuxiliar5);
            this.HojaBuscadorAuxiliares.Controls.Add(this.txtSearchCampoAuxiliar4);
            this.HojaBuscadorAuxiliares.Controls.Add(this.labelFiltroCampoAuxiliar5);
            this.HojaBuscadorAuxiliares.Controls.Add(this.labelFiltroCampoAuxiliar4);
            this.HojaBuscadorAuxiliares.Controls.Add(this.txtSearchCampoAuxiliar3);
            this.HojaBuscadorAuxiliares.Controls.Add(this.labelFiltroCampoAuxiliar3);
            this.HojaBuscadorAuxiliares.Controls.Add(this.txtSearchCampoAuxiliar2);
            this.HojaBuscadorAuxiliares.Controls.Add(this.txtSearchCampoAuxiliar1);
            this.HojaBuscadorAuxiliares.Controls.Add(this.labelFiltroCampoAuxiliar2);
            this.HojaBuscadorAuxiliares.Controls.Add(this.labelFiltroCampoAuxiliar1);
            this.HojaBuscadorAuxiliares.Controls.Add(this.mzSearchTextBox1);
            this.HojaBuscadorAuxiliares.Location = new System.Drawing.Point(4, 22);
            this.HojaBuscadorAuxiliares.Name = "HojaBuscadorAuxiliares";
            this.HojaBuscadorAuxiliares.Size = new System.Drawing.Size(786, 94);
            this.HojaBuscadorAuxiliares.TabIndex = 2;
            this.HojaBuscadorAuxiliares.Text = "Buscador campos auxiliares";
            // 
            // labelFiltroCampoAuxiliar6
            // 
            this.labelFiltroCampoAuxiliar6.Location = new System.Drawing.Point(392, 56);
            this.labelFiltroCampoAuxiliar6.Name = "labelFiltroCampoAuxiliar6";
            this.labelFiltroCampoAuxiliar6.Size = new System.Drawing.Size(104, 23);
            this.labelFiltroCampoAuxiliar6.TabIndex = 13;
            this.labelFiltroCampoAuxiliar6.Text = "CampoAuxiliar6";
            // 
            // txtSearchCampoAuxiliar5
            // 
            this.txtSearchCampoAuxiliar5.Location = new System.Drawing.Point(496, 32);
            this.txtSearchCampoAuxiliar5.Name = "txtSearchCampoAuxiliar5";
            this.txtSearchCampoAuxiliar5.Size = new System.Drawing.Size(232, 21);
            this.txtSearchCampoAuxiliar5.TabIndex = 4;
            // 
            // txtSearchCampoAuxiliar4
            // 
            this.txtSearchCampoAuxiliar4.Location = new System.Drawing.Point(496, 8);
            this.txtSearchCampoAuxiliar4.Name = "txtSearchCampoAuxiliar4";
            this.txtSearchCampoAuxiliar4.Size = new System.Drawing.Size(232, 21);
            this.txtSearchCampoAuxiliar4.TabIndex = 3;
            // 
            // labelFiltroCampoAuxiliar5
            // 
            this.labelFiltroCampoAuxiliar5.Location = new System.Drawing.Point(392, 32);
            this.labelFiltroCampoAuxiliar5.Name = "labelFiltroCampoAuxiliar5";
            this.labelFiltroCampoAuxiliar5.Size = new System.Drawing.Size(100, 23);
            this.labelFiltroCampoAuxiliar5.TabIndex = 9;
            this.labelFiltroCampoAuxiliar5.Text = "Campo Auxiliar 5";
            // 
            // labelFiltroCampoAuxiliar4
            // 
            this.labelFiltroCampoAuxiliar4.Location = new System.Drawing.Point(392, 8);
            this.labelFiltroCampoAuxiliar4.Name = "labelFiltroCampoAuxiliar4";
            this.labelFiltroCampoAuxiliar4.Size = new System.Drawing.Size(100, 23);
            this.labelFiltroCampoAuxiliar4.TabIndex = 8;
            this.labelFiltroCampoAuxiliar4.Text = "Campo Auxiliar 4";
            // 
            // txtSearchCampoAuxiliar3
            // 
            this.txtSearchCampoAuxiliar3.Location = new System.Drawing.Point(120, 56);
            this.txtSearchCampoAuxiliar3.Name = "txtSearchCampoAuxiliar3";
            this.txtSearchCampoAuxiliar3.Size = new System.Drawing.Size(232, 21);
            this.txtSearchCampoAuxiliar3.TabIndex = 2;
            // 
            // labelFiltroCampoAuxiliar3
            // 
            this.labelFiltroCampoAuxiliar3.Location = new System.Drawing.Point(16, 56);
            this.labelFiltroCampoAuxiliar3.Name = "labelFiltroCampoAuxiliar3";
            this.labelFiltroCampoAuxiliar3.Size = new System.Drawing.Size(100, 23);
            this.labelFiltroCampoAuxiliar3.TabIndex = 6;
            this.labelFiltroCampoAuxiliar3.Text = "Campo Auxiliar 3";
            // 
            // txtSearchCampoAuxiliar2
            // 
            this.txtSearchCampoAuxiliar2.Location = new System.Drawing.Point(120, 32);
            this.txtSearchCampoAuxiliar2.Name = "txtSearchCampoAuxiliar2";
            this.txtSearchCampoAuxiliar2.Size = new System.Drawing.Size(232, 21);
            this.txtSearchCampoAuxiliar2.TabIndex = 1;
            // 
            // txtSearchCampoAuxiliar1
            // 
            this.txtSearchCampoAuxiliar1.Location = new System.Drawing.Point(120, 8);
            this.txtSearchCampoAuxiliar1.Name = "txtSearchCampoAuxiliar1";
            this.txtSearchCampoAuxiliar1.Size = new System.Drawing.Size(232, 21);
            this.txtSearchCampoAuxiliar1.TabIndex = 0;
            // 
            // labelFiltroCampoAuxiliar2
            // 
            this.labelFiltroCampoAuxiliar2.Location = new System.Drawing.Point(16, 32);
            this.labelFiltroCampoAuxiliar2.Name = "labelFiltroCampoAuxiliar2";
            this.labelFiltroCampoAuxiliar2.Size = new System.Drawing.Size(100, 23);
            this.labelFiltroCampoAuxiliar2.TabIndex = 1;
            this.labelFiltroCampoAuxiliar2.Text = "Campo Auxiliar 2";
            // 
            // labelFiltroCampoAuxiliar1
            // 
            this.labelFiltroCampoAuxiliar1.Location = new System.Drawing.Point(16, 8);
            this.labelFiltroCampoAuxiliar1.Name = "labelFiltroCampoAuxiliar1";
            this.labelFiltroCampoAuxiliar1.Size = new System.Drawing.Size(100, 23);
            this.labelFiltroCampoAuxiliar1.TabIndex = 0;
            this.labelFiltroCampoAuxiliar1.Text = "Campo Auxiliar 1";
            // 
            // mzSearchTextBox1
            // 
            this.mzSearchTextBox1.Location = new System.Drawing.Point(496, 56);
            this.mzSearchTextBox1.Name = "mzSearchTextBox1";
            this.mzSearchTextBox1.Size = new System.Drawing.Size(232, 24);
            this.mzSearchTextBox1.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 0;
            // 
            // gridEx
            // 
            this.gridEx.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEx.ContextMenu = this.contextMenu1;
            this.gridEx.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEx.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEx.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEx.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEx.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEx.Location = new System.Drawing.Point(3, 144);
            this.gridEx.Name = "gridEx";
            this.gridEx.RowFormatStyle.Key = "Key";
            this.gridEx.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
            this.gridEx.Size = new System.Drawing.Size(788, 193);
            this.gridEx.TabIndex = 12;
            this.gridEx.TabStop = false;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(8, 176);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(736, 24);
            this.gridManagerView1.TabIndex = 3;
            this.gridManagerView1.Visible = false;
            // 
            // mzCETipoProducto
            // 
            this.mzCETipoProducto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCETipoProducto.DisplayMember = "";
            this.mzCETipoProducto.DisplayMemberCaption = "";
            this.mzCETipoProducto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCETipoProducto.Location = new System.Drawing.Point(0, 0);
            this.mzCETipoProducto.MaxItemsDisplay = 200;
            this.mzCETipoProducto.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCETipoProducto.Name = "mzCETipoProducto";
            this.mzCETipoProducto.Size = new System.Drawing.Size(144, 21);
            this.mzCETipoProducto.SorterMember = "";
            this.mzCETipoProducto.TabIndex = 0;
            this.mzCETipoProducto.ValueMember = "";
            this.mzCETipoProducto.ValueMemberCaption = "";
            // 
            // mzProductosSearchForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(794, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridManagerView1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.gridEx);
            this.Controls.Add(this.toolBarStandar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mzProductosSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.HojaPrecios.ResumeLayout(false);
            this.HojaPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioNetoMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioNetoMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMO)).EndInit();
            this.HojaListasDePrecios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListasDePrecios)).EndInit();
            this.HojaPreciosCondicionesDeVenta.ResumeLayout(false);
            this.HojaPreciosCondicionesDeVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCondicionesDeVenta)).EndInit();
            this.HojaUltimaModificacionPrecios.ResumeLayout(false);
            this.HojaUltimaModificacionPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaUltimaModifPcioVta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaUltimaModifPcioCosto)).EndInit();
            this.HojaProductosAsociados.ResumeLayout(false);
            this.HojaStock.ResumeLayout(false);
            this.HojaStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecionFinal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            this.HojaMedidas.ResumeLayout(false);
            this.HojaPreciosMediosDePago.ResumeLayout(false);
            this.HojaPreciosMediosDePago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioFinalMO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormasDePago)).EndInit();
            this.HojaProductosPendientesEntrega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPpp)).EndInit();
            this.HojaLinks.ResumeLayout(false);
            this.HojaAgrupamientos.ResumeLayout(false);
            this.HojaDetalleCombo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleCombo)).EndInit();
            this.tabBonificaciones.ResumeLayout(false);
            this.tabBonificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBonificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCampoAuxiliar6)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.HojaBuscadorGenerico.ResumeLayout(false);
            this.HojaBuscadorGenerico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCTipoProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCodProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCodigoSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).EndInit();
            this.HojaBuscadorJerarquico.ResumeLayout(false);
            this.HojaBuscadorAuxiliares.ResumeLayout(false);
            this.HojaBuscadorAuxiliares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCampoAuxiliar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Custom Members

        private mz.erp.ui.controllers.mzProductosSearchFormController _uicontroller = new mz.erp.ui.controllers.mzProductosSearchFormController();
        public virtual void ShowDialog()
        {
            Init();
            base.ShowDialog();
        }
        public void ShowForm()
        {
            Init();
            MdiParent = mz.erp.ui.utility.Environment.MainForm;
            Show();
        }
        private void Init()
        {
            Build_UI();
            InitEvents();
            InitDataBindings();
        }
        private void Build_UI()
        {
            /*
            this.treeAgrupamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeAgrupamientos.Location = new System.Drawing.Point(0, 0);
            this.treeAgrupamientos.Size = new System.Drawing.Size(408, 284);
            this.gridExAgrupados.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridExAgrupados.Location = new System.Drawing.Point(408, 0);
            this.gridExAgrupados.Size = new System.Drawing.Size(354, 284);
            */

            //Cristian Configuracion de las imagenes  20110717
            utility.Util.LoadImagesBuscador(toolBarStandar, imglStandar);
            //Fin Cristian


            //this.hierarchicalSearchControl1.Build_UI("PRODUCTOS", _uicontroller.BuscadorJerarquicoAllowMultipleSelect);	

            this.labelCampoAuxiliar1.Text = _uicontroller.LeyendaCampoAuxiliar1;
            this.labelCampoAuxiliar2.Text = _uicontroller.LeyendaCampoAuxiliar2;
            this.labelCampoAuxiliar3.Text = _uicontroller.LeyendaCampoAuxiliar3;
            this.labelCampoAuxiliar4.Text = _uicontroller.LeyendaCampoAuxiliar4;
            this.labelCampoAuxiliar5.Text = _uicontroller.LeyendaCampoAuxiliar5;
            chkActivo.Checked = _uicontroller.Activo_Search;
            chkActivo.Enabled = _uicontroller.AllowSearchByActivo;

            DateTime d = DateTime.Now;
            this.hierarchicalSearchControl1.Build_UI("PRODUCTOS", _uicontroller.BuscadorJerarquicoAllowMultipleSelect);
            int seg = DateTime.Now.Subtract(d).Seconds;

            if (_uicontroller.LeyendaCampoAuxiliar1 != "")
            {
                labelCampoAuxiliar1.Text = _uicontroller.LeyendaCampoAuxiliar1;
                labelFiltroCampoAuxiliar1.Text = _uicontroller.LeyendaCampoAuxiliar1;
                txtSearchCampoAuxiliar1.Enabled = true;
            }
            else
            {
                txtSearchCampoAuxiliar1.Enabled = false;
            }
            if (_uicontroller.LeyendaCampoAuxiliar2 != "")
            {
                labelCampoAuxiliar2.Text = _uicontroller.LeyendaCampoAuxiliar2;
                labelFiltroCampoAuxiliar2.Text = _uicontroller.LeyendaCampoAuxiliar2;
                txtSearchCampoAuxiliar2.Enabled = true;
            }
            else
            {
                txtSearchCampoAuxiliar2.Enabled = false;
            }
            if (_uicontroller.LeyendaCampoAuxiliar3 != "")
            {
                labelCampoAuxiliar3.Text = _uicontroller.LeyendaCampoAuxiliar3;
                labelFiltroCampoAuxiliar3.Text = _uicontroller.LeyendaCampoAuxiliar3;
                txtSearchCampoAuxiliar3.Enabled = true;
            }
            else
            {
                txtSearchCampoAuxiliar3.Enabled = false;
            }
            if (_uicontroller.LeyendaCampoAuxiliar4 != "")
            {
                labelCampoAuxiliar4.Text = _uicontroller.LeyendaCampoAuxiliar4;
                labelFiltroCampoAuxiliar4.Text = _uicontroller.LeyendaCampoAuxiliar4;
                txtSearchCampoAuxiliar4.Enabled = true;
            }
            else
            {
                txtSearchCampoAuxiliar4.Enabled = false;
            }
            if (_uicontroller.LeyendaCampoAuxiliar5 != "")
            {
                labelCampoAuxiliar5.Text = _uicontroller.LeyendaCampoAuxiliar5;
                labelFiltroCampoAuxiliar5.Text = _uicontroller.LeyendaCampoAuxiliar5;
                txtSearchCampoAuxiliar5.Enabled = true;
            }
            else
            {
                txtSearchCampoAuxiliar5.Enabled = false;
            }
            this.labelCodigoSec.Text = _uicontroller.LeyendaCodigoSec;
            //this.gridEx.LayoutData = _uicontroller.LayoutGrillaBusqueda;
            this.gridFormasDePago.LayoutData = _uicontroller.LayoutFormasDePago;
            //this.gridExAgrupados.LayoutData = _uicontroller.LayoutGrillaBusquedaJerarquica;
            this.gridCondicionesDeVenta.LayoutData = _uicontroller.LayoutPreciosPorCondicionesDeVenta;

            //this.gridManagerView1.Configure(_uicontroller.GetProcessName(), _uicontroller.GetTaskName(), gridPpp, this.Text);
            this.gridPpp.LayoutData = _uicontroller.LayoutProductosPendientesRecepcion;

            //Sabrina 20100715 - Tarea 794
            gridManagerView3.Configure("ProcesoConsultarProductos", "ConsultarProductos", gridListasDePrecios, this.Text);
            //Fin Sabrina 20100715 - Tarea 794

            //Sabrina: Tarea 1081. 20110328
            gridManagerView4.Configure("ProcesoConsultarProductos", "ConsultarProductos", gridDetalleCombo, this.Text);
            //Fin Sabrina: Tarea 1081. 20110328

            /*this.treeAgrupamientos.CollapseAll();
            this.treeAgrupamientos.Nodes[0].Expanded = true;
            this.treeAgrupamientos.Nodes[0].Selected = true;
            _uicontroller.NodoExpandir( this.treeAgrupamientos.Nodes[0] );*/
            _currentGrid = this.gridEx;
            //this.txtDescripcion.Focus();

            this.unePrecioFinalMD.ReadOnly = true;
            this.unePrecioNetoMD.ReadOnly = true;
            this.unePrecioFinalMO.ReadOnly = true;
            this.unePrecioNetoMO.ReadOnly = true;
            this.unePrecionFinal1.ReadOnly = true;
            this.unePrecioFinalMO1.ReadOnly = true;
            this.unePrecioFinalMD1.ReadOnly = true;
            this.unePrecioFinalMO2.ReadOnly = true;
            this.unePrecioFinalMD2.ReadOnly = true;

            if (!_uicontroller.SolapaStockVisible) this.tabControl1.Controls.Remove(this.HojaStock);
            if (!_uicontroller.SolapaPreciosVisible) this.tabControl1.Controls.Remove(this.HojaPrecios);
            if (!_uicontroller.SolapaPreciosMediosDePagoVisible) this.tabControl1.Controls.Remove(this.HojaPreciosMediosDePago);
            if (!_uicontroller.SolapaMedidasVisible) this.tabControl1.Controls.Remove(this.HojaMedidas);
            if (!_uicontroller.SolapaAgrupamientosVisible) this.tabControl1.Controls.Remove(this.HojaAgrupamientos);
            if (!_uicontroller.SolapaProductosAsociadosVisible) this.tabControl1.Controls.Remove(this.HojaProductosAsociados);
            this.tabControl1.SelectedTab = this.HojaPreciosCondicionesDeVenta;
            if (!_uicontroller.SolapaBuscadorJerarquicoVisible) this.tabControl2.Controls.Remove(this.HojaBuscadorJerarquico);
            if (!_uicontroller.SolapaBuscadorCamposAuxiliaresVisible) this.tabControl2.Controls.Remove(this.HojaBuscadorAuxiliares);
            if (!_uicontroller.SolapaProductosPendientesEntrega) this.tabControl1.Controls.Remove(this.HojaProductosPendientesEntrega);
            if (!_uicontroller.SolapaUltimaModificacionPreciosVisible) this.tabControl1.Controls.Remove(this.HojaUltimaModificacionPrecios);
            if (!_uicontroller.SolapaImagenesVisible) this.tabControl1.Controls.Remove(this.HojaImagenes);
            if (!_uicontroller.SolapaLinksVisible) this.tabControl1.Controls.Remove(this.HojaLinks);
            

            //Sabrina 20100715 - Tarea 794
            if (!_uicontroller.SolapaListasDePreciosVisible) this.tabControl1.Controls.Remove(this.HojaListasDePrecios);
            //Fin Sabrina 20100715 - Tarea 794

            //Sabrina: Tarea 1081. 20110328
            if (!_uicontroller.SolapaDetalleComboVisible) this.tabControl1.Controls.Remove(this.HojaDetalleCombo);
            //Fin Sabrina: Tarea 1081. 20110328
            
            //German 20120208 - Tarea 0000276
            if (!_uicontroller.SolapaBonificaciones) this.tabControl1.Controls.Remove(this.tabBonificaciones);
            //German 20120208 - Tarea 0000276

            /*if (_uicontroller.HojaBuscadorJerarquicoDefault())
            {
                this.tabControl2.SelectedIndex = 1;
                //this.HojaBuscadorJerarquico.Select();
            }
            else 
            {
                this.tabControl2.SelectedIndex = 0;
            }*/


            this.KeyPreview = true;
            if (_tipoDeFormularioPadre.Equals("C"))
                gridManagerView1.Configure("ProcesoConsultarProductosCompras", "ConsultarProductosCompras", gridEx, this.Text);
            else
                gridManagerView1.Configure("ProcesoConsultarProductos", "ConsultarProductos", gridEx, this.Text);
            mzComboListaDePrecios.FillFromDataSource(_uicontroller.ListaDePrecios, _uicontroller.KeyValueListaDePrecios, _uicontroller.KeyListListaDePrecios, 100, _uicontroller.KeyListListaDePrecios);
            if (_uicontroller.IdListaDePrecio == null)
                mzComboListaDePrecios.Value = _uicontroller.IdListaDePreciosDefault;
            else
                mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecio;
            if (!_uicontroller.ListaDePreciosHabilitadas)
                mzComboListaDePrecios.Enabled = false;

            if (_uicontroller.TipoDePrecioDeCosto == null)
                cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCostoDefault;
            else
                cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCosto;



            mzCTipoProducto.FillFromDataSource(_uicontroller.ListaTiposProductos, _uicontroller.KeyValueTiposProductos, _uicontroller.KeyListTiposProductos, 100, _uicontroller.KeyListTiposProductos);
            mzCTipoProducto.Value = _uicontroller.IdTipoProducto;
            mzCTipoProducto.Enabled = _uicontroller.ListaTiposDeProductosHabilitados;
            /* Fin Silvina 20111226 - Tarea 0000241 */
            this.mzSearchTextBox1.Init(true); 
            /* Fin Silvina 20111226 - Tarea 0000241 */
            if (_uicontroller.LeyendaCampoAuxiliar6 != "")
            {
                labelCampoAuxiliar6.Text = _uicontroller.LeyendaCampoAuxiliar6;
                labelFiltroCampoAuxiliar6.Text = _uicontroller.LeyendaCampoAuxiliar6;
                mzSearchTextBox1.Enabled = true;
            }
            else
            {
                mzSearchTextBox1.Enabled = false;
            }

            // ---- Matias - Tarea 279 - Custom 8 - 20090721
            uceEntreFechas.Enabled = true;
            uceResponsable.Enabled = true;
            mzCEResponsable.Enabled = false;
            udtFechaAltaDesde.Enabled = false;
            udtFechaAltaHasta.Enabled = false;

            mzCEResponsable.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
            mzCEResponsable.Value = _uicontroller.IdResponsable;
            udtFechaAltaDesde.Value = _uicontroller.FechaAltaDesde;
            udtFechaAltaDesde.Value = _uicontroller.FechaAltaHasta;
            // ---- Fin Matias

            gridEx.RecordNavigator = true;
            /* Silvina 20110728 - Tarea 0000136 */
            chkPermiteCambio.Checked = false;
            /* Fin Silvina 20110728 - Tarea 0000136 */

            /* Silvina 20111228 - Tarea 0000237 */
            if (_uicontroller.LeyendaCampoAuxiliar6 != null && _uicontroller.LeyendaCampoAuxiliar6 != string.Empty)
            {
                gridEx.RootTable.Columns["CampoAuxiliar6"].Caption = _uicontroller.LeyendaCampoAuxiliar6;
            }
            /* Fin Silvina 20111228 - Tarea 0000237 */


            //German 20120208 - Tarea 0000276

            gridBonificaciones.LayoutData = new mz.erp.ui.forms.classes.tsa_BonificacionesDet().GetLayoutBuscadorProductos();
            mzCEBonificacion.FillFromDataSource(businessrules.tsa_Bonificaciones.GetList(null, null, mz.erp.businessrules.Constantes.TipoBonificacionProducto).tsa_Bonificaciones, "IdBonificacion", "Codigo", 100, "1", "2", "Codigo");
            mzCEBonificacion.Enabled = false;
            //gridBonificaciones.Enabled = false;
            //German 20120208 - Tarea 0000276

        }

        private void AnularEnter()
        {
            //this.acceptButton1.SetUseDefaultAcceptButton(this.gridPpp, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.gridCondicionesDeVenta, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.gridStock, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.gridFormasDePago, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.gridEx, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.hierarchicalSearchControl1, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCampoAuxiliar1, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCampoAuxiliar2, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCampoAuxiliar3, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCampoAuxiliar4, false);
            //this.acceptButton1.SetUseDefaultAcceptButton(this.txtSearchCampoAuxiliar5, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.HojaBuscadorAuxiliares, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.HojaBuscadorGenerico, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.HojaBuscadorJerarquico, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.HojaPreciosCondicionesDeVenta, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.HojaPreciosMediosDePago, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.HojaProductosAsociados, false);
            this.acceptButton1.SetUseDefaultAcceptButton(this.HojaStock, false);
        }

        private void InitEvents()
        {
            /*			treeAgrupamientos.AfterExpand+= new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.treeAgrupamientos_AfterExpand);
                        treeAgrupamientos.AfterActivate+= new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.treeAgrupamientos_AfterActivate);*/
            EventsListener();

            this.gridEx.Click += new System.EventHandler(this.gridEx_Click);
            this.gridEx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridEx_KeyDown);
            this.gridEx.DoubleClick += new System.EventHandler(this.gridEx_DoubleClick);
            this.gridEx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridEx_KeyUp);
            //this.gridExAgrupados.Click += new System.EventHandler(this.gridEx_Click);
            /*this.gridExAgrupados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridEx_KeyDown);
            this.gridExAgrupados.DoubleClick += new System.EventHandler(this.gridEx_DoubleClick);
            this.gridExAgrupados.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridEx_KeyUp);*/
            /*
            this.txtSearchCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
            this.txtSearchDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
            this.txtSearchCodigoSec.KeyDown +=new KeyEventHandler(this.InputControl_KeyDown);
			
            this.hierarchicalSearchControl1.KeyDown+=new KeyEventHandler(this.InputControl_KeyDown);
            this.gridExAgrupados.KeyDown +=new KeyEventHandler(this.InputControl_KeyDown);
            */

            this.hierarchicalSearchControl1.OnSelected += new EventHandler(hierarchicalSearchControl1_OnSelected);
            this.KeyDown += new KeyEventHandler(this.InputControl_KeyDown);
            this.Load += new EventHandler(mzProductosSearchForm_Load);

            //Cristian Tarea 935
            this.Activated += new EventHandler(mzProductosSearchForm_Activated);
            //Fin Tarea 935


            this.uceResponsable.CheckedChanged += new EventHandler(uceResponsable_CheckedChanged);
            this.uceEntreFechas.CheckedChanged += new EventHandler(uceEntreFechas_CheckedChanged);
        }

        //Cristian Tarea 935
        void mzProductosSearchForm_Activated(object sender, EventArgs e)
        {
            this.ConfigurarSolapaPorDefault();
        }
        //Fin Tarea 935

        private void EventsListener()
        {
            _uicontroller.DataSearchChanged += new System.EventHandler(this.OnGeneralChangesListener);
            _uicontroller.DataDetailChanged += new System.EventHandler(this.OnDetailChangesListener);
            _uicontroller.DataDetailHierarchyChanged += new System.EventHandler(this.OnDetailHierarchyListener);
            mzComboListaDePrecios.ValueChanged += new EventHandler(mzComboListaDePrecios_ValueChanged);

        }
        private void OnDetailChangesListener(object sender, System.EventArgs e)
        {
            gridStock.DataSource = _uicontroller.DataStock;
            gridFormasDePago.DataSource = _uicontroller.PreciosSegunFormaDePago;
            gridCondicionesDeVenta.DataSource = _uicontroller.PreciosPorCondicionDeVenta;
            gridPpp.DataSource = _uicontroller.ProductosPedidosPendientesDataSet.Tables[0];
            Infragistics.Win.UltraWinGrid.UltraGridLayout layout = gridStock.DisplayLayout;
            layout.Bands[0].Columns[0].Hidden = true;
            layout.Bands[1].Columns[0].Hidden = true;
            layout.Bands[1].Columns[1].Hidden = true;
            layout.Bands[1].Columns[2].Hidden = true;
            layout.Bands[1].Columns[3].Hidden = true;
            layout.Bands[2].Columns[0].Hidden = true;

            //Sabrina 20100715 - Tarea 794
            gridListasDePrecios.DataSource = _uicontroller.DataListasDePrecios.Tables[0];
            //Fin Sabrina 20100715 - Tarea 794

            //Sabrina: Tarea 1081. 20110328
            if (_uicontroller.EsCombo)
                gridDetalleCombo.DataSource = _uicontroller.DetalleComboDataset.Tables[0];
            else
                gridDetalleCombo.DataSource = _uicontroller.DetalleComboDataset;
            //Fin Sabrina: Tarea 1081. 20110328
            //German 20120208 - Tarea 0000276
            gridBonificaciones.DataSource = _uicontroller.BonificacionesDet;
            //German 20120208 - Tarea 0000276

        }
        private void OnGeneralChangesListener(object sender, System.EventArgs e)
        {
            this.gridEx.SetDataBinding(null, null);
            this.gridEx.SetDataBinding(_uicontroller.DataSearch, null);
            this.gridEx.Refetch();
            this.gridEx.Refresh();
            if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
                gridManagerView1.SetView(_uicontroller.DataSearch);

        }
        private void OnDetailHierarchyListener(object sender, System.EventArgs e)
        {
            /*this.gridExAgrupados.SetDataBinding( null, null );
            this.gridExAgrupados.SetDataBinding( _uicontroller.DataHierarchy, null );
            this.gridExAgrupados.Refetch();
            this.gridExAgrupados.Refresh();*/
        }
        private void InitDataBindings()
        {
            this.txtSearchCodigo.DataBindings.Add("Text", _uicontroller, "Codigo_Search");
            this.txtSearchDescripcion.DataBindings.Add("Text", _uicontroller, "Descripcion_Search");
            //Cristian Tarea 935 20101211
            this.txtSearchCodProveedor.DataBindings.Add("Text", _uicontroller, "Codigo_Proveedor");
            //Fin Tarea 935
            /* Silvina 20110105 - Tarea 1019 */
            this.txtDescripcion.DataBindings.Add("Text", _uicontroller, "Descripcion");
            /* Fin Silvina */
            this.txtDescripcion1.DataBindings.Add("Text", _uicontroller, "Descripcion");
            this.txtObservaciones.DataBindings.Add("Text", _uicontroller, "Observaciones");
            this.txtCampoAuxiliar1.DataBindings.Add("Text", _uicontroller, "ValorCampoAuxiliar1");
            this.txtCampoAuxiliar2.DataBindings.Add("Text", _uicontroller, "ValorCampoAuxiliar2");
            this.txtCampoAuxiliar3.DataBindings.Add("Text", _uicontroller, "ValorCampoAuxiliar3");
            this.txtCampoAuxiliar4.DataBindings.Add("Text", _uicontroller, "ValorCampoAuxiliar4");
            this.txtCampoAuxiliar5.DataBindings.Add("Text", _uicontroller, "ValorCampoAuxiliar5");
            this.txtCampoAuxiliar6.DataBindings.Add("Text", _uicontroller, "ValorCampoAuxiliar6");
            this.unePrecionFinal1.DataBindings.Add("Value", _uicontroller, "PrecioFinalImpuestosIncluidos");
            this.labelPrecioFinal1.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioFinalMO");
            this.labelPrecioFinalMD.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioFinalMD");
            this.labelPrecioFinalMO.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioFinalMO");
            this.labelPrecioNetoMD.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioNetoMD");
            this.labelPrecioNetoMO.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioNetoMO");
            this.labelPrecioFinalMD1.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioFinalMD");
            this.labelPrecioFinalMO1.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioFinalMO");
            this.labelPrecioFinalMD2.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioFinalMD");
            this.labelPrecioFinalMO2.DataBindings.Add("Text", _uicontroller, "LeyendaPrecioFinalMO");
            //this.unePrecioFinalMD.DataBindings.Add( "Value", _uicontroller, "PrecioFinalMD" );
            this.unePrecioFinalMD.DataBindings.Add("Value", _uicontroller, "PrecioFinalMDRecargoCV");
            //this.unePrecioFinalMO.DataBindings.Add( "Value", _uicontroller, "PrecioFinalMO");
            this.unePrecioFinalMO.DataBindings.Add("Value", _uicontroller, "PrecioFinalMORecargoCV");
            //this.unePrecioNetoMD.DataBindings.Add( "Value", _uicontroller, "PrecioNetoMD");
            this.unePrecioNetoMO.DataBindings.Add("Value", _uicontroller, "PrecioDeVentaBrutoMORecargoCondicionDeVenta");
            //this.unePrecioNetoMO.DataBindings.Add( "Value", _uicontroller, "PrecioNetoMO");
            this.unePrecioNetoMD.DataBindings.Add("Value", _uicontroller, "PrecioDeVentaBrutoMDRecargoCondicionDeVenta");
            //this.unePrecioFinalMD1.DataBindings.Add("Value",_uicontroller, "PrecioFinalMD");
            this.unePrecioFinalMD1.DataBindings.Add("Value", _uicontroller, "PrecioFinalMDRecargoCV");
            //this.unePrecioFinalMO1.DataBindings.Add("Value",_uicontroller, "PrecioFinalMO");
            this.unePrecioFinalMO1.DataBindings.Add("Value", _uicontroller, "PrecioFinalMORecargoCV");
            //this.unePrecioFinalMD2.DataBindings.Add("Value",_uicontroller, "PrecioFinalMD");
            this.unePrecioFinalMD2.DataBindings.Add("Value", _uicontroller, "PrecioFinalMDRecargoCV");
            //this.unePrecioFinalMO2.DataBindings.Add("Value",_uicontroller, "PrecioFinalMO");
            this.unePrecioFinalMO2.DataBindings.Add("Value", _uicontroller, "PrecioFinalMORecargoCV");

            this.linkLabel1.DataBindings.Add("Text", _uicontroller, "Link1");
            this.linkLabel2.DataBindings.Add("Text", _uicontroller, "Link2");
            this.linkLabel3.DataBindings.Add("Text", _uicontroller, "Link3");
            this.linkLabel4.DataBindings.Add("Text", _uicontroller, "Link4");
            this.linkLabel5.DataBindings.Add("Text", _uicontroller, "Link5");

            //this.pictureBoxThumb.DataBindings.Add("Image", _uicontroller, "Thumb");
            //German 20120208 - Tarea 0000276
            mzCEBonificacion.DataBindings.Add("Value", _uicontroller, "IdBonificacion");
            //German 20120208 - Tarea 0000276


        }

        #endregion

        private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            switch (toolBarStandar.Buttons.IndexOf(e.Button))
            {
                case 0:
                    this.SearchNow();
                    break;
                case 1:
                    this.NewSearch();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Detail();
                    break;
                case 5:
                    break;
            }

        }


        private void SearchNow()
        {
            _uicontroller.Codigo_Search = this.txtSearchCodigo.Text;
            _uicontroller.CodigoSec_Search = this.txtSearchCodigoSec.Text;
            //Cristian Tarea 935
            _uicontroller.Codigo_Proveedor = this.txtSearchCodProveedor.Text;
            //Fin Tarea 935
            _uicontroller.Descripcion_Search = this.txtSearchDescripcion.Text;
            _uicontroller.CampoAuxiliar1_Search = this.txtSearchCampoAuxiliar1.Text;
            _uicontroller.CampoAuxiliar2_Search = this.txtSearchCampoAuxiliar2.Text;
            _uicontroller.CampoAuxiliar3_Search = this.txtSearchCampoAuxiliar3.Text;
            _uicontroller.CampoAuxiliar4_Search = this.txtSearchCampoAuxiliar4.Text;
            _uicontroller.CampoAuxiliar5_Search = this.txtSearchCampoAuxiliar5.Text;
            _uicontroller.CampoAuxiliar6_Search = this.mzSearchTextBox1.NodeDescription;
            _uicontroller.Activo_Search = this.chkActivo.Checked;
            _uicontroller.IdListaDePrecio_Search = (string)mzComboListaDePrecios.Value;
            _uicontroller.TipoDePrecioDeCosto_Search = cboTipoDePrecioDeCosto.Text;

            //German 20090916
            _uicontroller.IdTipoProducto = Convert.ToString(mzCTipoProducto.Value);
            //German 20090916


            _uicontroller.IdResponsable = Convert.ToString(mzCEResponsable.Value);
            _uicontroller.FechaAltaDesde = Convert.ToDateTime(udtFechaAltaDesde.Value);
            _uicontroller.FechaAltaHasta = Convert.ToDateTime(udtFechaAltaHasta.Value);

            /* Silvina 20110704 - Tarea 0000136 */
            _uicontroller.PermiteCambio = chkPermiteCambio.Checked;
            /* Fin Silvina 20110704 - Tarea 0000136 */

            _uicontroller.BuscarAhora();

            pictureBoxThumb.Image = _uicontroller.Thumb;


            if (_uicontroller.StockMinimoVisible)
            {
                Janus.Windows.GridEX.ConditionOperator condOp = new Janus.Windows.GridEX.ConditionOperator();
                switch (_uicontroller.Condicion)
                {
                    case "<":
                        condOp = Janus.Windows.GridEX.ConditionOperator.LessThan;
                        break;
                    case "<=":
                        condOp = Janus.Windows.GridEX.ConditionOperator.LessThanOrEqualTo;
                        break;
                    default:
                        condOp = Janus.Windows.GridEX.ConditionOperator.LessThanOrEqualTo;
                        break;
                }
                Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition(gridEx.RootTable.Columns["StockAntesMinimo"], condOp, (object)_uicontroller.Valor);
                cnd.FormatStyle.ForeColor = _uicontroller.Color;
                gridEx.RootTable.FormatConditions.Add(cnd);

                /*				Janus.Windows.GridEX.GridEXFormatCondition cnd2 = new Janus.Windows.GridEX.GridEXFormatCondition( gridExAgrupados.RootTable.Columns[ _uicontroller.Campo ], condOp, (object)_uicontroller.Valor);
                                cnd2.FormatStyle.ForeColor = _uicontroller.Color;												
                                gridExAgrupados.RootTable.FormatConditions.Add( cnd2 );*/

                /* Silvina 20110304 - Tarea 0000049 */
                if (_uicontroller.UltimaModificacionPrecioVisible)
                    FiltroUltimaModificacionPrecio(_uicontroller.ColorFecha);
                /* Fin Silvina */
            }
        }


        /* Silvina 20110304 - Tarea 0000049 */
        private void FiltroUltimaModificacionPrecio(System.Drawing.Color Color)
        {
            if (_uicontroller.CampoUltimaModificacionPrecio.Contains("FechaUltimaModificacionPrecioDeVenta"))
            {
                Janus.Windows.GridEX.ConditionOperator condFecha = Condicion(_uicontroller.CondicionFecha);
                Janus.Windows.GridEX.GridEXFormatCondition cndFecha = new Janus.Windows.GridEX.GridEXFormatCondition(gridEx.RootTable.Columns["FechaUltimaModificacionPrecioDeVenta"], condFecha, (object)System.DateTime.Today.AddDays((-1) * _uicontroller.ValorUltimaModificacionPrecio));
                cndFecha.FormatStyle.BackColor = Color;
                gridEx.RootTable.FormatConditions.Add(cndFecha);
            }
            if (_uicontroller.CampoUltimaModificacionPrecio.Contains("FechaUltimaModificacionPrecioDeCosto"))
            {
                Janus.Windows.GridEX.ConditionOperator condFechaCosto = Condicion(_uicontroller.CondicionFecha);
                Janus.Windows.GridEX.GridEXFormatCondition cndFechaCosto = new Janus.Windows.GridEX.GridEXFormatCondition(gridEx.RootTable.Columns["FechaUltimaModificacionPrecioDeCosto"], condFechaCosto, (object)System.DateTime.Today.AddDays((-1) * _uicontroller.ValorUltimaModificacionPrecio));
                cndFechaCosto.FormatStyle.BackColor = Color;
                gridEx.RootTable.FormatConditions.Add(cndFechaCosto);
            }
        }

        private Janus.Windows.GridEX.ConditionOperator Condicion(string Condicion)
        {
            Janus.Windows.GridEX.ConditionOperator condOp = new Janus.Windows.GridEX.ConditionOperator();
            switch (Condicion)
            {
                case ">":
                    condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThan;
                    break;
                case ">=":
                    condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo;
                    break;
                default:
                    condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo;
                    break;
            }
            return condOp;
        }

        /* Fin Silvina */


        private void NewSearch()
        {
            txtSearchCodigo.Text = "";
            txtSearchCodigoSec.Text = "";
            txtSearchDescripcion.Text = "";
            //Cristian 20101211 Tarea 935
            txtSearchCodProveedor.Text = "";
            _uicontroller.Codigo_Proveedor = "";
            //Fin Tarea 935
            _uicontroller.Codigo_Search = "";
            _uicontroller.CodigoSec_Search = "";
            _uicontroller.Descripcion_Search = "";
            hierarchicalSearchControl1.NodeChecked1 = false;
            hierarchicalSearchControl1.NodeChecked2 = false;
            hierarchicalSearchControl1.NodeChecked3 = false;
            hierarchicalSearchControl1.NodeChecked4 = false;
            hierarchicalSearchControl1.NodeChecked5 = false;
            hierarchicalSearchControl1.NodeChecked6 = false;
            hierarchicalSearchControl1.NodeChecked7 = false;
            hierarchicalSearchControl1.NodeChecked8 = false;
            _uicontroller.CampoAuxiliar1_Search = "";
            _uicontroller.CampoAuxiliar2_Search = "";
            _uicontroller.CampoAuxiliar3_Search = "";
            _uicontroller.CampoAuxiliar4_Search = "";
            _uicontroller.CampoAuxiliar5_Search = "";

            txtSearchCampoAuxiliar1.Text = "";
            txtSearchCampoAuxiliar2.Text = "";
            txtSearchCampoAuxiliar3.Text = "";
            txtSearchCampoAuxiliar4.Text = "";
            txtSearchCampoAuxiliar5.Text = "";

            _uicontroller.ByJerarquia1 = false;
            _uicontroller.ByJerarquia2 = false;
            _uicontroller.ByJerarquia3 = false;
            _uicontroller.ByJerarquia4 = false;
            _uicontroller.ByJerarquia5 = false;
            _uicontroller.ByJerarquia6 = false;
            _uicontroller.ByJerarquia7 = false;
            _uicontroller.ByJerarquia8 = false;

            mzComboListaDePrecios.Value = _uicontroller.IdListaDePreciosDefault;
            _uicontroller.IdListaDePrecio_Search = string.Empty;
            cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCostoDefault;

            // ---- Matias - Tarea 279 - Custom 8 - 20090721
            uceEntreFechas.Checked = false;
            uceResponsable.Checked = false;
            _uicontroller.IdResponsable = string.Empty;
            mzCEResponsable.Value = string.Empty;
            udtFechaAltaDesde.Value = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
            udtFechaAltaHasta.Value = mz.erp.businessrules.Sistema.DateTime.Now;
            // ---- Fin Matias

        }
        private void Detail()
        {
            if (_currentGrid.SelectedItems.Count > 0)
            {
                _uicontroller.VerDetalle((System.Data.DataRowView)_currentGrid.SelectedItems[0].GetRow().DataRow);
                pictureBoxThumb.Image = _uicontroller.Thumb;
            }
            if (_uicontroller.UltimaModificacionPcioCosto.Equals(DateTime.MinValue))
                uccFechaUltimaModifPcioCosto.Value = System.DBNull.Value;
            else
                uccFechaUltimaModifPcioCosto.Value = _uicontroller.UltimaModificacionPcioCosto;

            if (_uicontroller.UltimaModificacionPcioVenta.Equals(DateTime.MinValue))
                uccFechaUltimaModifPcioVta.Value = System.DBNull.Value;
            else
                uccFechaUltimaModifPcioVta.Value = _uicontroller.UltimaModificacionPcioVenta;

        }

        private string _selectedValue = string.Empty;
        private string _selectedDescription = string.Empty;
        private string _selectedListaDePrecios = string.Empty;
        private string _selectedTipoDePrecioDeCosto = string.Empty;
        private System.Data.DataRow _datarow = null;
        public string SelectedValue
        {
            get { return _selectedValue; }
        }
        public string SelectedDescription
        {
            get { return _selectedDescription; }
        }
        public string SelectedListaDePrecios
        {
            get { return _selectedListaDePrecios; }
            set { _uicontroller.IdListaDePrecio = value; }
        }

        public string SelectedTipoDePrecioDeCosto
        {
            get { return _selectedTipoDePrecioDeCosto; }
            set { _uicontroller.TipoDePrecioDeCosto = value; }
        }

        public System.Data.DataRow SelectedRow
        {
            get { return _datarow; }
        }

        /// <summary>
        /// Se configura de acuerdo al cierre automatico. Si se esta emitiendo una factura se desea que el formulario
        /// se cierre automaticamente luego de cargar el arrayList SelectedItems. En cambio si la entrada
        /// se produce por consulta de articulos, o bien no hace nada o como en este caso quedo
        /// configurado el detalle del articulo seleccionado.
        /// </summary>
        private void Select()
        {
            if (_cierreAutomatico)
            {
                BuildSelected();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                //Detail();
            }
        }

        private ArrayList _selectedItems = new ArrayList();
        public ArrayList SelectedItems
        {
            get { return _selectedItems; }
        }
        private void BuildSelected()
        {
            for (int i = 0; i < _currentGrid.SelectedItems.Count; i++)
            {
                _selectedItems.Add(_currentGrid.SelectedItems[i].GetRow().Cells["IdProducto"].Value);
            }
            if (_currentGrid.SelectedItems.Count > 0)
            {
                _uicontroller.VerDetalle((System.Data.DataRowView)_currentGrid.SelectedItems[0].GetRow().DataRow);
                this._selectedDescription = _uicontroller.Descripcion;
                this._selectedValue = _uicontroller.Codigo;
                this._selectedListaDePrecios = _uicontroller.IdListaDePrecio;
                this._selectedTipoDePrecioDeCosto = _uicontroller.TipoDePrecioDeCosto;
                this._datarow = ((System.Data.DataRowView)_currentGrid.SelectedItems[0].GetRow().DataRow).Row;
            }

        }
        private void InputControl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            switch (e.KeyData)
            {
                case System.Windows.Forms.Keys.F2:
                    this.SearchNow();
                    break;
                case System.Windows.Forms.Keys.PageDown:
                    gridEx.Focus();
                    break;
                case System.Windows.Forms.Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }

        }



        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            Detail();
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            Select();
        }

        private void treeAgrupamientos_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
        {
            _uicontroller.NodoExpandir(e.TreeNode);
        }

        private void treeAgrupamientos_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
        {
            _uicontroller.NodoActual(e.TreeNode);
        }


        private void gridEx_DoubleClick(object sender, System.EventArgs e)
        {
            Select();
        }

        private Janus.Windows.GridEX.GridEX _currentGrid;

        //Cristian Tarea 935 20101211
        private void ConfigurarSolapaPorDefault()
        {

            if (tabControl2.SelectedIndex == 0)
            {
                _currentGrid = gridEx;
                _uicontroller.SerachByJerarquia = false;
                switch (_uicontroller.SolapaBuscadorGenericoControlActivo)
                {
                    case "Descripcion":
                        txtSearchDescripcion.Focus();
                        break;
                    case "CodigoSecundario":
                        txtSearchCodigoSec.Focus();
                        break;
                    case "Activo":
                        chkActivo.Focus();
                        break;
                    case "Codigo":
                        txtSearchCodigo.Focus();
                        break;
                    case "ListaDePrecios":
                        cboTipoDePrecioDeCosto.Focus();
                        break;
                    //Cristian  Tarea 935 
                    case "CodigoProveedor":
                        txtSearchCodProveedor.Focus();
                        break;
                    //fin Tarea 935
                }
            }
            else
            {
                //_currentGrid = gridExAgrupados;
                _uicontroller.SerachByJerarquia = true;
                if (tabControl2.SelectedIndex == 1)
                {
                    switch (_uicontroller.SolapaBuscadorJerarquicoControlActivo)
                    {
                        case "Jerarquia1":
                            hierarchicalSearchControl1.ItemsJerarquia1Focus();
                            break;
                        case "Jerarquia2":
                            hierarchicalSearchControl1.ItemsJerarquia2Focus();
                            break;
                        case "Jerarquia3":
                            hierarchicalSearchControl1.ItemsJerarquia3Focus();
                            break;
                        case "Jerarquia4":
                            hierarchicalSearchControl1.ItemsJerarquia4Focus();
                            break;
                        case "Jerarquia5":
                            hierarchicalSearchControl1.ItemsJerarquia5Focus();
                            break;
                        case "Jerarquia6":
                            hierarchicalSearchControl1.ItemsJerarquia6Focus();
                            break;
                        case "Jerarquia7":
                            hierarchicalSearchControl1.ItemsJerarquia7Focus();
                            break;
                        case "Jerarquia8":
                            hierarchicalSearchControl1.ItemsJerarquia8Focus();
                            break;
                    }
                }
                else if (tabControl2.SelectedIndex == 2)
                {
                    switch (_uicontroller.SolapaBuscadorCamposAuxiliaresControlActivo)
                    {
                        case "CampoAuxiliar1":
                            txtSearchCampoAuxiliar1.Focus();
                            break;
                        case "CampoAuxiliar2":
                            txtSearchCampoAuxiliar2.Focus();
                            break;
                        case "CampoAuxiliar3":
                            txtSearchCampoAuxiliar3.Focus();
                            break;
                        case "CampoAuxiliar4":
                            txtSearchCampoAuxiliar4.Focus();
                            break;
                        case "CampoAuxiliar5":
                            txtSearchCampoAuxiliar5.Focus();
                            break;
                    }
                }
            }
        }
        //Fin Tarea 935
        private void tabControl2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.ConfigurarSolapaPorDefault();

        }

        private void gridEx_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case System.Windows.Forms.Keys.Enter:
                    {
                        Select();
                        break;
                    }
                default:
                    break;
            }
        }


        private void gridEx_Click(object sender, System.EventArgs e)
        {
            Detail();
        }


        private void gridEx_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Detail();
        }

        private void hierarchicalSearchControl1_Load(object sender, System.EventArgs e)
        {

        }

        private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
        {

            _uicontroller.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
            _uicontroller.Jerarquia1 = hierarchicalSearchControl1.ItemsJerarquia1;
            _uicontroller.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
            _uicontroller.Jerarquia2 = hierarchicalSearchControl1.ItemsJerarquia2;
            _uicontroller.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
            _uicontroller.Jerarquia3 = hierarchicalSearchControl1.ItemsJerarquia3;
            _uicontroller.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
            _uicontroller.Jerarquia4 = hierarchicalSearchControl1.ItemsJerarquia4;
            _uicontroller.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
            _uicontroller.Jerarquia5 = hierarchicalSearchControl1.ItemsJerarquia5;
            _uicontroller.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
            _uicontroller.Jerarquia6 = hierarchicalSearchControl1.ItemsJerarquia6;
            _uicontroller.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
            _uicontroller.Jerarquia7 = hierarchicalSearchControl1.ItemsJerarquia7;
            _uicontroller.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
            _uicontroller.Jerarquia8 = hierarchicalSearchControl1.ItemsJerarquia8;
            //_uicontroller.NodoActual();

        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void txtSearchCampoAuxiliar2_TextChanged(object sender, System.EventArgs e)
        {


        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel2.Text);
        }

        private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel3.Text);
        }

        private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel4.Text);
        }

        private void linkLabel5_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel5.Text);
        }

        private void mzComboListaDePrecios_ValueChanged(object sender, EventArgs e)
        {
            if (_uicontroller.AllowSearchOnListaDePrecioChange)
                this.SearchNow();
        }


        private void mzProductosSearchForm_Load(object sender, EventArgs e)
        {
            if (_uicontroller.SolapaVisualizacionActiva.Equals("Precios"))
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaPrecios);
            //this.tabControl1.SelectedIndex = 0;
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("ProductosPendientesEntrega"))
                //this.tabControl1.SelectedIndex = 1;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaProductosPendientesEntrega);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("UltimaModificacionPrecios"))
                //this.tabControl1.SelectedIndex = 2;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaUltimaModificacionPrecios);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("Links"))
                //this.tabControl1.SelectedIndex = 3;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaLinks);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("PreciosPorCondicionDeVenta"))
                //this.tabControl1.SelectedIndex = 4;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaPreciosCondicionesDeVenta);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("ProductosAsociados"))
                //this.tabControl1.SelectedIndex = 5;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaProductosAsociados);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("Imagenes"))
                //this.tabControl1.SelectedIndex = 6;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaImagenes);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("Stock"))
                //this.tabControl1.SelectedIndex = 7;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaStock);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("Agrupamientos"))
                //this.tabControl1.SelectedIndex = 8;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaAgrupamientos);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("Medidas"))
                //this.tabControl1.SelectedIndex = 9;
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaMedidas);
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("PreciosMediosDePago"))
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaPreciosMediosDePago);
            //Sabrina 20100722 - Tarea 798
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("ListasDePrecios"))
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaListasDePrecios);
            //Fin Sabrina 20100722 - Tarea 798
            //Sabrina: Tarea 1081. 20110328
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("DetalleCombo"))
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.HojaDetalleCombo);
            //Fin Sabrina: Tarea 1081. 20110328
            //German 20120208 - Tarea 0000276
            else if (_uicontroller.SolapaVisualizacionActiva.Equals("Bonificaciones"))
                this.tabControl1.SelectedIndex = this.tabControl1.TabPages.IndexOf(this.tabBonificaciones);
            //German 20120208 - Tarea 0000276
            this.tabControl2.SelectedIndex = 1;
            if (_uicontroller.SolapaActiva.Equals("SolapaBuscadorGenerico"))
                this.tabControl2.SelectedIndex = 0;
            else if (_uicontroller.SolapaActiva.Equals("SolapaBuscadorJerarquico"))
                this.tabControl2.SelectedIndex = 1;
            else if (_uicontroller.SolapaActiva.Equals("SolapaBuscadorCamposAuxiliares"))
                this.tabControl2.SelectedIndex = 2;
            tabControl2.Focus();
            tabControl2_SelectedIndexChanged(this, EventArgs.Empty);


        }

        private void groupBox2_Enter(object sender, System.EventArgs e)
        {

        }


        private void HojaBuscadorGenerico_Click(object sender, System.EventArgs e)
        {

        }

        private void uceResponsable_CheckedChanged(object sender, EventArgs e)
        {
            if (this.uceResponsable.Checked)
            {
                _uicontroller.BuscarPorResponsable = true;
                mzCEResponsable.Enabled = true;
            }
            else
            {
                _uicontroller.BuscarPorResponsable = false;
                mzCEResponsable.Enabled = false;
            }
        }

        private void uceEntreFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.uceEntreFechas.Checked)
            {
                _uicontroller.BuscarPorFechaAlta = true;
                udtFechaAltaDesde.Enabled = true;
                udtFechaAltaHasta.Enabled = true;
            }
            else
            {
                _uicontroller.BuscarPorFechaAlta = false;
                udtFechaAltaDesde.Enabled = false;
                udtFechaAltaHasta.Enabled = false;
            }

        }

        private void txtObservaciones_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}


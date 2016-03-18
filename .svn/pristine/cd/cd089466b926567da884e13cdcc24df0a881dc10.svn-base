using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using mz.erp.commontypes;
using System.Reflection;
using System.Data;
namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de mzCuentasSearchForm.
	/// </summary>
	public class mzCuentasSearchForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.TextBox txtTelefonos;
		private System.Windows.Forms.TextBox txtCodigo;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtTitular;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private mz.erp.ui.controls.mzComboEditor mzCETipoDoc;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtCampoAux1;
		private System.Windows.Forms.TextBox txtCampoAux3;
        private System.Windows.Forms.TextBox txtCampoAux2;
		private System.Windows.Forms.ToolBarButton tbbSeparador1;
		private System.Windows.Forms.ToolBarButton tbbBuscar;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbNuevaBusqueda;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private Janus.Windows.GridEX.GridEX gridDirecciones;
		private Janus.Windows.GridEX.GridEX gridContactos;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroPrincipal;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroSecundario;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroJerarquico;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpDirecciones;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpContactos;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcFiltros;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcDetalles;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utcJerarquias;
		private Janus.Windows.GridEX.GridEX gridJerarquias;
		private System.Windows.Forms.Label labelCampoAux3;
		private System.Windows.Forms.Label labelCampoAux2;
		private System.Windows.Forms.Label labelCampoAux1;
		private System.Windows.Forms.ToolBarButton tbbNuevo;
		private System.Windows.Forms.ToolBarButton tbbEditar;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.ToolBarButton tbbSeprardor6;
		private System.Windows.Forms.ToolBarButton tbbAceptar;
		private System.Windows.Forms.ToolBarButton tbbSeparator7;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemExportarExcel;
		private System.Windows.Forms.MenuItem menuItemVerCtaCte;
		private System.Windows.Forms.MenuItem menuItemVerObservaciones;
		private System.Windows.Forms.MenuItem menuItemVerDetalleVentas;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.ToolBarButton tbbSeparator8;
		private System.Windows.Forms.ToolBarButton tbbCuentaCorriente;
		private System.Windows.Forms.Label label9;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtContacto;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItemAgregarObservaciones;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chekbuscarLoc;
		private System.Windows.Forms.Label txtLocalidad;
		private System.Windows.Forms.GroupBox groupboxLocalidades;
		private mz.erp.ui.controls.mzComboEditor mzCmbPaisEditar;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private mz.erp.ui.controls.mzComboEditor mzCmbPciaEditar;
		private mz.erp.ui.controls.mzComboEditor mzCmbLocEditar;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceResponsable;
		private System.Windows.Forms.Label lFecha;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaHasta;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaDesde;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceEntreFechas;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsable;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
        private Label lCampoAuxiliar6;
        private controls.mzSearchTextBox mzSTBCampoAuxiliar6;
		private System.ComponentModel.IContainer components;

		
		#region Constructores y Destructores
		
		public mzCuentasSearchForm(mzCuentasSearchFormController UIController)
		{
			InitializeComponent();
			_uiController = UIController;
		}

		public mzCuentasSearchForm()
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
			}
			base.Dispose( disposing );
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
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab4 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab5 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab6 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mzCuentasSearchForm));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.utpFiltroPrincipal = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.uceEntreFechas = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.udtFechaAltaHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.udtFechaAltaDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.lFecha = new System.Windows.Forms.Label();
            this.uceResponsable = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.mzCEResponsable = new mz.erp.ui.controls.mzComboEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.chekbuscarLoc = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtLocalidad = new System.Windows.Forms.Label();
            this.groupboxLocalidades = new System.Windows.Forms.GroupBox();
            this.mzCmbPaisEditar = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmbPciaEditar = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbLocEditar = new mz.erp.ui.controls.mzComboEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mzCmbSrchEdtTitular = new mz.erp.ui.controls.mzComboSearchEditor();
            this.utpFiltroSecundario = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.label9 = new System.Windows.Forms.Label();
            this.mzCmbSrchEdtContacto = new mz.erp.ui.controls.mzComboSearchEditor();
            this.txtCampoAux3 = new System.Windows.Forms.TextBox();
            this.labelCampoAux3 = new System.Windows.Forms.Label();
            this.txtCampoAux2 = new System.Windows.Forms.TextBox();
            this.labelCampoAux2 = new System.Windows.Forms.Label();
            this.txtCampoAux1 = new System.Windows.Forms.TextBox();
            this.labelCampoAux1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mzCETipoDoc = new mz.erp.ui.controls.mzComboEditor();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.utpFiltroJerarquico = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.utpDirecciones = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.gridDirecciones = new Janus.Windows.GridEX.GridEX();
            this.utpContactos = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.gridContactos = new Janus.Windows.GridEX.GridEX();
            this.utcJerarquias = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.gridJerarquias = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.utcFiltros = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage2 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.utcDetalles = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
            this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
            this.gridResultado = new Janus.Windows.GridEX.GridEX();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemExportarExcel = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemVerDetalleVentas = new System.Windows.Forms.MenuItem();
            this.menuItemVerObservaciones = new System.Windows.Forms.MenuItem();
            this.menuItemVerCtaCte = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemAgregarObservaciones = new System.Windows.Forms.MenuItem();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbBuscar = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparador1 = new System.Windows.Forms.ToolBarButton();
            this.tbbNuevaBusqueda = new System.Windows.Forms.ToolBarButton();
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
            this.tbbSeparator8 = new System.Windows.Forms.ToolBarButton();
            this.tbbCuentaCorriente = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.lCampoAuxiliar6 = new System.Windows.Forms.Label();
            this.mzSTBCampoAuxiliar6 = new mz.erp.ui.controls.mzSearchTextBox();
            this.utpFiltroPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).BeginInit();
            this.groupboxLocalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPaisEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPciaEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbLocEditar)).BeginInit();
            this.utpFiltroSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoDoc)).BeginInit();
            this.utpFiltroJerarquico.SuspendLayout();
            this.utpDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDirecciones)).BeginInit();
            this.utpContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).BeginInit();
            this.utcJerarquias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJerarquias)).BeginInit();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).BeginInit();
            this.utcFiltros.SuspendLayout();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utcDetalles)).BeginInit();
            this.utcDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // utpFiltroPrincipal
            // 
            this.utpFiltroPrincipal.Controls.Add(this.chkActivo);
            this.utpFiltroPrincipal.Controls.Add(this.txtCalle);
            this.utpFiltroPrincipal.Controls.Add(this.uceEntreFechas);
            this.utpFiltroPrincipal.Controls.Add(this.udtFechaAltaHasta);
            this.utpFiltroPrincipal.Controls.Add(this.udtFechaAltaDesde);
            this.utpFiltroPrincipal.Controls.Add(this.lFecha);
            this.utpFiltroPrincipal.Controls.Add(this.uceResponsable);
            this.utpFiltroPrincipal.Controls.Add(this.mzCEResponsable);
            this.utpFiltroPrincipal.Controls.Add(this.label6);
            this.utpFiltroPrincipal.Controls.Add(this.chekbuscarLoc);
            this.utpFiltroPrincipal.Controls.Add(this.txtLocalidad);
            this.utpFiltroPrincipal.Controls.Add(this.groupboxLocalidades);
            this.utpFiltroPrincipal.Controls.Add(this.label5);
            this.utpFiltroPrincipal.Controls.Add(this.txtCodigo);
            this.utpFiltroPrincipal.Controls.Add(this.txtTelefonos);
            this.utpFiltroPrincipal.Controls.Add(this.txtRazonSocial);
            this.utpFiltroPrincipal.Controls.Add(this.label3);
            this.utpFiltroPrincipal.Controls.Add(this.label4);
            this.utpFiltroPrincipal.Controls.Add(this.label2);
            this.utpFiltroPrincipal.Controls.Add(this.label1);
            this.utpFiltroPrincipal.Controls.Add(this.mzCmbSrchEdtTitular);
            this.utpFiltroPrincipal.Location = new System.Drawing.Point(-10000, -10000);
            this.utpFiltroPrincipal.Name = "utpFiltroPrincipal";
            this.utpFiltroPrincipal.Size = new System.Drawing.Size(922, 124);
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(336, 27);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 24);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(584, 2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(288, 20);
            this.txtCalle.TabIndex = 7;
            // 
            // uceEntreFechas
            // 
            this.uceEntreFechas.BackColor = System.Drawing.Color.Transparent;
            this.uceEntreFechas.BackColorInternal = System.Drawing.Color.Transparent;
            this.uceEntreFechas.Location = new System.Drawing.Point(880, 101);
            this.uceEntreFechas.Name = "uceEntreFechas";
            this.uceEntreFechas.Size = new System.Drawing.Size(16, 16);
            this.uceEntreFechas.TabIndex = 14;
            // 
            // udtFechaAltaHasta
            // 
            this.udtFechaAltaHasta.Location = new System.Drawing.Point(737, 98);
            this.udtFechaAltaHasta.Name = "udtFechaAltaHasta";
            this.udtFechaAltaHasta.Size = new System.Drawing.Size(136, 21);
            this.udtFechaAltaHasta.TabIndex = 13;
            // 
            // udtFechaAltaDesde
            // 
            this.udtFechaAltaDesde.Location = new System.Drawing.Point(584, 98);
            this.udtFechaAltaDesde.Name = "udtFechaAltaDesde";
            this.udtFechaAltaDesde.Size = new System.Drawing.Size(136, 21);
            this.udtFechaAltaDesde.TabIndex = 12;
            // 
            // lFecha
            // 
            this.lFecha.BackColor = System.Drawing.Color.Transparent;
            this.lFecha.Location = new System.Drawing.Point(496, 102);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(104, 16);
            this.lFecha.TabIndex = 114;
            this.lFecha.Text = "Fecha de alta";
            this.lFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uceResponsable
            // 
            this.uceResponsable.BackColor = System.Drawing.Color.Transparent;
            this.uceResponsable.BackColorInternal = System.Drawing.Color.Transparent;
            this.uceResponsable.Location = new System.Drawing.Point(336, 101);
            this.uceResponsable.Name = "uceResponsable";
            this.uceResponsable.Size = new System.Drawing.Size(16, 16);
            this.uceResponsable.TabIndex = 6;
            // 
            // mzCEResponsable
            // 
            this.mzCEResponsable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsable.DisplayMember = "";
            this.mzCEResponsable.DisplayMemberCaption = "";
            this.mzCEResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsable.Location = new System.Drawing.Point(112, 98);
            this.mzCEResponsable.MaxItemsDisplay = 7;
            this.mzCEResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsable.Name = "mzCEResponsable";
            this.mzCEResponsable.Size = new System.Drawing.Size(216, 21);
            this.mzCEResponsable.SorterMember = "";
            this.mzCEResponsable.TabIndex = 5;
            this.mzCEResponsable.ValueMember = "";
            this.mzCEResponsable.ValueMemberCaption = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "Responsable de alta";
            // 
            // chekbuscarLoc
            // 
            this.chekbuscarLoc.BackColor = System.Drawing.Color.Transparent;
            this.chekbuscarLoc.BackColorInternal = System.Drawing.Color.Transparent;
            this.chekbuscarLoc.Location = new System.Drawing.Point(589, 21);
            this.chekbuscarLoc.Name = "chekbuscarLoc";
            this.chekbuscarLoc.Size = new System.Drawing.Size(16, 16);
            this.chekbuscarLoc.TabIndex = 8;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(496, 28);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(64, 16);
            this.txtLocalidad.TabIndex = 108;
            this.txtLocalidad.Text = "Localidad";
            // 
            // groupboxLocalidades
            // 
            this.groupboxLocalidades.Controls.Add(this.mzCmbPaisEditar);
            this.groupboxLocalidades.Controls.Add(this.ultraLabel6);
            this.groupboxLocalidades.Controls.Add(this.ultraLabel7);
            this.groupboxLocalidades.Controls.Add(this.ultraLabel4);
            this.groupboxLocalidades.Controls.Add(this.mzCmbPciaEditar);
            this.groupboxLocalidades.Controls.Add(this.mzCmbLocEditar);
            this.groupboxLocalidades.Location = new System.Drawing.Point(584, 19);
            this.groupboxLocalidades.Name = "groupboxLocalidades";
            this.groupboxLocalidades.Size = new System.Drawing.Size(304, 80);
            this.groupboxLocalidades.TabIndex = 107;
            this.groupboxLocalidades.TabStop = false;
            // 
            // mzCmbPaisEditar
            // 
            this.mzCmbPaisEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbPaisEditar.DisplayMember = "";
            this.mzCmbPaisEditar.DisplayMemberCaption = "";
            this.mzCmbPaisEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbPaisEditar.Location = new System.Drawing.Point(73, 8);
            this.mzCmbPaisEditar.MaxItemsDisplay = 7;
            this.mzCmbPaisEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbPaisEditar.Name = "mzCmbPaisEditar";
            this.mzCmbPaisEditar.Size = new System.Drawing.Size(216, 21);
            this.mzCmbPaisEditar.SorterMember = "";
            this.mzCmbPaisEditar.TabIndex = 9;
            this.mzCmbPaisEditar.ValueMember = "";
            this.mzCmbPaisEditar.ValueMemberCaption = "";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(17, 13);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(28, 20);
            this.ultraLabel6.TabIndex = 126;
            this.ultraLabel6.Text = "País";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(17, 61);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(56, 20);
            this.ultraLabel7.TabIndex = 128;
            this.ultraLabel7.Text = "Localidad";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(17, 37);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(32, 20);
            this.ultraLabel4.TabIndex = 125;
            this.ultraLabel4.Text = "Pcía";
            // 
            // mzCmbPciaEditar
            // 
            this.mzCmbPciaEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbPciaEditar.DisplayMember = "";
            this.mzCmbPciaEditar.DisplayMemberCaption = "";
            this.mzCmbPciaEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbPciaEditar.Location = new System.Drawing.Point(73, 32);
            this.mzCmbPciaEditar.MaxItemsDisplay = 7;
            this.mzCmbPciaEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbPciaEditar.Name = "mzCmbPciaEditar";
            this.mzCmbPciaEditar.Size = new System.Drawing.Size(216, 21);
            this.mzCmbPciaEditar.SorterMember = "";
            this.mzCmbPciaEditar.TabIndex = 10;
            this.mzCmbPciaEditar.ValueMember = "";
            this.mzCmbPciaEditar.ValueMemberCaption = "";
            // 
            // mzCmbLocEditar
            // 
            this.mzCmbLocEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbLocEditar.DisplayMember = "";
            this.mzCmbLocEditar.DisplayMemberCaption = "";
            this.mzCmbLocEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbLocEditar.Location = new System.Drawing.Point(73, 56);
            this.mzCmbLocEditar.MaxItemsDisplay = 7;
            this.mzCmbLocEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbLocEditar.Name = "mzCmbLocEditar";
            this.mzCmbLocEditar.Size = new System.Drawing.Size(216, 21);
            this.mzCmbLocEditar.SorterMember = "";
            this.mzCmbLocEditar.TabIndex = 11;
            this.mzCmbLocEditar.ValueMember = "";
            this.mzCmbLocEditar.ValueMemberCaption = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(496, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Calle";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(216, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(112, 49);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(272, 20);
            this.txtTelefonos.TabIndex = 3;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(112, 2);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(272, 20);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfonos";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Titular";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razón Social";
            // 
            // mzCmbSrchEdtTitular
            // 
            this.mzCmbSrchEdtTitular.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbSrchEdtTitular.DataValue = "";
            this.mzCmbSrchEdtTitular.EditObject = null;
            this.mzCmbSrchEdtTitular.FastSearch = false;
            this.mzCmbSrchEdtTitular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbSrchEdtTitular.HierarchicalSearch = false;
            this.mzCmbSrchEdtTitular.Location = new System.Drawing.Point(111, 73);
            this.mzCmbSrchEdtTitular.Name = "mzCmbSrchEdtTitular";
            this.mzCmbSrchEdtTitular.ReadOnly = false;
            this.mzCmbSrchEdtTitular.SearchObject = null;
            this.mzCmbSrchEdtTitular.SearchObjectListener = null;
            this.mzCmbSrchEdtTitular.Size = new System.Drawing.Size(360, 22);
            this.mzCmbSrchEdtTitular.TabIndex = 4;
            // 
            // utpFiltroSecundario
            // 
            this.utpFiltroSecundario.Controls.Add(this.lCampoAuxiliar6);
            this.utpFiltroSecundario.Controls.Add(this.mzSTBCampoAuxiliar6);
            this.utpFiltroSecundario.Controls.Add(this.label9);
            this.utpFiltroSecundario.Controls.Add(this.mzCmbSrchEdtContacto);
            this.utpFiltroSecundario.Controls.Add(this.txtCampoAux3);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux3);
            this.utpFiltroSecundario.Controls.Add(this.txtCampoAux2);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux2);
            this.utpFiltroSecundario.Controls.Add(this.txtCampoAux1);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux1);
            this.utpFiltroSecundario.Controls.Add(this.txtEmail);
            this.utpFiltroSecundario.Controls.Add(this.mzCETipoDoc);
            this.utpFiltroSecundario.Controls.Add(this.textBox1);
            this.utpFiltroSecundario.Controls.Add(this.label7);
            this.utpFiltroSecundario.Controls.Add(this.label8);
            this.utpFiltroSecundario.Location = new System.Drawing.Point(1, 23);
            this.utpFiltroSecundario.Name = "utpFiltroSecundario";
            this.utpFiltroSecundario.Size = new System.Drawing.Size(922, 124);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(400, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Contacto";
            // 
            // mzCmbSrchEdtContacto
            // 
            this.mzCmbSrchEdtContacto.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbSrchEdtContacto.DataValue = "";
            this.mzCmbSrchEdtContacto.EditObject = null;
            this.mzCmbSrchEdtContacto.FastSearch = false;
            this.mzCmbSrchEdtContacto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbSrchEdtContacto.HierarchicalSearch = false;
            this.mzCmbSrchEdtContacto.Location = new System.Drawing.Point(464, 40);
            this.mzCmbSrchEdtContacto.Name = "mzCmbSrchEdtContacto";
            this.mzCmbSrchEdtContacto.ReadOnly = false;
            this.mzCmbSrchEdtContacto.SearchObject = null;
            this.mzCmbSrchEdtContacto.SearchObjectListener = null;
            this.mzCmbSrchEdtContacto.Size = new System.Drawing.Size(360, 22);
            this.mzCmbSrchEdtContacto.TabIndex = 6;
            // 
            // txtCampoAux3
            // 
            this.txtCampoAux3.Location = new System.Drawing.Point(112, 72);
            this.txtCampoAux3.Name = "txtCampoAux3";
            this.txtCampoAux3.Size = new System.Drawing.Size(272, 20);
            this.txtCampoAux3.TabIndex = 4;
            // 
            // labelCampoAux3
            // 
            this.labelCampoAux3.AutoSize = true;
            this.labelCampoAux3.Location = new System.Drawing.Point(8, 78);
            this.labelCampoAux3.Name = "labelCampoAux3";
            this.labelCampoAux3.Size = new System.Drawing.Size(64, 13);
            this.labelCampoAux3.TabIndex = 17;
            this.labelCampoAux3.Text = "CampoAux3";
            // 
            // txtCampoAux2
            // 
            this.txtCampoAux2.Location = new System.Drawing.Point(464, 4);
            this.txtCampoAux2.Name = "txtCampoAux2";
            this.txtCampoAux2.Size = new System.Drawing.Size(272, 20);
            this.txtCampoAux2.TabIndex = 5;
            // 
            // labelCampoAux2
            // 
            this.labelCampoAux2.AutoSize = true;
            this.labelCampoAux2.Location = new System.Drawing.Point(400, 8);
            this.labelCampoAux2.Name = "labelCampoAux2";
            this.labelCampoAux2.Size = new System.Drawing.Size(64, 13);
            this.labelCampoAux2.TabIndex = 15;
            this.labelCampoAux2.Text = "CampoAux2";
            // 
            // txtCampoAux1
            // 
            this.txtCampoAux1.Location = new System.Drawing.Point(112, 51);
            this.txtCampoAux1.Name = "txtCampoAux1";
            this.txtCampoAux1.Size = new System.Drawing.Size(272, 20);
            this.txtCampoAux1.TabIndex = 3;
            // 
            // labelCampoAux1
            // 
            this.labelCampoAux1.AutoSize = true;
            this.labelCampoAux1.Location = new System.Drawing.Point(8, 54);
            this.labelCampoAux1.Name = "labelCampoAux1";
            this.labelCampoAux1.Size = new System.Drawing.Size(64, 13);
            this.labelCampoAux1.TabIndex = 13;
            this.labelCampoAux1.Text = "CampoAux1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // mzCETipoDoc
            // 
            this.mzCETipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCETipoDoc.DisplayMember = "";
            this.mzCETipoDoc.DisplayMemberCaption = "";
            this.mzCETipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCETipoDoc.ImageTransparentColor = System.Drawing.Color.Violet;
            this.mzCETipoDoc.Location = new System.Drawing.Point(112, 4);
            this.mzCETipoDoc.MaxItemsDisplay = 7;
            this.mzCETipoDoc.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCETipoDoc.Name = "mzCETipoDoc";
            this.mzCETipoDoc.Size = new System.Drawing.Size(145, 21);
            this.mzCETipoDoc.SorterMember = "";
            this.mzCETipoDoc.TabIndex = 0;
            this.mzCETipoDoc.ValueMember = "";
            this.mzCETipoDoc.ValueMemberCaption = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo y Nro de Doc";
            // 
            // utpFiltroJerarquico
            // 
            this.utpFiltroJerarquico.Controls.Add(this.hierarchicalSearchControl1);
            this.utpFiltroJerarquico.Location = new System.Drawing.Point(-10000, -10000);
            this.utpFiltroJerarquico.Name = "utpFiltroJerarquico";
            this.utpFiltroJerarquico.Size = new System.Drawing.Size(922, 124);
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(922, 104);
            this.hierarchicalSearchControl1.TabIndex = 10;
            // 
            // utpDirecciones
            // 
            this.utpDirecciones.Controls.Add(this.gridDirecciones);
            this.utpDirecciones.Location = new System.Drawing.Point(1, 23);
            this.utpDirecciones.Name = "utpDirecciones";
            this.utpDirecciones.Size = new System.Drawing.Size(915, 126);
            // 
            // gridDirecciones
            // 
            this.gridDirecciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridDirecciones.AlternatingColors = true;
            this.gridDirecciones.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridDirecciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDirecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDirecciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridDirecciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridDirecciones.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridDirecciones.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridDirecciones.GroupByBoxVisible = false;
            this.gridDirecciones.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridDirecciones.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridDirecciones.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridDirecciones.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridDirecciones.Location = new System.Drawing.Point(0, 0);
            this.gridDirecciones.Name = "gridDirecciones";
            this.gridDirecciones.RecordNavigatorText = "Registro:|de";
            this.gridDirecciones.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridDirecciones.ShowEmptyFields = false;
            this.gridDirecciones.Size = new System.Drawing.Size(915, 126);
            this.gridDirecciones.TabIndex = 7;
            this.gridDirecciones.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // utpContactos
            // 
            this.utpContactos.Controls.Add(this.gridContactos);
            this.utpContactos.Location = new System.Drawing.Point(-10000, -10000);
            this.utpContactos.Name = "utpContactos";
            this.utpContactos.Size = new System.Drawing.Size(915, 126);
            // 
            // gridContactos
            // 
            this.gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridContactos.AlternatingColors = true;
            this.gridContactos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridContactos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridContactos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridContactos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridContactos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridContactos.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridContactos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridContactos.GroupByBoxVisible = false;
            this.gridContactos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridContactos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridContactos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridContactos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridContactos.Location = new System.Drawing.Point(-2, 7);
            this.gridContactos.Name = "gridContactos";
            this.gridContactos.RecordNavigatorText = "Registro:|de";
            this.gridContactos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridContactos.ShowEmptyFields = false;
            this.gridContactos.Size = new System.Drawing.Size(919, 160);
            this.gridContactos.TabIndex = 7;
            this.gridContactos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // utcJerarquias
            // 
            this.utcJerarquias.Controls.Add(this.gridJerarquias);
            this.utcJerarquias.Location = new System.Drawing.Point(-10000, -10000);
            this.utcJerarquias.Name = "utcJerarquias";
            this.utcJerarquias.Size = new System.Drawing.Size(915, 126);
            // 
            // gridJerarquias
            // 
            this.gridJerarquias.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridJerarquias.AlternatingColors = true;
            this.gridJerarquias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridJerarquias.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridJerarquias.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridJerarquias.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridJerarquias.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridJerarquias.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridJerarquias.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridJerarquias.GroupByBoxVisible = false;
            this.gridJerarquias.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridJerarquias.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridJerarquias.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridJerarquias.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridJerarquias.Location = new System.Drawing.Point(-2, 7);
            this.gridJerarquias.Name = "gridJerarquias";
            this.gridJerarquias.RecordNavigatorText = "Registro:|de";
            this.gridJerarquias.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridJerarquias.ShowEmptyFields = false;
            this.gridJerarquias.Size = new System.Drawing.Size(919, 160);
            this.gridJerarquias.TabIndex = 8;
            this.gridJerarquias.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.utcFiltros);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(926, 150);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // utcFiltros
            // 
            this.utcFiltros.BackColorInternal = System.Drawing.Color.Transparent;
            this.utcFiltros.Controls.Add(this.ultraTabSharedControlsPage2);
            this.utcFiltros.Controls.Add(this.utpFiltroPrincipal);
            this.utcFiltros.Controls.Add(this.utpFiltroJerarquico);
            this.utcFiltros.Controls.Add(this.utpFiltroSecundario);
            this.utcFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.utcFiltros.Location = new System.Drawing.Point(0, 0);
            this.utcFiltros.Name = "utcFiltros";
            this.utcFiltros.SharedControlsPage = this.ultraTabSharedControlsPage2;
            this.utcFiltros.Size = new System.Drawing.Size(926, 150);
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
            appearance7.BackColor = System.Drawing.Color.Transparent;
            ultraTab3.ActiveAppearance = appearance7;
            appearance8.BackColor = System.Drawing.Color.Transparent;
            ultraTab3.Appearance = appearance8;
            appearance9.BackColor = System.Drawing.Color.Transparent;
            ultraTab3.ClientAreaAppearance = appearance9;
            ultraTab3.Key = "FiltroJerarquico";
            ultraTab3.TabPage = this.utpFiltroJerarquico;
            ultraTab3.Text = "Filtro Jerárquico";
            this.utcFiltros.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab1,
            ultraTab2,
            ultraTab3});
            this.utcFiltros.TabStop = false;
            // 
            // ultraTabSharedControlsPage2
            // 
            this.ultraTabSharedControlsPage2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabSharedControlsPage2.Name = "ultraTabSharedControlsPage2";
            this.ultraTabSharedControlsPage2.Size = new System.Drawing.Size(922, 124);
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.AutoScroll = true;
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.utcDetalles);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 258);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(926, 376);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.Color.Transparent;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(926, 24);
            this.gridManagerView1.TabIndex = 0;
            // 
            // utcDetalles
            // 
            this.utcDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utcDetalles.BackColorInternal = System.Drawing.Color.Transparent;
            this.utcDetalles.Controls.Add(this.ultraTabSharedControlsPage1);
            this.utcDetalles.Controls.Add(this.utpDirecciones);
            this.utcDetalles.Controls.Add(this.utpContactos);
            this.utcDetalles.Controls.Add(this.utcJerarquias);
            this.utcDetalles.Location = new System.Drawing.Point(0, 219);
            this.utcDetalles.Name = "utcDetalles";
            this.utcDetalles.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.utcDetalles.Size = new System.Drawing.Size(919, 152);
            this.utcDetalles.TabIndex = 16;
            ultraTab4.Key = "Domicilios";
            ultraTab4.TabPage = this.utpDirecciones;
            ultraTab4.Text = "Domicilios y Teléfonos";
            ultraTab5.Key = "Contactos";
            ultraTab5.TabPage = this.utpContactos;
            ultraTab5.Text = "Contactos";
            ultraTab6.Key = "Jerarquias";
            ultraTab6.TabPage = this.utcJerarquias;
            ultraTab6.Text = "Jerarquías";
            this.utcDetalles.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab4,
            ultraTab5,
            ultraTab6});
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(915, 126);
            // 
            // gridResultado
            // 
            this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridResultado.AlternatingColors = true;
            this.gridResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResultado.ContextMenu = this.contextMenu1;
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
            this.gridResultado.Location = new System.Drawing.Point(0, 27);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RecordNavigatorText = "Registro:|de";
            this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridResultado.ShowEmptyFields = false;
            this.gridResultado.Size = new System.Drawing.Size(919, 192);
            this.gridResultado.TabIndex = 1;
            this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemExportarExcel,
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItemExportarExcel
            // 
            this.menuItemExportarExcel.Index = 0;
            this.menuItemExportarExcel.Text = "Exportar a Excel";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemVerDetalleVentas,
            this.menuItemVerObservaciones,
            this.menuItemVerCtaCte});
            this.menuItem1.Text = "Ver";
            // 
            // menuItemVerDetalleVentas
            // 
            this.menuItemVerDetalleVentas.Index = 0;
            this.menuItemVerDetalleVentas.Text = "Detalle Ventas";
            // 
            // menuItemVerObservaciones
            // 
            this.menuItemVerObservaciones.Index = 1;
            this.menuItemVerObservaciones.Text = "Observaciones";
            // 
            // menuItemVerCtaCte
            // 
            this.menuItemVerCtaCte.Index = 2;
            this.menuItemVerCtaCte.Text = "Cuenta Corriente";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAgregarObservaciones});
            this.menuItem2.Text = "Agregar";
            // 
            // menuItemAgregarObservaciones
            // 
            this.menuItemAgregarObservaciones.Index = 0;
            this.menuItemAgregarObservaciones.Text = "Observaciones";
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            /* Silvina 20111226 - Tarea 0000241 */
            /*this.imglStandar.Images.SetKeyName(0, "");
            this.imglStandar.Images.SetKeyName(1, "");
            this.imglStandar.Images.SetKeyName(2, "");
            this.imglStandar.Images.SetKeyName(3, "");
            this.imglStandar.Images.SetKeyName(4, "");
            this.imglStandar.Images.SetKeyName(5, "");
            this.imglStandar.Images.SetKeyName(6, "");
            this.imglStandar.Images.SetKeyName(7, "");
            this.imglStandar.Images.SetKeyName(8, "");
            this.imglStandar.Images.SetKeyName(9, "");
            this.imglStandar.Images.SetKeyName(10, "");
            this.imglStandar.Images.SetKeyName(11, "");
            this.imglStandar.Images.SetKeyName(12, "");
            this.imglStandar.Images.SetKeyName(13, "");*/
            /* Fin Silvina 20111226 - Tarea 0000241 */
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbBuscar,
            this.tbbSeparador1,
            this.tbbNuevaBusqueda,
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
            this.tbbCancelar,
            this.tbbSeparator8,
            this.tbbCuentaCorriente});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(992, 28);
            this.toolBarStandar.TabIndex = 48;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbBuscar
            // 
            this.tbbBuscar.ImageIndex = 10;
            this.tbbBuscar.Name = "tbbBuscar";
            this.tbbBuscar.Text = "[F2] Buscar ahora";
            // 
            // tbbSeparador1
            // 
            this.tbbSeparador1.Name = "tbbSeparador1";
            this.tbbSeparador1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbNuevaBusqueda
            // 
            this.tbbNuevaBusqueda.ImageIndex = 5;
            this.tbbNuevaBusqueda.Name = "tbbNuevaBusqueda";
            this.tbbNuevaBusqueda.Text = "Nueva búsqueda";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbNuevo
            // 
            this.tbbNuevo.ImageIndex = 11;
            this.tbbNuevo.Name = "tbbNuevo";
            this.tbbNuevo.Text = "Nuevo";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbEditar
            // 
            this.tbbEditar.ImageIndex = 6;
            this.tbbEditar.Name = "tbbEditar";
            this.tbbEditar.Text = "Editar";
            // 
            // tbbSeparator4
            // 
            this.tbbSeparator4.Name = "tbbSeparator4";
            this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbbSeparator4.Visible = false;
            // 
            // tbbAnterior
            // 
            this.tbbAnterior.ImageIndex = 9;
            this.tbbAnterior.Name = "tbbAnterior";
            this.tbbAnterior.Text = "&Anterior";
            this.tbbAnterior.Visible = false;
            // 
            // tbbSeparator5
            // 
            this.tbbSeparator5.Name = "tbbSeparator5";
            this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbbSeparator5.Visible = false;
            // 
            // tbbSiguiente
            // 
            this.tbbSiguiente.ImageIndex = 8;
            this.tbbSiguiente.Name = "tbbSiguiente";
            this.tbbSiguiente.Text = "Siguiente";
            this.tbbSiguiente.Visible = false;
            // 
            // tbbSeprardor6
            // 
            this.tbbSeprardor6.Name = "tbbSeprardor6";
            this.tbbSeprardor6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbAceptar
            // 
            this.tbbAceptar.ImageIndex = 12;
            this.tbbAceptar.Name = "tbbAceptar";
            this.tbbAceptar.Text = "Aceptar";
            // 
            // tbbSeparator7
            // 
            this.tbbSeparator7.Name = "tbbSeparator7";
            this.tbbSeparator7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "Cancelar";
            // 
            // tbbSeparator8
            // 
            this.tbbSeparator8.Name = "tbbSeparator8";
            this.tbbSeparator8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCuentaCorriente
            // 
            this.tbbCuentaCorriente.ImageIndex = 13;
            this.tbbCuentaCorriente.Name = "tbbCuentaCorriente";
            this.tbbCuentaCorriente.Text = "Cuenta corriente";
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 150;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Filtros";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 376;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Detalle";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Scrollbars = Infragistics.Win.UltraWinExplorerBar.ScrollbarStyle.Always;
            this.ultraExplorerBar1.Size = new System.Drawing.Size(992, 550);
            this.ultraExplorerBar1.TabIndex = 80;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // lCampoAuxiliar6
            // 
            /* Silvina 20111226 - Tarea 0000241 */
            this.lCampoAuxiliar6.BackColor = System.Drawing.Color.Transparent;
            this.lCampoAuxiliar6.Location = new System.Drawing.Point(400, 72);
            this.lCampoAuxiliar6.Name = "lCampoAuxiliar6";
            this.lCampoAuxiliar6.Size = new System.Drawing.Size(58, 20);
            this.lCampoAuxiliar6.TabIndex = 75;
            this.lCampoAuxiliar6.Text = "label";
            // 
            // mzSTBCampoAuxiliar6
            // 
            this.mzSTBCampoAuxiliar6.BackColor = System.Drawing.Color.Transparent;
            this.mzSTBCampoAuxiliar6.Location = new System.Drawing.Point(464, 72);
            this.mzSTBCampoAuxiliar6.Name = "mzSTBCampoAuxiliar6";
            this.mzSTBCampoAuxiliar6.Size = new System.Drawing.Size(312, 22);
            this.mzSTBCampoAuxiliar6.TabIndex = 74;
            /* Fin Silvina 20111226 - Tarea 0000241 */
            // 
            // mzCuentasSearchForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(992, 578);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "mzCuentasSearchForm";
            this.Text = "Búsqueda de Clientes";
            this.utpFiltroPrincipal.ResumeLayout(false);
            this.utpFiltroPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).EndInit();
            this.groupboxLocalidades.ResumeLayout(false);
            this.groupboxLocalidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPaisEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPciaEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbLocEditar)).EndInit();
            this.utpFiltroSecundario.ResumeLayout(false);
            this.utpFiltroSecundario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoDoc)).EndInit();
            this.utpFiltroJerarquico.ResumeLayout(false);
            this.utpDirecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDirecciones)).EndInit();
            this.utpContactos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).EndInit();
            this.utcJerarquias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridJerarquias)).EndInit();
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).EndInit();
            this.utcFiltros.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utcDetalles)).EndInit();
            this.utcDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		#region Variables Privadas
			
			private  mzCuentasSearchFormController _uiController = null;
			private bool _cierreAutomatico = true;
			private bool _habilitaBotonNuevo = true;
			private bool _habilitaBotonEditar = true;
			private bool _habilitaDetalles = true;
			private ArrayList _selectedItems = new ArrayList();
			private string _selectedIdCuenta = string.Empty;
			private string _selectedCodigo = string.Empty;
			private string _selectedNombre = string.Empty;
			private System.Data.DataRow _datarow = null;
			private ISearchObjectListener _searchObjectListener;
			//Matias 20100603 - Tarea 16
			private bool _habilitaBotonAceptar = true;
			//Fin Matias 20100603 - Tarea 16
			
		
		#endregion

		#region Propiedades

		public bool AllowMultipleSelect
		{
			set
			{
				if(value)
					gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
				else
					gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			}
		}

		public string SelectedIdCuenta
		{
			get { return _selectedIdCuenta ; }
		}
		public string SelectedNombre
		{
			get { return _selectedNombre; }
		}

		public string SelectedCodigo
		{
			get { return _selectedCodigo; }
		}

		public System.Data.DataRow SelectedRow
		{
			get{ return _datarow; }
		}

		public ArrayList SelectedItems
		{
			get { return _selectedItems ; }
		}

		#endregion

		#region Metodos Publicos

		public void Init(bool CierreAutomatico, ISearchObjectListener listener)
		{
			_uiController = new mzCuentasSearchFormController();
			_cierreAutomatico = CierreAutomatico;
			_searchObjectListener = listener;
			BuildUI();
		}

		public void Init(bool CierreAutomatico)
		{
			_uiController = new mzCuentasSearchFormController();
			_cierreAutomatico = CierreAutomatico;
			BuildUI();
		}

		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar)
		{
			_uiController = new mzCuentasSearchFormController();
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;
			BuildUI();
		}

		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar, ISearchObjectListener listener)
		{
			_uiController = new mzCuentasSearchFormController();
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;			
			_searchObjectListener = listener;
			BuildUI();
		}


		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar, bool CierreAutomatico, bool HabilitaDetalles, ISearchObjectListener listener)
		{
			_uiController = new mzCuentasSearchFormController(); //Busqueda de Cliente para asignarlo a un comprobante de Venta.
			_cierreAutomatico = CierreAutomatico;
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;
			_habilitaDetalles = HabilitaDetalles;
			_searchObjectListener = listener;
			BuildUI();
		}

		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar, bool CierreAutomatico)
		{
			_uiController = new mzCuentasSearchFormController(); //Ingresa desde Datos/Consultar Datos/Clientes. Edicion de Clientes!
			_cierreAutomatico = CierreAutomatico;
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;
			BuildUI();
		}

		//Matias 20100603 - Tarea 16
		public void InitEditarCliente(bool HabilitaBotonNuevo, bool HabilitaBotonEditar, bool CierreAutomatico)
		{
			_uiController = new mzCuentasSearchFormController(); //Ingresa desde Datos/Consultar Datos/Clientes. Edicion de Clientes!
			_cierreAutomatico = CierreAutomatico;
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;
			_habilitaBotonAceptar = false; //no hay opcion de configuracion. Todo el formulario se encuentra "harcodeado".
			BuildUI();
		}
		//Fin Matias 20100603 - Tarea 16
		


		


		#endregion

		#region Metodos Privados

		private void BuildUI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();	;
		}

		private void InitDataBindings()
		{

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.gridResultado.Click +=new EventHandler(gridResultado_Click);
			this.gridResultado.KeyDown +=new KeyEventHandler(gridResultado_KeyDown);
			this.gridResultado.DoubleClick +=new EventHandler(gridResultado_DoubleClick);
			this.gridResultado.KeyUp +=new KeyEventHandler(gridResultado_KeyUp);
			_uiController.DetalleChanged +=new EventHandler(_uiController_DetalleChanged);
			this.KeyDown +=new KeyEventHandler(mzCuentasSearchForm_KeyDown);
			this.menuItemExportarExcel.Click +=new EventHandler(menuItemExportarExcel_Click);
			this.menuItemVerCtaCte.Click +=new EventHandler(menuItemVerCtaCte_Click);
			this.menuItemVerDetalleVentas.Click +=new EventHandler(menuItemVerDetalleVentas_Click);
			this.menuItemVerObservaciones.Click +=new EventHandler(menuItemVerObservaciones_Click);
			this.menuItemAgregarObservaciones.Click+=new EventHandler(menuItemAgregarObservaciones_Click);
			this.chekbuscarLoc.CheckedChanged+=new EventHandler(chekbuscarLoc_CheckedChanged);
			//Localidad
	this.mzCmbPaisEditar.SelectionChanged+=new EventHandler(mzCmbPaisEditar_SelectionChanged);
			this.mzCmbPciaEditar.SelectionChanged+=new EventHandler(mzCmbPciaEditar_SelectionChanged);

			this.uceResponsable.CheckedChanged+=new EventHandler(uceResponsable_CheckedChanged);
			this.uceEntreFechas.CheckedChanged+=new EventHandler(uceEntreFechas_CheckedChanged);

			this.KeyDown+=new KeyEventHandler(mzCuentasSearchForm_KeyDown);
            //Cristian Tarea 0000050 20110310
            this.udtFechaAltaDesde.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian

        }
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(udtFechaAltaDesde.Value)));
            this.udtFechaAltaHasta.Value = _uiController.FechaAltaHasta;

        }
        //Fin Cristian			


		private void InitializeData()
		{
			//mzCmbSrchEdtLocalidad.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Localidades );
			mzCmbSrchEdtTitular.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			mzCmbSrchEdtContacto.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			mzCETipoDoc.FillFromDataSource( businessrules.tsy_TiposDocumentos.GetList().tsy_TiposDocumentos, "idTipoDocumento", "Descripcion", 100, "1", "2", "Descripcion");
			txtCalle.Text = _uiController.Calle;
			txtCampoAux1.Text = _uiController.CampoAux1;
			txtCampoAux2.Text = _uiController.CampoAux2;
			txtCampoAux3.Text = _uiController.CampoAux3;
			txtCodigo.Text = _uiController.Codigo;
			txtEmail.Text = _uiController.Email;
			txtRazonSocial.Text = _uiController.Nombre;
			txtTelefonos.Text = _uiController.Telefonos;
			mzCETipoDoc.Value = _uiController.IdTipoDoc;
			//mzCmbSrchEdtLocalidad.DataValue = _uiController.IdLocalidad;
			mzCmbSrchEdtTitular.DataValue = _uiController.IdTitular;
			mzCmbSrchEdtContacto.DataValue = _uiController.IdContacto;
			chkActivo.Checked = _uiController.Activo;
			this.mzCmbPaisEditar.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbPaisEditar.Value=_uiController.IdPaisDefault;
			this.mzCmbPciaEditar.FillFromDataSource(_uiController.ProvinciasPais(_uiController.IdPaisDefault), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
			this.mzCmbPciaEditar.Value=_uiController.IdProvinciaDefault;
			this.mzCmbLocEditar.FillFromDataSource(_uiController.LocalidadPcia(_uiController.IdProvinciaDefault), _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
			this.mzCmbLocEditar.Value=_uiController.IdLocalidadDefault;
			
			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			mzCEResponsable.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
			mzCEResponsable.Value = _uiController.IdResponsable;
			udtFechaAltaDesde.Value = _uiController.FechaAltaDesde;
			udtFechaAltaDesde.Value = _uiController.FechaAltaHasta;
			// ---- Fin Matias

            /* Silvina 20111226 - Tarea 0000241 */
            mzSTBCampoAuxiliar6.Init("CUENTAS", true, _uiController.JerarquiaCampoAuxiliar6,_uiController.Separador);
            /* Fin Silvina 20111226 - Tarea 0000241 */
		}

		private void ConfigureInterface()
		{
			gridManagerView1.Configure(_uiController.ProcessName, _uiController.TaskName, this.Name, gridResultado, this.Text);
			hierarchicalSearchControl1.Build_UI("CUENTAS", _uiController.BuscadorJerarquicoAllowMultipleSelect);	

			if(_uiController.LabelCampoAuxiliar1 != null && _uiController.LabelCampoAuxiliar1 != string.Empty)
			{
				gridResultado.RootTable.Columns["CampoAuxiliar1"].Caption = _uiController.LabelCampoAuxiliar1;
			}
			if(_uiController.LabelCampoAuxiliar2 != null && _uiController.LabelCampoAuxiliar2 != string.Empty)
			{
				gridResultado.RootTable.Columns["CampoAuxiliar2"].Caption = _uiController.LabelCampoAuxiliar2;
			}
			if(_uiController.LabelCampoAuxiliar3 != null && _uiController.LabelCampoAuxiliar3 != string.Empty)
			{
				gridResultado.RootTable.Columns["CampoAuxiliar3"].Caption = _uiController.LabelCampoAuxiliar3;
			}

			if (!_uiController.SolapaDireccionesVisible) this.utcDetalles.Controls.Remove(this.utpDirecciones);
			if (!_uiController.SolapaContactosVisible) this.utcDetalles.Controls.Remove(this.utpContactos);
			if (!_uiController.SolapaBuscadorPrincicipalVisible) this.utcFiltros.Controls.Remove(this.utpFiltroPrincipal);
			if (!_uiController.SolapaBuscadorSecundarioVisible) this.utcFiltros.Controls.Remove(this.utpFiltroSecundario);
			if (!_uiController.SolapaBuscadorJerarquicoVisible) this.utcFiltros.Controls.Remove(this.utpFiltroJerarquico);
			if(this.utcFiltros.Tabs.Exists(_uiController.FiltroDefault))
				this.utcFiltros.SelectedTab = this.utcFiltros.Tabs[_uiController.FiltroDefault];
			else
				if(this.utcFiltros.Tabs.Count > 0)
					this.utcFiltros.SelectedTab = this.utcFiltros.Tabs[0];

			this.KeyPreview = true;	

			gridContactos.LayoutData = _uiController.LayoutContactos;
			gridDirecciones.LayoutData = _uiController.LayoutDirecciones;
			gridJerarquias.LayoutData = _uiController.LayoutJerarquias;
			labelCampoAux1.Text = _uiController.LabelCampoAuxiliar1;
			labelCampoAux2.Text = _uiController.LabelCampoAuxiliar2;
			labelCampoAux3.Text = _uiController.LabelCampoAuxiliar3;

			tbbNuevo.Enabled = _habilitaBotonNuevo && _uiController.HabilitaBotonNuevo();
			tbbEditar.Enabled = _habilitaBotonNuevo && _uiController.HabilitaBotonEditar();

			txtRazonSocial.Focus();
			menuItemExportarExcel.Enabled = gridManagerView1.AllowExportExcel;

			if (_habilitaDetalles)
			{
				menuItemVerCtaCte.Enabled = _uiController.HabilitaVerCuentaCorriente;
				tbbCuentaCorriente.Enabled = _uiController.HabilitaVerCuentaCorriente;
				menuItemVerObservaciones.Enabled = _uiController.HabilitaVerObservaciones;
				menuItemVerDetalleVentas.Enabled = _uiController.HabilitaVerDetalleVentas;
			}
			else 
			{
				menuItemVerCtaCte.Enabled = false;
				tbbCuentaCorriente.Enabled = false;
				menuItemVerObservaciones.Enabled = false;
				menuItemVerDetalleVentas.Enabled = false;
			}		
			gridManagerView1.Visible=true;
			this.groupboxLocalidades.Enabled=false;


			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			uceEntreFechas.Enabled = true;
			uceResponsable.Enabled = true;
			mzCEResponsable.Enabled = false;
			udtFechaAltaDesde.Enabled = false;
			udtFechaAltaHasta.Enabled = false;
			// ---- Fin Matias

			gridResultado.RecordNavigator = true;

            //Matias 20100603 - Tarea 16
			tbbAceptar.Enabled = _habilitaBotonAceptar;
			//Fin Matias 20100603 - Tarea 16

            /* Silvina 20111226 - Tarea 0000241 */
            utility.Util.LoadImagesBuscadorCuentas(toolBarStandar, imglStandar);
            lCampoAuxiliar6.Text = _uiController.LabelCampoAuxiliar6;

            if (_uiController.LabelCampoAuxiliar6 != null && _uiController.LabelCampoAuxiliar6 != string.Empty)
            {
                gridResultado.RootTable.Columns["CampoAuxiliar6"].Caption = _uiController.LabelCampoAuxiliar6;
            }
            /* Fin Silvina 20111226 - Tarea 0000241 */
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					this.RefreshData();
					break;
				case 2:
					this.ResetParameters();
					break;
				case 4:
					this.Nuevo();
					break;
				case 6:
                    mz.erp.systemframework.Util.InitTimer();
                    this.Editar();
                    Console.WriteLine("Termina Editar Mili " + mz.erp.systemframework.Util.GetTotalMilliseconds());
					break;
				case 8:/*Siguiente*/
					
					break;
				case 10:/*Siguiente*/
					
					break;
				case 12:
					this.Aceptar();
					break;
				case 14:
					this.CloseForm();
					break;
				case 16:
					this.CuentaCorriente();
					break;
				
			}		
		}


		public void RefreshData()
		{
			//_uiController.IdLocalidad = Convert.ToString(mzCmbSrchEdtLocalidad.DataValue);

			if((chekbuscarLoc.Checked)&& (mzCmbLocEditar.SelectedIndex!=-1))
			{
					string idLocalidad = (string)mzCmbLocEditar.Value;
				if (!idLocalidad.Equals(string.Empty))
				{
					_uiController.IdLocalidad=Convert.ToString(mzCmbLocEditar.Value);}
			}
			else
				_uiController.IdLocalidad=string.Empty;
			_uiController.IdTitular = Convert.ToString(mzCmbSrchEdtTitular.DataValue);
			_uiController.IdContacto = Convert.ToString(mzCmbSrchEdtContacto.DataValue);
			_uiController.IdTipoDoc = Convert.ToString(mzCETipoDoc.Value);
			_uiController.NroDoc = textBox1.Text;
			_uiController.Calle = txtCalle.Text ;
			_uiController.CampoAux1 = txtCampoAux1.Text;
			_uiController.CampoAux2 = txtCampoAux2.Text;
			_uiController.CampoAux3 = txtCampoAux3.Text;
			_uiController.Codigo = txtCodigo.Text;
			_uiController.Email = txtEmail.Text;
			_uiController.Nombre = txtRazonSocial.Text;
			_uiController.Telefonos = txtTelefonos.Text;
			_uiController.Activo = chkActivo.Checked;

			_uiController.IdResponsable = Convert.ToString(mzCEResponsable.Value);
			_uiController.FechaAltaDesde = Convert.ToDateTime(udtFechaAltaDesde.Value);
			_uiController.FechaAltaHasta = Convert.ToDateTime(udtFechaAltaHasta.Value);

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

            /* Silvina 20111226 - Tarea 0000241 */
            _uiController.CampoAux6 = mzSTBCampoAuxiliar6.NodeDescription;

            /* Fin Silvina 20111226 - Tarea 0000241 */

			DataView view = _uiController.RefreshData();
			gridResultado.DataSource =	view;

			if (gridResultado.DataSource!=null && gridResultado.RecordCount > 0 && gridResultado.SelectedItems.Count > 0)
				_uiController.VerDetalle( gridResultado.SelectedItems[0].GetRow().DataRow );
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(view.Table);
			
		}

		public void ResetParameters()
		{
			hierarchicalSearchControl1.NodeChecked1 = false;			
			hierarchicalSearchControl1.NodeChecked2 = false;			
			hierarchicalSearchControl1.NodeChecked3 = false;			
			hierarchicalSearchControl1.NodeChecked4 = false;			
			hierarchicalSearchControl1.NodeChecked5 = false;			
			hierarchicalSearchControl1.NodeChecked6 = false;			
			hierarchicalSearchControl1.NodeChecked7 = false;			
			hierarchicalSearchControl1.NodeChecked8 = false;						
			_uiController.ByJerarquia1 = false;
			_uiController.ByJerarquia2 = false;
			_uiController.ByJerarquia3 = false;
			_uiController.ByJerarquia4 = false;
			_uiController.ByJerarquia5 = false;
			_uiController.ByJerarquia6 = false;
			_uiController.ByJerarquia7 = false;
			_uiController.ByJerarquia8 = false;
			txtEmail.Text = string.Empty;
			txtRazonSocial.Text = string.Empty;
			txtTelefonos.Text = string.Empty;
			txtCodigo.Text = string.Empty;
			txtCampoAux3.Text = string.Empty;
			txtCampoAux2.Text = string.Empty;
			txtCampoAux1.Text = string.Empty;
			txtCalle.Text = string.Empty;
			mzCETipoDoc.ResetText();
			//mzCmbSrchEdtLocalidad.DataValue = string.Empty;
			mzCmbSrchEdtTitular.DataValue = string.Empty;
			mzCmbSrchEdtContacto.DataValue = string.Empty;
			textBox1.Text = "";	
			chkActivo.Checked = true;
			//Localidades
			groupboxLocalidades.Enabled=false;
			chekbuscarLoc.Checked=false;
			this.mzCmbPaisEditar.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbPaisEditar.Value=_uiController.IdPaisDefault;
			this.mzCmbPciaEditar.FillFromDataSource(_uiController.ProvinciasPais(_uiController.IdPaisDefault), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
			this.mzCmbPciaEditar.Value=_uiController.IdProvinciaDefault;
			this.mzCmbLocEditar.FillFromDataSource(_uiController.LocalidadPcia(_uiController.IdProvinciaDefault), _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
			this.mzCmbLocEditar.Value=_uiController.IdLocalidadDefault;

			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			uceEntreFechas.Checked = false;
			uceResponsable.Checked = false;
			_uiController.IdResponsable = string.Empty;
			mzCEResponsable.Value = string.Empty;
			udtFechaAltaDesde.Value = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
			udtFechaAltaHasta.Value = mz.erp.businessrules.Sistema.DateTime.Now;
			// ---- Fin Matias            			

		}

		private void gridResultado_Click(object sender, EventArgs e)
		{
			Detail();
		}

		private void gridResultado_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
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

		private void Select()
		{
			if (_cierreAutomatico) 
			{		
				BuildSelected();
				this.DialogResult = System.Windows.Forms.DialogResult.OK;
				this.Close();
			}
		}
		

		private void gridResultado_DoubleClick(object sender, EventArgs e)
		{
			Select();
		}

		private void gridResultado_KeyUp(object sender, KeyEventArgs e)
		{
			Detail();
		}

		private void Detail()
		{
			if (gridResultado.SelectedItems.Count > 0)
			{
				_uiController.VerDetalle( gridResultado.SelectedItems[0].GetRow().DataRow );
			}
		}

		private void _uiController_DetalleChanged(object sender, EventArgs e)
		{
			gridDirecciones.SetDataBinding(null, null);
			gridDirecciones.SetDataBinding(_uiController.DataDomicilios, null);
			gridContactos.SetDataBinding(null, null);
			gridContactos.SetDataBinding(_uiController.DataContactos, null);
			gridJerarquias.SetDataBinding(null, null);
			gridJerarquias.SetDataBinding(_uiController.DataJerarquias, null);
			
			
		}

		private void Aceptar()
		{
			BuildSelected();
			this.DialogResult = System.Windows.Forms.DialogResult.OK;	
			this.Close();
		}

		private void Cancelar()
		{					
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;	
			this.Close();
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

		private void CuentaCorriente()
		{					
			if (_uiController.IdCuentaSeleccionado == String.Empty)
			{
				if(gridResultado.RecordCount > 0)
				{
					gridResultado.Row = 0; 
					Detail();					
				}
			}
			

			if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{				
				FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteCliente", _uiController.CodigoSeleccionado);
				frmcc.MdiParent = mz.erp.ui.utility.Environment.MainForm;
				frmcc.Show();											
			}
		}

		private void Nuevo()
		{
											
			this.Cursor = Cursors.WaitCursor;
			FrmAbmCuentas form = new FrmAbmCuentas();
			if(_searchObjectListener != null)
			{
				EventInfo ei = form.GetType().GetEvent( "OnRowChanged" );
				Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, _searchObjectListener, "processEventChange" );
				ei.AddEventHandler(form, del1);

			}
			form.OnRowChanged += new mz.erp.ui.forms.FrmABMEx.RowChanged(EventoRefrescar);
			form.ShowForm(null, "NEW",txtRazonSocial.Text, "Nueva Cuenta");
			this.Cursor = Cursors.Default;
			if(_searchObjectListener != null)
				this.Visible = false;
		}

		private void Editar()
		{
			if(this.gridResultado.SelectedItems.Count > 0 && _uiController.IdCuentaSeleccionado != String.Empty)
			{
				this.Cursor = Cursors.WaitCursor;
				FrmAbmCuentas form = new FrmAbmCuentas();
				if(_searchObjectListener != null)
				{
					EventInfo ei = form.GetType().GetEvent( "OnRowChanged" );
					Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, _searchObjectListener, "processEventChange" );
					ei.AddEventHandler(form, del1);

				}
				form.OnRowChanged += new mz.erp.ui.forms.FrmABMEx.RowChanged(EventoRefrescar);
				form.ShowForm(_uiController.IdCuentaSeleccionado,"READONLY", "Datos de " + _uiController.NombreSeleccionado);
				this.Cursor = Cursors.Default;
				if(_searchObjectListener != null)
					this.Visible = false;
			}
		}

		private void EventoRefrescar( object sender, EventArgs args )
		{			
			
		}

		private void BuildSelected()
		{
			for (int i=0;i < gridResultado.SelectedItems.Count  ;i++)
			{
				_selectedItems.Add(((System.Data.DataRowView) gridResultado.SelectedItems[ i ].GetRow().DataRow).Row);
			}
			if (gridResultado.SelectedItems.Count > 0)
			{
				_uiController.VerDetalle( gridResultado.SelectedItems[0].GetRow().DataRow );
				this._selectedNombre = _uiController.NombreSeleccionado;
				this._selectedCodigo = _uiController.CodigoSeleccionado;
				this._selectedIdCuenta = _uiController.IdCuentaSeleccionado;
				this._datarow = ((System.Data.DataRowView) gridResultado.SelectedItems[ 0 ].GetRow().DataRow).Row;
			}

		}

		private void mzCuentasSearchForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F2 :
					this.RefreshData();					
					break;
				case System.Windows.Forms.Keys.PageDown :
					gridResultado.Focus();
					break;
				case System.Windows.Forms.Keys.Escape :
					this.Close();
					break;
				default:
					break;
			}
		}

		private void menuItemExportarExcel_Click(object sender, EventArgs e)
		{
			if(gridResultado.RecordCount > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				string fileName = string.Empty;
				SaveFileDialog saveFileDialog1 = new SaveFileDialog();
				saveFileDialog1.Filter = "Excel files (*.xls)|*.xls"  ;
				saveFileDialog1.RestoreDirectory = true ;
				if(saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					fileName = saveFileDialog1.FileName;
					gridManagerView1.SetView((DataView)gridResultado.DataSource);
					gridManagerView1.ExportToExcel(fileName);

				}
				this.Cursor = Cursors.Default;
			}

		}

		private void menuItemVerCtaCte_Click(object sender, EventArgs e)
		{	
			if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				this.Cursor = Cursors.WaitCursor;
				/* Cta Cte anterior 
				FrmVisualizacionCuentaCorriente frmVCC= new FrmVisualizacionCuentaCorriente("ProcesoCuentaCorrienteCliente", _uiController.CodigoSeleccionado);
				frmVCC.MdiParent = mz.erp.ui.utility.Environment.MainForm;			
				frmVCC.Show();
				*/
				// Matias - Nueva Cta Cte - 23/10/2008.
				FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteCliente", _uiController.CodigoSeleccionado);
				frmcc.MdiParent = mz.erp.ui.utility.Environment.MainForm;
				frmcc.Show();
				// --
				this.Cursor = Cursors.Default;
			}
		}

		private void menuItemVerDetalleVentas_Click(object sender, EventArgs e)
		{
			
		}

		private void menuItemVerObservaciones_Click(object sender, EventArgs e)
		{
			if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				this.Cursor = Cursors.WaitCursor;
				mzCuentasObservacionesSearchForm csf = new mzCuentasObservacionesSearchForm(_uiController.IdCuentaSeleccionado, "CUENTA");
				csf.MdiParent = mz.erp.ui.utility.Environment.MainForm;		
				csf.ShowForm();
				this.Cursor = Cursors.Default;
			}
		}

		private void menuItemAgregarObservaciones_Click(object sender, EventArgs e)
		{
			if(gridResultado.SelectedItems.Count > 0 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				this.Cursor = Cursors.WaitCursor;
				_uiController.GetParameters();
				ProcessLoader.CallProcess( "ProcesoABMCuentasObservaciones", _uiController.Parametros);				
				this.Cursor = Cursors.Default;
			}
		}
		private void chekbuscarLoc_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chekbuscarLoc.Checked)
				this.groupboxLocalidades.Enabled=true;
			else
				this.groupboxLocalidades.Enabled=false;
		}

		#endregion

		private void mzCmbPaisEditar_SelectionChanged(object sender, EventArgs e)
		{
			long idPaisSeleccionado = (long)mzCmbPaisEditar.Value;
			if(!idPaisSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbPciaEditar.FillFromDataSource(_uiController.ProvinciasPais(idPaisSeleccionado), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
				if(mzCmbPciaEditar.Items.Count!=0)
				{
					mzCmbPciaEditar.Enabled=true;
					mzCmbLocEditar.Enabled=false;
					mzCmbPciaEditar.SelectedIndex = 0;
											
				}
				else 
				{
					mzCmbPciaEditar.SelectedIndex=-1;
					mzCmbPciaEditar.Enabled=false;
					mzCmbLocEditar.SelectedIndex=-1;
					mzCmbLocEditar.Enabled=false;
						
				}
					
				
			}

		}

		private void mzCmbPciaEditar_SelectionChanged(object sender, EventArgs e)
		{
			long idProvinciaSeleccionado = (long)mzCmbPciaEditar.Value;
			if(!idProvinciaSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbLocEditar.FillFromDataSource(_uiController.LocalidadPcia(idProvinciaSeleccionado), _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
				if(mzCmbLocEditar.Items.Count!=0)
				{	
					mzCmbLocEditar.Enabled=true;
					mzCmbLocEditar.SelectedIndex = 0;

									
				}
				else 
				{
					mzCmbLocEditar.Enabled=false;
					mzCmbLocEditar.SelectedIndex=-1;
											
				}
							
			}

		}

		private void uceResponsable_CheckedChanged(object sender, EventArgs e)
		{
			if (this.uceResponsable.Checked)
			{
				_uiController.BuscarPorResponsable=true;
				mzCEResponsable.Enabled=true;
			}
			else
			{
				_uiController.BuscarPorResponsable=false;
				mzCEResponsable.Enabled=false;
			}
		}

		private void uceEntreFechas_CheckedChanged(object sender, EventArgs e)
		{
			if (this.uceEntreFechas.Checked)
			{
				_uiController.BuscarPorFechaAlta=true;
				udtFechaAltaDesde.Enabled=true;
				udtFechaAltaHasta.Enabled=true;
			}
			else
			{
				_uiController.BuscarPorFechaAlta=false;
				udtFechaAltaDesde.Enabled=false;
				udtFechaAltaHasta.Enabled=false;
			}

		}
	}
}


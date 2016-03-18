using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de frmProveedores.
	/// </summary>
	public class mzProveedoresSearchForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbBuscar;
		private System.Windows.Forms.ToolBarButton tbbSeparador1;
		private System.Windows.Forms.ToolBarButton tbbNuevaBusqueda;
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
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcFiltros;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage2;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroPrincipal;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtTelefonos;
		private System.Windows.Forms.TextBox txtRazonSocial;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtTitular;
        private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroSecundario;
		private System.Windows.Forms.TextBox txtCampoAux3;
		private System.Windows.Forms.Label labelCampoAux3;
		private System.Windows.Forms.TextBox txtCampoAux2;
		private System.Windows.Forms.Label labelCampoAux2;
		private System.Windows.Forms.TextBox txtCampoAux1;
		private System.Windows.Forms.Label labelCampoAux1;
		private System.Windows.Forms.TextBox txtEmail;
		private mz.erp.ui.controls.mzComboEditor mzCETipoDoc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcDetalles;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpDirecciones;
		private Janus.Windows.GridEX.GridEX gridDirecciones;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpContactos;
		private Janus.Windows.GridEX.GridEX gridContactos;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.TextBox txtCampoAux4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCampoAuxiliar5;
		private System.Windows.Forms.Label labelCampoAux4;
		private System.Windows.Forms.Label labelCampoAux5;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivoCAux5;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl1;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.TextBox txtdocumento;
		private mz.erp.ui.controls.mzComboEditor mzCmbPaisEditar;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private mz.erp.ui.controls.mzComboEditor mzCmbPciaEditar;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private mz.erp.ui.controls.mzComboEditor mzCmbLocEditar;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private System.Windows.Forms.GroupBox groupboxLocalidades;
		private System.Windows.Forms.Label txtLocalidad;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chekbuscarLoc;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTiposMovimiento;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposMovimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkExcluyeRetencionesIIBB;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkExcluyeRetencionesIVA;
		private System.Windows.Forms.Label label6;
		private mz.erp.ui.controls.mzComboEditor mzCECondicionesRetecionesGanancias;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivoExcluyeRetIBB;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivoExcluyeRetIVA;
		private mz.erp.ui.controls.mzComboEditor mzComboCondicionCompra;
		private System.Windows.Forms.Label label9;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceEntreFechas;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaHasta;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaDesde;
		private System.Windows.Forms.Label lFecha;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceResponsable;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsable;
		private System.Windows.Forms.Label label10;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private System.ComponentModel.IContainer components;

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
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab4 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            Infragistics.Win.UltraWinTabControl.UltraTab ultraTab5 = new Infragistics.Win.UltraWinTabControl.UltraTab();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mzProveedoresSearchForm));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.utpFiltroPrincipal = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.uceEntreFechas = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.udtFechaAltaHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.udtFechaAltaDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.lFecha = new System.Windows.Forms.Label();
            this.uceResponsable = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.mzCEResponsable = new mz.erp.ui.controls.mzComboEditor();
            this.label10 = new System.Windows.Forms.Label();
            this.chekbuscarLoc = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtLocalidad = new System.Windows.Forms.Label();
            this.groupboxLocalidades = new System.Windows.Forms.GroupBox();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmbPaisEditar = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmbPciaEditar = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbLocEditar = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCalle = new System.Windows.Forms.TextBox();
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
            this.mzComboCondicionCompra = new mz.erp.ui.controls.mzComboEditor();
            this.label9 = new System.Windows.Forms.Label();
            this.chkActivoExcluyeRetIVA = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkActivoExcluyeRetIBB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.mzCECondicionesRetecionesGanancias = new mz.erp.ui.controls.mzComboEditor();
            this.chkExcluyeRetencionesIIBB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkExcluyeRetencionesIVA = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.mzCmbSubTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.chkActivoCAux5 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.uneCampoAuxiliar5 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelCampoAux5 = new System.Windows.Forms.Label();
            this.txtCampoAux4 = new System.Windows.Forms.TextBox();
            this.labelCampoAux4 = new System.Windows.Forms.Label();
            this.txtCampoAux3 = new System.Windows.Forms.TextBox();
            this.labelCampoAux3 = new System.Windows.Forms.Label();
            this.txtCampoAux2 = new System.Windows.Forms.TextBox();
            this.labelCampoAux2 = new System.Windows.Forms.Label();
            this.txtCampoAux1 = new System.Windows.Forms.TextBox();
            this.labelCampoAux1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mzCETipoDoc = new mz.erp.ui.controls.mzComboEditor();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ultraTabPageControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.utpDirecciones = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.gridDirecciones = new Janus.Windows.GridEX.GridEX();
            this.utpContactos = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
            this.gridContactos = new Janus.Windows.GridEX.GridEX();
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
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.utpFiltroPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).BeginInit();
            this.groupboxLocalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPaisEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPciaEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbLocEditar)).BeginInit();
            this.utpFiltroSecundario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboCondicionCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesRetecionesGanancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCampoAuxiliar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoDoc)).BeginInit();
            this.ultraTabPageControl1.SuspendLayout();
            this.utpDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDirecciones)).BeginInit();
            this.utpContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).BeginInit();
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
            this.utpFiltroPrincipal.Controls.Add(this.uceEntreFechas);
            this.utpFiltroPrincipal.Controls.Add(this.udtFechaAltaHasta);
            this.utpFiltroPrincipal.Controls.Add(this.udtFechaAltaDesde);
            this.utpFiltroPrincipal.Controls.Add(this.lFecha);
            this.utpFiltroPrincipal.Controls.Add(this.uceResponsable);
            this.utpFiltroPrincipal.Controls.Add(this.mzCEResponsable);
            this.utpFiltroPrincipal.Controls.Add(this.label10);
            this.utpFiltroPrincipal.Controls.Add(this.chekbuscarLoc);
            this.utpFiltroPrincipal.Controls.Add(this.txtLocalidad);
            this.utpFiltroPrincipal.Controls.Add(this.groupboxLocalidades);
            this.utpFiltroPrincipal.Controls.Add(this.txtCalle);
            this.utpFiltroPrincipal.Controls.Add(this.label5);
            this.utpFiltroPrincipal.Controls.Add(this.txtCodigo);
            this.utpFiltroPrincipal.Controls.Add(this.txtTelefonos);
            this.utpFiltroPrincipal.Controls.Add(this.txtRazonSocial);
            this.utpFiltroPrincipal.Controls.Add(this.label3);
            this.utpFiltroPrincipal.Controls.Add(this.label4);
            this.utpFiltroPrincipal.Controls.Add(this.label2);
            this.utpFiltroPrincipal.Controls.Add(this.label1);
            this.utpFiltroPrincipal.Controls.Add(this.mzCmbSrchEdtTitular);
            this.utpFiltroPrincipal.Location = new System.Drawing.Point(1, 24);
            this.utpFiltroPrincipal.Name = "utpFiltroPrincipal";
            this.utpFiltroPrincipal.Size = new System.Drawing.Size(1071, 158);
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(468, 33);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(67, 28);
            this.chkActivo.TabIndex = 2;
            this.chkActivo.Text = "Activo";
            // 
            // uceEntreFechas
            // 
            this.uceEntreFechas.BackColor = System.Drawing.Color.Transparent;
            this.uceEntreFechas.BackColorInternal = System.Drawing.Color.Transparent;
            this.uceEntreFechas.Location = new System.Drawing.Point(1045, 127);
            this.uceEntreFechas.Name = "uceEntreFechas";
            this.uceEntreFechas.Size = new System.Drawing.Size(16, 17);
            this.uceEntreFechas.TabIndex = 13;
            // 
            // udtFechaAltaHasta
            // 
            this.udtFechaAltaHasta.Location = new System.Drawing.Point(877, 125);
            this.udtFechaAltaHasta.Name = "udtFechaAltaHasta";
            this.udtFechaAltaHasta.Size = new System.Drawing.Size(163, 24);
            this.udtFechaAltaHasta.TabIndex = 1213;
            // 
            // udtFechaAltaDesde
            // 
            this.udtFechaAltaDesde.Location = new System.Drawing.Point(694, 125);
            this.udtFechaAltaDesde.Name = "udtFechaAltaDesde";
            this.udtFechaAltaDesde.Size = new System.Drawing.Size(163, 24);
            this.udtFechaAltaDesde.TabIndex = 12;
            // 
            // lFecha
            // 
            this.lFecha.BackColor = System.Drawing.Color.Transparent;
            this.lFecha.Location = new System.Drawing.Point(588, 127);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(125, 18);
            this.lFecha.TabIndex = 122;
            this.lFecha.Text = "Fecha de alta";
            this.lFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uceResponsable
            // 
            this.uceResponsable.BackColor = System.Drawing.Color.Transparent;
            this.uceResponsable.BackColorInternal = System.Drawing.Color.Transparent;
            this.uceResponsable.Location = new System.Drawing.Point(397, 127);
            this.uceResponsable.Name = "uceResponsable";
            this.uceResponsable.Size = new System.Drawing.Size(19, 18);
            this.uceResponsable.TabIndex = 6;
            // 
            // mzCEResponsable
            // 
            this.mzCEResponsable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsable.DisplayMember = "";
            this.mzCEResponsable.DisplayMemberCaption = "";
            this.mzCEResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsable.Location = new System.Drawing.Point(133, 125);
            this.mzCEResponsable.MaxItemsDisplay = 7;
            this.mzCEResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsable.Name = "mzCEResponsable";
            this.mzCEResponsable.Size = new System.Drawing.Size(259, 24);
            this.mzCEResponsable.SorterMember = "";
            this.mzCEResponsable.TabIndex = 5;
            this.mzCEResponsable.ValueMember = "";
            this.mzCEResponsable.ValueMemberCaption = "";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 118;
            this.label10.Text = "Responsable de alta";
            // 
            // chekbuscarLoc
            // 
            this.chekbuscarLoc.BackColor = System.Drawing.Color.Transparent;
            this.chekbuscarLoc.BackColorInternal = System.Drawing.Color.Transparent;
            this.chekbuscarLoc.Location = new System.Drawing.Point(701, 28);
            this.chekbuscarLoc.Name = "chekbuscarLoc";
            this.chekbuscarLoc.Size = new System.Drawing.Size(17, 18);
            this.chekbuscarLoc.TabIndex = 8;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(576, 37);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(77, 18);
            this.txtLocalidad.TabIndex = 14;
            this.txtLocalidad.Text = "Localidad";
            // 
            // groupboxLocalidades
            // 
            this.groupboxLocalidades.Controls.Add(this.ultraLabel6);
            this.groupboxLocalidades.Controls.Add(this.mzCmbPaisEditar);
            this.groupboxLocalidades.Controls.Add(this.ultraLabel4);
            this.groupboxLocalidades.Controls.Add(this.mzCmbPciaEditar);
            this.groupboxLocalidades.Controls.Add(this.mzCmbLocEditar);
            this.groupboxLocalidades.Controls.Add(this.ultraLabel7);
            this.groupboxLocalidades.Location = new System.Drawing.Point(695, 28);
            this.groupboxLocalidades.Name = "groupboxLocalidades";
            this.groupboxLocalidades.Size = new System.Drawing.Size(365, 92);
            this.groupboxLocalidades.TabIndex = 13;
            this.groupboxLocalidades.TabStop = false;
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(24, 14);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(34, 23);
            this.ultraLabel6.TabIndex = 126;
            this.ultraLabel6.Text = "País";
            // 
            // mzCmbPaisEditar
            // 
            this.mzCmbPaisEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbPaisEditar.DisplayMember = "";
            this.mzCmbPaisEditar.DisplayMemberCaption = "";
            this.mzCmbPaisEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbPaisEditar.Location = new System.Drawing.Point(86, 9);
            this.mzCmbPaisEditar.MaxItemsDisplay = 7;
            this.mzCmbPaisEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbPaisEditar.Name = "mzCmbPaisEditar";
            this.mzCmbPaisEditar.Size = new System.Drawing.Size(260, 24);
            this.mzCmbPaisEditar.SorterMember = "";
            this.mzCmbPaisEditar.TabIndex = 9;
            this.mzCmbPaisEditar.ValueMember = "";
            this.mzCmbPaisEditar.ValueMemberCaption = "";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(24, 42);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(38, 23);
            this.ultraLabel4.TabIndex = 125;
            this.ultraLabel4.Text = "Pcía";
            // 
            // mzCmbPciaEditar
            // 
            this.mzCmbPciaEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbPciaEditar.DisplayMember = "";
            this.mzCmbPciaEditar.DisplayMemberCaption = "";
            this.mzCmbPciaEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbPciaEditar.Location = new System.Drawing.Point(86, 37);
            this.mzCmbPciaEditar.MaxItemsDisplay = 7;
            this.mzCmbPciaEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbPciaEditar.Name = "mzCmbPciaEditar";
            this.mzCmbPciaEditar.Size = new System.Drawing.Size(260, 24);
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
            this.mzCmbLocEditar.Location = new System.Drawing.Point(86, 65);
            this.mzCmbLocEditar.MaxItemsDisplay = 7;
            this.mzCmbLocEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbLocEditar.Name = "mzCmbLocEditar";
            this.mzCmbLocEditar.Size = new System.Drawing.Size(260, 24);
            this.mzCmbLocEditar.SorterMember = "";
            this.mzCmbLocEditar.TabIndex = 11;
            this.mzCmbLocEditar.ValueMember = "";
            this.mzCmbLocEditar.ValueMemberCaption = "";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(24, 69);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(67, 23);
            this.ultraLabel7.TabIndex = 128;
            this.ultraLabel7.Text = "Localidad";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(694, 5);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(345, 22);
            this.txtCalle.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(576, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Calle";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(134, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(327, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(134, 59);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(327, 22);
            this.txtTelefonos.TabIndex = 3;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(134, 3);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(327, 22);
            this.txtRazonSocial.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfonos";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Titular";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
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
            this.mzCmbSrchEdtTitular.Location = new System.Drawing.Point(133, 91);
            this.mzCmbSrchEdtTitular.Name = "mzCmbSrchEdtTitular";
            this.mzCmbSrchEdtTitular.ReadOnly = false;
            this.mzCmbSrchEdtTitular.SearchObject = null;
            this.mzCmbSrchEdtTitular.SearchObjectListener = null;
            this.mzCmbSrchEdtTitular.Size = new System.Drawing.Size(432, 22);
            this.mzCmbSrchEdtTitular.TabIndex = 4;
            // 
            // utpFiltroSecundario
            // 
            this.utpFiltroSecundario.Controls.Add(this.mzComboCondicionCompra);
            this.utpFiltroSecundario.Controls.Add(this.label9);
            this.utpFiltroSecundario.Controls.Add(this.chkActivoExcluyeRetIVA);
            this.utpFiltroSecundario.Controls.Add(this.chkActivoExcluyeRetIBB);
            this.utpFiltroSecundario.Controls.Add(this.label6);
            this.utpFiltroSecundario.Controls.Add(this.mzCECondicionesRetecionesGanancias);
            this.utpFiltroSecundario.Controls.Add(this.chkExcluyeRetencionesIIBB);
            this.utpFiltroSecundario.Controls.Add(this.chkExcluyeRetencionesIVA);
            this.utpFiltroSecundario.Controls.Add(this.mzCmbSubTiposMovimiento);
            this.utpFiltroSecundario.Controls.Add(this.mzCmbTiposMovimiento);
            this.utpFiltroSecundario.Controls.Add(this.ultraLabel10);
            this.utpFiltroSecundario.Controls.Add(this.chkActivoCAux5);
            this.utpFiltroSecundario.Controls.Add(this.uneCampoAuxiliar5);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux5);
            this.utpFiltroSecundario.Controls.Add(this.txtCampoAux4);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux4);
            this.utpFiltroSecundario.Controls.Add(this.txtCampoAux3);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux3);
            this.utpFiltroSecundario.Controls.Add(this.txtCampoAux2);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux2);
            this.utpFiltroSecundario.Controls.Add(this.txtCampoAux1);
            this.utpFiltroSecundario.Controls.Add(this.labelCampoAux1);
            this.utpFiltroSecundario.Controls.Add(this.txtEmail);
            this.utpFiltroSecundario.Controls.Add(this.mzCETipoDoc);
            this.utpFiltroSecundario.Controls.Add(this.txtdocumento);
            this.utpFiltroSecundario.Controls.Add(this.label7);
            this.utpFiltroSecundario.Controls.Add(this.label8);
            this.utpFiltroSecundario.Location = new System.Drawing.Point(-12000, -11538);
            this.utpFiltroSecundario.Name = "utpFiltroSecundario";
            this.utpFiltroSecundario.Size = new System.Drawing.Size(1071, 158);
            // 
            // mzComboCondicionCompra
            // 
            this.mzComboCondicionCompra.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboCondicionCompra.DisplayMember = "";
            this.mzComboCondicionCompra.DisplayMemberCaption = "";
            this.mzComboCondicionCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboCondicionCompra.Location = new System.Drawing.Point(931, 28);
            this.mzComboCondicionCompra.MaxItemsDisplay = 7;
            this.mzComboCondicionCompra.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboCondicionCompra.Name = "mzComboCondicionCompra";
            this.mzComboCondicionCompra.Size = new System.Drawing.Size(173, 24);
            this.mzComboCondicionCompra.SorterMember = "";
            this.mzComboCondicionCompra.TabIndex = 14;
            this.mzComboCondicionCompra.ValueMember = "";
            this.mzComboCondicionCompra.ValueMemberCaption = "";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(787, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 18);
            this.label9.TabIndex = 115;
            this.label9.Text = "Condición de compra";
            // 
            // chkActivoExcluyeRetIVA
            // 
            this.chkActivoExcluyeRetIVA.BackColor = System.Drawing.Color.Transparent;
            this.chkActivoExcluyeRetIVA.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivoExcluyeRetIVA.Location = new System.Drawing.Point(787, 53);
            this.chkActivoExcluyeRetIVA.Name = "chkActivoExcluyeRetIVA";
            this.chkActivoExcluyeRetIVA.Size = new System.Drawing.Size(19, 28);
            this.chkActivoExcluyeRetIVA.TabIndex = 15;
            this.chkActivoExcluyeRetIVA.CheckedChanged += new System.EventHandler(this.chkActivoExcluyeRetIVA_CheckedChanged);
            // 
            // chkActivoExcluyeRetIBB
            // 
            this.chkActivoExcluyeRetIBB.BackColor = System.Drawing.Color.Transparent;
            this.chkActivoExcluyeRetIBB.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivoExcluyeRetIBB.Location = new System.Drawing.Point(787, 81);
            this.chkActivoExcluyeRetIBB.Name = "chkActivoExcluyeRetIBB";
            this.chkActivoExcluyeRetIBB.Size = new System.Drawing.Size(19, 27);
            this.chkActivoExcluyeRetIBB.TabIndex = 17;
            this.chkActivoExcluyeRetIBB.CheckedChanged += new System.EventHandler(this.chkActivoExcluyeRetIBB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(787, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 111;
            this.label6.Text = "Cond. Ret. Ganancias";
            // 
            // mzCECondicionesRetecionesGanancias
            // 
            this.mzCECondicionesRetecionesGanancias.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCECondicionesRetecionesGanancias.DisplayMember = "";
            this.mzCECondicionesRetecionesGanancias.DisplayMemberCaption = "";
            this.mzCECondicionesRetecionesGanancias.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCECondicionesRetecionesGanancias.Location = new System.Drawing.Point(931, 0);
            this.mzCECondicionesRetecionesGanancias.MaxItemsDisplay = 7;
            this.mzCECondicionesRetecionesGanancias.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCECondicionesRetecionesGanancias.Name = "mzCECondicionesRetecionesGanancias";
            this.mzCECondicionesRetecionesGanancias.Size = new System.Drawing.Size(173, 24);
            this.mzCECondicionesRetecionesGanancias.SorterMember = "";
            this.mzCECondicionesRetecionesGanancias.TabIndex = 13;
            this.mzCECondicionesRetecionesGanancias.ValueMember = "";
            this.mzCECondicionesRetecionesGanancias.ValueMemberCaption = "";
            // 
            // chkExcluyeRetencionesIIBB
            // 
            this.chkExcluyeRetencionesIIBB.BackColor = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIIBB.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIIBB.Location = new System.Drawing.Point(816, 83);
            this.chkExcluyeRetencionesIIBB.Name = "chkExcluyeRetencionesIIBB";
            this.chkExcluyeRetencionesIIBB.Size = new System.Drawing.Size(182, 23);
            this.chkExcluyeRetencionesIIBB.TabIndex = 18;
            this.chkExcluyeRetencionesIIBB.Text = "Excluye retenciones IIBB";
            // 
            // chkExcluyeRetencionesIVA
            // 
            this.chkExcluyeRetencionesIVA.BackColor = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIVA.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIVA.Location = new System.Drawing.Point(816, 55);
            this.chkExcluyeRetencionesIVA.Name = "chkExcluyeRetencionesIVA";
            this.chkExcluyeRetencionesIVA.Size = new System.Drawing.Size(182, 23);
            this.chkExcluyeRetencionesIVA.TabIndex = 16;
            this.chkExcluyeRetencionesIVA.Text = "Excluye retenciones IVA";
            // 
            // mzCmbSubTiposMovimiento
            // 
            this.mzCmbSubTiposMovimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbSubTiposMovimiento.DisplayMember = "";
            this.mzCmbSubTiposMovimiento.DisplayMemberCaption = "";
            this.mzCmbSubTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbSubTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.mzCmbSubTiposMovimiento.Location = new System.Drawing.Point(432, 93);
            this.mzCmbSubTiposMovimiento.MaxItemsDisplay = 7;
            this.mzCmbSubTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbSubTiposMovimiento.Name = "mzCmbSubTiposMovimiento";
            this.mzCmbSubTiposMovimiento.Size = new System.Drawing.Size(288, 24);
            this.mzCmbSubTiposMovimiento.SorterMember = "";
            this.mzCmbSubTiposMovimiento.TabIndex = 12;
            this.mzCmbSubTiposMovimiento.ValueMember = "";
            this.mzCmbSubTiposMovimiento.ValueMemberCaption = "";
            // 
            // mzCmbTiposMovimiento
            // 
            this.mzCmbTiposMovimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTiposMovimiento.DisplayMember = "";
            this.mzCmbTiposMovimiento.DisplayMemberCaption = "";
            this.mzCmbTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.mzCmbTiposMovimiento.Location = new System.Drawing.Point(125, 93);
            this.mzCmbTiposMovimiento.MaxItemsDisplay = 7;
            this.mzCmbTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTiposMovimiento.Name = "mzCmbTiposMovimiento";
            this.mzCmbTiposMovimiento.Size = new System.Drawing.Size(288, 24);
            this.mzCmbTiposMovimiento.SorterMember = "";
            this.mzCmbTiposMovimiento.TabIndex = 11;
            this.mzCmbTiposMovimiento.ValueMember = "";
            this.mzCmbTiposMovimiento.ValueMemberCaption = "";
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel10.Location = new System.Drawing.Point(4, 93);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(144, 19);
            this.ultraLabel10.TabIndex = 106;
            this.ultraLabel10.Text = "Tipo de Movimiento";
            // 
            // chkActivoCAux5
            // 
            this.chkActivoCAux5.BackColor = System.Drawing.Color.Transparent;
            this.chkActivoCAux5.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivoCAux5.Location = new System.Drawing.Point(710, 46);
            this.chkActivoCAux5.Name = "chkActivoCAux5";
            this.chkActivoCAux5.Size = new System.Drawing.Size(20, 28);
            this.chkActivoCAux5.TabIndex = 9;
            this.chkActivoCAux5.CheckedChanged += new System.EventHandler(this.chkActivoCAux5_CheckedChanged);
            // 
            // uneCampoAuxiliar5
            // 
            this.uneCampoAuxiliar5.Location = new System.Drawing.Point(566, 46);
            this.uneCampoAuxiliar5.MaskInput = "nnnnnnnn.nnnn";
            this.uneCampoAuxiliar5.Name = "uneCampoAuxiliar5";
            this.uneCampoAuxiliar5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCampoAuxiliar5.Size = new System.Drawing.Size(120, 24);
            this.uneCampoAuxiliar5.TabIndex = 8;
            this.uneCampoAuxiliar5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelCampoAux5
            // 
            this.labelCampoAux5.Location = new System.Drawing.Point(422, 46);
            this.labelCampoAux5.Name = "labelCampoAux5";
            this.labelCampoAux5.Size = new System.Drawing.Size(125, 19);
            this.labelCampoAux5.TabIndex = 21;
            this.labelCampoAux5.Text = "CampoAux5";
            // 
            // txtCampoAux4
            // 
            this.txtCampoAux4.Location = new System.Drawing.Point(538, 23);
            this.txtCampoAux4.Name = "txtCampoAux4";
            this.txtCampoAux4.Size = new System.Drawing.Size(240, 22);
            this.txtCampoAux4.TabIndex = 7;
            // 
            // labelCampoAux4
            // 
            this.labelCampoAux4.Location = new System.Drawing.Point(422, 23);
            this.labelCampoAux4.Name = "labelCampoAux4";
            this.labelCampoAux4.Size = new System.Drawing.Size(125, 19);
            this.labelCampoAux4.TabIndex = 19;
            this.labelCampoAux4.Text = "CampoAux4";
            // 
            // txtCampoAux3
            // 
            this.txtCampoAux3.Location = new System.Drawing.Point(538, 0);
            this.txtCampoAux3.Name = "txtCampoAux3";
            this.txtCampoAux3.Size = new System.Drawing.Size(240, 22);
            this.txtCampoAux3.TabIndex = 6;
            // 
            // labelCampoAux3
            // 
            this.labelCampoAux3.Location = new System.Drawing.Point(422, 0);
            this.labelCampoAux3.Name = "labelCampoAux3";
            this.labelCampoAux3.Size = new System.Drawing.Size(125, 18);
            this.labelCampoAux3.TabIndex = 17;
            this.labelCampoAux3.Text = "CampoAux3";
            // 
            // txtCampoAux2
            // 
            this.txtCampoAux2.Location = new System.Drawing.Point(125, 70);
            this.txtCampoAux2.Name = "txtCampoAux2";
            this.txtCampoAux2.Size = new System.Drawing.Size(288, 22);
            this.txtCampoAux2.TabIndex = 4;
            // 
            // labelCampoAux2
            // 
            this.labelCampoAux2.Location = new System.Drawing.Point(4, 70);
            this.labelCampoAux2.Name = "labelCampoAux2";
            this.labelCampoAux2.Size = new System.Drawing.Size(120, 19);
            this.labelCampoAux2.TabIndex = 15;
            this.labelCampoAux2.Text = "CampoAux2";
            // 
            // txtCampoAux1
            // 
            this.txtCampoAux1.Location = new System.Drawing.Point(125, 47);
            this.txtCampoAux1.Name = "txtCampoAux1";
            this.txtCampoAux1.Size = new System.Drawing.Size(288, 22);
            this.txtCampoAux1.TabIndex = 3;
            // 
            // labelCampoAux1
            // 
            this.labelCampoAux1.Location = new System.Drawing.Point(4, 47);
            this.labelCampoAux1.Name = "labelCampoAux1";
            this.labelCampoAux1.Size = new System.Drawing.Size(120, 19);
            this.labelCampoAux1.TabIndex = 13;
            this.labelCampoAux1.Text = "CampoAux1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 24);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // mzCETipoDoc
            // 
            this.mzCETipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCETipoDoc.DisplayMember = "";
            this.mzCETipoDoc.DisplayMemberCaption = "";
            this.mzCETipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCETipoDoc.ImageTransparentColor = System.Drawing.Color.Violet;
            this.mzCETipoDoc.Location = new System.Drawing.Point(125, 0);
            this.mzCETipoDoc.MaxItemsDisplay = 7;
            this.mzCETipoDoc.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCETipoDoc.Name = "mzCETipoDoc";
            this.mzCETipoDoc.Size = new System.Drawing.Size(144, 24);
            this.mzCETipoDoc.SorterMember = "";
            this.mzCETipoDoc.TabIndex = 0;
            this.mzCETipoDoc.ValueMember = "";
            this.mzCETipoDoc.ValueMemberCaption = "";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(269, 0);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(144, 22);
            this.txtdocumento.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tipo y Nro de Doc";
            // 
            // ultraTabPageControl1
            // 
            this.ultraTabPageControl1.Controls.Add(this.hierarchicalSearchControl1);
            this.ultraTabPageControl1.Location = new System.Drawing.Point(-12000, -11538);
            this.ultraTabPageControl1.Name = "ultraTabPageControl1";
            this.ultraTabPageControl1.Size = new System.Drawing.Size(1071, 158);
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(1078, 129);
            this.hierarchicalSearchControl1.TabIndex = 1;
            // 
            // utpDirecciones
            // 
            this.utpDirecciones.Controls.Add(this.gridDirecciones);
            this.utpDirecciones.Location = new System.Drawing.Point(1, 24);
            this.utpDirecciones.Name = "utpDirecciones";
            this.utpDirecciones.Size = new System.Drawing.Size(961, 203);
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
            this.gridDirecciones.Size = new System.Drawing.Size(961, 203);
            this.gridDirecciones.TabIndex = 7;
            this.gridDirecciones.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // utpContactos
            // 
            this.utpContactos.Controls.Add(this.gridContactos);
            this.utpContactos.Location = new System.Drawing.Point(-12000, -11538);
            this.utpContactos.Name = "utpContactos";
            this.utpContactos.Size = new System.Drawing.Size(961, 203);
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
            this.gridContactos.Location = new System.Drawing.Point(-2, 8);
            this.gridContactos.Name = "gridContactos";
            this.gridContactos.RecordNavigatorText = "Registro:|de";
            this.gridContactos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridContactos.ShowEmptyFields = false;
            this.gridContactos.Size = new System.Drawing.Size(965, 185);
            this.gridContactos.TabIndex = 7;
            this.gridContactos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.utcFiltros);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 50);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(906, 180);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // utcFiltros
            // 
            this.utcFiltros.BackColorInternal = System.Drawing.Color.Transparent;
            this.utcFiltros.Controls.Add(this.ultraTabSharedControlsPage2);
            this.utcFiltros.Controls.Add(this.utpFiltroPrincipal);
            this.utcFiltros.Controls.Add(this.utpFiltroSecundario);
            this.utcFiltros.Controls.Add(this.ultraTabPageControl1);
            this.utcFiltros.Location = new System.Drawing.Point(0, 0);
            this.utcFiltros.Name = "utcFiltros";
            this.utcFiltros.SharedControlsPage = this.ultraTabSharedControlsPage2;
            this.utcFiltros.Size = new System.Drawing.Size(1075, 185);
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
            ultraTab3.Key = "FiltroJerarquico";
            ultraTab3.TabPage = this.ultraTabPageControl1;
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
            this.ultraTabSharedControlsPage2.Size = new System.Drawing.Size(1071, 158);
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.AutoScroll = true;
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.utcDetalles);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 290);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(906, 415);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(19, 37);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(893, 28);
            this.gridManagerView1.TabIndex = 17;
            this.gridManagerView1.Visible = false;
            // 
            // utcDetalles
            // 
            this.utcDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.utcDetalles.BackColorInternal = System.Drawing.Color.Transparent;
            this.utcDetalles.Controls.Add(this.ultraTabSharedControlsPage1);
            this.utcDetalles.Controls.Add(this.utpDirecciones);
            this.utcDetalles.Controls.Add(this.utpContactos);
            this.utcDetalles.Location = new System.Drawing.Point(0, 185);
            this.utcDetalles.Name = "utcDetalles";
            this.utcDetalles.SharedControlsPage = this.ultraTabSharedControlsPage1;
            this.utcDetalles.Size = new System.Drawing.Size(965, 230);
            this.utcDetalles.TabIndex = 16;
            ultraTab4.Key = "Domicilios";
            ultraTab4.TabPage = this.utpDirecciones;
            ultraTab4.Text = "Domicilios y Teléfonos";
            ultraTab5.Key = "Contactos";
            ultraTab5.TabPage = this.utpContactos;
            ultraTab5.Text = "Contactos";
            this.utcDetalles.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
            ultraTab4,
            ultraTab5});
            this.utcDetalles.Visible = false;
            // 
            // ultraTabSharedControlsPage1
            // 
            this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
            this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(961, 203);
            // 
            // gridResultado
            // 
            this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridResultado.AlternatingColors = true;
            this.gridResultado.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResultado.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridResultado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridResultado.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridResultado.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridResultado.GroupByBoxVisible = false;
            this.gridResultado.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridResultado.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridResultado.Location = new System.Drawing.Point(0, 0);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.RecordNavigatorText = "Registro:|de";
            this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridResultado.ShowEmptyFields = false;
            this.gridResultado.Size = new System.Drawing.Size(912, 415);
            this.gridResultado.TabIndex = 6;
            this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
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
            this.imglStandar.Images.SetKeyName(10, "");
            this.imglStandar.Images.SetKeyName(11, "");
            this.imglStandar.Images.SetKeyName(12, "");
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
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(976, 28);
            this.toolBarStandar.TabIndex = 49;
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
            this.tbbSeprardor6.Visible = false;
            // 
            // tbbAceptar
            // 
            this.tbbAceptar.ImageIndex = 12;
            this.tbbAceptar.Name = "tbbAceptar";
            this.tbbAceptar.Text = "Aceptar";
            this.tbbAceptar.Visible = false;
            // 
            // tbbSeparator7
            // 
            this.tbbSeparator7.Name = "tbbSeparator7";
            this.tbbSeparator7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbbSeparator7.Visible = false;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "Cancelar";
            this.tbbCancelar.Visible = false;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 180;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Filtros";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 415;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Detalle";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Scrollbars = Infragistics.Win.UltraWinExplorerBar.ScrollbarStyle.Always;
            this.ultraExplorerBar1.Size = new System.Drawing.Size(976, 481);
            this.ultraExplorerBar1.TabIndex = 81;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // mzProveedoresSearchForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(976, 509);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "mzProveedoresSearchForm";
            this.Text = "Búsqueda de proveedores";
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
            ((System.ComponentModel.ISupportInitialize)(this.mzComboCondicionCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesRetecionesGanancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneCampoAuxiliar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoDoc)).EndInit();
            this.ultraTabPageControl1.ResumeLayout(false);
            this.utpDirecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDirecciones)).EndInit();
            this.utpContactos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).EndInit();
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

		public mzProveedoresSearchForm()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			//Init();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
			}
			base.Dispose( disposing );
		}

		#region Variables Privadas
			
		private  mzProveedoresSearchFormController _uiController = null;		
		private bool _cierreAutomatico = true;
		private bool _habilitaBotonNuevo = true;
		private bool _habilitaBotonEditar = true;
		private bool _habilitaDetalles = true;
		private ArrayList _selectedItems = new ArrayList();
		private string _selectedIdProveedor = string.Empty;
		private string _selectedCodigo = string.Empty;
		private string _selectedNombre = string.Empty;
		private System.Data.DataRow _datarow = null;
		private ISearchObjectListener _searchObjectListener;
		
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

		public string SelectedIdProveedor
		{
			get { return _selectedIdProveedor ; }
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
			_uiController = new mzProveedoresSearchFormController();
			_cierreAutomatico = CierreAutomatico;
			_searchObjectListener = listener;
			BuildUI();
		}

		public void Init(bool CierreAutomatico)
		{
			_uiController = new mzProveedoresSearchFormController();
			_cierreAutomatico = CierreAutomatico;
			BuildUI();
		}

		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar)
		{
			_uiController = new mzProveedoresSearchFormController();
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;
			BuildUI();
		}

		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar, ISearchObjectListener listener)
		{
			_uiController = new mzProveedoresSearchFormController();
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;			
			_searchObjectListener = listener;
			BuildUI();
		}


		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar, bool CierreAutomatico, bool HabilitaDetalles, ISearchObjectListener listener)
		{
			_uiController = new mzProveedoresSearchFormController();
			_cierreAutomatico = CierreAutomatico;
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;
			_habilitaDetalles = HabilitaDetalles;
			_searchObjectListener = listener;
			BuildUI();
		}

		public void Init()
		{
			_uiController = new mzProveedoresSearchFormController();
			_cierreAutomatico = false;
			_habilitaBotonNuevo = _uiController.HabilitaBotonNuevo();
			_habilitaBotonEditar = _uiController.HabilitaBotonEditar();
			BuildUI();
		}

		public void Init(bool HabilitaBotonNuevo, bool HabilitaBotonEditar, bool CierreAutomatico)
		{
			_uiController = new mzProveedoresSearchFormController();
			_cierreAutomatico = CierreAutomatico;
			_habilitaBotonNuevo = HabilitaBotonNuevo;
			_habilitaBotonEditar = HabilitaBotonEditar;
			BuildUI();
		}


		#endregion

		#region Metodos Privados

		private void BuildUI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();	;
		}

		private void ConfigureInterface()
		{
			gridManagerView1.Configure(_uiController.ProcessName, _uiController.TaskName, gridResultado, this.Text);
			this.utcFiltros.SelectedTab = this.utcFiltros.Tabs[0];	
			txtRazonSocial.Focus();
			this.KeyPreview = true;
			this.hierarchicalSearchControl1.Build_UI("PROVEEDORES", _uiController.BuscadorJerarquicoAllowMultipleSelect);	
			labelCampoAux1.Text = _uiController.EtiquetaCampoAuxiliar1;
			labelCampoAux2.Text = _uiController.EtiquetaCampoAuxiliar2;
			labelCampoAux3.Text = _uiController.EtiquetaCampoAuxiliar3;
			labelCampoAux4.Text = _uiController.EtiquetaCampoAuxiliar4;
			labelCampoAux5.Text = _uiController.EtiquetaCampoAuxiliar5;
			groupboxLocalidades.Enabled=false;
			chkActivoCAux5.Checked = false;
			uneCampoAuxiliar5.Enabled = false;
			chkActivoExcluyeRetIBB.Checked = false;
			chkActivoExcluyeRetIVA.Checked = false;
			chkExcluyeRetencionesIVA.Enabled = false;
			chkExcluyeRetencionesIIBB.Enabled = false;


			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			uceEntreFechas.Enabled = true;
			uceResponsable.Enabled = true;
			mzCEResponsable.Enabled = false;
			udtFechaAltaDesde.Enabled = false;
			udtFechaAltaHasta.Enabled = false;
			// ---- Fin Matias			


			gridResultado.RecordNavigator = true;
			


		}
		private void InitializeData()
		{
			mzCmbSrchEdtTitular.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			mzCETipoDoc.FillFromDataSource( businessrules.tsy_TiposDocumentos.GetList().tsy_TiposDocumentos, "idTipoDocumento", "Descripcion", 100, "1", "2", "Descripcion");
			chkActivo.Checked = _uiController.Activo;
			this.mzCmbPaisEditar.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbPaisEditar.Value=_uiController.IdPaisDefault;
			this.mzCmbPciaEditar.FillFromDataSource(_uiController.ProvinciasPais(_uiController.IdPaisDefault), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
			this.mzCmbPciaEditar.Value=_uiController.IdProvinciaDefault;
			this.mzCmbLocEditar.FillFromDataSource(_uiController.LocalidadPcia(_uiController.IdProvinciaDefault), _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
			this.mzCmbLocEditar.Value=_uiController.IdLocalidadDefault;
			mzCmbTiposMovimiento.FillFromDataSource( _uiController.TiposMovimientos, "IdTipoMovimiento","Descripcion",8,"ID","Descripcion","Descripcion");
			mzCmbSubTiposMovimiento.FillFromDataSource( _uiController.SubTiposMovimientos, "IdSubTipoMovimiento","Descripcion",8,"ID","Descripcion","Descripcion");
			mzComboCondicionCompra.FillFromDataSource( _uiController.CondicionesDeCompra, "IdCondicionDeCompra","Descripcion",8,"ID","Descripcion","Descripcion");
			mzCECondicionesRetecionesGanancias.FillFromDataSource(mz.erp.businessrules.tpu_ProveedoresCondicionesImpuestoGanancias.GetList().tpu_ProveedoresCondicionesImpuestoGanancias,"IdCondicionImpuestoGanancias", "Descripcion",8,"ID","Condiciones","IdCondicionImpuestoGanancias");
			
			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			mzCEResponsable.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
			mzCEResponsable.Value = _uiController.IdResponsable;
			udtFechaAltaDesde.Value = _uiController.FechaAltaDesde;
			udtFechaAltaDesde.Value = _uiController.FechaAltaHasta;
			// ---- Fin Matias
		}

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

		
		private void InitDataBindings()
		{

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);			
			this.gridResultado.Click +=new EventHandler(gridResultado_Click);
			this.gridResultado.KeyDown +=new KeyEventHandler(gridResultado_KeyDown);
			this.gridResultado.DoubleClick +=new EventHandler(gridResultado_DoubleClick);
			this.gridResultado.KeyUp +=new KeyEventHandler(gridResultado_KeyUp);
			this.KeyDown +=new KeyEventHandler(mzCuentasSearchForm_KeyDown);
			this.chekbuscarLoc.CheckedChanged+=new EventHandler(chekbuscarLoc_CheckedChanged);
			//Localidad
			this.mzCmbPaisEditar.SelectionChanged+=new EventHandler(mzCmbPaisEditar_SelectionChanged);
			this.mzCmbPciaEditar.SelectionChanged+=new EventHandler(mzCmbPciaEditar_SelectionChanged);

			this.uceResponsable.CheckedChanged+=new EventHandler(uceResponsable_CheckedChanged);
			this.uceEntreFechas.CheckedChanged+=new EventHandler(uceEntreFechas_CheckedChanged);			
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
					this.Editar();
					break;
				
				
			}		
		}


		public void RefreshData()
		{
			this.Cursor = Cursors.WaitCursor;
			_uiController.Codigo = txtCodigo.Text;
			_uiController.Nombre = txtRazonSocial.Text;
			//Nuevos vivi
			_uiController.Telefonos=txtTelefonos.Text;
			_uiController.Titular=Convert.ToString(mzCmbSrchEdtTitular.DataValue);
			if((chekbuscarLoc.Checked)&& (mzCmbLocEditar.SelectedIndex!=-1))
				{string idLocalidad = (string)mzCmbLocEditar.Value;
				if (!idLocalidad.Equals(string.Empty))
				{
					_uiController.Localidad=Convert.ToString(mzCmbLocEditar.Value);}
				}
			else
				_uiController.Localidad=string.Empty;
			_uiController.Calle=txtCalle.Text;
			_uiController.TipoDocumento=Convert.ToString(mzCETipoDoc.Value);
			_uiController.Activo=chkActivo.Checked;
			_uiController.Documento=txtdocumento.Text;
			_uiController.Email=txtEmail.Text;

			//Fin Vivi
			_uiController.CampoAux1 = txtCampoAux1.Text;
			_uiController.CampoAux2 = txtCampoAux2.Text;
			_uiController.CampoAux3 = txtCampoAux3.Text;
			_uiController.CampoAux4 = txtCampoAux4.Text;
			_uiController.CampoAux5 = Convert.ToDecimal(uneCampoAuxiliar5.Value);
			_uiController.CampoAux5Activo = chkActivoCAux5.Checked;
			_uiController.IdTipoMovimiento = Convert.ToString(mzCmbTiposMovimiento.Value);
			_uiController.IdSubTipoMovimiento = Convert.ToString(mzCmbSubTiposMovimiento.Value);
			_uiController.IdCondicionDeCompra = Convert.ToString(mzComboCondicionCompra.Value);
			if(mzCECondicionesRetecionesGanancias.SelectedIndex!=-1)
				_uiController.CondicionImpuestoGanancias = (long)mzCECondicionesRetecionesGanancias.Value;
			else
				_uiController.CondicionImpuestoGanancias = long.MinValue;
			_uiController.ExcluyeRetencionIVAActivo = chkActivoExcluyeRetIVA.Checked;
			_uiController.ExcluyeRetencionIVA = chkExcluyeRetencionesIVA.Checked;
			_uiController.ExcluyeRetencionIIBBActivo = chkActivoExcluyeRetIBB.Checked;
			_uiController.ExcluyeRetencionIIBB = chkExcluyeRetencionesIIBB.Checked;


			_uiController.IdResponsable = Convert.ToString(mzCEResponsable.Value);
			_uiController.FechaAltaDesde = Convert.ToDateTime(udtFechaAltaDesde.Value);
			_uiController.FechaAltaHasta = Convert.ToDateTime(udtFechaAltaHasta.Value);

			System.Data.DataView view = _uiController.RefreshData();
			gridResultado.DataSource =	view;
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(view.Table);

			this.Cursor = Cursors.Default;

		}

		public void ResetParameters()
		{
			txtEmail.Text = string.Empty;
			txtRazonSocial.Text = string.Empty;
			txtTelefonos.Text = string.Empty;
			txtCodigo.Text = string.Empty;
			txtCampoAux1.Text = string.Empty;
			txtCampoAux2.Text = string.Empty;
			txtCampoAux3.Text = string.Empty;
			txtCampoAux4.Text = string.Empty;
			uneCampoAuxiliar5.Value = null;
			txtCalle.Text = string.Empty;
			mzCETipoDoc.ResetText();
			//mzCmbSrchEdtLocalidad.DataValue = string.Empty;
			mzCmbSrchEdtTitular.DataValue = string.Empty;
			txtdocumento.Text = "";	
			chkActivo.Checked = true;
			chkActivoCAux5.Checked = false;
			chkActivoExcluyeRetIBB.Checked  = false;
			chkActivoExcluyeRetIVA.Checked  = false;
			chkExcluyeRetencionesIIBB.Enabled = false;
			chkExcluyeRetencionesIVA.Enabled = false;
			mzCECondicionesRetecionesGanancias.ResetText();
			mzCmbSubTiposMovimiento.ResetText();
			mzCmbTiposMovimiento.ResetText();
			mzComboCondicionCompra.ResetText();
			/*hierarchicalSearchControl1.NodeChecked1 = false;			
			hierarchicalSearchControl1.NodeChecked2 = false;			
			hierarchicalSearchControl1.NodeChecked3 = false;			
			hierarchicalSearchControl1.NodeChecked4 = false;			
			hierarchicalSearchControl1.NodeChecked5 = false;			
			hierarchicalSearchControl1.NodeChecked6 = false;			
			hierarchicalSearchControl1.NodeChecked7 = false;			
			hierarchicalSearchControl1.NodeChecked8 = false;	*/
			_uiController.ByJerarquia1 = false;
			_uiController.ByJerarquia2 = false;
			_uiController.ByJerarquia3 = false;
			_uiController.ByJerarquia4 = false;
			_uiController.ByJerarquia5 = false;
			_uiController.ByJerarquia6 = false;
			_uiController.ByJerarquia7 = false;
			_uiController.ByJerarquia8 = false;
			//Reset localidad
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
		
		private void BuildSelected()
		{
			for (int i=0;i < gridResultado.SelectedItems.Count  ;i++)
			{
				_selectedItems.Add(((System.Data.DataRowView) gridResultado.SelectedItems[ i ].GetRow().DataRow).Row);
			}
			if (gridResultado.SelectedItems.Count > 0)
			{
				_uiController.VerDetalle( gridResultado.SelectedItems[0].GetRow().DataRow );
				this._selectedNombre = _uiController.NombreProveedor;
				this._selectedCodigo = _uiController.CodigoSeleccionado;
				this._selectedIdProveedor = _uiController.IdProveedorSeleccionado;
				this._datarow = ((System.Data.DataRowView) gridResultado.SelectedItems[ 0 ].GetRow().DataRow).Row;
			     
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
							
		}

		

		private void Nuevo()
		{				
			this.Cursor = Cursors.WaitCursor;
			FrmAbmProveedores prov = new FrmAbmProveedores();
			prov.MdiParent = this.MdiParent;
			prov.Show();
			this.Cursor = Cursors.Default;				
		
		}

		private void Editar()
		{											
			if(this.gridResultado.SelectedItems.Count > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				FrmAbmProveedores prov = new FrmAbmProveedores(_uiController.IdProveedorSeleccionado);				
				prov.MdiParent = this.MdiParent;
				prov.Show();
				this.Cursor = Cursors.Default;
				
			}
		}

		private void EventoRefrescar( object sender, EventArgs args )
		{			
			
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

		private void chkActivoCAux5_CheckedChanged(object sender, System.EventArgs e)
		{
			uneCampoAuxiliar5.Enabled = chkActivoCAux5.Checked;
		}

		private void chkActivoExcluyeRetIVA_CheckedChanged(object sender, System.EventArgs e)
		{
			chkExcluyeRetencionesIVA.Enabled = chkActivoExcluyeRetIVA.Checked;
		}
		private void chkActivoExcluyeRetIBB_CheckedChanged(object sender, System.EventArgs e)
		{
			chkExcluyeRetencionesIIBB.Enabled = chkActivoExcluyeRetIBB.Checked;
		}

		#endregion

		private void chekbuscarLoc_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chekbuscarLoc.Checked)
				this.groupboxLocalidades.Enabled=true;
			else
				this.groupboxLocalidades.Enabled=false;
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

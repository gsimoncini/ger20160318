using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmModificarPreciosMasivoDesdeExcel.
	/// </summary>
	public class FrmModificarPreciosMasivoDesdeExcel : System.Windows.Forms.Form,ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerItems;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.GroupBox groupBoxCampoDeBusqueda;
		private System.Windows.Forms.RadioButton rbPorCodigoProveedor;
		private System.Windows.Forms.RadioButton rbPorCodigoSecundario;
		private System.Windows.Forms.RadioButton rbPorCodigo;
		private Infragistics.Win.Misc.UltraButton btnVerDatos;
		private mz.erp.ui.controls.mzProveedoresControl mzCmbProveedores;
		private System.Windows.Forms.GroupBox groupBoxInsercion;
		private System.Windows.Forms.CheckBox chckAgregaProductosNuevos;
		private System.Windows.Forms.GroupBox groupBoxProductosNuevos;
		private System.Windows.Forms.CheckBox chckPercibeIB;
		private System.Windows.Forms.GroupBox groupBoxImpuestos;
		private System.Windows.Forms.RadioButton rbEx;
		private System.Windows.Forms.RadioButton rbIVADif;
		private System.Windows.Forms.RadioButton rbIVA;
		private System.Windows.Forms.CheckBox chckModificaBonificaciones;
		private System.Windows.Forms.CheckBox chckModificaPrecioDeCosto;
		private System.Windows.Forms.TextBox txtFileName;
		private Infragistics.Win.Misc.UltraButton btnFileChooser;
		private System.Windows.Forms.CheckBox chkModificaInactivos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private Infragistics.Win.Misc.UltraButton btnVerDatosVenta;
		private System.Windows.Forms.TextBox txtFileNameVenta;
		private Infragistics.Win.Misc.UltraButton btnFileChooserVenta;
		private System.Windows.Forms.GroupBox groupBoxCampoDeBusquedaVenta;
		private System.Windows.Forms.RadioButton rbPorCodigoSecundarioVenta;
		private System.Windows.Forms.RadioButton rbPorCodigoVenta;
		private System.Windows.Forms.CheckBox chckPcioDeVtaContieneImpuestos;
		private System.Windows.Forms.CheckBox chkModificaInactivosVenta;
		private System.Windows.Forms.GroupBox groupBoxInsercionVenta;
		private System.Windows.Forms.CheckBox chckAgregaProductosNuevosVenta;
		private System.Windows.Forms.CheckBox chckPercibeIBVenta;
		private System.Windows.Forms.GroupBox groupBoxProductosNuevosVenta;
		private System.Windows.Forms.CheckBox chkModificaCamposAuxiliares;
		private System.Windows.Forms.CheckBox chkModificaCodigoSecundario;
		private System.Windows.Forms.CheckBox chkModificaCodigoProveedor;
		private System.Windows.Forms.CheckBox chkModificaJerarquia1;
		private System.Windows.Forms.CheckBox chkModificaJerarquia2;
		private System.Windows.Forms.CheckBox chkModificaDescripcion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkModificaJerarquia5;
		private System.Windows.Forms.CheckBox chkModificaJerarquia3;
		private System.Windows.Forms.CheckBox chkModificaJerarquia4;
		private System.Windows.Forms.CheckBox chkModificaJerarquia6;
		private System.Windows.Forms.CheckBox chkModificaJerarquia7;
		private System.Windows.Forms.CheckBox chkModificaJerarquia8;
		private System.Windows.Forms.CheckBox chckAgregaLPProvNuevas;
		private Infragistics.Win.Misc.UltraButton btnTodos;
		private Infragistics.Win.Misc.UltraButton btnInvertir;
		private Infragistics.Win.Misc.UltraButton btnNinguno;
		private Infragistics.Win.Misc.UltraButton btnVerSeleccionados;
		private Infragistics.Win.Misc.UltraButton btnVerTodas;
		private System.Windows.Forms.GroupBox groupListasDePrecios;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkListasDePrecios;
        private CheckBox chkModificaPrecioDeVenta;
        private GroupBox groupBoxListasDePrecios2;
        private Infragistics.Win.Misc.UltraButton btnTodos2;
        private Infragistics.Win.Misc.UltraButton btnInvertir2;
        private Infragistics.Win.Misc.UltraButton btnNinguno2;
        private Infragistics.Win.Misc.UltraButton btnVerSeleccionados2;
        private Infragistics.Win.Misc.UltraButton btnVerTodas2;
        private controls.ToolTipCheckedListBox chkListasDePrecios2;
        private CheckBox chkPrecioDeVentaTieneImpuestos;
        private GroupBox groupBox3;
        private Janus.Windows.GridEX.GridEX gridProductos;
        private GroupBox groupBox2;
        private controls.GridManagerView gridManagerView1;
        private Infragistics.Win.Misc.UltraButton bDetallesProducto;
        private Infragistics.Win.Misc.UltraButton bAgregarProducto;
        
        
        
		private System.ComponentModel.IContainer components;


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
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupBoxListasDePrecios2 = new System.Windows.Forms.GroupBox();
            this.chkPrecioDeVentaTieneImpuestos = new System.Windows.Forms.CheckBox();
            this.btnTodos2 = new Infragistics.Win.Misc.UltraButton();
            this.btnInvertir2 = new Infragistics.Win.Misc.UltraButton();
            this.btnNinguno2 = new Infragistics.Win.Misc.UltraButton();
            this.btnVerSeleccionados2 = new Infragistics.Win.Misc.UltraButton();
            this.btnVerTodas2 = new Infragistics.Win.Misc.UltraButton();
            this.chkModificaPrecioDeVenta = new System.Windows.Forms.CheckBox();
            this.groupListasDePrecios = new System.Windows.Forms.GroupBox();
            this.btnTodos = new Infragistics.Win.Misc.UltraButton();
            this.btnInvertir = new Infragistics.Win.Misc.UltraButton();
            this.btnNinguno = new Infragistics.Win.Misc.UltraButton();
            this.btnVerSeleccionados = new Infragistics.Win.Misc.UltraButton();
            this.btnVerTodas = new Infragistics.Win.Misc.UltraButton();
            this.chkModificaInactivos = new System.Windows.Forms.CheckBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileChooser = new Infragistics.Win.Misc.UltraButton();
            this.chckModificaPrecioDeCosto = new System.Windows.Forms.CheckBox();
            this.chckModificaBonificaciones = new System.Windows.Forms.CheckBox();
            this.groupBoxInsercion = new System.Windows.Forms.GroupBox();
            this.chckAgregaProductosNuevos = new System.Windows.Forms.CheckBox();
            this.groupBoxProductosNuevos = new System.Windows.Forms.GroupBox();
            this.chckPercibeIB = new System.Windows.Forms.CheckBox();
            this.groupBoxImpuestos = new System.Windows.Forms.GroupBox();
            this.rbEx = new System.Windows.Forms.RadioButton();
            this.rbIVADif = new System.Windows.Forms.RadioButton();
            this.rbIVA = new System.Windows.Forms.RadioButton();
            this.chckAgregaLPProvNuevas = new System.Windows.Forms.CheckBox();
            this.btnVerDatos = new Infragistics.Win.Misc.UltraButton();
            this.groupBoxCampoDeBusqueda = new System.Windows.Forms.GroupBox();
            this.rbPorCodigoProveedor = new System.Windows.Forms.RadioButton();
            this.rbPorCodigoSecundario = new System.Windows.Forms.RadioButton();
            this.rbPorCodigo = new System.Windows.Forms.RadioButton();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkModificaDescripcion = new System.Windows.Forms.CheckBox();
            this.chkModificaCodigoProveedor = new System.Windows.Forms.CheckBox();
            this.chkModificaCodigoSecundario = new System.Windows.Forms.CheckBox();
            this.chkModificaCamposAuxiliares = new System.Windows.Forms.CheckBox();
            this.chkModificaInactivosVenta = new System.Windows.Forms.CheckBox();
            this.groupBoxInsercionVenta = new System.Windows.Forms.GroupBox();
            this.chckAgregaProductosNuevosVenta = new System.Windows.Forms.CheckBox();
            this.groupBoxProductosNuevosVenta = new System.Windows.Forms.GroupBox();
            this.chckPercibeIBVenta = new System.Windows.Forms.CheckBox();
            this.chckPcioDeVtaContieneImpuestos = new System.Windows.Forms.CheckBox();
            this.groupBoxCampoDeBusquedaVenta = new System.Windows.Forms.GroupBox();
            this.rbPorCodigoSecundarioVenta = new System.Windows.Forms.RadioButton();
            this.rbPorCodigoVenta = new System.Windows.Forms.RadioButton();
            this.txtFileNameVenta = new System.Windows.Forms.TextBox();
            this.btnFileChooserVenta = new Infragistics.Win.Misc.UltraButton();
            this.btnVerDatosVenta = new Infragistics.Win.Misc.UltraButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkModificaJerarquia6 = new System.Windows.Forms.CheckBox();
            this.chkModificaJerarquia7 = new System.Windows.Forms.CheckBox();
            this.chkModificaJerarquia8 = new System.Windows.Forms.CheckBox();
            this.chkModificaJerarquia5 = new System.Windows.Forms.CheckBox();
            this.chkModificaJerarquia3 = new System.Windows.Forms.CheckBox();
            this.chkModificaJerarquia4 = new System.Windows.Forms.CheckBox();
            this.chkModificaJerarquia1 = new System.Windows.Forms.CheckBox();
            this.chkModificaJerarquia2 = new System.Windows.Forms.CheckBox();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.containerItems = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bDetallesProducto = new Infragistics.Win.Misc.UltraButton();
            this.bAgregarProducto = new Infragistics.Win.Misc.UltraButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.chkListasDePrecios2 = new mz.erp.ui.controls.ToolTipCheckedListBox();
            this.chkListasDePrecios = new mz.erp.ui.controls.ToolTipCheckedListBox();
            this.mzCmbProveedores = new mz.erp.ui.controls.mzProveedoresControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.groupBoxListasDePrecios2.SuspendLayout();
            this.groupListasDePrecios.SuspendLayout();
            this.groupBoxInsercion.SuspendLayout();
            this.groupBoxProductosNuevos.SuspendLayout();
            this.groupBoxImpuestos.SuspendLayout();
            this.groupBoxCampoDeBusqueda.SuspendLayout();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.groupBoxInsercionVenta.SuspendLayout();
            this.groupBoxProductosNuevosVenta.SuspendLayout();
            this.groupBoxCampoDeBusquedaVenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            this.containerItems.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
            this.ultraExplorerBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(1348, 27);
            this.ultraExplorerBarContainerControl2.TabIndex = 2;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(1348, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxListasDePrecios2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkModificaPrecioDeVenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupListasDePrecios);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkModificaInactivos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtFileName);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.btnFileChooser);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chckModificaPrecioDeCosto);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chckModificaBonificaciones);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxInsercion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.btnVerDatos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBoxCampoDeBusqueda);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbProveedores);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 108);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(1348, 262);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // groupBoxListasDePrecios2
            // 
            this.groupBoxListasDePrecios2.Controls.Add(this.chkPrecioDeVentaTieneImpuestos);
            this.groupBoxListasDePrecios2.Controls.Add(this.btnTodos2);
            this.groupBoxListasDePrecios2.Controls.Add(this.btnInvertir2);
            this.groupBoxListasDePrecios2.Controls.Add(this.btnNinguno2);
            this.groupBoxListasDePrecios2.Controls.Add(this.btnVerSeleccionados2);
            this.groupBoxListasDePrecios2.Controls.Add(this.btnVerTodas2);
            this.groupBoxListasDePrecios2.Controls.Add(this.chkListasDePrecios2);
            this.groupBoxListasDePrecios2.Location = new System.Drawing.Point(627, 25);
            this.groupBoxListasDePrecios2.Name = "groupBoxListasDePrecios2";
            this.groupBoxListasDePrecios2.Size = new System.Drawing.Size(261, 183);
            this.groupBoxListasDePrecios2.TabIndex = 1821;
            this.groupBoxListasDePrecios2.TabStop = false;
            this.groupBoxListasDePrecios2.Text = "Listas De Precios Desde Excel";
            // 
            // chkPrecioDeVentaTieneImpuestos
            // 
            this.chkPrecioDeVentaTieneImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.chkPrecioDeVentaTieneImpuestos.Location = new System.Drawing.Point(18, 144);
            this.chkPrecioDeVentaTieneImpuestos.Name = "chkPrecioDeVentaTieneImpuestos";
            this.chkPrecioDeVentaTieneImpuestos.Size = new System.Drawing.Size(215, 40);
            this.chkPrecioDeVentaTieneImpuestos.TabIndex = 1823;
            this.chkPrecioDeVentaTieneImpuestos.Text = "Pcio. de Venta contiene Impuestos";
            this.chkPrecioDeVentaTieneImpuestos.UseVisualStyleBackColor = false;
            // 
            // btnTodos2
            // 
            this.btnTodos2.Location = new System.Drawing.Point(18, 112);
            this.btnTodos2.Name = "btnTodos2";
            this.btnTodos2.Size = new System.Drawing.Size(16, 24);
            this.btnTodos2.TabIndex = 130;
            this.btnTodos2.Text = "T";
            // 
            // btnInvertir2
            // 
            this.btnInvertir2.Location = new System.Drawing.Point(50, 112);
            this.btnInvertir2.Name = "btnInvertir2";
            this.btnInvertir2.Size = new System.Drawing.Size(16, 24);
            this.btnInvertir2.TabIndex = 131;
            this.btnInvertir2.Text = "I";
            // 
            // btnNinguno2
            // 
            this.btnNinguno2.Location = new System.Drawing.Point(34, 112);
            this.btnNinguno2.Name = "btnNinguno2";
            this.btnNinguno2.Size = new System.Drawing.Size(16, 24);
            this.btnNinguno2.TabIndex = 132;
            this.btnNinguno2.Text = "N";
            // 
            // btnVerSeleccionados2
            // 
            this.btnVerSeleccionados2.Location = new System.Drawing.Point(66, 112);
            this.btnVerSeleccionados2.Name = "btnVerSeleccionados2";
            this.btnVerSeleccionados2.Size = new System.Drawing.Size(112, 24);
            this.btnVerSeleccionados2.TabIndex = 133;
            this.btnVerSeleccionados2.Text = "Ver Seleccionadas";
            // 
            // btnVerTodas2
            // 
            this.btnVerTodas2.Location = new System.Drawing.Point(178, 112);
            this.btnVerTodas2.Name = "btnVerTodas2";
            this.btnVerTodas2.Size = new System.Drawing.Size(72, 24);
            this.btnVerTodas2.TabIndex = 134;
            this.btnVerTodas2.Text = "Ver Todas";
            // 
            // chkModificaPrecioDeVenta
            // 
            this.chkModificaPrecioDeVenta.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaPrecioDeVenta.Location = new System.Drawing.Point(630, 3);
            this.chkModificaPrecioDeVenta.Name = "chkModificaPrecioDeVenta";
            this.chkModificaPrecioDeVenta.Size = new System.Drawing.Size(255, 24);
            this.chkModificaPrecioDeVenta.TabIndex = 1820;
            this.chkModificaPrecioDeVenta.Text = "Modifica Precio de Venta desde Excel";
            this.chkModificaPrecioDeVenta.UseVisualStyleBackColor = false;
            // 
            // groupListasDePrecios
            // 
            this.groupListasDePrecios.Controls.Add(this.btnTodos);
            this.groupListasDePrecios.Controls.Add(this.btnInvertir);
            this.groupListasDePrecios.Controls.Add(this.btnNinguno);
            this.groupListasDePrecios.Controls.Add(this.chkListasDePrecios);
            this.groupListasDePrecios.Controls.Add(this.btnVerSeleccionados);
            this.groupListasDePrecios.Controls.Add(this.btnVerTodas);
            this.groupListasDePrecios.Location = new System.Drawing.Point(372, 94);
            this.groupListasDePrecios.Name = "groupListasDePrecios";
            this.groupListasDePrecios.Size = new System.Drawing.Size(248, 144);
            this.groupListasDePrecios.TabIndex = 1819;
            this.groupListasDePrecios.TabStop = false;
            this.groupListasDePrecios.Text = "Listas de Precios";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(16, 112);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(16, 24);
            this.btnTodos.TabIndex = 125;
            this.btnTodos.Text = "T";
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(48, 112);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(16, 24);
            this.btnInvertir.TabIndex = 126;
            this.btnInvertir.Text = "I";
            // 
            // btnNinguno
            // 
            this.btnNinguno.Location = new System.Drawing.Point(32, 112);
            this.btnNinguno.Name = "btnNinguno";
            this.btnNinguno.Size = new System.Drawing.Size(16, 24);
            this.btnNinguno.TabIndex = 127;
            this.btnNinguno.Text = "N";
            // 
            // btnVerSeleccionados
            // 
            this.btnVerSeleccionados.Location = new System.Drawing.Point(64, 112);
            this.btnVerSeleccionados.Name = "btnVerSeleccionados";
            this.btnVerSeleccionados.Size = new System.Drawing.Size(112, 24);
            this.btnVerSeleccionados.TabIndex = 128;
            this.btnVerSeleccionados.Text = "Ver Seleccionadas";
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.Location = new System.Drawing.Point(176, 112);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(72, 24);
            this.btnVerTodas.TabIndex = 129;
            this.btnVerTodas.Text = "Ver Todas";
            // 
            // chkModificaInactivos
            // 
            this.chkModificaInactivos.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaInactivos.Location = new System.Drawing.Point(373, 70);
            this.chkModificaInactivos.Name = "chkModificaInactivos";
            this.chkModificaInactivos.Size = new System.Drawing.Size(192, 24);
            this.chkModificaInactivos.TabIndex = 11;
            this.chkModificaInactivos.Text = "Modifica Productos No Activos";
            this.chkModificaInactivos.UseVisualStyleBackColor = false;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(317, 239);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(217, 20);
            this.txtFileName.TabIndex = 13;
            // 
            // btnFileChooser
            // 
            this.btnFileChooser.Location = new System.Drawing.Point(285, 239);
            this.btnFileChooser.Name = "btnFileChooser";
            this.btnFileChooser.Size = new System.Drawing.Size(32, 23);
            this.btnFileChooser.TabIndex = 12;
            this.btnFileChooser.Text = "...";
            // 
            // chckModificaPrecioDeCosto
            // 
            this.chckModificaPrecioDeCosto.BackColor = System.Drawing.Color.Transparent;
            this.chckModificaPrecioDeCosto.Location = new System.Drawing.Point(373, 52);
            this.chckModificaPrecioDeCosto.Name = "chckModificaPrecioDeCosto";
            this.chckModificaPrecioDeCosto.Size = new System.Drawing.Size(160, 24);
            this.chckModificaPrecioDeCosto.TabIndex = 10;
            this.chckModificaPrecioDeCosto.Text = "Modifica Precio de Costo";
            this.chckModificaPrecioDeCosto.UseVisualStyleBackColor = false;
            // 
            // chckModificaBonificaciones
            // 
            this.chckModificaBonificaciones.BackColor = System.Drawing.Color.Transparent;
            this.chckModificaBonificaciones.Location = new System.Drawing.Point(373, 32);
            this.chckModificaBonificaciones.Name = "chckModificaBonificaciones";
            this.chckModificaBonificaciones.Size = new System.Drawing.Size(160, 24);
            this.chckModificaBonificaciones.TabIndex = 9;
            this.chckModificaBonificaciones.Text = "Modifica Bonificaciones";
            this.chckModificaBonificaciones.UseVisualStyleBackColor = false;
            // 
            // groupBoxInsercion
            // 
            this.groupBoxInsercion.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInsercion.Controls.Add(this.chckAgregaProductosNuevos);
            this.groupBoxInsercion.Controls.Add(this.groupBoxProductosNuevos);
            this.groupBoxInsercion.Controls.Add(this.chckAgregaLPProvNuevas);
            this.groupBoxInsercion.Location = new System.Drawing.Point(157, 32);
            this.groupBoxInsercion.Name = "groupBoxInsercion";
            this.groupBoxInsercion.Size = new System.Drawing.Size(208, 176);
            this.groupBoxInsercion.TabIndex = 1818;
            this.groupBoxInsercion.TabStop = false;
            this.groupBoxInsercion.Text = "Inserción";
            // 
            // chckAgregaProductosNuevos
            // 
            this.chckAgregaProductosNuevos.BackColor = System.Drawing.Color.Transparent;
            this.chckAgregaProductosNuevos.Location = new System.Drawing.Point(16, 16);
            this.chckAgregaProductosNuevos.Name = "chckAgregaProductosNuevos";
            this.chckAgregaProductosNuevos.Size = new System.Drawing.Size(160, 16);
            this.chckAgregaProductosNuevos.TabIndex = 4;
            this.chckAgregaProductosNuevos.Text = "Agrega Productos Nuevos ";
            this.chckAgregaProductosNuevos.UseVisualStyleBackColor = false;
            // 
            // groupBoxProductosNuevos
            // 
            this.groupBoxProductosNuevos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProductosNuevos.Controls.Add(this.chckPercibeIB);
            this.groupBoxProductosNuevos.Controls.Add(this.groupBoxImpuestos);
            this.groupBoxProductosNuevos.Location = new System.Drawing.Point(8, 16);
            this.groupBoxProductosNuevos.Name = "groupBoxProductosNuevos";
            this.groupBoxProductosNuevos.Size = new System.Drawing.Size(184, 128);
            this.groupBoxProductosNuevos.TabIndex = 1818;
            this.groupBoxProductosNuevos.TabStop = false;
            // 
            // chckPercibeIB
            // 
            this.chckPercibeIB.BackColor = System.Drawing.Color.Transparent;
            this.chckPercibeIB.Location = new System.Drawing.Point(8, 104);
            this.chckPercibeIB.Name = "chckPercibeIB";
            this.chckPercibeIB.Size = new System.Drawing.Size(160, 24);
            this.chckPercibeIB.TabIndex = 8;
            this.chckPercibeIB.Text = "Percibe Ing. Brutos";
            this.chckPercibeIB.UseVisualStyleBackColor = false;
            // 
            // groupBoxImpuestos
            // 
            this.groupBoxImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxImpuestos.Controls.Add(this.rbEx);
            this.groupBoxImpuestos.Controls.Add(this.rbIVADif);
            this.groupBoxImpuestos.Controls.Add(this.rbIVA);
            this.groupBoxImpuestos.Location = new System.Drawing.Point(8, 24);
            this.groupBoxImpuestos.Name = "groupBoxImpuestos";
            this.groupBoxImpuestos.Size = new System.Drawing.Size(160, 80);
            this.groupBoxImpuestos.TabIndex = 1819;
            this.groupBoxImpuestos.TabStop = false;
            this.groupBoxImpuestos.Text = "Impuestos Asociados";
            // 
            // rbEx
            // 
            this.rbEx.Location = new System.Drawing.Point(16, 60);
            this.rbEx.Name = "rbEx";
            this.rbEx.Size = new System.Drawing.Size(128, 24);
            this.rbEx.TabIndex = 7;
            this.rbEx.Text = "Exento";
            // 
            // rbIVADif
            // 
            this.rbIVADif.Location = new System.Drawing.Point(16, 36);
            this.rbIVADif.Name = "rbIVADif";
            this.rbIVADif.Size = new System.Drawing.Size(128, 24);
            this.rbIVADif.TabIndex = 6;
            this.rbIVADif.Text = "IVA 10.5%";
            // 
            // rbIVA
            // 
            this.rbIVA.Location = new System.Drawing.Point(16, 12);
            this.rbIVA.Name = "rbIVA";
            this.rbIVA.Size = new System.Drawing.Size(128, 24);
            this.rbIVA.TabIndex = 5;
            this.rbIVA.Text = "IVA 21%";
            // 
            // chckAgregaLPProvNuevas
            // 
            this.chckAgregaLPProvNuevas.BackColor = System.Drawing.Color.Transparent;
            this.chckAgregaLPProvNuevas.Location = new System.Drawing.Point(8, 144);
            this.chckAgregaLPProvNuevas.Name = "chckAgregaLPProvNuevas";
            this.chckAgregaLPProvNuevas.Size = new System.Drawing.Size(192, 32);
            this.chckAgregaLPProvNuevas.TabIndex = 1819;
            this.chckAgregaLPProvNuevas.Text = "Agrega Listas De Precios Nuevas";
            this.chckAgregaLPProvNuevas.UseVisualStyleBackColor = false;
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(541, 239);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(80, 24);
            this.btnVerDatos.TabIndex = 1817;
            this.btnVerDatos.Text = "Ver Datos";
            // 
            // groupBoxCampoDeBusqueda
            // 
            this.groupBoxCampoDeBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCampoDeBusqueda.Controls.Add(this.rbPorCodigoProveedor);
            this.groupBoxCampoDeBusqueda.Controls.Add(this.rbPorCodigoSecundario);
            this.groupBoxCampoDeBusqueda.Controls.Add(this.rbPorCodigo);
            this.groupBoxCampoDeBusqueda.Location = new System.Drawing.Point(8, 32);
            this.groupBoxCampoDeBusqueda.Name = "groupBoxCampoDeBusqueda";
            this.groupBoxCampoDeBusqueda.Size = new System.Drawing.Size(145, 88);
            this.groupBoxCampoDeBusqueda.TabIndex = 133;
            this.groupBoxCampoDeBusqueda.TabStop = false;
            this.groupBoxCampoDeBusqueda.Text = "Campo de Búsqueda";
            // 
            // rbPorCodigoProveedor
            // 
            this.rbPorCodigoProveedor.Location = new System.Drawing.Point(8, 61);
            this.rbPorCodigoProveedor.Name = "rbPorCodigoProveedor";
            this.rbPorCodigoProveedor.Size = new System.Drawing.Size(128, 24);
            this.rbPorCodigoProveedor.TabIndex = 3;
            this.rbPorCodigoProveedor.Text = "Código Proveedor";
            // 
            // rbPorCodigoSecundario
            // 
            this.rbPorCodigoSecundario.Location = new System.Drawing.Point(8, 37);
            this.rbPorCodigoSecundario.Name = "rbPorCodigoSecundario";
            this.rbPorCodigoSecundario.Size = new System.Drawing.Size(128, 24);
            this.rbPorCodigoSecundario.TabIndex = 2;
            this.rbPorCodigoSecundario.Text = "Código Secundario";
            // 
            // rbPorCodigo
            // 
            this.rbPorCodigo.Location = new System.Drawing.Point(8, 13);
            this.rbPorCodigo.Name = "rbPorCodigo";
            this.rbPorCodigo.Size = new System.Drawing.Size(128, 24);
            this.rbPorCodigo.TabIndex = 1;
            this.rbPorCodigo.Text = "Código";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(8, 8);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
            this.ultraLabel1.TabIndex = 13;
            this.ultraLabel1.Text = "Proveedor";
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.chkModificaDescripcion);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.chkModificaCodigoProveedor);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.chkModificaCodigoSecundario);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.chkModificaCamposAuxiliares);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.chkModificaInactivosVenta);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.groupBoxInsercionVenta);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.chckPcioDeVtaContieneImpuestos);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.groupBoxCampoDeBusquedaVenta);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.txtFileNameVenta);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.btnFileChooserVenta);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.btnVerDatosVenta);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.groupBox1);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 427);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(1348, 170);
            this.ultraExplorerBarContainerControl4.TabIndex = 4;
            // 
            // chkModificaDescripcion
            // 
            this.chkModificaDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaDescripcion.Location = new System.Drawing.Point(384, 80);
            this.chkModificaDescripcion.Name = "chkModificaDescripcion";
            this.chkModificaDescripcion.Size = new System.Drawing.Size(160, 24);
            this.chkModificaDescripcion.TabIndex = 1836;
            this.chkModificaDescripcion.Text = "Modifica Descripción";
            this.chkModificaDescripcion.UseVisualStyleBackColor = false;
            // 
            // chkModificaCodigoProveedor
            // 
            this.chkModificaCodigoProveedor.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaCodigoProveedor.Location = new System.Drawing.Point(384, 32);
            this.chkModificaCodigoProveedor.Name = "chkModificaCodigoProveedor";
            this.chkModificaCodigoProveedor.Size = new System.Drawing.Size(168, 24);
            this.chkModificaCodigoProveedor.TabIndex = 1828;
            this.chkModificaCodigoProveedor.Text = "Modifica Código Proveedor";
            this.chkModificaCodigoProveedor.UseVisualStyleBackColor = false;
            // 
            // chkModificaCodigoSecundario
            // 
            this.chkModificaCodigoSecundario.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaCodigoSecundario.Location = new System.Drawing.Point(384, 8);
            this.chkModificaCodigoSecundario.Name = "chkModificaCodigoSecundario";
            this.chkModificaCodigoSecundario.Size = new System.Drawing.Size(168, 24);
            this.chkModificaCodigoSecundario.TabIndex = 1827;
            this.chkModificaCodigoSecundario.Text = "Modifica Código Secundario";
            this.chkModificaCodigoSecundario.UseVisualStyleBackColor = false;
            // 
            // chkModificaCamposAuxiliares
            // 
            this.chkModificaCamposAuxiliares.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaCamposAuxiliares.Location = new System.Drawing.Point(384, 56);
            this.chkModificaCamposAuxiliares.Name = "chkModificaCamposAuxiliares";
            this.chkModificaCamposAuxiliares.Size = new System.Drawing.Size(168, 24);
            this.chkModificaCamposAuxiliares.TabIndex = 1826;
            this.chkModificaCamposAuxiliares.Text = "Modifica Campos Auxiliares";
            this.chkModificaCamposAuxiliares.UseVisualStyleBackColor = false;
            // 
            // chkModificaInactivosVenta
            // 
            this.chkModificaInactivosVenta.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaInactivosVenta.Location = new System.Drawing.Point(176, 104);
            this.chkModificaInactivosVenta.Name = "chkModificaInactivosVenta";
            this.chkModificaInactivosVenta.Size = new System.Drawing.Size(192, 24);
            this.chkModificaInactivosVenta.TabIndex = 1824;
            this.chkModificaInactivosVenta.Text = "Modifica Productos No Activos";
            this.chkModificaInactivosVenta.UseVisualStyleBackColor = false;
            // 
            // groupBoxInsercionVenta
            // 
            this.groupBoxInsercionVenta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInsercionVenta.Controls.Add(this.chckAgregaProductosNuevosVenta);
            this.groupBoxInsercionVenta.Controls.Add(this.groupBoxProductosNuevosVenta);
            this.groupBoxInsercionVenta.Location = new System.Drawing.Point(176, 8);
            this.groupBoxInsercionVenta.Name = "groupBoxInsercionVenta";
            this.groupBoxInsercionVenta.Size = new System.Drawing.Size(193, 88);
            this.groupBoxInsercionVenta.TabIndex = 1823;
            this.groupBoxInsercionVenta.TabStop = false;
            this.groupBoxInsercionVenta.Text = "Inserción";
            // 
            // chckAgregaProductosNuevosVenta
            // 
            this.chckAgregaProductosNuevosVenta.BackColor = System.Drawing.Color.Transparent;
            this.chckAgregaProductosNuevosVenta.Location = new System.Drawing.Point(16, 16);
            this.chckAgregaProductosNuevosVenta.Name = "chckAgregaProductosNuevosVenta";
            this.chckAgregaProductosNuevosVenta.Size = new System.Drawing.Size(160, 24);
            this.chckAgregaProductosNuevosVenta.TabIndex = 4;
            this.chckAgregaProductosNuevosVenta.Text = "Agrega Productos Nuevos";
            this.chckAgregaProductosNuevosVenta.UseVisualStyleBackColor = false;
            // 
            // groupBoxProductosNuevosVenta
            // 
            this.groupBoxProductosNuevosVenta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProductosNuevosVenta.Controls.Add(this.chckPercibeIBVenta);
            this.groupBoxProductosNuevosVenta.Location = new System.Drawing.Point(8, 24);
            this.groupBoxProductosNuevosVenta.Name = "groupBoxProductosNuevosVenta";
            this.groupBoxProductosNuevosVenta.Size = new System.Drawing.Size(176, 56);
            this.groupBoxProductosNuevosVenta.TabIndex = 1818;
            this.groupBoxProductosNuevosVenta.TabStop = false;
            // 
            // chckPercibeIBVenta
            // 
            this.chckPercibeIBVenta.BackColor = System.Drawing.Color.Transparent;
            this.chckPercibeIBVenta.Location = new System.Drawing.Point(8, 24);
            this.chckPercibeIBVenta.Name = "chckPercibeIBVenta";
            this.chckPercibeIBVenta.Size = new System.Drawing.Size(160, 24);
            this.chckPercibeIBVenta.TabIndex = 8;
            this.chckPercibeIBVenta.Text = "Percibe Ing. Brutos";
            this.chckPercibeIBVenta.UseVisualStyleBackColor = false;
            // 
            // chckPcioDeVtaContieneImpuestos
            // 
            this.chckPcioDeVtaContieneImpuestos.BackColor = System.Drawing.Color.Transparent;
            this.chckPcioDeVtaContieneImpuestos.Location = new System.Drawing.Point(16, 88);
            this.chckPcioDeVtaContieneImpuestos.Name = "chckPcioDeVtaContieneImpuestos";
            this.chckPcioDeVtaContieneImpuestos.Size = new System.Drawing.Size(144, 40);
            this.chckPcioDeVtaContieneImpuestos.TabIndex = 1822;
            this.chckPcioDeVtaContieneImpuestos.Text = "Pcio. de Venta contiene Impuestos";
            this.chckPcioDeVtaContieneImpuestos.UseVisualStyleBackColor = false;
            // 
            // groupBoxCampoDeBusquedaVenta
            // 
            this.groupBoxCampoDeBusquedaVenta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCampoDeBusquedaVenta.Controls.Add(this.rbPorCodigoSecundarioVenta);
            this.groupBoxCampoDeBusquedaVenta.Controls.Add(this.rbPorCodigoVenta);
            this.groupBoxCampoDeBusquedaVenta.Location = new System.Drawing.Point(16, 8);
            this.groupBoxCampoDeBusquedaVenta.Name = "groupBoxCampoDeBusquedaVenta";
            this.groupBoxCampoDeBusquedaVenta.Size = new System.Drawing.Size(145, 64);
            this.groupBoxCampoDeBusquedaVenta.TabIndex = 1821;
            this.groupBoxCampoDeBusquedaVenta.TabStop = false;
            this.groupBoxCampoDeBusquedaVenta.Text = "Campo de Búsqueda";
            // 
            // rbPorCodigoSecundarioVenta
            // 
            this.rbPorCodigoSecundarioVenta.Location = new System.Drawing.Point(8, 37);
            this.rbPorCodigoSecundarioVenta.Name = "rbPorCodigoSecundarioVenta";
            this.rbPorCodigoSecundarioVenta.Size = new System.Drawing.Size(128, 24);
            this.rbPorCodigoSecundarioVenta.TabIndex = 2;
            this.rbPorCodigoSecundarioVenta.Text = "Código Secundario";
            // 
            // rbPorCodigoVenta
            // 
            this.rbPorCodigoVenta.Location = new System.Drawing.Point(8, 13);
            this.rbPorCodigoVenta.Name = "rbPorCodigoVenta";
            this.rbPorCodigoVenta.Size = new System.Drawing.Size(128, 24);
            this.rbPorCodigoVenta.TabIndex = 1;
            this.rbPorCodigoVenta.Text = "Código";
            // 
            // txtFileNameVenta
            // 
            this.txtFileNameVenta.Location = new System.Drawing.Point(520, 144);
            this.txtFileNameVenta.Name = "txtFileNameVenta";
            this.txtFileNameVenta.Size = new System.Drawing.Size(217, 20);
            this.txtFileNameVenta.TabIndex = 1819;
            // 
            // btnFileChooserVenta
            // 
            this.btnFileChooserVenta.Location = new System.Drawing.Point(488, 144);
            this.btnFileChooserVenta.Name = "btnFileChooserVenta";
            this.btnFileChooserVenta.Size = new System.Drawing.Size(32, 23);
            this.btnFileChooserVenta.TabIndex = 1818;
            this.btnFileChooserVenta.Text = "...";
            // 
            // btnVerDatosVenta
            // 
            this.btnVerDatosVenta.Location = new System.Drawing.Point(744, 144);
            this.btnVerDatosVenta.Name = "btnVerDatosVenta";
            this.btnVerDatosVenta.Size = new System.Drawing.Size(80, 24);
            this.btnVerDatosVenta.TabIndex = 1820;
            this.btnVerDatosVenta.Text = "Ver Datos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkModificaJerarquia6);
            this.groupBox1.Controls.Add(this.chkModificaJerarquia7);
            this.groupBox1.Controls.Add(this.chkModificaJerarquia8);
            this.groupBox1.Controls.Add(this.chkModificaJerarquia5);
            this.groupBox1.Controls.Add(this.chkModificaJerarquia3);
            this.groupBox1.Controls.Add(this.chkModificaJerarquia4);
            this.groupBox1.Controls.Add(this.chkModificaJerarquia1);
            this.groupBox1.Controls.Add(this.chkModificaJerarquia2);
            this.groupBox1.Location = new System.Drawing.Point(560, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 120);
            this.groupBox1.TabIndex = 1837;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jerarquias";
            // 
            // chkModificaJerarquia6
            // 
            this.chkModificaJerarquia6.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia6.Location = new System.Drawing.Point(144, 40);
            this.chkModificaJerarquia6.Name = "chkModificaJerarquia6";
            this.chkModificaJerarquia6.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia6.TabIndex = 1841;
            this.chkModificaJerarquia6.Text = "Modifica Jerarquía 6";
            this.chkModificaJerarquia6.UseVisualStyleBackColor = false;
            // 
            // chkModificaJerarquia7
            // 
            this.chkModificaJerarquia7.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia7.Location = new System.Drawing.Point(144, 64);
            this.chkModificaJerarquia7.Name = "chkModificaJerarquia7";
            this.chkModificaJerarquia7.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia7.TabIndex = 1840;
            this.chkModificaJerarquia7.Text = "Modifica Jerarquía 7";
            this.chkModificaJerarquia7.UseVisualStyleBackColor = false;
            // 
            // chkModificaJerarquia8
            // 
            this.chkModificaJerarquia8.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia8.Location = new System.Drawing.Point(144, 88);
            this.chkModificaJerarquia8.Name = "chkModificaJerarquia8";
            this.chkModificaJerarquia8.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia8.TabIndex = 1839;
            this.chkModificaJerarquia8.Text = "Modifica Jerarquía 8";
            this.chkModificaJerarquia8.UseVisualStyleBackColor = false;
            // 
            // chkModificaJerarquia5
            // 
            this.chkModificaJerarquia5.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia5.Location = new System.Drawing.Point(144, 16);
            this.chkModificaJerarquia5.Name = "chkModificaJerarquia5";
            this.chkModificaJerarquia5.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia5.TabIndex = 1838;
            this.chkModificaJerarquia5.Text = "Modifica Jerarquía 5";
            this.chkModificaJerarquia5.UseVisualStyleBackColor = false;
            // 
            // chkModificaJerarquia3
            // 
            this.chkModificaJerarquia3.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia3.Location = new System.Drawing.Point(8, 64);
            this.chkModificaJerarquia3.Name = "chkModificaJerarquia3";
            this.chkModificaJerarquia3.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia3.TabIndex = 1837;
            this.chkModificaJerarquia3.Text = "Modifica Jerarquía 3";
            this.chkModificaJerarquia3.UseVisualStyleBackColor = false;
            // 
            // chkModificaJerarquia4
            // 
            this.chkModificaJerarquia4.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia4.Location = new System.Drawing.Point(8, 88);
            this.chkModificaJerarquia4.Name = "chkModificaJerarquia4";
            this.chkModificaJerarquia4.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia4.TabIndex = 1836;
            this.chkModificaJerarquia4.Text = "Modifica Jerarquía 4";
            this.chkModificaJerarquia4.UseVisualStyleBackColor = false;
            // 
            // chkModificaJerarquia1
            // 
            this.chkModificaJerarquia1.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia1.Location = new System.Drawing.Point(8, 16);
            this.chkModificaJerarquia1.Name = "chkModificaJerarquia1";
            this.chkModificaJerarquia1.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia1.TabIndex = 1825;
            this.chkModificaJerarquia1.Text = "Modifica Jerarquía 1";
            this.chkModificaJerarquia1.UseVisualStyleBackColor = false;
            // 
            // chkModificaJerarquia2
            // 
            this.chkModificaJerarquia2.BackColor = System.Drawing.Color.Transparent;
            this.chkModificaJerarquia2.Location = new System.Drawing.Point(8, 40);
            this.chkModificaJerarquia2.Name = "chkModificaJerarquia2";
            this.chkModificaJerarquia2.Size = new System.Drawing.Size(128, 24);
            this.chkModificaJerarquia2.TabIndex = 1829;
            this.chkModificaJerarquia2.Text = "Modifica Jerarquía 2";
            this.chkModificaJerarquia2.UseVisualStyleBackColor = false;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.hierarchicalSearchControl1);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 654);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(1348, 100);
            this.ultraExplorerBarContainerControl3.TabIndex = 3;
            // 
            // containerItems
            // 
            this.containerItems.Controls.Add(this.groupBox3);
            this.containerItems.Controls.Add(this.groupBox2);
            this.containerItems.Location = new System.Drawing.Point(-10000, -10000);
            this.containerItems.Name = "containerItems";
            this.containerItems.Size = new System.Drawing.Size(1348, 269);
            this.containerItems.TabIndex = 1;
            this.containerItems.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridProductos);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1348, 232);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowCardSizing = false;
            this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductos.Location = new System.Drawing.Point(3, 16);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1342, 213);
            this.gridProductos.TabIndex = 4;
            this.gridProductos.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridManagerView1);
            this.groupBox2.Controls.Add(this.bDetallesProducto);
            this.groupBox2.Controls.Add(this.bAgregarProducto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 37);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // bDetallesProducto
            // 
            this.bDetallesProducto.Enabled = false;
            this.bDetallesProducto.Location = new System.Drawing.Point(95, 8);
            this.bDetallesProducto.Name = "bDetallesProducto";
            this.bDetallesProducto.Size = new System.Drawing.Size(88, 23);
            this.bDetallesProducto.TabIndex = 4;
            this.bDetallesProducto.Text = "&Detalles";
            // 
            // bAgregarProducto
            // 
            this.bAgregarProducto.Location = new System.Drawing.Point(4, 8);
            this.bAgregarProducto.Name = "bAgregarProducto";
            this.bAgregarProducto.Size = new System.Drawing.Size(88, 23);
            this.bAgregarProducto.TabIndex = 3;
            this.bAgregarProducto.Text = "&Agregar";
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
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(1414, 28);
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
            // ultraExplorerBar
            // 
            this.ultraExplorerBar.AnimationEnabled = false;
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar.Controls.Add(this.containerItems);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Key = "Tarea";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 27;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup2.Key = "DatosArchivoCostos";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 262;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Datos del Archivo";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup3.Key = "DatosArchivoVentas";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 170;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Datos del Archivo";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup4.Key = "Jerarquias";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 100;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Jerarquías";
            ultraExplorerBarGroup5.Container = this.containerItems;
            ultraExplorerBarGroup5.Key = "Detalle";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 269;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Detalle de Productos";
            this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5});
            this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar.Name = "ultraExplorerBar";
            this.ultraExplorerBar.Size = new System.Drawing.Size(1414, 760);
            this.ultraExplorerBar.TabIndex = 24;
            this.ultraExplorerBar.TabStop = false;
            // 
            // chkListasDePrecios2
            // 
            this.chkListasDePrecios2.Location = new System.Drawing.Point(17, 16);
            this.chkListasDePrecios2.Name = "chkListasDePrecios2";
            this.chkListasDePrecios2.Size = new System.Drawing.Size(216, 94);
            this.chkListasDePrecios2.TabIndex = 115;
            // 
            // chkListasDePrecios
            // 
            this.chkListasDePrecios.Location = new System.Drawing.Point(16, 16);
            this.chkListasDePrecios.Name = "chkListasDePrecios";
            this.chkListasDePrecios.Size = new System.Drawing.Size(216, 94);
            this.chkListasDePrecios.TabIndex = 114;
            // 
            // mzCmbProveedores
            // 
            this.mzCmbProveedores.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbProveedores.DataValue = "";
            this.mzCmbProveedores.EnableCtaCte = false;
            this.mzCmbProveedores.FastSearch = false;
            this.mzCmbProveedores.Location = new System.Drawing.Point(80, 0);
            this.mzCmbProveedores.Name = "mzCmbProveedores";
            this.mzCmbProveedores.SearchObjectListener = null;
            this.mzCmbProveedores.Size = new System.Drawing.Size(408, 22);
            this.mzCmbProveedores.TabIndex = 0;
            this.mzCmbProveedores.Tag = "ResponsableEmision";
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(195, 8);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(384, 24);
            this.gridManagerView1.TabIndex = 5;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(32, 8);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(784, 95);
            this.hierarchicalSearchControl1.TabIndex = 1;
            // 
            // FrmModificarPreciosMasivoDesdeExcel
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1414, 788);
            this.Controls.Add(this.ultraExplorerBar);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmModificarPreciosMasivoDesdeExcel";
            this.Text = "FrmModificarPreciosMasivoDesdeExcel";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            this.groupBoxListasDePrecios2.ResumeLayout(false);
            this.groupListasDePrecios.ResumeLayout(false);
            this.groupBoxInsercion.ResumeLayout(false);
            this.groupBoxProductosNuevos.ResumeLayout(false);
            this.groupBoxImpuestos.ResumeLayout(false);
            this.groupBoxCampoDeBusqueda.ResumeLayout(false);
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ultraExplorerBarContainerControl4.PerformLayout();
            this.groupBoxInsercionVenta.ResumeLayout(false);
            this.groupBoxProductosNuevosVenta.ResumeLayout(false);
            this.groupBoxCampoDeBusquedaVenta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.containerItems.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
            this.ultraExplorerBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Constructores y Destructores

		public FrmModificarPreciosMasivoDesdeExcel(ModificarPreciosMasivoDesdeExcelController controller)
		{
			InitializeComponent();
			_uiController = controller;			
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

		#endregion

		#region Variables Privadas		
		private ModificarPreciosMasivoDesdeExcelController _uiController = null;		
		private bool _processItem = true;
		#endregion

		#region Inicializadores y Carga
		

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}

		
		private void ConfigureInterface()
		{
			this.Text = _uiController.LeyendaFormulario;

			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			this.mzCmbProveedores.Enabled = true;
			mzCmbProveedores.Init();
			mzCmbProveedores.SearchObjectListener = this;
			mzCmbProveedores.EnableCtaCte = false;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridProductos, this.Text);			

			btnVerDatos.Enabled = false;
			txtFileName.Enabled = false;
			KeyPreview = true;

			hierarchicalSearchControl1.Build_UI("PRODUCTOS",false);
			hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);

			foreach  (Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup grupo in  this.ultraExplorerBar.Groups)
				grupo.Visible = false;

			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar.Groups.Exists(grupo))
						this.ultraExplorerBar.Groups[grupo].Visible = true;
				}
			}

			txtFileNameVenta.Enabled = false;

			chkModificaJerarquia1.Enabled = _uiController.HabilitaJerarquia1;
			chkModificaJerarquia2.Enabled = _uiController.HabilitaJerarquia2;
			chkModificaJerarquia3.Enabled = _uiController.HabilitaJerarquia3;
			chkModificaJerarquia4.Enabled = _uiController.HabilitaJerarquia4;
			chkModificaJerarquia5.Enabled = _uiController.HabilitaJerarquia5;
			chkModificaJerarquia6.Enabled = _uiController.HabilitaJerarquia6;
			chkModificaJerarquia7.Enabled = _uiController.HabilitaJerarquia7;
			chkModificaJerarquia8.Enabled = _uiController.HabilitaJerarquia8;

			gridProductos.RecordNavigator = true;

			groupListasDePrecios.Visible = _uiController.HabilitaListasDePrecios;

            //German 20120202 - Tarea 0000273
            chkModificaPrecioDeVenta.Enabled = _uiController.ActualizaListasDePreciosDeVentaDesdeExcel;
            groupBoxListasDePrecios2.Enabled = false;
            //Fin German 20120202 - Tarea 0000273
		}



		private void InitializeData()
		{						
			chkListasDePrecios.Items.AddRange(_uiController.ListasDePrecios.ToArray());
            //German 20120202 - Tarea 0000273
            chkListasDePrecios2.Items.AddRange(_uiController.ListasDePrecios.ToArray());
            //German 20120202 - Tarea 0000273
		}

		private void InitEventHandlers()
		{			
			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			btnVerDatos.Click +=new EventHandler(btnVerDatos_Click);
			chckAgregaProductosNuevos.CheckedChanged +=new EventHandler(chckAgregaProductosNuevos_CheckedChanged);
			mzCmbProveedores.ValueChanged+=new EventHandler(mzCmbProveedores_ValueChanged);
			btnFileChooser.Click +=new EventHandler(btnFileChooser_Click);
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
			chckAgregaLPProvNuevas.CheckedChanged+=new EventHandler(chckAgregaLPProvNuevas_CheckedChanged);

			btnVerDatosVenta.Click +=new EventHandler(btnVerDatos_Click);
			chckAgregaProductosNuevosVenta.CheckedChanged +=new EventHandler(chckAgregaProductosNuevos_CheckedChanged);
			btnFileChooserVenta.Click +=new EventHandler(btnFileChooser_Click);
			btnTodos.Click+=new EventHandler(btnTodos_Click);
			btnNinguno.Click += new System.EventHandler(this.btnNinguno_Click);
			btnInvertir.Click+=new EventHandler(btnInvertir_Click);
			btnVerSeleccionados.Click+=new EventHandler(btnVerSeleccionados_Click);
			btnVerTodas.Click+=new EventHandler(btnVerTodas_Click);
            //German 20120202 - Tarea 0000273
            chkModificaPrecioDeVenta.CheckedChanged += new EventHandler(chkModificaPrecioDeVenta_CheckedChanged);
            btnTodos2.Click += new EventHandler(btnTodos2_Click);
            btnNinguno2.Click += new System.EventHandler(this.btnNinguno2_Click);
            btnInvertir2.Click += new EventHandler(btnInvertir2_Click);
            btnVerSeleccionados2.Click += new EventHandler(btnVerSeleccionados2_Click);
            btnVerTodas2.Click += new EventHandler(btnVerTodas2_Click);
            //German 20120202 - Tarea 0000273
		}

        //German 20120202 - Tarea 0000273
        void chkModificaPrecioDeVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModificaPrecioDeVenta.Checked)
                groupBoxListasDePrecios2.Enabled = true;
            else
            {
                groupBoxListasDePrecios2.Enabled = false;
            }
        }

        //German 20120202 - Tarea 0000273

     

	
		private void InitDataBindings()
		{				
			mzCmbProveedores.DataBindings.Clear();
			rbPorCodigo.DataBindings.Clear();
			rbPorCodigoSecundario.DataBindings.Clear();
			rbPorCodigoProveedor.DataBindings.Clear();
			chckAgregaProductosNuevos.DataBindings.Clear();
			chckPercibeIB.DataBindings.Clear();
			rbIVA.DataBindings.Clear();
			rbIVADif.DataBindings.Clear();
			rbEx.DataBindings.Clear();
			chckModificaBonificaciones.DataBindings.Clear();
			chckModificaPrecioDeCosto.DataBindings.Clear();
			chkModificaInactivos.DataBindings.Clear();
			chckAgregaLPProvNuevas.DataBindings.Clear();

			rbPorCodigoVenta.DataBindings.Clear();
			rbPorCodigoSecundarioVenta.DataBindings.Clear();
			chckAgregaProductosNuevosVenta.DataBindings.Clear();
			chckPercibeIBVenta.DataBindings.Clear();
			chkModificaInactivosVenta.DataBindings.Clear();
            chckPcioDeVtaContieneImpuestos.DataBindings.Clear();
			chkModificaCodigoSecundario.DataBindings.Clear();
			chkModificaCodigoProveedor.DataBindings.Clear();
			chkModificaCamposAuxiliares.DataBindings.Clear();
			chkModificaDescripcion.DataBindings.Clear();
			chkModificaJerarquia1.DataBindings.Clear();
			chkModificaJerarquia2.DataBindings.Clear();
			chkModificaJerarquia3.DataBindings.Clear();
			chkModificaJerarquia4.DataBindings.Clear();
			chkModificaJerarquia5.DataBindings.Clear();
			chkModificaJerarquia6.DataBindings.Clear();
			chkModificaJerarquia7.DataBindings.Clear();
			chkModificaJerarquia8.DataBindings.Clear();

			mzCmbProveedores.DataBindings.Add("DataValue", _uiController, "CodigoProveedor");
			BindingController.Bind(rbPorCodigo,"Checked", _uiController, "PorCodigo");
			BindingController.Bind(rbPorCodigoSecundario,"Checked", _uiController, "PorCodigoSecundario");
			BindingController.Bind(rbPorCodigoProveedor,"Checked", _uiController, "PorCodigoProveedor");
			chckAgregaProductosNuevos.DataBindings.Add("Checked", _uiController, "AgregaProductosNuevos");
			groupBoxProductosNuevos.Enabled = chckAgregaProductosNuevos.Checked;
			chckPercibeIB.DataBindings.Add("Checked", _uiController, "PercibeIB");
			BindingController.Bind(rbIVA,"Checked", _uiController, "IVA");
			BindingController.Bind(rbIVADif,"Checked", _uiController, "IVADIF");
			BindingController.Bind(rbEx,"Checked", _uiController, "EX");
			chckModificaBonificaciones.DataBindings.Add("Checked", _uiController, "ModificaBonificaciones");
			chckModificaPrecioDeCosto.DataBindings.Add("Checked", _uiController, "ModificaPrecioDeCosto");
			chkModificaInactivos.DataBindings.Add("Checked", _uiController, "ModificaProductosInactivos");
			chckAgregaLPProvNuevas.DataBindings.Add("Checked", _uiController, "AgregaListaDePreciosNuevas");

			BindingController.Bind(rbPorCodigoVenta,"Checked", _uiController, "PorCodigo");
			BindingController.Bind(rbPorCodigoSecundarioVenta,"Checked", _uiController, "PorCodigoSecundario");
			chckAgregaProductosNuevosVenta.DataBindings.Add("Checked", _uiController, "AgregaProductosNuevos");
			groupBoxProductosNuevosVenta.Enabled = chckAgregaProductosNuevosVenta.Checked;
			chckPercibeIBVenta.DataBindings.Add("Checked", _uiController, "PercibeIB");
			chkModificaInactivosVenta.DataBindings.Add("Checked", _uiController, "ModificaProductosInactivos");
			chckPcioDeVtaContieneImpuestos.DataBindings.Add("Checked", _uiController, "PcioDeVtaContieneImpuestos");
			chkModificaCodigoSecundario.DataBindings.Add("Checked", _uiController, "ModificaCodigoSecundario");
			chkModificaCodigoProveedor.DataBindings.Add("Checked", _uiController, "ModificaCodigoProveedor");
			chkModificaCamposAuxiliares.DataBindings.Add("Checked", _uiController, "ModificaCamposAuxiliares");
			chkModificaDescripcion.DataBindings.Add("Checked", _uiController, "ModificaDescripcion");
			chkModificaJerarquia1.DataBindings.Add("Checked", _uiController, "ModificaJerarquia1");
			chkModificaJerarquia2.DataBindings.Add("Checked", _uiController, "ModificaJerarquia2");
			chkModificaJerarquia3.DataBindings.Add("Checked", _uiController, "ModificaJerarquia3");
			chkModificaJerarquia4.DataBindings.Add("Checked", _uiController, "ModificaJerarquia4");
			chkModificaJerarquia5.DataBindings.Add("Checked", _uiController, "ModificaJerarquia5");
			chkModificaJerarquia6.DataBindings.Add("Checked", _uiController, "ModificaJerarquia6");
			chkModificaJerarquia7.DataBindings.Add("Checked", _uiController, "ModificaJerarquia7");
			chkModificaJerarquia8.DataBindings.Add("Checked", _uiController, "ModificaJerarquia8");
            //German 20120202 - Tarea 0000273
            chkPrecioDeVentaTieneImpuestos.DataBindings.Add("Checked", _uiController, "PrecioDeVentaTieneImpuestos");
            //German 20120202 - Tarea 0000273
		}


		#endregion

		#region Métodos privados

		private void RefreshData()
		{
			Util.MoveFocus(this.ultraExplorerBarContainerControl2);
			this.Cursor = Cursors.WaitCursor;
			_uiController.RefreshData();
			this.Cursor = Cursors.Default;
		}

		private void RefreshData(object sender, EventArgs e)
		{			
			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Result, null);
			if (gridManagerView1.AllowGroupCollapse)
				this.gridProductos.CollapseGroups();
			else
				if (gridProductos.RootTable.Groups.Count > 0 )
				gridProductos.RootTable.Groups[0].Expand();
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.Result);
			//German 20091023 - Tarea 477
			if(_uiController.ProductosRepetidos.Count > 0)
			{
				string mensaje = string.Empty;
				foreach(string codigo in _uiController.ProductosRepetidos)
				{
					mensaje = mensaje + " " + codigo;
				}	
				string mensajeCompleto = "Los Productos " + mensaje + " estaban repetidos en el archivo origen, sólo se tuvieron en cuenta uno de cada uno de ellos";
				MessageBox.Show(mensajeCompleto, "Adevertencia por Códidgos Repetidos",System.Windows.Forms.MessageBoxButtons.OK);
				
			}
			//Fin German 20091023 - Tarea 477
		}

		private void SaveChanges()
		{
			this.Cursor = Cursors.WaitCursor;
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
	
			ArrayList selectedLP = new ArrayList();
			foreach(mz.erp.businessrules.ListaDePreciosView lp in chkListasDePrecios.CheckedItems)
				selectedLP.Add(lp);
			_uiController.ListasDePreciosSeleccionadas = selectedLP;

            //German 20120202 - Tarea 0000273

            ArrayList selectedLP2 = new ArrayList();
            foreach (mz.erp.businessrules.ListaDePreciosView lp in chkListasDePrecios2.CheckedItems)
                selectedLP2.Add(lp);
            _uiController.ListasDePreciosSeleccionadas2 = selectedLP2;
            //Fin German 20120202 - Tarea 0000273
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

			this.Cursor = Cursors.Default;
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
			this.SaveChanges();
		}

		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
		}

		#endregion

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2://Guardar		
					this.SaveChanges();
					break;
				case 4://Close					
					this.CloseForm();
					break;
			}						
		}

		private void btnVerDatos_Click(object sender, EventArgs e)
		{
			this.RefreshData();
		}

		/*
		 * Si el usuario decide agregar productos nuevos entonces necesariamente debera agregar la lista de
		 *  precios pues no se puede agregar productos sin ninguna lista de precios.
		 * */
		private void chckAgregaProductosNuevos_CheckedChanged(object sender, EventArgs e)
		{
			groupBoxProductosNuevos.Enabled = chckAgregaProductosNuevos.Checked;
			groupBoxProductosNuevosVenta.Enabled = chckAgregaProductosNuevosVenta.Checked;
			if(chckAgregaProductosNuevos.Checked)
			{
				_uiController.AgregaListaDePreciosNuevas = true;
				chckAgregaLPProvNuevas.Checked = true;
			}
		}

		private void mzCmbProveedores_ValueChanged(object sender, EventArgs e)
		{
			btnVerDatos.Enabled = !string.Empty.Equals(((string)mzCmbProveedores.DataValue));
		}

		private void btnFileChooser_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Excel files (*.xls)|*.xls"  ;
			openFileDialog1.RestoreDirectory = true ;
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtFileName.Text = openFileDialog1.FileName;
				txtFileNameVenta.Text = openFileDialog1.FileName;
				_uiController.ArchivoExcel = openFileDialog1.FileName;
			}

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
			

			/*if(_uiController.ByJerarquia1 && !hierarchicalSearchControl1.NodeDescripcion1.Equals(string.Empty) && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion1))
			{
				if(chkLista.Items.Contains(_desc1))
					chkLista.Items.Remove(_desc1);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion1, true);
				_desc1 = hierarchicalSearchControl1.NodeDescripcion1;
			}
			else if(!_uiController.ByJerarquia1 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion1))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion1);
			if(_uiController.ByJerarquia2 && !hierarchicalSearchControl1.NodeDescripcion2.Equals(string.Empty)  && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion2))
			{
				if(chkLista.Items.Contains(_desc2))
					chkLista.Items.Remove(_desc2);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion2, true);
				_desc2 = hierarchicalSearchControl1.NodeDescripcion2;
			}
			else if(!_uiController.ByJerarquia2 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion2))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion2);
			if(_uiController.ByJerarquia3 && !hierarchicalSearchControl1.NodeDescripcion3.Equals(string.Empty)  && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion3))
			{
				if(chkLista.Items.Contains(_desc3))
					chkLista.Items.Remove(_desc3);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion3, true);
				_desc3 = hierarchicalSearchControl1.NodeDescripcion3;
			}
			else if(!_uiController.ByJerarquia3 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion3))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion3);
			if(_uiController.ByJerarquia4 && !hierarchicalSearchControl1.NodeDescripcion4.Equals(string.Empty)  && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion4))
			{
				if(chkLista.Items.Contains(_desc4))
					chkLista.Items.Remove(_desc4);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion4, true);
				_desc4 = hierarchicalSearchControl1.NodeDescripcion4;
			}
			else if(!_uiController.ByJerarquia4 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion4))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion4);
			if(_uiController.ByJerarquia5 && !hierarchicalSearchControl1.NodeDescripcion5.Equals(string.Empty)  && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion5))
			{
				if(chkLista.Items.Contains(_desc5))
					chkLista.Items.Remove(_desc5);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion5, true);
				_desc5 = hierarchicalSearchControl1.NodeDescripcion5;
			}
			else if(!_uiController.ByJerarquia5 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion5))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion5);

			if(_uiController.ByJerarquia6 && !hierarchicalSearchControl1.NodeDescripcion6.Equals(string.Empty)  && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion6))
			{
				if(chkLista.Items.Contains(_desc6))
					chkLista.Items.Remove(_desc6);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion6, true);
				_desc6 = hierarchicalSearchControl1.NodeDescripcion6;
			}
			else if(!_uiController.ByJerarquia6 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion6))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion6);


			
			if(_uiController.ByJerarquia7 && !hierarchicalSearchControl1.NodeDescripcion7.Equals(string.Empty)  && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion7))
			{
				if(chkLista.Items.Contains(_desc7))
					chkLista.Items.Remove(_desc7);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion7, true);
				_desc7 = hierarchicalSearchControl1.NodeDescripcion7;
			}
			else if(!_uiController.ByJerarquia7 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion7))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion7);

			
			if(_uiController.ByJerarquia8 && !hierarchicalSearchControl1.NodeDescripcion8.Equals(string.Empty)  && !chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion8))
			{
				if(chkLista.Items.Contains(_desc8))
					chkLista.Items.Remove(_desc8);
				chkLista.Items.Add(hierarchicalSearchControl1.NodeDescripcion8, true);
				_desc8 = hierarchicalSearchControl1.NodeDescripcion8;
			}
			else if(!_uiController.ByJerarquia8 && chkLista.Items.Contains(hierarchicalSearchControl1.NodeDescripcion8))
				chkLista.Items.Remove(hierarchicalSearchControl1.NodeDescripcion8);
*/

			

			
		}

		/*
		 * Si el usuario decide no agregar listas de precios nuevas entonces tampoco podra agregar productos pues
		 * no puede agregar productos sin ninguna lista de precio.
		 * */
		private void chckAgregaLPProvNuevas_CheckedChanged(object sender, EventArgs e)
		{
			if(!chckAgregaLPProvNuevas.Checked)
			{
				_uiController.AgregaProductosNuevos = false;
				chckAgregaProductosNuevos.Checked = false;
			}
		}

        //German 20120202 - Tarea 0000273

        private void btnTodos2_Click(object sender, EventArgs e)
        {
            _processItem = false;
            for (int i = 0; i < chkListasDePrecios2.Items.Count; i++)
            {
                if (i + 1 == chkListasDePrecios2.Items.Count)// si es el ultimo
                    _processItem = true;
                chkListasDePrecios2.SetItemChecked(i, true);
            }

        }
        private void btnNinguno2_Click(object sender, System.EventArgs e)
        {
            _processItem = false;
            for (int i = 0; i < chkListasDePrecios2.Items.Count; i++)
            {
                if (i + 1 == chkListasDePrecios2.Items.Count)// si es el ultimo
                    _processItem = true;
                chkListasDePrecios2.SetItemChecked(i, false);
            }
        }

        private void btnInvertir2_Click(object sender, System.EventArgs e)
        {
            _processItem = false;
            for (int i = 0; i < chkListasDePrecios2.Items.Count; i++)
            {
                if (i + 1 == chkListasDePrecios2.Items.Count)// si es el ultimo
                    _processItem = true;
                chkListasDePrecios2.SetItemChecked(i, !chkListasDePrecios2.GetItemChecked(i));
            }
        }

        private void btnVerSeleccionados2_Click(object sender, System.EventArgs e)
        {
            ArrayList selectedLP = new ArrayList();
            foreach (mz.erp.businessrules.ListaDePreciosView lp in chkListasDePrecios2.CheckedItems)
                selectedLP.Add(lp);
            chkListasDePrecios2.Items.Clear();
            chkListasDePrecios2.Items.AddRange(selectedLP.ToArray());
            _processItem = false;
            for (int i = 0; i < chkListasDePrecios2.Items.Count; i++)
            {
                if (i + 1 == chkListasDePrecios2.Items.Count)// si es el ultimo
                    _processItem = true;
                chkListasDePrecios2.SetItemChecked(i, true);
            }
        }

        private void btnVerTodas2_Click(object sender, System.EventArgs e)
        {
            int i = 0;
            foreach (mz.erp.businessrules.ListaDePreciosView lp in _uiController.ListasDePrecios)
            {
                if (!chkListasDePrecios2.Items.Contains(lp))
                    chkListasDePrecios2.Items.Insert(i, lp);
                i++;
            }

        }


        //Fin German 20120202 - Tarea 0000273

		private void btnTodos_Click(object sender, EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				if(i +1 == chkListasDePrecios.Items.Count)// si es el ultimo
					_processItem = true;
				chkListasDePrecios.SetItemChecked(i, true);			
			}

		}
		private void btnNinguno_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				if(i +1 == chkListasDePrecios.Items.Count)// si es el ultimo
					_processItem = true;
				chkListasDePrecios.SetItemChecked(i, false);			
			}		
		}

		private void btnInvertir_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				if(i +1 == chkListasDePrecios.Items.Count)// si es el ultimo
					_processItem = true;
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
			_processItem = false;
			for(int i = 0; i<chkListasDePrecios.Items.Count; i++)
			{
				if(i +1 == chkListasDePrecios.Items.Count)// si es el ultimo
					_processItem = true;
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


	}
}

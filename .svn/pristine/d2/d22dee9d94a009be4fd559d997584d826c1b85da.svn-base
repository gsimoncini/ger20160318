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
	/// Descripción breve de FrmConsultaCompras.
	/// </summary>
	public class FrmConsultaCompras : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		#region Código generado por el Diseñador de Windows Forms
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbConsultar;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerJerarquias;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.GroupBox panelBuscarFechasAlmacenadas;
		private System.Windows.Forms.ListBox listBoxFechasAlmcenadas;
		private Infragistics.Win.Misc.UltraButton utbBuscarFechasAlmacenadas;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.GroupBox groupFiltroStock;
		private System.Windows.Forms.RadioButton rbPorEstadoDeStock;
		private System.Windows.Forms.RadioButton rbPorVisualizacionDeStock;
		private System.Windows.Forms.CheckedListBox chklbPorVisualizacion;
		private System.Windows.Forms.CheckedListBox chklbPorEstado;
		private System.Windows.Forms.ListBox listBoxDetalleVisualizacion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl1;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.CheckBox chkResumido;
		private System.Windows.Forms.GroupBox groupBoxFiltroFechas;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaDesdePorProducto;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaHastaPorProducto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkFiltroFechas;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerJerarquiaClientes;
        private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl2;
        //Matias 20100717 - Tarea 88
        private System.Windows.Forms.CheckBox chkSoloActivos;
        private Button btnNingunaVisualizacion;
        private Button btnTodasVisualizacion;
        private Button btnNingunEstado;
        private Button btnEstadosTodos;
        private Button button2;
        private CheckedListBox chklbFiltroStock;
        private Label label3;
        private mz.erp.ui.controls.mzComboEditor mzCmbSecciones;
        private mz.erp.ui.controls.mzComboEditor mzCmbDepositos;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        //FIN Matias 20100717 - Tarea 88
		private System.ComponentModel.IContainer components;

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCompras));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.lblTarea = new System.Windows.Forms.Label();
            this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkSoloActivos = new System.Windows.Forms.CheckBox();
            this.chkResumido = new System.Windows.Forms.CheckBox();
            this.groupBoxFiltroFechas = new System.Windows.Forms.GroupBox();
            this.uccFechaDesdePorProducto = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label7 = new System.Windows.Forms.Label();
            this.uccFechaHastaPorProducto = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFiltroFechas = new System.Windows.Forms.CheckBox();
            this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBuscarFechasAlmacenadas = new System.Windows.Forms.GroupBox();
            this.listBoxFechasAlmcenadas = new System.Windows.Forms.ListBox();
            this.utbBuscarFechasAlmacenadas = new Infragistics.Win.Misc.UltraButton();
            this.label9 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.btnNingunaVisualizacion = new System.Windows.Forms.Button();
            this.btnTodasVisualizacion = new System.Windows.Forms.Button();
            this.btnNingunEstado = new System.Windows.Forms.Button();
            this.btnEstadosTodos = new System.Windows.Forms.Button();
            this.groupFiltroStock = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mzCmbDepositos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbSecciones = new mz.erp.ui.controls.mzComboEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chklbFiltroStock = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxDetalleVisualizacion = new System.Windows.Forms.ListBox();
            this.chklbPorEstado = new System.Windows.Forms.CheckedListBox();
            this.chklbPorVisualizacion = new System.Windows.Forms.CheckedListBox();
            this.rbPorVisualizacionDeStock = new System.Windows.Forms.RadioButton();
            this.rbPorEstadoDeStock = new System.Windows.Forms.RadioButton();
            this.ContainerJerarquias = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.ContainerJerarquiaClientes = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.hierarchicalSearchControl2 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridResultado = new Janus.Windows.GridEX.GridEX();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbConsultar = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.button2 = new System.Windows.Forms.Button();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            this.ContainerFiltro.SuspendLayout();
            this.groupBoxFiltroFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesdePorProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHastaPorProducto)).BeginInit();
            this.panelBuscarFechasAlmacenadas.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.groupFiltroStock.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSecciones)).BeginInit();
            this.ContainerJerarquias.SuspendLayout();
            this.ContainerJerarquiaClientes.SuspendLayout();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar2)).BeginInit();
            this.ultraExplorerBar2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.lblTarea);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(969, 29);
            this.ultraExplorerBarContainerControl4.TabIndex = 2;
            this.ultraExplorerBarContainerControl4.Visible = false;
            // 
            // lblTarea
            // 
            this.lblTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(0, 0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(969, 23);
            this.lblTarea.TabIndex = 2;
            this.lblTarea.Text = "Tarea";
            this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContainerFiltro
            // 
            this.ContainerFiltro.Controls.Add(this.chkSoloActivos);
            this.ContainerFiltro.Controls.Add(this.chkResumido);
            this.ContainerFiltro.Controls.Add(this.groupBoxFiltroFechas);
            this.ContainerFiltro.Controls.Add(this.mzProductosControl1);
            this.ContainerFiltro.Controls.Add(this.mzCmb);
            this.ContainerFiltro.Controls.Add(this.label2);
            this.ContainerFiltro.Controls.Add(this.panelBuscarFechasAlmacenadas);
            this.ContainerFiltro.Controls.Add(this.label9);
            this.ContainerFiltro.Location = new System.Drawing.Point(28, -123);
            this.ContainerFiltro.Name = "ContainerFiltro";
            this.ContainerFiltro.Size = new System.Drawing.Size(969, 138);
            this.ContainerFiltro.TabIndex = 0;
            // 
            // chkSoloActivos
            // 
            this.chkSoloActivos.BackColor = System.Drawing.Color.Transparent;
            this.chkSoloActivos.Location = new System.Drawing.Point(416, 30);
            this.chkSoloActivos.Name = "chkSoloActivos";
            this.chkSoloActivos.Size = new System.Drawing.Size(96, 27);
            this.chkSoloActivos.TabIndex = 56;
            this.chkSoloActivos.Text = "Solo Activos";
            this.chkSoloActivos.UseVisualStyleBackColor = false;
            this.chkSoloActivos.Visible = false;
            // 
            // chkResumido
            // 
            this.chkResumido.BackColor = System.Drawing.Color.Transparent;
            this.chkResumido.Location = new System.Drawing.Point(416, 11);
            this.chkResumido.Name = "chkResumido";
            this.chkResumido.Size = new System.Drawing.Size(152, 27);
            this.chkResumido.TabIndex = 2;
            this.chkResumido.Text = "Resumido";
            this.chkResumido.UseVisualStyleBackColor = false;
            this.chkResumido.Visible = false;
            // 
            // groupBoxFiltroFechas
            // 
            this.groupBoxFiltroFechas.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFiltroFechas.Controls.Add(this.uccFechaDesdePorProducto);
            this.groupBoxFiltroFechas.Controls.Add(this.label7);
            this.groupBoxFiltroFechas.Controls.Add(this.uccFechaHastaPorProducto);
            this.groupBoxFiltroFechas.Controls.Add(this.label6);
            this.groupBoxFiltroFechas.Controls.Add(this.chkFiltroFechas);
            this.groupBoxFiltroFechas.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFiltroFechas.Name = "groupBoxFiltroFechas";
            this.groupBoxFiltroFechas.Size = new System.Drawing.Size(397, 56);
            this.groupBoxFiltroFechas.TabIndex = 55;
            this.groupBoxFiltroFechas.TabStop = false;
            this.groupBoxFiltroFechas.Text = "       Fecha";
            // 
            // uccFechaDesdePorProducto
            // 
            this.uccFechaDesdePorProducto.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaDesdePorProducto.DateButtons.Add(dateButton3);
            this.uccFechaDesdePorProducto.Location = new System.Drawing.Point(85, 19);
            this.uccFechaDesdePorProducto.Name = "uccFechaDesdePorProducto";
            this.uccFechaDesdePorProducto.NonAutoSizeHeight = 23;
            this.uccFechaDesdePorProducto.Size = new System.Drawing.Size(96, 21);
            this.uccFechaDesdePorProducto.TabIndex = 0;
            this.uccFechaDesdePorProducto.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Fecha Inicio";
            // 
            // uccFechaHastaPorProducto
            // 
            this.uccFechaHastaPorProducto.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaHastaPorProducto.DateButtons.Add(dateButton4);
            this.uccFechaHastaPorProducto.Location = new System.Drawing.Point(277, 19);
            this.uccFechaHastaPorProducto.Name = "uccFechaHastaPorProducto";
            this.uccFechaHastaPorProducto.NonAutoSizeHeight = 23;
            this.uccFechaHastaPorProducto.Size = new System.Drawing.Size(96, 21);
            this.uccFechaHastaPorProducto.TabIndex = 1;
            this.uccFechaHastaPorProducto.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(213, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha Fin";
            // 
            // chkFiltroFechas
            // 
            this.chkFiltroFechas.BackColor = System.Drawing.Color.Transparent;
            this.chkFiltroFechas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFiltroFechas.Location = new System.Drawing.Point(11, -4);
            this.chkFiltroFechas.Name = "chkFiltroFechas";
            this.chkFiltroFechas.Size = new System.Drawing.Size(16, 24);
            this.chkFiltroFechas.TabIndex = 3;
            this.chkFiltroFechas.UseVisualStyleBackColor = false;
            // 
            // mzProductosControl1
            // 
            this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl1.EnabledCantidad = true;
            this.mzProductosControl1.EnabledListaDePrecio = true;
            this.mzProductosControl1.Location = new System.Drawing.Point(80, 56);
            this.mzProductosControl1.Name = "mzProductosControl1";
            this.mzProductosControl1.Size = new System.Drawing.Size(408, 50);
            this.mzProductosControl1.TabIndex = 3;
            this.mzProductosControl1.VisibleCantidad = true;
            this.mzProductosControl1.VisibleComboListaDePrecios = true;
            this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl1.VisiblePrecios = true;
            // 
            // mzCmb
            // 
            this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmb.DataValue = "";
            this.mzCmb.EnableCtaCte = false;
            this.mzCmb.FastSearch = false;
            this.mzCmb.Location = new System.Drawing.Point(88, 112);
            this.mzCmb.Name = "mzCmb";
            this.mzCmb.SearchObjectListener = null;
            this.mzCmb.Size = new System.Drawing.Size(491, 24);
            this.mzCmb.TabIndex = 4;
            this.mzCmb.Tag = "ResponsableEmision";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Proveedor";
            // 
            // panelBuscarFechasAlmacenadas
            // 
            this.panelBuscarFechasAlmacenadas.Controls.Add(this.listBoxFechasAlmcenadas);
            this.panelBuscarFechasAlmacenadas.Controls.Add(this.utbBuscarFechasAlmacenadas);
            this.panelBuscarFechasAlmacenadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscarFechasAlmacenadas.Location = new System.Drawing.Point(3, 152);
            this.panelBuscarFechasAlmacenadas.Name = "panelBuscarFechasAlmacenadas";
            this.panelBuscarFechasAlmacenadas.Size = new System.Drawing.Size(454, 136);
            this.panelBuscarFechasAlmacenadas.TabIndex = 52;
            this.panelBuscarFechasAlmacenadas.TabStop = false;
            // 
            // listBoxFechasAlmcenadas
            // 
            this.listBoxFechasAlmcenadas.Location = new System.Drawing.Point(123, 10);
            this.listBoxFechasAlmcenadas.Name = "listBoxFechasAlmcenadas";
            this.listBoxFechasAlmcenadas.Size = new System.Drawing.Size(320, 82);
            this.listBoxFechasAlmcenadas.TabIndex = 9;
            // 
            // utbBuscarFechasAlmacenadas
            // 
            this.utbBuscarFechasAlmacenadas.Location = new System.Drawing.Point(16, 33);
            this.utbBuscarFechasAlmacenadas.Name = "utbBuscarFechasAlmacenadas";
            this.utbBuscarFechasAlmacenadas.Size = new System.Drawing.Size(97, 23);
            this.utbBuscarFechasAlmacenadas.TabIndex = 8;
            this.utbBuscarFechasAlmacenadas.Text = "Buscar";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(0, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "Producto";
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.btnNingunaVisualizacion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTodasVisualizacion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.btnNingunEstado);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.btnEstadosTodos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.groupFiltroStock);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 72);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(969, 172);
            this.ultraExplorerBarContainerControl1.TabIndex = 4;
            // 
            // btnNingunaVisualizacion
            // 
            this.btnNingunaVisualizacion.Location = new System.Drawing.Point(352, 139);
            this.btnNingunaVisualizacion.Name = "btnNingunaVisualizacion";
            this.btnNingunaVisualizacion.Size = new System.Drawing.Size(33, 21);
            this.btnNingunaVisualizacion.TabIndex = 9;
            this.btnNingunaVisualizacion.Text = "N";
            this.btnNingunaVisualizacion.UseVisualStyleBackColor = true;
            // 
            // btnTodasVisualizacion
            // 
            this.btnTodasVisualizacion.Location = new System.Drawing.Point(313, 139);
            this.btnTodasVisualizacion.Name = "btnTodasVisualizacion";
            this.btnTodasVisualizacion.Size = new System.Drawing.Size(33, 21);
            this.btnTodasVisualizacion.TabIndex = 8;
            this.btnTodasVisualizacion.Text = "T";
            this.btnTodasVisualizacion.UseVisualStyleBackColor = true;
            // 
            // btnNingunEstado
            // 
            this.btnNingunEstado.Location = new System.Drawing.Point(122, 139);
            this.btnNingunEstado.Name = "btnNingunEstado";
            this.btnNingunEstado.Size = new System.Drawing.Size(33, 21);
            this.btnNingunEstado.TabIndex = 7;
            this.btnNingunEstado.Text = "N";
            this.btnNingunEstado.UseVisualStyleBackColor = true;
            // 
            // btnEstadosTodos
            // 
            this.btnEstadosTodos.Location = new System.Drawing.Point(83, 139);
            this.btnEstadosTodos.Name = "btnEstadosTodos";
            this.btnEstadosTodos.Size = new System.Drawing.Size(33, 21);
            this.btnEstadosTodos.TabIndex = 6;
            this.btnEstadosTodos.Text = "T";
            this.btnEstadosTodos.UseVisualStyleBackColor = true;
            // 
            // groupFiltroStock
            // 
            this.groupFiltroStock.BackColor = System.Drawing.Color.Transparent;
            this.groupFiltroStock.Controls.Add(this.groupBox1);
            this.groupFiltroStock.Controls.Add(this.label3);
            this.groupFiltroStock.Controls.Add(this.chklbFiltroStock);
            this.groupFiltroStock.Controls.Add(this.label1);
            this.groupFiltroStock.Controls.Add(this.listBoxDetalleVisualizacion);
            this.groupFiltroStock.Controls.Add(this.chklbPorEstado);
            this.groupFiltroStock.Controls.Add(this.chklbPorVisualizacion);
            this.groupFiltroStock.Controls.Add(this.rbPorVisualizacionDeStock);
            this.groupFiltroStock.Controls.Add(this.rbPorEstadoDeStock);
            this.groupFiltroStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFiltroStock.Location = new System.Drawing.Point(0, 0);
            this.groupFiltroStock.Name = "groupFiltroStock";
            this.groupFiltroStock.Size = new System.Drawing.Size(966, 169);
            this.groupFiltroStock.TabIndex = 0;
            this.groupFiltroStock.TabStop = false;
            this.groupFiltroStock.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.mzCmbDepositos);
            this.groupBox1.Controls.Add(this.mzCmbSecciones);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(712, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 80);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicacion";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(227, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 36;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(227, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mzCmbDepositos
            // 
            appearance2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbDepositos.Appearance = appearance2;
            this.mzCmbDepositos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbDepositos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbDepositos.DisplayMember = "";
            this.mzCmbDepositos.DisplayMemberCaption = "";
            this.mzCmbDepositos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbDepositos.Enabled = false;
            this.mzCmbDepositos.Location = new System.Drawing.Point(59, 21);
            this.mzCmbDepositos.MaxItemsDisplay = 50;
            this.mzCmbDepositos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbDepositos.Name = "mzCmbDepositos";
            this.mzCmbDepositos.Size = new System.Drawing.Size(165, 21);
            this.mzCmbDepositos.SorterMember = "";
            this.mzCmbDepositos.TabIndex = 31;
            this.mzCmbDepositos.ValueMember = "";
            this.mzCmbDepositos.ValueMemberCaption = "";
            // 
            // mzCmbSecciones
            // 
            appearance1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbSecciones.Appearance = appearance1;
            this.mzCmbSecciones.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbSecciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mzCmbSecciones.DisplayMember = "";
            this.mzCmbSecciones.DisplayMemberCaption = "";
            this.mzCmbSecciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbSecciones.Enabled = false;
            this.mzCmbSecciones.Location = new System.Drawing.Point(59, 48);
            this.mzCmbSecciones.MaxItemsDisplay = 50;
            this.mzCmbSecciones.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbSecciones.Name = "mzCmbSecciones";
            this.mzCmbSecciones.Size = new System.Drawing.Size(165, 21);
            this.mzCmbSecciones.SorterMember = "";
            this.mzCmbSecciones.TabIndex = 32;
            this.mzCmbSecciones.ValueMember = "";
            this.mzCmbSecciones.ValueMemberCaption = "";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Depósito";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sección";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(617, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de Stock";
            // 
            // chklbFiltroStock
            // 
            this.chklbFiltroStock.BackColor = System.Drawing.SystemColors.Menu;
            this.chklbFiltroStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklbFiltroStock.FormattingEnabled = true;
            this.chklbFiltroStock.Items.AddRange(new object[] {
            "Stock < 0",
            "Stock = 0",
            "Stock > 0"});
            this.chklbFiltroStock.Location = new System.Drawing.Point(620, 40);
            this.chklbFiltroStock.Name = "chklbFiltroStock";
            this.chklbFiltroStock.Size = new System.Drawing.Size(86, 88);
            this.chklbFiltroStock.Sorted = true;
            this.chklbFiltroStock.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(434, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detalle Visualización de Stock";
            // 
            // listBoxDetalleVisualizacion
            // 
            this.listBoxDetalleVisualizacion.Location = new System.Drawing.Point(434, 39);
            this.listBoxDetalleVisualizacion.Name = "listBoxDetalleVisualizacion";
            this.listBoxDetalleVisualizacion.Size = new System.Drawing.Size(177, 95);
            this.listBoxDetalleVisualizacion.TabIndex = 4;
            // 
            // chklbPorEstado
            // 
            this.chklbPorEstado.Location = new System.Drawing.Point(22, 39);
            this.chklbPorEstado.Name = "chklbPorEstado";
            this.chklbPorEstado.Size = new System.Drawing.Size(213, 94);
            this.chklbPorEstado.TabIndex = 2;
            // 
            // chklbPorVisualizacion
            // 
            this.chklbPorVisualizacion.Location = new System.Drawing.Point(238, 39);
            this.chklbPorVisualizacion.Name = "chklbPorVisualizacion";
            this.chklbPorVisualizacion.Size = new System.Drawing.Size(190, 94);
            this.chklbPorVisualizacion.TabIndex = 3;
            // 
            // rbPorVisualizacionDeStock
            // 
            this.rbPorVisualizacionDeStock.BackColor = System.Drawing.Color.Transparent;
            this.rbPorVisualizacionDeStock.Location = new System.Drawing.Point(241, 19);
            this.rbPorVisualizacionDeStock.Name = "rbPorVisualizacionDeStock";
            this.rbPorVisualizacionDeStock.Size = new System.Drawing.Size(152, 24);
            this.rbPorVisualizacionDeStock.TabIndex = 1;
            this.rbPorVisualizacionDeStock.Text = "Por Visualización";
            this.rbPorVisualizacionDeStock.UseVisualStyleBackColor = false;
            // 
            // rbPorEstadoDeStock
            // 
            this.rbPorEstadoDeStock.BackColor = System.Drawing.Color.Transparent;
            this.rbPorEstadoDeStock.Location = new System.Drawing.Point(25, 19);
            this.rbPorEstadoDeStock.Name = "rbPorEstadoDeStock";
            this.rbPorEstadoDeStock.Size = new System.Drawing.Size(104, 24);
            this.rbPorEstadoDeStock.TabIndex = 0;
            this.rbPorEstadoDeStock.Text = "Por Estado";
            this.rbPorEstadoDeStock.UseVisualStyleBackColor = false;
            // 
            // ContainerJerarquias
            // 
            this.ContainerJerarquias.Controls.Add(this.hierarchicalSearchControl1);
            this.ContainerJerarquias.Location = new System.Drawing.Point(28, 301);
            this.ContainerJerarquias.Name = "ContainerJerarquias";
            this.ContainerJerarquias.Size = new System.Drawing.Size(969, 36);
            this.ContainerJerarquias.TabIndex = 3;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(846, 40);
            this.hierarchicalSearchControl1.TabIndex = 0;
            // 
            // ContainerJerarquiaClientes
            // 
            this.ContainerJerarquiaClientes.Controls.Add(this.hierarchicalSearchControl2);
            this.ContainerJerarquiaClientes.Location = new System.Drawing.Point(28, 394);
            this.ContainerJerarquiaClientes.Name = "ContainerJerarquiaClientes";
            this.ContainerJerarquiaClientes.Size = new System.Drawing.Size(969, 53);
            this.ContainerJerarquiaClientes.TabIndex = 5;
            // 
            // hierarchicalSearchControl2
            // 
            this.hierarchicalSearchControl2.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchicalSearchControl2.Location = new System.Drawing.Point(0, 0);
            this.hierarchicalSearchControl2.Name = "hierarchicalSearchControl2";
            this.hierarchicalSearchControl2.Size = new System.Drawing.Size(969, 104);
            this.hierarchicalSearchControl2.TabIndex = 11;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridResultado);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(969, 296);
            this.ultraExplorerBarContainerControl3.TabIndex = 1;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // gridResultado
            // 
            this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridResultado.GroupByBoxVisible = false;
            this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridResultado.Location = new System.Drawing.Point(0, 24);
            this.gridResultado.Name = "gridResultado";
            this.gridResultado.Size = new System.Drawing.Size(969, 272);
            this.gridResultado.TabIndex = 1;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(969, 24);
            this.gridManagerView1.TabIndex = 0;
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
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbAnterior,
            this.tbbSeparator,
            this.tbbSiguiente,
            this.tbbSeparator2,
            this.tbbConsultar,
            this.tbbSeparator3,
            this.tbbReiniciarFiltros,
            this.toolBarButton3,
            this.tbbCancelar,
            this.toolBarButton2});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(1035, 28);
            this.toolBarStandar.TabIndex = 21;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
            // tbbConsultar
            // 
            this.tbbConsultar.ImageIndex = 2;
            this.tbbConsultar.Name = "tbbConsultar";
            this.tbbConsultar.Text = "Ejecutar Consulta[F5]";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbReiniciarFiltros
            // 
            this.tbbReiniciarFiltros.ImageIndex = 5;
            this.tbbReiniciarFiltros.Name = "tbbReiniciarFiltros";
            this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // ultraExplorerBar2
            // 
            this.ultraExplorerBar2.AnimationEnabled = false;
            this.ultraExplorerBar2.Controls.Add(this.ContainerFiltro);
            this.ultraExplorerBar2.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar2.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar2.Controls.Add(this.ContainerJerarquias);
            this.ultraExplorerBar2.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar2.Controls.Add(this.ContainerJerarquiaClientes);
            this.ultraExplorerBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup1.Key = "Tarea";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 29;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ContainerFiltro;
            ultraExplorerBarGroup2.Key = "FiltroInicial";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 138;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Filtro Inicial";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup3.Key = "OtrosFiltros";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 172;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Otros Filtros";
            ultraExplorerBarGroup4.Container = this.ContainerJerarquias;
            ultraExplorerBarGroup4.Key = "Jerarquias";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 36;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Jerarquías";
            ultraExplorerBarGroup5.Container = this.ContainerJerarquiaClientes;
            ultraExplorerBarGroup5.Key = "JerarquiaClientes";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 53;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Jerarquía de Clientes";
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup6.Key = "Resultado";
            ultraExplorerBarGroup6.Settings.ContainerHeight = 296;
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Resultado";
            this.ultraExplorerBar2.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5,
            ultraExplorerBarGroup6});
            this.ultraExplorerBar2.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar2.Name = "ultraExplorerBar2";
            this.ultraExplorerBar2.Size = new System.Drawing.Size(1035, 458);
            this.ultraExplorerBar2.TabIndex = 22;
            this.ultraExplorerBar2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 21);
            this.button2.TabIndex = 7;
            this.button2.Text = "N";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaCompras
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1035, 486);
            this.Controls.Add(this.ultraExplorerBar2);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmConsultaCompras";
            this.Text = "FrmConsultaCompras";
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            this.ContainerFiltro.ResumeLayout(false);
            this.groupBoxFiltroFechas.ResumeLayout(false);
            this.groupBoxFiltroFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesdePorProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHastaPorProducto)).EndInit();
            this.panelBuscarFechasAlmacenadas.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.groupFiltroStock.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSecciones)).EndInit();
            this.ContainerJerarquias.ResumeLayout(false);
            this.ContainerJerarquiaClientes.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar2)).EndInit();
            this.ultraExplorerBar2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		#region Constructores y Destructores
		public FrmConsultaCompras()
		{
			InitializeComponent();			
		}
		public FrmConsultaCompras(controllers.ConsultaComprasController controller)
		{
			InitializeComponent();
			_uiController = controller;
			Init();
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

		#region Variables Privadas
		
		private mz.erp.ui.controllers.ConsultaComprasController _uiController = null;
		private ReportFilterArray _filtros = null;
		private int iniX = 10;
		private int iniY = 10;
		private int desplazamientotexto = 150;
		private int factordealtura = 24;
		private ArrayList _parametros = new ArrayList();
		

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

			mzProductosControl1.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "");

			chkResumido.Visible = _uiController.VisualizaCheckBoxResumido;
			//CallGridManager();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);

			ultraExplorerBar2.Groups[2].Expanded = false;	
			uccFechaDesdePorProducto.Enabled = false;
			uccFechaHastaPorProducto.Enabled = false;			
			lblTarea.Text = _uiController.LeyendaFormulario;

			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.gridResultado.AutomaticSort = true;
			this.KeyPreview = true;
			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS",_uiController.AllowMultipleSelect);
			if(_uiController.AllowShowBuscarFechasAlmacenadas)
			{
				this.ContainerFiltro.SetBounds(this.ContainerFiltro.Location.X , this.ContainerFiltro.Location.Y, this.ContainerFiltro.Size.Width,this.ContainerFiltro.Size.Height + (this.panelBuscarFechasAlmacenadas.Size.Height - 3));
			}
			this.ultraExplorerBar2.Groups["Jerarquias"].Visible = _uiController.VisualizaJerarquias;

            /* Silvina 20100630 - Tarea 669 */
            hierarchicalSearchControl2.Build_UI("CUENTAS", _uiController.AllowMultipleSelect);
            this.ultraExplorerBar2.Groups["JerarquiaClientes"].Visible = _uiController.VisualizaJerarquiasClientes;
            /* Fin Silvina */

			this.mzProductosControl1.Enabled = _uiController.HabilitaFiltroProducto;
			this.ultraExplorerBar2.Groups["OtrosFiltros"].Visible = _uiController.VisualizaOtrosFiltros;
			this.ultraExplorerBar2.Groups["OtrosFiltros"].Expanded = _uiController.VisualizaOtrosFiltros;

			if(_uiController.HabilitaFiltroStock)
			{
				this.groupFiltroStock.Enabled = _uiController.HabilitaFiltroStock;
				this.rbPorEstadoDeStock.Checked = true;
				_uiController.ByEstadoDeStock = true;
				this.chklbPorEstado.Enabled = true;
				this.chklbPorVisualizacion.Enabled = false;
				this.listBoxDetalleVisualizacion.Enabled = false;

			}

			this.mzCmb.Enabled = _uiController.HabilitaFiltroProveedor;
			mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ContainerJerarquias, hierarchicalSearchControl1);
            /* Silvina 20100630 - Tarea 669 */
            mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ContainerJerarquiaClientes, hierarchicalSearchControl2);
            /* Fin Silvina */
			if(_uiController.ByFechas)
			{
				uccFechaDesdePorProducto.Enabled = true;
				uccFechaHastaPorProducto.Enabled = _uiController.PermiteModificarFechaHasta;//true;	
			}
			KeyPreview = true;
			if(!_uiController.VisualizaFiltroProveedor)
			{
				mzCmb.Visible = false;
				label2.Visible = false;
				ContainerFiltro.SetBounds(ContainerFiltro.Location.X, ContainerFiltro.Location.Y, ContainerFiltro.Size.Width, ContainerFiltro.Size.Height - mzCmb.Size.Height);
			}

			if(!_uiController.VisualizaFiltroProducto)
			{
				mzProductosControl1.Visible = false;
				label9.Visible = false;
				ContainerFiltro.SetBounds(ContainerFiltro.Location.X, ContainerFiltro.Location.Y, ContainerFiltro.Size.Width, ContainerFiltro.Size.Height - mzProductosControl1.Size.Height);
				if(_uiController.VisualizaFiltroProveedor)
				{
					mzCmb.Location = new System.Drawing.Point(mzProductosControl1.Location.X,mzProductosControl1.Location.Y);
					label2.Location = new System.Drawing.Point(label9.Location.X,label9.Location.Y);
				}
			}

            //Matias 20100717 - Tarea 88
            this.chkSoloActivos.Enabled = _uiController.SoloActivosHabilitado;
            this.chkSoloActivos.Visible = _uiController.SoloActivosVisible;
            this.chkSoloActivos.Checked = _uiController.SoloActivos;
            //Fin Matias 20100717 - Tarea 88

		}

		/*private void CallGridManager()
		{
			string proceso = _uiController.GetProcessManager().GetProcessName();
			string tarea = _uiController.GetTaskName();
			controllers.GridVariablesLoader loader = new controllers.GridVariablesLoader(proceso, tarea);
			_allowCollapseGroups = loader.AllowGroupCollapse;
			GridManagerJanus manager = new GridManagerJanus(gridResultado);
			manager.ConfigureGrid(proceso, tarea, loader);
			ConfigureGrid();
			gridManagerView1.Init(manager, proceso, tarea, loader);	
			gridManagerView1.EnableMarkControl(loader.AllowMarkRow);
			gridManagerView1.ConfigureMarkControl("Imprimir");
			gridManagerView1.EnableColumnsControl(loader.AllowDefineVisibleColumns);
			gridManagerView1.ConfigureColumnsControl(string.Empty);
<<<<<<< FrmConsultaCompras.cs
			gridManagerView1.EnableExportExcelControl(true);
			gridManagerView1.ConfigureExportExcelControl(string.Empty);
		}*/

	

		private void ConfigureGrid()
		{
			
			
		}

		private void InitializeData()
		{
            //Cristian Tarea 0000010 20110223
            chklbFiltroStock.SetItemChecked(2,true);
            this.mzCmbDepositos.FillFromDataSource(_uiController.ListaDeposito, "IdDeposito", "Descripcion", 8, "Descripcion");

            if (_uiController.IdDeposito != "")
            {
                this.mzCmbDepositos.SetValue(_uiController.IdDeposito);
                _uiController.FiltroListaSecciones();
            }

            this.mzCmbSecciones.FillFromDataSource(_uiController.ListaSeccion, "IdSeccion", "Descripcion", 8, "Descripcion");
            if (_uiController.IdSeccion != "")
            {
                this.mzCmbSecciones.SetValue(_uiController.IdSeccion);
                this.mzCmbSecciones.Enabled = false;
            }
            this.mzCmbDepositos.DataBindings.Add("Value", _uiController, "IdDeposito");
            this.mzCmbSecciones.DataBindings.Add("Value", _uiController, "IdSeccion");
            //Fin Criatian


		}
		private void InitEventHandlers()
		{
			
			_uiController.DataChanged+=new EventHandler(RefreshData);
			this.Load +=new EventHandler(FrmConsultaCompras_Load);
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			gridResultado.GroupsChanged +=new Janus.Windows.GridEX.GroupsChangedEventHandler(gridResultado_GroupsChanged);
			this.chkFiltroFechas.Click += new System.EventHandler(this.chkFiltroFechas_Click);
			hierarchicalSearchControl1.OnSelected+=new EventHandler(hierarchicalSearchControl1_OnSelected);
            /* Silvina 20100630 - Tarea 669 */
            hierarchicalSearchControl2.OnSelected += new EventHandler(hierarchicalSearchControl2_OnSelected);
            /* Fin Silvina */
			utbBuscarFechasAlmacenadas.Click +=new EventHandler(utbBuscarFechasAlmacenadas_Click);
			listBoxFechasAlmcenadas.SelectedIndexChanged +=new EventHandler(listBoxFechasAlmcenadas_SelectedIndexChanged);
			if(_uiController.HabilitaFiltroStock)
			{
				rbPorEstadoDeStock.CheckedChanged +=new EventHandler(CheckedChanged);
				rbPorVisualizacionDeStock.CheckedChanged +=new EventHandler(CheckedChanged);
				chklbPorVisualizacion.SelectedIndexChanged +=new EventHandler(chklbPorVisualizacion_SelectedIndexChanged);
			}
			groupBoxFiltroFechas.Enabled = _uiController.HabilitaFiltroFechas;
			KeyDownManager KeyDown = new KeyDownManager(this);
            //Cristian Tarea 0000010 20110222 
            btnEstadosTodos.Click += new EventHandler(btnSeleccionTodosEstados_Click);
            btnNingunEstado.Click += new EventHandler(btnSeleccionNingunEstado_Click);
            btnNingunaVisualizacion.Click += new EventHandler(btnSeleccionNingunaVisualizacion_Click);
            btnTodasVisualizacion.Click += new EventHandler(btnSeleccionTodasVisualizacion_Click);
            checkBox1.CheckStateChanged += new EventHandler(checkBox1_CheckStateChanged);
            checkBox2.CheckStateChanged += new EventHandler(checkBox2_CheckStateChanged);
            mzCmbDepositos.ValueChanged += new EventHandler(mzCmbDepositos_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000050 20110310
            this.uccFechaDesdePorProducto.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110719
            this.uccFechaHastaPorProducto.ValueChanged += new EventHandler(uccFechaHastaPorProducto_ValueChanged);
            //Fin Cristian


        }


        //Cristian Tarea 0000146 20110719
        void uccFechaHastaPorProducto_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaHastaPorProducto.Value)), true);
            this.uccFechaDesdePorProducto.Value = _uiController.FechaDesde;
        }
        //Fin Cristian Tarea 0000146

        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaDesdePorProducto.Value)),false);
            this.uccFechaHastaPorProducto.Value = _uiController.FechaHasta;

        }
        //Fin Cristian



        //Cristian Tarea 0000010 20110223

        void mzCmbDepositos_ValueChanged(object sender, EventArgs e)
        {
            if (mzCmbDepositos.Value != null)
            {
                _uiController.IdDeposito = (string)mzCmbDepositos.Value;
                _uiController.FiltroListaSecciones();
                this.mzCmbSecciones.FillFromDataSource(_uiController.ListaSeccion, "idSeccion", "Descripcion", 8, "Descripcion");
                //Verifico que si existe una sola sección para el depósito seleccionado, que automáticamente lo muestre.

                this.mzCmbSecciones.SetValue(_uiController.IdSeccion);
                

            }
        }
        void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            mzCmbDepositos.Enabled = checkBox1.Checked;
            if (!mzCmbDepositos.Enabled)
            {
                checkBox2.Checked = false;
            }
            

        }
        void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            mzCmbSecciones.Enabled = checkBox2.Checked;
        }
        //Fin Cristian
		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.RefreshData();
					break;
			}
		}
	
		private void InitDataBindings()
		{				
			BindingController.Bind(chkFiltroFechas, "Checked", _uiController, "ByFechas");
			BindingController.Bind(chkResumido, "Checked", _uiController, "Resumido");
			uccFechaDesdePorProducto.DataBindings.Add("Value", _uiController, "FechaDesde");
			uccFechaHastaPorProducto.DataBindings.Add("Value", _uiController, "FechaHasta");
			mzProductosControl1.AddObjectListener( (IObserver)_uiController );
			mzCmb.DataBindings.Add("DataValue", _uiController, "CodigoProveedor");
			if(_uiController.HabilitaFiltroStock)
			{
				chklbPorVisualizacion.Items.AddRange(_uiController.VisualizacionesDeStock.ToArray());
				chklbPorEstado.Items.AddRange(_uiController.EstadosDeStock.ToArray());
                //Cristian Tarea 0000046 20110321
                if (!_uiController.GetProcessManager().GetProcessName().Equals("ProcesoConsultarStock"))
                {
                    this.btnSeleccionTodosEstados_Click(this.btnEstadosTodos, new EventArgs());
                    btnTodasVisualizacion.Enabled = false;
                    btnNingunaVisualizacion.Enabled = false;
                    listBoxDetalleVisualizacion.Enabled = false;
                    rbPorVisualizacionDeStock.Enabled = false;
                    chklbFiltroStock.Enabled = false;
                    groupBox1.Enabled = false;
                }
                //Fin Cristian
			}
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
			_uiController.Execute();
		}

		#endregion

		#region Métodos privados
		
		
		private void chkFiltroFechas_Click(object sender, System.EventArgs e)
		{
			uccFechaDesdePorProducto.Enabled = chkFiltroFechas.Checked;
            /* Silvina 20101126 - Tarea 956 */
            uccFechaHastaPorProducto.Enabled = chkFiltroFechas.Checked && _uiController.PermiteModificarFechaHasta;
            /* Fin Silvina */
		}

        /*Cristian Tarea 0000010 20110221*/
        private void btnSeleccionTodosEstados_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < chklbPorEstado.Items.Count; i++)
            {
                chklbPorEstado.SetItemChecked(i, true);
            }
        }
        private void btnSeleccionNingunEstado_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < chklbPorEstado.Items.Count; i++)
            {
                chklbPorEstado.SetItemChecked(i,false);
            }
        }
        private void btnSeleccionTodasVisualizacion_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < chklbPorVisualizacion.Items.Count; i++)
            {
                chklbPorVisualizacion.SetItemChecked(i, true);
            }
        }
        private void btnSeleccionNingunaVisualizacion_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < chklbPorVisualizacion.Items.Count; i++)
            {
                chklbPorVisualizacion.SetItemChecked(i, false);
            }
        }
        //Fin Cristian
		private void Init()
		{
			//toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);						
			_filtros = _uiController.GetFiltro();
			#region filtros
			for (int i=0;i<=(_filtros.Count-1);i++)
			{
				ReportFilterItem unfiltro = _filtros[i];
				/*if(unfiltro.Clave.ToUpper().Equals("ESTADOSORDENREPARACION"))
				{
					_parametros.Add( null );
					FiltroEstadoOrdenReparacion(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding, unfiltro.Table );
				}
				if ((unfiltro.Clave.ToUpper() == "ESTADODESTOCK"))
				{
					_parametros.Add( null );
					FiltroEstadoDeStock(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "SECCION"))
				{
					_parametros.Add( null );
					FiltroSeccion(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "DEPOSITO"))
				{
					_parametros.Add( null );
					FiltroDeposito(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}*/
				if ((unfiltro.Clave.ToUpper() == "PRODUCTO"))
				{
					_parametros.Add( null );
					FiltroProducto(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				/*if ((unfiltro.Clave.ToUpper() == "TIPODEAJUSTE"))
				{
					_parametros.Add( null );
					FiltroTipoDeAjuste(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "CUENTA"))
				{
					_parametros.Add( null );
					FiltroCuenta(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "PERSONA"))
				{
					_parametros.Add( null );
					FiltroPersona(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "RESPONSABLE"))
				{
					_parametros.Add( null );
					FiltroResponsable(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "FECHA"))
				{
					_parametros.Add( mz.erp.businessrules.Sistema.DateTime.Now );
					FiltroFecha(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
				}
				if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTE"))
				{
					_parametros.Add( null );
					FiltroTipoDeComprobante(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTEAGRUPADO"))
				{
					_parametros.Add( null );
					FiltroTipoDeComprobanteAgrupado(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}*/
				if ((unfiltro.Clave.ToUpper() == "PROVEEDOR"))
				{
					_parametros.Add( null );
					FiltroProveedor(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}
				/*if ((unfiltro.Clave.ToUpper() == "MONEDA"))
				{
					_parametros.Add( null );
					FiltroMoneda(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "MOMENTO"))
				{
					_parametros.Add( null );
					FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}
				if ((unfiltro.Clave.ToUpper() == "IDORDENREPARACION"))
				{
					_parametros.Add( null );
					FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
				}*/
			}
			#endregion
		}


		private void ValueChanged( object sender, System.EventArgs e)
		{
			if (sender.GetType() == typeof(mz.erp.ui.controls.mzComboSearchEditor))
			{
				_parametros[((Control)sender).TabIndex] = (string)((mz.erp.ui.controls.mzComboSearchEditor)sender).DataValue;
			}
			if (sender.GetType() == typeof(mz.erp.ui.controls.mzComboEditor))
			{
				_parametros[((Control)sender).TabIndex] = (string)((mz.erp.ui.controls.mzComboEditor)sender).Value;
			}

			if (sender.GetType() == typeof(Infragistics.Win.UltraWinSchedule.UltraCalendarCombo))
			{
				if (((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value == System.DBNull.Value)
				{
					_parametros[((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).TabIndex] = System.DateTime.MinValue;
				}
				else
				{
					_parametros[((Control)sender).TabIndex] = (System.DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
				}
			}
			if (sender.GetType() == typeof(System.Windows.Forms.ComboBox))
			{
				_parametros[((System.Windows.Forms.ComboBox)sender).TabIndex] =(string)((System.Windows.Forms.ComboBox)sender).Text ;
			}
			if (sender.GetType() == typeof(System.Windows.Forms.TextBox))
			{
				_parametros[((System.Windows.Forms.TextBox)sender).TabIndex] =(string)((System.Windows.Forms.TextBox)sender).Text ;
			}

		}

		private void FiltroProducto(int order, string leyenda, bool enabled, object defaultValue , string propertyBinding)
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchProducto = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchProducto.DataValue = "";
			mzComboSearchProducto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchProducto.SearchObject = typeof(mz.erp.ui.forms.classes.tsh_Productos);
			mzComboSearchProducto.Size = new System.Drawing.Size(496, 24);

			mzComboSearchProducto.Name = "mzComboSearchProducto"+Convert.ToString(order).Trim();
			mzComboSearchProducto.TabIndex = order;
			mzComboSearchProducto.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchProducto.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
			mzComboSearchProducto.ValueChanged+= new System.EventHandler( this.ValueChanged );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				
			label.BackColor = System.Drawing.Color.Transparent;
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblProducto"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchProducto );

			if (defaultValue != null)
			{
				mzComboSearchProducto.DataValue= (string)defaultValue;
			}		
		}
		private void FiltroProveedor(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchProveedor = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchProveedor.DataValue = "";
			mzComboSearchProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchProveedor.SearchObject = typeof(mz.erp.ui.forms.classes.tpu_Proveedores);
			mzComboSearchProveedor.Size = new System.Drawing.Size(496, 24);

			mzComboSearchProveedor.Name = "mzComboSearchProveedor"+Convert.ToString(order).Trim();
			mzComboSearchProveedor.TabIndex = order;
			mzComboSearchProveedor.ValueChanged+= new System.EventHandler( this.ValueChanged );
			mzComboSearchProveedor.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchProveedor.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchProveedor );
			if (defaultValue != null)
			{
				mzComboSearchProveedor.DataValue= (string)defaultValue;
			}
			else
			{
				if(_uiController != null)
				{
					mzComboSearchProveedor.DataBindings.Add("DataValue", _uiController, propertyBinding);
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
				case 2:
					_uiController.Execute();
					break;
				case 4:					
					RefreshData();
					break;
				case 6:					
					ResetFilters();
					break;
				case 8:					
					CloseForm();
					break;
			}				
		}
		protected void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);			
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			SetParameters();	
		    //Cristian 0000010 20110225
		    if (chklbFiltroStock.CheckedIndices.Count <= 0)
		    {
                MessageBox.Show("Seleccione una opcion de Cantidad de Stock.", "Cantidad de Stock", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		    }
            //Fin Cristian
			if(_uiController.FechasValidas())
				if (_uiController.RangoDeFechasValido())
					_uiController.RefreshData();
				else
					MessageBox.Show("Rango de Fechas Inválido.","Fechas Inválidas", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			else
				MessageBox.Show("La fechas deben coincidir.","Fechas Inválidas", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			this.Cursor = Cursors.Default;

		}


		private void SetParameters()
		{
			if(_uiController.HabilitaFiltroStock)
			{
				ArrayList aux = new ArrayList();
				foreach(object obj in chklbPorEstado.CheckedItems)
				{
					aux.Add(obj);
				}
				_uiController.SelectedEstadosDeStock = aux;
				ArrayList aux1 = new ArrayList();
				foreach(object obj in chklbPorVisualizacion.CheckedItems)
				{
					aux1.Add(obj);
				}
				_uiController.SelectedVisualizacionesDeStock = aux1;

			}
            //Cristian Tarea 0000010
            ArrayList filtrosStock = new ArrayList();

		    for (int i = 0; i < chklbFiltroStock.Items.Count; i++)
		    {
		        filtrosStock.Add(chklbFiltroStock.GetItemChecked(i));
		    }

		    _uiController.FiltroStock = filtrosStock;

            if (!checkBox1.Checked)
		    {
		        _uiController.IdDeposito = "";
                _uiController.IdSeccion = "";
		    }

            //Fin Cristian
            _uiController.SoloActivos = this.chkSoloActivos.Checked; //Matias 20100719 - Tarea 88
		}

		

		private void RefreshData(object sender, EventArgs e)
		{
			//gridResultado.LayoutData = _uiController.GetLayout();
			//ConfigureGrid();
			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Result, null);

			if(gridManagerView1.AllowGroupCollapse)
				gridResultado.CollapseGroups();
							
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.Result);			
			
		}

		private void ResetFilters()
		{
			mzProductosControl1.ClearControl();
			_uiController.Codigo=string.Empty;
            //Cristian Tarea 0000010 20110225
            chklbFiltroStock.SetItemChecked(0,false);
            chklbFiltroStock.SetItemChecked(1,false);
            chklbFiltroStock.SetItemChecked(2,true );
            this.mzCmbDepositos.Enabled = false;
		    checkBox1.Checked = false;
            this.mzCmbSecciones.Enabled = false;
            //Fin Cristian
			mzCmb.ClearControl();
			_uiController.CodigoProveedor=string.Empty;

            /* Silvina 20100909 - Tarea 669 */
			//chkFiltroFechas.Checked=false;
            chkFiltroFechas.Checked = _uiController.ByFechasDefault;
            /* Fin Silvina */
			uccFechaDesdePorProducto.Enabled = chkFiltroFechas.Checked;
            /* Silvina 20101126 - Tarea 956 */
            uccFechaHastaPorProducto.Enabled = chkFiltroFechas.Checked && _uiController.PermiteModificarFechaHasta;
            /* Fin Silvina */
			uccFechaDesdePorProducto.Value = DateTime.Now;
			uccFechaHastaPorProducto.Value = DateTime.Now;

			hierarchicalSearchControl1.ClearSelectedNodes();

//			chklbPorEstado;
//			chklbPorVisualizacion;

			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}

		private void FrmConsultaCompras_Load(object sender, EventArgs e)
		{
			

		}

		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
		}

		#endregion


		private void gridResultado_GroupsChanged(object sender, Janus.Windows.GridEX.GroupsChangedEventArgs e)
		{
			this.gridResultado.CollapseGroups();
		}

		private void gridManagerView1_Load(object sender, System.EventArgs e)
		{
		
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

        /* Silvina 20100630 - Tarea 669 */
        private void hierarchicalSearchControl2_OnSelected(object sender, EventArgs e)
        {
            _uiController.ByJerarquiaCliente1 = hierarchicalSearchControl2.NodeChecked1;
            _uiController.JerarquiasCliente1 = hierarchicalSearchControl2.ItemsJerarquia1;
            _uiController.ByJerarquiaCliente2 = hierarchicalSearchControl2.NodeChecked2;
            _uiController.JerarquiasCliente2 = hierarchicalSearchControl2.ItemsJerarquia2;
            _uiController.ByJerarquiaCliente3 = hierarchicalSearchControl2.NodeChecked3;
            _uiController.JerarquiasCliente3 = hierarchicalSearchControl2.ItemsJerarquia3;
            _uiController.ByJerarquiaCliente4 = hierarchicalSearchControl2.NodeChecked4;
            _uiController.JerarquiasCliente4 = hierarchicalSearchControl2.ItemsJerarquia4;
            _uiController.ByJerarquiaCliente5 = hierarchicalSearchControl2.NodeChecked5;
            _uiController.JerarquiasCliente5 = hierarchicalSearchControl2.ItemsJerarquia5;
            _uiController.ByJerarquiaCliente6 = hierarchicalSearchControl2.NodeChecked6;
            _uiController.JerarquiasCliente6 = hierarchicalSearchControl2.ItemsJerarquia6;
            _uiController.ByJerarquiaCliente7 = hierarchicalSearchControl2.NodeChecked7;
            _uiController.JerarquiasCliente7 = hierarchicalSearchControl2.ItemsJerarquia7;
            _uiController.ByJerarquiaCliente8 = hierarchicalSearchControl2.NodeChecked8;
            _uiController.JerarquiasCliente8 = hierarchicalSearchControl2.ItemsJerarquia8;

        }

		private void utbBuscarFechasAlmacenadas_Click(object sender, EventArgs e)
		{
			this.listBoxFechasAlmcenadas.Items.Clear();
			ArrayList aux =  _uiController.GetFechasAlmacenadas();
			foreach(DateTime f in aux)
			{
				this.listBoxFechasAlmcenadas.Items.Add(f);
			}
		}

		private void listBoxFechasAlmcenadas_SelectedIndexChanged(object sender, EventArgs e)
		{
			_uiController.FechaSeleccionada = Convert.ToDateTime(this.listBoxFechasAlmcenadas.SelectedItem);
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void CheckedChanged(object sender, EventArgs e)
		{
			chklbPorEstado.Enabled = rbPorEstadoDeStock.Checked;
			chklbPorVisualizacion.Enabled = rbPorVisualizacionDeStock.Checked;
			listBoxDetalleVisualizacion.Enabled = rbPorVisualizacionDeStock.Checked;
			_uiController.ByEstadoDeStock = rbPorEstadoDeStock.Checked;
            //Cristian Tarea 0000010 20110222
		    btnTodasVisualizacion.Enabled = rbPorVisualizacionDeStock.Checked;
            btnNingunaVisualizacion.Enabled = rbPorVisualizacionDeStock.Checked;
		    btnEstadosTodos.Enabled = rbPorEstadoDeStock.Checked;
		    btnNingunEstado.Enabled = rbPorEstadoDeStock.Checked;
            //Fin Cristian
		}

		private void chklbPorVisualizacion_SelectedIndexChanged(object sender, EventArgs e)
		{
			listBoxDetalleVisualizacion.Items.Clear();
			object selectedItem = chklbPorVisualizacion.SelectedItem;
			listBoxDetalleVisualizacion.Items.AddRange(_uiController.GetDetalleVisualizacionDeStock(selectedItem).ToArray());
		}

		private void groupBoxFiltroFechas_Enter(object sender, System.EventArgs e)
		{
		
		}

        public EventHandler FechaHasta_ValueChanged { get; set; }
    }
}

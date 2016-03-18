using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmStockNDias.
	/// </summary>
	public class FrmStockNDias : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage HojaBuscadorPorProducto;
        private System.Windows.Forms.TabPage HojaBuscadorPorJerarquia;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasPorProducto;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaHastaPorProducto;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaDesdePorProducto;
		private System.Windows.Forms.ToolBarButton tbbConsultar;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox grupoAperturaCierre;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasPorJerarquia;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaHastaPorJerarquia;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaDesdePorJerarquia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbUltimaCompraPorProducto;
		private System.Windows.Forms.RadioButton rbPrecioDeListaProveedorPorProducto;
		private System.Windows.Forms.RadioButton rbUltimaCompraProveedorPorProducto;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbUltimaCompraProveedorPorJerarquia;
		private System.Windows.Forms.RadioButton rbUltimaCompraPorJerarquia;
		private System.Windows.Forms.RadioButton rbPrecioDeListaProveedorPorJerarquia;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private mz.erp.ui.controls.mzProveedoresControl mzCmbProveedorPorJerarquia;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl1;
        /* Silvina 20101214 - Tarea 954 */
        private Panel panel2;
        /* Fin Silvina */
        private Janus.Windows.GridEX.GridEX gridEX1;
		private System.ComponentModel.IContainer components;

		
		#region Contructores


		public FrmStockNDias()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmStockNDias(StockNDiasController uiController )
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_uiController = uiController;

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}




		#endregion

		#region Variables Privadas

			private StockNDiasController _uiController;

		#endregion

		#region Dispose
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
				_uiController.DataDetailHierarchyChanged -= new System.EventHandler( this.OnDetailHierarchyListener );
				_uiController.ObjectHasChanged -=new EventHandler(Refresh);
				uneDiasPorJerarquia.Enter -=new EventHandler(uneDiasPorJerarquia_Enter);
				uneDiasPorProducto.Enter -=new EventHandler(uneDiasPorProducto_Enter);
				toolBarStandar.ButtonClick -=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
				_uiController.ObjectHasChanged -=new EventHandler(Refresh);
				tabControl2.SelectedIndexChanged -=new EventHandler(tabControl2_SelectedIndexChanged);
				this.Load -=new EventHandler(FrmStockNDias_Load);
				this.hierarchicalSearchControl1.OnSelected -=new EventHandler(hierarchicalSearchControl1_OnSelected);
				rbUltimaCompraPorProducto.CheckedChanged -=new EventHandler(rbUltimaCompraPorProducto_CheckedChanged);
				rbUltimaCompraProveedorPorProducto.CheckedChanged -=new EventHandler(rbUltimaCompraProveedorPorProducto_CheckedChanged);
				rbPrecioDeListaProveedorPorProducto.CheckedChanged -= new EventHandler(rbPrecioDeListaProveedorPorProducto_CheckedChanged);
				rbUltimaCompraPorJerarquia.CheckedChanged -= new EventHandler(rbUltimaCompraPorJerarquia_CheckedChanged);
				rbUltimaCompraProveedorPorJerarquia.CheckedChanged -= new EventHandler(rbUltimaCompraProveedorPorJerarquia_CheckedChanged);
				rbPrecioDeListaProveedorPorJerarquia.CheckedChanged -=new EventHandler(rbPrecioDeListaProveedorPorJerarquia_CheckedChanged);


				//mzCEProductos.DataBindings.Clear();
				mzCmb.DataBindings.Clear();
				mzCmbProveedorPorJerarquia.DataBindings.Clear();
				uneDiasPorJerarquia.DataBindings.Clear();
				uneDiasPorProducto.DataBindings.Clear();
				uccFechaDesdePorJerarquia.DataBindings.Clear();
				uccFechaDesdePorProducto.DataBindings.Clear();
				uccFechaHastaPorJerarquia.DataBindings.Clear();
				uccFechaHastaPorProducto.DataBindings.Clear();
				rbUltimaCompraPorProducto.DataBindings.Clear();
				rbUltimaCompraProveedorPorProducto.DataBindings.Clear();
				rbPrecioDeListaProveedorPorProducto.DataBindings.Clear();
				rbUltimaCompraPorJerarquia.DataBindings.Clear();
				rbUltimaCompraProveedorPorJerarquia.DataBindings.Clear();
				rbPrecioDeListaProveedorPorJerarquia.DataBindings.Clear();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockNDias));
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton5 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton6 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton7 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton8 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbConsultar = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.HojaBuscadorPorProducto = new System.Windows.Forms.TabPage();
            this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPrecioDeListaProveedorPorProducto = new System.Windows.Forms.RadioButton();
            this.rbUltimaCompraProveedorPorProducto = new System.Windows.Forms.RadioButton();
            this.rbUltimaCompraPorProducto = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uneDiasPorProducto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.uccFechaHastaPorProducto = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.uccFechaDesdePorProducto = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HojaBuscadorPorJerarquia = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mzCmbProveedorPorJerarquia = new mz.erp.ui.controls.mzProveedoresControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbPrecioDeListaProveedorPorJerarquia = new System.Windows.Forms.RadioButton();
            this.rbUltimaCompraProveedorPorJerarquia = new System.Windows.Forms.RadioButton();
            this.rbUltimaCompraPorJerarquia = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grupoAperturaCierre = new System.Windows.Forms.GroupBox();
            this.uneDiasPorJerarquia = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.uccFechaHastaPorJerarquia = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.uccFechaDesdePorJerarquia = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            /* Silvina 20101214 - Tarea 954 */
            this.panel2 = new System.Windows.Forms.Panel();
            /* Fin Silvina */
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.tabControl2.SuspendLayout();
            this.HojaBuscadorPorProducto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasPorProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHastaPorProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesdePorProducto)).BeginInit();
            this.HojaBuscadorPorJerarquia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grupoAperturaCierre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasPorJerarquia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHastaPorJerarquia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesdePorJerarquia)).BeginInit();
            /* Silvina 20101214 - Tarea 954 */
            this.panel2.SuspendLayout();
            /* Fin Silvina */
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            this.SuspendLayout();
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
            this.tbbConsultar,
            this.tbbSeparator3,
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(952, 28);
            this.toolBarStandar.TabIndex = 20;
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
            // tbbConsultar
            // 
            this.tbbConsultar.ImageIndex = 5;
            this.tbbConsultar.Name = "tbbConsultar";
            this.tbbConsultar.Text = "Ejecutar Consulta";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.HojaBuscadorPorProducto);
            this.tabControl2.Controls.Add(this.HojaBuscadorPorJerarquia);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 28);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(952, 212);
            this.tabControl2.TabIndex = 0;
            // 
            // HojaBuscadorPorProducto
            // 
            this.HojaBuscadorPorProducto.Controls.Add(this.mzProductosControl1);
            this.HojaBuscadorPorProducto.Controls.Add(this.mzCmb);
            this.HojaBuscadorPorProducto.Controls.Add(this.groupBox2);
            this.HojaBuscadorPorProducto.Controls.Add(this.label9);
            this.HojaBuscadorPorProducto.Controls.Add(this.groupBox1);
            this.HojaBuscadorPorProducto.Controls.Add(this.label8);
            this.HojaBuscadorPorProducto.Location = new System.Drawing.Point(4, 22);
            this.HojaBuscadorPorProducto.Name = "HojaBuscadorPorProducto";
            this.HojaBuscadorPorProducto.Size = new System.Drawing.Size(944, 186);
            this.HojaBuscadorPorProducto.TabIndex = 0;
            this.HojaBuscadorPorProducto.Text = "Por Producto";
            // 
            // mzProductosControl1
            // 
            this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl1.EnabledCantidad = true;
            this.mzProductosControl1.EnabledListaDePrecio = true;
            this.mzProductosControl1.Location = new System.Drawing.Point(86, 3);
            this.mzProductosControl1.Name = "mzProductosControl1";
            this.mzProductosControl1.Size = new System.Drawing.Size(408, 51);
            this.mzProductosControl1.TabIndex = 0;
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
            this.mzCmb.Location = new System.Drawing.Point(100, 156);
            this.mzCmb.Name = "mzCmb";
            this.mzCmb.SearchObjectListener = null;
            this.mzCmb.Size = new System.Drawing.Size(490, 22);
            this.mzCmb.TabIndex = 7;
            this.mzCmb.Tag = "ResponsableEmision";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbPrecioDeListaProveedorPorProducto);
            this.groupBox2.Controls.Add(this.rbUltimaCompraProveedorPorProducto);
            this.groupBox2.Controls.Add(this.rbUltimaCompraPorProducto);
            this.groupBox2.Location = new System.Drawing.Point(256, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precio";
            // 
            // rbPrecioDeListaProveedorPorProducto
            // 
            this.rbPrecioDeListaProveedorPorProducto.Location = new System.Drawing.Point(8, 61);
            this.rbPrecioDeListaProveedorPorProducto.Name = "rbPrecioDeListaProveedorPorProducto";
            this.rbPrecioDeListaProveedorPorProducto.Size = new System.Drawing.Size(160, 24);
            this.rbPrecioDeListaProveedorPorProducto.TabIndex = 6;
            this.rbPrecioDeListaProveedorPorProducto.Text = "Precio de Lista Proveedor";
            // 
            // rbUltimaCompraProveedorPorProducto
            // 
            this.rbUltimaCompraProveedorPorProducto.Location = new System.Drawing.Point(8, 37);
            this.rbUltimaCompraProveedorPorProducto.Name = "rbUltimaCompraProveedorPorProducto";
            this.rbUltimaCompraProveedorPorProducto.Size = new System.Drawing.Size(160, 24);
            this.rbUltimaCompraProveedorPorProducto.TabIndex = 5;
            this.rbUltimaCompraProveedorPorProducto.Text = "Última Compra Proveedor";
            // 
            // rbUltimaCompraPorProducto
            // 
            this.rbUltimaCompraPorProducto.Location = new System.Drawing.Point(8, 13);
            this.rbUltimaCompraPorProducto.Name = "rbUltimaCompraPorProducto";
            this.rbUltimaCompraPorProducto.Size = new System.Drawing.Size(104, 24);
            this.rbUltimaCompraPorProducto.TabIndex = 4;
            this.rbUltimaCompraPorProducto.Text = "Última Compra";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(26, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Producto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.uneDiasPorProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uccFechaHastaPorProducto);
            this.groupBox1.Controls.Add(this.uccFechaDesdePorProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(23, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas";
            // 
            // uneDiasPorProducto
            // 
            this.uneDiasPorProducto.Location = new System.Drawing.Point(85, 11);
            this.uneDiasPorProducto.MaskInput = "nnn";
            this.uneDiasPorProducto.MaxValue = 365;
            this.uneDiasPorProducto.MinValue = 1;
            this.uneDiasPorProducto.Name = "uneDiasPorProducto";
            this.uneDiasPorProducto.PromptChar = ' ';
            this.uneDiasPorProducto.Size = new System.Drawing.Size(96, 21);
            this.uneDiasPorProducto.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dias";
            // 
            // uccFechaHastaPorProducto
            // 
            this.uccFechaHastaPorProducto.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaHastaPorProducto.DateButtons.Add(dateButton5);
            this.uccFechaHastaPorProducto.Location = new System.Drawing.Point(85, 59);
            this.uccFechaHastaPorProducto.Name = "uccFechaHastaPorProducto";
            this.uccFechaHastaPorProducto.NonAutoSizeHeight = 23;
            this.uccFechaHastaPorProducto.Size = new System.Drawing.Size(96, 21);
            this.uccFechaHastaPorProducto.TabIndex = 3;
            this.uccFechaHastaPorProducto.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // uccFechaDesdePorProducto
            // 
            this.uccFechaDesdePorProducto.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaDesdePorProducto.DateButtons.Add(dateButton6);
            this.uccFechaDesdePorProducto.Location = new System.Drawing.Point(85, 35);
            this.uccFechaDesdePorProducto.Name = "uccFechaDesdePorProducto";
            this.uccFechaDesdePorProducto.NonAutoSizeHeight = 23;
            this.uccFechaDesdePorProducto.Size = new System.Drawing.Size(96, 21);
            this.uccFechaDesdePorProducto.TabIndex = 2;
            this.uccFechaDesdePorProducto.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha Fin";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha Inicio";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(24, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Proveedor";
            // 
            // HojaBuscadorPorJerarquia
            // 
            this.HojaBuscadorPorJerarquia.Controls.Add(this.panel1);
            this.HojaBuscadorPorJerarquia.Controls.Add(this.hierarchicalSearchControl1);
            this.HojaBuscadorPorJerarquia.Location = new System.Drawing.Point(4, 22);
            this.HojaBuscadorPorJerarquia.Name = "HojaBuscadorPorJerarquia";
            this.HojaBuscadorPorJerarquia.Size = new System.Drawing.Size(944, 186);
            this.HojaBuscadorPorJerarquia.TabIndex = 1;
            this.HojaBuscadorPorJerarquia.Text = "Por Jerarquia";
            this.HojaBuscadorPorJerarquia.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mzCmbProveedorPorJerarquia);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grupoAperturaCierre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 98);
            this.panel1.TabIndex = 44;
            // 
            // mzCmbProveedorPorJerarquia
            // 
            this.mzCmbProveedorPorJerarquia.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbProveedorPorJerarquia.DataValue = "";
            this.mzCmbProveedorPorJerarquia.EnableCtaCte = false;
            this.mzCmbProveedorPorJerarquia.FastSearch = false;
            this.mzCmbProveedorPorJerarquia.Location = new System.Drawing.Point(464, 16);
            this.mzCmbProveedorPorJerarquia.Name = "mzCmbProveedorPorJerarquia";
            this.mzCmbProveedorPorJerarquia.SearchObjectListener = null;
            this.mzCmbProveedorPorJerarquia.Size = new System.Drawing.Size(456, 22);
            this.mzCmbProveedorPorJerarquia.TabIndex = 133;
            this.mzCmbProveedorPorJerarquia.Tag = "ResponsableEmision";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.rbPrecioDeListaProveedorPorJerarquia);
            this.groupBox3.Controls.Add(this.rbUltimaCompraProveedorPorJerarquia);
            this.groupBox3.Controls.Add(this.rbUltimaCompraPorJerarquia);
            this.groupBox3.Location = new System.Drawing.Point(224, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 88);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            // 
            // rbPrecioDeListaProveedorPorJerarquia
            // 
            this.rbPrecioDeListaProveedorPorJerarquia.Location = new System.Drawing.Point(8, 64);
            this.rbPrecioDeListaProveedorPorJerarquia.Name = "rbPrecioDeListaProveedorPorJerarquia";
            this.rbPrecioDeListaProveedorPorJerarquia.Size = new System.Drawing.Size(160, 24);
            this.rbPrecioDeListaProveedorPorJerarquia.TabIndex = 50;
            this.rbPrecioDeListaProveedorPorJerarquia.Text = "Precio de Lista Proveedor";
            // 
            // rbUltimaCompraProveedorPorJerarquia
            // 
            this.rbUltimaCompraProveedorPorJerarquia.Location = new System.Drawing.Point(8, 40);
            this.rbUltimaCompraProveedorPorJerarquia.Name = "rbUltimaCompraProveedorPorJerarquia";
            this.rbUltimaCompraProveedorPorJerarquia.Size = new System.Drawing.Size(160, 24);
            this.rbUltimaCompraProveedorPorJerarquia.TabIndex = 49;
            this.rbUltimaCompraProveedorPorJerarquia.Text = "Última Compra Proveedor";
            // 
            // rbUltimaCompraPorJerarquia
            // 
            this.rbUltimaCompraPorJerarquia.Location = new System.Drawing.Point(8, 16);
            this.rbUltimaCompraPorJerarquia.Name = "rbUltimaCompraPorJerarquia";
            this.rbUltimaCompraPorJerarquia.Size = new System.Drawing.Size(104, 24);
            this.rbUltimaCompraPorJerarquia.TabIndex = 48;
            this.rbUltimaCompraPorJerarquia.Text = "Última Compra";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(400, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Proveedor";
            // 
            // grupoAperturaCierre
            // 
            this.grupoAperturaCierre.BackColor = System.Drawing.Color.Transparent;
            this.grupoAperturaCierre.Controls.Add(this.uneDiasPorJerarquia);
            this.grupoAperturaCierre.Controls.Add(this.label1);
            this.grupoAperturaCierre.Controls.Add(this.uccFechaHastaPorJerarquia);
            this.grupoAperturaCierre.Controls.Add(this.uccFechaDesdePorJerarquia);
            this.grupoAperturaCierre.Controls.Add(this.label5);
            this.grupoAperturaCierre.Controls.Add(this.label4);
            this.grupoAperturaCierre.Location = new System.Drawing.Point(0, 1);
            this.grupoAperturaCierre.Name = "grupoAperturaCierre";
            this.grupoAperturaCierre.Size = new System.Drawing.Size(211, 88);
            this.grupoAperturaCierre.TabIndex = 12;
            this.grupoAperturaCierre.TabStop = false;
            this.grupoAperturaCierre.Text = "Fechas";
            // 
            // uneDiasPorJerarquia
            // 
            this.uneDiasPorJerarquia.Location = new System.Drawing.Point(104, 19);
            this.uneDiasPorJerarquia.MaskInput = "nnn";
            this.uneDiasPorJerarquia.MaxValue = 365;
            this.uneDiasPorJerarquia.MinValue = 1;
            this.uneDiasPorJerarquia.Name = "uneDiasPorJerarquia";
            this.uneDiasPorJerarquia.PromptChar = ' ';
            this.uneDiasPorJerarquia.Size = new System.Drawing.Size(96, 21);
            this.uneDiasPorJerarquia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dias";
            // 
            // uccFechaHastaPorJerarquia
            // 
            this.uccFechaHastaPorJerarquia.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaHastaPorJerarquia.DateButtons.Add(dateButton7);
            this.uccFechaHastaPorJerarquia.Location = new System.Drawing.Point(104, 62);
            this.uccFechaHastaPorJerarquia.Name = "uccFechaHastaPorJerarquia";
            this.uccFechaHastaPorJerarquia.NonAutoSizeHeight = 23;
            this.uccFechaHastaPorJerarquia.Size = new System.Drawing.Size(96, 21);
            this.uccFechaHastaPorJerarquia.TabIndex = 4;
            this.uccFechaHastaPorJerarquia.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // uccFechaDesdePorJerarquia
            // 
            this.uccFechaDesdePorJerarquia.BackColor = System.Drawing.SystemColors.Window;
            this.uccFechaDesdePorJerarquia.DateButtons.Add(dateButton8);
            this.uccFechaDesdePorJerarquia.Location = new System.Drawing.Point(104, 40);
            this.uccFechaDesdePorJerarquia.Name = "uccFechaDesdePorJerarquia";
            this.uccFechaDesdePorJerarquia.NonAutoSizeHeight = 23;
            this.uccFechaDesdePorJerarquia.Size = new System.Drawing.Size(96, 21);
            this.uccFechaDesdePorJerarquia.TabIndex = 3;
            this.uccFechaDesdePorJerarquia.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Fin";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Inicio";
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 0);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(944, 88);
            this.hierarchicalSearchControl1.TabIndex = 46;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 240);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(952, 24);
            this.gridManagerView1.TabIndex = 8;
            /* Silvina 20101214 - Tarea 954 */
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridEX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 262);
            this.panel2.TabIndex = 21;
            // 
            // gridEX1
            // 
            this.gridEX1.AllowDrop = true;
            this.gridEX1.AutoEdit = true;
            this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEX1.Location = new System.Drawing.Point(0, 0);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(952, 262);
            this.gridEX1.TabIndex = 10;
            /* Fin Silvina */
            // 
            // FrmStockNDias
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(952, 526);
            /* Silvina 20101214 - Tarea 954 */
            this.Controls.Add(this.panel2);
            /* Fin Silvina */
            this.Controls.Add(this.gridManagerView1);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmStockNDias";
            this.Text = "Stock N-Dias";
            this.tabControl2.ResumeLayout(false);
            this.HojaBuscadorPorProducto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasPorProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHastaPorProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesdePorProducto)).EndInit();
            this.HojaBuscadorPorJerarquia.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grupoAperturaCierre.ResumeLayout(false);
            this.grupoAperturaCierre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasPorJerarquia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaHastaPorJerarquia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaDesdePorJerarquia)).EndInit();
            /* Silvina 20101214 - Tarea 954 */
            this.panel2.ResumeLayout(false);
            /* Fin Silvina */
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void treeAgrupamientos_AfterSelect(object sender, Infragistics.Win.UltraWinTree.SelectEventArgs e)
		{
		
		}
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
			gridEX1.UpdateData();
			DumpControls();
			_uiController.Execute();
		}

		//Matias 20100602 - Tarea 2
		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					mz.erp.ui.utility.Util.MoveFocus(panel1);
					DumpControls();					
					_uiController.RefreshData();
					break;
			}
		}
		//Fin Matias 20100602 - Tarea 2


		#endregion
		
		#region Metodos Privados

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();					
		}

		private void ConfigureInterface()
		{	
			// matias
			mzProductosControl1.SetUIForSearch();
			// --
			
			//gridEX1.LayoutData = _uiController.LayoutFiltroResultado;
			//CallGridManager();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridEX1, this.Text);
			mzCmb.Enabled = true;
			mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mzCmbProveedorPorJerarquia.Enabled = true;
			mzCmbProveedorPorJerarquia.Init();
			mzCmbProveedorPorJerarquia.SearchObjectListener = this;
			mzCmbProveedorPorJerarquia.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;

			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS",_uiController.AllowMultipleSelect);						
			mzProductosControl1.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");

		}

		/*private void CallGridManager()
		{
			string proceso = _uiController.GetProcessManager().GetProcessName();
			string tarea = _uiController.GetTaskName();
			controllers.GridVariablesLoader loader = new controllers.GridVariablesLoader(proceso, tarea);
			GridManagerJanus manager = new GridManagerJanus(gridEX1);
			manager.ConfigureGrid(proceso, tarea, loader);
			//ConfigureGrid();
			gridManagerView1.Init(manager, proceso, tarea, loader);	
			gridManagerView1.EnableMarkControl(loader.AllowMarkRow);
			gridManagerView1.ConfigureMarkControl("Imprimir");
			gridManagerView1.EnableColumnsControl(loader.AllowDefineVisibleColumns);
			gridManagerView1.ConfigureColumnsControl(string.Empty);
			gridManagerView1.EnableExportExcelControl(true);
			gridManagerView1.ConfigureExportExcelControl(string.Empty);
		}**/
		




		private void ConfigureGrid()
		{
			if(_uiController.AllowEdit)
				gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			else
				gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;

			gridEX1.AutomaticSort = false;
			gridEX1.GroupByBoxVisible = _uiController.AllowGroups;
			this.gridEX1.RootTable.Groups.Clear();
			ArrayList lista = _uiController.Groups;
			foreach(string str in lista)
			{
				if(!str.Equals(string.Empty))
				{
					this.gridEX1.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridEX1.RootTable.Columns[str]));
				}
			}
			lista = _uiController.FieldsGroupTotal;
			foreach(string str in lista)
			{
				if(!str.Equals(string.Empty))
				{
					this.gridEX1.RootTable.Columns[str].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
				}
			}
			this.gridEX1.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
			this.gridEX1.CollapseGroups();
			if(_uiController.AllowTotalRow)
			{
				this.gridEX1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
				
			}
			if (_uiController.AllowFilters)
				this.gridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			else 
				this.gridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.None;
			gridEX1.AutomaticSort = true;
		

		}
		

		private void InitializeData()
		{
			gridEX1.SetDataBinding(null, null);
			gridEX1.SetDataBinding(_uiController.DataTableResult, null);		
			hierarchicalSearchControl1.SetSelectionKey(_uiController.Jerarquias);
			mzCmb.DataValue = _uiController.CodigoProveedor;
			mzCmbProveedorPorJerarquia.DataValue = _uiController.CodigoProveedor;

		}

		private void InitEventHandlers()
		{
			//Matias 20100602 - Tarea 2
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			//Fin Matias 20100602 - Tarea 2			
			_uiController.DataDetailHierarchyChanged+= new System.EventHandler( this.OnDetailHierarchyListener );
			uneDiasPorJerarquia.Enter +=new EventHandler(uneDiasPorJerarquia_Enter);
			uneDiasPorProducto.Enter +=new EventHandler(uneDiasPorProducto_Enter);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.ObjectHasChanged +=new EventHandler(Refresh);
			tabControl2.SelectedIndexChanged +=new EventHandler(tabControl2_SelectedIndexChanged);
			this.Load +=new EventHandler(FrmStockNDias_Load);
			this.hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);
			rbUltimaCompraPorProducto.CheckedChanged +=new EventHandler(rbUltimaCompraPorProducto_CheckedChanged);
			rbUltimaCompraProveedorPorProducto.CheckedChanged +=new EventHandler(rbUltimaCompraProveedorPorProducto_CheckedChanged);
			rbPrecioDeListaProveedorPorProducto.CheckedChanged += new EventHandler(rbPrecioDeListaProveedorPorProducto_CheckedChanged);
			rbUltimaCompraPorJerarquia.CheckedChanged += new EventHandler(rbUltimaCompraPorJerarquia_CheckedChanged);
			rbUltimaCompraProveedorPorJerarquia.CheckedChanged += new EventHandler(rbUltimaCompraProveedorPorJerarquia_CheckedChanged);
			rbPrecioDeListaProveedorPorJerarquia.CheckedChanged +=new EventHandler(rbPrecioDeListaProveedorPorJerarquia_CheckedChanged);
			mzCmb.ValueChanged+=new EventHandler(mzCmb_ValueChanged);
			mzCmbProveedorPorJerarquia.ValueChanged+=new EventHandler(mzCmbProveedorPorJerarquia_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000050 20110310
            this.uccFechaDesdePorProducto.ValueChanged += new EventHandler(FechaDesde_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110725
            this.uccFechaHastaPorProducto.ValueChanged += new EventHandler(uccFechaHastaPorProducto_ValueChanged);
            //Fin cristian
        }

        //Cristian Tarea 0000146 20110725
        void uccFechaHastaPorProducto_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaHastaPorProducto.Value)), true);
            this.uccFechaDesdePorProducto.Value = _uiController.FechaDesde;
        }
        //Fin Cristian
        //Cristian Tarea 0000050 20110310
        void FechaDesde_ValueChanged(object sender, EventArgs e)
        {
            _uiController.updateFechas((Convert.ToDateTime(uccFechaDesdePorProducto.Value)),false);
            this.uccFechaHastaPorProducto.Value = _uiController.FechaHasta;

        }
        //Fin Cristian
		private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
		{			
			_uiController.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
			_uiController.IdJerarquia1 = hierarchicalSearchControl1.ItemsJerarquia1;
			_uiController.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
			_uiController.IdJerarquia2 = hierarchicalSearchControl1.ItemsJerarquia2;
			_uiController.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
			_uiController.IdJerarquia3 = hierarchicalSearchControl1.ItemsJerarquia3;
			_uiController.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
			_uiController.IdJerarquia4 = hierarchicalSearchControl1.ItemsJerarquia4;
			_uiController.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
			_uiController.IdJerarquia5 = hierarchicalSearchControl1.ItemsJerarquia5;
			_uiController.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
			_uiController.IdJerarquia6 = hierarchicalSearchControl1.ItemsJerarquia6;
			_uiController.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
			_uiController.IdJerarquia7 = hierarchicalSearchControl1.ItemsJerarquia7;
			_uiController.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
			_uiController.IdJerarquia8 = hierarchicalSearchControl1.ItemsJerarquia8;
			
		}



		private void OnDetailHierarchyListener( object sender, System.EventArgs e )
		{
			
		}

		private void InitDataBindings()
		{
			//mzCEProductos.DataBindings.Add("DataValue", _uiController, "Codigo");
			// matias
			mzProductosControl1.AddObjectListener( (IObserver)_uiController );
			// ----
			//mzCmb.DataBindings.Add("DataValue", _uiController, "CodigoProveedor");
			//mzCmbProveedorPorJerarquia.DataBindings.Add("DataValue", _uiController, "CodigoProveedor");
			uneDiasPorJerarquia.DataBindings.Add("Value", _uiController, "Dias");
			uneDiasPorProducto.DataBindings.Add("Value", _uiController, "Dias");
			uccFechaDesdePorJerarquia.DataBindings.Add("Value", _uiController, "FechaDesde");
			uccFechaDesdePorProducto.DataBindings.Add("Value", _uiController, "FechaDesde");
			uccFechaHastaPorJerarquia.DataBindings.Add("Value", _uiController, "FechaHasta");
			uccFechaHastaPorProducto.DataBindings.Add("Value", _uiController, "FechaHasta");
			rbUltimaCompraPorProducto.DataBindings.Add("Checked", _uiController, "PrecioUltimaCompra");		
			rbUltimaCompraProveedorPorProducto.DataBindings.Add("Checked", _uiController, "PrecioUltimaCompraProveedor");		
			rbPrecioDeListaProveedorPorProducto.DataBindings.Add("Checked", _uiController, "PrecioDeListaProveedor");		
			rbUltimaCompraPorJerarquia.DataBindings.Add("Checked", _uiController, "PrecioUltimaCompra");		
			rbUltimaCompraProveedorPorJerarquia.DataBindings.Add("Checked", _uiController, "PrecioUltimaCompraProveedor");		
			rbPrecioDeListaProveedorPorJerarquia.DataBindings.Add("Checked", _uiController, "PrecioDeListaProveedor");		
		}

		#endregion
		
		
		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
		}

		#endregion

		
		private void uneDiasPorJerarquia_Enter(object sender, EventArgs e)
		{
			uneDiasPorJerarquia.SelectAll();
		}

		private void uneDiasPorProducto_Enter(object sender, EventArgs e)
		{
			uneDiasPorProducto.SelectAll();
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:									
					gridEX1.UpdateData();
					DumpControls();
					_uiController.Execute();
					break;

				case 4:
					mz.erp.ui.utility.Util.MoveFocus(panel1);
					DumpControls();					
					_uiController.RefreshData();
					break;
				case 6:
					CloseForm();
					break;
			}		
		}

		private void DumpControls()
		{
			_uiController.CodigoProveedor = Convert.ToString(mzCmb.DataValue);
		}

		private void Refresh(object sender, EventArgs e)
		{
			gridEX1.SetDataBinding(null, null);
			gridEX1.SetDataBinding(_uiController.DataTableResult, null);
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.DataTableResult);			
		}

		private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl2.SelectedTab.Name.Equals("HojaBuscadorPorJerarquia"))
					_uiController.ByHierarchy=true;
			else _uiController.ByHierarchy=false;

		}

		private void FrmStockNDias_Load(object sender, EventArgs e)
		{
			this.tabControl2.SelectedIndex = 1;
		}

		private void rbUltimaCompraPorProducto_CheckedChanged( object sender, System.EventArgs e )
		{
			_uiController.PrecioUltimaCompra = rbUltimaCompraPorProducto.Checked;
			
		}
		private void rbUltimaCompraProveedorPorProducto_CheckedChanged( object sender, System.EventArgs e )
		{
			_uiController.PrecioUltimaCompraProveedor = rbUltimaCompraProveedorPorProducto.Checked;
			
		}
		private void rbPrecioDeListaProveedorPorProducto_CheckedChanged( object sender, System.EventArgs e )
		{
			_uiController.PrecioDeListaProveedor = rbPrecioDeListaProveedorPorProducto.Checked;
			
		}
		private void rbUltimaCompraPorJerarquia_CheckedChanged( object sender, System.EventArgs e )
		{
			_uiController.PrecioUltimaCompra = rbUltimaCompraPorJerarquia.Checked;
			
		}
		private void rbUltimaCompraProveedorPorJerarquia_CheckedChanged( object sender, System.EventArgs e )
		{
			_uiController.PrecioUltimaCompraProveedor = rbUltimaCompraProveedorPorJerarquia.Checked;
			
		}
		private void rbPrecioDeListaProveedorPorJerarquia_CheckedChanged( object sender, System.EventArgs e )
		{
			_uiController.PrecioDeListaProveedor = rbPrecioDeListaProveedorPorJerarquia.Checked;
			
		}

		private void mzCmb_ValueChanged( object sender, System.EventArgs e )
		{
			_uiController.CodigoProveedor = (string)mzCmb.DataValue;
			if(!((string)mzCmb.DataValue).Equals((string)mzCmbProveedorPorJerarquia.DataValue))
			{
				mzCmbProveedorPorJerarquia.DataValue = _uiController.CodigoProveedor;
			}
			
		}

		private void mzCmbProveedorPorJerarquia_ValueChanged( object sender, System.EventArgs e )
		{
			_uiController.CodigoProveedor = (string)mzCmbProveedorPorJerarquia.DataValue;
			if(!((string)mzCmb.DataValue).Equals((string)mzCmbProveedorPorJerarquia.DataValue))
			{
				mzCmb.DataValue = _uiController.CodigoProveedor;
			}
			
		}

	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui;
using Infragistics.Win.UltraWinExplorerBar;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultaMovimientosStock.
	/// </summary>
	public class FrmConsultaMovimientosStock : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private System.ComponentModel.IContainer components;
		private bool _expandir = true;
		private string _key = String.Empty;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbPorProducto;
		private System.Windows.Forms.RadioButton rbbPorFecha;
		private Infragistics.Win.UltraWinTree.UltraTree treeJerarquia2;
		private System.Windows.Forms.GroupBox groupBox2;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteHasta;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteDesde;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkPorFechas;
		private System.Windows.Forms.CheckBox chkPorLineas;
		private System.Windows.Forms.CheckBox chkPorMarcas;
		private System.Windows.Forms.RadioButton rbbPersonalizado;
		private Infragistics.Win.UltraWinTree.UltraTree treeJerarquia1;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator1;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbEjecutarConsulta;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBarButton toolReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton tbbSeparador3;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;		
		private string _descripcion = String.Empty;

		
		#region Constructores

		public FrmConsultaMovimientosStock(ConsultaMovimientosStockController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
		}
		
		
		

		#endregion


		#region Variables privadas
		
			private ConsultaMovimientosStockController _uiController;

		#endregion


	
		
		

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
			//BindingController.Clear( mzCmbProductos,"DataValue", _uiController, "Codigo");
			//udteDesde.DataBindings.Clear();
			//udteHasta.DataBindings.Clear();
			BindingController.Clear(udteDesde,"Value", _uiController, "FechaDesde");
			BindingController.Clear(udteHasta,"Value", _uiController, "FechaHasta");
			BindingController.Clear(chkPorLineas ,"Checked", _uiController, "ByJerarquia1");
			BindingController.Clear(chkPorMarcas, "Checked", _uiController, "ByJerarquia2");
			BindingController.Clear(chkPorFechas, "Checked", _uiController, "ByFechas");
			}
			base.Dispose( disposing );
		}

		
		protected void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
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
					_uiController.RefreshData();
					break;
				case 6:
					ResetFilters();
					break;
				case 8:
					CloseForm();
					break;
			}		
		}

		private void ResetFilters()
		{
            //mzCmbProductos.DataValue=string.Empty;
            chkPorLineas.Checked=false;
			chkPorMarcas.Checked=false;
			chkPorFechas.Checked=false;
			rbPorProducto.Checked=true;
			mzProductosControl.ClearControl();

			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode2 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override2 = new Infragistics.Win.UltraWinTree.Override();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaMovimientosStock));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
			this.chkPorLineas = new System.Windows.Forms.CheckBox();
			this.chkPorMarcas = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.udteHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.udteDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.chkPorFechas = new System.Windows.Forms.CheckBox();
			this.treeJerarquia2 = new Infragistics.Win.UltraWinTree.UltraTree();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbbPersonalizado = new System.Windows.Forms.RadioButton();
			this.rbbPorFecha = new System.Windows.Forms.RadioButton();
			this.rbPorProducto = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.treeJerarquia1 = new Infragistics.Win.UltraWinTree.UltraTree();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparador3 = new System.Windows.Forms.ToolBarButton();
			this.tbbEjecutarConsulta = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.toolReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udteDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.treeJerarquia2)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeJerarquia1)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(902, 31);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(902, 23);
			this.labelTarea.TabIndex = 2;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzProductosControl);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkPorLineas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkPorMarcas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.treeJerarquia2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.treeJerarquia1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 139);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(902, 205);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// mzProductosControl
			// 
			this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
			this.mzProductosControl.EnabledCantidad = true;
			this.mzProductosControl.EnabledListaDePrecio = true;
			this.mzProductosControl.Location = new System.Drawing.Point(96, 0);
			this.mzProductosControl.Name = "mzProductosControl";
			this.mzProductosControl.Size = new System.Drawing.Size(408, 40);
			this.mzProductosControl.TabIndex = 0;
			this.mzProductosControl.VisibleCantidad = true;
			this.mzProductosControl.VisibleComboListaDePrecios = true;
			this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
			this.mzProductosControl.VisiblePrecios = true;
			// 
			// chkPorLineas
			// 
			this.chkPorLineas.BackColor = System.Drawing.Color.Transparent;
			this.chkPorLineas.Location = new System.Drawing.Point(104, 48);
			this.chkPorLineas.Name = "chkPorLineas";
			this.chkPorLineas.Size = new System.Drawing.Size(224, 16);
			this.chkPorLineas.TabIndex = 1;
			this.chkPorLineas.Text = "Por Lineas";
			// 
			// chkPorMarcas
			// 
			this.chkPorMarcas.BackColor = System.Drawing.Color.Transparent;
			this.chkPorMarcas.Location = new System.Drawing.Point(347, 48);
			this.chkPorMarcas.Name = "chkPorMarcas";
			this.chkPorMarcas.Size = new System.Drawing.Size(248, 16);
			this.chkPorMarcas.TabIndex = 3;
			this.chkPorMarcas.Text = "Por Marcas";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.udteHasta);
			this.groupBox2.Controls.Add(this.udteDesde);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.chkPorFechas);
			this.groupBox2.Location = new System.Drawing.Point(600, 48);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(208, 80);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Por Fechas";
			// 
			// udteHasta
			// 
			this.udteHasta.Location = new System.Drawing.Point(108, 44);
			this.udteHasta.Name = "udteHasta";
			this.udteHasta.Size = new System.Drawing.Size(88, 21);
			this.udteHasta.TabIndex = 7;
			// 
			// udteDesde
			// 
			this.udteDesde.Location = new System.Drawing.Point(108, 20);
			this.udteDesde.Name = "udteDesde";
			this.udteDesde.Size = new System.Drawing.Size(88, 21);
			this.udteDesde.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(12, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 33;
			this.label4.Text = "Hasta";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(12, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 32;
			this.label3.Text = "Desde";
			// 
			// chkPorFechas
			// 
			this.chkPorFechas.BackColor = System.Drawing.Color.Transparent;
			this.chkPorFechas.Location = new System.Drawing.Point(69, -5);
			this.chkPorFechas.Name = "chkPorFechas";
			this.chkPorFechas.Size = new System.Drawing.Size(24, 24);
			this.chkPorFechas.TabIndex = 5;
			// 
			// treeJerarquia2
			// 
			this.treeJerarquia2.HideSelection = false;
			this.treeJerarquia2.Location = new System.Drawing.Point(344, 64);
			this.treeJerarquia2.Name = "treeJerarquia2";
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Agrupamientos";
			this.treeJerarquia2.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																									 ultraTreeNode1});
			_override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.treeJerarquia2.Override = _override1;
			this.treeJerarquia2.Size = new System.Drawing.Size(248, 143);
			this.treeJerarquia2.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.rbbPersonalizado);
			this.groupBox1.Controls.Add(this.rbbPorFecha);
			this.groupBox1.Controls.Add(this.rbPorProducto);
			this.groupBox1.Location = new System.Drawing.Point(600, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 80);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Agrupado por ";
			// 
			// rbbPersonalizado
			// 
			this.rbbPersonalizado.Location = new System.Drawing.Point(8, 56);
			this.rbbPersonalizado.Name = "rbbPersonalizado";
			this.rbbPersonalizado.Size = new System.Drawing.Size(130, 20);
			this.rbbPersonalizado.TabIndex = 10;
			this.rbbPersonalizado.TabStop = true;
			this.rbbPersonalizado.Text = "Personalizado";
			// 
			// rbbPorFecha
			// 
			this.rbbPorFecha.Location = new System.Drawing.Point(8, 35);
			this.rbbPorFecha.Name = "rbbPorFecha";
			this.rbbPorFecha.Size = new System.Drawing.Size(130, 20);
			this.rbbPorFecha.TabIndex = 9;
			this.rbbPorFecha.TabStop = true;
			this.rbbPorFecha.Text = "Por Fecha";
			// 
			// rbPorProducto
			// 
			this.rbPorProducto.Checked = true;
			this.rbPorProducto.Location = new System.Drawing.Point(8, 14);
			this.rbPorProducto.Name = "rbPorProducto";
			this.rbPorProducto.Size = new System.Drawing.Size(208, 20);
			this.rbPorProducto.TabIndex = 8;
			this.rbPorProducto.TabStop = true;
			this.rbPorProducto.Text = "Por Producto";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Jerarquía";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 25;
			this.label1.Text = "Producto";
			// 
			// treeJerarquia1
			// 
			this.treeJerarquia1.HideSelection = false;
			this.treeJerarquia1.Location = new System.Drawing.Point(104, 64);
			this.treeJerarquia1.Name = "treeJerarquia1";
			ultraTreeNode2.Key = "RAIZ";
			ultraTreeNode2.Text = "Agrupamientos";
			this.treeJerarquia1.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																									 ultraTreeNode2});
			_override2.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.treeJerarquia1.Override = _override2;
			this.treeJerarquia1.Size = new System.Drawing.Size(240, 143);
			this.treeJerarquia1.TabIndex = 2;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 403);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(902, 285);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.AlternatingColors = true;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.FilterRowFormatStyle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridResultado.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
			this.gridResultado.GroupRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.gridResultado.GroupTotalRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
			this.gridResultado.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.Lavender;
			this.gridResultado.GroupTotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridResultado.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 0);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.RecordNavigator = true;
			this.gridResultado.RecordNavigatorText = "Registro:|de";
			this.gridResultado.Size = new System.Drawing.Size(902, 285);
			this.gridResultado.TabIndex = 1;
			this.gridResultado.TableSpacing = 0;
			this.gridResultado.TabStop = false;
			this.gridResultado.ThemedAreas = Janus.Windows.GridEX.ThemedArea.None;
			this.gridResultado.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridResultado_FormattingRow);
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator1,
																							  this.tbbSiguiente,
																							  this.tbbSeparador3,
																							  this.tbbEjecutarConsulta,
																							  this.tbbSeparator2,
																							  this.toolReiniciarFiltros,
																							  this.tbbSeparator4,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(968, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 10;
			this.tbbAnterior.Text = "Anterior";
			// 
			// tbbSeparator1
			// 
			this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 11;
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// tbbSeparador3
			// 
			this.tbbSeparador3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbEjecutarConsulta
			// 
			this.tbbEjecutarConsulta.ImageIndex = 2;
			this.tbbEjecutarConsulta.Text = "Ejecutar Consulta[F5]";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolReiniciarFiltros
			// 
			this.toolReiniciarFiltros.ImageIndex = 5;
			this.toolReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
			// 
			// tbbSeparator4
			// 
			this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 31;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 205;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 285;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultados";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(968, 497);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
			this.ultraExplorerBar1.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
			// 
			// FrmConsultaMovimientosStock
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(968, 525);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultaMovimientosStock";
			this.Text = "Consulta de Movimientos de Stock";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udteDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.treeJerarquia2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeJerarquia1)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void gridResultado_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
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
			if (_uiController.PreguntarAlCancelar())
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
			this.treeJerarquia1.CollapseAll();
			this.treeJerarquia1.Nodes[0].Expanded = true;
			this.treeJerarquia1.Nodes[0].Selected = true;
			this.treeJerarquia1.Nodes[0].Key = _uiController.RaizJerarquia1;
			this.treeJerarquia1.Nodes[0].Text = _uiController.DescripcionRaizJerarquia1;
			_uiController.NodoExpandir( this.treeJerarquia1.Nodes[0] );

			this.treeJerarquia2.CollapseAll();
			this.treeJerarquia2.Nodes[0].Expanded = true;
			this.treeJerarquia2.Nodes[0].Selected = true;
			this.treeJerarquia2.Nodes[0].Key = _uiController.RaizJerarquia2;
			this.treeJerarquia2.Nodes[0].Text = _uiController.DescripcionRaizJerarquia2;
			_uiController.NodoExpandir( this.treeJerarquia2.Nodes[0] );

			//mzCmbProductos.SearchObject= _uiController.SearchProducto;
			//mzCmbProductos.LayoutData = _uiController.LayoutProductos;
			//mzCmbProductos.WidthSearchForm = 800;
			gridResultado.LayoutData = _uiController.LayoutFiltroResultado;
			gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			treeJerarquia1.Enabled = _uiController.ByJerarquia1;
			treeJerarquia2.Enabled = _uiController.ByJerarquia2;
			gridResultado.RecordNavigator = false;
			rbbPersonalizado.Checked = true;
			this.labelTarea.Text = _uiController.LeyendaFormulario();
			udteDesde.Enabled = _uiController.ByFechas;
			udteHasta.Enabled = _uiController.ByFechas;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.KeyPreview = true;

			mzProductosControl.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");
			//mzProductosControl.SetUIForSearch();
		}

		private void InitializeData()
		{				
		}

		private void InitEventHandlers()
		{
			
			treeJerarquia1.AfterExpand +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(treeAgrupamientos_AfterExpand);
			treeJerarquia1.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(treeAgrupamientos_AfterActivate);
			treeJerarquia2.AfterExpand +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(treeAgrupamientos_AfterExpand);
			treeJerarquia2.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(treeAgrupamientos_AfterActivate);
			_uiController.DataDetailHierarchyChanged+= new System.EventHandler( this.OnDetailHierarchyListener );
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.ObjectHasChanged +=new EventHandler(Refresh);
			MouseHelper mouseControler = new MouseHelper();
			mouseControler.Control = ultraExplorerBar1;
			mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
			mouseControler.WheelForward += new MouseEventHandler(ScrollUp);
			rbbPersonalizado.CheckedChanged += new EventHandler(CheckedChanged);
			rbbPorFecha.CheckedChanged += new EventHandler(CheckedChanged);
			rbPorProducto.CheckedChanged += new EventHandler(CheckedChanged);
			
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
			
		}
	
		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this._uiController.RefreshData();
					break;
			}
		}
	



		private void OnDetailHierarchyListener( object sender, System.EventArgs e )
		{
			
		}

		private void InitDataBindings()
		{
			//mzCmbProductos.DataBindings.Add("DataValue", _uiController, "Codigo");
			//BindingController.Bind( mzCmbProductos,"DataValue", _uiController, "Codigo");
			//udteDesde.DataBindings.Add("Value", _uiController, "FechaDesde");
			//udteHasta.DataBindings.Add("Value", _uiController, "FechaHasta");
			BindingController.Bind(udteDesde,"Value", _uiController, "FechaDesde");
			BindingController.Bind(udteHasta,"Value", _uiController, "FechaHasta");
			BindingController.Bind(chkPorLineas ,"Checked", _uiController, "ByJerarquia1");
			BindingController.Bind(chkPorMarcas, "Checked", _uiController, "ByJerarquia2");
			BindingController.Bind(chkPorFechas, "Checked", _uiController, "ByFechas");
			mzProductosControl.AddObjectListener( (IObserver)_uiController );			
		}

		private void Refresh(object sender, EventArgs e)
		{
			treeJerarquia1.Enabled = _uiController.ByJerarquia1;
			treeJerarquia2.Enabled = _uiController.ByJerarquia2;
			udteDesde.Enabled = _uiController.ByFechas;
			udteHasta.Enabled = _uiController.ByFechas;
			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.DataTableResult, null);
			UpdateVisualization();
		}


		private void treeAgrupamientos_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			
			
			_uiController.NodoExpandir( e.TreeNode );
		}

		private void treeAgrupamientos_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			Infragistics.Win.UltraWinTree.UltraTree tree  = (Infragistics.Win.UltraWinTree.UltraTree)sender;
			_uiController.NodoActual(e.TreeNode, tree.Name.Substring(tree.Name.Length-1,1));			
		}

		private void ScrollDown (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);
		}

		private void ScrollUp (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageUp);
		}

		private void UpdateVisualization()
		{
			this.gridResultado.RootTable.Groups.Clear();
			if(rbPorProducto.Checked)
			{
				this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns["Producto"]));
				this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns["Deposito"]));
				this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns["Seccion"]));
				this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns["Estado de Stock"]));
				this.gridResultado.RootTable.Groups[0].Expand();
				gridResultado.RootTable.Columns["Cantidad"].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
				this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
			}
			else
			{
				if(rbbPorFecha.Checked)
				{
					this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns["FechaCreacion"]));
					this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns["Producto"]));
					this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns["Estado de Stock"]));
					this.gridResultado.RootTable.Groups[0].Expand();
					gridResultado.RootTable.Columns["Cantidad"].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
					this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
				}
				else
				{
					/*Personalizado*/
					this.gridResultado.RootTable.Groups.Clear();
					this.gridResultado.GroupByBoxVisible = true;
					this.gridResultado.GroupByBoxInfoText = "Arrastre las Cabeceras de Columna para agrupar por columnas";
					gridResultado.RootTable.Columns["Cantidad"].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
					this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
					

				}
			}
		}


		#endregion

		private void CheckedChanged(object sender, EventArgs e)
		{
			UpdateVisualization();
		}
	}
}

using System;
using Janus.Windows;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using System.Data;
using mz.erp.ui.controls;
using mz.erp.commontypes;
using System.Text;
using mz.erp.ui.controllers;
using mz.erp.ui;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmViewer.
	/// </summary>
	public class FrmConsultaCajaTDCompTesoreria : System.Windows.Forms.Form, ITaskForm	
	{
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Janus.Windows.GridEX.GridEX gridUsuarios;
		private System.ComponentModel.IContainer components;
		private Janus.Windows.GridEX.GridEX gridCajas;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		protected System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.GroupBox grupoAperturaCierre;
		private Infragistics.Win.Misc.UltraButton bTodos;
		private Infragistics.Win.Misc.UltraButton bNinguno;
		private Infragistics.Win.Misc.UltraButton bNingunoCaja;
		private Infragistics.Win.Misc.UltraButton bTodosCaja;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelTarea;
		private mz.erp.ui.controllers.ConsultasCajaController _uiController;
		private Hashtable _mapGroupForegroundColors = new Hashtable();
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private HtmlRichText.HtmlRichTextBox htmlDetalle;
		private Janus.Windows.GridEX.GridEX gridTiposDeComprobante;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.RadioButton radioBUltimaCaja;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private Hashtable _mapGroupBackColors = new Hashtable();
	
		#region constructor, metodos asociados y destructores
	
		public FrmConsultaCajaTDCompTesoreria(mz.erp.ui.controllers.ConsultasCajaController uiController)
		{
			InitializeComponent();

			_uiController = uiController;
					
			gridCajas.LayoutData = _uiController.LayoutFiltroCajas;
			gridTiposDeComprobante.LayoutData = _uiController.LayoutFiltroTipos;
			gridUsuarios.LayoutData = _uiController.LayoutFiltroUsuarios;
			
			ultraExplorerBar1.Groups["Detalles"].Visible = _uiController.DetallesVisibles();

			//mzGridConfigPanel1.GridSource = gridResultado;
			//mzGridConfigPanel1.Initialize(_uiController.GetProcessName(), _uiController.GetTaskName(), _uiController.LayoutFiltroResultado);
			//ConfigureGrilla();
			//CallGridManager();
			string solapa = _uiController.GetFormText();
			if (solapa!= "" && solapa != string.Empty)
				this.Text = _uiController.GetFormText();

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);
			
			InitEvents();
			InitDataBindings();
		
			this.Build_UI();
		}

		private void InitDataBindings()
		{	
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );
			
			gridTiposDeComprobante.DataBindings.Clear();
			gridTiposDeComprobante.SetDataBinding( _uiController.FiltroTDCompTesoreria , null );
			
			gridUsuarios.DataBindings.Clear();
			gridUsuarios.SetDataBinding( _uiController.FiltroUsuarios , null );			
			
			radioBUltimaCaja.DataBindings.Clear();
			radioBUltimaCaja.DataBindings.Add("Checked", _uiController , "CheckUltimaCaja");
		}

		private void Build_UI()
		{
			this.labelTarea.Text = _uiController.LeyendaFormulario();
			ConfigureCabecera();
			LoadMapGroupColors();
			KeyDownManager KeyDown = new KeyDownManager(this);
			KeyPreview = true;
		}

		private void LoadMapGroupColors()
		{
			/*
			_mapGroupForegroundColors.Add(2,Color.DimGray);
			_mapGroupForegroundColors.Add(5,Color.DarkSalmon);
			_mapGroupForegroundColors.Add(0,Color.RoyalBlue);
			_mapGroupForegroundColors.Add(1,Color.Teal);
			_mapGroupForegroundColors.Add(6,Color.DarkKhaki);
			_mapGroupForegroundColors.Add(9,Color.Peru);
			_mapGroupForegroundColors.Add(4,Color.DarkMagenta);
			_mapGroupForegroundColors.Add(7,Color.DarkOrchid);
			_mapGroupForegroundColors.Add(8,Color.DarkSeaGreen);
			_mapGroupForegroundColors.Add(3,Color.DarkSlateBlue);
			_mapGroupForegroundColors.Add(10,Color.MidnightBlue);
			*/
			_mapGroupForegroundColors.Add(0,Color.DarkBlue);
			_mapGroupForegroundColors.Add(1,Color.MediumBlue);
			_mapGroupForegroundColors.Add(2,Color.BlueViolet);
			_mapGroupForegroundColors.Add(3,Color.DarkViolet);
			_mapGroupForegroundColors.Add(4,Color.Purple);


			_mapGroupBackColors.Add(4,Color.LightSteelBlue);
			_mapGroupBackColors.Add(5,Color.AliceBlue);
			_mapGroupBackColors.Add(0,Color.LightSkyBlue);
			_mapGroupBackColors.Add(1,Color.PowderBlue);
			_mapGroupBackColors.Add(2,Color.LightYellow);
			_mapGroupBackColors.Add(3,Color.Beige);
			_mapGroupBackColors.Add(6,Color.CadetBlue);
			_mapGroupBackColors.Add(7,Color.Lavender);
			_mapGroupBackColors.Add(8,Color.DeepSkyBlue);
			_mapGroupBackColors.Add(9,Color.MediumBlue);
			_mapGroupBackColors.Add(10,Color.MidnightBlue);
		}

		private void ConfigureCabecera()
		{
			
		}

		/*private void CallGridManager()
		{			
			string proceso = _uiController.GetProcessManager().GetProcessName();
			string tarea = _uiController.GetTaskName();
			controllers.GridVariablesLoader loader = new controllers.GridVariablesLoader(proceso, tarea);
			GridManagerJanus manager = new GridManagerJanus(gridResultado);
			manager.ConfigureGrid(proceso, tarea, loader);							
			gridManagerView1.Init(manager, proceso, tarea, loader);
			gridManagerView1.EnableMarkControl(loader.AllowMarkRow);
			gridManagerView1.EnableColumnsControl(loader.AllowDefineVisibleColumns);
			gridManagerView1.ConfigureMarkControl(loader.NameMarkRow);
			gridManagerView1.ConfigureColumnsControl(string.Empty);	
			gridManagerView1.EnableExportExcelControl(loader.AllowExportExcel);
			gridManagerView1.ConfigureExportExcelControl(string.Empty);

		
			_allowGroupCollapse = loader.AllowGroupCollapse;
		}*/

		private void ConfigureGrilla()
		{
			//if (!mzGridConfigPanel1.LoadFromFile) 
			{//esta cpnfiguracion depende de la configuracion del usuario 
				//(digamos, si el usuario cargo su configuracion, la configuracion default de grupos no se garga)
				
				//BORRO LOS GRUPOS ANTERIORES
				this.gridResultado.RootTable.Groups.Clear();
				//AGREGO LOS GRUPOS DEL CONTROLLER
				ArrayList lista = _uiController.GetGruposResultado();
				foreach(string str in lista)
				{
					this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns[str]));
				}
			}
			//HABILITO LOS FILTROS DE LA GRILLA 
			if (_uiController.AllowFiltrosGrilla())
				this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			else 
				this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.None;
			//DEJO EDITABLE O NO LOS GRUPOS SEGUN EL CONTROLLER
			this.gridResultado.GroupByBoxVisible= _uiController.GetGruposEditables();
			//CARGO SI TIENE UNA FILA DE SUMA
			if (_uiController.GetFilaTotalGroup() != "")
			{
				this.gridResultado.RootTable.Columns[_uiController.GetFilaTotalGroup()].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
				//usar format string para formatear el tipo de la row total group
				//permito que se vea el resultado de la suma siempre		
				this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;	
			}
			gridResultado.RowExpanded +=new Janus.Windows.GridEX.RowActionEventHandler(gridCajas_RowExpanded);
			Janus.Windows.GridEX.GridEXGroupCollection col = gridResultado.RootTable.Groups;
			
		}
	
		private void InitEvents()
		{
			_uiController.ObjectHasChanged+= new System.EventHandler( this.ListenerControllerChanges );
			gridResultado.FormattingRow +=new Janus.Windows.GridEX.RowLoadEventHandler(gridResultado_FormattingRow);
			if(_uiController.DetallesVisibles())
				gridResultado.SelectionChanged += new EventHandler(gridResultado_SelectionChanged);
			//mzGridConfigPanel1.LayoutChanged +=new EventHandler(RefreshData);
		}
		
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
						
				_uiController.ObjectHasChanged-= new System.EventHandler( this.ListenerControllerChanges );
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);	
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaCajaTDCompTesoreria));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.bNingunoCaja = new Infragistics.Win.Misc.UltraButton();
			this.bTodosCaja = new Infragistics.Win.Misc.UltraButton();
			this.bNinguno = new Infragistics.Win.Misc.UltraButton();
			this.bTodos = new Infragistics.Win.Misc.UltraButton();
			this.grupoAperturaCierre = new System.Windows.Forms.GroupBox();
			this.radioBUltimaCaja = new System.Windows.Forms.RadioButton();
			this.gridCajas = new Janus.Windows.GridEX.GridEX();
			this.gridTiposDeComprobante = new Janus.Windows.GridEX.GridEX();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridUsuarios = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.htmlDetalle = new HtmlRichText.HtmlRichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.grupoAperturaCierre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTiposDeComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, -24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(962, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(962, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bNingunoCaja);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bTodosCaja);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bNinguno);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bTodos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.grupoAperturaCierre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCajas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridTiposDeComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridUsuarios);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -181);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(962, 213);
			this.ultraExplorerBarContainerControl1.TabIndex = 1;
			// 
			// bNingunoCaja
			// 
			this.bNingunoCaja.AcceptsFocus = false;
			this.bNingunoCaja.Location = new System.Drawing.Point(464, 190);
			this.bNingunoCaja.Name = "bNingunoCaja";
			this.bNingunoCaja.Size = new System.Drawing.Size(64, 22);
			this.bNingunoCaja.TabIndex = 5;
			this.bNingunoCaja.TabStop = false;
			this.bNingunoCaja.Text = "&Ninguno";
			this.bNingunoCaja.Click += new System.EventHandler(this.bNingunoCaja_Click);
			// 
			// bTodosCaja
			// 
			this.bTodosCaja.AcceptsFocus = false;
			this.bTodosCaja.Location = new System.Drawing.Point(400, 190);
			this.bTodosCaja.Name = "bTodosCaja";
			this.bTodosCaja.Size = new System.Drawing.Size(64, 22);
			this.bTodosCaja.TabIndex = 4;
			this.bTodosCaja.TabStop = false;
			this.bTodosCaja.Text = "&Todos";
			this.bTodosCaja.Click += new System.EventHandler(this.bTodosCaja_Click);
			// 
			// bNinguno
			// 
			this.bNinguno.AcceptsFocus = false;
			this.bNinguno.Location = new System.Drawing.Point(776, 190);
			this.bNinguno.Name = "bNinguno";
			this.bNinguno.Size = new System.Drawing.Size(64, 22);
			this.bNinguno.TabIndex = 7;
			this.bNinguno.TabStop = false;
			this.bNinguno.Text = "&Ninguno";
			this.bNinguno.Click += new System.EventHandler(this.bNinguno_Click);
			// 
			// bTodos
			// 
			this.bTodos.AcceptsFocus = false;
			this.bTodos.Location = new System.Drawing.Point(712, 190);
			this.bTodos.Name = "bTodos";
			this.bTodos.Size = new System.Drawing.Size(64, 22);
			this.bTodos.TabIndex = 6;
			this.bTodos.TabStop = false;
			this.bTodos.Text = "&Todos";
			this.bTodos.Click += new System.EventHandler(this.bTodos_Click);
			// 
			// grupoAperturaCierre
			// 
			this.grupoAperturaCierre.BackColor = System.Drawing.Color.Transparent;
			this.grupoAperturaCierre.Controls.Add(this.radioBUltimaCaja);
			this.grupoAperturaCierre.Location = new System.Drawing.Point(8, 0);
			this.grupoAperturaCierre.Name = "grupoAperturaCierre";
			this.grupoAperturaCierre.Size = new System.Drawing.Size(904, 40);
			this.grupoAperturaCierre.TabIndex = 0;
			this.grupoAperturaCierre.TabStop = false;
			this.grupoAperturaCierre.Text = "Estado";
			// 
			// radioBUltimaCaja
			// 
			this.radioBUltimaCaja.Checked = true;
			this.radioBUltimaCaja.Location = new System.Drawing.Point(56, 14);
			this.radioBUltimaCaja.Name = "radioBUltimaCaja";
			this.radioBUltimaCaja.Size = new System.Drawing.Size(168, 16);
			this.radioBUltimaCaja.TabIndex = 0;
			this.radioBUltimaCaja.TabStop = true;
			this.radioBUltimaCaja.Text = "Ultima Caja";
			// 
			// gridCajas
			// 
			this.gridCajas.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCajas.GroupByBoxVisible = false;
			this.gridCajas.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCajas.Location = new System.Drawing.Point(312, 62);
			this.gridCajas.Name = "gridCajas";
			this.gridCajas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCajas.Size = new System.Drawing.Size(296, 128);
			this.gridCajas.TabIndex = 2;
			this.gridCajas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// gridTiposDeComprobante
			// 
			this.gridTiposDeComprobante.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridTiposDeComprobante.GroupByBoxVisible = false;
			this.gridTiposDeComprobante.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridTiposDeComprobante.Location = new System.Drawing.Point(616, 62);
			this.gridTiposDeComprobante.Name = "gridTiposDeComprobante";
			this.gridTiposDeComprobante.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridTiposDeComprobante.Size = new System.Drawing.Size(296, 128);
			this.gridTiposDeComprobante.TabIndex = 3;
			this.gridTiposDeComprobante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(616, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tipos de Comprobante";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(312, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cajas";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 14);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuario";
			// 
			// gridUsuarios
			// 
			this.gridUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridUsuarios.GroupByBoxVisible = false;
			this.gridUsuarios.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridUsuarios.Location = new System.Drawing.Point(8, 62);
			this.gridUsuarios.Name = "gridUsuarios";
			this.gridUsuarios.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridUsuarios.Size = new System.Drawing.Size(296, 128);
			this.gridUsuarios.TabIndex = 1;
			this.gridUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 91);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(962, 312);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			this.ultraExplorerBarContainerControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraExplorerBarContainerControl2_Paint);
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(960, 24);
			this.gridManagerView1.TabIndex = 0;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridResultado.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Empty;
			this.gridResultado.HeaderFormatStyle.BackColor = System.Drawing.Color.Transparent;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 32);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.ShowErrors = false;
			this.gridResultado.Size = new System.Drawing.Size(962, 280);
			this.gridResultado.TabIndex = 1;
			this.gridResultado.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)(((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
				| Janus.Windows.GridEX.ThemedArea.Headers) 
				| Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
				| Janus.Windows.GridEX.ThemedArea.ControlBorder)));
			this.gridResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.htmlDetalle);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 462);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(962, 150);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// htmlDetalle
			// 
			this.htmlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmlDetalle.Location = new System.Drawing.Point(0, 0);
			this.htmlDetalle.Name = "htmlDetalle";
			this.htmlDetalle.ReadOnly = true;
			this.htmlDetalle.Size = new System.Drawing.Size(962, 150);
			this.htmlDetalle.TabIndex = 0;
			this.htmlDetalle.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 24);
			this.panel1.TabIndex = 2;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.toolBarButton7,
																							  this.toolBarButton8,
																							  this.toolBarButton9,
																							  this.toolBarButton10,
																							  this.toolBarButton11,
																							  this.toolBarButton12,
																							  this.toolBarButton1,
																							  this.tbbReiniciarFiltros});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(1028, 28);
			this.toolBarStandar.TabIndex = 20;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.Enabled = false;
			this.tbbAnterior.ImageIndex = 10;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 11;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.ImageIndex = 0;
			this.toolBarButton7.Visible = false;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 1;
			this.toolBarButton8.Visible = false;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 2;
			this.toolBarButton9.Visible = false;
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 3;
			this.toolBarButton10.Visible = false;
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 2;
			this.toolBarButton12.Text = "Ejecutar Consulta [F5]";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbReiniciarFiltros
			// 
			this.tbbReiniciarFiltros.ImageIndex = 5;
			this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
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
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 213;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 312;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup4.Key = "Detalles";
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Detalles";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 24);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(1028, 438);
			this.ultraExplorerBar1.TabIndex = 3;
			this.ultraExplorerBar1.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
			this.ultraExplorerBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// FrmConsultaCajaTDCompTesoreria
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 462);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.panel1);
			this.Name = "FrmConsultaCajaTDCompTesoreria";
			this.Text = "Consulta de Caja";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.grupoAperturaCierre.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTiposDeComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		#region custom members
		
		Movimiento _selectedMovimiento = new Movimiento();
		
		
		private void RefreshData(object sender, EventArgs e)
		{
			//ConfigureGrilla();
			gridResultado.SetDataBinding( null , null );
			gridResultado.SetDataBinding( _uiController.Data, "Result" );
			gridResultado.Refetch();
			if (gridManagerView1.AllowExportExcel)
				gridManagerView1.SetTable(_uiController.Data.Tables["Result"]);		
		}
		
		private void RefreshData()
		{			
			//ConfigureGrilla();
			gridResultado.SetDataBinding( null , null );
			gridResultado.SetDataBinding( _uiController.Data, "Result" );
			gridResultado.Refetch();
			if (gridManagerView1.AllowExportExcel)
				gridManagerView1.SetTable(_uiController.Data.Tables["Result"]);			

						
			if (_uiController.Data.Tables.Count > 0)
			{
				if (_uiController.Data.Tables[0].Rows.Count == 0)
				{
					System.Windows.Forms.MessageBox.Show( "No hay datos para los filtros seleccionados", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
				}				
			}
			else
			{
				System.Windows.Forms.MessageBox.Show( "No hay datos para los filtros seleccionados", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
			}
			//cierro todos los + del arbol de resultados (si es q hay grupos)
			//this.gridResultado.CollapseGroups();
			/*if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();*/
			
			
			if (gridManagerView1.AllowGroupCollapse)
				this.gridResultado.CollapseGroups();
			else
				if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();
		}
		private void ListenerControllerChanges( object sender, System.EventArgs e)
		{
			
		}
		#endregion
	
		#region Tildar Filtros
		
		private void bTodos_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarTodosTDCompTesoreria();
			gridTiposDeComprobante.DataBindings.Clear();
			gridTiposDeComprobante.SetDataBinding( _uiController.FiltroTDCompTesoreria , null );
		}

		private void bNinguno_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarNingunoTDCompTesoreria();
			gridTiposDeComprobante.DataBindings.Clear();
			gridTiposDeComprobante.SetDataBinding( _uiController.FiltroTDCompTesoreria , null );
		}

		private void bTodosCaja_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarTodosCaja();
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );
		}

		private void bNingunoCaja_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarNingunoCaja();
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );
		}

		#endregion

		#region Miembros de ITaskForm

		public void ShowForm()
		{
			base.Show();
		}

		public void CloseForm()
		{			
			Close();
		}

		public void KeyDownPrevious()
		{
			Previous();
		}

		public void KeyDownNext()
		{
			Execute();
		}

		public void Execute()
		{
			if (_uiController.ObligaSeleccionItem())
			{
				if (gridResultado.SelectedItems.Count != 0) 
				{
					_uiController.SelectedItem = gridResultado.SelectedItems[0].GetRow().Cells[_uiController.IdentificadorSelectedItem()].Value;
					_uiController.Execute();
						
				}
				else
					System.Console.WriteLine("No se puede continuar debido a que no se seleccionó ningun ítem");
			}
			else
			{
				//_uiController.SelectedItem = gridResultado.SelectedItems[0].GetRow().Cells["idMovimiento"].Value;
				_uiController.Execute();
			}
		}
		public void Previous()
		{
			_uiController.Previous();
		}
		#endregion
		
		
		private void gridResultado_SelectionChanged(object sender, System.EventArgs e)
		{

			if (_uiController.ObligaSeleccionItem())
			{	
				if (this.gridResultado.SelectedItems.Count > 0 )
				{
					VisualizarInfoDetallada();
				}
				
			}
		}


		private void VisualizarInfoDetallada()
		{
			string datos = string.Empty;
			string IdValor = string.Empty;
			if (gridResultado.SelectedItems[0].RowType == Janus.Windows.GridEX.RowType.Record)
				if (IsValidKeys("IDVALOR"))
				{
					IdValor = Convert.ToString(this.gridResultado.SelectedItems[0].GetRow().Cells["IdValor"].Value);
					datos = _uiController.GetHTMLValoresDatosAuxiliares(IdValor);
				}
			this.htmlDetalle.Clear();
			this.htmlDetalle.AddHTML(datos);
		}
		private bool IsValidKeys(string clave)
		{
			Janus.Windows.GridEX.GridEXColumnCollection collec	= gridResultado.RootTable.Columns;
			ArrayList keys = new ArrayList();
			keys.Add(clave);
			foreach (Janus.Windows.GridEX.GridEXColumn elem in collec )
			{
				if(keys.Contains(elem.DataMember.ToUpper()))
					return true;
			}
			return false;
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					Previous();
					break;
				case 2:
					Execute();
					break;
				case 8:
					ExecuteQuery();
					break;
				case 10:
					ResetFilters();
					break;
			}		
		}

		
		private void ExecuteQuery()
		{
			this.Cursor = Cursors.WaitCursor;
			gridCajas.UpdateData();
			gridUsuarios.UpdateData();
			gridTiposDeComprobante.UpdateData();
			_uiController.RefreshData();
			this.RefreshData();
			this.Cursor = Cursors.Default;
		}

		private void ResetFilters()
		{
			_uiController.ReiniciarFiltros();

			//_uiController.TildarNingunoUsuarios();
			gridUsuarios.DataBindings.Clear();
			gridUsuarios.SetDataBinding( _uiController.FiltroUsuarios , null );

			//_uiController.TildarNingunoCaja();
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );

			//_uiController.TildarNingunoTDCompTesoreria();
			gridTiposDeComprobante.DataBindings.Clear();
			gridTiposDeComprobante.SetDataBinding( _uiController.FiltroTDCompTesoreria , null );

			gridResultado.SetDataBinding( null , null );
			gridResultado.Refresh();
		}

		private void InputControl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.ExecuteQuery();
					break;
			}
		}

		
		

		private void gridCajas_RowExpanded(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
		{
			Console.WriteLine("Hi");
		}


		
		private int grupoActual;
		private void gridResultado_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
			//gridResultado.GroupsChanged +=new Janus.Windows.GridEX.GroupsChangedEventHandler(gridResultado_GroupsChanged);
			//gridResultado.GroupsChanging += new Janus.Windows.GridEX.GroupsChangingEventHandler(gridResultado_GroupsChanging);			
			if(e.Row.RowType.Equals(Janus.Windows.GridEX.RowType.GroupHeader))
			{
				Janus.Windows.GridEX.GridEXFormatStyle style = new Janus.Windows.GridEX.GridEXFormatStyle();
				//style.BackColor = (Color)_mapGroupfis[e.Row.Group.Index];
				if(_mapGroupForegroundColors.ContainsKey(e.Row.Group.Index))
					style.ForeColor = (Color)_mapGroupForegroundColors[e.Row.Group.Index];
				else style.ForeColor = Color.DimGray;
				style.FontBold = Janus.Windows.GridEX.TriState.True;
				e.Row.RowStyle = style;

			}
			if(e.Row.RowType.Equals(Janus.Windows.GridEX.RowType.GroupFooter))
			{
				Janus.Windows.GridEX.GridEXFormatStyle style = new Janus.Windows.GridEX.GridEXFormatStyle();
				if(_mapGroupForegroundColors.ContainsKey(e.Row.Group.Index))
					style.ForeColor = (Color)_mapGroupForegroundColors[e.Row.Group.Index];
				else style.ForeColor = Color.DimGray;
				style.FontBold = Janus.Windows.GridEX.TriState.True;
				e.Row.RowStyle = style;
			}
			if(e.Row.RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				Janus.Windows.GridEX.GridEXFormatStyle style = new Janus.Windows.GridEX.GridEXFormatStyle();
				//style.ForeColor = Color.Transparent;
				e.Row.RowStyle = style;
			}
			/*
			if(e.Row.RowType.Equals(Janus.Windows.GridEX.RowType.TotalRow))
			{
				Janus.Windows.GridEX.GridEXFormatStyle style = new Janus.Windows.GridEX.GridEXFormatStyle();
				style.BackColor = Color.Pink;
				e.Row.RowStyle = style;
			}
			*/
		}

		private void gridResultado_GroupsChanged(object sender, Janus.Windows.GridEX.GroupsChangedEventArgs e)
		{
           
		}

		private void gridResultado_GroupsChanging(object sender, Janus.Windows.GridEX.GroupsChangingEventArgs e)
		{
			
		}

		private void ultraExplorerBarContainerControl2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void loadGridResultadoLayout()
		{
			
		}

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
		
		}
	}		
}
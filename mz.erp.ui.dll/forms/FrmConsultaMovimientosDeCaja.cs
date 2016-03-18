using System;
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
	/// Descripción breve de FrmConsultaMovimientosDeCaja.
	/// </summary>
	public class FrmConsultaMovimientosDeCaja : System.Windows.Forms.Form, ITaskForm	
	{
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
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.Misc.UltraButton bNingunoCaja;
		private Infragistics.Win.Misc.UltraButton bTodosCaja;
		private Infragistics.Win.Misc.UltraButton bNinguno;
		private Infragistics.Win.Misc.UltraButton bTodos;
		private Infragistics.Win.Misc.UltraButton bEgreso;
		private Infragistics.Win.Misc.UltraButton bIngreso;
		private System.Windows.Forms.GroupBox grupoAperturaCierre;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtFechaCierre;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtFechaApertura;
		private System.Windows.Forms.Label lHasta;
		private System.Windows.Forms.Label lDesde;
		private Janus.Windows.GridEX.GridEX gridCajas;
		private Janus.Windows.GridEX.GridEX gridTipos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private HtmlRichText.HtmlRichTextBox htmlDetalle;
		private System.Windows.Forms.CheckBox chkPorFechas;
		private System.ComponentModel.IContainer components;

		private ConsultarMovimientosDeCajasController _uiController = null;
		private Hashtable _mapGroupBackColors = new Hashtable();
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Hashtable _mapGroupForegroundColors = new Hashtable();

		public FrmConsultaMovimientosDeCaja(ConsultarMovimientosDeCajasController uiController)
		{
			InitializeComponent();

			_uiController = uiController;
					
			gridCajas.LayoutData = _uiController.LayoutFiltroCajas;
			gridTipos.LayoutData = _uiController.LayoutFiltroTipos;
			
			this.KeyPreview = true;
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
			
			gridTipos.DataBindings.Clear();
			gridTipos.SetDataBinding( _uiController.FiltroTipos , null );
			
			
			BindingController.Bind( dtFechaApertura,"Value",_uiController,"FechaApertura");
			BindingController.Bind( dtFechaCierre,"Value",_uiController,"FechaCierre");
			BindingController.Bind(chkPorFechas, "Checked", _uiController, "PorFechas");

			}

		private void Build_UI()
		{
			this.labelTarea.Text = _uiController.LeyendaFormulario();
			ConfigureCabecera();
			LoadMapGroupColors();
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

		/*private void ConfigureGrilla()
		{
			gridResultado.AutomaticSort = false;
			if(_uiController.AllowEdit)
				gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			else
				gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridResultado.GroupByBoxVisible = _uiController.AllowGroups;
			this.gridResultado.RootTable.Groups.Clear();
			ArrayList lista = _uiController.Groups;
			foreach(string str in lista)
			{
				if(!str.Equals(string.Empty))
				{
					this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns[str]));
				}
			}
			if(_uiController.AllowTotalGroupRow)
			{
				lista = _uiController.FieldsGroupTotal;
				foreach(string str in lista)
				{
					if(!str.Equals(string.Empty))
					{
						this.gridResultado.RootTable.Columns[str].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
					}
				}
				this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
			}
			this.gridResultado.CollapseGroups();

			if(_uiController.AllowGridTotal)
			{
				this.gridResultado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
				
			}
			if (_uiController.AllowFilters)
				this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			else 
				this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.None;
			gridResultado.AutomaticSort = true;
			
		}*/
	
		private void InitEvents()
		{
			_uiController.ObjectHasChanged+= new System.EventHandler( this.ListenerControllerChanges );
			this.KeyDown+=new KeyEventHandler(InputControl_KeyDown	);
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);	
			gridResultado.FormattingRow +=new Janus.Windows.GridEX.RowLoadEventHandler(gridResultado_FormattingRow);
			//mzGridConfigPanel1.LayoutChanged +=new EventHandler(RefreshData);
			this.chkPorFechas.Click += new System.EventHandler(this.chkFiltroFechas_Click);
			this.bNingunoCaja.Click += new System.EventHandler(this.bNingunoCaja_Click);
			this.bTodosCaja.Click += new System.EventHandler(this.bTodosCaja_Click);
			this.bNinguno.Click += new System.EventHandler(this.bNinguno_Click);
			this.bTodos.Click += new System.EventHandler(this.bTodos_Click);
			this.bEgreso.Click += new System.EventHandler(this.bEgreso_Click);
			this.bIngreso.Click += new System.EventHandler(this.bIngreso_Click);
			/*
			this.dtFechaCierre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			this.dtFechaApertura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			this.gridCajas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			this.gridTipos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			*/
			KeyDownManager KeyDown = new KeyDownManager(this);
            //Cristian Tarea 0000050 20110310
            this.dtFechaApertura.ValueChanged += new EventHandler(dtFechaApertura_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110725
            this.dtFechaCierre.ValueChanged += new EventHandler(dtFechaCierre_ValueChanged);
            //Fin Cristian

        }
        //Cristian Tarea 0000146 20110725
        void dtFechaCierre_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaCierre.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(dtFechaCierre.Value)), true);
                this.dtFechaApertura.Value = _uiController.FechaApertura;
            }
        }
        //Fin cristian 20110725
        //Cristian Tarea 0000050 20110310
        void dtFechaApertura_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaApertura.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(dtFechaApertura.Value)),false);
                this.dtFechaCierre.Value = _uiController.FechaCierre;
            }
        }

      //Fin Cristian

		private void chkFiltroFechas_Click(object sender, System.EventArgs e)
		{
			dtFechaApertura.Enabled = chkPorFechas.Checked;
			dtFechaCierre.Enabled = chkPorFechas.Checked;
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
				BindingController.Clear( dtFechaApertura,"Value",_uiController,"FechaApertura");
				BindingController.Clear( dtFechaCierre,"Value",_uiController,"FechaCierre");
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);	
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
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaMovimientosDeCaja));
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
			this.bEgreso = new Infragistics.Win.Misc.UltraButton();
			this.bIngreso = new Infragistics.Win.Misc.UltraButton();
			this.grupoAperturaCierre = new System.Windows.Forms.GroupBox();
			this.chkPorFechas = new System.Windows.Forms.CheckBox();
			this.dtFechaCierre = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.dtFechaApertura = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.lHasta = new System.Windows.Forms.Label();
			this.lDesde = new System.Windows.Forms.Label();
			this.gridCajas = new Janus.Windows.GridEX.GridEX();
			this.gridTipos = new Janus.Windows.GridEX.GridEX();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.htmlDetalle = new HtmlRichText.HtmlRichTextBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
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
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.grupoAperturaCierre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaCierre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaApertura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTipos)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 18);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(886, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(886, 23);
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
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bEgreso);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bIngreso);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.grupoAperturaCierre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCajas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridTipos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -239);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(886, 237);
			this.ultraExplorerBarContainerControl1.TabIndex = 1;
			// 
			// bNingunoCaja
			// 
			this.bNingunoCaja.AcceptsFocus = false;
			this.bNingunoCaja.Location = new System.Drawing.Point(160, 208);
			this.bNingunoCaja.Name = "bNingunoCaja";
			this.bNingunoCaja.Size = new System.Drawing.Size(64, 22);
			this.bNingunoCaja.TabIndex = 5;
			this.bNingunoCaja.TabStop = false;
			this.bNingunoCaja.Text = "&Ninguno";
			// 
			// bTodosCaja
			// 
			this.bTodosCaja.AcceptsFocus = false;
			this.bTodosCaja.Location = new System.Drawing.Point(96, 208);
			this.bTodosCaja.Name = "bTodosCaja";
			this.bTodosCaja.Size = new System.Drawing.Size(64, 22);
			this.bTodosCaja.TabIndex = 4;
			this.bTodosCaja.TabStop = false;
			this.bTodosCaja.Text = "&Todos";
			// 
			// bNinguno
			// 
			this.bNinguno.AcceptsFocus = false;
			this.bNinguno.Location = new System.Drawing.Point(528, 208);
			this.bNinguno.Name = "bNinguno";
			this.bNinguno.Size = new System.Drawing.Size(64, 22);
			this.bNinguno.TabIndex = 10;
			this.bNinguno.TabStop = false;
			this.bNinguno.Text = "&Ninguno";
			// 
			// bTodos
			// 
			this.bTodos.AcceptsFocus = false;
			this.bTodos.Location = new System.Drawing.Point(464, 208);
			this.bTodos.Name = "bTodos";
			this.bTodos.Size = new System.Drawing.Size(64, 22);
			this.bTodos.TabIndex = 9;
			this.bTodos.TabStop = false;
			this.bTodos.Text = "&Todos";
			// 
			// bEgreso
			// 
			this.bEgreso.AcceptsFocus = false;
			this.bEgreso.Location = new System.Drawing.Point(400, 208);
			this.bEgreso.Name = "bEgreso";
			this.bEgreso.Size = new System.Drawing.Size(64, 22);
			this.bEgreso.TabIndex = 8;
			this.bEgreso.TabStop = false;
			this.bEgreso.Text = "&Egresos";
			// 
			// bIngreso
			// 
			this.bIngreso.AcceptsFocus = false;
			this.bIngreso.Location = new System.Drawing.Point(336, 208);
			this.bIngreso.Name = "bIngreso";
			this.bIngreso.Size = new System.Drawing.Size(64, 22);
			this.bIngreso.TabIndex = 7;
			this.bIngreso.TabStop = false;
			this.bIngreso.Text = "&Ingresos";
			// 
			// grupoAperturaCierre
			// 
			this.grupoAperturaCierre.BackColor = System.Drawing.Color.Transparent;
			this.grupoAperturaCierre.Controls.Add(this.chkPorFechas);
			this.grupoAperturaCierre.Controls.Add(this.dtFechaCierre);
			this.grupoAperturaCierre.Controls.Add(this.dtFechaApertura);
			this.grupoAperturaCierre.Controls.Add(this.lHasta);
			this.grupoAperturaCierre.Controls.Add(this.lDesde);
			this.grupoAperturaCierre.Location = new System.Drawing.Point(8, 0);
			this.grupoAperturaCierre.Name = "grupoAperturaCierre";
			this.grupoAperturaCierre.Size = new System.Drawing.Size(871, 56);
			this.grupoAperturaCierre.TabIndex = 0;
			this.grupoAperturaCierre.TabStop = false;
			this.grupoAperturaCierre.Text = "Por Fechas";
			this.grupoAperturaCierre.Enter += new System.EventHandler(this.grupoAperturaCierre_Enter);
			// 
			// chkPorFechas
			// 
			this.chkPorFechas.Location = new System.Drawing.Point(68, -5);
			this.chkPorFechas.Name = "chkPorFechas";
			this.chkPorFechas.TabIndex = 0;
			// 
			// dtFechaCierre
			// 
			dateButton1.Caption = "Today";
			this.dtFechaCierre.DateButtons.Add(dateButton1);
			this.dtFechaCierre.Location = new System.Drawing.Point(408, 20);
			this.dtFechaCierre.Name = "dtFechaCierre";
			this.dtFechaCierre.NonAutoSizeHeight = 23;
			this.dtFechaCierre.Size = new System.Drawing.Size(96, 21);
			this.dtFechaCierre.TabIndex = 2;
			// 
			// dtFechaApertura
			// 
			dateButton2.Caption = "Today";
			this.dtFechaApertura.DateButtons.Add(dateButton2);
			this.dtFechaApertura.Location = new System.Drawing.Point(96, 20);
			this.dtFechaApertura.Name = "dtFechaApertura";
			this.dtFechaApertura.NonAutoSizeHeight = 23;
			this.dtFechaApertura.Size = new System.Drawing.Size(96, 21);
			this.dtFechaApertura.TabIndex = 1;
			// 
			// lHasta
			// 
			this.lHasta.BackColor = System.Drawing.Color.Transparent;
			this.lHasta.Location = new System.Drawing.Point(352, 24);
			this.lHasta.Name = "lHasta";
			this.lHasta.Size = new System.Drawing.Size(56, 16);
			this.lHasta.TabIndex = 8;
			this.lHasta.Text = "Hasta";
			this.lHasta.Visible = false;
			// 
			// lDesde
			// 
			this.lDesde.BackColor = System.Drawing.Color.Transparent;
			this.lDesde.Location = new System.Drawing.Point(40, 24);
			this.lDesde.Name = "lDesde";
			this.lDesde.Size = new System.Drawing.Size(56, 16);
			this.lDesde.TabIndex = 7;
			this.lDesde.Text = "Desde";
			this.lDesde.Visible = false;
			// 
			// gridCajas
			// 
			this.gridCajas.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCajas.GroupByBoxVisible = false;
			this.gridCajas.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCajas.Location = new System.Drawing.Point(8, 80);
			this.gridCajas.Name = "gridCajas";
			this.gridCajas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCajas.Size = new System.Drawing.Size(296, 128);
			this.gridCajas.TabIndex = 3;
			// 
			// gridTipos
			// 
			this.gridTipos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridTipos.GroupByBoxVisible = false;
			this.gridTipos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridTipos.Location = new System.Drawing.Point(312, 80);
			this.gridTipos.Name = "gridTipos";
			this.gridTipos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridTipos.Size = new System.Drawing.Size(296, 128);
			this.gridTipos.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(312, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cuenta";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cajas";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 57);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(886, 312);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(888, 24);
			this.gridManagerView1.TabIndex = 3;
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
			this.gridResultado.Size = new System.Drawing.Size(886, 280);
			this.gridResultado.TabIndex = 1;
			this.gridResultado.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)(((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
				| Janus.Windows.GridEX.ThemedArea.Headers) 
				| Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
				| Janus.Windows.GridEX.ThemedArea.ControlBorder)));
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.htmlDetalle);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 259);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(886, 150);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// htmlDetalle
			// 
			this.htmlDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmlDetalle.Location = new System.Drawing.Point(0, 0);
			this.htmlDetalle.Name = "htmlDetalle";
			this.htmlDetalle.ReadOnly = true;
			this.htmlDetalle.Size = new System.Drawing.Size(886, 150);
			this.htmlDetalle.TabIndex = 0;
			this.htmlDetalle.Text = "";
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
																							  this.tbbReiniciarFiltros,
																							  this.toolBarButton2,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(952, 28);
			this.toolBarStandar.TabIndex = 21;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
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
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 237;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 312;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup4.Expanded = false;
			ultraExplorerBarGroup4.Key = "Detalles";
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Detalles";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(952, 434);
			this.ultraExplorerBar1.TabIndex = 22;
			// 
			// FrmConsultaMovimientosDeCaja
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(952, 462);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultaMovimientosDeCaja";
			this.Text = "FrmConsultaMovimientosDeCaja";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.grupoAperturaCierre.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtFechaCierre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaApertura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTipos)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void grupoAperturaCierre_Enter(object sender, System.EventArgs e)
		{
		
		}
		#region Miembros de ITaskForm

		public void ShowForm()
		{
			base.Show();
		}

		public void CloseForm()
		{			
			if (_uiController.PreguntarAlCancelar)
			{
				if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
					base.Close();
			}
			else
			{
				base.Close();
			}
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
			_uiController.Execute();
		}

		public void Previous()
		{
			_uiController.Previous();
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
		private void bEgreso_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarEgresos();
			gridTipos.DataBindings.Clear();
			gridTipos.SetDataBinding( _uiController.FiltroTipos , null );
		}

		private void bIngreso_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarIngresos();
			gridTipos.DataBindings.Clear();
			gridTipos.SetDataBinding( _uiController.FiltroTipos , null );
		}

		private void bTodos_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarTodos();
			gridTipos.DataBindings.Clear();
			gridTipos.SetDataBinding( _uiController.FiltroTipos , null );
		}

		private void bNinguno_Click(object sender, System.EventArgs e)
		{
			_uiController.TildarNinguno();
			gridTipos.DataBindings.Clear();
			gridTipos.SetDataBinding( _uiController.FiltroTipos , null );
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


		

		private void VisualizarInfoDetallada()
		{
			string datos = string.Empty;
			if (gridResultado.SelectedItems[0].RowType == Janus.Windows.GridEX.RowType.Record)
				if (IsValidKeys("TextoHTML"))
					datos = Convert.ToString(this.gridResultado.SelectedItems[0].GetRow().Cells["TextoHTML"].Value);
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
				if(keys.Contains(elem.DataMember))
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
				case 12:
					CloseForm();
					break;
			}		
		}

		
		private void ExecuteQuery()
		{
			this.Cursor = Cursors.WaitCursor;
			gridCajas.UpdateData();
			gridTipos.UpdateData();
			_uiController.RefreshData();
			this.RefreshData();
			this.Cursor = Cursors.Default;
		}

		private void ResetFilters()
		{
			chkPorFechas.Checked=false;
			dtFechaApertura.Enabled=false;
			dtFechaCierre.Enabled=false;
			
			_uiController.TildarNingunoCaja();
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );

			_uiController.TildarNingunoCaja();
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );

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


		#endregion

	}
}

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
	public class FrmConsultaCaja : System.Windows.Forms.Form, ITaskForm	
	{
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Janus.Windows.GridEX.GridEX gridUsuarios;
		private Janus.Windows.GridEX.GridEX gridTipos;
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
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtFechaCierre;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo dtFechaApertura;
		private Infragistics.Win.Misc.UltraButton bIngreso;
		private Infragistics.Win.Misc.UltraButton bEgreso;
		private Infragistics.Win.Misc.UltraButton bTodos;
		private Infragistics.Win.Misc.UltraButton bNinguno;
		private Infragistics.Win.Misc.UltraButton bNingunoCaja;
		private Infragistics.Win.Misc.UltraButton bTodosCaja;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.RadioButton radioBSoloAbiertas;
		private System.Windows.Forms.RadioButton radioBSoloCerradas;
		private System.Windows.Forms.RadioButton radioBTodas;
		private System.Windows.Forms.Label lHasta;
		private System.Windows.Forms.Label lDesde;
		private mz.erp.ui.controllers.ConsultasCajaController _uiController;
		private Hashtable _mapGroupForegroundColors = new Hashtable();
		private mz.erp.ui.controls.mzGridConfigPanel mzGridConfigPanel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private HtmlRichText.HtmlRichTextBox htmlDetalle;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.RadioButton radioBMovimiento;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton tbbSeparadorCancelar;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Hashtable _mapGroupBackColors = new Hashtable();
	
		#region constructor, metodos asociados y destructores
	
		public FrmConsultaCaja(mz.erp.ui.controllers.ConsultasCajaController uiController)
		{
			InitializeComponent();

			_uiController = uiController;
					
			gridCajas.LayoutData = _uiController.LayoutFiltroCajas;
			gridTipos.LayoutData = _uiController.LayoutFiltroTipos;
			gridUsuarios.LayoutData = _uiController.LayoutFiltroUsuarios;
			
			ultraExplorerBar1.Groups["Detalles"].Visible = _uiController.DetallesVisibles();

			mzGridConfigPanel1.GridSource = gridResultado;
			mzGridConfigPanel1.Initialize(_uiController.GetProcessName(), _uiController.GetTaskName(), _uiController.LayoutFiltroResultado);
			//ConfigureGrilla();
			//CallGridManager();
			string solapa = _uiController.GetFormText();
			if (solapa!= "" && solapa != string.Empty)
				this.Text = _uiController.GetFormText();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);
			
			KeyPreview = true;

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
			
			gridUsuarios.DataBindings.Clear();
			gridUsuarios.SetDataBinding( _uiController.FiltroUsuarios , null );
			
			BindingController.Bind( dtFechaApertura,"Value",_uiController,"FechaApertura");
			BindingController.Bind( dtFechaCierre,"Value",_uiController,"FechaCierre");

			radioBSoloAbiertas.DataBindings.Clear();
			radioBSoloAbiertas.DataBindings.Add("Checked", _uiController , "CheckSoloAbiertas");
			radioBSoloCerradas.DataBindings.Clear();
			radioBSoloCerradas.DataBindings.Add("Checked", _uiController , "CheckSoloCerradas");
			
			dtFechaApertura.DataBindings.Add( "Enabled", _uiController, "AllowFechas");
			dtFechaCierre.DataBindings.Add( "Enabled", _uiController, "AllowFechas");
		}

		private void Build_UI()
		{
			this.labelTarea.Text = _uiController.LeyendaFormulario();
			ConfigureCabecera();
			LoadMapGroupColors();
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
            if ( _uiController.FiltroFechaMovimiento )
				radioBMovimiento.Enabled = true;
			else 
				radioBMovimiento.Enabled = false;
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
			if (!mzGridConfigPanel1.LoadFromFile) 
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
			/*if (_uiController.GetFilaTotalGroup() != "")
			{
				this.gridResultado.RootTable.Columns[_uiController.GetFilaTotalGroup()].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
				//usar format string para formatear el tipo de la row total group
				//permito que se vea el resultado de la suma siempre		
				this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;	
			}*/
			gridResultado.RowExpanded +=new Janus.Windows.GridEX.RowActionEventHandler(gridCajas_RowExpanded);
			Janus.Windows.GridEX.GridEXGroupCollection col = gridResultado.RootTable.Groups;
			
		}
	
		private void InitEvents()
		{
			_uiController.ObjectHasChanged+= new System.EventHandler( this.ListenerControllerChanges );
			radioBSoloAbiertas.Click += new EventHandler(radioCheck_Click);
			radioBSoloCerradas.Click += new EventHandler(radioCheck_Click);
			radioBTodas.Click += new EventHandler(radioCheck_Click);
			radioBMovimiento.Click += new EventHandler(radioCheck_Click);
			gridResultado.FormattingRow +=new Janus.Windows.GridEX.RowLoadEventHandler(gridResultado_FormattingRow);
			gridResultado.SelectionChanged += new EventHandler(gridResultado_SelectionChanged);
			mzGridConfigPanel1.LayoutChanged +=new EventHandler(RefreshData);
			KeyDown +=new KeyEventHandler(KeyDownBehavior);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
            //Cristian Tarea 0000050 20110310
            this.dtFechaApertura.ValueChanged += new EventHandler(dtFechaApertura_ValueChanged);
            //Fin Cristian
            //Cristian Tarea 0000146 20110725
            this.dtFechaCierre.ValueChanged += new EventHandler(dtFechaCierre_ValueChanged);
        }
         
        void dtFechaCierre_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaCierre.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(dtFechaCierre.Value)), true);
                this.dtFechaApertura.Value = _uiController.FechaApertura;
            }
        }
        //Fin Tarea 0000146

        //Cristian Tarea 0000050 20110310
        void dtFechaApertura_ValueChanged(object sender, EventArgs e)
        {
            if (dtFechaApertura.Value != (System.DBNull.Value))
            {
                _uiController.updateFechas((Convert.ToDateTime(dtFechaApertura.Value)),false);
                this.dtFechaCierre.Value = _uiController.FechaCierre;
            }
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
				
				radioBSoloAbiertas.DataBindings.Clear();
				radioBSoloCerradas.DataBindings.Clear();

				this.radioBSoloAbiertas.Click -= new System.EventHandler(this.radioCheck_Click);
				this.radioBSoloCerradas.Click -= new System.EventHandler(this.radioCheck_Click);
				this.radioBTodas.Click -= new System.EventHandler(this.radioCheck_Click);
				this.radioBMovimiento.Click -= new System.EventHandler(this.radioCheck_Click);
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
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaCaja));
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
			this.radioBMovimiento = new System.Windows.Forms.RadioButton();
			this.radioBTodas = new System.Windows.Forms.RadioButton();
			this.radioBSoloCerradas = new System.Windows.Forms.RadioButton();
			this.radioBSoloAbiertas = new System.Windows.Forms.RadioButton();
			this.dtFechaCierre = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.dtFechaApertura = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.lHasta = new System.Windows.Forms.Label();
			this.lDesde = new System.Windows.Forms.Label();
			this.gridCajas = new Janus.Windows.GridEX.GridEX();
			this.gridTipos = new Janus.Windows.GridEX.GridEX();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridUsuarios = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.mzGridConfigPanel1 = new mz.erp.ui.controls.mzGridConfigPanel();
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
			this.tbbSeparadorCancelar = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.grupoAperturaCierre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaCierre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaApertura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTipos)).BeginInit();
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
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, -31);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(962, 25);
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
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bEgreso);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bIngreso);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.grupoAperturaCierre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCajas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridTipos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridUsuarios);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -266);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(962, 260);
			this.ultraExplorerBarContainerControl1.TabIndex = 1;
			// 
			// bNingunoCaja
			// 
			this.bNingunoCaja.AcceptsFocus = false;
			this.bNingunoCaja.Location = new System.Drawing.Point(464, 238);
			this.bNingunoCaja.Name = "bNingunoCaja";
			this.bNingunoCaja.Size = new System.Drawing.Size(64, 22);
			this.bNingunoCaja.TabIndex = 10;
			this.bNingunoCaja.TabStop = false;
			this.bNingunoCaja.Text = "&Ninguno";
			this.bNingunoCaja.Click += new System.EventHandler(this.bNingunoCaja_Click);
			// 
			// bTodosCaja
			// 
			this.bTodosCaja.AcceptsFocus = false;
			this.bTodosCaja.Location = new System.Drawing.Point(400, 238);
			this.bTodosCaja.Name = "bTodosCaja";
			this.bTodosCaja.Size = new System.Drawing.Size(64, 22);
			this.bTodosCaja.TabIndex = 9;
			this.bTodosCaja.TabStop = false;
			this.bTodosCaja.Text = "&Todos";
			this.bTodosCaja.Click += new System.EventHandler(this.bTodosCaja_Click);
			// 
			// bNinguno
			// 
			this.bNinguno.AcceptsFocus = false;
			this.bNinguno.Location = new System.Drawing.Point(832, 238);
			this.bNinguno.Name = "bNinguno";
			this.bNinguno.Size = new System.Drawing.Size(64, 22);
			this.bNinguno.TabIndex = 14;
			this.bNinguno.TabStop = false;
			this.bNinguno.Text = "&Ninguno";
			this.bNinguno.Click += new System.EventHandler(this.bNinguno_Click);
			// 
			// bTodos
			// 
			this.bTodos.AcceptsFocus = false;
			this.bTodos.Location = new System.Drawing.Point(768, 238);
			this.bTodos.Name = "bTodos";
			this.bTodos.Size = new System.Drawing.Size(64, 22);
			this.bTodos.TabIndex = 13;
			this.bTodos.TabStop = false;
			this.bTodos.Text = "&Todos";
			this.bTodos.Click += new System.EventHandler(this.bTodos_Click);
			// 
			// bEgreso
			// 
			this.bEgreso.AcceptsFocus = false;
			this.bEgreso.Location = new System.Drawing.Point(704, 238);
			this.bEgreso.Name = "bEgreso";
			this.bEgreso.Size = new System.Drawing.Size(64, 22);
			this.bEgreso.TabIndex = 12;
			this.bEgreso.TabStop = false;
			this.bEgreso.Text = "&Egresos";
			this.bEgreso.Click += new System.EventHandler(this.bEgreso_Click);
			// 
			// bIngreso
			// 
			this.bIngreso.AcceptsFocus = false;
			this.bIngreso.Location = new System.Drawing.Point(640, 238);
			this.bIngreso.Name = "bIngreso";
			this.bIngreso.Size = new System.Drawing.Size(64, 22);
			this.bIngreso.TabIndex = 11;
			this.bIngreso.TabStop = false;
			this.bIngreso.Text = "&Ingresos";
			this.bIngreso.Click += new System.EventHandler(this.bIngreso_Click);
			// 
			// grupoAperturaCierre
			// 
			this.grupoAperturaCierre.BackColor = System.Drawing.Color.Transparent;
			this.grupoAperturaCierre.Controls.Add(this.radioBMovimiento);
			this.grupoAperturaCierre.Controls.Add(this.radioBTodas);
			this.grupoAperturaCierre.Controls.Add(this.radioBSoloCerradas);
			this.grupoAperturaCierre.Controls.Add(this.radioBSoloAbiertas);
			this.grupoAperturaCierre.Controls.Add(this.dtFechaCierre);
			this.grupoAperturaCierre.Controls.Add(this.dtFechaApertura);
			this.grupoAperturaCierre.Controls.Add(this.lHasta);
			this.grupoAperturaCierre.Controls.Add(this.lDesde);
			this.grupoAperturaCierre.Location = new System.Drawing.Point(8, 0);
			this.grupoAperturaCierre.Name = "grupoAperturaCierre";
			this.grupoAperturaCierre.Size = new System.Drawing.Size(912, 88);
			this.grupoAperturaCierre.TabIndex = 0;
			this.grupoAperturaCierre.TabStop = false;
			this.grupoAperturaCierre.Text = "Estado";
			// 
			// radioBMovimiento
			// 
			this.radioBMovimiento.Location = new System.Drawing.Point(56, 62);
			this.radioBMovimiento.Name = "radioBMovimiento";
			this.radioBMovimiento.Size = new System.Drawing.Size(168, 16);
			this.radioBMovimiento.TabIndex = 3;
			this.radioBMovimiento.Text = "Por fecha de movimiento";
			// 
			// radioBTodas
			// 
			this.radioBTodas.Location = new System.Drawing.Point(56, 46);
			this.radioBTodas.Name = "radioBTodas";
			this.radioBTodas.Size = new System.Drawing.Size(168, 16);
			this.radioBTodas.TabIndex = 2;
			this.radioBTodas.Text = "Todas (abiertas / cerradas)";
			// 
			// radioBSoloCerradas
			// 
			this.radioBSoloCerradas.Location = new System.Drawing.Point(56, 30);
			this.radioBSoloCerradas.Name = "radioBSoloCerradas";
			this.radioBSoloCerradas.Size = new System.Drawing.Size(168, 16);
			this.radioBSoloCerradas.TabIndex = 1;
			this.radioBSoloCerradas.Text = "Sólo cajas cerradas";
			// 
			// radioBSoloAbiertas
			// 
			this.radioBSoloAbiertas.Location = new System.Drawing.Point(56, 14);
			this.radioBSoloAbiertas.Name = "radioBSoloAbiertas";
			this.radioBSoloAbiertas.Size = new System.Drawing.Size(168, 16);
			this.radioBSoloAbiertas.TabIndex = 0;
			this.radioBSoloAbiertas.Text = "Sólo cajas abiertas";
			// 
			// dtFechaCierre
			// 
			dateButton1.Caption = "Today";
			this.dtFechaCierre.DateButtons.Add(dateButton1);
			this.dtFechaCierre.Location = new System.Drawing.Point(720, 30);
			this.dtFechaCierre.Name = "dtFechaCierre";
			this.dtFechaCierre.NonAutoSizeHeight = 23;
			this.dtFechaCierre.Size = new System.Drawing.Size(96, 21);
			this.dtFechaCierre.TabIndex = 5;
			this.dtFechaCierre.Visible = false;
			this.dtFechaCierre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// dtFechaApertura
			// 
			dateButton2.Caption = "Today";
			this.dtFechaApertura.DateButtons.Add(dateButton2);
			this.dtFechaApertura.Location = new System.Drawing.Point(408, 30);
			this.dtFechaApertura.Name = "dtFechaApertura";
			this.dtFechaApertura.NonAutoSizeHeight = 23;
			this.dtFechaApertura.Size = new System.Drawing.Size(96, 21);
			this.dtFechaApertura.TabIndex = 4;
			this.dtFechaApertura.Visible = false;
			this.dtFechaApertura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// lHasta
			// 
			this.lHasta.BackColor = System.Drawing.Color.Transparent;
			this.lHasta.Location = new System.Drawing.Point(664, 32);
			this.lHasta.Name = "lHasta";
			this.lHasta.Size = new System.Drawing.Size(56, 16);
			this.lHasta.TabIndex = 8;
			this.lHasta.Text = "Hasta";
			this.lHasta.Visible = false;
			// 
			// lDesde
			// 
			this.lDesde.BackColor = System.Drawing.Color.Transparent;
			this.lDesde.Location = new System.Drawing.Point(352, 32);
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
			this.gridCajas.Location = new System.Drawing.Point(312, 108);
			this.gridCajas.Name = "gridCajas";
			this.gridCajas.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCajas.Size = new System.Drawing.Size(296, 128);
			this.gridCajas.TabIndex = 7;
			this.gridCajas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// gridTipos
			// 
			this.gridTipos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridTipos.GroupByBoxVisible = false;
			this.gridTipos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridTipos.Location = new System.Drawing.Point(616, 108);
			this.gridTipos.Name = "gridTipos";
			this.gridTipos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridTipos.Size = new System.Drawing.Size(296, 128);
			this.gridTipos.TabIndex = 8;
			this.gridTipos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(616, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 14);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cuenta";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(312, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cajas";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 92);
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
			this.gridUsuarios.Location = new System.Drawing.Point(8, 108);
			this.gridUsuarios.Name = "gridUsuarios";
			this.gridUsuarios.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridUsuarios.Size = new System.Drawing.Size(296, 128);
			this.gridUsuarios.TabIndex = 6;
			this.gridUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzGridConfigPanel1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -108);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(962, 312);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			this.ultraExplorerBarContainerControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraExplorerBarContainerControl2_Paint);
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.Color.Transparent;
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
			this.gridResultado.SelectionChanged += new System.EventHandler(this.gridResultado_SelectionChanged);
			this.gridResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControl_KeyDown);
			// 
			// mzGridConfigPanel1
			// 
			this.mzGridConfigPanel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.mzGridConfigPanel1.GridSource = null;
			this.mzGridConfigPanel1.LayoutDefault = null;
			this.mzGridConfigPanel1.LoadFromFile = true;
			this.mzGridConfigPanel1.Location = new System.Drawing.Point(624, 40);
			this.mzGridConfigPanel1.Name = "mzGridConfigPanel1";
			this.mzGridConfigPanel1.ProcessName = null;
			this.mzGridConfigPanel1.Size = new System.Drawing.Size(304, 48);
			this.mzGridConfigPanel1.TabIndex = 2;
			this.mzGridConfigPanel1.TaskName = null;
			this.mzGridConfigPanel1.Visible = false;
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.htmlDetalle);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 263);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(962, 150);
			this.ultraExplorerBarContainerControl4.TabIndex = 0;
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
																							  this.tbbReiniciarFiltros,
																							  this.tbbSeparadorCancelar,
																							  this.tbbCancelar});
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
			// tbbSeparadorCancelar
			// 
			this.tbbSeparadorCancelar.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 260;
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
			// FrmConsultaCaja
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 462);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.panel1);
			this.Name = "FrmConsultaCaja";
			this.Text = "Consulta de Caja";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.grupoAperturaCierre.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtFechaCierre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtFechaApertura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCajas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridTipos)).EndInit();
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
//			ConfigureGrilla();
			gridResultado.SetDataBinding( null , null );
			gridResultado.SetDataBinding( _uiController.Data, "Result" );
			gridResultado.Refetch();
		}
		

		
		private void RefreshData()
		{			
//			ConfigureGrilla();
			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.Data.Tables[0], null);
			gridResultado.Refetch();

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
			if (gridManagerView1.AllowGroupCollapse)
				this.gridResultado.CollapseGroups();
			else
				if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();

			// ---- Matias - Tarea 285 - Custom 7 - 20090714
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.Data.Tables[0]);
			// ---- Fin Matias

			#region CCDeprecated
			//			if(_uiController.Data != null)
			//			{
			//				gridManagerView1.SetTable(_uiController.Data.Tables["Result"]);			
			//				if (_uiController.Data.Tables.Count > 0)
			//				{
			//					if (_uiController.Data.Tables[0].Rows.Count == 0)
			//					{
			//						System.Windows.Forms.MessageBox.Show( "No hay datos para los filtros seleccionados", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
			//					}
			//					// ---- Matias - 20090629
			//					else					
			//					{
			//						if (_uiController.Data.Tables[0].Rows.Count > 0)
			//						{
			//							gridResultado.SetDataBinding( null , null );
			//							gridResultado.SetDataBinding( _uiController.Data, "Result" );
			//							gridResultado.Refetch();			
			//						}
			//					}
			//					// ---- FinMatias.
			//				}
			//				else
			//				{
			//					System.Windows.Forms.MessageBox.Show( "No hay datos para los filtros seleccionados", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
			//				}
			#endregion

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

		#endregion

		#region Miembros de ITaskForm

		public void ShowForm()
		{
			base.Show();
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
					//
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
					
					bool esAjuste;
					if (_uiController.RevisarAjuste())
						esAjuste = _uiController.EsAjuste(Convert.ToString(this.gridResultado.SelectedItems[0].GetRow().Cells["Observaciones"].Value));
					else esAjuste = false;
					if ((this.gridResultado.SelectedItems[0].GetRow().RowType == Janus.Windows.GridEX.RowType.Record)&& !esAjuste)
					{
						tbbSiguiente.Enabled = true;
						_uiController.SelectedItem = this.gridResultado.SelectedItems[0].GetRow();
						_uiController.SelectedRow = this.gridResultado.SelectedItems[0].GetRow().DataRow;
					}
					else 
					{
						tbbSiguiente.Enabled = false;
						_uiController.SelectedRow = null;
					}
					VisualizarInfoDetallada();
				}
				else
					tbbSiguiente.Enabled = false;
			}
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
				/*Nueva Busqueda*/					
				case 10:
					ResetFilters();
					break;
				case 8:
					ExecuteQuery();
					break;
				case 12:
					CloseForm();
					break;
			}				
		}

		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					ExecuteQuery();
					break;
			}
		}

		private void ResetFilters()
		{
			radioBSoloAbiertas.Checked = true;
			_uiController.CheckSoloAbiertas = true;
			_uiController.CheckSoloCerradas = false;
			_uiController.CheckFechaMovimientos = false;
			dtFechaApertura.Visible = false;
			dtFechaCierre.Visible = false;
			lDesde.Visible = false;
			lHasta.Visible = false;

			// Reset tildes de Cajas.
			_uiController.ReiniciarFiltros();

			//_uiController.TildarNingunoCaja();			
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );

			// Reset tildes de Cuentas.
			//_uiController.TildarNinguno();
			gridTipos.DataBindings.Clear();
			gridTipos.SetDataBinding( _uiController.FiltroTipos , null );

			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}
		
		private void ExecuteQuery()
		{
			this.Cursor = Cursors.WaitCursor;
			gridCajas.UpdateData();
			gridUsuarios.UpdateData();
			gridTipos.UpdateData();
			_uiController.RefreshData();
			this.RefreshData();
			this.Cursor = Cursors.Default;
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

		
		private void radioCheck_Click(object sender, EventArgs e)
		{
			RadioButton radio = (RadioButton) sender;
			if (radio.Checked)
			{	
				_uiController.CheckSoloAbiertas = radio.Name.Equals("radioBSoloAbiertas");
				_uiController.CheckSoloCerradas = radio.Name.Equals("radioBSoloCerradas");
				_uiController.CheckFechaMovimientos = radio.Name.Equals("radioBMovimiento");
				bool _aux = _uiController.AllowFechas;
				dtFechaApertura.Visible = _aux;
				dtFechaCierre.Visible = _aux;
				lDesde.Visible= _aux;
				lHasta.Visible= _aux;
                /* Silvina 20110101 - Tarea 0000072 */
                dtFechaApertura.DataBindings.Clear();
                dtFechaApertura.DataBindings.Add("Enabled", _uiController, "AllowFechas");
                dtFechaCierre.DataBindings.Clear();
                dtFechaCierre.DataBindings.Add("Enabled", _uiController, "AllowFechas");
                /* Fin Silvina */
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

		/*private void radioBMovimiento_CheckedChanged(object sender, System.EventArgs e)
		{
			// Tarea 32 - Matias
		}*/
	}		
}
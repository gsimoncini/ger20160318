
using System.Configuration;

namespace mz.erp
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Diagnostics;
	
	using ClassLibrary1; //Manejador de Excepciones //descomentar y compilar despues --Cristian
	using mz.erp.businessrules;
	using mz.erp.businessrules.reportes;
	using mz.erp.commontypes;
	using mz.erp.systemframework;
	using System.Reflection;
	using mz.erp.ui.controllers;
	using System.Security.Permissions;
	using System.Globalization;
	using mz.erp.ui.forms;
	using mz.erp.ui.forms.classes;
    using System.Xml;
    using System.Text;
    using System.Reflection.Emit;
    using System.Security.Policy;	
	//using mz.erp.exe;
    using System.Media;

	
    //Prueba Branch
	public class MainForm : System.Windows.Forms.Form, IMainForm
	{
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Left;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Right;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Top;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Bottom;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager toolbarsManager;
		private Infragistics.Win.UltraWinStatusBar.UltraStatusBar statusBar;
		private System.Windows.Forms.ImageList imageListSmall;
		private Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager ultraTabbedMdiManager;
		private Infragistics.Win.UltraWinDock.UltraDockManager ultraDockManager1;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _MainFormUnpinnedTabAreaLeft;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _MainFormUnpinnedTabAreaRight;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _MainFormUnpinnedTabAreaTop;
		private Infragistics.Win.UltraWinDock.UnpinnedTabArea _MainFormUnpinnedTabAreaBottom;
		private Infragistics.Win.UltraWinDock.AutoHideControl _MainFormAutoHideControl;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar explorerBar;
		private Infragistics.Win.UltraWinDock.DockableWindow dockableWindow1;
		private System.Windows.Forms.ImageList imageListLarge;
		private System.Windows.Forms.ImageList imageListSmallEB;
		private System.Windows.Forms.ImageList imageListLargeEB;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.ComponentModel.IContainer components;
		private Infragistics.Win.UltraWinDock.WindowDockingArea windowDockingArea1;

		private static Timer _timer;
		private Infragistics.Win.UltraWinEditors.UltraPictureBox imageSemaphore;
		private static Timer _timerForSemaphore;
		private static Timer _timerParpadeo;
		private bool _FormCerrarSesion;
		private bool esFormControlMenu = false;


        private static bool _allwSemaphore = false;
        private Timer timerAlertas;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem VerAlertas;
        private NotifyIcon notifyIcon1;
		

		private Image _foregroundImage = null;
		


		public MainForm()
		{
            //Cristian Tarea 129 20110706
            ConfigurationForm();
            //Fin Tarea 129
            InitializeComponent();
			mz.erp.ui.utility.Environment.MainForm = this;
			_timer = new Timer();
			_timerForSemaphore = new Timer();
			_timerParpadeo = new Timer();

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

        //Cristian Tarea 129 20110617
	    //[STAThread]
		//static void Main() 
        
          static  void ConfigurationForm() 		
		{      
       
        //FIn Tarea 129 20110617

		if (Variables.GetValueBool("Debug.ManejadorDeExcepciones"))
			{
				//#if RELEASE
                /*
                string _strEmailTo = mz.erp.businessrules.Variables.GetValueString("Debug.ManejadorDeExcepciones.Mail.To");
                   string _strEmailPort = mz.erp.businessrules.Variables.GetValueString("Debug.Mail.Port");
                string _strEmailServer = mz.erp.businessrules.Variables.GetValueString("Debug.Mail.Server");
                bool SendEmail = mz.erp.businessrules.Variables.GetValueBool("Debug.ManejadorDeExcepciones.HabilitaEnvioMail");
                    bool LogToDB = mz.erp.businessrules.Variables.GetValueBool("Debug.ManejadorDeExcepciones.HabilitaEnvioDB");
                bool DisplayDialog = mz.erp.businessrules.Variables.GetValueBool("Debug.ManejadorDeExcepciones.HabilitaEnvioPantalla");
                ClassLibrary1.UnhandledExceptionManager.AddHandler( false,_strEmailTo, _strEmailPort , _strEmailServer, LogToDB, DisplayDialog );	 //descomentar y compilar despues --Cristian
                */
                ClassLibrary1.UnhandledExceptionManager.AddHandler(false);	
				//#endif 	
			}
			

			Application.Idle+= new EventHandler(Application_Idle);	
			/*
			NumberFormatInfo  nf = Application.CurrentCulture.NumberFormat;
			nf.CurrencyDecimalSeparator = ".";
			nf.CurrencyGroupSeparator = ",";
			nf.NumberDecimalSeparator = ".";
			nf.NumberGroupSeparator = ",";
			nf.PercentDecimalSeparator = ".";
			nf.PercentGroupSeparator = ",";
			*/


			if(Variables.GetValueBool("Sistema.Cultura.Personalizada"))
			{
				/*Falta crear las 4 Variables de sistema*/
				string CultureName = Variables.GetValueString("Sistema.Cultura.Nombre");
				string separadorDecimal = Variables.GetValueString("Sistema.Cultura.SeparadorDecimal");
				string separadorDeMiles = Variables.GetValueString("Sistema.Cultura.SeparadorDeMiles");
				Application.CurrentCulture = new CultureInfo(CultureName,true);
				Application.CurrentCulture.NumberFormat.NumberDecimalSeparator = separadorDecimal;
				Application.CurrentCulture.NumberFormat.NumberGroupSeparator = separadorDeMiles;
				Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator =separadorDecimal;
				Application.CurrentCulture.NumberFormat.CurrencyGroupSeparator = separadorDeMiles;
				Application.CurrentCulture.NumberFormat.PercentDecimalSeparator = separadorDecimal;
				Application.CurrentCulture.NumberFormat.PercentGroupSeparator = separadorDeMiles;

			}
			Security.SeparadorDeMiles = Application.CurrentCulture.NumberFormat.NumberGroupSeparator ;
			Security.SeparadorDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator ;
			Security.CultureName = Application.CurrentCulture.Name; 
			//Cristian tarea 129 20110706
            //Application.Run(new MainForm());
            //Fin Tarea 129
		}



	    private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e) 
		{								
			if( esFormControlMenu )
			{								
				bool Pregunta = Variables.GetValueBool("Debug.PreguntaAntesSalida.Habilitado");
				if (Pregunta) 
				{
					DialogResult result;
					result = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(result == DialogResult.No)
					{					
						e.Cancel = true;
					}
					esFormControlMenu = false;
				}
			}
		}  


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel2 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel3 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel4 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel5 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel6 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel7 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel8 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel9 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("Menú principal");
            Infragistics.Win.UltraWinToolbars.UltraToolbar ultraToolbar2 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("Estándar");
            Infragistics.Win.UltraWinDock.DockAreaPane dockAreaPane1 = new Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedLeft, new System.Guid("034a3886-5f63-47c8-a222-0a9fd780bfd9"));
            Infragistics.Win.UltraWinDock.DockableControlPane dockableControlPane1 = new Infragistics.Win.UltraWinDock.DockableControlPane(new System.Guid("3cfe1dd3-e92c-47b1-82c8-cad7a7a96fcb"), new System.Guid("00000000-0000-0000-0000-000000000000"), -1, new System.Guid("034a3886-5f63-47c8-a222-0a9fd780bfd9"), -1);
            this.imageSemaphore = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
            this.explorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.imageListLargeEB = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmallEB = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.statusBar = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
            this.toolbarsManager = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this._MainForm_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraTabbedMdiManager = new Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(this.components);
            this.ultraDockManager1 = new Infragistics.Win.UltraWinDock.UltraDockManager(this.components);
            this._MainFormUnpinnedTabAreaLeft = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._MainFormUnpinnedTabAreaRight = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._MainFormUnpinnedTabAreaTop = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._MainFormUnpinnedTabAreaBottom = new Infragistics.Win.UltraWinDock.UnpinnedTabArea();
            this._MainFormAutoHideControl = new Infragistics.Win.UltraWinDock.AutoHideControl();
            this.dockableWindow1 = new Infragistics.Win.UltraWinDock.DockableWindow();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.windowDockingArea1 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
            this.timerAlertas = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VerAlertas = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar)).BeginInit();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarsManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).BeginInit();
            this._MainFormAutoHideControl.SuspendLayout();
            this.dockableWindow1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageSemaphore
            // 
            this.imageSemaphore.BorderShadowColor = System.Drawing.Color.Empty;
            this.imageSemaphore.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.imageSemaphore.Location = new System.Drawing.Point(279, 3);
            this.imageSemaphore.Name = "imageSemaphore";
            this.imageSemaphore.ScaleImage = Infragistics.Win.ScaleImage.Always;
            this.imageSemaphore.Size = new System.Drawing.Size(98, 19);
            this.imageSemaphore.TabIndex = 30;
            this.imageSemaphore.Click += new System.EventHandler(this.ultraPictureBox1_Click);
            // 
            // explorerBar
            // 
            this.explorerBar.AnimationEnabled = false;
            this.explorerBar.ImageListLarge = this.imageListLargeEB;
            this.explorerBar.ImageListSmall = this.imageListSmallEB;
            this.explorerBar.Location = new System.Drawing.Point(0, 18);
            this.explorerBar.Name = "explorerBar";
            this.explorerBar.ShowDefaultContextMenu = false;
            this.explorerBar.Size = new System.Drawing.Size(211, 465);
            this.explorerBar.TabIndex = 23;
            this.explorerBar.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            this.explorerBar.ContextMenuInitializing += new Infragistics.Win.UltraWinExplorerBar.ContextMenuInitializingEventHandler(this.explorerBar_ContextMenuInitializing);
            this.explorerBar.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.explorerBar_ItemClick);
            this.explorerBar.NavigationContextMenuInitializing += new Infragistics.Win.UltraWinExplorerBar.NavigationContextMenuInitializingEventHandler(this.explorerBar_NavigationContextMenuInitializing);
            this.explorerBar.NavigationOptionsDialogDisplaying += new Infragistics.Win.UltraWinExplorerBar.NavigationOptionsDialogDisplayingEventHandler(this.explorerBar_NavigationOptionsDialogDisplaying);
            // 
            // imageListLargeEB
            // 
            this.imageListLargeEB.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLargeEB.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListLargeEB.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListSmallEB
            // 
            this.imageListSmallEB.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmallEB.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListSmallEB.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListSmall.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // statusBar
            // 
            this.statusBar.Controls.Add(this.imageSemaphore);
            this.statusBar.Location = new System.Drawing.Point(0, 535);
            this.statusBar.Name = "statusBar";
            ultraStatusPanel1.Key = "ProgressBar";
            appearance1.ForeColor = System.Drawing.Color.Black;
            ultraStatusPanel1.ProgressBarInfo.Appearance = appearance1;
            ultraStatusPanel1.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Progress;
            ultraStatusPanel2.Key = "UserName";
            ultraStatusPanel2.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Automatic;
            ultraStatusPanel3.Key = "Perfil";
            ultraStatusPanel3.Width = 150;
            ultraStatusPanel3.WrapText = Infragistics.Win.DefaultableBoolean.False;
            ultraStatusPanel4.Key = "SystemVersion";
            ultraStatusPanel4.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Automatic;
            ultraStatusPanel5.Control = this.imageSemaphore;
            ultraStatusPanel5.Key = "SemaphoreStatus";
            ultraStatusPanel5.SizingMode = Infragistics.Win.UltraWinStatusBar.PanelSizingMode.Automatic;
            ultraStatusPanel5.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.ControlContainer;
            ultraStatusPanel6.Key = "ProcessMessage";
            ultraStatusPanel6.Width = 250;
            ultraStatusPanel7.Key = "Cotizacion";
            ultraStatusPanel8.Key = "Servidor";
            ultraStatusPanel9.Key = "Database";
            ultraStatusPanel9.Width = 180;
            this.statusBar.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] {
            ultraStatusPanel1,
            ultraStatusPanel2,
            ultraStatusPanel3,
            ultraStatusPanel4,
            ultraStatusPanel5,
            ultraStatusPanel6,
            ultraStatusPanel7,
            ultraStatusPanel8,
            ultraStatusPanel9});
            this.statusBar.Size = new System.Drawing.Size(800, 23);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // toolbarsManager
            // 
            this.toolbarsManager.DesignerFlags = 1;
            this.toolbarsManager.DockWithinContainer = this;
            this.toolbarsManager.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.toolbarsManager.ImageListLarge = this.imageListLarge;
            this.toolbarsManager.ImageListSmall = this.imageListSmall;
            this.toolbarsManager.ShowFullMenusDelay = 500;
            this.toolbarsManager.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2003;
            ultraToolbar1.DockedColumn = 0;
            ultraToolbar1.DockedRow = 0;
            ultraToolbar1.Text = "Menú principal";
            ultraToolbar2.DockedColumn = 0;
            ultraToolbar2.DockedRow = 1;
            ultraToolbar2.Text = "Estándar";
            this.toolbarsManager.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] {
            ultraToolbar1,
            ultraToolbar2});
            this.toolbarsManager.BeforeToolbarListDropdown += new Infragistics.Win.UltraWinToolbars.BeforeToolbarListDropdownEventHandler(this.toolbarsManager_BeforeToolbarListDropdown);
            this.toolbarsManager.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.toolbarsManager_ToolClick);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageSize = new System.Drawing.Size(24, 24);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // _MainForm_Toolbars_Dock_Area_Left
            // 
            this._MainForm_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._MainForm_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._MainForm_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 52);
            this._MainForm_Toolbars_Dock_Area_Left.Name = "_MainForm_Toolbars_Dock_Area_Left";
            this._MainForm_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 483);
            this._MainForm_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolbarsManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Right
            // 
            this._MainForm_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._MainForm_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._MainForm_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(800, 52);
            this._MainForm_Toolbars_Dock_Area_Right.Name = "_MainForm_Toolbars_Dock_Area_Right";
            this._MainForm_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 483);
            this._MainForm_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolbarsManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Top
            // 
            this._MainForm_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._MainForm_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._MainForm_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._MainForm_Toolbars_Dock_Area_Top.Name = "_MainForm_Toolbars_Dock_Area_Top";
            this._MainForm_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(800, 52);
            this._MainForm_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolbarsManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Bottom
            // 
            this._MainForm_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(190)))), ((int)(((byte)(245)))));
            this._MainForm_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._MainForm_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 535);
            this._MainForm_Toolbars_Dock_Area_Bottom.Name = "_MainForm_Toolbars_Dock_Area_Bottom";
            this._MainForm_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(800, 0);
            this._MainForm_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolbarsManager;
            // 
            // ultraTabbedMdiManager
            // 
            this.ultraTabbedMdiManager.MdiParent = this;
            // 
            // ultraDockManager1
            // 
            this.ultraDockManager1.AllowDrop = false;
            this.ultraDockManager1.AutoHideDelay = 100;
            dockAreaPane1.DefaultPaneSettings.AllowPin = Infragistics.Win.DefaultableBoolean.True;
            dockableControlPane1.Control = this.explorerBar;
            dockableControlPane1.FlyoutSize = new System.Drawing.Size(211, -1);
            dockableControlPane1.OriginalControlBounds = new System.Drawing.Rectangle(344, 168, 175, 230);
            dockableControlPane1.Pinned = false;
            dockableControlPane1.Size = new System.Drawing.Size(100, 100);
            dockableControlPane1.Text = "Barra de exploración";
            dockAreaPane1.Panes.AddRange(new Infragistics.Win.UltraWinDock.DockablePaneBase[] {
            dockableControlPane1});
            dockAreaPane1.Size = new System.Drawing.Size(211, 481);
            this.ultraDockManager1.DockAreas.AddRange(new Infragistics.Win.UltraWinDock.DockAreaPane[] {
            dockAreaPane1});
            this.ultraDockManager1.HostControl = this;
            this.ultraDockManager1.ShowCloseButton = false;
            this.ultraDockManager1.ShowDisabledButtons = false;
            this.ultraDockManager1.UseDefaultContextMenus = false;
            this.ultraDockManager1.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            // 
            // _MainFormUnpinnedTabAreaLeft
            // 
            this._MainFormUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._MainFormUnpinnedTabAreaLeft.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MainFormUnpinnedTabAreaLeft.Location = new System.Drawing.Point(0, 52);
            this._MainFormUnpinnedTabAreaLeft.Name = "_MainFormUnpinnedTabAreaLeft";
            this._MainFormUnpinnedTabAreaLeft.Owner = this.ultraDockManager1;
            this._MainFormUnpinnedTabAreaLeft.Size = new System.Drawing.Size(21, 483);
            this._MainFormUnpinnedTabAreaLeft.TabIndex = 18;
            // 
            // _MainFormUnpinnedTabAreaRight
            // 
            this._MainFormUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._MainFormUnpinnedTabAreaRight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MainFormUnpinnedTabAreaRight.Location = new System.Drawing.Point(800, 52);
            this._MainFormUnpinnedTabAreaRight.Name = "_MainFormUnpinnedTabAreaRight";
            this._MainFormUnpinnedTabAreaRight.Owner = this.ultraDockManager1;
            this._MainFormUnpinnedTabAreaRight.Size = new System.Drawing.Size(0, 483);
            this._MainFormUnpinnedTabAreaRight.TabIndex = 19;
            // 
            // _MainFormUnpinnedTabAreaTop
            // 
            this._MainFormUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._MainFormUnpinnedTabAreaTop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MainFormUnpinnedTabAreaTop.Location = new System.Drawing.Point(21, 52);
            this._MainFormUnpinnedTabAreaTop.Name = "_MainFormUnpinnedTabAreaTop";
            this._MainFormUnpinnedTabAreaTop.Owner = this.ultraDockManager1;
            this._MainFormUnpinnedTabAreaTop.Size = new System.Drawing.Size(779, 0);
            this._MainFormUnpinnedTabAreaTop.TabIndex = 20;
            // 
            // _MainFormUnpinnedTabAreaBottom
            // 
            this._MainFormUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._MainFormUnpinnedTabAreaBottom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MainFormUnpinnedTabAreaBottom.Location = new System.Drawing.Point(21, 535);
            this._MainFormUnpinnedTabAreaBottom.Name = "_MainFormUnpinnedTabAreaBottom";
            this._MainFormUnpinnedTabAreaBottom.Owner = this.ultraDockManager1;
            this._MainFormUnpinnedTabAreaBottom.Size = new System.Drawing.Size(779, 0);
            this._MainFormUnpinnedTabAreaBottom.TabIndex = 21;
            // 
            // _MainFormAutoHideControl
            // 
            this._MainFormAutoHideControl.Controls.Add(this.dockableWindow1);
            this._MainFormAutoHideControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MainFormAutoHideControl.Location = new System.Drawing.Point(21, 52);
            this._MainFormAutoHideControl.Name = "_MainFormAutoHideControl";
            this._MainFormAutoHideControl.Owner = this.ultraDockManager1;
            this._MainFormAutoHideControl.Size = new System.Drawing.Size(216, 483);
            this._MainFormAutoHideControl.TabIndex = 22;
            // 
            // dockableWindow1
            // 
            this.dockableWindow1.Controls.Add(this.explorerBar);
            this.dockableWindow1.Location = new System.Drawing.Point(0, 0);
            this.dockableWindow1.Name = "dockableWindow1";
            this.dockableWindow1.Owner = this.ultraDockManager1;
            this.dockableWindow1.Size = new System.Drawing.Size(211, 483);
            this.dockableWindow1.TabIndex = 30;
            // 
            // windowDockingArea1
            // 
            this.windowDockingArea1.Cursor = System.Windows.Forms.Cursors.Default;
            this.windowDockingArea1.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowDockingArea1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowDockingArea1.Location = new System.Drawing.Point(21, 54);
            this.windowDockingArea1.Name = "windowDockingArea1";
            this.windowDockingArea1.Owner = this.ultraDockManager1;
            this.windowDockingArea1.Size = new System.Drawing.Size(216, 481);
            this.windowDockingArea1.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerAlertas});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 26);
            // 
            // VerAlertas
            // 
            this.VerAlertas.Name = "VerAlertas";
            this.VerAlertas.Size = new System.Drawing.Size(113, 22);
            this.VerAlertas.Text = "Ver Alertas";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Alertas MZ ERP";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this._MainFormAutoHideControl);
            this.Controls.Add(this.windowDockingArea1);
            this.Controls.Add(this._MainFormUnpinnedTabAreaTop);
            this.Controls.Add(this._MainFormUnpinnedTabAreaBottom);
            this.Controls.Add(this._MainFormUnpinnedTabAreaLeft);
            this.Controls.Add(this._MainFormUnpinnedTabAreaRight);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Top);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Mz ERP Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.explorerBar)).EndInit();
            this.statusBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarsManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).EndInit();
            this._MainFormAutoHideControl.ResumeLayout(false);
            this.dockableWindow1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}


	    #endregion

		private void MainForm_Load(object sender, System.EventArgs e)
		{
#if DEBUG

			/*string  aux = "VEO Q ESTUVISTE DEMASIADA OCUPADA EN ESTOS DIAS PQ NO HICISTE LOS DEBERES Q TE PEDI. POR ENDE TE LA VOY A COMPLICAR UN POCO CON LAS PISTAS: ESTOY POR TODA LA EMPRESA, MI EDAD ES UN NUEMRO PAR. ESPERO QUE ESTO TE ACLARE UN POCO MAS EL PANORAMA!!!";
			string[] aux1 = aux.Split(new char[]{' '});
			string result = "";
			foreach(string a in aux1)
			{
				
				for(int i=a.Length -1; i >= 0; i--)
				{
					result = result + a[i];
				}
				result = result + " ";
			}
			Console.WriteLine(result);*/
            
			if (!mz.erp.ControlVersion.IsValidVersion())
			{					
				bool salir = Variables.GetValueBool("Sistema.ControlVersion.Salir");
				bool mostrar = Variables.GetValueBool("Sistema.ControlVersion.MostrarMensaje");
				bool actualizar = Variables.GetValueBool("Sistema.ControlVersion.ActualizarVersion");

				if (mostrar)
					System.Windows.Forms.MessageBox.Show( "La versión de la aplicación no coincide con la versión de la base de datos", "Error",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );				
				if (actualizar)
					ActualizarVersion();
				if (salir)
					Application.Exit();
			}
			Splash _splash = new Splash();
			_splash.ShowDialog();
			ultraDockManager1.UnpinAll();
			LogIn _logIn = new LogIn();
			_logIn.ShowDialog( this );

            if (_logIn.DialogResult == DialogResult.OK)
            {
                Security.IdIdioma = 1;
                mz.erp.ui.utility.ToolsLoader.Load(this.toolbarsManager, this.explorerBar, this.ultraDockManager1);
                //explorerBar.Visible = visible;
                //ultraDockManager1.Visible = visible;
                this.ConfigToolsBar();
                //Variables.Load();
                if ((Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault")) != "")
                {
                    ProcessTool(Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault"));
                }

                this.statusBar.Panels["UserName"].Text = "Usuario Actual: " + Security.IdUsuario;
                this.statusBar.Panels["Perfil"].Text = "Perfil: " + Security.Perfil;
                this.statusBar.Panels["SystemVersion"].Text = "Puesto: " + Security.IdPuesto + " - " + Security.Puesto;
                this.statusBar.Panels["Servidor"].Text = systemframework.ApplicationConfiguration.GetServidor();
                this.statusBar.Panels["Database"].Text = systemframework.ApplicationConfiguration.GetDatabase();

                //Cristian tarea 852
                if ((Variables.GetValueBool("Sistema.VisualizaCotizacion")))
                {
                    this.statusBar.Panels["Cotizacion"].Text = "Cotización: " + mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacionPorDefecto(2).ToString();
                }
                //Fin tarea 852



                _allwSemaphore = Variables.GetValueBool("Debug.Semaforo.Habilitado");
                if (_allwSemaphore)
                {
                    this.UpdateApplicationState();
                }
                else
                {
                    this.statusBar.Panels["SemaphoreStatus"].Visible = false;
                    this.statusBar.Panels["SemaphoreStatus"].Visible = false;
                }
                if (Variables.GetValueBool("System.PermiteCierreSesionAutomatico"))
                {
                    this.InitializeTimer();
                }
                /* Silvina 20110712 - Tarea 0000121 */
                bool visualizaAlertas = Variables.GetValueBool("Alertas.CuentaCorriente.VisualizaAlertas");
                if (visualizaAlertas)
                    InicializarAlertas();
                /* Fin Silvina 20110712 - Tarea 0000121 */

                //German 20120608 - Tarea 0000350
                string path = mz.erp.systemframework.Util.ResourcePath() + @"\Resources\Icons\Fondo.jpg";
                if (System.IO.File.Exists(path))
                {
                    this.BackgroundImage = Image.FromFile(path);
                    this.BackgroundImageLayout = ImageLayout.Center;
                }
                //Fin German 20120608 - Tarea 0000350
                
            }
            else
            {
                Application.Exit();
            }

#else
				/*Splash _splash = new Splash();
				_splash.ShowDialog();*/

				/*LogIn _logIn = new LogIn();
				_logIn.ShowDialog( this );

				if ( _logIn.DialogResult == DialogResult.OK )
				{
					//Security.IdPerfil = _logIn.pe;
					Security.IdIdioma = 1;
					utility.ToolsLoader.Load( this.toolbarsManager, this.explorerBar );
					//this.InitializeTimer();					
				}
				else
				{
					Application.Exit();
				}*/
				Security.IdUsuario = "rgomez";
				Security.IdPerfil = 1;
				Security.IdIdioma = 1;
				Security.IdEmpresa= 1;
				Security.IdSucursal = 1;
				utility.ToolsLoader.Load( this.toolbarsManager, this.explorerBar );
				
#endif
			



		}

        /* Silvina 20110712 - Tarea 0000121 */
        FrmAlertas alertas;
        private void InicializarAlertas()
        {
            alertas = new FrmAlertas();
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.BalloonTipClicked += new System.EventHandler(notifyIcon1_BalloonTipClicked);
            timerAlertas.Tick += new System.EventHandler(timerAlertas_Tick);
            VerAlertas.Click += new EventHandler(VerAlertas_Click);
            timerAlertas.Interval = alertas.TiempoDeActualizacion() * (60000);
            timerAlertas.Enabled = true;
            timerAlertas.Start();
            MostrarAlertas();
        }

        private void VerAlertas_Click(object sender, EventArgs e)
        {
            alertas.ActualizarDatos();
            alertas.Show();
        }

        private void MostrarAlertas()
        {
            alertas.ActualizarDatos();
            if (alertas.HayAlertas())
            {
                notifyIcon1.BalloonTipText = "Existen alertas en las Cuentas Corrientes.";
                SystemSounds.Beep.Play();
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void timerAlertas_Tick(object sender, EventArgs e)
        {
            MostrarAlertas();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            alertas.ActualizarDatos();
            alertas.Show();
        }

        /* Fin Silvina 20110712 - Tarea 0000121 */

		private void ConfigToolsBar()
		{
			this.toolbarsManager.ToolbarSettings.AllowCustomize = Infragistics.Win.DefaultableBoolean.False;
			this.toolbarsManager.ToolbarSettings.AllowDockBottom = Infragistics.Win.DefaultableBoolean.False;
			this.toolbarsManager.ToolbarSettings.AllowDockLeft = Infragistics.Win.DefaultableBoolean.False;
			this.toolbarsManager.ToolbarSettings.AllowDockRight = Infragistics.Win.DefaultableBoolean.False;
			this.toolbarsManager.ToolbarSettings.AllowDockTop = Infragistics.Win.DefaultableBoolean.False;
			this.toolbarsManager.ToolbarSettings.AllowFloating = Infragistics.Win.DefaultableBoolean.False;
			this.toolbarsManager.ToolbarSettings.AllowHiding = Infragistics.Win.DefaultableBoolean.False;
			Infragistics.Shared.ResourceCustomizer rc =Infragistics.Win.UltraWinToolbars.Resources.Customizer;
			
			//Internacionalizacion de Strings en las toolbars
			rc.SetCustomizedString("CustomizeDialog_NewToolbar","JAJAJAJA, LO LOGRE");			
			
			this.toolbarsManager.LockToolbars = true;
			
			this.explorerBar.GroupSettings.AllowEdit = Infragistics.Win.DefaultableBoolean.False;
            //German 20110321 - Tarea 0000092
            this.toolbarsManager.ToolbarSettings.UseLargeImages = Infragistics.Win.DefaultableBoolean.True;
            //Fin German 20110321 - Tarea 0000092

            

		}

		private void InitializeTimer()
		{	
			//_FormCerrarSesion = false; 
			_timer.Interval = Convert.ToInt32(Variables.GetValueStringWithoutCache("System.TiempoDeSesion"));
			_timer.Tick += new EventHandler(_timer_Tick);
			//_timerForSemaphore.Interval = Convert.ToInt32(Variables.GetValueString("Debug.TimerParaSemaforo.Intervalo"));
			//_timerForSemaphore.Tick += new EventHandler(_timerForSemaphore_Tick);
			//_timerForSemaphore.Start();
			//_timerParpadeo.Interval =500;
			//_timerParpadeo.Tick +=new EventHandler(_timerParpadeo_Tick);
		}

		private void toolbarsManager_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
		{
			ProcessTool( e.Tool.Key );
		}

		private void explorerBar_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
			
			ProcessTool( e.Item.Key );
		}

		private void ProcessTool( string key )
		{								
			System.Console.WriteLine(new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64("HXuZXRnn4NafZnzzDmcdLA=="));
			System.Console.WriteLine("oTRA pRUEBA");
			this.Cursor = Cursors.WaitCursor;
			System.Console.WriteLine(key);
			switch ( key )
			{	
					#region Sesión				

				case "ProcesoIniciarSesion"://"Cerrar Sesion":
					this.CerrarSesion();
					break;
				/*case "ProcesoCambiarContraseña"://"Cambiar contraseña":
					CallProcess(key);			
					break;	
				case "ProcesoReestablecerContrasenia"://"Cambiar contraseña":
					CallProcess(key);			
					break;	*/
				case "ProcesoSalir"://"Salir":
					Application.Exit();
					break;
				
					#endregion
		
					#region Compras 
				
				case "ProcesoCompraConsultaArticulos"://"Consulta de Articulos":
					//FilterDocumentLoader( typeof( mz.erp.ui.tsh_Productos),null,typeof(mz.erp.ui.forms.FrmConsultaArticulos),"Consulta de Stock y Precios");
					
					mzProductosSearchForm sfcompras = new mzProductosSearchForm(false,"F3");
					sfcompras.ShowDialog();
					//sfcompras.MdiParent = this;
					//sfcompras.Show();
					
					/*
					Form1 f = new Form1();
					f.MdiParent = this;
					f.Show();
					Form1 f1 = new Form1();
					f1.ShowDialog();
					*/
					break;

				case "ProcesoComprasPedidosConfirmarYEnviar": //"Logitica Pedidos a Proveedores Cerrar Pedido":
				{
					ComprobanteDeCompraLoader("Pedir");
					break;
				}
	
				/*case "ProcesoConsultarStockNDias":
				{
					CallProcess("ProcesoConsultarStockNDias");
					break;
				}*/

				case "ProcesoComprasPedidoGenerarPedido": //"Logistica Pedidos a Proveedores Nuevo Pedido": //????
				{
					ComprobanteDeCompraLoader("Prepedir");
					break;
				}

				case "ProcesoComprasIngresoDeRemito":
				{
					CallProcess("ProcesoIngresarMercaderia");
					break;
				}

				/*case "ProcesoRegistrarNumerosDeSeriesPendientes":
				{
					CallProcess("ProcesoRegistrarNumerosDeSeriesPendientes");
					break;
				}*/

				/*case "ProcesoConfirmarIngresoMercaderia":
				{
					CallProcess("ProcesoConfirmarIngresoMercaderia");
					break;
				}*/

				case "ComprasProcesoModificarPrecioProducto":
				{
					CallProcess("ProcesoModificarPrecioProducto");
					break;
				}

				/*case "ProcesoModificarPreciosMasivo":
				{
					CallProcess("ProcesoModificarPreciosMasivo");
					break;
				}*/
				case "ProcesoCuentaCorrienteProveedor":
				{					
					FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteProveedor", "");
					frmcc.MdiParent = this;
					frmcc.Show();
					break;
				}

				case "ProcesoCuentaCorrienteProveedorDV":
				{					
					FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteProveedorDV", "");
					frmcc.MdiParent = this;
					frmcc.Show();
					break;
				}

				case "ProcesoCuentaCorrienteProveedoresConsolidada":
				{					
					FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteProveedoresConsolidada", "");
					frmcc.MdiParent = this;
					frmcc.Show();
					break;
				}


				/*case "ProcesoModificarProductosMasivo":
				{
					CallProcess("ProcesoModificarProductosMasivo");
					break;
				}*/

				case "ProcesoConsultaProveedoresObservaciones"://"Consulta de Observaciones de proveedor":					
					mz.erp.ui.forms.mzCuentasObservacionesSearchForm csf = new mz.erp.ui.forms.mzCuentasObservacionesSearchForm("PROVEEDOR");					
					csf.ShowForm();//Dialog();

					break;

			    case "ProcesoModificarPreciosMasivoDesdeExcel":
				{
					CallProcess("ProcesoModificarPreciosMasivoDesdeExcel");
					break;
				}

				case "ProcesoAutorizarFacturasCompras":
				{
					CallProcess("ProcesoAutorizarFacturasCompras");
					break;
				}

				#endregion

					#region Compras / Consultas
				case "ProcesoComprasConsultaListadoDeIngreso":
				{		
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-10));
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha", true, mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian					
                    array.Add( "Proveedor","Proveedor",true,null);
					array.Add( "Responsable","Responsable de Emisión",true,null);
					array.Add( "NumeroComprobante","Nº Remito",true,string.Empty);
					array.Add( "aux1","Nº Factura",true,string.Empty);
					FrmConsultas frmConsultas5 = ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeIngreso), "Listado de Ingreso", array, typeof( mz.erp.ui.forms.FrmConsultas ), false, true,new ArrayList(),false,"Total"); 
					frmConsultas5.SetProcess(key);
					frmConsultas5.Show();
					break;
				}
				case "ProcesoComprasConsultaListadoComprasPorArticulo":
				{	
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-10));
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha", true, mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian					
                    array.Add( "Producto","Producto",true,null);
					array.Add( "Proveedor","Proveedor",true,null);
					array.Add( "NumeroComprobante","Nº Remito",true,string.Empty);
					array.Add( "aux1","Nº Factura",true,string.Empty);
					FrmConsultas frmConsultas6 =  ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeComprasPorArt), "Listado de Compras por Artículo", array, typeof( mz.erp.ui.forms.FrmConsultas ), new mz.erp.ui.controllers.DetalleArticulosPorCompra()); 
					frmConsultas6.SetProcess(key);
					frmConsultas6.Show();
					break;
				}
				/*case "ProcesoConsultaSeguimientos":
				{
					CallProcess("ProcesoConsultaSeguimientos");
					break;
				}*/
				case "ComprasProcesoConsultarProductosNumerosDeSerie":
				{
					CallProcess("ProcesoConsultarProductosNumerosDeSerie");
					break;
				}
				/*case "ProcesoConsultarComprasListaDePrecios":
				{
					CallProcess("ProcesoConsultarComprasListaDePrecios");
					break;
				}*/
	
				case "ProcesoConsultarRentabilidadProductos":
				{
					CallProcess("ProcesoConsultarRentabilidadProductos");
					break;
				}
				case "ProcesoConsultarComprobantesDeCompraPorNumeroDeSerie":
				{
					CallProcess("ProcesoConsultarComprobantesDeCompraPorNumeroDeSerie");
					break;
				}

				case "ProcesoConsultarListasDePreciosCompras":
				{
					this.CallProcess( "ProcesoConsultarListasDePreciosCompras" );  
					break;
				}

				case "ProcesoConsultarListasDePreciosProveedores":
				{
					this.CallProcess( "ProcesoConsultarListasDePreciosProveedores" );  
					break;
				}
				case "ProcesoConsultarRetencionesProveedores":
				{
					this.CallProcess( "ProcesoConsultarRetencionesProveedores" );  
					break;
				}

				case "ProcesoConsultarSeguimientoCompras":
				{
					this.CallProcess( "ProcesoConsultarSeguimientoCompras" );  
					break;
				}

				case "ProcesoConsultarProductosConPreciosModificados":
				{
					CallProcess("ProcesoConsultarProductosConPreciosModificados");
					break;
				}

					#endregion

					#region Stock
			
				case "ProcesoIngresoStockParaReposicion":
					FrmIngresoMercParaReposicion stockParaReposicion = new FrmIngresoMercParaReposicion();
					stockParaReposicion.MdiParent = this;
					stockParaReposicion.ShowForm(null, "NUEVO", "Ingreso de Mercadería Para Reposición");
					break;	

					
				case "ProcesoTransferenciaMercaderiaAST":
				{
					CallProcess("ProcesoTransferenciaMercaderiaAST");
					break;
				}

				case "ProcesoTransferenciaInternaDeStock":
				{
					CallProcess("ProcesoTransferenciaInternaDeStock");
					break;
				}
						
				case "ProcesoDevolucionMercaderiaAST":
				{
					CallProcess("ProcesoDevolucionMercaderiaAST");
					break;
				}

					#endregion

					#region Stock / Ajuste De Stock
					
				case "ProcesoStockACero"://"StockACero":
					FrmStockACero frm = new FrmStockACero();
					frm.MdiParent = this;
					frm.ShowForm(null, "NUEVO", "Stock a cero");
					break;	

				case "ProcesoIngresoStock": //"Ajuste de Stock": 
					/*
					FrmAjusteDeStock frmAjuste = new FrmAjusteDeStock("+");
					frmAjuste.MdiParent = this;
					frmAjuste.ShowForm(null, "NUEVO", "Ajuste de Ingreso de Stock");
					*/
					CallProcess("ProcesoAjustarStockPositivo");

					break;						
				
				case "ProcesoEgresoStock": //"Ajuste de Stock":
					/*
					FrmAjusteDeStock frmAjuste2 = new FrmAjusteDeStock("-");
					frmAjuste2.MdiParent = this;
					frmAjuste2.ShowForm(null, "NUEVO", "Ajuste de Egreso de Stock");
					*/
					CallProcess("ProcesoAjustarStockNegativo");

					break;						
				
				case "ProcesoRecomponerStock"://"Actualizar stock":
				{
					DialogResult result;
					result = MessageBox.Show("¿Desea ejecutar recomposición de stock?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(result == DialogResult.Yes)
					{					
						this.Cursor = Cursors.WaitCursor;
						businessrules.Stock.RecomponerStock();
						this.Cursor = Cursors.Default;
					}				
					
					break;
				}
				
					#endregion

					#region Stock / Consultas

				case "ProcesoReporteConsultarStock"://"Reportes Reporte de Stock":
				{	
				
					FrmParameterReports frmPR = new FrmParameterReports("ReportStock.RPX");
					frmPR.ShowDialog();					
										
				}
					break;

				case "ProcesoConsultarStock"://"Reportes Reporte de Stock":
				{	
				
					/*
					FrmParameterReports frmPR = new FrmParameterReports("ReportStock.RPX");
					frmPR.ShowDialog();					
					*/
					CallProcess("ProcesoConsultarStock");
				}
					break;

				case "ProcesoConsultarValorizacionDeStock":
				{					
					CallProcess("ProcesoConsultarValorizacionDeStock");				
				}
					break;

				case "ProcesoMovimientos"://"Listado de Movimentos de Stock":
				{ 
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha", true, mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian					//array.Add( "Persona","Responsable de Emisión",true,null);
					array.Add( "Responsable","Responsable de Emisión",true,null);
					array.Add( "Producto","Producto", true, null);
					array.Add( "TipoDeAjuste", "Tipo de Ajuste", true,null);
                    //Cristian Tarea 0000010 20110224
                    array.Add("Deposito", "Deposito", true, null);
                    array.Add("Seccion", "Seccion", true, null);
                    //Fin Cristian
					FrmConsultas frmConsultas7 = ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeMovimientosDeStock), "Listado de Movimientos de Stock", array, typeof( mz.erp.ui.forms.FrmConsultas )); 
					frmConsultas7.SetProcess(key);
					frmConsultas7.Show();
					break;
				}
				case "ProcesoConsultarAjustes"://"Listado de Ajustes de Stock":
				{					
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha", true, mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian					//array.Add( "Persona","Responsable de Emisión",true,null);
					array.Add( "Responsable","Responsable de Emisión",true,null);
					array.Add( "Producto","Producto", true, null);
					array.Add( "TipoDeAjuste", "Tipo de Ajuste", true,null);
					FrmConsultas frmConsultas8 = ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeAjustesDeStock), "Listado de Ajustes de Stock", array, typeof( mz.erp.ui.forms.FrmConsultas ),false,false,new ArrayList(),true,null, new mz.erp.ui.controllers.NumerosDeSeriesPorAjusteDeStock()); 
					frmConsultas8.SetProcess(key);
					frmConsultas8.Show();
					break;
				}
				case "ProcesoStockConsArticDesacConStock": //"Listado de Artículos desactivados con Stock":
				{
					string aux = "Temporal";
					System.Console.WriteLine((string) (aux.Substring(1,3)));
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					FrmConsultas frmConsultas9 = ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeArtDesacConStock), "Listado de Artículos Desactivados con Stock",array , typeof( mz.erp.ui.forms.FrmConsultas )); 
					frmConsultas9.SetProcess(key);
					frmConsultas9.Show();
					break;
				}

				case "ProcesoDebajoDelMinimo" :
				{
					FrmParameterReports frmPDM = new FrmParameterReports("ReportStockDebajoMinimo.RPX");
					frmPDM.ShowDialog();
					break;
				}

				case "ProcesoStockConsultasMovimientosJerarquia" ://"Stock"
				{
					CallProcess("ProcesoConsultaMovimientosStockPorJerarquias");
					break;
				}
				case "StockProcesoConsultarProductosNumerosDeSerie":
				{
					CallProcess("ProcesoConsultarProductosNumerosDeSerie");
					break;
				}
				

					#endregion

					#region Ventas

				case "ProcesoConsultaArticulos"://"Consulta de Articulos":
					//FilterDocumentLoader( typeof( mz.erp.ui.tsh_Productos),null,typeof(mz.erp.ui.forms.FrmConsultaArticulos),"Consulta de Stock y Precios");
					mzProductosSearchForm sf = new mzProductosSearchForm(false);
					sf.SetProcess("ProcesoConsultarProductos", "ConsultarProductos", "V");
					sf.ShowDialog();					
					break;

				case "ProcesoConsultaCuentas"://"Consulta de Articulos":
					mz.erp.ui.forms.mzCuentasSearchForm _formmzCuentasSearchForm = new mz.erp.ui.forms.mzCuentasSearchForm();
					//_form.MdiParent = this;
					_formmzCuentasSearchForm.Init(true, true, false);
					_formmzCuentasSearchForm.ShowDialog();
					break;				
					


				case "ProcesoConsultaCuentasObservaciones"://"Consulta de Observaciones de cuenta":					

					mz.erp.ui.forms.mzCuentasObservacionesSearchForm opf = new mz.erp.ui.forms.mzCuentasObservacionesSearchForm("CUENTA");					
					opf.ShowForm();//Dialog();


					break;

				case "ProcesoPreciosActualizados"://"Precios Actualizados":
				{//ST ubicacion: Procesos/Precios actualizados
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha", true, mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian													
					FrmConsultas frmConsultas11 = ReportDocumentLoader( typeof( mz.erp.ui.forms.classes.tsh_ReportesAcutalizacionDePrecios), "Actualización de precios", array, typeof( mz.erp.ui.forms.FrmAbmExProductos)); 
					frmConsultas11.SetProcess(key);
					frmConsultas11.Show();

					break;
				}
				case "Autorizaciones":
				{
					CallProcess("ProcesoAutorizar");
					break;
				}
					#endregion

					#region Ventas / Emitir Comprobantes

				case "ProcesoEditarPresupuestar"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoEditarPresupuestar");
					break;

				case "ProcesoEditarPresupuestarAceptado"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoEditarPresupuestarAceptado");
					break;

				case "ProcesoEditarPresupuestarNOAceptado"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoEditarPresupuestarNOAceptado");
					break;

				case "ProcesoEditarPresupuestarRealizado"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoEditarPresupuestarRealizado");
					break;

				case "ProcesoEditarPresupuestarRechazado"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoEditarPresupuestarRechazado");
					break;

				case "ProcesoPresupuestarRechazadoPresupuestarRechazado"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoPresupuestarRechazadoPresupuestarRechazado");
					break;


				case "ProcesoAnularPresupuestar"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoAnularPresupuestar");
					break;

				case "ProcesoPresupuestarPresupuestar"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoPresupuestarPresupuestar");
					break;

				case "ProcesoPresupuestarAceptadoPresupuestarAceptado"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoPresupuestarAceptadoPresupuestarAceptado");
					break;

					
				case "ProcesoPresupuestarRealizadoPresupuestarRealizado"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoPresupuestarRealizadoPresupuestarRealizado");
					break;



				case "ProcesoArmarEquipoNuevoPrevender"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoArmarEquipoNuevoPrevender");
					break;

				case "ProcesoPresupuestar"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoPresupuestar");
					break;

				case "ProcesoPreprestar":
					CallProcess("ProcesoPreprestar");
					break;

				case "ProcesoRepararPrevender"://"Facturar Orden de Reparacion":			
					
					CallProcess("ProcesoRepararPrevender");
					break;
				case "ProcesoCopiaDePresupuesto"://"Ventas Emitir Comprobantes Copia de Presupuestos":
				{
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta",true,null);
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);						
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Presupuestos");
						
					ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesPendientes), "Copia de Presuspuestos", array, typeof( mz.erp.ui.forms.FrmComprobantes ), typeof(mz.erp.ui.forms.FrmComprobantesSelectN),true , "Presupuestar");*/
					this.CallProcess( "ProcesoCopiaDePresupuesto" );
					break;
				}
				case "ProcesoPrevender"://"Prefacturas":				
					//ComprobanteDeVentaLoader( "Prevender" );
					CallProcess( "ProcesoPrevender" );
					break;

				case "ProcesoPrefacturaDesdePresupuesto"://"Prefactura desde presupuesto":
				{
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta",true,null);
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);						
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Presupuestos");		
					ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesPendientes), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ), typeof(mz.erp.ui.forms.FrmComprobantesSelectN),true );					*/
					this.CallProcess( "ProcesoPrefacturaDesdePresupuesto" );
					break;
				}

				case "ProcesoVenderManual"://"FacturasManuales":		
					//ComprobanteDeVentaLoader( "VenderManual" );
					CallProcess( "ProcesoVenderManual" );
					break;
					
					
				case "ProcesoPrestar"://"Prestamos":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPrestar");
					break;
				}
				case "ProcesoAnularPrevender":
				{
					CallProcess("ProcesoAnularPrevender");
					break;
				}
				case "ProcesoAnularPreprestar":
				{
					CallProcess("ProcesoAnularPreprestar");
					break;
				}
				case "ProcesoArmarEquipoNuevoPreprestar"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoArmarEquipoNuevoPreprestar");
					break;


				case "ProcesoRepararPreprestar"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoRepararPreprestar");
					break;

				case "ProcesoRemitirPreprestar"://"Presupuestos":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoRemitirPreprestar");
					break;

				case "ProcesoEntregarPreprestar"://"Remitos internos":								
					CallProcess("ProcesoEntregarPreprestar");
					break;

				case "ProcesoRemitirPrevender":
					//ComprobanteDeVentaLoader( "Presupuestar" )
					CallProcess("ProcesoRemitirPrevender");
					break;


				case "ProcesoRecargarPreprestar":
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoRecargarPreprestar");
					break;

				case "ProcesoRecargarPrevender":			
					//ComprobanteDeVentaLoader( "Presupuestar" );
					CallProcess("ProcesoRecargarPrevender");
					break;



				case "ProcesoAnularRemitir"://"Prestamos":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoAnularRemitir");
					break;
				}

				case "ProcesoPrevenderPrevender"://"Prestamos":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPrevenderPrevender");
					break;
				}


				case "ProcesoPrevenderPrestar"://"Factura DV desde prefactura":
				{	
					CallProcess("ProcesoPrevenderPrestar");
					break;
				}

				case "ProcesoPreprestarPreprestar"://"Prestamos":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPreprestarPreprestar");
					break;
				}

				case "ProcesoPrevenderBienDeUso"://"Prestamos":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPrevenderBienDeUso");
					break;
				}

				case "ProcesoPrevenderVenderBienDeUso"://"Prestamos":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPrevenderVenderBienDeUso");
					break;
				}
				case "ProcesoPedir"://"Pedidos de Clientes":
				{						
					CallProcess("ProcesoPedir");
					break;
				}
				case "ProcesoPedirInterno"://"Pedidos interno":
				{						
					CallProcess("ProcesoPedirInterno");
					break;
				}

				case "ProcesoPresupuestarPresupuestarRealizado"://"Pedidos de Clientes":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPresupuestarPresupuestarRealizado");
					break;
				}

				case "ProcesoPresupuestarPresupuestarAceptado"://"Pedidos de Clientes":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPresupuestarPresupuestarAceptado");
					break;
				}

				case "ProcesoPresupuestarPresupuestarNOAceptado"://"Pedidos de Clientes":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPresupuestarPresupuestarNOAceptado");
					break;
				}

				case "ProcesoPresupuestarRealizadoPresupuestarRechazado"://"Pedidos de Clientes":
				{	
					//ComprobanteDeVentaLoader("Prestar");
					CallProcess("ProcesoPresupuestarRealizadoPresupuestarRechazado");
					break;
				}


				case "ProcesoPrerendir"://"Prerendir":
				{					
					CallProcess("ProcesoPrerendir");
					break;
				}


				case "ProcesoAnularPrerendir"://"AnularPrerendir":
				{					
					CallProcess("ProcesoAnularPrerendir");
					break;
				}

				case "ProcesoPrerendirRendir"://"PrerendirRendir":
				{					
					CallProcess("ProcesoPrerendirRendir");
					break;
				}

					
				case "ProcesoRemitirVender"://"PrerendirRendir":
				{					
					CallProcess("ProcesoRemitirVender");
					break;
				}
					
					#endregion

					#region Ventas / Cuentas Corrientes
			
				case "ProcesoCuentaCorrienteClienteVieja":
					FrmVisualizacionCuentaCorriente frmVCC= new FrmVisualizacionCuentaCorriente("ProcesoCuentaCorrienteCliente");
					frmVCC.MdiParent= this;
					frmVCC.Show();
					break;

				case "ProcesoCuentaCorrienteCliente":
				{					
					FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteCliente", "");
					frmcc.MdiParent = this;
					frmcc.Show();
					break;
				}

				case "ProcesoCuentaCorrienteClienteConsolidada":
				{					
					FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteClienteConsolidada", "");
					frmcc.MdiParent = this;
					frmcc.Show();
					break;
				}

				case "ProcesoCuentaCorrienteGeneral"://"Cuenta Corriente General": 
					CallProcess( "ProcesoCuentaCorrienteGeneral" );										
					break;

				case "ProcesoCuentaCorrienteGeneralDV"://"Cuenta Corriente General DV": 
					CallProcess( "ProcesoCuentaCorrienteGeneralDV" );
					break;

				case "ProcesoCuentaCorrienteClienteDVAnterior":
				{
					FrmVisualizacionCuentaCorriente frmVCCdv= new FrmVisualizacionCuentaCorriente("ProcesoCuentaCorrienteClienteDV");
					frmVCCdv.MdiParent= this;
					frmVCCdv.Show();
				}
					break;

				case "ProcesoCuentaCorrienteClienteDV":
				{
					FrmCuentaCorriente frmCC = new FrmCuentaCorriente("ProcesoCuentaCorrienteClienteDV", "");
					frmCC.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					frmCC.Show();
				}
					break;

				case "ProcesoPagoACuenta": 
					CallProcess( "ProcesoPagar" );
					break;

				case "ProcesoNotaDeCreditoManual": 
					CallProcess( "ProcesoNotaDeCreditoManual" );
					break;
					
				case "ProcesoVenderDevolver"://"Notas de Credito de factura";
					CallProcess( "ProcesoVenderDevolver" );
					break;

				case "ProcesoVenderDevolverBienDeUso"://"Notas de Credito de factura bien de uso";
					CallProcess( "ProcesoVenderDevolverBienDeUso" );
					break;

				case "ProcesoNotaDeCredito"://"Notas de Credito";
					CallProcess( "ProcesoNotaDeCredito" );
					break;

				case "ProcesoPredevolver"://"Prenota de credito";
					CallProcess( "ProcesoPredevolver" );
					break;


				case "ProcesoVenderPredevolver"://"Prenota de credito de factura";
					CallProcess( "ProcesoVenderPredevolver" );
					break;


				case "ProcesoPredevolverDevolver"://"Emision de prenotas de crédito";
					CallProcess( "ProcesoPredevolverDevolver" );
					break;



				case "ProcesoAnularPredevolver"://"Anulación de prenotas de crédito";
					CallProcess( "ProcesoAnularPredevolver" );
					break;					

				case "ProcesoAcreditarCuentaCorriente"://"Creditos";
					CallProcess( "ProcesoAcreditarCuentaCorriente" );
					break;

				case "ProcesoDebitarCuentaCorriente"://"Debitos";
					CallProcess( "ProcesoDebitarCuentaCorriente" );
					break;


				case "ProcesoAcreditarCuentaCorrienteDV"://"Creditos DV";
					CallProcess( "ProcesoAcreditarCuentaCorrienteDV" );
					break;

				case "ProcesoDebitarCuentaCorrienteDV"://"Debitos DV";
					CallProcess( "ProcesoDebitarCuentaCorrienteDV" );
					break;

				case "ProcesoDevolverPago"://"Creditos";
					CallProcess( "ProcesoDevolverPago" );
					break;

				case "ProcesoDevolverPagoDV"://"Debitos";
					CallProcess( "ProcesoDevolverPagoDV" );
					break;
				case "ProcesoPrestarDevolver":
					CallProcess( key );
					break;
					
				case "ProcesoNotaDeCreditoDV": 
					CallProcess( "ProcesoNotaDeCreditoDV" );
					break;

					/*ProcesoNotaDeDebito*/
					#endregion

					#region Ventas / Consultas
				
				case "ProcesoConsultaCompDeVenta"://"Consulta de Comprobantes":
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta");
					array.Add( "Fecha","Desde Fecha");
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha");
                    //Fin Cristian
					array.Add( "Persona","Responsable de Emisión");
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",true,"Facturas");
					FrmConsultas frmConsultas12 = ReportDocumentLoader( typeof( mz.erp.ui.forms.classes.tsa_ReporteComprobantesDeVenta), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ));
					frmConsultas12.SetProcess(key);
					frmConsultas12.Show();
					break;
				}

				case "ProcesoConsultaPresupuestos"://"Consulta de Presupuestos":
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta",true,null);
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha", true, mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian
					array.Add( "Persona","Responsable de Emisión",true,null);
						
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Presupuestos");
						
					FrmConsultas frmConsultas13 = ReportDocumentLoader( typeof( mz.erp.ui.forms.classes.tsa_ReporteComprobantesDeVenta), "Presupuestos", array, true);
					frmConsultas13.SetProcess(key);
					frmConsultas13.Show();

					break;
				}
	
				case "ProcesoConsultaCompPorDetalle": //"Ventas Consultas Detalle Comprobantes":
				{
					CallProcess("ProcesoConsultarDetalleComprobantes");
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta");
					array.Add( "Fecha","Desde Fecha");
					array.Add( "Fecha","Hasta Fecha");
					array.Add( "Persona","Responsable de Emisión");
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",true,"Facturas");
					ArrayList grupos = new ArrayList();
					grupos.Add("Descripcion"); //es el comprobante
					grupos.Add("Numero");					
					ReportDocumentLoaderSA( typeof( mz.erp.ui.forms.classes.tsa_ReporteDetalleComprobanteDeVenta), "Detalle de Comprobantes de Venta", array, false, grupos, true, "Total");*/
					break;
				}

				case "ProcesoConsultaCompDV": //"Ventas Consultar Comprobantes DV":
				{
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta");
					array.Add( "Fecha","Desde Fecha");
					array.Add( "Fecha","Hasta Fecha");
					array.Add( "Persona","Responsable de Emisión");
					array.Add( "TipoDeComprobanteAgrupadoDV","Tipos de Comprobantes",true,"Facturas DV");
					ReportDocumentLoader( typeof( mz.erp.ui.forms.classes.tsa_ReporteDetalleComprobanteDeVentaDV), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ));
					//ReportDocumentLoader( typeof( mz.erp.ui.forms.classes.tsa_ReporteComprobantesDeVenta), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ));
					break;*/
					CallProcess( "ProcesoConsultarCompDV" );
				}
					break;

				case "ProcesoConsultaOtrosComprobantes"://Ventas / consultas / otros comprobantes
				{
					CallProcess( "ProcesoConsultaOtrosComprobantes" );					
					break;
				}
				case "ProcesoConsultarRentabilidadEquiposUsuarios"://Ventas / consultas / otros comprobantes
				{
					CallProcess( "ProcesoConsultarRentabilidadEquiposUsuarios" );
					break;
				}

				case "ProcesoConsultarPresupuestosRealizadosPendientes"://Ventas / consultas / otros comprobantes
				{
					CallProcess( "ProcesoConsultarPresupuestosRealizadosPendientes" );
					break;
				}

				case "ProcesoConsultarPresupuestosAceptadosRechazadosPendientesDeRealizacion"://Ventas / consultas / otros comprobantes
				{
					CallProcess( "ProcesoConsultarPresupuestosAceptadosRechazadosPendientesDeRealizacion" );
					break;
				}

				case "ProcesoConsultarPresupuestosPendientesAceptacion"://Ventas / consultas / otros comprobantes
				{
					CallProcess( "ProcesoConsultarPresupuestosPendientesAceptacion" );
					break;
				}

				case "ProcesoConsultarAbonosPendientes"://Ventas / consultas / otros comprobantes
				{
					CallProcess( "ProcesoConsultarAbonosPendientes" );
					break;
				}

				case "ProcesoConsultarDetalleComprobantesEntregas": //"Ventas Consultas Detalle Comprobantes Entrega":
				{
					CallProcess("ProcesoConsultarDetalleComprobantesEntregas");
					break;
				}



					#endregion

					#region Caja
				
				case "ProcesoPrevenderVender":
				{
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
						array.Add( "Cuenta","Cuenta",true,null);
						array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30));
						array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
						array.Add( "Persona","Responsable de Emisión",true,null);						
						array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Prefacturas");
						ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesPendientes), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ), typeof(mz.erp.ui.forms.FrmComprobantesSelectN),true );*/
					this.CallProcess( "ProcesoPrevenderVender" );  
				}
					break;

				case "CajaProcesoVenderManual":
				{
					
					this.CallProcess( "ProcesoVenderManual" );  
				}
					break;
				case "ProcesoPrevenderVenderManual":
				{
					
					this.CallProcess( "ProcesoPrevenderVenderManual" );  
				}
					break;
				case "ProcesoPresupuestarVenderManual":
				{
					
					this.CallProcess( "ProcesoPresupuestarVenderManual" );  
				}
					break;
				case "ProcesoPresupuestarVender":
				{
					
					this.CallProcess( "ProcesoPresupuestarVender" );  
				}
					break;

				case "ProcesoPresupuestarPrestar":
				{
					
					this.CallProcess( "ProcesoPresupuestarPrestar" );  
				}
					break;


				case "ProcesoPreprestarPrestar":
				{
					this.CallProcess( "ProcesoPreprestarPrestar" );  
				}
					break;

				case "ProcesoCajaPagosCuentaCorriente"://"Caja Pagos a Cuenta":
					CallProcess( "ProcesoPagar" );
					break;

				case "ProcesoPagoACuentaDV"://"Caja Pagos a Cuenta":
				{
					
					CallProcess( "ProcesoPagoACuentaDV" );
				}
					break;
				
				case "ProcesoPrepararDiferidoVenderManual"://"Caja Pagos a Cuenta":
				{	
					CallProcess( "ProcesoPrepararDiferidoVenderManual" );
				}
					break;

				case "ProcesoPrepararDiferidoPrestar"://"Caja Pagos a Cuenta":
				{	
					CallProcess( "ProcesoPrepararDiferidoPrestar" );
				}break;
				

				case "CajaProcesoRemitirVender"://"Caja Pagos a Cuenta":
				{	
					CallProcess( "ProcesoRemitirVender" );
				}
					
					break;

					#endregion

					#region Caja / Control de Caja

				case "ProcesoCajaAperturaDeCaja"://"Apertura de Caja":
					FrmAperturaCaja formCaja = new FrmAperturaCaja();
					formCaja.MdiParent = this;					
					formCaja.Show();					
					break;
				
				case "ProcesoCajaCierreDeCaja"://"Cierre de Caja":
					FrmCierreCaja formCierreCaja= new FrmCierreCaja();
					formCierreCaja.MdiParent = this;
					formCierreCaja.Show();
					break;
				case "ProcesoCajasEstadoActual":
					ReportFilterArray array1 = new mz.erp.commontypes.ReportFilterArray();
					FrmConsultas frmConsultas = ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoEstadoCajas), "Estado actual de las cajas", array1, typeof( mz.erp.ui.forms.FrmConsultas )); 
					frmConsultas.SetProcess(key);
					frmConsultas.Show();
					break;
						
					/*case "ProcesoCajaCierreX"://"Cierre X":
						case "ProcesoCajaCierreZ"://"Cierre Z":
							FrmFiscal frmFis1 = new FrmFiscal();
							if (key == "Cierre X") 
							{frmFis1.Cierre('X');}
							else 
							{frmFis1.Cierre('Z');}
							break;
							/*ProcesoCajaArqueo*/

					#endregion

					#region Caja / Movimientos

				case "ProcesoCajaMovDeIngreso"://"Movimientos de Caja":
					CallProcess( "ProcesoMovimientoCajaIngreso" );
					/*FrmMovimientosCajaEx formMI= new FrmMovimientosCajaEx("1");
						formMI.MdiParent= this;
						formMI.ShowForm(null, "Movimientos de Ingreso");*/
					break;				
				case "ProcesoCajaMovDeEgreso"://"Movimientos de Caja":
					CallProcess( "ProcesoMovimientoCajaEgreso" );
					/*
						FrmMovimientosCajaEx formMC= new FrmMovimientosCajaEx("-1");
						formMC.MdiParent= this;
						formMC.ShowForm(null, "Movimientos de Egreso");*/
					break;				
				case "ProcesoTransferirValoresCaja":
				{
					CallProcess( "ProcesoTransferirValoresCaja" );
					break;
				}
				case "ProcesoAjustarMovimientoCaja":
				{
					CallProcess( "ProcesoAjustarMovimientoCaja" );
					break;
				}
				case "ProcesoEditarMovimientoCaja":
				{
					CallProcess( "ProcesoEditarMovimientoCaja" );
					break;
				}

				case "ProcesoModificarValor":
				{
					CallProcess( "ProcesoModificarValor" );
					break;
				}

					#endregion

					#region Caja / Consultas
					
				case "ProcesoCajaConsultasCobranzasYPagos":
				{
					CallProcess("ProcesoConsultasCobranzasYPagos");
					break;
				}
				/*case "ProcesoConsultasCobranzasYPagosAnterior":
				{
					CallProcess("ProcesoConsultasCobranzasYPagosAnterior");
					break;
				}*/
				case "ProcesoConsultarPosicionDeCaja":
				{
					CallProcess("ProcesoConsultarPosicionDeCaja");
					break;
				}

				case "ProcesoConsultarPosicionDeCajaAnterior":
				{
					CallProcess("ProcesoConsultarPosicionDeCajaAnterior");
					break;
				}

				case "ProcesoConsultaPosicionDeCajaDetallado":
				{
					CallProcess("ProcesoConsultarPosicionDeCajaDetallado");
					break;
				}	
				case "ProcesoConsultarGastos":
				{
					CallProcess("ProcesoConsultarGastos");
					break;
				}	
				case "ProcesoConsultarValoresCajas":
				{
					CallProcess("ProcesoConsultarValoresCajas");
					break;
				}	

					#endregion

					#region Entregas
				case "ProcesoPredefinirEntregar"://"Entregas Precomprobante de Entregas":
				{
					CallProcess( "ProcesoPredefinirEntregar" );
				}
					break;

				case "ProcesoPredefinirEntregarEntregar"://"Entregas Remito de Preremito":
				{
					
					CallProcess( "ProcesoPredefinirEntregarEntregar" );
				}
					break;

				case "ProcesoPrepararDiferidoPreparar"://"Entregas ProcesoOrdenPreparadoDiferidaOrdenPreparado":
				{
					CallProcess( "ProcesoPrepararDiferidoPreparar" );
				}

					break;

				
				case "ProcesoPrepararConfirmarPreparar"://"Entregas ProcesoPrepararConfirmarPreparar":
				{
					CallProcess( "ProcesoPrepararConfirmarPreparar" );
				}
					break;

				case "ProcesoConfirmarRemito"://"Entregas ProcesoPrepararConfirmarPreparar":
				{
					CallProcess( "ProcesoRemitirConfirmarRemitir" );
				}
					break;

				case "ProcesoEntregar"://"Entregar Mercaderia":
				{
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta",true,null);
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);
							
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Facturas");
							
					ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesPendientes), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ), typeof(mz.erp.ui.forms.FrmComprobantesSelectN),true );

					break;*/
					CallProcess("ProcesoEntregar");
					break;
				}

				case "ProcesoPrevenderPreprestarPreparar"://"Entregar Mercaderia":
				{
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta",true,null);
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);
							
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Facturas");
							
					ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesPendientes), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ), typeof(mz.erp.ui.forms.FrmComprobantesSelectN),true );

					break;*/
					CallProcess("ProcesoPrevenderPreprestarPreparar");
					break;
				}
				case "ProcesoRemitir"://"Remitos":
				{
					CallProcess("ProcesoRemitir");
					break;
				}
				case "ProcesoRemitirVenderManual"://"Factura manual desde Remito":
				{
					CallProcess("ProcesoRemitirVenderManual");
					break;
				}


				case "ProcesoPrepararDiferidoEnviar"://"Remitos":
				{
					CallProcess("ProcesoPrepararDiferidoEnviar");
					break;
				}


					#endregion

					#region Entregas / Consultas
				case "ProcesoEntregasConsultaOrdenesPendientes": //consulta 1 --> 889
				{
					CallProcess( "ProcesoEntregasConsultaOrdenesPendientes" );/*Una la clase ListarComprobantesPendientes*/
				}
					break;

				case "ProcesoEntregasConsultaOrdPrepControladas": //consulta 2 --> script 890
				{
					CallProcess( "ProcesoEntregasConsultaOrdPrepControladas" );
				}
					break;
	 
				case "ProcesoEntregasConsultaEntregaDeposito"://consulta 3 --> script 891
				{
					CallProcess( "ProcesoEntregasConsultaEntregaDeposito" );
				}
					break;
	  
				case "ProcesoEntregasConsultaOrdenesDeEnvio":// consulta 4 --> script 892
				{
					CallProcess( "ProcesoEntregasConsultaOrdenesDeEnvio" );
				}
					break;
				
				case "ProcesoEntregasConsultaConfMercEnviada": //consulta 5 --> script 893
				{
					CallProcess( "ProcesoEntregasConsultaConfMercEnviada" ); 
				}
					break;

					case "ProcesoEntregasConsultarArticulosPendienteDePreparacion": //consulta 6
					{
						CallProcess( "ProcesoEntregasConsultarArticulosPendienteDePreparacion" );
					}
					break;

				case "ProcesoConsultaOrdenesPreparadasPendientesEntrega": //consulta 6
				{
					CallProcess( "ProcesoConsultaOrdenesPreparadasPendientesEntrega" );
				}
					break;
						
					#endregion
		
					#region Reportes / De Valores
					#endregion

					#region Reportes / Contables
					/*ProcesoRepSubdiarioImpuestos*/

				case "ProcesoRepSubdiarioVentas"://"Libro de IVA":					
				{
					string ReportName = Variables.GetValueString("Momentos.ImprimirReporte.ProcesoRepSubdiarioVentas.Reporte");
					//ReportsManager.PrintReportLibroDeIVA(this);
					//FrmParameterReports frmPR = new FrmParameterReports("ReportLibroDeIVA.RPX");
					FrmParameterReports frmPR = new FrmParameterReports(ReportName);
					frmPR.ShowDialog();	
					break;
				}	
                /* Silvina 20101206 - Tarea 958 */
                case "ProcesoRepSubdiarioCompras"://"Libro de IVA":					
                {
                    string ReportName = Variables.GetValueString("Momentos.ImprimirReporte.ProcesoRepSubdiarioCompras.Reporte");
                    FrmParameterReports frmPR = new FrmParameterReports(ReportName);
                    frmPR.ShowDialog();
                    break;
                }
                /* Fin Silvina */
				case "ProcesoRepSubdiarioVentasTotalizado"://"Libro de IVA totalizado":					
				{
					FrmParameterReports frmPR = new FrmParameterReports("ReportLibroDeIVATotalizado.RPX");
					frmPR.ShowDialog();	
					break;
				}
				case "ProcesoRepRetenciones"://"Listado de retenciones":					
				{
					FrmParameterReports frmPR = new FrmParameterReports("ReportRetenciones.RPX");
					frmPR.ShowDialog();	
					break;
				}
				case "ProcesoListadoIngresosBrutos"://"Listado de Ingresos Brutos":				
				{					
					FrmParameterReports frmPR = new FrmParameterReports("ReportListadoIngresosBrutos.rpx");
					frmPR.ShowDialog();	
					break;
				}	

				case "ProcesoListadoPercepcionIngresosBrutos"://"Listado de Percepción de Ingresos Brutos":				
				{					
					FrmParameterReports frmPR = new FrmParameterReports("ReportListadoPercepcionIngresosBrutos.RPX");
					frmPR.ShowDialog();	
					break;
				}	
				
				case "ProcesoRepStockValorizado"://"Listado de Valorizacion de Stock":
				{
					/*
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Producto","Producto", true, null);
					array.Add( "Deposito","Depósito",true, null);
					array.Add( "Seccion","Sección",true, null);
					array.Add( "EstadoDeStock","Estado de Stock", true, null);
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeValorizacionDeStock), "Listado de Valorización de Stock", array, typeof( mz.erp.ui.forms.FrmConsultas )); 
					*/
					CallProcess("ProcesoValorizarStock");
					break;
				}
                //German 20120412 - Tarea 0000286
				case "ProcesoExportarListadoPercepcionIIBBClientes"://"Exportar Listado de Percepción de Ingresos Brutos":				
				{
                    /*
                    FrmExportarPercepcionIBClientes frmELPIIBB = new FrmExportarPercepcionIBClientes();
                    frmELPIIBB.MdiParent = this;
                    frmELPIIBB.Show();                    
                    break;
                     * */
                    FrmExportarImpuestos frmExportarImpuestos = new FrmExportarImpuestos("ProcesoExportarListadoPercepcionIIBBClientes");
                    frmExportarImpuestos.MdiParent = this;
                    frmExportarImpuestos.Show();
                    break;
				}
                //Fin German 20120412 - Tarea 0000286
		       //Cristian Tarea 0000067 20110329
                case "ProcesoExportarCitiVentas":
                {
                    FrmExportarCitiVentas frmcitiVtas = new FrmExportarCitiVentas();
                    frmcitiVtas.MdiParent = this;
                    frmcitiVtas.Show();
                    break;
                }
               //Fin Cristian

                //German 20120412 - Tarea 0000286
                case "ProcesoExportarListadoRetencionIIBBProveedores"://"Exportar Listado de Retencion de Ingresos Brutos":				
                {
                    FrmExportarImpuestos frmExportarImpuestos = new FrmExportarImpuestos("ProcesoExportarListadoRetencionIIBBProveedores");
                    frmExportarImpuestos.MdiParent = this;
                    frmExportarImpuestos.Show();
                    break;
                }
                //Fin German 20120412 - Tarea 0000286


					#endregion
				
					#region Reportes / Ventas
					/*
					ProcesoRepRankingDeVentas
					ProcesoRepVentasPorClientes
					ProcesoRepVentasPorRubro
					ProcesoRepVentasPorVendedor
					ProcesoRepRentabilidadPorCliente
					ProcesoRepRentabilidadPorProducto
					*/

				case "ProcesoRepVentasPorProducto" :
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-10));
					//Cristian Tarea 0000050 20110315
                    array.Add( "FechaHasta","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian
					//array.Add( "Jerarquia","Proveedor",true,null);
					FrmConsultas frmConsultas1 =  ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeVentasPorProducto), "Listado de Ventas por Producto", array, typeof( mz.erp.ui.forms.FrmConsultas )); 
					frmConsultas1.SetProcess(key);
					frmConsultas1.Show();
					break;
				}
					
					#endregion

					#region Reportes / Datos
				
				case "ProcesoRepListadoDeClientes"://"Reportes Reporte de Clientes":
				{
					//FrmPreviewReport preview1 = new FrmPreviewReport();
					//preview1.ShowReport("ReportClientes.RPX",this);
					FrmParameterReports frmPR = new FrmParameterReports("ReportClientes.RPX");
					frmPR.ShowDialog();					
					break;
				}
				case "ProcesoRepListadoDePrecios":
				{
					/*FrmPreviewReport preview2 = new FrmPreviewReport();
					preview2.ShowReport("ReportListaDePrecios.rpx",this);*/
					FrmParameterReports frmPR = new FrmParameterReports("ReportListaDePrecios.RPX");
					frmPR.ShowDialogCustom();
					break;
				}

				case "ProcesoConsultarListasDePreciosVentas":
				{
					this.CallProcess( "ProcesoConsultarListasDePreciosVentas" );  
					break;
				}

					#endregion
				
					#region Datos / Nuevo

				case "ProcesoDatosNuevoProveedor"://"Nuevo Nuevo Proveedor":
					//NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmProveedores), "Proveedores");					
					this.Cursor = Cursors.WaitCursor;

					FrmAbmProveedores prov = new FrmAbmProveedores();

					prov.MdiParent = this;
					prov.Show();
					this.Cursor = Cursors.Default;				

					break;
				case "ProcesoDatosNuevoPersona"://"Nuevo Nueva Persona":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmPersonas), "Personas");
					break;
				case "ProcesoDatosNuevoProducto"://"Nuevo Nuevo Producto":
					//CallProcess( "ProcesoABMProductos");
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmExProductos), "Productos");
					break;
				case "ProcesoDatosNuevoCliente"://"Nuevo Nuevo Cliente":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmCuentas), "Clientes");
					break;
				case "ProcesoDatosNuevoUsuario"://"Nuevo Nuevo Usuario":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmUsuariosEx), "Usuarios");
					break;
					/*case "ProcesoDatosNuevoElemento":
					
							break;
						*/
				case "ProcesoDatosNuevoTransporte":
					NewDocumentLoader( typeof(mz.erp.ui.forms.FrmAbmTransportes), "Transportes");
					break;
					#endregion

					#region Datos / Abrir
				case "ProcesoDatosAbrirPersona"://"Abrir Abrir Persona":
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tsh_Personas ), typeof( mz.erp.ui.forms.FrmAbmPersonas ), "Personas");
					//GridDocumentLoader( new ui.tsh_Personas(), "Personas" );
					break;
				case "ProcesoDatosAbrirProducto"://"Abrir Abrir Producto":
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tsh_Productos ), typeof( mz.erp.ui.forms.FrmAbmExProductos ), "Productos");
					//GridDocumentLoader( new ui.tsh_Productos(), "Productos" );
					break;
				case "ProcesoConsultarCuentas":
				case "ProcesoDatosAbrirCliente"://"Abrir Abrir Cliente":
					//FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tsa_Cuentas ), typeof( mz.erp.ui.forms.FrmAbmCuentas ), "Clientes" );										
					mz.erp.ui.forms.mzCuentasSearchForm _formCuentasSearchForm = new mz.erp.ui.forms.mzCuentasSearchForm();
					//Matias 20100603 - Tarea 16
					_formCuentasSearchForm.InitEditarCliente(true, true, false); //_formCuentasSearchForm.Init(true, true, false);
					//Fin Matias 20100603 - Tarea 16
					_formCuentasSearchForm.MdiParent = this;
					_formCuentasSearchForm.Show();

					break;
				case "ProcesoDatosAbrirProveedor"://"Abrir Abrir Proveedor":
					//FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tpu_Proveedores ), typeof( mz.erp.ui.forms.FrmAbmProveedores ), "Proveedores" );					
					
					mz.erp.ui.forms.mzProveedoresSearchForm fp = new mz.erp.ui.forms.mzProveedoresSearchForm();

					//fp.Init();
					fp.Init(true, true, false);
					fp.MdiParent = this;
					fp.Show();					
					break;
					

				case "ProcesoDatosAbrirUsuario"://"Abrir Usuario":					
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.sy_Usuarios ), typeof ( mz.erp.ui.forms.FrmAbmUsuariosEx ), "Usuarios" );					
					break;			
					/*	case "ProcesoDatosAbrirElemento":				
							break;	
						*/
					
				case "ProcesoDatosAbrirTransporte":
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tlg_Transportes ), typeof( mz.erp.ui.forms.FrmAbmTransportes), "Transportes");
					break;

				case "ProcesoEditarCuentasObservaciones":
					CallProcess("ProcesoEditarCuentasObservaciones");
					break;
				
				case "ProcesoConsultarProductos"://"Consulta de Productos":										
				    this.CallProcess( "ProcesoConsultarProductos" );  
					break;

				case "ProcesoConsultarPersonas"://"Consulta de Personas":										
					this.CallProcess( "ProcesoConsultarPersonas" );  
					break;
				
				case "ProcesoEditarProveedoresObservaciones":
					CallProcess("ProcesoEditarProveedoresObservaciones");
					break;

				case "ProcesoListarTareasRealizadasOrdenReparacion":
					CallProcess("ProcesoListarTareasRealizadasOrdenReparacion");
					break;

				case "ProcesoConsultarEstadisticaOrdenReparacion":
					CallProcess("ProcesoConsultarEstadisticaOrdenReparacion");
					break;

					#endregion
				
					#region Datos / Datos Auxiliares / Sistemas
				
				case "ProcesoDatosAuxSistVariables"://"Datos Auxiliares Sistema Variables":
					GridDocumentLoader( new mz.erp.ui.forms.classes.sy_Variables( new string[] {"IdVariable","Descripcion","ValorDefault","IdTipoVariable"}), "Variables" );
					break;
				case "ProcesoDatosAuxSistTiposDeVariables"://"Datos Auxiliares Sistema Tipos Variables":
					
					GridDocumentLoader( new mz.erp.ui.forms.classes.sy_TiposVariables( new string[] {"IdTipoVariable","Descripcion"}), "Tipos de Variables" );
					break;
				case "ProcesoDatosAuxSistSucursales"://"Datos Auxiliares Sistema Sucursales":
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.sy_Sucursales ), typeof( mz.erp.ui.forms.FrmAbmSucursales ), "Sucursales" );
					break;
				case "ProcesoDatosAuxSistVarPorPerfil"://"Datos Auxiliares Sistema Variables por Perfiles":
					
					
					GridDocumentLoader( new ui.forms.classes.sy_VariablesPerfiles(), "Variables por Perfiles" );
					break;
					
				case "ProcesoDatosAuxSistVarPorUsuario":
					GridDocumentLoader( new ui.forms.classes.sy_VariablesUsuarios(), "Variables por Usuarios" );
					break;

				case "ProcesoDatosAuxSistJerarquiaVariables":
					FrmJerarquiaAgrupVariables form = new FrmJerarquiaAgrupVariables();
					form.MdiParent = this;
					form.Text = "Jerarquía de variables";
					form.Show();
					break;

				case "ProcesoABMPuestos":
				{
					GridDocumentLoader( new ui.forms.classes.sy_Puestos(), "Puestos" );

				}
					break;
					#endregion
				
					#region Datos / Datos Auxiliares / Clientes

				case "ProcesoDatosAuxCliTratamientos"://"Datos Auxiliares Clientes Tratamientos":
					GridDocumentLoader( new ui.forms.classes.tcs_Tratamiento(), "Tratamientos" );
					break;
				case "cuentasCondicionesDeVenta": 
				{
					CallProcess("ProcesoABMCuentasCondicionesDeVenta");
					break;
				}
				case "ProcesoABMCuentasObservaciones": 
				{
					CallProcess("ProcesoABMCuentasObservaciones");
					break;
				}	
				case "ProcesoDatosAuxCuentasJerarquias"://"Datos Auxiliares Productos Jerarquías":
					
					FrmJerarquiaAgrupGeneral formjAC = new FrmJerarquiaAgrupGeneral("CUENTAS");
					formjAC.MdiParent = this;
					formjAC.Text = "Jerarquía de Clientes";
					formjAC.Show();
					break;
					
	
				case "ProcesoAgruparCuentasJerarquias"://"Datos Auxiliares Productos Jerarquías":
					FrmAgrupamientos formAg = new FrmAgrupamientos("CUENTAS");
					formAg.MdiParent = this;
					formAg.Text = "Agrupamientos";
					formAg.Show();
					break;	

				case "ProcesoAltaCuentaObservacionesEstados"://"Datos Auxiliares Estados Cuentas Observaciones Estados":
					this.CallProcess( "ProcesoAltaCuentaObservacionesEstados"); 
					break;

				case "ProcesoModificarCuentaObservacionesEstados"://"Datos Auxiliares Estados Cuentas Observaciones Estados":
					this.CallProcess( "ProcesoModificarCuentaObservacionesEstados"); 
					break;
					
						
					

				case "ProcesoAbmTiposObservacionesCuentas"://"ABM Tipos observaciones cuentas":					
				{					
					this.CallProcess( "ProcesoAbmTiposObservacionesCuentas" );  
					break;

				}


					#endregion

					#region Datos / Datos Auxiliares / Logistica
				
				case "ProcesoDatosAuxLogZonas"://"Zonas":
					//ST ubicacion: Archivo/Datos auxiliares/Logistica/Zonas
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tlg_Zonas ), typeof( mz.erp.ui.forms.FrmAbmZonas), "Zonas");
					break;
				
				case "ProcesoDatosAuxLogDepositos"://"Datos Auxiliares Logistica Depositos":
					GridDocumentLoader( new ui.forms.classes.tlg_Depositos(), "Depositos" );
					break;
				case "ProcesoDatosAuxLogSecciones"://"Datos Auxiliares Logistica Secciones":
					GridDocumentLoader( new ui.forms.classes.tlg_Secciones(), "Secciones" );
					break;
				case "ProcesoDatosAuxLogTiposDeAjustes"://"Datos Auxiliares Logistica Tipos de Ajustes de Stock":
					FilterDocumentLoader( typeof( mz.erp.ui.forms.classes.tlg_TiposDeAjuste), typeof(mz.erp.ui.forms.FrmAbmTiposDeAjuste), "Tipos de Ajustes de Stock" );
					break;
					
				case "ProcesoAbmVisualizacionDeStock"://"ABM Visualizaciones de Stock":	
					this.CallProcess( "ProcesoAbmVisualizacionDeStock" );  
					break;

					#endregion

					#region Datos / Datos Auxiliares / Ventas 

				case "ProcesoDatosAuxVentasBonificaciones"://"Datos Auxiliares Ventas Bonificaciones":
					FilterDocumentLoader( typeof (mz.erp.ui.forms.classes.tsa_BonificacionesEx), typeof( mz.erp.ui.forms.FrmAbmBonificacionesEx), "Bonificaciones");
					break;

					#endregion

					#region Datos / Datos Auxiliares / Productos
				
				case "ProcesoDatosAuxProdUnidadesDeMedida"://"Datos Auxiliares Productos Unidades de Medidas":
					GridDocumentLoader( new ui.forms.classes.tsh_Unidades(), "Unidades de Medidas" );
					break;

				case "ProcesoDatosAuxProdConversiones"://"Datos Auxiliares Productos Conversiones":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmABMConversionesEx), "Conversiones");
					break;

				case "ProcesoDatosAuxProdAgrupamientos"://"Datos Auxiliares Productos Agrupamientos":					
					FrmAgrupProductos formAP = new FrmAgrupProductos();
					formAP.MdiParent = this;
					formAP.Text = "Agrupamiento de productos";
					formAP.Show();
					break;

				case "ProcesoDatosAuxProdJerarquias"://"Datos Auxiliares Productos Jerarquías":
					FrmJerarquiaAgrupGeneral formjAP = new FrmJerarquiaAgrupGeneral("PRODUCTOS");
					formjAP.MdiParent = this;
					formjAP.Text = "Jerarquía de productos";
					formjAP.Show();
					break;		

				case "ProcesoIngresarCodigoSecundario":
				{
					CallProcess("ProcesoIngresarCodigoSecundario");
					break;
				}
				case "ProcesoDatosAuxProdImpuestos"://"Datos Auxiliares Sistema Impuestos":
					GridDocumentLoader( new mz.erp.ui.forms.classes.tsy_ImpuestosEx( new string[] {"Descripcion","Alicuota1"}), "Impuestos" );										
					break;

                //German 20110602 - Tarea 0000149
                case "ProcesoDatosAuxProdImpuestosInternos"://"Datos Auxiliares Productos ABM Impuestos Internos":
                    GridDocumentLoader(new mz.erp.ui.forms.classes.tsy_ImpuestosEx(new string[] {"IdImpuesto","Impuesto" ,"Descripcion", "Alicuota1", "FechaInicio" }, true), "Impuestos Internos");
                    break;
                //Fin German 20110602 - Tarea 0000149

				case "ProcesoDesactivarProductosSinMovimientos"://"Datos Auxiliares Productos Desactivar Productos sin Movimientos":										
					this.CallProcess( "ProcesoDesactivarProductosSinMovimientos" );  
					break;

				case "ProcesoABMArticulos":
					GridDocumentLoader( new ui.forms.classes.tsy_TipoProducto(new string[] {"IdTipoProducto","Descripcion","AfectaStock","Activo"}), "Tipos de Productos" );
					break;
					
				//Sabrina 20100618 - Tarea 787
				case "ProcesoABMListasDePrecios":
					GridDocumentLoader( new ui.forms.classes.tsh_ListasDePrecios(), "Listas De Precios" );
					break;
				//Fin Sabrina 20100618 - Tarea 787

                /* Silvina 20111104 - Tarea 0000222 */
                case "ProcesoAbmProductosCategoriasCuentas":
                    this.CallProcess("ProcesoAbmProductosCategoriasCuentas"); 
                    break;
                /* Fin Silvina 20111104 - Tarea 0000222 */

					#endregion

					#region Datos / Datos Auxiliares / Contabilidad
				
				case "ProcesoDatosAuxContabilidadEntidades"://"Datos Auxiliares Contabilidad Entidades":
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tfi_Entidades ), typeof( mz.erp.ui.forms.FrmAbmEntidades ), "Entidades" );
					//NewDocumentLoader( typeof( mz.erp.ui.forms.FrmAbmEntidades ), "Entidades");
					break;
				case "ProcesoIngresarEntidad":
					this.CallProcess( "ProcesoIngresarEntidad" );  
					break;
				case "ProcesoModificarEntidad":
					this.CallProcess( "ProcesoModificarEntidad" );  
					break;
				case "ProcesoDatosAuxContabilidadCajas":
					GridDocumentLoader( new ui.forms.classes.tfi_Cajas(), "Cajas" );
					break;
					
				case "ProcesoDatosAuxContabilidadRespDeCaja":
					GridDocumentLoader( new ui.forms.classes.tfi_ResponsablesCajas(), "Responsables de Caja" );
					break;

				case "ProcesoAltaFormasDePago":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmABMFormasDePago), "Formas de Pago");
					break;
				case "ProcesoAbrirFormasDePago":
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tfi_TDCompTesoreria), typeof(mz.erp.ui.forms.FrmABMFormasDePago),"Formas de Pago");
					break;
				// Formulario viejo
				case "ProcesoAltaCondicionesDeVentas":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FormAbmCondicionesDeVenta), "Condiciones de Venta");
					break;
				case "ProcesoAbrirCondicionesDeVentas":
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tsa_CondicionesDeVentas), typeof(mz.erp.ui.forms.FormAbmCondicionesDeVenta),"Condiciones de Venta");
					break;
				case "ProcesoIngresarCondicionDeVentaGeneral":
					this.CallProcess( "ProcesoIngresarCondicionDeVentaGeneral" );  
					break;
				case "ProcesoIngresarCondicionDeVentaParticular":
					this.CallProcess( "ProcesoIngresarCondicionDeVentaParticular" );  
					break;
				case "ProcesoIngresarCondicionDeVentaPorInclusionCuenta":
					this.CallProcess( "ProcesoIngresarCondicionDeVentaPorInclusionCuenta" );  
					break;
				case "ProcesoIngresarCondicionDeVentaPorExclusionCuenta":
					this.CallProcess( "ProcesoIngresarCondicionDeVentaPorExclusionCuenta" );  
					break;
				case "ProcesoModificarCondicionDeVentaGeneral":
					this.CallProcess( "ProcesoModificarCondicionDeVentaGeneral" );  
					break;
				case "ProcesoModificarCondicionDeVentaParticular":
					this.CallProcess( "ProcesoModificarCondicionDeVentaParticular" );  
					break;
				case "ProcesoModificarCondicionDeVentaPorInclusionCuenta":
					this.CallProcess( "ProcesoModificarCondicionDeVentaPorInclusionCuenta" );  
					break;
				case "ProcesoModificarCondicionDeVentaPorExclusionCuenta":
					this.CallProcess( "ProcesoModificarCondicionDeVentaPorExclusionCuenta" );  
					break;
				case "ProcesoABMTiposMovimientos"://"ABM Tipos movimientos":					
				{					
					this.CallProcess( "ProcesoABMTiposMovimientos" );  
					break;

				}
                /* Silvina 20110217 - Tarea 0000017 */
                case "ProcesoAbmCondicionesDeCompra":
                    GridDocumentLoader(new ui.forms.classes.tpu_CondicionesDeCompras(), "Condiciones de Pago");
                    break;

					#endregion

					#region Datos / Datos Auxiliares / General
			    /* Fin Silvina */
				/*SE PASO A WORKFLOW
				 * case "ProcesoDatosAuxGeneralLocalidades"://"Datos Auxiliares General Localidades":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmLocalidades ),  "Localidades" );
					break;*/

				case "ProcesoABMCotizacionMoneda"://"Datos Auxiliares General Localidades":
					this.CallProcess( "ProcesoABMCotizacionMoneda" );  
					break;

				case "ProcesoABMEmpresas":
					GridDocumentLoader( new ui.forms.classes.sy_Empresas(), "Empresas" );
					break;
					
			
					#endregion

					#region Datos / Datos Auxiliares / Configuración de menú
			
				case "ProcesoDatosAuxConfigMenuNuevoMenu"://"Nuevo Menu":
				{
					FrmConfiguracionMenues frmpr = new FrmConfiguracionMenues();
					frmpr.MdiParent = this;
					frmpr.Show();
					break;
				}


				case "ProcesoHabilitarOpcionDeMenu"://"Habilitar opción de menú":
				{				
					CallProcess(key);								
					break;
				}					

				case "ProcesoConfigurarMenues"://"Configurar menues":
				{				
					this.CallProcess( "ProcesoConfigurarMenues" );  
					break;
				}					
					break;	


					#endregion

					#region Datos / Datos Auxiliares / Proveedores
                    
				case "ProcesoJerarquiaAgrupProveedores"://"Datos Auxiliares Proveedores Jerarquías":
					
					FrmJerarquiaAgrupGeneral formjAProv = new FrmJerarquiaAgrupGeneral("PROVEEDORES");
					formjAProv.MdiParent = this;
					formjAProv.Text = "Jerarquía de Proveedores";
					formjAProv.Show();
					break;

				case "ProcesoAgrupProveedores"://"Datos Auxiliares Proveedores Agrupamientos":
					FrmAgrupamientos formAgP = new FrmAgrupamientos("PROVEEDORES");
					formAgP.MdiParent = this;
					formAgP.Text = "Agrupamientos";
					formAgP.Show();
					break;	

				case "ProcesoAltaProveedorObservacionesEstados"://"Datos Auxiliares Proveedores Alta Observaciones Estados Proveedor":
					this.CallProcess( "ProcesoAltaProveedorObservacionesEstados"); 
					break;

				case "ProcesoModificarProveedorObservacionesEstados"://"Datos Auxiliares Proveedores Modificacion Observaciones Estados Proveedor":
					this.CallProcess( "ProcesoModificarProveedorObservacionesEstados"); 
					break;

				case "ProcesoAbmTiposObservacionesProveedores"://"ABM Tipos observaciones proveedores":					
				{					
					this.CallProcess( "ProcesoAbmTiposObservacionesProveedores" );  
					break;

				}
				case "ProcesoABMProveedoresObservaciones": 
				{
					CallProcess("ProcesoABMProveedoresObservaciones");
					break;
				}	


					#endregion

					#region Datos / Datos Auxiliares / Orden Reparacion
                    

				case "ProcesoAbmMotivoOrdenReparacion": 
				{
					CallProcess("ProcesoAbmMotivoOrdenReparacion");
					break;
				}	

				case "ProcesoAbmServicio": 
				{
					CallProcess("ProcesoAbmServicio");
					break;
				}	

				case "ProcesoAbmTarea": 
				{
					CallProcess("ProcesoAbmTarea");
					break;
				}	

				case "ProcesoCierreMasivoOrdenReparacion": 
				{
					CallProcess("ProcesoCierreMasivoOrdenReparacion");
					break;
				}	
					
					#endregion

					#region Procesos
	
				case "ProcesoProcesosSincronizarCFiscal"://"Sincronizar Controlador Fiscal":					
				{					
					this.CallProcess( "ProcesoSincronizarFiscal" );  
					break;
				}

				/*case "ProcesoConfigurarLayoutGrillas":
				{					
					this.CallProcess( "ProcesoConfigurarLayoutGrillas" );  
					break;
				}		*/
				case "ProcesoCajaCierreX"://"Cierre X":							 
				{
					bool entrar = true;
					bool preguntar = businessrules.Variables.GetValueBool("ProcesoCierreX.Preguntar");							

					if (preguntar)
					{
						DialogResult result2;
						result2 = MessageBox.Show("¿Desea realizar un cierre X?", "Cierre fiscal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);						
						entrar = result2 == DialogResult.Yes;
					}									
					if (entrar) 														
						this.CallProcess( "ProcesoCierreX" );  
					break;
				}
				case "ProcesoCajaCierreZ"://"Cierre Z":
				{
					bool entrar = true;
					bool preguntar = businessrules.Variables.GetValueBool("ProcesoCierreZ.Preguntar");							

					if (preguntar)
					{
						DialogResult result2;						
						result2 = MessageBox.Show("¿Desea realizar un cierre Z?", "Cierre fiscal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);						
						entrar = result2 == DialogResult.Yes;
					}									
					if (entrar) 														
						this.CallProcess( "ProcesoCierreZ" );  

					break;

				}
				case "ProcesoProcesosTestFiscal"://"Test fiscal": 
				{
					frmTestFiscal _form = new frmTestFiscal();
					_form.MdiParent = this;					
					_form.Show();
					break;
				}

				case "ProcesoTest1" :					
				{ //test 1	
					
					frmTest _form = new frmTest();
					_form.MdiParent = this;
					_form.Show();	
					/*
					FrmCuentaCorriente frmcc = new FrmCuentaCorriente("Cuentas", "");
					frmcc.MdiParent = this;
					frmcc.Show();
					
					CallProcess("ProcesoConsultarValores");
					*/

					break;
				}

				case "ProcesoConnectionString":
				{
					frmConnectionString _form = new frmConnectionString();
					_form.MdiParent = this;
					_form.Show();
					break;
				}

				case "ProcesoResetearStockACero"://"Stock A Cero":							 
				{
					
					DialogResult result2;
					result2 = MessageBox.Show("¿Desea Poner el Stock a 0 para todos los productos en todos los depósitos y secciones?", "Stock a 0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);						
					if (result2 == DialogResult.Yes) 														
					{
						mz.erp.businessrules.Stock.StockACero();
					}
						
					break;
				}
				
				case "ProcesoCrearListadoFacturaImpagas":
				{
					mz.erp.businessrules.comprobantes.GenerarListadoFacturasImpagas.GetInstance().GeneraListadoFacturasImpagas();
					System.Windows.Forms.MessageBox.Show("Se ha generado la tabla de facturas impagas","Enhorabuena!",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Exclamation);					
					break;
				}

				#endregion

				#region Ayuda


				case "ProcesoReiniciarVariables":
				{
					Variables.Reset();
					/*ResetClasesTareas();
					ResetControllerTareas();
					MAPStaticInfo.Reset();
					WorkflowValidator.Clear();*/

					System.Windows.Forms.MessageBox.Show("Se han reiniciado las variables","Enhorabuena!",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Exclamation);					
					break;
				}

				case "ProcesoActualizacionConsolidadoDeCheques":
				{
					businessrules.reportes.Temporal.ActualizarConsolidadoCheques();
					System.Windows.Forms.MessageBox.Show("Información actualizada","Actualizacíón de cheques",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Exclamation);
					break;
				}

				case "ProcesoActualizacionConsolidadoDeTarjetas":
				{
					businessrules.reportes.Temporal.ActualizarConsolidadoTarjetas();
					System.Windows.Forms.MessageBox.Show("Información actualizada","Actualizacíón de tarjetas",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Exclamation);
					break;
				}
				case "ProcesoAcercaDe":
				{										
					//MAPStaticInfo.GetFDP("2");
					//MAPStaticInfo.GetBDFDP("3");
					//MAPStaticInfo.AddBDFDP("88", "sabrinita88" , "sabrini");
					//MAPStaticInfo.Save(); agrego en el addFDP el save();
					//MessageBox.Show(MAPStaticInfo.GetBDFDP("88"));	 
					
					Splash _splash = new Splash();
					_splash.ShowModal();
					
					
					string encriptada = "D284nSw7hAp4rfcO3m9chg==";
					string desencriptada = new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64(encriptada);
					desencriptada = "User ID=sa;password=03461441874;Initial Catalog=ErpPrincipalLPC;Data Source=10.1.254.100";
					encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64(desencriptada);
					Console.WriteLine(desencriptada);
					Console.WriteLine(encriptada);

					
					
					
					break;

					//UnhandledExceptionManager.GenericExceptionHandlerToDB(e);
				}

				case "ProcesoActualizacionSistema": 
				{			
					ActualizarVersion();
					break;
				}				
					#endregion

					#region OTROS SIN MENU ASOCIADO

				case "ProcesoConsultarClientes":
				{
					/*
					mz.erp.ui.controllers.forms.mzCuentasSearchForm sfc = new mz.erp.ui.controllers.forms.mzCuentasSearchForm(false);
					sfc.ShowDialog();
					*/
					//FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tsa_Cuentas ), typeof( mz.erp.ui.forms.FrmAbmCuentas ), "Clientes" );										
					mz.erp.ui.forms.mzCuentasSearchForm _formmzCuentasSearchForm1 = new mz.erp.ui.forms.mzCuentasSearchForm();
					//_form.MdiParent = this;
					_formmzCuentasSearchForm1.Init(false, false, false);
					_formmzCuentasSearchForm1.ShowDialog();
					break;				
					
				}
							
				case "Datos Auxiliares Clientes Cargos":
					GridDocumentLoader( new ui.forms.classes.tcs_Cargos(), "Cargos" );
					break;
				
				case "Ventas":
					break;
				case "Orden de Trabajo"://????
					ComprobanteDeVentaLoader( "OrdenDeTrabajo" );
					break;
				
				case "ProcesoVender"://"Facturas":				
					CallProcess( "ProcesoVender" );

					break;
				case "Ventas Consultas Detalle Comprobantes"://????
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta");
					array.Add( "Fecha","Desde Fecha");
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha");
                    //Fin Cristian					
                    array.Add( "Persona","Responsable de Emisión");
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",true,"Facturas");
					FrmConsultas frmConsultas2 = ReportDocumentLoader( typeof( mz.erp.ui.forms.classes.tsa_ReporteDetalleComprobanteDeVenta), "Detalle de Comprobantes de Venta", array, false);
					frmConsultas2.SetProcess(key);
					frmConsultas2.Show();
					break;
				}

				case "Datos Auxiliares Clientes Tipos de Contactos":
					GridDocumentLoader( new ui.forms.classes.tcs_TiposContactos(), "Tipos de contactos" );
					break;

				case "Datos Auxiliares Clientes Tipos de Domicilios":
					GridDocumentLoader( new ui.forms.classes.tcs_TiposDomicilios(), "Tipos de domicilios" );
					break;
			
				case "DatosAuxiliares Compras Motivo de Devoluciones":
					GridDocumentLoader( new ui.forms.classes.tpu_MotivosDevoluciones(), "Motivos de Devoluciones de Compras" );
					break;
				
				case "Datos Auxiliares Sistema Categorias de Iva":
					GridDocumentLoader( new ui.forms.classes.tsy_CategoriasIva( new string[] {"IdCategoriaIva","Descripcion","ActivoVentas","ActivoCompras","Clase","Discrimino","LPT","s"}), "Categorias de Iva" );
					break;

				case "Datos Auxiliares Sistema Tipos de Documentos":
					GridDocumentLoader( new ui.forms.classes.tsy_TiposDocumentos( new string[]{ "idTipoDocumento", "Descripcion"} ), "Tipos de Documento" );
					break;
				
			
				
				case "Test impresion": 
				{
					FrmImpresion _form = new FrmImpresion();
					_form.MdiParent = this;					
					_form.Show();
					break;
				}					
				
				case "Logistica Pedidos a Proveedores Pedidos Pendientes":
				{
					/*
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Proveedor","Proveedor",false,Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault"));
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);
						
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Pedidos");
						
					ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesDeCompraPendientes), "Comprobantes de Compra", array, typeof(mz.erp.ui.forms.FrmComprobantesDeCompraSelectN),true );
					*/
					break;
				}

				case "Logistica Consultas Detalle Comprobantes Compra":
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Proveedor","Proveedor",false,Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault"));
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
                    //Cristian Tarea 0000050 20110315
                    array.Add("FechaHasta", "Hasta Fecha", true, mz.erp.businessrules.Sistema.DateTime.Now);
                    //Fin Cristian					
                    array.Add( "Persona","Responsable de Emisión",true,null);	
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Pedidos");
						
					FrmConsultas frmConsultas3 =  ReportDocumentLoader( typeof( mz.erp.ui.forms.classes.DetalleComprobantesDeCompraPendientes), "Comprobantes de Compra", array , false);
					frmConsultas3.SetProcess(key);
					frmConsultas3.Show();
					break;

				}

				case "Logistica Pedidos a Proveedores Confirmacion de Pedidos Pendientes"://????
				{
					/*
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Proveedor","Proveedor",false,Variables.GetValueString("Compras.Pedidos.ProveedorPorDefault"));
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);
						
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Confirmación de Pedido");
						
					ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesDeCompraPendientes), "Comprobantes de Compra", array, typeof(mz.erp.ui.forms.FrmComprobantesDeCompraSelectN),true );
					*/
					break;

				}
				case "Pendiente de preparacion": 
				{
					
					/*ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta",true,null);
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);
					array.Add( "Momento","Accion a Realizar",true,"Preparar");										
					
					ReportDocumentLoader( typeof( mz.erp.ui.ComprobantesPendientesWF), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmEntregas ), typeof(mz.erp.ui.forms.FrmComprobantesSelectN),true );
					*/
					break;
				}

		
				
				
					//				case "Temporal"://????
					//				{//ST ubicacion:Procesos/Temporal
					//					FilterDocumentLoader( typeof ( mz.erp.ui.tlg_Transportes ), typeof( mz.erp.ui.forms.FrmAbmTransportes), "Transportes");
					//					//NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmTransportes), "Transportes");
					//					/*
					//					FrmEntregas frmTemp = new FrmEntregas();
					//					frmTemp.MdiParent = this;					
					//					frmTemp.Show();
					//					*/
					//					break;
					//				}

			

				case "Pedidos a Proveedores": //????
					WebDocumentLoader( mz.erp.businessrules.Variables.GetValueString("Web.Link.PedidosProveedores"));
					break;
				
				case "Reportes Impuestos": 	
				{
					FrmParameterReports frmPR = new FrmParameterReports("ReportImpuestos.RPX");
					frmPR.ShowDialog();								
					break;		
				}
	

			
				case "Nuevo Nuevo Objeto"://????
				
					NewDocumentLoader( typeof(mz.erp.ui.forms.FrmAbmObjetos),"Elementos");
				
					break;
				case "Abrir Abrir Objetos"://????
				
					FilterDocumentLoader( typeof ( mz.erp.ui.forms.classes.tpr_ObjetosEx ), typeof( mz.erp.ui.forms.FrmAbmObjetos ), "Elementos");
				
					break;
				
				case "Procesos Resetear Estado Aplicacion"://????
				
					mz.erp.businessrules.Sistema.SetApplicactionState(1);
					bool _allwSemaphore = Variables.GetValueBool("Debug.Semaforo.Habilitado");
					if(_allwSemaphore)
						this.UpdateApplicationState();
				
					break;

		
					#endregion


				default :
					if (businessrules.twf_Procesos.ExisteProceso(key))
						CallProcess(key);
					else					
						MessageBox.Show( "Función no implementada! " + key,"Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
			}
			this.Cursor = Cursors.Default;

		}

		#region Misc
		public void SetMessage( string _message)
		{
			this.statusBar.Panels["ProcessMessage"].Text = _message;
		}
		public void SetProgressBar( int value )
		{
			Application.DoEvents();
			if (this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Maximum >= value )
			
				this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Value = value;
			
		}
		public void SetProgressBarTop( int value )
		{
			this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Maximum = value;
			this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Minimum = 0;
		}

		private void CallProcess( string _processName )
		{
			ProcessLoader.CallProcess( _processName );
		}

		private void CallProcess( string _processName,Hashtable has)
		{
			ProcessLoader.CallProcess( _processName,has );
		}
		public void CerrarSesion()
		{	
			foreach(Form form in this.MdiChildren)
				form.Close();
			ResetTools();
			ResetVariables();
			ResetClasesTareas();
			ResetControllerTareas();
			CostosIndirectosLoader.Reset();
			MAPStaticInfo.Reset();
			WorkflowValidator.Clear();
			ultraDockManager1.UnpinAll();
			LogIn _logIn = new LogIn();
			_logIn.ShowDialog( this );

			if ( _logIn.DialogResult == DialogResult.OK )
			{	//carga el formulario default de inicio 
				if(Variables.GetValueBool("Sistema.Cultura.Personalizada"))
				{
					string CultureName = Variables.GetValueString("Sistema.Cultura.Nombre");
					string separadorDecimal = Variables.GetValueString("Sistema.Cultura.SeparadorDecimal");
					string separadorDeMiles = Variables.GetValueString("Sistema.Cultura.SeparadorDeMiles");
					Application.CurrentCulture = new CultureInfo(CultureName,true);
					Application.CurrentCulture.NumberFormat.NumberDecimalSeparator = separadorDecimal;
					Application.CurrentCulture.NumberFormat.NumberGroupSeparator = separadorDeMiles;
					Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator =separadorDecimal;
					Application.CurrentCulture.NumberFormat.CurrencyGroupSeparator = separadorDeMiles;
					Application.CurrentCulture.NumberFormat.PercentDecimalSeparator = separadorDecimal;
					Application.CurrentCulture.NumberFormat.PercentGroupSeparator = separadorDeMiles;
				}
				else
				{
					//////////****************************************************//////////
				}
				Security.SeparadorDeMiles = Application.CurrentCulture.NumberFormat.NumberGroupSeparator ;
				Security.SeparadorDecimal = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator ;
				Security.CultureName = Application.CurrentCulture.Name;
				/*Ver como obtener la cultura del sistema*/
				if ((Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault")) != "")
				{
					ProcessTool(Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault"));
				}
				//Security.IdPerfil = _logIn.pe;
				Security.IdIdioma = 1;
				mz.erp.ui.utility.ToolsLoader.Load( this.toolbarsManager, this.explorerBar,this.ultraDockManager1 );
				this.statusBar.Panels["UserName"].Text="Usuario Actual: " + Security.IdUsuario;
				this.statusBar.Panels["SystemVersion"].Text="Puesto: " + Security.IdPuesto + " - " + Security.Puesto;
				this.statusBar.Panels["Perfil"].Text="Perfil: " + Security.Perfil;
                //Cristian Tarea 0000122 20110509
                this.statusBar.Panels["Servidor"].Text = systemframework.ApplicationConfiguration.GetServidor();
                this.statusBar.Panels["Database"].Text = systemframework.ApplicationConfiguration.GetDatabase();	
                //Fin Tarea 0000122
                //Cristian tarea 852
                if ((Variables.GetValueBool("Sistema.VisualizaCotizacion")))
                {
                    this.statusBar.Panels["Cotizacion"].Text = "Cotización: " + mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacionPorDefecto(2).ToString();
                }
                //Fin tarea 852

				//this.statusBar.Panels["DB"].Text = Security.
				//this.statusBar.Panels["Servidor"].Text = Security.
				this.ConfigToolsBar();
				//Variables.Load();

				
				_allwSemaphore = Variables.GetValueBool("Debug.Semaforo.Habilitado");
				if(_allwSemaphore)
				{
					//this.InitializeTimer();
					//this.UpdateApplicationState();
					//this.statusBar.Panels["SemaphoreStatus"].Visible= true;
					//this.statusBar.Panels["SemaphoreStatus"].Visible = true;
				}
				else
				{
					//this.statusBar.Panels["SemaphoreStatus"].Visible= false;
					//this.statusBar.Panels["SemaphoreStatus"].Visible = false;
				}
				_FormCerrarSesion = false;
				//this.InitializeTimer();
                /* Silvina 20110712 - Tarea 0000121 */
                bool visualizaAlertas = Variables.GetValueBool("Alertas.CuentaCorriente.VisualizaAlertas");
                if (visualizaAlertas)
                    InicializarAlertas();
                else
                {
                    notifyIcon1.Visible = false;
                    timerAlertas.Stop();
                }
                /* Fin Silvina 20110712 - Tarea 0000121 */

			}
			else 
			{
				Application.Exit();
			}
		}

		private void ResetTools()
		{
			this.explorerBar.Groups.Clear();
			this.toolbarsManager.Tools.Clear();
		}


		private void ResetVariables()
		{
			Variables.Reset();
		}

		private void ResetControllerTareas()
		{
			ControllerTarea.Reset();
		}

		private void ResetClasesTareas()
		{
			ClaseTarea.Reset();
		}

		
		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, Type stepType, bool allowMultipleRows )
		{			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.StepType = stepType;
			_form.Text = caption;
			_form.AllowMultipleSelect = allowMultipleRows;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, Type stepType, bool allowMultipleRows, string momentoStepDefault )
		{			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.StepType = stepType;
			_form.Text = caption;
			_form.AllowMultipleSelect = allowMultipleRows;
			_form.MdiParent = this;
			_form.MomentoStepDefault = momentoStepDefault;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros,  Type stepType, bool allowMultipleRows )
		{			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
		
			_form.StepType = stepType;
			_form.Text = caption;
			_form.AllowMultipleSelect = allowMultipleRows;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}
		

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, Type stepType )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.StepType = stepType;
			_form.Text = caption;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}
		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.Text = caption;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType,bool allowMultipleRows, bool AllowShowDetails )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.AllowMultipleSelect = false;
			_form.AllowShowDetail = AllowShowDetails;
			_form.Text = caption;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType,bool allowMultipleRows, bool AllowShowDetails , ArrayList grupos, bool editGrupos, string filaSum)
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.AllowMultipleSelect = false;
			_form.AllowShowDetail = AllowShowDetails;
			_form.Text = caption;
			_form.Grupos = grupos;
			_form.FilaSum = filaSum;
			_form.EditGrupos = editGrupos;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType,bool allowMultipleRows, bool AllowShowDetails , ArrayList grupos, bool editGrupos, string filaSum, mz.erp.ui.controllers.IDetailController detailControllerInstance)
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.DetailControllerInstance = detailControllerInstance;
			_form.AllowMultipleSelect = false;
			_form.AllowShowDetail = AllowShowDetails;
			_form.Text = caption;
			_form.Grupos = grupos;
			_form.FilaSum = filaSum;
			_form.EditGrupos = editGrupos;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, mz.erp.ui.controllers.IDetailController detailControllerInstance )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.DetailControllerInstance = detailControllerInstance;
			_form.EditType = editType;
			_form.Text = caption;
			_form.MdiParent = this;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoaderSA( Type reportType, string caption, ReportFilterArray filtros , bool mustImprimir, ArrayList grupos, bool editGrupos, string filaSum )
		{
			FrmConsultas _form = new FrmConsultas( filtros, reportType, grupos, editGrupos, filaSum );
			_form.Text = caption;
			_form.MdiParent = this;
			_form.MustImprimir = mustImprimir;
			//_form.Show();
			return _form;
		}

		private FrmConsultas ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros , bool mustImprimir)
		{

			FrmConsultas _form = new FrmConsultas( filtros, reportType );
			_form.Text = caption;
			_form.MdiParent = this;
			_form.MustImprimir = mustImprimir;
			//_form.Show();
			return _form;
		}
		private void GridDocumentLoader(  mz.erp.ui.forms.classes.IGridDocument gridDocument, string caption )
		{
			GridDocument _gridDocument = new GridDocument(gridDocument );
			_gridDocument.Text = caption;
			_gridDocument.MdiParent = this;
			_gridDocument.Show();
		}

		private void FilterDocumentLoader ( Type searchType , Type editType, string caption )
		{
			FilterDocument _filterDocument = new FilterDocument( searchType, editType, caption );
			_filterDocument.Text = "Búsqueda de " + caption;
			_filterDocument.MdiParent = this;
			_filterDocument.Show();	
		}

		private void FilterDocumentLoader ( Type searchType , Type editType, Type detailType, string caption )
		{
			FilterDocument _filterDocument = new FilterDocument( searchType, editType, detailType, caption );
			_filterDocument.Text = "Búsqueda de " + caption;
			_filterDocument.MdiParent = this;
			_filterDocument.Show();	
		}

		private void FilterDocumentLoader ( Type searchType , Type editType, string caption, string layoutData )
		{
			//FilterDocument _filterDocument = new FilterDocument( searchType, editType, caption, layoutData );
			/*_filterDocument.Text = "Búsqueda de " + caption;
			_filterDocument.MdiParent = this;
			_filterDocument.Show();	*/
		}
		private void NewDocumentLoader( Type editType, string caption)
		{
			try
			{
				MethodBase _showMethod = null;
				foreach( MethodBase mb in editType.GetMethods() )
				{
					foreach( Attribute am in mb.GetCustomAttributes( false ) )
					{
						if ( am is IsShowFormMember )
						{
							_showMethod = mb;
						}
					}
				}
				object instance = Activator.CreateInstance( editType );
				if (_showMethod != null)
					_showMethod.Invoke( instance, new object[]{ null, caption} );
			}
			catch(Exception e){Debug.WriteLine(e.StackTrace);}
		}

		private void ComprobanteDeVentaLoader( string Momento )
		{
			FrmComprobantes formc = new FrmComprobantes( "NEW", null, Momento );
			formc.MdiParent = this;
			formc.Show();
		}

		private void ComprobanteDeCompraLoader( string Momento)
		{

			/*FrmComprobantesDeCompra formc = new FrmComprobantesDeCompra( "NEW", null, Momento );

			formc.MdiParent = this;

			formc.Show();*/

		}

		private void ComprobanteDeCompraLoader(string momento, string Caption)
		{

		}
		
		private void WebDocumentLoader( string url )
		{
			try
			{
				System.Diagnostics.Process.Start( url );
			}
			catch
			{
				//No se puede iniciar el browser
			}
		}

		
		#endregion

		
		private static void Application_Idle(object sender, EventArgs e)
		{
			_timer.Stop();
			_timer.Start();
			//Console.Write("PruebaCVS");
		}

		private void _timer_Tick(object sender, EventArgs e)
		{
			//hay q verificar q la ventana de cerrar sesion no este visible
			if (!_FormCerrarSesion )
			{
				_timer.Stop();
				_FormCerrarSesion = true;
				this.CerrarSesion();
				
			}
		}

		private void _timerForSemaphore_Tick(object sender, EventArgs e)
		{
			this.UpdateApplicationState();
		}
		[PermissionSetAttribute(SecurityAction.Demand, Name="FullTrust")]
		protected override void WndProc(ref System.Windows.Forms.Message m) 
		{
			// comprobar si se cierra la ventana al pulsar en la "x"    (22/Jun/04)
			const int WM_SYSCOMMAND = 0x112;
			const int SC_CLOSE = 0xF060;
			//
			switch(m.Msg)
			{
				case WM_SYSCOMMAND:
					if( m.WParam.ToInt32() == SC_CLOSE )
						esFormControlMenu = true;
					break; 
			}
			//
			base.WndProc(ref m);
		}


		private void toolbarsManager_BeforeToolbarListDropdown(object sender, Infragistics.Win.UltraWinToolbars.BeforeToolbarListDropdownEventArgs e)
		{
			e.Cancel = true;
		}

		private void explorerBar_NavigationContextMenuInitializing(object sender, Infragistics.Win.UltraWinExplorerBar.CancelableNavigationContextMenuInitializingEventArgs e)
		{
			e.Cancel = true;
		}

		private void explorerBar_ContextMenuInitializing(object sender, Infragistics.Win.UltraWinExplorerBar.CancelableContextMenuInitializingEventArgs e)
		{
			e.Cancel = true;
		}

		private void explorerBar_NavigationOptionsDialogDisplaying(object sender, Infragistics.Win.UltraWinExplorerBar.CancelableNavigationOptionsDialogDisplayingEventArgs e)
		{
			e.Cancel = true;
		}

		private void UpdateApplicationState()
		{
			
			mz.erp.businessrules.Sistema.GetLastProcessedInfo();
			int levelError = mz.erp.businessrules.Sistema.IdLevelError;
			string descripcion = mz.erp.businessrules.Sistema.Descripcion;
			DateTime lastProcessed = mz.erp.businessrules.Sistema.LastProcessed;
			double intervaloMax =Convert.ToDouble( Variables.GetValueLong("Debug.Sincronizacion.Intervalo"));
			if(lastProcessed.AddMilliseconds(intervaloMax) >= mz.erp.businessrules.Sistema.DateTime.Now)
			{
				if (levelError == 0)
				{
					this.statusBar.Panels["ProcessMessage"].Text = "No se encuentra el estado de la Aplicación";
					Infragistics.Win.UltraWinEditors.UltraPictureBox pic =(Infragistics.Win.UltraWinEditors.UltraPictureBox) this.statusBar.Panels[2].Control;
					pic.Image = null;
					this.statusBar.Panels["ProcessMessage"].Visible = false;

				}
				else
				{
					string path = mz.erp.systemframework.Util.ResourcePath() + @"\Resources\Icons\";
					string pathImage = path + mz.erp.businessrules.Sistema.FileNameImage;
					_foregroundImage = Image.FromFile(pathImage);
					int gravedad = mz.erp.businessrules.Sistema.Gravedad;
					this.statusBar.Panels["ProcessMessage"].Text= "Estado: " + descripcion;					
					Infragistics.Win.UltraWinEditors.UltraPictureBox pic =(Infragistics.Win.UltraWinEditors.UltraPictureBox) this.statusBar.Panels[2].Control;
					pic.Image = _foregroundImage;
					this.statusBar.Panels["ProcessMessage"].Visible = true;
					if(gravedad == 3)
					{
					
						_timerParpadeo.Start();

					}
					else
						_timerParpadeo.Stop();
				
					
				}	
			}
			else
			{
				mz.erp.businessrules.Sistema.SetApplicactionState(5);
				this.UpdateApplicationState();	
			}
		
	

		}

		private void ultraPictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void _timerParpadeo_Tick(object sender, EventArgs e)
		{
			Infragistics.Win.UltraWinEditors.UltraPictureBox pic =(Infragistics.Win.UltraWinEditors.UltraPictureBox) this.statusBar.Panels["SemaphoreStatus"].Control;
			if(pic.Image != null)
				pic.Visible = !pic.Visible;

			
		}

		private void ActualizarVersion()
		{
			DialogResult result2;
			result2 = MessageBox.Show("¿Desea salir de la aplicación e instalar la última versión?", "Actualización de " + Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result2 == DialogResult.Yes)
			{											
				System.Diagnostics.Process p=null;
				try
				{
					string targetDir;							
					targetDir = Variables.GetValueString("Sistema.Actualizacion.Directorio");
					p= new System.Diagnostics.Process();
					p.StartInfo.WorkingDirectory = targetDir;							
					p.StartInfo.FileName = Variables.GetValueString("Sistema.Actualizacion.Archivo");						
					//p.StartInfo.Arguments =  string.Format("C-Sharp Console application");
					p.StartInfo.CreateNoWindow = false;
					Application.Exit();
					p.Start();
					p.WaitForExit();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Excepción :{0},{1}", 
						ex.Message,ex.StackTrace.ToString());
				}
			}
		}


	}

}

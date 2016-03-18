
namespace mz.erp.ui.forms
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Diagnostics;
	
	using ClassLibrary1; //Manejador de Excepciones

	using mz.erp.businessrules;
	using mz.erp.businessrules.reportes;
	using mz.erp.commontypes;
	using mz.erp.systemframework;
	using System.Reflection;
	using mz.erp.ui.controls;
	using System.Security.Permissions;

	using System.Globalization;


	

	public class MainForm : System.Windows.Forms.Form
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
		

		private Image _foregroundImage = null;
		


		public MainForm()
		{
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

		[STAThread]
		static void Main() 		{									
			
			
			if (Variables.GetValueBool("Debug.ManejadorDeExcepciones"))
			{
				//#if RELEASE
				ClassLibrary1.UnhandledExceptionManager.AddHandler( false );	
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
			Application.Run( new MainForm() );

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.windowDockingArea1 = new Infragistics.Win.UltraWinDock.WindowDockingArea();
			((System.ComponentModel.ISupportInitialize)(this.explorerBar)).BeginInit();
			this.statusBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.toolbarsManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).BeginInit();
			this._MainFormAutoHideControl.SuspendLayout();
			this.dockableWindow1.SuspendLayout();
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
			this.explorerBar.FlatMode = true;
			this.explorerBar.ImageListLarge = this.imageListLargeEB;
			this.explorerBar.ImageListSmall = this.imageListSmallEB;
			this.explorerBar.Location = new System.Drawing.Point(0, 19);
			this.explorerBar.Name = "explorerBar";
			this.explorerBar.ShowDefaultContextMenu = false;
			this.explorerBar.Size = new System.Drawing.Size(211, 462);
			this.explorerBar.TabIndex = 23;
			this.explorerBar.ContextMenuInitializing += new Infragistics.Win.UltraWinExplorerBar.ContextMenuInitializingEventHandler(this.explorerBar_ContextMenuInitializing);
			this.explorerBar.NavigationContextMenuInitializing += new Infragistics.Win.UltraWinExplorerBar.NavigationContextMenuInitializingEventHandler(this.explorerBar_NavigationContextMenuInitializing);
			this.explorerBar.NavigationOptionsDialogDisplaying += new Infragistics.Win.UltraWinExplorerBar.NavigationOptionsDialogDisplayingEventHandler(this.explorerBar_NavigationOptionsDialogDisplaying);
			this.explorerBar.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.explorerBar_ItemClick);
			// 
			// imageListLargeEB
			// 
			this.imageListLargeEB.ImageSize = new System.Drawing.Size(24, 24);
			this.imageListLargeEB.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageListSmallEB
			// 
			this.imageListSmallEB.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListSmallEB.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageListSmall
			// 
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
			this.statusBar.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] {
																										 ultraStatusPanel1,
																										 ultraStatusPanel2,
																										 ultraStatusPanel3,
																										 ultraStatusPanel4,
																										 ultraStatusPanel5,
																										 ultraStatusPanel6,
																										 ultraStatusPanel7});
			this.statusBar.Size = new System.Drawing.Size(800, 23);
			this.statusBar.TabIndex = 1;
			this.statusBar.Text = "statusBar";
			// 
			// toolbarsManager
			// 
			this.toolbarsManager.DockWithinContainer = this;
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
			this.imageListLarge.ImageSize = new System.Drawing.Size(24, 24);
			this.imageListLarge.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// _MainForm_Toolbars_Dock_Area_Left
			// 
			this._MainForm_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(190)), ((System.Byte)(245)));
			this._MainForm_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
			this._MainForm_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
			this._MainForm_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 54);
			this._MainForm_Toolbars_Dock_Area_Left.Name = "_MainForm_Toolbars_Dock_Area_Left";
			this._MainForm_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 481);
			this._MainForm_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolbarsManager;
			// 
			// _MainForm_Toolbars_Dock_Area_Right
			// 
			this._MainForm_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(190)), ((System.Byte)(245)));
			this._MainForm_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
			this._MainForm_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
			this._MainForm_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(800, 54);
			this._MainForm_Toolbars_Dock_Area_Right.Name = "_MainForm_Toolbars_Dock_Area_Right";
			this._MainForm_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 481);
			this._MainForm_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolbarsManager;
			// 
			// _MainForm_Toolbars_Dock_Area_Top
			// 
			this._MainForm_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(190)), ((System.Byte)(245)));
			this._MainForm_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
			this._MainForm_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
			this._MainForm_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
			this._MainForm_Toolbars_Dock_Area_Top.Name = "_MainForm_Toolbars_Dock_Area_Top";
			this._MainForm_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(800, 54);
			this._MainForm_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolbarsManager;
			// 
			// _MainForm_Toolbars_Dock_Area_Bottom
			// 
			this._MainForm_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(190)), ((System.Byte)(245)));
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
			this.ultraDockManager1.FlatMode = true;
			this.ultraDockManager1.HostControl = this;
			this.ultraDockManager1.ShowCloseButton = false;
			this.ultraDockManager1.ShowDisabledButtons = false;
			this.ultraDockManager1.UseDefaultContextMenus = false;
			// 
			// _MainFormUnpinnedTabAreaLeft
			// 
			this._MainFormUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this._MainFormUnpinnedTabAreaLeft.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._MainFormUnpinnedTabAreaLeft.Location = new System.Drawing.Point(0, 54);
			this._MainFormUnpinnedTabAreaLeft.Name = "_MainFormUnpinnedTabAreaLeft";
			this._MainFormUnpinnedTabAreaLeft.Owner = this.ultraDockManager1;
			this._MainFormUnpinnedTabAreaLeft.Size = new System.Drawing.Size(21, 481);
			this._MainFormUnpinnedTabAreaLeft.TabIndex = 18;
			// 
			// _MainFormUnpinnedTabAreaRight
			// 
			this._MainFormUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right;
			this._MainFormUnpinnedTabAreaRight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._MainFormUnpinnedTabAreaRight.Location = new System.Drawing.Point(800, 54);
			this._MainFormUnpinnedTabAreaRight.Name = "_MainFormUnpinnedTabAreaRight";
			this._MainFormUnpinnedTabAreaRight.Owner = this.ultraDockManager1;
			this._MainFormUnpinnedTabAreaRight.Size = new System.Drawing.Size(0, 481);
			this._MainFormUnpinnedTabAreaRight.TabIndex = 19;
			// 
			// _MainFormUnpinnedTabAreaTop
			// 
			this._MainFormUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top;
			this._MainFormUnpinnedTabAreaTop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._MainFormUnpinnedTabAreaTop.Location = new System.Drawing.Point(21, 54);
			this._MainFormUnpinnedTabAreaTop.Name = "_MainFormUnpinnedTabAreaTop";
			this._MainFormUnpinnedTabAreaTop.Owner = this.ultraDockManager1;
			this._MainFormUnpinnedTabAreaTop.Size = new System.Drawing.Size(779, 0);
			this._MainFormUnpinnedTabAreaTop.TabIndex = 20;
			// 
			// _MainFormUnpinnedTabAreaBottom
			// 
			this._MainFormUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._MainFormUnpinnedTabAreaBottom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._MainFormUnpinnedTabAreaBottom.Location = new System.Drawing.Point(21, 535);
			this._MainFormUnpinnedTabAreaBottom.Name = "_MainFormUnpinnedTabAreaBottom";
			this._MainFormUnpinnedTabAreaBottom.Owner = this.ultraDockManager1;
			this._MainFormUnpinnedTabAreaBottom.Size = new System.Drawing.Size(779, 0);
			this._MainFormUnpinnedTabAreaBottom.TabIndex = 21;
			// 
			// _MainFormAutoHideControl
			// 
			this._MainFormAutoHideControl.Controls.Add(this.dockableWindow1);
			this._MainFormAutoHideControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._MainFormAutoHideControl.Location = new System.Drawing.Point(21, 54);
			this._MainFormAutoHideControl.Name = "_MainFormAutoHideControl";
			this._MainFormAutoHideControl.Owner = this.ultraDockManager1;
			this._MainFormAutoHideControl.Size = new System.Drawing.Size(16, 481);
			this._MainFormAutoHideControl.TabIndex = 22;
			// 
			// dockableWindow1
			// 
			this.dockableWindow1.Controls.Add(this.explorerBar);
			this.dockableWindow1.Location = new System.Drawing.Point(0, 0);
			this.dockableWindow1.Name = "dockableWindow1";
			this.dockableWindow1.Owner = this.ultraDockManager1;
			this.dockableWindow1.Size = new System.Drawing.Size(211, 481);
			this.dockableWindow1.TabIndex = 0;
			// 
			// windowDockingArea1
			// 
			this.windowDockingArea1.Cursor = System.Windows.Forms.Cursors.Default;
			this.windowDockingArea1.Dock = System.Windows.Forms.DockStyle.Left;
			this.windowDockingArea1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.windowDockingArea1.Location = new System.Drawing.Point(21, 54);
			this.windowDockingArea1.Name = "windowDockingArea1";
			this.windowDockingArea1.Owner = this.ultraDockManager1;
			this.windowDockingArea1.Size = new System.Drawing.Size(216, 481);
			this.windowDockingArea1.TabIndex = 24;
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
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.Text = "Mz ERP Formulario Principal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);			
			this.Closing+=new CancelEventHandler(MainForm_Closing);
			((System.ComponentModel.ISupportInitialize)(this.explorerBar)).EndInit();
			this.statusBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.toolbarsManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTabbedMdiManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraDockManager1)).EndInit();
			this._MainFormAutoHideControl.ResumeLayout(false);
			this.dockableWindow1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void MainForm_Load(object sender, System.EventArgs e)
		{
#if DEBUG


			
			/*if (!utility.ControlVersion.IsValidVersion())
			{
				System.Windows.Forms.MessageBox.Show( "La versión de la aplicación no coincide con la versión de la base de datos", "Error",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error );
				Application.Exit();
			}*/

			Splash _splash = new Splash();
			_splash.ShowDialog();
			ultraDockManager1.UnpinAll();
			LogIn _logIn = new LogIn();
			_logIn.ShowDialog( this );
			if ( _logIn.DialogResult == DialogResult.OK )
			{				
				Security.IdIdioma = 1;
				utility.ToolsLoader.Load( this.toolbarsManager, this.explorerBar );
				this.ConfigToolsBar();
				//Variables.Load();
				if ((Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault")) != "")
				{
					ProcessTool(Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault"));
				}
				
				this.statusBar.Panels["UserName"].Text="Usuario Actual: " + Security.IdUsuario;
				this.statusBar.Panels["Perfil"].Text="Perfil: " + Security.Perfil;
				this.statusBar.Panels["Cotizacion"].Text= "Cotización: " + tfi_CotizacionesMonedas.GetCoeficienteCotizacionPorDefecto(2).ToString();
					
				_allwSemaphore = Variables.GetValueBool("Debug.Semaforo.Habilitado");				
				if(_allwSemaphore)
				{
					this.UpdateApplicationState();
				}
				else
				{
					this.statusBar.Panels["SemaphoreStatus"].Visible= false;
					this.statusBar.Panels["SemaphoreStatus"].Visible = false;
				}
				if (Variables.GetValueBool("System.PermiteCierreSesionAutomatico"))
				{
					this.InitializeTimer();
				}			
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
			this.Cursor = Cursors.WaitCursor;
			System.Console.WriteLine(key);
			switch ( key )

			{	
				#region Sesión				

				case "ProcesoIniciarSesion"://"Cerrar Sesion":
					this.CerrarSesion();
					break;
				case "ProcesoCambiarContraseña"://"Cambiar contraseña":
					CallProcess(key);			
					break;	
				case "ProcesoReestablecerContrasenia"://"Cambiar contraseña":
					CallProcess(key);			
					break;	
				case "ProcesoSalir"://"Salir":
					Application.Exit();
					break;
				
					#endregion
		
					#region Compras 
				
				case "ProcesoCompraConsultaArticulos"://"Consulta de Articulos":
					//FilterDocumentLoader( typeof( mz.erp.ui.tsh_Productos),null,typeof(mz.erp.ui.forms.FrmConsultaArticulos),"Consulta de Stock y Precios");
					mzProductosSearchForm sfcompras = new mzProductosSearchForm(false);
					sfcompras.ShowDialog();
					break;

				case "ProcesoComprasPedidosConfirmarYEnviar": //"Logitica Pedidos a Proveedores Cerrar Pedido":
				{
					ComprobanteDeCompraLoader("Pedir");
					break;
				}
	
				case "ProcesoConsultarStockNDias":
				{
					CallProcess("ProcesoConsultarStockNDias");
					break;
				}

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

				case "ProcesoRegistrarNumerosDeSeriesPendientes":
				{
					CallProcess("ProcesoRegistrarNumerosDeSeriesPendientes");
					break;
				}

				case "ProcesoConfirmarIngresoMercaderia":
				{
					CallProcess("ProcesoConfirmarIngresoMercaderia");
					break;
				}

				case "ComprasProcesoModificarPrecioProducto":
				{
					CallProcess("ProcesoModificarPrecioProducto");
					break;
				}
					#endregion

					#region Compras / Consultas
				case "ProcesoComprasConsultaListadoDeIngreso":
				{		
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-10));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Proveedor","Proveedor",true,null);
					array.Add( "Responsable","Responsable de Emisión",true,null);
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeIngreso), "Listado de Ingreso", array, typeof( mz.erp.ui.forms.FrmConsultas ), false, true); 
					break;
				}
				case "ProcesoComprasConsultaListadoComprasPorArticulo":
				{	
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-10));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Producto","Producto",true,null);
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeComprasPorArt), "Listado de Compras por Artículo", array, typeof( mz.erp.ui.forms.FrmConsultas ), new mz.erp.ui.controllers.DetalleArticulosPorCompra()); 
					break;
				}
				case "ProcesoConsultaSeguimientos":
				{
					CallProcess("ProcesoConsultaSeguimientos");
					break;
				}
				case "ComprasProcesoConsultarProductosNumerosDeSerie":
				{
					CallProcess("ProcesoConsultarProductosNumerosDeSerie");
					break;
				}
				case "ProcesoConsultarComprasListaDePrecios":
				{
					CallProcess("ProcesoConsultarComprasListaDePrecios");
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

				case "ProcesoConsultarStock"://"Reportes Reporte de Stock":
				{					
					FrmParameterReports frmPR = new FrmParameterReports("ReportStock.RPX");
					frmPR.ShowDialog();					
				}
					break;

				case "ProcesoMovimientos"://"Listado de Movimentos de Stock":
				{ 
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					//array.Add( "Persona","Responsable de Emisión",true,null);
					array.Add( "Responsable","Responsable de Emisión",true,null);
					array.Add( "Producto","Producto", true, null);
					array.Add( "TipoDeAjuste", "Tipo de Ajuste", true,null);
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeMovimientosDeStock), "Listado de Movimientos de Stock", array, typeof( mz.erp.ui.forms.FrmConsultas )); 
					break;
				}
				case "ProcesoConsultarAjustes"://"Listado de Ajustes de Stock":
				{					
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					//array.Add( "Persona","Responsable de Emisión",true,null);
					array.Add( "Responsable","Responsable de Emisión",true,null);
					array.Add( "Producto","Producto", true, null);
					array.Add( "TipoDeAjuste", "Tipo de Ajuste", true,null);
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeAjustesDeStock), "Listado de Ajustes de Stock", array, typeof( mz.erp.ui.forms.FrmConsultas )); 
					break;
				}
				case "ProcesoStockConsArticDesacConStock": //"Listado de Artículos desactivados con Stock":
				{
					string aux = "Temporal";
					System.Console.WriteLine((string) (aux.Substring(1,3)));
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeArtDesacConStock), "Listado de Artículos Desactivados con Stock",array , typeof( mz.erp.ui.forms.FrmConsultas )); 
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
					sf.ShowDialog();
					break;

				case "ProcesoPreciosActualizados"://"Precios Actualizados":
				{//ST ubicacion: Procesos/Precios actualizados
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
													
					ReportDocumentLoader( typeof( mz.erp.ui.tsh_ReportesAcutalizacionDePrecios), "Actualización de precios", array, typeof( mz.erp.ui.forms.FrmAbmExProductos)); 

					break;
				}
				case "Autorizaciones":
				{
					CallProcess("ProcesoAutorizar");
					break;
				}
					#endregion

					#region Ventas / Emitir Comprobantes

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
					

					#endregion

					#region Ventas / Cuentas Corrientes
			
				case "ProcesoCuentaCorrienteCliente"://"Cuenta Corriente": 
					FrmVisualizacionCuentaCorriente frmVCC= new FrmVisualizacionCuentaCorriente("ProcesoCuentaCorrienteCliente");
					frmVCC.MdiParent= this;
					frmVCC.Show();
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

				case "ProcesoNotaDeCredito"://"Notas de Credito";
					CallProcess( "ProcesoNotaDeCredito" );
					break;

					/*ProcesoNotaDeDebito*/
					#endregion

					#region Ventas / Consultas
				
				case "ProcesoConsultaCompDeVenta"://"Consulta de Comprobantes":
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta");
					array.Add( "Fecha","Desde Fecha");
					array.Add( "Fecha","Hasta Fecha");
					array.Add( "Persona","Responsable de Emisión");
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",true,"Facturas");
					ReportDocumentLoader( typeof( mz.erp.ui.tsa_ReporteComprobantesDeVenta), "Comprobantes de Venta", array, typeof( mz.erp.ui.forms.FrmComprobantes ));
					break;
				}

				case "ProcesoConsultaPresupuestos"://"Consulta de Presupuestos":
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta",true,null);
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);
						
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Presupuestos");
						
					ReportDocumentLoader( typeof( mz.erp.ui.tsa_ReporteComprobantesDeVenta), "Presupuestos", array, true);

					break;
				}
				
				case "ProcesoConsultaCompPorDetalle": //"Ventas Consultas Detalle Comprobantes":
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Cuenta","Cuenta");
					array.Add( "Fecha","Desde Fecha");
					array.Add( "Fecha","Hasta Fecha");
					array.Add( "Persona","Responsable de Emisión");
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",true,"Facturas");
					ArrayList grupos = new ArrayList();
					grupos.Add("Descripcion"); //es el comprobante
					grupos.Add("Numero");
					//ReportDocumentLoader( typeof( mz.erp.ui.tsa_ReporteDetalleComprobanteDeVenta), "Detalle de Comprobantes de Venta", array);				
					ReportDocumentLoaderSA( typeof( mz.erp.ui.tsa_ReporteDetalleComprobanteDeVenta), "Detalle de Comprobantes de Venta", array, false, grupos, true, "Total");
					break;
				}

				case "ProcesoConsultaOtrosComprobantes"://Ventas / consultas / otros comprobantes
				{
					CallProcess( "ProcesoConsultaOtrosComprobantes" );
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

					case "ProcesoPreprestarPrestar":
					{
						this.CallProcess( "ProcesoPreprestarPrestar" );  
					}
					break;

					case "ProcesoCajaPagosCuentaCorriente"://"Caja Pagos a Cuenta":
						CallProcess( "ProcesoPagar" );
					break;

					case "ProcesoCuentaCorrienteClienteDV":
					{
						FrmVisualizacionCuentaCorriente frmVCCdv= new FrmVisualizacionCuentaCorriente("ProcesoCuentaCorrienteClienteDV");
						frmVCCdv.MdiParent= this;
						frmVCCdv.Show();
					}
					break;

				case "ProcesoPagoACuentaDV"://"Caja Pagos a Cuenta":
					
					CallProcess( "ProcesoPagoACuentaDV" );
				
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
				case "ProcesoConsultarPosicionDeCaja":
				{
					CallProcess("ProcesoConsultarPosicionDeCaja");
					break;
				}
				case "ProcesoConsultaPosicionDeCajaDetallado":
				{
					CallProcess("ProcesoConsultarPosicionDeCajaDetallado");
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
				case "ProcesoRemitir"://"Remitos":
				{
					CallProcess("ProcesoRemitir");
					break;
				}


						#endregion

						#region Entregas / Consultas
				case "ProcesoEntregasConsultaOrdenesPendientes": //consulta 1 --> 889
				{
					CallProcess( "ProcesoEntregasConsultaOrdenesPendientes" );
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

					/*case "ProcesoEntregasConsultaEnviosPorTransportista": //consulta 6
					{
						CallProcess( "" );
					}
						break;
					*/
	
						#endregion
		
						#region Reportes / De Valores
						#endregion

						#region Reportes / Contables
						/*ProcesoRepSubdiarioImpuestos*/

				case "ProcesoRepSubdiarioVentas"://"Libro de IVA":					
				{
					ReportsManager.PrintReportLibroDeIVA(this);
					FrmParameterReports frmPR = new FrmParameterReports("ReportLibroDeIVA.RPX");
					frmPR.ShowDialog();	
					break;
				}	
				case "ProcesoListadoIngresosBrutos"://"Listado de Ingresos Brutos":				
				{					
					FrmParameterReports frmPR = new FrmParameterReports("ReportListadoIngresosBrutos.rpx");
					frmPR.ShowDialog();	
					break;
				}	
				
				case "ProcesoRepStockValorizado"://"Listado de Valorizacion de Stock":
				{
					ReportFilterArray array = new mz.erp.commontypes.ReportFilterArray();
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-1));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Producto","Producto", true, null);
					array.Add( "Deposito","Depósito",true, null);
					array.Add( "Seccion","Sección",true, null);
					array.Add( "EstadoDeStock","Estado de Stock", true, null);
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeValorizacionDeStock), "Listado de Valorización de Stock", array, typeof( mz.erp.ui.forms.FrmConsultas )); 
					break;
				}
		

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
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					//array.Add( "Jerarquia","Proveedor",true,null);
					ReportDocumentLoader( typeof( mz.erp.ui.reportes.rep_ListadoDeVentasPorProducto), "Listado de Ventas por Producto", array, typeof( mz.erp.ui.forms.FrmConsultas )); 
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
				}
					break;

					#endregion
				
						#region Datos / Nuevo

				case "ProcesoDatosNuevoProveedor"://"Nuevo Nuevo Proveedor":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmProveedores), "Proveedores");
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
					FilterDocumentLoader( typeof ( mz.erp.ui.tsh_Personas ), typeof( mz.erp.ui.forms.FrmAbmPersonas ), "Personas");
					//GridDocumentLoader( new ui.tsh_Personas(), "Personas" );
					break;
				case "ProcesoDatosAbrirProducto"://"Abrir Abrir Producto":
					FilterDocumentLoader( typeof ( mz.erp.ui.tsh_Productos ), typeof( mz.erp.ui.forms.FrmAbmExProductos ), "Productos");
					//GridDocumentLoader( new ui.tsh_Productos(), "Productos" );
					break;
				case "ProcesoDatosAbrirCliente"://"Abrir Abrir Cliente":
					FilterDocumentLoader( typeof ( mz.erp.ui.tsa_Cuentas ), typeof( mz.erp.ui.forms.FrmAbmCuentas ), "Clientes" );										
					break;
				case "ProcesoDatosAbrirProveedor"://"Abrir Abrir Proveedor":
					FilterDocumentLoader( typeof ( mz.erp.ui.tpu_Proveedores ), typeof( mz.erp.ui.forms.FrmAbmProveedores ), "Proveedores" );					
					break;

				case "ProcesoDatosAbrirUsuario"://"Abrir Usuario":					
					FilterDocumentLoader( typeof ( mz.erp.ui.sy_Usuarios ), typeof ( mz.erp.ui.forms.FrmAbmUsuariosEx ), "Usuarios" );					
					break;			
						/*	case "ProcesoDatosAbrirElemento":				
							break;	
						*/
				case "ProcesoDatosAbrirTransporte":
					FilterDocumentLoader( typeof ( mz.erp.ui.tlg_Transportes ), typeof( mz.erp.ui.forms.FrmAbmTransportes), "Transportes");
					break;
				
						#endregion
				
						#region Datos / Datos Auxiliares / Sistemas
				
				case "ProcesoDatosAuxSistVariables"://"Datos Auxiliares Sistema Variables":
					GridDocumentLoader( new mz.erp.ui.sy_Variables( new string[] {"IdVariable","Descripcion","ValorDefault","IdTipoVariable"}), "Variables" );
					break;
				case "ProcesoDatosAuxSistTiposDeVariables"://"Datos Auxiliares Sistema Tipos Variables":
					
					GridDocumentLoader( new mz.erp.ui.sy_TiposVariables( new string[] {"IdTipoVariable","Descripcion"}), "Tipos de Variables" );
					break;
				case "ProcesoDatosAuxSistSucursales"://"Datos Auxiliares Sistema Sucursales":
					FilterDocumentLoader( typeof ( mz.erp.ui.sy_Sucursales ), typeof( mz.erp.ui.forms.FrmAbmSucursales ), "Sucursales" );
					break;
				case "ProcesoDatosAuxSistVarPorPerfil"://"Datos Auxiliares Sistema Variables por Perfiles":
					
					
					GridDocumentLoader( new ui.sy_VariablesPerfiles(), "Variables por Perfiles" );
					break;
					
				case "ProcesoDatosAuxSistVarPorUsuario":
					GridDocumentLoader( new ui.sy_VariablesUsuarios(), "Variables por Usuarios" );
					break;

				case "ProcesoDatosAuxSistJerarquiaVariables":
					FrmJerarquiaAgrupVariables form = new FrmJerarquiaAgrupVariables();
					form.MdiParent = this;
					form.Text = "Jerarquía de variables";
					form.Show();
					break;

						#endregion
				
						#region Datos / Datos Auxiliares / Clientes

				case "ProcesoDatosAuxCliTratamientos"://"Datos Auxiliares Clientes Tratamientos":
					GridDocumentLoader( new ui.tcs_Tratamiento(), "Tratamientos" );
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

						#endregion

						#region Datos / Datos Auxiliares / Logistica
				
				case "ProcesoDatosAuxLogZonas"://"Zonas":
				//ST ubicacion: Archivo/Datos auxiliares/Logistica/Zonas
					FilterDocumentLoader( typeof ( mz.erp.ui.tlg_Zonas ), typeof( mz.erp.ui.forms.FrmAbmZonas), "Zonas");
					break;
				
				case "ProcesoDatosAuxLogDepositos"://"Datos Auxiliares Logistica Depositos":
					GridDocumentLoader( new ui.tlg_Depositos(), "Depositos" );
					break;
				case "ProcesoDatosAuxLogSecciones"://"Datos Auxiliares Logistica Secciones":
					GridDocumentLoader( new ui.tlg_Secciones(), "Secciones" );
					break;
				case "ProcesoDatosAuxLogTiposDeAjustes"://"Datos Auxiliares Logistica Tipos de Ajustes de Stock":
					FilterDocumentLoader( typeof( mz.erp.ui.tlg_TiposDeAjuste), typeof(mz.erp.ui.forms.FrmAbmTiposDeAjuste), "Tipos de Ajustes de Stock" );
					break;
					
						#endregion

						#region Datos / Datos Auxiliares / Ventas 

				case "ProcesoDatosAuxVentasBonificaciones"://"Datos Auxiliares Ventas Bonificaciones":
					FilterDocumentLoader( typeof (mz.erp.ui.tsa_BonificacionesEx), typeof( mz.erp.ui.forms.FrmAbmBonificacionesEx), "Bonificaciones");
					break;

						#endregion

						#region Datos / Datos Auxiliares / Productos
				
				case "ProcesoDatosAuxProdUnidadesDeMedida"://"Datos Auxiliares Productos Unidades de Medidas":
					GridDocumentLoader( new ui.tsh_Unidades(), "Unidades de Medidas" );
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
					FrmJerarquiaAgrupProd formjAP = new FrmJerarquiaAgrupProd();
					formjAP.MdiParent = this;
					formjAP.Text = "Jerarquía de productos";
					formjAP.Show();
					break;		

						#endregion

						#region Datos / Datos Auxiliares / Contabilidad
				
				case "ProcesoDatosAuxContabilidadEntidades"://"Datos Auxiliares Contabilidad Entidades":
					FilterDocumentLoader( typeof ( mz.erp.ui.tfi_Entidades ), typeof( mz.erp.ui.forms.FrmAbmEntidades ), "Entidades" );
					//NewDocumentLoader( typeof( mz.erp.ui.forms.FrmAbmEntidades ), "Entidades");
					break;
				case "ProcesoDatosAuxContabilidadCajas":
					GridDocumentLoader( new ui.tfi_Cajas(), "Cajas" );
					break;
					
						//FALTA AGREGAR UNOOOO
						//ProcesoDatosAuxContabilidadCaja

				case "ProcesoDatosAuxContabilidadRespDeCaja":
					GridDocumentLoader( new ui.tfi_ResponsablesCajas(), "Responsables de Caja" );
					break;
				

						#endregion

						#region Datos / Datos Auxiliares / General
			
				case "ProcesoDatosAuxGeneralLocalidades"://"Datos Auxiliares General Localidades":
					NewDocumentLoader( typeof ( mz.erp.ui.forms.FrmAbmLocalidades ),  "Localidades" );
					break;

				case "ProcesoABMCotizacionMoneda"://"Datos Auxiliares General Localidades":
					this.CallProcess( "ProcesoABMCotizacionMoneda" );  
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
				break;	


						#endregion

						#region Procesos
	
				case "ProcesoProcesosSincronizarCFiscal"://"Sincronizar Controlador Fiscal":					
				{

					DialogResult result;
					result = MessageBox.Show("¿Desea provocar excepción en esta aplicación?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(result == DialogResult.Yes)
					{													
						decimal num = 0;
						decimal num2 = 2 / num;
					}

				}
					/*FrmFiscal frmFis = new FrmFiscal();	
						if (frmFis.Sincronizacion()) 
						{
							if (Variables.GetValueBool("Fiscal.CierreAutomatico")) 
							{
								frmFis.Close();
							}
						}*/
					break;

						case "ProcesoCajaCierreX"://"Cierre X":
							this.CallProcess( "ProcesoCierreX" );  
							break;
						case "ProcesoCajaCierreZ"://"Cierre Z":
							this.CallProcess( "ProcesoCierreZ" );  
							break;
						case "ProcesoProcesosTestFiscal"://"Test fiscal": 
						{
							frmTestFiscal _form = new frmTestFiscal();
							_form.MdiParent = this;					
							_form.Show();
							break;
						}
						case "ProcesoTest1" :					
						{ //test 1
							//CallProcess("ProcesoABMCuentasObservaciones");							
							/*string IdCuenta = "00001000010000013158";
							mz.erp.ui.controllers.forms.mzCuentasSearchForm csf = new mz.erp.ui.controllers.forms.mzCuentasSearchForm(IdCuenta);							
							csf.ShowDialog();*/
							frmTest frmtest = new frmTest();
							frmtest.ShowDialog();
							break;
						}
						
						#endregion

						#region Ayuda

				
				case "ProcesoReiniciarVariables":
				{
					Variables.Reset();
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
					string connection = "User ID=sa;password=03461441874;Initial Catalog=ErpPrincipal2115;Data Source=MZERP";
					string encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64( connection );
					
					Splash _splash = new Splash();
					_splash.ShowModal();
					
					break;
					

					//UnhandledExceptionManager.GenericExceptionHandlerToDB(e);
				}

				case "ProcesoActualizacionSistema": 
				{
					DialogResult result2;
					result2 = MessageBox.Show("¿Está seguro que desea salir de la aplicación e instalar la última versión?", "Actualización de " + Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
					FilterDocumentLoader( typeof ( mz.erp.ui.tsa_Cuentas ), typeof( mz.erp.ui.forms.FrmAbmCuentas ), "Clientes" );										
					break;
				}							
				case "Datos Auxiliares Clientes Cargos":
					GridDocumentLoader( new ui.tcs_Cargos(), "Cargos" );
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
					array.Add( "Fecha","Hasta Fecha");
					array.Add( "Persona","Responsable de Emisión");
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",true,"Facturas");
					ReportDocumentLoader( typeof( mz.erp.ui.tsa_ReporteDetalleComprobanteDeVenta), "Detalle de Comprobantes de Venta", array, false);
					break;
				}

				case "Datos Auxiliares Clientes Tipos de Contactos":
					GridDocumentLoader( new ui.tcs_TiposContactos(), "Tipos de contactos" );
					break;

				case "Datos Auxiliares Clientes Tipos de Domicilios":
					GridDocumentLoader( new ui.tcs_TiposDomicilios(), "Tipos de domicilios" );
					break;
			
				case "DatosAuxiliares Compras Motivo de Devoluciones":
					GridDocumentLoader( new ui.tpu_MotivosDevoluciones(), "Motivos de Devoluciones de Compras" );
					break;
				
				case "Datos Auxiliares Sistema Categorias de Iva":
					GridDocumentLoader( new ui.tsy_CategoriasIva( new string[] {"IdCategoriaIva","Descripcion","ActivoVentas","ActivoCompras","Clase","Discrimino","LPT","s"}), "Categorias de Iva" );
					break;

				case "Datos Auxiliares Sistema Tipos de Documentos":
					GridDocumentLoader( new ui.tsy_TiposDocumentos( new string[]{ "idTipoDocumento", "Descripcion"} ), "Tipos de Documento" );
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
					array.Add( "Fecha","Desde Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30));
					array.Add( "Fecha","Hasta Fecha",true,mz.erp.businessrules.Sistema.DateTime.Now);
					array.Add( "Persona","Responsable de Emisión",true,null);
						
					array.Add("TipoDeComprobanteAgrupado","Tipos de Comprobantes",false,"Pedidos");
						
					ReportDocumentLoader( typeof( mz.erp.ui.DetalleComprobantesDeCompraPendientes), "Comprobantes de Compra", array , false);

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
				
					FilterDocumentLoader( typeof ( mz.erp.ui.tpr_ObjetosEx ), typeof( mz.erp.ui.forms.FrmAbmObjetos ), "Elementos");
				
					break;
				
				case "Procesos Resetear Estado Aplicacion"://????
				
					mz.erp.businessrules.Sistema.SetApplicactionState(1);
					bool _allwSemaphore = Variables.GetValueBool("Debug.Semaforo.Habilitado");
					if(_allwSemaphore)
						this.UpdateApplicationState();
				
					break;

		
						#endregion


				default :
					MessageBox.Show( "Función no implementada! " + key,"Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
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

		public void CerrarSesion()
		{	
			foreach(Form form in this.MdiChildren)
				form.Close();
			ResetTools();
			ResetVariables();
			
			ultraDockManager1.UnpinAll();
			LogIn _logIn = new LogIn();
			_logIn.ShowDialog( this );

			if ( _logIn.DialogResult == DialogResult.OK )
			{	//carga el formulario default de inicio 
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
				if ((Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault")) != "")
				{
					ProcessTool(Variables.GetValueString("Sistema.Interfaz.FormularioInicioDefault"));
				}
				//Security.IdPerfil = _logIn.pe;
				Security.IdIdioma = 1;
				utility.ToolsLoader.Load( this.toolbarsManager, this.explorerBar );
				this.statusBar.Panels["UserName"].Text="Usuario Actual: " + Security.IdUsuario;
				this.statusBar.Panels["Perfil"].Text="Perfil: " + Security.Perfil;
				this.statusBar.Panels["Cotizacion"].Text= "Cotización: " + tfi_CotizacionesMonedas.GetCoeficienteCotizacionPorDefecto(2).ToString();
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

		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, Type stepType, bool allowMultipleRows )
		{			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.StepType = stepType;
			_form.Text = caption;
			_form.AllowMultipleSelect = allowMultipleRows;
			_form.MdiParent = this;
			_form.Show();
		}

		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, Type stepType, bool allowMultipleRows, string momentoStepDefault )
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
			_form.Show();
		}

		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros,  Type stepType, bool allowMultipleRows )
		{			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
		
			_form.StepType = stepType;
			_form.Text = caption;
			_form.AllowMultipleSelect = allowMultipleRows;
			_form.MdiParent = this;
			_form.Show();
		}
		

		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, Type stepType )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.StepType = stepType;
			_form.Text = caption;
			_form.MdiParent = this;
			_form.Show();
		}
		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.Text = caption;
			_form.MdiParent = this;
			_form.Show();
		}

		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType,bool allowMultipleRows, bool AllowShowDetails )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.EditType = editType;
			_form.AllowMultipleSelect = false;
			_form.AllowShowDetail = AllowShowDetails;
			_form.Text = caption;
			_form.MdiParent = this;
			_form.Show();
		}

		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros, Type editType, mz.erp.ui.controllers.IDetailController detailControllerInstance )
		{
			
			FrmConsultas _form = new FrmConsultas( );
			_form.Filtros = filtros;
			_form.ReportType = reportType;
			_form.DetailControllerInstance = detailControllerInstance;
			_form.EditType = editType;
			_form.Text = caption;
			_form.MdiParent = this;
			_form.Show();
		}

		private void ReportDocumentLoaderSA( Type reportType, string caption, ReportFilterArray filtros , bool mustImprimir, ArrayList grupos, bool editGrupos, string filaSum )
		{
			FrmConsultas _form = new FrmConsultas( filtros, reportType, grupos, editGrupos, filaSum );
			_form.Text = caption;
			_form.MdiParent = this;
			_form.MustImprimir = mustImprimir;
			_form.Show();
		}

		private void ReportDocumentLoader( Type reportType, string caption, ReportFilterArray filtros , bool mustImprimir)
		{

			FrmConsultas _form = new FrmConsultas( filtros, reportType );
			_form.Text = caption;
			_form.MdiParent = this;
			_form.MustImprimir = mustImprimir;
			_form.Show();
		}
		private void GridDocumentLoader( IGridDocument gridDocument, string caption )
		{
			GridDocument _gridDocument = new GridDocument( gridDocument );
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
			catch(Exception e){Debug.WriteLine(e.StackTrace);Debug.WriteLine(e.Message);}
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
	}
}

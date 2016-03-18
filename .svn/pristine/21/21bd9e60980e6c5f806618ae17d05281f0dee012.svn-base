using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Janus.Windows.GridEX;

using mz.replication.configuration;
using mz.replication.dataaccess;
using mz.replication.filetransfer;

namespace mz.replication.filetransfer.ui
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItemArhivoSalir;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.ImageList imageList;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItemEnviarRecibir;
		private System.Windows.Forms.MenuItem menuItemEnviar;
		private System.Windows.Forms.MenuItem menuItemRecibir;
		
		private System.Windows.Forms.StatusBar statusBar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.Panel panel2;
		private Infragistics.Win.UltraWinListBar.UltraListBar ultraListBar1;
		private System.Windows.Forms.ImageList imageListSmall;
		private FileReplication _fileReplication;

		private ConfigInfo _configInfo;
		private BandejaData _bandeja;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItemProcesarSentenciasDeReplicacion;
		private string _idBandeja;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panelGrid;
		private Janus.Windows.GridEX.GridEX gridEX;
		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.Splitter splitter2;
		private JobBuilder _jobBuilder;
		private AxSHDocVw.AxWebBrowser axWebBrowser;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem7;
		private string _tempFile = string.Empty;

		public FormMain()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			_configInfo = ConfigInfo.Read( AppDomain.CurrentDomain.BaseDirectory + "ServiceConfigInfo.xml" );
			_fileReplication = new FileReplication( _configInfo );
			_jobBuilder = new JobBuilder( _configInfo );
			_bandeja = new BandejaData();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormMain));
			Infragistics.Win.UltraWinListBar.Group group1 = new Infragistics.Win.UltraWinListBar.Group(true);
			Infragistics.Win.UltraWinListBar.Item item1 = new Infragistics.Win.UltraWinListBar.Item();
			Infragistics.Win.UltraWinListBar.Item item2 = new Infragistics.Win.UltraWinListBar.Item();
			Infragistics.Win.UltraWinListBar.Item item3 = new Infragistics.Win.UltraWinListBar.Item();
			Infragistics.Win.UltraWinListBar.Item item4 = new Infragistics.Win.UltraWinListBar.Item();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemArhivoSalir = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItemEnviarRecibir = new System.Windows.Forms.MenuItem();
			this.menuItemEnviar = new System.Windows.Forms.MenuItem();
			this.menuItemRecibir = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItemProcesarSentenciasDeReplicacion = new System.Windows.Forms.MenuItem();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.statusBar = new System.Windows.Forms.StatusBar();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.axWebBrowser = new AxSHDocVw.AxWebBrowser();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panelGrid = new System.Windows.Forms.Panel();
			this.gridEX = new Janus.Windows.GridEX.GridEX();
			this.labelHeader = new System.Windows.Forms.Label();
			this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
			this.ultraListBar1 = new Infragistics.Win.UltraWinListBar.UltraListBar();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWebBrowser)).BeginInit();
			this.panelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem1,
																					 this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItemArhivoSalir});
			this.menuItem1.Text = "&Archivo";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "-";
			// 
			// menuItemArhivoSalir
			// 
			this.menuItemArhivoSalir.Index = 2;
			this.menuItemArhivoSalir.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuItemArhivoSalir.Text = "&Salir";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemEnviarRecibir,
																					  this.menuItemEnviar,
																					  this.menuItemRecibir,
																					  this.menuItem6,
																					  this.menuItemProcesarSentenciasDeReplicacion,
																					  this.menuItem7,
																					  this.menuItem5});
			this.menuItem4.Text = "H&erramientas";
			// 
			// menuItemEnviarRecibir
			// 
			this.menuItemEnviarRecibir.Index = 0;
			this.menuItemEnviarRecibir.Text = "Enviar y recibir todo";
			this.menuItemEnviarRecibir.Click += new System.EventHandler(this.menuItemEnviarRecibir_Click);
			// 
			// menuItemEnviar
			// 
			this.menuItemEnviar.Index = 1;
			this.menuItemEnviar.Text = "Enviar todo";
			this.menuItemEnviar.Click += new System.EventHandler(this.menuItemEnviar_Click);
			// 
			// menuItemRecibir
			// 
			this.menuItemRecibir.Index = 2;
			this.menuItemRecibir.Text = "Recibir todo";
			this.menuItemRecibir.Click += new System.EventHandler(this.menuItemRecibir_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 3;
			this.menuItem6.Text = "-";
			// 
			// menuItemProcesarSentenciasDeReplicacion
			// 
			this.menuItemProcesarSentenciasDeReplicacion.Index = 4;
			this.menuItemProcesarSentenciasDeReplicacion.Text = "Procesar sentencias de replicación";
			this.menuItemProcesarSentenciasDeReplicacion.Click += new System.EventHandler(this.menuItemProcesarSentenciasDeReplicacion_Click);
			// 
			// imageList
			// 
			this.imageList.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 385);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(3, 363);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(829, 22);
			this.statusBar.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel2);
			this.panel3.Controls.Add(this.toolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(829, 363);
			this.panel3.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.ultraListBar1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 42);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(829, 321);
			this.panel2.TabIndex = 11;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.axWebBrowser);
			this.panel4.Controls.Add(this.splitter2);
			this.panel4.Controls.Add(this.panelGrid);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(144, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(685, 321);
			this.panel4.TabIndex = 10;
			// 
			// axWebBrowser
			// 
			this.axWebBrowser.ContainingControl = this;
			this.axWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axWebBrowser.Enabled = true;
			this.axWebBrowser.Location = new System.Drawing.Point(0, 195);
			this.axWebBrowser.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWebBrowser.OcxState")));
			this.axWebBrowser.Size = new System.Drawing.Size(685, 126);
			this.axWebBrowser.TabIndex = 10;
			// 
			// splitter2
			// 
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter2.Location = new System.Drawing.Point(0, 192);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(685, 3);
			this.splitter2.TabIndex = 9;
			this.splitter2.TabStop = false;
			// 
			// panelGrid
			// 
			this.panelGrid.Controls.Add(this.gridEX);
			this.panelGrid.Controls.Add(this.labelHeader);
			this.panelGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelGrid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panelGrid.Location = new System.Drawing.Point(0, 0);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Size = new System.Drawing.Size(685, 192);
			this.panelGrid.TabIndex = 8;
			// 
			// gridEX
			// 
			this.gridEX.ColumnAutoResize = true;
			this.gridEX.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridEX.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridEX.GroupByBoxVisible = false;
			this.gridEX.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX.LayoutData = @"<GridEXLayoutData><RootTable><AllowAddNew>False</AllowAddNew><AllowDelete>False</AllowDelete><AllowEdit>False</AllowEdit><AllowGroup>False</AllowGroup><Columns Collection=""true""><Column0 ID=""Icon""><AllowSize>False</AllowSize><ColumnType>Image</ColumnType><Key>Icon</Key><Position>0</Position><Width>30</Width></Column0><Column1 ID=""IdBandeja""><Caption>IdBandeja</Caption><DataMember>IdBandeja</DataMember><Key>IdBandeja</Key><Position>1</Position><Visible>False</Visible></Column1><Column2 ID=""NombreArchivo""><Caption>Nombre</Caption><DataMember>NombreArchivo</DataMember><Key>NombreArchivo</Key><Position>2</Position><Width>351</Width></Column2><Column3 ID=""FechaTransferencia""><AllowSize>False</AllowSize><Caption>Transferencia</Caption><DataMember>FechaTransferencia</DataMember><EditType>CalendarDropDown</EditType><Key>FechaTransferencia</Key><Position>3</Position><Width>150</Width></Column3><Column4 ID=""FechaCreacion""><AllowSize>False</AllowSize><Caption>Creación</Caption><DataMember>FechaCreacion</DataMember><EditType>CalendarDropDown</EditType><Key>FechaCreacion</Key><Position>4</Position><Width>150</Width></Column4></Columns><GridLines>Horizontal</GridLines><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>3</ColIndex><SortOrder>Descending</SortOrder></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridEX.Location = new System.Drawing.Point(0, 23);
			this.gridEX.Name = "gridEX";
			this.gridEX.Size = new System.Drawing.Size(685, 169);
			this.gridEX.TabIndex = 4;
			this.gridEX.SelectionChanged += new System.EventHandler(this.gridEX_SelectionChanged);
			// 
			// labelHeader
			// 
			this.labelHeader.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelHeader.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelHeader.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.labelHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelHeader.ImageIndex = 1;
			this.labelHeader.ImageList = this.imageListSmall;
			this.labelHeader.Location = new System.Drawing.Point(0, 0);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelHeader.Size = new System.Drawing.Size(685, 23);
			this.labelHeader.TabIndex = 0;
			this.labelHeader.Text = "   [bandeja]";
			this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// imageListSmall
			// 
			this.imageListSmall.ImageSize = new System.Drawing.Size(16, 16);
			this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
			this.imageListSmall.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraListBar1
			// 
			this.ultraListBar1.BorderStyle = Infragistics.Win.UIElementBorderStyle.InsetSoft;
			this.ultraListBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.ultraListBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraListBar1.GroupHeadersVisible = false;
			item1.Key = "INBOX";
			item1.LargeImageIndex = 0;
			item1.SmallImageIndex = 0;
			item1.Text = "Bandeja de entrada";
			item2.Key = "OUTBOX";
			item2.LargeImageIndex = 1;
			item2.SmallImageIndex = 1;
			item2.Text = "Bandeja de salida";
			item3.Key = "SENT";
			item3.LargeImageIndex = 2;
			item3.SmallImageIndex = 2;
			item3.Text = "Elementos enviados";
			item4.Key = "TRASH";
			item4.LargeImageIndex = 3;
			item4.SmallImageIndex = 3;
			item4.Text = "Elementos eliminados";
			group1.Items.Add(item1);
			group1.Items.Add(item2);
			group1.Items.Add(item3);
			group1.Items.Add(item4);
			this.ultraListBar1.Groups.Add(group1);
			this.ultraListBar1.LargeImageList = this.imageList;
			this.ultraListBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraListBar1.Name = "ultraListBar1";
			this.ultraListBar1.Size = new System.Drawing.Size(144, 321);
			this.ultraListBar1.ItemSelected += new Infragistics.Win.UltraWinListBar.ItemEventHandler(this.ultraListBar1_ItemSelected);
			// 
			// toolBar1
			// 
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(829, 42);
			this.toolBar1.TabIndex = 10;
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 6;
			this.menuItem5.Text = "Procesar bandeja de entrada";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// FormMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(832, 385);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.splitter1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu;
			this.Name = "FormMain";
			this.Text = "Administrador de transferencias";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWebBrowser)).EndInit();
			this.panelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

		private void ultraListBar1_ItemSelected(object sender, Infragistics.Win.UltraWinListBar.ItemEventArgs e)
		{
			UpdateBin( e.Item.Key );
		}

		private void UpdateBin( string idBandeja )
		{
			Cursor = Cursors.WaitCursor;

			gridEX.DataSource = _bandeja.GetDetalleBandeja( idBandeja );

			Infragistics.Win.UltraWinListBar.Item item = ultraListBar1.Groups[ 0 ].Items[ idBandeja ];
			UpdateHeaderLabel( item.Text, item.LargeImageIndex );

			_idBandeja = idBandeja;

			Cursor = Cursors.Default;
		}

		private void UpdateBin()
		{
			UpdateBin( _idBandeja );
		}

		private void UpdateHeaderLabel( string text, int imageIndex)
		{
			labelHeader.Text = new string( ' ', 3 ) + text;
			labelHeader.ImageIndex = imageIndex;
		}

		private void menuItemRecibir_Click(object sender, System.EventArgs e)
		{
			_fileReplication.ReceiveFiles();
			UpdateBin();
		}

		private void menuItemEnviar_Click(object sender, System.EventArgs e)
		{
			_fileReplication.SendFiles();
			UpdateBin();
		}

		private void menuItemEnviarRecibir_Click(object sender, System.EventArgs e)
		{
			_fileReplication.SendFiles();
			_fileReplication.ReceiveFiles();
			UpdateBin();
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{
			UpdateBin( "INBOX" );
		}

		private void menuItemProcesarSentenciasDeReplicacion_Click(object sender, System.EventArgs e)
		{
			_jobBuilder.CreateJob( "CLIENT>SERVER" );
		}

		private void gridEX_SelectionChanged(object sender, System.EventArgs e)
		{
			if ( File.Exists( _tempFile ) )
			{
				try
				{
					File.Delete( _tempFile );
				}
				catch{}
			}

			if ( gridEX.SelectedItems.Count == 0 )
			{
				return;
			}

			GridEXSelectedItem i = gridEX.SelectedItems[ 0 ];
			if ( i != null )
			{
				GridEXRow row = i.GetRow();
			
				string idBandeja = ( string )row.Cells[ "IdBandeja" ].Value;
				string nombreArchivo = ( string )row.Cells[ "NombreArchivo" ].Value;
				byte[] bytes = _bandeja.GetContenidoArhivo( idBandeja, nombreArchivo );

				_tempFile = Path.ChangeExtension( Path.GetTempFileName(), ".xml" );
				try
				{
					File.Delete( Path.ChangeExtension( _tempFile, ".tmp" ) );
				}
				catch
				{
				}

				FileStream fs = new FileStream( _tempFile, FileMode.Create );
				ZipUtil.Decompress( bytes, fs );
				fs.Flush();
				fs.Close();

				object o = null;

				axWebBrowser.Navigate( _tempFile, ref o, ref o, ref o, ref o );
			}


			//Job j = Job.Read( bytes );


		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			_fileReplication.ProcessInboxFiles();
		}


	}
}

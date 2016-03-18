using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.io;
using mz.erp.ui.forms;
using mz.erp.ui.controls;
using System.IO;
using Excel;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de frmTest.
	/// </summary>
	public class frmTest : System.Windows.Forms.Form
	{
		private mz.erp.ui.controls.mzComboSearchEditor mzComboSearchEditor1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;		
		//private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.Button button1;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txtFileName;
		private Infragistics.Win.Misc.UltraButton btnFileChooser;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTest()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			Janus.Windows.GridEX.GridEXLayout gridEXLayout1 = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.GridEX.GridEXLayout gridEXLayout2 = new Janus.Windows.GridEX.GridEXLayout();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.btnFileChooser = new Infragistics.Win.Misc.UltraButton();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(888, 590);
			this.tabControl1.TabIndex = 99;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.linkLabel1);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Controls.Add(this.txtFileName);
			this.tabPage2.Controls.Add(this.btnFileChooser);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.gridEX1);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(880, 564);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Pruebas";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(24, 232);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(440, 24);
			this.linkLabel1.TabIndex = 11;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "www.google.com";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(504, 488);
			this.button4.Name = "button4";
			this.button4.TabIndex = 10;
			this.button4.Text = "button4";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(568, 240);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 192);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(632, 448);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(217, 20);
			this.txtFileName.TabIndex = 8;
			this.txtFileName.Text = "";
			// 
			// btnFileChooser
			// 
			this.btnFileChooser.Location = new System.Drawing.Point(600, 448);
			this.btnFileChooser.Name = "btnFileChooser";
			this.btnFileChooser.Size = new System.Drawing.Size(32, 23);
			this.btnFileChooser.TabIndex = 7;
			this.btnFileChooser.Text = "...";
			this.btnFileChooser.Click += new System.EventHandler(this.btnFileChooser_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(504, 448);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(88, 24);
			this.button3.TabIndex = 5;
			this.button3.Text = "Grabar";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 296);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "Ver";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// gridEX1
			// 
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			gridEXLayout2.IsCurrentLayout = true;
			gridEXLayout2.Key = "Layout1";
			gridEXLayout2.LayoutString = @"<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Column1""><Key>Column1</Key><Position>0</Position></Column0></Columns><GroupCondition ID="""" /></RootTable><FormatStyles Collection=""true""><Style0 ID=""FormatStyle1""><Key>FormatStyle1</Key></Style0><Style1 ID=""FormatStyle2""><Key>FormatStyle2</Key></Style1></FormatStyles><WatermarkImage /><Font>Microsoft Sans Serif, 8.25pt</Font></GridEXLayoutData>";
			gridEXLayout1.ChildLayouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
																							gridEXLayout2});
			gridEXLayout1.Key = "Layout1";
			gridEXLayout1.Tag = "12";
			this.gridEX1.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
																					  gridEXLayout1});
			this.gridEX1.Location = new System.Drawing.Point(120, 56);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.Size = new System.Drawing.Size(400, 144);
			this.gridEX1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(56, 448);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(184, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmTest
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(888, 590);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmTest";
			this.Text = "frmTest";
			this.Load += new System.EventHandler(this.frmTest_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTest_Load(object sender, System.EventArgs e)
		{
		}
		

		private void button1_Click(object sender, System.EventArgs e)
		{
			
			if (RawPrinterHelper.SendFileToPrinter("Generic / Text Only", @"C:\Temp\PruebaImpresion.txt"))
				Console.WriteLine("Ando");
			else	
				Console.WriteLine("NO Ando");
			
			/*
			Excel.ApplicationClass excel = new ApplicationClass();
			excel.Application.Workbooks.Add(true); 
			int ColumnIndex=0; 
			ColumnIndex++;
			excel.Cells[1,ColumnIndex]="col.ColumnName";
			int rowIndex=0; 
			rowIndex++;       
			excel.Cells[rowIndex+1,ColumnIndex]="row.Cells[col.ColumnName].Text";         
			excel.Visible = true; 
			Worksheet worksheet = (Worksheet)excel.ActiveSheet; 
			worksheet.Activate();
			//DataTable table = DATASETNAME.Tables[0];
			*/

				
			
		}

		private void button2_Click(object sender, System.EventArgs e)
		{

			

		}
		public static byte[] Image2Bytes(Image img)
		{
			string sTemp = Path.GetTempFileName();
			FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
			fs.Position = 0;
			//
			int imgLength = Convert.ToInt32(fs.Length);
			byte[] bytes = new byte[imgLength];
			fs.Read(bytes, 0, imgLength);
			fs.Close();
			return bytes;
		}

		public static Image Bytes2Image(byte[] bytes)
		{
			if (bytes == null) return null;
			//
			MemoryStream ms = new MemoryStream(bytes);
			Bitmap bm = null;
			try
			{
				bm = new Bitmap(ms);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
			}
			return bm;
		}

		private void btnFileChooser_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();			
			openFileDialog1.Filter = "Todos (*.*)|*.*" ;
			openFileDialog1.RestoreDirectory = true ;
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			string IdProducto = "00001000010000002973";
			tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row = businessrules.tsh_ProductosAuxiliares.GetByPk(IdProducto);
			row.Imagen = Image2Bytes(pictureBox1.Image);						
			tsh_ProductosAuxiliares.Update(row);
		
		
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			pictureBox1.Image = null;			
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{				
			System.Diagnostics.Process.Start(linkLabel1.Text); 
		}

		

		
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Export;
using DataDynamics.ActiveReports.Export.Html;
using DataDynamics.ActiveReports.Export.Pdf;
using DataDynamics.ActiveReports.Export.Rtf;
using DataDynamics.ActiveReports.Export.Text;
using DataDynamics.ActiveReports.Export.Tiff;
using DataDynamics.ActiveReports.Export.Xls;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Summary description for ExportForm.
	/// </summary>
	public class ExportForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblSubTitle;
		private System.Windows.Forms.Panel pnlFill;
		private System.Windows.Forms.ComboBox cboExportFormat;
		private System.Windows.Forms.Label lblExportFormat;
		private System.Windows.Forms.Label lblFilename;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.Button btnSaveFile;

		private DataDynamics.ActiveReports.Document.Document doc;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		object export=null;

		public ExportForm(DataDynamics.ActiveReports.Document.Document doc)
		{
			InitializeComponent();

			this.doc = doc;
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblSubTitle = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.pnlFill = new System.Windows.Forms.Panel();
			this.btnSaveFile = new System.Windows.Forms.Button();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.lblFilename = new System.Windows.Forms.Label();
			this.lblExportFormat = new System.Windows.Forms.Label();
			this.cboExportFormat = new System.Windows.Forms.ComboBox();
			this.pnlTop.SuspendLayout();
			this.pnlBottom.SuspendLayout();
			this.pnlFill.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.SystemColors.Window;
			this.pnlTop.Controls.Add(this.lblSubTitle);
			this.pnlTop.Controls.Add(this.lblTitle);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(458, 48);
			this.pnlTop.TabIndex = 0;
			// 
			// lblSubTitle
			// 
			this.lblSubTitle.Location = new System.Drawing.Point(16, 24);
			this.lblSubTitle.Name = "lblSubTitle";
			this.lblSubTitle.Size = new System.Drawing.Size(360, 16);
			this.lblSubTitle.TabIndex = 1;
			this.lblSubTitle.Text = "Seleccione el formato a exportar y setee las opciones";
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(240, 20);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Exportar Reportes";
			// 
			// pnlBottom
			// 
			this.pnlBottom.Controls.Add(this.btnCancel);
			this.pnlBottom.Controls.Add(this.btnOk);
			this.pnlBottom.Location = new System.Drawing.Point(0, 112);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(458, 40);
			this.pnlBottom.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(368, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 24);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "&Cancelar";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(272, 8);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(80, 24);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "&OK";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// pnlFill
			// 
			this.pnlFill.Controls.Add(this.btnSaveFile);
			this.pnlFill.Controls.Add(this.txtFilename);
			this.pnlFill.Controls.Add(this.lblFilename);
			this.pnlFill.Controls.Add(this.lblExportFormat);
			this.pnlFill.Controls.Add(this.cboExportFormat);
			this.pnlFill.Location = new System.Drawing.Point(0, 48);
			this.pnlFill.Name = "pnlFill";
			this.pnlFill.Size = new System.Drawing.Size(458, 64);
			this.pnlFill.TabIndex = 2;
			// 
			// btnSaveFile
			// 
			this.btnSaveFile.Location = new System.Drawing.Point(416, 32);
			this.btnSaveFile.Name = "btnSaveFile";
			this.btnSaveFile.Size = new System.Drawing.Size(32, 20);
			this.btnSaveFile.TabIndex = 4;
			this.btnSaveFile.Text = "...";
			this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
			// 
			// txtFilename
			// 
			this.txtFilename.Location = new System.Drawing.Point(136, 32);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(280, 20);
			this.txtFilename.TabIndex = 3;
			this.txtFilename.Text = "";
			// 
			// lblFilename
			// 
			this.lblFilename.Location = new System.Drawing.Point(8, 34);
			this.lblFilename.Name = "lblFilename";
			this.lblFilename.Size = new System.Drawing.Size(120, 16);
			this.lblFilename.TabIndex = 2;
			this.lblFilename.Text = "Nombre del Archivo:";
			// 
			// lblExportFormat
			// 
			this.lblExportFormat.Location = new System.Drawing.Point(8, 10);
			this.lblExportFormat.Name = "lblExportFormat";
			this.lblExportFormat.Size = new System.Drawing.Size(120, 16);
			this.lblExportFormat.TabIndex = 1;
			this.lblExportFormat.Text = "Formato a exportar:";
			// 
			// cboExportFormat
			// 
			this.cboExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboExportFormat.Items.AddRange(new object[] {
																 "HTML Format (HTM)",
																 "Portable Document Format (PDF)",
																 "Rich Text Format (RTF)",
																 "TIFF Format (TIF)",
																 "Text Format (TXT)",
																 "Microsoft Excel (XLS)"});
			this.cboExportFormat.Location = new System.Drawing.Point(136, 8);
			this.cboExportFormat.Name = "cboExportFormat";
			this.cboExportFormat.Size = new System.Drawing.Size(312, 21);
			this.cboExportFormat.TabIndex = 0;
			this.cboExportFormat.SelectedIndexChanged += new System.EventHandler(this.cboExportFormat_SelectedIndexChanged);
			// 
			// ExportForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(458, 159);
			this.Controls.Add(this.pnlFill);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExportForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exportar Reportes";
			this.Load += new System.EventHandler(this.ExportForm_Load);
			this.pnlTop.ResumeLayout(false);
			this.pnlBottom.ResumeLayout(false);
			this.pnlFill.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void cboExportFormat_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			txtFilename.Text = "";
			this.export = null;
			

			switch (cboExportFormat.SelectedIndex)
			{
				case 0: // html
					this.export = new HtmlExport();
					break;
				case 1: // pdf
					this.export = new PdfExport();
					
					break;
				case 2: // rtf
					this.export = new RtfExport();
					break;
				case 3: // tiff
					this.export = new TiffExport();
					
					break;
				case 4: // txt
					this.export = new TextExport();
					break;
				case 5: // xls
					this.export = new XlsExport();
				
					break;
				default:
					this.export = null;
					break;
			}
			
		}

		private void ExportForm_Load(object sender, System.EventArgs e)
		{
			cboExportFormat.SelectedIndex = 1; // pdf
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (txtFilename.Text.Length == 0)
				{
					return;
				}
				if (File.Exists(txtFilename.Text))
				{
					if (MessageBox.Show(this, "Desea sobreescribir el archivo existente?", "Sobreescribe Archivo", MessageBoxButtons.YesNo) == DialogResult.No)
					{
						return;
					}
				}

				switch(cboExportFormat.SelectedIndex)
				{
					case 0:
						((HtmlExport) export).Export(this.doc, this.txtFilename.Text);
						break;
					case 1:
						((PdfExport) export).Export(this.doc, this.txtFilename.Text);
						break;
					case 2:
						((RtfExport) export).Export(this.doc, this.txtFilename.Text);
						break;
					case 3:
						((TiffExport) export).Export(this.doc, this.txtFilename.Text);
						break;
					case 4:
						((TextExport) export).Export(this.doc, this.txtFilename.Text);
						break;
					case 5:
						((XlsExport) export).Export(this.doc, this.txtFilename.Text);
						break;
				}
				this.Close();
			}
			catch(Exception exp)
			{
				MessageBox.Show(this, exp.ToString());
			}
			return;

		}

		private void btnSaveFile_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Exportar Reportes";
			sfd.AddExtension = true;

			switch(cboExportFormat.SelectedIndex)
			{
				case 0:
					sfd.DefaultExt = "htm";
					sfd.Filter = "Archivos HTML (*.htm;*.html)|*.htm;*.htm";
					break;
				case 1:
					sfd.DefaultExt = "htm";
					sfd.Filter = "Archivos PDF (*.pdf)|*.pdf";
					break;
				case 2:
					sfd.DefaultExt = "rtf";
					sfd.Filter = "Archivos RTF (*.rtf)|*.rtf";
					break;
				case 3:
					sfd.DefaultExt = "tif";
					sfd.Filter = "Imagenes TIFF (*.tif)|*.tif";
					break;
				case 4:
					sfd.DefaultExt = "txt";
					sfd.Filter = "Archivos de Texo (*.txt)|*.txt";
					break;
				case 5:
					sfd.DefaultExt = "xls";
					sfd.Filter = "Archivos de Microsoft Excel (*.xls)|*.xls";
					break;
			}
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				txtFilename.Text = sfd.FileName;
			}
		}
	}
}

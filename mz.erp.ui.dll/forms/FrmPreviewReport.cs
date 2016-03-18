using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using DataDynamics.ActiveReports;
using System.Resources;
using mz.erp.businessrules;
using mz.erp.ui.forms.classes;
//using DataDynamics.ActiveReports.DataSources;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmPreviewReport.
	/// </summary>
	public class FrmPreviewReport : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private DataDynamics.ActiveReports.Viewer.Viewer _viewer;
		private System.ComponentModel.Container components = null;

		public FrmPreviewReport()
		{
			InitializeComponent();
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

		public void Test( Form parentForm )
		{
			this.openFileDialog.Filter = "ActiveReports Report File(*.rpx)|*.rpx";
			this.openFileDialog.ShowDialog();
			ShowReport( openFileDialog.FileName, parentForm );
		}


		public void ShowReport( string fileName, Form parentForm )
		{
			try
			{
				Cursor tmp = this.Cursor;
				ResourceManager res = new ResourceManager("mz.erp.ui.forms.localization", this.GetType().Assembly);	
				_viewer.Localize = res;
				
				//Cursor = Cursors.WaitCursor;
				MdiParent = parentForm;
				string path = this.getPath(fileName);
				if ( File.Exists( path ) )
				{

					StreamReader sr = new StreamReader( path );
					DataDynamics.ActiveReports.ActiveReport rpt = new DataDynamics.ActiveReports.ActiveReport();
					rpt.LoadLayout( sr.BaseStream );
					//DataDynamics.ActiveReports.DataSources.SqlDBDataSource sqlDS = (DataDynamics.ActiveReports.DataSources.SqlDBDataSource)rpt.DataSource;
					//sqlDS.ConnectionString = dbhelper.Connection.GetConnection().ConnectionString;
					//rpt.DataSource = sqlDS;
				
					//rpt.AddNamedItem("Empresa",Variables.GetValueString("Sistema.NombreEmpresa"));
					
					rpt.Run();

					_viewer.Document = rpt.Document;
					Show();
				}
				else
				{
					Errores.MessageFileNotFound();					
				}
			}
			catch( Exception  e){;}
		}

		public void ShowReport(System.Data.DataTable table,string fileName, Form parentForm ,object[] parameters)
		{
			
			ResourceManager res = new ResourceManager("mz.erp.ui.forms.localization", this.GetType().Assembly);	
			_viewer.Localize = res;
			try
			{
				

				string path = this.getPath(fileName);
				MdiParent = parentForm;
				if ( File.Exists( path ) )
				{

					StreamReader sr = new StreamReader( path );
					DataDynamics.ActiveReports.ActiveReport rpt = new DataDynamics.ActiveReports.ActiveReport();

							
					rpt.LoadLayout( sr.BaseStream );
					
					DataDynamics.ActiveReports.DataSources.SqlDBDataSource sqlDS = (DataDynamics.ActiveReports.DataSources.SqlDBDataSource)rpt.DataSource;
					rpt.DataSource = table.DefaultView;
					
					
					Console.WriteLine("Vivi");
					rpt.AddNamedItem("Empresa",Variables.GetValueString("Sistema.NombreEmpresa"));
					FormatParameters(rpt,parameters);

							
					rpt.Run();
					
				

					_viewer.Document = rpt.Document;
					Show();										
				}
			
				else
				{
					Errores.MessageFileNotFound();					
				}
			}
			catch(Exception e )
			{
				
				Console.WriteLine(e.Message);
			}
		}



		public void ShowReport(System.Data.DataTable table,string fileName, Form parentForm ,ReportParameterCollection parameters)
		{
			
			ResourceManager res = new ResourceManager("mz.erp.ui.forms.localization", this.GetType().Assembly);	
			_viewer.Localize = res;
			try
			{
				

				string path = this.getPath(fileName);
				MdiParent = parentForm;
				if ( File.Exists( path ) )
				{

					StreamReader sr = new StreamReader( path );
					DataDynamics.ActiveReports.ActiveReport rpt = new DataDynamics.ActiveReports.ActiveReport();

       
				
					rpt.LoadLayout( sr.BaseStream );
					
					DataDynamics.ActiveReports.DataSources.SqlDBDataSource sqlDS = (DataDynamics.ActiveReports.DataSources.SqlDBDataSource)rpt.DataSource;
					rpt.DataSource = table;
					rpt.AddNamedItem("Empresa",Variables.GetValueString("Sistema.NombreEmpresa"));
					FormatParameters(rpt,parameters);
				
					rpt.Run();					

					_viewer.Document = rpt.Document;
					Show();					
					
				}			
				else
				{
					Errores.MessageFileNotFound();					
				}
			}
			catch(Exception e )
			{				
				Console.WriteLine(e.Message);

			}
		}




		public void ShowReport(System.Data.DataTable table,string fileName, Form parentForm ,ArrayList parameters)
		{
			
			ReportParameterCollection rpc = new ReportParameterCollection();
			foreach(ReportParameter rp in parameters)
			{
				rpc.Add(rp);
			}
			ShowReport(table,fileName,parentForm,rpc);
			
		}


		private string getPath(string fileName)
		{
			string path = string.Format(mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Reports\\" + fileName );
			return path;
		}
		
		private void FormatParameters(DataDynamics.ActiveReports.ActiveReport rpt,ReportParameterCollection parameters)
		{
			
					
			foreach (ReportParameter param in parameters)
			{
				rpt.AddNamedItem(param.ParameterName,param.ParameterValue);
				

			}
		}



		private void FormatParameters(DataDynamics.ActiveReports.ActiveReport rpt,object [] parameters)
		{
			
			string p = "Param";
			
			int i = 1;
			foreach (object param in parameters)
			{
				rpt.AddNamedItem(p+i,param);
				i++;

			}
			

		}
		
		
				
		


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._viewer = new DataDynamics.ActiveReports.Viewer.Viewer();
			this.SuspendLayout();
			// 
			// _viewer
			// 
			this._viewer.BackColor = System.Drawing.SystemColors.Control;
			this._viewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this._viewer.Location = new System.Drawing.Point(0, 0);
			this._viewer.Name = "_viewer";
			this._viewer.ReportViewer.CurrentPage = 0;
			this._viewer.ReportViewer.MultiplePageCols = 3;
			this._viewer.ReportViewer.MultiplePageRows = 2;
			this._viewer.Size = new System.Drawing.Size(712, 421);
			this._viewer.TabIndex = 0;
			this._viewer.TableOfContents.Text = "Contents";
			this._viewer.TableOfContents.Width = 200;
			this._viewer.Toolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this._viewer.ToolClick += new DataDynamics.ActiveReports.Toolbar.ToolClickEventHandler(this._viewer_ToolClick);
			// 
			// FrmPreviewReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(712, 421);
			this.Controls.Add(this._viewer);
			this.Name = "FrmPreviewReport";
			this.Text = "Visor de Reportes";
			this.Load += new System.EventHandler(this.FrmPreviewReport_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmPreviewReport_Load(object sender, System.EventArgs e)
		{
			
			Icon ico = new Icon(string.Format( Application.StartupPath + "\\resources\\Icons\\" +"Export16x16.ico" ));;
			_viewer.Toolbar.Images.Images.Add(ico);
			DataDynamics.ActiveReports.Toolbar.Button btn = new DataDynamics.ActiveReports.Toolbar.Button();
			btn.ImageIndex = 12;
			btn.Id = 5001;
			btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.TextAndIcon;
			
			btn.Caption = "Exportar";
			btn.ToolTip = "Exportar Reportes";
			_viewer.Toolbar.Tools.Insert(2, (DataDynamics.ActiveReports.Toolbar.Tool) btn);	
		}

		private void _viewer_ToolClick(object sender, DataDynamics.ActiveReports.Toolbar.ToolClickEventArgs e)
		{
			try
			{
				switch(e.Tool.Id)
				{
					case 5001:

						this.ExportDocument();
						break;
				}
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.ToString());
			}
		}
	private void ExportDocument()
		{
			ExportForm f = new ExportForm(_viewer.Document);
			f.ShowDialog(this);
			
		}



	
	}
}

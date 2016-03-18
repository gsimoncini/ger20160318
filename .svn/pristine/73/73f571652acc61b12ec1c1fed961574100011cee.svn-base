using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using DataDynamics.ActiveReports;
using System.Resources;
using mz.erp.businessrules;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using System.Drawing.Printing;


//using DataDynamics.ActiveReports.DataSources;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmPreviewReport.
	/// </summary>
	public class FrmReportsViewer : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imglStandar;
		private DataDynamics.ActiveReports.Viewer.Viewer _viewer;
		private System.Windows.Forms.Panel panel2;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		protected System.Windows.Forms.ToolBarButton toolBarButton10;
		private ReportsController _uiController;

		public FrmReportsViewer(mz.erp.ui.controllers.ReportsController uiController, string _ProcesoLlamador, string _Tarea)
		{
			InitializeComponent();
			_uiController = uiController;
			KeyPreview = true;
			InitEvents();
			InitInterface(_ProcesoLlamador, _Tarea);
		}

		private void InitEvents()
		{
			toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			this._viewer.ToolClick += new DataDynamics.ActiveReports.Toolbar.ToolClickEventHandler(this._viewer_ToolClick);			
			KeyDownManager KeyDownMan = new KeyDownManager(this);
		}
		
		private void InitInterface(string procesoLlamador, string tarea)
		{
			bool _visibleImprimir = Variables.GetValueBool(procesoLlamador, tarea, "BotonImprimir.Visible", true);
			_viewer.Toolbar.Tools.ToolById(2).Visible = _visibleImprimir;
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
			catch( Exception  e){Console.WriteLine(e.Message);}
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



		public void ShowReport(System.Data.DataTable table,string fileName, Form parentForm ,ReportParameterCollection parameters, bool show, bool print, bool printSetup, bool printProgress, bool askPrint, bool customPrinter, string PrinterName, short copies)
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
					if(show)
						Show();	
					else
					{
						if(print)
						{
							if(askPrint)
							{
								if(MessageBox.Show("Desea Imprimir?","Impresión", System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Question).Equals(DialogResult.Yes))
								{
									if(customPrinter)
										rpt.Document.Printer.PrinterSettings.PrinterName =  PrinterName ;//@"\\PCADRIANA\HP LaserJet 1020";
									else
										if(_uiController.AllowImpresoraPorTipoDeComprobante)
											rpt.Document.Printer.PrinterSettings.PrinterName =  _uiController.ImpresoraPorTipoDeComprobante;
									rpt.Document.Printer.PrinterSettings.Copies = copies;

                                    //German 20100713 - Tarea 793
                                    if (_uiController.BandejaPersonalizada)
                                    {
                                        if (_uiController.Bandeja != null && _uiController.Bandeja != string.Empty)
                                            //rpt.Document.Printer.PrinterSettings.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.Bandeja, rpt.Document);
                                            rpt.Document.Printer.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.Bandeja, rpt.Document);
                                    }
                                    else
                                    {
                                        if (_uiController.AllowBandejaPorTipoDeComprobante)
                                            if (_uiController.BandejaPorTipoDeComprobante != null && _uiController.BandejaPorTipoDeComprobante != string.Empty)
                                                //rpt.Document.Printer.PrinterSettings.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.BandejaPorTipoDeComprobante, rpt.Document);
                                                rpt.Document.Printer.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.BandejaPorTipoDeComprobante, rpt.Document);
                                    }
                                    //Fin German 20100713 - Tarea 793


                                    //Deprecated
                                    //rpt.Document.Print(printSetup, printProgress);
									rpt.Document.Print(printSetup,printProgress,false);
								}
							}
							else
							{
								if(customPrinter)
									rpt.Document.Printer.PrinterSettings.PrinterName =  PrinterName ;//@"\\PCADRIANA\HP LaserJet 1020";
								else
									if(_uiController.AllowImpresoraPorTipoDeComprobante)
									rpt.Document.Printer.PrinterSettings.PrinterName =  _uiController.ImpresoraPorTipoDeComprobante;
								rpt.Document.Printer.PrinterSettings.Copies = copies;

                                //German 20100713 - Tarea 793
                                if (_uiController.BandejaPersonalizada)
                                {
                                    if (_uiController.Bandeja != null && _uiController.Bandeja != string.Empty)
                                        //rpt.Document.Printer.PrinterSettings.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.Bandeja, rpt.Document);
                                        rpt.Document.Printer.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.Bandeja, rpt.Document);
                                }
                                else
                                {
                                    if (_uiController.AllowBandejaPorTipoDeComprobante)
                                        if (_uiController.BandejaPorTipoDeComprobante != null && _uiController.BandejaPorTipoDeComprobante != string.Empty)
                                            //rpt.Document.Printer.PrinterSettings.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.BandejaPorTipoDeComprobante, rpt.Document);
                                            rpt.Document.Printer.DefaultPageSettings.PaperSource = GetPrinterTray(_uiController.BandejaPorTipoDeComprobante, rpt.Document);
                                }
                                //Fin German 20100713 - Tarea 793
                               

                                //Deprecated
                                //rpt.Document.Print(printSetup, printProgress);
								rpt.Document.Print(printSetup,printProgress,false);
							}
						}
					}				
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
			ShowReport(table,fileName,parentForm,rpc, true, _uiController.Print, _uiController.PrintSetup, _uiController.PrintProgress, _uiController.AskPrint, _uiController.CustomPrinter, _uiController.PrinterName, Convert.ToInt16( _uiController.Copies));
			
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmReportsViewer));
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this._viewer = new DataDynamics.ActiveReports.Viewer.Viewer();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._viewer);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(896, 486);
			this.panel1.TabIndex = 1;
			// 
			// _viewer
			// 
			this._viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._viewer.BackColor = System.Drawing.SystemColors.Control;
			this._viewer.Location = new System.Drawing.Point(0, 32);
			this._viewer.Name = "_viewer";
			this._viewer.ReportViewer.CurrentPage = 0;
			this._viewer.ReportViewer.MultiplePageCols = 3;
			this._viewer.ReportViewer.MultiplePageRows = 2;
			this._viewer.Size = new System.Drawing.Size(896, 456);
			this._viewer.TabIndex = 1;
			this._viewer.TableOfContents.Text = "Contents";
			this._viewer.TableOfContents.Width = 200;
			this._viewer.Toolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.toolBarStandar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(896, 32);
			this.panel2.TabIndex = 23;
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
																							  this.toolBarButton10});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(896, 28);
			this.toolBarStandar.TabIndex = 23;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
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
			// FrmReportsViewer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(896, 486);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "FrmReportsViewer";
			this.Text = "Visor de Reportes";
			this.Load += new System.EventHandler(this.FrmPreviewReport_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
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

			btn.Visible = _viewer.Toolbar.Tools.ToolById(2).Visible; //si esta visible el boton imprimir este tb, sino no
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
					case 2: //boton imprimir
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

		protected virtual void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					_uiController.Execute();
					break;
			}		
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
	
			
			if(_uiController.AllowShow())
			{
				tbbAnterior.Enabled = !_uiController.IsFlushedState();
				ChangeTextoBotonSiguiente();
				ShowReport(_uiController.DataSource,_uiController.FileName,mz.erp.ui.utility.Environment.MainForm, _uiController.Parametros, true, _uiController.Print, _uiController.PrintSetup, _uiController.PrintProgress, _uiController.AskPrint, _uiController.CustomPrinter, _uiController.PrinterName, Convert.ToInt16( _uiController.Copies));
				//_uiController.Execute();
			}
			else
			{
				ShowReport(_uiController.DataSource,_uiController.FileName,mz.erp.ui.utility.Environment.MainForm, _uiController.Parametros, false, _uiController.Print, _uiController.PrintSetup, _uiController.PrintProgress, _uiController.AskPrint, _uiController.CustomPrinter, _uiController.PrinterName, Convert.ToInt16( _uiController.Copies));
				_uiController.Execute();
			}
		}
		public void CloseForm()
		{
			Close();		
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

		private void ChangeTextoBotonSiguiente() 
		{
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
		}

        //German 20100713 - Tarea 793
        private PaperSource GetPrinterTray(string TrayName, DataDynamics.ActiveReports.Document.Document document)
        {
            foreach (PaperSource ps in document.Printer.PrinterSettings.PaperSources)
            {
                if (ps.SourceName.ToUpper().Equals(TrayName.ToUpper()))
                    return ps;
            }
            return null;
        }
        //Fin German 20100713 - Tarea 793

	}
}

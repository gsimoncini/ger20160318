using System;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace mz.erp.ui.forms
{
	public class ActiveReport1 : ActiveReport
	{
		public ActiveReport1()
		{
			InitializeReport();
		}
		
		bool m_color = true;

		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
	

				
				if(m_color)
				{
					m_color =false;
					this.Sections["Detail"].BackColor = System.Drawing.Color.DarkSeaGreen;
					this.TextBox4.OutputFormat = "dd/mm/yyyy";
					this.TextBox4.Value = this.TextBox4.Value;
				}	
				else	
				{
					this.Sections["Detail"].BackColor = System.Drawing.Color.Transparent;
					m_color = true;	
					this.TextBox4.OutputFormat = "dd-mmmm-yy";
					this.TextBox4.Value = this.TextBox4.Value;
				}
			
		}
		private void Hola(object hi, bool ok)
		{
			//Debug.WriteLine("Hola");
		}
		

		private void ActiveReport1_ReportStart(object sender, System.EventArgs eArgs)
		{
			this.ParameterUIClosed +=new ParameterUIClosedHandler(Hola);
			
		}

		#region ActiveReports Designer generated code
		public DataDynamics.ActiveReports.DataSources.OleDBDataSource ds = null;
		private PageHeader PageHeader = null;
		private Detail Detail = null;
		private TextBox TextBox1 = null;
		private TextBox TextBox2 = null;
		private TextBox TextBox3 = null;
		private TextBox TextBox4 = null;
		private PageFooter PageFooter = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "mz.erp.ui.forms.ActiveReport1.rpx");
			this.ds = ((DataDynamics.ActiveReports.DataSources.OleDBDataSource)(this.DataSource));
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[0]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[1]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[2]));
			this.TextBox4 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[3]));
			// Attach Report Events
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.ReportStart += new System.EventHandler(this.ActiveReport1_ReportStart);
		}

		#endregion
	}
}

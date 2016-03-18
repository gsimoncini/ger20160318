using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules.reportes;
using mz.erp.systemframework;
using System.Reflection;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmParameterReports.
	/// </summary>
	public class FrmParameterReports : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.ComponentModel.IContainer components;
		private string _reportName;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private ReportConfig _rc ;

		public FrmParameterReports(string ReportName)
		{
			_reportName = ReportName;
			InitializeComponent();
			ReadConfig();
			LoadParameters();
		}


		public void ShowDialogCustom()
		{
			if(ultraExplorerBarContainerControl5.Controls.Count == 0)
			{
				MostrarReporte();	
			}
			else
			{
				this.ShowDialog();
			}
		}


		public FrmParameterReports(string ReportName, ReportConfig rc)
		{
			
			_reportName = ReportName;
			InitializeComponent();
			_rc = rc;
			LoadParameters();

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmParameterReports));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(599, 8);
			this.ultraExplorerBarContainerControl5.TabIndex = 6;
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
																							  this.toolBarButton9});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(648, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 6;
			this.toolBarButton9.Text = "Ver Reporte";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 8;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Parametros Reporte";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(648, 89);
			this.ultraExplorerBar1.TabIndex = 20;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmParameterReports
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 117);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmParameterReports";
			this.Text = "Parametros";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ReadConfig()
		{
			_rc = ReportConfig.Read(mz.erp.systemframework.Util.ResourcePath() + "\\resources\\Reports\\" + _reportName +".config"); 
		}
		
		private ArrayList _controlsBindings = new ArrayList();

		private void LoadParameters()
		{
			
			int heightControls = 5;
			int tabIndex = 0;
			
			foreach(ReportParameterConfig rpc in _rc.ParametersSQL)
			{
				ReportParameterControlType rpct= rpc.ControlUIType;
				if (rpct != null)
				{
					
					AddLabel( rpct.LabelText, rpct.LabelText, tabIndex++, 5, heightControls );
					if(rpct.ControlType == "System.String")
						AddTextBox(rpc,tabIndex++, 160, heightControls);
					else
						if(rpct.ControlType == "System.Int64")
						AddNumericBox(rpc, tabIndex++,160, heightControls);
					else
						if(rpct.ControlType == "System.Bool")
						AddCheckBox(rpc, tabIndex++,160, heightControls);
					else
						if(rpct.ControlType == "System.Decimal")
						AddNumericBox( rpc, tabIndex++,160, heightControls);
					else
						if(rpct.ControlType =="System.DateTime")
						AddDateTimeBox(rpc, tabIndex++,160, heightControls);
					else 
						if(rpct.ControlType == "mzComboEditor")
						AddComboEditor( rpc, tabIndex++, 160, heightControls );
					else
						if(rpct.ControlType == "mzComboSearchEditor")
						AddComboSearchEditor(rpc, tabIndex++, 160, heightControls);
					heightControls += 24;
				}




			}

			//Calculo para acomodar la ventana
			int x = this.ultraExplorerBarContainerControl5.Location.X;
			int y = this.ultraExplorerBarContainerControl5.Location.Y;
			int width = this.ultraExplorerBarContainerControl5.Size.Width;
			int heigth = this.ultraExplorerBarContainerControl5.Height;
			this.ultraExplorerBarContainerControl5.SetBounds(x,y,width,heigth  + heightControls );
			x = this.Location.X;
			y = this.Location.Y;
			width = this.Size.Width;
			heigth = this.Height;
			this.SetBounds(x,y,width, heigth + this.ultraExplorerBarContainerControl5.Size.Height);

		}

		private mz.erp.ui.controls.mzComboEditor AddComboEditor(ReportParameterConfig rp, int tabIndex, int x, int y )
		{
			mz.erp.ui.controls.mzComboEditor txt = new mz.erp.ui.controls.mzComboEditor();
			Type _type = System.Type.GetType(rp.ControlUIType.UIType);
			MethodBase method = null;
			foreach( MethodBase mb in _type.GetMethods() )
			{
				foreach( Attribute attMethod in mb.GetCustomAttributes( false ) )
				{
					if ( attMethod  is ValueListGridMember)
									
						method = mb;
				}
			}
			object instance = Activator.CreateInstance(_type, true );
			System.Data.DataTable resultValue =(System.Data.DataTable) method.Invoke( instance, new object []{} );
			
			txt.Location = new System.Drawing.Point( x, y );
			txt.Name = string.Format( "txt{0}", rp.Nombre);
			txt.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			txt.TabIndex = tabIndex;
			txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			this.ultraExplorerBarContainerControl5.Controls.Add( txt );
			txt.DataBindings.Add("Value", rp, "ValorPorDefecto");
			txt.FillFromDataSource(resultValue,rp.ControlUIType.PrimaryKey,rp.ControlUIType.Description,8,rp.ControlUIType.Description);
			
			return txt;
		}


		private Infragistics.Win.UltraWinEditors.UltraTextEditor AddTextBox(ReportParameterConfig rp, int tabIndex, int x, int y )
		{
			Infragistics.Win.UltraWinEditors.UltraTextEditor txt = new Infragistics.Win.UltraWinEditors.UltraTextEditor();

			txt.Location = new System.Drawing.Point( x, y );
			txt.Name = string.Format( "txt{0}", rp.ControlUIType.LabelText);
			txt.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			txt.TabIndex = tabIndex;
			txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			this.ultraExplorerBarContainerControl5.Controls.Add( txt );
			txt.DataBindings.Add("Text", rp, "ValorPorDefecto");
			


			return txt;
		}

		private int GetControlWidth()
		{
			return  this.ultraExplorerBarContainerControl5.Size.Width - ( 175 );
			//return  panelTop.Width - ( 185 );
		}
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor AddNumericBox( ReportParameterConfig rp, int tabIndex, int x, int y )
		{
			Infragistics.Win.UltraWinEditors.UltraNumericEditor une = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();

			une.Location = new System.Drawing.Point( x, y );
			une.Name = string.Format( "txt{0}", rp.Nombre );
			une.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			une.TabIndex = tabIndex;
			une.Value = null;
			
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			this.ultraExplorerBarContainerControl5.Controls.Add( une );
			une.DataBindings.Add("Value", rp,"ValorPorDefecto");
			une.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Integer;
			une.MinValue = 0;
			une.Click += new EventHandler(une_Click);

			return une;
		}

		
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor AddCheckBox( ReportParameterConfig rp, int tabIndex, int x, int y )
		{
			Infragistics.Win.UltraWinEditors.UltraCheckEditor une = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();

			une.Location = new System.Drawing.Point( x, y );
			une.Name = string.Format( "txt{0}", rp.Nombre );
			une.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			une.TabIndex = tabIndex;			
			une.Checked = false;	
						
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			this.ultraExplorerBarContainerControl5.Controls.Add( une );						
			une.DataBindings.Add("Checked", rp, "ValorPorDefecto");
			return une;
		}


		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor AddDateTimeBox(  ReportParameterConfig rp, int tabIndex, int x, int y )
		{
			Infragistics.Win.UltraWinEditors.UltraDateTimeEditor une = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();

			une.Location = new System.Drawing.Point( x, y );
			une.Name = string.Format( "txt{0}", rp.Nombre );
			une.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			une.TabIndex = tabIndex;
			une.Value ="";
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			this.ultraExplorerBarContainerControl5.Controls.Add( une );
			if(rp.ValorPorDefecto == null || rp.ValorPorDefecto.Equals(string.Empty))
			rp.ValorPorDefecto = Convert.ToString(DateTime.Now);
			une.DataBindings.Add("Text", rp,"ValorPorDefecto");
			//BindingController.Bind(une,"Text",rp,"ValorPorDefecto");
			return une;
		}
		private Infragistics.Win.Misc.UltraLabel AddLabel( string name, string caption, int tabIndex, int x, int y )
		{
			Infragistics.Win.Misc.UltraLabel lbl = new Infragistics.Win.Misc.UltraLabel();
			Infragistics.Win.Appearance appearance = new Infragistics.Win.Appearance();

			appearance.TextVAlign = Infragistics.Win.VAlign.Middle;
			lbl.Appearance = appearance;
			lbl.BackColor = System.Drawing.Color.Transparent; //SystemColors.Control;
			lbl.Location = new System.Drawing.Point( x, y );
			lbl.Name = string.Format( "lbl{0}", name );
			lbl.Text = caption;

			lbl.Size = new System.Drawing.Size( 150, 23 );
			lbl.TabIndex = tabIndex;

			this.ultraExplorerBarContainerControl5.Controls.Add( lbl );

			return lbl;

		}

		private mz.erp.ui.controls.mzComboSearchEditor AddComboSearchEditor( ReportParameterConfig rp, int tabIndex, int x, int y )
		{
			mz.erp.ui.controls.mzComboSearchEditor edt = new mz.erp.ui.controls.mzComboSearchEditor();

			edt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			edt.Location = new System.Drawing.Point( x, y );
			edt.Name = string.Format( "edt{0}", rp.Nombre );
			edt.SearchObject = System.Type.GetType(rp.ControlUIType.SearchObject);
			edt.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			edt.TabIndex = tabIndex;
			edt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			
			this.ultraExplorerBarContainerControl5.Controls.Add( edt );
			edt.DataBindings.Add("DataValue",rp,"ValorPorDefecto");
			return edt;
		}

		private void btnVerReporte_Click(object sender, System.EventArgs e)
		{
			System.Data.DataTable table = _rc.GetDataTable();
			FrmPreviewReport fpr = new FrmPreviewReport();
			//Acordarse de recuperar parametros generales de cada reporte
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			fpr.ShowReport(table, _reportName,mz.erp.ui.utility.Environment.MainForm,new object[] {});
			this.Close();
		}

		private void panelTop_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
				{	
					MostrarReporte();
					this.Close();
					break;
				}


			}
		}

		private void MostrarReporte()
		{
			mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl5);
			System.Data.DataTable table = _rc.GetDataTable();
			FrmPreviewReport fpr = new FrmPreviewReport();
			//Acordarse de recuperar parametros generales de cada reporte
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			fpr.ShowReport(table, _reportName,mz.erp.ui.utility.Environment.MainForm,new ArrayList(_rc.ParametersReport));
			
		}

		private void une_Click(object sender, EventArgs e)
		{
			Infragistics.Win.UltraWinEditors.UltraNumericEditor une = (Infragistics.Win.UltraWinEditors.UltraNumericEditor)sender;
			une.SelectAll();
		}
	}
}

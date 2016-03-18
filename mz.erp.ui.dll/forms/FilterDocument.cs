using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FilterDocument.
	/// </summary>
	public class FilterDocument : System.Windows.Forms.Form
	{
		private mz.erp.ui.controls.mzSearchPanel mzSearchPanel;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private bool _save = false;

		public FilterDocument()
		{
			InitializeComponent();
			InitEvents();
			
		}

		private void InitEvents()
		{

			this.KeyPreview = true;
			this.KeyDown +=new KeyEventHandler(FilterDocument_KeyDown);
			this.Closing += new CancelEventHandler(FilterDocument_Closing);
		}

		
		public FilterDocument( Type searchType, string caption )
		{
			InitializeComponent();
			mzSearchPanel.SearchObject = searchType;
			mzSearchPanel.Caption = caption;
			InitEvents();
		}

		public FilterDocument( Type searchType, Type editType, string caption )
		{
			InitializeComponent();
			mzSearchPanel.SearchObject = searchType;
			mzSearchPanel.EditObject = editType;			
			mzSearchPanel.Caption = caption;
			InitEvents();
		}

		public FilterDocument( Type searchType, Type editType, Type detailType, string caption )
		{
			InitializeComponent();
			mzSearchPanel.SearchObject = searchType;
			mzSearchPanel.EditObject = editType;
			mzSearchPanel.DetailObject = detailType;
			mzSearchPanel.Caption = caption;
			InitEvents();
		}

		public FilterDocument( Type searchType, Type editType, string caption, string layoutData )
		{
			InitializeComponent();
			mzSearchPanel.SearchObject = searchType;
			mzSearchPanel.EditObject = editType;
			mzSearchPanel.Caption = caption;
			mzSearchPanel.LayoutData = layoutData;
			InitEvents();
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
						this.mzSearchPanel = new mz.erp.ui.controls.mzSearchPanel();
						this.timer1 = new System.Windows.Forms.Timer(this.components);
						this.SuspendLayout();
						// 
						// mzSearchPanel
						// 
						this.mzSearchPanel.Caption = null;
						this.mzSearchPanel.DetailObject = null;
						this.mzSearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
						this.mzSearchPanel.EditObject = null;
						this.mzSearchPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
						this.mzSearchPanel.LayoutData = null;
						this.mzSearchPanel.Location = new System.Drawing.Point(0, 0);
						this.mzSearchPanel.Name = "mzSearchPanel";
						this.mzSearchPanel.SearchObject = null;
						this.mzSearchPanel.Size = new System.Drawing.Size(696, 453);
						this.mzSearchPanel.TabIndex = 0;
						this.mzSearchPanel.Load += new System.EventHandler(this.mzSearchPanel_Load);
						// 
						// timer1
						// 
						this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
						// 
						// FilterDocument
						// 
						this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
						this.ClientSize = new System.Drawing.Size(696, 453);
						this.Controls.Add(this.mzSearchPanel);
						this.Name = "FilterDocument";
						this.Text = "FilterDocument";
						this.ResumeLayout(false);

					}
		#endregion

		private void mzSearchPanel_Load(object sender, System.EventArgs e)
		{
		
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
		
		}


		#region KeyDown Events
		
		private void FilterDocument_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.F2)
			{
				//Debug.WriteLine(e.Handled);
				
				this.Cursor = Cursors.WaitCursor;
				this.mzSearchPanel.SearchNow();
				this.Cursor = Cursors.Arrow;
			}
			else 
				if(e.KeyCode == System.Windows.Forms.Keys.PageDown)
			{
				this.mzSearchPanel.SelectGrid();
			}
			
			else 
				
				if(e.KeyCode == System.Windows.Forms.Keys.N)
			{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
					this.mzSearchPanel.NewMember();
			}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.M)
			{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
					this.mzSearchPanel.EditMember();
			}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.D)
			{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
					this.mzSearchPanel.EditMember();
			}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.F5)
			{
				this.mzSearchPanel.RefreshSearch();
			}
		}

		#endregion

		private void FilterDocument_Closing(object sender, CancelEventArgs e)
		{
			if(MessageBox.Show("¿Esta seguro que desea cerrar el formulario " + this.Text + "?","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Warning) == DialogResult.Cancel)
				e.Cancel = true;
		}
	}
}

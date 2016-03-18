using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controls;
using mz.erp.commontypes;


using System.Data;

namespace mz.erp.ui.forms
{
	public class mzSearchForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button buttonOK;
		private mz.erp.ui.controls.mzSearchPanel mzSearchPanel;
		private System.ComponentModel.Container components = null;


		private ISearchObjectListener _searchObjectListener;
		public ISearchObjectListener SearchObjectListener
		{
			get{return _searchObjectListener;}
			set
			{
				_searchObjectListener = value;
				mzSearchPanel.SearchObjectListener = _searchObjectListener;
			}
		}

		private bool _allowMultipleSelect = false;
		internal System.Windows.Forms.Button buttonCancel;
	
		public bool AllowMultipleSelect
		{
			set
			{
				if(mzSearchPanel != null)
					mzSearchPanel.AllowMultipleSelect = value;

			}
		}
		private string _layoutData = string.Empty;
		public string LayoutData
		{
			set{_layoutData = value;}
		}


		public mzSearchForm()
		{
			InitializeComponent();
		}

		public mzSearchForm( Type searchObject )
		{
			InitializeComponent();
			mzSearchPanel.SearchObject = searchObject;	
			mzSearchPanel.LayoutData = _layoutData;			
				
			//this.RowDoubleClick += (new System.EventHandler(RowDoubleClick(this, new System.EventArgs ) ));			
		}

		public mzSearchForm( Type searchObject , Type editObject, bool fastSearch, string orderBy)
		{
			InitializeComponent();
			//Esto debe asignarse antes que nada, pues sino este flag no sera tenido en cuenta
			mzSearchPanel.FastSearch = fastSearch;
			mzSearchPanel.OrderBy = orderBy;
			mzSearchPanel.SearchObject = searchObject;	
			this.Text = "Buscar " + mzSearchPanel.GetCaption;
			mzSearchPanel.EditObject = editObject;
			mzSearchPanel.NewClick += new EventHandler(CloseUI);
			mzSearchPanel.EditClick += new EventHandler(CloseUI);			
			mzSearchPanel.LayoutData = _layoutData;
			
			//mzSearchPanel.RefreshDataEvent += new EventHandler(ShowUI);
				
			//this.RowDoubleClick += (new System.EventHandler(RowDoubleClick(this, new System.EventArgs ) ));			
		}

		public mzSearchForm( Type searchObject , Type editObject, bool fastSearch, string orderBy, int Width, string LayoutData)
		{
			InitializeComponent();
			//Esto debe asignarse antes que nada, pues sino este flag no sera tenido en cuenta
			mzSearchPanel.LayoutData = LayoutData;
			mzSearchPanel.FastSearch = fastSearch;
			mzSearchPanel.OrderBy = orderBy;
			mzSearchPanel.SearchObject = searchObject;	
			this.Text = "Buscar " + mzSearchPanel.GetCaption;
			mzSearchPanel.EditObject = editObject;
			mzSearchPanel.NewClick += new EventHandler(CloseUI);
			mzSearchPanel.EditClick += new EventHandler(CloseUI);			
		
			this.Width = Width;			
			
		}

		private void CloseUI(object panel, EventArgs args)
		{
			this.Visible= false;
			//this.SendToBack();
		}
		private void ShowUI(object panel, EventArgs args)
		{
			//this.Visible= true;
			//this.ShowDialog();		
			//this.Activate();
			//this.Show();
			//	this.BringToFront();
		}

		#region Dispose
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
		#endregion

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.mzSearchPanel = new mz.erp.ui.controls.mzSearchPanel();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mzSearchPanel
			// 
			this.mzSearchPanel.AllowMultipleSelect = false;
			this.mzSearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.mzSearchPanel.Caption = null;
			this.mzSearchPanel.DetailObject = null;
			this.mzSearchPanel.EditObject = null;
			this.mzSearchPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzSearchPanel.LayoutData = null;
			this.mzSearchPanel.Location = new System.Drawing.Point(8, 8);
			this.mzSearchPanel.Name = "mzSearchPanel";
			this.mzSearchPanel.SearchObject = null;
			this.mzSearchPanel.SearchObjectListener = null;
			this.mzSearchPanel.Size = new System.Drawing.Size(896, 432);
			this.mzSearchPanel.TabIndex = 0;
			this.mzSearchPanel.RowDoubleClick += new mz.erp.ui.controls.mzSearchPanel.SearchPanelEventHandler(this.mzSearchPanel_RowDoubleClick);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(656, 440);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(112, 24);
			this.buttonOK.TabIndex = 8;
			this.buttonOK.Text = "&Aceptar";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(784, 440);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(112, 24);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "&Cancelar";
			// 
			// mzSearchForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(914, 472);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.mzSearchPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "mzSearchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Búsqueda";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mzSearchForm_KeyDown);
			this.Load += new System.EventHandler(this.mzSearchForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		
		private void mzSearchForm_Load(object sender, System.EventArgs e)
		{
		
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			
			bool ok = mzSearchPanel.SelectedValue != null || mzSearchPanel.SelectedRow != null || (mzSearchPanel.ArraySelectedItems != null && mzSearchPanel.ArraySelectedItems.Count > 0);
			if(ok)
				this.DialogResult = DialogResult.OK;	
			else
				this.DialogResult = DialogResult.Cancel;	

		}

		private void mzSearchPanel_RowDoubleClick(object sender, mz.erp.ui.controls.SearchEventArgs e)
		{									
			this.DialogResult = DialogResult.OK;				
		}

		#region KeyDown Events		

		private void mzSearchForm_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.F2)
			{
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
			else
			{
				if(e.KeyCode == System.Windows.Forms.Keys.Escape)
				{
					this.Close();
				}
			}

		}

		#endregion

		public object SelectedValue
		{
			get
			{
				return mzSearchPanel.SelectedValue;
			}
		}


		public object SelecedDescription
		{
			get
			{
				return mzSearchPanel.SelectedDescription;
			}
		}


		public DataRow SelectedRow
		{
			get
			{
				return mzSearchPanel.SelectedRow;
			}
			
		}
		public ArrayList SelectedItems
		{
			get
			{
				return mzSearchPanel.ArraySelectedItems;
			}
		}

		
	}
}

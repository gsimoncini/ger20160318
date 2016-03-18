using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using mz.erp.commontypes;
using System.Data;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de mzHierarchichalSearchForm.
	/// </summary>
	public class mzHierarchicalSearchForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonOK;
		private mz.erp.ui.controls.mzHierarchicalSearchPanel mzHierarchichalSearchPanel1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public mzHierarchicalSearchForm()
		{
			InitializeComponent();
			Build_UI();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// 
		public mzHierarchicalSearchForm( Type searchObject )
		{
			InitializeComponent();
			Build_UI();
			mzHierarchichalSearchPanel1.SearchObject = searchObject;			
			//this.RowDoubleClick += (new System.EventHandler(RowDoubleClick(this, new System.EventArgs ) ));			
		}


		private void Build_UI()
		{
			//ConfigureInterface();	
			//InitializeData();
			InitEventHandlers();
			//InitDataBindings();
			//FillControls();
		}


		private void InitEventHandlers()
		{
			this.KeyDown+=new KeyEventHandler(mzHierarchicalSearchForm_KeyDown);
		}


		private ISearchObjectListener _searchObjectListener;
		public ISearchObjectListener SearchObjectListener
		{
			get{return _searchObjectListener;}
			set
			{
				_searchObjectListener = value;
				mzHierarchichalSearchPanel1.SearchObjectListener = _searchObjectListener;
			}
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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.mzHierarchichalSearchPanel1 = new mz.erp.ui.controls.mzHierarchicalSearchPanel();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(600, 480);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(112, 24);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancelar";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(488, 480);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(112, 24);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&Aceptar";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// mzHierarchichalSearchPanel1
			// 
			this.mzHierarchichalSearchPanel1.Caption = null;
			this.mzHierarchichalSearchPanel1.DetailObject = null;
			this.mzHierarchichalSearchPanel1.EditObject = null;
			this.mzHierarchichalSearchPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzHierarchichalSearchPanel1.LayoutData = null;
			this.mzHierarchichalSearchPanel1.Location = new System.Drawing.Point(0, 0);
			this.mzHierarchichalSearchPanel1.Name = "mzHierarchichalSearchPanel1";
			this.mzHierarchichalSearchPanel1.SearchObject = null;
			this.mzHierarchichalSearchPanel1.Size = new System.Drawing.Size(736, 464);
			this.mzHierarchichalSearchPanel1.TabIndex = 0;
			// 
			// mzHierarchicalSearchForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(736, 509);
			this.Controls.Add(this.mzHierarchichalSearchPanel1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Name = "mzHierarchicalSearchForm";
			this.Text = "mzHierarchichalSearchForm";
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
		
		}

		public mzHierarchicalSearchForm( Type searchObject , Type editObject, bool fastSearch, string orderBy)
		{
			InitializeComponent();
			mzHierarchichalSearchPanel1.FastSearch = fastSearch;
			mzHierarchichalSearchPanel1.OrderBy = orderBy;
			mzHierarchichalSearchPanel1.SearchObject = searchObject;	
			mzHierarchichalSearchPanel1.EditObject = editObject;
			this.Text = "Buscar " + mzHierarchichalSearchPanel1.GetCaption + " por Jerarquias";
			this.mzHierarchichalSearchPanel1.RowDoubleClick += new mz.erp.ui.controls.mzHierarchicalSearchPanel.SearchPanelEventHandler(this.mzSearchPanel_RowDoubleClick);
		}

		public object SelectedValue
		{
			get
			{
				return mzHierarchichalSearchPanel1.SelectedValue;
			}
		}

		private void mzSearchPanel_RowDoubleClick(object sender, mz.erp.ui.controls.SearchEventArgs e)
		{									
			this.DialogResult = DialogResult.OK;				
		}

		public object SelecedDescription
		{
			get
			{
				return mzHierarchichalSearchPanel1.SelectedDescription;
			}
		}


		public DataRow SelectedRow
		{
			get
			{
				return mzHierarchichalSearchPanel1.SelectedRow;
			}
			
		}

		private void mzHierarchicalSearchForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData) 
			{
//				case System.Windows.Forms.Keys.F2: 
//					this.SearchNow();
//					break;
				case System.Windows.Forms.Keys.Escape :
					this.Close();
					break;
				default:
					break;
			}
		}
	}
}

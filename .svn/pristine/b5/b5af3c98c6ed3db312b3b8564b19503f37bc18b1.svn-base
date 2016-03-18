using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.businessrules;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de HierarchicalControl.
	/// </summary>
	public class HierarchicalSearchControlSimple : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.IContainer components;
		private mz.erp.ui.controls.mzComboEditor mzCEJerarquias;
		private System.Windows.Forms.TextBox txtNombreJerarquia;		
		private System.Windows.Forms.ToolTip toolTip;

		public HierarchicalSearchControlSimple()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);    
			
			//this.utbJerarquia.Click +=new EventHandler(utbJerarquia_Click);
			//this.chkJerarquia.CheckedChanged +=new EventHandler(chkJerarquia_CheckedChanged);
			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent

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

		#region Código generado por el Diseñador de componentes
		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{			
			this.components = new System.ComponentModel.Container();
			this.chkJerarquia = new System.Windows.Forms.CheckBox();
			this.utbJerarquia = new Infragistics.Win.Misc.UltraButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.mzCEJerarquias = new mz.erp.ui.controls.mzComboEditor();
			this.txtNombreJerarquia = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.mzCEJerarquias)).BeginInit();
			this.SuspendLayout();
			// 
			// chkJerarquia
			// 
			this.chkJerarquia.BackColor = System.Drawing.Color.Transparent;
			this.chkJerarquia.Location = new System.Drawing.Point(0, 0);
			this.chkJerarquia.Name = "chkJerarquia";
			this.chkJerarquia.Size = new System.Drawing.Size(196, 16);
			this.chkJerarquia.TabIndex = 1;
			this.chkJerarquia.Text = "Por Jerarquia";
			// 
			// utbJerarquia
			// 
			this.utbJerarquia.Location = new System.Drawing.Point(0, 16);
			this.utbJerarquia.Name = "utbJerarquia";
			this.utbJerarquia.Size = new System.Drawing.Size(27, 23);
			this.utbJerarquia.TabIndex = 0;
			this.utbJerarquia.Text = "...";
			// 
			// mzCEJerarquias
			// 
			this.mzCEJerarquias.AutoComplete = true;
			this.mzCEJerarquias.AutoSize = false;
			this.mzCEJerarquias.DataSource = null;
			this.mzCEJerarquias.DisplayMember = "";
			this.mzCEJerarquias.DisplayMemberCaption = "";
			this.mzCEJerarquias.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never;
			this.mzCEJerarquias.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEJerarquias.Location = new System.Drawing.Point(28, 18);
			this.mzCEJerarquias.MaxDropDownItems = 1;
			this.mzCEJerarquias.MaxItemsDisplay = 50;
			this.mzCEJerarquias.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEJerarquias.Name = "mzCEJerarquias";
			this.mzCEJerarquias.Size = new System.Drawing.Size(168, 20);
			this.mzCEJerarquias.SorterMember = "";
			this.mzCEJerarquias.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending;
			this.mzCEJerarquias.TabIndex = 2;
			this.mzCEJerarquias.ValueMember = "";
			this.mzCEJerarquias.ValueMemberCaption = "";
			// 
			// txtNombreJerarquia
			// 
			this.txtNombreJerarquia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtNombreJerarquia.Location = new System.Drawing.Point(28, 18);
			this.txtNombreJerarquia.Name = "txtNombreJerarquia";
			this.txtNombreJerarquia.ReadOnly = true;
			this.txtNombreJerarquia.Size = new System.Drawing.Size(168, 20);
			this.txtNombreJerarquia.TabIndex = 3;
			this.txtNombreJerarquia.Text = "";
			this.txtNombreJerarquia.Visible = false;
			// 
			// HierarchicalSearchControlSimple
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.chkJerarquia);
			this.Controls.Add(this.utbJerarquia);
			this.Controls.Add(this.mzCEJerarquias);
			this.Controls.Add(this.txtNombreJerarquia);
			this.Name = "HierarchicalSearchControlSimple";
			this.Size = new System.Drawing.Size(200, 40);
			((System.ComponentModel.ISupportInitialize)(this.mzCEJerarquias)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private ArrayList _itemsJerarquias = new ArrayList();
		public ArrayList ItemsJerarquias
		{
			get{return _itemsJerarquias;}
		}

		private bool _allowMultipleSelect = false;
		private string _key = string.Empty;
		private int _mzCEJerarquiasMaxItemsDisplayProductos = 50;
		private int _mzCEJerarquiasMaxItemsDisplayCuentas = 50;
		private int _mzCEJerarquiasMaxItemsDisplayProveedores = 50;


		public void Configure(string key, string rootKey, string KeyNode, string KeyNodePath, bool AllowMultipleSelect)
		{
			_key = key;
			_itemsJerarquias = new ArrayList();
			ItemJerarquia it = new ItemJerarquia(key);
			it.NodeKey = KeyNode;
			it.NodeKeyPath = KeyNodePath;
			_itemsJerarquias.Add(it);
			_rootKey = rootKey;
			_allowMultipleSelect = AllowMultipleSelect;
			DataRow row = null;
			switch (_key.ToUpper())
			{
				case "PRODUCTOS":
				{
					row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_rootKey);
				}break;
				case "CUENTAS":
				{
					row = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetByPk(_rootKey);
				}break;
				case "PROVEEDORES":
				{
					row = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetByPk(_rootKey);
				}break;
			}
			if(row != null)
				this.chkJerarquia.Text ="Por " + Convert.ToString(row["Descripcion"]);
			string valorStringProd = businessrules.Variables.GetValueString("Productos.BuscadorJerarquico.JerarquiaN.CantidadItems");
			if(!valorStringProd.Equals(string.Empty))
				_mzCEJerarquiasMaxItemsDisplayProductos = Convert.ToInt32(valorStringProd);
			string valorStringCuentas = businessrules.Variables.GetValueString("Cuentas.BuscadorJerarquico.JerarquiaN.CantidadItems");
			if(!valorStringCuentas.Equals(string.Empty))
				_mzCEJerarquiasMaxItemsDisplayCuentas = Convert.ToInt32(valorStringCuentas);
			string valorStringProv = businessrules.Variables.GetValueString("Proveedores.BuscadorJerarquico.JerarquiaN.CantidadItems");
			if(!valorStringProv.Equals(string.Empty))
				_mzCEJerarquiasMaxItemsDisplayProveedores = Convert.ToInt32(valorStringProv);
			DateTime d = DateTime.Now;
			upadateDataSourceCmbJerarquias();
			int seg = DateTime.Now.Subtract(d).Seconds;
			mzCEJerarquias.ValueChanged+=new EventHandler(mzCEJerarquias_ValueChanged);
			mzCEJerarquias.BeforeDropDown+=new CancelEventHandler(mzCEJerarquias_BeforeDropDown);
			mzCEJerarquias.TextChanged +=new EventHandler(mzCEJerarquias_TextChanged); 	
			this.utbJerarquia.Click +=new EventHandler(utbJerarquia_Click);
			this.chkJerarquia.CheckedChanged +=new EventHandler(chkJerarquia_CheckedChanged);


		}

		public bool ContainsDescription(string Description)
		{
			return _descriptionKey.Equals(Description);
		}

		


		/*
		public string RootKey
		{
			set
			{
				_rootKey = value;
				DataRow row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_rootKey);
				if(row != null)
					this.chkJerarquia.Text ="Por " + Convert.ToString(row["Descripcion"]);

			}
		}
		*/

		public void SetSelectionKey(string nodeKeyPath, string selectedNodeKey)
		{
			if(_rootKey!= null && !_rootKey.Equals(string.Empty) && nodeKeyPath.IndexOf(this._rootKey) >= 0)
			{
				ItemJerarquia it = new ItemJerarquia(this._key);
				it.NodeKey= selectedNodeKey;
                it.NodeKeyPath = nodeKeyPath;
				this._itemsJerarquias.Add(it);
				_nodeChecked = true;
				_descriptionKey = string.Empty;
				foreach(ItemJerarquia itAux in _itemsJerarquias)
				{
					if(_descriptionKey.Equals(string.Empty))
						_descriptionKey = itAux.NodeDescription;
					else
						_descriptionKey =  _descriptionKey  + "; " + itAux.NodeDescription;
		
				}
				mzCEJerarquias.Text = _descriptionKey;

				this.chkJerarquia.Checked = true;				
				
			}
		}


		public void Selected()
		{
			if (OnSelected != null)
				OnSelected( this , new System.EventArgs());
		}

		

		
		#region Propiedades
		private string _rootKey = string.Empty;
		private string _descriptionKey = string.Empty;
		private string _nodeKey = string.Empty;
		private string _nodeKeyPath = string.Empty;
		private System.Windows.Forms.CheckBox chkJerarquia;
		private Infragistics.Win.Misc.UltraButton utbJerarquia;
	
	
		public string NodeDescription
		{
			get{return _descriptionKey;}
		}

		/*
		public string NodeKeyPath
		{
			get{return _nodeKeyPath;}
			set{_nodeKeyPath = value;}
		}
		public string  NodeKey 
		{
			get { return _nodeKey; }
			set
			{
				_nodeKey = value;
				DataRow row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_rootKey);
				if(row != null)
					_descriptionKey = Convert.ToString(row["Descripcion"]);

			}
		}
		*/		
		private bool _nodeChecked = false;
		public bool  NodeChecked
		{
			get { return _nodeChecked; }
			set
			{
				this.chkJerarquia.Checked = value;				
				
			}
		}		
		#endregion
		private void chkJerarquia_CheckedChanged(object sender, System.EventArgs e)
		{
			_nodeChecked = chkJerarquia.Checked;
			if (chkJerarquia.Checked)
			{
				this.utbJerarquia.Enabled = true;
			}
			if (OnSelected != null)
				OnSelected( this , new System.EventArgs());
			
			
		}
		private void utbJerarquia_Click(object sender, System.EventArgs e)
		{
			//forms.frmSeleccionJerarquia form = new mz.erp.ui.forms.frmSeleccionJerarquia(_rootKey, _nodeKey, _nodeKeyPath);
			//Cristian Tarea 000069 20110907
            forms.frmSeleccionJerarquia form = new mz.erp.ui.forms.frmSeleccionJerarquia(_key, _rootKey, _itemsJerarquias, true, _allowMultipleSelect);
            //Fin Cristian
			form.ShowDialog();
			if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				/*
				_nodeKey = form.NodeKey;
				_nodeKeyPath = form.NodeKeyPath;
				_descriptionKey =  form.NodeDescripcion;
				*/
				_itemsJerarquias = form.ItemsJerarquias;
				// matias
				if (_itemsJerarquias.Count>1) 
				{
					this.mzCEJerarquias.Visible = false;
					this.txtNombreJerarquia.Visible = true;                                        				
				}
				else
				{
					this.mzCEJerarquias.Visible = true;
					this.txtNombreJerarquia.Visible = false;
				}
				// -- matias
				_nodeChecked = true;
				_descriptionKey = string.Empty;
				foreach(ItemJerarquia it in _itemsJerarquias)
				{
					if(_descriptionKey.Equals(string.Empty))
						_descriptionKey = it.NodeDescription;
					else
						_descriptionKey =  _descriptionKey  + "; " + it.NodeDescription;
		
				}
				txtNombreJerarquia.Text = _descriptionKey;
				mzCEJerarquias.Value = form.NodeKey;				
				toolTip.SetToolTip(mzCEJerarquias, _descriptionKey);				
				toolTip.SetToolTip(utbJerarquia, _descriptionKey);
				this.chkJerarquia.Checked = true;				
				if (OnSelected != null)
					OnSelected( this , new System.EventArgs());
			}			            		
		}
		public System.EventHandler OnSelected;


		private void mzCEJerarquias_TextChanged(object sender, EventArgs e)
		{            
			toolTip.SetToolTip(mzCEJerarquias, mzCEJerarquias.Text);				
			toolTip.SetToolTip(utbJerarquia, mzCEJerarquias.Text);
			if ( (mzCEJerarquias.Visible) && (!(Convert.ToString(mzCEJerarquias.Value)).Equals(String.Empty)) )
			{
				_itemsJerarquias = new ArrayList();
				ItemJerarquia it = new ItemJerarquia(_key);
				it.NodeKey = Convert.ToString(mzCEJerarquias.Value);
				switch(_key)
				{
			
					case "PRODUCTOS" :
					{
						it.NodeKeyPath = it.Jerarquia;
						//it.NodeKeyPath = mz.erp.businessrules.Workflow.GetCaminoJerarquiaAgrupProd(it.NodeKey);
						break;
					}
					case "CUENTAS" :
					{
						it.NodeKeyPath = it.Jerarquia;
						//it.NodeKeyPath = mz.erp.businessrules.Workflow.GetCaminoJerarquiaAgrupCuentas(it.NodeKey);
						break;
					}
					case "PROVEEDORES" :
					{
						it.NodeKeyPath = it.Jerarquia;
						//it.NodeKeyPath = mz.erp.businessrules.Workflow.GetCaminoJerarquiaAgrupProveedores(it.NodeKey);
						break;
					}
				}
				_itemsJerarquias.Add(it);	
		
				// matias
				_descriptionKey = it.NodeDescription;
				// -- fin matias
			
				
				this.chkJerarquia.Checked = false;
				this.chkJerarquia.Checked = true;				
			}

		}

		private void upadateDataSourceCmbJerarquias()
		{
			System.Data.DataTable data;
			switch(_key)
			{
			
				case "PRODUCTOS" :
				{
					commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable dataP = getJerarquiaAgrupProd(_rootKey);
					if(dataP.Rows.Count > 0)
					{
						/*
						commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow rowPadre = mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.GetByPk(_rootKey);
						dataP.ImportRow(rowPadre);
						*/
						mzCEJerarquias.FillFromDataSource(dataP, "IdNomenclatura","Descripcion",_mzCEJerarquiasMaxItemsDisplayProductos,"ID","Descripcion","Descripcion");
					}
					break;
				}
				case "CUENTAS" :
				{
                    commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataC = getJerarquiaAgrupCuentasActivas(_rootKey);

                    if(dataC.Rows.Count > 0)
					{
						commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow rowPadre = mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.GetByPk(_rootKey);
						dataC.ImportRow(rowPadre);
						mzCEJerarquias.FillFromDataSource(dataC, "IdNomenclatura","Descripcion",_mzCEJerarquiasMaxItemsDisplayCuentas,"ID","Descripcion","Descripcion");
					}
					break;
				}
				case "PROVEEDORES" :
				{
					commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable dataProv = getJerarquiaAgrupProveedores(_rootKey);
					if(dataProv.Rows.Count > 0)
					{
						commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow rowPadre = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetByPk(_rootKey);
						dataProv.ImportRow(rowPadre);
						mzCEJerarquias.FillFromDataSource(dataProv, "IdNomenclatura","Descripcion",_mzCEJerarquiasMaxItemsDisplayProveedores,"ID","Descripcion","Descripcion");

					}
					break;
				}
			}
				
		}

		private commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable getJerarquiaAgrupProd(string IdPadre)
		{
			commontypes.data.tsh_JerarquiaAgrupProdDataset data = new commontypes.data.tsh_JerarquiaAgrupProdDataset();
			//Cristian Tarea 000069 20110907
            //commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable dataP = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetListByJerarquia(IdPadre).tsh_JerarquiaAgrupProd;
            commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable dataP = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetListByJerarquia(IdPadre,true).tsh_JerarquiaAgrupProd;
			//Fin Cristian 000069 20110907
            data.Merge(dataP);
			/*
			foreach (System.Data.DataRow rowH in dataP.Rows) 
			{
				string claveH = rowH["IdNomenclatura"].ToString();
				commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable dataH = getJerarquiaAgrupProd(claveH);
				data.Merge(dataH);
			}	
			*/
			return data.tsh_JerarquiaAgrupProd;

		}

		private commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable getJerarquiaAgrupCuentas(string IdPadre)
		{
			commontypes.data.tsa_JerarquiaAgrupCuentasDataset data = new commontypes.data.tsa_JerarquiaAgrupCuentasDataset();
            commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataP = mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.GetList(IdPadre, false);
			data.Merge(dataP);
			foreach (System.Data.DataRow rowH in dataP.Rows) 
			{
				string claveH = rowH["IdNomenclatura"].ToString();
				commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataH = getJerarquiaAgrupCuentas(claveH);
				data.Merge(dataH);
			}	
			return data.tsa_JerarquiaAgrupCuentas;

		}

        //Cristian Tarea 000069 20110907
        private commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable getJerarquiaAgrupCuentasActivas(string IdPadre)
        {
            commontypes.data.tsa_JerarquiaAgrupCuentasDataset data = new commontypes.data.tsa_JerarquiaAgrupCuentasDataset();
            commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataP = mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.GetListActivas(IdPadre, true);

            data.Merge(dataP);
            foreach (System.Data.DataRow rowH in dataP.Rows)
            {
                string claveH = rowH["IdNomenclatura"].ToString();
                commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataH = getJerarquiaAgrupCuentasActivas(claveH);
                data.Merge(dataH);
            }
            return data.tsa_JerarquiaAgrupCuentas;

        }
        //Fin Cristian
		private commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable getJerarquiaAgrupProveedores(string IdPadre)
		{
			commontypes.data.tpu_JerarquiaAgrupProveedoresDataset data = new commontypes.data.tpu_JerarquiaAgrupProveedoresDataset();
            //Cristian Tarea 000069 20110907
			commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable dataP = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetListActivas(IdPadre, true);
			//Fin Cristian
            data.Merge(dataP);
			foreach (System.Data.DataRow rowH in dataP.Rows) 
			{
				string claveH = rowH["IdNomenclatura"].ToString();
				commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable dataH = getJerarquiaAgrupProveedores(claveH);
				data.Merge(dataH);
			}	
			return data.tpu_JerarquiaAgrupProveedores;

		}

		private void mzCEJerarquias_ValueChanged(object sender, EventArgs e)
		{
			this.mzCEJerarquias_TextChanged(sender, new EventArgs());			
		}

		private void mzCEJerarquias_BeforeDropDown(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
		}

		public void ClearControl()
		{
			txtNombreJerarquia.Text=string.Empty;
			mzCEJerarquias.Value=string.Empty;
		}
	}
	 
}

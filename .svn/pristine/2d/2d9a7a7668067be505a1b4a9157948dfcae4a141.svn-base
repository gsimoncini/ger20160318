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
	/// Descripción breve de mzSearchTextBox.
	/// </summary>
	public class mzSearchTextBox : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TextBox txtNombreJerarquia;
		private Infragistics.Win.Misc.UltraButton utbJerarquia;
		private mz.erp.ui.controls.mzComboEditor mzCEJerarquias;
		//private System.Windows.Forms.ToolTip toolTip;
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public mzSearchTextBox()
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
			InitEvents();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent

		}

		private void InitEvents()
		{
			this.Resize += new System.EventHandler(this.mzSearchTextBox_Resize);
			this.KeyDown +=new KeyEventHandler(mzSearchTextBox_KeyDown);
			txtNombreJerarquia.KeyDown +=new KeyEventHandler(txtNombreJerarquia_KeyDown);
			mzCEJerarquias.KeyDown +=new KeyEventHandler(mzCEJerarquias_KeyDown);
		}

		public void Init(bool AllowMultipleSelect)
		{
			string _key = "PRODUCTOS";
			string _nodeKey = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada");
			string _separador = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada.Separador");
            /* Silvina 20111226 - Tarea 0000241 */
			Configure(_key, _nodeKey,_nodeKey,_nodeKey, AllowMultipleSelect, _separador);
            /* Fin Silvina 20111226 - Tarea 0000241 */
		}

        /* Silvina 20111104 - Tarea 0000222 */

        /* Silvina 20111226 - Tarea 0000241 */          
        public void Init(string Key, bool AllowMultipleSelect, string NodeKey, string Separador)
        {
            string _key = Key;
            Configure(_key, NodeKey, NodeKey, NodeKey, AllowMultipleSelect, Separador);
        }
        /* Fin Silvina 20111226 - Tarea 0000241 */
        /* Fin Silvina 20111104 - Tarea 0000222 */

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
			this.txtNombreJerarquia = new System.Windows.Forms.TextBox();
			this.utbJerarquia = new Infragistics.Win.Misc.UltraButton();
			this.mzCEJerarquias = new mz.erp.ui.controls.mzComboEditor();
			//this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.mzCEJerarquias)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNombreJerarquia
			// 
			this.txtNombreJerarquia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtNombreJerarquia.Location = new System.Drawing.Point(0, 1);
			this.txtNombreJerarquia.Name = "txtNombreJerarquia";
			this.txtNombreJerarquia.ReadOnly = true;
			this.txtNombreJerarquia.Size = new System.Drawing.Size(168, 20);
			this.txtNombreJerarquia.TabIndex = 5;
			this.txtNombreJerarquia.Text = "";
			this.txtNombreJerarquia.Visible = false;
			// 
			// utbJerarquia
			// 
			this.utbJerarquia.Location = new System.Drawing.Point(168, -1);
			this.utbJerarquia.Name = "utbJerarquia";
			this.utbJerarquia.Size = new System.Drawing.Size(27, 23);
			this.utbJerarquia.TabIndex = 4;
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
			this.mzCEJerarquias.Location = new System.Drawing.Point(0, 0);
			this.mzCEJerarquias.MaxItemsDisplay = 200;
			this.mzCEJerarquias.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEJerarquias.Name = "mzCEJerarquias";
			this.mzCEJerarquias.Size = new System.Drawing.Size(168, 21);
			this.mzCEJerarquias.SorterMember = "";
			this.mzCEJerarquias.TabIndex = 6;
			this.mzCEJerarquias.ValueMember = "";
			this.mzCEJerarquias.ValueMemberCaption = "";
			// 
			// mzSearchTextBox
			// 
			this.Controls.Add(this.txtNombreJerarquia);
			this.Controls.Add(this.mzCEJerarquias);
			this.Controls.Add(this.utbJerarquia);
			this.Name = "mzSearchTextBox";
			this.Size = new System.Drawing.Size(200, 24);
			Console.WriteLine("Llegueeeeeeeeeeeeeeeeeeeeeee");
			((System.ComponentModel.ISupportInitialize)(this.mzCEJerarquias)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void mzSearchTextBox_Resize(object sender, System.EventArgs e)
		{
				
				utbJerarquia.SetBounds(this.Width - utbJerarquia.Width, utbJerarquia.Location.Y, utbJerarquia.Width, utbJerarquia.Height);
				txtNombreJerarquia.SetBounds(txtNombreJerarquia.Location.X, txtNombreJerarquia.Location.Y, this.Width - utbJerarquia.Width, txtNombreJerarquia.Height);
				mzCEJerarquias.SetBounds(mzCEJerarquias.Location.X, mzCEJerarquias.Location.Y, this.Width - utbJerarquia.Width, mzCEJerarquias.Height);
				
		}

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

        /* Silvina 20111226 - Tarea 0000241 */
        private string _separador = string.Empty;

		public void Configure(string key, string rootKey, string KeyNode, string KeyNodePath, bool AllowMultipleSelect, string Separador)
        /* Fin Silvina 20111226 - Tarea 0000241 */
		{
			_key = key;
			_itemsJerarquias = new ArrayList();
			ItemJerarquia it = new ItemJerarquia(key);
			it.NodeKey = KeyNode;
			it.NodeKeyPath = KeyNodePath;
			_itemsJerarquias.Add(it);
			_rootKey = rootKey;
			_allowMultipleSelect = AllowMultipleSelect;
            /* Silvina 20111226 - Tarea 0000241 */
            _separador = Separador;
            if (string.IsNullOrEmpty(_separador))
                _separador = ",";
            /* Fin Silvina 20111226 - Tarea 0000241 */
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
				_descriptionKey = string.Empty;
				foreach(ItemJerarquia itAux in _itemsJerarquias)
				{
					if(_descriptionKey.Equals(string.Empty))
						_descriptionKey = itAux.NodeDescription;//.Substring(1, itAux.NodeDescription.IndexOf("-"));
					else
                        /* Silvina 20111226 - Tarea 0000241 */
						_descriptionKey =  _descriptionKey  + _separador + itAux.NodeDescription;//.Substring(1, itAux.NodeDescription.IndexOf("-"));
                        /* Fin Silvina 20111226 - Tarea 0000241 */
				}
				mzCEJerarquias.Text = _descriptionKey;

				
				
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
		
		#endregion

		public void SetJerarquias(ArrayList Jerarquias)
		{
			_itemsJerarquias = Jerarquias;
			if (_itemsJerarquias.Count>1) 
			{
				this.mzCEJerarquias.Visible = false;
				this.txtNombreJerarquia.Visible = true;                                        				
			}
			else
			{
				this.mzCEJerarquias.Visible = true;
				this.txtNombreJerarquia.Visible = false;
				if(_itemsJerarquias.Count == 1)
				{
					ItemJerarquia i1 = (ItemJerarquia)_itemsJerarquias[0];
					mzCEJerarquias.Value = i1.NodeKey;
				}
			}
			// -- matias
			_descriptionKey = string.Empty;
			foreach(ItemJerarquia it in _itemsJerarquias)
			{
				if(_descriptionKey.Equals(string.Empty))
					_descriptionKey = it.NodeDescription;//.Substring(1, it.NodeDescription.IndexOf("-"));
				else
                    /* Silvina 20111226 - Tarea 0000241 */
					_descriptionKey =  _descriptionKey  + _separador + it.NodeDescription;//.Substring(1, it.NodeDescription.IndexOf("-"));
                    /* Fin Silvina 20111226 - Tarea 0000241 */
			}
			txtNombreJerarquia.Text = _descriptionKey;
			
		}

		private void utbJerarquia_Click(object sender, System.EventArgs e)
		{
			//forms.frmSeleccionJerarquia form = new mz.erp.ui.forms.frmSeleccionJerarquia(_rootKey, _nodeKey, _nodeKeyPath);
			forms.frmSeleccionJerarquia form = new forms.frmSeleccionJerarquia(_key, _rootKey, _itemsJerarquias, _allowMultipleSelect);
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
				_descriptionKey = string.Empty;
				foreach(ItemJerarquia it in _itemsJerarquias)
				{
					if(_descriptionKey.Equals(string.Empty))
						_descriptionKey = it.NodeDescription;//.Substring(1, it.NodeDescription.IndexOf("-"));
					else
                        /* Silvina 20111226 - Tarea 0000241 */
						_descriptionKey =  _descriptionKey  + _separador + it.NodeDescription;//.Substring(1, it.NodeDescription.IndexOf("-"));
                        /* Fin Silvina 20111226 - Tarea 0000241 */
				}
				txtNombreJerarquia.Text = _descriptionKey;
				mzCEJerarquias.Value = form.NodeKey;				
				//toolTip.SetToolTip(mzCEJerarquias, _descriptionKey);				
				//toolTip.SetToolTip(utbJerarquia, _descriptionKey);
				if (OnSelected != null)
					OnSelected( this , new System.EventArgs());
			}			            		
		}
		public System.EventHandler OnSelected;


		private void mzCEJerarquias_TextChanged(object sender, EventArgs e)
		{            
			//toolTip.SetToolTip(mzCEJerarquias, mzCEJerarquias.Text);				
			//toolTip.SetToolTip(utbJerarquia, mzCEJerarquias.Text);
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
				_descriptionKey = it.NodeDescription;//.Substring(1, it.NodeDescription.IndexOf("-"));
				// -- fin matias
			
				
			
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
					commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasDataTable dataC = getJerarquiaAgrupCuentas(_rootKey);
					if(dataC.Rows.Count > 0)
					{
						commontypes.data.tsa_JerarquiaAgrupCuentasDataset.tsa_JerarquiaAgrupCuentasRow rowPadre = tsa_JerarquiaAgrupCuentas.GetByPk(_rootKey);
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
						commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresRow rowPadre = tpu_JerarquiaAgrupProveedores.GetByPk(_rootKey);
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
			commontypes.data.tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdDataTable dataP = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetListByJerarquia(IdPadre).tsh_JerarquiaAgrupProd;
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


		private commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable getJerarquiaAgrupProveedores(string IdPadre)
		{
			commontypes.data.tpu_JerarquiaAgrupProveedoresDataset data = new commontypes.data.tpu_JerarquiaAgrupProveedoresDataset();
			commontypes.data.tpu_JerarquiaAgrupProveedoresDataset.tpu_JerarquiaAgrupProveedoresDataTable dataP = mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.GetList(IdPadre, false);
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

		private void mzSearchTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.Escape
				|| e.KeyCode == System.Windows.Forms.Keys.Delete
				|| e.KeyCode == System.Windows.Forms.Keys.Return)
			{
				Reset();
			}
		}

		private void txtNombreJerarquia_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.Escape
				|| e.KeyCode == System.Windows.Forms.Keys.Delete
				|| e.KeyCode == System.Windows.Forms.Keys.Return)
			{
				Reset();
			}
		}

		private void mzCEJerarquias_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.Escape
				|| e.KeyCode == System.Windows.Forms.Keys.Delete
				|| e.KeyCode == System.Windows.Forms.Keys.Return)
			{
				Reset();
			}
		}

		public void Reset()
		{

			_descriptionKey = string.Empty;
			txtNombreJerarquia.Text = string.Empty;
			_itemsJerarquias.Clear();
			mzCEJerarquias.Visible = true;
			mzCEJerarquias.Clear();
			txtNombreJerarquia.Visible = false;
		}
	}
}

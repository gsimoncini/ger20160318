using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de frmSeleccionJerarquia.
	/// </summary>
	public class frmSeleccionJerarquia : System.Windows.Forms.Form
	{
		private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
		internal System.Windows.Forms.Button buttonCancel;
		internal System.Windows.Forms.Button buttonOK;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;
        //Cristian Tarea 000069
        bool _filtroJerarquiaActiva = false;
        //Fin Cristian
        //Cristian Tarea 000069 20110907
		public frmSeleccionJerarquia(string Key, string RootKey, ArrayList items, bool activas,  bool AllowMultipleSelect)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_rootKey = RootKey;
            _filtroJerarquiaActiva = activas;
			_itemsJerarquias = items;
            _allowMultipleSelect = AllowMultipleSelect;
			_key = Key;
            //German 20111107 - Tarea 0000224
			//Build_UI();
            if (_allowMultipleSelect)
            {
                ultraTree1.Override.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended;
            }
            ConfigureInterfaceMultipleSelect();
            //Fin German 20111107 - Tarea 0000224

		}
        //Fin Cristian Tarea 000069
        
        public frmSeleccionJerarquia(string Key, string RootKey, string SelectedKey, string SelectedKeyPath)
        {
            //
            // Necesario para admitir el Diseñador de Windows Forms
            //
            InitializeComponent();
            _rootKey = RootKey;
            _selectedKey = SelectedKey;
            _selectedKeyPath = SelectedKeyPath;
            _key = Key;
            Build_UI();

            //
            // TODO: agregar código de constructor después de llamar a InitializeComponent
            //
        }
        
		public frmSeleccionJerarquia(string Key,string RootKey,ArrayList Items, bool AllowMultipleSelect)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_rootKey = RootKey;
			_itemsJerarquias = Items; 
			
            _allowMultipleSelect = AllowMultipleSelect;
			_key = Key;
            if (_allowMultipleSelect)
            {
                ultraTree1.Override.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Extended;
            }
			ConfigureInterfaceMultipleSelect();
			

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
            Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
            Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
            this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraTree1
            // 
            this.ultraTree1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraTree1.HideSelection = false;
            this.ultraTree1.Location = new System.Drawing.Point(10, 9);
            this.ultraTree1.Name = "ultraTree1";
            ultraTreeNode1.Key = "RAIZ";
            ultraTreeNode1.Text = "Agrupamientos";
            this.ultraTree1.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
            ultraTreeNode1});
            _override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
            this.ultraTree1.Override = _override1;
            this.ultraTree1.Size = new System.Drawing.Size(564, 354);
            this.ultraTree1.TabIndex = 17;
            this.ultraTree1.AfterActivate += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterActivate);
            this.ultraTree1.AfterExpand += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterExpand);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(440, 372);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 28);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "&Cancelar";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(296, 372);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(134, 28);
            this.buttonOK.TabIndex = 18;
            this.buttonOK.Text = "&Aceptar";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // frmSeleccionJerarquia
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.ultraTree1);
            this.Name = "frmSeleccionJerarquia";
            this.Text = "frmSeleccionJerarquia";
            ((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Variables privadas
		private bool _expandir = true;
		private string _rootKey = string.Empty;
		private string _selectedKey = string.Empty;
		private string _selectedKeyPath = string.Empty;
		private bool _allowMultipleSelect = false;
		private string _key = string.Empty;
		#endregion
		#region Propiedades

		private ArrayList _itemsJerarquias = new ArrayList();

		public ArrayList ItemsJerarquias
		{
			get{return _itemsJerarquias;}
		}
		
	
		private string _nodeKeyPath = string.Empty;
		public string NodeKeyPath
		{
			get{return _nodeKeyPath;}
		}
		

		private string _nodeKey = "";
		public string NodeKey 
		{
			get {return _nodeKey;}
		}
		private string _nodeDescripcion = "";
        private bool p;
		public string NodeDescripcion 
		{
			get {return _nodeDescripcion;}
		}			

		#endregion
		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}
		
		
		private void ConfigureInterface()
		{											
			ultraTree1.CollapseAll();
			this.ultraTree1.Nodes[0].Key = _rootKey;
			switch (_key.ToUpper())
			{
				case "PRODUCTOS":
				{
					this.ultraTree1.Nodes[0].Text = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_rootKey).Descripcion;
					_expandir = false;
					ultraTree1.Nodes[0].Expanded = true;
					if(_rootKey.Equals(_selectedKey))
						mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(this.ultraTree1.Nodes[0]);			
					else mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(this.ultraTree1.Nodes[0],_selectedKeyPath);			
			
				}break;
				case "CUENTAS":
				{
					this.ultraTree1.Nodes[0].Text = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetByPk(_rootKey).Descripcion;
					_expandir = false;
					ultraTree1.Nodes[0].Expanded = true;
                    //Cristian Tarea 000069 20110709
                    if (!_filtroJerarquiaActiva)
                    {
                        if (_rootKey.Equals(_selectedKey))
                            mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietos(this.ultraTree1.Nodes[0]);
                        else mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietos(this.ultraTree1.Nodes[0], _selectedKeyPath);
                    }
                    else {
                        if (_rootKey.Equals(_selectedKey))
                            mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietosActivos(this.ultraTree1.Nodes[0]);
                        else mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietosActivos(this.ultraTree1.Nodes[0], _selectedKeyPath);
                    }
			        //Fin Cristian
				}break;
				case "PROVEEDORES":
				{
					this.ultraTree1.Nodes[0].Text = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetByPk(_rootKey).Descripcion;
					_expandir = false;
					ultraTree1.Nodes[0].Expanded = true;
                                        //Cristian Tarea 000069 20110709
                    if (!_filtroJerarquiaActiva)
                    {
                        if (_rootKey.Equals(_selectedKey))
                            mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(this.ultraTree1.Nodes[0]);
                        else mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(this.ultraTree1.Nodes[0], _selectedKeyPath);
                    }
                    else {
                        if (_rootKey.Equals(_selectedKey))
                            mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(this.ultraTree1.Nodes[0]);
                        else mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(this.ultraTree1.Nodes[0], _selectedKeyPath);
                    }
				}break;
			}
			_nodeKey =  _selectedKey;
			_nodeKeyPath = _selectedKeyPath;
			ItemJerarquia it = new ItemJerarquia(this._key);

					SetSelection();
					_expandir = true; //porque al expandir el árbol va al evento AfterExpand y entre nuevamente a HijoYNietos
		}


		private void ConfigureInterfaceMultipleSelect()
		{											
			ultraTree1.CollapseAll();
			this.ultraTree1.Nodes[0].Key = _rootKey;
			switch(_key)
			{
			
				case "PRODUCTOS" :
				{
					this.ultraTree1.Nodes[0].Text = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_rootKey).Descripcion;
				}break;
				case "CUENTAS" :
				{
					this.ultraTree1.Nodes[0].Text = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetByPk(_rootKey).Descripcion;
				}break;
				case "PROVEEDORES" :
				{
					this.ultraTree1.Nodes[0].Text = mz.erp.businessrules.tpu_JerarquiaAgrupProveedores.GetByPk(_rootKey).Descripcion;
				}break;
			}
			
			_expandir = false;
			ultraTree1.Nodes[0].Expanded = true;
			if(this._itemsJerarquias.Count == 0)
			{
				
				switch(_key)
				{
			
					case "PRODUCTOS" :
					{
						mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(this.ultraTree1.Nodes[0]);
					}break;
					case "CUENTAS" :
					{
                        //Cristian Tarea 000069 20110907
					    if(!_filtroJerarquiaActiva){
                        mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietos(this.ultraTree1.Nodes[0]);}
                        else
                        { mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietosActivos(this.ultraTree1.Nodes[0]);}
                        //Fin Cristian tarea 000069 
					}break;
					case "PROVEEDORES" :
					{
						mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(this.ultraTree1.Nodes[0]);
					}break;
				}
				
				
				_selectedKey = _rootKey;
				_nodeKey =  _selectedKey;
				SetSelection();
			}
			else
			{
				foreach(ItemJerarquia it in this._itemsJerarquias)
				{
					_selectedKey = it.NodeKey;
					_selectedKeyPath = it.NodeKeyPath;
					switch(_key)
					{
			
						case "PRODUCTOS" :
						{
							
							if(_rootKey.Equals(_selectedKey))
								mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(this.ultraTree1.Nodes[0],false,true);			
							else mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(this.ultraTree1.Nodes[0],_selectedKeyPath);			
						}break;
						case "CUENTAS" :
						{
							
							if(_rootKey.Equals(_selectedKey))
								mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietos(this.ultraTree1.Nodes[0],false,true);			
							else mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietos(this.ultraTree1.Nodes[0],_selectedKeyPath);			
						}break;
						case "PROVEEDORES" :
						{
							
							if(_rootKey.Equals(_selectedKey))
								mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(this.ultraTree1.Nodes[0],false,true);			
							else mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(this.ultraTree1.Nodes[0],_selectedKeyPath);			
						}break;
					}
					
				}
				foreach(ItemJerarquia it in this._itemsJerarquias)
				{
					_selectedKey = it.NodeKey;
					_selectedKeyPath = it.NodeKeyPath;
					_nodeKey =  _selectedKey;
					SetSelection();
				}
			}
		

			_expandir = true; //porque al expandir el árbol va al evento AfterExpand y entre nuevamente a HijoYNietos
		}
		
		private void SetSelection()
		{
			if(_selectedKey.Equals(_rootKey))
			{
				this.ultraTree1.Nodes[_selectedKey].Expanded = true;
				this.ultraTree1.Nodes[_selectedKey].Selected = true;
			}
			else
                //Cristian Tarea 000069
                if (!_selectedKeyPath.Equals(String.Empty))
				SetSelection(ultraTree1.Nodes[0],_selectedKeyPath.Substring(20));
                //Fin Cristian Tarea 000069
		}



		private void SetSelection(Infragistics.Win.UltraWinTree.UltraTreeNode tree, string path)
		{
			if(ContainKey(tree, _selectedKey))
			{
				tree.Nodes[_selectedKey].Expanded = true;
				tree.Nodes[_selectedKey].Selected = true;
				
			}
			else
			{
				if(path.Length >= 20)
				{
					string j = path.Substring(0,20);
					string newpath = path.Substring(20);
					tree.Nodes[j].Expanded = true;
					//tree.Nodes[j].Selected = true;
					SetSelection(tree.Nodes[j], newpath);
				}
			}
		}

		private bool ContainKey(Infragistics.Win.UltraWinTree.UltraTreeNode tree, string key )
		{
			foreach(Infragistics.Win.UltraWinTree.UltraTreeNode node in tree.Nodes)
			{
				if(node.Key.Equals(key))
					return true;
			}
			return false;
		}



	private void InitializeData()
	{
	}
	private void InitEventHandlers()
	{
		this.ultraTree1.DoubleClick += new System.EventHandler(this.buttonOK_Click);
	}
	private void InitDataBindings()
	{
	}
	private void buttonOK_Click(object sender, System.EventArgs e)
	{			
		_itemsJerarquias = new ArrayList();
		foreach(Infragistics.Win.UltraWinTree.UltraTreeNode node in ultraTree1.SelectedNodes)
		{
			ItemJerarquia it = new ItemJerarquia(this._key);
			it.NodeKey = node.Key;
			it.NodeKeyPath = _rootKey  + GetHierarchy(node, string.Empty);
			_itemsJerarquias.Add(it);
		}
		
		this.DialogResult = System.Windows.Forms.DialogResult.OK;
		this.Close();
	}

	private void ultraTree1_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
{			
	_nodeKey = e.TreeNode.Key;
	_nodeKeyPath =  _rootKey  + GetHierarchy(e.TreeNode, string.Empty);
	_nodeDescripcion = e.TreeNode.Text;
}

	private void ultraTree1_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
	{
		if (_expandir) 
		{
			switch (_key.ToUpper())
			{
				case "PRODUCTOS":
				{
					mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(e.TreeNode, false, true);					
				}break;
				case "CUENTAS":
				{
					mz.erp.ui.forms.classes.tsa_JerarquiaAgrupCuentas.HijosYNietos(e.TreeNode, false, true);
				}break;
				case "PROVEEDORES":
				{
					mz.erp.ui.forms.classes.tpu_JerarquiaAgrupProveedores.HijosYNietos(e.TreeNode, false, true);
				}break;
			}
		}
	}

	private string GetHierarchy(Infragistics.Win.UltraWinTree.UltraTreeNode Nodo, string aux)
{
	if(Nodo.IsRootLevelNode)
	return aux;
	else
	return GetHierarchy(Nodo.Parent,   Nodo.Key + aux);

}
}

public class Nodekey: Infragistics.Shared.IKeyedSubObject
{
	#region Miembros de IKeyedSubObject


	private string _key = string.Empty;
	public string Key
	{
		get
		{
			
			return _key;
		}
		set
		{
			_key = value;
		}
	}

	public void OnRemovedFromCollection(Infragistics.Shared.KeyedSubObjectsCollectionBase primaryCollection)
	{
		// TODO: agregar la implementación Nodekey.OnRemovedFromCollection
	}

	public void OnAddedToCollection(Infragistics.Shared.KeyedSubObjectsCollectionBase primaryCollection)
	{
		// TODO: agregar la implementación Nodekey.OnAddedToCollection
	}

	#endregion

}
}

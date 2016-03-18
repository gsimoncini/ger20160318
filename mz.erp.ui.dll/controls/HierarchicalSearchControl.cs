using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.businessrules.data;
using mz.erp.businessrules;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de HierarchicalSearchControl.
	/// </summary>
	public class HierarchicalSearchControl : System.Windows.Forms.UserControl
	{
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple1;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple2;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple6;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple4;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple5;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple3;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple7;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple8;
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HierarchicalSearchControl()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			  
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);  
			
			
				

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent

		}

		

		public void Build_UI(string key, bool AllowMultipleSelect)
		{
			_key = key;
			DateTime d = DateTime.Now;
			_uiController = new HierarchicalSearchControlController(_key);
			int seg = DateTime.Now.Subtract(d).Seconds;
			_allowMultipleSelect = AllowMultipleSelect;
			d = DateTime.Now;
			ConfigureInterface();	
			int seg1 = DateTime.Now.Subtract(d).Seconds;
			d = DateTime.Now;
			InitializeData();
			int seg2 = DateTime.Now.Subtract(d).Seconds;
			d = DateTime.Now;
			InitEventHandlers();
			int seg3 = DateTime.Now.Subtract(d).Seconds;
			d = DateTime.Now;
			InitDataBindings();	
			int seg4 = DateTime.Now.Subtract(d).Seconds;
			Console.WriteLine("");
		}

		private void ConfigureInterface()
		{			
			if(_uiController.IsValidKey1)
			{
				/*
				hierarchicalSearchControlSimple1.RootKey = _uiController.NodeKey1;
				hierarchicalSearchControlSimple1.NodeKey = _uiController.NodeKey1;
				hierarchicalSearchControlSimple1.NodeKeyPath = _uiController.NodeKey1;
				*/
				hierarchicalSearchControlSimple1.Configure(_key, _uiController.NodeKey1,_uiController.NodeKey1,_uiController.NodeKey1, _allowMultipleSelect);
				hierarchicalSearchControlSimple1.Enabled = true;
				hierarchicalSearchControlSimple1.Visible = true;
				hierarchicalSearchControlSimple1.OnSelected +=	new EventHandler(OnSelected1);
				
			}
			else 
			{
				hierarchicalSearchControlSimple1.Visible = false;
				hierarchicalSearchControlSimple1.Enabled = false;
			}
				
			if(_uiController.IsValidKey2)
			{
				/*
				hierarchicalSearchControlSimple2.RootKey = _uiController.NodeKey2;
				hierarchicalSearchControlSimple2.NodeKey = _uiController.NodeKey2;
				hierarchicalSearchControlSimple2.NodeKeyPath = _uiController.NodeKey2;
				*/
				hierarchicalSearchControlSimple2.Configure(_key, _uiController.NodeKey2,_uiController.NodeKey2,_uiController.NodeKey2, _allowMultipleSelect);
				hierarchicalSearchControlSimple2.Enabled = true;
				hierarchicalSearchControlSimple2.Visible = true;
				hierarchicalSearchControlSimple2.OnSelected +=	new EventHandler(OnSelected2);
				
			}
			else 
			{
				hierarchicalSearchControlSimple2.Visible = false;
				hierarchicalSearchControlSimple2.Enabled = false;
			}

			if(_uiController.IsValidKey3)
			{
				/*
				hierarchicalSearchControlSimple3.RootKey = _uiController.NodeKey3;
				hierarchicalSearchControlSimple3.NodeKey = _uiController.NodeKey3;
				hierarchicalSearchControlSimple2.NodeKeyPath = _uiController.NodeKey3;
				*/
				hierarchicalSearchControlSimple3.Configure(_key, _uiController.NodeKey3,_uiController.NodeKey3,_uiController.NodeKey3, _allowMultipleSelect);
				hierarchicalSearchControlSimple3.Enabled = true;
				hierarchicalSearchControlSimple3.Visible = true;
				hierarchicalSearchControlSimple3.OnSelected +=	new EventHandler(OnSelected3);
				
				
			}
			else 
			{
				hierarchicalSearchControlSimple3.Visible = false;
				hierarchicalSearchControlSimple3.Enabled = false;
			}


			if(_uiController.IsValidKey4)
			{
				/*
				hierarchicalSearchControlSimple4.RootKey = _uiController.NodeKey4;
				hierarchicalSearchControlSimple4.NodeKey = _uiController.NodeKey4;
				hierarchicalSearchControlSimple4.NodeKeyPath = _uiController.NodeKey4;
				*/
				hierarchicalSearchControlSimple4.Configure(_key, _uiController.NodeKey4,_uiController.NodeKey4,_uiController.NodeKey4, _allowMultipleSelect);
				hierarchicalSearchControlSimple4.Enabled = true;
				hierarchicalSearchControlSimple4.Visible = true;
				hierarchicalSearchControlSimple4.OnSelected +=	new EventHandler(OnSelected4);
				
			}
			else 
			{
				hierarchicalSearchControlSimple4.Visible = false;
				hierarchicalSearchControlSimple4.Enabled = false;
			}

			if(_uiController.IsValidKey5)
			{
				/*
				hierarchicalSearchControlSimple5.RootKey = _uiController.NodeKey5;
				hierarchicalSearchControlSimple5.NodeKey = _uiController.NodeKey5;
				hierarchicalSearchControlSimple5.NodeKeyPath = _uiController.NodeKey5;
				*/

				hierarchicalSearchControlSimple5.Configure(_key, _uiController.NodeKey5,_uiController.NodeKey5,_uiController.NodeKey5, _allowMultipleSelect);
				hierarchicalSearchControlSimple5.Enabled = true;
				hierarchicalSearchControlSimple5.Visible = true;
				hierarchicalSearchControlSimple5.OnSelected +=	new EventHandler(OnSelected5);
			}
			else 
			{
				hierarchicalSearchControlSimple5.Visible = false;
				hierarchicalSearchControlSimple5.Enabled = false;
			}

			if(_uiController.IsValidKey6)
			{				
				hierarchicalSearchControlSimple6.Configure(_key, _uiController.NodeKey6,_uiController.NodeKey6,_uiController.NodeKey6, _allowMultipleSelect);
				hierarchicalSearchControlSimple6.Enabled = true;
				hierarchicalSearchControlSimple6.Visible = true;
				hierarchicalSearchControlSimple6.OnSelected +=	new EventHandler(OnSelected6);
			}
			else 
			{
				hierarchicalSearchControlSimple6.Visible = false;
				hierarchicalSearchControlSimple6.Enabled = false;
			}

			if(_uiController.IsValidKey7)
			{				
				hierarchicalSearchControlSimple7.Configure(_key, _uiController.NodeKey7,_uiController.NodeKey7,_uiController.NodeKey7, _allowMultipleSelect);
				hierarchicalSearchControlSimple7.Enabled = true;
				hierarchicalSearchControlSimple7.Visible = true;
				hierarchicalSearchControlSimple7.OnSelected +=	new EventHandler(OnSelected7);
			}
			else 
			{
				hierarchicalSearchControlSimple7.Visible = false;
				hierarchicalSearchControlSimple7.Enabled = false;
			}

			if(_uiController.IsValidKey8)
			{				
				hierarchicalSearchControlSimple8.Configure(_key, _uiController.NodeKey8,_uiController.NodeKey8,_uiController.NodeKey8, _allowMultipleSelect);
				hierarchicalSearchControlSimple8.Enabled = true;
				hierarchicalSearchControlSimple8.Visible = true;
				hierarchicalSearchControlSimple8.OnSelected +=	new EventHandler(OnSelected8);
			}
			else 
			{
				hierarchicalSearchControlSimple8.Visible = false;
				hierarchicalSearchControlSimple8.Enabled = false;
			}

			if(_uiController.IsValidKey5 || _uiController.IsValidKey6 || _uiController.IsValidKey7 || _uiController.IsValidKey8)
				this.Size = new System.Drawing.Size(952, 92); // Alto doble
			else
				this.Size = new System.Drawing.Size(952, 44); // Alto simple
			
			
		
		}
		private void InitializeData(){}
		private void InitEventHandlers()
		{
			
		}
		private void InitDataBindings(){}

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
			this.hierarchicalSearchControlSimple1 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple2 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple4 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple5 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple3 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple6 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple7 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple8 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.SuspendLayout();
			// 
			// hierarchicalSearchControlSimple1
			// 
			this.hierarchicalSearchControlSimple1.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple1.Location = new System.Drawing.Point(0, 2);
			this.hierarchicalSearchControlSimple1.Name = "hierarchicalSearchControlSimple1";
			this.hierarchicalSearchControlSimple1.NodeChecked = false;
			this.hierarchicalSearchControlSimple1.Size = new System.Drawing.Size(200, 43);
			this.hierarchicalSearchControlSimple1.TabIndex = 0;
			// 
			// hierarchicalSearchControlSimple2
			// 
			this.hierarchicalSearchControlSimple2.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple2.Location = new System.Drawing.Point(197, 2);
			this.hierarchicalSearchControlSimple2.Name = "hierarchicalSearchControlSimple2";
			this.hierarchicalSearchControlSimple2.NodeChecked = false;
			this.hierarchicalSearchControlSimple2.Size = new System.Drawing.Size(203, 43);
			this.hierarchicalSearchControlSimple2.TabIndex = 1;
			// 
			// hierarchicalSearchControlSimple4
			// 
			this.hierarchicalSearchControlSimple4.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple4.Location = new System.Drawing.Point(592, 2);
			this.hierarchicalSearchControlSimple4.Name = "hierarchicalSearchControlSimple4";
			this.hierarchicalSearchControlSimple4.NodeChecked = false;
			this.hierarchicalSearchControlSimple4.Size = new System.Drawing.Size(196, 43);
			this.hierarchicalSearchControlSimple4.TabIndex = 3;
			// 
			// hierarchicalSearchControlSimple5
			// 
			this.hierarchicalSearchControlSimple5.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple5.Location = new System.Drawing.Point(0, 48);
			this.hierarchicalSearchControlSimple5.Name = "hierarchicalSearchControlSimple5";
			this.hierarchicalSearchControlSimple5.NodeChecked = false;
			this.hierarchicalSearchControlSimple5.Size = new System.Drawing.Size(200, 43);
			this.hierarchicalSearchControlSimple5.TabIndex = 4;
			// 
			// hierarchicalSearchControlSimple3
			// 
			this.hierarchicalSearchControlSimple3.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple3.Location = new System.Drawing.Point(394, 2);
			this.hierarchicalSearchControlSimple3.Name = "hierarchicalSearchControlSimple3";
			this.hierarchicalSearchControlSimple3.NodeChecked = false;
			this.hierarchicalSearchControlSimple3.Size = new System.Drawing.Size(196, 43);
			this.hierarchicalSearchControlSimple3.TabIndex = 2;
			// 
			// hierarchicalSearchControlSimple6
			// 
			this.hierarchicalSearchControlSimple6.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple6.Location = new System.Drawing.Point(197, 48);
			this.hierarchicalSearchControlSimple6.Name = "hierarchicalSearchControlSimple6";
			this.hierarchicalSearchControlSimple6.NodeChecked = false;
			this.hierarchicalSearchControlSimple6.Size = new System.Drawing.Size(203, 43);
			this.hierarchicalSearchControlSimple6.TabIndex = 5;
			// 
			// hierarchicalSearchControlSimple7
			// 
			this.hierarchicalSearchControlSimple7.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple7.Location = new System.Drawing.Point(394, 48);
			this.hierarchicalSearchControlSimple7.Name = "hierarchicalSearchControlSimple7";
			this.hierarchicalSearchControlSimple7.NodeChecked = false;
			this.hierarchicalSearchControlSimple7.Size = new System.Drawing.Size(208, 43);
			this.hierarchicalSearchControlSimple7.TabIndex = 6;
			// 
			// hierarchicalSearchControlSimple8
			// 
			this.hierarchicalSearchControlSimple8.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlSimple8.Location = new System.Drawing.Point(592, 48);
			this.hierarchicalSearchControlSimple8.Name = "hierarchicalSearchControlSimple8";
			this.hierarchicalSearchControlSimple8.NodeChecked = false;
			this.hierarchicalSearchControlSimple8.Size = new System.Drawing.Size(199, 43);
			this.hierarchicalSearchControlSimple8.TabIndex = 7;
			// 
			// HierarchicalSearchControl
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.hierarchicalSearchControlSimple8);
			this.Controls.Add(this.hierarchicalSearchControlSimple4);
			this.Controls.Add(this.hierarchicalSearchControlSimple7);
			this.Controls.Add(this.hierarchicalSearchControlSimple3);
			this.Controls.Add(this.hierarchicalSearchControlSimple6);
			this.Controls.Add(this.hierarchicalSearchControlSimple2);
			this.Controls.Add(this.hierarchicalSearchControlSimple5);
			this.Controls.Add(this.hierarchicalSearchControlSimple1);
			this.Name = "HierarchicalSearchControl";
			this.Size = new System.Drawing.Size(792, 95);
			this.ResumeLayout(false);

		}
		#endregion

		private HierarchicalSearchControlController _uiController = null;
		private string _key = string.Empty;
		public event EventHandler OnSelected;
		

		private bool _allowMultipleSelect = false;
		public bool AllowMultipleSelect
		{
			get{return _allowMultipleSelect;}
		}

		public void SetCheckedKey(string Text, bool check)
		{
			if(hierarchicalSearchControlSimple1.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple1.NodeChecked = check;
			if(hierarchicalSearchControlSimple2.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple2.NodeChecked = check;
			if(hierarchicalSearchControlSimple3.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple3.NodeChecked = check;
			if(hierarchicalSearchControlSimple4.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple4.NodeChecked = check;
			if(hierarchicalSearchControlSimple5.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple5.NodeChecked = check;
			if(hierarchicalSearchControlSimple6.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple6.NodeChecked = check;
			if(hierarchicalSearchControlSimple7.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple7.NodeChecked = check;
			if(hierarchicalSearchControlSimple8.NodeDescription.Equals(Text)) hierarchicalSearchControlSimple8.NodeChecked = check;
		}


		public void SetSelectionKey(ArrayList jerarquias)
		{
			hierarchicalSearchControlSimple1.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple2.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple3.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple4.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple5.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple6.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple7.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple8.ItemsJerarquias.Clear();
			foreach (object item in jerarquias) 
			{
				ItemJerarquia it = (ItemJerarquia) item;
				string nodeKeyPath = it.NodeKeyPath;
				string selectedNodeKey = it.NodeKey;
				hierarchicalSearchControlSimple1.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple2.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple3.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple4.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple5.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple6.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple7.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple8.SetSelectionKey(nodeKeyPath, selectedNodeKey);
			}
			hierarchicalSearchControlSimple1.Selected();
			hierarchicalSearchControlSimple2.Selected();
			hierarchicalSearchControlSimple3.Selected();
			hierarchicalSearchControlSimple4.Selected();
			hierarchicalSearchControlSimple5.Selected();
			hierarchicalSearchControlSimple6.Selected();
			hierarchicalSearchControlSimple7.Selected();
			hierarchicalSearchControlSimple8.Selected();
		}

		public void SetSelectionKey(AbmProveedores.ProveedoresJearaquias jerarquias)
		{
			hierarchicalSearchControlSimple1.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple2.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple3.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple4.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple5.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple6.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple7.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple8.ItemsJerarquias.Clear();
			foreach(AbmProveedores.ProveedorJerarquia pj in jerarquias)
			{
				string nodeKeyPath = pj.Jerarquia;
				string selectedNodeKey = pj.IdNomenclatura;
				hierarchicalSearchControlSimple1.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple2.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple3.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple4.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple5.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple6.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple7.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple8.SetSelectionKey(nodeKeyPath, selectedNodeKey);
			}
			hierarchicalSearchControlSimple1.Selected();
			hierarchicalSearchControlSimple2.Selected();
			hierarchicalSearchControlSimple3.Selected();
			hierarchicalSearchControlSimple4.Selected();
			hierarchicalSearchControlSimple5.Selected();
			hierarchicalSearchControlSimple6.Selected();
			hierarchicalSearchControlSimple7.Selected();
			hierarchicalSearchControlSimple8.Selected();
		}

		public void SetSelectionKey(AbmCuentas.CuentasJearaquias jerarquias)
		{
			hierarchicalSearchControlSimple1.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple2.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple3.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple4.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple5.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple6.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple7.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple8.ItemsJerarquias.Clear();
			foreach(AbmCuentas.CuentaJerarquia cj in jerarquias)
			{
				string nodeKeyPath = cj.Jerarquia;
				string selectedNodeKey = cj.IdNomenclatura;
				hierarchicalSearchControlSimple1.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple2.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple3.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple4.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple5.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple6.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple7.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple8.SetSelectionKey(nodeKeyPath, selectedNodeKey);
			}
			hierarchicalSearchControlSimple1.Selected();
			hierarchicalSearchControlSimple2.Selected();
			hierarchicalSearchControlSimple3.Selected();
			hierarchicalSearchControlSimple4.Selected();
			hierarchicalSearchControlSimple5.Selected();
			hierarchicalSearchControlSimple6.Selected();
			hierarchicalSearchControlSimple7.Selected();
			hierarchicalSearchControlSimple8.Selected();
		}

		public void SetSelectionKey(tsh_ProductosEx.ProductosJearaquias jerarquias)
		{
			
			hierarchicalSearchControlSimple1.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple2.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple3.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple4.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple5.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple6.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple7.ItemsJerarquias.Clear();
			hierarchicalSearchControlSimple8.ItemsJerarquias.Clear();
			foreach(tsh_ProductosEx.ProductoJerarquia pj in jerarquias)
			{
				string nodeKeyPath = pj.Jerarquia;
				string selectedNodeKey = pj.IdNomenclatura;
				hierarchicalSearchControlSimple1.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple2.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple3.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple4.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple5.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple6.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple7.SetSelectionKey(nodeKeyPath, selectedNodeKey);
				hierarchicalSearchControlSimple8.SetSelectionKey(nodeKeyPath, selectedNodeKey);
			}
			hierarchicalSearchControlSimple1.Selected();
			hierarchicalSearchControlSimple2.Selected();
			hierarchicalSearchControlSimple3.Selected();
			hierarchicalSearchControlSimple4.Selected();
			hierarchicalSearchControlSimple5.Selected();
			hierarchicalSearchControlSimple6.Selected();
			hierarchicalSearchControlSimple7.Selected();
			hierarchicalSearchControlSimple8.Selected();
		}


		private void OnSelected1(object sender, System.EventArgs e)
		{
			
			_uiController.NodeChecked1 = hierarchicalSearchControlSimple1.NodeChecked;
			/*
			_uiController.NodeKey1 = hierarchicalSearchControlSimple1.NodeKey;	
			_uiController.NodeKey1Path = hierarchicalSearchControlSimple1.NodeKeyPath;
			
			*/
			_uiController.NodeDescription1 = hierarchicalSearchControlSimple1.NodeDescription;
			_uiController.ItemsJerarquia1 = hierarchicalSearchControlSimple1.ItemsJerarquias;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
			
		}
		private void OnSelected2(object sender, System.EventArgs e)
		{
			_uiController.NodeChecked2 = hierarchicalSearchControlSimple2.NodeChecked;
			/*
			_uiController.NodeKey2 = hierarchicalSearchControlSimple2.NodeKey;
			_uiController.NodeKey2Path = hierarchicalSearchControlSimple2.NodeKeyPath;
			
			*/
			_uiController.NodeDescription2 = hierarchicalSearchControlSimple2.NodeDescription;
			_uiController.ItemsJerarquia2 = hierarchicalSearchControlSimple2.ItemsJerarquias;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
		}
		private void OnSelected3(object sender, System.EventArgs e)
		{

			
			_uiController.NodeChecked3 = hierarchicalSearchControlSimple3.NodeChecked;
			/*
			_uiController.NodeKey3 = hierarchicalSearchControlSimple3.NodeKey;	
			_uiController.NodeKey3Path = hierarchicalSearchControlSimple3.NodeKeyPath;
			
			*/
			_uiController.ItemsJerarquia3 = hierarchicalSearchControlSimple3.ItemsJerarquias;
			_uiController.NodeDescription3 = hierarchicalSearchControlSimple3.NodeDescription;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
		}
		private void OnSelected4(object sender, System.EventArgs e)
		{
			_uiController.NodeChecked4 = hierarchicalSearchControlSimple4.NodeChecked;
			/*
			_uiController.NodeKey4 = hierarchicalSearchControlSimple4.NodeKey;
			_uiController.NodeKey4Path = hierarchicalSearchControlSimple4.NodeKeyPath;
			
			*/
			_uiController.ItemsJerarquia4 = hierarchicalSearchControlSimple4.ItemsJerarquias;
			_uiController.NodeDescription4 = hierarchicalSearchControlSimple4.NodeDescription;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
		}
		private void OnSelected5(object sender, System.EventArgs e)
		{
			_uiController.NodeChecked5 = hierarchicalSearchControlSimple5.NodeChecked;
			/*
			_uiController.NodeKey5 = hierarchicalSearchControlSimple5.NodeKey;	
			_uiController.NodeKey5Path = hierarchicalSearchControlSimple5.NodeKeyPath;
			
			*/
			_uiController.NodeDescription5 = hierarchicalSearchControlSimple5.NodeDescription;
			_uiController.ItemsJerarquia5 = hierarchicalSearchControlSimple5.ItemsJerarquias;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
		}
		private void OnSelected6(object sender, System.EventArgs e)
		{
			_uiController.NodeChecked6 = hierarchicalSearchControlSimple6.NodeChecked;
			_uiController.NodeDescription6 = hierarchicalSearchControlSimple6.NodeDescription;
			_uiController.ItemsJerarquia6 = hierarchicalSearchControlSimple6.ItemsJerarquias;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
		}
		private void OnSelected7(object sender, System.EventArgs e)
		{
			_uiController.NodeChecked7 = hierarchicalSearchControlSimple7.NodeChecked;
			_uiController.NodeDescription7 = hierarchicalSearchControlSimple7.NodeDescription;
			_uiController.ItemsJerarquia7 = hierarchicalSearchControlSimple7.ItemsJerarquias;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
		}
		private void OnSelected8(object sender, System.EventArgs e)
		{
			_uiController.NodeChecked8 = hierarchicalSearchControlSimple8.NodeChecked;
			_uiController.NodeDescription8 = hierarchicalSearchControlSimple8.NodeDescription;
			_uiController.ItemsJerarquia8 = hierarchicalSearchControlSimple8.ItemsJerarquias;
			if(OnSelected!= null)
				OnSelected(this, new EventArgs());
		}

		public string NodeDescripcion1
		{
			get{return _uiController.NodeDescription1;}
		}

		public string NodeDescripcion2
		{
			get{return _uiController.NodeDescription2;}
		}

		public string NodeDescripcion3
		{
			get{return _uiController.NodeDescription3;}
		}
		public string NodeDescripcion4
		{
			get{return _uiController.NodeDescription4;}
		}
		public string NodeDescripcion5
		{
			get{return _uiController.NodeDescription5;}
		}
		public string NodeDescripcion6
		{
			get{return _uiController.NodeDescription6;}
		}
		public string NodeDescripcion7
		{
			get{return _uiController.NodeDescription7;}
		}
		public string NodeDescripcion8
		{
			get{return _uiController.NodeDescription8;}
		}				

		public bool NodeChecked1
		{
			get { return _uiController.NodeChecked1; }		
			set 
			{				
				hierarchicalSearchControlSimple1.NodeChecked = value;
			}
			
		}	
		public bool NodeChecked2
		{
			get { return _uiController.NodeChecked2; }		
			set 
			{				
				hierarchicalSearchControlSimple2.NodeChecked = value;
			}
		}	
		public bool NodeChecked3
		{
			get { return _uiController.NodeChecked3; }	
			set 
			{				
				hierarchicalSearchControlSimple3.NodeChecked = value;
			}
		}	
		public bool NodeChecked4
		{
			get { return _uiController.NodeChecked4; }		
			set 
			{				
				hierarchicalSearchControlSimple4.NodeChecked = value;
			}
		}	
		public bool NodeChecked5
		{
			get { return _uiController.NodeChecked5; }
			set 
			{				
				hierarchicalSearchControlSimple5.NodeChecked = value;
			}
		}	
		public bool NodeChecked6
		{
			get { return _uiController.NodeChecked6; }	
			set 
			{				
				hierarchicalSearchControlSimple6.NodeChecked = value;
			}
		}	
		public bool NodeChecked7
		{
			get { return _uiController.NodeChecked7; }	
			set 
			{				
				hierarchicalSearchControlSimple7.NodeChecked = value;
			}
		}	
		public bool NodeChecked8
		{
			get { return _uiController.NodeChecked8; }	
			set 
			{				
				hierarchicalSearchControlSimple8.NodeChecked = value;
			}
		}	

		public void ItemsJerarquia1Focus()
		{
			hierarchicalSearchControlSimple1.Focus();
		}	

		public void ItemsJerarquia2Focus()
		{
			hierarchicalSearchControlSimple2.Focus();
		}	
		
		public void ItemsJerarquia3Focus()
		{
			hierarchicalSearchControlSimple3.Focus();
		}	

		public void ItemsJerarquia4Focus()
		{
			hierarchicalSearchControlSimple4.Focus();
		}	
		public void ItemsJerarquia5Focus()
		{
			hierarchicalSearchControlSimple5.Focus();
		}	

		public void ItemsJerarquia6Focus()
		{
			hierarchicalSearchControlSimple6.Focus();
		}	

		public void ItemsJerarquia7Focus()
		{
			hierarchicalSearchControlSimple7.Focus();
		}	

		public void ItemsJerarquia8Focus()
		{
			hierarchicalSearchControlSimple8.Focus();
		}	


		public ArrayList ItemsJerarquia1
		{
			get{return _uiController.ItemsJerarquia1;}
		}
		public ArrayList ItemsJerarquia2
		{
			get{return _uiController.ItemsJerarquia2;}

		}
		public ArrayList ItemsJerarquia3
		{
			get{return _uiController.ItemsJerarquia3;}
		}
		public ArrayList ItemsJerarquia4
		{
			get{return _uiController.ItemsJerarquia4;}
		}
		public ArrayList ItemsJerarquia5
		{
			get{return _uiController.ItemsJerarquia5;}
		}
		public ArrayList ItemsJerarquia6
		{
			get{return _uiController.ItemsJerarquia6;}
		}
		public ArrayList ItemsJerarquia7
		{
			get{return _uiController.ItemsJerarquia7;}
		}
		public ArrayList ItemsJerarquia8
		{
			get{return _uiController.ItemsJerarquia8;}
		}
	
	
		public ArrayList GetKeyPathList(string Descripction)
		{
			if(hierarchicalSearchControlSimple1.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple1.ItemsJerarquias;
			if(hierarchicalSearchControlSimple2.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple2.ItemsJerarquias;
			if(hierarchicalSearchControlSimple3.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple3.ItemsJerarquias;
			if(hierarchicalSearchControlSimple4.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple4.ItemsJerarquias;
			if(hierarchicalSearchControlSimple5.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple5.ItemsJerarquias;
			if(hierarchicalSearchControlSimple6.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple6.ItemsJerarquias;
			if(hierarchicalSearchControlSimple7.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple7.ItemsJerarquias;
			if(hierarchicalSearchControlSimple8.ContainsDescription(Descripction))
				return hierarchicalSearchControlSimple8.ItemsJerarquias;
			return new ArrayList();
		}

		public void ClearSelectedNodes()
		{
			this.NodeChecked1 = false;
			this.NodeChecked2 = false;
			this.NodeChecked3 = false;
			this.NodeChecked4 = false;
			this.NodeChecked5 = false;
			this.NodeChecked6 = false;
			this.NodeChecked7 = false;
			this.NodeChecked8 = false;
			this.hierarchicalSearchControlSimple1.ClearControl();
			this.hierarchicalSearchControlSimple2.ClearControl();
			this.hierarchicalSearchControlSimple3.ClearControl();
			this.hierarchicalSearchControlSimple4.ClearControl();
			this.hierarchicalSearchControlSimple5.ClearControl();
			this.hierarchicalSearchControlSimple6.ClearControl();
			this.hierarchicalSearchControlSimple7.ClearControl();
			this.hierarchicalSearchControlSimple8.ClearControl();
			//this.NodeDescripcion1 = string.Empty;
		}
	}

}


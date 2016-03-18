using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.controllers;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de HierarchicalSearchControl.
	/// </summary>
	public class HierarchicalSearchControl : System.Windows.Forms.UserControl
	{
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple1;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple2;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple3;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple4;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple5;
		private mz.erp.ui.controls.HierarchicalSearchControlSimple hierarchicalSearchControlSimple6;
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HierarchicalSearchControl()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();	
			Build_UI();
				

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent

		}

		private void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();		
		}

		private void ConfigureInterface()
		{
			if(_uiController.IsValidKey1)
			{
				hierarchicalSearchControlSimple1.Root = _uiController.NodeKey1;
				hierarchicalSearchControlSimple1.Enabled = true;
			}
			else hierarchicalSearchControlSimple1.Enabled = false;
			if(_uiController.IsValidKey2)
			{
				hierarchicalSearchControlSimple2.Root = _uiController.NodeKey2;
				hierarchicalSearchControlSimple2.Enabled = true;
			}
			else hierarchicalSearchControlSimple2.Enabled = false;
			if(_uiController.IsValidKey3)
			{
				hierarchicalSearchControlSimple3.Root = _uiController.NodeKey3;
				hierarchicalSearchControlSimple3.Enabled = true;
			}
            else hierarchicalSearchControlSimple3.Enabled = false;
			if(_uiController.IsValidKey4)
			{
				hierarchicalSearchControlSimple4.Root = _uiController.NodeKey4;
				hierarchicalSearchControlSimple4.Enabled = true;
			}
			else hierarchicalSearchControlSimple4.Enabled = false;
			if(_uiController.IsValidKey5)
			{
				hierarchicalSearchControlSimple5.Root = _uiController.NodeKey5;
				hierarchicalSearchControlSimple5.Enabled = true;
			}
			else hierarchicalSearchControlSimple5.Enabled = false;
			if(_uiController.IsValidKey6)
			{
				hierarchicalSearchControlSimple6.Root = _uiController.NodeKey6;
				hierarchicalSearchControlSimple6.Enabled = true;
			}
			else hierarchicalSearchControlSimple6.Enabled = false;
		
		}
		private void InitializeData(){}
		private void InitEventHandlers(){}
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
			this.hierarchicalSearchControlSimple3 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple4 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple5 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.hierarchicalSearchControlSimple6 = new mz.erp.ui.controls.HierarchicalSearchControlSimple();
			this.SuspendLayout();
			// 
			// hierarchicalSearchControlSimple1
			// 
			this.hierarchicalSearchControlSimple1.Location = new System.Drawing.Point(0, 2);
			this.hierarchicalSearchControlSimple1.Name = "hierarchicalSearchControlSimple1";
			this.hierarchicalSearchControlSimple1.Size = new System.Drawing.Size(208, 43);
			this.hierarchicalSearchControlSimple1.TabIndex = 0;
			// 
			// hierarchicalSearchControlSimple2
			// 
			this.hierarchicalSearchControlSimple2.Location = new System.Drawing.Point(208, 2);
			this.hierarchicalSearchControlSimple2.Name = "hierarchicalSearchControlSimple2";
			this.hierarchicalSearchControlSimple2.Size = new System.Drawing.Size(208, 43);
			this.hierarchicalSearchControlSimple2.TabIndex = 1;
			// 
			// hierarchicalSearchControlSimple3
			// 
			this.hierarchicalSearchControlSimple3.Location = new System.Drawing.Point(624, 2);
			this.hierarchicalSearchControlSimple3.Name = "hierarchicalSearchControlSimple3";
			this.hierarchicalSearchControlSimple3.Size = new System.Drawing.Size(208, 43);
			this.hierarchicalSearchControlSimple3.TabIndex = 2;
			// 
			// hierarchicalSearchControlSimple4
			// 
			this.hierarchicalSearchControlSimple4.Location = new System.Drawing.Point(832, 2);
			this.hierarchicalSearchControlSimple4.Name = "hierarchicalSearchControlSimple4";
			this.hierarchicalSearchControlSimple4.Size = new System.Drawing.Size(208, 43);
			this.hierarchicalSearchControlSimple4.TabIndex = 3;
			// 
			// hierarchicalSearchControlSimple5
			// 
			this.hierarchicalSearchControlSimple5.Location = new System.Drawing.Point(416, 2);
			this.hierarchicalSearchControlSimple5.Name = "hierarchicalSearchControlSimple5";
			this.hierarchicalSearchControlSimple5.Size = new System.Drawing.Size(208, 43);
			this.hierarchicalSearchControlSimple5.TabIndex = 5;
			// 
			// hierarchicalSearchControlSimple6
			// 
			this.hierarchicalSearchControlSimple6.Location = new System.Drawing.Point(416, 56);
			this.hierarchicalSearchControlSimple6.Name = "hierarchicalSearchControlSimple6";
			this.hierarchicalSearchControlSimple6.Size = new System.Drawing.Size(208, 43);
			this.hierarchicalSearchControlSimple6.TabIndex = 4;
			// 
			// HierarchicalSearchControl
			// 
			this.Controls.Add(this.hierarchicalSearchControlSimple5);
			this.Controls.Add(this.hierarchicalSearchControlSimple6);
			this.Controls.Add(this.hierarchicalSearchControlSimple4);
			this.Controls.Add(this.hierarchicalSearchControlSimple3);
			this.Controls.Add(this.hierarchicalSearchControlSimple2);
			this.Controls.Add(this.hierarchicalSearchControlSimple1);
			this.Name = "HierarchicalSearchControl";
			this.Size = new System.Drawing.Size(952, 48);
			this.ResumeLayout(false);

		}
		#endregion

		private HierarchicalSearchControlController _uiController = new HierarchicalSearchControlController();

		private void OnSelected1(object sender, System.EventArgs e)
		{
			_uiController.NodeKey1 = hierarchicalSearchControlSimple1.NodeKey;	
			_uiController.NodeChecked1 = hierarchicalSearchControlSimple1.NodeChecked;
		}
		private void OnSelected2(object sender, System.EventArgs e)
		{
			_uiController.NodeKey2 = hierarchicalSearchControlSimple2.NodeKey;
		}
		private void OnSelected3(object sender, System.EventArgs e)
		{
			_uiController.NodeKey3 = hierarchicalSearchControlSimple3.NodeKey;	
		}
		private void OnSelected4(object sender, System.EventArgs e)
		{
			_uiController.NodeKey4 = hierarchicalSearchControlSimple4.NodeKey;
		}
		private void OnSelected5(object sender, System.EventArgs e)
		{
			_uiController.NodeKey5 = hierarchicalSearchControlSimple5.NodeKey;	
		}
		private void OnSelected6(object sender, System.EventArgs e)
		{
			_uiController.NodeKey6 = hierarchicalSearchControlSimple6.NodeKey;
		}

		
		public string  NodeKey1 
		{
			get { return _uiController.NodeKey1; }
		
		}
		
		public bool NodeChecked1
		{
			get { return _uiController.NodeChecked1; }
		
		}	
		
		public string  NodeKey2 
		{
			get { return _uiController.NodeKey2; }
		
		}
		
		public bool NodeChecked2
		{
			get { return _uiController.NodeChecked2; }
		
		}	
		
		public string  NodeKey3
		{
			get { return _uiController.NodeKey3; }
		
		}
		
		public bool NodeChecked3
		{
			get { return _uiController.NodeChecked3; }
		
		}	
		
		public string  NodeKey4
		{
			get { return _uiController.NodeKey4; }
		
		}
		
		public bool NodeChecked4
		{
			get { return _uiController.NodeChecked4; }
		
		}	
		
		public string  NodeKey5
		{
			get { return _uiController.NodeKey5; }
			
		}
		
		public bool NodeChecked5
		{
			get { return _uiController.NodeChecked5; }
			
		}	
		
		public string  NodeKey6
		{
			get { return _uiController.NodeKey6; }
			
		}
	
		public bool NodeChecked6
		{
			get { return _uiController.NodeChecked6; }
			
		}	
	}

}

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de HierarchicalControl.
	/// </summary>
	public class HierarchicalSearchControlSimple : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public HierarchicalSearchControlSimple()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();
			this.utbJerarquia.Click +=new EventHandler(utbJerarquia_Click);
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtNombreJerarquia = new System.Windows.Forms.TextBox();
			this.chkJerarquia = new System.Windows.Forms.CheckBox();
			this.utbJerarquia = new Infragistics.Win.Misc.UltraButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtNombreJerarquia);
			this.panel1.Controls.Add(this.chkJerarquia);
			this.panel1.Controls.Add(this.utbJerarquia);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(210, 43);
			this.panel1.TabIndex = 0;
			// 
			// txtNombreJerarquia
			// 
			this.txtNombreJerarquia.Enabled = false;
			this.txtNombreJerarquia.Location = new System.Drawing.Point(30, 19);
			this.txtNombreJerarquia.Name = "txtNombreJerarquia";
			this.txtNombreJerarquia.Size = new System.Drawing.Size(176, 20);
			this.txtNombreJerarquia.TabIndex = 9;
			this.txtNombreJerarquia.Text = "";
			// 
			// chkJerarquia
			// 
			this.chkJerarquia.BackColor = System.Drawing.Color.Transparent;
			this.chkJerarquia.Location = new System.Drawing.Point(6, 1);
			this.chkJerarquia.Name = "chkJerarquia";
			this.chkJerarquia.Size = new System.Drawing.Size(196, 16);
			this.chkJerarquia.TabIndex = 8;
			this.chkJerarquia.Text = "Por Jerarquia";
			// 
			// utbJerarquia
			// 
			this.utbJerarquia.Location = new System.Drawing.Point(2, 16);
			this.utbJerarquia.Name = "utbJerarquia";
			this.utbJerarquia.Size = new System.Drawing.Size(27, 23);
			this.utbJerarquia.TabIndex = 7;
			this.utbJerarquia.Text = "...";
			// 
			// HierarchicalSearchControlSimple
			// 
			this.Controls.Add(this.panel1);
			this.Name = "HierarchicalSearchControlSimple";
			this.Size = new System.Drawing.Size(210, 43);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public string Root
		{
			set
			{
				_rootKey = value;
				_nodeKey = value;
				DataRow row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_rootKey);
				if(row != null)
					this.chkJerarquia.Text ="Por " + Convert.ToString(row["Descripcion"]);
			}
		}
		
		#region Propiedades
		private string _rootKey = string.Empty;
		private string _descriptionKey = string.Empty;
		private string _nodeKey = string.Empty;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtNombreJerarquia;
		private System.Windows.Forms.CheckBox chkJerarquia;
		private Infragistics.Win.Misc.UltraButton utbJerarquia;
	
		public string  NodeKey 
		{
			get { return _nodeKey; }
		}		
		private bool _nodeChecked = false;
		public bool  NodeChecked
		{
			get { return _nodeChecked; }
		}		
		#endregion
		private void chkJerarquia_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkJerarquia.Checked)
			{
				this.utbJerarquia.Enabled = true;				
			}				
			else 
			{				
				if (OnSelected != null)
					OnSelected( this , new System.EventArgs());
			}
			_nodeChecked = chkJerarquia.Checked;
		}
		private void utbJerarquia_Click(object sender, System.EventArgs e)
		{
			forms.frmSeleccionJerarquia form = new mz.erp.ui.forms.frmSeleccionJerarquia(_rootKey, _nodeKey);
			form.ShowDialog();
			if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				_nodeKey = form.NodeKey;
				txtNombreJerarquia.Text = form.NodeDescripcion;
				this.chkJerarquia.Checked = true;				
				if (OnSelected != null)
					OnSelected( this , new System.EventArgs());
			}			            		
		}
		public System.EventHandler OnSelected;
	}
}

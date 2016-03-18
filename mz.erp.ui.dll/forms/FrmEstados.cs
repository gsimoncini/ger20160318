using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmEstados.
	/// </summary>
	public class FrmEstados : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmEstados()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			listBox1.Items.Clear();

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
						this.listBox1 = new System.Windows.Forms.ListBox();
						this.SuspendLayout();
						// 
						// listBox1
						// 
						this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
						this.listBox1.Location = new System.Drawing.Point(0, 0);
						this.listBox1.Name = "listBox1";
						this.listBox1.Size = new System.Drawing.Size(304, 446);
						this.listBox1.TabIndex = 1;
						// 
						// FrmEstados
						// 
						this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
						this.ClientSize = new System.Drawing.Size(304, 453);
						this.Controls.Add(this.listBox1);
						this.Name = "FrmEstados";
						this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
						this.Text = "Pantalla de visualización de estados";
			this.ResumeLayout(false);

		}
		#endregion

		public void CargarUltimoEstado(string estado) 
		{
			listBox1.Items.Add(estado);
		}

		public void CargarEstados(ArrayList estados) 
		{
			listBox1.Items.Clear();
			foreach( string s in estados )
			{
				listBox1.Items.Add( s );
			}								
		}
	}
}

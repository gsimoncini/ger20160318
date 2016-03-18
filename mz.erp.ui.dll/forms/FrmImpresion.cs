using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers.reportes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmImpresion.
	/// </summary>
	public class FrmImpresion : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmImpresion()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 96);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmImpresion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(408, 302);
			this.Controls.Add(this.button1);
			this.Name = "FrmImpresion";
			this.Text = "FrmImpresion";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			OrdenDePreparado odp = new OrdenDePreparado();
			odp.Print();			
		}
	}
}

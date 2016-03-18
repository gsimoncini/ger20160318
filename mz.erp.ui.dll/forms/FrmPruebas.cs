using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmPruebas.
	/// </summary>
	public class FrmPruebas : System.Windows.Forms.Form
	{
		private mz.erp.ui.controls.mzSearchPanel mzSearchPanel1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPruebas()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			mzSearchPanel1.SearchObject = typeof( tsh_Personas );
			//mzSearchPanel1.SelectedValue;

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
			this.mzSearchPanel1 = new mz.erp.ui.controls.mzSearchPanel();
			this.SuspendLayout();
			// 
			// mzSearchPanel1
			// 
			this.mzSearchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mzSearchPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzSearchPanel1.Location = new System.Drawing.Point(0, 0);
			this.mzSearchPanel1.Name = "mzSearchPanel1";
			this.mzSearchPanel1.SearchObject = null;
			this.mzSearchPanel1.Size = new System.Drawing.Size(768, 373);
			this.mzSearchPanel1.TabIndex = 0;
			// 
			// FrmPruebas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(768, 373);
			this.Controls.Add(this.mzSearchPanel1);
			this.Name = "FrmPruebas";
			this.Text = "FrmPruebas";
			this.ResumeLayout(false);

		}
		#endregion
	}
}

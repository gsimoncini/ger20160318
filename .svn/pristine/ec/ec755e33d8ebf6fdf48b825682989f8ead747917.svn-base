using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class FrmMostrarErrores : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lstbxErrores;
		private System.Windows.Forms.Button bAceptar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		
		public FrmMostrarErrores(System.Collections.ArrayList listaDeErrores)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			if (listaDeErrores != null) 
			{
				for (int i = 0; i < listaDeErrores.Count; i++)
				{
					lstbxErrores.Items.Add(listaDeErrores[i]);
				}

			}
			
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
			this.lstbxErrores = new System.Windows.Forms.ListBox();
			this.bAceptar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstbxmz.erp.ui.forms.classes.Errores
			// 
			this.lstbxErrores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lstbxErrores.Location = new System.Drawing.Point(16, 40);
			this.lstbxErrores.Name = "lstbxmz.erp.ui.forms.classes.Errores";
			this.lstbxErrores.Size = new System.Drawing.Size(328, 225);
			this.lstbxErrores.TabIndex = 0;
			this.lstbxErrores.DoubleClick += new System.EventHandler(this.lstbxErrores_DoubleClick);
			// 
			// bAceptar
			// 
			this.bAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.bAceptar.Location = new System.Drawing.Point(148, 336);
			this.bAceptar.Name = "bAceptar";
			this.bAceptar.TabIndex = 1;
			this.bAceptar.Text = "&Aceptar";
			this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Se han detectado los siguientes problemas";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(24, 280);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(320, 48);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// FrmMostrarmz.erp.ui.forms.classes.Errores
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 373);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bAceptar);
			this.Controls.Add(this.lstbxErrores);
			this.Name = "FrmMostrarErrores";
			this.Text = "Error";
			this.ResumeLayout(false);

		}
		#endregion

		private void bAceptar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void lstbxErrores_DoubleClick(object sender, System.EventArgs e)
		{
			label2.Text = lstbxErrores.Items[ lstbxErrores.SelectedIndex ].ToString();
		}
	}
}

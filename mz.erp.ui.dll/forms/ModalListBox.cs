using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de ModalListBox.
	/// </summary>
	public class ModalListBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listbox;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

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


		private bool _continuar = true;
		public bool Continuar  
		{
			get 
			{
				return _continuar;
			}		
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.listbox = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listbox
			// 
			this.listbox.Location = new System.Drawing.Point(16, 57);
			this.listbox.Name = "listbox";
			this.listbox.Size = new System.Drawing.Size(256, 108);
			this.listbox.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 174);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 26);
			this.button1.TabIndex = 1;
			this.button1.Text = "&Aceptar";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "La operación que intenta realizar solicita que seleccione entre estos posibles va" +
				"lores para continuar su ejecución";
			// 
			// ModalListBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 205);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listbox);
			this.Name = "ModalListBox";
			this.Text = "Seleccione los items disponibles";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.ModalListBox_Closing);
			this.Closed += new System.EventHandler(this.ModalListBox_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Members
		public ModalListBox( object[] lista )
		{
			InitializeComponent();
			listbox.Items.AddRange( lista );
			
		}
		public object SelectedItem()
		{
			return listbox.SelectedItem;
		}
		public void ShowModal()
		{
			/*if (listbox.Items.Count == 0)
			{
				MessageBox.Show("No hay acciones posibles para efectuar");
			}
			else
			{
				if (listbox.Items.Count == 1)
				{
					listbox.SelectedItem = 0;
				}
				else
				{*/
					this.ShowDialog();
			/*	}
			}*/
				
		}

		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void ModalListBox_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{		
		}

		private void ModalListBox_Closed(object sender, System.EventArgs e)
		{
			if (listbox.SelectedItem == null) 
			{
				_continuar = false;
			}			
		}
	}
}

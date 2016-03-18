//German 20110328 - Tarea 0000057
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmShowWarnings.
	/// </summary>
	public class FrmShowWarnings : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Button Aceptar;
		private System.Windows.Forms.Button Cancelar;
		private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private HtmlRichText.HtmlRichTextBox txtWarnings;
		private System.ComponentModel.IContainer components;

		public FrmShowWarnings()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowWarnings));
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWarnings = new HtmlRichText.HtmlRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Aceptar.Location = new System.Drawing.Point(312, 241);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(80, 24);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Location = new System.Drawing.Point(400, 241);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(80, 24);
            this.Cancelar.TabIndex = 2;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Se han proporcionado las siguientes Advertencias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Se proporcionan los siguientes detalles:";
            // 
            // txtWarnings
            // 
            this.txtWarnings.Location = new System.Drawing.Point(12, 85);
            this.txtWarnings.Name = "txtWarnings";
            this.txtWarnings.Size = new System.Drawing.Size(502, 150);
            this.txtWarnings.TabIndex = 7;
            this.txtWarnings.Text = "";
            // 
            // FrmShowWarnings
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(526, 282);
            this.Controls.Add(this.txtWarnings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowWarnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atención";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion



		public FrmShowWarnings( string _mensaje )
		{
			InitializeComponent();
			Init(_mensaje);
		}

		private void Init()
		{
		}

		private void pictureBox1_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		    this.Close();
		}

		private void mensaje_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}
		
		private void Init(string _mensaje)
		{
            //txtWarnings.Enabled = false;
            _mensaje = _mensaje + "<br>";
            _mensaje = "<b>* " + _mensaje + "<br><br>";
            txtWarnings.AddHTML(_mensaje);
		}

	}
}

//Fin German 20110328 - Tarea 0000057

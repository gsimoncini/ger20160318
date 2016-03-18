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
    /// Descripción breve de FrmShowErrors.
	/// </summary>
	public class FrmShowErrors : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button Aceptar;
		private System.Windows.Forms.PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private HtmlRichText.HtmlRichTextBox txtErrors;
		private System.ComponentModel.IContainer components;

		public FrmShowErrors()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowErrors));
            this.Aceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtErrors = new HtmlRichText.HtmlRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Aceptar.Location = new System.Drawing.Point(434, 241);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(80, 24);
            this.Aceptar.TabIndex = 1;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
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
            this.label1.Size = new System.Drawing.Size(414, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Se han proporcionado los siguientes Errores:";
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
            // txtErrors
            // 
            this.txtErrors.Location = new System.Drawing.Point(12, 85);
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.Size = new System.Drawing.Size(502, 150);
            this.txtErrors.TabIndex = 7;
            this.txtErrors.Text = "";
            // 
            // FrmShowErrors
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(526, 282);
            this.Controls.Add(this.txtErrors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowErrors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atención";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


    

        public FrmShowErrors(ItemsDatasetErrors errores )
		{
			InitializeComponent();
            Init(errores);
		}

        
        public FrmShowErrors(System.Data.DataRow row)
		{
			InitializeComponent();
            DatasetErrors errores = new mz.erp.businessrules.DatasetErrors(row);
			Init(errores);
		}


        public FrmShowErrors(System.Data.DataTable table)
		{
			InitializeComponent();
            DatasetErrors errores = new mz.erp.businessrules.DatasetErrors(table);
            Init(errores);
		}

        public FrmShowErrors(System.Data.DataSet dataset)
		{
			InitializeComponent();
            DatasetErrors errores = new mz.erp.businessrules.DatasetErrors(dataset);
            Init(errores);
			
		}

		private void Init()
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

        private void Init(ItemsDatasetErrors errores)
		{

            //txtErrors.Enabled = false;
            string mensaje = string.Empty;

            mensaje = mensaje + "<br>";
            foreach (ItemDatasetError error in errores)
            {
                mensaje = mensaje + "<b>* " + error.Mensaje + "<br><br>";
                     
            }
            
            txtErrors.AddHTML(mensaje);
		}

        private void Init(DatasetErrors errores)
        {

            //txtErrors.Enabled = false;
            string mensaje = string.Empty;

            mensaje = mensaje + "<br>";
            foreach (ItemDatasetError error in errores.DetailErrors)
            {
                mensaje = mensaje + "<b>* " + error.Mensaje + "<br><br>"; //"Tabla: " + error.Tabla + " Campo: " + error.Campo + " Mensaje: " +

            }
            
            txtErrors.AddHTML(mensaje);
        }

        public void Show()

        {
            this.ShowDialog();
        }
        


	}
}

//Fin German 20110328 - Tarea 0000057

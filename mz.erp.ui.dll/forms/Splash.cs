using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Reflection;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de SplashForm.
	/// </summary>
	public class Splash : System.Windows.Forms.Form
	{
		private System.Timers.Timer timerClose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txtCompanyName;
		private System.Windows.Forms.Label txtApplicationName;
		private System.Windows.Forms.Label txtVersionNumber;
		private System.Windows.Forms.Label txtAdicionalText;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.ImageList imglStandar;
		private System.ComponentModel.IContainer components;

		public Splash()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Splash));
			this.timerClose = new System.Timers.Timer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCustomer = new System.Windows.Forms.TextBox();
			this.txtAdicionalText = new System.Windows.Forms.Label();
			this.txtVersionNumber = new System.Windows.Forms.Label();
			this.txtApplicationName = new System.Windows.Forms.Label();
			this.txtCompanyName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.timerClose)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timerClose
			// 
			this.timerClose.Enabled = true;
			this.timerClose.Interval = 3000;
			this.timerClose.SynchronizingObject = this;
			this.timerClose.Elapsed += new System.Timers.ElapsedEventHandler(this.timerClose_Elapsed);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCustomer);
			this.groupBox1.Controls.Add(this.txtAdicionalText);
			this.groupBox1.Controls.Add(this.txtVersionNumber);
			this.groupBox1.Controls.Add(this.txtApplicationName);
			this.groupBox1.Controls.Add(this.txtCompanyName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 286);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 130);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Producto";
			// 
			// txtCustomer
			// 
			this.txtCustomer.Enabled = false;
			this.txtCustomer.Location = new System.Drawing.Point(12, 84);
			this.txtCustomer.Multiline = true;
			this.txtCustomer.Name = "txtCustomer";
			this.txtCustomer.Size = new System.Drawing.Size(411, 36);
			this.txtCustomer.TabIndex = 7;
			this.txtCustomer.Text = "";
			// 
			// txtAdicionalText
			// 
			this.txtAdicionalText.Location = new System.Drawing.Point(12, 56);
			this.txtAdicionalText.Name = "txtAdicionalText";
			this.txtAdicionalText.Size = new System.Drawing.Size(413, 32);
			this.txtAdicionalText.TabIndex = 6;
			// 
			// txtVersionNumber
			// 
			this.txtVersionNumber.Location = new System.Drawing.Point(303, 21);
			this.txtVersionNumber.Name = "txtVersionNumber";
			this.txtVersionNumber.Size = new System.Drawing.Size(114, 16);
			this.txtVersionNumber.TabIndex = 5;
			// 
			// txtApplicationName
			// 
			this.txtApplicationName.Location = new System.Drawing.Point(12, 21);
			this.txtApplicationName.Name = "txtApplicationName";
			this.txtApplicationName.Size = new System.Drawing.Size(183, 16);
			this.txtApplicationName.TabIndex = 4;
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Location = new System.Drawing.Point(12, 37);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(346, 16);
			this.txtCompanyName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(256, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Versión";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(16, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(432, 264);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// Splash
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(464, 448);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Splash";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MZ.ERP";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Splash_Load);
			((System.ComponentModel.ISupportInitialize)(this.timerClose)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void timerClose_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			this.Close();
		}

		private void Splash_Load(object sender, System.EventArgs e)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();
			cnx.Close();
			txtApplicationName.Text = Application.ProductName;
			txtCompanyName.Text = Application.CompanyName;
			txtVersionNumber.Text = Application.ProductVersion;
			txtAdicionalText.Text = "Copyright (c) 2005 - "+Application.CompanyName+ ". Se autoriza el uso de este producto bajo los terminos y condiciones estipulados en el contrato de licencia a ";
			txtCustomer.Text = mz.erp.businessrules.Variables.GetValueString("Sistema.NombreEmpresa") + "\r\n" +
				systemframework.ApplicationConfiguration.GetServidor() + " " + systemframework.ApplicationConfiguration.GetDatabase();	

		}
		public void ShowModal()
		{
			timerClose.Enabled=false;
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.ShowDialog();
			
		}

		private void btnCerrar_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}

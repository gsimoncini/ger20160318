using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.forms;
using mz.erp.ui.controls;
using System.IO;
using Excel;
using System.Drawing.Printing;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de frmConnectionString.
	/// </summary>
	public class frmConnectionString : System.Windows.Forms.Form
	{
		private mz.erp.ui.controls.mzComboSearchEditor mzComboSearchEditor1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtConexionEncriptada;
		private System.Windows.Forms.TextBox txtConexion;
		private System.Windows.Forms.ListBox listBoxImpresorasInstaladas;
		private System.Windows.Forms.TextBox txtImpresora;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private Infragistics.Win.Misc.UltraButton utbConvertir;
		private System.Windows.Forms.TextBox textBox1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmConnectionString()
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtConexionEncriptada = new System.Windows.Forms.TextBox();
			this.txtConexion = new System.Windows.Forms.TextBox();
			this.listBoxImpresorasInstaladas = new System.Windows.Forms.ListBox();
			this.txtImpresora = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.utbConvertir = new Infragistics.Win.Misc.UltraButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Conexión encriptada:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Conexión:";
			// 
			// txtConexionEncriptada
			// 
			this.txtConexionEncriptada.Location = new System.Drawing.Point(128, 56);
			this.txtConexionEncriptada.Name = "txtConexionEncriptada";
			this.txtConexionEncriptada.Size = new System.Drawing.Size(744, 20);
			this.txtConexionEncriptada.TabIndex = 5;
			this.txtConexionEncriptada.Text = "";
			// 
			// txtConexion
			// 
			this.txtConexion.Location = new System.Drawing.Point(128, 24);
			this.txtConexion.Name = "txtConexion";
			this.txtConexion.Size = new System.Drawing.Size(744, 20);
			this.txtConexion.TabIndex = 4;
			this.txtConexion.Text = "";
			// 
			// listBoxImpresorasInstaladas
			// 
			this.listBoxImpresorasInstaladas.Location = new System.Drawing.Point(128, 104);
			this.listBoxImpresorasInstaladas.Name = "listBoxImpresorasInstaladas";
			this.listBoxImpresorasInstaladas.Size = new System.Drawing.Size(264, 264);
			this.listBoxImpresorasInstaladas.TabIndex = 8;
			// 
			// txtImpresora
			// 
			this.txtImpresora.Location = new System.Drawing.Point(400, 104);
			this.txtImpresora.Name = "txtImpresora";
			this.txtImpresora.Size = new System.Drawing.Size(472, 20);
			this.txtImpresora.TabIndex = 9;
			this.txtImpresora.Text = "textBox1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Impresoras Instaladas";
			// 
			// uneTotal
			// 
			this.uneTotal.Location = new System.Drawing.Point(400, 168);
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.Size = new System.Drawing.Size(96, 21);
			this.uneTotal.TabIndex = 11;
			this.uneTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// utbConvertir
			// 
			this.utbConvertir.Location = new System.Drawing.Point(504, 167);
			this.utbConvertir.Name = "utbConvertir";
			this.utbConvertir.Size = new System.Drawing.Size(120, 24);
			this.utbConvertir.TabIndex = 12;
			this.utbConvertir.Text = "Convertir a Texto";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(400, 192);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(472, 176);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "textBox1";
			// 
			// frmConnectionString
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(888, 454);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.utbConvertir);
			this.Controls.Add(this.uneTotal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtImpresora);
			this.Controls.Add(this.listBoxImpresorasInstaladas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtConexionEncriptada);
			this.Controls.Add(this.txtConexion);
			this.Name = "frmConnectionString";
			this.Text = "frmConnectionString";
			this.Load += new System.EventHandler(this.frmConnectionString_Load);
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmConnectionString_Load(object sender, System.EventArgs e)
		{
			this.txtConexion.Leave+=new EventHandler(txtConexion_Leave);
            //German 20110228 - Tarea 0000076
            this.txtConexionEncriptada.Leave += new EventHandler(txtConexionEncriptada_Leave);
            //Fin German 20110228 - Tarea 0000076
			utbConvertir.Click +=new EventHandler(utbConvertir_Click);
			CargarImpresorasInstaladas();
			listBoxImpresorasInstaladas.SelectedIndexChanged +=new EventHandler(listBoxImpresorasInstaladas_SelectedIndexChanged);
		}

        //German 20110228 - Tarea 0000076
        void txtConexionEncriptada_Leave(object sender, EventArgs e)
        {
            if (txtConexionEncriptada.Text.Trim() != "")
            {
                string connection = txtConexionEncriptada.Text;
                string desencriptada = new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64(connection);
                txtConexion.Text = desencriptada;
            }
        }
        //Fin German 20110228 - Tarea 0000076

        
		private void CargarImpresorasInstaladas()
		{
			string pkInstalledPrinters;
			for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
			{
				pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
				listBoxImpresorasInstaladas.Items.Add(pkInstalledPrinters);
			}

		}
		private void txtConexion_Leave(object sender, System.EventArgs e)
		{
			//string connection = "User ID=sa;password=03461441874;Initial Catalog=ErpPrincipalT1;Data Source=10.1.254.100";
			//string encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64( connection );					
            //MessageBox.Show(new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64( "I4lho3MHyFsPUahKcMcBUg=="));
            if (txtConexion.Text.Trim() != "")
			{
				string connection = txtConexion.Text;
				string encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64( connection );
				txtConexionEncriptada.Text = encriptada;
			}
		}

		private void listBoxImpresorasInstaladas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxImpresorasInstaladas.SelectedItems.Count > 0)
			{
				string pkInstalledPrinters;
				pkInstalledPrinters = Convert.ToString(listBoxImpresorasInstaladas.SelectedItem);
				txtImpresora.Text = pkInstalledPrinters;
                //German 20100713 - Tarea 793
                PrintDocument doc = new PrintDocument();
                doc.PrinterSettings.PrinterName = pkInstalledPrinters;
                string text = "Impresora: " + pkInstalledPrinters + " Bandejas: ";
                foreach (PaperSource ps in doc.PrinterSettings.PaperSources)
                {
                    text = text + ps.SourceName + ";";
                }
                txtImpresora.Text = text;
                //Fin German 20100713 - Tarea 793
				
			}
			else
				txtImpresora.Text = string.Empty;
		}

		private void utbConvertir_Click(object sender, EventArgs e)
		{
			textBox1.Text = NumberToText.NumberToWords(Convert.ToDecimal(uneTotal.Value),"Pesos");
		}
	}
}

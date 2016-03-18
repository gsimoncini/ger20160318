using System;
using System.Windows.Forms;

/// Código desarrollado por José Miguel Torres
/// jtorres_diaz@terra.es
/// Mayo 2004

namespace mz.erp.ui.forms.controls
{
	/// <summary>
	/// Clase equivalente InputBox de Visual Basic.
	/// </summary>
	/// <remarks>Devuelve DialogResult.OK en Aceptar o Intro.
	/// Devuelve DialogResult.Cancel en Cancelar o Escape.</remarks>

	public class InputBox : System.Windows.Forms.Form
	{

		#region "Atributos"

		private Infragistics.Win.Misc.UltraButton buttonCancel;
		private Infragistics.Win.Misc.UltraButton buttonOk;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtTexto;
		private System.Windows.Forms.Label lblInfo;
		private System.ComponentModel.Container components = null;
		#endregion

		#region "Constructor/InitializeComponent/Dispose"
		private InputBox()
		{
			InitializeComponent();
		}

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

		private void InitializeComponent()
		{
			this.buttonCancel = new Infragistics.Win.Misc.UltraButton();
			this.buttonOk = new Infragistics.Win.Misc.UltraButton();
			this.txtTexto = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.lblInfo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.txtTexto)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatMode = true;
			this.buttonCancel.Location = new System.Drawing.Point(184, 56);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 24);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "&Cancelar";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(88, 56);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(88, 24);
			this.buttonOk.TabIndex = 6;
			this.buttonOk.Text = "&Aceptar";
			// 
			// txtTexto
			// 
			this.txtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTexto.Location = new System.Drawing.Point(16, 24);
			this.txtTexto.Name = "txtTexto";
			this.txtTexto.Size = new System.Drawing.Size(256, 22);
			this.txtTexto.TabIndex = 0;
			this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
			// 
			// lblInfo
			// 
			this.lblInfo.BackColor = System.Drawing.Color.Transparent;
			this.lblInfo.Location = new System.Drawing.Point(16, 4);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(256, 23);
			this.lblInfo.TabIndex = 9;
			// 
			// InputBox
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(290, 88);
			this.ControlBox = false;
			this.Controls.Add(this.txtTexto);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.Load += new System.EventHandler(this.InputBox_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtTexto)).EndInit();
			this.ResumeLayout(false);

		}
 
		#endregion
 
		#region "Métodos privados"
		private void InputBox_Load(object sender, System.EventArgs e)
		{
			this.Width = 300;
			this.Height = 112;
		}
		private void textBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else if (e.KeyCode == Keys.Escape )
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}
		#endregion

		/// <summary>
		/// Ejecuta InputBox.
		/// </summary>
		/// <param name="prompt">Cadena de pregunta del InputBox.</param>
		/// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>

		public  static string ShowInputBox(string prompt)
		{
			InputBox box = new InputBox();
			box.Text = Application.ProductName;
			box.lblInfo.Text = prompt;
			box.txtTexto.Text = "";
			box.StartPosition =  FormStartPosition.CenterScreen;
			box.Height = 112;
			box.ShowDialog();

			if (box.DialogResult.CompareTo(DialogResult.OK) == 0)
				return box.txtTexto.Text;
			else
				return "";
		}
 
		/// <summary>
		/// Ejecuta InputBox.
		/// </summary>
		/// <param name="prompt">Cadena de pregunta del InputBox.</param>
		/// <param name="title">Titulo del InputBox.</param>		
		/// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>
		public  static string ShowInputBox(string prompt, string title)
		{
			InputBox box = new InputBox();
			box.Text = title;
			box.lblInfo.Text = prompt;
			box.txtTexto.Text = String.Empty;
			box.StartPosition =  FormStartPosition.CenterScreen;
			box.Height = 112;
			box.ShowDialog();

			if (box.DialogResult.CompareTo(DialogResult.OK) == 0)
				return box.txtTexto.Text;
			else
				return "";
		}    


		/// <summary>
		/// Ejecuta InputBox.
		/// </summary>
		/// <param name="prompt">Cadena de pregunta del InputBox.</param>
		/// <param name="title">Titulo del InputBox.</param>
		/// <param name="defaultValue">Valor por defecto en la casilla de entra de texto.</param>
		/// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>

		public  static string ShowInputBox(string prompt, string title, string defaultValue)
		{
			InputBox box = new InputBox();
			box.Text = title;			
			box.lblInfo.Text = prompt;
			box.txtTexto.Text = defaultValue;
			box.StartPosition =  FormStartPosition.CenterScreen;
			box.Height = 112;
			box.ShowDialog();

			if (box.DialogResult.CompareTo(DialogResult.OK) == 0)
				return box.txtTexto.Text;
			else
				return "";
		}          

		/// <summary>
		/// Ejecuta InputBox.
		/// </summary>
		/// <param name="prompt">Cadena de pregunta del InputBox.</param>
		/// <param name="title">Titulo del InputBox.</param>
		/// <param name="defaultValue">Valor por defecto en la casilla de entra de texto.</param>
		/// <param name="XPos">Posiciona el InputBox en la coordenada X horizontal.</param>
		/// <param name="YPos">Posiciona el InputBox en la coordenada Y vertical.</param>
		/// <returns>Devuelve cadena introducida por el usuario si DialgoResult es OK.</returns>

		public  static string ShowInputBox(string prompt, string title, string defaultValue, int XPos, int YPos)
		{
			InputBox box = new InputBox();
			box.Text = title;
			box.lblInfo.Text = prompt;
			box.txtTexto.Text = defaultValue;
			box.Location = new System.Drawing.Point(XPos,YPos);
			box.Height = 112;
			box.ShowDialog();

			if (box.DialogResult.CompareTo(DialogResult.OK) == 0)
				return box.txtTexto.Text;
			else
				return "";
		}
	}
}
 
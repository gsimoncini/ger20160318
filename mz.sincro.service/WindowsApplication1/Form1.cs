using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication1
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
			Infragistics.Win.UltraWinDataSource.UltraDataBand ultraDataBand1 = new Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1");
			Infragistics.Win.UltraWinDataSource.UltraDataBand ultraDataBand2 = new Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 0");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 1");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 2");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 0");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 1");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 2");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 0");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn8 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 1");
			Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn9 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Column 2");
			this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraDataSource1
			// 
			ultraDataBand2.Columns.AddRange(new object[] {
															 ultraDataColumn1,
															 ultraDataColumn2,
															 ultraDataColumn3});
			ultraDataBand1.ChildBands.AddRange(new object[] {
																ultraDataBand2});
			ultraDataBand1.Columns.AddRange(new object[] {
															 ultraDataColumn4,
															 ultraDataColumn5,
															 ultraDataColumn6});
			this.ultraDataSource1.Band.ChildBands.AddRange(new object[] {
																			ultraDataBand1});
			this.ultraDataSource1.Band.Columns.AddRange(new object[] {
																		 ultraDataColumn7,
																		 ultraDataColumn8,
																		 ultraDataColumn9});
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(112, 40);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(264, 160);
			this.listBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(408, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(296, 40);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(808, 273);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string[] s = new string[]{ "UNO", "DOS", "TRES" };
			listBox1.DataSource = s;
		
			string[] s1 = new string[]{ "UNO", "DOS", "TRES", "CUATRO" };
			listBox1.DataSource = s1;

			ArrayList a = new ArrayList();
			a.Add( "CINCO" );
			a.Add( "SEIS" );
			listBox1.DataSource = a;

		}
	}
}

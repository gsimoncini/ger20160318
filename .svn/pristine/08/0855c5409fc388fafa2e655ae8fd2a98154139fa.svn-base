using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.systemframework;
using mz.erp.businessrules;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmReporteImpuestos.
	/// </summary>
	public class FrmReporteImpuestos : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox rbImpInt;
		private Infragistics.Win.Misc.UltraButton ultraButton1;
		private System.Windows.Forms.ImageList imageList1;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteHasta;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteDesde;
		private System.Windows.Forms.CheckBox cbIVA;
		private System.Windows.Forms.CheckBox cbImpInt;
		private System.Windows.Forms.CheckBox cbIB;
		private System.Windows.Forms.CheckBox cbIVADIF;
		private System.ComponentModel.IContainer components;

		public FrmReporteImpuestos()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmReporteImpuestos));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.udteHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.udteDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.rbImpInt = new System.Windows.Forms.GroupBox();
			this.cbIVADIF = new System.Windows.Forms.CheckBox();
			this.cbIB = new System.Windows.Forms.CheckBox();
			this.cbImpInt = new System.Windows.Forms.CheckBox();
			this.cbIVA = new System.Windows.Forms.CheckBox();
			this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udteDesde)).BeginInit();
			this.rbImpInt.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.udteHasta);
			this.groupBox1.Controls.Add(this.udteDesde);
			this.groupBox1.Location = new System.Drawing.Point(8, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 144);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtros Temporales";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 88);
			this.label2.Name = "label2";
			this.label2.TabIndex = 5;
			this.label2.Text = "Fecha Hasta:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 4;
			this.label1.Text = "Fecha Desde:";
			// 
			// udteHasta
			// 
			this.udteHasta.Location = new System.Drawing.Point(8, 112);
			this.udteHasta.Name = "udteHasta";
			this.udteHasta.Size = new System.Drawing.Size(264, 21);
			this.udteHasta.TabIndex = 3;
			// 
			// udteDesde
			// 
			this.udteDesde.Location = new System.Drawing.Point(8, 56);
			this.udteDesde.Name = "udteDesde";
			this.udteDesde.Size = new System.Drawing.Size(264, 21);
			this.udteDesde.TabIndex = 2;
			// 
			// rbImpInt
			// 
			this.rbImpInt.Controls.Add(this.cbIVADIF);
			this.rbImpInt.Controls.Add(this.cbIB);
			this.rbImpInt.Controls.Add(this.cbImpInt);
			this.rbImpInt.Controls.Add(this.cbIVA);
			this.rbImpInt.Location = new System.Drawing.Point(8, 16);
			this.rbImpInt.Name = "rbImpInt";
			this.rbImpInt.Size = new System.Drawing.Size(280, 144);
			this.rbImpInt.TabIndex = 3;
			this.rbImpInt.TabStop = false;
			this.rbImpInt.Text = "Impuestos";
			// 
			// cbIVADIF
			// 
			this.cbIVADIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbIVADIF.Location = new System.Drawing.Point(16, 112);
			this.cbIVADIF.Name = "cbIVADIF";
			this.cbIVADIF.TabIndex = 3;
			this.cbIVADIF.Text = "IVADif";
			// 
			// cbIB
			// 
			this.cbIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbIB.Location = new System.Drawing.Point(16, 48);
			this.cbIB.Name = "cbIB";
			this.cbIB.Size = new System.Drawing.Size(216, 24);
			this.cbIB.TabIndex = 1;
			this.cbIB.Text = "Ingresos Brutos";
			// 
			// cbImpInt
			// 
			this.cbImpInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbImpInt.Location = new System.Drawing.Point(16, 80);
			this.cbImpInt.Name = "cbImpInt";
			this.cbImpInt.Size = new System.Drawing.Size(176, 24);
			this.cbImpInt.TabIndex = 2;
			this.cbImpInt.Text = "Impuestos Internos";
			this.cbImpInt.CheckedChanged += new System.EventHandler(this.cbImpInt_CheckedChanged);
			// 
			// cbIVA
			// 
			this.cbIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbIVA.Location = new System.Drawing.Point(16, 16);
			this.cbIVA.Name = "cbIVA";
			this.cbIVA.TabIndex = 0;
			this.cbIVA.Text = "IVA";
			// 
			// ultraButton1
			// 
			this.ultraButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraButton1.ImageList = this.imageList1;
			this.ultraButton1.ImageTransparentColor = System.Drawing.Color.Empty;
			this.ultraButton1.Location = new System.Drawing.Point(8, 168);
			this.ultraButton1.Name = "ultraButton1";
			this.ultraButton1.Size = new System.Drawing.Size(280, 40);
			this.ultraButton1.TabIndex = 4;
			this.ultraButton1.Text = "Ver Reporte";
			this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// FrmReporteImpuestos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 213);
			this.Controls.Add(this.ultraButton1);
			this.Controls.Add(this.rbImpInt);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmReporteImpuestos";
			this.Text = "FrmReporteImpuestos";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udteDesde)).EndInit();
			this.rbImpInt.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void ultraButton1_Click(object sender, System.EventArgs e)
		{
			DateTime fechaDesde = DateTime.MinValue;
			DateTime fechaHasta = DateTime.MinValue;
			if (!(udteDesde.Value == null)) fechaDesde = (DateTime)udteDesde.Value;
			if(!(udteHasta.Value == null)) fechaHasta = (DateTime)udteHasta.Value;
			ArrayList impuestos = new ArrayList();
			
			if (cbIVA.Checked)impuestos.Add("IVA");
			if (cbIVADIF.Checked)impuestos.Add("IVADIF");	
									
			if (cbIB.Checked) impuestos.Add(Variables.GetValueString("Impuestos.IB"));

            //German 20110602 - Tarea 0000149

            if (cbImpInt.Checked)
            {
                impuestos.Add(Variables.GetValueString("Impuestos.II") + "," + mz.erp.businessrules.tsy_Impuestos.GetListImpuestosInternosString());
                
            }
            //Fin German 20110602 - Tarea 0000149
			ReportsManager.PrintReportImpuestos(fechaDesde, fechaHasta,impuestos,this.MdiParent);
			
			
		}

		private void cbImpInt_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}

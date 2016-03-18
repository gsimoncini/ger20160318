using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.ui.controls;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmZonas.
	/// </summary>
	public class FrmAbmZonas : mz.erp.ui.forms.FrmAMB
	{
		private System.Windows.Forms.Label labelDescripcion;
		private System.Windows.Forms.Label labelValor1;
		private System.Windows.Forms.Label labelValor2;
		private System.Windows.Forms.Label labelValor3;
		private System.Windows.Forms.Label labelFormula;
		private System.Windows.Forms.TextBox descripcion;
		private System.Windows.Forms.TextBox valor1;
		private System.Windows.Forms.TextBox valor2;
		private System.Windows.Forms.TextBox valor3;
		private System.Windows.Forms.TextBox formula;
				
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmAbmZonas()
		{
			InitializeComponent();
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

	
		#region CustomMembers

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tlg_Zonas().GetType();
			base.Init();
		}
		protected override void InitializeMembers()
		{
			descripcion.MaxLength = 100;
		}

		protected override void FillControls()
		{

			if (_row != null)
			{
				descripcion.Text = (string)_row["Descripcion"];
				/*
				valor1.Text = (string)_row["Valor1"];
				valor2.Text = (string)_row["Valor2"];
				valor3.Text = (string)_row["Valor3"];
				formula.Text = (string)_row["Formula"];
				*/
			}
			else 
			{
			}
		}

		protected override void DumpControls()
		{
			_row["Descripcion"] = descripcion.Text;
			/*
			_row["Valor1"] = valor1.Text;
			_row["Valor2"] = valor2.Text;
			_row["Valor3"] = valor3.Text;
			_row["Formula"] = formula.Text;
			*/
		}

	
		#endregion		



		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelDescripcion = new System.Windows.Forms.Label();
			this.labelValor1 = new System.Windows.Forms.Label();
			this.labelValor2 = new System.Windows.Forms.Label();
			this.labelValor3 = new System.Windows.Forms.Label();
			this.labelFormula = new System.Windows.Forms.Label();
			this.descripcion = new System.Windows.Forms.TextBox();
			this.valor1 = new System.Windows.Forms.TextBox();
			this.valor2 = new System.Windows.Forms.TextBox();
			this.valor3 = new System.Windows.Forms.TextBox();
			this.formula = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.formula);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.valor3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.valor2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.valor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.descripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelFormula);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelValor3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelValor2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelValor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelDescripcion);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(871, 191);
			// 
			// labelDescripcion
			// 
			this.labelDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelDescripcion.Location = new System.Drawing.Point(24, 15);
			this.labelDescripcion.Name = "labelDescripcion";
			this.labelDescripcion.TabIndex = 0;
			this.labelDescripcion.Text = "Descripción";
			// 
			// labelValor1
			// 
			this.labelValor1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelValor1.Location = new System.Drawing.Point(24, 39);
			this.labelValor1.Name = "labelValor1";
			this.labelValor1.TabIndex = 1;
			this.labelValor1.Text = "Valor 1";
			this.labelValor1.Visible = false;
			// 
			// labelValor2
			// 
			this.labelValor2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelValor2.Location = new System.Drawing.Point(24, 64);
			this.labelValor2.Name = "labelValor2";
			this.labelValor2.TabIndex = 2;
			this.labelValor2.Text = "Valor 2";
			this.labelValor2.Visible = false;
			// 
			// labelValor3
			// 
			this.labelValor3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelValor3.Location = new System.Drawing.Point(24, 88);
			this.labelValor3.Name = "labelValor3";
			this.labelValor3.TabIndex = 3;
			this.labelValor3.Text = "Valor 3";
			this.labelValor3.Visible = false;
			// 
			// labelFormula
			// 
			this.labelFormula.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelFormula.Location = new System.Drawing.Point(24, 112);
			this.labelFormula.Name = "labelFormula";
			this.labelFormula.TabIndex = 4;
			this.labelFormula.Text = "Fórmula";
			this.labelFormula.Visible = false;
			// 
			// descripcion
			// 
			this.descripcion.Location = new System.Drawing.Point(136, 16);
			this.descripcion.Name = "descripcion";
			this.descripcion.Size = new System.Drawing.Size(424, 20);
			this.descripcion.TabIndex = 5;
			this.descripcion.Text = "";
			// 
			// valor1
			// 
			this.valor1.Location = new System.Drawing.Point(136, 40);
			this.valor1.Name = "valor1";
			this.valor1.Size = new System.Drawing.Size(424, 20);
			this.valor1.TabIndex = 6;
			this.valor1.Text = "";
			this.valor1.Visible = false;
			// 
			// valor2
			// 
			this.valor2.Location = new System.Drawing.Point(136, 64);
			this.valor2.Name = "valor2";
			this.valor2.Size = new System.Drawing.Size(424, 20);
			this.valor2.TabIndex = 7;
			this.valor2.Text = "";
			this.valor2.Visible = false;
			// 
			// valor3
			// 
			this.valor3.Location = new System.Drawing.Point(136, 88);
			this.valor3.Name = "valor3";
			this.valor3.Size = new System.Drawing.Size(424, 20);
			this.valor3.TabIndex = 8;
			this.valor3.Text = "";
			this.valor3.Visible = false;
			// 
			// formula
			// 
			this.formula.Location = new System.Drawing.Point(136, 112);
			this.formula.Name = "formula";
			this.formula.Size = new System.Drawing.Size(424, 20);
			this.formula.TabIndex = 9;
			this.formula.Text = "";
			this.formula.Visible = false;
			// 
			// FrmAbmZonas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 437);
			this.Name = "FrmAbmZonas";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmTransportes.
	/// </summary>
	public class FrmAbmTransportes:mz.erp.ui.forms.FrmAMB	
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboSearchEditor mzComboProveedor;
		private System.Windows.Forms.Label label4;
		private mz.erp.ui.controls.mzComboSearchEditor mzcomboResponsable;
		private System.Windows.Forms.TextBox descripcion;
		private System.Windows.Forms.TextBox valor2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox valor3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox formula;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor valor1;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmAbmTransportes()
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
																																	this.label1 = new System.Windows.Forms.Label();
																																	this.label2 = new System.Windows.Forms.Label();
																																	this.label3 = new System.Windows.Forms.Label();
																																	this.descripcion = new System.Windows.Forms.TextBox();
																																	this.mzComboProveedor = new mz.erp.ui.controls.mzComboSearchEditor();
																																	this.mzcomboResponsable = new mz.erp.ui.controls.mzComboSearchEditor();
																																	this.label4 = new System.Windows.Forms.Label();
																																	this.valor2 = new System.Windows.Forms.TextBox();
																																	this.label5 = new System.Windows.Forms.Label();
																																	this.valor3 = new System.Windows.Forms.TextBox();
																																	this.label6 = new System.Windows.Forms.Label();
																																	this.formula = new System.Windows.Forms.TextBox();
																																	this.label7 = new System.Windows.Forms.Label();
																																	this.valor1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																																	((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
																																	this.ultraExplorerBar1.SuspendLayout();
																																	this.ultraExplorerBarContainerControl1.SuspendLayout();
																																	((System.ComponentModel.ISupportInitialize)(this.valor1)).BeginInit();
																																	this.SuspendLayout();
																																	// 
																																	// ultraExplorerBar1
																																	// 
																																	this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
																																	this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
																																	this.ultraExplorerBar1.Margins.ForceSerialization = true;
																																	this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
																																	this.ultraExplorerBar1.Size = new System.Drawing.Size(712, 410);
																																	// 
																																	// ultraExplorerBarContainerControl1
																																	// 
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.valor1);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.formula);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.valor3);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.valor2);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.descripcion);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.mzcomboResponsable);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboProveedor);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
																																	this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
																																	this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
																																	this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(663, 111);
																																	// 
																																	// label1
																																	// 
																																	this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
																																	this.label1.Location = new System.Drawing.Point(24, 80);
																																	this.label1.Name = "label1";
																																	this.label1.TabIndex = 0;
																																	this.label1.Text = "Costo de flete";
																																	// 
																																	// label2
																																	// 
																																	this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
																																	this.label2.Location = new System.Drawing.Point(24, 56);
																																	this.label2.Name = "label2";
																																	this.label2.TabIndex = 1;
																																	this.label2.Text = "Proveedor";
																																	// 
																																	// label3
																																	// 
																																	this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
																																	this.label3.Location = new System.Drawing.Point(24, 8);
																																	this.label3.Name = "label3";
																																	this.label3.TabIndex = 2;
																																	this.label3.Text = "Descripción";
																																	// 
																																	// descripcion
																																	// 
																																	this.descripcion.Location = new System.Drawing.Point(128, 8);
																																	this.descripcion.Name = "descripcion";
																																	this.descripcion.Size = new System.Drawing.Size(496, 20);
																																	this.descripcion.TabIndex = 1;
																																	this.descripcion.Text = "";
																																	// 
																																	// mzComboProveedor
																																	// 
																																	this.mzComboProveedor.Cursor = System.Windows.Forms.Cursors.Default;
																																	this.mzComboProveedor.DataValue = "";
																																	this.mzComboProveedor.EditObject = null;
																																	this.mzComboProveedor.FastSearch = false;
																																	this.mzComboProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
																																	this.mzComboProveedor.HierarchicalSearch = false;
																																	this.mzComboProveedor.Location = new System.Drawing.Point(128, 56);
																																	this.mzComboProveedor.Name = "mzComboProveedor";
																																	this.mzComboProveedor.SearchObject = null;
																																	this.mzComboProveedor.SearchObjectListener = null;
																																	this.mzComboProveedor.Size = new System.Drawing.Size(496, 22);
																																	this.mzComboProveedor.TabIndex = 3;
																																	// 
																																	// mzcomboResponsable
																																	// 
																																	this.mzcomboResponsable.Cursor = System.Windows.Forms.Cursors.Default;
																																	this.mzcomboResponsable.DataValue = "";
																																	this.mzcomboResponsable.EditObject = null;
																																	this.mzcomboResponsable.FastSearch = false;
																																	this.mzcomboResponsable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
																																	this.mzcomboResponsable.HierarchicalSearch = false;
																																	this.mzcomboResponsable.Location = new System.Drawing.Point(128, 32);
																																	this.mzcomboResponsable.Name = "mzcomboResponsable";
																																	this.mzcomboResponsable.SearchObject = null;
																																	this.mzcomboResponsable.SearchObjectListener = null;
																																	this.mzcomboResponsable.Size = new System.Drawing.Size(496, 22);
																																	this.mzcomboResponsable.TabIndex = 2;
																																	// 
																																	// label4
																																	// 
																																	this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
																																	this.label4.Location = new System.Drawing.Point(24, 32);
																																	this.label4.Name = "label4";
																																	this.label4.TabIndex = 6;
																																	this.label4.Text = "Responsable";
																																	// 
																																	// valor2
																																	// 
																																	this.valor2.Location = new System.Drawing.Point(128, 128);
																																	this.valor2.Name = "valor2";
																																	this.valor2.Size = new System.Drawing.Size(264, 20);
																																	this.valor2.TabIndex = 9;
																																	this.valor2.Text = "";
																																	this.valor2.Visible = false;
																																	// 
																																	// label5
																																	// 
																																	this.label5.Location = new System.Drawing.Point(24, 128);
																																	this.label5.Name = "label5";
																																	this.label5.TabIndex = 8;
																																	this.label5.Text = "Valor 2";
																																	this.label5.Visible = false;
																																	// 
																																	// valor3
																																	// 
																																	this.valor3.Location = new System.Drawing.Point(128, 152);
																																	this.valor3.Name = "valor3";
																																	this.valor3.Size = new System.Drawing.Size(264, 20);
																																	this.valor3.TabIndex = 11;
																																	this.valor3.Text = "";
																																	this.valor3.Visible = false;
																																	// 
																																	// label6
																																	// 
																																	this.label6.Location = new System.Drawing.Point(24, 152);
																																	this.label6.Name = "label6";
																																	this.label6.TabIndex = 10;
																																	this.label6.Text = "Valor 3";
																																	this.label6.Visible = false;
																																	// 
																																	// formula
																																	// 
																																	this.formula.Location = new System.Drawing.Point(128, 176);
																																	this.formula.Name = "formula";
																																	this.formula.Size = new System.Drawing.Size(264, 20);
																																	this.formula.TabIndex = 13;
																																	this.formula.Text = "";
																																	this.formula.Visible = false;
																																	// 
																																	// label7
																																	// 
																																	this.label7.Location = new System.Drawing.Point(24, 176);
																																	this.label7.Name = "label7";
																																	this.label7.TabIndex = 12;
																																	this.label7.Text = "Fórmula";
																																	this.label7.Visible = false;
																																	// 
																																	// valor1
																																	// 
																																	this.valor1.Location = new System.Drawing.Point(128, 80);
																																	this.valor1.MinValue = 0;
																																	this.valor1.Name = "valor1";
																																	this.valor1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																																	this.valor1.Size = new System.Drawing.Size(100, 21);
																																	this.valor1.TabIndex = 4;
																																	// 
																																	// FrmAbmTransportes
																																	// 
																																	this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
																																	this.ClientSize = new System.Drawing.Size(712, 438);
																																	this.Name = "FrmAbmTransportes";
																																	this.Text = "FrmAbmTransportes";
																																	((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
																																	this.ultraExplorerBar1.ResumeLayout(false);
																																	this.ultraExplorerBarContainerControl1.ResumeLayout(false);
																																	((System.ComponentModel.ISupportInitialize)(this.valor1)).EndInit();
																																	this.ResumeLayout(false);

		}
		#endregion

	
	
		#region CustomMembers

		protected override void Init()
		{		
			_businessRulesType = new mz.erp.businessrules.tlg_Transportes().GetType();
			base.Init();
		}
		protected override void InitializeMembers()
		{
			descripcion.MaxLength = 255;
			mzcomboResponsable.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas);
			mzcomboResponsable.DataValue = Security.IdPersona;
			mzComboProveedor.SearchObject = typeof( mz.erp.ui.forms.classes.tpu_Proveedores);
		}

		protected override void FillControls() //se copian en la ventana todos los datos de la tabla
		{   
			if (_row != null)
			{
				descripcion.Text = Convert.ToString(_row["Descripcion"]);
				string idResp = Convert.ToString(_row["IdResponsable"]);
				if(idResp != null && idResp.Equals(string.Empty))
					mzcomboResponsable.DataValue = Security.IdPersona;
				else mzcomboResponsable.DataValue = idResp;
				mzComboProveedor.DataValue = Convert.ToString(_row["IdProveedor"]);
				valor1.Value = Convert.ToDecimal(_row["Valor1"]);
				valor2.Text =  Convert.ToString(_row["Valor2"]);
				valor3.Text =  Convert.ToString(_row["Valor3"]);
				formula.Text = Convert.ToString(_row["FormulaDeCalculo"]) ;

			}
			else 
			{ 

			}
			
		}

		protected override void DumpControls()//pone los datos de la ventana en la tabla
		{   
			//llama al save
			_row["Descripcion"] = this.descripcion.Text;
			_row["IdResponsable"] = mzcomboResponsable.DataValue;
			_row["IdProveedor"] = mzComboProveedor.DataValue;
			_row["Valor1"] = valor1.Value;
			_row["Valor2"] = valor2.Text;
			_row["Valor3"] = valor3.Text;
			_row["FormulaDeCalculo"] = formula.Text;
		}


			
		#endregion		
	
	}
}

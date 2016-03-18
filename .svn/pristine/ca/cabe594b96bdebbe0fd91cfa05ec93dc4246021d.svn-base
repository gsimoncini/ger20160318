using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using mz.erp.businessrules;
using mz.erp.ui;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;


namespace mz.erp.ui.forms
{
	public class FrmAbmJerarquiaAgrupGeneral : mz.erp.ui.forms.FrmAMB
	{
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.ComponentModel.IContainer components = null;
		private string _claveP = String.Empty;
		private string _claveH = String.Empty;
		private string _descripcion = String.Empty;
		private bool _activo = true;
		private System.Windows.Forms.CheckBox checkBox1;
        /* Silvina 20120420 - Tarea 0000294 */
        private Infragistics.Win.Misc.UltraLabel lComision;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor utnComision;
        /* Fin Silvina 20120420 - Tarea 0000294 */
		//private char _idTipoProducto;
		//private char _idTipoCuenta;
		private string _source = string.Empty;

		public FrmAbmJerarquiaAgrupGeneral()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
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

		#region CustomMembers

		protected override void Init()
		{
			switch(_source.ToUpper())
			{
				case "PRODUCTOS":
				{
					_businessRulesType = new mz.erp.businessrules.tsh_JerarquiaAgrupProd().GetType();
                    /* Silvina 20120420 - Tarea 0000294 */
                    utnComision.Visible = true;
                    lComision.Visible = true;
                    /* Fin Silvina 20120420 - Tarea 0000294 */
				}break;
				case "CUENTAS":
				{
					_businessRulesType = new mz.erp.businessrules.tsa_JerarquiaAgrupCuentas().GetType();
				}break;
				case "PROVEEDORES":
				{
					_businessRulesType = new mz.erp.businessrules.tpu_JerarquiaAgrupProveedores().GetType();
				}break;

			}
			base.Init();
		}

		protected override void InitializeMembers()
		{
			txtDescripcion.MaxLength = 50;				
		}

		protected override void FillControls()
		{
			if (_row != null)
			{
				txtDescripcion.Text = (string) _row["Descripcion"];				
				//_activo = Convert.ToBoolean(_row["Activo"]);
				checkBox1.Checked = Convert.ToBoolean(_row["Activo"]);
                /* Silvina 20120420 - Tarea 0000294 */
                if (_source.ToUpper().Equals("PRODUCTOS"))
                    utnComision.Value = _row["Comision"] ;
                /* Fin Silvina 20120420 - Tarea 0000294 */
			}
			else 
			{				
				if(_descripcion != null) txtDescripcion.Text = _descripcion;			
			}
			//checkBox1.Checked = _activo;
		}

		protected override void DumpControls()
		{
			_row["Descripcion"] = txtDescripcion.Text; 
			if (_claveP == null) 
			{_claveP = String.Empty;}
			_row["Activo"] = checkBox1.Checked;
			_row["IdPadre"] = _claveP;
			//_row["IdTipoProducto"] = _idTipoProducto;
             /* Silvina 20120420 - Tarea 0000294 */
            if(_source.ToUpper().Equals("PRODUCTOS"))
				_row["Comision"] = utnComision.Value;
            /* Fin Silvina 20120420 - Tarea 0000294 */
		}			

		#endregion				


		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lComision = new Infragistics.Win.Misc.UltraLabel();
            this.utnComision = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utnComision)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
            this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
            this.ultraExplorerBar1.Margins.ForceSerialization = true;
            this.ultraExplorerBar1.Size = new System.Drawing.Size(804, 409);
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.utnComision);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.lComision);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.checkBox1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(755, 150);
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel5.Location = new System.Drawing.Point(24, 8);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel5.TabIndex = 37;
            this.ultraLabel5.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 8);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 20);
            this.txtDescripcion.TabIndex = 36;
            this.txtDescripcion.Text = "txtDescripcion";
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(24, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(125, 24);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "Activo";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lComision
            // 
            this.lComision.BackColorInternal = System.Drawing.Color.Transparent;
            this.lComision.Location = new System.Drawing.Point(461, 12);
            this.lComision.Name = "lComision";
            this.lComision.Size = new System.Drawing.Size(100, 16);
            this.lComision.TabIndex = 39;
            this.lComision.Text = "Comisión";
            this.lComision.Visible = false;
            // 
            // utnComision
            // 
            this.utnComision.Location = new System.Drawing.Point(529, 7);
            this.utnComision.Name = "utnComision";
            this.utnComision.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.utnComision.PromptChar = ' ';
            this.utnComision.Size = new System.Drawing.Size(54, 21);
            this.utnComision.TabIndex = 40;
            this.utnComision.Visible = false;
            // 
            // FrmAbmJerarquiaAgrupGeneral
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(804, 437);
            this.Name = "FrmAbmJerarquiaAgrupGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utnComision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		//Sobrecarga el metodo showForm para que envia un tercer parametro 
		// que sirve para la inicializacion 
		[ IsShowFormMember ]
		//public void ShowForm( string id, string idP, char IdTipoProducto, string caption )
		public void ShowForm( string Source, string ClaveH, string ClaveP, char IdTipo, string caption)
		{				
			_source = Source;
			_claveH = ClaveH;
			_claveP = ClaveP;
			ShowForm(_claveH,caption);			
		}
	}
}


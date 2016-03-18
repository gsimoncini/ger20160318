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
	public class FrmAbmJerarquiaAgrupProd : mz.erp.ui.forms.FrmAMB
	{
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.ComponentModel.IContainer components = null;
		private string _claveP = String.Empty;
		private string _claveH = String.Empty;
		private string _descripcion = String.Empty;
		private bool _activo = true;
		private System.Windows.Forms.CheckBox checkBox1;
		private char _idTipoProducto;

		public FrmAbmJerarquiaAgrupProd()
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
			_businessRulesType = new mz.erp.businessrules.tsh_JerarquiaAgrupProd().GetType();
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
			_row["IdTipoProducto"] = _idTipoProducto;
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
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1";
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.checkBox1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
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
			this.checkBox1.Location = new System.Drawing.Point(24, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox1.Size = new System.Drawing.Size(125, 24);
			this.checkBox1.TabIndex = 38;
			this.checkBox1.Text = "Activo";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmAbmJerarquiaAgrupProd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 437);
			this.Name = "FrmAbmJerarquiaAgrupProd";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);

		}
		#endregion

		//Sobrecarga el metodo showForm para que envia un tercer parametro 
		// que sirve para la inicializacion 
		[ IsShowFormMember ]
		//public void ShowForm( string id, string idP, char IdTipoProducto, string caption )
		public void ShowForm( string ClaveH, string ClaveP, char IdTipoProducto, string caption)
		{				
			_claveH = ClaveH;
			_claveP = ClaveP;
			_idTipoProducto = IdTipoProducto;			
			ShowForm(_claveH,caption);			
		}
	}
}


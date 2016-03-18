using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace mz.erp.ui.forms
{
	public class FrmAbmCajas : mz.erp.ui.forms.FrmAMB
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescripcion;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsable;
		private System.ComponentModel.IContainer components = null;

		public FrmAbmCajas()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// 
		#region CustomMembers

			protected override void Init()
			{
				_businessRulesType = new mz.erp.businessrules.tfi_Cajas().GetType();
				base.Init();
			}		


			protected override void InitializeMembers()
			{
				//txtIdCaja.MaxLength = 20;
				txtDescripcion.MaxLength = 50;
			}

			protected override void FillControls()
			{
				if (_row != null)
				{
					//txtIdCaja.Text = ( string )_row["IdCaja"];
					mzCEResponsable.SelectedItem.DataValue = ( long )_row["IdResponsable"];
					txtDescripcion.Text = ( string )_row["Descripcion"];
				}
			}
						
			protected override void DumpControls()
			{
				//_row["IdCaja"] = txtIdCaja.Text;
				_row["IdResponsable"] = mzCEResponsable.SelectedItem.DataValue;
				_row["Descripcion"] = txtDescripcion.Text;
			}
				
	#endregion		
					
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

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.mzCEResponsable = new mz.erp.ui.controls.mzComboEditor();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).BeginInit();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsable);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Descripcion";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 48);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Responsable";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(160, 16);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.TabIndex = 4;
			this.txtDescripcion.Text = "";
			// 
			// mzCEResponsable
			// 
			this.mzCEResponsable.DataSource = null;
			this.mzCEResponsable.DisplayMember = "";
			this.mzCEResponsable.DisplayMemberCaption = "";
			this.mzCEResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsable.Location = new System.Drawing.Point(160, 48);
			this.mzCEResponsable.MaxItemsDisplay = 7;
			this.mzCEResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsable.Name = "mzCEResponsable";
			this.mzCEResponsable.Size = new System.Drawing.Size(136, 21);
			this.mzCEResponsable.SorterMember = "";
			this.mzCEResponsable.TabIndex = 66;
			this.mzCEResponsable.ValueMember = "";
			this.mzCEResponsable.ValueMemberCaption = "";
			// 
			// FrmAbmCajas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 437);
			this.Name = "FrmAbmCajas";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).EndInit();

		}
		#endregion

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}


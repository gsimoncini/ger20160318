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

namespace mz.erp.ui.forms
{
	public class FrmAbmEntidades : mz.erp.ui.forms.FrmAMB
	{
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;
		private string _codigo;
		private string _descripcion;

		public FrmAbmEntidades()
		{
			InitializeComponent();
		}



		#region CustomMembers
	

			protected override void Init()
			{
			_businessRulesType = new mz.erp.businessrules.tfi_Entidades().GetType();
			base.Init();
			}		


			protected override void InitializeMembers()
			{
			//txtIdEntidad.MaxLength = 20;
			txtCodigo.MaxLength = 20;
			txtDescripcion.MaxLength = 50;
			}

			protected override void FillControls()
			{
				if (_row != null)
				{
					//txtIdEntidad.Text = ( string )_row["IdEntidad"];
					txtCodigo.Text = ( string )_row["Codigo"];
					txtDescripcion.Text = ( string )_row["Descripcion"];
					//chkSistema.Checked = ( bool )_row["Sistema"];
				}
				else 
				{
					txtCodigo.Text=_codigo;
					txtDescripcion.Text=_descripcion;
				}
			
			}
						
			protected override void DumpControls()
				{
					//_row["IdEntidad"] = txtIdEntidad.Text;
					_row["Codigo"] = txtCodigo.Text;
					_row["Descripcion"] = txtDescripcion.Text;
					//_row["Sistema"] = chkSistema.Checked;
				}
				
			#endregion		
					
					



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

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
					/// el contenido del método con el editor de código.
					/// </summary>
					private void InitializeComponent()
					{
						this.txtCodigo = new System.Windows.Forms.TextBox();
						this.txtDescripcion = new System.Windows.Forms.TextBox();
						this.label1 = new System.Windows.Forms.Label();
						this.label2 = new System.Windows.Forms.Label();
						((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
						this.ultraExplorerBar1.SuspendLayout();
						this.ultraExplorerBarContainerControl1.SuspendLayout();
						this.SuspendLayout();
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
						this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
						this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
						this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
						this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCodigo);
						this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
						// 
						// txtCodigo
						// 
						this.txtCodigo.Location = new System.Drawing.Point(88, 16);
						this.txtCodigo.Name = "txtCodigo";
						this.txtCodigo.Size = new System.Drawing.Size(224, 20);
						this.txtCodigo.TabIndex = 0;
						this.txtCodigo.Text = "";
						// 
						// txtDescripcion
						// 
						this.txtDescripcion.Location = new System.Drawing.Point(88, 48);
						this.txtDescripcion.Name = "txtDescripcion";
						this.txtDescripcion.Size = new System.Drawing.Size(224, 20);
						this.txtDescripcion.TabIndex = 1;
						this.txtDescripcion.Text = "";
						// 
						// label1
						// 
						this.label1.BackColor = System.Drawing.Color.Transparent;
						this.label1.Location = new System.Drawing.Point(24, 16);
						this.label1.Name = "label1";
						this.label1.Size = new System.Drawing.Size(64, 23);
						this.label1.TabIndex = 2;
						this.label1.Text = "Código";
						this.label1.Click += new System.EventHandler(this.label1_Click);
						// 
						// label2
						// 
						this.label2.BackColor = System.Drawing.Color.Transparent;
						this.label2.Location = new System.Drawing.Point(24, 48);
						this.label2.Name = "label2";
						this.label2.Size = new System.Drawing.Size(64, 23);
						this.label2.TabIndex = 3;
						this.label2.Text = "Descripción";
						// 
						// FrmAbmEntidades
						// 
						this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
						this.ClientSize = new System.Drawing.Size(920, 437);
						this.Name = "FrmAbmEntidades";
						this.Text = "ABM de Entidades";
						((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
						this.ultraExplorerBar1.ResumeLayout(false);
						this.ultraExplorerBarContainerControl1.ResumeLayout(false);
						this.ResumeLayout(false);

					}
		#endregion

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}


	/*	[ IsShowFormMember ]
		public void ShowForm( object id, string caption,object [] parameters )
		{
			
			_codigo=(string)parameters[0];//Codigo de la entidad
			_descripcion=(String)parameters[1];//descripcion de la entidad
			ShowForm(id,caption);
			
		}*/
	}
}


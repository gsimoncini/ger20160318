using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using mz.erp.ui.controls;
using mz.erp.ui.controllers;


namespace mz.erp.ui.forms
{
	public class FrmAbmLocalidades : mz.erp.ui.forms.FrmAMB
	{
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCodigoPostal;
		private System.ComponentModel.IContainer components = null;
		private string _descripcion;
		private string _codigoPostal; 

		public FrmAbmLocalidades()
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

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.txtCodigoPostal = new System.Windows.Forms.TextBox();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
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
			this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 433);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCodigoPostal);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(871, 39);
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(0, 20);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel1.TabIndex = 43;
			this.ultraLabel1.Text = "Código Postal";
			// 
			// txtCodigoPostal
			// 
			this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigoPostal.Location = new System.Drawing.Point(104, 20);
			this.txtCodigoPostal.Name = "txtCodigoPostal";
			this.txtCodigoPostal.Size = new System.Drawing.Size(272, 20);
			this.txtCodigoPostal.TabIndex = 1;
			this.txtCodigoPostal.Text = "TXTCODIGOPOSTAL";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(0, 0);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel5.TabIndex = 41;
			this.ultraLabel5.Text = "Nombre";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDescripcion.Location = new System.Drawing.Point(104, 0);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(272, 20);
			this.txtDescripcion.TabIndex = 0;
			this.txtDescripcion.Text = "TXTDESCRIPCION";
			// 
			// FrmAbmLocalidades
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 461);
			this.Name = "FrmAbmLocalidades";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region CustomMembers

		protected override void Init()
		{			
			_businessRulesType = new mz.erp.businessrules.tsh_Localidades().GetType();
			base.Init();
		}

		protected override void InitializeMembers()
		{
			//txtidLocalidad.MaxLength = 30;
			txtDescripcion.MaxLength = 30;
			txtCodigoPostal.MaxLength = 10;
		}

		protected override void FillControls()
		{
			
			if (_row != null)
			{
				//txtidLocalidad.Text = ( string )_row["idLocalidad"];
				txtDescripcion.Text = ( string )_row["Descripcion"];
				txtCodigoPostal.Text = ( string )_row["CodigoPostal"];
			}
			else 
			{ 
				if(_descripcion != null) txtDescripcion.Text =_descripcion;
				if(_codigoPostal != null) txtCodigoPostal.Text = _codigoPostal;
			}
		}

		protected override void DumpControls()
		{
			//_row["idLocalidad"] = txtidLocalidad.Text;
		
				_row["Descripcion"] = txtDescripcion.Text;
				_row["CodigoPostal"] = txtCodigoPostal.Text;
			
		}

		private bool  Validar()
		{
	
			if (txtDescripcion.Text=="")
			{	
				MessageBox.Show("Debe Ingresar El nombre de la Localidad");
				return false;
			}
			if(txtCodigoPostal.Text=="")
			{	
				MessageBox.Show("Debe el Codigo Postal  de la Localidad");
				return false;
			}
			return true;
		}
	
		#endregion	
		

		//Sobrecarga el metodo showForm para que envia un tercer parametro 
		// que sirve para la inicializacion 
		[ IsShowFormMember ]
		public void ShowForm( object id, string caption,object [] parameters )
		{
			this.setDescripcion((string)parameters[0]);//descripcion
			this.setCodigoPostal((string)parameters[1]);//Codigo Postal
			ShowForm(id,caption);
			
		}
		
		#region descripcion
		public void setDescripcion(string desc)
		{
			_descripcion=desc;
		}
		public string getDescripcion()
		{
			return _descripcion;
		}
		#endregion 


		#region codigoPostal
		public void setCodigoPostal(string cp)
		{
			_codigoPostal=cp;
		}
		public string getCodigoPostal()
		{
			return _codigoPostal;
		}
		#endregion
	}
}


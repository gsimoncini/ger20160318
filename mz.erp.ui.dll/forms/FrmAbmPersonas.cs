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
	public class FrmAbmPersonas : mz.erp.ui.forms.FrmAMB
	{
		private System.ComponentModel.IContainer components = null;
		private string _nombre;
		private string _telefono;



		public FrmAbmPersonas()
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

		private System.Windows.Forms.Button button1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.TextBox txtComentarios;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtInstantMesseger;
		private System.Windows.Forms.TextBox txtNombre;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private mz.erp.ui.controls.mzComboEditor mzCmbTratamiento;
		private System.Windows.Forms.TextBox txtTelefonos;

		#region CustomMembers

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tsh_Personas().GetType();
			base.Init();
		}
		protected override void InitializeMembers()
		{
			txtNombre.MaxLength = 50;
			txtComentarios.MaxLength = 100;
			txtTelefonos.MaxLength = 100;
			txtEmail.MaxLength = 100;
			txtInstantMesseger.MaxLength = 100;
			txtObservaciones.MaxLength = 1000;
			mzCmbTratamiento.FillFromDataSource( businessrules.tcs_Tratamiento.GetList().tcs_Tratamiento, "IdTratamiento", "Texto", 8, "ID", "Texto", "Texto" );
			
		}

		protected override void FillControls()
		{

			if (_row != null)
			{
				txtNombre.Text = (string)_row["Nombre"];
				txtComentarios.Text = (string)_row["Comentarios"];
				txtTelefonos.Text = (string)_row["Telefonos"];
				txtEmail.Text = (string)_row["Email"];
				txtInstantMesseger.Text = (string)_row["InstantMesseger"];
				txtObservaciones.Text = (string)_row["Observaciones"];
				if(this.State.Equals("NEW"))
					mzCmbTratamiento.Value = 7;
				else
				if(_row["IdTratamiento"] != null)
					mzCmbTratamiento.Value = (long)_row["IdTratamiento"];
			}
			else 
			{
				//if(_idPersona != null) 
				if(_nombre != null) txtNombre.Text = _nombre;
				if(_telefono != null)txtTelefonos.Text = _telefono;
			}
		}

		protected override void DumpControls()
		{
			
				_row["Nombre"] = txtNombre.Text;
				_row["Comentarios"] = txtComentarios.Text;
				_row["Telefonos"] = txtTelefonos.Text;
				_row["Email"] = txtEmail.Text;
				_row["InstantMesseger"] = txtInstantMesseger.Text;
				_row["Observaciones"] = txtObservaciones.Text;
				if(mzCmbTratamiento.Value == null)
				_row["IdTratamiento"] = System.DBNull.Value;
				else _row["IdTratamiento"] = mzCmbTratamiento.Value;
			
		}


			
		#endregion		
				
		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.txtComentarios = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtInstantMesseger = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTelefonos = new System.Windows.Forms.TextBox();
			this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbTratamiento = new mz.erp.ui.controls.mzComboEditor();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTratamiento)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(704, 225);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTratamiento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel7);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtObservaciones);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtComentarios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtEmail);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtInstantMesseger);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNombre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTelefonos);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(655, 151);
			this.ultraExplorerBarContainerControl1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(392, 424);
			this.button1.Name = "button1";
			this.button1.TabIndex = 18;
			this.button1.Text = "button1";
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(-1, 120);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel6.TabIndex = 36;
			this.ultraLabel6.Text = "Instant Messenger";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(0, 0);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel5.TabIndex = 35;
			this.ultraLabel5.Text = "Nombre";
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(-1, 101);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel4.TabIndex = 34;
			this.ultraLabel4.Text = "Observaciones";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(0, 40);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel3.TabIndex = 33;
			this.ultraLabel3.Text = "Email";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(-1, 61);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel2.TabIndex = 32;
			this.ultraLabel2.Text = "Teléfonos";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(0, 80);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel1.TabIndex = 31;
			this.ultraLabel1.Text = "Comentarios";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(104, 101);
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(272, 20);
			this.txtObservaciones.TabIndex = 5;
			this.txtObservaciones.Text = "textBox2";
			// 
			// txtComentarios
			// 
			this.txtComentarios.Location = new System.Drawing.Point(104, 80);
			this.txtComentarios.Name = "txtComentarios";
			this.txtComentarios.Size = new System.Drawing.Size(272, 20);
			this.txtComentarios.TabIndex = 4;
			this.txtComentarios.Text = "textBox2";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(104, 40);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(272, 20);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.Text = "textBox2";
			// 
			// txtInstantMesseger
			// 
			this.txtInstantMesseger.Location = new System.Drawing.Point(104, 120);
			this.txtInstantMesseger.Name = "txtInstantMesseger";
			this.txtInstantMesseger.Size = new System.Drawing.Size(272, 20);
			this.txtInstantMesseger.TabIndex = 6;
			this.txtInstantMesseger.Text = "textBox2";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(104, 0);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(272, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.Text = "textBox2";
			// 
			// txtTelefonos
			// 
			this.txtTelefonos.Location = new System.Drawing.Point(104, 61);
			this.txtTelefonos.Name = "txtTelefonos";
			this.txtTelefonos.Size = new System.Drawing.Size(272, 20);
			this.txtTelefonos.TabIndex = 3;
			this.txtTelefonos.Text = "textBox1";
			// 
			// ultraLabel7
			// 
			this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel7.Location = new System.Drawing.Point(-1, 20);
			this.ultraLabel7.Name = "ultraLabel7";
			this.ultraLabel7.Size = new System.Drawing.Size(100, 21);
			this.ultraLabel7.TabIndex = 37;
			this.ultraLabel7.Text = "Tratamiento";
			// 
			// mzCmbTratamiento
			// 
			this.mzCmbTratamiento.AutoComplete = true;
			this.mzCmbTratamiento.DataSource = null;
			this.mzCmbTratamiento.DisplayMember = "";
			this.mzCmbTratamiento.DisplayMemberCaption = "";
			this.mzCmbTratamiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTratamiento.Location = new System.Drawing.Point(104, 20);
			this.mzCmbTratamiento.MaxItemsDisplay = 7;
			this.mzCmbTratamiento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTratamiento.Name = "mzCmbTratamiento";
			this.mzCmbTratamiento.Size = new System.Drawing.Size(272, 21);
			this.mzCmbTratamiento.SorterMember = "";
			this.mzCmbTratamiento.TabIndex = 1;
			this.mzCmbTratamiento.ValueMember = "";
			this.mzCmbTratamiento.ValueMemberCaption = "";
			// 
			// FrmAbmPersonas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 253);
			this.Controls.Add(this.button1);
			this.Name = "FrmAbmPersonas";
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.ultraExplorerBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTratamiento)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion



		//Sobrecarga el metodo showForm para que envia un tercer parametro 
		// que sirve para la inicializacion 
		[ IsShowFormMember ]
		public void ShowForm( object id, string caption,object [] parameters )
		{
			//_idPersona=(string)parameters[0];//IdPersona
			_nombre=(string)parameters[0];//Nombre de la persona
			_telefono=(String)parameters[1];//Telefono o telefonos
			ShowForm(id,caption);
			
		}
	}
}


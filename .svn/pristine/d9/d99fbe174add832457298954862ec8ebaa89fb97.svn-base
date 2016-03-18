
namespace mz.erp.ui.forms
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using mz.erp.businessrules;
	using mz.erp.commontypes.data;
    using mz.erp.systemframework;

	public class LogIn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private Infragistics.Win.Misc.UltraButton buttonOk;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor editUserName;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor editPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor comboEmpresas;
		private Infragistics.Win.UltraWinEditors.UltraComboEditor comboPerfiles;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.Misc.UltraButton buttonCanel;
		private mz.erp.ui.controls.mzComboEditor mzCEUsuarios;
		private System.ComponentModel.Container components = null;
        //Cristian Tarea 0000122 20110506
        private bool multiEmpresa = false;
        //Fin Tarea 0000122
		public LogIn()
		{
			InitializeComponent();
			//mzCEUsuarios.FillFromDataSource(mz.erp.businessrules.sy_Usuarios.GetList().sy_Usuarios, "IdUsuario","Nombre",100,"ID","Nombre","Nombre");
			//Cristian Tarea 00000122
           // ApplicationConfiguration.updateConnectionString((String)comboEmpresas.Value);
            
            //mzCEUsuarios.FillFromDataSource(mz.erp.businessrules.sy_Usuarios.GetListActivos(), "IdUsuario","Nombre",100,"ID","Nombre","Nombre");
            sy_EmpresasDataset _data = sy_Empresas.GetList(); 
            comboEmpresas.Items.Clear();
            comboPerfiles.Items.Clear();
            multiEmpresa =  Variables.GetValueBool("Login.MultiEmpresa");
            int baseActual = 0;
            foreach (sy_EmpresasDataset.sy_EmpresasRow _row in _data.sy_Empresas.Rows)
            {
                comboEmpresas.Items.Add(_row.BaseDeDatos, _row.Descripcion);
                if (ApplicationConfiguration.GetDatabase().Equals(_row.BaseDeDatos)) { baseActual = (comboEmpresas.Items.Count - 1); }
            }
            if (multiEmpresa)
            {
                if (comboEmpresas.Items.Count > 0)
                {
                    if (comboEmpresas.Items.Count == 1)
                    {
                        mzCEUsuarios.Focus();
                        mzCEUsuarios.Select();

                    }
                    else
                    {
                        comboEmpresas.Focus();
                        comboEmpresas.Select();
                    }
                }
                }//end if principal
            else
               {
                mzCEUsuarios.FillFromDataSource(mz.erp.businessrules.sy_Usuarios.GetListActivos(), "IdUsuario", "Nombre", 100, "ID", "Nombre", "Nombre");
                comboEmpresas.SelectedIndex = baseActual;
                mzCEUsuarios.Focus();
                mzCEUsuarios.Select();
               }
            
            //fin Tarea 00000122
		}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editUserName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.editPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.buttonOk = new Infragistics.Win.Misc.UltraButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEmpresas = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.comboPerfiles = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCanel = new Infragistics.Win.Misc.UltraButton();
            this.mzCEUsuarios = new mz.erp.ui.controls.mzComboEditor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboPerfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // editUserName
            // 
            this.editUserName.Location = new System.Drawing.Point(214, 37);
            this.editUserName.Name = "editUserName";
            this.editUserName.Size = new System.Drawing.Size(256, 22);
            this.editUserName.TabIndex = 1;
            this.editUserName.TabStop = false;
            this.editUserName.Leave += new System.EventHandler(this.editUserName_Leave);
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(216, 60);
            this.editPassword.Name = "editPassword";
            this.editPassword.PasswordChar = '*';
            this.editPassword.Size = new System.Drawing.Size(256, 22);
            this.editPassword.TabIndex = 2 ;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(264, 112);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 24);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Iniciar sesión";
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(144, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(144, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Empresa:";
            // 
            // comboEmpresas
            // 
            this.comboEmpresas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.comboEmpresas.Location = new System.Drawing.Point(216, 9);
            this.comboEmpresas.Name = "comboEmpresas";
            this.comboEmpresas.Size = new System.Drawing.Size(256, 22);
            this.comboEmpresas.TabIndex = 0;
            this.comboEmpresas.ValueChanged += new System.EventHandler(this.comboEmpresas_ValueChanged);
            // 
            // comboPerfiles
            // 
            this.comboPerfiles.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.comboPerfiles.Location = new System.Drawing.Point(216, 84);
            this.comboPerfiles.Name = "comboPerfiles";
            this.comboPerfiles.Size = new System.Drawing.Size(256, 22);
            this.comboPerfiles.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(144, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Perfil:";
            // 
            // buttonCanel
            // 
            this.buttonCanel.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button;
            this.buttonCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCanel.Location = new System.Drawing.Point(384, 112);
            this.buttonCanel.Name = "buttonCanel";
            this.buttonCanel.Size = new System.Drawing.Size(88, 24);
            this.buttonCanel.TabIndex = 5;
            this.buttonCanel.Text = "&Cancelar";
            this.buttonCanel.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            // 
            // mzCEUsuarios
            // 
            this.mzCEUsuarios.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEUsuarios.AutoSize = false;
            this.mzCEUsuarios.DisplayMember = "";
            this.mzCEUsuarios.DisplayMemberCaption = "";
            this.mzCEUsuarios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEUsuarios.Location = new System.Drawing.Point(216, 37);
            this.mzCEUsuarios.MaxDropDownItems = 7;
            this.mzCEUsuarios.MaxItemsDisplay = 50;
            this.mzCEUsuarios.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEUsuarios.Name = "mzCEUsuarios";
            this.mzCEUsuarios.Size = new System.Drawing.Size(256, 22);
            this.mzCEUsuarios.SorterMember = "";
            this.mzCEUsuarios.SortStyle = Infragistics.Win.ValueListSortStyle.Ascending;
            this.mzCEUsuarios.TabIndex = 1;
            this.mzCEUsuarios.ValueMember = "";
            this.mzCEUsuarios.ValueMemberCaption = "";
            this.mzCEUsuarios.ValueChanged += new System.EventHandler(this.mzCEUsuarios_ValueChanged);
            // 
            // LogIn
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.CancelButton = this.buttonCanel;
            this.ClientSize = new System.Drawing.Size(482, 152);
            this.Controls.Add(this.mzCEUsuarios);
            this.Controls.Add(this.buttonCanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboPerfiles);
            this.Controls.Add(this.comboEmpresas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.editUserName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboPerfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


		#endregion

		private void buttonOk_Click(object sender, System.EventArgs e)
		{
			if ( Security.LogIn( (string)mzCEUsuarios.Value, editPassword.Text ) )
			{
				Security.IdUsuario = (string)mzCEUsuarios.Value;
				Security.IdPerfil = ( long )comboPerfiles.Value;
				Security.Perfil = comboPerfiles.Text;
				Security.IdIdioma = 1;

				sy_ConexionDataset.sy_ConexionRow row = mz.erp.businessrules.sy_Conexion.NewRow();								
				
				row.IdUsuario = Security.IdUsuario;				
				row.IdPerfil = Security.IdPerfil;
				row.IdEmpresa = Security.IdEmpresa;
				row.IdConexionCreacion = row.IdConexion;				
				row.IdPuesto = Security.IdPuesto;
				
				mz.erp.businessrules.sy_Conexion.Update(row);
				Security.IdConexion = row.IdConexion;
				this.DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show( "Usuario o contraseña no válidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
				editPassword.SelectAll();
			}
		}

		private void editUserName_Leave(object sender, System.EventArgs e)
		{
			using ( sy_EmpresasDataset _data = sy_Empresas.GetList() )
			{
				comboEmpresas.Items.Clear();
				comboPerfiles.Items.Clear();

				foreach ( sy_EmpresasDataset.sy_EmpresasRow _row in _data.sy_Empresas.Rows )
				{
					comboEmpresas.Items.Add( _row.IdEmpresa, _row.Descripcion );
				}

				if ( comboEmpresas.Items.Count > 0 )
				{
					comboEmpresas.SelectedIndex = 0;
				}
			}
		}


        private void comboEmpresas_ValueChanged(object sender, System.EventArgs e)
        {
            
            //Cristian Tarea 0000122
            if (multiEmpresa)
            {
                comboPerfiles.Items.Clear();
                Console.WriteLine(" BD:" + ApplicationConfiguration.GetDatabase());
                //Si la base de datos elegida no es igual a la default se modifica el connectionString
                if (!((String)comboEmpresas.Value).Equals(ApplicationConfiguration.GetDatabase()))
                {
                    ApplicationConfiguration.updateConnectionString((String)comboEmpresas.Value);
                    //this.statusBar.Panels["Servidor"].Text = systemframework.ApplicationConfiguration.GetServidor();
                    //this.statusBar.Panels["Database"].Text = systemframework.ApplicationConfiguration.GetDatabase();				
			
                }

                mzCEUsuarios.FillFromDataSource(mz.erp.businessrules.sy_Usuarios.GetListActivos(), "IdUsuario", "Nombre", 100, "ID", "Nombre", "Nombre");
            }
            //Fin Tarea 00000122
         }
   
		private void mzCEUsuarios_ValueChanged(object sender, System.EventArgs e)
		{
            //Cristian Tarea 0000122 20110505
            comboPerfiles.Items.Clear();
            long idEmpresa = 1;
            if (multiEmpresa && !comboEmpresas.Text.Equals(String.Empty) && (string)mzCEUsuarios.Value != string.Empty)
            {
                idEmpresa = this.recuperarIdEmpresa((String)comboEmpresas.Value);

            }
            else
            {
                using (sy_EmpresasDataset _data = sy_Empresas.GetList())
                {
                    /*
                    comboEmpresas.Items.Clear();
                    comboPerfiles.Items.Clear();
                    int baseActual = 0;
                    foreach (sy_EmpresasDataset.sy_EmpresasRow _row in _data.sy_Empresas.Rows)
                    {
                        comboEmpresas.Items.Add(_row.BaseDeDatos, _row.Descripcion);
                        if (ApplicationConfiguration.GetDatabase().Equals(_row.BaseDeDatos)) { baseActual = (int)_row.IdEmpresa; }
                    }
                    if (comboEmpresas.Items.Count > 0)
                    {
                        comboEmpresas.SelectedIndex = baseActual;
                    }
                     */
                }
            }//End Else

            using (sy_PerfilesDataset _data = sy_Perfiles.GetList(idEmpresa, (string)mzCEUsuarios.Value))
            {
                foreach (sy_PerfilesDataset.sy_PerfilesRow _row in _data.sy_Perfiles.Rows)
                {
                    comboPerfiles.Items.Add(_row.IdPerfil, _row.Descripcion);
                }

                if (comboPerfiles.Items.Count > 0)
                {
                    comboPerfiles.SelectedIndex = 0;
                }
            }
            //Fin Tarea 00000122
            
		}


		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			this.Text = "Iniciar sesión - " + 			
				systemframework.ApplicationConfiguration.GetServidor() + " " + 
				systemframework.ApplicationConfiguration.GetDatabase();	
		}

        //Cristian Tarea 0000122 20110505
        private long recuperarIdEmpresa(String BDEmpresa)
        {
            using (sy_EmpresasDataset _data = sy_Empresas.GetList())
            {
                foreach (sy_EmpresasDataset.sy_EmpresasRow _row in _data.sy_Empresas.Rows)
                {
                    if (_row.BaseDeDatos.Equals(BDEmpresa)) ; { return _row.IdEmpresa; }
                }
            return 0;
            }
        }
        //Fin Tarea 0000122
	}
}

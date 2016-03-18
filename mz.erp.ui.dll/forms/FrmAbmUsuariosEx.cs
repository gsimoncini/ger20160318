using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.commontypes.data;



namespace mz.erp.ui.forms
{
	public class FrmAbmUsuariosEx : mz.erp.ui.forms.FrmABMEx
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombreUsuario;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor1;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uteConfirmaPassword;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbPersona;
		private System.Windows.Forms.CheckedListBox ListaPerfiles;
		private System.Windows.Forms.CheckBox chkActivo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor equipo;
		private System.Windows.Forms.Label labelEquipo;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.TreeView treeViewSecciones;
		private System.ComponentModel.IContainer components = null;

		public FrmAbmUsuariosEx()
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
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ListaPerfiles = new System.Windows.Forms.CheckedListBox();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.treeViewSecciones = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ultraTextEditor1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.uteConfirmaPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCmbPersona = new mz.erp.ui.controls.mzComboSearchEditor();
			this.chkActivo = new System.Windows.Forms.CheckBox();
			this.equipo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.labelEquipo = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uteConfirmaPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.equipo)).BeginInit();
			this.SuspendLayout();
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.Size = new System.Drawing.Size(832, 28);
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Key = "Perfiles";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 229;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Perfiles";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup2.Key = "DepositosYSecciones";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 229;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Depósitos y Secciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(832, 450);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl3, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelEquipo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.equipo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNombreUsuario);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbPersona);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uteConfirmaPassword);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraTextEditor1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.Password);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 48);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(767, 104);
			this.ultraExplorerBarContainerControl1.TabStop = false;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ListaPerfiles);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 34);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(767, 229);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// ListaPerfiles
			// 
			this.ListaPerfiles.Location = new System.Drawing.Point(0, 0);
			this.ListaPerfiles.Name = "ListaPerfiles";
			this.ListaPerfiles.Size = new System.Drawing.Size(760, 229);
			this.ListaPerfiles.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.treeViewSecciones);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 322);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(767, 229);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// treeViewSecciones
			// 
			this.treeViewSecciones.CheckBoxes = true;
			this.treeViewSecciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewSecciones.ImageIndex = -1;
			this.treeViewSecciones.Location = new System.Drawing.Point(0, 0);
			this.treeViewSecciones.Name = "treeViewSecciones";
			this.treeViewSecciones.SelectedImageIndex = -1;
			this.treeViewSecciones.Size = new System.Drawing.Size(767, 229);
			this.treeViewSecciones.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre de Usuario";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.Location = new System.Drawing.Point(136, 0);
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(328, 20);
			this.txtNombreUsuario.TabIndex = 0;
			this.txtNombreUsuario.Text = "";
			// 
			// Password
			// 
			this.Password.BackColor = System.Drawing.Color.Transparent;
			this.Password.Location = new System.Drawing.Point(0, 28);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(136, 16);
			this.Password.TabIndex = 2;
			this.Password.Text = "Password";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Confirmar Password";
			// 
			// ultraTextEditor1
			// 
			this.ultraTextEditor1.Location = new System.Drawing.Point(136, 24);
			this.ultraTextEditor1.Name = "ultraTextEditor1";
			this.ultraTextEditor1.PasswordChar = '*';
			this.ultraTextEditor1.Size = new System.Drawing.Size(328, 21);
			this.ultraTextEditor1.TabIndex = 1;
			// 
			// uteConfirmaPassword
			// 
			this.uteConfirmaPassword.Location = new System.Drawing.Point(136, 48);
			this.uteConfirmaPassword.Name = "uteConfirmaPassword";
			this.uteConfirmaPassword.PasswordChar = '*';
			this.uteConfirmaPassword.Size = new System.Drawing.Size(328, 21);
			this.uteConfirmaPassword.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(0, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Persona";
			// 
			// mzCmbPersona
			// 
			this.mzCmbPersona.DataValue = "";
			this.mzCmbPersona.EditObject = null;
			this.mzCmbPersona.FastSearch = false;
			this.mzCmbPersona.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbPersona.HierarchicalSearch = false;
			this.mzCmbPersona.Location = new System.Drawing.Point(136, 72);
			this.mzCmbPersona.Name = "mzCmbPersona";
			this.mzCmbPersona.ReadOnly = false;
			this.mzCmbPersona.SearchObject = null;
			this.mzCmbPersona.SearchObjectListener = null;
			this.mzCmbPersona.Size = new System.Drawing.Size(496, 22);
			this.mzCmbPersona.TabIndex = 3;
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Checked = true;
			this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkActivo.Location = new System.Drawing.Point(496, 0);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkActivo.Size = new System.Drawing.Size(136, 24);
			this.chkActivo.TabIndex = 4;
			this.chkActivo.Text = "Activo";
			this.chkActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// equipo
			// 
			this.equipo.Location = new System.Drawing.Point(616, 32);
			this.equipo.MaxValue = 999999;
			this.equipo.MinValue = 0;
			this.equipo.Name = "equipo";
			this.equipo.Size = new System.Drawing.Size(72, 21);
			this.equipo.TabIndex = 5;
			this.equipo.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// labelEquipo
			// 
			this.labelEquipo.BackColor = System.Drawing.Color.Transparent;
			this.labelEquipo.Location = new System.Drawing.Point(496, 32);
			this.labelEquipo.Name = "labelEquipo";
			this.labelEquipo.Size = new System.Drawing.Size(98, 16);
			this.labelEquipo.TabIndex = 79;
			this.labelEquipo.Text = "Equipo del usuario";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// FrmAbmUsuariosEx
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(832, 478);
			this.Name = "FrmAbmUsuariosEx";
			this.Text = "ABM de Usuarios";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uteConfirmaPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.equipo)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.sy_UsuariosEx().GetType();
			base.Init();
		}


		#region Perfiles
	
		private ArrayList perfiles; //variables q mantiene los perfiles de la lista 
		string _nombre = String.Empty;
		string _idUsuario = String.Empty;

		private	Hashtable idsTree = new Hashtable();																	  
		private	Hashtable nodesTree = new Hashtable();																	  


		#region Clase auxiliar para mantener info del perfil
		
		public class Perfil
		{
			public Perfil()
			{
			}

			string _descripcion = string.Empty;
			string _idPerfil = string.Empty;
			bool _tildado = false;
			bool _estadoInicial = false;

			public string Descripcion
			{
				set { _descripcion = value;}
				get { return _descripcion;}
			}
			public string IdPerfil
			{
				set { _idPerfil = value;}
				get { return _idPerfil;}
			}
			public bool Tildado
			{
				set { _tildado = value;}
				get { return _tildado;}
			}
			public bool EstadoInicial
			{
				set { _estadoInicial = value;}
				get { return _estadoInicial;}
			}
		}
		#endregion

		
		private ArrayList InicializarPerfiles()
		{
			perfiles = new ArrayList();
			if(Security.PerteneceAPerfilSuperior) //Si es un perfil superior ve todos los perfiles q existen
			{
				System.Data.DataTable tablePerfiles = _data.Tables["sy_Perfiles"];
				foreach(System.Data.DataRow row in tablePerfiles.Rows)
				{
					Perfil p  = new Perfil();
					p.Descripcion = row["Descripcion"].ToString();
					p.IdPerfil = row["idPerfil"].ToString();
					p.Tildado = false;
					perfiles.Add(p);
				}	
			}
			else
			{
				string strPerfilesAExcluir = Variables.GetValueString("Usuarios.Nuevo.PerfilesOcultos");
				string IdPerfilAdministrador = Variables.GetValueString("Sistema.Administrador.IdPerfil");
				ArrayList PerfilesAExcluir = systemframework.Util.Parse(strPerfilesAExcluir, ",");			

				

				System.Data.DataTable tablePerfiles = _data.Tables["sy_Perfiles"];
				foreach(System.Data.DataRow row in tablePerfiles.Rows)
				{
					Perfil p  = new Perfil();
					p.Descripcion = row["Descripcion"].ToString();
					p.IdPerfil = row["idPerfil"].ToString();
					p.Tildado = false;
					if (!Security.PerfilesSuperioresList.Contains(p.IdPerfil.ToString()) && !PerfilesAExcluir.Contains(p.IdPerfil))
					{
							perfiles.Add(p);
					}				
				}	
			}
			return perfiles;
		}
		
		private void InicializarDepositosYSecciones()
		{
			/*Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();

			Infragistics.Win.UltraWinTree.UltraTree ultraTree = new Infragistics.Win.UltraWinTree.UltraTree();
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Tipos de Observaciones";
			ultraTreeNode1.CheckedState = System.Windows.Forms.CheckState.
			ultraTree.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
			*/
								
		    tlg_DepositosDataset.tlg_DepositosDataTable dataDepositos = mz.erp.businessrules.tlg_Depositos.GetList().tlg_Depositos;
			foreach(tlg_DepositosDataset.tlg_DepositosRow rowD in dataDepositos.Rows)
			{
				string IdDeposito = rowD.IdDeposito;
				string DescripcionD = rowD.Descripcion;
				TreeNode nodeD = new TreeNode(DescripcionD);
				idsTree.Add(nodeD, IdDeposito);
				treeViewSecciones.Nodes.Add(nodeD);
				tlg_SeccionesDataset.tlg_SeccionesDataTable dataSecciones = mz.erp.businessrules.tlg_Secciones.GetList(IdDeposito, true).tlg_Secciones;
				foreach(tlg_SeccionesDataset.tlg_SeccionesRow rowS in dataSecciones.Rows)
				{
					string IdSeccion = rowS.IdSeccion;
					string DescripcionS = rowS.Descripcion;
					TreeNode nodeS = new TreeNode(DescripcionS);
					idsTree.Add(nodeS, IdSeccion);
					nodesTree.Add(IdSeccion, nodeS);
					nodeD.Nodes.Add(nodeS);
				}

			}
		}

		private void seleccionarDeposito()
		{
			foreach(TreeNode node in treeViewSecciones.Nodes)
			{
				bool chk = node.Nodes.Count > 0;
				int i = 0;
				while(chk && i < node.Nodes.Count)
				{
					TreeNode nodeS = node.Nodes[i];
					chk = chk && nodeS.Checked;
					i++;
				}
				node.Checked = chk;
			}

		}
			#endregion
		
		protected override void InitializeMembers()
		{
			mzCmbPersona.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			InicializarPerfiles();
			foreach(Perfil p in perfiles)
			{
				ListaPerfiles.Items.Add(p.Descripcion, false);
			}				
			this.ultraExplorerBar1.Groups[1].Visible = true;//!this.State.Equals("EDIT");
			InicializarDepositosYSecciones();

			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, "Usuarios.ContenedoresColapsados");
		}

		protected override void FillControls()
		{//para levantar
			if (_data != null)
			{
				System.Data.DataTable tableUsuarios = _data.Tables["sy_Usuarios"];
				System.Data.DataTable tableUsuariosPerfiles = _data.Tables["sy_PerfilesUsuariosEmpresas"];
				System.Data.DataRow rowUsuarios = tableUsuarios.Rows[0];

				_idUsuario = (string)rowUsuarios["IdUsuario"];
				_nombre = (string)rowUsuarios["Nombre"];
				txtNombreUsuario.Text = _idUsuario;
				string clave = Convert.ToString(rowUsuarios["Clave"]);
				if(clave != null && !clave.Equals(string.Empty))
					clave = new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64( clave);
				uteConfirmaPassword.Text =clave;				
				ultraTextEditor1.Text = clave;		
				chkActivo.Checked = Convert.ToBoolean(rowUsuarios["Activo"]);

				/*foreach(System.Data.DataRow row in tableUsuariosPerfiles.Rows)//por cadausuario
				{	
					for(int i=0; i < perfiles.Count; i++) //por cada item 
					{
						Perfil p = (Perfil)perfiles[i];
						p.EstadoInicial= (Convert.ToInt64(p.IdPerfil) == (long)row["IdPerfil"]); //lo tilda segun si esta o no entre los perfiles
						p.Tildado = p.EstadoInicial;						
					}
				}*/				
			
				if(this.State.Equals("EDIT")) 
				{
					this.equipo.Value=rowUsuarios["Equipo"];
					foreach(System.Data.DataRow row in tableUsuariosPerfiles.Rows)//por cadausuario
					{	
						string IdUsuario = Convert.ToString(row["IdUsuario"]);
						if (_idUsuario == IdUsuario)
						{
							for(int i=0; i < perfiles.Count; i++) //por cada item 
							{
								Perfil p = (Perfil)perfiles[i];
								long IdPerfil1 = (long)row["IdPerfil"];
								long IdPerfil2 = Convert.ToInt64(p.IdPerfil);							
								if (IdPerfil1 == IdPerfil2) 
								{								
									p.EstadoInicial= true;
									p.Tildado = p.EstadoInicial;						
								}							
							}
						}
					}
					for (int i=0; i < ListaPerfiles.Items.Count; i++)
					{					
						Perfil p = (Perfil)perfiles[i];
						ListaPerfiles.SetSelected(i, true);
						ListaPerfiles.SetItemChecked(i, p.Tildado);						
					}

					//Cargo las secciones de las q son responsables
					_processItem = false;
					sy_UsuariosExDataset.tlg_ResponsablesDepositosSeccionesDataTable tableResponsablesSecciones = (sy_UsuariosExDataset.tlg_ResponsablesDepositosSeccionesDataTable)_data.Tables["tlg_ResponsablesDepositosSecciones"];
					foreach(sy_UsuariosExDataset.tlg_ResponsablesDepositosSeccionesRow rowRS in tableResponsablesSecciones.Rows)
					{
						string IdSeccion = rowRS.IdSeccion;
						TreeNode nodeS = (TreeNode)nodesTree[IdSeccion];
						foreach(TreeNode node in treeViewSecciones.Nodes)
						{
							int index = node.Nodes.IndexOf(nodeS);
							if(index != -1)
								node.Nodes[index].Checked = true;
						}
						

					}
					//si todas las secciones de un deposito estan seleccionadas selecciono el deposito
					this.seleccionarDeposito();
					_processItem = true;

				}
				mzCmbPersona.DataValue = (string) rowUsuarios["IdPersona"];		

				this.ListaPerfiles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListaPerfiles_ItemCheck);
			    treeViewSecciones.AfterCheck+=new TreeViewEventHandler(treeViewSecciones_AfterCheck);

				if(this.State.Equals("EDIT")) //Si es modificacion solo el propio usuario puede editar su contraseña.
				{
					ultraTextEditor1.Enabled = Security.IdUsuario.Equals(_idUsuario);
					uteConfirmaPassword.Enabled = Security.IdUsuario.Equals(_idUsuario);
				}
				else //Si es alta se puede ingresar una contraseña para el usuario q se esta creando solo si la variable asi lo indica.
				{
					ultraTextEditor1.Enabled = Variables.GetValueBool("Usuarios.Editar.Password");
					uteConfirmaPassword.Enabled = Variables.GetValueBool("Usuarios.Editar.Password");
				}

				mzCmbPersona.Enabled = Variables.GetValueBool("Usuarios.Editar.Persona");
				txtNombreUsuario.Enabled =  Variables.GetValueBool("Usuarios.Editar.NombreDeUsuario");
				chkActivo.Enabled = Variables.GetValueBool("Usuarios.Editar.Activo");
				equipo.Enabled = Variables.GetValueBool("Usuarios.Editar.Equipo");
				ListaPerfiles.Enabled = Variables.GetValueBool("Usuarios.Editar.Perfiles");
				treeViewSecciones.Enabled = Variables.GetValueBool("Usuarios.Editar.DepositosSecciones");

				//Visibiliza y habilita las solapas de acuerdo a lo configurado en las variabes
				ultraExplorerBar1.Groups[0].Key = "DatosGenerales";
				foreach  (Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup grupo in  this.ultraExplorerBar1.Groups)
				{						
					grupo.Visible = false;
					grupo.Container.Enabled=false;
				}

				string contenedoresVisibles = Variables.GetValueString("Usuarios.ContenedoresVisibles");
				if(!contenedoresVisibles.Equals(string.Empty))
				{
					ArrayList cont = mz.erp.systemframework.Util.Parse(contenedoresVisibles, ",");
					foreach(string grupo in cont)
					{
						if (this.ultraExplorerBar1.Groups.Exists(grupo))
							this.ultraExplorerBar1.Groups[grupo].Visible = true;
					}
				}

				string contenedoresHabilitados = Variables.GetValueString("Usuarios.ContenedoresHabilitados");
				if(!contenedoresHabilitados.Equals(string.Empty))
				{								
					ArrayList cont = mz.erp.systemframework.Util.Parse(contenedoresHabilitados, ",");
					foreach(string grupo in cont)
					{
						if (this.ultraExplorerBar1.Groups.Exists(grupo))
						{
							if (this.ultraExplorerBar1.Groups[grupo].Container != null)
							{
								this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;}
							this.ultraExplorerBar1.Groups[grupo].Enabled = true;}
					}
				}
			}
		}

		protected override void DumpControls()
		{
/*
 			_row = sy_Usuarios.GetByPk(this._idUsuario);	
			string encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64( this._claveNueva2 );
			_row.Clave = encriptada;
			_data.sy_Usuarios.ImportRow(_row);

 * */
			System.Data.DataTable tableUsuarios = _data.Tables["sy_Usuarios"];
			System.Data.DataTable tableUsuariosPerfiles = _data.Tables["sy_PerfilesUsuariosEmpresas"];
			System.Data.DataRow rowUsuarios = tableUsuarios.Rows[0];
			rowUsuarios["IdUsuario"] = txtNombreUsuario.Text;
			

			//rowUsuarios["Clave"] = ultraTextEditor1.Text;
			string encriptada = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64( ultraTextEditor1.Text );
			rowUsuarios["Clave"] = encriptada;
			string IdPersona = Convert.ToString(mzCmbPersona.DataValue);
			if(IdPersona != null && !IdPersona.Equals(string.Empty))
			{
					rowUsuarios["IdPersona"] = IdPersona;
					System.Data.DataRow row = mz.erp.businessrules.tsh_Personas.GetByPk(IdPersona);
					if(row != null)
						rowUsuarios["Nombre"] = row["Nombre"];
					else
						rowUsuarios["Nombre"] = txtNombreUsuario.Text;
			}
			rowUsuarios["VencimientoClave"] = mz.erp.businessrules.Sistema.DateTime.Now;
			rowUsuarios["HabilitacionCuenta"] = mz.erp.businessrules.Sistema.DateTime.Now;
			rowUsuarios["Expiracion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			rowUsuarios["Activo"] = chkActivo.Checked;
			//Viviana
			rowUsuarios["Equipo"]=this.equipo.Value;
			if (!ultraTextEditor1.Text.Equals(uteConfirmaPassword.Text))
				rowUsuarios.SetColumnError("Clave","Las claves no coinciden");
			
			//if(this.State.Equals("NEW"))
			//{	
				for(int i=0; i < perfiles.Count; i++) //por cada item 
				{
					bool ok = false;
					Perfil p = (Perfil)perfiles[i];
					if(p.Tildado) //si esta tildado --> lo agrego (si no está)
					{
						foreach(System.Data.DataRow row in tableUsuariosPerfiles.Rows)
							if (row.RowState != System.Data.DataRowState.Deleted)
							{
								if((long)row["IdPerfil"] == Convert.ToInt64(p.IdPerfil))
								{
									row["IdUsuario"] = txtNombreUsuario.Text;
									ok = true;
									break;
								}
							}							
						if(!ok)
						{
							System.Data.DataRow row = mz.erp.businessrules.sy_PerfilesUsuariosEmpresas.NewRow();
							row["IdUsuario"]= txtNombreUsuario.Text;
							row["IdPerfil"] = p.IdPerfil;
							row["IdEmpresa"]= Security.IdEmpresa;
							tableUsuariosPerfiles.LoadDataRow(row.ItemArray, false);
						}
					}
					else //si no esta tildado
					{
						if (p.Tildado != p.EstadoInicial) // y es distinto del estado anterior -->(borrarlo de la base)
							foreach(System.Data.DataRow row in tableUsuariosPerfiles.Rows)
							{
								if (row.RowState != System.Data.DataRowState.Deleted)
								{
									string IdPerfil = Convert.ToString(row["IdPerfil"]);
									string IdUsuario = Convert.ToString(row["IdUsuario"]);
									if(p.IdPerfil == IdPerfil && txtNombreUsuario.Text == IdUsuario )
									{   //borro la tupla
										row.Delete();	
										break;
									}
								}
							}
					}
				}
			//}

			//Modifico los responsables de las secciones
			sy_UsuariosExDataset.tlg_ResponsablesDepositosSeccionesDataTable tableResponsablesSecciones = (sy_UsuariosExDataset.tlg_ResponsablesDepositosSeccionesDataTable)_data.Tables["tlg_ResponsablesDepositosSecciones"];
			string IdUsu = (string)rowUsuarios["IdUsuario"];
			foreach(TreeNode nodeD in treeViewSecciones.Nodes)
			{
				string IdDeposito = (string)idsTree[nodeD];
				foreach(TreeNode nodeS in nodeD.Nodes)
				{
					string IdSeccion = (string)idsTree[nodeS];
					sy_UsuariosExDataset.tlg_ResponsablesDepositosSeccionesRow rowRS = tableResponsablesSecciones.FindByIdUsuarioIdDepositoIdSeccion(IdUsu, IdDeposito, IdSeccion);
					if(nodeS.Checked)//si esta tildado --> lo agrego (si no está)
					{
						if(rowRS == null)
						{
							rowRS = tableResponsablesSecciones.Newtlg_ResponsablesDepositosSeccionesRow();
							rowRS.IdUsuario = IdUsu;
							rowRS.IdDeposito = IdDeposito;
							rowRS.IdSeccion = IdSeccion;
							rowRS.Activo = true;
							rowRS.FechaCreacion = DateTime.Now;
							rowRS.IdConexionCreacion =  Security.IdConexion;
							tableResponsablesSecciones.LoadDataRow(rowRS.ItemArray, false);
						}
					}
					else//si no esta tildado --> lo borro (si está)
					{
						if(rowRS != null)
						{
							rowRS.Delete();
						}
					}
				}
			}

		}

		private void ListaPerfiles_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			int x =ListaPerfiles.SelectedIndex;
			Perfil p = (Perfil)perfiles[x];
			if (ListaPerfiles.CheckedIndices.Contains(x)) p.Tildado = false;
			else p.Tildado = true;							  
		}

		private bool _processItem = true;
		private void treeViewSecciones_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if(_processItem)
			{
				_processItem = false;
				foreach(TreeNode node in e.Node.Nodes)
				{
					node.Checked = e.Node.Checked;
				}
				seleccionarDeposito();
				_processItem = true;
			}
		}
	}
}


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConfiguracionMenues.
	/// </summary>
	public class FrmConfiguracionMenues : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private System.Windows.Forms.TextBox txtId;
		private mz.erp.ui.controls.mzComboEditor mzCmbHerramientas;
		private System.Windows.Forms.CheckBox cbHabilitado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.CheckBox cbSupervisor;
		private System.Windows.Forms.CheckBox cbAdministrador;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.CheckBox cdBarraDeHerramienta;
		private System.Windows.Forms.CheckBox cdBarraDeMenu;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.TextBox txtImagen;
		private System.Windows.Forms.TextBox txtToolTip;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.CheckBox cdToolTip;
		private System.Windows.Forms.CheckBox cdImagen;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.CheckBox cbVendedor;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl cbShorcuts;
		private System.Windows.Forms.ComboBox comboBox1;
		private Herramienta _herramienta;

		public FrmConfiguracionMenues()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			Init();

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConfiguracionMenues));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.cbShorcuts = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtId = new System.Windows.Forms.TextBox();
			this.mzCmbHerramientas = new mz.erp.ui.controls.mzComboEditor();
			this.cbHabilitado = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.cbVendedor = new System.Windows.Forms.CheckBox();
			this.cbSupervisor = new System.Windows.Forms.CheckBox();
			this.cbAdministrador = new System.Windows.Forms.CheckBox();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.cdBarraDeHerramienta = new System.Windows.Forms.CheckBox();
			this.cdBarraDeMenu = new System.Windows.Forms.CheckBox();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtImagen = new System.Windows.Forms.TextBox();
			this.txtToolTip = new System.Windows.Forms.TextBox();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.cdToolTip = new System.Windows.Forms.CheckBox();
			this.cdImagen = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cbShorcuts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbHerramientas)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbShorcuts
			// 
			this.cbShorcuts.Controls.Add(this.comboBox1);
			this.cbShorcuts.Controls.Add(this.txtId);
			this.cbShorcuts.Controls.Add(this.mzCmbHerramientas);
			this.cbShorcuts.Controls.Add(this.cbHabilitado);
			this.cbShorcuts.Controls.Add(this.label2);
			this.cbShorcuts.Controls.Add(this.label1);
			this.cbShorcuts.Location = new System.Drawing.Point(28, 49);
			this.cbShorcuts.Name = "cbShorcuts";
			this.cbShorcuts.Size = new System.Drawing.Size(783, 79);
			this.cbShorcuts.TabIndex = 0;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(104, 16);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(272, 20);
			this.txtId.TabIndex = 15;
			this.txtId.Text = "";
			// 
			// mzCmbHerramientas
			// 
			this.mzCmbHerramientas.DataSource = null;
			this.mzCmbHerramientas.DisplayMember = "";
			this.mzCmbHerramientas.DisplayMemberCaption = "";
			this.mzCmbHerramientas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbHerramientas.Location = new System.Drawing.Point(104, 0);
			this.mzCmbHerramientas.MaxItemsDisplay = 7;
			this.mzCmbHerramientas.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbHerramientas.Name = "mzCmbHerramientas";
			this.mzCmbHerramientas.Size = new System.Drawing.Size(272, 21);
			this.mzCmbHerramientas.SorterMember = "";
			this.mzCmbHerramientas.TabIndex = 14;
			this.mzCmbHerramientas.ValueMember = "";
			this.mzCmbHerramientas.ValueMemberCaption = "";
			// 
			// cbHabilitado
			// 
			this.cbHabilitado.BackColor = System.Drawing.Color.Transparent;
			this.cbHabilitado.Location = new System.Drawing.Point(0, 32);
			this.cbHabilitado.Name = "cbHabilitado";
			this.cbHabilitado.Size = new System.Drawing.Size(100, 16);
			this.cbHabilitado.TabIndex = 2;
			this.cbHabilitado.Text = "Habilitado";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Id";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu Padre";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.cbVendedor);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.cbSupervisor);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.cbAdministrador);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 187);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(783, 53);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// cbVendedor
			// 
			this.cbVendedor.BackColor = System.Drawing.Color.Transparent;
			this.cbVendedor.Location = new System.Drawing.Point(0, 32);
			this.cbVendedor.Name = "cbVendedor";
			this.cbVendedor.Size = new System.Drawing.Size(100, 16);
			this.cbVendedor.TabIndex = 5;
			this.cbVendedor.Text = "Vendedor";
			// 
			// cbSupervisor
			// 
			this.cbSupervisor.BackColor = System.Drawing.Color.Transparent;
			this.cbSupervisor.Location = new System.Drawing.Point(0, 16);
			this.cbSupervisor.Name = "cbSupervisor";
			this.cbSupervisor.Size = new System.Drawing.Size(100, 16);
			this.cbSupervisor.TabIndex = 4;
			this.cbSupervisor.Text = "Supervisor";
			// 
			// cbAdministrador
			// 
			this.cbAdministrador.BackColor = System.Drawing.Color.Transparent;
			this.cbAdministrador.Location = new System.Drawing.Point(0, 0);
			this.cbAdministrador.Name = "cbAdministrador";
			this.cbAdministrador.Size = new System.Drawing.Size(100, 16);
			this.cbAdministrador.TabIndex = 3;
			this.cbAdministrador.Text = "Administrador";
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.cdBarraDeHerramienta);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.cdBarraDeMenu);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 299);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(783, 29);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// cdBarraDeHerramienta
			// 
			this.cdBarraDeHerramienta.BackColor = System.Drawing.Color.Transparent;
			this.cdBarraDeHerramienta.Location = new System.Drawing.Point(0, 16);
			this.cdBarraDeHerramienta.Name = "cdBarraDeHerramienta";
			this.cdBarraDeHerramienta.Size = new System.Drawing.Size(160, 16);
			this.cdBarraDeHerramienta.TabIndex = 7;
			this.cdBarraDeHerramienta.Text = "Barra de Herraminetas";
			// 
			// cdBarraDeMenu
			// 
			this.cdBarraDeMenu.BackColor = System.Drawing.Color.Transparent;
			this.cdBarraDeMenu.Location = new System.Drawing.Point(0, 0);
			this.cdBarraDeMenu.Name = "cdBarraDeMenu";
			this.cdBarraDeMenu.Size = new System.Drawing.Size(100, 16);
			this.cdBarraDeMenu.TabIndex = 6;
			this.cdBarraDeMenu.Text = "Barra de Menues";
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.txtImagen);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.txtToolTip);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.txtTitulo);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.cdToolTip);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.cdImagen);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.checkBox3);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 387);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(783, 61);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// txtImagen
			// 
			this.txtImagen.Enabled = false;
			this.txtImagen.Location = new System.Drawing.Point(104, 20);
			this.txtImagen.Name = "txtImagen";
			this.txtImagen.Size = new System.Drawing.Size(312, 20);
			this.txtImagen.TabIndex = 11;
			this.txtImagen.Text = "";
			// 
			// txtToolTip
			// 
			this.txtToolTip.Enabled = false;
			this.txtToolTip.Location = new System.Drawing.Point(104, 40);
			this.txtToolTip.Name = "txtToolTip";
			this.txtToolTip.Size = new System.Drawing.Size(312, 20);
			this.txtToolTip.TabIndex = 10;
			this.txtToolTip.Text = "";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Enabled = false;
			this.txtTitulo.Location = new System.Drawing.Point(104, 0);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(312, 20);
			this.txtTitulo.TabIndex = 9;
			this.txtTitulo.Text = "";
			// 
			// cdToolTip
			// 
			this.cdToolTip.BackColor = System.Drawing.Color.Transparent;
			this.cdToolTip.Location = new System.Drawing.Point(0, 40);
			this.cdToolTip.Name = "cdToolTip";
			this.cdToolTip.Size = new System.Drawing.Size(100, 20);
			this.cdToolTip.TabIndex = 8;
			this.cdToolTip.Text = "ToolTip";
			this.cdToolTip.Click += new System.EventHandler(this.cdToolTip_Click);
			// 
			// cdImagen
			// 
			this.cdImagen.BackColor = System.Drawing.Color.Transparent;
			this.cdImagen.Location = new System.Drawing.Point(0, 20);
			this.cdImagen.Name = "cdImagen";
			this.cdImagen.Size = new System.Drawing.Size(100, 20);
			this.cdImagen.TabIndex = 7;
			this.cdImagen.Text = "Imagen";
			this.cdImagen.Click += new System.EventHandler(this.cdImagen_Click);
			// 
			// checkBox3
			// 
			this.checkBox3.BackColor = System.Drawing.Color.Transparent;
			this.checkBox3.Location = new System.Drawing.Point(0, 0);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(100, 20);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "Titulo";
			this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.toolBarButton1});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(832, 28);
			this.toolBarStandar.TabIndex = 19;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 6;
			this.toolBarButton1.Text = "Agregar menu";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 6;
			this.toolBarButton9.Text = "Agregar Menu";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.cbShorcuts);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.cbShorcuts;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 79;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 53;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Perfiles";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 29;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Barras de Herramientas";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 61;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Recursos";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(832, 473);
			this.ultraExplorerBar1.TabIndex = 20;
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(104, 48);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(272, 21);
			this.comboBox1.TabIndex = 16;
			// 
			// FrmConfiguracionMenues
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(832, 501);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConfiguracionMenues";
			this.Text = "FrmConfiguracionMenues";
			this.cbShorcuts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbHerramientas)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
			
		private void Init()
		{
			mzCmbHerramientas.FillFromDataSource( mz.erp.businessrules.sy_Herramientas.GetList().sy_Herramientas, "IdHerramienta","Id",8,"Id");						
			comboBox1.Items.AddRange(Enum.GetNames(typeof(System.Windows.Forms.Shortcut)));
			
		}

		private void checkBox3_Click(object sender, System.EventArgs e)
		{
			if (this.checkBox3.Checked) txtTitulo.Enabled = true;
			else txtTitulo.Enabled = false;
		}

		private void cdImagen_Click(object sender, System.EventArgs e)
		{
			if(this.cdImagen.Checked) txtImagen.Enabled=true;		
			else txtImagen.Enabled=false;		
		}

		private void cdToolTip_Click(object sender, System.EventArgs e)
		{	
			if(this.cdToolTip.Checked) txtToolTip.Enabled=true;
			else txtToolTip.Enabled=false;
		}

		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					Commit();
					((IMainForm)this.MdiParent).CerrarSesion();
					break;

			}		
		}
		private void  Commit()
		{
			string s = "None";
			if(comboBox1.Text != "")
				s= comboBox1.Text;
			_herramienta = Factory.GetHerramienta(Convert.ToInt32(mzCmbHerramientas.Value),txtId.Text, cbHabilitado.Checked,s);
			if (cbAdministrador.Checked)
				_herramienta.AddPerfil(Constantes.IdAdministrador);
			if(cbSupervisor.Checked)
				_herramienta.AddPerfil(Constantes.IdSupervisor);
			if(cbVendedor.Checked)
				_herramienta.AddPerfil(Constantes.IdVendedor);
			if(cdBarraDeMenu.Checked)
				_herramienta.AddBarra(Constantes.IdBarraDeMenu);
			if(cdBarraDeHerramienta.Checked)
				_herramienta.AddBarra(Constantes.IdBarraDeHerramienta);
			if(cdImagen.Checked)
				_herramienta.AddRecurso(Constantes.IdRecursoImagen,txtImagen.Text);
			if(checkBox3.Checked)
				_herramienta.AddRecurso(Constantes.IdRecursoTitulo,txtTitulo.Text);
			if(cdToolTip.Checked)
				_herramienta.AddRecurso(Constantes.IdRecursoToolTip,txtToolTip.Text);
;	
			_herramienta.Commit();
		
			
		}




	}
}

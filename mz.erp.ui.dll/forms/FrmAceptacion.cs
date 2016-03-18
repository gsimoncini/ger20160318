using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAceptacion.
	/// </summary>
	public class FrmAceptacion : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;

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
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAceptacion));
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtUsuario2 = new System.Windows.Forms.Label();
			this.txtUsuario1 = new System.Windows.Forms.Label();
			this.bxComentario = new System.Windows.Forms.TextBox();
			this.bxClave2 = new System.Windows.Forms.TextBox();
			this.bxClave1 = new System.Windows.Forms.TextBox();
			this.bxMensaje = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(647, 24);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(647, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Ingreso de Claves para Confirmación";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtUsuario2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtUsuario1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bxComentario);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bxClave2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bxClave1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bxMensaje);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.DockPadding.Top = 12;
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(647, 221);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// txtUsuario2
			// 
			this.txtUsuario2.BackColor = System.Drawing.Color.Transparent;
			this.txtUsuario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUsuario2.Location = new System.Drawing.Point(16, 191);
			this.txtUsuario2.Name = "txtUsuario2";
			this.txtUsuario2.Size = new System.Drawing.Size(232, 29);
			this.txtUsuario2.TabIndex = 33;
			this.txtUsuario2.Text = "usuario 2";
			this.txtUsuario2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtUsuario1
			// 
			this.txtUsuario1.BackColor = System.Drawing.Color.Transparent;
			this.txtUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtUsuario1.Location = new System.Drawing.Point(16, 169);
			this.txtUsuario1.Name = "txtUsuario1";
			this.txtUsuario1.Size = new System.Drawing.Size(232, 24);
			this.txtUsuario1.TabIndex = 32;
			this.txtUsuario1.Text = "usuario 1";
			this.txtUsuario1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bxComentario
			// 
			this.bxComentario.Location = new System.Drawing.Point(8, 107);
			this.bxComentario.Multiline = true;
			this.bxComentario.Name = "bxComentario";
			this.bxComentario.Size = new System.Drawing.Size(632, 45);
			this.bxComentario.TabIndex = 2;
			this.bxComentario.Text = "";
			// 
			// bxClave2
			// 
			this.bxClave2.Location = new System.Drawing.Point(376, 195);
			this.bxClave2.Name = "bxClave2";
			this.bxClave2.PasswordChar = '*';
			this.bxClave2.TabIndex = 1;
			this.bxClave2.Text = "";
			// 
			// bxClave1
			// 
			this.bxClave1.Location = new System.Drawing.Point(376, 171);
			this.bxClave1.Name = "bxClave1";
			this.bxClave1.PasswordChar = '*';
			this.bxClave1.TabIndex = 0;
			this.bxClave1.Text = "";
			// 
			// bxMensaje
			// 
			this.bxMensaje.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.bxMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bxMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bxMensaje.Location = new System.Drawing.Point(8, 8);
			this.bxMensaje.Multiline = true;
			this.bxMensaje.Name = "bxMensaje";
			this.bxMensaje.ReadOnly = true;
			this.bxMensaje.Size = new System.Drawing.Size(632, 72);
			this.bxMensaje.TabIndex = 23;
			this.bxMensaje.Text = "";
			this.bxMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(264, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "Ingrese SU clave";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(264, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "Ingrese SU clave";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 24;
			this.label1.Text = "Comentario";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar1);
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 486);
			this.panel1.TabIndex = 0;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 221;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(696, 458);
			this.ultraExplorerBar1.TabIndex = 50;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.toolBarButton4,
																							  this.toolBarButton5});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(696, 28);
			this.toolBarStandar.TabIndex = 49;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 9;
			this.toolBarButton1.Text = "&Anterior";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 8;
			this.toolBarButton3.Text = "&Siguiente";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 7;
			this.toolBarButton5.Text = "&Cancelar";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// FrmAceptacion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(696, 486);
			this.Controls.Add(this.panel1);
			this.Name = "FrmAceptacion";
			this.Text = "FrmAceptacion";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label txtUsuario2;
		private System.Windows.Forms.Label txtUsuario1;
		private System.Windows.Forms.TextBox bxComentario;
		private System.Windows.Forms.TextBox bxClave2;
		private System.Windows.Forms.TextBox bxClave1;
		private System.Windows.Forms.TextBox bxMensaje;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
	
		#region Custom Members
		
		private mz.erp.ui.controllers.AceptacionController _uiController;
		
		public FrmAceptacion()
		{
			InitializeComponent();
		}

		public FrmAceptacion( mz.erp.ui.controllers.AceptacionController uiController )
		{
			InitializeComponent();
			_uiController = uiController;
		}

		
		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
		}

		private void ConfigureInterface()
		{
			KeyPreview = true;
		}

		private void InitEventHandlers()
		{
			KeyDownManager KeyDown = new KeyDownManager(this);	
		}

		private void InitDataBindings()
		{
			txtUsuario1.DataBindings.Add( "Text", _uiController, "Usuario1" );
			txtUsuario2.DataBindings.Add( "Text", _uiController, "Usuario2" );
			bxMensaje.DataBindings.Add("Text", _uiController, "Mensaje");
			bxComentario.DataBindings.Add("Text", _uiController, "Comentario");
			bxClave1.DataBindings.Add("Text", _uiController, "Clave1");
			bxClave2.DataBindings.Add("Text", _uiController, "Clave2");
		}
		private void InitializeData()
		{	

		}


		#endregion

		#region Miembros de ITaskForm

		public virtual void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();
			}
			else
			{
				if(_uiController.IsNextState())
					this._uiController.Execute();
				else
					if(_uiController.IsBackState())
					this._uiController.Previous();
			}
		}

		public void CloseForm()
		{			
			if (_uiController.PreguntarAlCancelar)
			{
				if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
					Close();
			}
			else
			{
				Close();
			}
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			Execute();
		}

	/*	public void Execute()
		{
			// TODO: agregar la implementación FrmAceptacion.Execute
			this._uiController.Execute();
		}
	*/
		public void Previous()
		{
			// TODO: agregar la implementación FrmAceptacion.Previous
			this._uiController.Previous();
		}

		#endregion

	

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					Execute();
					break;
				case 4:
					/*if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
						Close();*/
					CloseForm();
					break;
			}
		}


		public void Execute()
		{
			if (txtUsuario1.Focused)
				txtUsuario2.Focus();
			else 
				txtUsuario1.Focus();
			_uiController.Execute();
		}
	}
}

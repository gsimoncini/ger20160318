using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//using System.Security.Permissions;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmSolicitarAutorizacion.
	/// </summary>
	public class FrmSolicitarAutorizacion : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;
		private Infragistics.Win.UltraWinStatusBar.UltraStatusBar statusBar;
		private Infragistics.Win.UltraWinEditors.UltraPictureBox imageSemaphore;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMotivo;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton ttbReintentar;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		mz.erp.ui.controllers.SolicitarAutorizacionController _uiController = null;
		private HtmlRichText.HtmlRichTextBox htmlRichTextBox1;
		//bool clickprevio = false;

		public FrmSolicitarAutorizacion()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			
		}

		public FrmSolicitarAutorizacion(mz.erp.ui.controllers.SolicitarAutorizacionController controller)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//			
			InitializeComponent();
			_uiController = controller;	
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
					_uiController.OnChangeTimer -=new EventHandler(_uiController_OnChangeTimer);
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
			Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
			Infragistics.Win.UltraWinStatusBar.UltraStatusPanel ultraStatusPanel2 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSolicitarAutorizacion));
			this.statusBar = new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
			this.imageSemaphore = new Infragistics.Win.UltraWinEditors.UltraPictureBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.ttbReintentar = new System.Windows.Forms.ToolBarButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.htmlRichTextBox1 = new HtmlRichText.HtmlRichTextBox();
			this.SuspendLayout();
			// 
			// statusBar
			// 
			this.statusBar.Location = new System.Drawing.Point(0, 311);
			this.statusBar.Name = "statusBar";
			ultraStatusPanel1.Key = "ProcessMessage";
			ultraStatusPanel1.Width = 150;
			ultraStatusPanel2.Key = "ProgressBar";
			appearance1.ForeColor = System.Drawing.Color.Black;
			ultraStatusPanel2.ProgressBarInfo.Appearance = appearance1;
			ultraStatusPanel2.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Progress;
			ultraStatusPanel2.Width = 250;
			this.statusBar.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] {
																										 ultraStatusPanel1,
																										 ultraStatusPanel2});
			this.statusBar.Size = new System.Drawing.Size(640, 23);
			this.statusBar.TabIndex = 4;
			this.statusBar.Text = "statusBar";
			// 
			// imageSemaphore
			// 
			this.imageSemaphore.BorderShadowColor = System.Drawing.Color.Empty;
			this.imageSemaphore.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.imageSemaphore.Location = new System.Drawing.Point(127, 3);
			this.imageSemaphore.Name = "imageSemaphore";
			this.imageSemaphore.ScaleImage = Infragistics.Win.ScaleImage.Always;
			this.imageSemaphore.Size = new System.Drawing.Size(98, 19);
			this.imageSemaphore.TabIndex = 30;
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
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.ttbReintentar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(640, 28);
			this.toolBarStandar.TabIndex = 31;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			// ttbReintentar
			// 
			this.ttbReintentar.ImageIndex = 8;
			this.ttbReintentar.Text = "Reintentar";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 91;
			this.label2.Text = "Observaciones";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 90;
			this.label1.Text = "Datos";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtObservaciones.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtObservaciones.Location = new System.Drawing.Point(88, 64);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(536, 48);
			this.txtObservaciones.TabIndex = 88;
			this.txtObservaciones.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 93;
			this.label3.Text = "Motivo";
			// 
			// txtMotivo
			// 
			this.txtMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMotivo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.txtMotivo.Location = new System.Drawing.Point(88, 40);
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.ReadOnly = true;
			this.txtMotivo.Size = new System.Drawing.Size(536, 20);
			this.txtMotivo.TabIndex = 92;
			this.txtMotivo.Text = "";
			// 
			// htmlRichTextBox1
			// 
			this.htmlRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.htmlRichTextBox1.Location = new System.Drawing.Point(88, 120);
			this.htmlRichTextBox1.Name = "htmlRichTextBox1";
			this.htmlRichTextBox1.Size = new System.Drawing.Size(536, 184);
			this.htmlRichTextBox1.TabIndex = 94;
			this.htmlRichTextBox1.Text = "";
			// 
			// FrmSolicitarAutorizacion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(640, 334);
			this.Controls.Add(this.htmlRichTextBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.txtObservaciones);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.imageSemaphore);
			this.Name = "FrmSolicitarAutorizacion";
			this.Text = "FrmSolicitarAutorizacion";
			this.ResumeLayout(false);

		}
		#endregion


		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					//clickprevio = true;					
					_uiController.Previous();
					break;				
				case 2:
					//clickprevio = true;
					ComenzarSolicitud();
					break;

			}
		}

		public void Execute()
		{
			//this._uiController.Execute();
		}

		public void Previous()
		{
			//clickprevio = true;			
			this._uiController.Previous();
		}
		public void ShowForm()
		{
			if (_uiController.AllowShow()) 
			{
				//clickprevio = false;				
				this.Show();
				this.ComenzarSolicitud();				
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
			if (_uiController.IsValid) 
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
		}

		private void Init() 
		{			
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();	
		}
		private void ConfigureInterface() 
		{			
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();			
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			
			this.txtObservaciones.Enabled = true;
			this.txtObservaciones.ReadOnly = true;
			this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Minimum = _uiController.ProgresoMin;
			this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Maximum = _uiController.ProgresoMax;			
			this.htmlRichTextBox1.ReadOnly = true;			
			KeyPreview = true;
		}
		private void InitEventHandlers()
		{		
			//_uiController.OnShowForm +=new EventHandler(_uiController_OnShowForm);			
			_uiController.OnCloseForm +=new EventHandler(_uiController_OnCloseForm);
			_uiController.OnChangeTimer +=new EventHandler(_uiController_OnChangeTimer);			
			this.KeyDown+=new KeyEventHandler(FrmSolicitarAutorizacion_KeyDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.FrmSolicitarAutorizacion_Closing);	
			KeyDownManager KeyDownMan = new KeyDownManager(this);
		}
		private void InitializeData() 
		{	
			this.Text = _uiController.Titulo;
		}
		private void InitDataBindings() 
		{
		}


		/*private void _uiController_OnShowForm(object sender, EventArgs e)
		{
			if (_uiController.AllowShow())
			{	
				this.Text = _uiController.Titulo;
				string [] partes = _uiController.Datos.Split(';');				
				this.txtDatos.Lines = partes;
				this.txtMotivo.Text = _uiController.Motivo;
				//this.Show();
				this.statusBar.Panels["ProcessMessage"].Text = _uiController.Titulo + "...";
				this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Maximum = _uiController.ProgresoMax;
				this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Minimum = _uiController.ProgresoMin;

				this.Refresh();
				Application.DoEvents();
			}
		}*/

		private void _uiController_OnCloseForm(object sender, EventArgs e)
		{			
		}

		private void _uiController_OnChangeTimer(object sender, EventArgs e)
		{	
			this.Refresh();
			Application.DoEvents();
			Console.WriteLine("Progreso "  + _uiController.Progreso.ToString());			
			this.statusBar.Panels["ProcessMessage"].Text = _uiController.Titulo + "...";
			try 
			{
				if (_uiController.Progreso <= _uiController.ProgresoMax) 																										  																						  
				{
					this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Value = _uiController.Progreso;
				}							
				else
				{
					this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Value = _uiController.ProgresoMax;
				}
			}
			catch 
			{
			}

			this.txtObservaciones.Text = _uiController.Observaciones;
			this.Refresh();
			Application.DoEvents();
		}

		/*[PermissionSetAttribute(SecurityAction.Demand, Name="FullTrust")]
		protected override void WndProc(ref System.Windows.Forms.Message m) 
		{
			// comprobar si se cierra la ventana al pulsar en la "x"    (22/Jun/04)
			const int WM_SYSCOMMAND = 0x112;
			const int SC_CLOSE = 0xF060;
			//
			Console.WriteLine(m.Msg);
			base.WndProc(ref m);
		}	*/		
		private void ComenzarSolicitud() 
		{
			/*string [] partes = _uiController.Datos.Split(';');				
			this.txtDatos.Lines = partes;*/

			string datos = _uiController.Datos;
			this.htmlRichTextBox1.Clear();
			this.htmlRichTextBox1.AddHTML(datos);

			this.txtMotivo.Text = _uiController.Motivo;
			this.Refresh();			
			Application.DoEvents();
			ttbReintentar.Enabled = false;
			this.statusBar.Panels["ProgressBar"].ProgressBarInfo.Minimum = 0;
			_uiController.ComenzarSolicitud();
			if (!_uiController.Autorizado) 
			{
				MessageBox.Show(_uiController.Mensaje);
			}
			ttbReintentar.Enabled = true;			
		}

		private void FrmSolicitarAutorizacion_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			/*if (clickprevio == false)
			{
				_uiController.FormHasClosed();
			}			*/
		}



		private void FrmSolicitarAutorizacion_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.F4)
			{
				if(e.Modifiers == System.Windows.Forms.Keys.Control)
					this.CloseForm();
			}
		}
	}
}

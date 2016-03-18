using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmHabilitacionOpcionDeMenu.
	/// </summary>
	public class FrmHabilitacionOpcionDeMenu : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.TextBox txtOpcionPadre;
		private System.Windows.Forms.TextBox txtOpcion;
		private System.Windows.Forms.Label label4;
		private Janus.Windows.GridEX.GridEX gridPerfiles;
		private System.ComponentModel.IContainer components;



		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmHabilitacionOpcionDeMenu));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridPerfiles = new Janus.Windows.GridEX.GridEX();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.txtOpcionPadre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOpcion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridPerfiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(807, 24);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(807, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridPerfiles);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTitulo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtOpcionPadre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtOpcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.DockPadding.Top = 12;
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(807, 237);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// gridPerfiles
			// 
			this.gridPerfiles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridPerfiles.AlternatingColors = true;
			this.gridPerfiles.AutomaticSort = false;
			this.gridPerfiles.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridPerfiles.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridPerfiles.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridPerfiles.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridPerfiles.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridPerfiles.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridPerfiles.GroupByBoxVisible = false;
			this.gridPerfiles.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridPerfiles.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridPerfiles.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridPerfiles.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridPerfiles.Location = new System.Drawing.Point(408, 32);
			this.gridPerfiles.Name = "gridPerfiles";
			this.gridPerfiles.RecordNavigator = true;
			this.gridPerfiles.RecordNavigatorText = "Registro:|de";
			this.gridPerfiles.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridPerfiles.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridPerfiles.ShowEmptyFields = false;
			this.gridPerfiles.Size = new System.Drawing.Size(384, 200);
			this.gridPerfiles.TabIndex = 3;
			this.gridPerfiles.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(408, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 16);
			this.label4.TabIndex = 73;
			this.label4.Text = "Perfiles";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTitulo.Location = new System.Drawing.Point(152, 104);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(192, 22);
			this.txtTitulo.TabIndex = 2;
			this.txtTitulo.Text = "";
			// 
			// txtOpcionPadre
			// 
			this.txtOpcionPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtOpcionPadre.Location = new System.Drawing.Point(152, 40);
			this.txtOpcionPadre.Name = "txtOpcionPadre";
			this.txtOpcionPadre.Size = new System.Drawing.Size(192, 22);
			this.txtOpcionPadre.TabIndex = 0;
			this.txtOpcionPadre.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(40, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 16);
			this.label3.TabIndex = 70;
			this.label3.Text = "Título";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(40, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 69;
			this.label2.Text = "Opción padre";
			// 
			// txtOpcion
			// 
			this.txtOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtOpcion.Location = new System.Drawing.Point(152, 72);
			this.txtOpcion.Name = "txtOpcion";
			this.txtOpcion.Size = new System.Drawing.Size(192, 22);
			this.txtOpcion.TabIndex = 1;
			this.txtOpcion.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(40, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 67;
			this.label1.Text = "Opción";
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
																							  this.tbbSiguiente,
																							  this.tbbSeparator2,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(856, 28);
			this.toolBarStandar.TabIndex = 43;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
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
			this.tbbSeparator2.Visible = false;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			this.tbbCancelar.Visible = false;
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
			ultraExplorerBarGroup2.Settings.ContainerHeight = 237;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos de cabecera";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(856, 442);
			this.ultraExplorerBar1.TabIndex = 48;
			// 
			// FrmHabilitacionOpcionDeMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(856, 470);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmHabilitacionOpcionDeMenu";
			this.Text = "FrmHabilitacionOpcionDeMenu";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridPerfiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Members
	
		#endregion


		#region Variables Privadas
		private controllers.HabilitarOpcionDeMenuController _uiController = null;
		#endregion

		#region Variables Publicas
		#endregion

		#region Constructores y Destructores
		public FrmHabilitacionOpcionDeMenu( controllers.HabilitarOpcionDeMenuController controller )
		{
			InitializeComponent();
			_uiController = controller;
			Init();			
		}

		public FrmHabilitacionOpcionDeMenu()
		{			
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.HabilitarOpcionDeMenuController();	
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
				BindingController.Clear(txtOpcionPadre,"Text", _uiController, "OpcionPadre");
				BindingController.Clear(txtOpcion,"Text", _uiController, "Opcion");		
				BindingController.Clear(txtTitulo,"Text", _uiController, "Titulo");
				BindingController.Clear(gridPerfiles,"Text", _uiController, "Titulo");
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Inicializadores y Carga
		

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}

		
		private void ConfigureInterface()
		{
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	

			gridPerfiles.LayoutData = _uiController.LayoutPerfiles;
			gridPerfiles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;			

			//txtClaveAnt.Select();

			KeyPreview = true;
		}

		private void InitializeData()
		{			
		}
		private void InitEventHandlers()
		{
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		}	
	
		private void InitDataBindings()
		{						
			BindingController.Bind(txtOpcionPadre,"Text", _uiController, "OpcionPadre");
			BindingController.Bind(txtOpcion,"Text", _uiController, "Opcion");		
			BindingController.Bind(txtTitulo,"Text", _uiController, "Titulo");
			BindingController.Bind(gridPerfiles,"Text", _uiController, "Titulo");
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			

			gridPerfiles.DataBindings.Clear();
			gridPerfiles.SetDataBinding(_uiController.Perfiles, null);
		}

		private void EventsListener()
		{
			
		}

		#endregion


		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{	
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:	//Guardar					
					SaveChanges();
					break;
				case 4:	//Salir					
					//Close();
					break;
			}						
		}

		private void SaveChanges()
		{			
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			_uiController.Execute();
		}

		#region Miembros de ITaskForm

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		public void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();
				_uiController.RefreshData();
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
			Close();
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			SaveChanges();
		}


		#endregion


		private void Init() 
		{			
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;			
		}
	
	}
}

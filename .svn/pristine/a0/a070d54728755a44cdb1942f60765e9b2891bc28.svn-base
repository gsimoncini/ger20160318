using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmSeleccionarInstanciaOrdenReparacion.
	/// </summary>
	public class FrmSeleccionarInstanciaOrdenReparacion : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridInstanciasOrdenReparacion;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label labelTarea;
		private System.ComponentModel.IContainer components;

		
		#region Constructores

		public FrmSeleccionarInstanciaOrdenReparacion(SeleccionarInstanciaOrdenReparacionController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
		}

		#endregion

		#region Variables Privadas

			private SeleccionarInstanciaOrdenReparacionController _uiController;
	

		#endregion



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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSeleccionarInstanciaOrdenReparacion));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridInstanciasOrdenReparacion = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridInstanciasOrdenReparacion)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.SuspendLayout();
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
																							  this.toolBarButton7,
																							  this.tbbSiguiente,
																							  this.tbStep3,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(760, 28);
			this.toolBarStandar.TabIndex = 22;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 23;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 247;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(760, 378);
			this.ultraExplorerBar1.TabIndex = 23;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridInstanciasOrdenReparacion);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 106);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(711, 247);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridInstanciasOrdenReparacion
			// 
			this.gridInstanciasOrdenReparacion.AllowDrop = true;
			this.gridInstanciasOrdenReparacion.AutoEdit = true;
			this.gridInstanciasOrdenReparacion.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridInstanciasOrdenReparacion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridInstanciasOrdenReparacion.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridInstanciasOrdenReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridInstanciasOrdenReparacion.GroupByBoxVisible = false;
			this.gridInstanciasOrdenReparacion.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridInstanciasOrdenReparacion.LayoutData = @"<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Column1""><FormatString>c</FormatString><Key>Column1</Key><Position>0</Position><Width>81</Width></Column0></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex><SortOrder>Descending</SortOrder></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridInstanciasOrdenReparacion.Location = new System.Drawing.Point(0, 0);
			this.gridInstanciasOrdenReparacion.Name = "gridInstanciasOrdenReparacion";
			this.gridInstanciasOrdenReparacion.Size = new System.Drawing.Size(711, 247);
			this.gridInstanciasOrdenReparacion.TabIndex = 21;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(711, 23);
			this.ultraExplorerBarContainerControl1.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(711, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmSeleccionarInstanciaOrdenReparacion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(760, 406);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmSeleccionarInstanciaOrdenReparacion";
			this.Text = "FrmSeleccionarInstanciaOrdenReparacion";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridInstanciasOrdenReparacion)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		#region Metodos Privados

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}

		private void ConfigureInterface()
		{
			gridInstanciasOrdenReparacion.LayoutData = _uiController.Layout;		
			KeyPreview = true;
		}
		private void InitializeData(){}
		private void InitEventHandlers()
		{
			gridInstanciasOrdenReparacion.SelectionChanged +=new EventHandler(gridInstanciasOrdenReparacion_SelectionChanged);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
		}
		private void InitDataBindings()
		{
			gridInstanciasOrdenReparacion.SetDataBinding(_uiController.InstanciasOrdenReparacion, null);
		}

		#endregion
		
		#region Miembros de ITaskForm

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
			_uiController.Execute();
		}

		public void Execute()
		{
			
			_uiController.Execute();
		}
		public void Previous()
		{
			_uiController.Previous();
		}
		#endregion

		private void gridInstanciasOrdenReparacion_SelectionChanged(object sender, EventArgs e)
		{
			if(gridInstanciasOrdenReparacion.SelectedItems.Count > 0)
				_uiController.SelectedItem = gridInstanciasOrdenReparacion.SelectedItems[0].GetRow().DataRow;
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2://Guardar					
					_uiController.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}	
		}
	}
}

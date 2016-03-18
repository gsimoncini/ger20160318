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
	/// Descripción breve de FrmAbmProductosSucursales.
	/// </summary>
	public class FrmAbmProductosSucursales : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		protected System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnTransferir;
		private System.Windows.Forms.Button btnRemoverTodo;
		private System.Windows.Forms.Button btnTransferirTodo;
		private Janus.Windows.GridEX.GridEX gridProductosSucursales;
		private Janus.Windows.GridEX.GridEX gridSucursales;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private System.ComponentModel.IContainer components;

	
		#region Construtores

		public FrmAbmProductosSucursales(AbmProductosSucursalesController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
		}
		
		#endregion

		#region Variables Privadas

			private AbmProductosSucursalesController _uiController;

		#endregion

		#region Dispose

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

		#endregion

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmProductosSucursales));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnTransferir = new System.Windows.Forms.Button();
			this.btnRemoverTodo = new System.Windows.Forms.Button();
			this.btnTransferirTodo = new System.Windows.Forms.Button();
			this.gridProductosSucursales = new Janus.Windows.GridEX.GridEX();
			this.gridSucursales = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProductosSucursales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(958, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(958, 24);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Información general de productos en Sucursales";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridProductos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnRemover);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTransferir);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnRemoverTodo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnTransferirTodo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridProductosSucursales);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridSucursales);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(958, 373);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// gridProductos
			// 
			this.gridProductos.AllowCardSizing = false;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridProductos.GroupByBoxVisible = false;
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductos.Location = new System.Drawing.Point(0, 22);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridProductos.Size = new System.Drawing.Size(408, 152);
			this.gridProductos.TabIndex = 73;
			this.gridProductos.TabStop = false;
			// 
			// btnRemover
			// 
			this.btnRemover.Enabled = false;
			this.btnRemover.Location = new System.Drawing.Point(408, 113);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(48, 16);
			this.btnRemover.TabIndex = 72;
			this.btnRemover.Text = "<";
			// 
			// btnTransferir
			// 
			this.btnTransferir.Enabled = false;
			this.btnTransferir.Location = new System.Drawing.Point(408, 65);
			this.btnTransferir.Name = "btnTransferir";
			this.btnTransferir.Size = new System.Drawing.Size(48, 16);
			this.btnTransferir.TabIndex = 71;
			this.btnTransferir.Text = ">";
			// 
			// btnRemoverTodo
			// 
			this.btnRemoverTodo.Enabled = false;
			this.btnRemoverTodo.Location = new System.Drawing.Point(408, 97);
			this.btnRemoverTodo.Name = "btnRemoverTodo";
			this.btnRemoverTodo.Size = new System.Drawing.Size(48, 16);
			this.btnRemoverTodo.TabIndex = 70;
			this.btnRemoverTodo.Text = "<<";
			// 
			// btnTransferirTodo
			// 
			this.btnTransferirTodo.Enabled = false;
			this.btnTransferirTodo.Location = new System.Drawing.Point(408, 81);
			this.btnTransferirTodo.Name = "btnTransferirTodo";
			this.btnTransferirTodo.Size = new System.Drawing.Size(48, 16);
			this.btnTransferirTodo.TabIndex = 69;
			this.btnTransferirTodo.Text = ">>";
			// 
			// gridProductosSucursales
			// 
			this.gridProductosSucursales.AllowCardSizing = false;
			this.gridProductosSucursales.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductosSucursales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductosSucursales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridProductosSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridProductosSucursales.GroupByBoxVisible = false;
			this.gridProductosSucursales.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductosSucursales.Location = new System.Drawing.Point(456, 24);
			this.gridProductosSucursales.Name = "gridProductosSucursales";
			this.gridProductosSucursales.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridProductosSucursales.Size = new System.Drawing.Size(496, 304);
			this.gridProductosSucursales.TabIndex = 68;
			this.gridProductosSucursales.TabStop = false;
			// 
			// gridSucursales
			// 
			this.gridSucursales.AllowCardSizing = false;
			this.gridSucursales.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridSucursales.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridSucursales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridSucursales.GroupByBoxVisible = false;
			this.gridSucursales.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridSucursales.Location = new System.Drawing.Point(0, 176);
			this.gridSucursales.Name = "gridSucursales";
			this.gridSucursales.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridSucursales.Size = new System.Drawing.Size(408, 152);
			this.gridSucursales.TabIndex = 67;
			this.gridSucursales.TabStop = false;
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
			this.toolBarStandar.Size = new System.Drawing.Size(1024, 28);
			this.toolBarStandar.TabIndex = 19;
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
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 373;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(1024, 490);
			this.ultraExplorerBar1.TabIndex = 20;
			// 
			// FrmAbmProductosSucursales
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1024, 518);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmProductosSucursales";
			this.Text = "FrmAbmProductosSucursales";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridProductosSucursales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSucursales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Miembros de ITaskForm

		public void ShowForm()
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


		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
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
			Previous();
		}

		public void KeyDownNext()
		{
			Execute();
		}
		

		#endregion

		#region Metodos Privados
		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
			/*ConfigGrids();*/
		}
		private void ListenerControllerChanges( object sender, System.EventArgs e )
		{
			
		}
		private void InitEventHandlers()
		{
			_uiController.ObjectHasChanged +=new EventHandler(Refresh);
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			btnRemover.Click +=new EventHandler(btnRemover_Click);
			btnTransferir.Click +=new EventHandler(btnTransferir_Click);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}
		private void InitializeData()
		{
			RefreshData();
		}
		private void InitDataBindings()
		{
			gridProductos.SetDataBinding(_uiController.Productos, null);
			gridSucursales.SetDataBinding(_uiController.Sucursales, null);
			gridProductosSucursales.SetDataBinding(_uiController.ProductosSucursales, null);
		}
		private void RefreshData()
		{
			
		}
	
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf(e.Button) )
			{
				case 0:
					Previous();
					break;
				case 2:
					Execute();
					break;
				case 4:
					CloseForm();
					break;
			}		
		}
		private void ConfigureInterface()
		{
			gridProductos.LayoutData = _uiController.LayoutProductos;
			gridSucursales.LayoutData = _uiController.LayoutSucursales;
			gridProductosSucursales.LayoutData = _uiController.LayoutProductosSucursales;
			btnRemover.Enabled = true;
			btnTransferir.Enabled = true;
			KeyPreview = true;
		}

		#endregion

		private void Refresh(object sender, EventArgs e)
		{
			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Productos, null);
			gridSucursales.SetDataBinding(null, null);
			gridSucursales.SetDataBinding(_uiController.Sucursales, null);
			gridProductosSucursales.SetDataBinding(null, null);
			gridProductosSucursales.SetDataBinding(_uiController.ProductosSucursales, null);

		}

		private void btnRemover_Click(object sender, EventArgs e)
		{
			if(gridProductos.SelectedItems.Count == 1 && gridSucursales.SelectedItems.Count == 1)
			{
				object selectdProducto = gridProductos.SelectedItems[0].GetRow().Cells["IdProducto"].Value;
				object selectdSucursal = gridSucursales.SelectedItems[0].GetRow().Cells["IdSucursal"].Value;
				_uiController.RemoveProductoSucursal(selectdProducto, selectdSucursal);
			}
		}

		private void btnTransferir_Click(object sender, EventArgs e)
		{
			if(gridProductos.SelectedItems.Count == 1 && gridSucursales.SelectedItems.Count == 1)
			{
				object selectdProducto = gridProductos.SelectedItems[0].GetRow().Cells["IdProducto"].Value;
				object selectdSucursal = gridSucursales.SelectedItems[0].GetRow().Cells["IdSucursal"].Value;
				_uiController.AddProductoSucursal(selectdProducto, selectdSucursal);
			}
		}
	}
}

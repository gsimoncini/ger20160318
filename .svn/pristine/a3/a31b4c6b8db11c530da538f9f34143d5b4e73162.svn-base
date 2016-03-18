using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using Janus.Windows.GridEX;
using mz.erp.businessrules;
using mz.erp.ui.forms.classes;



namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmRegistrarNumerosDeSerie.
	/// </summary>
	public class FrmRegistrarNumerosDeSerie : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private System.ComponentModel.IContainer components;
		private Janus.Windows.GridEX.GridEX gridEXDetalle;





		private mz.erp.ui.controllers.RegistrarNumerosDeSerieController _uiController;


		public FrmRegistrarNumerosDeSerie(RegistrarNumerosDeSerieController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
			_uiController.OnControllerChanged += new System.EventHandler(this.ListenerControllerChanged);
		}

		public FrmRegistrarNumerosDeSerie()
		{
			InitializeComponent();
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
				_uiController.OnControllerChanged -= new System.EventHandler(this.ListenerControllerChanged);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmRegistrarNumerosDeSerie));
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridEXDetalle = new Janus.Windows.GridEX.GridEX();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEXDetalle)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(807, 24);
			this.ultraExplorerBarContainerControl2.TabIndex = 9;
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
			// ultraExplorerBarContainerControl6
			// 
			this.ultraExplorerBarContainerControl6.Controls.Add(this.gridEXDetalle);
			this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
			this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(807, 373);
			this.ultraExplorerBarContainerControl6.TabIndex = 8;
			// 
			// gridEXDetalle
			// 
			this.gridEXDetalle.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEXDetalle.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEXDetalle.ContinuousScroll = false;
			this.gridEXDetalle.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEXDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridEXDetalle.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEXDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridEXDetalle.GroupByBoxVisible = false;
			this.gridEXDetalle.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEXDetalle.Location = new System.Drawing.Point(0, 0);
			this.gridEXDetalle.Name = "gridEXDetalle";
			this.gridEXDetalle.Size = new System.Drawing.Size(807, 373);
			this.gridEXDetalle.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar1);
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(856, 534);
			this.panel1.TabIndex = 0;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl6;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 373;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Productos";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(856, 506);
			this.ultraExplorerBar1.TabIndex = 21;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(856, 28);
			this.toolBarStandar.TabIndex = 20;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick_1);
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
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// FrmRegistrarNumerosDeSerie
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(856, 534);
			this.Controls.Add(this.panel1);
			this.Name = "FrmRegistrarNumerosDeSerie";
			this.Text = "FrmRegistrarNumerosDeSerie";
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEXDetalle)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		public  void ShowForm()
		{
			
			if(this._uiController.AllowShow())
			{
				this.Init();				
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
			base.Close();
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous(); 
		}

		public void KeyDownNext()
		{
			gridEXDetalle.UpdateData();
			_uiController.Execute();
		}

		#endregion

		#region metodos privados
		

		protected void Init()
		{
			ConfigureInterface();
			Build_UI();
			InitEvents();
			//InitDataBindings();			
		}

		private void ConfigureInterface()
		{
			labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.LeyendaFormulario;
			KeyPreview = true;
		}

		private void Build_UI()
		{
			gridEXDetalle.LayoutData = _uiController.LayoutDetalle;
			if(_uiController.AllowGroup)
			{
				this.gridEXDetalle.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridEXDetalle.RootTable.Columns["Codigo"]));
			}
			gridEXDetalle.RootTable.SortKeys.Clear();
			gridEXDetalle.RootTable.SortKeys.Add(new Janus.Windows.GridEX.GridEXSortKey(gridEXDetalle.RootTable.Columns["Codigo"]));
			gridEXDetalle.RootTable.SortKeys.Add(new Janus.Windows.GridEX.GridEXSortKey(gridEXDetalle.RootTable.Columns["Item"]));
			gridEXDetalle.AutomaticSort = false;
			
			gridEXDetalle.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridEXDetalle.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextRow;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbAnterior.Text= _uiController.TextoBotonPrevio;

			tbbSiguiente.Text= _uiController.TextoBotonSiguiente;
			this.labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.LeyendaFormulario;
			gridEXDetalle.UpdateOnLeave = true;
			gridEXDetalle.UpdatingCell +=new UpdatingCellEventHandler(gridEXDetalle_UpdatingCell);
			gridEXDetalle.DataBindings.Clear();
			gridEXDetalle.SetDataBinding(_uiController.Detalle, null);
			gridEXDetalle.UpdateData();
			
			ConfigureGrid();
		}

		private void InitEvents() 
		{
			
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			//this.gridEXDetalle.KeyPress +=new KeyPressEventHandler(SpecialClickOnColumn);
			//this.gridEXDetalle.KeyDown +=new KeyEventHandler(SpecialClickOnColumn);
			//this.gridEXDetalle.UpdatingRecord +=new CancelEventHandler(gridEXDetalle_UpdatingRecord);
			gridEXDetalle.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			gridEXDetalle.Error+=new ErrorEventHandler(gridEXDetalle_Error);
			KeyDownManager KeyDownMan = new KeyDownManager(this);			
		}

		private void ConfigureGrid()
		{
			gridEXDetalle.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			gridEXDetalle.RootTable.Columns["Codigo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
			gridEXDetalle.RootTable.Columns["Descripcion"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
			gridEXDetalle.RootTable.Columns["NumeroDeSerie"].EmptyStringValue = string.Empty;
		}


		private void ListenerControllerChanged(object sender, EventArgs e)
		{			
			gridEXDetalle.UpdateData();
			gridEXDetalle.SetDataBinding(_uiController.Detalle, null);
			gridEXDetalle.DataBindings.Clear();
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: _uiController.Previous(); 
					break;
				case 2: 
				{
					gridEXDetalle.UpdateData();
					_uiController.Execute();
					break;
				}		
			}
		}
	
		
		private void SpecialClickOnColumn(object sender, KeyPressEventArgs e)
		{
			
		}


		#endregion

		private void SpecialClickOnColumn(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(System.Windows.Forms.Keys.Enter))
			{
				this.gridEXDetalle.MoveNext();
				
			}
		}

		private void gridEXDetalle_Error(object sender, ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		private void toolBarStandar_ButtonClick_1(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
		
		}

		
		private void gridEXDetalle_UpdatingRecord(object sender, CancelEventArgs e)
		{
			if(this.gridEXDetalle.SelectedItems.Count > 0)
			{
				object selectedItem = this.gridEXDetalle.SelectedItems[0].GetRow().DataRow;
				e.Cancel = !_uiController.IsEditable(selectedItem);
			}
		}

		private void gridEXDetalle_UpdatingCell(object sender, UpdatingCellEventArgs e)
		{
			if(this.gridEXDetalle.SelectedItems.Count > 0)
			{
				object selectedItem = this.gridEXDetalle.SelectedItems[0].GetRow().DataRow;

				if(!_uiController.AllowSeleccion() && !_uiController.IsEditable(selectedItem))
				{
					e.Cancel = true;
					gridEXDetalle.Refetch();
				}
			}
		}
	}
}


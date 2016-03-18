using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.controls;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
using System.Data;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmCierreMasivoOrdenReparacion.
	/// </summary>
	public class FrmCierreMasivoOrdenReparacion : System.Windows.Forms.Form,  ITaskForm
	{
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmCierreMasivoOrdenReparacion));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(814, 30);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(814, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 113);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(814, 400);
			this.ultraExplorerBarContainerControl1.TabIndex = 6;
			// 
			// gridResultado
			// 
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 32);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(814, 368);
			this.gridResultado.TabIndex = 54;
			this.gridResultado.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridResultado_FormattingRow);
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(831, 24);
			this.gridManagerView1.TabIndex = 53;
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
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.toolBarButton4,
																							  this.toolBarButton5,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(880, 28);
			this.toolBarStandar.TabIndex = 49;
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
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 10;
			this.toolBarButton2.Text = "[F2] Buscar ahora";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 4;
			this.toolBarButton4.Text = "Guardar";
			this.toolBarButton4.Visible = false;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton5.Visible = false;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 30;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 400;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Ordenes A Cerrar";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(880, 464);
			this.ultraExplorerBar1.TabIndex = 52;
			// 
			// FrmCierreMasivoOrdenReparacion
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(880, 492);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmCierreMasivoOrdenReparacion";
			this.Text = "FrmCierreMasivoOrdenReparacion";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Construtores y Destructores

		public FrmCierreMasivoOrdenReparacion(CierreMasivoOrdenReparacionController uiController)
		{
			InitializeComponent();
			_uiController = uiController;

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
				gridResultado.EditingCell-=new Janus.Windows.GridEX.EditingCellEventHandler(gridResultado_EditingCell);
			}
			base.Dispose( disposing );
		}
		#endregion

		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;

		#region Variables Privadas
		private CierreMasivoOrdenReparacionController _uiController = null;
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

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);

			KeyPreview = true;

		}

		private void InitializeData()
		{

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			_uiController.DataChanged+=new EventHandler(RefreshData);
			KeyDownManager KeyDown = new KeyDownManager(this);	
			gridResultado.EditingCell+=new Janus.Windows.GridEX.EditingCellEventHandler(gridResultado_EditingCell);
		}	
	
		private void InitDataBindings()
		{
		}

		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this.Cursor = Cursors.WaitCursor;
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			_uiController.Execute();
			this.Cursor = Cursors.Default;
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

		#endregion

		#region Metodos Privados
		private void RefreshData()
		{
			Util.MoveFocus(ultraExplorerBarContainerControl1);
			this.Cursor = Cursors.WaitCursor;
			gridResultado.Focus();
			_uiController.RefreshData();
			this.Cursor = Cursors.Default;
		}

		private void gridResultado_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}

		/*private void SaveChanges()
		{	
			this.Cursor = Cursors.WaitCursor;
    		_uiController.SaveChanges();
			MessageBox.Show("Los datos han sido guardados correctamente.","Advertencia",System.Windows.Forms.MessageBoxButtons.OK);
			this.Cursor = Cursors.Default;
		}*/

		#endregion

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			int index = toolBarStandar.Buttons.IndexOf( e.Button ) ;
			switch ( index)
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:

					this.Execute();

					break;
				case 4:					
					RefreshData();
					break;
				/*case 6:					
					this.SaveChanges();
					break;
					*/
				case 8:					
					this.CloseForm();
					break;
			}				
		}

		private void RefreshData(object sender, EventArgs e)
		{			
			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(_uiController.ResultAsTable, null);

			if (gridManagerView1.AllowGroupCollapse)
				this.gridResultado.CollapseGroups();
			else
				if (gridResultado.RootTable.Groups.Count > 0 )
				gridResultado.RootTable.Groups[0].Expand();
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.ResultAsTable);

		}

		private void gridResultado_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			if(!e.Column.Key.Equals("Marca"))
				e.Cancel = true;
		}
	}
}

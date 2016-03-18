using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmSeleccionEstadoDeItems.
	/// </summary>
	public class FrmSeleccionEstadoDeItems : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbStep3;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.Panel panel1;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components;

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
				_uiController.OnModelChanged -=new EventHandler(_uiController_OnModelChanged);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSeleccionEstadoDeItems));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(887, 23);
			this.ultraExplorerBarContainerControl1.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(887, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.panel1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 106);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(887, 318);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridEX1
			// 
			this.gridEX1.AllowDrop = true;
			this.gridEX1.AutoEdit = true;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX1.LayoutData = @"<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Column1""><FormatString>c</FormatString><Key>Column1</Key><Position>0</Position><Width>81</Width></Column0></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex><SortOrder>Descending</SortOrder></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridEX1.Location = new System.Drawing.Point(0, 24);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.Size = new System.Drawing.Size(887, 294);
			this.gridEX1.TabIndex = 21;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.gridManagerView1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(887, 24);
			this.panel1.TabIndex = 26;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(364, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(340, 24);
			this.gridManagerView1.TabIndex = 27;
			this.gridManagerView1.Visible = false;
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(164, 0);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(184, 21);
			this.comboBox1.TabIndex = 26;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 16);
			this.label2.TabIndex = 28;
			this.label2.Text = "Aplicar Estado a Todos los Items";
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
			this.toolBarStandar.Size = new System.Drawing.Size(936, 28);
			this.toolBarStandar.TabIndex = 21;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
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
			ultraExplorerBarGroup2.Settings.ContainerHeight = 318;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(936, 470);
			this.ultraExplorerBar1.TabIndex = 22;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmSeleccionEstadoDeItems
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 498);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmSeleccionEstadoDeItems";
			this.Text = "FrmSeleccionEstadoDeItems";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Member
		
		#region Variables Privadas
		private mz.erp.ui.controllers.SeleccionarEstadoItemsController _uiController;			
		#endregion

		#region Constructores
		public FrmSeleccionEstadoDeItems()
		{
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.SeleccionarEstadoItemsController();
		}
				
		public FrmSeleccionEstadoDeItems( mz.erp.ui.controllers.SeleccionarEstadoItemsController uiController )
		{
			InitializeComponent();
			_uiController = uiController;
			
		}
						
		#endregion
		
		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
		}

		private void ConfigureInterface()
		{			
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbStep3.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			
			gridEX1.LayoutData = _uiController.LayoutItems;			
			Janus.Windows.GridEX.GridEXColumnCollection col = gridEX1.RootTable.Columns;
			col["IdEstado"].Caption = _uiController.CaptionColumnaIdEstado;
			col["FechaDeEntrega"].Caption = _uiController.CaptionColumnaFechaDeEntrega;
			col["FechaDeEntrega"].FormatString = "dd/MM/yyyy HH:mm:ss";
			EstadosCollection estados = (new EstadosCollection()).GenerateFormaDeEntrega();
			foreach (Estado est in estados)
			{
				this.comboBox1.Items.Add(est.Descripcion);
			}
			labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.LeyendaFormulario;
			
			//gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridEX1);			

			KeyPreview = true;
		}	
		private void InitEventHandlers()
		{
			_uiController.OnModelChanged +=new EventHandler(_uiController_OnModelChanged);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
			this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
		}

		private void InitDataBindings()
		{
			gridEX1.SetDataBinding(_uiController.Items,null);
			//genero los datos q va a tener el combo
			EstadosCollection datosCombo = (new EstadosCollection()).GenerateFormaDeEntrega();
			//agrego el combo a la columna "FormaDeEntrega"
			Janus.Windows.GridEX.GridEXColumnCollection col = gridEX1.CurrentTable.Columns;
			col["IdEstado"].ValueList.PopulateValueList( datosCombo, "IdItem","Descripcion");
		}
		private void InitializeData() 
		{	//se modifica la forma de entrega default mediante una variable de configuración
			if (!_uiController.PreSetData)
			{
				this.comboBox1.Text = _uiController.EstadoItemDefault;	
			}
		}
		
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
			gridEX1.UpdateData();
			_uiController.Execute();
		}

		#endregion
		
		private void RefreshData( object sender, System.EventArgs e)
		{
			gridEX1.Refresh();
			gridEX1.Refetch();
		}

		private void gridEX1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
			
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf(e.Button))
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					gridEX1.UpdateData();
					_uiController.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}		
		}

		private void _uiController_OnModelChanged(object sender, EventArgs e)
		{  //hace el rebindeo 
			
			gridEX1.SetDataBinding(null,null);
			gridEX1.SetDataBinding(_uiController.Items,null);

		}

		private void comboBox1_SelectedValueChanged(object sender, System.EventArgs e)
		{
			System.Console.WriteLine(comboBox1.SelectedItem);
			_uiController.AsignarEstadoAItems((string) comboBox1.SelectedItem.ToString());
		}

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}
	}
}

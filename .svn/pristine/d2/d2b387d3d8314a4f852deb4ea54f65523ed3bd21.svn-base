using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;


namespace mz.erp.ui.forms
{
	
	/// <summary>
	/// Descripción breve de FrmCargosAdicionales.
	/// </summary>
	public class FrmCargosAdicionales : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private mz.erp.ui.controls.mzComboSearchEditor mzComboSearchTransporte;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox descripcion;
		private System.Windows.Forms.Label labelDescripcion;
		private mz.erp.ui.controls.mzComboSearchEditor mzComboSearchPersona;
		private System.Windows.Forms.Label labelProveedor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor monto;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		
		#region Variables Privadas
			private mz.erp.ui.controllers.ConceptosAdicionalesController _uiController;			
		#endregion

		#region Contructores
		public FrmCargosAdicionales()
		{
			InitializeComponent();
		}
		
		public FrmCargosAdicionales( mz.erp.ui.controllers.ConceptosAdicionalesController uiController )
		{
			InitializeComponent();
			_uiController = uiController;
			_uiController.OnModelChanged +=new EventHandler(_uiController_OnModelChanged);
		}
			
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
				_uiController.OnModelChanged -=new EventHandler(_uiController_OnModelChanged);
				BindingController.Clear(mzComboSearchTransporte, "DataValue", _uiController, "IdTransporte");
				BindingController.Clear(mzComboSearchPersona, "DataValue", _uiController, "IdPersona");
				BindingController.Clear(descripcion, "Text", _uiController, "Descripcion");	
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
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmCargosAdicionales));
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzComboSearchTransporte = new mz.erp.ui.controls.mzComboSearchEditor();
			this.mzComboSearchPersona = new mz.erp.ui.controls.mzComboSearchEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.monto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.descripcion = new System.Windows.Forms.TextBox();
			this.labelDescripcion = new System.Windows.Forms.Label();
			this.labelProveedor = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.monto)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
			this.ultraExplorerBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(759, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(759, 23);
			this.labelTarea.TabIndex = 2;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboSearchTransporte);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboSearchPersona);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.monto);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.descripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelProveedor);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(759, 111);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// mzComboSearchTransporte
			// 
			this.mzComboSearchTransporte.DataValue = "";
			this.mzComboSearchTransporte.EditObject = null;
			this.mzComboSearchTransporte.FastSearch = false;
			this.mzComboSearchTransporte.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzComboSearchTransporte.HierarchicalSearch = false;
			this.mzComboSearchTransporte.Location = new System.Drawing.Point(96, 56);
			this.mzComboSearchTransporte.Name = "mzComboSearchTransporte";
			this.mzComboSearchTransporte.SearchObject = null;
			this.mzComboSearchTransporte.SearchObjectListener = null;
			this.mzComboSearchTransporte.Size = new System.Drawing.Size(496, 22);
			this.mzComboSearchTransporte.TabIndex = 1;
			this.mzComboSearchTransporte.ValueChanged += new System.EventHandler(this.mzComboSearchTransporte_ValueChanged);
			// 
			// mzComboSearchPersona
			// 
			this.mzComboSearchPersona.DataValue = "";
			this.mzComboSearchPersona.EditObject = null;
			this.mzComboSearchPersona.FastSearch = false;
			this.mzComboSearchPersona.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzComboSearchPersona.HierarchicalSearch = false;
			this.mzComboSearchPersona.Location = new System.Drawing.Point(96, 80);
			this.mzComboSearchPersona.Name = "mzComboSearchPersona";
			this.mzComboSearchPersona.SearchObject = null;
			this.mzComboSearchPersona.SearchObjectListener = null;
			this.mzComboSearchPersona.Size = new System.Drawing.Size(496, 22);
			this.mzComboSearchPersona.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(528, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 44;
			this.label4.Text = "Total Conceptos";
			// 
			// monto
			// 
			appearance1.BackColor = System.Drawing.Color.Transparent;
			this.monto.Appearance = appearance1;
			this.monto.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
			this.monto.Enabled = false;
			this.monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.monto.Location = new System.Drawing.Point(624, 0);
			this.monto.Name = "monto";
			this.monto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.monto.PromptChar = ' ';
			this.monto.ReadOnly = true;
			this.monto.Size = new System.Drawing.Size(112, 27);
			this.monto.TabIndex = 43;
			this.monto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 40;
			this.label3.Text = "Transporte";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 39;
			this.label2.Text = "Tipo";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 38;
			this.label1.Text = "Flete";
			// 
			// descripcion
			// 
			this.descripcion.Location = new System.Drawing.Point(96, 32);
			this.descripcion.Name = "descripcion";
			this.descripcion.Size = new System.Drawing.Size(496, 20);
			this.descripcion.TabIndex = 0;
			this.descripcion.Text = "";
			this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
			// 
			// labelDescripcion
			// 
			this.labelDescripcion.BackColor = System.Drawing.Color.Transparent;
			this.labelDescripcion.Location = new System.Drawing.Point(16, 32);
			this.labelDescripcion.Name = "labelDescripcion";
			this.labelDescripcion.Size = new System.Drawing.Size(80, 23);
			this.labelDescripcion.TabIndex = 37;
			this.labelDescripcion.Text = "Observaciones";
			// 
			// labelProveedor
			// 
			this.labelProveedor.BackColor = System.Drawing.Color.Transparent;
			this.labelProveedor.Location = new System.Drawing.Point(16, 80);
			this.labelProveedor.Name = "labelProveedor";
			this.labelProveedor.Size = new System.Drawing.Size(80, 23);
			this.labelProveedor.TabIndex = 34;
			this.labelProveedor.Text = "Responsable";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 277);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(759, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridEX1
			// 
			this.gridEX1.AllowDrop = true;
			this.gridEX1.AutoEdit = true;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX1.LayoutData = @"<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""Column1""><FormatString>c</FormatString><Key>Column1</Key><Position>0</Position><Width>81</Width></Column0></Columns><GroupCondition ID="""" /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex><SortOrder>Descending</SortOrder></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridEX1.Location = new System.Drawing.Point(16, 8);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.Size = new System.Drawing.Size(720, 136);
			this.gridEX1.TabIndex = 43;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar);
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(808, 534);
			this.panel1.TabIndex = 0;
			// 
			// ultraExplorerBar
			// 
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 111;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle conceptos adicionales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Detalle de Items";
			this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																													   ultraExplorerBarGroup1,
																													   ultraExplorerBarGroup2,
																													   ultraExplorerBarGroup3});
			this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar.Name = "ultraExplorerBar"; this.ultraExplorerBar.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar.Size = new System.Drawing.Size(808, 506);
			this.ultraExplorerBar.TabIndex = 34;
			this.ultraExplorerBar.TabStop = false;
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
			this.toolBarStandar.Size = new System.Drawing.Size(808, 28);
			this.toolBarStandar.TabIndex = 22;
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
			this.tbbCancelar.Text = "Cancelar";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// FrmCargosAdicionales
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(808, 534);
			this.Controls.Add(this.panel1);
			this.Name = "FrmCargosAdicionales";
			this.Text = "FrmCargosAdicionales";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.monto)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
			this.ultraExplorerBar.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// aca se hace el rebindeo
		/// </summary>
		private void _uiController_OnModelChanged(object sender, EventArgs e)
		{  
			gridEX1.SetDataBinding(null,null);
			gridEX1.SetDataBinding(_uiController.Items,null);
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
			_uiController.Execute();
		}

		private void Build_UI()
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
			gridEX1.LayoutData = _uiController.LayoutItems;
			labelTarea.Text = _uiController.LeyendaFormulario;
			KeyPreview = true;
		}
	
		private void InitializeData() 
		{
			mzComboSearchPersona.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas);
			mzComboSearchTransporte.SearchObject = typeof( mz.erp.ui.forms.classes.tlg_Transportes);
		}
		
		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}	

		private void InitDataBindings()
		{
			gridEX1.SetDataBinding(_uiController.Items, null);
			BindingController.Bind(mzComboSearchTransporte, "DataValue", _uiController, "IdTransporte");
			BindingController.Bind(mzComboSearchPersona, "DataValue", _uiController, "IdPersona");
			BindingController.Bind(descripcion, "Text", _uiController, "Descripcion");	
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf(e.Button))
			{

				case 0: 
					_uiController.Previous();
					break;
				case 2: 
					_uiController.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}		
		}

		private void mzComboSearchTransporte_ValueChanged(object sender, System.EventArgs e)
		{
			if (mzComboSearchTransporte.SelectedRow != null)
			{
				monto.Value = mzComboSearchTransporte.SelectedRow["Valor1"];			
				_uiController.Monto = Convert.ToDecimal(monto.Value);
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			//el cambio de esto es escuchado por la factura, 
			//si esta checked = False, entonces se le incrementa el valor a la factura actual
		}

		private void descripcion_TextChanged(object sender, System.EventArgs e)
		{
	
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

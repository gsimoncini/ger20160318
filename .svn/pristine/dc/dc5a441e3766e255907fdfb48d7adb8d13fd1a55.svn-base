using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmABMComprobantesCategoriaIva.
	/// </summary>
	public class FrmABMComprobantesCategoriaIva : System.Windows.Forms.Form,ITaskForm
	{
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelLeyenda;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label1;
		private mz.erp.ui.controls.mzComboEditor mzCategoriaIva;
		private System.Windows.Forms.Label labelTarea;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkListTiposDeComprobantes;
		private System.Windows.Forms.Label label25;
		private Infragistics.Win.Misc.UltraButton bNingunoTiposDeComprobantes;
		private Infragistics.Win.Misc.UltraButton bTodosTiposDeComprobantes;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private System.ComponentModel.IContainer components;

		public FrmABMComprobantesCategoriaIva()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			Build_UI();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmABMComprobantesCategoriaIva(ABMComprobantesCategoriaIvaController controller)
		{
			InitializeComponent();
			_uiController=controller;
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
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMComprobantesCategoriaIva));
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.labelLeyenda = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label25 = new System.Windows.Forms.Label();
			this.chkListTiposDeComprobantes = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.mzCategoriaIva = new mz.erp.ui.controls.mzComboEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.bTodosTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.bNingunoTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCategoriaIva)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelLeyenda);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(884, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(884, 23);
			this.labelTarea.TabIndex = 4;
			this.labelTarea.Text = "tareaa";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelLeyenda
			// 
			this.labelLeyenda.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLeyenda.Location = new System.Drawing.Point(0, 0);
			this.labelLeyenda.Name = "labelLeyenda";
			this.labelLeyenda.Size = new System.Drawing.Size(958, 24);
			this.labelLeyenda.TabIndex = 0;
			this.labelLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label25);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkListTiposDeComprobantes);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCategoriaIva);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bTodosTiposDeComprobantes);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bNingunoTiposDeComprobantes);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(884, 294);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(0, 56);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(608, 24);
			this.label25.TabIndex = 116;
			this.label25.Text = "Seleccione lo/s Tipo/s de Comprobante/s a lo/s cual/es se asocia la categoria de " +
				"I.V.A";
			// 
			// chkListTiposDeComprobantes
			// 
			this.chkListTiposDeComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkListTiposDeComprobantes.Location = new System.Drawing.Point(0, 88);
			this.chkListTiposDeComprobantes.MultiColumn = true;
			this.chkListTiposDeComprobantes.Name = "chkListTiposDeComprobantes";
			this.chkListTiposDeComprobantes.Size = new System.Drawing.Size(878, 154);
			this.chkListTiposDeComprobantes.TabIndex = 115;
			// 
			// mzCategoriaIva
			// 
			this.mzCategoriaIva.AutoComplete = true;
			this.mzCategoriaIva.DataSource = null;
			this.mzCategoriaIva.DisplayMember = "";
			this.mzCategoriaIva.DisplayMemberCaption = "";
			this.mzCategoriaIva.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCategoriaIva.Location = new System.Drawing.Point(80, 16);
			this.mzCategoriaIva.MaxItemsDisplay = 50;
			this.mzCategoriaIva.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCategoriaIva.Name = "mzCategoriaIva";
			this.mzCategoriaIva.Size = new System.Drawing.Size(160, 21);
			this.mzCategoriaIva.SorterMember = "";
			this.mzCategoriaIva.TabIndex = 114;
			this.mzCategoriaIva.ValueMember = "";
			this.mzCategoriaIva.ValueMemberCaption = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(0, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Categoria I.V.A:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// bTodosTiposDeComprobantes
			// 
			this.bTodosTiposDeComprobantes.AcceptsFocus = false;
			this.bTodosTiposDeComprobantes.Location = new System.Drawing.Point(0, 264);
			this.bTodosTiposDeComprobantes.Name = "bTodosTiposDeComprobantes";
			this.bTodosTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bTodosTiposDeComprobantes.TabIndex = 25;
			this.bTodosTiposDeComprobantes.TabStop = false;
			this.bTodosTiposDeComprobantes.Text = "&Todos";
			// 
			// bNingunoTiposDeComprobantes
			// 
			this.bNingunoTiposDeComprobantes.AcceptsFocus = false;
			this.bNingunoTiposDeComprobantes.Location = new System.Drawing.Point(72, 264);
			this.bNingunoTiposDeComprobantes.Name = "bNingunoTiposDeComprobantes";
			this.bNingunoTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bNingunoTiposDeComprobantes.TabIndex = 26;
			this.bNingunoTiposDeComprobantes.TabStop = false;
			this.bNingunoTiposDeComprobantes.Text = "&Ninguno";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 460);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(884, 216);
			this.ultraExplorerBarContainerControl2.TabIndex = 3;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(884, 24);
			this.gridManagerView1.TabIndex = 91;
			this.gridManagerView1.Visible = false;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.AlternatingColors = true;
			this.gridResultado.AutomaticSort = false;
			this.gridResultado.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridResultado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridResultado.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridResultado.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridResultado.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridResultado.Location = new System.Drawing.Point(0, 20);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.RecordNavigatorText = "Registro:|de";
			this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridResultado.ShowEmptyFields = false;
			this.gridResultado.Size = new System.Drawing.Size(878, 154);
			this.gridResultado.TabIndex = 90;
			this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(0, 184);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(64, 22);
			this.btnEliminar.TabIndex = 89;
			this.btnEliminar.Text = "&Eliminar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Key = "Leyenda";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Leyenda";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Key = "DatosGenerales";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 294;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "Modificaciones";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 216;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Modificaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 32);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(950, 496);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
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
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(952, 28);
			this.toolBarStandar.TabIndex = 20;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.Enabled = false;
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
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// FrmABMComprobantesCategoriaIva
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(952, 526);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Name = "FrmABMComprobantesCategoriaIva";
			this.Text = "FrmABMComprobantesCategoriaIva";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCategoriaIva)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
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
			this.siguiente();
		}

		#endregion
		#region variables privadas
		ABMComprobantesCategoriaIvaController _uiController= new ABMComprobantesCategoriaIvaController();
		private ArrayList _seleccionados=new ArrayList();
		private ArrayList _deseleccionados=new ArrayList();
		#endregion
		# region metodos publicos
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{//Reconoce los botones por el orden en la barra, ver en la barra, propiedades buttons, es el orden q se ve a la izq
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					//Presiono el boton de anterior
					_uiController.Previous();
					break;
				case 2:
					//Presiono el boton de siguiente o guardar
					//mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
					this.siguiente();
					break;
				case 4:
					//Presiono el boton de Cancelar
					/*if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
						Close();*/
					CloseForm();
					break;
			}		
		}
		protected void Build_UI()
		{
			ConfigureInterface();	
			//FillControls();
			InitEventHandlers();
			InitDataBindings();		
			InitializeData();
		}

		private void siguiente()
		{
				 this.guardar();
				_uiController.Execute();
			
			
		}
		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.bTodosTiposDeComprobantes.Click+=new EventHandler(bTodosTiposDeComprobantes_Click);
			this.bNingunoTiposDeComprobantes.Click+=new EventHandler(bNingunoTiposDeComprobantes_Click);
			this.mzCategoriaIva.ValueChanged+=new EventHandler(mzCategoriaIva_ValueChanged);
			//this.chkListTiposDeComprobantes.ItemCheck+=new ItemCheckEventHandler(chkListTiposDeComprobantes_ItemCheck);
			_uiController.ModificacionesHasChanged+=new EventHandler(_uiController_ModificacionesHasChanged);
			this.btnEliminar.Click+=new EventHandler(btnEliminar_Click);
			KeyDownManager KeyDown = new KeyDownManager(this);
			
		}
		
		private void ConfigureInterface()
		{
			//Toma los valores definidos en la bd
			this.tbbAnterior.Text=_uiController.TextoBotonAnterior;
			this.tbbSiguiente.Text=_uiController.TextoBotonSiguiente;
			this.labelTarea.Text=_uiController.Leyenda;
			this.mzCategoriaIva.FillFromDataSource(_uiController.CategoriasIva,"IdCategoriaIva","IdCategoriaIva" ,100,"IdCategoriaIva");
			this.tbbAnterior.Enabled=false;
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);
			KeyPreview = true;
		}

		private void InitializeData()
		{			
			
			this.CargarTiposDeComprobantes();

		}
		private void InitDataBindings()
		{			
			
			BindingController.Bind(mzCategoriaIva,"Value", _uiController, "IdCategoriaIva");
			this.gridResultado.SetDataBinding(_uiController.Modificaciones, null );
						
		}
		#endregion

		//Seleccionar todos los comprobantes
		private void bTodosTiposDeComprobantes_Click(object sender, EventArgs e)
		{
			CargarTiposDeComprobantes(true);
		}
		//Desselecciona todos
		private void bNingunoTiposDeComprobantes_Click(object sender, EventArgs e)
		{
			CargarTiposDeComprobantes(false);
		}
		//Cuando selecciona uno en la vista
		private void chkListTiposDeComprobantes_ItemCheck(object sender, ItemCheckEventArgs e)
		{

		}
		private void btnEliminar_Click(object sender, System.EventArgs e)
		{	string idCategoriaIva = (string)gridResultado.SelectedItems[0].GetRow().Cells["CategoriaIva"].Value;
			string idTipoComprobante = (string)gridResultado.SelectedItems[0].GetRow().Cells["TipoComprobante"].Value;
			//Primero guarda los cambios q pudo haber hecho en el listbox y deppe avisa q se elimino una fila de la grilla
			this.guardar();
			_uiController.EliminarDeGrilla(idCategoriaIva,idTipoComprobante);
			this.CargarTiposDeComprobantes();		
		}

		private void CargarTiposDeComprobantes(bool checkState)
		{
			chkListTiposDeComprobantes.Items.Clear();
			ArrayList comprobantes= _uiController.ComprobantesAsociados();
			foreach(object tc in comprobantes)
			{	
				chkListTiposDeComprobantes.Items.Add(tc, checkState);
			}
			
		}
		private void CargarTiposDeComprobantes()
		{
			chkListTiposDeComprobantes.Items.Clear();
			ArrayList comprobantes= _uiController.ComprobantesAsociados();
			foreach(object tc in comprobantes)
			{	bool checkState=_uiController.Activo(tc);
				chkListTiposDeComprobantes.Items.Add(tc, checkState);
			}
		}
		
		//Tiene q recargar lo de abajo dejando seleccionados los de esa categoria
		private void mzCategoriaIva_ValueChanged(object sender, EventArgs e)
		{	//manda a guardar los cambios q hizo el usuario en la vista
			this.actualizarSeleccion();
			_uiController.AsociarNuevosComprobantes(_seleccionados,_deseleccionados);
			//Carga los comprobantes de la nueva categoria
			if (Convert.ToString((mzCategoriaIva.Value))!="")
				_uiController.IdCategoriaIva=Convert.ToString((mzCategoriaIva.Value));
			this.CargarTiposDeComprobantes();
			
		

			
			
		}
		private void guardar()
		{
			this.actualizarSeleccion();
			_uiController.AsociarNuevosComprobantes(_seleccionados,_deseleccionados);
		}
	
		
		private void actualizarSeleccion()
		{
			_seleccionados=new ArrayList();
			_deseleccionados= new ArrayList();
			foreach(object o in chkListTiposDeComprobantes.Items)
			{
				if(chkListTiposDeComprobantes.CheckedItems.Contains(o))
					_seleccionados.Add(o);
				else _deseleccionados.Add(o);
			}
		}

		private void _uiController_ModificacionesHasChanged(object sender, EventArgs e)
		{
			this.gridResultado.SetDataBinding( null, null );
			this.gridResultado.SetDataBinding(_uiController.Modificaciones, null );
		}
	}	  
	  

}

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
	/// Descripción breve de FrmAbmTiposDeAjusteStock.
	/// </summary>
	public class FrmAbmTiposDeAjusteStock : System.Windows.Forms.Form, ITaskForm 
	{
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		protected System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		protected System.Windows.Forms.ToolBarButton toolBarButton5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl datosGeneralesContainer;
		private System.Windows.Forms.CheckBox chActivo;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioNegativa;
		private System.Windows.Forms.RadioButton radioPositiva;
		private mz.erp.ui.controls.mzComboEditor mzComboEstadoDeStock;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescripcion;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbTipoAjuste;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.CheckBox chSistema;
		private System.Windows.Forms.CheckBox chAfectaSeguimiento;

		private ABMTiposDeAjusteStockController _uiController;

		public FrmAbmTiposDeAjusteStock(ABMTiposDeAjusteStockController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
		}

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
			this.DumpControls();
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

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitializeMembers();
			InitDataBindings();
			//FillControls();
		}

		private void ConfigureInterface()
		{
			Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;
			chActivo.Checked = true;
			chSistema.Checked = false;
			chAfectaSeguimiento.Checked = false;
			if (!_uiController.PerteneceAPerfilSuperior)
			{
				chSistema.Visible = false;
			}
			KeyPreview = true;
			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessName(), _uiController.GetTaskName());
		}

		private void InitEventHandlers()
		{
			mzCmbTipoAjuste.ValueChanged += new EventHandler(mzCmbTipoAjuste_ValueChanged);
			toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(toolBar1_ButtonClick);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}

		private void InitializeData()
		{
			RefreshData();
		}

		protected void InitializeMembers()
		{
			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar1.Groups.Exists(grupo))
						this.ultraExplorerBar1.Groups[grupo].Visible = true;
				}
			}

			if(!_uiController.ContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar1.Groups.Exists(grupo))
					{
						if (this.ultraExplorerBar1.Groups[grupo].Container != null)
						{
							this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;}
						this.ultraExplorerBar1.Groups[grupo].Enabled = true;}
				}
			}

			mzCmbTipoAjuste.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_TiposDeAjuste);
			mzComboEstadoDeStock.FillFromDataSource( businessrules.tlg_EstadosDeStock.GetList().tlg_EstadosDeStock, "IdEstadoDeStock", "Descripcion", 8, "ID", "Descripcion", "Descripcion" );
		}

		private void InitDataBindings()
		{		
		}

		//se ejecuta al levantar la ventana
		protected void FillControls()
		{
			txtDescripcion.Text = _uiController.Descripcion;
			mzComboEstadoDeStock.Value = _uiController.IdEstadoDeStock;
			short operacion = _uiController.Operacion;
			if (operacion == 1)
			{
				radioPositiva.Checked = true;
			}
			else
			{
				radioNegativa.Checked = true;
			}
			chActivo.Checked = _uiController.Activo;
			chSistema.Checked = _uiController.Sistema;
			chAfectaSeguimiento.Checked = _uiController.AfectaSeguimientoArticulosFisico;

		}

		//se ejecuta al intentar guardar
		protected void DumpControls()
		{
			_uiController.IdEstadoDeStock = mzComboEstadoDeStock.Value.ToString();
			_uiController.Descripcion = txtDescripcion.Text;
			if (radioPositiva.Checked)
			{
				_uiController.Operacion = 1;
			}
			else
			{
				_uiController.Operacion = -1;
			}
			_uiController.Activo = chActivo.Checked;
			_uiController.Sistema = chSistema.Checked;
			_uiController.AfectaSeguimientoArticulosFisico = chAfectaSeguimiento.Checked;
		}

		/*private void Componentes_Changes( object sender, System.EventArgs e )
		{				
		}*/

		private void RefreshData()
		{
			string idTipoAjuste = (string) mzCmbTipoAjuste.DataValue;
			if(idTipoAjuste != null && idTipoAjuste != string.Empty && idTipoAjuste != _uiController.IdTipoAjusteStock)
			{
				_uiController.IdTipoAjusteStock = idTipoAjuste;
				FillControls();
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmTiposDeAjusteStock));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmbTipoAjuste = new mz.erp.ui.controls.mzComboSearchEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.datosGeneralesContainer = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chAfectaSeguimiento = new System.Windows.Forms.CheckBox();
			this.chSistema = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioNegativa = new System.Windows.Forms.RadioButton();
			this.radioPositiva = new System.Windows.Forms.RadioButton();
			this.mzComboEstadoDeStock = new mz.erp.ui.controls.mzComboEditor();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.chActivo = new System.Windows.Forms.CheckBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.datosGeneralesContainer.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEstadoDeStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(758, 39);
			this.ultraExplorerBarContainerControl4.TabIndex = 5;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(758, 32);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTipoAjuste);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 122);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(758, 38);
			this.ultraExplorerBarContainerControl1.TabIndex = 7;
			// 
			// mzCmbTipoAjuste
			// 
			this.mzCmbTipoAjuste.DataValue = "";
			this.mzCmbTipoAjuste.EditObject = null;
			this.mzCmbTipoAjuste.FastSearch = false;
			this.mzCmbTipoAjuste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbTipoAjuste.HierarchicalSearch = false;
			this.mzCmbTipoAjuste.Location = new System.Drawing.Point(134, 8);
			this.mzCmbTipoAjuste.Name = "mzCmbTipoAjuste";
			this.mzCmbTipoAjuste.ReadOnly = false;
			this.mzCmbTipoAjuste.SearchObject = null;
			this.mzCmbTipoAjuste.SearchObjectListener = null;
			this.mzCmbTipoAjuste.Size = new System.Drawing.Size(496, 22);
			this.mzCmbTipoAjuste.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(32, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 35;
			this.label3.Text = "Tipo de Ajuste";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// datosGeneralesContainer
			// 
			this.datosGeneralesContainer.Controls.Add(this.chAfectaSeguimiento);
			this.datosGeneralesContainer.Controls.Add(this.chSistema);
			this.datosGeneralesContainer.Controls.Add(this.label1);
			this.datosGeneralesContainer.Controls.Add(this.groupBox1);
			this.datosGeneralesContainer.Controls.Add(this.mzComboEstadoDeStock);
			this.datosGeneralesContainer.Controls.Add(this.label9);
			this.datosGeneralesContainer.Controls.Add(this.label4);
			this.datosGeneralesContainer.Controls.Add(this.txtDescripcion);
			this.datosGeneralesContainer.Controls.Add(this.chActivo);
			this.datosGeneralesContainer.Location = new System.Drawing.Point(28, 219);
			this.datosGeneralesContainer.Name = "datosGeneralesContainer";
			this.datosGeneralesContainer.Size = new System.Drawing.Size(758, 125);
			this.datosGeneralesContainer.TabIndex = 0;
			// 
			// chAfectaSeguimiento
			// 
			this.chAfectaSeguimiento.BackColor = System.Drawing.Color.Transparent;
			this.chAfectaSeguimiento.Checked = true;
			this.chAfectaSeguimiento.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chAfectaSeguimiento.Location = new System.Drawing.Point(440, 112);
			this.chAfectaSeguimiento.Name = "chAfectaSeguimiento";
			this.chAfectaSeguimiento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chAfectaSeguimiento.Size = new System.Drawing.Size(224, 16);
			this.chAfectaSeguimiento.TabIndex = 6;
			this.chAfectaSeguimiento.Text = "Afecta Seguimiento De Articulos Fisico ";
			this.chAfectaSeguimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chSistema
			// 
			this.chSistema.BackColor = System.Drawing.Color.Transparent;
			this.chSistema.Checked = true;
			this.chSistema.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chSistema.Location = new System.Drawing.Point(256, 112);
			this.chSistema.Name = "chSistema";
			this.chSistema.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chSistema.Size = new System.Drawing.Size(72, 16);
			this.chSistema.TabIndex = 5;
			this.chSistema.Text = "Sistema";
			this.chSistema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(24, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 47;
			this.label1.Text = "Operación";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioNegativa);
			this.groupBox1.Controls.Add(this.radioPositiva);
			this.groupBox1.Location = new System.Drawing.Point(128, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(120, 48);
			this.groupBox1.TabIndex = 46;
			this.groupBox1.TabStop = false;
			// 
			// radioNegativa
			// 
			this.radioNegativa.Location = new System.Drawing.Point(8, 27);
			this.radioNegativa.Name = "radioNegativa";
			this.radioNegativa.Size = new System.Drawing.Size(104, 16);
			this.radioNegativa.TabIndex = 3;
			this.radioNegativa.Text = "Negativa";
			// 
			// radioPositiva
			// 
			this.radioPositiva.Checked = true;
			this.radioPositiva.Location = new System.Drawing.Point(8, 12);
			this.radioPositiva.Name = "radioPositiva";
			this.radioPositiva.Size = new System.Drawing.Size(104, 16);
			this.radioPositiva.TabIndex = 2;
			this.radioPositiva.TabStop = true;
			this.radioPositiva.Text = "Positiva";
			// 
			// mzComboEstadoDeStock
			// 
			this.mzComboEstadoDeStock.AutoComplete = true;
			this.mzComboEstadoDeStock.DataSource = null;
			this.mzComboEstadoDeStock.DisplayMember = "";
			this.mzComboEstadoDeStock.DisplayMemberCaption = "";
			this.mzComboEstadoDeStock.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEstadoDeStock.Location = new System.Drawing.Point(128, 32);
			this.mzComboEstadoDeStock.MaxItemsDisplay = 7;
			this.mzComboEstadoDeStock.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEstadoDeStock.Name = "mzComboEstadoDeStock";
			this.mzComboEstadoDeStock.Size = new System.Drawing.Size(345, 21);
			this.mzComboEstadoDeStock.SorterMember = "";
			this.mzComboEstadoDeStock.TabIndex = 1;
			this.mzComboEstadoDeStock.ValueMember = "";
			this.mzComboEstadoDeStock.ValueMemberCaption = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(24, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 44;
			this.label9.Text = "Stock Afectado";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(24, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 43;
			this.label4.Text = "Descripción";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(128, 8);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(345, 20);
			this.txtDescripcion.TabIndex = 0;
			this.txtDescripcion.Text = "";
			// 
			// chActivo
			// 
			this.chActivo.BackColor = System.Drawing.Color.Transparent;
			this.chActivo.Checked = true;
			this.chActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chActivo.Location = new System.Drawing.Point(24, 112);
			this.chActivo.Name = "chActivo";
			this.chActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chActivo.Size = new System.Drawing.Size(64, 16);
			this.chActivo.TabIndex = 4;
			this.chActivo.Text = "Activo";
			this.chActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5});
			this.toolBar1.ButtonSize = new System.Drawing.Size(77, 22);
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imglStandar;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(824, 28);
			this.toolBar1.TabIndex = 22;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
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
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.datosGeneralesContainer);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Key = "Tarea";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 39;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Enabled = false;
			ultraExplorerBarGroup2.Key = "Ajustes de Stock";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 38;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Ajustes de Stock";
			ultraExplorerBarGroup2.Visible = false;
			ultraExplorerBarGroup3.Container = this.datosGeneralesContainer;
			ultraExplorerBarGroup3.Enabled = false;
			ultraExplorerBarGroup3.Key = "Datos Generales";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 125;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Datos Generales";
			ultraExplorerBarGroup3.Visible = false;
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(824, 362);
			this.ultraExplorerBar1.TabIndex = 23;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmAbmTiposDeAjusteStock
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(824, 390);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBar1);
			this.Name = "FrmAbmTiposDeAjusteStock";
			this.Text = "FrmAbmTiposDeAjusteStock";
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.datosGeneralesContainer.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzComboEstadoDeStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void mzCmbTipoAjuste_ValueChanged(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{ 
			switch ( toolBar1.Buttons.IndexOf(e.Button) )
			{
				case 0: //Anterior
					Previous();
					break;
				case 2: //Siguiente
					Execute();
					break;			
				case 4:	//Cancelar					
					CloseForm();
					break;
			}		
		}
	}
}

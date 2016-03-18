using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmABMLocalidadesWorkflow.
	/// </summary>
	public class FrmABMLocalidadesWorkflow : System.Windows.Forms.Form,ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ImageList imageList1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelLeyenda;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private System.Windows.Forms.TextBox txtCodigoPostal;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private mz.erp.ui.controls.mzComboEditor mzCmbPais;
		private mz.erp.ui.controls.mzComboEditor mzCmbProvincia;
		private System.Windows.Forms.TextBox txtNombre;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private mz.erp.ui.controls.mzComboEditor mzCmbPaisEditar;
		private mz.erp.ui.controls.mzComboEditor mzCmbPciaEditar;
		private mz.erp.ui.controls.mzComboEditor mzCmbLocEditar;
		private System.Windows.Forms.Label labelTarea;
		private System.ComponentModel.IContainer components;

		public FrmABMLocalidadesWorkflow()
		{
			InitializeComponent();
			//controlador asociado al form q se comunicara con tarea en el workflow
			_uiController = new ABMLocalidadesController();
			Build_UI();
	
		}
		public FrmABMLocalidadesWorkflow(ABMLocalidadesController controllers)
		{
			// Se generasolo el initializeComponent
			InitializeComponent();
			//controlador asociado al form q se comunicara con tarea en el workflow
			_uiController = controllers;
			
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMLocalidadesWorkflow));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelLeyenda = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmbLocEditar = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbPaisEditar = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbPciaEditar = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmbPais = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbProvincia = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.txtCodigoPostal = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbLocEditar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPaisEditar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPciaEditar)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPais)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProvincia)).BeginInit();
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
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(743, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelLeyenda
			// 
			this.labelLeyenda.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLeyenda.Location = new System.Drawing.Point(0, 0);
			this.labelLeyenda.Name = "labelLeyenda";
			this.labelLeyenda.Size = new System.Drawing.Size(958, 24);
			this.labelLeyenda.TabIndex = 0;
			this.labelLeyenda.Text = "ABM Localidades";
			this.labelLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbLocEditar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbPaisEditar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbPciaEditar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(743, 69);
			this.ultraExplorerBarContainerControl2.TabIndex = 0;
			// 
			// mzCmbLocEditar
			// 
			this.mzCmbLocEditar.AutoComplete = true;
			this.mzCmbLocEditar.DataSource = null;
			this.mzCmbLocEditar.DisplayMember = "";
			this.mzCmbLocEditar.DisplayMemberCaption = "";
			this.mzCmbLocEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbLocEditar.Location = new System.Drawing.Point(64, 48);
			this.mzCmbLocEditar.MaxItemsDisplay = 7;
			this.mzCmbLocEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbLocEditar.Name = "mzCmbLocEditar";
			this.mzCmbLocEditar.Size = new System.Drawing.Size(272, 21);
			this.mzCmbLocEditar.SorterMember = "";
			this.mzCmbLocEditar.TabIndex = 2;
			this.mzCmbLocEditar.ValueMember = "";
			this.mzCmbLocEditar.ValueMemberCaption = "";
			// 
			// ultraLabel7
			// 
			this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel7.Location = new System.Drawing.Point(0, 51);
			this.ultraLabel7.Name = "ultraLabel7";
			this.ultraLabel7.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel7.TabIndex = 126;
			this.ultraLabel7.Text = "Localidad";
			// 
			// mzCmbPaisEditar
			// 
			this.mzCmbPaisEditar.AutoComplete = true;
			this.mzCmbPaisEditar.DataSource = null;
			this.mzCmbPaisEditar.DisplayMember = "";
			this.mzCmbPaisEditar.DisplayMemberCaption = "";
			this.mzCmbPaisEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbPaisEditar.Location = new System.Drawing.Point(64, 0);
			this.mzCmbPaisEditar.MaxItemsDisplay = 7;
			this.mzCmbPaisEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbPaisEditar.Name = "mzCmbPaisEditar";
			this.mzCmbPaisEditar.Size = new System.Drawing.Size(272, 21);
			this.mzCmbPaisEditar.SorterMember = "";
			this.mzCmbPaisEditar.TabIndex = 0;
			this.mzCmbPaisEditar.ValueMember = "";
			this.mzCmbPaisEditar.ValueMemberCaption = "";
			// 
			// mzCmbPciaEditar
			// 
			this.mzCmbPciaEditar.AutoComplete = true;
			this.mzCmbPciaEditar.DataSource = null;
			this.mzCmbPciaEditar.DisplayMember = "";
			this.mzCmbPciaEditar.DisplayMemberCaption = "";
			this.mzCmbPciaEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbPciaEditar.Location = new System.Drawing.Point(64, 24);
			this.mzCmbPciaEditar.MaxItemsDisplay = 7;
			this.mzCmbPciaEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbPciaEditar.Name = "mzCmbPciaEditar";
			this.mzCmbPciaEditar.Size = new System.Drawing.Size(272, 21);
			this.mzCmbPciaEditar.SorterMember = "";
			this.mzCmbPciaEditar.TabIndex = 1;
			this.mzCmbPciaEditar.ValueMember = "";
			this.mzCmbPciaEditar.ValueMemberCaption = "";
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(0, 27);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel4.TabIndex = 123;
			this.ultraLabel4.Text = "Provincia";
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(0, 2);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel6.TabIndex = 122;
			this.ultraLabel6.Text = "País";
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbPais);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbProvincia);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCodigoPostal);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNombre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 235);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(743, 53);
			this.ultraExplorerBarContainerControl1.TabIndex = 1;
			// 
			// mzCmbPais
			// 
			this.mzCmbPais.AutoComplete = true;
			this.mzCmbPais.DataSource = null;
			this.mzCmbPais.DisplayMember = "";
			this.mzCmbPais.DisplayMemberCaption = "";
			this.mzCmbPais.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbPais.Location = new System.Drawing.Point(64, 0);
			this.mzCmbPais.MaxItemsDisplay = 7;
			this.mzCmbPais.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbPais.Name = "mzCmbPais";
			this.mzCmbPais.Size = new System.Drawing.Size(272, 21);
			this.mzCmbPais.SorterMember = "";
			this.mzCmbPais.TabIndex = 0;
			this.mzCmbPais.ValueMember = "";
			this.mzCmbPais.ValueMemberCaption = "";
			// 
			// mzCmbProvincia
			// 
			this.mzCmbProvincia.AutoComplete = true;
			this.mzCmbProvincia.DataSource = null;
			this.mzCmbProvincia.DisplayMember = "";
			this.mzCmbProvincia.DisplayMemberCaption = "";
			this.mzCmbProvincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbProvincia.Location = new System.Drawing.Point(64, 23);
			this.mzCmbProvincia.MaxItemsDisplay = 7;
			this.mzCmbProvincia.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbProvincia.Name = "mzCmbProvincia";
			this.mzCmbProvincia.Size = new System.Drawing.Size(272, 21);
			this.mzCmbProvincia.SorterMember = "";
			this.mzCmbProvincia.TabIndex = 1;
			this.mzCmbProvincia.ValueMember = "";
			this.mzCmbProvincia.ValueMemberCaption = "";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(0, 28);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel3.TabIndex = 51;
			this.ultraLabel3.Text = "Provincia";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(0, 3);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel2.TabIndex = 50;
			this.ultraLabel2.Text = "País";
			// 
			// txtCodigoPostal
			// 
			this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigoPostal.Location = new System.Drawing.Point(464, 24);
			this.txtCodigoPostal.Name = "txtCodigoPostal";
			this.txtCodigoPostal.Size = new System.Drawing.Size(272, 20);
			this.txtCodigoPostal.TabIndex = 3;
			this.txtCodigoPostal.Text = "";
			// 
			// txtNombre
			// 
			this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNombre.Location = new System.Drawing.Point(464, 1);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(272, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.Text = "";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(352, 24);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel1.TabIndex = 47;
			this.ultraLabel1.Text = "Código Postal";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(352, 0);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(100, 20);
			this.ultraLabel5.TabIndex = 46;
			this.ultraLabel5.Text = "Nombre";
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
			this.toolBarStandar.Size = new System.Drawing.Size(792, 28);
			this.toolBarStandar.TabIndex = 20;
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
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Key = "Leyenda";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Leyenda";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Key = "DatosGenerales";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 69;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Key = "DatosLocalidad";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 53;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Datos Localidad";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(792, 318);
			this.ultraExplorerBar1.TabIndex = 21;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(743, 24);
			this.labelTarea.TabIndex = 3;
			this.labelTarea.Text = "ABM Localidades";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmABMLocalidadesWorkflow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 346);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmABMLocalidadesWorkflow";
			this.Text = "FrmABMLocalidadesWorkflow";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbLocEditar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPaisEditar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPciaEditar)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPais)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProvincia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region variables privadas
		private ABMLocalidadesController _uiController;
		private int _localidadSeleccionada;
		private int _pasisSeleccionado;
			
		#endregion
		#region Miembros de ITaskForm

		public void Execute()
		{
			//DumpControls()
			//pasa al controler el valor del text box
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
			mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			SaveChanges();
		}

		#endregion

	
		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();		
		
		}
		private void ConfigureInterface()
		{
			/*Le pide al controller los controlles q tiene q poner deshabilitado*/
			ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles(), ",");
				foreach(string grupo in cont)
				{ 
					if (grupo != string.Empty)
					{
						if (this.ultraExplorerBar1.Groups.Exists(grupo))
							if (this.ultraExplorerBar1.Groups[grupo].Container != null)
								this.ultraExplorerBar1.Groups[grupo].Container.Enabled = false;
					}
				}
			
			//Toma los valores definidos en la bd
			this.tbbAnterior.Text=_uiController.TextoBotonAnterior;
			this.tbbAnterior.Enabled=false;
			this.tbbSiguiente.Text=_uiController.TextoBotonSiguiente;
			this.labelLeyenda.Text=_uiController.Leyenda;
			this.Text=_uiController.Leyenda;
			KeyPreview = true;
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
			this.mzCmbPais.SelectionChanged+=new EventHandler(mzCmbPais_SelectionChanged);
			this.mzCmbPaisEditar.SelectionChanged+=new EventHandler(mzCmbPaisEditar_SelectionChanged);
			this.mzCmbProvincia.SelectionChanged+=new EventHandler(mzCmbProvincia_SelectionChanged);
			this.mzCmbPciaEditar.SelectionChanged+=new EventHandler(mzCmbPciaEditar_SelectionChanged);
			this.mzCmbLocEditar.SelectionChanged+=new EventHandler(mzCmbLocEditar_SelectionChanged);
			_uiController.ObjectHasChanged+=new EventHandler(_uiController_ObjectHasChanged);
			//this.mzCmbSrchEdtLocalidades.ValueChanged+=new EventHandler(mzCmbSrchEdtLocalidades_ValueChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}

		private void InitDataBindings()
		{
			//mzCmbPais.DataBindings.Add("Value", _uiController, "IdPais"); 
			//mzCmbProvincia.DataBindings.Add("Value", _uiController, "IdProvincia"); 
			//mzCmbPaisEditar.DataBindings.Add("Value", _uiController, "IdPaisEdicion"); 
			//mzCmbPciaEditar.DataBindings.Add("Value", _uiController, "IdProvinciaEdicion"); 
			//mzCmbLocEditar.DataBindings.Add("Value", _uiController, "IdLocalidad"); 
			txtCodigoPostal.DataBindings.Add("Text",_uiController,"CodigoPostal");
			txtNombre.DataBindings.Add("Text", _uiController,"NombreLocalidad");
		}
		private void InitializeData()
		{
			this.mzCmbPais.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbProvincia.FillFromDataSource(_uiController.Provincias, _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
			this.mzCmbPaisEditar.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbPciaEditar.FillFromDataSource(_uiController.Provincias, _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
			this.mzCmbLocEditar.FillFromDataSource(_uiController.Localidades, _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);

			this.mzCmbPais.Value=_uiController.IdPais;
			this.mzCmbProvincia.Value=_uiController.IdProvincia;			
		}

		
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{	
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: //Anterior
					_uiController.Previous();
					break;
				case 2:	//Siguiente		
					mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl1);
					SaveChanges();
					break;
				case 4:	//Cancelar					
					if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning )== System.Windows.Forms.DialogResult.OK))
						CloseForm();
					break;
				
			}						
		}

		private void SaveChanges()
		{	/* Silvina 20100903 - Tarea 797 */
			/*if (!_uiController.ValidarDatosLocalidad(this.txtNombre.Text)) // false==datos invalidos.
			{
				if ((MessageBox.Show(this,"La localidad ingresada ya existe. Realmente desea realizar esta operación? (En caso afirmativo se duplicará dicha localidad)","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning )== System.Windows.Forms.DialogResult.OK))
				{
					if (!_uiController.ValidarDatosCP(this.txtCodigoPostal.Text))
					{
						if ((MessageBox.Show(this,"El código postal ingresado ya existe. Realmente desea realizar esta operación? (En caso afirmativo se duplicará dicho código postal)","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning )== System.Windows.Forms.DialogResult.OK))
						{
							_uiController.Execute(); // Loc==F, CP==F.
						} 
						// else cancela
					}
					else
					{
						_uiController.Execute(); // Loc==F, CP==T.
					}					
				} 
				// else cancela
			}
			else
			{
				if (!_uiController.ValidarDatosCP(this.txtCodigoPostal.Text))
				{
					if ((MessageBox.Show(this,"El código postal ingresado ya existe. Realmente desea realizar esta operación? (En caso afirmativo se duplicará dicho código postal)","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning )== System.Windows.Forms.DialogResult.OK))
					{
						_uiController.Execute(); // Loc==T, CP==F.
					}
					// else cancela
				}
				else
				{
					_uiController.Execute(); // Loc==T, CP==T.
				}
			}*/
            _uiController.Execute();
            /* Fon Silvina */
		}

	
		private void mzCmbPais_SelectionChanged(object sender, EventArgs e)
		{
			long idPaisSeleccionado = (long)mzCmbPais.Value;
			if(!idPaisSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbProvincia.FillFromDataSource(_uiController.ProvinciasPais(idPaisSeleccionado), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
				if(idPaisSeleccionado != _uiController.IdPais)
				{
					_uiController.IdPais=idPaisSeleccionado;
					if(mzCmbProvincia.Items.Count!=0)
					{
						mzCmbProvincia.Enabled=true;
						mzCmbProvincia.SelectedIndex = 0;
						_uiController.IdProvincia = (long)mzCmbProvincia.Value;
						
					}
					else 
					{
						mzCmbProvincia.Enabled=false;
						//mzCmbLocEditar.Enabled=false;
					}
					
				}
			}
		}

		private void mzCmbProvincia_SelectionChanged(object sender, EventArgs e)
		{
			_uiController.IdProvincia=(long)mzCmbProvincia.Value;
			
		}
		private void mzCmbPaisEditar_SelectionChanged(object sender, EventArgs e)
		{
			long idPaisSeleccionado = (long)mzCmbPaisEditar.Value;
			if(!idPaisSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbPciaEditar.FillFromDataSource(_uiController.ProvinciasPais(idPaisSeleccionado), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
				if(idPaisSeleccionado != _uiController.IdPaisEdicion)
				{
					_uiController.IdPaisEdicion=idPaisSeleccionado;
					if(mzCmbPciaEditar.Items.Count!=0){
						mzCmbPciaEditar.Enabled=true;
						mzCmbLocEditar.Enabled=false;
						mzCmbPciaEditar.SelectedIndex = 0;
						_uiController.IdProvinciaEdicion = (long)mzCmbPciaEditar.Value;
						
					}
					else 
					{
						mzCmbPciaEditar.Enabled=false;
						mzCmbLocEditar.Enabled=false;
						this.ultraExplorerBar1.Groups["DatosLocalidad"].Container.Enabled = false;
					}
					
				}
			}

		}

		private void mzCmbPciaEditar_SelectionChanged(object sender, EventArgs e)
		{
			long idProvinciaSeleccionado = (long)mzCmbPciaEditar.Value;
			if(!idProvinciaSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbLocEditar.FillFromDataSource(_uiController.LocalidadPcia(idProvinciaSeleccionado), _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
				if(idProvinciaSeleccionado != _uiController.IdProvinciaEdicion)
				{
					_uiController.IdProvinciaEdicion=idProvinciaSeleccionado;
					if(mzCmbLocEditar.Items.Count!=0)
					{	
						mzCmbLocEditar.Enabled=true;
						mzCmbLocEditar.SelectedIndex = 0;
						_uiController.IdLocalidad = (string)mzCmbLocEditar.Value;
						
					}
					else 
					{
						mzCmbLocEditar.Enabled=false;
						this.ultraExplorerBar1.Groups["DatosLocalidad"].Container.Enabled = false;
						
					}
					
				}
			}

		}

		private void mzCmbLocEditar_SelectionChanged(object sender, EventArgs e)
		{
			string idLocalidad = (string)mzCmbLocEditar.Value;
			if (!idLocalidad.Equals(string.Empty))
			{
				_uiController.IdLocalidad=idLocalidad;
				_localidadSeleccionada=this.mzCmbPciaEditar.SelectedIndex;
				_pasisSeleccionado=this.mzCmbPaisEditar.SelectedIndex;
				_uiController.ActualizarDatos();
				this.ultraExplorerBar1.Groups["DatosLocalidad"].Container.Enabled = true;
			}
		
		}

		private void _uiController_ObjectHasChanged(object sender, EventArgs e)
		{
			this.mzCmbPais.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbPais.SelectedIndex=_pasisSeleccionado;
			this.mzCmbProvincia.FillFromDataSource(_uiController.ProvinciasPais(_uiController.IdPais), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
			this.mzCmbProvincia.SelectedIndex=_localidadSeleccionada;
			//mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			this.txtCodigoPostal.Text=_uiController.CodigoPostal;
			this.txtNombre.Text=_uiController.NombreLocalidad;
		}
	}
}

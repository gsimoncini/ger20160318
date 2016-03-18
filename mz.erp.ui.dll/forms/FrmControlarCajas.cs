using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmControlarCajas.
	/// </summary>
	public class FrmControlarCajas : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.Misc.UltraButton btnAgregar;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private mz.erp.ui.controls.mzComboEditor mzCFormaDePago;
		private System.Windows.Forms.Label label2;
		private mz.erp.ui.controls.mzComboEditor mzCTipoBillete;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedas;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCantidad;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMonto;
		private System.Windows.Forms.Label label5;
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmControlarCajas));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.uneMonto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneCantidad = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.mzCEMonedas = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.mzCTipoBillete = new mz.erp.ui.controls.mzComboEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.mzCFormaDePago = new mz.erp.ui.controls.mzComboEditor();
			this.btnAgregar = new Infragistics.Win.Misc.UltraButton();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneMonto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCTipoBillete)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCFormaDePago)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(798, 26);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(798, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCEInstanciasCaja);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 109);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(798, 410);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.uneMonto);
			this.groupBox1.Controls.Add(this.uneCantidad);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.mzCEMonedas);
			this.groupBox1.Controls.Add(this.ultraLabel7);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.mzCTipoBillete);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.mzCFormaDePago);
			this.groupBox1.Controls.Add(this.btnAgregar);
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(784, 104);
			this.groupBox1.TabIndex = 123;
			this.groupBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(424, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 142;
			this.label5.Tag = "";
			this.label5.Text = "Monto";
			// 
			// uneMonto
			// 
			this.uneMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uneMonto.Location = new System.Drawing.Point(496, 40);
			this.uneMonto.MaskInput = "{LOC}nnnnnnn.nn";
			this.uneMonto.Name = "uneMonto";
			this.uneMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneMonto.Size = new System.Drawing.Size(96, 21);
			this.uneMonto.TabIndex = 5;
			this.uneMonto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// uneCantidad
			// 
			this.uneCantidad.Location = new System.Drawing.Point(496, 16);
			this.uneCantidad.MinValue = 0;
			this.uneCantidad.Name = "uneCantidad";
			this.uneCantidad.PromptChar = ' ';
			this.uneCantidad.Size = new System.Drawing.Size(100, 21);
			this.uneCantidad.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(424, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 140;
			this.label4.Tag = "";
			this.label4.Text = "Cantidad";
			// 
			// mzCEMonedas
			// 
			this.mzCEMonedas.AutoComplete = true;
			this.mzCEMonedas.DataSource = null;
			this.mzCEMonedas.DisplayMember = "";
			this.mzCEMonedas.DisplayMemberCaption = "";
			this.mzCEMonedas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedas.Location = new System.Drawing.Point(136, 64);
			this.mzCEMonedas.MaxItemsDisplay = 7;
			this.mzCEMonedas.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedas.Name = "mzCEMonedas";
			this.mzCEMonedas.Size = new System.Drawing.Size(152, 21);
			this.mzCEMonedas.SorterMember = "";
			this.mzCEMonedas.TabIndex = 3;
			this.mzCEMonedas.ValueMember = "";
			this.mzCEMonedas.ValueMemberCaption = "";
			// 
			// ultraLabel7
			// 
			this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel7.Location = new System.Drawing.Point(16, 72);
			this.ultraLabel7.Name = "ultraLabel7";
			this.ultraLabel7.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel7.TabIndex = 128;
			this.ultraLabel7.Text = "Moneda";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 126;
			this.label2.Text = "Tipo Billete";
			// 
			// mzCTipoBillete
			// 
			this.mzCTipoBillete.AutoComplete = true;
			this.mzCTipoBillete.DataSource = null;
			this.mzCTipoBillete.DisplayMember = "";
			this.mzCTipoBillete.DisplayMemberCaption = "";
			this.mzCTipoBillete.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCTipoBillete.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCTipoBillete.Location = new System.Drawing.Point(136, 40);
			this.mzCTipoBillete.MaxItemsDisplay = 7;
			this.mzCTipoBillete.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCTipoBillete.Name = "mzCTipoBillete";
			this.mzCTipoBillete.Size = new System.Drawing.Size(272, 21);
			this.mzCTipoBillete.SorterMember = "";
			this.mzCTipoBillete.TabIndex = 2;
			this.mzCTipoBillete.ValueMember = "";
			this.mzCTipoBillete.ValueMemberCaption = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 124;
			this.label1.Text = "Forma de pago";
			// 
			// mzCFormaDePago
			// 
			this.mzCFormaDePago.AutoComplete = true;
			this.mzCFormaDePago.DataSource = null;
			this.mzCFormaDePago.DisplayMember = "";
			this.mzCFormaDePago.DisplayMemberCaption = "";
			this.mzCFormaDePago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCFormaDePago.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCFormaDePago.Location = new System.Drawing.Point(136, 16);
			this.mzCFormaDePago.MaxItemsDisplay = 7;
			this.mzCFormaDePago.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCFormaDePago.Name = "mzCFormaDePago";
			this.mzCFormaDePago.Size = new System.Drawing.Size(272, 21);
			this.mzCFormaDePago.SorterMember = "";
			this.mzCFormaDePago.TabIndex = 1;
			this.mzCFormaDePago.ValueMember = "";
			this.mzCFormaDePago.ValueMemberCaption = "";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(680, 64);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(80, 24);
			this.btnAgregar.TabIndex = 6;
			this.btnAgregar.Text = "&Agregar";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 122;
			this.label3.Text = "Caja ";
			// 
			// mzCEInstanciasCaja
			// 
			this.mzCEInstanciasCaja.AutoComplete = true;
			this.mzCEInstanciasCaja.DataSource = null;
			this.mzCEInstanciasCaja.DisplayMember = "";
			this.mzCEInstanciasCaja.DisplayMemberCaption = "";
			this.mzCEInstanciasCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEInstanciasCaja.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCEInstanciasCaja.Location = new System.Drawing.Point(80, 8);
			this.mzCEInstanciasCaja.MaxItemsDisplay = 7;
			this.mzCEInstanciasCaja.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEInstanciasCaja.Name = "mzCEInstanciasCaja";
			this.mzCEInstanciasCaja.Size = new System.Drawing.Size(272, 21);
			this.mzCEInstanciasCaja.SorterMember = "";
			this.mzCEInstanciasCaja.TabIndex = 0;
			this.mzCEInstanciasCaja.ValueMember = "";
			this.mzCEInstanciasCaja.ValueMemberCaption = "";
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.AutomaticSort = false;
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEX1.Location = new System.Drawing.Point(0, 184);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(798, 216);
			this.gridEX1.TabIndex = 9;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(712, 152);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "&Eliminar";
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 160);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(672, 24);
			this.gridManagerView1.TabIndex = 7;
			this.gridManagerView1.Visible = false;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 26;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 410;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(864, 536);
			this.ultraExplorerBar1.TabIndex = 53;
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
			this.toolBarStandar.Size = new System.Drawing.Size(864, 28);
			this.toolBarStandar.TabIndex = 52;
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
			// FrmControlarCajas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(864, 564);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmControlarCajas";
			this.Text = "FrmControlarCajas";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneMonto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCTipoBillete)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCFormaDePago)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private ControlarCajasController _uiController = null;
		#endregion
		
		#region Constructores y Destructores
		public FrmControlarCajas(ControlarCajasController controller)
		{
			InitializeComponent();
			_uiController = controller;
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

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridEX1, this.Text);

			mzCEInstanciasCaja.Enabled = _uiController.AllowEditCaja();
            mzCTipoBillete.Enabled = false;

		}

		private void InitializeData()
		{
			mzCEInstanciasCaja.FillFromDataSource(_uiController.InstanciasDeCaja(), "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
			if (mzCEInstanciasCaja.Items.Count != 0)
			{
				mzCEInstanciasCaja.Enabled = _uiController.AllowEditCaja();
				_uiController.IdCaja = Convert.ToString(mzCEInstanciasCaja.Items[0].DataValue);			
			}
			else 
				mzCEInstanciasCaja.Enabled =false;

			mzCFormaDePago.FillFromDataSource( _uiController.TDCompTesorerias, _uiController.KeyValueTDCompTesoreria, _uiController.KeyListTDCompTesoreria, 100, _uiController.KeyListTDCompTesoreria);
			if (mzCFormaDePago.Items.Count != 0)
			{
				_uiController.IdControlDeCajasFamiliasComprobanteTesoreria = Convert.ToString(mzCFormaDePago.Items[0].DataValue);			
			}
			mzCTipoBillete.Enabled = _uiController.HabilitaTipoBillete();
			mzCTipoBillete.FillFromDataSource( _uiController.TiposBilletes, _uiController.KeyValueTipoBillete, _uiController.KeyListTipoBillete, 100, _uiController.KeyValueTipoBillete);
			if (mzCTipoBillete.Enabled && mzCTipoBillete.Items.Count != 0)
			{
				_uiController.IdTipoBillete = (long)(mzCTipoBillete.Items[0].DataValue);			
			}
			mzCEMonedas.FillFromDataSource(_uiController.Monedas, _uiController.KeyValueMoneda, _uiController.KeyListMoneda, 100, _uiController.KeyValueMoneda);
			if (mzCEMonedas.Items.Count != 0)
			{
				_uiController.IdMoneda = Convert.ToString(mzCEMonedas.Items[0].DataValue);			
			}

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			mzCFormaDePago.ValueChanged+=new EventHandler(mzCFormaDePago_ValueChanged);
            btnAgregar.Click+=new EventHandler(btnAgregar_Click);
			_uiController.AuditoriaControlCajasDetViewHasChanged+=new EventHandler(_uiController_AuditoriaControlCajasDetViewHasChanged);
			mzCTipoBillete.ValueChanged+=new EventHandler(mzCTipoBillete_ValueChanged);
			mzCEMonedas.ValueChanged+=new EventHandler(mzCEMonedas_ValueChanged);
			uneCantidad.ValueChanged+=new EventHandler(uneCantidad_ValueChanged);
			gridEX1.EditingCell+=new Janus.Windows.GridEX.EditingCellEventHandler(gridEX1_EditingCell);
			btnEliminar.Click+=new EventHandler(btnEliminar_Click);
			gridEX1.SelectionChanged+=new EventHandler(gridEX1_SelectionChanged);
			uneCantidad.Enter+=new EventHandler(uneCantidad_Enter);
			uneMonto.Enter+=new EventHandler(uneMonto_Enter);
		}	
	
		private void InitDataBindings()
		{
			mzCEInstanciasCaja.DataBindings.Clear();
			mzCFormaDePago.DataBindings.Clear();
			mzCTipoBillete.DataBindings.Clear();
			mzCEMonedas.DataBindings.Clear();
			uneCantidad.DataBindings.Clear();
			uneMonto.DataBindings.Clear();

			mzCEInstanciasCaja.DataBindings.Add("Value", _uiController , "IdCaja");
			mzCFormaDePago.DataBindings.Add("Value", _uiController , "IdControlDeCajasFamiliasComprobanteTesoreria");
			mzCTipoBillete.DataBindings.Add("Value", _uiController , "IdTipoBillete");
			mzCEMonedas.DataBindings.Add("Value", _uiController , "IdMoneda");
			uneCantidad.DataBindings.Add("Value", _uiController, "CantidadInformada");
			uneMonto.DataBindings.Add("Value", _uiController, "MontoInformado");
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
			SaveChanges();
		}


		#endregion

		#region Métodos Privados
		private void SaveChanges()
		{	
			this.Cursor = Cursors.WaitCursor;
			Util.MoveFocus(this.ultraExplorerBarContainerControl2);
			_uiController.Execute();
			this.Cursor = Cursors.Default;
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
					CloseForm();
					break;
			}						
		}

		private void mzCFormaDePago_ValueChanged(object sender, EventArgs e)
		{
			_uiController.IdControlDeCajasFamiliasComprobanteTesoreria = Convert.ToString(mzCFormaDePago.Value);
			_uiController.TDCompTesoreria = mzCFormaDePago.Text;
			mzCTipoBillete.Enabled = _uiController.HabilitaTipoBillete();
			uneMonto.Enabled = !_uiController.HabilitaTipoBillete();
			if (mzCTipoBillete.Enabled && mzCTipoBillete.Items.Count != 0)
			{
				_uiController.IdTipoBillete = (long)(mzCTipoBillete.Items[0].DataValue);	
				mzCTipoBillete.TabIndex = 2;
				uneMonto.TabIndex = 20;
			}
			else
			{
				mzCTipoBillete.TabIndex = 20;
				uneMonto.TabIndex = 5;
				mzCTipoBillete.ResetText();
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			cantAnterior = _uiController.AuditoriaControlCajasDetView.Count;
			_uiController.AgregarItemAuditoria();
			mzCFormaDePago.Focus();
		}

		private int cantAnterior;
		private int index = 0;
		private void _uiController_AuditoriaControlCajasDetViewHasChanged(object sender, EventArgs e)
		{		
			gridEX1.SelectionChanged-=new EventHandler(gridEX1_SelectionChanged);
			this.gridEX1.SetDataBinding( null, null );
			this.gridEX1.SetDataBinding(_uiController.AuditoriaControlCajasDetView, null );
			gridEX1.SelectionChanged+=new EventHandler(gridEX1_SelectionChanged);
			int cantPosterior = _uiController.AuditoriaControlCajasDetView.Count;
			if(cantAnterior != cantPosterior) //Si agrego o borro lo dejo parado en la ultima fila
			{
				if(cantPosterior > 0)
					gridEX1.Row = cantPosterior - 1;
			}
			else //Si modifico lo dejo parado en la misma fila q estaba (la q modifico)
			{
			    gridEX1.Row = index;
			}
			btnEliminar.Enabled = _uiController.AuditoriaControlCajasDetView.Count > 0;
		}

		private void mzCTipoBillete_ValueChanged(object sender, EventArgs e)
		{
			if(mzCTipoBillete.Value != null)
                _uiController.IdTipoBillete = (long)mzCTipoBillete.Value;
			_uiController.TipoBillete = mzCTipoBillete.Text;

		}

		private void mzCEMonedas_ValueChanged(object sender, EventArgs e)
		{
			_uiController.IdMoneda = Convert.ToString(mzCEMonedas.Value);
			_uiController.Moneda = mzCEMonedas.Text;
		}

		private void uneCantidad_ValueChanged(object sender, EventArgs e)
		{
			if(uneCantidad.Value != null)
				_uiController.CantidadInformada = Convert.ToInt64(uneCantidad.Value);
			if(_uiController.HabilitaTipoBillete())
			{				
				_uiController.MontoInformado = Convert.ToInt64(uneCantidad.Value) * _uiController.ValorBillete;
				uneMonto.Value = _uiController.MontoInformado;
			}
		}

		private void gridEX1_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			businessrules.AuditoriaControlCajasDetView aud = (businessrules.AuditoriaControlCajasDetView)gridEX1.SelectedItems[0].GetRow().DataRow;
			if(aud.UsaDetalleBilletes && e.Column.Key.Equals("MontoInformado"))
				e.Cancel = true;
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			cantAnterior = _uiController.AuditoriaControlCajasDetView.Count;
			businessrules.AuditoriaControlCajasDetView aud = (businessrules.AuditoriaControlCajasDetView)gridEX1.SelectedItems[0].GetRow().DataRow;
			gridEX1.Row = 0;
			_uiController.EliminarItemAuditoria(aud);
		}

		private void gridEX1_SelectionChanged(object sender, EventArgs e)
		{
			index = 0;
			if(gridEX1.SelectedItems.Count > 0)
			{
				index = gridEX1.SelectedItems[0].Position;
				businessrules.AuditoriaControlCajasDetView aud = (businessrules.AuditoriaControlCajasDetView)gridEX1.SelectedItems[0].GetRow().DataRow;
				mzCFormaDePago.Value = aud.IdControlDeCajasFamiliasComprobanteTesoreria;
				mzCTipoBillete.Value = aud.IdTipoBillete;
				mzCEMonedas.Value = aud.IdMoneda;
				uneCantidad.Value = aud.CantidadInformada;
				uneMonto.Value = aud.MontoInformado;
			}
		}

		private void uneCantidad_Enter(object sender, EventArgs e)
		{
			uneCantidad.Focus();
			uneCantidad.SelectAll();
		}

		private void uneMonto_Enter(object sender, EventArgs e)
		{
			uneMonto.Focus();
			uneMonto.SelectAll();
		}
	}
}

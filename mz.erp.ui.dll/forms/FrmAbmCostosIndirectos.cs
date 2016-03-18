using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controls;
using mz.erp.commontypes;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmABMCostosIndirectos.
	/// </summary>
	public class FrmABMCostosIndirectos : System.Windows.Forms.Form,ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValor;
		private Infragistics.Win.Misc.UltraLabel lblOrigen;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBoxTipoMoneda;
		private mz.erp.ui.controls.mzComboEditor mzCEFuenteDeCambio;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private mz.erp.ui.controls.mzComboEditor mzCEMoneda;
		private System.Windows.Forms.TextBox txtDescripcionFuente;
		private System.Windows.Forms.TextBox txtDescripcionMoneda;
		private System.Windows.Forms.CheckBox chkTipo;
		private Janus.Windows.GridEX.GridEX gridListaDeCostosIndirectos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private System.ComponentModel.IContainer components;

		public FrmABMCostosIndirectos()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmABMCostosIndirectos(controllers.AbmCostosIndirectosController _controller)
		{
			InitializeComponent();
			_uiController = _controller;
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
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMCostosIndirectos));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.uneValor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.lblOrigen = new Infragistics.Win.Misc.UltraLabel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBoxTipoMoneda = new System.Windows.Forms.GroupBox();
			this.mzCEFuenteDeCambio = new mz.erp.ui.controls.mzComboEditor();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.mzCEMoneda = new mz.erp.ui.controls.mzComboEditor();
			this.txtDescripcionFuente = new System.Windows.Forms.TextBox();
			this.txtDescripcionMoneda = new System.Windows.Forms.TextBox();
			this.chkTipo = new System.Windows.Forms.CheckBox();
			this.gridListaDeCostosIndirectos = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneValor)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBoxTipoMoneda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridListaDeCostosIndirectos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(863, 25);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(863, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridListaDeCostosIndirectos);
			this.ultraExplorerBarContainerControl1.DockPadding.Top = 12;
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 108);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(863, 342);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Location = new System.Drawing.Point(8, 229);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(696, 112);
			this.groupBox1.TabIndex = 148;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkActivo);
			this.groupBox2.Controls.Add(this.ultraLabel1);
			this.groupBox2.Controls.Add(this.txtDescripcion);
			this.groupBox2.Controls.Add(this.uneValor);
			this.groupBox2.Controls.Add(this.lblOrigen);
			this.groupBox2.Location = new System.Drawing.Point(16, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 82);
			this.groupBox2.TabIndex = 93;
			this.groupBox2.TabStop = false;
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkActivo.Location = new System.Drawing.Point(8, 52);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(92, 20);
			this.chkActivo.TabIndex = 96;
			this.chkActivo.Text = "Activo";
			// 
			// ultraLabel1
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Left;
			this.ultraLabel1.Appearance = appearance1;
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(8, 33);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ultraLabel1.Size = new System.Drawing.Size(48, 16);
			this.ultraLabel1.TabIndex = 95;
			this.ultraLabel1.Text = "Valor";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcion.Location = new System.Drawing.Point(88, 12);
			this.txtDescripcion.MaxLength = 30;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(128, 20);
			this.txtDescripcion.TabIndex = 94;
			this.txtDescripcion.Text = "";
			// 
			// uneValor
			// 
			this.uneValor.Location = new System.Drawing.Point(88, 31);
			this.uneValor.MaskInput = "nnnnnnnn.nn";
			this.uneValor.Name = "uneValor";
			this.uneValor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValor.Size = new System.Drawing.Size(72, 21);
			this.uneValor.TabIndex = 93;
			this.uneValor.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// lblOrigen
			// 
			appearance2.TextHAlign = Infragistics.Win.HAlign.Left;
			this.lblOrigen.Appearance = appearance2;
			this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
			this.lblOrigen.Location = new System.Drawing.Point(8, 12);
			this.lblOrigen.Name = "lblOrigen";
			this.lblOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblOrigen.Size = new System.Drawing.Size(72, 16);
			this.lblOrigen.TabIndex = 92;
			this.lblOrigen.Text = "Descripcion";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBoxTipoMoneda);
			this.groupBox3.Controls.Add(this.chkTipo);
			this.groupBox3.Location = new System.Drawing.Point(286, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(395, 82);
			this.groupBox3.TabIndex = 92;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Tipo de Costo Indirecto";
			// 
			// groupBoxTipoMoneda
			// 
			this.groupBoxTipoMoneda.BackColor = System.Drawing.Color.Transparent;
			this.groupBoxTipoMoneda.Controls.Add(this.mzCEFuenteDeCambio);
			this.groupBoxTipoMoneda.Controls.Add(this.label18);
			this.groupBoxTipoMoneda.Controls.Add(this.label17);
			this.groupBoxTipoMoneda.Controls.Add(this.mzCEMoneda);
			this.groupBoxTipoMoneda.Controls.Add(this.txtDescripcionFuente);
			this.groupBoxTipoMoneda.Controls.Add(this.txtDescripcionMoneda);
			this.groupBoxTipoMoneda.Location = new System.Drawing.Point(128, 8);
			this.groupBoxTipoMoneda.Name = "groupBoxTipoMoneda";
			this.groupBoxTipoMoneda.Size = new System.Drawing.Size(256, 64);
			this.groupBoxTipoMoneda.TabIndex = 91;
			this.groupBoxTipoMoneda.TabStop = false;
			// 
			// mzCEFuenteDeCambio
			// 
			this.mzCEFuenteDeCambio.AutoComplete = true;
			this.mzCEFuenteDeCambio.DataSource = null;
			this.mzCEFuenteDeCambio.DisplayMember = "";
			this.mzCEFuenteDeCambio.DisplayMemberCaption = "";
			this.mzCEFuenteDeCambio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFuenteDeCambio.Location = new System.Drawing.Point(115, 35);
			this.mzCEFuenteDeCambio.MaxItemsDisplay = 200;
			this.mzCEFuenteDeCambio.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFuenteDeCambio.Name = "mzCEFuenteDeCambio";
			this.mzCEFuenteDeCambio.Size = new System.Drawing.Size(128, 21);
			this.mzCEFuenteDeCambio.SorterMember = "";
			this.mzCEFuenteDeCambio.TabIndex = 35;
			this.mzCEFuenteDeCambio.ValueMember = "";
			this.mzCEFuenteDeCambio.ValueMemberCaption = "";			
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(11, 37);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(104, 16);
			this.label18.TabIndex = 34;
			this.label18.Text = "Fuente de Cambio";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(11, 17);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 16);
			this.label17.TabIndex = 33;
			this.label17.Text = "Moneda ";
			// 
			// mzCEMoneda
			// 
			this.mzCEMoneda.AutoComplete = true;
			this.mzCEMoneda.DataSource = null;
			this.mzCEMoneda.DisplayMember = "";
			this.mzCEMoneda.DisplayMemberCaption = "";
			this.mzCEMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMoneda.Location = new System.Drawing.Point(115, 14);
			this.mzCEMoneda.MaxItemsDisplay = 200;
			this.mzCEMoneda.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMoneda.Name = "mzCEMoneda";
			this.mzCEMoneda.Size = new System.Drawing.Size(128, 21);
			this.mzCEMoneda.SorterMember = "";
			this.mzCEMoneda.TabIndex = 32;
			this.mzCEMoneda.ValueMember = "";
			this.mzCEMoneda.ValueMemberCaption = "";
			
			// 
			// txtDescripcionFuente
			// 
			this.txtDescripcionFuente.Location = new System.Drawing.Point(120, 33);
			this.txtDescripcionFuente.Name = "txtDescripcionFuente";
			this.txtDescripcionFuente.TabIndex = 37;
			this.txtDescripcionFuente.Text = "";
			// 
			// txtDescripcionMoneda
			// 
			this.txtDescripcionMoneda.Location = new System.Drawing.Point(120, 14);
			this.txtDescripcionMoneda.Name = "txtDescripcionMoneda";
			this.txtDescripcionMoneda.TabIndex = 36;
			this.txtDescripcionMoneda.Text = "";
			// 
			// chkTipo
			// 
			this.chkTipo.Location = new System.Drawing.Point(32, 28);
			this.chkTipo.Name = "chkTipo";
			this.chkTipo.Size = new System.Drawing.Size(72, 24);
			this.chkTipo.TabIndex = 0;
			this.chkTipo.Text = "Moneda";
			//this.chkTipo.CheckedChanged += new System.EventHandler(this.chkTipo_CheckedChanged);
			// 
			// gridListaDeCostosIndirectos
			// 
			this.gridListaDeCostosIndirectos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridListaDeCostosIndirectos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridListaDeCostosIndirectos.AlternatingColors = true;
			this.gridListaDeCostosIndirectos.AutomaticSort = false;
			this.gridListaDeCostosIndirectos.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.gridListaDeCostosIndirectos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridListaDeCostosIndirectos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridListaDeCostosIndirectos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridListaDeCostosIndirectos.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridListaDeCostosIndirectos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridListaDeCostosIndirectos.GroupByBoxVisible = false;
			this.gridListaDeCostosIndirectos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridListaDeCostosIndirectos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridListaDeCostosIndirectos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridListaDeCostosIndirectos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridListaDeCostosIndirectos.Location = new System.Drawing.Point(8, 8);
			this.gridListaDeCostosIndirectos.Name = "gridListaDeCostosIndirectos";
			this.gridListaDeCostosIndirectos.RecordNavigatorText = "Registro:|de";
			this.gridListaDeCostosIndirectos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridListaDeCostosIndirectos.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridListaDeCostosIndirectos.ShowEmptyFields = false;
			this.gridListaDeCostosIndirectos.Size = new System.Drawing.Size(696, 214);
			this.gridListaDeCostosIndirectos.TabIndex = 147;
			this.gridListaDeCostosIndirectos.TabStop = false;
			this.gridListaDeCostosIndirectos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(800, 42);
			this.toolBarStandar.TabIndex = 41;
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
			// toolBarButton1
			// 
			this.toolBarButton1.Enabled = false;
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
			this.toolBarButton5.Text = "Cancelar";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton11,
																						this.toolBarButton12,
																						this.toolBarButton13});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(912, 28);
			this.toolBar1.TabIndex = 46;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Enabled = false;
			this.toolBarButton11.ImageIndex = 9;
			this.toolBarButton11.Text = "&Anterior";
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.ImageIndex = 8;
			this.toolBarButton13.Text = "&Siguiente";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 342;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Coeficientes Indirectos";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(912, 478);
			this.ultraExplorerBar1.TabIndex = 47;
			// 
			// FrmABMCostosIndirectos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(912, 506);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBar1);
			this.Name = "FrmABMCostosIndirectos";
			this.Text = "FrmABMCostosIndirectos";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneValor)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBoxTipoMoneda.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuenteDeCambio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridListaDeCostosIndirectos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void lblOrigen_Click(object sender, System.EventArgs e)
		{
		
		}

		private void gridListaDeCostosIndirectos_Changed(object sender, EventArgs e)
		{
			if ( gridListaDeCostosIndirectos.SelectedItems.Count > 0 ) 
			{
				object selectedItem = gridListaDeCostosIndirectos.SelectedItems[0].GetRow().DataRow;
				//_uiController.IdCoeficienteCostoIndirecto = selectedItem;
			}

		}
		
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
		}

		public void KeyDownNext()
		{
			Execute();
		}

		#endregion

		#region Variables Privadas	
		private controllers.AbmCostosIndirectosController _uiController = null;
		private CurrencyManager miCurrencyManager;
		#endregion

		#region Metodos Privados
		private void InitDataBindingsCurrencyManager(DataTable unaTabla)
		{
			txtDescripcion.DataBindings.Add("Text", unaTabla, "Descripcion");
			uneValor.DataBindings.Add("Value", unaTabla, "Valor");
			chkActivo.DataBindings.Add("Checked", unaTabla, "Activo");
			chkTipo.DataBindings.Add("Checked", unaTabla, "Tipo"); // 0=% & 1=$			
			mzCEMoneda.DataBindings.Add("Value", unaTabla, "IdMoneda");			
			mzCEFuenteDeCambio.DataBindings.Add("Value", unaTabla, "IdFuenteDeCambio");
			txtDescripcionMoneda.DataBindings.Add("Text", unaTabla, "DescripcionMoneda");
			txtDescripcionFuente.DataBindings.Add("Text", unaTabla, "DescripcionFuenteDeCambio");
			
			miCurrencyManager = (CurrencyManager)this.BindingContext[unaTabla];
			miCurrencyManager.Position = 0;
            this.RefreshDataPostCurrencyManager();		
		}

		private void RefreshDataPostCurrencyManager()
		{
			if ( !chkTipo.Checked )
				groupBoxTipoMoneda.Enabled = false;
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
			//this.tbbAnterior.Text = _uiController.TextoBotonAnterior;
			this.tbbAnterior.Enabled = false;
			//this.tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			
			labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.LeyendaFormulario;

			mzCEMoneda.FillFromDataSource(_uiController.Monedas, _uiController.MonedaValueMember, _uiController.MonedaDisplayMember, 8, _uiController.MonedaSortedMember);		
			mzCEFuenteDeCambio.FillFromDataSource(_uiController.FuentesDeCambio, _uiController.FuenteDeCambioValueMember, _uiController.FuenteDeCambioDisplayMember, 8, _uiController.FuenteDeCambioSortedMember);
			mzCEMoneda.Enabled = true;
			mzCEFuenteDeCambio.Enabled = true;
			KeyPreview = true;
		}

		private void InitializeData()
		{
			this.gridListaDeCostosIndirectos.LayoutData = mz.erp.ui.forms.classes.tsh_CoeficientesCostosIndirectos.GetLayoutEx(new string[]{"Descripcion", "Valor", "Tipo", /*"IdMoneda", "IdFuenteDeCambio",*/ "DescripcionMoneda", "DescripcionFuenteDeCambio", "Activo" } );
		}

		private void InitEventHandlers()
		{
			chkTipo.CheckedChanged += new System.EventHandler(this.chkTipo_CheckedChanged);
			toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			mzCEMoneda.ValueChanged += new System.EventHandler(this.mzCEMoneda_ValueChanged);
			mzCEFuenteDeCambio.ValueChanged += new System.EventHandler(this.mzCEFuenteDeCambio_ValueChanged);
			gridListaDeCostosIndirectos.SelectionChanged += new EventHandler(gridListaDeCostosIndirectos_Changed);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}	
	
		private void InitDataBindings()
		{				
			gridListaDeCostosIndirectos.SetDataBinding(_uiController.CostosIndirectosDataTable, null);
			this.InitDataBindingsCurrencyManager(_uiController.CostosIndirectosDataTable);			
		}

		private void EventsListener()
		{			
		}

		#endregion

		/*private void radioMoneda_CheckedChanged(object sender, System.EventArgs e)
		{
			
		}

		private void radioPorc_CheckedChanged(object sender, System.EventArgs e)
		{			
			
		}*/

		private void chkTipo_CheckedChanged(object sender, System.EventArgs e)
		{
			if ( chkTipo.Checked )
			{
				groupBoxTipoMoneda.Enabled = true;
				this.txtDescripcionFuente.Text = mzCEFuenteDeCambio.Text;
				this.txtDescripcionMoneda.Text = mzCEMoneda.Text;
			}
			else
			{
				groupBoxTipoMoneda.Enabled = false;
				this.txtDescripcionFuente.Text = string.Empty;
				this.txtDescripcionMoneda.Text = string.Empty;
				mzCEMoneda.Text = string.Empty;
				mzCEFuenteDeCambio.Text = string.Empty;
			}

		}

		private void mzCEMoneda_ValueChanged(object sender, System.EventArgs e)
		{
			txtDescripcionMoneda.Text = mzCEMoneda.Text;
		}

		private void mzCEFuenteDeCambio_ValueChanged(object sender, System.EventArgs e)
		{
			txtDescripcionFuente.Text = mzCEFuenteDeCambio.Text;
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBar1.Buttons.IndexOf( e.Button ) )
			{ 
				case 4://Cancelar
					CloseForm();
					break;
				case 2://Guardar	
					_uiController.Execute();
					break;
			}		
		}


	}
}

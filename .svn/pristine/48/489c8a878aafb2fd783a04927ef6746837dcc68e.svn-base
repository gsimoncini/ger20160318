using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de frmConfiguracionLayoutGrilla.
	/// </summary>
	public class frmConfiguracionLayoutGrilla : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imageList1;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		protected System.Windows.Forms.ToolBarButton tbFirst;
		protected System.Windows.Forms.ToolBarButton tbPrev;
		protected System.Windows.Forms.ToolBarButton tbNext;
		protected System.Windows.Forms.ToolBarButton tbLast;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		protected System.Windows.Forms.ToolBarButton tbActualizar;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		protected System.Windows.Forms.ToolBarButton tbGuardar;
		private System.Windows.Forms.ToolBarButton tbStep3;
		protected System.Windows.Forms.ToolBarButton tbDelete;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Janus.Windows.GridEX.GridEX gridSPs;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.ListBox lstBxParameters;
		private System.Windows.Forms.ListBox lstBxFields;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSQL;
		private Infragistics.Win.Misc.UltraButton bExecute;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboFormato;
		private System.Windows.Forms.ComboBox comboAlineacion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboTipoEdicion;
		private System.Windows.Forms.ComboBox comboTipoColumna;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtGrilla;
		private Infragistics.Win.Misc.UltraButton bArriba;
		private Infragistics.Win.Misc.UltraButton bAbajo;
		private mz.erp.ui.controls.mzComboEditor mzCmbTareas;
		private mz.erp.ui.controls.mzComboEditor mzCmbProcesos;
		private mz.erp.ui.controls.mzComboEditor mzCmbPerfiles;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private Infragistics.Win.Misc.UltraButton utbBuscar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl chk;
		private System.Windows.Forms.CheckBox chkCombinar;
		private System.Windows.Forms.CheckBox chkSoloVisibles;
		private System.Windows.Forms.CheckBox chkSetVisibles;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtOrden;
		private System.ComponentModel.IContainer components;

		public frmConfiguracionLayoutGrilla(ConfigurarLayoutGrillasController uiController)
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
				_uiController.ObjectHasChanged -=new EventHandler(Refresh);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmConfiguracionLayoutGrilla));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkSetVisibles = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSQL = new System.Windows.Forms.TextBox();
			this.bExecute = new Infragistics.Win.Misc.UltraButton();
			this.lstBxParameters = new System.Windows.Forms.ListBox();
			this.gridSPs = new Janus.Windows.GridEX.GridEX();
			this.chk = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label12 = new System.Windows.Forms.Label();
			this.txtOrden = new System.Windows.Forms.TextBox();
			this.chkCombinar = new System.Windows.Forms.CheckBox();
			this.utbBuscar = new Infragistics.Win.Misc.UltraButton();
			this.label11 = new System.Windows.Forms.Label();
			this.mzCmbPerfiles = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbTareas = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbProcesos = new mz.erp.ui.controls.mzComboEditor();
			this.label10 = new System.Windows.Forms.Label();
			this.txtGrilla = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboTipoEdicion = new System.Windows.Forms.ComboBox();
			this.comboTipoColumna = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboFormato = new System.Windows.Forms.ComboBox();
			this.comboAlineacion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAncho = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lstBxFields = new System.Windows.Forms.ListBox();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chkSoloVisibles = new System.Windows.Forms.CheckBox();
			this.bAbajo = new Infragistics.Win.Misc.UltraButton();
			this.bArriba = new Infragistics.Win.Misc.UltraButton();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbFirst = new System.Windows.Forms.ToolBarButton();
			this.tbPrev = new System.Windows.Forms.ToolBarButton();
			this.tbNext = new System.Windows.Forms.ToolBarButton();
			this.tbLast = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbActualizar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbGuardar = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSPs)).BeginInit();
			this.chk.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPerfiles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTareas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProcesos)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkSetVisibles);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtSQL);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.bExecute);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lstBxParameters);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridSPs);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -203);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(878, 193);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// chkSetVisibles
			// 
			this.chkSetVisibles.BackColor = System.Drawing.Color.Transparent;
			this.chkSetVisibles.Checked = true;
			this.chkSetVisibles.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSetVisibles.Location = new System.Drawing.Point(512, 168);
			this.chkSetVisibles.Name = "chkSetVisibles";
			this.chkSetVisibles.Size = new System.Drawing.Size(176, 16);
			this.chkSetVisibles.TabIndex = 3;
			this.chkSetVisibles.Text = "Todas las columnas visibles";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label7.Location = new System.Drawing.Point(512, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 16);
			this.label7.TabIndex = 64;
			this.label7.Text = "SQL";
			// 
			// txtSQL
			// 
			this.txtSQL.Location = new System.Drawing.Point(512, 24);
			this.txtSQL.Multiline = true;
			this.txtSQL.Name = "txtSQL";
			this.txtSQL.Size = new System.Drawing.Size(288, 136);
			this.txtSQL.TabIndex = 2;
			this.txtSQL.Text = "";
			// 
			// bExecute
			// 
			this.bExecute.AcceptsFocus = false;
			this.bExecute.Location = new System.Drawing.Point(744, 168);
			this.bExecute.Name = "bExecute";
			this.bExecute.Size = new System.Drawing.Size(64, 22);
			this.bExecute.TabIndex = 4;
			this.bExecute.TabStop = false;
			this.bExecute.Text = "&Ejecutar";
			// 
			// lstBxParameters
			// 
			this.lstBxParameters.Location = new System.Drawing.Point(344, 8);
			this.lstBxParameters.Name = "lstBxParameters";
			this.lstBxParameters.Size = new System.Drawing.Size(144, 173);
			this.lstBxParameters.TabIndex = 1;
			// 
			// gridSPs
			// 
			this.gridSPs.AllowCardSizing = false;
			this.gridSPs.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridSPs.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridSPs.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridSPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridSPs.GroupByBoxVisible = false;
			this.gridSPs.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridSPs.Location = new System.Drawing.Point(8, 8);
			this.gridSPs.Name = "gridSPs";
			this.gridSPs.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridSPs.Size = new System.Drawing.Size(328, 176);
			this.gridSPs.TabIndex = 0;
			this.gridSPs.TabStop = false;
			// 
			// chk
			// 
			this.chk.Controls.Add(this.label12);
			this.chk.Controls.Add(this.txtOrden);
			this.chk.Controls.Add(this.chkCombinar);
			this.chk.Controls.Add(this.utbBuscar);
			this.chk.Controls.Add(this.label11);
			this.chk.Controls.Add(this.mzCmbPerfiles);
			this.chk.Controls.Add(this.mzCmbTareas);
			this.chk.Controls.Add(this.mzCmbProcesos);
			this.chk.Controls.Add(this.label10);
			this.chk.Controls.Add(this.txtGrilla);
			this.chk.Controls.Add(this.label6);
			this.chk.Controls.Add(this.label5);
			this.chk.Controls.Add(this.comboTipoEdicion);
			this.chk.Controls.Add(this.comboTipoColumna);
			this.chk.Controls.Add(this.label4);
			this.chk.Controls.Add(this.label3);
			this.chk.Controls.Add(this.comboFormato);
			this.chk.Controls.Add(this.comboAlineacion);
			this.chk.Controls.Add(this.label2);
			this.chk.Controls.Add(this.txtTitulo);
			this.chk.Controls.Add(this.label1);
			this.chk.Controls.Add(this.txtAncho);
			this.chk.Controls.Add(this.checkBox1);
			this.chk.Controls.Add(this.label8);
			this.chk.Controls.Add(this.label9);
			this.chk.Controls.Add(this.lstBxFields);
			this.chk.Location = new System.Drawing.Point(28, -153);
			this.chk.Name = "chk";
			this.chk.Size = new System.Drawing.Size(878, 239);
			this.chk.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label12.Location = new System.Drawing.Point(256, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 16);
			this.label12.TabIndex = 89;
			this.label12.Text = "Orden";
			// 
			// txtOrden
			// 
			this.txtOrden.AcceptsReturn = true;
			this.txtOrden.Location = new System.Drawing.Point(336, 112);
			this.txtOrden.Name = "txtOrden";
			this.txtOrden.Size = new System.Drawing.Size(64, 20);
			this.txtOrden.TabIndex = 68;
			this.txtOrden.Text = "";
			// 
			// chkCombinar
			// 
			this.chkCombinar.BackColor = System.Drawing.Color.Transparent;
			this.chkCombinar.Location = new System.Drawing.Point(400, 62);
			this.chkCombinar.Name = "chkCombinar";
			this.chkCombinar.Size = new System.Drawing.Size(88, 16);
			this.chkCombinar.TabIndex = 4;
			this.chkCombinar.Text = "Combinar";
			this.chkCombinar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// utbBuscar
			// 
			this.utbBuscar.AcceptsFocus = false;
			this.utbBuscar.Location = new System.Drawing.Point(336, 56);
			this.utbBuscar.Name = "utbBuscar";
			this.utbBuscar.Size = new System.Drawing.Size(64, 22);
			this.utbBuscar.TabIndex = 3;
			this.utbBuscar.TabStop = false;
			this.utbBuscar.Text = "&Buscar";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label11.Location = new System.Drawing.Point(600, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 16);
			this.label11.TabIndex = 85;
			this.label11.Text = "Perfil";
			// 
			// mzCmbPerfiles
			// 
			this.mzCmbPerfiles.AutoComplete = true;
			this.mzCmbPerfiles.DataSource = null;
			this.mzCmbPerfiles.DisplayMember = "";
			this.mzCmbPerfiles.DisplayMemberCaption = "";
			this.mzCmbPerfiles.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbPerfiles.Location = new System.Drawing.Point(656, 6);
			this.mzCmbPerfiles.MaxItemsDisplay = 50;
			this.mzCmbPerfiles.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbPerfiles.Name = "mzCmbPerfiles";
			this.mzCmbPerfiles.Size = new System.Drawing.Size(160, 21);
			this.mzCmbPerfiles.SorterMember = "";
			this.mzCmbPerfiles.TabIndex = 6;
			this.mzCmbPerfiles.ValueMember = "";
			this.mzCmbPerfiles.ValueMemberCaption = "";
			// 
			// mzCmbTareas
			// 
			this.mzCmbTareas.AutoComplete = true;
			this.mzCmbTareas.DataSource = null;
			this.mzCmbTareas.DisplayMember = "";
			this.mzCmbTareas.DisplayMemberCaption = "";
			this.mzCmbTareas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTareas.Location = new System.Drawing.Point(336, 32);
			this.mzCmbTareas.MaxItemsDisplay = 50;
			this.mzCmbTareas.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTareas.Name = "mzCmbTareas";
			this.mzCmbTareas.Size = new System.Drawing.Size(252, 21);
			this.mzCmbTareas.SorterMember = "";
			this.mzCmbTareas.TabIndex = 2;
			this.mzCmbTareas.ValueMember = "";
			this.mzCmbTareas.ValueMemberCaption = "";
			// 
			// mzCmbProcesos
			// 
			this.mzCmbProcesos.AutoComplete = true;
			this.mzCmbProcesos.DataSource = null;
			this.mzCmbProcesos.DisplayMember = "";
			this.mzCmbProcesos.DisplayMemberCaption = "";
			this.mzCmbProcesos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbProcesos.Location = new System.Drawing.Point(336, 6);
			this.mzCmbProcesos.MaxItemsDisplay = 50;
			this.mzCmbProcesos.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbProcesos.Name = "mzCmbProcesos";
			this.mzCmbProcesos.Size = new System.Drawing.Size(252, 21);
			this.mzCmbProcesos.SorterMember = "";
			this.mzCmbProcesos.TabIndex = 1;
			this.mzCmbProcesos.ValueMember = "";
			this.mzCmbProcesos.ValueMemberCaption = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label10.Location = new System.Drawing.Point(600, 34);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 81;
			this.label10.Text = "Grilla";
			// 
			// txtGrilla
			// 
			this.txtGrilla.AcceptsReturn = true;
			this.txtGrilla.Location = new System.Drawing.Point(656, 32);
			this.txtGrilla.Name = "txtGrilla";
			this.txtGrilla.Size = new System.Drawing.Size(160, 20);
			this.txtGrilla.TabIndex = 7;
			this.txtGrilla.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label6.Location = new System.Drawing.Point(600, 208);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 79;
			this.label6.Text = "Tipo de Columna";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label5.Location = new System.Drawing.Point(600, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 16);
			this.label5.TabIndex = 78;
			this.label5.Text = "Tipo de Edición";
			// 
			// comboTipoEdicion
			// 
			this.comboTipoEdicion.Items.AddRange(new object[] {
																  "CasillaDeVerificacion",
																  "CuadroDeTexto",
																  "Imagen",
																  "ImagenYTexto"});
			this.comboTipoEdicion.Location = new System.Drawing.Point(704, 208);
			this.comboTipoEdicion.Name = "comboTipoEdicion";
			this.comboTipoEdicion.Size = new System.Drawing.Size(121, 21);
			this.comboTipoEdicion.TabIndex = 9;
			// 
			// comboTipoColumna
			// 
			this.comboTipoColumna.Items.AddRange(new object[] {
																  "NoEditable",
																  "CasillaDeVerificacion",
																  "CalendarioCombo",
																  "CalendarioDropDown",
																  "ComboBox",
																  "CuadroDeTexto",
																  "Personalizado"});
			this.comboTipoColumna.Location = new System.Drawing.Point(704, 184);
			this.comboTipoColumna.Name = "comboTipoColumna";
			this.comboTipoColumna.Size = new System.Drawing.Size(121, 21);
			this.comboTipoColumna.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label4.Location = new System.Drawing.Point(256, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 75;
			this.label4.Text = "Formato";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Location = new System.Drawing.Point(256, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 74;
			this.label3.Text = "Alineación";
			// 
			// comboFormato
			// 
			this.comboFormato.Items.AddRange(new object[] {
															  "Moneda",
															  "Porcentaje",
															  "Fecha",
															  "Fecha corta",
															  "Entero",
															  "Decimal",
															  "Decimal+-0",
															  "Default"});
			this.comboFormato.Location = new System.Drawing.Point(336, 208);
			this.comboFormato.Name = "comboFormato";
			this.comboFormato.Size = new System.Drawing.Size(121, 21);
			this.comboFormato.TabIndex = 72;
			// 
			// comboAlineacion
			// 
			this.comboAlineacion.Items.AddRange(new object[] {
																 "Izquierda",
																 "Centrada",
																 "Derecha"});
			this.comboAlineacion.Location = new System.Drawing.Point(336, 184);
			this.comboAlineacion.Name = "comboAlineacion";
			this.comboAlineacion.Size = new System.Drawing.Size(121, 21);
			this.comboAlineacion.TabIndex = 71;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Location = new System.Drawing.Point(256, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 71;
			this.label2.Text = "Título";
			// 
			// txtTitulo
			// 
			this.txtTitulo.AcceptsReturn = true;
			this.txtTitulo.Location = new System.Drawing.Point(336, 136);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(160, 20);
			this.txtTitulo.TabIndex = 69;
			this.txtTitulo.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Location = new System.Drawing.Point(256, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 69;
			this.label1.Text = "Ancho";
			// 
			// txtAncho
			// 
			this.txtAncho.AcceptsReturn = true;
			this.txtAncho.Location = new System.Drawing.Point(336, 160);
			this.txtAncho.Name = "txtAncho";
			this.txtAncho.Size = new System.Drawing.Size(64, 20);
			this.txtAncho.TabIndex = 70;
			this.txtAncho.Text = "";
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(256, 88);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBox1.Size = new System.Drawing.Size(96, 16);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Visible";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label8.Location = new System.Drawing.Point(256, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 66;
			this.label8.Text = "Tarea";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label9.Location = new System.Drawing.Point(256, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 64;
			this.label9.Text = "Proceso";
			// 
			// lstBxFields
			// 
			this.lstBxFields.Location = new System.Drawing.Point(8, 0);
			this.lstBxFields.Name = "lstBxFields";
			this.lstBxFields.Size = new System.Drawing.Size(232, 238);
			this.lstBxFields.Sorted = true;
			this.lstBxFields.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.chkSoloVisibles);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.bAbajo);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.bArriba);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 145);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(878, 272);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// chkSoloVisibles
			// 
			this.chkSoloVisibles.BackColor = System.Drawing.Color.Transparent;
			this.chkSoloVisibles.Location = new System.Drawing.Point(152, 8);
			this.chkSoloVisibles.Name = "chkSoloVisibles";
			this.chkSoloVisibles.Size = new System.Drawing.Size(152, 16);
			this.chkSoloVisibles.TabIndex = 2;
			this.chkSoloVisibles.Text = "Solo visibles";
			// 
			// bAbajo
			// 
			this.bAbajo.AcceptsFocus = false;
			this.bAbajo.Location = new System.Drawing.Point(64, 5);
			this.bAbajo.Name = "bAbajo";
			this.bAbajo.Size = new System.Drawing.Size(64, 22);
			this.bAbajo.TabIndex = 1;
			this.bAbajo.TabStop = false;
			this.bAbajo.Text = "&Abajo";
			// 
			// bArriba
			// 
			this.bArriba.AcceptsFocus = false;
			this.bArriba.Location = new System.Drawing.Point(0, 5);
			this.bArriba.Name = "bArriba";
			this.bArriba.Size = new System.Drawing.Size(64, 22);
			this.bArriba.TabIndex = 0;
			this.bArriba.TabStop = false;
			this.bArriba.Text = "&Arriba";
			// 
			// gridEX1
			// 
			this.gridEX1.AllowCardSizing = false;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.DefaultForeColorAlphaMode = Janus.Windows.GridEX.AlphaMode.UseAlpha;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EmptyRows = true;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX1.Location = new System.Drawing.Point(0, 32);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridEX1.Size = new System.Drawing.Size(872, 232);
			this.gridEX1.TabIndex = 3;
			this.gridEX1.TabStop = false;
			this.gridEX1.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridEX1_FormattingRow);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbFirst,
																							  this.tbPrev,
																							  this.tbNext,
																							  this.tbLast,
																							  this.toolBarButton5,
																							  this.tbActualizar,
																							  this.toolBarButton7,
																							  this.tbGuardar,
																							  this.tbStep3,
																							  this.tbDelete});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbFirst
			// 
			this.tbFirst.ImageIndex = 0;
			this.tbFirst.Visible = false;
			// 
			// tbPrev
			// 
			this.tbPrev.ImageIndex = 1;
			this.tbPrev.Visible = false;
			// 
			// tbNext
			// 
			this.tbNext.ImageIndex = 2;
			this.tbNext.Visible = false;
			// 
			// tbLast
			// 
			this.tbLast.ImageIndex = 3;
			this.tbLast.Visible = false;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton5.Visible = false;
			// 
			// tbActualizar
			// 
			this.tbActualizar.ImageIndex = 5;
			this.tbActualizar.Visible = false;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton7.Visible = false;
			// 
			// tbGuardar
			// 
			this.tbGuardar.ImageIndex = 4;
			this.tbGuardar.Text = "&Guardar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbStep3.Visible = false;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 7;
			this.tbDelete.Text = "Borrar";
			this.tbDelete.Visible = false;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.chk);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 193;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			ultraExplorerBarGroup2.Container = this.chk;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 239;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Campos";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 272;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(944, 442);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// frmConfiguracionLayoutGrilla
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(944, 470);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "frmConfiguracionLayoutGrilla";
			this.Text = "frmConfiguracionLayoutGrilla";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSPs)).EndInit();
			this.chk.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPerfiles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTareas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProcesos)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}

		#region Inicializadores
		private void ConfigureInterface()
		{
			gridSPs.LayoutData = _uiController.LayoutSPTable;
			gridSPs.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridEX1.LayoutData = _uiController.LayoutColumnsProperties;
			gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			mzCmbProcesos.FillFromDataSource( _uiController.Procesos, _uiController.KeyValueProcesos,_uiController.KeyListProcesos,100, _uiController.KeyListProcesos );
			mzCmbTareas.FillFromDataSource( _uiController.Tareas, _uiController.KeyValueTareas,_uiController.KeyListTareas,100, _uiController.KeyListTareas );
			mzCmbPerfiles.FillFromDataSource( _uiController.Perfiles, _uiController.KeyValuePerfiles,_uiController.KeyListPerfiles,100, _uiController.KeyListPerfiles );

		}

		private void InitializeData()
		{
			
		}
		private void InitEventHandlers()
		{			
			_uiController.ObjectHasChanged +=new EventHandler(Refresh);
			gridSPs.SelectionChanged +=new EventHandler(gridSPs_SelectionChanged);
			_uiController.ColumnsHasChanged +=new EventHandler(ColumnsHasChanged);
			_uiController.SelectedItemChanged +=new EventHandler(Refresh);
			bExecute.Click +=new EventHandler(bExecute_Click);
			bAbajo.Click +=new EventHandler(bAbajo_Click);
			bArriba.Click +=new EventHandler(bArriba_Click);
			lstBxFields.SelectedIndexChanged +=new EventHandler(lstBxFields_SelectedIndexChanged);			
			this._uiController.ProcesoHasChanged +=new EventHandler(_uiController_TiposHasChanged);
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
			this.Closed +=new EventHandler(frmConfiguracionLayoutGrilla_Closed);
			this.utbBuscar.Click +=new EventHandler(utbBuscar_Click);
			this.chkSoloVisibles.Click +=new EventHandler(chkSoloVisibles_Click);
			this.chkSetVisibles.Click +=new EventHandler(chkSetVisibles_Click);
		}	

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 7:
					_uiController.Execute();
					break;
			
			}				
		}

		private void ColumnsHasChanged(object sender, EventArgs e)
		{
			lstBxFields.DataSource = null;
			lstBxFields.DataSource = _uiController.Columns;
			//lstBxFields.SelectedIndex = _uiController.SetIndex;			
			gridEX1.Row = _uiController.SetIndex;
		}		
	
		private void InitDataBindings()
		{
			gridSPs.SetDataBinding(_uiController.SPTable, null);
			txtOrden.DataBindings.Add("Text", _uiController,"ColumnOrder");
			txtTitulo.DataBindings.Add("Text", _uiController,"ColumnCaption");
			checkBox1.DataBindings.Add("Checked", _uiController, "ColumnVisible");
			txtAncho.DataBindings.Add("Text", _uiController, "ColumnWidth");							
			comboAlineacion.DataBindings.Add("Text", _uiController, "ColumnAlignment");
			comboFormato.DataBindings.Add("Text", _uiController, "ColumnFormat");
			comboTipoColumna.DataBindings.Add("Text", _uiController, "ColumnEditType");
			comboTipoEdicion.DataBindings.Add("Text", _uiController, "ColumnType");			
			gridEX1.SetDataBinding(_uiController.ColumnsProperties,null);
			txtGrilla.DataBindings.Add("Text", _uiController, "GridName");

			chkCombinar.DataBindings.Add("Checked", _uiController, "Merge");
			
			BindingController.Bind(mzCmbProcesos,"Value", _uiController, "IdProceso");
			BindingController.Bind(mzCmbTareas,"Value", _uiController, "IdTarea");
			BindingController.Bind(mzCmbPerfiles,"Value", _uiController, "IdPerfil");
		}
				
		#endregion


		#region Miembros de ITaskForm

		private ConfigurarLayoutGrillasController _uiController;

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
				this.Show();
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
			Close();			
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}

		#endregion

		private void gridSPs_SelectionChanged(object sender, EventArgs e)
		{
			if(gridSPs.SelectedItems.Count > 0)
			{
				string spName = Convert.ToString(gridSPs.SelectedItems[0].GetRow().Cells["name"].Value);
				lstBxParameters.DataSource = _uiController.GetSPParameters(spName);
			}
		}

		private void bAbajo_Click(object sender, EventArgs e)
		{			
			int indice = Convert.ToInt32(gridEX1.SelectedItems[0].GetRow().Cells["order"].Value);			
			_uiController.Abajo(indice);			
		}

		private void bArriba_Click(object sender, EventArgs e)
		{			
			int indice = Convert.ToInt32(gridEX1.SelectedItems[0].GetRow().Cells["order"].Value);			
			_uiController.Arriba(indice);
		}

		private void bExecute_Click(object sender, EventArgs e)
		{
			//lstBxFields.Items.Clear();
			lstBxFields.DataSource = _uiController.GetSPColumns(txtSQL.Text);			
		}

		private void lstBxFields_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lstBxFields.SelectedItem != null)
				_uiController.SelectedItem = lstBxFields.SelectedItem;
		}

		private void Refresh(object sender, EventArgs e)
		{			
			gridEX1.SetDataBinding(null, null);
			gridEX1.SetDataBinding(_uiController.ColumnsProperties, null);
		}
		
		private void frmConfiguracionLayoutGrilla_Closed(object sender, EventArgs e)
		{
			ClearDataBindings();
			ClearEventHandlers();		
		}

		private void ClearDataBindings()
		{			
			BindingController.Clear(mzCmbProcesos,"Value", _uiController, "IdProceso");
			BindingController.Clear(mzCmbTareas,"Value", _uiController, "IdTarea");	
			BindingController.Clear(mzCmbPerfiles,"Value", _uiController, "IdPerfil");	
		}

		private void ClearEventHandlers()
		{		
			this.Closed -=new EventHandler(frmConfiguracionLayoutGrilla_Closed);						
		}
		private void _uiController_TiposHasChanged(object sender, EventArgs e)
		{
			mzCmbTareas.FillFromDataSource( _uiController.Tareas, _uiController.KeyValueTareas,_uiController.KeyListTareas,100, _uiController.KeyListTareas );
/*			if (mzCmbProcesos.Value != null) 
			{														
				if (_uiController.CantidadSubTipos <= 1) 
				{					
					this.mzCmbSubTipos.Enabled = false;								
				}
				else 
				{					
					this.mzCmbSubTipos.Enabled = true;
					
				}
			}*/
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void utbBuscar_Click(object sender, EventArgs e)
		{
			this.gridSPs.Focus();
			lstBxFields.DataSource = _uiController.SearchColumnsProperties();		
			Refresh();
		}

		private void chkSoloVisibles_Click(object sender, EventArgs e)
		{
			if (chkSoloVisibles.Checked)
			{
				Janus.Windows.GridEX.GridEXColumn column = gridEX1.RootTable.Columns["Visible"];
				Janus.Windows.GridEX.ConditionOperator condicion = Janus.Windows.GridEX.ConditionOperator.Equal;
				Janus.Windows.GridEX.GridEXFilterCondition filtro =new Janus.Windows.GridEX.GridEXFilterCondition(column, condicion, true);
				gridEX1.RootTable.FilterCondition = filtro;
			}
			else 
			{
				gridEX1.RootTable.FilterCondition = null;
			}

		}

		private void chkSetVisibles_Click(object sender, EventArgs e)
		{
			_uiController.VisibleDefault = chkSetVisibles.Checked;

		}

		private void gridEX1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}
	}
}

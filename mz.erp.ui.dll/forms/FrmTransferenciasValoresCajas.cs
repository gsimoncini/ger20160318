using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmTransferenciasValoresCajas.
	/// </summary>
	public class FrmTransferenciasValoresCajas : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private Janus.Windows.GridEX.GridEX gridValoresDisponibles;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Janus.Windows.GridEX.GridEX gridValoresATransferir;
		private mz.erp.ui.controls.mzComboEditor mzComboCajasOrigen;
		private mz.erp.ui.controls.mzComboEditor mzComboCajasDestino;
		private System.Windows.Forms.Label lblRespDestino;
		private System.Windows.Forms.Label lblRespOrigen;
		private System.Windows.Forms.Button btnTransferir;
		private System.Windows.Forms.Button btnTransferirTodo;
		private System.Windows.Forms.Button btnRemover;
		private System.Windows.Forms.Button btnRemoverTodo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbRefresh;
		private System.ComponentModel.IContainer components;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmTransferenciasValoresCajas));
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.mzComboCajasDestino = new mz.erp.ui.controls.mzComboEditor();
			this.mzComboCajasOrigen = new mz.erp.ui.controls.mzComboEditor();
			this.lblRespDestino = new System.Windows.Forms.Label();
			this.lblRespOrigen = new System.Windows.Forms.Label();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnTransferir = new System.Windows.Forms.Button();
			this.btnRemoverTodo = new System.Windows.Forms.Button();
			this.btnTransferirTodo = new System.Windows.Forms.Button();
			this.gridValoresATransferir = new Janus.Windows.GridEX.GridEX();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.gridValoresDisponibles = new Janus.Windows.GridEX.GridEX();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboCajasDestino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboCajasOrigen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridValoresATransferir)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridValoresDisponibles)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(903, 24);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(903, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.mzComboCajasDestino);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.mzComboCajasOrigen);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.lblRespDestino);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.lblRespOrigen);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.btnRemover);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.btnTransferir);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.btnRemoverTodo);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.btnTransferirTodo);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.gridValoresATransferir);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.label9);
			this.ultraExplorerBarContainerControl4.Controls.Add(this.gridValoresDisponibles);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(903, 429);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// uneTotal
			// 
			appearance1.BackColor = System.Drawing.Color.Transparent;
			this.uneTotal.Appearance = appearance1;
			this.uneTotal.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
			this.uneTotal.Enabled = false;
			this.uneTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.uneTotal.Location = new System.Drawing.Point(784, 392);
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.PromptChar = ' ';
			this.uneTotal.ReadOnly = true;
			this.uneTotal.Size = new System.Drawing.Size(112, 27);
			this.uneTotal.TabIndex = 4;
			this.uneTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneTotal.TabStop = false;
			// 
			// mzComboCajasDestino
			// 
			this.mzComboCajasDestino.AutoComplete = true;
			this.mzComboCajasDestino.DataSource = null;
			this.mzComboCajasDestino.DisplayMember = "";
			this.mzComboCajasDestino.DisplayMemberCaption = "";
			this.mzComboCajasDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboCajasDestino.Location = new System.Drawing.Point(482, 32);
			this.mzComboCajasDestino.MaxItemsDisplay = 50;
			this.mzComboCajasDestino.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboCajasDestino.Name = "mzComboCajasDestino";
			this.mzComboCajasDestino.Size = new System.Drawing.Size(415, 21);
			this.mzComboCajasDestino.SorterMember = "";
			this.mzComboCajasDestino.TabIndex = 1;
			this.mzComboCajasDestino.ValueMember = "";
			this.mzComboCajasDestino.ValueMemberCaption = "";
			// 
			// mzComboCajasOrigen
			// 
			this.mzComboCajasOrigen.AutoComplete = true;
			this.mzComboCajasOrigen.DataSource = null;
			this.mzComboCajasOrigen.DisplayMember = "";
			this.mzComboCajasOrigen.DisplayMemberCaption = "";
			this.mzComboCajasOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboCajasOrigen.Location = new System.Drawing.Point(0, 32);
			this.mzComboCajasOrigen.MaxItemsDisplay = 50;
			this.mzComboCajasOrigen.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboCajasOrigen.Name = "mzComboCajasOrigen";
			this.mzComboCajasOrigen.Size = new System.Drawing.Size(415, 21);
			this.mzComboCajasOrigen.SorterMember = "";
			this.mzComboCajasOrigen.TabIndex = 0;
			this.mzComboCajasOrigen.ValueMember = "";
			this.mzComboCajasOrigen.ValueMemberCaption = "";
			// 
			// lblRespDestino
			// 
			this.lblRespDestino.BackColor = System.Drawing.Color.Transparent;
			this.lblRespDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRespDestino.Location = new System.Drawing.Point(482, 56);
			this.lblRespDestino.Name = "lblRespDestino";
			this.lblRespDestino.Size = new System.Drawing.Size(400, 23);
			this.lblRespDestino.TabIndex = 70;
			this.lblRespDestino.Text = "Resp";
			// 
			// lblRespOrigen
			// 
			this.lblRespOrigen.BackColor = System.Drawing.Color.Transparent;
			this.lblRespOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRespOrigen.Location = new System.Drawing.Point(0, 56);
			this.lblRespOrigen.Name = "lblRespOrigen";
			this.lblRespOrigen.Size = new System.Drawing.Size(400, 23);
			this.lblRespOrigen.TabIndex = 69;
			this.lblRespOrigen.Text = "Resp";
			// 
			// btnRemover
			// 
			this.btnRemover.Enabled = false;
			this.btnRemover.Location = new System.Drawing.Point(424, 160);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(48, 16);
			this.btnRemover.TabIndex = 66;
			this.btnRemover.Text = "<";
			// 
			// btnTransferir
			// 
			this.btnTransferir.Enabled = false;
			this.btnTransferir.Location = new System.Drawing.Point(424, 112);
			this.btnTransferir.Name = "btnTransferir";
			this.btnTransferir.Size = new System.Drawing.Size(48, 16);
			this.btnTransferir.TabIndex = 65;
			this.btnTransferir.Text = ">";
			// 
			// btnRemoverTodo
			// 
			this.btnRemoverTodo.Enabled = false;
			this.btnRemoverTodo.Location = new System.Drawing.Point(424, 144);
			this.btnRemoverTodo.Name = "btnRemoverTodo";
			this.btnRemoverTodo.Size = new System.Drawing.Size(48, 16);
			this.btnRemoverTodo.TabIndex = 64;
			this.btnRemoverTodo.Text = "<<";
			// 
			// btnTransferirTodo
			// 
			this.btnTransferirTodo.Enabled = false;
			this.btnTransferirTodo.Location = new System.Drawing.Point(424, 128);
			this.btnTransferirTodo.Name = "btnTransferirTodo";
			this.btnTransferirTodo.Size = new System.Drawing.Size(48, 16);
			this.btnTransferirTodo.TabIndex = 63;
			this.btnTransferirTodo.Text = ">>";
			// 
			// gridValoresATransferir
			// 
			this.gridValoresATransferir.AllowCardSizing = false;
			this.gridValoresATransferir.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridValoresATransferir.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridValoresATransferir.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridValoresATransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridValoresATransferir.GroupByBoxVisible = false;
			this.gridValoresATransferir.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridValoresATransferir.Location = new System.Drawing.Point(482, 82);
			this.gridValoresATransferir.Name = "gridValoresATransferir";
			this.gridValoresATransferir.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridValoresATransferir.Size = new System.Drawing.Size(415, 302);
			this.gridValoresATransferir.TabIndex = 3;
			this.gridValoresATransferir.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 61;
			this.label1.Text = "Origen";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(482, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 60;
			this.label9.Text = "Destino";
			// 
			// gridValoresDisponibles
			// 
			this.gridValoresDisponibles.AllowCardSizing = false;
			this.gridValoresDisponibles.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridValoresDisponibles.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridValoresDisponibles.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridValoresDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridValoresDisponibles.GroupByBoxVisible = false;
			this.gridValoresDisponibles.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridValoresDisponibles.Location = new System.Drawing.Point(0, 82);
			this.gridValoresDisponibles.Name = "gridValoresDisponibles";
			this.gridValoresDisponibles.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridValoresDisponibles.Size = new System.Drawing.Size(415, 302);
			this.gridValoresDisponibles.TabIndex = 2;
			this.gridValoresDisponibles.TabStop = false;
			this.gridValoresDisponibles.DoubleClick += new System.EventHandler(this.gridValoresDisponibles_DoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar1);
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(952, 630);
			this.panel1.TabIndex = 0;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 429;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Cajas a realizar la transferencia";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(952, 602);
			this.ultraExplorerBar1.TabIndex = 43;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.tbbSeparator2,
																							  this.tbbRefresh,
																							  this.tbbSeparator3,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(952, 28);
			this.toolBarStandar.TabIndex = 42;
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
			// tbbRefresh
			// 
			this.tbbRefresh.ImageIndex = 2;
			this.tbbRefresh.Text = "Ejecutar Consulta [F5]";
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			// FrmTransferenciasValoresCajas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(952, 630);
			this.Controls.Add(this.panel1);
			this.Name = "FrmTransferenciasValoresCajas";
			this.Text = "Transferencia de valores entre cajas";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboCajasDestino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboCajasOrigen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridValoresATransferir)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridValoresDisponibles)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region constructores / destructores
		public FrmTransferenciasValoresCajas()
		{
			InitializeComponent();
		}

		public FrmTransferenciasValoresCajas( ui.controllers.TransferenciasValoresCajasController uiController)
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
				BindingController.Clear(mzComboCajasOrigen,"Value", _uiController,"KeyValueCajaOrigen");
				BindingController.Clear(mzComboCajasDestino,"Value", _uiController,"KeyValueCajaDestino");
				BindingController.Clear(lblRespOrigen,"Text", _uiController,"ResponsableCajaOrigen");
				BindingController.Clear(lblRespDestino,"Text", _uiController,"ResponsableCajaDestino");
				BindingController.Clear(uneTotal,"Value", _uiController,"TotalATransferir");	
				_uiController.KeyValueCajaOrigenChanged-=new EventHandler(_uiController_KeyValueCajaOrigenChanged);
				_uiController.KeyValueCajaDestinoChanged-=new EventHandler(_uiController_KeyValueCajaDestinoChanged);
				_uiController.ValoresATransferirChanged-=new EventHandler(_uiController_ValoresATransferirChanged);
			}
			base.Dispose( disposing );
		}


		#endregion

		#region variables

		private mz.erp.ui.controllers.TransferenciasValoresCajasController _uiController;

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
			//por problemas del focus uso el UpdateData();
			gridValoresDisponibles.UpdateData();
			gridValoresATransferir.UpdateData();
			Util.MoveFocus(this.ultraExplorerBarContainerControl4);						
			_uiController.Execute();
		}

		#endregion

		#region metodos

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
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			labelTarea.Text = _uiController.LeyendaFormulario;		
			
			gridValoresDisponibles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridValoresATransferir.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;

			gridValoresDisponibles.LayoutData = _uiController.LayoutDetalleValoresDisponibles;
			gridValoresATransferir.LayoutData = _uiController.LayoutDetalleValoresATransferir;

			this.uneTotal.MaskInput = "{LOC}nnnnnnn.nn";		
			KeyPreview = true;

		}
		private void InitializeData() 
		{
			this.mzComboCajasOrigen.FillFromDataSource( _uiController.CajasOrigenDisponible, _uiController.CajaOrigenValueMember, _uiController.CajaOrigenDisplayMember, 8, _uiController.CajaOrigenDisplayMember);
			this.mzComboCajasDestino.FillFromDataSource( _uiController.CajasDestinoDisponible, _uiController.CajaDestinoValueMember, _uiController.CajaDestinoDisplayMember, 8, _uiController.CajaDestinoDisplayMember);
		}
		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			this.btnTransferir.Click+=new EventHandler(btnTransferir_Click);
			this.btnTransferirTodo.Click+=new EventHandler(btnTransferirTodo_Click);
			this.btnRemover.Click+=new EventHandler(btnRemover_Click);
			this.btnRemoverTodo.Click+=new EventHandler(btnRemoverTodo_Click);
			this.KeyDown+=new System.Windows.Forms.KeyEventHandler(FrmTransferenciasValoresCajas_KeyDown);	
			this.ultraExplorerBar1.KeyDown+=new System.Windows.Forms.KeyEventHandler(FrmTransferenciasValoresCajas_KeyDown);	
			this.gridValoresDisponibles.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridValoresDisponibles_Error);
			this.gridValoresATransferir.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridValoresDisponibles_Error);

			_uiController.KeyValueCajaOrigenChanged+=new EventHandler(_uiController_KeyValueCajaOrigenChanged);
			_uiController.KeyValueCajaDestinoChanged+=new EventHandler(_uiController_KeyValueCajaDestinoChanged);
			_uiController.ValoresATransferirChanged+=new EventHandler(_uiController_ValoresATransferirChanged);
			//_uiController.TotalATransferirChanged+=new EventHandler(_uiController_TotalATransferirChanged);
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		}
		private void InitDataBindings()
		{		
			BindingController.Bind(mzComboCajasOrigen,"Value", _uiController,"KeyValueCajaOrigen");
			BindingController.Bind(mzComboCajasDestino,"Value", _uiController,"KeyValueCajaDestino");
			BindingController.Bind(lblRespOrigen,"Text", _uiController,"ResponsableCajaOrigen");
			BindingController.Bind(lblRespDestino,"Text", _uiController,"ResponsableCajaDestino");
			BindingController.Bind(uneTotal,"Value", _uiController,"TotalATransferir");					


			//BindingController.Bind(gridValoresATransferir,"get_DataSource", _uiController,"ValoresATransferir");
		}

		
		/*private void comboCajasOrigen_SelectedValueChanged(object sender, EventArgs e)
		{   // castear al tipo de elementos de la coleccion de Oscar Con la cajas Origen
			// valor = (InstanciaCaja)comboCajasOrigen.SelectedItem;
			//Console.WriteLine(valor.Id);
			object objeto = comboCajasOrigen.SelectedItem;
			_uiController.KeyValueCajaOrigen = objeto;
		}*/
		
		/*private void comboCajasDestino_SelectedValueChanged(object sender, EventArgs e)
		{
			//castear al tipo de elementos de la coleccion de Oscar Con la cajas destino
			//  valor = (InstanciaCaja)comboCajasDestino.SelectedItem;
		}*/

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: _uiController.Previous(); 
					break;
				case 2: 
				{
					//por problemas del focus uso el UpdateData();
					gridValoresDisponibles.UpdateData();
					gridValoresATransferir.UpdateData();
					Util.MoveFocus(this.ultraExplorerBarContainerControl4);						
					_uiController.Execute();
					break;
				}
				case 4:
				{
					RefrescarCajaOrigen();
					break;
				}
				case 6:
				{
					CloseForm();
					break;
				}

			}
		}
		
		#endregion

		#region Otros Métodos
		private void HabilitarBotonesTransferir(bool habilitar) 
		{
			btnTransferir.Enabled = habilitar;
			btnTransferirTodo.Enabled = habilitar;
		}
		private void HabilitarBotonesRemover(bool habilitar) 
		{
			btnRemover.Enabled = habilitar;
			btnRemoverTodo.Enabled = habilitar;
		}
		#endregion



		private void gridValoresDisponibles_DoubleClick(object sender, System.EventArgs e)
		{
			if(gridValoresDisponibles.SelectedItems.Count > 0)
			{
				Janus.Windows.GridEX.GridEXRow row = gridValoresDisponibles.SelectedItems[0].GetRow();

				string IdTDCompTesoreria = Convert.ToString(row.Cells["IdTDCompTesoreria"].Value);
				bool agrupado = Convert.ToBoolean(row.Cells["Agrupado"].Value);
				string IdMoneda = Convert.ToString(row.Cells["IdMoneda"].Value);
				decimal ValorDefault = Convert.ToDecimal(row.Cells["ValorDestino"].Value);
				//ver bien el valor 0 q se le pasa al form
				//ojo modif cheque
				FrmValores form = new FrmValores(IdTDCompTesoreria,IdMoneda, ValorDefault,0,agrupado,null,this._uiController, string.Empty); 
			}
		}

		private void _uiController_KeyValueCajaOrigenChanged(object sender, EventArgs e)
		{								
			CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.ValoresDisponibles];
			cm.Refresh();
			gridValoresDisponibles.DataBindings.Clear();
			gridValoresDisponibles.SetDataBinding(_uiController.ValoresDisponibles, null);
			HabilitarBotonesTransferir(_uiController.PuedoHabilitarBotonesTransferir());		
		}

		private void _uiController_KeyValueCajaDestinoChanged(object sender, EventArgs e)
		{			
			gridValoresATransferir.DataBindings.Clear();
			gridValoresATransferir.SetDataBinding(_uiController.ValoresATransferir, null);
			HabilitarBotonesRemover(_uiController.PuedoHabilitarBotonesRemover());
			HabilitarBotonesTransferir(_uiController.PuedoHabilitarBotonesTransferir());
		}

		private void RefrescarCajaOrigen()
		{
			_uiController.RefreshDataOrigen();
			gridValoresDisponibles.DataBindings.Clear();
			gridValoresDisponibles.SetDataBinding(_uiController.ValoresDisponibles, null);
			HabilitarBotonesTransferir(_uiController.PuedoHabilitarBotonesTransferir());
		}

		private void _uiController_ValoresATransferirChanged(object sender, EventArgs e)
		{
			
			gridValoresATransferir.DataBindings.Clear();
			
			try 
			{
				//Si no se agrega dentro de un try/catch sale un error en tiempo de ejecución cuando se borra la última fila de la grilla cuando la cantidad de filas es > 1
				gridValoresATransferir.SetDataBinding(_uiController.ValoresATransferir, null);
			}
			catch
			{
			}

			HabilitarBotonesRemover(_uiController.PuedoHabilitarBotonesRemover());
		}

		private void _uiController_TotalATransferirChanged(object sender, EventArgs e)
		{
			BindingController.Clear(uneTotal,"Value", _uiController,"TotalATransferir");
			BindingController.Bind(uneTotal,"Value", _uiController,"TotalATransferir");
		}

		private void btnTransferir_Click(object sender, System.EventArgs e)
		{					
			ArrayList array = new ArrayList();
			for (int index = 0; index < gridValoresDisponibles.SelectedItems.Count; index++) 
			{				
				Janus.Windows.GridEX.GridEXRow row = gridValoresDisponibles.SelectedItems[index].GetRow();											
				array.Add(row.Cells["IdValor"].Value);
			}
			_uiController.Transferir(array);
		}
		private void btnTransferirTodo_Click(object sender, System.EventArgs e)
		{
			_uiController.TransferirTodo();
		}
		private void btnRemover_Click(object sender, System.EventArgs e) 
		{
			ArrayList array = new ArrayList();
			for (int index = 0; index < gridValoresATransferir.SelectedItems.Count; index++) 
			{				
				Janus.Windows.GridEX.GridEXRow row = gridValoresATransferir.SelectedItems[index].GetRow();											
				array.Add(row.Cells["IdValor"].Value);
			}			
			_uiController.Remover(array);
		}
		private void btnRemoverTodo_Click(object sender, System.EventArgs e) 
		{
			_uiController.RemoverTodo();
		}

		private void FrmTransferenciasValoresCajas_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{			
			if(e.KeyCode == System.Windows.Forms.Keys.F5)
			{
				RefrescarCajaOrigen();
			}
		}

		private void gridValoresDisponibles_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}
	}
}

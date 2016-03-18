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
	/// Descripción breve de FrmPagosGastosServicios.
	/// </summary>
	public class FrmPagosGastosServicios : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl gridComprobantes;
		private Infragistics.Win.Misc.UltraLabel ultraLabel13;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private Infragistics.Win.Misc.UltraLabel ultraLabel11;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label tarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.Misc.UltraButton ubBuscar;
		private Infragistics.Win.Misc.UltraButton ubEliminar;
		private Infragistics.Win.Misc.UltraButton ubAgregar;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private System.Windows.Forms.Label label4;
		private Janus.Windows.GridEX.GridEX gridEXValores;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsable;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFecha;
		private System.ComponentModel.IContainer components;
		private Infragistics.Win.Misc.UltraButton utbNinguno;
		private Infragistics.Win.Misc.UltraButton utbTodos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalSeleccionados;
		private System.Windows.Forms.Label label1;

		#region Variables Privadas

			private mz.erp.ui.controllers.PagarServiciosGastosComprasController _uiController;

		#endregion
		
		#region Construtores y Destructores

		public FrmPagosGastosServicios(PagarServiciosGastosComprasController UIController)
		{
			InitializeComponent();
			_uiController = UIController;
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
				_uiController.OnControllerChanged -= new EventHandler( this.ListenerControllerChanges );
				_uiController.ComprobantesSelectedChanged -=new EventHandler(_uiController_ComprobantesSelectedChanged);
				BindingController.Clear(mzCEResponsable,"Value", _uiController, "IdResponsable");
				BindingController.Clear(mzCEInstanciasCaja,"Value", _uiController, "IdInstanciaCaja");
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPagosGastosServicios));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.tarea = new System.Windows.Forms.Label();
			this.gridComprobantes = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneTotalSeleccionados = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.utbNinguno = new Infragistics.Win.Misc.UltraButton();
			this.utbTodos = new Infragistics.Win.Misc.UltraButton();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCEResponsable = new mz.erp.ui.controls.mzComboEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
			this.uccFecha = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ubBuscar = new Infragistics.Win.Misc.UltraButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ubEliminar = new Infragistics.Win.Misc.UltraButton();
			this.ubAgregar = new Infragistics.Win.Misc.UltraButton();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.gridEXValores = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.gridComprobantes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalSeleccionados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFecha)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.tarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, -28);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(886, 25);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// tarea
			// 
			this.tarea.BackColor = System.Drawing.Color.Transparent;
			this.tarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.tarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tarea.Location = new System.Drawing.Point(0, 0);
			this.tarea.Name = "tarea";
			this.tarea.Size = new System.Drawing.Size(886, 23);
			this.tarea.TabIndex = 1;
			this.tarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gridComprobantes
			// 
			this.gridComprobantes.Controls.Add(this.uneTotalSeleccionados);
			this.gridComprobantes.Controls.Add(this.label1);
			this.gridComprobantes.Controls.Add(this.utbNinguno);
			this.gridComprobantes.Controls.Add(this.utbTodos);
			this.gridComprobantes.Controls.Add(this.ultraLabel1);
			this.gridComprobantes.Controls.Add(this.gridEX1);
			this.gridComprobantes.Controls.Add(this.ultraLabel13);
			this.gridComprobantes.Controls.Add(this.mzCEResponsable);
			this.gridComprobantes.Controls.Add(this.label3);
			this.gridComprobantes.Controls.Add(this.mzCEInstanciasCaja);
			this.gridComprobantes.Controls.Add(this.ultraLabel11);
			this.gridComprobantes.Controls.Add(this.uccFecha);
			this.gridComprobantes.DockPadding.Top = 12;
			this.gridComprobantes.Location = new System.Drawing.Point(28, -172);
			this.gridComprobantes.Name = "gridComprobantes";
			this.gridComprobantes.Size = new System.Drawing.Size(886, 261);
			this.gridComprobantes.TabIndex = 0;
			// 
			// uneTotalSeleccionados
			// 
			this.uneTotalSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uneTotalSeleccionados.Location = new System.Drawing.Point(520, 232);
			this.uneTotalSeleccionados.MaskInput = "{LOC}nnnnnnn.nn";
			this.uneTotalSeleccionados.Name = "uneTotalSeleccionados";
			this.uneTotalSeleccionados.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalSeleccionados.Size = new System.Drawing.Size(96, 21);
			this.uneTotalSeleccionados.TabIndex = 4;
			this.uneTotalSeleccionados.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(390, 233);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 121;
			this.label1.Text = "Total Seleccionados: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// utbNinguno
			// 
			this.utbNinguno.AcceptsFocus = false;
			this.utbNinguno.Location = new System.Drawing.Point(64, 232);
			this.utbNinguno.Name = "utbNinguno";
			this.utbNinguno.Size = new System.Drawing.Size(64, 22);
			this.utbNinguno.TabIndex = 119;
			this.utbNinguno.TabStop = false;
			this.utbNinguno.Text = "&Ninguno";
			// 
			// utbTodos
			// 
			this.utbTodos.AcceptsFocus = false;
			this.utbTodos.Location = new System.Drawing.Point(0, 232);
			this.utbTodos.Name = "utbTodos";
			this.utbTodos.Size = new System.Drawing.Size(64, 22);
			this.utbTodos.TabIndex = 118;
			this.utbTodos.TabStop = false;
			this.utbTodos.Text = "&Todos";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(8, 56);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(152, 16);
			this.ultraLabel1.TabIndex = 117;
			this.ultraLabel1.Text = "Comprobantes a Pagar";
			// 
			// gridEX1
			// 
			this.gridEX1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AutomaticSort = false;
			this.gridEX1.ContinuousScroll = false;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX1.Location = new System.Drawing.Point(0, 72);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridEX1.Size = new System.Drawing.Size(880, 160);
			this.gridEX1.TabIndex = 3;
			// 
			// ultraLabel13
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel13.Appearance = appearance1;
			this.ultraLabel13.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel13.Location = new System.Drawing.Point(416, 5);
			this.ultraLabel13.Name = "ultraLabel13";
			this.ultraLabel13.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel13.TabIndex = 115;
			this.ultraLabel13.Text = "Responsable";
			// 
			// mzCEResponsable
			// 
			this.mzCEResponsable.AutoComplete = true;
			this.mzCEResponsable.DataSource = null;
			this.mzCEResponsable.DisplayMember = "";
			this.mzCEResponsable.DisplayMemberCaption = "";
			this.mzCEResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsable.Location = new System.Drawing.Point(528, 0);
			this.mzCEResponsable.MaxItemsDisplay = 50;
			this.mzCEResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsable.Name = "mzCEResponsable";
			this.mzCEResponsable.Size = new System.Drawing.Size(256, 21);
			this.mzCEResponsable.SorterMember = "";
			this.mzCEResponsable.TabIndex = 2;
			this.mzCEResponsable.ValueMember = "";
			this.mzCEResponsable.ValueMemberCaption = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 42;
			this.label3.Text = "Caja :";
			// 
			// mzCEInstanciasCaja
			// 
			this.mzCEInstanciasCaja.AutoComplete = true;
			this.mzCEInstanciasCaja.DataSource = null;
			this.mzCEInstanciasCaja.DisplayMember = "";
			this.mzCEInstanciasCaja.DisplayMemberCaption = "";
			this.mzCEInstanciasCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEInstanciasCaja.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCEInstanciasCaja.Location = new System.Drawing.Point(128, 0);
			this.mzCEInstanciasCaja.MaxItemsDisplay = 7;
			this.mzCEInstanciasCaja.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEInstanciasCaja.Name = "mzCEInstanciasCaja";
			this.mzCEInstanciasCaja.Size = new System.Drawing.Size(272, 21);
			this.mzCEInstanciasCaja.SorterMember = "";
			this.mzCEInstanciasCaja.TabIndex = 0;
			this.mzCEInstanciasCaja.ValueMember = "";
			this.mzCEInstanciasCaja.ValueMemberCaption = "";
			// 
			// ultraLabel11
			// 
			this.ultraLabel11.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel11.Location = new System.Drawing.Point(8, 29);
			this.ultraLabel11.Name = "ultraLabel11";
			this.ultraLabel11.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel11.TabIndex = 41;
			this.ultraLabel11.Text = "Fecha";
			// 
			// uccFecha
			// 
			dateButton1.Caption = "Today";
			this.uccFecha.DateButtons.Add(dateButton1);
			this.uccFecha.Enabled = false;
			this.uccFecha.Location = new System.Drawing.Point(128, 24);
			this.uccFecha.Name = "uccFecha";
			this.uccFecha.NonAutoSizeHeight = 23;
			this.uccFecha.Size = new System.Drawing.Size(272, 21);
			this.uccFecha.TabIndex = 1;
			this.uccFecha.Value = new System.DateTime(2006, 3, 20, 13, 44, 15, 429);
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ubBuscar);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ubEliminar);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ubAgregar);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridEXValores);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 148);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(886, 229);
			this.ultraExplorerBarContainerControl3.TabIndex = 5;
			// 
			// ubBuscar
			// 
			this.ubBuscar.ImageList = this.imglStandar;
			this.ubBuscar.Location = new System.Drawing.Point(217, 0);
			this.ubBuscar.Name = "ubBuscar";
			this.ubBuscar.Size = new System.Drawing.Size(97, 24);
			this.ubBuscar.TabIndex = 2;
			this.ubBuscar.Text = "Buscar";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ubEliminar
			// 
			this.ubEliminar.ImageList = this.imglStandar;
			this.ubEliminar.Location = new System.Drawing.Point(112, 0);
			this.ubEliminar.Name = "ubEliminar";
			this.ubEliminar.Size = new System.Drawing.Size(97, 24);
			this.ubEliminar.TabIndex = 1;
			this.ubEliminar.Text = "Eliminar";
			// 
			// ubAgregar
			// 
			this.ubAgregar.ImageList = this.imglStandar;
			this.ubAgregar.Location = new System.Drawing.Point(8, 0);
			this.ubAgregar.Name = "ubAgregar";
			this.ubAgregar.Size = new System.Drawing.Size(96, 24);
			this.ubAgregar.TabIndex = 0;
			this.ubAgregar.Text = "Agregar";
			// 
			// uneTotal
			// 
			this.uneTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uneTotal.Location = new System.Drawing.Point(520, 0);
			this.uneTotal.MaskInput = "{LOC}nnnnnnn.nn";
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.Size = new System.Drawing.Size(96, 21);
			this.uneTotal.TabIndex = 3;
			this.uneTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(411, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Total: ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gridEXValores
			// 
			this.gridEXValores.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEXValores.AutomaticSort = false;
			this.gridEXValores.ContinuousScroll = false;
			this.gridEXValores.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEXValores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEXValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridEXValores.GroupByBoxVisible = false;
			this.gridEXValores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEXValores.Location = new System.Drawing.Point(0, 32);
			this.gridEXValores.Name = "gridEXValores";
			this.gridEXValores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridEXValores.Size = new System.Drawing.Size(880, 192);
			this.gridEXValores.TabIndex = 4;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.toolBarButton4,
																							  this.toolBarButton5});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(952, 28);
			this.toolBarStandar.TabIndex = 51;
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
			this.ultraExplorerBar1.Controls.Add(this.gridComprobantes);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.gridComprobantes;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 261;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 229;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Detalle de Valores";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(952, 402);
			this.ultraExplorerBar1.TabIndex = 52;
			// 
			// FrmPagosGastosServicios
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(952, 430);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmPagosGastosServicios";
			this.Text = "FrmPagosGastosServicios";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.gridComprobantes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneTotalSeleccionados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uccFecha)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			DumpControls();
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
			this.Previous();
		}

		public void KeyDownNext()
		{
			this.Execute();
		}

		#endregion

		#region Metodos privados
		private  void Build_UI()
		{	
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();		
			FillControls();
		}

		private void InitDataBindings()
		{
			BindingController.Bind(mzCEResponsable,"Value", _uiController, "IdResponsable");
			BindingController.Bind(mzCEInstanciasCaja,"Value", _uiController, "IdInstanciaCaja");
			gridEXValores.SetDataBinding(_uiController.Valores, null);
			gridEX1.SetDataBinding(_uiController.Comprobantes, null);
		}

		private void InitializeData()
		{
			mzCEInstanciasCaja.FillFromDataSource(_uiController.Cajas, "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
			mzCEResponsable.FillFromDataSource(_uiController.Usuarios,"IdPersona","Nombre",100,"Nombre" );
			
		}
		
		private void InitEventHandlers()
		{
			mzCEResponsable.Leave +=new EventHandler(mzCEResponsable_Leave);
			ubAgregar.Click +=new EventHandler(ubAgregar_Click);
			ubEliminar.Click +=new EventHandler(ubEliminar_Click);
			ubBuscar.Click +=new EventHandler(ubBuscar_Click);
			
			gridEXValores.DeletingRecords +=new CancelEventHandler(gridEXValores_DeletingRecords);
			gridEXValores.RecordsDeleted +=new EventHandler(gridEXValores_RecordsDeleted);
			
			//gridEX1.CellUpdated +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridEX1_CellUpdated);
			
			utbNinguno.Click +=new EventHandler(utbNinguno_Click);
			utbTodos.Click +=new EventHandler(utbTodos_Click);
			
			_uiController.OnControllerChanged+= new EventHandler( this.ListenerControllerChanges );
			_uiController.ComprobantesSelectedChanged +=new EventHandler(_uiController_ComprobantesSelectedChanged);

			gridEX1.SelectionChanged +=new EventHandler(gridEX1_SelectionChanged);

			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		}

		private  void ConfigureInterface()
		{
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tarea.Text= _uiController.LeyendaFormulario;
			mzCEInstanciasCaja.Enabled = _uiController.AllowEditCaja;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			uccFecha.Enabled = _uiController.AllowEditFecha;
			ubAgregar.Enabled = _uiController.AllowAddValores;
			ubEliminar.Enabled = _uiController.AllowDeleteValores;
			ubBuscar.Enabled = _uiController.AllowSearchValores;
			this.mzCEResponsable.Enabled=_uiController.AllowEditResponsable;
			this.Text = _uiController.LeyendaFormulario;

			gridEXValores.LayoutData= new mz.erp.ui.controllers.tfi_ValoresEx().GetLayoutValores();
			gridEX1.LayoutData = new mz.erp.ui.controllers.tpu_Comprobantes().GetLayoutItemComprobanteDeCompraView();
			gridEX1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			gridEX1.UpdateOnLeave = true;
			KeyPreview = true;
		}

		private void DumpControls()
		{
			_uiController.Fecha = Convert.ToDateTime(uccFecha.Value);
			//_uiController.IdInstanciaCaja = Convert.ToString(mzCEInstanciasCaja.Value);
		}

		private void FillControls()
		{
			uccFecha.Value = _uiController.Fecha;
			//mzCEInstanciasCaja.Value = _uiController.IdInstanciaCaja;
			
		}

		#endregion

		private void mzCEResponsable_Leave(object sender, EventArgs e)
		{
			if (_uiController.HabilitarContraseña) 
			{
				ShowPassword();				
			}	
		}

		
		private void ShowPassword() 
		{			
			string IdPersona = Convert.ToString(mzCEResponsable.Value);			
			if (IdPersona != _uiController.UltimoResponsableClaveCorrecta)
			{
				string password = InputBox.ShowInputBoxPassword("Ingrese la contraseña:","Cambio de responsable de emisión");								
				bool ClaveCorrecta = false;
				if (IdPersona != null && IdPersona != String.Empty)
				{
					ClaveCorrecta = businessrules.Security.LogInXPersona(IdPersona, password);					
					if (!ClaveCorrecta /*&& password != ""*/)
						MessageBox.Show("¡Clave incorrecta!", "Cambio de responsable de emisión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
						_uiController.UltimoResponsableClaveCorrecta = IdPersona;
				}
				
				if (!ClaveCorrecta)
					_uiController.IdResponsable = string.Empty;
			}
		}

		private void ubAgregar_Click(object sender, EventArgs e)
		{
			gridEX1.UpdateData();
			if(_uiController.HayComprobantesSeleccionados())
			{
				if(!_uiController.HayComprobantesSinSaldo())
				{
					FrmValores form = new FrmValores(_uiController.GetValoresController(_uiController.TotalSaldoComprobantesSeleccionados), _uiController);
					form.AddObjectListener(_uiController);
					form.ShowFormIObservable();
					_uiController.Seleccionar(false);
				}
				else
					MessageBox.Show("Debe seleccionar comprobantes con saldo mayor a cero","Seleccione un Comprobante",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("Debe seleccionar al menos un comprobante","Seleccione un Comprobante",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
		}

		private void ListenerControllerChanges( object sender, System.EventArgs e)
		{
			this.RefreshData();
		}


		private void RefreshData()
		{
			gridEXValores.SetDataBinding(null, null);
			gridEXValores.SetDataBinding(_uiController.Valores, null);
			uneTotal.Value = _uiController.Total;
			gridEX1.SetDataBinding(null, null);
			gridEX1.SetDataBinding(_uiController.Comprobantes, null);
		}

		private void ubEliminar_Click(object sender, EventArgs e)
		{
			if(gridEXValores.SelectedItems.Count > 0)
			{
				
				gridEXValores.Delete();
				gridEXValores.Refresh();
				
			}
		}

		private void gridEXValores_RecordsDeleted(object sender, EventArgs e)
		{		
			uneTotal.Value = _uiController.Total;
			gridEX1.Refetch();
			gridEX1.Refresh();
		}

		private void gridEXValores_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridEXValores.SelectedItems.Count > 0 && gridEXValores.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				_uiController.BorrarValor(gridEXValores.SelectedItems[0].GetRow().DataRow);
			}
		}

		private void utbNinguno_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(false);
			gridEX1.Refetch();
		}

		private void utbTodos_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(true);
			gridEX1.Refetch();
		}

		private void _uiController_ComprobantesSelectedChanged(object sender, EventArgs e)
		{
			uneTotalSeleccionados.Value = _uiController.TotalSaldoComprobantesSeleccionados;
		}

		/*
		private void gridEX1_CellUpdated(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			gridEX1.Refresh();
		}
		*/

		private void gridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool ok = false;
			if(gridEX1.SelectedItems.Count > 0 && gridEX1.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				gridEXValores.Refetch();
				object selected = gridEX1.SelectedItems[0].GetRow().DataRow;
				ArrayList valores = _uiController.GetValores(selected);
				foreach(object valor in valores)
				{
					Janus.Windows.GridEX.GridEXRow row = gridEXValores.GetRow(valor);
					if(row != null)
					{
						Janus.Windows.GridEX.GridEXFormatStyle rowStyle = new Janus.Windows.GridEX.GridEXFormatStyle();
						rowStyle.BackColor = System.Drawing.Color.Red;
						row.RowStyle = rowStyle;
					}
				}
				
			}
			
		}

		private void ubBuscar_Click(object sender, EventArgs e)
		{
			if(_uiController.IdInstanciaCaja != null && _uiController.IdInstanciaCaja != string.Empty)
			{
				if(_uiController.CantidadComprobantesSeleccionados == 1 )
				{
					if(!_uiController.HayComprobantesSinSaldo())
					{
						FrmConsultaValores frmConsultaValores = new FrmConsultaValores("ProcesoConsultarValores", "ConsultarValores", _uiController.IdInstanciaCaja);
						frmConsultaValores.AddObjectListener(this._uiController);
						frmConsultaValores.Build_UI();
						frmConsultaValores.MdiParent = this.MdiParent;
						frmConsultaValores.Show();
					}
					else
						MessageBox.Show("Debe seleccionar sólo un comprobante con saldo mayor a cero","Seleccione un Comprobante",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
				}
				else
					MessageBox.Show("Debe seleccionar sólo un comprobante con saldo mayor a cero","Seleccione un Comprobante",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
			}
			else
				MessageBox.Show("No ha Seleccionado una Caja", "Debe seleccionar la Caja en la que se van a buscar los valores", 
					System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					this.Previous();
					break;
				case 2:

					this.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}
		}
	}
}

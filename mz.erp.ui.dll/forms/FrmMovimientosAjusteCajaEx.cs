using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.forms.classes;
using System.Data;



namespace mz.erp.ui.forms
{
	

	public class FrmMovimientosAjusteCajaEx : System.Windows.Forms.Form	, ITaskForm
	{
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		//private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel9;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel11;
		private Infragistics.Win.Misc.UltraLabel ultraLabel12;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label tarea;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumero;
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTiposMovimiento;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoComp;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposMovimiento;
		private Infragistics.Win.Misc.UltraButton ubEliminar;
		private Infragistics.Win.Misc.UltraButton ubAgregar;
		private Janus.Windows.GridEX.GridEX gridEXValores;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private Infragistics.Win.Misc.UltraButton ubBuscar;
		private mz.erp.ui.controls.mzComboEditor mzComboUsuario;
		private Infragistics.Win.Misc.UltraLabel ultraLabel13;
		private System.ComponentModel.IContainer components = null;


		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
				_uiController.OnControllerChanged -= new EventHandler( this.ListenerControllerChanges );
				mzCmbTipoComp.DataBindings.Clear();
				mzCmbSubTiposMovimiento.DataBindings.Clear();
				mzCmbTiposMovimiento.DataBindings.Clear();
				mzCEInstanciasCaja.DataBindings.Clear();
				txtNumero.DataBindings.Clear();
				txtObservaciones.DataBindings.Clear();
				ultraCalendarCombo1.DataBindings.Clear();
			}
			base.Dispose( disposing );
		}



		#region Custom Members
		
		private mz.erp.ui.controllers.MovimientoAjusteCajaController _uiController;
		private System.Data.DataSet _dataValoresEx;
		//private ArrayList _cotizaciones;
		//private MovimientoDeCaja _movimiento;

		
		public FrmMovimientosAjusteCajaEx()
		{
			InitializeComponent();			
		}
		public FrmMovimientosAjusteCajaEx( mz.erp.ui.controllers.MovimientoAjusteCajaController uiController )
		{
			InitializeComponent();
			_uiController = uiController;
			this.Text = _uiController.GetFormText();
			this.Build_UI();
		}

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
			//InitializeData();
			RefreshData();
		}

		private void ConfigureInterface()
		{
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			tarea.Text= _uiController.LeyendaFormulario;
			uneTotal.Enabled = _uiController.AllowEditUneTotal();
			txtNumero.Enabled = _uiController.AllowEditNumero();
			txtObservaciones.Enabled = _uiController.AllowEditObservaciones();
			mzCEInstanciasCaja.Enabled = _uiController.AllowEditCaja();
			mzCmbTiposMovimiento.Enabled = _uiController.AllowEditTipoDeMovimiento();
			mzCmbSubTiposMovimiento.Enabled = _uiController.AllowEditsubTipoDeMovimiento();
			mzCmbTipoComp.Enabled = _uiController.AllowEditObservaciones();		
			ubEliminar.Enabled = _uiController.AllowEditValores();
			ubAgregar.Enabled = _uiController.AllowEditValores();
			//grilla resultado valores
			gridEXValores.Enabled = _uiController.AllowEditValores();
			gridEXValores.LayoutData= _uiController.LayoutResult;
			if (_uiController.AllowMenuContextualGrilla())
			{
				// contextMenu1
				this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.Detalles});
				// Detalles
				this.Detalles.Index = 0;
				this.Detalles.Text = "Editar";
				this.Detalles.Click += new System.EventHandler(this.Detalles_Click);
			}
			if (_uiController.LayoutEditTypeValores())
				this.gridEXValores.EditMode = Janus.Windows.GridEX.EditMode.EditOn;
			else this.gridEXValores.EditMode = Janus.Windows.GridEX.EditMode.EditOff;

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			ultraCalendarCombo1.Enabled = _uiController.AllowEditFecha();
			
			ubAgregar.Enabled = _uiController.AllowAddValores;
			ubEliminar.Enabled = _uiController.AllowDeleteValores;
			ubBuscar.Enabled = _uiController.AllowSearchValores;
			this.mzComboUsuario.Enabled=_uiController.PermiteEditarResponsable;
			this.Text= _uiController.LeyendaFormulario;
			KeyPreview = true;
						
		}

		private void InitEventHandlers()
		{
			_uiController.OnControllerChanged+= new EventHandler( this.ListenerControllerChanges );
			_uiController.IdCajaChanged+=new EventHandler(_uiController_IdCajaChanged);
			gridEXValores.RecordsDeleted +=new EventHandler(gridEXValores_RecordsDeleted);
			ubBuscar.Click +=new EventHandler(ubBuscar_Click);
			this.mzComboUsuario.Leave+=new EventHandler(mzComboUsuario_Change);
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		}

		private void InitDataBindings()
		{			
			mzCmbTipoComp.DataBindings.Add("Value", _uiController, "IdComp");
			mzCmbSubTiposMovimiento.DataBindings.Add("Value", _uiController, "IdSubtipo");
			mzCmbTiposMovimiento.DataBindings.Add("Value", _uiController, "IdTipo");
			mzCEInstanciasCaja.DataBindings.Add("Value", _uiController , "IdCaja");
			txtNumero.DataBindings.Add("Value", _uiController, "Numero");
			txtObservaciones.DataBindings.Add("Text",_uiController, "Observaciones");
			ultraCalendarCombo1.DataBindings.Add("Value", _uiController, "Fecha");
			BindingController.Bind(mzComboUsuario,"Value", _uiController, "IdUsuario");
		}

				
		private void InitializeData()
		{	
			//mzCEInstanciasCaja.FillFromDataSource(mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdPersona).Tables[0], "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
			mzCEInstanciasCaja.FillFromDataSource(_uiController.InstanciasDeCaja(), "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
			if (mzCEInstanciasCaja.Items.Count != 0)
			{
				mzCEInstanciasCaja.Enabled = _uiController.AllowEditCaja();
				_uiController.IdCaja = Convert.ToString(mzCEInstanciasCaja.Items[0].DataValue);			
			}
			else 
				mzCEInstanciasCaja.Enabled =false;
			
			this.mzCmbTiposMovimiento.FillFromDataSource(_uiController.FiltroTiposMovimientos, "IdTipoMovimiento", "Descripcion", 100, "Descripcion");
			if (_uiController.FiltroTiposMovimientos.Rows.Count != 0)
				this.mzCmbTiposMovimiento.Value = _uiController.IdTipo; // tipos.tsy_TiposMovimientos[0]["IdTipoMovimiento"];
			
			_dataValoresEx = new tfi_ValoresExDataset();
			mzComboUsuario.FillFromDataSource(_uiController.Usuarios,_uiController.KeyValueUsuarios,_uiController.KeyListUsuarios,100,_uiController.KeyListUsuarios );
		}

		
		private void ListenerControllerChanges( object sender, System.EventArgs e)
		{
			this.RefreshData();
		}


		private void RefreshData()
		{
			txtObservaciones.Text = _uiController.Observaciones;
			txtNumero.Text = _uiController.Numero;
			mzCEInstanciasCaja.Value = _uiController.IdCaja; 
			
			mzCmbTiposMovimiento.Value= _uiController.IdTipo;
			mzCmbSubTiposMovimiento.DataBindings.Clear();
			mzCmbSubTiposMovimiento.DataBindings.Add("Value", _uiController, "IdSubtipo");
			
			mzCmbTipoComp.Value = _uiController.IdComp;

			//grilla
			gridEXValores.SetDataBinding(null, null);
			gridEXValores.LayoutData = _uiController.LayoutResult;
			gridEXValores.SetDataBinding(_uiController.Valores, null);

			uneTotal.Value = _uiController.UneTotal;
			ubAgregar.Enabled = _uiController.AllowAddValores;
			//mzCEInstanciasCaja.DataBindings.Clear();
		
			//mzComboUsuario.Refresh();
		}
		#endregion

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem6 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.ValueListItem valueListItem7 = new Infragistics.Win.ValueListItem();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmMovimientosAjusteCajaEx));
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.tarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
			this.mzComboUsuario = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbTipoComp = new mz.erp.ui.controls.mzComboEditor();
			this.txtNumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbSubTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraCalendarCombo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ubBuscar = new Infragistics.Win.Misc.UltraButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ubEliminar = new Infragistics.Win.Misc.UltraButton();
			this.ubAgregar = new Infragistics.Win.Misc.UltraButton();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label4 = new System.Windows.Forms.Label();
			this.gridEXValores = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzComboUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.tarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 9);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(830, 24);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// tarea
			// 
			this.tarea.BackColor = System.Drawing.Color.Transparent;
			this.tarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.tarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tarea.Location = new System.Drawing.Point(0, 0);
			this.tarea.Name = "tarea";
			this.tarea.Size = new System.Drawing.Size(830, 23);
			this.tarea.TabIndex = 1;
			this.tarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel13);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboUsuario);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTipoComp);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumero);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSubTiposMovimiento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel9);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtObservaciones);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel10);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEInstanciasCaja);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel11);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposMovimiento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel12);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraCalendarCombo1);
			this.ultraExplorerBarContainerControl1.DockPadding.Top = 12;
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 92);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(830, 157);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// ultraLabel13
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel13.Appearance = appearance1;
			this.ultraLabel13.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel13.Location = new System.Drawing.Point(488, 56);
			this.ultraLabel13.Name = "ultraLabel13";
			this.ultraLabel13.Size = new System.Drawing.Size(88, 16);
			this.ultraLabel13.TabIndex = 115;
			this.ultraLabel13.Text = "Responsable";
			// 
			// mzComboUsuario
			// 
			this.mzComboUsuario.AutoComplete = true;
			this.mzComboUsuario.DataSource = null;
			this.mzComboUsuario.DisplayMember = "";
			this.mzComboUsuario.DisplayMemberCaption = "";
			this.mzComboUsuario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboUsuario.Location = new System.Drawing.Point(584, 48);
			this.mzComboUsuario.MaxItemsDisplay = 50;
			this.mzComboUsuario.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboUsuario.Name = "mzComboUsuario";
			this.mzComboUsuario.Size = new System.Drawing.Size(160, 21);
			this.mzComboUsuario.SorterMember = "";
			this.mzComboUsuario.TabIndex = 7;
			this.mzComboUsuario.ValueMember = "";
			this.mzComboUsuario.ValueMemberCaption = "";
			// 
			// mzCmbTipoComp
			// 
			this.mzCmbTipoComp.AutoComplete = true;
			this.mzCmbTipoComp.DataSource = null;
			this.mzCmbTipoComp.DisplayMember = "";
			this.mzCmbTipoComp.DisplayMemberCaption = "";
			this.mzCmbTipoComp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTipoComp.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			valueListItem1.DataValue = "No";
			valueListItem1.DisplayText = "No/I";
			valueListItem2.DataValue = "Fact.A";
			valueListItem2.DisplayText = "Fact. A";
			valueListItem3.DataValue = "Fact.B";
			valueListItem3.DisplayText = "Fact. B";
			valueListItem4.DataValue = "Fact.C";
			valueListItem4.DisplayText = "Fact. C";
			valueListItem5.DataValue = "Ticket.A";
			valueListItem5.DisplayText = "Ticket A";
			valueListItem6.DataValue = "Ticket";
			valueListItem6.DisplayText = "Ticket";
			valueListItem7.DataValue = "Recibo";
			valueListItem7.DisplayText = "Recibo";
			this.mzCmbTipoComp.Items.Add(valueListItem1);
			this.mzCmbTipoComp.Items.Add(valueListItem2);
			this.mzCmbTipoComp.Items.Add(valueListItem3);
			this.mzCmbTipoComp.Items.Add(valueListItem4);
			this.mzCmbTipoComp.Items.Add(valueListItem5);
			this.mzCmbTipoComp.Items.Add(valueListItem6);
			this.mzCmbTipoComp.Items.Add(valueListItem7);
			this.mzCmbTipoComp.Location = new System.Drawing.Point(584, 0);
			this.mzCmbTipoComp.MaxItemsDisplay = 7;
			this.mzCmbTipoComp.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTipoComp.Name = "mzCmbTipoComp";
			this.mzCmbTipoComp.Size = new System.Drawing.Size(137, 21);
			this.mzCmbTipoComp.SorterMember = "";
			this.mzCmbTipoComp.TabIndex = 5;
			this.mzCmbTipoComp.ValueMember = "";
			this.mzCmbTipoComp.ValueMemberCaption = "";
			this.mzCmbTipoComp.ValueChanged += new System.EventHandler(this.mzCmbTipoComp_ValueChanged);
			// 
			// txtNumero
			// 
			this.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.txtNumero.InputMask = "\\A-####-########";
			this.txtNumero.Location = new System.Drawing.Point(584, 24);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.TabIndex = 6;
			this.txtNumero.Text = "A--";
			this.txtNumero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtNumero_MouseUp);
			// 
			// ultraLabel1
			// 
			appearance2.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel1.Appearance = appearance2;
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(456, 8);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(116, 16);
			this.ultraLabel1.TabIndex = 49;
			this.ultraLabel1.Text = "Tipo de Comprobante";
			// 
			// ultraLabel4
			// 
			appearance3.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel4.Appearance = appearance3;
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(512, 32);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel4.TabIndex = 48;
			this.ultraLabel4.Text = "Número";
			// 
			// mzCmbSubTiposMovimiento
			// 
			this.mzCmbSubTiposMovimiento.AutoComplete = true;
			this.mzCmbSubTiposMovimiento.DataSource = null;
			this.mzCmbSubTiposMovimiento.DisplayMember = "";
			this.mzCmbSubTiposMovimiento.DisplayMemberCaption = "";
			this.mzCmbSubTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbSubTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCmbSubTiposMovimiento.Location = new System.Drawing.Point(128, 72);
			this.mzCmbSubTiposMovimiento.MaxItemsDisplay = 7;
			this.mzCmbSubTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbSubTiposMovimiento.Name = "mzCmbSubTiposMovimiento";
			this.mzCmbSubTiposMovimiento.Size = new System.Drawing.Size(272, 21);
			this.mzCmbSubTiposMovimiento.SorterMember = "";
			this.mzCmbSubTiposMovimiento.TabIndex = 3;
			this.mzCmbSubTiposMovimiento.ValueMember = "";
			this.mzCmbSubTiposMovimiento.ValueMemberCaption = "";
			// 
			// ultraLabel9
			// 
			this.ultraLabel9.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel9.Location = new System.Drawing.Point(8, 77);
			this.ultraLabel9.Name = "ultraLabel9";
			this.ultraLabel9.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel9.TabIndex = 46;
			this.ultraLabel9.Text = "Sub-Tipo de Movim.";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(128, 96);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObservaciones.Size = new System.Drawing.Size(472, 51);
			this.txtObservaciones.TabIndex = 4;
			this.txtObservaciones.Text = "TEXTBOX3";
			// 
			// ultraLabel10
			// 
			this.ultraLabel10.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel10.Location = new System.Drawing.Point(8, 98);
			this.ultraLabel10.Name = "ultraLabel10";
			this.ultraLabel10.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel10.TabIndex = 43;
			this.ultraLabel10.Text = "Observaciones";
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
			// mzCmbTiposMovimiento
			// 
			this.mzCmbTiposMovimiento.AutoComplete = true;
			this.mzCmbTiposMovimiento.DataSource = null;
			this.mzCmbTiposMovimiento.DisplayMember = "";
			this.mzCmbTiposMovimiento.DisplayMemberCaption = "";
			this.mzCmbTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCmbTiposMovimiento.Location = new System.Drawing.Point(128, 48);
			this.mzCmbTiposMovimiento.MaxItemsDisplay = 7;
			this.mzCmbTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposMovimiento.Name = "mzCmbTiposMovimiento";
			this.mzCmbTiposMovimiento.Size = new System.Drawing.Size(272, 21);
			this.mzCmbTiposMovimiento.SorterMember = "";
			this.mzCmbTiposMovimiento.TabIndex = 2;
			this.mzCmbTiposMovimiento.ValueMember = "";
			this.mzCmbTiposMovimiento.ValueMemberCaption = "";
			this.mzCmbTiposMovimiento.ValueChanged += new System.EventHandler(this.mzCmbTiposMovimiento_ValueChanged);
			// 
			// ultraLabel12
			// 
			this.ultraLabel12.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel12.Location = new System.Drawing.Point(8, 53);
			this.ultraLabel12.Name = "ultraLabel12";
			this.ultraLabel12.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel12.TabIndex = 40;
			this.ultraLabel12.Text = "Tipo de Movimiento";
			// 
			// ultraCalendarCombo1
			// 
			dateButton1.Caption = "Today";
			this.ultraCalendarCombo1.DateButtons.Add(dateButton1);
			this.ultraCalendarCombo1.Enabled = false;
			this.ultraCalendarCombo1.Location = new System.Drawing.Point(128, 24);
			this.ultraCalendarCombo1.Name = "ultraCalendarCombo1";
			this.ultraCalendarCombo1.NonAutoSizeHeight = 23;
			this.ultraCalendarCombo1.Size = new System.Drawing.Size(272, 21);
			this.ultraCalendarCombo1.TabIndex = 1;
			this.ultraCalendarCombo1.Value = new System.DateTime(2006, 3, 20, 13, 44, 15, 429);
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ubBuscar);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ubEliminar);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ubAgregar);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridEXValores);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 308);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(830, 229);
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
			this.ubEliminar.Click += new System.EventHandler(this.ubEliminar_Click);
			// 
			// ubAgregar
			// 
			this.ubAgregar.ImageList = this.imglStandar;
			this.ubAgregar.Location = new System.Drawing.Point(8, 0);
			this.ubAgregar.Name = "ubAgregar";
			this.ubAgregar.Size = new System.Drawing.Size(96, 24);
			this.ubAgregar.TabIndex = 0;
			this.ubAgregar.Text = "Agregar";
			this.ubAgregar.Click += new System.EventHandler(this.ubAgregar_Click);
			// 
			// uneTotal
			// 
			this.uneTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.uneTotal.Location = new System.Drawing.Point(655, 0);
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
			this.label4.Location = new System.Drawing.Point(543, 2);
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
			this.gridEXValores.ContextMenu = this.contextMenu1;
			this.gridEXValores.ContinuousScroll = false;
			this.gridEXValores.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEXValores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEXValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridEXValores.GroupByBoxVisible = false;
			this.gridEXValores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEXValores.Location = new System.Drawing.Point(0, 32);
			this.gridEXValores.Name = "gridEXValores";
			this.gridEXValores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridEXValores.Size = new System.Drawing.Size(768, 192);
			this.gridEXValores.TabIndex = 4;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 259);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(854, 232);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(568, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Total: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ultraLabel7
			// 
			appearance4.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel7.Appearance = appearance4;
			this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel7.Location = new System.Drawing.Point(456, 8);
			this.ultraLabel7.Name = "ultraLabel7";
			this.ultraLabel7.Size = new System.Drawing.Size(116, 16);
			this.ultraLabel7.TabIndex = 49;
			this.ultraLabel7.Text = "Tipo de Comprobante";
			// 
			// ultraLabel8
			// 
			appearance5.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel8.Appearance = appearance5;
			this.ultraLabel8.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel8.Location = new System.Drawing.Point(512, 32);
			this.ultraLabel8.Name = "ultraLabel8";
			this.ultraLabel8.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel8.TabIndex = 48;
			this.ultraLabel8.Text = "Número";
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(8, 72);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel6.TabIndex = 46;
			this.ultraLabel6.Text = "Sub-Tipo de Movim.";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(8, 96);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel5.TabIndex = 43;
			this.ultraLabel5.Text = "Observaciones";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 42;
			this.label2.Text = "Caja :";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(8, 32);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel3.TabIndex = 41;
			this.ultraLabel3.Text = "Fecha";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(8, 48);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel2.TabIndex = 40;
			this.ultraLabel2.Text = "Tipo de Movimiento";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar1);
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(896, 590);
			this.panel1.TabIndex = 0;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 157;
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
			this.ultraExplorerBar1.Size = new System.Drawing.Size(896, 562);
			this.ultraExplorerBar1.TabIndex = 51;
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
			this.toolBarStandar.Size = new System.Drawing.Size(896, 28);
			this.toolBarStandar.TabIndex = 50;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			// Detalles
			// 
			this.Detalles.Index = -1;
			this.Detalles.Text = "";
			// 
			// FrmMovimientosAjusteCajaEx
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(896, 590);
			this.Controls.Add(this.panel1);
			this.Name = "FrmMovimientosAjusteCajaEx";
			this.Text = "Movimiento de Caja";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzComboUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
			
		#region Miembros de ITaskForm
			
		public virtual void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				//				this.Build_UI();
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
			this.Execute();
		}

		public void Execute()
		{
			gridEXValores.Select();
			_uiController.Execute();
		}

		public void Previous()
		{
			_uiController.Previous();
		}


		#endregion


		public void getDataSet(System.Data.DataSet data, Valor  valor)
		{
			try
			{
				_dataValoresEx= data;
				valor.Recalcular();
			}
			catch(Exception e) {;}	
		}


		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:

					this.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}
		}


		private void ubAgregar_Click(object sender, System.EventArgs e)
		{
		
			FrmValores form = new FrmValores(_uiController.GetValoresController(), _uiController);
			form.AddObjectListener(_uiController);
			form.ShowFormIObservable();
			
		}
		
		private void ubEliminar_Click(object sender, System.EventArgs e)
		{
			if(gridEXValores.SelectedItems.Count > 0)
			{
				gridEXValores.Delete();
				gridEXValores.Refresh();	
				
			}

		}

		private void mzCmbTiposMovimiento_ValueChanged(object sender, System.EventArgs e)
		{
			//tsy_SubTipoMovimientoDataset subtipos = _uiController.ListaSubTipoMovimientos(Convert.ToString(this.mzCmbTiposMovimiento.Value)); 
			DataTable subtipos = _uiController.ListaSubTipoMovimientos(Convert.ToString(this.mzCmbTiposMovimiento.Value)); 
			this.mzCmbSubTiposMovimiento.FillFromDataSource(subtipos, "IdSubTipoMovimiento", "Descripcion", 100, "Descripcion");
			
			if (subtipos.Rows.Count != 0)
				this.mzCmbSubTiposMovimiento.Value = _uiController.IdSubTipo;
		}

		private void mzCmbTipoComp_ValueChanged(object sender, System.EventArgs e)
		{
			switch ( Convert.ToString(mzCmbTipoComp.Value) )
			{	
				case "Fact.A":
					txtNumero.InputMask = "\\A-####-########";
					txtNumero.Enabled = _uiController.AllowEditNumero();
					break;
				case "Fact.B":
					txtNumero.InputMask = "\\B-####-########";
					txtNumero.Enabled = _uiController.AllowEditNumero();
					break;	
				case "Fact.C":
					txtNumero.InputMask = "\\C-####-########";
					txtNumero.Enabled = _uiController.AllowEditNumero();
					break;	
				case "Ticket.A":
					txtNumero.InputMask = "\\###############";
					txtNumero.Enabled = _uiController.AllowEditNumero();
					break;	
				case "Ticket":
					txtNumero.InputMask = "\\###############";
					txtNumero.Enabled = _uiController.AllowEditNumero();
					break;	
				case "Recibo":
					txtNumero.InputMask = "\\R-####-########";
					txtNumero.Enabled = _uiController.AllowEditNumero();
					break;	
				case "No":
					_uiController.Numero="";
					txtNumero.Text = "";
					txtNumero.InputMask = "";
					txtNumero.Enabled = false;
					break;
			}
		}

		private void txtNumero_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			txtNumero.SelectAll();
		}

	

		private void Detalles_Click(object sender, EventArgs e)
		{
			if(gridEXValores.SelectedItems.Count > 0 && _uiController != null)
			{
				FrmValores form = new FrmValores(_uiController.GetValoresController(), _uiController);
				form.AddObjectListener(_uiController);
				form.ShowFormIObservable();
			}
		}

		private void gridEXValores_RecordsDeleted(object sender, EventArgs e)
		{
			_uiController.ValorDeleted();
			ubAgregar.Enabled = _uiController.AllowAddValores;
		}

		private void ubBuscar_Click(object sender, EventArgs e)
		{
			if(_uiController.IdCaja != null && _uiController.IdCaja != string.Empty)
			{
				FrmConsultaValores frmConsultaValores = new FrmConsultaValores("ProcesoConsultarValores", "ConsultarValores", _uiController.IdCaja);
				frmConsultaValores.AddObjectListener(this._uiController);
				frmConsultaValores.Build_UI();
				frmConsultaValores.MdiParent = this.MdiParent;
				frmConsultaValores.Show();
			}
			else
				MessageBox.Show("No ha Seleccionado una Caja", "Debe seleccionar la Caja en la que se van a buscar los valores", 
					System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
		}

		private void ShowPassword() 
		{			
			string IdPersona = Convert.ToString(mzComboUsuario.Value);			
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
					_uiController.ClearResponsableDeEmision();
			}
		}

		private void mzComboUsuario_Change(object sender, EventArgs e)
		{
			if (_uiController.HabilitarContraseña) 
			{
				ShowPassword();				
			}	
		}

		private void _uiController_IdCajaChanged(object sender, EventArgs e)
		{
			//Pide de nuevo las instancias de caja
			mzCEInstanciasCaja.FillFromDataSource(_uiController.InstanciasDeCaja(), "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");

		}
	}
}


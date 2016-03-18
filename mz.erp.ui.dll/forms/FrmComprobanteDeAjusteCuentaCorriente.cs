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
	/// Descripción breve de FrmComprobanteDeAjusteCuentaCorriente.
	/// </summary>
	public class FrmComprobanteDeAjusteCuentaCorriente : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumero;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private System.Windows.Forms.Label label6;
		private mz.erp.ui.controls.mzComboEditor mzCETipoComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEObservaciones;
		private System.ComponentModel.IContainer components;

		
		#region Constructorees

		public FrmComprobanteDeAjusteCuentaCorriente(ComprobanteDeAjusteCuentaCorrienteController controller )
		{			
			InitializeComponent();
			_uiController = controller;			
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
            //German 20120223 -  Tarea 0000247
            _uiController.FillData();
            //Fin German 20120223 -  Tarea 0000247
            mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			labelTarea.Text = _uiController.LeyendaFormulario;
			this.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			ultraMENumero.Enabled = _uiController.AllowEditNumeration;
			ultraMENumero.InputMask = _uiController.Mascara;
			ultraMENumero.Text = "X--";			
			//Text
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;
			cldFechaComprobante.Enabled = _uiController.AllowEditFecha;
			mzCETipoComprobante.Enabled = _uiController.AllowEditResponsableEmision;
			cldFechaComprobante.Value = _uiController.Fecha;
			
			KeyPreview = true;
			
		}

		private void InitializeData()
		{						
			
			
			mzCETipoComprobante.FillFromDataSource(_uiController.TableTiposDeComprobantes,_uiController.TiposDeComprobantesValueMember,_uiController.TiposDeComprobantesDisplayMember,100,_uiController.TiposDeComprobantesDisplayMember);
			mzCEResponsableEmision.FillFromDataSource(_uiController.ResponsableDataTable, _uiController.ResponsableValueMember,_uiController.ResponsableDisplayMember,8,_uiController.ResponsableDisplayMember);

		}
		private void InitEventHandlers()
		{			
			
			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			mzCmbCuenta.AddObjectListener( (IObserver)_uiController );
			uneTotal.Enter +=new EventHandler(uneTotal_Enter);
			KeyDownManager KeyDown = new KeyDownManager(this);
			
		}	 
	
		private void InitDataBindings()
		{				
			ultraMENumero.DataBindings.Add( "InputMask",_uiController , "Mascara" );
			mzCEResponsableEmision.DataBindings.Add("Value", _uiController, "ResponsableDeEmision");
			BindingController.Bind(mzCETipoComprobante,"Value",_uiController,"KeyValueTiposDeComprobantes");
			ultraMENumero.DataBindings.Add("Text", _uiController, "NumeroComprobante");
			cldFechaComprobante.DataBindings.Add("Value", _uiController, "Fecha");
			uneTotal.DataBindings.Add("Value", _uiController,"Total");
			mzCmbCuenta.DataBindings.Add("DataValue", _uiController, "CodigoCuenta");
			BindingController.Bind(uTEObservaciones, "Value", _uiController, "Observaciones");
			


		}


		
		#endregion

		#region Variables Privadas		
		
			private ComprobanteDeAjusteCuentaCorrienteController _uiController = null;		

		#endregion

		#region Destructores

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
					

				}
				ultraMENumero.DataBindings.Clear();
				mzCEResponsableEmision.DataBindings.Clear();
				BindingController.Clear(mzCETipoComprobante,"Value",_uiController,"KeyValueTiposDeComprobantes");
				ultraMENumero.DataBindings.Clear();
				cldFechaComprobante.DataBindings.Clear();
				uneTotal.DataBindings.Clear();
				mzCmbCuenta.DataBindings.Clear();
				BindingController.Clear(uTEObservaciones, "Value", _uiController, "Observaciones");
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
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmComprobanteDeAjusteCuentaCorriente));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCETipoComprobante = new mz.erp.ui.controls.mzComboEditor();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label6 = new System.Windows.Forms.Label();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
			this.ultraMENumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uTEObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCETipoComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(854, 24);
			this.ultraExplorerBarContainerControl4.TabIndex = 5;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(854, 23);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCETipoComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraMENumero);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableEmision);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(854, 77);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// mzCETipoComprobante
			// 
			this.mzCETipoComprobante.AutoComplete = true;
			this.mzCETipoComprobante.DataSource = null;
			this.mzCETipoComprobante.DisplayMember = "";
			this.mzCETipoComprobante.DisplayMemberCaption = "";
			this.mzCETipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCETipoComprobante.Location = new System.Drawing.Point(680, 2);
			this.mzCETipoComprobante.MaxItemsDisplay = 7;
			this.mzCETipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCETipoComprobante.Name = "mzCETipoComprobante";
			this.mzCETipoComprobante.Size = new System.Drawing.Size(167, 21);
			this.mzCETipoComprobante.SorterMember = "";
			this.mzCETipoComprobante.TabIndex = 3;
			this.mzCETipoComprobante.ValueMember = "";
			this.mzCETipoComprobante.ValueMemberCaption = "";
			// 
			// uneTotal
			// 
			this.uneTotal.Location = new System.Drawing.Point(120, 50);
			this.uneTotal.MinValue = 0;
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.Size = new System.Drawing.Size(104, 21);
			this.uneTotal.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(16, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 20);
			this.label6.TabIndex = 100;
			this.label6.Text = "Total";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ultraLabel3
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel3.Appearance = appearance1;
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(616, 30);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel3.TabIndex = 28;
			this.ultraLabel3.Text = "Fecha";
			// 
			// cldFechaComprobante
			// 
			dateButton1.Caption = "Today";
			this.cldFechaComprobante.DateButtons.Add(dateButton1);
			this.cldFechaComprobante.Location = new System.Drawing.Point(680, 26);
			this.cldFechaComprobante.Name = "cldFechaComprobante";
			this.cldFechaComprobante.NonAutoSizeHeight = 23;
			this.cldFechaComprobante.Size = new System.Drawing.Size(109, 21);
			this.cldFechaComprobante.TabIndex = 4;
			this.cldFechaComprobante.Value = new System.DateTime(2005, 8, 15, 0, 0, 0, 0);
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.AllowEditClientePaso = false;
			this.mzCmbCuenta.BackColor = System.Drawing.Color.Transparent;
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EnableCtaCte = false;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(120, 26);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(480, 24);
			this.mzCmbCuenta.TabIndex = 1;
			// 
			// ultraMENumero
			// 
			this.ultraMENumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.ultraMENumero.InputMask = "\\A-####-########";
			this.ultraMENumero.Location = new System.Drawing.Point(680, 50);
			this.ultraMENumero.Name = "ultraMENumero";
			this.ultraMENumero.TabIndex = 5;
			this.ultraMENumero.Text = "A--";
			this.ultraMENumero.Leave += new System.EventHandler(this.ultraMENumero_Leave);
			// 
			// mzCEResponsableEmision
			// 
			this.mzCEResponsableEmision.AutoComplete = true;
			this.mzCEResponsableEmision.DataSource = null;
			this.mzCEResponsableEmision.DisplayMember = "";
			this.mzCEResponsableEmision.DisplayMemberCaption = "";
			this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsableEmision.Location = new System.Drawing.Point(120, 2);
			this.mzCEResponsableEmision.MaxItemsDisplay = 8;
			this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
			this.mzCEResponsableEmision.Size = new System.Drawing.Size(167, 21);
			this.mzCEResponsableEmision.SorterMember = "";
			this.mzCEResponsableEmision.TabIndex = 0;
			this.mzCEResponsableEmision.ValueMember = "";
			this.mzCEResponsableEmision.ValueMemberCaption = "";
			// 
			// ultraLabel2
			// 
			appearance2.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel2.Appearance = appearance2;
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(560, 8);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(116, 16);
			this.ultraLabel2.TabIndex = 32;
			this.ultraLabel2.Text = "Tipo de Comprobante";
			// 
			// ultraLabel6
			// 
			appearance3.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel6.Appearance = appearance3;
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(-8, 8);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(120, 20);
			this.ultraLabel6.TabIndex = 30;
			this.ultraLabel6.Text = "Responsable Emisión";
			// 
			// ultraLabel1
			// 
			appearance4.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel1.Appearance = appearance4;
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(51, 30);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel1.TabIndex = 29;
			this.ultraLabel1.Text = "Cuenta";
			// 
			// ultraLabel5
			// 
			appearance5.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel5.Appearance = appearance5;
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(616, 54);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(62, 11);
			this.ultraLabel5.TabIndex = 27;
			this.ultraLabel5.Text = "Número";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uTEObservaciones);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 243);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(854, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 6;
			// 
			// uTEObservaciones
			// 
			this.uTEObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uTEObservaciones.Location = new System.Drawing.Point(0, 0);
			this.uTEObservaciones.Multiline = true;
			this.uTEObservaciones.Name = "uTEObservaciones";
			this.uTEObservaciones.Size = new System.Drawing.Size(854, 150);
			this.uTEObservaciones.TabIndex = 0;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
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
			this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
			this.toolBarStandar.TabIndex = 19;
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
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 77;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos de Cabecera";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Observaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 370);
			this.ultraExplorerBar1.TabIndex = 20;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmComprobanteDeAjusteCuentaCorriente
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 398);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmComprobanteDeAjusteCuentaCorriente";
			this.Text = "FrmComprobanteDeAjusteCuentaCorriente";
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCETipoComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).EndInit();
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
				//_uiController.RefreshData();

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
			mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);	
			_uiController.Execute();
		}

		#endregion

		#region Metodos Privados

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:	
					mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);	
					_uiController.Execute();
					break;
				case 4:
					CloseForm();
					break;
			}						
		}

		#endregion

		private void uneTotal_Enter(object sender, EventArgs e)
		{
			uneTotal.SelectAll();
		}

		private void ultraMENumero_Leave(object sender, System.EventArgs e)
		{
			this.ultraMENumero.Text = _uiController.FillNumberWithZeros(ultraMENumero.Text);
		}
	}
}

using System;
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
	/// Descripción breve de borrar.
	/// </summary>
	public class FrmAbmCotizacionMoneda : System.Windows.Forms.Form,ITaskForm
	{
		private System.Windows.Forms.ToolBarButton tbGuardar;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton tbCerrar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Panel panel2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedasDestino;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedasOrigen;
		private Infragistics.Win.Misc.UltraLabel lblOrigen;
		private mz.erp.ui.controls.mzComboEditor mzCEFuentesDeCambio;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCotizacion;

		//private string _momento;



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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmCotizacionMoneda));
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCEFuentesDeCambio = new mz.erp.ui.controls.mzComboEditor();
			this.uneCotizacion = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.mzCEMonedasDestino = new mz.erp.ui.controls.mzComboEditor();
			this.lblOrigen = new Infragistics.Win.Misc.UltraLabel();
			this.mzCEMonedasOrigen = new mz.erp.ui.controls.mzComboEditor();
			this.tbGuardar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
			this.tbCerrar = new System.Windows.Forms.ToolBarButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuentesDeCambio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCotizacion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedasDestino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedasOrigen)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(751, 24);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(751, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEFuentesDeCambio);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneCotizacion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEMonedasDestino);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lblOrigen);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEMonedasOrigen);
			this.ultraExplorerBarContainerControl1.DockPadding.Top = 12;
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(751, 37);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// mzCEFuentesDeCambio
			// 
			this.mzCEFuentesDeCambio.DataSource = null;
			this.mzCEFuentesDeCambio.DisplayMember = "";
			this.mzCEFuentesDeCambio.DisplayMemberCaption = "";
			this.mzCEFuentesDeCambio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFuentesDeCambio.Location = new System.Drawing.Point(560, 8);
			this.mzCEFuentesDeCambio.MaxItemsDisplay = 7;
			this.mzCEFuentesDeCambio.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFuentesDeCambio.Name = "mzCEFuentesDeCambio";
			this.mzCEFuentesDeCambio.Size = new System.Drawing.Size(152, 21);
			this.mzCEFuentesDeCambio.SorterMember = "";
			this.mzCEFuentesDeCambio.TabIndex = 67;
			this.mzCEFuentesDeCambio.ValueMember = "";
			this.mzCEFuentesDeCambio.ValueMemberCaption = "";
			// 
			// uneCotizacion
			// 
			this.uneCotizacion.Location = new System.Drawing.Point(288, 8);
			this.uneCotizacion.MaskInput = "nnnnnnnn.nn";
			this.uneCotizacion.Name = "uneCotizacion";
			this.uneCotizacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneCotizacion.Size = new System.Drawing.Size(100, 21);
			this.uneCotizacion.TabIndex = 66;
			this.uneCotizacion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// mzCEMonedasDestino
			// 
			this.mzCEMonedasDestino.DataSource = null;
			this.mzCEMonedasDestino.DisplayMember = "";
			this.mzCEMonedasDestino.DisplayMemberCaption = "";
			this.mzCEMonedasDestino.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedasDestino.Location = new System.Drawing.Point(396, 8);
			this.mzCEMonedasDestino.MaxItemsDisplay = 7;
			this.mzCEMonedasDestino.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedasDestino.Name = "mzCEMonedasDestino";
			this.mzCEMonedasDestino.Size = new System.Drawing.Size(152, 21);
			this.mzCEMonedasDestino.SorterMember = "";
			this.mzCEMonedasDestino.TabIndex = 65;
			this.mzCEMonedasDestino.ValueMember = "";
			this.mzCEMonedasDestino.ValueMemberCaption = "";
			// 
			// lblOrigen
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Left;
			this.lblOrigen.Appearance = appearance1;
			this.lblOrigen.BackColor = System.Drawing.Color.Transparent;
			this.lblOrigen.Location = new System.Drawing.Point(8, 10);
			this.lblOrigen.Name = "lblOrigen";
			this.lblOrigen.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblOrigen.Size = new System.Drawing.Size(120, 16);
			this.lblOrigen.TabIndex = 63;
			this.lblOrigen.Text = "Origen";
			// 
			// mzCEMonedasOrigen
			// 
			this.mzCEMonedasOrigen.DataSource = null;
			this.mzCEMonedasOrigen.DisplayMember = "";
			this.mzCEMonedasOrigen.DisplayMemberCaption = "";
			this.mzCEMonedasOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMonedasOrigen.Location = new System.Drawing.Point(128, 8);
			this.mzCEMonedasOrigen.MaxItemsDisplay = 7;
			this.mzCEMonedasOrigen.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMonedasOrigen.Name = "mzCEMonedasOrigen";
			this.mzCEMonedasOrigen.Size = new System.Drawing.Size(152, 21);
			this.mzCEMonedasOrigen.SorterMember = "";
			this.mzCEMonedasOrigen.TabIndex = 60;
			this.mzCEMonedasOrigen.ValueMember = "";
			this.mzCEMonedasOrigen.ValueMemberCaption = "";
			// 
			// tbGuardar
			// 
			this.tbGuardar.ImageIndex = 4;
			this.tbGuardar.Text = "&Guardar";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbStep3.Visible = false;
			// 
			// tbbImprimir
			// 
			this.tbbImprimir.ImageIndex = 8;
			this.tbbImprimir.Text = "Imprimir";
			this.tbbImprimir.Visible = false;
			// 
			// tbCerrar
			// 
			this.tbCerrar.ImageIndex = 7;
			this.tbCerrar.Text = "Cerrar";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 614);
			this.panel1.TabIndex = 21;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ultraExplorerBar1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 586);
			this.panel2.TabIndex = 42;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 37;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos de cabecera";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(800, 586);
			this.ultraExplorerBar1.TabIndex = 2;
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
			this.toolBarStandar.Size = new System.Drawing.Size(800, 28);
			this.toolBarStandar.TabIndex = 41;
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
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// FrmAbmCotizacionMoneda
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 614);
			this.Controls.Add(this.panel1);
			this.Name = "FrmAbmCotizacionMoneda";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEFuentesDeCambio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCotizacion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedasDestino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMonedasOrigen)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion 

				
		#region Custom Members
		

		
		private void Componentes_Changes(object sender, System.EventArgs e)
		{			
			/*if (((Control)sender).Name == "mzCmbCuenta")
			{
				if (mzCmbCuenta.DataValue != null && _uiController != null)
				{
					_uiController.IdCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string)mzCmbCuenta.DataValue);
				}
			}
			if (((Control)sender).Name == "mzCEResponsableEmision")
			{
				if (mzCEResponsableEmision.Value != null && _uiController != null)
				{
					_uiController.IdResponsable = (string)mzCEResponsableEmision.Value;
					

				}
			}*/				
		}

		private void SetCaptionForm(string texto)
		{
			//this.Text = texto;
		}

		private void FrmEntregas_Closing(object sender, CancelEventArgs e)
		{
			
			//
			// if(!_save)
			//{
			//	if(MessageBox.Show("¿Esta seguro que desea cerrar el formulario?","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Warning) == DialogResult.Cancel)
			//		e.Cancel = true;
			//}

		}
		#endregion


		#region Variables Privadas
	
		private controllers.AbmCotizacionMonedaController _uiController = null;
		#endregion

		#region Variables Publicas

		//public string State
		//{
		//	get { return _state; }
		//}


		#endregion

		#region Constructores y Destructores
		public FrmAbmCotizacionMoneda( controllers.AbmCotizacionMonedaController controller )
		{
			InitializeComponent();
			_uiController = controller;
			Init();			
		}

		public FrmAbmCotizacionMoneda()
		{
			
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.AbmCotizacionMonedaController();
	
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
				BindingController.Clear(mzCEMonedasOrigen,"Value", _uiController,"IdMonedaOrigen");
				BindingController.Clear(mzCEMonedasDestino,"Value", _uiController,"IdMonedaDestino");
				BindingController.Clear(mzCEFuentesDeCambio,"Value", _uiController,"IdFuenteDeCambio");
				
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

		mzCEMonedasOrigen.FillFromDataSource(_uiController.Monedas, _uiController.MonedaValueMember, _uiController.MonedaDisplayMember, 8, _uiController.MonedaSortedMember);		
		mzCEMonedasDestino.FillFromDataSource(_uiController.Monedas, _uiController.MonedaValueMember, _uiController.MonedaDisplayMember, 8, _uiController.MonedaSortedMember);		
		mzCEFuentesDeCambio.FillFromDataSource(_uiController.FuentesDeCambio, _uiController.FuenteDeCambioValueMember, _uiController.FuenteDeCambioDisplayMember, 8, _uiController.FuenteDeCambioSortedMember);


		mzCEMonedasOrigen.SetValue(_uiController.IdMonedaOrigen);
		mzCEMonedasDestino.SetValue(_uiController.IdMonedaDestino);		
		mzCEFuentesDeCambio.SetValue(_uiController.IdFuenteDeCambio);

		mzCEMonedasOrigen.Enabled = true;
		mzCEMonedasDestino.Enabled = true;
		mzCEFuentesDeCambio.Enabled = true;

		
		labelTarea.Text = _uiController.LeyendaFormulario;
		this.Text = _uiController.LeyendaFormulario;
		lblOrigen.Text = "Por cada unidad en";

		tbbSeparator2.Visible = false;
		tbbCancelar.Visible = false;
		KeyPreview = true;
	}

	private void InitializeData()
	{
	}
	private void InitEventHandlers()
	{
		KeyDownManager KeyDown = new KeyDownManager(this);
	}	
	
	private void InitDataBindings()
	{				
		BindingController.Bind(mzCEMonedasOrigen,"Value", _uiController,"IdMonedaOrigen");
		BindingController.Bind(mzCEMonedasDestino,"Value", _uiController,"IdMonedaDestino");		
		BindingController.Bind(mzCEFuentesDeCambio,"Value", _uiController,"IdFuenteDeCambio");
		uneCotizacion.DataBindings.Add("Value", _uiController, "Cotizacion");
	}

	private void EventsListener()
	{
			
	}

	#endregion


		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{	
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0://Anterior
					_uiController.Previous();
				break;
				case 2:	//Siguiente					
					SaveChanges();
					break;
				case 4:	//Cancelar
					//_uiController.RefreshData();
					CloseForm();
				break;
			}						
		}

		private void SaveChanges()
		{			
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			_uiController.Execute();
		}

		

		private void mzProductosControl_SingleSelectionProducto(object sender, EventArgs e)
		{
			
		}
		private void mzProductosControl_MultipleSelectionProducto(object sender, EventArgs e)
		{
			
		}

		private void _uiController_ComprobanteChanged(object sender, EventArgs e)
		{			
							
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
			Previous();
		}

		public void KeyDownNext()
		{
			SaveChanges();
		}

		#endregion
		private void ultraLabel2_Click(object sender, System.EventArgs e)
		{
			
		}

		private void cldFechaVencimiento_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}

		private void ultraLabel1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void gridProductos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		private void Init() 
		{			
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;			
		}
	}
}

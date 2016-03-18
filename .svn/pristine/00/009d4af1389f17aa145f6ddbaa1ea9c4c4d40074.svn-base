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
	/// Descripción breve de FrmAbmChequeras.
	/// </summary>
	public class FrmAbmChequeras : System.Windows.Forms.Form,ITaskForm
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
		private System.Windows.Forms.Label labelSearch;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelLeyenda;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorBancoBusqueda;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorCuentaBusqueda;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorBanco;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorCuenta;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit nroChequera;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultimoCheque;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit primerCheque;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label lChequera;
		private System.Windows.Forms.Label lUltimoCheque;
		private System.Windows.Forms.Label lPrimerCheque;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorPChequeBusqueda;
		private System.Windows.Forms.Label lfechaCierre;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtFechaCierre;
		
		
		private ABMChequerasControllers _uiController;
		
		

		public FrmAbmChequeras()
		{
			InitializeComponent();
			//controlador asociado al form q se comunicara con tarea en el workflow
			_uiController = new ABMChequerasControllers();
			Build_UI();
			
		}
		public FrmAbmChequeras(ABMChequerasControllers controllers)
		{
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
		protected void Build_UI()
		{	//Configura los controlles, visibilidad, etc, etc
			ConfigureInterface();	
			//Ejemplo le carga datos a un combo
			InitializeData();
			
		
			InitEventHandlers();
			InitDataBindings();		
			//Para propiedades estaticas, datos q no dependen ni modifican a nadie.
			//carga la info q viene del controller
			//FillControls();
		}
		#region metodos privados
		private void ConfigureInterface()
		{/*Le pide al controller los controlles q tiene q poner deshabilitado*/
			
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
			
			//Configuracion de mascaras para nroChequera, primer cheque y ultimo cheque
			this.primerCheque.InputMask=_uiController.MascaraPrimerCheque;
			this.ultimoCheque.InputMask=_uiController.MascaraUltimoCheque;
			this.nroChequera.InputMask=_uiController.MascaraNroChequera;
			this.mzComboEditorCuenta.Enabled=false;
			this.mzComboEditorCuentaBusqueda.Enabled=false;
			this.mzComboEditorPChequeBusqueda.Enabled=false;
			this.txtFechaCierre.Visible=false;
			this.lfechaCierre.Visible=false;
			//Toma los valores definidos en la bd
			this.tbbAnterior.Text=_uiController.TextoBotonAnterior;
			this.tbbAnterior.Enabled=false;
			this.tbbSiguiente.Text=_uiController.TextoBotonSiguiente;
			this.labelLeyenda.Text=_uiController.Leyenda;
			this.Text=_uiController.Leyenda;
			KeyPreview = true;
        }

		private void InitializeData()
		{
			this.mzComboEditorBanco.FillFromDataSource(_uiController.Bancos, _uiController.KeyValueBanco, _uiController.KeyListBanco, 100, _uiController.KeyListBanco);	
			this.mzComboEditorBancoBusqueda.FillFromDataSource(_uiController.Bancos, _uiController.KeyValueBanco, _uiController.KeyListBanco, 100, _uiController.KeyListBanco);	

		}
		private void InitDataBindings()
		{
			
		BindingController.Bind(this.nroChequera,"Value", _uiController, "Chequera");
		BindingController.Bind(this.primerCheque,"Value",_uiController,"PrimerCheque");
		BindingController.Bind(this.ultimoCheque,"Value",_uiController,"UltimoCheque");
		

		}
	
		private void InitEventHandlers()
		{
			this.mzComboEditorBanco.ValueChanged+=new EventHandler(mzComboEditorBanco_ValueChanged);
			this.mzComboEditorCuenta.ValueChanged+=new EventHandler(mzComboEditorCuenta_ValueChanged);
            this.toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			//Para la busqueda
			this.mzComboEditorBancoBusqueda.ValueChanged+=new EventHandler(mzComboEditorBancoBusqueda_ValueChanged);
			this.mzComboEditorCuentaBusqueda.ValueChanged+=new EventHandler(mzComboEditorCuentaBusqueda_ValueChanged);
			this.mzComboEditorPChequeBusqueda.ValueChanged+=new EventHandler(mzComboEditorPChequeBusqueda_ValueChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmChequeras));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelLeyenda = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label6 = new System.Windows.Forms.Label();
			this.mzComboEditorPChequeBusqueda = new mz.erp.ui.controls.mzComboEditor();
			this.mzComboEditorCuentaBusqueda = new mz.erp.ui.controls.mzComboEditor();
			this.mzComboEditorBancoBusqueda = new mz.erp.ui.controls.mzComboEditor();
			this.labelSearch = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.lfechaCierre = new System.Windows.Forms.Label();
			this.txtFechaCierre = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.primerCheque = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.ultimoCheque = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.nroChequera = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.lChequera = new System.Windows.Forms.Label();
			this.mzComboEditorCuenta = new mz.erp.ui.controls.mzComboEditor();
			this.mzComboEditorBanco = new mz.erp.ui.controls.mzComboEditor();
			this.lUltimoCheque = new System.Windows.Forms.Label();
			this.lPrimerCheque = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorPChequeBusqueda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuentaBusqueda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBancoBusqueda)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFechaCierre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBanco)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelLeyenda);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(734, 25);
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
			this.labelLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboEditorPChequeBusqueda);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboEditorCuentaBusqueda);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboEditorBancoBusqueda);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelSearch);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 108);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(734, 50);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label6.Location = new System.Drawing.Point(496, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 24);
			this.label6.TabIndex = 107;
			this.label6.Text = "Primer Cheque:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzComboEditorPChequeBusqueda
			// 
			this.mzComboEditorPChequeBusqueda.AutoComplete = true;
			this.mzComboEditorPChequeBusqueda.DataSource = null;
			this.mzComboEditorPChequeBusqueda.DisplayMember = "";
			this.mzComboEditorPChequeBusqueda.DisplayMemberCaption = "";
			this.mzComboEditorPChequeBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorPChequeBusqueda.Location = new System.Drawing.Point(568, 15);
			this.mzComboEditorPChequeBusqueda.MaxItemsDisplay = 50;
			this.mzComboEditorPChequeBusqueda.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorPChequeBusqueda.Name = "mzComboEditorPChequeBusqueda";
			this.mzComboEditorPChequeBusqueda.Size = new System.Drawing.Size(160, 21);
			this.mzComboEditorPChequeBusqueda.SorterMember = "";
			this.mzComboEditorPChequeBusqueda.TabIndex = 106;
			this.mzComboEditorPChequeBusqueda.ValueMember = "";
			this.mzComboEditorPChequeBusqueda.ValueMemberCaption = "";
			// 
			// mzComboEditorCuentaBusqueda
			// 
			this.mzComboEditorCuentaBusqueda.AutoComplete = true;
			this.mzComboEditorCuentaBusqueda.DataSource = null;
			this.mzComboEditorCuentaBusqueda.DisplayMember = "";
			this.mzComboEditorCuentaBusqueda.DisplayMemberCaption = "";
			this.mzComboEditorCuentaBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorCuentaBusqueda.Location = new System.Drawing.Point(320, 15);
			this.mzComboEditorCuentaBusqueda.MaxItemsDisplay = 50;
			this.mzComboEditorCuentaBusqueda.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorCuentaBusqueda.Name = "mzComboEditorCuentaBusqueda";
			this.mzComboEditorCuentaBusqueda.Size = new System.Drawing.Size(160, 21);
			this.mzComboEditorCuentaBusqueda.SorterMember = "";
			this.mzComboEditorCuentaBusqueda.TabIndex = 105;
			this.mzComboEditorCuentaBusqueda.ValueMember = "";
			this.mzComboEditorCuentaBusqueda.ValueMemberCaption = "";
			// 
			// mzComboEditorBancoBusqueda
			// 
			this.mzComboEditorBancoBusqueda.AutoComplete = true;
			this.mzComboEditorBancoBusqueda.DataSource = null;
			this.mzComboEditorBancoBusqueda.DisplayMember = "";
			this.mzComboEditorBancoBusqueda.DisplayMemberCaption = "";
			this.mzComboEditorBancoBusqueda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorBancoBusqueda.Location = new System.Drawing.Point(64, 15);
			this.mzComboEditorBancoBusqueda.MaxItemsDisplay = 50;
			this.mzComboEditorBancoBusqueda.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorBancoBusqueda.Name = "mzComboEditorBancoBusqueda";
			this.mzComboEditorBancoBusqueda.Size = new System.Drawing.Size(160, 21);
			this.mzComboEditorBancoBusqueda.SorterMember = "";
			this.mzComboEditorBancoBusqueda.TabIndex = 104;
			this.mzComboEditorBancoBusqueda.ValueMember = "";
			this.mzComboEditorBancoBusqueda.ValueMemberCaption = "";
			// 
			// labelSearch
			// 
			this.labelSearch.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelSearch.Location = new System.Drawing.Point(8, 15);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.TabIndex = 2;
			this.labelSearch.Text = "Banco:";
			this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(248, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "Cuenta:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.lfechaCierre);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtFechaCierre);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.primerCheque);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultimoCheque);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.nroChequera);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.lChequera);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzComboEditorCuenta);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzComboEditorBanco);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.lUltimoCheque);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.lPrimerCheque);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 217);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(734, 136);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// lfechaCierre
			// 
			this.lfechaCierre.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lfechaCierre.Location = new System.Drawing.Point(8, 56);
			this.lfechaCierre.Name = "lfechaCierre";
			this.lfechaCierre.Size = new System.Drawing.Size(48, 24);
			this.lfechaCierre.TabIndex = 115;
			this.lfechaCierre.Text = "Fecha Cierre:";
			this.lfechaCierre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtFechaCierre
			// 
			this.txtFechaCierre.Location = new System.Drawing.Point(56, 58);
			this.txtFechaCierre.Name = "txtFechaCierre";
			this.txtFechaCierre.Size = new System.Drawing.Size(160, 21);
			this.txtFechaCierre.TabIndex = 114;
			// 
			// primerCheque
			// 
			this.primerCheque.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Long;
			this.primerCheque.InputMask = "nnnnnnnn";
			this.primerCheque.Location = new System.Drawing.Point(312, 56);
			this.primerCheque.Name = "primerCheque";
			this.primerCheque.Size = new System.Drawing.Size(160, 20);
			this.primerCheque.TabIndex = 113;
			// 
			// ultimoCheque
			// 
			this.ultimoCheque.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Long;
			this.ultimoCheque.InputMask = "nnnnnnnn";
			this.ultimoCheque.Location = new System.Drawing.Point(568, 58);
			this.ultimoCheque.Name = "ultimoCheque";
			this.ultimoCheque.Size = new System.Drawing.Size(160, 20);
			this.ultimoCheque.TabIndex = 112;
			// 
			// nroChequera
			// 
			this.nroChequera.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Long;
			this.nroChequera.InputMask = "nnnnnnnn";
			this.nroChequera.Location = new System.Drawing.Point(568, 16);
			this.nroChequera.Name = "nroChequera";
			this.nroChequera.Size = new System.Drawing.Size(160, 20);
			this.nroChequera.TabIndex = 111;
			// 
			// lChequera
			// 
			this.lChequera.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lChequera.Location = new System.Drawing.Point(496, 16);
			this.lChequera.Name = "lChequera";
			this.lChequera.Size = new System.Drawing.Size(64, 24);
			this.lChequera.TabIndex = 110;
			this.lChequera.Text = "Chequera:";
			this.lChequera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzComboEditorCuenta
			// 
			this.mzComboEditorCuenta.AutoComplete = true;
			this.mzComboEditorCuenta.DataSource = null;
			this.mzComboEditorCuenta.DisplayMember = "";
			this.mzComboEditorCuenta.DisplayMemberCaption = "";
			this.mzComboEditorCuenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorCuenta.Location = new System.Drawing.Point(312, 16);
			this.mzComboEditorCuenta.MaxItemsDisplay = 50;
			this.mzComboEditorCuenta.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorCuenta.Name = "mzComboEditorCuenta";
			this.mzComboEditorCuenta.Size = new System.Drawing.Size(160, 21);
			this.mzComboEditorCuenta.SorterMember = "";
			this.mzComboEditorCuenta.TabIndex = 103;
			this.mzComboEditorCuenta.ValueMember = "";
			this.mzComboEditorCuenta.ValueMemberCaption = "";
			// 
			// mzComboEditorBanco
			// 
			this.mzComboEditorBanco.AutoComplete = true;
			this.mzComboEditorBanco.DataSource = null;
			this.mzComboEditorBanco.DisplayMember = "";
			this.mzComboEditorBanco.DisplayMemberCaption = "";
			this.mzComboEditorBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorBanco.Location = new System.Drawing.Point(56, 16);
			this.mzComboEditorBanco.MaxItemsDisplay = 50;
			this.mzComboEditorBanco.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorBanco.Name = "mzComboEditorBanco";
			this.mzComboEditorBanco.Size = new System.Drawing.Size(160, 21);
			this.mzComboEditorBanco.SorterMember = "";
			this.mzComboEditorBanco.TabIndex = 102;
			this.mzComboEditorBanco.ValueMember = "";
			this.mzComboEditorBanco.ValueMemberCaption = "";
			// 
			// lUltimoCheque
			// 
			this.lUltimoCheque.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lUltimoCheque.Location = new System.Drawing.Point(496, 56);
			this.lUltimoCheque.Name = "lUltimoCheque";
			this.lUltimoCheque.Size = new System.Drawing.Size(88, 24);
			this.lUltimoCheque.TabIndex = 12;
			this.lUltimoCheque.Text = "Ultimo Cheque:";
			this.lUltimoCheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lPrimerCheque
			// 
			this.lPrimerCheque.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lPrimerCheque.Location = new System.Drawing.Point(240, 56);
			this.lPrimerCheque.Name = "lPrimerCheque";
			this.lPrimerCheque.Size = new System.Drawing.Size(88, 24);
			this.lPrimerCheque.TabIndex = 11;
			this.lPrimerCheque.Text = "Primer Cheque:";
			this.lPrimerCheque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(240, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "Cuenta:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 24);
			this.label1.TabIndex = 9;
			this.label1.Text = "Banco:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.toolBarStandar.Size = new System.Drawing.Size(800, 28);
			this.toolBarStandar.TabIndex = 20;
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
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Key = "Leyenda";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Leyenda";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Key = "DatosGenerales";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 50;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "Datoschequera";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 136;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Datos de  la chequera";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(800, 322);
			this.ultraExplorerBar1.TabIndex = 21;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmAbmChequeras
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 350);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmChequeras";
			this.Text = "FrmAbmChequeras";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorPChequeBusqueda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuentaBusqueda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBancoBusqueda)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtFechaCierre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBanco)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
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
		}

		public void KeyDownNext()
		{
			System.DateTime fechaCierre=Convert.ToDateTime(txtFechaCierre.Text);
			_uiController.FechaCierre=fechaCierre;
			_uiController.Execute();
		}


		#endregion

		private void mzComboEditorBanco_ValueChanged(object sender, EventArgs e)
		{
			if(mzComboEditorBanco.Value!=null)
			{
				_uiController.IdBanco=Convert.ToString(mzComboEditorBanco.Value);
				_uiController.IdCuenta=string.Empty;
				this.mzComboEditorCuenta.Enabled=true;
				this.mzComboEditorCuenta.FillFromDataSource(_uiController.CuentasBancarias, _uiController.KeyValueCuenta, _uiController.KeyListCuenta, 100, _uiController.KeyListCuenta);	
			
			}

		}

		private void mzComboEditorCuenta_ValueChanged(object sender, EventArgs e)
		{
			if(mzComboEditorCuenta.Value!=null)
			{
				_uiController.IdCuenta=Convert.ToString(mzComboEditorCuenta.Value);
			}
		}
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{ 
				case 4://Cancelar
					//this.ResetearDatos();
					break;
				case 2://Guardar	
					System.DateTime fechaCierre=Convert.ToDateTime(txtFechaCierre.Text);
					_uiController.FechaCierre=fechaCierre;
					_uiController.Execute();
					break;
			}						
		}

		private void mzComboEditorBancoBusqueda_ValueChanged(object sender, EventArgs e)
		{
			if (this.mzComboEditorBancoBusqueda.Value!=null)
			{
				this.ultraExplorerBar1.Groups["Datoschequera"].Container.Enabled = false;
				_uiController.IdChequera=string.Empty;
				_uiController.IdBancoBusqueda=Convert.ToString(mzComboEditorBancoBusqueda.Value);
				_uiController.IdCuentaBusqueda=string.Empty;
				this.mzComboEditorCuenta.Enabled=true;
				this.mzComboEditorCuentaBusqueda.Enabled=true;
				this.mzComboEditorCuentaBusqueda.FillFromDataSource(_uiController.CuentasBancarias, _uiController.KeyValueCuenta, _uiController.KeyListCuenta, 100, _uiController.KeyListCuenta);	
				BindingController.Clear(this.nroChequera,"Value", _uiController, "Chequera");
				BindingController.Clear(this.primerCheque,"Value",_uiController,"PrimerCheque");
				BindingController.Clear(this.ultimoCheque,"Value",_uiController,"UltimoCheque");
			
			}
		}

		private void mzComboEditorCuentaBusqueda_ValueChanged(object sender, EventArgs e)
		{
			if(mzComboEditorCuentaBusqueda.Value!=null)
			{
				this.ultraExplorerBar1.Groups["Datoschequera"].Container.Enabled = false;
				_uiController.IdCuentaBusqueda=Convert.ToString(mzComboEditorCuentaBusqueda.Value);
				this.mzComboEditorPChequeBusqueda.Enabled=true;
				this.mzComboEditorPChequeBusqueda.FillFromDataSource(_uiController.Chequeras, _uiController.KeyValueCheque, _uiController.KeyListCheque, 100, _uiController.KeyListCheque);	
			}
		}

		private void mzComboEditorPChequeBusqueda_ValueChanged(object sender, EventArgs e)
		{
				if(this.mzComboEditorPChequeBusqueda.Value!=null){
				//Carga todos los datos abajo, pone enabled=true el contenedor
				this.ultraExplorerBar1.Groups["Datoschequera"].Container.Enabled = true;
				_uiController.IdChequera=Convert.ToString(mzComboEditorPChequeBusqueda.Value);
				_uiController.CargarDatos();
				this.mzComboEditorBanco.ValueChanged-=new EventHandler(mzComboEditorBanco_ValueChanged);
				this.mzComboEditorCuenta.ValueChanged-=new EventHandler(mzComboEditorCuenta_ValueChanged);
				this.mzComboEditorBanco.Value=_uiController.IdBanco;
				this.mzComboEditorCuenta.FillFromDataSource(_uiController.CuentasBancarias, _uiController.KeyValueCuenta, _uiController.KeyListCuenta, 100, _uiController.KeyListCuenta);	
				mzComboEditorCuenta.Value=_uiController.IdCuenta;
				BindingController.Bind(this.nroChequera,"Value", _uiController, "Chequera");
				BindingController.Bind(this.primerCheque,"Value",_uiController,"PrimerCheque");
				BindingController.Bind(this.ultimoCheque,"Value",_uiController,"UltimoCheque");
				this.mzComboEditorBanco.ValueChanged+=new EventHandler(mzComboEditorBanco_ValueChanged);
				this.mzComboEditorCuenta.ValueChanged+=new EventHandler(mzComboEditorCuenta_ValueChanged);
				//Pongo  todos los controlles enabled, porq solo puede modificar la fecha de cierre
				this.mzComboEditorBanco.Enabled=false;
				this.mzComboEditorCuenta.Enabled=false;
				this.nroChequera.Enabled=false;
				this.primerCheque.Enabled=false;
				this.ultimoCheque.Enabled=false;
				this.txtFechaCierre.Visible=true;
				this.lfechaCierre.Visible=true;
			}

		}
	
	}
}

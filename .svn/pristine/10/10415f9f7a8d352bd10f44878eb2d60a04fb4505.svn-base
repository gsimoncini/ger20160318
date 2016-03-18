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
	/// Descripción breve de FrmDepositoBancario.
	/// </summary>
	public class FrmDepositoBancario : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.Label label5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelLeyenda;
		private System.Windows.Forms.ImageList imageList1;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private System.ComponentModel.IContainer components;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorBanco;
		private mz.erp.ui.controls.mzComboEditor mzComboEditorCuenta;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtFechaDeposito;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit NroBoleta;
		#region variables privadas
			private DepositoBancarioController _uiController;
		#endregion

		public FrmDepositoBancario()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmDepositoBancario(DepositoBancarioController controllers)
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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmDepositoBancario));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelLeyenda = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.NroBoleta = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.txtFechaDeposito = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.mzComboEditorCuenta = new mz.erp.ui.controls.mzComboEditor();
			this.mzComboEditorBanco = new mz.erp.ui.controls.mzComboEditor();
			this.labelSearch = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
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
			((System.ComponentModel.ISupportInitialize)(this.txtFechaDeposito)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBanco)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelLeyenda);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(962, 25);
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
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.NroBoleta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtFechaDeposito);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboEditorCuenta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboEditorBanco);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelSearch);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 108);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(962, 84);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(664, 8);
			this.label2.Name = "label2";
			this.label2.TabIndex = 118;
			this.label2.Text = "Fecha Depósito:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(664, 41);
			this.label1.Name = "label1";
			this.label1.TabIndex = 117;
			this.label1.Text = "Nro Boleta:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NroBoleta
			// 
			this.NroBoleta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.Long;
			this.NroBoleta.InputMask = "nnnnnnnn";
			this.NroBoleta.Location = new System.Drawing.Point(768, 41);
			this.NroBoleta.Name = "NroBoleta";
			this.NroBoleta.Size = new System.Drawing.Size(160, 20);
			this.NroBoleta.TabIndex = 3;
			// 
			// txtFechaDeposito
			// 
			this.txtFechaDeposito.Location = new System.Drawing.Point(768, 8);
			this.txtFechaDeposito.Name = "txtFechaDeposito";
			this.txtFechaDeposito.Size = new System.Drawing.Size(160, 21);
			this.txtFechaDeposito.TabIndex = 2;
			// 
			// mzComboEditorCuenta
			// 
			this.mzComboEditorCuenta.AutoComplete = true;
			this.mzComboEditorCuenta.DataSource = null;
			this.mzComboEditorCuenta.DisplayMember = "";
			this.mzComboEditorCuenta.DisplayMemberCaption = "";
			this.mzComboEditorCuenta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEditorCuenta.Location = new System.Drawing.Point(104, 40);
			this.mzComboEditorCuenta.MaxItemsDisplay = 50;
			this.mzComboEditorCuenta.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorCuenta.Name = "mzComboEditorCuenta";
			this.mzComboEditorCuenta.Size = new System.Drawing.Size(160, 21);
			this.mzComboEditorCuenta.SorterMember = "";
			this.mzComboEditorCuenta.TabIndex = 1;
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
			this.mzComboEditorBanco.Location = new System.Drawing.Point(104, 8);
			this.mzComboEditorBanco.MaxItemsDisplay = 50;
			this.mzComboEditorBanco.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEditorBanco.Name = "mzComboEditorBanco";
			this.mzComboEditorBanco.Size = new System.Drawing.Size(160, 21);
			this.mzComboEditorBanco.SorterMember = "";
			this.mzComboEditorBanco.TabIndex = 0;
			this.mzComboEditorBanco.ValueMember = "";
			this.mzComboEditorBanco.ValueMemberCaption = "";
			// 
			// labelSearch
			// 
			this.labelSearch.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelSearch.Location = new System.Drawing.Point(8, 8);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.TabIndex = 2;
			this.labelSearch.Text = "Banco:";
			this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(8, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 24);
			this.label5.TabIndex = 13;
			this.label5.Text = "Cuenta Bancaria:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 251);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(962, 271);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.AlternatingColors = true;
			this.gridResultado.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridResultado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridResultado.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridResultado.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridResultado.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridResultado.Location = new System.Drawing.Point(0, 32);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.RecordNavigatorText = "Registro:|de";
			this.gridResultado.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridResultado.ShowEmptyFields = false;
			this.gridResultado.Size = new System.Drawing.Size(968, 240);
			this.gridResultado.TabIndex = 2;
			this.gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(962, 24);
			this.gridManagerView1.TabIndex = 0;
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
			this.toolBarStandar.Size = new System.Drawing.Size(1028, 28);
			this.toolBarStandar.TabIndex = 21;
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
			ultraExplorerBarGroup2.Settings.ContainerHeight = 84;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos del depósito";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "ValoresADepositar";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 271;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Valores a Depositar";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(1028, 506);
			this.ultraExplorerBar1.TabIndex = 22;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmDepositoBancario
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 534);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmDepositoBancario";
			this.Text = "FrmDepositoBancario";
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtFechaDeposito)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorCuenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEditorBanco)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
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
			
			Close();								
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}


		#endregion
		#region metodos privados
		protected void Build_UI()
		{	//Configura los controlles, visibilidad, etc, etc
			ConfigureInterface();	
			
			
			
			//Ejemplo le carga datos a un combo
			InitializeData();
			InitEventHandlers();
			InitDataBindings();		
			
		}
		private void ConfigureInterface(){

				//Toma los valores definidos en la bd
			this.tbbAnterior.Text=_uiController.TextoBotonAnterior;
			this.tbbAnterior.Enabled=false;
			this.tbbSiguiente.Text=_uiController.TextoBotonSiguiente;
			this.labelLeyenda.Text=_uiController.Leyenda;
			this.Text=_uiController.Leyenda;
			//Otras configurations
			gridManagerView1.Configure(_uiController.GetProcessName(), _uiController.GetTaskName(),this.Name, gridResultado, this.Text);
			gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
		}
	    private void InitializeData(){

			gridResultado.DataSource=_uiController.Data;
			this.mzComboEditorBanco.FillFromDataSource(_uiController.Bancos, _uiController.KeyValueBanco, _uiController.KeyListBanco, 100, _uiController.KeyListBanco);	
		}

		private void InitDataBindings()
		{
			
			BindingController.Bind(this.txtFechaDeposito,"Text", _uiController, "FechaDeposito");
			BindingController.Bind(this.NroBoleta,"Value",_uiController,"NroBoleta");
			
		

		}
		private void InitEventHandlers(){
			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.mzComboEditorBanco.ValueChanged+=new EventHandler(mzComboEditorBanco_ValueChanged);
			this.mzComboEditorCuenta.ValueChanged+=new EventHandler(mzComboEditorCuenta_ValueChanged);
		}

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
		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{ 
				case 0://Cancelar
					_uiController.Previous();
					break;
				case 2://Guardar	
					_uiController.Execute();
					break;
			}			
		}
		#endregion

		
	}
}

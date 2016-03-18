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
	/// Descripción breve de FrmAbmCuentasCondicionesDeVenta.
	/// </summary>
	public class FrmAbmCuentasCondicionesDeVenta : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;

		public FrmAbmCuentasCondicionesDeVenta()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmAbmCuentasCondicionesDeVenta(AbmCuentasCondicionesDeVentaController controller)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			
			InitializeComponent();
			_uiController = controller;	
			Init();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
				BindingController.Clear(mzCmbCuenta, "DataValue", _uiController, "Codigo");
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmCuentasCondicionesDeVenta));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.container = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.gridCondicionesDeVenta = new Janus.Windows.GridEX.GridEX();
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
			this.container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCondicionesDeVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// container
			// 
			this.container.Controls.Add(this.ultraLabel1);
			this.container.Controls.Add(this.mzCmbCuenta);
			this.container.Controls.Add(this.gridCondicionesDeVenta);
			this.container.Location = new System.Drawing.Point(28, 49);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(839, 295);
			this.container.TabIndex = 0;
			// 
			// ultraLabel1
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
			this.ultraLabel1.Appearance = appearance1;
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(15, 11);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel1.TabIndex = 82;
			this.ultraLabel1.Text = "Cuenta";
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EditObject = null;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCuenta.HierarchicalSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(88, 8);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.SearchObject = null;
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(384, 22);
			this.mzCmbCuenta.TabIndex = 81;
			// 
			// gridCondicionesDeVenta
			// 
			this.gridCondicionesDeVenta.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridCondicionesDeVenta.AlternatingColors = true;
			this.gridCondicionesDeVenta.AutomaticSort = false;
			this.gridCondicionesDeVenta.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridCondicionesDeVenta.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCondicionesDeVenta.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridCondicionesDeVenta.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridCondicionesDeVenta.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridCondicionesDeVenta.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridCondicionesDeVenta.GroupByBoxVisible = false;
			this.gridCondicionesDeVenta.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridCondicionesDeVenta.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridCondicionesDeVenta.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridCondicionesDeVenta.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridCondicionesDeVenta.Location = new System.Drawing.Point(87, 39);
			this.gridCondicionesDeVenta.Name = "gridCondicionesDeVenta";
			this.gridCondicionesDeVenta.RecordNavigator = true;
			this.gridCondicionesDeVenta.RecordNavigatorText = "Registro:|de";
			this.gridCondicionesDeVenta.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridCondicionesDeVenta.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCondicionesDeVenta.ShowEmptyFields = false;
			this.gridCondicionesDeVenta.Size = new System.Drawing.Size(384, 256);
			this.gridCondicionesDeVenta.TabIndex = 80;
			this.gridCondicionesDeVenta.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
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
			this.toolBarStandar.Size = new System.Drawing.Size(888, 28);
			this.toolBarStandar.TabIndex = 77;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			this.ultraExplorerBar1.Controls.Add(this.container);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.container;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 295;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Información";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(888, 458);
			this.ultraExplorerBar1.TabIndex = 80;
			// 
			// FrmAbmCuentasCondicionesDeVenta
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(888, 486);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmCuentasCondicionesDeVenta";
			this.Text = "FrmAbmCuentasCondicionesDeVenta";
			this.container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCondicionesDeVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

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
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl container;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta;
		private Janus.Windows.GridEX.GridEX gridCondicionesDeVenta;

		private AbmCuentasCondicionesDeVentaController _uiController;
		public void ShowForm()
		{
			Show();
		}

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
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
				if (_uiController.IsValid) 
				{				
					Close();
				}
			}
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}

		private void Init() 
		{
			this.Text = "Condiciones de venta para cliente";
			mzCmbCuenta.Enabled = true;						
			mzCmbCuenta.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas  );
			BindingController.Bind(mzCmbCuenta, "DataValue", _uiController, "Codigo");

			gridCondicionesDeVenta.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridCondicionesDeVenta.LayoutData =  mz.erp.ui.forms.classes.tsa_CuentasCondicionesDeVenta_TDCompTesoreria.GetLayoutAbmCuentasCondicionesDeVenta();			

			_uiController.CodigoChanged+=new EventHandler(_uiController_CodigoChanged);
			KeyPreview = true;
			KeyDownManager KeyDown = new KeyDownManager(this);

			
			//gridImpuestos.SetDataBinding(_cp.Impuestos,null);

				/*_uiController.OnShowForm +=new EventHandler(_uiController_OnShowForm);
				_uiController.OnCloseForm +=new EventHandler(_uiController_OnCloseForm);
				_uiController.OnChangeTimer +=new EventHandler(_uiController_OnChangeTimer);*/
			}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 5:					
					break;
				case 7:
					Util.MoveFocus(this.container);
					_uiController.Execute();
					break;
				case 9:					
					break;

			}
		
		}

		private void _uiController_CodigoChanged(object sender, EventArgs e)
		{			
			gridCondicionesDeVenta.SetDataBinding(_uiController.CuentaCondicionesDeVenta,null);
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using Janus.Windows.GridEX;


using System.Data;
using mz.erp.systemframework;
using mz.erp.ui.forms.classes;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmVisualizacionCuentaCorriente.
	/// </summary>
	public class FrmVisualizacionCuentaCorrienteGeneral : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.ComponentModel.IContainer components;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteHasta;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.ToolBarButton tbbVerCtaCte;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbVerAsociaciones;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		//private mz.erp.ui.controls.mzComboSearchEditor mzCETitular;
		
		//private CuentaCorriente _ctaCte;
		private string _orderBy = string.Empty;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private string _processName = string.Empty;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ImageList imglStandar;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControlClientes;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControlClientes;
		

		#region Variables Privadas
		private controllers.CuentaCorrienteGeneralController _uiController = null;
		#endregion

		#region Variables Publicas
		#endregion

		#region Constructores y Destructores
		
		/*		public FrmVisualizacionCuentaCorrienteGeneral(string Proceso)
				{
					InitializeComponent();
					initializeMembers();
					//mzCETitular.Select();		
					//this.richInfoComprobante.ReadOnly = true;
					this._processName = Proceso;
					this.labelTarea.Text = Variables.GetValueString("Momentos." + _processName + ".LeyendaFormulario");
				}*/

		public FrmVisualizacionCuentaCorrienteGeneral( controllers.CuentaCorrienteGeneralController controller )
		{
			InitializeComponent();
			_uiController = controller;
			Init();			
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
		#endregion


		private void initializeMembers()
		{
			//para hacer el color del saldo configurable
			System.Drawing.Color colorDeudor;
			System.Drawing.Color colorAcreedor;
			if( Variables.GetValueBool("CuentaCorriente.SaldoAcumuladoDeudor.Color.Red"))
			{
				colorDeudor = System.Drawing.Color.Red;
				colorAcreedor = System.Drawing.Color.Black;
			}
			else 
			{	
				colorDeudor = System.Drawing.Color.Black;
				colorAcreedor = System.Drawing.Color.Red;
			}
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmVisualizacionCuentaCorrienteGeneral));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label2 = new System.Windows.Forms.Label();
			this.udteHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.ultraExplorerBarContainerControlClientes = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.hierarchicalSearchControlClientes = new mz.erp.ui.controls.HierarchicalSearchControl();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.tbbVerCtaCte = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbbVerAsociaciones = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).BeginInit();
			this.ultraExplorerBarContainerControlClientes.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(871, 24);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(871, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.udteHasta);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(871, 21);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 81;
			this.label2.Text = "Hasta:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// udteHasta
			// 
			this.udteHasta.Location = new System.Drawing.Point(112, 0);
			this.udteHasta.Name = "udteHasta";
			this.udteHasta.Size = new System.Drawing.Size(216, 21);
			this.udteHasta.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControlClientes
			// 
			this.ultraExplorerBarContainerControlClientes.Controls.Add(this.hierarchicalSearchControlClientes);
			this.ultraExplorerBarContainerControlClientes.Location = new System.Drawing.Point(28, 187);
			this.ultraExplorerBarContainerControlClientes.Name = "ultraExplorerBarContainerControlClientes";
			this.ultraExplorerBarContainerControlClientes.Size = new System.Drawing.Size(871, 104);
			this.ultraExplorerBarContainerControlClientes.TabIndex = 4;
			// 
			// hierarchicalSearchControlClientes
			// 
			this.hierarchicalSearchControlClientes.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControlClientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hierarchicalSearchControlClientes.Location = new System.Drawing.Point(35, 8);
			this.hierarchicalSearchControlClientes.Name = "hierarchicalSearchControlClientes";
			this.hierarchicalSearchControlClientes.Size = new System.Drawing.Size(784, 88);
			this.hierarchicalSearchControlClientes.TabIndex = 56;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 227);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(871, 255);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridManagerView1.BackColor = System.Drawing.Color.Transparent;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 8);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(872, 24);
			this.gridManagerView1.TabIndex = 7;
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridEX1.ContextMenu = this.contextMenu1;
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEX1.Location = new System.Drawing.Point(0, 40);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigator = true;
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(872, 208);
			this.gridEX1.TabIndex = 6;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.Detalles});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// Detalles
			// 
			this.Detalles.Index = 0;
			this.Detalles.Text = "Ver detalle";
			this.Detalles.Click += new System.EventHandler(this.Detalles_Click);
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.toolBarButton3,
																							  this.tbbSiguiente,
																							  this.toolBarButton4,
																							  this.tbbVerCtaCte,
																							  this.toolBarButton1,
																							  this.tbbImprimir,
																							  this.toolBarButton2,
																							  this.tbbVerAsociaciones});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "Anterior";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbVerCtaCte
			// 
			this.tbbVerCtaCte.ImageIndex = 6;
			this.tbbVerCtaCte.Text = "Detalle &Cta Cte";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbImprimir
			// 
			this.tbbImprimir.ImageIndex = 4;
			this.tbbImprimir.Text = "&Imprimir";
			this.tbbImprimir.Visible = false;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton2.Visible = false;
			// 
			// tbbVerAsociaciones
			// 
			this.tbbVerAsociaciones.Text = "Ver Cta. Cte.";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControlClientes);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 21;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControlClientes;
			ultraExplorerBarGroup3.Expanded = false;
			ultraExplorerBarGroup3.Key = "Jerarquia";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 104;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Jerarquia Clientes";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 255;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 642);
			this.ultraExplorerBar1.TabIndex = 78;
			// 
			// FrmVisualizacionCuentaCorrienteGeneral
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 670);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmVisualizacionCuentaCorrienteGeneral";
			this.Text = "Cuenta Corriente";
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).EndInit();
			this.ultraExplorerBarContainerControlClientes.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void MostrarDetalleCuentaCorriente()
		{
			this.Cursor = Cursors.WaitCursor;			
			DateTime fecha = DateTime.MinValue;
						
			if (udteHasta.Value == null)
				MessageBox.Show("Debe seleccionar una Fecha","Fecha Invalida", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
			else fecha = (DateTime)udteHasta.Value;									
				

			_uiController.RefreshData();
			if (gridManagerView1.AllowGroupCollapse)
				this.gridEX1.CollapseGroups();
			else
				if (gridEX1.RootTable.Groups.Count > 0 )
				gridEX1.RootTable.Groups[0].Expand();

			this.Cursor = Cursors.Default;					
		}

		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 4://DetalleCtaCte					
					mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
					MostrarDetalleCuentaCorriente();
					break;						
				case 2: //Execute					
					mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
					gridEX1.UpdateData();
					_uiController.Execute();
					break;									

				case 8://Ver cta.cte.
					Detalles_Click(this, new EventArgs());
					break;
				default:
					break;
			}		
		}		

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
		
		}

		private void Detalles_Click(object sender, EventArgs e)
		{			
			this.Cursor = Cursors.WaitCursor;
			if (gridEX1.RecordCount == 0) 
			{
				MessageBox.Show("Debe seleccionar una Cuenta Corriente","Cuenta Corriente Invalida", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
			}
			else 
			{
				string CodigoCliente = Convert.ToString(gridEX1.SelectedItems[0].GetRow().Cells["Codigo"].Value);
				// ----- Matias - Tarea 35
				// ----- Formulario CtaCte viejo
				// FrmVisualizacionCuentaCorriente frmVCC= new FrmVisualizacionCuentaCorriente(_uiController.SubProcess, CodigoCliente);
				// ----- Formulario CtaCte nuevo
				FrmCuentaCorriente frmCC = new FrmCuentaCorriente(_uiController.GetProcessName(), CodigoCliente);
				frmCC.MdiParent = mz.erp.ui.utility.Environment.MainForm;
				frmCC.Show();
				// -----------------------------

				this.Cursor = Cursors.Default;
			}
		}

		private void hierarchicalSearchControlClientes_OnSelected(object sender, EventArgs e)
		{	
			_uiController.ByJerarquia1 = hierarchicalSearchControlClientes.NodeChecked1;
			_uiController.Jerarquias1 = hierarchicalSearchControlClientes.ItemsJerarquia1;
			_uiController.ByJerarquia2 = hierarchicalSearchControlClientes.NodeChecked2;
			_uiController.Jerarquias2 = hierarchicalSearchControlClientes.ItemsJerarquia2;
			_uiController.ByJerarquia3 = hierarchicalSearchControlClientes.NodeChecked3;
			_uiController.Jerarquias3 = hierarchicalSearchControlClientes.ItemsJerarquia3;
			_uiController.ByJerarquia4 = hierarchicalSearchControlClientes.NodeChecked4;
			_uiController.Jerarquias4 = hierarchicalSearchControlClientes.ItemsJerarquia4;
			_uiController.ByJerarquia5 = hierarchicalSearchControlClientes.NodeChecked5;
			_uiController.Jerarquias5 = hierarchicalSearchControlClientes.ItemsJerarquia5;
			_uiController.ByJerarquia6 = hierarchicalSearchControlClientes.NodeChecked6;
			_uiController.Jerarquias6 = hierarchicalSearchControlClientes.ItemsJerarquia6;
			_uiController.ByJerarquia7 = hierarchicalSearchControlClientes.NodeChecked7;
			_uiController.Jerarquias7 = hierarchicalSearchControlClientes.ItemsJerarquia7;
			_uiController.ByJerarquia8 = hierarchicalSearchControlClientes.NodeChecked8;
			_uiController.Jerarquias8 = hierarchicalSearchControlClientes.ItemsJerarquia8;		
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
			Close();			
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
			mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
			gridEX1.UpdateData();
			_uiController.Execute();
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
			this.Text = _uiController.LeyendaFormulario;
			//tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			//tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			//gridEX1.LayoutData = _uiController.GetLayout();				
			gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			//CallGridManager();
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridEX1, this.Text);
			this.Detalles.Text = "Ver Cta.Cte.";
			labelTarea.Text = _uiController.LeyendaFormulario;	

			this.ultraExplorerBar1.Groups["Jerarquia"].Text = _uiController.TextoSolapaJerarquias;
            this.hierarchicalSearchControlClientes.Build_UI(_uiController.KeyHierarchicalSearchControl,_uiController.AllowMultipleSelect);
			KeyPreview = true;
		}

		private void InitializeData()
		{
		}

		private void InitEventHandlers()
		{
			toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			hierarchicalSearchControlClientes.OnSelected+=new EventHandler(hierarchicalSearchControlClientes_OnSelected);
			_uiController.ObjectHasChanged +=new EventHandler(Refresh);
			decimal cantDiasDesde = Variables.GetValueDecimal("CuentaCorriente.RangoFechas.DiasAnteriores");
			decimal cantDiasHasta = Variables.GetValueDecimal("CuentaCorriente.RangoFechas.DiasPosteriores");
			DateTime fHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(Convert.ToDouble(cantDiasHasta));
			udteHasta.Value = fHasta;
			KeyDownManager KeyDownMan = new KeyDownManager(this);
		}	

		private void InitDataBindings()
		{
			udteHasta.DataBindings.Add("Value", _uiController, "FechaHasta");
		}

		/*private void CallGridManager()
		{			
			string proceso = _uiController.GetProcessManager().GetProcessName();
			string tarea = _uiController.GetTaskName();
			controllers.GridVariablesLoader loader = new controllers.GridVariablesLoader(proceso, tarea);
			GridManagerJanus manager = new GridManagerJanus(gridEX1);
			manager.ConfigureGrid(proceso, tarea, loader);							
			gridManagerView1.Init(manager, proceso, tarea, loader);
			gridManagerView1.EnableMarkControl(loader.AllowMarkRow);
			gridManagerView1.EnableColumnsControl(loader.AllowDefineVisibleColumns);
			gridManagerView1.ConfigureMarkControl(loader.NameMarkRow);
			gridManagerView1.ConfigureColumnsControl(string.Empty);	
			gridManagerView1.EnableExportExcelControl(loader.AllowExportExcel);
			gridManagerView1.ConfigureExportExcelControl(string.Empty);
		}*/		

		private void EventsListener()
		{			
		}

		private void Refresh(object sender, EventArgs e)
		{			
			gridEX1.SetDataBinding(null, null);
			gridEX1.SetDataBinding(_uiController.TablaResultado, null);
			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.TablaResultado);			
		}

		#endregion

		private void Init() 
		{		
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;			
		}	
	}
}

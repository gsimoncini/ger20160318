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
using mz.erp.commontypes;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmVisualizacionCuentaCorriente.
	/// </summary>
	public class FrmVisualizacionCuentaCorriente : System.Windows.Forms.Form, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.ComponentModel.IContainer components;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteDesde;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteHasta;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbSoloPendientes;
		private System.Windows.Forms.ToolBarButton tbbVerCtaCte;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor uneSaldoAnterior;
		private Infragistics.Win.UltraWinEditors.UltraCurrencyEditor uneSaldoPosterior;
		private System.Windows.Forms.ToolBarButton tbbImputar;
		private System.Windows.Forms.ToolBarButton tbbVerAsociaciones;
		private System.Windows.Forms.ToolBarButton tbbDesimputar;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton tbbAnular;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		

		private mz.erp.businessrules.comprobantes.CuentaCorriente _ctaCte;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private string _orderBy = string.Empty;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private mz.erp.ui.controls.mzCuentasControl mzCETitular;
		private System.Windows.Forms.RadioButton rbSoloFacturas;
		private System.Windows.Forms.RadioButton rbSoloNotasC;
		private System.Windows.Forms.RadioButton rbTodo;
		private string _processName = string.Empty;
		

		public FrmVisualizacionCuentaCorriente(string Proceso)
		{
			InitializeComponent();
			initializeMembers();
			mzCETitular.Select();		
			this.richInfoComprobante.ReadOnly = true;
			this._processName = Proceso;
			this.labelTarea.Text = Variables.GetValueString("Momentos." + _processName + ".LeyendaFormulario");
			this.Text = this.labelTarea.Text;
		}

		public FrmVisualizacionCuentaCorriente(string Proceso, string CodigoCliente)
		{
			InitializeComponent();
			initializeMembers();
			mzCETitular.Select();		
			this.richInfoComprobante.ReadOnly = true;
			this._processName = Proceso;
			this.labelTarea.Text = Variables.GetValueString("Momentos." + _processName + ".LeyendaFormulario");
			this.Text = this.labelTarea.Text;
			mzCETitular.DataValue = CodigoCliente;
			MostrarDetalleCuentaCorriente();
		}


		private void initializeMembers()
		{
			//para hacer el color del saldo configurable
			mzCETitular.Init();
			mzCETitular.SearchObjectListener = this;
			mzCETitular.EnableCtaCte = false;
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
			//fin de para hacer el color del saldo configurable
			
			//mzCETitular.SearchObject = typeof(  mz.erp.ui.forms.classes.tsa_Cuentas );
			gridEX1.LayoutData= new mz.erp.ui.forms.classes.tsa_CuentaCorriente().GetLayoutDetalleCuentaCorriente();
			
			Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["Saldo"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,0);
		
			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientes"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,0);
			fc.FormatStyle.ForeColor= colorDeudor; //System.Drawing.Color.Red;
			fc.TargetColumn = this.gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"];
			this.gridEX1.RootTable.FormatConditions.Add(fc);

			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientes"],
				Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo,0);
			fc.FormatStyle.ForeColor= colorAcreedor; //System.Drawing.Color.Black;
			fc.TargetColumn = this.gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"];
			this.gridEX1.RootTable.FormatConditions.Add(fc);

			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["SaldoAcumulado"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,0);			
			fc.FormatStyle.ForeColor= colorDeudor; //System.Drawing.Color.Red;
			fc.TargetColumn = this.gridEX1.RootTable.Columns["SaldoAcumuladoSinSigno"];
			this.gridEX1.RootTable.FormatConditions.Add(fc);
			
			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["SaldoAcumulado"],
				Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo,0);			
			fc.FormatStyle.ForeColor= colorAcreedor; //System.Drawing.Color.black;
			fc.TargetColumn = this.gridEX1.RootTable.Columns["SaldoAcumuladoSinSigno"];
			this.gridEX1.RootTable.FormatConditions.Add(fc);


			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["Debe"],
				Janus.Windows.GridEX.ConditionOperator.Equal, 0);			
			fc.FormatStyle.ForeColor = System.Drawing.Color.Transparent;
			fc.TargetColumn = this.gridEX1.RootTable.Columns["Debe"];			
			this.gridEX1.RootTable.FormatConditions.Add(fc);

			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["Haber"],
				Janus.Windows.GridEX.ConditionOperator.Equal, 0);			
			fc.FormatStyle.ForeColor = System.Drawing.Color.Transparent;
			fc.TargetColumn = this.gridEX1.RootTable.Columns["Haber"];					
			this.gridEX1.RootTable.FormatConditions.Add(fc);

			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEX1.RootTable.Columns["SaldoSinSigno"],
				Janus.Windows.GridEX.ConditionOperator.Equal, 0);			
			fc.FormatStyle.ForeColor = System.Drawing.Color.Transparent;
			fc.TargetColumn = this.gridEX1.RootTable.Columns["SaldoSinSigno"];	
			this.gridEX1.RootTable.FormatConditions.Add(fc);

			this.gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"].Visible = false;
		
			toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			decimal cantDiasDesde = Variables.GetValueDecimal("CuentaCorriente.RangoFechas.DiasAnteriores");
			decimal cantDiasHasta = Variables.GetValueDecimal("CuentaCorriente.RangoFechas.DiasPosteriores");
			
			DateTime fDesde = mz.erp.businessrules.Sistema.DateTime.Now.AddDays((-1)* Convert.ToDouble(cantDiasDesde)); 
			DateTime fHasta = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(Convert.ToDouble(cantDiasHasta));

			udteDesde.Value = fDesde;
			udteHasta.Value = fHasta;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmVisualizacionCuentaCorriente));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.rbTodo = new System.Windows.Forms.RadioButton();
			this.rbSoloNotasC = new System.Windows.Forms.RadioButton();
			this.rbSoloFacturas = new System.Windows.Forms.RadioButton();
			this.mzCETitular = new mz.erp.ui.controls.mzCuentasControl();
			this.label5 = new System.Windows.Forms.Label();
			this.cbSoloPendientes = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.udteDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.udteHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneSaldoPosterior = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
			this.uneSaldoAnterior = new Infragistics.Win.UltraWinEditors.UltraCurrencyEditor();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbVerCtaCte = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.tbbImputar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.tbbVerAsociaciones = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbbDesimputar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.tbbAnular = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udteDesde)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneSaldoPosterior)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneSaldoAnterior)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, -33);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(838, 24);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(838, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rbTodo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rbSoloNotasC);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.rbSoloFacturas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCETitular);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cbSoloPendientes);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.udteDesde);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.udteHasta);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -81);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(838, 109);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// rbTodo
			// 
			this.rbTodo.BackColor = System.Drawing.Color.Transparent;
			this.rbTodo.Checked = true;
			this.rbTodo.Location = new System.Drawing.Point(112, 88);
			this.rbTodo.Name = "rbTodo";
			this.rbTodo.Size = new System.Drawing.Size(72, 24);
			this.rbTodo.TabIndex = 4;
			this.rbTodo.TabStop = true;
			this.rbTodo.Text = "Todo";
			// 
			// rbSoloNotasC
			// 
			this.rbSoloNotasC.BackColor = System.Drawing.Color.Transparent;
			this.rbSoloNotasC.Location = new System.Drawing.Point(240, 88);
			this.rbSoloNotasC.Name = "rbSoloNotasC";
			this.rbSoloNotasC.Size = new System.Drawing.Size(168, 24);
			this.rbSoloNotasC.TabIndex = 5;
			this.rbSoloNotasC.Text = "Solo Notas de Crédito";
			// 
			// rbSoloFacturas
			// 
			this.rbSoloFacturas.BackColor = System.Drawing.Color.Transparent;
			this.rbSoloFacturas.Location = new System.Drawing.Point(448, 88);
			this.rbSoloFacturas.Name = "rbSoloFacturas";
			this.rbSoloFacturas.TabIndex = 6;
			this.rbSoloFacturas.Text = "Solo Facturas";
			// 
			// mzCETitular
			// 
			this.mzCETitular.AllowEditClientePaso = false;
			this.mzCETitular.BackColor = System.Drawing.Color.Transparent;
			this.mzCETitular.DataValue = "";
			this.mzCETitular.EnableCtaCte = false;
			this.mzCETitular.FastSearch = false;
			this.mzCETitular.Location = new System.Drawing.Point(112, 0);
			this.mzCETitular.Name = "mzCETitular";
			this.mzCETitular.SearchObjectListener = null;
			this.mzCETitular.Size = new System.Drawing.Size(408, 24);
			this.mzCETitular.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(0, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 24);
			this.label5.TabIndex = 88;
			this.label5.Text = "Visualización";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbSoloPendientes
			// 
			this.cbSoloPendientes.BackColor = System.Drawing.Color.Transparent;
			this.cbSoloPendientes.Location = new System.Drawing.Point(112, 74);
			this.cbSoloPendientes.Name = "cbSoloPendientes";
			this.cbSoloPendientes.Size = new System.Drawing.Size(120, 16);
			this.cbSoloPendientes.TabIndex = 3;
			this.cbSoloPendientes.Text = "Solo Pendientes";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 24);
			this.label3.TabIndex = 82;
			this.label3.Text = "Cliente";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 81;
			this.label2.Text = "Hasta:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 24);
			this.label1.TabIndex = 80;
			this.label1.Text = "Desde:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// udteDesde
			// 
			this.udteDesde.Location = new System.Drawing.Point(112, 24);
			this.udteDesde.Name = "udteDesde";
			this.udteDesde.Size = new System.Drawing.Size(216, 21);
			this.udteDesde.TabIndex = 1;
			// 
			// udteHasta
			// 
			this.udteHasta.Location = new System.Drawing.Point(112, 48);
			this.udteHasta.Name = "udteHasta";
			this.udteHasta.Size = new System.Drawing.Size(216, 21);
			this.udteHasta.TabIndex = 2;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneSaldoPosterior);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneSaldoAnterior);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 87);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(838, 255);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// uneSaldoPosterior
			// 
			this.uneSaldoPosterior.Location = new System.Drawing.Point(728, 227);
			this.uneSaldoPosterior.MaskInput = "$-nnnnnnnnn.nn";
			this.uneSaldoPosterior.Name = "uneSaldoPosterior";
			this.uneSaldoPosterior.ReadOnly = true;
			this.uneSaldoPosterior.Size = new System.Drawing.Size(104, 21);
			this.uneSaldoPosterior.TabIndex = 2;
			this.uneSaldoPosterior.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// uneSaldoAnterior
			// 
			this.uneSaldoAnterior.FormatString = "";
			this.uneSaldoAnterior.Location = new System.Drawing.Point(728, 0);
			this.uneSaldoAnterior.MaskInput = "$-nnnnnnnnn.nn";
			this.uneSaldoAnterior.Name = "uneSaldoAnterior";
			this.uneSaldoAnterior.ReadOnly = true;
			this.uneSaldoAnterior.Size = new System.Drawing.Size(104, 21);
			this.uneSaldoAnterior.TabIndex = 0;
			this.uneSaldoAnterior.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(624, 227);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 21);
			this.label6.TabIndex = 79;
			this.label6.Text = "Saldo Actual";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(624, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 21);
			this.label4.TabIndex = 77;
			this.label4.Text = "Saldo Anterior";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
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
			this.gridEX1.Location = new System.Drawing.Point(0, 24);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigator = true;
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(832, 200);
			this.gridEX1.TabIndex = 1;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.gridEX1.SelectionChanged += new System.EventHandler(this.gridEX1_SelectionChanged);
			this.gridEX1.SortKeysChanged += new System.EventHandler(this.gridEX1_SortKeysChanged);
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
			this.Detalles.Text = "Ver detalles";
			this.Detalles.Click += new System.EventHandler(this.Detalles_Click);
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.richInfoComprobante);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 401);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(838, 216);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// richInfoComprobante
			// 
			this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
			this.richInfoComprobante.Name = "richInfoComprobante";
			this.richInfoComprobante.Size = new System.Drawing.Size(832, 208);
			this.richInfoComprobante.TabIndex = 89;
			this.richInfoComprobante.Text = "";
			this.richInfoComprobante.TextChanged += new System.EventHandler(this.htmlRichTextBox1_TextChanged);
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
																							  this.tbbVerCtaCte,
																							  this.toolBarButton1,
																							  this.tbbImprimir,
																							  this.toolBarButton2,
																							  this.tbbImputar,
																							  this.toolBarButton3,
																							  this.tbbVerAsociaciones,
																							  this.toolBarButton5,
																							  this.tbbDesimputar,
																							  this.toolBarButton6,
																							  this.tbbAnular});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(904, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbImputar
			// 
			this.tbbImputar.Text = "Impu&tar";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbVerAsociaciones
			// 
			this.tbbVerAsociaciones.Enabled = false;
			this.tbbVerAsociaciones.Text = "&Ver Imputaciones";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbDesimputar
			// 
			this.tbbDesimputar.Enabled = false;
			this.tbbDesimputar.Text = "&Eliminar Imputacion";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbAnular
			// 
			this.tbbAnular.Enabled = false;
			this.tbbAnular.ImageIndex = 7;
			this.tbbAnular.Text = "&Anular";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 109;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtros";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 255;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Detalle";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup4.Settings.ContainerHeight = 216;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Contenido del Comprobante";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(904, 642);
			this.ultraExplorerBar1.TabIndex = 78;
			// 
			// FrmVisualizacionCuentaCorriente
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(904, 670);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmVisualizacionCuentaCorriente";
			this.Text = "Cuenta Corriente";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmVisualizacionCuentaCorriente_KeyDown);
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udteDesde)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udteHasta)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneSaldoPosterior)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneSaldoAnterior)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void MostrarDetalleCuentaCorriente()
		{
			if((string)mzCETitular.DataValue != "")
			{
				string IdCuenta =mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string)mzCETitular.DataValue);
				if (IdCuenta != "")
				{
					string clienteDePaso = Variables.GetValueString("Cuenta.ClienteDePaso.Default");
					string idClientePaso = mz.erp.businessrules.tsa_Cuentas.GetByCodigo(clienteDePaso).IdCuenta;
					if (IdCuenta.Equals(idClientePaso) && (_processName.Equals("ProcesoCuentaCorrienteClienteDV") || _processName.Equals("ProcesoCuentaCorrienteCliente")))
					{
						MessageBox.Show("El cliente no es correcto para la operación que desea realizar.");
					}
					else
					{
						//reviso las fechas
						DateTime desde = DateTime.MinValue;
						DateTime hasta = DateTime.MinValue;
						if (udteDesde.Value == null)
							MessageBox.Show("Debe seleccionar una Fecha","Fecha Invalida", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
						else desde = (DateTime)udteDesde.Value;
						if (udteHasta.Value == null)
							MessageBox.Show("Debe seleccionar una Fecha","Fecha Invalida", System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
						else hasta = (DateTime)udteHasta.Value;
			
						_ctaCte = Factory.GetCuentaCorriente(IdCuenta, desde, hasta, _orderBy);					
					
						this.uneSaldoAnterior.Value = _ctaCte.GetSaldoAnterior(this._processName);
						this.uneSaldoPosterior.Value = _ctaCte.GetSaldoPosterior(this._processName);
					
					
						//obtengo la los comprobantes pendientes o no segun corresponda
						if (cbSoloPendientes.Checked)
						{
							gridEX1.RootTable.Columns["SaldoAcumuladoSinSigno"].Visible= false;
							gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"].Visible= true;
							gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"].Width= 95;
							gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"].TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
							gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"].FormatString = "0.00";
							_ctaCte.GetDetalleCuentaCorrienteSoloPendientes(_processName);
						}
						else 
						{
							_ctaCte.GetDetalleCuentaCorriente(_processName);
							gridEX1.RootTable.Columns["SaldoAcumuladoSinSigno"].Visible= true;
							gridEX1.RootTable.Columns["SaldoAcumuladoSinSigno"].Width= 95;
							gridEX1.RootTable.Columns["SaldoAcumuladoSoloPendientesSinSigno"].Visible= false;
						}

					
						this.gridEX1.SelectionChanged -= new System.EventHandler(this.gridEX1_SelectionChanged);
						gridEX1.DataSource=_ctaCte.Detalle;
						this.gridEX1.SelectionChanged += new System.EventHandler(this.gridEX1_SelectionChanged);
					
						SetColoresSaldoAnteriorYPosterior();

						//habilita o no el boton imputar
						if(_ctaCte.Detalle.Count > 0)
						{
							this.tbbImputar.Enabled = true;
							this.gridEX1_SelectionChanged(this,new EventArgs());
						}
						else this.tbbImputar.Enabled = false;
						filtrarResultado();
					}
				}

				else MessageBox.Show("Debe seleccionar el titular de la Cuenta Corriente");
			}
			else
				MessageBox.Show("Debe seleccionar el titular de la Cuenta Corriente");
		}



		private void filtrarResultado()
		{
			if (rbSoloFacturas.Checked)
			{
				Janus.Windows.GridEX.GridEXColumn column = gridEX1.RootTable.Columns["Comprobante"];
				Janus.Windows.GridEX.ConditionOperator condicion = Janus.Windows.GridEX.ConditionOperator.BeginsWith;
				Janus.Windows.GridEX.GridEXFilterCondition filtro =new Janus.Windows.GridEX.GridEXFilterCondition(column, condicion, "Factura");
				gridEX1.RootTable.FilterCondition = filtro;
			}
			else
			{
				if (rbSoloNotasC.Checked)
				{
					Janus.Windows.GridEX.GridEXColumn column = gridEX1.RootTable.Columns["Comprobante"];
					Janus.Windows.GridEX.ConditionOperator condicion = Janus.Windows.GridEX.ConditionOperator.BeginsWith;
					Janus.Windows.GridEX.GridEXFilterCondition filtro =new Janus.Windows.GridEX.GridEXFilterCondition(column, condicion, "Nota de Crédito");
					gridEX1.RootTable.FilterCondition = filtro;
				}
				else
				{
					if (gridEX1.RootTable.FilterApplied != null )
						gridEX1.RootTable.FilterCondition = null;
				}
			}
		}



		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0://DetalleCtaCte
					MostrarDetalleCuentaCorriente();
					break;				
				case 2://Imprimir
					Imprimir();	
					break;
				
				case 4://Imputar
					
					ImputarComprobantes();

					break;
				case 6://Ver Asociaciones

					VerAsociaciones();
					break;
				case 8://Desimputar

					if(gridEX1.SelectedItems.Count > 0)
					{
						Desimputar();
						MostrarDetalleCuentaCorriente();
					}
					else
						MessageBox.Show("Debe seleccionar el comprobante a desimputar","Atencion",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
					break;
				case 10://Anular Recibo
					Anular();
					MostrarDetalleCuentaCorriente();
					break;

				default:
					break;
					
				
			}		
		}

	/*	private void Pagos()
		{
			FrmPagoCuentaCorriente frmpcc  ;
			if (_ctaCte!= null)
			{
				
				
				frmpcc= new FrmPagoCuentaCorriente(_ctaCte.IdCuenta);
				frmpcc.OnRowChanged += new FrmPagoCuentaCorriente.RowChanged(UpdateSelection);
			}
			else frmpcc = new FrmPagoCuentaCorriente();
			frmpcc.MdiParent = this.MdiParent;
			frmpcc.Show();

		}*/

		private void Imprimir()
		{
			/*
			if(gridEX1.SelectedItems.Count > 0 && gridEX1.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				string IdComprobante = Convert.ToString(gridEX1.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
				ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
			}
			*/
			if(this._ctaCte != null)
			{
				ReportsManager.PrintReportCuentaCorriente(this._ctaCte,this.MdiParent, this._processName, cbSoloPendientes.Checked, rbSoloFacturas.Checked, rbSoloNotasC.Checked);
			}
			else
				MessageBox.Show(this,"Debe seleccionar el detalle de la cuenta corriente","Advertencia",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
			
		}
			

		private void UpdateSelection(object sender, EventArgs e)
		{
			this.MostrarDetalleCuentaCorriente();
		}

		private void Anular()
		{
			if (tbbDesimputar.Enabled)
				MessageBox.Show("Debe desimputar el comprobante antes de anularlo");
			else
			{
				DetalleCuentaCorriente dcc = (DetalleCuentaCorriente)gridEX1.SelectedItems[0].GetRow().DataRow;
				CancelacionComprobanteDePago ccp = new CancelacionComprobanteDePago();
				ccp.Anular(dcc.IdComprobante);
				ccp.Commit();
				if(ccp.IsValid())
                    ccp.Flush();
			}
		}


		private void Desimputar()
		{
			
			DetalleCuentaCorriente dcc = (DetalleCuentaCorriente)gridEX1.SelectedItems[0].GetRow().DataRow;
			if (dcc.Desimputar())
				dcc.flushDesimputar();
		}

		private void ImputarComprobantes()
		{
			FrmAplicacionDePagos frmap;
			if (_ctaCte!= null)
			{
				if (gridEX1.SelectedItems.Count > 0)
				{
					DetalleCuentaCorriente dcc = (DetalleCuentaCorriente)gridEX1.SelectedItems[0].GetRow().DataRow;
					frmap = new FrmAplicacionDePagos(_ctaCte.IdCuenta,dcc, _processName);
				}
				else frmap = new FrmAplicacionDePagos(_ctaCte.IdCuenta,null,_processName);
				frmap.OnRowChanged += new FrmAplicacionDePagos.RowChanged(UpdateSelection);
			}
			else
			{
				frmap = new FrmAplicacionDePagos();
			}
			frmap.MdiParent = this.MdiParent;
			frmap.Show();
		}

		private void VerAsociaciones()
		{
			DetalleCuentaCorriente dcc = (DetalleCuentaCorriente)gridEX1.SelectedItems[0].GetRow().DataRow;
			FrmVerAsociaciones frmVA = new FrmVerAsociaciones(this._ctaCte,dcc, _processName);
			frmVA.MdiParent = this.MdiParent;
			frmVA.Show();
		}

	
		private void gridEX1_SelectionChanged(object sender, System.EventArgs e)
		{
			if (gridEX1.SelectedItems.Count > 0 )
			{
				DetalleCuentaCorriente dcc =(DetalleCuentaCorriente)gridEX1.SelectedItems[0].GetRow().DataRow;
			
				string VarCompImputar = Variables.GetValueString(_processName, "Imputar", "Comprobantes"); //Variables.GetValueString("Momentos.Imputar.Comprobantes");
				string VarCompDesimputar = Variables.GetValueString(_processName, "Desimputar", "Comprobantes"); //Variables.GetValueString("Momentos.Desimputar.Comprobantes");
				string VarCompAnulables = Variables.GetValueString(_processName, "Anular", "Comprobantes"); 

				ArrayList comprobantesImputar = mz.erp.systemframework.Util.Parse(VarCompImputar,",");
				ArrayList comprobantesDesimputar = mz.erp.systemframework.Util.Parse(VarCompDesimputar,",");
				ArrayList comprobantesAnulables = mz.erp.systemframework.Util.Parse(VarCompAnulables,",");
						
				bool anulado = dcc.EstaAnulado(_processName);
				tbbAnular.Enabled = comprobantesAnulables.Contains(dcc.IdTipoDeComprobante) && !anulado && dcc.ImporteSinSigno.Equals(dcc.SaldoSinSigno);
				//Si el saldo es 0 implica que el comprobante esta saldado
				
				if(dcc.Saldo == 0)
				{
					//Habilita o deshabilita sabiendo que el saldo es 0 y depndiendo si el comprobante seleccionado
					//pertence al momento imputar desimputar
					tbbDesimputar.Enabled = (comprobantesDesimputar.Contains(dcc.IdTipoDeComprobante)) && !anulado;
					tbbVerAsociaciones.Enabled =(comprobantesDesimputar.Contains(dcc.IdTipoDeComprobante)) && !anulado;
					tbbImputar.Enabled = false;


				}
					//El saldo es >0, por ende, puede que el comprobante este con imputaciones parciales
				else 
				{
					//Chequea que haya imputaciones parciales y que el tipo de comprobante puede estar en en 
					// momento inputar o desimputar
					tbbDesimputar.Enabled =((decimal.Round(dcc.Saldo,2) * dcc.Signo) < (decimal.Round(dcc.Importe,2) * dcc.Signo)) && (comprobantesDesimputar.Contains(dcc.IdTipoDeComprobante));
					tbbVerAsociaciones.Enabled =((decimal.Round(dcc.Saldo,2) * dcc.Signo) < (decimal.Round(dcc.Importe,2) * dcc.Signo)) && (comprobantesDesimputar.Contains(dcc.IdTipoDeComprobante));
					tbbImputar.Enabled = (comprobantesDesimputar.Contains(dcc.IdTipoDeComprobante)) && !anulado;
				}
				//mostrar datos del comprobante en la solapa de abajo
				VisualizarInfoDelComprobante();
			}
		}


		private void VisualizarInfoDelComprobante()
		{
			bool visualizaDetalle = Variables.GetValueBool("Momentos." + _processName + ".VisualizaDetalleComprobantes");
			string metodoVisualizacion = Variables.GetValueString("Momentos." + _processName + ".MetodoVisualizacionDetalle");
			bool VerHTML = false;
			if(visualizaDetalle && metodoVisualizacion.Equals("AUTOMATICO"))
				VerHTML = true;
			if(VerHTML)
			{
				/*string datos = string.Empty;
				if (gridEX1.SelectedItems.Count == 1 )
				{
					datos = Convert.ToString(this.gridEX1.SelectedItems[0].GetRow().Cells["TextoHTML"].Value);
					//				string idComprobante = Convert.ToString(this.gridEX1.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);					
				}		
				this.richInfoComprobante.Clear();
				this.richInfoComprobante.AddHTML(datos);*/
				if(gridEX1.SelectedItems.Count == 1 && gridEX1.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
				{
					string IdComprobante = Convert.ToString(gridEX1.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
					string IdTipoDeComprobante = Convert.ToString(gridEX1.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
					if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
					{
						this.richInfoComprobante.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
						this.richInfoComprobante.AddHTML(datos);
					}
					else this.richInfoComprobante.Clear();
					//ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
				}
			}
			else
				this.richInfoComprobante.Clear();
				
		}

	

		private void FrmVisualizacionCuentaCorriente_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.C)
			{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
						if(tbbVerCtaCte.Enabled)
							MostrarDetalleCuentaCorriente();
			}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.I)
				{
						if(e.Modifiers == System.Windows.Forms.Keys.Alt)
							if(tbbImprimir.Enabled)
                                Imprimir();
				}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.T)
				{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
						if(tbbImputar.Enabled)	
							ImputarComprobantes();
				}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.V)
				{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
						if(tbbVerAsociaciones.Enabled)
							VerAsociaciones();
				}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.E)
				{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
					{
						if(tbbDesimputar.Enabled)
						{
							Desimputar();
							MostrarDetalleCuentaCorriente();
						}
					}
				}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.A)
				{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
					{
						if(tbbAnular.Enabled)
						{
							Anular();
							MostrarDetalleCuentaCorriente();
						}
					}
				}
		
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
		
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
		
		}

		private void Detalles_Click(object sender, EventArgs e)
		{
			bool visualizaDetalle = Variables.GetValueBool("Momentos." + _processName + ".VisualizaDetalleComprobantes");
			string metodoVisualizacion = Variables.GetValueString("Momentos." + _processName + ".MetodoVisualizacionDetalle");
			bool VerHTML = false;
			if(visualizaDetalle && metodoVisualizacion.Equals("PORDEMANDA"))
				VerHTML = true;
			if(VerHTML)
			{
				if(gridEX1.SelectedItems.Count > 0 && gridEX1.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
				{
					string IdComprobante = Convert.ToString(gridEX1.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);
					string IdTipoDeComprobante = Convert.ToString(gridEX1.SelectedItems[0].GetRow().Cells["IdTipoDeComprobante"].Value);
					if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
					{
						this.richInfoComprobante.Clear();
						string datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
						this.richInfoComprobante.AddHTML(datos);
					}
					else this.richInfoComprobante.Clear();
					//ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
				}
			}
		}

		private void gridEX1_SortKeysChanged(object sender, EventArgs e)
		{
			
			string order = string.Empty;
			/*
			this._orderBy = "FechaEmision ASC";
			this.MostrarDetalleCuentaCorriente();
			gridEX1.RootTable.SortKeys.Clear();
			*/
			Janus.Windows.GridEX.GridEXSortKeyCollection collec = gridEX1.RootTable.SortKeys;
			if(IsValidKeys())
			{
				foreach (Janus.Windows.GridEX.GridEXSortKey elem in collec )
				{
					if (elem.SortOrder == Janus.Windows.GridEX.SortOrder.Descending)
						order = elem.Column.Key +" DESC";
					if (elem.SortOrder == Janus.Windows.GridEX.SortOrder.Ascending)
						order = elem.Column.Key +" ASC";
					this._orderBy= order;
				}
				this.MostrarDetalleCuentaCorriente();
			}
			else gridEX1.RootTable.SortKeys.Clear();
			
		}

		private bool IsValidKeys()
		{
			Janus.Windows.GridEX.GridEXSortKeyCollection collec = gridEX1.RootTable.SortKeys;
			ArrayList keys = new ArrayList();
			keys.Add("FechaEmision");
			keys.Add("FechaVencimiento");
			foreach (Janus.Windows.GridEX.GridEXSortKey elem in collec )
			{
				if(!keys.Contains(elem.Column.Key))
					return false;
			}
			return true;
		}

		private void htmlRichTextBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		
		private void SetColoresSaldoAnteriorYPosterior ()
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
			//fin de para hacer el color del saldo configurable
			
			//modifico el color del saldo anterior
			_ctaCte.GetSaldoAnterior(_processName);
			if(_ctaCte.SaldoAnterior >= 0)
				uneSaldoAnterior.Appearance.ForeColor = colorAcreedor;//Color.Black;
			else uneSaldoAnterior.Appearance.ForeColor = colorDeudor;//Color.Red;
			uneSaldoAnterior.Text=Convert.ToString( _ctaCte.SaldoAnteriorSinSigno);
					
			//modifico el colos del saldo posterior
			_ctaCte.GetSaldoPosterior(_processName); 
			if(_ctaCte.SaldoPosterior >= 0)
				uneSaldoPosterior.Appearance.ForeColor = colorAcreedor;//Color.Black;
			else uneSaldoPosterior.Appearance.ForeColor = colorDeudor;//Color.Red;
			uneSaldoPosterior.Text=Convert.ToString(_ctaCte.SaldoPosteriorSinSigno);
		}	
		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			// TODO: agregar la implementación FrmVisualizacionCuentaCorriente.processEventChange
		}

		#endregion
	}
}

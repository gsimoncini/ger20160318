using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


using mz.erp.commontypes.data;
using mz.erp.ui;
using mz.erp.ui.forms;
using Janus.Windows.GridEX;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;


using Infragistics.Win.UltraWinExplorerBar;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmPagoCuentaCorriente.
	/// </summary>
	public class FrmPagoCuentaCorriente : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbDelete;
		private System.ComponentModel.IContainer components;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbResponsableEmision;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoComprobante;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Janus.Windows.GridEX.GridEX gridCompAImputar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		private Infragistics.Win.Misc.UltraButton ubEliminar;
		private Infragistics.Win.Misc.UltraButton ubAgregar;
		private System.Windows.Forms.Label label1;
		private Janus.Windows.GridEX.GridEX gridEXValores;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta;
		private ComprobanteDePago _comprobante;
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalValores;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImputado;
		private System.Windows.Forms.ToolBarButton tbbGuardar;
		private System.Windows.Forms.TextBox txtNumero;
		private ArrayList _cotizaciones;

		public FrmPagoCuentaCorriente()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			InitializeMembers(null);

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}
		public FrmPagoCuentaCorriente(string IdCuenta)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			InitializeMembers(IdCuenta);

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		private void InitializeMembers(string IdCuenta)
		{
			
			string IdInstanciaCajaAbierta = mz.erp.businessrules.tfi_Cajas.GetInstanciaAbiertaDeCaja(Security.IdPersona,Variables.GetValueString("Cajas.Default"));
			if(IdInstanciaCajaAbierta != null && !IdInstanciaCajaAbierta.Equals(string.Empty))
			{
				mzCEInstanciasCaja.Value = IdInstanciaCajaAbierta;
				mzCEInstanciasCaja.FillFromDataSource(mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdUsuario).Pr_tfi_InstanciasCaja_GetByResponsable, "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
				System.Data.DataTable table = businessrules.tsy_TiposDeComprobantes.GetList(null,null,true,Constantes.SignoComporbanteDePago,null).tsy_TiposDeComprobantes;
				//	System.Data.DataView data = new System.Data.DataView(table,"signo = -1","",System.Data.DataViewRowState.OriginalRows);
				string comprobantesCuentaCorriente = Variables.GetValueString("Cuentas.CuentaCorriente.Comprobantes");
				table = this.FilterComprobantes(comprobantesCuentaCorriente,table );	

			
				mzCmbTipoComprobante.FillFromDataSource(table, "IdTipoDeComprobante","Descripcion",8,"ID","Descripcion","Descripcion");
				mzCmbResponsableEmision.SearchObject = typeof( mz.erp.ui.tsh_Personas );
	
				mzCmbCuenta.SearchObject = typeof( mz.erp.ui.tsa_Cuentas );
				
				mzCmbResponsableEmision.DataValue = mz.erp.businessrules.sy_Usuarios.GetByPk(Security.IdUsuario).IdPersona;
				mzCmbTipoComprobante.Value = Variables.GetValueString("Comprobantes.ComprobantesDePago.Default");
				cldFechaComprobante.Value = mz.erp.businessrules.Sistema.DateTime.Now;
				cldFechaComprobante.ReadOnly = true;
				gridCompAImputar.LayoutData = new mz.erp.ui.tsa_CuentaCorriente().GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota", "FechaVencimiento","Numero", "SaldoSinSigno","Signo","ImporteSinSigno","Pago"});
				Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridCompAImputar.RootTable.Columns["Signo"],
					Janus.Windows.GridEX.ConditionOperator.LessThan,
					0);
				fc.FormatStyle.ForeColor=System.Drawing.Color.Red;
				fc.TargetColumn = this.gridCompAImputar.RootTable.Columns["SaldoSinSigno"];
				this.gridCompAImputar.RootTable.FormatConditions.Add(fc);
			
				//Para el importe
				Janus.Windows.GridEX.GridEXFormatCondition fc1 = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridCompAImputar.RootTable.Columns["Signo"],
					Janus.Windows.GridEX.ConditionOperator.LessThan,
					0);
				fc1.FormatStyle.ForeColor=System.Drawing.Color.Red;
				fc1.TargetColumn = this.gridCompAImputar.RootTable.Columns["ImporteSinSigno"];
				this.gridCompAImputar.RootTable.FormatConditions.Add(fc1);

				mzCEInstanciasCaja.FillFromDataSource(mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdUsuario).Pr_tfi_InstanciasCaja_GetByResponsable, "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
				mzCEInstanciasCaja.Value = mz.erp.businessrules.tfi_Cajas.GetInstanciaAbiertaDeCaja(Security.IdPersona,Variables.GetValueString("Cajas.Default"));
				_comprobante = Factory.GetComprobanteDePago();
			
				_cotizaciones= new ArrayList();
				mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizaciones( _cotizaciones,_comprobante.IdMonedaCierre);
				gridEXValores.LayoutData = new mz.erp.ui.tfi_ValoresEx().GetLayoutValores();

				uneTotalValores.DataBindings.Add("Text", this._comprobante , "Total");

				MouseHelper mouseControler = new MouseHelper();
				mouseControler.Control = ultraExplorerBar1;
				mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
				mouseControler.WheelForward += new MouseEventHandler(ScrollUp);
				this.mzCmbCuenta.ValueChanged += new System.EventHandler(this.mzCmbCuenta_ValueChanged);
				if(IdCuenta != null && !IdCuenta.Equals(string.Empty))
					mzCmbCuenta.DataValue = mz.erp.businessrules.tsa_Cuentas.GetByPk(IdCuenta).Codigo;
			}
			else
			{
				DisableUI();
			}
			

		}

		private void DisableUI()
		{
			ultraExplorerBarContainerControl1.Enabled = false;
			ultraExplorerBarContainerControl5.Enabled = false;
			ultraExplorerBarContainerControl6.Enabled = false;
			ultraExplorerBar1.Groups[0].Text = "No hay Cajas Abiertas para el Usuario Actual. No se puede efectuar el pago";
			ultraExplorerBar1.Groups[1].Text = "No hay Cajas Abiertas para el Usuario Actual. No se puede efectuar el pago";
			ultraExplorerBar1.Groups[2].Text = "No hay Cajas Abiertas para el Usuario Actual. No se puede efectuar el pago";
			this.tbbGuardar.Visible = false;

		}

		private System.Data.DataTable FilterComprobantes(string comprobantesCuentaCorriente,System.Data.DataTable tableParam )
		{
			System.Data.DataTable table = new System.Data.DataTable();
			table.Columns.Add("IdTipoDeComprobante");
			table.Columns.Add("Descripcion");
			ArrayList aux = mz.erp.systemframework.Util.Parse(comprobantesCuentaCorriente,",");
			foreach(System.Data.DataRow row in tableParam.Rows)
			{
					if(aux.Contains(row["IdTipoDeComprobante"]))
						table.ImportRow(row);
				
			}

			return table;
		}
	
		private void ScrollDown (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);
		}

		private void ScrollUp (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageUp);
		}
		
		

		private void RefreshTotal(object comp)
		{
			this.uneTotalValores.Refresh();

		}

		private void RefreshTotalImputado(object comp)
		{
			this.uneTotalImputado.Refresh();

		}
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
			}
			base.Dispose( disposing );
		}
						
		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
							
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPagoCuentaCorriente));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbTipoComprobante = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.mzCmbResponsableEmision = new mz.erp.ui.controls.mzComboSearchEditor();
			this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ubEliminar = new Infragistics.Win.Misc.UltraButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ubAgregar = new Infragistics.Win.Misc.UltraButton();
			this.label1 = new System.Windows.Forms.Label();
			this.gridEXValores = new Janus.Windows.GridEX.GridEX();
			this.uneTotalValores = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridCompAImputar = new Janus.Windows.GridEX.GridEX();
			this.uneTotalImputado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label8 = new System.Windows.Forms.Label();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
			this.ultraExplorerBarContainerControl6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.txtNumero);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmbCuenta);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCEInstanciasCaja);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmbTipoComprobante);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.cldFechaComprobante);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmbResponsableEmision);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(815, 143);
			this.ultraExplorerBarContainerControl5.TabIndex = 6;
			// 
			// txtNumero
			// 
			this.txtNumero.Enabled = false;
			this.txtNumero.Location = new System.Drawing.Point(128, 23);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(240, 20);
			this.txtNumero.TabIndex = 1;
			this.txtNumero.Text = "";
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EditObject = null;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCuenta.HierarchicalSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(128, 69);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.SearchObject = null;
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(438, 22);
			this.mzCmbCuenta.TabIndex = 3;
			
			// 
			// mzCEInstanciasCaja
			// 
			this.mzCEInstanciasCaja.DataSource = null;
			this.mzCEInstanciasCaja.DisplayMember = "";
			this.mzCEInstanciasCaja.DisplayMemberCaption = "";
			this.mzCEInstanciasCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEInstanciasCaja.Location = new System.Drawing.Point(128, 116);
			this.mzCEInstanciasCaja.MaxItemsDisplay = 7;
			this.mzCEInstanciasCaja.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEInstanciasCaja.Name = "mzCEInstanciasCaja";
			this.mzCEInstanciasCaja.Size = new System.Drawing.Size(240, 21);
			this.mzCEInstanciasCaja.SorterMember = "";
			this.mzCEInstanciasCaja.TabIndex = 5;
			this.mzCEInstanciasCaja.ValueMember = "";
			this.mzCEInstanciasCaja.ValueMemberCaption = "";
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(0, 121);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel4.TabIndex = 27;
			this.ultraLabel4.Text = "Instancia de Caja";
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(0, 49);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel6.TabIndex = 26;
			this.ultraLabel6.Text = "Responsable Emisión";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(0, 73);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel1.TabIndex = 25;
			this.ultraLabel1.Text = "Cuenta";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(0, 1);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel3.TabIndex = 24;
			this.ultraLabel3.Text = "Fecha";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(0, 25);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel5.TabIndex = 23;
			this.ultraLabel5.Text = "Número";
			// 
			// mzCmbTipoComprobante
			// 
			this.mzCmbTipoComprobante.DataSource = null;
			this.mzCmbTipoComprobante.DisplayMember = "";
			this.mzCmbTipoComprobante.DisplayMemberCaption = "";
			this.mzCmbTipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTipoComprobante.Location = new System.Drawing.Point(128, 93);
			this.mzCmbTipoComprobante.MaxItemsDisplay = 7;
			this.mzCmbTipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTipoComprobante.Name = "mzCmbTipoComprobante";
			this.mzCmbTipoComprobante.Size = new System.Drawing.Size(240, 21);
			this.mzCmbTipoComprobante.SorterMember = "";
			this.mzCmbTipoComprobante.TabIndex = 4;
			this.mzCmbTipoComprobante.ValueMember = "";
			this.mzCmbTipoComprobante.ValueMemberCaption = "";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(0, 97);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel2.TabIndex = 22;
			this.ultraLabel2.Text = "Tipo de Comprobante";
			// 
			// cldFechaComprobante
			// 
			dateButton1.Caption = "Today";
			this.cldFechaComprobante.DateButtons.Add(dateButton1);
			this.cldFechaComprobante.Location = new System.Drawing.Point(128, 0);
			this.cldFechaComprobante.Name = "cldFechaComprobante";
			this.cldFechaComprobante.NonAutoSizeHeight = 23;
			this.cldFechaComprobante.Size = new System.Drawing.Size(240, 21);
			this.cldFechaComprobante.TabIndex = 0;
			this.cldFechaComprobante.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
			// 
			// mzCmbResponsableEmision
			// 
			this.mzCmbResponsableEmision.DataValue = "";
			this.mzCmbResponsableEmision.EditObject = null;
			this.mzCmbResponsableEmision.FastSearch = false;
			this.mzCmbResponsableEmision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbResponsableEmision.HierarchicalSearch = false;
			this.mzCmbResponsableEmision.Location = new System.Drawing.Point(128, 45);
			this.mzCmbResponsableEmision.Name = "mzCmbResponsableEmision";
			this.mzCmbResponsableEmision.SearchObject = null;
			this.mzCmbResponsableEmision.SearchObjectListener = null;
			this.mzCmbResponsableEmision.Size = new System.Drawing.Size(438, 22);
			this.mzCmbResponsableEmision.TabIndex = 2;
			// 
			// ultraExplorerBarContainerControl6
			// 
			this.ultraExplorerBarContainerControl6.Controls.Add(this.ubEliminar);
			this.ultraExplorerBarContainerControl6.Controls.Add(this.ubAgregar);
			this.ultraExplorerBarContainerControl6.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl6.Controls.Add(this.gridEXValores);
			this.ultraExplorerBarContainerControl6.Controls.Add(this.uneTotalValores);
			this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(28, 251);
			this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
			this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(815, 205);
			this.ultraExplorerBarContainerControl6.TabIndex = 8;
			// 
			// ubEliminar
			// 
			this.ubEliminar.ImageList = this.imglStandar;
			this.ubEliminar.Location = new System.Drawing.Point(104, 0);
			this.ubEliminar.Name = "ubEliminar";
			this.ubEliminar.Size = new System.Drawing.Size(96, 24);
			this.ubEliminar.TabIndex = 1;
			this.ubEliminar.Text = "&Eliminar";
			this.ubEliminar.Click += new System.EventHandler(this.ubEliminar_Click);
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ubAgregar
			// 
			this.ubAgregar.ImageList = this.imglStandar;
			this.ubAgregar.Location = new System.Drawing.Point(8, 0);
			this.ubAgregar.Name = "ubAgregar";
			this.ubAgregar.Size = new System.Drawing.Size(96, 24);
			this.ubAgregar.TabIndex = 0;
			this.ubAgregar.Text = "&Agregar";
			this.ubAgregar.Click += new System.EventHandler(this.ubAgregar_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(432, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 12);
			this.label1.TabIndex = 31;
			this.label1.Text = "Total";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gridEXValores
			// 
			this.gridEXValores.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEXValores.ContinuousScroll = false;
			this.gridEXValores.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEXValores.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEXValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridEXValores.GroupByBoxVisible = false;
			this.gridEXValores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEXValores.Location = new System.Drawing.Point(4, 32);
			this.gridEXValores.Name = "gridEXValores";
			this.gridEXValores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridEXValores.Size = new System.Drawing.Size(660, 160);
			this.gridEXValores.TabIndex = 2;
			this.gridEXValores.DoubleClick += new System.EventHandler(this.gridEXValores_DoubleClick);
			this.gridEXValores.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridEXValores_FormattingRow);
			// 
			// uneTotalValores
			// 
			this.uneTotalValores.Location = new System.Drawing.Point(568, 0);
			this.uneTotalValores.Name = "uneTotalValores";
			this.uneTotalValores.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalValores.Size = new System.Drawing.Size(96, 21);
			this.uneTotalValores.TabIndex = 11;
			this.uneTotalValores.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCompAImputar);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneTotalImputado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 515);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(815, 157);
			this.ultraExplorerBarContainerControl1.TabIndex = 7;
			// 
			// gridCompAImputar
			// 
			this.gridCompAImputar.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridCompAImputar.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCompAImputar.GroupByBoxVisible = false;
			this.gridCompAImputar.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCompAImputar.Location = new System.Drawing.Point(0, 0);
			this.gridCompAImputar.Name = "gridCompAImputar";
			this.gridCompAImputar.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCompAImputar.Size = new System.Drawing.Size(664, 128);
			this.gridCompAImputar.TabIndex = 0;
			this.gridCompAImputar.DoubleClick += new System.EventHandler(this.gridCompAImputar_DoubleClick);
			// 
			// uneTotalImputado
			// 
			this.uneTotalImputado.Location = new System.Drawing.Point(568, 132);
			this.uneTotalImputado.Name = "uneTotalImputado";
			this.uneTotalImputado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalImputado.Size = new System.Drawing.Size(96, 21);
			this.uneTotalImputado.TabIndex = 8;
			this.uneTotalImputado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(441, 136);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 16);
			this.label8.TabIndex = 32;
			this.label8.Text = "Total";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 143;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Informacion General";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl6;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 205;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Valores";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 157;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Comprobantes A Imputar";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1";
			this.ultraExplorerBar1.Size = new System.Drawing.Size(864, 718);
			this.ultraExplorerBar1.TabIndex = 19;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbGuardar});
			this.toolBarStandar.ButtonSize = new System.Drawing.Size(65, 22);
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(864, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbGuardar
			// 
			this.tbbGuardar.ImageIndex = 4;
			this.tbbGuardar.Text = "&Guardar";
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 4;
			this.toolBarButton8.Text = "Guardar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 7;
			this.tbDelete.Text = "Borrar";
			// 
			// FrmPagoCuentaCorriente
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(864, 746);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmPagoCuentaCorriente";
			this.Text = "Pagos en Cuenta Corriente";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPagoCuentaCorriente_KeyDown);
			this.Load += new System.EventHandler(this.FrmPagoCuentaCorriente_Load);
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
			this.ultraExplorerBarContainerControl6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmPagoCuentaCorriente_Load(object sender, System.EventArgs e)
		{
		
		}

		//Cada vez que se elige una cuenta de un cliente se traen comprobantes que se pueden llegar a imputar
		//con el recibo que esta por generar. Cabe aclarar que la grilla se filtra para que solo se muestren
		// aquellos comprobantes que tienen signo -1 en la tabla tsa_TiposDeComprobantes
		private void mzCmbCuenta_ValueChanged(object sender, System.EventArgs e)
		{
			if ((string ) mzCmbCuenta.DataValue != "")
			{
				string IdCuenta= mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string) mzCmbCuenta.DataValue);
				if(_comprobante == null || IdCuenta != _comprobante.IdCuenta)
				{
					_comprobante.CuentaCorriente = Factory.GetCuentaCorriente(IdCuenta, DateTime.MinValue, DateTime.MaxValue);
			
					_comprobante.CuentaCorriente.GetDetalleComprobantesAImputar();
					uneTotalImputado.DataBindings.Clear();
					uneTotalImputado.DataBindings.Add("Text", _comprobante.CuentaCorriente, "TotalImputado");

					gridCompAImputar.SetDataBinding(_comprobante.CuentaCorriente.Detalle, null);		
					gridCompAImputar.RootTable.Columns["Comprobante"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
					gridCompAImputar.RootTable.Columns["FechaVencimiento"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
					gridCompAImputar.RootTable.Columns["Numero"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
					gridCompAImputar.RootTable.Columns["SaldoSinSigno"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
					Janus.Windows.GridEX.GridEXFilterCondition filter1= new Janus.Windows.GridEX.GridEXFilterCondition();
					filter1.Column=gridCompAImputar.RootTable.Columns["Signo"];
					filter1.ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal;
					filter1.Value1 = -1;
				
					gridCompAImputar.RootTable.ApplyFilter(filter1);
				}
			}
			else
			{
				_comprobante = Factory.GetComprobanteDePago();
				gridCompAImputar.SetDataBinding(null, null);
				
			}
		}

		private void ubAgregar_Click(object sender, System.EventArgs e)
		{
			/*FrmAbmValores frmV = new FrmAbmValores(_comprobante.Valores.DataValoresEx);
			frmV.DataSetChange += new FrmAbmValores.DataSetChangeEventHandler( getDataSet );
			//frmV.MdiParent= this.ParentForm;
			frmV.ShowForm(null,"Valor en Pago de Cuenta Corriente de "+Convert.ToString(mzCmbCuenta.DisplayValue),"","");
		*/
		/*
			FrmValores form = new FrmValores(_uiController.GetValoresController(), _uiController);
			form.AddObjectListener(_uiController);
			form.ShowForm();
		*/
		}


		public void getDataSet(System.Data.DataSet data, Valor  valor)
		{
			try
			{
				
				_comprobante.RefreshValores(data, valor);
				gridEXValores.SetDataBinding(_comprobante.Valores.MisValores,null); 
				Janus.Windows.GridEX.GridEXColumnCollection col = gridEXValores.CurrentTable.Columns;
				col["IdMoneda"].HasValueList =true;
				col["IdMoneda"].EditType= Janus.Windows.GridEX.EditType.Combo;
				col["IdMoneda"].ValueList.PopulateValueList(mz.erp.businessrules.tfi_Monedas.GetList().tfi_Monedas,"IdMoneda","Descripcion");
				col["IdEntidad"].HasValueList= true;
				col["IdEntidad"].EditType= Janus.Windows.GridEX.EditType.Combo;
				col["IdEntidad"].ValueList.PopulateValueList(mz.erp.businessrules.tfi_Entidades.GetList().tfi_Entidades, "IdEntidad","Descripcion");
				col["Fecha"].EditType = Janus.Windows.GridEX.EditType.CalendarCombo;
				col["FechaVencimiento"].EditType= Janus.Windows.GridEX.EditType.CalendarCombo;
				col["IdTDCompTesoreria"].HasValueList =true;
				col["IdTDCompTesoreria"].EditType= Janus.Windows.GridEX.EditType.Combo;
				col["IdTDCompTesoreria"].ValueList.PopulateValueList(mz.erp.businessrules.tfi_TDCompTesoreria.GetList().tfi_TDCompTesoreria,"IdTDCompTesoreria","Descripcion");
			
			
		

				
				
			}
			catch(Exception e) {;}
			
			
		}

		private void ultraExplorerBarContainerControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void mzCmbResponsableEmision_Load(object sender, System.EventArgs e)
		{
		
		}

		private void mzCmbCuenta_Load(object sender, System.EventArgs e)
		{
		
		}

		private void gridEXValores_DoubleClick(object sender, System.EventArgs e)
		{

		
			gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			
	
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
						Save();
				
					break;
				default :
				break;
			}
		}


		private void Save()
		{
			if(_comprobante.CuentaCorriente.TotalImputado > _comprobante.Total)
				MessageBox.Show("El Monto del comprobante es menor que la imputacion asociada");
			else
			{
				DumpControls();
				_comprobante.Commit();
				_comprobante.Flush();
				Evaluate();
			}

		}

		private void DumpControls()
		{
		//Datos del comprobante
		
				
				if(mzCEInstanciasCaja.Value == null)
					_comprobante.IdInstanciaCaja ="";
				else
					_comprobante.IdInstanciaCaja =(string) mzCEInstanciasCaja.Value;

				_comprobante.IdCuenta =  mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string)mzCmbCuenta.DataValue);
				_comprobante.Numero = txtNumero.Text;
				_comprobante.FechaComprobante= mz.erp.businessrules.Sistema.DateTime.Now;
				_comprobante.TipoComprobanteDestino = (string)mzCmbTipoComprobante.Value;
				_comprobante.Signo = Convert.ToInt32(mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(_comprobante.TipoComprobanteDestino).signo);
				_comprobante.IdResponsable = (string)mzCmbResponsableEmision.DataValue;
				_comprobante.Saldo= _comprobante.Total;
				_comprobante.CondicionDeVenta = new CondicionDeVenta("NEW",_comprobante,Variables.GetValueString("Comprobantes.FormaDePago.Contado"));
			
			
		
	


		}
		public delegate void RowChanged( object sender, EventArgs args );
		public event RowChanged OnRowChanged;

	/*	protected void Evaluate()
		{			
			if (_comprobante.DatasetComprobante.HasErrors)
			{
				DatasetErrors errores = new DatasetErrors( _comprobante.DatasetComprobante);
				FrmShowRowError _form = new FrmShowRowError( _comprobante.DatasetComprobante );
				_form.Show();
				//_comprobante.DatasetComprobante = null;
			}
			else
			{
				MessageBox.Show("La acción se ha ejecutado con éxito");
				this.Close();
			}
		}*/

		protected void Evaluate()
		{			
			bool hasErrors=false;
			foreach (System.Data.DataTable table in this._comprobante.DatasetComprobante.Tables)
				foreach (System.Data.DataRow row in table.Rows)
				{

					if (row.HasErrors)
					{
						hasErrors=true;
						FrmShowRowError _form = new FrmShowRowError(row);
						_form.Show();
						row.ClearErrors();						
					}
					/*else 
					{						
						ui.Impresion.ImprimirReciboFiscal(_comprobante);
					}*/

					
				}
			if (hasErrors)this._comprobante.DatasetComprobante.RejectChanges();
			
			if (!hasErrors)
			{
				MessageBox.Show("La acción se ha ejecutado con éxito");
				if ( OnRowChanged != null )
				{
					OnRowChanged( this, null );
				}
				Close();
			}
		}

		private void gridCompAImputar_DoubleClick(object sender, System.EventArgs e)
		{
			//if (gridCompAImputar.CurrentColumn.Key.Equals("Saldo"))
			//{
				DetalleCuentaCorriente dcc = (DetalleCuentaCorriente) gridCompAImputar.GetRow().DataRow;
				dcc.Pago = dcc.Saldo*dcc.Signo;
				gridCompAImputar.Refetch();
			//}
		}
		

		private void ubEliminar_Click(object sender, System.EventArgs e)
		{
			if (gridEXValores.SelectedItems.Count > 0)
			{
				int posicion  = gridEXValores.SelectedItems[0].Position;
		//		_comprobante.Valores.EliminarValor(posicion);
				gridEXValores.Delete();
				gridEXValores.Refresh();
				
				_comprobante.Recalcular();
				
					
					
			}
		}

		private void gridEXValores_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}

		private void FrmPagoCuentaCorriente_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.G)
				{	if(e.Modifiers == System.Windows.Forms.Keys.Alt)
						Save();
				}
		}


			
		
		




	}
}

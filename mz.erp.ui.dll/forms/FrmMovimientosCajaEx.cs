using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes.data;
using Janus.Windows.GridEX;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	public class FrmMovimientosCajaEx : mz.erp.ui.forms.FrmABMEx
	{ 
		private Janus.Windows.GridEX.GridEX gridEXFormasDePago;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposMovimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo ultraCalendarCombo1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridEXValores;
		private System.ComponentModel.IContainer components = null;
		private mz.erp.ui.forms.classes.tfi_MovimientosDeCajaEx _sourceUI;
		private System.Windows.Forms.Label label1;


		private System.Data.DataSet _dataValoresEx;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Janus.Windows.GridEX.GridEX gridExCotizaciones;
		private System.Windows.Forms.ImageList imglStandar;
		private Infragistics.Win.Misc.UltraButton ubAgregar;
		private Infragistics.Win.Misc.UltraButton ubEliminar;	
		
		private ArrayList _cotizaciones;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private System.Windows.Forms.Label label2;
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private System.Windows.Forms.TextBox txtObservaciones;
		
		private MovimientoDeCaja _movimiento;
		private string _idTipoDeMovimiento = string.Empty;
		private string _idSubTipoMovimiento = string.Empty;
		private string _numero = string.Empty;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTiposMovimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit txtNumero;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoComp;
		private string _signo  = string.Empty;

		
		public FrmMovimientosCajaEx(string signo)
		{
			InitializeComponent();
			_signo = signo;
		}




		#region Custom Members

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tfi_MovimientosDeCajaEx().GetType();
			base.Init();
		}
		
		
		protected override void  InitializeMembers()
		{
			_sourceUI= new mz.erp.ui.forms.classes.tfi_MovimientosDeCajaEx();
			//mzCmbTiposMovimiento.FillFromDataSource( businessrules.tsy_TiposMovimientos.GetList().tsy_TiposMovimientos, "IdTipoMovimiento","Descripcion",8,"ID","Descripcion","Descripcion");
			_dataValoresEx = new tfi_ValoresExDataset();
			_movimiento= Factory.GetMovimiento(Variables.GetValueString("Contabilidad.MonedaReferencia"));

			_cotizaciones= new ArrayList();
			mzCEInstanciasCaja.FillFromDataSource(mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdPersona).Tables[0], "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
			mzCEInstanciasCaja.SelectedIndex = 0 ;

			gridExCotizaciones.LayoutData= new mz.erp.ui.forms.classes.tfi_CotizacionesMonedas().GetLayoutCotizaciones();
					
			gridExCotizaciones.DataSource =mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizaciones( _cotizaciones,_movimiento.IdMonedaCierre).Tables[0];

			uneTotal.DataBindings.Add("Text", this._movimiento , "Total");
			
			tsy_TiposMovimientosDataset tipos = mz.erp.businessrules.tsy_TiposMovimientos.GetListPorSigno(_signo);
			this.mzCmbTiposMovimiento.FillFromDataSource(tipos.tsy_TiposMovimientos, "IdTipoMovimiento","Descripcion",100,"Descripcion");
			this.mzCmbTiposMovimiento.Value = tipos.tsy_TiposMovimientos[0]["IdTipoMovimiento"];
			this.mzCmbTiposMovimiento.ReadOnly = false;
			/*sy_UsuariosDataset usuarios=mz.erp.businessrules.sy_Usuarios.GetList();
			this.mzComboUsuario.FillFromDataSource(usuarios.sy_Usuarios,"IdUsuario","Nombre",100,"Nombre");
			this.mzComboUsuario.Value=usuarios.sy_Usuarios[0].IdUsuario;*/
			this.mzCmbTipoComp.Value = "Fact.A";
		}



		protected override void FillControls()
		{
			if (_data != null)
			{
				try
				{
					tfi_MovimientosDeCajaExDataset data = (tfi_MovimientosDeCajaExDataset) _data;
					tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaDataTable tabla = data.tfi_MovimientosDeCaja;
					tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow row = (tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow) tabla.Rows[0];
					ultraCalendarCombo1.Value =(object)row.Fecha;
					//mzCmbTiposMovimiento.Value = row.IdTipoDeMovimiento; 
					uneTotal.Value = row.Total;
					txtObservaciones.Text = row.Observaciones;
					//mzCmbTiposMovimiento.Value = _movimiento.IdTipoMovimiento;

					gridEXFormasDePago.LayoutData =  _sourceUI.GetLayoutComprobantesTesoreria();
					_data = mz.erp.businessrules.tfi_MovimientosDeCajaEx.GetComprobantesTesoreria(_data);
					gridEXFormasDePago.DataSource= _data.Tables["Pr_tfi_GetComprobantesTesoreria"];
					gridEXValores.LayoutData = new mz.erp.ui.forms.classes.tfi_ValoresEx().GetLayoutValores();

					if(mzCEInstanciasCaja.DataSource.Rows.Count == 0)
					{
						//tbGuardar.Enabled = false;
						
						ultraExplorerBar1.Groups[0].Text ="No Hay Cajas Abiertas";
						ultraExplorerBar1.Groups[1].Text ="No Hay Cajas Abiertas";
						ultraExplorerBar1.Groups[0].Expanded = false;
						ultraExplorerBar1.Groups[1].Expanded = false;
						ultraExplorerBar1.Groups[0].Enabled = false;
						ultraExplorerBar1.Groups[1].Enabled = false;
					}
				}
				catch(Exception e){;}
			}
			//mzComboUsuario.FillFromDataSource(_uiController.Usuarios,_uiController.KeyValueUsuarios,_uiController.KeyListUsuarios,100,_uiController.KeyListUsuarios );
		}
		
		protected override void DumpControls()
		{
			_movimiento.IdTipoMovimiento=(string) mzCmbTiposMovimiento.Value;
			_movimiento.IdSubTipoMovimiento=(string) mzCmbSubTiposMovimiento.Value;
			
			_movimiento.Numero = (string) txtNumero.Text;			

			System.Data.DataRow RowTipoMov = mz.erp.businessrules.tsy_TiposMovimientos.GetByPk(_movimiento.IdTipoMovimiento);
			_movimiento.Signo= Convert.ToInt32( RowTipoMov["Signo"]);
			
			_movimiento.Fecha = (DateTime)ultraCalendarCombo1.Value;
			_movimiento.IdInstanciaDeCaja=(string) mzCEInstanciasCaja.Value;
			_movimiento.Observaciones = txtObservaciones.Text;
		}



		#endregion


		private void gridEXFormasDePago_DoubleClick(object sender, System.EventArgs e)
		{
			string IdTDCompTesoreria = (string)this.gridEXFormasDePago.SelectedItems[0].GetRow().Cells["IdTDCompTesoreria"].Value;
			string IdMoneda = "";
			string comprobante= (string)this.gridEXFormasDePago.SelectedItems[0].GetRow().Cells["Descripcion"].Value;
			bool Agrupado =(bool)this.gridEXFormasDePago.SelectedItems[0].GetRow().Cells["Agrupado"].Value;
			if (Agrupado)
			//Si esta agrupado --> IdTDCompTesoreria #IdMoneda
			{
				string aux= IdTDCompTesoreria;
				IdTDCompTesoreria= aux.Substring(0,aux.IndexOf("#"));
				IdMoneda= aux.Substring(aux.IndexOf("#") + 1);
			}
			
			FrmAbmValores frmV = new FrmAbmValores(_dataValoresEx);
			frmV.DataSetChange += new FrmAbmValores.DataSetChangeEventHandler( getDataSet );
			frmV.MdiParent= this.ParentForm;
			
			frmV.ShowForm(null,"Agregar Valor",IdTDCompTesoreria,IdMoneda);
				
				
		
		}

		public void getDataSet(System.Data.DataSet data, Valor  valor)
		{
			try
			{
				_dataValoresEx= data;
				valor.Recalcular();
				_movimiento.AddValor(valor);
				gridEXValores.SetDataBinding(_movimiento.Valores,null); 
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
			
				_movimiento.Recalcular();
				
			}
			catch(Exception e) {;}
			
			
		}
		private void gridEXValores_DoubleClick(object sender, System.EventArgs e)
		{
			/*string IdTDCompTesoreria = (string)this.gridEXValores.SelectedItems[0].GetRow().Cells["IdTDCompTesoreria"].Value;
			string IdMoneda = (string)this.gridEXValores.SelectedItems[0].GetRow().Cells["IdMoneda"].Value;
			string IdValor= (string)this.gridEXValores.SelectedItems[0].GetRow().Cells["IdValor"].Value;
			FrmAbmValores frmV = new FrmAbmValores(_dataValoresEx);
			frmV.DataSetChange += new FrmAbmValores.DataSetChangeEventHandler( getDataSet );
			frmV.MdiParent= this.ParentForm;
			frmV.ShowForm(IdValor,"Agregar Valor",IdTDCompTesoreria,IdMoneda);*/
		
			gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			
			
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

		#region Diseñador
								private void InitializeComponent()
																				{
									this.components = new System.ComponentModel.Container();
									Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
									System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmMovimientosCajaEx));
									Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
									Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
									Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
									Infragistics.Win.ValueListItem valueListItem1 = new Infragistics.Win.ValueListItem();
									Infragistics.Win.ValueListItem valueListItem2 = new Infragistics.Win.ValueListItem();
									Infragistics.Win.ValueListItem valueListItem3 = new Infragistics.Win.ValueListItem();
									Infragistics.Win.ValueListItem valueListItem4 = new Infragistics.Win.ValueListItem();
									Infragistics.Win.ValueListItem valueListItem5 = new Infragistics.Win.ValueListItem();
									this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
									this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
									this.ubEliminar = new Infragistics.Win.Misc.UltraButton();
									this.imglStandar = new System.Windows.Forms.ImageList(this.components);
									this.ubAgregar = new Infragistics.Win.Misc.UltraButton();
									this.label1 = new System.Windows.Forms.Label();
									this.gridEXValores = new Janus.Windows.GridEX.GridEX();
									this.gridEXFormasDePago = new Janus.Windows.GridEX.GridEX();
									this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
									this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
									this.mzCmbTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
									this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
									this.ultraCalendarCombo1 = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
									this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
									this.gridExCotizaciones = new Janus.Windows.GridEX.GridEX();
									this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
									this.label2 = new System.Windows.Forms.Label();
									this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
									this.txtObservaciones = new System.Windows.Forms.TextBox();
									this.mzCmbSubTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
									this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
									this.txtNumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
									this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
									this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
									this.mzCmbTipoComp = new mz.erp.ui.controls.mzComboEditor();
									((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
									this.ultraExplorerBar1.SuspendLayout();
									this.ultraExplorerBarContainerControl1.SuspendLayout();
									this.ultraExplorerBarContainerControl2.SuspendLayout();
									((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.gridEXFormasDePago)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.gridExCotizaciones)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).BeginInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComp)).BeginInit();
									this.SuspendLayout();
									// 
									// toolBarStandar
									// 
									this.toolBarStandar.Name = "toolBarStandar";
									this.toolBarStandar.Size = new System.Drawing.Size(864, 28);
									// 
									// ultraExplorerBar1
									// 
									this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
									ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
									ultraExplorerBarGroup1.Settings.ContainerHeight = 240;
									ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
									ultraExplorerBarGroup1.Text = "Detalle de Valores";
									this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																																				ultraExplorerBarGroup1});
									this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
									this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
									this.ultraExplorerBar1.Margins.ForceSerialization = true;
									this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
									this.ultraExplorerBar1.Size = new System.Drawing.Size(864, 454);
									this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
									this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
									// 
									// ultraExplorerBarContainerControl1
									// 
									this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTipoComp);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumero);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel7);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel8);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSubTiposMovimiento);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.txtObservaciones);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEInstanciasCaja);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.gridExCotizaciones);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.gridEXFormasDePago);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposMovimiento);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
									this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraCalendarCombo1);
									this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -21);
									this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
									this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(798, 151);
									this.ultraExplorerBarContainerControl1.TabStop = false;
									// 
									// ultraExplorerBarContainerControl2
									// 
									this.ultraExplorerBarContainerControl2.Controls.Add(this.uneTotal);
									this.ultraExplorerBarContainerControl2.Controls.Add(this.ubEliminar);
									this.ultraExplorerBarContainerControl2.Controls.Add(this.ubAgregar);
									this.ultraExplorerBarContainerControl2.Controls.Add(this.label1);
									this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEXValores);
									this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 189);
									this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
									this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(798, 240);
									this.ultraExplorerBarContainerControl2.TabIndex = 1;
									// 
									// uneTotal
									// 
									this.uneTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
									this.uneTotal.Location = new System.Drawing.Point(671, 8);
									this.uneTotal.MaskInput = "{LOC}nnnnnnn.nn";
									this.uneTotal.Name = "uneTotal";
									this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
									this.uneTotal.Size = new System.Drawing.Size(96, 21);
									this.uneTotal.TabIndex = 2;
									this.uneTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
									// 
									// ubEliminar
									// 
									this.ubEliminar.ImageList = this.imglStandar;
									this.ubEliminar.Location = new System.Drawing.Point(111, 8);
									this.ubEliminar.Name = "ubEliminar";
									this.ubEliminar.Size = new System.Drawing.Size(97, 24);
									this.ubEliminar.TabIndex = 1;
									this.ubEliminar.Text = "Eliminar";
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
									this.ubAgregar.Location = new System.Drawing.Point(8, 8);
									this.ubAgregar.Name = "ubAgregar";
									this.ubAgregar.Size = new System.Drawing.Size(96, 24);
									this.ubAgregar.TabIndex = 0;
									this.ubAgregar.Text = "Agregar";
									this.ubAgregar.Click += new System.EventHandler(this.ubAgregar_Click);
									// 
									// label1
									// 
									this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
									this.label1.BackColor = System.Drawing.Color.Transparent;
									this.label1.Location = new System.Drawing.Point(565, 10);
									this.label1.Name = "label1";
									this.label1.Size = new System.Drawing.Size(104, 16);
									this.label1.TabIndex = 17;
									this.label1.Text = "Total: ";
									this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
									this.gridEXValores.Location = new System.Drawing.Point(0, 40);
									this.gridEXValores.Name = "gridEXValores";
									this.gridEXValores.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
									this.gridEXValores.Size = new System.Drawing.Size(768, 192);
									this.gridEXValores.TabIndex = 3;
									this.gridEXValores.RecordsDeleted += new System.EventHandler(this.gridEXValores_RecordsDeleted);
									this.gridEXValores.DoubleClick += new System.EventHandler(this.gridEXValores_DoubleClick);
									// 
									// gridEXFormasDePago
									// 
									this.gridEXFormasDePago.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
									this.gridEXFormasDePago.Cursor = System.Windows.Forms.Cursors.Default;
									this.gridEXFormasDePago.GroupByBoxVisible = false;
									this.gridEXFormasDePago.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
									this.gridEXFormasDePago.Location = new System.Drawing.Point(760, 0);
									this.gridEXFormasDePago.Name = "gridEXFormasDePago";
									this.gridEXFormasDePago.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
									this.gridEXFormasDePago.Size = new System.Drawing.Size(256, 56);
									this.gridEXFormasDePago.TabIndex = 3;
									this.gridEXFormasDePago.Visible = false;
									this.gridEXFormasDePago.DoubleClick += new System.EventHandler(this.gridEXFormasDePago_DoubleClick);
									// 
									// ultraLabel1
									// 
									this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel1.Location = new System.Drawing.Point(752, 8);
									this.ultraLabel1.Name = "ultraLabel1";
									this.ultraLabel1.Size = new System.Drawing.Size(96, 24);
									this.ultraLabel1.TabIndex = 19;
									this.ultraLabel1.Text = "Formas De Pago";
									this.ultraLabel1.Visible = false;
									// 
									// ultraLabel3
									// 
									this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel3.Location = new System.Drawing.Point(0, 25);
									this.ultraLabel3.Name = "ultraLabel3";
									this.ultraLabel3.Size = new System.Drawing.Size(62, 16);
									this.ultraLabel3.TabIndex = 18;
									this.ultraLabel3.Text = "Fecha";
									// 
									// mzCmbTiposMovimiento
									// 
									this.mzCmbTiposMovimiento.AutoComplete = true;
									this.mzCmbTiposMovimiento.DataSource = null;
									this.mzCmbTiposMovimiento.DisplayMember = "";
									this.mzCmbTiposMovimiento.DisplayMemberCaption = "";
									this.mzCmbTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
									this.mzCmbTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
									this.mzCmbTiposMovimiento.Location = new System.Drawing.Point(120, 46);
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
									// ultraLabel2
									// 
									this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel2.Location = new System.Drawing.Point(-1, 48);
									this.ultraLabel2.Name = "ultraLabel2";
									this.ultraLabel2.Size = new System.Drawing.Size(120, 16);
									this.ultraLabel2.TabIndex = 16;
									this.ultraLabel2.Text = "Tipo de Movimiento";
									// 
									// ultraCalendarCombo1
									// 
									dateButton1.Caption = "Today";
									this.ultraCalendarCombo1.DateButtons.Add(dateButton1);
									this.ultraCalendarCombo1.Enabled = false;
									this.ultraCalendarCombo1.Location = new System.Drawing.Point(120, 23);
									this.ultraCalendarCombo1.Name = "ultraCalendarCombo1";
									this.ultraCalendarCombo1.NonAutoSizeHeight = 23;
									this.ultraCalendarCombo1.Size = new System.Drawing.Size(272, 21);
									this.ultraCalendarCombo1.TabIndex = 1;
									this.ultraCalendarCombo1.Value = new System.DateTime(2006, 3, 20, 13, 44, 15, 429);
									// 
									// ultraLabel4
									// 
									this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel4.Location = new System.Drawing.Point(752, 24);
									this.ultraLabel4.Name = "ultraLabel4";
									this.ultraLabel4.Size = new System.Drawing.Size(128, 16);
									this.ultraLabel4.TabIndex = 21;
									this.ultraLabel4.Text = "Cotizaciones Actuales";
									this.ultraLabel4.Visible = false;
									// 
									// gridExCotizaciones
									// 
									this.gridExCotizaciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
									this.gridExCotizaciones.Cursor = System.Windows.Forms.Cursors.Default;
									this.gridExCotizaciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
									this.gridExCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
									this.gridExCotizaciones.GroupByBoxVisible = false;
									this.gridExCotizaciones.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
									this.gridExCotizaciones.Location = new System.Drawing.Point(760, 0);
									this.gridExCotizaciones.Name = "gridExCotizaciones";
									this.gridExCotizaciones.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
									this.gridExCotizaciones.Size = new System.Drawing.Size(376, 48);
									this.gridExCotizaciones.TabIndex = 5;
									this.gridExCotizaciones.Visible = false;
									// 
									// mzCEInstanciasCaja
									// 
									this.mzCEInstanciasCaja.AutoComplete = true;
									this.mzCEInstanciasCaja.DataSource = null;
									this.mzCEInstanciasCaja.DisplayMember = "";
									this.mzCEInstanciasCaja.DisplayMemberCaption = "";
									this.mzCEInstanciasCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
									this.mzCEInstanciasCaja.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
									this.mzCEInstanciasCaja.Location = new System.Drawing.Point(120, 0);
									this.mzCEInstanciasCaja.MaxItemsDisplay = 7;
									this.mzCEInstanciasCaja.MoreItemsDisplayText = "(Ver mas elementos...)";
									this.mzCEInstanciasCaja.Name = "mzCEInstanciasCaja";
									this.mzCEInstanciasCaja.Size = new System.Drawing.Size(272, 21);
									this.mzCEInstanciasCaja.SorterMember = "";
									this.mzCEInstanciasCaja.TabIndex = 0;
									this.mzCEInstanciasCaja.ValueMember = "";
									this.mzCEInstanciasCaja.ValueMemberCaption = "";
									// 
									// label2
									// 
									this.label2.BackColor = System.Drawing.Color.Transparent;
									this.label2.Location = new System.Drawing.Point(0, 2);
									this.label2.Name = "label2";
									this.label2.Size = new System.Drawing.Size(64, 16);
									this.label2.TabIndex = 24;
									this.label2.Text = "Caja :";
									// 
									// ultraLabel5
									// 
									this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel5.Location = new System.Drawing.Point(0, 93);
									this.ultraLabel5.Name = "ultraLabel5";
									this.ultraLabel5.Size = new System.Drawing.Size(120, 16);
									this.ultraLabel5.TabIndex = 25;
									this.ultraLabel5.Text = "Observaciones";
									// 
									// txtObservaciones
									// 
									this.txtObservaciones.Location = new System.Drawing.Point(120, 93);
									this.txtObservaciones.Multiline = true;
									this.txtObservaciones.Name = "txtObservaciones";
									this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
									this.txtObservaciones.Size = new System.Drawing.Size(472, 51);
									this.txtObservaciones.TabIndex = 4;
									this.txtObservaciones.Text = "TEXTBOX3";
									this.txtObservaciones.TextChanged += new System.EventHandler(this.txtObservaciones_TextChanged);
									// 
									// mzCmbSubTiposMovimiento
									// 
									this.mzCmbSubTiposMovimiento.AutoComplete = true;
									this.mzCmbSubTiposMovimiento.DataSource = null;
									this.mzCmbSubTiposMovimiento.DisplayMember = "";
									this.mzCmbSubTiposMovimiento.DisplayMemberCaption = "";
									this.mzCmbSubTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
									this.mzCmbSubTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
									this.mzCmbSubTiposMovimiento.Location = new System.Drawing.Point(120, 69);
									this.mzCmbSubTiposMovimiento.MaxItemsDisplay = 7;
									this.mzCmbSubTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
									this.mzCmbSubTiposMovimiento.Name = "mzCmbSubTiposMovimiento";
									this.mzCmbSubTiposMovimiento.Size = new System.Drawing.Size(272, 21);
									this.mzCmbSubTiposMovimiento.SorterMember = "";
									this.mzCmbSubTiposMovimiento.TabIndex = 3;
									this.mzCmbSubTiposMovimiento.ValueMember = "";
									this.mzCmbSubTiposMovimiento.ValueMemberCaption = "";
									// 
									// ultraLabel6
									// 
									this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel6.Location = new System.Drawing.Point(0, 71);
									this.ultraLabel6.Name = "ultraLabel6";
									this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
									this.ultraLabel6.TabIndex = 28;
									this.ultraLabel6.Text = "Sub-Tipo de Movim.";
									// 
									// txtNumero
									// 
									this.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
									this.txtNumero.InputMask = "\\A-####-########";
									this.txtNumero.Location = new System.Drawing.Point(576, 24);
									this.txtNumero.Name = "txtNumero";
									this.txtNumero.TabIndex = 6;
									this.txtNumero.Text = "A--";
									// 
									// ultraLabel7
									// 
									appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
									this.ultraLabel7.Appearance = appearance1;
									this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel7.Location = new System.Drawing.Point(448, 8);
									this.ultraLabel7.Name = "ultraLabel7";
									this.ultraLabel7.Size = new System.Drawing.Size(116, 16);
									this.ultraLabel7.TabIndex = 35;
									this.ultraLabel7.Text = "Tipo de Comprobante";
									// 
									// ultraLabel8
									// 
									appearance2.TextHAlign = Infragistics.Win.HAlign.Right;
									this.ultraLabel8.Appearance = appearance2;
									this.ultraLabel8.BackColor = System.Drawing.Color.Transparent;
									this.ultraLabel8.Location = new System.Drawing.Point(504, 32);
									this.ultraLabel8.Name = "ultraLabel8";
									this.ultraLabel8.Size = new System.Drawing.Size(62, 11);
									this.ultraLabel8.TabIndex = 34;
									this.ultraLabel8.Text = "Número";
									// 
									// mzCmbTipoComp
									// 
									this.mzCmbTipoComp.AutoComplete = true;
									this.mzCmbTipoComp.DataSource = null;
									this.mzCmbTipoComp.DisplayMember = "";
									this.mzCmbTipoComp.DisplayMemberCaption = "";
									this.mzCmbTipoComp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
									this.mzCmbTipoComp.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
									valueListItem1.DataValue = "Fact.A";
									valueListItem1.DisplayText = "Fact. A";
									valueListItem2.DataValue = "Fact.B";
									valueListItem2.DisplayText = "Fact. B";
									valueListItem3.DataValue = "Fact.C";
									valueListItem3.DisplayText = "Fact. C";
									valueListItem4.DataValue = "Ticket";
									valueListItem4.DisplayText = "Ticket";
									valueListItem5.DataValue = "No";
									valueListItem5.DisplayText = "No/I";
									this.mzCmbTipoComp.Items.Add(valueListItem1);
									this.mzCmbTipoComp.Items.Add(valueListItem2);
									this.mzCmbTipoComp.Items.Add(valueListItem3);
									this.mzCmbTipoComp.Items.Add(valueListItem4);
									this.mzCmbTipoComp.Items.Add(valueListItem5);
									this.mzCmbTipoComp.Location = new System.Drawing.Point(576, 0);
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
									// FrmMovimientosCajaEx
									// 
									this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
									this.ClientSize = new System.Drawing.Size(864, 482);
									this.Name = "FrmMovimientosCajaEx";
									this.Text = "Movimiento de Caja";
									((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
									this.ultraExplorerBar1.ResumeLayout(false);
									this.ultraExplorerBarContainerControl1.ResumeLayout(false);
									this.ultraExplorerBarContainerControl2.ResumeLayout(false);
									((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.gridEXFormasDePago)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.ultraCalendarCombo1)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.gridExCotizaciones)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).EndInit();
									((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComp)).EndInit();
									this.ResumeLayout(false);

								}
		#endregion

		private void ubAgregar_Click(object sender, System.EventArgs e)
		{
			FrmAbmValores frmV = new FrmAbmValores(_dataValoresEx);
			frmV.DataSetChange += new FrmAbmValores.DataSetChangeEventHandler( getDataSet );
			frmV.MdiParent= this.ParentForm;
			frmV.ShowForm(null,"Agregar Valor","","");
						
		}

		private void ubEliminar_Click(object sender, System.EventArgs e)
		{
			if (gridEXValores.SelectedItems.Count > 0)
			{
					int posicion  = gridEXValores.SelectedItems[0].Position;
					Valor valor = (Valor) gridEXValores.SelectedItems[0].GetRow().DataRow;
					valor.DeleteFormDataSet((tfi_ValoresExDataset)this._dataValoresEx);
					
					gridEXValores.Delete();
					gridEXValores.Refresh();	

					_movimiento.Recalcular();
			}
		}

				
		
		protected override void SaveChanges()
		{
			DumpControls();
			mz.erp.businessrules.tfi_MovimientosDeCajaEx.Commit((tfi_MovimientosDeCajaExDataset)_data,_movimiento,_dataValoresEx);
			mz.erp.businessrules.tfi_MovimientosDeCajaEx.UpdateWithValidation((tfi_MovimientosDeCajaExDataset)_data);
			
			Evaluate();
		}

		private void gridEXValores_RecordsDeleted(object sender, System.EventArgs e)
		{
			_movimiento.Recalcular();
		}

		private void txtObservaciones_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void mzCmbTiposMovimiento_ValueChanged(object sender, System.EventArgs e)
		{
			
			tsy_SubTipoMovimientoDataset subtipos = mz.erp.businessrules.tsy_SubTipoMovimiento.GetList( Convert.ToString(this.mzCmbTiposMovimiento.Value));
			this.mzCmbSubTiposMovimiento.FillFromDataSource(subtipos.tsy_SubTipoMovimiento, "IdSubTipoMovimiento","Descripcion",100,"Descripcion");
			if (subtipos.tsy_SubTipoMovimiento.Count != 0)
				this.mzCmbSubTiposMovimiento.Value = subtipos.tsy_SubTipoMovimiento[0]["IdSubTipoMovimiento"];
			this.mzCmbSubTiposMovimiento.ReadOnly = false;
		}

		private void mzCmbTipoComp_ValueChanged(object sender, System.EventArgs e)
		{
			switch ( Convert.ToString(mzCmbTipoComp.Value) )
			{
			
				case "Fact.A":
					txtNumero.InputMask = "\\A-####-########";
					txtNumero.Text = "A--";
					txtNumero.Enabled = true;
					break;
				case "Fact.B":
					txtNumero.InputMask = "\\B-####-########";
					txtNumero.Text = "B--";
					txtNumero.Enabled = true;
					break;	
				case "Fact.C":
					txtNumero.InputMask = "\\C-####-########";
					txtNumero.Text = "C--";
					txtNumero.Enabled = true;
					break;	
				case "Ticket":
					txtNumero.InputMask = "\\###############";
					txtNumero.Text = "";
					txtNumero.Enabled = true;
					break;	
				case "No":
					txtNumero.InputMask = "";
					txtNumero.Text = "";
					txtNumero.Enabled = false;
					break;
			}
		}

		/*
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
					if (!ClaveCorrecta /*&& password != ""*//*)
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

		}*/
	}	
}


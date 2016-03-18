using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.businessrules;
using Janus.Windows.GridEX;
using Infragistics.Win.UltraWinExplorerBar;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesDePago.
	/// </summary>
	public class FrmComprobantesDePago : System.Windows.Forms.Form, ISearchObjectListener, ITaskForm
	{
		#region Variables Privadas
		
		private System.Windows.Forms.ToolBar toolBarStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private mz.erp.ui.controls.mzComboEditor mzCmbTipoComprobante;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Janus.Windows.GridEX.GridEX gridCompAImputar;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImputado;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		private Infragistics.Win.Misc.UltraButton ubEliminar;
		private Infragistics.Win.Misc.UltraButton ubAgregar;
		private System.Windows.Forms.Label label1;
		private Janus.Windows.GridEX.GridEX gridEXValores;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalValores;
		private System.ComponentModel.IContainer components;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private System.Windows.Forms.MenuItem Editar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEObservaciones;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumero;
		private Infragistics.Win.Misc.UltraButton ubBuscar;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private Infragistics.Win.Misc.UltraLabel ultraLabel9;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneSaldo;
        private CheckBox chckImputaAutomaticamente;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneSaldoAimputar;
        private Label label3;

		private ComprobantesDePagoController _uiController;
		#endregion

		#region Constructores

		public FrmComprobantesDePago()
		{
			
			InitializeComponent();
			_uiController = new ComprobantesDePagoController();

		}

		public FrmComprobantesDePago(ComprobantesDePagoController controller)
		{
			InitializeComponent();
			_uiController = controller;
		}

		#endregion

		#region Inicializadores
		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
		}
	
		private void ConfigureInterface()
		{
            utility.Util.LoadImages(this.toolBarStandar, imglStandar);
            tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			gridEXValores.LayoutData = _uiController.LayoutValores;
			uneTotalImputado.ReadOnly = true;
			uneTotalValores.ReadOnly = true;
            //German 20120125 - Tarea 0000256
            uneSaldoAimputar.ReadOnly = true;
            //Fin German 20120125 - Tarea 0000256
			labelTarea.Text = _uiController.LeyendaFormulario;
			mzCmbCuenta.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mzCmbCuenta.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			mzCmbCuenta.Enabled = _uiController.AllowEditCuenta;			
			/* sasa
			if(_uiController.AllowEditImputacion)
				gridCompAImputar.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			else gridCompAImputar.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			*/
			mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;
			mzCmbTipoComprobante.Enabled = _uiController.AllowEditTipoDeComprobante;
			mzCEInstanciasCaja.Enabled = _uiController.AllowEditInstanciaDeCaja;
			ubAgregar.Enabled = _uiController.AllowEditValores;
			ubEliminar.Enabled = _uiController.AllowEditValores;

			tbbAnterior.Text = _uiController.TextoBotonAnterior;			
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			ultraMENumero.ReadOnly = !_uiController.AllowEditNumeration;
			ultraMENumero.Enabled = _uiController.AllowEditNumeration;
			


			//Grilla de Comprobantes Imputados
			
			//Layout
			gridCompAImputar.LayoutData = _uiController.LayoutDataCompAImputar;
			
			//Format Condition para el campo Saldo
			Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridCompAImputar.RootTable.Columns["Signo"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,
				0);
			fc.FormatStyle.ForeColor=System.Drawing.Color.Red;
			fc.TargetColumn = this.gridCompAImputar.RootTable.Columns["SaldoSinSigno"];
			this.gridCompAImputar.RootTable.FormatConditions.Add(fc);
			
			//Format Condition para el campo Importe
			Janus.Windows.GridEX.GridEXFormatCondition fc1 = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridCompAImputar.RootTable.Columns["Signo"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,
				0);
			fc1.FormatStyle.ForeColor=System.Drawing.Color.Red;
			fc1.TargetColumn = this.gridCompAImputar.RootTable.Columns["ImporteSinSigno"];
			this.gridCompAImputar.RootTable.FormatConditions.Add(fc1);

            //Sabrina: Tarea 1117. 20110816
            chckImputaAutomaticamente.Enabled = _uiController.AllowEditImputaAutomaticamente;

            //Format Style para los comprobantes Imputados
            Janus.Windows.GridEX.GridEXFormatStyle fs = new Janus.Windows.GridEX.GridEXFormatStyle((Janus.Windows.GridEX.GridEXFormatStyle)gridCompAImputar.RowFormatStyle);
            fs.BackColor = System.Drawing.Color.Gray;
            Janus.Windows.GridEX.ConditionOperator condOp = Janus.Windows.GridEX.ConditionOperator.GreaterThan;
            Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition(gridCompAImputar.RootTable.Columns["Pago"], condOp, Convert.ToInt32(0));
            cnd.FormatStyle = fs;
            gridCompAImputar.RootTable.FormatConditions.Add(cnd);
            //Fin Sabrina: Tarea 1117. 20110816

			ubBuscar.Enabled = _uiController.AllowSearchValores;
			KeyPreview = true;

			uneSaldo.ReadOnly = true;
			uneSaldo.FormatString = "$#,##0.00;$#,##0.00;$0.00";	
			uneTotalImputado.FormatString = "$#,##0.00;$#,##0.00;$0.00";	
			uneTotalValores.FormatString = "$#,##0.00;$#,##0.00;$0.00";
            //German 20120125 - Tarea 0000256
            uneSaldoAimputar.FormatString = "$#,##0.00;$#,##0.00;$0.00";	
            //Fin German 20120125 - Tarea 0000256

			this.gridCompAImputar.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
				

		}
		

		private void InitEventHandlers()
		{
			mzCmbCuenta.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbCuenta.AllowEditClientePaso = true;
			mzCmbCuenta.SearchObjectListener = this;
			mzCmbCuenta.AddObjectListener( (IObserver)_uiController );
			//mzCmbCuenta.SendObservable( (IObservable) _uiController );
			//mzCEResponsableEmision.ValueChanged += new System.EventHandler( this.Componentes_Changes );
			MouseHelper mouseControler = new MouseHelper();
			mouseControler.Control = ultraExplorerBar1;
			mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
			mouseControler.WheelForward += new MouseEventHandler(ScrollUp);
			ubAgregar.Click +=new EventHandler(ubAgregar_Click);
			ubEliminar.Click +=new EventHandler(ubEliminar_Click);
			ubBuscar.Click +=new EventHandler(ubBuscar_Click);
			toolBarStandar.ButtonClick += new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			gridEXValores.DoubleClick +=new EventHandler(gridEXValores_DoubleClick);
//sasa			gridCompAImputar.DoubleClick +=new EventHandler(gridCompAImputar_DoubleClick);
			_uiController.ComprobanteHasChanged +=new EventHandler(Refresh);
			gridEXValores.Error +=new ErrorEventHandler(gridEXValores_Error);									
			gridEXValores.RecordsDeleted+=new EventHandler(gridEXValores_RecordsDeleted);
			mzCEResponsableEmision.Leave +=new EventHandler(mzCEResponsableEmision_Leave);
			KeyDownManager KeyDown = new KeyDownManager(this);	

			_uiController.SaldoChanged +=new EventHandler(_uiController_SaldoChanged);
            /* Silvina 20111230 - Tarea 0000245 */
            ultraMENumero.ValueChanged += new EventHandler(ultraMENumero_ValueChanged);
            _uiController.NumeroChanged += new EventHandler(_uiController_NumeroChanged);
            /* Fin Silvina 20111230 - Tarea 0000245 */
            //German 20120510 - Tarea 0000323
            _uiController.NumeroSugeridoChanged += new EventHandler(_uiController_NumeroSugeridoChanged);
            //Fin German 20120510 - Tarea 0000323
		}

        //German 20120510 - Tarea 0000323
        void _uiController_NumeroSugeridoChanged(object sender, EventArgs e)
        {
            this.ultraMENumero.ValueChanged -= new EventHandler(ultraMENumero_ValueChanged);
            ultraMENumero.InputMask = _uiController.Mascara;
            ultraMENumero.Text = _uiController.Numero;
            this.ultraMENumero.ValueChanged += new EventHandler(ultraMENumero_ValueChanged);

        }
        //Fin German 20120510 - Tarea 0000323

		private void ScrollDown (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);
		}

		private void ScrollUp (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageUp);
		}
		
		private void Componentes_Changes(object sender, System.EventArgs e)
		{
			if ((string ) mzCmbCuenta.DataValue != "")
			{
				string codigo = Convert.ToString(mzCmbCuenta.DataValue);
				if(!codigo.Equals(_uiController.CodigoCuenta))
				{		
					_uiController.CodigoCuenta = Convert.ToString(mzCmbCuenta.DataValue);//codigo;
					uneTotalImputado.DataBindings.Clear();
					uneTotalImputado.DataBindings.Add("Text", _uiController, "TotalImputado");
                    //German 20120125 - Tarea 0000256
                    uneSaldoAimputar.DataBindings.Clear();
                    uneSaldoAimputar.DataBindings.Add("Text", _uiController, "SaldoAImputar");
                    //Fin German 20120125 - Tarea 0000256
					gridCompAImputar.SetDataBinding(_uiController.DetalleCuentaCorriente, null);		
					ConfigGridForCompAImputar();				
				}
			}
			else
			{
				_uiController.CodigoCuenta = string.Empty;
				gridCompAImputar.SetDataBinding(null, null);
				
			}
		}

		private void ConfigGridForCompAImputar()
		{
			if(_uiController.DetalleCuentaCorriente != null)
			{
				if(gridCompAImputar.RootTable != null)
				{
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
		}

		private void InitializeData()
		{
			// new
			if(_uiController.RenombraClienteDePaso)
				mzCmbCuenta.SetNombreClienteDePaso(_uiController.NombreClientePaso);
			mzCmbCuenta.DataValue = _uiController.CodigoCuenta;
			mzCEResponsableEmision.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona","Nombre",100,"ID","Nombre","Nombre");
			mzCEInstanciasCaja.FillFromDataSource(_uiController.InstanciasCajasAbiertas, "IdInstanciaCaja","Descripcion",100,"ID","Descripcion","Descripcion");
			mzCmbTipoComprobante.FillFromDataSource(_uiController.TiposDeComprobantesDePago, "IdTipoDeComprobante","Descripcion",100,"ID","Descripcion","Descripcion");		
		}

		private void InitDataBindings()
		{
			mzCEInstanciasCaja.DataBindings.Add("Value", _uiController,"IdInstanciaDeCaja");
			//BindingController.Bind(mzCEInstanciasCaja,"Value", _uiController,"IdInstanciaDeCaja");
			BindingController.Bind(mzCEResponsableEmision,"Value", _uiController,"IdResponsable");
			BindingController.Bind(uTEObservaciones,"Text", _uiController, "Observaciones" );			
			//BindingController.numeroBind(txtNumero,"Text", _uiController, "Numero" );	
			uneTotalValores.DataBindings.Add("Value", _uiController , "Total");
			mzCmbTipoComprobante.DataBindings.Add("Value", _uiController, "TipoDeComprobante");
			gridEXValores.SetDataBinding(_uiController.Valores, null);
			ConfigGridForValores();
			gridCompAImputar.SetDataBinding(_uiController.DetalleCuentaCorriente, null);
			ConfigGridForCompAImputar();
			uneTotalImputado.DataBindings.Add("Value", _uiController, "TotalImputado");
            //German 20120125 - Tarea 0000256
            uneSaldoAimputar.DataBindings.Add("Value", _uiController, "SaldoAImputar");
            //Fin German 20120125 - Tarea 0000256
            /* Silvina 20111230 - Tarea 0000245 */
            ultraMENumero.InputMask = _uiController.Mascara;
            ultraMENumero.Text = _uiController.Numero;
			//ultraMENumero.DataBindings.Add( "InputMask",_uiController , "Mascara" );
			//BindingController.Bind(ultraMENumero,"Text", _uiController, "Numero" );
            /* Fin Silvina 20111230 - Tarea 0000245 */
			cldFechaComprobante.DataBindings.Add("Enabled", _uiController, "AllowEditFecha");
			cldFechaComprobante.DataBindings.Add("Value", _uiController, "FechaComprobante");
			uneSaldo.DataBindings.Add("Value", _uiController , "Saldo");

            //Sabrina: Tarea 1117. 20110816
            chckImputaAutomaticamente.DataBindings.Add("Checked", _uiController, "ImputaAutomaticamente");
            //Fin Sabrina: Tarea 1117. 20110816			
		}

		private void ubAgregar_Click(object sender, EventArgs e)
		{
			//_uiController.IdCuenta
			FrmValores form = new FrmValores(_uiController.GetValoresController(), _uiController, _uiController.IdCuenta);
			form.AddObjectListener(_uiController);
			form.ShowFormIObservable("Valor en Pago de Cuenta Corriente de "+Convert.ToString("Fix_ubAgregar_click_mzCmbCuenta."));
		}
		private void ubEliminar_Click(object sender, EventArgs e)
		{
			if(gridEXValores.SelectedItems.Count > 0)
			{
				gridEXValores.Delete();				
			}
		}
		private void getDataSet(System.Data.DataSet data, Valor  valor)
		{
			try
			{
				_uiController.RefreshValores(data, valor);
				gridEXValores.SetDataBinding(_uiController.Valores,null); 
				ConfigGridForValores();			
			}
			catch(Exception e) {;}
			
			
		}

		private void ConfigGridForValores()
		{
			if(_uiController.Valores != null)
			{
				if(gridEXValores.RootTable != null && gridEXValores.CurrentTable != null)
				{
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
					if(!_uiController.AllowEditValores)
					{
						col["IdTDCompTesoreria"].EditType= Janus.Windows.GridEX.EditType.NoEdit;
						col["Monto"].EditType= Janus.Windows.GridEX.EditType.NoEdit;
						col["MontoCotizado"].EditType= Janus.Windows.GridEX.EditType.NoEdit;
						col["IdMoneda"].EditType= Janus.Windows.GridEX.EditType.NoEdit;

					}

				}
			}
			
		}

		private void gridEXValores_DoubleClick(object sender, EventArgs e)
		{
			gridEXValores.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
		}

		private void gridCompAImputar_DoubleClick(object sender, EventArgs e)
		{
			if (gridCompAImputar.SelectedItems.Count > 0 )
			{
				if(_uiController.AllowEditImputacion)
				{
					_uiController.UpdatePago(gridCompAImputar.GetRow().DataRow);
					gridCompAImputar.Refetch();
				}
			}
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					Util.MoveFocus(this.ultraExplorerBarContainerControl5);					
					_uiController.Execute();
					break;
				case 4:
					if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
						Close();
					break;
			}
		}


		#endregion

		#region Dispose

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
				_uiController.ComprobanteHasChanged -=new EventHandler(Refresh);
				mzCEInstanciasCaja.DataBindings.Clear();
				//BindingController.Clear(mzCEInstanciasCaja,"Value", _uiController,"IdInstanciaDeCaja");
				BindingController.Clear(mzCEResponsableEmision,"Value", _uiController,"IdResponsable");
				BindingController.Clear(uTEObservaciones,"Text", _uiController, "Observaciones" );	
				//BindingController.Clear(txtNumero,"Text", _uiController, "Numero" );	
				_uiController.SaldoChanged -=new EventHandler(_uiController_SaldoChanged);
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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
            this.ultraMENumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
            this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmbTipoComprobante = new mz.erp.ui.controls.mzComboEditor();
            this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chckImputaAutomaticamente = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uneSaldo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ubBuscar = new Infragistics.Win.Misc.UltraButton();
            this.ubEliminar = new Infragistics.Win.Misc.UltraButton();
            this.ubAgregar = new Infragistics.Win.Misc.UltraButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gridEXValores = new Janus.Windows.GridEX.GridEX();
            this.uneTotalValores = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridCompAImputar = new Janus.Windows.GridEX.GridEX();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.Detalles = new System.Windows.Forms.MenuItem();
            this.Editar = new System.Windows.Forms.MenuItem();
            this.uneTotalImputado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label8 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uTEObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.uneSaldoAimputar = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label3 = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
            this.ultraExplorerBarContainerControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).BeginInit();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoAimputar)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 24);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(1267, 25);
            this.ultraExplorerBarContainerControl2.TabIndex = 9;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(1267, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel7);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel8);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel9);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmbCuenta);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraMENumero);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCEResponsableEmision);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCEInstanciasCaja);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel4);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel6);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmbTipoComprobante);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.cldFechaComprobante);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 106);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(1267, 71);
            this.ultraExplorerBarContainerControl5.TabIndex = 6;
            // 
            // ultraLabel7
            // 
            appearance1.TextHAlignAsString = "Right";
            this.ultraLabel7.Appearance = appearance1;
            this.ultraLabel7.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(549, 28);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(65, 11);
            this.ultraLabel7.TabIndex = 34;
            this.ultraLabel7.Text = "Fecha";
            // 
            // ultraLabel8
            // 
            appearance2.TextHAlignAsString = "Right";
            this.ultraLabel8.Appearance = appearance2;
            this.ultraLabel8.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel8.Location = new System.Drawing.Point(496, 3);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(119, 12);
            this.ultraLabel8.TabIndex = 35;
            this.ultraLabel8.Text = "Tipo de comprobante";
            // 
            // ultraLabel9
            // 
            appearance3.TextHAlignAsString = "Right";
            this.ultraLabel9.Appearance = appearance3;
            this.ultraLabel9.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel9.Location = new System.Drawing.Point(549, 52);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(65, 11);
            this.ultraLabel9.TabIndex = 33;
            this.ultraLabel9.Text = "Número";
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(112, 23);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(440, 24);
            this.mzCmbCuenta.TabIndex = 1;
            // 
            // ultraMENumero
            // 
            this.ultraMENumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMENumero.InputMask = "\\A-####-########";
            this.ultraMENumero.Location = new System.Drawing.Point(620, 48);
            this.ultraMENumero.Name = "ultraMENumero";
            this.ultraMENumero.Size = new System.Drawing.Size(100, 20);
            this.ultraMENumero.TabIndex = 5;
            this.ultraMENumero.Text = "A--";
            this.ultraMENumero.Leave += new System.EventHandler(this.ultraMENumero_Leave);
            // 
            // mzCEResponsableEmision
            // 
            this.mzCEResponsableEmision.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsableEmision.DisplayMember = "";
            this.mzCEResponsableEmision.DisplayMemberCaption = "";
            this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableEmision.Location = new System.Drawing.Point(112, 0);
            this.mzCEResponsableEmision.MaxItemsDisplay = 7;
            this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
            this.mzCEResponsableEmision.Size = new System.Drawing.Size(152, 21);
            this.mzCEResponsableEmision.SorterMember = "";
            this.mzCEResponsableEmision.TabIndex = 0;
            this.mzCEResponsableEmision.ValueMember = "";
            this.mzCEResponsableEmision.ValueMemberCaption = "";
            // 
            // mzCEInstanciasCaja
            // 
            this.mzCEInstanciasCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEInstanciasCaja.DisplayMember = "";
            this.mzCEInstanciasCaja.DisplayMemberCaption = "";
            this.mzCEInstanciasCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEInstanciasCaja.Location = new System.Drawing.Point(112, 48);
            this.mzCEInstanciasCaja.MaxItemsDisplay = 7;
            this.mzCEInstanciasCaja.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEInstanciasCaja.Name = "mzCEInstanciasCaja";
            this.mzCEInstanciasCaja.Size = new System.Drawing.Size(152, 21);
            this.mzCEInstanciasCaja.SorterMember = "";
            this.mzCEInstanciasCaja.TabIndex = 2;
            this.mzCEInstanciasCaja.ValueMember = "";
            this.mzCEInstanciasCaja.ValueMemberCaption = "";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(0, 46);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel4.TabIndex = 27;
            this.ultraLabel4.Text = "Instancia de Caja";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(0, 0);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel6.TabIndex = 26;
            this.ultraLabel6.Text = "Responsable Emisión";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(0, 23);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel1.TabIndex = 25;
            this.ultraLabel1.Text = "Cuenta";
            // 
            // mzCmbTipoComprobante
            // 
            this.mzCmbTipoComprobante.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTipoComprobante.DisplayMember = "";
            this.mzCmbTipoComprobante.DisplayMemberCaption = "";
            this.mzCmbTipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTipoComprobante.Location = new System.Drawing.Point(620, 0);
            this.mzCmbTipoComprobante.MaxItemsDisplay = 7;
            this.mzCmbTipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTipoComprobante.Name = "mzCmbTipoComprobante";
            this.mzCmbTipoComprobante.Size = new System.Drawing.Size(152, 21);
            this.mzCmbTipoComprobante.SorterMember = "";
            this.mzCmbTipoComprobante.TabIndex = 3;
            this.mzCmbTipoComprobante.ValueMember = "";
            this.mzCmbTipoComprobante.ValueMemberCaption = "";
            // 
            // cldFechaComprobante
            // 
            this.cldFechaComprobante.BackColor = System.Drawing.SystemColors.Window;
            this.cldFechaComprobante.DateButtons.Add(dateButton1);
            this.cldFechaComprobante.Enabled = false;
            this.cldFechaComprobante.Location = new System.Drawing.Point(620, 24);
            this.cldFechaComprobante.Name = "cldFechaComprobante";
            this.cldFechaComprobante.NonAutoSizeHeight = 23;
            this.cldFechaComprobante.Size = new System.Drawing.Size(100, 21);
            this.cldFechaComprobante.TabIndex = 4;
            // 
            // ultraExplorerBarContainerControl6
            // 
            this.ultraExplorerBarContainerControl6.Controls.Add(this.chckImputaAutomaticamente);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.label2);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.uneSaldo);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.ubBuscar);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.ubEliminar);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.ubAgregar);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.gridEXValores);
            this.ultraExplorerBarContainerControl6.Controls.Add(this.uneTotalValores);
            this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(28, 234);
            this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
            this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(1267, 181);
            this.ultraExplorerBarContainerControl6.TabIndex = 8;
            // 
            // chckImputaAutomaticamente
            // 
            this.chckImputaAutomaticamente.BackColor = System.Drawing.Color.Transparent;
            this.chckImputaAutomaticamente.Location = new System.Drawing.Point(306, 0);
            this.chckImputaAutomaticamente.Name = "chckImputaAutomaticamente";
            this.chckImputaAutomaticamente.Size = new System.Drawing.Size(184, 21);
            this.chckImputaAutomaticamente.TabIndex = 38;
            this.chckImputaAutomaticamente.Text = "Imputar Automáticamente";
            this.chckImputaAutomaticamente.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(648, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "Saldo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneSaldo
            // 
            this.uneSaldo.Location = new System.Drawing.Point(696, 2);
            this.uneSaldo.Name = "uneSaldo";
            this.uneSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneSaldo.Size = new System.Drawing.Size(96, 21);
            this.uneSaldo.TabIndex = 36;
            this.uneSaldo.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ubBuscar
            // 
            this.ubBuscar.Location = new System.Drawing.Point(200, 0);
            this.ubBuscar.Name = "ubBuscar";
            this.ubBuscar.Size = new System.Drawing.Size(96, 24);
            this.ubBuscar.TabIndex = 2;
            this.ubBuscar.Text = "&Buscar";
            // 
            // ubEliminar
            // 
            this.ubEliminar.Location = new System.Drawing.Point(104, 0);
            this.ubEliminar.Name = "ubEliminar";
            this.ubEliminar.Size = new System.Drawing.Size(96, 24);
            this.ubEliminar.TabIndex = 1;
            this.ubEliminar.Text = "&Eliminar";
            // 
            // ubAgregar
            // 
            this.ubAgregar.Location = new System.Drawing.Point(8, 0);
            this.ubAgregar.Name = "ubAgregar";
            this.ubAgregar.Size = new System.Drawing.Size(96, 24);
            this.ubAgregar.TabIndex = 0;
            this.ubAgregar.Text = "&Agregar";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(496, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
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
            this.gridEXValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridEXValores.GroupByBoxVisible = false;
            this.gridEXValores.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridEXValores.Location = new System.Drawing.Point(0, 24);
            this.gridEXValores.Name = "gridEXValores";
            this.gridEXValores.Size = new System.Drawing.Size(792, 160);
            this.gridEXValores.TabIndex = 4;
            // 
            // uneTotalValores
            // 
            this.uneTotalValores.Location = new System.Drawing.Point(552, 2);
            this.uneTotalValores.Name = "uneTotalValores";
            this.uneTotalValores.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalValores.Size = new System.Drawing.Size(96, 21);
            this.uneTotalValores.TabIndex = 3;
            this.uneTotalValores.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneSaldoAimputar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCompAImputar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneTotalImputado);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label8);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 472);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(1267, 157);
            this.ultraExplorerBarContainerControl1.TabIndex = 7;
            // 
            // gridCompAImputar
            // 
            this.gridCompAImputar.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridCompAImputar.ContextMenu = this.contextMenu1;
            this.gridCompAImputar.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridCompAImputar.GroupByBoxVisible = false;
            this.gridCompAImputar.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridCompAImputar.Location = new System.Drawing.Point(0, 22);
            this.gridCompAImputar.Name = "gridCompAImputar";
            this.gridCompAImputar.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridCompAImputar.Size = new System.Drawing.Size(792, 128);
            this.gridCompAImputar.TabIndex = 1;
            this.gridCompAImputar.DoubleClick += new System.EventHandler(this.gridCompAImputar_DoubleClick_1);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Detalles,
            this.Editar});
            // 
            // Detalles
            // 
            this.Detalles.Index = 0;
            this.Detalles.Text = "Ver detalles";
            this.Detalles.Click += new System.EventHandler(this.Detalles_Click);
            // 
            // Editar
            // 
            this.Editar.Index = 1;
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // uneTotalImputado
            // 
            this.uneTotalImputado.Location = new System.Drawing.Point(552, -2);
            this.uneTotalImputado.Name = "uneTotalImputado";
            this.uneTotalImputado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalImputado.Size = new System.Drawing.Size(96, 21);
            this.uneTotalImputado.TabIndex = 0;
            this.uneTotalImputado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(424, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uTEObservaciones);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(798, 150);
            this.ultraExplorerBarContainerControl3.TabIndex = 10;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // uTEObservaciones
            // 
            this.uTEObservaciones.Location = new System.Drawing.Point(0, 8);
            this.uTEObservaciones.Multiline = true;
            this.uTEObservaciones.Name = "uTEObservaciones";
            this.uTEObservaciones.Size = new System.Drawing.Size(792, 128);
            this.uTEObservaciones.TabIndex = 1;
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
            this.toolBarStandar.Size = new System.Drawing.Size(1333, 28);
            this.toolBarStandar.TabIndex = 19;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbAnterior
            // 
            this.tbbAnterior.ImageIndex = 9;
            this.tbbAnterior.Name = "tbbAnterior";
            this.tbbAnterior.Text = "&Anterior";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSiguiente
            // 
            this.tbbSiguiente.ImageIndex = 8;
            this.tbbSiguiente.Name = "tbbSiguiente";
            this.tbbSiguiente.Text = "&Siguiente";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl6);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 71;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Informacion General";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl6;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 181;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Valores";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup4.Settings.ContainerHeight = 157;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Comprobantes A Imputar";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Observaciones";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(1333, 649);
            this.ultraExplorerBar1.TabIndex = 20;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // uneSaldoAimputar
            // 
            this.uneSaldoAimputar.Location = new System.Drawing.Point(696, -2);
            this.uneSaldoAimputar.Name = "uneSaldoAimputar";
            this.uneSaldoAimputar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneSaldoAimputar.Size = new System.Drawing.Size(96, 21);
            this.uneSaldoAimputar.TabIndex = 33;
            this.uneSaldoAimputar.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(651, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Saldo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmComprobantesDePago
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1333, 677);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmComprobantesDePago";
            this.Text = "Comprobante De Pago";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            this.ultraExplorerBarContainerControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTipoComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
            this.ultraExplorerBarContainerControl6.ResumeLayout(false);
            this.ultraExplorerBarContainerControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalValores)).EndInit();
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uneSaldoAimputar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
			// TODO: agregar la implementación FrmComprobantesDePago.processEventChange
			// todo esto fue copiado de FrmComprobantesDeVenta...
			System.Data.DataSet data = (System.Data.DataSet)sender;
			System.Data.DataTable table = data.Tables["tsa_cuentas"];
			System.Data.DataRow row = table.Rows[0];
			//aca
			//mzComboCuentaSearchEditor1.DataValue = (string )row["Codigo"];
			//aca
			// = (string )row["Codigo"];
			//_uiController.DatosCuentaChanged = true;
			mzCmbCuenta.DataValue = Convert.ToString(row["Codigo"]);

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
				{
					_uiController.Close();
					Close();
				}
			}
			else
			{
				_uiController.Close();
				Close();
			}
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			Util.MoveFocus(this.ultraExplorerBarContainerControl5);					
			_uiController.Execute();
		}

		#endregion

		private void Refresh(object sender, EventArgs e)
		{
			gridEXValores.DataBindings.Clear();
			gridEXValores.SetDataBinding(_uiController.Valores, null);
			//ConfigGridForValores();
			//German 20091019
			int rowind = gridCompAImputar.Row;
			//Fin German 20091019
			gridCompAImputar.DataBindings.Clear();
			gridCompAImputar.SetDataBinding(_uiController.DetalleCuentaCorriente, null);
			//German 20091019
			gridCompAImputar.MoveToRowIndex(rowind);
			//Fin German 20091019
			
		}

		private void gridEXValores_Error(object sender, ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		
		private void Detalles_Click(object sender, EventArgs e)
		{
			if(gridCompAImputar.SelectedItems.Count > 0 && _uiController != null)
			{
				if ( _uiController.AllowPrintItem() ) 
				{
					this.Cursor = Cursors.WaitCursor;
					string IdComprobante = Convert.ToString(gridCompAImputar.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);					
					ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void Editar_Click(object sender, EventArgs e)
		{
			if(gridCompAImputar.SelectedItems.Count > 0 )
			{
				gridCompAImputar.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
				gridCompAImputar_DoubleClick(this, new System.EventArgs());
			}
		}

		private void gridEXValores_RecordsDeleted(object sender, EventArgs e)
		{
			gridEXValores.Refresh();
			_uiController.Recalcular();
		}

		private void mzCEResponsableEmision_Leave(object sender, EventArgs e)
		{
			if (_uiController.AskForPasswordResponsableEmision) 
			{
				ShowPassword();				
			}	
		}

		private void ShowPassword() 
		{			
			string IdPersona = Convert.ToString(mzCEResponsableEmision.Value);			
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

		private void ubBuscar_Click(object sender, EventArgs e)
		{
			if(_uiController.IdInstanciaDeCaja != null && _uiController.IdInstanciaDeCaja != string.Empty)
			{
				FrmConsultaValores frmConsultaValores = new FrmConsultaValores("ProcesoConsultarValores", "ConsultarValores", _uiController.IdInstanciaDeCaja);
				frmConsultaValores.AddObjectListener(this._uiController);
				frmConsultaValores.Build_UI();
				frmConsultaValores.MdiParent = this.MdiParent;
				frmConsultaValores.Show();
			}
			else
				MessageBox.Show("No ha Seleccionado una Caja", "Debe seleccionar la Caja en la que se van a buscar los valores", 
					System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
		}

		private void ultraMENumero_Leave(object sender, System.EventArgs e)
		{
			this.ultraMENumero.Text = _uiController.FillNumberWithZeros(ultraMENumero.Text);
		}

        /* Silvina 20111230 - Tarea 0000245 */
        private void ultraMENumero_ValueChanged(object sender, EventArgs e)
        {
            _uiController.Numero = ultraMENumero.Text;
        }

        private void _uiController_NumeroChanged(object sender, EventArgs e)
        {
            this.ultraMENumero.ValueChanged -= new EventHandler(ultraMENumero_ValueChanged);
            ultraMENumero.InputMask = _uiController.Mascara;
            ultraMENumero.Text = _uiController.Numero;
            this.ultraMENumero.ValueChanged += new EventHandler(ultraMENumero_ValueChanged);
        }

        /* Fin Silvina 20111230 - Tarea 0000245 */

		private void gridCompAImputar_DoubleClick_1(object sender, System.EventArgs e)
		{
			if (gridCompAImputar.SelectedItems.Count > 0 && gridCompAImputar.GetRow().RowType.Equals(Janus.Windows.GridEX.RowType.Record) )
			{
				if(_uiController.AllowEditImputacion)
				{
					_uiController.UpdatePago(gridCompAImputar.GetRow().DataRow);
					//German 20091019
					int rowind = gridCompAImputar.Row;
					//Fin German 20091019
					gridCompAImputar.Refetch();
					//German 20091019
					gridCompAImputar.MoveToRowIndex(rowind);
					//Fin German 20091019

				}
			}
		}

		private void _uiController_SaldoChanged(object sender, EventArgs e)
		{
			if(_uiController.Saldo < 0)
				uneSaldo.Appearance.ForeColor = Color.Red;
			else uneSaldo.Appearance.ForeColor = Color.Black;
		}


	}
}

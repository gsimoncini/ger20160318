using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;	
using mz.erp.commontypes;
using mz.erp.businessrules.comprobantes; //Cristian Tarea 879

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmCabeceraComprobanteDeCompra.
	/// </summary>
	public class FrmCabeceraComprobanteDeCompra : System.Windows.Forms.Form, ITaskForm, ISearchObjectListener
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorCotizacion;
		private Infragistics.Win.Misc.UltraLabel ultraLabel9;
		private mz.erp.ui.controls.mzComboEditor mzCETiposDeCambio;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private mz.erp.ui.controls.mzComboEditor mzCEMonedas;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaRegistracion;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ultraMENumero;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableEmision;
		private mz.erp.ui.controls.mzComboEditor mzCETipoComprobante;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cldFechaComprobante;		
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccFechaVencimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel11;
		private mz.erp.ui.controls.mzComboEditor mzCECuentaImputacion;
		private Infragistics.Win.Misc.UltraLabel ultraLabel12;
		private mz.erp.ui.controls.mzComboEditor mzCESubcuentaImputacion;
		private Infragistics.Win.Misc.UltraLabel ultraLabel13;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasVencimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel16;
		private Infragistics.Win.Misc.UltraLabel ultraLabel17;
		private System.Windows.Forms.TextBox txtCAI;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneNeto;
		private Infragistics.Win.Misc.UltraLabel ultraLabel18;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDescuentos;
		private Infragistics.Win.Misc.UltraLabel ultraLabel19;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcentajeDescuento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel20;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneNetoConDescuento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel21;
		private System.Windows.Forms.GroupBox groupBox1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel22;
		private Infragistics.Win.Misc.UltraLabel ultraLabel23;
		private Infragistics.Win.Misc.UltraLabel ultraLabel24;
		private Infragistics.Win.Misc.UltraLabel ultraLabel25;
		private Infragistics.Win.Misc.UltraLabel ultraLabel26;
		private Infragistics.Win.Misc.UltraLabel ultraLabel27;
		private System.Windows.Forms.GroupBox groupBox2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel28;
		private Infragistics.Win.Misc.UltraLabel ultraLabel29;
		private Infragistics.Win.Misc.UltraLabel ultraLabel30;
		private Infragistics.Win.Misc.UltraLabel ultraLabel31;
		private Infragistics.Win.Misc.UltraLabel ultraLabel32;
		private Janus.Windows.GridEX.GridEX gridOtrosConceptos;
		private Janus.Windows.GridEX.GridEX gridNetosGravados;
		private mz.erp.ui.controls.mzComboEditor mzCETipoDeNetoGravados;
		private mz.erp.ui.controls.mzComboEditor mzCEImpuestoAplicadoNetoGravado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcentajeImpuestoAplicadoNetoGravado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneNetoGravadoAplicado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorImpuestoAplicadoNetoGravado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalNetoGravado;
		private Infragistics.Win.Misc.UltraButton utbAgregarNetoGravado;
		private Infragistics.Win.Misc.UltraButton utbAgregarConceptoNOGravado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalConceptoNOGravado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorImpuestoAplicadoConceptoNOGravado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcentajeImpuestoAplicadoConceptoNOGravado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneConceptoNOGravadoAplicado;
		private mz.erp.ui.controls.mzComboEditor mzCEConceptosNOGravados;
		private Infragistics.Win.Misc.UltraLabel ultraLabel33;
		private mz.erp.ui.controls.mzComboEditor mzCEImpuestoAplicadoConceptoNOGravado;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo uccProximaFechaVencimiento;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit umeMesImputacion;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDescuentoGeneral;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePorcentajeDescuentoGeneral;
		private Infragistics.Win.Misc.UltraLabel ultraLabel15;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalGeneral;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private System.Windows.Forms.TextBox txtLeyenda;
		private Infragistics.Win.Misc.UltraLabel ultraLabel34;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel35;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneImpuestos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalUsuario;
		private Infragistics.Win.Misc.UltraLabel ultraLabel36;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor1;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor3;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor4;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor2;
		private System.Windows.Forms.Label labelSimboloMonedaReferencia;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalUsuarioMonedaReferencia;
		private Infragistics.Win.Misc.UltraLabel ultraLabel37;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor5;
		private System.Windows.Forms.Label labelSimboloMonedaProveedor6;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl6;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtObservaciones;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel38;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalDesdeImpuestos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneNetoItemsReal;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneNetoItems;
		private Infragistics.Win.Misc.UltraLabel ultraLabel39;
		private Infragistics.Win.Misc.UltraLabel ultraLabel40;
		private Infragistics.Win.Misc.UltraLabel ultraLabel14;
		private mz.erp.ui.controls.mzComboEditor mzCECondicionDeCompra;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit umeMesDevengamiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel41;		
		private System.ComponentModel.IContainer components;

		public FrmCabeceraComprobanteDeCompra()
		{			
			InitializeComponent();
		}

		public FrmCabeceraComprobanteDeCompra( controllers.IngresarComprobanteDeCompraCabeceraController controller )
		{			
			InitializeComponent();
			_uiController = controller;			
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
				//BindingController.Clear(mzCmb,"DataValue",_uiController,"KeyValueProveedores");
				BindingController.Clear(mzCECondicionDeCompra,"Value", _uiController, "IdCondicionDeCompra");
				mzCEResponsableEmision.DataBindings.Clear();
				BindingController.Clear(mzCETipoComprobante,"Value",_uiController,"KeyValueTiposDeComprobantes");
				ultraMENumero.DataBindings.Clear();
				cldFechaComprobante.DataBindings.Clear();
				uneDiasVencimiento.DataBindings.Clear();
				uccFechaVencimiento.DataBindings.Clear();
                //German 20120510 - Tarea 0000320
                uccProximaFechaVencimiento.DataBindings.Clear();
                //Fin German 20120510 - Tarea 0000320


                BindingController.Clear(mzCECuentaImputacion,"Value",_uiController,"IdCuentaImputacion");
				BindingController.Clear(mzCESubcuentaImputacion,"Value",_uiController,"IdSubCuentaImputacion");
				uneDescuentos.DataBindings.Clear();
				uneNeto.DataBindings.Clear();
				uneNetoConDescuento.DataBindings.Clear();
				unePorcentajeDescuento.DataBindings.Clear();
				uneDescuentoGeneral.DataBindings.Clear();
				unePorcentajeDescuentoGeneral.DataBindings.Clear();
				uneImpuestos.DataBindings.Clear();
				BindingController.Clear(mzCETipoDeNetoGravados,"Value", _uiController, "IdNetoGravado");
				BindingController.Clear(mzCEConceptosNOGravados,"Value", _uiController, "IdNetoNOGravado");
				BindingController.Clear(mzCEImpuestoAplicadoNetoGravado,"Value", _uiController, "IdImpuestoAsociadoNetoGravado");
				BindingController.Clear(mzCEImpuestoAplicadoConceptoNOGravado,"Value", _uiController, "IdImpuestoAsociadoNetoNOGravado");
				BindingController.Clear(uneNetoGravadoAplicado,"Value", _uiController, "NetoGravadoAplicado");
				BindingController.Clear(uneConceptoNOGravadoAplicado,"Value", _uiController, "NetoNOGravadoAplicado");
				uneValorImpuestoAplicadoNetoGravado.DataBindings.Clear();
				uneValorImpuestoAplicadoConceptoNOGravado.DataBindings.Clear();
				labelSimboloMonedaProveedor.DataBindings.Clear();
				labelSimboloMonedaProveedor1.DataBindings.Clear();
				labelSimboloMonedaProveedor2.DataBindings.Clear();
				labelSimboloMonedaProveedor3.DataBindings.Clear();
				labelSimboloMonedaProveedor4.DataBindings.Clear();
				labelSimboloMonedaProveedor5.DataBindings.Clear();
				labelSimboloMonedaProveedor6.DataBindings.Clear();
				mzCETiposDeCambio.DataBindings.Clear();
				mzCEMonedas.DataBindings.Clear();
				uneValorCotizacion.DataBindings.Clear();
				uneTotalUsuario.DataBindings.Clear();
				uneTotalUsuarioMonedaReferencia.DataBindings.Clear();
				gridNetosGravados.SetDataBinding(null, null);
				gridOtrosConceptos.SetDataBinding(null, null);
				gridProductos.SetDataBinding(null, null);
			
				uneNetoItems.DataBindings.Clear();
				uneNetoItemsReal.DataBindings.Clear();
				BindingController.Clear(mzCECondicionDeCompra,"Value", _uiController, "IdCondicionDeCompra");



				toolBarStandar.ButtonClick-=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
				_uiController.DiasVencimientoChanged -= new EventHandler(_uiController_DiasVencimientoChanged);
				_uiController.FechaVencimientoChanged -=new EventHandler(_uiController_FechaVencimientoChanged);
                //German 20120510 - Tarea 0000320
                _uiController.ProximaFechaVencimientoChanged -= new EventHandler(_uiController_ProximaFechaVencimientoChanged);
                //Fin German 20120510 - Tarea 0000320
				_uiController.CuentaImputacionChanged -=new EventHandler(_uiController_CuentaImputacionChanged);
				_uiController.CuentaImputacionProveedorChanged -=new EventHandler(_uiController_CuentaImputacionProveedorChanged);
				_uiController.SubCuentaImputacionProveedorChanged -=new EventHandler(_uiController_SubCuentaImputacionProveedorChanged);
                //German 2011104 - Tarea 914
				_uiController.NetoChangedAux -=new EventHandler(_uiController_NetoChanged);
                //Fin German 2011104 - Tarea 914
				_uiController.TotalChanged -=new EventHandler(_uiController_TotalChanged);
				_uiController.TipoDeComprobanteDestinoChanged -=new EventHandler(_uiController_TipoDeComprobanteDestinoChanged);
				_uiController.IdNetoGravadoChanged -=new EventHandler(_uiController_IdNetoGravadoChanged);
				_uiController.IdNetoNOGravadoChanged -=new EventHandler(_uiController_IdNetoNOGravadoChanged);
				_uiController.CalculoGravadoChanged -=new EventHandler(_uiController_CalculoGravadoChanged);
				_uiController.CalculoNOGravadoChanged -=new EventHandler(_uiController_CalculoNOGravadoChanged);
				_uiController.NetoAcumuladoInvalidoError -=new EventHandler(_uiController_NetoAcumuladoInvalidoError);
				_uiController.ConceptoRepetidoError -=new EventHandler(_uiController_ConceptoRepetidoError);
				this.ultraMENumero.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneValorCotizacion.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneDiasVencimiento.Enter -= new System.EventHandler(this.OnEnterControl);
				this.txtCAI.Enter -= new System.EventHandler(this.OnEnterControl);
				this.txtLeyenda.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneConceptoNOGravadoAplicado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneDescuentos.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneNeto.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneNetoConDescuento.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneNetoGravadoAplicado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.unePorcentajeDescuento.Enter -= new System.EventHandler(this.OnEnterControl);
				this.unePorcentajeImpuestoAplicadoConceptoNOGravado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.unePorcentajeImpuestoAplicadoNetoGravado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneTotalConceptoNOGravado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneTotalNetoGravado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneValorImpuestoAplicadoConceptoNOGravado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneValorImpuestoAplicadoNetoGravado.Enter -= new System.EventHandler(this.OnEnterControl);
				this.umeMesImputacion.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneTotalUsuario.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneImpuestos.Enter -= new System.EventHandler(this.OnEnterControl);
				this.uneDescuentoGeneral.Enter -= new System.EventHandler(this.OnEnterControl);

				utbAgregarNetoGravado.Click -=new EventHandler(utbAgregarNetoGravado_Click);
				utbAgregarConceptoNOGravado.Click -=new EventHandler(utbAgregarConceptoNOGravado_Click);
				//this.gridNetosGravados.DeletingRecords+=new CancelEventHandler(gridNetosGravados_DeletingRecords);
				this.gridNetosGravados.RecordsDeleted-=new EventHandler(gridNetosGravados_RecordsDeleted);
				this.gridOtrosConceptos.DeletingRecords-=new CancelEventHandler(gridOtrosConceptos_DeletingRecords);
				this.gridOtrosConceptos.RecordsDeleted-=new EventHandler(gridOtrosConceptos_RecordsDeleted);

				
			
				this.gridProductos.EditingCell -=new Janus.Windows.GridEX.EditingCellEventHandler(gridProductos_EditingCell);

				_uiController.ItemsChanged -=new EventHandler(_uiController_ItemsChanged);

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
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton3 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton4 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCabeceraComprobanteDeCompra));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.umeMesDevengamiento = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.ultraLabel41 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.mzCECondicionDeCompra = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel14 = new Infragistics.Win.Misc.UltraLabel();
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.ultraLabel34 = new Infragistics.Win.Misc.UltraLabel();
            this.umeMesImputacion = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.txtCAI = new System.Windows.Forms.TextBox();
            this.ultraLabel17 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel16 = new Infragistics.Win.Misc.UltraLabel();
            this.uccProximaFechaVencimiento = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.uneDiasVencimiento = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.mzCESubcuentaImputacion = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCECuentaImputacion = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.uccFechaVencimiento = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraLabel11 = new Infragistics.Win.Misc.UltraLabel();
            this.uneValorCotizacion = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCETiposDeCambio = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCEMonedas = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.cldFechaRegistracion = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraMENumero = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
            this.mzCEResponsableEmision = new mz.erp.ui.controls.mzComboEditor();
            this.mzCETipoComprobante = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.cldFechaComprobante = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uneTotalDesdeImpuestos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneDescuentos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.ultraLabel38 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaReferencia = new System.Windows.Forms.Label();
            this.uneTotalUsuarioMonedaReferencia = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel37 = new Infragistics.Win.Misc.UltraLabel();
            this.labelSimboloMonedaProveedor2 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaProveedor4 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaProveedor3 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaProveedor1 = new System.Windows.Forms.Label();
            this.labelSimboloMonedaProveedor = new System.Windows.Forms.Label();
            this.uneTotalUsuario = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel36 = new Infragistics.Win.Misc.UltraLabel();
            this.uneImpuestos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel35 = new Infragistics.Win.Misc.UltraLabel();
            this.uneNetoConDescuento = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel21 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel20 = new Infragistics.Win.Misc.UltraLabel();
            this.unePorcentajeDescuento = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel19 = new Infragistics.Win.Misc.UltraLabel();
            this.uneNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel18 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.ultraLabel15 = new Infragistics.Win.Misc.UltraLabel();
            this.uneTotalGeneral = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePorcentajeDescuentoGeneral = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneDescuentoGeneral = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSimboloMonedaProveedor6 = new System.Windows.Forms.Label();
            this.ultraLabel33 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCEImpuestoAplicadoConceptoNOGravado = new mz.erp.ui.controls.mzComboEditor();
            this.utbAgregarConceptoNOGravado = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel28 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel29 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel30 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel31 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel32 = new Infragistics.Win.Misc.UltraLabel();
            this.uneTotalConceptoNOGravado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneValorImpuestoAplicadoConceptoNOGravado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneConceptoNOGravadoAplicado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.mzCEConceptosNOGravados = new mz.erp.ui.controls.mzComboEditor();
            this.gridOtrosConceptos = new Janus.Windows.GridEX.GridEX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSimboloMonedaProveedor5 = new System.Windows.Forms.Label();
            this.utbAgregarNetoGravado = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel27 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel26 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel25 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel24 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel23 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel22 = new Infragistics.Win.Misc.UltraLabel();
            this.uneTotalNetoGravado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneValorImpuestoAplicadoNetoGravado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePorcentajeImpuestoAplicadoNetoGravado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneNetoGravadoAplicado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.mzCEImpuestoAplicadoNetoGravado = new mz.erp.ui.controls.mzComboEditor();
            this.mzCETipoDeNetoGravados = new mz.erp.ui.controls.mzComboEditor();
            this.gridNetosGravados = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
            this.ultraLabel40 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel39 = new Infragistics.Win.Misc.UltraLabel();
            this.uneNetoItems = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.uneNetoItemsReal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.txtObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionDeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccProximaFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCESubcuentaImputacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECuentaImputacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETiposDeCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaRegistracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalDesdeImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalUsuarioMonedaReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneImpuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoConDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNeto)).BeginInit();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeDescuentoGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentoGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEImpuestoAplicadoConceptoNOGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalConceptoNOGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorImpuestoAplicadoConceptoNOGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeImpuestoAplicadoConceptoNOGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneConceptoNOGravadoAplicado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEConceptosNOGravados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtrosConceptos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalNetoGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorImpuestoAplicadoNetoGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeImpuestoAplicadoNetoGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoGravadoAplicado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEImpuestoAplicadoNetoGravado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoDeNetoGravados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNetosGravados)).BeginInit();
            this.ultraExplorerBarContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoItemsReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.ultraExplorerBarContainerControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
            this.ultraExplorerBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -21);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(870, 28);
            this.ultraExplorerBarContainerControl2.TabIndex = 2;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(870, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.umeMesDevengamiento);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel41);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmb);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCECondicionDeCompra);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel14);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtLeyenda);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel34);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.umeMesImputacion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCAI);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel17);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel16);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uccProximaFechaVencimiento);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneDiasVencimiento);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCESubcuentaImputacion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel13);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCECuentaImputacion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel12);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel10);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uccFechaVencimiento);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel11);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneValorCotizacion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel9);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCETiposDeCambio);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel8);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEMonedas);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaRegistracion);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraMENumero);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableEmision);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCETipoComprobante);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.cldFechaComprobante);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -228);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(870, 221);
            this.ultraExplorerBarContainerControl1.TabIndex = 10;
            this.ultraExplorerBarContainerControl1.Visible = false;
            this.ultraExplorerBarContainerControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraExplorerBarContainerControl1_Paint);
            // 
            // umeMesDevengamiento
            // 
            appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
            this.umeMesDevengamiento.Appearance = appearance1;
            this.umeMesDevengamiento.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.umeMesDevengamiento.InputMask = "mm/yyyy";
            this.umeMesDevengamiento.Location = new System.Drawing.Point(736, 128);
            this.umeMesDevengamiento.Name = "umeMesDevengamiento";
            this.umeMesDevengamiento.Size = new System.Drawing.Size(88, 20);
            this.umeMesDevengamiento.TabIndex = 15;
            this.umeMesDevengamiento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.umeMesDevengamiento.Text = "--";
            // 
            // ultraLabel41
            // 
            this.ultraLabel41.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel41.Location = new System.Drawing.Point(600, 128);
            this.ultraLabel41.Name = "ultraLabel41";
            this.ultraLabel41.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel41.TabIndex = 57;
            this.ultraLabel41.Text = "Mes de Devengamiento";
            // 
            // mzCmb
            // 
            this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmb.DataValue = "";
            this.mzCmb.EnableCtaCte = false;
            this.mzCmb.FastSearch = false;
            this.mzCmb.Location = new System.Drawing.Point(128, 30);
            this.mzCmb.Name = "mzCmb";
            this.mzCmb.SearchObjectListener = null;
            this.mzCmb.Size = new System.Drawing.Size(456, 22);
            this.mzCmb.TabIndex = 1;
            this.mzCmb.Tag = "ResponsableEmision";
            // 
            // mzCECondicionDeCompra
            // 
            this.mzCECondicionDeCompra.AutoComplete = true;
            this.mzCECondicionDeCompra.AutoSize = true;
            this.mzCECondicionDeCompra.DataSource = null;
            this.mzCECondicionDeCompra.DisplayMember = "";
            this.mzCECondicionDeCompra.DisplayMemberCaption = "";
            this.mzCECondicionDeCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCECondicionDeCompra.Location = new System.Drawing.Point(736, 32);
            this.mzCECondicionDeCompra.MaxItemsDisplay = 7;
            this.mzCECondicionDeCompra.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCECondicionDeCompra.Name = "mzCECondicionDeCompra";
            this.mzCECondicionDeCompra.Size = new System.Drawing.Size(128, 21);
            this.mzCECondicionDeCompra.SorterMember = "";
            this.mzCECondicionDeCompra.TabIndex = 10;
            this.mzCECondicionDeCompra.ValueMember = "";
            this.mzCECondicionDeCompra.ValueMemberCaption = "";
            // 
            // ultraLabel14
            // 
            this.ultraLabel14.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel14.Location = new System.Drawing.Point(600, 32);
            this.ultraLabel14.Name = "ultraLabel14";
            this.ultraLabel14.Size = new System.Drawing.Size(104, 16);
            this.ultraLabel14.TabIndex = 55;
            this.ultraLabel14.Text = "Cond. De Pago";
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Location = new System.Drawing.Point(128, 152);
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.Size = new System.Drawing.Size(168, 20);
            this.txtLeyenda.TabIndex = 7;
            // 
            // ultraLabel34
            // 
            this.ultraLabel34.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel34.Location = new System.Drawing.Point(8, 152);
            this.ultraLabel34.Name = "ultraLabel34";
            this.ultraLabel34.Size = new System.Drawing.Size(116, 16);
            this.ultraLabel34.TabIndex = 54;
            this.ultraLabel34.Text = "Leyenda";
            // 
            // umeMesImputacion
            // 
            appearance2.TextHAlign = Infragistics.Win.HAlign.Right;
            this.umeMesImputacion.Appearance = appearance2;
            this.umeMesImputacion.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.umeMesImputacion.InputMask = "mm/yyyy";
            this.umeMesImputacion.Location = new System.Drawing.Point(736, 104);
            this.umeMesImputacion.Name = "umeMesImputacion";
            this.umeMesImputacion.Size = new System.Drawing.Size(88, 20);
            this.umeMesImputacion.TabIndex = 14;
            this.umeMesImputacion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.umeMesImputacion.Text = "--";
            // 
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(128, 128);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.Size = new System.Drawing.Size(168, 20);
            this.txtCAI.TabIndex = 6;
            // 
            // ultraLabel17
            // 
            this.ultraLabel17.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel17.Location = new System.Drawing.Point(8, 128);
            this.ultraLabel17.Name = "ultraLabel17";
            this.ultraLabel17.Size = new System.Drawing.Size(116, 16);
            this.ultraLabel17.TabIndex = 51;
            this.ultraLabel17.Text = "CAI";
            // 
            // ultraLabel16
            // 
            this.ultraLabel16.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel16.Location = new System.Drawing.Point(600, 82);
            this.ultraLabel16.Name = "ultraLabel16";
            this.ultraLabel16.Size = new System.Drawing.Size(136, 16);
            this.ultraLabel16.TabIndex = 48;
            this.ultraLabel16.Text = "Fecha Prox. Venc.";
            // 
            // uccProximaFechaVencimiento
            // 
            dateButton1.Caption = "Today";
            this.uccProximaFechaVencimiento.DateButtons.Add(dateButton1);
            this.uccProximaFechaVencimiento.Location = new System.Drawing.Point(736, 80);
            this.uccProximaFechaVencimiento.Name = "uccProximaFechaVencimiento";
            this.uccProximaFechaVencimiento.NonAutoSizeHeight = 23;
            this.uccProximaFechaVencimiento.Size = new System.Drawing.Size(88, 21);
            this.uccProximaFechaVencimiento.TabIndex = 13;
            this.uccProximaFechaVencimiento.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
            // 
            // uneDiasVencimiento
            // 
            this.uneDiasVencimiento.Location = new System.Drawing.Point(828, 54);
            this.uneDiasVencimiento.MaskInput = "nnn";
            this.uneDiasVencimiento.MaxValue = 999;
            this.uneDiasVencimiento.MinValue = 0;
            this.uneDiasVencimiento.Name = "uneDiasVencimiento";
            this.uneDiasVencimiento.Size = new System.Drawing.Size(36, 21);
            this.uneDiasVencimiento.TabIndex = 12;
            this.uneDiasVencimiento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // mzCESubcuentaImputacion
            // 
            this.mzCESubcuentaImputacion.AutoComplete = true;
            this.mzCESubcuentaImputacion.AutoSize = true;
            this.mzCESubcuentaImputacion.DataSource = null;
            this.mzCESubcuentaImputacion.DisplayMember = "";
            this.mzCESubcuentaImputacion.DisplayMemberCaption = "";
            this.mzCESubcuentaImputacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCESubcuentaImputacion.Location = new System.Drawing.Point(128, 104);
            this.mzCESubcuentaImputacion.MaxItemsDisplay = 7;
            this.mzCESubcuentaImputacion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCESubcuentaImputacion.Name = "mzCESubcuentaImputacion";
            this.mzCESubcuentaImputacion.Size = new System.Drawing.Size(167, 21);
            this.mzCESubcuentaImputacion.SorterMember = "";
            this.mzCESubcuentaImputacion.TabIndex = 5;
            this.mzCESubcuentaImputacion.ValueMember = "";
            this.mzCESubcuentaImputacion.ValueMemberCaption = "";
            // 
            // ultraLabel13
            // 
            this.ultraLabel13.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel13.Location = new System.Drawing.Point(8, 104);
            this.ultraLabel13.Name = "ultraLabel13";
            this.ultraLabel13.Size = new System.Drawing.Size(116, 16);
            this.ultraLabel13.TabIndex = 42;
            this.ultraLabel13.Text = "Subcuenta de Imp.";
            // 
            // mzCECuentaImputacion
            // 
            this.mzCECuentaImputacion.AutoComplete = true;
            this.mzCECuentaImputacion.AutoSize = true;
            this.mzCECuentaImputacion.DataSource = null;
            this.mzCECuentaImputacion.DisplayMember = "";
            this.mzCECuentaImputacion.DisplayMemberCaption = "";
            this.mzCECuentaImputacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCECuentaImputacion.Location = new System.Drawing.Point(128, 80);
            this.mzCECuentaImputacion.MaxItemsDisplay = 7;
            this.mzCECuentaImputacion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCECuentaImputacion.Name = "mzCECuentaImputacion";
            this.mzCECuentaImputacion.Size = new System.Drawing.Size(167, 21);
            this.mzCECuentaImputacion.SorterMember = "";
            this.mzCECuentaImputacion.TabIndex = 4;
            this.mzCECuentaImputacion.ValueMember = "";
            this.mzCECuentaImputacion.ValueMemberCaption = "";
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel12.Location = new System.Drawing.Point(8, 80);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.Size = new System.Drawing.Size(116, 16);
            this.ultraLabel12.TabIndex = 40;
            this.ultraLabel12.Text = "Cuenta de Imputación";
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel10.Location = new System.Drawing.Point(600, 56);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(136, 16);
            this.ultraLabel10.TabIndex = 38;
            this.ultraLabel10.Text = "Fecha de Venc.";
            // 
            // uccFechaVencimiento
            // 
            dateButton2.Caption = "Today";
            this.uccFechaVencimiento.DateButtons.Add(dateButton2);
            this.uccFechaVencimiento.Location = new System.Drawing.Point(736, 54);
            this.uccFechaVencimiento.Name = "uccFechaVencimiento";
            this.uccFechaVencimiento.NonAutoSizeHeight = 23;
            this.uccFechaVencimiento.Size = new System.Drawing.Size(88, 21);
            this.uccFechaVencimiento.TabIndex = 11;
            this.uccFechaVencimiento.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
            // 
            // ultraLabel11
            // 
            this.ultraLabel11.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel11.Location = new System.Drawing.Point(600, 106);
            this.ultraLabel11.Name = "ultraLabel11";
            this.ultraLabel11.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel11.TabIndex = 37;
            this.ultraLabel11.Text = "Mes de imputación";
            // 
            // uneValorCotizacion
            // 
            this.uneValorCotizacion.Location = new System.Drawing.Point(736, 200);
            this.uneValorCotizacion.MinValue = 0;
            this.uneValorCotizacion.Name = "uneValorCotizacion";
            this.uneValorCotizacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneValorCotizacion.Size = new System.Drawing.Size(88, 21);
            this.uneValorCotizacion.TabIndex = 18;
            this.uneValorCotizacion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel9.Location = new System.Drawing.Point(600, 200);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel9.TabIndex = 34;
            this.ultraLabel9.Text = "Cotización";
            // 
            // mzCETiposDeCambio
            // 
            this.mzCETiposDeCambio.AutoComplete = true;
            this.mzCETiposDeCambio.AutoSize = true;
            this.mzCETiposDeCambio.DataSource = null;
            this.mzCETiposDeCambio.DisplayMember = "";
            this.mzCETiposDeCambio.DisplayMemberCaption = "";
            this.mzCETiposDeCambio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCETiposDeCambio.Location = new System.Drawing.Point(736, 176);
            this.mzCETiposDeCambio.MaxItemsDisplay = 7;
            this.mzCETiposDeCambio.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCETiposDeCambio.Name = "mzCETiposDeCambio";
            this.mzCETiposDeCambio.Size = new System.Drawing.Size(128, 21);
            this.mzCETiposDeCambio.SorterMember = "";
            this.mzCETiposDeCambio.TabIndex = 17;
            this.mzCETiposDeCambio.ValueMember = "";
            this.mzCETiposDeCambio.ValueMemberCaption = "";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel8.Location = new System.Drawing.Point(600, 176);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(136, 16);
            this.ultraLabel8.TabIndex = 32;
            this.ultraLabel8.Text = "Tipo de cambio";
            // 
            // mzCEMonedas
            // 
            this.mzCEMonedas.AutoComplete = true;
            this.mzCEMonedas.AutoSize = true;
            this.mzCEMonedas.DataSource = null;
            this.mzCEMonedas.DisplayMember = "";
            this.mzCEMonedas.DisplayMemberCaption = "";
            this.mzCEMonedas.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEMonedas.Location = new System.Drawing.Point(736, 152);
            this.mzCEMonedas.MaxItemsDisplay = 7;
            this.mzCEMonedas.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEMonedas.Name = "mzCEMonedas";
            this.mzCEMonedas.Size = new System.Drawing.Size(128, 21);
            this.mzCEMonedas.SorterMember = "";
            this.mzCEMonedas.TabIndex = 16;
            this.mzCEMonedas.ValueMember = "";
            this.mzCEMonedas.ValueMemberCaption = "";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel7.Location = new System.Drawing.Point(600, 152);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(136, 16);
            this.ultraLabel7.TabIndex = 30;
            this.ultraLabel7.Text = "Moneda Comprobante";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(8, 176);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(96, 16);
            this.ultraLabel4.TabIndex = 27;
            this.ultraLabel4.Text = "Fecha de ingreso";
            // 
            // cldFechaRegistracion
            // 
            dateButton3.Caption = "Today";
            this.cldFechaRegistracion.DateButtons.Add(dateButton3);
            this.cldFechaRegistracion.Location = new System.Drawing.Point(128, 176);
            this.cldFechaRegistracion.Name = "cldFechaRegistracion";
            this.cldFechaRegistracion.NonAutoSizeHeight = 23;
            this.cldFechaRegistracion.Size = new System.Drawing.Size(168, 21);
            this.cldFechaRegistracion.TabIndex = 8;
            this.cldFechaRegistracion.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
            // 
            // ultraMENumero
            // 
            this.ultraMENumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
            this.ultraMENumero.InputMask = "?-####-########";
            this.ultraMENumero.Location = new System.Drawing.Point(360, 56);
            this.ultraMENumero.Name = "ultraMENumero";
            this.ultraMENumero.Size = new System.Drawing.Size(100, 20);
            this.ultraMENumero.TabIndex = 3;
            this.ultraMENumero.Text = "--";
            this.ultraMENumero.Leave += new System.EventHandler(this.ultraMENumero_Leave);
            // 
            // mzCEResponsableEmision
            // 
            this.mzCEResponsableEmision.AutoComplete = true;
            this.mzCEResponsableEmision.AutoSize = true;
            this.mzCEResponsableEmision.DataSource = null;
            this.mzCEResponsableEmision.DisplayMember = "";
            this.mzCEResponsableEmision.DisplayMemberCaption = "";
            this.mzCEResponsableEmision.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableEmision.Location = new System.Drawing.Point(128, 4);
            this.mzCEResponsableEmision.MaxItemsDisplay = 8;
            this.mzCEResponsableEmision.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableEmision.Name = "mzCEResponsableEmision";
            this.mzCEResponsableEmision.Size = new System.Drawing.Size(167, 21);
            this.mzCEResponsableEmision.SorterMember = "";
            this.mzCEResponsableEmision.TabIndex = 0;
            this.mzCEResponsableEmision.ValueMember = "";
            this.mzCEResponsableEmision.ValueMemberCaption = "";
            // 
            // mzCETipoComprobante
            // 
            this.mzCETipoComprobante.AutoComplete = true;
            this.mzCETipoComprobante.AutoSize = true;
            this.mzCETipoComprobante.DataSource = null;
            this.mzCETipoComprobante.DisplayMember = "";
            this.mzCETipoComprobante.DisplayMemberCaption = "";
            this.mzCETipoComprobante.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCETipoComprobante.Location = new System.Drawing.Point(128, 56);
            this.mzCETipoComprobante.MaxItemsDisplay = 7;
            this.mzCETipoComprobante.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCETipoComprobante.Name = "mzCETipoComprobante";
            this.mzCETipoComprobante.Size = new System.Drawing.Size(167, 21);
            this.mzCETipoComprobante.SorterMember = "";
            this.mzCETipoComprobante.TabIndex = 2;
            this.mzCETipoComprobante.ValueMember = "";
            this.mzCETipoComprobante.ValueMemberCaption = "";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(7, 56);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(116, 16);
            this.ultraLabel2.TabIndex = 20;
            this.ultraLabel2.Text = "Tipo de Comprobante";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(8, 6);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel6.TabIndex = 15;
            this.ultraLabel6.Text = "Responsable Emisión";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(8, 32);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
            this.ultraLabel1.TabIndex = 13;
            this.ultraLabel1.Text = "Proveedor";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel3.Location = new System.Drawing.Point(600, 8);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel3.TabIndex = 12;
            this.ultraLabel3.Text = "Fecha de emisión";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel5.Location = new System.Drawing.Point(304, 59);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(104, 16);
            this.ultraLabel5.TabIndex = 10;
            this.ultraLabel5.Text = "Número";
            // 
            // cldFechaComprobante
            // 
            dateButton4.Caption = "Today";
            this.cldFechaComprobante.DateButtons.Add(dateButton4);
            this.cldFechaComprobante.Location = new System.Drawing.Point(736, 8);
            this.cldFechaComprobante.Name = "cldFechaComprobante";
            this.cldFechaComprobante.NonAutoSizeHeight = 23;
            this.cldFechaComprobante.Size = new System.Drawing.Size(88, 21);
            this.cldFechaComprobante.TabIndex = 9;
            this.cldFechaComprobante.Value = new System.DateTime(2005, 1, 28, 0, 0, 0, 0);
            this.cldFechaComprobante.Leave += new System.EventHandler(this.cldFechaComprobante_Leave);
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalDesdeImpuestos);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneDescuentos);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel38);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelSimboloMonedaReferencia);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalUsuarioMonedaReferencia);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel37);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelSimboloMonedaProveedor2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelSimboloMonedaProveedor4);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelSimboloMonedaProveedor3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelSimboloMonedaProveedor1);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelSimboloMonedaProveedor);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalUsuario);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel36);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneImpuestos);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel35);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneNetoConDescuento);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel21);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel20);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.unePorcentajeDescuento);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel19);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneNeto);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraLabel18);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 17);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(870, 104);
            this.ultraExplorerBarContainerControl3.TabIndex = 1;
            // 
            // uneTotalDesdeImpuestos
            // 
            this.uneTotalDesdeImpuestos.Enabled = false;
            this.uneTotalDesdeImpuestos.Location = new System.Drawing.Point(752, 80);
            this.uneTotalDesdeImpuestos.MinValue = 0;
            this.uneTotalDesdeImpuestos.Name = "uneTotalDesdeImpuestos";
            this.uneTotalDesdeImpuestos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalDesdeImpuestos.Size = new System.Drawing.Size(112, 21);
            this.uneTotalDesdeImpuestos.TabIndex = 7;
            this.uneTotalDesdeImpuestos.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneDescuentos
            // 
            this.uneDescuentos.Location = new System.Drawing.Point(128, 31);
            this.uneDescuentos.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.uneDescuentos.MaskInput = "-nnnnnnn.nn";
            this.uneDescuentos.MinValue = -2147483647;
            this.uneDescuentos.Name = "uneDescuentos";
            this.uneDescuentos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneDescuentos.Size = new System.Drawing.Size(112, 21);
            this.uneDescuentos.TabIndex = 1;
            this.uneDescuentos.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(736, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 80;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ultraLabel38
            // 
            this.ultraLabel38.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel38.Location = new System.Drawing.Point(600, 82);
            this.ultraLabel38.Name = "ultraLabel38";
            this.ultraLabel38.Size = new System.Drawing.Size(144, 16);
            this.ultraLabel38.TabIndex = 78;
            this.ultraLabel38.Text = "Total gral desde Impuestos";
            // 
            // labelSimboloMonedaReferencia
            // 
            this.labelSimboloMonedaReferencia.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaReferencia.Location = new System.Drawing.Point(720, 55);
            this.labelSimboloMonedaReferencia.Name = "labelSimboloMonedaReferencia";
            this.labelSimboloMonedaReferencia.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaReferencia.TabIndex = 77;
            this.labelSimboloMonedaReferencia.Text = "$";
            this.labelSimboloMonedaReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneTotalUsuarioMonedaReferencia
            // 
            this.uneTotalUsuarioMonedaReferencia.Location = new System.Drawing.Point(752, 53);
            this.uneTotalUsuarioMonedaReferencia.MinValue = 0;
            this.uneTotalUsuarioMonedaReferencia.Name = "uneTotalUsuarioMonedaReferencia";
            this.uneTotalUsuarioMonedaReferencia.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalUsuarioMonedaReferencia.Size = new System.Drawing.Size(112, 21);
            this.uneTotalUsuarioMonedaReferencia.TabIndex = 6;
            this.uneTotalUsuarioMonedaReferencia.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel37
            // 
            this.ultraLabel37.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel37.Location = new System.Drawing.Point(600, 55);
            this.ultraLabel37.Name = "ultraLabel37";
            this.ultraLabel37.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel37.TabIndex = 76;
            this.ultraLabel37.Text = "Total gral Mon Ref.";
            // 
            // labelSimboloMonedaProveedor2
            // 
            this.labelSimboloMonedaProveedor2.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor2.Location = new System.Drawing.Point(96, 55);
            this.labelSimboloMonedaProveedor2.Name = "labelSimboloMonedaProveedor2";
            this.labelSimboloMonedaProveedor2.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaProveedor2.TabIndex = 74;
            this.labelSimboloMonedaProveedor2.Text = "$";
            this.labelSimboloMonedaProveedor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaProveedor4
            // 
            this.labelSimboloMonedaProveedor4.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor4.Location = new System.Drawing.Point(720, 33);
            this.labelSimboloMonedaProveedor4.Name = "labelSimboloMonedaProveedor4";
            this.labelSimboloMonedaProveedor4.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaProveedor4.TabIndex = 73;
            this.labelSimboloMonedaProveedor4.Text = "$";
            this.labelSimboloMonedaProveedor4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaProveedor3
            // 
            this.labelSimboloMonedaProveedor3.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor3.Location = new System.Drawing.Point(720, 10);
            this.labelSimboloMonedaProveedor3.Name = "labelSimboloMonedaProveedor3";
            this.labelSimboloMonedaProveedor3.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaProveedor3.TabIndex = 72;
            this.labelSimboloMonedaProveedor3.Text = "$";
            this.labelSimboloMonedaProveedor3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaProveedor1
            // 
            this.labelSimboloMonedaProveedor1.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor1.Location = new System.Drawing.Point(96, 33);
            this.labelSimboloMonedaProveedor1.Name = "labelSimboloMonedaProveedor1";
            this.labelSimboloMonedaProveedor1.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaProveedor1.TabIndex = 71;
            this.labelSimboloMonedaProveedor1.Text = "$";
            this.labelSimboloMonedaProveedor1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimboloMonedaProveedor
            // 
            this.labelSimboloMonedaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor.Location = new System.Drawing.Point(96, 10);
            this.labelSimboloMonedaProveedor.Name = "labelSimboloMonedaProveedor";
            this.labelSimboloMonedaProveedor.Size = new System.Drawing.Size(32, 16);
            this.labelSimboloMonedaProveedor.TabIndex = 70;
            this.labelSimboloMonedaProveedor.Text = "$";
            this.labelSimboloMonedaProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uneTotalUsuario
            // 
            this.uneTotalUsuario.Location = new System.Drawing.Point(752, 31);
            this.uneTotalUsuario.MinValue = 0;
            this.uneTotalUsuario.Name = "uneTotalUsuario";
            this.uneTotalUsuario.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalUsuario.Size = new System.Drawing.Size(112, 21);
            this.uneTotalUsuario.TabIndex = 5;
            this.uneTotalUsuario.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel36
            // 
            this.ultraLabel36.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel36.Location = new System.Drawing.Point(600, 33);
            this.ultraLabel36.Name = "ultraLabel36";
            this.ultraLabel36.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel36.TabIndex = 46;
            this.ultraLabel36.Text = "Total general";
            // 
            // uneImpuestos
            // 
            this.uneImpuestos.Location = new System.Drawing.Point(752, 8);
            this.uneImpuestos.MinValue = 0;
            this.uneImpuestos.Name = "uneImpuestos";
            this.uneImpuestos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneImpuestos.Size = new System.Drawing.Size(112, 21);
            this.uneImpuestos.TabIndex = 4;
            this.uneImpuestos.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel35
            // 
            this.ultraLabel35.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel35.Location = new System.Drawing.Point(600, 10);
            this.ultraLabel35.Name = "ultraLabel35";
            this.ultraLabel35.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel35.TabIndex = 44;
            this.ultraLabel35.Text = "Impuestos";
            // 
            // uneNetoConDescuento
            // 
            this.uneNetoConDescuento.Location = new System.Drawing.Point(128, 53);
            this.uneNetoConDescuento.MinValue = 0;
            this.uneNetoConDescuento.Name = "uneNetoConDescuento";
            this.uneNetoConDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneNetoConDescuento.Size = new System.Drawing.Size(112, 21);
            this.uneNetoConDescuento.TabIndex = 3;
            this.uneNetoConDescuento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel21
            // 
            this.ultraLabel21.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel21.Location = new System.Drawing.Point(16, 55);
            this.ultraLabel21.Name = "ultraLabel21";
            this.ultraLabel21.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel21.TabIndex = 42;
            this.ultraLabel21.Text = "Neto";
            // 
            // ultraLabel20
            // 
            this.ultraLabel20.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel20.Location = new System.Drawing.Point(296, 33);
            this.ultraLabel20.Name = "ultraLabel20";
            this.ultraLabel20.Size = new System.Drawing.Size(24, 16);
            this.ultraLabel20.TabIndex = 40;
            this.ultraLabel20.Text = "%";
            // 
            // unePorcentajeDescuento
            // 
            this.unePorcentajeDescuento.Location = new System.Drawing.Point(240, 31);
            this.unePorcentajeDescuento.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
            this.unePorcentajeDescuento.MaskInput = "-nnnn.nn";
            this.unePorcentajeDescuento.MaxValue = 9999;
            this.unePorcentajeDescuento.MinValue = -9999;
            this.unePorcentajeDescuento.Name = "unePorcentajeDescuento";
            this.unePorcentajeDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcentajeDescuento.Size = new System.Drawing.Size(56, 21);
            this.unePorcentajeDescuento.TabIndex = 2;
            this.unePorcentajeDescuento.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel19
            // 
            this.ultraLabel19.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel19.Location = new System.Drawing.Point(16, 33);
            this.ultraLabel19.Name = "ultraLabel19";
            this.ultraLabel19.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel19.TabIndex = 38;
            this.ultraLabel19.Text = "Desc/Rec";
            // 
            // uneNeto
            // 
            this.uneNeto.Location = new System.Drawing.Point(128, 8);
            this.uneNeto.MinValue = 0;
            this.uneNeto.Name = "uneNeto";
            this.uneNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneNeto.Size = new System.Drawing.Size(112, 21);
            this.uneNeto.TabIndex = 0;
            this.uneNeto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // ultraLabel18
            // 
            this.ultraLabel18.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel18.Location = new System.Drawing.Point(16, 10);
            this.ultraLabel18.Name = "ultraLabel18";
            this.ultraLabel18.Size = new System.Drawing.Size(128, 16);
            this.ultraLabel18.TabIndex = 36;
            this.ultraLabel18.Text = "Neto Bruto";
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.ultraLabel15);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotalGeneral);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.unePorcentajeDescuentoGeneral);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.uneDescuentoGeneral);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.uneTotal);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.groupBox2);
            this.ultraExplorerBarContainerControl4.Controls.Add(this.groupBox1);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 180);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(870, 448);
            this.ultraExplorerBarContainerControl4.TabIndex = 4;
            // 
            // ultraLabel15
            // 
            this.ultraLabel15.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel15.Location = new System.Drawing.Point(704, 416);
            this.ultraLabel15.Name = "ultraLabel15";
            this.ultraLabel15.Size = new System.Drawing.Size(24, 16);
            this.ultraLabel15.TabIndex = 55;
            this.ultraLabel15.Text = "%";
            // 
            // uneTotalGeneral
            // 
            appearance3.BackColor = System.Drawing.Color.Transparent;
            this.uneTotalGeneral.Appearance = appearance3;
            this.uneTotalGeneral.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            this.uneTotalGeneral.Enabled = false;
            this.uneTotalGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uneTotalGeneral.Location = new System.Drawing.Point(376, 416);
            this.uneTotalGeneral.Name = "uneTotalGeneral";
            this.uneTotalGeneral.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalGeneral.PromptChar = ' ';
            this.uneTotalGeneral.ReadOnly = true;
            this.uneTotalGeneral.Size = new System.Drawing.Size(120, 27);
            this.uneTotalGeneral.TabIndex = 16;
            this.uneTotalGeneral.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.uneTotalGeneral.TabStop = false;
            // 
            // unePorcentajeDescuentoGeneral
            // 
            this.unePorcentajeDescuentoGeneral.Location = new System.Drawing.Point(640, 416);
            this.unePorcentajeDescuentoGeneral.MaskInput = "-nnnn.nn";
            this.unePorcentajeDescuentoGeneral.MaxValue = 9999;
            this.unePorcentajeDescuentoGeneral.MinValue = -9999;
            this.unePorcentajeDescuentoGeneral.Name = "unePorcentajeDescuentoGeneral";
            this.unePorcentajeDescuentoGeneral.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcentajeDescuentoGeneral.Size = new System.Drawing.Size(56, 21);
            this.unePorcentajeDescuentoGeneral.TabIndex = 18;
            this.unePorcentajeDescuentoGeneral.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneDescuentoGeneral
            // 
            this.uneDescuentoGeneral.Location = new System.Drawing.Point(520, 416);
            this.uneDescuentoGeneral.MaskInput = "-nnnnnnn.nn";
            this.uneDescuentoGeneral.MinValue = -2147483647;
            this.uneDescuentoGeneral.Name = "uneDescuentoGeneral";
            this.uneDescuentoGeneral.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneDescuentoGeneral.Size = new System.Drawing.Size(112, 21);
            this.uneDescuentoGeneral.TabIndex = 17;
            this.uneDescuentoGeneral.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneTotal
            // 
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.uneTotal.Appearance = appearance4;
            this.uneTotal.BorderStyle = Infragistics.Win.UIElementBorderStyle.None;
            this.uneTotal.Enabled = false;
            this.uneTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uneTotal.Location = new System.Drawing.Point(736, 416);
            this.uneTotal.Name = "uneTotal";
            this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotal.PromptChar = ' ';
            this.uneTotal.ReadOnly = true;
            this.uneTotal.Size = new System.Drawing.Size(120, 27);
            this.uneTotal.TabIndex = 19;
            this.uneTotal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.uneTotal.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.labelSimboloMonedaProveedor6);
            this.groupBox2.Controls.Add(this.ultraLabel33);
            this.groupBox2.Controls.Add(this.mzCEImpuestoAplicadoConceptoNOGravado);
            this.groupBox2.Controls.Add(this.utbAgregarConceptoNOGravado);
            this.groupBox2.Controls.Add(this.ultraLabel28);
            this.groupBox2.Controls.Add(this.ultraLabel29);
            this.groupBox2.Controls.Add(this.ultraLabel30);
            this.groupBox2.Controls.Add(this.ultraLabel31);
            this.groupBox2.Controls.Add(this.ultraLabel32);
            this.groupBox2.Controls.Add(this.uneTotalConceptoNOGravado);
            this.groupBox2.Controls.Add(this.uneValorImpuestoAplicadoConceptoNOGravado);
            this.groupBox2.Controls.Add(this.unePorcentajeImpuestoAplicadoConceptoNOGravado);
            this.groupBox2.Controls.Add(this.uneConceptoNOGravadoAplicado);
            this.groupBox2.Controls.Add(this.mzCEConceptosNOGravados);
            this.groupBox2.Controls.Add(this.gridOtrosConceptos);
            this.groupBox2.Location = new System.Drawing.Point(8, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 200);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conceptos NO Gravados";
            // 
            // labelSimboloMonedaProveedor6
            // 
            this.labelSimboloMonedaProveedor6.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor6.Location = new System.Drawing.Point(344, 34);
            this.labelSimboloMonedaProveedor6.Name = "labelSimboloMonedaProveedor6";
            this.labelSimboloMonedaProveedor6.Size = new System.Drawing.Size(24, 16);
            this.labelSimboloMonedaProveedor6.TabIndex = 79;
            this.labelSimboloMonedaProveedor6.Text = "$";
            this.labelSimboloMonedaProveedor6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ultraLabel33
            // 
            this.ultraLabel33.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel33.Location = new System.Drawing.Point(176, 16);
            this.ultraLabel33.Name = "ultraLabel33";
            this.ultraLabel33.Size = new System.Drawing.Size(160, 16);
            this.ultraLabel33.TabIndex = 52;
            this.ultraLabel33.Text = "Impuesto Aplicado";
            // 
            // mzCEImpuestoAplicadoConceptoNOGravado
            // 
            this.mzCEImpuestoAplicadoConceptoNOGravado.AutoComplete = true;
            this.mzCEImpuestoAplicadoConceptoNOGravado.AutoSize = true;
            this.mzCEImpuestoAplicadoConceptoNOGravado.DataSource = null;
            this.mzCEImpuestoAplicadoConceptoNOGravado.DisplayMember = "";
            this.mzCEImpuestoAplicadoConceptoNOGravado.DisplayMemberCaption = "";
            this.mzCEImpuestoAplicadoConceptoNOGravado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEImpuestoAplicadoConceptoNOGravado.Location = new System.Drawing.Point(176, 32);
            this.mzCEImpuestoAplicadoConceptoNOGravado.MaxItemsDisplay = 7;
            this.mzCEImpuestoAplicadoConceptoNOGravado.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEImpuestoAplicadoConceptoNOGravado.Name = "mzCEImpuestoAplicadoConceptoNOGravado";
            this.mzCEImpuestoAplicadoConceptoNOGravado.Size = new System.Drawing.Size(167, 21);
            this.mzCEImpuestoAplicadoConceptoNOGravado.SorterMember = "";
            this.mzCEImpuestoAplicadoConceptoNOGravado.TabIndex = 9;
            this.mzCEImpuestoAplicadoConceptoNOGravado.ValueMember = "";
            this.mzCEImpuestoAplicadoConceptoNOGravado.ValueMemberCaption = "";
            // 
            // utbAgregarConceptoNOGravado
            // 
            this.utbAgregarConceptoNOGravado.Location = new System.Drawing.Point(760, 31);
            this.utbAgregarConceptoNOGravado.Name = "utbAgregarConceptoNOGravado";
            this.utbAgregarConceptoNOGravado.Size = new System.Drawing.Size(88, 23);
            this.utbAgregarConceptoNOGravado.TabIndex = 14;
            this.utbAgregarConceptoNOGravado.Text = "&Agregar";
            // 
            // ultraLabel28
            // 
            this.ultraLabel28.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel28.Location = new System.Drawing.Point(648, 16);
            this.ultraLabel28.Name = "ultraLabel28";
            this.ultraLabel28.Size = new System.Drawing.Size(112, 16);
            this.ultraLabel28.TabIndex = 49;
            this.ultraLabel28.Text = "Total";
            // 
            // ultraLabel29
            // 
            this.ultraLabel29.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel29.Location = new System.Drawing.Point(536, 16);
            this.ultraLabel29.Name = "ultraLabel29";
            this.ultraLabel29.Size = new System.Drawing.Size(112, 16);
            this.ultraLabel29.TabIndex = 48;
            this.ultraLabel29.Text = "$ Impuesto";
            // 
            // ultraLabel30
            // 
            this.ultraLabel30.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel30.Location = new System.Drawing.Point(480, 16);
            this.ultraLabel30.Name = "ultraLabel30";
            this.ultraLabel30.Size = new System.Drawing.Size(48, 16);
            this.ultraLabel30.TabIndex = 47;
            this.ultraLabel30.Text = "% Imp.";
            // 
            // ultraLabel31
            // 
            this.ultraLabel31.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel31.Location = new System.Drawing.Point(368, 16);
            this.ultraLabel31.Name = "ultraLabel31";
            this.ultraLabel31.Size = new System.Drawing.Size(112, 16);
            this.ultraLabel31.TabIndex = 46;
            this.ultraLabel31.Text = "Neto Aplicado";
            // 
            // ultraLabel32
            // 
            this.ultraLabel32.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel32.Location = new System.Drawing.Point(8, 16);
            this.ultraLabel32.Name = "ultraLabel32";
            this.ultraLabel32.Size = new System.Drawing.Size(160, 16);
            this.ultraLabel32.TabIndex = 45;
            this.ultraLabel32.Text = "Concepto Aplicado";
            // 
            // uneTotalConceptoNOGravado
            // 
            this.uneTotalConceptoNOGravado.Location = new System.Drawing.Point(648, 32);
            this.uneTotalConceptoNOGravado.MinValue = 0;
            this.uneTotalConceptoNOGravado.Name = "uneTotalConceptoNOGravado";
            this.uneTotalConceptoNOGravado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalConceptoNOGravado.Size = new System.Drawing.Size(112, 21);
            this.uneTotalConceptoNOGravado.TabIndex = 13;
            this.uneTotalConceptoNOGravado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneValorImpuestoAplicadoConceptoNOGravado
            // 
            this.uneValorImpuestoAplicadoConceptoNOGravado.Location = new System.Drawing.Point(536, 32);
            this.uneValorImpuestoAplicadoConceptoNOGravado.MinValue = 0;
            this.uneValorImpuestoAplicadoConceptoNOGravado.Name = "uneValorImpuestoAplicadoConceptoNOGravado";
            this.uneValorImpuestoAplicadoConceptoNOGravado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneValorImpuestoAplicadoConceptoNOGravado.Size = new System.Drawing.Size(112, 21);
            this.uneValorImpuestoAplicadoConceptoNOGravado.TabIndex = 12;
            this.uneValorImpuestoAplicadoConceptoNOGravado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePorcentajeImpuestoAplicadoConceptoNOGravado
            // 
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.Location = new System.Drawing.Point(480, 32);
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.MaskInput = "nnnn.nn";
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.MinValue = 0;
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.Name = "unePorcentajeImpuestoAplicadoConceptoNOGravado";
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.Size = new System.Drawing.Size(56, 21);
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.TabIndex = 11;
            this.unePorcentajeImpuestoAplicadoConceptoNOGravado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneConceptoNOGravadoAplicado
            // 
            this.uneConceptoNOGravadoAplicado.Location = new System.Drawing.Point(368, 32);
            this.uneConceptoNOGravadoAplicado.MinValue = 0;
            this.uneConceptoNOGravadoAplicado.Name = "uneConceptoNOGravadoAplicado";
            this.uneConceptoNOGravadoAplicado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneConceptoNOGravadoAplicado.Size = new System.Drawing.Size(112, 21);
            this.uneConceptoNOGravadoAplicado.TabIndex = 10;
            this.uneConceptoNOGravadoAplicado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // mzCEConceptosNOGravados
            // 
            this.mzCEConceptosNOGravados.AutoComplete = true;
            this.mzCEConceptosNOGravados.AutoSize = true;
            this.mzCEConceptosNOGravados.DataSource = null;
            this.mzCEConceptosNOGravados.DisplayMember = "";
            this.mzCEConceptosNOGravados.DisplayMemberCaption = "";
            this.mzCEConceptosNOGravados.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEConceptosNOGravados.Location = new System.Drawing.Point(8, 32);
            this.mzCEConceptosNOGravados.MaxItemsDisplay = 7;
            this.mzCEConceptosNOGravados.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEConceptosNOGravados.Name = "mzCEConceptosNOGravados";
            this.mzCEConceptosNOGravados.Size = new System.Drawing.Size(167, 21);
            this.mzCEConceptosNOGravados.SorterMember = "";
            this.mzCEConceptosNOGravados.TabIndex = 8;
            this.mzCEConceptosNOGravados.ValueMember = "";
            this.mzCEConceptosNOGravados.ValueMemberCaption = "";
            // 
            // gridOtrosConceptos
            // 
            this.gridOtrosConceptos.AllowCardSizing = false;
            this.gridOtrosConceptos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridOtrosConceptos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridOtrosConceptos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridOtrosConceptos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridOtrosConceptos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridOtrosConceptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridOtrosConceptos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridOtrosConceptos.Location = new System.Drawing.Point(8, 56);
            this.gridOtrosConceptos.Name = "gridOtrosConceptos";
            this.gridOtrosConceptos.Size = new System.Drawing.Size(840, 136);
            this.gridOtrosConceptos.TabIndex = 15;
            this.gridOtrosConceptos.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelSimboloMonedaProveedor5);
            this.groupBox1.Controls.Add(this.utbAgregarNetoGravado);
            this.groupBox1.Controls.Add(this.ultraLabel27);
            this.groupBox1.Controls.Add(this.ultraLabel26);
            this.groupBox1.Controls.Add(this.ultraLabel25);
            this.groupBox1.Controls.Add(this.ultraLabel24);
            this.groupBox1.Controls.Add(this.ultraLabel23);
            this.groupBox1.Controls.Add(this.ultraLabel22);
            this.groupBox1.Controls.Add(this.uneTotalNetoGravado);
            this.groupBox1.Controls.Add(this.uneValorImpuestoAplicadoNetoGravado);
            this.groupBox1.Controls.Add(this.unePorcentajeImpuestoAplicadoNetoGravado);
            this.groupBox1.Controls.Add(this.uneNetoGravadoAplicado);
            this.groupBox1.Controls.Add(this.mzCEImpuestoAplicadoNetoGravado);
            this.groupBox1.Controls.Add(this.mzCETipoDeNetoGravados);
            this.groupBox1.Controls.Add(this.gridNetosGravados);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 200);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Netos Gravados";
            // 
            // labelSimboloMonedaProveedor5
            // 
            this.labelSimboloMonedaProveedor5.BackColor = System.Drawing.Color.Transparent;
            this.labelSimboloMonedaProveedor5.Location = new System.Drawing.Point(344, 34);
            this.labelSimboloMonedaProveedor5.Name = "labelSimboloMonedaProveedor5";
            this.labelSimboloMonedaProveedor5.Size = new System.Drawing.Size(24, 16);
            this.labelSimboloMonedaProveedor5.TabIndex = 78;
            this.labelSimboloMonedaProveedor5.Text = "$";
            this.labelSimboloMonedaProveedor5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // utbAgregarNetoGravado
            // 
            this.utbAgregarNetoGravado.Location = new System.Drawing.Point(760, 31);
            this.utbAgregarNetoGravado.Name = "utbAgregarNetoGravado";
            this.utbAgregarNetoGravado.Size = new System.Drawing.Size(88, 23);
            this.utbAgregarNetoGravado.TabIndex = 6;
            this.utbAgregarNetoGravado.Text = "&Agregar";
            // 
            // ultraLabel27
            // 
            this.ultraLabel27.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel27.Location = new System.Drawing.Point(648, 16);
            this.ultraLabel27.Name = "ultraLabel27";
            this.ultraLabel27.Size = new System.Drawing.Size(112, 16);
            this.ultraLabel27.TabIndex = 49;
            this.ultraLabel27.Text = "Total";
            // 
            // ultraLabel26
            // 
            this.ultraLabel26.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel26.Location = new System.Drawing.Point(536, 16);
            this.ultraLabel26.Name = "ultraLabel26";
            this.ultraLabel26.Size = new System.Drawing.Size(112, 16);
            this.ultraLabel26.TabIndex = 48;
            this.ultraLabel26.Text = "$ Impuesto";
            // 
            // ultraLabel25
            // 
            this.ultraLabel25.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel25.Location = new System.Drawing.Point(480, 16);
            this.ultraLabel25.Name = "ultraLabel25";
            this.ultraLabel25.Size = new System.Drawing.Size(48, 16);
            this.ultraLabel25.TabIndex = 47;
            this.ultraLabel25.Text = "% Imp.";
            // 
            // ultraLabel24
            // 
            this.ultraLabel24.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel24.Location = new System.Drawing.Point(368, 16);
            this.ultraLabel24.Name = "ultraLabel24";
            this.ultraLabel24.Size = new System.Drawing.Size(112, 16);
            this.ultraLabel24.TabIndex = 46;
            this.ultraLabel24.Text = "Neto Aplicado";
            // 
            // ultraLabel23
            // 
            this.ultraLabel23.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel23.Location = new System.Drawing.Point(176, 16);
            this.ultraLabel23.Name = "ultraLabel23";
            this.ultraLabel23.Size = new System.Drawing.Size(160, 16);
            this.ultraLabel23.TabIndex = 45;
            this.ultraLabel23.Text = "Impuesto Aplicado";
            // 
            // ultraLabel22
            // 
            this.ultraLabel22.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel22.Location = new System.Drawing.Point(8, 16);
            this.ultraLabel22.Name = "ultraLabel22";
            this.ultraLabel22.Size = new System.Drawing.Size(160, 16);
            this.ultraLabel22.TabIndex = 44;
            this.ultraLabel22.Text = "Tipo de Neto";
            // 
            // uneTotalNetoGravado
            // 
            this.uneTotalNetoGravado.Location = new System.Drawing.Point(648, 32);
            this.uneTotalNetoGravado.MinValue = 0;
            this.uneTotalNetoGravado.Name = "uneTotalNetoGravado";
            this.uneTotalNetoGravado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneTotalNetoGravado.Size = new System.Drawing.Size(112, 21);
            this.uneTotalNetoGravado.TabIndex = 5;
            this.uneTotalNetoGravado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneValorImpuestoAplicadoNetoGravado
            // 
            this.uneValorImpuestoAplicadoNetoGravado.Location = new System.Drawing.Point(536, 32);
            this.uneValorImpuestoAplicadoNetoGravado.MinValue = 0;
            this.uneValorImpuestoAplicadoNetoGravado.Name = "uneValorImpuestoAplicadoNetoGravado";
            this.uneValorImpuestoAplicadoNetoGravado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneValorImpuestoAplicadoNetoGravado.Size = new System.Drawing.Size(112, 21);
            this.uneValorImpuestoAplicadoNetoGravado.TabIndex = 4;
            this.uneValorImpuestoAplicadoNetoGravado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // unePorcentajeImpuestoAplicadoNetoGravado
            // 
            this.unePorcentajeImpuestoAplicadoNetoGravado.Location = new System.Drawing.Point(480, 32);
            this.unePorcentajeImpuestoAplicadoNetoGravado.MaskInput = "nnnn.nn";
            this.unePorcentajeImpuestoAplicadoNetoGravado.MinValue = 0;
            this.unePorcentajeImpuestoAplicadoNetoGravado.Name = "unePorcentajeImpuestoAplicadoNetoGravado";
            this.unePorcentajeImpuestoAplicadoNetoGravado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePorcentajeImpuestoAplicadoNetoGravado.Size = new System.Drawing.Size(56, 21);
            this.unePorcentajeImpuestoAplicadoNetoGravado.TabIndex = 3;
            this.unePorcentajeImpuestoAplicadoNetoGravado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneNetoGravadoAplicado
            // 
            this.uneNetoGravadoAplicado.Location = new System.Drawing.Point(368, 32);
            this.uneNetoGravadoAplicado.MinValue = 0;
            this.uneNetoGravadoAplicado.Name = "uneNetoGravadoAplicado";
            this.uneNetoGravadoAplicado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneNetoGravadoAplicado.Size = new System.Drawing.Size(112, 21);
            this.uneNetoGravadoAplicado.TabIndex = 2;
            this.uneNetoGravadoAplicado.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // mzCEImpuestoAplicadoNetoGravado
            // 
            this.mzCEImpuestoAplicadoNetoGravado.AutoComplete = true;
            this.mzCEImpuestoAplicadoNetoGravado.AutoSize = true;
            this.mzCEImpuestoAplicadoNetoGravado.DataSource = null;
            this.mzCEImpuestoAplicadoNetoGravado.DisplayMember = "";
            this.mzCEImpuestoAplicadoNetoGravado.DisplayMemberCaption = "";
            this.mzCEImpuestoAplicadoNetoGravado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEImpuestoAplicadoNetoGravado.Location = new System.Drawing.Point(176, 32);
            this.mzCEImpuestoAplicadoNetoGravado.MaxItemsDisplay = 7;
            this.mzCEImpuestoAplicadoNetoGravado.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEImpuestoAplicadoNetoGravado.Name = "mzCEImpuestoAplicadoNetoGravado";
            this.mzCEImpuestoAplicadoNetoGravado.Size = new System.Drawing.Size(167, 21);
            this.mzCEImpuestoAplicadoNetoGravado.SorterMember = "";
            this.mzCEImpuestoAplicadoNetoGravado.TabIndex = 1;
            this.mzCEImpuestoAplicadoNetoGravado.ValueMember = "";
            this.mzCEImpuestoAplicadoNetoGravado.ValueMemberCaption = "";
            // 
            // mzCETipoDeNetoGravados
            // 
            this.mzCETipoDeNetoGravados.AutoComplete = true;
            this.mzCETipoDeNetoGravados.AutoSize = true;
            this.mzCETipoDeNetoGravados.DataSource = null;
            this.mzCETipoDeNetoGravados.DisplayMember = "";
            this.mzCETipoDeNetoGravados.DisplayMemberCaption = "";
            this.mzCETipoDeNetoGravados.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCETipoDeNetoGravados.Location = new System.Drawing.Point(8, 32);
            this.mzCETipoDeNetoGravados.MaxItemsDisplay = 7;
            this.mzCETipoDeNetoGravados.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCETipoDeNetoGravados.Name = "mzCETipoDeNetoGravados";
            this.mzCETipoDeNetoGravados.Size = new System.Drawing.Size(167, 21);
            this.mzCETipoDeNetoGravados.SorterMember = "";
            this.mzCETipoDeNetoGravados.TabIndex = 0;
            this.mzCETipoDeNetoGravados.ValueMember = "";
            this.mzCETipoDeNetoGravados.ValueMemberCaption = "";
            // 
            // gridNetosGravados
            // 
            this.gridNetosGravados.AllowCardSizing = false;
            this.gridNetosGravados.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridNetosGravados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridNetosGravados.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridNetosGravados.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridNetosGravados.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridNetosGravados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridNetosGravados.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridNetosGravados.Location = new System.Drawing.Point(8, 56);
            this.gridNetosGravados.Name = "gridNetosGravados";
            this.gridNetosGravados.Size = new System.Drawing.Size(840, 136);
            this.gridNetosGravados.TabIndex = 7;
            this.gridNetosGravados.TabStop = false;
            // 
            // ultraExplorerBarContainerControl5
            // 
            this.ultraExplorerBarContainerControl5.Controls.Add(this.mzProductosControl);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel40);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel39);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.uneNetoItems);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.uneNetoItemsReal);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.gridManagerView1);
            this.ultraExplorerBarContainerControl5.Controls.Add(this.gridProductos);
            this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 220);
            this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
            this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(870, 231);
            this.ultraExplorerBarContainerControl5.TabIndex = 5;
            // 
            // mzProductosControl
            // 
            this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl.EnabledCantidad = false;
            this.mzProductosControl.EnabledListaDePrecio = true;
            this.mzProductosControl.Location = new System.Drawing.Point(16, 152);
            this.mzProductosControl.Name = "mzProductosControl";
            this.mzProductosControl.Size = new System.Drawing.Size(608, 80);
            this.mzProductosControl.TabIndex = 1;
            this.mzProductosControl.VisibleCantidad = true;
            this.mzProductosControl.VisibleComboListaDePrecios = true;
            this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl.VisiblePrecios = true;
            // 
            // ultraLabel40
            // 
            this.ultraLabel40.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel40.Location = new System.Drawing.Point(728, 192);
            this.ultraLabel40.Name = "ultraLabel40";
            this.ultraLabel40.Size = new System.Drawing.Size(32, 16);
            this.ultraLabel40.TabIndex = 57;
            this.ultraLabel40.Text = "Neto";
            // 
            // ultraLabel39
            // 
            this.ultraLabel39.BackColor = System.Drawing.Color.Transparent;
            this.ultraLabel39.Location = new System.Drawing.Point(688, 160);
            this.ultraLabel39.Name = "ultraLabel39";
            this.ultraLabel39.Size = new System.Drawing.Size(72, 16);
            this.ultraLabel39.TabIndex = 56;
            this.ultraLabel39.Text = "Neto Original";
            // 
            // uneNetoItems
            // 
            this.uneNetoItems.Location = new System.Drawing.Point(768, 184);
            this.uneNetoItems.MinValue = 0;
            this.uneNetoItems.Name = "uneNetoItems";
            this.uneNetoItems.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneNetoItems.Size = new System.Drawing.Size(88, 21);
            this.uneNetoItems.TabIndex = 3;
            this.uneNetoItems.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // uneNetoItemsReal
            // 
            this.uneNetoItemsReal.Location = new System.Drawing.Point(768, 156);
            this.uneNetoItemsReal.MinValue = 0;
            this.uneNetoItemsReal.Name = "uneNetoItemsReal";
            this.uneNetoItemsReal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneNetoItemsReal.Size = new System.Drawing.Size(88, 21);
            this.uneNetoItemsReal.TabIndex = 2;
            this.uneNetoItemsReal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // gridManagerView1
            // 
            this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
            this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerView1.Name = "gridManagerView1";
            this.gridManagerView1.Size = new System.Drawing.Size(864, 24);
            this.gridManagerView1.TabIndex = 4;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowCardSizing = false;
            this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductos.Location = new System.Drawing.Point(16, 0);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(840, 152);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.TabStop = false;
            // 
            // ultraExplorerBarContainerControl6
            // 
            this.ultraExplorerBarContainerControl6.Controls.Add(this.txtObservaciones);
            this.ultraExplorerBarContainerControl6.Location = new System.Drawing.Point(28, 483);
            this.ultraExplorerBarContainerControl6.Name = "ultraExplorerBarContainerControl6";
            this.ultraExplorerBarContainerControl6.Size = new System.Drawing.Size(870, 136);
            this.ultraExplorerBarContainerControl6.TabIndex = 6;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.AcceptsReturn = true;
            this.txtObservaciones.AcceptsTab = true;
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.AutoSize = true;
            this.txtObservaciones.Location = new System.Drawing.Point(16, 0);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(840, 128);
            this.txtObservaciones.TabIndex = 0;
            // 
            // imglStandar
            // 
            this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            this.imglStandar.Images.SetKeyName(0, "");
            this.imglStandar.Images.SetKeyName(1, "");
            this.imglStandar.Images.SetKeyName(2, "");
            this.imglStandar.Images.SetKeyName(3, "");
            this.imglStandar.Images.SetKeyName(4, "");
            this.imglStandar.Images.SetKeyName(5, "");
            this.imglStandar.Images.SetKeyName(6, "");
            this.imglStandar.Images.SetKeyName(7, "");
            this.imglStandar.Images.SetKeyName(8, "");
            this.imglStandar.Images.SetKeyName(9, "");
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
            this.toolBarStandar.Size = new System.Drawing.Size(936, 28);
            this.toolBarStandar.TabIndex = 23;
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
            this.tbbCancelar.Text = "Cancelar";
            // 
            // ultraExplorerBar
            // 
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl5);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl6);
            this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Key = "Tarea";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 28;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup2.Key = "Cabecera";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 221;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Datos de Cabecera";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup3.Key = "Netos";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 104;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Netos y totales";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup4.Key = "Impuestos";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 448;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Impuestos";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl5;
            ultraExplorerBarGroup5.Key = "Items";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 231;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Items";
            ultraExplorerBarGroup6.Container = this.ultraExplorerBarContainerControl6;
            ultraExplorerBarGroup6.Key = "Observaciones";
            ultraExplorerBarGroup6.Settings.ContainerHeight = 136;
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Observaciones";
            this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5,
            ultraExplorerBarGroup6});
            this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar.Name = "ultraExplorerBar"; this.ultraExplorerBar.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
            this.ultraExplorerBar.Size = new System.Drawing.Size(936, 466);
            this.ultraExplorerBar.TabIndex = 24;
            this.ultraExplorerBar.TabStop = false;
            // 
            // FrmCabeceraComprobanteDeCompra
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(936, 494);
            this.Controls.Add(this.ultraExplorerBar);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmCabeceraComprobanteDeCompra";
            this.Text = "FrmCabeceraComprobanteDeCompra";
            this.Load += new System.EventHandler(this.FrmCabeceraComprobanteDeCompra_Load);
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionDeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccProximaFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCESubcuentaImputacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECuentaImputacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uccFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETiposDeCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEMonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaRegistracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cldFechaComprobante)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalDesdeImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalUsuarioMonedaReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneImpuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoConDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNeto)).EndInit();
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeDescuentoGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDescuentoGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mzCEImpuestoAplicadoConceptoNOGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalConceptoNOGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorImpuestoAplicadoConceptoNOGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeImpuestoAplicadoConceptoNOGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneConceptoNOGravadoAplicado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEConceptosNOGravados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtrosConceptos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uneTotalNetoGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneValorImpuestoAplicadoNetoGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePorcentajeImpuestoAplicadoNetoGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoGravadoAplicado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEImpuestoAplicadoNetoGravado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCETipoDeNetoGravados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNetosGravados)).EndInit();
            this.ultraExplorerBarContainerControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneNetoItemsReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ultraExplorerBarContainerControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
            this.ultraExplorerBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void FrmCabeceraComprobanteDeCompra_Load(object sender, System.EventArgs e)
		{
			this.mzCEResponsableEmision.Select();
		}

		#region Variables Privadas				
			private controllers.IngresarComprobanteDeCompraCabeceraController _uiController = null;							
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
			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			mzCmb.Enabled = _uiController.AllowEditProveedor;
            mzCmb.Init();
			mzCmb.SearchObjectListener = this;
			mzCmb.EnableCtaCte = _uiController.EnabledButtonCuentaCtaCte;
			mzCETipoComprobante.Enabled = _uiController.AllowEditTipoDeComprobante;
			ultraMENumero.Enabled = _uiController.AllowEditNumeration;
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			mzCEResponsableEmision.Enabled = _uiController.AllowEditResponsableEmision;
			mzCEMonedas.Enabled = _uiController.AllowEditMonedaOrigen;
			mzCETiposDeCambio.Enabled = _uiController.AllowEditFuenteDeCambio;
			uneValorCotizacion.Enabled = _uiController.AllowEditFuenteDeCambio;
			
			uneDiasVencimiento.Enabled = _uiController.AllowEditDiasVencimiento;
			uneNeto.Enabled = _uiController.AllowEditNetoBruto;
			uneNetoConDescuento.Enabled = _uiController.AllowEditNeto;
			unePorcentajeDescuento.Enabled = _uiController.AllowEditPorcentajeDescuentos;
			uccFechaVencimiento.Enabled = _uiController.AllowEditFechaVencimiento;
			uccProximaFechaVencimiento.Enabled = _uiController.AllowEditProximaFechaVencimiento;
			txtCAI.Enabled = _uiController.AllowEditCAI;
			txtLeyenda.Enabled = _uiController.AllowEditLeyenda;
			uneTotalUsuarioMonedaReferencia.Enabled = _uiController.AllowEditTotalUsuarioMonedaReferencia;
			uneTotalUsuarioMonedaReferencia.ReadOnly = !_uiController.AllowEditTotalUsuarioMonedaReferencia;

			this.gridNetosGravados.LayoutData = _uiController.LayoutConceptos;
            //Cristian 20101025 Tarea 879
            this.gridNetosGravados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
            //Fin Tarea 879
			this.gridOtrosConceptos.LayoutData = _uiController.LayoutConceptos;			
			uneNetoConDescuento.Enabled = false;
			unePorcentajeImpuestoAplicadoNetoGravado.Enabled = _uiController.AllowEditPorcentajeImpuestoAplicadoNetoGravado;
			uneValorImpuestoAplicadoNetoGravado.Enabled = _uiController.AllowEditValorImpuestoAplicadoNetoGravado;
			uneTotalNetoGravado.Enabled = _uiController.AllowEditTotalNetoGravado;
			unePorcentajeImpuestoAplicadoConceptoNOGravado.Enabled = _uiController.AllowEditPorcentajeImpuestoAplicadoConceptoNOGravado;
			uneConceptoNOGravadoAplicado.Enabled = _uiController.AllowEditConceptoNoGravadoAplicado;
			uneValorImpuestoAplicadoConceptoNOGravado.Enabled = _uiController.AllowEditValorImpuestoAplicadoConceptoNOGravado;
			uneTotalConceptoNOGravado.Enabled  = _uiController.AllowEditTotalConceptoNOGravado;
			mz.erp.ui.utility.Util.VisualizacionContenedores(ultraExplorerBar, _uiController.GetProcessManager().GetProcessName(), _uiController.TaskName);
			//gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			if(_uiController.AllowDeleteItems)
			{
				gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			}
			else
			{
				gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			}
			gridProductos.GroupByBoxVisible = false;
			gridProductos.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			gridManagerView1.Visible = false;
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridProductos, this.Text);			

			//gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextRow;
			gridProductos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			gridProductos.UpdateOnLeave = true;

			uneImpuestos.Enabled = _uiController.AllowEditImpuestos;

			mzCECuentaImputacion.Enabled = _uiController.AllowEditCuentaImputacion;
			mzCESubcuentaImputacion.Enabled = _uiController.AllowEditSubcuentaImputacion;
			cldFechaRegistracion.Enabled = _uiController.AllowEditFechaRegistracion;
			cldFechaComprobante.Enabled = _uiController.AllowEditFecha;
			mzCECondicionDeCompra.Enabled = _uiController.AllowEditCondicionDeCompra;
			umeMesImputacion.Enabled = _uiController.AllowEditMesImputacion;
			umeMesDevengamiento.Enabled = _uiController.AllowEditMesDevengamiento;
			uneDescuentos.Enabled = _uiController.AllowEditDescuentos;
			uneTotalUsuario.Enabled = _uiController.AllowEditTotalUsuario;
			uneTotalDesdeImpuestos.Enabled = _uiController.AllowEditTotalDesdeImpuestos;
			mzCETipoDeNetoGravados.Enabled = _uiController.AllowEditTipoDeNetoGravados;
			mzCEImpuestoAplicadoNetoGravado.Enabled = _uiController.AllowEditImpuestoAplicadoNetoGravado;
			uneNetoGravadoAplicado.Enabled = _uiController.AllowEditNetoGravadoAplicado;
			groupBox1.Enabled = _uiController.AllowEditNetosGravados;
			groupBox2.Enabled = _uiController.AllowEditConceptosNoGravados;
			mzCEConceptosNOGravados.Enabled = _uiController.AllowEditTipoConceptoNoGravado;
			mzCEImpuestoAplicadoConceptoNOGravado.Enabled = _uiController.AllowEditImpuestoAplicadoConceptoNOGravado;
			uneTotalGeneral.Enabled = _uiController.AllowEditTotalGeneral;
			uneDescuentoGeneral.Enabled = _uiController.AllowEditDescuentoGeneral;
			unePorcentajeDescuentoGeneral.Enabled= _uiController.AllowEditPorcentajeDescuentoGeneral;
			uneTotal.Enabled = _uiController.AllowEditTotal;
			uneNetoItems.Enabled = _uiController.AllowEditNetoItems;
			uneNetoItemsReal.Enabled = _uiController.AllowEditNetoItemsReal;
			txtObservaciones.Enabled = _uiController.AllowEditObservaciones;

			mzProductosControl.Enabled = _uiController.AllowAddItems;
			mzProductosControl.VisiblePrecios = false;
			mzProductosControl.EnabledCantidad = true;
			mzProductosControl.EnabledListaDePrecio = false;

			KeyPreview = true;

		}

		private void InitializeData()
		{	
			mzCETipoComprobante.FillFromDataSource(_uiController.TiposDeComprobantesSearchObject,_uiController.TiposDeComprobantesValueMember,_uiController.TiposDeComprobantesDisplayMember,100,_uiController.TiposDeComprobantesDisplayMember);
			mzCEResponsableEmision.FillFromDataSource(_uiController.ResponsableDataTable, _uiController.ResponsableValueMember,_uiController.ResponsableDisplayMember,8,_uiController.ResponsableDisplayMember);
			mzCEMonedas.FillFromDataSource(_uiController.TableMonedas, "IdMoneda", "Descripcion", 8,null);
			mzCETiposDeCambio.FillFromDataSource(_uiController.TableFuentesDeCambio, "IdFuenteDeCambio", "Descripcion", 8,null);
			mzCECuentaImputacion.FillFromDataSource( _uiController.TableCuentasDeImputacion, _uiController.KeyValueTiposMovimientos,_uiController.KeyListTiposMovimientos,100, _uiController.KeyListTiposMovimientos );
			mzCESubcuentaImputacion.FillFromDataSource( _uiController.TableSubcuentasDeImputacion, _uiController.KeyValueTiposMovimientos,_uiController.KeyListTiposMovimientos,100, _uiController.KeyListTiposMovimientos );
			mzCETipoDeNetoGravados.FillFromDataSource(_uiController.TableNetosGravados, "IdNeto", "Descripcion", 8,"ID", "Descripcion",null, "EsGravado=true");
			mzCEConceptosNOGravados.FillFromDataSource(_uiController.TableNetosNOGravados, "IdNeto", "Descripcion", 8,"ID", "Descripcion",null, "EsGravado=false");
			mzCEImpuestoAplicadoNetoGravado.FillFromDataSource(_uiController.TableImpuestosAsociadosNetosGravados, "IdImpuesto", "Descripcion", 8,null);
			mzCEImpuestoAplicadoConceptoNOGravado.FillFromDataSource(_uiController.TableImpuestosAsociadosNetosNOGravados, "IdImpuesto", "Descripcion", 8,null);
			labelSimboloMonedaProveedor1.Text = _uiController.SimboloMonedaCierre;
            /* Silvina 20110225 - Tarea 0000074 */
            mzCECondicionDeCompra.FillFromDataSource(mz.erp.businessrules.tpu_CondicionesDeCompras.GetListActivas().tpu_CondicionesDeCompras, "IdCondicionDeCompra", "Descripcion", 16, "Orden");
            /* Fin Silvina */
			FillControls();
			mzProductosControl.AddObjectListener((IObserver)_uiController);
			ConfigureGrid();

		}

		private void InitEventHandlers()
		{	
			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.DiasVencimientoChanged +=new EventHandler(_uiController_DiasVencimientoChanged);
			_uiController.FechaVencimientoChanged +=new EventHandler(_uiController_FechaVencimientoChanged);
            //German 20120510 - Tarea 0000320
            _uiController.ProximaFechaVencimientoChanged += new EventHandler(_uiController_ProximaFechaVencimientoChanged);
            //Fin German 20120510 - Tarea 0000320
			_uiController.CuentaImputacionChanged +=new EventHandler(_uiController_CuentaImputacionChanged);
			_uiController.CuentaImputacionProveedorChanged +=new EventHandler(_uiController_CuentaImputacionProveedorChanged);
			_uiController.SubCuentaImputacionProveedorChanged +=new EventHandler(_uiController_SubCuentaImputacionProveedorChanged);
            //German 2011104 - Tarea 914
			_uiController.NetoChangedAux +=new EventHandler(_uiController_NetoChanged);
            //Fin German 2011104 - Tarea 914
			_uiController.TotalChanged +=new EventHandler(_uiController_TotalChanged);
			_uiController.TipoDeComprobanteDestinoChanged +=new EventHandler(_uiController_TipoDeComprobanteDestinoChanged);
			_uiController.IdNetoGravadoChanged +=new EventHandler(_uiController_IdNetoGravadoChanged);
			_uiController.IdNetoNOGravadoChanged +=new EventHandler(_uiController_IdNetoNOGravadoChanged);
			_uiController.CalculoGravadoChanged +=new EventHandler(_uiController_CalculoGravadoChanged);
			_uiController.CalculoNOGravadoChanged +=new EventHandler(_uiController_CalculoNOGravadoChanged);
			_uiController.NetoAcumuladoInvalidoError +=new EventHandler(_uiController_NetoAcumuladoInvalidoError);
			_uiController.ConceptoRepetidoError +=new EventHandler(_uiController_ConceptoRepetidoError);
			this.ultraMENumero.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneValorCotizacion.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneDiasVencimiento.Enter += new System.EventHandler(this.OnEnterControl);
			this.txtCAI.Enter += new System.EventHandler(this.OnEnterControl);
			this.txtLeyenda.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneConceptoNOGravadoAplicado.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneDescuentos.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneNeto.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneNetoConDescuento.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneNetoGravadoAplicado.Enter += new System.EventHandler(this.OnEnterControl);
			this.unePorcentajeDescuento.Enter += new System.EventHandler(this.OnEnterControl);
			this.unePorcentajeImpuestoAplicadoConceptoNOGravado.Enter += new System.EventHandler(this.OnEnterControl);
			this.unePorcentajeImpuestoAplicadoNetoGravado.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneTotalConceptoNOGravado.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneTotalNetoGravado.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneValorImpuestoAplicadoConceptoNOGravado.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneValorImpuestoAplicadoNetoGravado.Enter += new System.EventHandler(this.OnEnterControl);
			this.umeMesImputacion.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneTotalUsuario.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneTotalDesdeImpuestos.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneImpuestos.Enter += new System.EventHandler(this.OnEnterControl);
			this.uneDescuentoGeneral.Enter += new System.EventHandler(this.OnEnterControl);

			utbAgregarNetoGravado.Click +=new EventHandler(utbAgregarNetoGravado_Click);
			utbAgregarConceptoNOGravado.Click +=new EventHandler(utbAgregarConceptoNOGravado_Click);
			//this.gridNetosGravados.DeletingRecords+=new CancelEventHandler(gridNetosGravados_DeletingRecords);
			this.gridNetosGravados.RecordsDeleted+=new EventHandler(gridNetosGravados_RecordsDeleted);
            //Cristian Tarea 879
            this.gridNetosGravados.CellEdited+= new Janus.Windows.GridEX.ColumnActionEventHandler(gridNetosGravados_CellEdited);
            //Fin Tarea 879
			this.gridOtrosConceptos.DeletingRecords+=new CancelEventHandler(gridOtrosConceptos_DeletingRecords);
			this.gridOtrosConceptos.RecordsDeleted+=new EventHandler(gridOtrosConceptos_RecordsDeleted);

			MouseHelper mouseControler = new MouseHelper();
			mouseControler.Control = ultraExplorerBar;
			mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
			mouseControler.WheelForward += new MouseEventHandler(ScrollUp);

			
			this.gridProductos.EditingCell +=new Janus.Windows.GridEX.EditingCellEventHandler(gridProductos_EditingCell);

			_uiController.ItemsChanged +=new EventHandler(_uiController_ItemsChanged);
			gridProductos.DeletingRecords +=new CancelEventHandler(gridProductos_DeletingRecords);
			mzCmb.ValueChanged +=new EventHandler(mzCmb_ValueChanged);

			_uiController.NetosCollectionChanged += new EventHandler(_uiController_NetosCollectionChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);

		}

        //German 20120510 - Tarea 0000320
        void _uiController_ProximaFechaVencimientoChanged(object sender, EventArgs e)
        {
            uccFechaVencimiento.Value = _uiController.ProximaFechaVencimiento;
        }
        //Fin German 20120510 - Tarea 0000320
		private void InitDataBindings()
		{			
			if(_uiController.Mascara != null && _uiController.Mascara != String.Empty)
			{
				ultraMENumero.InputMask = _uiController.Mascara;
				
			}
			
			mzCEResponsableEmision.DataBindings.Add("Value", _uiController, "ResponsableDeEmision");
			BindingController.Bind(mzCETipoComprobante,"Value",_uiController,"KeyValueTiposDeComprobantes");
			ultraMENumero.DataBindings.Add("Text", _uiController, "NumeroComprobante");
			cldFechaComprobante.DataBindings.Add("Value", _uiController, "FechaComprobante");
			uneDiasVencimiento.DataBindings.Add("Value", _uiController, "DiasVencimiento");
			uccFechaVencimiento.DataBindings.Add("Value", _uiController, "FechaVencimiento");
            //German 20120510 - Tarea 0000320
            uccProximaFechaVencimiento.DataBindings.Add("Value", _uiController, "ProximaFechaVencimiento");
            //Fin German 20120510 - Tarea 0000320
			
			//BindingController.Bind(mzCmb,"DataValue",_uiController,"KeyValueProveedores");

			BindingController.Bind(mzCECuentaImputacion,"Value",_uiController,"IdCuentaImputacion");
			BindingController.Bind(mzCESubcuentaImputacion,"Value",_uiController,"IdSubCuentaImputacion");
			uneDescuentos.DataBindings.Add("Value",_uiController,"Descuentos");
			uneNeto.DataBindings.Add("Value",_uiController,"NetoBruto");
			uneNetoConDescuento.DataBindings.Add("Value",_uiController,"Neto");
			unePorcentajeDescuento.DataBindings.Add("Value",_uiController,"PorcentajeDescuentos");
			uneDescuentoGeneral.DataBindings.Add("Value",_uiController,"DescuentoGeneral");
			unePorcentajeDescuentoGeneral.DataBindings.Add("Value",_uiController,"PorcentajeDescuentoGeneral");
			uneImpuestos.DataBindings.Add("Value", _uiController, "Impuestos");
			BindingController.Bind(mzCETipoDeNetoGravados,"Value", _uiController, "IdNetoGravado");
			BindingController.Bind(mzCEConceptosNOGravados,"Value", _uiController, "IdNetoNOGravado");
			BindingController.Bind(mzCEImpuestoAplicadoNetoGravado,"Value", _uiController, "IdImpuestoAsociadoNetoGravado");
			BindingController.Bind(mzCEImpuestoAplicadoConceptoNOGravado,"Value", _uiController, "IdImpuestoAsociadoNetoNOGravado");
			BindingController.Bind(uneNetoGravadoAplicado,"Value", _uiController, "NetoGravadoAplicado");
			BindingController.Bind(uneConceptoNOGravadoAplicado,"Value", _uiController, "NetoNOGravadoAplicado");
			uneValorImpuestoAplicadoNetoGravado.DataBindings.Add("Value", _uiController, "ValorImpuestoAplicadoNetoGravado");
			uneValorImpuestoAplicadoConceptoNOGravado.DataBindings.Add("Value", _uiController, "ValorImpuestoAplicadoNetoNOGravado");
			labelSimboloMonedaProveedor.DataBindings.Add("Text", _uiController,"SimboloMonedaOrigen");
			labelSimboloMonedaProveedor1.DataBindings.Add("Text", _uiController,"SimboloMonedaOrigen");
			labelSimboloMonedaProveedor2.DataBindings.Add("Text", _uiController,"SimboloMonedaOrigen");
			labelSimboloMonedaProveedor3.DataBindings.Add("Text", _uiController,"SimboloMonedaOrigen");
			labelSimboloMonedaProveedor4.DataBindings.Add("Text", _uiController,"SimboloMonedaOrigen");
			labelSimboloMonedaProveedor5.DataBindings.Add("Text", _uiController,"SimboloMonedaOrigen");
			labelSimboloMonedaProveedor6.DataBindings.Add("Text", _uiController,"SimboloMonedaOrigen");
			mzCETiposDeCambio.DataBindings.Add("Value", _uiController, "IdFuenteDeCambioProveedor");
			mzCEMonedas.DataBindings.Add("Value", _uiController, "IdMonedaOrigen");
			uneValorCotizacion.DataBindings.Add("Value", _uiController, "ValorCotizacionProveedor");
			uneTotalUsuario.DataBindings.Add("Value", _uiController, "TotalUsuario");
			uneTotalUsuarioMonedaReferencia.DataBindings.Add("Value", _uiController, "TotalUsuarioMonedaReferencia");
			gridNetosGravados.SetDataBinding(_uiController.ConceptosGravados, null);
			gridOtrosConceptos.SetDataBinding(_uiController.ConceptosNOGravados, null);
			gridProductos.SetDataBinding(_uiController.Items, null);
			
			uneNetoItems.DataBindings.Add("Value", _uiController, "NetoItems");
			uneNetoItemsReal.DataBindings.Add("Value", _uiController, "NetoItemsOriginal");
				BindingController.Bind(mzCECondicionDeCompra,"Value", _uiController, "IdCondicionDeCompra");

		}


		private void ConfigureGrid()
		{
			if(_uiController.AllowEditItems)
			{
				gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
				gridProductos.RootTable.Columns["Codigo"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
				gridProductos.RootTable.Columns["Descripcion"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
				gridProductos.RootTable.Columns["Cantidad"].EditType = Janus.Windows.GridEX.EditType.TextBox;
				gridProductos.RootTable.Columns["PrecioDeCosto"].EditType = Janus.Windows.GridEX.EditType.TextBox;

			}
			else
				gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;

		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{			
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2://Guardar	
					Execute();
					break;
				case 4:
					CloseForm();
					break;
			}						
		}

		
		private void FillControls()
		{
			mzCEResponsableEmision.Value = _uiController.ResponsableDeEmision;
			mzCECuentaImputacion.Value = _uiController.IdCuentaImputacion;
			mzCESubcuentaImputacion.Value = _uiController.IdSubCuentaImputacion;
			//cldFechaComprobante.Value = _uiController.FechaComprobante;
			cldFechaRegistracion.Value = _uiController.FechaRegistracion;
            //German 20120510 - Tarea 0000320
			//uccProximaFechaVencimiento.Value = _uiController.ProximaFechaVencimiento;
            //Fin German 20120510 - Tarea 0000320
			//mzCETiposDeCambio.Value =  _uiController.IdFuenteDeCambioProveedor;
			//mzCEMonedas.Value = _uiController.IdMonedaOrigen;
			//uneValorCotizacion.Value = _uiController.ValorCotizacionProveedor;
			txtCAI.Text = _uiController.CAI;
			txtLeyenda.Text = _uiController.Leyenda;
			umeMesImputacion.Value = _uiController.MesDeImputacion;			
			umeMesDevengamiento.Value = _uiController.MesDeDevengamiento;
			mzCmb.DataValue = _uiController.KeyValueProveedores;
			//uneDiasDemoraEntrega.Value = _uiController.DiasDemoraEntrega;
			if (_uiController.TotalGeneral != 0)
			{
				_uiController_NetoChanged(this, new EventArgs());
			}
			txtObservaciones.Value = _uiController.Observaciones;
		}


		public void DumpControls()
		{			
			_uiController.FechaComprobante = Convert.ToDateTime(cldFechaComprobante.Value);
			_uiController.FechaRegistracion = Convert.ToDateTime(cldFechaRegistracion.Value);			
			_uiController.FechaVencimiento = Convert.ToDateTime(uccFechaVencimiento.Value);			
			_uiController.ProximaFechaVencimiento = Convert.ToDateTime(uccProximaFechaVencimiento.Value);
			//_uiController.IdFuenteDeCambioProveedor = Convert.ToString(mzCETiposDeCambio.Value);
			//_uiController.IdMonedaOrigen = Convert.ToString(mzCEMonedas.Value);
			//_uiController.ValorCotizacionProveedor = Convert.ToDecimal(uneValorCotizacion.Value);
			_uiController.CAI = txtCAI.Text ;
			_uiController.Leyenda = txtLeyenda.Text;
			_uiController.MesDeImputacion = Convert.ToString(umeMesImputacion.Value);
			_uiController.MesDeDevengamiento = Convert.ToString(umeMesDevengamiento.Value);
			//_uiController.DiasDemoraEntrega = Convert.ToInt32(uneDiasDemoraEntrega.Value);				
			_uiController.Impuestos = Convert.ToDecimal(uneImpuestos.Value);
			//_uiController.TotalUsuario = Convert.ToDecimal(uneTotalUsuario.Value);
			_uiController.Observaciones = txtObservaciones.Text;		
			//_uiController.KeyValueProveedores = Convert.ToString(mzCmb.DataValue);

		}		

		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			mz.erp.ui.utility.Util.MoveFocus(this.ultraExplorerBarContainerControl1);
			DumpControls();
			_uiController.Execute();			
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
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			Execute();
		}

		#endregion

		#region Miembros de ISearchObjectListener

		public void processEventChange(object sender, EventArgs e)
		{
		}

		#endregion

		private void _uiController_DiasVencimientoChanged(object sender, EventArgs e)
		{
			uccFechaVencimiento.Value = _uiController.FechaVencimiento;
		}
			
		private void _uiController_FechaVencimientoChanged(object sender, EventArgs e)
		{
			uneDiasVencimiento.Value = _uiController.DiasVencimiento;
		}
		
		

		private void _uiController_CuentaImputacionChanged(object sender, EventArgs e)
		{
			mzCESubcuentaImputacion.FillFromDataSource( _uiController.TableSubcuentasDeImputacion, _uiController.KeyValueSubTiposMovimientos,_uiController.KeyListTiposMovimientos,100, _uiController.KeyListTiposMovimientos );
			mzCESubcuentaImputacion.Value = _uiController.IdSubCuentaImputacion;
		}

		private void _uiController_CuentaImputacionProveedorChanged(object sender, EventArgs e)
		{		
			//if (_uiController.IdCuentaImputacion != "")
				mzCECuentaImputacion.Value = _uiController.IdCuentaImputacion;
		}

		private void _uiController_SubCuentaImputacionProveedorChanged(object sender, EventArgs e)
		{		
			mzCESubcuentaImputacion.Value = _uiController.IdSubCuentaImputacion;
		}

		private void OnEnterControl(object sender, System.EventArgs e)
		{
			if(sender.GetType().Equals(typeof(Infragistics.Win.UltraWinEditors.UltraNumericEditor)))
			{
				Infragistics.Win.UltraWinEditors.UltraNumericEditor control = (Infragistics.Win.UltraWinEditors.UltraNumericEditor) sender;
				control.SelectAll();
			}
			if(sender.GetType().Equals(typeof(Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit )))
			{
				Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit  control = (Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit ) sender;
				control.SelectAll();
			}
			if(sender.GetType().Equals(typeof(System.Windows.Forms.TextBox)))
			{
				System.Windows.Forms.TextBox control = (System.Windows.Forms.TextBox) sender;
				control.SelectAll();
			}
		}

		private void _uiController_NetoChanged(object sender, EventArgs e)
		{
            //German

            if (Convert.ToDecimal(uneDescuentos.Value) != _uiController.Descuentos)
			    uneDescuentos.Value = _uiController.Descuentos;
            if (Convert.ToDecimal(uneNeto.Value) != _uiController.NetoBruto)
			    uneNeto.Value = _uiController.NetoBruto;
            if (Convert.ToDecimal(uneNetoConDescuento.Value) != _uiController.Neto)
			    uneNetoConDescuento.Value = _uiController.Neto;
            if (Convert.ToDecimal(unePorcentajeDescuento.Value) != _uiController.PorcentajeDescuentos)
			    unePorcentajeDescuento.Value = _uiController.PorcentajeDescuentos;
            if (Convert.ToDecimal(uneTotalGeneral.Value) != _uiController.TotalGeneral)
			    uneTotalGeneral.Value = _uiController.TotalGeneral;
            if (Convert.ToDecimal(uneDescuentoGeneral.Value) != _uiController.DescuentoGeneral)
			    uneDescuentoGeneral.Value = _uiController.DescuentoGeneral;
            if (Convert.ToDecimal(unePorcentajeDescuentoGeneral.Value) != _uiController.PorcentajeDescuentoGeneral)
			    unePorcentajeDescuentoGeneral.Value = _uiController.PorcentajeDescuentoGeneral;
            if (Convert.ToDecimal(uneTotal.Value) != _uiController.Total)
			    uneTotal.Value = _uiController.Total;
            if (Convert.ToDecimal(uneTotalDesdeImpuestos.Value) != _uiController.Total)
			    uneTotalDesdeImpuestos.Value = _uiController.Total;			
		}

		private void _uiController_TotalChanged(object sender, EventArgs e)
		{			
			uneDescuentoGeneral.Value = _uiController.DescuentoGeneral;
			unePorcentajeDescuentoGeneral.Value = _uiController.PorcentajeDescuentoGeneral;
			uneTotal.Value = _uiController.Total;
			uneTotalDesdeImpuestos.Value = _uiController.Total;
		}

		private void _uiController_TipoDeComprobanteDestinoChanged(object sender, EventArgs e)
		{
			mzCETipoDeNetoGravados.FillFromDataSource(_uiController.TableNetosGravados, "IdNeto", "Descripcion", 8,"ID", "Descripcion",null, "EsGravado=true");
			mzCEConceptosNOGravados.FillFromDataSource(_uiController.TableNetosNOGravados, "IdNeto", "Descripcion", 8,"ID", "Descripcion",null, "EsGravado=false");
			mzCETipoComprobante.Value = _uiController.TipoComprobanteDestino;			
			ultraMENumero.InputMask = _uiController.Mascara;
		}

		private void _uiController_IdNetoGravadoChanged(object sender, EventArgs e)
		{
			mzCEImpuestoAplicadoNetoGravado.FillFromDataSource(_uiController.TableImpuestosAsociadosNetosGravados, "IdImpuesto", "Descripcion", 8,null);
			mzCEImpuestoAplicadoNetoGravado.Value = _uiController.IdImpuestoAsociadoNetoGravado;
			unePorcentajeImpuestoAplicadoNetoGravado.Value = _uiController.PorcentajeImpuestoAsociadoNetoGravado;
			uneValorImpuestoAplicadoNetoGravado.Value = _uiController.ValorImpuestoAplicadoNetoGravado;
			uneTotalNetoGravado.Value = _uiController.TotalGravado;
		}

		private void _uiController_IdNetoNOGravadoChanged(object sender, EventArgs e)
		{
			mzCEImpuestoAplicadoConceptoNOGravado.FillFromDataSource(_uiController.TableImpuestosAsociadosNetosNOGravados, "IdImpuesto", "Descripcion", 8,null);
			mzCEImpuestoAplicadoConceptoNOGravado.Value = _uiController.IdImpuestoAsociadoNetoNOGravado;
			unePorcentajeImpuestoAplicadoConceptoNOGravado.Value = _uiController.PorcentajeImpuestoAsociadoNetoNOGravado;
			uneValorImpuestoAplicadoConceptoNOGravado.Value = _uiController.ValorImpuestoAplicadoNetoNOGravado;
			uneTotalConceptoNOGravado.Value = _uiController.TotalNOGravado;
		}

		private void utbAgregarNetoGravado_Click(object sender, EventArgs e)
		{
			if(this.mzCETipoDeNetoGravados.Value != null && this.mzCETipoDeNetoGravados.Value != string.Empty
				&& this.mzCEImpuestoAplicadoNetoGravado.Value != null && this.mzCEImpuestoAplicadoNetoGravado.Value != string.Empty			
				)
			{
					string IdNetoGravado = Convert.ToString(mzCETipoDeNetoGravados.Value);
					string IdImpuestoAplicado = Convert.ToString(mzCEImpuestoAplicadoNetoGravado.Value);
					decimal Neto = Convert.ToDecimal(uneNetoGravadoAplicado.Value);
					decimal PorcentajeAplicado = Convert.ToDecimal(unePorcentajeImpuestoAplicadoNetoGravado.Value);
					decimal ImpuestoAplicado = Convert.ToDecimal(uneValorImpuestoAplicadoNetoGravado.Value);
					decimal Total = Convert.ToDecimal(uneTotalNetoGravado.Value);
					string DescripcionNeto = mzCETipoDeNetoGravados.Text;
					string DescripcionImpuesto = mzCEImpuestoAplicadoNetoGravado.Text;
					_uiController.AddNetoGravado(IdNetoGravado, DescripcionNeto, IdImpuestoAplicado, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
					this.gridNetosGravados.SetDataBinding(null, null);
					this.gridNetosGravados.SetDataBinding(_uiController.ConceptosGravados, null);

					mzCETipoDeNetoGravados.Value = string.Empty;
					mzCEImpuestoAplicadoNetoGravado.Value = string.Empty;
					uneNetoGravadoAplicado.Value = 0;
					unePorcentajeImpuestoAplicadoNetoGravado.Value = 0;
					uneValorImpuestoAplicadoNetoGravado.Value = 0;
					uneTotalNetoGravado.Value = 0;
				

					mzCETipoDeNetoGravados.Focus();
			}
			
		}

		private void MostrarMensajeError(string msj)
		{
			MessageBox.Show(msj, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
		}
		
/*		private void gridNetosGravados_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridNetosGravados.SelectedItems.Count ==  1)
			{				
			}
			else e.Cancel = true;		
		}*/
		private void gridNetosGravados_RecordsDeleted(object sender, EventArgs e)
		{			
			_uiController.RefreshTotal();
		}
        //Cristian Tarea 879
        private void gridNetosGravados_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Janus.Windows.GridEX.GridEXRow fila = gridNetosGravados.SelectedItems[0].GetRow();
            //German 20101105 - Tarea 879
            //if (!(fila.Cells[6].Value == null))
            if (!(fila.Cells[e.Column].Value == null))
            //Fin German 20101105 - Tarea 879
            {
                //German 20101105 - Tarea 879
                if (e.Column.Key.ToUpper().Equals("MONTOIMPUESTO"))
                {
                //Fin German 20101105 - Tarea 879
                    //recupero el monto del impuesto modificado
                    //German 20101105 - Tarea 879
                    //decimal montoModificado = (decimal)fila.Cells[6].Value;
                    decimal montoModificado = (decimal)fila.Cells[e.Column].Value;
                    //Fin German 20101105 - Tarea 879
                    ItemConcepto itemConcepto = (ItemConcepto)gridNetosGravados.SelectedItems[0].GetRow().DataRow;
                    //German 20101111 - Tarea 933
                    _uiController.updateNetoAplicado(itemConcepto.IdConcepto, itemConcepto.IdImpuesto, montoModificado);
                    //Fin German 20101111 - Tarea 933
                //German 20101105 - Tarea 879
                }
                
                //German 20101105 - Tarea 879
                if (e.Column.Key.ToUpper().Equals("MONTONETO"))
                {
                    decimal montoModificado = (decimal)fila.Cells[e.Column].Value;
                    //Fin German 20101105 - Tarea 879
                    ItemConcepto itemConcepto = (ItemConcepto)gridNetosGravados.SelectedItems[0].GetRow().DataRow;
                    //German 20101111 - Tarea 933
                    _uiController.updateImpuesto(itemConcepto.IdConcepto, itemConcepto.IdImpuesto, montoModificado);
                    //Fin German 20101111 - Tarea 933

                }
                //Fin German 20101105 - Tarea 879
            }
            //German 20101105 - Tarea 879
            //uneTotalDesdeImpuestos.Value = _uiController.Total;			
            //Fin German 20101105 - Tarea 879
            gridNetosGravados.SetDataBinding(_uiController.ConceptosGravados, null);

        }  
        //Fin Tarea 879 
		private void utbAgregarConceptoNOGravado_Click(object sender, EventArgs e)
		{
			if(this.mzCEConceptosNOGravados.Value != null && this.mzCEConceptosNOGravados.Value != string.Empty
				&& this.mzCEImpuestoAplicadoConceptoNOGravado.Value != null && this.mzCEImpuestoAplicadoConceptoNOGravado.Value != string.Empty			
				)
			{
				
					string IdNetoGravado = Convert.ToString(mzCEConceptosNOGravados.Value);
					string IdImpuestoAplicado = Convert.ToString(mzCEImpuestoAplicadoConceptoNOGravado.Value);
					decimal Neto = Convert.ToDecimal(uneConceptoNOGravadoAplicado.Value);
					decimal PorcentajeAplicado = Convert.ToDecimal(unePorcentajeImpuestoAplicadoConceptoNOGravado.Value);
					decimal ImpuestoAplicado = Convert.ToDecimal(uneValorImpuestoAplicadoConceptoNOGravado.Value);
					decimal Total = Convert.ToDecimal(uneTotalConceptoNOGravado.Value);
					string DescripcionNeto = mzCEConceptosNOGravados.Text;
					string DescripcionImpuesto = mzCEImpuestoAplicadoConceptoNOGravado.Text;
					_uiController.AddNetoNOGravado(IdNetoGravado, DescripcionNeto, IdImpuestoAplicado, DescripcionImpuesto, Neto, PorcentajeAplicado, ImpuestoAplicado, Total);
					this.gridOtrosConceptos.SetDataBinding(null, null);
					this.gridOtrosConceptos.SetDataBinding(_uiController.ConceptosNOGravados, null);

					mzCEConceptosNOGravados.Value = string.Empty;
					mzCEImpuestoAplicadoConceptoNOGravado.Value = string.Empty;
					uneConceptoNOGravadoAplicado.Value = 0;
					unePorcentajeImpuestoAplicadoConceptoNOGravado.Value = 0;
					uneValorImpuestoAplicadoConceptoNOGravado.Value = 0;
					uneTotalConceptoNOGravado.Value = 0;
				

					mzCEConceptosNOGravados.Focus();

			}
		}
		private void gridOtrosConceptos_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridOtrosConceptos.SelectedItems.Count ==  1)
			{				
				//if (_uiController.AllowDeleteItems) 
				//{
				/*object selectedItem = 	gridNetosGravados.SelectedItems[0].GetRow().DataRow;
					if (_uiController.IsRemovable(selectedItem)) 
						e.Cancel = false;
					else e.Cancel = true;*/
				//}
				//else e.Cancel = true;
			}
			else e.Cancel = true;

		}

		private void gridOtrosConceptos_RecordsDeleted(object sender, EventArgs e)
		{
			_uiController.RefreshTotal();
		}

		private void _uiController_CalculoGravadoChanged(object sender, EventArgs e)
		{
			unePorcentajeImpuestoAplicadoNetoGravado.Value = _uiController.PorcentajeImpuestoAsociadoNetoGravado;
			uneValorImpuestoAplicadoNetoGravado.Value = _uiController.ValorImpuestoAplicadoNetoGravado;
			uneTotalNetoGravado.Value = _uiController.TotalGravado;
		}

		private void _uiController_CalculoNOGravadoChanged(object sender, EventArgs e)
		{
			unePorcentajeImpuestoAplicadoConceptoNOGravado.Value = _uiController.PorcentajeImpuestoAsociadoNetoNOGravado;
			uneValorImpuestoAplicadoConceptoNOGravado.Value = _uiController.ValorImpuestoAplicadoNetoNOGravado;
			uneTotalConceptoNOGravado.Value = _uiController.TotalNOGravado;
		}

		private void _uiController_NetoAcumuladoInvalidoError(object sender, EventArgs e)
		{
			MostrarMensajeError("El Neto acumulado en los conceptos supera el Neto del comprobante");
		}

		private void _uiController_ConceptoRepetidoError(object sender, EventArgs e)
		{
			MostrarMensajeError("El concepto ya existe");
		}

		private void ultraExplorerBarContainerControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
		private void ScrollDown (object sender, MouseEventArgs e)
		{
			//ultraExplorerBar.PerformAction(UltraExplorerBarAction.ScrollPageDown);
		}

		private void ScrollUp (object sender, MouseEventArgs e)
		{
			//ultraExplorerBar.PerformAction(UltraExplorerBarAction.ScrollPageUp);
		}


		private void gridProductos_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridProductos.SelectedItems.Count > 0)
			{
				businessrules.comprobantes.ItemComprobanteCompra itemComp =  (businessrules.comprobantes.ItemComprobanteCompra)gridProductos.SelectedItems[0].GetRow().DataRow;
				if(itemComp.Estado.Equals("NEW") || _uiController.IsRemovable(itemComp))
				{
					e.Cancel = true;
					CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.Items];
					int pos = cm.Position;
					if(pos >= 0)
					{
						cm.RemoveAt(pos);
						cm.Refresh();
					}
				}
				else
				{
					e.Cancel = true;
					_uiController.RemoveItem(itemComp);
				}
			}
		}


		private void gridProductos_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
		{
			string column = e.Column.Key;
			if(gridProductos.SelectedItems.Count > 0)
			{
				object selectedItem = 	gridProductos.SelectedItems[0].GetRow().DataRow;
				if (!_uiController.IsEditable(selectedItem, column)) 
					e.Cancel = true;
			}
		}

		private void _uiController_ItemsChanged(object sender, EventArgs e)
		{
			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Items, null);
		}

		private void mzCmb_ValueChanged(object sender, EventArgs e)
		{
			_uiController.KeyValueProveedores = Convert.ToString(mzCmb.DataValue);
            /* Silvina 20110729 - Tarea 0000147 */
            mzCECondicionDeCompra.Enabled = string.IsNullOrEmpty(_uiController.IdCondicionDeCompra) || _uiController.AllowEditCondicionDeCompra;
            /* Silvina 20110729 - Tarea 0000147 */
		}

		private void ultraMENumero_Leave(object sender, System.EventArgs e)
		{
			this.ultraMENumero.Text = _uiController.FillNumberWithZeros(ultraMENumero.Text);
		}

		private void cldFechaComprobante_Leave(object sender, System.EventArgs e)
		{
			try
			{
				decimal mes = (Convert.ToDateTime(cldFechaComprobante.Value)).Month;
				decimal año = (Convert.ToDateTime(cldFechaComprobante.Value)).Year;
				umeMesImputacion.Value = Convert.ToString(mes) + '/' + Convert.ToString(año);
				umeMesDevengamiento.Value = Convert.ToString(mes) + '/' + Convert.ToString(año);
			}
			catch(Exception errorFecha)
			{
				
			}
		}

		private void _uiController_NetosCollectionChanged(object sender, EventArgs e)
		{
			this.gridOtrosConceptos.SetDataBinding(null, null);
			this.gridOtrosConceptos.SetDataBinding(_uiController.ConceptosNOGravados, null);
			this.gridNetosGravados.SetDataBinding(null, null);
			this.gridNetosGravados.SetDataBinding(_uiController.ConceptosGravados, null);

		}

	}
}


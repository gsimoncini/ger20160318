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
	/// Descripción breve de mzProductosSearchFormWorkflow.
	/// </summary>
	public class mzProductosSearchFormWorkflow : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbBuscar;
		private System.Windows.Forms.ToolBarButton tbbSeparador1;
		private System.Windows.Forms.ToolBarButton tbbNuevaBusqueda;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbNuevo;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbEditar;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator5;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeprardor6;
		private System.Windows.Forms.ToolBarButton tbbAceptar;
		private System.Windows.Forms.ToolBarButton tbbSeparator7;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcFiltros;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage2;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroPrincipal;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroJerarquico;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl utpFiltroSecundario;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private mz.erp.ui.controls.mzComboEditor mzComboTipoProducto;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelCodigoSec;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private System.Windows.Forms.TextBox txtDescripcionLarga;
		private System.Windows.Forms.TextBox txtDescripcionCorta;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar1;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtCampoAuxiliar1;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar2;
		private System.Windows.Forms.TextBox txtCodigoSecundario;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar5;
		private System.Windows.Forms.TextBox txtCampoAuxiliar5;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar4;
		private System.Windows.Forms.TextBox txtCampoAuxiliar4;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkObligaNumeroSerie;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkObligaCodigoBarra;
		private System.Windows.Forms.Label label14;
		private mz.erp.ui.controls.mzComboEditor mzCEBonificacion;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkPercibeIB;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarActivo;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarObligaCB;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarObligaNS;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarPercibeIB;
		private Janus.Windows.GridEX.GridEX gridEx;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl1;
		private Infragistics.Win.UltraWinTabControl.UltraTabControl utcDetalles;
		private Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage ultraTabSharedControlsPage1;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl2;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl3;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl4;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl5;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl6;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl7;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private Janus.Windows.GridEX.GridEX gridCondicionesDeVenta;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.PictureBox pictureBoxThumb;
		private Janus.Windows.GridEX.GridEX gridFormasDePago;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private Infragistics.Win.UltraWinGrid.UltraGrid gridStock;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label32;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultDescripcion;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioFinalMD;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioNetoMD;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioNetoMO;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioFinalMO;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultObservaciones;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultCampoAuxiliar5;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultCampoAuxiliar4;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultCampoAuxiliar3;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultCampoAuxiliar2;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultCampoAuxiliar1;
		private System.Windows.Forms.Label lbResultlEtiquetaCampoAuxiliar2;
		private System.Windows.Forms.Label lbResultlEtiquetaCampoAuxiliar1;
		private System.Windows.Forms.Label lbResultlEtiquetaCampoAuxiliar3;
		private System.Windows.Forms.Label lbResultlEtiquetaCampoAuxiliar5;
		private System.Windows.Forms.Label lbResultlEtiquetaCampoAuxiliar4;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioFinalMD;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioNetoMO;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioFinalMO;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioNetoMD;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioFinalMD2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioFinalMO2;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioFinalMD2;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioFinalMO2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioFinalMD1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecioFinalMO1;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioFinalMD1;
		private System.Windows.Forms.Label lbEtiquetaResultPrecioFinalMO1;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtResultDescripcion1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneResultPrecionFinal1;
		private System.Windows.Forms.Label lbEtitutaResultPrecionFinal1;
		private Infragistics.Win.UltraWinTabControl.UltraTabPageControl ultraTabPageControl9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaDesde;
		private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo FechaHasta;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItemSeleccionarTodos;
		private System.Windows.Forms.MenuItem menuItemDesSeleccionar;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceEntreFechas;
		private System.Windows.Forms.Label lFecha;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceResponsable;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsable;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox1;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaHasta;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFechaAltaDesde;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton2 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab1 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab2 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab3 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab4 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab5 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab6 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab7 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab8 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab9 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab10 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab11 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			Infragistics.Win.UltraWinTabControl.UltraTab ultraTab12 = new Infragistics.Win.UltraWinTabControl.UltraTab();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mzProductosSearchFormWorkflow));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.utpFiltroPrincipal = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.label12 = new System.Windows.Forms.Label();
			this.uceEntreFechas = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.uceResponsable = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.mzCEResponsable = new mz.erp.ui.controls.mzComboEditor();
			this.label10 = new System.Windows.Forms.Label();
			this.chkHabilitarActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.txtCodigoSecundario = new System.Windows.Forms.TextBox();
			this.mzComboTipoProducto = new mz.erp.ui.controls.mzComboEditor();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelCodigoSec = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.txtDescripcionLarga = new System.Windows.Forms.TextBox();
			this.txtDescripcionCorta = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.udtFechaAltaHasta = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.udtFechaAltaDesde = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label11 = new System.Windows.Forms.Label();
			this.lFecha = new System.Windows.Forms.Label();
			this.utpFiltroSecundario = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.chkHabilitarPercibeIB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkHabilitarObligaNS = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkHabilitarObligaCB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.label14 = new System.Windows.Forms.Label();
			this.mzCEBonificacion = new mz.erp.ui.controls.mzComboEditor();
			this.chkPercibeIB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkObligaNumeroSerie = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkObligaCodigoBarra = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.lblEtiquetaCampoAuxiliar5 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar5 = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar4 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar4 = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar2 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar1 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.lblEtiquetaCampoAuxiliar3 = new System.Windows.Forms.Label();
			this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
			this.utpFiltroJerarquico = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
			this.ultraTabPageControl9 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.FechaHasta = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.FechaDesde = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ultraTabPageControl1 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.uneResultPrecioFinalMD = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneResultPrecioNetoMD = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneResultPrecioNetoMO = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneResultPrecioFinalMO = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.lbEtiquetaResultPrecioNetoMO = new System.Windows.Forms.Label();
			this.lbEtiquetaResultPrecioFinalMO = new System.Windows.Forms.Label();
			this.lbEtiquetaResultPrecioNetoMD = new System.Windows.Forms.Label();
			this.lbEtiquetaResultPrecioFinalMD = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lbResultlEtiquetaCampoAuxiliar5 = new System.Windows.Forms.Label();
			this.lbResultlEtiquetaCampoAuxiliar4 = new System.Windows.Forms.Label();
			this.lbResultlEtiquetaCampoAuxiliar2 = new System.Windows.Forms.Label();
			this.lbResultlEtiquetaCampoAuxiliar1 = new System.Windows.Forms.Label();
			this.lbResultlEtiquetaCampoAuxiliar3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtResultObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtResultCampoAuxiliar5 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtResultCampoAuxiliar4 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtResultCampoAuxiliar3 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtResultCampoAuxiliar2 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtResultCampoAuxiliar1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.txtResultDescripcion = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraTabPageControl2 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.pictureBoxThumb = new System.Windows.Forms.PictureBox();
			this.uneResultPrecioFinalMD2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneResultPrecioFinalMO2 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.lbEtiquetaResultPrecioFinalMD2 = new System.Windows.Forms.Label();
			this.lbEtiquetaResultPrecioFinalMO2 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.gridCondicionesDeVenta = new Janus.Windows.GridEX.GridEX();
			this.ultraTabPageControl3 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.uneResultPrecioFinalMD1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneResultPrecioFinalMO1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.lbEtiquetaResultPrecioFinalMD1 = new System.Windows.Forms.Label();
			this.lbEtiquetaResultPrecioFinalMO1 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.gridFormasDePago = new Janus.Windows.GridEX.GridEX();
			this.ultraTabPageControl4 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.label29 = new System.Windows.Forms.Label();
			this.ultraTabPageControl5 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.ultraTabPageControl6 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.label30 = new System.Windows.Forms.Label();
			this.ultraTabPageControl7 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.lbEtitutaResultPrecionFinal1 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.uneResultPrecionFinal1 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.txtResultDescripcion1 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.gridStock = new Infragistics.Win.UltraWinGrid.UltraGrid();
			this.ultraTabPageControl8 = new Infragistics.Win.UltraWinTabControl.UltraTabPageControl();
			this.label32 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.utcFiltros = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
			this.ultraTabSharedControlsPage2 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.utcDetalles = new Infragistics.Win.UltraWinTabControl.UltraTabControl();
			this.ultraTabSharedControlsPage1 = new Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridEx = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbBuscar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparador1 = new System.Windows.Forms.ToolBarButton();
			this.tbbNuevaBusqueda = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbNuevo = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbEditar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeprardor6 = new System.Windows.Forms.ToolBarButton();
			this.tbbAceptar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator7 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItemSeleccionarTodos = new System.Windows.Forms.MenuItem();
			this.menuItemDesSeleccionar = new System.Windows.Forms.MenuItem();
			this.utpFiltroPrincipal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboTipoProducto)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaDesde)).BeginInit();
			this.utpFiltroSecundario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).BeginInit();
			this.utpFiltroJerarquico.SuspendLayout();
			this.ultraTabPageControl9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).BeginInit();
			this.ultraTabPageControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioNetoMD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioNetoMO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMO)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultObservaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultDescripcion)).BeginInit();
			this.ultraTabPageControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMD2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMO2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCondicionesDeVenta)).BeginInit();
			this.ultraTabPageControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMD1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMO1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFormasDePago)).BeginInit();
			this.ultraTabPageControl4.SuspendLayout();
			this.ultraTabPageControl6.SuspendLayout();
			this.ultraTabPageControl7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecionFinal1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultDescripcion1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
			this.ultraTabPageControl8.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).BeginInit();
			this.utcFiltros.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.utcDetalles)).BeginInit();
			this.utcDetalles.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// utpFiltroPrincipal
			// 
			this.utpFiltroPrincipal.AutoScroll = true;
			this.utpFiltroPrincipal.Controls.Add(this.label12);
			this.utpFiltroPrincipal.Controls.Add(this.uceEntreFechas);
			this.utpFiltroPrincipal.Controls.Add(this.uceResponsable);
			this.utpFiltroPrincipal.Controls.Add(this.mzCEResponsable);
			this.utpFiltroPrincipal.Controls.Add(this.label10);
			this.utpFiltroPrincipal.Controls.Add(this.chkHabilitarActivo);
			this.utpFiltroPrincipal.Controls.Add(this.txtCodigoSecundario);
			this.utpFiltroPrincipal.Controls.Add(this.mzComboTipoProducto);
			this.utpFiltroPrincipal.Controls.Add(this.label9);
			this.utpFiltroPrincipal.Controls.Add(this.label5);
			this.utpFiltroPrincipal.Controls.Add(this.label4);
			this.utpFiltroPrincipal.Controls.Add(this.label3);
			this.utpFiltroPrincipal.Controls.Add(this.labelCodigoSec);
			this.utpFiltroPrincipal.Controls.Add(this.label1);
			this.utpFiltroPrincipal.Controls.Add(this.chkActivo);
			this.utpFiltroPrincipal.Controls.Add(this.txtDescripcionLarga);
			this.utpFiltroPrincipal.Controls.Add(this.txtDescripcionCorta);
			this.utpFiltroPrincipal.Controls.Add(this.txtDescripcion);
			this.utpFiltroPrincipal.Controls.Add(this.txtCodigo);
			this.utpFiltroPrincipal.Controls.Add(this.groupBox1);
			this.utpFiltroPrincipal.Location = new System.Drawing.Point(1, 23);
			this.utpFiltroPrincipal.Name = "utpFiltroPrincipal";
			this.utpFiltroPrincipal.Size = new System.Drawing.Size(858, 133);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(544, 49);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 16);
			this.label12.TabIndex = 138;
			this.label12.Text = "Fecha de alta";
			// 
			// uceEntreFechas
			// 
			this.uceEntreFechas.BackColor = System.Drawing.Color.Transparent;
			this.uceEntreFechas.Location = new System.Drawing.Point(656, 47);
			this.uceEntreFechas.Name = "uceEntreFechas";
			this.uceEntreFechas.Size = new System.Drawing.Size(13, 15);
			this.uceEntreFechas.TabIndex = 10;
			// 
			// uceResponsable
			// 
			this.uceResponsable.BackColor = System.Drawing.Color.Transparent;
			this.uceResponsable.Location = new System.Drawing.Point(839, 25);
			this.uceResponsable.Name = "uceResponsable";
			this.uceResponsable.Size = new System.Drawing.Size(16, 16);
			this.uceResponsable.TabIndex = 9;
			// 
			// mzCEResponsable
			// 
			this.mzCEResponsable.AutoComplete = true;
			this.mzCEResponsable.DataSource = null;
			this.mzCEResponsable.DisplayMember = "";
			this.mzCEResponsable.DisplayMemberCaption = "";
			this.mzCEResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsable.Location = new System.Drawing.Point(656, 23);
			this.mzCEResponsable.MaxItemsDisplay = 7;
			this.mzCEResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsable.Name = "mzCEResponsable";
			this.mzCEResponsable.Size = new System.Drawing.Size(177, 21);
			this.mzCEResponsable.SorterMember = "";
			this.mzCEResponsable.TabIndex = 8;
			this.mzCEResponsable.ValueMember = "";
			this.mzCEResponsable.ValueMemberCaption = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(544, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 16);
			this.label10.TabIndex = 132;
			this.label10.Text = "Responsable de alta";
			// 
			// chkHabilitarActivo
			// 
			this.chkHabilitarActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarActivo.Location = new System.Drawing.Point(776, 1);
			this.chkHabilitarActivo.Name = "chkHabilitarActivo";
			this.chkHabilitarActivo.Size = new System.Drawing.Size(72, 20);
			this.chkHabilitarActivo.TabIndex = 7;
			this.chkHabilitarActivo.Text = "Habilitar";
			this.chkHabilitarActivo.CheckedChanged += new System.EventHandler(this.chkHabilitarActivo_CheckedChanged);
			// 
			// txtCodigoSecundario
			// 
			this.txtCodigoSecundario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigoSecundario.Location = new System.Drawing.Point(112, 24);
			this.txtCodigoSecundario.Name = "txtCodigoSecundario";
			this.txtCodigoSecundario.Size = new System.Drawing.Size(160, 20);
			this.txtCodigoSecundario.TabIndex = 1;
			this.txtCodigoSecundario.Text = "";
			// 
			// mzComboTipoProducto
			// 
			this.mzComboTipoProducto.AutoComplete = true;
			this.mzComboTipoProducto.DataSource = null;
			this.mzComboTipoProducto.DisplayMember = "";
			this.mzComboTipoProducto.DisplayMemberCaption = "";
			this.mzComboTipoProducto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboTipoProducto.Location = new System.Drawing.Point(112, 106);
			this.mzComboTipoProducto.MaxItemsDisplay = 7;
			this.mzComboTipoProducto.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboTipoProducto.Name = "mzComboTipoProducto";
			this.mzComboTipoProducto.Size = new System.Drawing.Size(160, 21);
			this.mzComboTipoProducto.SorterMember = "";
			this.mzComboTipoProducto.TabIndex = 5;
			this.mzComboTipoProducto.ValueMember = "";
			this.mzComboTipoProducto.ValueMemberCaption = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 106);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 50;
			this.label9.Text = "Tipo de Producto";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 49;
			this.label5.Text = "Descripción Corta";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 48;
			this.label4.Text = "Descripción Larga";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(9, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 47;
			this.label3.Text = "Descripción";
			// 
			// labelCodigoSec
			// 
			this.labelCodigoSec.BackColor = System.Drawing.Color.Transparent;
			this.labelCodigoSec.Location = new System.Drawing.Point(9, 24);
			this.labelCodigoSec.Name = "labelCodigoSec";
			this.labelCodigoSec.Size = new System.Drawing.Size(104, 20);
			this.labelCodigoSec.TabIndex = 46;
			this.labelCodigoSec.Text = "Código Secundario";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(9, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 45;
			this.label1.Text = "Código";
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Enabled = false;
			this.chkActivo.Location = new System.Drawing.Point(656, 1);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.TabIndex = 6;
			this.chkActivo.Text = "Activo";
			// 
			// txtDescripcionLarga
			// 
			this.txtDescripcionLarga.Location = new System.Drawing.Point(112, 84);
			this.txtDescripcionLarga.Multiline = true;
			this.txtDescripcionLarga.Name = "txtDescripcionLarga";
			this.txtDescripcionLarga.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcionLarga.Size = new System.Drawing.Size(408, 20);
			this.txtDescripcionLarga.TabIndex = 4;
			this.txtDescripcionLarga.Text = "";
			// 
			// txtDescripcionCorta
			// 
			this.txtDescripcionCorta.Location = new System.Drawing.Point(112, 64);
			this.txtDescripcionCorta.Multiline = true;
			this.txtDescripcionCorta.Name = "txtDescripcionCorta";
			this.txtDescripcionCorta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcionCorta.Size = new System.Drawing.Size(408, 20);
			this.txtDescripcionCorta.TabIndex = 3;
			this.txtDescripcionCorta.Text = "";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(112, 44);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcion.Size = new System.Drawing.Size(408, 20);
			this.txtDescripcion.TabIndex = 2;
			this.txtDescripcion.Text = "";
			// 
			// txtCodigo
			// 
			this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigo.Location = new System.Drawing.Point(112, 4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(160, 20);
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.udtFechaAltaHasta);
			this.groupBox1.Controls.Add(this.udtFechaAltaDesde);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.lFecha);
			this.groupBox1.Location = new System.Drawing.Point(650, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 62);
			this.groupBox1.TabIndex = 137;
			this.groupBox1.TabStop = false;
			// 
			// udtFechaAltaHasta
			// 
			this.udtFechaAltaHasta.Location = new System.Drawing.Point(48, 35);
			this.udtFechaAltaHasta.Name = "udtFechaAltaHasta";
			this.udtFechaAltaHasta.Size = new System.Drawing.Size(135, 21);
			this.udtFechaAltaHasta.TabIndex = 12;
			// 
			// udtFechaAltaDesde
			// 
			this.udtFechaAltaDesde.Location = new System.Drawing.Point(48, 13);
			this.udtFechaAltaDesde.Name = "udtFechaAltaDesde";
			this.udtFechaAltaDesde.Size = new System.Drawing.Size(135, 21);
			this.udtFechaAltaDesde.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(11, 36);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 16);
			this.label11.TabIndex = 137;
			this.label11.Text = "Hasta";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lFecha
			// 
			this.lFecha.BackColor = System.Drawing.Color.Transparent;
			this.lFecha.Location = new System.Drawing.Point(11, 15);
			this.lFecha.Name = "lFecha";
			this.lFecha.Size = new System.Drawing.Size(80, 16);
			this.lFecha.TabIndex = 136;
			this.lFecha.Text = "Desde";
			this.lFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// utpFiltroSecundario
			// 
			this.utpFiltroSecundario.AutoScroll = true;
			this.utpFiltroSecundario.Controls.Add(this.chkHabilitarPercibeIB);
			this.utpFiltroSecundario.Controls.Add(this.chkHabilitarObligaNS);
			this.utpFiltroSecundario.Controls.Add(this.chkHabilitarObligaCB);
			this.utpFiltroSecundario.Controls.Add(this.label14);
			this.utpFiltroSecundario.Controls.Add(this.mzCEBonificacion);
			this.utpFiltroSecundario.Controls.Add(this.chkPercibeIB);
			this.utpFiltroSecundario.Controls.Add(this.chkObligaNumeroSerie);
			this.utpFiltroSecundario.Controls.Add(this.chkObligaCodigoBarra);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar5);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar5);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar4);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar4);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar2);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar2);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar1);
			this.utpFiltroSecundario.Controls.Add(this.label24);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar1);
			this.utpFiltroSecundario.Controls.Add(this.txtObservaciones);
			this.utpFiltroSecundario.Controls.Add(this.lblEtiquetaCampoAuxiliar3);
			this.utpFiltroSecundario.Controls.Add(this.txtCampoAuxiliar3);
			this.utpFiltroSecundario.Location = new System.Drawing.Point(-10000, -10000);
			this.utpFiltroSecundario.Name = "utpFiltroSecundario";
			this.utpFiltroSecundario.Size = new System.Drawing.Size(858, 133);
			// 
			// chkHabilitarPercibeIB
			// 
			this.chkHabilitarPercibeIB.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarPercibeIB.Location = new System.Drawing.Point(552, 74);
			this.chkHabilitarPercibeIB.Name = "chkHabilitarPercibeIB";
			this.chkHabilitarPercibeIB.TabIndex = 11;
			this.chkHabilitarPercibeIB.Text = "Habilitar";
			this.chkHabilitarPercibeIB.CheckedChanged += new System.EventHandler(this.chkHabilitarPercibeIB_CheckedChanged);
			// 
			// chkHabilitarObligaNS
			// 
			this.chkHabilitarObligaNS.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarObligaNS.Location = new System.Drawing.Point(552, 50);
			this.chkHabilitarObligaNS.Name = "chkHabilitarObligaNS";
			this.chkHabilitarObligaNS.TabIndex = 9;
			this.chkHabilitarObligaNS.Text = "Habilitar";
			this.chkHabilitarObligaNS.CheckedChanged += new System.EventHandler(this.chkHabilitarObligaNS_CheckedChanged);
			// 
			// chkHabilitarObligaCB
			// 
			this.chkHabilitarObligaCB.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitarObligaCB.Location = new System.Drawing.Point(552, 26);
			this.chkHabilitarObligaCB.Name = "chkHabilitarObligaCB";
			this.chkHabilitarObligaCB.TabIndex = 7;
			this.chkHabilitarObligaCB.Text = "Habilitar";
			this.chkHabilitarObligaCB.CheckedChanged += new System.EventHandler(this.chkHabilitarObligaCB_CheckedChanged);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(408, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 23);
			this.label14.TabIndex = 81;
			this.label14.Text = "Bonificacion";
			// 
			// mzCEBonificacion
			// 
			this.mzCEBonificacion.AutoComplete = true;
			this.mzCEBonificacion.DataSource = null;
			this.mzCEBonificacion.DisplayMember = "";
			this.mzCEBonificacion.DisplayMemberCaption = "";
			this.mzCEBonificacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEBonificacion.ImageTransparentColor = System.Drawing.Color.Violet;
			this.mzCEBonificacion.Location = new System.Drawing.Point(488, 96);
			this.mzCEBonificacion.MaxItemsDisplay = 7;
			this.mzCEBonificacion.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEBonificacion.Name = "mzCEBonificacion";
			this.mzCEBonificacion.Size = new System.Drawing.Size(184, 21);
			this.mzCEBonificacion.SorterMember = "";
			this.mzCEBonificacion.TabIndex = 12;
			this.mzCEBonificacion.ValueMember = "";
			this.mzCEBonificacion.ValueMemberCaption = "";
			// 
			// chkPercibeIB
			// 
			this.chkPercibeIB.BackColor = System.Drawing.Color.Transparent;
			this.chkPercibeIB.Enabled = false;
			this.chkPercibeIB.Location = new System.Drawing.Point(408, 74);
			this.chkPercibeIB.Name = "chkPercibeIB";
			this.chkPercibeIB.Size = new System.Drawing.Size(147, 20);
			this.chkPercibeIB.TabIndex = 10;
			this.chkPercibeIB.Text = "Percibe Ing. Brutos";
			// 
			// chkObligaNumeroSerie
			// 
			this.chkObligaNumeroSerie.BackColor = System.Drawing.Color.Transparent;
			this.chkObligaNumeroSerie.Enabled = false;
			this.chkObligaNumeroSerie.Location = new System.Drawing.Point(408, 50);
			this.chkObligaNumeroSerie.Name = "chkObligaNumeroSerie";
			this.chkObligaNumeroSerie.Size = new System.Drawing.Size(147, 20);
			this.chkObligaNumeroSerie.TabIndex = 8;
			this.chkObligaNumeroSerie.Text = "Obliga Numero de Serie";
			// 
			// chkObligaCodigoBarra
			// 
			this.chkObligaCodigoBarra.BackColor = System.Drawing.Color.Transparent;
			this.chkObligaCodigoBarra.Enabled = false;
			this.chkObligaCodigoBarra.Location = new System.Drawing.Point(408, 26);
			this.chkObligaCodigoBarra.Name = "chkObligaCodigoBarra";
			this.chkObligaCodigoBarra.Size = new System.Drawing.Size(147, 20);
			this.chkObligaCodigoBarra.TabIndex = 6;
			this.chkObligaCodigoBarra.Text = "Obliga Codigo Barras";
			// 
			// lblEtiquetaCampoAuxiliar5
			// 
			this.lblEtiquetaCampoAuxiliar5.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar5.Location = new System.Drawing.Point(8, 99);
			this.lblEtiquetaCampoAuxiliar5.Name = "lblEtiquetaCampoAuxiliar5";
			this.lblEtiquetaCampoAuxiliar5.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar5.TabIndex = 61;
			this.lblEtiquetaCampoAuxiliar5.Text = "Campo Auxiliar5";
			// 
			// txtCampoAuxiliar5
			// 
			this.txtCampoAuxiliar5.Location = new System.Drawing.Point(104, 99);
			this.txtCampoAuxiliar5.MaxLength = 256;
			this.txtCampoAuxiliar5.Name = "txtCampoAuxiliar5";
			this.txtCampoAuxiliar5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar5.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar5.TabIndex = 5;
			this.txtCampoAuxiliar5.Text = "";
			this.txtCampoAuxiliar5.WordWrap = false;
			// 
			// lblEtiquetaCampoAuxiliar4
			// 
			this.lblEtiquetaCampoAuxiliar4.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar4.Location = new System.Drawing.Point(8, 80);
			this.lblEtiquetaCampoAuxiliar4.Name = "lblEtiquetaCampoAuxiliar4";
			this.lblEtiquetaCampoAuxiliar4.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar4.TabIndex = 59;
			this.lblEtiquetaCampoAuxiliar4.Text = "Campo Auxiliar4";
			// 
			// txtCampoAuxiliar4
			// 
			this.txtCampoAuxiliar4.Location = new System.Drawing.Point(104, 80);
			this.txtCampoAuxiliar4.MaxLength = 256;
			this.txtCampoAuxiliar4.Name = "txtCampoAuxiliar4";
			this.txtCampoAuxiliar4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar4.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar4.TabIndex = 4;
			this.txtCampoAuxiliar4.Text = "";
			this.txtCampoAuxiliar4.WordWrap = false;
			// 
			// lblEtiquetaCampoAuxiliar2
			// 
			this.lblEtiquetaCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar2.Location = new System.Drawing.Point(8, 42);
			this.lblEtiquetaCampoAuxiliar2.Name = "lblEtiquetaCampoAuxiliar2";
			this.lblEtiquetaCampoAuxiliar2.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar2.TabIndex = 57;
			this.lblEtiquetaCampoAuxiliar2.Text = "Campo Auxiliar2";
			// 
			// txtCampoAuxiliar2
			// 
			this.txtCampoAuxiliar2.Location = new System.Drawing.Point(104, 42);
			this.txtCampoAuxiliar2.MaxLength = 256;
			this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
			this.txtCampoAuxiliar2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar2.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar2.TabIndex = 2;
			this.txtCampoAuxiliar2.Text = "";
			this.txtCampoAuxiliar2.WordWrap = false;
			// 
			// lblEtiquetaCampoAuxiliar1
			// 
			this.lblEtiquetaCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar1.Location = new System.Drawing.Point(8, 23);
			this.lblEtiquetaCampoAuxiliar1.Name = "lblEtiquetaCampoAuxiliar1";
			this.lblEtiquetaCampoAuxiliar1.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar1.TabIndex = 55;
			this.lblEtiquetaCampoAuxiliar1.Text = "Campo Auxiliar1";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(8, 4);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(80, 20);
			this.label24.TabIndex = 53;
			this.label24.Text = "Observaciones";
			// 
			// txtCampoAuxiliar1
			// 
			this.txtCampoAuxiliar1.Location = new System.Drawing.Point(104, 23);
			this.txtCampoAuxiliar1.MaxLength = 256;
			this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
			this.txtCampoAuxiliar1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar1.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar1.TabIndex = 1;
			this.txtCampoAuxiliar1.Text = "";
			this.txtCampoAuxiliar1.WordWrap = false;
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(104, 4);
			this.txtObservaciones.MaxLength = 255;
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtObservaciones.Size = new System.Drawing.Size(576, 20);
			this.txtObservaciones.TabIndex = 0;
			this.txtObservaciones.Text = "";
			// 
			// lblEtiquetaCampoAuxiliar3
			// 
			this.lblEtiquetaCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
			this.lblEtiquetaCampoAuxiliar3.Location = new System.Drawing.Point(8, 61);
			this.lblEtiquetaCampoAuxiliar3.Name = "lblEtiquetaCampoAuxiliar3";
			this.lblEtiquetaCampoAuxiliar3.Size = new System.Drawing.Size(96, 18);
			this.lblEtiquetaCampoAuxiliar3.TabIndex = 59;
			this.lblEtiquetaCampoAuxiliar3.Text = "Campo Auxiliar3";
			// 
			// txtCampoAuxiliar3
			// 
			this.txtCampoAuxiliar3.Location = new System.Drawing.Point(104, 61);
			this.txtCampoAuxiliar3.MaxLength = 256;
			this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
			this.txtCampoAuxiliar3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCampoAuxiliar3.Size = new System.Drawing.Size(296, 20);
			this.txtCampoAuxiliar3.TabIndex = 3;
			this.txtCampoAuxiliar3.Text = "";
			this.txtCampoAuxiliar3.WordWrap = false;
			// 
			// utpFiltroJerarquico
			// 
			this.utpFiltroJerarquico.Controls.Add(this.hierarchicalSearchControl1);
			this.utpFiltroJerarquico.Location = new System.Drawing.Point(-10000, -10000);
			this.utpFiltroJerarquico.Name = "utpFiltroJerarquico";
			this.utpFiltroJerarquico.Size = new System.Drawing.Size(858, 133);
			// 
			// hierarchicalSearchControl1
			// 
			this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
			this.hierarchicalSearchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 0);
			this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
			this.hierarchicalSearchControl1.Size = new System.Drawing.Size(858, 133);
			this.hierarchicalSearchControl1.TabIndex = 0;
			// 
			// ultraTabPageControl9
			// 
			this.ultraTabPageControl9.Controls.Add(this.FechaHasta);
			this.ultraTabPageControl9.Controls.Add(this.FechaDesde);
			this.ultraTabPageControl9.Controls.Add(this.label8);
			this.ultraTabPageControl9.Controls.Add(this.label7);
			this.ultraTabPageControl9.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl9.Name = "ultraTabPageControl9";
			this.ultraTabPageControl9.Size = new System.Drawing.Size(858, 133);
			// 
			// FechaHasta
			// 
			dateButton1.Caption = "Today";
			this.FechaHasta.DateButtons.Add(dateButton1);
			this.FechaHasta.Location = new System.Drawing.Point(96, 32);
			this.FechaHasta.Name = "FechaHasta";
			this.FechaHasta.NonAutoSizeHeight = 23;
			this.FechaHasta.Size = new System.Drawing.Size(96, 21);
			this.FechaHasta.TabIndex = 1;
			this.FechaHasta.Tag = "FechaDesde";
			// 
			// FechaDesde
			// 
			dateButton2.Caption = "Today";
			this.FechaDesde.DateButtons.Add(dateButton2);
			this.FechaDesde.Location = new System.Drawing.Point(96, 8);
			this.FechaDesde.Name = "FechaDesde";
			this.FechaDesde.NonAutoSizeHeight = 23;
			this.FechaDesde.Size = new System.Drawing.Size(96, 21);
			this.FechaDesde.TabIndex = 0;
			this.FechaDesde.Tag = "FechaDesde";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 16);
			this.label8.TabIndex = 47;
			this.label8.Text = "Fecha Hasta";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(9, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 16);
			this.label7.TabIndex = 46;
			this.label7.Text = "Fecha Desde";
			// 
			// ultraTabPageControl1
			// 
			this.ultraTabPageControl1.AutoScroll = true;
			this.ultraTabPageControl1.Controls.Add(this.uneResultPrecioFinalMD);
			this.ultraTabPageControl1.Controls.Add(this.uneResultPrecioNetoMD);
			this.ultraTabPageControl1.Controls.Add(this.uneResultPrecioNetoMO);
			this.ultraTabPageControl1.Controls.Add(this.uneResultPrecioFinalMO);
			this.ultraTabPageControl1.Controls.Add(this.lbEtiquetaResultPrecioNetoMO);
			this.ultraTabPageControl1.Controls.Add(this.lbEtiquetaResultPrecioFinalMO);
			this.ultraTabPageControl1.Controls.Add(this.lbEtiquetaResultPrecioNetoMD);
			this.ultraTabPageControl1.Controls.Add(this.lbEtiquetaResultPrecioFinalMD);
			this.ultraTabPageControl1.Controls.Add(this.label17);
			this.ultraTabPageControl1.Controls.Add(this.label16);
			this.ultraTabPageControl1.Controls.Add(this.label15);
			this.ultraTabPageControl1.Controls.Add(this.label13);
			this.ultraTabPageControl1.Controls.Add(this.lbResultlEtiquetaCampoAuxiliar5);
			this.ultraTabPageControl1.Controls.Add(this.lbResultlEtiquetaCampoAuxiliar4);
			this.ultraTabPageControl1.Controls.Add(this.lbResultlEtiquetaCampoAuxiliar2);
			this.ultraTabPageControl1.Controls.Add(this.lbResultlEtiquetaCampoAuxiliar1);
			this.ultraTabPageControl1.Controls.Add(this.lbResultlEtiquetaCampoAuxiliar3);
			this.ultraTabPageControl1.Controls.Add(this.label6);
			this.ultraTabPageControl1.Controls.Add(this.label2);
			this.ultraTabPageControl1.Controls.Add(this.txtResultObservaciones);
			this.ultraTabPageControl1.Controls.Add(this.txtResultCampoAuxiliar5);
			this.ultraTabPageControl1.Controls.Add(this.txtResultCampoAuxiliar4);
			this.ultraTabPageControl1.Controls.Add(this.txtResultCampoAuxiliar3);
			this.ultraTabPageControl1.Controls.Add(this.txtResultCampoAuxiliar2);
			this.ultraTabPageControl1.Controls.Add(this.txtResultCampoAuxiliar1);
			this.ultraTabPageControl1.Controls.Add(this.txtResultDescripcion);
			this.ultraTabPageControl1.Location = new System.Drawing.Point(1, 23);
			this.ultraTabPageControl1.Name = "ultraTabPageControl1";
			this.ultraTabPageControl1.Size = new System.Drawing.Size(858, 206);
			// 
			// uneResultPrecioFinalMD
			// 
			this.uneResultPrecioFinalMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.uneResultPrecioFinalMD.FormatString = "";
			this.uneResultPrecioFinalMD.Location = new System.Drawing.Point(600, 32);
			this.uneResultPrecioFinalMD.MaxValue = 47483647.99;
			this.uneResultPrecioFinalMD.MinValue = -47483648.99;
			this.uneResultPrecioFinalMD.Name = "uneResultPrecioFinalMD";
			this.uneResultPrecioFinalMD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioFinalMD.Size = new System.Drawing.Size(120, 28);
			this.uneResultPrecioFinalMD.TabIndex = 2;
			// 
			// uneResultPrecioNetoMD
			// 
			this.uneResultPrecioNetoMD.Location = new System.Drawing.Point(624, 64);
			this.uneResultPrecioNetoMD.MaxValue = 2147483647.99;
			this.uneResultPrecioNetoMD.MinValue = -2147483648.99;
			this.uneResultPrecioNetoMD.Name = "uneResultPrecioNetoMD";
			this.uneResultPrecioNetoMD.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioNetoMD.Size = new System.Drawing.Size(96, 21);
			this.uneResultPrecioNetoMD.TabIndex = 3;
			// 
			// uneResultPrecioNetoMO
			// 
			this.uneResultPrecioNetoMO.Location = new System.Drawing.Point(624, 112);
			this.uneResultPrecioNetoMO.MaxValue = 2147483647.99;
			this.uneResultPrecioNetoMO.MinValue = -2147483648.99;
			this.uneResultPrecioNetoMO.Name = "uneResultPrecioNetoMO";
			this.uneResultPrecioNetoMO.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioNetoMO.Size = new System.Drawing.Size(96, 21);
			this.uneResultPrecioNetoMO.TabIndex = 1873;
			// 
			// uneResultPrecioFinalMO
			// 
			this.uneResultPrecioFinalMO.Location = new System.Drawing.Point(624, 88);
			this.uneResultPrecioFinalMO.MaxValue = 2147483647.99;
			this.uneResultPrecioFinalMO.MinValue = -2147483648.99;
			this.uneResultPrecioFinalMO.Name = "uneResultPrecioFinalMO";
			this.uneResultPrecioFinalMO.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioFinalMO.Size = new System.Drawing.Size(96, 21);
			this.uneResultPrecioFinalMO.TabIndex = 4;
			// 
			// lbEtiquetaResultPrecioNetoMO
			// 
			this.lbEtiquetaResultPrecioNetoMO.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioNetoMO.Location = new System.Drawing.Point(536, 112);
			this.lbEtiquetaResultPrecioNetoMO.Name = "lbEtiquetaResultPrecioNetoMO";
			this.lbEtiquetaResultPrecioNetoMO.Size = new System.Drawing.Size(48, 20);
			this.lbEtiquetaResultPrecioNetoMO.TabIndex = 1871;
			this.lbEtiquetaResultPrecioNetoMO.Text = "Moneda";
			// 
			// lbEtiquetaResultPrecioFinalMO
			// 
			this.lbEtiquetaResultPrecioFinalMO.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioFinalMO.Location = new System.Drawing.Point(536, 88);
			this.lbEtiquetaResultPrecioFinalMO.Name = "lbEtiquetaResultPrecioFinalMO";
			this.lbEtiquetaResultPrecioFinalMO.Size = new System.Drawing.Size(48, 20);
			this.lbEtiquetaResultPrecioFinalMO.TabIndex = 1870;
			this.lbEtiquetaResultPrecioFinalMO.Text = "Moneda";
			// 
			// lbEtiquetaResultPrecioNetoMD
			// 
			this.lbEtiquetaResultPrecioNetoMD.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioNetoMD.Location = new System.Drawing.Point(536, 64);
			this.lbEtiquetaResultPrecioNetoMD.Name = "lbEtiquetaResultPrecioNetoMD";
			this.lbEtiquetaResultPrecioNetoMD.Size = new System.Drawing.Size(48, 20);
			this.lbEtiquetaResultPrecioNetoMD.TabIndex = 1869;
			this.lbEtiquetaResultPrecioNetoMD.Text = "Moneda";
			// 
			// lbEtiquetaResultPrecioFinalMD
			// 
			this.lbEtiquetaResultPrecioFinalMD.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioFinalMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbEtiquetaResultPrecioFinalMD.Location = new System.Drawing.Point(536, 32);
			this.lbEtiquetaResultPrecioFinalMD.Name = "lbEtiquetaResultPrecioFinalMD";
			this.lbEtiquetaResultPrecioFinalMD.Size = new System.Drawing.Size(56, 20);
			this.lbEtiquetaResultPrecioFinalMD.TabIndex = 1868;
			this.lbEtiquetaResultPrecioFinalMD.Text = "Moneda";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(392, 112);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(144, 20);
			this.label17.TabIndex = 1867;
			this.label17.Text = "Precio Neto Moneda Origen";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(392, 88);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(144, 20);
			this.label16.TabIndex = 1866;
			this.label16.Text = "Precio Final Imp. Incluidos";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(392, 64);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 20);
			this.label15.TabIndex = 1865;
			this.label15.Text = "Precio Neto";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(392, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(120, 32);
			this.label13.TabIndex = 1864;
			this.label13.Text = "Precio Final Impuestos Incluidos";
			// 
			// lbResultlEtiquetaCampoAuxiliar5
			// 
			this.lbResultlEtiquetaCampoAuxiliar5.BackColor = System.Drawing.Color.Transparent;
			this.lbResultlEtiquetaCampoAuxiliar5.Location = new System.Drawing.Point(8, 208);
			this.lbResultlEtiquetaCampoAuxiliar5.Name = "lbResultlEtiquetaCampoAuxiliar5";
			this.lbResultlEtiquetaCampoAuxiliar5.Size = new System.Drawing.Size(88, 18);
			this.lbResultlEtiquetaCampoAuxiliar5.TabIndex = 1863;
			this.lbResultlEtiquetaCampoAuxiliar5.Text = "Campo Auxiliar5";
			// 
			// lbResultlEtiquetaCampoAuxiliar4
			// 
			this.lbResultlEtiquetaCampoAuxiliar4.BackColor = System.Drawing.Color.Transparent;
			this.lbResultlEtiquetaCampoAuxiliar4.Location = new System.Drawing.Point(8, 184);
			this.lbResultlEtiquetaCampoAuxiliar4.Name = "lbResultlEtiquetaCampoAuxiliar4";
			this.lbResultlEtiquetaCampoAuxiliar4.Size = new System.Drawing.Size(88, 18);
			this.lbResultlEtiquetaCampoAuxiliar4.TabIndex = 1862;
			this.lbResultlEtiquetaCampoAuxiliar4.Text = "Campo Auxiliar4";
			// 
			// lbResultlEtiquetaCampoAuxiliar2
			// 
			this.lbResultlEtiquetaCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
			this.lbResultlEtiquetaCampoAuxiliar2.Location = new System.Drawing.Point(8, 136);
			this.lbResultlEtiquetaCampoAuxiliar2.Name = "lbResultlEtiquetaCampoAuxiliar2";
			this.lbResultlEtiquetaCampoAuxiliar2.Size = new System.Drawing.Size(88, 18);
			this.lbResultlEtiquetaCampoAuxiliar2.TabIndex = 1860;
			this.lbResultlEtiquetaCampoAuxiliar2.Text = "Campo Auxiliar2";
			// 
			// lbResultlEtiquetaCampoAuxiliar1
			// 
			this.lbResultlEtiquetaCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
			this.lbResultlEtiquetaCampoAuxiliar1.Location = new System.Drawing.Point(8, 112);
			this.lbResultlEtiquetaCampoAuxiliar1.Name = "lbResultlEtiquetaCampoAuxiliar1";
			this.lbResultlEtiquetaCampoAuxiliar1.Size = new System.Drawing.Size(88, 18);
			this.lbResultlEtiquetaCampoAuxiliar1.TabIndex = 1859;
			this.lbResultlEtiquetaCampoAuxiliar1.Text = "Campo Auxiliar1";
			// 
			// lbResultlEtiquetaCampoAuxiliar3
			// 
			this.lbResultlEtiquetaCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
			this.lbResultlEtiquetaCampoAuxiliar3.Location = new System.Drawing.Point(8, 160);
			this.lbResultlEtiquetaCampoAuxiliar3.Name = "lbResultlEtiquetaCampoAuxiliar3";
			this.lbResultlEtiquetaCampoAuxiliar3.Size = new System.Drawing.Size(88, 18);
			this.lbResultlEtiquetaCampoAuxiliar3.TabIndex = 1861;
			this.lbResultlEtiquetaCampoAuxiliar3.Text = "Campo Auxiliar3";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 1858;
			this.label6.Text = "Observaciones";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 1857;
			this.label2.Text = "Descripción";
			// 
			// txtResultObservaciones
			// 
			this.txtResultObservaciones.ImageTransparentColor = System.Drawing.SystemColors.Window;
			this.txtResultObservaciones.Location = new System.Drawing.Point(96, 64);
			this.txtResultObservaciones.Multiline = true;
			this.txtResultObservaciones.Name = "txtResultObservaciones";
			this.txtResultObservaciones.Size = new System.Drawing.Size(288, 40);
			this.txtResultObservaciones.TabIndex = 1;
			// 
			// txtResultCampoAuxiliar5
			// 
			this.txtResultCampoAuxiliar5.ImageTransparentColor = System.Drawing.SystemColors.Window;
			this.txtResultCampoAuxiliar5.Location = new System.Drawing.Point(96, 208);
			this.txtResultCampoAuxiliar5.Name = "txtResultCampoAuxiliar5";
			this.txtResultCampoAuxiliar5.Size = new System.Drawing.Size(288, 21);
			this.txtResultCampoAuxiliar5.TabIndex = 1855;
			// 
			// txtResultCampoAuxiliar4
			// 
			this.txtResultCampoAuxiliar4.ImageTransparentColor = System.Drawing.SystemColors.Window;
			this.txtResultCampoAuxiliar4.Location = new System.Drawing.Point(96, 184);
			this.txtResultCampoAuxiliar4.Name = "txtResultCampoAuxiliar4";
			this.txtResultCampoAuxiliar4.Size = new System.Drawing.Size(288, 21);
			this.txtResultCampoAuxiliar4.TabIndex = 1854;
			// 
			// txtResultCampoAuxiliar3
			// 
			this.txtResultCampoAuxiliar3.ImageTransparentColor = System.Drawing.SystemColors.Window;
			this.txtResultCampoAuxiliar3.Location = new System.Drawing.Point(96, 160);
			this.txtResultCampoAuxiliar3.Name = "txtResultCampoAuxiliar3";
			this.txtResultCampoAuxiliar3.Size = new System.Drawing.Size(288, 21);
			this.txtResultCampoAuxiliar3.TabIndex = 1853;
			// 
			// txtResultCampoAuxiliar2
			// 
			this.txtResultCampoAuxiliar2.ImageTransparentColor = System.Drawing.SystemColors.Window;
			this.txtResultCampoAuxiliar2.Location = new System.Drawing.Point(96, 136);
			this.txtResultCampoAuxiliar2.Name = "txtResultCampoAuxiliar2";
			this.txtResultCampoAuxiliar2.Size = new System.Drawing.Size(288, 21);
			this.txtResultCampoAuxiliar2.TabIndex = 1852;
			// 
			// txtResultCampoAuxiliar1
			// 
			this.txtResultCampoAuxiliar1.ImageTransparentColor = System.Drawing.SystemColors.Window;
			this.txtResultCampoAuxiliar1.Location = new System.Drawing.Point(96, 112);
			this.txtResultCampoAuxiliar1.Name = "txtResultCampoAuxiliar1";
			this.txtResultCampoAuxiliar1.Size = new System.Drawing.Size(288, 21);
			this.txtResultCampoAuxiliar1.TabIndex = 1851;
			// 
			// txtResultDescripcion
			// 
			this.txtResultDescripcion.ImageTransparentColor = System.Drawing.SystemColors.Window;
			this.txtResultDescripcion.Location = new System.Drawing.Point(96, 16);
			this.txtResultDescripcion.Multiline = true;
			this.txtResultDescripcion.Name = "txtResultDescripcion";
			this.txtResultDescripcion.Size = new System.Drawing.Size(288, 40);
			this.txtResultDescripcion.TabIndex = 0;
			// 
			// ultraTabPageControl2
			// 
			this.ultraTabPageControl2.AutoScroll = true;
			this.ultraTabPageControl2.Controls.Add(this.pictureBoxThumb);
			this.ultraTabPageControl2.Controls.Add(this.uneResultPrecioFinalMD2);
			this.ultraTabPageControl2.Controls.Add(this.uneResultPrecioFinalMO2);
			this.ultraTabPageControl2.Controls.Add(this.lbEtiquetaResultPrecioFinalMD2);
			this.ultraTabPageControl2.Controls.Add(this.lbEtiquetaResultPrecioFinalMO2);
			this.ultraTabPageControl2.Controls.Add(this.label25);
			this.ultraTabPageControl2.Controls.Add(this.gridCondicionesDeVenta);
			this.ultraTabPageControl2.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl2.Name = "ultraTabPageControl2";
			this.ultraTabPageControl2.Size = new System.Drawing.Size(858, 206);
			// 
			// pictureBoxThumb
			// 
			this.pictureBoxThumb.BackColor = System.Drawing.SystemColors.HighlightText;
			this.pictureBoxThumb.Location = new System.Drawing.Point(504, 128);
			this.pictureBoxThumb.Name = "pictureBoxThumb";
			this.pictureBoxThumb.Size = new System.Drawing.Size(160, 120);
			this.pictureBoxThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxThumb.TabIndex = 1876;
			this.pictureBoxThumb.TabStop = false;
			// 
			// uneResultPrecioFinalMD2
			// 
			this.uneResultPrecioFinalMD2.Location = new System.Drawing.Point(576, 80);
			this.uneResultPrecioFinalMD2.Name = "uneResultPrecioFinalMD2";
			this.uneResultPrecioFinalMD2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioFinalMD2.Size = new System.Drawing.Size(96, 21);
			this.uneResultPrecioFinalMD2.TabIndex = 12;
			// 
			// uneResultPrecioFinalMO2
			// 
			this.uneResultPrecioFinalMO2.Location = new System.Drawing.Point(576, 56);
			this.uneResultPrecioFinalMO2.Name = "uneResultPrecioFinalMO2";
			this.uneResultPrecioFinalMO2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioFinalMO2.Size = new System.Drawing.Size(96, 21);
			this.uneResultPrecioFinalMO2.TabIndex = 11;
			// 
			// lbEtiquetaResultPrecioFinalMD2
			// 
			this.lbEtiquetaResultPrecioFinalMD2.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioFinalMD2.Location = new System.Drawing.Point(520, 80);
			this.lbEtiquetaResultPrecioFinalMD2.Name = "lbEtiquetaResultPrecioFinalMD2";
			this.lbEtiquetaResultPrecioFinalMD2.Size = new System.Drawing.Size(48, 20);
			this.lbEtiquetaResultPrecioFinalMD2.TabIndex = 1873;
			this.lbEtiquetaResultPrecioFinalMD2.Text = "Moneda";
			// 
			// lbEtiquetaResultPrecioFinalMO2
			// 
			this.lbEtiquetaResultPrecioFinalMO2.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioFinalMO2.Location = new System.Drawing.Point(520, 56);
			this.lbEtiquetaResultPrecioFinalMO2.Name = "lbEtiquetaResultPrecioFinalMO2";
			this.lbEtiquetaResultPrecioFinalMO2.Size = new System.Drawing.Size(48, 20);
			this.lbEtiquetaResultPrecioFinalMO2.TabIndex = 1872;
			this.lbEtiquetaResultPrecioFinalMO2.Text = "Moneda";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(488, 24);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(144, 20);
			this.label25.TabIndex = 1871;
			this.label25.Text = "Precio Final Imp. Incluidos";
			// 
			// gridCondicionesDeVenta
			// 
			this.gridCondicionesDeVenta.AllowCardSizing = false;
			this.gridCondicionesDeVenta.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridCondicionesDeVenta.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridCondicionesDeVenta.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCondicionesDeVenta.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridCondicionesDeVenta.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridCondicionesDeVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridCondicionesDeVenta.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCondicionesDeVenta.Location = new System.Drawing.Point(8, 8);
			this.gridCondicionesDeVenta.Name = "gridCondicionesDeVenta";
			this.gridCondicionesDeVenta.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridCondicionesDeVenta.Size = new System.Drawing.Size(472, 208);
			this.gridCondicionesDeVenta.TabIndex = 10;
			this.gridCondicionesDeVenta.TabStop = false;
			// 
			// ultraTabPageControl3
			// 
			this.ultraTabPageControl3.AutoScroll = true;
			this.ultraTabPageControl3.Controls.Add(this.uneResultPrecioFinalMD1);
			this.ultraTabPageControl3.Controls.Add(this.uneResultPrecioFinalMO1);
			this.ultraTabPageControl3.Controls.Add(this.lbEtiquetaResultPrecioFinalMD1);
			this.ultraTabPageControl3.Controls.Add(this.lbEtiquetaResultPrecioFinalMO1);
			this.ultraTabPageControl3.Controls.Add(this.label28);
			this.ultraTabPageControl3.Controls.Add(this.gridFormasDePago);
			this.ultraTabPageControl3.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl3.Name = "ultraTabPageControl3";
			this.ultraTabPageControl3.Size = new System.Drawing.Size(858, 206);
			// 
			// uneResultPrecioFinalMD1
			// 
			this.uneResultPrecioFinalMD1.Location = new System.Drawing.Point(576, 72);
			this.uneResultPrecioFinalMD1.Name = "uneResultPrecioFinalMD1";
			this.uneResultPrecioFinalMD1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioFinalMD1.Size = new System.Drawing.Size(96, 21);
			this.uneResultPrecioFinalMD1.TabIndex = 22;
			// 
			// uneResultPrecioFinalMO1
			// 
			this.uneResultPrecioFinalMO1.Location = new System.Drawing.Point(576, 48);
			this.uneResultPrecioFinalMO1.Name = "uneResultPrecioFinalMO1";
			this.uneResultPrecioFinalMO1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecioFinalMO1.Size = new System.Drawing.Size(96, 21);
			this.uneResultPrecioFinalMO1.TabIndex = 21;
			// 
			// lbEtiquetaResultPrecioFinalMD1
			// 
			this.lbEtiquetaResultPrecioFinalMD1.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioFinalMD1.Location = new System.Drawing.Point(520, 72);
			this.lbEtiquetaResultPrecioFinalMD1.Name = "lbEtiquetaResultPrecioFinalMD1";
			this.lbEtiquetaResultPrecioFinalMD1.Size = new System.Drawing.Size(48, 20);
			this.lbEtiquetaResultPrecioFinalMD1.TabIndex = 1876;
			this.lbEtiquetaResultPrecioFinalMD1.Text = "Moneda";
			// 
			// lbEtiquetaResultPrecioFinalMO1
			// 
			this.lbEtiquetaResultPrecioFinalMO1.BackColor = System.Drawing.Color.Transparent;
			this.lbEtiquetaResultPrecioFinalMO1.Location = new System.Drawing.Point(520, 48);
			this.lbEtiquetaResultPrecioFinalMO1.Name = "lbEtiquetaResultPrecioFinalMO1";
			this.lbEtiquetaResultPrecioFinalMO1.Size = new System.Drawing.Size(48, 20);
			this.lbEtiquetaResultPrecioFinalMO1.TabIndex = 1875;
			this.lbEtiquetaResultPrecioFinalMO1.Text = "Moneda";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Location = new System.Drawing.Point(488, 16);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(144, 20);
			this.label28.TabIndex = 1874;
			this.label28.Text = "Precio Final Imp. Incluidos";
			// 
			// gridFormasDePago
			// 
			this.gridFormasDePago.AllowCardSizing = false;
			this.gridFormasDePago.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridFormasDePago.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridFormasDePago.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridFormasDePago.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridFormasDePago.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridFormasDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridFormasDePago.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridFormasDePago.Location = new System.Drawing.Point(8, 8);
			this.gridFormasDePago.Name = "gridFormasDePago";
			this.gridFormasDePago.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridFormasDePago.Size = new System.Drawing.Size(472, 208);
			this.gridFormasDePago.TabIndex = 20;
			this.gridFormasDePago.TabStop = false;
			// 
			// ultraTabPageControl4
			// 
			this.ultraTabPageControl4.AutoScroll = true;
			this.ultraTabPageControl4.Controls.Add(this.label29);
			this.ultraTabPageControl4.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl4.Name = "ultraTabPageControl4";
			this.ultraTabPageControl4.Size = new System.Drawing.Size(858, 206);
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label29.ForeColor = System.Drawing.Color.White;
			this.label29.Location = new System.Drawing.Point(214, 91);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(248, 16);
			this.label29.TabIndex = 2;
			this.label29.Text = "Funcionalidad No Habilitada";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraTabPageControl5
			// 
			this.ultraTabPageControl5.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl5.Name = "ultraTabPageControl5";
			this.ultraTabPageControl5.Size = new System.Drawing.Size(858, 206);
			// 
			// ultraTabPageControl6
			// 
			this.ultraTabPageControl6.Controls.Add(this.label30);
			this.ultraTabPageControl6.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl6.Name = "ultraTabPageControl6";
			this.ultraTabPageControl6.Size = new System.Drawing.Size(858, 206);
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label30.ForeColor = System.Drawing.Color.White;
			this.label30.Location = new System.Drawing.Point(214, 91);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(248, 16);
			this.label30.TabIndex = 2;
			this.label30.Text = "Funcionalidad No Habilitada";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraTabPageControl7
			// 
			this.ultraTabPageControl7.AutoScroll = true;
			this.ultraTabPageControl7.Controls.Add(this.lbEtitutaResultPrecionFinal1);
			this.ultraTabPageControl7.Controls.Add(this.label34);
			this.ultraTabPageControl7.Controls.Add(this.label31);
			this.ultraTabPageControl7.Controls.Add(this.uneResultPrecionFinal1);
			this.ultraTabPageControl7.Controls.Add(this.txtResultDescripcion1);
			this.ultraTabPageControl7.Controls.Add(this.gridStock);
			this.ultraTabPageControl7.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl7.Name = "ultraTabPageControl7";
			this.ultraTabPageControl7.Size = new System.Drawing.Size(858, 206);
			// 
			// lbEtitutaResultPrecionFinal1
			// 
			this.lbEtitutaResultPrecionFinal1.BackColor = System.Drawing.Color.Transparent;
			this.lbEtitutaResultPrecionFinal1.Location = new System.Drawing.Point(512, 120);
			this.lbEtitutaResultPrecionFinal1.Name = "lbEtitutaResultPrecionFinal1";
			this.lbEtitutaResultPrecionFinal1.Size = new System.Drawing.Size(48, 20);
			this.lbEtitutaResultPrecionFinal1.TabIndex = 1878;
			this.lbEtitutaResultPrecionFinal1.Text = "Moneda";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(448, 104);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(144, 20);
			this.label34.TabIndex = 1877;
			this.label34.Text = "Precio Final Imp. Incluidos";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Location = new System.Drawing.Point(448, 8);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(100, 20);
			this.label31.TabIndex = 1858;
			this.label31.Text = "Descripción";
			// 
			// uneResultPrecionFinal1
			// 
			this.uneResultPrecionFinal1.Location = new System.Drawing.Point(592, 120);
			this.uneResultPrecionFinal1.Name = "uneResultPrecionFinal1";
			this.uneResultPrecionFinal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneResultPrecionFinal1.Size = new System.Drawing.Size(100, 21);
			this.uneResultPrecionFinal1.TabIndex = 1830;
			// 
			// txtResultDescripcion1
			// 
			this.txtResultDescripcion1.Location = new System.Drawing.Point(448, 32);
			this.txtResultDescripcion1.Multiline = true;
			this.txtResultDescripcion1.Name = "txtResultDescripcion1";
			this.txtResultDescripcion1.Size = new System.Drawing.Size(240, 56);
			this.txtResultDescripcion1.TabIndex = 31;
			// 
			// gridStock
			// 
			this.gridStock.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridStock.Location = new System.Drawing.Point(8, 8);
			this.gridStock.Name = "gridStock";
			this.gridStock.Size = new System.Drawing.Size(424, 208);
			this.gridStock.TabIndex = 30;
			this.gridStock.Text = "Stock";
			// 
			// ultraTabPageControl8
			// 
			this.ultraTabPageControl8.Controls.Add(this.label32);
			this.ultraTabPageControl8.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabPageControl8.Name = "ultraTabPageControl8";
			this.ultraTabPageControl8.Size = new System.Drawing.Size(858, 206);
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label32.ForeColor = System.Drawing.Color.White;
			this.label32.Location = new System.Drawing.Point(214, 91);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(248, 16);
			this.label32.TabIndex = 1;
			this.label32.Text = "Funcionalidad No Habilitada";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.AutoScroll = true;
			this.ultraExplorerBarContainerControl1.Controls.Add(this.utcFiltros);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(862, 159);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// utcFiltros
			// 
			this.utcFiltros.BackColor = System.Drawing.Color.Transparent;
			this.utcFiltros.Controls.Add(this.ultraTabSharedControlsPage2);
			this.utcFiltros.Controls.Add(this.utpFiltroPrincipal);
			this.utcFiltros.Controls.Add(this.utpFiltroJerarquico);
			this.utcFiltros.Controls.Add(this.utpFiltroSecundario);
			this.utcFiltros.Controls.Add(this.ultraTabPageControl9);
			this.utcFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcFiltros.Location = new System.Drawing.Point(0, 0);
			this.utcFiltros.Name = "utcFiltros";
			this.utcFiltros.SharedControlsPage = this.ultraTabSharedControlsPage2;
			this.utcFiltros.Size = new System.Drawing.Size(862, 159);
			this.utcFiltros.TabIndex = 0;
			appearance1.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ActiveAppearance = appearance1;
			appearance2.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.Appearance = appearance2;
			appearance3.BackColor = System.Drawing.Color.Transparent;
			ultraTab1.ClientAreaAppearance = appearance3;
			ultraTab1.Key = "FiltroPrincipal";
			ultraTab1.TabPage = this.utpFiltroPrincipal;
			ultraTab1.Text = "Filtro Principal";
			appearance4.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.ActiveAppearance = appearance4;
			appearance5.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.Appearance = appearance5;
			appearance6.BackColor = System.Drawing.Color.Transparent;
			ultraTab2.ClientAreaAppearance = appearance6;
			ultraTab2.Key = "FiltroSecundario";
			ultraTab2.TabPage = this.utpFiltroSecundario;
			ultraTab2.Text = "Filtro Secundario";
			appearance7.BackColor = System.Drawing.Color.Transparent;
			ultraTab3.ActiveAppearance = appearance7;
			appearance8.BackColor = System.Drawing.Color.Transparent;
			ultraTab3.Appearance = appearance8;
			appearance9.BackColor = System.Drawing.Color.Transparent;
			ultraTab3.ClientAreaAppearance = appearance9;
			ultraTab3.Key = "FiltroJerarquico";
			ultraTab3.TabPage = this.utpFiltroJerarquico;
			ultraTab3.Text = "Filtro Jerárquico";
			ultraTab4.Key = "FiltroAuxiliar";
			ultraTab4.TabPage = this.ultraTabPageControl9;
			ultraTab4.Text = "Filtro Auxiliar";
			this.utcFiltros.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
																								 ultraTab1,
																								 ultraTab2,
																								 ultraTab3,
																								 ultraTab4});
			this.utcFiltros.TabStop = false;
			// 
			// ultraTabSharedControlsPage2
			// 
			this.ultraTabSharedControlsPage2.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabSharedControlsPage2.Name = "ultraTabSharedControlsPage2";
			this.ultraTabSharedControlsPage2.Size = new System.Drawing.Size(858, 133);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.AutoScroll = true;
			this.ultraExplorerBarContainerControl2.Controls.Add(this.utcDetalles);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEx);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 267);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(862, 392);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// utcDetalles
			// 
			this.utcDetalles.Controls.Add(this.ultraTabSharedControlsPage1);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl1);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl2);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl3);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl4);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl5);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl6);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl7);
			this.utcDetalles.Controls.Add(this.ultraTabPageControl8);
			this.utcDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.utcDetalles.Location = new System.Drawing.Point(0, 160);
			this.utcDetalles.Name = "utcDetalles";
			this.utcDetalles.SharedControlsPage = this.ultraTabSharedControlsPage1;
			this.utcDetalles.Size = new System.Drawing.Size(862, 232);
			this.utcDetalles.TabIndex = 18;
			ultraTab5.Key = "Precios";
			ultraTab5.TabPage = this.ultraTabPageControl1;
			ultraTab5.Text = "Precios, Descripciones";
			ultraTab6.Key = "PreciosCondicionesDeVenta";
			ultraTab6.TabPage = this.ultraTabPageControl2;
			ultraTab6.Text = "Precios por Condiciones de venta";
			ultraTab7.Key = "PreciosMediosDePago";
			ultraTab7.TabPage = this.ultraTabPageControl3;
			ultraTab7.Text = "Precios por Medio de Pago";
			ultraTab8.Key = "Medidas";
			ultraTab8.TabPage = this.ultraTabPageControl4;
			ultraTab8.Text = "Medidas y Conversiones";
			ultraTab9.Key = "Imagenes";
			ultraTab9.TabPage = this.ultraTabPageControl5;
			ultraTab9.Text = "Imágenes";
			ultraTab10.Key = "Agrupamientos";
			ultraTab10.TabPage = this.ultraTabPageControl6;
			ultraTab10.Text = "Agrupamientos";
			ultraTab11.Key = "Stock";
			ultraTab11.TabPage = this.ultraTabPageControl7;
			ultraTab11.Text = "Stock";
			ultraTab12.Key = "ProductosAsociados";
			ultraTab12.TabPage = this.ultraTabPageControl8;
			ultraTab12.Text = "Productos Asociados";
			this.utcDetalles.Tabs.AddRange(new Infragistics.Win.UltraWinTabControl.UltraTab[] {
																								  ultraTab5,
																								  ultraTab6,
																								  ultraTab7,
																								  ultraTab8,
																								  ultraTab9,
																								  ultraTab10,
																								  ultraTab11,
																								  ultraTab12});
			// 
			// ultraTabSharedControlsPage1
			// 
			this.ultraTabSharedControlsPage1.Location = new System.Drawing.Point(-10000, -10000);
			this.ultraTabSharedControlsPage1.Name = "ultraTabSharedControlsPage1";
			this.ultraTabSharedControlsPage1.Size = new System.Drawing.Size(858, 206);
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(16, 24);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(672, 24);
			this.gridManagerView1.TabIndex = 17;
			this.gridManagerView1.Visible = false;
			// 
			// gridEx
			// 
			this.gridEx.AllowDrop = true;
			this.gridEx.AlternatingColors = true;
			this.gridEx.AutoEdit = true;
			this.gridEx.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEx.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEx.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridEx.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEx.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEx.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEx.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEx.GroupByBoxVisible = false;
			this.gridEx.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEx.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEx.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEx.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEx.Location = new System.Drawing.Point(0, 0);
			this.gridEx.Name = "gridEx";
			this.gridEx.RecordNavigatorText = "Registro:|de";
			this.gridEx.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEx.ShowEmptyFields = false;
			this.gridEx.Size = new System.Drawing.Size(862, 160);
			this.gridEx.TabIndex = 6;
			this.gridEx.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbBuscar,
																							  this.tbbSeparador1,
																							  this.tbbNuevaBusqueda,
																							  this.tbbSeparator2,
																							  this.tbbNuevo,
																							  this.tbbSeparator3,
																							  this.tbbEditar,
																							  this.tbbSeparator4,
																							  this.tbbAnterior,
																							  this.tbbSeparator5,
																							  this.tbbSiguiente,
																							  this.tbbSeprardor6,
																							  this.tbbAceptar,
																							  this.tbbSeparator7,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(928, 28);
			this.toolBarStandar.TabIndex = 49;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbBuscar
			// 
			this.tbbBuscar.ImageIndex = 10;
			this.tbbBuscar.Text = "[F2] Buscar ahora";
			// 
			// tbbSeparador1
			// 
			this.tbbSeparador1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbNuevaBusqueda
			// 
			this.tbbNuevaBusqueda.ImageIndex = 5;
			this.tbbNuevaBusqueda.Text = "Nueva búsqueda";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbNuevo
			// 
			this.tbbNuevo.ImageIndex = 11;
			this.tbbNuevo.Text = "Nuevo";
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbEditar
			// 
			this.tbbEditar.ImageIndex = 6;
			this.tbbEditar.Text = "Editar";
			// 
			// tbbSeparator4
			// 
			this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator5
			// 
			this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "Siguiente";
			// 
			// tbbSeprardor6
			// 
			this.tbbSeprardor6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbAceptar
			// 
			this.tbbAceptar.ImageIndex = 12;
			this.tbbAceptar.Text = "Aceptar";
			// 
			// tbbSeparator7
			// 
			this.tbbSeparator7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
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
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 159;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Filtros";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 392;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Scrollbars = Infragistics.Win.UltraWinExplorerBar.ScrollbarStyle.Always;
			this.ultraExplorerBar1.Size = new System.Drawing.Size(928, 529);
			this.ultraExplorerBar1.TabIndex = 81;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemSeleccionarTodos,
																						 this.menuItemDesSeleccionar});
			// 
			// menuItemSeleccionarTodos
			// 
			this.menuItemSeleccionarTodos.Index = 0;
			this.menuItemSeleccionarTodos.Text = "Todos";
			// 
			// menuItemDesSeleccionar
			// 
			this.menuItemDesSeleccionar.Index = 1;
			this.menuItemDesSeleccionar.Text = "Ninguno";
			// 
			// mzProductosSearchFormWorkflow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(928, 557);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "mzProductosSearchFormWorkflow";
			this.Text = "mzProductosSearchFormWorkflow";
			this.utpFiltroPrincipal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboTipoProducto)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udtFechaAltaDesde)).EndInit();
			this.utpFiltroSecundario.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).EndInit();
			this.utpFiltroJerarquico.ResumeLayout(false);
			this.ultraTabPageControl9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FechaHasta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FechaDesde)).EndInit();
			this.ultraTabPageControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioNetoMD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioNetoMO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMO)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultObservaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultCampoAuxiliar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultDescripcion)).EndInit();
			this.ultraTabPageControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMD2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMO2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCondicionesDeVenta)).EndInit();
			this.ultraTabPageControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMD1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecioFinalMO1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFormasDePago)).EndInit();
			this.ultraTabPageControl4.ResumeLayout(false);
			this.ultraTabPageControl6.ResumeLayout(false);
			this.ultraTabPageControl7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneResultPrecionFinal1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtResultDescripcion1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
			this.ultraTabPageControl8.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.utcFiltros)).EndInit();
			this.utcFiltros.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.utcDetalles)).EndInit();
			this.utcDetalles.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores		

		public mzProductosSearchFormWorkflow(mzProductosSearchFormWorkflowController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
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
				this.toolBarStandar.ButtonClick -=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Variables privadas
		private mzProductosSearchFormWorkflowController _uiController;
		#endregion

		#region Propiedades
		#endregion

		#region Miembros de ITaskForm
		public void ShowForm()
		{
			Init();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();			
		}

		public void CloseForm()
		{
			Close();			
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			_uiController.Execute();
		}

		public void Execute()
		{			
		}

		public void Previous()
		{
			
		}

		#endregion

		#region Métodos privados

		private void Init()
		{
			Build_UI();
		}

		private void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();
			FillControls();
		}

		private void ConfigureInterface()
		{
			this.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator5.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			foreach(Infragistics.Win.UltraWinTabControl.UltraTab tab in utcFiltros.Tabs)
				tab.Enabled = false;

			if(!_uiController.SolapasHabilitadas.Equals(string.Empty))
			{								
				ArrayList tabs = mz.erp.systemframework.Util.Parse(_uiController.SolapasHabilitadas, ",");
				foreach(string keyTab in tabs)
                    utcFiltros.Tabs[keyTab].Enabled = true;
			}

			if(!_uiController.SolapaActiva.Equals(string.Empty))
                utcFiltros.SelectedTab = utcFiltros.Tabs[_uiController.SolapaActiva];

			txtCodigo.Enabled = _uiController.AllowEditCodigo;
			txtCodigoSecundario.Enabled = _uiController.AllowEditCodigoSecundario;
			txtDescripcion.Enabled = _uiController.AllowEditDescripcion;
			txtDescripcionCorta.Enabled = _uiController.AllowEditDescripcionCorta;
			txtDescripcionLarga.Enabled = _uiController.AllowEditDescripcionLarga;
			chkActivo.Enabled = _uiController.AllowEditActivo;
			chkHabilitarActivo.Enabled = _uiController.AllowEditHabilitarActivo;
			mzComboTipoProducto.Enabled = _uiController.AllowEditTipoProducto;
			txtObservaciones.Enabled = _uiController.AllowEditObservaciones;
			txtCampoAuxiliar1.Enabled = _uiController.AllowEditCampoAuxiliar1;
			txtCampoAuxiliar2.Enabled = _uiController.AllowEditCampoAuxiliar2;
			txtCampoAuxiliar3.Enabled = _uiController.AllowEditCampoAuxiliar3;
			txtCampoAuxiliar4.Enabled = _uiController.AllowEditCampoAuxiliar4;
			txtCampoAuxiliar5.Enabled = _uiController.AllowEditCampoAuxiliar5;
			chkObligaCodigoBarra.Enabled = _uiController.AllowEditObligaCodigoBarra;
			chkHabilitarObligaCB.Enabled = _uiController.AllowEditHabilitarObligaCB;
			chkObligaNumeroSerie.Enabled = _uiController.AllowEditObligaNumeroSerie;
			chkHabilitarObligaNS.Enabled = _uiController.AllowEditHabilitarObligaNS;
			chkPercibeIB.Enabled = _uiController.AllowEditPercibeIB;
			chkHabilitarPercibeIB.Enabled = _uiController.AllowEditHabilitarPercibeIB;
			mzCEBonificacion.Enabled = _uiController.AllowEditBonificacion;
			FechaDesde.Enabled = _uiController.AllowEditFechaDesde;
			FechaHasta.Enabled = _uiController.AllowEditFechaHasta;
            
			//TODO hacer la conf de la grilla
			gridManagerView1.Configure(_uiController.ProcessName, _uiController.GetTaskName(), gridEx, this.Text);

			//gridManagerView1.Configure("ProcesoConsultarProductos", "ConsultarProductos", gridEx, this.Text);

			this.hierarchicalSearchControl1.Build_UI("PRODUCTOS", _uiController.BuscadorJerarquicoAllowMultipleSelect);	
			
			lblEtiquetaCampoAuxiliar1.Text = _uiController.EtiquetaCampoAuxiliar1;
			lblEtiquetaCampoAuxiliar2.Text = _uiController.EtiquetaCampoAuxiliar2;
			lblEtiquetaCampoAuxiliar3.Text = _uiController.EtiquetaCampoAuxiliar3;
			lblEtiquetaCampoAuxiliar4.Text = _uiController.EtiquetaCampoAuxiliar4;
			lblEtiquetaCampoAuxiliar5.Text = _uiController.EtiquetaCampoAuxiliar5;
			lbResultlEtiquetaCampoAuxiliar1.Text = lblEtiquetaCampoAuxiliar1.Text;
			lbResultlEtiquetaCampoAuxiliar2.Text = lblEtiquetaCampoAuxiliar2.Text;
			lbResultlEtiquetaCampoAuxiliar3.Text = lblEtiquetaCampoAuxiliar3.Text;
			lbResultlEtiquetaCampoAuxiliar4.Text = lblEtiquetaCampoAuxiliar4.Text;
			lbResultlEtiquetaCampoAuxiliar5.Text = lblEtiquetaCampoAuxiliar5.Text;
			mzComboTipoProducto.FillFromDataSource( _uiController.TiposProductos, _uiController.KeyValueTiposProductos, _uiController.KeyListTiposProductos, 100, _uiController.KeyListTiposProductos);
			mzCEBonificacion.FillFromDataSource( _uiController.Bonificaciones, _uiController.KeyValueBonificaciones, _uiController.KeyListBonificaciones, 100, _uiController.KeyListBonificaciones);

			if (!_uiController.SolapaMedidasVisible) this.utcDetalles.Controls.Remove(this.ultraTabPageControl4);						
			if (!_uiController.SolapaStockVisible) this.utcDetalles.Controls.Remove(this.ultraTabPageControl7);
			if (!_uiController.SolapaPreciosVisible) this.utcDetalles.Controls.Remove(this.ultraTabPageControl1);
			if (!_uiController.SolapaPreciosMediosDePagoVisible) this.utcDetalles.Controls.Remove(this.ultraTabPageControl3);
			if (!_uiController.SolapaAgrupamientosVisible) this.utcDetalles.Controls.Remove(this.ultraTabPageControl6);
			if (!_uiController.SolapaProductosAsociadosVisible) this.utcDetalles.Controls.Remove(this.ultraTabPageControl8);

			this.gridCondicionesDeVenta.LayoutData = _uiController.LayoutPreciosPorCondicionesDeVenta;
			this.gridFormasDePago.LayoutData = _uiController.LayoutFormasDePago;
			KeyPreview = true;

			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			uceEntreFechas.Enabled = true;
			uceResponsable.Enabled = true;
			mzCEResponsable.Enabled = false;
			udtFechaAltaDesde.Enabled = false;
			udtFechaAltaHasta.Enabled = false;
			// ---- Fin Matias

			if (_uiController.ProcessName.Equals("ProcesoDesactivarProductosSinMovimientos"))
			{
				tbbAceptar.Visible = false;
				tbbCancelar.Visible = false;
				tbbEditar.Visible = false;
				tbbNuevo.Visible = false;
				tbbSeparator2.Visible = false;
				tbbSeparator4.Visible = false;
				tbbSeprardor6.Visible = false;
				tbbSeparator7.Visible = false;
			}

		}

		private void InitializeData()
		{
			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			mzCEResponsable.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
			mzCEResponsable.Value = _uiController.IdResponsable;
			udtFechaAltaDesde.Value = _uiController.FechaAltaDesde;
			udtFechaAltaDesde.Value = _uiController.FechaAltaHasta;
			// ---- Fin Matias
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			this.hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);			
			this.gridEx.SelectionChanged += new System.EventHandler(this.gridEx_SelectionChanged);
			_uiController.DetalleChanged +=new EventHandler(_uiController_DetalleChanged);
			this.menuItemDesSeleccionar.Click +=new EventHandler(menuItemDesSeleccionar_Click);
			this.menuItemSeleccionarTodos.Click +=new EventHandler(menuItemSeleccionarTodos_Click);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
			this.uceResponsable.CheckedChanged+=new EventHandler(uceResponsable_CheckedChanged);
			this.uceEntreFechas.CheckedChanged+=new EventHandler(uceEntreFechas_CheckedChanged);
		}

		private void InitDataBindings()
		{
		}

		private void FillControls() 
		{
		}


		#endregion

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: /*Buscar Ahora*/
					this.SearchNow();
					break;
				case 2: /*Nueva Búsqueda*/
					this.ResetParameters();
					break;
				case 4: /*Nuevo*/
					this.Nuevo();
					break;
				case 6: /*Editar*/
					this.Editar();
					break;
				case 8:/*Anterior*/
					_uiController.Previous();
					break;
				case 10:/*Siguiente*/
					gridEx.UpdateData();
					_uiController.Execute();
					break;
				case 12: /*Aceptar*/
                    _uiController.Execute();
					break;
				case 14: /*Cancelar*/
					this.Cancelar();
					break;
				
			}		
		}

		private void SearchNow()
		{						
			this.Cursor = Cursors.WaitCursor;
			_uiController.Codigo = txtCodigo.Text;
			_uiController.CodigoSecundario = txtCodigoSecundario.Text;
			_uiController.Descripcion = txtDescripcion.Text;
			_uiController.DescripcionCorta = txtDescripcionCorta.Text;
            _uiController.DescripcionLarga = txtDescripcionLarga.Text;
			_uiController.Activo = chkActivo.Checked;
			_uiController.ByActivo = chkHabilitarActivo.Checked;
			_uiController.IdTipoProducto = (string) mzComboTipoProducto.Value;
			_uiController.Observaciones = txtObservaciones.Text;
			_uiController.CampoAuxiliar1 = txtCampoAuxiliar1.Text;
			_uiController.CampoAuxiliar2 = txtCampoAuxiliar2.Text;
			_uiController.CampoAuxiliar3 = txtCampoAuxiliar3.Text;
			_uiController.CampoAuxiliar4 = txtCampoAuxiliar4.Text;
			_uiController.CampoAuxiliar5 = txtCampoAuxiliar5.Text;
			_uiController.IdBonificacion = (string) mzCEBonificacion.Value;
			_uiController.ObligaCodigoBarra = chkObligaCodigoBarra.Checked;
			_uiController.ByObligaCodigoBarra = chkHabilitarObligaCB.Checked;
			_uiController.ObligaNumeroSerie = chkObligaNumeroSerie.Checked;
			_uiController.ByObligaNumeroSerie = chkHabilitarObligaNS.Checked;
			_uiController.PercibeIB = chkPercibeIB.Checked;
			_uiController.ByPercibeIB = chkHabilitarPercibeIB.Checked;	
			_uiController.FechaDesde = (DateTime)FechaDesde.Value;
			_uiController.FechaHasta = (DateTime)FechaHasta.Value;

			_uiController.IdResponsable = Convert.ToString(mzCEResponsable.Value);
			_uiController.FechaAltaDesde = Convert.ToDateTime(udtFechaAltaDesde.Value);
			_uiController.FechaAltaHasta = Convert.ToDateTime(udtFechaAltaHasta.Value);

			//gridEx.DataSource =	_uiController.SearchNow();		
			_uiController.SearchNow();

			gridEx.SetDataBinding(null, null);
			gridEx.SetDataBinding(_uiController.DataTableResult, null);

			if (gridManagerView1.AllowExportExcel || gridManagerView1.AllowSortByAgregateColumn)
				gridManagerView1.SetTable(_uiController.DataTableResult);
			this.Cursor = Cursors.Default;
		}

		public void ResetParameters()
		{
			txtCodigo.Text = string.Empty;
			txtCodigoSecundario.Text = string.Empty;
			txtDescripcion.Text = string.Empty;
			txtDescripcionCorta.Text = string.Empty;
			txtDescripcionLarga.Text = string.Empty;
			chkActivo.Checked = false;
			chkActivo.Enabled = false;
			chkHabilitarActivo.Checked = false;
			mzComboTipoProducto.ResetText();
			txtObservaciones.Text = string.Empty;
			txtCampoAuxiliar1.Text = string.Empty;
			txtCampoAuxiliar2.Text = string.Empty;
			txtCampoAuxiliar3.Text = string.Empty;
			txtCampoAuxiliar4.Text = string.Empty;
			txtCampoAuxiliar5.Text = string.Empty;
			mzCEBonificacion.ResetText();
			chkObligaCodigoBarra.Checked = false;
			chkObligaCodigoBarra.Enabled = false;
			chkHabilitarObligaCB.Checked = false;
			chkObligaNumeroSerie.Checked = false;
			chkObligaNumeroSerie.Enabled = false;
			chkHabilitarObligaNS.Checked = false;
			chkPercibeIB.Checked = false;
			chkPercibeIB.Enabled = false;
			chkHabilitarPercibeIB.Checked = false;
			/*hierarchicalSearchControl1.NodeChecked1 = false;			
			hierarchicalSearchControl1.NodeChecked2 = false;			
			hierarchicalSearchControl1.NodeChecked3 = false;			
			hierarchicalSearchControl1.NodeChecked4 = false;			
			hierarchicalSearchControl1.NodeChecked5 = false;			
			hierarchicalSearchControl1.NodeChecked6 = false;			
			hierarchicalSearchControl1.NodeChecked7 = false;			
			hierarchicalSearchControl1.NodeChecked8 = false;*/	
			hierarchicalSearchControl1.ClearSelectedNodes();
			_uiController.ByJerarquia1 = false;
			_uiController.ByJerarquia2 = false;
			_uiController.ByJerarquia3 = false;
			_uiController.ByJerarquia4 = false;
			_uiController.ByJerarquia5 = false;
			_uiController.ByJerarquia6 = false;
			_uiController.ByJerarquia7 = false;
			_uiController.ByJerarquia8 = false;
			FechaDesde.Value = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
			FechaHasta.Value = mz.erp.businessrules.Sistema.DateTime.Now;
			gridEx.SetDataBinding(null, null);

			// ---- Matias - Tarea 279 - Custom 8 - 20090720
			uceEntreFechas.Checked = false;
			uceResponsable.Checked = false;
			_uiController.IdResponsable = string.Empty;
			mzCEResponsable.Value = string.Empty;
			udtFechaAltaDesde.Value = mz.erp.businessrules.Sistema.DateTime.Now.AddDays(-30);
			udtFechaAltaHasta.Value = mz.erp.businessrules.Sistema.DateTime.Now;
			// ---- Fin Matias            			

		}


		private void Nuevo()
		{
			this.Cursor = Cursors.WaitCursor;
			FrmAbmExProductos form = new FrmAbmExProductos();
			form.OnRowChanged += new mz.erp.ui.forms.FrmABMEx.RowChanged(EventoRefrescar);
			form.ShowForm(null, "Producto");
			this.Cursor = Cursors.Default;

		}

		private void EventoRefrescar( object sender, EventArgs args )
		{			
			
		}

		private void Editar()
		{
			if(this.gridEx.SelectedItems.Count > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				FrmAbmExProductos form = new FrmAbmExProductos();
				form.OnRowChanged += new mz.erp.ui.forms.FrmABMEx.RowChanged(EventoRefrescar);
				form.ShowForm(_uiController.IdProductoSeleccionado, "Producto");
				this.Cursor = Cursors.Default;
			}
		}

		private void Cancelar()
		{					
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;	
			this.Close();
		}


		private void chkHabilitarActivo_CheckedChanged(object sender, System.EventArgs e)
		{
			chkActivo.Enabled = chkHabilitarActivo.Checked;
		}

		private void chkHabilitarObligaCB_CheckedChanged(object sender, System.EventArgs e)
		{
			chkObligaCodigoBarra.Enabled = chkHabilitarObligaCB.Checked;		
		}

		private void chkHabilitarObligaNS_CheckedChanged(object sender, System.EventArgs e)
		{
			chkObligaNumeroSerie.Enabled = chkHabilitarObligaNS.Checked;		
		}

		private void chkHabilitarPercibeIB_CheckedChanged(object sender, System.EventArgs e)
		{
			chkPercibeIB.Enabled = chkHabilitarPercibeIB.Checked;
		}

		private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
		{
			
			_uiController.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
			_uiController.Jerarquia1 = hierarchicalSearchControl1.ItemsJerarquia1;
			_uiController.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
			_uiController.Jerarquia2 = hierarchicalSearchControl1.ItemsJerarquia2;
			_uiController.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
			_uiController.Jerarquia3 = hierarchicalSearchControl1.ItemsJerarquia3;
			_uiController.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
			_uiController.Jerarquia4 = hierarchicalSearchControl1.ItemsJerarquia4;
			_uiController.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
			_uiController.Jerarquia5 = hierarchicalSearchControl1.ItemsJerarquia5;
			_uiController.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
			_uiController.Jerarquia6 = hierarchicalSearchControl1.ItemsJerarquia6;
			_uiController.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
			_uiController.Jerarquia7 = hierarchicalSearchControl1.ItemsJerarquia7;
			_uiController.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
			_uiController.Jerarquia8 = hierarchicalSearchControl1.ItemsJerarquia8;
		}


	
		private void gridEx_SelectionChanged(object sender, System.EventArgs e)
		{
			Detail();
		}

		private void Detail()
		{
			if (gridEx.SelectedItems.Count > 0)
			{
				_uiController.VerDetalle( (System.Data.DataRowView)gridEx.SelectedItems[0].GetRow().DataRow );
				//pictureBoxThumb.Image = _uicontroller.Thumb;
			}
		}

		private void _uiController_DetalleChanged(object sender, EventArgs e)
		{
			txtResultDescripcion.Text = _uiController.ResultDescripcion;
			txtResultObservaciones.Text = _uiController.ResultObservaciones;
			txtResultCampoAuxiliar1.Text = _uiController.ResultCampoAuxiliar1;
			txtResultCampoAuxiliar2.Text = _uiController.ResultCampoAuxiliar2;
			txtResultCampoAuxiliar3.Text = _uiController.ResultCampoAuxiliar3;
			txtResultCampoAuxiliar4.Text = _uiController.ResultCampoAuxiliar4;
			txtResultCampoAuxiliar5.Text = _uiController.ResultCampoAuxiliar5;
			uneResultPrecioFinalMD.Value = _uiController.ResultPrecioFinalMDRecargoCV;
			uneResultPrecioNetoMD.Value = _uiController.ResultPrecioDeVentaBrutoMDRecargoCondicionDeVenta;
			uneResultPrecioFinalMO.Value = _uiController.ResultPrecioFinalMORecargoCV;
			uneResultPrecioNetoMO.Value = _uiController.ResultPrecioDeVentaBrutoMORecargoCondicionDeVenta;
			lbEtiquetaResultPrecioFinalMD.Text =_uiController.EtiquetaResultPrecioFinalMD;
			lbEtiquetaResultPrecioNetoMD.Text = _uiController.EtiquetaResultPrecioNetoMD;
			lbEtiquetaResultPrecioFinalMO.Text = _uiController.EtiquetaResultPrecioFinalMO;
            lbEtiquetaResultPrecioNetoMO.Text = _uiController.EtiquetaResultPrecioNetoMO;			
			gridCondicionesDeVenta.DataSource = _uiController.PreciosPorCondicionDeVenta;
			lbEtiquetaResultPrecioFinalMO2.Text = _uiController.EtiquetaResultPrecioFinalMO;
            lbEtiquetaResultPrecioFinalMD2.Text =_uiController.EtiquetaResultPrecioFinalMD;
			uneResultPrecioFinalMO2.Value = _uiController.ResultPrecioFinalMORecargoCV;
            uneResultPrecioFinalMD2.Value = _uiController.ResultPrecioFinalMDRecargoCV;
			pictureBoxThumb.Image = _uiController.Thumb;		
			gridFormasDePago.DataSource = _uiController.PreciosSegunFormaDePago;
			lbEtiquetaResultPrecioFinalMO1.Text = _uiController.EtiquetaResultPrecioFinalMO;
            lbEtiquetaResultPrecioFinalMD1.Text = _uiController.EtiquetaResultPrecioFinalMD;
			uneResultPrecioFinalMO1.Value = _uiController.ResultPrecioFinalMORecargoCV;
			uneResultPrecioFinalMD1.Value = _uiController.ResultPrecioFinalMDRecargoCV;
			gridStock.DataSource = _uiController.DataStock;
			Infragistics.Win.UltraWinGrid.UltraGridLayout layout = gridStock.DisplayLayout;
			layout.Bands[0].Columns[0].Hidden= true;
			layout.Bands[1].Columns[0].Hidden = true; 
			layout.Bands[1].Columns[1].Hidden = true; 
			layout.Bands[1].Columns[2].Hidden = true; 
			layout.Bands[1].Columns[3].Hidden = true; 
			layout.Bands[2].Columns[0].Hidden = true; 	
			txtResultDescripcion1.Text = _uiController.ResultDescripcion;
			lbEtitutaResultPrecionFinal1.Text = _uiController.EtiquetaResultPrecioFinalMO;
			uneResultPrecionFinal1.Value = _uiController.ResultPrecioFinalImpuestosIncluidos;
		}

		private void menuItemDesSeleccionar_Click(object sender, EventArgs e)
		{
			gridManagerView1.MarcarNinguno();
			gridEx.SetDataBinding(null, null);
			gridEx.SetDataBinding(_uiController.DataTableResult, null);
		}

		private void menuItemSeleccionarTodos_Click(object sender, EventArgs e)
		{
			gridManagerView1.MarcarTodos();
			gridEx.SetDataBinding(null, null);
			gridEx.SetDataBinding(_uiController.DataTableResult, null);
		}

		private void uceResponsable_CheckedChanged(object sender, EventArgs e)
		{
			if (this.uceResponsable.Checked)
			{
				_uiController.BuscarPorResponsable=true;
				mzCEResponsable.Enabled=true;
			}
			else
			{
				_uiController.BuscarPorResponsable=false;
				mzCEResponsable.Enabled=false;
			}
		}

		private void uceEntreFechas_CheckedChanged(object sender, EventArgs e)
		{
			if (this.uceEntreFechas.Checked)
			{
				_uiController.BuscarPorFechaAlta=true;
				udtFechaAltaDesde.Enabled=true;
				udtFechaAltaHasta.Enabled=true;
			}
			else
			{
				_uiController.BuscarPorFechaAlta=false;
				udtFechaAltaDesde.Enabled=false;
				udtFechaAltaHasta.Enabled=false;
			}

		}
   }
}

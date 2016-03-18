using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.utility;
using mz.erp.commontypes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmProveedores.
	/// </summary>
	public class FrmAbmProveedores : System.Windows.Forms.Form
	{
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
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label10;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacionGeneral;
		private System.Windows.Forms.Label label2;
		private mz.erp.ui.controls.mzComboEditor mzComboEstado;
		private System.Windows.Forms.Label label21;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasDemoraEntrega;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtTitular;
		private System.Windows.Forms.Label label7;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDeIVA;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTiposMovimiento;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposMovimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private System.Windows.Forms.RichTextBox txtObservaciones;
		private mz.erp.ui.controls.ComponenteDocumentos componenteDocumentos1;
		private System.Windows.Forms.TextBox txtWeb;
		private System.Windows.Forms.TextBox txtHorarioComercial;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtInstantMessenger;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtTelefonos;
		private Infragistics.Win.Misc.UltraLabel ultraLabel13;
		private Infragistics.Win.Misc.UltraLabel ultraLabel12;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private mz.erp.ui.controls.mzComboEditor mzComboCondicionCompra;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar1;
		private Infragistics.Win.Misc.UltraLabel labelCampoAux1;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private Infragistics.Win.Misc.UltraLabel labelCampoAux2;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private Infragistics.Win.Misc.UltraLabel labelCampoAux3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar4;
		private Infragistics.Win.Misc.UltraLabel labelCampoAux4;
		private Infragistics.Win.Misc.UltraLabel labelCampoAux5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCampoAuxiliar5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkExcluyeRetencionesIVA;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkExcluyeRetencionesIIBB;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboEditor mzCECondicionesRetecionesGanancias;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneAlicuotaRetencionIIBBCompras;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneAlicuotaRetencionIIBBServicios;
		private System.Windows.Forms.Label label6;
		private mz.erp.ui.controls.mzComboEditor mzCmbPaisEditar;
		private mz.erp.ui.controls.mzComboEditor mzCmbPciaEditar;
		private mz.erp.ui.controls.mzComboEditor mzCmbLocEditar;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableIngreso;
        private System.Windows.Forms.Label label15;
        private mz.erp.ui.controls.mzComboEditor mzCmbCodPos;
        private mz.erp.ui.controls.mzComboEditor mzCmbCPostalEditar;
        private TextBox mzTxtCPostal;
        private TextBox textBox1;
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbmProveedores));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzTxtCPostal = new System.Windows.Forms.TextBox();
            this.mzCEResponsableIngreso = new mz.erp.ui.controls.mzComboEditor();
            this.label15 = new System.Windows.Forms.Label();
            this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.label8 = new System.Windows.Forms.Label();
            this.mzCmbLocEditar = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbPciaEditar = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbPaisEditar = new mz.erp.ui.controls.mzComboEditor();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mzComboCondicionCompra = new mz.erp.ui.controls.mzComboEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.mzCmbSrchEdtTitular = new mz.erp.ui.controls.mzComboSearchEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.mzCmbTiposDeIVA = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbSubTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.componenteDocumentos1 = new mz.erp.ui.controls.ComponenteDocumentos();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtHorarioComercial = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtInstantMessenger = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uneAlicuotaRetencionIIBBServicios = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label6 = new System.Windows.Forms.Label();
            this.uneAlicuotaRetencionIIBBCompras = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mzCECondicionesRetecionesGanancias = new mz.erp.ui.controls.mzComboEditor();
            this.chkExcluyeRetencionesIIBB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.label10 = new System.Windows.Forms.Label();
            this.uneBonificacionGeneral = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.mzComboEstado = new mz.erp.ui.controls.mzComboEditor();
            this.label21 = new System.Windows.Forms.Label();
            this.uneDiasDemoraEntrega = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.chkExcluyeRetencionesIVA = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.uneCampoAuxiliar5 = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.labelCampoAux5 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCampoAuxiliar4 = new System.Windows.Forms.TextBox();
            this.labelCampoAux4 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
            this.labelCampoAux3 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
            this.labelCampoAux2 = new Infragistics.Win.Misc.UltraLabel();
            this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
            this.labelCampoAux1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mzCmbCodPos = new mz.erp.ui.controls.mzComboEditor();
            this.mzCmbCPostalEditar = new mz.erp.ui.controls.mzComboEditor();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbLocEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPciaEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPaisEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboCondicionCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneAlicuotaRetencionIIBBServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneAlicuotaRetencionIIBBCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesRetecionesGanancias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacionGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasDemoraEntrega)).BeginInit();
            this.ultraExplorerBarContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCampoAuxiliar5)).BeginInit();
            this.ultraExplorerBarContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbCodPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbCPostalEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzTxtCPostal);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableIngreso);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label15);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkActivo);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label8);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbLocEditar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbPciaEditar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbPaisEditar);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCodigo);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboCondicionCompra);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSrchEdtTitular);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposDeIVA);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSubTiposMovimiento);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposMovimiento);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel10);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtObservaciones);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.componenteDocumentos1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtWeb);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtHorarioComercial);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDomicilio);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtEmail);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtInstantMessenger);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNombre);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTelefonos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel13);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel12);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel8);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 47);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(814, 407);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // mzTxtCPostal
            // 
            this.mzTxtCPostal.BackColor = System.Drawing.Color.White;
            this.mzTxtCPostal.Location = new System.Drawing.Point(523, 145);
            this.mzTxtCPostal.Name = "mzTxtCPostal";
            this.mzTxtCPostal.ReadOnly = true;
            this.mzTxtCPostal.Size = new System.Drawing.Size(93, 20);
            this.mzTxtCPostal.TabIndex = 116;
            // 
            // mzCEResponsableIngreso
            // 
            this.mzCEResponsableIngreso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsableIngreso.DisplayMember = "";
            this.mzCEResponsableIngreso.DisplayMemberCaption = "";
            this.mzCEResponsableIngreso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableIngreso.Location = new System.Drawing.Point(432, 0);
            this.mzCEResponsableIngreso.MaxItemsDisplay = 8;
            this.mzCEResponsableIngreso.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableIngreso.Name = "mzCEResponsableIngreso";
            this.mzCEResponsableIngreso.Size = new System.Drawing.Size(184, 21);
            this.mzCEResponsableIngreso.SorterMember = "";
            this.mzCEResponsableIngreso.TabIndex = 20;
            this.mzCEResponsableIngreso.ValueMember = "";
            this.mzCEResponsableIngreso.ValueMemberCaption = "";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(325, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 14);
            this.label15.TabIndex = 115;
            this.label15.Text = "Responsable de alta";
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivo.Location = new System.Drawing.Point(376, 384);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(120, 20);
            this.chkActivo.TabIndex = 18;
            this.chkActivo.Text = "Activo";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(8, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 112;
            this.label8.Text = "Localidad:";
            // 
            // mzCmbLocEditar
            // 
            this.mzCmbLocEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbLocEditar.DisplayMember = "";
            this.mzCmbLocEditar.DisplayMemberCaption = "";
            this.mzCmbLocEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbLocEditar.Location = new System.Drawing.Point(393, 144);
            this.mzCmbLocEditar.MaxItemsDisplay = 7;
            this.mzCmbLocEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbLocEditar.Name = "mzCmbLocEditar";
            this.mzCmbLocEditar.Size = new System.Drawing.Size(124, 21);
            this.mzCmbLocEditar.SorterMember = "";
            this.mzCmbLocEditar.TabIndex = 8;
            this.mzCmbLocEditar.ValueMember = "";
            this.mzCmbLocEditar.ValueMemberCaption = "";
            // 
            // mzCmbPciaEditar
            // 
            this.mzCmbPciaEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbPciaEditar.DisplayMember = "";
            this.mzCmbPciaEditar.DisplayMemberCaption = "";
            this.mzCmbPciaEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbPciaEditar.Location = new System.Drawing.Point(270, 144);
            this.mzCmbPciaEditar.MaxItemsDisplay = 7;
            this.mzCmbPciaEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbPciaEditar.Name = "mzCmbPciaEditar";
            this.mzCmbPciaEditar.Size = new System.Drawing.Size(117, 21);
            this.mzCmbPciaEditar.SorterMember = "";
            this.mzCmbPciaEditar.TabIndex = 7;
            this.mzCmbPciaEditar.ValueMember = "";
            this.mzCmbPciaEditar.ValueMemberCaption = "";
            // 
            // mzCmbPaisEditar
            // 
            this.mzCmbPaisEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbPaisEditar.DisplayMember = "";
            this.mzCmbPaisEditar.DisplayMemberCaption = "";
            this.mzCmbPaisEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbPaisEditar.Location = new System.Drawing.Point(120, 144);
            this.mzCmbPaisEditar.MaxItemsDisplay = 7;
            this.mzCmbPaisEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbPaisEditar.Name = "mzCmbPaisEditar";
            this.mzCmbPaisEditar.Size = new System.Drawing.Size(144, 21);
            this.mzCmbPaisEditar.SorterMember = "";
            this.mzCmbPaisEditar.TabIndex = 6;
            this.mzCmbPaisEditar.ValueMember = "";
            this.mzCmbPaisEditar.ValueMemberCaption = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(120, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "textBox1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 107;
            this.label4.Text = "Código";
            // 
            // mzComboCondicionCompra
            // 
            this.mzComboCondicionCompra.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboCondicionCompra.DisplayMember = "";
            this.mzComboCondicionCompra.DisplayMemberCaption = "";
            this.mzComboCondicionCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboCondicionCompra.Location = new System.Drawing.Point(120, 384);
            this.mzComboCondicionCompra.MaxItemsDisplay = 7;
            this.mzComboCondicionCompra.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboCondicionCompra.Name = "mzComboCondicionCompra";
            this.mzComboCondicionCompra.Size = new System.Drawing.Size(144, 21);
            this.mzComboCondicionCompra.SorterMember = "";
            this.mzComboCondicionCompra.TabIndex = 17;
            this.mzComboCondicionCompra.ValueMember = "";
            this.mzComboCondicionCompra.ValueMemberCaption = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "Condición de compra";
            // 
            // mzCmbSrchEdtTitular
            // 
            this.mzCmbSrchEdtTitular.DataValue = "";
            this.mzCmbSrchEdtTitular.EditObject = null;
            this.mzCmbSrchEdtTitular.FastSearch = false;
            this.mzCmbSrchEdtTitular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbSrchEdtTitular.HierarchicalSearch = false;
            this.mzCmbSrchEdtTitular.Location = new System.Drawing.Point(120, 48);
            this.mzCmbSrchEdtTitular.Name = "mzCmbSrchEdtTitular";
            this.mzCmbSrchEdtTitular.ReadOnly = false;
            this.mzCmbSrchEdtTitular.SearchObject = null;
            this.mzCmbSrchEdtTitular.SearchObjectListener = null;
            this.mzCmbSrchEdtTitular.Size = new System.Drawing.Size(496, 22);
            this.mzCmbSrchEdtTitular.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 102;
            this.label7.Text = "Condición de IVA";
            // 
            // mzCmbTiposDeIVA
            // 
            this.mzCmbTiposDeIVA.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTiposDeIVA.DisplayMember = "";
            this.mzCmbTiposDeIVA.DisplayMemberCaption = "";
            this.mzCmbTiposDeIVA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTiposDeIVA.Location = new System.Drawing.Point(120, 72);
            this.mzCmbTiposDeIVA.MaxItemsDisplay = 7;
            this.mzCmbTiposDeIVA.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTiposDeIVA.Name = "mzCmbTiposDeIVA";
            this.mzCmbTiposDeIVA.Size = new System.Drawing.Size(216, 21);
            this.mzCmbTiposDeIVA.SorterMember = "";
            this.mzCmbTiposDeIVA.TabIndex = 3;
            this.mzCmbTiposDeIVA.ValueMember = "";
            this.mzCmbTiposDeIVA.ValueMemberCaption = "";
            // 
            // mzCmbSubTiposMovimiento
            // 
            this.mzCmbSubTiposMovimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbSubTiposMovimiento.DisplayMember = "";
            this.mzCmbSubTiposMovimiento.DisplayMemberCaption = "";
            this.mzCmbSubTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbSubTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.mzCmbSubTiposMovimiento.Location = new System.Drawing.Point(376, 360);
            this.mzCmbSubTiposMovimiento.MaxItemsDisplay = 7;
            this.mzCmbSubTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbSubTiposMovimiento.Name = "mzCmbSubTiposMovimiento";
            this.mzCmbSubTiposMovimiento.Size = new System.Drawing.Size(240, 21);
            this.mzCmbSubTiposMovimiento.SorterMember = "";
            this.mzCmbSubTiposMovimiento.TabIndex = 16;
            this.mzCmbSubTiposMovimiento.ValueMember = "";
            this.mzCmbSubTiposMovimiento.ValueMemberCaption = "";
            // 
            // mzCmbTiposMovimiento
            // 
            this.mzCmbTiposMovimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTiposMovimiento.DisplayMember = "";
            this.mzCmbTiposMovimiento.DisplayMemberCaption = "";
            this.mzCmbTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.mzCmbTiposMovimiento.Location = new System.Drawing.Point(120, 360);
            this.mzCmbTiposMovimiento.MaxItemsDisplay = 7;
            this.mzCmbTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTiposMovimiento.Name = "mzCmbTiposMovimiento";
            this.mzCmbTiposMovimiento.Size = new System.Drawing.Size(240, 21);
            this.mzCmbTiposMovimiento.SorterMember = "";
            this.mzCmbTiposMovimiento.TabIndex = 15;
            this.mzCmbTiposMovimiento.ValueMember = "";
            this.mzCmbTiposMovimiento.ValueMemberCaption = "";
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel10.Location = new System.Drawing.Point(8, 368);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(120, 16);
            this.ultraLabel10.TabIndex = 98;
            this.ultraLabel10.Text = "Tipo de Movimiento";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(120, 192);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(496, 72);
            this.txtObservaciones.TabIndex = 10;
            this.txtObservaciones.Text = "";
            // 
            // componenteDocumentos1
            // 
            this.componenteDocumentos1.BackColor = System.Drawing.Color.Transparent;
            this.componenteDocumentos1.Location = new System.Drawing.Point(8, 96);
            this.componenteDocumentos1.Name = "componenteDocumentos1";
            this.componenteDocumentos1.Numero = "";
            this.componenteDocumentos1.Size = new System.Drawing.Size(616, 24);
            this.componenteDocumentos1.TabIndex = 4;
            this.componenteDocumentos1.TipoDocSelected = "";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(120, 336);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(496, 20);
            this.txtWeb.TabIndex = 14;
            this.txtWeb.Text = "txtWeb";
            // 
            // txtHorarioComercial
            // 
            this.txtHorarioComercial.Location = new System.Drawing.Point(120, 168);
            this.txtHorarioComercial.Name = "txtHorarioComercial";
            this.txtHorarioComercial.Size = new System.Drawing.Size(496, 20);
            this.txtHorarioComercial.TabIndex = 9;
            this.txtHorarioComercial.Text = "txtHorarioComercial";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(120, 120);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(496, 20);
            this.txtDomicilio.TabIndex = 5;
            this.txtDomicilio.Text = "txtDomicilio";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 288);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(496, 20);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.Text = "txtEmail";
            // 
            // txtInstantMessenger
            // 
            this.txtInstantMessenger.Location = new System.Drawing.Point(120, 312);
            this.txtInstantMessenger.Name = "txtInstantMessenger";
            this.txtInstantMessenger.Size = new System.Drawing.Size(496, 20);
            this.txtInstantMessenger.TabIndex = 13;
            this.txtInstantMessenger.Text = "txtInstantMessenger";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(496, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "txtNombre";
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(120, 264);
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(496, 20);
            this.txtTelefonos.TabIndex = 11;
            this.txtTelefonos.Text = "txtTelefonos";
            // 
            // ultraLabel13
            // 
            this.ultraLabel13.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel13.Location = new System.Drawing.Point(8, 344);
            this.ultraLabel13.Name = "ultraLabel13";
            this.ultraLabel13.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel13.TabIndex = 95;
            this.ultraLabel13.Text = "Web";
            // 
            // ultraLabel12
            // 
            this.ultraLabel12.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel12.Location = new System.Drawing.Point(8, 168);
            this.ultraLabel12.Name = "ultraLabel12";
            this.ultraLabel12.Size = new System.Drawing.Size(96, 16);
            this.ultraLabel12.TabIndex = 94;
            this.ultraLabel12.Text = "Horario comercial";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel8.Location = new System.Drawing.Point(8, 52);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel8.TabIndex = 93;
            this.ultraLabel8.Text = "Titular";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel6.Location = new System.Drawing.Point(8, 320);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel6.TabIndex = 92;
            this.ultraLabel6.Text = "Instant Messenger";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel5.Location = new System.Drawing.Point(8, 28);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel5.TabIndex = 91;
            this.ultraLabel5.Text = "Nombre";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel4.Location = new System.Drawing.Point(8, 216);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel4.TabIndex = 90;
            this.ultraLabel4.Text = "Observaciones";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel3.Location = new System.Drawing.Point(8, 296);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel3.TabIndex = 89;
            this.ultraLabel3.Text = "Email";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(8, 272);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel2.TabIndex = 88;
            this.ultraLabel2.Text = "Teléfonos";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(8, 120);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(100, 16);
            this.ultraLabel1.TabIndex = 87;
            this.ultraLabel1.Text = "Domicilio";
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneAlicuotaRetencionIIBBServicios);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneAlicuotaRetencionIIBBCompras);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label5);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label3);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCECondicionesRetecionesGanancias);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.chkExcluyeRetencionesIIBB);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label10);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneBonificacionGeneral);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.mzComboEstado);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.label21);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.uneDiasDemoraEntrega);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.chkExcluyeRetencionesIVA);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(815, 75);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            this.ultraExplorerBarContainerControl2.Visible = false;
            // 
            // uneAlicuotaRetencionIIBBServicios
            // 
            this.uneAlicuotaRetencionIIBBServicios.Location = new System.Drawing.Point(744, 21);
            this.uneAlicuotaRetencionIIBBServicios.MaskInput = "nnn.nn";
            this.uneAlicuotaRetencionIIBBServicios.Name = "uneAlicuotaRetencionIIBBServicios";
            this.uneAlicuotaRetencionIIBBServicios.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneAlicuotaRetencionIIBBServicios.Size = new System.Drawing.Size(56, 21);
            this.uneAlicuotaRetencionIIBBServicios.TabIndex = 7;
            this.uneAlicuotaRetencionIIBBServicios.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(672, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 96;
            this.label6.Text = "Alic. IIBB Serv.";
            // 
            // uneAlicuotaRetencionIIBBCompras
            // 
            this.uneAlicuotaRetencionIIBBCompras.Location = new System.Drawing.Point(616, 21);
            this.uneAlicuotaRetencionIIBBCompras.MaskInput = "nnn.nn";
            this.uneAlicuotaRetencionIIBBCompras.MaxValue = 1000;
            this.uneAlicuotaRetencionIIBBCompras.MinValue = 0;
            this.uneAlicuotaRetencionIIBBCompras.Name = "uneAlicuotaRetencionIIBBCompras";
            this.uneAlicuotaRetencionIIBBCompras.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneAlicuotaRetencionIIBBCompras.Size = new System.Drawing.Size(56, 21);
            this.uneAlicuotaRetencionIIBBCompras.TabIndex = 6;
            this.uneAlicuotaRetencionIIBBCompras.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(536, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Alic. IIBB Comp.";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(376, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 93;
            this.label3.Text = "Cond. Retenciones Ganancias";
            // 
            // mzCECondicionesRetecionesGanancias
            // 
            this.mzCECondicionesRetecionesGanancias.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCECondicionesRetecionesGanancias.DisplayMember = "";
            this.mzCECondicionesRetecionesGanancias.DisplayMemberCaption = "";
            this.mzCECondicionesRetecionesGanancias.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCECondicionesRetecionesGanancias.Location = new System.Drawing.Point(536, 56);
            this.mzCECondicionesRetecionesGanancias.MaxItemsDisplay = 7;
            this.mzCECondicionesRetecionesGanancias.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCECondicionesRetecionesGanancias.Name = "mzCECondicionesRetecionesGanancias";
            this.mzCECondicionesRetecionesGanancias.Size = new System.Drawing.Size(144, 21);
            this.mzCECondicionesRetecionesGanancias.SorterMember = "";
            this.mzCECondicionesRetecionesGanancias.TabIndex = 8;
            this.mzCECondicionesRetecionesGanancias.ValueMember = "";
            this.mzCECondicionesRetecionesGanancias.ValueMemberCaption = "";
            // 
            // chkExcluyeRetencionesIIBB
            // 
            this.chkExcluyeRetencionesIIBB.BackColor = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIIBB.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIIBB.Location = new System.Drawing.Point(376, 29);
            this.chkExcluyeRetencionesIIBB.Name = "chkExcluyeRetencionesIIBB";
            this.chkExcluyeRetencionesIIBB.Size = new System.Drawing.Size(160, 20);
            this.chkExcluyeRetencionesIIBB.TabIndex = 5;
            this.chkExcluyeRetencionesIIBB.Text = "Excluye retenciones IIBB";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 84;
            this.label10.Text = "Bonificación general";
            // 
            // uneBonificacionGeneral
            // 
            this.uneBonificacionGeneral.Location = new System.Drawing.Point(120, 0);
            this.uneBonificacionGeneral.MaskInput = "nnnnnnnn.nnnn";
            this.uneBonificacionGeneral.Name = "uneBonificacionGeneral";
            this.uneBonificacionGeneral.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneBonificacionGeneral.Size = new System.Drawing.Size(100, 21);
            this.uneBonificacionGeneral.TabIndex = 0;
            this.uneBonificacionGeneral.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 90;
            this.label2.Text = "Estado";
            // 
            // mzComboEstado
            // 
            this.mzComboEstado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboEstado.DisplayMember = "";
            this.mzComboEstado.DisplayMemberCaption = "";
            this.mzComboEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboEstado.Location = new System.Drawing.Point(120, 24);
            this.mzComboEstado.MaxItemsDisplay = 7;
            this.mzComboEstado.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboEstado.Name = "mzComboEstado";
            this.mzComboEstado.Size = new System.Drawing.Size(144, 21);
            this.mzComboEstado.SorterMember = "";
            this.mzComboEstado.TabIndex = 1;
            this.mzComboEstado.ValueMember = "";
            this.mzComboEstado.ValueMemberCaption = "";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(8, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 32);
            this.label21.TabIndex = 88;
            this.label21.Text = "Días de demora en la entrega";
            // 
            // uneDiasDemoraEntrega
            // 
            this.uneDiasDemoraEntrega.Location = new System.Drawing.Point(120, 48);
            this.uneDiasDemoraEntrega.MaxValue = 99999;
            this.uneDiasDemoraEntrega.MinValue = 0;
            this.uneDiasDemoraEntrega.Name = "uneDiasDemoraEntrega";
            this.uneDiasDemoraEntrega.Size = new System.Drawing.Size(72, 21);
            this.uneDiasDemoraEntrega.TabIndex = 2;
            this.uneDiasDemoraEntrega.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // chkExcluyeRetencionesIVA
            // 
            this.chkExcluyeRetencionesIVA.BackColor = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIVA.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkExcluyeRetencionesIVA.Location = new System.Drawing.Point(376, 0);
            this.chkExcluyeRetencionesIVA.Name = "chkExcluyeRetencionesIVA";
            this.chkExcluyeRetencionesIVA.Size = new System.Drawing.Size(160, 20);
            this.chkExcluyeRetencionesIVA.TabIndex = 4;
            this.chkExcluyeRetencionesIVA.Text = "Excluye retenciones IVA";
            // 
            // ultraExplorerBarContainerControl3
            // 
            this.ultraExplorerBarContainerControl3.Controls.Add(this.uneCampoAuxiliar5);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelCampoAux5);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar4);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelCampoAux4);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelCampoAux3);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelCampoAux2);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.txtCampoAuxiliar1);
            this.ultraExplorerBarContainerControl3.Controls.Add(this.labelCampoAux1);
            this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
            this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(815, 128);
            this.ultraExplorerBarContainerControl3.TabIndex = 2;
            this.ultraExplorerBarContainerControl3.Visible = false;
            // 
            // uneCampoAuxiliar5
            // 
            this.uneCampoAuxiliar5.Location = new System.Drawing.Point(120, 104);
            this.uneCampoAuxiliar5.MaskInput = "nnnnnnnn.nnnn";
            this.uneCampoAuxiliar5.Name = "uneCampoAuxiliar5";
            this.uneCampoAuxiliar5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCampoAuxiliar5.Size = new System.Drawing.Size(100, 21);
            this.uneCampoAuxiliar5.TabIndex = 4;
            this.uneCampoAuxiliar5.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // labelCampoAux5
            // 
            this.labelCampoAux5.BackColorInternal = System.Drawing.Color.Transparent;
            this.labelCampoAux5.Location = new System.Drawing.Point(8, 104);
            this.labelCampoAux5.Name = "labelCampoAux5";
            this.labelCampoAux5.Size = new System.Drawing.Size(100, 16);
            this.labelCampoAux5.TabIndex = 101;
            this.labelCampoAux5.Text = "Campo Auxiliar5";
            // 
            // txtCampoAuxiliar4
            // 
            this.txtCampoAuxiliar4.Location = new System.Drawing.Point(120, 80);
            this.txtCampoAuxiliar4.Name = "txtCampoAuxiliar4";
            this.txtCampoAuxiliar4.Size = new System.Drawing.Size(496, 20);
            this.txtCampoAuxiliar4.TabIndex = 3;
            this.txtCampoAuxiliar4.Text = "txtCampoAuxiliar4";
            // 
            // labelCampoAux4
            // 
            this.labelCampoAux4.BackColorInternal = System.Drawing.Color.Transparent;
            this.labelCampoAux4.Location = new System.Drawing.Point(8, 80);
            this.labelCampoAux4.Name = "labelCampoAux4";
            this.labelCampoAux4.Size = new System.Drawing.Size(100, 16);
            this.labelCampoAux4.TabIndex = 99;
            this.labelCampoAux4.Text = "Campo Auxiliar4";
            // 
            // txtCampoAuxiliar3
            // 
            this.txtCampoAuxiliar3.Location = new System.Drawing.Point(120, 56);
            this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
            this.txtCampoAuxiliar3.Size = new System.Drawing.Size(496, 20);
            this.txtCampoAuxiliar3.TabIndex = 2;
            this.txtCampoAuxiliar3.Text = "txtCampoAuxiliar3";
            // 
            // labelCampoAux3
            // 
            this.labelCampoAux3.BackColorInternal = System.Drawing.Color.Transparent;
            this.labelCampoAux3.Location = new System.Drawing.Point(8, 56);
            this.labelCampoAux3.Name = "labelCampoAux3";
            this.labelCampoAux3.Size = new System.Drawing.Size(100, 16);
            this.labelCampoAux3.TabIndex = 97;
            this.labelCampoAux3.Text = "Campo Auxiliar3";
            // 
            // txtCampoAuxiliar2
            // 
            this.txtCampoAuxiliar2.Location = new System.Drawing.Point(120, 32);
            this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
            this.txtCampoAuxiliar2.Size = new System.Drawing.Size(496, 20);
            this.txtCampoAuxiliar2.TabIndex = 1;
            this.txtCampoAuxiliar2.Text = "txtCampoAuxiliar2";
            // 
            // labelCampoAux2
            // 
            this.labelCampoAux2.BackColorInternal = System.Drawing.Color.Transparent;
            this.labelCampoAux2.Location = new System.Drawing.Point(8, 32);
            this.labelCampoAux2.Name = "labelCampoAux2";
            this.labelCampoAux2.Size = new System.Drawing.Size(100, 16);
            this.labelCampoAux2.TabIndex = 95;
            this.labelCampoAux2.Text = "Campo Auxiliar2";
            // 
            // txtCampoAuxiliar1
            // 
            this.txtCampoAuxiliar1.Location = new System.Drawing.Point(120, 8);
            this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
            this.txtCampoAuxiliar1.Size = new System.Drawing.Size(496, 20);
            this.txtCampoAuxiliar1.TabIndex = 0;
            this.txtCampoAuxiliar1.Text = "txtCampoAuxiliar1";
            this.txtCampoAuxiliar1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelCampoAux1
            // 
            this.labelCampoAux1.BackColorInternal = System.Drawing.Color.Transparent;
            this.labelCampoAux1.Location = new System.Drawing.Point(8, 8);
            this.labelCampoAux1.Name = "labelCampoAux1";
            this.labelCampoAux1.Size = new System.Drawing.Size(100, 16);
            this.labelCampoAux1.TabIndex = 93;
            this.labelCampoAux1.Text = "Campo Auxiliar1";
            this.labelCampoAux1.Click += new System.EventHandler(this.ultraLabel7_Click);
            // 
            // ultraExplorerBarContainerControl4
            // 
            this.ultraExplorerBarContainerControl4.Controls.Add(this.hierarchicalSearchControl1);
            this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
            this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(815, 48);
            this.ultraExplorerBarContainerControl4.TabIndex = 3;
            this.ultraExplorerBarContainerControl4.Visible = false;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(0, 4);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(840, 40);
            this.hierarchicalSearchControl1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
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
            this.toolBarStandar.Size = new System.Drawing.Size(880, 28);
            this.toolBarStandar.TabIndex = 17;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbFirst
            // 
            this.tbFirst.ImageIndex = 0;
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Visible = false;
            // 
            // tbPrev
            // 
            this.tbPrev.ImageIndex = 1;
            this.tbPrev.Name = "tbPrev";
            this.tbPrev.Visible = false;
            // 
            // tbNext
            // 
            this.tbNext.ImageIndex = 2;
            this.tbNext.Name = "tbNext";
            this.tbNext.Visible = false;
            // 
            // tbLast
            // 
            this.tbLast.ImageIndex = 3;
            this.tbLast.Name = "tbLast";
            this.tbLast.Visible = false;
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.toolBarButton5.Visible = false;
            // 
            // tbActualizar
            // 
            this.tbActualizar.ImageIndex = 5;
            this.tbActualizar.Name = "tbActualizar";
            this.tbActualizar.Visible = false;
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.toolBarButton7.Visible = false;
            // 
            // tbGuardar
            // 
            this.tbGuardar.ImageIndex = 4;
            this.tbGuardar.Name = "tbGuardar";
            this.tbGuardar.Text = "&Guardar";
            // 
            // tbStep3
            // 
            this.tbStep3.Name = "tbStep3";
            this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.tbStep3.Visible = false;
            // 
            // tbDelete
            // 
            this.tbDelete.ImageIndex = 7;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Text = "Borrar";
            this.tbDelete.Visible = false;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup1.Key = "DatosGenerales";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 407;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Datos Generales";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Key = "Avanzadas";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 75;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Otros datos de interés";
            ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
            ultraExplorerBarGroup3.Key = "DatosAuxiliares";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 128;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Datos Auxiliares";
            ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl4;
            ultraExplorerBarGroup4.Key = "Jerarquias";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 48;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Jerarquias";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(880, 454);
            this.ultraExplorerBar1.TabIndex = 18;
            this.ultraExplorerBar1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 116;
            // 
            // mzCmbCodPos
            // 
            this.mzCmbCodPos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbCodPos.DisplayMember = "";
            this.mzCmbCodPos.DisplayMemberCaption = "";
            this.mzCmbCodPos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbCodPos.Location = new System.Drawing.Point(523, 144);
            this.mzCmbCodPos.MaxItemsDisplay = 7;
            this.mzCmbCodPos.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbCodPos.Name = "mzCmbCodPos";
            this.mzCmbCodPos.Size = new System.Drawing.Size(93, 21);
            this.mzCmbCodPos.SorterMember = "";
            this.mzCmbCodPos.TabIndex = 116;
            this.mzCmbCodPos.ValueMember = "";
            this.mzCmbCodPos.ValueMemberCaption = "";
            // 
            // mzCmbCPostalEditar
            // 
            this.mzCmbCPostalEditar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbCPostalEditar.DisplayMember = "";
            this.mzCmbCPostalEditar.DisplayMemberCaption = "";
            this.mzCmbCPostalEditar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbCPostalEditar.Location = new System.Drawing.Point(523, 144);
            this.mzCmbCPostalEditar.MaxItemsDisplay = 7;
            this.mzCmbCPostalEditar.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbCPostalEditar.Name = "mzCmbCPostalEditar";
            this.mzCmbCPostalEditar.Size = new System.Drawing.Size(93, 21);
            this.mzCmbCPostalEditar.SorterMember = "";
            this.mzCmbCPostalEditar.TabIndex = 116;
            this.mzCmbCPostalEditar.ValueMember = "";
            this.mzCmbCPostalEditar.ValueMemberCaption = "";
            // 
            // FrmAbmProveedores
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(880, 482);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmAbmProveedores";
            this.Text = "FrmAbmProveedores";
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbLocEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPciaEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbPaisEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboCondicionCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneAlicuotaRetencionIIBBServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneAlicuotaRetencionIIBBCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCECondicionesRetecionesGanancias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneBonificacionGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasDemoraEntrega)).EndInit();
            this.ultraExplorerBarContainerControl3.ResumeLayout(false);
            this.ultraExplorerBarContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uneCampoAuxiliar5)).EndInit();
            this.ultraExplorerBarContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbCodPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbCPostalEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		
		#region Constructores y Destructores
		public FrmAbmProveedores()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.AbmProveedoresController();
			Build_UI();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}
		public FrmAbmProveedores(string IdProveedor)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.AbmProveedoresController(IdProveedor);
			//_uiController.IdProveedor = IdProveedor;
			Build_UI();

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
				this.mzCEResponsableIngreso.Leave -= new EventHandler(mzCEResponsableIngreso_Change);
			}
			base.Dispose( disposing );
		}
		#endregion

		#region CustomMembers
 
		/*protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tpu_Proveedores().GetType();
			base.Init();
		}   */

		/*protected override void InitializeMembers()
		{
			txtNombre.MaxLength = 50;
			//txtIdTitular.MaxLength = 20;
			//txtIdCategoriaIva.MaxLength = 10;
			//txtidTipoDocumento.MaxLength = 5;
			
		
			txtDomicilio.MaxLength = 100;
			txtHorarioComercial.MaxLength = 50;
			txtObservaciones.MaxLength = 1000;
			txtTelefonos.MaxLength = 100;
			txtEmail.MaxLength = 100;			
			txtInstantMessenger.MaxLength = 100;
			txtWeb.MaxLength = 100;
			
			//Setea el tipo/s de documentos a chequear por la componente
			ArrayList array = new ArrayList();
			array.Add("CUIT");
			array.Add("CUIL");
			componenteDocumentos1.TipoDoc = array;

			//Agrega los tipos de Doc. al ComboBox del  componete
			componenteDocumentos1.FillFromDataSource( businessrules.tsy_TiposDocumentos.GetList().tsy_TiposDocumentos, "idTipoDocumento", "Descripcion", 8, "1", "2", "Descripcion");
			
			
			mzCmbSrchEdtTitular.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			mzCmbSrchEdtCategoriaIva.SearchObject = typeof( mz.erp.ui.forms.classes.tsy_CategoriasIva );
		}*/
 
		/*protected override void FillControls()
		{
			if (_row != null)
			{
				//uneIdProveedor.Value = ( long )_row["IdProveedor"];
				txtNombre.Text = ( string )_row["Nombre"];
				mzCmbSrchEdtTitular.DataValue = ( string )_row["IdTitular"];
				mzCmbSrchEdtCategoriaIva.DataValue = ( string )_row["IdCategoriaIva"];
				componenteDocumentos1.TipoDocSelected = (string)_row["idTipoDocumento"];				
				componenteDocumentos1.Numero = ( string )_row["Numero"];
				txtDomicilio.Text = ( string )_row["Domicilio"];
				txtHorarioComercial.Text = ( string )_row["HorarioComercial"];
				txtObservaciones.Text = ( string )_row["Observaciones"];
				txtTelefonos.Text = ( string )_row["Telefonos"];
				txtEmail.Text = ( string )_row["Email"];
				txtInstantMessenger.Text = ( string )_row["InstantMessenger"];
				txtWeb.Text = ( string )_row["Web"];	
			}
		}*/


		/*protected override void DumpControls()
		{
			//_row["IdProveedor"] = uneIdProveedor.Value;
			_row["Nombre"] = txtNombre.Text;			
			_row["IdTitular"] = mzCmbSrchEdtTitular.DataValue;
			_row["IdCategoriaIva"] = mzCmbSrchEdtCategoriaIva.DataValue;
			_row["IdTipoDocumento"] = componenteDocumentos1.TipoDocSelected;
			_row["Numero"] = componenteDocumentos1.Numero;
			_row["Domicilio"] = txtDomicilio.Text;
			_row["HorarioComercial"] = txtHorarioComercial.Text;
			_row["Observaciones"] = txtObservaciones.Text;
			_row["Telefonos"] = txtTelefonos.Text;
			_row["Email"] = txtEmail.Text;
			_row["InstantMessenger"] = txtInstantMessenger.Text;
			_row["Web"] = txtWeb.Text;
		}*/


		#endregion  		

		#region Eventos
		public delegate void RowChanged( object sender, EventArgs args );
		public event RowChanged OnRowChanged;
		#endregion

		#region Variables Privadas
		private controllers.AbmProveedoresController _uiController = null;		
		#endregion

		#region Propiedades
		
		#endregion	
	
		#region Inicializadores y Carga

		protected void Build_UI()
		{	//Configura los controllers, visibilidad, etc, etc
			ConfigureInterface();	
			//Ejemplo le carga datos a un combo
			InitializeData();
			//Asociar eventos a la interface
			InitEventHandlers();
			//Realizar binding entre la interface y el controlador
			InitDataBindings();		
			//Para propiedades estaticas, datos q no dependen ni modifican a nadie.
			FillControls();
		}

		
		private void ConfigureInterface()
		{
			/*tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	
			txtClaveAnt.Select();
			txtClaveAnt.Enabled = _uiController.EnabledSetPreviuosPassword;
			mzCmbUsuarios.FillFromDataSource( _uiController.Usuarios, _uiController.KeyValueUsuarios,_uiController.KeyListUsuarios,100, _uiController.KeyListUsuarios );
			mzCmbUsuarios.Enabled = !_uiController.EnabledSetPreviuosPassword;*/			
			this.hierarchicalSearchControl1.Build_UI("PROVEEDORES", _uiController.BuscadorJerarquicoAllowMultipleSelect);	
			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ultraExplorerBarContainerControl4, hierarchicalSearchControl1);

			_uiController.GetProveedor();
			if (_uiController.IdProveedor == "")
				this.Text = "Alta de proveedores";
			else //Es edicion
			{
				this.Text = "Datos de " + _uiController.Nombre;
				hierarchicalSearchControl1.SetSelectionKey(_uiController.Jerarquias);
				
			}
			labelCampoAux1.Text = _uiController.EtiquetaCampoAuxiliar1;
			labelCampoAux2.Text = _uiController.EtiquetaCampoAuxiliar2;
			labelCampoAux3.Text = _uiController.EtiquetaCampoAuxiliar3;
			labelCampoAux4.Text = _uiController.EtiquetaCampoAuxiliar4;
			labelCampoAux5.Text = _uiController.EtiquetaCampoAuxiliar5;
			txtCodigo.Enabled = !ComprobantesRules.Proveedor_CodigoAutomatico;



			foreach( Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup group in this.ultraExplorerBar1.Groups)
			{				
				group.Visible = false;
				if (group.Container != null)
					group.Container.Enabled = false;
			}

			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					/*
					if (grupo.Equals("DatosGenerales"))
						this.ultraExplorerBar1.Groups[0].Visible = true;
					if (grupo.Equals("Avanzadas"))
						this.ultraExplorerBar1.Groups[1].Visible = true;
					if (grupo.Equals("DatosGenerales"))
						this.ultraExplorerBar1.Groups[2].Visible = true;
					if (grupo.Equals("Jerarquias"))
						this.ultraExplorerBar1.Groups[3].Visible = true;
					*/
					this.ultraExplorerBar1.Groups[grupo].Visible = true;
				}
			}

			if(!_uiController.ContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar1.Groups[grupo].Container != null)
						this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;
										
				}
			}

            mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, "Momentos.ABMProveedores.ContenedoresColapsados");

			this.mzCEResponsableIngreso.Enabled = _uiController.AllowEditResponsableIngreso;
			if (_uiController.AskForPasswordResponsableIngreso) 
			{
				this.mzCEResponsableIngreso.Nullable = true;				
				this.mzCEResponsableIngreso.NullText = string.Empty;
			}

		}

		private void InitializeData()
		{
			mzCmbSrchEdtTitular.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			componenteDocumentos1.FillFromDataSource( _uiController.TiposDocumento, "idTipoDocumento", "Descripcion", 100, "1", "2", "Descripcion");
			componenteDocumentos1.CantItems = 10;
			componenteDocumentos1.TipoDocSelected = _uiController.IdTipoDocumento;
			componenteDocumentos1.Numero = _uiController.Numero;		

			mzCmbTiposDeIVA.FillFromDataSource( _uiController.CategoriasIva, "IdCategoriaIva", "Descripcion", 100, "1", "2", "Descripcion");
			/* Silvina 20110829 - Tarea 0000198 */
			mzCmbTiposMovimiento.FillFromDataSource( _uiController.TiposMovimientos, "IdTipoMovimiento","Descripcion",1000,"ID","Descripcion","Descripcion");
			mzCmbSubTiposMovimiento.FillFromDataSource( _uiController.SubTiposMovimientos, "IdSubTipoMovimiento","Descripcion",1000,"ID","Descripcion","Descripcion");
			
			mzComboCondicionCompra.FillFromDataSource( _uiController.CondicionesDeCompra, "IdCondicionDeCompra","Descripcion",1000,"ID","Descripcion","Descripcion");
            /* Fin Silvina 20110829 - Tarea 0000198 */
			mzComboEstado.FillFromDataSource( _uiController.Estados, "IdEstado","Descripcion",8,"ID","Descripcion","Descripcion");
			mzCECondicionesRetecionesGanancias.FillFromDataSource(mz.erp.businessrules.tpu_ProveedoresCondicionesImpuestoGanancias.GetList().tpu_ProveedoresCondicionesImpuestoGanancias,"IdCondicionImpuestoGanancias", "Descripcion",8,"ID","Condiciones","IdCondicionImpuestoGanancias");


			this.mzCmbPaisEditar.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbPciaEditar.FillFromDataSource(_uiController.Provincias, _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
			this.mzCmbLocEditar.FillFromDataSource(_uiController.Localidades, _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);

			if(_uiController.IdProveedor != null && !_uiController.IdProveedor.Equals(string.Empty))
			{
				mzCmbLocEditar.Value = _uiController.IdLocalidad;
				mzCmbPaisEditar.Value = _uiController.IdPaisEdicion;
				mzCmbPciaEditar.Value = _uiController.IdProvinciaEdicion;
			}
            mzCEResponsableIngreso.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(false), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
			this.mzCEResponsableIngreso.Value = _uiController.IdResponsableIngreso;
		}
		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			//mzCmbTiposMovimiento.ValueChanged+=new EventHandler(mzCmbTiposMovimiento_ValueChanged);
			_uiController.TiposHasChanged+=new EventHandler(_uiController_TiposHasChanged);
			this.hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);
			
			this.mzCmbPaisEditar.SelectionChanged+=new EventHandler(mzCmbPaisEditar_SelectionChanged);
			this.mzCmbPciaEditar.SelectionChanged+=new EventHandler(mzCmbPciaEditar_SelectionChanged);
            //Cristian 20101116 Tarea 932
            this.mzCmbLocEditar.TextChanged += new EventHandler(mzCmbLocEditar_EnterElement);
            //Fin Tarea 932
			this.mzCEResponsableIngreso.Leave+=new EventHandler(mzCEResponsableIngreso_Change);

		}	
	
		private void InitDataBindings()
		{
			txtNombre.DataBindings.Add("Text", _uiController, "Nombre");
			mzCmbSrchEdtTitular.DataBindings.Add("DataValue", _uiController, "IdTitular");			
			//mzCmbTiposDeIVA.DataBindings.Add("Value", _uiController, "IdCategoriaIva");			
			BindingController.Bind(mzCmbTiposDeIVA,"Value", _uiController, "IdCategoriaIva");
			txtDomicilio.DataBindings.Add("Text", _uiController, "Domicilio");
			txtHorarioComercial.DataBindings.Add("Text", _uiController, "HorarioComercial");
			txtObservaciones.DataBindings.Add("Text", _uiController, "Observaciones");
			txtTelefonos.DataBindings.Add("Text", _uiController, "Telefonos");
			txtEmail.DataBindings.Add("Text", _uiController, "Email");
			txtWeb.DataBindings.Add("Text", _uiController, "Web");
			txtInstantMessenger.DataBindings.Add("Text", _uiController, "InstantMessenger");

			/*mzCmbTiposMovimiento.DataBindings.Add("Value", _uiController, "IdTipoDeMovimiento");			
			mzCmbSubTiposMovimiento.DataBindings.Add("Value", _uiController, "IdSubTipoDeMovimiento");			*/
			BindingController.Bind(mzCmbTiposMovimiento,"Value", _uiController, "IdTipoDeMovimiento");
			BindingController.Bind(mzCmbSubTiposMovimiento,"Value", _uiController, "IdSubTipoDeMovimiento");

			mzComboCondicionCompra.DataBindings.Add("Value", _uiController, "IdCondicionDeCompra");			

			uneBonificacionGeneral.DataBindings.Add("Value", _uiController, "BonificacionGeneral");
			//mzComboEstado.DataBindings.Add("Value", _uiController, "IdEstado");			
			BindingController.Bind(mzComboEstado,"Value", _uiController, "IdEstado");
			chkActivo.DataBindings.Add("Checked", _uiController, "Activo");
			uneDiasDemoraEntrega.DataBindings.Add("Value", _uiController, "DiasDemoraEntrega");			

			uneAlicuotaRetencionIIBBCompras.DataBindings.Add("Value", _uiController, "AlicuotaRetencionIIBBCompras");
			uneAlicuotaRetencionIIBBServicios.DataBindings.Add("Value", _uiController, "AlicuotaRetencionIIBBServicios");
			
			//mzComboEstado.Value = "normal";
		}
		private void FillControls() 
		{
            if (this._uiController.IdProveedor == "")
            {
                if (_uiController.IdCategoriaIvaDefault != String.Empty)
                    this.mzCmbTiposDeIVA.SetValue(Convert.ToString(_uiController.IdCategoriaIvaDefault));
                //if (_uiController.IdEstadoDefault != String.Empty)
                /*
                if (_uiController.Estados.Rows.Count > 0)
                    this.mzComboEstado.SetValue(_uiController.IdEstadoDefault);
                else
                    this.mzComboEstado.Value = null;
                */
            }
            //Para Sabrina
            //Cristian 20101116 Tarea 932
            else {

                    mzCmbPaisEditar.Value = _uiController.IdPaisEdicion;
                    mzCmbPciaEditar.Value = _uiController.IdProvinciaEdicion;
                    mzCmbLocEditar.Value = _uiController.IdLocalidad;
                    mzTxtCPostal.Text = _uiController.CodigoPostalLocalidad(_uiController.IdLocalidad);
                  }
            //Fin Tares 932
			txtCampoAuxiliar1.Text = _uiController.CampoAuxiliar1;
			txtCampoAuxiliar2.Text = _uiController.CampoAuxiliar2;
			txtCampoAuxiliar3.Text = _uiController.CampoAuxiliar3;
			txtCampoAuxiliar4.Text = _uiController.CampoAuxiliar4;
			uneCampoAuxiliar5.Value = _uiController.CampoAuxiliar5;
			chkExcluyeRetencionesIIBB.Checked = _uiController.ExcluyeRetencionIIBB;
			chkExcluyeRetencionesIVA.Checked = _uiController.ExcluyeRetencionIVA;
			mzCECondicionesRetecionesGanancias.Value = _uiController.IdCondicionRetecionGanancias;
		    txtCodigo.Text = _uiController.Codigo;
			mzCEResponsableIngreso.Value = _uiController.IdResponsableIngreso;
		}

		#endregion

		private void Save()//dumpcontrols()
		{
			Util.MoveFocus(this.ultraExplorerBarContainerControl1);					
			_uiController.IdTipoDocumento = componenteDocumentos1.TipoDocSelected;
			_uiController.Numero = componenteDocumentos1.Numero;			
			_uiController.CampoAuxiliar1 = txtCampoAuxiliar1.Text;
			_uiController.CampoAuxiliar2 = txtCampoAuxiliar2.Text;
			_uiController.CampoAuxiliar3 = txtCampoAuxiliar3.Text;
			_uiController.CampoAuxiliar4 = txtCampoAuxiliar4.Text;
			_uiController.CampoAuxiliar5 = Convert.ToDecimal(uneCampoAuxiliar5.Value);

			_uiController.ExcluyeRetencionIIBB = chkExcluyeRetencionesIIBB.Checked ;
			_uiController.ExcluyeRetencionIVA = chkExcluyeRetencionesIVA.Checked;
			_uiController.IdCondicionRetecionGanancias = Convert.ToInt64(mzCECondicionesRetecionesGanancias.Value);
			_uiController.Codigo = txtCodigo.Text;
			_uiController.IdLocalidad = Convert.ToString(mzCmbLocEditar.Value);
			_uiController.IdResponsableIngreso = Convert.ToString(mzCEResponsableIngreso.Value);

			_uiController.Execute();
			if (!_uiController.HasErrors){
				if ( OnRowChanged != null )
				{
					OnRowChanged( this, null );
				}
				this.Close();
				System.Windows.Forms.MessageBox.Show( "El proceso ha finalizado con éxito.","Mensaje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information );
			}			
			else
			{				
				if(_uiController.Errors.Rows.Count > 0)
				{
					/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( _uiController.GetErrors() );
					_form.ShowDialog();
				}
			}
		}

		private void mzCmbTiposMovimiento_ValueChanged(object sender, System.EventArgs e)
		{			
		/*	tsy_SubTipoMovimientoDataset subtipos = mz.erp.businessrules.tsy_SubTipoMovimiento.GetList( Convert.ToString(this.mzCmbTiposMovimiento.Value));
			this.mzCmbSubTiposMovimiento.FillFromDataSource(subtipos.tsy_SubTipoMovimiento, "IdSubTipoMovimiento","Descripcion",100,"Descripcion");
			if (subtipos.tsy_SubTipoMovimiento.Count != 0)
				this.mzCmbSubTiposMovimiento.Value = subtipos.tsy_SubTipoMovimiento[0]["IdSubTipoMovimiento"];
			this.mzCmbSubTiposMovimiento.ReadOnly = false;*/			
		}
		private void _uiController_TiposHasChanged(object sender, EventArgs e)
		{
			mzCmbSubTiposMovimiento.FillFromDataSource( _uiController.SubTiposMovimientos, "IdSubTipoMovimiento","Descripcion",8,"ID","Descripcion","Descripcion");			
			/*try 
			{
				if (mzCmbTipos.Value != null) 
				{														
					if (_uiController.CantidadSubTipos <= 1) 
					{					
						this.mzCmbSubTipos.Enabled = false;								
					}
					else 
					{					
						this.mzCmbSubTipos.Enabled = true;
					
					}
				}
			}
			catch{}*/
		}


		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				/*case 0:
					this.RefreshData();
					break;
				case 2:
					this.ResetParameters();
					break;
				case 4:
					this.Nuevo();
					break;
				case 6:
					this.Editar();
					break;*/
				case 7:
					this.Save();
					break;
				case 8:/*Siguiente*/
					
					break;
				case 10:/*Siguiente*/
					
					break;								
			}		
		}

		private void ultraLabel7_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
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

		private void mzCmbPaisEditar_SelectionChanged(object sender, EventArgs e)
		{
			long idPaisSeleccionado = (long)mzCmbPaisEditar.Value;
			if(!idPaisSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbPciaEditar.FillFromDataSource(_uiController.ProvinciasPais(idPaisSeleccionado), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
				if(idPaisSeleccionado != _uiController.IdPaisEdicion)
				{
					_uiController.IdPaisEdicion=idPaisSeleccionado;
					if(mzCmbPciaEditar.Items.Count!=0)
					{
						mzCmbPciaEditar.Enabled=true;
						mzCmbLocEditar.Enabled=false;
						mzCmbPciaEditar.SelectedIndex = 0;
						_uiController.IdProvinciaEdicion = (long)mzCmbPciaEditar.Value;
						
					}
					else 
					{
						mzCmbPciaEditar.Enabled=false;
						mzCmbLocEditar.Enabled=false;
					}
					
				}
			}

		}

		private void mzCmbPciaEditar_SelectionChanged(object sender, EventArgs e)
		{
			long idProvinciaSeleccionado = (long)mzCmbPciaEditar.Value;
			if(!idProvinciaSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbLocEditar.FillFromDataSource(_uiController.LocalidadPcia(idProvinciaSeleccionado), _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
				if(idProvinciaSeleccionado != _uiController.IdProvinciaEdicion)
				{
					_uiController.IdProvinciaEdicion=idProvinciaSeleccionado;
					if(mzCmbLocEditar.Items.Count!=0)
					{	
						mzCmbLocEditar.Enabled=true;
						mzCmbLocEditar.SelectedIndex = 0;
						_uiController.IdLocalidad = (string)mzCmbLocEditar.Value;
						
					}
					else 
					{
						mzCmbLocEditar.Enabled=false;
									
					}
					
				}
			}

		}
        //Cristian 20101116 Tarea 932
		private void mzCmbLocEditar_EnterElement(object sender, EventArgs e)
        {
            String idLocalidadSeleccionada = (String)mzCmbLocEditar.Value;
            if (!idLocalidadSeleccionada.Equals(String.Empty)) 
            { if(! (mzCmbLocEditar.Text == "No indica")){
                this.mzTxtCPostal.Text = _uiController.CodigoPostalLocalidad(idLocalidadSeleccionada); 
              }
               else {  this.mzTxtCPostal.Text = "--";}
            }
 

        }
        //Fin Tarea 932

		private void mzCEResponsableIngreso_Change(object sender, EventArgs e)
		{
			if (_uiController.AskForPasswordResponsableIngreso) 
			{
				ShowPassword();				
			}	
		}

		private void ShowPassword() 
		{			
			string IdPersona = Convert.ToString(mzCEResponsableIngreso.Value);			
			if (IdPersona != _uiController.UltimoResponsableClaveCorrecta)
			{
				string password = InputBox.ShowInputBoxPassword("Ingrese la contraseña:","Cambio de responsable asociado al nuevo ingreso");								
				bool ClaveCorrecta = false;
				if (IdPersona != null && !IdPersona.Equals(string.Empty) )
				{
					ClaveCorrecta = businessrules.Security.LogInXPersona(IdPersona, password);					
					if (!ClaveCorrecta /*&& password != ""*/)
						MessageBox.Show("¡Clave incorrecta!", "Cambio de responsable de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
						_uiController.UltimoResponsableClaveCorrecta = IdPersona;
				}
				
				if (!ClaveCorrecta)
				{
					this.mzCEResponsableIngreso.Value = string.Empty;
					_uiController.IdResponsableIngreso = string.Empty;
				}
			}				
		}



	}
}

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace mz.erp.ui.forms
{
	public class FrmAbmProveedoresNuevo : mz.erp.ui.forms.FrmAMB
	{
		//private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtTelefonos;
		private System.Windows.Forms.TextBox txtDomicilio;
		private Infragistics.Win.Misc.UltraLabel ultraLabel8;
		private Infragistics.Win.Misc.UltraLabel ultraLabel12;
		private System.Windows.Forms.TextBox txtHorarioComercial;
		private Infragistics.Win.Misc.UltraLabel ultraLabel13;
		private System.Windows.Forms.TextBox txtWeb;
		private System.Windows.Forms.TextBox txtInstantMessenger;		
		private mz.erp.ui.controls.ComponenteDocumentos componenteDocumentos1;
		private System.Windows.Forms.RichTextBox txtObservaciones;
		private System.Windows.Forms.Label label10;
		
		private System.Windows.Forms.Label label9;
		private mz.erp.ui.controls.mzComboEditor mzCmbSubTiposMovimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel7;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposMovimiento;
		private Infragistics.Win.Misc.UltraLabel ultraLabel10;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private mz.erp.ui.controls.mzComboEditor mzComboCondicionCompra;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label21;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasDemoraEntrega;
		private System.Windows.Forms.Label label2;
		private mz.erp.ui.controls.mzComboEditor mzComboEstado;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacionGeneral;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkExcluyeRetenciones;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDeIVA;
		private System.Windows.Forms.Label label7;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtTitular;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtLocalidad;
		private System.ComponentModel.IContainer components = null;

		#region Código generado por el diseñador
		private void InitializeComponent()
		{
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label10 = new System.Windows.Forms.Label();
			this.uneBonificacionGeneral = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.mzComboEstado = new mz.erp.ui.controls.mzComboEditor();
			this.label21 = new System.Windows.Forms.Label();
			this.uneDiasDemoraEntrega = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.chkExcluyeRetenciones = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtInstantMessenger = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTelefonos = new System.Windows.Forms.TextBox();
			this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel12 = new Infragistics.Win.Misc.UltraLabel();
			this.txtHorarioComercial = new System.Windows.Forms.TextBox();
			this.ultraLabel13 = new Infragistics.Win.Misc.UltraLabel();
			this.txtWeb = new System.Windows.Forms.TextBox();
			this.componenteDocumentos1 = new mz.erp.ui.controls.ComponenteDocumentos();
			this.txtObservaciones = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.mzCmbSubTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbTiposMovimiento = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
			this.mzComboCondicionCompra = new mz.erp.ui.controls.mzComboEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.mzCmbTiposDeIVA = new mz.erp.ui.controls.mzComboEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.mzCmbSrchEdtTitular = new mz.erp.ui.controls.mzComboSearchEditor();
			this.mzCmbSrchEdtLocalidad = new mz.erp.ui.controls.mzComboSearchEditor();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionGeneral)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEstado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneDiasDemoraEntrega)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboCondicionCompra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeIVA)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Otros datos de interés";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1";
			this.ultraExplorerBar1.Size = new System.Drawing.Size(856, 505);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSrchEdtLocalidad);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSrchEdtTitular);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposDeIVA);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboCondicionCompra);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSubTiposMovimiento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel7);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposMovimiento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel10);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label9);
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
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(790, 432);
			this.ultraExplorerBarContainerControl1.TabIndex = 1;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label10);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneBonificacionGeneral);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzComboEstado);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label21);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uneDiasDemoraEntrega);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkActivo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkExcluyeRetenciones);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 522);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(790, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(64, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(223, 21);
			this.label10.TabIndex = 63;
			this.label10.Text = "Bonificación general";
			// 
			// uneBonificacionGeneral
			// 
			this.uneBonificacionGeneral.Location = new System.Drawing.Point(288, 24);
			this.uneBonificacionGeneral.MaskInput = "nnnnnnnn.nnnn";
			this.uneBonificacionGeneral.Name = "uneBonificacionGeneral";
			this.uneBonificacionGeneral.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneBonificacionGeneral.Size = new System.Drawing.Size(100, 21);
			this.uneBonificacionGeneral.TabIndex = 62;
			this.uneBonificacionGeneral.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(64, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 82;
			this.label2.Text = "Estado";
			// 
			// mzComboEstado
			// 
			this.mzComboEstado.AutoComplete = true;
			this.mzComboEstado.DataSource = null;
			this.mzComboEstado.DisplayMember = "";
			this.mzComboEstado.DisplayMemberCaption = "";
			this.mzComboEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboEstado.Location = new System.Drawing.Point(176, 64);
			this.mzComboEstado.MaxItemsDisplay = 7;
			this.mzComboEstado.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboEstado.Name = "mzComboEstado";
			this.mzComboEstado.SorterMember = "";
			this.mzComboEstado.TabIndex = 81;
			this.mzComboEstado.ValueMember = "";
			this.mzComboEstado.ValueMemberCaption = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(448, 40);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(160, 24);
			this.label21.TabIndex = 80;
			this.label21.Text = "Días de demora en la entrega";
			// 
			// uneDiasDemoraEntrega
			// 
			this.uneDiasDemoraEntrega.Location = new System.Drawing.Point(608, 40);
			this.uneDiasDemoraEntrega.MaxValue = 99999;
			this.uneDiasDemoraEntrega.MinValue = 0;
			this.uneDiasDemoraEntrega.Name = "uneDiasDemoraEntrega";
			this.uneDiasDemoraEntrega.Size = new System.Drawing.Size(72, 21);
			this.uneDiasDemoraEntrega.TabIndex = 79;
			this.uneDiasDemoraEntrega.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Location = new System.Drawing.Point(448, 96);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.TabIndex = 70;
			this.chkActivo.Text = "Activo";
			// 
			// chkExcluyeRetenciones
			// 
			this.chkExcluyeRetenciones.BackColor = System.Drawing.Color.Transparent;
			this.chkExcluyeRetenciones.Location = new System.Drawing.Point(184, 104);
			this.chkExcluyeRetenciones.Name = "chkExcluyeRetenciones";
			this.chkExcluyeRetenciones.Size = new System.Drawing.Size(136, 20);
			this.chkExcluyeRetenciones.TabIndex = 71;
			this.chkExcluyeRetenciones.Text = "Excluye retenciones";
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Location = new System.Drawing.Point(8, 272);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel6.TabIndex = 50;
			this.ultraLabel6.Text = "Instant Messenger";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Location = new System.Drawing.Point(0, 0);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel5.TabIndex = 49;
			this.ultraLabel5.Text = "Nombre";
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(8, 168);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel4.TabIndex = 48;
			this.ultraLabel4.Text = "Observaciones";
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Location = new System.Drawing.Point(8, 256);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel3.TabIndex = 47;
			this.ultraLabel3.Text = "Email";
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Location = new System.Drawing.Point(8, 232);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel2.TabIndex = 46;
			this.ultraLabel2.Text = "Teléfonos";
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(0, 91);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel1.TabIndex = 45;
			this.ultraLabel1.Text = "Domicilio";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(104, 88);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(496, 20);
			this.txtDomicilio.TabIndex = 4;
			this.txtDomicilio.Text = "txtDomicilio";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(112, 248);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(496, 20);
			this.txtEmail.TabIndex = 8;
			this.txtEmail.Text = "txtEmail";
			// 
			// txtInstantMessenger
			// 
			this.txtInstantMessenger.Location = new System.Drawing.Point(112, 272);
			this.txtInstantMessenger.Name = "txtInstantMessenger";
			this.txtInstantMessenger.Size = new System.Drawing.Size(496, 20);
			this.txtInstantMessenger.TabIndex = 9;
			this.txtInstantMessenger.Text = "txtInstantMessenger";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(104, 0);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(496, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.Text = "txtNombre";
			// 
			// txtTelefonos
			// 
			this.txtTelefonos.Location = new System.Drawing.Point(112, 232);
			this.txtTelefonos.Name = "txtTelefonos";
			this.txtTelefonos.Size = new System.Drawing.Size(496, 20);
			this.txtTelefonos.TabIndex = 7;
			this.txtTelefonos.Text = "txtTelefonos";
			// 
			// ultraLabel8
			// 
			this.ultraLabel8.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel8.Location = new System.Drawing.Point(0, 24);
			this.ultraLabel8.Name = "ultraLabel8";
			this.ultraLabel8.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel8.TabIndex = 53;
			this.ultraLabel8.Text = "Titular";
			// 
			// ultraLabel12
			// 
			this.ultraLabel12.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel12.Location = new System.Drawing.Point(8, 144);
			this.ultraLabel12.Name = "ultraLabel12";
			this.ultraLabel12.Size = new System.Drawing.Size(96, 16);
			this.ultraLabel12.TabIndex = 59;
			this.ultraLabel12.Text = "Horario comercial";
			// 
			// txtHorarioComercial
			// 
			this.txtHorarioComercial.Location = new System.Drawing.Point(112, 136);
			this.txtHorarioComercial.Name = "txtHorarioComercial";
			this.txtHorarioComercial.Size = new System.Drawing.Size(496, 20);
			this.txtHorarioComercial.TabIndex = 5;
			this.txtHorarioComercial.Text = "txtHorarioComercial";
			// 
			// ultraLabel13
			// 
			this.ultraLabel13.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel13.Location = new System.Drawing.Point(8, 296);
			this.ultraLabel13.Name = "ultraLabel13";
			this.ultraLabel13.Size = new System.Drawing.Size(100, 16);
			this.ultraLabel13.TabIndex = 61;
			this.ultraLabel13.Text = "Web";
			// 
			// txtWeb
			// 
			this.txtWeb.Location = new System.Drawing.Point(112, 288);
			this.txtWeb.Name = "txtWeb";
			this.txtWeb.Size = new System.Drawing.Size(496, 20);
			this.txtWeb.TabIndex = 10;
			this.txtWeb.Text = "txtWeb";
			// 
			// componenteDocumentos1
			// 
			this.componenteDocumentos1.BackColor = System.Drawing.Color.Transparent;
			this.componenteDocumentos1.Location = new System.Drawing.Point(-8, 64);
			this.componenteDocumentos1.Name = "componenteDocumentos1";
			this.componenteDocumentos1.Numero = "";
			this.componenteDocumentos1.Size = new System.Drawing.Size(616, 24);
			this.componenteDocumentos1.TabIndex = 3;
			this.componenteDocumentos1.TipoDocSelected = "";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(112, 160);
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(496, 72);
			this.txtObservaciones.TabIndex = 6;
			this.txtObservaciones.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(0, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 65;
			this.label9.Text = "Localidad:";
			// 
			// mzCmbSubTiposMovimiento
			// 
			this.mzCmbSubTiposMovimiento.AutoComplete = true;
			this.mzCmbSubTiposMovimiento.DataSource = null;
			this.mzCmbSubTiposMovimiento.DisplayMember = "";
			this.mzCmbSubTiposMovimiento.DisplayMemberCaption = "";
			this.mzCmbSubTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbSubTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCmbSubTiposMovimiento.Location = new System.Drawing.Point(112, 344);
			this.mzCmbSubTiposMovimiento.MaxItemsDisplay = 7;
			this.mzCmbSubTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbSubTiposMovimiento.Name = "mzCmbSubTiposMovimiento";
			this.mzCmbSubTiposMovimiento.Size = new System.Drawing.Size(272, 21);
			this.mzCmbSubTiposMovimiento.SorterMember = "";
			this.mzCmbSubTiposMovimiento.TabIndex = 68;
			this.mzCmbSubTiposMovimiento.ValueMember = "";
			this.mzCmbSubTiposMovimiento.ValueMemberCaption = "";
			// 
			// ultraLabel7
			// 
			this.ultraLabel7.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel7.Location = new System.Drawing.Point(8, 344);
			this.ultraLabel7.Name = "ultraLabel7";
			this.ultraLabel7.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel7.TabIndex = 69;
			this.ultraLabel7.Text = "Sub-Tipo de Movim.";
			// 
			// mzCmbTiposMovimiento
			// 
			this.mzCmbTiposMovimiento.AutoComplete = true;
			this.mzCmbTiposMovimiento.DataSource = null;
			this.mzCmbTiposMovimiento.DisplayMember = "";
			this.mzCmbTiposMovimiento.DisplayMemberCaption = "";
			this.mzCmbTiposMovimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposMovimiento.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
			this.mzCmbTiposMovimiento.Location = new System.Drawing.Point(112, 320);
			this.mzCmbTiposMovimiento.MaxItemsDisplay = 7;
			this.mzCmbTiposMovimiento.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposMovimiento.Name = "mzCmbTiposMovimiento";
			this.mzCmbTiposMovimiento.Size = new System.Drawing.Size(272, 21);
			this.mzCmbTiposMovimiento.SorterMember = "";
			this.mzCmbTiposMovimiento.TabIndex = 66;
			this.mzCmbTiposMovimiento.ValueMember = "";
			this.mzCmbTiposMovimiento.ValueMemberCaption = "";
			// 
			// ultraLabel10
			// 
			this.ultraLabel10.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel10.Location = new System.Drawing.Point(8, 320);
			this.ultraLabel10.Name = "ultraLabel10";
			this.ultraLabel10.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel10.TabIndex = 67;
			this.ultraLabel10.Text = "Tipo de Movimiento";
			// 
			// mzComboCondicionCompra
			// 
			this.mzComboCondicionCompra.AutoComplete = true;
			this.mzComboCondicionCompra.DataSource = null;
			this.mzComboCondicionCompra.DisplayMember = "";
			this.mzComboCondicionCompra.DisplayMemberCaption = "";
			this.mzComboCondicionCompra.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboCondicionCompra.Location = new System.Drawing.Point(112, 376);
			this.mzComboCondicionCompra.MaxItemsDisplay = 7;
			this.mzComboCondicionCompra.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboCondicionCompra.Name = "mzComboCondicionCompra";
			this.mzComboCondicionCompra.SorterMember = "";
			this.mzComboCondicionCompra.TabIndex = 72;
			this.mzComboCondicionCompra.ValueMember = "";
			this.mzComboCondicionCompra.ValueMemberCaption = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 384);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 16);
			this.label1.TabIndex = 73;
			this.label1.Text = "Condición de compra";
			// 
			// mzCmbTiposDeIVA
			// 
			this.mzCmbTiposDeIVA.AutoComplete = true;
			this.mzCmbTiposDeIVA.DataSource = null;
			this.mzCmbTiposDeIVA.DisplayMember = "";
			this.mzCmbTiposDeIVA.DisplayMemberCaption = "";
			this.mzCmbTiposDeIVA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposDeIVA.Location = new System.Drawing.Point(104, 48);
			this.mzCmbTiposDeIVA.MaxItemsDisplay = 7;
			this.mzCmbTiposDeIVA.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposDeIVA.Name = "mzCmbTiposDeIVA";
			this.mzCmbTiposDeIVA.Size = new System.Drawing.Size(216, 21);
			this.mzCmbTiposDeIVA.SorterMember = "";
			this.mzCmbTiposDeIVA.TabIndex = 74;
			this.mzCmbTiposDeIVA.ValueMember = "";
			this.mzCmbTiposDeIVA.ValueMemberCaption = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(0, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 15);
			this.label7.TabIndex = 75;
			this.label7.Text = "Condición de IVA";
			// 
			// mzCmbSrchEdtTitular
			// 
			this.mzCmbSrchEdtTitular.DataValue = "";
			this.mzCmbSrchEdtTitular.EditObject = null;
			this.mzCmbSrchEdtTitular.FastSearch = false;
			this.mzCmbSrchEdtTitular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbSrchEdtTitular.HierarchicalSearch = false;
			this.mzCmbSrchEdtTitular.Location = new System.Drawing.Point(104, 24);
			this.mzCmbSrchEdtTitular.Name = "mzCmbSrchEdtTitular";
			this.mzCmbSrchEdtTitular.ReadOnly = false;
			this.mzCmbSrchEdtTitular.SearchObject = null;
			this.mzCmbSrchEdtTitular.SearchObjectListener = null;
			this.mzCmbSrchEdtTitular.Size = new System.Drawing.Size(496, 22);
			this.mzCmbSrchEdtTitular.TabIndex = 76;
			// 
			// mzCmbSrchEdtLocalidad
			// 
			this.mzCmbSrchEdtLocalidad.DataValue = "";
			this.mzCmbSrchEdtLocalidad.EditObject = null;
			this.mzCmbSrchEdtLocalidad.FastSearch = false;
			this.mzCmbSrchEdtLocalidad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbSrchEdtLocalidad.HierarchicalSearch = false;
			this.mzCmbSrchEdtLocalidad.Location = new System.Drawing.Point(104, 112);
			this.mzCmbSrchEdtLocalidad.Name = "mzCmbSrchEdtLocalidad";
			this.mzCmbSrchEdtLocalidad.ReadOnly = false;
			this.mzCmbSrchEdtLocalidad.SearchObject = null;
			this.mzCmbSrchEdtLocalidad.SearchObjectListener = null;
			this.mzCmbSrchEdtLocalidad.Size = new System.Drawing.Size(544, 22);
			this.mzCmbSrchEdtLocalidad.TabIndex = 77;
			// 
			// FrmAbmProveedoresNuevo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(856, 533);
			this.Name = "FrmAbmProveedoresNuevo";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionGeneral)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboEstado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneDiasDemoraEntrega)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSubTiposMovimiento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposMovimiento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboCondicionCompra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeIVA)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		#region Constructores y Destructores
		public FrmAbmProveedoresNuevo()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.AbmProveedoresController();	

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
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

		#region Variables Privadas
		private controllers.AbmProveedoresController _uiController = null;
		#endregion

		#region Variables Publicas
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
			/*tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	
			txtClaveAnt.Select();
			txtClaveAnt.Enabled = _uiController.EnabledSetPreviuosPassword;
			mzCmbUsuarios.FillFromDataSource( _uiController.Usuarios, _uiController.KeyValueUsuarios,_uiController.KeyListUsuarios,100, _uiController.KeyListUsuarios );
			mzCmbUsuarios.Enabled = !_uiController.EnabledSetPreviuosPassword;*/
		}

		private void InitializeData()
		{
			mzCmbSrchEdtTitular.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			mzCmbTiposDeIVA.FillFromDataSource(businessrules.tsy_CategoriasIva.GetList().tsy_CategoriasIva, "IdCategoriaIva", "Descripcion", 100, "1", "2", "Descripcion");
			mzCmbSrchEdtLocalidad.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Localidades );
			mzCmbTiposMovimiento.FillFromDataSource( businessrules.tsy_TiposMovimientos.GetList().tsy_TiposMovimientos, "IdTipoMovimiento","Descripcion",8,"ID","Descripcion","Descripcion");
			/*tsy_SubTipoMovimientoDataset subtipos = mz.erp.businessrules.tsy_SubTipoMovimiento.GetList( Convert.ToString(this.mzCmbTiposMovimiento.Value));
			mzCmbSubTiposMovimiento.FillFromDataSource(subtipos.tsy_SubTipoMovimiento, "IdSubTipoMovimiento","Descripcion",100,"Descripcion");*/
			//mzComboCondicionCompra.FillFromDataSource
		}
		private void InitEventHandlers()
		{
		}	
	
		private void InitDataBindings()
		{
			txtNombre.DataBindings.Add("Text", _uiController, "Nombre");
			//titular
			//cat iva
			//tipo doc y nro
			txtDomicilio.DataBindings.Add("Text", _uiController, "Domicilio");
			//localidad
			txtHorarioComercial.DataBindings.Add("Text", _uiController, "HorarioComercial");
			txtObservaciones.DataBindings.Add("Text", _uiController, "Observaciones");
			txtTelefonos.DataBindings.Add("Text", _uiController, "Telefonos");
			txtEmail.DataBindings.Add("Text", _uiController, "Email");
			txtWeb.DataBindings.Add("Text", _uiController, "Web");
			txtInstantMessenger.DataBindings.Add("Text", _uiController, "InstantMessenger");
			//tipo mov
			//sub tipo mov
			//cond compra

			uneBonificacionGeneral.DataBindings.Add("Value", _uiController, "BonificacionGeneral");
			//estado			
			chkActivo.DataBindings.Add("Checked", _uiController, "Activo");
			chkExcluyeRetenciones.DataBindings.Add("Checked", _uiController, "ExcluyeRetenciones");			
			uneDiasDemoraEntrega.DataBindings.Add("Value", _uiController, "DiasDemoraEntrega");

			/*BindingController.Bind(txtClaveAnt,"Text", _uiController, "ClaveAnterior");
			BindingController.Bind(txtClaveNue1,"Text", _uiController, "ClaveNueva1");
			BindingController.Bind(txtClaveNue2,"Text", _uiController, "ClaveNueva2");			
			BindingController.Bind(mzCmbUsuarios, "Value", _uiController, "IdUsuario" );			*/
			
		}

		#endregion
	}
}
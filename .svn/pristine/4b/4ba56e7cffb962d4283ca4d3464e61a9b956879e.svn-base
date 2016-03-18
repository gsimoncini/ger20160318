using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.businessrules;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmDomicilios.
	/// </summary>
	public class FrmAbmDomicilios : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private mz.erp.ui.controls.mzComboEditor mzCmbPais;
		private mz.erp.ui.controls.mzComboEditor mzCmbProvincia;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private mz.erp.ui.controls.mzComboEditor mzCmbLocalidad;
		private mz.erp.ui.controls.mzComboEditor mzCmbResponsable;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtTelefonos;
		private System.Windows.Forms.TextBox txtCodigoPostal;
		private System.Windows.Forms.TextBox txtManzana;
		private System.Windows.Forms.TextBox txtDepartamento;
		private System.Windows.Forms.TextBox txtPiso;
		private System.Windows.Forms.TextBox txtTorre;
		private System.Windows.Forms.TextBox txtSector;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.TextBox txtCalle;
		private System.Windows.Forms.Label label14;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDeDomicilios;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		protected System.Windows.Forms.ToolBarButton tbbAceptar;
		private System.Windows.Forms.ToolBarButton tbbSeparator4;
		protected System.Windows.Forms.ToolBarButton tbbGuardar;
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmDomicilios));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmbPais = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbProvincia = new mz.erp.ui.controls.mzComboEditor();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.mzCmbLocalidad = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbResponsable = new mz.erp.ui.controls.mzComboEditor();
			this.label15 = new System.Windows.Forms.Label();
			this.txtTelefonos = new System.Windows.Forms.TextBox();
			this.txtCodigoPostal = new System.Windows.Forms.TextBox();
			this.txtManzana = new System.Windows.Forms.TextBox();
			this.txtDepartamento = new System.Windows.Forms.TextBox();
			this.txtPiso = new System.Windows.Forms.TextBox();
			this.txtTorre = new System.Windows.Forms.TextBox();
			this.txtSector = new System.Windows.Forms.TextBox();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.mzCmbTiposDeDomicilios = new mz.erp.ui.controls.mzComboEditor();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbAceptar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
			this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPais)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProvincia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbLocalidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbResponsable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeDomicilios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(670, 25);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(670, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbPais);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbProvincia);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label13);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label12);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbLocalidad);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbResponsable);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label15);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtTelefonos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtCodigoPostal);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtManzana);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtDepartamento);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtPiso);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtTorre);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtSector);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtNumero);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtCalle);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label14);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.mzCmbTiposDeDomicilios);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label10);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label9);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 108);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(670, 315);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// mzCmbPais
			// 
			this.mzCmbPais.AutoComplete = true;
			this.mzCmbPais.DataSource = null;
			this.mzCmbPais.DisplayMember = "";
			this.mzCmbPais.DisplayMemberCaption = "";
			this.mzCmbPais.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbPais.Location = new System.Drawing.Point(120, 96);
			this.mzCmbPais.MaxItemsDisplay = 7;
			this.mzCmbPais.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbPais.Name = "mzCmbPais";
			this.mzCmbPais.Size = new System.Drawing.Size(272, 21);
			this.mzCmbPais.SorterMember = "";
			this.mzCmbPais.TabIndex = 119;
			this.mzCmbPais.ValueMember = "";
			this.mzCmbPais.ValueMemberCaption = "";
			// 
			// mzCmbProvincia
			// 
			this.mzCmbProvincia.AutoComplete = true;
			this.mzCmbProvincia.DataSource = null;
			this.mzCmbProvincia.DisplayMember = "";
			this.mzCmbProvincia.DisplayMemberCaption = "";
			this.mzCmbProvincia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbProvincia.Location = new System.Drawing.Point(120, 118);
			this.mzCmbProvincia.MaxItemsDisplay = 7;
			this.mzCmbProvincia.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbProvincia.Name = "mzCmbProvincia";
			this.mzCmbProvincia.Size = new System.Drawing.Size(272, 21);
			this.mzCmbProvincia.SorterMember = "";
			this.mzCmbProvincia.TabIndex = 117;
			this.mzCmbProvincia.ValueMember = "";
			this.mzCmbProvincia.ValueMemberCaption = "";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(8, 96);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 21);
			this.label13.TabIndex = 118;
			this.label13.Text = "País:";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(8, 118);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 21);
			this.label12.TabIndex = 116;
			this.label12.Text = "Provincia:";
			// 
			// mzCmbLocalidad
			// 
			this.mzCmbLocalidad.AutoComplete = true;
			this.mzCmbLocalidad.DataSource = null;
			this.mzCmbLocalidad.DisplayMember = "";
			this.mzCmbLocalidad.DisplayMemberCaption = "";
			this.mzCmbLocalidad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbLocalidad.Location = new System.Drawing.Point(120, 140);
			this.mzCmbLocalidad.MaxItemsDisplay = 7;
			this.mzCmbLocalidad.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbLocalidad.Name = "mzCmbLocalidad";
			this.mzCmbLocalidad.Size = new System.Drawing.Size(272, 21);
			this.mzCmbLocalidad.SorterMember = "";
			this.mzCmbLocalidad.TabIndex = 115;
			this.mzCmbLocalidad.ValueMember = "";
			this.mzCmbLocalidad.ValueMemberCaption = "";
			// 
			// mzCmbResponsable
			// 
			this.mzCmbResponsable.AutoComplete = true;
			this.mzCmbResponsable.DataSource = null;
			this.mzCmbResponsable.DisplayMember = "";
			this.mzCmbResponsable.DisplayMemberCaption = "";
			this.mzCmbResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbResponsable.Location = new System.Drawing.Point(120, 294);
			this.mzCmbResponsable.MaxItemsDisplay = 7;
			this.mzCmbResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbResponsable.Name = "mzCmbResponsable";
			this.mzCmbResponsable.Size = new System.Drawing.Size(272, 21);
			this.mzCmbResponsable.SorterMember = "";
			this.mzCmbResponsable.TabIndex = 112;
			this.mzCmbResponsable.ValueMember = "";
			this.mzCmbResponsable.ValueMemberCaption = "";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(8, 294);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 21);
			this.label15.TabIndex = 114;
			this.label15.Text = "Responsable:";
			// 
			// txtTelefonos
			// 
			this.txtTelefonos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTelefonos.Location = new System.Drawing.Point(120, 74);
			this.txtTelefonos.Name = "txtTelefonos";
			this.txtTelefonos.Size = new System.Drawing.Size(272, 20);
			this.txtTelefonos.TabIndex = 99;
			this.txtTelefonos.Text = "";
			// 
			// txtCodigoPostal
			// 
			this.txtCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCodigoPostal.Location = new System.Drawing.Point(120, 272);
			this.txtCodigoPostal.Name = "txtCodigoPostal";
			this.txtCodigoPostal.Size = new System.Drawing.Size(272, 20);
			this.txtCodigoPostal.TabIndex = 111;
			this.txtCodigoPostal.Text = "";
			// 
			// txtManzana
			// 
			this.txtManzana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtManzana.Location = new System.Drawing.Point(120, 250);
			this.txtManzana.Name = "txtManzana";
			this.txtManzana.Size = new System.Drawing.Size(272, 20);
			this.txtManzana.TabIndex = 110;
			this.txtManzana.Text = "";
			// 
			// txtDepartamento
			// 
			this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDepartamento.Location = new System.Drawing.Point(120, 228);
			this.txtDepartamento.Name = "txtDepartamento";
			this.txtDepartamento.Size = new System.Drawing.Size(272, 20);
			this.txtDepartamento.TabIndex = 108;
			this.txtDepartamento.Text = "";
			// 
			// txtPiso
			// 
			this.txtPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPiso.Location = new System.Drawing.Point(120, 206);
			this.txtPiso.Name = "txtPiso";
			this.txtPiso.Size = new System.Drawing.Size(272, 20);
			this.txtPiso.TabIndex = 106;
			this.txtPiso.Text = "";
			// 
			// txtTorre
			// 
			this.txtTorre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtTorre.Location = new System.Drawing.Point(120, 184);
			this.txtTorre.Name = "txtTorre";
			this.txtTorre.Size = new System.Drawing.Size(272, 20);
			this.txtTorre.TabIndex = 104;
			this.txtTorre.Text = "";
			// 
			// txtSector
			// 
			this.txtSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtSector.Location = new System.Drawing.Point(120, 162);
			this.txtSector.Name = "txtSector";
			this.txtSector.Size = new System.Drawing.Size(272, 20);
			this.txtSector.TabIndex = 102;
			this.txtSector.Text = "";
			// 
			// txtNumero
			// 
			this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumero.Location = new System.Drawing.Point(120, 52);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(272, 20);
			this.txtNumero.TabIndex = 97;
			this.txtNumero.Text = "";
			// 
			// txtCalle
			// 
			this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCalle.Location = new System.Drawing.Point(120, 30);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(272, 20);
			this.txtCalle.TabIndex = 94;
			this.txtCalle.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 74);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 20);
			this.label14.TabIndex = 113;
			this.label14.Text = "Teléfonos:";
			// 
			// mzCmbTiposDeDomicilios
			// 
			this.mzCmbTiposDeDomicilios.AutoComplete = true;
			this.mzCmbTiposDeDomicilios.DataSource = null;
			this.mzCmbTiposDeDomicilios.DisplayMember = "";
			this.mzCmbTiposDeDomicilios.DisplayMemberCaption = "";
			this.mzCmbTiposDeDomicilios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposDeDomicilios.Location = new System.Drawing.Point(120, 8);
			this.mzCmbTiposDeDomicilios.MaxItemsDisplay = 7;
			this.mzCmbTiposDeDomicilios.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposDeDomicilios.Name = "mzCmbTiposDeDomicilios";
			this.mzCmbTiposDeDomicilios.Size = new System.Drawing.Size(272, 21);
			this.mzCmbTiposDeDomicilios.SorterMember = "";
			this.mzCmbTiposDeDomicilios.TabIndex = 92;
			this.mzCmbTiposDeDomicilios.ValueMember = "";
			this.mzCmbTiposDeDomicilios.ValueMemberCaption = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(8, 272);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 20);
			this.label10.TabIndex = 109;
			this.label10.Text = "Código Postal:";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 140);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 21);
			this.label9.TabIndex = 107;
			this.label9.Text = "Localidad:";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 250);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 20);
			this.label8.TabIndex = 105;
			this.label8.Text = "Manzana:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 20);
			this.label7.TabIndex = 103;
			this.label7.Text = "Departamento:";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 101;
			this.label6.Text = "Piso:";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 100;
			this.label5.Text = "Torre:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 98;
			this.label4.Text = "Sector:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 96;
			this.label3.Text = "Número:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 95;
			this.label2.Text = "Calle:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 93;
			this.label1.Text = "Tipo de Domicilio:";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.tbbSeparator2,
																							  this.tbbAceptar,
																							  this.tbbSeparator3,
																							  this.tbbCancelar,
																							  this.tbbSeparator4,
																							  this.tbbGuardar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(736, 28);
			this.toolBarStandar.TabIndex = 50;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 0;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 1;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbAceptar
			// 
			this.tbbAceptar.ImageIndex = 2;
			this.tbbAceptar.Text = "&Aceptar";
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 3;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// tbbSeparator4
			// 
			this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbGuardar
			// 
			this.tbbGuardar.ImageIndex = 4;
			this.tbbGuardar.Text = "&Guardar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 315;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Información";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(736, 438);
			this.ultraExplorerBar1.TabIndex = 51;
			// 
			// FrmAbmDomicilios
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(736, 466);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmDomicilios";
			this.Text = "FrmAbmDomicilios";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCmbPais)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbProvincia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbLocalidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbResponsable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeDomicilios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private AbmDomiciliosController _uiController = null;
		#endregion

		#region Constructores y Destructores
		public FrmAbmDomicilios()
		{
			InitializeComponent();
			_uiController = new AbmDomiciliosController();
		}

		public FrmAbmDomicilios(AbmDomiciliosController controller)
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
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Propiedades

		private string _action;
		public string Action
		{
			get{return _action;}
		}

        #endregion

		#region Eventos y Delegados
		public delegate void DomicilioChanged( object sender, EventArgs args );
		public event DomicilioChanged OnDomicilioChanged;
		#endregion

		#region Inicializadores y Carga
		protected void Build_UI(bool isWorkflow)
		{
			ConfigureInterface(isWorkflow);	
			InitializeData(isWorkflow);
			InitEventHandlers();
			InitDataBindings();			

		}

		private void ConfigureInterface(bool isWorkflow)
		{

			if(isWorkflow)
			{
				tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
				tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

				this.Text = _uiController.LeyendaFormulario;
				labelTarea.Text = _uiController.LeyendaFormulario;	

				tbbAnterior.Text = _uiController.TextoBotonAnterior;
				tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			}
			else
			{
				tbbAnterior.Visible = false;
				tbbSeparator.Visible = false;
				tbbSiguiente.Visible = false;
				tbbSeparator2.Visible = false;
				tbbSeparator4.Visible = false;
				tbbGuardar.Visible = false;

				this.Text = "Modificar y Agregar Domicilios";
				labelTarea.Text = "Modificar y Agregar Domicilios";

			}
			KeyPreview = true;
		}


		private void InitializeData(bool isWorkflow)
		{
			this.mzCmbTiposDeDomicilios.FillFromDataSource(_uiController.TiposDomicilios, _uiController.KeyValueTiposDomicilios, _uiController.KeyListTiposDomicilios, 100, _uiController.KeyListTiposDomicilios);
			this.mzCmbResponsable.FillFromDataSource(_uiController.UsuariosPersonas, _uiController.KeyValueUsuariosPersonas, _uiController.KeyListUsuariosPersonas, 100, _uiController.KeyListUsuariosPersonas);
			this.mzCmbPais.FillFromDataSource(_uiController.Paises, _uiController.KeyValuePaises, _uiController.KeyListPaises, 100, _uiController.KeyListPaises);
			this.mzCmbProvincia.FillFromDataSource(_uiController.Provincias, _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
            this.mzCmbLocalidad.FillFromDataSource(_uiController.Localidades, _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
			mzCmbPais.SelectionChanged += new EventHandler(mzCmbPais_SelectionChanged);
			mzCmbProvincia.SelectionChanged += new EventHandler(mzCmbProvincia_SelectionChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}	
	
		private void InitDataBindings()
		{
			mzCmbTiposDeDomicilios.DataBindings.Add("Value", _uiController.Domicilio, "IdTipoDomicilio");	
	        txtCalle.DataBindings.Add("Text", _uiController.Domicilio, "Calle"); 
			txtNumero.DataBindings.Add("Text", _uiController.Domicilio, "Numero"); 
			txtTelefonos.DataBindings.Add("Text", _uiController.Domicilio, "Telefono"); 
			mzCmbPais.DataBindings.Add("Value", _uiController.Domicilio, "IdPais"); 
			mzCmbProvincia.DataBindings.Add("Value", _uiController.Domicilio, "IdProvincia"); 
			mzCmbLocalidad.DataBindings.Add("Value", _uiController.Domicilio, "IdLocalidad"); 
			txtSector.DataBindings.Add("Text", _uiController.Domicilio, "Sector"); 
			txtTorre.DataBindings.Add("Text", _uiController.Domicilio, "Torre"); 
			txtPiso.DataBindings.Add("Text", _uiController.Domicilio, "Piso"); 
			txtDepartamento.DataBindings.Add("Text", _uiController.Domicilio, "Departamento"); 
			txtManzana.DataBindings.Add("Text", _uiController.Domicilio, "Manzana"); 
			txtCodigoPostal.DataBindings.Add("Text", _uiController.Domicilio, "CodigoPostal"); 
			mzCmbResponsable.DataBindings.Add("Value", _uiController.Domicilio, "IdResponsable");	
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
				this.Build_UI(true);
				base.Show();
				_uiController.RefreshData();
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
		}

		#endregion

		#region Metodos Privados

		private void Aceptar()
		{
			Util.MoveFocus(this.ultraExplorerBarContainerControl2);	
			_uiController.Domicilio.IdLocalidad = (string)mzCmbLocalidad.Value;
			if(OnDomicilioChanged != null)
				OnDomicilioChanged(_uiController.Domicilio, new EventArgs());
			this.CloseForm();
		}

		private void SaveChanges()
		{	
			_uiController.Execute();
		}
		#endregion

		#region Métodos Públicos
		public void ShowForm(string action, DomicilioCuenta domicilioCuenta)
		{
			_action = action;
			_uiController.Domicilio = domicilioCuenta;
			this.Build_UI(false);		
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			base.Show();
		}

		#endregion



		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{	
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: //Anterior
					_uiController.Previous();
					break;
				case 2:	//Siguiente					
					break;
				case 4:	//Aceptar		
					Aceptar();
					break;
				case 6:	//Cancelar					
					CloseForm();
					break;
				case 8:	//Guardar					
					SaveChanges();
					break;
			}						
		}

		private void mzCmbPais_SelectionChanged(object sender, EventArgs e)
		{
			long idPaisSeleccionado = (long)mzCmbPais.Value;
			if(!idPaisSeleccionado.Equals(long.MinValue))
			{
				this.mzCmbProvincia.FillFromDataSource(_uiController.ProvinciasPais(idPaisSeleccionado), _uiController.KeyValueProvincias, _uiController.KeyListProvincias, 100, _uiController.KeyListProvincias);
				if(idPaisSeleccionado != _uiController.Domicilio.IdPais)
				{
					mzCmbProvincia.SelectedIndex = 0;
					_uiController.Domicilio.IdProvincia = (long)mzCmbProvincia.Value;
				}
			}
		}

		private void mzCmbProvincia_SelectionChanged(object sender, EventArgs e)
		{
			long idProvSeleccionada = (long)mzCmbProvincia.Value;
			if(!idProvSeleccionada.Equals(long.MinValue))
			{
				this.mzCmbLocalidad.FillFromDataSource(_uiController.LocalidadesProvincia(idProvSeleccionada), _uiController.KeyValueLocalidades, _uiController.KeyListLocalidades, 100, _uiController.KeyListLocalidades);
				if(idProvSeleccionada != _uiController.Domicilio.IdProvincia)
				{
					mzCmbLocalidad.SelectedIndex = 0;
					_uiController.Domicilio.IdLocalidad = (string)mzCmbLocalidad.Value;
				}
			}
		}

	}
}

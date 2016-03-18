using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using mz.erp.businessrules;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de frmAbmArticulos.
	/// </summary>
	public class FrmAbmArticulos : System.Windows.Forms.Form
	{
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uchkActivo;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCodigoSecundario;
		private System.Windows.Forms.TextBox txtCodigo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unedUnidadesPorPack;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unedAlicuotaIva;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unedPrecioVenta;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uchkObligatorioNumeroDeSerie;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uchkObligatorioCodigoBarras;
		private System.Windows.Forms.TextBox txtDescripcionCorta;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar uEBPanel;
		private Infragistics.Win.Misc.UltraButton bNuevo;
		private System.Windows.Forms.Button bAceptar;
		private System.Windows.Forms.Button bCancelar;
		private System.Windows.Forms.Button bBuscar;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Button bEliminar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbFirstRecord;
		private System.Windows.Forms.ToolBarButton tbPreviousRecord;
		private System.Windows.Forms.ToolBarButton tbNextRecord;
		private System.Windows.Forms.ToolBarButton tbLastRecord;
		private System.Windows.Forms.ToolBarButton tbSep1;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSep2;
		private System.Windows.Forms.ToolBarButton tbSave;
		private System.ComponentModel.IContainer components;

		public FrmAbmArticulos()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			this.Refresh();
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
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmArticulos));
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uchkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.txtDescripcionCorta = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCodigoSecundario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.unedUnidadesPorPack = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.unedAlicuotaIva = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label6 = new System.Windows.Forms.Label();
			this.unedPrecioVenta = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uchkObligatorioNumeroDeSerie = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.uchkObligatorioCodigoBarras = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.uEBPanel = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.bNuevo = new Infragistics.Win.Misc.UltraButton();
			this.bCancelar = new System.Windows.Forms.Button();
			this.bAceptar = new System.Windows.Forms.Button();
			this.bBuscar = new System.Windows.Forms.Button();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.bEliminar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbFirstRecord = new System.Windows.Forms.ToolBarButton();
			this.tbPreviousRecord = new System.Windows.Forms.ToolBarButton();
			this.tbNextRecord = new System.Windows.Forms.ToolBarButton();
			this.tbLastRecord = new System.Windows.Forms.ToolBarButton();
			this.tbSep1 = new System.Windows.Forms.ToolBarButton();
			this.tbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbSep2 = new System.Windows.Forms.ToolBarButton();
			this.tbSave = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.unedUnidadesPorPack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unedAlicuotaIva)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unedPrecioVenta)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uEBPanel)).BeginInit();
			this.uEBPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uchkActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcionCorta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCodigoSecundario);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCodigo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(19, 44);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(682, 109);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// uchkActivo
			// 
			this.uchkActivo.BackColor = System.Drawing.Color.Transparent;
			this.uchkActivo.Location = new System.Drawing.Point(496, 8);
			this.uchkActivo.Name = "uchkActivo";
			this.uchkActivo.Size = new System.Drawing.Size(88, 20);
			this.uchkActivo.TabIndex = 8;
			this.uchkActivo.Text = "Activo";
			// 
			// txtDescripcionCorta
			// 
			this.txtDescripcionCorta.Location = new System.Drawing.Point(126, 82);
			this.txtDescripcionCorta.Name = "txtDescripcionCorta";
			this.txtDescripcionCorta.Size = new System.Drawing.Size(338, 20);
			this.txtDescripcionCorta.TabIndex = 7;
			this.txtDescripcionCorta.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(15, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Descripción Corta";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(126, 56);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(338, 20);
			this.txtDescripcion.TabIndex = 5;
			this.txtDescripcion.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Descripción";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigoSecundario
			// 
			this.txtCodigoSecundario.Location = new System.Drawing.Point(126, 32);
			this.txtCodigoSecundario.Name = "txtCodigoSecundario";
			this.txtCodigoSecundario.Size = new System.Drawing.Size(338, 20);
			this.txtCodigoSecundario.TabIndex = 3;
			this.txtCodigoSecundario.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(4, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Código Secundario";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(126, 7);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.TabIndex = 1;
			this.txtCodigo.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.unedUnidadesPorPack);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.unedAlicuotaIva);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.unedPrecioVenta);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(19, 199);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(682, 61);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// unedUnidadesPorPack
			// 
			this.unedUnidadesPorPack.FormatString = "";
			this.unedUnidadesPorPack.Location = new System.Drawing.Point(392, 6);
			this.unedUnidadesPorPack.MaskInput = "nnnnnn";
			this.unedUnidadesPorPack.MaxValue = 9999999;
			this.unedUnidadesPorPack.MinValue = 0;
			this.unedUnidadesPorPack.Name = "unedUnidadesPorPack";
			this.unedUnidadesPorPack.Size = new System.Drawing.Size(100, 21);
			this.unedUnidadesPorPack.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(280, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 7;
			this.label7.Text = "Unidades por Pack";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// unedAlicuotaIva
			// 
			this.unedAlicuotaIva.FormatString = "";
			this.unedAlicuotaIva.Location = new System.Drawing.Point(117, 32);
			this.unedAlicuotaIva.MaskInput = "nnn,nn";
			this.unedAlicuotaIva.MaxValue = 100;
			this.unedAlicuotaIva.MinValue = 0;
			this.unedAlicuotaIva.Name = "unedAlicuotaIva";
			this.unedAlicuotaIva.Size = new System.Drawing.Size(100, 21);
			this.unedAlicuotaIva.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(5, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Alicuota de Iva";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// unedPrecioVenta
			// 
			this.unedPrecioVenta.FormatString = "";
			this.unedPrecioVenta.Location = new System.Drawing.Point(117, 5);
			this.unedPrecioVenta.MaskInput = "nnnnnn,nn";
			this.unedPrecioVenta.MinValue = 0;
			this.unedPrecioVenta.Name = "unedPrecioVenta";
			this.unedPrecioVenta.Size = new System.Drawing.Size(100, 21);
			this.unedPrecioVenta.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 7);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Precio de Venta";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uchkObligatorioNumeroDeSerie);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uchkObligatorioCodigoBarras);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(19, 306);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(682, 62);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// uchkObligatorioNumeroDeSerie
			// 
			this.uchkObligatorioNumeroDeSerie.BackColor = System.Drawing.Color.Transparent;
			this.uchkObligatorioNumeroDeSerie.Location = new System.Drawing.Point(48, 32);
			this.uchkObligatorioNumeroDeSerie.Name = "uchkObligatorioNumeroDeSerie";
			this.uchkObligatorioNumeroDeSerie.Size = new System.Drawing.Size(272, 20);
			this.uchkObligatorioNumeroDeSerie.TabIndex = 1;
			this.uchkObligatorioNumeroDeSerie.Text = "Obligatorio Número de Serie";
			// 
			// uchkObligatorioCodigoBarras
			// 
			this.uchkObligatorioCodigoBarras.BackColor = System.Drawing.Color.Transparent;
			this.uchkObligatorioCodigoBarras.Location = new System.Drawing.Point(48, 3);
			this.uchkObligatorioCodigoBarras.Name = "uchkObligatorioCodigoBarras";
			this.uchkObligatorioCodigoBarras.Size = new System.Drawing.Size(208, 20);
			this.uchkObligatorioCodigoBarras.TabIndex = 0;
			this.uchkObligatorioCodigoBarras.Text = "Obligatorio Código de Barras";
			// 
			// uEBPanel
			// 
			this.uEBPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.uEBPanel.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.uEBPanel.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.uEBPanel.Controls.Add(this.ultraExplorerBarContainerControl3);
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 111;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 63;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos de Venta y Presentación";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 64;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Avanzadas";
			this.uEBPanel.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																											   ultraExplorerBarGroup1,
																											   ultraExplorerBarGroup2,
																											   ultraExplorerBarGroup3});
			this.uEBPanel.Location = new System.Drawing.Point(16, 40);
			this.uEBPanel.Name = "uEBPanel";
			this.uEBPanel.Size = new System.Drawing.Size(720, 392);
			this.uEBPanel.TabIndex = 0;
			this.uEBPanel.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.XP;
			// 
			// bNuevo
			// 
			this.bNuevo.Location = new System.Drawing.Point(16, 8);
			this.bNuevo.Name = "bNuevo";
			this.bNuevo.TabIndex = 1;
			this.bNuevo.Text = "Nuevo";
			this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
			// 
			// bCancelar
			// 
			this.bCancelar.Location = new System.Drawing.Point(664, 440);
			this.bCancelar.Name = "bCancelar";
			this.bCancelar.TabIndex = 5;
			this.bCancelar.Text = "&Cancelar";
			this.bCancelar.Click += new System.EventHandler(this.button2_Click);
			// 
			// bAceptar
			// 
			this.bAceptar.Location = new System.Drawing.Point(576, 440);
			this.bAceptar.Name = "bAceptar";
			this.bAceptar.TabIndex = 4;
			this.bAceptar.Text = "Aceptar";
			this.bAceptar.Click += new System.EventHandler(this.ultraButton1_Click);
			// 
			// bBuscar
			// 
			this.bBuscar.Location = new System.Drawing.Point(104, 8);
			this.bBuscar.Name = "bBuscar";
			this.bBuscar.TabIndex = 6;
			this.bBuscar.Text = "Buscar";
			this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(187, 10);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.TabIndex = 7;
			this.txtBusqueda.Text = "";
			// 
			// bEliminar
			// 
			this.bEliminar.Location = new System.Drawing.Point(300, 9);
			this.bEliminar.Name = "bEliminar";
			this.bEliminar.TabIndex = 8;
			this.bEliminar.Text = "Eliminar";
			this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(440, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 9;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.onClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(528, 8);
			this.button2.Name = "button2";
			this.button2.TabIndex = 10;
			this.button2.Text = "button2";
			this.button2.Click += new System.EventHandler(this.onClick);
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
																							  this.tbFirstRecord,
																							  this.tbPreviousRecord,
																							  this.tbNextRecord,
																							  this.tbLastRecord,
																							  this.tbSep1,
																							  this.tbRefresh,
																							  this.tbSep2,
																							  this.tbSave});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(752, 28);
			this.toolBarStandar.TabIndex = 11;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbFirstRecord
			// 
			this.tbFirstRecord.ImageIndex = 0;
			// 
			// tbPreviousRecord
			// 
			this.tbPreviousRecord.ImageIndex = 1;
			// 
			// tbNextRecord
			// 
			this.tbNextRecord.ImageIndex = 2;
			// 
			// tbLastRecord
			// 
			this.tbLastRecord.ImageIndex = 3;
			// 
			// tbSep1
			// 
			this.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbRefresh
			// 
			this.tbRefresh.ImageIndex = 5;
			// 
			// tbSep2
			// 
			this.tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbSave
			// 
			this.tbSave.ImageIndex = 4;
			this.tbSave.Text = "Guardar";
			// 
			// FrmAbmArticulos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(752, 485);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bEliminar);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.bBuscar);
			this.Controls.Add(this.bCancelar);
			this.Controls.Add(this.bAceptar);
			this.Controls.Add(this.bNuevo);
			this.Controls.Add(this.uEBPanel);
			this.Name = "FrmAbmArticulos";
			this.Text = "FrmAbmArticulos";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.unedUnidadesPorPack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unedAlicuotaIva)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unedPrecioVenta)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uEBPanel)).EndInit();
			this.uEBPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Members
		
		public void _Abm( string accion )
		{
			switch ( accion.ToUpper())
			{
				case "A": //Alta de nuevo item
					row = businessrules.tsh_Productos.NewRow();
					_LoadControls( "C", row );
					break;
				case "B": //Eliminación del current item
					_LoadControls( "L", row );
					row.Delete();
					break;
				case "M": //Modificacion del current item
					break;
			}



		}
		
		
		/// <summary>
		/// Inicializa los controles visuales del formulario
		/// </summary>
		/// <param name="accion"></param> Puede tomar los valores I: Initialize, L: Load
		/// <param name="row"></param> Fila de tipo tsh_ProductosDataset.tsh_ProductosRow
		public void _LoadControls( string accion, tsh_ProductosDataset.tsh_ProductosRow row )
		{
			switch ( accion.ToUpper() )
			{
				case "I":
					txtCodigo.Text = "";
					txtCodigoSecundario.Text = "";
					txtDescripcion.Text = "";
					txtDescripcionCorta.Text = "";
					uchkActivo.Checked = false;
					unedPrecioVenta.Value = 0;
					unedAlicuotaIva.Value = 0;
					unedUnidadesPorPack.Value = 0;
					uchkObligatorioCodigoBarras.Checked = false;
					uchkObligatorioNumeroDeSerie.Checked = false;
					uEBPanel.Enabled=false;
					break;
				default:
					txtCodigo.Text = row.Codigo;
					txtCodigoSecundario.Text = row.CodigoSecundario;
					txtDescripcion.Text = row.Descripcion;
					txtDescripcionCorta.Text = row.DescripcionCorta;
					uchkActivo.Checked = row.Activo;
					unedPrecioVenta.Value = row.PrecioBaseVenta;
					unedAlicuotaIva.Value = row.AlicuotaIva;
					unedUnidadesPorPack.Value = row.UnidadesPorPack;
					uchkObligatorioCodigoBarras.Checked = row.ObligaCodigoBarra;
					uchkObligatorioNumeroDeSerie.Checked = row.ObligaNumeroSerie;					
					break;
			}
				
		}


		public override void  Refresh()
		{
			LoadControls( "A",-1);
			uEBPanel.Enabled = false;
		}

		tsh_ProductosDataset.tsh_ProductosRow row;
		protected void Acciones( string accion )
		{
			switch ( accion.ToUpper() )
			{
				case "NUEVO":
					LoadControls( "A",-1);
					break;
				case "MODIFICAR":
					break;
				case "ACEPTAR":
					ValidAndSave( );
					break;
				case "CANCELAR":
					LoadControls( "X",-1);
					break;
				case "BUSCAR":
					Find ( txtBusqueda.Text );
					break;
				case "ELIMINAR":
					DialogResult result;
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					result = MessageBox.Show(this,"¿Desea eliminar completamente este item de la base de datos?","Pregunta",buttons,
						MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
								

  
					if(result == DialogResult.Yes)
					{
						row.Delete();
						DeleteAndSave( );
					}
					break;
			}
		
		}

		protected void Find( string clave )
		{
			row = mz.erp.businessrules.tsh_Productos.GetByUk( "CODIGO",clave);
			if (row != null)
				LoadControls("M", row.IdProducto);	
			else
				MessageBox.Show("No encontrado");
		}
		protected void DeleteAndSave( )
		{
			System.Collections.ArrayList mensajes = new System.Collections.ArrayList();
			row.Delete();
			businessrules.tsh_Productos.Update( row );
			/*if (false)
			{
				MessageBox.Show( "No se han podido almancenar los cambios!","Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				this.Refresh();
			}
			else
			{*/
				MessageBox.Show( "Los cambios se han introducido con éxito!","Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				this.Refresh();
		/*	}*/

		}

		protected void ValidAndSave()
		{
			System.Collections.ArrayList mensajes = new System.Collections.ArrayList();
			row.Codigo = txtCodigo.Text;
			row.CodigoSecundario = txtCodigoSecundario.Text;
			row.Descripcion = txtDescripcion.Text;
			row.DescripcionCorta = txtDescripcionCorta.Text;
			row.Activo = uchkActivo.Checked;
			row.PrecioBaseVenta = Convert.ToDecimal(unedPrecioVenta.Value);
			row.AlicuotaIva = Convert.ToDecimal(unedAlicuotaIva.Value);
			row.UnidadesPorPack = Convert.ToDecimal(unedUnidadesPorPack.Value);
			row.ObligaCodigoBarra = uchkObligatorioCodigoBarras.Checked;
			row.ObligaNumeroSerie = uchkObligatorioNumeroDeSerie.Checked;
			businessrules.tsh_Productos.UpdateWithValidation( row );
		

			/*
				if (mensajes.Count > 0) 
				{
					FrmMostrarErrores _frmErrores = new FrmMostrarErrores( mensajes );
					_frmErrores.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show( "Los cambios se han introducido con éxito!","Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				this.Refresh();
			}*/

		}

		protected void LoadControls( string movimiento, long  id )
		{
			switch ( movimiento.ToString() )
			{
				case "A":
					row = businessrules.tsh_Productos.NewRow();
					uEBPanel.Enabled=true;
					break;
				case "B":
					row = businessrules.tsh_Productos.NewRow();
					uEBPanel.Enabled=false;
					break;
				case "M":
					uEBPanel.Enabled=true;
					break;
				case "X":
					uEBPanel.Enabled=true;
					break;
				default :
					row = null;
					uEBPanel.Enabled=false;
					break;
			}

			txtCodigo.Text = row.Codigo;
			txtCodigoSecundario.Text = row.CodigoSecundario;
			txtDescripcion.Text = row.Descripcion;
			txtDescripcionCorta.Text = row.DescripcionCorta;
			uchkActivo.Checked = row.Activo;
			unedPrecioVenta.Value = row.PrecioBaseVenta;
			unedAlicuotaIva.Value = row.AlicuotaIva;
			unedUnidadesPorPack.Value = row.UnidadesPorPack;
			uchkObligatorioCodigoBarras.Checked = row.ObligaCodigoBarra;
			uchkObligatorioNumeroDeSerie.Checked = row.ObligaNumeroSerie;

		}

		#endregion

		private void ultraButton1_Click(object sender, System.EventArgs e)
		{
			Acciones("ACEPTAR");
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Acciones("CANCELAR");
		}

		private void bNuevo_Click(object sender, System.EventArgs e)
		{
			Acciones("NUEVO");
		}

		private void bBuscar_Click(object sender, System.EventArgs e)
		{
			Acciones("BUSCAR");
		}

		private void bEliminar_Click(object sender, System.EventArgs e)
		{
			Acciones("ELIMINAR");
		}

		private void onClick(object sender, System.EventArgs e)
		{
			if ( sender is Button )
			{
				//switch ( ( Button )sender ).Name
				{
					
				}

			}
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			
		}

	}
}

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mz.erp.commontypes.data;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.commontypes;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controls;
using System.Data;
//using mz.erp.businessrules.Comprobantes_de_Compra;

namespace mz.erp.ui.forms
{
	public class FrmComprobantesABMProductos : mz.erp.ui.forms.FrmAltaRow
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbProductos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCantidad;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioDeLista;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacionProducto;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneBonificacionProductoPorcentaje;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtDescripcion;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.TextBox txtDescripcionLarga;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private Janus.Windows.GridEX.GridEX gridElementosAsociados;
		private System.Windows.Forms.Button bAgregar;
		private System.Windows.Forms.Button bQuitar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.GroupBox groupBox2;
		private Janus.Windows.GridEX.GridEX gridImpuestos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtVisualizacion;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private Janus.Windows.GridEX.GridEX gridStock;
		private System.Windows.Forms.Label label8;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneStockPropio;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneStock;
		private System.Windows.Forms.Label labelConversion;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioFinal;
		private System.Windows.Forms.Label label20;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCantidadDestino;
		private System.Windows.Forms.Label labelUnidadOrigen;
		private System.Windows.Forms.Label labelUnidadDestino;
		private mz.erp.ui.controls.mzComboEditor mzComboListaDePrecios;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components = null;

		public FrmComprobantesABMProductos()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			this.tbbPedidos.Visible = true;

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

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmComprobantesABMProductos));
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.uneStock = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label8 = new System.Windows.Forms.Label();
			this.gridStock = new Janus.Windows.GridEX.GridEX();
			this.uneStockPropio = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtVisualizacion = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gridImpuestos = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.bQuitar = new System.Windows.Forms.Button();
			this.bAgregar = new System.Windows.Forms.Button();
			this.gridElementosAsociados = new Janus.Windows.GridEX.GridEX();
			this.label19 = new System.Windows.Forms.Label();
			this.txtDescripcionLarga = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.uneCantidad = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.unePrecioDeLista = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneBonificacionProducto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneBonificacionProductoPorcentaje = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.labelUnidadOrigen = new System.Windows.Forms.Label();
			this.labelConversion = new System.Windows.Forms.Label();
			this.unePrecioFinal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label20 = new System.Windows.Forms.Label();
			this.uneCantidadDestino = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.labelUnidadDestino = new System.Windows.Forms.Label();
			this.mzComboListaDePrecios = new mz.erp.ui.controls.mzComboEditor();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneStockPropio)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridElementosAsociados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeLista)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionProducto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionProductoPorcentaje)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioFinal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidadDestino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 288;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Información adicional";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 184;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Especificaciones del item";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(872, 490);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl3, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzComboListaDePrecios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelUnidadDestino);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneCantidadDestino);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label20);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.unePrecioFinal);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelConversion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelUnidadOrigen);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label17);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneBonificacionProductoPorcentaje);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneBonificacionProducto);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.unePrecioDeLista);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneCantidad);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -158);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(806, 151);
			this.ultraExplorerBarContainerControl1.TabStop = false;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Name = "toolBarStandar";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.groupBox1);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.groupBox2);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, -66);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(806, 288);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.uneStock);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.gridStock);
			this.groupBox1.Controls.Add(this.uneStockPropio);
			this.groupBox1.Controls.Add(this.txtEstado);
			this.groupBox1.Controls.Add(this.txtVisualizacion);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 280);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Stock";
			// 
			// uneStock
			// 
			this.uneStock.Location = new System.Drawing.Point(328, 64);
			this.uneStock.MaskInput = "-nnnnnnnnn.nn";
			this.uneStock.MinValue = -2147483647;
			this.uneStock.Name = "uneStock";
			this.uneStock.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneStock.PromptChar = ' ';
			this.uneStock.Size = new System.Drawing.Size(104, 21);
			this.uneStock.TabIndex = 3;
			this.uneStock.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneStock.Value = 1;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(232, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 24);
			this.label8.TabIndex = 13;
			this.label8.Text = "Stock consolidado";
			// 
			// gridStock
			// 
			this.gridStock.AllowColumnDrag = false;
			this.gridStock.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridStock.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridStock.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridStock.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridStock.GroupByBoxInfoText = "uu";
			this.gridStock.GroupByBoxVisible = false;
			this.gridStock.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridStock.Location = new System.Drawing.Point(16, 96);
			this.gridStock.Name = "gridStock";
			this.gridStock.Size = new System.Drawing.Size(416, 168);
			this.gridStock.TabIndex = 4;
			// 
			// uneStockPropio
			// 
			this.uneStockPropio.FormatString = "";
			this.uneStockPropio.Location = new System.Drawing.Point(120, 64);
			this.uneStockPropio.MaskInput = "-nnnnnnnnn.nn";
			this.uneStockPropio.MinValue = -2147483647;
			this.uneStockPropio.Name = "uneStockPropio";
			this.uneStockPropio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneStockPropio.PromptChar = ' ';
			this.uneStockPropio.Size = new System.Drawing.Size(100, 21);
			this.uneStockPropio.TabIndex = 2;
			this.uneStockPropio.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneStockPropio.Value = 1;
			// 
			// txtEstado
			// 
			this.txtEstado.BackColor = System.Drawing.Color.White;
			this.txtEstado.Location = new System.Drawing.Point(120, 40);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.ReadOnly = true;
			this.txtEstado.Size = new System.Drawing.Size(312, 20);
			this.txtEstado.TabIndex = 1;
			this.txtEstado.Text = "txtEstado";
			// 
			// txtVisualizacion
			// 
			this.txtVisualizacion.BackColor = System.Drawing.Color.White;
			this.txtVisualizacion.Location = new System.Drawing.Point(120, 16);
			this.txtVisualizacion.Name = "txtVisualizacion";
			this.txtVisualizacion.ReadOnly = true;
			this.txtVisualizacion.Size = new System.Drawing.Size(312, 20);
			this.txtVisualizacion.TabIndex = 0;
			this.txtVisualizacion.Text = "txtVisualizacion";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(96, 20);
			this.label14.TabIndex = 2;
			this.label14.Text = "Estado de stock";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 18);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 20);
			this.label15.TabIndex = 1;
			this.label15.Text = "Visualización de stock";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 65);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(112, 20);
			this.label16.TabIndex = 0;
			this.label16.Text = "Stock";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.gridImpuestos);
			this.groupBox2.Location = new System.Drawing.Point(464, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(336, 280);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Impuestos aplicables";
			// 
			// gridImpuestos
			// 
			this.gridImpuestos.AllowColumnDrag = false;
			this.gridImpuestos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridImpuestos.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridImpuestos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridImpuestos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridImpuestos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridImpuestos.Location = new System.Drawing.Point(16, 24);
			this.gridImpuestos.Name = "gridImpuestos";
			this.gridImpuestos.Size = new System.Drawing.Size(304, 240);
			this.gridImpuestos.TabIndex = 5;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.bQuitar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.bAgregar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridElementosAsociados);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label19);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtDescripcionLarga);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label18);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 281);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(806, 184);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// bQuitar
			// 
			this.bQuitar.Location = new System.Drawing.Point(470, 123);
			this.bQuitar.Name = "bQuitar";
			this.bQuitar.Size = new System.Drawing.Size(77, 23);
			this.bQuitar.TabIndex = 3;
			this.bQuitar.Text = "Quitar";
			// 
			// bAgregar
			// 
			this.bAgregar.Location = new System.Drawing.Point(470, 97);
			this.bAgregar.Name = "bAgregar";
			this.bAgregar.Size = new System.Drawing.Size(77, 23);
			this.bAgregar.TabIndex = 2;
			this.bAgregar.Text = "Agregar";
			// 
			// gridElementosAsociados
			// 
			this.gridElementosAsociados.AllowColumnDrag = false;
			this.gridElementosAsociados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridElementosAsociados.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridElementosAsociados.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridElementosAsociados.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridElementosAsociados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridElementosAsociados.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridElementosAsociados.Location = new System.Drawing.Point(134, 95);
			this.gridElementosAsociados.Name = "gridElementosAsociados";
			this.gridElementosAsociados.Size = new System.Drawing.Size(327, 79);
			this.gridElementosAsociados.TabIndex = 1;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(6, 96);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(114, 17);
			this.label19.TabIndex = 33;
			this.label19.Text = "Elementos asociados";
			// 
			// txtDescripcionLarga
			// 
			this.txtDescripcionLarga.Location = new System.Drawing.Point(134, 7);
			this.txtDescripcionLarga.Multiline = true;
			this.txtDescripcionLarga.Name = "txtDescripcionLarga";
			this.txtDescripcionLarga.Size = new System.Drawing.Size(637, 80);
			this.txtDescripcionLarga.TabIndex = 0;
			this.txtDescripcionLarga.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(6, 10);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(99, 15);
			this.label18.TabIndex = 31;
			this.label18.Text = "Descripción Larga";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Producto";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(10, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Cantidad";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(10, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Precio de Lista";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(10, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Rec/Bon al Producto";
			// 
			// uneCantidad
			// 
			this.uneCantidad.Location = new System.Drawing.Point(136, 56);
			this.uneCantidad.MinValue = 0;
			this.uneCantidad.Name = "uneCantidad";
			this.uneCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneCantidad.Size = new System.Drawing.Size(100, 21);
			this.uneCantidad.TabIndex = 2;
			this.uneCantidad.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneCantidad.Value = 1;
			// 
			// unePrecioDeLista
			// 
			this.unePrecioDeLista.Location = new System.Drawing.Point(136, 80);
			this.unePrecioDeLista.MaskInput = "nnnnnnn.nnnn";
			this.unePrecioDeLista.MinValue = 0;
			this.unePrecioDeLista.Name = "unePrecioDeLista";
			this.unePrecioDeLista.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioDeLista.Size = new System.Drawing.Size(100, 21);
			this.unePrecioDeLista.TabIndex = 3;
			this.unePrecioDeLista.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// uneBonificacionProducto
			// 
			this.uneBonificacionProducto.Location = new System.Drawing.Point(136, 104);
			this.uneBonificacionProducto.MaskInput = "nnnnnnn.nnnn";
			this.uneBonificacionProducto.MinValue = 0;
			this.uneBonificacionProducto.Name = "uneBonificacionProducto";
			this.uneBonificacionProducto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneBonificacionProducto.Size = new System.Drawing.Size(100, 21);
			this.uneBonificacionProducto.TabIndex = 4;
			this.uneBonificacionProducto.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// uneBonificacionProductoPorcentaje
			// 
			this.uneBonificacionProductoPorcentaje.Location = new System.Drawing.Point(240, 104);
			this.uneBonificacionProductoPorcentaje.MaskInput = "nnn.nn";
			this.uneBonificacionProductoPorcentaje.MaxValue = 100;
			this.uneBonificacionProductoPorcentaje.MinValue = 0;
			this.uneBonificacionProductoPorcentaje.Name = "uneBonificacionProductoPorcentaje";
			this.uneBonificacionProductoPorcentaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneBonificacionProductoPorcentaje.Size = new System.Drawing.Size(48, 21);
			this.uneBonificacionProductoPorcentaje.TabIndex = 5;
			this.uneBonificacionProductoPorcentaje.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(296, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "%";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(10, 35);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(88, 16);
			this.label17.TabIndex = 29;
			this.label17.Text = "Descripción";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(136, 32);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(637, 20);
			this.txtDescripcion.TabIndex = 1;
			this.txtDescripcion.Text = "";
			// 
			// labelUnidadOrigen
			// 
			this.labelUnidadOrigen.BackColor = System.Drawing.Color.Transparent;
			this.labelUnidadOrigen.Location = new System.Drawing.Point(238, 60);
			this.labelUnidadOrigen.Name = "labelUnidadOrigen";
			this.labelUnidadOrigen.Size = new System.Drawing.Size(74, 16);
			this.labelUnidadOrigen.TabIndex = 30;
			this.labelUnidadOrigen.Text = "Unidad";
			// 
			// labelConversion
			// 
			this.labelConversion.AutoSize = true;
			this.labelConversion.BackColor = System.Drawing.Color.Transparent;
			this.labelConversion.Location = new System.Drawing.Point(520, 58);
			this.labelConversion.Name = "labelConversion";
			this.labelConversion.Size = new System.Drawing.Size(62, 16);
			this.labelConversion.TabIndex = 31;
			this.labelConversion.Text = "Conversion";
			// 
			// unePrecioFinal
			// 
			this.unePrecioFinal.Location = new System.Drawing.Point(136, 128);
			this.unePrecioFinal.MaskInput = "nnnnnnn.nnnn";
			this.unePrecioFinal.MinValue = 0;
			this.unePrecioFinal.Name = "unePrecioFinal";
			this.unePrecioFinal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.unePrecioFinal.Size = new System.Drawing.Size(100, 21);
			this.unePrecioFinal.TabIndex = 6;
			this.unePrecioFinal.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(10, 128);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(112, 16);
			this.label20.TabIndex = 33;
			this.label20.Text = "Pcio Final Imp Inc";
			// 
			// uneCantidadDestino
			// 
			this.uneCantidadDestino.Location = new System.Drawing.Point(320, 56);
			this.uneCantidadDestino.MinValue = 0;
			this.uneCantidadDestino.Name = "uneCantidadDestino";
			this.uneCantidadDestino.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneCantidadDestino.Size = new System.Drawing.Size(100, 21);
			this.uneCantidadDestino.TabIndex = 7;
			this.uneCantidadDestino.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.uneCantidadDestino.Value = 1;
			// 
			// labelUnidadDestino
			// 
			this.labelUnidadDestino.BackColor = System.Drawing.Color.Transparent;
			this.labelUnidadDestino.Location = new System.Drawing.Point(420, 58);
			this.labelUnidadDestino.Name = "labelUnidadDestino";
			this.labelUnidadDestino.Size = new System.Drawing.Size(88, 16);
			this.labelUnidadDestino.TabIndex = 35;
			this.labelUnidadDestino.Text = "Unidad";
			// 
			// mzComboListaDePrecios
			// 
			this.mzComboListaDePrecios.AutoComplete = true;
			this.mzComboListaDePrecios.DataSource = null;
			this.mzComboListaDePrecios.DisplayMember = "";
			this.mzComboListaDePrecios.DisplayMemberCaption = "";
			this.mzComboListaDePrecios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzComboListaDePrecios.Location = new System.Drawing.Point(592, 88);
			this.mzComboListaDePrecios.MaxItemsDisplay = 7;
			this.mzComboListaDePrecios.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzComboListaDePrecios.Name = "mzComboListaDePrecios";
			this.mzComboListaDePrecios.Size = new System.Drawing.Size(168, 21);
			this.mzComboListaDePrecios.SorterMember = "";
			this.mzComboListaDePrecios.TabIndex = 8;
			this.mzComboListaDePrecios.ValueMember = "";
			this.mzComboListaDePrecios.ValueMemberCaption = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(488, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 1815;
			this.label3.Text = "Lista de Precios";
			// 
			// FrmComprobantesABMProductos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(872, 518);
			this.Name = "FrmComprobantesABMProductos";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneStockPropio)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridElementosAsociados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioDeLista)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionProducto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneBonificacionProductoPorcentaje)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unePrecioFinal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidadDestino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Members
		private bool _listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios"); 
        private string _idListaDePreciosDefault = string.Empty;
		protected override void Init()
		{
			tbbPedidos.Visible = Variables.GetValueBool("Compras.Pedidos.Habilitar");
			mzCmbProductos.WidthSearchForm = 920;			
			mzCmbProductos.SearchObject = typeof (mz.erp.ui.forms.classes.tsh_Productos);
			mzCmbProductos.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			uneCantidad.Value = 1;
			txtVisualizacion.Text = String.Empty;
			txtEstado.Text = String.Empty;						
			unePrecioDeLista.ReadOnly = true;
			uneBonificacionProducto.ReadOnly = !Variables.GetValueBool("Comprobantes.Seguridad.Productos.PermiteDescuentos");
			uneBonificacionProductoPorcentaje.ReadOnly = !Variables.GetValueBool("Comprobantes.Seguridad.Productos.PermiteDescuentos");
			labelConversion.Visible = false;
			txtDescripcion.ReadOnly = true; //!Variables.GetValueBool("Comprobante.Seguridad.Productos.PermiteModificarDescripcion");
			if (_sender != null)
			{
				//Obtengo el resto de la informacion del comprobante
				ComprobanteDeVenta comprobante = (ComprobanteDeVenta)_sender;
				txtDescripcionLarga.ReadOnly = !ComprobantesRules.Momentos_Parametros_Bool(comprobante.Momento,"Emision.Editar.DescripcionLarga");
				gridElementosAsociados.Enabled = ComprobantesRules.Momentos_Parametros_Bool( comprobante.Momento, "Emision.Editar.ElementosAsociados" );
				unePrecioDeLista.ReadOnly = !ComprobantesRules.Momentos_Parametros_Bool( comprobante.Momento,"Emision.Editar.PrecioDeLista");
				this.ultraExplorerBar1.Groups[2].Visible = Variables.GetValueBool("Comprobantes.Objetos.DefinicionActiva");
			}
			else
			{
				txtDescripcionLarga.ReadOnly = true;
				gridElementosAsociados.Enabled = false;
				unePrecioDeLista.ReadOnly = true;
				this.ultraExplorerBar1.Groups[2].Visible = false;				
			}

			DataTable listaDePreciosTable = businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
			DataTable _listaDePrecios = VariablesListComparer.FilterDataTable(this.Name + ".ListasDePrecios", "IdListaDePrecio", listaDePreciosTable);
			mzComboListaDePrecios.FillFromDataSource( _listaDePrecios, "IdListaDePrecio", "Descripcion", 100, "Descripcion");
            _idListaDePreciosDefault = Variables.GetValueString(this.Name + ".ListaDePreciosDefault");
			if(_idListaDePreciosDefault.Equals(string.Empty))
				_idListaDePreciosDefault = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
			mzComboListaDePrecios.Value = _idListaDePreciosDefault;			
			this.mzComboListaDePrecios.Enabled = _listaDePreciosHabilitadas;

		}

		private void RefreshControls()
		{
			gridImpuestos.Refetch();
			//gridStock.SetDataBinding( null, null);
			//gridStock.SetDataBinding( businessrules.tlg_Stock.GetStockSucursales(miProducto.IdProducto, "3"), null);
			//gridStock.Refetch();
		}

		private Productos miProducto;
		private ItemComprobante miItemComprobante = null;
		private void FillItemComprobante()
		{
			if (_sender != null )
			{
				//Obtengo el resto de la informacion del comprobante
				ComprobanteDeVenta comprobante = (ComprobanteDeVenta)_sender;
				//Obtengo información del producto
				string CodigoProducto = ( (string)mzCmbProductos.DataValue );
				string IdListaDePrecios = (string)mzComboListaDePrecios.Value;
				miProducto = null;
				if ((CodigoProducto != null) && (CodigoProducto.CompareTo(string.Empty) != 0))
				{
					miProducto = new mz.erp.businessrules.Productos( "CODIGO", CodigoProducto, IdListaDePrecios, _idListaDePreciosDefault,_listaDePreciosHabilitadas, false);
					if ((miProducto == null || miProducto.Codigo == null || miProducto.Codigo.CompareTo(string.Empty) == 0))
					{
						MessageBox.Show("El producto no existe o no está habilitado");
					}
					else
					{
						Item _miItem = new mz.erp.businessrules.comprobantes.Item(miProducto);
						_miItem.SetConversion(comprobante.Momento);
						miItemComprobante = new ItemComprobante( "NEW", comprobante.Items, _miItem );
						/*unePrecio.DataBindings.Clear();
						unePrecio.DataBindings.Add( "Value", miItemComprobante, "Precio" );*/
						unePrecioDeLista.DataBindings.Clear();
						unePrecioDeLista.DataBindings.Add( "Value",miItemComprobante, "PrecioDeVentaBruto");
						uneBonificacionProducto.DataBindings.Clear();
						uneBonificacionProducto.DataBindings.Add( "Value", miItemComprobante,"BonificacionRecargoProducto" );
						uneBonificacionProductoPorcentaje.DataBindings.Clear();
						uneBonificacionProductoPorcentaje.DataBindings.Add( "Value", miItemComprobante, "BonificacionRecargoProductoPorcentual" );
						/*uneBonificacionCuenta.DataBindings.Clear();
						uneBonificacionCuenta.DataBindings.Add( "Value",miItemComprobante,"BonificacionRecargoCuenta");
						uneBonificacionFinanciera.DataBindings.Clear();
						uneBonificacionFinanciera.DataBindings.Add( "Value",miItemComprobante,"BonificacionRecargoFinanciero");
						uneBonificacionMonetaria.DataBindings.Clear();
						uneBonificacionMonetaria.DataBindings.Add("Value",miItemComprobante,"BonificacionMonetaria");
						uneBonificacionPorcentaje.DataBindings.Clear();
						uneBonificacionPorcentaje.DataBindings.Add("Value",miItemComprobante,"BonificacionPorcentual");*/
						uneCantidad.DataBindings.Clear();
						uneCantidad.DataBindings.Add( "Value",miItemComprobante,"CantidadUnidadOrigen");
						gridImpuestos.DataSource = miItemComprobante.ImpuestosDirectos;
						gridImpuestos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutImpuestos( new string[] {"DescripcionCorta","Valor"});
						gridImpuestos.GroupByBoxVisible= false;
						txtDescripcionLarga.DataBindings.Clear();
						txtDescripcionLarga.DataBindings.Add("Text",miItemComprobante, "DescripcionLarga");
						uneCantidad.ReadOnly=false;
						txtDescripcion.DataBindings.Clear();
						txtDescripcion.DataBindings.Add("Text",miItemComprobante,"DescripcionDetallada");
						txtDescripcionLarga.Validated+=new System.EventHandler(this.Componentes_Changes);
						txtDescripcion.Validated+=new System.EventHandler(this.Componentes_Changes );
						unePrecioDeLista.ValueChanged+= new System.EventHandler(this.Componentes_Changes);
						uneBonificacionProducto.Validated+= new System.EventHandler(this.Componentes_Changes);
						uneCantidad.Validated+=new System.EventHandler(this.Componentes_Changes);
						uneStock.DataBindings.Clear();
						uneStock.DataBindings.Add("Text",miItemComprobante,"CantStock");
						uneStockPropio.DataBindings.Clear();
						uneStockPropio.DataBindings.Add("Text",miItemComprobante,"CantStockPropio");
						txtEstado.DataBindings.Clear();
						txtEstado.DataBindings.Add("Text",miItemComprobante,"EstadoStock");
						txtVisualizacion.DataBindings.Clear();
						txtVisualizacion.DataBindings.Add("Text", miItemComprobante,"VisualizacionStock");				
						string IdEstadoDeStock = Variables.GetValue("Stock.EstadoDeStock.Default").ToString();
						string IdVisualizacionDeStock = Variables.GetValue("Stock.VisualizacionDeStock.Default").ToString();						
						gridStock.DataSource = businessrules.tlg_Stock.GetStockSucursal(miProducto.IdProducto, IdVisualizacionDeStock, IdEstadoDeStock).Tables[0];
						gridStock.LayoutData = mz.erp.ui.forms.classes.Stock.GetLayoutStockSucursales(new string [] {"Descripcion","DescripcionDeposito", "DescripcionSeccion", "Suma"});
						gridStock.GroupByBoxVisible= false;
						gridStock.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridStock.RootTable.Columns["Descripcion"]));
						gridStock.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridStock.RootTable.Columns["DescripcionDeposito"]));
						gridStock.RootTable.Columns["Suma"].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
						unePrecioFinal.DataBindings.Clear();					
						unePrecioFinal.DataBindings.Add("Text",miItemComprobante,"PrecioConImpuestos");
						//unePrecioFinal.DataBindings.Add("Text",miItemComprobante,"BonificacionRecargoProductoConImpuestos");
						
						/*Nuevo Conversiones German*/
						uneCantidadDestino.DataBindings.Clear();
						uneCantidadDestino.DataBindings.Add("Value",miItemComprobante,"Cantidad");
						labelUnidadOrigen.Text = miItemComprobante.UnidadOrigen;
						labelUnidadDestino.Text = miItemComprobante.UnidadDestino;
						string valorConversion = Convert.ToString(miItemComprobante.Conversion.Items.Get(0).ValorConversion);
						string formulaConversion =  valorConversion +" " + miItemComprobante.UnidadOrigen + " = " +  "1 " + miItemComprobante.UnidadDestino;
						labelConversion.Text = formulaConversion;
						labelConversion.Visible = true;
					}
				}
				else ResetDataBindings();
			}
		}

		private void ResetDataBindings()
		{
			unePrecioDeLista.DataBindings.Clear();
			unePrecioDeLista.ResetValue();
			uneBonificacionProducto.DataBindings.Clear();
			uneBonificacionProducto.ResetValue();
			uneBonificacionProductoPorcentaje.DataBindings.Clear();
			uneBonificacionProductoPorcentaje.ResetValue();
			uneCantidad.DataBindings.Clear();
			uneCantidad.ResetValue();
			gridImpuestos.DataSource = null;
			txtDescripcionLarga.DataBindings.Clear();
			txtDescripcionLarga.ResetText();
			txtDescripcion.DataBindings.Clear();
			txtDescripcion.ResetText();
			uneStock.DataBindings.Clear();
			uneStock.ResetValue();
			uneStockPropio.DataBindings.Clear();
			uneStockPropio.ResetValue();
			txtEstado.DataBindings.Clear();
			txtEstado.ResetText();
			txtVisualizacion.DataBindings.Clear();
			txtVisualizacion.ResetText();
			gridStock.DataSource = null;
			unePrecioFinal.DataBindings.Clear();					
			unePrecioFinal.ResetValue();
			/*Nuevo Conversiones German*/
			uneCantidadDestino.DataBindings.Clear();
			uneCantidadDestino.ResetValue();
			labelUnidadOrigen.Text = string.Empty;
			labelUnidadDestino.Text = string.Empty;
			labelConversion.Text = string.Empty;
			labelConversion.Visible = true;
		}

		private void DumpItemComprobante()
		{
			
		}
		
		private void Componentes_Changes(object sender, System.EventArgs e)
		{
			if (((Control)sender).Name == "mzCmbProductos")
			{
				if (mzCmbProductos.DataValue != null)
				{
					if	( miProducto == null)
					{
						FillItemComprobante();
					}
					else
					{
						if (miProducto != null) 
						{
							if (miProducto.Codigo != null)
							{
								if (miProducto.Codigo != (String)mzCmbProductos.DataValue && miProducto.Codigo != String.Empty)
								{ 
									FillItemComprobante();
								}
							}
						}
					}
				}
				
			}
			else
			{
				RefreshControls();
			}
			
			
		}
		protected override void Aceptar()
		{
			if (miItemComprobante != null)
			{
				ComprobanteDeVenta comprobante = (ComprobanteDeVenta)_sender;
				comprobante.Items.Add( miItemComprobante );
				ProcessObjectsObserver();		
				base.Aceptar();
			}
			else
			{
				base.Cancelar();
			}
		}

		protected override void GenerarPedido()
		{
			/*if(miItemComprobante != null)

			{
				FrmComprobantesDeCompra Frmcc = new FrmComprobantesDeCompra("New", miItemComprobante,"Prepedir");
				Frmcc.MdiParent = this.MdiParent;
				Frmcc.Show();
			}*/

		
		}

		private ArrayList _objectListener = new ArrayList();
		public void AddObjectListener( ISearchObjectListener _object )
		{
			_objectListener.Add( _object );
		}
		private void ProcessObjectsObserver()
		{
			foreach ( ISearchObjectListener _object in _objectListener )
			{
				_object.processEventChange( miItemComprobante, new System.EventArgs() );	
			}
		}


		#endregion



		
		

		
	}
}


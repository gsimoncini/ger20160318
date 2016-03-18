 using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmFormasDePago.
	/// </summary>
	public class FrmFormasDePago : System.Windows.Forms.Form, ITaskForm
	{
		protected System.Windows.Forms.ToolBar toolBarStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.ComponentModel.IContainer components;
		private Janus.Windows.GridEX.GridEX gridValoresRecargos;
		private Janus.Windows.GridEX.GridEX gridFormasDePago;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalCompVenta;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalCompVentaSinRecargo;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImporteAbonado;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalPorcentajeRecargo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImporteRecargo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBarButton tbbSiguiente;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.MenuItem menuItemEditar;
		private System.Windows.Forms.MenuItem menuItemEliminar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor Saldo;
		private System.Windows.Forms.Label label8;

		private FormasDePagoController _uiController;

		public FrmFormasDePago()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
		}

		

		public FrmFormasDePago(FormasDePagoController controller)
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

		public void InitColores () 
		{	
			//modifico el color
			if (Convert.ToDouble(Saldo.Value) >= 0.0) 
			{
				if (Convert.ToDouble(Saldo.Value) == 0.0 ) //queda saldado
					Saldo.Appearance.ForeColor = Color.Black;
				else // falta pagar 
					Saldo.Appearance.ForeColor = Color.Red;
			}
			else //pago mas de lo que debe pagar
				Saldo.Appearance.ForeColor = Color.Blue;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmFormasDePago));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.gridValoresRecargos = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItemEditar = new System.Windows.Forms.MenuItem();
			this.menuItemEliminar = new System.Windows.Forms.MenuItem();
			this.gridFormasDePago = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label8 = new System.Windows.Forms.Label();
			this.Saldo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.uneTotalCompVenta = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.uneTotalCompVentaSinRecargo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.uneTotalImporteAbonado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalPorcentajeRecargo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotalImporteRecargo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridValoresRecargos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFormasDePago)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Saldo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalCompVenta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalCompVentaSinRecargo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImporteAbonado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalPorcentajeRecargo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImporteRecargo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, -22);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(878, 25);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(878, 25);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.btnAgregar);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridValoresRecargos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridFormasDePago);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 62);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(878, 216);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(341, 72);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(48, 16);
			this.btnEliminar.TabIndex = 2;
			this.btnEliminar.Text = "<<";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Location = new System.Drawing.Point(341, 56);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(48, 16);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = ">>";
			// 
			// gridValoresRecargos
			// 
			this.gridValoresRecargos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridValoresRecargos.ContextMenu = this.contextMenu1;
			this.gridValoresRecargos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridValoresRecargos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridValoresRecargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gridValoresRecargos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridValoresRecargos.Location = new System.Drawing.Point(392, 8);
			this.gridValoresRecargos.Name = "gridValoresRecargos";
			this.gridValoresRecargos.Size = new System.Drawing.Size(536, 208);
			this.gridValoresRecargos.TabIndex = 3;
			this.gridValoresRecargos.SortKeysChanged += new System.EventHandler(this.gridValoresRecargos_SortKeysChanged);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItemEditar,
																						 this.menuItemEliminar});
			// 
			// menuItemEditar
			// 
			this.menuItemEditar.Index = 0;
			this.menuItemEditar.Text = "Editar";
			this.menuItemEditar.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItemEliminar
			// 
			this.menuItemEliminar.Index = 1;
			this.menuItemEliminar.Text = "Eliminar";
			this.menuItemEliminar.Click += new System.EventHandler(this.menuItemEliminar_Click);
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
			this.gridFormasDePago.Location = new System.Drawing.Point(0, 8);
			this.gridFormasDePago.Name = "gridFormasDePago";
			this.gridFormasDePago.Size = new System.Drawing.Size(336, 208);
			this.gridFormasDePago.TabIndex = 0;
			this.gridFormasDePago.TabStop = false;
			this.gridFormasDePago.DoubleClick += new System.EventHandler(this.gridFormasDePago_DoubleClick);
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label8);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.Saldo);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalCompVenta);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalCompVentaSinRecargo);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalImporteAbonado);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalPorcentajeRecargo);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotalImporteRecargo);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 337);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(878, 128);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(656, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 8);
			this.label8.TabIndex = 32;
			this.label8.Text = "~";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// Saldo
			// 
			appearance1.ForeColorDisabled = System.Drawing.Color.Black;
			this.Saldo.Appearance = appearance1;
			this.Saldo.AutoSize = false;
			this.Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Saldo.FormatString = "";
			this.Saldo.Location = new System.Drawing.Point(524, 99);
			this.Saldo.MaxValue = 9999999;
			this.Saldo.MinValue = -9999999;
			this.Saldo.Name = "Saldo";
			this.Saldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.Saldo.ReadOnly = true;
			this.Saldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Saldo.Size = new System.Drawing.Size(120, 24);
			this.Saldo.TabIndex = 31;

			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(400, 103);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 17);
			this.label7.TabIndex = 30;
			this.label7.Text = "Saldo";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(400, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 16);
			this.label6.TabIndex = 28;
			this.label6.Text = "Sub Total";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(400, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "Recargos";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(744, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 26;
			this.label4.Text = "% de Recargo";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(400, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 16);
			this.label3.TabIndex = 25;
			this.label3.Text = "Importe Abonado";
			// 
			// uneTotalCompVenta
			// 
			this.uneTotalCompVenta.AutoSize = false;
			this.uneTotalCompVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.uneTotalCompVenta.FormatString = "";
			this.uneTotalCompVenta.Location = new System.Drawing.Point(524, 72);
			this.uneTotalCompVenta.MaxValue = 9999999;
			this.uneTotalCompVenta.MinValue = -9999999;
			this.uneTotalCompVenta.Name = "uneTotalCompVenta";
			this.uneTotalCompVenta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalCompVenta.ReadOnly = true;
			this.uneTotalCompVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uneTotalCompVenta.Size = new System.Drawing.Size(120, 24);
			this.uneTotalCompVenta.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(400, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 16);
			this.label2.TabIndex = 23;
			this.label2.Text = "Total Con Recargos";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// uneTotalCompVentaSinRecargo
			// 
			this.uneTotalCompVentaSinRecargo.AutoSize = false;
			this.uneTotalCompVentaSinRecargo.FormatString = "";
			this.uneTotalCompVentaSinRecargo.Location = new System.Drawing.Point(232, 74);
			this.uneTotalCompVentaSinRecargo.MaxValue = 99999999;
			this.uneTotalCompVentaSinRecargo.MinValue = -99999999;
			this.uneTotalCompVentaSinRecargo.Name = "uneTotalCompVentaSinRecargo";
			this.uneTotalCompVentaSinRecargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalCompVentaSinRecargo.ReadOnly = true;
			this.uneTotalCompVentaSinRecargo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uneTotalCompVentaSinRecargo.Size = new System.Drawing.Size(100, 21);
			this.uneTotalCompVentaSinRecargo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(80, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 16);
			this.label1.TabIndex = 21;
			this.label1.Text = "Total sin Recargos";
			// 
			// uneTotalImporteAbonado
			// 
			this.uneTotalImporteAbonado.AutoSize = false;
			this.uneTotalImporteAbonado.FormatString = "";
			this.uneTotalImporteAbonado.Location = new System.Drawing.Point(544, 0);
			this.uneTotalImporteAbonado.MaxValue = 99999999;
			this.uneTotalImporteAbonado.MinValue = -99999999;
			this.uneTotalImporteAbonado.Name = "uneTotalImporteAbonado";
			this.uneTotalImporteAbonado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalImporteAbonado.ReadOnly = true;
			this.uneTotalImporteAbonado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uneTotalImporteAbonado.Size = new System.Drawing.Size(100, 21);
			this.uneTotalImporteAbonado.TabIndex = 1;
			// 
			// uneTotalPorcentajeRecargo
			// 
			this.uneTotalPorcentajeRecargo.AutoSize = false;
			this.uneTotalPorcentajeRecargo.FormatString = "p";
			this.uneTotalPorcentajeRecargo.Location = new System.Drawing.Point(680, 24);
			this.uneTotalPorcentajeRecargo.MaxValue = 99999999;
			this.uneTotalPorcentajeRecargo.MinValue = -99999999;
			this.uneTotalPorcentajeRecargo.Name = "uneTotalPorcentajeRecargo";
			this.uneTotalPorcentajeRecargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalPorcentajeRecargo.ReadOnly = true;
			this.uneTotalPorcentajeRecargo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uneTotalPorcentajeRecargo.Size = new System.Drawing.Size(56, 21);
			this.uneTotalPorcentajeRecargo.TabIndex = 6;
			// 
			// uneTotalImporteRecargo
			// 
			this.uneTotalImporteRecargo.AutoSize = false;
			this.uneTotalImporteRecargo.FormatString = "";
			this.uneTotalImporteRecargo.Location = new System.Drawing.Point(544, 24);
			this.uneTotalImporteRecargo.MaxValue = 99999999;
			this.uneTotalImporteRecargo.MinValue = -99999999;
			this.uneTotalImporteRecargo.Name = "uneTotalImporteRecargo";
			this.uneTotalImporteRecargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalImporteRecargo.ReadOnly = true;
			this.uneTotalImporteRecargo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uneTotalImporteRecargo.Size = new System.Drawing.Size(100, 21);
			this.uneTotalImporteRecargo.TabIndex = 2;
			// 
			// uneTotal
			// 
			this.uneTotal.AutoSize = false;
			this.uneTotal.FormatString = "";
			this.uneTotal.Location = new System.Drawing.Point(544, 48);
			this.uneTotal.MaxValue = 9999999;
			this.uneTotal.MinValue = -9999999;
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.ReadOnly = true;
			this.uneTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uneTotal.Size = new System.Drawing.Size(100, 21);
			this.uneTotal.TabIndex = 3;
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
			this.toolBarStandar.Size = new System.Drawing.Size(944, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
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
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 216;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 128;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Totales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(944, 490);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
			this.ultraExplorerBar1.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
			// 
			// FrmFormasDePago
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(944, 518);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmFormasDePago";
			this.Text = "FrmFormasDePago";
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridValoresRecargos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFormasDePago)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Saldo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalCompVenta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalCompVentaSinRecargo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImporteAbonado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalPorcentajeRecargo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImporteRecargo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

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

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf(e.Button))
			{
				case 0:
					_uiController.Previous();
					break;
				case 2: 
					_uiController.Execute();
					break;
				case 4:
					if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
						Close();
					break;
			}		
		}


		public void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();
				InitColores();


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
			_uiController.Execute();
		}

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
			ConfigGrids();
		}

		private void ConfigGrids()
		{
			if(gridValoresRecargos.RootTable != null)
			{
				gridValoresRecargos.RootTable.Columns["Concepto"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["PorcentajeRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["ImporteRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["Total"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["RecargosIncluidos"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				

			}
			if(gridFormasDePago.RootTable != null)
			{
				//gridFormasDePago.RootTable.Groups[0].Expand();
				

		
	
			}
			//gridValoresRecargos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridFormasDePago.MoveFirst();
		
		}

		private void ConfigureInterface()
		{
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			gridFormasDePago.GroupByBoxVisible = false;
			this.Text = _uiController.Caption;
			gridFormasDePago.LayoutData = _uiController.LayoutFormasDePagos;
			gridValoresRecargos.LayoutData = _uiController.LayoutRecargos;
			labelTarea.Text = _uiController.Caption;
			gridValoresRecargos.GroupByBoxVisible = false;
			//gridValoresRecargos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			//gridValoresRecargos.UpdateOnLeave = false;
			gridValoresRecargos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			gridValoresRecargos.EventErrorHandling = true;
			
			gridValoresRecargos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			btnEliminar.Enabled = true;
			btnAgregar.Enabled = true;

			gridFormasDePago.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			gridFormasDePago.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			KeyPreview = true;
		}

		private void InitEventHandlers()
		{
		    toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick); 
			_uiController.OnModelChanged +=new EventHandler(_uiController_OnModelChanged);
			gridValoresRecargos.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridValoresRecargos_Error);
			gridValoresRecargos.KeyDown +=new KeyEventHandler(gridValoresRecargos_KeyDown);
			gridValoresRecargos.CellEdited +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridValoresRecargos_CellEdited);
			gridValoresRecargos.RecordsDeleted +=new EventHandler(gridValoresRecargos_RecordsDeleted);
			gridValoresRecargos.DoubleClick +=new EventHandler(gridValoresRecargos_DoubleClick);
			btnAgregar.Click +=new EventHandler(btnAgregar_Click);
			btnEliminar.Click +=new EventHandler(btnEliminar_Click);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
		}

		private void InitDataBindings()
		{
			gridFormasDePago.SetDataBinding(_uiController.FormasDePagos, null);
			/*
			this.gridFormasDePago.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridFormasDePago.RootTable.Columns["DescripcionComprobante"]));
			this.gridFormasDePago.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridFormasDePago.RootTable.Columns["DescripcionEntidad"]));
			this.gridFormasDePago.RootTable.Groups[0].Collapse();
			*/
			Saldo.DataBindings.Add("Value", _uiController, "Saldo");
			gridValoresRecargos.SetDataBinding(_uiController.RecargosFormaDepago, null);
			uneTotal.DataBindings.Add("Value", _uiController, "Total");
			uneTotalImporteAbonado.DataBindings.Add("Value", _uiController, "TotalImporteAbonado");
			uneTotalImporteRecargo.DataBindings.Add("Value", _uiController, "TotalImporteRecargo");
			uneTotalPorcentajeRecargo.DataBindings.Add("Value", _uiController,"TotalPorcentajeRecargo");
			uneTotalCompVenta.DataBindings.Add("Value", _uiController, "TotalComprobanteDeVenta");
			uneTotalCompVentaSinRecargo.DataBindings.Add("Value", _uiController, "TotalComprobanteDeVentaSinRecargos");
			
		}

		private void InitializeData()
		{
		}



		#endregion

		
		/*Esto q esta hecho aca es horrible, cambiar todo cuando FrmValores sea MVC*/
		private void gridFormasDePago_DoubleClick(object sender, System.EventArgs e)
		{
			AddRecargo();	
		}

		private void RemoveRecargo()
		{
			if(gridValoresRecargos.SelectedItems.Count > 0)
			{
				gridValoresRecargos.Delete();
			}
		}

		private void AddRecargo()
		{
			if(gridFormasDePago.SelectedItems.Count > 0)
			{
				FormaDePago formaDePago = (FormaDePago)this.gridFormasDePago.SelectedItems[0].GetRow().DataRow;
				
				if(formaDePago != null)
				{
					FormaDePago formaDePagoClone = formaDePago.ShallowClone();
					string IdTDCompTesoreria = formaDePago.IdTDComprobante;
					bool agrupado = formaDePago.Agrupado;
					string IdMoneda = formaDePago.IdMoneda;
					if(_uiController.TotalAAbonar > 0)
					{
						_uiController.CurrentFormaDePago = formaDePagoClone ;
						FrmValores form = new FrmValores(_uiController.GetValoresController( IdTDCompTesoreria,IdMoneda,agrupado,_uiController.TotalAAbonar,formaDePago.Recargo,null, _uiController));
                        form.AddObjectListener(_uiController);
						form.ShowFormIObservable();
					}
						
				}

			}
		}

		private void _uiController_OnModelChanged(object sender, EventArgs e)
		{
			this.Refresh();
			labelTarea.Text = _uiController.Caption;
		}

		private void Refresh()
		{
			try
			{
				gridValoresRecargos.SetDataBinding(null, null);
				gridValoresRecargos.LayoutData = _uiController.LayoutRecargos;
				gridValoresRecargos.SetDataBinding(_uiController.RecargosFormaDepago, null);
				Saldo.DataBindings.Clear();
				Saldo.DataBindings.Add("Value", _uiController, "Saldo");
				uneTotal.DataBindings.Clear();
				uneTotal.DataBindings.Add("Value", _uiController, "Total");
				uneTotalImporteAbonado.DataBindings.Clear();
				uneTotalImporteAbonado.DataBindings.Add("Value", _uiController, "TotalImporteAbonado");
				uneTotalImporteRecargo.DataBindings.Clear();
				uneTotalImporteRecargo.DataBindings.Add("Value", _uiController, "TotalImporteRecargo");
				uneTotalPorcentajeRecargo.DataBindings.Clear();
				uneTotalPorcentajeRecargo.DataBindings.Add("Value", _uiController,"TotalPorcentajeRecargo");
				uneTotalCompVentaSinRecargo.DataBindings.Clear();
				uneTotalCompVentaSinRecargo.DataBindings.Add("Value", _uiController, "TotalComprobanteDeVentaSinRecargos");
				uneTotalCompVenta.DataBindings.Clear();
				uneTotalCompVenta.DataBindings.Add("Value", _uiController, "TotalComprobanteDeVenta");
				gridValoresRecargos.RootTable.Columns["Concepto"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["PorcentajeRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["ImporteRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["Total"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["RecargosIncluidos"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				InitColores();
			}
			catch(Exception e)
			{

			}

		}

		private void gridValoresRecargos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		private void gridValoresRecargos_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode.Equals(System.Windows.Forms.Keys.Enter) || e.KeyCode.Equals(System.Windows.Forms.Keys.Tab))
			{		
				if(gridValoresRecargos.SelectedItems.Count > 0)
				{
					object  formaDePago = this.gridValoresRecargos.SelectedItems[0].GetRow().DataRow;
					if(_uiController.IsEditable(formaDePago, string.Empty))
					{
						if(gridValoresRecargos.CurrentColumn.Caption.Equals("Importe"))
						{
							gridValoresRecargos.CellEdited -=new Janus.Windows.GridEX.ColumnActionEventHandler(gridValoresRecargos_CellEdited);
							gridValoresRecargos.UpdateData();
							gridValoresRecargos.RootTable.Columns["Concepto"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridValoresRecargos.RootTable.Columns["PorcentajeRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridValoresRecargos.RootTable.Columns["ImporteRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridValoresRecargos.RootTable.Columns["Total"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridValoresRecargos.RootTable.Columns["RecargosIncluidos"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridValoresRecargos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
							gridValoresRecargos.CellEdited +=new Janus.Windows.GridEX.ColumnActionEventHandler(gridValoresRecargos_CellEdited);
								
						}
					}
				}
			}
		}

		private void gridValoresRecargos_RecordsDeleted(object sender, EventArgs e)
		{
			_uiController.Refresh();
		}

		private void gridValoresRecargos_DoubleClick(object sender, EventArgs e)
		{
					
			if(gridValoresRecargos.SelectedItems.Count > 0 && gridValoresRecargos.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
			{
				object formaDePago = this.gridValoresRecargos.SelectedItems[0].GetRow().DataRow;
				if(_uiController.IsEditable(formaDePago, string.Empty))
				{
					if(gridValoresRecargos.CurrentColumn != null)
					{
						if(gridValoresRecargos.CurrentColumn.Caption.Equals("Importe"))
						{
							gridValoresRecargos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;

						}
					}
				}
			}
			
		}


		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			
			if(gridValoresRecargos.SelectedItems.Count > 0)
			{
				RecargoFormaDePago recargo = (RecargoFormaDePago)this.gridValoresRecargos.SelectedItems[0].GetRow().DataRow;
				FormaDePago formaDePago = (FormaDePago)recargo.FormaDePago;
				if(formaDePago != null)
					if(_uiController.IsEditable(recargo, string.Empty))
					{
				
				
						string IdTDCompTesoreria = formaDePago.IdTDComprobante;
						//bool agrupado = formaDePago.Agrupado;
						//string IdMoneda = formaDePago.IdMoneda;
						_uiController.CurrentFormaDePago = formaDePago ;
						FrmValores form = new FrmValores(_uiController.GetValoresController(), _uiController);
						form.AddObjectListener(_uiController);
						form.ShowFormIObservable();
					}
						
				

			}
				
		}

		private void gridValoresRecargos_CellEdited(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			if(gridValoresRecargos.CurrentColumn.Caption.Equals("Importe")  )
			{
				gridValoresRecargos.UpdateData();
				gridValoresRecargos.RootTable.Columns["Concepto"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["PorcentajeRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["ImporteRecargo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["Total"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.RootTable.Columns["RecargosIncluidos"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				gridValoresRecargos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
								
			}	
		}

		private void gridValoresRecargos_SortKeysChanged(object sender, System.EventArgs e)
		{
			

		}



		private void menuItemEliminar_Click(object sender, System.EventArgs e)
		{
			if(_uiController.IsRemovable(sender))
				RemoveRecargo();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			AddRecargo();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if(_uiController.IsRemovable(sender))
				RemoveRecargo();
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
		
		}

		private void label8_Click(object sender, System.EventArgs e)
		{
		
		}	

		

	}
}

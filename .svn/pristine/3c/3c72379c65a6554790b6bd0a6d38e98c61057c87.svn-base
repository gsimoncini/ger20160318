using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FormCuentas.
	/// </summary>
	public class FormCuentas : System.Windows.Forms.Form
	{
		private mz.erp.commontypes.data.tsa_CuentasDataset.tsa_CuentasRow row;

		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private Infragistics.Win.Misc.UltraLabel ultraLabel3;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private Infragistics.Win.Misc.UltraLabel ultraLabel5;
		private Infragistics.Win.Misc.UltraLabel ultraLabel6;
		private Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown uCDDCategoriaIva;
		private Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown uCDDTipoDocumento;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTECategoriaIva;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTETipoDocumento;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEDocumento;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEHorario;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTENombre;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTECodigo;
		private System.Windows.Forms.CheckBox checkBox1;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor uTEObservaciones;
		private Infragistics.Win.Misc.UltraButton ultraButton1;
		private Infragistics.Win.Misc.UltraButton ultraButton2;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormCuentas( long id)
		{

			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			//LoadControls

			if (id != 0)
			{
				row = mz.erp.businessrules.tsa_Cuentas.GetByPk(id);				
			}
			else 
			{
				row = mz.erp.businessrules.tsa_Cuentas.NewRow();
			}
			uTECodigo.Text = Convert.ToString(row.Codigo);
			uTENombre.Text = row.Nombre;
			uTECategoriaIva.Text = row.IdCategoriaIva;
			uTEDocumento.Text = row.Documento;
			uTEHorario.Text = row.HorarioComercial;
			uTETipoDocumento.Text = Convert.ToString(row.idTipoDocumento);
			checkBox1.Checked = row.Activo;
			uTEObservaciones.Text = row.Observaciones;
		
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
			Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton calculatorButton1 = new Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15);
			Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton calculatorButton2 = new Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton(15);
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.uCDDCategoriaIva = new Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown();
			this.uCDDTipoDocumento = new Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown();
			this.uTECategoriaIva = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.uTETipoDocumento = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
			this.uTEDocumento = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.uTEHorario = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
			this.uTENombre = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
			this.uTECodigo = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uTEObservaciones = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
			this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uCDDCategoriaIva)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uCDDTipoDocumento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uTECategoriaIva)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uTETipoDocumento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uTEDocumento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uTEHorario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uTENombre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uTECodigo)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.BackColor = System.Drawing.SystemColors.Control;
			this.ultraExplorerBarContainerControl1.Controls.Add(this.checkBox1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uCDDCategoriaIva);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uCDDTipoDocumento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uTECategoriaIva);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uTETipoDocumento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uTEDocumento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uTEHorario);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uTENombre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uTECodigo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(19, 45);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(649, 161);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Location = new System.Drawing.Point(401, 0);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Activo";
			// 
			// uCDDCategoriaIva
			// 
			calculatorButton1.Key = ".";
			calculatorButton1.KeyCodeAlternateValue = 190;
			calculatorButton1.KeyCodeValue = 110;
			calculatorButton1.Text = ",";
			this.uCDDCategoriaIva.Buttons.AddRange(new Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton[] {
																															calculatorButton1});
			this.uCDDCategoriaIva.Location = new System.Drawing.Point(161, 125);
			this.uCDDCategoriaIva.Name = "uCDDCategoriaIva";
			this.uCDDCategoriaIva.Size = new System.Drawing.Size(250, 22);
			this.uCDDCategoriaIva.TabIndex = 15;
			// 
			// uCDDTipoDocumento
			// 
			calculatorButton2.Key = ".";
			calculatorButton2.KeyCodeAlternateValue = 190;
			calculatorButton2.KeyCodeValue = 110;
			calculatorButton2.Text = ",";
			this.uCDDTipoDocumento.Buttons.AddRange(new Infragistics.Win.UltraWinEditors.UltraWinCalc.CalculatorButton[] {
																															 calculatorButton2});
			this.uCDDTipoDocumento.Location = new System.Drawing.Point(161, 75);
			this.uCDDTipoDocumento.Name = "uCDDTipoDocumento";
			this.uCDDTipoDocumento.Size = new System.Drawing.Size(250, 22);
			this.uCDDTipoDocumento.TabIndex = 14;
			// 
			// uTECategoriaIva
			// 
			this.uTECategoriaIva.Location = new System.Drawing.Point(101, 125);
			this.uTECategoriaIva.Name = "uTECategoriaIva";
			this.uTECategoriaIva.Size = new System.Drawing.Size(60, 22);
			this.uTECategoriaIva.TabIndex = 13;
			// 
			// uTETipoDocumento
			// 
			this.uTETipoDocumento.Location = new System.Drawing.Point(101, 75);
			this.uTETipoDocumento.Name = "uTETipoDocumento";
			this.uTETipoDocumento.Size = new System.Drawing.Size(60, 22);
			this.uTETipoDocumento.TabIndex = 12;
			// 
			// ultraLabel6
			// 
			this.ultraLabel6.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraLabel6.Location = new System.Drawing.Point(0, 125);
			this.ultraLabel6.Name = "ultraLabel6";
			this.ultraLabel6.Size = new System.Drawing.Size(101, 22);
			this.ultraLabel6.TabIndex = 11;
			this.ultraLabel6.Text = "Categoría IVA:";
			// 
			// ultraLabel5
			// 
			this.ultraLabel5.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraLabel5.Location = new System.Drawing.Point(0, 75);
			this.ultraLabel5.Name = "ultraLabel5";
			this.ultraLabel5.Size = new System.Drawing.Size(101, 22);
			this.ultraLabel5.TabIndex = 9;
			this.ultraLabel5.Text = "Tipo Documento:";
			// 
			// uTEDocumento
			// 
			this.uTEDocumento.Location = new System.Drawing.Point(101, 100);
			this.uTEDocumento.Name = "uTEDocumento";
			this.uTEDocumento.Size = new System.Drawing.Size(100, 22);
			this.uTEDocumento.TabIndex = 8;
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraLabel4.Location = new System.Drawing.Point(0, 100);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(101, 22);
			this.ultraLabel4.TabIndex = 7;
			this.ultraLabel4.Text = "Documento:";
			// 
			// uTEHorario
			// 
			this.uTEHorario.Location = new System.Drawing.Point(101, 50);
			this.uTEHorario.Name = "uTEHorario";
			this.uTEHorario.Size = new System.Drawing.Size(400, 22);
			this.uTEHorario.TabIndex = 6;
			// 
			// ultraLabel3
			// 
			this.ultraLabel3.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraLabel3.Location = new System.Drawing.Point(0, 50);
			this.ultraLabel3.Name = "ultraLabel3";
			this.ultraLabel3.Size = new System.Drawing.Size(101, 22);
			this.ultraLabel3.TabIndex = 5;
			this.ultraLabel3.Text = "Horario Comercial:";
			// 
			// uTENombre
			// 
			this.uTENombre.Location = new System.Drawing.Point(101, 25);
			this.uTENombre.Name = "uTENombre";
			this.uTENombre.Size = new System.Drawing.Size(400, 22);
			this.uTENombre.TabIndex = 4;
			// 
			// ultraLabel2
			// 
			this.ultraLabel2.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraLabel2.Location = new System.Drawing.Point(0, 25);
			this.ultraLabel2.Name = "ultraLabel2";
			this.ultraLabel2.Size = new System.Drawing.Size(101, 22);
			this.ultraLabel2.TabIndex = 3;
			this.ultraLabel2.Text = "Nombre:";
			// 
			// uTECodigo
			// 
			this.uTECodigo.Location = new System.Drawing.Point(101, 0);
			this.uTECodigo.Name = "uTECodigo";
			this.uTECodigo.Size = new System.Drawing.Size(100, 22);
			this.uTECodigo.TabIndex = 2;
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ultraLabel1.Location = new System.Drawing.Point(0, 0);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(101, 22);
			this.ultraLabel1.TabIndex = 1;
			this.ultraLabel1.Text = "Código:";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.uTEObservaciones);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(19, 76);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(649, 148);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// uTEObservaciones
			// 
			this.uTEObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uTEObservaciones.Location = new System.Drawing.Point(0, 0);
			this.uTEObservaciones.Multiline = true;
			this.uTEObservaciones.Name = "uTEObservaciones";
			this.uTEObservaciones.Size = new System.Drawing.Size(649, 148);
			this.uTEObservaciones.TabIndex = 0;
			this.uTEObservaciones.Text = "ultraTextEditor1";
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(19, 284);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(554, 148);
			this.ultraExplorerBarContainerControl4.TabIndex = 3;
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(19, 138);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(666, 148);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.dataGrid1);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 324);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(543, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 0);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(543, 150);
			this.dataGrid1.TabIndex = 0;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Default;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ultraExplorerBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Expanded = false;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 163;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Cuentas";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Expanded = false;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Observaciones";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup3.Expanded = false;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Domicilios";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup4.Expanded = false;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Contactos";
			ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup5.Expanded = false;
			ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup5.Text = "Formas de Pago";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4,
																														ultraExplorerBarGroup5});
			this.ultraExplorerBar1.GroupSpacing = 5;
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 32);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(704, 485);
			this.ultraExplorerBar1.TabIndex = 4;
			this.ultraExplorerBar1.ViewStyle = Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarViewStyle.XP;
			// 
			// ultraButton1
			// 
			this.ultraButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ultraButton1.Location = new System.Drawing.Point(512, 5);
			this.ultraButton1.Name = "ultraButton1";
			this.ultraButton1.TabIndex = 5;
			this.ultraButton1.Text = "Aceptar";
			this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
			// 
			// ultraButton2
			// 
			this.ultraButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ultraButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ultraButton2.Location = new System.Drawing.Point(600, 5);
			this.ultraButton2.Name = "ultraButton2";
			this.ultraButton2.TabIndex = 5;
			this.ultraButton2.Text = "Cancelar";
			// 
			// FormCuentas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 517);
			this.Controls.Add(this.ultraButton1);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.ultraButton2);
			this.Name = "FormCuentas";
			this.Text = "FormCuentas";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uCDDCategoriaIva)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uCDDTipoDocumento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uTECategoriaIva)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uTETipoDocumento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uTEDocumento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uTEHorario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uTENombre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uTECodigo)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uTEObservaciones)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		# region Custom Members
	

		# endregion


		private void ultraButton1_Click(object sender, System.EventArgs e)
		{
			row.Nombre = uTENombre.Text;
			mz.erp.businessrules.tsa_Cuentas.Update(row);
		}

	}
}

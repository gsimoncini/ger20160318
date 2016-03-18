using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Drawing;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.systemframework;
using mz.erp.businessrules;
using mz.erp.ui;
using mz.erp.ui.controls;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FormAbmCondicionesDeVenta.
	/// </summary>
	public class FormAbmCondicionesDeVenta : mz.erp.ui.forms.FrmABMEx	
	{
		#region variables de la ventana
			
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCuotas;
		
		#endregion 
		
		#region variables
				
		string _recargo;
		string _descripcion;
		string _cuotas;
		string _idCondicionDeVenta;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtRecargo;
		private System.Windows.Forms.CheckBox chkTieneFDPAsociada;
		private System.Windows.Forms.Label label5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.RadioButton rbMetodoComparacionPorI;
		private System.Windows.Forms.RadioButton rbMetodoComparacionPorE;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbMetAsigCuentaPorI;
		private System.Windows.Forms.RadioButton rbMetAsigCuentaPorE;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbMetAsigTipCompPorI;
		private System.Windows.Forms.RadioButton rbMetAsigTipCompPorE;
		private Infragistics.Win.Misc.UltraButton ultraButton1;
		private Janus.Windows.GridEX.GridEX gridClientes;
		private mz.erp.ui.controls.mzCuentasControl mzCuentasControl1;
		private System.Windows.Forms.Label label25;
		private Infragistics.Win.Misc.UltraButton bNingunoTiposDeComprobantes;
		private Infragistics.Win.Misc.UltraButton bTodosTiposDeComprobantes;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkListTiposDeComprobantes;
		private System.Windows.Forms.CheckBox chActivo;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		mz.erp.businessrules.tsa_CondicionesDeVentaDet  detalle = new tsa_CondicionesDeVentaDet();

		#endregion

		#region CustomMembers

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tsa_CondicionesDeVentasEx().GetType();
			base.Init();
		}		

		protected override void InitializeMembers()
		{
			txtDescripcion.MaxLength = 50;
			txtRecargo.Enter += new EventHandler(txtRecargo_Enter);
		}

		protected override void FillControls()
		{
			if (_data != null)
			{
				try
				{	
					tsa_CondicionesDeVentasExDataset data  = (tsa_CondicionesDeVentasExDataset) _data;
					System.Data.DataRow row = data.tsa_CondicionesDeVentas.Rows[0];
					_idCondicionDeVenta = (string)row["IdCondicionDeVenta"];
					txtDescripcion.Text = (string)row["Descripcion"];
					txtRecargo.Text = Convert.ToString(row["Recargo"]);
					txtCuotas.Text = detalle.TextCuotas(_idCondicionDeVenta);	
					bool _activo = (bool)row["Activo"];
					if (_activo) chActivo.Checked = true;
										
				}
				catch(Exception e)
				{Console.WriteLine(e.Message);}
			}
		}
						
		protected override void DumpControls()
		{
			if (_data != null)
			{
				//agrego la cabecera
				tsa_CondicionesDeVentasExDataset data  = (tsa_CondicionesDeVentasExDataset) _data;
				System.Data.DataRow row = data.tsa_CondicionesDeVentas.Rows[0];
				row["Descripcion"] = txtDescripcion.Text;
				if (txtRecargo.Text == txtRecargo.NullText ) 
					row["Recargo"] = 000.00; 
				else
					row["Recargo"] = txtRecargo.Text;

				if (chActivo.Checked) 
					row["Activo"] = true;
				else 
					row["Activo"] = false;

				//agrego o modifico los detalles; puntualmente en base a las cuotas ingresadas
				if (txtCuotas.Text == String.Empty) 
					txtCuotas.Text = "0";
				InsertUpdateDetalles((string)row["IdCondicionDeVenta"], txtCuotas.Text);				
			}	
		}

	
		/// <summary>
		/// desarma el string text, de forma tal de poder insertar el detalle correspondiente a una 
		/// condicion de venta determinada, basandose en los dias de vencimiento de las cuotas
		/// </summary>
		public void InsertUpdateDetalles(string idCondicionDeVenta, string text)
		{
			short cuota = 1;
			string[] dias = text.Split(',');
			int cantCuotas = text.Split(',').Length;
			decimal porcentajeCuota = 100/cantCuotas;		
			tsa_CondicionesDeVentasExDataset dataEX  = (tsa_CondicionesDeVentasExDataset) _data;
			//borro todas las filas hijos
			foreach(System.Data.DataRow row in dataEX.tsa_CondicionesDeVentaDet.Rows)
			{
				row.Delete();
			}
			//agrego todos los hijos nuevos
			foreach (string dia in dias)
			{
				tsa_CondicionesDeVentasExDataset.tsa_CondicionesDeVentaDetRow row = dataEX.tsa_CondicionesDeVentaDet.Newtsa_CondicionesDeVentaDetRow();			
				row["IdCondicionDeVentaDet"] = idCondicionDeVenta;
				row["Cuota"]= cuota;
				row["DiasVencimiento"]= dia;
				row["Porcentual"] = porcentajeCuota;
				cuota ++;
				dataEX.tsa_CondicionesDeVentaDet.Addtsa_CondicionesDeVentaDetRow(row);	
			}
		}
		
		#endregion					

		#region constructores y destructores
		public FormAbmCondicionesDeVenta()
		{
			InitializeComponent();
		}

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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label26 = new System.Windows.Forms.Label();
			this.rbMetodoComparacionPorI = new System.Windows.Forms.RadioButton();
			this.rbMetodoComparacionPorE = new System.Windows.Forms.RadioButton();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label28 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbMetAsigCuentaPorI = new System.Windows.Forms.RadioButton();
			this.rbMetAsigCuentaPorE = new System.Windows.Forms.RadioButton();
			this.label27 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbMetAsigTipCompPorI = new System.Windows.Forms.RadioButton();
			this.rbMetAsigTipCompPorE = new System.Windows.Forms.RadioButton();
			this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
			this.gridClientes = new Janus.Windows.GridEX.GridEX();
			this.mzCuentasControl1 = new mz.erp.ui.controls.mzCuentasControl();
			this.label25 = new System.Windows.Forms.Label();
			this.bNingunoTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.bTodosTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.chkListTiposDeComprobantes = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCuotas = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRecargo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.chkTieneFDPAsociada = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chActivo = new System.Windows.Forms.CheckBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).BeginInit();
			this.SuspendLayout();
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.Size = new System.Drawing.Size(904, 28);
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Enabled = false;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 13;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Método de Comparación";
			ultraExplorerBarGroup1.Visible = false;
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup2.Enabled = false;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 360;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Tipos de Comprobantes y Clientes Asociados";
			ultraExplorerBarGroup2.Visible = false;
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(904, 490);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl3, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl2, 0);
			this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chActivo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.chkTieneFDPAsociada);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtRecargo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCuotas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(838, 104);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label26);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.rbMetodoComparacionPorI);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.rbMetodoComparacionPorE);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 212);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(838, 13);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(0, 0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(152, 16);
			this.label26.TabIndex = 27;
			this.label26.Text = "Método de Comparación";
			// 
			// rbMetodoComparacionPorI
			// 
			this.rbMetodoComparacionPorI.AccessibleDescription = "";
			this.rbMetodoComparacionPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetodoComparacionPorI.Location = new System.Drawing.Point(272, 0);
			this.rbMetodoComparacionPorI.Name = "rbMetodoComparacionPorI";
			this.rbMetodoComparacionPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetodoComparacionPorI.TabIndex = 26;
			this.rbMetodoComparacionPorI.Text = "Por Inclusión";
			// 
			// rbMetodoComparacionPorE
			// 
			this.rbMetodoComparacionPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetodoComparacionPorE.Location = new System.Drawing.Point(160, 0);
			this.rbMetodoComparacionPorE.Name = "rbMetodoComparacionPorE";
			this.rbMetodoComparacionPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetodoComparacionPorE.TabIndex = 25;
			this.rbMetodoComparacionPorE.Text = "Por Exclusión";
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.panel3);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label28);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.panel2);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label27);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.panel1);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.ultraButton1);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridClientes);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.mzCuentasControl1);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.label25);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.bNingunoTiposDeComprobantes);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.bTodosTiposDeComprobantes);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.chkListTiposDeComprobantes);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 284);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(838, 360);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new System.Drawing.Point(0, 160);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(904, 1);
			this.panel3.TabIndex = 45;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(0, 184);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(128, 16);
			this.label28.TabIndex = 44;
			this.label28.Text = "Método de Asignación";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.rbMetAsigCuentaPorI);
			this.panel2.Controls.Add(this.rbMetAsigCuentaPorE);
			this.panel2.Location = new System.Drawing.Point(136, 176);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 24);
			this.panel2.TabIndex = 43;
			// 
			// rbMetAsigCuentaPorI
			// 
			this.rbMetAsigCuentaPorI.AccessibleDescription = "";
			this.rbMetAsigCuentaPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigCuentaPorI.Location = new System.Drawing.Point(144, 5);
			this.rbMetAsigCuentaPorI.Name = "rbMetAsigCuentaPorI";
			this.rbMetAsigCuentaPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigCuentaPorI.TabIndex = 23;
			this.rbMetAsigCuentaPorI.Text = "Por Inclusión";
			// 
			// rbMetAsigCuentaPorE
			// 
			this.rbMetAsigCuentaPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigCuentaPorE.Location = new System.Drawing.Point(16, 5);
			this.rbMetAsigCuentaPorE.Name = "rbMetAsigCuentaPorE";
			this.rbMetAsigCuentaPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigCuentaPorE.TabIndex = 22;
			this.rbMetAsigCuentaPorE.Text = "Por Exclusión";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(0, 8);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(128, 16);
			this.label27.TabIndex = 42;
			this.label27.Text = "Método de Asignación";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbMetAsigTipCompPorI);
			this.panel1.Controls.Add(this.rbMetAsigTipCompPorE);
			this.panel1.Location = new System.Drawing.Point(136, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(376, 24);
			this.panel1.TabIndex = 41;
			// 
			// rbMetAsigTipCompPorI
			// 
			this.rbMetAsigTipCompPorI.AccessibleDescription = "";
			this.rbMetAsigTipCompPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigTipCompPorI.Location = new System.Drawing.Point(144, 5);
			this.rbMetAsigTipCompPorI.Name = "rbMetAsigTipCompPorI";
			this.rbMetAsigTipCompPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigTipCompPorI.TabIndex = 23;
			this.rbMetAsigTipCompPorI.Text = "Por Inclusión";
			// 
			// rbMetAsigTipCompPorE
			// 
			this.rbMetAsigTipCompPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigTipCompPorE.Location = new System.Drawing.Point(16, 5);
			this.rbMetAsigTipCompPorE.Name = "rbMetAsigTipCompPorE";
			this.rbMetAsigTipCompPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigTipCompPorE.TabIndex = 22;
			this.rbMetAsigTipCompPorE.Text = "Por Exclusión";
			// 
			// ultraButton1
			// 
			this.ultraButton1.AcceptsFocus = false;
			this.ultraButton1.Location = new System.Drawing.Point(528, 200);
			this.ultraButton1.Name = "ultraButton1";
			this.ultraButton1.Size = new System.Drawing.Size(112, 24);
			this.ultraButton1.TabIndex = 40;
			this.ultraButton1.TabStop = false;
			this.ultraButton1.Text = "Agregar Cliente";
			// 
			// gridClientes
			// 
			this.gridClientes.AllowCardSizing = false;
			this.gridClientes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridClientes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridClientes.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridClientes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridClientes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridClientes.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridClientes.Location = new System.Drawing.Point(64, 224);
			this.gridClientes.Name = "gridClientes";
			this.gridClientes.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridClientes.Size = new System.Drawing.Size(528, 128);
			this.gridClientes.TabIndex = 39;
			this.gridClientes.TabStop = false;
			// 
			// mzCuentasControl1
			// 
			this.mzCuentasControl1.AllowEditClientePaso = false;
			this.mzCuentasControl1.BackColor = System.Drawing.SystemColors.Control;
			this.mzCuentasControl1.DataValue = "";
			this.mzCuentasControl1.EnableCtaCte = false;
			this.mzCuentasControl1.FastSearch = false;
			this.mzCuentasControl1.Location = new System.Drawing.Point(64, 200);
			this.mzCuentasControl1.Name = "mzCuentasControl1";
			this.mzCuentasControl1.SearchObjectListener = null;
			this.mzCuentasControl1.Size = new System.Drawing.Size(440, 24);
			this.mzCuentasControl1.TabIndex = 38;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(592, 48);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(232, 56);
			this.label25.TabIndex = 37;
			this.label25.Text = "Seleccione lo/s Tipo/s de Comprobante/s a lo/s cual/es se asocia la nueva forma d" +
				"e pago";
			// 
			// bNingunoTiposDeComprobantes
			// 
			this.bNingunoTiposDeComprobantes.AcceptsFocus = false;
			this.bNingunoTiposDeComprobantes.Location = new System.Drawing.Point(0, 88);
			this.bNingunoTiposDeComprobantes.Name = "bNingunoTiposDeComprobantes";
			this.bNingunoTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bNingunoTiposDeComprobantes.TabIndex = 36;
			this.bNingunoTiposDeComprobantes.TabStop = false;
			this.bNingunoTiposDeComprobantes.Text = "&Ninguno";
			// 
			// bTodosTiposDeComprobantes
			// 
			this.bTodosTiposDeComprobantes.AcceptsFocus = false;
			this.bTodosTiposDeComprobantes.Location = new System.Drawing.Point(0, 64);
			this.bTodosTiposDeComprobantes.Name = "bTodosTiposDeComprobantes";
			this.bTodosTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bTodosTiposDeComprobantes.TabIndex = 35;
			this.bTodosTiposDeComprobantes.TabStop = false;
			this.bTodosTiposDeComprobantes.Text = "&Todos";
			// 
			// chkListTiposDeComprobantes
			// 
			this.chkListTiposDeComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkListTiposDeComprobantes.Location = new System.Drawing.Point(64, 24);
			this.chkListTiposDeComprobantes.MultiColumn = true;
			this.chkListTiposDeComprobantes.Name = "chkListTiposDeComprobantes";
			this.chkListTiposDeComprobantes.Size = new System.Drawing.Size(520, 124);
			this.chkListTiposDeComprobantes.TabIndex = 34;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 0);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Descripción";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Porcentaje de Recargo ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(160, 0);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(184, 20);
			this.txtDescripcion.TabIndex = 1;
			this.txtDescripcion.Text = "";
			// 
			// txtCuotas
			// 
			this.txtCuotas.Location = new System.Drawing.Point(160, 48);
			this.txtCuotas.Name = "txtCuotas";
			this.txtCuotas.Size = new System.Drawing.Size(184, 20);
			this.txtCuotas.TabIndex = 3;
			this.txtCuotas.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 23);
			this.label3.TabIndex = 27;
			this.label3.Text = "Vencimiento de las cuotas";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(352, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(384, 48);
			this.label4.TabIndex = 29;
			this.label4.Text = "Indique los días de vencimiento de cada cuota (separados por coma). Ejemplo : 10," +
				"30,60  indica que la primer cuota vence a los 10 días, la segunda a los 30 días " +
				"y la tercera a los 60 días";
			// 
			// txtRecargo
			// 
			this.txtRecargo.Location = new System.Drawing.Point(160, 24);
			this.txtRecargo.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
			this.txtRecargo.MaskInput = "-nnn.nn";
			this.txtRecargo.MaxValue = 999;
			this.txtRecargo.MinValue = -999;
			this.txtRecargo.Name = "txtRecargo";
			this.txtRecargo.Nullable = true;
			this.txtRecargo.NullText = "000.00";
			this.txtRecargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.txtRecargo.PromptChar = '0';
			this.txtRecargo.Size = new System.Drawing.Size(184, 21);
			this.txtRecargo.TabIndex = 2;
			// 
			// chkTieneFDPAsociada
			// 
			this.chkTieneFDPAsociada.BackColor = System.Drawing.Color.Transparent;
			this.chkTieneFDPAsociada.Location = new System.Drawing.Point(160, 104);
			this.chkTieneFDPAsociada.Name = "chkTieneFDPAsociada";
			this.chkTieneFDPAsociada.Size = new System.Drawing.Size(128, 24);
			this.chkTieneFDPAsociada.TabIndex = 30;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(16, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 23);
			this.label5.TabIndex = 31;
			this.label5.Text = "Forma de Pago Asoc.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chActivo
			// 
			this.chActivo.BackColor = System.Drawing.Color.Transparent;
			this.chActivo.Location = new System.Drawing.Point(16, 80);
			this.chActivo.Name = "chActivo";
			this.chActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chActivo.Size = new System.Drawing.Size(158, 16);
			this.chActivo.TabIndex = 33;
			this.chActivo.Text = "Activo";
			this.chActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(480, 312);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.TabIndex = 18;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
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
			this.tbbCancelar.Text = "Cancelar";
			// 
			// FormAbmCondicionesDeVenta
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(904, 518);
			this.Controls.Add(this.linkLabel1);
			this.Name = "FormAbmCondicionesDeVenta";
			this.Text = "FormAbmCondicionesDeVenta";
			this.Controls.SetChildIndex(this.linkLabel1, 0);
			this.Controls.SetChildIndex(this.toolBarStandar, 0);
			this.Controls.SetChildIndex(this.ultraExplorerBar1, 0);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void txtRecargo_Enter(object sender, EventArgs e)
		{
			txtRecargo.SelectAll();
		}

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

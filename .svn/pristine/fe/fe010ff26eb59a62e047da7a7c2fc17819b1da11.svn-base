using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.commontypes.data;
using mz.erp.ui.controls;
using mz.erp.businessrules;
using Infragistics.Win.UltraWinExplorerBar;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultaArticulos.
	/// </summary>
	public class FrmConsultaArticulos : System.Windows.Forms.Form
	{
		private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioNeto;
		private System.Windows.Forms.Label label7;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMaxDescto;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioBruto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridStock;
		private System.Windows.Forms.GroupBox groupBox1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneStock;
		private System.Windows.Forms.TextBox txtEstado;
		private System.Windows.Forms.TextBox txtVisualizacion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDescripcion;
		private Janus.Windows.GridEX.GridEX gridEXAgrupamientos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioNetoConImp;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioListaConImp;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneMaxDesctoConImp;
		private System.ComponentModel.IContainer components;
		

		public FrmConsultaArticulos()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
		
			mz.erp.ui.forms.classes.tsh_AgrupProductos ap = new mz.erp.ui.forms.classes.tsh_AgrupProductos();	
			gridEXAgrupamientos.LayoutData = ap.GetLayout();			
			txtVisualizacion.Text = String.Empty;
			txtEstado.Text = String.Empty;
			txtDescripcion.Text = String.Empty;
			MouseHelper mouseControler = new MouseHelper();
			mouseControler.Control = ultraExplorerBar1;
			mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
			mouseControler.WheelForward += new MouseEventHandler(ScrollUp);

		}
	
		private void ScrollDown (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageDown);
		}

		private void ScrollUp (object sender, MouseEventArgs e)
		{
			ultraExplorerBar1.PerformAction(UltraExplorerBarAction.ScrollPageUp);
		}

		

		[ IsShowFormMember ]
		public void ShowForm(object id)
		{
			_idProducto = (string)id;	
			Init();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();

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

		#region Codigo generado por el Diseñador de Windows Forms
/*		go generado por el Diseñador de Windows Forms
		>
		sario para admitir el Diseñador. No se puede modificar nido del método con el editor de código.*/
																	/// </summary>
																	private void InitializeComponent()
																				{
																		this.components = new System.ComponentModel.Container();
																		Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
																		Infragistics.Win.UltraWinDataSource.UltraDataBand ultraDataBand1 = new Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1");
																		Infragistics.Win.UltraWinDataSource.UltraDataBand ultraDataBand2 = new Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2");
																		Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sucursal");
																		Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad");
																		Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion");
																		Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad");
																		Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion");
																		Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad");
																		System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaArticulos));
																		Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
																		Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
																		Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
																		this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
																		this.label9 = new System.Windows.Forms.Label();
																		this.label8 = new System.Windows.Forms.Label();
																		this.txtDescripcion = new System.Windows.Forms.TextBox();
																		this.gridEXAgrupamientos = new Janus.Windows.GridEX.GridEX();
																		this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
																		this.uneMaxDesctoConImp = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																		this.label11 = new System.Windows.Forms.Label();
																		this.unePrecioListaConImp = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																		this.label10 = new System.Windows.Forms.Label();
																		this.unePrecioNeto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																		this.label7 = new System.Windows.Forms.Label();
																		this.uneMaxDescto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																		this.label6 = new System.Windows.Forms.Label();
																		this.unePrecioBruto = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																		this.label5 = new System.Windows.Forms.Label();
																		this.unePrecioNetoConImp = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																		this.label2 = new System.Windows.Forms.Label();
																		this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
																		this.ultraGridStock = new Infragistics.Win.UltraWinGrid.UltraGrid();
																		this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource();
																		this.groupBox1 = new System.Windows.Forms.GroupBox();
																		this.uneStock = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
																		this.txtEstado = new System.Windows.Forms.TextBox();
																		this.txtVisualizacion = new System.Windows.Forms.TextBox();
																		this.label4 = new System.Windows.Forms.Label();
																		this.label3 = new System.Windows.Forms.Label();
																		this.label1 = new System.Windows.Forms.Label();
																		this.imglStandar = new System.Windows.Forms.ImageList(this.components);
																		this.toolBarStandar = new System.Windows.Forms.ToolBar();
																		this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
																		this.panel1 = new System.Windows.Forms.Panel();
																		this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
																		this.ultraExplorerBarContainerControl3.SuspendLayout();
																		((System.ComponentModel.ISupportInitialize)(this.gridEXAgrupamientos)).BeginInit();
																		this.ultraExplorerBarContainerControl1.SuspendLayout();
																		((System.ComponentModel.ISupportInitialize)(this.uneMaxDesctoConImp)).BeginInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioListaConImp)).BeginInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioNeto)).BeginInit();
																		((System.ComponentModel.ISupportInitialize)(this.uneMaxDescto)).BeginInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioBruto)).BeginInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioNetoConImp)).BeginInit();
																		this.ultraExplorerBarContainerControl2.SuspendLayout();
																		((System.ComponentModel.ISupportInitialize)(this.ultraGridStock)).BeginInit();
																		((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
																		this.groupBox1.SuspendLayout();
																		((System.ComponentModel.ISupportInitialize)(this.uneStock)).BeginInit();
																		this.panel1.SuspendLayout();
																		((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
																		this.ultraExplorerBar1.SuspendLayout();
																		this.SuspendLayout();
																		// 
																		// ultraExplorerBarContainerControl3
																		// 
																		this.ultraExplorerBarContainerControl3.Controls.Add(this.label9);
																		this.ultraExplorerBarContainerControl3.Controls.Add(this.label8);
																		this.ultraExplorerBarContainerControl3.Controls.Add(this.txtDescripcion);
																		this.ultraExplorerBarContainerControl3.Controls.Add(this.gridEXAgrupamientos);
																		this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, -83);
																		this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
																		this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(846, 82);
																		this.ultraExplorerBarContainerControl3.TabIndex = 2;
																		// 
																		// label9
																		// 
																		this.label9.BackColor = System.Drawing.Color.Transparent;
																		this.label9.Location = new System.Drawing.Point(1, 24);
																		this.label9.Name = "label9";
																		this.label9.Size = new System.Drawing.Size(87, 16);
																		this.label9.TabIndex = 28;
																		this.label9.Text = "Agrupamientos";
																		// 
																		// label8
																		// 
																		this.label8.BackColor = System.Drawing.Color.Transparent;
																		this.label8.Location = new System.Drawing.Point(0, 3);
																		this.label8.Name = "label8";
																		this.label8.Size = new System.Drawing.Size(69, 16);
																		this.label8.TabIndex = 27;
																		this.label8.Text = "Descripción";
																		// 
																		// txtDescripcion
																		// 
																		this.txtDescripcion.BackColor = System.Drawing.Color.White;
																		this.txtDescripcion.Location = new System.Drawing.Point(101, 0);
																		this.txtDescripcion.Name = "txtDescripcion";
																		this.txtDescripcion.ReadOnly = true;
																		this.txtDescripcion.Size = new System.Drawing.Size(376, 20);
																		this.txtDescripcion.TabIndex = 0;
																		this.txtDescripcion.Text = "txtDescripcion";
																		// 
																		// gridEXAgrupamientos
																		// 
																		this.gridEXAgrupamientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
																		this.gridEXAgrupamientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
																			| System.Windows.Forms.AnchorStyles.Right)));
																		this.gridEXAgrupamientos.Cursor = System.Windows.Forms.Cursors.Default;
																		this.gridEXAgrupamientos.GroupByBoxInfoText = "";
																		this.gridEXAgrupamientos.GroupByBoxVisible = false;
																		this.gridEXAgrupamientos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
																		this.gridEXAgrupamientos.LayoutData = "<GridEXLayoutData><RootTable><Columns Collection=\"true\"><Column0 ID=\"IdProducto\">" +
																			"<Caption>IdProducto</Caption><DataMember>IdProducto</DataMember><Key>IdProducto<" +
																			"/Key><Position>0</Position><Visible>False</Visible></Column0><Column1 ID=\"Jerarq" +
																			"uia\"><Caption>Jerarquia</Caption><DataMember>Jerarquia</DataMember><Key>Jerarqui" +
																			"a</Key><Position>1</Position><Visible>False</Visible></Column1><Column2 ID=\"Fech" +
																			"aCreacion\"><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember" +
																			"><Key>FechaCreacion</Key><Position>2</Position><Visible>False</Visible></Column2" +
																			"><Column3 ID=\"IdConexionCreacion\"><Caption>IdConexionCreacion</Caption><DataMemb" +
																			"er>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>3</Posi" +
																			"tion><Visible>False</Visible></Column3><Column4 ID=\"UltimaModificacion\"><Caption" +
																			">UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>Ult" +
																			"imaModificacion</Key><Position>4</Position><Visible>False</Visible></Column4><Co" +
																			"lumn5 ID=\"IdConexionUltimaModificacion\"><Caption>IdConexionUltimaModificacion</C" +
																			"aption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltim" +
																			"aModificacion</Key><Position>5</Position><Visible>False</Visible></Column5><Colu" +
																			"mn6 ID=\"IdReservado\"><Caption>IdReservado</Caption><DataMember>IdReservado</Data" +
																			"Member><Key>IdReservado</Key><Position>6</Position><Visible>False</Visible></Col" +
																			"umn6><Column7 ID=\"RowId\"><Caption>RowId</Caption><DataMember>RowId</DataMember><" +
																			"Key>RowId</Key><Position>7</Position><Visible>False</Visible></Column7><Column8 " +
																			"ID=\"IdEmpresa\"><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Ke" +
																			"y>IdEmpresa</Key><Position>8</Position><Visible>False</Visible></Column8><Column" +
																			"9 ID=\"Descripcion\"><Caption>Descripcion</Caption><DataMember>Descripcion</DataMe" +
																			"mber><Key>Descripcion</Key><Position>9</Position><Width>98</Width></Column9></Co" +
																			"lumns><GroupCondition ID=\"\" /><SortKeys Collection=\"true\"><SortKey0 ID=\"SortKey0" +
																			"\"><ColIndex>9</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
																		this.gridEXAgrupamientos.Location = new System.Drawing.Point(101, 22);
																		this.gridEXAgrupamientos.Name = "gridEXAgrupamientos";
																		this.gridEXAgrupamientos.Size = new System.Drawing.Size(370, 58);
																		this.gridEXAgrupamientos.TabIndex = 1;
																		// 
																		// ultraExplorerBarContainerControl1
																		// 
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.uneMaxDesctoConImp);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.label11);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.unePrecioListaConImp);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.label10);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.unePrecioNeto);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.uneMaxDescto);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.unePrecioBruto);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.unePrecioNetoConImp);
																		this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
																		this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 58);
																		this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
																		this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(846, 82);
																		this.ultraExplorerBarContainerControl1.TabIndex = 0;
																		// 
																		// uneMaxDesctoConImp
																		// 
																		this.uneMaxDesctoConImp.FormatString = "0.00";
																		this.uneMaxDesctoConImp.Location = new System.Drawing.Point(526, 27);
																		this.uneMaxDesctoConImp.MaxValue = 2147483647.99;
																		this.uneMaxDesctoConImp.MinValue = -21474836.99;
																		this.uneMaxDesctoConImp.Name = "uneMaxDesctoConImp";
																		this.uneMaxDesctoConImp.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																		this.uneMaxDesctoConImp.PromptChar = ' ';
																		this.uneMaxDesctoConImp.ReadOnly = true;
																		this.uneMaxDesctoConImp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
																		this.uneMaxDesctoConImp.Size = new System.Drawing.Size(100, 21);
																		this.uneMaxDesctoConImp.TabIndex = 4;
																		// 
																		// label11
																		// 
																		this.label11.BackColor = System.Drawing.Color.Transparent;
																		this.label11.Location = new System.Drawing.Point(325, 29);
																		this.label11.Name = "label11";
																		this.label11.Size = new System.Drawing.Size(200, 16);
																		this.label11.TabIndex = 31;
																		this.label11.Text = "Máximo descuento aplicable";
																		// 
																		// unePrecioListaConImp
																		// 
																		this.unePrecioListaConImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
																		this.unePrecioListaConImp.FormatString = "0.00";
																		this.unePrecioListaConImp.Location = new System.Drawing.Point(526, 3);
																		this.unePrecioListaConImp.MaxValue = 2147483647.99;
																		this.unePrecioListaConImp.MinValue = -21474836.99;
																		this.unePrecioListaConImp.Name = "unePrecioListaConImp";
																		this.unePrecioListaConImp.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																		this.unePrecioListaConImp.PromptChar = ' ';
																		this.unePrecioListaConImp.ReadOnly = true;
																		this.unePrecioListaConImp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
																		this.unePrecioListaConImp.Size = new System.Drawing.Size(100, 21);
																		this.unePrecioListaConImp.TabIndex = 3;
																		// 
																		// label10
																		// 
																		this.label10.BackColor = System.Drawing.Color.Transparent;
																		this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
																		this.label10.Location = new System.Drawing.Point(325, 6);
																		this.label10.Name = "label10";
																		this.label10.Size = new System.Drawing.Size(192, 16);
																		this.label10.TabIndex = 29;
																		this.label10.Text = "Precio de Lista Impuestos Incluidos";
																		this.label10.Click += new System.EventHandler(this.label10_Click);
																		// 
																		// unePrecioNeto
																		// 
																		this.unePrecioNeto.FormatString = "0.00";
																		this.unePrecioNeto.Location = new System.Drawing.Point(173, 52);
																		this.unePrecioNeto.MaxValue = 2147483647.99;
																		this.unePrecioNeto.MinValue = -21474836.99;
																		this.unePrecioNeto.Name = "unePrecioNeto";
																		this.unePrecioNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																		this.unePrecioNeto.PromptChar = ' ';
																		this.unePrecioNeto.ReadOnly = true;
																		this.unePrecioNeto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
																		this.unePrecioNeto.Size = new System.Drawing.Size(100, 21);
																		this.unePrecioNeto.TabIndex = 2;
																		this.unePrecioNeto.ValueChanged += new System.EventHandler(this.unePrecioNeto_ValueChanged);
																		// 
																		// label7
																		// 
																		this.label7.BackColor = System.Drawing.Color.Transparent;
																		this.label7.Location = new System.Drawing.Point(16, 59);
																		this.label7.Name = "label7";
																		this.label7.Size = new System.Drawing.Size(152, 16);
																		this.label7.TabIndex = 27;
																		this.label7.Text = "Precio Mínimo sin Impuestos";
																		this.label7.Click += new System.EventHandler(this.label7_Click);
																		// 
																		// uneMaxDescto
																		// 
																		this.uneMaxDescto.FormatString = "0.00";
																		this.uneMaxDescto.Location = new System.Drawing.Point(173, 27);
																		this.uneMaxDescto.MaxValue = 2147483647.99;
																		this.uneMaxDescto.MinValue = -21474836.99;
																		this.uneMaxDescto.Name = "uneMaxDescto";
																		this.uneMaxDescto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																		this.uneMaxDescto.PromptChar = ' ';
																		this.uneMaxDescto.ReadOnly = true;
																		this.uneMaxDescto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
																		this.uneMaxDescto.Size = new System.Drawing.Size(100, 21);
																		this.uneMaxDescto.TabIndex = 1;
																		// 
																		// label6
																		// 
																		this.label6.BackColor = System.Drawing.Color.Transparent;
																		this.label6.Location = new System.Drawing.Point(16, 32);
																		this.label6.Name = "label6";
																		this.label6.Size = new System.Drawing.Size(152, 16);
																		this.label6.TabIndex = 25;
																		this.label6.Text = "Máximo descuento aplicable";
																		// 
																		// unePrecioBruto
																		// 
																		this.unePrecioBruto.FormatString = "0.00";
																		this.unePrecioBruto.Location = new System.Drawing.Point(173, 3);
																		this.unePrecioBruto.MaxValue = 2147483647.99;
																		this.unePrecioBruto.MinValue = -21474836.99;
																		this.unePrecioBruto.Name = "unePrecioBruto";
																		this.unePrecioBruto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																		this.unePrecioBruto.PromptChar = ' ';
																		this.unePrecioBruto.ReadOnly = true;
																		this.unePrecioBruto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
																		this.unePrecioBruto.Size = new System.Drawing.Size(100, 21);
																		this.unePrecioBruto.TabIndex = 0;
																		// 
																		// label5
																		// 
																		this.label5.BackColor = System.Drawing.Color.Transparent;
																		this.label5.Location = new System.Drawing.Point(16, 6);
																		this.label5.Name = "label5";
																		this.label5.Size = new System.Drawing.Size(160, 16);
																		this.label5.TabIndex = 23;
																		this.label5.Text = "Precio de Lista sin Impuestos";
																		// 
																		// unePrecioNetoConImp
																		// 
																		this.unePrecioNetoConImp.FormatString = "0.00";
																		this.unePrecioNetoConImp.Location = new System.Drawing.Point(526, 52);
																		this.unePrecioNetoConImp.MaxValue = 2147483647.99;
																		this.unePrecioNetoConImp.MinValue = -21474836.99;
																		this.unePrecioNetoConImp.Name = "unePrecioNetoConImp";
																		this.unePrecioNetoConImp.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																		this.unePrecioNetoConImp.PromptChar = ' ';
																		this.unePrecioNetoConImp.ReadOnly = true;
																		this.unePrecioNetoConImp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
																		this.unePrecioNetoConImp.Size = new System.Drawing.Size(100, 21);
																		this.unePrecioNetoConImp.TabIndex = 5;
																		// 
																		// label2
																		// 
																		this.label2.BackColor = System.Drawing.Color.Transparent;
																		this.label2.Location = new System.Drawing.Point(326, 57);
																		this.label2.Name = "label2";
																		this.label2.Size = new System.Drawing.Size(192, 16);
																		this.label2.TabIndex = 17;
																		this.label2.Text = "Precio Mínimo Impuestos Incluidos";
																		// 
																		// ultraExplorerBarContainerControl2
																		// 
																		this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraGridStock);
																		this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox1);
																		this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 199);
																		this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
																		this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(846, 273);
																		this.ultraExplorerBarContainerControl2.TabIndex = 1;
																		// 
																		// ultraGridStock
																		// 
																		this.ultraGridStock.Cursor = System.Windows.Forms.Cursors.Default;
																		this.ultraGridStock.DataSource = this.ultraDataSource1;
																		appearance1.BackColor = System.Drawing.Color.White;
																		this.ultraGridStock.DisplayLayout.Appearance = appearance1;
																		this.ultraGridStock.Dock = System.Windows.Forms.DockStyle.Fill;
																		this.ultraGridStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
																		this.ultraGridStock.Location = new System.Drawing.Point(0, 0);
																		this.ultraGridStock.Name = "ultraGridStock";
																		this.ultraGridStock.Size = new System.Drawing.Size(846, 273);
																		this.ultraGridStock.TabIndex = 0;
																		// 
																		// ultraDataSource1
																		// 
																		ultraDataBand2.Columns.AddRange(new object[] {
																														 ultraDataColumn1,
																														 ultraDataColumn2});
																		ultraDataBand1.ChildBands.AddRange(new object[] {
																															ultraDataBand2});
																		ultraDataBand1.Columns.AddRange(new object[] {
																														 ultraDataColumn3,
																														 ultraDataColumn4});
																		this.ultraDataSource1.Band.ChildBands.AddRange(new object[] {
																																		ultraDataBand1});
																		this.ultraDataSource1.Band.Columns.AddRange(new object[] {
																																	 ultraDataColumn5,
																																	 ultraDataColumn6});
																		// 
																		// groupBox1
																		// 
																		this.groupBox1.BackColor = System.Drawing.Color.Transparent;
																		this.groupBox1.Controls.Add(this.uneStock);
																		this.groupBox1.Controls.Add(this.txtEstado);
																		this.groupBox1.Controls.Add(this.txtVisualizacion);
																		this.groupBox1.Controls.Add(this.label4);
																		this.groupBox1.Controls.Add(this.label3);
																		this.groupBox1.Controls.Add(this.label1);
																		this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
																		this.groupBox1.Location = new System.Drawing.Point(0, 0);
																		this.groupBox1.Name = "groupBox1";
																		this.groupBox1.Size = new System.Drawing.Size(846, 273);
																		this.groupBox1.TabIndex = 1;
																		this.groupBox1.TabStop = false;
																		// 
																		// uneStock
																		// 
																		this.uneStock.Location = new System.Drawing.Point(128, 62);
																		this.uneStock.Name = "uneStock";
																		this.uneStock.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
																		this.uneStock.PromptChar = ' ';
																		this.uneStock.ReadOnly = true;
																		this.uneStock.Size = new System.Drawing.Size(100, 21);
																		this.uneStock.TabIndex = 30;
																		// 
																		// txtEstado
																		// 
																		this.txtEstado.BackColor = System.Drawing.Color.White;
																		this.txtEstado.Location = new System.Drawing.Point(128, 40);
																		this.txtEstado.Name = "txtEstado";
																		this.txtEstado.ReadOnly = true;
																		this.txtEstado.Size = new System.Drawing.Size(144, 20);
																		this.txtEstado.TabIndex = 4;
																		this.txtEstado.Text = "txtEstado";
																		// 
																		// txtVisualizacion
																		// 
																		this.txtVisualizacion.BackColor = System.Drawing.Color.White;
																		this.txtVisualizacion.Location = new System.Drawing.Point(128, 17);
																		this.txtVisualizacion.Name = "txtVisualizacion";
																		this.txtVisualizacion.ReadOnly = true;
																		this.txtVisualizacion.Size = new System.Drawing.Size(144, 20);
																		this.txtVisualizacion.TabIndex = 3;
																		this.txtVisualizacion.Text = "txtVisualizacion";
																		// 
																		// label4
																		// 
																		this.label4.Location = new System.Drawing.Point(8, 41);
																		this.label4.Name = "label4";
																		this.label4.Size = new System.Drawing.Size(96, 20);
																		this.label4.TabIndex = 2;
																		this.label4.Text = "Estado de stock";
																		// 
																		// label3
																		// 
																		this.label3.Location = new System.Drawing.Point(8, 18);
																		this.label3.Name = "label3";
																		this.label3.Size = new System.Drawing.Size(120, 20);
																		this.label3.TabIndex = 1;
																		this.label3.Text = "Visualizacion de stock";
																		// 
																		// label1
																		// 
																		this.label1.Location = new System.Drawing.Point(8, 65);
																		this.label1.Name = "label1";
																		this.label1.Size = new System.Drawing.Size(40, 20);
																		this.label1.TabIndex = 0;
																		this.label1.Text = "Stock";
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
																																						  this.toolBarButton12});
																		this.toolBarStandar.DropDownArrows = true;
																		this.toolBarStandar.ImageList = this.imglStandar;
																		this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
																		this.toolBarStandar.Name = "toolBarStandar";
																		this.toolBarStandar.ShowToolTips = true;
																		this.toolBarStandar.Size = new System.Drawing.Size(912, 28);
																		this.toolBarStandar.TabIndex = 20;
																		this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
																		this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
																		// 
																		// toolBarButton12
																		// 
																		this.toolBarButton12.ImageIndex = 5;
																		this.toolBarButton12.Text = "Actualizar";
																		// 
																		// panel1
																		// 
																		this.panel1.Controls.Add(this.ultraExplorerBar1);
																		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
																		this.panel1.Location = new System.Drawing.Point(0, 28);
																		this.panel1.Name = "panel1";
																		this.panel1.Size = new System.Drawing.Size(912, 497);
																		this.panel1.TabIndex = 21;
																		// 
																		// ultraExplorerBar1
																		// 
																		this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
																		this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
																		this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
																		this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
																		ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
																		ultraExplorerBarGroup1.Settings.ContainerHeight = 82;
																		ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
																		ultraExplorerBarGroup1.Text = "Información principal";
																		ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
																		ultraExplorerBarGroup2.Settings.ContainerHeight = 82;
																		ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
																		ultraExplorerBarGroup2.Text = "Precios";
																		ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
																		ultraExplorerBarGroup3.Settings.ContainerHeight = 273;
																		ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
																		ultraExplorerBarGroup3.Text = "Stock";
																		this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																																													ultraExplorerBarGroup1,
																																													ultraExplorerBarGroup2,
																																													ultraExplorerBarGroup3});
																		this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
																		this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
																		this.ultraExplorerBar1.Size = new System.Drawing.Size(912, 497);
																		this.ultraExplorerBar1.TabIndex = 2;
																		// 
																		// FrmConsultaArticulos
																		// 
																		this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
																		this.BackColor = System.Drawing.SystemColors.Control;
																		this.ClientSize = new System.Drawing.Size(912, 525);
																		this.Controls.Add(this.panel1);
																		this.Controls.Add(this.toolBarStandar);
																		this.Name = "FrmConsultaArticulos";
																		this.Text = "Consulta de artículos";
																		this.ultraExplorerBarContainerControl3.ResumeLayout(false);
																		((System.ComponentModel.ISupportInitialize)(this.gridEXAgrupamientos)).EndInit();
																		this.ultraExplorerBarContainerControl1.ResumeLayout(false);
																		((System.ComponentModel.ISupportInitialize)(this.uneMaxDesctoConImp)).EndInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioListaConImp)).EndInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioNeto)).EndInit();
																		((System.ComponentModel.ISupportInitialize)(this.uneMaxDescto)).EndInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioBruto)).EndInit();
																		((System.ComponentModel.ISupportInitialize)(this.unePrecioNetoConImp)).EndInit();
																		this.ultraExplorerBarContainerControl2.ResumeLayout(false);
																		((System.ComponentModel.ISupportInitialize)(this.ultraGridStock)).EndInit();
																		((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
																		this.groupBox1.ResumeLayout(false);
																		((System.ComponentModel.ISupportInitialize)(this.uneStock)).EndInit();
																		this.panel1.ResumeLayout(false);
																		((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
																		this.ultraExplorerBar1.ResumeLayout(false);
																		this.ResumeLayout(false);

																	}
		#endregion

		private string _idProducto = String.Empty;

		private void ActualizarInformacion() 
		{
			/// <summary>
			/// Muestra los distintos precios para el producto seleccionado.
			/// </summary>
			
			businessrules.Productos producto = new mz.erp.businessrules.Productos( _idProducto );
			
			uneMaxDescto.Value = producto.MaximoDescuento;
			unePrecioNeto.Value = producto.PrecioDeVentaNeto;
			unePrecioBruto.Value = producto.PrecioDeVentaBruto;						
			uneMaxDesctoConImp.Value = producto.MaximoDescuentoConImpuestos;
			unePrecioNetoConImp.Value = producto.PrecioNetoConImpuestos;
			unePrecioListaConImp.Value = producto.PrecioBrutoConImpuestos;	
			txtDescripcion.Text = producto.Descripcion;
//			txtDescripcionC.Text = producto.DescripcionCorta;
//			txtDescripcionL.Text = producto.DescripcionLarga;
		}

		private void ActualizarStock() 
		{			
			/// <summary>
			/// De acuerdo al código de producto muestra en la grilla los distintos visualizaciones de stock permitidas, agrupado por estados, y luego agrupado por sucursales. Además muestra el tipo de visualizacion de stock, estado y sucursal por defecto de acuerdo a las variables de configuración.
			/// </summary>
			
			System.Data.DataSet data = businessrules.tlg_Stock.GetList( _idProducto, string.Empty);
			ultraGridStock.DataSource = data;
			
			Infragistics.Win.UltraWinGrid.UltraGridLayout layout = ultraGridStock.DisplayLayout;
			layout.Bands[0].Columns[0].Hidden= true;
			layout.Bands[1].Columns[0].Hidden = true; 
			layout.Bands[1].Columns[1].Hidden = true; 
			layout.Bands[1].Columns[2].Hidden = true; 
			layout.Bands[1].Columns[3].Hidden = true; 
			layout.Bands[2].Columns[0].Hidden = true; 			

			string IdVisualizacionDeStock = Variables.GetValue("Stock.VisualizacionDeStock.Default").ToString();
			string IdEstadoDeStock = Variables.GetValue("Stock.EstadoDeStock.Default").ToString();
			decimal stock = businessrules.Stock.GetStock(IdVisualizacionDeStock, IdEstadoDeStock, _idProducto, false);
			tlg_VisualizacionDeStockDataset.tlg_VisualizacionDeStockRow rowVS = mz.erp.businessrules.tlg_VisualizacionDeStock.GetByPk(IdVisualizacionDeStock);
			tlg_EstadosDeStockDataset.tlg_EstadosDeStockRow rowES = mz.erp.businessrules.tlg_EstadosDeStock.GetByPk(IdEstadoDeStock);
			
			if (rowVS != null && rowES != null)
			{
				txtVisualizacion.Text = rowVS.Descripcion;
				txtEstado.Text = rowES.Descripcion;
				uneStock.Value = stock;
			}
		}

		private void ActualizarAgrupamientos() 
		{			
			/// <summary>
			/// Muestra todos los tipos de agrupamientos que posee el producto seleccionado.
			/// </summary>
			mz.erp.ui.forms.classes.tsh_AgrupProductos ap = new mz.erp.ui.forms.classes.tsh_AgrupProductos();		
			gridEXAgrupamientos.DataSource = ap.GetList( _idProducto );														
		}

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
		
		}

		private void RefreshData()
		{
			Init();
		}

		private void Init()
		{
			ActualizarInformacion();
			ActualizarAgrupamientos();			
			ActualizarStock();			
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					RefreshData();
					break;					
			}		
		}

		private void label7_Click(object sender, System.EventArgs e)
		{
		
		}

		private void unePrecioNeto_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void label10_Click(object sender, System.EventArgs e)
		{
		
		}

		/*private void gridEXStock_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}

		private void ultraDataSource1_CellDataRequested(object sender, Infragistics.Win.UltraWinDataSource.CellDataRequestedEventArgs e)
		{
		
		}*/
			
	}
}

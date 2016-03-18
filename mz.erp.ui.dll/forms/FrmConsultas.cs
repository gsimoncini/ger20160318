using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using mz.erp.ui.controls;

using mz.erp.commontypes;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using mz.erp.ui.utility;

using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultas.
	/// </summary>
	public class FrmConsultas : System.Windows.Forms.Form , ISearchObjectListener, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem Detalles;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private System.Windows.Forms.MenuItem ExportarAExcel;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.ComponentModel.IContainer components;

		


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
				_uiController = null;
				_filtros = null;
				DisposeControls();
			}
			base.Dispose( disposing );
		}

		private void DisposeControls()
		{
			foreach(Control control in this.ContainerFiltro.Controls)
			{
				control.DataBindings.Clear();
			}			
		}

		#region Implemetancion Interface ISearchObjectListener
		public void processEventChange(object sender , EventArgs e)
		{
			RefreshData();
		}
		
		#endregion

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultas));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.Detalles = new System.Windows.Forms.MenuItem();
			this.ExportarAExcel = new System.Windows.Forms.MenuItem();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(822, 24);
			this.ultraExplorerBarContainerControl1.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(822, 23);
			this.labelTarea.TabIndex = 2;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContainerFiltro
			// 
			this.ContainerFiltro.Location = new System.Drawing.Point(28, 107);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(822, 146);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 312);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(822, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(822, 24);
			this.gridManagerView1.TabIndex = 52;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.ContextMenu = this.contextMenu1;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 24);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(784, 128);
			this.gridResultado.TabIndex = 0;
			this.gridResultado.DoubleClick += new System.EventHandler(this.gridResultado_DoubleClick);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.Detalles,
																						 this.ExportarAExcel});
			// 
			// Detalles
			// 
			this.Detalles.Index = 0;
			this.Detalles.Text = "Ver detalles";
			this.Detalles.Click += new System.EventHandler(this.Detalles_Click);
			// 
			// ExportarAExcel
			// 
			this.ExportarAExcel.Index = 1;
			this.ExportarAExcel.Text = "Exportar A Excel";
			this.ExportarAExcel.Click += new System.EventHandler(this.ExportarAExcel_Click);
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.richInfoComprobante);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 301);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(782, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 3;
			// 
			// richInfoComprobante
			// 
			this.richInfoComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
			this.richInfoComprobante.Name = "richInfoComprobante";
			this.richInfoComprobante.Size = new System.Drawing.Size(782, 150);
			this.richInfoComprobante.TabIndex = 90;
			this.richInfoComprobante.Text = "";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.toolBarButton11,
																							  this.toolBarButton12,
																							  this.toolBarButton13,
																							  this.toolBarButton14,
																							  this.toolBarButton16,
																							  this.toolBarButton7,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(888, 28);
			this.toolBarStandar.TabIndex = 19;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 10;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 11;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 2;
			this.toolBarButton12.Text = "Ejecutar Consulta [F5]";
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton14
			// 
			this.toolBarButton14.ImageIndex = 5;
			this.toolBarButton14.Text = "Reiniciar Filtros de Busqueda";
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 9;
			this.toolBarButton16.Text = "&Selección";
			this.toolBarButton16.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(888, 402);
			this.panel1.TabIndex = 20;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ContainerFiltro);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ContainerFiltro;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 146;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtro Inicial";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Contenido del Comprobante";
			ultraExplorerBarGroup4.Visible = false;
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(888, 402);
			this.ultraExplorerBar1.TabIndex = 1;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// FrmConsultas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(888, 430);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmConsultas";
			this.Text = "Comprobantes";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultas_KeyDown);
			this.Load += new System.EventHandler(this.FrmConsultas_Load);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region MetodosYPropiedadesPublicas

		#region variables de formato de grilla
		
		private ArrayList _grupos;
		private bool _editGrupos = false;
		private string _filaSum = string.Empty;
		
		public ArrayList Grupos
		{
			set{_grupos = value;}
			get{return _grupos;}
		}
		public bool EditGrupos
		{
			set{_editGrupos = value;}
			get{return _editGrupos;}
		}
		public string FilaSum
		{
			set{_filaSum = value;}
			get{return _filaSum;}
		}
		
		#endregion
		
		public void SetProcess(string Proceso)
		{
			bool permiteExportarAExcel = Variables.GetValueBool("Consultas." + Proceso + ".GrillaResultado.PermiteExportarAExcel");
			_allowExportToExcel = permiteExportarAExcel;
			ExportarAExcel.Enabled = permiteExportarAExcel;

		}

		private bool _allowExportToExcel = false;
		
		
		private ReportFilterArray _filtros;
		public bool AllowShowDetail
		{
			set
			{
				_allowShowDetails = value;
				//Matias 20100602 - Tarea 14
				this.Detalles.Enabled = _allowShowDetails;
				//Fin Matias 20100602 - Tarea 14
			}
		}

		private bool _mustImprimir;
		public bool MustImprimir
		{
			get
			{
				return _mustImprimir;
			}
			set
			{
				_mustImprimir = value;
			}
		}
		/// <summary>
		///	Determina el filtro del reporte con sus valores default y comportamientos.
		/// </summary>
		public ReportFilterArray Filtros
		{
			set
			{
				_filtros = value;
			}
			get
			{
				return _filtros;
			}
		}
		private bool _allowMultipleSelect = false;
		public bool AllowMultipleSelect
		{
			get
			{
				return _allowMultipleSelect;
			}
			set
			{
				_allowMultipleSelect= true;
			}
		}
		private Type _reportType;
		/// <summary>
		/// Clase que provee los datos del reporte
		/// </summary>
		public Type ReportType
		{
			set
			{
				_reportType = value;
			}
			get
			{
				return _reportType;
			}
		}

		private Type _editType;
		/// <summary>
		/// Clase que posibilita la edición/visualizacion de los datos
		/// </summary>
		public Type EditType
		{
			set
			{
				_editType = value;
			}
			get
			{
				return _reportType;
			}
		}
		private Type _stepType;
		/// <summary>
		/// Clase que permite realizar el proximo paso para el comprobante seleccionado
		/// </summary>
		public Type StepType
		{
			set
			{
				_stepType = value;
			}
			get
			{
				return _stepType;
			}
		}

		public string MomentoStepDefault
		{
			set
			{
				_momentoStepDefault = value;
			}
		}

		private IFormDetail _detailInstance;
		

		private IDetailController _detailControllerInstance;
		public IDetailController DetailControllerInstance
		{
			get{return _detailControllerInstance;}
			set{_detailControllerInstance = value;}
		}


		private mz.erp.ui.controllers.ConsultasController _uiController = null;
		Hashtable _defaultValues = new Hashtable();
		
		

		/// <summary>
		/// Constructor: Permite consultar comprobantes segun diferentes filtros
		/// </summary>
		/// <param name="filtros"> De tipo ReportFilterArray, determina valores default y comportamientos de cada uno de los filtros
		/// </param>
		public FrmConsultas(ReportFilterArray filtros)
		{
			InitializeComponent();
			Init();
			ExportarAExcel.Enabled = false;
		}
		/// <summary>
		/// Contructor: Permite consultar comprobantes segun diferentes filtros, requiere que previamente se hayan definido
		/// las propiedades ReportType, EditType, StepType, en función de las capacidades que se quieran obtener
		/// </summary>
		public FrmConsultas()
		{
			InitializeComponent();
			ExportarAExcel.Enabled = false;
		}
		/// <summary> Contructor: Permite consultar comprobantes según diferentes filtros
		/// </summary>
		/// <param name="filtros"> De tipo ReportFilterArray, determina valores default y comportamientos de cada uno de los filtros
		/// </param>
		/// <param name="reportType"> Tipo de la clase que maneja la consulta de datos
		/// </param>
		public FrmConsultas(ReportFilterArray filtros, Type reportType)
		{
			InitializeComponent();
			_filtros = filtros;
			_reportType = reportType;
			ExportarAExcel.Enabled = false;
		}

		///se usará para para cualquier consulta sobre comprobantes que se quiera hacer,
		///debido a que ConsultasController  es una clase abstracta!
		public FrmConsultas(ConsultasController controller)
		{			
			InitializeComponent();
			_uiController = controller;
			_filtros = _uiController.Filtros;
			ExportarAExcel.Enabled = false;

			//_reportType = _uiController.ReportType;
		}

		/// <summary>
		/// Se usará para todas aquellas ventanas en las q se permita hacer grupos 
		/// </summary>
		/// <param name="filtros"></param>
		/// <param name="reportType"></param>
		/// <param name="grupos">es un array list de string q contiene los nombres de las columnas q se desean editar</param>
		/// <param name="editGrupos"> un bool que indica si se puede o no modificar el grupo que se dejó definido con la variable anterior</param>
		/// <param name="filaSum"> indica si se necesita poner una fila totalizadora; si es "" no totaliza nada, sino debe se un unco string del tipo "importe"</param>
		public FrmConsultas(ReportFilterArray filtros, Type reportType, ArrayList  grupos, bool editGrupos, string filaSum )
		{
			InitializeComponent();
			_filtros = filtros;
			_reportType = reportType;
			_grupos = grupos;
			_editGrupos = editGrupos;
			_filaSum = filaSum;
			ExportarAExcel.Enabled = false;
		}

		public new virtual void Show()
		{
			Init();
			try
			{
				LoadDefaultValues();	
				base.Show();				
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		#endregion

		#region MetodosYPropiedadesPrivadas

		private bool _allowShowDetails = false;
		private string _defaultValueComprobantesAgrupados;
		private object instanceReport;
		private MethodBase _refreshData;
		private MethodBase _layoutData;
		private MethodBase _editData;
		private MethodBase _stepData;

		private int iniX = 3;
		private int iniY = 3;
		private int desplazamientotexto = 150;
		private int factordealtura = 21;
		private ArrayList _parametros = new ArrayList();

		private bool _changeSort = false;

		private string _momentoStepDefault = null;

		private string _idTipoDeComprobante ;
		private string LayoutVacio = "<GridEXLayoutData></GridEXLayoutData>";

		private void ValueChanged( object sender, System.EventArgs e)
		{
			if (sender.GetType() == typeof(mz.erp.ui.controls.mzProveedoresControl))
			{
				string codigoProveedor = (string)((mz.erp.ui.controls.mzProveedoresControl)sender).DataValue;
				mz.erp.businessrules.Proveedor proveedor = new mz.erp.businessrules.Proveedor();
				proveedor.GetCuenta_CodigoProveedor(codigoProveedor);
				string idProveedor = proveedor.IdProveedor;
				_parametros[((Control)sender).TabIndex] = idProveedor;
			}
	        if (sender.GetType() == typeof(mz.erp.ui.controls.mzComboSearchEditor))
			{
				_parametros[((Control)sender).TabIndex] = (string)((mz.erp.ui.controls.mzComboSearchEditor)sender).DataValue;
			}
			if (sender.GetType() == typeof(mz.erp.ui.controls.mzComboEditor))
			{
                //Cristian Tarea 0000010 20110224
			    if (((Control)sender).Name == "mzComboSearchDeposito")
			    {
			       
                   foreach (Control control in this.ContainerFiltro.Controls)
                   {
                   if (control.Name.Equals("mzComboSearchSeccion"))
                   {

                       ((mz.erp.ui.controls.mzComboEditor) control).FillFromDataSource(
                           businessrules.tlg_Secciones.GetList(
                               (((mz.erp.ui.controls.mzComboEditor) sender).Value.ToString()), true).
                               tlg_Secciones,
            "idSeccion", "Descripcion", 8, "Descripcion");
                   
                   }
                    }   
			    }

                _parametros[((Control)sender).TabIndex] = Convert.ToString(((mz.erp.ui.controls.mzComboEditor)sender).Value);					
                 //Fin Cristian
			}
            //Cristian Tarea 0000146 20110721
			if (sender.GetType() == typeof(Infragistics.Win.UltraWinSchedule.UltraCalendarCombo))
			{
                //Cristian Tsrea 0000050 20110310
                //Cristian Tarea 0000146 20110721
                ArrayList controlesFechas = new ArrayList();
                foreach (Control control in this.ContainerFiltro.Controls)
                {
                    Console.WriteLine("Verificando Componente ... " + control.Name);
                    if (control.Name.Contains("ultraCalendarCombo"))
                    {
                        Console.WriteLine("Componente fecha Agregado: " + control.Name);
                        controlesFechas.Add(control.Name);
                    }
                }

                controlesFechas.Sort();

                String nombreCalendarDesde = (String) controlesFechas[0];
                String nombreCalendarHasta = String.Empty;
                if (controlesFechas.Count > 1) {  nombreCalendarHasta =  (String)controlesFechas[1]; }
                //String nombreCalendarHasta = "";// (String)controlesFechas[1];
                /*
                if (((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Name == "ultraCalendarCombo1")
                {
                    nombreCalendarDesde = "ultraCalendarCombo" + ((Control)sender).TabIndex;
                    nombreCalendarHasta = "ultraCalendarCombo" + (((Control)sender).TabIndex + 1);
                }
                else {
                    nombreCalendarDesde = "ultraCalendarCombo" + ( ((Control)sender).TabIndex - 1 );
                    nombreCalendarHasta = "ultraCalendarCombo" + (((Control)sender).TabIndex );
                }
                */
                if (((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value == System.DBNull.Value)
				{
					_parametros[((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).TabIndex] = System.DateTime.MinValue;
				}
				else
				{
					_parametros[((Control)sender).TabIndex] = (System.DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
                    //DateTime fechaInicio = (DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
                    //DateTime fechaFin = (DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value;
                   Console.WriteLine(((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Name);
                   Console.WriteLine("Nombre de la componente HASTA: "+ nombreCalendarHasta);
                   //Console.WriteLine(((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Name);
                   Console.WriteLine("Nombre de la componente DESDE: " + nombreCalendarDesde);
                    if (((((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Name == nombreCalendarDesde)))
                    {

                        foreach (Control control in this.ContainerFiltro.Controls)
                        {
                            if (control.Name == nombreCalendarHasta)
                            {
                                DateTime fechaInicio = (DateTime) ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
                                DateTime fechaFin =  (DateTime) ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo) control).Value ;
                                if (fechaInicio > fechaFin)
                                {
                                    ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value =
                                        ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
                                }
                                break;

                            }
                        }
                        //Si es una consulta WORKFLOW actualizo la fecha de Fin
                        if (_uiController != null)
                        {
                            _uiController.updateFechas((System.DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value, false);
                        }
                    }
                    else //Si el control que cambio fue FECHA_FIN
                       {
                        /* Silvina 20111212 - Tarea 0000232 */
                           if (((((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Name == nombreCalendarHasta)))
                           {
                           /* Fin Silvina 20111212 - Tarea 0000232 */
                               foreach (Control control in this.ContainerFiltro.Controls)
                               {
                                   if (control.Name == nombreCalendarDesde)
                                   {
                                       DateTime fechaFin = (DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
                                       DateTime fechaInicio = (DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value;
                                       if (fechaInicio > fechaFin)
                                       {
                                           ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value =
                                           ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
                                       }
                                       break;

                                   }
                               }
                               //Si es una consulta WORKFLOW actualizo la fecha de Fin
                               if (_uiController != null)
                               {
                                   _uiController.updateFechas((System.DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value, true);
                               }
                           /* Silvina 20111212 - Tarea 0000232 */
                           }
                           /* Fin Silvina 20111212 - Tarea 0000232 */
                    }
				}
                //Fin cristian Tsrea 0000146
                //Fin Cristian
			}
			if (sender.GetType() == typeof(System.Windows.Forms.ComboBox))
			{
				_parametros[((System.Windows.Forms.ComboBox)sender).TabIndex] =(string)((System.Windows.Forms.ComboBox)sender).Text ;
			}
			if (sender.GetType() == typeof(System.Windows.Forms.TextBox))
			{
				_parametros[((System.Windows.Forms.TextBox)sender).TabIndex] =(string)((System.Windows.Forms.TextBox)sender).Text ;
			}

		}

		private void FiltroEstadoDeStock(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding )
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchEstadoDeStock = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchEstadoDeStock.DataValue = "";
			mzComboSearchEstadoDeStock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchEstadoDeStock.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_EstadosDeStock);
			mzComboSearchEstadoDeStock.Size = new System.Drawing.Size(496, 24);

			mzComboSearchEstadoDeStock.Name = "mzComboSearchEstadoDeStock"+Convert.ToString(order).Trim();
			mzComboSearchEstadoDeStock.TabIndex = order;
			mzComboSearchEstadoDeStock.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchEstadoDeStock.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
			mzComboSearchEstadoDeStock.ValueChanged+= new System.EventHandler( this.ValueChanged );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				
			label.BackColor = System.Drawing.Color.Transparent;
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblEstadoDeStock"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchEstadoDeStock );

			if (defaultValue != null)
			{
				mzComboSearchEstadoDeStock.DataValue= (string)defaultValue;
			}			
		}
		
		private void FiltroSeccion(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding )
		{
            //Cristian Tarea 0000010 20110224
            mz.erp.ui.controls.mzComboEditor mzComboSearchSeccion = new mzComboEditor();

			//mzComboSearchSeccion.DataValue = "";
			mzComboSearchSeccion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			//mzComboSearchSeccion.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_Secciones);
			mzComboSearchSeccion.Size = new System.Drawing.Size(450, 24);

            mzComboSearchSeccion.Name = "mzComboSearchSeccion";//+Convert.ToString(order).Trim();
			mzComboSearchSeccion.TabIndex = order;
			mzComboSearchSeccion.Enabled = false;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchSeccion.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
			mzComboSearchSeccion.ValueChanged+= new System.EventHandler( this.ValueChanged );


            System.Windows.Forms.CheckBox chkSeccion = new System.Windows.Forms.CheckBox();
            chkSeccion.Location = new System.Drawing.Point(iniX + desplazamientotexto + 457, posicionY);
            chkSeccion.Checked = false;
            chkSeccion.Name = "chkSeccion";// +Convert.ToString(order).Trim();
            chkSeccion.CheckStateChanged += new EventHandler(chkSeccion_CheckStateChanged);

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				
			label.BackColor = System.Drawing.Color.Transparent;
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblSeccion"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchSeccion );
            this.ContainerFiltro.Controls.Add(chkSeccion);

            mzComboSearchSeccion.FillFromDataSource(businessrules.tlg_Secciones.GetList("", true).tlg_Secciones,
            "idSeccion", "Descripcion", 8, "Descripcion");
		    //mzComboSearchSeccion.Items.Add("");
			if (defaultValue != null)
			{
				//mzComboSearchSeccion.DataValue= (string)defaultValue;
			}			
            //Fin Cristian
		}
		
		private void FiltroDeposito(int order, string leyenda, bool enabled, object defaultValue , string propertyBinding)
		{
            //Cristian Tarea 0000010 20110224
            mz.erp.ui.controls.mzComboEditor mzComboSearchDeposito = new mz.erp.ui.controls.mzComboEditor();
			mzComboSearchDeposito.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchDeposito.Size = new System.Drawing.Size(450, 24);

			mzComboSearchDeposito.Name = "mzComboSearchDeposito";//+Convert.ToString(order).Trim();
			mzComboSearchDeposito.TabIndex = order;
			mzComboSearchDeposito.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchDeposito.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
			mzComboSearchDeposito.ValueChanged+= new System.EventHandler( this.ValueChanged );
		    mzComboSearchDeposito.Enabled = false;
            System.Windows.Forms.CheckBox chkDeposito = new System.Windows.Forms.CheckBox();
            chkDeposito.Location = new System.Drawing.Point(iniX + desplazamientotexto + 457, posicionY);
            chkDeposito.Checked = false;
            chkDeposito.Name = "chkDeposito" + Convert.ToString(order).Trim();
            chkDeposito.CheckStateChanged += new EventHandler(chkDeposito_CheckStateChanged);
			System.Windows.Forms.Label label = new System.Windows.Forms.Label();


			label.BackColor = System.Drawing.Color.Transparent;
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblDeposito"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchDeposito );
            this.ContainerFiltro.Controls.Add( chkDeposito);
            mzComboSearchDeposito.FillFromDataSource(businessrules.tlg_Depositos.GetList("","","", true).tlg_Depositos,
"idDeposito", "Descripcion", 8, "Descripcion");
            mzComboSearchDeposito.Items.Add("");
			if (defaultValue != null)
			{
				//mzComboSearchDeposito.DataValue= (string)defaultValue;
			}			
            //Fin Cristian
		}
        //Cristian Tarea 0000010 20110224
        void chkDeposito_CheckStateChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)sender;
            bool chequeado = false;
            foreach (Control control in this.ContainerFiltro.Controls)
            {
                if (control.Name.Equals("mzComboSearchDeposito"))
                {

                    control.Enabled = checkbox.Checked;
                    if (!(control.Enabled))
                    {
                        chequeado = true;
                        _parametros[((mz.erp.ui.controls.mzComboEditor)control).TabIndex] = "";
                        ((mz.erp.ui.controls.mzComboEditor) control).Value = "";
                    }
                }
                if (control.Name.Equals("chkSeccion"))
                {
                    if (chequeado)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                   
                }
            }
        }
        void chkSeccion_CheckStateChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)sender;
            foreach (Control control in this.ContainerFiltro.Controls)
            {
                if (control.Name.Equals("mzComboSearchSeccion"))
                {
                    control.Enabled = checkbox.Checked;
                    if (!(control.Enabled))
                    {
                        _parametros[((mz.erp.ui.controls.mzComboEditor)control).TabIndex] = "";
                        ((mz.erp.ui.controls.mzComboEditor)control).Value = "";
                    }
                }
            }
        }
        //fin Cristian
		private void FiltroTipoDeAjuste(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding )
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchTipoDeAjuste = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchTipoDeAjuste.DataValue = "";
			mzComboSearchTipoDeAjuste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchTipoDeAjuste.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_TiposDeAjuste);
			mzComboSearchTipoDeAjuste.Size = new System.Drawing.Size(496, 24);

			mzComboSearchTipoDeAjuste.Name = "mzComboSearchTipoDeAjuste"+Convert.ToString(order).Trim();
			mzComboSearchTipoDeAjuste.TabIndex = order;
			mzComboSearchTipoDeAjuste.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchTipoDeAjuste.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
			mzComboSearchTipoDeAjuste.ValueChanged+= new System.EventHandler( this.ValueChanged );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				
			label.BackColor = System.Drawing.Color.Transparent;
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblTipoDeAjuste"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchTipoDeAjuste );

			if (defaultValue != null)
			{
				mzComboSearchTipoDeAjuste.DataValue= (string)defaultValue;
			}			
		}

		private void FiltroProducto(int order, string leyenda, bool enabled, object defaultValue , string propertyBinding)
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchProducto = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchProducto.DataValue = "";
			mzComboSearchProducto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchProducto.SearchObject = typeof(mz.erp.ui.forms.classes.tsh_Productos);
			mzComboSearchProducto.Size = new System.Drawing.Size(496, 24);

			mzComboSearchProducto.Name = "mzComboSearchProducto"+Convert.ToString(order).Trim();
			mzComboSearchProducto.TabIndex = order;
			mzComboSearchProducto.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchProducto.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
			mzComboSearchProducto.ValueChanged+= new System.EventHandler( this.ValueChanged );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				
			label.BackColor = System.Drawing.Color.Transparent;
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblProducto"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchProducto );

			if (defaultValue != null)
			{
				mzComboSearchProducto.DataValue= (string)defaultValue;
			}		
		}
		private void FiltroCuenta(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchCuenta.DataValue = "";
			mzComboSearchCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchCuenta.SearchObject = typeof( mz.erp.ui.forms.classes.tsa_Cuentas );
			mzComboSearchCuenta.Size = new System.Drawing.Size(496, 24);

			mzComboSearchCuenta.Name = "mzComboSearchCuenta"+Convert.ToString(order).Trim();
			mzComboSearchCuenta.TabIndex = order;
			mzComboSearchCuenta.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchCuenta.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
			mzComboSearchCuenta.ValueChanged+= new System.EventHandler( this.ValueChanged );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			
			label.BackColor = System.Drawing.Color.Transparent;
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchCuenta );

			if (defaultValue != null)
			{
				mzComboSearchCuenta.DataValue= (string)defaultValue;
			}
			else
			{
				if(_uiController != null)
				{
					mzComboSearchCuenta.DataBindings.Add("DataValue",_uiController,propertyBinding);
				}
			}

		}
		private void FiltroTipoDeComprobanteAgrupado(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			System.Windows.Forms.ComboBox comboBoxTipoDeCompAgrupados = new ComboBox();
			if(_listaFamiliaDeComprobantes == null || _listaFamiliaDeComprobantes.Equals(string.Empty))
				comboBoxTipoDeCompAgrupados.Items.AddRange(new object [] {Constantes.TodosLosComprobantes,"Facturas", "Presupuestos",/*"Notas de Débito",*/"Notas de Crédito","Prefacturas","Remitos","Pedidos","Confirmación de Pedido","Preremitos","Recibos"});
			else
			{
					ArrayList aux = new ArrayList();
					aux.Add(Constantes.TodosLosComprobantes);
					aux.AddRange(mz.erp.systemframework.Util.Parse(_listaFamiliaDeComprobantes,","));
					comboBoxTipoDeCompAgrupados.Items.AddRange(aux.ToArray());
					
					
			}
			comboBoxTipoDeCompAgrupados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			comboBoxTipoDeCompAgrupados.Size = new System.Drawing.Size(300,24);
			
			comboBoxTipoDeCompAgrupados.Name = "comboBoxTipoDeCompAgrupados";
			comboBoxTipoDeCompAgrupados.TabIndex = order;
			comboBoxTipoDeCompAgrupados.TextChanged+= new System.EventHandler( this.ValueChanged );
			comboBoxTipoDeCompAgrupados.Enabled = enabled;
			int posicionY = iniY + (factordealtura * order);
			comboBoxTipoDeCompAgrupados.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblTipoComprobanteAgrupado"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( comboBoxTipoDeCompAgrupados);
			comboBoxTipoDeCompAgrupados.SelectedItem = Constantes.TodosLosComprobantes;
			
			if (defaultValue != null)
			{
				comboBoxTipoDeCompAgrupados.SelectedItem = (string)defaultValue;
				_defaultValueComprobantesAgrupados = (string)defaultValue;
			}
			else
			{
				if(_uiController != null)
				{
					comboBoxTipoDeCompAgrupados.DataBindings.Add("Text",_uiController,propertyBinding);
					_defaultValueComprobantesAgrupados = _uiController.FamiliaComprobantes;
				}
			}

		}
		private void FiltroTipoDeComprobanteAgrupadoDV(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			System.Windows.Forms.ComboBox comboBoxTipoDeCompAgrupados = new ComboBox();
			//toma las variables que se tienen en cuenta en la cuenta corriente DV
			if(_listaFamiliaDeComprobantesDV == null || _listaFamiliaDeComprobantesDV.Equals(string.Empty))
				comboBoxTipoDeCompAgrupados.Items.AddRange(new object [] {Constantes.TodosLosComprobantes,"Facturas", "Presupuestos",/*"Notas de Débito",*/"Notas de Crédito","Prefacturas","Remitos","Pedidos","Confirmación de Pedido","Preremitos","Recibos"});
			else
			{
				ArrayList aux = new ArrayList();
				aux.Add(Constantes.TodosLosComprobantes);
				aux.AddRange(mz.erp.systemframework.Util.Parse(_listaFamiliaDeComprobantesDV,","));
				comboBoxTipoDeCompAgrupados.Items.AddRange(aux.ToArray());
					
					
			}
			comboBoxTipoDeCompAgrupados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			comboBoxTipoDeCompAgrupados.Size = new System.Drawing.Size(300,24);
			
			comboBoxTipoDeCompAgrupados.Name = "comboBoxTipoDeCompAgrupados";
			comboBoxTipoDeCompAgrupados.TabIndex = order;
			comboBoxTipoDeCompAgrupados.TextChanged+= new System.EventHandler( this.ValueChanged );
			comboBoxTipoDeCompAgrupados.Enabled = enabled;
			int posicionY = iniY + (factordealtura * order);
			comboBoxTipoDeCompAgrupados.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblTipoComprobanteAgrupado"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( comboBoxTipoDeCompAgrupados);
			comboBoxTipoDeCompAgrupados.SelectedItem = Constantes.TodosLosComprobantesDV;
			
			if (defaultValue != null && _uiController == null)
			{
				comboBoxTipoDeCompAgrupados.SelectedItem = (string)defaultValue;
				_defaultValueComprobantesAgrupados = (string)defaultValue;
			}
			if(_uiController != null)
			{
				comboBoxTipoDeCompAgrupados.DataBindings.Add("Text",_uiController,propertyBinding);
				_defaultValueComprobantesAgrupados = _uiController.FamiliaComprobantes;
			}

		}
		private void FiltroTipoDeComprobante(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboTipoDeComprobante = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboTipoDeComprobante.DataValue = "";
			mzComboTipoDeComprobante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboTipoDeComprobante.SearchObject = typeof(mz.erp.ui.forms.classes.tsy_TiposDeComprobantes);
			mzComboTipoDeComprobante.Size = new System.Drawing.Size(496, 24);

			mzComboTipoDeComprobante.Name = "mzComboTipoDeComprobante"+Convert.ToString(order).Trim();
			mzComboTipoDeComprobante.TabIndex = order;
			mzComboTipoDeComprobante.ValueChanged+= new System.EventHandler( this.ValueChanged );
			mzComboTipoDeComprobante.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboTipoDeComprobante.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblTipoComprobante"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboTipoDeComprobante);
			
			if (defaultValue != null)
			{
				mzComboTipoDeComprobante.DataValue= (string)defaultValue;
			}

		}
		private void FiltroPersona(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchPersona = new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchPersona.DataValue = "";
			mzComboSearchPersona.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchPersona.SearchObject = typeof(mz.erp.ui.forms.classes.tsh_Personas);
			mzComboSearchPersona.Size = new System.Drawing.Size(496, 24);

			mzComboSearchPersona.Name = "mzComboSearchCuenta"+Convert.ToString(order).Trim();
			mzComboSearchPersona.TabIndex = order;
			mzComboSearchPersona.ValueChanged+= new System.EventHandler( this.ValueChanged );
			mzComboSearchPersona.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchPersona.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchPersona );
			if (defaultValue != null)
			{
				mzComboSearchPersona.DataValue= (string)defaultValue;
			}
			else
			{
				if(_uiController != null)
				{
					mzComboSearchPersona.DataBindings.Add("DataValue",_uiController,propertyBinding);
				}
			}

		}
		private void FiltroResponsable(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			mz.erp.ui.controls.mzComboEditor mzComboSearchResponsable = new mzComboEditor();
			//mzComboSearchResponsable.FillFromDataSource = "";
			mzComboSearchResponsable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			//mzComboSearchResponsable SearchObject
			mzComboSearchResponsable.Size = new System.Drawing.Size(496, 24);

			mzComboSearchResponsable.Name = "mzComboSearchResponsable"+Convert.ToString(order).Trim();
			mzComboSearchResponsable.TabIndex = order;
			mzComboSearchResponsable.ValueChanged+= new System.EventHandler( this.ValueChanged );
			mzComboSearchResponsable.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchResponsable.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchResponsable );

			mzComboSearchResponsable.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), 
				"IdUsuario","Nombre",100,"ID","Nombre","Nombre");

			if(_uiController != null)
			{
				mzComboSearchResponsable.DataBindings.Add("Value", _uiController, propertyBinding);
			}


		}

		private void FiltroEstadoOrdenReparacion(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding, DataTable table)
		{
			mz.erp.ui.controls.mzComboEditor mzComboSearchEstadoOrdenReparacion = new mzComboEditor();
			mzComboSearchEstadoOrdenReparacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchEstadoOrdenReparacion.Size =  new System.Drawing.Size(300,24);

			mzComboSearchEstadoOrdenReparacion.Name = "mzComboSearchEstadoOrdenReparacion"+Convert.ToString(order).Trim();
			mzComboSearchEstadoOrdenReparacion.TabIndex = order;			
			mzComboSearchEstadoOrdenReparacion.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchEstadoOrdenReparacion.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchEstadoOrdenReparacion );
			if(table == null)
			{
				mzComboSearchEstadoOrdenReparacion.FillFromDataSource(mz.erp.businessrules.st_EstadoOrdenReparacion.GetList(string.Empty).Tables[0], 
					"IdEstadoOrdenReparacion","Descripcion",100,"ID","Descripcion","Descripcion");
			}
			else 
			{
				mzComboSearchEstadoOrdenReparacion.FillFromDataSource(table, 
					"Codigo","Descripcion",100,"ID","Descripcion","Descripcion");
			}

			if(_uiController != null)
			{
				mzComboSearchEstadoOrdenReparacion.DataBindings.Add("Value", _uiController, propertyBinding);
			}
			else 
			{
				mzComboSearchEstadoOrdenReparacion.ValueChanged+= new System.EventHandler( this.ValueChanged );
			}

		}

		private void FiltroProveedor(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			mz.erp.ui.controls.mzProveedoresControl mzComboSearchProveedor = new mz.erp.ui.controls.mzProveedoresControl();
			mzComboSearchProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchProveedor.BackColor = System.Drawing.SystemColors.Control;
			mzComboSearchProveedor.DataValue = "";
			mzComboSearchProveedor.EnableCtaCte = true;
			mzComboSearchProveedor.FastSearch = false;
			mzComboSearchProveedor.Name = "mzComboSearchProveedor"+Convert.ToString(order).Trim();
			mzComboSearchProveedor.SearchObjectListener = null;
			mzComboSearchProveedor.Size = new System.Drawing.Size(490, 22);
			mzComboSearchProveedor.TabIndex = order;
			mzComboSearchProveedor.Visible = true;
			mzComboSearchProveedor.ValueChanged+= new System.EventHandler( this.ValueChanged );
			mzComboSearchProveedor.Enabled = enabled;
			mzComboSearchProveedor.Init();

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchProveedor.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchProveedor );
			if (defaultValue != null)
			{
				mzComboSearchProveedor.DataValue= (string)defaultValue;
			}
			else
			{
				if(_uiController != null)
				{
					mzComboSearchProveedor.DataBindings.Add("DataValue", _uiController, propertyBinding);
				}
			}
		}

		private void FiltroTextBox(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			int posicionY = iniY + (factordealtura * order);
			System.Windows.Forms.TextBox text = new TextBox();
			text.TextChanged+= new System.EventHandler( this.ValueChanged);						
			text.TabIndex = order;
			text.BackColor = System.Drawing.Color.White;
			text.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			text.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			text.Text = Convert.ToString(defaultValue);
			text.Visible = true;
			text.Enabled = true;

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

			text.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY);
			text.Name = "txtTextBox"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( text );
			if(_uiController != null)
			{
				text.DataBindings.Add("Text", _uiController, propertyBinding);
			}

		}

		private void FiltroCheckBox(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			int posicionY = iniY + (factordealtura * order);
			System.Windows.Forms.CheckBox text = new CheckBox();
			text.CheckedChanged+= new System.EventHandler( this.ValueChanged);						
			text.TabIndex = order;
			text.BackColor = System.Drawing.Color.Transparent;
			text.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
			text.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			text.Checked = Convert.ToBoolean(defaultValue);
			text.Visible = true;
			text.Enabled = true;

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			text.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY);
			text.Name = "checkBox"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( text );
			if(_uiController != null)
			{
				text.DataBindings.Add("Checked", _uiController, propertyBinding);
			}

		}


		private void FiltroFecha( int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			Infragistics.Win.UltraWinSchedule.UltraCalendarCombo calendar = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
			Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
			dateButton.Caption = "Hoy";
			calendar.DateButtons.Add(dateButton);
			calendar.NonAutoSizeHeight = 23;
			
			int posicionY = iniY + (factordealtura * order);
			calendar.Name = "ultraCalendarCombo"+Convert.ToString(order).Trim();
			calendar.Size = new System.Drawing.Size(96, 21);
			calendar.TabIndex = order;
			calendar.Location = new System.Drawing.Point( iniX+ desplazamientotexto, posicionY );
			calendar.ValueChanged+= new System.EventHandler( this.ValueChanged );
			calendar.Enabled = enabled;

			
			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( calendar);

			if (defaultValue != null)
			{
				calendar.Value = (DateTime)defaultValue;
			}
			else
			{
				if(_uiController != null)
				{
					calendar.DataBindings.Add("Value",_uiController, propertyBinding);		
				}
			}		
		}

		private void FiltroMoneda(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
		{
			mz.erp.ui.controls.mzComboSearchEditor mzComboSearchMoneda= new mz.erp.ui.controls.mzComboSearchEditor();
			mzComboSearchMoneda.DataValue = "";
			mzComboSearchMoneda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			mzComboSearchMoneda.SearchObject = typeof(mz.erp.ui.forms.classes.tfi_Monedas);
			mzComboSearchMoneda.Size = new System.Drawing.Size(496, 24);

			mzComboSearchMoneda.Name = "mzComboSearchMoneda"+Convert.ToString(order).Trim();
			mzComboSearchMoneda.TabIndex = order;
			mzComboSearchMoneda.ValueChanged+= new System.EventHandler( this.ValueChanged );
			mzComboSearchMoneda.Enabled = enabled;

			int posicionY = iniY + (factordealtura * order);
			mzComboSearchMoneda.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

			System.Windows.Forms.Label label = new System.Windows.Forms.Label();
			label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
			label.BackColor = System.Drawing.Color.Transparent;
			
			label.Text = leyenda;
			label.Location = new System.Drawing.Point( iniX, posicionY);
			label.Name = "lblCuenta"+Convert.ToString(order).Trim();
			this.ContainerFiltro.Controls.Add( label );
			this.ContainerFiltro.Controls.Add( mzComboSearchMoneda );
			if (defaultValue != null)
			{
				mzComboSearchMoneda.DataValue = (string)defaultValue;
			}
			else
			{
				if(_uiController != null)
				{
					mzComboSearchMoneda.DataBindings.Add("DataValue", _uiController, propertyBinding);
				}
			}
		}



		private void LoadDefaultValues() 
		{			
			foreach(Control control in this.ContainerFiltro.Controls)
			{
				if (control.GetType() == typeof(Infragistics.Win.UltraWinSchedule.UltraCalendarCombo))
				{
					object key = ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Name;
					object valor = ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value;
					_defaultValues.Add(key, valor);
				}
			}

		}
		
	
		private void Build_UI()
		{						
			string Proceso = "ProcesoConsultarComprobantes";
			string Tarea = "ConsultarComprobantes";

			if(_uiController != null)
			{			
				labelTarea.Text = _uiController.LeyendaFormulario;
				this.Text = _uiController.LeyendaFormulario;				
				//Proceso = _uiController.GetProcessManager().GetProcessName();
				//Tarea = _uiController.GetTaskName();
				tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
				tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
				tbbSiguiente.Enabled = !_uiController.IsLastTask() && !_uiController.IsFlushedState();
				this.gridResultado.DoubleClick -= new System.EventHandler(this.gridResultado_DoubleClick);
				if(_uiController.AllowShowDetail)
				{
					
					this.ultraExplorerBar1.Groups[3].Visible = true;
					this.gridResultado.SelectionChanged +=new EventHandler(gridResultado_SelectionChanged);
				}
				tbbAnterior.Text = _uiController.TextoBotonAnterior;
				tbbSiguiente.Text = _uiController.TextoBotonSiguiente;				
			}
			else
			{
				labelTarea.Text = this.Text;
				tbbAnterior.Enabled = false;
				tbbSiguiente.Enabled = false;
				if(_allowShowDetails)
				{
					this.ultraExplorerBar1.Groups[3].Visible = true;
					this.gridResultado.SelectionChanged +=new EventHandler(gridResultado_SelectionChanged);
				}
			}		

			//gridManagerView1.Configure(Proceso, Tarea, gridResultado);						
			//if (gridResultado.LayoutData == LayoutVacio)
			//{
				gridResultado.Dock = DockStyle.Fill;
				gridManagerView1.Visible = false;
			//}

			if(_uiController != null)
			{
				if(_uiController.Filtros.Count == 0) this.ultraExplorerBar1.Groups[1].Visible = false;
			}	
			else
				if(_filtros.Count == 0)this.ultraExplorerBar1.Groups[1].Visible  = false;
			gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.RowUpdate;
			gridResultado.UpdateOnLeave = true;
			gridResultado.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridResultado_Error);
			gridResultado.SortKeysChanged +=new EventHandler(gridResultado_SortKeysChanged);
			this.KeyPreview = true;
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			KeyDownManager KeyDownMan = new KeyDownManager(this);
			
		}
	
		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.RefreshData();
					break;
			}
		}
			
			
		string _listaFamiliaDeComprobantes = string.Empty;
		string _listaFamiliaDeComprobantesDV = string.Empty;
		private void Init()
		{
			toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);						
			_listaFamiliaDeComprobantes = Variables.GetValueString("Comprobantes.FamiliasDeComprobantes");
			_listaFamiliaDeComprobantesDV = Variables.GetValueString("Comprobantes.FamiliasDeComprobantesDV");
			#region filtros
				for (int i=0;i<=(_filtros.Count-1);i++)
				{
					ReportFilterItem unfiltro = _filtros[i];
					if(unfiltro.Clave.ToUpper().Equals("ESTADOSORDENREPARACION"))
					{
						_parametros.Add( null );
						FiltroEstadoOrdenReparacion(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding, unfiltro.Table );
					}
					if ((unfiltro.Clave.ToUpper() == "ESTADODESTOCK"))
					{
						_parametros.Add( null );
						FiltroEstadoDeStock(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "SECCION"))
					{
						_parametros.Add( null );
						FiltroSeccion(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "DEPOSITO"))
					{
						_parametros.Add( null );
						FiltroDeposito(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "PRODUCTO"))
					{
						_parametros.Add( null );
						FiltroProducto(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "TIPODEAJUSTE"))
					{
						_parametros.Add( null );
						FiltroTipoDeAjuste(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "CUENTA"))
					{
						_parametros.Add( null );
						FiltroCuenta(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "PERSONA"))
					{
						_parametros.Add( null );
						FiltroPersona(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "RESPONSABLE"))
					{
						_parametros.Add( null );
						FiltroResponsable(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "FECHA"))
					{
						_parametros.Add( mz.erp.businessrules.Sistema.DateTime.Now );
						FiltroFecha(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
                    //Cristian Tarea 0000050 20110315
                    if ((unfiltro.Clave.ToUpper() == "FECHAHASTA"))
                    {
                        _parametros.Add(mz.erp.businessrules.Sistema.DateTime.Now);
                        FiltroFecha(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
                    }
                    //Fin Cristian

					if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTE"))
					{
						_parametros.Add( null );
						FiltroTipoDeComprobante(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTEAGRUPADO"))
					{
						_parametros.Add( null );
						FiltroTipoDeComprobanteAgrupado(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTEAGRUPADODV"))
					{
						_parametros.Add( null );
						FiltroTipoDeComprobanteAgrupadoDV(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "PROVEEDOR"))
					{
						_parametros.Add( null );
						FiltroProveedor(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "MONEDA"))
					{
						_parametros.Add( null );
						FiltroMoneda(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "MOMENTO"))
					{
						_parametros.Add( null );
						FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "IDORDENREPARACION"))
					{
						_parametros.Add( null );
						FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "NUMEROCOMPROBANTE"))
					{
						_parametros.Add( null );
						FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "AUX1"))
					{
						_parametros.Add( null );
						FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "NUMERODESERIE"))
					{
						_parametros.Add( null );
						FiltroTextBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "CHECKBOX"))
					{
						_parametros.Add( null );
						FiltroCheckBox(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}


				}
			#endregion
	
				if (_reportType != null)
				{
					instanceReport = Activator.CreateInstance( _reportType );
					foreach( MethodBase mb in _reportType.GetMethods() )
					{
						foreach( Attribute am in mb.GetCustomAttributes( false ) )
						{
							if ( am is mz.erp.ui.controllers.atMethodReportRefreshData )
							{
								_refreshData = mb;
							}
							if ( am is mz.erp.ui.controllers.atMethodLayoutData)
							{
								_layoutData = mb;
							}

						}
					}
				}
				if (_editType != null)
				{
					foreach( MethodBase mb in _editType.GetMethods() )
					{
						foreach( Attribute am in mb.GetCustomAttributes( false ) )
						{
							if ( am is mz.erp.ui.controllers.IsViewFormMember )
							{
								_editData = mb;
							}
						}
					}
				}
				if (_stepType != null)
				{
					foreach( MethodBase mb in _stepType.GetMethods() )
					{
						foreach( Attribute am in mb.GetCustomAttributes( false ) )
						{
							if ( am is mz.erp.ui.controllers.IsNextStepMember )
							{
								_stepData = mb;
							}
						}
					}
				}
				InitHijo();
				Build_UI();
				if(_uiController == null || _uiController.AllowFastSearch)
				{
					RefreshData();
				}

				int altoFiltros = _filtros.Count * factordealtura + 10;
				int altoAnteriorFiltros = this.ContainerFiltro.Height;
				this.ContainerFiltro.SetBounds(this.ContainerFiltro.Location.X, this.ContainerFiltro.Location.Y,	
																this.ContainerFiltro.Size.Width, altoFiltros );
				/*if(altoAnteriorFiltros > altoFiltros)
					this.ultraExplorerBarContainerControl2.Height += (altoAnteriorFiltros-altoFiltros);
					*/
				
				int groupSpacing = this.ultraExplorerBar1.GroupSpacing;
				this.ultraExplorerBarContainerControl2.Height = this.ultraExplorerBar1.Height - (altoFiltros + this.ultraExplorerBarContainerControl1.Height + 3*groupSpacing);
				
		}

		protected virtual void InitHijo() 
		{

			if (_allowMultipleSelect)
			{
				gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			}
			else
			{
				gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			}
			if(_uiController != null)
			{
				if(_uiController.AllowMultipleSelect)
					gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
				
				else
					gridResultado.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;

			}
		}

	
		protected void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);

			if(_uiController == null)
			{
				object[]param =  (object[])_parametros.ToArray();
				System.Data.DataSet data = (System.Data.DataSet)_refreshData.Invoke( instanceReport, param );
				gridResultado.SetDataBinding( null, null );
				gridResultado.SetDataBinding( data.Tables[0], null );
				if(this._allowShowDetails)
				{
					if(gridResultado.RecordCount > 0)
					{
						gridResultado.Row = 0;
						this.gridResultado_SelectionChanged(gridResultado, new EventArgs())	;
					}
				}
				gridResultado.Refetch();
				gridResultado.Refresh();

				if (gridResultado.LayoutData == LayoutVacio)
				{
					if (_layoutData != null)
					{
						gridResultado.LayoutData = (string)_layoutData.Invoke( instanceReport, null );
					}
					else
					{
						gridResultado.RetrieveStructure();
						gridResultado.ResumeLayout();
					}			
				}
			}
			else
			{
				gridResultado.Focus();
				_uiController.RefreshData();
				System.Data.DataTable table = _uiController.Table;

				if (gridResultado.LayoutData == LayoutVacio)
				{
					gridResultado.LayoutData = _uiController.LayoutData;
				}
				gridResultado.SetDataBinding(null, null);
				gridResultado.SetDataBinding(table, null);
				if(this._uiController.AllowShowDetail)
				{
					if(gridResultado.RecordCount > 0)
					{
						gridResultado.Row = 0;
						this.gridResultado_SelectionChanged(gridResultado, new EventArgs())	;
					}
				}
				gridResultado.Refetch();
				gridResultado.Refresh();	

				
			}
			//FormatoGrilla();
            // German 2010105 - Tarea 856
            SetOrden();
            //Fin German 2010105 - Tarea 856
			SetGrupos();
		}

        //German 2010105 - Tarea 856
        private void SetOrden()
        {
            if (_uiController != null)
            {
                gridResultado.RootTable.SortKeys.Clear();
                Janus.Windows.GridEX.GridEXColumn col;
                Janus.Windows.GridEX.GridEXSortKey sortKey;
                string column = null;
                bool ascendente = true;
                foreach(string order in mz.erp.systemframework.Util.Parse(_uiController.OrderBy))
                {
                    if (order.ToUpper().EndsWith(" ASC"))
                    {
                        ascendente = true;
                        column = order.Substring(0, order.Length - 4);
                    }
                    else
                        if (order.ToUpper().EndsWith(" DESC"))
                        {
                            ascendente = false;
                            column = order.Substring(0, order.Length - 5);
                        }
                        else
                            column = order;
                    if (column != null && column != string.Empty)
                    {
                        if (mz.erp.systemframework.Util.ContainsColumn(gridResultado, column))
                        {
                            col = gridResultado.RootTable.Columns[column];
                            sortKey = new Janus.Windows.GridEX.GridEXSortKey(col);
                            if(ascendente)
                                sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending;
                            else
                                sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Descending;
                            try
                            {
                                gridResultado.RootTable.SortKeys.Add(sortKey);
                            }
                            catch (Exception e)
                            {
                            }
                        }
                    }
                }
                
                            
            }
        }
        //Fin German 2010105 - Tarea 856

		private bool ContainsColumn(string key)
		{
			foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
			{
				if(col.Key.Equals(key))
					return true;
			}
			return false;
							
		}

		private void SetGrupos()
		{
			if(_uiController == null)
			{
				if ( _grupos!= null && _grupos.Count > 0 )
				{
					//BORRO LOS GRUPOS ANTERIORES
					this.gridResultado.RootTable.Groups.Clear();
					//AGREGO LOS GRUPOS
					foreach(string str in _grupos)
					{
						this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns[str]));
					}
				}
				//DEJO EDITABLE O NO LOS GRUPOS
				this.gridResultado.GroupByBoxVisible= _editGrupos;
			
				//CARGO SI TIENE UNA FILA DE SUMA
				if (_filaSum != string.Empty && _filaSum != null)
				{
					this.gridResultado.RootTable.Columns[_filaSum].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
					//permito que se vea el resultado de la suma		
					this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
					this.gridResultado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
				}

				//collapso los simbolos mas
				this.gridResultado.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
			}
			else
			{
				
				if ( _uiController.Groups != null && _uiController.Groups != string.Empty )
				{
					
					this.gridResultado.RootTable.Groups.Clear();
					ArrayList groups = new ArrayList();
					groups = mz.erp.systemframework.Util.Parse(_uiController.Groups, ",");
					foreach(string str in groups)
					{
						if(ContainsColumn(str))
							this.gridResultado.RootTable.Groups.Add(new Janus.Windows.GridEX.GridEXGroup(this.gridResultado.RootTable.Columns[str]));
					}
				}
				//DEJO EDITABLE O NO LOS GRUPOS
				this.gridResultado.GroupByBoxVisible= _uiController.EditGroups;
			
				if(_uiController.TotalGroups)
				{
					if (_uiController.FieldsTotalGroups != string.Empty && _uiController.FieldsTotalGroups != null)
					{
					
						ArrayList groups = new ArrayList();
						groups = mz.erp.systemframework.Util.Parse(_uiController.FieldsTotalGroups, ",");
						foreach(string str in groups)
						{
							if(ContainsColumn(str))
								this.gridResultado.RootTable.Columns[str].AggregateFunction = Janus.Windows.GridEX.AggregateFunction.Sum;
						}
						
						//permito que se vea el resultado de la suma		
						this.gridResultado.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
						if (_uiController.GridTotal)
							this.gridResultado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
						else
							this.gridResultado.TotalRow = Janus.Windows.GridEX.InheritableBoolean.False;
					}
				}

				//collapso los simbolos mas
			
				this.gridResultado.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
				this.gridResultado.CollapseGroups();
				
			}
		}
		/*private void FormatoGrilla()
		{			
			this.gridResultado.RootTable.UseGroupCondition=true;
			this.gridResultado.RootTable.GroupCondition.Column = this.gridResultado.RootTable.Columns["Total"];
			this.gridResultado.RootTable.GroupCondition.ConditionOperator=Janus.Windows.GridEX.ConditionOperator.GreaterThan;
			this.gridResultado.RootTable.GroupCondition.Value1 = (object) 100;
			this.gridResultado.RootTable.ShowGroupConditionCount = true;
			//this.gridResultado.RootTable.GroupConditionCountTitle = "Items On Sale";
			this.gridResultado.RootTable.GroupCondition.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			
			Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridResultado.RootTable.Columns["Total"],Janus.Windows.GridEX.ConditionOperator.Equal,true);
			fc.FormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridResultado.RootTable.FormatConditions.Add(fc);
		}*/


		private void FrmConsultas_Load(object sender, System.EventArgs e)
		{
		
		}

		protected virtual void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					StepMultipleRow();
					break;
				case 3:
					break;
				case 4:					
					RefreshData();
					break;
				case 6:
					ResetUI();					
					break;
				case 8:					
					PrintComprobante();									
					break;
				case 9:
					CloseForm();
					break;
			}		
		}

		protected void PrintComprobante()
		{
			if(_uiController == null)
			{
				if (MustImprimir)
				{
					if ((gridResultado.RecordCount > 0 ) && (gridResultado.SelectedItems.Count > 0))
					{
						if(gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
							string IdComprobante = (string)gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value;
							ReportsManager.PrintReportComprobantes(IdComprobante,this.MdiParent);
						}
					}
					//else MessageBox.Show("Debe seleccionar el Comprobante a imprimir");
				}
			}
			else
			{
				if(_uiController.AllowPrintItem)
				{
					if ((gridResultado.RecordCount > 0 ) && (gridResultado.SelectedItems.Count > 0))
					{
						if(gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
							this.Cursor = Cursors.WaitCursor;
							string IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);					
							ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
							this.Cursor = Cursors.Default;
						}
					}
				}
			}
			//else MessageBox.Show("No esta habilitada la impresion");

		}

		private string ObtenerFamiliaDeComprobanteSeleccionado()
		{
			sy_VariablesDataset  data = mz.erp.businessrules.sy_Variables.GetList("Comprobantes.TiposDeComprobantes.");
			System.Data.DataTable table = data.Tables[0];
			_idTipoDeComprobante = (string)gridResultado.SelectedItems[0].GetRow().Cells[11].Value;
			string family = null;
			foreach(System.Data.DataRow row in table.Rows)
			{
				ArrayList ar = mz.erp.systemframework.Util.Parse((string)row["ValorDefault"],",");
				if (ar.Contains(_idTipoDeComprobante))
				{
					string [] partes = ((string)row["IdVariable"]).Split('.');
					family  = partes[partes.Length-1];
				}
			}
			return family;
		}

		protected void ResetUI()
		{					
			foreach(Control control in this.ContainerFiltro.Controls)
			{
				if (control.GetType() == typeof(mz.erp.ui.controls.mzProveedoresControl))
				{
					//((mz.erp.ui.controls.mzProveedoresControl)control).DataValue ="";
					((mz.erp.ui.controls.mzProveedoresControl)control).ClearControl();
				}
				if (control.GetType() == typeof(mz.erp.ui.controls.mzComboSearchEditor))
				{
					//((mz.erp.ui.controls.mzComboSearchEditor)control).DataValue ="";
					((mz.erp.ui.controls.mzComboSearchEditor)control).ClearControl();
				}
				if (control.GetType() == typeof(mz.erp.ui.controls.mzComboEditor))
				{
					((mz.erp.ui.controls.mzComboEditor)control).Clear();
				}
				if (control.GetType() == typeof(Infragistics.Win.UltraWinSchedule.UltraCalendarCombo))
				{
					object key = ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Name;					
					object valor = null;
					try
					{
						valor = this._defaultValues[key];
					}
					catch
					{
						valor = mz.erp.businessrules.Sistema.DateTime.Now;
					}
					
					((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value= valor;
				}
				if (control.GetType() == typeof(System.Windows.Forms.ComboBox))
				{
					((System.Windows.Forms.ComboBox)control).Text =_defaultValueComprobantesAgrupados ;
				}
				if (control.GetType() == typeof(System.Windows.Forms.TextBox))
				{
					((System.Windows.Forms.TextBox)control).Text = string.Empty ;
				}
			}
			gridResultado.SetDataBinding( null, null );
		}
		protected void StepMultipleRow()
		{
			
			if ((_stepType != null) && (_stepData != null))
			{
				this.Cursor = Cursors.WaitCursor;
				object instance = Activator.CreateInstance( _stepType );
				ArrayList array = new ArrayList();
				if (gridResultado.SelectedItems.Count > 0) 
				{
					for (int i=0;i<gridResultado.SelectedItems.Count;i++)
					{
						array.Add( gridResultado.SelectedItems[i].GetRow().Cells[0].Value );
					}

					foreach( PropertyInfo pi in _stepType.GetProperties())
					{
						foreach( Attribute  am in pi.GetCustomAttributes( false ) )
						{
							if ( am is FormOwnerPropertyAttributte)
							{
								pi.SetValue(instance,this,null);
							}

						}
					}
					_stepData.Invoke( instance, new object[] { array } );
				}
			}
			/*Nuevo con manejo de controller*/
			if(_uiController != null)
			{
				if(gridResultado.SelectedItems.Count > 0)
				{
					if(gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
					{
						ArrayList arrayIdComprobantesPendientes = new ArrayList();
						ArrayList selectedItems = new ArrayList();
						if (gridResultado.SelectedItems.Count > 0) 
						{
							for (int i=0;i<gridResultado.SelectedItems.Count;i++)
							{
								arrayIdComprobantesPendientes.Add( gridResultado.SelectedItems[i].GetRow().Cells[0].Value );
								DataRow rowAux = null;
								if(gridResultado.SelectedItems[i].GetRow().DataRow.GetType().Equals(typeof(System.Data.DataRowView)))
								{
									rowAux = (DataRow)((DataRowView)gridResultado.SelectedItems[i].GetRow().DataRow).Row;
									selectedItems.Add(rowAux );
								}
								else
									if(gridResultado.SelectedItems[i].GetRow().DataRow.GetType().Equals(typeof(System.Data.DataRow)))
								{
									rowAux = (DataRow)(gridResultado.SelectedItems[i].GetRow().DataRow);
									selectedItems.Add(rowAux );
								}
							}
						}
						_uiController.ArrayComprobantesPendientes = arrayIdComprobantesPendientes;
						_uiController.SetSelectedItems(selectedItems);
						//	ArrayIdComprobantesPendientes = arrayIdComprobantesPendientes;
						_uiController.HasShowSeleccionItems = true;
						_uiController.Execute();
					}
					else
					{
						if(_uiController.MustImprimir())
						{
							_uiController.Execute();
						}
					}

				}
				else
				{
					if(_uiController.MustImprimir())
					{
						_uiController.Execute();
					}
				}
			}
			this.Cursor = Cursors.Default;
			
		}
		private void gridResultado_DoubleClick(object sender, System.EventArgs e)
		{
			
			if(_detailControllerInstance != null)
			{	
				DataRowView rowView = (DataRowView)gridResultado.SelectedItems[0].GetRow().DataRow;
				object param = rowView.Row;
				_detailControllerInstance.SetObject(param);
				_detailInstance = new FrmDetail();
				_detailInstance.SetController(_detailControllerInstance);
				_detailInstance.ShowModal();
			}
			/*
			if(_changeSort) _changeSort = false;
			else
			{
				if ((_stepType != null) && (_stepData != null))
				{
					if (!_allowMultipleSelect)
					{
						this.Cursor = Cursors.WaitCursor;
						object instance = Activator.CreateInstance(_stepType);
						string id = (string)gridResultado.SelectedItems[0].GetRow().Cells[0].Value;
						string TipoComprobanteOrigen = (string)gridResultado.SelectedItems[0].GetRow().Cells[11].Value;
						ArrayList TiposComprobanteDestinos = businessrules.tlg_TiposComprobantesOrigenDestino.GetTipoComprobanteDestino(TipoComprobanteOrigen);					
						//_stepData.Invoke( instance, new object[] {id, "Vender", TipoComprobanteDestino});
						this.Cursor = Cursors.Default;
					}
					else 
					{
						this.Cursor = Cursors.WaitCursor;
						string IdComprobanteOrigen = (string)gridResultado.SelectedItems[0].GetRow().Cells[0].Value;
						string IdTipoDeComprobanteOrigen = (string)gridResultado.SelectedItems[0].GetRow().Cells[11].Value;
						mz.erp.ui.RelacionComprobanteOrigenDestino rod = new 	mz.erp.ui.RelacionComprobanteOrigenDestino(IdComprobanteOrigen, IdTipoDeComprobanteOrigen);					
						rod.FormOwner = this;
						rod.MomentoStepDefault = this._momentoStepDefault;
						rod.Step();
						this.Cursor = Cursors.Default;
					}
				}
				else
				{
					if ((_editType != null) && (_editData != null))
					{
						this.Cursor = Cursors.WaitCursor;
						object instance = Activator.CreateInstance(_editType);
						string id = (string)gridResultado.SelectedItems[0].GetRow().Cells[0].Value;
						_editData.Invoke( instance, new object[] {id} );
						this.Cursor = Cursors.Default;
					}
					else
					{
						
						else
						{
							if(_uiController != null)
							{	
								if(gridResultado.SelectedItems.Count == 1)
								{
									string IdComprobanteOrigen = (string)gridResultado.SelectedItems[0].GetRow().Cells[0].Value;
									string IdTipoDeComprobanteOrigen = (string)gridResultado.SelectedItems[0].GetRow().Cells[11].Value;
									_uiController.GenerateRelacionOrigenDestino(IdComprobanteOrigen);
									/*RelacionComprobanteOrigenDestino rod = new RelacionComprobanteOrigenDestino(IdComprobanteOrigen, IdTipoDeComprobanteOrigen);					
									_uiController.RelacionesComprobantesOrigenDestino = rod.GetRelaciones();
									_uiController.HasShowSeleccionItems = false;
									_uiController.Execute();
									
									
								}
							}
						}
					}
				}
			}	
			*/
		}
		#endregion

		#region Eventos
		
		private void FrmConsultas_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.S)
			{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
				{
					StepMultipleRow();
				}
			}
			else
				if(e.KeyCode == System.Windows.Forms.Keys.PageDown)
					this.gridResultado.Select();
				
				else
				if(e.KeyCode == System.Windows.Forms.Keys.N)
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
						this.ResetUI();	
				else 
					if (e.KeyCode == System.Windows.Forms.Keys.F5)
						this.RefreshData();
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
			/*if(_uiController != null)
				tbbAnterior.Visible = _uiController.IsFirstTask();
			this.Show();*/
			if(_uiController != null)
			{
				if(this._uiController.AllowShow())
				{
					
					ExportarAExcel.Enabled = _uiController.AllowExportarAExcel;
					tbbAnterior.Visible = _uiController.IsFirstTask();
					Show();
				

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
			else this.Show();
		
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
			StepMultipleRow();
		}

		#endregion

		private void gridResultado_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = true;
		}

	
		private void gridResultado_SortKeysChanged(object sender, EventArgs e)
		{
			_changeSort = true;
		}

		
		private void Detalles_Click(object sender, EventArgs e)
		{
			/*
			if(gridResultado.SelectedItems.Count > 0 && _uiController != null)
			{
				
				if ( _uiController.AllowPrintItem ) 
				{
					this.Cursor = Cursors.WaitCursor;
					string IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells["IdComprobante"].Value);					
					ReportsManager.PrintReportComprobantes( IdComprobante, this.MdiParent) ;
					this.Cursor = Cursors.Default;

				}
			}
			else
			{
				if(gridResultado.SelectedItems.Count > 0 && _uiController == null)
				{
					PrintComprobante();
				}
				

			}
			*/
			if(_uiController != null)
			{
				if(_uiController.AllowShowDetail && _uiController.ShowDetailBy.ToUpper().Equals("PORDEMANDA"))
					if(this.gridResultado.SelectedItems.Count > 0)
					{
						string datos = string.Empty;
						if (gridResultado.SelectedItems.Count == 1 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
							string IdComprobanteFieldName = _uiController.IdComprobanteFieldName;
							string IdTipoDeComprobanteFieldName = _uiController.IdTipoDeComprobanteFieldName;
							string IdComprobante = string.Empty;
							string IdTipoDeComprobante = string.Empty;
							foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
							{
								if(col.Key.Equals(IdComprobanteFieldName))
									IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells[col].Value);
								if(col.Key.Equals(IdTipoDeComprobanteFieldName))
									IdTipoDeComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells[col].Value);
							}
							if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
							{
								this.richInfoComprobante.Clear();
								datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
								this.richInfoComprobante.AddHTML(datos);
							}
							else this.richInfoComprobante.Clear();
								
							
						}		
						
					}
			}
			
			else 
				if(_allowShowDetails)
				{
					if(this.gridResultado.SelectedItems.Count > 0)
					{
						string datos = string.Empty;
						if (gridResultado.SelectedItems.Count == 1 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
						
							string IdComprobante = string.Empty;
							string IdTipoDeComprobante = string.Empty;
							foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
							{
								if(col.Key.Equals("IdComprobante"))
									IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells[col].Value);
								if(col.Key.Equals("IdTipoDeComprobante"))
									IdTipoDeComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells[col].Value);
							}
							if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
							{
								this.richInfoComprobante.Clear();
								datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
								this.richInfoComprobante.AddHTML(datos);
							}
							else this.richInfoComprobante.Clear();
									
								
						}		
							
					}
			}
		}

		private void gridResultado_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}

		private void gridResultado_SelectionChanged(object sender, EventArgs e)
		{
			

			if(_uiController != null)
			{
				
				if(_uiController.AllowShowDetail && _uiController.ShowDetailBy.ToUpper().Equals("AUTOMATICO"))
				{
					if(this.gridResultado.SelectedItems.Count > 0)
					{
						string datos = string.Empty;
						if (gridResultado.SelectedItems.Count == 1 &&  gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
						{
							foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
							{
								if(col.Key.Equals("TextoHTML"))
									datos = Convert.ToString(this.gridResultado.SelectedItems[0].GetRow().Cells["TextoHTML"].Value);
							}
								
							
						}		
						this.richInfoComprobante.Clear();
						this.richInfoComprobante.AddHTML(datos);
					}
				}
				else
				{
					if(_uiController.AllowShowDetail && _uiController.ShowDetailBy.ToUpper().Equals("PORDEMANDA"))
						if(this.gridResultado.SelectedItems.Count > 0)
						{
							string datos = string.Empty;
							if (gridResultado.SelectedItems.Count == 1 && gridResultado.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record))
							{
								string IdComprobanteFieldName = _uiController.IdComprobanteFieldName;
								string IdTipoDeComprobanteFieldName = _uiController.IdTipoDeComprobanteFieldName;
								string IdComprobante = string.Empty;
								string IdTipoDeComprobante = string.Empty;
								foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
								{
									if(col.Key.Equals(IdComprobanteFieldName))
										IdComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells[col].Value);
									if(col.Key.Equals(IdTipoDeComprobanteFieldName))
										IdTipoDeComprobante = Convert.ToString(gridResultado.SelectedItems[0].GetRow().Cells[col].Value);
								}
								if(!IdComprobante.Equals(string.Empty) && !IdTipoDeComprobante.Equals(string.Empty))
								{
									this.richInfoComprobante.Clear();
									datos = mz.erp.businessrules.Workflow.GetHTMLComprobantes(IdComprobante, IdTipoDeComprobante);
									this.richInfoComprobante.AddHTML(datos);
								}
								else this.richInfoComprobante.Clear();
								
							
							}		
						
						}
				
						else
						{
							this.richInfoComprobante.Clear();
						}
				}
			}
			else 
				if(_allowShowDetails)
					if(this.gridResultado.SelectedItems.Count > 0)
					{
						string datos = string.Empty;
						if (gridResultado.SelectedItems.Count == 1 )
						{
							foreach(Janus.Windows.GridEX.GridEXColumn col in gridResultado.RootTable.Columns)
							{
								if(col.Key.Equals("TextoHTML"))
									datos = Convert.ToString(this.gridResultado.SelectedItems[0].GetRow().Cells["TextoHTML"].Value);
							}
								
						}		
						this.richInfoComprobante.Clear();
						this.richInfoComprobante.AddHTML(datos);
					}
					
					
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
		
		}

		private void ExportarAExcel_Click(object sender, System.EventArgs e)
		{
			
			if(gridResultado.RecordCount > 0)
			{
				string fileName = string.Empty;
				GridManagerJanus manager = new GridManagerJanus(gridResultado);
				ArrayList layoutProperties =  manager.GetLayoutProperties(string.Empty);
				SaveFileDialog saveFileDialog1 = new SaveFileDialog();
				saveFileDialog1.Filter = "Excel files (*.xls)|*.xls"  ;
				saveFileDialog1.RestoreDirectory = true ;
				if(saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
                    fileName = saveFileDialog1.FileName;
					DataTable table = (DataTable)gridResultado.DataSource;
					ExportToExcel exporter = new ExportToExcel();
					exporter.Export(table.DefaultView, fileName ,"Prueba",layoutProperties);
				}
			}
		}
	}
}

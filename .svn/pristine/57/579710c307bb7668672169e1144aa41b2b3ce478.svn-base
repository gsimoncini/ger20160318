using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
using System.IO;
using Infragistics.Win.UltraWinTree;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConfigurarMenues.
	/// </summary>
	public class FrmConfigurarMenues : System.Windows.Forms.Form, ITaskForm
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
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.GroupBox panel1;
		private System.Windows.Forms.ComboBox cmbBarrasDeHerramientas;
		private System.Windows.Forms.Button btnSubir;
		private System.Windows.Forms.Button btnBajar;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTreeMenu; 
        private System.Windows.Forms.GroupBox panel2;
		private System.Windows.Forms.GroupBox groupBox3;
		private Infragistics.Win.Misc.UltraButton btnEliminarSeparador;
		private Infragistics.Win.Misc.UltraButton btnAgregarSeparador;
		private System.Windows.Forms.GroupBox groupBox2;
		private Infragistics.Win.Misc.UltraButton btnTodos;
		private Infragistics.Win.Misc.UltraButton btnInvertir;
		private Infragistics.Win.Misc.UltraButton btnNinguno;
		private Infragistics.Win.Misc.UltraButton btnVisibilizar;
		private Infragistics.Win.Misc.UltraButton btnInvisibilizar;
		private System.Windows.Forms.ListBox listBoxPerfiles;
		private mz.erp.ui.controls.ToolTipCheckedListBox chkPerfiles;
		private Infragistics.Win.Misc.UltraButton btnVerSeleccionados;
		private Infragistics.Win.Misc.UltraButton btnVerTodas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtOrden;
		private Infragistics.Win.Misc.UltraButton btnModificar;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitado;
		private System.Windows.Forms.ComboBox cmbImagenes;
		private System.Windows.Forms.ComboBox cmbShortCut;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitulo;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIdHerramienta;
		private System.Windows.Forms.TextBox txtProceso;
		private System.Windows.Forms.Label labelProceso;
		private System.Windows.Forms.TextBox txtIdProceso;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtHerramientaPadre;
		private System.Windows.Forms.TextBox txtIdHerramientaPadre;
		private System.Windows.Forms.GroupBox groupBox4;
		private Infragistics.Win.Misc.UltraButton btnAceptarModificacion;
		private Infragistics.Win.Misc.UltraButton btnCancelarModificacion;
		private Infragistics.Win.Misc.UltraButton btnAceptarSubmenu;
		private Infragistics.Win.Misc.UltraButton btnCancelarSubmenu;
		private Infragistics.Win.Misc.UltraButton btnAgregarSubmenu;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox cmbBarraDeHerramientasNueva;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox5;
		private Infragistics.Win.Misc.UltraButton btnAceptarBarra;
		private Infragistics.Win.Misc.UltraButton btnCancelarBarra;
		private Infragistics.Win.Misc.UltraButton btnAgregarBarra;
		private Infragistics.Win.Misc.UltraButton btnEliminarBarra;
		private System.ComponentModel.IContainer components;


		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConfigurarMenues));
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.panel2 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btnAgregarBarra = new Infragistics.Win.Misc.UltraButton();
			this.btnAceptarBarra = new Infragistics.Win.Misc.UltraButton();
			this.btnCancelarBarra = new Infragistics.Win.Misc.UltraButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnAgregarSubmenu = new Infragistics.Win.Misc.UltraButton();
			this.btnAceptarSubmenu = new Infragistics.Win.Misc.UltraButton();
			this.btnCancelarSubmenu = new Infragistics.Win.Misc.UltraButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnEliminarSeparador = new Infragistics.Win.Misc.UltraButton();
			this.btnAgregarSeparador = new Infragistics.Win.Misc.UltraButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnTodos = new Infragistics.Win.Misc.UltraButton();
			this.btnInvertir = new Infragistics.Win.Misc.UltraButton();
			this.btnNinguno = new Infragistics.Win.Misc.UltraButton();
			this.btnVisibilizar = new Infragistics.Win.Misc.UltraButton();
			this.btnInvisibilizar = new Infragistics.Win.Misc.UltraButton();
			this.listBoxPerfiles = new System.Windows.Forms.ListBox();
			this.chkPerfiles = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.btnVerSeleccionados = new Infragistics.Win.Misc.UltraButton();
			this.btnVerTodas = new Infragistics.Win.Misc.UltraButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbBarraDeHerramientasNueva = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnCancelarModificacion = new Infragistics.Win.Misc.UltraButton();
			this.btnAceptarModificacion = new Infragistics.Win.Misc.UltraButton();
			this.txtIdHerramientaPadre = new System.Windows.Forms.TextBox();
			this.txtHerramientaPadre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtIdProceso = new System.Windows.Forms.TextBox();
			this.labelProceso = new System.Windows.Forms.Label();
			this.txtProceso = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIdHerramienta = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtOrden = new System.Windows.Forms.TextBox();
			this.btnModificar = new Infragistics.Win.Misc.UltraButton();
			this.cmbImagenes = new System.Windows.Forms.ComboBox();
			this.cmbShortCut = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.chkHabilitado = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.panel1 = new System.Windows.Forms.GroupBox();
			this.cmbBarrasDeHerramientas = new System.Windows.Forms.ComboBox();
			this.btnSubir = new System.Windows.Forms.Button();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.btnBajar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraTreeMenu = new Infragistics.Win.UltraWinTree.UltraTree();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnEliminarBarra = new Infragistics.Win.Misc.UltraButton();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraTreeMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(790, 25);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(790, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.panel2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.panel1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 108);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(790, 590);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.groupBox5);
			this.panel2.Controls.Add(this.groupBox4);
			this.panel2.Controls.Add(this.groupBox3);
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Controls.Add(this.gridEX1);
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Location = new System.Drawing.Point(256, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(696, 592);
			this.panel2.TabIndex = 1;
			this.panel2.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btnEliminarBarra);
			this.groupBox5.Controls.Add(this.btnAgregarBarra);
			this.groupBox5.Controls.Add(this.btnAceptarBarra);
			this.groupBox5.Controls.Add(this.btnCancelarBarra);
			this.groupBox5.Location = new System.Drawing.Point(152, 328);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(176, 88);
			this.groupBox5.TabIndex = 142;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Barra de Herramientas";
			// 
			// btnAgregarBarra
			// 
			this.btnAgregarBarra.Enabled = false;
			this.btnAgregarBarra.Location = new System.Drawing.Point(8, 14);
			this.btnAgregarBarra.Name = "btnAgregarBarra";
			this.btnAgregarBarra.Size = new System.Drawing.Size(160, 24);
			this.btnAgregarBarra.TabIndex = 148;
			this.btnAgregarBarra.Text = "Agregar Barra Herramientas";
			// 
			// btnAceptarBarra
			// 
			this.btnAceptarBarra.Enabled = false;
			this.btnAceptarBarra.Location = new System.Drawing.Point(8, 60);
			this.btnAceptarBarra.Name = "btnAceptarBarra";
			this.btnAceptarBarra.Size = new System.Drawing.Size(80, 24);
			this.btnAceptarBarra.TabIndex = 142;
			this.btnAceptarBarra.Text = "Aceptar";
			// 
			// btnCancelarBarra
			// 
			this.btnCancelarBarra.Enabled = false;
			this.btnCancelarBarra.Location = new System.Drawing.Point(88, 60);
			this.btnCancelarBarra.Name = "btnCancelarBarra";
			this.btnCancelarBarra.Size = new System.Drawing.Size(80, 24);
			this.btnCancelarBarra.TabIndex = 143;
			this.btnCancelarBarra.Text = "Cancelar";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnAgregarSubmenu);
			this.groupBox4.Controls.Add(this.btnAceptarSubmenu);
			this.groupBox4.Controls.Add(this.btnCancelarSubmenu);
			this.groupBox4.Location = new System.Drawing.Point(328, 328);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(184, 64);
			this.groupBox4.TabIndex = 141;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Submenues";
			// 
			// btnAgregarSubmenu
			// 
			this.btnAgregarSubmenu.Enabled = false;
			this.btnAgregarSubmenu.Location = new System.Drawing.Point(16, 14);
			this.btnAgregarSubmenu.Name = "btnAgregarSubmenu";
			this.btnAgregarSubmenu.Size = new System.Drawing.Size(160, 24);
			this.btnAgregarSubmenu.TabIndex = 141;
			this.btnAgregarSubmenu.Text = "AgregarSubmenú";
			// 
			// btnAceptarSubmenu
			// 
			this.btnAceptarSubmenu.Enabled = false;
			this.btnAceptarSubmenu.Location = new System.Drawing.Point(16, 37);
			this.btnAceptarSubmenu.Name = "btnAceptarSubmenu";
			this.btnAceptarSubmenu.Size = new System.Drawing.Size(80, 24);
			this.btnAceptarSubmenu.TabIndex = 142;
			this.btnAceptarSubmenu.Text = "Aceptar";
			// 
			// btnCancelarSubmenu
			// 
			this.btnCancelarSubmenu.Enabled = false;
			this.btnCancelarSubmenu.Location = new System.Drawing.Point(96, 37);
			this.btnCancelarSubmenu.Name = "btnCancelarSubmenu";
			this.btnCancelarSubmenu.Size = new System.Drawing.Size(80, 24);
			this.btnCancelarSubmenu.TabIndex = 143;
			this.btnCancelarSubmenu.Text = "Cancelar";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnEliminarSeparador);
			this.groupBox3.Controls.Add(this.btnAgregarSeparador);
			this.groupBox3.Location = new System.Drawing.Point(16, 328);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(136, 66);
			this.groupBox3.TabIndex = 140;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Separadores";
			// 
			// btnEliminarSeparador
			// 
			this.btnEliminarSeparador.Enabled = false;
			this.btnEliminarSeparador.Location = new System.Drawing.Point(16, 37);
			this.btnEliminarSeparador.Name = "btnEliminarSeparador";
			this.btnEliminarSeparador.Size = new System.Drawing.Size(112, 24);
			this.btnEliminarSeparador.TabIndex = 112;
			this.btnEliminarSeparador.Text = "&Eliminar&Separador";
			this.btnEliminarSeparador.Click += new System.EventHandler(this.btnEliminarSeparador_Click);
			// 
			// btnAgregarSeparador
			// 
			this.btnAgregarSeparador.Enabled = false;
			this.btnAgregarSeparador.Location = new System.Drawing.Point(16, 14);
			this.btnAgregarSeparador.Name = "btnAgregarSeparador";
			this.btnAgregarSeparador.Size = new System.Drawing.Size(112, 24);
			this.btnAgregarSeparador.TabIndex = 111;
			this.btnAgregarSeparador.Text = "&Agregar&Separador";
			this.btnAgregarSeparador.Click += new System.EventHandler(this.btnAgregarSeparador_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnTodos);
			this.groupBox2.Controls.Add(this.btnInvertir);
			this.groupBox2.Controls.Add(this.btnNinguno);
			this.groupBox2.Controls.Add(this.btnVisibilizar);
			this.groupBox2.Controls.Add(this.btnInvisibilizar);
			this.groupBox2.Controls.Add(this.listBoxPerfiles);
			this.groupBox2.Controls.Add(this.chkPerfiles);
			this.groupBox2.Controls.Add(this.btnVerSeleccionados);
			this.groupBox2.Controls.Add(this.btnVerTodas);
			this.groupBox2.Location = new System.Drawing.Point(16, 176);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(496, 144);
			this.groupBox2.TabIndex = 139;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Perfiles";
			// 
			// btnTodos
			// 
			this.btnTodos.Location = new System.Drawing.Point(16, 112);
			this.btnTodos.Name = "btnTodos";
			this.btnTodos.Size = new System.Drawing.Size(16, 24);
			this.btnTodos.TabIndex = 125;
			this.btnTodos.Text = "T";
			this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
			// 
			// btnInvertir
			// 
			this.btnInvertir.Location = new System.Drawing.Point(48, 112);
			this.btnInvertir.Name = "btnInvertir";
			this.btnInvertir.Size = new System.Drawing.Size(16, 24);
			this.btnInvertir.TabIndex = 126;
			this.btnInvertir.Text = "I";
			this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
			// 
			// btnNinguno
			// 
			this.btnNinguno.Location = new System.Drawing.Point(32, 112);
			this.btnNinguno.Name = "btnNinguno";
			this.btnNinguno.Size = new System.Drawing.Size(16, 24);
			this.btnNinguno.TabIndex = 127;
			this.btnNinguno.Text = "N";
			// 
			// btnVisibilizar
			// 
			this.btnVisibilizar.Enabled = false;
			this.btnVisibilizar.Location = new System.Drawing.Point(256, 112);
			this.btnVisibilizar.Name = "btnVisibilizar";
			this.btnVisibilizar.Size = new System.Drawing.Size(80, 24);
			this.btnVisibilizar.TabIndex = 130;
			this.btnVisibilizar.Text = "&Visibilizar";
			this.btnVisibilizar.Click += new System.EventHandler(this.btnVisibilizar_Click);
			// 
			// btnInvisibilizar
			// 
			this.btnInvisibilizar.Enabled = false;
			this.btnInvisibilizar.Location = new System.Drawing.Point(336, 112);
			this.btnInvisibilizar.Name = "btnInvisibilizar";
			this.btnInvisibilizar.Size = new System.Drawing.Size(80, 24);
			this.btnInvisibilizar.TabIndex = 131;
			this.btnInvisibilizar.Text = "&Invisibilizar";
			this.btnInvisibilizar.Click += new System.EventHandler(this.btnInvisibilizar_Click);
			// 
			// listBoxPerfiles
			// 
			this.listBoxPerfiles.Location = new System.Drawing.Point(256, 16);
			this.listBoxPerfiles.Name = "listBoxPerfiles";
			this.listBoxPerfiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxPerfiles.Size = new System.Drawing.Size(192, 95);
			this.listBoxPerfiles.TabIndex = 132;
			// 
			// chkPerfiles
			// 
			this.chkPerfiles.Location = new System.Drawing.Point(16, 16);
			this.chkPerfiles.Name = "chkPerfiles";
			this.chkPerfiles.Size = new System.Drawing.Size(216, 94);
			this.chkPerfiles.TabIndex = 114;
			// 
			// btnVerSeleccionados
			// 
			this.btnVerSeleccionados.Location = new System.Drawing.Point(64, 112);
			this.btnVerSeleccionados.Name = "btnVerSeleccionados";
			this.btnVerSeleccionados.Size = new System.Drawing.Size(112, 24);
			this.btnVerSeleccionados.TabIndex = 128;
			this.btnVerSeleccionados.Text = "Ver Seleccionadas";
			this.btnVerSeleccionados.Click += new System.EventHandler(this.btnVerSeleccionados_Click);
			// 
			// btnVerTodas
			// 
			this.btnVerTodas.Location = new System.Drawing.Point(176, 112);
			this.btnVerTodas.Name = "btnVerTodas";
			this.btnVerTodas.Size = new System.Drawing.Size(72, 24);
			this.btnVerTodas.TabIndex = 129;
			this.btnVerTodas.Text = "Ver Todas";
			this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbBarraDeHerramientasNueva);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.btnCancelarModificacion);
			this.groupBox1.Controls.Add(this.btnAceptarModificacion);
			this.groupBox1.Controls.Add(this.txtIdHerramientaPadre);
			this.groupBox1.Controls.Add(this.txtHerramientaPadre);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.txtIdProceso);
			this.groupBox1.Controls.Add(this.labelProceso);
			this.groupBox1.Controls.Add(this.txtProceso);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtIdHerramienta);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtOrden);
			this.groupBox1.Controls.Add(this.btnModificar);
			this.groupBox1.Controls.Add(this.cmbImagenes);
			this.groupBox1.Controls.Add(this.cmbShortCut);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTitulo);
			this.groupBox1.Controls.Add(this.chkHabilitado);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(504, 170);
			this.groupBox1.TabIndex = 138;
			this.groupBox1.TabStop = false;
			// 
			// cmbBarraDeHerramientasNueva
			// 
			this.cmbBarraDeHerramientasNueva.Location = new System.Drawing.Point(64, 144);
			this.cmbBarraDeHerramientasNueva.Name = "cmbBarraDeHerramientasNueva";
			this.cmbBarraDeHerramientasNueva.Size = new System.Drawing.Size(200, 21);
			this.cmbBarraDeHerramientasNueva.TabIndex = 146;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(24, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 16);
			this.label8.TabIndex = 145;
			this.label8.Text = "Barra";
			// 
			// btnCancelarModificacion
			// 
			this.btnCancelarModificacion.Enabled = false;
			this.btnCancelarModificacion.Location = new System.Drawing.Point(120, 120);
			this.btnCancelarModificacion.Name = "btnCancelarModificacion";
			this.btnCancelarModificacion.Size = new System.Drawing.Size(80, 24);
			this.btnCancelarModificacion.TabIndex = 144;
			this.btnCancelarModificacion.Text = "&Cancelar";
			// 
			// btnAceptarModificacion
			// 
			this.btnAceptarModificacion.Enabled = false;
			this.btnAceptarModificacion.Location = new System.Drawing.Point(120, 96);
			this.btnAceptarModificacion.Name = "btnAceptarModificacion";
			this.btnAceptarModificacion.Size = new System.Drawing.Size(80, 24);
			this.btnAceptarModificacion.TabIndex = 143;
			this.btnAceptarModificacion.Text = "&Aceptar";
			// 
			// txtIdHerramientaPadre
			// 
			this.txtIdHerramientaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtIdHerramientaPadre.Location = new System.Drawing.Point(384, 96);
			this.txtIdHerramientaPadre.Name = "txtIdHerramientaPadre";
			this.txtIdHerramientaPadre.Size = new System.Drawing.Size(40, 20);
			this.txtIdHerramientaPadre.TabIndex = 132;
			this.txtIdHerramientaPadre.Text = "";
			// 
			// txtHerramientaPadre
			// 
			this.txtHerramientaPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtHerramientaPadre.Location = new System.Drawing.Point(296, 118);
			this.txtHerramientaPadre.Name = "txtHerramientaPadre";
			this.txtHerramientaPadre.Size = new System.Drawing.Size(184, 20);
			this.txtHerramientaPadre.TabIndex = 131;
			this.txtHerramientaPadre.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(280, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 16);
			this.label7.TabIndex = 130;
			this.label7.Text = "Herramienta Padre";
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtId.Location = new System.Drawing.Point(296, 30);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(184, 20);
			this.txtId.TabIndex = 129;
			this.txtId.Text = "";
			// 
			// txtIdProceso
			// 
			this.txtIdProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtIdProceso.Location = new System.Drawing.Point(384, 54);
			this.txtIdProceso.Name = "txtIdProceso";
			this.txtIdProceso.Size = new System.Drawing.Size(40, 20);
			this.txtIdProceso.TabIndex = 127;
			this.txtIdProceso.Text = "";
			// 
			// labelProceso
			// 
			this.labelProceso.BackColor = System.Drawing.Color.Transparent;
			this.labelProceso.Location = new System.Drawing.Point(280, 54);
			this.labelProceso.Name = "labelProceso";
			this.labelProceso.Size = new System.Drawing.Size(48, 16);
			this.labelProceso.TabIndex = 125;
			this.labelProceso.Text = "Proceso";
			// 
			// txtProceso
			// 
			this.txtProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtProceso.Location = new System.Drawing.Point(296, 74);
			this.txtProceso.Name = "txtProceso";
			this.txtProceso.Size = new System.Drawing.Size(184, 20);
			this.txtProceso.TabIndex = 124;
			this.txtProceso.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(280, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 16);
			this.label6.TabIndex = 122;
			this.label6.Text = "Herramienta";
			// 
			// txtIdHerramienta
			// 
			this.txtIdHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtIdHerramienta.Location = new System.Drawing.Point(384, 8);
			this.txtIdHerramienta.Name = "txtIdHerramienta";
			this.txtIdHerramienta.Size = new System.Drawing.Size(40, 20);
			this.txtIdHerramienta.TabIndex = 123;
			this.txtIdHerramienta.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(16, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 120;
			this.label5.Text = "Orden";
			// 
			// txtOrden
			// 
			this.txtOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtOrden.Location = new System.Drawing.Point(80, 74);
			this.txtOrden.Name = "txtOrden";
			this.txtOrden.Size = new System.Drawing.Size(40, 20);
			this.txtOrden.TabIndex = 121;
			this.txtOrden.Text = "";
			// 
			// btnModificar
			// 
			this.btnModificar.Enabled = false;
			this.btnModificar.Location = new System.Drawing.Point(24, 96);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(80, 24);
			this.btnModificar.TabIndex = 103;
			this.btnModificar.Text = "&Modificar";
			// 
			// cmbImagenes
			// 
			this.cmbImagenes.Location = new System.Drawing.Point(80, 30);
			this.cmbImagenes.Name = "cmbImagenes";
			this.cmbImagenes.Size = new System.Drawing.Size(192, 21);
			this.cmbImagenes.TabIndex = 117;
			this.cmbImagenes.Text = "comboBox1";
			// 
			// cmbShortCut
			// 
			this.cmbShortCut.Location = new System.Drawing.Point(80, 54);
			this.cmbShortCut.Name = "cmbShortCut";
			this.cmbShortCut.Size = new System.Drawing.Size(192, 21);
			this.cmbShortCut.TabIndex = 119;
			this.cmbShortCut.Text = "comboBox1";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(16, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 110;
			this.label4.Text = "ShortCut";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 16);
			this.label3.TabIndex = 109;
			this.label3.Text = "Imagen";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 104;
			this.label2.Text = "Tîtulo";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtTitulo.Location = new System.Drawing.Point(80, 8);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(192, 20);
			this.txtTitulo.TabIndex = 105;
			this.txtTitulo.Text = "";
			// 
			// chkHabilitado
			// 
			this.chkHabilitado.BackColor = System.Drawing.Color.Transparent;
			this.chkHabilitado.Enabled = false;
			this.chkHabilitado.Location = new System.Drawing.Point(144, 72);
			this.chkHabilitado.Name = "chkHabilitado";
			this.chkHabilitado.Size = new System.Drawing.Size(80, 22);
			this.chkHabilitado.TabIndex = 118;
			this.chkHabilitado.Text = "Habilitado";
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.AutomaticSort = false;
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEX1.Location = new System.Drawing.Point(3, 429);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(690, 160);
			this.gridEX1.TabIndex = 137;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(20, 398);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 136;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.cmbBarrasDeHerramientas);
			this.panel1.Controls.Add(this.btnSubir);
			this.panel1.Controls.Add(this.btnBajar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.ultraTreeMenu);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(256, 590);
			this.panel1.TabIndex = 0;
			this.panel1.TabStop = false;
			// 
			// cmbBarrasDeHerramientas
			// 
			this.cmbBarrasDeHerramientas.Location = new System.Drawing.Point(44, 7);
			this.cmbBarrasDeHerramientas.Name = "cmbBarrasDeHerramientas";
			this.cmbBarrasDeHerramientas.Size = new System.Drawing.Size(200, 21);
			this.cmbBarrasDeHerramientas.TabIndex = 124;
			this.cmbBarrasDeHerramientas.Text = "comboBox1";
			// 
			// btnSubir
			// 
			this.btnSubir.ImageIndex = 11;
			this.btnSubir.ImageList = this.imglStandar;
			this.btnSubir.Location = new System.Drawing.Point(228, 151);
			this.btnSubir.Name = "btnSubir";
			this.btnSubir.Size = new System.Drawing.Size(24, 32);
			this.btnSubir.TabIndex = 123;
			this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnBajar
			// 
			this.btnBajar.ImageIndex = 12;
			this.btnBajar.ImageList = this.imglStandar;
			this.btnBajar.Location = new System.Drawing.Point(228, 183);
			this.btnBajar.Name = "btnBajar";
			this.btnBajar.Size = new System.Drawing.Size(24, 32);
			this.btnBajar.TabIndex = 122;
			this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(4, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 121;
			this.label1.Text = "Barra";
			// 
			// ultraTreeMenu
			// 
			this.ultraTreeMenu.AllowDrop = true;
			this.ultraTreeMenu.HideSelection = false;
			this.ultraTreeMenu.Location = new System.Drawing.Point(4, 47);
			this.ultraTreeMenu.Name = "ultraTreeMenu";
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Menu";
			this.ultraTreeMenu.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																									ultraTreeNode1});
			_override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.ultraTreeMenu.Override = _override1;
			this.ultraTreeMenu.Size = new System.Drawing.Size(224, 536);
			this.ultraTreeMenu.TabIndex = 120;
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
			this.toolBarStandar.Size = new System.Drawing.Size(856, 28);
			this.toolBarStandar.TabIndex = 51;
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
			ultraExplorerBarGroup2.Settings.ContainerHeight = 590;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Configuración de Menu";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(856, 718);
			this.ultraExplorerBar1.TabIndex = 53;
			// 
			// imageList
			// 
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// btnEliminarBarra
			// 
			this.btnEliminarBarra.Enabled = false;
			this.btnEliminarBarra.Location = new System.Drawing.Point(8, 37);
			this.btnEliminarBarra.Name = "btnEliminarBarra";
			this.btnEliminarBarra.Size = new System.Drawing.Size(160, 24);
			this.btnEliminarBarra.TabIndex = 149;
			this.btnEliminarBarra.Text = "Eliminar Barra Herramientas";
			// 
			// FrmConfigurarMenues
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(856, 746);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConfigurarMenues";
			this.Text = "FrmConfigurarMenues";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraTreeMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y Destructores
		public FrmConfigurarMenues(controllers.ConfigurarMenuesController controller)
		{
			InitializeComponent();
			_uiController = controller;
		}

		public FrmConfigurarMenues()
		{
			InitializeComponent();
			_uiController = new mz.erp.ui.controllers.ConfigurarMenuesController();	
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
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
				_uiController.HerramientasExModificadasHasChanged-=new EventHandler(_uiController_HerramientasExModificadasHasChanged);
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Variables Privadas

		private controllers.ConfigurarMenuesController _uiController = null;
		private bool _expandir = true;
		private bool _processItem = true;
		private string estado = string.Empty;
		private bool modificando;

		#endregion

		#region Inicializadores y Carga
		

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
			cmbBarrasDeHerramientas.SelectedItem = _uiController.BarraHerramientaSeleccionada;
			cmbBarraDeHerramientasNueva.SelectedItem = _uiController.BarraHerramientaSeleccionada;
		}

		
		private void ConfigureInterface()
		{
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			this.gridEX1.LayoutData = _uiController.GetLayout();

			ultraTreeMenu.AllowDrop = true;
			ultraTreeMenu.CollapseAll();

			btnModificar.Enabled = false;
			chkHabilitado.Enabled = false;
			cmbImagenes.Enabled = false;
			cmbShortCut.Enabled = false;
			cmbBarraDeHerramientasNueva.Enabled = false;

			chkPerfiles.Enabled = false;
			btnTodos.Enabled = false;
			btnNinguno.Enabled = false;
			btnInvertir.Enabled = false;
			btnVerSeleccionados.Enabled = false;
			btnVerTodas.Enabled = false;
			btnVisibilizar.Enabled = false;
			btnInvisibilizar.Enabled = false;
			listBoxPerfiles.Enabled = false;
			btnAgregarSeparador.Enabled = false;
			btnEliminarSeparador.Enabled = false;
			btnBajar.Enabled = false;
			btnSubir.Enabled = false;

			bool perfilSuperior = _uiController.PerfilSuperior;
			txtId.Visible = perfilSuperior;
			label6.Visible = perfilSuperior;
			labelProceso.Visible = perfilSuperior;
			txtProceso.Visible = perfilSuperior;
			txtIdProceso.Visible = perfilSuperior;
			txtHerramientaPadre.AllowDrop = true;

			btnAgregarSubmenu.Enabled = true;
			btnAceptarModificacion.Enabled = false;
			btnCancelarModificacion.Enabled = false;
			btnAceptarSubmenu.Enabled = false;
			btnCancelarSubmenu.Enabled = false;

			btnAgregarBarra.Enabled = false;
			btnAceptarBarra.Enabled = false;
			btnCancelarBarra.Enabled = false;

			txtTitulo.ReadOnly = true;
			txtHerramientaPadre.ReadOnly = true;
			txtId.ReadOnly = true;
			txtIdHerramienta.ReadOnly = true;
			txtIdHerramientaPadre.ReadOnly = true;
			txtIdProceso.ReadOnly = true;
			txtProceso.ReadOnly = true;	
			txtOrden.ReadOnly = true;

			KeyPreview = true;

		}

		private void InitializeData()
		{
			chkPerfiles.Items.AddRange(_uiController.Perfiles.ToArray());
			cmbBarrasDeHerramientas.Items.AddRange(_uiController.BarrasDeHerramientas.ToArray());
			cmbBarraDeHerramientasNueva.Items.AddRange(_uiController.BarrasDeHerramientasNuevas.ToArray());
			cmbShortCut.Items.AddRange(Enum.GetNames(typeof(System.Windows.Forms.Shortcut)));
			cmbShortCut.SelectedIndex = 0;
			//LoadImages
			DirectoryInfo dir = new DirectoryInfo(string.Format( mz.erp.systemframework.Util.ResourcePath()+ "\\resources\\Icons", "16" ));
            FileInfo[] bmpfiles = dir.GetFiles("*.bmp");
			cmbImagenes.Items.Add(new ComboItem("None", -1));

			foreach( FileInfo f in bmpfiles)
			{
				imageList.Images.Add(Image.FromFile( f.FullName), System.Drawing.Color.Magenta );
                cmbImagenes.Items.Add(new ComboItem(f.Name, imageList.Images.Count - 1));

			}
			cmbImagenes.DrawMode = DrawMode.OwnerDrawFixed;
			cmbImagenes.SelectedIndex = 0;
		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
			cmbBarrasDeHerramientas.SelectedIndexChanged += new EventHandler(cmbBarrasDeHerramientas_SelectedIndexChanged);
			cmbBarraDeHerramientasNueva.SelectedIndexChanged += new EventHandler(cmbBarraDeHerramientasNueva_SelectedIndexChanged); 
			ultraTreeMenu.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
			ultraTreeMenu.AfterExpand +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterExpand);
			cmbImagenes.DrawItem +=new DrawItemEventHandler(cmbImagenes_DrawItem);
			_uiController.HerramientasExModificadasHasChanged+=new EventHandler(_uiController_HerramientasExModificadasHasChanged);
			chkPerfiles.ItemCheck+=new ItemCheckEventHandler(chkPerfiles_ItemCheck);
			gridEX1.Click+=new EventHandler(gridEX1_Click);

			ultraTreeMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(ultraTreeMenu_MouseDown);
			txtHerramientaPadre.DragEnter += new System.Windows.Forms.DragEventHandler(txtHerramientaPadre_DragEnter);
			txtHerramientaPadre.DragDrop += new DragEventHandler(txtHerramientaPadre_DragDrop);
			txtHerramientaPadre.TextChanged += new EventHandler(txtHerramientaPadre_TextChanged);
			txtIdHerramientaPadre.TextChanged += new EventHandler(txtIdHerramientaPadre_TextChanged);

			btnAgregarSubmenu.Click += new EventHandler(btnAgregarSubmenu_Click);
			btnAceptarSubmenu.Click += new EventHandler(btnAceptarSubmenu_Click);
			btnCancelarSubmenu.Click += new EventHandler(btnCancelarSubmenu_Click);

			btnModificar.Click += new System.EventHandler(btnModificar_Click);
			btnAceptarModificacion.Click += new EventHandler(btnAceptarModificacion_Click);
			btnCancelarModificacion.Click += new EventHandler(btnCancelarModificacion_Click);

			btnAgregarBarra.Click += new EventHandler(btnAgregarBarra_Click);
			btnEliminarBarra.Click += new EventHandler(btnEliminarBarra_Click);
			btnAceptarBarra.Click += new EventHandler(btnAceptarBarra_Click);
			btnCancelarBarra.Click += new EventHandler(btnCancelarBarra_Click);

			btnNinguno.Click += new System.EventHandler(btnNinguno_Click);

			KeyDownManager KeyDown = new KeyDownManager(this);	

		}	
	
		private void InitDataBindings()
		{						
			gridEX1.DataSource = _uiController.HerramientasExModificadas;
			if(_uiController.HerramientasExModificadas.Count > 0)
				btnEliminar.Enabled = true;
			gridEX1.SelectionChanged+=new EventHandler(gridEX1_SelectionChanged);

		}

		private void EventsListener()
		{
			
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
				this.Build_UI();
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
			SaveChanges();
		}

		#endregion

		#region Métodos Privados

		private void loadPerfiles(businessrules.HerramientaEx herramienta)
		{
			chkPerfiles.ItemCheck-=new ItemCheckEventHandler(chkPerfiles_ItemCheck);
			chkPerfiles.Items.Clear();
			chkPerfiles.Items.AddRange(_uiController.Perfiles.ToArray());
			for(int i=0; i< chkPerfiles.Items.Count ; i++)
			{
				mz.erp.businessrules.PerfilView perfil = (mz.erp.businessrules.PerfilView)chkPerfiles.Items[i];
				mz.erp.businessrules.PerfilView perfilHerramienta = GetPerfilHerramienta(herramienta, perfil.IdPerfil); 
				if(perfilHerramienta != null)
				{
					chkPerfiles.SetItemChecked(i, true);
					perfil.Descripcion = perfilHerramienta.Descripcion;
				}
				else
					chkPerfiles.SetItemChecked(i, false);

			}
			listBoxPerfiles.Items.Clear();
			listBoxPerfiles.Items.AddRange(herramienta.PerfilesHerramientas.ToArray());
			chkPerfiles.ItemCheck+=new ItemCheckEventHandler(chkPerfiles_ItemCheck);
		}

		private mz.erp.businessrules.PerfilView GetPerfilHerramienta(businessrules.HerramientaEx herramienta, long IdPerfil)
		{
			bool existe = false;
			mz.erp.businessrules.PerfilView perfilHerramienta = null;
			int i = 0;
			while(!existe && herramienta.PerfilesHerramientas.Count > i)
			{
				perfilHerramienta = (mz.erp.businessrules.PerfilView)herramienta.PerfilesHerramientas[i];
				existe = perfilHerramienta.IdPerfil.Equals(IdPerfil);
				i++;
			}
			if(existe)
				return perfilHerramienta;
			else return null;

		}

		private mz.erp.businessrules.PerfilView GetPerfilChkPerfiles(long IdPerfil)
		{
			bool existe = false;
			mz.erp.businessrules.PerfilView perfilHerramienta = null;
			int i = 0;
			while(!existe && chkPerfiles.CheckedItems.Count > i)
			{
				perfilHerramienta = (mz.erp.businessrules.PerfilView)chkPerfiles.CheckedItems[i];
				existe = perfilHerramienta.IdPerfil.Equals(IdPerfil);
				i++;
			}
			if(existe)
				return perfilHerramienta;
			else return null;

		}
		private void UpdateTree()
		{
			mz.erp.businessrules.HerramientaEx hex = _uiController.HerramientaModificada;
			switch(hex.Modo)
			{				
				case "MODIF"://Modificacion de Menu
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode modifNode = ultraTreeMenu.GetNodeByKey(hex.IdHerramienta.ToString());
					if(modifNode != null)
					{
						string descripcionM = hex.Descripcion;
						if(hex.Habilitado)
							descripcionM = descripcionM + " (Habilitado)";
						else
							descripcionM = descripcionM + " (Deshabilitado)";
						modifNode.Text = descripcionM;
					}
					break;	
				}
				case "NEW"://Agrega Separador
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode addNode = ultraTreeMenu.GetNodeByKey(hex.IdHerramientaPadre.ToString());
					addNode.Nodes.Clear();
					UpdateTree(addNode);
					break;	
				}
				case "DEL"://Borra Separador
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode addNode = ultraTreeMenu.GetNodeByKey(hex.IdHerramientaPadre.ToString());
					addNode.Nodes.Clear();
					UpdateTree(addNode);
					break;	
				}
				case "ADD"://Agrega un Submenu
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode addNode = ultraTreeMenu.GetNodeByKey(hex.IdHerramientaPadre.ToString());
					addNode.Nodes.Clear();
					UpdateTree(addNode);
					break;	
				}

			}

		}


		private void SaveChanges()
		{	
			Util.MoveFocus(this.ultraExplorerBarContainerControl2);
			_uiController.Execute();
		}

		private void UpdateTree(Infragistics.Win.UltraWinTree.UltraTreeNode Node)
		{
			string key = Node.Key;
			_uiController.UpdateTree(key);
			while(_uiController.HasNext())
			{
				ArrayList nodo = _uiController.Next();
				string keyChildNode = Convert.ToString(nodo[0]);
				string descriptionChildNode = Convert.ToString(nodo[1]);
				Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);				
				if(!Node.Nodes.Exists(keyChildNode))
					Node.Nodes.Add(childNode);

			}
			int i = 0;
			foreach(Infragistics.Win.UltraWinTree.UltraTreeNode childNode in Node.Nodes)
			{
				string keyC = childNode.Key;
				_uiController.UpdateTree(keyC);
				while(_uiController.HasNext())
				{
					ArrayList nodo = _uiController.Next();
					string keyChildNode = Convert.ToString(nodo[0]);
					string descriptionChildNode = Convert.ToString(nodo[1]);
					Infragistics.Win.UltraWinTree.UltraTreeNode childChildNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
					if(!childNode.Nodes.Exists(keyChildNode))
						childNode.Nodes.Add(childChildNode);
				}
				i++;
			}

		}

		private bool isHabilitado(string description)
		{
			if(description.IndexOf("Habilitado") > 0)
				return true;
			else
				return false;
		
		}

		private string getDescriptionFrom(string description)
		{
			int pos = description.IndexOf("(") -1;
			if(pos >0)
				return description.Substring(0,pos);
			else
				return description;

		}
		private int GetComboItemIndex(string description)
		{
			bool existe = false;
			ComboItem comboItem = null;
			int i = 0;
			while(!existe && cmbImagenes.Items.Count > i)
			{
				comboItem = (ComboItem)cmbImagenes.Items[i];
				existe = comboItem.Etiqueta.Equals(description);
				i++;
			}
			if(existe)
				return comboItem.ImageIndex + 1;
			else return 0;

		}
		private void deshacerCambios(mz.erp.businessrules.HerramientaEx herramienta)
		{
			switch(herramienta.Modo)
			{
				case "MODIF":
				{					
					mz.erp.businessrules.Node nodeO = _uiController.UpdateNode(herramienta.IdHerramienta, herramienta.IdRecurso);
					Infragistics.Win.UltraWinTree.UltraTreeNode node = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramienta.ToString());
					node.Text = nodeO.Description;
					businessrules.HerramientaEx h = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
					this.txtTitulo.Text = h.Descripcion;
					if(h.ShortCut.Equals(String.Empty))
						cmbShortCut.SelectedIndex = 0;
					else
						cmbShortCut.SelectedItem = h.ShortCut;
					_uiController.Habilitado = h.Habilitado;
					chkHabilitado.Checked = _uiController.Habilitado;
					this.loadPerfiles(h);
					businessrules.HerramientaEx ImagenHerramienta = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_IMAGEN);
					if(ImagenHerramienta != null)
						cmbImagenes.SelectedIndex = this.GetComboItemIndex(ImagenHerramienta.Descripcion);
					else
						cmbImagenes.SelectedIndex = 0;
					txtOrden.Text = h.Orden.ToString();
					
					break;
				}
				case "NEW":
				{
					string IdRecurso = string.Empty;
					int pos = _uiController.CurrentKey.IndexOf("_");
					if(pos >0)
						IdRecurso = _uiController.CurrentKey.Substring(pos + 1);
					businessrules.HerramientaEx hex = _uiController.GetSeparador(IdRecurso);
					_uiController.RemoveSeparador(hex.IdHerramienta.ToString());
					break;
				}
				case "DEL":
				{
					_uiController.AddSeparador(herramienta);
					Infragistics.Win.UltraWinTree.UltraTreeNode addNode = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramientaPadre.ToString());
					addNode.Nodes.Clear();
					UpdateTree(addNode);
					break;
				}
				case "ADD":
				{
					this.txtTitulo.Text = herramienta.Descripcion;
					if(herramienta.ShortCut.Equals(String.Empty))
						cmbShortCut.SelectedIndex = 0;
					else
						cmbShortCut.SelectedItem = herramienta.ShortCut;
					//_uiController.Habilitado = herramienta.Habilitado;
					chkHabilitado.Checked = herramienta.Habilitado;
					if(herramienta.Imagen != null)
						cmbImagenes.SelectedIndex = this.GetComboItemIndex(herramienta.Imagen);
					else
						cmbImagenes.SelectedIndex = 0;
					txtOrden.Text = herramienta.Orden.ToString();
					txtId.Text = herramienta.Id;
					txtIdHerramienta.Text = herramienta.IdHerramienta.ToString();
					txtIdProceso.Text = "";
					txtProceso.Text = "";

					break;
				}

			}
		}

		private void InvertirVisiblePerfil(string visible)
		{
			businessrules.HerramientaEx herramienta = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
			foreach (businessrules.PerfilView perfilLB in listBoxPerfiles.SelectedItems)
			{
				businessrules.PerfilView perfil = GetPerfilChkPerfiles(perfilLB.IdPerfil);
				int pos = perfil.Descripcion.IndexOf("(") -1;
				if(pos >0)
					perfil.Descripcion = perfil.Descripcion.Substring(0,pos);
				perfil.Descripcion = perfil.Descripcion + visible;
				mz.erp.businessrules.PerfilView perfilHerramienta = GetPerfilHerramienta(herramienta, perfil.IdPerfil); 
				if(perfilHerramienta != null)
				{
					perfilHerramienta.Descripcion = perfil.Descripcion;
				}
			}
			chkPerfiles.Refresh();
			bool habilitado = false;
			if(chkHabilitado.Checked)
				habilitado = true;
			else
				habilitado = false;
			ComboItem item = cmbImagenes.SelectedItem as ComboItem;
			_uiController.AddHerramientaModificada(txtTitulo.Text, _uiController.CurrentKey , item.Etiqueta, cmbShortCut.SelectedItem.ToString(), habilitado, herramienta.PerfilesHerramientas, txtIdHerramientaPadre.Text, "MODIF", true);			
			listBoxPerfiles.Items.Clear();
			listBoxPerfiles.Items.AddRange(herramienta.PerfilesHerramientas.ToArray());
			chkPerfiles.Refresh();

		}

		private void expandir(businessrules.HerramientaEx herramienta)
		{
			Infragistics.Win.UltraWinTree.UltraTreeNode node = null;
			if(herramienta.IdTipoRecurso.Equals(businessrules.ConfigurarMenues.ID_TIPO_RECURSO_SEPARATOR))
				node = ultraTreeMenu.GetNodeByKey(herramienta.Descripcion);
			else
				node = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramienta.ToString());	
			if(node == null)
			{
				mz.erp.businessrules.HerramientaEx herramientaP = _uiController.GetHerramienta(herramienta.IdHerramientaPadre.ToString(), businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO); 
				this.expandir(herramientaP);
				if(herramienta.IdTipoRecurso.Equals(businessrules.ConfigurarMenues.ID_TIPO_RECURSO_SEPARATOR))
					node = ultraTreeMenu.GetNodeByKey(herramienta.Descripcion);
				else
					node = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramienta.ToString());
				this.expandir(node);
			}else
                this.expandir(node);

		}

		private void expandir(Infragistics.Win.UltraWinTree.UltraTreeNode node)
		{
			Infragistics.Win.UltraWinTree.UltraTreeNode parent = node.Parent;
			if(parent != null)
			{
				parent.Expanded = true;
				this.expandir(parent);
			}

		}

		private void ModificarOrdenes(short OrdenAnterior, short OrdenActual, long IdHerramientaPadre)
		{
			businessrules.HerramientaEx herramientaModif = _uiController.GetHerramientaModificadaConOrden(OrdenActual, IdHerramientaPadre);
			if(herramientaModif != null)
			{
				if(_uiController.SoloCambioOrden(herramientaModif))
				{
					Janus.Windows.GridEX.GridEXRow rowGE = gridEX1.GetRow(herramientaModif);
					gridEX1.Row = rowGE.Position;
					this.btnEliminar_Click(this, new EventArgs());
				}
				else
				{
					herramientaModif.Orden = OrdenAnterior;	
					businessrules.HerramientaEx hx = _uiController.GetHerramienta(herramientaModif.IdHerramienta.ToString(), businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
					hx.Orden = OrdenAnterior;
				}
				Infragistics.Win.UltraWinTree.UltraTreeNode addNode = ultraTreeMenu.GetNodeByKey(_uiController.ParentKey);
				addNode.Nodes.Clear();
				UpdateTree(addNode);
			}
		}
		#endregion

		#region Drag and Drop
		// Se ejecuta al clickear sobre un menu
		private void ultraTreeMenu_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((ultraTreeMenu.SelectedNodes.Count>0) && (modificando))
				DoDragDrop(this.ultraTreeMenu.SelectedNodes, DragDropEffects.Copy);
		}

		//Se ejecuta al pasar con el mouse
		private void txtHerramientaPadre_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			//if (_uiController.JerarquiaEditable("1", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			/*else
			{
				e.Effect = DragDropEffects.None;
				//MessageBox.Show(this,"No puede modificar esta jerarquia.", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
			}*/
		}
		
		//Se ejecuta al soltar el mouse
		private void txtHerramientaPadre_DragDrop(object sender, DragEventArgs e)
		{
			txtIdHerramientaPadre.TextChanged -= new EventHandler(txtIdHerramientaPadre_TextChanged);
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			string key = selectedNodes[0].Key;
			if (key != "RAIZ")
			{
				businessrules.HerramientaEx herramienta = _uiController.GetHerramienta(key, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
				txtIdHerramientaPadre.Text = herramienta.IdHerramienta.ToString();
				txtHerramientaPadre.Text = herramienta.Descripcion;
			}
			else
			{
				if (txtIdProceso.Text == "0")
				{
					txtIdHerramientaPadre.Text = null;
					txtHerramientaPadre.Text = selectedNodes[0].Text;
				}
			}
			txtIdHerramientaPadre.TextChanged += new EventHandler(txtIdHerramientaPadre_TextChanged);
		}

		#endregion

		private void txtHerramientaPadre_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtIdHerramientaPadre_TextChanged(object sender, EventArgs e)
		{
			string key = txtIdHerramientaPadre.Text;
            /* Silvina 20110805 - Tarea 0000184 */
            if (!string.IsNullOrEmpty(key))
            {
                businessrules.HerramientaEx herramienta = _uiController.GetHerramienta(key, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
                if (herramienta != null)
                    txtHerramientaPadre.Text = herramienta.Descripcion;
            }
            /* Fin Silvina 20110805 - Tarea 0000184 */
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{	
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:	//Guardar					
					SaveChanges();
					break;
				case 4:	//Salir					
					CloseForm();
					break;
			}						
		}

		private void cmbBarrasDeHerramientas_SelectedIndexChanged(object sender, EventArgs e)
		{
			_uiController.BarraHerramientaSeleccionada = (string) cmbBarrasDeHerramientas.SelectedItem;
			ultraTreeMenu.Nodes.Clear();
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Menu";
			this.ultraTreeMenu.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																									ultraTreeNode1});
			UpdateTree(ultraTreeMenu.Nodes[0]);
			_expandir = false;
			ultraTreeMenu.Nodes[0].Expanded = true;
			_expandir = true;

		}

		private void cmbBarraDeHerramientasNueva_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ultraTreeAgrupamientos_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (_expandir) {UpdateTree(e.TreeNode);}
		}

		private void ultraTreeAgrupamientos_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (e.TreeNode.Key != "RAIZ")
			{
				_uiController.CurrentKey = e.TreeNode.Key;
				_uiController.CurrentDescription = e.TreeNode.Text;
				//this.btnVerTodas_Click(this, new EventArgs());
				//if(_uiController.CurrentKey != "RAIZ" && _uiController.CurrentDescription != "Separador")
				if(_uiController.CurrentDescription != "Separador")
				{
					_uiController.ParentKey = e.TreeNode.Parent.Key;
					_uiController.ParentDescription = e.TreeNode.Parent.Text;
					btnModificar.Enabled = true;
					if ((_uiController.IdBarraDeHerramientaSeleccionada == 1) && (_uiController.CurrentIdProcess != 0))
						btnAgregarBarra.Enabled = true;
					else
						btnAgregarBarra.Enabled = false;

					if ((_uiController.IdBarraDeHerramientaSeleccionada == 2) || (_uiController.IdBarraDeHerramientaSeleccionada == 3))
						btnEliminarBarra.Enabled = true;
					else
						btnEliminarBarra.Enabled = false;

					/*chkHabilitado.Enabled = true;
					cmbImagenes.Enabled = true;
					cmbShortCut.Enabled = true;
					txtTitulo.Enabled = true;
					chkPerfiles.Enabled = true;
					btnTodos.Enabled = true;
					btnNinguno.Enabled = true;
					btnInvertir.Enabled = true;
					btnVerSeleccionados.Enabled = true;
					btnVerTodas.Enabled = true;
					btnAgregarSeparador.Enabled = false;
					btnEliminarSeparador.Enabled = false;
					btnBajar.Enabled = false;
					btnSubir.Enabled = false;
					if(_uiController.IdBarraDeHerramientaSeleccionada == 1)					
					{
						btnBajar.Enabled = true;
						btnSubir.Enabled = true;
						if(_uiController.ParentKey != "RAIZ")
						{
							businessrules.HerramientaEx separador = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_SEPARATOR);
							if(separador == null)
								btnAgregarSeparador.Enabled = true;
						}
					}*/
					businessrules.HerramientaEx herramienta = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
					/*if(herramienta.PerfilesHerramientas.Count > 0)
					{
						btnVisibilizar.Enabled = true;
						btnInvisibilizar.Enabled = true;
						listBoxPerfiles.Enabled = true;

					}
					else
					{
						btnVisibilizar.Enabled = false;
						btnInvisibilizar.Enabled = false;
						listBoxPerfiles.Enabled = false;

					}*/
					this.txtTitulo.Text = herramienta.Descripcion;
					if(herramienta.ShortCut.Equals(String.Empty))
						cmbShortCut.SelectedIndex = 0;
					else
						cmbShortCut.SelectedItem = herramienta.ShortCut;
					_uiController.Habilitado = herramienta.Habilitado;
					chkHabilitado.Checked = _uiController.Habilitado;
					txtIdHerramienta.Text = _uiController.CurrentKey;
					txtProceso.Text = _uiController.CurrentDescriptionProcess;
					toolTip1.SetToolTip(txtProceso, txtProceso.Text);			

					txtIdProceso.Text = _uiController.CurrentIdProcess.ToString();
					txtId.Text = herramienta.Id;
					txtIdHerramientaPadre.Text = herramienta.IdHerramientaPadre.ToString();

					businessrules.HerramientaEx herramientaPadre = _uiController.GetHerramienta(herramienta.IdHerramientaPadre.ToString(), businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
					if (herramientaPadre != null)
					{
						txtHerramientaPadre.Text = herramientaPadre.Descripcion;
					}
					this.loadPerfiles(herramienta);
					cmbImagenes.SelectedIndex = this.GetComboItemIndex(herramienta.Imagen);
					/*businessrules.HerramientaEx ImagenHerramienta = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_IMAGEN);
					if(ImagenHerramienta != null)
						cmbImagenes.SelectedIndex = this.GetComboItemIndex(ImagenHerramienta.Descripcion);
					else
						cmbImagenes.SelectedIndex = 0;*/
					txtOrden.Text = herramienta.Orden.ToString();
					cmbBarraDeHerramientasNueva.SelectedItem = cmbBarrasDeHerramientas.SelectedItem;
				}
				else
				{
					/*btnModificar.Enabled = false;
					chkHabilitado.Enabled = false;
					cmbImagenes.Enabled = false;
					cmbShortCut.Enabled = false;
					txtTitulo.Enabled = false;
					chkPerfiles.Enabled = false;
					btnTodos.Enabled = false;
					btnNinguno.Enabled = false;
					btnInvertir.Enabled = false;
					btnVerSeleccionados.Enabled = false;
					btnVerTodas.Enabled = false;
					btnVisibilizar.Enabled = false;
					btnInvisibilizar.Enabled = false;
					listBoxPerfiles.Enabled = false;
					btnAgregarSeparador.Enabled = false;
					btnEliminarSeparador.Enabled = false;
					btnBajar.Enabled = false;
					btnSubir.Enabled = false;
					if(_uiController.IdBarraDeHerramientaSeleccionada == 1 && _uiController.CurrentKey != "RAIZ")
						btnEliminarSeparador.Enabled = true;*/
					this.txtTitulo.Text = this.getDescriptionFrom(_uiController.CurrentDescription);
					chkPerfiles.Items.Clear();
					chkPerfiles.Items.AddRange(_uiController.Perfiles.ToArray());
					listBoxPerfiles.Items.Clear();
					txtOrden.Text = string.Empty;
					txtIdProceso.Text = "";
					txtProceso.Text = "";
					txtId.Text = "";
				}	
			}
			else
			{
				ResetearCampos();
			}
		}

		private void ResetearCampos()
		{
			txtTitulo.Text = "";
			cmbImagenes.SelectedIndex = 0;
			cmbShortCut.SelectedIndex = 0;
			txtIdProceso.Text = "";
			txtIdHerramientaPadre.Text = "0";
			txtOrden.Text = "";
			txtId.Text = "";
			txtIdHerramienta.Text = "";
			txtHerramientaPadre.Text = "";
			txtProceso.Text = "";
			txtIdProceso.Text = "0";
			chkHabilitado.Checked = false;
		}

		private void cmbImagenes_DrawItem(object sender, DrawItemEventArgs e)
		{
			ComboItem item = cmbImagenes.Items[e.Index] as ComboItem;
			e.DrawBackground();   
			if (item.ImageIndex >= 0 && item.ImageIndex < imageList.Images.Count) 
				e.Graphics.DrawImage(imageList.Images[item.ImageIndex], new PointF(e.Bounds.Left, e.Bounds.Top));   
			e.Graphics.DrawString(item.Etiqueta, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.Left + imageList.ImageSize.Width + 1, e.Bounds.Top));
		}

		
		private void _uiController_HerramientasExModificadasHasChanged(object sender, EventArgs e)
		{			
			gridEX1.SelectionChanged-=new EventHandler(gridEX1_SelectionChanged);

			this.gridEX1.SetDataBinding( null, null );
			this.gridEX1.SetDataBinding(_uiController.HerramientasExModificadas, null );
			if(_uiController.HerramientasExModificadas.Count > 0)
                btnEliminar.Enabled = true;
			else
				btnEliminar.Enabled = false;
			this.UpdateTree();
			gridEX1.SelectionChanged+=new EventHandler(gridEX1_SelectionChanged);

		}



		private void chkPerfiles_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if(_uiController.CurrentKey != "RAIZ" && _uiController.CurrentDescription != "Separador")
			{
				int index = e.Index;
				if(e.NewValue.Equals(System.Windows.Forms.CheckState.Checked))
				{
					businessrules.PerfilView perfil = (businessrules.PerfilView)chkPerfiles.Items[index];
					perfil.Descripcion = perfil.Descripcion + " ("+ _uiController.DefaultVisible + ")";
					_uiController.AddPerfilHerramienta(_uiController.CurrentKey, perfil);
				}
				else
				{
					businessrules.PerfilView perfil = (businessrules.PerfilView)chkPerfiles.Items[index];
					_uiController.RemovePerfilHerramienta(_uiController.CurrentKey, perfil);
					int pos = perfil.Descripcion.IndexOf("(") -1;
					if(pos >0)
						perfil.Descripcion = perfil.Descripcion.Substring(0,pos);
				}
				bool habilitado = false;
				if(chkHabilitado.Checked)
					habilitado = true;
				else
					habilitado = false;
				ComboItem item = cmbImagenes.SelectedItem as ComboItem;
				businessrules.HerramientaEx herramienta = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
				_uiController.AddHerramientaModificada(txtTitulo.Text, _uiController.CurrentKey , item.Etiqueta, cmbShortCut.SelectedItem.ToString(), habilitado, herramienta.PerfilesHerramientas, txtIdHerramientaPadre.Text, "MODIF", true);			
				listBoxPerfiles.Items.Clear();
				listBoxPerfiles.Items.AddRange(herramienta.PerfilesHerramientas.ToArray());
				if(herramienta.PerfilesHerramientas.Count > 0)
				{
					btnVisibilizar.Enabled = true;
					btnInvisibilizar.Enabled = true;
					listBoxPerfiles.Enabled = true;

				}
				else
				{
					btnVisibilizar.Enabled = false;
					btnInvisibilizar.Enabled = false;
					listBoxPerfiles.Enabled = false;

				}
			}
		}

		private void gridEX1_SelectionChanged(object sender, EventArgs e)
		{			
			mz.erp.businessrules.HerramientaEx herramienta = (mz.erp.businessrules.HerramientaEx) gridEX1.SelectedItems[0].GetRow().DataRow;				
			/*if(!herramienta.IdBarraHerramienta.Equals(_uiController.IdBarraDeHerramientaSeleccionada))
			{
				cmbBarrasDeHerramientas.SelectedItem = _uiController.GetBarraHerramienta(herramienta.IdBarraHerramienta);
			}*/
			if(herramienta.Modo.Equals("ADD")||herramienta.Modo.Equals("ADD_ESTANDAR")||herramienta.Modo.Equals("ADD_EXPLORACION"))
			{							
				deshacerCambios(herramienta);
			}
			else
			{
				if(!herramienta.Modo.Equals("DEL"))
				{							
					this.expandir(herramienta);
					Infragistics.Win.UltraWinTree.UltraTreeNode node = null;
					if(herramienta.IdTipoRecurso.Equals(businessrules.ConfigurarMenues.ID_TIPO_RECURSO_SEPARATOR))
						node = ultraTreeMenu.GetNodeByKey(herramienta.Descripcion);
					else
						node = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramienta.ToString());	
					ultraTreeMenu.SelectedNodes.Clear();
					ultraTreeMenu.ActiveNode= node;		
					ultraTreeMenu.ActiveNode.Selected = true;
				}
			}
		}

		private void gridEX1_Click(object sender, EventArgs e)
		{
			if(gridEX1.SelectedItems.Count > 0)
				this.gridEX1_SelectionChanged(sender, new EventArgs());

		}

		private void btnTodos_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkPerfiles.Items.Count; i++)
			{
				if(i +1 == chkPerfiles.Items.Count)// si es el ultimo
					_processItem = true;
				chkPerfiles.SetItemChecked(i, true);			
			}
		}

		private void btnNinguno_Click(object sender, System.EventArgs e)
		{
			/*_processItem = false;
			for(int i = 0; i<chkPerfiles.Items.Count; i++)
			{
				if(i +1 == chkPerfiles.Items.Count)// si es el ultimo
					_processItem = true;
				chkPerfiles.SetItemChecked(i, false);			
			}*/
			NingunPerfil();
		}

		private void NingunPerfil()
		{
			_processItem = false;
			for(int i = 0; i<chkPerfiles.Items.Count; i++)
			{
				if(i +1 == chkPerfiles.Items.Count)// si es el ultimo
					_processItem = true;
				chkPerfiles.SetItemChecked(i, false);			
			}
		}

		private void btnInvertir_Click(object sender, System.EventArgs e)
		{
			_processItem = false;
			for(int i = 0; i<chkPerfiles.Items.Count; i++)
			{
				if(i +1 == chkPerfiles.Items.Count)// si es el ultimo
					_processItem = true;
				chkPerfiles.SetItemChecked(i, !chkPerfiles.GetItemChecked(i));
			}
		}

		private void btnVerSeleccionados_Click(object sender, System.EventArgs e)
		{
			chkPerfiles.ItemCheck-=new ItemCheckEventHandler(chkPerfiles_ItemCheck);
			businessrules.HerramientaEx h = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
			chkPerfiles.Items.Clear();
			chkPerfiles.Items.AddRange(h.PerfilesHerramientas.ToArray());
			_processItem = false;
			for(int i = 0; i<chkPerfiles.Items.Count; i++)
			{
				if(i +1 == chkPerfiles.Items.Count)// si es el ultimo
					_processItem = true;
				chkPerfiles.SetItemChecked(i, true);	
			}
			chkPerfiles.ItemCheck+=new ItemCheckEventHandler(chkPerfiles_ItemCheck);
		}

		private void btnVerTodas_Click(object sender, System.EventArgs e)
		{
			businessrules.HerramientaEx h = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
			if(h != null)
				loadPerfiles(h);

		}

		private void btnVisibilizar_Click(object sender, System.EventArgs e)
		{
			this.InvertirVisiblePerfil(" (Visible)");
		}

		private void btnInvisibilizar_Click(object sender, System.EventArgs e)
		{
			this.InvertirVisiblePerfil(" (No Visible)");
		}

		private void btnAgregarSeparador_Click(object sender, System.EventArgs e)
		{
			_uiController.AddSeparador(_uiController.CurrentKey);			
			btnAgregarSeparador.Enabled = false;	
			Infragistics.Win.UltraWinTree.UltraTreeNode node = null;
			businessrules.HerramientaEx herramienta = _uiController.HerramientaModificada;
			if(herramienta.IdTipoRecurso.Equals(businessrules.ConfigurarMenues.ID_TIPO_RECURSO_SEPARATOR))
				node = ultraTreeMenu.GetNodeByKey(herramienta.Descripcion);
			else
				node = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramienta.ToString());
			ultraTreeMenu.SelectedNodes.Clear();
			ultraTreeMenu.ActiveNode= node;		
			ultraTreeMenu.ActiveNode.Selected = true;
			this.expandir(node);
			gridEX1.Row = gridEX1.RowCount - 1;

            		
		}

		private void btnEliminarSeparador_Click(object sender, System.EventArgs e)
		{
			string IdRecurso = string.Empty;
			int pos = _uiController.CurrentKey.IndexOf("_");
			if(pos >0)
				IdRecurso = _uiController.CurrentKey.Substring(pos + 1);
			businessrules.HerramientaEx hex = _uiController.GetSeparador(IdRecurso);
			if(hex.Modo.Equals("NEW"))
				this.btnEliminar_Click(sender, new EventArgs());
			else
				_uiController.RemoveSeparador(hex.IdHerramienta.ToString());
			btnEliminarSeparador.Enabled = false;
			if(_uiController.HerramientasExModificadas.Count > 0)
				gridEX1.Row = gridEX1.RowCount - 1;
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.HerramientasExModificadas];
			int pos = cm.Position;
			if(pos >= 0)
			{
				mz.erp.businessrules.HerramientaEx hex = (mz.erp.businessrules.HerramientaEx) gridEX1.SelectedItems[0].GetRow().DataRow;				
				long IdHerrameinta = hex.IdHerramienta;
				short OrdenAnterior = hex.Orden;
				this.deshacerCambios(hex);
				cm.RemoveAt(pos);
				cm.Refresh();				
				businessrules.HerramientaEx h = _uiController.GetHerramienta(IdHerrameinta.ToString(), businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
				if (h != null)
				{
					short OrdenActual = h.Orden;
					ArrayList herramientasRecurso = _uiController.GetHerramientasRecurso(h.IdRecurso);
					foreach(businessrules.HerramientaEx hr in herramientasRecurso)
						if(hr.IdHerramienta != h.IdHerramienta)
						{
							businessrules.HerramientaEx herramientaModif =_uiController.GetHerramientaModificada(hr.IdHerramienta);
							if(herramientaModif != null)
							{
								string description = h.Descripcion;
								businessrules.HerramientaEx hx = _uiController.GetHerramienta(hr.IdHerramienta.ToString(), businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
								hx.Descripcion = description;
								if(_uiController.SoloCambioDescripcion(herramientaModif))
								{
									Janus.Windows.GridEX.GridEXRow rowGE = gridEX1.GetRow(herramientaModif);
									gridEX1.Row = rowGE.Position;
									this.btnEliminar_Click(sender, new EventArgs());
								}
								else
								{
									herramientaModif.Descripcion = description;	
									this.txtTitulo.Text = description;
									bool habilitado = herramientaModif.Habilitado;
									if(habilitado)
										description = description + " (Habilitado)";
									else
										description = description + " (Deshabilitado)";
									Infragistics.Win.UltraWinTree.UltraTreeNode nodeR = ultraTreeMenu.GetNodeByKey(hr.IdHerramienta.ToString());
									nodeR.Text = description;									

								}
							}
						}
				
					if(OrdenAnterior != OrdenActual)
						this.ModificarOrdenes(OrdenAnterior, OrdenActual, hex.IdHerramientaPadre);
				}
			}		
			if(_uiController.HerramientasExModificadas.Count == 0)
			{
				btnEliminar.Enabled = false;	
				btnEliminarSeparador.Enabled = false;
			}
		
		}

		private void btnBajar_Click(object sender, System.EventArgs e)
		{
			bool modifica = _uiController.ModificarOrdenBajar(_uiController.CurrentKey);		
			if(modifica)
			{
				Infragistics.Win.UltraWinTree.UltraTreeNode addNode = ultraTreeMenu.GetNodeByKey(_uiController.ParentKey);
				addNode.Nodes.Clear();
				UpdateTree(addNode);
				businessrules.HerramientaEx herramienta = _uiController.HerramientaModificada;
				Infragistics.Win.UltraWinTree.UltraTreeNode node = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramienta.ToString());
				ultraTreeMenu.SelectedNodes.Clear();
				ultraTreeMenu.ActiveNode= node;		
				ultraTreeMenu.ActiveNode.Selected = true;
				this.expandir(node);
			}
		}

		private void btnSubir_Click(object sender, System.EventArgs e)
		{
			bool modifica = _uiController.ModificarOrdenSubir(_uiController.CurrentKey);		
			if(modifica)
			{
				Infragistics.Win.UltraWinTree.UltraTreeNode addNode = ultraTreeMenu.GetNodeByKey(_uiController.ParentKey);
				addNode.Nodes.Clear();
				UpdateTree(addNode);
				businessrules.HerramientaEx herramienta = _uiController.HerramientaModificada;
				Infragistics.Win.UltraWinTree.UltraTreeNode node = ultraTreeMenu.GetNodeByKey(herramienta.IdHerramienta.ToString());
				ultraTreeMenu.SelectedNodes.Clear();
				ultraTreeMenu.ActiveNode= node;		
				ultraTreeMenu.ActiveNode.Selected = true;
				this.expandir(node);
			}

		}

		private void btnAgregarSubmenu_Click(object sender, EventArgs e)
		{
			ultraTreeMenu.AfterActivate -=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);

			ResetearCampos();
			txtHerramientaPadre.ReadOnly = false;
			txtIdHerramientaPadre.ReadOnly = false;
			txtId.ReadOnly = false;
			//txtIdHerramienta.Enabled = true;
			chkHabilitado.Enabled = true;
			cmbShortCut.Enabled = true;
			//txtOrden.Enabled = true;
			txtTitulo.ReadOnly = false;
			cmbImagenes.Enabled = true;

			/*chkPerfiles.Enabled = true;
			btnTodos.Enabled = true;
			btnNinguno.Enabled = true;
			btnInvertir.Enabled = true;
			btnVerSeleccionados.Enabled = true;
			btnVerTodas.Enabled = true;
			btnVisibilizar.Enabled = true;
			btnInvisibilizar.Enabled = true;
			listBoxPerfiles.Enabled = true;*/

			btnAgregarSubmenu.Enabled = false;
			btnAceptarSubmenu.Enabled = true;
			btnCancelarSubmenu.Enabled = true;
			btnModificar.Enabled = false;
			btnAgregarBarra.Enabled = false;
			btnEliminarBarra.Enabled = false;

			chkPerfiles.ItemCheck -= new ItemCheckEventHandler(chkPerfiles_ItemCheck);
			NingunPerfil();
			chkPerfiles.ItemCheck += new ItemCheckEventHandler(chkPerfiles_ItemCheck);
            /* Silvina 20110805 - Tarea 0000184 */
            modificando = true;
            /* Fin Silvina 20110805 - Tarea 0000184 */
		}

		private void btnAceptarSubmenu_Click(object sender, EventArgs e)
		{
			bool habilitado = false;
			if(chkHabilitado.Checked)
				habilitado = true;
			else
				habilitado = false;
			ComboItem item = cmbImagenes.SelectedItem as ComboItem;
			ArrayList perfilesSeleccionados = new ArrayList();
			//perfilesSeleccionados.AddRange(chkPerfiles.CheckedItems);

            /* Silvina 20110805 - Tarea 0000184 */          

			bool ok = _uiController.AddSubmenu(txtTitulo.Text, item.Etiqueta, cmbShortCut.SelectedItem.ToString(), habilitado, txtIdHerramientaPadre.Text, txtId.Text);			
			//_uiController.AddHerramientaModificada(txtTitulo.Text, _uiController.CurrentKey , item.Etiqueta, cmbShortCut.SelectedItem.ToString(), habilitado, perfilesSeleccionados, txtIdHerramientaPadre.Text, txtOrden.Text, "ADD", true);			
            if (ok)
            {
                Janus.Windows.GridEX.GridEXRow rowGE = gridEX1.GetRow(_uiController.HerramientaModificada);
                gridEX1.Row = rowGE.Position;

                txtHerramientaPadre.ReadOnly = true;
                txtIdHerramientaPadre.ReadOnly = true;
                txtId.ReadOnly = true;
                //txtIdHerramienta.Enabled = false;
                chkHabilitado.Enabled = false;
                cmbShortCut.Enabled = false;
                //txtOrden.Enabled = false;
                txtTitulo.ReadOnly = true;
                cmbImagenes.Enabled = false;

                btnAgregarSubmenu.Enabled = true;
                btnAceptarSubmenu.Enabled = false;
                btnCancelarSubmenu.Enabled = false;
                //btnAgregarBarra.Enabled = true;

                /* Silvina 20110805 - Tarea 0000184 */
                modificando = false;
                /* Fin Silvina 20110805 - Tarea 0000184 */

                ultraTreeMenu.AfterActivate += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
            }
            /* Fin Silvina 20110805 - Tarea 0000184 */	
		}

		private void btnCancelarSubmenu_Click(object sender, EventArgs e)
		{
			txtHerramientaPadre.ReadOnly = true;
			txtIdHerramientaPadre.ReadOnly = true;
			txtId.ReadOnly = true;
			//txtIdHerramienta.Enabled = false;
			chkHabilitado.Enabled = false;
			cmbShortCut.Enabled = false;
			//txtOrden.Enabled = false;
			txtTitulo.ReadOnly = true;
			cmbImagenes.Enabled = false;

			btnAgregarSubmenu.Enabled = true;
			btnAceptarSubmenu.Enabled = false;
			btnCancelarSubmenu.Enabled = false;
			//btnAgregarBarra.Enabled = true;

            /* Silvina 20110805 - Tarea 0000184 */
            modificando = false;
            /* Fin Silvina 20110805 - Tarea 0000184 */

			ultraTreeMenu.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);

		}


		private void btnAgregarBarra_Click(object sender, EventArgs e)
		{
			ultraTreeMenu.AfterActivate -=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);

			cmbBarraDeHerramientasNueva.Enabled = true;

			btnAgregarSubmenu.Enabled = false;
			btnAceptarBarra.Enabled = true;
			btnCancelarBarra.Enabled = true;
			btnModificar.Enabled = false;
			btnAgregarBarra.Enabled = false;		
			btnEliminarBarra.Enabled = false;
			estado = "AGREGAR";
		}

		private void btnEliminarBarra_Click(object sender, EventArgs e)
		{
			ultraTreeMenu.AfterActivate -=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);

			//cmbBarraDeHerramientasNueva.Enabled = true;

			btnAgregarSubmenu.Enabled = false;
			btnAceptarBarra.Enabled = true;
			btnCancelarBarra.Enabled = true;
			btnModificar.Enabled = false;
			btnAgregarBarra.Enabled = false;		
			btnEliminarBarra.Enabled = false;
			estado = "ELIMINAR";
		}

		private void btnAceptarBarra_Click(object sender, EventArgs e)
		{
			if (estado.Equals("AGREGAR"))
			{
				string barra = cmbBarraDeHerramientasNueva.SelectedItem.ToString();

				_uiController.AddBarra(txtIdHerramienta.Text, barra);			
				Janus.Windows.GridEX.GridEXRow rowGE = gridEX1.GetRow(_uiController.HerramientaModificada);
				gridEX1.Row = rowGE.Position;

				cmbBarraDeHerramientasNueva.Enabled = false;

				btnAgregarSubmenu.Enabled = true;
				btnAceptarBarra.Enabled = false;
				btnCancelarBarra.Enabled = false;
				btnModificar.Enabled = true;
				//btnAgregarBarra.Enabled = true;	

			}
			else
			{// estado = "ELIMINAR"
				string barra = cmbBarrasDeHerramientas.SelectedItem.ToString();

				_uiController.RemoveBarra(txtIdHerramienta.Text, barra);			
				Janus.Windows.GridEX.GridEXRow rowGE = gridEX1.GetRow(_uiController.HerramientaModificada);
				gridEX1.Row = rowGE.Position;

				btnAgregarSubmenu.Enabled = true;
				btnAceptarBarra.Enabled = false;
				btnCancelarBarra.Enabled = false;
				btnModificar.Enabled = true;
			}
			ultraTreeMenu.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
		}

		private void btnCancelarBarra_Click(object sender, EventArgs e)
		{
			cmbBarraDeHerramientasNueva.Enabled = false;

			btnAgregarSubmenu.Enabled = true;
			btnAceptarBarra.Enabled = false;
			btnCancelarBarra.Enabled = false;
			btnModificar.Enabled = true;
			//btnAgregarBarra.Enabled = true;	

			ultraTreeMenu.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
		}

		private void btnModificar_Click(object sender, System.EventArgs e)
		{
			ultraTreeMenu.AfterActivate -=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);

			btnModificar.Enabled = false;
			btnAceptarModificacion.Enabled = true;
			btnCancelarModificacion.Enabled = true;
			btnAgregarSubmenu.Enabled = false;

			if(_uiController.CurrentDescription != "Separador")
			{
				chkHabilitado.Enabled = true;
				cmbImagenes.Enabled = true;
				cmbShortCut.Enabled = true;
				//cmbBarraDeHerramientasNueva.Enabled = true;
				txtTitulo.ReadOnly = false;
				chkPerfiles.Enabled = true;
				btnTodos.Enabled = true;
				btnNinguno.Enabled = true;
				btnInvertir.Enabled = true;
				btnVerSeleccionados.Enabled = true;
				btnVerTodas.Enabled = true;
				btnAgregarSeparador.Enabled = false;
				btnEliminarSeparador.Enabled = false;
				btnBajar.Enabled = false;
				btnSubir.Enabled = false;
				txtHerramientaPadre.ReadOnly = false;
				txtIdHerramientaPadre.ReadOnly = false;
				if(_uiController.IdBarraDeHerramientaSeleccionada == 1)					
				{
					btnBajar.Enabled = true;
					btnSubir.Enabled = true;
					if(_uiController.ParentKey != "RAIZ")
					{
						businessrules.HerramientaEx separador = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_SEPARATOR);
						if(separador == null)
							btnAgregarSeparador.Enabled = true;
					}
				}
				businessrules.HerramientaEx herramienta = _uiController.GetHerramienta(_uiController.CurrentKey, businessrules.ConfigurarMenues.ID_TIPO_RECURSO_TITULO);
				if(herramienta.PerfilesHerramientas.Count > 0)
				{
					btnVisibilizar.Enabled = true;
					btnInvisibilizar.Enabled = true;
					listBoxPerfiles.Enabled = true;
				}
				else
				{
					btnVisibilizar.Enabled = false;
					btnInvisibilizar.Enabled = false;
					listBoxPerfiles.Enabled = false;

				}
				cmbShortCut.Enabled = true;
			}
			else
			{
				chkHabilitado.Enabled = false;
				cmbImagenes.Enabled = false;
				cmbShortCut.Enabled = false;
				txtTitulo.ReadOnly = true;
				chkPerfiles.Enabled = false;
				btnTodos.Enabled = false;
				btnNinguno.Enabled = false;
				btnInvertir.Enabled = false;
				btnVerSeleccionados.Enabled = false;
				btnVerTodas.Enabled = false;
				btnVisibilizar.Enabled = false;
				btnInvisibilizar.Enabled = false;
				listBoxPerfiles.Enabled = false;
				btnAgregarSeparador.Enabled = false;
				btnEliminarSeparador.Enabled = false;
				btnBajar.Enabled = false;
				btnSubir.Enabled = false;
				if(_uiController.IdBarraDeHerramientaSeleccionada == 1 && _uiController.CurrentKey != "RAIZ")
					btnEliminarSeparador.Enabled = true;
			}	
			modificando = true;
		}

		private void btnAceptarModificacion_Click(object sender, EventArgs e)
		{
			if(_uiController.CurrentKey != "RAIZ")
			{
				bool habilitado = false;
				if(chkHabilitado.Checked)
					habilitado = true;
				else
					habilitado = false;
				ComboItem item = cmbImagenes.SelectedItem as ComboItem;
				ArrayList perfilesSeleccionados = new ArrayList();
				perfilesSeleccionados.AddRange(chkPerfiles.CheckedItems);
				_uiController.AddHerramientaModificada(txtTitulo.Text, _uiController.CurrentKey , item.Etiqueta, cmbShortCut.SelectedItem.ToString(), habilitado, perfilesSeleccionados, txtIdHerramientaPadre.Text, "MODIF", true);			
				Janus.Windows.GridEX.GridEXRow rowGE = gridEX1.GetRow(_uiController.HerramientaModificada);
				gridEX1.Row = rowGE.Position;
			}

			btnModificar.Enabled = true;
			btnAgregarSubmenu.Enabled = true;
			btnAceptarModificacion.Enabled = false;
			btnCancelarModificacion.Enabled = false;

			chkHabilitado.Enabled = false;
			cmbImagenes.Enabled = false;
			cmbShortCut.Enabled = false;
			cmbBarraDeHerramientasNueva.Enabled = false;
			txtTitulo.ReadOnly = true;
			chkPerfiles.Enabled = false;
			btnTodos.Enabled = false;
			btnNinguno.Enabled = false;
			btnInvertir.Enabled = false;
			btnVerSeleccionados.Enabled = false;
			btnVerTodas.Enabled = false;
			btnAgregarSeparador.Enabled = false;
			btnEliminarSeparador.Enabled = false;
			btnBajar.Enabled = false;
			btnSubir.Enabled = false;
			btnVisibilizar.Enabled = false;
			btnInvisibilizar.Enabled = false;
			listBoxPerfiles.Enabled = false;
			txtHerramientaPadre.ReadOnly = true;
			txtIdHerramientaPadre.ReadOnly = true;

			modificando = false;

			ultraTreeMenu.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
		}

		private void btnCancelarModificacion_Click(object sender, EventArgs e)
		{
			btnModificar.Enabled = true;
			btnAceptarModificacion.Enabled = false;
			btnCancelarModificacion.Enabled = false;
			btnAgregarSubmenu.Enabled = true;

			chkHabilitado.Enabled = false;
			cmbImagenes.Enabled = false;
			cmbShortCut.Enabled = false;
			cmbBarraDeHerramientasNueva.Enabled = false;
			txtTitulo.ReadOnly = true;
			chkPerfiles.Enabled = false;
			btnTodos.Enabled = false;
			btnNinguno.Enabled = false;
			btnInvertir.Enabled = false;
			btnVerSeleccionados.Enabled = false;
			btnVerTodas.Enabled = false;
			btnAgregarSeparador.Enabled = false;
			btnEliminarSeparador.Enabled = false;
			btnBajar.Enabled = false;
			btnSubir.Enabled = false;
			btnVisibilizar.Enabled = false;
			btnInvisibilizar.Enabled = false;
			listBoxPerfiles.Enabled = false;
			txtHerramientaPadre.ReadOnly = true;
			txtIdHerramientaPadre.ReadOnly = true;

			modificando = false;

			ultraTreeMenu.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
		}

	}
}

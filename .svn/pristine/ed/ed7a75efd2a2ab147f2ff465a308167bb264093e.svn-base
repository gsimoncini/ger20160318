using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmVisualizacionDeStock.
	/// </summary>
	public class FrmAbmVisualizacionDeStock : System.Windows.Forms.Form, ITaskForm
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
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTreeVisualizacionesDeStock;
		private System.Windows.Forms.TextBox txtNombreVisualizacion;
		private Infragistics.Win.Misc.UltraButton btnAgregarVisualizacion;
		private Infragistics.Win.Misc.UltraButton btnModificarVisualizacion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbbNegativa;
		private System.Windows.Forms.RadioButton rbPositiva;
		private Infragistics.Win.Misc.UltraButton btnAgregarEstadoAVisualizacion;
		private Infragistics.Win.Misc.UltraButton btnEliminarEstadoDeVisualizacion;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Infragistics.Win.Misc.UltraButton btnModificarOperacionEstadoVisualizacion;
		private mz.erp.ui.controls.mzComboEditor cmbEstadosDeStock;
		private System.Windows.Forms.TextBox txtNombreVisualizacionPadre;
		private System.Windows.Forms.TextBox txtEstadoDeStock;
		private System.Windows.Forms.GroupBox groupBoxOperacion;
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmVisualizacionDeStock));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbEstadosDeStock = new mz.erp.ui.controls.mzComboEditor();
			this.btnModificarOperacionEstadoVisualizacion = new Infragistics.Win.Misc.UltraButton();
			this.txtEstadoDeStock = new System.Windows.Forms.TextBox();
			this.txtNombreVisualizacionPadre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnEliminarEstadoDeVisualizacion = new Infragistics.Win.Misc.UltraButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAgregarEstadoAVisualizacion = new Infragistics.Win.Misc.UltraButton();
			this.groupBoxOperacion = new System.Windows.Forms.GroupBox();
			this.rbbNegativa = new System.Windows.Forms.RadioButton();
			this.rbPositiva = new System.Windows.Forms.RadioButton();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.ultraTreeVisualizacionesDeStock = new Infragistics.Win.UltraWinTree.UltraTree();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.btnAgregarVisualizacion = new Infragistics.Win.Misc.UltraButton();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombreVisualizacion = new System.Windows.Forms.TextBox();
			this.btnModificarVisualizacion = new Infragistics.Win.Misc.UltraButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmbEstadosDeStock)).BeginInit();
			this.groupBoxOperacion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTreeVisualizacionesDeStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(734, 25);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(734, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.groupBox2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraTreeVisualizacionesDeStock);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnAgregarVisualizacion);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.chkActivo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.txtNombreVisualizacion);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnModificarVisualizacion);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 108);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(734, 520);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.cmbEstadosDeStock);
			this.groupBox2.Controls.Add(this.btnModificarOperacionEstadoVisualizacion);
			this.groupBox2.Controls.Add(this.txtEstadoDeStock);
			this.groupBox2.Controls.Add(this.txtNombreVisualizacionPadre);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnEliminarEstadoDeVisualizacion);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.btnAgregarEstadoAVisualizacion);
			this.groupBox2.Controls.Add(this.groupBoxOperacion);
			this.groupBox2.Location = new System.Drawing.Point(208, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(504, 128);
			this.groupBox2.TabIndex = 107;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Asociación de Estados de Stock";
			// 
			// cmbEstadosDeStock
			// 
			this.cmbEstadosDeStock.AutoComplete = true;
			this.cmbEstadosDeStock.DataSource = null;
			this.cmbEstadosDeStock.DisplayMember = "";
			this.cmbEstadosDeStock.DisplayMemberCaption = "";
			this.cmbEstadosDeStock.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.cmbEstadosDeStock.Enabled = false;
			this.cmbEstadosDeStock.Location = new System.Drawing.Point(96, 88);
			this.cmbEstadosDeStock.MaxItemsDisplay = 7;
			this.cmbEstadosDeStock.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.cmbEstadosDeStock.Name = "cmbEstadosDeStock";
			this.cmbEstadosDeStock.Size = new System.Drawing.Size(192, 21);
			this.cmbEstadosDeStock.SorterMember = "";
			this.cmbEstadosDeStock.TabIndex = 7;
			this.cmbEstadosDeStock.ValueMember = "";
			this.cmbEstadosDeStock.ValueMemberCaption = "";
			// 
			// btnModificarOperacionEstadoVisualizacion
			// 
			this.btnModificarOperacionEstadoVisualizacion.Enabled = false;
			this.btnModificarOperacionEstadoVisualizacion.Location = new System.Drawing.Point(400, 96);
			this.btnModificarOperacionEstadoVisualizacion.Name = "btnModificarOperacionEstadoVisualizacion";
			this.btnModificarOperacionEstadoVisualizacion.Size = new System.Drawing.Size(80, 24);
			this.btnModificarOperacionEstadoVisualizacion.TabIndex = 12;
			this.btnModificarOperacionEstadoVisualizacion.Text = "&Modificar";
			this.btnModificarOperacionEstadoVisualizacion.Click += new System.EventHandler(this.btnModificarOperacionEstadoVisualizacion_Click);
			// 
			// txtEstadoDeStock
			// 
			this.txtEstadoDeStock.Enabled = false;
			this.txtEstadoDeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEstadoDeStock.Location = new System.Drawing.Point(96, 56);
			this.txtEstadoDeStock.Name = "txtEstadoDeStock";
			this.txtEstadoDeStock.ReadOnly = true;
			this.txtEstadoDeStock.Size = new System.Drawing.Size(192, 20);
			this.txtEstadoDeStock.TabIndex = 6;
			this.txtEstadoDeStock.Text = "";
			// 
			// txtNombreVisualizacionPadre
			// 
			this.txtNombreVisualizacionPadre.Enabled = false;
			this.txtNombreVisualizacionPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNombreVisualizacionPadre.Location = new System.Drawing.Point(96, 24);
			this.txtNombreVisualizacionPadre.Name = "txtNombreVisualizacionPadre";
			this.txtNombreVisualizacionPadre.ReadOnly = true;
			this.txtNombreVisualizacionPadre.Size = new System.Drawing.Size(192, 20);
			this.txtNombreVisualizacionPadre.TabIndex = 5;
			this.txtNombreVisualizacionPadre.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 108;
			this.label4.Text = "Estado de Stock";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 107;
			this.label3.Text = "Visualización";
			// 
			// btnEliminarEstadoDeVisualizacion
			// 
			this.btnEliminarEstadoDeVisualizacion.Enabled = false;
			this.btnEliminarEstadoDeVisualizacion.Location = new System.Drawing.Point(304, 56);
			this.btnEliminarEstadoDeVisualizacion.Name = "btnEliminarEstadoDeVisualizacion";
			this.btnEliminarEstadoDeVisualizacion.Size = new System.Drawing.Size(80, 24);
			this.btnEliminarEstadoDeVisualizacion.TabIndex = 8;
			this.btnEliminarEstadoDeVisualizacion.Text = "&Eliminar";
			this.btnEliminarEstadoDeVisualizacion.Click += new System.EventHandler(this.btnEliminarEstadoDeVisualizacion_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 91;
			this.label1.Text = "Estados de Stock";
			// 
			// btnAgregarEstadoAVisualizacion
			// 
			this.btnAgregarEstadoAVisualizacion.Enabled = false;
			this.btnAgregarEstadoAVisualizacion.Location = new System.Drawing.Point(304, 88);
			this.btnAgregarEstadoAVisualizacion.Name = "btnAgregarEstadoAVisualizacion";
			this.btnAgregarEstadoAVisualizacion.Size = new System.Drawing.Size(80, 24);
			this.btnAgregarEstadoAVisualizacion.TabIndex = 9;
			this.btnAgregarEstadoAVisualizacion.Text = "&Agregar";
			this.btnAgregarEstadoAVisualizacion.Click += new System.EventHandler(this.btnAgregarEstadoAVisualizacion_Click);
			// 
			// groupBoxOperacion
			// 
			this.groupBoxOperacion.BackColor = System.Drawing.Color.Transparent;
			this.groupBoxOperacion.Controls.Add(this.rbbNegativa);
			this.groupBoxOperacion.Controls.Add(this.rbPositiva);
			this.groupBoxOperacion.Enabled = false;
			this.groupBoxOperacion.Location = new System.Drawing.Point(400, 16);
			this.groupBoxOperacion.Name = "groupBoxOperacion";
			this.groupBoxOperacion.Size = new System.Drawing.Size(95, 68);
			this.groupBoxOperacion.TabIndex = 106;
			this.groupBoxOperacion.TabStop = false;
			this.groupBoxOperacion.Text = "Operación";
			// 
			// rbbNegativa
			// 
			this.rbbNegativa.Location = new System.Drawing.Point(8, 35);
			this.rbbNegativa.Name = "rbbNegativa";
			this.rbbNegativa.Size = new System.Drawing.Size(72, 20);
			this.rbbNegativa.TabIndex = 11;
			this.rbbNegativa.TabStop = true;
			this.rbbNegativa.Text = "Negativa";
			// 
			// rbPositiva
			// 
			this.rbPositiva.Checked = true;
			this.rbPositiva.Location = new System.Drawing.Point(8, 14);
			this.rbPositiva.Name = "rbPositiva";
			this.rbPositiva.Size = new System.Drawing.Size(64, 20);
			this.rbPositiva.TabIndex = 10;
			this.rbPositiva.TabStop = true;
			this.rbPositiva.Text = "Positiva";
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.AutomaticSort = false;
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEX1.Location = new System.Drawing.Point(208, 272);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(504, 160);
			this.gridEX1.TabIndex = 14;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// ultraTreeVisualizacionesDeStock
			// 
			this.ultraTreeVisualizacionesDeStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.ultraTreeVisualizacionesDeStock.HideSelection = false;
			this.ultraTreeVisualizacionesDeStock.Location = new System.Drawing.Point(8, 16);
			this.ultraTreeVisualizacionesDeStock.Name = "ultraTreeVisualizacionesDeStock";
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Visualizaciones de Stock";
			this.ultraTreeVisualizacionesDeStock.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																													  ultraTreeNode1});
			_override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.ultraTreeVisualizacionesDeStock.Override = _override1;
			this.ultraTreeVisualizacionesDeStock.Size = new System.Drawing.Size(184, 408);
			this.ultraTreeVisualizacionesDeStock.TabIndex = 96;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(208, 240);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 13;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnAgregarVisualizacion
			// 
			this.btnAgregarVisualizacion.Enabled = false;
			this.btnAgregarVisualizacion.Location = new System.Drawing.Point(216, 56);
			this.btnAgregarVisualizacion.Name = "btnAgregarVisualizacion";
			this.btnAgregarVisualizacion.Size = new System.Drawing.Size(80, 24);
			this.btnAgregarVisualizacion.TabIndex = 1;
			this.btnAgregarVisualizacion.Text = "&Agregar";
			this.btnAgregarVisualizacion.Click += new System.EventHandler(this.btnAgregarVisualizacion_Click);
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Enabled = false;
			this.chkActivo.Location = new System.Drawing.Point(440, 56);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(64, 20);
			this.chkActivo.TabIndex = 4;
			this.chkActivo.Text = "Activo";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(208, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 91;
			this.label2.Text = "Nombre Visualización";
			// 
			// txtNombreVisualizacion
			// 
			this.txtNombreVisualizacion.Enabled = false;
			this.txtNombreVisualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtNombreVisualizacion.Location = new System.Drawing.Point(328, 24);
			this.txtNombreVisualizacion.Name = "txtNombreVisualizacion";
			this.txtNombreVisualizacion.Size = new System.Drawing.Size(192, 20);
			this.txtNombreVisualizacion.TabIndex = 0;
			this.txtNombreVisualizacion.Text = "";
			// 
			// btnModificarVisualizacion
			// 
			this.btnModificarVisualizacion.Enabled = false;
			this.btnModificarVisualizacion.Location = new System.Drawing.Point(328, 56);
			this.btnModificarVisualizacion.Name = "btnModificarVisualizacion";
			this.btnModificarVisualizacion.Size = new System.Drawing.Size(80, 24);
			this.btnModificarVisualizacion.TabIndex = 2;
			this.btnModificarVisualizacion.Text = "&Modificar";
			this.btnModificarVisualizacion.Click += new System.EventHandler(this.btnModificarVisualizacion_Click);
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
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(800, 28);
			this.toolBarStandar.TabIndex = 49;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 1;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 2;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 0;
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
			ultraExplorerBarGroup2.Settings.ContainerHeight = 520;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Edición y Adición de visualizaciones de stock";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(800, 550);
			this.ultraExplorerBar1.TabIndex = 50;
			// 
			// FrmAbmVisualizacionDeStock
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 578);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmVisualizacionDeStock";
			this.Text = "FrmAbmVisualizacionDeStock";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmbEstadosDeStock)).EndInit();
			this.groupBoxOperacion.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTreeVisualizacionesDeStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private AbmVisualizacionDeStockController _uiController = null;
		private bool _expandir = true;
		#endregion

        #region Constructores y Destructores
		public FrmAbmVisualizacionDeStock(AbmVisualizacionDeStockController controller)
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
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
				_uiController.VisualizacionesNuevasHasChanged-=new EventHandler(_uiController_VisualizacionesNuevasHasChanged);

			}
			base.Dispose( disposing );
		}

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
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			this.gridEX1.LayoutData = _uiController.GetLayout();

			ultraTreeVisualizacionesDeStock.CollapseAll();
			KeyPreview = true;
		}

		private void InitializeData()
		{
			if(_uiController.PreviousTree != null)
                UpdateTree(ultraTreeVisualizacionesDeStock.Nodes[0], _uiController.PreviousTree);
			else
                UpdateTree(ultraTreeVisualizacionesDeStock.Nodes[0]);
			_expandir = false;
			ultraTreeVisualizacionesDeStock.Nodes[0].Expanded = true;
			_expandir = true;
			cmbEstadosDeStock.FillFromDataSource(_uiController.EstadosDeStock, _uiController.KeyValueEstadosDeStock, _uiController.KeyListEstadosDeStock, 100, _uiController.KeyListEstadosDeStock);
		}



		private void UpdateTree(Infragistics.Win.UltraWinTree.UltraTreeNode Node, Infragistics.Win.UltraWinTree.TreeNodesCollection children)
		{
			int i = 0;
			foreach(Infragistics.Win.UltraWinTree.UltraTreeNode childNode in children)
			{
				string keyChildNode = childNode.Key;
				string descriptionChildNode = childNode.Text;
				Infragistics.Win.UltraWinTree.UltraTreeNode child = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
				if(!Node.Nodes.Exists(keyChildNode))
				{
					Node.Nodes.Add(child);
					UpdateTree(Node.Nodes[i], children[i].Nodes);
				}
				i++;
			}

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

		private void UpdateTree()
		{
			mz.erp.businessrules.VisualizacionNueva vm = _uiController.VisualizacionModificada;
			switch(vm.Modo)
			{
				case "NEW"://Nueva Visualizacion o Modificacion de Visualizacion Nueva
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode modifNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyVisualizacion);
					if(modifNode != null) //Esta modificando una visualizacion que aun no se guardo en la BD
					{
						string descripcionM = vm.NombreVisualizacion;
						if(vm.Activo)
							descripcionM = descripcionM + " (Activo)";
						else
							descripcionM = descripcionM + " (Desactivo)";
						modifNode.Text = descripcionM;
					}
					else //Nueva Visualizacion
					{
						Infragistics.Win.UltraWinTree.UltraTreeNode rootNode = ultraTreeVisualizacionesDeStock.Nodes[0];
						string descripcionN = vm.NombreVisualizacion;
						if(vm.Activo)
							descripcionN = descripcionN + " (Activo)";
						else
							descripcionN = descripcionN + " (Desactivo)";
						Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(vm.KeyVisualizacion, descripcionN);
						if(!rootNode.Nodes.Exists(vm.KeyVisualizacion))
							rootNode.Nodes.Add(childNode);

					}
					break;
				}
				case "MODIF"://Modificacion de Visualizacion
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode modifNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyVisualizacion);
					string descripcionM = vm.NombreVisualizacion;
					if(vm.Activo)
						descripcionM = descripcionM + " (Activo)";
					else
						descripcionM = descripcionM + " (Desactivo)";
					modifNode.Text = descripcionM;
					break;	
				}
				case "DEL"://Eliminacion de estado 
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode parentNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyVisualizacion);
					Infragistics.Win.UltraWinTree.UltraTreeNode childNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyEstado);
					if(parentNode.Nodes.Exists(vm.KeyEstado))
                        parentNode.Nodes.Remove(childNode);				
					break;	
				}
				case "ADD"://Adicion de estado o Modificacion de estado agergado
				{
					string descripcionE = vm.DescripcionEstado;
					if(vm.Operacion.Equals("+"))
						descripcionE = descripcionE + " (+)";
					else 
						descripcionE = descripcionE + " (-)";
					Infragistics.Win.UltraWinTree.UltraTreeNode modifNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyEstado);
					if(modifNode != null) //Esta modificando un estado que aun no se guardo en la BD
					{
						modifNode.Text = descripcionE;
					}
					else // Adicion de estado
					{
						Infragistics.Win.UltraWinTree.UltraTreeNode parentNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyVisualizacion);
						Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(vm.KeyEstado, descripcionE);
						if(!parentNode.Nodes.Exists(vm.KeyEstado))
							parentNode.Nodes.Add(childNode);
					}

					break;	
				}
				case "MODIFOP"://Modificacion de operacion de estado 
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode modifNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyEstado);
					string descripcionE = vm.DescripcionEstado;
					if(vm.Operacion.Equals("+"))
						descripcionE = descripcionE + " (+)";
					else 
						descripcionE = descripcionE + " (-)";
					if(modifNode == null) //La visualizacion ya tiene ese estado en la DB pero el usuario lo borro y lo volvio a agregar con otra operacion
					{
						Infragistics.Win.UltraWinTree.UltraTreeNode parentNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyVisualizacion);
						Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(vm.KeyEstado, descripcionE);
						if(!parentNode.Nodes.Exists(vm.KeyEstado))
							parentNode.Nodes.Add(childNode);
					}
					else //Es una modificacion simple					
						modifNode.Text = descripcionE;					
					break;	
				}
				case "NOTHING"://Borro un estado y luego lo agrego de la misma manera 
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode parentNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(vm.KeyVisualizacion);
					string descripcionE = vm.DescripcionEstado;
					if(vm.Operacion.Equals("+"))
						descripcionE = descripcionE + " (+)";
					else 
						descripcionE = descripcionE + " (-)";
					Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(vm.KeyEstado, descripcionE);
					if(!parentNode.Nodes.Exists(vm.KeyEstado))
						parentNode.Nodes.Add(childNode);

					break;	
				}
			}

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
			ultraTreeVisualizacionesDeStock.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeVisualizacionesDeStock_AfterActivate);
			ultraTreeVisualizacionesDeStock.AfterExpand +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeVisualizacionesDeStock_AfterExpand);
			_uiController.VisualizacionesNuevasHasChanged+=new EventHandler(_uiController_VisualizacionesNuevasHasChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}	
	
		private void InitDataBindings()
		{
			gridEX1.DataSource = _uiController.VisualizacionesNuevas;
			if(_uiController.VisualizacionesNuevas.Count > 0)
				btnEliminar.Enabled = true;

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

		#region Metodos Privados
		private void SaveChanges()
		{	
			Util.MoveFocus(this.ultraExplorerBarContainerControl2);	
			_uiController.PreviousTree = ultraTreeVisualizacionesDeStock.Nodes[0].Nodes;
			_uiController.Execute();
		}

		private string getDescriptionFrom(string description)
		{
			int pos = description.IndexOf("(") -1;
			if(pos >0)
				return description.Substring(0,pos);
			else
				return description;

		}

		private bool isActivo(string description)
		{
			if(description.IndexOf("Activo") > 0)
				return true;
			else
				return false;
		
		}

		private bool isOperacionPositiva(string description)
		{
			if(description.IndexOf("+") > 0)
				return true;
			else
				return false;
		
		}
		private void deshacerCambios(mz.erp.businessrules.VisualizacionNueva v)
		{
			switch(v.Modo)
			{
				case "NEW":
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode rootNode = ultraTreeVisualizacionesDeStock.Nodes[0];
					Infragistics.Win.UltraWinTree.UltraTreeNode node = ultraTreeVisualizacionesDeStock.GetNodeByKey(v.KeyVisualizacion);
					if(rootNode.Nodes.Exists(v.KeyVisualizacion))
						rootNode.Nodes.Remove(node);
					break;
				}
				case "MODIF":
				{
					mz.erp.businessrules.Node nodeO = _uiController.UpdateNode(v.KeyVisualizacion, string.Empty);
					Infragistics.Win.UltraWinTree.UltraTreeNode node = ultraTreeVisualizacionesDeStock.GetNodeByKey(v.KeyVisualizacion);
					node.Text = nodeO.Description;
					break;
				}
				case "ADD":
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode parentNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(v.KeyVisualizacion);
					if(parentNode != null)
					{
						Infragistics.Win.UltraWinTree.UltraTreeNode node = ultraTreeVisualizacionesDeStock.GetNodeByKey(v.KeyEstado);
						if(parentNode.Nodes.Exists(v.KeyEstado))
							parentNode.Nodes.Remove(node);
					}
					break;
				}
				case "DEL":
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode parentNode = ultraTreeVisualizacionesDeStock.GetNodeByKey(v.KeyVisualizacion);
					mz.erp.businessrules.Node nodeO = _uiController.UpdateNode(v.KeyVisualizacion, v.KeyEstado);
					Infragistics.Win.UltraWinTree.UltraTreeNode node = new Infragistics.Win.UltraWinTree.UltraTreeNode(v.KeyEstado, nodeO.Description);
					if(!parentNode.Nodes.Exists(v.KeyEstado))
						parentNode.Nodes.Add(node);
					break;
				}
				case "MODIFOP":
				{
					Infragistics.Win.UltraWinTree.UltraTreeNode node = ultraTreeVisualizacionesDeStock.GetNodeByKey(v.KeyEstado);
					mz.erp.businessrules.Node nodeO = _uiController.UpdateNode(v.KeyVisualizacion, v.KeyEstado);
					node.Text = nodeO.Description;
					break;
				}
			}
		}

		#endregion


		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{	
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: //Anterior
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


		private void ultraTreeVisualizacionesDeStock_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (_expandir) {UpdateTree(e.TreeNode);}
		}


		private void ultraTreeVisualizacionesDeStock_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			_uiController.CurrentKey = e.TreeNode.Key;
			_uiController.CurrentDescription = e.TreeNode.Text;
			if(_uiController.CurrentKey != "RAIZ")
			{
				_uiController.ParentKey = e.TreeNode.Parent.Key;
				_uiController.ParentDescription = e.TreeNode.Parent.Text;
				if(_uiController.ParentKey == "RAIZ") //Es una visualizacion
				{
					txtNombreVisualizacion.Text = this.getDescriptionFrom(_uiController.CurrentDescription);
					txtNombreVisualizacion.Enabled = true;
					btnAgregarVisualizacion.Enabled = false;
					btnModificarVisualizacion.Enabled = true;
					_uiController.Activo = this.isActivo(_uiController.CurrentDescription);
					chkActivo.Checked = _uiController.Activo;
					chkActivo.Enabled = true;
					txtNombreVisualizacionPadre.Text = txtNombreVisualizacion.Text;
					txtEstadoDeStock.Text = string.Empty;
					btnEliminarEstadoDeVisualizacion.Enabled = false;
					cmbEstadosDeStock.Enabled = true;
					btnAgregarEstadoAVisualizacion.Enabled = true;
					btnModificarOperacionEstadoVisualizacion.Enabled = false;
					groupBoxOperacion.Enabled = true;
					rbPositiva.Checked = true;
					e.TreeNode.Selected = true;		
				}
				else //Es un estado
				{
					txtNombreVisualizacion.Text = string.Empty;
					txtNombreVisualizacion.Enabled = false;
					btnAgregarVisualizacion.Enabled = false;
					btnModificarVisualizacion.Enabled = false;
					chkActivo.Enabled = false;
					txtNombreVisualizacionPadre.Text = this.getDescriptionFrom(_uiController.ParentDescription);
					txtEstadoDeStock.Text = this.getDescriptionFrom(_uiController.CurrentDescription);
					btnEliminarEstadoDeVisualizacion.Enabled = true;
					cmbEstadosDeStock.Enabled = false;
					btnAgregarEstadoAVisualizacion.Enabled = false;
					btnModificarOperacionEstadoVisualizacion.Enabled = true;
					groupBoxOperacion.Enabled = true;
					bool isOpPositiva = this.isOperacionPositiva(_uiController.CurrentDescription);
					rbPositiva.Checked = isOpPositiva;
					rbbNegativa.Checked = !isOpPositiva;
					e.TreeNode.Selected = true;		
				}
			}
			else
			{
				txtNombreVisualizacion.Text = string.Empty;
				txtNombreVisualizacion.Enabled = true;
				btnAgregarVisualizacion.Enabled = true;
				btnModificarVisualizacion.Enabled = false;
				chkActivo.Enabled = true;
				txtNombreVisualizacionPadre.Text = string.Empty;
				txtEstadoDeStock.Text = string.Empty;
				cmbEstadosDeStock.Enabled = false;
				btnEliminarEstadoDeVisualizacion.Enabled = false;
				btnAgregarEstadoAVisualizacion.Enabled = false;
				btnModificarOperacionEstadoVisualizacion.Enabled = false;
				groupBoxOperacion.Enabled = false;					
			}			
		}

		
		private void btnAgregarVisualizacion_Click(object sender, System.EventArgs e)
		{
			bool activo = chkActivo.Checked;
			_uiController.AddVisualizacion(txtNombreVisualizacion.Text, "" , "", "", "", activo, "NEW");			
		}

		private void _uiController_VisualizacionesNuevasHasChanged(object sender, EventArgs e)
		{			
			this.gridEX1.SetDataBinding( null, null );
			this.gridEX1.SetDataBinding(_uiController.VisualizacionesNuevas, null );
			btnEliminar.Enabled = true;
			this.UpdateTree();
		}

		private void btnModificarVisualizacion_Click(object sender, System.EventArgs e)
		{
			if(_uiController.CurrentKey != "RAIZ")
			{
				bool activo = false;
				if(chkActivo.Checked)
					activo = true;
				else
					activo = false;
				_uiController.AddVisualizacion(txtNombreVisualizacion.Text, _uiController.CurrentKey , "", "", "", activo, "MODIF");			
			}
		}

		private void btnEliminarEstadoDeVisualizacion_Click(object sender, System.EventArgs e)
		{
			bool activo = this.isActivo(_uiController.ParentDescription);
			bool positiva = this.isOperacionPositiva(_uiController.CurrentDescription);
			string operacion = string.Empty;
			if(positiva)
				operacion = "+";
			else
				operacion = "-";
			_uiController.AddVisualizacion(txtNombreVisualizacionPadre.Text, _uiController.ParentKey , _uiController.CurrentKey, txtEstadoDeStock.Text, operacion, activo, "DEL");			
	
		}

		private void btnAgregarEstadoAVisualizacion_Click(object sender, System.EventArgs e)
		{
			if(cmbEstadosDeStock.Value != null)
			{
				bool activo = this.isActivo(_uiController.CurrentDescription);
				string operacion = string.Empty;
				if(rbPositiva.Checked)
					operacion = "+";
				else
					operacion = "-";
				_uiController.AddVisualizacion(txtNombreVisualizacionPadre.Text, _uiController.CurrentKey , (string)cmbEstadosDeStock.Value, cmbEstadosDeStock.Text, operacion, activo, "ADD");			
			}
		
		}

		private void btnModificarOperacionEstadoVisualizacion_Click(object sender, System.EventArgs e)
		{
			bool activo = this.isActivo(_uiController.ParentDescription);
			string operacion = string.Empty;
			if(rbPositiva.Checked)
				operacion = "+";
			else
				operacion = "-";
			_uiController.AddVisualizacion(txtNombreVisualizacionPadre.Text, _uiController.ParentKey , _uiController.CurrentKey, txtEstadoDeStock.Text, operacion, activo, "MODIFOP");			
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.VisualizacionesNuevas];
			int pos = cm.Position;
			if(pos >= 0)
			{
				mz.erp.businessrules.VisualizacionNueva v = (mz.erp.businessrules.VisualizacionNueva) gridEX1.SelectedItems[0].GetRow().DataRow;				
				this.deshacerCambios(v);
				cm.RemoveAt(pos);
				cm.Refresh();				
			}		

			CurrencyManager cm1 = (CurrencyManager) this.BindingContext[_uiController.VisualizacionesNuevasConfigVariables];
			int pos1 = cm1.Position;
			if(pos1 >= 0)
			{
				cm1.RemoveAt(pos1);
				cm1.Refresh();
			}		

			if(_uiController.VisualizacionesNuevas.Count == 0)
				btnEliminar.Enabled = false;	
		
		}

	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using Infragistics.Win.UltraWinTree;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmJerarquiaConfigurarVariable.
	/// </summary>
	public class FrmJerarquiaConfigurarVariable : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ToolBarButton tbbGuardar;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ImageList imageList2;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtJerarquia1;
		private System.Windows.Forms.TextBox txtJerarquia2;
		private System.Windows.Forms.TextBox txtJerarquia3;
		private System.Windows.Forms.TextBox txtJerarquia4;
		private System.Windows.Forms.TextBox txtJerarquia5;
		private System.Windows.Forms.TextBox txtJerarquia6;
		private System.Windows.Forms.TextBox txtJerarquia8;
		private System.Windows.Forms.TextBox txtJerarquia7;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTreeJerarquia;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private Infragistics.Win.Misc.UltraButton ultraButton1;
		private Infragistics.Win.Misc.UltraButton ultraButton2;
		private Infragistics.Win.Misc.UltraButton ultraButton3;
		private Infragistics.Win.Misc.UltraButton ultraButton4;
		private Infragistics.Win.Misc.UltraButton ultraButton5;
		private Infragistics.Win.Misc.UltraButton ultraButton6;
		private Infragistics.Win.Misc.UltraButton ultraButton7;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label labelTarea;
        private RadioButton rbJerarquia1;
        private RadioButton rbJerarquia8;
        private RadioButton rbJerarquia7;
        private RadioButton rbJerarquia6;
        private RadioButton rbJerarquia5;
        private RadioButton rbJerarquia4;
        private RadioButton rbJerarquia3;
        private RadioButton rbJerarquia2;
        private ToolTip toolTip;
		private System.ComponentModel.IContainer components;

		public FrmJerarquiaConfigurarVariable()
		{
			InitializeComponent();
		}

		public FrmJerarquiaConfigurarVariable(JerarquiaConfigurarVariableController controllers)
		{
			InitializeComponent();
			_uiController = controllers;
			//Build_UI();
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
            Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
            Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJerarquiaConfigurarVariable));
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.ultraTreeJerarquia = new Infragistics.Win.UltraWinTree.UltraTree();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbJerarquia8 = new System.Windows.Forms.RadioButton();
            this.rbJerarquia7 = new System.Windows.Forms.RadioButton();
            this.rbJerarquia6 = new System.Windows.Forms.RadioButton();
            this.rbJerarquia5 = new System.Windows.Forms.RadioButton();
            this.rbJerarquia4 = new System.Windows.Forms.RadioButton();
            this.rbJerarquia3 = new System.Windows.Forms.RadioButton();
            this.rbJerarquia2 = new System.Windows.Forms.RadioButton();
            this.rbJerarquia1 = new System.Windows.Forms.RadioButton();
            this.ultraButton7 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton6 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton5 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton4 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton3 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton2 = new Infragistics.Win.Misc.UltraButton();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
            this.txtJerarquia7 = new System.Windows.Forms.TextBox();
            this.txtJerarquia8 = new System.Windows.Forms.TextBox();
            this.txtJerarquia6 = new System.Windows.Forms.TextBox();
            this.txtJerarquia5 = new System.Windows.Forms.TextBox();
            this.txtJerarquia4 = new System.Windows.Forms.TextBox();
            this.txtJerarquia3 = new System.Windows.Forms.TextBox();
            this.txtJerarquia2 = new System.Windows.Forms.TextBox();
            this.txtJerarquia1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTreeJerarquia)).BeginInit();
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
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(788, 26);
            this.ultraExplorerBarContainerControl1.TabIndex = 2;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(788, 24);
            this.labelTarea.TabIndex = 2;
            this.labelTarea.Text = "Label Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraTreeJerarquia);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.panel1);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 109);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(788, 399);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // ultraTreeJerarquia
            // 
            this.ultraTreeJerarquia.AllowDrop = true;
            this.ultraTreeJerarquia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ultraTreeJerarquia.HideSelection = false;
            this.ultraTreeJerarquia.Location = new System.Drawing.Point(0, 0);
            this.ultraTreeJerarquia.Name = "ultraTreeJerarquia";
            ultraTreeNode1.Key = "RAIZ";
            ultraTreeNode1.Text = "Jerarquias";
            this.ultraTreeJerarquia.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
            ultraTreeNode1});
            _override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
            this.ultraTreeJerarquia.Override = _override1;
            this.ultraTreeJerarquia.Size = new System.Drawing.Size(392, 392);
            this.ultraTreeJerarquia.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbJerarquia8);
            this.panel1.Controls.Add(this.rbJerarquia7);
            this.panel1.Controls.Add(this.rbJerarquia6);
            this.panel1.Controls.Add(this.rbJerarquia5);
            this.panel1.Controls.Add(this.rbJerarquia4);
            this.panel1.Controls.Add(this.rbJerarquia3);
            this.panel1.Controls.Add(this.rbJerarquia2);
            this.panel1.Controls.Add(this.rbJerarquia1);
            this.panel1.Controls.Add(this.ultraButton7);
            this.panel1.Controls.Add(this.ultraButton6);
            this.panel1.Controls.Add(this.ultraButton5);
            this.panel1.Controls.Add(this.ultraButton4);
            this.panel1.Controls.Add(this.ultraButton3);
            this.panel1.Controls.Add(this.ultraButton2);
            this.panel1.Controls.Add(this.ultraButton1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtJerarquia7);
            this.panel1.Controls.Add(this.txtJerarquia8);
            this.panel1.Controls.Add(this.txtJerarquia6);
            this.panel1.Controls.Add(this.txtJerarquia5);
            this.panel1.Controls.Add(this.txtJerarquia4);
            this.panel1.Controls.Add(this.txtJerarquia3);
            this.panel1.Controls.Add(this.txtJerarquia2);
            this.panel1.Controls.Add(this.txtJerarquia1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(402, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 392);
            this.panel1.TabIndex = 26;
            // 
            // rbJerarquia8
            // 
            this.rbJerarquia8.Enabled = false;
            this.rbJerarquia8.Location = new System.Drawing.Point(282, 186);
            this.rbJerarquia8.Name = "rbJerarquia8";
            this.rbJerarquia8.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia8.TabIndex = 40;
            this.rbJerarquia8.Visible = false;
            // 
            // rbJerarquia7
            // 
            this.rbJerarquia7.Enabled = false;
            this.rbJerarquia7.Location = new System.Drawing.Point(282, 163);
            this.rbJerarquia7.Name = "rbJerarquia7";
            this.rbJerarquia7.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia7.TabIndex = 39;
            this.rbJerarquia7.Visible = false;
            // 
            // rbJerarquia6
            // 
            this.rbJerarquia6.Enabled = false;
            this.rbJerarquia6.Location = new System.Drawing.Point(282, 139);
            this.rbJerarquia6.Name = "rbJerarquia6";
            this.rbJerarquia6.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia6.TabIndex = 38;
            this.rbJerarquia6.Visible = false;
            // 
            // rbJerarquia5
            // 
            this.rbJerarquia5.Enabled = false;
            this.rbJerarquia5.Location = new System.Drawing.Point(282, 114);
            this.rbJerarquia5.Name = "rbJerarquia5";
            this.rbJerarquia5.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia5.TabIndex = 37;
            this.rbJerarquia5.Visible = false;
            // 
            // rbJerarquia4
            // 
            this.rbJerarquia4.Enabled = false;
            this.rbJerarquia4.Location = new System.Drawing.Point(282, 90);
            this.rbJerarquia4.Name = "rbJerarquia4";
            this.rbJerarquia4.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia4.TabIndex = 36;
            this.rbJerarquia4.Visible = false;
            // 
            // rbJerarquia3
            // 
            this.rbJerarquia3.Enabled = false;
            this.rbJerarquia3.Location = new System.Drawing.Point(282, 66);
            this.rbJerarquia3.Name = "rbJerarquia3";
            this.rbJerarquia3.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia3.TabIndex = 35;
            this.rbJerarquia3.Visible = false;
            // 
            // rbJerarquia2
            // 
            this.rbJerarquia2.Enabled = false;
            this.rbJerarquia2.Location = new System.Drawing.Point(282, 41);
            this.rbJerarquia2.Name = "rbJerarquia2";
            this.rbJerarquia2.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia2.TabIndex = 34;
            this.rbJerarquia2.Visible = false;
            // 
            // rbJerarquia1
            // 
            this.rbJerarquia1.Enabled = false;
            this.rbJerarquia1.Location = new System.Drawing.Point(282, 19);
            this.rbJerarquia1.Name = "rbJerarquia1";
            this.rbJerarquia1.Size = new System.Drawing.Size(16, 16);
            this.rbJerarquia1.TabIndex = 33;
            this.rbJerarquia1.Visible = false;
            // 
            // ultraButton7
            // 
            this.ultraButton7.Location = new System.Drawing.Point(208, 184);
            this.ultraButton7.Name = "ultraButton7";
            this.ultraButton7.Size = new System.Drawing.Size(64, 22);
            this.ultraButton7.TabIndex = 15;
            this.ultraButton7.Text = "&Limpiar";
            this.ultraButton7.Click += new System.EventHandler(this.ultraButton7_Click);
            // 
            // ultraButton6
            // 
            this.ultraButton6.Location = new System.Drawing.Point(208, 160);
            this.ultraButton6.Name = "ultraButton6";
            this.ultraButton6.Size = new System.Drawing.Size(64, 22);
            this.ultraButton6.TabIndex = 14;
            this.ultraButton6.Text = "&Limpiar";
            this.ultraButton6.Click += new System.EventHandler(this.ultraButton6_Click);
            // 
            // ultraButton5
            // 
            this.ultraButton5.Location = new System.Drawing.Point(208, 136);
            this.ultraButton5.Name = "ultraButton5";
            this.ultraButton5.Size = new System.Drawing.Size(64, 22);
            this.ultraButton5.TabIndex = 13;
            this.ultraButton5.Text = "&Limpiar";
            this.ultraButton5.Click += new System.EventHandler(this.ultraButton5_Click);
            // 
            // ultraButton4
            // 
            this.ultraButton4.Location = new System.Drawing.Point(208, 112);
            this.ultraButton4.Name = "ultraButton4";
            this.ultraButton4.Size = new System.Drawing.Size(64, 22);
            this.ultraButton4.TabIndex = 12;
            this.ultraButton4.Text = "&Limpiar";
            this.ultraButton4.Click += new System.EventHandler(this.ultraButton4_Click);
            // 
            // ultraButton3
            // 
            this.ultraButton3.Location = new System.Drawing.Point(208, 88);
            this.ultraButton3.Name = "ultraButton3";
            this.ultraButton3.Size = new System.Drawing.Size(64, 22);
            this.ultraButton3.TabIndex = 11;
            this.ultraButton3.Text = "&Limpiar";
            this.ultraButton3.Click += new System.EventHandler(this.ultraButton3_Click);
            // 
            // ultraButton2
            // 
            this.ultraButton2.Location = new System.Drawing.Point(208, 64);
            this.ultraButton2.Name = "ultraButton2";
            this.ultraButton2.Size = new System.Drawing.Size(64, 22);
            this.ultraButton2.TabIndex = 10;
            this.ultraButton2.Text = "&Limpiar";
            this.ultraButton2.Click += new System.EventHandler(this.ultraButton2_Click);
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(208, 41);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(64, 22);
            this.ultraButton1.TabIndex = 9;
            this.ultraButton1.Text = "&Limpiar";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(208, 18);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(64, 22);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "&Limpiar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtJerarquia7
            // 
            this.txtJerarquia7.AllowDrop = true;
            this.txtJerarquia7.Location = new System.Drawing.Point(99, 160);
            this.txtJerarquia7.Name = "txtJerarquia7";
            this.txtJerarquia7.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia7.TabIndex = 6;
            // 
            // txtJerarquia8
            // 
            this.txtJerarquia8.AllowDrop = true;
            this.txtJerarquia8.Location = new System.Drawing.Point(99, 184);
            this.txtJerarquia8.Name = "txtJerarquia8";
            this.txtJerarquia8.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia8.TabIndex = 7;
            // 
            // txtJerarquia6
            // 
            this.txtJerarquia6.AllowDrop = true;
            this.txtJerarquia6.Location = new System.Drawing.Point(99, 136);
            this.txtJerarquia6.Name = "txtJerarquia6";
            this.txtJerarquia6.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia6.TabIndex = 5;
            // 
            // txtJerarquia5
            // 
            this.txtJerarquia5.AllowDrop = true;
            this.txtJerarquia5.Location = new System.Drawing.Point(99, 112);
            this.txtJerarquia5.Name = "txtJerarquia5";
            this.txtJerarquia5.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia5.TabIndex = 4;
            // 
            // txtJerarquia4
            // 
            this.txtJerarquia4.AllowDrop = true;
            this.txtJerarquia4.Location = new System.Drawing.Point(99, 88);
            this.txtJerarquia4.Name = "txtJerarquia4";
            this.txtJerarquia4.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia4.TabIndex = 3;
            // 
            // txtJerarquia3
            // 
            this.txtJerarquia3.AllowDrop = true;
            this.txtJerarquia3.Location = new System.Drawing.Point(99, 64);
            this.txtJerarquia3.Name = "txtJerarquia3";
            this.txtJerarquia3.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia3.TabIndex = 2;
            // 
            // txtJerarquia2
            // 
            this.txtJerarquia2.AllowDrop = true;
            this.txtJerarquia2.Location = new System.Drawing.Point(99, 40);
            this.txtJerarquia2.Name = "txtJerarquia2";
            this.txtJerarquia2.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia2.TabIndex = 1;
            // 
            // txtJerarquia1
            // 
            this.txtJerarquia1.AllowDrop = true;
            this.txtJerarquia1.Location = new System.Drawing.Point(99, 16);
            this.txtJerarquia1.Name = "txtJerarquia1";
            this.txtJerarquia1.Size = new System.Drawing.Size(100, 20);
            this.txtJerarquia1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(24, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Jerarquía 8";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(24, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Jerarquía 7";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(24, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Jerarquía 6";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Jerarquía 2";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Jerarquía 5";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Jerarquía 4";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Jerarquía 3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Jerarquía 1";
            // 
            // tbbGuardar
            // 
            this.tbbGuardar.ImageIndex = 4;
            this.tbbGuardar.Name = "tbbGuardar";
            this.tbbGuardar.Text = "&Aceptar";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.ImageIndex = 7;
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "&Cancelar";
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imageList2;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(837, 28);
            this.toolBarStandar.TabIndex = 21;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 4;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Text = "&Aceptar";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 7;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Text = "&Cancelar";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 26;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Leyenda";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 399;
            ultraExplorerBarGroup2.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.True;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Jerarquías";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(837, 534);
            this.ultraExplorerBar1.TabIndex = 25;
            // 
            // FrmJerarquiaConfigurarVariable
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(837, 562);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmJerarquiaConfigurarVariable";
            this.Text = "FrmJerarquiaConfigurarVariable";
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraTreeJerarquia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Variables Privadas

		private mz.erp.ui.controllers.JerarquiaConfigurarVariableController _uiController;
		//private UltraTree_DropHightLight_DrawFilter_Class UltraTree_DropHightLight_DrawFilter = new UltraTree_DropHightLight_DrawFilter_Class();
		private bool _expandir = true;

		#endregion

		#region Miembros de ITaskForm

		public void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();

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
			Close();
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		#endregion

		#region Inicializadores

		private void Build_UI()
		{
			ConfigureInterface();
			InitializeData();
			InitEventHandlers();
			InitDataBindings();
		}
	
		private void ConfigureInterface()
		{
			this.Text=_uiController.LeyendaFormulario();
			this.labelTarea.Text=_uiController.LeyendaFormulario();

			this.txtJerarquia1.ReadOnly=true;
			this.txtJerarquia2.ReadOnly=true;
			this.txtJerarquia3.ReadOnly=true;
			this.txtJerarquia4.ReadOnly=true;
			this.txtJerarquia5.ReadOnly=true;
			this.txtJerarquia6.ReadOnly=true;
			this.txtJerarquia7.ReadOnly=true;
			this.txtJerarquia8.ReadOnly=true;
			
			ultraTreeJerarquia.CollapseAll();

            /* Silvina 20111104 - Tarea 0000222 */
            utility.Util.LoadImages(toolBarStandar, imageList2);
            if (_uiController.UsaCategorias)
            {
                rbJerarquia1.Visible = true;
                rbJerarquia2.Visible = true;
                rbJerarquia3.Visible = true;
                rbJerarquia4.Visible = true;
                rbJerarquia5.Visible = true;
                rbJerarquia6.Visible = true;
                rbJerarquia7.Visible = true;
                rbJerarquia8.Visible = true;

                toolTip.SetToolTip(rbJerarquia1, "Indica Categoría");
                toolTip.SetToolTip(rbJerarquia2, "Indica Categoría");
                toolTip.SetToolTip(rbJerarquia3, "Indica Categoría");
                toolTip.SetToolTip(rbJerarquia4, "Indica Categoría");
                toolTip.SetToolTip(rbJerarquia5, "Indica Categoría");
                toolTip.SetToolTip(rbJerarquia6, "Indica Categoría");
                toolTip.SetToolTip(rbJerarquia7, "Indica Categoría");
                toolTip.SetToolTip(rbJerarquia8, "Indica Categoría");
            }
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}
		
		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			this.ultraTreeJerarquia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ultraTreeJerarquia_MouseDown);
			this.txtJerarquia7.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia7_DragDrop);
			this.txtJerarquia7.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia7_DragEnter);
			this.txtJerarquia8.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia8_DragDrop);
			this.txtJerarquia8.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia8_DragEnter);
			this.txtJerarquia6.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia6_DragDrop);
			this.txtJerarquia6.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia6_DragEnter);
			this.txtJerarquia5.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia5_DragDrop);
			this.txtJerarquia5.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia5_DragEnter);
			this.txtJerarquia4.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia4_DragDrop);
			this.txtJerarquia4.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia4_DragEnter);
			this.txtJerarquia3.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia3_DragDrop);
			this.txtJerarquia3.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia3_DragEnter);
			this.txtJerarquia2.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia2_DragDrop);
			this.txtJerarquia2.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia2_DragEnter);
			this.txtJerarquia1.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtJerarquia1_DragDrop);
			this.txtJerarquia1.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtJerarquia1_DragEnter);
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia1.CheckedChanged += new EventHandler(rbJerarquia1_CheckedChanged);
            rbJerarquia2.CheckedChanged += new EventHandler(rbJerarquia2_CheckedChanged);
            rbJerarquia3.CheckedChanged += new EventHandler(rbJerarquia3_CheckedChanged);
            rbJerarquia4.CheckedChanged += new EventHandler(rbJerarquia4_CheckedChanged);
            rbJerarquia5.CheckedChanged += new EventHandler(rbJerarquia5_CheckedChanged);
            rbJerarquia6.CheckedChanged += new EventHandler(rbJerarquia6_CheckedChanged);
            rbJerarquia7.CheckedChanged += new EventHandler(rbJerarquia7_CheckedChanged);
            rbJerarquia8.CheckedChanged += new EventHandler(rbJerarquia8_CheckedChanged);
            /* Fin Silvina 20111104 - Tarea 0000222 */
							
		}

        /* Silvina 20111104 - Tarea 0000222 */

        void rbJerarquia1_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(1); 
        }

        void rbJerarquia2_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(2);
        }

        void rbJerarquia3_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(3);
        }

        void rbJerarquia4_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(4);
        }

        void rbJerarquia5_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(5);
        }

        void rbJerarquia6_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(6);
        }

        void rbJerarquia7_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(7);
        }

        void rbJerarquia8_CheckedChanged(object sender, EventArgs e)
        {
            _uiController.SetCategoria(8);
        }
        /* Fin Silvina 20111104 - Tarea 0000222 */

		private void InitializeData()
		{
			UpdateTree(ultraTreeJerarquia.Nodes[0]);
			_expandir = false;
			ultraTreeJerarquia.Nodes[0].Expanded = true;
			_expandir = true;

			txtJerarquia1.Text=_uiController.Jerarquia1;
			txtJerarquia2.Text=_uiController.Jerarquia2;
			txtJerarquia3.Text=_uiController.Jerarquia3;
			txtJerarquia4.Text=_uiController.Jerarquia4;
			txtJerarquia5.Text=_uiController.Jerarquia5;
			txtJerarquia6.Text=_uiController.Jerarquia6;
			txtJerarquia7.Text=_uiController.Jerarquia7;
			txtJerarquia8.Text=_uiController.Jerarquia8;

            /* Silvina 20111104 - Tarea 0000222 */
            if (_uiController.UsaCategorias)
            {
                if (!string.IsNullOrEmpty(_uiController.Jerarquia1))
                {
                    rbJerarquia1.Enabled = true;
                    rbJerarquia1.Checked = _uiController.SetNomenclaturaJerarquia1.Equals(_uiController.Categoria);
                }
                if (!string.IsNullOrEmpty(_uiController.Jerarquia2))
                {
                    rbJerarquia2.Enabled = true;
                    rbJerarquia2.Checked = _uiController.SetNomenclaturaJerarquia2.Equals(_uiController.Categoria);
                }
                if (!string.IsNullOrEmpty(_uiController.Jerarquia3))
                {
                    rbJerarquia3.Enabled = true;
                    rbJerarquia3.Checked = _uiController.SetNomenclaturaJerarquia3.Equals(_uiController.Categoria);
                }
                if (!string.IsNullOrEmpty(_uiController.Jerarquia4))
                {
                    rbJerarquia4.Enabled = true;
                    rbJerarquia4.Checked = _uiController.SetNomenclaturaJerarquia4.Equals(_uiController.Categoria);
                }
                if (!string.IsNullOrEmpty(_uiController.Jerarquia5))
                {
                    rbJerarquia5.Enabled = true;
                    rbJerarquia5.Checked = _uiController.SetNomenclaturaJerarquia5.Equals(_uiController.Categoria);
                }
                if (!string.IsNullOrEmpty(_uiController.Jerarquia6))
                {
                    rbJerarquia6.Enabled = true;
                    rbJerarquia6.Checked = _uiController.SetNomenclaturaJerarquia6.Equals(_uiController.Categoria);
                }
                if (!string.IsNullOrEmpty(_uiController.Jerarquia7))
                {
                    rbJerarquia7.Enabled = true;
                    rbJerarquia7.Checked = _uiController.SetNomenclaturaJerarquia7.Equals(_uiController.Categoria);
                }
                if (!string.IsNullOrEmpty(_uiController.Jerarquia8))
                {
                    rbJerarquia8.Enabled = true;
                    rbJerarquia8.Checked = _uiController.SetNomenclaturaJerarquia8.Equals(_uiController.Categoria);
                }
            }
            /* Fin Silvina 20111104 - Tarea 0000222 */
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

			}
		
		}

		private void InitDataBindings()
		{

		}

		#endregion

		#region Drag and Drop
		private void ultraTreeJerarquia_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (this.ultraTreeJerarquia.SelectedNodes.Count>0)
				if (!this.ultraTreeJerarquia.SelectedNodes[0].Key.Equals("RAIZ"))
				{
					if (_uiController.ValidarNodoNivel0(this.ultraTreeJerarquia.SelectedNodes[0].Key))
						DoDragDrop(this.ultraTreeJerarquia.SelectedNodes, DragDropEffects.Copy);
				}
		}

		private void txtJerarquia1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("1", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
			{
				e.Effect = DragDropEffects.None;
				//MessageBox.Show(this,"No puede modificar esta jerarquia.", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
			}
		}

		private void txtJerarquia2_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("2", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void txtJerarquia3_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("3", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void txtJerarquia4_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("4", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void txtJerarquia5_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("5", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void txtJerarquia6_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("6", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void txtJerarquia7_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("7", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void txtJerarquia8_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_uiController.JerarquiaEditable("8", this.ultraTreeJerarquia.SelectedNodes[0].Key))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void txtJerarquia1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia1.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia1=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia1.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		private void txtJerarquia2_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia2.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia2=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia2.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		private void txtJerarquia3_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia3.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia3=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia3.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		private void txtJerarquia4_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia4.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia4=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia4.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		private void txtJerarquia5_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia5.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia5=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia5.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		private void txtJerarquia6_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia6.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia6=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia6.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		private void txtJerarquia7_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia7.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia7=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia7.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		private void txtJerarquia8_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			SelectedNodesCollection selectedNodes = (SelectedNodesCollection)e.Data.GetData(typeof(SelectedNodesCollection));
			this.txtJerarquia8.Text = selectedNodes.GetItem(0).ToString();
			_uiController.SetNomenclaturaJerarquia8=this.ultraTreeJerarquia.SelectedNodes[0].Key;
            /* Silvina 20111104 - Tarea 0000222 */
            rbJerarquia8.Enabled = true;
            /* Fin Silvina 20111104 - Tarea 0000222 */
		}

		#endregion

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Execute();
					break;
				case 2:
					if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning )== System.Windows.Forms.DialogResult.OK))
						Close();
					break;
			}
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("1", string.Empty))
			{
				this.txtJerarquia1.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia1=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia1.Enabled = false;
                rbJerarquia1.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

		private void ultraButton1_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("2", string.Empty))
			{
				this.txtJerarquia2.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia2=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia2.Enabled = false;
                rbJerarquia2.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

		private void ultraButton2_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("3", string.Empty))
			{
				this.txtJerarquia3.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia3=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia3.Enabled = false;
                rbJerarquia3.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

		private void ultraButton3_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("4", string.Empty))
			{
				this.txtJerarquia4.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia4=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia4.Enabled = false;
                rbJerarquia4.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

		private void ultraButton4_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("5", string.Empty))
			{
				this.txtJerarquia5.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia5=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia5.Enabled = false;
                rbJerarquia5.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

		private void ultraButton5_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("6", string.Empty))
			{
				this.txtJerarquia6.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia6=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia6.Enabled = false;
                rbJerarquia6.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

		private void ultraButton6_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("7", string.Empty))
			{
				this.txtJerarquia7.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia7=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia7.Enabled = false;
                rbJerarquia7.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

		private void ultraButton7_Click(object sender, System.EventArgs e)
		{
			if (_uiController.JerarquiaEditable("8", string.Empty))
			{
				this.txtJerarquia8.Text=string.Empty;
				_uiController.SetNomenclaturaJerarquia8=string.Empty;
                /* Silvina 20111104 - Tarea 0000222 */
                rbJerarquia8.Enabled = false;
                rbJerarquia8.Checked = false;
                /* Fin Silvina 20111104 - Tarea 0000222 */
			}
			else
				MessageBox.Show(this,"No se puede eliminar esta configuracion (se encuentra en uso)", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning );
		}

	}
}
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using System.Reflection;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAltaRow.
	/// </summary>
	public class FrmAltaRow : System.Windows.Forms.Form
	{
		protected System.ComponentModel.IContainer components;

		public FrmAltaRow()
		{
			InitializeComponent();
			this.tbbPedidos.Visible = false;
		}

		protected object _sender;
		protected Type _businessRulesType;
		//private MethodBase _saveChangesMethod;
		//private MethodBase _newMemberMethod;
		//private MethodBase _editMemberMethod;
		//private MethodBase _deleteMemberMethod;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		protected System.Windows.Forms.ToolBarButton bAceptar;
		protected System.Windows.Forms.ToolBarButton bCancelar;
		protected System.Windows.Forms.ImageList imageList1;
		protected  System.Windows.Forms.ToolBarButton tbbPedidos;
	
		#region Custom Members
		private string _caption;
		public string Caption
		{
			set {
				_caption = value;
				this.Caption = _caption;
				}
			get
				{
				return _caption;
				}
		}

		private string _action;
		public string Action
		{
			get{return _action;}
		}

		protected virtual void Init()
		{
	
		}


		private string _state;
		public string State
		{
			get{return _state;}
			
		}

		[ IsShowFormMember ]
		public void ShowForm( object sender, string action, string caption )
		{
			ShowForm( sender, action, caption, null );
		}
		
		public void ShowForm( object sender, string action, string caption , object id)

		{
			_sender = sender;
			_action = action;
			Init();
			if ( action.ToUpper() == "NUEVO" ) 
			{
				New();
				this.Text = "Alta de " + caption;
				this._state = "NEW";
			}
			else
			{
				Modify(id);
				this.Text = "Modificación de " + caption;
				this._state ="EDIT";
			}
			InitializeMembers();
			FillControls();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();

		}

		protected virtual void New()
		{
		}

		protected virtual void Modify(object id)
		{
		}

		protected virtual void InitializeMembers()
		{

		}

		protected virtual void FillControls()
		{

		}

		protected virtual void DumpControls()
		{

		}





		#endregion

		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0: //Aceptar
					Aceptar();
					break;
				case 1: //Cancelar
					Cancelar();
					break;
				case 2://Pedidos
					GenerarPedido();
					break;
			
			}		
		}
		protected virtual void Aceptar()
		{
			DumpControls();
			Evaluate();
		}
		protected virtual void Cancelar()
		{
			this.Close();
		}

		protected virtual void Evaluate()
		{
			Close();
		}

		protected virtual void GenerarPedido()
		{
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAltaRow));
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.bAceptar = new System.Windows.Forms.ToolBarButton();
			this.bCancelar = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tbbPedidos = new System.Windows.Forms.ToolBarButton();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(823, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Información";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(872, 245);
			this.ultraExplorerBar1.TabIndex = 0;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.bAceptar,
																							  this.bCancelar,
																							  this.tbbPedidos});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(872, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			// 
			// bAceptar
			// 
			this.bAceptar.ImageIndex = 0;
			this.bAceptar.Text = "&Aceptar";
			// 
			// bCancelar
			// 
			this.bCancelar.ImageIndex = 1;
			this.bCancelar.Text = "&Cancelar";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// tbbPedidos
			// 
			this.tbbPedidos.Text = "Generar &Pedido";
			// 
			// FrmAltaRow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(872, 273);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmAltaRow";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAltaRow_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected virtual void FrmAltaRow_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys.A):
					{
					if (e.Modifiers == System.Windows.Forms.Keys.Alt) {	Aceptar(); }
					break;		
					}
				case (System.Windows.Forms.Keys.C):
					{
					if (e.Modifiers == System.Windows.Forms.Keys.Alt) { Cancelar(); }
					break;
					}
			}
		}
	}
}

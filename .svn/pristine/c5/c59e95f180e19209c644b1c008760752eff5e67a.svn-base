using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controls;
using System.Reflection;
using Infragistics.Win.UltraWinExplorerBar;
using mz.erp.ui.controllers;



namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAMB.
	/// </summary>
	public class FrmAMB : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbDelete;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton14;
		private System.Windows.Forms.ToolBarButton toolBarButton15;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private System.Windows.Forms.ToolBarButton toolBarButton17;
		private System.Windows.Forms.ToolBarButton toolBarButton18;
		private System.ComponentModel.IContainer components;

		public FrmAMB()
		{
			InitializeComponent();
		}

		protected System.Data.DataRow _row;
		protected Type _businessRulesType;
		private MethodBase _saveChangesMethod;
		private MethodBase _newMemberMethod;
		private MethodBase _editMemberMethod;
		private MethodBase _deleteMemberMethod;
		private bool _save = false;

		
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAMB));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton14 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton17 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton18 = new System.Windows.Forms.ToolBarButton();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(871, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
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
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.toolBarButton4,
																							  this.toolBarButton5,
																							  this.toolBarButton6,
																							  this.toolBarButton7,
																							  this.toolBarButton8,
																							  this.tbStep3,
																							  this.tbDelete});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
			this.toolBarStandar.TabIndex = 16;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton1.Visible = false;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton2.Visible = false;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			this.toolBarButton3.Visible = false;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			this.toolBarButton4.Visible = false;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton5.Visible = false;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			this.toolBarButton6.Visible = false;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton7.Visible = false;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 4;
			this.toolBarButton8.Text = "&Guardar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 7;
			this.tbDelete.Text = "Borrar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 409);
			this.ultraExplorerBar1.TabIndex = 17;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 0;
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 1;
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.ImageIndex = 2;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 3;
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton14
			// 
			this.toolBarButton14.ImageIndex = 5;
			// 
			// toolBarButton15
			// 
			this.toolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 4;
			this.toolBarButton16.Text = "Guardar";
			// 
			// toolBarButton17
			// 
			this.toolBarButton17.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton18
			// 
			this.toolBarButton18.ImageIndex = 7;
			this.toolBarButton18.Text = "Borrar";
			// 
			// FrmAMB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 437);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmAMB";
			this.Text = "FrmAMB";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAMB_KeyDown);
			this.Load += new System.EventHandler(this.FrmAMB_Load);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		#region Custom Members

		protected virtual void Init()
		{
			foreach( MethodBase mb in _businessRulesType.GetMethods() )
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is mz.erp.businessrules.atMethodNewRow )
					{
						_newMemberMethod = mb;
					}
					
					if ( am is mz.erp.businessrules.atMethodGetByPkRow )
					{
						_editMemberMethod = mb;
					}
					if ( am is mz.erp.businessrules.atMethodSaveRowWithValidation )
					{
						_saveChangesMethod = mb;
					}
					if ( am is mz.erp.businessrules.atMethodDeleteRow )
					{
						_deleteMemberMethod = mb;
					}

					
				}
			}
			MouseHelper mouseControler = new MouseHelper();
			mouseControler.Control = ultraExplorerBar1;
			mouseControler.WheelBackward+=new MouseEventHandler(ScrollDown);
			mouseControler.WheelForward += new MouseEventHandler(ScrollUp);
			this.Closing +=new CancelEventHandler(FrmAMB_Closing);

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
		public void ShowForm( object id, string caption )
		{
			Init();
			if ( id == null ) 
			{
				tbDelete.Visible = false;
				New();
				this.Text = "Alta de " + caption;
				this._state ="NEW";
			}
			else
			{
				//Matias 20100604 - Tarea 18
				//-- El metodo Delete(), ejecutado al oprimir "Borrar", no se posee codigo (es decir, no haca nada),
				//-- razon por la cual no tiene sentido mostrar el boton.
				//-- A futuro, si se quisiera realizar alguna accion al oprimir "Borrar" habria que codificar cuando
				//-- mostrar el boton (y cuando no).
				tbDelete.Visible = false;
				//Fin Matias 20100604 - Tarea 18
				Modify(id);
				this.Text = "Modificación de " + caption;
				this._state ="EDIT";
			}
			InitializeMembers();
			FillControls();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();

		}

		private string _state=string.Empty;

		protected string State
		{
			get
			{
				return this._state;		
			}
		}
		protected virtual void InitializeMembers()
		{

		}
		protected virtual void New()
		{
			object instance = Activator.CreateInstance( _businessRulesType );
			_row = (System.Data.DataRow)_newMemberMethod.Invoke( instance, new object[]{ } );			
		}

		protected virtual void Modify(object id)
		{
			object instance = Activator.CreateInstance( _businessRulesType );
			_row = (System.Data.DataRow)_editMemberMethod.Invoke( instance, new object[]{ id } );
		}

		protected virtual void Delete()
		{
			/*DialogResult result;
			result = MessageBox.Show("Eliminación","Está seguro que desea eliminar el registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if(result == DialogResult.Yes) 
			{
				object instance = Activator.CreateInstance( _businessRulesType );
				if (_deleteMemberMethod != null)
				{
					_deleteMemberMethod.Invoke( instance, new object[]{ _row } );
					Evaluate();
				}
			}	*/
			MessageBox.Show(this,"Funcionalidad no habilitada","Atención!",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop );
		}

		protected virtual void FillControls()
		{
		}
		
		protected virtual void DumpControls()
		{
		}

		[ IsSaveChangesMember ]
		protected virtual void SaveChanges()
		{
			DumpControls();
			object instance = Activator.CreateInstance( _businessRulesType );
			_saveChangesMethod.Invoke( instance, new object[]{ _row } );
			Evaluate();
		}

		public delegate void RowChanged( object sender, EventArgs args );
		public event RowChanged OnRowChanged;

		protected void Evaluate()
		{			
			if (_row.HasErrors)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(_row);
                //German 20120530 - Tarea 0000344
				//_form.MdiParent = mz.erp.ui.utility.Environment.MainForm;
                //Fin German 20120530 - Tarea 0000344
				_form.Show();
				_row.ClearErrors();
			}
			else
			{
				MessageBox.Show("La acción se ha ejecutado con éxito");
				if ( OnRowChanged != null )
				{
					OnRowChanged( this, null );
				}
				_save = true;
				Close();
			}
		}
		#endregion

		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 5:					
					break;
				case 7:
					SaveChanges();
					break;
				case 9:
					Delete();
					break;
			}		
		}

		private void FrmAMB_Load(object sender, System.EventArgs e)
		{
		
		}

		protected void FrmAMB_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.G:
				{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
					{
						SaveChanges();
					}
					break;
				}
			}
		}

		private void FrmAMB_Closing(object sender, CancelEventArgs e)
		{
			if(!_save)
			{
				if(MessageBox.Show("¿Esta seguro que desea cerrar el formulario " + this.Text + "?","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Warning) == DialogResult.Cancel)
					e.Cancel = true;
			}
		}
	}
}

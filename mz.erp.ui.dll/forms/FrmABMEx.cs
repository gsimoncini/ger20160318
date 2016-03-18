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
	public class FrmABMEx : System.Windows.Forms.Form
	{
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbStep3;
		protected System.Windows.Forms.ToolBarButton tbDelete;
		private System.Windows.Forms.ImageList imageList1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.ComponentModel.IContainer components;
		protected System.Windows.Forms.ToolBarButton tbFirst;
		protected System.Windows.Forms.ToolBarButton tbPrev;
		protected System.Windows.Forms.ToolBarButton tbNext;
		protected System.Windows.Forms.ToolBarButton tbLast;
		protected System.Windows.Forms.ToolBarButton tbActualizar;
		protected System.Windows.Forms.ToolBarButton tbGuardar;
		

		private object _id;
	
		public FrmABMEx()
		{
			InitializeComponent();

			this.tbDelete.Visible = false;
			
		}

		protected System.Data.DataSet _data;
		protected Type _businessRulesType;
		private MethodBase _saveChangesMethod;
		private MethodBase _newMemberMethod;
		private MethodBase _editMemberMethod;
		private MethodBase _deleteMemberMethod;
		protected bool _save = false;

        //Cristian Tarea 000243 20120102
        protected bool _hasErrors = false;
        //Fin Cristian Tarea 000243



        //Cristian Tarea 000243 20120102
        protected bool HasErrors
        {
            get
            {
                return this._hasErrors;
            }
        }
        //Fin Cristian Tarea 000243

	

		
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMEx));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbFirst = new System.Windows.Forms.ToolBarButton();
			this.tbPrev = new System.Windows.Forms.ToolBarButton();
			this.tbNext = new System.Windows.Forms.ToolBarButton();
			this.tbLast = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbActualizar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbGuardar = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
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
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbFirst,
																							  this.tbPrev,
																							  this.tbNext,
																							  this.tbLast,
																							  this.toolBarButton5,
																							  this.tbActualizar,
																							  this.toolBarButton7,
																							  this.tbGuardar,
																							  this.tbStep3,
																							  this.tbDelete});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
			this.toolBarStandar.TabIndex = 16;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			// 
			// tbFirst
			// 
			this.tbFirst.ImageIndex = 0;
			this.tbFirst.Visible = false;
			// 
			// tbPrev
			// 
			this.tbPrev.ImageIndex = 1;
			this.tbPrev.Visible = false;
			// 
			// tbNext
			// 
			this.tbNext.ImageIndex = 2;
			this.tbNext.Visible = false;
			// 
			// tbLast
			// 
			this.tbLast.ImageIndex = 3;
			this.tbLast.Visible = false;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton5.Visible = false;
			// 
			// tbActualizar
			// 
			this.tbActualizar.ImageIndex = 5;
			this.tbActualizar.Visible = false;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton7.Visible = false;
			// 
			// tbGuardar
			// 
			this.tbGuardar.ImageIndex = 4;
			this.tbGuardar.Text = "&Guardar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbStep3.Visible = false;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 7;
			this.tbDelete.Text = "Borrar";
			this.tbDelete.Visible = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
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
			// FrmABMEx
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 437);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmABMEx";
			this.Text = "FrmABMEx";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmABMEx_KeyDown);
			this.Load += new System.EventHandler(this.FrmABMEx_Load);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		#region Custom Members

		protected virtual void Init()
		{
            //Cristian Tarea 000243 20120102
            _hasErrors = false;
            //Fin Cristian Tarea 000243 20120102
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
            this.Closing +=new CancelEventHandler(FrmABMEx_Closing);
			

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
				New();
				this.Text = "Alta de " + caption;
				this._state = "NEW";
			}
			else
			{
				Modify(id);
				_id = id;
				this.Text = "Modificación de " + caption;
				this._state = "EDIT";
			}
			InitializeMembers();
			FillControls();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();

		}

		protected string _state=string.Empty;

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
			if (_newMemberMethod != null)
			{
				object instance = Activator.CreateInstance( _businessRulesType );
				_data = (System.Data.DataSet)_newMemberMethod.Invoke( instance, new object[]{ } );
				this.Text = "Alta";
				this._state = "NEW";
			}
			else
			{
				MessageBox.Show(this,"Funcionalidad no habilitada","Atención!",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop );
			}
		}

		protected virtual void Modify(object id)
		{
			if (_editMemberMethod != null)
			{
				object instance = Activator.CreateInstance( _businessRulesType );
				_data = (System.Data.DataSet)_editMemberMethod.Invoke( instance, new object[]{ id } );
				this.Text = "Modificacion";
				this._state = "EDIT";
			}
			else
			{
				MessageBox.Show(this,"Funcionalidad no habilitada","Atención!",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop );
			}

		}

		protected virtual void Delete()
		{
			/*
			if (_deleteMemberMethod != null)
			{
				object instance = Activator.CreateInstance( _businessRulesType );
				_deleteMemberMethod.Invoke( instance, new object[]{ _data } );
				Evaluate();
			}
			else
			{*/
				MessageBox.Show(this,"Funcionalidad no habilitada","Atención!",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop );
			//}

		}
		protected virtual void FillControls()
		{
		}
		
		protected virtual void DumpControls()
		{
		}

        //Cristian Tarea 000243 20111230
        protected virtual void LoadPrecios()
        {
            Evaluate();
        }
        //Fin cristian
		
		[ IsSaveChangesMember ]
		protected virtual void SaveChanges()
		{
			DumpControls();
			object instance = Activator.CreateInstance( _businessRulesType );
			_saveChangesMethod.Invoke( instance, new object[]{ _data } );
			
			Evaluate();
		}

		public delegate void RowChanged( object sender, EventArgs args );
		public event RowChanged OnRowChanged;

        protected void Evaluate()
		{			
			//bool hasErrors=false;
			foreach (System.Data.DataTable table in _data.Tables)
				foreach (System.Data.DataRow row in table.Rows)
				{

					if (row.HasErrors)
					{
                        //Cristian Tarea 000243 20120102
						_hasErrors=true;
                        //Fin Cristian Tarea 000243
											
					}				
				}
            //Cristian Tarea 000243 20120102
			if(_hasErrors)
            //Fin Cristian Tarea 000243
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(_data);
				_form.Show();
				foreach (System.Data.DataTable table in _data.Tables)
					foreach (System.Data.DataRow row in table.Rows)
					{

						if (row.HasErrors)
						{
                            //German 20120328 - Tarea 0000288
                            _hasErrors = false;
                            //German 20120328 - Tarea 0000288
							row.ClearErrors();
											
						}				
					}	
					
			}
            //German 20120328 - Tarea 0000288
            //Cristian Tarea 000243 20120102
			//if (!_hasErrors)
            else
            //Fin Cristian Tarea 000243 20120102
            //German 20120328 - Tarea 0000288
			{
				//MessageBox.Show("La acción se ha ejecutado con éxito");
				try
				{
					if ( OnRowChanged != null )
						OnRowChanged( this._data, null );
				}
				catch (Exception e)
				{
					// nada.
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
                //Cristian Tara 000243 20111230
                case 11:
                    LoadPrecios();
                    
                    break;
                //Fin cristian
			}		
		}

		private void FrmABMEx_Load(object sender, System.EventArgs e)
		{
			
		}

		private void FrmABMEx_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

		private void FrmABMEx_Closing(object sender, CancelEventArgs e)
		{
			if(!_save)
			{
				if(MessageBox.Show("¿Esta seguro que desea cerrar el formulario " + this.Text + "?","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Warning) == DialogResult.Cancel)
					e.Cancel = true;
			}
		}
	}
}

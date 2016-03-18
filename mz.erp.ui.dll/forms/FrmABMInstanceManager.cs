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
	/// Descripción breve de FormABMInstanceManager.
	/// </summary>
	public class FrmABMInstanceManager : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBarButton tbDelete;
		private System.Windows.Forms.ImageList imglStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private System.Windows.Forms.ToolBarButton primero;
		private System.Windows.Forms.ToolBarButton anterior;
		private System.Windows.Forms.ToolBarButton siguiente;
		private System.Windows.Forms.ToolBarButton ultimo;
		private System.Windows.Forms.ToolBarButton actualizar;
		private System.Windows.Forms.ToolBarButton guardar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl DatosGenerales;
		private System.Windows.Forms.ToolBar barra;
		private System.Windows.Forms.ToolBarButton separador1;
		private System.Windows.Forms.ToolBarButton separador2;
		private System.Windows.Forms.ToolBarButton separador3;
		private System.ComponentModel.IContainer components;

		public FrmABMInstanceManager()
		{
			InitializeComponent();
		}

		protected System.Object _instance; 		
 		protected Type _businessRulesType;
		private MethodBase _saveChangesMethod;
		private MethodBase _newMemberMethod;
		private MethodBase _editMemberMethod;
		private MethodBase _deleteMemberMethod;

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
				this._state ="NEW";
				//get by pk
				//mz.erp.businessrules.tlg_Transportes.GetByPk(null);
			}
			else
			{
				Modify(id);
				this.Text = "Modificación de " + caption;
				this._state ="EDIT";
				//trae los datos q estan en la bd
				mz.erp.businessrules.tlg_Transportes.GetByPk(((mz.erp.commontypes.data.tlg_TransportesDataset.tlg_TransportesRow)(_instance)).IdTransporte);
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
			try
			{
				object br_nombreTabla = Activator.CreateInstance( _businessRulesType );
				_instance = (System.Data.DataRow)_newMemberMethod.Invoke( br_nombreTabla, new object[]{ }  );
			}
			catch(Exception e)
			{
				System.Console.WriteLine((string) e.Message);
		    }
		}


		protected virtual void Modify(object id)
		{
			object instance = Activator.CreateInstance( _businessRulesType );
			_instance = (System.Data.DataRow)_editMemberMethod.Invoke( instance, new object[]{ id } );
		}


		protected virtual void Delete()
		{
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
			_saveChangesMethod.Invoke( instance, new object[]{ _instance } );
			Evaluate();
		}


		public delegate void RowChanged( object sender, EventArgs args );

		public event RowChanged OnRowChanged;

		protected void Evaluate()
		{
			if (((System.Data.DataRow) _instance).HasErrors)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors((System.Data.DataRow) _instance);
				_form.MdiParent = mz.erp.ui.utility.Environment.MainForm;
				_form.Show();
				((System.Data.DataRow) _instance).ClearErrors();
			}
			else
			{
				MessageBox.Show("La acción se ha ejecutado con éxito");
				if ( OnRowChanged != null )
				{
					OnRowChanged( this, null );
				}

				Close();
			}
		}

		#endregion



		





		#region Código generado por el Diseñador de Windows Forms

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMInstanceManager));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.DatosGenerales = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.barra = new System.Windows.Forms.ToolBar();
			this.primero = new System.Windows.Forms.ToolBarButton();
			this.anterior = new System.Windows.Forms.ToolBarButton();
			this.siguiente = new System.Windows.Forms.ToolBarButton();
			this.ultimo = new System.Windows.Forms.ToolBarButton();
			this.separador1 = new System.Windows.Forms.ToolBarButton();
			this.actualizar = new System.Windows.Forms.ToolBarButton();
			this.separador2 = new System.Windows.Forms.ToolBarButton();
			this.guardar = new System.Windows.Forms.ToolBarButton();
			this.separador3 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DatosGenerales
			// 
			this.DatosGenerales.Location = new System.Drawing.Point(28, 49);
			this.DatosGenerales.Name = "DatosGenerales";
			this.DatosGenerales.Size = new System.Drawing.Size(759, 150);
			this.DatosGenerales.TabIndex = 0;
			this.DatosGenerales.TabStop = true;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// barra
			// 
			this.barra.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.barra.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					 this.primero,
																					 this.anterior,
																					 this.siguiente,
																					 this.ultimo,
																					 this.separador1,
																					 this.actualizar,
																					 this.separador2,
																					 this.guardar,
																					 this.separador3});
			this.barra.DropDownArrows = true;
			this.barra.ImageList = this.imglStandar;
			this.barra.Location = new System.Drawing.Point(0, 0);
			this.barra.Name = "barra";
			this.barra.ShowToolTips = true;
			this.barra.Size = new System.Drawing.Size(808, 28);
			this.barra.TabIndex = 16;
			this.barra.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.barra.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);
			// 
			// primero
			// 
			this.primero.ImageIndex = 0;
			// 
			// anterior
			// 
			this.anterior.ImageIndex = 1;
			// 
			// siguiente
			// 
			this.siguiente.ImageIndex = 2;
			// 
			// ultimo
			// 
			this.ultimo.ImageIndex = 3;
			// 
			// separador1
			// 
			this.separador1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// actualizar
			// 
			this.actualizar.ImageIndex = 5;
			// 
			// separador2
			// 
			this.separador2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// guardar
			// 
			this.guardar.ImageIndex = 4;
			this.guardar.Text = "&Guardar";
			// 
			// separador3
			// 
			this.separador3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.DatosGenerales);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.DatosGenerales;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(808, 378);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
			this.ultraExplorerBar1.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
			// 
			// FrmABMInstanceManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(808, 406);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.barra);
			this.Name = "FrmABMInstanceManager";
			this.Text = "FrmABMInstanceManager";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( barra.Buttons.IndexOf( e.Button ) )
			{
				case 0://primero
					break;
				case 1://anterior
					break;
				case 2://siguiente
					break;
				case 3://ultimo
					break;
				case 5://actualizar					
					break;
				case 7://guardar
					SaveChanges();
					break;
				case 9://borrar
					Delete();
					break;
			}		
		}

		protected void FrmABMInstanceManager_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
		
		}



	}
}

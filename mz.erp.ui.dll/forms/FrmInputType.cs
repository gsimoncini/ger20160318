using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmInputType.
	/// </summary>
	public class FrmInputType : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl Container;
		private System.Windows.Forms.ToolBarButton tbbAceptar;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.ComponentModel.IContainer components;

		public FrmInputType(string caption, object binding, string property, Type dataTypeProperty, Type dataTypeBinding)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_caption = caption;
			_binding = binding;
			_property = property;
			_controlDataType = dataTypeProperty;
			_bindingDataType = dataTypeBinding;
			_oldValue = dataTypeBinding.GetProperty(_property).GetValue(binding,null);
			
			ConfigUI();
			InitEvents();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}


		private string _property = null;
		private string _caption = null;
		private Type _controlDataType = null;
		private object _binding = null; 
		private Type _bindingDataType = null;
		private object _oldValue = null;


		/*
		private Type _controlDataType = null;
		public Type ControlDataType
		{
			set
			{	
				_controlDataType = value;
				if(_controlDataType != null)
					ConfigUI();
			}
		}
*/

		private void ConfigUI()
		{
			
			
			this.Text = "Ingrese " + _caption;
			SuspendLayout();
			this.Container.SuspendLayout();
			this.Container.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
			//panelTop.Controls.Clear();
			this.Container.AutoScroll = true;

			int y = 1;
			int tabIndex = 0;
			if ( _controlDataType == typeof ( System.String ) )
				{
					//AddTextBox( _caption, tabIndex++, 160, y );
					AddMemo( _caption, tabIndex++, 2, y );
				}
				else 
				
					if (_controlDataType == typeof ( System.Int64 ) )
					{
						 AddNumericBox( _caption, tabIndex++,1, y, "System.Int64" );
					}
					else
					
						if (_controlDataType == typeof ( System.Decimal ) )
						{
							 AddNumericBox( _caption, tabIndex++,1, y,  "System.Decimal" );
						}
						else
						
							if (_controlDataType == typeof ( System.DateTime ) )
							{
								AddDateTimeBox( _caption, tabIndex++,1, y );
							}
							else
							{
								MessageBox.Show( string.Format( "No se ha implementado editor para el tipo '{0}'", _controlDataType.ToString() ) );
							}
						
			this.Container.ResumeLayout( false );
			ResumeLayout( false );
			this.Container.Refresh();
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
		}

		private void InitEvents()
		{
			toolBarStandar.ButtonClick+=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
		}


		private Infragistics.Win.UltraWinEditors.UltraTextEditor AddTextBox( string name, int tabIndex, int x, int y )
		{
			Infragistics.Win.UltraWinEditors.UltraTextEditor txt = new Infragistics.Win.UltraWinEditors.UltraTextEditor();

			txt.Location = new System.Drawing.Point( x, y );
			txt.Name = string.Format( "txt{0}", name );
			txt.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			txt.TabStop = true;
			txt.TabIndex = tabIndex;
			txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			txt.DataBindings.Add("Text",_binding,_property);
			this.Container.Controls.Add( txt );

			return txt;
		}

		private System.Windows.Forms.TextBox AddMemo( string name, int tabIndex, int x, int y )
		{
			System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();

			txt.Location = new System.Drawing.Point( x, y );
			txt.Name = string.Format( "txt{0}", name );
			txt.Size = new System.Drawing.Size( this.Container.Width , 105 );
			txt.TabStop = true;
			txt.TabIndex = tabIndex;
			txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			txt.Multiline = true;
			txt.AutoSize = true;
			txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			txt.DataBindings.Add("Text",_binding,_property);
			//this.Container.Height = 94;
			txt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Container.Controls.Add( txt );
			
			return txt;
		}



		private void AddNumericBox( string name, int tabIndex, int x, int y, string tag )
		{
			Infragistics.Win.UltraWinEditors.UltraNumericEditor une = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();

			une.Location = new System.Drawing.Point( 29, 49);
			une.Name = string.Format( "txt{0}", name );
			une.Size = new System.Drawing.Size( 100, 23 );
			une.TabStop= true;
			une.TabIndex = tabIndex;
			une.Value = null;
			une.Tag = tag;
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			une.DataBindings.Add("Value",_binding,_property);
			//this.SetBounds(this.Location.X, this.Location.Y, 100,50);
			//une.Dock = System.Windows.Forms.DockStyle.Right;
			this.Container.Size = new System.Drawing.Size(100, 100);
			this.Container.Controls.Add(une);
			
			

			
		}
		private void AddDateTimeBox( string name, int tabIndex, int x, int y )
		{
			Infragistics.Win.UltraWinEditors.UltraDateTimeEditor une = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();

			une.Location = new System.Drawing.Point( x, y );
			une.Name = string.Format( "txt{0}", name );
			une.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			une.TabStop = true;
			une.TabIndex = tabIndex;
			une.Value ="";
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			une.DataBindings.Add("Value",_binding,_property);
			
			this.Container.Controls.Add( une );

			
		}


		private int GetControlWidth()
		{
			//return  this.Container.Size.Width - ( 175 );
			//return  panelTop.Width - ( 185 );
			return  this.Container.Size.Width;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmInputType));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.Container = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAceptar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Container
			// 
			this.Container.Location = new System.Drawing.Point(28, 49);
			this.Container.Name = "Container";
			this.Container.Size = new System.Drawing.Size(657, 176);
			this.Container.TabIndex = 0;
			this.Container.TabStop = true;
			this.Container.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Paint);
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
																							  this.tbbAceptar,
																							  this.tbbSeparator,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(706, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAceptar
			// 
			this.tbbAceptar.Text = "Aceptar";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.Container);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.Container;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 176;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(706, 252);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
			this.ultraExplorerBar1.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
			// 
			// FrmInputType
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(706, 280);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmInputType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Formulario de Entrada";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion






		private void Aceptar()
		{
			
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Cancelar()
		{
			this.DialogResult = DialogResult.Cancel;
			_bindingDataType.GetProperty(_property).SetValue(_binding, _oldValue,null);
			this.Close();
		}

		private void panelTop_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}



		/*
		public string Value 
		{
			get
			{	
				return panelTop.Controls[0].Text;
			}
		
		}
		*/

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			Aceptar();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Cancelar();
		}

		private void Container_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
		
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					toolBarStandar.Select();
					Aceptar();
					break;
				case 2:
					Cancelar();
					break;
				
			}
		}
	}
}

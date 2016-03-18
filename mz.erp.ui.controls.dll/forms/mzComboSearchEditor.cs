using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using mz.erp.ui.controls.forms;

namespace mz.erp.ui.controls
{
	public class mzComboSearchEditor : System.Windows.Forms.UserControl
	{
		private Infragistics.Win.UltraWinEditors.UltraTextEditor editorID;
		private Infragistics.Win.Misc.UltraLabel labelDescription;
		private System.Windows.Forms.Button buttonElipsis;
		private System.ComponentModel.IContainer components;
		private Parameters _parameters;
		private MethodBase _searchMethod;
		private string _dataSource = string.Empty;
		private System.Windows.Forms.ToolTip toolTip;
		private bool _propertyMode = false;

		public mzComboSearchEditor()
		{
			InitializeComponent();
			
		}

		private void SetToolTip( string caption )
		{
			toolTip.SetToolTip( labelDescription, caption );
			toolTip.SetToolTip( editorID, caption );
			toolTip.SetToolTip( buttonElipsis, caption );
			toolTip.SetToolTip( this, caption );
		}

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

		#region Código generado por el Diseñador de componentes
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			this.editorID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.labelDescription = new Infragistics.Win.Misc.UltraLabel();
			this.buttonElipsis = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.editorID)).BeginInit();
			this.SuspendLayout();
			// 
			// editorID
			// 
			this.editorID.Location = new System.Drawing.Point(0, 0);
			this.editorID.Name = "editorID";
			this.editorID.Size = new System.Drawing.Size(104, 22);
			this.editorID.TabIndex = 0;
			this.editorID.Leave += new System.EventHandler(this.editorID_Leave);
			// 
			// labelDescription
			// 
			appearance1.TextVAlign = Infragistics.Win.VAlign.Middle;
			this.labelDescription.Appearance = appearance1;
			this.labelDescription.BackColor = System.Drawing.SystemColors.Control;
			this.labelDescription.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.labelDescription.Location = new System.Drawing.Point(136, 0);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(352, 22);
			this.labelDescription.TabIndex = 3;
			// 
			// buttonElipsis
			// 
			this.buttonElipsis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonElipsis.Location = new System.Drawing.Point(106, 0);
			this.buttonElipsis.Name = "buttonElipsis";
			this.buttonElipsis.Size = new System.Drawing.Size(22, 22);
			this.buttonElipsis.TabIndex = 2;
			this.buttonElipsis.TabStop = false;
			this.buttonElipsis.Text = "...";
			this.buttonElipsis.Click += new System.EventHandler(this.buttonElipsis_Click);
			// 
			// mzComboSearchEditor
			// 
			this.Controls.Add(this.buttonElipsis);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.editorID);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "mzComboSearchEditor";
			this.Size = new System.Drawing.Size(496, 24);
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.mzSearchControl_Layout);
			((System.ComponentModel.ISupportInitialize)(this.editorID)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		private void mzSearchControl_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			int labelWidth = Width - ( editorID.Width + buttonElipsis.Width + 4 );
			labelDescription.Width = labelWidth;
			labelDescription.Height = 22; 
			labelDescription.Left = editorID.Width + buttonElipsis.Width + 4;

			Height = 22;
			buttonElipsis.Height = 22;
		}

		private Type _searchObject;
		public Type SearchObject
		{
			get
			{
				return _searchObject;
			}
			set
			{
				_searchObject = value;
				LoadParameters();
			}
		}

		private void LoadParameters()
		{
			if ( _searchObject == null ) return;


			foreach( MethodBase mb in _searchObject.GetMethods() )
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is SearchMember)
					{
						SearchMember sm = ( SearchMember )am;
						_dataSource = sm.DataSource;

						_searchMethod = mb;

						_parameters = new Parameters();

						ParameterInfo[] pi = mb.GetParameters();
						for( int i = 0; i < pi.Length; i++ )
						{
							Parameter _parameter = new Parameter( pi[ i ].Name, pi[ i ] );
							_parameters.Add( _parameter );

							foreach( Attribute ap in pi[ i ].GetCustomAttributes( false ) )
							{
								if ( ap is SearchParameterInfo )
								{
									SearchParameterInfo smi = ( SearchParameterInfo )ap;

									_parameter.Caption = smi.Caption;
									_parameter.IsAlternativePrimaryKey = smi.IsAlternativePrimaryKey;
									_parameter.IsDescription = smi.IsDescription;
								}
							}
						}
					}
				}
			}
		}

		private void editorID_Leave(object sender, System.EventArgs e)
		{
			FillDescription();
		}

		private void FillDescription()
		{
			if ( editorID.Text != string.Empty )
			{
				labelDescription.Text = GetDescription( editorID.Text );
				SetToolTip( GetToolTipString() );
			}
			else
			{
				toolTip.RemoveAll();
			}
		}

		private string GetToolTipString()
		{
			string s = string.Empty;
			for( int i = 0; i < _parameters.Count; i++ )
			{
				if ( _parameters[ i ].Text != string.Empty )
				{
					s += _parameters[ i ].Caption + ": " + _parameters[ i ].Text + "\r\n";
				}
			}

			return s;
		}

		private string GetDescription( object alternativePrimaryKeyValue )
		{
			try
			{
				_parameters.AlternativePrimaryKey.Value = alternativePrimaryKeyValue;

				object instance = Activator.CreateInstance( _searchObject, true );

				object resultValue = _searchMethod.Invoke( instance, _parameters.InvokeParameters );

				if ( resultValue != null && resultValue is DataSet )
				{
					DataSet data = ( DataSet )resultValue;
					DataTable table = data.Tables[ _dataSource ];
					if ( table.Rows.Count == 1 )
					{
						for( int i = 0; i < _parameters.Count; i++ )
						{
							_parameters[ i ].Text = table.Rows[ 0 ][ _parameters[ i ].Name ].ToString();
						}

						return _parameters.Description.Text;
					}
					else if ( table.Rows.Count > 1 )
					{
						if ( _propertyMode )
						{
							throw( new ArgumentException( "El valor seleccionado no se ha encontrado en el orígen de datos.", "DataValue" ) );
						}
						else
						{
							MessageBox.Show( "Seleccione valores de clave completa" );
							//Implementar búsqueda parcial
						}
					}
				}
			}
			catch
			{
			}

			return string.Empty;
		}

		private void buttonElipsis_Click(object sender, System.EventArgs e)
		{
			mzSearchForm sf = new mzSearchForm( _searchObject );

			DialogResult dr = sf.ShowDialog();
			if ( dr == DialogResult.OK )
			{
				DataValue = sf.SelectedValue;
				FillDescription();
			}
		}

		public object DataValue
		{
			get
			{
				return editorID.Text;
			}
			set
			{
				editorID.Text = ( string )value;
				_propertyMode = true;
				FillDescription();
				_propertyMode = false;

			}
		}

		public string DisplayValue
		{
			get
			{
				return labelDescription.Text;
			}
		}

	}
}

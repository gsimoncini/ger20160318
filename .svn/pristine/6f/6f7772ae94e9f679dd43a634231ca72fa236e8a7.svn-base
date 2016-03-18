using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using mz.erp.ui.controls.forms;
using mz.erp.commontypes;

namespace mz.erp.ui.controls
{
	public class mzComboSearchEditor : System.Windows.Forms.UserControl
	{
		private Infragistics.Win.UltraWinEditors.UltraTextEditor editorID;
		private Infragistics.Win.Misc.UltraLabel labelDescription;
		private System.Windows.Forms.Button buttonElipsis;
		private System.ComponentModel.IContainer components;
		private string _lastValue;
		
		
		#region Eventos y Delegados
		/// <summary>
		/// Tiene lugar cuando la propiedad DataValue ha cambiado
		/// </summary>
		public event System.EventHandler ValueChanged;
		public event System.EventHandler DataValueChanged;


		private bool _hierarchicalSearch = false;


		#endregion

		#region Constructores y Destructores
		public mzComboSearchEditor()
		{
			InitializeComponent();			
		}


		public mzComboSearchEditor(bool hierarchicalSearch)
		{
			InitializeComponent();
			this._hierarchicalSearch = hierarchicalSearch;

		}

		public bool HierarchicalSearch
		{	
			get{return _hierarchicalSearch;}
			set{_hierarchicalSearch = value;}
		}

		private void SetToolTip( string caption )
		{
			toolTip.SetToolTip( labelDescription, caption );
			toolTip.SetToolTip( editorID, caption );
			toolTip.SetToolTip( buttonElipsis, caption );
			toolTip.SetToolTip( this, caption );
		}

		private DataRow _selectedRow = null;
		public DataRow SelectedRow
		{
			get 
			{
				if (_selectedRow != null) 
				{return _selectedRow;}								
				else
				{return null;}
			}
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

		#endregion

		#region Variables Privadas

		private Parameters _parameters;
		private MethodBase _searchMethod;
		private string _dataSource = string.Empty;
		private System.Windows.Forms.ToolTip toolTip;
		private bool _propertyMode = false;
		private string _layoutData = string.Empty;

		private bool _fastSearch = false;

		private string _orderBy = null;

		private int _widthSearchForm = 560;		

		private string _description ;

		#endregion

		#region Variables Publicas
		/*private DataRow _selectedRow = null;
		public DataRow SelectedRow
		{
			get 
			{
				if (_selectedRow != null) 
				{return _selectedRow;}								
				else
				{return null;}
			}
		}*/		
		public int WidthSearchForm
		{
			set
			{
				_widthSearchForm = value;
			}
		}

		public string OrderBy
		{
			set
			{
				_orderBy = value;
			}
		}
		
		public bool FastSearch
		{
			get
			{
				 return _fastSearch;
			}
			set
			{
				_fastSearch = value;
			}
		}

		public string Description
		{
			
			get
			{
				return _description ;
			}
		}

		private bool _allowMultipleSelect = false;
		public bool AllowMultipleSelect
		{
			set
			{
				_allowMultipleSelect = value;
			}
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
		
		private Type _editObject;
		public Type EditObject
		{
			get
			{
				return _editObject;
			}
			set
			{
				_editObject = value;
				ConfigureEditObject();
			}
		}

		private ISearchObjectListener _searchObjectListener;
		public ISearchObjectListener SearchObjectListener
		{
			get{return _searchObjectListener;}
			set{_searchObjectListener = value;}
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
				_lastValue = (string)value;
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

			
		public string LayoutData
		{
			set
			{
				_layoutData = value;
				
			}
		}

		private ArrayList _selectedItems = new ArrayList();
		public ArrayList SelectedItems
		{
			get 
			{
				return _selectedItems;	
			}
		}

		#endregion

		#region Funciones y Métodos Privados
		/*private void SetToolTip( string caption )
		{
			toolTip.SetToolTip( labelDescription, caption );
			toolTip.SetToolTip( editorID, caption );
			toolTip.SetToolTip( buttonElipsis, caption );
			toolTip.SetToolTip( this, caption );
		}*/

		private void mzSearchControl_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			int labelWidth = Width - ( editorID.Width + buttonElipsis.Width + 4 );
			labelDescription.Width = labelWidth;
			labelDescription.Height = 22; 
			labelDescription.Left = editorID.Width + buttonElipsis.Width + 4;

			Height = 22;
			buttonElipsis.Height = 22;
		}
		private void ConfigureEditObject()
		{
		

		}
		private void LoadParameters()
		{
			if ( _searchObject == null ) return;
			foreach( PropertyInfo mb in _searchObject.GetProperties())
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is atHierarchicalSearch )
					{
						object instance = Activator.CreateInstance( _searchObject );
						_hierarchicalSearch = (bool)mb.GetValue( instance , null );
					}
				}
			}
			
			foreach( MethodBase mb in _searchObject.GetMethods() )
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is SearchMember )
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
									_parameter.IsSearch = smi.IsSearch;
									_parameter.IsDescription = smi.IsDescription;
									_parameter.Metodo = smi.Metodo;
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
			if ( editorID.Text != string.Empty)
			{
				//if(_description == null		)
				_description = GetDescription(editorID.Text);
					
				labelDescription.Text = _description;
				if (_description == "") 
				{
					editorID.Text = "";
					//Nuevo German 01/09/2005 *********************************************
					_selectedItems.Clear();
					_selectedRow = null;
					//*********************************************************************
				}
				else 
				{
					SetToolTip( GetToolTipString() );
				}				
			}
			else
			{
				toolTip.RemoveAll();
				labelDescription.Text = "";
				//Nuevo German 01/09/2005 *********************************************
				_selectedItems.Clear();
				_selectedRow = null;
				//*********************************************************************
			}
			if (ValueChanged != null)
			{
				ValueChanged( this, new System.EventArgs() );
			}
			if (DataValueChanged != null)
				DataValueChanged(this, new EventArgs());
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
						string apk = "";
						for( int i = 0; i < _parameters.Count; i++ ) 
						{
							if (_parameters[i].IsAlternativePrimaryKey) 
							{
								apk = _parameters[i].Value.ToString();
							}
						}
						for( int i = 0; i < _parameters.Count; i++ )
						{
							if (_parameters[i].IsSearch) 
							{
								_parameters[ i ].Text = table.Rows[ 0 ][ _parameters[ i ].Name ].ToString();
							}
							else 
							{								
								_parameters[ i ].Text = Convert.ToString(_searchObject.InvokeMember( _parameters[i].Metodo, System.Reflection.BindingFlags.InvokeMethod, null, instance, new object[] {apk}));
							}							
							_selectedRow = table.Rows[0];
							if(_selectedRow != null)
							{
								_selectedItems.Clear();
								this._selectedItems.Add( this._selectedRow );
							}
								
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
							//MessageBox.Show( "Seleccione valores de clave completa" );
							//Implementar búsqueda parcial
							foreach(System.Data.DataRow row in table.Rows)
							{
								if(row[_parameters.AlternativePrimaryKey.Name].Equals(alternativePrimaryKeyValue))
								{
									for( int i = 0; i < _parameters.Count; i++ )
									{
										_parameters[ i ].Text = row[ _parameters[ i ].Name ].ToString();
										_selectedRow = row;															
									}

									return _parameters.Description.Text;
								}

							}
						}
					}
				}
			}
			catch (Exception e)
			{
				System.Diagnostics.Debug.WriteLine(e.ToString());
			}

			return string.Empty;
		}
		
		private void _CallSearchFormMember( int tipodebusqueda )
		{
			switch (tipodebusqueda)
			{
				case 0:	//si es busqueda normal
				{
					mzSearchForm sf = new mzSearchForm( _searchObject, _editObject, _fastSearch, _orderBy, _widthSearchForm, _layoutData);
					sf.SearchObjectListener = _searchObjectListener;
					sf.AllowMultipleSelect = _allowMultipleSelect;
					sf.LayoutData = _layoutData;
					
					DialogResult dr = sf.ShowDialog();

					if ( dr == DialogResult.OK )
					{
						if (sf.SelectedItems.Count > 1)
						{
							_selectedItems = sf.SelectedItems;
							if (ValueChanged != null)
							{
								ValueChanged( this, new System.EventArgs() );
							}
							if (DataValueChanged != null)
							{
								DataValueChanged(this, new EventArgs());
							}
						}
						else
						{
							if (sf.SelectedItems.Count == 1)
							{
								_selectedItems = sf.SelectedItems;
								DataValue = sf.SelectedValue;
								_description = (string)sf.SelecedDescription;
								_selectedRow = sf.SelectedRow;
								//FillDescription();

							}
						}
						
						/*
					
						if (sf.SelectedItems.Count > 1)
						{
							_selectedItems = sf.SelectedItems;
						}
						else
						{
							FillDescription();
						}
					
						System.Diagnostics.Debug.WriteLine( mz.erp.businessrules.Sistema.DateTime.Now.ToLongTimeString() );
					*/
					
					}
				}
				break;
				case 1 :
				{
					mzHierarchicalSearchForm hsf = new mzHierarchicalSearchForm(_searchObject, _editObject, false, _orderBy);
					hsf.SearchObjectListener = _searchObjectListener;
					DialogResult dr = hsf.ShowDialog();
					if ( dr == DialogResult.OK )
					{
						DataValue = hsf.SelectedValue;
						_description = (string)hsf.SelecedDescription;
						_selectedRow = hsf.SelectedRow;
						FillDescription();				
					}
				}
					break;

			}
		}
		private void buttonElipsis_Click(object sender, System.EventArgs e)
		{
			_CallSearchFormMember( 0 );
		}

		private void editorID_ValueChanged(object sender, System.EventArgs e)
		{
			
		}
		
		private void editorID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyData == System.Windows.Forms.Keys.F2)
			{
				_CallSearchFormMember( 0 );
			}					
			else
			{
				if (e.KeyData == System.Windows.Forms.Keys.F3)
				{
					_CallSearchFormMember( 1 );
				}
			}		
		}


		#endregion

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
			this.editorID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editorID_KeyDown);
			this.editorID.Leave += new System.EventHandler(this.editorID_Leave);
			this.editorID.ValueChanged += new System.EventHandler(this.editorID_ValueChanged);
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
			this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
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

		private void labelDescription_Click(object sender, System.EventArgs e)
		{
		
		}



		

		




		





	}
}

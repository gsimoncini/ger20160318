using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using mz.erp.commontypes;
using mz.erp.businessrules;



namespace mz.erp.ui.controls
{

	public class mzSearchPanel : System.Windows.Forms.UserControl
	{

		private System.ComponentModel.IContainer components;
		internal Janus.Windows.GridEX.GridEX gridEx;
		private Parameters _parameters;
		private string _dataSource = string.Empty;
		private string _getCaption = string.Empty;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSearchNow;
		private System.Windows.Forms.ToolBarButton tbNewSearch;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.ToolBarButton tbNew;
		private System.Windows.Forms.ToolBarButton tbEdit;
		private System.Windows.Forms.ToolBarButton tbSep;
		private MethodBase _searchMethod;
		private MethodBase _showMethod;
		private MethodBase _layoutMethod;
		private System.Windows.Forms.ToolBarButton tbDetail;
		private MethodBase _detailMethod;
		private PropertyInfo _allowMultipleSelectMethod;
		private MethodBase _showWithParameterValueMethod;
		private FormatoCondicional _formato;


		#region Eventos

		public delegate void SearchPanelEventHandler( object sender, SearchEventArgs e );
		public event SearchPanelEventHandler RowDoubleClick;
		public event EventHandler NewClick;
		public event EventHandler EditClick;
		public event EventHandler RefreshDataEvent;

		#endregion

		public mzSearchPanel()
		{
			InitializeComponent();			
			this.tbNew.Visible = false;
			this.tbEdit.Visible = false;
			this.tbDetail.Visible = false;
		}

		public string GetCaption
		{
			get{return _getCaption;}
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

		private ISearchObjectListener _searchObjectListener;
		public ISearchObjectListener SearchObjectListener
		{
			get{return _searchObjectListener;}
			set{_searchObjectListener = value;}
		}

		private string _layoutData = string.Empty;
		public string LayoutData
		{
			get
			{
				return _layoutData;
			}
			set 
			{
				_layoutData = value;
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
				BuildUI();
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
				SetupEditObject();
			}
		}

		private Type _detailObject;

		public Type DetailObject
		{
			get
			{
				return _detailObject;
			}
			set
			{
				_detailObject = value;
				SetupDetailObject();
			}
		}
		private String _caption;

		public String Caption
		{
			get
			{
				return _caption;
			}
			set
			{
				_caption = value;				
			}
		}

		private string _orderBy = null;

		public string OrderBy
		{
			set
			{
				_orderBy = value;
			}
		
		}

		private bool _orderUIAvailable = false;
		private bool _fastSearch = false; 

		public bool FastSearch
		{
			set
			{
				_fastSearch = value;
			}
		}

		private bool _allowMultipleSelect = false;
		public bool AllowMultipleSelect
		{
			set { 
				_allowMultipleSelect = value;
				ConfigureGrid();
					}
			get { return _allowMultipleSelect ; }
		}

		private ArrayList _arraySelectedItems = new ArrayList();
		public ArrayList ArraySelectedItems
		{
			get 
			{
				if (gridEx.SelectedItems.Count > 0) 
				{
					BuildArraySelectedItems();
					return _arraySelectedItems;
				}
				else return null;
				
			}	
		}

		private void BuildArraySelectedItems()
		{
			_arraySelectedItems.Clear();
			foreach (Janus.Windows.GridEX.GridEXSelectedItem sel in gridEx.SelectedItems)
			{
				_arraySelectedItems.Add ( ((System.Data.DataRowView)sel.GetRow().DataRow).Row );				
			}
		}

		public System.Data.DataRow SelectedRow
		{
			get 
			{
				if (gridEx.SelectedItems.Count > 0) 
				{
					BuildArraySelectedItems();
					return ((System.Data.DataRowView) gridEx.SelectedItems[ 0 ].GetRow().DataRow).Row;
				}
				else
				{
					return null;
				}
				
			}
		}

		private void SetupDetailObject()
		{
			if ( _detailObject == null ) return;

			tbDetail.Visible = true; 

			foreach( MethodBase mb in _detailObject.GetMethods() )
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is IsShowFormMember )
					{
						_detailMethod = mb;
					}

				}
			}
		}

		private void SetBotones()
		{
			//los pongo en false por default
			tbEdit.Visible = false;
			tbNew.Visible = false;
			string[] nombre = this.SearchObject.ToString().Split('_');

			//seteo el boton "nuevo"			
			string[] listaPerfilesNuevo = Variables.GetValueString(nombre[1]+".BotonNuevo.PerfilesHabilitados").Split(',');
			foreach (string str in listaPerfilesNuevo)
			{
				if (str.Equals(Security.IdPerfil.ToString()))
				{
					tbNew.Visible = true;
					tbNew.Enabled = true;
				}
			}
			//seteo el boton "editar"
			string[] listaPerfilesEditar = Variables.GetValueString(nombre[1]+".BotonEditar.PerfilesHabilitados").Split(',');
			foreach (string str in listaPerfilesEditar)
			{
				if (str.Equals(Security.IdPerfil.ToString()))
				{
					tbEdit.Visible = true;
					tbEdit.Enabled= true;
				}
			}
		}
		private void SetupEditObject()
		{
			if ( _editObject == null ) return;

			SetBotones();
			
			if(!_fastSearch)
				tbEdit.Enabled = false;

			foreach( MethodBase mb in _editObject.GetMethods() )
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is IsShowFormMember )
					{
						_showMethod = mb;
					}
					else if (am is IsShowWithParametersValueFormMember)
					{
						_showWithParameterValueMethod = mb;
					}
				}
			}
		}

		private void LoadParameters()
		{
			if ( _searchObject == null ) return;

			foreach( PropertyInfo mb in _searchObject.GetProperties())
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
				
					if ( am is atAllowMultipleRows )
					{
						_allowMultipleSelectMethod = mb;
					}
					if ( am is atFormatCondition) 
					{
						_formato = (FormatoCondicional) mb.GetValue(_searchObject,null);						 
					}
				}
			}

			foreach( MethodBase mb in _searchObject.GetMethods() )
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is SearchMember)
					{
						SearchMember sm = ( SearchMember )am;
						_dataSource = sm.DataSource;
						_getCaption = sm.Caption;
						_orderUIAvailable = sm.OrderUIAvailable;

						if(!_fastSearch)
							_fastSearch= sm.FastSearch;

						_searchMethod = mb;

						_parameters = new Parameters();
						_parameters.OrderUIAvailable = _orderUIAvailable;

						ParameterInfo[] pi = mb.GetParameters();
						for( int i = 0; i < pi.Length; i++ )
						{
							Parameter _parameter = new Parameter( pi[ i ].Name, pi[ i ] );
							_parameter.EditorType = SearchEditorType.Standar;
							_parameter.EditorObject = pi[ i ].ParameterType;

							_parameters.Add( _parameter );
							

							foreach( Attribute ap in pi[ i ].GetCustomAttributes( false ) )
							{
								if ( ap is SearchParameterInfo )
								{
									SearchParameterInfo smi = ( SearchParameterInfo )ap;

									if (smi.CaptionVariable == String.Empty) 
									{
										_parameter.Caption = smi.Caption;
									}
									else 
									{
										_parameter.Caption = Variables.GetValueString(smi.CaptionVariable);
										//En el futuro debería manejarse desde un controller para no hacer
										//referencia directa con BS.
									}									
									
									_parameter.IsAlternativePrimaryKey = smi.IsAlternativePrimaryKey;
									_parameter.IsDescription = smi.IsDescription;
									if(_orderUIAvailable)
										_parameter.OrderUI = smi.OrderUI;
								}

								if ( ap is SearchEditor )
								{
									SearchEditor se = ( SearchEditor )ap;
									_parameter.EditorType = se.EditorType;
									_parameter.EditorObject = se.EditorObject;
									if(_orderUIAvailable)
										_parameter.OrderUI = se.OrderUI;
								}
								
							}
						}
					}
					if (am is atMethodLayoutData)
					{
						_layoutMethod = mb;
					}
				}
			}
		}

		private void BuildUI()
		{
			if ( _parameters == null ) return;

			SuspendLayout();
			panelTop.SuspendLayout();
			
			panelTop.Controls.Clear();
			panelTop.AutoScroll = true;

			int y = 5;
			int tabIndex = 0;
			ArrayList paramsSorted = _parameters.Sort();
			for( int i = 0; i < paramsSorted.Count; i++ )
			{
				Parameter p = (Parameter)paramsSorted[ i ];
				//Guarda con esto
				p.Value = null;

				AddLabel( p.Name, p.Caption, tabIndex++, 5, y );

				if ( p.EditorType == SearchEditorType.Standar )
				{
					if ( p.EditorObject == typeof ( System.String ) )
					{
						p.InputControl = AddTextBox( p.Name, tabIndex++, 160, y );
					}
					else 
					{
						if (p.EditorObject == typeof ( System.Int64 ) )
						{
							p.InputControl = AddNumericBox( p.Name, tabIndex++,160, y, "System.Int64" );
						}
						else
						{
							if (p.EditorObject == typeof ( System.Decimal ) )
							{
								p.InputControl = AddNumericBox( p.Name, tabIndex++,160, y,  "System.Decimal" );
							}
							else
							{
								if (p.EditorObject == typeof ( System.DateTime ) )
								{
									p.InputControl = AddDateTimeBox( p.Name, tabIndex++,160, y );
								}
								else
								{

									if (p.EditorObject == typeof ( System.Boolean ) )
									{
										p.InputControl = AddCheckBox( p.Name, tabIndex++,160, y );										
										p.Value = (object) true;
									}
									else
									{
										MessageBox.Show( string.Format( "No se ha implementado editor para el tipo '{0}'", p.EditorType.ToString() ) );
									}

								}
								
							}
						}
					}
				}

				else if ( p.EditorType == SearchEditorType.Search )
				{
					p.InputControl = AddSearchEdit( p.Name, tabIndex++, p.EditorObject, 160, y );
				}
				//Le asociamos el evento KeyDown para realizar busquedas por F2
				//p.InputControl.KeyDown += new KeyEventHandler(InputControl_KeyDown);
				y += 24;
			}

			panelTop.ResumeLayout( false );
			ResumeLayout( false );
			panelTop.Refresh();

			if (_allowMultipleSelectMethod != null)
			{
				object instance = Activator.CreateInstance( _searchObject, true );
				_allowMultipleSelect= (bool) _allowMultipleSelectMethod.GetValue( instance, null );
			}
				/*
			else
			{
				_allowMultipleSelect= false;
			}
			*/

			if (_allowMultipleSelect)
			{
				gridEx.SelectionMode= Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			}
			else
			{
				gridEx.SelectionMode= Janus.Windows.GridEX.SelectionMode.SingleSelection;
			}

			if(_fastSearch)
			{
				this.SearchNow();
				this.SelectGrid();
			}
			else
			{
				if(_searchObject != null)
				{
					object instance = Activator.CreateInstance( _searchObject, true );

					if (_layoutMethod != null && (_layoutData == null || _layoutData.Equals(string.Empty)))
					{
						_layoutData = (string) _layoutMethod.Invoke( instance, null );
					
						if (_layoutData !=null)
						{
							gridEx.LayoutData = _layoutData;
						}
					}
					else
						gridEx.LayoutData = _layoutData;
				}
				
			}
		}

		public void SelectGrid()
		{
			if(this.gridEx.RowCount > 0)
				this.gridEx.Select();
		}

		private void ConfigureGrid()
		{
			if (_allowMultipleSelect)
			{
				gridEx.SelectionMode= Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			}
		}


		private void  InputControl_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				
				case System.Windows.Forms.Keys.F2 :
					SearchNow();
					
					break;
				default:
					break;

			}

		}

		private void ResetUI()
		{

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

			panelTop.Controls.Add( txt );

			return txt;
		}

		private Infragistics.Win.UltraWinEditors.UltraCheckEditor AddCheckBox( string name, int tabIndex, int x, int y, string tag )
		{
			Infragistics.Win.UltraWinEditors.UltraCheckEditor une = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();

			une.Location = new System.Drawing.Point( x, y );
			une.Name = string.Format( "txt{0}", name );
			une.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			une.TabStop= true;
			une.TabIndex = tabIndex;
			une.Checked = false;
			une.Tag = tag;
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			panelTop.Controls.Add( une );

			return une;
		}

		private Infragistics.Win.UltraWinEditors.UltraNumericEditor AddNumericBox( string name, int tabIndex, int x, int y, string tag )
		{
			Infragistics.Win.UltraWinEditors.UltraNumericEditor une = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();

			une.Location = new System.Drawing.Point( x, y );
			une.Name = string.Format( "txt{0}", name );
			une.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			une.TabStop= true;
			une.TabIndex = tabIndex;
			une.Value = null;
			une.Tag = tag;
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			panelTop.Controls.Add( une );

			return une;
		}
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor AddDateTimeBox( string name, int tabIndex, int x, int y )
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

			panelTop.Controls.Add( une );

			return une;
		}
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor AddCheckBox( string name, int tabIndex, int x, int y)																			
		{
			Infragistics.Win.UltraWinEditors.UltraCheckEditor une = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();

			une.Location = new System.Drawing.Point( x, y );
			une.Name = string.Format( "txt{0}", name );
			une.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			une.TabStop= true;
			une.TabIndex = tabIndex;
			une.Checked = true;			
			une.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			panelTop.Controls.Add( une );

			return une;
		}


		private int GetControlWidth()
		{
			return  panelTop.Size.Width - ( 175 );
			//return  panelTop.Width - ( 185 );
		}

		private mz.erp.ui.controls.mzComboSearchEditor AddSearchEdit( string name, int tabIndex, Type searchObject, int x, int y )
		{
			mz.erp.ui.controls.mzComboSearchEditor edt = new mz.erp.ui.controls.mzComboSearchEditor();

			edt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			edt.Location = new System.Drawing.Point( x, y );
			edt.Name = string.Format( "edt{0}", name );
			edt.SearchObject = searchObject;
			edt.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			edt.TabStop= true;
			edt.TabIndex = tabIndex;
			edt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			panelTop.Controls.Add( edt );

			return edt;
		}

		private Infragistics.Win.Misc.UltraLabel AddLabel( string name, string caption, int tabIndex, int x, int y )
		{
			Infragistics.Win.Misc.UltraLabel lbl = new Infragistics.Win.Misc.UltraLabel();
			Infragistics.Win.Appearance appearance = new Infragistics.Win.Appearance();

			appearance.TextVAlign = Infragistics.Win.VAlign.Middle;
			lbl.Appearance = appearance;
			lbl.BackColor = System.Drawing.SystemColors.Control;
			lbl.Location = new System.Drawing.Point( x, y );
			lbl.Name = string.Format( "lbl{0}", name );
			lbl.Text = caption;

			lbl.Size = new System.Drawing.Size( 150, 23 );
			lbl.TabIndex = tabIndex;

			panelTop.Controls.Add( lbl );

			return lbl;

		}

		private void DownloadParameters()
		{
			ArrayList paramsSorted = _parameters.Sort();
			for( int i = 0; i < paramsSorted.Count; i++ )
			{
				Parameter p = (Parameter)paramsSorted[ i ];

				Control ctrl = panelTop.Controls[ panelTop.Controls.GetChildIndex( p.InputControl ) ];

				if ( ctrl is Infragistics.Win.UltraWinEditors.UltraTextEditor )
				{
					string s = ( ( Infragistics.Win.UltraWinEditors.UltraTextEditor )ctrl ).Text;
					p.Value = ( s == string.Empty ) ? null : s;
				}
				else if ( ctrl is mz.erp.ui.controls.mzComboSearchEditor )
				{
					string s = ( string )( ( mz.erp.ui.controls.mzComboSearchEditor )ctrl ).DataValue;
					p.Value = ( s == string.Empty ) ? null : s;
				}
				else if ( ctrl is Infragistics.Win.UltraWinEditors.UltraNumericEditor )
				{
					if (((string)ctrl.Tag) == "System.Int64")
					{
						long n = Convert.ToInt64( ( ( Infragistics.Win.UltraWinEditors.UltraNumericEditor)ctrl).Value );
						p.Value = ( n == 0 ) ? long.MinValue : n;
					}
					else
					{
						decimal n = Convert.ToDecimal( ( ( Infragistics.Win.UltraWinEditors.UltraNumericEditor)ctrl).Value );
						p.Value = ( n == 0 ) ? -1: n;					
					}
				}
				else if ( ctrl is Infragistics.Win.UltraWinEditors.UltraDateTimeEditor )
				{
					DateTime n = Convert.ToDateTime( ( ( Infragistics.Win.UltraWinEditors.UltraDateTimeEditor)ctrl).Value );
					p.Value =  ( Convert.ToString(n).Equals("01/01/0001 12:00:00 a.m.")) ? DateTime.Parse("1/1/1753"): n;
					/*Debug.WriteLine(Convert.ToString(n));
					Debug.WriteLine(Convert.ToString(n).Equals("1/1/1"));
					Debug.WriteLine(p.Value);*/
				}
				else 
				{
					if (ctrl is Infragistics.Win.UltraWinEditors.UltraCheckEditor) 
					{
						Boolean b = (Boolean)((Infragistics.Win.UltraWinEditors.UltraCheckEditor) ctrl).Checked;
						p.Value = b;
					}
				}
				

			}
		}

		#region Código generado por el Diseñador de componentes
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mzSearchPanel));
			this.gridEx = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbSearchNow = new System.Windows.Forms.ToolBarButton();
			this.tbNewSearch = new System.Windows.Forms.ToolBarButton();
			this.tbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbSep = new System.Windows.Forms.ToolBarButton();
			this.tbNew = new System.Windows.Forms.ToolBarButton();
			this.tbEdit = new System.Windows.Forms.ToolBarButton();
			this.tbDetail = new System.Windows.Forms.ToolBarButton();
			this.panelTop = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).BeginInit();
			this.SuspendLayout();
			// 
			// gridEx
			// 
			this.gridEx.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridEx.ColumnAutoResize = true;
			this.gridEx.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEx.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEx.EmptyRows = true;
			this.gridEx.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEx.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridEx.GridLines = Janus.Windows.GridEX.GridLines.None;
			this.gridEx.GroupByBoxVisible = false;
			this.gridEx.GroupRowFormatStyle.BackColor = System.Drawing.Color.Empty;
			this.gridEx.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEx.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEx.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEx.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridEx.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
			this.gridEx.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEx.LayoutData = @"<GridEXLayoutData><RootTable><Caption>Customers</Caption><Columns Collection=""true""><Column0 ID=""Icon""><AllowGroup>False</AllowGroup><AllowSize>False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><HeaderImageIndex>1</HeaderImageIndex><ImageIndex>0</ImageIndex><Key>Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>22</Width></Column0><Column1 ID=""ID""><AllowSort>False</AllowSort><Caption>ID</Caption><DataMember>Codigo</DataMember><DefaultGroupPrefix>ID</DefaultGroupPrefix><Key>ID</Key><Position>1</Position><Selectable>False</Selectable><Width>252</Width></Column1><Column2 ID=""DESCRIPTION""><AllowSort>False</AllowSort><Caption>DESCRIPTION</Caption><DataMember>DESCRIPTION</DataMember><DefaultGroupPrefix>DESCRIPTION</DefaultGroupPrefix><Key>DESCRIPTION</Key><Position>2</Position><Selectable>False</Selectable><Width>442</Width></Column2></Columns><GroupCondition ID="""" /><Key>Customers</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridEx.Location = new System.Drawing.Point(8, 144);
			this.gridEx.Name = "gridEx";
			this.gridEx.RecordNavigator = true;
			this.gridEx.RecordNavigatorText = "Registro:|de";
			this.gridEx.Size = new System.Drawing.Size(720, 368);
			this.gridEx.TabIndex = 1800;
			this.gridEx.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
				| Janus.Windows.GridEX.ThemedArea.Headers) 
				| Janus.Windows.GridEX.ThemedArea.GroupByBox) 
				| Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
				| Janus.Windows.GridEX.ThemedArea.ControlBorder)));
			this.gridEx.Click += new System.EventHandler(this.gridEx_Click);
			this.gridEx.DoubleClick += new System.EventHandler(this.gridEx_DoubleClick);
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbSearchNow,
																							  this.tbNewSearch,
																							  this.tbRefresh,
																							  this.tbSep,
																							  this.tbNew,
																							  this.tbEdit,
																							  this.tbDetail});
			this.toolBarStandar.Divider = false;
			this.toolBarStandar.Dock = System.Windows.Forms.DockStyle.None;
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(736, 26);
			this.toolBarStandar.TabIndex = 0;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbSearchNow
			// 
			this.tbSearchNow.ImageIndex = 2;
			this.tbSearchNow.Text = "Buscar";
			// 
			// tbNewSearch
			// 
			this.tbNewSearch.ImageIndex = 1;
			this.tbNewSearch.Text = "Nueva búsqueda";
			// 
			// tbRefresh
			// 
			this.tbRefresh.ImageIndex = 0;
			this.tbRefresh.Text = "Actualizar";
			this.tbRefresh.Visible = false;
			// 
			// tbSep
			// 
			this.tbSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbNew
			// 
			this.tbNew.ImageIndex = 3;
			this.tbNew.Text = "Nuevo";
			// 
			// tbEdit
			// 
			this.tbEdit.ImageIndex = 4;
			this.tbEdit.Text = "Editar";
			// 
			// tbDetail
			// 
			this.tbDetail.ImageIndex = 5;
			this.tbDetail.Text = "Detalle";
			// 
			// panelTop
			// 
			this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panelTop.AutoScrollMargin = new System.Drawing.Size(5, 5);
			this.panelTop.BackColor = System.Drawing.SystemColors.Control;
			this.panelTop.Location = new System.Drawing.Point(8, 32);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(720, 104);
			this.panelTop.TabIndex = 10;
			this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
			// 
			// mzSearchPanel
			// 
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.gridEx);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "mzSearchPanel";
			this.Size = new System.Drawing.Size(736, 520);
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			DownloadParameters();
			
			object instance = Activator.CreateInstance( _searchObject, true );
			object resultValue = _searchMethod.Invoke( instance, _parameters.InvokeParameters );

			if ( resultValue != null && resultValue is DataSet )
			{
				DataSet data = ( DataSet )resultValue;
				DataTable table = data.Tables[ _dataSource ];
				gridEx.DataSource = table;
				//****************************************************
				//Mostrar solamente las columnas en las que se busca
				//****************************************************
				gridEx.RetrieveStructure();
			}
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					SearchNow();
					break;

				case 1:
					NewSearch();
					break;

				case 2:
					RefreshSearch();
					break;
				case 4:
					NewMember();
					break;
				case 5:
					EditMember();
					break;
				case 6:
					DetailMember();
					break;
			}
		}

		public void SearchNow()
		{
			DownloadParameters();
			
			object instance = Activator.CreateInstance( _searchObject, true );
			object resultValue = _searchMethod.Invoke( instance, _parameters.InvokeParameters );

			if ( resultValue != null && resultValue is DataSet )
			{
				DataSet data = ( DataSet )resultValue;
				DataTable table = data.Tables[ _dataSource ];
				tbEdit.Enabled = table.Rows.Count > 0;
				
				
				//gridEx.RetrieveStructure();

				if (_layoutMethod != null && (_layoutData == null ||_layoutData == string.Empty))
		{
					_layoutData = (string) _layoutMethod.Invoke( instance, null );
					
					if (_layoutData !=null)
					{
						gridEx.LayoutData = _layoutData;
					}
				}
				else
					gridEx.LayoutData = _layoutData;
				if(_orderBy != null)
				{
					DataView view = new DataView(table,null, _orderBy,System.Data.DataViewRowState.OriginalRows);
					gridEx.DataSource = view;
				}
				else
				{
					gridEx.DataSource = table;
				}

				if (_formato != null)
				{
					if (_formato.Visible) 
					{
						Janus.Windows.GridEX.ConditionOperator condOp = new Janus.Windows.GridEX.ConditionOperator();				
						switch (_formato.Condicion )
						{				
							case "<" :
								condOp = Janus.Windows.GridEX.ConditionOperator.LessThan;					
								break;
							default:
								condOp = Janus.Windows.GridEX.ConditionOperator.Equal;
								break;
						}			
						Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition( gridEx.RootTable.Columns[ _formato.Campo ], condOp, (object)_formato.Valor);
						cnd.FormatStyle.ForeColor = _formato.Color;
						gridEx.RootTable.FormatConditions.Add( cnd );
					}
				}
				if(table.Rows.Count == 0)
				{
					MessageBox.Show("NO se han encontrado datos con los filtros seleccionados","Advertencia",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);  
				}

			}
		}

		public void NewSearch()
		{
			this.BuildUI();
			this.gridEx.DataSource= null;
		}

		public void RefreshSearch()
		{
			SearchNow();
		}

		public void NewMember()
		{
			if (_editObject != null)
			{
				
				EventInfo ei = _editObject.GetEvent( "OnRowChanged" );

				object instance = Activator.CreateInstance( _editObject );
				
				Delegate del = Delegate.CreateDelegate( ei.EventHandlerType, this, "EventoRefrescar" );
				if(SearchObjectListener != null)
				{
					Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, SearchObjectListener, "processEventChange" );
					ei.AddEventHandler(instance, del1);
				}
				ei.AddEventHandler( instance, del );

				
				
				if(_showWithParameterValueMethod == null)
					_showMethod.Invoke( instance, new object[]{ null, Caption} );
				else 
					_showWithParameterValueMethod.Invoke(instance, new object []{null , _parameters, Caption});

				if(NewClick != null)
				{
					NewClick(this, new EventArgs());
				}
				
				
				
			}

		}

		private void EventoRefrescar( object sender, EventArgs args )
		{
			SearchNow();
			if(RefreshDataEvent != null)
				RefreshDataEvent(this , new EventArgs());
		}

		public void EditMember()
		{
			object instance = Activator.CreateInstance( _editObject );
			//hello
			//Se cuelga del metodo OnRowChanged para actualizar la busqueda con los datos modificados
			EventInfo ei = _editObject.GetEvent( "OnRowChanged" );
			Delegate del = Delegate.CreateDelegate( ei.EventHandlerType, this, "EventoRefrescar" );
			ei.AddEventHandler( instance, del );

			if(SearchObjectListener != null)
			{
				Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, SearchObjectListener, "processEventChange" );
				ei.AddEventHandler(instance, del1);
			}
			_showMethod.Invoke( instance, new object[]{ gridEx.SelectedItems[0].GetRow().Cells[0].Value, Caption} );
			if(EditClick != null)
			{
				EditClick(this, new EventArgs());
			}
		}
		
		public void DetailMember()
		{
			object instance = Activator.CreateInstance( _detailObject );
			if (gridEx.SelectedItems.Count > 0)
			{
				_detailMethod.Invoke( instance, new object[]{ gridEx.SelectedItems[0].GetRow().Cells[0].Value} );
			}
			
		}

		private void gridEx_DoubleClick(object sender, System.EventArgs e)
		{
			SearchEventArgs sea = new SearchEventArgs( SelectedValue );

			if ( RowDoubleClick != null )
			{
				RowDoubleClick( this, sea );
			}
		}

		private void gridEx_Click(object sender, System.EventArgs e)
		{
			
		}

		private void panelTop_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}


		public object SelectedDescription
		{
			get
			{
				if ( _parameters.Description == null )
				{
					throw new Exception( "No se ha definido ningún parámetro como 'Description'." );
				}

				object valor = null;
				try 
				{
					valor = gridEx.SelectedItems[ 0 ].GetRow().Cells[ _parameters.Description.Caption].Value;
					return valor;
				}
				catch 
				{					
					return null;
				}
			}


		}



		public object SelectedValue
		{
			get
			{
				if ( _parameters.AlternativePrimaryKey == null )
				{
					throw new Exception( "No se ha definido ningún parámetro como 'AlternativePrimaryKey'." );
				}

				object valor = null;
				try 
				{
					valor = gridEx.SelectedItems[ 0 ].GetRow().Cells[ _parameters.AlternativePrimaryKey.Name ].Value;
					return valor;
				}
				catch 
				{					
					return null;
				}
			}
		}





	}

	
}


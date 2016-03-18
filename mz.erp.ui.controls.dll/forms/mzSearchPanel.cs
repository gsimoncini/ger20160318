using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace mz.erp.ui.controls
{

	public class mzSearchPanel : System.Windows.Forms.UserControl
	{
		public delegate void SearchPanelEventHandler( object sender, SearchEventArgs e );
		public event SearchPanelEventHandler RowDoubleClick;

		private System.ComponentModel.IContainer components;
		internal Janus.Windows.GridEX.GridEX gridEx;
		private Parameters _parameters;
		private string _dataSource = string.Empty;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSearchNow;
		private System.Windows.Forms.ToolBarButton tbNewSearch;
		private System.Windows.Forms.Panel panelTop;
		private MethodBase _searchMethod;

		public mzSearchPanel()
		{
			InitializeComponent();
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
							_parameter.EditorType = SearchEditorType.Standar;
							_parameter.EditorObject = pi[ i ].ParameterType;

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

								if ( ap is SearchEditor )
								{
									SearchEditor se = ( SearchEditor )ap;
									_parameter.EditorType = se.EditorType;
									_parameter.EditorObject = se.EditorObject;
								}
							}
						}
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

			for( int i = 0; i < _parameters.Count; i++ )
			{
				Parameter p = _parameters[ i ];

				AddLabel( p.Name, p.Caption, tabIndex++, 5, y );

				if ( p.EditorType == SearchEditorType.Standar )
				{
					if ( p.EditorObject == typeof ( System.String ) )
					{
						p.InputControl = AddTextBox( p.Name, tabIndex++, 160, y );
					}
					else 
					{
						MessageBox.Show( string.Format( "No se ha implementado editor para el tipo '{0}'", p.EditorType.ToString() ) );
					}
				}
				else if ( p.EditorType == SearchEditorType.Search )
				{
					p.InputControl = AddSearchEdit( p.Name, tabIndex++, p.EditorObject, 160, y );
				}

				y += 24;
			}

			panelTop.ResumeLayout( false );
			ResumeLayout( false );
			panelTop.Refresh();
		}

		private Infragistics.Win.UltraWinEditors.UltraTextEditor AddTextBox( string name, int tabIndex, int x, int y )
		{
			Infragistics.Win.UltraWinEditors.UltraTextEditor txt = new Infragistics.Win.UltraWinEditors.UltraTextEditor();

			txt.Location = new System.Drawing.Point( x, y );
			txt.Name = string.Format( "txt{0}", name );
			txt.Size = new System.Drawing.Size( GetControlWidth(), 23 );
			txt.TabIndex = tabIndex;
			txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));

			panelTop.Controls.Add( txt );

			return txt;
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
			for( int i = 0; i < _parameters.Count; i++ )
			{
				Parameter p = _parameters[ i ];

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
			this.gridEx.EmptyRows = true;
			this.gridEx.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEx.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEx.GridLines = Janus.Windows.GridEX.GridLines.None;
			this.gridEx.GroupByBoxVisible = false;
			this.gridEx.GroupRowFormatStyle.BackColor = System.Drawing.Color.Empty;
			this.gridEx.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEx.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridEx.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
			this.gridEx.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEx.LayoutData = @"<GridEXLayoutData><RootTable><Caption>Customers</Caption><Columns Collection=""true""><Column0 ID=""Icon""><AllowGroup>False</AllowGroup><AllowSize>False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><HeaderImageIndex>1</HeaderImageIndex><ImageIndex>0</ImageIndex><Key>Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>22</Width></Column0><Column1 ID=""ID""><AllowSort>False</AllowSort><Caption>ID</Caption><DataMember>Codigo</DataMember><DefaultGroupPrefix>ID</DefaultGroupPrefix><Key>ID</Key><Position>1</Position><Selectable>False</Selectable><Width>177</Width></Column1><Column2 ID=""DESCRIPTION""><AllowSort>False</AllowSort><Caption>DESCRIPTION</Caption><DataMember>DESCRIPTION</DataMember><DefaultGroupPrefix>DESCRIPTION</DefaultGroupPrefix><Key>DESCRIPTION</Key><Position>2</Position><Selectable>False</Selectable><Width>517</Width></Column2></Columns><GroupCondition ID="""" /><Key>Customers</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>2</ColIndex><SortOrder>Descending</SortOrder></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridEx.Location = new System.Drawing.Point(8, 144);
			this.gridEx.Name = "gridEx";
			this.gridEx.RecordNavigator = true;
			this.gridEx.RecordNavigatorText = "Registro:|de";
			this.gridEx.Size = new System.Drawing.Size(720, 368);
			this.gridEx.TabIndex = 9;
			this.gridEx.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
				| Janus.Windows.GridEX.ThemedArea.Headers) 
				| Janus.Windows.GridEX.ThemedArea.GroupByBox) 
				| Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
				| Janus.Windows.GridEX.ThemedArea.ControlBorder)));
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
																							  this.tbRefresh});
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
			this.tbSearchNow.Text = "Buscar ahora";
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
			}
		}

		private void SearchNow()
		{
			DownloadParameters();
			
			object instance = Activator.CreateInstance( _searchObject, true );
			object resultValue = _searchMethod.Invoke( instance, _parameters.InvokeParameters );

			if ( resultValue != null && resultValue is DataSet )
			{
				DataSet data = ( DataSet )resultValue;
				DataTable table = data.Tables[ _dataSource ];
				gridEx.DataSource = table;
				gridEx.RetrieveStructure();
			}
		}

		private void NewSearch()
		{
			MessageBox.Show( "No implementado" );
		}

		private void RefreshSearch()
		{
			MessageBox.Show( "No implementado" );
		}

		private void gridEx_DoubleClick(object sender, System.EventArgs e)
		{
			SearchEventArgs sea = new SearchEventArgs( SelectedValue );

			if ( RowDoubleClick != null )
			{
				RowDoubleClick( this, sea );
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
				return gridEx.SelectedItems[ 0 ].GetRow().Cells[ _parameters.AlternativePrimaryKey.Name ].Value;
			}
		}
		
	}

	public class SearchEventArgs : EventArgs
	{
		public SearchEventArgs( object selectedValue )
		{
			SelectedValue = selectedValue;
		}

		private object _selectedValue;
		public object SelectedValue
		{
			get
			{
				return _selectedValue;
			}
			set
			{
				_selectedValue = value;
			}
		}

	}
}


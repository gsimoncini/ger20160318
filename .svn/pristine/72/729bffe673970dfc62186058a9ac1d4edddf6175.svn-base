using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using mz.erp.commontypes;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de mzHierarchichalSearchPanel.
	/// </summary>
	public class mzHierarchicalSearchPanel : System.Windows.Forms.UserControl
	{
		public delegate void SearchPanelEventHandler( object sender, SearchEventArgs e );
		public event SearchPanelEventHandler RowDoubleClick;
		public event EventHandler NewClick;
		public event EventHandler RefreshDataEvent;
		private System.ComponentModel.IContainer components;
		private Parameters _parameters;
		private string _dataSource = string.Empty;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSearchNow;
		private System.Windows.Forms.ToolBarButton tbNewSearch;
		private System.Windows.Forms.ToolBarButton tbNew;
		private System.Windows.Forms.ToolBarButton tbEdit;
		private System.Windows.Forms.ToolBarButton tbSep;
		private MethodBase _searchMethod;
		private MethodBase _showMethod;
		private MethodBase _layoutMethod;
		private System.Windows.Forms.ToolBarButton tbDetail;
		private MethodBase _detailMethod;
		private System.Windows.Forms.ImageList imglStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		internal Janus.Windows.GridEX.GridEX  gridResultado;
		private MethodBase _showWithParameterValueMethod;
		private MethodBase _searchTree;

		private Type _searchTreeMethodType;
		//Datos nrecesarios para el correcto funcionamiento del arbol
		private bool _expandir = true;
		private string _key = String.Empty;
		private string _descripcion = String.Empty;
		private bool _isLeaf = false;
		private string _getCaption = string.Empty;



		private ISearchObjectListener _searchObjectListener;
		public ISearchObjectListener SearchObjectListener
		{
			get{return _searchObjectListener;}
			set{_searchObjectListener = value;}
		}


		public string GetCaption
		{
			get{return _getCaption;}
		}
			

		


		private string _orderBy = null;

		public string OrderBy
		{
			set
			{
				_orderBy = value;
			}
		
		}


		private bool _fastSearch = false; 

		public bool FastSearch
		{
			set
			{
				_fastSearch = value;
			}
		}


		public mzHierarchicalSearchPanel()
		{
			InitializeComponent();			
			this.tbNew.Visible = false;
			this.tbEdit.Visible = false;
			this.tbDetail.Visible = false;
			this.ultraTree1.AfterExpand += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterExpand);
			this.ultraTree1.AfterActivate += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterActivate);
		}


		private void ultraTree1_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (_expandir) 
			{
				object instance = Activator.CreateInstance(  _searchTreeMethodType, true );
				object resultValue = _searchTree.Invoke( instance, new object[] {e.TreeNode} );
			}
		}

		private void ultraTree1_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			_key = e.TreeNode.Key;			
			_descripcion = e.TreeNode.Text;	
			_isLeaf = !e.TreeNode.HasNodes;
			
			
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

		private string _layoutData;
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
				if(value != null)
				{
					_searchObject = value;
					LoadParameters();
					BuildUI();
				}
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

		
		public System.Data.DataRow SelectedRow
		{
			get 
			{
				if (gridResultado.SelectedItems.Count > 0) 
				{
					return ((System.Data.DataRowView) gridResultado.SelectedItems[ 0 ].GetRow().DataRow).Row;
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


		private void SetupEditObject()
		{
			if ( _editObject == null ) return;

			tbEdit.Visible = true;
			tbNew.Visible = true;
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


			foreach( MethodBase mb in _searchObject.GetMethods() )
			{
				foreach( Attribute am in mb.GetCustomAttributes( false ) )
				{
					if ( am is HierarchicalSearchMember)
					{
						HierarchicalSearchMember sm = ( HierarchicalSearchMember )am;
						
						
						_searchMethod = mb;
						_searchTreeMethodType = sm.TreeByDemandType;
						foreach( MethodBase mb1 in _searchTreeMethodType.GetMethods() )
						{
							foreach( Attribute am1 in mb1.GetCustomAttributes( false ) )
							{
								if ( am1 is TreeByDemandAttribute)
								{
									_searchTree = mb1;
								}
							}
						}
					
					}
					if (am is atMethodLayoutData)
					{
						_layoutMethod = mb;
					}
					if ( am is SearchMember)
					{
						SearchMember sm = ( SearchMember )am;
						_dataSource = sm.DataSource;

						_getCaption = sm.Caption;

						if(!_fastSearch)
							_fastSearch= sm.FastSearch;

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


		

		#region Código generado por el Diseñador de componentes
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mzHierarchicalSearchPanel));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbSearchNow = new System.Windows.Forms.ToolBarButton();
			this.tbNewSearch = new System.Windows.Forms.ToolBarButton();
			this.tbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbSep = new System.Windows.Forms.ToolBarButton();
			this.tbNew = new System.Windows.Forms.ToolBarButton();
			this.tbEdit = new System.Windows.Forms.ToolBarButton();
			this.tbDetail = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraTree1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(687, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
			// 
			// ultraTree1
			// 
			this.ultraTree1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraTree1.HideSelection = false;
			this.ultraTree1.Location = new System.Drawing.Point(0, 0);
			this.ultraTree1.Name = "ultraTree1";
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Agrupamientos";
			this.ultraTree1.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																								 ultraTreeNode1});
			_override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.ultraTree1.Override = _override1;
			this.ultraTree1.Size = new System.Drawing.Size(687, 150);
			this.ultraTree1.TabIndex = 0;
			this.ultraTree1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ultraTree1_KeyDown);
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 258);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(687, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.ColumnAutoResize = true;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridResultado.EmptyRows = true;
			this.gridResultado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridResultado.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridResultado.GridLines = Janus.Windows.GridEX.GridLines.None;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.GroupRowFormatStyle.BackColor = System.Drawing.Color.Empty;
			this.gridResultado.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridResultado.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridResultado.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridResultado.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridResultado.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.LayoutData = @"<GridEXLayoutData><RootTable><Caption>Customers</Caption><Columns Collection=""true""><Column0 ID=""Icon""><AllowGroup>False</AllowGroup><AllowSize>False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><HeaderImageIndex>1</HeaderImageIndex><ImageIndex>0</ImageIndex><Key>Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>22</Width></Column0><Column1 ID=""ID""><AllowSort>False</AllowSort><Caption>ID</Caption><DataMember>Codigo</DataMember><DefaultGroupPrefix>ID</DefaultGroupPrefix><Key>ID</Key><Position>1</Position><Selectable>False</Selectable><Width>236</Width></Column1><Column2 ID=""DESCRIPTION""><AllowSort>False</AllowSort><Caption>DESCRIPTION</Caption><DataMember>DESCRIPTION</DataMember><DefaultGroupPrefix>DESCRIPTION</DefaultGroupPrefix><Key>DESCRIPTION</Key><Position>2</Position><Selectable>False</Selectable><Width>427</Width></Column2></Columns><GroupCondition ID="""" /><Key>Customers</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridResultado.Location = new System.Drawing.Point(0, 0);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.RecordNavigator = true;
			this.gridResultado.RecordNavigatorText = "Registro:|de";
			this.gridResultado.Size = new System.Drawing.Size(687, 150);
			this.gridResultado.TabIndex = 0;
			this.gridResultado.TableSpacing = 1;
			this.gridResultado.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
				| Janus.Windows.GridEX.ThemedArea.Headers) 
				| Janus.Windows.GridEX.ThemedArea.GroupByBox) 
				| Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
				| Janus.Windows.GridEX.ThemedArea.ControlBorder)));
			this.gridResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridResultado_KeyDown);
			this.gridResultado.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gridResultado_FormattingRow);
			// 
			// toolBarStandar
			// 
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
			this.tbNewSearch.ImageIndex = 0;
			this.tbNewSearch.Text = "Nueva búsqueda";
			// 
			// tbRefresh
			// 
			this.tbRefresh.ImageIndex = 0;
			this.tbRefresh.Text = "Actualizar";
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
			this.tbEdit.ImageIndex = 5;
			this.tbEdit.Text = "Editar";
			// 
			// tbDetail
			// 
			this.tbDetail.ImageIndex = 5;
			this.tbDetail.Text = "Detalle";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Seleccione una jerarquia";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Resultado de la Busqueda";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 26);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1";
			this.ultraExplorerBar1.Size = new System.Drawing.Size(736, 438);
			this.ultraExplorerBar1.TabIndex = 19;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// mzHierarchicalSearchPanel
			// 
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "mzHierarchicalSearchPanel";
			this.Size = new System.Drawing.Size(736, 464);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonSearch_Click(object sender, System.EventArgs e)
		{
			//DownloadParameters();
			
			object instance = Activator.CreateInstance( _searchObject, true );
			object resultValue = _searchMethod.Invoke( instance, _parameters.InvokeParameters );

			if ( resultValue != null && resultValue is DataSet )
			{
				DataSet data = ( DataSet )resultValue;
				DataTable table = data.Tables[ _dataSource ];
				gridResultado.DataSource = table;
				//****************************************************
				//Mostrar solamente las columnas en las que se busca
				//****************************************************
				gridResultado.RetrieveStructure();
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



		private void BuildUI()
		{
			ultraTree1.CollapseAll();
			if (_expandir) 
			{
				object instance = Activator.CreateInstance(  _searchTreeMethodType, true );
				object resultValue = _searchTree.Invoke( instance, new object[] {ultraTree1.Nodes[0]} );
			}
				
			_expandir = false;
			ultraTree1.Nodes[0].Expanded = true;
			_expandir = true;
			ultraTree1.Nodes[0].Selected = true;
			if(_fastSearch)
			{
				this.SearchNow();
				this.SelectGrid();
			}

		}

		public void SelectGrid()
		{
			if(this.gridResultado.RowCount > 0)
				this.gridResultado.Select();
		}

		public void SearchNow()
		{
			/*DownloadParameters();*/
			
		

			/*if ( resultValue != null && resultValue is DataSet )
			{
				DataSet data = ( DataSet )resultValue;
				DataTable table = data.Tables[ _dataSource ];
				tbEdit.Enabled = table.Rows.Count > 0;
			*/
			//if(_isLeaf)
			//{

			if(this.ultraTree1.SelectedNodes.Count >0)
			{
				Infragistics.Win.UltraWinTree.UltraTreeNode Nodo = this.ultraTree1.SelectedNodes[0];
				string _jerarquia = this.GetHierarchy(Nodo, String.Empty);
				object instance = Activator.CreateInstance( _searchObject, true );
				object resultValue = _searchMethod.Invoke( instance, new object[] {_jerarquia} );
				gridResultado.DataSource = null;
				gridResultado.DataSource = (DataTable)resultValue;
			
			
				
			
				
				//gridResultado.RetrieveStructure();
				if (_layoutMethod != null)
				{
					_layoutData = (string) _layoutMethod.Invoke( instance, null );
				}
				
				if (_layoutData !=null)
				{
					gridResultado.LayoutData = _layoutData;
				}
				/*
				if(_orderBy != null)
				{
					DataView view = new DataView(table,null, _orderBy,System.Data.DataViewRowState.OriginalRows);
					gridEx.DataSource = view;
				}
				else
				{
					gridEx.DataSource = table;
				}

				if(table.Rows.Count == 0)
				{
					MessageBox.Show("NO se han encontrado datos con los filtros seleccionados","Advertencia",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);  
				}
				*/

			//}
			}
			else MessageBox.Show("Debe seleccionar una jerarquia","Atencion",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
		}


		private string GetHierarchy(Infragistics.Win.UltraWinTree.UltraTreeNode Nodo, string aux)
		{
			if(Nodo.IsRootLevelNode)
				return aux;
			else
				return GetHierarchy(Nodo.Parent, Nodo.Key + aux);

		}

		public void NewSearch()
		{
			this.ultraTree1.CollapseAll();
			this.gridResultado.DataSource= null;
		}

		public void RefreshSearch()
		{
			SearchNow();
		}

		public void NewMember()
		{
			if (_editObject != null)
			{
				object instance = Activator.CreateInstance( _editObject );
				if(_showWithParameterValueMethod == null)
					_showMethod.Invoke( instance, new object[]{ null, Caption} );
				else 
					_showWithParameterValueMethod.Invoke(instance, new object []{null , _parameters, Caption});

				if(NewClick != null)
				{
					NewClick(this, new EventArgs());
				}
				EventInfo ei = _editObject.GetEvent( "OnRowChanged" );

				Delegate del = Delegate.CreateDelegate( ei.EventHandlerType, this, "EventoRefrescar" );

				ei.AddEventHandler( instance, del );
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
			_showMethod.Invoke( instance, new object[]{ gridResultado.SelectedItems[0].GetRow().Cells[0].Value, Caption} );
		}
		
		public void DetailMember()
		{
			object instance = Activator.CreateInstance( _detailObject );
			if (gridResultado.SelectedItems.Count > 0)
			{
				_detailMethod.Invoke( instance, new object[]{ gridResultado.SelectedItems[0].GetRow().Cells[0].Value} );
			}
			
		}

		private void gridResultado_DoubleClick(object sender, System.EventArgs e)
		{
			SearchEventArgs sea = new SearchEventArgs( SelectedValue );

			if ( RowDoubleClick != null )
			{
				RowDoubleClick( this, sea );
			}
		}

		private void ultraTree1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.F2:
				{
					SearchNow();
					break;
				}
				case System.Windows.Forms.Keys.PageDown:
				{	
					
					this.gridResultado.Focus();
					
					break;
				}
				case System.Windows.Forms.Keys.Space :
				{
					
					ultraTree1.SelectedNodes[0].Expanded = true;
					
					break;

				}
			}
			
		}



		private void gridResultado_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case System.Windows.Forms.Keys.Enter:
				{
					SearchEventArgs sea = new SearchEventArgs( SelectedValue );

					if ( RowDoubleClick != null )
					{
						RowDoubleClick( this, sea );
					}
					break;
				}
				
			}
		
		}

		private void gridResultado_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
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
					valor = gridResultado.SelectedItems[ 0 ].GetRow().Cells[ _parameters.AlternativePrimaryKey.Name ].Value;
					return valor;
				}
				catch 
				{					
					return null;
				}
			}
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
					valor = gridResultado.SelectedItems[ 0 ].GetRow().Cells[ _parameters.Description.Caption].Value;
					return valor;
				}
				catch 
				{					
					return null;
				}
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

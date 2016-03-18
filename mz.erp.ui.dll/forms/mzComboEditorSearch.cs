using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de mzComboEditorSearch.
	/// </summary>
	public class mzComboEditorSearch : System.Windows.Forms.Form
	{
		internal Janus.Windows.GridEX.GridEX gridEx;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.ComponentModel.IContainer components;

		public mzComboEditorSearch()
		{
			InitializeComponent();
			
		}
		//Comentario
 		public mzComboEditorSearch( string displayMember, string displayMemberCaption, string valueMember, string valueMemberCaption, DataTable dataSource )
		{
			InitializeComponent();
			DisplayMember = displayMember;
			DisplayMemberCaption = displayMemberCaption;
			ValueMember = valueMember;
			ValueMemberCaption = valueMemberCaption;
			DataSource = dataSource;
			gridEx.RootTable.Columns["ID"].Caption = valueMember; 
			gridEx.RootTable.Columns["DESCRIPTION"].Caption = displayMember;
			this.Text = "Seleccione un Item";
		}

		public object SelectedValue()
		{
			return gridEx.SelectedItems[ 0 ].GetRow().Cells[ "ID" ].Value;
		}
		
		public string SelectedText()
		{
			return gridEx.SelectedItems[ 0 ].GetRow().Cells[ "DESCRIPTION" ].Value.ToString();
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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mzComboEditorSearch));
			this.gridEx = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).BeginInit();
			this.SuspendLayout();
			// 
			// gridEx
			// 
			this.gridEx.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEx.ColumnAutoResize = true;
			this.gridEx.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEx.EmptyRows = true;
			this.gridEx.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEx.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEx.GridLines = Janus.Windows.GridEX.GridLines.None;
			this.gridEx.GroupByBoxVisible = false;
			this.gridEx.GroupRowFormatStyle.BackColor = System.Drawing.Color.Empty;
			this.gridEx.GroupRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEx.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
			this.gridEx.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEx.LayoutData = @"<GridEXLayoutData><RootTable><Caption>Customers</Caption><Columns Collection=""true""><Column0 ID=""Icon""><AllowGroup>False</AllowGroup><AllowSize>False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><HeaderImageIndex>1</HeaderImageIndex><ImageIndex>0</ImageIndex><Key>Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>22</Width></Column0><Column1 ID=""ID""><AllowSort>False</AllowSort><Caption>ID</Caption><DataMember>ID</DataMember><DefaultGroupPrefix>ID</DefaultGroupPrefix><Key>ID</Key><Position>1</Position><Selectable>False</Selectable><Width>109</Width></Column1><Column2 ID=""DESCRIPTION""><AllowSort>False</AllowSort><Caption>DESCRIPTION</Caption><DataMember>DESCRIPTION</DataMember><DefaultGroupPrefix>DESCRIPTION</DefaultGroupPrefix><Key>DESCRIPTION</Key><Position>2</Position><Selectable>False</Selectable><Width>313</Width></Column2></Columns><GroupCondition ID="""" /><Key>Customers</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>2</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridEx.Location = new System.Drawing.Point(2, 33);
			this.gridEx.Name = "gridEx";
			this.gridEx.Size = new System.Drawing.Size(448, 304);
			this.gridEx.TabIndex = 8;
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
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.toolBarButton10,
																							  this.toolBarButton11,
																							  this.toolBarButton1});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(456, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 6;
			this.toolBarButton10.Text = "Aceptar";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 7;
			this.toolBarButton1.Text = "Cancelar";
			// 
			// mzComboEditorSearch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(456, 341);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.gridEx);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "mzComboEditorSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Búsqueda";
			this.Load += new System.EventHandler(this.mzComboEditorSearch_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridEx)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void mzComboEditorSearch_Load(object sender, System.EventArgs e)
		{
			
		
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			if ( gridEx.Row < 0 )
			{
				MessageBox.Show( "Debe seleccionar una fila!", "Mz ERP" );
				return;
			}
			else
			{
				DialogResult = DialogResult.OK;
			}
		}

		private void gridEx_DoubleClick(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
						this.buttonOK_Click(sender, new EventArgs());
					break;
				case 2:
					DialogResult = DialogResult.Cancel;
					break;

			}		
		}


		public DataTable DataSource
		{
			get
			{
				return ( DataTable )gridEx.DataSource;
			}
			set
			{
				gridEx.DataSource = value;
			}
		}
		public string DisplayMember
		{
			get
			{
				return gridEx.RootTable.Columns[ "DESCRIPTION" ].DataMember;
			}
			set
			{
				gridEx.RootTable.Columns[ "DESCRIPTION" ].DataMember = value;
			}
		}

		public string ValueMember
		{
			get
			{
				return gridEx.RootTable.Columns[ "ID" ].DataMember;
			}
			set
			{
				gridEx.RootTable.Columns[ "ID" ].DataMember = value;
			}
		}


		public string DisplayMemberCaption
		{
			get
			{
				return gridEx.RootTable.Columns[ "DESCRIPTION" ].Caption;
			}
			set
			{
				gridEx.RootTable.Columns[ "DESCRIPTION" ].Caption = value;
			}
		}

		public string ValueMemberCaption
		{
			get
			{
				return gridEx.RootTable.Columns[ "ID" ].Caption;
			}
			set
			{
				gridEx.RootTable.Columns[ "ID" ].Caption = value;
			}
		}


	}
}

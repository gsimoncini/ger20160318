using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmSearchProductbyJerarquia.
	/// </summary>
	public class FrmSearchProductbyJerarquia : System.Windows.Forms.Form
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
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		internal Janus.Windows.GridEX.GridEX gridResultado;
		private System.ComponentModel.IContainer components;

		private bool _expandir = true;
		private string _key = String.Empty;
		private string _descripcion = String.Empty;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.CheckBox checkBox1;

		private bool _isLeaf = false;
		

		public FrmSearchProductbyJerarquia()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			Init();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSearchProductbyJerarquia));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
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
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraTree1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 131);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(718, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
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
			this.ultraTree1.Size = new System.Drawing.Size(718, 150);
			this.ultraTree1.TabIndex = 2;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 340);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(718, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.ColumnAutoResize = true;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.gridResultado.LayoutData = @"<GridEXLayoutData><RootTable><Caption>Customers</Caption><Columns Collection=""true""><Column0 ID=""Icon""><AllowGroup>False</AllowGroup><AllowSize>False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ColumnType>Image</ColumnType><EditType>NoEdit</EditType><HeaderImageIndex>1</HeaderImageIndex><ImageIndex>0</ImageIndex><Key>Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>22</Width></Column0><Column1 ID=""ID""><AllowSort>False</AllowSort><Caption>ID</Caption><DataMember>Codigo</DataMember><DefaultGroupPrefix>ID</DefaultGroupPrefix><Key>ID</Key><Position>1</Position><Selectable>False</Selectable><Width>247</Width></Column1><Column2 ID=""DESCRIPTION""><AllowSort>False</AllowSort><Caption>DESCRIPTION</Caption><DataMember>DESCRIPTION</DataMember><DefaultGroupPrefix>DESCRIPTION</DefaultGroupPrefix><Key>DESCRIPTION</Key><Position>2</Position><Selectable>False</Selectable><Width>445</Width></Column2></Columns><GroupCondition ID="""" /><Key>Customers</Key><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>1</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>";
			this.gridResultado.Location = new System.Drawing.Point(0, 0);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.RecordNavigator = true;
			this.gridResultado.RecordNavigatorText = "Registro:|de";
			this.gridResultado.Size = new System.Drawing.Size(718, 150);
			this.gridResultado.TabIndex = 1801;
			this.gridResultado.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
				| Janus.Windows.GridEX.ThemedArea.Headers) 
				| Janus.Windows.GridEX.ThemedArea.GroupByBox) 
				| Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
				| Janus.Windows.GridEX.ThemedArea.ControlBorder)));
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
																							  this.toolBarButton9,
																							  this.toolBarButton10,
																							  this.toolBarButton11,
																							  this.toolBarButton12});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(784, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			this.toolBarButton6.Text = "Buscar Ahora";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 5;
			this.toolBarButton8.Text = "Nueva Busqueda";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
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
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 7;
			this.toolBarButton12.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 23;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Filtros";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Seleccione una jerarquia";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado de la Busqueda";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(784, 377);
			this.ultraExplorerBar1.TabIndex = 18;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.checkBox1);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(718, 23);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(8, 0);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(176, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Activo";
			// 
			// FrmSearchProductbyJerarquia
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(784, 405);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmSearchProductbyJerarquia";
			this.Text = "Busqueda de Productos por Jerarquia";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void Init()
		{
			ultraTree1.CollapseAll();
			mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(ultraTree1.Nodes[0]);			
			_expandir = false;
			ultraTree1.Nodes[0].Expanded = true;
			_expandir = true;
			toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);			
			gridResultado.LayoutData = new mz.erp.ui.forms.classes.tsh_Productos().GetLayout();
			this.ultraTree1.AfterExpand += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterExpand);
			this.ultraTree1.AfterActivate += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterActivate);
		}


		private void ultraTree1_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (_expandir) {mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(e.TreeNode);}
		}

		private void ultraTree1_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			_key = e.TreeNode.Key;			
			_descripcion = e.TreeNode.Text;	
			_isLeaf = !e.TreeNode.HasNodes;
			
			
		}

		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					gridResultado.MoveFirst();
					break;
				case 1:
					gridResultado.MovePrevious();
					break;
				case 2:
					gridResultado.MoveNext();
					break;
				case 3:
					gridResultado.MoveLast();
					break;
				case 4:
					break;
				case 5://Buscar Ahora
					//BuscarAhora();
					break;
				case 7:
					NuevaBusqueda();
					break;
				case 11:
					CloseForm();
					break;
				default:
					break;
					
				
			}		
		}

		private void NuevaBusqueda()
		{	
			
			
			ultraTree1.CollapseAll();
			gridResultado.DataSource = null;
			

		}

		private void BuscarAhora()
		{

			if(_isLeaf)
			{
				tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow rowJ = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_key);
				string jerarquia = rowJ.Jerarquia;
				//System.Data.DataTable tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(jerarquia, Security.IdSucursal, Security.IdEmpresa, this.activo);
				System.Data.DataTable tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(jerarquia, Security.IdSucursal, Security.IdEmpresa);
				gridResultado.DataSource = tabla;
				
			}
		}

		public void CloseForm()
		{		
			bool _preguntarAlCancelar = Variables.GetValueBool("SearchProductByJerarquia.PreguntarAlCancelar",false);
			if (_preguntarAlCancelar)
			{
				if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
					Close();
			}
			else
			{
				Close();
			}
		}

	}



}

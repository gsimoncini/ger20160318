using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using mz.erp.ui.controls;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmJerarquiaAgrupVariables.
	/// </summary>
	public class FrmJerarquiaAgrupVariables : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbSearchNow;
		private System.Windows.Forms.ToolBarButton tbNewSearch;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSep;
		private System.Windows.Forms.ToolBarButton tbNew;
		private System.Windows.Forms.ToolBarButton tbEdit;
		private System.Windows.Forms.ImageList imglStandar;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
		private System.ComponentModel.IContainer components;

		public FrmJerarquiaAgrupVariables()
		{
			InitializeComponent();
			_key = ultraTree1.Nodes[0].Key;	
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmJerarquiaAgrupVariables));
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbSearchNow = new System.Windows.Forms.ToolBarButton();
			this.tbNewSearch = new System.Windows.Forms.ToolBarButton();
			this.tbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbSep = new System.Windows.Forms.ToolBarButton();
			this.tbNew = new System.Windows.Forms.ToolBarButton();
			this.tbEdit = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
			this.SuspendLayout();
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
												this.tbEdit});
			this.toolBarStandar.Divider = false;
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(704, 26);
			this.toolBarStandar.TabIndex = 14;
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
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraTree1
			// 
			this.ultraTree1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraTree1.HideSelection = false;
			this.ultraTree1.Location = new System.Drawing.Point(0, 26);
			this.ultraTree1.Name = "ultraTree1";
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Agrupamientos";
			this.ultraTree1.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																								 ultraTreeNode1});
			_override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.ultraTree1.Override = _override1;
			this.ultraTree1.Size = new System.Drawing.Size(704, 419);
			this.ultraTree1.TabIndex = 19;
			this.ultraTree1.AfterExpand += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterExpand);
			this.ultraTree1.AfterActivate += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterActivate);
			// 
			// FrmJerarquiaAgrupVariables
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 486);
			this.Controls.Add(this.ultraTree1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmJerarquiaAgrupVariables";
			this.Text = "FrmJerarquiaAgrupVariables";
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
			this.ResumeLayout(false);
						
		}
		#endregion
	
	

		private string _key = String.Empty;		
		private string _descripcion = String.Empty;		
		private bool _expandir = true;

		private void ultraTree1_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{			
			if (_expandir) 
			{
				sy_JerarquiaAgrupVariables.HijosYNietos(e.TreeNode);
			}
		}

		private void ultraTree1_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			_key = e.TreeNode.Key;			
			_descripcion = e.TreeNode.Text;		
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
					//NewMember(_key, _descripcion);					
					break;
				case 5:					
					//EditMember(_key, _descripcion);
					break;
			}
		}

		/// <summary>
		/// Abre el árbol y realiza la búsqueda de los hijos y nietos del raiz. Los nietos se buscan para poder visualizar el signo (+) en los hijos.
		/// </summary>
		private void SearchNow()
		{
			ultraTree1.CollapseAll();
			sy_JerarquiaAgrupVariables.HijosYNietos(ultraTree1.Nodes[0]);
			_expandir = false;
			ultraTree1.Nodes[0].Expanded = true;
			_expandir = true; //porque al expandir el árbol va al evento AfterExpand y entre nuevamente a HijoYNietos
		}

		private void NewSearch()
		{
			MessageBox.Show( "No implementado" );
		}

		private void RefreshSearch()
		{	
			/// <summary>
			/// Actualiza la rama del árbol a partir del padre del nodo seleccionado.
			/// </summary>
			Infragistics.Win.UltraWinTree.UltraTreeNode Nodo;
			if (ultraTree1.GetNodeByKey(_key).IsRootLevelNode)
			{Nodo = ultraTree1.GetNodeByKey(_key);}						
			else 
			{Nodo = ultraTree1.GetNodeByKey(_key).Parent;}			
			
			sy_JerarquiaAgrupVariables.HijosYNietos(Nodo);					
		}

		/*
		temporalmente comentado, falta hacer un par de clases
		private void NewMember(string Key, string Descripcion)
		{					
			/// <summary>
			/// Alta de jerarquía de variables. Se abre el formulario de edición.
			/// </summary>
			string Caption = "Agrupamientos";						
			FrmAbmJerarquiaAgrupVariables form = new FrmAbmJerarquiaAgrupVariables();
			form.ShowForm(null, Key, 'A', Caption + '-' + Descripcion);						
			form.OnRowChanged+= new FrmAMB.RowChanged(this.RefreshEvent);
		}*/

		/// <summary>
		/// Modificación de jerarquía de Variables. Se abre el formulario de edición para poder modificar el nombre o borrar el nodo seleccionado.
		/// </summary>

		/*temporalmente comentado, faltan hacer un par de clases
		private void EditMember(string Key, string Descripcion)
		{				

			if (Key != ultraTree1.Nodes[0].Key)
			{
				string KeyP = ultraTree1.GetNodeByKey(Key).Parent.Key;
				string Caption = "Agrupamientos";		
				FrmAbmJerarquiaAgrupVariables form = new FrmAbmJerarquiaAgrupVariables();
				form.ShowForm(Key, KeyP, 'A', Caption + '-' + Descripcion);
				form.OnRowChanged+= new FrmAMB.RowChanged(this.RefreshEvent);
			}
		}
		*/
		private void RefreshEvent(object sender, System.EventArgs e) 
		{
			this.RefreshSearch();
		}

		private void FrmJerarquiaAgrupVariables_Load(object sender, System.EventArgs e)
		{
		
		}

		private void ultraExplorerBarContainerControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

	}
}

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
	/// Descripción breve de FrmJerarquiaAgrupProd.
	/// </summary>
	public class FrmJerarquiaAgrupProd : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbSearchNow;
		private System.Windows.Forms.ToolBarButton tbNewSearch;
		private System.Windows.Forms.ToolBarButton tbRefresh;
		private System.Windows.Forms.ToolBarButton tbSep;
		private System.Windows.Forms.ToolBarButton tbNew;
		private System.Windows.Forms.ToolBarButton tbEdit;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
		private System.ComponentModel.IContainer components;

		public FrmJerarquiaAgrupProd()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_key = ultraTree1.Nodes[0].Key;			

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmJerarquiaAgrupProd));
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbSearchNow = new System.Windows.Forms.ToolBarButton();
			this.tbNewSearch = new System.Windows.Forms.ToolBarButton();
			this.tbRefresh = new System.Windows.Forms.ToolBarButton();
			this.tbSep = new System.Windows.Forms.ToolBarButton();
			this.tbNew = new System.Windows.Forms.ToolBarButton();
			this.tbEdit = new System.Windows.Forms.ToolBarButton();
			this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
			this.SuspendLayout();
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
			// FrmJerarquiaAgrupProd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 445);
			this.Controls.Add(this.ultraTree1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmJerarquiaAgrupProd";
			this.Text = "FrmJerarquiaAgrupProd";
			this.Load += new System.EventHandler(this.FrmJerarquiaAgrupProd_Load);
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private string _key = String.Empty;		
		private string _descripcion = String.Empty;		
		private bool _expandir = true;

		private void btnGetList_Click(object sender, System.EventArgs e)
		{
		}

		private void btnAbrir_Click(object sender, System.EventArgs e)
		{				
		}

		private void ultraTree1_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{			
			if (_expandir) {tsh_JerarquiaAgrupProd.HijosYNietos(e.TreeNode);}
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
					NewMember(_key, _descripcion);					
					break;
				case 5:					
					EditMember(_key, _descripcion);
					break;
			}
		}

		private void SearchNow()
		{
			/// <summary>
			/// Abre el árbol y realiza la búsqueda de los hijos y nietos del raiz. Los nietos se buscan para poder visualizar el signo (+) en los hijos.
			/// </summary>
			ultraTree1.CollapseAll();
			tsh_JerarquiaAgrupProd.HijosYNietos(ultraTree1.Nodes[0], false, false);
			
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
			
			tsh_JerarquiaAgrupProd.HijosYNietos(Nodo);					
		}

		private void NewMember(string Key, string Descripcion)
		{					
			/// <summary>
			/// Alta de jerarquía de productos. Se abre el formulario de edición.
			/// </summary>
			string Caption = "Agrupamientos";						
			FrmAbmJerarquiaAgrupProd form = new FrmAbmJerarquiaAgrupProd();
			form.ShowForm(null, Key, 'A', Caption + '-' + Descripcion);						
			form.OnRowChanged+= new FrmAMB.RowChanged(this.RefreshEvent);
		}

		private void EditMember(string Key, string Descripcion)
		{				
			/// <summary>
			/// Modificación de jerarquía de productos. Se abre el formulario de edición para poder modificar el nombre o borrar el nodo seleccionado.
			/// </summary>

			if (Key != ultraTree1.Nodes[0].Key)
			{
				string KeyP = ultraTree1.GetNodeByKey(Key).Parent.Key;
				string Caption = "Agrupamientos";		
				FrmAbmJerarquiaAgrupProd form = new FrmAbmJerarquiaAgrupProd();
				form.ShowForm(Key, KeyP, 'A', Caption + '-' + Descripcion);
				form.OnRowChanged+= new FrmAMB.RowChanged(this.RefreshEvent);
			}
		}

		private void RefreshEvent(object sender, System.EventArgs e) 
		{
			this.RefreshSearch();
		}

		private void FrmJerarquiaAgrupProd_Load(object sender, System.EventArgs e)
		{
		
		}

		private void ultraExplorerBarContainerControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		/*private static void BorraHijos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{											
			int hijos = NodoPadre.GetNodeCount(false);			
			for (int i=0; i < hijos; i++) {NodoPadre.Nodes[0].Remove();}
		}*/

		/*private static void HijosYNietos(Infragistics.Win.UltraWinTree.UltraTreeNode NodoPadre)
		{			
			if (NodoPadre.HasNodes)
			{
				BorraHijos(NodoPadre);
			}			
				
			Infragistics.Win.UltraWinTree.UltraTreeNode NodoHijo;
			string descripcionH = String.Empty;
			string claveH = String.Empty;
			string descripcionN = String.Empty;
			string claveN = String.Empty;

			System.Data.DataTable data;

			if (NodoPadre.Key == "RAIZ") 
			{data = mz.erp.ui.tsh_JerarquiaAgrupProd.GetList('A');}
			else
			{data = mz.erp.ui.tsh_JerarquiaAgrupProd.GetList(NodoPadre.Key);}
			
			
			foreach (System.Data.DataRow rowH in data.Rows) 
			{
				descripcionH = rowH["Descripcion"].ToString();
				claveH = rowH["IdNomenclatura"].ToString();
				NodoPadre.Nodes.Add(claveH, descripcionH);
				
				System.Data.DataTable dataH = mz.erp.ui.tsh_JerarquiaAgrupProd.GetList(claveH);
				foreach (System.Data.DataRow rowN in dataH.Rows) 
				{
					descripcionN = rowN["Descripcion"].ToString();
					claveN = rowN["IdNomenclatura"].ToString();
					NodoHijo = NodoPadre.Nodes[claveH];
					NodoHijo.Nodes.Add(claveN, descripcionN);
				}
			}			
		}*/
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAgrupProductos.
	/// </summary>
	public class FrmAgrupProductos : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTree1;
		private Infragistics.Win.Misc.UltraButton btnBuscar;
		private Janus.Windows.GridEX.GridEX gridEXAgrupamientos;
		private Infragistics.Win.Misc.UltraButton btnAgregar;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl1;		
		private Janus.Windows.GridEX.GridEX gridProductos;					

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzProductosControl1 = new mz.erp.ui.controls.mzProductosControl();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.btnAgregar = new Infragistics.Win.Misc.UltraButton();
			this.gridEXAgrupamientos = new Janus.Windows.GridEX.GridEX();
			this.btnBuscar = new Infragistics.Win.Misc.UltraButton();
			this.ultraTree1 = new Infragistics.Win.UltraWinTree.UltraTree();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEXAgrupamientos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzProductosControl1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -22);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(862, 63);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// mzProductosControl1
			// 
			this.mzProductosControl1.BackColor = System.Drawing.Color.Transparent;
			this.mzProductosControl1.EnabledCantidad = true;
			this.mzProductosControl1.EnabledListaDePrecio = true;
			this.mzProductosControl1.Location = new System.Drawing.Point(95, -8);
			this.mzProductosControl1.Name = "mzProductosControl1";
			this.mzProductosControl1.Size = new System.Drawing.Size(672, 80);
			this.mzProductosControl1.TabIndex = 0;
			this.mzProductosControl1.VisibleCantidad = true;
			this.mzProductosControl1.VisibleComboListaDePrecios = true;
			this.mzProductosControl1.VisibleComboTipoDePrecioDeCosto = false;
			this.mzProductosControl1.VisiblePrecios = true;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 23;
			this.label1.Text = "Producto";
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridProductos);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, -15);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(862, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// gridProductos
			// 
			this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridProductos.AlternatingColors = true;
			this.gridProductos.AutomaticSort = false;
			this.gridProductos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridProductos.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridProductos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridProductos.GroupByBoxVisible = false;
			this.gridProductos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridProductos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridProductos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridProductos.Location = new System.Drawing.Point(0, 0);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.RecordNavigatorText = "Registro:|de";
			this.gridProductos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridProductos.ShowEmptyFields = false;
			this.gridProductos.Size = new System.Drawing.Size(862, 150);
			this.gridProductos.TabIndex = 0;
			this.gridProductos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnAgregar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEXAgrupamientos);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.btnBuscar);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraTree1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 194);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(862, 461);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(408, 66);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(408, 34);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(80, 24);
			this.btnAgregar.TabIndex = 2;
			this.btnAgregar.Text = "&Agregar";
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// gridEXAgrupamientos
			// 
			this.gridEXAgrupamientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEXAgrupamientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridEXAgrupamientos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEXAgrupamientos.GroupByBoxInfoText = "";
			this.gridEXAgrupamientos.GroupByBoxVisible = false;
			this.gridEXAgrupamientos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEXAgrupamientos.Location = new System.Drawing.Point(499, 0);
			this.gridEXAgrupamientos.Name = "gridEXAgrupamientos";
			this.gridEXAgrupamientos.Size = new System.Drawing.Size(356, 456);
			this.gridEXAgrupamientos.TabIndex = 4;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(408, 2);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(80, 24);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "&Buscar";
			// 
			// ultraTree1
			// 
			this.ultraTree1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.ultraTree1.HideSelection = false;
			this.ultraTree1.Location = new System.Drawing.Point(0, 0);
			this.ultraTree1.Name = "ultraTree1";
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Agrupamientos";
			this.ultraTree1.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																								 ultraTreeNode1});
			_override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.ultraTree1.Override = _override1;
			this.ultraTree1.Size = new System.Drawing.Size(400, 456);
			this.ultraTree1.TabIndex = 0;
			this.ultraTree1.AfterExpand += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterExpand);
			this.ultraTree1.AfterActivate += new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(this.ultraTree1_AfterActivate);
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 63;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Detalle de productos";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.ContainerHeight = 461;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Detalle de Agrupamiento";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(928, 645);
			this.ultraExplorerBar1.TabIndex = 23;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmAgrupProductos
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(928, 645);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Name = "FrmAgrupProductos";
			this.Text = "Agrupamiento de productos";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEXAgrupamientos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraTree1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private bool _expandir = true;
		private string _idProducto = String.Empty;		
		private string _key = String.Empty;		
		private string _descripcion = String.Empty;
		private AgrupProductosController _uiController = new AgrupProductosController();

		#region Constructores y Destructores
		public FrmAgrupProductos()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();		
			Build_UI();
			
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
		#region Inicializadores y Carga
		

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}
		
		private void ConfigureInterface()
		{								
			mzProductosControl1.VisiblePrecios = false;			

			ultraTree1.CollapseAll();
            //German 20120412 - Tarea 0000271
			//mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(ultraTree1.Nodes[0], false, true);
            mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietosFiltrandoCampoAuxiliar6(ultraTree1.Nodes[0], false, true);
            //Fin German 20120412 - Tarea 0000271
			_expandir = false;
			ultraTree1.Nodes[0].Expanded = true;
			_expandir = true; //porque al expandir el árbol va al evento AfterExpand y entre nuevamente a HijoYNietos

			gridEXAgrupamientos.LayoutData = _uiController.GetLayoutAgrupProductos();
			gridProductos.LayoutData = _uiController.GetLayoutProductos();

			this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			mzProductosControl1.EnabledListaDePrecio = false;
		}

		private void InitializeData()
		{
		}
		private void InitEventHandlers()
		{
			_uiController.OnModelChanged+=new EventHandler(_uiController_OnModelChanged);
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
		}	
	
		private void InitDataBindings()
		{			
			this.mzProductosControl1.AddObjectListener( (IObserver)_uiController );
			this.gridProductos.SetDataBinding( null, null );
			this.gridProductos.SetDataBinding(_uiController.Items, null);
			this.gridProductos.Refresh();
			this.gridProductos.Refetch();
		}



		private void _uiController_OnModelChanged(object sender, EventArgs e)
		{
			this.gridProductos.SetDataBinding( null, null );
			this.gridProductos.SetDataBinding(_uiController.Items, null);
		}

		#endregion


		private void Actualizar() 
		{
			/// <summary>
			/// Muestra en pantalla el producto seleccionado.
			/// </summary>
			if (gridProductos.RowCount > 0)
			{
				_idProducto = Convert.ToString(gridProductos.SelectedItems[0].GetRow().Cells["IdProducto"].Value);
				tsh_AgrupProductos ap = new tsh_AgrupProductos();
				gridEXAgrupamientos.DataSource = ap.GetList( _idProducto );	
			}		
		}

		private void Evaluate()
		{
			if (_uiController.Row!=null && _uiController.Row.HasErrors)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(_uiController.Row);
				_form.Show();
			}
		}

		private void ultraTree1_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (_expandir) 
			{
				mz.erp.ui.forms.classes.tsh_JerarquiaAgrupProd.HijosYNietos(e.TreeNode, false, true);
			}
		}

		private void ultraTree1_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			_key = e.TreeNode.Key;
			_descripcion = e.TreeNode.Text;	
		}

		private void btnBuscar_Click(object sender, System.EventArgs e)
		{				
			Actualizar();
		}

		private void btnAgregar_Click(object sender, System.EventArgs e)
		{
			/// <summary>
			/// Busca la clave que posee la jerarquia seleccionada y junto con el idProducto graba un nuevo registro en la tabla de relación
			/// </summary>
			tsh_JerarquiaAgrupProdDataset.tsh_JerarquiaAgrupProdRow rowJ = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(_key);			
			if (rowJ != null && _uiController.Items.Count > 0) 

			{	
				//Cristian Tarea 0000040 20110309
                if (MessageBox.Show("El agrupamiento de producto sera guardado. Desea Continuar?", "Warning",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (!_uiController.UpdateWithValidation(rowJ.Jerarquia))
                    { Evaluate(); }
                    else
                    { Actualizar(); }	
                }

                //MessageBox.Show("El agrupamiento sera guardado. Desea Continuar?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			    //Fin Cristian
								
			}
			else 
			{				
				if (_uiController.Items.Count == 0) 
				{
					MessageBox.Show( "Debe seleccionar un producto.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else 
				{
					MessageBox.Show( "Debe seleccionar otro nivel de la jerarquía.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}				
			}				
		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			/// <summary>
			/// Busca en la tabla de relación según la jerarquía y el código de producto para eliminarla.
			/// </summary>
			if (gridEXAgrupamientos.SelectedItems.Count > 0 && _idProducto != String.Empty) 
			{

               //Cristian Tarea 0000040 20110309
                if (MessageBox.Show("El agrupamiento de producto sera borrado. Desea Continuar?", "Warning",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string Jerarquia = gridEXAgrupamientos.SelectedItems[0].GetRow().Cells["Jerarquia"].Value.ToString();
                    _uiController.Delete(Jerarquia);
                    Evaluate();
                    Actualizar();
                }
                //Fin Cristian
			}
			else 
			{
				if (_idProducto == String.Empty) 
				{
					MessageBox.Show( "Debe seleccionar un producto.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}
				else 
				{
					MessageBox.Show( "No hay un agrupamiento para eliminar.","Información", MessageBoxButtons.OK, MessageBoxIcon.Information );
				}				
			}
		}

		private void gridProductos_Click(object sender, EventArgs e)
		{
			Actualizar();
		}
	}
}


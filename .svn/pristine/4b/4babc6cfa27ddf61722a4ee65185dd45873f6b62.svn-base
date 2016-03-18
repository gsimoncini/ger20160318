using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAgrupCuentas.
	/// </summary>
	public class FrmAgrupamientos : System.Windows.Forms.Form, ITaskForm
	{
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private Infragistics.Win.Misc.UltraButton btnAgregar;
		private Janus.Windows.GridEX.GridEX gridEXAgrupamientos;
		private Infragistics.Win.Misc.UltraButton btnBuscar;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTreeAgrupamientos;
		private Janus.Windows.GridEX.GridEX gridElementos;
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		
		private System.ComponentModel.Container components = null;

		#region Variables Privadas
		
		private AgrupamientosController _uiController;
		private System.Windows.Forms.ContextMenu cmAgrupamientosTree;
		private System.Windows.Forms.MenuItem menuItem1;
		private bool _expandir = true;
		private mz.erp.ui.controls.mzProveedoresControl mzCmb;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private mz.erp.ui.controls.mzCuentasControl mzCmbCuenta;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
		private string _type;
        private Button button1;
        //Cristian Tarea 00084 20120109
        private ArrayList _proveedoresSeleccionados = new ArrayList();
        //Fin Cristian Tarea 00084

		#endregion

		#region Constructores

		public FrmAgrupamientos(string type)
		{
			InitializeComponent();
			_type = type;
			_uiController = new AgrupamientosController(type);
			Build_UI();
		}

		public FrmAgrupamientos(AgrupamientosController controller)
		{
			_uiController = controller; 
			InitializeComponent();
		}

		#endregion

		#region Diseñador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgrupamientos));
            Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
            Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzCmbCuenta = new mz.erp.ui.controls.mzCuentasControl();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.mzCmb = new mz.erp.ui.controls.mzProveedoresControl();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.gridElementos = new Janus.Windows.GridEX.GridEX();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
            this.btnAgregar = new Infragistics.Win.Misc.UltraButton();
            this.gridEXAgrupamientos = new Janus.Windows.GridEX.GridEX();
            this.btnBuscar = new Infragistics.Win.Misc.UltraButton();
            this.ultraTreeAgrupamientos = new Infragistics.Win.UltraWinTree.UltraTree();
            this.cmAgrupamientosTree = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.button1 = new System.Windows.Forms.Button();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridElementos)).BeginInit();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEXAgrupamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTreeAgrupamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.button1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCuenta);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmb);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.ultraLabel1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gridElementos);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 50);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(842, 220);
            this.ultraExplorerBarContainerControl1.TabIndex = 0;
            // 
            // mzCmbCuenta
            // 
            this.mzCmbCuenta.AllowEditClientePaso = false;
            this.mzCmbCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmbCuenta.DataValue = "";
            this.mzCmbCuenta.EnableCtaCte = false;
            this.mzCmbCuenta.FastSearch = false;
            this.mzCmbCuenta.Location = new System.Drawing.Point(125, 3);
            this.mzCmbCuenta.Name = "mzCmbCuenta";
            this.mzCmbCuenta.ReseteaCodCta = false;
            this.mzCmbCuenta.SearchObjectListener = null;
            this.mzCmbCuenta.Size = new System.Drawing.Size(614, 25);
            this.mzCmbCuenta.TabIndex = 0;
            this.mzCmbCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mzCmbCuenta_KeyDown);
            
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel2.Location = new System.Drawing.Point(10, 0);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(74, 18);
            this.ultraLabel2.TabIndex = 36;
            this.ultraLabel2.Text = "Cuenta";
            // 
            // mzCmb
            // 
            this.mzCmb.BackColor = System.Drawing.SystemColors.Control;
            this.mzCmb.DataValue = "";
            this.mzCmb.EnableCtaCte = false;
            this.mzCmb.FastSearch = false;
            this.mzCmb.Location = new System.Drawing.Point(125, 0);
            this.mzCmb.Name = "mzCmb";
            this.mzCmb.SearchObjectListener = null;
            this.mzCmb.Size = new System.Drawing.Size(585, 25);
            this.mzCmb.TabIndex = 0;
            this.mzCmb.Tag = "ResponsableEmision";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.BackColorInternal = System.Drawing.Color.Transparent;
            this.ultraLabel1.Location = new System.Drawing.Point(10, 0);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(74, 18);
            this.ultraLabel1.TabIndex = 27;
            this.ultraLabel1.Text = "Proveedor";
            // 
            // gridElementos
            // 
            this.gridElementos.AllowCardSizing = false;
            this.gridElementos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridElementos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridElementos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridElementos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridElementos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridElementos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridElementos.GroupByBoxVisible = false;
            this.gridElementos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridElementos.Location = new System.Drawing.Point(0, 27);
            this.gridElementos.Name = "gridElementos";
            this.gridElementos.Size = new System.Drawing.Size(842, 193);
            this.gridElementos.TabIndex = 1;
            this.gridElementos.TabStop = false;
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.btnEliminar);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.btnAgregar);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEXAgrupamientos);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.btnBuscar);
            this.ultraExplorerBarContainerControl2.Controls.Add(this.ultraTreeAgrupamientos);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 330);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(842, 532);
            this.ultraExplorerBarContainerControl2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(490, 76);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(490, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 28);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "&Agregar";
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
            this.gridEXAgrupamientos.LayoutData = resources.GetString("gridEXAgrupamientos.LayoutData");
            this.gridEXAgrupamientos.Location = new System.Drawing.Point(599, 0);
            this.gridEXAgrupamientos.Name = "gridEXAgrupamientos";
            this.gridEXAgrupamientos.Size = new System.Drawing.Size(235, 526);
            this.gridEXAgrupamientos.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(490, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 28);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&Buscar";
            // 
            // ultraTreeAgrupamientos
            // 
            this.ultraTreeAgrupamientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ultraTreeAgrupamientos.ContextMenu = this.cmAgrupamientosTree;
            this.ultraTreeAgrupamientos.HideSelection = false;
            this.ultraTreeAgrupamientos.Location = new System.Drawing.Point(0, 0);
            this.ultraTreeAgrupamientos.Name = "ultraTreeAgrupamientos";
            ultraTreeNode1.Key = "RAIZ";
            ultraTreeNode1.Text = "Agrupamientos";
            this.ultraTreeAgrupamientos.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
            ultraTreeNode1});
            _override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
            this.ultraTreeAgrupamientos.Override = _override1;
            this.ultraTreeAgrupamientos.Size = new System.Drawing.Size(480, 526);
            this.ultraTreeAgrupamientos.TabIndex = 0;
            // 
            // cmAgrupamientosTree
            // 
            this.cmAgrupamientosTree.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Agregar";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.AnimationEnabled = false;
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 220;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Datos Generales";
            ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 532;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Detalle de Agrupamiento";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2});
            this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
            this.ultraExplorerBar1.Name = "ultraExplorerBar1";
            this.ultraExplorerBar1.Size = new System.Drawing.Size(912, 550);
            this.ultraExplorerBar1.TabIndex = 24;
            
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // FrmAgrupamientos
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(912, 550);
            this.Controls.Add(this.ultraExplorerBar1);
            this.Name = "FrmAgrupamientos";
            this.Text = "Grupos de Clientes";
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridElementos)).EndInit();
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEXAgrupamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTreeAgrupamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#endregion

		#region Inicializadores
			
		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();
		}

		private void ConfigureInterface()
		{
			gridElementos.LayoutData = _uiController.LayoutElementos;
			gridEXAgrupamientos.LayoutData = _uiController.LayoutAgrupamientos;
			ultraTreeAgrupamientos.CollapseAll();
			if(_type.ToUpper().Equals("CUENTAS"))
			{
				
				mzCmbCuenta.EnableCtaCte = false;
				mzCmbCuenta.Init();
				mzCmbCuenta.Enabled = true;	
				mzCmbCuenta.AllowEditClientePaso = false;
				mzCmbCuenta.AllowMultipleSelect = true;
				mzCmbCuenta.Visible = true;
				mzCmb.Visible = false;
				ultraLabel1.Visible = false;
				ultraLabel2.Visible = true;
				
			}
			else if(_type.ToUpper().Equals("PROVEEDORES"))
			{
				
				mzCmb.Enabled = true;
				mzCmb.Init();
				mzCmb.EnableCtaCte = false;
				mzCmb.AllowMultipleSelect = true;
				mzCmbCuenta.Visible = false;
				mzCmb.Visible = true;
				ultraLabel1.Visible = true;
				ultraLabel2.Visible = false;
			}

		}

		private void InitEventHandlers()
		{
			ultraTreeAgrupamientos.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
			ultraTreeAgrupamientos.AfterExpand +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterExpand);
			btnAgregar.Click +=new EventHandler(btnAgregar_Click);
			btnEliminar.Click +=new EventHandler(btnEliminar_Click);
			btnBuscar.Click +=new EventHandler(btnBuscar_Click);
			_uiController.ModelHasChanged +=new EventHandler(_uiController_ModelHasChanged);
			_uiController.AgrupamientosHasChanged +=new EventHandler(_uiController_AgrupamientosHasChanged);
			gridElementos.RecordsDeleted +=new EventHandler(gridElementos_RecordsDeleted);
            if (_type.ToUpper().Equals("CUENTAS"))
            {
                this.button1.Click += new System.EventHandler(this.Cuentas_Click);
                mzCmbCuenta.MultipleSelectedItemsChanged += new EventHandler(mzCmbCuenta_MultipleSelectedItemsChanged);
            }
            else
                if (_type.ToUpper().Equals("PROVEEDORES"))
                {
                    this.button1.Click += new System.EventHandler(this.Proveedores_Click);
                    mzCmb.MultipleSelectedItemsChanged += new EventHandler(mzCmb_MultipleSelectedItemsChanged);
                }
            //mzCmb.
            mzCmb.ChangeUICues += new UICuesEventHandler(mzCmb_ChangeUICues);
		}

        void mzCmb_ChangeUICues(object sender, UICuesEventArgs e)
        {
            //_uiController.ModelHasChanged(e);    
        }

		private void Componentes_Changes( object sender, System.EventArgs e )
		{			
			
		}

		private void mzCmbProveedor_ValueChanged(object sender, EventArgs e)
		{
			
		}


		private void InitializeData()
		{
			UpdateTree(ultraTreeAgrupamientos.Nodes[0]);
			_expandir = false;
			ultraTreeAgrupamientos.Nodes[0].Expanded = true;
			_expandir = true;
			
	
		}

		private void UpdateTree(Infragistics.Win.UltraWinTree.UltraTreeNode Node)
		{
			string key = Node.Key;
			_uiController.UpdateTree(key);
			while(_uiController.HasNext())
			{
				ArrayList nodo = _uiController.Next();
				string keyChildNode = Convert.ToString(nodo[0]);
				string descriptionChildNode = Convert.ToString(nodo[1]);
                Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
				if(!Node.Nodes.Exists(keyChildNode))
					Node.Nodes.Add(childNode);

			}
			foreach(Infragistics.Win.UltraWinTree.UltraTreeNode childNode in Node.Nodes)
			{
				string keyC = childNode.Key;
				_uiController.UpdateTree(keyC);
				while(_uiController.HasNext())
				{
					ArrayList nodo = _uiController.Next();
					string keyChildNode = Convert.ToString(nodo[0]);
					string descriptionChildNode = Convert.ToString(nodo[1]);
					Infragistics.Win.UltraWinTree.UltraTreeNode childChildNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
					if(!childNode.Nodes.Exists(keyChildNode))
						childNode.Nodes.Add(childChildNode);

				}

			}
		
		}

		private void InitDataBindings()
		{

		}

	

		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}


		public void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();

			}
			else
			{
				if(_uiController.IsNextState())
					this._uiController.Execute();
				else
					if(_uiController.IsBackState())
					this._uiController.Previous();
			}
		}
		public void CloseForm()
		{
			
			Close();								
		}

		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}

		#endregion

		private void ultraTreeAgrupamientos_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (_expandir) {UpdateTree(e.TreeNode);}
		}

		private void ultraTreeAgrupamientos_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			_uiController.CurrentKey = e.TreeNode.Key;
			_uiController.CurrentDescription = e.TreeNode.Text;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			_uiController.Add();
			if(_uiController.GetErrors().Count > 0)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors( _uiController.GetErrors() );
				_form.ShowDialog();
			}
			else
			{
				if(gridElementos.SelectedItems.Count > 0)
				{
					object SelectedItem = gridElementos.SelectedItems[0].GetRow().DataRow;
					gridEXAgrupamientos.SetDataBinding(null, null);
					gridEXAgrupamientos.SetDataBinding(_uiController.BuscarJerarquias(SelectedItem), null);
					//System.Data.DataTable data = _uiController.BuscarJerarquias(SelectedItem);
					//this.gridEXAgrupamientos.DataSource = data;
				}
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			if(gridEXAgrupamientos.SelectedItems.Count > 0)
			{
				//Cristian Tarea 0000040 20110309
                if (MessageBox.Show("El agrupamiento de "+_type+" sera borrado. Desea Continuar?", "Warning",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    string Jerarquia =
                        Convert.ToString(gridEXAgrupamientos.SelectedItems[0].GetRow().Cells["Jerarquia"].Value);
                    _uiController.BorrarAgrupamientos(Jerarquia);
                    /*
                    if(!_uiController.IsValid())
                    {
                        FrmShowErrors _form = new FrmShowErrors( _uiController.GetErrors() );
                        _form.ShowForm();
                    }
                    else
                    {
                    */
                    if (gridElementos.SelectedItems.Count > 0)
                    {
                        object SelectedItem = gridElementos.SelectedItems[0].GetRow().DataRow;
                        gridEXAgrupamientos.SetDataBinding(null, null);
                        gridEXAgrupamientos.SetDataBinding(_uiController.BuscarJerarquias(SelectedItem), null);
                        //this.gridEXAgrupamientos.DataSource = _uiController.BuscarJerarquias(SelectedItem);
                    }
                    //}
                }//Fin Tarea Cristian
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if(gridElementos.SelectedItems.Count > 0)
			{
				object SelectedItem = gridElementos.SelectedItems[0].GetRow().DataRow;
				gridEXAgrupamientos.SetDataBinding(null, null);
				gridEXAgrupamientos.SetDataBinding(_uiController.BuscarJerarquias(SelectedItem), null);
				//this.gridEXAgrupamientos.DataSource = _uiController.BuscarJerarquias(SelectedItem);
			}
		}



		private void _uiController_ModelHasChanged(object sender, EventArgs e)
		{
			//this.gridElementos.DataSource = _uiController.Elementos;
			//this.gridElementos.DataBindings.Clear();
			this.gridElementos.SetDataBinding( _uiController.Elementos, null);
            this.gridElementos.SetDataBinding(null, null);
            this.gridElementos.SetDataBinding(_uiController.Elementos, null);
		}

		private void _uiController_AgrupamientosHasChanged(object sender, EventArgs e)
		{
			
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void gridElementos_RecordsDeleted(object sender, EventArgs e)
		{
			if(gridElementos.RecordCount == 0)
				gridEXAgrupamientos.SetDataBinding(null, null);
		}

		private void mzCmbCuenta_MultipleSelectedItemsChanged(object sender, EventArgs e)
		{
			if( mzCmbCuenta.SelectedItems.Count > 0)
				_uiController.UpdateElementos( mzCmbCuenta.SelectedItems);
		}

		private void mzCmb_MultipleSelectedItemsChanged(object sender, EventArgs e)
		{
			if( mzCmb.SelectedItems.Count > 0)
				_uiController.UpdateElementos( mzCmb.SelectedItems);
		}

        protected void addProveedor(String idProveedor){

        }




        private void mzCmbCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            switch (e.KeyData)
            {
                case System.Windows.Forms.Keys.Enter:
                    {
                        _uiController.Agregar(mzCmb.DataValue);
                        _uiController.UpdateElementos(mzCmb.SelectedItems);
                        break;
                    }
                default:
                    break;
            }
            */
        }


        //Cristian Tarea 00084 20120110
        private void Proveedores_Click(object sender, EventArgs e)
        {
            _uiController.Agregar(mzCmb.DataValue);
            _uiController.UpdateElementos(mzCmb.SelectedItems);
        }
        private void Cuentas_Click(object sender, EventArgs e)
        {
            _uiController.Agregar(mzCmbCuenta.DataValue);
            _uiController.UpdateElementos(mzCmbCuenta.SelectedItems);
        }
        //Fin Cristian Tarea 000084
	}
}

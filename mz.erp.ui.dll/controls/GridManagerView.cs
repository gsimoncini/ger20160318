using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using mz.erp.commontypes;
using mz.erp.commontypes.CommonInterfaces;
using mz.erp.businessrules;

namespace mz.erp.ui.controls
{ 
	/// <summary>
	/// Descripción breve de GridManagerView.
	/// </summary>
	public class GridManagerView : System.Windows.Forms.UserControl, IObserver
	{
		private mz.erp.ui.controls.GridManagerViewMark gridManagerViewMark1;
		private mz.erp.ui.controls.GridManagerColumns gridManagerColumns1;
		private mz.erp.ui.controls.GridManagerViewExportExcel gridManagerViewExportExcel1;
		private mz.erp.ui.controls.GridManagerViewSortByAgregateColumn gridManagerViewSortByAgregateColumn1;	
		private mz.erp.ui.controls.GridManagerViewConfigurarStyleGrilla gridManagerViewConfigurarStyleGrilla1;
		private System.Windows.Forms.ToolTip toolTipNombreGrilla;
		private System.ComponentModel.IContainer components;
        private mz.erp.ui.controls.GridManagerViewSaveConfig gridManagerViewSaveConfig1; //Matias 20101005 - Tarea 898

		public GridManagerView()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);    

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent

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

		#region Código generado por el Diseñador de componentes
		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.gridManagerViewMark1 = new mz.erp.ui.controls.GridManagerViewMark();
            this.gridManagerColumns1 = new mz.erp.ui.controls.GridManagerColumns();
            this.gridManagerViewExportExcel1 = new mz.erp.ui.controls.GridManagerViewExportExcel();
            this.gridManagerViewSortByAgregateColumn1 = new mz.erp.ui.controls.GridManagerViewSortByAgregateColumn();
            this.gridManagerViewConfigurarStyleGrilla1 = new mz.erp.ui.controls.GridManagerViewConfigurarStyleGrilla();
            this.gridManagerViewSaveConfig1 = new mz.erp.ui.controls.GridManagerViewSaveConfig();
            this.toolTipNombreGrilla = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // gridManagerViewMark1
            // 
            this.gridManagerViewMark1.Location = new System.Drawing.Point(160, 0);
            this.gridManagerViewMark1.Name = "gridManagerViewMark1";
            this.gridManagerViewMark1.Size = new System.Drawing.Size(72, 24);
            this.gridManagerViewMark1.TabIndex = 0;
            // 
            // gridManagerColumns1
            // 
            this.gridManagerColumns1.Location = new System.Drawing.Point(0, 0);
            this.gridManagerColumns1.Name = "gridManagerColumns1";
            this.gridManagerColumns1.Size = new System.Drawing.Size(160, 24);
            this.gridManagerColumns1.TabIndex = 1;
            // 
            // gridManagerViewExportExcel1
            // 
            this.gridManagerViewExportExcel1.Location = new System.Drawing.Point(392, 0);
            this.gridManagerViewExportExcel1.Name = "gridManagerViewExportExcel1";
            this.gridManagerViewExportExcel1.Size = new System.Drawing.Size(344, 24);
            this.gridManagerViewExportExcel1.TabIndex = 2;
            // 
            // gridManagerViewSortByAgregateColumn1
            // 
            this.gridManagerViewSortByAgregateColumn1.Location = new System.Drawing.Point(744, 0);
            this.gridManagerViewSortByAgregateColumn1.Name = "gridManagerViewSortByAgregateColumn1";
            this.gridManagerViewSortByAgregateColumn1.Size = new System.Drawing.Size(120, 23);
            this.gridManagerViewSortByAgregateColumn1.TabIndex = 3;
            // 
            // gridManagerViewConfigurarStyleGrilla1
            // 
            this.gridManagerViewConfigurarStyleGrilla1.Location = new System.Drawing.Point(240, 0);
            this.gridManagerViewConfigurarStyleGrilla1.Name = "gridManagerViewConfigurarStyleGrilla1";
            this.gridManagerViewConfigurarStyleGrilla1.Size = new System.Drawing.Size(96, 24);
            this.gridManagerViewConfigurarStyleGrilla1.TabIndex = 4;
            // 
            // gridManagerViewSaveConfig1
            // 
            this.gridManagerViewSaveConfig1.Location = new System.Drawing.Point(350, 0);
            this.gridManagerViewSaveConfig1.Name = "gridManagerViewSaveConfig1";
            this.gridManagerViewSaveConfig1.Size = new System.Drawing.Size(28, 24);
            this.gridManagerViewSaveConfig1.TabIndex = 5;
            this.toolTipNombreGrilla.SetToolTip(this.gridManagerViewSaveConfig1, "Guardar Configuración");
            // 
            // GridManagerView
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gridManagerViewSortByAgregateColumn1);
            this.Controls.Add(this.gridManagerViewExportExcel1);
            this.Controls.Add(this.gridManagerColumns1);
            this.Controls.Add(this.gridManagerViewMark1);
            this.Controls.Add(this.gridManagerViewConfigurarStyleGrilla1);
            this.Controls.Add(this.gridManagerViewSaveConfig1);
            this.Name = "GridManagerView";
            this.Size = new System.Drawing.Size(864, 24);
            this.ResumeLayout(false);

		}
		#endregion
	
		#region Propiedades
		private bool _allowGroupCollapse = false;
		public bool AllowGroupCollapse 
		{
			get { return _allowGroupCollapse; }			
		}

		private bool _allowExportExcel = false;
		public bool AllowExportExcel 
		{
			get { return _allowExportExcel; }			
		}
		private bool _allowSortByAgregateColumn = false;
		public bool AllowSortByAgregateColumn 
		{
			get { return _allowSortByAgregateColumn; }			
		}
		private bool _allowMarkColumn = false;
		public bool AllowMarkColumn 
		{
			get { return _allowMarkColumn; }			
		}



		#endregion
				
		#region Variables privadas
		private IGridManager _manager;
		private GridVariablesLoader _loader;
		private string _processName = string.Empty;
		private string _taskName = string.Empty;
        //Matias 20100727 - Tarea 21
        //Var privada global "ascendente": tuve que hacerlo asi porque no le da bolilla a Asc o Desc de la Grilla.
        private bool _ascendente = true; //sirve para alternar el orden entre Asc y Desc.
        private bool _orderCodigoNumerico = false; // si es true ==> orden por numero natural, false ==> lexicografico.
        //Fin Matias 20100727 - Tarea 21
        //Matias 20101007 - Tarea 898
        private Janus.Windows.GridEX.GridEX _grillaActual = new Janus.Windows.GridEX.GridEX(); // guarda la grilla actual.
        //FinMatias 20101007 - Tarea 898
		#endregion

		public void Init(IGridManager manager, string ProcessName, string TaskName, GridVariablesLoader loader)
		{			
			gridManagerColumns1.Enabled = false;
			gridManagerViewMark1.Enabled = false;
			gridManagerViewExportExcel1.Enabled = false;
			gridManagerViewSortByAgregateColumn1.Enabled = false;
			gridManagerViewConfigurarStyleGrilla1.Enabled = false;
            gridManagerViewSaveConfig1.Enabled = true; //Matias 20101005 - Tarea 898 (visibilidad= true o false)
			gridManagerViewSortByAgregateColumn1.AddObjectListener(this);
			this.BackColor = Color.Transparent;
			_manager = manager;			
			_loader = loader;
			_processName = ProcessName;
			_taskName = TaskName;			
		}

		#region Configure - Levanta variables por GrillaResultado (default)
		public void Configure(string ProcessName, string TaskName, Janus.Windows.GridEX.GridEX grilla, string TituloFormularioPadre)
		{
			Configure(ProcessName, TaskName, null, grilla, TituloFormularioPadre);
		}
		public void Configure(string ProcessName, string TaskName, string Formulario, Janus.Windows.GridEX.GridEX grilla, string TituloFormularioPadre)
		{	
			// Levanta todas las variables de configuracion de la grilla de sy_variables
			controllers.GridVariablesLoader loader = new controllers.GridVariablesLoader(ProcessName, TaskName, false, grilla.Name);
			GridManagerJanus manager = new GridManagerJanus(grilla);
			if (Formulario == null)
				manager.ConfigureGrid(ProcessName, TaskName, loader);
			else
				manager.ConfigureGrid(ProcessName, TaskName, loader, Formulario);

			this.Init(manager, ProcessName, TaskName, loader);
			this.EnableMarkControl(loader.AllowMarkRow);
			this.EnableColumnsControl(loader.AllowDefineVisibleColumns);
			this.EnableConfigurarStyleGrillaControl(loader.AllowGridConfiguration);
			this.ConfigureMarkControl(loader.NameMarkRow);
			this.ConfigureColumnsControl(string.Empty);	
			this.ConfigureConfigurarStyleGrillaControl(ProcessName, TaskName, Formulario, grilla, TituloFormularioPadre);
			this.EnableExportExcelControl(loader.AllowExportExcel);
			this.ConfigureExportExcelControl(string.Empty);				
			this._allowGroupCollapse = loader.AllowGroupCollapse;		
			this.ConfigureSortByAgregateColumnControl(grilla);
            //Matias 20101005 - Tarea 898
            this.EnableSaveConfigControl(loader.AllowSaveConfig);
            this.ConfigureSaveConfigControl(string.Empty, grilla.Name);
            //FinMatias 20101005 - Tarea 898

			if(Security.PerteneceAPerfilSuperior)
                toolTipNombreGrilla.SetToolTip(grilla, grilla.Name);
            
            //Matias 20100727 - Tarea 21
            _orderCodigoNumerico = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.OrdenCodigoNumerico", "Grillas.OrdenCodigoNumerico", false); //Indica si Codigo lo ordena por String o Int (true==>Int).
            grilla.SortKeysChanged += new EventHandler(grilla_SortKeysChanged);
            //Fin Matias 20100727 - Tarea 21
            //Matias 20101005 - Tarea 898
            if (Security.PerteneceAPerfilSuperior)
                this.configurarEventosGrilla(grilla);
            //FinMatias 20101005 - Tarea 898
		}
		#endregion

		#region Configure - Levanta variables por Grilla.Name
		public void Configure(string ProcessName, string TaskName, Janus.Windows.GridEX.GridEX grilla, string TituloFormularioPadre, bool LevantaVariablesPorGrillaName)
		{
			Configure(ProcessName, TaskName, null, grilla, TituloFormularioPadre, LevantaVariablesPorGrillaName);
		}
        public void Configure(string ProcessName, string TaskName, string Formulario, Janus.Windows.GridEX.GridEX grilla, string TituloFormularioPadre, bool LevantaVariablesPorGrillaName)
		{	
			// Levanta todas las variables de configuracion de la grilla de sy_variables
			controllers.GridVariablesLoader loader = new controllers.GridVariablesLoader(ProcessName, TaskName, LevantaVariablesPorGrillaName, grilla.Name);
			GridManagerJanus manager = new GridManagerJanus(grilla);
			if (Formulario == null)
				manager.ConfigureGrid(ProcessName, TaskName, loader);
			else
				manager.ConfigureGrid(ProcessName, TaskName, loader, Formulario);

			this.Init(manager, ProcessName, TaskName, loader);
			this.EnableMarkControl(loader.AllowMarkRow);
			this.EnableColumnsControl(loader.AllowDefineVisibleColumns);
			this.EnableConfigurarStyleGrillaControl(loader.AllowGridConfiguration);
			this.ConfigureMarkControl(loader.NameMarkRow);
			this.ConfigureColumnsControl(string.Empty);	
			this.ConfigureConfigurarStyleGrillaControl(ProcessName, TaskName, Formulario, grilla, TituloFormularioPadre);
			this.EnableExportExcelControl(loader.AllowExportExcel);
			this.ConfigureExportExcelControl(string.Empty);				
			this._allowGroupCollapse = loader.AllowGroupCollapse;		
			this.ConfigureSortByAgregateColumnControl(grilla);
            //Matias 20101005 - Tarea 898
            this.EnableSaveConfigControl(loader.AllowSaveConfig);
            this.ConfigureSaveConfigControl(string.Empty, grilla.Name);
            //FinMatias 20101005 - Tarea 898

            //Matias 20100727 - Tarea 21
            _orderCodigoNumerico = Variables.GetValueBool(_processName, _taskName, "GrillaResultado.OrdenCodigoNumerico", "Grillas.OrdenCodigoNumerico", false); //Indica si Codigo lo ordena por String o Int (true==>Int).
            grilla.SortKeysChanged += new EventHandler(grilla_SortKeysChanged);
            //Fin Matias 20100727 - Tarea 21

            //Matias 20101005 - Tarea 898
            if (Security.PerteneceAPerfilSuperior)
                this.configurarEventosGrilla(grilla);
            //FinMatias 20101005 - Tarea 898
		}

        #region Matias 20101005 - Tarea 898
        //Matias 20101005 - Tarea 898
        private void configurarEventosGrilla(Janus.Windows.GridEX.GridEX grilla)
        {
            _grillaActual = grilla;
            grilla.MouseDown += new MouseEventHandler(grilla_MouseDown);
        }

        void grilla_MouseDown(object sender, MouseEventArgs e)
        {
            // Evento ligado solo para Perfiles Superiores!
            if (e.Button == MouseButtons.Right)
            {
                Janus.Windows.GridEX.GridArea gridArea = _grillaActual.HitTest(e.X, e.Y);
                if (gridArea == Janus.Windows.GridEX.GridArea.ColumnHeader)
                {
                    // Boton derecho sobre el column header de la grilla.
                    // 1) Veo si existe un contextMenu ligado a la grilla.
                    if (_grillaActual.ContextMenu == null)
                    {
                        ContextMenu menu = new ContextMenu();
                        _grillaActual.ContextMenu = menu;

                    }
                    // 2) Agrego, si NO EXISTE, una nueva opcion al menu: "ConfigurarColumna".
                    if (!_grillaActual.ContextMenu.MenuItems.ContainsKey("ConfigurarColumna"))
                    {
                        MenuItem configurarColumna = new MenuItem();
                        configurarColumna.Name = "ConfigurarColumna";
                        configurarColumna.Click += new EventHandler(configurarColumna_Click);
                        configurarColumna.Text = "Configurar Columna";
                        _grillaActual.ContextMenu.MenuItems.Add(configurarColumna);
                    }
                }
                else
                {
                    // Botón derecho sobre la grilla pero FUERA del area Column Header.
                    // Elimino, en caso que exista el menu contextual, la opcion "Guardar Configuracion" (si existe).
                    if ((_grillaActual.ContextMenu != null) && (_grillaActual.ContextMenu.MenuItems.ContainsKey("ConfigurarColumna")))
                    {
                        // Existe el menu y la opcion ==> elimino la opcion.
                        _grillaActual.ContextMenu.MenuItems.RemoveByKey("ConfigurarColumna");
                    }
                    // Nota: si el menu queda sin opciones ==> no será visible! OK.
                }
            }
        }

        void configurarColumna_Click(object sender, EventArgs e)
        {
            mz.erp.ui.forms.FrmGrillasOpcionesSuperiores frmOpciones = new mz.erp.ui.forms.FrmGrillasOpcionesSuperiores(_processName, _taskName, _grillaActual, _manager);
            frmOpciones.ShowDialog();
            _grillaActual.Refresh();
        }

        //FinMatias 20101005 - Tarea 898
        #endregion

		#endregion

		public void EnableExportExcelControl(bool value)
		{
			_allowExportExcel = value;
			gridManagerViewExportExcel1.Enabled = value;
		}
		public void ConfigureSortByAgregateColumnControl(Janus.Windows.GridEX.GridEX grilla)
		{			
			gridManagerViewSortByAgregateColumn1.Configure(_manager, _loader, grilla);
			_allowSortByAgregateColumn = _loader.AllowSortByMergeAgregateColumn;
		}
		public void EnableMarkControl(bool value)
		{
			gridManagerViewMark1.Enabled = value;
			_allowMarkColumn = value;
		}
		public void ConfigureMarkControl(string ColumnName) 
		{
			gridManagerViewMark1.Configure(_manager, _loader, ColumnName);
		}

		public void EnableColumnsControl(bool value)
		{
			gridManagerColumns1.Enabled = value;
		}
		public void ConfigureColumnsControl(string ExcludedColumns) 
		{
			gridManagerColumns1.Configure(_manager, _loader,ExcludedColumns, _processName, _taskName);
		}

		public void ConfigureExportExcelControl(string ExcludedColumns) 
		{
			gridManagerViewExportExcel1.Configure(_manager, _loader,ExcludedColumns, _processName, _taskName);
		}
		/* Solo es usado por el buscador de Clientes y se le pasa gridManagerViewExportExcel */
        /* Tambien usado para la exportacion a Excel */
		public void SetView(DataView view) 
		{
			gridManagerViewExportExcel1.View = view;
		}

		public void SetTable(DataTable table) 
		{
			if (table != null)
			{   
                gridManagerViewExportExcel1.Table = table;
                gridManagerViewSortByAgregateColumn1.Table = table;
			}
		}

		public void ExportToExcel(string FileName)
		{
            
			if(_allowExportExcel)
			{   // Cristian Tarea 921
                gridManagerViewExportExcel1.View = updateView();
                //Fin Tarea 921
				gridManagerViewExportExcel1.ExportToExcel(FileName);
			}
		}
        //Cristian Tarea 921
        /// <summary>
        /// Retorna la vista actual de la grilla
        /// </summary>
        /// <returns>vista</returns>
        private DataView updateView()
        {
            DataTable tabla = new DataTable();
            /* se realiza esta comparacion porque Datasource puede contener un Datable, un DataView o un DataSet */
            /* Silvina 20101213 - Tarea 921 */
            if (_grillaActual.DataSource != null)
            /* Fin Silvina */
            {
                /* Cristian Tarea 1054 20110207 */
                string datasource = _grillaActual.DataSource.GetType().Name.ToString();
                switch (datasource)
                {
                    case "DataTable":
                        tabla = (DataTable)_grillaActual.DataSource;
                        break;
                    case "DataView":
                        tabla = (DataTable)((DataView)_grillaActual.DataSource).Table;
                        break;
                    case "DataSet":
                        tabla = (DataTable)((DataSet)_grillaActual.DataSource).Tables[0];
                        break;
                    default:
                        break;
                }
                /* Fin Cristian */ 
            }

            DataView vista = new DataView(tabla);
            /* Silvina 20101213 - Tarea 921 */
            if ((_grillaActual.RootTable != null) && _grillaActual.RootTable.SortKeys.Count>0 && (vista.Count > 0)) {
            /* Fin Silvina */
                Janus.Windows.GridEX.GridEXSortKey orden = _grillaActual.RootTable.SortKeys[0];
                if (orden.SortOrder.Equals(Janus.Windows.GridEX.SortOrder.Ascending))
                    {
                      vista.Sort = orden.Column.DataMember + " ASC";
                      }
                 else
                   {
                     if (orden.SortOrder.Equals(Janus.Windows.GridEX.SortOrder.Descending))
                       {
                           vista.Sort = orden.Column.DataMember + " DESC";
                       }
                    }//end else
            }
            return vista;
        }
        //Fin Tarea 921

		protected override void OnPaint(PaintEventArgs pe)
		{
			
			// Calling the base class OnPaint
			base.OnPaint(pe);
			// Create two semi-transparent colors
			/*Color c1 = Color.FromArgb
				(0 ,0,0,0 );
			Color c2 = Color.FromArgb
				(0 ,0,0,0);
			Brush b = new System.Drawing.Drawing2D.LinearGradientBrush
				(ClientRectangle, c1, c2, 10);
			pe.Graphics.FillRectangle (b, ClientRectangle);
			b.Dispose();
			*/
			
			
		}

		public void EnableConfigurarStyleGrillaControl(bool value)
		{
			gridManagerViewConfigurarStyleGrilla1.Enabled = value;
		}

		public void ConfigureConfigurarStyleGrillaControl(string ProcessName, string TaskName, string Formulario, Janus.Windows.GridEX.GridEX grilla, string TituloFormularioPadre) 
		{
			ArrayList columnas = new ArrayList();
			Janus.Windows.GridEX.GridEXColumnCollection cols = grilla.RootTable.Columns;
			foreach(Janus.Windows.GridEX.GridEXColumn col in cols)
			{				
				mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView colV = new mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView(col.Caption, getTypeFor(col.FormatString, col.ColumnType.ToString()), col.Key, col);
				columnas.Add(colV);
			}
			gridManagerViewConfigurarStyleGrilla1.Configure(_manager, _loader,columnas, grilla, ProcessName, TaskName, Formulario, TituloFormularioPadre);
		}


		public static string getTypeFor(string formatStyle, string columnType)
		{
			if(columnType.Equals(Convert.ToString(PropertiesTypesJanus.ColumnTypes.CheckBox)))
				return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.BoolType;	
			else
			{
				switch(formatStyle)
				{
					case "c": return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.DecimalType;						
						break;
					case "p": return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.DecimalType;
						break;
					case "d": return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.DateTimeType;
						break;
					case "dd/MM/yyyy": return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.DateTimeType;
						break;
					case "0": return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.IntType;
						break;
					case "0.00": return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.DecimalType;
						break;
					case "#,##0.00;#,##0.00;0.00": return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.DecimalType;
                    //Matias 20101025 - Tarea 898
                        break;
                    case "f": return ConfiguracionStyleGrilla.ColumnaView.StringType;
                        break;
                    //FinMatias
                    default: return mz.erp.businessrules.ConfiguracionStyleGrilla.ColumnaView.StringType;
				}
			}	
		}

		#region Miembros de IObserver

		public void UpdateObject(object sender, object valores)
		{
			if(sender.Equals(this.gridManagerViewSortByAgregateColumn1))
			{
				bool ok = Convert.ToBoolean(valores);
				if(ok)
				{
					gridManagerColumns1.Enabled = false;
					gridManagerViewMark1.Enabled = false;
					// matias 23/09/08
					//gridManagerViewExportExcel1.Enabled = false;
					this.SetView(this.gridManagerViewSortByAgregateColumn1.ActualDataView());
					// --
				}
				else
				{
					this.EnableMarkControl(_loader.AllowMarkRow);
					this.EnableColumnsControl(_loader.AllowDefineVisibleColumns);
					this.EnableExportExcelControl(_loader.AllowExportExcel);
					// matias
					this.SetView(this.gridManagerViewSortByAgregateColumn1.ActualDataView());
					// --
				}
			}
		}

		#endregion

		public void MarcarTodos()
		{
				if(_allowMarkColumn)
				gridManagerViewMark1.MarcarTodos();
		}
		
		public void MarcarNinguno()
		{
			if(_allowMarkColumn)
				gridManagerViewMark1.MarcarNinguno();
		}

        //Matias 20100727 - Tarea 21		
        private void grilla_SortKeysChanged(object sender, EventArgs e)
        {
            //Cristian Tarea 921 20101216
            Janus.Windows.GridEX.GridEX grilla = (Janus.Windows.GridEX.GridEX)sender;

            //Fin Tarea 921
            if (_orderCodigoNumerico)
            {
                //Janus.Windows.GridEX.GridEX grilla = (Janus.Windows.GridEX.GridEX)sender;
                Janus.Windows.GridEX.GridEXSortKeyCollection collec = grilla.RootTable.SortKeys;
                ArrayList keys = new ArrayList();
                foreach (Janus.Windows.GridEX.GridEXSortKey elem in collec)
                {
                    if (elem.Column.Key.ToUpper().Equals("CODIGO"))
                    {
                        // Grilla ordenada por codigo (bajo nivel).
                        try
                        {
                            // grilla.DataSource podria contener un DataTable o un DataView.
                            DataTable tabla = new DataTable();
                            if (grilla.DataSource.GetType().Equals(typeof(System.Data.DataTable)))
                                tabla = (DataTable)grilla.DataSource;
                            else
                            {
                                if (grilla.DataSource.GetType().Equals(typeof(System.Data.DataView)))
                                    tabla = (DataTable)((DataView)grilla.DataSource).Table;
                            }
                            // Agregar a la tabla vinculada a la Grilla, si no existe, la nueva columna "CodigoNumericoInterno".
                            if (!tabla.Columns.Contains("CodigoNumericoInterno"))
                            {
                                DataColumn dc = new DataColumn("CodigoNumericoInterno", System.Type.GetType("System.Int32"));
                                tabla.Columns.Add(dc);
                            }
                            foreach (DataRow row in tabla.Rows)
                                row["CodigoNumericoInterno"] = Convert.ToInt32(row["Codigo"]);
                            grilla.SetDataBinding(tabla, null);
                            grilla.RootTable.SortKeys.Clear();
                            Janus.Windows.GridEX.GridEXSortKey sortKey = new Janus.Windows.GridEX.GridEXSortKey(grilla.RootTable.Columns["CodigoNumericoInterno"]);
                            if (_ascendente)//Alterna entre Asc y Desc.
                            {
                                sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending;
                                _ascendente = false;
                            }
                            else
                            {
                                sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Descending;
                                _ascendente = true;
                            }
                            grilla.RootTable.SortKeys.Add(sortKey);
                            grilla.MoveFirst();
                            break;
                        }
                        catch (Exception errorDeConversion)
                        {
                        }
                    }
                }
            }

            //Cristian 20101206 Tarea 921
            _grillaActual = grilla;
             this.SetView(this.updateView());
            //Fin Tarea 921
        }
        //Fin Matias 20100727 - Tarea 21

        //Matias 20101005 - Tarea 898
        public void EnableSaveConfigControl(bool value)
        {
            gridManagerViewSaveConfig1.Visible = value; //Define si va visible o no (Visible solo p perfiles superiores.
        }
        public void ConfigureSaveConfigControl(string ExcludedColumns, string GrillaName)
        {
            gridManagerViewSaveConfig1.Configure(_manager, _loader, ExcludedColumns, _processName, _taskName, GrillaName);
        }
        //FinMatias 20101005 - Tarea 898


    }
}

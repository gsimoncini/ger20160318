using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.commontypes;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de GridManagerViewSortByAgregateColumn.
	/// </summary>
	public class GridManagerViewSortByAgregateColumn : System.Windows.Forms.UserControl, IObservable
	{
		private System.Windows.Forms.CheckBox chkorden;
		
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridManagerViewSortByAgregateColumn()
		{
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
			this.chkorden = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// chkorden
			// 
			this.chkorden.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkorden.Location = new System.Drawing.Point(0, 0);
			this.chkorden.Name = "chkorden";
			this.chkorden.Size = new System.Drawing.Size(216, 23);
			this.chkorden.TabIndex = 1;
			this.chkorden.Text = "Orden x Totales";
			// 
			// GridManagerViewSortByAgregateColumn
			// 
			this.Controls.Add(this.chkorden);
			this.Name = "GridManagerViewSortByAgregateColumn";
			this.Size = new System.Drawing.Size(120, 23);
			this.ResumeLayout(false);

		}
		#endregion
		#region variables privadas
		private IGridManager _manager;
		private GridVariablesLoader _loader;
		private Janus.Windows.GridEX.GridEX _grilla;
		private GridManagerViewSortByAgregateColumnController _controller= new GridManagerViewSortByAgregateColumnController();
		private DataTable _table;
		#endregion

		public DataTable Table
		{
			set
			{
				if(value != null)
				{
					_table = value;
					this.Enabled=(_loader.AllowSortByMergeAgregateColumn && _grilla.RootTable.Groups.Count>0 && _grilla.RecordCount > 0);			
					if(this.chkorden.Checked)
					{
						_controller.DataSourceAnterior=_grilla.DataSource;
						this.chkorden.Checked = false;
					}
				}
			}
		}

		#region metodos publicos
		public void Configure(IGridManager manager, GridVariablesLoader loader, Janus.Windows.GridEX.GridEX grilla) 
		{
			_loader = loader;
			_grilla=grilla;
			this.Enabled=(_loader.AllowSortByMergeAgregateColumn && grilla.RootTable.Groups.Count>0 && grilla.RecordCount > 0);			
			_manager = manager;
			InitEventHandlers();			
		}

		public DataView ActualDataView()
		{
			if (this.chkorden.Checked && _grilla.DataSource!=null)
				return _controller.DataSource.DefaultView;
			else {
				if (_controller.DataSourceAnterior.GetType().Equals(typeof(System.Data.DataTable)))
					return ((DataTable) _controller.DataSourceAnterior).DefaultView;	
			}
			return null;
		}

		#endregion
		private void InitEventHandlers()
		{	
			chkorden.CheckedChanged+=new EventHandler(chkorden_CheckedChanged);
			_grilla.GroupsChanged+=new Janus.Windows.GridEX.GroupsChangedEventHandler(_grilla_GroupsChanged);
			
		}
		#region metodos privados

		#endregion

		private void chkorden_CheckedChanged(object sender, EventArgs e)
		{
			//Aca tiene q ver si chequea o no, si se chequea tomar los datos de mi clase y mostrar esa grilla, sino bindear la grilla al result del controller;
			if (this.chkorden.Checked && _grilla.DataSource!=null)
			{		_controller.DataSourceAnterior=_grilla.DataSource;
					_controller.columnasVisibles(_grilla);
					_controller.nuevoLayout(_grilla, _loader);
					_grilla.GroupByBoxVisible=false;
					_grilla.DataSource=_controller.DataSource;
				
				}
				
			else if (!this.chkorden.Checked && _grilla.DataSource!=null){
					_controller.layoutAnterior(_grilla);
					_grilla.GroupByBoxVisible=_loader.AllowGroup;
					_grilla.DataSource=_controller.DataSourceAnterior;}
			ProcessObjectsObserver();
		}

		private void _grilla_GroupsChanged(object sender, Janus.Windows.GridEX.GroupsChangedEventArgs e)
		{
			if(_grilla.RootTable.Groups.Count==0)
				this.Enabled=false;
			else
				if(_grilla.RecordCount > 0 && _loader.AllowSortByMergeAgregateColumn)
					this.Enabled=true;
		}
		#region Miembros de IObservable

		private ArrayList _observers = new ArrayList();

		public void ProcessObjectsObserver()
		{
			foreach(IObserver observer in _observers)
			{
				observer.UpdateObject(this, this.chkorden.Checked);
			}
		}

		public void AddObjectListener(IObserver observer)
		{
			_observers.Add(observer);
		}
		#endregion
	}
}

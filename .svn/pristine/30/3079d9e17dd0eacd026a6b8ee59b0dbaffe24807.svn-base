using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.forms;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de GridManagerColumns.
	/// </summary>
	public class GridManagerColumns : System.Windows.Forms.UserControl
	{
		private Infragistics.Win.Misc.UltraButton btnColumns;
		private Infragistics.Win.Misc.UltraButton utbGuardar;
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridManagerColumns()
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
			this.btnColumns = new Infragistics.Win.Misc.UltraButton();
			this.utbGuardar = new Infragistics.Win.Misc.UltraButton();
			this.SuspendLayout();
			// 
			// btnColumns
			// 
			this.btnColumns.Location = new System.Drawing.Point(1, 0);
			this.btnColumns.Name = "btnColumns";
			this.btnColumns.TabIndex = 2;
			this.btnColumns.Text = "Columnas";
			// 
			// utbGuardar
			// 
			this.utbGuardar.Location = new System.Drawing.Point(75, 0);
			this.utbGuardar.Name = "utbGuardar";
			this.utbGuardar.TabIndex = 3;
			this.utbGuardar.Text = "Guardar";
			// 
			// GridManagerColumns
			// 
			this.Controls.Add(this.utbGuardar);
			this.Controls.Add(this.btnColumns);
			this.Name = "GridManagerColumns";
			this.Size = new System.Drawing.Size(152, 24);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables privadas

		
		private IGridManager _manager;
		private GridVariablesLoader _loader;
		private ArrayList _gridLayoutProperties = new ArrayList();
		private string _excludedColumns = string.Empty;
		private GridManagerViewColumnsFormDetailController _formDetailController = new GridManagerViewColumnsFormDetailController();
		private string _processName = string.Empty;
		private string _taskName = string.Empty;
		
	

		#endregion

		#region Métodos públicos	
		public void Configure(IGridManager manager, GridVariablesLoader loader, string ExcludedColumns, string ProcessName, string TaskName) 
		{
			_loader = loader;
			_manager = manager;
			_excludedColumns = ExcludedColumns;
			_processName = ProcessName;
			_taskName = TaskName;
			btnColumns.Click +=new EventHandler(btnColumns_Click);
			utbGuardar.Click +=new EventHandler(utbGuardar_Click);

		}
		#endregion

		#region Metodos Privados

		private void btnColumns_Click(object sender, EventArgs e)
		{
			_gridLayoutProperties = _manager.GetLayoutProperties(_excludedColumns);
			_formDetailController.SetObject(_gridLayoutProperties);
			FrmDetail _detailInstance = new FrmDetail();
			_detailInstance.SetController(_formDetailController);
			_detailInstance.ShowModal();
			_manager.SetLayoutProperties(_gridLayoutProperties);
		}


		
		private void utbGuardar_Click(object sender, EventArgs e)
		{
			_gridLayoutProperties = _manager.GetLayoutProperties(_excludedColumns);
			_manager.SaveLayoutProperties(_gridLayoutProperties, _processName, _taskName, _excludedColumns);
		}

		#endregion

	}
}

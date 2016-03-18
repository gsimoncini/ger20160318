using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.forms;
using System.IO;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de GridManagerViewExportExcel.
	/// </summary>
	public class GridManagerViewExportExcel : System.Windows.Forms.UserControl
	{
		private Infragistics.Win.Misc.UltraButton utbExportar;
		private Infragistics.Win.Misc.UltraButton btnFileChooser;
		private System.Windows.Forms.TextBox txtFileName;
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridManagerViewExportExcel()
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
			this.utbExportar = new Infragistics.Win.Misc.UltraButton();
			this.btnFileChooser = new Infragistics.Win.Misc.UltraButton();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// utbExportar
			// 
			this.utbExportar.Location = new System.Drawing.Point(248, 0);
			this.utbExportar.Name = "utbExportar";
			this.utbExportar.Size = new System.Drawing.Size(97, 23);
			this.utbExportar.TabIndex = 5;
			this.utbExportar.Text = "Exportar a Excel";
			// 
			// btnFileChooser
			// 
			this.btnFileChooser.Location = new System.Drawing.Point(0, 0);
			this.btnFileChooser.Name = "btnFileChooser";
			this.btnFileChooser.Size = new System.Drawing.Size(32, 23);
			this.btnFileChooser.TabIndex = 4;
			this.btnFileChooser.Text = "...";
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(31, 2);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(217, 20);
			this.txtFileName.TabIndex = 6;
			this.txtFileName.Text = "";
			// 
			// GridManagerViewExportExcel
			// 
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.utbExportar);
			this.Controls.Add(this.btnFileChooser);
			this.Name = "GridManagerViewExportExcel";
			this.Size = new System.Drawing.Size(344, 24);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables privadas

		
		private IGridManager _manager;
		private GridVariablesLoader _loader;
		private ArrayList _gridLayoutProperties = new ArrayList();
		private string _excludedColumns = string.Empty;
		private string _processName = string.Empty;
		private string _taskName = string.Empty;
		private DataView _table = null;
		private string _fileName = string.Empty;
		private string _separator = string.Empty;
		private bool _canExportToExcel = true;
		private GridManagerViewExportExcelController _uiController = null;
		
	

		#endregion

		public DataView View
		{
			set{_table = value;}
		}

		public DataTable Table
		{
			set
			{
				if(value != null)
				{
					_table = value.DefaultView;
				}
			}
		}

		public void Configure(IGridManager manager, GridVariablesLoader loader, string ExcludedColumns, string ProcessName, string TaskName) 
		{
			_uiController = new GridManagerViewExportExcelController(ProcessName, TaskName);
			_loader = loader;
			_manager = manager;
			_excludedColumns = ExcludedColumns;
			_processName = ProcessName;
			_taskName = TaskName;
			_separator = _uiController.Separator;
			_canExportToExcel = _uiController.CanExportToExcel;
			utbExportar.Click +=new EventHandler(utbExportar_Click);
			btnFileChooser.Click +=new EventHandler(btnFileChooser_Click);
			


		}

		public void ExportToExcel(string fileName)
		{
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			ExportToCSV exporterCSV = new ExportToCSV(_separator);
			ExportToExcel exporter = new ExportToExcel();
			_fileName = fileName;
			string directory = _fileName.Substring(0,_fileName.LastIndexOf(@"\") + 1);
			if(_table != null &&  _fileName != null && !_fileName.Equals(string.Empty) && Directory.Exists(directory))
			{
				_gridLayoutProperties = _manager.GetLayoutProperties(_excludedColumns);
				if (!exporter.IsOpen(_fileName))
				{
					if(_canExportToExcel)
						exporter.Export(_table, _fileName ,"Prueba",_gridLayoutProperties);
					else 
						exporterCSV.Export(_table, _fileName ,_gridLayoutProperties);
				}
				else // else "Archivo abierto...."
				{
					DialogResult result;
					result = MessageBox.Show("El archivo '" + _fileName + "' se encuentra abierto (Para poder exportar los datos el mismo debe estar cerrado). Ciérrelo y vuelva a intentarlo.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Question);					
				}				
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		
		private void utbExportar_Click(object sender, EventArgs e)
		{
			this.ExportToExcel(txtFileName.Text);
		}

		private void btnFileChooser_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 			if(_canExportToExcel)
				saveFileDialog1.Filter = "Excel files (*.xls)|*.xls"  ;
			else
				saveFileDialog1.Filter = "CSV files (*.csv)|*.csv"  ;
			saveFileDialog1.RestoreDirectory = true ;
 			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtFileName.Text = saveFileDialog1.FileName;
			}

		}
	}
}

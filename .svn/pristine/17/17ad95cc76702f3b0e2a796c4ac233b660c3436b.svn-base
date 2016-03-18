using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de GridManagerMark.
	/// </summary>
	public class GridManagerViewMark : System.Windows.Forms.UserControl
	{
		private Infragistics.Win.Misc.UltraButton bNinguno;
		private Infragistics.Win.Misc.UltraButton bTodos;
		private Infragistics.Win.Misc.UltraButton bInvertir;
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridManagerViewMark()
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
			this.bNinguno = new Infragistics.Win.Misc.UltraButton();
			this.bTodos = new Infragistics.Win.Misc.UltraButton();
			this.bInvertir = new Infragistics.Win.Misc.UltraButton();
			this.SuspendLayout();
			// 
			// bNinguno
			// 
			this.bNinguno.Location = new System.Drawing.Point(24, 0);
			this.bNinguno.Name = "bNinguno";
			this.bNinguno.Size = new System.Drawing.Size(24, 23);
			this.bNinguno.TabIndex = 0;
			this.bNinguno.Text = "N";
			// 
			// bTodos
			// 
			this.bTodos.Location = new System.Drawing.Point(0, 0);
			this.bTodos.Name = "bTodos";
			this.bTodos.Size = new System.Drawing.Size(24, 23);
			this.bTodos.TabIndex = 1;
			this.bTodos.Text = "T";
			// 
			// bInvertir
			// 
			this.bInvertir.Location = new System.Drawing.Point(48, 0);
			this.bInvertir.Name = "bInvertir";
			this.bInvertir.Size = new System.Drawing.Size(24, 23);
			this.bInvertir.TabIndex = 2;
			this.bInvertir.Text = "I";
			// 
			// GridManagerViewMark
			// 
			this.Controls.Add(this.bNinguno);
			this.Controls.Add(this.bTodos);
			this.Controls.Add(this.bInvertir);
			this.Name = "GridManagerViewMark";
			this.Size = new System.Drawing.Size(72, 24);
			this.ResumeLayout(false);

		}
		#endregion




		#region Variables privadas

		private string _columnName = "";
		private IGridManager _manager;
		private GridVariablesLoader _loader;
		#endregion
		
		#region Métodos públicos	
		public void Configure(IGridManager manager, GridVariablesLoader loader, string ColumnName) 
		{
			_columnName = ColumnName;
			_manager = manager;
			_loader = loader;
			InitEventHandlers();			
		}

		
		public void MarcarTodos()
		{
			_manager.SetValue(_columnName, "true", null);
		}
		
		public void MarcarNinguno()
		{
			_manager.SetValue(_columnName, "false", null);
		}
		#endregion

		#region Métodos privados
		private void InitEventHandlers()
		{
			bTodos.Click+=new EventHandler(bTodos_Click);
			bNinguno.Click+=new EventHandler(bNinguno_Click);
			bInvertir.Click+=new EventHandler(bInvertir_Click);			
		}
		private void bTodos_Click(object sender, System.EventArgs e)
		{
			bTodos.Cursor = Cursors.WaitCursor;			
			_manager.SetValue(_columnName, "true", null);		

			bTodos.Cursor = Cursors.Default;			
		}

		private void bNinguno_Click(object sender, System.EventArgs e)
		{
			bTodos.Cursor = Cursors.WaitCursor;			
			_manager.SetValue(_columnName, "false", null);				
			bTodos.Cursor = Cursors.Default;			
		}

		private void bInvertir_Click(object sender, System.EventArgs e)
		{
			bTodos.Cursor = Cursors.WaitCursor;			
			_manager.InvertValue(_columnName);		
			bTodos.Cursor = Cursors.Default;			
		}
		#endregion
	}
}

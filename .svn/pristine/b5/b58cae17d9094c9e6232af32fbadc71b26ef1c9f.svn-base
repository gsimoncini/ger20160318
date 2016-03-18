using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de /*20110328 - Tarea 0000057*/ FrmShowErrors.
	/// </summary>
	public class /*20110328 - Tarea 0000057*/ FrmShowRowError : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private Janus.Windows.GridEX.GridEX gridDetail;
		private Janus.Windows.GridEX.GridEX gridGlobal;

		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridDetail = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridGlobal = new Janus.Windows.GridEX.GridEX();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDetail)).BeginInit();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridGlobal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.BackColor = System.Drawing.Color.Transparent;
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridDetail);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(631, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridDetail
			// 
			this.gridDetail.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDetail.GroupByBoxVisible = false;
			this.gridDetail.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridDetail.Location = new System.Drawing.Point(0, 0);
			this.gridDetail.Name = "gridDetail";
			this.gridDetail.Size = new System.Drawing.Size(631, 150);
			this.gridDetail.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridGlobal);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 258);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(631, 150);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// gridGlobal
			// 
			this.gridGlobal.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridGlobal.GroupByBoxVisible = false;
			this.gridGlobal.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridGlobal.Location = new System.Drawing.Point(0, 0);
			this.gridGlobal.Name = "gridGlobal";
			this.gridGlobal.Size = new System.Drawing.Size(631, 150);
			this.gridGlobal.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(328, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Se han detectado problemas";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Errores asociados a elementos del conjunto de datos";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Errores asociados al conjunto de datos";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(680, 461);
			this.ultraExplorerBar1.TabIndex = 2;
			// 
			// /*20110328 - Tarea 0000057*/ FrmShowErrors
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 461);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.label1);
			this.Name = "/*20110328 - Tarea 0000057*/ FrmShowErrors";
			this.Text = "Problemas al intentar almacenar información";
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDetail)).EndInit();
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridGlobal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		#region Custom Members
		private DatasetErrors Errores;
		private /*20110328 - Tarea 0000057*/ FrmShowRowError( ItemsDatasetErrors errores )
		{
			InitializeComponent();
			Errores = new mz.erp.businessrules.DatasetErrors( errores );
			Init();
		}
        private /*20110328 - Tarea 0000057*/ FrmShowRowError(System.Data.DataRow row)
		{
			InitializeComponent();
			Errores = new mz.erp.businessrules.DatasetErrors( row );
			Init();
		}

		private void gridGlobal_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}

        private /*20110328 - Tarea 0000057*/ FrmShowRowError(System.Data.DataTable table)
		{
			InitializeComponent();
			Errores = new mz.erp.businessrules.DatasetErrors( table );
			Init();
		}

        private /*20110328 - Tarea 0000057*/ FrmShowRowError(System.Data.DataSet dataset)
		{
			InitializeComponent();
			Errores = new mz.erp.businessrules.DatasetErrors( dataset );
			Init();
			
		}

		private void Init()
		{
			gridDetail.SetDataBinding( Errores.DetailErrors,null);
			gridGlobal.SetDataBinding( Errores.GlobalErrors,null);
			gridDetail.LayoutData = mz.erp.ui.forms.classes.Errores.GetLayoutErrores();
			gridGlobal.LayoutData = mz.erp.ui.forms.classes.Errores.GetLayoutErrores();
			

		}

		public void ShowForm()
		{
			this.MdiParent = utility.Environment.MainForm;
			this.Show();
			
		}
	#endregion 
		
	}
}

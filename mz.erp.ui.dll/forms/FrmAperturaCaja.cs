using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.ui;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAperturaCaja.
	/// </summary>
	public class FrmAperturaCaja : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Janus.Windows.GridEX.GridEX gridStandar;
		private System.ComponentModel.IContainer components;
		private tfi_InstanciasCajaExDataset.tfi_InstanciasCajaRow _row;

		public FrmAperturaCaja()
		{
			System.Data.DataTable table;
			InitializeComponent();
			mz.erp.ui.forms.classes.tfi_Cajas sourceUI= new mz.erp.ui.forms.classes.tfi_Cajas();
			this.gridStandar.LayoutData = sourceUI.GetLayoutApertura();
			if (Variables.GetValueBool("Cajas.Seguridad.PermiteAperturaConTransporteDeSaldo"))
			{
				
				if(!Security.CajasNivelControlAlto)
				{
					bool TodasLasCajas = Variables.GetValueBool("Cajas.Seguridad.PermiteAperturaPorTodosLosResponsables.TodasLasCajas", true);
					string cajas = null;
					if(!TodasLasCajas)
						cajas = Variables.GetValueString("Cajas.Seguridad.PermiteAperturaPorTodosLosResponsables.Cajas");
					table =  mz.erp.businessrules.tfi_Cajas.GetByResponsableTodasLasCajasConAperturaConSaldo(Security.IdPersona, cajas);
				}
				else
					table = mz.erp.businessrules.tfi_Cajas.GetByResponsableConAperturaConSaldo(Security.IdPersona);
			}
			else
			{
				if(!Security.CajasNivelControlAlto)
				{
					bool TodasLasCajas = Variables.GetValueBool("Cajas.Seguridad.PermiteAperturaPorTodosLosResponsables.TodasLasCajas", true);
					string cajas = null;
					if(!TodasLasCajas)
						cajas = Variables.GetValueString("Cajas.Seguridad.PermiteAperturaPorTodosLosResponsables.Cajas");
					table =  mz.erp.businessrules.tfi_Cajas.GetByResponsableTodasLasCajas(Security.IdPersona, cajas);
				}
				else
				table = (System.Data.DataTable)mz.erp.businessrules.tfi_Cajas.GetList(Security.IdPersona).Pr_tfi_Cajas_GetByResponsable;
			}
			this.gridStandar.DataSource = table;
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAperturaCaja));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridStandar = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridStandar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridStandar);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(623, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// gridStandar
			// 
			this.gridStandar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.gridStandar.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridStandar.AlternatingColors = true;
			this.gridStandar.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridStandar.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridStandar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStandar.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			//this.gridStandar.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridStandar.FilterMode = Janus.Windows.GridEX.FilterMode.None;
			this.gridStandar.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridStandar.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridStandar.GroupByBoxVisible = false;
			this.gridStandar.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridStandar.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridStandar.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridStandar.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridStandar.Location = new System.Drawing.Point(0, 0);
			this.gridStandar.Name = "gridStandar";
			this.gridStandar.RecordNavigator = true;
			this.gridStandar.RecordNavigatorText = "Registro:|de";
			this.gridStandar.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridStandar.Size = new System.Drawing.Size(623, 150);
			this.gridStandar.TabIndex = 1;
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
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.toolBarButton4,
																							  this.toolBarButton5,
																							  this.toolBarButton6});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(672, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 6;
			this.toolBarButton6.Tag = "";
			this.toolBarButton6.Text = "Abrir Caja";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Apertura de caja";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(672, 329);
			this.ultraExplorerBar1.TabIndex = 18;
			// 
			// FrmAperturaCaja
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(672, 357);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAperturaCaja";
			this.Text = "Apertura de caja";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridStandar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	




		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					gridStandar.MoveFirst();
					break;

				case 1:
					gridStandar.MovePrevious();
					break;

				case 2:
					gridStandar.MoveNext();
					break;

				case 3:
					gridStandar.MoveLast();
					break;

				case 5:
					
					AbrirCaja();
					break;					
				
			}
	
			
		}	
		protected void Evaluate()
		{			
			if (_row.Table.HasErrors)
			{
				/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(_row);
				_form.Show();
				//_row.RejectChanges();
			}
			else
			{
				MessageBox.Show("La acción se ha ejecutado con éxito");
				Close();
			}
		}
		private void AbrirCaja()
		{			
			if ( (this.gridStandar.SelectedItems.Count > 0) && (this.gridStandar.SelectedItems[0].RowType.Equals(Janus.Windows.GridEX.RowType.Record)) )
			{	
				string IdCaja = Convert.ToString(gridStandar.SelectedItems[0].GetRow().Cells["IdCaja"].Value);
				string IdInstanciaCaja = Convert.ToString(this.gridStandar.SelectedItems[0].GetRow().Cells["IdInstanciaCaja"].Value);
				
				if (Variables.GetValueBool("Cajas.Seguridad.PermiteAperturaConTransporteDeSaldo"))
				{
					string poseeValores = Convert.ToString(this.gridStandar.SelectedItems[0].GetRow().Cells["Con Saldo"].Value);
					_row = mz.erp.businessrules.tfi_InstanciasCaja.AbrirCajaConSaldo(IdCaja, IdInstanciaCaja, poseeValores.ToUpper().Equals("SI"));
				}
				else 
				{
					_row = mz.erp.businessrules.tfi_InstanciasCaja.AbrirCaja(IdCaja);
				}
				if (_row != null)  
					Evaluate();
			}
			else MessageBox.Show("Debe seleccionar una Caja ");
		}
	}
}

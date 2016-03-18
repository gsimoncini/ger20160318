using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using System.Data;
using mz.erp.ui.controls;
using mz.erp.commontypes;
using System.Text;
using mz.erp.ui.controllers;
using mz.erp.ui;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmViewer.
	/// </summary>
	public class FrmConsultaCajaDetalle : System.Windows.Forms.Form, ITaskForm	
	{
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components;
		private Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		protected System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbMedioDePago;
		private System.Windows.Forms.ComboBox cmbCaja;
		private System.Windows.Forms.ComboBox cmbUsuarios;
		private mz.erp.ui.controllers.ConsultasCajaController _uiController;
		public FrmConsultaCajaDetalle(mz.erp.ui.controllers.ConsultasCajaController uiController)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
			_uiController = uiController;
			_uiController.ObjectHasChanged+= new System.EventHandler( this.ListenerControllerChanges );
			KeyDownManager KeyDown = new KeyDownManager(this);
			
			
			/*gridCajas.LayoutData = _uiController.LayoutFiltroCajas;
			gridTipos.LayoutData = _uiController.LayoutFiltroTipos;
			gridUsuarios.LayoutData = _uiController.LayoutFiltroUsuarios;
			gridResultado.LayoutData = _uiController.LayoutFiltroResultado;
			
			gridCajas.DataBindings.Clear();
			gridCajas.SetDataBinding( _uiController.FiltroCajas , null );
			
			gridTipos.DataBindings.Clear();
			gridTipos.SetDataBinding( _uiController.FiltroTipos , null );
			
			gridUsuarios.DataBindings.Clear();
			gridUsuarios.SetDataBinding( _uiController.FiltroUsuarios , null );
			
			BindingController.Bind( dtFechaApertura,"Value",_uiController,"FechaApertura");
			BindingController.Bind( dtFechaCierre,"Value",_uiController,"FechaCierre");

			//dtFechaApertura.DataBindings.Add("Value",_uiController,"FechaApertura");
			//dtFechaCierre.DataBindings.Add("Value",_uiController,"FechaCierre");
			dtFechaApertura.DataBindings.Add( "Enabled", _uiController, "AllowEditFechaApertura");
			dtFechaCierre.DataBindings.Add( "Enabled", _uiController, "AllowEditFechaCierre");
			cbSoloAbiertas.DataBindings.Add( "Checked", _uiController, "SoloAbiertas");
			*/
			
			
		}
		private void Reset()
		{
			for(int i=0;i<_uiController.FiltroCajas.Count;i++)
			{
				((ItemsFiltros)_uiController.FiltroCajas[i]).Sel= false;
			}
			for(int i=0;i<_uiController.FiltroTDCompTesoreria.Count;i++)
			{
				((ItemsFiltros)_uiController.FiltroTDCompTesoreria[i]).Sel= false;
			}
			for(int i=0;i<_uiController.FiltroUsuarios.Count;i++)
			{
				((ItemsFiltros)_uiController.FiltroUsuarios[i]).Sel= false;
			}

		}
		private void Build_Ui()
		{
			Reset();
			for(int i=0;i<_uiController.FiltroCajas.Count;i++)
			{
				((ItemsFiltros)_uiController.FiltroCajas[i]).Sel= false;
				this.cmbCaja.Items.Add( ((ItemsFiltros)_uiController.FiltroCajas[i]).Descripcion );
			}
			for(int i=0;i<_uiController.FiltroTDCompTesoreria.Count;i++)
			{
				((ItemsFiltros)_uiController.FiltroTDCompTesoreria[i]).Sel= false;
				this.cmbMedioDePago.Items.Add( ((ItemsFiltros)_uiController.FiltroTDCompTesoreria[i]).Descripcion );
			}
			for(int i=0;i<_uiController.FiltroUsuarios.Count;i++)
			{
				((ItemsFiltros)_uiController.FiltroUsuarios[i]).Sel= false;
				this.cmbUsuarios.Items.Add( ((ItemsFiltros)_uiController.FiltroUsuarios[i]).Descripcion );
			}

			if (this.cmbCaja.Items.Count > 0)
			{
				this.cmbCaja.SelectedIndex = 0;
			}
			if (this.cmbUsuarios.Items.Count > 0)
			{
				this.cmbUsuarios.SelectedIndex = 0;
			}
			if (this.cmbMedioDePago.Items.Count> 0)
			{
				this.cmbMedioDePago.SelectedIndex = 0;
			}
			KeyPreview = true;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultaCajaDetalle));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.cmbMedioDePago = new System.Windows.Forms.ComboBox();
			this.cmbCaja = new System.Windows.Forms.ComboBox();
			this.cmbUsuarios = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cmbMedioDePago);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cmbCaja);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.cmbUsuarios);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -67);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(962, 87);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// cmbMedioDePago
			// 
			this.cmbMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMedioDePago.Location = new System.Drawing.Point(112, 57);
			this.cmbMedioDePago.Name = "cmbMedioDePago";
			this.cmbMedioDePago.Size = new System.Drawing.Size(304, 21);
			this.cmbMedioDePago.TabIndex = 2;
			// 
			// cmbCaja
			// 
			this.cmbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCaja.Location = new System.Drawing.Point(112, 32);
			this.cmbCaja.Name = "cmbCaja";
			this.cmbCaja.Size = new System.Drawing.Size(304, 21);
			this.cmbCaja.TabIndex = 1;
			// 
			// cmbUsuarios
			// 
			this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUsuarios.Location = new System.Drawing.Point(112, 6);
			this.cmbUsuarios.Name = "cmbUsuarios";
			this.cmbUsuarios.Size = new System.Drawing.Size(304, 21);
			this.cmbUsuarios.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Medio de Pago";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Caja";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuario";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 79);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(962, 422);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridResultado
			// 
			this.gridResultado.BlendColor = System.Drawing.Color.DarkMagenta;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 0);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.ShowErrors = false;
			this.gridResultado.Size = new System.Drawing.Size(962, 422);
			this.gridResultado.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.toolBarStandar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 24);
			this.panel1.TabIndex = 2;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.toolBarButton7,
																							  this.toolBarButton8,
																							  this.toolBarButton9,
																							  this.toolBarButton10,
																							  this.toolBarButton11,
																							  this.toolBarButton12});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(1028, 28);
			this.toolBarStandar.TabIndex = 20;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.Enabled = false;
			this.tbbAnterior.ImageIndex = 10;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 11;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.ImageIndex = 0;
			this.toolBarButton7.Visible = false;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 1;
			this.toolBarButton8.Visible = false;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 2;
			this.toolBarButton9.Visible = false;
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 3;
			this.toolBarButton10.Visible = false;
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.ImageIndex = 2;
			this.toolBarButton12.Text = "Ejecutar Consulta [F5]";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 87;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Filtros";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 422;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Resultado";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 24);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(1028, 526);
			this.ultraExplorerBar1.TabIndex = 3;
			// 
			// FrmConsultaCajaDetalle
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 550);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.panel1);
			this.Name = "FrmConsultaCajaDetalle";
			this.Text = "FrmConsultaCaja";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region custom members
		private void RefreshData()
		{
			gridResultado.LayoutData = _uiController.LayoutFiltroResultado;
			gridResultado.SetDataBinding( null, null);
			gridResultado.SetDataBinding( _uiController.Data, "Result" );
			gridResultado.Refetch();
			if (_uiController.Data.Tables.Count > 0)
			{
				if (_uiController.Data.Tables[0].Rows.Count == 0)
					System.Windows.Forms.MessageBox.Show( "No hay datos para los filtros seleccionados", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
			}
			else
			{
					System.Windows.Forms.MessageBox.Show( "No hay datos para los filtros seleccionados", "Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
			}

		}
		private void ListenerControllerChanges( object sender, System.EventArgs e)
		{
			
		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			//_uiController.Execute;
		}
		#region Miembros de ITaskForm

		public void ShowForm()
		{
			base.Show();
		}

		public void CloseForm()
		{			
			Close();
		}

		public void KeyDownPrevious()
		{
			Previous();
		}

		public void KeyDownNext()
		{
			Execute();
		}

		public void Execute()
		{
			_uiController.Execute();
		}
		public void Previous()
		{
			_uiController.Previous();
		}
		#endregion

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					Previous();
					break;
				case 2:
					Execute();
					break;
				case 8:
					ExecuteQuery();
					break;
			}		
		}
		private void ExecuteQuery()
		{
			this.Cursor = Cursors.WaitCursor;			
			Reset();
			((ItemsFiltros)_uiController.FiltroTDCompTesoreria[ this.cmbMedioDePago.SelectedIndex]).Sel = true;
			((ItemsFiltros)_uiController.FiltroCajas[this.cmbCaja.SelectedIndex]).Sel = true;
			((ItemsFiltros)_uiController.FiltroUsuarios[this.cmbUsuarios.SelectedIndex]).Sel = true;
			_uiController.RefreshData();
			this.RefreshData();
			this.Cursor = Cursors.Default;

		}

	

	
	}
}

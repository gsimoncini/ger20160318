using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultarLibroIVA.
	/// </summary>
	public class FrmConsultarLibroIVA : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbConsultar;
		private System.Windows.Forms.ToolBarButton tbbSeparator3;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label lblTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private HtmlRichText.HtmlRichTextBox richInfoComprobante;
		private System.ComponentModel.IContainer components;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit PeriodoDesde;
		private Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit PeriodoHasta;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.Windows.Forms.ToolBarButton tbbSeparador11;

		private ConsultarLibroIVAController _uiController;

		public FrmConsultarLibroIVA(ConsultarLibroIVAController UIController)
		{
			_uiController = UIController;
			InitializeComponent();

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
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultarLibroIVA));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.lblTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.PeriodoHasta = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.PeriodoDesde = new Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.richInfoComprobante = new HtmlRichText.HtmlRichTextBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbConsultar = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparador11 = new System.Windows.Forms.ToolBarButton();
			this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ContainerFiltro.SuspendLayout();
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.lblTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(886, 28);
			this.ultraExplorerBarContainerControl4.TabIndex = 2;
			// 
			// lblTarea
			// 
			this.lblTarea.BackColor = System.Drawing.Color.Transparent;
			this.lblTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTarea.Location = new System.Drawing.Point(0, 0);
			this.lblTarea.Name = "lblTarea";
			this.lblTarea.Size = new System.Drawing.Size(886, 23);
			this.lblTarea.TabIndex = 2;
			this.lblTarea.Text = "Tarea";
			this.lblTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContainerFiltro
			// 
			this.ContainerFiltro.Controls.Add(this.PeriodoHasta);
			this.ContainerFiltro.Controls.Add(this.PeriodoDesde);
			this.ContainerFiltro.Controls.Add(this.label7);
			this.ContainerFiltro.Controls.Add(this.label6);
			this.ContainerFiltro.Location = new System.Drawing.Point(28, 111);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(886, 50);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// PeriodoHasta
			// 
			appearance1.TextHAlign = Infragistics.Win.HAlign.Right;
			this.PeriodoHasta.Appearance = appearance1;
			this.PeriodoHasta.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.PeriodoHasta.InputMask = "mm/yyyy";
			this.PeriodoHasta.Location = new System.Drawing.Point(96, 24);
			this.PeriodoHasta.Name = "PeriodoHasta";
			this.PeriodoHasta.Size = new System.Drawing.Size(88, 20);
			this.PeriodoHasta.TabIndex = 1;
			this.PeriodoHasta.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.PeriodoHasta.Text = "--";
			// 
			// PeriodoDesde
			// 
			appearance2.TextHAlign = Infragistics.Win.HAlign.Right;
			this.PeriodoDesde.Appearance = appearance2;
			this.PeriodoDesde.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask;
			this.PeriodoDesde.InputMask = "mm/yyyy";
			this.PeriodoDesde.Location = new System.Drawing.Point(96, 0);
			this.PeriodoDesde.Name = "PeriodoDesde";
			this.PeriodoDesde.Size = new System.Drawing.Size(88, 20);
			this.PeriodoDesde.TabIndex = 0;
			this.PeriodoDesde.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
			this.PeriodoDesde.Text = "--";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 21);
			this.label7.TabIndex = 114;
			this.label7.Tag = "FechaDesde";
			this.label7.Text = "Período Desde";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 8;
			this.label6.Tag = "FechaHasta";
			this.label6.Text = "Período Hasta";
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl3.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 220);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(886, 296);
			this.ultraExplorerBarContainerControl3.TabIndex = 1;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 24);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(886, 272);
			this.gridResultado.TabIndex = 0;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(0, 0);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(864, 24);
			this.gridManagerView1.TabIndex = 119;
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.richInfoComprobante);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 386);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(886, 150);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			this.ultraExplorerBarContainerControl5.Visible = false;
			// 
			// richInfoComprobante
			// 
			this.richInfoComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richInfoComprobante.Location = new System.Drawing.Point(0, 0);
			this.richInfoComprobante.Name = "richInfoComprobante";
			this.richInfoComprobante.Size = new System.Drawing.Size(886, 150);
			this.richInfoComprobante.TabIndex = 0;
			this.richInfoComprobante.Text = "";
			// 
			// imglStandar
			// 
			this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.tbbSeparator2,
																							  this.tbbConsultar,
																							  this.tbbSeparador11,
																							  this.tbbReiniciarFiltros,
																							  this.tbbSeparator3,
																							  this.tbbCancelar,
																							  this.toolBarButton2});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(952, 28);
			this.toolBarStandar.TabIndex = 22;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbConsultar
			// 
			this.tbbConsultar.ImageIndex = 2;
			this.tbbConsultar.Text = "Ejecutar Consulta[F5]";
			// 
			// tbbSeparador11
			// 
			this.tbbSeparador11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbReiniciarFiltros
			// 
			this.tbbReiniciarFiltros.ImageIndex = 5;
			this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
			// 
			// tbbSeparator3
			// 
			this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ContainerFiltro);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Key = "Tarea";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 28;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ContainerFiltro;
			ultraExplorerBarGroup2.Key = "FiltroInicial";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 50;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtro Inicial";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup3.Key = "Resultado";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 296;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			ultraExplorerBarGroup4.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup4.Key = "Detalle";
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Detalle";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(952, 418);
			this.ultraExplorerBar1.TabIndex = 23;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmConsultarLibroIVA
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(952, 446);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmConsultarLibroIVA";
			this.Text = "FrmConsultarLibroIVA";
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ContainerFiltro.ResumeLayout(false);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

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
				this.Show();
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
			if (_uiController.PreguntarAlCancelar)
			{
				if ((MessageBox.Show(this,"Está a punto de cerrar el fomulario. Realmente desea realizar esta operación?","Atención!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
					Close();
			}
			else
			{
				Close();
			}
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			_uiController.Execute();
		}

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
			this.Text = _uiController.LeyendaFormulario;
			this.lblTarea.Text = _uiController.LeyendaFormulario;
			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), gridResultado, this.Text);
			this.KeyPreview = true;
		}

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					_uiController.Execute();
					break;
				case 4:					
					RefreshData();
					break;
				case 6:					
					ResetFilters();
					break;
				case 8:
					CloseForm();
					break;
				
			}				
		}

		private void ResetFilters()
		{
			PeriodoDesde.Value=string.Empty;
			PeriodoHasta.Value=string.Empty;
			
			gridResultado.SetDataBinding(null, null);
			gridResultado.Refresh();
		}

		public bool IsValidPeriodo()
		{
			string perDesde = Convert.ToString(PeriodoDesde.Value);
			string perHasta = Convert.ToString(PeriodoHasta.Value);
			if( perDesde == null ||perDesde == string.Empty || perHasta == null ||perHasta == string.Empty)
				return false;
	

			string[] mesAñoDesde = perDesde.Split(new char[]{'/'});
			int MesDesde = 0;
			int AñoDesde = 0;
			if(mesAñoDesde.Length == 2)
			{
				MesDesde = Convert.ToInt32(mesAñoDesde[0]);
				if(!(MesDesde >=1 && MesDesde <= 12))
					return false;
			} else return false;

			string[] mesAñoHasta= perHasta.Split(new char[]{'/'});
			int MesHasta = 0;
			int AñoHasta = 0;
			if(mesAñoHasta.Length == 2)
			{
				MesHasta = Convert.ToInt32(mesAñoHasta[0]);
				if(!(MesHasta >=1 && MesHasta <= 12))
					return false;
			} 
			else return false;
			return true;

		}
		protected void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);
			if(IsValidPeriodo())
			{
				this.Cursor = Cursors.WaitCursor;
				gridResultado.Focus();
				this.DumpControls();	
				//German 20090420
				System.Data.DataTable table = _uiController.RefreshData();
				gridResultado.DataSource = table;
                gridManagerView1.SetTable(table);
				//Fin German 20090420
				if(gridResultado.RecordCount > 0)
				{
					gridResultado.Row = 0;
				}
				this.Cursor = Cursors.Default;
			}
			else MessageBox.Show("El Período a consultar en inválido", "Período Inválido", System.Windows.Forms.MessageBoxButtons.OK);
		}

		private void DumpControls()
		{
			_uiController.FechaDesde = Convert.ToString(PeriodoDesde.Value);
			_uiController.FechaHasta = Convert.ToString(PeriodoHasta.Value);
		}


		private void InitializeData()
		{
			PeriodoDesde.Value = _uiController.FechaDesde;
			PeriodoHasta.Value = _uiController.FechaHasta;
		}
		private void InitEventHandlers()
		{			
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			this.KeyDown +=new KeyEventHandler(KeyDownBehavior);
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
		}	

		private void KeyDownBehavior(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.F5 :
					this.RefreshData();
					break;
			}
		}
	


	
		private void InitDataBindings()
		{				
		}
		
		#endregion

		#endregion
	}
}

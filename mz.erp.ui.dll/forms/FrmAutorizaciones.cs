using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAutorizaciones.
	/// </summary>
	public class FrmAutorizaciones : System.Windows.Forms.Form, ITaskForm
	{
		private System.ComponentModel.IContainer components;

		public FrmAutorizaciones()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmAutorizaciones(controllers.AutorizarController controller)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			
			InitializeComponent();
			_uiController = controller;	
			Init();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAutorizaciones));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.container = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.htmlRichTextBox1 = new HtmlRichText.HtmlRichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.gridSolicitudes = new Janus.Windows.GridEX.GridEX();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbFirst = new System.Windows.Forms.ToolBarButton();
			this.tbPrev = new System.Windows.Forms.ToolBarButton();
			this.tbNext = new System.Windows.Forms.ToolBarButton();
			this.tbLast = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbActualizar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbDesautorizar = new System.Windows.Forms.ToolBarButton();
			this.tbAutorizar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// container
			// 
			this.container.BackColor = System.Drawing.Color.Transparent;
			this.container.Controls.Add(this.htmlRichTextBox1);
			this.container.Controls.Add(this.label2);
			this.container.Controls.Add(this.label1);
			this.container.Controls.Add(this.txtObservaciones);
			this.container.Controls.Add(this.gridSolicitudes);
			this.container.Location = new System.Drawing.Point(28, 49);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(839, 431);
			this.container.TabIndex = 0;
			// 
			// htmlRichTextBox1
			// 
			this.htmlRichTextBox1.Location = new System.Drawing.Point(80, 168);
			this.htmlRichTextBox1.Name = "htmlRichTextBox1";
			this.htmlRichTextBox1.Size = new System.Drawing.Size(752, 256);
			this.htmlRichTextBox1.TabIndex = 1;
			this.htmlRichTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 87;
			this.label2.Text = "Observaciones";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 86;
			this.label1.Text = "Datos";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.BackColor = System.Drawing.SystemColors.Window;
			this.txtObservaciones.Location = new System.Drawing.Point(80, 112);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(752, 48);
			this.txtObservaciones.TabIndex = 0;
			this.txtObservaciones.Text = "";
			// 
			// gridSolicitudes
			// 
			this.gridSolicitudes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridSolicitudes.AlternatingColors = true;
			this.gridSolicitudes.AutomaticSort = false;
			this.gridSolicitudes.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridSolicitudes.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridSolicitudes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridSolicitudes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridSolicitudes.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridSolicitudes.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridSolicitudes.GroupByBoxVisible = false;
			this.gridSolicitudes.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridSolicitudes.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridSolicitudes.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridSolicitudes.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridSolicitudes.Location = new System.Drawing.Point(0, 0);
			this.gridSolicitudes.Name = "gridSolicitudes";
			this.gridSolicitudes.RecordNavigator = true;
			this.gridSolicitudes.RecordNavigatorText = "Registro:|de";
			this.gridSolicitudes.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridSolicitudes.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridSolicitudes.ShowEmptyFields = false;
			this.gridSolicitudes.Size = new System.Drawing.Size(832, 104);
			this.gridSolicitudes.TabIndex = 80;
			this.gridSolicitudes.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbFirst,
																							  this.tbPrev,
																							  this.tbNext,
																							  this.tbLast,
																							  this.toolBarButton5,
																							  this.tbActualizar,
																							  this.toolBarButton7,
																							  this.tbDesautorizar,
																							  this.tbAutorizar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(888, 28);
			this.toolBarStandar.TabIndex = 78;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick_1);
			// 
			// tbFirst
			// 
			this.tbFirst.ImageIndex = 0;
			this.tbFirst.Visible = false;
			// 
			// tbPrev
			// 
			this.tbPrev.ImageIndex = 1;
			this.tbPrev.Visible = false;
			// 
			// tbNext
			// 
			this.tbNext.ImageIndex = 2;
			this.tbNext.Visible = false;
			// 
			// tbLast
			// 
			this.tbLast.ImageIndex = 3;
			this.tbLast.Visible = false;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.toolBarButton5.Visible = false;
			// 
			// tbActualizar
			// 
			this.tbActualizar.ImageIndex = 5;
			this.tbActualizar.Text = "Actualizar";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbDesautorizar
			// 
			this.tbDesautorizar.ImageIndex = 7;
			this.tbDesautorizar.Text = "&Desautorizar";
			// 
			// tbAutorizar
			// 
			this.tbAutorizar.ImageIndex = 4;
			this.tbAutorizar.Text = "&Autorizar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.container);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.container;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 431;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Información";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(888, 506);
			this.ultraExplorerBar1.TabIndex = 81;
			// 
			// FrmAutorizaciones
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(888, 534);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAutorizaciones";
			this.Text = "FrmAutorizaciones";
			this.container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSolicitudes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ImageList imageList1;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		protected System.Windows.Forms.ToolBarButton tbFirst;
		protected System.Windows.Forms.ToolBarButton tbPrev;
		protected System.Windows.Forms.ToolBarButton tbNext;
		protected System.Windows.Forms.ToolBarButton tbLast;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		protected System.Windows.Forms.ToolBarButton tbActualizar;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl container;
		private Janus.Windows.GridEX.GridEX gridSolicitudes;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		protected System.Windows.Forms.ToolBarButton tbAutorizar;
		protected System.Windows.Forms.ToolBarButton tbDesautorizar;
		private HtmlRichText.HtmlRichTextBox htmlRichTextBox1;
	
		private controllers.AutorizarController _uiController;

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
			Show();
		}

		public void CloseForm()
		{
			if (_uiController.IsValid) 
			{				
				Close();
			}
		}


		public void KeyDownPrevious()
		{
		}

		public void KeyDownNext()
		{
		}

		private void Init() 
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitDataBindings();	
			ChangeDatos();			
		}
		private void ConfigureInterface() 
		{
			this.Text = "Autorizaciones";
			this.htmlRichTextBox1.ReadOnly = true;
		}
		private void InitEventHandlers()
		{
			gridSolicitudes.Click+=new EventHandler(gridSolicitudes_Click);
			gridSolicitudes.SelectionChanged+=new EventHandler(gridSolicitudes_Click);
			this.KeyPreview = true;
			this.KeyDown+=new KeyEventHandler(FrmAutorizaciones_KeyDown);
			gridSolicitudes.KeyPress+=new KeyPressEventHandler(gridSolicitudes_KeyPress);

			
		}
		private void InitializeData() 
		{			
			gridSolicitudes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridSolicitudes.LayoutData = mz.erp.ui.forms.classes.tsh_Autorizaciones.GetLayoutSolicitudes();
			_uiController.GetSolicitudes();
		}
		private void InitDataBindings() 
		{
			txtObservaciones.DataBindings.Add("Text", _uiController, "Observaciones");				
			gridSolicitudes.SetDataBinding(_uiController.Solicitudes, null);
		}

		private void gridSolicitudes_Click(object sender, EventArgs e)
		{			
			ChangeDatos();	
		}
			
		private void ChangeDatos()
		{
			if (gridSolicitudes.SelectedItems.Count == 1)
			{
				string IdAutorizacion = (string)gridSolicitudes.SelectedItems[0].GetRow().Cells["IdAutorizacion"].Value;			
				string datos = _uiController.GetDatos(IdAutorizacion);				
				txtObservaciones.Text = _uiController.GetObservaciones(IdAutorizacion);
				/*string [] partes = datos.Split(';');
				txtDatos.Lines = partes;	*/
				this.htmlRichTextBox1.Clear();
				this.htmlRichTextBox1.AddHTML(datos);
				
			}
		}

		private void RefreshData() 
		{
			_uiController.GetSolicitudes();
			gridSolicitudes.SetDataBinding( null, null );
			gridSolicitudes.SetDataBinding(_uiController.Solicitudes, null);
			gridSolicitudes.Refresh();
			gridSolicitudes.Refetch();
			ChangeDatos();							
		}

		/*private void ActualizarDatos()
		{
			gridSolicitudes.Refresh();
			gridSolicitudes.Refetch();
			ChangeDatos();					
		}*/

		private void toolBarStandar_ButtonClick_1(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 5:					
					RefreshData();
					break;
				case 7:
					Desautorizar();
					break;
				case 8:
					Autorizar();
					break;
			}			
		}

		private void FrmAutorizaciones_KeyDown(object sender, KeyEventArgs e)
		{			
			if (e.KeyCode == System.Windows.Forms.Keys.F5)
				this.RefreshData();
		}

		private void gridSolicitudes_KeyPress(object sender, KeyPressEventArgs e)
		{			

			//MessageBox.Show(e.KeyChar.ToString());
			/*			if(e.KeyChar == System.Windows.Forms.Keys.PageDown) 
							this.ChangeDatos();				
						if(e.KeyCode == System.Windows.Forms.Keys.PageUp) 
							this.ChangeDatos();				*/
		}

		private void Autorizar() 
		{
			if (gridSolicitudes.SelectedItems.Count == 1) 
			{
				Util.MoveFocus(this.container);
				_uiController.Autorizado = true;						
				_uiController.IdAutorizacion = (string)gridSolicitudes.SelectedItems[0].GetRow().Cells["IdAutorizacion"].Value;
				_uiController.Execute();
			}
		}
		private void Desautorizar() 
		{
			if (gridSolicitudes.SelectedItems.Count == 1) 
			{
				Util.MoveFocus(this.container);
				_uiController.Autorizado = false;
				_uiController.IdAutorizacion = (string)gridSolicitudes.SelectedItems[0].GetRow().Cells["IdAutorizacion"].Value;
				_uiController.Execute();
			}
		}

	
	}
	}

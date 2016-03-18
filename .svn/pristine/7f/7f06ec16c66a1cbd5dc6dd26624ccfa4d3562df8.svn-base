using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using mz.erp.businessrules;
using mz.erp.commontypes.CommonInterfaces;
namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConversiones.
	/// </summary>
	public class FrmConversiones : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridDetalleConversion;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolBarButton tbbAceptar;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton tbbCancelar;


		private Conversion _conversion;
		private string _unidad;

		public FrmConversiones()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmConversiones(Conversion conversion, string unidad)
		{
			_conversion = conversion;
			_unidad = unidad;
			InitializeComponent();
			InitializeMembers();
		}


		private void InitializeMembers()
		{
			gridDetalleConversion.LayoutData = new mz.erp.ui.forms.classes.tsh_DetalleConversiones().GetLayoutDetalle();
			InitEvents();
			InitDataBindings();
			gridDetalleConversion.Select();

			gridDetalleConversion.CurrentColumn = gridDetalleConversion.RootTable.Columns["ValorSinConvertir"];
			gridDetalleConversion.SelectCurrentCellText();
			
		}


		private void InitEvents()
		{
				this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick	);
		}


		private void InitDataBindings()
		{
			gridDetalleConversion.SetDataBinding(_conversion.Items.Filter(null, _unidad), null);
			gridDetalleConversion.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridDetalleConversion.RootTable.Columns["UnidadOrigen"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridDetalleConversion.RootTable.Columns["UnidadDestino"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridDetalleConversion.RootTable.Columns["ValorConversion"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			gridDetalleConversion.RootTable.Columns["ValorConvertido"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
			//gridDetalleConversion.RootTable.Columns["Formula"].EditType = Janus.Windows.GridEX.EditType.NoEdit;
		}



		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0://Acptar
					Aceptar();
					break;
				case 1:
					break;
				case 2:
					Cancelar();
					break;
				
			}		
		
		}


		private void Aceptar()
		{
			this.DialogResult = DialogResult.OK;
			
		}


		private void Cancelar()
		{
			this.DialogResult = DialogResult.Cancel;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConversiones));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridDetalleConversion = new Janus.Windows.GridEX.GridEX();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAceptar = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleConversion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtDescripcion);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNombre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(615, 39);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(64, 19);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(352, 20);
			this.txtDescripcion.TabIndex = 1;
			this.txtDescripcion.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descripcion: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(64, 0);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(352, 20);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre: ";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridDetalleConversion);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 89);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(615, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridDetalleConversion
			// 
			this.gridDetalleConversion.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.gridDetalleConversion.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridDetalleConversion.AlternatingColors = true;
			this.gridDetalleConversion.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridDetalleConversion.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridDetalleConversion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridDetalleConversion.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridDetalleConversion.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridDetalleConversion.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridDetalleConversion.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridDetalleConversion.GroupByBoxVisible = false;
			this.gridDetalleConversion.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridDetalleConversion.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridDetalleConversion.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridDetalleConversion.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridDetalleConversion.Location = new System.Drawing.Point(0, 0);
			this.gridDetalleConversion.Name = "gridDetalleConversion";
			this.gridDetalleConversion.RecordNavigatorText = "Registro:|de";
			this.gridDetalleConversion.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridDetalleConversion.Size = new System.Drawing.Size(615, 150);
			this.gridDetalleConversion.TabIndex = 0;
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
																							  this.tbbAceptar,
																							  this.toolBarButton9,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(664, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAceptar
			// 
			this.tbbAceptar.ImageIndex = 6;
			this.tbbAceptar.Text = "Aceptar";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Expanded = false;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 39;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Datos Generales";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Tabulacion";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(664, 329);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmConversiones
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 357);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmConversiones";
			this.Text = "Conversiones";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConversiones_KeyDown);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDetalleConversion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmConversiones_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.A)
			{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
						Aceptar();
			}
			else
			if(e.KeyCode == System.Windows.Forms.Keys.C)
			{
					if(e.Modifiers == System.Windows.Forms.Keys.Alt)
						Cancelar();
			}
				
		
		}
	}
}

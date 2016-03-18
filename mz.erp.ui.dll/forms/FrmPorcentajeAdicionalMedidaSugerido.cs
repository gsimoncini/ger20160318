using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using mz.erp.businessrules;
using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmPorcentajeAdicionalMedidaSugerido.
	/// </summary>
	public class FrmPorcentajeAdicionalMedidaSugerido : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imageList1;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton bAceptar;
		private System.Windows.Forms.ToolBarButton bCancelar;
		protected Janus.Windows.GridEX.GridEX gridPorcentajes;
		private System.ComponentModel.IContainer components;



		private PorcentajeAdicionalMedidaSugeridoController _controller;

		public FrmPorcentajeAdicionalMedidaSugerido(Conversion conversion)
		{
			
			InitializeComponent();
			InitController(conversion);
			
			InitEvents();
			InitDataBindings();
			_controller.SelectionChange(gridPorcentajes.SelectedItems[0].GetRow().DataRow);
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


		private void InitController(Conversion conversion)
		{
			_controller = new PorcentajeAdicionalMedidaSugeridoController(conversion);
		}

		private void InitDataBindings()
		{
			gridPorcentajes.LayoutData = _controller.LayoutData;
			gridPorcentajes.SetDataBinding(_controller.DataSource, null);
			if(_controller.DataSource.Count > 0)
			{
				gridPorcentajes.Row = 0;
				gridPorcentajes.Select();
			}
		}

		private void InitEvents()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			gridPorcentajes.SelectionChanged +=new EventHandler(gridPorcentajes_SelectionChanged);
			this.KeyDown +=new KeyEventHandler(FrmPorcentajeAdicionalMedidaSugerido_KeyDown);
		}



		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPorcentajeAdicionalMedidaSugerido));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.bAceptar = new System.Windows.Forms.ToolBarButton();
			this.bCancelar = new System.Windows.Forms.ToolBarButton();
			this.gridPorcentajes = new Janus.Windows.GridEX.GridEX();
			((System.ComponentModel.ISupportInitialize)(this.gridPorcentajes)).BeginInit();
			this.SuspendLayout();
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
																							  this.bAceptar,
																							  this.bCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(240, 28);
			this.toolBarStandar.TabIndex = 19;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// bAceptar
			// 
			this.bAceptar.ImageIndex = 0;
			this.bAceptar.Text = "&Aceptar";
			// 
			// bCancelar
			// 
			this.bCancelar.ImageIndex = 1;
			this.bCancelar.Text = "&Cancelar";
			// 
			// gridPorcentajes
			// 
			this.gridPorcentajes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridPorcentajes.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridPorcentajes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPorcentajes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridPorcentajes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridPorcentajes.GroupByBoxVisible = false;
			this.gridPorcentajes.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridPorcentajes.Location = new System.Drawing.Point(0, 28);
			this.gridPorcentajes.Name = "gridPorcentajes";
			this.gridPorcentajes.Size = new System.Drawing.Size(240, 146);
			this.gridPorcentajes.TabIndex = 20;
			// 
			// FrmPorcentajeAdicionalMedidaSugerido
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(240, 174);
			this.Controls.Add(this.gridPorcentajes);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmPorcentajeAdicionalMedidaSugerido";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Porcentaje Sugerido";
			((System.ComponentModel.ISupportInitialize)(this.gridPorcentajes)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0://Aceptar
				{
					Aceptar();
					break;
				}
				case 1://Cancelar
				{
					Cancelar();
					break;

				}
			}
		}

		private void Aceptar()
		{
			_controller.Aceptar();
			if(_controller.IsValid())
				this.Close();

		}

		private void Cancelar()
		{
			_controller.Cancelar();
			this.Close();
		}

		private void gridPorcentajes_SelectionChanged(object sender, EventArgs e)
		{
			if(gridPorcentajes.SelectedItems.Count >0)
				_controller.SelectionChange(gridPorcentajes.SelectedItems[0].GetRow().DataRow);
		}

		private void FrmPorcentajeAdicionalMedidaSugerido_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData )
			{
				case System.Windows.Forms.Keys.A :
					if(e.Alt)
						this.Aceptar();						
					break;
				case System.Windows.Forms.Keys.C :
					if(e.Alt)
						this.Cancelar();
					break;
				case System.Windows.Forms.Keys.Enter:
					this.Aceptar();
					break;
				default:
					break;
			}

		}
	}
}

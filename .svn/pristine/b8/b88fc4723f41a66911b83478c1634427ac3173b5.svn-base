using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.Comprobantes_de_Compra;
using mz.erp.ui.controls;
using mz.erp.commontypes;
using System.Reflection;








namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesSelectN.
	/// </summary>
	public class FrmComprobantesDeCompraSelectN : System.Windows.Forms.Form
	{
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton tbStep3;
		private System.Windows.Forms.ToolBarButton tbDelete;		
		private System.ComponentModel.IContainer components;

		public FrmComprobantesDeCompraSelectN()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		private Form _formOwner;
		[FormOwnerPropertyAttributte]
		public Form FormOwner
		{
			get {return _formOwner;}
			set {_formOwner = value;}
		}
		#region Custom Members
		public FrmComprobantesDeCompraSelectN(ArrayList IdComprobantes)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			Init(IdComprobantes);

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		private RelacionesComprobanteDeCompraOrigenDestino items;
		[IsNextStepMember]
		public void Init(ArrayList IdComprobantes)
		{			
			items = new RelacionesComprobanteDeCompraOrigenDestino( IdComprobantes);
			gridEX1.LayoutData = mz.erp.ui.ComprobanteDeCompra.GetLayoutRelacionOrigenDestino( new string[] {"IdTipoDeComprobante", "Numero", "OrdinalOrigen", "CantidadOrigen","CantidadDestino","Descripcion", "PrecioDeCosto"});
			gridEX1.DataSource = items;	
			base.MdiParent = mz.erp.ui.utility.Environment.MainForm;
			base.Show();
			
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// 
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

		#endregion
		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{						
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmComprobantesDeCompraSelectN));
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.tbStep3 = new System.Windows.Forms.ToolBarButton();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(839, 295);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// gridEX1
			// 
			this.gridEX1.AllowDrop = true;
			this.gridEX1.AutoEdit = true;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEX1.LayoutData = "<GridEXLayoutData><RootTable><Columns Collection=\"true\"><Column0 ID=\"Column1\"><Fo" +
				"rmatString>c</FormatString><Key>Column1</Key><Position>0</Position><Width>81</Wi" +
				"dth></Column0></Columns><GroupCondition ID=\"\" /></RootTable></GridEXLayoutData>";
			this.gridEX1.Location = new System.Drawing.Point(0, 0);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
			this.gridEX1.Size = new System.Drawing.Size(839, 295);
			this.gridEX1.TabIndex = 13;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1";
			this.ultraExplorerBar1.Size = new System.Drawing.Size(888, 413);
			this.ultraExplorerBar1.TabIndex = 18;
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
																							  this.toolBarButton6,
																							  this.toolBarButton7,
																							  this.toolBarButton8,
																							  this.tbStep3,
																							  this.tbDelete});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(888, 28);
			this.toolBarStandar.TabIndex = 19;
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
			this.toolBarButton6.ImageIndex = 5;
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 8;
			this.toolBarButton8.Text = "Continuar";
			// 
			// tbStep3
			// 
			this.tbStep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.tbStep3.Visible = false;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 7;
			this.tbDelete.Text = "Borrar";
			this.tbDelete.Visible = false;
			// 
			// FrmComprobantesDeComppraSelectN
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(888, 413);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.ultraExplorerBar1);
			this.KeyPreview = true;
			this.Name = "FrmComprobantesDeComppraSelectN";
			this.Text = "Selección de items de comprobantes";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmComprobantesSelectN_KeyDown);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
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
					break;
				case 1:
					break;
				case 2:
					break;
				case 3:
					break;
				case 5:										
					break;
				case 7:					
					Step();
					break;
				case 8:
					
					break;
			}				
		}
		private void Step()
		{
			bool _continuar = false;
			gridEX1.UpdateData(); 
			ArrayList idTipos = items.ComprobantesDestinoPermitidos();
			ArrayList nombres = mz.erp.businessrules.tsy_TiposDeComprobantes.ObtenerNombres( idTipos );
			string NombreComprobanteSeleccionado = null;
			string IdTipoDestino = null;
			if(idTipos.Count > 1)
			{
				ModalListBox seleccionar = new ModalListBox( nombres.ToArray() );
				seleccionar.ShowModal();
				NombreComprobanteSeleccionado = (string)seleccionar.SelectedItem();
				IdTipoDestino= mz.erp.businessrules.tsy_TiposDeComprobantes.ObtenerClave( NombreComprobanteSeleccionado );
				_continuar = seleccionar.Continuar;
			}
			else
				if(idTipos.Count == 1) 
				{
					NombreComprobanteSeleccionado = (string)nombres[0];
					IdTipoDestino =(string)idTipos[0];
					_continuar = true;
				}

			string momentoasociado = mz.erp.businessrules.tsy_TiposDeComprobantes.MomentoAsociado( IdTipoDestino );
			if (momentoasociado != null && _continuar)
			{
				/*FrmComprobantesDeCompra frmComprobantes = new FrmComprobantesDeCompra( );
				EventInfo ei =frmComprobantes.GetType().GetEvent("OnCommitComprobante");
				Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, this._formOwner, "processEventChange" );
				ei.AddEventHandler(frmComprobantes, del1);
				frmComprobantes.Step( momentoasociado, IdTipoDestino, items );*/
				this.Close();
			}
		}


		#region Eventos
		private void FrmComprobantesSelectN_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.C)
			{
				if(e.Modifiers == System.Windows.Forms.Keys.Alt)
				{
					Step();
				}
			}
		}

		#endregion
	}
}

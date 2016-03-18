using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui ;
using mz.erp.businessrules.comprobantes;
using System.Data;
//using mz.erp.dataaccess;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmIngresosEgresos.
	/// </summary>
	public class FrmDetalleInstanciaCaja : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.ToolBarButton tbbVerDetalle;
		private Janus.Windows.GridEX.GridEX gsInstanciasCajas;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.ToolBarButton tbbVerValores;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsable;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor uDTECierre;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor uDTEApertura;
		private System.Windows.Forms.ToolBarButton tbbNuevaBusqueda;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton tbbVerCajasPorFiltros;
		private System.Windows.Forms.ToolBarButton tbbVerCajasAbiertas;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private Janus.Windows.GridEX.GridEX gsDetalleIngresosEgresos;
		private System.ComponentModel.IContainer components;


	
		public FrmDetalleInstanciaCaja()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			
			InitializeMembers();
			

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public void InitializeMembers()
		{
			mzCEResponsable.FillFromDataSource( businessrules.sy_Usuarios.GetList().sy_Usuarios, "idUsuario", "Nombre", 8, "1", "2", "Nombre");
			mz.erp.ui.forms.classes.tfi_InstanciasCaja sourceUI= new mz.erp.ui.forms.classes.tfi_InstanciasCaja();
			this.gsInstanciasCajas.LayoutData= sourceUI.GetLayout();
			DataTable table = mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdUsuario).Tables[0];
			this.gsInstanciasCajas.DataSource=	table;
			if(table.Rows.Count > 0)tbbVerDetalle.Enabled = true;
			else tbbVerDetalle.Enabled = false;
			tbbVerValores.Enabled = false;

			tbbVerCajasAbiertas.Enabled=false;
			gsDetalleIngresosEgresos.LayoutData= new mz.erp.ui.forms.classes.tfi_InstanciasCaja().GetLayoutIngresosEgresos();
			mzCEResponsable.Value = Security.IdUsuario;

			mzCEResponsable.ValueChanged +=new EventHandler(Refresh);
			uDTEApertura.ValueChanged +=new EventHandler(Refresh);
			uDTECierre.ValueChanged +=new EventHandler(Refresh);
			

	
		}

		private void Refresh(object sender, EventArgs e)
		{
			tbbVerCajasPorFiltros.Enabled = true;
		}

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				
				case 0:					
					MostrarDetalles();
					break;

				case 2:
					MostrarValores();
					break;

				case 4:
					ResetUI();
					break;

				case 6:
					VerCajasPorFiltros();
					break;
				case 8:
					VerCajasAbiertas();
					break;


										
			
			}
		}	

		public void MostrarDetalles()

		{
			
			if (gsInstanciasCajas.RecordCount > 0)
			{
				if(gsInstanciasCajas.SelectedItems.Count > 0)

				{									
					string IdInstanciaCaja =(string)this.gsInstanciasCajas.SelectedItems[0].GetRow().Cells[0].Value;
					if (IdInstanciaCaja != null) 
					{
							
						tfi_InstanciasCajaExDataset data = new tfi_InstanciasCajaExDataset();
						data =  mz.erp.businessrules.tfi_InstanciasCaja.GetDetalleIngresosEgresos(data, IdInstanciaCaja);
						gsDetalleIngresosEgresos.LayoutData= new mz.erp.ui.forms.classes.tfi_InstanciasCaja().GetLayoutIngresosEgresos();
						gsDetalleIngresosEgresos.DataSource =  data.Pr_tfi_InstanciasCaja_GetIngresosEgresosByPk;
						tbbVerValores.Enabled = true;
					}
				}
						
				else  MessageBox.Show("Debe seleccionar una Instancia de Caja");
			}

			else MessageBox.Show("No hay Cajas Abiertas");
		

		}

		//Metodo que muestra Los valores de acuerdo al Ingreso/Egreso (pagos de Comprobantes o Movimientos)
		// seleccionado. se tubo que agregar el IdBusqueda al stored Procedure puesto que las filas que se 
		//encuentran an la gilla de Ingresos/Egresos proveien tanto de la tabla de Movimientos como de la de
		//Comprobantes y los Ids se podrin repetir, por ende el IdBusuqeda represenata a cualquiera de esos IDS
		// y hay un campo mas que denota de que tabla hay que sacar ese Ingreso/Egreso para luego obtener el detalle de los
		//valores utuilizados en en ese Pago de Comprobante o Detalle de Movimiento

		public void MostrarValores()
		{
			
			
			if (gsDetalleIngresosEgresos.RecordCount > 0)
			{
				if (gsDetalleIngresosEgresos.SelectedItems.Count > 0 )
				{								
					string IdBusqueda = (string) this.gsDetalleIngresosEgresos.SelectedItems[0].GetRow().Cells["IdBusqueda"].Value;
					string tabla =(string )this.gsDetalleIngresosEgresos.SelectedItems[0].GetRow().Cells["SourceTable"].Value;
					if (IdBusqueda != "")
			
					{
						DataSet data = new DataSet();	
						System.Data.DataTable table;
						if (tabla.Equals(Constantes.TablaMovimientosDeCaja)) 
						{
							data = mz.erp.businessrules.tfi_InstanciasCaja.GetDetallePagosMovimientosDeCaja(IdBusqueda);
							table= data.Tables[0];
						}
						else 
						{
							data=mz.erp.businessrules.tfi_InstanciasCaja.GetDetallePagosComprobantes(IdBusqueda);
							table=data.Tables[0];
						}
						 ArrayList valores =Valor.LoadValores(table);
						FrmDetalleValores fdv = new FrmDetalleValores(valores);
						fdv.MdiParent= this.ParentForm;
						fdv.Show();
			
			
					}
					else MessageBox.Show("No hay nada para mostrar");
				}	
				else
					MessageBox.Show("Debe seleccionar un Ingreso/Egreso");
			}
			else MessageBox.Show("No hubo Movimientos en dicha Instancia de Caja");
			


			
				
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmDetalleInstanciaCaja));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gsInstanciasCajas = new Janus.Windows.GridEX.GridEX();
			this.label1 = new System.Windows.Forms.Label();
			this.uDTEApertura = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.uDTECierre = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCEResponsable = new mz.erp.ui.controls.mzComboEditor();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gsDetalleIngresosEgresos = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbVerDetalle = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbbVerValores = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.tbbNuevaBusqueda = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.tbbVerCajasPorFiltros = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.tbbVerCajasAbiertas = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gsInstanciasCajas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uDTEApertura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uDTECierre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gsDetalleIngresosEgresos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gsInstanciasCajas);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uDTEApertura);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uDTECierre);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsable);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(774, 191);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// gsInstanciasCajas
			// 
			this.gsInstanciasCajas.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.gsInstanciasCajas.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gsInstanciasCajas.AlternatingColors = true;
			this.gsInstanciasCajas.AutomaticSort = false;
			this.gsInstanciasCajas.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gsInstanciasCajas.Cursor = System.Windows.Forms.Cursors.Default;
			this.gsInstanciasCajas.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gsInstanciasCajas.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gsInstanciasCajas.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gsInstanciasCajas.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gsInstanciasCajas.GroupByBoxVisible = false;
			this.gsInstanciasCajas.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gsInstanciasCajas.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gsInstanciasCajas.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gsInstanciasCajas.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gsInstanciasCajas.Location = new System.Drawing.Point(0, 63);
			this.gsInstanciasCajas.Name = "gsInstanciasCajas";
			this.gsInstanciasCajas.RecordNavigatorText = "Registro:|de";
			this.gsInstanciasCajas.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gsInstanciasCajas.Size = new System.Drawing.Size(774, 128);
			this.gsInstanciasCajas.TabIndex = 3;
			this.gsInstanciasCajas.DoubleClick += new System.EventHandler(this.gsInstanciasCajas_DoubleClick);
			this.gsInstanciasCajas.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.gsInstanciasCajas_FormattingRow);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Apertura:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uDTEApertura
			// 
			this.uDTEApertura.Location = new System.Drawing.Point(112, 0);
			this.uDTEApertura.Name = "uDTEApertura";
			this.uDTEApertura.Size = new System.Drawing.Size(224, 21);
			this.uDTEApertura.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(-1, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cierre:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// uDTECierre
			// 
			this.uDTECierre.Location = new System.Drawing.Point(112, 21);
			this.uDTECierre.Name = "uDTECierre";
			this.uDTECierre.Size = new System.Drawing.Size(224, 21);
			this.uDTECierre.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(0, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 75;
			this.label3.Text = "Responsable: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCEResponsable
			// 
			this.mzCEResponsable.AutoComplete = true;
			this.mzCEResponsable.DataSource = null;
			this.mzCEResponsable.DisplayMember = "";
			this.mzCEResponsable.DisplayMemberCaption = "";
			this.mzCEResponsable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEResponsable.Location = new System.Drawing.Point(112, 42);
			this.mzCEResponsable.MaxItemsDisplay = 7;
			this.mzCEResponsable.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEResponsable.Name = "mzCEResponsable";
			this.mzCEResponsable.Size = new System.Drawing.Size(224, 21);
			this.mzCEResponsable.SorterMember = "";
			this.mzCEResponsable.TabIndex = 2;
			this.mzCEResponsable.ValueMember = "";
			this.mzCEResponsable.ValueMemberCaption = "";
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gsDetalleIngresosEgresos);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 299);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(774, 197);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gsDetalleIngresosEgresos
			// 
			this.gsDetalleIngresosEgresos.AcceptsEscape = false;
			this.gsDetalleIngresosEgresos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.gsDetalleIngresosEgresos.AllowCardSizing = false;
			this.gsDetalleIngresosEgresos.AllowColumnDrag = false;
			this.gsDetalleIngresosEgresos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gsDetalleIngresosEgresos.AlternatingColors = true;
			this.gsDetalleIngresosEgresos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gsDetalleIngresosEgresos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gsDetalleIngresosEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gsDetalleIngresosEgresos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gsDetalleIngresosEgresos.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gsDetalleIngresosEgresos.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gsDetalleIngresosEgresos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gsDetalleIngresosEgresos.GroupByBoxVisible = false;
			this.gsDetalleIngresosEgresos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gsDetalleIngresosEgresos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gsDetalleIngresosEgresos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gsDetalleIngresosEgresos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gsDetalleIngresosEgresos.Location = new System.Drawing.Point(0, 0);
			this.gsDetalleIngresosEgresos.Name = "gsDetalleIngresosEgresos";
			this.gsDetalleIngresosEgresos.RecordNavigatorText = "Registro:|de";
			this.gsDetalleIngresosEgresos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gsDetalleIngresosEgresos.Size = new System.Drawing.Size(774, 197);
			this.gsDetalleIngresosEgresos.TabIndex = 1;
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
																							  this.tbbVerDetalle,
																							  this.toolBarButton7,
																							  this.tbbVerValores,
																							  this.toolBarButton6,
																							  this.tbbNuevaBusqueda,
																							  this.toolBarButton8,
																							  this.tbbVerCajasPorFiltros,
																							  this.toolBarButton9,
																							  this.tbbVerCajasAbiertas});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(840, 28);
			this.toolBarStandar.TabIndex = 19;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
			// 
			// tbbVerDetalle
			// 
			this.tbbVerDetalle.Tag = "";
			this.tbbVerDetalle.Text = "Ver Detalle";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbVerValores
			// 
			this.tbbVerValores.Text = "Ver Valores";
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbNuevaBusqueda
			// 
			this.tbbNuevaBusqueda.Text = "Nueva Busqueda";
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbVerCajasPorFiltros
			// 
			this.tbbVerCajasPorFiltros.Text = "Filtrar Cajas";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbVerCajasAbiertas
			// 
			this.tbbVerCajasAbiertas.Text = "Cajas Abiertas";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Top;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 191;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Filtros";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 197;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Movimientos de Caja";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(840, 516);
			this.ultraExplorerBar1.TabIndex = 20;
			this.ultraExplorerBar1.TabStop = false;
			this.ultraExplorerBar1.ItemClick += new Infragistics.Win.UltraWinExplorerBar.ItemClickEventHandler(this.ultraExplorerBar1_ItemClick);
			// 
			// FrmDetalleInstanciaCaja
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(840, 542);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmDetalleInstanciaCaja";
			this.Text = "Consulta de Caja";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gsInstanciasCajas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uDTEApertura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uDTECierre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEResponsable)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gsDetalleIngresosEgresos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void gsDetalleIngresosEgresos_DoubleClick(object sender, System.EventArgs e)
		{
				MostrarValores();

		}
				
				
		private void gsInstanciasCajas_DoubleClick(object sender, System.EventArgs e)
		{
			
					MostrarDetalles ();
			
		}

		private void gsInstanciasCajas_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
		{
		
		}
		//Boton para ver las Intancias de caja Filtradas por Fecha de Apertura y Cierre y Responsable
		private void VerCajasPorFiltros()
		{
			DateTime Apertura;
			if (uDTEApertura.Value == null)
				Apertura = DateTime.MinValue;
			else Apertura = (DateTime)uDTEApertura.Value;
			DateTime Cierre;
			if (uDTECierre.Value == null)
				Cierre = DateTime.MinValue;
			else
				Cierre =(DateTime) uDTECierre.Value;
			string IdResponsable ="";
			if ((string)mzCEResponsable.Value != "")
				IdResponsable= (string)mzCEResponsable.Value;
			else IdResponsable = Security.IdUsuario;
			
			Apertura = mz.erp.systemframework.Util.GetStartDay(Apertura);
			Cierre = mz.erp.systemframework.Util.GetEndDay(Cierre);
			gsInstanciasCajas.DataSource = mz.erp.businessrules.tfi_InstanciasCaja.GetList(null, null, Apertura, Cierre, IdResponsable).tfi_InstanciasCaja;
			if (gsInstanciasCajas.RecordCount >0)
			{	
				
				
				tbbVerCajasPorFiltros.Enabled = false;

			}
			else 
			{
				gsDetalleIngresosEgresos.DataSource = null;
				
				gsInstanciasCajas.DataSource = null;
				

			}
			tbbVerCajasAbiertas.Enabled=true;
		
		}

		private void VerCajasAbiertas()
		{
			DataTable table = mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdUsuario).Tables[0];
			this.gsInstanciasCajas.DataSource=	table;
			if(table.Rows.Count > 0)tbbVerDetalle.Enabled = true;
			else tbbVerDetalle.Enabled = false;
			tbbVerCajasAbiertas.Enabled = false;
			tbbVerCajasPorFiltros.Enabled = true;
			gsDetalleIngresosEgresos.DataSource = null;
			mzCEResponsable.ResetText();
			uDTEApertura.ResetValue();
			uDTECierre.ResetValue();

			
		}

		private void ResetUI()
		{
			mzCEResponsable.ResetText();
			uDTEApertura.ResetValue();
			uDTECierre.ResetValue();
			gsInstanciasCajas.DataSource = null;
			gsDetalleIngresosEgresos.DataSource= null;
			tbbVerCajasAbiertas.Enabled= true;
			tbbVerCajasPorFiltros.Enabled = true;

			
		}

		private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
		{
		
		}

	
	}
}

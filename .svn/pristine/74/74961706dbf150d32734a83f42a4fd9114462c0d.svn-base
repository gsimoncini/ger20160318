using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.businessrules.comprobantes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmDetalleItem.
	/// </summary>
	public class FrmDetalleItem : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbDelete;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerItems;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private System.ComponentModel.IContainer components;
		private ArrayList _items;

		public FrmDetalleItem(ArrayList items, String action)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_items = items;
			Init();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}



			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		

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

		private void Init()
		{
			
		
			/*gridProductos.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutDetalleProductos( new string[] { "Codigo", "Cantidad","Descripcion","PrecioDeVentaBruto","BonificacionPorcentual","Precio","SubTotalNeto","SubTotalConImpuestosDirectos","PrecioConImpuestos"} );
			gridProductos.DataSource = this._items;
			Janus.Windows.GridEX.GridEXTable childTabel = new Janus.Windows.GridEX.GridEXTable();
			childTabel.DataMember="Impuestos";
			
			gridProductos.RootTable.ChildTables.Add(childTabel);

			
			Janus.Windows.GridEX.GridEXColumn column = new Janus.Windows.GridEX.GridEXColumn();
			column.Key = column.Caption = column.DataMember = "Nombre";
			Janus.Windows.GridEX.GridEXColumn column1 = new Janus.Windows.GridEX.GridEXColumn();
			column1.Key = column1.Caption = column1.DataMember = "Valor";
			childTabel.Columns.Add(column);
			childTabel.Columns.Add(column1);*/
	
		


			// mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutImpuestos( new string[] {"Nombre","Valor"});
			//gridProductos.RootTable.ChildTables.Add(childTabel);
			
			

			//gridProductos.RootTable.ChildTables.

			//Definicion de la tabla de ItemComprobante
			System.Data.DataTable tableItem = new System.Data.DataTable("Item");
		
			DataColumn columnCodigo = new DataColumn("Codigo", typeof(string), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnCodigo);
			
			DataColumn columnCantidad = new DataColumn("Cantidad", typeof(string), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnCantidad);
			DataColumn columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnDescripcion);
			DataColumn columnPrecioDeVentaBruto = new DataColumn("PrecioDeVentaBruto", typeof(System.Decimal), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnPrecioDeVentaBruto);
			DataColumn columnBonificacionPorcentual = new DataColumn("BonificacionPorcentual", typeof(System.Decimal), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnBonificacionPorcentual);
			DataColumn columnPrecio = new DataColumn("Precio", typeof(System.Decimal), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnPrecio);
			DataColumn columnSubTotalNeto= new DataColumn("SubTotalNeto", typeof(System.Decimal), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnSubTotalNeto);
			DataColumn columnSubTotalConImpuestosDirectos= new DataColumn("SubTotalConImpuestosDirectos", typeof(System.Decimal), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnSubTotalConImpuestosDirectos);
			DataColumn columnPrecioConImpuestos = new DataColumn("PrecioConImpuestos", typeof(System.Decimal), null, System.Data.MappingType.Element);
			tableItem.Columns.Add(columnPrecioConImpuestos);
			
			//Definicion de la table de Impuestos
			System.Data.DataTable tableImpuestosItem = new System.Data.DataTable("ImpuestosItem");
			DataColumn columnCodigoDetail = new DataColumn("Codigo", typeof(string), null, System.Data.MappingType.Element);
			tableImpuestosItem.Columns.Add(columnCodigoDetail);
			DataColumn columnNombre = new DataColumn("Nombre", typeof(string), null, System.Data.MappingType.Element);
			tableImpuestosItem.Columns.Add(columnNombre);
			DataColumn columnValor = new DataColumn("Valor", typeof(System.Decimal), null, System.Data.MappingType.Element);
			tableImpuestosItem.Columns.Add(columnValor);

			
			//Creacion del Dataset

			System.Data.DataSet data = new System.Data.DataSet();
			data.Tables.Add(tableItem);
			data.Tables.Add(tableImpuestosItem);

			//Relaciones entre las tabla anteriores
			data.Relations.Add(columnCodigo,columnCodigoDetail);


			//Carga de Valores
			//Carga de Items
			foreach(ItemComprobante ic in this._items)
			{
				//Carga un Item en particular ic
				System.Data.DataRow row = data.Tables["Item"].NewRow();
				row["Codigo"]= ic.Codigo;
				row["Descripcion"] = ic.Descripcion;
				row["Cantidad"] = Convert.ToString(ic.Cantidad);
				row["PrecioDeVentaBruto"] = ic.PrecioDeVentaBruto;
				row["BonificacionPorcentual"] = ic.BonificacionPorcentual;
				row["Precio"] = ic.Precio;
				row["SubTotalNeto"] = ic.SubTotalNeto;
				row["SubTotalConImpuestosDirectos"]= ic.SubTotalConImpuestos;
				row["PrecioConImpuestos"]= ic.PrecioConImpuestos;
				data.Tables["Item"].Rows.Add(row);
				
				//Carga los impuestos para el item

				foreach(Impuesto imp in ic.Impuestos)
				{
					System.Data.DataRow rowImp = data.Tables["ImpuestosItem"].NewRow();
					rowImp["Codigo"] = ic.Codigo;
					rowImp["Nombre"] = imp.Nombre;
					rowImp["Valor"]  = imp.Valor;
					data.Tables["ImpuestosItem"].Rows.Add(rowImp);
				}

			}

			//Cargar el tema del Stock para poder visualizar el detalle del stock del item 
			//en las distintas sucursales

			gridProductos.GroupByBoxVisible= false;
			gridProductos.Hierarchical = true;
			gridProductos.SetDataBinding(data.Tables["Item"],"");
			gridProductos.RetrieveStructure(true);		

		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmDetalleItem));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbDelete = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.containerItems = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridProductos = new Janus.Windows.GridEX.GridEX();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
			this.ultraExplorerBar.SuspendLayout();
			this.containerItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
			this.SuspendLayout();
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
																							  this.tbDelete});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(832, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbDelete
			// 
			this.tbDelete.ImageIndex = 6;
			this.tbDelete.Text = "Aceptar";
			// 
			// ultraExplorerBar
			// 
			this.ultraExplorerBar.Controls.Add(this.containerItems);
			this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.containerItems;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 167;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Detalle de Productos";
			this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																													   ultraExplorerBarGroup1});
			this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar.Name = "ultraExplorerBar"; this.ultraExplorerBar.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar.Size = new System.Drawing.Size(832, 249);
			this.ultraExplorerBar.TabIndex = 19;
			// 
			// containerItems
			// 
			this.containerItems.Controls.Add(this.gridProductos);
			this.containerItems.Location = new System.Drawing.Point(28, 49);
			this.containerItems.Name = "containerItems";
			this.containerItems.Size = new System.Drawing.Size(783, 167);
			this.containerItems.TabIndex = 1;
			// 
			// gridProductos
			// 
			this.gridProductos.AllowCardSizing = false;
			this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridProductos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridProductos.Location = new System.Drawing.Point(0, 0);
			this.gridProductos.Name = "gridProductos";
			this.gridProductos.Size = new System.Drawing.Size(783, 167);
			this.gridProductos.TabIndex = 5;
			// 
			// FrmDetalleItem
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(832, 277);
			this.Controls.Add(this.ultraExplorerBar);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmDetalleItem";
			this.Text = "Detalle de Item";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
			this.ultraExplorerBar.ResumeLayout(false);
			this.containerItems.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	}
}

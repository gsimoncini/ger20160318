using System;
/*using System.Data;
using System.Collections;*/
//using System.ComponentModel;
/*using System.Drawing;*/
using System.Windows.Forms;
/*using mz.erp.businessrules;
using mz.erp.commontypes;
using mz.erp.commontypes.data;*/

namespace mz.erp.ui.forms	
{
	public class FrmStockACero : mz.erp.ui.forms.FrmAltaRow
	{
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbProductos;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCantidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;		
		/*private string _idProducto = String.Empty;
		private string _idTipoDeAjuste = String.Empty;
		private string _idDeposito = String.Empty;
		private string _idSeccion = String.Empty;*/
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDeAjuste;
		private System.Windows.Forms.Label label2;
		private mz.erp.ui.controls.mzComboEditor mzCmbDepositos;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboEditor mzCmbSecciones;
		//private DataRow _row;

		public FrmStockACero()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmStockACero));
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			this.mzCmbProductos = new mz.erp.ui.controls.mzComboSearchEditor();
			this.uneCantidad = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mzCmbTiposDeAjuste = new mz.erp.ui.controls.mzComboEditor();
			this.mzCmbDepositos = new mz.erp.ui.controls.mzComboEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCmbSecciones = new mz.erp.ui.controls.mzComboEditor();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeAjuste)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbDepositos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSecciones)).BeginInit();
			this.SuspendLayout();
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSecciones);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbDepositos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposDeAjuste);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbProductos);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneCantidad);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(823, 135);
			this.ultraExplorerBarContainerControl1.TabStop = false;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Name = "toolBarStandar";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			// 
			// mzCmbProductos
			// 
			this.mzCmbProductos.DataValue = "";
			this.mzCmbProductos.EditObject = null;
			this.mzCmbProductos.FastSearch = false;
			this.mzCmbProductos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbProductos.HierarchicalSearch = false;
			this.mzCmbProductos.Location = new System.Drawing.Point(81, 3);
			this.mzCmbProductos.Name = "mzCmbProductos";
			this.mzCmbProductos.ReadOnly = false;
			this.mzCmbProductos.SearchObject = null;
			this.mzCmbProductos.SearchObjectListener = null;
			this.mzCmbProductos.Size = new System.Drawing.Size(463, 22);
			this.mzCmbProductos.TabIndex = 0;
			// 
			// uneCantidad
			// 
			this.uneCantidad.Location = new System.Drawing.Point(81, 96);
			this.uneCantidad.MinValue = 0;
			this.uneCantidad.Name = "uneCantidad";
			this.uneCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneCantidad.Size = new System.Drawing.Size(100, 21);
			this.uneCantidad.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(1, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Tipo de ajuste";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(1, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cantidad";
			this.label4.Visible = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(1, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Producto";
			// 
			// mzCmbTiposDeAjuste
			// 
			this.mzCmbTiposDeAjuste.AutoComplete = true;
			this.mzCmbTiposDeAjuste.DataSource = null;
			this.mzCmbTiposDeAjuste.DisplayMember = "";
			this.mzCmbTiposDeAjuste.DisplayMemberCaption = "";
			this.mzCmbTiposDeAjuste.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbTiposDeAjuste.Location = new System.Drawing.Point(81, 27);
			this.mzCmbTiposDeAjuste.MaxItemsDisplay = 7;
			this.mzCmbTiposDeAjuste.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbTiposDeAjuste.Name = "mzCmbTiposDeAjuste";
			this.mzCmbTiposDeAjuste.Size = new System.Drawing.Size(272, 21);
			this.mzCmbTiposDeAjuste.SorterMember = "";
			this.mzCmbTiposDeAjuste.TabIndex = 1;
			this.mzCmbTiposDeAjuste.ValueMember = "";
			this.mzCmbTiposDeAjuste.ValueMemberCaption = "";
			this.mzCmbTiposDeAjuste.ValueChanged += new System.EventHandler(this.Componentes_Changes);
			// 
			// mzCmbDepositos
			// 
			this.mzCmbDepositos.AutoComplete = true;
			this.mzCmbDepositos.DataSource = null;
			this.mzCmbDepositos.DisplayMember = "";
			this.mzCmbDepositos.DisplayMemberCaption = "";
			this.mzCmbDepositos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbDepositos.Location = new System.Drawing.Point(81, 50);
			this.mzCmbDepositos.MaxItemsDisplay = 7;
			this.mzCmbDepositos.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbDepositos.Name = "mzCmbDepositos";
			this.mzCmbDepositos.Size = new System.Drawing.Size(272, 21);
			this.mzCmbDepositos.SorterMember = "";
			this.mzCmbDepositos.TabIndex = 2;
			this.mzCmbDepositos.ValueMember = "";
			this.mzCmbDepositos.ValueMemberCaption = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(1, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Depósito";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(0, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 14;
			this.label3.Text = "Sección";
			// 
			// mzCmbSecciones
			// 
			appearance1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mzCmbSecciones.Appearance = appearance1;
			this.mzCmbSecciones.AutoComplete = true;
			this.mzCmbSecciones.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mzCmbSecciones.DataSource = null;
			this.mzCmbSecciones.DisplayMember = "";
			this.mzCmbSecciones.DisplayMemberCaption = "";
			this.mzCmbSecciones.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCmbSecciones.Location = new System.Drawing.Point(81, 72);
			this.mzCmbSecciones.MaxItemsDisplay = 7;
			this.mzCmbSecciones.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCmbSecciones.Name = "mzCmbSecciones";
			this.mzCmbSecciones.Size = new System.Drawing.Size(272, 21);
			this.mzCmbSecciones.SorterMember = "";
			this.mzCmbSecciones.TabIndex = 3;
			this.mzCmbSecciones.ValueMember = "";
			this.mzCmbSecciones.ValueMemberCaption = "";
			// 
			// FrmStockACero
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(872, 273);
			this.Name = "FrmStockACero";
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeAjuste)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbDepositos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCmbSecciones)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Custom Members
		controllers.StockACeroController _uicontroller = new mz.erp.ui.controllers.StockACeroController();
		/*public virtual void Show()
		{
			Init();
			base.Show();
		}*/		
				//
		protected override void Init()
		{
			Build_UI();
			InitEvents();
			InitDataBindings();			
		}

		private void Build_UI()
		{													
			this.mzCmbProductos.SearchObject = _uicontroller.ListaProductos;
			
			this.mzCmbTiposDeAjuste.FillFromDataSource(_uicontroller.ListaTipoDeAjuste, _uicontroller.TipoAjusteValueMember, _uicontroller.TipoAjusteDisplayMember,8, _uicontroller.TipoAjusteValueMember, _uicontroller.TipoAjusteDisplayMember, "", _uicontroller.View);
			if (this.mzCmbTiposDeAjuste.Items.Count == 1)			
			{
				_uicontroller.IdTipoDeAjuste = this.mzCmbTiposDeAjuste.Items[0].DataValue.ToString();
				this.mzCmbTiposDeAjuste.SetValue(_uicontroller.IdTipoDeAjuste);
				this.mzCmbTiposDeAjuste.Enabled = false;								
			}

			this.mzCmbDepositos.FillFromDataSource( _uicontroller.ListaDeposito, _uicontroller.DepositoValueMember,_uicontroller.DepositoDisplayMember,8,"Descripcion");						
			if (_uicontroller.IdDeposito != "") 
			{
				this.mzCmbDepositos.SetValue(_uicontroller.IdDeposito);
				_uicontroller.FiltroListaSecciones();
			}

			this.mzCmbSecciones.FillFromDataSource( _uicontroller.ListaSeccion, _uicontroller.SeccionValueMember,_uicontroller.SeccionDisplayMember,8,"Descripcion");
			if (_uicontroller.IdSeccion != "") 
			{
				this.mzCmbSecciones.SetValue(_uicontroller.IdSeccion);
				this.mzCmbSecciones.Enabled = false;
			}			
			this.uneCantidad.Visible = false;
//			this.mzCmbTiposDeAjuste.Visible = false;
			//this.uneCantidad.Value = _uicontroller.Cantidad;
			this.mzCmbProductos.Focus();
		}
		private void InitEvents()
		{
			mzCmbProductos.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbDepositos.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbSecciones.ValueChanged+= new System.EventHandler( this.Componentes_Changes );
			mzCmbProductos.ValueChanged+= new System.EventHandler( this.Componentes_Changes );						
		}
		private void InitDataBindings()
		{							
			this.mzCmbTiposDeAjuste.DataBindings.Add("Value", _uicontroller, "IdTipoDeAjuste");
			this.mzCmbDepositos.DataBindings.Add("Value", _uicontroller, "IdDeposito");
			this.mzCmbSecciones.DataBindings.Add("Value", _uicontroller, "IdSeccion");
			//this.uneCantidad.DataBindings.Add("Value", _uicontroller, "Cantidad");
		}

		private void EventsListener()
		{
		}

		private void Componentes_Changes(object sender, System.EventArgs e)
		{
		
			if (((Control)sender).Name == "mzCmbProductos")
			{
				if (mzCmbProductos.SelectedRow != null) 
				{
					_uicontroller.IdProducto = mzCmbProductos.SelectedRow["IdProducto"].ToString();				
				}
			}
			else
			{
				if (((Control)sender).Name == "mzCmbTiposDeAjuste") 
				{
				}								
				else 
				{
					if (((Control)sender).Name == "mzCmbDepositos") 
					{
						if (mzCmbDepositos.Value != null) 
						{														
							_uicontroller.IdDeposito = (string) mzCmbDepositos.Value;
							_uicontroller.FiltroListaSecciones();
							this.mzCmbSecciones.FillFromDataSource( _uicontroller.ListaSeccion, _uicontroller.SeccionValueMember,_uicontroller.SeccionDisplayMember,8,"Descripcion");
							//Verifico que si existe una sola sección para el depósito seleccionado, que automáticamente lo muestre.
							if (_uicontroller.CantidadSecciones == 1) 
							{
								this.mzCmbSecciones.SetValue(_uicontroller.IdSeccion);
								this.mzCmbSecciones.Enabled = false;								
							}
						}
					}
				}					
			}						
		}		

		protected override void Aceptar()
		{
			if (uneCantidad.Focused) {mzCmbSecciones.Select();}
			else {uneCantidad.Select();}										

			_uicontroller.Execute();			
			base.Aceptar();
		}

		protected override void Evaluate()
		{			
			if (_uicontroller.Row != null)
			{
				if (_uicontroller.HasErrors()) 
				{
					/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(_uicontroller.Row);
					_form.MdiParent = mz.erp.ui.utility.Environment.MainForm;
					_form.Show();
				}
				else 
				{
					MessageBox.Show("La acción se ha ejecutado con éxito");				
					Close();
				}
			}
			else 
			{	//la accion no puede ejecutarse por q no hay fila sobre la cual ejecutarla
				MessageBox.Show("La acción no puede ser ejecutada.");
				Close();
			}
		}

		#endregion		
	}
}


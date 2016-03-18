using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmABMCondicionesDeVenta.
	/// </summary>
	/// antes heredaba de 
	public class FrmABMCondicionesDeVenta : System.Windows.Forms.Form, ITaskForm 
	{
		private System.Windows.Forms.ImageList imageList1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.CheckBox chActivo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtRecargo;
		private System.Windows.Forms.TextBox txtCuotas;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imglStandar;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbMetAsigCuentaPorI;
		private System.Windows.Forms.RadioButton rbMetAsigCuentaPorE;
		private Janus.Windows.GridEX.GridEX gridClientes;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbMetAsigTipCompPorI;
		private System.Windows.Forms.RadioButton rbMetAsigTipCompPorE;
		private System.Windows.Forms.Label label25;
		private Infragistics.Win.Misc.UltraButton bNingunoTiposDeComprobantes;
		private Infragistics.Win.Misc.UltraButton bTodosTiposDeComprobantes;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.RadioButton rbMetodoComparacionPorI;
		private System.Windows.Forms.RadioButton rbMetodoComparacionPorE;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl datosGeneralesContainer;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl metodoComparacionContainer;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl tiposDeComprobantesContainer;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl clientesAsociadosContainer;
		protected System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		protected System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		protected System.Windows.Forms.ToolBarButton toolBarButton5;
		private Infragistics.Win.Misc.UltraButton agregarCliente;
		private mz.erp.ui.controls.ToolTipCheckedListBox listaDeFormasDePago;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private mz.erp.ui.controls.ToolTipCheckedListBox listaDeComprobantes;
		private Infragistics.Win.Misc.UltraButton bNingunaFormaDePago;
		private Infragistics.Win.Misc.UltraButton bTodasFormasDePago;
		private mz.erp.ui.controls.mzCuentasControl mzCuentasControl1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCondicionVta;


		private mz.erp.ui.controllers.ABMCondicionesDeVentaController _uiController;

		public FrmABMCondicionesDeVenta(mz.erp.ui.controllers.ABMCondicionesDeVentaController uiController)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			_uiController = uiController;
			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}


		#region Miembros de ITaskForm

		public void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();
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


		public void Execute()
		{
			this.DumpControls();
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
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
			Previous();
		}

		public void KeyDownNext()
		{
			Execute();
		}

		private void Build_UI()
		{
			ConfigureInterface();
			InitEventHandlers();
			InitializeData();
			InitializeMembers();
			InitDataBindings();
			FillControls();
		}

		private void ListenerControllerChanges( object sender, System.EventArgs e )
		{
			RefreshData();
		}
		private void InitEventHandlers()
		{
			mzCuentasControl1.ValueChanged += new System.EventHandler( this.Componentes_Changes);
			_uiController.OnControllerHasChanged+=new System.EventHandler( this.ListenerControllerChanges );
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			bTodosTiposDeComprobantes.Click +=new EventHandler(bTodosTiposDeComprobantes_Click);
			bNingunoTiposDeComprobantes.Click +=new EventHandler(bNingunoTiposDeComprobantes_Click);
			bTodasFormasDePago.Click += new EventHandler(bTodasFormasDePago_Click);
			bNingunaFormaDePago.Click += new EventHandler(bNingunaFormaDePago_Click);
			agregarCliente.Click += new EventHandler(this.agregarCliente_Click);
			mzCmbCondicionVta.ValueChanged += new EventHandler(this.CondicionVta_Change);

			listaDeFormasDePago.ItemCheck += new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
			listaDeComprobantes.ItemCheck += new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
			gridClientes.RecordsDeleted += new EventHandler(gridClientes_RecordsDeleted);
			gridClientes.DeletingRecords +=new CancelEventHandler(gridClientes_DeletingRecords);
			KeyDownManager KeyDown = new KeyDownManager(this);

		}

		private void InitializeData()
		{
			CargarTiposDeComprobantes(false);
			CargarFormasDePago(false);
			RefreshData();
		}

		protected void InitializeMembers()
		{
			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar1.Groups.Exists(grupo))
						this.ultraExplorerBar1.Groups[grupo].Visible = true;
				}
			}

			if(!_uiController.ContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					if (this.ultraExplorerBar1.Groups.Exists(grupo)){
						if (this.ultraExplorerBar1.Groups[grupo].Container != null){
							this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;}
						this.ultraExplorerBar1.Groups[grupo].Enabled = true;}
			}
			}

			mzCmbCondicionVta.SearchObject = typeof(mz.erp.ui.forms.classes.tsa_CondicionesDeVentas);
		}

		private void InitDataBindings()
		{		
		}

		//se ejecuta al levantar la ventana
		protected void FillControls()
		{
			//mzCmbCondicionVta.DataValue = _uiController.Descripcion;
			txtDescripcion.Text = _uiController.Descripcion;
			txtCuotas.Text = _uiController.DiasDeVencimiento.ToString();
			txtRecargo.Value = _uiController.Recargo;

			if (_uiController.MetodoDeAsignacionCuenta == "I") {
				rbMetAsigCuentaPorI.Checked = true;}
			else {rbMetAsigCuentaPorE.Checked = true;}
			rbMetAsigCuentaPorE.Enabled = _uiController.PermiteMetodoAsignacionCuentas;
			rbMetAsigCuentaPorI.Enabled = _uiController.PermiteMetodoAsignacionCuentas;

			if (_uiController.MetodoDeAsignacionTipoDeComprobante == "I"){
				rbMetAsigTipCompPorI.Checked = true;}
			else {rbMetAsigTipCompPorE.Checked = true;}

			if (_uiController.MetodoComparacion == "I"){
				rbMetodoComparacionPorI.Checked = true;}
			else {rbMetodoComparacionPorE.Checked = true;}
			rbMetodoComparacionPorI.Enabled = _uiController.PermiteMetodoComparacion;
			rbMetodoComparacionPorE.Enabled = _uiController.PermiteMetodoComparacion;

			if (_uiController.TodosLosComprobantes)
			{
				CargarTiposDeComprobantes(true);
			}

			chActivo.Checked = _uiController.Activo;

			if (_uiController.IdCondicionDeVenta != "")
			{
				SeleccionarFormasDePago();
				SeleccionarTiposDeComprobante();
			}
		}

		//se ejecuta al intentar guardar
		protected void DumpControls()
		{
			_uiController.DiasDeVencimiento = Convert.ToInt16(txtCuotas.Text);
			_uiController.Recargo = Convert.ToDecimal(txtRecargo.Text);

			_uiController.Activo = chActivo.Checked;

			/*if ((string)mzCmbCondicionVta.DataValue != String.Empty)
			{
				_uiController.Descripcion = (string)mzCmbCondicionVta.Description;}
			else 
			{*/
				_uiController.Descripcion = txtDescripcion.Text;
			//}

			FormasDePagos ListaFormasDePagoSeleccionadas = new FormasDePagos();
			foreach(object obj in listaDeFormasDePago.CheckedItems)
			{
				ListaFormasDePagoSeleccionadas.Add(obj);
			}
			_uiController.ListaFormasDePagoSeleccionadas = ListaFormasDePagoSeleccionadas;

			TiposDeComprobantes ListaTiposDeComprobantesSeleccionados = new TiposDeComprobantes();
			foreach(object obj in listaDeComprobantes.CheckedItems)
			{
				ListaTiposDeComprobantesSeleccionados.Add(obj);
			}
			_uiController.ListaTiposDeComprobantesSeleccionados = ListaTiposDeComprobantesSeleccionados;

			if (rbMetodoComparacionPorE.Checked)
			{
				_uiController.MetodoComparacion = "E";}
			else 
			{
				if (rbMetodoComparacionPorI.Checked)
				{_uiController.MetodoComparacion = "I";}
			}

			if (rbMetAsigTipCompPorE.Checked) 
			{
				_uiController.MetodoDeAsignacionTipoDeComprobante = "E";}
			else 
			{
				if (rbMetAsigTipCompPorI.Checked) {
					  _uiController.MetodoDeAsignacionTipoDeComprobante = "I";}
			}

			if (rbMetAsigCuentaPorE.Checked)
			{
				_uiController.MetodoDeAsignacionCuenta = "E";}
			else 
			{
				if (rbMetAsigCuentaPorI.Checked){
					  _uiController.MetodoDeAsignacionCuenta = "I";}
			}
		}

		private void Componentes_Changes( object sender, System.EventArgs e )
		{				
		}

		private void RefreshData()
		{
			string idCondicion = (string) mzCmbCondicionVta.DataValue;
			if(idCondicion != null && idCondicion != string.Empty && idCondicion != _uiController.IdCondicionDeVenta)
			{
				_uiController.IdCondicionDeVenta = idCondicion;
				CargarCuentas();
				FillControls();
				
			}

		}
		#endregion

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


		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{ 
			switch ( toolBar1.Buttons.IndexOf(e.Button) )
			{
				case 0: //Anterior
					Previous();
					break;
				case 2: //Siguiente
					Execute();
					break;			
				case 4:	//Cancelar					
					CloseForm();
					break;
			}		
		}

		private void ConfigureInterface()
		{
			Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;
			mzCuentasControl1.Init(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName());
			gridClientes.LayoutData = _uiController.GetLayoutCuentas();
			gridClientes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			gridClientes.GroupByBoxVisible  = false;
			KeyPreview = true;
			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessName(), _uiController.GetTaskName());
		}

		private void CargarTiposDeComprobantes(bool checkState)
		{   
			listaDeComprobantes.ItemCheck -= new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
			listaDeComprobantes.Items.Clear();
			TiposDeComprobantes aux = _uiController.TiposDeComprobantes;
			foreach(TipoDeComprobante tc in aux)
			{	
				listaDeComprobantes.Items.Add(tc, checkState);
			}
			listaDeComprobantes.ItemCheck += new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
		}

		private void CargarFormasDePago(bool checkState)
		{
			listaDeFormasDePago.ItemCheck -= new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
			listaDeFormasDePago.Items.Clear();
			FormasDePagos aux = _uiController.FormasDePago;
			foreach(FormaDePago fp in aux)
			{	
				listaDeFormasDePago.Items.Add(fp, checkState);
			}
			listaDeFormasDePago.ItemCheck += new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
		}

		private void CargarCuentas()
		{
			_uiController.UpdateCuentasCondicionDeVenta(_uiController.IdCondicionDeVenta);
			gridClientes.SetDataBinding(null, null);

			gridClientes.SetDataBinding(_uiController.ListaCuentas, null);
			//gridClientes.SetDataBinding(listaCuentasSinRepetidos, null);
		}

		private void SeleccionarFormasDePago()
		{
			listaDeFormasDePago.ItemCheck -= new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
			for(int i=0; i<listaDeFormasDePago.Items.Count; i++)
			{	
				listaDeFormasDePago.SetItemChecked(i, false);
			}
			FormasDePagos aux = _uiController.ListaFormasDePagoSeleccionadas;
			foreach (FormaDePago fp in aux)
			{	
				fp.SourceBD = true;
				int indice = listaDeFormasDePago.Items.IndexOf(fp);
				listaDeFormasDePago.SetItemChecked(indice,true);
			}
			listaDeFormasDePago.ItemCheck += new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
		}

		private void SeleccionarTiposDeComprobante()
		{
			listaDeComprobantes.ItemCheck -= new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
			for(int i=0; i<listaDeComprobantes.Items.Count; i++)
			{	
				listaDeComprobantes.SetItemChecked(i, false);
			}
			TiposDeComprobantes aux = _uiController.ListaTiposDeComprobantesSeleccionados;
			foreach (TipoDeComprobante tdc in aux)
			{	
				tdc.SourceBD = true;
				TipoDeComprobante comp =  _uiController.TiposDeComprobantes.GetByTDComp(tdc.IdTipoComprobante);
				//if (comp != null)
				//{
					int indice = listaDeComprobantes.Items.IndexOf(tdc);
					listaDeComprobantes.SetItemChecked(indice,true);
				//}				
			}
			listaDeComprobantes.ItemCheck += new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
		}


		#region Eventos

		private void bTodosTiposDeComprobantes_Click(object sender, EventArgs e)
		{
			//CargarTiposDeComprobantes(true);
			CheckedListBox.CheckedItemCollection items = listaDeComprobantes.CheckedItems;
			listaDeComprobantes.ItemCheck -= new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
			listaDeComprobantes.Items.Clear();
			TiposDeComprobantes aux = _uiController.TiposDeComprobantes;
			foreach(TipoDeComprobante tc in aux)
			{	
				if (!items.Contains(tc))
				{
					tc.Agregado = true;
				}
				listaDeComprobantes.Items.Add(tc, true);
			}
			listaDeComprobantes.ItemCheck += new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
		}

		private void bNingunoTiposDeComprobantes_Click(object sender, EventArgs e)
		{
			//CargarTiposDeComprobantes(false);
			CheckedListBox.CheckedItemCollection items = listaDeComprobantes.CheckedItems;
			listaDeComprobantes.ItemCheck -= new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);
			listaDeComprobantes.Items.Clear();
			TiposDeComprobantes aux = _uiController.TiposDeComprobantes;
			foreach(TipoDeComprobante tc in aux)
			{	
				if (!items.Contains(tc))
				{
					tc.Agregado = false;
				}
				listaDeComprobantes.Items.Add(tc, false);
			}
			listaDeComprobantes.ItemCheck += new ItemCheckEventHandler(this.TipoDeComprobante_ItemCheck);

		}

		private void bTodasFormasDePago_Click(object sender, EventArgs e)
		{
			CheckedListBox.CheckedItemCollection items = listaDeFormasDePago.CheckedItems;
			listaDeFormasDePago.ItemCheck -= new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
			listaDeFormasDePago.Items.Clear();
			FormasDePagos aux = _uiController.FormasDePago;
			foreach(FormaDePago fp in aux)
			{	
				if (!items.Contains(fp))
				{
					fp.Agregada = true;
				}
				listaDeFormasDePago.Items.Add(fp, true);
			}
			listaDeFormasDePago.ItemCheck += new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
		}

		private void bNingunaFormaDePago_Click(object sender, EventArgs e)
		{
			//CargarFormasDePago(false);
			CheckedListBox.CheckedItemCollection items = listaDeFormasDePago.CheckedItems;
			listaDeFormasDePago.ItemCheck -= new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
			listaDeFormasDePago.Items.Clear();
			FormasDePagos aux = _uiController.FormasDePago;
			foreach(FormaDePago fp in aux)
			{	
				if (!items.Contains(fp))
				{
					fp.Agregada = false;
				}
				listaDeFormasDePago.Items.Add(fp, false);
			}
			listaDeFormasDePago.ItemCheck += new ItemCheckEventHandler(this.FormaDePago_ItemCheck);
		}

		private void agregarCliente_Click(object sender, EventArgs e)
		{	string codigoCuenta = mzCuentasControl1.DataValue;
			if(codigoCuenta != null && codigoCuenta != string.Empty)
				{
				if(!_uiController.ClienteRepetido(codigoCuenta))
				{	_uiController.UpdateCuentas(codigoCuenta);
					gridClientes.SetDataBinding(null, null);
					gridClientes.SetDataBinding(_uiController.ListaCuentas, null);
				}
				else
					MessageBox.Show("El Cliente ya ha sido agregado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void gridClientes_DeletingRecords(object sender, CancelEventArgs e)
		{
			if(gridClientes.SelectedItems.Count > 0)
			{
				ArrayList aux = new ArrayList();
				foreach(Janus.Windows.GridEX.GridEXSelectedItem item in gridClientes.SelectedItems)
				{
					aux.Add(item.GetRow().DataRow);
				}
				_uiController.ListaCuentasSeleccionadasABorrar = aux;
				//_uiController.Borrar(aux);
			}			
		}

		private void gridClientes_RecordsDeleted(object sender, EventArgs e)
		{
			if(gridClientes.RecordCount > 0)
			{
				gridClientes.SetDataBinding( null,null);
				gridClientes.SetDataBinding( _uiController.ListaCuentas,null);				
			}
		}

		private void CondicionVta_Change(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void FormaDePago_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int indice = e.Index;
			FormaDePago fp = (FormaDePago)listaDeFormasDePago.Items[indice];
			fp.Agregada = !fp.Agregada;
		}

		private void TipoDeComprobante_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			int indice = e.Index;
			TipoDeComprobante tdc = (TipoDeComprobante)listaDeComprobantes.Items[indice];
			tdc.Agregado = !tdc.Agregado;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmABMCondicionesDeVenta));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmbCondicionVta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.label3 = new System.Windows.Forms.Label();
			this.datosGeneralesContainer = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chActivo = new System.Windows.Forms.CheckBox();
			this.txtRecargo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.txtCuotas = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.metodoComparacionContainer = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.bNingunaFormaDePago = new Infragistics.Win.Misc.UltraButton();
			this.bTodasFormasDePago = new Infragistics.Win.Misc.UltraButton();
			this.label2 = new System.Windows.Forms.Label();
			this.listaDeFormasDePago = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.label26 = new System.Windows.Forms.Label();
			this.rbMetodoComparacionPorI = new System.Windows.Forms.RadioButton();
			this.rbMetodoComparacionPorE = new System.Windows.Forms.RadioButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tiposDeComprobantesContainer = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label27 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbMetAsigTipCompPorI = new System.Windows.Forms.RadioButton();
			this.rbMetAsigTipCompPorE = new System.Windows.Forms.RadioButton();
			this.label25 = new System.Windows.Forms.Label();
			this.bNingunoTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.bTodosTiposDeComprobantes = new Infragistics.Win.Misc.UltraButton();
			this.listaDeComprobantes = new mz.erp.ui.controls.ToolTipCheckedListBox();
			this.clientesAsociadosContainer = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCuentasControl1 = new mz.erp.ui.controls.mzCuentasControl();
			this.label28 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbMetAsigCuentaPorI = new System.Windows.Forms.RadioButton();
			this.rbMetAsigCuentaPorE = new System.Windows.Forms.RadioButton();
			this.agregarCliente = new Infragistics.Win.Misc.UltraButton();
			this.gridClientes = new Janus.Windows.GridEX.GridEX();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.datosGeneralesContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).BeginInit();
			this.metodoComparacionContainer.SuspendLayout();
			this.tiposDeComprobantesContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			this.clientesAsociadosContainer.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(822, 39);
			this.ultraExplorerBarContainerControl4.TabIndex = 5;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(822, 32);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbCondicionVta);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 28);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(822, 56);
			this.ultraExplorerBarContainerControl1.TabIndex = 7;
			// 
			// mzCmbCondicionVta
			// 
			this.mzCmbCondicionVta.DataValue = "";
			this.mzCmbCondicionVta.EditObject = null;
			this.mzCmbCondicionVta.FastSearch = false;
			this.mzCmbCondicionVta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCondicionVta.HierarchicalSearch = false;
			this.mzCmbCondicionVta.Location = new System.Drawing.Point(184, 16);
			this.mzCmbCondicionVta.Name = "mzCmbCondicionVta";
			this.mzCmbCondicionVta.ReadOnly = false;
			this.mzCmbCondicionVta.SearchObject = null;
			this.mzCmbCondicionVta.SearchObjectListener = null;
			this.mzCmbCondicionVta.Size = new System.Drawing.Size(496, 22);
			this.mzCmbCondicionVta.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(32, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 35;
			this.label3.Text = "Condiciones de Venta";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// datosGeneralesContainer
			// 
			this.datosGeneralesContainer.Controls.Add(this.chActivo);
			this.datosGeneralesContainer.Controls.Add(this.txtRecargo);
			this.datosGeneralesContainer.Controls.Add(this.txtCuotas);
			this.datosGeneralesContainer.Controls.Add(this.txtDescripcion);
			this.datosGeneralesContainer.Controls.Add(this.label1);
			this.datosGeneralesContainer.Controls.Add(this.label5);
			this.datosGeneralesContainer.Controls.Add(this.label6);
			this.datosGeneralesContainer.Location = new System.Drawing.Point(28, -91);
			this.datosGeneralesContainer.Name = "datosGeneralesContainer";
			this.datosGeneralesContainer.Size = new System.Drawing.Size(822, 112);
			this.datosGeneralesContainer.TabIndex = 0;
			// 
			// chActivo
			// 
			this.chActivo.BackColor = System.Drawing.Color.Transparent;
			this.chActivo.Checked = true;
			this.chActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chActivo.Location = new System.Drawing.Point(51, 88);
			this.chActivo.Name = "chActivo";
			this.chActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chActivo.Size = new System.Drawing.Size(158, 16);
			this.chActivo.TabIndex = 41;
			this.chActivo.Text = "Activo";
			this.chActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRecargo
			// 
			this.txtRecargo.Location = new System.Drawing.Point(195, 32);
			this.txtRecargo.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludeLiterals;
			this.txtRecargo.MaskInput = "-nnn.nn";
			this.txtRecargo.MaxValue = 999;
			this.txtRecargo.MinValue = -999;
			this.txtRecargo.Name = "txtRecargo";
			this.txtRecargo.Nullable = true;
			this.txtRecargo.NullText = "000.00";
			this.txtRecargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.txtRecargo.PromptChar = '0';
			this.txtRecargo.Size = new System.Drawing.Size(184, 21);
			this.txtRecargo.TabIndex = 37;
			// 
			// txtCuotas
			// 
			this.txtCuotas.Location = new System.Drawing.Point(195, 56);
			this.txtCuotas.Name = "txtCuotas";
			this.txtCuotas.Size = new System.Drawing.Size(184, 20);
			this.txtCuotas.TabIndex = 38;
			this.txtCuotas.Text = "";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(195, 8);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(184, 20);
			this.txtDescripcion.TabIndex = 36;
			this.txtDescripcion.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(51, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 39;
			this.label1.Text = "Vencimiento de las cuotas";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(51, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 35;
			this.label5.Text = "Porcentaje de Recargo ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(51, 8);
			this.label6.Name = "label6";
			this.label6.TabIndex = 34;
			this.label6.Text = "Descripción";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// metodoComparacionContainer
			// 
			this.metodoComparacionContainer.Controls.Add(this.bNingunaFormaDePago);
			this.metodoComparacionContainer.Controls.Add(this.bTodasFormasDePago);
			this.metodoComparacionContainer.Controls.Add(this.label2);
			this.metodoComparacionContainer.Controls.Add(this.listaDeFormasDePago);
			this.metodoComparacionContainer.Controls.Add(this.label26);
			this.metodoComparacionContainer.Controls.Add(this.rbMetodoComparacionPorI);
			this.metodoComparacionContainer.Controls.Add(this.rbMetodoComparacionPorE);
			this.metodoComparacionContainer.Controls.Add(this.panel3);
			this.metodoComparacionContainer.Location = new System.Drawing.Point(28, -187);
			this.metodoComparacionContainer.Name = "metodoComparacionContainer";
			this.metodoComparacionContainer.Size = new System.Drawing.Size(822, 186);
			this.metodoComparacionContainer.TabIndex = 0;
			// 
			// bNingunaFormaDePago
			// 
			this.bNingunaFormaDePago.AcceptsFocus = false;
			this.bNingunaFormaDePago.Location = new System.Drawing.Point(0, 104);
			this.bNingunaFormaDePago.Name = "bNingunaFormaDePago";
			this.bNingunaFormaDePago.Size = new System.Drawing.Size(64, 22);
			this.bNingunaFormaDePago.TabIndex = 50;
			this.bNingunaFormaDePago.TabStop = false;
			this.bNingunaFormaDePago.Text = "&Ninguno";
			// 
			// bTodasFormasDePago
			// 
			this.bTodasFormasDePago.AcceptsFocus = false;
			this.bTodasFormasDePago.Location = new System.Drawing.Point(0, 80);
			this.bTodasFormasDePago.Name = "bTodasFormasDePago";
			this.bTodasFormasDePago.Size = new System.Drawing.Size(64, 22);
			this.bTodasFormasDePago.TabIndex = 49;
			this.bTodasFormasDePago.TabStop = false;
			this.bTodasFormasDePago.Text = "&Todos";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(592, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 56);
			this.label2.TabIndex = 47;
			this.label2.Text = "Seleccione la/s Forma/s de Pago/s a la/s cual/es se asocia la nueva forma de pago" +
				"";
			// 
			// listaDeFormasDePago
			// 
			this.listaDeFormasDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listaDeFormasDePago.Location = new System.Drawing.Point(64, 48);
			this.listaDeFormasDePago.MultiColumn = true;
			this.listaDeFormasDePago.Name = "listaDeFormasDePago";
			this.listaDeFormasDePago.Size = new System.Drawing.Size(520, 124);
			this.listaDeFormasDePago.TabIndex = 44;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(16, 11);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(136, 16);
			this.label26.TabIndex = 30;
			this.label26.Text = "Método de Comparación";
			// 
			// rbMetodoComparacionPorI
			// 
			this.rbMetodoComparacionPorI.AccessibleDescription = "";
			this.rbMetodoComparacionPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetodoComparacionPorI.Location = new System.Drawing.Point(272, 11);
			this.rbMetodoComparacionPorI.Name = "rbMetodoComparacionPorI";
			this.rbMetodoComparacionPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetodoComparacionPorI.TabIndex = 29;
			this.rbMetodoComparacionPorI.Text = "Por Inclusión";
			// 
			// rbMetodoComparacionPorE
			// 
			this.rbMetodoComparacionPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetodoComparacionPorE.Location = new System.Drawing.Point(160, 11);
			this.rbMetodoComparacionPorE.Name = "rbMetodoComparacionPorE";
			this.rbMetodoComparacionPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetodoComparacionPorE.TabIndex = 28;
			this.rbMetodoComparacionPorE.Text = "Por Exclusión";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Location = new System.Drawing.Point(152, 8);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(376, 24);
			this.panel3.TabIndex = 48;
			// 
			// tiposDeComprobantesContainer
			// 
			this.tiposDeComprobantesContainer.Controls.Add(this.label27);
			this.tiposDeComprobantesContainer.Controls.Add(this.panel1);
			this.tiposDeComprobantesContainer.Controls.Add(this.label25);
			this.tiposDeComprobantesContainer.Controls.Add(this.bNingunoTiposDeComprobantes);
			this.tiposDeComprobantesContainer.Controls.Add(this.bTodosTiposDeComprobantes);
			this.tiposDeComprobantesContainer.Controls.Add(this.listaDeComprobantes);
			this.tiposDeComprobantesContainer.Location = new System.Drawing.Point(28, 58);
			this.tiposDeComprobantesContainer.Name = "tiposDeComprobantesContainer";
			this.tiposDeComprobantesContainer.Size = new System.Drawing.Size(822, 175);
			this.tiposDeComprobantesContainer.TabIndex = 2;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(-1, 16);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(128, 16);
			this.label27.TabIndex = 48;
			this.label27.Text = "Método de Asignación";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.rbMetAsigTipCompPorI);
			this.panel1.Controls.Add(this.rbMetAsigTipCompPorE);
			this.panel1.Location = new System.Drawing.Point(135, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(376, 24);
			this.panel1.TabIndex = 47;
			// 
			// rbMetAsigTipCompPorI
			// 
			this.rbMetAsigTipCompPorI.AccessibleDescription = "";
			this.rbMetAsigTipCompPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigTipCompPorI.Location = new System.Drawing.Point(144, 5);
			this.rbMetAsigTipCompPorI.Name = "rbMetAsigTipCompPorI";
			this.rbMetAsigTipCompPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigTipCompPorI.TabIndex = 23;
			this.rbMetAsigTipCompPorI.Text = "Por Inclusión";
			// 
			// rbMetAsigTipCompPorE
			// 
			this.rbMetAsigTipCompPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigTipCompPorE.Location = new System.Drawing.Point(16, 5);
			this.rbMetAsigTipCompPorE.Name = "rbMetAsigTipCompPorE";
			this.rbMetAsigTipCompPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigTipCompPorE.TabIndex = 22;
			this.rbMetAsigTipCompPorE.Text = "Por Exclusión";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(591, 61);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(232, 56);
			this.label25.TabIndex = 46;
			this.label25.Text = "Seleccione lo/s Tipo/s de Comprobante/s a lo/s cual/es se asocia la nueva forma d" +
				"e pago";
			// 
			// bNingunoTiposDeComprobantes
			// 
			this.bNingunoTiposDeComprobantes.AcceptsFocus = false;
			this.bNingunoTiposDeComprobantes.Location = new System.Drawing.Point(-1, 101);
			this.bNingunoTiposDeComprobantes.Name = "bNingunoTiposDeComprobantes";
			this.bNingunoTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bNingunoTiposDeComprobantes.TabIndex = 45;
			this.bNingunoTiposDeComprobantes.TabStop = false;
			this.bNingunoTiposDeComprobantes.Text = "&Ninguno";
			// 
			// bTodosTiposDeComprobantes
			// 
			this.bTodosTiposDeComprobantes.AcceptsFocus = false;
			this.bTodosTiposDeComprobantes.Location = new System.Drawing.Point(-1, 77);
			this.bTodosTiposDeComprobantes.Name = "bTodosTiposDeComprobantes";
			this.bTodosTiposDeComprobantes.Size = new System.Drawing.Size(64, 22);
			this.bTodosTiposDeComprobantes.TabIndex = 44;
			this.bTodosTiposDeComprobantes.TabStop = false;
			this.bTodosTiposDeComprobantes.Text = "&Todos";
			// 
			// listaDeComprobantes
			// 
			this.listaDeComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listaDeComprobantes.Location = new System.Drawing.Point(63, 40);
			this.listaDeComprobantes.MultiColumn = true;
			this.listaDeComprobantes.Name = "listaDeComprobantes";
			this.listaDeComprobantes.Size = new System.Drawing.Size(520, 124);
			this.listaDeComprobantes.TabIndex = 43;
			// 
			// clientesAsociadosContainer
			// 
			this.clientesAsociadosContainer.Controls.Add(this.mzCuentasControl1);
			this.clientesAsociadosContainer.Controls.Add(this.label28);
			this.clientesAsociadosContainer.Controls.Add(this.panel2);
			this.clientesAsociadosContainer.Controls.Add(this.agregarCliente);
			this.clientesAsociadosContainer.Controls.Add(this.gridClientes);
			this.clientesAsociadosContainer.Location = new System.Drawing.Point(28, 292);
			this.clientesAsociadosContainer.Name = "clientesAsociadosContainer";
			this.clientesAsociadosContainer.Size = new System.Drawing.Size(822, 208);
			this.clientesAsociadosContainer.TabIndex = 6;
			// 
			// mzCuentasControl1
			// 
			this.mzCuentasControl1.AllowEditClientePaso = false;
			this.mzCuentasControl1.BackColor = System.Drawing.SystemColors.Control;
			this.mzCuentasControl1.DataValue = "";
			this.mzCuentasControl1.EnableCtaCte = false;
			this.mzCuentasControl1.FastSearch = false;
			this.mzCuentasControl1.Location = new System.Drawing.Point(56, 48);
			this.mzCuentasControl1.Name = "mzCuentasControl1";
			this.mzCuentasControl1.SearchObjectListener = null;
			this.mzCuentasControl1.Size = new System.Drawing.Size(512, 22);
			this.mzCuentasControl1.TabIndex = 50;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(51, 16);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(128, 16);
			this.label28.TabIndex = 49;
			this.label28.Text = "Método de Asignación";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.rbMetAsigCuentaPorI);
			this.panel2.Controls.Add(this.rbMetAsigCuentaPorE);
			this.panel2.Location = new System.Drawing.Point(187, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(376, 24);
			this.panel2.TabIndex = 48;
			// 
			// rbMetAsigCuentaPorI
			// 
			this.rbMetAsigCuentaPorI.AccessibleDescription = "";
			this.rbMetAsigCuentaPorI.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigCuentaPorI.Location = new System.Drawing.Point(144, 5);
			this.rbMetAsigCuentaPorI.Name = "rbMetAsigCuentaPorI";
			this.rbMetAsigCuentaPorI.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigCuentaPorI.TabIndex = 23;
			this.rbMetAsigCuentaPorI.Text = "Por Inclusión";
			// 
			// rbMetAsigCuentaPorE
			// 
			this.rbMetAsigCuentaPorE.BackColor = System.Drawing.Color.Transparent;
			this.rbMetAsigCuentaPorE.Location = new System.Drawing.Point(16, 5);
			this.rbMetAsigCuentaPorE.Name = "rbMetAsigCuentaPorE";
			this.rbMetAsigCuentaPorE.Size = new System.Drawing.Size(104, 16);
			this.rbMetAsigCuentaPorE.TabIndex = 22;
			this.rbMetAsigCuentaPorE.Text = "Por Exclusión";
			// 
			// agregarCliente
			// 
			this.agregarCliente.AcceptsFocus = false;
			this.agregarCliente.Location = new System.Drawing.Point(576, 48);
			this.agregarCliente.Name = "agregarCliente";
			this.agregarCliente.Size = new System.Drawing.Size(112, 24);
			this.agregarCliente.TabIndex = 47;
			this.agregarCliente.TabStop = false;
			this.agregarCliente.Text = "Agregar Cliente";
			// 
			// gridClientes
			// 
			this.gridClientes.AllowCardSizing = false;
			this.gridClientes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridClientes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridClientes.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridClientes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridClientes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridClientes.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridClientes.Location = new System.Drawing.Point(56, 72);
			this.gridClientes.Name = "gridClientes";
			this.gridClientes.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridClientes.Size = new System.Drawing.Size(640, 128);
			this.gridClientes.TabIndex = 46;
			this.gridClientes.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.datosGeneralesContainer);
			this.ultraExplorerBar1.Controls.Add(this.metodoComparacionContainer);
			this.ultraExplorerBar1.Controls.Add(this.tiposDeComprobantesContainer);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
			this.ultraExplorerBar1.Controls.Add(this.clientesAsociadosContainer);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl4;
			ultraExplorerBarGroup1.Key = "Tarea";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 39;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Enabled = false;
			ultraExplorerBarGroup2.Key = "Condiciones de Venta";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 56;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Condiciones de Venta";
			ultraExplorerBarGroup2.Visible = false;
			ultraExplorerBarGroup3.Container = this.datosGeneralesContainer;
			ultraExplorerBarGroup3.Enabled = false;
			ultraExplorerBarGroup3.Key = "Datos Generales";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 112;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Datos Generales";
			ultraExplorerBarGroup3.Visible = false;
			ultraExplorerBarGroup4.Container = this.metodoComparacionContainer;
			ultraExplorerBarGroup4.Enabled = false;
			ultraExplorerBarGroup4.Key = "Metodo de Comparacion";
			ultraExplorerBarGroup4.Settings.ContainerHeight = 186;
			ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup4.Text = "Método de Comparación";
			ultraExplorerBarGroup4.Visible = false;
			ultraExplorerBarGroup5.Container = this.tiposDeComprobantesContainer;
			ultraExplorerBarGroup5.Enabled = false;
			ultraExplorerBarGroup5.Key = "Tipos de Comprobantes";
			ultraExplorerBarGroup5.Settings.ContainerHeight = 175;
			ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup5.Text = "Tipos de Comprobantes";
			ultraExplorerBarGroup5.Visible = false;
			ultraExplorerBarGroup6.Container = this.clientesAsociadosContainer;
			ultraExplorerBarGroup6.Enabled = false;
			ultraExplorerBarGroup6.Key = "Clientes Asociados";
			ultraExplorerBarGroup6.Settings.ContainerHeight = 208;
			ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup6.Text = "Clientes Asociados";
			ultraExplorerBarGroup6.Visible = false;
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3,
																														ultraExplorerBarGroup4,
																														ultraExplorerBarGroup5,
																														ultraExplorerBarGroup6});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(888, 510);
			this.ultraExplorerBar1.TabIndex = 0;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// imageList2
			// 
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton3,
																						this.toolBarButton4,
																						this.toolBarButton5});
			this.toolBar1.ButtonSize = new System.Drawing.Size(77, 22);
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imglStandar;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(888, 28);
			this.toolBar1.TabIndex = 21;
			this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 9;
			this.toolBarButton1.Text = "&Anterior";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 8;
			this.toolBarButton3.Text = "&Siguiente";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.ImageIndex = 7;
			this.toolBarButton5.Text = "&Cancelar";
			// 
			// FrmABMCondicionesDeVenta
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(888, 510);
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Name = "FrmABMCondicionesDeVenta";
			this.Text = "FrmABMCondicionesDeVenta";
			this.TransparencyKey = System.Drawing.Color.Silver;
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.datosGeneralesContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).EndInit();
			this.metodoComparacionContainer.ResumeLayout(false);
			this.tiposDeComprobantesContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.clientesAsociadosContainer.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

	}
}

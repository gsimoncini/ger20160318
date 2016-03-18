using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.controls;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;
//German 20120208 - Tarea 0000276
using mz.erp.businessrules;
//German 20120208 - Tarea 0000276

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmModificarProductosMasivo.
	/// </summary>
	public class FrmModificarProductosMasivo : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerProductos;
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.Misc.UltraButton bNingunoCaja;
		private Infragistics.Win.Misc.UltraButton bTodosCaja;
		private System.Windows.Forms.RadioButton rbSeleccionMultiple;
		private System.Windows.Forms.RadioButton rbSeleccionSimple;
		private Janus.Windows.GridEX.GridEX gridProductos;
		private System.Windows.Forms.Label label9;
		private System.ComponentModel.IContainer components;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerInfoAdicional;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtObservaciones;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar1;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar2;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private System.Windows.Forms.TextBox txtCampoAuxiliar1;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar3;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar4;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar5;
		private System.Windows.Forms.TextBox txtCampoAuxiliar4;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private System.Windows.Forms.TextBox txtCampoAuxiliar5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl containerAvanzadas;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor ucePercibeIB;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkObligaNumeroSerie;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkObligaCodigoBarra;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux2;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux3;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux4;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux5;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarObservaciones;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCodBarras;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarNumSerie;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarIngBrutos;
		private mz.erp.ui.controls.mzProductosControl mzProductosControl;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbProveedor;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarCAux6;
		private System.Windows.Forms.Label lblEtiquetaCampoAuxiliar6;
		private mz.erp.ui.controls.mzSearchTextBox mzSearchTextBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbAgregar;
		private System.Windows.Forms.RadioButton rbEliminar;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarProveedorDefault;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkPermiteCambio;
        private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarBonificaciones;
        private Janus.Windows.GridEX.GridEX gridEX1;
        private Label label6;
        private Label label14;
        private mzComboEditor mzCEBonificacion;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkHabilitarActivo;

		#region Construtores
		public FrmModificarProductosMasivo(ModificarProductosMasivoController uiController)
		{			
			InitializeComponent();
			_uiController = uiController;
		}
        #endregion

		#region Variables Privadas

		private ModificarProductosMasivoController _uiController;
		private int _selectedIndex = 0;


		#endregion

		#region Metodos Privados

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();	
			if(gridProductos.RecordCount > 0)
			{
				gridProductos.Row = 0;
				gridProductos.Select();
				this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
				

			}
			
		}

		
		private void ConfigureInterface()
		{
			//Cristian Configuracion Imagelist 20110717

            tbbAnterior.ImageIndex = 1;
            tbbCancelar.ImageIndex = 0;
            tbbSiguiente.ImageIndex = 2;

            Util.LoadImagesWorkflow(this.toolBarStandar,this.imglStandar);

            //Fin Cristian Configuracion Imagelist 20110717
            
            this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			
			mzProductosControl.Enabled = _uiController.EnableBuscadorProducto;
			mzProductosControl.SetProcess(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), "V");

			gridProductos.LayoutData = _uiController.LayoutProductos;
			gridProductos.GroupByBoxVisible = false;
			gridProductos.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			this.mzProductosControl.EnabledCantidad = true;
			this.mzProductosControl.ReadOnlyCantidad = true;
			if(_uiController.AllowRemoveItems)
				gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			else gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;

			rbSeleccionSimple.Checked = !_uiController.SeleccionMultiple;
			rbSeleccionMultiple.Checked = _uiController.SeleccionMultiple;
			bTodosCaja.Enabled = _uiController.SeleccionMultiple;
			bNingunoCaja.Enabled = _uiController.SeleccionMultiple;

			if(_uiController.AllowSeleccionMultiple)
			{
				if(!_uiController.SeleccionMultiple)
				{
					gridProductos.RootTable.Columns["Selected"].Visible = false;
				}
			}
			gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			panel1.Enabled = _uiController.AllowSeleccionMultiple;

			lblEtiquetaCampoAuxiliar1.Text = _uiController.EtiquetaCampoAuxiliar1;
			lblEtiquetaCampoAuxiliar2.Text = _uiController.EtiquetaCampoAuxiliar2;
			lblEtiquetaCampoAuxiliar3.Text = _uiController.EtiquetaCampoAuxiliar3;
			lblEtiquetaCampoAuxiliar4.Text = _uiController.EtiquetaCampoAuxiliar4;
			lblEtiquetaCampoAuxiliar5.Text = _uiController.EtiquetaCampoAuxiliar5;
			lblEtiquetaCampoAuxiliar6.Text = _uiController.EtiquetaCampoAuxiliar6;

			mzProductosControl.EnabledListaDePrecio = false;
			mzCmbProveedor.SearchObject = typeof(mz.erp.ui.forms.classes.tpu_Proveedores);	
			mzSearchTextBox1.Init(true);
			mzSearchTextBox1.Enabled = false;
			groupBox1.Enabled = false;
			rbAgregar.Checked = true;
			mzCmbProveedor.Enabled = false;
			KeyPreview = true;

            //German 20120208 - Tarea 0000276

            mzCEBonificacion.Enabled = false;
            gridEX1.Enabled = false;
            gridEX1.LayoutData = new mz.erp.ui.forms.classes.tsa_BonificacionesDet().GetLayout();
            //German 20120208 - Tarea 0000276
			

		}

		private void InitializeData()
		{						
			mzProductosControl.AddObjectListener( (IObserver)_uiController );

            //German 20120208 - Tarea 0000276
            mzCEBonificacion.FillFromDataSource(businessrules.tsa_Bonificaciones.GetList(null, null, Constantes.TipoBonificacionProducto).tsa_Bonificaciones, "IdBonificacion", "Codigo", 100, "1", "2", "Codigo");
            //German 20120208 - Tarea 0000276

     	}
	
		private void InitEventHandlers()
		{			
			_uiController.ObjectHasChanged +=new EventHandler(RefreshControls);
			gridProductos.SelectionChanged +=new EventHandler(gridProductos_SelectionChanged);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			_uiController.ProductosCollectionChanged +=	new EventHandler(Refresh);
			rbSeleccionSimple.CheckedChanged +=new EventHandler(rbSeleccionMultiple_CheckedChanged);
			rbSeleccionMultiple.CheckedChanged +=new EventHandler(rbSeleccionMultiple_CheckedChanged);
			bTodosCaja.Click +=new EventHandler(bTodosCaja_Click);
			bNingunoCaja.Click +=new EventHandler(bNingunoCaja_Click);
			chkHabilitarCAux6.CheckedChanged+=new EventHandler(chkHabilitarCAux6_CheckedChanged);
			rbAgregar.CheckedChanged +=new EventHandler(rbAgregar_CheckedChanged);
			rbEliminar.CheckedChanged +=new EventHandler(rbEliminar_CheckedChanged);
			chkHabilitarProveedorDefault.CheckedChanged +=new EventHandler(chkHabilitarProveedorDefault_CheckedChanged);
			KeyDownManager KeyDownMan = new KeyDownManager(this);

            //German 20120208 - Tarea 0000276
            this.mzCEBonificacion.ValueChanged += new System.EventHandler(this.mzCEBonificacion_ValueChanged);
            mzCEBonificacion.KeyDown += new KeyEventHandler(mzCEBonificacion_KeyDown);
            chkHabilitarBonificaciones.CheckedChanged += new EventHandler(chkHabilitarBonificaciones_CheckedChanged);
            //German 20120208 - Tarea 0000276
		}

        void chkHabilitarBonificaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitarBonificaciones.Checked)
            {
                mzCEBonificacion.Enabled = true;
                gridEX1.Enabled = true;
            }
            else
            {
                mzCEBonificacion.Enabled = false;
                gridEX1.Enabled = false;

            }
        }

        //German 20120208 - Tarea 0000276
        private void mzCEBonificacion_ValueChanged(object sender, System.EventArgs e)
        {
            string IdBonificacion = (string)mzCEBonificacion.Value;
            if (IdBonificacion != null)
                gridEX1.DataSource = mz.erp.businessrules.tsa_BonificacionesDet.GetList(IdBonificacion, decimal.MinValue).tsa_BonificacionesDet;
            else gridEX1.DataSource = null;
        }


        private void mzCEBonificacion_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                //German 20120208 - Tarea 0000276
                mzCEBonificacion.FillFromDataSource(businessrules.tsa_Bonificaciones.GetList(null, null, Constantes.TipoBonificacionProducto).tsa_Bonificaciones, "IdBonificacion", "Codigo", 100, "1", "2", "Codigo");
                //German 20120208 - Tarea 0000276
                gridEX1.DataSource = null;
            }

        }
        //German 20120208 - Tarea 0000276

		private void RefreshControls(object sender, EventArgs e)
		{
			txtObservaciones.Text = _uiController.Observaciones;
			txtCampoAuxiliar1.Text = _uiController.CampoAuxiliar1;
			txtCampoAuxiliar2.Text = _uiController.CampoAuxiliar2;
			txtCampoAuxiliar3.Text = _uiController.CampoAuxiliar3;
			txtCampoAuxiliar4.Text = _uiController.CampoAuxiliar4;
			txtCampoAuxiliar5.Text = _uiController.CampoAuxiliar5;
			chkObligaCodigoBarra.Checked = _uiController.ObligaCodigoBarra;
			chkObligaNumeroSerie.Checked = _uiController.ObligaNumeroSerie;
			ucePercibeIB.Checked = _uiController.PercibeIngresosBrutos;
			chkActivo.Checked  = _uiController.Activo;
			mzCmbProveedor.DataValue = _uiController.IdProveedorDefault;
            /* Silvina 20110630 - Tarea 0000136 */
            chkPermiteCambio.Checked = _uiController.PermiteCambio;
            /* Fin Silvina 20110630 - Tarea 0000136 */
            //German 20120208 - Tarea 0000276
            mzCEBonificacion.Value = _uiController.IdBonificacion;
                ;
            //German 20120208 - Tarea 0000276
		}
	
		private void Refresh(object sender, EventArgs e)
		{
			try
			{
				gridProductos.SetDataBinding(null, null);
				gridProductos.SetDataBinding(_uiController.Items, null);
				gridProductos.UpdateData();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
	
		}
	
		private void InitDataBindings()
		{				
			txtObservaciones.DataBindings.Clear();
			txtCampoAuxiliar1.DataBindings.Clear();
			txtCampoAuxiliar2.DataBindings.Clear();
			txtCampoAuxiliar3.DataBindings.Clear();
			txtCampoAuxiliar4.DataBindings.Clear();
			txtCampoAuxiliar5.DataBindings.Clear();
			chkObligaCodigoBarra.DataBindings.Clear();
			chkObligaNumeroSerie.DataBindings.Clear();
			ucePercibeIB.DataBindings.Clear();
			chkActivo.DataBindings.Clear();
            mzCmbProveedor.DataBindings.Clear();
            /* Silvina 20110630 - Tarea 0000136 */
            chkPermiteCambio.DataBindings.Clear();
            /* Fin Silvina 20110630 - Tarea 0000136 */

			gridProductos.SetDataBinding(null, null);
			gridProductos.SetDataBinding(_uiController.Items, null);

			txtObservaciones.DataBindings.Add("Text", _uiController, "Observaciones");
			txtCampoAuxiliar1.DataBindings.Add("Text", _uiController, "CampoAuxiliar1");
			txtCampoAuxiliar2.DataBindings.Add("Text", _uiController, "CampoAuxiliar2");
			txtCampoAuxiliar3.DataBindings.Add("Text", _uiController, "CampoAuxiliar3");
			txtCampoAuxiliar4.DataBindings.Add("Text", _uiController, "CampoAuxiliar4");
			txtCampoAuxiliar5.DataBindings.Add("Text", _uiController, "CampoAuxiliar5");
			chkObligaCodigoBarra.DataBindings.Add("Checked", _uiController, "ObligaCodigoBarra");
			chkObligaNumeroSerie.DataBindings.Add("Checked", _uiController, "ObligaNumeroSerie");
			ucePercibeIB.DataBindings.Add("Checked", _uiController, "PercibeIngresosBrutos");
			chkActivo.DataBindings.Add("Checked", _uiController, "Activo");
			mzCmbProveedor.DataBindings.Add("DataValue", _uiController, "IdProveedorDefault");
            /* Silvina 20110630 - Tarea 0000136 */
            chkPermiteCambio.DataBindings.Add("Checked", _uiController, "PermiteCambio");
            /* Fin Silvina 20110630 - Tarea 0000136 */
            //German 20120208 - Tarea 0000276
            mzCEBonificacion.DataBindings.Add("Value", _uiController, "IdBonificacion");

            //German 20120208 - Tarea 0000276
		}

		private void Cancelar()
		{					
			this.CloseForm();
		}

		private void DumpControls()
		{
			if(txtObservaciones.Enabled)
                _uiController.Observaciones = txtObservaciones.Text;
			if(txtCampoAuxiliar1.Enabled)
                _uiController.CampoAuxiliar1 = txtCampoAuxiliar1.Text;
			if(txtCampoAuxiliar2.Enabled)
				_uiController.CampoAuxiliar2 = txtCampoAuxiliar2.Text;
			if(txtCampoAuxiliar3.Enabled)
				_uiController.CampoAuxiliar3 = txtCampoAuxiliar3.Text;
			if(txtCampoAuxiliar4.Enabled)
				_uiController.CampoAuxiliar4 = txtCampoAuxiliar4.Text;
			if(txtCampoAuxiliar5.Enabled)
				_uiController.CampoAuxiliar5 = txtCampoAuxiliar5.Text;
			if(mzSearchTextBox1.Enabled)
				_uiController.CampoAuxiliar6 = mzSearchTextBox1.NodeDescription;
			if(chkObligaCodigoBarra.Enabled)
				_uiController.ObligaCodigoBarra = chkObligaCodigoBarra.Checked;
			if(chkObligaNumeroSerie.Enabled)
				_uiController.ObligaNumeroSerie = chkObligaNumeroSerie.Checked;
			if(ucePercibeIB.Enabled)
				_uiController.PercibeIngresosBrutos = ucePercibeIB.Checked;
			if(chkActivo.Enabled)
				_uiController.Activo = chkActivo.Checked;
			if(chkHabilitarProveedorDefault.Checked)
				_uiController.IdProveedorDefault = Convert.ToString(mzCmbProveedor.DataValue);
            /* Silvina 20110630 - Tarea 0000136 */
            if (chkPermiteCambio.Enabled)
                _uiController.PermiteCambio = chkPermiteCambio.Checked;
            /* Fin Silvina 20110630 - Tarea 0000136 */

		}
		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this.DumpControls();
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
			this.Execute();
		}

		#endregion

		#region Windows Form
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
				_uiController.ObjectHasChanged -=new EventHandler(Refresh);
				gridProductos.SelectionChanged -=new EventHandler(gridProductos_SelectionChanged);
				txtObservaciones.DataBindings.Clear();
				txtCampoAuxiliar1.DataBindings.Clear();
				txtCampoAuxiliar2.DataBindings.Clear();
				txtCampoAuxiliar3.DataBindings.Clear();
				txtCampoAuxiliar4.DataBindings.Clear();
				txtCampoAuxiliar5.DataBindings.Clear();
				chkObligaCodigoBarra.DataBindings.Clear();
				chkObligaNumeroSerie.DataBindings.Clear();
				ucePercibeIB.DataBindings.Clear();
				chkActivo.DataBindings.Clear();
                //German 20120208 - Tarea 0000276
                mzCEBonificacion.DataBindings.Clear();
                //German 20120208 - Tarea 0000276


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
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.labelTarea = new System.Windows.Forms.Label();
            this.containerProductos = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzProductosControl = new mz.erp.ui.controls.mzProductosControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bNingunoCaja = new Infragistics.Win.Misc.UltraButton();
            this.bTodosCaja = new Infragistics.Win.Misc.UltraButton();
            this.rbSeleccionMultiple = new System.Windows.Forms.RadioButton();
            this.rbSeleccionSimple = new System.Windows.Forms.RadioButton();
            this.gridProductos = new Janus.Windows.GridEX.GridEX();
            this.label9 = new System.Windows.Forms.Label();
            this.containerInfoAdicional = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkHabilitarProveedorDefault = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbAgregar = new System.Windows.Forms.RadioButton();
            this.mzSearchTextBox1 = new mz.erp.ui.controls.mzSearchTextBox();
            this.chkHabilitarCAux6 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.lblEtiquetaCampoAuxiliar6 = new System.Windows.Forms.Label();
            this.mzCmbProveedor = new mz.erp.ui.controls.mzComboSearchEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHabilitarObservaciones = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarCAux5 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarCAux4 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarCAux3 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarCAux2 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarCAux1 = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.lblEtiquetaCampoAuxiliar5 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar5 = new System.Windows.Forms.TextBox();
            this.lblEtiquetaCampoAuxiliar3 = new System.Windows.Forms.Label();
            this.lblEtiquetaCampoAuxiliar4 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar4 = new System.Windows.Forms.TextBox();
            this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
            this.lblEtiquetaCampoAuxiliar1 = new System.Windows.Forms.Label();
            this.lblEtiquetaCampoAuxiliar2 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
            this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.containerAvanzadas = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.chkPermiteCambio = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarIngBrutos = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarNumSerie = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkHabilitarCodBarras = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ucePercibeIB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkObligaNumeroSerie = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.chkObligaCodigoBarra = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.toolBarStandar = new System.Windows.Forms.ToolBar();
            this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
            this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
            this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
            this.ultraExplorerBar = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
            this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mzCEBonificacion = new mz.erp.ui.controls.mzComboEditor();
            this.chkHabilitarBonificaciones = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraExplorerBarContainerControl2.SuspendLayout();
            this.containerProductos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.containerInfoAdicional.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.containerAvanzadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).BeginInit();
            this.ultraExplorerBar.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraExplorerBarContainerControl2
            // 
            this.ultraExplorerBarContainerControl2.Controls.Add(this.labelTarea);
            this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(-10000, -10000);
            this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
            this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(1027, 29);
            this.ultraExplorerBarContainerControl2.TabIndex = 2;
            this.ultraExplorerBarContainerControl2.Visible = false;
            // 
            // labelTarea
            // 
            this.labelTarea.BackColor = System.Drawing.Color.Transparent;
            this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarea.Location = new System.Drawing.Point(0, 0);
            this.labelTarea.Name = "labelTarea";
            this.labelTarea.Size = new System.Drawing.Size(1027, 23);
            this.labelTarea.TabIndex = 1;
            this.labelTarea.Text = "Tarea";
            this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerProductos
            // 
            this.containerProductos.Controls.Add(this.mzProductosControl);
            this.containerProductos.Controls.Add(this.panel1);
            this.containerProductos.Controls.Add(this.gridProductos);
            this.containerProductos.Controls.Add(this.label9);
            this.containerProductos.Location = new System.Drawing.Point(-10000, -10000);
            this.containerProductos.Name = "containerProductos";
            this.containerProductos.Size = new System.Drawing.Size(1027, 205);
            this.containerProductos.TabIndex = 3;
            this.containerProductos.Visible = false;
            // 
            // mzProductosControl
            // 
            this.mzProductosControl.BackColor = System.Drawing.Color.Transparent;
            this.mzProductosControl.EnabledCantidad = false;
            this.mzProductosControl.EnabledListaDePrecio = true;
            this.mzProductosControl.Location = new System.Drawing.Point(64, -8);
            this.mzProductosControl.Name = "mzProductosControl";
            this.mzProductosControl.PermiteProductosCombo = false;
            this.mzProductosControl.Size = new System.Drawing.Size(624, 48);
            this.mzProductosControl.TabIndex = 0;
            this.mzProductosControl.VisibleCantidad = true;
            this.mzProductosControl.VisibleComboListaDePrecios = true;
            this.mzProductosControl.VisibleComboTipoDePrecioDeCosto = false;
            this.mzProductosControl.VisiblePrecios = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bNingunoCaja);
            this.panel1.Controls.Add(this.bTodosCaja);
            this.panel1.Controls.Add(this.rbSeleccionMultiple);
            this.panel1.Controls.Add(this.rbSeleccionSimple);
            this.panel1.Location = new System.Drawing.Point(16, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 24);
            this.panel1.TabIndex = 76;
            // 
            // bNingunoCaja
            // 
            this.bNingunoCaja.AcceptsFocus = false;
            this.bNingunoCaja.Location = new System.Drawing.Point(392, 0);
            this.bNingunoCaja.Name = "bNingunoCaja";
            this.bNingunoCaja.Size = new System.Drawing.Size(64, 22);
            this.bNingunoCaja.TabIndex = 4;
            this.bNingunoCaja.TabStop = false;
            this.bNingunoCaja.Text = "&Ninguno";
            // 
            // bTodosCaja
            // 
            this.bTodosCaja.AcceptsFocus = false;
            this.bTodosCaja.Location = new System.Drawing.Point(328, 0);
            this.bTodosCaja.Name = "bTodosCaja";
            this.bTodosCaja.Size = new System.Drawing.Size(64, 22);
            this.bTodosCaja.TabIndex = 3;
            this.bTodosCaja.TabStop = false;
            this.bTodosCaja.Text = "&Todos";
            // 
            // rbSeleccionMultiple
            // 
            this.rbSeleccionMultiple.Location = new System.Drawing.Point(176, 0);
            this.rbSeleccionMultiple.Name = "rbSeleccionMultiple";
            this.rbSeleccionMultiple.Size = new System.Drawing.Size(152, 24);
            this.rbSeleccionMultiple.TabIndex = 2;
            this.rbSeleccionMultiple.Text = "Selección Múltiple";
            // 
            // rbSeleccionSimple
            // 
            this.rbSeleccionSimple.Location = new System.Drawing.Point(8, 0);
            this.rbSeleccionSimple.Name = "rbSeleccionSimple";
            this.rbSeleccionSimple.Size = new System.Drawing.Size(168, 24);
            this.rbSeleccionSimple.TabIndex = 1;
            this.rbSeleccionSimple.Text = "Selección Individual";
            // 
            // gridProductos
            // 
            this.gridProductos.AllowCardSizing = false;
            this.gridProductos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProductos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridProductos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridProductos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
            this.gridProductos.Location = new System.Drawing.Point(16, 72);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(730, 120);
            this.gridProductos.TabIndex = 5;
            this.gridProductos.TabStop = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(11, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Producto";
            // 
            // containerInfoAdicional
            // 
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarProveedorDefault);
            this.containerInfoAdicional.Controls.Add(this.groupBox1);
            this.containerInfoAdicional.Controls.Add(this.mzSearchTextBox1);
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarCAux6);
            this.containerInfoAdicional.Controls.Add(this.lblEtiquetaCampoAuxiliar6);
            this.containerInfoAdicional.Controls.Add(this.mzCmbProveedor);
            this.containerInfoAdicional.Controls.Add(this.label1);
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarObservaciones);
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarCAux5);
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarCAux4);
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarCAux3);
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarCAux2);
            this.containerInfoAdicional.Controls.Add(this.chkHabilitarCAux1);
            this.containerInfoAdicional.Controls.Add(this.lblEtiquetaCampoAuxiliar5);
            this.containerInfoAdicional.Controls.Add(this.txtCampoAuxiliar5);
            this.containerInfoAdicional.Controls.Add(this.lblEtiquetaCampoAuxiliar3);
            this.containerInfoAdicional.Controls.Add(this.lblEtiquetaCampoAuxiliar4);
            this.containerInfoAdicional.Controls.Add(this.txtCampoAuxiliar4);
            this.containerInfoAdicional.Controls.Add(this.txtCampoAuxiliar3);
            this.containerInfoAdicional.Controls.Add(this.lblEtiquetaCampoAuxiliar1);
            this.containerInfoAdicional.Controls.Add(this.lblEtiquetaCampoAuxiliar2);
            this.containerInfoAdicional.Controls.Add(this.txtCampoAuxiliar2);
            this.containerInfoAdicional.Controls.Add(this.txtCampoAuxiliar1);
            this.containerInfoAdicional.Controls.Add(this.txtObservaciones);
            this.containerInfoAdicional.Controls.Add(this.label24);
            this.containerInfoAdicional.Location = new System.Drawing.Point(28, -101);
            this.containerInfoAdicional.Name = "containerInfoAdicional";
            this.containerInfoAdicional.Size = new System.Drawing.Size(1027, 240);
            this.containerInfoAdicional.TabIndex = 0;
            // 
            // chkHabilitarProveedorDefault
            // 
            this.chkHabilitarProveedorDefault.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarProveedorDefault.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarProveedorDefault.Enabled = false;
            this.chkHabilitarProveedorDefault.Location = new System.Drawing.Point(624, 240);
            this.chkHabilitarProveedorDefault.Name = "chkHabilitarProveedorDefault";
            this.chkHabilitarProveedorDefault.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarProveedorDefault.TabIndex = 132;
            this.chkHabilitarProveedorDefault.Text = "Habilitar su modificación";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbEliminar);
            this.groupBox1.Controls.Add(this.rbAgregar);
            this.groupBox1.Location = new System.Drawing.Point(616, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 32);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            // 
            // rbEliminar
            // 
            this.rbEliminar.Location = new System.Drawing.Point(112, 6);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(92, 24);
            this.rbEliminar.TabIndex = 15;
            this.rbEliminar.Text = "Quitar";
            // 
            // rbAgregar
            // 
            this.rbAgregar.Location = new System.Drawing.Point(7, 6);
            this.rbAgregar.Name = "rbAgregar";
            this.rbAgregar.Size = new System.Drawing.Size(92, 24);
            this.rbAgregar.TabIndex = 14;
            this.rbAgregar.Text = "Agregar";
            // 
            // mzSearchTextBox1
            // 
            this.mzSearchTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.mzSearchTextBox1.Location = new System.Drawing.Point(120, 216);
            this.mzSearchTextBox1.Name = "mzSearchTextBox1";
            this.mzSearchTextBox1.Size = new System.Drawing.Size(312, 24);
            this.mzSearchTextBox1.TabIndex = 12;
            // 
            // chkHabilitarCAux6
            // 
            this.chkHabilitarCAux6.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux6.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux6.Enabled = false;
            this.chkHabilitarCAux6.Location = new System.Drawing.Point(448, 216);
            this.chkHabilitarCAux6.Name = "chkHabilitarCAux6";
            this.chkHabilitarCAux6.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarCAux6.TabIndex = 13;
            this.chkHabilitarCAux6.Text = "Habilitar su modificación";
            // 
            // lblEtiquetaCampoAuxiliar6
            // 
            this.lblEtiquetaCampoAuxiliar6.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar6.Location = new System.Drawing.Point(0, 216);
            this.lblEtiquetaCampoAuxiliar6.Name = "lblEtiquetaCampoAuxiliar6";
            this.lblEtiquetaCampoAuxiliar6.Size = new System.Drawing.Size(120, 18);
            this.lblEtiquetaCampoAuxiliar6.TabIndex = 128;
            this.lblEtiquetaCampoAuxiliar6.Text = "Campo Auxiliar6";
            // 
            // mzCmbProveedor
            // 
            this.mzCmbProveedor.DataValue = "";
            this.mzCmbProveedor.EditObject = null;
            this.mzCmbProveedor.FastSearch = false;
            this.mzCmbProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbProveedor.HierarchicalSearch = false;
            this.mzCmbProveedor.Location = new System.Drawing.Point(120, 240);
            this.mzCmbProveedor.Name = "mzCmbProveedor";
            this.mzCmbProveedor.ReadOnly = false;
            this.mzCmbProveedor.SearchObject = null;
            this.mzCmbProveedor.SearchObjectListener = null;
            this.mzCmbProveedor.Size = new System.Drawing.Size(496, 22);
            this.mzCmbProveedor.TabIndex = 126;
            this.mzCmbProveedor.Tag = "ResponsableEmision";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 125;
            this.label1.Tag = "Proveedor";
            this.label1.Text = "Proveedor";
            // 
            // chkHabilitarObservaciones
            // 
            this.chkHabilitarObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarObservaciones.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarObservaciones.Enabled = false;
            this.chkHabilitarObservaciones.Location = new System.Drawing.Point(120, 0);
            this.chkHabilitarObservaciones.Name = "chkHabilitarObservaciones";
            this.chkHabilitarObservaciones.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarObservaciones.TabIndex = 0;
            this.chkHabilitarObservaciones.Text = "Habilitar su modificación";
            this.chkHabilitarObservaciones.CheckedChanged += new System.EventHandler(this.chkHabilitarObservaciones_CheckedChanged);
            // 
            // chkHabilitarCAux5
            // 
            this.chkHabilitarCAux5.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux5.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux5.Enabled = false;
            this.chkHabilitarCAux5.Location = new System.Drawing.Point(448, 195);
            this.chkHabilitarCAux5.Name = "chkHabilitarCAux5";
            this.chkHabilitarCAux5.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarCAux5.TabIndex = 11;
            this.chkHabilitarCAux5.Text = "Habilitar su modificación";
            this.chkHabilitarCAux5.CheckedChanged += new System.EventHandler(this.chkHabilitarCAux5_CheckedChanged);
            // 
            // chkHabilitarCAux4
            // 
            this.chkHabilitarCAux4.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux4.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux4.Enabled = false;
            this.chkHabilitarCAux4.Location = new System.Drawing.Point(448, 174);
            this.chkHabilitarCAux4.Name = "chkHabilitarCAux4";
            this.chkHabilitarCAux4.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarCAux4.TabIndex = 9;
            this.chkHabilitarCAux4.Text = "Habilitar su modificación";
            this.chkHabilitarCAux4.CheckedChanged += new System.EventHandler(this.chkHabilitarCAux4_CheckedChanged);
            // 
            // chkHabilitarCAux3
            // 
            this.chkHabilitarCAux3.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux3.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux3.Enabled = false;
            this.chkHabilitarCAux3.Location = new System.Drawing.Point(448, 154);
            this.chkHabilitarCAux3.Name = "chkHabilitarCAux3";
            this.chkHabilitarCAux3.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarCAux3.TabIndex = 7;
            this.chkHabilitarCAux3.Text = "Habilitar su modificación";
            this.chkHabilitarCAux3.CheckedChanged += new System.EventHandler(this.chkHabilitarCAux3_CheckedChanged);
            // 
            // chkHabilitarCAux2
            // 
            this.chkHabilitarCAux2.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux2.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux2.Enabled = false;
            this.chkHabilitarCAux2.Location = new System.Drawing.Point(448, 134);
            this.chkHabilitarCAux2.Name = "chkHabilitarCAux2";
            this.chkHabilitarCAux2.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarCAux2.TabIndex = 5;
            this.chkHabilitarCAux2.Text = "Habilitar su modificación";
            this.chkHabilitarCAux2.CheckedChanged += new System.EventHandler(this.chkHabilitarCAux2_CheckedChanged);
            // 
            // chkHabilitarCAux1
            // 
            this.chkHabilitarCAux1.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux1.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarCAux1.Enabled = false;
            this.chkHabilitarCAux1.Location = new System.Drawing.Point(448, 114);
            this.chkHabilitarCAux1.Name = "chkHabilitarCAux1";
            this.chkHabilitarCAux1.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarCAux1.TabIndex = 3;
            this.chkHabilitarCAux1.Text = "Habilitar su modificación";
            this.chkHabilitarCAux1.CheckedChanged += new System.EventHandler(this.chkHabilitarCAux1_CheckedChanged);
            // 
            // lblEtiquetaCampoAuxiliar5
            // 
            this.lblEtiquetaCampoAuxiliar5.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar5.Location = new System.Drawing.Point(0, 195);
            this.lblEtiquetaCampoAuxiliar5.Name = "lblEtiquetaCampoAuxiliar5";
            this.lblEtiquetaCampoAuxiliar5.Size = new System.Drawing.Size(120, 18);
            this.lblEtiquetaCampoAuxiliar5.TabIndex = 59;
            this.lblEtiquetaCampoAuxiliar5.Text = "Campo Auxiliar5";
            // 
            // txtCampoAuxiliar5
            // 
            this.txtCampoAuxiliar5.Enabled = false;
            this.txtCampoAuxiliar5.Location = new System.Drawing.Point(120, 194);
            this.txtCampoAuxiliar5.MaxLength = 256;
            this.txtCampoAuxiliar5.Name = "txtCampoAuxiliar5";
            this.txtCampoAuxiliar5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar5.Size = new System.Drawing.Size(312, 20);
            this.txtCampoAuxiliar5.TabIndex = 10;
            this.txtCampoAuxiliar5.WordWrap = false;
            // 
            // lblEtiquetaCampoAuxiliar3
            // 
            this.lblEtiquetaCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar3.Location = new System.Drawing.Point(0, 154);
            this.lblEtiquetaCampoAuxiliar3.Name = "lblEtiquetaCampoAuxiliar3";
            this.lblEtiquetaCampoAuxiliar3.Size = new System.Drawing.Size(120, 18);
            this.lblEtiquetaCampoAuxiliar3.TabIndex = 57;
            this.lblEtiquetaCampoAuxiliar3.Text = "Campo Auxiliar3";
            // 
            // lblEtiquetaCampoAuxiliar4
            // 
            this.lblEtiquetaCampoAuxiliar4.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar4.Location = new System.Drawing.Point(0, 174);
            this.lblEtiquetaCampoAuxiliar4.Name = "lblEtiquetaCampoAuxiliar4";
            this.lblEtiquetaCampoAuxiliar4.Size = new System.Drawing.Size(120, 18);
            this.lblEtiquetaCampoAuxiliar4.TabIndex = 56;
            this.lblEtiquetaCampoAuxiliar4.Text = "Campo Auxiliar4";
            // 
            // txtCampoAuxiliar4
            // 
            this.txtCampoAuxiliar4.Enabled = false;
            this.txtCampoAuxiliar4.Location = new System.Drawing.Point(120, 174);
            this.txtCampoAuxiliar4.MaxLength = 174;
            this.txtCampoAuxiliar4.Name = "txtCampoAuxiliar4";
            this.txtCampoAuxiliar4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar4.Size = new System.Drawing.Size(312, 20);
            this.txtCampoAuxiliar4.TabIndex = 8;
            this.txtCampoAuxiliar4.WordWrap = false;
            // 
            // txtCampoAuxiliar3
            // 
            this.txtCampoAuxiliar3.Enabled = false;
            this.txtCampoAuxiliar3.Location = new System.Drawing.Point(120, 154);
            this.txtCampoAuxiliar3.MaxLength = 256;
            this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
            this.txtCampoAuxiliar3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar3.Size = new System.Drawing.Size(312, 20);
            this.txtCampoAuxiliar3.TabIndex = 6;
            this.txtCampoAuxiliar3.WordWrap = false;
            // 
            // lblEtiquetaCampoAuxiliar1
            // 
            this.lblEtiquetaCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar1.Location = new System.Drawing.Point(0, 114);
            this.lblEtiquetaCampoAuxiliar1.Name = "lblEtiquetaCampoAuxiliar1";
            this.lblEtiquetaCampoAuxiliar1.Size = new System.Drawing.Size(120, 18);
            this.lblEtiquetaCampoAuxiliar1.TabIndex = 53;
            this.lblEtiquetaCampoAuxiliar1.Text = "Campo Auxiliar1";
            // 
            // lblEtiquetaCampoAuxiliar2
            // 
            this.lblEtiquetaCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaCampoAuxiliar2.Location = new System.Drawing.Point(0, 134);
            this.lblEtiquetaCampoAuxiliar2.Name = "lblEtiquetaCampoAuxiliar2";
            this.lblEtiquetaCampoAuxiliar2.Size = new System.Drawing.Size(120, 18);
            this.lblEtiquetaCampoAuxiliar2.TabIndex = 52;
            this.lblEtiquetaCampoAuxiliar2.Text = "Campo Auxiliar2";
            // 
            // txtCampoAuxiliar2
            // 
            this.txtCampoAuxiliar2.Enabled = false;
            this.txtCampoAuxiliar2.Location = new System.Drawing.Point(120, 134);
            this.txtCampoAuxiliar2.MaxLength = 256;
            this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
            this.txtCampoAuxiliar2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar2.Size = new System.Drawing.Size(312, 20);
            this.txtCampoAuxiliar2.TabIndex = 4;
            this.txtCampoAuxiliar2.WordWrap = false;
            // 
            // txtCampoAuxiliar1
            // 
            this.txtCampoAuxiliar1.Enabled = false;
            this.txtCampoAuxiliar1.Location = new System.Drawing.Point(120, 114);
            this.txtCampoAuxiliar1.MaxLength = 256;
            this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
            this.txtCampoAuxiliar1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCampoAuxiliar1.Size = new System.Drawing.Size(312, 20);
            this.txtCampoAuxiliar1.TabIndex = 2;
            this.txtCampoAuxiliar1.WordWrap = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(120, 24);
            this.txtObservaciones.MaxLength = 255;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(592, 88);
            this.txtObservaciones.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(8, 56);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 20);
            this.label24.TabIndex = 48;
            this.label24.Text = "Observaciones";
            // 
            // containerAvanzadas
            // 
            this.containerAvanzadas.Controls.Add(this.chkPermiteCambio);
            this.containerAvanzadas.Controls.Add(this.chkHabilitarActivo);
            this.containerAvanzadas.Controls.Add(this.chkHabilitarIngBrutos);
            this.containerAvanzadas.Controls.Add(this.chkHabilitarNumSerie);
            this.containerAvanzadas.Controls.Add(this.chkHabilitarCodBarras);
            this.containerAvanzadas.Controls.Add(this.chkActivo);
            this.containerAvanzadas.Controls.Add(this.ucePercibeIB);
            this.containerAvanzadas.Controls.Add(this.chkObligaNumeroSerie);
            this.containerAvanzadas.Controls.Add(this.chkObligaCodigoBarra);
            this.containerAvanzadas.Location = new System.Drawing.Point(28, 196);
            this.containerAvanzadas.Name = "containerAvanzadas";
            this.containerAvanzadas.Size = new System.Drawing.Size(1027, 112);
            this.containerAvanzadas.TabIndex = 4;
            // 
            // chkPermiteCambio
            // 
            this.chkPermiteCambio.BackColor = System.Drawing.Color.Transparent;
            this.chkPermiteCambio.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkPermiteCambio.Enabled = false;
            this.chkPermiteCambio.Location = new System.Drawing.Point(353, 8);
            this.chkPermiteCambio.Name = "chkPermiteCambio";
            this.chkPermiteCambio.Size = new System.Drawing.Size(120, 20);
            this.chkPermiteCambio.TabIndex = 8;
            this.chkPermiteCambio.Text = "P/Cambio";
            // 
            // chkHabilitarActivo
            // 
            this.chkHabilitarActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarActivo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarActivo.Enabled = false;
            this.chkHabilitarActivo.Location = new System.Drawing.Point(176, 80);
            this.chkHabilitarActivo.Name = "chkHabilitarActivo";
            this.chkHabilitarActivo.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarActivo.TabIndex = 7;
            this.chkHabilitarActivo.Text = "Habilitar su modificación";
            this.chkHabilitarActivo.CheckedChanged += new System.EventHandler(this.chkHabilitarActivo_CheckedChanged);
            // 
            // chkHabilitarIngBrutos
            // 
            this.chkHabilitarIngBrutos.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarIngBrutos.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarIngBrutos.Enabled = false;
            this.chkHabilitarIngBrutos.Location = new System.Drawing.Point(176, 56);
            this.chkHabilitarIngBrutos.Name = "chkHabilitarIngBrutos";
            this.chkHabilitarIngBrutos.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarIngBrutos.TabIndex = 5;
            this.chkHabilitarIngBrutos.Text = "Habilitar su modificación";
            this.chkHabilitarIngBrutos.CheckedChanged += new System.EventHandler(this.chkHabilitarIngBrutos_CheckedChanged);
            // 
            // chkHabilitarNumSerie
            // 
            this.chkHabilitarNumSerie.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarNumSerie.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarNumSerie.Enabled = false;
            this.chkHabilitarNumSerie.Location = new System.Drawing.Point(176, 32);
            this.chkHabilitarNumSerie.Name = "chkHabilitarNumSerie";
            this.chkHabilitarNumSerie.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarNumSerie.TabIndex = 3;
            this.chkHabilitarNumSerie.Text = "Habilitar su modificación";
            this.chkHabilitarNumSerie.CheckedChanged += new System.EventHandler(this.chkHabilitarNumSerie_CheckedChanged);
            // 
            // chkHabilitarCodBarras
            // 
            this.chkHabilitarCodBarras.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarCodBarras.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarCodBarras.Enabled = false;
            this.chkHabilitarCodBarras.Location = new System.Drawing.Point(176, 8);
            this.chkHabilitarCodBarras.Name = "chkHabilitarCodBarras";
            this.chkHabilitarCodBarras.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarCodBarras.TabIndex = 1;
            this.chkHabilitarCodBarras.Text = "Habilitar su modificación";
            this.chkHabilitarCodBarras.CheckedChanged += new System.EventHandler(this.chkHabilitarCodBarras_CheckedChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(8, 80);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(120, 20);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            // 
            // ucePercibeIB
            // 
            this.ucePercibeIB.BackColor = System.Drawing.Color.Transparent;
            this.ucePercibeIB.BackColorInternal = System.Drawing.Color.Transparent;
            this.ucePercibeIB.Enabled = false;
            this.ucePercibeIB.Location = new System.Drawing.Point(8, 56);
            this.ucePercibeIB.Name = "ucePercibeIB";
            this.ucePercibeIB.Size = new System.Drawing.Size(152, 20);
            this.ucePercibeIB.TabIndex = 4;
            this.ucePercibeIB.Text = "Percibe Ing. Brutos";
            // 
            // chkObligaNumeroSerie
            // 
            this.chkObligaNumeroSerie.BackColor = System.Drawing.Color.Transparent;
            this.chkObligaNumeroSerie.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkObligaNumeroSerie.Enabled = false;
            this.chkObligaNumeroSerie.Location = new System.Drawing.Point(8, 32);
            this.chkObligaNumeroSerie.Name = "chkObligaNumeroSerie";
            this.chkObligaNumeroSerie.Size = new System.Drawing.Size(152, 20);
            this.chkObligaNumeroSerie.TabIndex = 2;
            this.chkObligaNumeroSerie.Text = "Obliga Numero de Serie";
            // 
            // chkObligaCodigoBarra
            // 
            this.chkObligaCodigoBarra.BackColor = System.Drawing.Color.Transparent;
            this.chkObligaCodigoBarra.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkObligaCodigoBarra.Enabled = false;
            this.chkObligaCodigoBarra.Location = new System.Drawing.Point(8, 8);
            this.chkObligaCodigoBarra.Name = "chkObligaCodigoBarra";
            this.chkObligaCodigoBarra.Size = new System.Drawing.Size(152, 20);
            this.chkObligaCodigoBarra.TabIndex = 0;
            this.chkObligaCodigoBarra.Text = "Obliga Codigo Barras";
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
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
            this.tbbCancelar});
            this.toolBarStandar.DropDownArrows = true;
            this.toolBarStandar.ImageList = this.imglStandar;
            this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
            this.toolBarStandar.Name = "toolBarStandar";
            this.toolBarStandar.ShowToolTips = true;
            this.toolBarStandar.Size = new System.Drawing.Size(1093, 28);
            this.toolBarStandar.TabIndex = 24;
            this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            // 
            // tbbAnterior
            // 
            this.tbbAnterior.Name = "tbbAnterior";
            this.tbbAnterior.Text = "&Anterior";
            // 
            // tbbSeparator
            // 
            this.tbbSeparator.Name = "tbbSeparator";
            this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSiguiente
            // 
            this.tbbSiguiente.Name = "tbbSiguiente";
            this.tbbSiguiente.Text = "&Siguiente";
            // 
            // tbbSeparator2
            // 
            this.tbbSeparator2.Name = "tbbSeparator2";
            this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbCancelar
            // 
            this.tbbCancelar.Name = "tbbCancelar";
            this.tbbCancelar.Text = "Cancelar";
            // 
            // ultraExplorerBar
            // 
            this.ultraExplorerBar.AnimationEnabled = false;
            this.ultraExplorerBar.Controls.Add(this.containerInfoAdicional);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl2);
            this.ultraExplorerBar.Controls.Add(this.containerProductos);
            this.ultraExplorerBar.Controls.Add(this.containerAvanzadas);
            this.ultraExplorerBar.Controls.Add(this.ultraExplorerBarContainerControl1);
            this.ultraExplorerBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ultraExplorerBar.Dock = System.Windows.Forms.DockStyle.Fill;
            ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
            ultraExplorerBarGroup1.Settings.ContainerHeight = 29;
            ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Tarea";
            ultraExplorerBarGroup2.Container = this.containerProductos;
            ultraExplorerBarGroup2.Settings.ContainerHeight = 205;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Producto";
            ultraExplorerBarGroup3.Container = this.containerInfoAdicional;
            ultraExplorerBarGroup3.Settings.ContainerHeight = 240;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Información Adicional";
            ultraExplorerBarGroup4.Container = this.containerAvanzadas;
            ultraExplorerBarGroup4.Settings.ContainerHeight = 112;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Avanzadas";
            ultraExplorerBarGroup5.Container = this.ultraExplorerBarContainerControl1;
            ultraExplorerBarGroup5.Settings.ContainerHeight = 196;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Bonificaciones";
            this.ultraExplorerBar.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5});
            this.ultraExplorerBar.Location = new System.Drawing.Point(0, 28);
            this.ultraExplorerBar.Name = "ultraExplorerBar";
            this.ultraExplorerBar.Size = new System.Drawing.Size(1093, 540);
            this.ultraExplorerBar.TabIndex = 25;
            this.ultraExplorerBar.TabStop = false;
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkHabilitarBonificaciones);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.gridEX1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label14);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEBonificacion);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 365);
            this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(1027, 196);
            this.ultraExplorerBarContainerControl1.TabIndex = 5;
            // 
            // gridEX1
            // 
            this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.AlternatingColors = true;
            this.gridEX1.AutomaticSort = false;
            this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridEX1.Location = new System.Drawing.Point(176, 37);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RecordNavigator = true;
            this.gridEX1.RecordNavigatorText = "Registro:|de";
            this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridEX1.ShowEmptyFields = false;
            this.gridEX1.Size = new System.Drawing.Size(513, 135);
            this.gridEX1.TabIndex = 78;
            this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 77;
            this.label6.Text = "Detalle de Bonificacion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(8, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 76;
            this.label14.Text = "Bonificacion";
            // 
            // mzCEBonificacion
            // 
            this.mzCEBonificacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEBonificacion.DisplayMember = "";
            this.mzCEBonificacion.DisplayMemberCaption = "";
            this.mzCEBonificacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEBonificacion.ImageTransparentColor = System.Drawing.Color.Violet;
            this.mzCEBonificacion.Location = new System.Drawing.Point(176, 13);
            this.mzCEBonificacion.MaxItemsDisplay = 7;
            this.mzCEBonificacion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEBonificacion.Name = "mzCEBonificacion";
            this.mzCEBonificacion.Size = new System.Drawing.Size(232, 21);
            this.mzCEBonificacion.SorterMember = "";
            this.mzCEBonificacion.TabIndex = 75;
            this.mzCEBonificacion.ValueMember = "";
            this.mzCEBonificacion.ValueMemberCaption = "";
            // 
            // chkHabilitarBonificaciones
            // 
            this.chkHabilitarBonificaciones.BackColor = System.Drawing.Color.Transparent;
            this.chkHabilitarBonificaciones.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkHabilitarBonificaciones.Enabled = false;
            this.chkHabilitarBonificaciones.Location = new System.Drawing.Point(430, 14);
            this.chkHabilitarBonificaciones.Name = "chkHabilitarBonificaciones";
            this.chkHabilitarBonificaciones.Size = new System.Drawing.Size(160, 20);
            this.chkHabilitarBonificaciones.TabIndex = 79;
            this.chkHabilitarBonificaciones.Text = "Habilitar su modificación";
            // 
            // FrmModificarProductosMasivo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1093, 568);
            this.Controls.Add(this.ultraExplorerBar);
            this.Controls.Add(this.toolBarStandar);
            this.Name = "FrmModificarProductosMasivo";
            this.Text = "Quitar";
            this.ultraExplorerBarContainerControl2.ResumeLayout(false);
            this.containerProductos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.containerInfoAdicional.ResumeLayout(false);
            this.containerInfoAdicional.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.containerAvanzadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar)).EndInit();
            this.ultraExplorerBar.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void groupMZ_Enter(object sender, System.EventArgs e)
		{
		
		}
		#endregion
	
		public void AddObjectListener(IObserver observer)
		{
			_uiController.AddObjectListener(observer);
		}

		private void gridProductos_SelectionChanged(object sender, EventArgs e)
		{
			habilitarModificaciones();
			if(!_uiController.SeleccionMultiple)
			{
				if(gridProductos.SelectedItems.Count > 0)
				{
					object selectedItem = gridProductos.SelectedItems[0].GetRow().DataRow;
					_selectedIndex = gridProductos.Row;
					_uiController.SelectedItem = selectedItem;
					if(chkHabilitarCAux6.Checked)
					{
						if(rbAgregar.Checked)
							mzSearchTextBox1.Reset();
						else
							/*Debe traer la union de todas las jerarquias!!!!*/
							mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
					}
					else
						mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
				}
			}
			else
			{
				if(chkHabilitarCAux6.Checked)
				{
					if(rbAgregar.Checked)
						mzSearchTextBox1.Reset();
					else
						/*Debe traer la union de todas las jerarquias!!!!*/
						mzSearchTextBox1.SetJerarquias(_uiController.ProductosJerarquiasCampoAuxiliar6);
				}
				else
					mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
			}

		}

		private void habilitarModificaciones()
		{
			bool hayProductos = gridProductos.SelectedItems.Count > 0;
			chkHabilitarActivo.Enabled = hayProductos;
			chkHabilitarCAux1.Enabled = hayProductos && _uiController.HabilitaCampoAuxiliar1;
			chkHabilitarCAux2.Enabled = hayProductos && _uiController.HabilitaCampoAuxiliar2;
			chkHabilitarCAux3.Enabled = hayProductos && _uiController.HabilitaCampoAuxiliar3;
			chkHabilitarCAux4.Enabled = hayProductos && _uiController.HabilitaCampoAuxiliar4;
			chkHabilitarCAux5.Enabled = hayProductos && _uiController.HabilitaCampoAuxiliar5;
			chkHabilitarCAux6.Enabled = hayProductos && _uiController.HabilitaCampoAuxiliar6;
			chkHabilitarCodBarras.Enabled = hayProductos;
			chkHabilitarIngBrutos.Enabled = hayProductos;
			chkHabilitarNumSerie.Enabled = hayProductos;
			chkHabilitarObservaciones.Enabled = hayProductos;
			chkHabilitarProveedorDefault.Enabled = hayProductos;
            /* Silvina 20110630 - Tarea 0000136 */
            chkPermiteCambio.Enabled = hayProductos;
            /* Fin Silvina 20110630 - Tarea 0000136 */
            //German 20120208 - Tarea 0000276
            chkHabilitarBonificaciones.Enabled = hayProductos;
            //German 20120208 - Tarea 0000276
		}



		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2://Guardar					
					this.Execute();
					break;
				case 4://Cancelar
					this.Cancelar();
					break;

			}						
		}

		private void rbSeleccionMultiple_CheckedChanged(object sender, EventArgs e)
		{
			bTodosCaja.Enabled = rbSeleccionMultiple.Checked;
			bNingunoCaja.Enabled = rbSeleccionMultiple.Checked;
			_uiController.SeleccionMultiple = rbSeleccionMultiple.Checked;
			if(rbSeleccionSimple.Checked)
				this.gridProductos_SelectionChanged(gridProductos, new EventArgs());
			if(_uiController.AllowSeleccionMultiple)
			{
				gridProductos.RootTable.Columns["Selected"].Visible = rbSeleccionMultiple.Checked;
			}
		}

		private void bTodosCaja_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(true);
		}

		private void bNingunoCaja_Click(object sender, EventArgs e)
		{
			_uiController.Seleccionar(false);
		}

		private void chkHabilitarObservaciones_CheckedChanged(object sender, System.EventArgs e)
		{
			txtObservaciones.Enabled = chkHabilitarObservaciones.Checked;
		}

		private void chkHabilitarCAux1_CheckedChanged(object sender, System.EventArgs e)
		{
			txtCampoAuxiliar1.Enabled = chkHabilitarCAux1.Checked;
		}

		private void chkHabilitarCAux2_CheckedChanged(object sender, System.EventArgs e)
		{
			txtCampoAuxiliar2.Enabled = chkHabilitarCAux2.Checked;
		}

		private void chkHabilitarCAux3_CheckedChanged(object sender, System.EventArgs e)
		{
			txtCampoAuxiliar3.Enabled = chkHabilitarCAux3.Checked;
		}
	
		private void chkHabilitarCAux4_CheckedChanged(object sender, System.EventArgs e)
		{
			txtCampoAuxiliar4.Enabled = chkHabilitarCAux4.Checked;
		}
	
		private void chkHabilitarCAux5_CheckedChanged(object sender, System.EventArgs e)
		{
			txtCampoAuxiliar5.Enabled = chkHabilitarCAux5.Checked;
		}

	
		private void chkHabilitarCodBarras_CheckedChanged(object sender, System.EventArgs e)
		{
			chkObligaCodigoBarra.Enabled = chkHabilitarCodBarras.Checked;
		}

		private void chkHabilitarNumSerie_CheckedChanged(object sender, System.EventArgs e)
		{
			chkObligaNumeroSerie.Enabled = chkHabilitarNumSerie.Checked;
		}

	    private void chkHabilitarIngBrutos_CheckedChanged(object sender, System.EventArgs e)
	    {
				 ucePercibeIB.Enabled = chkHabilitarIngBrutos.Checked;
		}

		private void chkHabilitarActivo_CheckedChanged(object sender, System.EventArgs e)
		{
			chkActivo.Enabled = chkHabilitarActivo.Checked;
		}



	
		private void chkHabilitarCAux6_CheckedChanged(object sender, EventArgs e)
		{
			mzSearchTextBox1.Enabled = chkHabilitarCAux6.Checked;
			groupBox1.Enabled = chkHabilitarCAux6.Checked;
			if(chkHabilitarCAux6.Checked)
			{
				if(rbAgregar.Checked)
				{
					_uiController.State = "A";
					mzSearchTextBox1.Reset();
				}
				else
				{
					_uiController.State = "D";
					if(!_uiController.SeleccionMultiple)
						mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
					else
						mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
				}
			}
			
		}

		private void rbAgregar_CheckedChanged(object sender, EventArgs e)
		{
			if(chkHabilitarCAux6.Checked)
			{
				if(rbAgregar.Checked)
				{
					_uiController.State = "A";
					mzSearchTextBox1.Reset();
				}
				else
				{
					_uiController.State = "D";
					if(!_uiController.SeleccionMultiple)
						mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
					else
						mzSearchTextBox1.SetJerarquias(_uiController.ProductosJerarquiasCampoAuxiliar6);
				}
			}
		}

		private void rbEliminar_CheckedChanged(object sender, EventArgs e)
		{

			if(chkHabilitarCAux6.Checked)
			{
				if(rbAgregar.Checked)
				{
					_uiController.State = "A";
					mzSearchTextBox1.Reset();
				}
				else
				{
					_uiController.State = "D";
					if(!_uiController.SeleccionMultiple)
						mzSearchTextBox1.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
					else
						mzSearchTextBox1.SetJerarquias(_uiController.ProductosJerarquiasCampoAuxiliar6);
				}
			}

		}

		private void chkHabilitarProveedorDefault_CheckedChanged(object sender, EventArgs e)
		{
			mzCmbProveedor.Enabled = chkHabilitarProveedorDefault.Checked;
		}
	}
}

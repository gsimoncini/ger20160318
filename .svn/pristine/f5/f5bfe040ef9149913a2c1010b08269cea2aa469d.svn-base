using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
//German 20101223 - Tarea 1003
using Infragistics.Win.UltraWinGrid;
//Fin German 20101223 - Tarea 1003

namespace mz.erp.ui.forms
{
	public class FrmAbmCuentas : mz.erp.ui.forms.FrmABMEx
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label6;
		private mz.erp.ui.controls.ComponenteDocumentos componenteDocumentos1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelCampoAuxiliar1;
		private System.Windows.Forms.TextBox txtCampoAuxiliar1;
		private System.Windows.Forms.TextBox txtCampoAuxiliar3;
		private System.Windows.Forms.Label labelCampoAuxiliar3;
		private System.Windows.Forms.Label labelCampoAuxiliar2;
		private System.Windows.Forms.RichTextBox rtbObservaciones;
		private System.Windows.Forms.TextBox txtCampoAuxiliar2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private mz.erp.ui.controls.mzComboEditor mzCEBonificacion;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private Janus.Windows.GridEX.GridEX grillaElementosAsociados;
		private Janus.Windows.GridEX.GridEX grillaProductosAsociados;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.ComponentModel.IContainer components = null;
		private mz.erp.ui.controls.mzComboEditor mzCmbTiposDeIVA;
		private System.Windows.Forms.Label label4;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtTitular;
		private System.Windows.Forms.TextBox txtHorarioComercial;
		private System.Windows.Forms.Label label3;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private System.Windows.Forms.TextBox txtEMail;
		private System.Windows.Forms.Label label13;

		private string _action = string.Empty;
		private string _idDomicilioActual = string.Empty;
		private string _idPerosnaActual = string.Empty;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor uceExcluyePercepcionIB;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbbEditar;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton tbbVolver;
		private Janus.Windows.GridEX.GridEX gridContactos;
		private System.Windows.Forms.Button btnAgregarContacto;
		private System.Windows.Forms.Button btnEditarContacto;
		private System.Windows.Forms.Button btnEliminarContacto;
		private System.Windows.Forms.Button btnBuscarContacto;
		private System.Windows.Forms.Panel panelABMContactos;
		private System.Windows.Forms.Button btnMasDetallesContacto;
		private System.Windows.Forms.Panel panelABM;
		private System.Windows.Forms.Button btnEditarDomicilio;
		private System.Windows.Forms.Button btnAgregarDomicilio;
		private System.Windows.Forms.Button btnMasDetalles;
        private System.Windows.Forms.Button btnEliminar;
		//private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private System.Windows.Forms.Label label5;
		private mz.erp.ui.controls.mzComboEditor mzCEListaPrecios;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerInformacionAdicional;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerBonificacion;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerListaDePrecios;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerElementosAsociados;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerJerarquia;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerContactos;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerDomicilio;
		private mz.erp.ui.controls.HierarchicalSearchControl hierarchicalSearchControl1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneAlicuotaPercepcionIngresosBrutos;
		private System.Windows.Forms.Label label14;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneLimiteDeCredito;
		private System.Windows.Forms.Label label12;
		private mz.erp.ui.controls.mzComboEditor mzCEResponsableIngreso;
		private System.Windows.Forms.Label label15;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneDiasLimiteDeCredito;
        private System.Windows.Forms.Label label16;
        private Janus.Windows.GridEX.GridEX gridDomicilios;
        private Infragistics.Win.UltraWinGrid.UltraGrid gridDom;
        private Button btnCancelar;
        private Button btnAceptar;
        private mzSearchTextBox mzSTBCampoAuxiliar6;
        private Label lCampoAuxiliar6;
	


		public event System.EventHandler OnNewRow;

		private string _stateFormDomicilios;

		public FrmAbmCuentas()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
            Console.WriteLine("Empieza InitializeComponent" + mz.erp.systemframework.Util.GetTotalMilliseconds());
			InitializeComponent();
            Console.WriteLine("Termina InitializeComponent " + mz.erp.systemframework.Util.GetTotalMilliseconds());
			_uiController = new mz.erp.ui.controllers.AbmCuentasController();
			Build_UI();
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// 



		#region CustomMembers

		protected override void Init()
		{
			_businessRulesType = new mz.erp.businessrules.tsa_CuentasEx().GetType();
			base.Init();
			componenteDocumentos1.Numero = "0";
			label10.Visible = false;
			grillaElementosAsociados.Visible = false;
			button1.Visible = false;
			button2.Visible = false;
			this.ultraExplorerBar1.Groups[3].Visible = false;			
			/*txtEMail.Enabled = true;
			txtEMail.ReadOnly = true;*/
		}		


		protected override void InitializeMembers()
		{
			//txtIdCuenta.MaxLength = 20;
			txtCodigo.MaxLength = 15;
			txtNombre.MaxLength = Convert.ToInt32(_uiController.LengthRazonSocial);
			
			txtHorarioComercial.MaxLength = 50;
			//txtidTipoDocumento.MaxLength = 5;
			//txtDocumento.MaxLength = 13;
			//txtIdCategoriaIva.MaxLength = 10;
			txtCampoAuxiliar1.MaxLength = 100;
			txtCampoAuxiliar2.MaxLength = 100;
			txtCampoAuxiliar3.MaxLength = 100;
			//txtIdTitular.MaxLength = 20;
			//txtObservaciones.MaxLength = 1000;
			
			//Setea el tipo/s de documentos a chequear por la componente			
			ArrayList array = new ArrayList();
			array.Add("CUIT");
			array.Add("CUIL");
			componenteDocumentos1.TipoDoc = array;

			//Agrega los tipos de Doc. al ComboBox del  componete
			componenteDocumentos1.FillFromDataSource( businessrules.tsy_TiposDocumentos.GetList().tsy_TiposDocumentos, "idTipoDocumento", "Descripcion", 100, "1", "2", "Descripcion");
			componenteDocumentos1.CantItems = 10;
			mzCmbSrchEdtTitular.SearchObject = typeof( mz.erp.ui.forms.classes.tsh_Personas );
			

			mzCmbTiposDeIVA.FillFromDataSource(businessrules.tsy_CategoriasIva.GetList().tsy_CategoriasIva, "IdCategoriaIva", "Descripcion", 100, "1", "2", "Descripcion");
			mzCEBonificacion.FillFromDataSource( businessrules.tsa_Bonificaciones.GetList(null,null,Constantes.ImpuestosAplicadosACuentas).tsa_Bonificaciones, "IdBonificacion", "Descripcion",100, "1", "2", "Descripcion");
			gridEX1.LayoutData= new mz.erp.ui.forms.classes.tsa_BonificacionesDet().GetLayout();
			labelCampoAuxiliar1.Text=Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta");
			labelCampoAuxiliar2.Text=Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta");
			labelCampoAuxiliar3.Text=Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta");
			txtCodigo.Enabled = !ComprobantesRules.Cuentas_CodigoAutomatico;
			//componenteDocumentos1.BackColor = System.Drawing.Color.Transparent;
			
			btnAgregarDomicilio.Click +=new EventHandler(btnAgregarDomicilio_Click);
			btnEditarDomicilio.Click +=new EventHandler(btnEditarDomicilio_Click);
			btnEliminar.Click +=new EventHandler(btnEliminar_Click);
			btnMasDetalles.Click +=new EventHandler(btnMasDetalles_Click);

			bool allowEdit = Variables.GetValueBool("Cuentas.Emision.Editar.ExcluyePercepcionIB");
			uceExcluyePercepcionIB.Enabled = allowEdit;

            /* Silvina 20101130 - Tarea 940 
			gridDomiciliosAnterior.LayoutData = _uiController.LayoutDomicilios;
			//gridDomicilios.LayoutData = new mz.erp.ui.forms.classes.tcs_Domicilios().GetLayout();
			gridDomiciliosAnterior.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridDomiciliosAnterior.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridDomiciliosAnterior.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			gridDomiciliosAnterior.AcceptsEscape = true;
            Fin Silvina */


			gridContactos.LayoutData = _uiController.LayoutContactos;
			gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AcceptsEscape = true;

			toolBarStandar.ButtonClick -=new ToolBarButtonClickEventHandler(base.onClick);
			toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(onClick);
            /* Silvina 20101130 - Tarea 940 
			gridDomiciliosAnterior.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridDomicilios_Error);
			gridDomiciliosAnterior.UpdatingRecord += new CancelEventHandler(gridDomicilios_UpdatingRecord);
			gridDomiciliosAnterior.RecordUpdated +=new EventHandler(gridDomicilios_RecordUpdated);
			gridDomiciliosAnterior.RowEditCanceled +=new Janus.Windows.GridEX.RowActionEventHandler(gridDomicilios_RowEditCanceled);
			gridDomiciliosAnterior.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(gridDomicilios_CellUpdated);
			gridDomiciliosAnterior.DropDown += new Janus.Windows.GridEX.ColumnActionEventHandler(gridDomicilios_DropDown);
            Fin Silvina */
            
            gridContactos.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridContactos_Error);
			gridContactos.UpdatingRecord += new CancelEventHandler(gridContactos_UpdatingRecord);
			gridContactos.RecordUpdated +=new EventHandler(gridContactos_RecordUpdated);
			gridContactos.RowEditCanceled +=new Janus.Windows.GridEX.RowActionEventHandler(gridContactos_RowEditCanceled);
			ConfigureGridContactos();
			
			if(Variables.GetValueBool("Cuentas.Nombre.SoloMayusculas"))
				this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			else
				this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			
			erp.commontypes.data.tsa_CuentasExDataset data=(mz.erp.commontypes.data.tsa_CuentasExDataset) _data;
			System.Data.DataTable tableCuentas=data.Tables["tsa_Cuentas"];
			System.Data.DataRow _row = tableCuentas.Rows[0];
			string idCuenta = ( string )_row["IdCuenta"];
			_uiController.IdCuenta = idCuenta;

            /* Silvina 20101201 - Tarea 940 */
            
            //German 20101223 - Tarea 1003
            //gridDom.CellListSelect += new Infragistics.Win.UltraWinGrid.CellEventHandler(gridDom_CellListSelect);
            
            gridDom.AfterCellUpdate += new Infragistics.Win.UltraWinGrid.CellEventHandler(gridDom_AfterCellUpdate);
            gridDom.AfterRowUpdate += new Infragistics.Win.UltraWinGrid.RowEventHandler(gridDom_AfterRowUpdate);
            gridDom.CellChange += new CellEventHandler(gridDom_CellChange);
            /* Fin Silvina 20110804 - Tarea 0000178 */
            //gridDom.AfterRowCancelUpdate += new RowEventHandler(gridDom_AfterRowCancelUpdate);
            gridDom.AfterCellCancelUpdate += new CellEventHandler(gridDom_AfterCellCancelUpdate);

            //gridDom.KeyActionMappings.Add(new GridKeyActionMapping(Keys.Enter, UltraGridAction.CommitRow, 0, UltraGridState.Row, Infragistics.Win.SpecialKeys.All, 0));
            //gridDom.KeyActionMappings.Add(new GridKeyActionMapping(Keys.Escape, UltraGridAction.UndoRow, 0, UltraGridState.Row, Infragistics.Win.SpecialKeys.All, 0));
            gridDom.KeyActionMappings.Add(new GridKeyActionMapping(Keys.Enter, UltraGridAction.CommitRow, 0, UltraGridState.InEdit, Infragistics.Win.SpecialKeys.All, 0));
            gridDom.KeyActionMappings.Add(new GridKeyActionMapping(Keys.Escape, UltraGridAction.UndoCell, 0, UltraGridState.InEdit, Infragistics.Win.SpecialKeys.All, 0));

            gridDom.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnRowChangeOrLostFocus;
            //Fin German 20101223 - Tarea 1003
            /* Silvina 20110804 - Tarea 0000178 */
            gridDom.BeforeRowsDeleted += new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(gridDom_BeforeRowsDeleted);
            //gridDom.BeforeCellUpdate += new Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventHandler(gridDom_BeforeCellUpdate);
            /* Fin Silvina 20110804 - Tarea 0000178 */
            /* Silvina 20110302 - Tarea 0000081 */
            bool cambio = _uiController.InitDomicilios();
            if (cambio)
            {
                ConfigureGrid();
                ActualizarCombosGrillaDomicilios();
            }
            /* Fin Silvina 20110302 - Tarea 0000081 */
            /* Fin Silvina */

            /* Silvina 20111104 - Tarea 0000222 */
            lCampoAuxiliar6.Text = _uiController.EtiquetaCampoAuxiliar6;
            /* Silvina 20111226 - Tarea 0000241 */
            mzSTBCampoAuxiliar6.Init("CUENTAS",true, _uiController.JerarquiaCampoAuxiliar6, _uiController.Separador);
            mzSTBCampoAuxiliar6.Enabled = _uiController.AllowEditCampoAuxiliar6;
            /* Fin Silvina 20111226 - Tarea 0000241 */
            /* Fin Silvina 20111104 - Tarea 0000222 */

			if(this._state.Equals("EDIT"))
			{
				_uiController.InitJerarquias();
				hierarchicalSearchControl1.SetSelectionKey(_uiController.Jerarquias);
			}
			
			this.ultraExplorerBar1.Groups[0].Key= "DatosGenerales";
			
			
			//this.ultraExplorerBarContainerControl5.ClientSize = hierarchicalSearchControl1.Size;
			this.ContainerJerarquia.ClientSize = hierarchicalSearchControl1.Size;
			foreach  (Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup grupo in  this.ultraExplorerBar1.Groups){
						
				grupo.Visible = false;
				grupo.Container.Enabled=false;
			}
			

			if(!_uiController.ContenedoresVisibles.Equals(string.Empty))
			{
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles, ",");
				foreach(string grupo in cont)
				{   if (this.ultraExplorerBar1.Groups.Exists(grupo))
					this.ultraExplorerBar1.Groups[grupo].Visible = true;
				}
			}

			if(!_uiController.ContenedoresHabilitados.Equals(string.Empty))
			{								
				ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresHabilitados, ",");
				foreach(string grupo in cont)
				{
					 if (this.ultraExplorerBar1.Groups.Exists(grupo))
						if (this.ultraExplorerBar1.Groups[grupo].Container != null)
							this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;
				}
			}
			mzCEListaPrecios.FillFromDataSource( businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios, "IdListaDePrecio", "Descripcion", 100, "1", "2", "Descripcion");
			uneAlicuotaPercepcionIngresosBrutos.ReadOnly = !_uiController.AllowEditAlicuotaPercepcionIngresosBrutos;
			mzCmbTiposDeIVA.ValueChanged +=new EventHandler(mzCmbTiposDeIVA_ValueChanged);
			uneLimiteDeCredito.ReadOnly = !_uiController.AllowEditLimiteDeCredito;
			uneDiasLimiteDeCredito.ReadOnly = !_uiController.AllowEditDiasLimiteDeCredito;

		}

        //German 20101223 - Tarea 1003
        void gridDom_AfterCellCancelUpdate(object sender, CellEventArgs e)
        {
            /* Silvina 20110804 - Tarea 0000178 */
            //gridDom.Enabled = false;
            //panelABM.Visible = true;
            /* Fin Silvina 20110804 - Tarea 0000178 */
        }
        //Fin German 20101223 - Tarea 1003


        //German 20101223 - Tarea 1003
        void gridDom_AfterRowUpdate(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
        {
            /* Silvina 20110804 - Tarea 0000178 */
            //gridDom.Enabled = false;
            //panelABM.Visible = true;
            /* Fin Silvina 20110804 - Tarea 0000178 */
        }
        //Fin German 20101223 - Tarea 1003

        /* Silvina 20110823 - Tarea 0000178 */

        void gridDom_CellChange(object sender, CellEventArgs e)
        {
            string key = e.Cell.Column.Key;
            if (key.Equals("Default"))
                gridDom.UpdateData();
        }

        /* Fin Silvina 20110823 - Tarea 0000178 */

        //German 20101223 - Tarea 1003
        void gridDom_AfterCellUpdate(object sender, Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            /* Silvina 20110823 - Tarea 0000178 */
            /*if (_permiteEditar)
            {*/
            /* Fin Silvina 20110823 - Tarea 0000178 */
                string key = e.Cell.Column.Key;
                int pos = gridDom.ActiveRow.Index;
                DomicilioCuenta domC = (DomicilioCuenta)_uiController.DataDomicilios[pos];
                /* Silvina 20110823 - Tarea 0000178 */
                if (key.Equals("Default") && domC.Default)
                {
                    _uiController.ActualizarDomiciliosDefault();
                    domC.Default = true;
                    gridDom.DataSource = null;
                    gridDom.DataSource = _uiController.DataDomicilios;
                    gridDom.DataBind();
                    /*if (_uiController.DataDomicilios.Count > 0)
                    {*/
                        ConfigurarGrillaDomicilio();
                        ActualizarCombosGrillaDomicilios();
                    //}
                }
                if (!domC.Estado.Equals("NEW"))
                {
                    domC.Estado = "MODIF";
                    domC.Aceptado = false;
                }
                /* Fin Silvina 20110823 - Tarea 0000178 */
                gridDom_UpdateCombo(e);
            //}
        }

        void gridDom_UpdateCombo(Infragistics.Win.UltraWinGrid.CellEventArgs e)
        {
            
			string key = e.Cell.Column.Key;
            int pos = e.Cell.Row.Index;
            switch(key)
            {	
                case "IdPais": 
				{		
                    long idPaisSeleted = Convert.ToInt64(e.Cell.Value);
                    CellsCollection cell = e.Cell.Row.Cells;
                    DomicilioCuenta dom = (DomicilioCuenta)e.Cell.Row.ListObject;
                    Infragistics.Win.ValueList vlPr = new Infragistics.Win.ValueList();
                    foreach (DataRowView row in dom.Provincias)
                        vlPr.ValueListItems.Add(row["IdProvincia"].ToString(), row["Nombre"].ToString());
                    
                    cell["IdProvincia"].ValueList = vlPr;
                    cell["IdProvincia"].Value = dom.IdProvincia;

                    
                    Infragistics.Win.ValueList vlL = new Infragistics.Win.ValueList();
                    foreach (DataRowView row in dom.Localidades)
                        vlL.ValueListItems.Add(row["IdLocalidad"].ToString(), row["Descripcion"].ToString());
                    cell["IdLocalidad"].ValueList = vlL;
                    cell["IdLocalidad"].Value = dom.IdLocalidad;
                    
					break;
				}
				case "IdProvincia": 
				{

                    DomicilioCuenta dom = (DomicilioCuenta)e.Cell.Row.ListObject;
                    Infragistics.Win.ValueList vlL = new Infragistics.Win.ValueList();
                    foreach (DataRowView row in dom.Localidades)
                        vlL.ValueListItems.Add(row["IdLocalidad"].ToString(), row["Descripcion"].ToString());

                    CellsCollection cell = e.Cell.Row.Cells;
                    cell["IdLocalidad"].ValueList = vlL;
                    cell["IdLocalidad"].Value = dom.IdLocalidad;
                    

    				break;
				}
                default:
				   break;				
			}

        }
        //Fin German 20101223 - Tarea 1003

        /* Silvina 20110804 - Tarea 0000178 */

        void gridDom_BeforeCellUpdate(object sender, Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs e)
        {
            //if (!_permiteEditar)
                e.Cancel = true;
        }

        void gridDom_BeforeRowsDeleted(object sender, Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs e)
        {
            e.Cancel = true;
        }

        private void EliminarDomicilio()
        {
            if (gridDom.ActiveRow != null)
            {
                int index = gridDom.ActiveRow.Index;
                if (gridDom.Rows.Count >= 1 && _uiController.isDefaultDomicilio(index))
                {
                    MessageBox.Show("Antes de eliminar el domicilio por defecto debe seleccionar otro como tal", "Advertencia", System.Windows.Forms.MessageBoxButtons.OK);
                }
                else
                {
                    /*if (MessageBox.Show("Está seguro que desea Eliminar el domicilio seleccionado", "Advertencia", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question).Equals(DialogResult.OK))
                    {*/
                        _uiController.DeleteDomicilio(index);                                         
                    /*}
                    else
                    {
                        e.Cancel = true;
                    }*/
                }
            }
            gridDom.Update();
            _eliminar = false;
        }
        /* Fin Silvina 20110804 - Tarea 0000178 */
 
		private void ConfigureGrid()
		{
            /* Silvina 20101130 - Tarea 940 */
            //gridDomiciliosAnterior.SetDataBinding(_uiController.DataDomicilios, null);
            //ConfigureGrid();
            
            if (_uiController.DataDomicilios.Count > 0)
            {
                gridDom.DataSource = null;
                gridDom.DataSource = _uiController.DataDomicilios;
                gridDom.DataBind();
                ConfigurarGrillaDomicilio();

                Infragistics.Win.ValueList valTD = new Infragistics.Win.ValueList();
                tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosDataTable td = mz.erp.businessrules.tcs_TiposDomicilios.GetList().tcs_TiposDomicilios;
                foreach (tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow row in td)
                    valTD.ValueListItems.Add(row.IdTipoDomicilio, row.Descripcion);
                gridDom.Rows[0].Cells["IdTipoDomicilio"].Column.ValueList = valTD;

                /*Janus.Windows.GridEX.GridEXColumnCollection col = gridDomiciliosAnterior.RootTable.Columns;
                col["IdTipoDomicilio"].HasValueList =true;
                col["IdTipoDomicilio"].EditType= Janus.Windows.GridEX.EditType.Combo;
                col["IdTipoDomicilio"].ValueList.PopulateValueList(mz.erp.businessrules.tcs_TiposDomicilios.GetList().tcs_TiposDomicilios,"IdTipoDomicilio","Descripcion");
                col["IdPais"].HasValueList =true;
                col["IdPais"].EditType= Janus.Windows.GridEX.EditType.Combo;
                col["IdProvincia"].HasValueList =true;
                col["IdProvincia"].EditType = Janus.Windows.GridEX.EditType.Combo;
                col["IdLocalidad"].HasValueList =true;
                col["IdLocalidad"].EditType= Janus.Windows.GridEX.EditType.Combo;*/

                long idPaisDefault = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
                /*long idProvinciaDefault = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
                string idLocalidadDefault = Variables.GetValueString("Cuentas.Domicilios.Localidades.ValorDefault");*/
                string descripcionPais = mz.erp.businessrules.tsh_Paises.GetByPk(idPaisDefault).Nombre;
                /*string descripcionProv = mz.erp.businessrules.tsh_Provincias.GetByPk(idProvinciaDefault).Nombre;
                string descripcion = mz.erp.businessrules.tsh_Localidades.GetByPk(idLocalidadDefault).Descripcion;*/

                //DataView localidades = _uiController.GetListLocalidades(idProvinciaDefault);

                /*col["IdPais"].ValueList.PopulateValueList(_uiController.Paises,"IdPais","Nombre");
                col["IdProvincia"].ValueList.PopulateValueList(_uiController.Provincias, "IdProvincia", "Nombre");
                        
                col["IdLocalidad"].ValueList.PopulateValueList(localidades, "IdLocalidad", "Descripcion");*/

                Infragistics.Win.ValueList valP = new Infragistics.Win.ValueList();
                foreach (tsh_PaisesDataset.tsh_PaisesRow row in _uiController.Paises)
                    valP.ValueListItems.Add(row.IdPais, row.Nombre);
                gridDom.DisplayLayout.Bands[0].Columns["IdPais"].ValueList = valP;

                /* Silvina 20110302 - Tarea 0000081 */
                //long pais = (long)(tsh_Paises.GetList(long.MinValue,descripcionPais,string.Empty,long.MinValue,long.MinValue).tsh_Paises.Rows[0]["IdPais"]);
                gridDom.DisplayLayout.Bands[0].Columns["IdPais"].DefaultCellValue = idPaisDefault;
                /* Fin Silvina - Tarea 0000081 */

                Infragistics.Win.ValueList valPr = new Infragistics.Win.ValueList();
                foreach (tsh_ProvinciasDataset.tsh_ProvinciasRow row in _uiController.Provincias)
                    valPr.ValueListItems.Add(row.IdProvincia, row.Nombre);
                gridDom.DisplayLayout.Bands[0].Columns["IdProvincia"].ValueList = valPr;

                Infragistics.Win.ValueList valL = new Infragistics.Win.ValueList();
                foreach (tsh_LocalidadesDataset.tsh_LocalidadesRow row in _uiController.Localidades)
                    valL.ValueListItems.Add(row.IdLocalidad, row.Descripcion);
                gridDom.DisplayLayout.Bands[0].Columns["IdLocalidad"].ValueList = valL;

                /*gridDomiciliosAnterior.RootTable.Columns["IdPais"].DefaultValue = 	gridDomiciliosAnterior.RootTable.Columns["IdPais"].ValueList[descripcionPais].Value;
                gridDomiciliosAnterior.RootTable.Columns["IdProvincia"].DefaultValue = 	gridDomiciliosAnterior.RootTable.Columns["IdProvincia"].ValueList[descripcionProv].Value;
                gridDomiciliosAnterior.RootTable.Columns["IdLocalidad"].DefaultValue = 	gridDomiciliosAnterior.RootTable.Columns["IdLocalidad"].ValueList[descripcion].Value;*/

                long IdTipoDomicilioDefault = Variables.GetValueLong("Cuentas.Domicilios.TipoDomicilioDefault");
                gridDom.DisplayLayout.Bands[0].Columns["IdTipoDomicilio"].DefaultCellValue = IdTipoDomicilioDefault;
                /*gridDomiciliosAnterior.RootTable.Columns["IdTipoDomicilio"].DefaultValue = gridDomiciliosAnterior.RootTable.Columns["IdTipoDomicilio"].ValueList[0].Value;

                gridDomiciliosAnterior.RootTable.Columns["Numero"].DefaultValue = "S/N";
                gridDomiciliosAnterior.RootTable.Columns["Default"].DefaultValue = true;*/
            }
            /* Fin Silvina */

		}

        /* Silvina 20101130 - Tarea 940 */
        private void ConfigurarGrillaDomicilio()
        {
            gridDom.DataBind();
            gridDom.DisplayLayout.Bands[0].Columns["IdDomicilio"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Sector"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Torre"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Piso"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Departamento"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Manzana"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Partido"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["IdResponsable"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["IdCuenta"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Estado"].Hidden = true;

            gridDom.DisplayLayout.Bands[0].Columns["IdPais"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            gridDom.DisplayLayout.Bands[0].Columns["IdProvincia"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            gridDom.DisplayLayout.Bands[0].Columns["IdLocalidad"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
            gridDom.DisplayLayout.Bands[0].Columns["IdTipoDomicilio"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;

            gridDom.DisplayLayout.Bands[0].Columns["IdPais"].Header.Caption = "Pais";
            gridDom.DisplayLayout.Bands[0].Columns["IdProvincia"].Header.Caption = "Provincia";
            gridDom.DisplayLayout.Bands[0].Columns["IdLocalidad"].Header.Caption = "Localidad";
            /* Silvina 20110823 - Tarea 0000178 */
            gridDom.DisplayLayout.Bands[0].Columns["CodigoPostal"].Header.Caption = "CP";
            gridDom.DisplayLayout.Bands[0].Columns["CodigoPostal"].Width = 50;
            gridDom.DisplayLayout.Bands[0].Columns["Aceptado"].Hidden = true;
            gridDom.DisplayLayout.Bands[0].Columns["Calle"].Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            gridDom.DisplayLayout.Bands[0].Columns["Numero"].Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            gridDom.DisplayLayout.Bands[0].Columns["Telefono"].Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            gridDom.DisplayLayout.Bands[0].Columns["CodigoPostal"].Nullable = Infragistics.Win.UltraWinGrid.Nullable.EmptyString;
            /* Fin Silvina 20110823 - Tarea 0000178 */
        }

		private void ConfigureGridDefault()
		{
            /* Silvina 20101130 - Tarea 940 
			Janus.Windows.GridEX.GridEXColumnCollection col = gridDomiciliosAnterior.RootTable.Columns;

			long  idPaisDefault = Variables.GetValueLong("Cuentas.Domicilios.Pais.ValorDefault");
			long  idProvinciaDefault = Variables.GetValueLong("Cuentas.Domicilios.Provincia.ValorDefault");
			string  idLocalidadDefault = Variables.GetValueString("Cuentas.Domicilios.Localidades.ValorDefault");

			
			Janus.Windows.GridEX.GridEXValueListItemCollection vlP = new Janus.Windows.GridEX.GridEXValueListItemCollection();
			vlP.PopulateValueList(_uiController.GetListProvincias(idPaisDefault),"IdProvincia","Nombre");
			col["IdProvincia"].EditValueList = vlP;
    
			
            Janus.Windows.GridEX.GridEXValueListItemCollection vlL = new Janus.Windows.GridEX.GridEXValueListItemCollection();
            DataView localidades = _uiController.GetListLocalidades(idProvinciaDefault);
            vlL.PopulateValueList(localidades,"IdLocalidad","Descripcion");
			col["IdLocalidad"].EditValueList = vlL;

            Janus.Windows.GridEX.GridEXValueListItemCollection vlCP = new Janus.Windows.GridEX.GridEXValueListItemCollection();
            vlCP.PopulateValueList(_uiController.GetListLocalidades(idProvinciaDefault), "IdLocalidad", "CodigoPostal");
            vlCP.Sort();
            /* Fin Silvina */


		}
	
		private void ConfigureGridContactos()
		{
			Janus.Windows.GridEX.GridEXColumnCollection col = gridContactos.RootTable.Columns;
			col["IdTipoContacto"].HasValueList =true;
			col["IdTipoContacto"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["IdTipoContacto"].ValueList.PopulateValueList(_uiController.TiposContactos,"IdTipoContacto","Descripcion");

			col["IdCargo"].HasValueList =true;
			col["IdCargo"].EditType= Janus.Windows.GridEX.EditType.Combo;
			col["IdCargo"].ValueList.PopulateValueList(_uiController.TiposCargos,"IdCargo","Descripcion");

		}

		bool ExcluyePercepcionIB = false;
		string IdCategoriaIVA = string.Empty;
		protected override void FillControls()
		{
					
			if (_data != null)
			{
				try 
				{
					erp.commontypes.data.tsa_CuentasExDataset data=(mz.erp.commontypes.data.tsa_CuentasExDataset) _data;
					//data.AcceptChanges();
					System.Data.DataTable tableCuentas=data.Tables["tsa_Cuentas"];
					System.Data.DataRow _row = tableCuentas.Rows[0];
					//	txtIdCuenta.Text = ( string )_row["IdCuenta"];
					txtCodigo.Text = ( string )_row["Codigo"];
					txtNombre.Text = ( string )_row["Nombre"];
					
					txtHorarioComercial.Text = ( string )_row["HorarioComercial"];
					txtEMail.Text = Convert.ToString(_row["Email"]);
					if(this.State.Equals("NEW"))
					{
						componenteDocumentos1.TipoDocSelected = Variables.GetValueString("Cuentas.TipoDocumento.Default");						
						if (componenteDocumentos1.TipoDocSelected == "")
						{
							componenteDocumentos1.TipoDocSelected = "NO/I";
						}
						mzCmbTiposDeIVA.Value = Variables.GetValueString("Cuenta.CategoriaImpositiva.Default");
						if (mzCmbTiposDeIVA.Value == null)						
						{
							mzCmbTiposDeIVA.Value="CF";							
						}
						//mzCEListaPrecios.Value = Variables.GetValueString("Cuentas.IdListaDePreciosDefault");
                        //Sabrina 20100618 - Tarea 787
                        //mzCEListaPrecios.Value = mz.erp.businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
                        /* Silvina 20100921 - Tarea 841 */
                        mzCEListaPrecios.Value = Variables.GetValueString("Productos.IdListaDePreciosDefault", null);
                        /* Fin Silvina */
                        //Fin Sabrina 20100618 - Tarea 787
					}
					else
					{
						componenteDocumentos1.TipoDocSelected = ( string )_row["idTipoDocumento"];
						mzCmbTiposDeIVA.Value = ( string )_row["IdCategoriaIva"];
						IdCategoriaIVA = ( string )_row["IdCategoriaIva"];
						mzCEListaPrecios.Value = Convert.ToString(_row["IdListaDePreciosDefault"]);
                        /* Silvina 20110406 - Tarea 0000081 */
                        mzCEResponsableIngreso.Value = Convert.ToString(_row["IdResponsableCreacion"]);
                        /* Fin Silvina 20110406 - Tarea 0000081 */
						
					}
					componenteDocumentos1.Numero= ( string )_row["Documento"];
					txtCampoAuxiliar1.Text = ( string )_row["CampoAuxiliar1"];
					txtCampoAuxiliar2.Text = ( string )_row["CampoAuxiliar2"];
					txtCampoAuxiliar3.Text = ( string )_row["CampoAuxiliar3"];
					mzCmbSrchEdtTitular.DataValue = ( string )_row["IdTitular"];
					mzCEBonificacion.Value = (string ) _row["IdBonificacion"];
					uceExcluyePercepcionIB.Checked = Convert.ToBoolean(_row["ExcluyePercepcionIB"]);
					ExcluyePercepcionIB = Convert.ToBoolean(_row["ExcluyePercepcionIB"]);
					rtbObservaciones.Text= ( string )_row["Observaciones"];
					chkActivo.Checked = ( bool )_row["Activo"];
					uneAlicuotaPercepcionIngresosBrutos.Value = Convert.ToDecimal(_row["AlicuotaPercepcionIngresosBrutos"]);
					
					if(!_row["LimiteDeCredito"].Equals(System.DBNull.Value))
						uneLimiteDeCredito.Value =  _row["LimiteDeCredito"];
					else uneLimiteDeCredito.Value = 0;
					if(!_row["DiasLimiteDeCredito"].Equals(System.DBNull.Value))
						uneDiasLimiteDeCredito.Value =  _row["DiasLimiteDeCredito"];
					else uneDiasLimiteDeCredito.Value = 0;
					
					//gridDomicilios.SetDataBinding( _data.Tables["tcs_domicilios"], null);
                    /* Silvina 20110302 - Tarea 0000081 */
					bool cambio = _uiController.InitDomicilios();
                    if (cambio)
                    {
                    /* Fin Silvina */
                        /* Silvina 20101130 - Tarea 940 */
                        //gridDomiciliosAnterior.SetDataBinding(_uiController.DataDomicilios, null);
                        ConfigureGrid();
                        /* Silvina 20110411 - Tarea 0000106 */
                        if (!State.Equals("NEW"))
                        /* Fin Silvina 20110411 - Tarea 0000106 */
                            ConfigurarGrillaDomicilio();
                        ActualizarCombosGrillaDomicilios();
                    }
                    /* Fin Silvina */
					_uiController.InitContactos();
                    /* Silvina 20111104 - Tarea 0000222 */
                    _uiController.InitCampoAuxiliar6((string)_row["CampoAuxiliar6"]);
                    mzSTBCampoAuxiliar6.SetJerarquias(_uiController.JerarquiasCampoAuxiliar6);
                    /* Fin Silvina 20111104 - Tarea 0000222 */
					gridContactos.SetDataBinding(_uiController.DataContactos, null);
					ConfigureGridContactos();

					// ---- Matias - Custom 8 - Tarea 279 - 20090716
                    /* Silvina 20110406 - Tarea 0000081 */
					//this.mzCEResponsableIngreso.Value = Convert.ToString(_row["IdResponsableCreacion"]);
                    /* Fin Silvina 20110406 - Tarea 0000081 */
                    // ---- Fin Matias
									
				}
				catch(Exception e)
				{
					
					Console.WriteLine(e.Message);
				}
			}			
		}

		protected override void DumpControls()
		{
			if (_data != null)				
			{				
				mz.erp.businessrules.tsa_CuentasEx.State = this._state;
				mz.erp.commontypes.data.tsa_CuentasExDataset data = (mz.erp.commontypes.data.tsa_CuentasExDataset) _data;
				System.Data.DataTable tableCuentas = data.Tables["tsa_Cuentas"];
				System.Data.DataRow _row = tableCuentas.Rows[0];
				_row["Codigo"] = txtCodigo.Text;
				_row["Nombre"] = txtNombre.Text;
				
				_row["HorarioComercial"] = txtHorarioComercial.Text;
				
				_row["idTipoDocumento"] =componenteDocumentos1.TipoDocSelected;
				_row["Documento"] = componenteDocumentos1.Numero;
				_row["IdCategoriaIva"] = Convert.ToString(mzCmbTiposDeIVA.Value);
				_row["CampoAuxiliar1"] = txtCampoAuxiliar1.Text;
				_row["CampoAuxiliar2"] = txtCampoAuxiliar2.Text;
				_row["CampoAuxiliar3"] = txtCampoAuxiliar3.Text;

                /* Silvina 20111104 - Tarea 0000222 */
                _row["CampoAuxiliar6"] = mzSTBCampoAuxiliar6.NodeDescription;
                /* Fin Silvina 20111104 - Tarea 0000222 */

				_row["IdTitular"] = mzCmbSrchEdtTitular.DataValue;
				_row["Observaciones"] = rtbObservaciones.Text;
				
				try 
				{
					_row["IdConexionUltimaModificacion"] = businessrules.Security.IdConexion;
				}
				catch{}
				
				_row["Activo"] = chkActivo.Checked;
				_row["IdBonificacion"] = Convert.ToString(mzCEBonificacion.Value);

				_row["LimiteDeCredito"] = uneLimiteDeCredito.Value;
				_row["DiasLimiteDeCredito"] = uneDiasLimiteDeCredito.Value;
				_row["ExcluyePercepcionIB"] = uceExcluyePercepcionIB.Checked;
				_row["Email"] = txtEMail.Text;
				_row["IdListaDePreciosDefault"] = mzCEListaPrecios.Value;
				_row["AlicuotaPercepcionIngresosBrutos"] = uneAlicuotaPercepcionIngresosBrutos.Value;
				_row["IdResponsableCreacion"] = mzCEResponsableIngreso.Value;

				/*if (mzCmbSrchEdtTitular.DataValue != null && mzCmbSrchEdtTitular.DataValue != String.Empty) 
				{
					tsh_PersonasDataset.tsh_PersonasRow row = businessrules.tsh_Personas.GetByPk(mzCmbSrchEdtTitular.DataValue);
					if(row != null)
					{
						row.Email = txtEMail.Text;
						businessrules.tsh_Personas.Update(row);
					}
				}*/
                /* Silvina 20101130 - Tarea 940 
				gridDomiciliosAnterior.UpdateData();
                Fin Silvina */
				gridContactos.UpdateData();
				string IdCuenta = Convert.ToString(_row["IdCuenta"] );
				
				if(Variables.GetValueBool("Sistema.PercibeIB"))
				{
					if(this._state.Equals("NEW"))
					{
						data.tsy_ImpuestosCuentas.Rows.Clear();
						if(uceExcluyePercepcionIB.Checked || Convert.ToString(mzCmbTiposDeIVA.Value).Equals("CF") || Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI"))
						{
							AddTsy_ImpuestosCuentasRow( "00001000010000000001", IdCuenta, data);
						}
						if(uceExcluyePercepcionIB.Checked || Convert.ToString(mzCmbTiposDeIVA.Value).Equals("CF") || !Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI"))
						{
							AddTsy_ImpuestosCuentasRow( "00001000010000000008", IdCuenta, data );
						}
					}
					else
					{
						if(this._state.Equals("EDIT"))
						{
							bool excluyePIBChanged = (ExcluyePercepcionIB != uceExcluyePercepcionIB.Checked);
							bool CategoriaIVAChanged = (IdCategoriaIVA != Convert.ToString(mzCmbTiposDeIVA.Value));
							#region Se tilda o Destilda el checkbox ExcluyePercepcionIB
							if(excluyePIBChanged)
							{
								if(uceExcluyePercepcionIB.Checked)
								{
									if (data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000001", IdCuenta) == null)
									{
										AddTsy_ImpuestosCuentasRow( "00001000010000000001", IdCuenta, data);
									}
									if (data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000008", IdCuenta) == null)
									{
										AddTsy_ImpuestosCuentasRow( "00001000010000000008", IdCuenta, data);
									}
									
								}
								else //Vale la categoria de IVA
								{
									if(Convert.ToString(mzCmbTiposDeIVA.Value).Equals("CF") || Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI"))
									{
										if (data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000001", IdCuenta) == null)
										{
											AddTsy_ImpuestosCuentasRow( "00001000010000000001", IdCuenta, data);
										}
										if (Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI") && data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000008", IdCuenta) != null)
										{
											data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000008", IdCuenta).Delete();
										}
									}
									if(Convert.ToString(mzCmbTiposDeIVA.Value).Equals("CF") || !Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI"))
									{
										if (data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000008", IdCuenta) == null)
										{
											AddTsy_ImpuestosCuentasRow( "00001000010000000008", IdCuenta, data);
										}
										if (!Convert.ToString(mzCmbTiposDeIVA.Value).Equals("CF") && data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000001", IdCuenta) != null)
										{
											data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000001", IdCuenta).Delete();
										}

									}
								}
							}
								#endregion
								#region Cambia la categoria de IVA
							else
							{
								if(CategoriaIVAChanged && !uceExcluyePercepcionIB.Checked)
								{
									if(Convert.ToString(mzCmbTiposDeIVA.Value).Equals("CF") || Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI"))
									{
										if (data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000001", IdCuenta) == null)
										{
											AddTsy_ImpuestosCuentasRow( "00001000010000000001", IdCuenta, data);
										}
										if (Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI") && data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000008", IdCuenta) != null)
										{
											data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000008", IdCuenta).Delete();
										}
									}
									if(!Convert.ToString(mzCmbTiposDeIVA.Value).Equals("RI"))
									{
										if (data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000008", IdCuenta) == null)
										{
											AddTsy_ImpuestosCuentasRow( "00001000010000000008", IdCuenta, data);
										}
										if (!Convert.ToString(mzCmbTiposDeIVA.Value).Equals("CF") && data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000001", IdCuenta) != null)
										{
											data.tsy_ImpuestosCuentas.FindByIdImpuestoIdCuenta("00001000010000000001", IdCuenta).Delete();
										}
									}

								}
							}
							#endregion

						}
					}
				}
				data = _uiController.UpdateContactos(data);
				data = _uiController.UpdateDomicilios(data);
				_data = _uiController.Commit(data, IdCuenta);
			}
		}

		private void AddTsy_ImpuestosCuentasRow(string IdImpuesto, string IdCuenta, mz.erp.commontypes.data.tsa_CuentasExDataset data)
		{
			tsa_CuentasExDataset.tsy_ImpuestosCuentasRow rowIC = data.tsy_ImpuestosCuentas.Newtsy_ImpuestosCuentasRow();
			rowIC.IdImpuesto = IdImpuesto; 
			rowIC.IdCuenta = IdCuenta; 
			rowIC.MetodoDeAsignacion = "E";
			rowIC.FechaCreacion = DateTime.Now;
			rowIC.IdConexionCreacion = Security.IdConexion;
			rowIC.IdConexionUltimaModificacion = Security.IdConexion;
			rowIC.IdReservado = 0;
			rowIC.RowId = Guid.Empty;
			rowIC.IdEmpresa = Security.IdEmpresa;
			rowIC.IdSucursal = Security.IdSucursal;
			data.tsy_ImpuestosCuentas.Addtsy_ImpuestosCuentasRow(rowIC);
		}
				
	
		#endregion		
		
		#region Variables Privadas
		private controllers.AbmCuentasController _uiController = null;	
		string _idDomicilio = string.Empty;
		#endregion


		#region Inicializadores y Carga

		protected void Build_UI()
		{	//Configura los controllers, visibilidad, etc, etc
			ConfigureInterface();
			//Ejemplo le carga datos a un combo
            Console.WriteLine("Empieza InitializeData " + mz.erp.systemframework.Util.GetTotalMilliseconds());
            InitializeData();
            Console.WriteLine("Termina InitializeData " + mz.erp.systemframework.Util.GetTotalMilliseconds()); 
			//Asociar eventos a la interface
			InitEventHandlers();
			//Realizar binding entre la interface y el controlador
			InitDataBindings();
			//Para propiedades estaticas, datos q no dependen ni modifican a nadie.
            Console.WriteLine("Empieza FillControls " + mz.erp.systemframework.Util.GetTotalMilliseconds()); 
			FillControls();
            Console.WriteLine("Termina FillControls " + mz.erp.systemframework.Util.GetTotalMilliseconds()); 

		}

		
		private void ConfigureInterface()
		{
			this.hierarchicalSearchControl1.Build_UI("CUENTAS", _uiController.BuscadorJerarquicoAllowMultipleSelect);
			mz.erp.ui.forms.classes.ContainerManager.UpdateSize(this.ContainerJerarquia, hierarchicalSearchControl1);
			this.mzCEListaPrecios.Enabled = _uiController.HabilitaListasDePrecios;
			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, "Momentos.ABMCuentas.ContenedoresColapsados");
			mzCEResponsableIngreso.Enabled = _uiController.AllowEditResponsableIngreso;
			if (_uiController.AskForPasswordResponsableIngreso) 
			{
				this.mzCEResponsableIngreso.Nullable = true;				
				this.mzCEResponsableIngreso.NullText = string.Empty;
			}
            /* Silvina 20110804 - Tarea 0000178 */
            btnMasDetalles.Visible = false;
            utility.Util.LoadImagesAbmCuentas(toolBarStandar, imglStandar);
            gridDom.Enabled = true;
            gridDom.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            /* Fin Silvina 20110804 - Tarea 0000178 */
		}

		private void InitializeData()
		{
            mzCEResponsableIngreso.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(false), "IdPersona", "Nombre", 200, "ID", "Nombre", "Nombre");
			this.mzCEResponsableIngreso.Value = _uiController.IdResponsableIngreso;
		}

		private void InitEventHandlers()
		{
			this.hierarchicalSearchControl1.OnSelected +=new EventHandler(hierarchicalSearchControl1_OnSelected);
			this.mzCEResponsableIngreso.Leave+=new EventHandler(mzCEResponsableIngreso_Change);
            /* Silvina 20110315 - Tarea 000081 */
            this.mzCEBonificacion.ValueChanged += new System.EventHandler(this.mzCEBonificacion_ValueChanged);
            this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            this.btnBuscarContacto.Click += new System.EventHandler(this.btnBuscarContacto_Click);
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            this.btnMasDetallesContacto.Click += new System.EventHandler(this.btnMasDetallesContacto_Click);
            /* Fin Silvina */
            /* Silvina 20110804 - Tarea 0000178 */
            btnCancelar.Click += new EventHandler(btnCancelar_Click);
            btnAceptar.Click += new EventHandler(btnAceptar_Click);
            /* Fin Silvina 20110804 - Tarea 0000178 */
		}

		private void InitDataBindings()
		{
		}
		#endregion

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
				this.mzCEResponsableIngreso.Leave -= new EventHandler(mzCEResponsableIngreso_Change);
			}
			base.Dispose( disposing );
		}

		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
	
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup6 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup7 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
            this.ContainerDomicilio = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.panelABM = new System.Windows.Forms.Panel();
            this.btnAgregarDomicilio = new System.Windows.Forms.Button();
            this.btnEditarDomicilio = new System.Windows.Forms.Button();
            this.btnMasDetalles = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gridDom = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ContainerInformacionAdicional = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.lCampoAuxiliar6 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar2 = new System.Windows.Forms.TextBox();
            this.labelCampoAuxiliar2 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar3 = new System.Windows.Forms.TextBox();
            this.mzSTBCampoAuxiliar6 = new mz.erp.ui.controls.mzSearchTextBox();
            this.labelCampoAuxiliar3 = new System.Windows.Forms.Label();
            this.txtCampoAuxiliar1 = new System.Windows.Forms.TextBox();
            this.labelCampoAuxiliar1 = new System.Windows.Forms.Label();
            this.ContainerBonificacion = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mzCEBonificacion = new mz.erp.ui.controls.mzComboEditor();
            this.ContainerListaDePrecios = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.mzCEListaPrecios = new mz.erp.ui.controls.mzComboEditor();
            this.label5 = new System.Windows.Forms.Label();
            this.ContainerElementosAsociados = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grillaProductosAsociados = new Janus.Windows.GridEX.GridEX();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grillaElementosAsociados = new Janus.Windows.GridEX.GridEX();
            this.ContainerJerarquia = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.hierarchicalSearchControl1 = new mz.erp.ui.controls.HierarchicalSearchControl();
            this.ContainerContactos = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
            this.panelABMContactos = new System.Windows.Forms.Panel();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.btnEditarContacto = new System.Windows.Forms.Button();
            this.btnBuscarContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnMasDetallesContacto = new System.Windows.Forms.Button();
            this.gridContactos = new Janus.Windows.GridEX.GridEX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.imglStandar = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbObservaciones = new System.Windows.Forms.RichTextBox();
            this.componenteDocumentos1 = new mz.erp.ui.controls.ComponenteDocumentos();
            this.label7 = new System.Windows.Forms.Label();
            this.mzCmbTiposDeIVA = new mz.erp.ui.controls.mzComboEditor();
            this.label4 = new System.Windows.Forms.Label();
            this.mzCmbSrchEdtTitular = new mz.erp.ui.controls.mzComboSearchEditor();
            this.txtHorarioComercial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.uceExcluyePercepcionIB = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbbEditar = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.tbbVolver = new System.Windows.Forms.ToolBarButton();
            this.uneAlicuotaPercepcionIngresosBrutos = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label14 = new System.Windows.Forms.Label();
            this.uneLimiteDeCredito = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label12 = new System.Windows.Forms.Label();
            this.mzCEResponsableIngreso = new mz.erp.ui.controls.mzComboEditor();
            this.label15 = new System.Windows.Forms.Label();
            this.uneDiasLimiteDeCredito = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
            this.ultraExplorerBar1.SuspendLayout();
            this.ultraExplorerBarContainerControl1.SuspendLayout();
            this.ContainerDomicilio.SuspendLayout();
            this.panelABM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDom)).BeginInit();
            this.ContainerInformacionAdicional.SuspendLayout();
            this.ContainerBonificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).BeginInit();
            this.ContainerListaDePrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEListaPrecios)).BeginInit();
            this.ContainerElementosAsociados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductosAsociados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaElementosAsociados)).BeginInit();
            this.ContainerJerarquia.SuspendLayout();
            this.ContainerContactos.SuspendLayout();
            this.panelABMContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeIVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneAlicuotaPercepcionIngresosBrutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneLimiteDeCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasLimiteDeCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBarStandar
            // 
            this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.tbbVolver,
            this.toolBarButton2,
            this.tbbEditar});
            this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
            // 
            // ultraExplorerBar1
            // 
            this.ultraExplorerBar1.Controls.Add(this.ContainerInformacionAdicional);
            this.ultraExplorerBar1.Controls.Add(this.ContainerBonificacion);
            this.ultraExplorerBar1.Controls.Add(this.ContainerElementosAsociados);
            this.ultraExplorerBar1.Controls.Add(this.ContainerJerarquia);
            this.ultraExplorerBar1.Controls.Add(this.ContainerContactos);
            this.ultraExplorerBar1.Controls.Add(this.ContainerDomicilio);
            this.ultraExplorerBar1.Controls.Add(this.ContainerListaDePrecios);
            ultraExplorerBarGroup1.Container = this.ContainerDomicilio;
            ultraExplorerBarGroup1.Key = "Domicilios";
            ultraExplorerBarGroup1.Settings.ContainerHeight = 155;
            ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup1.Text = "Domicilios";
            ultraExplorerBarGroup2.Container = this.ContainerInformacionAdicional;
            ultraExplorerBarGroup2.Key = "InformaciónAdicional";
            ultraExplorerBarGroup2.Settings.ContainerHeight = 101;
            ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup2.Text = "Información Adicional";
            ultraExplorerBarGroup3.Container = this.ContainerBonificacion;
            ultraExplorerBarGroup3.Key = "Bonificaciónylímitedecrédito";
            ultraExplorerBarGroup3.Settings.ContainerHeight = 130;
            ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup3.Text = "Bonificación y límite de crédito";
            ultraExplorerBarGroup4.Container = this.ContainerListaDePrecios;
            ultraExplorerBarGroup4.Key = "ListadePrecios";
            ultraExplorerBarGroup4.Settings.ContainerHeight = 25;
            ultraExplorerBarGroup4.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup4.Text = "Lista de Precios";
            ultraExplorerBarGroup5.Container = this.ContainerElementosAsociados;
            ultraExplorerBarGroup5.Key = "ElementosAsociados";
            ultraExplorerBarGroup5.Settings.ContainerHeight = 182;
            ultraExplorerBarGroup5.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup5.Text = "Elementos Asociados";
            ultraExplorerBarGroup6.Container = this.ContainerJerarquia;
            ultraExplorerBarGroup6.Key = "Jerarquias";
            ultraExplorerBarGroup6.Settings.ContainerHeight = 48;
            ultraExplorerBarGroup6.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup6.Text = "Jerarquias";
            ultraExplorerBarGroup7.Container = this.ContainerContactos;
            ultraExplorerBarGroup7.Key = "Contactos";
            ultraExplorerBarGroup7.Settings.ContainerHeight = 300;
            ultraExplorerBarGroup7.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
            ultraExplorerBarGroup7.Text = "Contactos";
            this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
            ultraExplorerBarGroup1,
            ultraExplorerBarGroup2,
            ultraExplorerBarGroup3,
            ultraExplorerBarGroup4,
            ultraExplorerBarGroup5,
            ultraExplorerBarGroup6,
            ultraExplorerBarGroup7});
            this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
            this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
            this.ultraExplorerBar1.Margins.ForceSerialization = true;
            this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 513);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ContainerListaDePrecios, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ContainerDomicilio, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ContainerContactos, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ContainerJerarquia, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ContainerElementosAsociados, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ContainerBonificacion, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ContainerInformacionAdicional, 0);
            this.ultraExplorerBar1.Controls.SetChildIndex(this.ultraExplorerBarContainerControl1, 0);
            // 
            // ultraExplorerBarContainerControl1
            // 
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneDiasLimiteDeCredito);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label16);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEResponsableIngreso);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label15);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneLimiteDeCredito);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label12);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uneAlicuotaPercepcionIngresosBrutos);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label14);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.uceExcluyePercepcionIB);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label13);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtEMail);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtHorarioComercial);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNombre);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.txtCodigo);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.chkActivo);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSrchEdtTitular);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.componenteDocumentos1);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbTiposDeIVA);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.rtbObservaciones);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
            this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
            this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, -209);
            this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(854, 200);
            this.ultraExplorerBarContainerControl1.TabStop = false;
            // 
            // ContainerDomicilio
            // 
            this.ContainerDomicilio.Controls.Add(this.panelABM);
            this.ContainerDomicilio.Controls.Add(this.gridDom);
            this.ContainerDomicilio.Controls.Add(this.btnCancelar);
            this.ContainerDomicilio.Controls.Add(this.btnAceptar);
            this.ContainerDomicilio.Location = new System.Drawing.Point(28, 50);
            this.ContainerDomicilio.Name = "ContainerDomicilio";
            this.ContainerDomicilio.Size = new System.Drawing.Size(854, 155);
            this.ContainerDomicilio.TabIndex = 6;
            // 
            // panelABM
            // 
            this.panelABM.BackColor = System.Drawing.Color.Transparent;
            this.panelABM.Controls.Add(this.btnAgregarDomicilio);
            this.panelABM.Controls.Add(this.btnEditarDomicilio);
            this.panelABM.Controls.Add(this.btnMasDetalles);
            this.panelABM.Controls.Add(this.btnEliminar);
            this.panelABM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelABM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelABM.Location = new System.Drawing.Point(0, 0);
            this.panelABM.Name = "panelABM";
            this.panelABM.Size = new System.Drawing.Size(854, 24);
            this.panelABM.TabIndex = 3;
            // 
            // btnAgregarDomicilio
            // 
            this.btnAgregarDomicilio.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarDomicilio.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarDomicilio.Location = new System.Drawing.Point(0, 2);
            this.btnAgregarDomicilio.Name = "btnAgregarDomicilio";
            this.btnAgregarDomicilio.Size = new System.Drawing.Size(72, 20);
            this.btnAgregarDomicilio.TabIndex = 0;
            this.btnAgregarDomicilio.Text = "&Agregar";
            this.btnAgregarDomicilio.UseVisualStyleBackColor = false;
            // 
            // btnEditarDomicilio
            // 
            this.btnEditarDomicilio.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarDomicilio.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditarDomicilio.Location = new System.Drawing.Point(72, 2);
            this.btnEditarDomicilio.Name = "btnEditarDomicilio";
            this.btnEditarDomicilio.Size = new System.Drawing.Size(72, 20);
            this.btnEditarDomicilio.TabIndex = 1;
            this.btnEditarDomicilio.Text = "&Editar";
            this.btnEditarDomicilio.UseVisualStyleBackColor = false;
            // 
            // btnMasDetalles
            // 
            this.btnMasDetalles.BackColor = System.Drawing.SystemColors.Control;
            this.btnMasDetalles.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMasDetalles.Enabled = false;
            this.btnMasDetalles.Location = new System.Drawing.Point(216, 2);
            this.btnMasDetalles.Name = "btnMasDetalles";
            this.btnMasDetalles.Size = new System.Drawing.Size(72, 20);
            this.btnMasDetalles.TabIndex = 3;
            this.btnMasDetalles.Text = "Mas &Detalles";
            this.btnMasDetalles.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.Location = new System.Drawing.Point(144, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 20);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eli&minar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // gridDom
            // 
            this.gridDom.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridDom.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.gridDom.Enabled = false;
            this.gridDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDom.Location = new System.Drawing.Point(0, 24);
            this.gridDom.Name = "gridDom";
            this.gridDom.Size = new System.Drawing.Size(854, 131);
            this.gridDom.TabIndex = 1816;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.Location = new System.Drawing.Point(73, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 20);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.Location = new System.Drawing.Point(1, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(72, 20);
            this.btnAceptar.TabIndex = 1817;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // ContainerInformacionAdicional
            // 
            this.ContainerInformacionAdicional.Controls.Add(this.lCampoAuxiliar6);
            this.ContainerInformacionAdicional.Controls.Add(this.txtCampoAuxiliar2);
            this.ContainerInformacionAdicional.Controls.Add(this.labelCampoAuxiliar2);
            this.ContainerInformacionAdicional.Controls.Add(this.txtCampoAuxiliar3);
            this.ContainerInformacionAdicional.Controls.Add(this.mzSTBCampoAuxiliar6);
            this.ContainerInformacionAdicional.Controls.Add(this.labelCampoAuxiliar3);
            this.ContainerInformacionAdicional.Controls.Add(this.txtCampoAuxiliar1);
            this.ContainerInformacionAdicional.Controls.Add(this.labelCampoAuxiliar1);
            this.ContainerInformacionAdicional.Location = new System.Drawing.Point(28, 264);
            this.ContainerInformacionAdicional.Name = "ContainerInformacionAdicional";
            this.ContainerInformacionAdicional.Size = new System.Drawing.Size(854, 101);
            this.ContainerInformacionAdicional.TabIndex = 1;
            // 
            // lCampoAuxiliar6
            // 
            this.lCampoAuxiliar6.BackColor = System.Drawing.Color.Transparent;
            this.lCampoAuxiliar6.Location = new System.Drawing.Point(0, 72);
            this.lCampoAuxiliar6.Name = "lCampoAuxiliar6";
            this.lCampoAuxiliar6.Size = new System.Drawing.Size(100, 20);
            this.lCampoAuxiliar6.TabIndex = 73;
            this.lCampoAuxiliar6.Text = "label";
            // 
            // txtCampoAuxiliar2
            // 
            this.txtCampoAuxiliar2.Location = new System.Drawing.Point(104, 24);
            this.txtCampoAuxiliar2.Name = "txtCampoAuxiliar2";
            this.txtCampoAuxiliar2.Size = new System.Drawing.Size(736, 20);
            this.txtCampoAuxiliar2.TabIndex = 1;
            // 
            // labelCampoAuxiliar2
            // 
            this.labelCampoAuxiliar2.BackColor = System.Drawing.Color.Transparent;
            this.labelCampoAuxiliar2.Location = new System.Drawing.Point(0, 24);
            this.labelCampoAuxiliar2.Name = "labelCampoAuxiliar2";
            this.labelCampoAuxiliar2.Size = new System.Drawing.Size(120, 20);
            this.labelCampoAuxiliar2.TabIndex = 11;
            this.labelCampoAuxiliar2.Text = "label";
            // 
            // txtCampoAuxiliar3
            // 
            this.txtCampoAuxiliar3.Location = new System.Drawing.Point(104, 48);
            this.txtCampoAuxiliar3.Name = "txtCampoAuxiliar3";
            this.txtCampoAuxiliar3.Size = new System.Drawing.Size(736, 20);
            this.txtCampoAuxiliar3.TabIndex = 2;
            // 
            // mzSTBCampoAuxiliar6
            // 
            this.mzSTBCampoAuxiliar6.BackColor = System.Drawing.Color.Transparent;
            this.mzSTBCampoAuxiliar6.Location = new System.Drawing.Point(104, 72);
            this.mzSTBCampoAuxiliar6.Name = "mzSTBCampoAuxiliar6";
            this.mzSTBCampoAuxiliar6.Size = new System.Drawing.Size(312, 22);
            this.mzSTBCampoAuxiliar6.TabIndex = 72;
            // 
            // labelCampoAuxiliar3
            // 
            this.labelCampoAuxiliar3.BackColor = System.Drawing.Color.Transparent;
            this.labelCampoAuxiliar3.Location = new System.Drawing.Point(0, 48);
            this.labelCampoAuxiliar3.Name = "labelCampoAuxiliar3";
            this.labelCampoAuxiliar3.Size = new System.Drawing.Size(120, 20);
            this.labelCampoAuxiliar3.TabIndex = 9;
            this.labelCampoAuxiliar3.Text = "label";
            // 
            // txtCampoAuxiliar1
            // 
            this.txtCampoAuxiliar1.Location = new System.Drawing.Point(104, 0);
            this.txtCampoAuxiliar1.Name = "txtCampoAuxiliar1";
            this.txtCampoAuxiliar1.Size = new System.Drawing.Size(736, 20);
            this.txtCampoAuxiliar1.TabIndex = 0;
            // 
            // labelCampoAuxiliar1
            // 
            this.labelCampoAuxiliar1.BackColor = System.Drawing.Color.Transparent;
            this.labelCampoAuxiliar1.Location = new System.Drawing.Point(0, 0);
            this.labelCampoAuxiliar1.Name = "labelCampoAuxiliar1";
            this.labelCampoAuxiliar1.Size = new System.Drawing.Size(120, 20);
            this.labelCampoAuxiliar1.TabIndex = 0;
            this.labelCampoAuxiliar1.Text = "label";
            // 
            // ContainerBonificacion
            // 
            this.ContainerBonificacion.Controls.Add(this.gridEX1);
            this.ContainerBonificacion.Controls.Add(this.label9);
            this.ContainerBonificacion.Controls.Add(this.label8);
            this.ContainerBonificacion.Controls.Add(this.mzCEBonificacion);
            this.ContainerBonificacion.Location = new System.Drawing.Point(28, 424);
            this.ContainerBonificacion.Name = "ContainerBonificacion";
            this.ContainerBonificacion.Size = new System.Drawing.Size(854, 130);
            this.ContainerBonificacion.TabIndex = 2;
            this.ContainerBonificacion.TabStop = true;
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
            this.gridEX1.Location = new System.Drawing.Point(104, 24);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RecordNavigator = true;
            this.gridEX1.RecordNavigatorText = "Registro:|de";
            this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.gridEX1.ShowEmptyFields = false;
            this.gridEX1.Size = new System.Drawing.Size(384, 104);
            this.gridEX1.TabIndex = 1;
            this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(0, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 69;
            this.label9.Text = "Detalle de Bonificacion";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 68;
            this.label8.Text = "Bonificacion";
            // 
            // mzCEBonificacion
            // 
            this.mzCEBonificacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEBonificacion.DisplayMember = "";
            this.mzCEBonificacion.DisplayMemberCaption = "";
            this.mzCEBonificacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEBonificacion.ImageTransparentColor = System.Drawing.Color.Violet;
            this.mzCEBonificacion.Location = new System.Drawing.Point(104, 0);
            this.mzCEBonificacion.MaxItemsDisplay = 7;
            this.mzCEBonificacion.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEBonificacion.Name = "mzCEBonificacion";
            this.mzCEBonificacion.Size = new System.Drawing.Size(384, 21);
            this.mzCEBonificacion.SorterMember = "";
            this.mzCEBonificacion.TabIndex = 0;
            this.mzCEBonificacion.ValueMember = "";
            this.mzCEBonificacion.ValueMemberCaption = "";
            // 
            // ContainerListaDePrecios
            // 
            this.ContainerListaDePrecios.Controls.Add(this.mzCEListaPrecios);
            this.ContainerListaDePrecios.Controls.Add(this.label5);
            this.ContainerListaDePrecios.Location = new System.Drawing.Point(-10000, -10000);
            this.ContainerListaDePrecios.Name = "ContainerListaDePrecios";
            this.ContainerListaDePrecios.Size = new System.Drawing.Size(854, 25);
            this.ContainerListaDePrecios.TabIndex = 7;
            this.ContainerListaDePrecios.Visible = false;
            // 
            // mzCEListaPrecios
            // 
            this.mzCEListaPrecios.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEListaPrecios.DisplayMember = "";
            this.mzCEListaPrecios.DisplayMemberCaption = "";
            this.mzCEListaPrecios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEListaPrecios.ImageTransparentColor = System.Drawing.Color.Violet;
            this.mzCEListaPrecios.Location = new System.Drawing.Point(104, 0);
            this.mzCEListaPrecios.MaxItemsDisplay = 7;
            this.mzCEListaPrecios.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEListaPrecios.Name = "mzCEListaPrecios";
            this.mzCEListaPrecios.Size = new System.Drawing.Size(136, 21);
            this.mzCEListaPrecios.SorterMember = "";
            this.mzCEListaPrecios.TabIndex = 71;
            this.mzCEListaPrecios.ValueMember = "";
            this.mzCEListaPrecios.ValueMemberCaption = "";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Lista de Precios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContainerElementosAsociados
            // 
            this.ContainerElementosAsociados.Controls.Add(this.button3);
            this.ContainerElementosAsociados.Controls.Add(this.button4);
            this.ContainerElementosAsociados.Controls.Add(this.button2);
            this.ContainerElementosAsociados.Controls.Add(this.button1);
            this.ContainerElementosAsociados.Controls.Add(this.grillaProductosAsociados);
            this.ContainerElementosAsociados.Controls.Add(this.label11);
            this.ContainerElementosAsociados.Controls.Add(this.label10);
            this.ContainerElementosAsociados.Controls.Add(this.grillaElementosAsociados);
            this.ContainerElementosAsociados.Location = new System.Drawing.Point(-10000, -10000);
            this.ContainerElementosAsociados.Name = "ContainerElementosAsociados";
            this.ContainerElementosAsociados.Size = new System.Drawing.Size(854, 182);
            this.ContainerElementosAsociados.TabIndex = 3;
            this.ContainerElementosAsociados.TabStop = true;
            this.ContainerElementosAsociados.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(336, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Agregar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eliminar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            // 
            // grillaProductosAsociados
            // 
            this.grillaProductosAsociados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grillaProductosAsociados.AlternatingColors = true;
            this.grillaProductosAsociados.AutomaticSort = false;
            this.grillaProductosAsociados.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.grillaProductosAsociados.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillaProductosAsociados.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.grillaProductosAsociados.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.grillaProductosAsociados.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grillaProductosAsociados.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.grillaProductosAsociados.GroupByBoxVisible = false;
            this.grillaProductosAsociados.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.grillaProductosAsociados.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grillaProductosAsociados.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.grillaProductosAsociados.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.grillaProductosAsociados.Location = new System.Drawing.Point(336, 33);
            this.grillaProductosAsociados.Name = "grillaProductosAsociados";
            this.grillaProductosAsociados.RecordNavigator = true;
            this.grillaProductosAsociados.RecordNavigatorText = "Registro:|de";
            this.grillaProductosAsociados.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grillaProductosAsociados.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.grillaProductosAsociados.ShowEmptyFields = false;
            this.grillaProductosAsociados.Size = new System.Drawing.Size(312, 104);
            this.grillaProductosAsociados.TabIndex = 18;
            this.grillaProductosAsociados.TableSpacing = 3;
            this.grillaProductosAsociados.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(336, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Productos Asociados";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(9, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Elementos Asociados";
            // 
            // grillaElementosAsociados
            // 
            this.grillaElementosAsociados.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grillaElementosAsociados.AlternatingColors = true;
            this.grillaElementosAsociados.AutomaticSort = false;
            this.grillaElementosAsociados.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.grillaElementosAsociados.Cursor = System.Windows.Forms.Cursors.Default;
            this.grillaElementosAsociados.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.grillaElementosAsociados.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.grillaElementosAsociados.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.grillaElementosAsociados.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.grillaElementosAsociados.GroupByBoxVisible = false;
            this.grillaElementosAsociados.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.grillaElementosAsociados.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grillaElementosAsociados.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.grillaElementosAsociados.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.grillaElementosAsociados.Location = new System.Drawing.Point(7, 32);
            this.grillaElementosAsociados.Name = "grillaElementosAsociados";
            this.grillaElementosAsociados.RecordNavigator = true;
            this.grillaElementosAsociados.RecordNavigatorText = "Registro:|de";
            this.grillaElementosAsociados.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grillaElementosAsociados.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
            this.grillaElementosAsociados.ShowEmptyFields = false;
            this.grillaElementosAsociados.Size = new System.Drawing.Size(313, 104);
            this.grillaElementosAsociados.TabIndex = 15;
            this.grillaElementosAsociados.TableSpacing = 0;
            this.grillaElementosAsociados.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // ContainerJerarquia
            // 
            this.ContainerJerarquia.Controls.Add(this.hierarchicalSearchControl1);
            this.ContainerJerarquia.Location = new System.Drawing.Point(-10000, -10000);
            this.ContainerJerarquia.Name = "ContainerJerarquia";
            this.ContainerJerarquia.Size = new System.Drawing.Size(854, 48);
            this.ContainerJerarquia.TabIndex = 4;
            this.ContainerJerarquia.Visible = false;
            // 
            // hierarchicalSearchControl1
            // 
            this.hierarchicalSearchControl1.BackColor = System.Drawing.Color.Transparent;
            this.hierarchicalSearchControl1.Location = new System.Drawing.Point(7, 1);
            this.hierarchicalSearchControl1.Name = "hierarchicalSearchControl1";
            this.hierarchicalSearchControl1.Size = new System.Drawing.Size(840, 40);
            this.hierarchicalSearchControl1.TabIndex = 3;
            // 
            // ContainerContactos
            // 
            this.ContainerContactos.Controls.Add(this.panelABMContactos);
            this.ContainerContactos.Controls.Add(this.gridContactos);
            this.ContainerContactos.Location = new System.Drawing.Point(-10000, -10000);
            this.ContainerContactos.Name = "ContainerContactos";
            this.ContainerContactos.Size = new System.Drawing.Size(854, 300);
            this.ContainerContactos.TabIndex = 5;
            this.ContainerContactos.Visible = false;
            // 
            // panelABMContactos
            // 
            this.panelABMContactos.BackColor = System.Drawing.Color.Transparent;
            this.panelABMContactos.Controls.Add(this.btnAgregarContacto);
            this.panelABMContactos.Controls.Add(this.btnEditarContacto);
            this.panelABMContactos.Controls.Add(this.btnBuscarContacto);
            this.panelABMContactos.Controls.Add(this.btnEliminarContacto);
            this.panelABMContactos.Controls.Add(this.btnMasDetallesContacto);
            this.panelABMContactos.Location = new System.Drawing.Point(0, -1);
            this.panelABMContactos.Name = "panelABMContactos";
            this.panelABMContactos.Size = new System.Drawing.Size(360, 24);
            this.panelABMContactos.TabIndex = 12;
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarContacto.Location = new System.Drawing.Point(0, 2);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(72, 20);
            this.btnAgregarContacto.TabIndex = 0;
            this.btnAgregarContacto.Text = "&Agregar";
            this.btnAgregarContacto.UseVisualStyleBackColor = false;
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarContacto.Location = new System.Drawing.Point(72, 2);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(72, 20);
            this.btnEditarContacto.TabIndex = 1;
            this.btnEditarContacto.Text = "&Editar";
            this.btnEditarContacto.UseVisualStyleBackColor = false;
            // 
            // btnBuscarContacto
            // 
            this.btnBuscarContacto.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarContacto.Location = new System.Drawing.Point(144, 2);
            this.btnBuscarContacto.Name = "btnBuscarContacto";
            this.btnBuscarContacto.Size = new System.Drawing.Size(72, 20);
            this.btnBuscarContacto.TabIndex = 2;
            this.btnBuscarContacto.Text = "&Buscar";
            this.btnBuscarContacto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarContacto.Location = new System.Drawing.Point(216, 2);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(72, 20);
            this.btnEliminarContacto.TabIndex = 3;
            this.btnEliminarContacto.Text = "Eli&minar";
            this.btnEliminarContacto.UseVisualStyleBackColor = false;
            // 
            // btnMasDetallesContacto
            // 
            this.btnMasDetallesContacto.BackColor = System.Drawing.SystemColors.Control;
            this.btnMasDetallesContacto.Location = new System.Drawing.Point(288, 2);
            this.btnMasDetallesContacto.Name = "btnMasDetallesContacto";
            this.btnMasDetallesContacto.Size = new System.Drawing.Size(72, 20);
            this.btnMasDetallesContacto.TabIndex = 4;
            this.btnMasDetallesContacto.Text = "Mas &Detalles";
            this.btnMasDetallesContacto.UseVisualStyleBackColor = false;
            // 
            // gridContactos
            // 
            this.gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridContactos.AlternatingColors = true;
            this.gridContactos.AutomaticSort = false;
            this.gridContactos.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.gridContactos.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridContactos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridContactos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridContactos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
            this.gridContactos.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridContactos.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
            this.gridContactos.GroupByBoxVisible = false;
            this.gridContactos.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridContactos.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.gridContactos.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
            this.gridContactos.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
            this.gridContactos.Location = new System.Drawing.Point(0, 28);
            this.gridContactos.Name = "gridContactos";
            this.gridContactos.RecordNavigatorText = "Registro:|de";
            this.gridContactos.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridContactos.ShowEmptyFields = false;
            this.gridContactos.Size = new System.Drawing.Size(854, 272);
            this.gridContactos.TabIndex = 5;
            this.gridContactos.TabStop = false;
            this.gridContactos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(104, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "textBox1";
            // 
            // imglStandar
            // 
            this.imglStandar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
            this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(-1, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Observaciones";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(744, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(0, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Razon Social";
            // 
            // rtbObservaciones
            // 
            this.rtbObservaciones.Location = new System.Drawing.Point(104, 95);
            this.rtbObservaciones.Name = "rtbObservaciones";
            this.rtbObservaciones.Size = new System.Drawing.Size(744, 32);
            this.rtbObservaciones.TabIndex = 9;
            this.rtbObservaciones.Text = "";
            // 
            // componenteDocumentos1
            // 
            this.componenteDocumentos1.BackColor = System.Drawing.Color.Transparent;
            this.componenteDocumentos1.Location = new System.Drawing.Point(-8, 46);
            this.componenteDocumentos1.Name = "componenteDocumentos1";
            this.componenteDocumentos1.Numero = "0";
            this.componenteDocumentos1.Size = new System.Drawing.Size(504, 26);
            this.componenteDocumentos1.TabIndex = 3;
            this.componenteDocumentos1.TipoDocSelected = "";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(0, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 69;
            this.label7.Text = "Condición de IVA";
            // 
            // mzCmbTiposDeIVA
            // 
            this.mzCmbTiposDeIVA.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCmbTiposDeIVA.DisplayMember = "";
            this.mzCmbTiposDeIVA.DisplayMemberCaption = "";
            this.mzCmbTiposDeIVA.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCmbTiposDeIVA.Location = new System.Drawing.Point(104, 72);
            this.mzCmbTiposDeIVA.MaxItemsDisplay = 7;
            this.mzCmbTiposDeIVA.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCmbTiposDeIVA.Name = "mzCmbTiposDeIVA";
            this.mzCmbTiposDeIVA.Size = new System.Drawing.Size(216, 21);
            this.mzCmbTiposDeIVA.SorterMember = "";
            this.mzCmbTiposDeIVA.TabIndex = 6;
            this.mzCmbTiposDeIVA.ValueMember = "";
            this.mzCmbTiposDeIVA.ValueMemberCaption = "";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(0, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "Horario comercial";
            // 
            // mzCmbSrchEdtTitular
            // 
            this.mzCmbSrchEdtTitular.DataValue = "";
            this.mzCmbSrchEdtTitular.EditObject = null;
            this.mzCmbSrchEdtTitular.FastSearch = false;
            this.mzCmbSrchEdtTitular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mzCmbSrchEdtTitular.HierarchicalSearch = false;
            this.mzCmbSrchEdtTitular.Location = new System.Drawing.Point(104, 170);
            this.mzCmbSrchEdtTitular.Name = "mzCmbSrchEdtTitular";
            this.mzCmbSrchEdtTitular.ReadOnly = false;
            this.mzCmbSrchEdtTitular.SearchObject = null;
            this.mzCmbSrchEdtTitular.SearchObjectListener = null;
            this.mzCmbSrchEdtTitular.Size = new System.Drawing.Size(496, 22);
            this.mzCmbSrchEdtTitular.TabIndex = 12;
            // 
            // txtHorarioComercial
            // 
            this.txtHorarioComercial.Location = new System.Drawing.Point(104, 127);
            this.txtHorarioComercial.Name = "txtHorarioComercial";
            this.txtHorarioComercial.Size = new System.Drawing.Size(744, 20);
            this.txtHorarioComercial.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(0, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 75;
            this.label3.Text = "Titular";
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.Transparent;
            this.chkActivo.BackColorInternal = System.Drawing.Color.Transparent;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(613, 170);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 24);
            this.chkActivo.TabIndex = 13;
            this.chkActivo.Text = "Activo";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(104, 148);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(744, 20);
            this.txtEMail.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(0, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 85;
            this.label13.Text = "E-Mail";
            // 
            // uceExcluyePercepcionIB
            // 
            this.uceExcluyePercepcionIB.BackColor = System.Drawing.Color.Transparent;
            this.uceExcluyePercepcionIB.BackColorInternal = System.Drawing.Color.Transparent;
            this.uceExcluyePercepcionIB.Checked = true;
            this.uceExcluyePercepcionIB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uceExcluyePercepcionIB.Location = new System.Drawing.Point(328, 76);
            this.uceExcluyePercepcionIB.Name = "uceExcluyePercepcionIB";
            this.uceExcluyePercepcionIB.Size = new System.Drawing.Size(240, 16);
            this.uceExcluyePercepcionIB.TabIndex = 7;
            this.uceExcluyePercepcionIB.Text = "Excluye Percepción Ing. Brutos";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.toolBarButton1.Visible = false;
            // 
            // tbbEditar
            // 
            this.tbbEditar.ImageIndex = 6;
            this.tbbEditar.Name = "tbbEditar";
            this.tbbEditar.Text = "Editar";
            this.tbbEditar.Visible = false;
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.toolBarButton2.Visible = false;
            // 
            // tbbVolver
            // 
            this.tbbVolver.ImageIndex = 1;
            this.tbbVolver.Name = "tbbVolver";
            this.tbbVolver.Text = "Volver";
            this.tbbVolver.Visible = false;
            // 
            // uneAlicuotaPercepcionIngresosBrutos
            // 
            this.uneAlicuotaPercepcionIngresosBrutos.Location = new System.Drawing.Point(675, 72);
            this.uneAlicuotaPercepcionIngresosBrutos.Name = "uneAlicuotaPercepcionIngresosBrutos";
            this.uneAlicuotaPercepcionIngresosBrutos.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneAlicuotaPercepcionIngresosBrutos.Size = new System.Drawing.Size(100, 21);
            this.uneAlicuotaPercepcionIngresosBrutos.TabIndex = 8;
            this.uneAlicuotaPercepcionIngresosBrutos.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(568, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 87;
            this.label14.Text = "Alicuota Perc. IB";
            // 
            // uneLimiteDeCredito
            // 
            this.uneLimiteDeCredito.Location = new System.Drawing.Point(567, 46);
            this.uneLimiteDeCredito.Name = "uneLimiteDeCredito";
            this.uneLimiteDeCredito.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneLimiteDeCredito.Size = new System.Drawing.Size(100, 21);
            this.uneLimiteDeCredito.TabIndex = 4;
            this.uneLimiteDeCredito.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(489, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 22);
            this.label12.TabIndex = 88;
            this.label12.Text = "Lím. de crédito";
            // 
            // mzCEResponsableIngreso
            // 
            this.mzCEResponsableIngreso.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzCEResponsableIngreso.DisplayMember = "";
            this.mzCEResponsableIngreso.DisplayMemberCaption = "";
            this.mzCEResponsableIngreso.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzCEResponsableIngreso.Location = new System.Drawing.Point(675, 0);
            this.mzCEResponsableIngreso.MaxItemsDisplay = 8;
            this.mzCEResponsableIngreso.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzCEResponsableIngreso.Name = "mzCEResponsableIngreso";
            this.mzCEResponsableIngreso.Size = new System.Drawing.Size(173, 21);
            this.mzCEResponsableIngreso.SorterMember = "";
            this.mzCEResponsableIngreso.TabIndex = 1;
            this.mzCEResponsableIngreso.ValueMember = "";
            this.mzCEResponsableIngreso.ValueMemberCaption = "";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(568, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 14);
            this.label15.TabIndex = 91;
            this.label15.Text = "Responsable de alta";
            // 
            // uneDiasLimiteDeCredito
            // 
            this.uneDiasLimiteDeCredito.Location = new System.Drawing.Point(768, 46);
            this.uneDiasLimiteDeCredito.MaskInput = "nnnn";
            this.uneDiasLimiteDeCredito.MaxValue = 9999;
            this.uneDiasLimiteDeCredito.MinValue = 0;
            this.uneDiasLimiteDeCredito.Name = "uneDiasLimiteDeCredito";
            this.uneDiasLimiteDeCredito.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneDiasLimiteDeCredito.Size = new System.Drawing.Size(80, 21);
            this.uneDiasLimiteDeCredito.TabIndex = 5;
            this.uneDiasLimiteDeCredito.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(676, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 16);
            this.label16.TabIndex = 93;
            this.label16.Text = "Dias Lim. Cred.";
            // 
            // FrmAbmCuentas
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(920, 541);
            this.Name = "FrmAbmCuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
            this.ultraExplorerBar1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.ResumeLayout(false);
            this.ultraExplorerBarContainerControl1.PerformLayout();
            this.ContainerDomicilio.ResumeLayout(false);
            this.panelABM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDom)).EndInit();
            this.ContainerInformacionAdicional.ResumeLayout(false);
            this.ContainerInformacionAdicional.PerformLayout();
            this.ContainerBonificacion.ResumeLayout(false);
            this.ContainerBonificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEBonificacion)).EndInit();
            this.ContainerListaDePrecios.ResumeLayout(false);
            this.ContainerListaDePrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEListaPrecios)).EndInit();
            this.ContainerElementosAsociados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductosAsociados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaElementosAsociados)).EndInit();
            this.ContainerJerarquia.ResumeLayout(false);
            this.ContainerContactos.ResumeLayout(false);
            this.panelABMContactos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCmbTiposDeIVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneAlicuotaPercepcionIngresosBrutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneLimiteDeCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzCEResponsableIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneDiasLimiteDeCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	
		#endregion

		private void mzCEBonificacion_ValueChanged(object sender, System.EventArgs e)
		{
			string IdBonificacion= (string)mzCEBonificacion.Value;
			if (IdBonificacion !=null)
				gridEX1.DataSource= mz.erp.businessrules.tsa_BonificacionesDet.GetList(IdBonificacion, decimal.MinValue).tsa_BonificacionesDet;
		}

		private void mzCmbSrchEdtCategoriaIva_Load(object sender, System.EventArgs e)
		{
		
		}

		public void ShowForm( string id,string state, string caption )
		{
			Init();
			if ( state.ToUpper().Equals("NEW")) 
			{
				New();
				this._state = state;
			}
			else
			{

				Modify(id);
				this._state = "EDIT";
				
			}
			this.Text = caption;
            Console.WriteLine("Empieza InitializeMembers " + mz.erp.systemframework.Util.GetTotalMilliseconds()); 
			InitializeMembers();
            Console.WriteLine("Termina InitializeMembers " + mz.erp.systemframework.Util.GetTotalMilliseconds()); 
			if(state.ToUpper().Equals("READONLY"))
				DisableUI();
			FillControls();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();
		}


		private void DisableUI()
		{
			tbbEditar.Visible = true;
			tbGuardar.Visible = false;
            toolBarButton2.Visible = true;
			tbbVolver.Visible = true;
			ultraExplorerBarContainerControl1.Enabled = false;
			ContainerDomicilio.Enabled = false;
			ContainerBonificacion.Enabled = false;
			ContainerContactos.Enabled = false;
			ContainerElementosAsociados.Enabled = false;
			ContainerInformacionAdicional.Enabled = false;
			ContainerJerarquia.Enabled = false;
			ContainerListaDePrecios.Enabled = false;
		}



		[ IsShowWithParametersValueFormMember]
		public void ShowForm( object id, Parameters parameters , string caption )
		{
			Init();
			if ( id == null ) 
			{
				New();
				this._state = "NEW";
				this.Text = "Alta de " + caption;
			
				InitializeRowWithParameters(parameters);
			}
			else
			{
				Modify(id);
				this._state = "EDIT";
				this.Text = "Modificación de " + caption;
			}
			InitializeMembers();
			FillControls();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();

		}

		public void ShowForm( object id, string state,string nombre , string caption )
		{
			Init();
			if ( id == null ) 
			{
				New();
				this._state = "NEW";
				this.Text = "Alta de " + caption;
				InitializeRowWithNombre(nombre);
			}
			else
			{
				Modify(id);
				this._state = "EDIT";
				this.Text = "Modificación de " + caption;
			}
			InitializeMembers();
			FillControls();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();

		}

		private void InitializeRowWithNombre(string Nombre)
		{
			System.Data.DataTable table = _data.Tables["tsa_Cuentas"];
			System.Data.DataRow row = table.Rows[0];
			if(row != null)
                row["Nombre"] = Nombre;
			
		}


		private void InitializeRowWithParameters(Parameters parameters)
		{
			System.Data.DataTable table = _data.Tables["tsa_Cuentas"];
			System.Data.DataRow row = table.Rows[0];
			for(int i =0 ; i < parameters.Count; i++)
			{	
				Parameter param = (Parameter) parameters[i];
				if(!(param.Value == null))
					row[param.Name] = param.Value;
			}
		}

		private void btnAgregarDomicilio_Click(object sender, EventArgs e)
		{
            /* Silvina 20101126 - Tarea 940 */
            //int pos = 0;
            /*if (gridDomiciliosAnterior.SelectedItems.Count != 0)
                pos = gridDomiciliosAnterior.SelectedItems[0].Position;*/
            //pos = gridDom.ActiveRow.Index;
            /* Fin Silvina */
			/*gridDomiciliosAnterior.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridDomiciliosAnterior.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridDomiciliosAnterior.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;*/
            /* Silvina 20110823 - Tarea 0000178 */
            gridDom.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            /* Fin Silvina 20110823 - Tarea 0000178 */
            //gridDom.Enabled = true;
			panelABM.Visible = false;
            //_permiteEditar = true;
			_uiController.AddDomicilio();
            /* Silvina 20101126 - Tarea 940 */
            //DomicilioCuenta dom = (DomicilioCuenta)_uiController.DataDomicilios[0];
            /* Fin Silvina */
			//gridDomiciliosAnterior.SetDataBinding(_uiController.DataDomicilios, null);
            gridDom.DataSource = null;
            gridDom.DataSource = _uiController.DataDomicilios;
            gridDom.DataBind();
            ConfigurarGrillaDomicilio();
            ActualizarCombosGrillaDomicilios();
            /* Silvina 20101125 - Tarea 940 */
            /*ConfigureGrid();

            gridDomiciliosAnterior.Row = pos;
            ActualizarCombosGrillaDomicilios(dom, pos);

            gridDomiciliosAnterior.Row = 0;
            gridDomiciliosAnterior.Select();
            gridDomiciliosAnterior.Focus();*/
            //ConfigureGridDefault();
            /* Fin Silvina */
            /* Silvina 20110804 - Tarea 0000178 */
            btnCancelar.Visible = true;
            btnAceptar.Visible = true;
            /* Fin Silvina 20110804 - Tarea 0000178 */

		}

        /* Silvina 20101126 - Tarea 940 
        private void ActualizarCombosGrillaDomicilios(DomicilioCuenta dom, int pos)
        {
            Janus.Windows.GridEX.GridEXCellCollection cell = gridDomiciliosAnterior.GetRows()[pos].Cells;

            Janus.Windows.GridEX.GridEXColumn colP = cell["IdPais"].Column;
            Janus.Windows.GridEX.GridEXValueListItemCollection vlP = new Janus.Windows.GridEX.GridEXValueListItemCollection();
            vlP.PopulateValueList(dom.Paises, "IdPais", "Nombre");
            colP.EditValueList = vlP;
            //colP.ValueList.PopulateValueList(dom.Paises, "IdPais", "Nombre");

            Janus.Windows.GridEX.GridEXColumn colPr = cell["IdProvincia"].Column;
            Janus.Windows.GridEX.GridEXValueListItemCollection vlPr = new Janus.Windows.GridEX.GridEXValueListItemCollection();
            vlPr.PopulateValueList(dom.Provincias, "IdProvincia", "Nombre");
            colPr.EditValueList = vlPr;
            //colPr.ValueList.PopulateValueList(dom.Provincias, "IdProvincia", "Nombre");

            Janus.Windows.GridEX.GridEXColumn colL = cell["IdLocalidad"].Column;
            Janus.Windows.GridEX.GridEXValueListItemCollection vlL = new Janus.Windows.GridEX.GridEXValueListItemCollection();
            vlL.PopulateValueList(dom.Localidades, "IdLocalidad", "Descripcion");
            colL.EditValueList = vlL;
            //colL.ValueList.PopulateValueList(dom.Localidades, "IdLocalidad", "Descripcion");
        }
        Fin Silvina */

        /* Silvina 20101201 - Tarea 940 */
        private void ActualizarCombosGrillaDomicilios()
        {
            //Infragistics.Win.UltraWinGrid.CellsCollection cell = gridDom.Rows[pos].Cells;
           // DomicilioCuenta dom = (DomicilioCuenta)_uiController.DataDomicilios[pos];
            foreach (DomicilioCuenta dom in _uiController.DataDomicilios)
            {
                int pos = _uiController.DataDomicilios.IndexOf(dom);
                Infragistics.Win.UltraWinGrid.CellsCollection cell = gridDom.Rows[pos].Cells;
                //Infragistics.Win.UltraWinGrid.UltraGridColumn colP = cell["IdPais"].Column;
                Infragistics.Win.ValueList vlP = new Infragistics.Win.ValueList();
                foreach (DataRowView row in dom.Paises)
                    vlP.ValueListItems.Add(row["IdPais"].ToString(), row["Nombre"].ToString());
                cell["IdPais"].ValueList = vlP;
                cell["IdPais"].Value = dom.IdPais;

                //Infragistics.Win.UltraWinGrid.UltraGridColumn colPr = cell["IdProvincia"].Column;
                Infragistics.Win.ValueList vlPr = new Infragistics.Win.ValueList();
                foreach (DataRowView row in dom.Provincias)
                    vlPr.ValueListItems.Add(row["IdProvincia"].ToString(), row["Nombre"].ToString());
                //gridDom.DisplayLayout.Bands[0].Columns["IdProvincia"].ValueList = vlPr;
                cell["IdProvincia"].ValueList = vlPr;
                cell["IdProvincia"].Value = dom.IdProvincia;

                //Infragistics.Win.UltraWinGrid.UltraGridColumn colL = cell["IdLocalidad"].Column;
                Infragistics.Win.ValueList vlL = new Infragistics.Win.ValueList();
                foreach (DataRowView row in dom.Localidades)
                    vlL.ValueListItems.Add(row["IdLocalidad"].ToString(), row["Descripcion"].ToString());
                cell["IdLocalidad"].ValueList = vlL;
                cell["IdLocalidad"].Value = dom.IdLocalidad;

                Infragistics.Win.ValueList valTD = new Infragistics.Win.ValueList();
                tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosDataTable td = mz.erp.businessrules.tcs_TiposDomicilios.GetList().tcs_TiposDomicilios;
                foreach (tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow row in td)
                    valTD.ValueListItems.Add(row.IdTipoDomicilio, row.Descripcion);
                gridDom.Rows[0].Cells["IdTipoDomicilio"].Column.ValueList = valTD;
                cell["IdTipoDomicilio"].Value = dom.IdTipoDomicilio;
            }

        }

		private void frmABMDomicilios_OnDomicilioChanged(object sender, EventArgs args)
		{
			DomicilioCuenta dom = (DomicilioCuenta) sender;
			if(_stateFormDomicilios.ToUpper().Equals("NEW"))
				_uiController.AddDomicilio(dom);
			else
                _uiController.ModifyDomicilio(dom);
			//gridDomiciliosAnterior.SetDataBinding(_uiController.DataDomicilios, null);
			//gridDomicilios.Refetch();
			ConfigureGrid();
		}

        /* Fin Silvina */
	
		private void frmAbmPersonas_OnRowChanged(object sender, EventArgs args)
		{
			gridContactos.SetDataBinding(null, null);
			_uiController.InitContactos();
			gridContactos.SetDataBinding(_uiController.DataContactos, null);
			ConfigureGridContactos();
			
		}

        /* Silvina 20110804 - Tarea 0000178 */
        void btnCancelar_Click(object sender, EventArgs e)
        {
            _uiController.Cancelar();
            panelABM.Visible = true;
            gridDom.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;
            gridDom.DataSource = null;
            gridDom.DataSource = _uiController.DataDomicilios;
            gridDom.DataBind();
            if (_uiController.DataDomicilios.Count > 0)
            {
                ConfigurarGrillaDomicilio();
                ActualizarCombosGrillaDomicilios();
            }
            _eliminar = false;
        }

        bool _eliminar = false;

        void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_eliminar)
                EliminarDomicilio();
            else
                _uiController.Aceptar();
            panelABM.Visible = true;
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;
            ActualizarCombosGrillaDomicilios();
            gridDom.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
        }

        /* Fin Silvina 20110804 - Tarea 0000178 */

        /* Silvina 20101130 - Tarea 940 */
        //bool _permiteEditar = false;
		private void btnEditarDomicilio_Click(object sender, System.EventArgs e)
		{
            //German 20101223 - Tarea 1003
            if (gridDom.ActiveRow != null)
            {
                //gridDom.Enabled = true;
                panelABM.Visible = false;
                //_permiteEditar = true;
                /* Silvina 20110804 - Tarea 0000178 */
                btnCancelar.Visible = true;
                btnAceptar.Visible = true;
                /* Fin Silvina 20110804 - Tarea 0000178 */
            }
            //Fin German 20101223 - Tarea 1003
            /* Silvina 20110823 - Tarea 0000178 */
            gridDom.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            /* Fin Silvina 20110823 - Tarea 0000178 */
		}
        /* Fin Silvina */		

    	private void gridContactos_UpdatingRecord(object sender, CancelEventArgs e)
		{
			int index = gridContactos.SelectedItems[0].Position;
			_uiController.ModifyContacto(index);
		}

        /* Silvina 20101130 - Tarea 940 
		private void gridDomicilios_UpdatingRecord(object sender, CancelEventArgs e)
		{
			/*Janus.Windows.GridEX.GridEXSelectedItem col = gridDomicilios.SelectedItems[0];
			Janus.Windows.GridEX.GridEXRow row = col.GetRow();
			if(row.Cells["IdResponsable"].Value == null)
				row.Cells["IdResponsable"].Value = Security.IdPersona;
			

			int index = gridDomiciliosAnterior.SelectedItems[0].Position;
			_uiController.ModifyDomicilio(index);
			gridDomiciliosAnterior.SetDataBinding(_uiController.DataDomicilios, null);
		}
        Fin Silvina */

		/*private void mzCmbSrchEdtTitular_ValueChanged(object sender, System.EventArgs e)
		{
			if (mzCmbSrchEdtTitular.DataValue != null && mzCmbSrchEdtTitular.DataValue != string.Empty) 
			{
				tsh_PersonasDataset.tsh_PersonasRow row = businessrules.tsh_Personas.GetByPk(mzCmbSrchEdtTitular.DataValue);
				if(row != null)
				{
					txtEMail.Text = row.Email;                
				}
			}
			else 
			{
				txtEMail.Text = String.Empty;
			}
		}*/
        /* Silvina 20101202 - Tarea 940 */
		private void btnEliminar_Click(object sender, EventArgs e)
		{			
            /* Silvina 20110823 - Tarea 0000178 */
            if (gridDom.ActiveRow != null)
            {
                gridDom.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
                panelABM.Visible = false;
                btnCancelar.Visible = true;
                btnAceptar.Visible = true;
                _eliminar = true;
            }
            /* Fin Silvina 20110823 - Tarea 0000178 */
		}
		
		private void gridDomicilios_DropDown(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{			
            /* Silvina 20101123 - Trea 940 */
            /*string key = e.Column.Key;
            switch(key)
            {
                case "IdProvincia": 
                {				
                    long idPaisSeleted = (long)gridDomicilios.SelectedItems[0].GetRow().Cells["IdPais"].Value;
                    Janus.Windows.GridEX.GridEXColumnCollection col = gridDomicilios.RootTable.Columns;

                    Janus.Windows.GridEX.GridEXValueListItemCollection vlP = new Janus.Windows.GridEX.GridEXValueListItemCollection();
                    vlP.PopulateValueList(_uiController.GetListProvincias(idPaisSeleted),"IdProvincia","Nombre");
                    col["IdProvincia"].EditValueList = vlP;

                    break;
                }
                case "IdLocalidad": 
                {				
                    long idProvinciaSeleted = (long)gridDomicilios.SelectedItems[0].GetRow().Cells["IdProvincia"].Value;
                    Janus.Windows.GridEX.GridEXColumnCollection col = gridDomicilios.RootTable.Columns;

                    Janus.Windows.GridEX.GridEXValueListItemCollection vlL = new Janus.Windows.GridEX.GridEXValueListItemCollection();
                    vlL.PopulateValueList(_uiController.GetListLocalidades(idProvinciaSeleted),"IdLocalidad","Descripcion");
                    col["IdLocalidad"].EditValueList = vlL;

                    break;
                }


                default:
                    break;				
            }*/

            /* Fin Silvina */

		}


		private void gridContactos_RecordUpdated(object sender, EventArgs e)
		{
			gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;	
			panelABMContactos.Visible = true;
		}

		private void btnMasDetalles_Click(object sender, EventArgs e)
		{
            /* Silvina 20101203 - Tarea 940 */
			//if(this.gridDomiciliosAnterior.SelectedItems.Count  == 0 )
            if (gridDom.ActiveRow == null)
			{
				FrmAbmDomicilios frmABMDomicilios = new FrmAbmDomicilios();
				frmABMDomicilios.OnDomicilioChanged += new mz.erp.ui.forms.FrmAbmDomicilios.DomicilioChanged(frmABMDomicilios_OnDomicilioChanged);
				_stateFormDomicilios = "NEW";
				DomicilioCuenta dom = new DomicilioCuenta(_uiController.IdCuenta, true, "NEW");	
				frmABMDomicilios.ShowForm("NUEVO", dom);
			}
			else
				//if(gridDomiciliosAnterior.SelectedItems.Count >0)
			{
				//int index = gridDomiciliosAnterior.SelectedItems[0].Position;	
                int index = gridDom.ActiveRow.Index;
				DomicilioCuenta dom = _uiController.GetDomicilio(index);
				FrmAbmDomicilios frmABMDomicilios = new FrmAbmDomicilios();
				frmABMDomicilios.OnDomicilioChanged += new mz.erp.ui.forms.FrmAbmDomicilios.DomicilioChanged(frmABMDomicilios_OnDomicilioChanged);
				_stateFormDomicilios = "EDIT";
				frmABMDomicilios.ShowForm("EDITAR", dom);
			}
		}

		private void gridContactos_RowEditCanceled(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
		{
			gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;	
			panelABMContactos.Visible = true;
		}

		private void gridContactos_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}
		
		private void gridDomicilios_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = false;
		}

		protected void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
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
                    /* Silvina 20110804 - Tarea 0000178 */
                    if (!panelABM.Visible)
                        MessageBox.Show("Debe confirmar el Domicilio.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    else 
					    SaveChanges();
                    /* Fin Silvina 20110804 - Tarea 0000178 */
					break;
				case 9:
					Delete();
					break;
				case 11:
					this.Close();
					break;
				case 13:
					SetEditableUI();
					break;
			}		
		}

		private void SetEditableUI()
		{
			tbbEditar.Visible = false;
			tbGuardar.Visible = true;
			toolBarButton2.Visible = false;
			ultraExplorerBarContainerControl1.Enabled =  true;
			ContainerDomicilio.Enabled = true;
			ContainerInformacionAdicional.Enabled = true;
			ContainerBonificacion.Enabled = true;
			ContainerElementosAsociados.Enabled = true;
			ContainerJerarquia.Enabled = true;
			ContainerContactos.Enabled = true;
            ContainerListaDePrecios.Enabled = true;

			tbbVolver.Visible = false;
		}

		private void btnMasDetalles_Click_1(object sender, System.EventArgs e)
		{
		
		}
		
		private void hierarchicalSearchControl1_OnSelected(object sender, EventArgs e)
		{			
			_uiController.ByJerarquia1 = hierarchicalSearchControl1.NodeChecked1;
			_uiController.Jerarquia1 = hierarchicalSearchControl1.ItemsJerarquia1;
			_uiController.ByJerarquia2 = hierarchicalSearchControl1.NodeChecked2;
			_uiController.Jerarquia2 = hierarchicalSearchControl1.ItemsJerarquia2;
			_uiController.ByJerarquia3 = hierarchicalSearchControl1.NodeChecked3;
			_uiController.Jerarquia3 = hierarchicalSearchControl1.ItemsJerarquia3;
			_uiController.ByJerarquia4 = hierarchicalSearchControl1.NodeChecked4;
			_uiController.Jerarquia4 = hierarchicalSearchControl1.ItemsJerarquia4;
			_uiController.ByJerarquia5 = hierarchicalSearchControl1.NodeChecked5;
			_uiController.Jerarquia5 = hierarchicalSearchControl1.ItemsJerarquia5;
			_uiController.ByJerarquia6 = hierarchicalSearchControl1.NodeChecked6;
			_uiController.Jerarquia6 = hierarchicalSearchControl1.ItemsJerarquia6;
			_uiController.ByJerarquia7 = hierarchicalSearchControl1.NodeChecked7;
			_uiController.Jerarquia7 = hierarchicalSearchControl1.ItemsJerarquia7;
			_uiController.ByJerarquia8 = hierarchicalSearchControl1.NodeChecked8;
			_uiController.Jerarquia8 = hierarchicalSearchControl1.ItemsJerarquia8;
		}

		private void btnAgregarContacto_Click(object sender, System.EventArgs e)
		{
			gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
			gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
			panelABMContactos.Visible = false;
			_uiController.AddContacto();
			gridContactos.SetDataBinding(_uiController.DataContactos, null);
			ConfigureGridContactos();
			gridContactos.Row = 0;
			gridContactos.Select();
			gridContactos.Focus();
		}

		private void btnEditarContacto_Click(object sender, System.EventArgs e)
		{
			if(gridContactos.SelectedItems.Count >0)
			{
				gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
				gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
				gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;	
				panelABMContactos.Visible = false;
			}
		}

		private void btnBuscarContacto_Click(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			mzPersonasSearchForm form = new mzPersonasSearchForm();
			form.OnRowChanged += new mz.erp.ui.forms.mzPersonasSearchForm.RowChanged(EventoAgregarPersonaExistente);
			form.ShowFormNW();
			this.Cursor = Cursors.Default;
			panelABMContactos.Visible = true;
		}

		private void EventoAgregarPersonaExistente( object sender, EventArgs args )
		{			
			if(sender == null)
			{
				gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
				gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
				gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
				panelABMContactos.Visible = false;
				_uiController.AddContacto();
				gridContactos.SetDataBinding(_uiController.DataContactos, null);
				ConfigureGridContactos();
				gridContactos.Row = 0;
				gridContactos.Select();
				gridContactos.Focus();
			}
			else
			{
				System.Data.DataRowView dataRowSelected = (System.Data.DataRowView) sender;
				string idPersona = Convert.ToString(dataRowSelected["IdPersona"]);
				if(_uiController.ExistContacto(idPersona))
					MessageBox.Show("La persona seleccionada ya es un contacto del cliente");
				else
				{
					gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
					gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True;
					gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
					panelABMContactos.Visible = true;
					string nombre = Convert.ToString(dataRowSelected["Nombre"]);
					string telefonos = Convert.ToString(dataRowSelected["Telefonos"]);
					string email = Convert.ToString(dataRowSelected["Email"]);
					string comentarios = Convert.ToString(dataRowSelected["Comentarios"]);
					string instantMesseger = Convert.ToString(dataRowSelected["InstantMesseger"]);
					bool activo = Convert.ToBoolean(dataRowSelected["Activo"]);
					_uiController.AddContacto(idPersona, nombre, telefonos, email, comentarios, instantMesseger, activo);
					gridContactos.SetDataBinding(_uiController.DataContactos, null);
					ConfigureGridContactos();
					gridContactos.Row = 0;
					gridContactos.Select();
					gridContactos.Focus();
					gridContactos.UpdateData();
				}
			}
		}

		private void btnEliminarContacto_Click(object sender, System.EventArgs e)
		{
			gridContactos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;	
			if(gridContactos.SelectedItems.Count == 1)
			{
				if(MessageBox.Show("Está seguro que desea Eliminar el contacto seleccionado","Advertencia",System.Windows.Forms.MessageBoxButtons.OKCancel,System.Windows.Forms.MessageBoxIcon.Question).Equals(DialogResult.OK))
				{
					int index = gridContactos.SelectedItems[0].Position;									
					_uiController.DeleteContacto(index);
					gridContactos.Delete();	
				}
			}
			gridContactos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;	
			panelABMContactos.Visible = true;		
		}

		private void btnMasDetallesContacto_Click(object sender, System.EventArgs e)
		{
			if(gridContactos.SelectedItems.Count >0)
			{
				int index = gridContactos.SelectedItems[0].Position;	
				if(_uiController.MustShowPersona(index))
				{
					FrmAbmPersonas frmAbmPersonas = new FrmAbmPersonas();
					frmAbmPersonas.OnRowChanged += new mz.erp.ui.forms.FrmAbmPersonas.RowChanged(frmAbmPersonas_OnRowChanged);
					string idPersona = Convert.ToString(gridContactos.SelectedItems[0].GetRow().Cells["IdPersona"].Value);
					frmAbmPersonas.ShowForm(idPersona, "ABM de Personas");
				}
			}
		}

		private void mzCmbTiposDeIVA_ValueChanged(object sender, EventArgs e)
		{
			string valor = Convert.ToString(mzCmbTiposDeIVA.Value);
			if(valor.Equals("CF"))
				uneAlicuotaPercepcionIngresosBrutos.Enabled = false;
			else
				uneAlicuotaPercepcionIngresosBrutos.Enabled = true;
		}

		private void mzCEResponsableIngreso_Change(object sender, EventArgs e)
		{
			if (_uiController.AskForPasswordResponsableIngreso) 
			{
				ShowPassword();				
			}	
		}

		private void ShowPassword() 
		{			
			string IdPersona = Convert.ToString(mzCEResponsableIngreso.Value);			
			if (IdPersona != _uiController.UltimoResponsableClaveCorrecta)
			{
				string password = InputBox.ShowInputBoxPassword("Ingrese la contraseña:","Cambio de responsable asociado al nuevo ingreso");								
				bool ClaveCorrecta = false;
				if (IdPersona != null && !IdPersona.Equals(string.Empty) )
				{
					ClaveCorrecta = businessrules.Security.LogInXPersona(IdPersona, password);					
					if (!ClaveCorrecta /*&& password != ""*/)
						MessageBox.Show("¡Clave incorrecta!", "Cambio de responsable de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					else
						_uiController.UltimoResponsableClaveCorrecta = IdPersona;
				}
				
				if (!ClaveCorrecta)
				{
					this.mzCEResponsableIngreso.Value = string.Empty;
					_uiController.IdResponsableIngreso = string.Empty;
				}
			}				
		}

	}
}


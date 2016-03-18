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
	/// Descripción breve de FrmAbmEntidadesW.
	/// </summary>
	public class FrmAbmEntidadesW : System.Windows.Forms.Form, ITaskForm 
	{
		protected System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		protected System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		protected System.Windows.Forms.ToolBarButton toolBarButton5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl datosGeneralesContainer;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ImageList imglStandar;
		private mz.erp.ui.controls.mzComboEditor mzCEFamiliaFormaDePago;
		private mz.erp.ui.controls.mzComboEditor mzCEComprobanteTesoreria;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.ComponentModel.IContainer components;

		private System.Windows.Forms.RadioButton rbRetencion;
		private System.Windows.Forms.RadioButton rbTarjeta;
		private System.Windows.Forms.RadioButton rbNinguno;
		private System.Windows.Forms.RadioButton rbCheque;

		private mz.erp.ui.controllers.ABMEntidadesController _uiController;
		private string _jerarquiaActual=string.Empty;
		private string _familia=string.Empty;
		private bool modificando = false;
		private System.Windows.Forms.CheckBox chActivo;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label label3;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbEntidad;

		public FrmAbmEntidadesW(mz.erp.ui.controllers.ABMEntidadesController uiController)
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
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			rbTarjeta.CheckedChanged +=new EventHandler(rbTarjeta_CheckedChanged);
			rbCheque.CheckedChanged +=new EventHandler(rbCheque_CheckedChanged);
			rbRetencion.CheckedChanged +=new EventHandler(rbRetencion_CheckedChanged);
			rbNinguno.CheckedChanged +=new EventHandler(rbNinguno_CheckedChanged);
			mzCmbEntidad.ValueChanged += new EventHandler(this.Entidad_Change);
			mzCEFamiliaFormaDePago.ValueChanged += new EventHandler(_uiController_JerarquiaChanged);
			mzCEComprobanteTesoreria.ValueChanged += new EventHandler(_uiController_Jerarquia1Changed);
			KeyDownManager KeyDown = new KeyDownManager(this);	
		}

		private void InitializeData()
		{

		}

		protected void InitializeMembers()
		{
			txtCodigo.MaxLength = 20;
			txtDescripcion.MaxLength = 50;

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
					if (this.ultraExplorerBar1.Groups.Exists(grupo))
					{
						if (this.ultraExplorerBar1.Groups[grupo].Container != null)
						{
							this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;}
						this.ultraExplorerBar1.Groups[grupo].Enabled = true;}
				}
			}

			mzCEFamiliaFormaDePago.FillFromDataSource( _uiController.GetTableFamiliasTDCompTesoreria(), "Jerarquia", "Descripcion", 100, "Descripcion");
			mzCEComprobanteTesoreria.Enabled=false;

			mzCmbEntidad.SearchObject = typeof(mz.erp.ui.forms.classes.tfi_Entidades);

		}

		private void InitDataBindings()
		{					
			BindingController.Bind(mzCEFamiliaFormaDePago, "Value", _uiController, "Jerarquia");
			BindingController.Bind(mzCEComprobanteTesoreria, "Value", _uiController, "Jerarquia1");
		}

		//se ejecuta al levantar la ventana
		protected void FillControls()
		{		
			chActivo.Checked = _uiController.Activo;
			txtDescripcion.Text = _uiController.Descripcion;
			txtCodigo.Text = _uiController.Codigo;

			if (_uiController.IdEntidad == string.Empty)
			{
				_uiController.seleccionarFamilia();
			}
			else {
				mzCEFamiliaFormaDePago.Enabled = false;
				mzCEComprobanteTesoreria.Enabled = false;
			}
			mzCEFamiliaFormaDePago.Value = _uiController.Jerarquia;
			mzCEComprobanteTesoreria.FillFromDataSource( _uiController.ListaSegundoNivel, "Jerarquia", "Descripcion", 100, "Descripcion");
			
			mzCEComprobanteTesoreria.Value = _uiController.Jerarquia1;
			this.ChequearFamilia();
			
		}

		//se ejecuta al intentar guardar
		protected void DumpControls()
		{
			_uiController.Descripcion = txtDescripcion.Text;
			_uiController.Codigo = txtCodigo.Text;
			_uiController.Activo = chActivo.Checked;
		}

		private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
		{
			if (rbTarjeta.Checked)
			{
				_uiController.Familia = "Tarjeta";
			}
		}

		private void rbCheque_CheckedChanged(object sender, EventArgs e)
		{
			if (rbCheque.Checked)
			{
				_uiController.Familia = "Cheque";
			}

		}

		private void rbRetencion_CheckedChanged(object sender, EventArgs e)
		{
			if (rbRetencion.Checked)
			{
				_uiController.Familia = "Retención";
			}
		}

		private void rbNinguno_CheckedChanged(object sender, EventArgs e)
		{
			if (rbRetencion.Checked)
			{
				_uiController.Familia = "";
			}
		}


		private void _uiController_JerarquiaChanged(object sender, EventArgs e)
		{
			string jerarquia = Convert.ToString(mzCEFamiliaFormaDePago.Value);
			_uiController.Jerarquia = jerarquia;
			if (!(_uiController.Jerarquia==null) && !_uiController.Jerarquia.Equals(string.Empty))
			{
				this.ChequearFamilia();

				if (_uiController.TieneHijos)
				{
					if (!modificando)
						mzCEComprobanteTesoreria.Enabled=true;
					mzCEComprobanteTesoreria.FillFromDataSource( _uiController.ListaSegundoNivel, "Jerarquia", "Descripcion", 100, "Descripcion");
					_uiController.SeleccionarFamiliaDeNivel2();
				}
				else
				{//Cargo los hijos por nivel uno
					mzCEComprobanteTesoreria.Enabled=false;
					_uiController.ActualizarJerarquiaUno();
					mzCEComprobanteTesoreria.FillFromDataSource( _uiController.ListaSegundoNivel, "Jerarquia", "Descripcion", 100, "Descripcion");		
				}
			}
		}

		 private void _uiController_Jerarquia1Changed(object sender, EventArgs e)
		{
			if (!(_uiController.Jerarquia1==null) && !_uiController.Jerarquia1.Equals(string.Empty))
			{
				_jerarquiaActual=_uiController.Jerarquia1;
			}
		}

		private void ChequearFamilia()
		{
			Hashtable flias=_uiController.FamiliasPorClaveLarga;
			if (_uiController.Jerarquia != null)
			{
				this._familia=Convert.ToString(flias[_uiController.Jerarquia]);

				_jerarquiaActual=_uiController.Jerarquia;
				if (_familia.Equals("Cheques"))
					rbCheque.Checked=true;
				if (_familia.Equals("Retenciones"))
					rbRetencion.Checked=true;
				if (_familia.Equals("Tarjetas"))
					rbTarjeta.Checked=true;
				if (_familia.Equals("Efectivo"))
					rbNinguno.Checked=true;		
			}
		}

		private void Entidad_Change(object sender, EventArgs e)
		{
			string codigo = (string) mzCmbEntidad.DataValue;
			_uiController.Codigo = codigo;
			_uiController.GetEntidad(codigo);
			modificando = true;
			mzCEComprobanteTesoreria.Enabled = false;
			mzCEFamiliaFormaDePago.Enabled = false;
			FillControls();
		}

		private void Componentes_Changes( object sender, System.EventArgs e )
		{				
		}

		private void RefreshData()
		{
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
			KeyPreview = true;
			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessName(), _uiController.GetTaskName());
		}

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmEntidadesW));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label3 = new System.Windows.Forms.Label();
			this.mzCmbEntidad = new mz.erp.ui.controls.mzComboSearchEditor();
			this.datosGeneralesContainer = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.chActivo = new System.Windows.Forms.CheckBox();
			this.rbRetencion = new System.Windows.Forms.RadioButton();
			this.rbTarjeta = new System.Windows.Forms.RadioButton();
			this.rbNinguno = new System.Windows.Forms.RadioButton();
			this.rbCheque = new System.Windows.Forms.RadioButton();
			this.mzCEFamiliaFormaDePago = new mz.erp.ui.controls.mzComboEditor();
			this.mzCEComprobanteTesoreria = new mz.erp.ui.controls.mzComboEditor();
			this.label21 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.datosGeneralesContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEFamiliaFormaDePago)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, -5);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(862, 39);
			this.ultraExplorerBarContainerControl4.TabIndex = 5;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(862, 32);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbEntidad);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 28);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(862, 62);
			this.ultraExplorerBarContainerControl1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(56, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 36;
			this.label3.Text = "Entidades";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// mzCmbEntidad
			// 
			this.mzCmbEntidad.DataValue = "";
			this.mzCmbEntidad.EditObject = null;
			this.mzCmbEntidad.FastSearch = false;
			this.mzCmbEntidad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbEntidad.HierarchicalSearch = false;
			this.mzCmbEntidad.Location = new System.Drawing.Point(208, 24);
			this.mzCmbEntidad.Name = "mzCmbEntidad";
			this.mzCmbEntidad.ReadOnly = false;
			this.mzCmbEntidad.SearchObject = null;
			this.mzCmbEntidad.SearchObjectListener = null;
			this.mzCmbEntidad.Size = new System.Drawing.Size(496, 22);
			this.mzCmbEntidad.TabIndex = 1;
			// 
			// datosGeneralesContainer
			// 
			this.datosGeneralesContainer.Controls.Add(this.chActivo);
			this.datosGeneralesContainer.Controls.Add(this.rbRetencion);
			this.datosGeneralesContainer.Controls.Add(this.rbTarjeta);
			this.datosGeneralesContainer.Controls.Add(this.rbNinguno);
			this.datosGeneralesContainer.Controls.Add(this.rbCheque);
			this.datosGeneralesContainer.Controls.Add(this.mzCEFamiliaFormaDePago);
			this.datosGeneralesContainer.Controls.Add(this.mzCEComprobanteTesoreria);
			this.datosGeneralesContainer.Controls.Add(this.label21);
			this.datosGeneralesContainer.Controls.Add(this.label2);
			this.datosGeneralesContainer.Controls.Add(this.label1);
			this.datosGeneralesContainer.Controls.Add(this.txtDescripcion);
			this.datosGeneralesContainer.Controls.Add(this.txtCodigo);
			this.datosGeneralesContainer.Location = new System.Drawing.Point(28, 149);
			this.datosGeneralesContainer.Name = "datosGeneralesContainer";
			this.datosGeneralesContainer.Size = new System.Drawing.Size(862, 140);
			this.datosGeneralesContainer.TabIndex = 0;
			// 
			// chActivo
			// 
			this.chActivo.BackColor = System.Drawing.Color.Transparent;
			this.chActivo.Checked = true;
			this.chActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chActivo.Location = new System.Drawing.Point(32, 120);
			this.chActivo.Name = "chActivo";
			this.chActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chActivo.Size = new System.Drawing.Size(158, 16);
			this.chActivo.TabIndex = 8;
			this.chActivo.Text = "Activo";
			this.chActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rbRetencion
			// 
			this.rbRetencion.BackColor = System.Drawing.Color.Transparent;
			this.rbRetencion.Enabled = false;
			this.rbRetencion.Location = new System.Drawing.Point(456, 72);
			this.rbRetencion.Name = "rbRetencion";
			this.rbRetencion.Size = new System.Drawing.Size(104, 16);
			this.rbRetencion.TabIndex = 5;
			this.rbRetencion.Text = "Retención";
			// 
			// rbTarjeta
			// 
			this.rbTarjeta.AccessibleDescription = "";
			this.rbTarjeta.BackColor = System.Drawing.Color.Transparent;
			this.rbTarjeta.Enabled = false;
			this.rbTarjeta.Location = new System.Drawing.Point(232, 72);
			this.rbTarjeta.Name = "rbTarjeta";
			this.rbTarjeta.Size = new System.Drawing.Size(104, 16);
			this.rbTarjeta.TabIndex = 3;
			this.rbTarjeta.Text = "Tarjeta";
			// 
			// rbNinguno
			// 
			this.rbNinguno.BackColor = System.Drawing.Color.Transparent;
			this.rbNinguno.Enabled = false;
			this.rbNinguno.Location = new System.Drawing.Point(352, 72);
			this.rbNinguno.Name = "rbNinguno";
			this.rbNinguno.Size = new System.Drawing.Size(104, 16);
			this.rbNinguno.TabIndex = 4;
			this.rbNinguno.Text = "Efectivo";
			// 
			// rbCheque
			// 
			this.rbCheque.BackColor = System.Drawing.Color.Transparent;
			this.rbCheque.Enabled = false;
			this.rbCheque.Location = new System.Drawing.Point(96, 72);
			this.rbCheque.Name = "rbCheque";
			this.rbCheque.Size = new System.Drawing.Size(104, 16);
			this.rbCheque.TabIndex = 2;
			this.rbCheque.Text = "Cheque";
			// 
			// mzCEFamiliaFormaDePago
			// 
			this.mzCEFamiliaFormaDePago.AutoComplete = true;
			this.mzCEFamiliaFormaDePago.DataSource = null;
			this.mzCEFamiliaFormaDePago.DisplayMember = "";
			this.mzCEFamiliaFormaDePago.DisplayMemberCaption = "";
			this.mzCEFamiliaFormaDePago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEFamiliaFormaDePago.Location = new System.Drawing.Point(96, 96);
			this.mzCEFamiliaFormaDePago.MaxItemsDisplay = 7;
			this.mzCEFamiliaFormaDePago.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEFamiliaFormaDePago.Name = "mzCEFamiliaFormaDePago";
			this.mzCEFamiliaFormaDePago.Size = new System.Drawing.Size(197, 21);
			this.mzCEFamiliaFormaDePago.SorterMember = "";
			this.mzCEFamiliaFormaDePago.TabIndex = 6;
			this.mzCEFamiliaFormaDePago.ValueMember = "";
			this.mzCEFamiliaFormaDePago.ValueMemberCaption = "";
			// 
			// mzCEComprobanteTesoreria
			// 
			this.mzCEComprobanteTesoreria.AutoComplete = true;
			this.mzCEComprobanteTesoreria.DataSource = null;
			this.mzCEComprobanteTesoreria.DisplayMember = "";
			this.mzCEComprobanteTesoreria.DisplayMemberCaption = "";
			this.mzCEComprobanteTesoreria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEComprobanteTesoreria.Location = new System.Drawing.Point(328, 96);
			this.mzCEComprobanteTesoreria.MaxItemsDisplay = 7;
			this.mzCEComprobanteTesoreria.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEComprobanteTesoreria.Name = "mzCEComprobanteTesoreria";
			this.mzCEComprobanteTesoreria.Size = new System.Drawing.Size(216, 21);
			this.mzCEComprobanteTesoreria.SorterMember = "";
			this.mzCEComprobanteTesoreria.TabIndex = 7;
			this.mzCEComprobanteTesoreria.ValueMember = "";
			this.mzCEComprobanteTesoreria.ValueMemberCaption = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(32, 96);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(100, 16);
			this.label21.TabIndex = 136;
			this.label21.Text = "Es del tipo";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(32, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 135;
			this.label2.Text = "Descripción";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(32, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 134;
			this.label1.Text = "Código";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(96, 40);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(224, 20);
			this.txtDescripcion.TabIndex = 1;
			this.txtDescripcion.Text = "";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(96, 8);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(224, 20);
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.Text = "";
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
			this.toolBar1.Size = new System.Drawing.Size(928, 28);
			this.toolBar1.TabIndex = 22;
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
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.datosGeneralesContainer);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl4);
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
			ultraExplorerBarGroup2.Key = "Entidad";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 62;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Entidad";
			ultraExplorerBarGroup2.Visible = false;
			ultraExplorerBarGroup3.Container = this.datosGeneralesContainer;
			ultraExplorerBarGroup3.Enabled = false;
			ultraExplorerBarGroup3.Key = "Datos Generales";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 140;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Datos Generales";
			ultraExplorerBarGroup3.Visible = false;
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(928, 314);
			this.ultraExplorerBar1.TabIndex = 23;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmAbmEntidadesW
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(928, 342);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBar1);
			this.Name = "FrmAbmEntidadesW";
			this.Text = "FrmAbmEntidadesW";
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.datosGeneralesContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEFamiliaFormaDePago)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

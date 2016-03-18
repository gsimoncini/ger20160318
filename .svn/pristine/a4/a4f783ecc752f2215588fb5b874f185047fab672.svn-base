using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmCuentasObservacionesEstados.
	/// </summary>
	public class FrmAbmCuentasObservacionesEstados : System.Windows.Forms.Form,ITaskForm
	{	
		#region Variables Privadas
		//Variables de la vista del form, las maneja el windforms
		private System.Windows.Forms.TextBox estados;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbSrchEdtEstados;
		private System.Windows.Forms.Label labelSearch;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxActivo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox descripcion;
		//Variables mias

		private ABMCuentasObservacionesEstadosControllers _uiController;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
		private System.Windows.Forms.Label labelLeyenda;
		string modo = "new";
		
		#endregion
		
		public FrmAbmCuentasObservacionesEstados()
		{
			// Se generasolo el initializeComponent
			InitializeComponent();
			//controlador asociado al form q se comunicara con tarea en el workflow
			_uiController = new ABMCuentasObservacionesEstadosControllers();
			Build_UI();
			
		}

		/*Constructor que usa el workflow*/
		public FrmAbmCuentasObservacionesEstados(ABMCuentasObservacionesEstadosControllers controllers)
		{
			// Se generasolo el initializeComponent
			InitializeComponent();
			//controlador asociado al form q se comunicara con tarea en el workflow
			_uiController = controllers;
			
			
		}
		
		protected void Build_UI()
		{	//Configura los controlles, visibilidad, etc, etc
			ConfigureInterface();	
			//Ejemplo le carga datos a un combo
			InitializeData();
			
			//Asociar eventos a la interface
			//Cuando hace click en la  barra de arriba, ejemplo guardar...
			InitEventHandlers();
			
			//Realizar binding entre la interface y el controlador
			//implementacion no lleva
			//InitDataBindings();		
			//Para propiedades estaticas, datos q no dependen ni modifican a nadie.
			//carga la info q viene del controller
			FillControls();
		}
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
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmCuentasObservacionesEstados));
			this.ultraExplorerBarContainerControl3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelLeyenda = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.mzCmbSrchEdtEstados = new mz.erp.ui.controls.mzComboSearchEditor();
			this.labelSearch = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxActivo = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.descripcion = new System.Windows.Forms.TextBox();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBarContainerControl3.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl3
			// 
			this.ultraExplorerBarContainerControl3.Controls.Add(this.labelLeyenda);
			this.ultraExplorerBarContainerControl3.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl3.Name = "ultraExplorerBarContainerControl3";
			this.ultraExplorerBarContainerControl3.Size = new System.Drawing.Size(901, 24);
			this.ultraExplorerBarContainerControl3.TabIndex = 2;
			// 
			// labelLeyenda
			// 
			this.labelLeyenda.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelLeyenda.Location = new System.Drawing.Point(0, 0);
			this.labelLeyenda.Name = "labelLeyenda";
			this.labelLeyenda.Size = new System.Drawing.Size(958, 24);
			this.labelLeyenda.TabIndex = 0;
			this.labelLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCmbSrchEdtEstados);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelSearch);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 107);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(901, 50);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			this.ultraExplorerBarContainerControl1.TabStop = true;
			// 
			// mzCmbSrchEdtEstados
			// 
			this.mzCmbSrchEdtEstados.DataValue = "";
			this.mzCmbSrchEdtEstados.EditObject = null;
			this.mzCmbSrchEdtEstados.FastSearch = false;
			this.mzCmbSrchEdtEstados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbSrchEdtEstados.HierarchicalSearch = false;
			this.mzCmbSrchEdtEstados.Location = new System.Drawing.Point(64, 8);
			this.mzCmbSrchEdtEstados.Name = "mzCmbSrchEdtEstados";
			this.mzCmbSrchEdtEstados.ReadOnly = false;
			this.mzCmbSrchEdtEstados.SearchObject = null;
			this.mzCmbSrchEdtEstados.SearchObjectListener = null;
			this.mzCmbSrchEdtEstados.Size = new System.Drawing.Size(544, 22);
			this.mzCmbSrchEdtEstados.TabIndex = 5;
			// 
			// labelSearch
			// 
			this.labelSearch.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.labelSearch.Location = new System.Drawing.Point(8, 8);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.TabIndex = 2;
			this.labelSearch.Text = "Estado:";
			this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.checkBoxActivo);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.descripcion);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 216);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(901, 50);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.Location = new System.Drawing.Point(312, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Activo:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxActivo
			// 
			this.checkBoxActivo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.checkBoxActivo.Checked = true;
			this.checkBoxActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxActivo.Location = new System.Drawing.Point(360, 16);
			this.checkBoxActivo.Name = "checkBoxActivo";
			this.checkBoxActivo.Size = new System.Drawing.Size(16, 24);
			this.checkBoxActivo.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 24);
			this.label1.TabIndex = 9;
			this.label1.Text = "Estado:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// descripcion
			// 
			this.descripcion.Location = new System.Drawing.Point(64, 20);
			this.descripcion.Name = "descripcion";
			this.descripcion.TabIndex = 8;
			this.descripcion.Text = "";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl3);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl3;
			ultraExplorerBarGroup1.Key = "Leyenda";
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Leyenda";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Key = "DatosGenerales";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 50;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Datos Generales";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Key = "DatosdelEstado";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 50;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Datos del Estado";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 32);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(950, 496);
			this.ultraExplorerBar1.TabIndex = 18;
			this.ultraExplorerBar1.TabStop = false;
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
			this.toolBarStandar.ImageList = this.imageList1;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(976, 28);
			this.toolBarStandar.TabIndex = 19;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 9;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 8;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 7;
			this.tbbCancelar.Text = "Cancelar";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// FrmAbmCuentasObservacionesEstados
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(976, 398);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Name = "FrmAbmCuentasObservacionesEstados";
			this.Load += new System.EventHandler(this.FrmAbmCuentasObservacionesEstados_Load);
			this.ultraExplorerBarContainerControl3.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		//carga los datos que la tarea tendra q procesar
		//Este metodo se llama cuando desde la interface se presiona guardar
		private void dumpControls()
		{	//Faltaria el id cuando es busqueda
			//Util.MoveFocus(this.ultraExplorerBarContainerControl1);	
			if(_uiController.GetProcessManager().GetProcessName().Equals("ProcesoModificarCuentaObservacionesEstados"))
                _uiController.IdCuentaObservacionEstado=(String)this.mzCmbSrchEdtEstados.DataValue;	
			else if(_uiController.GetProcessManager().GetProcessName().Equals("ProcesoModificarProveedorObservacionesEstados"))
				_uiController.IdProveedorObservacionEstado=(String)this.mzCmbSrchEdtEstados.DataValue;	
			_uiController.Descripcion= descripcion.Text;
			_uiController.Activo = checkBoxActivo.Checked;
			_uiController.Execute();
			//_uiController.Numero = componenteDocumentos1.Numero;
			//Faltaria el id cuando es busqueda
		}
		//Toma los datos que le manda la tarea y los carga en los controles del form
		//Este metodo se llama cuando se construye la interface
		private void FillControls()
		{	//Faltaria el id cuando es busqueda
			//(String)this.mzCmbSrchEdtEstados.DataValue=_uiController.IdCuentaObservacionEstado;
			descripcion.Text=_uiController.Descripcion;
			checkBoxActivo.Checked=_uiController.Activo;
			//_uiController.Numero = componenteDocumentos1.Numero;
			//Faltaria el id cuando es busqueda
		}
		#region Miembros de ITaskForm

		public void Execute()
		{
			//DumpControls()
			//pasa al controler el valor del text box
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
			this.dumpControls();
		}

		#endregion

		private void ConfigureInterface()
		{/*Le pide al controller los controlles q tiene q poner deshabilitado*/
			
			ArrayList cont = mz.erp.systemframework.Util.Parse(_uiController.ContenedoresVisibles(), ",");
			foreach(string grupo in cont)
			{ 
				if (grupo != string.Empty){
				  this.ultraExplorerBar1.Groups[grupo].Enabled = false;
				  this.mzCmbSrchEdtEstados.Enabled=false;
				}
			}
			//Toma los valores definidos en la bd
			this.tbbAnterior.Text=_uiController.TextoBotonAnterior;
			this.tbbAnterior.Enabled=false;
			this.tbbSiguiente.Text=_uiController.TextoBotonSiguiente;
			this.labelLeyenda.Text=_uiController.Leyenda;
			this.Text=_uiController.Leyenda;
			KeyPreview = true;
		}

		private void InitializeData()
		{
			if(_uiController.GetProcessManager().GetProcessName().Equals("ProcesoModificarCuentaObservacionesEstados"))
				this.mzCmbSrchEdtEstados.SearchObject = typeof( mz.erp.ui.controllers.tsa_CuentasObservacionesEstados);
			else if(_uiController.GetProcessManager().GetProcessName().Equals("ProcesoModificarProveedorObservacionesEstados"))
				this.mzCmbSrchEdtEstados.SearchObject = typeof( mz.erp.ui.controllers.tpu_ProveedoresObservacionesEstados);
		}
	
		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
			//Detecta este evento y llama a mzCmbSrchEdtEstados_ValueChanged()
			this.mzCmbSrchEdtEstados.ValueChanged+=new EventHandler(mzCmbSrchEdtEstados_ValueChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}
		//Cuando se busca y se selecciona un item, debo actualizar el resto de los controles en interface
		private void mzCmbSrchEdtEstados_ValueChanged(object sender, EventArgs e)
		{
			if(mzCmbSrchEdtEstados.SelectedItems.Count > 0){
				_uiController.UpdateElementos(mzCmbSrchEdtEstados.SelectedItems);
				this.FillControls();}
			//mzCmbSrchEdtEstados.ValueChanged-=new EventHandler(mzCmbSrchEdtEstados_ValueChanged);
			//mzCmbSrchEdtEstados.DataValue = null;
			//mzCmbSrchEdtEstados.ValueChanged+=new EventHandler(mzCmbSrchEdtEstados_ValueChanged);
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void FrmAbmCuentasObservacionesEstados_Load(object sender, System.EventArgs e)
		{
		
		}

		
		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{//Reconoce los botones por el orden en la barra, ver en la barra, propiedades buttons, es el orden q se ve a la izq
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					//Presiono el boton de anterior
					_uiController.Previous();
					break;
				case 2:
					//Presiono el boton de siguiente o guardar
					//mz.erp.ui.utility.Util.MoveFocus(ultraExplorerBarContainerControl1);
					this.dumpControls();
					break;
				case 4:
					//Presiono el boton de Cancelar
					CloseForm();
					break;
			}		
		}

	

	}

	
}


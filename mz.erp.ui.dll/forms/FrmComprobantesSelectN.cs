using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controls;
using mz.erp.commontypes;

using System.Reflection;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;




namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmComprobantesSelectN.
	/// </summary>
	public class FrmComprobantesSelectN : System.Windows.Forms.Form , ITaskForm
	{
		private System.Windows.Forms.ToolBar toolBarStandar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		private System.Windows.Forms.ToolBarButton tbbCancelar;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;		
		private System.ComponentModel.IContainer components;
		
		public FrmComprobantesSelectN()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		public FrmComprobantesSelectN(ComprobantesSelectNController controller)
		{
			InitializeComponent();
			this._uiController = controller;
			Init();
		}

		private Form _formOwner;
		private ArrayList _idComprobantes;
		private ComprobantesSelectNController  _uiController;

		[FormOwnerPropertyAttributte]
		public Form FormOwner
		{
			get {return _formOwner;}
			set {_formOwner = value;}
		}

		#region Custom Members
		public FrmComprobantesSelectN(ArrayList IdComprobantes)
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			//Init(IdComprobantes);			

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		private void Init()
		{
			BuildUI();
			InitDataBindings();
			InitEvents();

		}

		private void BuildUI()
		{	
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;
			//gridEX1.LayoutData = _uiController.Layout;
			gridManagerView1.Visible = false;
			gridManagerView1.Configure(_uiController.GetProcessName(), _uiController.GetTaskName(), "FrmComprobantesSelectN", gridEX1, "FrmComprobantesSelectN");
			Janus.Windows.GridEX.GridEXColumn column = gridEX1.RootTable.Columns["Visible"];
			Janus.Windows.GridEX.ConditionOperator condicion = Janus.Windows.GridEX.ConditionOperator.Equal;
			Janus.Windows.GridEX.GridEXFilterCondition filtro =new Janus.Windows.GridEX.GridEXFilterCondition(column, condicion, true);
			gridEX1.RootTable.FilterCondition = filtro;
			KeyPreview = true;		
		}

		private void InitDataBindings()
		{
			gridEX1.SetDataBinding(null, null);	
			gridEX1.SetDataBinding(_uiController.Items, null);	
		}

		private void InitEvents()
		{
			_uiController.OnModelChanged +=new EventHandler(_uiController_OnModelChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);
		}

	
		private RelacionesComprobanteOrigenDestino items;
		/*
		[IsNextStepMember]
		public void Init(ArrayList IdComprobantes)
		{			
			items = new RelacionesComprobanteOrigenDestino( IdComprobantes);
			_idComprobantes = IdComprobantes;
			gridEX1.LayoutData = mz.erp.ui.forms.classes.ComprobantesDeVenta.GetLayoutRelacionOrigenDestino( new string[] {"IdTipoDeComprobante", "Numero", "OrdinalOrigen", "CantidadOrigen","CantidadDestino","Descripcion", "Precio"});
			gridEX1.DataSource = items;	
			base.MdiParent = mz.erp.ui.utility.Environment.MainForm;
			base.Show();
			
		}
		*/
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
				_uiController.OnModelChanged -=new EventHandler(_uiController_OnModelChanged);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmComprobantesSelectN));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(888, 385);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
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
			this.gridEX1.Size = new System.Drawing.Size(888, 385);
			this.gridEX1.TabIndex = 15;
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
			this.toolBarStandar.Size = new System.Drawing.Size(888, 28);
			this.toolBarStandar.TabIndex = 17;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 385;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Detalle de productos";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(888, 385);
			this.ultraExplorerBar1.TabIndex = 18;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(12, 194);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(864, 24);
			this.gridManagerView1.TabIndex = 121;
			// 
			// FrmComprobantesSelectN
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(888, 413);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Controls.Add(this.gridManagerView1);
			this.KeyPreview = true;
			this.Name = "FrmComprobantesSelectN";
			this.Text = "Selección de items de comprobantes";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmComprobantesSelectN_KeyDown);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
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
					_uiController.Previous();
					break;
				case 2:			
					Util.MoveFocus(ultraExplorerBarContainerControl2);
					Step();
					break;
				case 4:
					CloseForm();
					break;
			}				
		}
		private void Step()
		{
			bool _continuar = false;
			gridEX1.UpdateData(); 
			if(_uiController == null)
			{
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
					if (momentoasociado == "Preparar") 
					{
						FrmEntregas frm = new FrmEntregas();
						//EventInfo ei =frmComprobantes.GetType().GetEvent("OnCommitComprobante");				
						//Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, this._formOwner, "processEventChange" );
						//ei.AddEventHandler(frmComprobantes, del1);
						frm.Step( momentoasociado, IdTipoDestino, items );

						//frm.MdiParent = base.MdiParent;
						//frm.Show();
					}
					else 
					{
						FrmComprobantes frmComprobantes = new FrmComprobantes();
						EventInfo ei =frmComprobantes.GetType().GetEvent("OnCommitComprobante");
				
						Delegate del1 = Delegate.CreateDelegate( ei.EventHandlerType, this._formOwner, "processEventChange" );
						ei.AddEventHandler(frmComprobantes, del1);
						frmComprobantes.Step( momentoasociado, IdTipoDestino, items );
					}			
					this.Close();				
				}
			}
			else
			{
				this._uiController.Execute();
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

		private void frmComprobantes_OnCommitComprobante(object sender, EventArgs e)
		{

		}
		#region Miembros de ITaskForm

		public void Execute()
		{
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
			Util.MoveFocus(ultraExplorerBarContainerControl2);
			Step();
		}

		#endregion

		private void _uiController_OnModelChanged(object sender, EventArgs e)
		{
			gridEX1.SetDataBinding(null, null);
			gridEX1.SetDataBinding(_uiController.Items, null);	
		}
	}
}

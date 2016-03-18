using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmAbmTiposDeComprobantes.
	/// </summary>
	public class FrmAbmTiposDeComprobantes : System.Windows.Forms.Form, ITaskForm 
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ImageList imglStandar;
		protected System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		protected System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		protected System.Windows.Forms.ToolBarButton toolBarButton5;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl datosGeneralesContainer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.CheckBox chActivo;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl4;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.CheckBox chRequiereCondicionDeVenta;
		private System.Windows.Forms.RadioButton radioSignoNegativo;
		private System.Windows.Forms.RadioButton radioSignoPositivo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioDV;
		private System.Windows.Forms.TextBox txtMascara;
		private System.Windows.Forms.TextBox txtFamilia;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioSignoCtaCteNegativo;
		private System.Windows.Forms.RadioButton radioSignoCtaCtePositivo;
		private Janus.Windows.GridEX.GridEX gridTiposDeComprobantes;
		private System.Windows.Forms.RadioButton radioNoVa;
		private System.Windows.Forms.RadioButton radioBlanco;
		private mz.erp.ui.controls.GridManagerView gridManagerView1;

		private AbmTipoDeComprobanteController _uiController;

		public FrmAbmTiposDeComprobantes(AbmTipoDeComprobanteController uiController)
		{
			InitializeComponent();
			_uiController = uiController;
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
			//FillControls();
		}

		private void ConfigureInterface()
		{
			Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;

			gridTiposDeComprobantes.LayoutData = _uiController.GetLayoutTiposDeComprobantes();
			gridTiposDeComprobantes.GroupByBoxVisible  = false;
			gridTiposDeComprobantes.AllowColumnDrag = false;
			gridTiposDeComprobantes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;

			gridManagerView1.Configure(_uiController.GetProcessManager().GetProcessName(), _uiController.GetTaskName(), this.Name, gridTiposDeComprobantes, this.Text);			
			gridManagerView1.Enabled = true;
			KeyPreview = true;
			mz.erp.ui.forms.classes.ContainerManager.CollapseContainers(ultraExplorerBar1, _uiController.GetProcessName(), _uiController.GetTaskName());
		}

		private void InitEventHandlers()
		{
			toolBar1.ButtonClick += new ToolBarButtonClickEventHandler(toolBar1_ButtonClick);
			gridTiposDeComprobantes.SelectionChanged += new EventHandler(gridTiposDeComprobantes_SelectionChanged);
			txtDescripcion.TextChanged += new EventHandler(txtDescripcion_TextChanged);
			txtFamilia.TextChanged += new EventHandler(txtFamilia_TextChanged);
			txtMascara.TextChanged += new EventHandler(txtMascara_TextChanged);
			radioNoVa.CheckedChanged += new EventHandler(radioNoVa_CheckedChanged);
			radioBlanco.CheckedChanged += new EventHandler(radioBlanco_CheckedChanged);
			radioDV.CheckedChanged += new EventHandler(radioDV_CheckedChanged);
			radioSignoCtaCteNegativo.CheckedChanged += new EventHandler(radioSignoCtaCteNegativo_CheckedChanged);
			radioSignoCtaCtePositivo.CheckedChanged += new EventHandler(radioSignoCtaCtePositivo_CheckedChanged);
			radioSignoNegativo.CheckedChanged += new EventHandler(radioSignoNegativo_CheckedChanged);
			radioSignoPositivo.CheckedChanged += new EventHandler(radioSignoPositivo_CheckedChanged);
			chActivo.CheckedChanged += new EventHandler(chActivo_CheckedChanged);
			chRequiereCondicionDeVenta.CheckedChanged += new EventHandler(chRequiereCondicionDeVenta_CheckedChanged);
			KeyDownManager KeyDown = new KeyDownManager(this);	
		}

		private void ActivarEventos()
		{
			txtDescripcion.TextChanged += new EventHandler(txtDescripcion_TextChanged);
			txtFamilia.TextChanged += new EventHandler(txtFamilia_TextChanged);
			txtMascara.TextChanged += new EventHandler(txtMascara_TextChanged);
			radioNoVa.CheckedChanged += new EventHandler(radioNoVa_CheckedChanged);
			radioBlanco.CheckedChanged += new EventHandler(radioBlanco_CheckedChanged);
			radioDV.CheckedChanged += new EventHandler(radioDV_CheckedChanged);
			radioSignoCtaCteNegativo.CheckedChanged += new EventHandler(radioSignoCtaCteNegativo_CheckedChanged);
			radioSignoCtaCtePositivo.CheckedChanged += new EventHandler(radioSignoCtaCtePositivo_CheckedChanged);
			radioSignoNegativo.CheckedChanged += new EventHandler(radioSignoNegativo_CheckedChanged);
			radioSignoPositivo.CheckedChanged += new EventHandler(radioSignoPositivo_CheckedChanged);
			chActivo.CheckedChanged += new EventHandler(chActivo_CheckedChanged);
			chRequiereCondicionDeVenta.CheckedChanged += new EventHandler(chRequiereCondicionDeVenta_CheckedChanged);
		}

		private void DesactivarEventos()
		{
			txtDescripcion.TextChanged -= new EventHandler(txtDescripcion_TextChanged);
			txtFamilia.TextChanged -= new EventHandler(txtFamilia_TextChanged);
			txtMascara.TextChanged -= new EventHandler(txtMascara_TextChanged);
			radioNoVa.CheckedChanged -= new EventHandler(radioNoVa_CheckedChanged);
			radioBlanco.CheckedChanged -= new EventHandler(radioBlanco_CheckedChanged);
			radioDV.CheckedChanged -= new EventHandler(radioDV_CheckedChanged);
			radioSignoCtaCteNegativo.CheckedChanged -= new EventHandler(radioSignoCtaCteNegativo_CheckedChanged);
			radioSignoCtaCtePositivo.CheckedChanged -= new EventHandler(radioSignoCtaCtePositivo_CheckedChanged);
			radioSignoNegativo.CheckedChanged -= new EventHandler(radioSignoNegativo_CheckedChanged);
			radioSignoPositivo.CheckedChanged -= new EventHandler(radioSignoPositivo_CheckedChanged);
			chActivo.CheckedChanged -= new EventHandler(chActivo_CheckedChanged);
			chRequiereCondicionDeVenta.CheckedChanged -= new EventHandler(chRequiereCondicionDeVenta_CheckedChanged);
		}

		private void InitializeData()
		{
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
					if (this.ultraExplorerBar1.Groups.Exists(grupo))
					{
						if (this.ultraExplorerBar1.Groups[grupo].Container != null)
						{
							this.ultraExplorerBar1.Groups[grupo].Container.Enabled = true;}
						this.ultraExplorerBar1.Groups[grupo].Enabled = true;}
				}
			}

		}

		private void InitDataBindings()
		{		
			gridTiposDeComprobantes.DataBindings.Clear();
			gridTiposDeComprobantes.SetDataBinding(_uiController.TiposDeComprobantes,null);
		}


		//se ejecuta al levantar la ventana
		protected void FillControls()
		{
			/*txtDescripcion.Text = _uiController.Descripcion;
			mzComboEstadoDeStock.Value = _uiController.IdEstadoDeStock;
			short operacion = _uiController.Operacion;
			if (operacion == 1)
			{
				radioPositiva.Checked = true;
			}
			else
			{
				radioNegativa.Checked = true;
			}
			chActivo.Checked = _uiController.Activo;
			chSistema.Checked = _uiController.Sistema;*/

		}

		//se ejecuta al intentar guardar
		protected void DumpControls()
		{
			/*_uiController.IdEstadoDeStock = mzComboEstadoDeStock.Value.ToString();
			_uiController.Descripcion = txtDescripcion.Text;
			if (radioPositiva.Checked)
			{
				_uiController.Operacion = 1;
			}
			else
			{
				_uiController.Operacion = -1;
			}
			_uiController.Activo = chActivo.Checked;
			_uiController.Sistema = chSistema.Checked;*/
		}

		private void RefreshData()
		{
			/*string idTipoAjuste = (string) mzCmbTipoAjuste.DataValue;
			if(idTipoAjuste != null && idTipoAjuste != string.Empty && idTipoAjuste != _uiController.IdTipoAjusteStock)
			{
				_uiController.IdTipoAjusteStock = idTipoAjuste;
				FillControls();
			}*/

			Janus.Windows.GridEX.ConditionOperator condOp = new Janus.Windows.GridEX.ConditionOperator();	
			condOp = Janus.Windows.GridEX.ConditionOperator.Equal;
			Janus.Windows.GridEX.GridEXFormatCondition cnd = new Janus.Windows.GridEX.GridEXFormatCondition( gridTiposDeComprobantes.RootTable.Columns[ "Agregado" ], condOp, true);
			cnd.FormatStyle.ForeColor = System.Drawing.Color.Red;
			gridTiposDeComprobantes.RootTable.FormatConditions.Add( cnd );

			gridTiposDeComprobantes.SelectionChanged -= new EventHandler(gridTiposDeComprobantes_SelectionChanged);
	
			int posicion = gridTiposDeComprobantes.Row;
			gridTiposDeComprobantes.SetDataBinding( null,null);
			gridTiposDeComprobantes.SetDataBinding( _uiController.TiposDeComprobantes,null);	
			gridTiposDeComprobantes.Row = posicion;

			gridTiposDeComprobantes.SelectionChanged += new EventHandler(gridTiposDeComprobantes_SelectionChanged);

	
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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmTiposDeComprobantes));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl4 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridTiposDeComprobantes = new Janus.Windows.GridEX.GridEX();
			this.datosGeneralesContainer = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioSignoCtaCteNegativo = new System.Windows.Forms.RadioButton();
			this.radioSignoCtaCtePositivo = new System.Windows.Forms.RadioButton();
			this.txtFamilia = new System.Windows.Forms.TextBox();
			this.txtMascara = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioNoVa = new System.Windows.Forms.RadioButton();
			this.radioDV = new System.Windows.Forms.RadioButton();
			this.radioBlanco = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.chRequiereCondicionDeVenta = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioSignoNegativo = new System.Windows.Forms.RadioButton();
			this.radioSignoPositivo = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.chActivo = new System.Windows.Forms.CheckBox();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.gridManagerView1 = new mz.erp.ui.controls.GridManagerView();
			this.ultraExplorerBarContainerControl4.SuspendLayout();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTiposDeComprobantes)).BeginInit();
			this.datosGeneralesContainer.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl4
			// 
			this.ultraExplorerBarContainerControl4.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl4.Location = new System.Drawing.Point(28, 18);
			this.ultraExplorerBarContainerControl4.Name = "ultraExplorerBarContainerControl4";
			this.ultraExplorerBarContainerControl4.Size = new System.Drawing.Size(846, 39);
			this.ultraExplorerBarContainerControl4.TabIndex = 5;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(846, 32);
			this.labelTarea.TabIndex = 0;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridManagerView1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridTiposDeComprobantes);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 116);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(846, 256);
			this.ultraExplorerBarContainerControl1.TabIndex = 7;
			// 
			// gridTiposDeComprobantes
			// 
			this.gridTiposDeComprobantes.AllowCardSizing = false;
			this.gridTiposDeComprobantes.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridTiposDeComprobantes.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridTiposDeComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridTiposDeComprobantes.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridTiposDeComprobantes.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridTiposDeComprobantes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridTiposDeComprobantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.gridTiposDeComprobantes.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridTiposDeComprobantes.Location = new System.Drawing.Point(8, 40);
			this.gridTiposDeComprobantes.Name = "gridTiposDeComprobantes";
			this.gridTiposDeComprobantes.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridTiposDeComprobantes.Size = new System.Drawing.Size(823, 208);
			this.gridTiposDeComprobantes.TabIndex = 47;
			this.gridTiposDeComprobantes.TabStop = false;
			// 
			// datosGeneralesContainer
			// 
			this.datosGeneralesContainer.Controls.Add(this.groupBox3);
			this.datosGeneralesContainer.Controls.Add(this.txtFamilia);
			this.datosGeneralesContainer.Controls.Add(this.txtMascara);
			this.datosGeneralesContainer.Controls.Add(this.groupBox2);
			this.datosGeneralesContainer.Controls.Add(this.label6);
			this.datosGeneralesContainer.Controls.Add(this.label5);
			this.datosGeneralesContainer.Controls.Add(this.label2);
			this.datosGeneralesContainer.Controls.Add(this.chRequiereCondicionDeVenta);
			this.datosGeneralesContainer.Controls.Add(this.label1);
			this.datosGeneralesContainer.Controls.Add(this.groupBox1);
			this.datosGeneralesContainer.Controls.Add(this.label9);
			this.datosGeneralesContainer.Controls.Add(this.label4);
			this.datosGeneralesContainer.Controls.Add(this.txtDescripcion);
			this.datosGeneralesContainer.Controls.Add(this.chActivo);
			this.datosGeneralesContainer.Location = new System.Drawing.Point(28, 431);
			this.datosGeneralesContainer.Name = "datosGeneralesContainer";
			this.datosGeneralesContainer.Size = new System.Drawing.Size(846, 157);
			this.datosGeneralesContainer.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.radioSignoCtaCteNegativo);
			this.groupBox3.Controls.Add(this.radioSignoCtaCtePositivo);
			this.groupBox3.Location = new System.Drawing.Point(320, 92);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(120, 48);
			this.groupBox3.TabIndex = 55;
			this.groupBox3.TabStop = false;
			// 
			// radioSignoCtaCteNegativo
			// 
			this.radioSignoCtaCteNegativo.Location = new System.Drawing.Point(8, 27);
			this.radioSignoCtaCteNegativo.Name = "radioSignoCtaCteNegativo";
			this.radioSignoCtaCteNegativo.Size = new System.Drawing.Size(104, 16);
			this.radioSignoCtaCteNegativo.TabIndex = 1;
			this.radioSignoCtaCteNegativo.Text = "Negativo";
			// 
			// radioSignoCtaCtePositivo
			// 
			this.radioSignoCtaCtePositivo.Checked = true;
			this.radioSignoCtaCtePositivo.Location = new System.Drawing.Point(8, 12);
			this.radioSignoCtaCtePositivo.Name = "radioSignoCtaCtePositivo";
			this.radioSignoCtaCtePositivo.Size = new System.Drawing.Size(104, 16);
			this.radioSignoCtaCtePositivo.TabIndex = 0;
			this.radioSignoCtaCtePositivo.TabStop = true;
			this.radioSignoCtaCtePositivo.Text = "Positivo";
			// 
			// txtFamilia
			// 
			this.txtFamilia.Location = new System.Drawing.Point(128, 50);
			this.txtFamilia.Name = "txtFamilia";
			this.txtFamilia.Size = new System.Drawing.Size(345, 20);
			this.txtFamilia.TabIndex = 54;
			this.txtFamilia.Text = "";
			// 
			// txtMascara
			// 
			this.txtMascara.Location = new System.Drawing.Point(128, 28);
			this.txtMascara.Name = "txtMascara";
			this.txtMascara.Size = new System.Drawing.Size(345, 20);
			this.txtMascara.TabIndex = 53;
			this.txtMascara.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.radioNoVa);
			this.groupBox2.Controls.Add(this.radioDV);
			this.groupBox2.Controls.Add(this.radioBlanco);
			this.groupBox2.Location = new System.Drawing.Point(544, 92);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(120, 64);
			this.groupBox2.TabIndex = 52;
			this.groupBox2.TabStop = false;
			// 
			// radioNoVa
			// 
			this.radioNoVa.Location = new System.Drawing.Point(8, 40);
			this.radioNoVa.Name = "radioNoVa";
			this.radioNoVa.Size = new System.Drawing.Size(104, 16);
			this.radioNoVa.TabIndex = 2;
			this.radioNoVa.Text = "No va a Cta Cte";
			// 
			// radioDV
			// 
			this.radioDV.Location = new System.Drawing.Point(8, 27);
			this.radioDV.Name = "radioDV";
			this.radioDV.Size = new System.Drawing.Size(104, 16);
			this.radioDV.TabIndex = 1;
			this.radioDV.Text = "DV";
			// 
			// radioBlanco
			// 
			this.radioBlanco.Checked = true;
			this.radioBlanco.Location = new System.Drawing.Point(8, 12);
			this.radioBlanco.Name = "radioBlanco";
			this.radioBlanco.Size = new System.Drawing.Size(104, 16);
			this.radioBlanco.TabIndex = 0;
			this.radioBlanco.TabStop = true;
			this.radioBlanco.Text = "Blanco";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(512, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(176, 16);
			this.label6.TabIndex = 51;
			this.label6.Text = "Tipo Cuenta Corriente";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(288, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(176, 16);
			this.label5.TabIndex = 50;
			this.label5.Text = "Signo Cuenta Corriente";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(24, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 49;
			this.label2.Text = "Familia";
			// 
			// chRequiereCondicionDeVenta
			// 
			this.chRequiereCondicionDeVenta.BackColor = System.Drawing.Color.Transparent;
			this.chRequiereCondicionDeVenta.Checked = true;
			this.chRequiereCondicionDeVenta.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chRequiereCondicionDeVenta.Location = new System.Drawing.Point(512, 28);
			this.chRequiereCondicionDeVenta.Name = "chRequiereCondicionDeVenta";
			this.chRequiereCondicionDeVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chRequiereCondicionDeVenta.Size = new System.Drawing.Size(176, 16);
			this.chRequiereCondicionDeVenta.TabIndex = 48;
			this.chRequiereCondicionDeVenta.Text = "Requiere Condicion de Venta";
			this.chRequiereCondicionDeVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(24, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 47;
			this.label1.Text = "Signo";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioSignoNegativo);
			this.groupBox1.Controls.Add(this.radioSignoPositivo);
			this.groupBox1.Location = new System.Drawing.Point(65, 92);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(120, 48);
			this.groupBox1.TabIndex = 46;
			this.groupBox1.TabStop = false;
			// 
			// radioSignoNegativo
			// 
			this.radioSignoNegativo.Location = new System.Drawing.Point(8, 27);
			this.radioSignoNegativo.Name = "radioSignoNegativo";
			this.radioSignoNegativo.Size = new System.Drawing.Size(104, 16);
			this.radioSignoNegativo.TabIndex = 1;
			this.radioSignoNegativo.Text = "Negativo";
			// 
			// radioSignoPositivo
			// 
			this.radioSignoPositivo.Checked = true;
			this.radioSignoPositivo.Location = new System.Drawing.Point(8, 12);
			this.radioSignoPositivo.Name = "radioSignoPositivo";
			this.radioSignoPositivo.Size = new System.Drawing.Size(104, 16);
			this.radioSignoPositivo.TabIndex = 0;
			this.radioSignoPositivo.TabStop = true;
			this.radioSignoPositivo.Text = "Positivo";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(24, 28);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 16);
			this.label9.TabIndex = 44;
			this.label9.Text = "Mascara";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(24, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 43;
			this.label4.Text = "Descripción";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(128, 8);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(345, 20);
			this.txtDescripcion.TabIndex = 42;
			this.txtDescripcion.Text = "";
			// 
			// chActivo
			// 
			this.chActivo.BackColor = System.Drawing.Color.Transparent;
			this.chActivo.Checked = true;
			this.chActivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chActivo.Location = new System.Drawing.Point(512, 8);
			this.chActivo.Name = "chActivo";
			this.chActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chActivo.Size = new System.Drawing.Size(176, 16);
			this.chActivo.TabIndex = 41;
			this.chActivo.Text = "Activo";
			this.chActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.toolBar1.Size = new System.Drawing.Size(912, 28);
			this.toolBar1.TabIndex = 23;
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
			ultraExplorerBarGroup2.Key = "Tipos De Comprobantes";
			ultraExplorerBarGroup2.Settings.ContainerHeight = 256;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Tipos De Comprobantes";
			ultraExplorerBarGroup2.Visible = false;
			ultraExplorerBarGroup3.Container = this.datosGeneralesContainer;
			ultraExplorerBarGroup3.Enabled = false;
			ultraExplorerBarGroup3.Key = "Comprobante";
			ultraExplorerBarGroup3.Settings.ContainerHeight = 157;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Comprobante";
			ultraExplorerBarGroup3.Visible = false;
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(912, 594);
			this.ultraExplorerBar1.TabIndex = 24;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// gridManagerView1
			// 
			this.gridManagerView1.BackColor = System.Drawing.SystemColors.Control;
			this.gridManagerView1.Location = new System.Drawing.Point(8, 8);
			this.gridManagerView1.Name = "gridManagerView1";
			this.gridManagerView1.Size = new System.Drawing.Size(384, 24);
			this.gridManagerView1.TabIndex = 48;
			// 
			// FrmAbmTiposDeComprobantes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(912, 622);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBar1);
			this.Name = "FrmAbmTiposDeComprobantes";
			this.Text = "FrmAbmTiposDeComprobantes";
			this.ultraExplorerBarContainerControl4.ResumeLayout(false);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridTiposDeComprobantes)).EndInit();
			this.datosGeneralesContainer.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

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

		private void gridTiposDeComprobantes_SelectionChanged(object sender, EventArgs e)
		{
			DesactivarEventos();
			//txtDescripcion.TextChanged -= new EventHandler(txtDescripcion_TextChanged);

			if(gridTiposDeComprobantes.SelectedItems.Count > 0)
			{
				mz.erp.businessrules.TipoDeComprobante row = (mz.erp.businessrules.TipoDeComprobante)gridTiposDeComprobantes.SelectedItems[0].GetRow().DataRow;
				//row.Agregado = true;

				_uiController.TipoDeComprobanteSeleccionado = row;
				txtDescripcion.Text = row.Descripcion;
				txtFamilia.Text = row.Familia;
				txtMascara.Text = row.Mascara;
				int signo = row.Signo;
				if (signo == 1)
				{
					radioSignoPositivo.Checked = true;
				}
				else
				{
					radioSignoNegativo.Checked = true;
				}
				int signoCtaCte = row.SignoCuentaCorriente;
				if (signoCtaCte == 1)
				{
					radioSignoCtaCtePositivo.Checked = true;
				}
				else
				{
					radioSignoCtaCteNegativo.Checked = true;
				}
				int tipo = row.TipoCuentaCorriente;
				switch ( tipo )
				{
					case 0:
						radioNoVa.Checked = true;
						break;
					case 1:
						radioBlanco.Checked = true;
						break;
					case 2:
						radioDV.Checked = true;
						break;
					default :
						radioNoVa.Checked = true;
						break;
				}
				chActivo.Checked = row.Activo;
				chRequiereCondicionDeVenta.Checked = row.RequiereCondicionDeVenta;

				//txtDescripcion.TextChanged += new EventHandler(txtDescripcion_TextChanged);
				ActivarEventos();

			}
		}

		private void txtDescripcion_TextChanged(object sender, EventArgs e)
		{
			//mz.erp.businessrules.TipoDeComprobante row = (mz.erp.businessrules.TipoDeComprobante)gridTiposDeComprobantes.SelectedItems[0].GetRow().DataRow;
			_uiController.TipoDeComprobanteSeleccionado.Descripcion = txtDescripcion.Text;
			_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
			RefreshData();
		}

		private void txtFamilia_TextChanged(object sender, EventArgs e)
		{
			//mz.erp.businessrules.TipoDeComprobante row = (mz.erp.businessrules.TipoDeComprobante)gridTiposDeComprobantes.SelectedItems[0].GetRow().DataRow;
			_uiController.TipoDeComprobanteSeleccionado.Familia = txtFamilia.Text;
			_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
			RefreshData();
		}

		private void txtMascara_TextChanged(object sender, EventArgs e)
		{
			_uiController.TipoDeComprobanteSeleccionado.Mascara = txtMascara.Text;
			_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
			RefreshData();
		}

		private void radioNoVa_CheckedChanged(object sender, EventArgs e)
		{
			if (radioNoVa.Checked)
			{
				_uiController.TipoDeComprobanteSeleccionado.TipoCuentaCorriente = 0;
				_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
				RefreshData();
			}
		}

		private void radioBlanco_CheckedChanged(object sender, EventArgs e)
		{
			if (radioBlanco.Checked)
			{
				_uiController.TipoDeComprobanteSeleccionado.TipoCuentaCorriente = 1;
				_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
				RefreshData();
			}
		}

		private void radioDV_CheckedChanged(object sender, EventArgs e)
		{
			if (radioDV.Checked)
			{
				_uiController.TipoDeComprobanteSeleccionado.TipoCuentaCorriente = 2;
				_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
				RefreshData();
			}
		}

		private void radioSignoCtaCteNegativo_CheckedChanged(object sender, EventArgs e)
		{
			if (radioSignoCtaCteNegativo.Checked)
			{
				_uiController.TipoDeComprobanteSeleccionado.SignoCuentaCorriente = -1;
				_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
				RefreshData();
			}
		}

		private void radioSignoCtaCtePositivo_CheckedChanged(object sender, EventArgs e)
		{
			if (radioSignoCtaCtePositivo.Checked)
			{
				_uiController.TipoDeComprobanteSeleccionado.SignoCuentaCorriente = 1;
				_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
				RefreshData();
			}
		}

		private void radioSignoNegativo_CheckedChanged(object sender, EventArgs e)
		{
			if (radioSignoNegativo.Checked)
			{
				_uiController.TipoDeComprobanteSeleccionado.Signo = -1;
				_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
				RefreshData();
			}
		}

		private void radioSignoPositivo_CheckedChanged(object sender, EventArgs e)
		{
			if (radioSignoPositivo.Checked)
			{
				_uiController.TipoDeComprobanteSeleccionado.Signo = 1;
				_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
				RefreshData();
			}
		}

		private void chActivo_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.TipoDeComprobanteSeleccionado.Activo = chActivo.Checked;
			_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
			RefreshData();
		}

		private void chRequiereCondicionDeVenta_CheckedChanged(object sender, EventArgs e)
		{
			_uiController.TipoDeComprobanteSeleccionado.RequiereCondicionDeVenta = chRequiereCondicionDeVenta.Checked;
			_uiController.TipoDeComprobanteSeleccionado.Agregado = true;
			RefreshData();
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

using mz.erp.ui.controls;

using mz.erp.commontypes;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.commontypes.data;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

using mz.erp.ui.controllers;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmConsultas.
	/// </summary>
	public class FrmConsultasWF : System.Windows.Forms.Form , ISearchObjectListener, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		protected System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.Panel panel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ContainerFiltro;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		protected Janus.Windows.GridEX.GridEX gridResultado;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.ToolBarButton toolBarButton15;
		private System.Windows.Forms.ToolBarButton tbbImprimir;
		private System.Windows.Forms.ToolBarButton toolBarButton16;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private System.Windows.Forms.Label labelTarea;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbEjecutarConsulta;
		private System.Windows.Forms.ToolBarButton tbbReiniciarFiltros;
		private System.ComponentModel.IContainer components;

		


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
				_uiController = null;
				_filtros = null;
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmConsultasWF));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup3 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ContainerFiltro = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridResultado = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.tbbEjecutarConsulta = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.tbbReiniciarFiltros = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton15 = new System.Windows.Forms.ToolBarButton();
			this.tbbImprimir = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton16 = new System.Windows.Forms.ToolBarButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(686, 24);
			this.ultraExplorerBarContainerControl1.TabIndex = 2;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(686, 23);
			this.labelTarea.TabIndex = 2;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ContainerFiltro
			// 
			this.ContainerFiltro.Location = new System.Drawing.Point(28, 107);
			this.ContainerFiltro.Name = "ContainerFiltro";
			this.ContainerFiltro.Size = new System.Drawing.Size(686, 146);
			this.ContainerFiltro.TabIndex = 0;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridResultado);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 312);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(686, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridResultado
			// 
			this.gridResultado.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridResultado.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridResultado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridResultado.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridResultado.GroupByBoxVisible = false;
			this.gridResultado.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridResultado.Location = new System.Drawing.Point(0, 0);
			this.gridResultado.Name = "gridResultado";
			this.gridResultado.Size = new System.Drawing.Size(686, 150);
			this.gridResultado.TabIndex = 0;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 0;
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 1;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 2;
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 3;
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 5;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.toolBarButton11,
																							  this.tbbEjecutarConsulta,
																							  this.toolBarButton13,
																							  this.tbbReiniciarFiltros,
																							  this.toolBarButton15,
																							  this.tbbImprimir,
																							  this.toolBarButton16});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(752, 28);
			this.toolBarStandar.TabIndex = 19;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 10;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 11;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbEjecutarConsulta
			// 
			this.tbbEjecutarConsulta.ImageIndex = 2;
			this.tbbEjecutarConsulta.Text = "Ejecutar Consulta [F5]";
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbReiniciarFiltros
			// 
			this.tbbReiniciarFiltros.ImageIndex = 5;
			this.tbbReiniciarFiltros.Text = "Reiniciar Filtros de Busqueda";
			// 
			// toolBarButton15
			// 
			this.toolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbImprimir
			// 
			this.tbbImprimir.ImageIndex = 8;
			this.tbbImprimir.Text = "Imprimir";
			// 
			// toolBarButton16
			// 
			this.toolBarButton16.ImageIndex = 9;
			this.toolBarButton16.Text = "&Selección";
			this.toolBarButton16.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ultraExplorerBar1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(752, 418);
			this.panel1.TabIndex = 20;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ContainerFiltro);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 24;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ContainerFiltro;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 146;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Filtro Inicial";
			ultraExplorerBarGroup3.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup3.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup3.Text = "Resultado";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2,
																														ultraExplorerBarGroup3});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 0);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(752, 418);
			this.ultraExplorerBar1.TabIndex = 1;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmConsultasWF
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(752, 446);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolBarStandar);
			this.KeyPreview = true;
			this.Name = "FrmConsultasWF";
			this.Text = "Comprobantes";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultas_KeyDown);
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridResultado)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region MetodosYPropiedadesPublicas

		private mz.erp.ui.controllers.ConsultasController _uiController = null;
		Hashtable _defaultValues = new Hashtable();
		
		public new virtual void Show()
		{
			Init();
			try
			{
				LoadDefaultValues();	
				base.Show();	
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		#endregion

		#region MetodosYPropiedadesPrivadas
		private string _defaultValueComprobantesAgrupados;

		private int iniX = 10;
		private int iniY = 10;
		private int desplazamientotexto = 150;
		private int factordealtura = 24;
		private ArrayList _parametros = new ArrayList();
		private bool _changeSort = false;
		private ReportFilterArray _filtros;

		#endregion

		///se usará para para cualquier consulta sobre comprobantes que se quiera hacer,
		///debido a que ConsultasController  es una clase abstracta!
		public FrmConsultasWF(ConsultasController controller)
		{			
			InitializeComponent();
			_uiController = controller;
			_filtros = _uiController.Filtros;
			Build_UI();
		}

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
			if(_uiController != null)
			{
				if(this._uiController.AllowShow())
				{
					tbbAnterior.Visible = _uiController.IsFirstTask();
					Show();
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
			else this.Show();
		
		}

		public void CloseForm()
		{
			Close();
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			_uiController.Execute();
		}

		private void Build_UI()
		{			
			labelTarea.Text = _uiController.LeyendaFormulario;
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSiguiente.Enabled = !_uiController.IsLastTask() && !_uiController.IsFlushedState();

			if(_uiController.Filtros.Count == 0)
				{
				 this.ultraExplorerBar1.Groups[1].Visible = false;
				}

			gridResultado.UpdateMode = Janus.Windows.GridEX.UpdateMode.RowUpdate;
			gridResultado.UpdateOnLeave = true;
			gridResultado.Error +=new Janus.Windows.GridEX.ErrorEventHandler(gridResultado_Error);
			gridResultado.SortKeysChanged +=new EventHandler(gridResultado_SortKeysChanged);
			Init();
			KeyDownManager KeyDownMan = new KeyDownManager(this);	
			
		}

		private void gridResultado_Error(object sender, Janus.Windows.GridEX.ErrorEventArgs e)
		{
			e.DisplayErrorMessage = true;
		}

		private void gridResultado_SortKeysChanged(object sender, EventArgs e)
		{
			_changeSort = true;
		}

		protected virtual void onClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:
					_uiController.Execute();
					break;
			}		
		}

		private void FrmConsultas_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == System.Windows.Forms.Keys.PageDown)
				this.gridResultado.Select();
			
			else
			if(e.KeyCode == System.Windows.Forms.Keys.N)
				if(e.Modifiers == System.Windows.Forms.Keys.Alt)
					this.ResetUI();	
			else 
				if (e.KeyCode == System.Windows.Forms.Keys.F5)
					this.RefreshData();
		}
		

		protected void RefreshData()
		{
			Util.MoveFocus(this.ContainerFiltro);
			gridResultado.Focus();
			_uiController.RefreshData();
			System.Data.DataTable table = _uiController.Table;
			gridResultado.LayoutData = _uiController.LayoutData;
			gridResultado.SetDataBinding(null, null);
			gridResultado.SetDataBinding(table, null);
			gridResultado.Refetch();
			gridResultado.Refresh();	
		}



		#region Implemetancion Interface ISearchObjectListener
		public void processEventChange(object sender , EventArgs e)
		{
			RefreshData();
		}
		#endregion

		#region Filters
			#region FiltroMoneda
			private void FiltroMoneda(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchMoneda= new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchMoneda.DataValue = "";
				mzComboSearchMoneda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchMoneda.SearchObject = typeof(mz.erp.ui.forms.classes.tfi_Monedas);
				mzComboSearchMoneda.Size = new System.Drawing.Size(496, 24);

				mzComboSearchMoneda.Name = "mzComboSearchMoneda"+Convert.ToString(order).Trim();
				mzComboSearchMoneda.TabIndex = order;
				mzComboSearchMoneda.ValueChanged+= new System.EventHandler( this.ValueChanged );
				mzComboSearchMoneda.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchMoneda.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;
				
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblCuenta"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchMoneda );
				if (defaultValue != null)
				{
					mzComboSearchMoneda.DataValue = (string)defaultValue;
				}
				else
				{
					if(_uiController != null)
					{
						mzComboSearchMoneda.DataBindings.Add("DataValue", _uiController, propertyBinding);
					}
				}
			}
			#endregion
			#region FiltroProveedor
			private void FiltroProveedor(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchProveedor = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchProveedor.DataValue = "";
				mzComboSearchProveedor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchProveedor.SearchObject = typeof(mz.erp.ui.forms.classes.tpu_Proveedores);
				mzComboSearchProveedor.Size = new System.Drawing.Size(496, 24);

				mzComboSearchProveedor.Name = "mzComboSearchProveedor"+Convert.ToString(order).Trim();
				mzComboSearchProveedor.TabIndex = order;
				mzComboSearchProveedor.ValueChanged+= new System.EventHandler( this.ValueChanged );
				mzComboSearchProveedor.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchProveedor.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;
				
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblCuenta"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchProveedor );
				if (defaultValue != null)
				{
					mzComboSearchProveedor.DataValue= (string)defaultValue;
				}
				else
				{
					if(_uiController != null)
					{
						mzComboSearchProveedor.DataBindings.Add("DataValue", _uiController, propertyBinding);
					}
				}
			}
			#endregion
			#region FiltroMomento
			private void FiltroMomento(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				int posicionY = iniY + (factordealtura * order);
				System.Windows.Forms.TextBox text = new TextBox();
				text.TextChanged+= new System.EventHandler( this.ValueChanged);						
				text.TabIndex = order;
				text.BackColor = System.Drawing.Color.White;
				text.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
				text.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				text.Text = defaultValue.ToString();
				text.Visible = true;
				text.Enabled = false;

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;			
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblCuenta"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );

				text.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY);
				text.Name = "txtMomento"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( text );

			}
			#endregion
			#region FiltroFecha

			private void FiltroFecha( int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				Infragistics.Win.UltraWinSchedule.UltraCalendarCombo calendar = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
				Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
				dateButton.Caption = "Hoy";
				calendar.DateButtons.Add(dateButton);
				calendar.NonAutoSizeHeight = 23;
				
				int posicionY = iniY + (factordealtura * order);
				calendar.Name = "ultraCalendarCombo"+Convert.ToString(order).Trim();
				calendar.Size = new System.Drawing.Size(96, 21);
				calendar.TabIndex = order;
				calendar.Location = new System.Drawing.Point( iniX+ desplazamientotexto, posicionY );
				calendar.ValueChanged+= new System.EventHandler( this.ValueChanged );
				calendar.Enabled = enabled;

				
				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;
				
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblCuenta"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( calendar);

				if (defaultValue != null)
				{
					calendar.Value = (DateTime)defaultValue;
				}
				else
				{
					if(_uiController != null)
					{
						calendar.DataBindings.Add("Value",_uiController, propertyBinding);		
					}
				}		
			}
			#endregion
			#region FiltroEstadoDeStock
			private void FiltroEstadoDeStock(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding )
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchEstadoDeStock = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchEstadoDeStock.DataValue = "";
				mzComboSearchEstadoDeStock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchEstadoDeStock.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_EstadosDeStock);
				mzComboSearchEstadoDeStock.Size = new System.Drawing.Size(496, 24);

				mzComboSearchEstadoDeStock.Name = "mzComboSearchEstadoDeStock"+Convert.ToString(order).Trim();
				mzComboSearchEstadoDeStock.TabIndex = order;
				mzComboSearchEstadoDeStock.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchEstadoDeStock.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
				mzComboSearchEstadoDeStock.ValueChanged+= new System.EventHandler( this.ValueChanged );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
					
				label.BackColor = System.Drawing.Color.Transparent;
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblEstadoDeStock"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchEstadoDeStock );

				if (defaultValue != null)
				{
					mzComboSearchEstadoDeStock.DataValue= (string)defaultValue;
				}			
			}
			#endregion
			#region FiltroSeccion
			private void FiltroSeccion(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding )
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchSeccion = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchSeccion.DataValue = "";
				mzComboSearchSeccion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchSeccion.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_Secciones);
				mzComboSearchSeccion.Size = new System.Drawing.Size(496, 24);

				mzComboSearchSeccion.Name = "mzComboSearchSeccion"+Convert.ToString(order).Trim();
				mzComboSearchSeccion.TabIndex = order;
				mzComboSearchSeccion.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchSeccion.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
				mzComboSearchSeccion.ValueChanged+= new System.EventHandler( this.ValueChanged );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
					
				label.BackColor = System.Drawing.Color.Transparent;
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblSeccion"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchSeccion );

				if (defaultValue != null)
				{
					mzComboSearchSeccion.DataValue= (string)defaultValue;
				}			
			}
			#endregion
			#region FiltroDeposito
			private void FiltroDeposito(int order, string leyenda, bool enabled, object defaultValue , string propertyBinding)
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchDeposito = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchDeposito.DataValue = "";
				mzComboSearchDeposito.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchDeposito.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_Depositos);
				mzComboSearchDeposito.Size = new System.Drawing.Size(496, 24);

				mzComboSearchDeposito.Name = "mzComboSearchDeposito"+Convert.ToString(order).Trim();
				mzComboSearchDeposito.TabIndex = order;
				mzComboSearchDeposito.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchDeposito.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
				mzComboSearchDeposito.ValueChanged+= new System.EventHandler( this.ValueChanged );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
					
				label.BackColor = System.Drawing.Color.Transparent;
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblDeposito"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchDeposito );

				if (defaultValue != null)
				{
					mzComboSearchDeposito.DataValue= (string)defaultValue;
				}			
			}
			#endregion
			#region FiltroTipoDeAjuste
			
			private void FiltroTipoDeAjuste(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding )
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchTipoDeAjuste = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchTipoDeAjuste.DataValue = "";
				mzComboSearchTipoDeAjuste.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchTipoDeAjuste.SearchObject = typeof(mz.erp.ui.forms.classes.tlg_TiposDeAjuste);
				mzComboSearchTipoDeAjuste.Size = new System.Drawing.Size(496, 24);

				mzComboSearchTipoDeAjuste.Name = "mzComboSearchTipoDeAjuste"+Convert.ToString(order).Trim();
				mzComboSearchTipoDeAjuste.TabIndex = order;
				mzComboSearchTipoDeAjuste.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchTipoDeAjuste.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
				mzComboSearchTipoDeAjuste.ValueChanged+= new System.EventHandler( this.ValueChanged );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
					
				label.BackColor = System.Drawing.Color.Transparent;
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblTipoDeAjuste"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchTipoDeAjuste );

				if (defaultValue != null)
				{
					mzComboSearchTipoDeAjuste.DataValue= (string)defaultValue;
				}			
			}
			#endregion
			#region FiltroProducto
			private void FiltroProducto(int order, string leyenda, bool enabled, object defaultValue , string propertyBinding)
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchProducto = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchProducto.DataValue = "";
				mzComboSearchProducto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchProducto.SearchObject = typeof(mz.erp.ui.forms.classes.tsh_Productos);
				mzComboSearchProducto.Size = new System.Drawing.Size(496, 24);

				mzComboSearchProducto.Name = "mzComboSearchProducto"+Convert.ToString(order).Trim();
				mzComboSearchProducto.TabIndex = order;
				mzComboSearchProducto.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchProducto.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
				mzComboSearchProducto.ValueChanged+= new System.EventHandler( this.ValueChanged );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
					
				label.BackColor = System.Drawing.Color.Transparent;
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblProducto"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchProducto );

				if (defaultValue != null)
				{
					mzComboSearchProducto.DataValue= (string)defaultValue;
				}		
			}
			#endregion
			#region FiltroCuenta

			private void FiltroCuenta(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchCuenta.DataValue = "";
				mzComboSearchCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchCuenta.SearchObject = typeof( mz.erp.ui.forms.classes.tsa_Cuentas );
				mzComboSearchCuenta.Size = new System.Drawing.Size(496, 24);

				mzComboSearchCuenta.Name = "mzComboSearchCuenta"+Convert.ToString(order).Trim();
				mzComboSearchCuenta.TabIndex = order;
				mzComboSearchCuenta.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchCuenta.Location = new System.Drawing.Point(  iniX+desplazamientotexto, posicionY );
				mzComboSearchCuenta.ValueChanged+= new System.EventHandler( this.ValueChanged );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				
				label.BackColor = System.Drawing.Color.Transparent;
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura);
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblCuenta"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchCuenta );

				if (defaultValue != null)
				{
					mzComboSearchCuenta.DataValue= (string)defaultValue;
				}
				else
				{
					if(_uiController != null)
					{
						mzComboSearchCuenta.DataBindings.Add("DataValue",_uiController,propertyBinding);
					}
				}

			}
			#endregion
			#region FiltroTipoDeComprobanteAgrupado
			private void FiltroTipoDeComprobanteAgrupado(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				System.Windows.Forms.ComboBox comboBoxTipoDeCompAgrupados = new ComboBox();
				comboBoxTipoDeCompAgrupados.Items.AddRange(new object [] {Constantes.TodosLosComprobantes,"Facturas", "Presupuestos",/*"Notas de Débito",*/"Notas de Crédito","Prefacturas","Remitos","Pedidos","Confirmación de Pedido","Preremitos"});
				comboBoxTipoDeCompAgrupados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				comboBoxTipoDeCompAgrupados.Size = new System.Drawing.Size(300,24);
				
				comboBoxTipoDeCompAgrupados.Name = "comboBoxTipoDeCompAgrupados";
				comboBoxTipoDeCompAgrupados.TabIndex = order;
				comboBoxTipoDeCompAgrupados.TextChanged+= new System.EventHandler( this.ValueChanged );
				comboBoxTipoDeCompAgrupados.Enabled = enabled;
				int posicionY = iniY + (factordealtura * order);
				comboBoxTipoDeCompAgrupados.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;
				
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblTipoComprobanteAgrupado"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( comboBoxTipoDeCompAgrupados);
				comboBoxTipoDeCompAgrupados.SelectedItem = Constantes.TodosLosComprobantes;
				
				if (defaultValue != null)
				{
					comboBoxTipoDeCompAgrupados.SelectedItem = (string)defaultValue;
					_defaultValueComprobantesAgrupados = (string)defaultValue;
				}
				else
				{
					if(_uiController != null)
					{
						comboBoxTipoDeCompAgrupados.DataBindings.Add("Text",_uiController,propertyBinding);
						_defaultValueComprobantesAgrupados = _uiController.FamiliaComprobantes;
					}
				}

			}
			#endregion
			#region FiltroTipoDeComprobante
			private void FiltroTipoDeComprobante(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboTipoDeComprobante = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboTipoDeComprobante.DataValue = "";
				mzComboTipoDeComprobante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboTipoDeComprobante.SearchObject = typeof(mz.erp.ui.forms.classes.tsy_TiposDeComprobantes);
				mzComboTipoDeComprobante.Size = new System.Drawing.Size(496, 24);

				mzComboTipoDeComprobante.Name = "mzComboTipoDeComprobante"+Convert.ToString(order).Trim();
				mzComboTipoDeComprobante.TabIndex = order;
				mzComboTipoDeComprobante.ValueChanged+= new System.EventHandler( this.ValueChanged );
				mzComboTipoDeComprobante.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboTipoDeComprobante.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;
				
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblTipoComprobante"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboTipoDeComprobante);
				
				if (defaultValue != null)
				{
					mzComboTipoDeComprobante.DataValue= (string)defaultValue;
				}

			}
			#endregion
			#region FiltroPersona
			private void FiltroPersona(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				mz.erp.ui.controls.mzComboSearchEditor mzComboSearchPersona = new mz.erp.ui.controls.mzComboSearchEditor();
				mzComboSearchPersona.DataValue = "";
				mzComboSearchPersona.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				mzComboSearchPersona.SearchObject = typeof(mz.erp.ui.forms.classes.tsh_Personas);
				mzComboSearchPersona.Size = new System.Drawing.Size(496, 24);

				mzComboSearchPersona.Name = "mzComboSearchCuenta"+Convert.ToString(order).Trim();
				mzComboSearchPersona.TabIndex = order;
				mzComboSearchPersona.ValueChanged+= new System.EventHandler( this.ValueChanged );
				mzComboSearchPersona.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchPersona.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;
				
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblCuenta"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchPersona );
				if (defaultValue != null)
				{
					mzComboSearchPersona.DataValue= (string)defaultValue;
				}
				else
				{
					if(_uiController != null)
					{
						mzComboSearchPersona.DataBindings.Add("DataValue",_uiController,propertyBinding);
					}
				}

			}
			#endregion
			#region FiltroResponsable
			private void FiltroResponsable(int order, string leyenda, bool enabled, object defaultValue, string propertyBinding)
			{
				mz.erp.ui.controls.mzComboEditor mzComboSearchResponsable = new mzComboEditor();
				//mzComboSearchResponsable.FillFromDataSource = "";
				mzComboSearchResponsable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
				//mzComboSearchResponsable SearchObject
				mzComboSearchResponsable.Size = new System.Drawing.Size(496, 24);

				mzComboSearchResponsable.Name = "mzComboSearchResponsable"+Convert.ToString(order).Trim();
				mzComboSearchResponsable.TabIndex = order;
				mzComboSearchResponsable.ValueChanged+= new System.EventHandler( this.ValueChanged );
				mzComboSearchResponsable.Enabled = enabled;

				int posicionY = iniY + (factordealtura * order);
				mzComboSearchResponsable.Location = new System.Drawing.Point( iniX+desplazamientotexto, posicionY );

				System.Windows.Forms.Label label = new System.Windows.Forms.Label();
				label.Size = new System.Drawing.Size( desplazamientotexto, factordealtura );
				label.BackColor = System.Drawing.Color.Transparent;
				
				label.Text = leyenda;
				label.Location = new System.Drawing.Point( iniX, posicionY);
				label.Name = "lblCuenta"+Convert.ToString(order).Trim();
				this.ContainerFiltro.Controls.Add( label );
				this.ContainerFiltro.Controls.Add( mzComboSearchResponsable );

				mzComboSearchResponsable.FillFromDataSource(businessrules.data.UsuariosPersonas.GetList(), 
					"IdUsuario","Nombre",100,"ID","Nombre","Nombre");

				if(_uiController != null)
				{
					mzComboSearchResponsable.DataBindings.Add("Value", _uiController, propertyBinding);
				}

			}
			#endregion

		private void Init()
		{
			toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.onClick);						
			
				for (int i=0;i<=(_filtros.Count-1);i++)
				{
					ReportFilterItem unfiltro = _filtros[i];
					if ((unfiltro.Clave.ToUpper() == "ESTADODESTOCK"))
					{
						_parametros.Add( null );
						FiltroEstadoDeStock(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "SECCION"))
					{
						_parametros.Add( null );
						FiltroSeccion(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "DEPOSITO"))
					{
						_parametros.Add( null );
						FiltroDeposito(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "PRODUCTO"))
					{
						_parametros.Add( null );
						FiltroProducto(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "TIPODEAJUSTE"))
					{
						_parametros.Add( null );
						FiltroTipoDeAjuste(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "CUENTA"))
					{
						_parametros.Add( null );
						FiltroCuenta(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "PERSONA"))
					{
						_parametros.Add( null );
						FiltroPersona(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "RESPONSABLE"))
					{
						_parametros.Add( null );
						FiltroResponsable(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue , unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "FECHA"))
					{
						_parametros.Add( DateTime.Now );
						FiltroFecha(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding );
					}
					if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTE"))
					{
						_parametros.Add( null );
						FiltroTipoDeComprobante(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "TIPODECOMPROBANTEAGRUPADO"))
					{
						_parametros.Add( null );
						FiltroTipoDeComprobanteAgrupado(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "PROVEEDOR"))
					{
						_parametros.Add( null );
						FiltroProveedor(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "MONEDA"))
					{
						_parametros.Add( null );
						FiltroMoneda(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}
					if ((unfiltro.Clave.ToUpper() == "MOMENTO"))
					{
						_parametros.Add( null );
						FiltroMomento(i, unfiltro.Leyenda, unfiltro.Enabled, unfiltro.DefaultValue, unfiltro.PropertyBinding);
					}

				}
		}
		private void ValueChanged( object sender, System.EventArgs e)
		{
			if (sender.GetType() == typeof(mz.erp.ui.controls.mzComboSearchEditor))
			{
				_parametros[((Control)sender).TabIndex] = (string)((mz.erp.ui.controls.mzComboSearchEditor)sender).DataValue;
			}
			if (sender.GetType() == typeof(mz.erp.ui.controls.mzComboEditor))
			{
				_parametros[((Control)sender).TabIndex] = (string)((mz.erp.ui.controls.mzComboEditor)sender).Value;
			}

			if (sender.GetType() == typeof(Infragistics.Win.UltraWinSchedule.UltraCalendarCombo))
			{
				if (((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value == System.DBNull.Value)
				{
					_parametros[((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).TabIndex] = System.DateTime.MinValue;
				}
				else
				{
					_parametros[((Control)sender).TabIndex] = (System.DateTime)((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)sender).Value;
				}
			}
			if (sender.GetType() == typeof(System.Windows.Forms.ComboBox))
			{
				_parametros[((System.Windows.Forms.ComboBox)sender).TabIndex] =(string)((System.Windows.Forms.ComboBox)sender).Text ;
			}
			if (sender.GetType() == typeof(System.Windows.Forms.TextBox))
			{
				_parametros[((System.Windows.Forms.TextBox)sender).TabIndex] =(string)((System.Windows.Forms.TextBox)sender).Text ;
			}

		}

		protected void ResetUI()
		{					
			foreach(Control control in this.ContainerFiltro.Controls)
			{
				if (control.GetType() == typeof(mz.erp.ui.controls.mzComboSearchEditor))
				{
						((mz.erp.ui.controls.mzComboSearchEditor)control).DataValue ="";
				}
				if (control.GetType() == typeof(Infragistics.Win.UltraWinSchedule.UltraCalendarCombo))
				{
					object key = ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Name;					
					object valor = null;
					try
					{
						valor = this._defaultValues[key];
					}
					catch
					{
						valor = DateTime.Now;
					}
					
					((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value= valor;
				}
				if (control.GetType() == typeof(System.Windows.Forms.ComboBox))
				{
					((System.Windows.Forms.ComboBox)control).Text =_defaultValueComprobantesAgrupados ;
				}
			}
			gridResultado.SetDataBinding( null, null );
		}

		private void LoadDefaultValues() 
		{			
			foreach(Control control in this.ContainerFiltro.Controls)
			{
				if (control.GetType() == typeof(Infragistics.Win.UltraWinSchedule.UltraCalendarCombo))
				{
					object key = ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Name;
					object valor = ((Infragistics.Win.UltraWinSchedule.UltraCalendarCombo)control).Value;
					_defaultValues.Add(key, valor);
				}
			}
		}

		#endregion
	}
}

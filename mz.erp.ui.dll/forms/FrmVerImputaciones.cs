using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmVerImputaciones.
	/// </summary>
	public class FrmVerImputaciones : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneSaldo;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotal;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTipoDeComprobante;
		private System.Windows.Forms.Label label1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private Janus.Windows.GridEX.GridEX gridAsociaciones;
		private System.ComponentModel.IContainer components;

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmVerImputaciones));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneSaldo = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneTotal = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTipoDeComprobante = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridAsociaciones = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).BeginInit();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridAsociaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneSaldo);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneTotal);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumero);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label4);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label3);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtTipoDeComprobante);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(887, 95);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// uneSaldo
			// 
			this.uneSaldo.Location = new System.Drawing.Point(144, 72);
			this.uneSaldo.MaskInput = "$-nnnnnnnnn.nn";
			this.uneSaldo.Name = "uneSaldo";
			this.uneSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneSaldo.ReadOnly = true;
			this.uneSaldo.Size = new System.Drawing.Size(100, 21);
			this.uneSaldo.TabIndex = 3;
			// 
			// uneTotal
			// 
			this.uneTotal.Location = new System.Drawing.Point(144, 48);
			this.uneTotal.MaskInput = "$-nnnnnnnnn.nn";
			this.uneTotal.Name = "uneTotal";
			this.uneTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotal.ReadOnly = true;
			this.uneTotal.Size = new System.Drawing.Size(100, 21);
			this.uneTotal.TabIndex = 2;
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(144, 24);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.ReadOnly = true;
			this.txtNumero.Size = new System.Drawing.Size(240, 20);
			this.txtNumero.TabIndex = 1;
			this.txtNumero.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(0, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Total";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(0, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Saldo";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(0, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Número";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtTipoDeComprobante
			// 
			this.txtTipoDeComprobante.Location = new System.Drawing.Point(144, 0);
			this.txtTipoDeComprobante.Name = "txtTipoDeComprobante";
			this.txtTipoDeComprobante.ReadOnly = true;
			this.txtTipoDeComprobante.Size = new System.Drawing.Size(240, 20);
			this.txtTipoDeComprobante.TabIndex = 0;
			this.txtTipoDeComprobante.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipo de Comprobante";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.gridAsociaciones);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 203);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(887, 150);
			this.ultraExplorerBarContainerControl2.TabIndex = 1;
			// 
			// gridAsociaciones
			// 
			this.gridAsociaciones.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridAsociaciones.AlternatingColors = true;
			this.gridAsociaciones.AutomaticSort = false;
			this.gridAsociaciones.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridAsociaciones.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridAsociaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridAsociaciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridAsociaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridAsociaciones.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridAsociaciones.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridAsociaciones.GroupByBoxVisible = false;
			this.gridAsociaciones.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridAsociaciones.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridAsociaciones.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridAsociaciones.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridAsociaciones.Location = new System.Drawing.Point(0, 0);
			this.gridAsociaciones.Name = "gridAsociaciones";
			this.gridAsociaciones.RecordNavigator = true;
			this.gridAsociaciones.RecordNavigatorText = "Registro:|de";
			this.gridAsociaciones.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridAsociaciones.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both;
			this.gridAsociaciones.ShowEmptyFields = false;
			this.gridAsociaciones.Size = new System.Drawing.Size(887, 150);
			this.gridAsociaciones.TabIndex = 7;
			this.gridAsociaciones.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
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
																							  this.toolBarButton9});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(936, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 7;
			this.toolBarButton9.Text = "Salir";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 95;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Comprobante";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Imputaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(936, 393);
			this.ultraExplorerBar1.TabIndex = 19;
			// 
			// FrmVerImputaciones
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 421);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmVerImputaciones";
			this.Text = "FrmVerImputaciones";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneSaldo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneTotal)).EndInit();
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridAsociaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private string _idCuenta;
		private ItemCuentaCorriente _itemCuentaCorriente;
		private string _processName;
		#endregion

		#region Constructores y Destructores
		public FrmVerImputaciones(string IdCuenta, ItemCuentaCorriente icc, string ProcessName)
		{
			InitializeComponent();
			_idCuenta = IdCuenta;
			_itemCuentaCorriente = icc;
			_processName = ProcessName;
			Init();
		}

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
		#endregion

		#region Inicializadores y Carga
		
		private void Init()
		{
			Build_UI();
		}


		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}

		
		private void ConfigureInterface()
		{
			gridAsociaciones.LayoutData = new mz.erp.ui.forms.classes.tsa_CuentaCorriente().GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota","FechaEmision","FechaVencimiento","Numero", "Saldo","Signo","Pago"});
			Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridAsociaciones.RootTable.Columns["Signo"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,
				0);
			fc.FormatStyle.ForeColor=System.Drawing.Color.Red;
			fc.TargetColumn = this.gridAsociaciones.RootTable.Columns["Saldo"];
			this.gridAsociaciones.RootTable.FormatConditions.Add(fc);

		}

		private void InitializeData()
		{
			switch(this._processName)
			{
				case "ProcesoCuentaCorrienteCliente":
				{
					gridAsociaciones.DataSource = _itemCuentaCorriente.GetImputacionesCliente();				
					break;
				}
				case "ProcesoCuentaCorrienteClienteDV":
				{
					gridAsociaciones.DataSource = _itemCuentaCorriente.GetImputacionesCliente();
					break;
				}
				case "ProcesoCuentaCorrienteClienteConsolidada":
				{
					gridAsociaciones.DataSource = _itemCuentaCorriente.GetImputacionesCliente();
					break;
				}
				case "ProcesoCuentaCorrienteProveedor":
				{
					gridAsociaciones.DataSource = _itemCuentaCorriente.GetImputacionesProveedor();
					break;
				}
				case "ProcesoCuentaCorrienteProveedorDV":
				{
					gridAsociaciones.DataSource = _itemCuentaCorriente.GetImputacionesProveedor();
					break;
				}
				case "ProcesoCuentaCorrienteProveedoresConsolidada":
				{
					gridAsociaciones.DataSource = _itemCuentaCorriente.GetImputacionesProveedor();
					break;
				}
			}
					
			txtTipoDeComprobante.Text = _itemCuentaCorriente.Comprobante;
			txtNumero.Text = _itemCuentaCorriente.Numero;
			uneSaldo.Value = _itemCuentaCorriente.Saldo;
			uneTotal.Value = _itemCuentaCorriente.Importe;
			if(_itemCuentaCorriente.Signo == -1)
			{	
				uneSaldo.Appearance.ForeColor = System.Drawing.Color.Red;
				uneTotal.Appearance.ForeColor = System.Drawing.Color.Red;
			}

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);
            
		}	
	
		private void InitDataBindings()
		{
		}

		#endregion

		private void toolBarStandar_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					this.Close();
					break;
			}

		}
	}
}

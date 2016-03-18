using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using mz.erp.commontypes.data;
using mz.erp.businessrules;
using mz.erp.ui.forms.classes;
using mz.erp.systemframework;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripción breve de FrmCierreCaja.
	/// </summary>
	public class FrmCierreCaja : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Janus.Windows.GridEX.GridEX gridStandar;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolBarButton tbbCerrarCaja;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton tbbGuardar;

		private tfi_InstanciasCajaExDataset _data;
		private ArrayList _arrayCajas = new ArrayList();
		private string IdInstanciaCaja;
		private bool _requiereControlCaja = false;

		public FrmCierreCaja()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();
			mz.erp.ui.forms.classes.tfi_InstanciasCaja sourceUI= new mz.erp.ui.forms.classes.tfi_InstanciasCaja();
			this.gridStandar.LayoutData = sourceUI.GetLayout();
			
			DataTable table ;
			table= mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdPersona).Tables[0];
			Build_ArrayCajas(table);
			
			this.gridStandar.DataSource=_arrayCajas;
			this.tbbCerrarCaja.Enabled= true;
			this.tbbGuardar.Enabled= false;

			_requiereControlCaja = Variables.GetValueBool("Cajas.CierreCaja.RequiereControlCaja", _requiereControlCaja);
		}

		public void Build_ArrayCajas(DataTable table)
		{
			string _idCajas = Variables.GetValueString( "Cajas.Seguridad.Cerrar.Cajas" );
			string[] _cajas = _idCajas.Split( ',' );
			ArrayList _arrayCajasPuedeAbrir = new ArrayList( _cajas );
			foreach(DataRow row in table.Rows)
			{
				InstanciaCajaView insCajaView = new InstanciaCajaView();
				insCajaView.IdCaja = Convert.ToString(row["IdCaja"]);
				insCajaView.Descripcion = Convert.ToString(row["Descripcion"]);
				insCajaView.Apertura = Convert.ToDateTime(row["Apertura"]);
				//insCajaView.Cierre = Convert.ToDateTime(row["Cierre"]);
				insCajaView.IdResponsable = Convert.ToString(row["IdResponsable"]);
				insCajaView.Responsable = Convert.ToString(row["Responsable"]);
				insCajaView.IdInstanciaCaja = Convert.ToString(row["IdInstanciaCaja"]);
				if(insCajaView.IdResponsable.Equals(Security.IdPersona))
					_arrayCajas.Add(insCajaView);
				else
					if(_arrayCajasPuedeAbrir.Contains(insCajaView.IdCaja))
						_arrayCajas.Add(insCajaView);
			}

		}


		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					gridStandar.MoveFirst();
					break;

				case 1:
					gridStandar.MovePrevious();
					break;

				case 2:
					gridStandar.MoveNext();
					break;

				case 3:
					gridStandar.MoveLast();
					break;

				case 5: //"cerrar caja"
					if (this.gridStandar.SelectedItems.Count > 0) 
					{						
						InstanciaCajaView ins = (InstanciaCajaView)this.gridStandar.SelectedItems[0].GetRow().DataRow;
						if (ins != null) 
						{							
							IdInstanciaCaja = ins.IdInstanciaCaja;
							string mje = string.Empty;
							if(_requiereControlCaja)
                                mje = businessrules.AuditoriasControlCajas.GetInstance().PuedeCerrarCaja(IdInstanciaCaja);
							if(mje.Equals(string.Empty))
							{
								_data = mz.erp.businessrules.tfi_InstanciasCaja.CerrarCaja(IdInstanciaCaja);
								mz.erp.ui.forms.classes.tfi_InstanciasCaja sourceUI= new mz.erp.ui.forms.classes.tfi_InstanciasCaja();
								this.gridStandar.LayoutData = sourceUI.GetLayoutCierre();
								tfi_InstanciasCajaExDataset.Pr_tfi_InstanciasCaja_CierreCajaDataTable table = mz.erp.businessrules.tfi_InstanciasCaja.GetCierre(IdInstanciaCaja).Pr_tfi_InstanciasCaja_CierreCaja;
								this.gridStandar.DataSource = table;
								this.tbbCerrarCaja.Enabled= false;
								this.tbbGuardar.Enabled= true;
							}
							else
								MessageBox.Show("La caja no puede ser cerrada pues " + mje, "Error en cierre de caja");

						}
					}
					break;
				case 7: // "guardar" ; aparece despues de hacer "cerrar caja".
					_data = mz.erp.businessrules.tfi_InstanciasCaja.GuardarArqueoCaja(_data);
					Evaluate();	
					break;

										
			
			}
		}


		protected void Evaluate()
		{			
			bool hasErrors=false;
			foreach (System.Data.DataTable table in _data.Tables)
				foreach (System.Data.DataRow row in table.Rows)
				{

					if (row.HasErrors)
					{
						hasErrors=true;
						/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(row);
						_form.Show();
					}
					
				}
			if (!hasErrors)
			{
				MessageBox.Show("La acción se ha ejecutado con éxito");
				System.Data.DataSet data = mz.erp.businessrules.reportes.tfi_ReporteCierreCaja.GetCierreCaja(IdInstanciaCaja);
				ReportsManager.PrintReportCierreCaja(IdInstanciaCaja,this.MdiParent);
				Close();
			}
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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmCierreCaja));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.gridStandar = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.tbbCerrarCaja = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridStandar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridStandar);
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 49);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(599, 150);
			this.ultraExplorerBarContainerControl1.TabIndex = 0;
			// 
			// gridStandar
			// 
			this.gridStandar.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.gridStandar.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridStandar.AlternatingColors = true;
			this.gridStandar.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridStandar.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridStandar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridStandar.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridStandar.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridStandar.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridStandar.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aquí para agrupar por esa columna.";
			this.gridStandar.GroupByBoxVisible = false;
			this.gridStandar.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridStandar.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridStandar.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridStandar.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridStandar.Location = new System.Drawing.Point(0, 0);
			this.gridStandar.Name = "gridStandar";
			this.gridStandar.RecordNavigator = true;
			this.gridStandar.RecordNavigatorText = "Registro:|de";
			this.gridStandar.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridStandar.Size = new System.Drawing.Size(599, 150);
			this.gridStandar.TabIndex = 1;
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
																							  this.toolBarButton1,
																							  this.toolBarButton2,
																							  this.toolBarButton3,
																							  this.toolBarButton4,
																							  this.toolBarButton5,
																							  this.tbbCerrarCaja,
																							  this.toolBarButton7,
																							  this.tbbGuardar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(648, 28);
			this.toolBarStandar.TabIndex = 18;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);
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
			// tbbCerrarCaja
			// 
			this.tbbCerrarCaja.ImageIndex = 6;
			this.tbbCerrarCaja.Tag = "";
			this.tbbCerrarCaja.Text = "Cerrar Caja";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbGuardar
			// 
			this.tbbGuardar.ImageIndex = 4;
			this.tbbGuardar.Text = "Guardar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Cierre de caja";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(648, 329);
			this.ultraExplorerBar1.TabIndex = 19;
			// 
			// FrmCierreCaja
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 357);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmCierreCaja";
			this.Text = "Cierre de caja";
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridStandar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion




		
	}

	public class InstanciaCajaView
	{
		public InstanciaCajaView()
		{
		}

		private string _idCaja;
		private DateTime _apertura;
		private DateTime _cierre;
		private string _idResponsable;
		private string _responsable;
		private string _idInstanciaCaja;
		private string _descripcion;

		public string IdCaja
		{
			get{return _idCaja;}
			set{_idCaja = value;}
		}

		public DateTime Apertura
		{
			get{return _apertura;}
			set{_apertura = value;}
		}
		public DateTime Cierre
		{
			get{return _cierre;}
			set{_cierre = value;}
		}

		public string IdResponsable
		{
			get{return _idResponsable;}
			set{_idResponsable = value;}
		}

		public string Responsable
		{
			get{return _responsable;}
			set{_responsable = value;}
		}
		public string IdInstanciaCaja
		{
			get{return _idInstanciaCaja;}
			set{_idInstanciaCaja = value;}
		}

		public string Descripcion
		{
			get{return _descripcion;}
			set{_descripcion = value;}
		}
		
	}
}

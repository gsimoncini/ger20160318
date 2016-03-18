using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
using mz.erp.businessrules;

namespace mz.erp.ui.forms
{
	public class FrmAbmValores : mz.erp.ui.forms.FrmABMEx
	{
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNumero;
		private mz.erp.ui.controls.mzComboEditor mzCEMoneda;
		private mz.erp.ui.controls.mzComboEditor mzCEEntidad;
		private System.Windows.Forms.Timer timer1;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtFecha;
		private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtFechaVencimiento;
		private System.ComponentModel.IContainer components = null;
		private string _idTDCompTesoreria = "";
		private System.Windows.Forms.Label label7;
		private mz.erp.ui.controls.mzComboEditor mzCEComprobanteTesoreria;
		private string _idMoneda = "";

	//	private bool _save= false;
	
		private System.Data.DataRow _row; 
		private Valor _valor;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor txtValor;
		private System.Windows.Forms.Label lNumero;
		private System.Windows.Forms.Label lEntidad;
		private System.Windows.Forms.Label lFechaVencimiento;
		private System.Windows.Forms.Label lFecha;
		private System.Windows.Forms.Label lVariablesAuxiliares;
		//private ArrayList _cotizaciones;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneValorCotizado;
		private System.Windows.Forms.Label label1;
		private mz.erp.ui.controls.mzComboEditor mzCEMoneReferencia;
		private System.Windows.Forms.Label label2;

		public delegate void DataSetChangeEventHandler (System.Data.DataSet data, Valor valor);
		public event DataSetChangeEventHandler DataSetChange;

		private decimal  _defaultValue = 0;


		public FrmAbmValores()
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
		}

		
		public FrmAbmValores(System.Data.DataSet data/*, ArrayList cotizaciones*/)
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			_data = data;
			//_cotizaciones= cotizaciones;
		
		}


		public FrmAbmValores(System.Data.DataSet data, /*ArrayList cotizaciones,*/ decimal defaultValue)
		{
			// Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			_data = data;
			//_cotizaciones= cotizaciones;
			_defaultValue = defaultValue;
		}


		#region CustomMembers

		protected override void Init()
		{
			
			_businessRulesType = new mz.erp.businessrules.data.tfi_ValoresEx().GetType();
			base.Init();
		}		


		protected override void InitializeMembers()
		{
			
			txtNumero.MaxLength = 50;
			mzCEEntidad.FillFromDataSource( businessrules.tfi_Entidades.GetList().tfi_Entidades, "idEntidad", "Descripcion", 8, "1", "2", "Descripcion");
			mzCEMoneda.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");	
			mzCEComprobanteTesoreria.FillFromDataSource( businessrules.tfi_TDCompTesoreria.GetList().tfi_TDCompTesoreria, "idTDCompTesoreria", "Descripcion", 8, "1", "2", "Descripcion");	
			this.gridEX1.LayoutData= new mz.erp.ui.forms.classes.tfi_ValoresEx().GetLayout();
			
			mzCEComprobanteTesoreria.Value = Variables.GetValueString("Valores.ComprobanteTesoreria.Default");
			mzCEMoneda.Value = Variables.GetValueLong("Contabilidad.MonedaReferencia");
			mzCEMoneReferencia.FillFromDataSource( businessrules.tfi_Monedas.GetList().tfi_Monedas, "idMoneda", "Descripcion", 8, "1", "2", "Descripcion");	
			mzCEMoneReferencia.Value = Variables.GetValueLong("Contabilidad.MonedaReferencia");
			mzCEMoneReferencia.ReadOnly = true;
			txtValor.Focus();
			txtValor.SelectAll();
			
		}
		protected override void FillControls()
		{	
			
			if (_data != null)
			{
				try
				{	
					mz.erp.commontypes.data.tfi_ValoresExDataset data=(mz.erp.commontypes.data.tfi_ValoresExDataset) _data;
					txtFecha.Text=Convert.ToString( _row["Fecha"]);
					if (( string )_row["IdTDCompTesoreria"] != "")
					{
						mzCEComprobanteTesoreria.Value= _idTDCompTesoreria;
						 
						mzCEComprobanteTesoreria.Enabled= false;
					}
					
					txtNumero.Text =(string) _row["Numero"];
					if ((( string )_row["IdEntidad"]) != "")
						mzCEEntidad.Value = ( string )_row["IdEntidad"];
					
						
					txtFechaVencimiento.Text = Convert.ToString ((System.DateTime)_row["FechaVencimiento"]);
					
					if(_defaultValue != 0)
					{
						if(_defaultValue  < 0)
							txtValor.Value = 0;
						else
							txtValor.Value = _defaultValue;
					}
					else
						txtValor.Value = Convert.ToDecimal(_row["Valor"]);

					
					
					
					if ((( string )_row["IdMoneda"]) != "")
					{
						mzCEMoneda.Value= ( string )_row["IdMoneda"];
						_idMoneda = ( string )_row["IdMoneda"];
						mzCEMoneda.Enabled = false;
					}
					
					
					mz.erp.businessrules.data.tfi_ValoresEx.GetVariablesAuxiliares(data,(string)_row["IdValor"],(string)_row["IdTDCompTesoreria"]);
					
					this.gridEX1.DataSource =data.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria;
					this.gridEX1.RootTable.Columns[0].EditType=Janus.Windows.GridEX.EditType.NoEdit;
					this.gridEX1.RootTable.Columns[1].EditType=Janus.Windows.GridEX.EditType.NoEdit;
					this.gridEX1.RootTable.Columns[2].EditType=Janus.Windows.GridEX.EditType.NoEdit;
					_valor= Factory.GetValor((string)_row["IdValor"],(string)mzCEComprobanteTesoreria.Value,(string) mzCEComprobanteTesoreria.Text, (string)mzCEMoneda.Value, 
						(string)mzCEMoneda.Text, (string)mzCEEntidad.Value, mzCEEntidad.Text,txtNumero.Text, (DateTime)_row["Fecha"],
						(DateTime) _row["FechaVencimiento"], Convert.ToDecimal(txtValor.Value) );
					uneValorCotizado.Value = _valor.MontoCotizado;
					txtValor.Leave +=new EventHandler(txtValor_Leave);
					uneValorCotizado.Leave +=new EventHandler(uneValorCotizado_Leave);
					mzCEMoneda.ValueChanged +=new EventHandler(mzCEMoneda_ValueChanged);
					
				}
				catch(Exception e){
					Console.WriteLine(e.Message);
					;}
			}
		}
		
		protected override void DumpControls()
		{	
			if(Validar())
			{
				_row["IdTDCompTesoreria"] = mzCEComprobanteTesoreria.Value;
				_row["Numero"] = txtNumero.Text;
				_row["IdEntidad"] = mzCEEntidad.Value;
				_row["Fecha"] = Convert.ToDateTime(txtFecha.Text);
				_row["FechaVencimiento"] = Convert.ToDateTime(txtFechaVencimiento.Text);
				_row["Valor"] = Convert.ToDecimal(uneValorCotizado.Value);
				_row["IdMoneda"] =mzCEMoneda.Value;
				_row["IdCotizacionMoneda"] =_valor.IdCotizacion; 
				_valor.IdValor = Convert.ToString(_row["IdValor"]);
				_valor.IdTDCompTesoreria = Convert.ToString(mzCEComprobanteTesoreria.Value);
				_valor.Comprobante = Convert.ToString(mzCEComprobanteTesoreria.Text);
				_valor.IdMoneda = Convert.ToString(mzCEMoneda.Value);
				_valor.IdEntidad = Convert.ToString(mzCEEntidad.Value);
				_valor.Entidad = Convert.ToString( mzCEEntidad.Text);
				_valor.Numero = Convert.ToString(txtNumero.Text);
				_valor.Fecha =Convert.ToDateTime(_row["Fecha"]);
				_valor.FechaVencimiento = Convert.ToDateTime(_row["FechaVencimiento"]);
				
			
			}
	}

		private void ConfigUI()
		{
			mzCEComprobanteTesoreria.ValueChanged += new System.EventHandler(this.mzCEComprobanteTesoreria_ValueChanged);			
			
			string idValor = Convert.ToString(_row["IdValor"]);
			string idtdcomptesoreria = Convert.ToString(mzCEComprobanteTesoreria.Value);
			mz.erp.commontypes.data.tfi_ValoresExDataset data=(mz.erp.commontypes.data.tfi_ValoresExDataset) _data;
			
			
			mz.erp.businessrules.data.tfi_ValoresEx.GetVariablesAuxiliares( data, idValor, idtdcomptesoreria);
			this.gridEX1.DataSource =data.Pr_tfi_VariablesAuxiliaresWithValor_By_IdValorAndIdTDCompTesoreria;
			
			if (gridEX1.RowCount > 0)
			{
				gridEX1.Visible = true;
				lVariablesAuxiliares.Visible = true;
				this.gridEX1.CurrentTable.Columns[0].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				this.gridEX1.CurrentTable.Columns[1].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				this.gridEX1.CurrentTable.Columns[2].EditType=Janus.Windows.GridEX.EditType.NoEdit;
				
			}
			else
			{
				gridEX1.Visible = false;
				lVariablesAuxiliares.Visible = false;
			}
			if(_idTDCompTesoreria != "")
			{
				if (_idTDCompTesoreria.Equals(Constantes.IdBilletes))
				{
					mzCEEntidad.Visible=false;
					txtNumero.Visible=false;
					//gridEX1.Enabled=true;
					txtFecha.Visible=false;
					txtFechaVencimiento.Visible=false;
					lNumero.Visible = false;
					lFechaVencimiento.Visible = false;
					lFecha.Visible = false;
					
					lEntidad.Visible = false;
				}
				else
				{
					mzCEEntidad.Visible=true;
					txtNumero.Visible=true;
					//gridEX1.Enabled=true;
					txtFecha.Visible=true;
					txtFechaVencimiento.Visible=true;
					lNumero.Visible = true;
				
					lFecha.Visible = true;
					lFechaVencimiento.Visible = true;
					lEntidad.Visible = true;
				}
				txtValor.Focus();
			}
		}
		private bool Validar()
		{
			if(txtValor.Text =="")
			{
				MessageBox.Show("Debe ingresar el valor del Comprobante");
				return false;
			}
			return true;
		}
	



		public void ShowForm(object id, string caption , string IdTDCompTesoreria , string IdMoneda)
		{
			_idTDCompTesoreria = IdTDCompTesoreria;
			_idMoneda = IdMoneda;
			Init();
			if ( id == null ) 
				{
				New();
				this.Text = "Alta de " + caption;
				}
			else
				{
				Modify(id);
				this.Text = "Modificación de " + caption;
			}
			InitializeMembers();
			FillControls();
			MdiParent = mz.erp.ui.utility.Environment.MainForm;
			Show();

		}
		#endregion		
					


		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
				{
				if (components != null) 
					{
					components.Dispose();
					}
						
				base.Dispose( disposing );
				
				}
		}
				
		#region Código generado por el diseñador
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void   InitializeComponent()
	{
			this.components = new System.ComponentModel.Container();
			this.lNumero = new System.Windows.Forms.Label();
			this.lEntidad = new System.Windows.Forms.Label();
			this.lFechaVencimiento = new System.Windows.Forms.Label();
			this.lFecha = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.mzCEMoneda = new mz.erp.ui.controls.mzComboEditor();
			this.mzCEEntidad = new mz.erp.ui.controls.mzComboEditor();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.txtFecha = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.txtFechaVencimiento = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
			this.label7 = new System.Windows.Forms.Label();
			this.mzCEComprobanteTesoreria = new mz.erp.ui.controls.mzComboEditor();
			this.lVariablesAuxiliares = new System.Windows.Forms.Label();
			this.txtValor = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.uneValorCotizado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.mzCEMoneReferencia = new mz.erp.ui.controls.mzComboEditor();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEEntidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFecha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneReferencia)).BeginInit();
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.Size = new System.Drawing.Size(840, 28);
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.GroupSettings.ForceSerialization = true;
			this.ultraExplorerBar1.ItemSettings.ForceSerialization = true;
			this.ultraExplorerBar1.Margins.ForceSerialization = true;
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 – Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(840, 442);
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.BackColor = System.Drawing.SystemColors.Window;
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEMoneReferencia);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneValorCotizado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtValor);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lVariablesAuxiliares);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEComprobanteTesoreria);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label7);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtFechaVencimiento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtFecha);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridEX1);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.txtNumero);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEEntidad);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.mzCEMoneda);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label5);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label6);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lFechaVencimiento);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lFecha);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lEntidad);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.lNumero);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(791, 255);
			this.ultraExplorerBarContainerControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.ultraExplorerBarContainerControl1_Paint);
			// 
			// lNumero
			// 
			this.lNumero.BackColor = System.Drawing.Color.Transparent;
			this.lNumero.Location = new System.Drawing.Point(0, 64);
			this.lNumero.Name = "lNumero";
			this.lNumero.Size = new System.Drawing.Size(136, 20);
			this.lNumero.TabIndex = 0;
			this.lNumero.Text = "Número de Comprobante";
			// 
			// lEntidad
			// 
			this.lEntidad.BackColor = System.Drawing.Color.Transparent;
			this.lEntidad.Location = new System.Drawing.Point(0, 84);
			this.lEntidad.Name = "lEntidad";
			this.lEntidad.Size = new System.Drawing.Size(100, 21);
			this.lEntidad.TabIndex = 1;
			this.lEntidad.Text = "Entidad";
			// 
			// lFechaVencimiento
			// 
			this.lFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
			this.lFechaVencimiento.Location = new System.Drawing.Point(0, 126);
			this.lFechaVencimiento.Name = "lFechaVencimiento";
			this.lFechaVencimiento.Size = new System.Drawing.Size(136, 21);
			this.lFechaVencimiento.TabIndex = 3;
			this.lFechaVencimiento.Text = "Fecha de Vencimiento";
			// 
			// lFecha
			// 
			this.lFecha.BackColor = System.Drawing.Color.Transparent;
			this.lFecha.Location = new System.Drawing.Point(0, 105);
			this.lFecha.Name = "lFecha";
			this.lFecha.Size = new System.Drawing.Size(104, 21);
			this.lFecha.TabIndex = 2;
			this.lFecha.Text = "Fecha de Emisión";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(0, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 21);
			this.label5.TabIndex = 5;
			this.label5.Text = "Moneda";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(0, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 4;
			this.label6.Text = "Valor";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(160, 62);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(168, 20);
			this.txtNumero.TabIndex = 3;
			this.txtNumero.Text = "";
			this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
			// 
			// mzCEMoneda
			// 
			this.mzCEMoneda.DataSource = null;
			this.mzCEMoneda.DisplayMember = "";
			this.mzCEMoneda.DisplayMemberCaption = "";
			this.mzCEMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMoneda.Location = new System.Drawing.Point(160, 40);
			this.mzCEMoneda.MaxItemsDisplay = 7;
			this.mzCEMoneda.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMoneda.Name = "mzCEMoneda";
			this.mzCEMoneda.Size = new System.Drawing.Size(168, 21);
			this.mzCEMoneda.SorterMember = "";
			this.mzCEMoneda.TabIndex = 2;
			this.mzCEMoneda.ValueMember = "";
			this.mzCEMoneda.ValueMemberCaption = "";
			// 
			// mzCEEntidad
			// 
			this.mzCEEntidad.DataSource = null;
			this.mzCEEntidad.DisplayMember = "";
			this.mzCEEntidad.DisplayMemberCaption = "";
			this.mzCEEntidad.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEEntidad.Location = new System.Drawing.Point(160, 84);
			this.mzCEEntidad.MaxItemsDisplay = 7;
			this.mzCEEntidad.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEEntidad.Name = "mzCEEntidad";
			this.mzCEEntidad.Size = new System.Drawing.Size(168, 21);
			this.mzCEEntidad.SorterMember = "";
			this.mzCEEntidad.TabIndex = 4;
			this.mzCEEntidad.ValueMember = "";
			this.mzCEEntidad.ValueMemberCaption = "";
			this.mzCEEntidad.ValueChanged += new System.EventHandler(this.mzCEEntidad_ValueChanged);
			// 
			// gridEX1
			// 
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
			this.gridEX1.Location = new System.Drawing.Point(160, 145);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(512, 104);
			this.gridEX1.TabIndex = 7;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.gridEX1.Leave += new System.EventHandler(this.gridEX1_Leave);
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(160, 105);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(168, 21);
			this.txtFecha.TabIndex = 5;
			this.txtFecha.ValueChanged += new System.EventHandler(this.txtFecha_ValueChanged);
			// 
			// txtFechaVencimiento
			// 
			this.txtFechaVencimiento.Location = new System.Drawing.Point(160, 126);
			this.txtFechaVencimiento.Name = "txtFechaVencimiento";
			this.txtFechaVencimiento.Size = new System.Drawing.Size(168, 21);
			this.txtFechaVencimiento.TabIndex = 6;
			this.txtFechaVencimiento.ValueChanged += new System.EventHandler(this.txtFechaVencimiento_ValueChanged);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(0, -1);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 21);
			this.label7.TabIndex = 72;
			this.label7.Text = "Forma de Pago";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// mzCEComprobanteTesoreria
			// 
			this.mzCEComprobanteTesoreria.DataSource = null;
			this.mzCEComprobanteTesoreria.DisplayMember = "";
			this.mzCEComprobanteTesoreria.DisplayMemberCaption = "";
			this.mzCEComprobanteTesoreria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEComprobanteTesoreria.Location = new System.Drawing.Point(160, -1);
			this.mzCEComprobanteTesoreria.MaxItemsDisplay = 7;
			this.mzCEComprobanteTesoreria.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEComprobanteTesoreria.Name = "mzCEComprobanteTesoreria";
			this.mzCEComprobanteTesoreria.Size = new System.Drawing.Size(168, 21);
			this.mzCEComprobanteTesoreria.SorterMember = "";
			this.mzCEComprobanteTesoreria.TabIndex = 0;
			this.mzCEComprobanteTesoreria.ValueMember = "";
			this.mzCEComprobanteTesoreria.ValueMemberCaption = "";
			
			// 
			// lVariablesAuxiliares
			// 
			this.lVariablesAuxiliares.BackColor = System.Drawing.Color.Transparent;
			this.lVariablesAuxiliares.Location = new System.Drawing.Point(0, 152);
			this.lVariablesAuxiliares.Name = "lVariablesAuxiliares";
			this.lVariablesAuxiliares.Size = new System.Drawing.Size(152, 32);
			this.lVariablesAuxiliares.TabIndex = 74;
			this.lVariablesAuxiliares.Text = "Valores de Variables Auxliares";
			// 
			// txtValor
			// 
			this.txtValor.Location = new System.Drawing.Point(160, 20);
			this.txtValor.MinValue = 0;
			this.txtValor.Name = "txtValor";
			this.txtValor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.txtValor.Size = new System.Drawing.Size(168, 21);
			this.txtValor.TabIndex = 1;
			this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
			// 
			// uneValorCotizado
			// 
			this.uneValorCotizado.Location = new System.Drawing.Point(440, 18);
			this.uneValorCotizado.MinValue = 0;
			this.uneValorCotizado.Name = "uneValorCotizado";
			this.uneValorCotizado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneValorCotizado.Size = new System.Drawing.Size(168, 21);
			this.uneValorCotizado.TabIndex = 75;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(334, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 76;
			this.label1.Text = "Valor Destino";
			// 
			// mzCEMoneReferencia
			// 
			this.mzCEMoneReferencia.DataSource = null;
			this.mzCEMoneReferencia.DisplayMember = "";
			this.mzCEMoneReferencia.DisplayMemberCaption = "";
			this.mzCEMoneReferencia.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEMoneReferencia.Location = new System.Drawing.Point(440, 40);
			this.mzCEMoneReferencia.MaxItemsDisplay = 7;
			this.mzCEMoneReferencia.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEMoneReferencia.Name = "mzCEMoneReferencia";
			this.mzCEMoneReferencia.Size = new System.Drawing.Size(168, 21);
			this.mzCEMoneReferencia.SorterMember = "";
			this.mzCEMoneReferencia.TabIndex = 77;
			this.mzCEMoneReferencia.ValueMember = "";
			this.mzCEMoneReferencia.ValueMemberCaption = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(333, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 78;
			this.label2.Text = "Moneda Destino";
			// 
			// FrmAbmValores
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(840, 470);
			this.Name = "FrmAbmValores";
			this.Text = "Valores";
			this.Closed += new System.EventHandler(this.FrmAbmValores_Closed);
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneda)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEEntidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFecha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFechaVencimiento)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEComprobanteTesoreria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uneValorCotizado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEMoneReferencia)).EndInit();

		}
		#endregion


		private void label7_Click(object sender, System.EventArgs e)
		{
				
		}

		protected override void SaveChanges()
		{
			gridEX1.UpdateData();
			DumpControls();	
			
			_data= mz.erp.businessrules.data.tfi_ValoresEx.CargarValores(_data);
			_save = true;
			
			Close();
		}

		protected   override  void Modify(object IdValor)
		{
			_row = mz.erp.businessrules.data.tfi_ValoresEx.GetByPk(_data, (string) IdValor);
			_data = mz.erp.businessrules.data.tfi_ValoresEx.GetVariablesAuxiliaresAModificar((tfi_ValoresExDataset)_data, (string)_row["IdValor"],(string) _row["IdTDCompTesoreria"]);			
		}

		protected override void New()
		{
			try
				{
					_row= mz.erp.businessrules.data.tfi_ValoresEx.NewRow(_data, _idTDCompTesoreria, _idMoneda);
				}
			catch(Exception e)
			{
				System.Console.WriteLine(e.ToString());
			}
		}

		private void gridEX1_Leave(object sender, System.EventArgs e)
		{
			gridEX1.UpdateData();
		}

		private void FrmAbmValores_Closed(object sender, System.EventArgs e)
		{
			if (!_save) 
			{
				_data.Tables["tfi_Valores"].Rows.Remove(_row);
			}
			DataSetChange(_data, _valor );
		}

		private void mzCEComprobanteTesoreria_ValueChanged(object sender, System.EventArgs e)
		{
			_idTDCompTesoreria=(string)mzCEComprobanteTesoreria.Value;
			ConfigUI();
		}

		private void ultraExplorerBarContainerControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void mzCEEntidad_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtFecha_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtFechaVencimiento_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtNumero_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void txtValor_Leave(object sender, EventArgs e)
		{
			_valor.Monto = Convert.ToDecimal(txtValor.Value);
			uneValorCotizado.Value = _valor.MontoCotizado;
		}

		private void uneValorCotizado_Leave(object sender, EventArgs e)
		{
			_valor.MontoCotizado =Convert.ToDecimal( uneValorCotizado.Value);
			txtValor.Value = _valor.Monto;
		}

		private void mzCEMoneda_ValueChanged(object sender, EventArgs e)
		{
			_valor.IdMoneda = Convert.ToString(mzCEMoneda.Value);
			txtValor.Value = _valor.Monto;
			uneValorCotizado.Value = _valor.MontoCotizado;
		}

		private void txtValor_Click(object sender, System.EventArgs e)
		{
			txtValor.SelectAll();

		}
	}
}


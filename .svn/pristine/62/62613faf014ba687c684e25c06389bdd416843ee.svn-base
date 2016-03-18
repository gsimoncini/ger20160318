using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.businessrules;
using mz.erp.businessrules.comprobantes;
using mz.erp.ui.controllers;
using mz.erp.ui.forms.classes;
using mz.erp.ui.forms;


namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de mzProductosControl.
	/// Control utilizado para la seleccion de productos y su respectiva cantidad dependiendo de la
	/// medida por default
	/// </summary>
	public class mzProductosControl : System.Windows.Forms.UserControl//, IObservable Matias 20081229
	{
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneCantidad;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label lblInfoAdicional2;
		private System.Windows.Forms.Label lblInfoAdicional1;
		private System.Windows.Forms.Label labelUnidadOrigen;
		private System.Windows.Forms.Label labelCantidadDestino;
		private System.Windows.Forms.Label labelUnidadDestino;
		private System.Windows.Forms.Label labelFormula;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecio;


		#region Variables Privadas
			
		//Este deberia ser del tipo IItem para que sea generico y sirva para todos los comprobantes

		private string  _momento;		
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor unePrecioUnidadOrigen;
		private System.Windows.Forms.Button buttonElipsis;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor editorID;
		private ArrayList _selectedItems = new ArrayList();
		
		#endregion

		private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDescripcion;


		#region Propiedades
			
		public ArrayList SelectedItems
		{
			get
			{
				return _selectedItems;
			}
		}

		public string Momento
		{
			set
			{
				_momento = value;
				_uicontroller.Momento = this._momento;	
			}
		}
		
		public bool EnabledCantidad 
		{
			get 
			{
				return this.uneCantidad.Enabled;
			}
			
			set 
			{
				//_enabledCantidad = value;
				this.uneCantidad.Enabled = value;
			}			
		}

		//private bool _enabledListaDePrecio = true;
		public bool EnabledListaDePrecio
		{
			get 
			{
				return mzComboListaDePrecios.Enabled;
			}
			set 
			{
				mzComboListaDePrecios.Enabled = value;
			}
		}



		public bool ReadOnlyCantidad
		{
			set
			{
				this.uneCantidad.ReadOnly = value;
			}
		}

		private bool _visiblePrecios = true;
		private System.Windows.Forms.Label lblCodigoSecundario;
	
		public bool VisiblePrecios 
		{
			get {return _visiblePrecios;}
			set 
			{
				_visiblePrecios = value;
				this.unePrecioUnidadOrigen.Visible = value;
				this.unePrecio.Visible = value;
			}
		}

		private bool _visibleComboListaDePrecios = true;
	
		public bool VisibleComboListaDePrecios
		{
			get {return _visibleComboListaDePrecios;}
			set 
			{
				_visibleComboListaDePrecios = value;
				this.mzComboListaDePrecios.Visible = value;
			}
		}
		
		private bool _visibleComboTipoDePrecioDeCosto = false;
	
		public bool VisibleComboTipoDePrecioDeCosto
		{
			get {return _visibleComboTipoDePrecioDeCosto;}
			set 
			{
				_visibleComboTipoDePrecioDeCosto = value;
				this.cboTipoDePrecioDeCosto.Visible = value;
			}
		}

		private bool _visibleCantidad = true;	
		public bool VisibleCantidad
		{
			get {return _visibleCantidad;}
			set 
			{
				_visibleCantidad = value;
				this.uneCantidad.Visible = value;
			}
			
		}

        //Sabrina: Tarea 1080. 20110326
        public bool PermiteProductosCombo
        {
            get { return _uicontroller.PermiteProductosCombo; }
            set { _uicontroller.PermiteProductosCombo = value; }

        }
        //Fin Sabrina: Tarea 1080. 20110326
		#endregion

		#region Eventos
		
		public event EventHandler SingleSelectionProducto;
		public event EventHandler MultipleSelectionProducto;

		private mz.erp.ui.controllers.mzProductosControlController _uicontroller = new mz.erp.ui.controllers.mzProductosControlController();
		private string _taskName = "";
		private mz.erp.ui.controls.mzComboEditor mzComboListaDePrecios;
		private System.Windows.Forms.ComboBox cboTipoDePrecioDeCosto;
		private string _processName = "";
		//esta variable indica si el control esta en un form de compras (C) o ventas (V)
		private string _tipoDeFormularioPadre = "V";
		#endregion

		#region constructor
		public mzProductosControl()

		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);    
			
			Init();
			

			// TODO: agregar cualquier inicialización después de llamar a InitializeComponent

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

		#region Código generado por el Diseñador de componentes
		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.uneCantidad = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.lblInfoAdicional2 = new System.Windows.Forms.Label();
            this.lblInfoAdicional1 = new System.Windows.Forms.Label();
            this.labelUnidadOrigen = new System.Windows.Forms.Label();
            this.labelCantidadDestino = new System.Windows.Forms.Label();
            this.labelUnidadDestino = new System.Windows.Forms.Label();
            this.labelFormula = new System.Windows.Forms.Label();
            this.unePrecio = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.unePrecioUnidadOrigen = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.buttonElipsis = new System.Windows.Forms.Button();
            this.editorID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtDescripcion = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.lblCodigoSecundario = new System.Windows.Forms.Label();
            this.mzComboListaDePrecios = new mz.erp.ui.controls.mzComboEditor();
            this.cboTipoDePrecioDeCosto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioUnidadOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // uneCantidad
            // 
            this.uneCantidad.Location = new System.Drawing.Point(407, 8);
            this.uneCantidad.MaskInput = "nnnnnn.nn";
            this.uneCantidad.MaxValue = 10000000;
            this.uneCantidad.MinValue = 0;
            this.uneCantidad.Name = "uneCantidad";
            this.uneCantidad.Nullable = true;
            this.uneCantidad.NullText = "0";
            this.uneCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.uneCantidad.Size = new System.Drawing.Size(72, 21);
            this.uneCantidad.TabIndex = 1;
            this.uneCantidad.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.uneCantidad.Value = 1D;
            // 
            // lblInfoAdicional2
            // 
            this.lblInfoAdicional2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfoAdicional2.Location = new System.Drawing.Point(144, 50);
            this.lblInfoAdicional2.Name = "lblInfoAdicional2";
            this.lblInfoAdicional2.Size = new System.Drawing.Size(264, 21);
            this.lblInfoAdicional2.TabIndex = 10;
            // 
            // lblInfoAdicional1
            // 
            this.lblInfoAdicional1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfoAdicional1.Location = new System.Drawing.Point(8, 50);
            this.lblInfoAdicional1.Name = "lblInfoAdicional1";
            this.lblInfoAdicional1.Size = new System.Drawing.Size(136, 21);
            this.lblInfoAdicional1.TabIndex = 9;
            this.lblInfoAdicional1.Click += new System.EventHandler(this.lblInfoAdicional1_Click);
            // 
            // labelUnidadOrigen
            // 
            this.labelUnidadOrigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUnidadOrigen.Location = new System.Drawing.Point(479, 8);
            this.labelUnidadOrigen.Name = "labelUnidadOrigen";
            this.labelUnidadOrigen.Size = new System.Drawing.Size(56, 21);
            this.labelUnidadOrigen.TabIndex = 11;
            this.labelUnidadOrigen.Click += new System.EventHandler(this.labelUnidadOrigen_Click);
            // 
            // labelCantidadDestino
            // 
            this.labelCantidadDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCantidadDestino.Location = new System.Drawing.Point(407, 29);
            this.labelCantidadDestino.Name = "labelCantidadDestino";
            this.labelCantidadDestino.Size = new System.Drawing.Size(72, 21);
            this.labelCantidadDestino.TabIndex = 12;
            this.labelCantidadDestino.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelUnidadDestino
            // 
            this.labelUnidadDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUnidadDestino.Location = new System.Drawing.Point(479, 29);
            this.labelUnidadDestino.Name = "labelUnidadDestino";
            this.labelUnidadDestino.Size = new System.Drawing.Size(56, 21);
            this.labelUnidadDestino.TabIndex = 13;
            this.labelUnidadDestino.Click += new System.EventHandler(this.labelUnidadDestino_Click);
            // 
            // labelFormula
            // 
            this.labelFormula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFormula.Location = new System.Drawing.Point(408, 48);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(128, 21);
            this.labelFormula.TabIndex = 14;
            this.labelFormula.Click += new System.EventHandler(this.labelFormula_Click);
            // 
            // unePrecio
            // 
            this.unePrecio.FormatString = "c";
            this.unePrecio.Location = new System.Drawing.Point(704, 29);
            this.unePrecio.MinValue = -2147483647D;
            this.unePrecio.Name = "unePrecio";
            this.unePrecio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecio.Size = new System.Drawing.Size(64, 21);
            this.unePrecio.TabIndex = 4;
            this.unePrecio.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.unePrecio.TabStop = false;
            this.unePrecio.ValueChanged += new System.EventHandler(this.unePrecio_ValueChanged);
            // 
            // unePrecioUnidadOrigen
            // 
            this.unePrecioUnidadOrigen.FormatString = "c";
            this.unePrecioUnidadOrigen.Location = new System.Drawing.Point(704, 8);
            this.unePrecioUnidadOrigen.MinValue = -2147483647D;
            this.unePrecioUnidadOrigen.Name = "unePrecioUnidadOrigen";
            this.unePrecioUnidadOrigen.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
            this.unePrecioUnidadOrigen.Size = new System.Drawing.Size(64, 21);
            this.unePrecioUnidadOrigen.TabIndex = 3;
            this.unePrecioUnidadOrigen.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl;
            this.unePrecioUnidadOrigen.TabStop = false;
            // 
            // buttonElipsis
            // 
            this.buttonElipsis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonElipsis.Location = new System.Drawing.Point(120, 8);
            this.buttonElipsis.Name = "buttonElipsis";
            this.buttonElipsis.Size = new System.Drawing.Size(25, 22);
            this.buttonElipsis.TabIndex = 18;
            this.buttonElipsis.TabStop = false;
            this.buttonElipsis.Text = "...";
            this.buttonElipsis.Click += new System.EventHandler(this.buttonElipsis_Click);
            // 
            // editorID
            // 
            this.editorID.AcceptsTab = true;
            this.editorID.Location = new System.Drawing.Point(8, 8);
            this.editorID.Name = "editorID";
            this.editorID.Size = new System.Drawing.Size(110, 21);
            this.editorID.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(144, 8);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(264, 42);
            this.txtDescripcion.TabIndex = 20;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.ValueChanged += new System.EventHandler(this.txtDescripcion_ValueChanged);
            // 
            // lblCodigoSecundario
            // 
            this.lblCodigoSecundario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoSecundario.Location = new System.Drawing.Point(8, 29);
            this.lblCodigoSecundario.Name = "lblCodigoSecundario";
            this.lblCodigoSecundario.Size = new System.Drawing.Size(136, 21);
            this.lblCodigoSecundario.TabIndex = 21;
            // 
            // mzComboListaDePrecios
            // 
            this.mzComboListaDePrecios.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            this.mzComboListaDePrecios.DisplayMember = "";
            this.mzComboListaDePrecios.DisplayMemberCaption = "";
            this.mzComboListaDePrecios.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
            this.mzComboListaDePrecios.Location = new System.Drawing.Point(536, 8);
            this.mzComboListaDePrecios.MaxItemsDisplay = 7;
            this.mzComboListaDePrecios.MoreItemsDisplayText = "(Ver mas elementos...)";
            this.mzComboListaDePrecios.Name = "mzComboListaDePrecios";
            this.mzComboListaDePrecios.Size = new System.Drawing.Size(168, 21);
            this.mzComboListaDePrecios.SorterMember = "";
            this.mzComboListaDePrecios.TabIndex = 1813;
            this.mzComboListaDePrecios.ValueMember = "";
            this.mzComboListaDePrecios.ValueMemberCaption = "";
            // 
            // cboTipoDePrecioDeCosto
            // 
            this.cboTipoDePrecioDeCosto.Location = new System.Drawing.Point(536, 8);
            this.cboTipoDePrecioDeCosto.Name = "cboTipoDePrecioDeCosto";
            this.cboTipoDePrecioDeCosto.Size = new System.Drawing.Size(168, 21);
            this.cboTipoDePrecioDeCosto.TabIndex = 2;
            this.cboTipoDePrecioDeCosto.Tag = "TiposDeComprobantes";
            // 
            // mzProductosControl
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cboTipoDePrecioDeCosto);
            this.Controls.Add(this.mzComboListaDePrecios);
            this.Controls.Add(this.lblCodigoSecundario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.buttonElipsis);
            this.Controls.Add(this.editorID);
            this.Controls.Add(this.unePrecioUnidadOrigen);
            this.Controls.Add(this.unePrecio);
            this.Controls.Add(this.labelFormula);
            this.Controls.Add(this.labelUnidadDestino);
            this.Controls.Add(this.labelCantidadDestino);
            this.Controls.Add(this.labelUnidadOrigen);
            this.Controls.Add(this.lblInfoAdicional2);
            this.Controls.Add(this.lblInfoAdicional1);
            this.Controls.Add(this.uneCantidad);
            this.Name = "mzProductosControl";
            this.Size = new System.Drawing.Size(776, 80);
            this.Load += new System.EventHandler(this.mzProductosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uneCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unePrecioUnidadOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mzComboListaDePrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void SingleSelectionListener(  object sender, System.EventArgs e )
		{
			
			unePrecioUnidadOrigen.DataBindings.Clear();
			unePrecioUnidadOrigen.DataBindings.Add( "Value", _uicontroller, "PrecioUnidadOrigen" );
			unePrecio.DataBindings.Clear();
			unePrecio.DataBindings.Add("Value", _uicontroller, "PrecioUnidadDestino");
			uneCantidad.DataBindings.Clear();
			uneCantidad.DataBindings.Add( "Value",_uicontroller,"Cantidad");
			//uneCantidad.ReadOnly=false;
			unePrecio.ReadOnly = true;
			unePrecioUnidadOrigen.ReadOnly = true;
			labelUnidadOrigen.Text = _uicontroller.UnidadOrigen;
			labelUnidadDestino.Text = _uicontroller.UnidadDestino;
			string valorConversion = Convert.ToString(_uicontroller.ValorConversion);
			string formulaConversion =  valorConversion +" " +_uicontroller.UnidadOrigen + " = " +  "1 " + _uicontroller.UnidadDestino;
			labelFormula.Text = formulaConversion;
			labelCantidadDestino.DataBindings.Clear();
			labelCantidadDestino.DataBindings.Add("Text",_uicontroller,"CantidadDestino");
			lblInfoAdicional1.Text= "Stock Propio: "+ Convert.ToString(Math.Round(_uicontroller.Stock,0));
			lblInfoAdicional2.Text= _uicontroller.NombreCampoAuxiliar1+ " "+ _uicontroller.CampoAuxiliar1 + "; "+ _uicontroller.NombreCampoAuxiliar2+ " "+_uicontroller.CampoAuxiliar2;
			lblCodigoSecundario.Text = _uicontroller.CodigoSec;
			this.editorID.DataBindings.Clear();
			this.txtDescripcion.DataBindings.Clear();
			this.editorID.DataBindings.Add( "Text", _uicontroller, "Codigo_Search");
			this.txtDescripcion.DataBindings.Add( "Text", _uicontroller, "Descripcion");
			this.mzComboListaDePrecios.DataBindings.Clear();
			this.mzComboListaDePrecios.DataBindings.Add("Value", _uicontroller, "IdListaDePrecios_Search");

			this.cboTipoDePrecioDeCosto.DataBindings.Clear();
			this.cboTipoDePrecioDeCosto.DataBindings.Add("Text", _uicontroller, "TipoDePrecioDeCosto_Search");
		}
		private void MultipleSelectionListener( object sender, System.EventArgs e)
		{
			/*
			this._selectedItems.Clear();
			foreach(mz.erp.businessrules.comprobantes.Item _miItem in _uicontroller.SelectedItems)
			{
				_selectedItems.Add(_miItem);
			}
			*/
			if(_uicontroller.SelectedItems.Count > 1)
			{
				if(MultipleSelectionProducto != null)
					MultipleSelectionProducto(_uicontroller.SelectedItems, new EventArgs());
				ProcessObjectsObserver();
			}
			ResetBindings();
			
		}
		
		public void Init()
		{						
			Build_UI();
			InitEvents();
			InitDataBindings();
		}


		private string _idProveedor = "";
		public void SetIdProveedor(string IdProveedor)
		{
			_idProveedor = IdProveedor;
			_uicontroller.SetIdProveedor(IdProveedor);			

			cboTipoDePrecioDeCosto.Items.Clear();
			cboTipoDePrecioDeCosto.Items.AddRange( _uicontroller.TiposDePrecioDeCosto.ToArray());
			cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCostoDefault;
			this.cboTipoDePrecioDeCosto.Enabled = cboTipoDePrecioDeCosto.Items.Count >1;					
		}

		public void SetIdProducto(string IdProducto)
		{
			_uicontroller.IdProducto = IdProducto;
			commontypes.data.tsh_ProductosDataset.tsh_ProductosRow rowP = businessrules.tsh_Productos.GetByPk(IdProducto);
			if(rowP != null)
			{
				string CodigoProd = rowP.Codigo;
				editorID.Text = CodigoProd;
				editorID_Leave(this, new EventArgs());
			}
		}

		public string GetIdProducto()
		{
			return _uicontroller.IdProducto;
		}
		public void SetProcess(string ProcessName, string TaskName, string TipoDeFormularioPadre)
		{
			_processName = ProcessName;
			_taskName = TaskName;
			_tipoDeFormularioPadre = TipoDeFormularioPadre;
			_uicontroller.SetProcess(_processName, _taskName, _tipoDeFormularioPadre);			

			mzComboListaDePrecios.FillFromDataSource( _uicontroller.ListaDePrecios, _uicontroller.KeyValueListaDePrecios, _uicontroller.KeyListListaDePrecios, 100, _uicontroller.KeyListListaDePrecios);
			mzComboListaDePrecios.Value = _uicontroller.IdListaDePreciosDefault;
			
			// Matias 20090102
			//this.mzComboListaDePrecios.Enabled = _uicontroller.ListaDePreciosHabilitadas;	
			this.mzComboListaDePrecios.Enabled = _uicontroller.PermiteListaDePreciosDistintas;
			// -----

		
			if(_tipoDeFormularioPadre.Equals("C"))
			{
				this.VisiblePrecios = false;
				this.VisibleComboListaDePrecios = false;
				this.VisibleComboTipoDePrecioDeCosto = true;

			}
			else
			{
				this.VisibleComboTipoDePrecioDeCosto = false;
			}


		}


		private void Build_UI()
		{
			this.BackColor = Color.Transparent;
			this.uneCantidad.ReadOnly = false;
			this.uneCantidad.Enabled = false;
			//this.uneCantidad.Value = 0;
			this.uneCantidad.Select();			
			cboTipoDePrecioDeCosto.Visible = this._visibleComboTipoDePrecioDeCosto;

            //German 20120130 - Tarea 0000269
            this.unePrecio.MinValue = -2147483647D;
            this.unePrecioUnidadOrigen.MinValue = -2147483647D;
            //Fin German 20120130 - Tarea 0000269
		}

		private void InitEvents()
		{
			
			_uicontroller.SingleSelectionProducto+= new System.EventHandler( this.SingleSelectionListener );
			_uicontroller.MultipleSelectionProducto+= new System.EventHandler( this.MultipleSelectionListener );
			uneCantidad.Enter +=new EventHandler(uneCantidad_Enter);
			//German 20090824
			//uneCantidad.KeyUp +=new KeyEventHandler(uneCantidad_KeyUp);
			//Fin German 20090824
			uneCantidad.KeyDown += new KeyEventHandler(KeyDownEnter);
			mzComboListaDePrecios.ValueChanged +=new EventHandler(mzComboListaDePrecios_ValueChanged);
			mzComboListaDePrecios.KeyDown +=new KeyEventHandler(mzComboListaDePrecios_KeyDown);
			cboTipoDePrecioDeCosto.KeyDown +=new KeyEventHandler(cboTipoDePrecioDeCosto_KeyDown);
			this.editorID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editorID_KeyUp);
			this.editorID.Leave += new System.EventHandler(this.editorID_Leave);
			
		}

		private void InitDataBindings()
		{

			//this.editorID.DataBindings.Add( "Text", _uicontroller, "Codigo_Search");
			//this.txtDescripcion.DataBindings.Add( "Text", _uicontroller, "Descripcion");

			// Matias 
			this.mzComboListaDePrecios.DataBindings.Clear();
			this.mzComboListaDePrecios.DataBindings.Add("Value", _uicontroller, "IdListaDePrecios_Search");
		}
		
		private void ResetBindings()
		{
			#region clear Databindings
			unePrecio.DataBindings.Clear();
			uneCantidad.DataBindings.Clear();
			unePrecioUnidadOrigen.DataBindings.Clear();
			labelCantidadDestino.DataBindings.Clear();
			editorID.DataBindings.Clear();
			txtDescripcion.DataBindings.Clear();

			#endregion


			#region reset values
			unePrecio.Value = 0;

			uneCantidad.Value = 1;
			//uneCantidad.Value = 0;

			unePrecioUnidadOrigen.Value = 0;
			labelUnidadOrigen.Text = "";
			labelUnidadDestino.Text = "";
			labelFormula.Text = "";
			lblCodigoSecundario.Text = "";
			lblInfoAdicional1.Text= "";			
			lblInfoAdicional2.Text="";
			labelCantidadDestino.Text = "0";
            /* Silvina 20110217 - Tarea 0000018 */
			//editorID.Text = "";
            /* Fin Silvina 20110217 - Tarea 0000018 */
			txtDescripcion.Text = "";
			//German 20090331
			
			//editorID.Focus();
            if (encontrado)
            /* Silvina 20110427 - Tarea 0000018 */
            {
                editorID.Text = "";
                editorID.Focus();
            }
            /* Fin Silvina 20110427 - Tarea 0000018 */
			//Fin German 20090331
			if(_uicontroller.IdListaDePrecios_Search == null || _uicontroller.IdListaDePrecios_Search.Equals(string.Empty))
				mzComboListaDePrecios.Value = _uicontroller.IdListaDePreciosDefault;
			else
				mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecios_Search;

			if(_uicontroller.TipoDePrecioDeCosto_Search == null || _uicontroller.TipoDePrecioDeCosto_Search.Equals(string.Empty))
				cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCostoDefault;
			else
				cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCosto_Search;
			#endregion

		}

		public void ClearControl()
		{
			this.ResetBindings();
		}
		

		private void KeyDownEnter(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			
			if(e.KeyCode == System.Windows.Forms.Keys.Enter)
			{
				//German 20090824
				if ((_uicontroller.SelectedItems.Count == 1) && uneCantidad.Value != null 
					&& uneCantidad.Value != System.DBNull.Value &&(Convert.ToDecimal(uneCantidad.Value) > 0) )
				{
					if(uneCantidad.Value != null && uneCantidad.Value != System.DBNull.Value)
						_uicontroller.Cantidad = Convert.ToDecimal(uneCantidad.Value);
					else
					{
						_uicontroller.Cantidad = 0;
						uneCantidad.SelectAll();
					}
					//Fin German 20090824
					if(_uicontroller.MostrarSugerencias())//Variable de Sistema q controla si se muestra la vebatana de porcenatajes sugeridos
					{
						FrmPorcentajeAdicionalMedidaSugerido frmpams = new FrmPorcentajeAdicionalMedidaSugerido(_uicontroller.Item.Conversion);
						frmpams.ShowDialog();
					}
					if(SingleSelectionProducto != null)
						SingleSelectionProducto(_uicontroller.Item,new EventArgs());
					ProcessObjectsObserver();
					// Matias
					//_uicontroller.ProcessObjectsObserver();
					// -------------
					ResetBindings();
					if(_uicontroller.ListaDePreciosHabilitadas)
					{
						if(_uicontroller.VolverAListaDePreciosDefault)
							mzComboListaDePrecios.Value = _uicontroller.IdListaDePreciosDefault;
					}
				}
			
			}
			

		}

		private void uneCantidad_Enter(object sender, System.EventArgs e)
		{
			uneCantidad.Focus();
			uneCantidad.SelectAll();
		}

		






		//German 20090824
		/*
		private void uneCantidad_KeyUp(object sender, KeyEventArgs e)
		{
			if(uneCantidad.Value != null && uneCantidad.Value != System.DBNull.Value)
				_uicontroller.Cantidad = Convert.ToDecimal(uneCantidad.Value);
			else
			{
				_uicontroller.Cantidad = 0;
				uneCantidad.SelectAll();
			}
		}
		*/
		//Fin German 20090824

		
		private void editorID_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			encontrado = false;
			if(e.KeyCode == System.Windows.Forms.Keys.F2)
			{
				BuscadorAuxiliar();
				if (_uicontroller.IsValid == true)
				{
					encontrado = true;
					uneCantidad.Focus();				
				}				
			}
			else 
			{
				if (e.KeyCode == System.Windows.Forms.Keys.Enter) 
				{
					encontrado = false;
					editorID_Leave(sender, e);
				}
				/*
					else
					{
						if (e.KeyCode == System.Windows.Forms.Keys.Tab)
						{
							encontrado = false;
							editorID_Leave(sender, e);

					
						}
					}
					*/
			}
			
		}

		private void buttonElipsis_Click(object sender, System.EventArgs e)
		{
			BuscadorAuxiliar();
		}
		private void BuscadorAuxiliar()
		{			
			//_uicontroller.BuscadorAuxiliar();
			_uicontroller.SelectedItems.Clear();			
			mzProductosSearchForm sf = new mzProductosSearchForm(true/*cierreAutomat*/,true/*SeleccMult*/);		
			sf.SetProcess(_processName, _taskName, _tipoDeFormularioPadre);
			sf.SetIdProveedor(_idProveedor);
			sf.SelectedListaDePrecios = (string)mzComboListaDePrecios.Value;	
			sf.SelectedTipoDePrecioDeCosto = cboTipoDePrecioDeCosto.Text;
            //Sabrina: Tarea 1080. 20110326
            sf.PermiteProductosCombo = this.PermiteProductosCombo;
            //Fin Sabrina: Tarea 1080. 20110326
			sf.ShowDialog();			
			if (sf.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				_uicontroller.Descripcion = sf.SelectedDescription;
				_uicontroller.Codigo_Search = sf.SelectedValue;
				_uicontroller.IdListaDePrecios_Search = sf.SelectedListaDePrecios;
				_uicontroller.TipoDePrecioDeCosto_Search = sf.SelectedTipoDePrecioDeCosto;
				if (sf.SelectedItems.Count >= 2)
				{
					foreach ( string idproducto in sf.SelectedItems)
					{
						_uicontroller.AddItem( idproducto );
					}
					_uicontroller.RefreshMultiple();
				}
				else
				{
					if (sf.SelectedItems.Count == 1)
					{
						_uicontroller.AddItem( (string)sf.SelectedItems[0] );
						_uicontroller.Lastcode_search = _uicontroller.Codigo_Search;					
						_uicontroller.RefreshSingle();						
					}
				}
				_uicontroller.IsValid = true;
			}
			else
			{
				_uicontroller.IsValid = false; 
				_uicontroller.ErrorMessage = string.Empty;
			}

			if (!_uicontroller.IsValid)
			{
				ResetBindings();
			}
			editorID.Focus();
			//uneCantidad.Focus();
		}


		private void BuscarAhora(Control target)
		{	
		
			_uicontroller.SetOrdenBusqueda();
			_uicontroller.IdListaDePrecios_Search = (string) mzComboListaDePrecios.Value;
			encontrado = false;
			foreach(string cod in _uicontroller.OrdenDeBusqueda)
			{
				if(cod.Equals(string.Empty)|| cod.ToUpper().Equals("CODIGO"))
				{
					_uicontroller.Codigo_Search = editorID.Text;			
					_uicontroller.BuscarAhora();
					if (_uicontroller.ListaDePreciosHabilitadas == true)
						mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecios_Search;
					if(_uicontroller.IsValid)
					{
						encontrado = true;
						break;
					}
				}
				if(cod.ToUpper().Equals("CODIGOSECUNDARIO") && !encontrado)
				{
					_uicontroller.CodigoSec_Search = editorID.Text;
					_uicontroller.BuscarAhoraSec();
					if (_uicontroller.ListaDePreciosHabilitadas == true)
						mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecios_Search;
					if(_uicontroller.IsValid)
					{
						encontrado = true;
						break;
					}
				}
				if(cod.ToUpper().Equals("CODIGOPROVEEDOR") && !encontrado)
				{
					_uicontroller.CodigoProveedor_search = editorID.Text;
					_uicontroller.BuscarAhoraCodigoProveedor();
					if (_uicontroller.ListaDePreciosHabilitadas == true)
						mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecios_Search;
					if(_uicontroller.IsValid)
					{
						encontrado = true;
						break;
					}
				}
			}
			if(encontrado)
			{
				editorID.Text = _uicontroller.Codigo_Search;
				if(target.Name.ToUpper().Equals("EDITORID"))
					SetCantidadAutomatica();
			}
			else
			{
				if (_uicontroller.ErrorMessage != string.Empty)
				{
					//German 20090331
					if(_uicontroller.FocoEnCodigoProducto)
					{
						System.Windows.Forms.MessageBox.Show(_uicontroller.ErrorMessage );
					}
					else
					{
						if(System.Windows.Forms.MessageBox.Show(_uicontroller.ErrorMessage ).Equals(DialogResult.OK));
						{
							uneCantidad.Enter -=new EventHandler(uneCantidad_Enter);
							//German 20090824
							//uneCantidad.KeyUp -=new KeyEventHandler(uneCantidad_KeyUp);
							//Fin German 20090824
							uneCantidad.KeyDown -= new KeyEventHandler(KeyDownEnter);
							mzComboListaDePrecios.ValueChanged -=new EventHandler(mzComboListaDePrecios_ValueChanged);
							mzComboListaDePrecios.KeyDown -=new KeyEventHandler(mzComboListaDePrecios_KeyDown);
							cboTipoDePrecioDeCosto.KeyDown -=new KeyEventHandler(cboTipoDePrecioDeCosto_KeyDown);
							this.editorID.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.editorID_KeyUp);
							this.editorID.Leave -= new System.EventHandler(this.editorID_Leave);
							//buttonElipsis.Select();
							uneCantidad.Select();
							uneCantidad.Enter +=new EventHandler(uneCantidad_Enter);
							//German 20090824
							//uneCantidad.KeyUp +=new KeyEventHandler(uneCantidad_KeyUp);
							//Fin German 20090824
							uneCantidad.KeyDown += new KeyEventHandler(KeyDownEnter);
							mzComboListaDePrecios.ValueChanged +=new EventHandler(mzComboListaDePrecios_ValueChanged);
							mzComboListaDePrecios.KeyDown +=new KeyEventHandler(mzComboListaDePrecios_KeyDown);
							cboTipoDePrecioDeCosto.KeyDown +=new KeyEventHandler(cboTipoDePrecioDeCosto_KeyDown);
							this.editorID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.editorID_KeyUp);
							this.editorID.Leave += new System.EventHandler(this.editorID_Leave);
						}
					}
					
					//Fin German 20090331
					
				}
				ResetBindings();

			}


		}
		private void BuscarAhoraAnterior(Control target)
		{			
			//Parche
			_uicontroller.SetOrdenBusqueda();
			_uicontroller.IdListaDePrecios_Search = (string) mzComboListaDePrecios.Value;
			_uicontroller.TipoDePrecioDeCosto_Search = (string)cboTipoDePrecioDeCosto.Text;
			if(_uicontroller.OrdenDeBusqueda[0].Equals(string.Empty)|| _uicontroller.OrdenDeBusqueda[0].ToUpper().Equals("CODIGO"))
			{
				_uicontroller.Codigo_Search = editorID.Text;			
				_uicontroller.BuscarAhora();
				if (_uicontroller.ListaDePreciosHabilitadas == true)
					mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecios_Search;
				cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCosto_Search;
				if (!_uicontroller.IsValid)
				{
					
					//Busco el código secundario
					_uicontroller.CodigoSec_Search = editorID.Text;
					_uicontroller.BuscarAhoraSec();
					if (_uicontroller.ListaDePreciosHabilitadas == true)
						mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecios_Search;
					cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCosto_Search;
					if (!_uicontroller.IsValid)
					{
						if (_uicontroller.ErrorMessage != string.Empty)
						{
							System.Windows.Forms.MessageBox.Show( _uicontroller.ErrorMessage );
							encontrado = false;
						}
						ResetBindings();
						//uneCantidad.Focus();
					}
					else 
					{
						editorID.Text = _uicontroller.Codigo_Search;
						encontrado = true;
						if(target.Name.ToUpper().Equals("EDITORID"))
							SetCantidadAutomatica();	
						//uneCantidad.Focus();											
					}
				}
			
				else 
				{
					encontrado = true;
					if(target.Name.ToUpper().Equals("EDITORID"))
						SetCantidadAutomatica();								
				}
			}
			else
			{
				_uicontroller.CodigoSec_Search = editorID.Text;			
				_uicontroller.BuscarAhoraSec();
				if (_uicontroller.ListaDePreciosHabilitadas == true)
					mzComboListaDePrecios.Value = _uicontroller.IdListaDePrecios_Search;
				cboTipoDePrecioDeCosto.Text = _uicontroller.TipoDePrecioDeCosto_Search;
				if (!_uicontroller.IsValid)
				{
					//Busco el código secundario
					_uicontroller.Codigo_Search = editorID.Text;
					_uicontroller.BuscarAhora();
					if (!_uicontroller.IsValid)
					{
						if (_uicontroller.ErrorMessage != string.Empty)
						{
							System.Windows.Forms.MessageBox.Show( _uicontroller.ErrorMessage );
							encontrado = false;
					
						}
						ResetBindings();
						//uneCantidad.Focus();
					}
					else 
					{
						editorID.Text = _uicontroller.Codigo_Search;
						encontrado = true;
						if(target.Name.ToUpper().Equals("EDITORID"))
							SetCantidadAutomatica();
					}
				}
			
				else 
				{
					encontrado = true;
					if(target.Name.ToUpper().Equals("EDITORID"))
						SetCantidadAutomatica();
				}
			}
						
		}
		bool encontrado = false;

		public void SetCantidadAutomatica() 
		{
			
			bool CantidadAutomatica = Variables.GetValueBool(_processName, _taskName, "CantidadAutomatica");						

			if (CantidadAutomatica)
			{
				long CantidadAutomaticaValorDefault = Variables.GetValueLong(_processName, _taskName, "CantidadAutomaticaValorDefault");
				if (CantidadAutomaticaValorDefault == long.MinValue)
					CantidadAutomaticaValorDefault = Variables.GetValueLong("Momentos.Default.CantidadAutomaticaValorDefault");

				_uicontroller.Cantidad = CantidadAutomaticaValorDefault;
				if(SingleSelectionProducto != null)
					SingleSelectionProducto(_uicontroller.Item,new EventArgs());
				ProcessObjectsObserver();
				bool resetea = Variables.GetValueBool(_processName, _taskName, "ReseteaCodigoProducto", true);
				if (resetea) 
					ResetBindings();
			}
			else
			{
				uneCantidad.Focus();	
				//this.SelectNextControl(editorID,true,true,false,false);
			}
		}

		private void editorID_Leave(object sender, System.EventArgs e)
		{
			
			if (!encontrado)
				BuscarAhora((System.Windows.Forms.Control)sender);
		}
		
		protected override void OnPaint(PaintEventArgs pe)
		{
			
			// Calling the base class OnPaint
			base.OnPaint(pe);
			// Create two semi-transparent colors
			/*Color c1 = Color.FromArgb
				(0 ,0,0,0 );
			Color c2 = Color.FromArgb
				(0 ,0,0,0);
			Brush b = new System.Drawing.Drawing2D.LinearGradientBrush
				(ClientRectangle, c1, c2, 10);
			pe.Graphics.FillRectangle (b, ClientRectangle);
			b.Dispose();
			*/
			
			
		}
		
		#region Observer
		public void SendObservable( IObservable _object )			 
		{	
			_object.AddObjectListener((IObserver) _uicontroller);
		}	

		private ArrayList _objectListener = new ArrayList();
		//public void AddObjectListener( IObserver _object )
		//{
		//	_objectListener.Add( _object );
		//}		
		public void AddObjectListener( IObserver _object )			 
		{	
			_objectListener.Add( _object );
			//_uicontroller.AddObjectListener(_object);			
		}	

		public  void ProcessObjectsObserver()
		{
			System.EventArgs e = new System.EventArgs();
			foreach ( IObserver _object in _objectListener )
			{
				_object.UpdateObject( this, _uicontroller.SelectedItems);	
			}
		}
		#endregion

		private void labelUnidadOrigen_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtDescripcion_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void mzProductosControl_Load(object sender, System.EventArgs e)
		{
		
		}

		private void lblInfoAdicional1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelUnidadDestino_Click(object sender, System.EventArgs e)
		{
		
		}

		private void labelFormula_Click(object sender, System.EventArgs e)
		{
		
		}

		private void unePrecio_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void mzComboListaDePrecios_ValueChanged(object sender, System.EventArgs e)
		{		
			if (_uicontroller.ListaDePreciosHabilitadas)
				BuscarAhora((System.Windows.Forms.Control)sender);

		}

		private void mzComboListaDePrecios_KeyDown(object sender, KeyEventArgs e)
		{
		
			if(e.KeyCode == System.Windows.Forms.Keys.Enter)
			{
				if ((_uicontroller.SelectedItems.Count == 1) && (Convert.ToDecimal(uneCantidad.Value) > 0) )
				{
					if(SingleSelectionProducto != null)
						SingleSelectionProducto(_uicontroller.Item,new EventArgs());
					ProcessObjectsObserver();
					ResetBindings();
					if(_uicontroller.ListaDePreciosHabilitadas)
					{
						if(_uicontroller.VolverAListaDePreciosDefault)
							mzComboListaDePrecios.Value = _uicontroller.IdListaDePreciosDefault;
					}
				}
			
			}
		}

		private void cboTipoDePrecioDeCosto_KeyDown(object sender, KeyEventArgs e)
		{
		
			if(e.KeyCode == System.Windows.Forms.Keys.Enter)
			{
				if ((_uicontroller.SelectedItems.Count == 1) && (Convert.ToDecimal(uneCantidad.Value) > 0) )
				{
					if(SingleSelectionProducto != null)
						SingleSelectionProducto(_uicontroller.Item,new EventArgs());
					ProcessObjectsObserver();
					ResetBindings();
					/*if(_uicontroller.ListaDePreciosHabilitadas)
					{
						if(_uicontroller.VolverAListaDePreciosDefault)
							mzComboListaDePrecios.Value = _uicontroller.IdListaDePreciosDefault;
					}*/
				}
			
			}
		}

		public void SetFocus()
		{
			this.ActiveControl = this.editorID;
		}

		
		public void SetUIForSearch()
		{
			this.BackColor = Color.Transparent;
			this.uneCantidad.ReadOnly = false;
			this.uneCantidad.Enabled = false;
			this.uneCantidad.Select();			
			this.cboTipoDePrecioDeCosto.Visible = false;
			this.EnabledListaDePrecio = false;
			this.VisibleComboListaDePrecios = false;
			this.VisibleComboTipoDePrecioDeCosto = false;
			this.VisiblePrecios = false;
			this.VisibleCantidad = false;			
		}
	}
}


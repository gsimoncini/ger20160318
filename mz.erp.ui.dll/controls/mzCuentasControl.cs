using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms;
using mz.erp.ui.forms.classes;
using mz.erp.ui.controllers;
using System.Reflection;

namespace mz.erp.ui.controls
{
	/// <summary>
	/// Descripción breve de mzCuentasControl.
	/// </summary>
	public class mzCuentasControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button buttonElipsis;
		private Infragistics.Win.Misc.UltraLabel labelDescription;
		private Infragistics.Win.UltraWinEditors.UltraTextEditor editorID;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btnCtaCte;
		private System.ComponentModel.IContainer components;

		

		#region Código generado por el Diseñador de componentes
		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(mzCuentasControl));
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.buttonElipsis = new System.Windows.Forms.Button();
			this.labelDescription = new Infragistics.Win.Misc.UltraLabel();
			this.editorID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btnCtaCte = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.editorID)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonElipsis
			// 
			this.buttonElipsis.BackColor = System.Drawing.SystemColors.Control;
			this.buttonElipsis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonElipsis.Location = new System.Drawing.Point(105, 0);
			this.buttonElipsis.Name = "buttonElipsis";
			this.buttonElipsis.Size = new System.Drawing.Size(22, 21);
			this.buttonElipsis.TabIndex = 5;
			this.buttonElipsis.TabStop = false;
			this.buttonElipsis.Text = "...";
			// 
			// labelDescription
			// 
			appearance1.TextVAlign = Infragistics.Win.VAlign.Middle;
			this.labelDescription.Appearance = appearance1;
			this.labelDescription.BackColor = System.Drawing.SystemColors.Control;
			this.labelDescription.BorderStyleInner = Infragistics.Win.UIElementBorderStyle.Dotted;
			this.labelDescription.ImageTransparentColor = System.Drawing.Color.Turquoise;
			this.labelDescription.Location = new System.Drawing.Point(128, 0);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(264, 21);
			this.labelDescription.TabIndex = 6;
			this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
			// 
			// editorID
			// 
			this.editorID.Location = new System.Drawing.Point(0, 0);
			this.editorID.Name = "editorID";
			this.editorID.Size = new System.Drawing.Size(104, 21);
			this.editorID.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(392, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(22, 21);
			this.button1.TabIndex = 7;
			this.button1.TabStop = false;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(416, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(22, 21);
			this.button2.TabIndex = 8;
			this.button2.TabStop = false;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(464, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(22, 21);
			this.button3.TabIndex = 10;
			this.button3.TabStop = false;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.BackColor = System.Drawing.SystemColors.Control;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(440, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(22, 21);
			this.button4.TabIndex = 9;
			this.button4.TabStop = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnCtaCte
			// 
			this.btnCtaCte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCtaCte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCtaCte.Image = ((System.Drawing.Image)(resources.GetObject("btnCtaCte.Image")));
			this.btnCtaCte.Location = new System.Drawing.Point(488, 0);
			this.btnCtaCte.Name = "btnCtaCte";
			this.btnCtaCte.Size = new System.Drawing.Size(22, 21);
			this.btnCtaCte.TabIndex = 11;
			this.btnCtaCte.TabStop = false;
			// 
			// mzCuentasControl
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.btnCtaCte);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonElipsis);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.editorID);
			this.Name = "mzCuentasControl";
			this.Size = new System.Drawing.Size(512, 22);
			((System.ComponentModel.ISupportInitialize)(this.editorID)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Constructores y destructores
		
		public mzCuentasControl()
		{
			// Llamada necesaria para el Diseñador de formularios Windows.Forms.
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | 
				ControlStyles.UserPaint | 
				ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor,
				true);    			
			//Init();
			
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
		
		#region Eventos
		public event System.EventHandler ValueChanged;
		public event EventHandler RefreshDataEvent;
		public event EventHandler MultipleSelectedItemsChanged;
		
		#endregion

		#region Variables privadas
			private mz.erp.ui.controllers.mzCuentasControlController _uiController = new mz.erp.ui.controllers.mzCuentasControlController();			
			private MethodBase _showMethod;
			private ArrayList _selectedItems = new ArrayList();
			private bool _allowMultipleSelect = false;
		#endregion
		
		#region Propiedades públicas
		//private string _codigo = string.Empty;

		public bool AllowMultipleSelect
		{
			set
			{
				_allowMultipleSelect = value;
			}
		}


		public ArrayList SelectedItems
		{
			get{return _selectedItems;}
		}
		
		public string DataValue
		{
			get	{return _uiController.Codigo_Search;}
			//get{return string.Empty;}
			set 
			{
				_uiController.Codigo_Search = value;
				BuscarAhora();				
			}
		}				
		
		private string _descripcion = string.Empty;
		public string Descripcion
		{
			get	{return _uiController.Nombre;}
		}
		private Type _searchObject = typeof( mz.erp.ui.forms.classes.tsa_Cuentas );
		public Type SearchObject
		{
			get
			{
				return _searchObject;
			}
					}
		
		private Type _editObject = typeof(mz.erp.ui.forms.FrmAbmCuentas);
		public Type EditObject
		{
			get
			{
				return _editObject;
			}
		}

		private ISearchObjectListener _searchObjectListener;
		public ISearchObjectListener SearchObjectListener
		{
			get{return _searchObjectListener;}
			set{_searchObjectListener = value;}
		}

		private bool _fastSearch;
		public bool FastSearch
		{
			get
			{
				return _fastSearch;
			}
			set
			{
				_fastSearch = value;
			}
		}
		private bool _allowEditClientePaso = false;
		public bool AllowEditClientePaso 
		{
			get { return _allowEditClientePaso;	}
			set { _allowEditClientePaso = value;}
		}
		/*private string _nombreClientePaso = String.Empty;
		public string NombreClientePaso 
		{
			get { return _nombreClientePaso;}			
		}*/
		private bool _enableCtaCte = false;
		public bool EnableCtaCte 
		{
			get { return _enableCtaCte;	}
			set { _enableCtaCte = value;}
		}
		
		//Sabrina 20100615 - Tarea 766
		private bool _reseteaCodCta = false;
		public bool ReseteaCodCta 
		{
			get { return _reseteaCodCta;	}
			set { _reseteaCodCta = value;}
		}
		//Fin Sabrina 20100615 - Tarea 766
		#endregion

		#region Métodos privados

		
		public void Init()
		{			
			Build_UI();
			InitEvents();
			InitDataBindings();
		}


		public void Init(string Proceso, string Tarea)
		{			
			Build_UI();
			InitEvents();
			InitDataBindings();
			_uiController.SetProcess(Proceso, Tarea);
		}

		private void Build_UI()
		{
			_uiController.Init();
			this.BackColor = Color.Transparent;
			this.button1.Enabled = false;
			this.button2.Enabled = true;			
			this.button3.Enabled = false;
			this.button4.Enabled = false;	
			this.btnCtaCte.Enabled = false;

			toolTip.SetToolTip(this.button3, "Cambio nombre del cliente de paso");
			
		}

		private void InitEvents()
		{						
			this.editorID.Leave+=new EventHandler(editorID_Leave);
			this.editorID.KeyUp+=new KeyEventHandler(editorID_KeyUp);
			this.buttonElipsis.Click+=new EventHandler(buttonElipsis_Click);
			this.button1.Click+=new EventHandler(button1_Click);
			this.button2.Click+=new EventHandler(button2_Click);
			this.button3.Click+=new EventHandler(button3_Click);
			this.btnCtaCte.Click+=new EventHandler(btnCtaCte_Click);
			
			_uiController.ValueChanged+=new EventHandler(_uiController_ValueChanged);
		}

		private void InitDataBindings()
		{			
			BindingController.Bind(labelDescription, "Text", _uiController, "Nombre");									
			//this.labelDescription.DataBindings.Add("Text", _uiController, "Nombre");	
		}
		private void BuscarAuxiliar() 
		{															
			string orderBy = null;
			int width = 560;
			string layoutData = String.Empty;				

			/*
			mzSearchForm sf = new mzSearchForm( _searchObject, _editObject, _fastSearch, orderBy, width, layoutData);
			sf.SearchObjectListener = _searchObjectListener;
			sf.AllowMultipleSelect = false;
			sf.LayoutData = layoutData;
			*/
			mz.erp.ui.forms.mzCuentasSearchForm _formmzCuentasSearchForm = new mz.erp.ui.forms.mzCuentasSearchForm();
			_formmzCuentasSearchForm.Init(true, true, true,false,_searchObjectListener);			
			//German 20090519
			_formmzCuentasSearchForm.AllowMultipleSelect = _allowMultipleSelect;
			//Fin German 20090519
			DialogResult dr = _formmzCuentasSearchForm.ShowDialog();
			if ( dr == DialogResult.OK )
			{
				if (_formmzCuentasSearchForm.SelectedItems.Count == 1)
				{
					_uiController.Codigo_Search = (string)_formmzCuentasSearchForm.SelectedCodigo;						
					BuscarAhora();						
				}
				else
				{
					//German 20090519
					if(_formmzCuentasSearchForm.SelectedItems.Count > 1)
					{
						_uiController.IsValid = false;
						_selectedItems = _formmzCuentasSearchForm.SelectedItems;
						if(MultipleSelectedItemsChanged != null)
							MultipleSelectedItemsChanged(this, new EventArgs());
					}
					//Fin German 20090519
                    

                
                }//Cristian Tarea 0000084 20111223
                _selectedItems = _formmzCuentasSearchForm.SelectedItems;
                if (MultipleSelectedItemsChanged != null)
                  MultipleSelectedItemsChanged(this, new EventArgs());   
                //Fin Cristian 20111223
			}

			if (! _uiController.IsValid)
			{			
				ResetBindings();
			}
			else 
			{
				editorID.Text = _uiController.Codigo_Search;
			}	
			//Sabrina 20100615 - Tarea 766
			ClearControl();
			//Fin Sabrina 20100615 - Tarea 766
		}
		private void BuscarAhora() 
		{				
			_uiController.BuscarAhora();
			if (! _uiController.IsValid)
			{
				if (_uiController.ErrorMessage != String.Empty) 
				{
					System.Windows.Forms.MessageBox.Show(_uiController.ErrorMessage);
				}
				ResetBindings();
				button1.Enabled = false;
			}
			else 
			{
				editorID.Text = _uiController.Codigo_Search;							
				button1.Enabled = true;	
				btnCtaCte.Enabled = _enableCtaCte;
				if (_allowEditClientePaso) 
				{
					EdicionClientePaso();
				}				
			}
			SetToolTip( _uiController.GetToolTipString() );		
			button4.Enabled = _uiController.HabilitarEdicionCliente();
			//Sabrina 20100615 - Tarea 766
			ClearControl();
		    //Fin Sabrina 20100615 - Tarea 766
		}

		private void EdicionClientePaso() 
		{			
			if (_uiController.Codigo_Search == _uiController.ClienteDePaso) 
			{ button3.Enabled = true;}
			else 
			{ button3.Enabled = false;}			
		}

		private void ResetBindings()
		{
			#region clear Databindings
			/*unePrecio.DataBindings.Clear();
			uneCantidad.DataBindings.Clear();
			unePrecioUnidadOrigen.DataBindings.Clear();
			labelCantidadDestino.DataBindings.Clear();
			editorID.DataBindings.Clear();
			txtDescripcion.DataBindings.Clear();*/
			labelDescription.DataBindings.Clear();

			#endregion


			#region reset values
			/*unePrecio.Value = 0;
			uneCantidad.Value = 1;
			unePrecioUnidadOrigen.Value = 0;
			labelUnidadOrigen.Text = "";
			labelUnidadDestino.Text = "";
			labelFormula.Text = "";
			lblInfoAdicional1.Text= "";
			lblInfoAdicional2.Text="";
			labelCantidadDestino.Text = "0";
			editorID.Text = "";
			txtDescripcion.Text = "";
			editorID.Focus();*/
			#endregion
		}

		private void SetToolTip( string caption )
		{			
			toolTip.SetToolTip( labelDescription, caption );
			toolTip.SetToolTip( editorID, caption );
			toolTip.SetToolTip( buttonElipsis, caption );
		}

		#endregion

		#region Métodos privados para eventos
		private void buttonElipsis_Click(object sender, EventArgs e)
		{
			BuscarAuxiliar();
		}
		private void editorID_Leave(object sender, EventArgs e)
		{						
			this._uiController.Codigo_Search = this.editorID.Text;
			BuscarAhora();			
		}
		private void editorID_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == System.Windows.Forms.Keys.F2)
			{
				BuscarAuxiliar();
			}
			if (e.KeyCode == System.Windows.Forms.Keys.Enter)
			{
				editorID_Leave(this, e);
			}		
		}
		private void _uiController_ValueChanged(object sender, EventArgs e)
		{
			if (ValueChanged != null)
			{
				ValueChanged( this, new System.EventArgs() );
			}
			toolTip.SetToolTip(this.button1, String.Format("Ver observaciones de {0}", _uiController.Nombre));
			toolTip.SetToolTip(this.button2, String.Format("Agregar observación a {0}", _uiController.Nombre));
			toolTip.SetToolTip(this.button4, String.Format("Ver Datos del cliente {0}", _uiController.Nombre));
			toolTip.SetToolTip(this.btnCtaCte, String.Format("Ver cta.cte. del cliente {0}", _uiController.Nombre));
			

		}
		private void button1_Click(object sender, EventArgs e)
		{			
		
			mzCuentasObservacionesSearchForm csf = new mzCuentasObservacionesSearchForm(_uiController.IdCuenta, _uiController.Codigo_Search, "CUENTA");
			csf.ShowDialog();
			
		}
		private void button2_Click(object sender, EventArgs e)
		{				
			
			_uiController.GetParameters();
			ProcessLoader.CallProcess( "ProcesoABMCuentasObservaciones", _uiController.Parametros);
			
		}
		private void button3_Click(object sender, EventArgs e)
		{
			
			string nombre = InputBox.ShowInputBox("Ingrese el nombre del cliente de paso", "Cliente de paso");
			if (nombre != String.Empty)
			{
				SetNombreClienteDePaso(nombre);
			}	
			
		}
		#endregion		

		#region Métodos públicos

		public void SetNombreClienteDePaso(string NombreClienteDePaso)
		{
			_uiController.ReemplazoNombreClientePaso = true;
			_uiController.Nombre = NombreClienteDePaso;	
			_uiController.NombreClienteDePaso = NombreClienteDePaso;
		}

		public void AddObjectListener( IObserver _object )			 
		{
			
			_uiController.AddObjectListener(_object);						
			
		}		
		public void SendObservable( IObservable _object )			 
		{
			
			_object.AddObjectListener((IObserver) _uiController);
			
		}		

		public void ClearControl()
		{
			//Sabrina 20100615 - Tarea 766
			if(ReseteaCodCta)
			{
				this.editorID.Value=string.Empty;
				this.labelDescription.Text=string.Empty;
				_uiController.IdCuenta=string.Empty;
				_uiController.Nombre=string.Empty;
			}
			//Fin Sabrina 20100615 - Tarea 766
		}
		#endregion

		private void button4_Click(object sender, System.EventArgs e)
		{									
			this.Cursor = Cursors.WaitCursor;
			FrmAbmCuentas form = new FrmAbmCuentas();
			form.OnRowChanged += new mz.erp.ui.forms.FrmABMEx.RowChanged(EventoRefrescar);
			form.ShowForm(_uiController.IdCuenta,"READONLY", "Datos de " + _uiController.Nombre);
			this.Cursor = Cursors.Default;
		}

		private void EventoRefrescar( object sender, EventArgs args )
		{			
			BuscarAhora(); 
			if(RefreshDataEvent != null)
				RefreshDataEvent(this , new EventArgs());
		}

		private void labelDescription_Click(object sender, System.EventArgs e)
		{
			if (_uiController.IdCuenta.Trim() != "")
				MessageBox.Show(_uiController.GetToolTipString(), _uiController.Nombre);
		}

		private void btnCtaCte_Click(object sender, EventArgs e)
		{
			FrmCuentaCorriente frmcc = new FrmCuentaCorriente("ProcesoCuentaCorrienteCliente", _uiController.Codigo_Search);
			frmcc.MdiParent = mz.erp.ui.utility.Environment.MainForm;
			frmcc.Show();				
		}
	}
}

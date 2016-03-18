using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzCuentasControlController.
	/// </summary>
	public class mzCuentasControlController: IObserver, IObservable
	{
		public mzCuentasControlController()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Propiedades públicas
		private string _codigo_search = string.Empty;
		public string Codigo_Search
		{
			get { return _codigo_search; }
			set 
			{ 
				_codigo_search = value ;				
			}
		}


		private string _clienteDePaso = string.Empty;	
		private bool _incluirCamposAuxiliar1 = false;
		private bool _incluirCamposAuxiliar2 = false;
		private bool _incluirCamposAuxiliar3 = false;
		private string _etiquetaCampoAuxiliar1 = string.Empty;	
		private string _etiquetaCampoAuxiliar2 = string.Empty;	
		private string _etiquetaCampoAuxiliar3 = string.Empty;	


		public string ClienteDePaso
		{
			get { return _clienteDePaso; }
		}		

		private string _idCuenta = string.Empty;
		public string IdCuenta
		{
			get { return _idCuenta; }
			set 
			{ 
				_idCuenta = value ;				
			}
		}		
		private string _nombre = String.Empty;
		public string Nombre
		{
			get { return _nombre; }			
			set 
			{ 
				_nombre = value; 
				if (NombreChanged != null)
				{
					NombreChanged( this, new System.EventArgs() );
				}
				if (_reemplazoNombreClientePaso) 
				{
					ProcessObjectsObserver();
					_reemplazoNombreClientePaso = false;
				}				
			}
		}

		private string _nombreClienteDePaso = "";
		public string NombreClienteDePaso
		{
			get {return _nombreClienteDePaso;}
			set {_nombreClienteDePaso = value;}
		}
		
		private bool _reemplazoNombreClientePaso = false;
		public bool ReemplazoNombreClientePaso 
		{
			get {return _reemplazoNombreClientePaso;}
			set {_reemplazoNombreClientePaso = value;}
		}

		private bool _isValid = false;
		public bool IsValid
		{
			get { return _isValid; }
			set 
			{ 
				_isValid = value ;				
			}
		}

		private string _errorMessage = String.Empty;
		public string ErrorMessage
		{
			get { return _errorMessage; }
			set 
			{ 
				_errorMessage = value ;				
			}
		}
		Hashtable _parametros = null;
		public Hashtable Parametros 
		{
			get {return _parametros;}
		}

		public string _idListaDePreciosDefault = String.Empty;
		public string IdListaDePreciosDefault
		{
			get { return _idListaDePreciosDefault; }
			set { _idListaDePreciosDefault = value;}
		}
        
		
		#endregion

		#region Variables privadas
		
		private string _lastcode_search = string.Empty;
		private businessrules.Cuenta cuenta;
		private businessrules.ProveedorView proveedor;
		public event System.EventHandler NombreChanged;
		public event System.EventHandler ValueChanged;

		private bool _muestraSaldoCtaCteDV = false;
        private bool _muestraEmail = false;
        private bool _muestraNombreTitular = false;
        private bool _muestraTelefonoTitular = false;

		#endregion

		#region Métodos públicos


		public void SetProcess(string Proceso, string Tarea)
		{
			_muestraSaldoCtaCteDV = Variables.GetValueBool(Proceso, Tarea, "BuscadorClientes.MuestraHintSaldoCtaCteDV", _muestraSaldoCtaCteDV);
			_muestraSaldoCtaCteDV = _muestraSaldoCtaCteDV || Variables.GetValueBool("Cuentas.BuscadorClientes.MuestraHintSaldoCtaCteDV");
		}

		

		public void BuscarAhora()
		{
			//if (_lastcode_search.CompareTo(_codigo_search) != 0 || cuenta == null)
			//{				
				if ((_codigo_search != null) && (_codigo_search.CompareTo(string.Empty) != 0) )
				{
					cuenta = new mz.erp.businessrules.Cuenta();
					cuenta.GetCuenta_CodigoCuenta(_codigo_search);
					_idCuenta = cuenta.IdCuenta;					
					
					if ((cuenta != null) && (cuenta.Codigo != null) && (cuenta.Codigo.CompareTo(string.Empty) != 0))
					{												
						_lastcode_search = _codigo_search;

						if (_codigo_search != _clienteDePaso || _nombre == "" || _nombreClienteDePaso == "")
						{
							_nombre = cuenta.Nombre;
							_idListaDePreciosDefault = cuenta.IdListaDePreciosDefault;							
						}
						else 
						{
							_nombre = _nombreClienteDePaso;
						}
						//_nombre = cuenta.Nombre;
						CallRefresh();
						_isValid = true;
					}
					else
					{
						cuenta = null;
						_codigo_search = string.Empty;
						_isValid = false;
						_errorMessage = "La cuenta no es válido o no está habilitado";
					}
				}
				else
				{					
					cuenta = null;
					_codigo_search = string.Empty;
					_nombre = string.Empty;
					_isValid = false;
					_errorMessage = string.Empty;
					CallRefresh();
				}
			/*}
			else
			{
				if(_lastcode_search.CompareTo(string.Empty)!= 0)
				{
					_isValid = true;						
				}
				CallRefresh();
			}*/
		}
		public void BuscadorAuxiliar()
		{			
			/*this.SelectedItems.Clear();
			mz.erp.ui.controllers.forms.mzCuentasSearchForm

			mz.erp.ui.controllers.forms.mzProductosSearchForm sf = new mz.erp.ui.controllers.forms.mzProductosSearchForm();
			sf.ShowDialog();
			if (sf.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				this._descripcion = sf.SelectedDescription;
				this._codigo_search = sf.SelectedValue;
				if (sf.SelectedItems.Count >= 2)
				{
					foreach ( string idproducto in sf.SelectedItems)
					{
						AddItem( idproducto );
					}
					if (this.MultipleSelectionProducto != null)
					{
						MultipleSelectionProducto( this, new System.EventArgs());
					}
				}
				else
				{
					if (sf.SelectedItems.Count == 1)
					{
						AddItem( (string)sf.SelectedItems[0] );
						_lastcode_search = _codigo_search;
						if (this.SingleSelectionProducto != null)
						{
							SingleSelectionProducto( this, new System.EventArgs());
						}
						CallRefresh();
					}
				}
				_isValid = true;
			}
			else
			{
				_isValid = false; 
				_errorMessage = string.Empty;
			}*/
		}
		public string GetToolTipString()
		{
			string s = string.Empty;
			if (cuenta != null)
			{				
				s += "Nombre: " + _nombre + "\r\n";			
				s += "Código: " + _codigo_search + "\r\n";							
				s += "Tipo y nro. de documento: " + cuenta.TipoDocumento + " " + cuenta.Documento + "\r\n";			
			
				foreach (businessrules.Domicilio domicilio in cuenta.DomiciliosAsociado)
				{						
					s+=  domicilio.TipoDomicilio + ": " + domicilio.DomicilioTexto + " " + domicilio.Telefono + " " + domicilio.Localidad + "\r\n";
				}
                /* Silvina 20100526 - Tarea 438 */
                if (_muestraEmail)
                    s += "Email: " + cuenta.Email + "\r\n";
                if (_muestraNombreTitular)
                    s += "Titular: " + cuenta.NombreTitular + "\r\n";
                if (_muestraTelefonoTitular)
                    s += "Telefono Titular: " + cuenta.TelefonoTitular + "\r\n";
                /* Fin Silvina */
				s += "Categoría de IVA: " + cuenta.CategoriaImpositiva + "\r\n";
				s += "Saldo Cta Cte: " + Convert.ToString(decimal.Round(cuenta.SaldoCtaCte,2)) + "\r\n";
				if(_muestraSaldoCtaCteDV)
					s += "Saldo Cta Cte 2: " + Convert.ToString(decimal.Round(cuenta.SaldoCtaCteDV,2)) + "\r\n";
				if(cuenta.ExcluyePercepcionIB)
					s += "Excluye Percepción de Ing. Brutos" + "\r\n";
				else
					s += "NO Excluye Percepción de Ing. Brutos" + "\r\n";

				if (_incluirCamposAuxiliar1)
					s += _etiquetaCampoAuxiliar1 + ": " + cuenta.CampoAuxiliar1 + "\r\n";			

				if (_incluirCamposAuxiliar2)
					s += _etiquetaCampoAuxiliar2 + ": " + cuenta.CampoAuxiliar2 + "\r\n";			

				if (_incluirCamposAuxiliar3)
					s += _etiquetaCampoAuxiliar3 + ": " + cuenta.CampoAuxiliar3 + "\r\n";	
				
				
				
			}
			return s;
		}

		public bool HabilitarEdicionCliente()
		{
			bool resultado = false;			
			if (_codigo_search != String.Empty)
			{											 
				/*string[] listaPerfilesEditar = businessrules.Variables.GetValueString("Cuentas.BotonEditar.PerfilesHabilitados").Split(',');
				foreach (string str in listaPerfilesEditar)
				{
					if (str.Equals(businessrules.Security.IdPerfil.ToString()))
					{					
						resultado = true;
					}
				}	*/
				resultado = businessrules.Variables.GetValueBool("Cuentas.Habilitar.BotonEditar");
			}
			return resultado;
			
		}

		public void Init()
		{
			_clienteDePaso = businessrules.Variables.GetValueString("Cuenta.ClienteDePaso.Default");
			_incluirCamposAuxiliar1 = businessrules.Variables.GetValueBool("Cuenta.MostrarCampoAuxiliar1");
			if (_incluirCamposAuxiliar1)
				_etiquetaCampoAuxiliar1 = businessrules.Variables.GetValueString("Cuentas.CampoAuxiliar1.Etiqueta");
			_incluirCamposAuxiliar2 = businessrules.Variables.GetValueBool("Cuenta.MostrarCampoAuxiliar2");
			if (_incluirCamposAuxiliar2)
				_etiquetaCampoAuxiliar2 = businessrules.Variables.GetValueString("Cuentas.CampoAuxiliar2.Etiqueta");
			_incluirCamposAuxiliar3 = businessrules.Variables.GetValueBool("Cuenta.MostrarCampoAuxiliar3");
			if (_incluirCamposAuxiliar3)
				_etiquetaCampoAuxiliar3 = businessrules.Variables.GetValueString("Cuentas.CampoAuxiliar3.Etiqueta");
            /* Silvina 20100526 - Tarea 438 */
            _muestraEmail = Variables.GetValueBool("Cuentas.BuscadorClientes.MuestraHintEmail");
            _muestraNombreTitular = Variables.GetValueBool("Cuentas.BuscadorClientes.MuestraHintNombreTitular");
            _muestraTelefonoTitular = Variables.GetValueBool("Cuentas.BuscadorClientes.MuestraHintTelefonoTitular");
            /* Fin Silvina */
		}
		#endregion

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = mz.erp.businessrules.Variables.GetValueBool("Cuentas.PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

		#region IObservable
		private ArrayList _objectListener = new ArrayList();
		public void AddObjectListener( IObserver _object )
		{
			_objectListener.Add( _object );
		}

		public void ProcessObjectsObserver()
		{
			System.EventArgs e = new System.EventArgs();
			foreach ( IObserver _object in _objectListener )
			{
				_object.UpdateObject( this, _nombre);
			}
		}
		#endregion

		#region Miembros de IObserver
		public void UpdateObject(object sender, object valores)
		{		
//			if ((valores.GetType()) == typeof(System.Collections.ArrayList))
//			{
//				ProcessItemComprobante( (ArrayList)valores);
//			}
			if ((valores.GetType()) == typeof(System.String))
			{
				if (_nombre != Convert.ToString(valores)) 
				{
					_nombre = Convert.ToString(valores);
					CallRefresh();
				}				
			}
		}

		#endregion

		#region Métodos privados

		private void CallRefresh()
		{
			if (NombreChanged != null)
			{
				NombreChanged( this, new System.EventArgs() );
			}
			if (ValueChanged != null)
			{
				ValueChanged( this, new System.EventArgs() );				
			}
			// Matias 20081230
			if ((_codigo_search != null) && (_codigo_search.CompareTo(string.Empty) != 0) )
				ProcessObjectsObserver();
			// ------
		}

		public void GetParameters() 
		{
			_parametros = ProcessParameters.ConvertToHash("ABMCuentasObservaciones", "CodigoCuenta", _codigo_search);
		}
		#endregion
	}
}

using System;
using System.Collections;
using mz.erp.commontypes;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de mzProveedoresControlController.
	/// </summary>
	public class mzProveedoresControlController: IObserver, IObservable
	{
		public mzProveedoresControlController()
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


		private bool _incluirCamposAuxiliar1 = false;
		private bool _incluirCamposAuxiliar2 = false;
		private bool _incluirCamposAuxiliar3 = false;
		private bool _incluirCamposAuxiliar4 = false;
		private bool _incluirCamposAuxiliar5 = false;
		private string _etiquetaCampoAuxiliar1 = string.Empty;	
		private string _etiquetaCampoAuxiliar2 = string.Empty;	
		private string _etiquetaCampoAuxiliar3 = string.Empty;	
		private string _etiquetaCampoAuxiliar4 = string.Empty;	
		private string _etiquetaCampoAuxiliar5 = string.Empty;	


		private string _idProveedor = string.Empty;
		public string IdProveedor
		{
			get { return _idProveedor; }
			set 
			{ 
				_idProveedor = value ;				
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
			}
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

		#endregion

		#region Variables privadas
		
		private string _lastcode_search = string.Empty;
		private businessrules.Proveedor proveedor;
		//private businessrules.ProveedorView proveedor;
		public event System.EventHandler NombreChanged;
		public event System.EventHandler ValueChanged;

		#endregion

		#region Métodos públicos
		

		public void BuscarAhora()
		{
			if ((_codigo_search != null) && (_codigo_search.CompareTo(string.Empty) != 0) )
			{
				proveedor = new mz.erp.businessrules.Proveedor();
				proveedor.GetCuenta_CodigoProveedor(_codigo_search);
				_idProveedor = proveedor.IdProveedor;					
					
				if ((proveedor != null) && (proveedor.Codigo != null) && (proveedor.Codigo.CompareTo(string.Empty) != 0))
				{												
					_lastcode_search = _codigo_search;
					_nombre = proveedor.Nombre;
					CallRefresh();
					_isValid = true;
				}
				else
				{
					proveedor = null;
					_codigo_search = string.Empty;
					_isValid = false;
					_errorMessage = "El proveedor no es válido o no está habilitado";
				}
			}
			else
			{					
				proveedor = null;
				_codigo_search = string.Empty;
				_nombre = string.Empty;
				_isValid = false;
				_errorMessage = string.Empty;
				CallRefresh();
			}
		}

		public void BuscadorAuxiliar()
		{			
		}

		public string GetToolTipString()
		{
			string s = string.Empty;
			if (proveedor != null)
			{				
				s += "Nombre: " + _nombre + "\r\n";			
				s += "Código: " + _codigo_search + "\r\n";							
				s += "Tipo y nro. de documento: " + proveedor.TipoDocumento + " " + proveedor.Documento + "\r\n";			
			
				//TODO Sabri: Ver lo de los domicilios
				/*foreach (businessrules.Domicilio domicilio in proveedor.DomiciliosAsociado)
				{						
					s+=  domicilio.TipoDomicilio + ": " + domicilio.DomicilioTexto + " " + domicilio.Telefono + " " + domicilio.Localidad + "\r\n";
				}*/
				s += "Categoría de IVA: " + proveedor.CategoriaImpositiva + "\r\n";
				if(proveedor.ExcluyeRetencionIIBB)
					s += "Excluye Retención de Ing. Brutos" + "\r\n";
				else
					s += "NO Excluye Retención de Ing. Brutos" + "\r\n";

				if (_incluirCamposAuxiliar1)
					s += _etiquetaCampoAuxiliar1 + ": " + proveedor.CampoAuxiliar1 + "\r\n";			

				if (_incluirCamposAuxiliar2)
					s += _etiquetaCampoAuxiliar2 + ": " + proveedor.CampoAuxiliar2 + "\r\n";			

				if (_incluirCamposAuxiliar3)
					s += _etiquetaCampoAuxiliar3 + ": " + proveedor.CampoAuxiliar3 + "\r\n";			

				if (_incluirCamposAuxiliar4)
					s += _etiquetaCampoAuxiliar4 + ": " + proveedor.CampoAuxiliar4 + "\r\n";			

				if (_incluirCamposAuxiliar5)
					s += _etiquetaCampoAuxiliar5 + ": " + proveedor.CampoAuxiliar5.ToString() + "\r\n";			

			}
			return s;
		}

		public bool HabilitarEdicionProveedor()
		{
			bool resultado = false;			
			if (_codigo_search != String.Empty)
			{											 
				resultado = businessrules.Variables.GetValueBool("Proveedor.Habilitar.BotonEditar");
			}
			return resultado;
			
		}

		public void Init()
		{
			_incluirCamposAuxiliar1 = businessrules.Variables.GetValueBool("Proveedor.MostrarCampoAuxiliar1");
			if (_incluirCamposAuxiliar1)
				_etiquetaCampoAuxiliar1 = businessrules.Variables.GetValueString("Proveedor.CampoAuxiliar1.Etiqueta");
			_incluirCamposAuxiliar2 = businessrules.Variables.GetValueBool("Proveedor.MostrarCampoAuxiliar2");
			if (_incluirCamposAuxiliar2)
				_etiquetaCampoAuxiliar2 = businessrules.Variables.GetValueString("Proveedor.CampoAuxiliar2.Etiqueta");
			_incluirCamposAuxiliar3 = businessrules.Variables.GetValueBool("Proveedor.MostrarCampoAuxiliar3");
			if (_incluirCamposAuxiliar3)
				_etiquetaCampoAuxiliar3 = businessrules.Variables.GetValueString("Proveedor.CampoAuxiliar3.Etiqueta");
			if (_incluirCamposAuxiliar4)
				_etiquetaCampoAuxiliar4 = businessrules.Variables.GetValueString("Proveedor.CampoAuxiliar4.Etiqueta");
			if (_incluirCamposAuxiliar5)
				_etiquetaCampoAuxiliar5 = businessrules.Variables.GetValueString("Proveedor.CampoAuxiliar5.Etiqueta");

		}
		#endregion

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
		}
		public void GetParameters() 
		{
			_parametros = ProcessParameters.ConvertToHash("ABMCuentasObservaciones", "IdProveedor", _idProveedor);
		}
		#endregion

	}
}

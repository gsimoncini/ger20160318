using System;
using System.Collections;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Cuenta.
	/// </summary>
	public class Cuenta:IComparable
	{
		#region Constructores
		
		public Cuenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public Cuenta(string IdCuenta)
		{
			_idCuenta = IdCuenta;
			Init();
		}
		#endregion

		#region Propiedades públicas

		private bool _sourceBD = false;
		public bool SourceBD
		{
			get{return _sourceBD;}
			set{_sourceBD = value;}
		}

		private bool _agregado = false;
		public bool Agregado
		{
			get{return _agregado;}
			set{_agregado = value;}
		}

		private string _idCuenta = string.Empty;
		public string IdCuenta
		{
			get { return _idCuenta; }
			set { _idCuenta = value ;}
		}
		private string _codigo = String.Empty;
		public string Codigo
		{
			get { return _codigo; }
			set {_codigo = value; }
		}		

		private string _nombre = String.Empty;
		public string Nombre
		{
			get { return _nombre; }
			set {_nombre = value; }
		}		

		private string _domicilio = String.Empty;
		public string Domicilio
		{
			get { return _domicilio; }
			set {_domicilio = value; }
		}	
	
		private string _idDomicilioDefault = String.Empty;
		/*
		public string IdDomicilio
		{
			get { return _domicilio; }
			set {_domicilio = value; }
		}
		*/	

		private string _telefono = String.Empty;
		public string Telefono
		{
			get { return _telefono; }
			set {_telefono = value; }
		}		

		private string _localidad = String.Empty;
		public string Localidad
		{
			get { return _localidad; }
			set {_localidad = value; }
		}		
		private string _tipoDocumento = String.Empty;
		public string TipoDocumento
		{
			get { return _tipoDocumento; }
			set {_tipoDocumento = value; }
		}		

		private string _documento = String.Empty;
		public string Documento
		{
			get { return _documento; }
			set {_documento = value; }
		}				
		private string _horarioComercial = String.Empty;
		public string HorarioComercial
		{
			get { return _horarioComercial; }
			set {_documento = value; }
		}		
		private ArrayList _domiciliosAsociados;
		public ArrayList DomiciliosAsociado
		{
			get { return _domiciliosAsociados ; }
			set { _domiciliosAsociados = value ; }
		}	

		private bool _excluyePercepcionIB = false;
		public bool ExcluyePercepcionIB
		{
			get{return _excluyePercepcionIB;}
			set{_excluyePercepcionIB = value;}
		}


		private decimal _limiteDeCredito;
		public decimal LimiteDeCredito
		{
			get { return _limiteDeCredito ; }
			//set { _limiteDeCredito = value ; }
		}
		private string _categoriaImpositiva = String.Empty;
		public string CategoriaImpositiva
		{
			get { return _categoriaImpositiva; }
			set {_categoriaImpositiva = value; }
		}	

		private string _observaciones = String.Empty;
		public string Observaciones
		{
			get { return _observaciones; }
			set {_observaciones = value; }
		}	

		private string _metodoAsignacion = string.Empty;
		public string MetodoDeAsignacion
		{
			get {return _metodoAsignacion;}
			set {_metodoAsignacion = value;}
		}

		private string _campoAuxiliar1 = String.Empty;
		public string CampoAuxiliar1
		{
			get { return _campoAuxiliar1; }
			//set {_documento = value; }
		}	

		private string _campoAuxiliar2 = String.Empty;
		public string CampoAuxiliar2
		{
			get { return _campoAuxiliar2; }
			//set {_documento = value; }
		}	
		
		private string _campoAuxiliar3 = String.Empty;
		public string CampoAuxiliar3
		{
			get { return _campoAuxiliar3; }
			//set {_documento = value; }
		}	

		private decimal _alicuotaPercepcionIngresosBrutos;
		public decimal AlicuotaPercepcionIngresosBrutos
		{
			get{return _alicuotaPercepcionIngresosBrutos;}
		}

		private string _idListaDePreciosDefault = String.Empty;
		public string IdListaDePreciosDefault
		{
			get{return _idListaDePreciosDefault;}
		}

		private decimal _saldoCtaCteDV;
		public decimal SaldoCtaCteDV
		{
			get{return _saldoCtaCteDV;}
		}

		private decimal _saldoCtaCte;
		public decimal SaldoCtaCte
		{
			get{return _saldoCtaCte;}
		}

        /* Silvina 20100526 - Tarea 438 */
        private string _email = string.Empty;
        public string Email
        {
            get { return _email;}
        }

        private string _nombreTitular = string.Empty;
        public string NombreTitular
        {
            get { return _nombreTitular; }
        }

        private string _telefonoTitular = string.Empty;
        public string TelefonoTitular
        {
            get { return _telefonoTitular; }
        }

        /* Fin Silvina */

		#endregion

		#region Métodos privados
		private void Init() 
		{
			this.GetCuenta_IdCuenta(_idCuenta);
		}

		private void FillStaticData(tsa_CuentasDataset.tsa_CuentasRow row) 
		{			 
			if (row !=null)
			{
				this._idCuenta = row.IdCuenta;
				this._codigo = row.Codigo;
				this._nombre = row.Nombre;
				this._categoriaImpositiva = row.IdCategoriaIva;
				this._tipoDocumento = row.idTipoDocumento;
				this._documento = row.Documento;
				this._horarioComercial = row.HorarioComercial;
				this._localidad = row.CampoAuxiliar1;
				this._domiciliosAsociados = mz.erp.businessrules.tcs_DomiciliosCuentas.GetDomicilios( _idCuenta );
				this._limiteDeCredito = row.LimiteDeCredito;				
				this._excluyePercepcionIB = row.ExcluyePercepcionIB;
				this._campoAuxiliar1 = row.CampoAuxiliar1;
				this._campoAuxiliar2 = row.CampoAuxiliar2;
				this._campoAuxiliar3 = row.CampoAuxiliar3;
				this._observaciones = row.Observaciones;
				this._alicuotaPercepcionIngresosBrutos = row.AlicuotaPercepcionIngresosBrutos;

				this._idDomicilioDefault = row.IdDomicilioDefault;
				if( _idDomicilioDefault != null && !_idDomicilioDefault.Equals(string.Empty))
				{
					foreach(Domicilio dom in _domiciliosAsociados)
					{
						if(dom.IdDomicilio.Equals(_idDomicilioDefault))
						{
							this._domicilio = dom.DomicilioTexto;
							this._telefono = dom.Telefono;
						}
					}
				}
				else
				{
					this._domicilio = row.Domicilio;	
					this._telefono = row.Telefono;
				}
				this._saldoCtaCte = row.SaldoCtaCte;
				this._saldoCtaCteDV = row.SaldoCtaCteDV;

				//Sabrina 20100615 - Tarea 765
				this._idListaDePreciosDefault = row.IdListaDePreciosDefault;
				//Fin Sabrina 20100615 - Tarea 765
				
				/* Silvina 20100526 - Tarea 438 */
                if (row.Email != null)
                    this._email = row.Email;
                tsh_PersonasDataset.tsh_PersonasRow titular = tsh_Personas.GetByPk(row.IdTitular);
                if (titular != null)
                {
                    _nombreTitular = titular.Nombre;
                    _telefonoTitular = titular.Telefonos;
                }
                /* Fin Silvina */
							
			}
		}
		#endregion

		#region Métodos públicos
		public void GetCuenta_IdCuenta(string IdCuenta) 
		{
            /* Silvina 20100730 - Tarea 806 */
            tsa_CuentasDataset.tsa_CuentasRow row = mz.erp.businessrules.tsa_Cuentas.GetByPk(IdCuenta);
            /* Fin Silvina */
			this.FillStaticData(row);

		}

		public void GetCuenta_CodigoCuenta(string Codigo)
		{
			_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(Codigo);
            /* Silvina 20100730 - Tarea 806 */
			tsa_CuentasDataset.tsa_CuentasRow row = mz.erp.businessrules.tsa_Cuentas.GetByPk(_idCuenta);
            /* Fin Silvina */
			this.FillStaticData(row);
		}
		
		public Domicilio GetDomicilio(string IdTipoDeComprobante)
		{
			foreach(Domicilio dom in this._domiciliosAsociados)
			{
				if(dom.TipoDomicilio.Equals(IdTipoDeComprobante))
					return dom;
			}
			return null;
		}

		public override string ToString()
		{
			return _idCuenta;
		}

		public Cuenta ShallowClone()
		{
			return (Cuenta)this.MemberwiseClone();
		}
		

		#endregion
		
		#region Miembros de IComparable

		public int CompareTo(object obj)
		{
			Cuenta cuenta = (Cuenta)obj;
			int result = cuenta.Nombre.CompareTo(this.Nombre);
			return result;
		}

		#endregion
	}
}

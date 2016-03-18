using System;
using System.Collections;
using mz.erp.businessrules.data;
using mz.erp.commontypes.data;
using mz.erp.businessrules.comprobantes;
/* Silvina 20111104 - Tarea 0000222 */
using System.Data;
/* Fin Silvina 20111104 - Tarea 0000222 */

namespace mz.erp.businessrules.comprobantes
{
	
	/// <summary>
	/// Contiene toda la información necesaria de la cuenta.
	/// Ejecuta funcionalidad al realizar cambios en la definición de la cuenta que puedan afectar al comprobante
	/// </summary>
	public class Cuenta
	{
		
		private ComprobanteDeVenta _parent;
		private string _action;

		public Cuenta(string _action, ComprobanteDeVenta sender, string IdCuenta )
		{
			_parent = sender;
			_idCuenta = IdCuenta;
			Init( _action );
		}
		public Cuenta(string _action, ComprobanteDeVenta sender)
		{
			_parent = sender;
			Init( _action );
		}

		private void Init(string action)
		{
			this._action = action;
			switch (action)
			{
				case "NEW":
					FillStaticData();
					FillNewData();
					break;
				case "EDIT":
					FillStaticData();
					FillEditData();
					break;
			}
		}

		public delegate void RecalcularCuenta( object sender, System.EventArgs e);
		/// <summary>
		/// Se ejecuta cada vez que un cambio importante en los valores de la cuenta afectan
		/// variables de calculo del comprobante.
		/// </summary>
		public event RecalcularCuenta OnRecalcularCuenta;

		public delegate void RefrescarCuenta( object sender, System.EventArgs e);
		//public event RefrescarCuenta OnRefrescarCuenta;

	
		/*
		public string ComprobanteDeVentaSugerido()
		{
			string[] arrayComprobantes = ComprobantesRules.Comprobantes_Admitidos_Segun_Momento( this._parent.Momento );
			string[] arrayComprobantesPorCategoria = ComprobantesRules.CategoriaImpositiva_Comprobantes_Por_Tipo( this._categoriaImpositiva );
			for (int i=0; i<=(arrayComprobantes.Length - 1);i++)
			{
				for (int f=0;f<=(arrayComprobantesPorCategoria.Length -1) ;f++)
				{
					if (arrayComprobantes[i].Trim().ToUpper() ==  arrayComprobantesPorCategoria[f].Trim().ToUpper() )
						return arrayComprobantes[i].Trim().ToUpper();
				}
			}
			return string.Empty;

		}
		*/

		public string ComprobanteDeVentaSugerido(string ProcessName, string taskName)
		{
			string[] arrayComprobantes = ComprobantesRules.Comprobantes_Admitidos_Segun_Momento( ProcessName, taskName );
			ArrayList arrayComprobantesPorCategoria = ComprobantesRules.CategoriaImpositiva_Comprobantes_Por_Tipo( this._categoriaImpositiva );
			for (int i=0; i<=(arrayComprobantes.Length - 1);i++)
			{
				//for (int f=0;f<=(arrayComprobantesPorCategoria.Length -1) ;f++)
				foreach(string IdComp in arrayComprobantesPorCategoria)
				{
					if (arrayComprobantes[i].Trim().ToUpper() ==  IdComp.Trim().ToUpper() )
						return arrayComprobantes[i].Trim().ToUpper();
				}
			}
			return string.Empty;

		}

		public string ComprobanteDeEntregaSugerido(string ProcessName, string TaskName, string Estado)
		{
			//string[] arrayComprobantes = ComprobantesRules.Comprobantes_Admitidos_Segun_Momento( ProcessName, taskName );
			string idTiposComprobantes = Variables.GetValueString( ProcessName,TaskName,Estado+".Comprobantes" );
			if(idTiposComprobantes == null || idTiposComprobantes == string.Empty)
				idTiposComprobantes = Variables.GetValueString( ProcessName,TaskName,"Comprobantes" );
			ArrayList arrayComprobantes = mz.erp.systemframework.Util.Parse(idTiposComprobantes,",");
			ArrayList arrayComprobantesPorCategoria = ComprobantesRules.CategoriaImpositiva_Comprobantes_Por_Tipo( this._categoriaImpositiva );
			foreach(string tc in arrayComprobantes)
			{
				/*
				for (int f=0;f<=(arrayComprobantesPorCategoria.Length -1) ;f++)
				{
					if (tc.Trim().ToUpper() ==  arrayComprobantesPorCategoria[f].Trim().ToUpper() )
						return tc.Trim().ToUpper();
				}
				*/
				foreach(string IdComp in arrayComprobantesPorCategoria)
				{
					if (tc.Trim().ToUpper() ==  IdComp.Trim().ToUpper() )
						return tc.Trim().ToUpper();
				}
			}
			return string.Empty;

		}



		/// <summary>
		/// Fuerza la captura de información interna de la cuenta cada vez que se ha generado un cambio la cuenta definida
		/// </summary>
		private void RefreshData()
		{
			FillNewData();
			FillStaticData();
		}

		/// <summary>
		/// Captura la información de la cuenta que no se almacena en el comprobante. Buscará la información directamente de
		/// los datos almacenados en el RDBM
		/// </summary>
		private void FillStaticData()
		{
            /* Silvina 20100730 - Tarea 806 */
            tsa_CuentasDataset.tsa_CuentasRow _row = mz.erp.businessrules.tsa_Cuentas.GetByPk(_idCuenta);
            /* Fin Silvina */
			if (_row !=null)
			{
				string codigoClienteDePaso = Variables.GetValueString("Cuenta.ClienteDePaso.Default");
				if(!_row.Codigo.Equals(codigoClienteDePaso))
				{
					this._nombre = _row.Nombre;
					_parent.InfoCliente = this._nombre;
				}
				else
				{
					if((this._nombre == null || this._nombre.Equals(string.Empty)) || _codigoChanged)
					{
						this._nombre = _row.Nombre;
						_parent.InfoCliente = this._nombre;
					}
				}
				this._categoriaImpositiva = _row.IdCategoriaIva;
				this._tipoDocumento = _row.idTipoDocumento;
				this._documento = _row.Documento;
				this._domicilio = _row.Domicilio;				
				this._telefono = _row.Telefono;
				this._codigo = _row.Codigo;
				this._limiteDeCredito = _row.LimiteDeCredito;
				this._diasLimiteDeCredito = _row.DiasLimiteDeCredito;
				this._excluyePercepcionIB = _row.ExcluyePercepcionIB;
				this._alicuotaPercepcionIngresosBrutos = _row.AlicuotaPercepcionIngresosBrutos;
				string idTipoDomicilio = ComprobantesRules.Momentos_Cuenta_Domicilio_Default(this._parent.Momento);
				
				/*Aca llamar a la funcion de la BD fn_getIdDomicilio*/
				string IdDomicilio = mz.erp.businessrules.tcs_DomiciliosCuentas.GetIdDomicilioDefault(IdCuenta, Convert.ToUInt32(idTipoDomicilio));
				/*Con el IdDimicilio que devuelve la funcion, ahcer un getByPk(IdDomicilio)*/
				
				this._domicilio = tcs_DomiciliosCuentas.GetDomicilioPorDefault(IdDomicilio);				
				this._telefono = tcs_DomiciliosCuentas.GetTelefonoPorDefault(IdDomicilio);								
				this._localidad = tcs_DomiciliosCuentas.GetLocalidadPorDefault(IdDomicilio);	
			    //Matias 20110819 - Tarea 0000131
                this._codigoPostal = tcs_DomiciliosCuentas.GetCpPorDefault(IdDomicilio);
                this._idProvincia = tcs_DomiciliosCuentas.GetIdProvinciaPorDefault(IdDomicilio);
                this._codigoProvincia = tcs_DomiciliosCuentas.GetCodigoProvinciaPorDefault(IdDomicilio);
                this._email = _row.Email;
                //FinMatias 20110819 - Tarea 0000131
				this._domiciliosAsociados = mz.erp.businessrules.tcs_DomiciliosCuentas.GetDomicilios( _idCuenta );

				this._saldoCtaCte = _row.SaldoCtaCte;
				this._saldoCtaCteDV = _row.SaldoCtaCteDV;
				
				//Sabrina 20100615 - Tarea 765
				this._idListaDePreciosDefault = _row.IdListaDePreciosDefault;
				//Fin Sabrina 20100615 - Tarea 765
				
				_parent.InfoDomicilio = this._domicilio;
				_parent.InfoTipoDocumento = this._tipoDocumento;
				_parent.InfoDocumento= this._documento;
				_parent.InfoObservaciones = "Código de cliente: " + this._codigo + ".";
//				_parent.InfoAux1 = this._nombre;
//				_parent.InfoAux2 = this._nombre;
//				_parent.InfoAux3 = this._nombre;

                /* Silvina 20111104 - Tarea 0000222 */
                if (_jerarquiaCuentas.Equals(_campoAuxiliar6Cuentas))
                {
                    ArrayList jer = new ArrayList();
                    ArrayList CampoAuxiliar6BDList = mz.erp.systemframework.Util.Parse(_row.CampoAuxiliar6, ",");
                    foreach (string aux in CampoAuxiliar6BDList)
                    {
                        if (aux != null && aux != string.Empty)
                        {
                            DataRow row = mz.erp.businessrules.tsa_JerarquiaAgrupCuentas.GetPkByDescripcion(aux);
                            if (row != null)
                                jer.Add(row["Jerarquia"].ToString());
                        }
                    }
                    _jerarquiaCategorias = systemframework.Util.PackString(jer);
                }
                else
                {
                    dataCuentaJerarquia = tsa_AgrupCuentas.GetList(_idCuenta);
                    _jerarquiaCategorias = string.Empty;
                    foreach (DataRow row in dataCuentaJerarquia.Tables[0].Rows)
                    {
                        if (row["Jerarquia"].ToString().Contains(_jerarquiaCuentas))
                            _jerarquiaCategorias = row["Jerarquia"].ToString();
                    }
                }
                /* Fin Silvina 20111104 - Tarea 0000222 */
                /* Silvina 20120413 - Tarea 0000275 */
                _idDomicilioDefault = _row.IdDomicilioDefault;
                /* Fin Silvina 20120413 - Tarea 0000275 */
			}
		}
	
		/// <summary>
		/// Captura la información de inicialización al crearse una cuenta o al modificarse el id de la cuenta actual.
		/// La información es buscada directamente de los datos almacenados en el RDBM
		/// </summary>
		private void FillNewData()
		{
			this._bonificacion = tsa_BonificacionesEx.GetBonificacionCuenta( _idCuenta, 0 );			
		}

		/// <summary>
		/// Captura la información desde un comprobante almacenado, la información es obtenida desde las variables de sistema
		/// almacenadas para el comprobante especificado en el RDBM
		/// </summary>
		private void FillEditData()
		{
			string idVariableAuxiliar = ComprobantesRules.Comprobantes_Variables_IdBonificacionCuenta;
			VariableAuxiliar var = _parent.VariablesComprobante.Search( idVariableAuxiliar );
			if (var != null)
				this._bonificacion = Convert.ToDecimal( var.Valor );
		}

		private decimal _saldoCtaCte = 0;
		public decimal SaldoCtaCte
		{
			get
			{
				return _saldoCtaCte;
			}
		}
		

		private decimal _saldoCtaCteDV = 0;
		public decimal SaldoCtaCteDV
		{
			get
			{
				return _saldoCtaCteDV;
			}
		}


		decimal _bonificacion = 0;
		/// <summary>
		/// Bonificación global definida para la cuenta según el importe total del comprobante de venta que lo contiene.
		/// </summary>
		public decimal BonificacionCuenta
		{
			get
			{
				/*if (_action != "EDIT")
				{
					_bonificacion = tsa_BonificacionesEx.GetBonificacionCuenta( _idCuenta, _parent.Total );			
				}
				*/
				//return _bonificacion;
				//return 0;

				_bonificacion = tsa_BonificacionesEx.GetBonificacionCuenta( _idCuenta, _parent.Total );
				return _bonificacion;
			}
		}

		private string _categoriaImpositiva = String.Empty;
		/// <summary>
		/// Devuelve la categoría impositiva (IVA) de la cuenta.
		/// </summary>
		public string CategoriaImpositiva
		{
			get { return _categoriaImpositiva; }
			set {_categoriaImpositiva = value; }
		}

		private decimal _alicuotaPercepcionIngresosBrutos = 0;
		/// <summary>
		/// Devuelve la categoría impositiva (IVA) de la cuenta.
		/// </summary>
		public decimal AlicuotaPercepcionIngresosBrutos
		{
			get { return _alicuotaPercepcionIngresosBrutos; }
			//set {_categoriaImpositiva = value; }
		}

		private string _nombre = String.Empty;
		/// <summary>
		/// Devuelve el nombre de la cuenta. Correspondencia con Nombre de la tabla tsa_Cuentas
		/// </summary>
		public string Nombre
		{
			get { return _nombre; }
			set {_nombre = value; }
		}		

		private string _domicilio = String.Empty;
		/// <summary>
		/// Devuelve el domicilio de la cuenta. Correspondencia con Domicilio de la tabla tsa_Cuentas
		/// </summary>
		public string Domicilio
		{
			get { return _domicilio; }
			set {_domicilio = value; }
		}		

		private string _telefono = String.Empty;
		/// <summary>
		/// Devuelve el domicilio de la cuenta. Correspondencia con Domicilio de la tabla tsa_Cuentas
		/// </summary>
		public string Telefono
		{
			get { return _telefono; }
			set {_telefono = value; }
		}

        //Matias 20110819 - Tarea 0000131
        private string _codigoPostal = String.Empty;
        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }
        private string _idProvincia = String.Empty;
        public string IdProvincia
        {
            get { return _idProvincia; }
            set { _idProvincia = value; }
        }
        private string _codigoProvincia = String.Empty; //Codigo workout (para las eFacturas)
        public string CodigoProvincia
        {
            get { return _codigoProvincia; }
            set { _codigoProvincia = value; }
        }
        private string _email = String.Empty;
        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }
        //FinMatias 20110819 - Tarea 0000131

		private string _localidad = String.Empty;
		/// <summary>
		/// Devuelve el domicilio de la cuenta. Correspondencia con Domicilio de la tabla tsa_Cuentas
		/// </summary>
		public string Localidad
		{
			get { return _localidad; }
			set {_localidad = value; }
		}	
	
		private bool _excluyePercepcionIB = false;
		public bool ExcluyePercepcionIB
		{
			get{return _excluyePercepcionIB;}
			set{_excluyePercepcionIB = value;}
		}


		private string _tipoDocumento = String.Empty;
		/// <summary>
		/// Devuelve el tipo de documento de la cuenta. Correspondencia con idTipoDocumento de la tabla tsa_Cuentas
		/// </summary>
		public string TipoDocumento
		{
			get { return _tipoDocumento; }
			set {_tipoDocumento = value; }
		}		

		private string _documento = String.Empty;
		/// <summary>
		/// Devuelve el nro. de documento de la cuenta. Correspondencia con Documento de la tabla tsa_Cuentas
		/// </summary>
		public string Documento
		{
			get { return _documento; }
			set {_documento = value; }
		}	
	

		public event EventHandler CodigoChanged;
		
		private string _codigo = string.Empty;
		private bool _codigoChanged = false;


		private bool _datosCuentaChanged = false;
		public bool DatosCuentaChanged
		{
			set{_datosCuentaChanged = value;}
		}


		public string Codigo
		{
			get
			{	
				return _codigo;
			}
			set
			{											
				if(_codigo != value)
				{
					_codigo = value;
					_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk( value );
					_codigoChanged = true;
					RefreshData();
					this._parent.TipoComprobanteDestino = this.ComprobanteDeVentaSugerido(this._parent.GetProcessManagerParent().Process.ProcessName,this._parent.GetTaskName());
					this._parent.RefreshCondicionesDeVentas();
					if (OnRecalcularCuenta != null)
					{
						OnRecalcularCuenta( this, new System.EventArgs() );				

					}	
					_codigoChanged = false;
				}
				else
				{
					if(_codigo == value)
					{		
						_codigoChanged = false;				
						businessrules.Cuenta cuenta = new mz.erp.businessrules.Cuenta();
						cuenta.GetCuenta_CodigoCuenta(_codigo);
						string categoriaImpositiva = _categoriaImpositiva;
						bool excluyePercepcionIB = _excluyePercepcionIB;
						RefreshData();
						if (cuenta.CategoriaImpositiva != categoriaImpositiva || cuenta.ExcluyePercepcionIB != excluyePercepcionIB)
						{
							string ComprobanteSugerido = this.ComprobanteDeVentaSugerido(this._parent.GetProcessManagerParent().Process.ProcessName,this._parent.GetTaskName());
							this._parent.TipoComprobanteDestino = ComprobanteSugerido;
							this._parent.RefreshCondicionesDeVentas();
							if (OnRecalcularCuenta != null)
							{
								OnRecalcularCuenta( this, new System.EventArgs() );				
							}	
						}						
						_idCuenta = cuenta.IdCuenta;
						_datosCuentaChanged = false;
					}
/*					 
					 if(_codigo == value && _datosCuentaChanged)
					{
						_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk( value );	
						_datosCuentaChanged = false;
						
					}*/
				}

				
				/*
				if(CodigoChanged != null)
					CodigoChanged(this, new EventArgs());
				*/

			}
		}

        /* Silvina 20111104 - Tarea 0000222 */
        private DataSet dataCuentaJerarquia;
        private string _jerarquiaCuentas = Variables.GetValueString("Cuentas.Categorias.JerarquiaAsociada");
        private string _campoAuxiliar6Cuentas = Variables.GetValueString("Cuentas.CampoAuxiliar6.JerarquiaAsociada");
        private string _jerarquiaCategorias = string.Empty;

        public string JerarquiaCategorias
        {
            get
            {
                return _jerarquiaCategorias;
            }
        }

        /* Fin Silvina 20111104 - Tarea 0000222 */

		private string _idCuenta = string.Empty;
		/// <summary>
		/// Devuelve el identificador unico de la cuenta. Correspondencia con IdCuenta de la tabla tsa_Cuentas
		/// </summary>
		public string IdCuenta
		{
			get { return _idCuenta; }
			set 
			{	
				if(_idCuenta != null && _idCuenta!= string.Empty && _idCuenta != value )
				{
					_idCuenta = value ;
					RefreshData();
					this._parent.TipoComprobanteDestino = this.ComprobanteDeVentaSugerido(this._parent.GetProcessManagerParent().Process.ProcessName,this._parent.GetTaskName());
					this._parent.RefreshCondicionesDeVentas();
					if (OnRecalcularCuenta != null)
					{
						OnRecalcularCuenta( this, new System.EventArgs() );
					}
				}
			}
		}
		private ArrayList _domiciliosAsociados = new ArrayList();
		public ArrayList DomiciliosAsociado
		{
			get { return _domiciliosAsociados ; }
			set { _domiciliosAsociados = value ; }
		}
			
		public bool DocumentoVacio()
		{			
			bool result = _documento == null || _documento == "0" || _documento.Trim() == String.Empty ||
				_documento.Replace("-","").Trim() == String.Empty;
			return result;
		}

	
		private decimal _limiteDeCredito;
		public decimal LimiteDeCredito
		{
			get { return _limiteDeCredito ; }
			//set { _limiteDeCredito = value ; }
		}

		private decimal _diasLimiteDeCredito;
		public decimal DiasLimiteDeCredito
		{
			get { return _diasLimiteDeCredito ; }
			//set { _limiteDeCredito = value ; }
		}

		//Sabrina 20100615 - Tarea 765
		private string _idListaDePreciosDefault = String.Empty;
		/// <summary>
		/// Devuelve el IdListaDePreciosDefault de la cuenta. Correspondencia con IdListaDePreciosDefault de la tabla tsa_Cuentas
		/// </summary>
		public string IdListaDePreciosDefault
		{
			get { return _idListaDePreciosDefault; }
		}
		//Fin Sabrina 20100615 - Tarea 765

        /* Silvina 20120413 - Tarea 0000275 */
        private string _idDomicilioDefault = string.Empty;
        public string IdDomicilioDefault
        {
            get { return _idDomicilioDefault; }
        }
        /* Fin Silvina 20120413 - Tarea 0000275 */
	}
}

using System;
using System.Collections;
using mz.erp.commontypes.data;
using System.Data;
using mz.erp.businessrules;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de Valor.
	/// </summary>
	public class Valor: ITask, IPersistentTask
	{
		//necesarios para el commit con el WF
		private tfi_ValoresDataset.tfi_ValoresRow _rowValor;
		private tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow _rowValorDatoAuxiliar;
		private tfi_ValoresDatosAuxiliaresDataset dataValorDatoAuxiliar = new tfi_ValoresDatosAuxiliaresDataset();
		private tfi_ValoresDataset dataValor = new tfi_ValoresDataset();
		//fin necesatio para el commit WF
		private DataTable _bancos=new DataTable();
		
	
		private string _idCuenta=string.Empty;

		#region constructores e inicializacion

		public Valor()
		{
			Initialize();
		}

		public Valor(string IdValor ,string IdTDCompTesoreria, string IdMoneda)
		{
			Init(IdValor, IdTDCompTesoreria, IdMoneda, 0);			
		}
		public Valor(string IdValor ,string IdTDCompTesoreria, string IdMoneda, decimal valor)
		{
			Init(IdValor, IdTDCompTesoreria, IdMoneda, valor);			
		}

	

	
		private void Init(string IdValor ,string IdTDCompTesoreria, string IdMoneda, decimal Valor)
		{
			if(IdValor == null ||IdValor.Equals(string.Empty))
			{
				this._idTDCompTesoreria = IdTDCompTesoreria;
				this._idMoneda = IdMoneda;
				if(this._idMoneda != null && this._idMoneda != string.Empty)
				{
					DataRow rowMoneda = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMoneda);
					_moneda = Convert.ToString(rowMoneda["Descripcion"]);
				}
				else _moneda = string.Empty;
				DataRow row = mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(this._idTDCompTesoreria);
				if (row != null)
				{
					this._comprobante = Convert.ToString(row["Descripcion"]);
					this._agrupado = Convert.ToBoolean(row["Agrupado"]);
				}
				this._idValor = mz.erp.systemframework.Util.NewStringId();
				this._valor = Valor;
				this._valorCotizado = Valor;
				this._valorSinRecargos = Valor;
				this._idEntidad = string.Empty;
				this._numero = string.Empty;
				this._monedaReferencia = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaReferencia).Descripcion;
				_datoAuxiliar = new DatoAuxiliar(IdValor);
				_state = "NEW";
				GerCotizacion();
				GetValorCotizado();
				
			}
			else
			{
				DataRow row = mz.erp.businessrules.tfi_Valores.GetByPk(IdValor);
				this._idInstanciaCaja = Convert.ToString(row["IdInstanciaCaja"]);
				this._signo = Convert.ToInt32(row["Signo"]);
				this._signoDB = Convert.ToInt32(row["Signo"]);
				this._idValor = Convert.ToString( row["IdValor"]);
				this._idTDCompTesoreria =  Convert.ToString( row["IdTDCompTesoreria"]);
				if(_idTDCompTesoreria != null && _idTDCompTesoreria != string.Empty )
				{
					DataRow rowTDC = mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(this._idTDCompTesoreria);
					if (rowTDC != null)
					{
						this._comprobante = Convert.ToString(rowTDC["Descripcion"]);
						this._agrupado = Convert.ToBoolean(rowTDC["Agrupado"]);
					}
				}
				this._numero =  Convert.ToString( row["Numero"]);
				this._idEntidad =  Convert.ToString(row["IdEntidad"] );
				if(_idEntidad != null && _idEntidad != string.Empty )
				{
					this._entidad = mz.erp.businessrules.tfi_Entidades.GetByPk(this._idEntidad).Descripcion;				
				}
				this._fecha= Convert.ToDateTime(row["Fecha"]);
				this._fechaVencimiento= Convert.ToDateTime( row["FechaVencimiento"]);
				this._idMoneda =  Convert.ToString(row["IdMoneda"]);
				this._idCotizacion = Convert.ToString(row["IdCotizacionMoneda"]);
				if(_idCotizacion != null && _idCotizacion != string.Empty )
				{
					Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(_idCotizacion);
					this._valorCotizacion = cot.Valor;
				}
				if(_idMoneda != null && !_idMoneda.Equals(string.Empty))
					_moneda = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMoneda).Descripcion;
				this._valor = Convert.ToDecimal(row["Valor"]);
				GetValorCotizado();
				_datoAuxiliar = new DatoAuxiliar(this.IdValor);
				_state = "EDIT";
			}
			GetListaEntidades(this._idTDCompTesoreria);
			GetDefaultIncluyeRecargo();
			AllowEditIncluyeRecargos();
			GetAllowShowIncluyeRecargos();
			_bancos=tfi_Banco.GetListEnTabla();
		}
	
		
		
		public void Init()
		{
			_monedaReferencia = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaReferencia).Descripcion;
			GetDefaultIncluyeRecargo();
			AllowEditIncluyeRecargos();
			GetAllowShowIncluyeRecargos();
			GetListaEntidades(this._idTDCompTesoreria);
			_processName = this.GetProcessManagerParent().Process.ProcessName;
			_bancos=tfi_Banco.GetListEnTabla();
		}
		

		public void Initialize()
		{
			_monedaReferencia = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMonedaReferencia).Descripcion;
			GetDefaultIncluyeRecargo();
			AllowEditIncluyeRecargos();
			GetAllowShowIncluyeRecargos();
			GetListaEntidades(this._idTDCompTesoreria);
			_bancos=tfi_Banco.GetListEnTabla();
			
		}


		#endregion 

		#region variables privadas 

		private string _idValor = string.Empty;
		private string _idMoneda = string.Empty;
		
		private string _idCotizacion= string.Empty;
		private decimal _valorCotizacion = 1;

		private decimal _valor = 0;
		private decimal _valorSinRecargos = 0;
		private string _idTDCompTesoreria= string.Empty;
		private string _comprobante= string.Empty;
		private string _moneda= string.Empty;
		private DateTime _fecha = mz.erp.businessrules.Sistema.DateTime.Now;
		private DateTime _fechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
		private string _idEntidad= string.Empty;
		private string _entidad= string.Empty;
		private string _numero= string.Empty;
		private decimal _valorCotizado = 0;
		private decimal _valorCotizadoForUndo = 0;
		private decimal _valorForUndo = 0;
		private decimal _valorSinRecargosForUndo = 0;
		private bool _mustUndo = false;
		private string _idFuenteDeCambioReferencia = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
		private DatoAuxiliar _datoAuxiliar;
		//private string _idCuenta = String.Empty;
		
		//private VariablesAuxiliaresComprobantesTesoreria _variablesAuxiliares;
		private string _idFormaDePago = string.Empty;
		private string _state = string.Empty;

	
		private string _idCotizacionReferencia = Variables.GetValueString("Contabilidad.CotizacionReferencia");
		private string _idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
		private string _monedaReferencia = string.Empty;
		


		private bool _incluyeRecargos = true;
		private bool _allowEditIncluyeRecargos = false;
		private bool _allowShowIncluyeRecargos = false;

		private bool _isStep = false;
		private bool _agrupado = false;


		private DataTable _listaEntidades = new DataTable();
		private DataTable _estadosCheques=businessrules.tfi_EstadoCheques.GetList().tfi_EstadoCheques;

		private string _idInstanciaCaja = string.Empty;
		private string _idEstado=string.Empty;
		private int _signo = 0;
		private int _signoDB = 0;
		//private string _idProveedor=string.Empty;
		private string _noIndica=Variables.GetValueString("Valores.Estado.NoIndica");
		private string _enCartera=Variables.GetValueString("Valores.Estado.EnCartera");
		private string _enCarteraSinRetirar=Variables.GetValueString("Valores.Estado.EnCarteraSinRetirar");
		
		#endregion 

		#region acceso a variables de DatoAuxiliar
		
		
		
		public string CodigoAutorizacion
		{
			set { _datoAuxiliar.CodigoAutorizacion = value;}
			get { return _datoAuxiliar.CodigoAutorizacion;}
		}

		public string Cupon
		{
			set { _datoAuxiliar.Cupon = value;}
			get { return _datoAuxiliar.Cupon;}
		}
		public DateTime FechaDeAcreditacion
		{
			set { _datoAuxiliar.FechaDeAcreditacion = value;}
			get { return _datoAuxiliar.FechaDeAcreditacion;}
		}
		public DateTime FechaDeAutorizacion
		{
			set { _datoAuxiliar.FechaDeAutorizacion = value;}
			get { return _datoAuxiliar.FechaDeAutorizacion;}
		}
		public string Lote
		{
			set { _datoAuxiliar.Lote = value;}
			get { return _datoAuxiliar.Lote;}
		}
		public short CantidadCuotas
		{
			set { _datoAuxiliar.CantidadCuotas = value;}
			get { return _datoAuxiliar.CantidadCuotas;}
		}
		public string CuentaBancaria
		{
			set { _datoAuxiliar.CuentaBancaria = value;}
			get { return _datoAuxiliar.CuentaBancaria;}
		}
		public string Librador
		{
			set { _datoAuxiliar.Librador = value;}
			get { return _datoAuxiliar.Librador;}
		}
		public string Sucursal
		{
			set { _datoAuxiliar.Sucursal = value;}
			get { return _datoAuxiliar.Sucursal;}
		}
		public DateTime FechaDePago
		{
			set { _datoAuxiliar.FechaDePago = value;}
			get { return _datoAuxiliar.FechaDePago;}
		}
		public DateTime FechaDeRecepcion
		{
			set { _datoAuxiliar.FechaDeRecepcion = value;}
			get { return _datoAuxiliar.FechaDeRecepcion;}
		}

		public string IdCuenta
		{
			get	{ return _datoAuxiliar.IdCuenta;}
			set	{_datoAuxiliar.IdCuenta= value;	}
		}

		public string NroBoleta
		{
			set {_datoAuxiliar.NroBoleta = value;}
			get {return _datoAuxiliar.NroBoleta;}
		}

		public string CodigoDiez
		{
			set {_datoAuxiliar.CodigoDiez= value;}
			get {return _datoAuxiliar.CodigoDiez;}
		}

		public DateTime FechaIngresoBanco
		{
			set {_datoAuxiliar.FechaIngresoBanco= value;}
			get {return _datoAuxiliar.FechaIngresoBanco;}
		}

		public bool Cruzado
		{
			set { _datoAuxiliar.Cruzado = value;}
			get { return  _datoAuxiliar.Cruzado;}
		}
		public bool Sellado
		{
			set { _datoAuxiliar.Sellado = value;}
			get { return _datoAuxiliar.Sellado;}
		}

		public string IdTipoDeRetencion
		{
			//set { _datoAuxiliar.IdTipoDeRetencion = value;}
			get { return _datoAuxiliar.IdTipoDeRetencion;}
		}
		#endregion

		#region acceso a variables privadas 

		public string IdProveedor
		{
			get
			{
				return this.DatoAuxiliar.IdDestinatario;
				
			}
			set
			{
				if(this.DatoAuxiliar.IdDestinatario != value)
				{
					this.DatoAuxiliar.Destinatario = this.Proveedor(value);
					this.DatoAuxiliar.IdDestinatario = value;
					if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
				}
				

			}
		}
		public DataTable ListaEntidades
		{
			get{return _listaEntidades;}
		}

		public string ProcessName
		{
			set{_processName = value;}
		}

		public string TaskName
		{
			set{_task = value;}
		}
		
		public bool AllowEditImporte()
		{
			bool _agrupado = false;
			tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaRow rowTdcomp = (tfi_TDCompTesoreria.GetByPk(this.IdTDCompTesoreria));
			if (rowTdcomp != null )
			{
				_agrupado = rowTdcomp.Agrupado; 
			}
			if(!_agrupado)
				return !Variables.GetValueBool( _processName, _task, "ValorDefaultReadOnly");
			return true;
			/*
			if (this._task.Equals("DefinirValor") && this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
				return true;
			else 
				return false;			
				
			*/
		}

		public bool Agrupado
		{
			get{return _agrupado;}
			set{_agrupado = value;}
        }
		public string IdEstado
		{
			get{return _idEstado;}
			set{_idEstado = value;}
		}

		public bool IsStep
		{
			get{return _isStep;}
			set{_isStep = value;}
		}


		public bool IncluyeRecargos
		{
			get{return _incluyeRecargos;}
			set
			{
				if(_incluyeRecargos != value)
				{
					_incluyeRecargos = value;
					if(IncluyeRecargosChanged != null)
						IncluyeRecargosChanged(this, new EventArgs());
				}
			}
		}

		

		public bool AllowShowIncluyeRecargos
		{
			get{return _allowShowIncluyeRecargos;}
			set{_allowShowIncluyeRecargos = false;}
		}
		
		public bool MustUndo
		{
			get{return _mustUndo;}
			set{_mustUndo = value;}
		}

		public string State
		{
			get{return _state;	}
			//set	{_state = value;}
		}	
		public DatoAuxiliar DatoAuxiliar
		{
			get{ return _datoAuxiliar;}
		}

		public String NoIndica
		{
			get{return _noIndica;}
		}
		public String EnCartera
		{
			get{return _enCartera;}
		}

		public String EnCarteraSinRetirar
		{
			get{return _enCarteraSinRetirar;}
		}

		
		public string IdMonedaReferencia
		{
			get	{return _idMonedaReferencia;}
		}

		public string MonedaReferencia 
		{
			get{return _monedaReferencia;}
		}

		public string IdFormaDePago
		{
			get{return _idFormaDePago;}
			set{_idFormaDePago = value;}	
		}
		/*
		public ArrayList Cotizaciones
		{
			set{_cotizaciones = value;}
		}
		*/
		
		public decimal MontoSinRecargos
		{
			get {return _valorSinRecargos;}
			set
			{
				if(value != _valorSinRecargos)
				{
					_valorSinRecargos = value;
					if(ValorSinRecargoChange != null)
						ValorSinRecargoChange();
				}
			}
		}
	
		public decimal  Monto
		{
			
			get{return _valor;}
			set	
			{	
				if(_valor != value)
				{
					_valor = value;
					GetValorCotizado();
					if (ValorChange != null)
					{
						ValorChange();
					}	
				}
			}
		}
		
		public decimal  MontoCotizado
		{
			get	{return _valorCotizado;	}
			set
			{
				if(_valorCotizado != value)
				{
					_valorCotizado = value;
					GetValorSinCotizar();
					if(ValorChange != null)
						ValorChange();
				}
			}
		}

        /* Silvina 20110901 - Tarea 0000206 */
        private decimal _montoCotizadoConRecargos = 0;

        public decimal MontoCotizadoConRecargos
        {
            set { _montoCotizadoConRecargos = value; }
            get {return _montoCotizadoConRecargos;}
        }
        /* Fin Silvina 20110901 - Tarea 0000206 */

		public DataTable EstadosCheques
		{
			get{return _estadosCheques;}
		}
		public DataTable Bancos
		{
			get{return _bancos;}
		}
		public DataTable CuentasBancarias
		{
			get{return this.DatoAuxiliar.CuentasBancarias;}
		}
		public string IdBanco
		{
			get 
			{
				return this.DatoAuxiliar.IdBanco;
			}
			set
			{
				if(value != this.DatoAuxiliar.IdBanco)
				{
					this.DatoAuxiliar.IdBanco=value;
				}
			
			}
		}

		public string Banco
		{
			get{return this.DatoAuxiliar.Banco;}
		}
		
		public decimal  ValorCotizacion
		{
			get	{	return _valorCotizacion;	}
			set	{	_valorCotizacion = value;	}
		}

		public string  IdValor
		{
			get	{	return _idValor;	}
			set	{	_idValor = value;	}
		}

		public string  IdCotizacion
		{
			get	{	return _idCotizacion;	}
			set	{	_idCotizacion = value;	}
		}
		
		public string  Moneda
		{
			get	{	return _moneda;		}
			set	{	_moneda = value;	}
		}

		public string  IdEntidad
		{
			get	{	return _idEntidad;	}
			set 
			{
				if (_idEntidad != value)
				{
					_idEntidad = value;
					if (value != null && value != "")
					{
						System.Data.DataRow row = mz.erp.businessrules.tfi_Entidades.GetByPk(value);
						if (row != null)
							Entidad = Convert.ToString(row["Descripcion"]);
						else Entidad ="";
					}
					else Entidad = "";
				}	
			}
		}

		public string  Entidad
		{
			get{	return _entidad;	}
			set	{	_entidad = value;	}
		}
		public string  Numero
		{
			get	{	return _numero;		}
			set	{	_numero = value;	}
		}
		public string  Comprobante
		{
			get	{	return _comprobante;	}
			set	{	_comprobante = value;	}
		}

		public DateTime Fecha
		{
			get	{	return _fecha;	}
			set	
			{	
				if (_fecha != value)
				{
					_fecha = value;
					/*
					if (PerteneceACheque(IdTDCompTesoreria) && !ChequeDiferido(IdTDCompTesoreria))
						FechaVencimiento = _fecha.AddDays(30);
					if (PerteneceACheque(IdTDCompTesoreria) && ChequeDiferido(IdTDCompTesoreria))
						FechaVencimiento = _fecha.AddDays(360);
					*/
				}
			}

		}

		public DateTime FechaVencimiento
		{
			get	{return _fechaVencimiento;	}
			set	{
				if (_fechaVencimiento != value)
				{
					_fechaVencimiento = value;	
					if ( ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}
				}
			}
		}

		public string  IdMoneda
		{
			get{return _idMoneda;	}
			set
			{
				if(_idMoneda != value)
				{
					_idMoneda = value;
					if(_idMoneda != null)
						_moneda = mz.erp.businessrules.tfi_Monedas.GetByPk(_idMoneda).Descripcion;
					GerCotizacion();
					GetValorCotizado();
					if(ValorChange != null)
						ValorChange();
				}
			}
		}

		

		public string IdTDCompTesoreria
		{
			set 
			{
				if (_idTDCompTesoreria  != value)
				{
					_idTDCompTesoreria = value;
					if (value != null && value != "")
					{
						System.Data.DataRow row = mz.erp.businessrules.tfi_TDCompTesoreria.GetByPk(value);
						if (row != null)
						{
							this._comprobante = Convert.ToString(row["Descripcion"]);
							this._agrupado = Convert.ToBoolean(row["Agrupado"]);
						}
						else
						{
							this._comprobante = string.Empty;
							this._agrupado = false;
						}
						CalcularEstado(value);
						GetListaEntidades(value);
						_idEntidad = string.Empty;
					}
					else Comprobante = "";
					if ( ObjectHasChanged != null)
					{
						ObjectHasChanged(this, new EventArgs());
					}					
				}	
			}	
			get {return _idTDCompTesoreria; }
		}

		public string IdInstanciaCaja
		{
			get{return _idInstanciaCaja;}
			set{_idInstanciaCaja = value;}
		}

		public int Signo
		{
			get{return _signo;}
			set{_signo = value;}
		}

		public int SignoDB
		{
			get{return _signoDB;}
			set{_signoDB = value;}
		}

		


		#endregion

		#region eventos
		
		public delegate void ValorChangeEventHandler ();
		public event ValorChangeEventHandler  ValorChange;
		public event ValorChangeEventHandler ValorSinRecargoChange;
		public event EventHandler ObjectHasChanged;
		public event EventHandler IncluyeRecargosChanged;
		public event EventHandler OnFinalizeEdit;

		#endregion
		
		#region verificacion datos completos en las variables auxiliares
		
		private Hashtable _reglasDeValidacionAuxiliares = new Hashtable();
		private Hashtable _reglasDeValidacionDatos = new Hashtable();
		
		public Hashtable ReglasDeValidacionAuxiliares
		{
			set { _reglasDeValidacionAuxiliares = value ; }
		}
		public Hashtable ReglasDeValidacionDatos
		{
			set { _reglasDeValidacionDatos = value ; }
		}

		private string ValidarDatosCompletos(string IdTDCompTesoreria)
		{
			string valorRetorno = null;
			if (_reglasDeValidacionAuxiliares.ContainsKey( IdTDCompTesoreria ))
				valorRetorno = Convert.ToString(_reglasDeValidacionAuxiliares[IdTDCompTesoreria]);
			return valorRetorno;
		}
		private string ValidarDatos(string IdTDCompTesoreria)
		{
			string valorRetorno = null;
			if (_reglasDeValidacionDatos.ContainsKey( IdTDCompTesoreria ))
				valorRetorno = Convert.ToString(_reglasDeValidacionDatos[IdTDCompTesoreria]);
			return valorRetorno;
		}

		

		public bool completoDatos() //verifica q esten completos los datos para un tipo de comprobante dado
		{
			SetReglasDeValidacion(this._task, this._processName);
			string conjuntoDeDatosAValidarAUX = ValidarDatosCompletos( this._idTDCompTesoreria);
			string conjuntoDeDatosAValidar = ValidarDatos( this._idTDCompTesoreria);
		
			return (this.verificateCon(conjuntoDeDatosAValidar) && this.DatoAuxiliar.verificateCon(conjuntoDeDatosAValidarAUX));
		}


		public bool completoDatos(string ProcessName, string TaskName ) //verifica q esten completos los datos para un tipo de comprobante dado
		{
			this._processName = ProcessName;
			this._task = TaskName;
			return completoDatos();
		}


		
		private void SetReglasDeValidacion(string Task, string ProcessName)
		{
			Hashtable hashAux = new Hashtable();
			Hashtable hashDatos = new Hashtable();

			mz.erp.commontypes.data.tfi_TDCompTesoreriaDataset _dataIdTDCompTesoreria = mz.erp.businessrules.tfi_TDCompTesoreria.GetList();
			foreach (System.Data.DataRow _rowIdTDCompTesoreria in _dataIdTDCompTesoreria.tfi_TDCompTesoreria.Rows)
			{
				string variable = String.Empty;				
				string idTipoDeComprobanteDeTesoreria = Convert.ToString( _rowIdTDCompTesoreria["IdTDCompTesoreria"] );
				variable = "Momentos."+ Task +"." //+ ProcessName + "."+
					+ mz.erp.businessrules.MAPStaticInfo.GetFDP(idTipoDeComprobanteDeTesoreria)+"."+"ObligaVarAuxiliares";
				string debevalidarAux = Variables.GetValueString(variable);
				variable = "Momentos."+ Task +"." //+ ProcessName + "."+
					+ mz.erp.businessrules.MAPStaticInfo.GetFDP(idTipoDeComprobanteDeTesoreria)+"."+"ObligaDatosValor";
				string debevalidarDatos = Variables.GetValueString(variable);			
				hashAux.Add( idTipoDeComprobanteDeTesoreria, debevalidarAux );
				hashDatos.Add( idTipoDeComprobanteDeTesoreria, debevalidarDatos );
			}
			_reglasDeValidacionAuxiliares = hashAux;
			_reglasDeValidacionDatos = hashDatos;
		}

		private bool verificateCon(string datosARevisar)
		{
			//verifica q la variable auxiliar este completa con respecto a lo q dice en la var de configuracion
			if (datosARevisar != null)
			{
				bool result = true;
				string[] _datosARevisar = datosARevisar.Split(',');
				for(int i=0; i < _datosARevisar.Length; i++)
				{
					switch ( _datosARevisar[i].ToString() )
					{	
						case "Entidad":
							result = result && (this.IdEntidad != null && this.IdEntidad != string.Empty);
							break;
						case "Numero":
							result = result && (this.Numero != null && this.Numero != string.Empty);
							break;
							//ojoooo mas adelante tenemos q completar esto
					}
				}
				return (result);
			}
			return (true);
		}

		#endregion

		#region Metodos Publicos

		public void CalcularEstado(string idCompTesoreria){
			if (this.PerteneceACheque(idCompTesoreria)){
				this.IdEstado=this.EnCartera;
				if (this.PerteneceAPropio(idCompTesoreria))
					this.IdEstado=this.EnCarteraSinRetirar;
				}
			else this.IdEstado=this.NoIndica;
		
		
		}
		public void Recalcular()
		{
			this.GetValorCotizado();
		}

		public  void PrepareEdit()
		{	
			this._valorCotizadoForUndo = this._valorCotizado;
			this._valorForUndo = this._valor;
			this._valorSinRecargosForUndo = this._valorSinRecargos;
			this.MontoCotizado = this.MontoSinRecargos;
		}

		public void FinalizeEdit(bool mustUndo)
		{	
			if(mustUndo)
			{	
				this.MontoCotizado = this._valorCotizadoForUndo;
				this.MontoSinRecargos = this._valorSinRecargosForUndo;
			}
			else
				if(OnFinalizeEdit != null)	
					OnFinalizeEdit(this, new EventArgs());
			/*
            else
			{
				this._valorSinRecargos = this.MontoCotizado;
			}
			*/
		}
		
		public static ArrayList LoadValores(System.Data.DataTable tabla)
		{
			ArrayList valores = new ArrayList();
			foreach(System.Data.DataRow row in tabla.Rows)
			{
				Valor valor = Factory.GetValor((string) row["Comprobante"],(string)row["Numero"],Convert.ToString(row["Entidad"]),
								(DateTime) row["Fecha"], (DateTime) row["FechaVencimiento"],(decimal) row["Valor"],
								(string) row["IdMoneda"], (string) row["IdCotizacionMoneda"]);			
				valores.Add(valor);
			}
			return valores;
		}

		public void DeleteFormDataSet(tfi_ValoresExDataset data)
		{
			tfi_ValoresExDataset.tfi_ValoresRow rowValor = data.tfi_Valores.FindByIdValor(this.IdValor);
			data.tfi_Valores.Removetfi_ValoresRow(rowValor);
		}

		
		public tfi_ValoresExDataset Update(tfi_ValoresExDataset data)
		{
			DataRow row  = mz.erp.businessrules.tfi_Valores.GetByPk(this.IdValor);
			row["IdInstanciaCaja"] = this.IdInstanciaCaja;
			row["Signo"] = this.Signo;
			row["IdEntidad"] = this.IdEntidad;
			row["IdMoneda"]= this.IdMoneda;
			row["IdTDCompTesoreria"] = this.IdTDCompTesoreria;
			row["Numero"]= this.Numero;
			row["Valor"]= this.Monto;
			row["Fecha"]= this.Fecha;
			row["FechaVencimiento"]= this.FechaVencimiento;
			row["IdCotizacionMoneda"]= this.IdCotizacion;
			row["IdEmpresa"] = Security.IdEmpresa;
			row["IdSucursal"] = Security.IdSucursal;
			row["IdValor"] =this.IdValor;
			row["IdEstadoCheque"]=this.IdEstado;
			data.tfi_Valores.ImportRow(row);
			return data;

		}
		
		public tfi_ValoresExDataset Commit(tfi_ValoresExDataset data)
		{
			tfi_ValoresExDataset.tfi_ValoresRow rowValor = data.tfi_Valores.Newtfi_ValoresRow();
			this.SetRowValues(rowValor);
			data.tfi_Valores.Addtfi_ValoresRow(rowValor);
			this.DatoAuxiliar.Commit(data, this.IdValor);
			return data;

		}
		public tfi_ValoresExDataset Commit(tfi_ValoresExDataset data, bool ok)
		{
			if(this._agrupado)
			{
				DataRow [] rows = data.tfi_Valores.Select("IdTDCompTesoreria = " + this.IdTDCompTesoreria 
					+ "and IdMoneda = " + this.IdMoneda);
				DataRow row = rows[0];
				row["Valor"] = Convert.ToDecimal(row["Valor"]) + this.Monto;
			}
			else
			{
				tfi_ValoresExDataset.tfi_ValoresRow rowValor = data.tfi_Valores.Newtfi_ValoresRow();
				this.SetRowValues(rowValor);
				data.tfi_Valores.Addtfi_ValoresRow(rowValor);
				this.DatoAuxiliar.Commit(data, this.IdValor);
			}
			return data;

		}

		public void SetRowValues(tfi_ValoresExDataset.tfi_ValoresRow  rowValor)
		{
			rowValor.IdEntidad= this.IdEntidad;
			rowValor.IdMoneda= this.IdMoneda;
			rowValor.IdTDCompTesoreria= this.IdTDCompTesoreria;
			rowValor.Numero= this.Numero;
			rowValor.Valor= this.Monto;
			rowValor.Fecha= this.Fecha;
			rowValor.FechaVencimiento= this.FechaVencimiento;
			rowValor.IdCotizacionMoneda= this.IdCotizacion;
			rowValor.IdEmpresa = Security.IdEmpresa;
			rowValor.IdSucursal = Security.IdSucursal;
			rowValor.IdValor =this.IdValor;
			rowValor.IdInstanciaCaja = this.IdInstanciaCaja;
			rowValor.Signo = this.Signo;
			rowValor.IdEstadoCheque=this.IdEstado;
			rowValor.OldIdValor = this.IdValor;
		}

		public void SetRowValues(tsa_ComprobantesExDataset.tsa_ComprobanteDetalleDePagosRow row, 
			string IdValor,
			tsa_ComprobantesExDataset.tsa_ComprobantesRow rowComprobante, Hashtable TablaDeValoresFormasDePago )
		{
			row.IdComprobante =rowComprobante.IdComprobante; 
			row.IdValor = IdValor;
			string IdFormaDePago = null;
			IdFormaDePago = Convert.ToString(TablaDeValoresFormasDePago[row.IdValor]);
			row.IdFormaDePago = IdFormaDePago;
			row.IdTipoDeComprobante = rowComprobante.IdTipoDeComprobante;
			row.Numero =rowComprobante.Numero;
			row.Monto = this.MontoCotizado;
			row.MontoSinRecargos = this.MontoSinRecargos;
			row.IdMoneda = this.IdMoneda;
			row.IdCotizaicon = this.IdCotizacion;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
		}

		public void CommitDetalleDePagos(tpu_ComprobanteDetalleDePagosDataset.tpu_ComprobanteDetalleDePagosRow row)
		{
			row.IdComprobante = string.Empty; 
			row.IdValor = this.IdValor;
			row.IdFormaDePago = string.Empty;
			row.IdTipoDeComprobante = string.Empty;
			row.Numero = string.Empty;
			row.Monto = this.MontoCotizado;
			row.MontoSinRecargos = this.MontoSinRecargos;
			row.IdMoneda = this.IdMoneda;
			row.IdCotizaicon = this.IdCotizacion;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
		}
		
		

		public bool HasVariablesAuxiliares()
		{//ojooooo sa 
			return false;
		}

		public void Refresh(object sender , EventArgs e)
		{
			RecargoFormaDePago recargo = (RecargoFormaDePago)sender;
			this._valorCotizado = recargo.Total;
			this._valorSinRecargos = recargo.ImporteAbonado;
			GetValorSinCotizar();
		}
		
		public bool PerteneceACheque(string IdTDCompTesoreria)
		{
			return MAPStaticInfo.PerteneceACheque(IdTDCompTesoreria);
		}
		
		public bool PerteneceATerceros(string IdTDCompTesoreria)
		{
			return MAPStaticInfo.PerteneceATerceros(IdTDCompTesoreria);
		}
		public bool PerteneceAPropio(string IdTDCompTesoreria)
		{
			return MAPStaticInfo.PerteneceAPropio(IdTDCompTesoreria);
		}
		

		public bool PerteneceATarjeta(string IdTDCompTesoreria)
		{
			return MAPStaticInfo.PerteneceATarjeta(IdTDCompTesoreria);
		}

		public bool PertenceARetenciones(string IdTDCompTesoreria)
		{
			return MAPStaticInfo.PertenceARetenciones(IdTDCompTesoreria);
		}

		public bool ChequeDiferido(string idFormaDePago)
		{
			return MAPStaticInfo.ChequeDiferido(idFormaDePago);
		}


		public void LoadDatosAuxiliares()
		{
			if(this.IdValor != null && this.IdValor != string.Empty)
			{
					this._datoAuxiliar = new DatoAuxiliar(this.IdValor);
			}
		}

		public string Empresa(){
		sy_EmpresasDataset.sy_EmpresasRow row=sy_Empresas.GetByPk(Security.IdEmpresa);
		if (row!=null)
			return Convert.ToString(row.Descripcion);
		return string.Empty;
		
		}
		public string Proveedor(string _idProveedor)
		{
			tpu_ProveedoresDataset.tpu_ProveedoresRow row=tpu_Proveedores.GetByPk(_idProveedor);
			if(row!=null)
				return Convert.ToString(row.Nombre);
			else return string.Empty;
		
		}


		#endregion

		#region Metodos Privados

		private void GetListaEntidades(string IdTDCompTesoreria)
		{
			_listaEntidades = businessrules.tfi_TDCompTesoreria_Entidades.GetList(IdTDCompTesoreria).tfi_TDCompTesoreria_Entidades;
		}

		private void GerCotizacion()
		{
			Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacion(this._idMoneda,this._idMonedaReferencia, this._idFuenteDeCambioReferencia);
			this._idCotizacion = cot.IdCotizacion;
			this._valorCotizacion= cot.Valor;
		}

		private void GetValorCotizado()
		{
			decimal monto = this._valor;
			this._valorCotizado =  monto * this._valorCotizacion;
		}

		private void GetValorSinCotizar()
		{
			decimal montoCotizado = this.MontoCotizado;
			this._valor =  montoCotizado * (1/this._valorCotizacion);
		}
		
		private void GetAllowShowIncluyeRecargos()
		{
			DataTable table = mz.erp.businessrules.tfi_TDCompTesoreriasMonedasRecargos.GetList(IdTDCompTesoreria, IdMoneda).tfi_TDCompTesoreriasMonedasRecargos;
			if(table.Rows.Count == 1)
			{
				bool cond1 = Convert.ToDecimal(table.Rows[0]["Recargo"]) !=0;
				_allowShowIncluyeRecargos = cond1;
			}
			else _allowShowIncluyeRecargos = false;
		}

		/*Necesario q sea public hasta q se cree un constructor q reciba ProcessName y TaskName*/
		public bool AllowEditIncluyeRecargos()
		{
			DataTable table = mz.erp.businessrules.tfi_TDCompTesoreriasMonedasRecargos.GetList(IdTDCompTesoreria, IdMoneda).tfi_TDCompTesoreriasMonedasRecargos;
			if(table.Rows.Count == 1)
			{
				bool cond1 = Convert.ToDecimal(table.Rows[0]["Recargo"]) !=0;
				string descComp = MAPStaticInfo.GetFDP(this._idTDCompTesoreria);
				bool cond2 = Variables.GetValueBool(this._processName, this._task, descComp + ".AllowEditIncluyeRecargo");
				_allowEditIncluyeRecargos = cond1 && cond2; 
			}
			else _allowEditIncluyeRecargos = false;
			return _allowEditIncluyeRecargos;
		}

		private void GetDefaultIncluyeRecargo()
		{
			_incluyeRecargos = Variables.GetValueBool("Cajas.Comprobantes.ImporteIncluyeRecargo");
		}

		

	
		#endregion

		#region Miembros de ITask
		
		#region variables locales para WF 
			
			private string _idMovimientoOrignal = string.Empty;
		
		#endregion


		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private ProcessManager _process;
		private string _task;
		private string _processName = string.Empty;

		public void ListenerTaskDependentChanged(object sender)
		{
			// TODO: agregar la implementación Valor.ListenerTaskDependentChanged
		}

		public void ListenerAfterExecuteDependentTask(object sender)
		{
			ITask tareaprevia = (ITask)sender;
			if (tareaprevia.GetTaskName().CompareTo("ConsultarPosicionDeCajaDetallado") ==0 )
			{
				ConsultasDeCaja consulta = (ConsultasDeCaja)sender;
			
				#region PROCESO EDITAR MOVIMIENTO CAJA
				string _procName = this._process.Process.ProcessName;
				if(_procName.Equals("ProcesoModificarValor"))
				{
					if (consulta.SelectedItem != null && Convert.ToString(consulta.SelectedItem) != string.Empty)
					{
						this.IdValor = Convert.ToString(consulta.SelectedItem);
						System.Data.DataRow rowValor = tfi_Valores.GetByPk(IdValor);
						//seteo los valores de la clase valores
						IdTDCompTesoreria = Convert.ToString(rowValor["idTDCompTesoreria"]);
						Numero = Convert.ToString(rowValor["numero"]);
						IdEntidad = Convert.ToString(rowValor["idEntidad"]);
						Fecha = Convert.ToDateTime(rowValor["Fecha"]);
						FechaVencimiento = Convert.ToDateTime(rowValor["FechaVencimiento"]);
						IdCotizacion = Convert.ToString(rowValor["IdCotizacionMoneda"]);
						IdMoneda = Convert.ToString(rowValor["IdMoneda"]);	
						Monto = Convert.ToDecimal(rowValor["Valor"]);
						this.IdInstanciaCaja = Convert.ToString(rowValor["IdInstanciaCaja"]);
						//seteo los valores de la clase ValoresDatosAuxiliares
						_datoAuxiliar = new DatoAuxiliar(IdValor);
						_datoAuxiliar.GetDatoAuxiliar(IdValor);
					}
				}	
				#endregion	
			}

			if (tareaprevia.GetTaskName().CompareTo("ConsultarValores") ==0 )
			{
				ConsultaValores consulta = (ConsultaValores)sender;
			
				#region PROCESO EDITAR MOVIMIENTO CAJA
				string _procName = this._process.Process.ProcessName;
				if(_procName.Equals("ProcesoModificarValor"))
				{
					ArrayList valores = consulta.GetValores();
					if(valores.Count > 0)
					{
						Valor valor = (Valor)valores[0];
						this._idValor = valor.IdValor;
						this._idTDCompTesoreria = valor.IdTDCompTesoreria;
						this._agrupado = valor.Agrupado;
						this._idEntidad = valor.IdEntidad;
						this._comprobante = valor.Comprobante;
						this._entidad = valor.Entidad;
						this._state = valor.State;
						this._signo = valor.Signo;
						this._signoDB = valor.SignoDB;
						this._datoAuxiliar = valor.DatoAuxiliar;
						this._fecha = valor.Fecha;
						this._fechaVencimiento = valor.FechaVencimiento;
						this._numero = valor.Numero;
						this._idCotizacion = valor.IdCotizacion;
						this._idMoneda = valor.IdMoneda;
						this._moneda = valor.Moneda;
						this._valor = valor.Monto;
						this._valorCotizado = valor.MontoCotizado;
						this._valorSinRecargos = valor.MontoSinRecargos;
						this._idInstanciaCaja = valor.IdInstanciaCaja;
						GetListaEntidades(this._idTDCompTesoreria);

					}
					/*
					if (consulta.SelectedItem != null && Convert.ToString(consulta.SelectedItem) != string.Empty)
					{
						this.IdValor = Convert.ToString(consulta.SelectedItem);
						System.Data.DataRow rowValor = tfi_Valores.GetByPk(IdValor);
						//seteo los valores de la clase valores
						IdTDCompTesoreria = Convert.ToString(rowValor["idTDCompTesoreria"]);
						Numero = Convert.ToString(rowValor["numero"]);
						IdEntidad = Convert.ToString(rowValor["idEntidad"]);
						Fecha = Convert.ToDateTime(rowValor["Fecha"]);
						FechaVencimiento = Convert.ToDateTime(rowValor["FechaVencimiento"]);
						IdCotizacion = Convert.ToString(rowValor["IdCotizacionMoneda"]);
						IdMoneda = Convert.ToString(rowValor["IdMoneda"]);	
						Monto = Convert.ToDecimal(rowValor["Valor"]);
						this.IdInstanciaCaja = Convert.ToString(rowValor["IdInstanciaCaja"]);
						//seteo los valores de la clase ValoresDatosAuxiliares
						_datoAuxiliar = new DatoAuxiliar(IdValor);
						_datoAuxiliar.GetDatoAuxiliar(IdValor);
					}
					*/
				}	
				#endregion	
			}
		}

		public void ListenerBeforeExecuteDependentTask(object sender)
		{
			// TODO: agregar la implementación Valor.ListenerBeforeExecuteDependentTask
		}

		public bool IsValidForStartProcess()
		{
			_errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_task);
			bool IsValid = validator.IsValidForStartProcess(this._process.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
		}

		public bool IsValid()
		{
			bool IsValid = true;
			_errores.Clear();
			
			if(!this.completoDatos())
			{
				IsValid = false;
				_errores.Add( new ItemDatasetError( "Valores","Valores","Falta completar información para 'Medio de Pago' especificado."));

			}
			if(!IsValidPercepcion()) 
			{								
				IsValid = false;
			}
			if(!IsValidNroCheque()){
				IsValid = false;
			}
			if(_task.Equals("DefinirValor") || _task.Equals("MovimientoCaja") || _task.Equals("SeleccionarFormasDePagos")|| _task.Equals("PagoACuenta"))
			{
				long IdTarea = Workflow.GetIdTakByName(_task);
				DataSet data = businessrules.twf_ProcesosTareasValidaciones.GetValidaciones(long.MinValue, IdTarea); //Sobrecarga para workflow
				if (data != null)
				{
					foreach (DataRow row in data.Tables[0].Rows) 
					{
						string Condicion = Convert.ToString(row["Validacion"]);				
						string Titulo = Convert.ToString(row["Titulo"]);
						string Mensaje = Convert.ToString(row["Mensaje"]);
						if (!Evaluator.EvaluateToBool(Condicion, this, false)) //Pasa false si la compilación da como resultado un error
							{
								IsValid = false;
								_errores.Add( new ItemDatasetError( Titulo,"Valor",Mensaje));

							}
						}
				}
			}
			

			return IsValid;

		}       

	public bool IsValidNroCheque() 
	{
		bool isValid = true;
		bool ok=false;				
		//Tengo q validar q el numero de cheque q me ingresen sea de alguna chequera abierta para esa cuenta y banco	
		if (this.PerteneceAPropio(this.IdTDCompTesoreria)){
			string nroCuenta=this.DatoAuxiliar.CuentaBancaria;
			if (!nroCuenta.Equals(string.Empty))
			{
				tfi_CuentaBancariaDataset cuenta=tfi_CuentaBancaria.GetList(string.Empty,string.Empty,string.Empty,nroCuenta,string.Empty);
				string idCuentaBancaria=Convert.ToString(cuenta.Tables[0].Rows[0]["IdCuenta"]);
				string idBanco=Convert.ToString(cuenta.Tables[0].Rows[0]["IdBanco"]);
				tfi_ChequeraDataset data =tfi_Chequera.GetListAbierta(idBanco, idCuentaBancaria);
				if (data.Tables[0].Rows.Count!=0)
				{
					if (!this.Numero.Equals(string.Empty))
					{
						long numeroCheque=Convert.ToInt64(this.Numero);

						foreach(tfi_ChequeraDataset.tfi_ChequeraRow row in  data.Tables[0].Rows)
						{
							//Si el numero de cheque esta dentro de las chequeras abiertas para esa sucursal :D
							long comienzaEn=Convert.ToInt64(row["Comienzo"]);
							long finalizaEn=Convert.ToInt64(row["Final"]);

							if ((numeroCheque>comienzaEn && numeroCheque<finalizaEn) ||(numeroCheque==comienzaEn) ||(numeroCheque==finalizaEn))
								ok=true;						

						}
						if (!ok)
						{
							_errores.Add( new ItemDatasetError( "Valor","Nro Cheque","Ninguna chequera abierta de esa cuenta bancaria tiene ese numero de cheque") );
							isValid = false;
						}
					}
					else{
						_errores.Add( new ItemDatasetError( "Valor","Nro Cheque","Ingrese el numero de cheque") );
						isValid = false;
					}
					}
				else
				{
					_errores.Add( new ItemDatasetError( "Valor","Nro Cheque","No hay ninguna chequera abierta para la cuenta del banco q selecciono") );
					isValid = false;
				}
			
			}
			else
			{
				_errores.Add( new ItemDatasetError( "Valor","Cuenta Bancaria, Banco","Seleccione una entidad y una cuenta bancaria") );
				isValid = false;
			}
			
		}		
			
		
		
		return isValid;
	}

		public bool IsValidPercepcion() 
		{
			bool isValid = true;						
			
			string CompTesoreria = MAPStaticInfo.GetFDP(this.IdTDCompTesoreria);			
			
			if (CompTesoreria == "Retenciones") 
			{												

				if (_datoAuxiliar.IdCuenta == String.Empty || _datoAuxiliar.IdCuenta == null) 

				{
					ItemDatasetError error = new ItemDatasetError("Retención","Retención","El cliente no fue seleccionado");
					_errores.Add( error );					
					return false;
				}
				else 
				{
					//verifico q no existe entre las retenciones grabadas en la BD.
					if (tfi_Valores.ExisteRetencion(_datoAuxiliar.IdCuenta, _idTDCompTesoreria, _numero, _datoAuxiliar.IdTipoDeRetencion, _datoAuxiliar.FechaDeRecepcion)) 
					{
						ItemDatasetError error = new ItemDatasetError("Percepción","Percepción","El número de percepción ya fue ingresado anteriormente");
						_errores.Add( error );						
						return false;
					}
					else 
					{
						return true;
					}	
				}
			}
			return isValid;
		}

		public bool AllowShow()
		{
			return true;
		}

		public void FormHasClosed() 
		{
		}
		public ItemsDatasetErrors GetErrors()
		{
			return _errores;
		}

		public string GetWarnings()
		{
			return null;
		}

		public ProcessManager GetProcessManagerParent()
		{
			return _process;
		}

		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_process= processManager;
			_processName = _process.Process.ProcessName;
		}

		public string GetTaskName()
		{
			return _task;
		}

		public void SetTaskName(string taskName)
		{
			_task=taskName;
		}

		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			this.AllowPrevious();
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public void ListenerAfterPreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación Valor.ListenerAfterPreviousDependentTask
		}

		public void ListenerBeforePreviousDependentTask(object sender)
		{
			// TODO: agregar la implementación Valor.ListenerBeforePreviousDependentTask
		}

	

		#endregion

		#region Miembros de IPersistentTask

		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;
		private TaskCollectionData _taskCollectionData = new TaskCollectionData();
		private mz.erp.commontypes.SentenciasReplicacion _replication = new mz.erp.commontypes.SentenciasReplicacion();

		public TaskCollectionData GetData()
		{
			return _taskCollectionData ;
		}

		public void Commit()
		{
			#region proceso modificar valor	
				if(this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
				{	
					//actualizo los valores 
					_rowValor = tfi_Valores.GetByPk(IdValor);
					_rowValor["IdTDCompTesoreria"] = this.IdTDCompTesoreria;
					_rowValor["Numero"] = this.Numero;
					_rowValor["IdEntidad"] = this.IdEntidad;
					_rowValor["Fecha"] = this.Fecha;
					_rowValor["FechaVencimiento"] = this.FechaVencimiento;
					_rowValor["Valor"] = this.Monto;
					_rowValor["IdMoneda"] = this.IdMoneda;
					_rowValor["IdCotizacionMoneda"] = this.IdCotizacion;
                    _rowValor["IdInstanciaCaja"] = this.IdInstanciaCaja;
					dataValor.tfi_Valores.ImportRow(_rowValor);
					//actualizo los valores datos auxiliares
					_rowValorDatoAuxiliar = tfi_ValoresDatosAuxiliares.GetByPk(IdValor);
					_rowValorDatoAuxiliar["CODIGO_AUT_TC_TD_TCCUO_"] = this._datoAuxiliar.CodigoAutorizacion;
					_rowValorDatoAuxiliar["CUPON_TC_TD_TCCUO_"]= this._datoAuxiliar.Cupon;
					if (!_datoAuxiliar.FechaDeAcreditacion.Equals(DateTime.MinValue))
                        _rowValorDatoAuxiliar["FECHA_ACREDIT_TC_TCCUO_"]= this._datoAuxiliar.FechaDeAcreditacion;
					else _rowValorDatoAuxiliar.SetFECHA_ACREDIT_TC_TCCUO_Null();
					if (!_datoAuxiliar.FechaDeAutorizacion.Equals(DateTime.MinValue))
						_rowValorDatoAuxiliar["FECHA_AUT_TC_TD_TCCUO_"]= this._datoAuxiliar.FechaDeAutorizacion;
					else _rowValorDatoAuxiliar.SetFECHA_AUT_TC_TD_TCCUO_Null();
					_rowValorDatoAuxiliar["LOTE_TC_TD_TCCUO_"]= this._datoAuxiliar.Lote;
					_rowValorDatoAuxiliar["CTA_BANCARIA_CHE_T_C_DT_D_DP_"]= this._datoAuxiliar.CuentaBancaria;
					_rowValorDatoAuxiliar["LIBRADOR_CHE_T_DT_"]= this._datoAuxiliar.Librador;
					_rowValorDatoAuxiliar["SUCURSAL_CHE_T_C_DT_D_DP_"]= this._datoAuxiliar.Sucursal;
					if (!_datoAuxiliar.FechaDePago.Equals(DateTime.MinValue))
						_rowValorDatoAuxiliar.FECHA_PAGO_CHE_T_DT_= _datoAuxiliar.FechaDePago;
					else _rowValorDatoAuxiliar.SetFECHA_PAGO_CHE_T_DT_Null(); 
					if (!_datoAuxiliar.FechaDeRecepcion.Equals(DateTime.MinValue))
						_rowValorDatoAuxiliar["FECHA_RECEP_CHE_T_C_DT_D_"]= _datoAuxiliar.FechaDeRecepcion;
					else _rowValorDatoAuxiliar.SetFECHA_RECEP_CHE_T_C_DT_D_Null();					
					_rowValorDatoAuxiliar["TIPO_RETENCION_RET_"]= this._datoAuxiliar.IdTipoDeRetencion;
					if (!_datoAuxiliar.FechaIngresoRetencion.Equals(DateTime.MinValue))
						_rowValorDatoAuxiliar["FECHA_INGRESO_RET_"]= this._datoAuxiliar.FechaIngresoRetencion;
					else _rowValorDatoAuxiliar.SetFECHA_INGRESO_RET_Null();
					if (!_datoAuxiliar.FechaComprobanteRetencion.Equals(DateTime.MinValue))
                        _rowValorDatoAuxiliar["FECHA_COMP_RET_"]= this._datoAuxiliar.FechaComprobanteRetencion;
					else _rowValorDatoAuxiliar.SetFECHA_COMP_RET_Null();
					_rowValorDatoAuxiliar["NROBOLETA_CHE_T_C_DT_D_"] = this._datoAuxiliar.NroBoleta;
					if(!_datoAuxiliar.FechaIngresoBanco.Equals(DateTime.MinValue))
						_rowValorDatoAuxiliar.FECHAINGBANCO_CHE_T_C_DT_D_  = _datoAuxiliar.FechaIngresoBanco;
					else _rowValorDatoAuxiliar.SetFECHAINGBANCO_CHE_T_C_DT_D_Null();
					_rowValorDatoAuxiliar["DESTINATARIO_CHE_DP_"]= this._datoAuxiliar.Destinatario;
					_rowValorDatoAuxiliar["IDDESTINATARIO_CHE_DP_"]= this._datoAuxiliar.IdDestinatario;
					_rowValorDatoAuxiliar["IDBANCO_CHE_DP_"]= this._datoAuxiliar.IdBanco;
					_rowValorDatoAuxiliar["BANCO_CHE_DP_"]= this._datoAuxiliar.Banco;
					_rowValorDatoAuxiliar["CRUZADO_CHE_T_C_DT_D_DP_"]= this._datoAuxiliar.Cruzado;
					_rowValorDatoAuxiliar["SELLADO_CHE_T_C_DT_D_DP_"]= this._datoAuxiliar.Sellado;
					_rowValorDatoAuxiliar["CODIGO10_TC_TD_TCCUO_"] = this._datoAuxiliar.CodigoDiez;
					dataValorDatoAuxiliar.tfi_ValoresDatosAuxiliares.ImportRow(_rowValorDatoAuxiliar);
				}		
			#endregion
		}	
			
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			#region MODIFICAR VALOR
		
			if(this._process.Process.ProcessName.Equals("ProcesoModificarValor"))
			{
				GenerateReplication();
				mz.erp.dataaccess.tfi_Valores.Update(dataValor.Tables[0], IdTransaction, _replication);
				mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.Update(dataValorDatoAuxiliar.Tables[0], IdTransaction, _replication);
			}
			#endregion
			

			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}
		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
		{
			_replication.IdConexion = Security.IdConexion;
			_replication.SucGeneradora = Security.IdSucursal;
			_replication.Destino = null;
			_replication.VersionBD = null;
			_replication.NombreTabla = "dataaccess.tfi_movimientosdecaja";
			return _replication;
		}

		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación Valor.PutExtraDataOnCommit
		}

		public void PutExtraData(ProcessCollectionData _processCollectionData)
		{
			// TODO: agregar la implementación Valor.PutExtraData
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}

		public bool GetHasSaved()
		{
			// TODO: agregar la implementación Valor.GetHasSaved
			return false;
		}

		#endregion

	}
}


	#region clases auxiliares
			
		
	public class DatoAuxiliar
	{
		#region constructores e inicializacion

		public DatoAuxiliar(string IdValor)
		{
			Init(IdValor);
		}

		public DatoAuxiliar()
		{
			
		}


		private void Init(string IdValor)
		{
			if (!(IdValor==null || IdValor.Equals(string.Empty)))
			{
				//trae los valores q estan guardados en la base de datos
				GetDatoAuxiliar(IdValor);
			}
		}

		public void GetDatoAuxiliar(string IdValor)
		{
			tfi_ValoresDatosAuxiliaresDataset.tfi_ValoresDatosAuxiliaresRow row = mz.erp.businessrules.tfi_ValoresDatosAuxiliares.GetByPk(IdValor);
			this.IdValor = IdValor;
			this.CodigoAutorizacion = Convert.ToString(row["CODIGO_AUT_TC_TD_TCCUO_"]);
			this.Cupon = Convert.ToString(row["CUPON_TC_TD_TCCUO_"]);
			this.FechaDeAcreditacion = Convert.ToDateTime(row["FECHA_ACREDIT_TC_TCCUO_"]);
			this.FechaDeAutorizacion = Convert.ToDateTime(row["FECHA_AUT_TC_TD_TCCUO_"]);
			this.Lote = Convert.ToString(row["LOTE_TC_TD_TCCUO_"]);
			this.CantidadCuotas = Convert.ToInt16(row["CANTIDAD_CUOTAS_TCCUO_"]);
			this.CuentaBancaria = Convert.ToString(row["CTA_BANCARIA_CHE_T_C_DT_D_DP_"]);
			this.Librador = Convert.ToString(row["LIBRADOR_CHE_T_DT_"]);
			this.Sucursal = Convert.ToString(row["SUCURSAL_CHE_T_C_DT_D_DP_"]);
			if (row["FECHA_PAGO_CHE_T_DT_"].GetType() == System.DBNull.Value.GetType())
				this.FechaDePago = DateTime.MinValue;
			else
				this.FechaDePago = Convert.ToDateTime(row["FECHA_PAGO_CHE_T_DT_"]);
			this.FechaDeRecepcion = Convert.ToDateTime(row["FECHA_RECEP_CHE_T_C_DT_D_"]);	
			this.IdTipoDeRetencion = Convert.ToString(row["TIPO_RETENCION_RET_"]);
			if (row["FECHA_INGRESO_RET_"].GetType() == System.DBNull.Value.GetType())
				this.FechaIngresoRetencion = DateTime.MinValue;
			else
				this.FechaIngresoRetencion = Convert.ToDateTime(row["FECHA_INGRESO_RET_"]);
			this.FechaComprobanteRetencion = Convert.ToDateTime(row["FECHA_COMP_RET_"]);
			this.NroBoleta = Convert.ToString(row["NROBOLETA_CHE_T_C_DT_D_"]);
			this.Cruzado=Convert.ToBoolean(row["CRUZADO_CHE_T_C_DT_D_DP_"]);
			this.Sellado=Convert.ToBoolean(row["SELLADO_CHE_T_C_DT_D_DP_"]);
			this.Destinatario=Convert.ToString(row["DESTINATARIO_CHE_DP_"]);
			if (row["FECHAINGBANCO_CHE_T_C_DT_D_"].GetType() == System.DBNull.Value.GetType())
				this.FechaIngresoBanco = DateTime.MinValue;
			else
				this.FechaIngresoBanco = Convert.ToDateTime(row["FECHAINGBANCO_CHE_T_C_DT_D_"]);
			this.CodigoDiez = Convert.ToString(row["CODIGO10_TC_TD_TCCUO_"]);
			this._idDestinatario = Convert.ToString(row["IDDESTINATARIO_CHE_DP_"]);
			this._idBanco = Convert.ToString(row["IDBANCO_CHE_DP_"]);
			this._banco = Convert.ToString(row["BANCO_CHE_DP_"]);
			_cuentasBancarias=tfi_CuentaBancaria.GetListPorBanco(_idBanco);
			//SetBanco();
		}

		private void SetBanco()
		{
			if(_CuentaBancaria != null && _CuentaBancaria != string.Empty)
			{
				DataSet data =  mz.erp.businessrules.tfi_CuentaBancaria.GetList(null, null, null, _CuentaBancaria, null);
				if(data.Tables[0].Rows.Count > 0)
				{
					DataRow row = data.Tables[0].Rows[0];
					IdBanco =Convert.ToString(row["IdBanco"]);
				}
			}
		}


		#endregion

		#region variables
		
		private string _CodigoAutorizacion = string.Empty;
		private string _Cupon = string.Empty;
		private DateTime _FechaDeAcreditacion = DateTime.Now;
		private DateTime _FechaDeAutorizacion = DateTime.Now;
		private string _Lote= string.Empty;
		private short _CantidadCuotas = 0;
		private string _CuentaBancaria= string.Empty;
		private string _Librador= string.Empty;
		private string _Destinatario=string.Empty;
		private string _idDestinatario=string.Empty;
		public bool _Cruzado=false;
		public bool _Sellado=false;
		private string _Sucursal= string.Empty;
		private DateTime _FechaDePago = DateTime.MinValue; //DateTime.Now;
		private DateTime _FechaDeRecepcion = DateTime.Now;
		private string _IdTipoDeRetencion= string.Empty;
		private string _IdValor= string.Empty;
		private DateTime _FechaIngresoRetencion = DateTime.Now;
		private DateTime _FechaComprobanteRetencion = DateTime.Now;
		private string _idCuenta = string.Empty;
		private string _nroBoleta = string.Empty;
		private string _codigoDiez = string.Empty;
		private DateTime _fechaIngresoBanco = DateTime.MinValue; 

		private string _idBanco=string.Empty;
		private string _banco = string.Empty;
		private DataTable _cuentasBancarias = tfi_CuentaBancaria.GetListPorBanco(string.Empty);

		#endregion
		
		#region acceso a datos

		
		public string IdBanco
		{
			get 
			{
				return _idBanco;
			}
			set
			{
				if(value != _idBanco)
				{
					_idBanco=value;
					DataRow row = mz.erp.businessrules.tfi_Banco.GetByPk( _idBanco);
					if(row != null)
						_banco = Convert.ToString(row["Nombre"]);
					_cuentasBancarias=tfi_CuentaBancaria.GetListPorBanco(_idBanco);
				}
			
			}
		}

		public DataTable CuentasBancarias
		{
			get{return _cuentasBancarias;}
		}

		public string Banco
		{
			get{return _banco;}
		}
		



		public string IdValor
		{
			set { _IdValor = value;}
			get { return _IdValor;}
		}

		public string CodigoAutorizacion
		{
			set { _CodigoAutorizacion = value;}
			get { return _CodigoAutorizacion;}
		}

		public string Cupon
		{
			set { _Cupon = value;}
			get { return _Cupon;}
		}
		public DateTime FechaDeAcreditacion
		{
			set { _FechaDeAcreditacion = value;}
			get { return _FechaDeAcreditacion;}
		}
		public DateTime FechaDeAutorizacion
		{
			set { _FechaDeAutorizacion = value;}
			get { return _FechaDeAutorizacion;}
		}
		public string Lote
		{
			set { _Lote = value;}
			get { return _Lote;}
		}
		public short CantidadCuotas
		{
			set { _CantidadCuotas = value;}
			get { return _CantidadCuotas;}
		}
		public string CuentaBancaria
		{
			set { _CuentaBancaria = value;	}
			get { return _CuentaBancaria;}
		}
		public string Librador
		{
			set { _Librador = value;}
			get { return _Librador;}
		}

		public string IdDestinatario
		{
			set { _idDestinatario = value;}
			get { return _idDestinatario;}
		}

		public string Destinatario
		{
			set { _Destinatario = value;}
			get { return _Destinatario;}
		}
		public bool Cruzado
		{
			set { _Cruzado = value;}
			get { return _Cruzado;}
		}
		public bool Sellado
		{
			set { _Sellado = value;}
			get { return _Sellado;}
		}
		
		public string IdCuenta
		{
			set { _idCuenta = value;}
			get { return _idCuenta;}
		}
		
		public string Sucursal
		{
			set { _Sucursal = value;}
			get { return _Sucursal;}
		}
		public DateTime FechaDePago
		{
			set { _FechaDePago = value;}
			get { return _FechaDePago;}
		}
		public DateTime FechaDeRecepcion
		{
			set { _FechaDeRecepcion = value;}
			get { return _FechaDeRecepcion;}
		}
		public string IdTipoDeRetencion
		{
			set { _IdTipoDeRetencion = value;}
			get { return _IdTipoDeRetencion;}
		}
		public DateTime FechaIngresoRetencion
		{
			set { _FechaIngresoRetencion = value;}
			get { return _FechaIngresoRetencion;}
		}
		public DateTime FechaComprobanteRetencion
		{
			set { _FechaComprobanteRetencion = value;}
			get { return _FechaComprobanteRetencion;}
		}
		public string NroBoleta
		{
			set{ _nroBoleta = value;}
			get{ return _nroBoleta;}
		}
		public string CodigoDiez
		{
			set{ _codigoDiez = value;}
			get{ return _codigoDiez ;}
		}
		public DateTime FechaIngresoBanco
		{
			set{ _fechaIngresoBanco = value;}
			get{ return _fechaIngresoBanco;}
		}
		#endregion

		#region metodos publicos
		
		public void Commit(tfi_ValoresExDataset data, string IdValor)
		{
			tfi_ValoresExDataset.tfi_ValoresDatosAuxiliaresRow row = data.tfi_ValoresDatosAuxiliares.Newtfi_ValoresDatosAuxiliaresRow();
  			row.IdValor = IdValor;
			row.SUCURSAL_CHE_T_C_DT_D_DP_ = _Sucursal;
			row.LOTE_TC_TD_TCCUO_ = _Lote;
			row.LIBRADOR_CHE_T_DT_ = _Librador;
			row.DESTINATARIO_CHE_DP_= _Destinatario;
			row.CRUZADO_CHE_T_C_DT_D_DP_=_Cruzado;
			row.SELLADO_CHE_T_C_DT_D_DP_=_Sellado;
			row.FECHA_RECEP_CHE_T_C_DT_D_ = _FechaDeRecepcion;
			if(!_FechaDePago.Equals(DateTime.MinValue))
				row.FECHA_PAGO_CHE_T_DT_ = _FechaDePago;
			else row.SetFECHA_PAGO_CHE_T_DT_Null();
			row.FECHA_AUT_TC_TD_TCCUO_ = _FechaDeAutorizacion;
			row.FECHA_ACREDIT_TC_TCCUO_ = _FechaDeAcreditacion;
			row.CUPON_TC_TD_TCCUO_ = _Cupon;
			row.CTA_BANCARIA_CHE_T_C_DT_D_DP_ = _CuentaBancaria;
			row.CODIGO_AUT_TC_TD_TCCUO_ = _CodigoAutorizacion;
			if (_CantidadCuotas == short.MinValue)
				row.CANTIDAD_CUOTAS_TCCUO_ = 0;
			else row.CANTIDAD_CUOTAS_TCCUO_ = _CantidadCuotas;
			row.TIPO_RETENCION_RET_ = _IdTipoDeRetencion;
			row.FECHA_INGRESO_RET_ = _FechaIngresoRetencion;
			row.FECHA_COMP_RET_ = _FechaComprobanteRetencion;
			row.NROBOLETA_CHE_T_C_DT_D_ = _nroBoleta;
			if(!_fechaIngresoBanco.Equals(DateTime.MinValue))
				row.FECHAINGBANCO_CHE_T_C_DT_D_  = _fechaIngresoBanco;
			else 
				row.SetFECHAINGBANCO_CHE_T_C_DT_D_Null();
			row.CODIGO10_TC_TD_TCCUO_ = _codigoDiez;
			row.IDDESTINATARIO_CHE_DP_ = _idDestinatario;
			row.IDBANCO_CHE_DP_ = _idBanco;
			row.BANCO_CHE_DP_ = _banco;

			data.tfi_ValoresDatosAuxiliares.Addtfi_ValoresDatosAuxiliaresRow(row);
		}
		
		//ojooooo feisisisismo sacarlo urgentemente a un XML
		public bool verificateCon(string datosARevisar)
		{
			//verifica q la variable auxiliar este completa con respecto a lo q dice en la var de configuracion
			if (datosARevisar != null)
			{
				bool result = true;
				string[] _datosARevisar = datosARevisar.Split(',');
				for(int i=0; i < _datosARevisar.Length; i++)
				{
					switch ( _datosARevisar[i].ToString() )
					{	
						case "CODIGO_AUT_TC_TD_TCCUO_":
							result = result && (this._CodigoAutorizacion != null && this._CodigoAutorizacion != string.Empty);
							break;
						case "CUPON_TC_TD_TCCUO_":
							result = result && (this._Cupon != null && this._Cupon != string.Empty);
							break;
						case "FECHA_ACREDIT_TC_TCCUO_":
							result = result && (this._FechaDeAcreditacion.Date != DateTime.MinValue);
							break;
						case "FECHA_AUT_TC_TD_TCCUO_":
							result = result && (this._FechaDeAutorizacion.Date != DateTime.MinValue);
							break;
						case "LOTE_TC_TD_TCCUO_":
							result = result && (this._Lote != null && this._Lote!= string.Empty);
							break;
						case "CANTIDAD_CUOTAS_TCCUO_":
							result = result && (this._CantidadCuotas != 0 && this._CantidadCuotas!= short.MinValue);
							break;
						case "CTA_BANCARIA_CHE_T_C_DT_D_":
							result = result && (this._CuentaBancaria != null && this._CuentaBancaria!= string.Empty);
							break;
						case "LIBRADOR_CHE_T_DT_":
							result = result && (this._Librador != null && this._Librador!= string.Empty);
							break;
						case "SUCURSAL_CHE_T_C_DT_D_":
							result = result && (this._Sucursal != null && this._Sucursal!= string.Empty);
							break;
						case "FECHA_PAGO_CHE_T_DT_":
							result = result && (this._FechaDePago.Date != DateTime.MinValue);
							break;
						case "FECHA_RECEP_CHE_T_C_DT_D_":
							result = result && (this._FechaDeRecepcion.Date != DateTime.MinValue);
							break;
						case "TIPO_RETENCION_RET_":
							result = result && (this._IdTipoDeRetencion != null && this._IdTipoDeRetencion!= string.Empty);
							break;
						case "FECHA_INGRESO_RET_":
							result = result && (this._FechaIngresoRetencion.Date != DateTime.MinValue);
							break;
						case "FECHA_COMP_RET_":
							result = result && (this._FechaComprobanteRetencion.Date != DateTime.MinValue);
							break;		
						case "NROBOLETA_CHE_T_C_DT_D_":
							result = result && (this._nroBoleta != null && this._nroBoleta != string.Empty);
							break;
						case "FECHAINGBANCO_CHE_T_C_DT_D_":
							result = result && (this._fechaIngresoBanco.Date != DateTime.MinValue);
							break;
						case "CODIGO10_TC_TD_TCCUO_":
							result = result && (this._codigoDiez!= null && this._codigoDiez!= string.Empty);
							break;
						case "DESTINATARIO_CHE_DP_":
							result = result && (this._Destinatario!= null && this._Destinatario!= string.Empty);
						break;
						case "CRUZADO_CHE_T_C_DT_D_DP_":
							result = result && (this._Cruzado!= false);
						break;
						case "SELLADO_CHE_T_C_DT_D_DP_":
							result = result && (this._Sellado!= false);
						break;
						case "IDDESTINATARIO_CHE_DP_":
							result = result && (this._idDestinatario!= null && this._idDestinatario!= string.Empty);
							break;
						case "IDBANCO_CHE_DP_":
							result = result && (this._idBanco!= null && this._idBanco!= string.Empty);
							break;
						case "BANCO_CHE_DP_":
							result = result && (this._banco!= null && this._banco!= string.Empty);
							break;

					}
				}
				return (result);
			}
			return (true);
		}
		#endregion
	}


	
	
	#endregion






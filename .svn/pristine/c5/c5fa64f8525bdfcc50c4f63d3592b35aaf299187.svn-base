using System;
using System.Collections;
using System.Data;

using mz.erp.businessrules.data;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.systemframework;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Descripción breve de ComprobanteDePago.
	/// Esta clase representa a aquellos comprobantes que generan un Debito.
	/// Pueden estar asociados a una Cuenta Corriente, sobre la cual pueden llegar ser usados para
	/// imputar otros comprobantes en dicha Cuenta Corriente.
	/// Tambien pueden agregarse a Cuenta, es decir generando un credito en la Cuenta Corriente del
	/// Cliente titular del Comprobante.
	/// Ademas Los Comprobantes de Pago tiene asociados los valores que constituyen su valor Total.
	/// </summary>
	public class ComprobanteDePago: Comprobante, ITask, IPersistentTask
	{
		
		#region Constructores

		public ComprobanteDePago()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			_signoCuentaCorriente = 1;
		}

		#endregion

		#region Variables Privadas

		
		private Valores _valores;
		private ComprobantesDetalleDePagos _compDetalleDePagos;
		private bool _anular = false;
		private AplicacionesDePagos _aplicacionesDePagos;
		private CuentaCorriente _cuentaCorriente;
		private decimal _totalPago;
		
		private ComprobanteDeVenta _comprobanteDeVenta;
		private string _momento;
	
		private RelacionesComprobanteOrigenDestino _relacionesComprobanteOrigenDestino;
		private ArrayList _precomprobantesDePago = new ArrayList();
		private ArrayList _detalleCtaCteADesimputar = new ArrayList();
		private ArrayList _cancelacionesDePago = new ArrayList();

		private ArrayList _desimpuatcionDetalleDeudaDataSets = new ArrayList();
		private ArrayList _desimputacionAplicacionPagoDataSets = new ArrayList();
		private ArrayList _cancelacionesDePagoDataSets = new ArrayList();
		private ArrayList _cotizaciones = new ArrayList();
		
		
		private ArrayList _arrData = null;
		ProcessManager _processParent = null;
		private string _taskName = null;
		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		private bool _allowShow = true;
		private bool _allowSave = true;
		

		private bool _allowEditTipoDeComprobante = true;
		private bool _allowEditCuenta = true;
		private bool _allowEditFecha = true;
		private bool _allowEditResponsableEmision = true;
		private bool _allowEditFormasDePago = true;
		private bool _allowEditNumeration = false;
		private bool _actualizaNumeracion = true;
		private bool _allowEditImputacion = true;
		private bool _allowEditValores = true;
		private bool _allowEditInstanciaDeCaja = false;
		private bool _allowValidarNumeracion = false;

		private bool _preguntarAlCancelar = false;

		private CondicionDeVenta _condicionDeVentaComptobanteDeVenta;
		private string _idCondicionDeVentaComptobanteDeVenta = string.Empty;
		private decimal _totalComprobanteDeVenta;
		private decimal _totalComprobanteDeVentaDesdeRecargos;
		private bool _hasRecargos = false;
		private string _idComprobanteDeVenta = string.Empty;
		private string _idTipoDeComprobanteDeVenta = string.Empty;
		private string _tipoDeComprobanteDeVenta = string.Empty;
		private string _numeroComprobanteDeVenta = string.Empty;
		private string _responsable = string.Empty;
		private int _signoComprobanteDeVenta = -1;
		private DateTime _fechaComprobanteDeVenta = mz.erp.businessrules.Sistema.DateTime.Now;

		private string _errorCaja = string.Empty;
		private DataTable _instanciasCajasAbiertas ;
			

		private Hashtable _idValoresIdFormasDePagosTable = new Hashtable();
		private string _numeroDefault = string.Empty;
		
		/*Esta variable controla si los valores se generan nuevamente o se mantiene el mismo valor*/
		/*El valor de esta variable debe ser el mismo q la variable q se usa en la clase RecargosFormasDePago*/
		private bool _creaIdValoresNuevos = true;

		private bool _desimputaYAnulaComprobanteDePagoPrevio =  false;

		private bool _askForPasswordResponsableEmision = false;

		private bool _allowSearchValores = false;
		private bool _validarValoresExistentes = false;
		private bool _validarSignoValoresExistentes = false;

		private string _nombreCliente = string.Empty;

		//German 20091120
		private bool _allowValidarFechaEmisionMayorFechaActual = false;
		//Fin German 20091120

		/* Silvina 20100609 - Tarea 459 */
		private bool _validarMontoDisponibleDeCaja = false;
		/* Fin Silvina */

        /* Silvina 20101020 - Tarea 899 */
        private bool _validarCheques = false;
        /* Fin Silvina */

        //Sabrina: Tarea 1117. 20110816
        private bool _allowEditImputaAutomaticamente = false;
        private bool _imputaAutomaticamente = false;
        //Fin Sabrina: Tarea 1117. 20110816

        //Sabrina: Tarea 1119. 20110816
        private SortOrder _sortOrder = SortOrder.EmisionAsc;
        //Fin Sabrina: Tarea 1119. 20110816

        /* Silvina 20111230 - Tarea 0000245 */
        private bool _numeracionPorUsuario = false;
        private bool _numeracionPorPerfil = false;
        private string _listaTiposDeComprobantesSugiereNumeracion = string.Empty;
        /* Fin Silvina 20111230 - Tarea 0000245 */

        #endregion

		#region Variables y Propiedades Publicas
		public bool AllowSearchValores
		{
			get{return _allowSearchValores;}
		}

		public override string IdResponsable
		{
			get{return _IdResponsable;}
			set 
			{
				if(_IdResponsable != value)
				{
					_IdResponsable = value;
					GetInstanciaDeCaja();
                    /* Silvina 20111230 - Tarea 0000245 */
                    RefreshNumeracion();
                    /* Fin Silvina 20111230 - Tarea 0000245 */
					if(IdResponsableChanged != null)
						IdResponsableChanged(this, EventArgs.Empty);
				}
			}
		}

		public string NombreCliente
		{
			get{return _nombreCliente;}
			set 
			{
				if(_nombreCliente != value)
				{
					_nombreCliente = value;
					if(NombreClienteChanged != null)
						NombreClienteChanged(this, EventArgs.Empty);
				}
			}
		}

		public bool AskForPasswordResponsableEmision
		{
			set { _askForPasswordResponsableEmision = value; }
			get 
			{ 
				//_askForPasswordResponsableEmision = Variables.GetValueBool("Pantalla.ComprobanteDeVenta.AskForPasswordResponsableEmision");
				return _askForPasswordResponsableEmision; 				
			}
		}

		public DateTime FechaComprobanteDeVenta
		{
			set{ _fechaComprobanteDeVenta = value;}
			get{ return _fechaComprobanteDeVenta;}
		}

        /* Silvina 20111212 - Tarea 0000232 */
        
        private DateTime _fechaReserva = mz.erp.businessrules.Sistema.DateTime.Now;

        public DateTime FechaReserva
        {
            set { _fechaReserva = value; }
            get { return _fechaReserva; }
        }

        /* Fin Silvina 20111212 - Tarea 0000232 */

		public DataTable InstanciasCajasAbiertas
		{
			get{return _instanciasCajasAbiertas;}
		}

		public bool AllowEditInstanciaDeCaja
		{
			get
			{
				return _allowEditInstanciaDeCaja ;
			}
		}

		public bool AllowEditValores
		{
			get
			{
				return _allowEditValores;
			}
			set
			{
				_allowEditValores = value;
			}
		}

		public bool AllowEditImputacion
		{
			get
			{	
				return _allowEditImputacion;
			}
			set
			{
				_allowEditImputacion = value;
			}
		}

		public bool PreguntarAlCancelar
		{
			get {return _preguntarAlCancelar ;}
		}

		public decimal TotalImputado
		{
			get
			{
				decimal ti = 0;
				foreach(DetalleCuentaCorriente dcc in this._cuentaCorriente.Detalle)
				{
					ti = ti + dcc.Pago;
				}
				return ti;
			}
		}
		public override decimal Saldo
		{
			get
			{
				if(this._cuentaCorriente != null)
					//return decimal.Round(this._total - this._cuentaCorriente.TotalImputado,2);
					return decimal.Round(this._total - this.TotalImputado,2);
				else
					return decimal.Round(this._total,2);
			}
			set
			{
				base.Saldo = value;
			}
		}

/*
		public ArrayList Cotizaciones
		{
			get
			{
				return _cotizaciones;
			}
		}
		*/

		public bool AllowEditTipoDeComprobante
		{
			set 
			{
				_allowEditTipoDeComprobante = value; 
			}
			get
			{ 
				return _allowEditTipoDeComprobante; 
			}
		}



		public bool AllowEditCuenta
		{
			set
			{
				_allowEditCuenta = value; 
			}
			get
			{ 
				return _allowEditCuenta; 
			}
		}

		public bool AllowEditFecha
		{
			set 
			{ 
				_allowEditFecha = value; 
			}
			get 
			{
				return _allowEditFecha; 
			}
		}

		public bool AllowEditResponsableEmision
		{
			set
			{ 
				_allowEditResponsableEmision = value; 
			}
			get
			{ 
				return _allowEditResponsableEmision; 
			}
		}

        public bool AllowEditFormasDePago
		{
			set
			{ 
				_allowEditFormasDePago = value; 
			}
			get
			{ 
				return _allowEditFormasDePago; 
			}
		}

		public bool ActualizaNumeracion 
		{
			set
			{ 
				_actualizaNumeracion = value;
			}
			get
			{ 
				return _actualizaNumeracion; 
			}
		}

		public bool AllowEditNumeration
		{
			set
			{ 
				_allowEditNumeration = value;
			}
			get
			{ 
				return _allowEditNumeration; 
			}
		}
		
		public override string IdCuenta
		{
			get
			{
				return base.IdCuenta;
			}
			set
			{
				if(value != _idCuenta)
				{
					_idCuenta = value;
					_codigoCuenta = mz.erp.businessrules.tsa_Cuentas.GetUkByPk(_idCuenta);
				}	
				if(this._cuentaCorriente != null)
					if(_idCuenta != null && _idCuenta != string.Empty && this._cuentaCorriente.IdCuenta != value)
					{
						this.CuentaCorriente = Factory.GetCuentaCorriente(this._idCuenta, DateTime.MinValue, DateTime.MaxValue, null);
						this._cuentaCorriente.GetDetalleComprobantesAImputar(this._processParent.Process.ProcessName, this._taskName);
					}
			}
		}
		
		public override string CodigoCuenta
		{
			get
			{
				return _codigoCuenta;
			}
			set
			{
				if(_codigoCuenta != value)
				{
					_codigoCuenta = value;
					_idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(_codigoCuenta);
				}
				if(this._cuentaCorriente != null)
				{
					if(_idCuenta != null && _idCuenta != string.Empty && this._cuentaCorriente.IdCuenta != _idCuenta)
					{
						this.CuentaCorriente = Factory.GetCuentaCorriente(this._idCuenta, DateTime.MinValue, DateTime.MaxValue, null);
						//ojo modif cta_cte
						this._cuentaCorriente.GetDetalleComprobantesAImputar(this._processParent.Process.ProcessName, this._taskName);
					}
					else
						if(_idCuenta == null || _idCuenta == string.Empty)
						this._cuentaCorriente.IdCuenta = string.Empty;
					
				}
			}
		}

		
		public string Observaciones
		{
			get
			{
				return _observaciones;
			}
			set
			{
				if(_observaciones != value)
				{
					_observaciones = value;					
				}
			}
		}

		public bool Anular
		{
			get
			{
				return _anular;
			}
			set 
			{
				_anular = value;
			}

		}

		public ComprobanteDeVenta ComprobanteDeVenta
		{
			set
			{
				_comprobanteDeVenta = value;
			}
			get
			{
				return _comprobanteDeVenta;
			}
		}

		
		public decimal TotalPago
		{
			get
				{
					return _totalPago;
				}
			set	
				{
					_totalPago = value;
				}
		}

		
		public event EventHandler	TotalChanged;
		
		public CuentaCorriente CuentaCorriente
		{
			get {return _cuentaCorriente;}
			set
			{
				if(_cuentaCorriente != value)
				{
					
					_cuentaCorriente = value;
					_cuentaCorriente.TotalImputadoChanged +=new EventHandler(_cuentaCorriente_TotalImputadoChanged);
                    //German 20120125 - Tarea 0000256
                    _cuentaCorriente.SaldoAImputarChanged += new EventHandler(_cuentaCorriente_SaldoAImputarChanged);
                    //Fin German 20120125 - Tarea 0000256
				}
			}

		}

        //German 20120125 - Tarea 0000256
        void _cuentaCorriente_SaldoAImputarChanged(object sender, EventArgs e)
        {
            if (SaldoAImputarChanged != null)
                SaldoAImputarChanged(this, EventArgs.Empty);
        }
        //German 20120125 - Tarea 0000256

		/// <summary>
		/// Propiedad. Devuelve el nombre del responsable de la emisión del comprobante.
		/// </summary>		
		public string Responsable
		{
			get { return _responsable; }
			//set { _responsable = value; }
		}
		
		public Valores Valores
		{
			get{return _valores;}
			set{_valores = value;}

		}

		public AplicacionesDePagos AplicacionesDePagos
		{
			get {return _aplicacionesDePagos;}
			set {_aplicacionesDePagos = value;}

		}

		
		/// <summary>
		///Propiedad que representa el Total del Comprobante de Pago
		///Levanta el evento TotalChanged para que la interfaz de usuario refleje su valor Actual
		/// </summary>
		
		public override  decimal Total
		{
			get { return decimal.Round(_total,2);}
			set 
			{
				if (_total != value) 
				{
					_total= value ;
					this._condicionDeVenta.Refresh();
					if(this.CuentaCorriente!= null)
					{
						//UpdateCuentaCorriente();
						this._saldo = _total - this.CuentaCorriente.TotalImputado;

					}
					else this._saldo = 0;
					if (TotalChanged != null)
						TotalChanged(this, new EventArgs());
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
			}
		}

		public ComprobantesDetalleDePagos CompDetalleDePagos
		{
			get{return _compDetalleDePagos;}
			set{_compDetalleDePagos = value;}
		}
	
		public override string TipoComprobanteDestino
		{
			get
			{
				return base.TipoComprobanteDestino;
			}
			set
			{
				base.TipoComprobanteDestino = value;
				this.Signo = Convert.ToInt32(mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk( base.TipoComprobanteDestino).signo);
                /* Silvina 20111230 - Tarea 0000245 */
                RefreshNumeracion();
                if (ObjectHasChanged != null)
                    ObjectHasChanged(this, new System.EventArgs());
                /* Fin Silvina 20111230 - Tarea 0000245 */
			}
		}

		
		

		public bool HasErrors
		{
			get
			{
				if (_errores.Count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		public ItemsDatasetErrors Errores
		{
			get
			{
				return _errores;
			}
		}
		
		public bool IsValidCuenta
		{
			get 
			{
				if ((this.IdCuenta== null) || (this.IdCuenta == string.Empty))
					return false;
				else
					return true;
			}
		}
		public bool IsValidResponsable
		{
			get
			{
				if ((this.IdResponsable == null) || (this.IdResponsable == string.Empty))
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}
		public bool IsValidInstanciaDeCaja
		{
			get
			{
				if(MustValidateInstanciaDeCaja())
				{
					if ((this.IdInstanciaCaja == null) || (this.IdInstanciaCaja == string.Empty))
					{
						return false;
					}
					else
					{
						return true;
					}
				}
				else
					return true;
			}
		}
		
		public bool IsValidMonto
		{
			get
			{
                //German 20111202 - Tarea 0000232
                if (this._processParent.Process.ProcessName.Equals("ProcesoPrevenderReserva")) return true;
                //Fin German 20111202 - Tarea 0000232

				if(this._condicionDeVentaComptobanteDeVenta != null && !((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas"))
					|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
					/*Hasta 4 centavos de diferencia - Ver este tema bien con Pablo*/
					return this.Total >= (this._condicionDeVentaComptobanteDeVenta.GetObligatoryPayment()- Convert.ToDecimal(0.04));
				else
					if(this._processParent.Process.ProcessName.Equals("ProcesoPagar")|| this._processParent.Process.ProcessName.Equals("ProcesoPagoACuentaDV")
					|| this._processParent.Process.ProcessName.Equals("ProcesoDevolverPago")
					|| this._processParent.Process.ProcessName.Equals("ProcesoDevolverPagoDV")
					|| this._processParent.Process.ProcessName.Equals("ProcesoPagarManual"))
						return this.Total > 0;
					else
						if((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas"))
						|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV"))
						{
							return this.Total >= ( this._condicionDeVentaComptobanteDeVenta.GetObligatoryPayment(_totalComprobanteDeVentaDesdeRecargos) - Convert.ToDecimal(0.04));
						}
					
				else return true;
				
			}
		}
		public bool IsValidMontoConImputacion
		{
			get
			{

                //German 20111202 - Tarea 0000232
                if (this._processParent.Process.ProcessName.Equals("ProcesoPrevenderReserva")) return true;
                //Fin German 20111202 - Tarea 0000232

				if(this._condicionDeVentaComptobanteDeVenta != null && !((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas"))
					|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")))
					/*Hasta 4 centavos de diferencia - Ver este tema bien con Pablo*/
					return this.Total >= (this._condicionDeVentaComptobanteDeVenta.GetObligatoryPayment()- Convert.ToDecimal(0.04));
				else
					if(this._processParent.Process.ProcessName.Equals("ProcesoPagar")|| this._processParent.Process.ProcessName.Equals("ProcesoPagoACuentaDV")
					|| this._processParent.Process.ProcessName.Equals("ProcesoPagarManual"))
					return this.Total >= this.CuentaCorriente.TotalImputado;
					else
						if((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas"))
						|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV"))
						{
							return this.Total >= ( this._condicionDeVentaComptobanteDeVenta.GetObligatoryPayment(_totalComprobanteDeVentaDesdeRecargos) - Convert.ToDecimal(0.04));
						}
						else return true;				
			}
		}		
		


		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{
				string valor = String.Empty;
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonAnterior";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonAnterior";
					valor = Variables.GetValueString(variable);		
				}
				if (valor == String.Empty) 
				{
					return _textoBotonAnterior;
				}
				else 
				{
					return valor;
				}							
			}
		}
		private string _textoBotonSiguiente = "Siguiente";
		public string TextoBotonSiguiente
		{
			get 
			{		
				string valor = String.Empty;				
				string variable = "Momentos." + this.GetTaskName() + "." + this._processParent.Process.ProcessName + "." + "TextoBotonSiguiente";
				valor = Variables.GetValueString(variable);
				if (valor == String.Empty)
				{
					variable = "Sistema.Interfaz.TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);				
				}									
				if (valor == String.Empty) 
				{
					return _textoBotonSiguiente;
				}
				else 
				{
					return valor;
				}
			}
		}

		private bool _renombraClienteDePaso = false;
		public bool RenombraClienteDePaso
		{
			get{return _renombraClienteDePaso;}
			
		}

        //Sabrina: Tarea 1117. 20110816
        public bool AllowEditImputaAutomaticamente
        {
            get { return _allowEditImputaAutomaticamente; }

        }

        public bool ImputaAutomaticamente
        {
            get { return _imputaAutomaticamente; }
            set { _imputaAutomaticamente = value; }
        }
        //Fin Sabrina: Tarea 1117. 20110816
		
		#endregion
		
		#region Metodos Publicos
		/// <summary>
		///Agrega un nuevo Valor a la Coleccion de Valores de un Comprobante de Pago
		///Se vincula al evento ValorChange de la clase Valor para que cuando el el total de Valor
		///cambie, se recalcule el Total del comprobante de Pago.
		/// </summary>
		/// 


		public bool Contains(Valor valor)
		{
			return this.Valores.Contains(valor);
		}


		public void AddValor(Valor valor)
		{
			this.Valores.Add(valor);
			this.Recalcular();
			valor.ValorChange += new Valor.ValorChangeEventHandler(Recalcular);

            //Sabrina: Tarea 1119. 20110816
            if (ImputaAutomaticamente)
            {
                ArrayList comprobantesAImputar = this.SortComprobantesAImputar();
                int i = 0;
                decimal restoValor = Math.Abs(valor.MontoCotizado);
                while (restoValor != 0 && i < comprobantesAImputar.Count)
                {
                    DetalleCuentaCorriente dcc = (DetalleCuentaCorriente)comprobantesAImputar[i];
                    decimal restoAImputar = Math.Abs(dcc.Saldo) - Math.Abs(dcc.Pago);
                    if (restoAImputar != 0)
                    {
                        if (restoValor >= restoAImputar)
                        {
                            dcc.Pago = Math.Abs(dcc.Saldo);
                            restoValor = restoValor - restoAImputar;
                        }
                        else
                        {
                            dcc.Pago = Math.Abs(restoValor);
                            restoValor = 0;
                        }
                    }
                    i++;
                }
                this.CuentaCorriente.RecalcularTotalPago();
            }
            //Fin Sabrina: Tarea 1119. 20110816
		}
		/// <summary>
		///Metodo que Recalcula el Total del Comprobante de pago en base a los valores asociados
		///con dicho comprobante
		/// </summary>
		public void Recalcular()
		{

			decimal total=0;
			foreach (Valor valor in this.Valores.MisValores)
			{

				total = total + valor.MontoCotizado;
		
			
			}	
			this.Total= total;
			

		}
		/// <summary>
		///Fuerza la escritura de los datos en memoria al dataset del comprobante para poder ser enviados a almacenar en el RDBM
		///Metodo que se encarga del traspado de los datos en la Clase Comprobante de Pago a una 
		///fila de de la Tabla tsa_Comprobantes.
		///El Commit de un Comprobante de pago implica tambien que se commiteen los Valores, el detalle de pagos
		///la condicion de venta, que por defecto es al contado.
		///En caso de que ademas el Comprobante de Pago se usa para imputar otros comprobantes en la cuenta
		///corriente, se debera hacer el commit de la Aplicaciones de pagos, y ademas actualizar la Condicoin de
		///Venta de todos los comprobantes implicados en la imputacion
		/// </summary>

		public void Commit()
		{
			if(this.AllowSave())
			{
				this.CommitComprobante();
				this.CommitValores();
				this.CommitDetallePagos();
				this.CommitCondicionDeVenta();
				this.CommitCuentaCorriente();
				this.CommitDesimputacionesYAnulaciones();
			}
			else
				if(_precomprobantesDePago.Count > 0)
					this.CommitDesimputacionesYAnulaciones();
		}

		public void RefreshValores(System.Data.DataSet data, Valor valor)
		{
			//this.Valores.DataValoresEx= data;
			valor.Recalcular();
			this.AddValor(valor);
			this.Recalcular();
		}
		public void RefreshValores(Valor valor)
		{
			//this.Valores.DataValoresEx= data;
			valor.Recalcular();
			this.AddValor(valor);
			this.Recalcular();
		}

        /* Silvina 20111230 - Tarea 0000245 */
        private long _idPerfilNumeracion = -1;
        private string _idUsuarioNumeracion = string.Empty;

        private bool SugiereNumeracion(string TipoComprobante)
        {
            ArrayList aux = mz.erp.systemframework.Util.Parse(_listaTiposDeComprobantesSugiereNumeracion, ",");
            return aux.Contains(TipoComprobante);
        }

        private void RefreshNumeracion()
        {
            if (this.SugiereNumeracion(_tipoComprobanteDestino) && !string.IsNullOrEmpty(_tipoComprobanteDestino) && !string.IsNullOrEmpty(_IdResponsable))
            {
                string numeracion = string.Empty;
                sy_PerfilesUsuariosEmpresasDataset perfiles;
                _idUsuarioNumeracion = sy_Usuarios.GetUsuario(_IdResponsable);
                if (_numeracionPorUsuario)
                {
                    numeracion = Variables.GetValueStringUsuariosWithoutCache("Comprobantes.Numeracion." + this._tipoComprobanteDestino, _idUsuarioNumeracion);
                }
                if (numeracion.Equals(string.Empty) && _numeracionPorPerfil)
                {
                    perfiles = sy_PerfilesUsuariosEmpresas.GetList(_idUsuarioNumeracion, Security.IdEmpresa);
                    _idUsuarioNumeracion = string.Empty;
                    foreach (sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow r in perfiles.sy_PerfilesUsuariosEmpresas.Rows)
                    {
                        numeracion = Variables.GetValueStringPerfilesWithoutCache("Comprobantes.Numeracion." + this._tipoComprobanteDestino, r.IdPerfil);
                        if (!numeracion.Equals(string.Empty))
                        {
                            _idPerfilNumeracion = r.IdPerfil;
                            break;
                        }
                    }
                }
                if (numeracion.Equals(string.Empty))
                {
                    _idUsuarioNumeracion = string.Empty;
                    numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + this._tipoComprobanteDestino);
                }
                if (numeracion != string.Empty)
                {
                    this._numero = Util.StcZero(numeracion, 8);
                    if (ObjectHasChanged != null)
                        ObjectHasChanged(this, new System.EventArgs());
                    //German 20120510 - Tarea 0000323
                    if (NumeroSugeridoChanged != null)
                        NumeroSugeridoChanged(this, EventArgs.Empty);
                    //Fin German 20120510 - Tarea 0000323

                }
            }
        }

        private string UpdateNumeroSugerido(tsa_ComprobantesExDataset data, string IdTransaction)
        {
            foreach (System.Data.DataRow row1 in data.tsa_Comprobantes.Rows)
            {
                if (true)
                {
                    row1["Numero"] = this.Numero;
                    return "Comprobantes.Numeracion." + row1["IdTipoDeComprobante"];
                }

            }

            return null;
        }

        /* Fin Silvina 20111230 - Tarea 0000245 */

		public bool Flush()
		{
			string IdTransaction = dataaccess.PoolTransaction.BeginTransaction();
			
			try
			{
				this.Flush(IdTransaction);
				dataaccess.PoolTransaction.Commit(IdTransaction);
				return true;
			}
			catch(Exception e)
			{
				dataaccess.PoolTransaction.RollBack(IdTransaction);
				return  false;

			}

		}

		


		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			if(AllowSave() || _precomprobantesDePago.Count > 0 )
			{
                /* Silvina 20111230 - Tarea 0000245 */
                string IdVariable = string.Empty;
				tsa_ComprobantesExDataset dataEx = this.DatasetComprobante ;                
				/*if (this.ActualizaNumeracion) 
				{
					IdVariable = UpdateNumero(dataEx, IdTransaction);
				}
				else 
				{
					IdVariable = dataEx.tsa_Comprobantes.Rows[0]["Numero"].ToString();
				}*/
                if (this.ActualizaNumeracion)
                {
                    IdVariable = UpdateNumero(dataEx, IdTransaction);
                }
                else
                {
                    if (SugiereNumeracion(_tipoComprobanteDestino))
                    {
                        IdVariable = UpdateNumeroSugerido(dataEx, IdTransaction);
                    }
                }
                if (!string.IsNullOrEmpty(IdVariable))
                    if (_numeracionPorUsuario && !string.IsNullOrEmpty(_idUsuarioNumeracion))
                        mz.erp.dataaccess.sy_VariablesUsuarios.Update(IdVariable, _numero, _idUsuarioNumeracion, IdTransaction);
                    else
                        if (_numeracionPorPerfil && _idPerfilNumeracion > 0)
                            mz.erp.dataaccess.sy_VariablesPerfiles.Update(IdVariable, _numero , _idPerfilNumeracion, IdTransaction);
                        else
                            mz.erp.dataaccess.sy_Variables.Update(IdVariable, _numero, IdTransaction);
                /* Fin Silvina 20111230 - Tarea 0000245 */
				_replication = GenerateReplication();
				BuildExtraDataSets();
				mz.erp.dataaccess.tsa_ComprobantesEx.UpdateComprobanteDePago(dataEx, IdVariable,_numero,  _replication, IdTransaction,_desimpuatcionDetalleDeudaDataSets,_desimputacionAplicacionPagoDataSets,_cancelacionesDePagoDataSets);
				GuardarSaldoCuentaCorriente.GetInstance().FlushSaldoCuentaCorriente(this.GetProcessManagerParent().Process, IdTransaction, _replication);
			}
			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this, new EventArgs());
		}

		private void BuildExtraDataSets()
		{
			_desimpuatcionDetalleDeudaDataSets = new ArrayList();
			_desimputacionAplicacionPagoDataSets = new ArrayList();
			_cancelacionesDePagoDataSets = new ArrayList();
			foreach(DetalleCuentaCorriente dcc in _detalleCtaCteADesimputar)
			{
				_desimputacionAplicacionPagoDataSets.Add(dcc.DataAplicacionDePagos);
				_desimpuatcionDetalleDeudaDataSets.Add(dcc.DataDetalleDeuda);
			}
			foreach(CancelacionComprobanteDePago cancelacionDePago in _cancelacionesDePago)
			{
				cancelacionDePago.DataComprobante.tsa_Comprobantes.Rows[0]["Numero"] = this._numero;
				_cancelacionesDePagoDataSets.Add(cancelacionDePago.DataComprobante);
			}

		}
		private void Merge()
		{
			
			foreach(DetalleCuentaCorriente dcc in _detalleCtaCteADesimputar)
			{
				this.DatasetComprobante.Merge(dcc.DataAplicacionDePagos,false);
				this.DatasetComprobante.Merge(dcc.DataDetalleDeuda, false);
			}
			foreach(CancelacionComprobanteDePago cancelacionDePago in _cancelacionesDePago)
			{
				this.DatasetComprobante.Merge(cancelacionDePago.DataComprobante,false);
			}
		}

		private mz.erp.commontypes.SentenciasReplicacion _replication;
		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		
		private mz.erp.commontypes.SentenciasReplicacion  GenerateReplication()
		{
			mz.erp.commontypes.SentenciasReplicacion replication = new mz.erp.commontypes.SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsa_Comprobantes";
			return replication;
			
		}

		private string  UpdateNumero(tsa_ComprobantesExDataset data, string IdTransaction)
		{
			/*foreach(System.Data.DataRow row1 in data.tsa_Comprobantes.Rows)
			{
				if (true) 
				{
					string tipoDeComprobante = (string)row1["IdTipoDeComprobante"];
					string comprobantesdePago = Variables.GetValueString("Comprobantes.ComprobantesDePago");
					ArrayList comps = mz.erp.systemframework.Util.Parse(comprobantesdePago,",");	
					if(comps.Contains(tipoDeComprobante))
					{
						string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + tipoDeComprobante, IdTransaction);
						_numero = Util.StcZero(numeracion,8);
						row1["Numero"]= _numero;
						sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"], IdTransaction);

						return row.IdVariable;
					}
				}
				
			}

			return null;*/
            
            foreach (System.Data.DataRow row1 in data.tsa_Comprobantes.Rows)
            {
                if (true)
                {
                    string tipoDeComprobante = (string)row1["IdTipoDeComprobante"];
					string comprobantesdePago = Variables.GetValueString("Comprobantes.ComprobantesDePago");
					ArrayList comps = mz.erp.systemframework.Util.Parse(comprobantesdePago,",");
                    if (comps.Contains(tipoDeComprobante))
                    {
                        /* Silvina 20111230 - Tarea 0000245 */
                        string numeracion = string.Empty;
                        if (SugiereNumeracion(tipoDeComprobante))
                        {
                            sy_PerfilesUsuariosEmpresasDataset perfiles;
                            _idUsuarioNumeracion = sy_Usuarios.GetUsuario(_IdResponsable);
                            if (_numeracionPorUsuario)
                            {
                                _idUsuarioNumeracion = sy_Usuarios.GetUsuario(_IdResponsable);
                                numeracion = Variables.GetValueStringUsuariosWithoutCache("Comprobantes.Numeracion." + tipoDeComprobante, _idUsuarioNumeracion, IdTransaction);
                            }
                            if (numeracion.Equals(string.Empty) && _numeracionPorPerfil)
                            {
                                perfiles = sy_PerfilesUsuariosEmpresas.GetList(_idUsuarioNumeracion, Security.IdEmpresa);
                                _idUsuarioNumeracion = string.Empty;
                                foreach (sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow r in perfiles.sy_PerfilesUsuariosEmpresas.Rows)
                                {
                                    numeracion = Variables.GetValueStringPerfilesWithoutCache("Comprobantes.Numeracion." + tipoDeComprobante, r.IdPerfil, IdTransaction);
                                    if (!numeracion.Equals(string.Empty))
                                    {
                                        _idPerfilNumeracion = r.IdPerfil;
                                        break;
                                    }
                                }
                            }
                            if (numeracion.Equals(string.Empty))
                            {
                                _idUsuarioNumeracion = string.Empty;
                                numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + tipoDeComprobante, IdTransaction);
                            }
                        }
                        else // No sugiere numeracion para ese tipo de comprobante
                            numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + tipoDeComprobante, IdTransaction);
                        if (numeracion != string.Empty)
                            this._numero = Util.StcZero(numeracion, 8);
                        row1["Numero"] = Numero;
                        return "Comprobantes.Numeracion." + tipoDeComprobante;
                    }
                    /* Fin Silvina 20111230 - Tarea 0000245 */
                }
                

            }

            return null;
		}
		
		public void ActualizarTotalyPago()
		{
			ArrayList dccs  = this.CuentaCorriente.Detalle;
			//Mejorar esto y agregar un atributo TotalPago al comprobante de Pago
			//De manera que Total representa el total del comprobante y TotalPago lo que se ha imputado
			this.TotalPago = this.CuentaCorriente.TotalImputado;
			foreach(DetalleCuentaCorriente dcc in dccs )
			{
				if(dcc.IdComprobante == this.IdComprobante)
					dcc.Pago = this.TotalPago;
			}	
		}

		public bool IsValidForStartProcess()
		{
			
            _errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processParent.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;
             
            return true;
		}

		public bool IsValid()
		{
			_errores.Clear();
//			if(AllowSave())
//			{
				bool isvalid = true;
				
				if (!IsValidCuenta)
				{
					ItemDatasetError error = new ItemDatasetError("Cuenta","Cliente Seleccionado","El cliente seleccionado no puede ser nulo");
					_errores.Add( error );
					isvalid = false;
				}
				if(this._processParent.Process.ProcessName.Equals("ProcesoPagoACuentaDV")||this._processParent.Process.ProcessName.Equals("ProcesoPagar") 
					|| this._processParent.Process.ProcessName.Equals("ProcesoPagarManual") )
				{
					string clienteDePaso = Variables.GetValueString("Cuenta.ClienteDePaso.Default");
					string idClientePaso = tsa_Cuentas.GetByCodigo(clienteDePaso).IdCuenta;
					if (this.IdCuenta == idClientePaso)
					{
						isvalid = false;
						_errores.Add( new ItemDatasetError( "Cuenta","Cuenta","El cliente no es correcto para la operación que desea realizar."));					
					}
				}
				if (!IsValidResponsable)
				{
					ItemDatasetError error = new ItemDatasetError("Responsable","Responsable de Emision","El responsable de emisión no puede ser nulo");
					_errores.Add( error );
					isvalid = false;
				}
				if (!IsValidInstanciaDeCaja)
				{
					string msj = _errorCaja.Equals(string.Empty)? "Debe seleccionar una caja abierta en donde imputar el pago" : _errorCaja;
					ItemDatasetError error = new ItemDatasetError("Caja","Instancia de Caja",msj);
					_errores.Add( error );
					isvalid = false;
				}
				if(!this.CuentaCorriente.IsValid())
				{	
					_errores.AddAll(this.CuentaCorriente.Errores);
					isvalid = false;
				}

				if(!IsValidMonto)
				{
					ItemDatasetError error = new ItemDatasetError("Total","Total","El Total del comprobante debe ser mayor que 0");
					_errores.Add( error );
					isvalid = false;				
				}
				if(!IsValidMontoConImputacion)
				{
					ItemDatasetError error = new ItemDatasetError("Total","Total","El Total del comprobante debe ser mayor o igual que el monto imputado a el/los comprobante/s a imputar");
					_errores.Add( error );
					isvalid = false;				
				}
				if (!(this.IsValidNumeration()))
				{
					isvalid = false;
					_errores.Add( new ItemDatasetError( "Comprobante","Numeración","La numeración del comprobante no es válida o ya existe"));
				}
				//verifico q no existe entre las retenciones grabadas en la BD.
				if (ExisteRetencionRepetida(_idCuenta)) 
				{
					_errores.Add( new ItemDatasetError("Retención","Retención","El número de retención está repetido."));						
					isvalid = false;
				}
				if(_validarValoresExistentes)
				{
					foreach(Valor valor in this.Valores.MisValores)
					{
						if (!valor.Agrupado && ((valor.IdInstanciaCaja != _idInstanciaCaja && valor.State.ToUpper().Equals("EDIT"))|| valor.State.ToUpper().Equals("NEW")))
						{
							string message = "El valor " + valor.Comprobante + " Nro " + valor.Numero + " No pertenece a la caja de la cual se desea hacer el egreso. Debe transferirlo.";
							_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor",message));	
							isvalid = false;	
						}
					}
				}
				if(_validarSignoValoresExistentes)
				{
					int signo = int.MinValue;
					DataRow rowTC = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino);
					if(rowTC != null)
						signo = Convert.ToInt32(rowTC["Signo"]);
					foreach(Valor valor in this.Valores.MisValores)
					{
						if (!valor.Agrupado && valor.State.ToUpper().Equals("EDIT") && valor.Signo.Equals(signo))
						{
							string message = "El valor " + valor.Comprobante + " Nro " + valor.Numero + " No puede usarse en este tipo de comprobante";
							_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor",message));	
							isvalid = false;	
						}
					}
				}
			//German 20091120
			if(!IsValidCajaAbierta())
			{
				_errores.Add( new ItemDatasetError("Caja","Caja","La Caja seleccionada para este proceso ha sido cerrada. Debe reiniciar el proceso."));						
				isvalid = false;
			}
			if(!IsValidFechaEmision())
			{
				_errores.Add( new ItemDatasetError("Fecha","Fecha","La fecha de emisión NO puede ser mayor a la fecha actual"));						
				isvalid = false;
			}
			//Fin German 20091120
				/*Falta validar el monto y los valores  asociados*/ 
			
			/* Silvina 20100609 - Tarea 459 */
			if (_validarMontoDisponibleDeCaja)
				foreach(Valor valor in this.Valores.MisValores)
				{
					if (valor.Agrupado)
					{
						decimal importe = tfi_Cajas.GetImportePorTipoDeComprobante(valor.IdTDCompTesoreria,valor.IdMoneda,IdInstanciaCaja);
						if (valor.Monto > importe)
						{
							string message = "El importe ingresado en "+ valor.Comprobante + " "+ valor.Moneda + " supera el saldo disponible." +
								"El Monto actual en la caja es de " + importe;
							_errores.Add( new ItemDatasetError( this._processParent.Process.ProcessName,"Valor",message));	
							isvalid = false;
						}
					}
				}

			/* Fin Silvina */

            /* Silvina 20101020 - Tarea 899 */
            if (_validarCheques)
            {
                foreach (Valor valor in this.Valores.MisValores)
                {
                    if (valor.State.ToUpper().Equals("NEW") && MAPStaticInfo.PerteneceACheque(valor.IdTDCompTesoreria))
                    {
                        string message = "No puede ingresar cheques nuevos";
                        _errores.Add(new ItemDatasetError(this._processParent.Process.ProcessName, "Valor", message));
                        isvalid = false;
                    }
                }
            }
            /* Fin Silvina */
				return isvalid;
//			}
//			else return true;
		}


		//German 20091120

		private bool IsValidFechaEmision()
		{
			if(_allowValidarFechaEmisionMayorFechaActual)
			{
				DateTime fechaActual = mz.erp.businessrules.Sistema.DateTime.Now;
				DateTime fechaActualSinHora = mz.erp.systemframework.Util.GetStartDay(fechaActual);
				DateTime fechaEmisionSinHora = mz.erp.systemframework.Util.GetStartDay(this._fechaComprobante);
				return fechaActualSinHora >= fechaEmisionSinHora;
			}
			return true;

		}
		private bool IsValidCajaAbierta()
		{
			if ((this.IdInstanciaCaja != null) && (!this.IdInstanciaCaja.Equals(string.Empty)))
			{
				tfi_InstanciasCajaDataset.tfi_InstanciasCajaRow row = mz.erp.businessrules.tfi_InstanciasCaja.GetByPk(IdInstanciaCaja);
				if(row != null)
				{
					if(!row.IsCierreNull())
					{
						return false;
					}
				}
				else return false;
			}
			return true;
		}
		//Fin German 20091120


		private bool ExisteRetencionRepetida(string IdCuenta)
		{	
			//verifica si el numero de retencion existe mas de una vez en la lista de valores que se muestra en la ventana					
			bool result = false;
			foreach (Valor val in  Valores.MisValores)
			{
				if(val != null)
				{
					int cant = 0 ;
					if( MAPStaticInfo.GetFDP(val.IdTDCompTesoreria) == "Retenciones")
					{
						foreach (Valor valor in  Valores.MisValores)
							if (valor.Numero == val.Numero)
								cant = cant+1;
						if (cant != 1)
							result = true;
					}
				}
			}
			return result;
		}		



		public bool IsValidNumeration()
		{
			if (this._allowValidarNumeracion )
			{  
				if (Numero== null || Numero.Equals(_numeroDefault) || Numero.EndsWith("-") || (Numero == string.Empty) || ExistsNumeration()) 
				{
					return false;
				}
			}
			return true;
		}

		private bool ExistsNumeration()
		{
			
			return mz.erp.businessrules.tsa_Comprobantes.ExistsNumeration(this.Numero, this.TipoComprobanteDestino);
			
		}



		public bool IsValidFor(string action)
		{
			bool isValid = true;
			switch(action.ToUpper())
			{
				case "IMPUTACION":
				{
					break;
				}
				case "PAGO":
				{
					break;
				}
				case "DESIMPUTACION":
				{
					break;
				}

			}

			return isValid;

		}

		private void GetInstanciaDeCaja()
		{
			_errorCaja = string.Empty;
			_instanciasCajasAbiertas = new DataTable();
			string variable = "Momentos." + this._momento + "."+ this._processParent.Process.ProcessName + ".Cajas";
			string idCajaVariables = Variables.GetValueString(variable);
			ArrayList cajaAbiertas = new ArrayList();
			if(!idCajaVariables.Equals(string.Empty))
				cajaAbiertas = mz.erp.systemframework.Util.Parse(idCajaVariables, ",");
			
			if(this._IdResponsable != null && this._IdResponsable != string.Empty)
			{
				string idUsuarioResp = this._IdResponsable;
				if(cajaAbiertas.Count == 0)
				{
					_idInstanciaCaja = null;
					_errorCaja = "No hay Cajas Definidas para el Proceso Actual";
					_allowShow = true;
					_allowEditInstanciaDeCaja = false;
				}
				else
				{
					if(cajaAbiertas.Count == 1)
					{
						string idCaja = Convert.ToString(cajaAbiertas[0]);
						string idCajaTemporal = Variables.GetValueString("Cajas.CajaTemporalDefault");
						if(idCaja.Equals(idCajaTemporal))
						{
							try 
							{
								_idInstanciaCaja = ComprobantesRules.InstanciaCajaAbiertaDefault( null, idCaja );
								idUsuarioResp = mz.erp.businessrules.tfi_InstanciasCaja.GetByPk(_idInstanciaCaja).IdResponsable;
							}
							catch
							{
								string Mensaje = "La caja temporal no se encuentra abierta";
								Exception e = new Exception(Mensaje);
							}						
						}
						else
						{
							_idInstanciaCaja = ComprobantesRules.InstanciaCajaAbiertaDefault(  idUsuarioResp , idCaja );
						}
						_instanciasCajasAbiertas = mz.erp.businessrules.tfi_InstanciasCaja.GetList(idUsuarioResp, idCajaVariables).Tables[0];	 
						if(_instanciasCajasAbiertas != null && _instanciasCajasAbiertas.Rows.Count == 0)
						{
							_idInstanciaCaja = null;
							_errorCaja = "La/s Caja/s definida/s para este proceso estan cerradas. Proceda con la apertura de la/s misma/s";
							_allowShow = true;
							_allowEditInstanciaDeCaja = false;
						}
						else
						{
							_allowShow = false;
							//_allowEditInstanciaDeCaja = true;
						}
					
					}
					else
					{
					
						_instanciasCajasAbiertas = mz.erp.businessrules.tfi_InstanciasCaja.GetList(idUsuarioResp, idCajaVariables).Tables[0];
						if(_instanciasCajasAbiertas != null && _instanciasCajasAbiertas.Rows.Count == 1)
						{
							_idInstanciaCaja = Convert.ToString(_instanciasCajasAbiertas.Rows[0]["IdInstanciaCaja"]);
							_allowShow = false;
						}
						else
							if(_instanciasCajasAbiertas != null && _instanciasCajasAbiertas.Rows.Count == 0)
						{
							_idInstanciaCaja = null;
							_errorCaja = "La/s Caja/s definida/s para este proceso estan cerradas. Proceda con la apertura de la/s misma/s";
							_allowShow = true;
							_allowEditInstanciaDeCaja = false;
						}

						else
						{
							_allowShow = true;
							_allowEditInstanciaDeCaja = true;
						}
					}
				
				
				
					/*
					else
					{
						foreach(string idCaja in cajaAbiertas)allowshow
					
						{
							string idInstanciaCaja = ComprobantesRules.InstanciaCajaAbiertaDefault(Security.IdUsuario, idCaja );
							string description = mz.erp.businessrules.tfi_Cajas.GetByPk(idCaja).Descripcion;
							_instanciasCajasAbiertas.Add(new InstanciaCajaView(idInstanciaCaja,description));
						}		
					}
					*/
				}
			}
			else
			{
				_idInstanciaCaja = null;
				_allowShow = true;
				_allowEditInstanciaDeCaja = false;
			}
		
			
		}

        public void Init()
        {
            _momento = this._taskName;
            string IdMoneda = Variables.GetValueString("Contabilidad.MonedaReferencia");
            _idMonedaCierre = IdMoneda;
            mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizaciones(_cotizaciones, IdMoneda);
            _fechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;

            _condicionDeVenta = new CondicionDeVenta("NEW", this, Variables.GetValueString("Comprobantes.FormaDePago.Contado"));
            DatasetComprobante = new tsa_ComprobantesExDataset();
            _arrData = new ArrayList();
            _arrData.Add(DatasetComprobante);
            _valores = Factory.GetValores(DatasetComprobante);
            _compDetalleDePagos = Factory.GetComprobantesDetalleDePagos(this);
            this._IdResponsable = Security.IdPersona;
            tsh_PersonasDataset.tsh_PersonasRow row = businessrules.tsh_Personas.GetByPk(this._IdResponsable);
            _responsable = row.Nombre;
            GetInstanciaDeCaja();
            _saldo = 0;
            _totalPago = 0;
            _aplicacionesDePagos = Factory.getAplicacionesDePagos(this);
            _idComprobante = mz.erp.systemframework.Util.NewStringId();
            _cuentaCorriente = Factory.GetCuentaCorriente();
            _tipoComprobanteDestino = Variables.GetValueString(this._processParent.Process.ProcessName, this._momento, "Comprobantes");
            _mascara = this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
            if (_mascara == null || _mascara == string.Empty)
                _mascara = @"\R-####-########";
            _numeroDefault = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "MascaraNumero");
            if (_numeroDefault != null && !_numeroDefault.Equals(string.Empty))
                this._numero = _numeroDefault;
            this._codigoCuenta = Variables.GetValueString("Momentos." + this._momento + ".Cuenta.Default");
            if (this._codigoCuenta != null && !this._codigoCuenta.Equals(string.Empty))
            {
                this._idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(this._codigoCuenta);
                if (this._idCuenta != null && !this._idCuenta.Equals(string.Empty))
                {
                    this.CuentaCorriente = Factory.GetCuentaCorriente(this._idCuenta, DateTime.MinValue, DateTime.MaxValue, null);
                    //ojo modif ctacte
                    this.CuentaCorriente.GetDetalleComprobantesAImputar(this._processParent.Process.ProcessName, this._taskName);
                }
            }
            SetEditablesProperty();
            _creaIdValoresNuevos = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Step.Valores.CreaNuevosValores", true);
            _desimputaYAnulaComprobanteDePagoPrevio = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Step.DesimputaYAnulaComprobanteDePagoPrevio", _desimputaYAnulaComprobanteDePagoPrevio);
            _allowSearchValores = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "PermiteBuscarValores");
            _validarValoresExistentes = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "Validar.ValoresExistentes");
            _validarSignoValoresExistentes = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "Validar.SignoValoresExistentes");
            _preguntarAlCancelar = Variables.GetValueBool(_processParent.Process.ProcessName, _taskName, "PreguntarAlCancelar");

            //German 20091120
            _allowValidarFechaEmisionMayorFechaActual = Variables.GetValueBool(this.GetProcessManagerParent().Process.ProcessName, this.GetTaskName(), "Validar.FechaEmisionMayorFechaActual");
            //Fin German 20091120
            /* Silvina 20100609 - Tarea 459 */
            _validarMontoDisponibleDeCaja = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Validar.MontoDisponibleDeCaja");
            /* Fin Silvina */
            /* Silvina 20101020 - Tarea 899 */
            _validarCheques = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Validar.Cheques");
            /* Fin Silvina */

            //Sabrina: Tarea 1117. 20110816
            _allowEditImputaAutomaticamente = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Editar.ImputaAutomaticamente");
            _imputaAutomaticamente = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "ImputaAutomaticamente.ValorDefault");
            //Fin Sabrina: Tarea 1117. 20110816

            //Sabrina: Tarea 1119. 20110816
            string ordenDeImputacion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "ImputacionesAutomaticas.OrdenDeImputacion");
            if (ordenDeImputacion.Equals("EmisionAsc"))
                _sortOrder = SortOrder.EmisionAsc;
            else if (ordenDeImputacion.Equals("EmisionDesc"))
                _sortOrder = SortOrder.EmisionDesc;
            else if (ordenDeImputacion.Equals("VencimientoAsc"))
                _sortOrder = SortOrder.VencimientoAsc;
            else if (ordenDeImputacion.Equals("VencimientoDesc"))
                _sortOrder = SortOrder.VencimientoDesc;
            //Fin Sabrina: Tarea 1119. 20110816

            /* Silvina 20111230 - Tarea 0000245 */
            _listaTiposDeComprobantesSugiereNumeracion = Variables.GetValueString(this._processParent.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumero.ListaTiposDeComprobantes");
            _numeracionPorPerfil = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumeroPorPerfil", _numeracionPorPerfil);
            _numeracionPorUsuario = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumeroPorUsuario", _numeracionPorUsuario);
            RefreshNumeracion();
            /* Fin Silvina 20111230 - Tarea 0000245 */
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
			return _processParent;
		}

	
		public TaskCollectionData GetData()
		{
			TaskCollectionData _taskCollectionData = new TaskCollectionData();
			_taskCollectionData.TaskName = this.GetTaskName();
			_taskCollectionData.Add( this.DatasetComprobante );
			return _taskCollectionData;
		}
		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			array.Add( (DataSet)this.DatasetComprobante );
			return array;

		}
		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}
		
		public string GetTaskName()
		{
			return _taskName;
		}
		public void SetTaskName(string taskName)
		{
			_taskName = taskName;
		}
		
		public void SetProcessManagerParent( ProcessManager process )
		{
			_processParent = process;
		}

		public void UpdatePago(object selectedRow)
		{
			DetalleCuentaCorriente dcc = (DetalleCuentaCorriente) selectedRow;
			this.CuentaCorriente.UpdatePago(dcc);
			this.CuentaCorriente.RecalcularTotalPago();
		}

		#endregion

		#region Metodos Privados

		private bool MustValidateInstanciaDeCaja()
		{
			return this.Valores.MisValores.Count > 0;
		}

		private void SetEditablesProperty()
		{
			
			
			string _processName = this.GetProcessManagerParent().Process.ProcessName;
			if(_processName.Equals("ProcesoPagar") || _processName.Equals("ProcesoDevolver")|| _processName.Equals("ProcesoPagoACuentaDV")
				||  _processParent.Process.ProcessName.Equals("ProcesoDevolverPago") ||  _processParent.Process.ProcessName.Equals("ProcesoDevolverPagoDV")
				|| _processName.Equals("ProcesoPagarManual"))
			{
				AllowEditTipoDeComprobante = ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Editar.TComp");
				AllowEditCuenta = ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Editar.Cuenta");
				AllowEditFecha = ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Editar.Fecha");
				AllowEditFormasDePago = ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Editar.FPago");
				AllowEditResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Editar.REmision");
				AllowEditNumeration = ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Editar.Numeracion");
				ActualizaNumeracion = !ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Editar.Numeracion");
				_allowValidarNumeracion = ComprobantesRules.Momentos_Parametros_Bool( this._momento,_processName, "Emision.Validar.Numeracion");
			}
			else
			{
				AllowEditTipoDeComprobante = false;
				AllowEditCuenta = false;
				AllowEditFecha = false;
				AllowEditFormasDePago = false;
				AllowEditResponsableEmision = false;
				AllowEditNumeration = false;
				AllowEditImputacion = false;
				AllowEditValores = false;
				_allowValidarNumeracion = false;
			}
			AllowEditFecha = Variables.GetValueBool(this._processParent.Process.ProcessName, this._taskName, "Emision.Editar.Fecha");
			AskForPasswordResponsableEmision = Variables.GetValueBool( this._processParent.Process.ProcessName, this._taskName, "Emision.HabilitarContraseña.REmision");
				//ComprobantesRules.Momentos_Parametros_Bool( this._momento,IdProceso, "Emision.Editar.Fecha");
			//_allowEditInstanciaDeCaja = _instanciasCajasAbiertas.Count > 1;
		}

		private void CommitComprobante()
		{
			tsa_ComprobantesExDataset.tsa_ComprobantesRow row = DatasetComprobante.tsa_Comprobantes.Newtsa_ComprobantesRow();

			DateTime now = mz.erp.businessrules.Sistema.DateTime.Now;
			DateTime fc = this.FechaComprobante;
			DateTime fecha = new DateTime(fc.Year, fc.Month, fc.Day, now.Hour,now.Minute, now.Second);
			row.Fecha = fecha;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdComprobante = Util.NewStringId();
			this.IdComprobante = row.IdComprobante;
			row.IdCuenta = this.IdCuenta;
			row.IdResponsable = this.IdResponsable;
			row.Observaciones = this.Observaciones;

			row.IdTipoDeComprobante = this.TipoComprobanteDestino;
			row.Numero = this.Numero;
			row.IdCotizacionCierre = Variables.GetValueString( "Contabilidad.CotizacionReferencia");
			row.Total = this.Total*this.Signo;

			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			
			row.IdInstanciaCaja = this.IdInstanciaCaja;
			row.IdMonedaCierre = this.IdMonedaCierre;
			
			row.IdReservado = 0;

            /* Silvina 20111212 - Tarea 0000232 */
            row.FechaVencimientoReserva = FechaReserva;
            /* Fin Silvina 20111212 - Tarea 0000232 */
			DatasetComprobante.tsa_Comprobantes.Addtsa_ComprobantesRow( row );
		
		}
		private void CommitValores()
		{
			//Para guardar en tfi_Valores
			this.Valores.CreaIdValoresNuevos = this._creaIdValoresNuevos;
			DataRow row = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._tipoComprobanteDestino);
			int signo = 1;
			if(row != null)
				signo = Convert.ToInt32(row["Signo"]);
			this.Valores.Commit(this._idInstanciaCaja, signo);
		}

		private void CommitDetallePagos()
		{
			//Para guardar en tsa_ComprobantesDetallePagos
			this.CompDetalleDePagos.CreaIdValoresNuevos = this._creaIdValoresNuevos;
			this.CompDetalleDePagos.TablaDeValoresFormasDePago = _idValoresIdFormasDePagosTable;
			this.CompDetalleDePagos.Commit();
		}

		private void CommitCondicionDeVenta()
		{
			//Para guradar en tsa_ComprobantesDetalleDeuda
			this.CondicionDeVenta.Commit(this.GetProcessManagerParent().Process);
		}
		private void CommitCuentaCorriente()
		{
			//cheque si hay imputaciones
			
			if (this.CuentaCorriente.TotalImputado > 0)
			{
				this.AplicacionesDePagos.Commit();
				this.CondicionDeVenta.Update(this.CuentaCorriente);

			}
		}

		private void CommitDesimputacionesYAnulaciones()
		{
			
			if(_desimputaYAnulaComprobanteDePagoPrevio)
			{
				_detalleCtaCteADesimputar = new ArrayList();
				_cancelacionesDePago = new ArrayList();
				foreach(ComprobanteDePago comp in this._precomprobantesDePago)
				{
					DetalleCuentaCorriente dcc = Factory.GetDetalleCuentaCorriente(comp);
					dcc.Desimputar();
					_detalleCtaCteADesimputar.Add(dcc);
					CancelacionComprobanteDePago _cancelacionComprobanteDePago= new CancelacionComprobanteDePago();
					_cancelacionComprobanteDePago.Anular(comp.IdComprobante);
					_cancelacionComprobanteDePago.Commit();
					_cancelacionesDePago.Add(_cancelacionComprobanteDePago);
				}
			}
		}

        //Sabrina: Tarea 1119. 20110816
        private ArrayList SortComprobantesAImputar()
        {
            ArrayList result = new ArrayList();
            result.AddRange(this.CuentaCorriente.Detalle);
            switch (_sortOrder)
            {
                case SortOrder.EmisionAsc:
                    {
                        result.Sort(DetalleCuentaCorriente.SortByFechaEmisionAscInstance);
                    }
                    break;
                case SortOrder.EmisionDesc:
                    {
                        result.Sort(DetalleCuentaCorriente.SortByFechaEmisionDescInstance);
                    }
                    break;
                case SortOrder.VencimientoAsc:
                    {
                        result.Sort(DetalleCuentaCorriente.SortByFechaVencimientoAscInstance);
                    }
                    break;
                case SortOrder.VencimientoDesc:
                    {
                        result.Sort(DetalleCuentaCorriente.SortByFechaVencimientoDescInstance);
                    }
                    break;
            }

            return result;
        }
        //Fin Sabrina: Tarea 1119. 20110816

		#endregion

		#region Metodos Listener

		
		public void ListenerTaskDependentChanged(object sender)
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
			{
				ITask taskInfo = (ITask)sender;
				if(!taskInfo.GetTaskName().Equals("AnularPrevender")&&
					!taskInfo.GetTaskName().Equals("AnularPreprestar") &&
					!taskInfo.GetTaskName().Equals("AnularPresupuestar") &&
					!((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
					|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")) && taskInfo.GetTaskName().Equals("Devolver"))
				   )
				{
					bool _totalHasChanged = this._totalComprobanteDeVenta != ((ComprobanteDeVenta) sender).Total;
					if(_hasRecargos || _totalHasChanged)
					{
						LoadDataFromComprobanteDeVenta((ComprobanteDeVenta) sender);
						if(ObjectHasChanged != null)
							ObjectHasChanged(this, new EventArgs());
					}
				}
			}
			if(sender.GetType() == typeof(mz.erp.businessrules.RecargosFormasDePago))
			{
				RecargosFormasDePago recargos = (RecargosFormasDePago) sender;
                decimal porcentajeRecargo = recargos.PorcentualRecargosFinancieros;
				if(porcentajeRecargo > 0)
					_hasRecargos = true;
			}
		}


		private void LoadDataFromComprobanteDeVenta(ComprobanteDeVenta comprobanteDeVenta)
		{
			

			bool _totalHasChanged = this._totalComprobanteDeVenta != comprobanteDeVenta.Total;
			bool _idCuentaHasChanged = this._idCuenta != comprobanteDeVenta.IdCuenta;
			bool _CondicionDeVentaHasChanged = this._idCondicionDeVentaComptobanteDeVenta != null && comprobanteDeVenta.CondicionDeVenta!= null && this._idCondicionDeVentaComptobanteDeVenta!= comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta; 
			this.IdResponsable = comprobanteDeVenta.IdResponsable;
			if(_totalHasChanged ||_idCuentaHasChanged || _CondicionDeVentaHasChanged)
			{
				this._idCondicionDeVentaComptobanteDeVenta = comprobanteDeVenta.CondicionDeVenta.IdCondicionDeVenta;
				this._condicionDeVentaComptobanteDeVenta = comprobanteDeVenta.CondicionDeVenta;
				this._totalComprobanteDeVenta = comprobanteDeVenta.Total;
				this._codigoCuenta = comprobanteDeVenta.Cuenta.Codigo;
				this._idCuenta = comprobanteDeVenta.Cuenta.IdCuenta;
				if(this._cuentaCorriente != null)
					this._cuentaCorriente.IdCuenta = this._idCuenta;
				this._idComprobanteDeVenta = comprobanteDeVenta.IdComprobante;
				this._idTipoDeComprobanteDeVenta = comprobanteDeVenta.TipoComprobanteDestino;
				this._numeroComprobanteDeVenta = comprobanteDeVenta.Numero;
				this._tipoDeComprobanteDeVenta = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this._idTipoDeComprobanteDeVenta).Descripcion;
				this._signoComprobanteDeVenta = comprobanteDeVenta.SignoCuentaCorriente;
				this._fechaComprobanteDeVenta = comprobanteDeVenta.FechaComprobante;
				
				if(!IsStep() || (IsStep() && _CondicionDeVentaHasChanged))
				{
					this.BuildCuentaCorriente(comprobanteDeVenta);
					this.UpdateCuentaCorriente();
				}
				else 
					StepCuentaCorriente();
			}
	
		}

		private bool IsStep()
		{
			return this._relacionesComprobanteOrigenDestino != null;
		}

		public bool AllowShow()
		{
			_allowShow = _allowShow && this.Valores.MisValores.Count >0;
			return ((_allowShow &&  !(_processParent.Process.ProcessName.Equals("ProcesoPagar")||(_processParent.Process.ProcessName.Equals("ProcesoPagoACuentaDV")) ||  _processParent.Process.ProcessName.Equals("ProcesoPagarManual")))
					||  _processParent.Process.ProcessName.Equals("ProcesoPagar") ||  _processParent.Process.ProcessName.Equals("ProcesoPagoACuentaDV")
					||  _processParent.Process.ProcessName.Equals("ProcesoDevolverPago") ||  _processParent.Process.ProcessName.Equals("ProcesoDevolverPagoDV")
					||  _processParent.Process.ProcessName.Equals("ProcesoPagarManual"));
		
		}
		public void FormHasClosed() 
		{
		}

		private bool AllowSave()
		{
			return this.Total > 0;			
		}
	
		/*Este metodo lo que hace es */
		private void BuildCuentaCorriente(ComprobanteDeVenta comprobanteDeVenta)
		{						
			_cuentaCorriente.Detalle.Clear();
			comprobantes.CondicionDeVenta condicionDeVenta = comprobanteDeVenta.CondicionDeVenta;
			foreach(DetalleCuotas cuota in condicionDeVenta)
			{			
				DetalleCuentaCorriente dcc = Factory.GetDetalleCuentaCorriente(cuota, comprobanteDeVenta);
				dcc.PagoChanged +=new EventHandler(_cuentaCorriente.RecalcularTotalPago);
				_cuentaCorriente.Detalle.Add(dcc);
			}			
		}

		private void ResetCuentaCorriente()
		{
			this._totalPago = 0;
			this._cuentaCorriente.Detalle.Clear();
			this._cuentaCorriente.RecalcularTotalPago();
		}

		private void BuildCuentaCorriente()
		{		
		
			_cuentaCorriente.Detalle.Clear();
			comprobantes.CondicionDeVenta condicionDeVenta = this._condicionDeVentaComptobanteDeVenta;
			if (condicionDeVenta != null) 
			{
				foreach(DetalleCuotas cuota in condicionDeVenta)
				{				
					DetalleCuentaCorriente dcc = Factory.GetDetalleCuentaCorriente(this._idComprobanteDeVenta, this._tipoDeComprobanteDeVenta, this._numeroComprobanteDeVenta, this._fechaComprobanteDeVenta, this._fechaComprobanteDeVenta, 1, this._totalComprobanteDeVenta * this._signoComprobanteDeVenta, this._totalComprobanteDeVenta *this._signoComprobanteDeVenta, this._totalComprobanteDeVenta * this._signoComprobanteDeVenta,this._signoComprobanteDeVenta, this._idTipoDeComprobanteDeVenta);
					dcc.PagoChanged +=new EventHandler(_cuentaCorriente.RecalcularTotalPago);
					_cuentaCorriente.Detalle.Add(dcc);
				}
			}
		}


		
		private void UpdateCuentaCorriente()
		{
			decimal totalCompPago = decimal.Round(this._total,2);
			decimal totalImputado = 0;
			if(totalCompPago > 0)
			{
				foreach(DetalleCuentaCorriente dcc in this._cuentaCorriente.Detalle)
				{
					decimal importe = dcc.ImporteSinSigno;
					if(totalCompPago > 0)
					{
						if(totalCompPago >= importe)
						{
							dcc.SetPago(importe);
							dcc.Saldo = 0;
							totalCompPago = totalCompPago - importe;
							totalImputado = totalImputado + importe;
						}
						else
						{
							dcc.SetPago(totalCompPago);
							dcc.Saldo = (dcc.ImporteSinSigno - dcc.TotalPago) * dcc.Signo;
							totalCompPago = 0;
							totalImputado = totalImputado + (dcc.TotalPago);
						}
					}
				}
			}
			this._totalPago = totalImputado;
			
		}

		
		public void ListenerAfterExecuteDependentTask( object sender )
		{
			if(sender.GetType().Equals(typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta)))
			{
				ITask taskInfo = (ITask)sender;
				if(!taskInfo.GetTaskName().Equals("AnularPrevender")&&!taskInfo.GetTaskName().Equals("AnularPreprestar")&&
					!((this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas")
					|| this._processParent.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV")) && taskInfo.GetTaskName().Equals("Devolver"))
					
					)
				{
					LoadDataFromComprobanteDeVenta((ComprobanteDeVenta) sender);
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
				}
                /* Silvina 20111212 - Tarea 0000232 */
                if (this._processParent.Process.ProcessName.Equals("ProcesoPrevenderReserva") && taskInfo.GetTaskName().Equals("Prevender"))
                {
                    ComprobanteDeVenta comp = (ComprobanteDeVenta)sender;
                    FechaReserva = comp.FechaReserva;
                }
                /* Fin Silvina 20111212 - Tarea 0000232 */
			}
			/*
			 * Se cuelga del los comprobanes pendientes siempre y cuando estemos en un proceso q asi lo requiera.
			 * Lo que hace es tomar todos los comprobantes anteriores y ver cuales son los comprobantes de pagos asociados
			*/

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.ComprobantesPendientes)))
			{
				ComprobantesPendientes comprobantesPendientes = (ComprobantesPendientes)sender;
				if(comprobantesPendientes.RelacionesComprobanteOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{
					this._relacionesComprobanteOrigenDestino = comprobantesPendientes.RelacionesComprobanteOrigenDestino;
					this.Step();
				}

			}

			if(sender.GetType().Equals(typeof(mz.erp.businessrules.SeleccionItemsPendientes)))
			{
				SeleccionItemsPendientes comprobantesPendientes = (SeleccionItemsPendientes)sender;
				if(comprobantesPendientes.RelacionesComprobanteOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{
					this._relacionesComprobanteOrigenDestino = comprobantesPendientes.RelacionesComprobanteOrigenDestino;
					this.Step();
				}

			}

			if(sender.GetType() == typeof(mz.erp.businessrules.RecargosFormasDePago))
			{
				RecargosFormasDePago recargos = (RecargosFormasDePago) sender;
				if(recargos.IsValidObject)
				{
					decimal porcentajeRecargo = recargos.PorcentualRecargosFinancieros;
					_totalComprobanteDeVentaDesdeRecargos = recargos.TotalFinalComprobanteDeVenta;
					if(porcentajeRecargo > 0)
						_hasRecargos = true;

					
					
					if(IsStep() /*&& MustAplicarValores(recargos.Recargos)*/)
					{
						BuildCuentaCorriente();
						ResetValores();
						AplicarValores(recargos.Recargos);
						UpdateCuentaCorriente();
					}
					else
						if(IsStep() && recargos.Recargos.Count == 0)
					{
						ResetCuentaCorriente();
						ResetValores();
					}
					else
						if(!IsStep())
						{
							if(recargos.Recargos.Count >0 /*&& MustAplicarValores(recargos.Recargos)*/)
							{
								ResetValores();
								AplicarValores(recargos.Recargos);
								UpdateCuentaCorriente();
							}
						
							else
							{
								ResetCuentaCorriente();
								ResetValores();
							}
						}
				}
			}
			/*if(sender.GetType() == typeof(mz.erp.businessrules.FiscalComprobantes))
			{
				FiscalComprobantes impresion = (FiscalComprobantes) sender;
				this.Numero = impresion.Numero;
				this.ActualizaNumeracion = impresion.ActualizaNumeracion;
			}	*/
		}

		private bool MustAplicarValores(RecargosFormaDePago recargos)
		{
			//Se sacan las formas de pagos, esto es posible si selecciono por ejemlo cta cte y nose paga nada en
			//el momento
			if(recargos.Count == 0 ) 
				return false;
			//Cmbiaron las formas de pagos establecidas en el comprobante anterior (Step)
			if(recargos.Count != this._valores.MisValores.Count)
				return true;
			//No cambiaron las formas de pagos preestablecidas. Se verifica si cambioen los montos de las mismas
			foreach(RecargoFormaDePago recargo in recargos)
			{
				Valor valor = Factory.GetValor(recargo);
				bool comparer = false;
				foreach(Valor val in this._valores.MisValores)
				{
					comparer =  comparer ||( valor.IdFormaDePago.Equals(val.IdFormaDePago)
							&& valor.MontoCotizado.Equals(val.MontoCotizado)&& valor.IdTDCompTesoreria.Equals(val.IdTDCompTesoreria)
							&& valor.IdMoneda.Equals(val.IdMoneda));
				}
				if(!comparer)
					return true;
			}
			return false;
		}

		private void ResetValores()
		{
			this._valores.Reset();
			this.Recalcular();
			_idValoresIdFormasDePagosTable.Clear();
		
		}

		private void AplicarValores(RecargosFormaDePago recargos)
		{
		
			foreach(RecargoFormaDePago recargo in recargos)
			{
				FormaDePago fdp = recargo.FormaDePago;
				Valor valor = fdp.Valor;
				this._valores.Add(valor);
				/*Cambio German - Ver si tiene sentido*/
				/*
				tfi_ValoresExDataset data = new tfi_ValoresExDataset();
				data = valor.Commit(data);
				*/
				_idValoresIdFormasDePagosTable.Add(valor.IdValor, recargo.FormaDePago.GetIdFormaDePago());
			}
			if(recargos.Count > 0)
			{
				this.Recalcular();
				UpdateCuentaCorriente();
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}

		}
		
		public void ListenerBeforeExecuteDependentTask( object sender )
		{
			
		}
		
		#endregion

		#region Eventos

		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event EventHandler IdResponsableChanged;
		public event EventHandler NombreClienteChanged;

        //German 20120125 - Tarea 0000256
        public event EventHandler SaldoAImputarChanged;

        //Fin German 20120125 - Tarea 0000256

        //German 20120510 - Tarea 0000323
        public event EventHandler NumeroSugeridoChanged;
        //Fin German 20120510 - Tarea 0000323


		#endregion

		private void _cuentaCorriente_TotalImputadoChanged(object sender, EventArgs e)
		{
			_saldo = _total - this.CuentaCorriente.TotalImputado;
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		}

		private bool ExistsImputacion(string IdComprobanteDeVenta)
		{
			System.Data.DataSet data = mz.erp.businessrules.tsa_AplicacionPagos.GetList(IdComprobanteDeVenta,1,decimal.MinValue,null,null, short.MinValue);
			return data.Tables[0].Rows.Count > 0;

		}

		private void Step()
		{
			
			string IdComprobante = string.Empty;
			string IdCondicionDeVenta = string.Empty;
			_precomprobantesDePago.Clear();
			foreach(RelacionComprobanteOrigenDestino relacion in this._relacionesComprobanteOrigenDestino)
			{
				
				if(!IdComprobante.Equals(relacion.IdComprobante) )//&& ComprobantesRules.Comprobantes_CondicionDeVenta_Permite_Imputar(relacion.IdCondicionDeVenta))
				{
					/*Generalizarlo, pr ahora sirve para el camino RET - RE*/
					IdComprobante = relacion.IdComprobante;
					IdCondicionDeVenta = relacion.IdCondicionDeVenta;
					if(ExistsImputacion(IdComprobante))
					{
						ComprobanteDePago precomprobanteDePago = Factory.GetComprobanteDePago(IdComprobante, IdCondicionDeVenta);
						_precomprobantesDePago.Add(precomprobanteDePago);
						StepValores(precomprobanteDePago);	
					}
				}
      
			}
			if(_precomprobantesDePago.Count > 0)
			{
				this.Recalcular();
				//StepCuentaCorriente();
				if(ObjectHasChanged != null)
					ObjectHasChanged(this, new EventArgs());
			}
		}

		public void StepCuentaCorriente()
		{
			if(_precomprobantesDePago.Count >0 )
			{
				ComprobanteDePago cdp = (ComprobanteDePago)_precomprobantesDePago[0];
				if(cdp.CuentaCorriente != null)
				{
					this._cuentaCorriente = cdp.CuentaCorriente.ShallowClone();
					foreach(DetalleCuentaCorriente dcc in this._cuentaCorriente.Detalle)
					{
						dcc.IdComprobante = this._idComprobanteDeVenta;
						dcc.IdTipoDeComprobante = this._idTipoDeComprobanteDeVenta;
						dcc.Comprobante = this._tipoDeComprobanteDeVenta;
						dcc.Numero = this._numeroComprobanteDeVenta;
						decimal pago = dcc.ImporteSinSigno -dcc.SaldoSinSigno;
						dcc.SetPago(pago);
					}
					this._cuentaCorriente.RecalcularTotalPago();
					this._totalPago = cdp.TotalPago;
					this._cuentaCorriente.IdCuenta = this._idCuenta;
				}
			}
		}
		public void PutExtraData( ProcessCollectionData _processCollectionData)
		{
			//OJOOOOOO MAS ADELANTE JUNTAR LOS DOS IF
			foreach( TaskCollectionData _collectionTask in _processCollectionData)
			{
				#region PreVender , VenderManual, Devolver, Prestar
				if ((_collectionTask.TaskName.Equals("Prevender")) || 
					_collectionTask.TaskName.Equals("Devolver")|| _collectionTask.TaskName.Equals("DevolverManual")
					|| _collectionTask.TaskName.Equals("Prestar") || _collectionTask.TaskName.Equals("Preprestar")
					|| _collectionTask.TaskName.Equals("PrestarDevolver") || _collectionTask.TaskName.Equals("Predevolver")					
					)
				{
					string idcomprobantedeventa = null;
					foreach (System.Data.DataSet dataventas in _collectionTask )
					{
						if (dataventas.DataSetName.Equals( "tsa_ComprobantesExDataset"))
						{
							idcomprobantedeventa = Convert.ToString(dataventas.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"]);
						}
					}
					SortedList comps = Workflow.GetComprobantesAsociadosList(Workflow.GetIdTakByName(_collectionTask.TaskName));
					foreach (System.Data.DataRow row in  this.DatasetComprobante.tsa_Comprobantes.Rows)
					{
						if (comps.ContainsKey( (string)row["IdTipoDeComprobante"]))
						{
							row["IdComprobante"]= idcomprobantedeventa;
							row.AcceptChanges();
						}
					}
					foreach (System.Data.DataRow row in this.DatasetComprobante.tsa_AplicacionPagos.Rows)
					{
						row["IdComprobanteOrigen"] = idcomprobantedeventa;

					}
					foreach(System.Data.DataRow row in this.DatasetComprobante.tsa_ComprobanteDetalleDeuda.Rows)
					{
						if (comps.Contains( (string)row["IdTipoDeComprobante"]))
						{
							row["IdComprobante"]= idcomprobantedeventa;
						}
					}
				}
				#endregion
				
				#region Vender, PrevenderVender
				if ((_collectionTask.TaskName.Equals("Vender"))
					|| (_collectionTask.TaskName.Equals("VenderManual")) 
					)
				{
					string idcomprobantedeventa = null;
					string numero = null;
					foreach (System.Data.DataSet dataventas in _collectionTask )
					{
						if (dataventas.DataSetName.Equals( "tsa_ComprobantesExDataset"))
						{
							idcomprobantedeventa = Convert.ToString(dataventas.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"]);
                            numero = Convert.ToString(dataventas.Tables["tsa_Comprobantes"].Rows[0]["Numero"]);
						}
					}
					SortedList comps = Workflow.GetComprobantesAsociadosList(Workflow.GetIdTakByName(_collectionTask.TaskName));
					foreach (System.Data.DataRow row in  this.DatasetComprobante.tsa_Comprobantes.Rows)
					{
						if (comps.ContainsKey( (string)row["IdTipoDeComprobante"]))
						{
							row["IdComprobante"]= idcomprobantedeventa;
							row.AcceptChanges();
						}
					}
					
					foreach (System.Data.DataRow row in  this.DatasetComprobante.tsa_Comprobantes.Rows)
					{	 
						if (Convert.ToString(row["IdTipoDeComprobante"]).Equals(this.TipoComprobanteDestino))
						{
							row["Observaciones"]=  "Comprobante asociado: "+ numero;							
							//row.AcceptChanges();
						}	
						
					}
					
					foreach (System.Data.DataRow row in this.DatasetComprobante.tsa_AplicacionPagos.Rows)
					{
						row["IdComprobanteOrigen"] = idcomprobantedeventa;
						
					}
					foreach(System.Data.DataRow row in this.DatasetComprobante.tsa_ComprobanteDetalleDeuda.Rows)
					{
						if (comps.Contains( (string)row["IdTipoDeComprobante"]))
						{
							row["IdComprobante"]= idcomprobantedeventa;
						}
					}
				}
				#endregion				
			}	
		}
					

		private void StepValores(ComprobanteDePago precomprobaneDePago)
		{
			Valores valoresPrecomprobante = precomprobaneDePago.Valores;
			//this._valores.DataValoresEx.Merge(valoresPrecomprobante.DataValoresEx,false);
			foreach(Valor valor in valoresPrecomprobante.MisValores)
			{
				this._valores.Add(valor);
			}
		}


		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			foreach( TaskCollectionData _collectionTask in _processCollectionData)
			{
				if ((_collectionTask.TaskName.Equals("Vender")) || (_collectionTask.TaskName.Equals("Prevender")) 
					|| (_collectionTask.TaskName.Equals("Preprestar"))|| (_collectionTask.TaskName.Equals("VenderManual"))
					|| (_collectionTask.TaskName.Equals("Prestar") || _collectionTask.TaskName.Equals("Devolver")
					|| _collectionTask.TaskName.Equals("DevolverManual") || _collectionTask.TaskName.Equals("PrestarDevolver")
					|| _collectionTask.TaskName.Equals("Predevolver")					
					))
				{
					foreach (System.Data.DataSet dataventas in _collectionTask )
					{
						if (dataventas.DataSetName.Equals( "tsa_ComprobantesExDataset"))
						{
							if(dataventas.Tables["tsa_comprobantes"].Rows.Count == 1)
								this.DatasetComprobante.tsa_Comprobantes.LoadDataRow(dataventas.Tables["tsa_comprobantes"].Rows[0].ItemArray, true);
							foreach(System.Data.DataRow row in dataventas.Tables["tsa_ComprobanteDetalleDeuda"].Rows)
								this.DatasetComprobante.tsa_ComprobanteDetalleDeuda.LoadDataRow(row.ItemArray, true);
							if(IsStep())
							{
								string idComprobanteDeVenta = Convert.ToString(dataventas.Tables["tsa_comprobantes"].Rows[0]["IdComprobante"]);
								string idTipoDeComprobante = Convert.ToString(dataventas.Tables["tsa_comprobantes"].Rows[0]["IdTipoDeComprobante"]);
								foreach(DetalleCuentaCorriente dcc in this._cuentaCorriente.Detalle)
								{
									dcc.IdComprobante = idComprobanteDeVenta;
									dcc.IdTipoDeComprobante = idTipoDeComprobante;
								}
							}
						}
					}
				}
			}	



		}
		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;


		public event System.EventHandler OnTaskBeforePrevious;
		public event System.EventHandler OnTaskAfterPrevious;

		public void Previous()
		{
			if(OnTaskBeforePrevious != null)
				OnTaskBeforePrevious(this, new EventArgs());
			if(OnTaskAfterPrevious != null)
				OnTaskAfterPrevious(this, new EventArgs());
		}

		public bool AllowPrevious()
		{
			return true;
		}
		public void ListenerAfterPreviousDependentTask( object sender )
		{
		}
		public void ListenerBeforePreviousDependentTask( object sender )
		{
		}	
		
		public string TDCompTesoreriaDefault()
		{
			return Variables.GetValueString("Momentos.Comprobantes.TDCompTesoreria.Default");
		}
		public string MonedaDefault()
		{ 
			return Variables.GetValueString("Contabilidad.MonedaReferencia");
		}

		public string FillNumberWithZeros(string txt)
		{
			string separator = Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) (	Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) (	Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}

        //Sabrina: Tarea 1119. 20110816
        public enum SortOrder
        {
            EmisionAsc,
            EmisionDesc,
            VencimientoAsc,
            VencimientoDesc
        };
        //Fin Sabrina: Tarea 1119. 20110816
    }
}

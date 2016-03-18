// Modelo estático
using System;
using System.Collections;
using System.Data;
using mz.erp.businessrules.data;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using mz.erp.systemframework;
using System.Text;

namespace mz.erp.businessrules.comprobantes
{
	/// <summary>
	/// Realiza toda la funcionalidad para los comprobantes de venta.
	/// Controla los comprobantes que se definan en la tabla tsa_TiposDeComprobantes
	/// Maneja Impuestos, Formas de Pago, Stock, Cuenta Corriente.
	/// Adquiere su funcionalidad a través de variables definidas en el sistema.
	/// Interactua con clases auxiliares.
	/// Esta a la espera de notificaciones de cambios de sus clases auxiliares para
	/// forzar refrezcos de información.
	/// Genera dos eventos globales que permiten determinar posibles refrescos de la informacion
	/// en la interfase de usuario.
	/// </summary>
	
	
	public class ComprobanteDeVenta	: Comprobante, ITask, IPersistentTask
	{
		#region Eventos y Delegados
		
		/// <summary>
		/// Delegado Asociado al evento RecalcularComprobante;
		/// </summary>
		public delegate void RecalcularComprobante( object sender, System.EventArgs e );
		/// <summary>
		/// Evento que se dispara cada vez que una variable interviniente en cualquiera de las
		/// clases subyacentes ha generado un cambio en los atributos de calculo y que podrian
		/// llegar a forzar un refresco de los calculos informados en la interfase.
		/// </summary>
		public event RecalcularComprobante OnRecalcularComprobante;

		/// <summary>
		/// Delegado asociado al evento RefrescarComprobante
		/// </summary>
		public delegate void RefrescarComprobante( object sender, System.EventArgs e );
		/// <summary>
		/// Evento que se dispara cada vez que una varibles interviniente en cualquiera de las
		/// clases subyacentes ha generado un cambio en un atributo informativo. No necesariamente
		/// necesita un refrezco de todos los componentes de la interfase y por lo general se
		/// conocerá nuevo valor de antemano. Por ejemplo el cambio de un valor que antes paso
		/// por la interfase de usuario y luego modifico al atributo de la clase.
		/// </summary>
		public event RefrescarComprobante OnRefrescarComprobante;

		public event EventHandler TableCondicionesDeVentaChanged;
		public event EventHandler CondicionesDeVentaChanged;




		#endregion

		#region Variables Publicas
		
		/// <summary>
		/// Define si se debe permitir modificar el tipo de comprobante
		/// </summary>
		/// 

		
		public bool ProductosControlFocused
		{
			get{return _allowGeneracionRapida;}
		}


		public DataTable TableCondicionesDeVenta
		{
			get{return _tableCondicionesDeVenta;}
		}

		public ArrayList OrdenesReparacion 
		{
			get
			{
				return _ordenesReparacion;
			}
		}

		public string State
		{
			get{return _state;}
		}

		/*
		public bool HasValores
		{
			get
			{
				if(this._comprobanteDePago == null)
					return false;
				else
					return (this._comprobanteDePago.Valores.MisValores.Count > 0);
		
			}
		}
		*/
		
		private bool _renombraClienteDePaso = false;
		public bool RenombraClienteDePaso
		{
			get{return _renombraClienteDePaso;}
			
		}

		private bool _mustRecalcular = true;
		public bool MustRecalcular
		{
			set{this._mustRecalcular = value;}
			get{return _mustRecalcular;}

		}
			
		private bool _listasDePrecios = false;
		public bool ListasDePrecios
		{
			get { return _listasDePrecios; }
		}

		private bool _permiteListaDePreciosDistintas = false;
		public bool PermiteListaDePreciosDistintas
		{
			get{return _permiteListaDePreciosDistintas;}
		}

		public string IdDeposito
		{
			get{return _idDeposito;}
		}

		public string IdSeccion
		{
			get{return _idSeccion;}
		}

		public string Numero
		{
			get
			{
				return _numero;
			}
			set
			{
				if(_numero != value)
				{
					_numero = value;
					/*
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
						*/
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

		public bool AllowToValidateDocumento
		{
			get
			{
				return _allowToValidateDocumento;
			}
			set
			{
				_allowToValidateDocumento = value;
			}			
		}

		public bool AllowToValidateDNIForImporte
		{
			get
			{
				return _allowToValidateDNIForImporte;
			}
			set
			{
				_allowToValidateDNIForImporte = value;
			}			
		}
		public bool AllowToValidateTipoDocumentoForImporte
		{
			get
			{
				return _allowToValidateTipoDocumentoForImporte;
			}
			set
			{
				_allowToValidateTipoDocumentoForImporte = value;
			}			
		}
		

		public bool AllowEditTipoDeComprobante
		{
			set { _allowEditTipoDeComprobante = value; }
			get { return _allowEditTipoDeComprobante; }
		}

		public bool AllowEditVariablesAuxiliares
		{
			set { _allowEditVariablesAuxiliares = value; }
			get { return _allowEditVariablesAuxiliares; }
		}
		

		/// <summary>
		/// Define si se debe permitir modificar la cuenta
		/// </summary>
		public bool AllowEditCuenta
		{
			set { _allowEditCuenta = value; }
			get { return _allowEditCuenta; }
		}

		/// <summary>
		/// Define si se debe permitir modificar la fecha
		/// </summary>
		public bool AllowEditFecha
		{
			set { _allowEditFecha = value; }
			get { return _allowEditFecha; }
		}

		public bool AllowToShowWarningItemsPertenecenAJerarquias
		{
			get{return _allowToShowWarningItemsPertenecenAJerarquias;}
			set{_allowToShowWarningItemsPertenecenAJerarquias = value;}
		}

		public bool AllowToShowWarningItemsConMonto0
		{
			get{return _allowToShowWarningItemsConMonto0;}
			set{_allowToShowWarningItemsConMonto0 = value;}
		}
		
		public bool AllowToValidateItemsPertenecenAJerarquias
		{
			set
			{		
				_allowToValidateItemsPertenecenAJerarquias = value;
			}
			get
			{	
				return _allowToValidateItemsPertenecenAJerarquias ;
			}
		}

		public bool AllowToValidateItemsNoPertenecenAJerarquias
		{
			set
			{		
				_allowToValidateItemsNoPertenecenAJerarquias = value;
			}
			get
			{	
				return _allowToValidateItemsNoPertenecenAJerarquias ;
			}
		}


		public bool AllowToValidateMaximoDescuentoItemMenorBonificaciones
		{
			get{return _allowToValidateMaximoDescuentoItemMenorBonificaciones;}
		}


		public bool AllowToValidateItems
		{
			set
			{		
				_allowToValidateItems = value;
			}
			get
			{	
				return _allowToValidateItems ;
			}
		}

		public bool AllowToShowWarningDiasLimiteDeCredito
		{
			set
			{
				_allowToShowWarningDiasLimiteDeCredito = value;
			}
			get
			{
				return _allowToShowWarningDiasLimiteDeCredito;
			}

		}


		public bool AllowToShowWarningLimiteDeCredito
		{
			set
			{
				_allowToShowWarningLimiteDeCredito = value;
			}
			get
			{
				return _allowToShowWarningLimiteDeCredito;
			}

		}

		public bool AllowToValidateDiasLimiteDeCredito
		{
			set
			{		
				_allowToValidateDiasLimiteDeCredito = value;
			}
			get
			{	
				return _allowToValidateDiasLimiteDeCredito ;
			}
		}


		public bool AllowToValidateLimiteDeCredito
		{
			set
			{		
				_allowToValidateLimiteDeCredito = value;
			}
			get
			{	
				return _allowToValidateLimiteDeCredito ;
			}
		}


		public bool AllowToValidateItemsConMonto0
		{
			set
			{		
				_allowToValidateItemsConMonto0 = value;
			}
			get
			{	
				return _allowToValidateItemsConMonto0 ;
			}
		}

		public bool AllowToValidateCondVenta
		{
			set
			{
				_allowToValidateCondVenta = value;
			}
			get
			{
				return _allowToValidateCondVenta;
			}
		}
		
		/// <summary>
		/// Define si debe permitir modificar al responsable de emisión
		/// </summary>
		public bool AllowEditResponsableEmision
		{
			set { _allowEditResponsableEmision = value; }
			get { return _allowEditResponsableEmision; }		
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
		
		
		/// <summary>
		/// Define si debe permitir editar la condición de venta
		/// </summary>
		public bool AllowEditCondicionDeVenta
		{
			set { _allowEditCondicionDeVenta = value; }
			get { return _allowEditCondicionDeVenta; }
		}
		
		/// <summary>
		/// Defin si debe permitir editar los items
		/// </summary>
		public bool AllowEditItems
		{
			set { _allowEditItems = value; }
			get { return _allowEditItems; }
		}
		public bool AllowDeleteItems
		{
			set { _allowDeleteItems = value; }
			get { return _allowDeleteItems; }
		}
		public bool AllowAddItems
		{
			set { _allowAddItems = value; }
			get { return _allowAddItems; }
		}		
		/// <summary>
		/// Define si debe permitir editar la forma de pago
		/// </summary>
		public bool AllowEditFormasDePago
		{
			set { _allowEditFormasDePago = value; }
			get { return _allowEditFormasDePago; }
		}

		/// <summary>
		/// Define si debe permitir actualizar la numeración
		/// </summary>
		public bool ActualizaNumeracion 
		{
			set { _actualizaNumeracion = value;}
			get { return _actualizaNumeracion; }
		}

		public bool AllowEditNumeration
		{
			set { _allowEditNumeration = value;}

			get { return _allowEditNumeration; }
		}

		

		public bool Validar
		{
			set { _validar = value;}

			get { return _validar; }
		}

		public string IdVariablesAuxiliares 
		{
			get 
			{
				string valor = string.Empty;
				string variable = "Momentos." + this._processManager.Process.ProcessName + "." + "VariablesAuxiliares.Detalle";
				valor = Variables.GetValueString(variable);				
				return valor;
				//return Variables.GetValueString("Momentos.Vender.VariablesAuxiliares.Detalle");				
			}
		}

		private string _idListaDePreciosDefault = String.Empty;
		public string IdListaDePreciosDefault
		{
			get{return _idListaDePreciosDefault;}
			set{_idListaDePreciosDefault = value;}
		}
		
		private string _textoBotonAnterior = "Anterior";
		public string TextoBotonAnterior
		{
			get 
			{		
				string valor = string.Empty;
				try 
				{
					string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonAnterior";
					valor = Variables.GetValueString(variable);				
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonAnterior";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
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
				string valor = string.Empty;
				try 
				{
					string variable = "Momentos." + this.GetTaskName() + "." + this._processManager.Process.ProcessName + "." + "TextoBotonSiguiente";
					valor = Variables.GetValueString(variable);
					if (valor == String.Empty)
					{
						variable = "Sistema.Interfaz.TextoBotonSiguiente";
						valor = Variables.GetValueString(variable);				
					}
				}
				catch 
				{
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

		public bool PreguntarAlCancelar
		{
			get 
			{
				bool _preguntarAlCancelar = Variables.GetValueBool(_processManager.Process.ProcessName,_taskName,"PreguntarAlCancelar",false);
				return _preguntarAlCancelar ;}
		}

        /* Silvina 20100531 - Tarea 646 */
        private bool _seleccionaUltimo = false;
        public bool SeleccionaUltimo
        {
            get { return _seleccionaUltimo; }
        }
        /* Fin Silvina */

		/// <summary>
		/// Colección de Items de Comprobantes
		/// </summary>
		/// 
		//private ItemsComprobantes _items;
		public ItemsComprobantes Items;
		
		/*{
				get{return _items;}
				set{_items = value;}
			}
			*/

		/// <summary>
		/// Clase Cuenta contiene los atributos y la funcionalidad de la cuenta asociada al comprobante
		/// </summary>
		public Cuenta Cuenta;

		/// <summary>
		/// Establece las formas de pago con que se abonará el comprobante de venta.
		/// </summary>
		public FormasDePagos FormasDePago;


		public override string Mascara
		{
			set 
			{ 
				base._mascara = value; 
	
			}
			get 
			{ 
				if (base._mascara == null)
				{
					base._mascara = string.Empty;
				}
				return base._mascara ; 
			}
		}


		public override string TipoComprobanteOrigen
		{
			set
			{				
				this._tipoComprobanteOrigen = value;
			}
			get
			{
				return _tipoComprobanteOrigen;
			}
		}


		/// Un Tipo de Comprobante. De la tabla Tipos De Comprobante.
		/// Como cada comprobante posee una definición impositiva y otras caracteristicas en particular
		/// fuerza el refrezco de los miembros de la clase Comprobante. 
		/// Indirectamente puede generar un evento de notificación de cambios en el comprobante.		/// 
		/// </summary>
		public override string TipoComprobanteDestino
		{
			set
			{				
				this._tipoComprobanteDestino = value;
				if (this.Items != null)
				{
					this.Items.RefrescarImpuestos();					
					this.VariablesComprobante = new VariablesAuxiliares( this._state, this );
				}
				this._mascara = tsy_TiposDeComprobantes.Mascara(this._tipoComprobanteDestino);
				if(this._mascara != null )
				{
					if(this._numero == null || this._numero == string.Empty)
						this._numero = this._mascara;
                    /* Silvina 20111230 - Tarea 0000245 */
					/*if(this.SugiereNumeracion())
					{
						if(this._tipoComprobanteDestino != null && this._tipoComprobanteDestino != string.Empty)
						{*/                            
							//German 20090804
							/*string numeracion = string.Empty;
							if(_numeracionPorPerfil)
								numeracion = Variables.GetValueStringPerfilesWithoutCache("Comprobantes.Numeracion." + this._tipoComprobanteDestino, Security.IdPerfil);
							else
								numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + this._tipoComprobanteDestino);*/
							/*
							if(numeracion != string.Empty)
								this._numero = Util.StcZero(numeracion,8);
							*/
							/*if(numeracion != string.Empty)
							{
								this._numero = Util.StcZero(numeracion,8);
								//if(NumeroComprobanteChanged	!= null)
								//	NumeroComprobanteChanged(this, new EventArgs());
							}*/
							//Fin German 20090804
                      RefreshNumeracion();                            
						/*}					
					}*/
                    /* Fin Silvina 20111230 - Tarea 0000245 */
				}
				
				if (ObjectHasChanged != null)
					ObjectHasChanged(this,new System.EventArgs());
				
				
			}
			get
			{
				return _tipoComprobanteDestino;
			}
		}

		
		/// <summary>
		/// Total del comprobante. Sin impuestos.Incluye recargos financieros. 
		/// Es el valor neto final una vez aplicado las bonificaciones y recargos por todo concepto.
		/// </summary>
		public decimal TotalNeto
		{
			get
			{
				decimal subtotal = 0;
				if(this.Items != null)
				{
					foreach (ItemComprobante item in this.Items)
					{
						subtotal+= item.SubTotalNeto;
					}
				}
				return subtotal;
			}
		}

		/// <summary>
		///
		/// Total del comprobante. Sin impuestos.Incluye recargos financieros. 
		/// Es el valor neto final una vez aplicado las bonificaciones y recargos por todo concepto
		/// sobre los Items q perciben IB
		/// </summary>
		public decimal TotalNetoAPercibirIB
		{
			get
			{
				decimal subtotal = 0;
				if(this.Items != null)
				{
					foreach (ItemComprobante item in this.Items)
					{
						if(item.PercibeIB)
							subtotal+= item.SubTotalNeto;
					}
				}
				return subtotal;
			}
		}
		/// <summary>
		/// El valor total de la factura. Impuestos incluidos. Incluye todas las bonificaciones
		/// </summary>
		public decimal TotalConImpuestos
		{
			get
			{
				
				decimal subtotal = 0;
				if(this.Items != null)
				{
					foreach (ItemComprobante item in this.Items)
					{
						subtotal+= item.SubTotalConImpuestos;
					}
				}
				return subtotal;
			}
		}

		/// <summary>
		/// Sumatoria del resumen de impuestos que aplican a todo el comprobante.
		/// En forma directa e indirecta.
		/// </summary>
		public decimal TotalImpuestos
		{
			get
			{
				
				if (this.Items != null)
				{
					return this.Items.TotalImpuestos;
				}
				else
				{
					return 0;
				}
			}

		}

		/// <summary>
		/// Sumatoria del total bruto de los items (sin impuestos) sin aplicar ningún ninguna
		/// bonificación ni recargo a los mismos.
		/// Es el valor que se obtendria si el comprobante no sufre ninguna bonificación ni
		/// recargo por todo concepto.
		/// </summary>
		public decimal TotalBruto
		{
			get
			{
				
				if (this.Items != null)
				{
					return this.Items.TotalBruto;
				}
				else
				{
					return 0;
				}

			}
		}
		/// <summary>
		/// Sumatoria de los descuentos directos aplicados a los items. 
		/// Sin incluir recargos/bonificaciones financieras.
		/// Los descuentos directos son los aplicados por descuentos definidos a la cuenta, al producto y al volumen de venta
		/// </summary>
		public decimal TotalDescuentos
		{
			get
			{
				if (this.Items != null)
				{
					return this.Items.TotalDescuentos;
				}
				else
				{
					return 0;
				}
			}
		}

		public decimal TotalDescuentosCuentas
		{
			get
			{
				if (this.Items != null)
				{					
					return this.Items.TotalBonificacionesRecargosCuenta;
				}
				else
				{
					return 0;
				}
			}
		}

		public decimal TotalDescuentosProductos
		{
			get
			{
				if (this.Items != null)
				{										
					return this.Items.TotalBonificacionesRecargosProducto;					
				}
				else
				{
					return 0;
				}
			}
		}

		public decimal TotalConImpuestosSinRecargos
		{
			get
			{
				if(this.Items != null)
				{
					return this.Items.TotalConImpuestosSinRecargos;
				}
				return 0;
			}
		}


		private decimal _porcentualrecargosFinancieros=0;
		public decimal PorcentualRecargosFinancieros
		{
			get
			{
				//CalcularRecargosFinancieros();
				return _porcentualrecargosFinancieros;
			}
		}
		/// <summary>
		/// Sumatoria de los recargos o bonificaciones aplicados indirectamente a los items pero que han modificado su precio
		/// Los recargos financieros (por ejemplo un recargo por abonar con Tarjeta de Credito) modifican el precio final del
		/// producto y son almacenados en otro atributo para poder discriminarlos.
		/// </summary>
		public decimal TotalRecargosFinancieros
		{
			get
			{
				return this.Items.TotalRecargosFinancieros;
			}
		}
		/// <summary>
		/// El total del comprobante de venta. Incluido todo concepto. 
		/// Utilizar este valor para determinar el monto final del comprobante
		/// </summary>
		public override decimal Total
		{
			get
			{
				return decimal.Round(this.TotalConImpuestos,2);
			}
		}

		/*
		public override decimal Saldo
		{
			get
			{
				return this.Total - _comprobanteDePago.Total;
			}
		}
		*/
		/// <summary>
		/// Codigo de responsable que emite el comprobante. Relacion con la tabla Personas
		/// </summary>
		public string IdResponsable
		{
			get
			{
				return _idResponsable;
			}
			set
			{
				if(_idResponsable != value)
				{				
					_idResponsable = value;					
					if (_idResponsable != null && _idResponsable != String.Empty)
					{
						tsh_PersonasDataset.tsh_PersonasRow row = businessrules.tsh_Personas.GetByPk(value);
						_responsable =  row.Nombre;			
						RefreshCondicionesDeVentas();
                        /* Silvina 20111230 - Tarea 0000245 */
                        RefreshNumeracion();
                        /* Fin Silvina 20111230 - Tarea 0000245 */
					}
					else 
					{
						_responsable = "";
						/*if (ObjectHasChanged != null)
							ObjectHasChanged(this,new System.EventArgs());*/
					}
				}
			}
		}

		/// <summary>
		/// Propiedad. Devuelve el nombre del responsable de la emisión del comprobante.
		/// </summary>		
		public string Responsable
		{
			get { return _responsable; }
			set 
			{ 
				_responsable = value; 
			}
		}

		public System.Data.DataTable ResumenDeImpuestos
		{
			get
			{
				if (this.Items != null)
				{
					return this.Items.ResumenDeImpuestos;
				}
				else
				{
					return null;
				}
			}
		}
		

		public string Momento 
		{
			set
			{
				_momento = value;
			}
			get
			{
				return _momento;
			}
		}

		public long MomentoDeStock
		{
			get { return _momentoDeStock; }
			set { _momentoDeStock = value; }
		}
		
		public string EstadoDeStockOrigen
		{
			get { return _estadoDeStockOrigen; }
			set { _estadoDeStockOrigen = value; }
		}
		
		public string EstadoDeStockDestino
		{
			get { return _estadoDeStockDestino; }
			set { _estadoDeStockDestino = value; }
		}

		public decimal ImporteCancelado
		{
			get { return _importeCancelado; } 
			set { _importeCancelado = value; } 
		}

		public ArrayList ComprobantesAsociados
		{
			get { return _comprobantesAsociados; } 
			set { _comprobantesAsociados = value; } 
		}

        //German 20120306 - Tarea 0000289
        public ArrayList RemitosAsociados
        {
            get { return _remitosAsociados; }
            
        }
        //Fin German 20120306 - Tarea 0000289

		public DateTime FechaComprobante
		{
			get
			{
				return _fechaComprobante;
			}
			set
			{
				if(_fechaComprobante != value)
				{
					_fechaComprobante = value;
					/*
					if(ObjectHasChanged != null)
						ObjectHasChanged(this, new EventArgs());
					*/
				}
			}
		}
		
		public string InfoCliente
		{
			set 
			{
				_infoCliente= value; 
				if (value != null && value != "")
					this.Cuenta.Nombre = value;
			}
			get { return _infoCliente; }
		}

		public string InfoDomicilio
		{
			set { _infoDomicilio= value; }
			get { return _infoDomicilio; }
		}
		public string InfoTipoDocumento
		{
			set { _infoTipoDocumento= value; }
			get { return _infoTipoDocumento; }
		}
		public string InfoDocumento
		{
			set { _infoDocumento= value; }
			get { return _infoDocumento; }
		}
		public string InfoObservaciones
		{	//leer comentario sobre infoXXX
			set { _infoObservaciones= value; }
			get { return _infoObservaciones; }
		}
		public string InfoAux1
		{
			set { _infoaux1= value; }
			get { return _infoaux1; }
		}
		public string InfoAux2
		{
			set { _infoaux2= value; }
			get { return _infoaux2; }
		}
		public string InfoAux3
		{
			set { _infoaux3= value; }
			get { return _infoaux3; }
		}


		//German 20091023 - tarea 470
		public ArrayList ResponsablesComprobantesAnteriores
		{
			get
			{
				return _responsablesComprobantesAnteriores;
			}
		}
		//Fin German 20091023 - tarea 470



		#endregion

		#region Variables Privadas
		private bool _allowEditTipoDeComprobante = true;
		private bool _allowEditVariablesAuxiliares = true;
		private bool _allowEditCuenta = true;
		private bool _allowEditFecha = true;
		private bool _allowEditResponsableEmision = true;
		private bool _askForPasswordResponsableEmision = false;
		private bool _allowEditCondicionDeVenta = true;
		private bool _allowEditItems = true;
		private bool _allowDeleteItems = true;
		private bool _allowAddItems = true;
		private bool _allowEditFormasDePago = true;
		private bool _allowEditNumeration = false;
		private bool _actualizaNumeracion = true;
		private bool _allowToValidateItems = false;
		private bool _allowToValidateItemsPertenecenAJerarquias = false;
		private bool _allowToValidateItemsNoPertenecenAJerarquias = false;
		private bool _allowToShowWarningItemsPertenecenAJerarquias = false;
		private bool _allowToShowWarningItemsConMonto0 = false;
		private bool _allowToValidateCondVenta = false;
		private bool _allowToValidateDNIForImporte = false;
		private bool _allowToValidateDocumento = false;
		private bool _allowToValidateTipoDocumentoForImporte = false;
		private bool _allowToValidateMaximoDescuentoItemMenorBonificaciones = false;
		private bool _validar = true;
		private bool _allowToValidateFlujosComprobantes = true;
		private bool _allowToValidateStock = false;
        //Cristian Tarea 0000023 20110217
        private bool _allowToValidateErrorStock = false;
        //fin Cristian
		private bool _allowActualizarPredecesores = true;
		private bool _actualizaPredecesoresOnCommit = true;
		private bool _allowGeneracionRapida = false;
		private bool _allowToValidateItemsConMonto0 = false;
		private bool _allowToValidateLimiteDeCredito = false;
		private bool _allowToShowWarningLimiteDeCredito = false;

		private string _mensajeErrorLimiteDeCredito = "La deuda en Cuenta Corriente supera el límite de crédito permitido para este cliente.";


		private bool _allowToValidateDiasLimiteDeCredito = false;
		private bool _allowToShowWarningDiasLimiteDeCredito = false;
		private string _mensajeErrorDiasLimiteDeCredito = "La deuda en Cuenta Corriente supera el límite en días de crédito permitido para este cliente.";
		private string _mensajeErrorTiposDeProductos = "No se puede agregar ese Tipo de Producto.";
        //Cristian Tarea 0000023 20110217
        private string _mensajeErrorCantidadDisponible = "El stock del producto {0} es insuficiente para realizar la venta";
        //Fin Cristian
		

		private string _idResponsable;
		private string _responsable;

		private string _momento = string.Empty;

		private long _momentoDeStock;
		private string _estadoDeStockOrigen;
		private string _estadoDeStockDestino;
		private string _idDeposito = string.Empty;
		private string _idSeccion = string.Empty;
		
		private decimal _importeCancelado = 0;
		private string _listaTiposDeComprobantesSugiereNumeracion = string.Empty;
		private string _listaTiposDeComprobantesValidarFlush = string.Empty;
		private string _numeroSugerido = string.Empty;

		private string _idAutorizacion = "";

		//private ComprobanteDePago _comprobanteDePago;
		private CancelacionComprobanteDePago _cancelacionComprobanteDePago;
		private DetalleCuentaCorriente _detalleCuentaCorriente;
		private ProcessManager _processManager;

		private ArrayList _ordenesReparacion = new ArrayList();

		private decimal _saldo;

		/// <summary>
		/// todas las variabels privadas _infoZZZZ se usan para matener la informacion 
		/// historica del cliente en un comprobante, es decir, si la informacion del cliente varia en el tiempo,
		/// esta informacion no se modifica en los comprobantes que ya fueron emitidos.
		/// </summary>
		/// <remarks>La informacion la almacena la siguiente clase -->  br/Comprobantes/Cuenta</remarks>
		private string _infoCliente= string.Empty;
		private string _infoDomicilio= string.Empty;
		private string _infoTipoDocumento= string.Empty;
		private string _infoDocumento= string.Empty;
		private string _infoObservaciones= string.Empty;
		private string _infoaux1= string.Empty;
		private string _infoaux2= string.Empty;
		private string _infoaux3= string.Empty;

		private string _idMonedaReferencia = string.Empty;
		private string _idFuenteDeCambioReferencia = string.Empty;		

		private bool _validaCambioDeFecha = false;
		private long _cantidadDeDias = 0;

		private ArrayList _comprobantesAsociados = new ArrayList(new string[] {});
		private DataTable _tableCondicionesDeVenta = new DataTable();
		private decimal _MACOR = 0;
		private string _estadoStockAValidar = string.Empty;
		private mz.erp.commontypes.SentenciasReplicacion _replication = new mz.erp.commontypes.SentenciasReplicacion();

		//German 20090804
		private bool _numeracionPorPerfil = false;
		//Fin German 20090804
        /* Silvina 20111230 - Tarea 0000245 */
        private bool _numeracionPorUsuario = false;
        /* Fin Silvina 20111230 - Tarea 0000245 */
		//German 20091023 - tarea 470
		private ArrayList _responsablesComprobantesAnteriores = new ArrayList();
		//Fin German 20091023 - tarea 470

        //German 20120208 - Tarea 0000276

        private string _mensajeErrorBonificaciones = "Los siguientes productos tienen descuentos mayores a las bonificaciones permitidas: ";
        //German 20120208 - Tarea 0000276

        //German 20120306 - Tarea 0000289
        private ArrayList _remitosAsociados = new ArrayList();
        //Fin German 20120306 - Tarea 0000289
		
		#endregion

		#region Constructores y Destructores
		/// <summary>
		/// Deprecated. Obtenido de la derivación de Dataobject
		/// </summary>
		public ComprobanteDeVenta()
		{
			this.Cuenta = new Cuenta( "NEW", this );
			this._idComprobante = mz.erp.systemframework.Util.NewStringId();
			this.CondicionDeVenta = new CondicionDeVenta( "NEW", this );
			_signoCuentaCorriente = -1;
		}

        /* Silvina 20111230 - Tarea 0000245 */
		private bool SugiereNumeracion(string TipoComprobante)
		{
			ArrayList aux = mz.erp.systemframework.Util.Parse(_listaTiposDeComprobantesSugiereNumeracion, ",");
            return aux.Contains(TipoComprobante);
		}
        /* Fin Silvina 20111230 - Tarea 0000245 */

		/// <summary>
		/// Constructor principal. Crea una nueva instancia de comprobante de venta.
		/// </summary>
		/// <param name="idTipoDeComprobante"></param>
		/// Un tipo de comprobante. Referido a la tabla TiposDeComprobantes
		/// <param name="IdCuenta"></param>
		/// Una cuenta. Referido a la tabla Cuentas.
		public ComprobanteDeVenta( string action, string momento, string idCuenta, System.DateTime Fecha, string idResponsable, string idCondicionDeVenta)
		{
			this.Momento = momento;
			Init( action, null, Momento, idCuenta, Fecha, idResponsable, idCondicionDeVenta, null,null);
		}

		public ComprobanteDeVenta( string action, string momento, string idComprobante, string TipoComprobanteDestino)
		{
			if (momento != null) 
			{
				this.Momento = momento;
			}
			Init( action, idComprobante, momento, null, System.DateTime.MinValue, null, null, TipoComprobanteDestino,null);						
		}

		public ComprobanteDeVenta( string action, string idComprobante, string TipoComprobanteDestino)
		{
			Init( action, idComprobante, null, null, System.DateTime.MinValue, null, null, TipoComprobanteDestino,null);						
		}

		public ComprobanteDeVenta( string action, string momento, string idComprobante, string TipoComprobanteDestino, RelacionesComprobanteOrigenDestino relaciones)
		{
			if (momento != null) 
			{
				this.Momento = momento;
			}
			Init( action, idComprobante, momento, null, System.DateTime.MinValue, null, null, TipoComprobanteDestino, relaciones);						
		}
		#endregion

		#region Inicializadores y Carga
		private void Init( string action, string idComprobante, string Momento, string idCuenta, System.DateTime Fecha, string idResponsable, string idCondicionDeVenta, string TipoComprobanteDestino, RelacionesComprobanteOrigenDestino relaciones)
		{
			
			this._momento = Momento;
			switch ( action.ToUpper() )
			{
				case "NEW":
					this._state = "NEW";
					FillLoadData( idComprobante, action.ToUpper(), TipoComprobanteDestino, Security.IdPersona, idCuenta, idCondicionDeVenta, relaciones);
					FillStaticData( );
					break;
				case "EDIT":
					this._state = "EDIT";
					this.AllowEdit = false;
					FillLoadData( idComprobante, action.ToUpper(), TipoComprobanteDestino, idResponsable, idCuenta, idCondicionDeVenta, relaciones);
					
					break;
				case "STEP":
					this._state = "STEP";
					FillLoadData( idComprobante, action.ToUpper(), TipoComprobanteDestino, idResponsable, idCuenta, idCondicionDeVenta, relaciones);
					FillStaticData( );
					this.IdComprobante = Util.NewStringId();										
					break;
			}
			SetEditablesProperty();
			_idDeposito = ComprobantesRules.TareaProceso_GetDeposito(this._processManager.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Deposito" );
			_idSeccion =  ComprobantesRules.TareaProceso_GetSeccion(this._processManager.Process.ProcessName, this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Seccion" );		
			if (this.AskForPasswordResponsableEmision)
				this.IdResponsable = null;
		}

		/// <summary>
		/// Segun el tipo de comprobante que se esta emitiendo (regido por el momento) establece cuales
		/// son las propiedades que pueden editarse o no dentro de la clase ComprobanteDeVenta
		/// </summary>
		private void SetEditablesProperty()
		{
			string cMomento = this.Momento;
			string IdProceso = this.ProcessName();
			AllowEditTipoDeComprobante = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.TComp");
			AllowEditCuenta = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, IdProceso, "Emision.Editar.Cuenta");
			AllowEditFecha = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.Fecha");
			AllowEditFormasDePago = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.FPago");
			AllowEditCondicionDeVenta = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.CondVenta");
			AllowEditItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.Items", _allowEditItems);
			AllowDeleteItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Delete.Items", _allowDeleteItems);
			AllowAddItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Add.Items", _allowAddItems);
			AllowEditResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.REmision");
			AskForPasswordResponsableEmision = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.HabilitarContraseña.REmision");
			AllowEditNumeration = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.Numeracion");
			AllowEditVariablesAuxiliares = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.VariablesAuxiliares", _allowEditVariablesAuxiliares);
			ActualizaNumeracion = ! ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Editar.Numeracion");
			AllowToValidateItems = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.Items");
			AllowToValidateItemsPertenecenAJerarquias = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.ItemsPertencenAJerarquias");
			AllowToValidateItemsNoPertenecenAJerarquias = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.ItemsNoPertencenAJerarquias");
			AllowToShowWarningItemsPertenecenAJerarquias = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.ItemsPertencenAJerarquias.MostrarWarning");
			AllowToValidateCondVenta = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.CondVenta");
			AllowToValidateDNIForImporte =  ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.DNI");			
			AllowToValidateDocumento = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.Documento");
			AllowToValidateTipoDocumentoForImporte = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.TipoDocumento");			
			_allowToValidateMaximoDescuentoItemMenorBonificaciones = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.ItemsMaximoDescuentoMenorBonificaciones");			
			_allowToValidateFlujosComprobantes = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.FlujosComprobantes", _allowToValidateFlujosComprobantes);
			_listaTiposDeComprobantesValidarFlush = Variables.GetValueString( IdProceso, this.Momento, "Emision.Validar.FlujosComprobantes.ListaTiposDeComprobantes");
			_allowToValidateStock = ComprobantesRules.Momentos_Parametros_Bool( this.Momento, IdProceso, "Emision.Validar.ItemsSinStock");
            //Cristian Tarea 0000023 20110217
            _allowToValidateErrorStock = ComprobantesRules.Momentos_Parametros_Bool(this.Momento, IdProceso, "Emision.Validar.Error.ItemsSinStock");
            //FinCristian
            _allowActualizarPredecesores = Variables.GetValueBool(IdProceso, Momento, "ActualizaPredecesoresYSucesores", "Comprobantes.ActualizaPredecesoresYSucesores");
			_actualizaPredecesoresOnCommit = Variables.GetValueBool(IdProceso, Momento, "ActualizaPredecesoresYSucesoresOnCommit", "Comprobantes.ActualizaPredecesoresYSucesoresOnCommit");
			AllowToValidateItemsConMonto0 = Variables.GetValueBool(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.ItemsConMonto0");
			AllowToShowWarningItemsConMonto0 = Variables.GetValueBool(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.ItemsConMonto0.MostrarWarning");
			AllowToValidateLimiteDeCredito = Variables.GetValueBool(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.LimiteDeCredito");
			AllowToShowWarningLimiteDeCredito = Variables.GetValueBool(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.LimiteDeCredito.MostrarWarning");
			_mensajeErrorLimiteDeCredito = Variables.GetValueStringDefault(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.LimiteDeCredito.MensajeAMostrar",_mensajeErrorLimiteDeCredito);
            
			AllowToValidateDiasLimiteDeCredito = Variables.GetValueBool(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.DiasLimiteDeCredito");
			AllowToShowWarningDiasLimiteDeCredito = Variables.GetValueBool(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.DiasLimiteDeCredito.MostrarWarning");
			_mensajeErrorDiasLimiteDeCredito = Variables.GetValueStringDefault(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.DiasLimiteDeCredito.MensajeAMostrar",_mensajeErrorDiasLimiteDeCredito);

			_mensajeErrorTiposDeProductos = Variables.GetValueStringDefault(this._processManager.Process.ProcessName, this.GetTaskName(), "Emision.Validar.TiposDeProductos.MensajeAMostrar",_mensajeErrorTiposDeProductos);
			
			string CodigoCuenta = Variables.GetValueString(this._processManager.Process.ProcessName, this.GetTaskName(), "Cuenta.Default"); 
			if (this.Cuenta.Codigo == CodigoCuenta)
			{
				bool permitirClienteDePaso = Variables.GetValueBool(this._processManager.Process.ProcessName, this.GetTaskName(), "PermitirClienteDePaso"); 					
				if (!permitirClienteDePaso)
				{
					AllowEditCuenta = true;
					string idCuenta = String.Empty;
					this.Cuenta = new Cuenta( "NEW", this, idCuenta);
					this.IdCuenta = idCuenta;					
				}
				}
		}

		private void FillStaticData( )
		{
			/*string EstadoOrigen = "";
			string EstadoDestino= "";
			ComprobantesRules.EstadosSegunMomento( this.MomentoDeStock, ref EstadoOrigen, ref EstadoDestino );
			this._estadoDeStockOrigen = EstadoOrigen;
			this._estadoDeStockDestino = EstadoDestino;*/
		}

        /* Silvina 20101101 - Tarea 887 */

        private bool _actualizaLP = false;

        public bool ActualizaLP
        {
            get { return _actualizaLP; }
        }

        /* Fin Silvina*/

        //German 20120514 - Tarea 0000325
        private bool _actualizaLPPorCategoria = false;

        public bool ActualizaLPPorCategoria
        {
            get { return _actualizaLPPorCategoria; }
        }
        //Fin German 20120514 - Tarea 0000325

        /* Silvina 20111104 - Tarea 0000222 */
        private bool _usaCategorias = false;

        public bool UsaCategorias
        {
            get { return _usaCategorias; }
        }

        /* Fin Silvina 20111104 - Tarea 0000222 */

		private void FillLoadData( string IdComprobante, string state, string TipoComprobanteDestino, string IdResponsable, string idCuenta, string idCondicionDeVenta, RelacionesComprobanteOrigenDestino relaciones)
		{			
			switch (state)
			{
				case "STEP":
				{
				
					this.DatasetComprobante = new mz.erp.commontypes.data.tsa_ComprobantesExDataset();
					this.IdResponsable = mz.erp.businessrules.Security.IdPersona;//relaciones.IdResponsable;
					this.VariablesComprobante = new VariablesAuxiliares( "STEP", this );
					this.Cuenta = new Cuenta( "EDIT", this, relaciones.IdCuenta );					
					this.IdCuenta = relaciones.IdCuenta;		
					bool ArrastraObservaciones = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "StepObservaciones",true);
					if(ArrastraObservaciones)
						this.Observaciones = relaciones.Observaciones;
					else this.Observaciones = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Emision.Editar.Observaciones.Default");
					this._infoCliente = relaciones.InfoCliente;
					if (this.Cuenta.Nombre != this.InfoCliente && this.InfoCliente != String.Empty) 
					{
						//Paso el nombre modificado cuando es cliente de paso. Lo utiliza InterfaceFiscal que toma el valor de la clase cuenta.
						this.Cuenta.Nombre = this.InfoCliente;
						this._renombraClienteDePaso = true;
 
					}
					this.TipoComprobanteOrigen = relaciones.Get(0).IdTipoDeComprobante;
					this.IdComprobanteOrigen = relaciones.Get(0).IdComprobante;					
					this.NumeroOrigen = relaciones.Get(0).Numero;
					
					_comprobantesAsociados.Add(this.NumeroOrigen);

                    //German 20120306 - Tarea 0000289
                    if(this._processManager.Process.ProcessName.Equals("ProcesoRemitirVender"))
                    {
                        _remitosAsociados.Clear();
                        foreach (RelacionComprobanteOrigenDestino rcod in relaciones)
                        {
                            if (!_remitosAsociados.Contains(rcod.Numero))
                                _remitosAsociados.Add(rcod.Numero);
                        }
                    }
                    //Fin German 20120306 - Tarea 0000289

					this.TipoComprobanteDestino = Cuenta.ComprobanteDeVentaSugerido(this._processManager.Process.ProcessName, this._taskName);
					if (TipoComprobanteDestino == null) 
					{
						this.TipoComprobanteDestino = TipoComprobanteDestino;
					}
					
					/*if (TipoComprobanteDestino == null) 
					{
						this.TipoComprobanteDestino = Cuenta.ComprobanteDeVentaSugerido();						
					}
					else 
					{
						this.TipoComprobanteDestino = TipoComprobanteDestino;
					}*/

					this.FechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
					this.IdComprobante = Util.NewStringId();
					
				
					this.TemporalNumeration = true;	
					/*********/
					this.Items = new ItemsComprobantes("STEP", this, relaciones);
					/*********/
					
					
					this._relacionesComprobanteOrigenDestino = relaciones;
					
					//this._porcentualrecargosFinancieros = this.Items.PorcentajeRecargosFinancieros;				

					this.Total= 0;
					_tableCondicionesDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.GetCondicionesDeVentaBy(this.Cuenta.IdCuenta,this.TipoComprobanteDestino,ProcessName(),GetTaskName(),IdResponsable);
					if( (relaciones.Get(0).IdCondicionDeVenta != null && relaciones.Get(0).IdCondicionDeVenta != string.Empty) || IsValidCondicionDeVentaForStep(relaciones.Get(0).IdCondicionDeVenta) )
					{
						this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, relaciones.Get(0).IdCondicionDeVenta);
						this._porcentualrecargosFinancieros = this.Items.PorcentajeRecargosFinancieros;				
					}
					else
					{						
						//this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, Convert.ToString(ComprobantesRules.Momentos_CondicionDeVenta_Default(this.Momento)));
						long cv = ComprobantesRules.Momentos_CondicionDeVenta_Default(this._taskName, this.ProcessName());
						if (cv == long.MinValue)
							cv = ComprobantesRules.Momentos_CondicionDeVenta_Default(this.Momento);
						if(cv == long.MinValue)
							this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, string.Empty);
						else
							this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, Convert.ToString(cv));
						this._porcentualrecargosFinancieros = this.CondicionDeVenta.Recargo;
					}
					this.Items.IsDirty = true;
					this.Items.RefrescarBonificaciones();
					this.Items.RefrescarImpuestos();
					this.Refresh();
					this.Items.IsDirty=false;	
					//this._comprobanteDePago = Factory.GetComprobanteDePago(relaciones.Get(0).IdComprobante, relaciones.Get(0).IdCondicionDeVenta);
					//this._importeCancelado = this._comprobanteDePago.Total;

					break;					
				}
				case "EDIT":
				{
					System.Console.WriteLine("Empieza el edit***************************************");
					System.Console.WriteLine(mz.erp.businessrules.Sistema.DateTime.Now.ToString());
					
					this.DatasetComprobante = mz.erp.businessrules.tsa_ComprobantesEx.GetList(  IdComprobante );
					tsa_ComprobantesExDataset.tsa_ComprobantesRow rowComprobante = (tsa_ComprobantesExDataset.tsa_ComprobantesRow)this.DatasetComprobante.tsa_Comprobantes.Rows[0];
					this.IdResponsable = rowComprobante.IdResponsable;
					

					this.TipoComprobanteDestino = rowComprobante.IdTipoDeComprobante; 
					this._momento = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this.TipoComprobanteDestino).Momento;
					this.FechaComprobante = rowComprobante.Fecha;
					this.IdComprobante = rowComprobante.IdComprobante;
					this.Numero = rowComprobante.Numero;
					this.TemporalNumeration = false;
					

					this.VariablesComprobante = new VariablesAuxiliares( "EDIT", this );
					this.Cuenta = new Cuenta( "EDIT", this, rowComprobante.IdCuenta );
					this.IdCuenta = rowComprobante.IdCuenta;
					System.Console.WriteLine("Antes de crear los items***************************************");
					System.Console.WriteLine(mz.erp.businessrules.Sistema.DateTime.Now.ToString());
					/*********/
					this.Items = new ItemsComprobantes("EDIT", this );
					/*********/
					this.Items.IsDirty=false;

					System.Console.WriteLine("Despues de crear los items***************************************");
					System.Console.WriteLine(mz.erp.businessrules.Sistema.DateTime.Now.ToString());
					
					this.CondicionDeVenta = new CondicionDeVenta("EDIT", this );
					this.Total= rowComprobante.Total;
					this._momento = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this.TipoComprobanteDestino).Momento;
					System.Console.WriteLine("Termina el edit***************************************");
					System.Console.WriteLine(mz.erp.businessrules.Sistema.DateTime.Now.ToString());
					break;					
				}

				case "NEW":
				{
					
					
					
					this.DatasetComprobante = new mz.erp.commontypes.data.tsa_ComprobantesExDataset();
					
					//Modificar para tomar el responsable por defecto
					
					this.IdResponsable = IdResponsable;
					if (idCuenta == null)
					{
						string codigo = ComprobantesRules.Momentos_Cuenta_Default( this.Momento );
						idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(codigo);
					}

					if (Momento == "AnularVenta") 
					{
						string codigo = ComprobantesRules.Momentos_Cuenta_Default( this.Momento );
						idCuenta = mz.erp.businessrules.tsa_Cuentas.GetPkByUk(codigo);
					}
					
				
					
					this.Cuenta = new Cuenta( "NEW", this, idCuenta);
					this.IdCuenta = idCuenta;
					
					
				
					
					if (Momento != "AnularVenta") 
					{
						if(idCuenta != null && !idCuenta.Equals(string.Empty))
						{
							string tipoDeComp = Cuenta.ComprobanteDeVentaSugerido(this._processManager.Process.ProcessName, this._taskName);

							if(tipoDeComp != null && !tipoDeComp.Equals(string.Empty))
							{						
								this.TipoComprobanteDestino = tipoDeComp ;
							}
							else
							{
								string tiposDeComp = ComprobantesRules.Momentos_Parametros(this._processManager.Process.ProcessName, this._taskName, "Comprobantes");
								ArrayList aux = mz.erp.systemframework.Util.Parse(tiposDeComp,",");
								if(aux.Count > 0)
									this.TipoComprobanteDestino = Convert.ToString(aux[0]);
							}
						}
						else
						{
							string tiposDeComp = ComprobantesRules.Momentos_Parametros(this._processManager.Process.ProcessName, this._taskName, "Comprobantes");
							ArrayList aux = mz.erp.systemframework.Util.Parse(tiposDeComp,",");
							if(aux.Count > 0)
								this.TipoComprobanteDestino = Convert.ToString(aux[0]);

						}
					}
					

					this.FechaComprobante = mz.erp.businessrules.Sistema.DateTime.Now;
					this.IdComprobante = Util.NewStringId();

					//this.Numero = string.Empty;
					//this.Numero = "A-0001-00001974";
					this.TemporalNumeration = true;
					
					this.VariablesComprobante = new VariablesAuxiliares( "NEW", this );
					

					
						
					/*********/
					this.Items = new ItemsComprobantes( "NEW", this );
					/*********/
					this.Items.IsDirty=false;
					
					_tableCondicionesDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.GetCondicionesDeVentaBy(this.Cuenta.IdCuenta,this.TipoComprobanteDestino,ProcessName(),GetTaskName(),IdResponsable);
					
					this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, idCondicionDeVenta );

					long condicionPorDefecto = ComprobantesRules.Momentos_CondicionDeVenta_Default(this._taskName, this._processManager.Process.ProcessName);
					if ( condicionPorDefecto == long.MinValue)
						condicionPorDefecto = ComprobantesRules.Momentos_CondicionDeVenta_Default(this.Momento); 									
					if ( ! (condicionPorDefecto == long.MinValue))
						this.CondicionDeVenta.IdCondicionDeVenta = Convert.ToString(condicionPorDefecto);
					
					
					this.Total= 0;
					//this._comprobanteDePago = Factory.GetComprobanteDePago();

					this.Observaciones = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Emision.Editar.Observaciones.Default");

					
					break;
				}
			}
			
			InitEvents();
		}

        /* Silvina 20111230 - Tarea 0000245 */
        private long _idPerfilNumeracion = -1;
        private string _idUsuarioNumeracion = string.Empty;

        private void RefreshNumeracion()
        {
            if (this.SugiereNumeracion(_tipoComprobanteDestino) && !string.IsNullOrEmpty(_tipoComprobanteDestino) && !string.IsNullOrEmpty(_idResponsable))
            {
                string numeracion = string.Empty;
                sy_PerfilesUsuariosEmpresasDataset perfiles;
                _idUsuarioNumeracion = sy_Usuarios.GetUsuario(_idResponsable);
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


                    //German 20120605 - Tarea 0000347
                    string _listaTiposDeComprobantesSugiereNumeracionCompartida = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumero.ListaTiposDeComprobantesCompartenNumeracion");
                    ArrayList aux = new ArrayList();
                    if (_listaTiposDeComprobantesSugiereNumeracionCompartida != null && _listaTiposDeComprobantesSugiereNumeracionCompartida != string.Empty)
                        aux = mz.erp.systemframework.Util.Parse(_listaTiposDeComprobantesSugiereNumeracionCompartida, ",");
                    if (aux.Contains(this._tipoComprobanteDestino)) //Si comparte la numercion con otro tipo de comprobante, es para cuando son distintos tipos de comprobantes para el sistema que comparten el mismo preimpreso.
                    {
                        string _tipoDeComprobanteComparteNumero = Variables.GetValueStringWithoutCache("Comprobantes.NumeracionCompartida." + this._tipoComprobanteDestino + ".ComparteCon");
                        if (_tipoDeComprobanteComparteNumero != null && _tipoDeComprobanteComparteNumero != string.Empty)
                        {
                            _idUsuarioNumeracion = string.Empty;
                            numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + _tipoDeComprobanteComparteNumero);
                        }
                    }
                    else
                    {

                        _idUsuarioNumeracion = string.Empty;
                        numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + this._tipoComprobanteDestino);
                    }
                    //Fin German 20120605 - Tarea 0000347
                    
                    
                  
                }
                if (numeracion != string.Empty)
                {
                    this._numero = Util.StcZero(numeracion, 8);
                    if (ObjectHasChanged != null)
                        ObjectHasChanged(this, new System.EventArgs());
                }
            }
        }
        /* Fin Silvina 20111230 - Tarea 0000245 */

		public void RefreshCondicionesDeVentas()
		{
            /* Silvina 20100520 - Tarea 762 */
            if ((IdResponsable == null) 
                /* Silvina 20110209 - Tarea 1057 */
                || (IdResponsable.Equals(string.Empty)))
                /* Fin Silvina */
                _tableCondicionesDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.GetCondicionesDeVentaBy(this.Cuenta.IdCuenta, this.TipoComprobanteDestino, ProcessName(), GetTaskName(), Security.IdPersona);
            else
			    _tableCondicionesDeVenta = mz.erp.businessrules.tsa_CondicionesDeVentas.GetCondicionesDeVentaBy(this.Cuenta.IdCuenta,this.TipoComprobanteDestino,ProcessName(),GetTaskName(),IdResponsable);
            /* Fin Silvina */
			if(TableCondicionesDeVentaChanged != null)
				TableCondicionesDeVentaChanged(this, new EventArgs());
			if(this.CondicionDeVenta != null /*&& _state.Equals("STEP")*/ && IsValidCondicionDeVentaForStep(this.CondicionDeVenta.IdCondicionDeVenta))
				this.CondicionDeVenta = new CondicionDeVenta( "NEW", this, this.CondicionDeVenta.IdCondicionDeVenta);
			else
			{
				long cond = ComprobantesRules.Momentos_CondicionDeVenta_Default(this.Momento);
                //German 20110602 - Tarea 0000149
                if (!cond.Equals(long.MinValue))
                {
                    //this.CondicionDeVenta = new CondicionDeVenta("NEW", this, Convert.ToString(cond));
                    if (IsValidCondicionDeVentaForStep(Convert.ToString(cond)))
                        this.CondicionDeVenta = new CondicionDeVenta("NEW", this, Convert.ToString(cond));
                    else
                        if (_tableCondicionesDeVenta.Rows.Count == 1)
                            this.CondicionDeVenta = new CondicionDeVenta("NEW", this, Convert.ToString(_tableCondicionesDeVenta.Rows[0]["IdCondicionDeVenta"]));
                }
                else
                {
                    if (_tableCondicionesDeVenta.Rows.Count == 1)
                        this.CondicionDeVenta = new CondicionDeVenta("NEW", this, Convert.ToString(_tableCondicionesDeVenta.Rows[0]["IdCondicionDeVenta"]));
                }
                //Fin German 20110602 - Tarea 0000149
			}
			if(this.CondicionDeVenta != null && this.CondicionDeVenta.IdCondicionDeVenta != string.Empty)
				if(CondicionesDeVentaChanged != null)
					CondicionesDeVentaChanged(this, new EventArgs());
		}

		private bool IsValidCondicionDeVentaForStep(string IdCondicionDeVenta)
		{
			foreach(DataRow row in _tableCondicionesDeVenta.Rows)
			{
				if(Convert.ToString(row["IdCondicionDeVenta"]).Equals(IdCondicionDeVenta))
					return true;
			}
			return false;
		}

		private void InitEvents()
		{
			this.Items.OnRecalcItems += new ItemsComprobantes.RecalcularItems( this.EscuchoRecalcularItems );
			this.Items.OnRefreshItems += new ItemsComprobantes.RefrescarItems( this.EscuchoRefrescarItems );
			this.Cuenta.OnRecalcularCuenta += new Cuenta.RecalcularCuenta( this.EscuchoRecalcularCuenta );
			this.CondicionDeVenta.IdCondicionDeVentaChanged +=new EventHandler(this.EscuchoRecalcularItems);
			//this.Cuenta.CodigoChanged +=new EventHandler(Cuenta_CodigoChanged);

		}
		
		#endregion

		#region Funciones y Metodos Privados
		
		public void RecalcularItems()
		{
			this.IsDirty = true;
			this.Items.RefrescarImpuestos();
			this.Items.RefrescarBonificaciones();
			this.CallEvents();
		}
		

		private void EscuchoRecalcularCuenta( object sender, System.EventArgs e )
		{
			this.IsDirty = true;
			this.Items.RefrescarImpuestos();
			this.Items.RefrescarBonificaciones();
			this.CallEvents();
			
		}

		private void EscuchoRefrescarCuenta( object sender, System.EventArgs e)
		{
			
			
			if (OnRefrescarComprobante != null)
			{
				OnRefrescarComprobante( this, new System.EventArgs() );
			}
		}

		
		private void EscuchoRecalcularItems( object sender, System.EventArgs e )
		{
			if (OnRecalcularComprobante != null)
			{
				OnRecalcularComprobante( this, new System.EventArgs() );
			}
			
			this.CallEvents();

		}

		private void EscuchoRefrescarItems( object sender, System.EventArgs e)
		{
			if ( OnRefrescarComprobante != null )
			{
				OnRefrescarComprobante( this, new System.EventArgs() );
			}
		}

		private void Refresh()
		{
			this.CondicionDeVenta.Refresh();

		}

		private void CallEvents()
		{
			/*if (TotalNetoChanged != null)
			{
				TotalNetoChanged( this, new System.EventArgs() );
			}
			if (TotalConImpuestosChanged != null)
			{
				TotalConImpuestosChanged( this, new System.EventArgs());
			}
			if (TotalImpuestosChanged != null)
			{
				TotalImpuestosChanged( this, new System.EventArgs());
			}
			if (TotalBrutoChanged != null)
			{
				TotalBrutoChanged( this, new System.EventArgs());
			}
			if (TotalRecargosFinancierosChanged != null)
			{
				TotalRecargosFinancierosChanged( this, new System.EventArgs());
			}
			if (TotalChanged != null)
			{
				TotalChanged( this, new System.EventArgs());
			}
			if (TotalDescuentosChanged != null)
			{
				TotalDescuentosChanged( this, new System.EventArgs());
			}
			if (ImporteCanceladoChanged != null)
			{
				ImporteCanceladoChanged( this, new System.EventArgs());
			}
			if (MascaraChanged != null)
			{
				MascaraChanged( this, new System.EventArgs());
			}*/
			Refresh();
			if (ObjectHasChanged != null)
			{
				ObjectHasChanged( this, new System.EventArgs());
			}
			
			
		}


		
		#endregion

		#region Funciones y Métodos Publicos




		public Hashtable GetORAsociadas()
		{
			return this.Items.GetORAsociadas();
		}

		public string ProcessName()
		{
			return this._processManager.Process.ProcessName;
		}
		public string TaskName() 
		{
			return this._taskName;
		}

		#region Implementacion de IPersistenTask

		/// <summary>
		/// Fuerza la escritura de los datos en memoria al dataset del comprobante para poder ser enviados
		/// a la capa de acceso a datos. s
		/// El dataset del comprobante no se va modificando en tiempo de ejecución mientras la clase adquiere comportamiento. 
		/// Esta accion se debe realizar explicitamente antes de enviar el Flush
		/// </summary>
		public void Commit()
		{		
			this.CommitComprobante();
			this.CommitItems();
			this.CommitStock();
			this.CommitCondicionDeVenta();
			this.CommitVariablesComprobante(IdVariablesAuxiliares);			
			this.CommitProductosAuxiliares();
			this.CommitComprobanteAnteriorListaSucesores();
            /* Silvina 20111212 - Tarea 0000232 */
            if (this._taskName.Equals("Vender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderReserva"))
                CommitReservas("T");
            if (this._processManager.Process.ProcessName.Equals("ProcesoAnularPrevenderReserva"))
                CommitReservas("A");
            /* Fin Silvina 20111212 - Tarea 0000232 */
		}

        /* Silvina 20111212 - Tarea 0000232 */

        private void CommitReservas(string Estado)
        {
            /*if (this._taskName.Equals("Vender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderReserva"))
            {
                _dataComprobantesReservas.Clear();
                tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row = mz.erp.businessrules.tsa_ComprobantesReservasRelacion.GetByPk(IdComprobanteOrigen);
                row.Estado = "T";
                _dataComprobantesReservas.tsa_ComprobantesReservasRelacion.ImportRow(row);
            }
            if (this._processManager.Process.ProcessName.Equals("ProcesoAnularPrevenderReserva"))
            {
                _dataComprobantesReservas.Clear();
                tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row = mz.erp.businessrules.tsa_ComprobantesReservasRelacion.GetByPk(IdComprobanteOrigen);
                row.Estado = "A";
                _dataComprobantesReservas.tsa_ComprobantesReservasRelacion.ImportRow(row);
            }*/
            _dataComprobantesReservas.Clear();
            tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row = mz.erp.businessrules.tsa_ComprobantesReservasRelacion.GetByPk(IdComprobanteOrigen);
            row.Estado = Estado;
            _dataComprobantesReservas.tsa_ComprobantesReservasRelacion.ImportRow(row);
        }

        /* Fin Silvina 20111212 - Tarea 0000232 */
		private void CommitStock()
		{			
			_idDeposito = ComprobantesRules.TareaProceso_GetDeposito(this.ProcessName(), this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Deposito" );
			_idSeccion =  ComprobantesRules.TareaProceso_GetSeccion(this.ProcessName(), this._taskName);//Variables.GetValueString( "Momentos."+this._taskName+".Seccion" );
			mz.erp.businessrules.GenerarMovimientosDeStock _movimientos = new GenerarMovimientosDeStock( _idDeposito, _idSeccion );
			long IdTarea = Workflow.GetIdTakByName(this._taskName);
			long IdProceso = Workflow.GetIdProcessByName(this.ProcessName());
			foreach (mz.erp.businessrules.comprobantes.ItemComprobante _item in this.Items)
			{
				if(_item.AfectaStock)
				{					
					long IdTransicion = Stock.GetTransicion( _item.IdTipoComprobanteOrigen, this.TipoComprobanteDestino, IdTarea, IdProceso);
					_movimientos.Add( IdTransicion, _item.IdProducto, _item.Cantidad );
				}
			}
			foreach (mz.erp.businessrules.comprobantes.ItemComprobante _item in this.Items.ItemsNoVisibles)
			{
				if(_item.AfectaStock)
				{
					long IdTransicion = Stock.GetTransicion( _item.IdTipoComprobanteOrigen, this.TipoComprobanteDestino, IdTarea, IdProceso);
					_movimientos.Add( IdTransicion, _item.IdProducto, _item.Cantidad );
				}
			}
			
			mz.erp.commontypes.data.tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable _table = Stock.GetDataTableStock( _movimientos );
			this.DatasetComprobante.tlg_MovimientosDeStock.Rows.Clear();
			foreach (System.Data.DataRow _row in _table )
			{
				this.DatasetComprobante.tlg_MovimientosDeStock.Rows.Add( _row.ItemArray );
			}

		}

		private void CommitProductosAuxiliares()
		{									
			long IdTarea = Workflow.GetIdTakByName(this._taskName);
			long IdProceso = Workflow.GetIdProcessByName(this.ProcessName());
			if (this.ProcessName() == "ProcesoPrerendirRendir" && this._taskName == "Rendir")
			{
				foreach (mz.erp.businessrules.comprobantes.ItemComprobante _item in this.Items)
				{
					DataRow rowPA = (DataRow) businessrules.tsh_ProductosAuxiliares.GetByPk(_item.IdProducto);
					if (rowPA != null)
					{
						rowPA["Contador"] = _item.ContadorDestino;
						//DatasetComprobante.tsh_ProductosAuxiliares.Addtsh_ProductosAuxiliaresRow((tsa_ComprobantesExDataset.tsh_ProductosAuxiliaresRow) rowPA);
						DatasetComprobante.tsh_ProductosAuxiliares.ImportRow(rowPA);
						
					}
					
					/*
				
							tsa_ComprobantesExDataset.tsa_ComprobantesAutorizacionesRow r = DatasetComprobante.tsa_ComprobantesAutorizaciones.Newtsa_ComprobantesAutorizacionesRow();			
			
			r.IdComprobanteAutorizacion = Util.NewStringId();
			r.IdAutorizacion = this._idAutorizacion;			
			r.IdComprobante = this.IdComprobante;			
			r.IdComprobanteAutorizacion = string.Empty;			
			r.FechaCreacion = DateTime.Now;
			r.IdConexionCreacion = Security.IdConexion;
			//r.UltimaModificacion = null;			
			r.IdReservado = 0;
			r.RowId = Guid.Empty;
			r.IdSucursal = Security.IdSucursal;
			r.IdEmpresa = Security.IdEmpresa;			
			DatasetComprobante.tsa_ComprobantesAutorizaciones.Addtsa_ComprobantesAutorizacionesRow(r);*/
				}
			}			
		}

		public mz.erp.commontypes.SentenciasReplicacion GetSentenceReplication()
		{
			return _replication;
		}
		private mz.erp.commontypes.SentenciasReplicacion GenerateReplication()
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

        /* Silvina 20120104 - Tarea 0000232 */
        private string idpreFac = string.Empty;
        /* Fin Silvina 20120104 - Tarea 0000232 */

		public void PutExtraData( ProcessCollectionData _processCollectionData )
		{
             //German 20111207 - Tarea 0000232
            foreach (TaskCollectionData _collectionTask in _processCollectionData)
            {
                if (_collectionTask.TaskName.Equals("Prevender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderReserva"))
                {
                    foreach (System.Data.DataSet dataventas in _collectionTask)
                    {
                        if (dataventas.DataSetName.Equals("tsa_ComprobantesExDataset"))
                        {
                            if (dataventas.Tables["tsa_comprobantes"].Rows.Count == 1)
                            {
                                string IdComprobantePrefacturaReserva = Convert.ToString(dataventas.Tables["tsa_comprobantes"].Rows[0]["IdComprobante"]);
                                _dataComprobantesReservas.Clear();
                                tsa_ComprobantesReservasRelacionDataset.tsa_ComprobantesReservasRelacionRow row = _dataComprobantesReservas.tsa_ComprobantesReservasRelacion.Newtsa_ComprobantesReservasRelacionRow();
                                mz.erp.businessrules.tsa_ComprobantesReservasRelacion.SetRowDefaultValues(row);
                                row.IdComprobantePrefacturaReserva = IdComprobantePrefacturaReserva;
                                row.Estado = "P";
                                _dataComprobantesReservas.tsa_ComprobantesReservasRelacion.Addtsa_ComprobantesReservasRelacionRow(row);
                                /* Silvina 20120104 - Tarea 0000232 */
                                idpreFac = dataventas.Tables["tsa_comprobantes"].Rows[0]["IdComprobante"].ToString();
                                /* Fin Silvina 20120104 - Tarea 0000232 */
                            }
                              
                        }
                    }
                }
            }
            //Fin German 20111207 - Tarea 0000232

		}
		public ArrayList GetDataList()
		{
			ArrayList array = new ArrayList();
			array.Add( (DataSet) this.DatasetComprobante);
			return array;
		}
		public TaskCollectionData GetData()
		{
			TaskCollectionData data = new TaskCollectionData();
			data.TaskName = this.GetTaskName();
			data.Add( this.DatasetComprobante );
			return data;
		}

		/// <summary>
		/// Envia el dataset e información adicional a la capa de acceso a datos para ejecutar la grabación de datos
		/// en el RDBM.
		/// </summary>
		/// 

		st_OrdenReparacionDataset dataOrdenesReparacion = new st_OrdenReparacionDataset();
		tsa_ComprobantesAutorizacionesDataset dataComprobantesAutorizaciones = new tsa_ComprobantesAutorizacionesDataset();
		tsa_ComprobantesDetAuxiliaresDataset _dataComprobantesDetAuxiliares = new tsa_ComprobantesDetAuxiliaresDataset();
        //German 20111207 - Tarea 0000232
        tsa_ComprobantesReservasRelacionDataset _dataComprobantesReservas = new tsa_ComprobantesReservasRelacionDataset();
        //Fin German 20111207 - Tarea 0000232

		string _prefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas");
		string _prefacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas DV");
		string _facturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas");
		string _facturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Facturas DV");
		string _anulacionDePrefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Anulación de Prefacturas");
		string _anulacionDePrefacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Anulación de Prefacturas DV");
				
		private void CommitOrdenReparacion()
		{
			dataOrdenesReparacion = new st_OrdenReparacionDataset();
			foreach(long IdOrdenreparacion in this._ordenesReparacion)
			{
				DataRow r = mz.erp.businessrules.st_OrdenReparacion.GetByPk(Convert.ToString(IdOrdenreparacion));
				dataOrdenesReparacion.st_OrdenReparacion.ImportRow(r);
			}
			ArrayList compPrevios = mz.erp.systemframework.Util.Parse(_prefacturas, ",");
			compPrevios.AddRange(mz.erp.systemframework.Util.Parse(_prefacturasDV, ","));
			bool ok = (this.TipoComprobanteOrigen != null && compPrevios.Contains(this.TipoComprobanteOrigen));
			if(ok)
			{
				ArrayList comp = mz.erp.systemframework.Util.Parse(_facturas, ",");
				comp.AddRange(mz.erp.systemframework.Util.Parse(_facturasDV, ","));
				comp.AddRange(mz.erp.systemframework.Util.Parse(_anulacionDePrefacturas, ","));
				comp.AddRange(mz.erp.systemframework.Util.Parse(_anulacionDePrefacturasDV, ","));

                //German 20100826 - Tarea 814
                comp.AddRange(mz.erp.systemframework.Util.Parse(_prefacturas, ","));
                comp.AddRange(mz.erp.systemframework.Util.Parse(_prefacturasDV, ","));
                //FIN German 20100826 - Tarea 814

                ok = ok && ( (this.TipoComprobanteDestino != null &&  comp.Contains(this.TipoComprobanteDestino)));
				if(ok)
				{
					dataOrdenesReparacion = new st_OrdenReparacionDataset();
					//DataSet dataComprobanteOrdenReparacion = mz.erp.businessrules.tsa_ComprobantesOrdenReparacion.GetList(this.IdComprobanteOrigen, long.MinValue);
					DataSet dataOR = Workflow.GetCaminoComprobantesBottonUp(IdComprobanteOrigen,"OR");
					foreach(DataRow row in dataOR.Tables[0].Rows)
					{
						string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);
						if(IdTipoDeComprobante.Equals("OR"))
						{
							DataRow r = mz.erp.businessrules.st_OrdenReparacion.GetByPk(Convert.ToString(row["IdComprobante"]));
							dataOrdenesReparacion.st_OrdenReparacion.ImportRow(r);
						}
	

					}
					

				}
			}
			

		}
		
        //German 20100826 - Tarea 814
		private void UpdateOrdenReparacion(string IdTransaction)
		{
			
			ArrayList compPreviosDV = mz.erp.systemframework.Util.Parse(_prefacturasDV, ",");
			ArrayList Facturas = mz.erp.systemframework.Util.Parse(_facturas, ",");
			Facturas.AddRange(mz.erp.systemframework.Util.Parse(_facturasDV, ","));
			ArrayList AnulacionDePrefacturas = mz.erp.systemframework.Util.Parse(_anulacionDePrefacturas, ",");
			AnulacionDePrefacturas.AddRange(mz.erp.systemframework.Util.Parse(_anulacionDePrefacturasDV, ","));
			ArrayList Prefacturas = mz.erp.systemframework.Util.Parse(_prefacturas, ",");
			Prefacturas.AddRange(mz.erp.systemframework.Util.Parse(_prefacturasDV, ","));
			foreach(DataRow row in dataOrdenesReparacion.Tables[0].Rows)
			{
				if(Facturas.Contains(this.TipoComprobanteDestino))
				{
					if(!compPreviosDV.Contains(this.TipoComprobanteOrigen))
						row["NumeroFactura"] = this.DatasetComprobante.tsa_Comprobantes.Rows[0]["Numero"];
					row["FechaFactura"] = this.DatasetComprobante.tsa_Comprobantes.Rows[0]["Fecha"];
					string EstadoOREN = Variables.GetValueString("Momentos." + this._taskName + "." + this._processManager.Process.ProcessName+".EquipoNuevo.EstadoOrdenDeReparacion.Default");
					string EstadoOR = Variables.GetValueString("Momentos." + this._taskName + "." + this._processManager.Process.ProcessName+".EstadoOrdenDeReparacion.Default");
					
					if(Convert.ToBoolean(row["EsEquipoNuevo"]))
					{
						if(EstadoOREN != null && EstadoOREN != string.Empty)
							row["IdEstadoOrdenReparacion"] = EstadoOREN;
					}
					else
						if(EstadoOR != null && EstadoOR != string.Empty)
						row["IdEstadoOrdenReparacion"] = EstadoOR;
                    row["IdComprobanteFactura"] = this.IdComprobante;
				}
				if(AnulacionDePrefacturas.Contains(this.TipoComprobanteDestino))
				{
					/*Agregar que se actualica el flag*/
					/*Se pregunta pues si en procesos de edcion de prefacturas se genera una anulacion y por ende sucede q si
					 * se edita una prefactura se puede volver a prefacturar la OR. MAAAAAALLLLLL
					 * */
                    if (!_processManager.Process.ProcessName.Equals("ProcesoPrevenderPrevender")
                        && !_processManager.Process.ProcessName.Equals("ProcesoPreprestarPreprestar"))
                    {
                        row["FechaPrefactura"] = System.DBNull.Value;
                        row["IdComprobantePrefactura"] = System.DBNull.Value;
                    }
				}
				if(Prefacturas.Contains(this.TipoComprobanteDestino))
				{
					row["FechaPrefactura"] = DateTime.Now;
                    row["IdComprobantePrefactura"] = this.IdComprobante;
				}
			}
			mz.erp.dataaccess.st_OrdenReparacion.Update(dataOrdenesReparacion.st_OrdenReparacion, IdTransaction);

            
		}
        //Fin German 20100826 - Tarea 814
		
	
		private void CommitComprobantesAutorizaciones()
		{						
			tsa_ComprobantesExDataset.tsa_ComprobantesAutorizacionesRow r = DatasetComprobante.tsa_ComprobantesAutorizaciones.Newtsa_ComprobantesAutorizacionesRow();			
			
			r.IdComprobanteAutorizacion = Util.NewStringId();
			r.IdAutorizacion = this._idAutorizacion;			
			r.IdComprobante = this.IdComprobante;			
			r.IdComprobanteAutorizacion = string.Empty;			
			r.FechaCreacion = DateTime.Now;
			r.IdConexionCreacion = Security.IdConexion;
			//r.UltimaModificacion = null;			
			r.IdReservado = 0;
			r.RowId = Guid.Empty;
			r.IdSucursal = Security.IdSucursal;
			r.IdEmpresa = Security.IdEmpresa;			
			DatasetComprobante.tsa_ComprobantesAutorizaciones.Addtsa_ComprobantesAutorizacionesRow(r);
			
		}
		
		public void Flush(string IdTransaction)
		{
			if(OnTaskBeforeFlush != null)
				OnTaskBeforeFlush(this, new EventArgs());
			tsa_ComprobantesExDataset dataEx = this.DatasetComprobante;
			string IdVariable = string.Empty;
			if (this.ActualizaNumeracion)
			{
				IdVariable = UpdateNumero(dataEx,IdTransaction);
			}
			else 
			{				
				if(SugiereNumeracion(_tipoComprobanteDestino))
				{
					IdVariable = UpdateNumeroSugerido(dataEx,IdTransaction);
				}
				/*
				else
					IdVariable = dataEx.tsa_Comprobantes.Rows[0]["Numero"].ToString();
				*/
			}
			_replication = GenerateReplication();
			if(_allowToValidateFlujosComprobantes)
				ValidarComprobantesRelacionados(IdTransaction);
            /* Silvina 20120104 - Tarea 0000232 */
            if (_taskName.Equals("Vender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderReserva"))
            {
                string nroFac = dataEx.tsa_Comprobantes.Rows[0]["Numero"].ToString();
                tsa_Comprobantes.UpdateNroDeComprobante(IdTransaction, idpreFac, nroFac);
            }
            /* Fin Silvina 20120104 - Tarea 0000232 */
			mz.erp.dataaccess.tsa_Comprobantes.Update( dataEx.Tables["tsa_Comprobantes"], IdTransaction, _replication);	
			this.IdComprobante = (string)dataEx.tsa_Comprobantes.Rows[0]["IdComprobante"];		
			//German 20090804
            /* Silvina 20111230 - Tarea 0000245 */
            /* if(IdVariable != null && IdVariable != string.Empty && !_numeracionPorPerfil)
				mz.erp.dataaccess.sy_Variables.Update(IdVariable,(string) dataEx.Tables["tsa_Comprobantes"].Rows[0]["Numero"], IdTransaction);				
			else
				if(IdVariable != null && IdVariable != string.Empty && _numeracionPorPerfil)
				mz.erp.dataaccess.sy_VariablesPerfiles.Update(IdVariable,(string) dataEx.Tables["tsa_Comprobantes"].Rows[0]["Numero"], Security.IdPerfil,IdTransaction);
            */
			if(!string.IsNullOrEmpty(IdVariable))
                if (_numeracionPorUsuario && !string.IsNullOrEmpty(_idUsuarioNumeracion))
                    mz.erp.dataaccess.sy_VariablesUsuarios.Update (IdVariable,(string) dataEx.Tables["tsa_Comprobantes"].Rows[0]["Numero"],_idUsuarioNumeracion,IdTransaction);
                else
                    if (_numeracionPorPerfil && _idPerfilNumeracion > 0)
                        mz.erp.dataaccess.sy_VariablesPerfiles.Update(IdVariable,(string) dataEx.Tables["tsa_Comprobantes"].Rows[0]["Numero"], _idPerfilNumeracion,IdTransaction);
                    else 
				        mz.erp.dataaccess.sy_Variables.Update(IdVariable,(string) dataEx.Tables["tsa_Comprobantes"].Rows[0]["Numero"], IdTransaction);				
            /* Fin Silvina 20111230 - Tarea 0000245 */
            /*
			if(IdVariable != null && IdVariable != string.Empty)
				mz.erp.dataaccess.sy_Variables.Update(IdVariable,(string) dataEx.Tables["tsa_Comprobantes"].Rows[0]["Numero"],IdTransaction);				
			*/
			//Fin German 20090804
			mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update( dataEx.Tables["tsa_ComprobanteDetalleDeuda"],IdTransaction, _replication); 				
			mz.erp.dataaccess.tsa_ComprobantesDet.Update( dataEx.Tables["tsa_ComprobantesDet"], IdTransaction, _replication);							
			
			mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.Update( dataEx.Tables["tsa_ComprobantesDetAuxiliares"], IdTransaction);							
			mz.erp.dataaccess.tlg_MovimientosDeStock.Update( dataEx.Tables[ "tlg_MovimientosDeStock"] , IdTransaction, _replication );
			mz.erp.dataaccess.tsa_ComprobanteDetalleImpuestos.Update( dataEx.Tables["tsa_ComprobanteDetalleImpuestos"], IdTransaction,_replication);
			mz.erp.dataaccess.tsa_ComprobanteValoresVarAux.Update( dataEx.Tables["tsa_ComprobanteValoresVarAux"], IdTransaction, _replication);
			mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.Update( dataEx.Tables["tsa_ComprobanteDetalleDescripcionAdicional"], IdTransaction, _replication );
			mz.erp.dataaccess.tsa_ComprobantesRelacionOrigenDestino.Update( dataEx.Tables["tsa_ComprobantesRelacionOrigenDestino"], IdTransaction, _replication, IdComprobante);
			mz.erp.dataaccess.tsa_ComprobantesOrdenReparacion.Update(	dataEx.Tables["tsa_ComprobantesOrdenReparacion"], IdTransaction);
			mz.erp.dataaccess.tsa_ComprobanteDetalleOrdenReparacion.Update(dataEx.Tables["tsa_ComprobanteDetalleOrdenReparacion"], IdTransaction);
			mz.erp.dataaccess.tsh_ProductosAuxiliares.Update(dataEx.Tables["tsh_ProductosAuxiliares"], IdTransaction);
			GuardarSaldoCuentaCorriente.GetInstance().FlushSaldoCuentaCorriente(this.GetProcessManagerParent().Process, IdTransaction, _replication);

			if (_idAutorizacion != "")
				mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.Update(dataEx.Tables["tsa_ComprobantesAutorizaciones"], IdTransaction);

			UpdateOrdenReparacion(IdTransaction);

			foreach( System.Data.DataRow _row in dataEx.Tables["tlg_MovimientosDeStock"].Rows )
			{
				mz.erp.commontypes.data.tsa_ComprobantesExDataset.tsa_ComprobantesMovimientosDeStockRow _rowMovimiento = dataEx.tsa_ComprobantesMovimientosDeStock.Newtsa_ComprobantesMovimientosDeStockRow();
				_rowMovimiento["IdComprobante"] = this.IdComprobante;
				_rowMovimiento["IdMovimientoDeStock"] = _row["IdMovimientoDeStock"];
				dataEx.tsa_ComprobantesMovimientosDeStock.Addtsa_ComprobantesMovimientosDeStockRow( _rowMovimiento );
			}
			mz.erp.dataaccess.tsa_ComprobantesMovimientosDeStock.Update( dataEx.Tables["tsa_ComprobantesMovimientosDeStock"], IdTransaction );
			
			UpdateComprobanteAnteriorListaSucesores(IdTransaction);
            //German 20111207 - Tarea 0000232
            if (this._taskName.Equals("Vender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderReserva"))
            {
                _dataComprobantesReservas.tsa_ComprobantesReservasRelacion.Rows[0][_dataComprobantesReservas.tsa_ComprobantesReservasRelacion.IdComprobanteFacturaColumn] = this.IdComprobante;
                mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.Update(_dataComprobantesReservas.tsa_ComprobantesReservasRelacion, IdTransaction);
            }
            //Fin German 20111207 - Tarea 0000232

            /* Silvina 20111212 - Tarea 0000232 */
            if ((this._taskName.Equals("Vender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderReserva")) ||
                 (this._taskName.Equals("AnularPrevender") && this._processManager.Process.ProcessName.Equals("ProcesoAnularPrevenderReserva")))
            {
                _dataComprobantesReservas.tsa_ComprobantesReservasRelacion.Rows[0][_dataComprobantesReservas.tsa_ComprobantesReservasRelacion.IdComprobanteFacturaPrefacturaReservaColumn] = this.IdComprobante;
                mz.erp.dataaccess.tsa_ComprobantesReservasRelacion.Update(_dataComprobantesReservas.tsa_ComprobantesReservasRelacion, IdTransaction);
            }
            /* Fin Silvina 20111212 - Tarea 0000232 */          


			if(OnTaskAfterFlush != null)
				OnTaskAfterFlush(this,new EventArgs());
		}


		private void CommitComprobanteAnteriorListaSucesores()
		{
			if(_allowActualizarPredecesores && _actualizaPredecesoresOnCommit)
			{
				_dataComprobantesDetAuxiliares = new tsa_ComprobantesDetAuxiliaresDataset();
				foreach(DataRow rowROR in this.DatasetComprobante.tsa_ComprobantesRelacionOrigenDestino.Rows)
				{
				
					string IdComprobanteOrigen = Convert.ToString(rowROR["IdComprobanteOrigen"]);
					long  OrdinalOrigen = Convert.ToInt64(rowROR["IdOrdinalOrigen"]);
					long  Ordinal = Convert.ToInt64(rowROR["IdOrdinalDestino"]);
					DataRow row = mz.erp.businessrules.tsa_ComprobantesDetAuxiliares.GetByPk( IdComprobanteOrigen, OrdinalOrigen);
					if(row != null)
					{
						row["IdTiposComprobantesSucesores"] = Convert.ToString(row["IdTiposComprobantesSucesores"]) + "," + this.TipoComprobanteDestino;
						row["OrdinalesSucesores"] = Convert.ToString(row["OrdinalesSucesores"]) + "," + Convert.ToString(Ordinal);
						string IdComprobantesPredecesores = Convert.ToString(row["IdComprobantesPredecesores"]);
						string OrdinalesPredecesores = Convert.ToString(row["OrdinalesPredecesores"]);
						ArrayList ListaIdCompPredecesores =  mz.erp.systemframework.Util.Parse(IdComprobantesPredecesores, ",");
						ArrayList ListaOrdinalesPredecesores =  mz.erp.systemframework.Util.Parse(OrdinalesPredecesores, ",");
						for(int i = 0; i < ListaIdCompPredecesores.Count; i++)
						{
							string IdComprobantePredecesor = Convert.ToString(ListaIdCompPredecesores[i]);
							if(IdComprobantePredecesor != null && IdComprobantePredecesor != string.Empty)
							{
								long OrdinalPredecesor = Convert.ToInt64(ListaOrdinalesPredecesores[i]);
								DataRow rowAux = mz.erp.businessrules.tsa_ComprobantesDetAuxiliares.GetByPk( IdComprobantePredecesor, OrdinalPredecesor);
								if(rowAux != null)
								{

									rowAux["IdTiposComprobantesSucesores"] = Convert.ToString(rowAux["IdTiposComprobantesSucesores"]) + "," + this.TipoComprobanteDestino;
									rowAux["OrdinalesSucesores"] = Convert.ToString(rowAux["OrdinalesSucesores"]) + "," + Convert.ToString(Ordinal);
									_dataComprobantesDetAuxiliares.tsa_ComprobantesDetAuxiliares.ImportRow(rowAux);
							
								}
							}
					
						}

						_dataComprobantesDetAuxiliares.tsa_ComprobantesDetAuxiliares.ImportRow(row);
					}

				
				}
			}
		}

		private void UpdateComprobanteAnteriorListaSucesores(string IdTransaction)
		{
			if(_allowActualizarPredecesores && _actualizaPredecesoresOnCommit)
			{
			
				foreach(DataRow row in _dataComprobantesDetAuxiliares.tsa_ComprobantesDetAuxiliares.Rows)
				{
					row["IdComprobantesSucesores"] = Convert.ToString(row["IdComprobantesSucesores"]) + "," + this.IdComprobante;
				
				}			
				mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.Update( _dataComprobantesDetAuxiliares.Tables["tsa_ComprobantesDetAuxiliares"], IdTransaction);							
			}
			else
			{
				if(_allowActualizarPredecesores && !_actualizaPredecesoresOnCommit)
				{
					_dataComprobantesDetAuxiliares = new tsa_ComprobantesDetAuxiliaresDataset();
					foreach(DataRow rowROR in this.DatasetComprobante.tsa_ComprobantesRelacionOrigenDestino.Rows)
					{
				
						string IdComprobanteOrigen = Convert.ToString(rowROR["IdComprobanteOrigen"]);
						long  OrdinalOrigen = Convert.ToInt64(rowROR["IdOrdinalOrigen"]);
						long  Ordinal = Convert.ToInt64(rowROR["IdOrdinalDestino"]);
						DataRow row = mz.erp.businessrules.tsa_ComprobantesDetAuxiliares.GetByPk( IdComprobanteOrigen, OrdinalOrigen, IdTransaction);
						if(row != null)
						{
							row["IdTiposComprobantesSucesores"] = Convert.ToString(row["IdTiposComprobantesSucesores"]) + "," + this.TipoComprobanteDestino;
							row["OrdinalesSucesores"] = Convert.ToString(row["OrdinalesSucesores"]) + "," + Convert.ToString(Ordinal);
							row["IdComprobantesSucesores"] = Convert.ToString(row["IdComprobantesSucesores"]) + "," + this.IdComprobante;
							string IdComprobantesPredecesores = Convert.ToString(row["IdComprobantesPredecesores"]);
							string OrdinalesPredecesores = Convert.ToString(row["OrdinalesPredecesores"]);
							ArrayList ListaIdCompPredecesores =  mz.erp.systemframework.Util.Parse(IdComprobantesPredecesores, ",");
							ArrayList ListaOrdinalesPredecesores =  mz.erp.systemframework.Util.Parse(OrdinalesPredecesores, ",");
							for(int i = 0; i < ListaIdCompPredecesores.Count; i++)
							{
								string IdComprobantePredecesor = Convert.ToString(ListaIdCompPredecesores[i]);
								if(IdComprobantePredecesor != null && IdComprobantePredecesor != string.Empty)
								{
									long OrdinalPredecesor = Convert.ToInt64(ListaOrdinalesPredecesores[i]);
									DataRow rowAux = mz.erp.businessrules.tsa_ComprobantesDetAuxiliares.GetByPk( IdComprobantePredecesor, OrdinalPredecesor, IdTransaction);
									if(rowAux != null)
									{

										rowAux["IdTiposComprobantesSucesores"] = Convert.ToString(rowAux["IdTiposComprobantesSucesores"]) + "," + this.TipoComprobanteDestino;
										rowAux["OrdinalesSucesores"] = Convert.ToString(rowAux["OrdinalesSucesores"]) + "," + Convert.ToString(Ordinal);
										rowAux["IdComprobantesSucesores"] = Convert.ToString(rowAux["IdComprobantesSucesores"]) + "," + this.IdComprobante;
										_dataComprobantesDetAuxiliares.tsa_ComprobantesDetAuxiliares.ImportRow(rowAux);
							
									}
								}
					
							}

							_dataComprobantesDetAuxiliares.tsa_ComprobantesDetAuxiliares.ImportRow(row);
						}

				
					}
					mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.Update( _dataComprobantesDetAuxiliares.Tables["tsa_ComprobantesDetAuxiliares"], IdTransaction);							
				}
			}

		}


		private void ValidarComprobantesRelacionados(string IdTransaction)
		{
			string IdTipoDeComprobanteDestino = this._tipoComprobanteDestino;
			IdTipoDeComprobanteDestino = IdTipoDeComprobanteDestino + "," + _listaTiposDeComprobantesValidarFlush;
			foreach(DataRow row in this.DatasetComprobante.tsa_ComprobantesRelacionOrigenDestino.Rows)
			{
				string IdComprobanteOrigen = Convert.ToString(row["IdComprobanteOrigen"]);
				if(IdComprobanteOrigen != null && IdComprobanteOrigen != string.Empty)
				{
					long OrdinalOrigen = Convert.ToInt64(row["IdOrdinalOrigen"]);
					DataTable table = mz.erp.businessrules.tsa_ComprobantesRelacionOrigenDestino.ValidarFlujo(IdTransaction,IdComprobanteOrigen, OrdinalOrigen, IdTipoDeComprobanteDestino);
					if(table.Rows.Count > 0)
						throw new Exception("Ya existe un flujo entre el comprobante previo y el comprobante actual");
				}
			}	
		}

		private string UpdateNumero(tsa_ComprobantesExDataset data, string IdTransaction)
		{
			foreach(System.Data.DataRow row1 in data.tsa_Comprobantes.Rows)
			{
				if (true) 
				{
                    /* Silvina 20111230 - Tarea 0000245 */
                    string numeracion = string.Empty;
                    if (SugiereNumeracion(row1["IdTipoDeComprobante"].ToString()))
                    {                        
                        sy_PerfilesUsuariosEmpresasDataset perfiles;
                        _idUsuarioNumeracion = sy_Usuarios.GetUsuario(_idResponsable);
                        if (_numeracionPorUsuario)
                        {
                            _idUsuarioNumeracion = sy_Usuarios.GetUsuario(_idResponsable);
                            numeracion = Variables.GetValueStringUsuariosWithoutCache("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"].ToString(), _idUsuarioNumeracion, IdTransaction);
                        }
                        if (numeracion.Equals(string.Empty) && _numeracionPorPerfil)
                        {
                            perfiles = sy_PerfilesUsuariosEmpresas.GetList(_idUsuarioNumeracion, Security.IdEmpresa);
                            _idUsuarioNumeracion = string.Empty;
                            foreach (sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow r in perfiles.sy_PerfilesUsuariosEmpresas.Rows)
                            {
                                numeracion = Variables.GetValueStringPerfilesWithoutCache("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"].ToString(), r.IdPerfil, IdTransaction);
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
                            numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"].ToString(), IdTransaction);
                        }
                    }
                    else // No sugiere numeracion para ese tipo de comprobante
                        numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"].ToString(), IdTransaction);
                    if (numeracion != string.Empty)
                        this._numero = Util.StcZero(numeracion, 8);             
                    

					//string numeracion = Variables.GetValueStringWithoutCache("Comprobantes.Numeracion." + (string)row1["IdTipoDeComprobante"],IdTransaction);
					//string Numero = Util.StcZero(numeracion,8);
					row1["Numero"]= Numero;
					//sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"],IdTransaction);
					//this.Numero = Numero;
                    return "Comprobantes.Numeracion." + row1["IdTipoDeComprobante"].ToString(); //row.IdVariable;
                    
                    /* Fin Silvina 20111230 - Tarea 0000245 */
				}
				
			}

			return null;
		}

		private string UpdateNumeroSugerido(tsa_ComprobantesExDataset data, string IdTransaction)
		{
			foreach(System.Data.DataRow row1 in data.tsa_Comprobantes.Rows)
			{
				if (true) 
				{
					row1["Numero"]= this.Numero;
					//German 20090804
					return "Comprobantes.Numeracion." + row1["IdTipoDeComprobante"];
					/*
					sy_VariablesDataset.sy_VariablesRow row = mz.erp.businessrules.sy_Variables.GetByPk("Comprobantes.Numeracion." + row1["IdTipoDeComprobante"],IdTransaction);
					return row.IdVariable;
					*/
					//Fin German 20090804
				}
				
			}

			return null;
		}
	


		
		#endregion

		public void Commit(ComprobanteDeVenta source, string Numero)
		{
			DatasetComprobante = new mz.erp.commontypes.data.tsa_ComprobantesExDataset();
			tsa_ComprobantesExDataset.tsa_ComprobantesRow row = DatasetComprobante.tsa_Comprobantes.Newtsa_ComprobantesRow();

			DateTime now = mz.erp.businessrules.Sistema.DateTime.Now;
			DateTime fc = source.FechaComprobante;
			DateTime fecha = new DateTime(fc.Year, fc.Month, fc.Day, now.Hour,now.Minute, now.Second);
			row.Fecha = fecha;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdComprobante = source.IdComprobante;
			row.IdCuenta = source.Cuenta.IdCuenta;
			row.IdResponsable = source.IdResponsable;								

			row.IdTipoDeComprobante = source.TipoComprobanteDestino;
			//row.Numero = "";//Util.NewStringId();
			row.IdCotizacionCierre = ComprobantesRules.Contabilidad_CotizacionReferencia;
			row.Total = 0;
			row.IdCondicionDeVenta = source.CondicionDeVenta.IdCondicionDeVenta;

			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
		
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
		
			row.IdInstanciaCaja = string.Empty;
			row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdReservado = 0;
		
			//this.Numero = row.Numero;
			row.Numero = Numero; //ORL. Le paso al row el valor de comprobante.Numero para que no reviente en los items si es nulo.
			
			//cargo los datos adicionles del cliente
			row.Cliente = source.InfoCliente;
			row.Domicilio = source.InfoDomicilio;
			row.TipoDocumento = source.InfoTipoDocumento;
			row.Documento = source.InfoDocumento;
			row.Observaciones = "TRANSPORTE";
			row.Aux1 = source.InfoAux1;
			row.Aux1 = source.InfoAux2;
			row.Aux1 = source.InfoAux3;

			DatasetComprobante.tsa_Comprobantes.Addtsa_ComprobantesRow( row );
		}
		

		private void CommitComprobante()
		{
			DatasetComprobante = new mz.erp.commontypes.data.tsa_ComprobantesExDataset();
			tsa_ComprobantesExDataset.tsa_ComprobantesRow row = DatasetComprobante.tsa_Comprobantes.Newtsa_ComprobantesRow();

			DateTime now = mz.erp.businessrules.Sistema.DateTime.Now;
			DateTime fc = this.FechaComprobante;
			DateTime fecha = new DateTime(fc.Year, fc.Month, fc.Day, now.Hour,now.Minute, now.Second);
			row.Fecha = fecha;
            /* Silvina 20111212 - Tarea 0000232 */
            row.FechaVencimientoReserva = FechaReserva;
            /* Fin Silvina 20111212 - Tarea 0000232 */
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdComprobante = this.IdComprobante;
			row.IdCuenta = this.Cuenta.IdCuenta;
			row.IdResponsable = this._idResponsable;								

			row.IdTipoDeComprobante = this.TipoComprobanteDestino;
			//row.Numero = "";//Util.NewStringId();
			row.IdCotizacionCierre = ComprobantesRules.Contabilidad_CotizacionReferencia;
			row.Total = this.Total;
			row.IdCondicionDeVenta = this.CondicionDeVenta.IdCondicionDeVenta;

			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
		
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
		
			row.IdInstanciaCaja = string.Empty;
			row.IdMonedaCierre = ComprobantesRules.Contabilidad_MonedaReferencia;
			row.IdReservado = 0;
		
			//this.Numero = row.Numero;
			row.Numero = this.Numero; //ORL. Le paso al row el valor de comprobante.Numero para que no reviente en los items si es nulo.
			
			//cargo los datos adicionles del cliente
			row.Cliente = this._infoCliente;
			row.Domicilio = this._infoDomicilio;
			row.TipoDocumento = this._infoTipoDocumento;
			row.Documento = this._infoDocumento;
			row.Observaciones = this.Observaciones;//this.InfoObservaciones;
			row.Aux1 = this._infoaux1;
			row.Aux1 = this._infoaux2;
			row.Aux1 = this._infoaux3;

			row.IdCotizacionCierreDolarOficial = tfi_CotizacionesMonedas.GetCoeficienteCotizacion( "2", this._idMonedaReferencia, this._idFuenteDeCambioReferencia).IdCotizacion;

			DatasetComprobante.tsa_Comprobantes.Addtsa_ComprobantesRow( row );
			foreach(long IdOrdenreparacion in this._ordenesReparacion)
			{
				tsa_ComprobantesExDataset.tsa_ComprobantesOrdenReparacionRow rowCO = DatasetComprobante.tsa_ComprobantesOrdenReparacion.Newtsa_ComprobantesOrdenReparacionRow();
				rowCO.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				rowCO.IdComprobante = this.IdComprobante;
				rowCO.IdOrdenReparacion = Convert.ToInt64(IdOrdenreparacion);
				rowCO.IdConexionCreacion = Security.IdConexion;
				rowCO.IdConexionUltimaModificacion = Security.IdConexion;
				rowCO.IdEmpresa = Security.IdEmpresa;
				rowCO.IdSucursal = Security.IdSucursal;
				rowCO.IdReservado = 0;
				DatasetComprobante.tsa_ComprobantesOrdenReparacion.Addtsa_ComprobantesOrdenReparacionRow(rowCO);		
			}
			
			if (this.VariablesDeUsuario.Count > 0)
			{
				VariableAuxiliar var1 = (VariableAuxiliar) this.VariablesDeUsuario[0];
				row.CampoAuxiliar1 = var1.Valor;
			}
			
			if (this.VariablesDeUsuario.Count > 1)
			{
				VariableAuxiliar var2 = (VariableAuxiliar) this.VariablesDeUsuario[1];
				row.CampoAuxiliar2 = var2.Valor;
			}

			if (this.VariablesDeUsuario.Count > 2)
			{
				VariableAuxiliar var3 = (VariableAuxiliar) this.VariablesDeUsuario[2];
				row.CampoAuxiliar3 = var3.Valor;
			}
			if (this.VariablesDeUsuario.Count > 3)
			{
				VariableAuxiliar var4 = (VariableAuxiliar) this.VariablesDeUsuario[3];
				row.CampoAuxiliar4 = var4.Valor;
			}
			if (this.VariablesDeUsuario.Count > 4)
			{
				VariableAuxiliar var5 = (VariableAuxiliar) this.VariablesDeUsuario[4];
				row.CampoAuxiliar5 = var5.Valor;
			}

			CommitOrdenReparacion();
			if (_idAutorizacion != "")
				CommitComprobantesAutorizaciones();
		}
		
		private void CommitItems()
		{
			this.Items.Commit();
		}
		private void CommitCondicionDeVenta()
		{
			this.CondicionDeVenta.Commit(this.GetProcessManagerParent().Process);
			
		}
		private void CommitVariablesComprobante(string IdVariablesAuxiliares)
		{
			this.VariablesComprobante.Commit(IdVariablesAuxiliares);
		}
		

		public override void SetDirty( bool value )
		{
			this.IsDirty = value;

		}


		#region Valores, pendiente refactoriazacion u ordenamiento
		public System.Collections.ArrayList GetCotizaciones()
		{
			ArrayList _cotizaciones = new ArrayList();
			mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizaciones( _cotizaciones, this._idMonedaCierre );
			return _cotizaciones;
		}
		/*
		public System.Data.DataSet GetDataSetValores()
		{
			if (this._comprobanteDePago != null)
			{
				return this._comprobanteDePago.Valores.DataValoresEx;
			}
			else
			{
				return null;
			}
		}
		
		public void PutDataSetValores(System.Data.DataSet data, Valor valor )
		{
			this._comprobanteDePago.RefreshValores( data, valor);	
			this._importeCancelado = this._comprobanteDePago.Total;
			this.CalcularRecargosFinancieros();
			this.IsDirty = true;
			this.Items.RefrescarImpuestos();
			this.Items.RefrescarBonificaciones();
		
			this.CallEvents();
		}
		*/

		public System.Data.DataTable GetFormasDePagosEspecificas()
		{
			mz.erp.commontypes.data.tfi_FormasDePagoExDataset datafdp = new tfi_FormasDePagoExDataset();
			System.Data.DataTable table = new DataTable();
			System.Data.DataRowCollection rowsCol = tfi_FormasDePagoEx.GetFormasDePagosGenerales(datafdp) ;
			foreach (System.Data.DataRow row in rowsCol)
			{
				table.Rows.Add( row );
			}
			return table;
		}
		/*
		public ArrayList GetArrayValores()
		{
			return this._comprobanteDePago.Valores.MisValores;
		}
		*/
		/*
		public bool IsValidObligatoryPayment()
		{
			if (ComprobantesRules.ValidarComprobanteDePago( this.Momento ))
			{
				return this._comprobanteDePago.Total >= this.CondicionDeVenta.GetObligatoryPayment();
			}
			else
				
				return true;
		}
		*/
		public bool IsValidNumeration()
		{
			if (this.AllowEditNumeration)
			{  
				if ( Numero.EndsWith("-") || (Numero == string.Empty) || ExistsNumeration()|| (Numero.Length!=15)) 
				{
					return false;
				}
			}
			return true;
		}
		
		private string _messageErrorValidateItemsPertenecenAJerarquias = string.Empty;
		public bool IsValidItemsPertenecenAJerarquias()
		{
			_messageErrorValidateItemsPertenecenAJerarquias = string.Empty;
			bool result = true;
			if(this.AllowToValidateItemsPertenecenAJerarquias)
			{
				string Jerarquias = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Emision.Validar.ItemsPertencenAJerarquias.JerarquiasValidas");
				ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquias, ",");
				foreach(ItemComprobante item in this.Items)
				{
					bool ok = false;
					foreach(string j in aux)
					{
						if(mz.erp.businessrules.tsh_AgrupProductos.GetList(item.IdProducto, j).Tables[0].Rows.Count > 0)
						{
							ok = true;
						}
					}
					if(!ok)
					{
						result = false;
						_messageErrorValidateItemsPertenecenAJerarquias =  _messageErrorValidateItemsPertenecenAJerarquias + "El Artículo " + item.Codigo + " NO ES VÁLIDO para este tipo de comprobante. " ;
					}
						
				}
			}
			return result;
		}

		public bool PercibeIB
		{
			get
			{
				
				return !this.Cuenta.ExcluyePercepcionIB && this.Cuenta.CategoriaImpositiva != "CF";
			}
		}


		private string _messageErrorValidateItemsNoPertenecenAJerarquias = string.Empty;
		public bool IsValidItemsNoPertenecenAJerarquias()
		{
			_messageErrorValidateItemsNoPertenecenAJerarquias = string.Empty;
			bool result = true;
			if(this.AllowToValidateItemsNoPertenecenAJerarquias && this.PercibeIB)
			{
				string Jerarquias = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Emision.Validar.ItemsNoPertencenAJerarquias.JerarquiasNoValidas");
				ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquias, ",");
				foreach(ItemComprobante item in this.Items)
				{
					
					foreach(string j in aux)
					{
						if(mz.erp.businessrules.tsh_AgrupProductos.GetList(item.IdProducto, j).Tables[0].Rows.Count > 0)
						{
							result = false;
							_messageErrorValidateItemsNoPertenecenAJerarquias =  _messageErrorValidateItemsNoPertenecenAJerarquias + "El Artículo " + item.Codigo + " Es un BIEN DE USO. " ;
						}
					}
						
				}
			}
			return result;
		}


		public bool IsValidItems()
		{
			if (this.AllowToValidateItems)
			{
				if (this.Items.Count == 0 ) 
				{
					return false;
				}
			}
			return true;
		}

		public bool IsValidItemsConMonto0()
		{
			if (this.AllowToValidateItemsConMonto0)
			{
				return !this.Items.ExistenItemsConMonto0;
			}
			return true;
		}

		public bool IsValidDiasLimiteDeCredito()
		{
			if(this.AllowToValidateDiasLimiteDeCredito)
			{
				return ValidarDiasLimiteDeCredito();
			}
			return true;
		}

		public bool IsValidLimiteDeCredito()
		{
			if(this.AllowToValidateLimiteDeCredito)
			{
				return ValidarLimiteDeCredito();
			}
			return true;
		}

		private bool ValidarDiasLimiteDeCredito()
		{
			if(!(this.CondicionDeVenta.IdCondicionDeVenta.Equals(string.Empty)) && !(this.CondicionDeVenta.IdCondicionDeVenta == null))
			{
				if(this.CondicionDeVenta.EsCuentaCorriente)
				{
					/*
					DataRow rowTC = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this.TipoComprobanteDestino);
					int tipoCtaCte = Convert.ToInt32(rowTC["TipoCtaCte"]);
					*/
					mz.erp.businessrules.CuentaCorriente cc = new mz.erp.businessrules.CuentaCorriente();
					string Comprobantes = string.Empty;
					ArrayList ListaComprobantes = new ArrayList();
					cc.GetDetalleCuentaCorrienteVentas(this.Cuenta.IdCuenta, long.MinValue);
					Comprobantes = Variables.GetValueString("Momentos.CuentaCorriente.ProcesoCuentaCorrienteCliente.ListaTiposDeComprobantes.Facturas");
					ListaComprobantes = mz.erp.systemframework.Util.Parse(Comprobantes,",");
					Comprobantes = Variables.GetValueString("Momentos.CuentaCorriente.ProcesoCuentaCorrienteClienteDV.ListaTiposDeComprobantes.Facturas");
					ListaComprobantes.AddRange(mz.erp.systemframework.Util.Parse(Comprobantes,","));
                    //German 20101119 - Tarea 943
                    //if (this.Cuenta.DiasLimiteDeCredito <= 0 && ((DetalleCuotas)this.CondicionDeVenta.DetalleCondicionDeVentaList[0]).DiasVencimiento > 0)
                    //    return false;
                    //Fin German 20101119 - Tarea 943
					/*
					if(tipoCtaCte == 1)
					{
						Comprobantes = Variables.GetValueString("Momentos.CuentaCorriente.ProcesoCuentaCorrienteCliente.ListaTiposDeComprobantes.Facturas");
						ListaComprobantes = mz.erp.systemframework.Util.Parse(Comprobantes,",");

					}
					else
					{
						if(tipoCtaCte == 2)
						{
							Comprobantes = Variables.GetValueString("Momentos.CuentaCorriente.ProcesoCuentaCorrienteClienteDV.ListaTiposDeComprobantes.Facturas");
							ListaComprobantes = mz.erp.systemframework.Util.Parse(Comprobantes,",");
						}
					}
					*/
					foreach (ItemCuentaCorriente icc in cc)
					{
						if (ListaComprobantes.Contains(icc.IdTipoDeComprobante))
						{
							if(icc.Saldo != 0)
							{
								DateTime fechaVencCorta = mz.erp.systemframework.Util.GetStartDay( icc.FechaVencimiento);
								DateTime fechaActualCorta = mz.erp.systemframework.Util.GetStartDay( mz.erp.businessrules.Sistema.DateTime.Now);
								TimeSpan diff = fechaActualCorta.Subtract(fechaVencCorta);
								//Fecha vencimiento actual mas grande que la fecha de Vencimiento. Facrura Vencida por diff.Days dias
								if(diff.Days > 0)
								{
									decimal diasLim = this.Cuenta.DiasLimiteDeCredito;
									//Los dias de vecimiento son mayores que el limite de dias permitido para el cliente
									if(diasLim < diff.Days)
									{
										return false;
									}
								}

							}

						}
					}


					
					


				}
			}
			return true;
		}

		private bool ValidarLimiteDeCredito()
		{
			if(!(this.CondicionDeVenta.IdCondicionDeVenta.Equals(string.Empty)) && !(this.CondicionDeVenta.IdCondicionDeVenta == null))
			{
				if(this.CondicionDeVenta.EsCuentaCorriente)
				{
					DataRow rowTC = mz.erp.businessrules.tsy_TiposDeComprobantes.GetByPk(this.TipoComprobanteDestino);
					int tipoCtaCte = Convert.ToInt32(rowTC["TipoCtaCte"]);
					decimal saldoCCFormat = 0;
					decimal saldoCCDVFormat = 0;
					decimal saldoCteCte = 0;
					decimal limiteDeCredito = saldoCCFormat = decimal.Round(this.Cuenta.LimiteDeCredito,2);
					saldoCCFormat = decimal.Round(this.Cuenta.SaldoCtaCte,2);
					saldoCCDVFormat = decimal.Round(this.Cuenta.SaldoCtaCteDV,2);
					saldoCteCte = saldoCCFormat + saldoCCDVFormat;
					if(limiteDeCredito < this.Total + saldoCteCte)
						return false;
					/*
					if(tipoCtaCte == 1)
					{
						saldoCCFormat = decimal.Round(this.Cuenta.SaldoCtaCte,2);
						if(limiteDeCredito < this.Total + saldoCCFormat)
							return false;
					}
					if(tipoCtaCte == 2)
					{
						saldoCCFormat = decimal.Round(this.Cuenta.SaldoCtaCteDV,2);
						if(limiteDeCredito < this.Total + saldoCCFormat)
							return false;
					}
					*/
				}
			}
			return true;
		}

		public bool IsValidCondVenta()
		{
			if (this.AllowToValidateCondVenta)
			{
				if(this.CondicionDeVenta.IdCondicionDeVenta.Equals(string.Empty) || this.CondicionDeVenta.IdCondicionDeVenta == null)
					return false;
			
                
			}
			return true;

		}

		public bool HayCondicionesDeVentas()
		{
			if (this.AllowToValidateCondVenta)
			{
				if(this._tableCondicionesDeVenta == null || this._tableCondicionesDeVenta.Rows.Count == 0)
					return false;
			

			}
			return true;

		}

        /* Silvina 20111212 - Tarea 0000232 */
        private bool IsValidCondVentaReserva()
        {
            if (this._processManager.Process.ProcessName.Equals("ProcesoPrevenderReserva"))
                return !this.CondicionDeVenta.EsCuentaCorriente;         
            return true;
        }
        /* Fin Silvina 20111212 - Tarea 0000232 */

		/*
		private bool AnularComprobanteDePago()
		{
			bool ok = false;
			ok = this._comprobanteDePago.Valores.MisValores.Count > 0 & this._comprobanteDePago.Anular;

			return ok;
		}
		*/
		/*
		public bool IsValidCurrenPayment()
		{
			bool resultado = true;
			if(this._state.ToUpper().Equals("STEP"))
			{
			
				_detalleCuentaCorriente = Factory.GetDetalleCuentaCorriente(this._comprobanteDePago);
				_cancelacionComprobanteDePago= new CancelacionComprobanteDePago();
				//Si se desimpuat, es pque estaba impuatdoa un comprobante de pago
				//por ende hay que desimputarlo y luego anularlo
				
				_detalleCuentaCorriente.Desimputar();
				if(AnularComprobanteDePago())
				{
					_cancelacionComprobanteDePago.Anular(_detalleCuentaCorriente.IdComprobante);
					_cancelacionComprobanteDePago.Commit();
				}
				
				this._importeCancelado = this._comprobanteDePago.Total;
				//
				//Como es un step, le paso los valores del comprobante anterior
				//ComprobanteDePago cdp = Factory.GetComprobanteDePago();
				//cdp.Valores = this._comprobanteDePago.Valores;
				//cdp.Recalcular();
			
				//this._comprobanteDePago = cdp;

				//Faltan validaciones
				//resultado = _detalleCuentaCorriente.IsValid() && _cancelacionComprobanteDePago.Isvalid()

			}
			
			
			
			if (ComprobantesRules.ValidarComprobanteDePago( this.Momento ))
			{
				this._comprobanteDePago.IdInstanciaCaja = ComprobantesRules.InstanciaCajaAbiertaDefault( this.IdResponsable );
				this._comprobanteDePago.IdCuenta = this.Cuenta.IdCuenta;
				this._comprobanteDePago.Numero = "";
				this._comprobanteDePago.FechaComprobante= mz.erp.businessrules.Sistema.DateTime.Now;
				this._comprobanteDePago.TipoComprobanteDestino = ComprobantesRules.ComprobanteDePagoDefault(this.Momento);
				this._comprobanteDePago.Signo = ComprobantesRules.GetSignoComprobante( ComprobantesRules.ComprobanteDePagoDefault(this.Momento) );
				this._comprobanteDePago.IdResponsable = this.IdResponsable;
				this._comprobanteDePago.Saldo = this._comprobanteDePago.Total;
				this._comprobanteDePago.CondicionDeVenta = new CondicionDeVenta("NEW",this._comprobanteDePago,Variables.GetValueString("Comprobantes.FormaDePago.Contado"));
				this._comprobanteDePago.CuentaCorriente = Factory.GetCuentaCorriente( this.Cuenta.IdCuenta, DateTime.MinValue, DateTime.MaxValue);
				
				//Modificaciones German
				
				if(ComprobantesRules.Comprobantes_CondicionDeVenta_Permite_Imputar(this.CondicionDeVenta.IdCondicionDeVenta))
				{
					this._comprobanteDePago.ComprobanteDeVenta = this;
					DetalleCuentaCorriente dccComprobanteDeVenta = Factory.GetDetalleCuentaCorriente(this);
					//DetalleCuentaCorriente dccComprobanteDePago = Factory.GetDetalleCuentaCorriente(this._comprobanteDePago);
					//dccComprobanteDePago.Pago = this.Total;
					dccComprobanteDeVenta.Pago = this.Total;
					//this._comprobanteDePago.CuentaCorriente.Detalle.Add(dccComprobanteDePago);
					this._comprobanteDePago.CuentaCorriente.Detalle.Add(dccComprobanteDeVenta);

					this._comprobanteDePago.CuentaCorriente.TotalImputado = this.Total;

					//Hasta aca
				}
				return this._comprobanteDePago.IsValid() && resultado;
			}
			else
			{
				return true;
			}
		}
		*/
		# endregion

		public void Anular(string Numero, string TipoComprobanteDestino) 
		{			
			
			this.TipoComprobanteDestino = TipoComprobanteDestino;
			this.Numero = Numero;
			this.ActualizaNumeracion = false;
			this.Validar = false;
			this.Commit();

			string IdTransaction = dataaccess.PoolTransaction.BeginTransaction();
			
			try
			{
				this.Flush(IdTransaction);							
				dataaccess.PoolTransaction.Commit(IdTransaction);
			}
			catch(Exception e)
			{			
				dataaccess.PoolTransaction.RollBack(IdTransaction);
			}
			//this.Flush();
		}

        //Cristian Tarea 0000023 20110217
        public ArrayList isValidarStock()
        {
            ArrayList productosSinStock = new ArrayList();

            if (_allowToValidateErrorStock )
            {
                foreach (ItemComprobante item in this.Items)
                {
                    /*decimal stock = Stock.GetStock(item.IdProducto, this._idDeposito, this._idSeccion,
                                                   _estadoStockAValidar, Security.IdSucursal, Security.IdEmpresa); */
                    if (item.CantidadUnidadDestino > item.CantStock)
                    {
                         productosSinStock.Add((item));
                         Console.WriteLine("Producto -" + item.Codigo);
                         Console.WriteLine("------------------------------------");
                         Console.WriteLine("Stock -"+ item.CantStock);
                         Console.WriteLine("unidades para llevar -" + item.CantidadUnidadDestino);
                         Console.WriteLine("*****************************************************");
                         Console.WriteLine("*****************************************************");
                    }
                }
            }
            return productosSinStock;
        }
        //Fin Cristian

		/*
		 * This method Deprecated for the rest of the life.
		 * 
		*/
		/*
		private void CalcularRecargosFinancieros()
		{
			
			if (this.TotalConImpuestosSinRecargos > 0)
			{
				System.Collections.Hashtable table = tfi_TDCompTesoreriasMonedasRecargos.GetRecargosTDCompTesoreria();
				System.Collections.ArrayList arrayValores = this._comprobanteDePago.Valores.MisValores;
				decimal _totalrecargo = 0;
				decimal _totalpago = 0;
				foreach (Valor unvalor in arrayValores)
				{
					if (table.Contains( unvalor.IdTDCompTesoreria+' ' +unvalor.IdMoneda ))
					{
						decimal porcentaje = Convert.ToDecimal(table[ unvalor.IdTDCompTesoreria+' ' +unvalor.IdMoneda ]);
						_totalrecargo = _totalrecargo + (unvalor.MontoSinRecargos * porcentaje / 100);
					}
					
				}
					
				decimal _porcentajerepresentacion = _totalrecargo * 100/  this.TotalConImpuestosSinRecargos ;
				_porcentualrecargosFinancieros =  _porcentajerepresentacion;
			}
			else
				_porcentualrecargosFinancieros = 0;
			

		}
		*/


		#endregion

		#region Propiedades de Estado
		
		public bool IsDirty
		{
			set
			{
				this.Items.IsDirty=value;
			}
			get
			{
				return this.Items.IsDirty;
			}
			
		}

		/*
		 * Este metodod deberia modificarse si en algun momento se permite facturar la mismo momento
		 * OR comunes y OR por EN
		 * 
		 * **/
		private void reasignarResponsable()
		{
			
			bool esEquipoNuevo = false;
			if(this.IdResponsable != null && this.IdResponsable != string.Empty)
			{
				sy_UsuariosDataset data=mz.erp.businessrules.sy_Usuarios.GetListByIdPersona(this.IdResponsable);
				sy_UsuariosDataset.sy_UsuariosRow _ruser =(sy_UsuariosDataset.sy_UsuariosRow)data.Tables[0].Rows[0];
				long Equipo = (long)_ruser["Equipo"];
			
				foreach(ItemComprobante item in this.Items)
				{	//Si no viene de un comprobante anterior
				
					if(item.IdTipoComprobanteOrigen != null && item.IdTipoComprobanteOrigen.Equals("OR"))
					{
						string IdOR = item.IdComprobanteOrigen;
						DataRow rowOR = mz.erp.businessrules.st_OrdenReparacion.GetByPk(IdOR);
						if(rowOR != null)
						{
							if(!rowOR.IsNull("EsEquipoNuevo"))
								esEquipoNuevo = Convert.ToBoolean(rowOR["EsEquipoNuevo"]);
						}
					}
					if (item.IdComprobanteOrigen==null || 
						(item.IdTipoComprobanteOrigen.Equals("OR")&& !_habilitaUsuariaAltaOR) ||
						(item.IdTipoComprobanteOrigen.Equals("OR") && esEquipoNuevo))
					{

						item.Equipo= Equipo;
						item.IdResponsableOrigen=this.IdResponsable;
					}
				
				
				}
				if(esEquipoNuevo)
				{
					foreach(ItemComprobante item in this.Items.ItemsNoVisibles)
					{	
						item.Equipo= Equipo;
						item.IdResponsableOrigen=this.IdResponsable;
					}
				}
			}
			
		}
		
		public bool IsValid()
		{
			_errores.Clear();
			bool isValid = true;
			if ((this.Cuenta.IdCuenta == null) || (this.Cuenta.IdCuenta == string.Empty))
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Cuenta","IdCuenta","El cliente/la cuenta no puede ser nulo"));
			}
			string proceso = this._processManager.Process.ProcessName;
			string tarea = this.GetTaskName();			
			bool PermitirEmitirConClienteDePaso = Variables.GetValueBool(proceso, tarea, "PermitirClienteDePaso",true);
			if (! PermitirEmitirConClienteDePaso )
			{
				string clienteDePaso = Variables.GetValueString("Cuenta.ClienteDePaso.Default");
				if (this.Cuenta.Codigo == clienteDePaso)
				{
					isValid = false;
					_errores.Add( new ItemDatasetError( "Cuenta","Cuenta","El cliente no es correcto para la operación que desea realizar."));					
				}
			}
            //Tarea Validar cambio de nombre del cliente de Paso
            if (proceso.Equals("ProcesoPresupuestar") || proceso.Equals("ProcesoCopiaDePresupuesto"))
            {
                string clienteDePaso = Variables.GetValueString("Cuenta.ClienteDePaso.Default");
                tsa_CuentasDataset.tsa_CuentasRow rowCuenta = mz.erp.businessrules.tsa_Cuentas.GetByCodigo(clienteDePaso);
                if (rowCuenta != null)
                {
                    String nombreClientePasoDB = rowCuenta.Nombre;
                    if(nombreClientePasoDB.Equals(this.Cuenta.Nombre))
                    {
                        isValid = false;
                        _errores.Add(new ItemDatasetError("Cuenta", "Cuenta", "Debe cambiar el nombre del cliente de paso o consumidor final."));	
                    }

                }
            }
            //Fin Tarea Validar cambio de nombre del cliente de Paso
			/*if((this._processManager.Process.ProcessName.Equals("ProcesoPrestar")) || (this._processManager.Process.ProcessName.Equals("ProcesoPreprestarPrestar")) 
				|| (this._processManager.Process.ProcessName.Equals("ProcesoPreprestar") ) || (this._processManager.Process.ProcessName.Equals("ProcesoRemitirPreprestar") )
				|| (this._processManager.Process.ProcessName.Equals("ProcesoRecargarPreprestar") ))
			{Str
				string clienteDePaso = Variables.GetValueString("Cuenta.ClienteDePaso.Default");
				if (this.Cuenta.Codigo == clienteDePaso)
				{
					isValid = false;
					_errores.Add( new ItemDatasetError( "Cuenta","Cuenta","El cliente no es correcto para la operación que desea realizar."));					
				}
			}*/
            /* Silvina 20110803 - Tarea 0000060 */
			if(this._processManager.Process.ProcessName.Equals("ProcesoVenderDevolver")
               || this._processManager.Process.ProcessName.Equals("ProcesoVenderDevolverManual"))
            /* Fin Silvina 20110803 - Tarea 0000060 */
			{
				PermitirEmitirConClienteDePaso = Variables.GetValueBool(proceso, tarea, "PermitirClienteDePaso");
				if (! PermitirEmitirConClienteDePaso )
				{
					string variable = "Momentos." + tarea + "." + proceso + "." + "Cuenta.Default";
					string CodigoCuenta = Variables.GetValueString(variable);
					if (this.Cuenta.Codigo == CodigoCuenta)
					{
						isValid = false;
						_errores.Add( new ItemDatasetError( "Cuenta","IdCuenta","Cliente incorrecto"));					
					}

				}
			}
			if ((this.IdResponsable == null) || (this.IdResponsable == string.Empty))
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Responsable","IdResponsable","El responsable de emisión no puede ser nulo"));
			}
			if(!HayCondicionesDeVentas())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Condiciones de Venta","IdCondicionDeVenta","No se definieron Condiciones de Ventas para este Comprobante"));
			}
			if(!IsValidCondVenta())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Condicion de Venta","IdCondicionDeVenta","La condición de venta no puede ser nula"));

			}
			if (this.Items.Count == 0 && this._taskName != "AnularVenta")
				//Esta validación habría que sacarla luego de la implementación en MZ para que todos los comprobants de venta 
				//empiecen a usar IsValidItems. Agregar las variables necesarias. Oscar y German. Oct'06
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Items","Items","No ha seleccionado ningun item"));
			}
			if(!IsValidFechaComprobante())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Fecha de Comprobante","Fecha de Comprobante","La fecha seleccionada no es correcta. No puede ser mayor al dia de la fecha"));
			}

			/*if (!(this.IsValidObligatoryPayment()))
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante De Pago","Pago","El valor ingresado como pago es inferior a lo requerido para la condicion de venta seleccionada"));
			}
			if (!(this.IsValidCurrenPayment()))
			{
				isValid = false;
				foreach (ItemDatasetError unError in this._comprobanteDePago.Errores)
				{
					_errores.Add( new ItemDatasetError( unError.Tabla, unError.Campo, unError.Mensaje ));
				}
			}*/
			if (!(this.IsValidNumeration()))
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Numeración","La numeración del comprobante no es válida"));
			}
			if (!(this.IsValidItems()))
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Items","Debe seleccionar al menos un item"));
			}
			if(!this.IsValidDocumento())
			{
				isValid = false;				
				_errores.Add( new ItemDatasetError( "Cliente","Documento","Debe cargar el documento del Cliente."));
			}
			if(!this.IsValidDNIForImporte())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","DNI","Debe cargar el DNI del Cliente. Es obligatorio debido al importe del comprobante que se esta emitiendo"));
			}

			if(!this.IsValidTipoDocumentoForImporte())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","TipoDocumento","Debe cargar el tipo de documento del Cliente. Es obligatorio debido al importe del comprobante que se esta emitiendo"));
			}

			if(!IsValidPrecioParaEquipoNuevo())
			{
				isValid = false;
			}
			if(!IsValidItemsPertenecenAJerarquias())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Articulos",_messageErrorValidateItemsPertenecenAJerarquias));
			}

			if(!IsValidItemsNoPertenecenAJerarquias())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Articulos",_messageErrorValidateItemsNoPertenecenAJerarquias));
			}
			
			if(!IsValidDescuentos())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Articulos","No se puede realizar el descuento seleccionado"));
			}
			if(!IsValidMaximoDescuentoMenorBonificaciones())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Articulos","El Descuento Por Condición De Venta provoca que el precio del Producto sea Menor que el permitido"));
			}

			if (this.Total == 0)
			{
				bool PermitirComprobanteTotalCero = Variables.GetValueBool(proceso, tarea, "PermitirComprobanteTotalCero",true);
				if (! PermitirComprobanteTotalCero )
				{
					isValid = false;
					_errores.Add( new ItemDatasetError( "Comprobante","Importe total","No se permite la emisión del comprobante con importe total en cero."));
				}
			}
			// ---- Matias - 200907407 - Custom tarea 215.
			if(!IsValidItemsConMonto0())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Items",this.Items.ItemsConMonto0));
			}

			// ---- Matias.

			if(proceso.Equals("ProcesoVenderManual"))
			{
				if (_validaCambioDeFecha )
				{
					DateTime fechaIni = mz.erp.businessrules.Sistema.DateTime.Now;
					fechaIni = fechaIni.AddDays(_cantidadDeDias * (-1));
					if (FechaComprobante.Date < fechaIni.Date)
					{
						isValid = false;

						string error = "La fecha no puede anterior a " + fechaIni.ToString();
						_errores.Add( new ItemDatasetError( "Fecha","Fecha",error));					
					}

				}
			}
			//German 20090824
			if(!IsValidLimiteDeCredito())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Límite de Crédito", _mensajeErrorLimiteDeCredito));
			}
			//Fin German 20090824		
			//German 20090825
			if(!IsValidDiasLimiteDeCredito())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Dias de Crédito", _mensajeErrorDiasLimiteDeCredito));
			}
			//Fin German 20090825

            //Cristian Tarea 0000023 20110217
            ArrayList  productosSinStock = this.isValidarStock();
            if(productosSinStock.Count > 0)
            {
                isValid = false;
                foreach (ItemComprobante item in productosSinStock)
                {
                    _errores.Add(new ItemDatasetError("Comprobante", "Cantidad de productos", String.Format(_mensajeErrorCantidadDisponible,item.Codigo)));
                }
                
            }
            //Fin Cristian

			if(!IsValidTiposDeProductos())
			{
				isValid = false;
				_errores.Add( new ItemDatasetError( "Comprobante","Tipos de Productos", _mensajeErrorTiposDeProductos));
			}

            /* Silvina 20111212 - Tarea 0000232 */
            if (!IsValidCondVentaReserva())
            {
                isValid = false;
                _errores.Add(new ItemDatasetError("Condicion de Venta", "Dias de Vencimiento", "La condición de venta no puede ser Cuenta Corriente"));
            }
            /* Fin Silvina 20111212 - Tarea 0000232 */

            //German 20120208 - Tarea 0000276
            if (!IsValidBonificacion())
            {
                isValid = false;
                _errores.Add(new ItemDatasetError("Bonificaciones", "Bonificaciones", _mensajeErrorBonificaciones));
            }
            //German 20120208 - Tarea 0000276
            //German 20120416 - Tarea 0000247
            if (!IsValidVariableObraAcopio())
            {
                isValid = false;
                _errores.Add(new ItemDatasetError("Acopios", "Obra", "Debe ingresar la obra"));
            }
            //German 20120416 - Tarea 0000247

			this._isValid = isValid;
			return isValid;
			
		}

        //German 20120416 - Tarea 0000247
        private bool IsValidVariableObraAcopio()
        {
            if (_processManager.Process.ProcessName.Equals("ProcesoPrevenderAcopio")
                || _processManager.Process.ProcessName.Equals("ProcesoPreprestarAcopio")
                
                )
            {
                VariableAuxiliar varA = this.VariablesComprobante.Search("22");
                if (varA.Valor == null || varA.Valor.Trim().Equals(string.Empty))
                    return false;
            }
            return true;
        }
        //German 20120416 - Tarea 0000247


		private bool IsValidTiposDeProductos()
		{
			bool validaTiposDeProductos = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Emision.Validar.TiposDeProductos",false);
			string tiposProductos = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Emision.TiposDeProductosPermitidos");
			ArrayList tipos = mz.erp.systemframework.Util.Parse(tiposProductos, ",");
			if (validaTiposDeProductos)
			{
				foreach (ItemComprobante it in Items)
				{
					if (!tipos.Contains(it.IdTipoProducto))
						return false;
				}
			}
			return true;
		}

		private bool IsValidPrecioParaEquipoNuevo()
		{
			bool mustValidate = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Emision.Validar.Total");
			if(mustValidate)
			{
				string prefacturas = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas");
				string prefacturasDV = Variables.GetValueString("Comprobantes.TiposDeComprobantes.Prefacturas DV");
				ArrayList compPrevios = mz.erp.systemframework.Util.Parse(prefacturas, ",");
				compPrevios.AddRange(mz.erp.systemframework.Util.Parse(prefacturasDV, ","));
				if(compPrevios.Contains(this.TipoComprobanteDestino))
				{
					DataSet data = Workflow.GetPreviousTasksOfProcess(_processManager.Process.MainTask.IdTask, _processManager.Process.IdProcess);
					if(data.Tables[0].Rows.Count > 0)
					{
						string TareaPrevia = Convert.ToString(data.Tables[0].Rows[0]["Descripcion"]);
						if(TareaPrevia.Equals("ArmarEquipoNuevo"))
						{
							if(_MACOR > 0)
							{
								Producto prod;
								decimal PrecioFinal = 0;
								decimal PrecioDeVentaNeto = 0;
								decimal errorPermitido = Variables.GetValueDecimal("Sistema.EquiposNuevos.MargenPrecioPermitido");
								errorPermitido = errorPermitido.Equals(decimal.MinValue)?0:errorPermitido;
								foreach(ItemComprobante item in this.Items.ItemsNoVisibles)
								{
									/*German 20090325*/
									prod = new Producto(item.IdProducto, string.Empty, true, false);
									/*Fin German 20090325*/
									prod.MAC = _MACOR;
									PrecioDeVentaNeto = prod.PrecioDeVentaNeto;
									prod.PrecioLista = PrecioDeVentaNeto;
									PrecioFinal += prod.PrecioDeListaConImpuestosMonedaReferencia;
								}
								decimal margenDeError = PrecioFinal * errorPermitido /100;
								decimal PrecioPermitido = PrecioFinal + margenDeError;
								if(PrecioPermitido < this.TotalConImpuestosSinRecargos)
								{
									_errores.Add( new ItemDatasetError( "Equipos Nuevos","Total","El total del Equipo Nuevo supera el Máximo estimado"));
									return false;
								}
								return true;
							}
							/*
							else
							{
								_errores.Add( new ItemDatasetError( "Equipos Nuevos","MAC","No se ha especificado el MAC aplicado a los articulos que pertencen al Equipo Nuevo"));
								return false;
							}
							*/
						}
					}
				}
			}
			return true;
			
		}

		private bool IsValidMaximoDescuentoMenorBonificaciones()
		{
			bool ok = true;
			if(_allowToValidateMaximoDescuentoItemMenorBonificaciones)
			{
				foreach(ItemComprobante item in this.Items)
				{
					if(item.PrecioDeVentaNetoMinimo > item.Precio)
					{
						ok = false;
					}
				}
			}
			return ok;
		}
		private bool IsValidDocumento() 
		{
			if(AllowToValidateDocumento)
			{				
				//verificar que si el cliente tiene definido el tipo de documento como CUIT que el número no sea vacío
				if (ExigeDocumento(Cuenta.TipoDocumento) && Cuenta.DocumentoVacio())
					
				//if (ExigeDocumento(Cuenta.TipoDocumento) && this.Cuenta.DomiciliosAsociado
				{				
					return false;
				}
				return true;
			}
			else
				return true;			
		}

		private bool ExigeDocumento(string TipoDocumento) 
		{
			string tipos = "CUIT,CUIL";
			ArrayList arrTipos = Util.Parse(tipos,",");
			return arrTipos.Contains(TipoDocumento);
		}
		
		private bool IsValidDNIForImporte()
		{
			if(AllowToValidateDNIForImporte)
			{
				decimal montoLimite = Variables.GetValueDecimal("Momentos.Default.ImporteLimiteSinDNICuenta");
				if(this.Total > montoLimite)
				{
					return !(this.Cuenta.Documento.CompareTo(string.Empty)==0);
				
				}
				else return true;	
			
			}
			else return true;
		}
		private bool IsValidTipoDocumentoForImporte()
		{
			if(AllowToValidateTipoDocumentoForImporte)
			{
				decimal montoLimite = Variables.GetValueDecimal("Momentos.Default.ImporteLimiteSinDNICuenta");
				if(this.Total > montoLimite)
				{
					return !(this.Cuenta.TipoDocumento.CompareTo("NO/I")==0);
				
				}
				else return true;	
			
			}
			else return true;
		}
		private bool IsValidFechaComprobante()
		{
			return this.FechaComprobante <= mz.erp.systemframework.Util.GetEndDay(mz.erp.businessrules.Sistema.DateTime.Now);
		}
		private bool IsValidDescuentos()
		{
			bool isvalid = true; 
			bool validar = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Validar.Descuentos");
			if (validar)
			{
				foreach(ItemComprobante item in this.Items)
				{
					decimal precio = Math.Round(item.PrecioDeVentaBruto,2);
					decimal precioMinimo = 0;
					DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
					if(rowP != null)
					{
						decimal precioNeto = Convert.ToDecimal(rowP["PrecioDeVentaNeto"]);
						string IdCotizacion = Convert.ToString(rowP["IdCotizacionCierrePrecioDeVentaNeto"]);
						Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
						precioMinimo = Math.Round(precioNeto * cot.Valor,2);
					}
					decimal result = precio - precioMinimo;
					if (result < Convert.ToDecimal(-0.05)) 
					{
						isvalid = false;
					}
				}
			}
				

			return isvalid;
			
			
			/*
			 * 				ItemsComprobantes items = _items;
				string comodines = Variables.GetValueString(this._processParent.Process.ProcessName, this._processParent.Process.MainTask.KeyTask, "Emision.Editar.Items.ListaItemComodin");
				bool autorizaItemComodines = Variables.GetValueBool(this._processParent.Process.ProcessName, this._processParent.Process.MainTask.KeyTask, "RequiereAutorizarItemComodin");
				ArrayList comodinesList = mz.erp.systemframework.Util.Parse(comodines, ",");
				foreach (ItemComprobante item in _items) 
				{				
					if(!ExcluyeFlujoComprobanteOrigenDestino(item))
					{
						if(!comodinesList.Contains(item.IdProducto) || 
							(comodinesList.Contains(item.IdProducto) && autorizaItemComodines ))
						{
							decimal precio = Math.Round(item.PrecioDeVentaBruto,2);
							decimal precioMinimo = 0;
							DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
							if(rowP != null)
							{
								decimal precioNeto = Convert.ToDecimal(rowP["PrecioDeVentaNeto"]);
								string IdCotizacion = Convert.ToString(rowP["IdCotizacionCierrePrecioDeVentaNeto"]);
								Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
								precioMinimo = Math.Round(precioNeto * cot.Valor,2);
							}
							decimal result = precio - precioMinimo;
							if (result < Convert.ToDecimal(-0.05)) 
							{
								return false;
							}
						}
					}
				}	

			 * */
		}

        //German 20120208 - Tarea 0000276
        private bool IsValidBonificacion()
        {
            bool isvalid = true;
            _mensajeErrorBonificaciones = "Los siguientes productos tienen descuentos mayores a las bonificaciones permitidas: ";
            bool validar = Variables.GetValueBool("Productos.Validar.Bonificaciones");
            if(!validar)
                validar = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Validar.Bonificaciones");
            
            if (validar)
            {
                /*
                Hashtable productosCant = new Hashtable();
                foreach (ItemComprobante item in this.Items)
                {
                    if (!productosCant.ContainsKey(item.IdProducto))
                        productosCant.Add(item.IdProducto, item.CantidadUnidadOrigen);
                    else
                        productosCant[item.IdProducto] = Convert.ToDecimal(productosCant[item.IdProducto]) + item.CantidadUnidadOrigen;
                }
                 * */

                
                foreach (ItemComprobante item in this.Items)
                {
                    decimal precio = Math.Round(item.PrecioDeVentaBruto, 2);
                    decimal precioMinimo = 0;
                    DataRow rowP = mz.erp.businessrules.tsh_Productos.GetByPk(item.IdProducto);
                    DataRow rowLP = mz.erp.businessrules.tsh_ProductosListasDePrecios.GetByPk(item.IdProducto, item.IdListaDePrecios);
                    if (rowP != null && rowLP != null)
                    {
                        //decimal precioNeto = Convert.ToDecimal(rowP["PrecioDeVentaBruto"]);
                        decimal precioNeto = Convert.ToDecimal(rowLP["PrecioDeVentaBruto"]);
                        string IdCotizacion = Convert.ToString(rowP["IdCotizacionCierrePrecioDeVentaNeto"]);
                        

                        Cotizacion cot = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCotizacion(IdCotizacion);
                        precioMinimo = Math.Round(precioNeto * cot.Valor, 2); // Hay que restarle la bonificacion;


                        
                        string IdBonificacion = Convert.ToString(rowP["IdBonificacion"]);
                        if (IdBonificacion != null && IdBonificacion != string.Empty)
                        {
                            Bonificacion BonificacionProducto = new Bonificacion();
                            BonificacionProducto.IdBonificacion = IdBonificacion;
                            BonificacionProducto.CargarDetalle();

                            precioMinimo = precioMinimo + precioMinimo * BonificacionProducto.BonificacionAAplicar(/*Convert.ToDecimal(productosCant[item.IdProducto]))*/  item.CantidadUnidadOrigen) / 100;
                        }
                    }
                    decimal result = precio - precioMinimo;
                    if (result < Convert.ToDecimal(-0.05))
                    {
                        _mensajeErrorBonificaciones = _mensajeErrorBonificaciones + " " + item.Codigo;
                        isvalid = false;
                    }
                }
            }


            return isvalid;

        }
        //German 20120208 - Tarea 0000276

		public bool AllowShow() 
		{
			return true;
		}
		public void FormHasClosed() 
		{
		}
		

		private ItemsDatasetErrors _errores = new ItemsDatasetErrors();
		
		public ItemsDatasetErrors Errores
		{
			get
			{
				return _errores;
			}
		}
		
		/*
		public void EliminarValor(int posicion)
		{

			this._comprobanteDePago.Valores.EliminarValor(posicion);
		}

		
		public void Recalcular()
		{
			this._comprobanteDePago.Recalcular();
			this._importeCancelado = this._comprobanteDePago.Total;
		}
*/
		private bool ExistsNumeration()
		{
			
			return mz.erp.businessrules.tsa_Comprobantes.ExistsNumeration(this.Numero, this.TipoComprobanteDestino);
			
		}

		
		#endregion

		public void ListenerTaskDependentChanged(object sender)
		{
			if(sender.GetType() == typeof(mz.erp.businessrules.RecargosFormasDePago))
			{
				if(!this._taskName.Equals("AnularPrevender")&&!this._taskName.Equals("AnularPreprestar")
                    //German 20111202 - Tarea 0000232
                    && !(this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoPrevenderReserva") && this._taskName.Equals("Vender"))
                    //Fin German 20111202 - Tarea 0000232
                    )
				{
					RecargosFormasDePago recargos = (RecargosFormasDePago) sender;
					decimal porcentajeRecargo = recargos.PorcentualRecargosFinancieros;
					if((porcentajeRecargo > 0 && porcentajeRecargo != _recargoFinancieroPorFormaDePago/*_porcentualrecargosFinancieros*/) || (porcentajeRecargo != _recargoFinancieroPorFormaDePago/*_porcentualrecargosFinancieros*/))
					{
						this.RecargoFinancieroPorFormaDePago = porcentajeRecargo;
						/*	
						_porcentualrecargosFinancieros = porcentajeRecargo;
						this.IsDirty = true;
						this.Items.RefrescarImpuestos();
						this.Items.RefrescarBonificaciones();
						this.CallEvents();									
						*/
						if(recargos.Modified)
							RecargoFinancieroPorFormaDePago = porcentajeRecargo;
					}

				}
			}
		}
		public void ListenerAfterExecuteDependentTask( object sender )
		{
            if (sender.GetType() == typeof(mz.erp.businessrules.SeleccionItemsPendientes))
            {
				SeleccionItemsPendientes itemsPendientes = (SeleccionItemsPendientes)sender;
				if(itemsPendientes.RelacionesComprobanteOrigenDestino != null && itemsPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{
                    //German 20120222 - Tarea 0000247
                    if ( (this._processManager.Process.ProcessName.Equals("ProcesoAnularPrevenderAcopio") && this._taskName.Equals("Devolver"))
                        || (this._processManager.Process.ProcessName.Equals("ProcesoAnularPreprestarAcopio") && this._taskName.Equals("Devolver"))
                        
                        )
                    {
                        bool _actualizaPrecios = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Step.ActualizaPrecios",true);
                        itemsPendientes.RelacionesComprobanteOrigenDestino.ActualizaPrecio = _actualizaPrecios;
                    }
                    //Fin German 20120222 - Tarea 0000247
                    Step( ((SeleccionItemsPendientes)sender).RelacionesComprobanteOrigenDestino);
				}
			}

            if (sender.GetType() == typeof( mz.erp.businessrules.ComprobantesPendientes ))
			{
			
				ComprobantesPendientes comprobantesPendientes = (ComprobantesPendientes)sender;
				if(this._processManager.Process.ProcessName.Equals("ProcesoRepararPrevender") || this._processManager.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPrevender")
					|| this._processManager.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPreprestar") || this._processManager.Process.ProcessName.Equals("ProcesoRepararPreprestar"))
					this._ordenesReparacion = comprobantesPendientes.ArrayIdComprobantesPendientes;
				/*
				if(comprobantesPendientes.RelacionesComprobanteOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{
					
					this.Step(comprobantesPendientes.RelacionesComprobanteOrigenDestino);
					//this.OnRecalcularComprobante(this, new EventArgs());
				}
				*/
			}

			if (sender.GetType() == typeof( mz.erp.businessrules.SeleccionReparacionesPendientes ))
			{
			
				SeleccionReparacionesPendientes comprobantesPendientes = (SeleccionReparacionesPendientes)sender;
				if(this._processManager.Process.ProcessName.Equals("ProcesoRepararPrevender")|| this._processManager.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPrevender")
					|| this._processManager.Process.ProcessName.Equals("ProcesoArmarEquipoNuevoPreprestar") || this._processManager.Process.ProcessName.Equals("ProcesoRepararPreprestar"))
					this._ordenesReparacion = comprobantesPendientes.ArrayIdComporbantesPendientes;
				/*
				if(comprobantesPendientes.RelacionesComprobanteOrigenDestino != null && comprobantesPendientes.RelacionesComprobanteOrigenDestino.Count > 0)
				{
					
					this.Step(comprobantesPendientes.RelacionesComprobanteOrigenDestino);
					//this.OnRecalcularComprobante(this, new EventArgs());
				}
				*/
			}
			if(sender.GetType() == typeof(mz.erp.businessrules.RecargosFormasDePago))
			{
				if(!this._taskName.Equals("AnularPrevender")&&!this._taskName.Equals("AnularPreprestar")
                    //German 20111202 - Tarea 0000232
                    && !(this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoPrevenderReserva") && this._taskName.Equals("Vender"))
                    //Fin German 20111202 - Tarea 0000232
                    
                    )
				{
					RecargosFormasDePago recargos = (RecargosFormasDePago) sender;
					decimal porcentajeRecargo = recargos.PorcentualRecargosFinancieros; 
					if(porcentajeRecargo != _recargoFinancieroPorFormaDePago/*_porcentualrecargosFinancieros*/)
					{
						this.RecargoFinancieroPorFormaDePago = porcentajeRecargo;
						/*
						_porcentualrecargosFinancieros = porcentajeRecargo;
						this.IsDirty = true;
						this.Items.RefrescarImpuestos();
						this.Items.RefrescarBonificaciones();
						this.CallEvents();									
						*/
					}
				
					if(recargos.Modified)
						RecargoFinancieroPorFormaDePago = porcentajeRecargo;
				}

			}

			if(sender.GetType() == typeof(mz.erp.businessrules.ConceptosAdicionales))
			{
				if(!this._taskName.Equals("AnularPrevender")&&!this._taskName.Equals("AnularPreprestar"))
				{
					ConceptosAdicionales fletes = (ConceptosAdicionales) sender;
					if(fletes.ArrayItems.Count > 0)
						LoadDataFromConceptosAdicionales(fletes);
				}
			}

			if(sender.GetType() == typeof(mz.erp.businessrules.FiscalComprobantes))
			{
				FiscalComprobantes impresion = (FiscalComprobantes) sender;
                //German 20111207 - Tarea 0000232
				if(impresion.TareaAsociada.Equals(_taskName) || (this._taskName.Equals("Prevender") && this._processManager.Process.ProcessName.Equals("ProcesoPrevenderReserva")))
                //Fin German 20111207 - Tarea 0000232
				{
					this.Numero = impresion.Numero;
					this.ActualizaNumeracion = impresion.ActualizaNumeracion;
				}
			}			
			if (sender.GetType() == typeof( mz.erp.businessrules.SolicitarAutorizacion ))
			{
				SolicitarAutorizacion solicitar = (SolicitarAutorizacion) sender;
				_idAutorizacion = solicitar.IdAutorizacion;
				
			}
			if (sender.GetType() == typeof( mz.erp.businessrules.comprobantes.ComprobanteDeVenta ) &&
				(this._processManager.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentas") ||
				this._processManager.Process.ProcessName.Equals("ProcesoCambiarMercaderiaVentasDV"))
				&& (this._taskName.Equals("Vender") || this._taskName.Equals("Prestar")))
			{
				ComprobanteDeVenta comp = (ComprobanteDeVenta)sender;
				LoadFromComprobanteDeVenta(comp);
                /* Silvina 20110316 - Tarea 0000039 */
                _totalNC = comp.Total;
                /* Fin Silvina */
			}
            /* Silvina 20111212 - Tarea 0000232 */
            if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDeVenta) && this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoPrevenderReserva") && this._taskName.Equals("Vender"))
            {
                ComprobanteDeVenta comp = (ComprobanteDeVenta)sender;
                //German 20120302 - Tarea 0000284
                this.Cuenta = new Cuenta("NEW", this, comp.IdCuenta);
                //Fin German 20120302 - Tarea 0000284
                IdCuenta = comp.IdCuenta;
                FechaReserva = comp.FechaReserva;
            }
            /* Fin Silvina 20111212 - Tarea 0000232 */
            //German 20111202 - Tarea 0000232
            if (sender.GetType() == typeof(mz.erp.businessrules.comprobantes.ComprobanteDePago))
            {
                if (this.GetProcessManagerParent().Process.ProcessName.Equals("ProcesoPrevenderReserva") && this._taskName.Equals("Vender"))
                {
                    ComprobanteDePago recargos = (ComprobanteDePago)sender;
                    this.Items.ClearCache();
                    this.Items.Clear();
                    bool _listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios");
                    string codigoProductoReserva = Variables.GetValueString("Productos.CodigoProductoReserva");
                    if (_idListaDePreciosDefault == null || _idListaDePreciosDefault.Equals(string.Empty)) 
                            _idListaDePreciosDefault = Variables.GetValueString("Productos.IdListaDePreciosDefault");

                    Productos prod = new mz.erp.businessrules.Productos("CODIGO", codigoProductoReserva, _idListaDePreciosDefault, _idListaDePreciosDefault, _listaDePreciosHabilitadas, false);

                    Item item = new Item(prod);
                    item.SetConversion(this._taskName);
                    mz.erp.businessrules.comprobantes.ItemComprobante _miItemComprobante = new ItemComprobante("NEW", this.Items, item);
                    _miItemComprobante.PrecioConImpuestos = recargos.Total;
                    this.Items.AddInCache(_miItemComprobante);
                    this.Items.FlushCache();
                }



            }
            //Fin German 20111202 - Tarea 0000232

		}

        /* Silvina 20110316 - Tarea 0000039 */
        private decimal _totalNC = 0;
        private bool _visualizaSaldo = false;

        public decimal TotalNC
        {
            get { return _totalNC; }
        }

        public bool VisualizaSaldo
        {
            get { return _visualizaSaldo; }
        }

        /* Fin Silvina */

        /* Silvina 20111212 - Tarea 0000232 */
        private bool _visualizaFechaReserva = false;
        private DateTime _fechaReserva = mz.erp.businessrules.Sistema.DateTime.Now;

        public bool VisualizaFechaReserva
        {
            get { return _visualizaFechaReserva; }
        }

        public DateTime FechaReserva
        {
            set { _fechaReserva = value; }
            get { return _fechaReserva; }
        }

        /* Fin Silvina 20111212 - Tarea 0000232 */

		private void LoadFromComprobanteDeVenta(ComprobanteDeVenta comp)
		{
			this.CodigoCuenta = comp.CodigoCuenta;
			this.CondicionDeVenta.IdCondicionDeVenta = comp.CondicionDeVenta.IdCondicionDeVenta;
			this.Items.IsDirty = true;
			this.Items.RefrescarBonificaciones();
			this.Items.RefrescarImpuestos();
			this.Refresh();
			this.Items.IsDirty=false;
		}

		private void LoadDataFromConceptosAdicionales(ConceptosAdicionales fletes)
		{
			Item item = new Item(fletes);
			mz.erp.businessrules.comprobantes.ItemComprobante _miItemComprobante = new ItemComprobante( "NEW", this.Items, item );
			this.Items.ClearCache();
			this.Items.AddInCache( _miItemComprobante );
			this.Items.FlushCache();
			
			/*
			if(porcentajeRecargo > 0 && porcentajeRecargo != _porcentualrecargosFinancieros)
			{
				_porcentualrecargosFinancieros = porcentajeRecargo;
				this.IsDirty = true;
				this.Items.RefrescarImpuestos();
				this.Items.RefrescarBonificaciones();
				this.CallEvents();		
			}
			*/
		}

		private bool _hasSaved = false;
		public bool GetHasSaved()
		{
			return _hasSaved;
		}
		public event System.EventHandler OnTaskBeforeFlush;
		public event System.EventHandler OnTaskAfterFlush;
		
		public void ListenerBeforeExecuteDependentTask( object sender )
		{
			
		}

		public bool IsValidForStartProcess()
		{

            _errores.Clear();
			WorkflowValidator validator = new WorkflowValidator();
			long IdTarea = Workflow.GetIdTakByName(_taskName);
			bool IsValid = validator.IsValidForStartProcess(this._processManager.Process.IdProcess,IdTarea, this);
			_errores.AddAll(validator.GetErrors());
			return IsValid;

		}
		
		public void Step(RelacionesComprobanteOrigenDestino relaciones)
		{
			
			string action = "STEP";
			_idComprobanteOrigen = relaciones.Get(0).IdComprobante;
			_MACOR = relaciones.MACOR;
			string idcomprobante;
			if ((this._idComprobante == null) || (this._idComprobante == string.Empty))
			{
				idcomprobante = null;
			}
			else
			{
				idcomprobante =  this._idComprobante;
			}

			string momento = this._taskName;
			this._momento = momento;
			string idcuenta;
			if ((this.CodigoCuenta == null) || (this.CodigoCuenta == string.Empty ))
			{
				idcuenta =ComprobantesRules.Momentos_Cuenta_Default(momento);
			}
			else
			{
				idcuenta = this._idCuenta;
			}
			System.DateTime fecha;
			if (( this.FechaComprobante != mz.erp.businessrules.Sistema.DateTime.Now ))
			{
				fecha = this.FechaComprobante;
			}
			else
			{
				fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			}
			string idresponsable;
			if (( this.IdResponsable == null) || (this.IdResponsable == string.Empty ))			
			{
				idresponsable = Security.IdPersona;
			}
			else
			{
				idresponsable = this.IdResponsable;
			}
			string idcondiciondeventa;
			if (( this.CondicionDeVenta.IdCondicionDeVenta == null ))
			{
				idcondiciondeventa = null;
			}
			else
			{
				idcondiciondeventa = this.CondicionDeVenta.IdCondicionDeVenta ;
			}
			string idtipodecomprobantedestino;
			if ((this.TipoComprobanteDestino == null ) || (this.TipoComprobanteDestino == string.Empty ))
			{
				idtipodecomprobantedestino = null;
			}
			else
			{
				idtipodecomprobantedestino = this.TipoComprobanteDestino ;
			}
			
			//German 20091023 - tarea 470
			_responsablesComprobantesAnteriores = relaciones.ResponsablesComprobantesAnteriores;
			//Fin German 20091023 - tarea 470

			Init( action, idcomprobante, momento, idcuenta, fecha, idresponsable, idcondiciondeventa, idtipodecomprobantedestino, relaciones);
			if(ObjectHasChanged != null)
				ObjectHasChanged(this, new EventArgs());
		
		}

		public void SetRelacionesComprobantesOrigenDestino(RelacionesComprobanteOrigenDestino crod)
		{
			this._relacionesComprobanteOrigenDestino = crod;
		}

		public RelacionesComprobanteOrigenDestino RelacionesComprobantesOrigenDestino
		{
			set
			{
				LoadDataFromRelacionesComprobanteOrigenDestino( value );
				if (ObjectHasChanged != null)
				{
					ObjectHasChanged( this, new System.EventArgs() );
				}
			}
			get
			{
				return this._relacionesComprobanteOrigenDestino;
			}
		}
		private void LoadDataFromRelacionesComprobanteOrigenDestino( RelacionesComprobanteOrigenDestino relaciones )
		{
			/*********/
			this.Items = new ItemsComprobantes("STEP", this, relaciones);
			/*********/
			this.Items.IsDirty=false;
			this.VariablesComprobante = new VariablesAuxiliares( "STEP", this );
			this.DatasetComprobante = new mz.erp.commontypes.data.tsa_ComprobantesExDataset();
			this.TemporalNumeration = true;
			this._relacionesComprobanteOrigenDestino = relaciones;
		}

		private bool _habilitaUsuariaAltaOR = false;

		public bool HabilitaUsuariaAltaOR
		{
			get{return _habilitaUsuariaAltaOR;}
		}
		
		public void Init()
		{
			DateTime fecha1 = DateTime.Now;
			string action = "NEW";
			string idcomprobante = null;
			string momento = this._taskName;
			this._momento = momento;
			string codigo = ComprobantesRules.Momentos_Cuenta_Default(momento);
			string idcuenta = tsa_Cuentas.GetPkByUk( codigo );
			_habilitaUsuariaAltaOR = Variables.GetValueBool("Sistema.RentabilidadOR.HabilitaUsuarioAlta");
			System.DateTime fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			string idresponsable = string.Copy(Security.IdPersona);
			string idcondiciondeventa  = string.Empty;
			/*long condicionPorDefecto = ComprobantesRules.Momentos_FormaDePago_Default(this.Momento); 
			if ( ! (condicionPorDefecto == long.MinValue))
				idcondiciondeventa = Convert.ToString(condicionPorDefecto);*/
			string idtipodecomprobantedestino = null; 
			RelacionesComprobanteOrigenDestino relaciones = null;
			TimeSpan  diff = DateTime.Now.Subtract(fecha1);
			Console.WriteLine("Antes del ComprobanteDeVenta.Init() " + diff.TotalSeconds + " " + DateTime.Now);

			string proceso = this._processManager.Process.ProcessName;
			_listaTiposDeComprobantesSugiereNumeracion = Variables.GetValueString(proceso, this._taskName, "Emision.Editar.SugerirNumero.ListaTiposDeComprobantes");
			_estadoStockAValidar = Variables.GetValueString(proceso, this._taskName, "Emision.Validar.ItemsSinStock.EstadoDeStock");
			_allowGeneracionRapida  = ComprobantesRules.Momentos_HabilitaGeneracionRapida(this._processManager.Process.ProcessName, this._taskName);

			_idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
			_idFuenteDeCambioReferencia = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");

			_listasDePrecios = Variables.GetValueBool("Productos.ListasDePrecios");
			_permiteListaDePreciosDistintas = Variables.GetValueBool(this.ProcessName(), this.TaskName(), "PermiteListaDePreciosDistintas", "Productos.ListaDePrecios.PermiteListaDePreciosDistintas");			
			
			_validaCambioDeFecha = Variables.GetValueBool(proceso,_taskName,"ValidaCambioDeFecha");
			_cantidadDeDias = Variables.GetValueLong(proceso,_taskName,"CantidadDeDias");

			//German 20090804
			_numeracionPorPerfil = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumeroPorPerfil", _numeracionPorPerfil);
			//Fin German 20090804

            /* Silvina 20111230 - Tarea 0000245 */
            _numeracionPorUsuario = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Emision.Editar.SugerirNumeroPorUsuario", _numeracionPorUsuario);
            /* Fin Silvina 20111230 - Tarea 0000245 */

            /* Silvina 20100531 - Tarea 646 */
            _seleccionaUltimo = Variables.GetValueBool("ComprobantesDeVenta.Emision.Editar.SeleccionaUltimoProducto");
            if (!_seleccionaUltimo)
                _seleccionaUltimo = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "Emision.Editar.SeleccionaUltimoProducto", _seleccionaUltimo);
            /* Fin Silvina */

            /* Silvina 20110316 - Tarea 0000039 */
            _visualizaSaldo = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "VisualizaSaldo", _visualizaSaldo);
            /* Fin Silvina */

            /* Silvina 20111212 - Tarea 0000232 */
            _visualizaFechaReserva = Variables.GetValueBool(this._processManager.Process.ProcessName, this._taskName, "VisualizaFechaReserva", _visualizaFechaReserva);
            /* Fin Silvina 20111212 - Tarea 0000232 */

            /* Silvina 20111104 - Tarea 0000222 */
            _usaCategorias = Variables.GetValueBool("Cuentas.UsaCategorias");
            /* Fin Silvina 20111104 - Tarea 0000222 */
			Init( action, idcomprobante, momento, idcuenta, fecha, idresponsable, idcondiciondeventa, idtipodecomprobantedestino, relaciones);
		}
		
		public ItemsDatasetErrors GetErrors()
		{
			return this._errores;
		}
		/*private bool PercibeIB
		{
			get
			{
				string listaIBstr = Variables.GetValueString("Impuestos.Lista.IB");
				ArrayList listaIB = Util.Parse(listaIBstr, ",");
				foreach(DataRow row in this.Items.ResumenDeImpuestos.Rows)
				{
					string key = Convert.ToString(row["key"]);
					if(listaIB.Contains(key))
						return true;
				}
				return false;
			}
		}*/

		public string GetWarnings()
		{
			StringBuilder result = new StringBuilder();				
			if(AllowToShowWarningItemsPertenecenAJerarquias /*&& this.PercibeIB*/)
			{
				string Jerarquias = Variables.GetValueString(this._processManager.Process.ProcessName, this._taskName, "Emision.Validar.ItemsPertencenAJerarquias.MostrarWarning.JerarquiasNoValidas");
				ArrayList aux = mz.erp.systemframework.Util.Parse(Jerarquias, ",");
				foreach(ItemComprobante item in this.Items)
				{
					foreach(string j in aux)
					{
						if(mz.erp.businessrules.tsh_AgrupProductos.GetList(item.IdProducto, j).Tables[0].Rows.Count > 0)
						{
							result.Append("El Artículo " + item.Codigo + " Pertenece a la Jerarquía de Bien de Uso.");
							result.Append(System.Environment.NewLine);
							break;
						}
					}
				}
				//return result;
			}
			if(_allowToValidateStock && _estadoStockAValidar != null && _estadoStockAValidar != string.Empty)
			{
				foreach(ItemComprobante item in this.Items)
				{
					decimal stock = Stock.GetStock(item.IdProducto, this._idDeposito, this._idSeccion, _estadoStockAValidar, Security.IdSucursal, Security.IdEmpresa);
					if(item.CantidadUnidadDestino > stock)
					{
						result.Append(" El Artículo " + item.DescripcionDetallada + " tiene stock por debajo de la cantidad ingresada.");
						result.Append(System.Environment.NewLine);
					}
				}
				//return result.ToString();
			}
			if(_allowToShowWarningItemsConMonto0)
			{
				if (this.Items.ExistenItemsConMonto0)
				{
					result.Append(this.Items.ItemsConMonto0);
					result.Append(System.Environment.NewLine);
				}
				//return result.ToString();
			}
			if(_allowToShowWarningLimiteDeCredito)
			{
				if(!ValidarLimiteDeCredito())
				{
					result.Append(this._mensajeErrorLimiteDeCredito);
					result.Append(System.Environment.NewLine);
				}
				
			}
			if(_allowToShowWarningDiasLimiteDeCredito)
			{
				if(!ValidarDiasLimiteDeCredito())
				{
					result.Append(this._mensajeErrorDiasLimiteDeCredito);
					result.Append(System.Environment.NewLine);
				}
				
			}
			if (result.Length>0)
				return result.ToString();
			return null;			
		}

	
		public ProcessManager GetProcessManagerParent()
		{
			return _processManager;
		}
		public void SetProcessManagerParent(ProcessManager processManager)
		{
			_processManager = processManager;
		}
		public event System.EventHandler ObjectHasChanged;
		public event System.EventHandler OnTaskBeforeExecute;
		public event System.EventHandler OnTaskAfterExecute;
		public event System.EventHandler NumeroComprobanteChanged;
	
		private string _taskName = null;
		public void SetTaskName( string taskName )
		{
			_taskName = taskName;
		}
		public string GetTaskName()
		{
			return _taskName;
		}

		private bool _isValid = false;
		public void Execute()
		{
			if(OnTaskBeforeExecute != null)
				OnTaskBeforeExecute(this, new EventArgs());
			this.IsValid();
			this.reasignarResponsable();
			//Viviana
			if(OnTaskAfterExecute != null)
				OnTaskAfterExecute(this, new EventArgs());
		}

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
			

		private void Cuenta_CodigoChanged(object sender, EventArgs e)
		{	
			if(OnRefrescarComprobante != null)
				OnRefrescarComprobante(this, new EventArgs());
		}

		public override string IdCuenta
		{
			get {return Cuenta.IdCuenta;}
			set {Cuenta.IdCuenta = value;}
		 }

		public bool DatosCuentaChanged
		{
			set{Cuenta.DatosCuentaChanged = value;}
		}

		public string CodigoCuenta
		{
			get{return Cuenta.Codigo;}
			set
			{
                /* Silvina 20100104 - Tarea 887 */
                if (!Cuenta.Codigo.Equals(value))
                //German 20120514 - Tarea 0000325
                {
                    _actualizaLP = true;
                    _actualizaLPPorCategoria = true;
                }
                //Fin German 20120514 - Tarea 0000325
                /* Fin Silvina */
				Cuenta.Codigo = value;
			}
		}

		public bool IsEditable()
		{
			return (this.ProcessName() != "PocesoPrevenderVender");
		}


		public void PutExtraDataOnCommit(ProcessCollectionData _processCollectionData)
		{
			
		}

		public override decimal RecargoFinancieroPorCondicionDeVenta
		{
			get	{return base.RecargoFinancieroPorCondicionDeVenta;}
			set	
			{	
				if(_recargoFinancieroPorCondicionDeVenta != value)
				{
					_recargoFinancieroPorCondicionDeVenta = value;
					_porcentualrecargosFinancieros = value;
					// Silvina 20100511 - Tarea 748 
					if (Items != null)
						Items.RefrescarBonificaciones();
					
					//this.Items.OnRecalcItems -= new ItemsComprobantes.RecalcularItems( this.EscuchoRecalcularItems );
					//this.Items.OnRefreshItems -= new ItemsComprobantes.RefrescarItems( this.EscuchoRefrescarItems );
					//this.Cuenta.OnRecalcularCuenta -= new Cuenta.RecalcularCuenta( this.EscuchoRecalcularCuenta );
					//this.CondicionDeVenta.IdCondicionDeVentaChanged -=new EventHandler(this.EscuchoRecalcularItems);
					//this.IsDirty = true;
					//this.Items.RefrescarImpuestos();
					//his.Items.RefrescarBonificaciones();
					//his.CallEvents();	
					//this.Items.OnRecalcItems += new ItemsComprobantes.RecalcularItems( this.EscuchoRecalcularItems );
					//this.Items.OnRefreshItems += new ItemsComprobantes.RefrescarItems( this.EscuchoRefrescarItems );
					//this.Cuenta.OnRecalcularCuenta += new Cuenta.RecalcularCuenta( this.EscuchoRecalcularCuenta );
					//this.CondicionDeVenta.IdCondicionDeVentaChanged +=new EventHandler(this.EscuchoRecalcularItems);
				}
			}
		}

		public override decimal RecargoFinancieroPorFormaDePago
		{
			get{return base.RecargoFinancieroPorFormaDePago;}
			set
			{
				if(value != _recargoFinancieroPorFormaDePago)
				{	
					decimal totalSinRecargo = this.TotalConImpuestosSinRecargos;
					if(totalSinRecargo > 0)
					{
						_recargoFinancieroPorFormaDePago = value;
						decimal recargoPorCondicionDeVenta = totalSinRecargo * _recargoFinancieroPorCondicionDeVenta/100;
						decimal totalConRecargoPorCondicionDeVenta = totalSinRecargo + recargoPorCondicionDeVenta;
						decimal recargoPorFormaDepago = totalConRecargoPorCondicionDeVenta * _recargoFinancieroPorFormaDePago/100;
						decimal totalConRecargoFormaDePago = totalConRecargoPorCondicionDeVenta + recargoPorFormaDepago;
						decimal totalRecargosFinancieros = totalConRecargoFormaDePago - totalSinRecargo;
						_porcentualrecargosFinancieros = totalRecargosFinancieros * 100 / totalSinRecargo;
						this.IsDirty = true;
						this.Items.RefrescarBonificaciones();
						this.Items.RefrescarImpuestos();
						this.IsDirty = false;
						
					}			
				}
			}
		}


		public string FillNumberWithZeros(string txt)
		{
			string separator = Variables.GetValueString("Comprobante.TiposDeComprobante.Numeracion.Separador");
			int cant1 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion1.Longitud") );
			int cant2 = (int) ( Variables.GetValueLong("Comprobante.TiposDeComprobante.Numeracion.Seccion2.Longitud") );
			return mz.erp.systemframework.Util.FillNumberWithZeros(txt, separator, cant1, cant2);
		}

		public void ActualizarListaDePreciosItemsCargadados()
		{
            if (!this.PermiteListaDePreciosDistintas)
			{
				foreach ( ItemComprobante item in this.Items )
				{
					item.IdListaDePrecios = this.IdListaDePreciosDefault;
				}
			}
            /* Silvina 20101104 - Tarea 887 */
            _actualizaLP = false;
            /* Fin Silvina */
		}

        /* Silvina 20111104 - Tarea 0000222 */
        
        public void ActualizarCategorias()
        {
            foreach (ItemComprobante item in Items)
            {
                string lp = tsh_ProductosListasDePreciosCategoriasCuentas.GetListaDePrecios(Cuenta.JerarquiaCategorias, item.JerarquiaCategorias);
                if (lp != null)
                    item.IdListaDePrecios = lp;
                else
                    item.IdListaDePrecios = this.IdListaDePreciosDefault;
            }
            //German 20120514 - Tarea 0000325
            _actualizaLPPorCategoria = false;
            //Fin German 20120514 - Tarea 0000325
        }
        
        /* Fin Silvina 20111104 - Tarea 0000222 */

        //Matias 20110823 - Tarea 0000131
        public decimal GetBaseImponible(string impuestos) //Ojo: impuesto es una lista de impuestos!
        {
            return Items.GetBaseImponible(impuestos);
        }
        public int CantidadDeImpuestos(ArrayList lista)
        {
            //foreach (DataRow rowImpuesto in comprobante.Items.ResumenDeImpuestos.Rows)
            //{
            //    string key = Convert.ToString(rowImpuesto["Key"]);
            //    if (impIIBB.Contains(key) || impInternos.Contains(key))
            //        ctrib++;
            //    else
            //    {
            //        if (impIVA.Contains(key))
            //            civa++;
            //    }
            //}            
            int cant = 0;
            foreach (DataRow rowImpuesto in this.Items.ResumenDeImpuestos.Rows)
            {
                // ResumenDeImpuestos no trae duplicados de impuestos (ya viene con el distinct incluido!)
                string key = Convert.ToString(rowImpuesto["Key"]);
                if (lista.Contains(key))
                    cant++;
            }
            return cant;
        }

        //FinMatias 20110823 - Tarea 0000131
	}
}

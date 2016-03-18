using System;
using System.Data;
using mz.erp.businessrules;
using ParaisoFiscal;
using mz.erp.businessrules.comprobantes;
using System.Collections;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Fiscal.
	/// </summary>
	/// 
	
	/*	public class FormasPagoFiscal 
		{

			private string _texto;
			private decimal _monto;		

			public string Texto 
			{
				get 
				{
					return _texto;
				}
				set 
				{
					_texto = value;
				}
			}
			public decimal Monto 
			{
				get
				{
					return _monto;
				}
				set 
				{				
					_monto = value;
				}
			}

			public FormasPagoFiscal() 
			{
			}

			public FormasPagoFiscal(string Texto, decimal Monto) 
			{
				_texto = Texto;
				_monto = Monto;			
			}
		}
	*/
	public class InterfaceFiscal
	{		
		public event EventHandler OnChangeEstadoFiscal; //Manejador para clase superior
		private ParaisoFiscal.FiscalMZ fiscal;
		private byte _codImpFis = byte.Parse(Variables.GetValue("Fiscal.Codigo").ToString());
		private byte _codCompTipo = 1; //1 Factura; 2 ND; 3 NC; 4 ticket; 16 ticket-factura
		private byte _codCliTipo = 5; //cons. final
		private bool _subActiva = Variables.GetValueBool("Fiscal.SubActiva",true);
		private bool _informacionAdicional = Variables.GetValueBool("Fiscal.InformacionAdicional");
		//Si la variable _subActiva está en false no llama a los métodos de FiscalMZ, pero continua como si lo estuviera haciendo. De esta forma se pueden chequear los valores finales impresos sin que tener imprimir en la IF

		private decimal _ivaDefault = 0;
		//private bool _itemConPrecioCero = Variables.GetValueBool("Fiscal.Item.ImprimirConPrecioCero");
		
		
		private string _mensaje;
		public string Mensaje 
		{
			get 
			{
				return _mensaje;
			}
		}

		private string MensajeInt
		{			
			get 
			{
				return _mensaje;
			}
			set 
			{
				_mensaje = value;
				if (OnChangeEstadoFiscal != null) 
				{
					OnChangeEstadoFiscal( this , new System.EventArgs());
				}			
			}
		}
		
		private ReporteFiscal _reporteFiscal = null;
		public ReporteFiscal ReporteFiscal
		{
			get { return _reporteFiscal; }
		}
		


		private bool _soportaComprobante = false;
		public bool SoportaComprobante 
		{			
			get
			{				
				return _soportaComprobante;
			}
		}		

		private byte _copias = 0;
		public byte Copias
		{			
			get	{return _copias;}
			set {_copias = value;}
		}		

		private string _numero = string.Empty;
		public string Numero
		{			
			get	{return _numero;}
		}	
	
		private string _numeroDesde = string.Empty;
		public string NumeroDesde
		{
			get{return _numeroDesde;}
		}

		private string _numeroHasta = string.Empty;
		private char _claseComp = char.MaxValue;
		private string _puntoVentaComp = string.Empty;

		public string NumeroHasta
		{
			get{return _numeroHasta;}
		}

		public char ClaseComp
		{
			get{return _claseComp;}
		}
		public string PuntoVentaComp
		{
			get{return _puntoVentaComp;}
		}
		

		/// <summary>
		/// En true da la posibilidad de buscar el número de comprobante en la variable "Comprobantes.Numeracion..."
		/// Cuando desde la interface fiscal está todo OK (cierre de comprobante) se pone el parámetro en false. 
		/// De esta forma se graba con el valor que asigna el controlador fiscal
		/// </summary>
		private bool _actualizaNumeracion = true; 
		public bool ActualizaNumeracion
		{			
			get	{return _actualizaNumeracion;}
		}		

		private bool _todosItemsOK = true; 
		public bool TodosItemsOK
		{			
			get	{return _todosItemsOK;}
		}		
		private bool _totalOK = true; 
		public bool TotalOK
		{			
			get	{return _totalOK;}
		}	

        /* Silvina 20110704 - Tarea 0000136 */

        private string _idTipoDeComprobante;
        public string IdTipoDeComprobante
        {
            set { _idTipoDeComprobante = value; }
            get { return _idTipoDeComprobante; }
        }	

        /* Fin Silvina 20110704 - Tarea 0000136 */
		
		/*public InterfaceFiscal(string TipoComprobante) 
		{
			Init(TipoComprobante);
		}*/

		/*public InterfaceFiscal(ComprobanteDeVenta Comprobante, string TipoComprobante)
		{
			_comprobante = Comprobante;
			Init(TipoComprobante);
			fiscal = new ParaisoFiscal.FiscalMZ();
			fiscal.OnChangeEstado += (new System.EventHandler(OnChangeEstado));
		}*/

		public InterfaceFiscal(ProcessManager process, string TaskName) 
		{			
			_processManager = process;
			_taskName = TaskName;
			fiscal = new ParaisoFiscal.FiscalMZ();
			fiscal.OnChangeEstado += (new System.EventHandler(OnChangeEstado));			
		}

		private DatosPreparadosParaImpresion _datosPreparados;
		private string _taskName = string.Empty;
		private ProcessManager _processManager = null;

        /* Silvina 20110704 - Tarea 0000136 */
        public InterfaceFiscal(DatosPreparadosParaImpresion DatosPreparados, ProcessManager process, string TaskName, string IdTipo)
        /* Fin Silvina 20110704 - Tarea 0000136 */
		{			
			_datosPreparados = DatosPreparados;			
			_processManager = process;
			_taskName = TaskName;
            /* Silvina 20110704 - Tarea 0000136 */
            IdTipoDeComprobante = IdTipo;
            /* Fin Silvina 20110704 - Tarea 0000136 */
			Init();
		}
		
        /* Silvina 20111212 - Tarea 0000232 */
        private string _codSeña = string.Empty;
        /* Fin Silvina 20111212 - Tarea 0000232 */

		private void Init() 
		{						
			fiscal = new ParaisoFiscal.FiscalMZ();

            /* Silvina 20100713 - Tarea 795 */
            /* Silvina 20110704 - Tarea 0000136 */
            fiscal.ImprimeTicketDeCambio = Variables.GetValueBool("TicketDeCambio.Habilitar") && Variables.GetValueBool(_processManager.Process.ProcessName, _taskName, "TicketDeCambio.Habilitar", false);
            //German 20120329 - Tarea 0000308
            if (IdTipoDeComprobante != null && IdTipoDeComprobante.Trim() != string.Empty)
            //Fin German 20120329 - Tarea 0000308
            {
                string familia = tsy_TiposDeComprobantes.GetByPk(IdTipoDeComprobante).Familia;
                string descAdic = Variables.GetValueString("TicketDeCambio." + familia + ".DescripcionAdicional", string.Empty);
                if (descAdic.Equals(string.Empty))
                    descAdic = Variables.GetValueString("TicketDeCambio.DescripcionAdicional");
                fiscal.DescripcionAdicionalTicketDeCambio = descAdic;
                /* Silvina 20111212 - Tarea 0000232 */
                _codSeña = Variables.GetValueString("Productos.CodigoProductoReserva");
                /* Fin Silvina 20111212 - Tarea 0000232 */
            }
            /* Fin Silvina 20110704 - Tarea 0000136 */
            /* Fin Silvina 20100713 - Tarea 795 */
			fiscal.OnChangeEstado += (new System.EventHandler(OnChangeEstado));			

			_codCliTipo = GetTipoCliente();	
			switch (_datosPreparados.TipoComprobante)
			{
				case "FA": _codCompTipo = 1;
					break;
				case "ND": _codCompTipo = 2;
					break;
				case "NC": _codCompTipo = 3;
					break;
				case "TI": _codCompTipo = 4;
					break;
				case "TF": _codCompTipo = 16;
					break;
				case "TINC": _codCompTipo = 17;
					break;
				case "RM": _codCompTipo = 7; //Remito
					break;
				case "RX": _codCompTipo = 6;//Recibo
					break;
				default:
					MensajeInt = "Comprobante no reconocido: " + _datosPreparados.TipoComprobante;
					break;
			}			
		}
		

		private void OnChangeEstado(object Sender, System.EventArgs e) 
		{

            
            if (_mensaje != fiscal.Mensaje && fiscal.Mensaje.Trim() != String.Empty)//para evitar que se imprima el mismo mensaje
			{
				MensajeInt = fiscal.Mensaje;				
				if (_informacionAdicional) 
				{
					MensajeInt = fiscal.EstadoFiscal;
				}
			}
            mz.erp.commontypes.ApplicationLog.WriteInfo("Mensaje Fiscal = " + MensajeInt);
            
		}

		public bool ImpresionFiscal() 
		{		
			MensajeInt = "Impresión de comprobante";
			bool AbrioIF = false;

            mz.erp.commontypes.ApplicationLog.WriteError("ConfiguracionImpresoraFiscal()" );
			if (ConfiguracionImpresoraFiscal()) 
			{
                mz.erp.commontypes.ApplicationLog.WriteError("AperturaImpresoraFiscal()");
				if (AperturaImpresoraFiscal() ) 
				{

                    mz.erp.commontypes.ApplicationLog.WriteError("fiscal.AbrirImpFis() = true");
                    mz.erp.commontypes.ApplicationLog.WriteError("Estado Despues fiscal.AbrirImpFis() = true" + fiscal.EstadoFiscal);
                    ChequearDatosCabecera();
					GrabarClase();
					AbrioIF = true;
				}
                mz.erp.commontypes.ApplicationLog.WriteError("Estado Despues fiscal.AbrirImpFis() = false" + fiscal.EstadoFiscal);
                mz.erp.commontypes.ApplicationLog.WriteError("fiscal.EstadoCompAbierto = " + Convert.ToString(fiscal.EstadoCompAbierto));
				if (fiscal.EstadoCompAbierto) 
				{
					GetClase();
					if (fiscal.CancelarComp()) 
					{
						GrabaComprobanteAnulado();
						AbrioIF = true;
					}
				}
				if (AbrioIF) 
				{
                    mz.erp.commontypes.ApplicationLog.WriteError("AbrioIF = " + Convert.ToString(AbrioIF));
                    if (AperturaComprobanteFiscal()) 
					{						
						if (_codCompTipo != 6)  //RECIBO X
						{
							ImpresionItems();
							ImpresionObservaciones();
							if (_datosPreparados.TipoComprobante != "RM")
							{
								ImpresionPercepciones();															
								DescuentosGenerales();
								PrevioCierre();
							}
						}
						if (_datosPreparados.TipoComprobante != "RM") //Remito
						{
							Pagos();
						}						
						if (CierreComprobanteFiscal()) 
						{return true;}
						else
						{return false;}

						CierreImpresoraFiscal();
						
					}	
					else 
					{return false;} //nuevo nov 2005
				}
				else
				{return false;} //nuevo nov 2005
			}
			return false;
		}

		private void DescuentosGenerales()
		{
			//ItemsComprobantes items = _comprobante.Items;
			bool _aplicoDescuentosEnItem = Variables.GetValueBool("Fiscal.DescuentoEnItem");
			bool _discriminaDescuentoCuenta = Variables.GetValueBool("Productos.Precio.Bonificaciones.DiscriminarBonRecCuenta");
			bool _discriminaDescuentoProducto = Variables.GetValueBool("Productos.Precio.Bonificaciones.DiscriminarBonRecProducto");
			bool _discriminaDescuentoFinanciero = Variables.GetValueBool("Productos.Precio.Bonificaciones.DiscriminarBonRecFinancieros");
				
			decimal descuentosGenerales = 0;
            //German 20120606 - Tarea 0000348
            char tipo = 'D';
            string leyendaA = "";
            string leyenda = "";
            //Fin German 20120606 - Tarea 0000348
			if (_aplicoDescuentosEnItem)
			{
                //German 20120606 - Tarea 0000348

                if (fiscal.GrupoImpFis == 2)
                    descuentosGenerales = 0;
                else
                {
                    foreach (ItemComprobante it in this._datosPreparados.Items)
                    {
                        if (it.Precio < 0)
                        {
                            leyendaA += it.Descripcion + " ";
                            descuentosGenerales += it.SubTotalNeto;
                        }
                    }
                    if (descuentosGenerales >= 0)
                    {
                        tipo = 'D';
                    }
                    else
                    {
                        tipo = 'R';
                    }

                    if (descuentosGenerales != 0)
                    {
                        //German 20120131 - Tarea 0000269 - Si tipo = D entonces multiplica descuentogeneral por -1
                        if ((descuentosGenerales > 0 && tipo == 'R') || (descuentosGenerales < 0 && tipo == 'D'))
                            leyenda = "Recargo " + leyendaA;
                        else
                            leyenda = "Bonificación " + leyendaA;
                        //German 20120131 - Tarea 0000269
                        fiscal.GrabarDesctoGral(leyenda, descuentosGenerales, tipo);
                    }
                }
                //Fin German 20120606 - Tarea 0000348
			}
			else
			{
                //German 20120606 - Tarea 0000348
				//char tipo = 'D';
                //string leyendaA = "";
				//string leyenda = "";
                //Fin German 20120606 - Tarea 0000348
				if (!_discriminaDescuentoCuenta)
				{
					descuentosGenerales = this._datosPreparados.ItemsTotalBonificacionesRecargosCuenta;
                    //German 20120131 - Tarea 0000269
                    if(descuentosGenerales != 0)
                    //German 20120131 - Tarea 0000269
    					leyendaA = "Cliente ";
				}
                
				if (!_discriminaDescuentoProducto)
                {
					descuentosGenerales+= this._datosPreparados.ItemsTotalBonificacionesRecargosProducto;
                    //German 20120131 - Tarea 0000269
                    if (this._datosPreparados.ItemsTotalBonificacionesRecargosProducto != 0 )
                        leyendaA += "Producto ";
                    foreach(ItemComprobante it in this._datosPreparados.Items)
                    {
                        if (it.Precio < 0)
                        {
                            leyendaA += it.Descripcion + " ";
                            descuentosGenerales += it.SubTotalNeto;
                        }
                    }
                    
					//leyendaA+= "Producto ";
                    //German 20120131 - Tarea 0000269
				}
				if (!_discriminaDescuentoFinanciero)
				{
                    //German 20120214 - Tarea 0000281 - Si es step y hay rec/desc financieros esto genera problemas.Esto tiene relacion con el metodo ImpresionItems!!!
                    //descuentosGenerales+= this._datosPreparados.ItemsTotalBonificacionesRecargosFinancieros;
                    //Fin German 20120214 - Tarea 0000281
                    //German 20120131 - Tarea 0000269
                    if (this._datosPreparados.ItemsTotalBonificacionesRecargosFinancieros != 0)
                    //German 20120131 - Tarea 0000269
					    leyendaA+= "Financieros ";
				}
     
	            if (descuentosGenerales >= 0)
     
				{
					tipo = 'D';
				}
				else
				{
					tipo = 'R';
				}
                
				if (descuentosGenerales != 0)
				{
                    //German 20120131 - Tarea 0000269 - Si tipo = D entonces multiplica descuentogeneral por -1
                    if ((descuentosGenerales > 0 && tipo == 'R') ||  (descuentosGenerales < 0 && tipo == 'D'))
                       leyenda = "Recargo "+ leyendaA;
                    else
                        leyenda = "Bonificación " + leyendaA;
                    //German 20120131 - Tarea 0000269
					fiscal.GrabarDesctoGral( leyenda, descuentosGenerales, tipo );
				}				
			}
		}
		public bool Sincronizacion() 
		{
			_codCompTipo = GetTipoComprobante(Variables.GetValueString("Fiscal.Momentos.Vender"));							
			if (ConfiguracionImpresoraFiscal())
			{
				AperturaImpresoraFiscal();
				if (fiscal.EstadoCompAbierto) 
				{
					GetClase();
					if (fiscal.CancelarComp())
					{													
						GrabaComprobanteAnulado();
						return true;
					}
					else 
					{return false;}
				}
				else 
				{
					MensajeInt = "No hay ningún comprobante abierto";
					return false;
				}				
			}
			else 
			{return false;}

		}

		public bool Cierre(char Tipo) 
		{
			MensajeInt = "Cierre " + Tipo;			
			if ( fiscal.VerOpcImpFis(_codImpFis, _codCompTipo, _codCliTipo)) 
			{
				MensajeInt = fiscal.Nombre;
				byte Puerto = byte.Parse(Variables.GetValue("Fiscal.Puerto").ToString());
				MensajeInt = "Puerto: COM" + Convert.ToString(Puerto);
				int Velocidad = int.Parse(Variables.GetValue("Fiscal.Velocidad").ToString());
				if (fiscal.CompPuntoDeVenta == String.Empty) 
				{								
					fiscal.CompPuntoDeVenta = Variables.GetValue("Fiscal.PuntoDeVenta").ToString();
				}			

				bool Abrio = fiscal.AbrirImpFis(Puerto, Velocidad);				
				/*if (fiscal.NecesitaCierre) 
				{*/
				_reporteFiscal = new ReporteFiscal();	
				if (Abrio)
				{
					Abrio = fiscal.Reporte(Tipo,_reporteFiscal);
					ReporteDatos(_reporteFiscal);
				}				
				return Abrio;
				//}				
			}
			return false;
		}
		public void Prueba() 
		{
			GrabaComprobanteAnulado();
		}
		private bool ConfiguracionImpresoraFiscal()
		{				
			fiscal.InformacionAdicional = Variables.GetValueBool("Fiscal.InformacionAdicional");
			if (_codCompTipo == 0)  
			{
				MensajeInt = "No reconoce el tipo de comprobante";		
				return false;
			}

			if ( fiscal.VerOpcImpFis(_codImpFis, _codCompTipo, _codCliTipo)) 
			{				
				MensajeInt = fiscal.Nombre;
			}
			else
			{								
				MensajeInt = "Error de código de impresora fiscal";			
				return false;
			}			

			if (fiscal.SoportaCompTipo)
			{
				MensajeInt = fiscal.CompNombre + ' ' + fiscal.CompClase;				
				_soportaComprobante = true;
			}
			else
			{
				MensajeInt = "No soporta tipo de comprobante";		
				_soportaComprobante = false;
				return false;
			}
			
			if (fiscal.SoportaCliente)
			{
				MensajeInt = fiscal.CliTipo;				
			}
			else
			{
				MensajeInt = "No soporta tipo de cliente";				
				return false;
			}

			/*
			 Acá tengo que evaluar los items para ver si la impresora fiscal soporta 
			 los impuestos incluidos en cada uno de ellos, se pasaría el mensaje a MensajeInt
			 * */
			return true;
		}

		private bool AperturaImpresoraFiscal() 
		{
            mz.erp.commontypes.ApplicationLog.WriteError("AperturaImpresoraFiscal");
            byte Puerto = byte.Parse(Variables.GetValue("Fiscal.Puerto").ToString());
            mz.erp.commontypes.ApplicationLog.WriteError("Puerto " + Convert.ToString(Puerto));
			int Velocidad = int.Parse(Variables.GetValue("Fiscal.Velocidad").ToString());
            mz.erp.commontypes.ApplicationLog.WriteError("Velocidad " + Convert.ToString(Velocidad));
            //German 20110311 - Tarea 0000077

            /*
             * Si es true, indica que al momento de imprimir un item se le pasa el precio sin impuestos 
             * directos, de esta forma la fiscal calcula el neto.
             * Solo se aplica a impresoras Hasar.
             * 
             */

            bool _precioBase = Variables.GetValueBool("Fiscal.Item.PrecioBase", true);
            fiscal.PrecioBase = _precioBase;
            //Fin German 20110311 - Tarea 0000077
			if (fiscal.CompPuntoDeVenta == String.Empty) 
			{								
				fiscal.CompPuntoDeVenta = Variables.GetValue("Fiscal.PuntoDeVenta").ToString();
			}			
			if (_subActiva)
			{
				MensajeInt = "Puerto: COM" + Convert.ToString(Puerto);
                mz.erp.commontypes.ApplicationLog.WriteError("fiscal.AbrirImpFis()");
                mz.erp.commontypes.ApplicationLog.WriteError("Estado Antes fiscal.AbrirImpFis() " + fiscal.EstadoFiscal);
				return fiscal.AbrirImpFis(Puerto, Velocidad);
			}
			else
			{
				MensajeInt = HTML.Bold("Impresora fiscal sub-activa = false");
				return true;
			}
				
		}

		private bool AperturaComprobanteFiscal()
		{						
			if (_datosPreparados.TipoComprobante != "RM" && _datosPreparados.TipoComprobante != "RX")
			{
				MensajeInt = HTML.Bold("Total a facturar: " + Convert.ToString(_datosPreparados.Total));
				MensajeInt = " ";		
			}
			ClienteFiscal clifis = new ClienteFiscal(_codImpFis);
			clifis.CondIVA = _codCliTipo;
			clifis.DocTipo = GetTipoDocumento();
			clifis.DocNumero = this._datosPreparados.CuentaDocumento;

			if (clifis.DocTipo == 0) 
			{
				clifis.DocTipo = Convert.ToByte(Variables.GetValueString("Fiscal.Comprobante.TipoDocumento.Default"));
				MensajeInt = HTML.Bold("El cliente no tiene ingresado el tipo de documento");
			}

			if (ClienteVacio(clifis.DocNumero))
			{
				clifis.DocNumero = Variables.GetValueString("Fiscal.Comprobante.NroDocumento.Default");
				if (_datosPreparados.Total >= Variables.GetValueDecimal("Fiscal.Comprobantes.ImporteLimiteSinDNICuenta"))
					MensajeInt = HTML.Bold("El cliente no tiene ingresado el número de documento");
			}
			else 
			{
                //German 20110221 - Tarea 0000025
				clifis.DocNumero = this._datosPreparados.CuentaDocumento.Replace("-","").Replace(".","");
                //Fin German 20110221 - Tarea 0000025
			}
            //German 20120307 - Tarea 0000289
			ArrayList Lineas = CargarLineas(clifis);
            //Fin German 20120307 - Tarea 0000289
			DistribuyeLineas(Lineas, clifis);
			
			fiscal.DescuentoEnItem = Variables.GetValueBool("Fiscal.DescuentoEnItem");

			string TipoLetra = Variables.GetValueString("Fiscal.TipoLetra");
			fiscal.TipoLetra = TipoLetra == "-1" ? "12" : TipoLetra;
			fiscal.Copias = Convert.ToByte(Variables.GetValueString("Fiscal.Copias"));

			if (_codCompTipo == 6)  //RECIBO X 
			{
				try 
				{
					fiscal.NroInterno = Convert.ToUInt64(this._datosPreparados.NroInterno);
				}
				catch 
				{
					fiscal.NroInterno = 0;
				}				
			}

			if (_subActiva)
			{
				if (fiscal.AbrirComp(_codCompTipo, 0, clifis))
				{												
					if (_codCompTipo != 6)  
					{
						MensajeInt = fiscal.CompAbrev + ' ' + fiscal.CompClase.ToString() + ' ' + fiscal.CompPuntoDeVenta + '-' + fiscal.CompNumeroD;
						this._numero = fiscal.CompClase.ToString() + '-' + fiscal.CompPuntoDeVenta + '-' + fiscal.CompNumeroD;					
					}
					else  //RECIBO X 
					{
						MensajeInt = this._datosPreparados.NroInterno;
						this._numero = this._datosPreparados.NroInterno;
					}
					return true;
				}			
				return false;
			}
			else return true;		
		}

        //German 20120307 - Tarea 0000289
        private ArrayList CargarLineas(ClienteFiscal clifis)
        //Fin German 20120307 - Tarea 0000289
		{					
			string Impresion = Variables.GetValueString("Fiscal.Comprobante.Impresion.Momentos." + this._datosPreparados.Momento);
			if (Impresion == "") 
			{
				Impresion = Variables.GetValueString("Fiscal.Comprobante.Impresion.Default");
			}

			//los id de variables 
			ArrayList ids = mz.erp.systemframework.Util.Parse(Impresion,",");
			ArrayList Lineas = new ArrayList();
			//int lineasvar = 0;			
			string separador = " ";

			string deuda = "saldo: xx.xx";//GetTextoSaldo();

			string compasoc1 = "";
			string compasoc2 = "";
			string compasoc3 = "";
			string compasoc4 = "";
			string compasoc5 = "";					
			GetNumAsocs(ref compasoc1, ref compasoc2, ref compasoc3, ref compasoc4, ref compasoc5);
            //German 20120306 - Tarea 0000289

            string remitosAsociados =string.Empty;
            string remitosAsociados2 = string.Empty;

            byte longLinFis = fiscal.LinVarLong;
            string longLinVar = Variables.GetValueString("Fiscal.Comprobante.LineasVariables.Longitud");
            int longLin = longLinVar == "-1" ? (int)longLinFis : Convert.ToInt32(longLinVar);

            if (this._processManager.Process.ProcessName.Equals("ProcesoRemitirVender"))
            {
                foreach( string num in this._datosPreparados.RemitosAsociados)
                {
                    // + 8 por que al final se le anexa el texto "Remitos " y el + 9 es para que tenga que tenga en cuenta que entra el proximo numero
                    if ((remitosAsociados.Length + 8 + 9) <= longLin && remitosAsociados2.Equals(string.Empty))
                    {
                        remitosAsociados = remitosAsociados + num.Substring(6);
                    }
                    else //+ 9 es para que tenga que tenga en cuenta que entra el proximo numero
                        if((remitosAsociados2.Length + 9) <= longLin)
                            remitosAsociados2 = remitosAsociados2 + num.Substring(6);
                }


            }
            if (remitosAsociados != string.Empty)
                remitosAsociados = "Remitos " + remitosAsociados;
                     
            //Fin German 20120306 - Tarea 0000289
				
			string cliente = this._datosPreparados.CuentaNombre;
			string clienteCod = this._datosPreparados.CuentaCodigo;
			string direccion = this._datosPreparados.CuentaDomicilio.Trim() == "" ? "(sin domicilio)" : this._datosPreparados.CuentaDomicilio.Trim();
			string direccionEntrega = this._datosPreparados.CuentaDomicilioEntrega.Trim() == "" ? "" : this._datosPreparados.CuentaDomicilioEntrega.Trim();			
			string localidad = this._datosPreparados.CuentaLocalidad.Trim() == "" ? "": this._datosPreparados.CuentaLocalidad.Trim();
			string telefono = this._datosPreparados.CuentaTelefono.Trim() == "" ? "(sin telef)" : this._datosPreparados.CuentaTelefono.Trim();
			string vendedor = this._datosPreparados.Responsable.Trim();

			string cv = this._datosPreparados.CondicionDeVenta.Trim();


			string dfp = GetDetalleFormaDePago();
			decimal cotizacion = mz.erp.businessrules.tfi_CotizacionesMonedas.GetCoeficienteCotizacionPorDefecto(2);
			decimal total = this._datosPreparados.Total; 
			string cotizacionS = cotizacion.ToString();
			decimal total2 = total / cotizacion;
			string totalS = Convert.ToString(Math.Round(total2,2));				

			string texto1 = Variables.GetValueString("Fiscal.Comprobante.Texto1");
			string texto2 = Variables.GetValueString("Fiscal.Comprobante.Texto2");
			string texto3 = Variables.GetValueString("Fiscal.Comprobante.Texto3");
			string texto4 = Variables.GetValueString("Fiscal.Comprobante.Texto4");
			string texto5 = Variables.GetValueString("Fiscal.Comprobante.Texto5");			
			string texto6 = Variables.GetValueString("Fiscal.Comprobante.Texto6");			
			string texto7 = Variables.GetValueString("Fiscal.Comprobante.Texto7");			
			string texto8 = Variables.GetValueString("Fiscal.Comprobante.Texto8");			
			string texto9 = Variables.GetValueString("Fiscal.Comprobante.Texto9");			
			string texto10 = Variables.GetValueString("Fiscal.Comprobante.Texto10");			

			bool MostrarTitulo = Variables.GetValueBool("Fiscal.Comprobante.Momentos.Entregar.MostrarTitulo");						
			//Para esta última pendiente agregar para otros momentos.

			foreach (string lineavar in ids) 
			{
				string campo = "";
				ArrayList ids2 = mz.erp.systemframework.Util.Parse(lineavar,"+");

				foreach (string mascara in ids2) 
				{										
					switch (mascara.Trim().ToUpper()) 
					{									
						case "": campo = " ";
							break;						
						case "@CUENTA": 
							campo = campo + cliente + separador;
							break;
						case "@CUENTACODIGO": 
							campo = campo + clienteCod + separador;
							break;							
						case "@DIRECCION": 
						case "@DOMICILIO": 
							campo = campo + direccion + separador;
							break;		
						case "@DIRECCIONENTREGA": 
						case "@DOMICILIOENTREGA": 
							campo = campo + direccionEntrega + separador;
							break;					
						case "@LOCALIDAD": 
							campo = campo + localidad + separador;
							break;						
						case "@TELEFONO":
							campo = campo + telefono + separador;
							break;						
						case "@VENDEDOR": 
							campo = campo + vendedor + separador;
							break;						
						case "@CV": 
							campo = campo + cv + separador;
							break;						
						case "@DFP": 
							campo = campo + dfp + separador;
							break;
						case "@COTIZACION":  campo = campo + cotizacion + separador;
							break;
						case "@TOTAL": campo = campo + totalS + separador;
							break;
						case "@DEUDA": 
						case "@SALDO":
							campo = campo + deuda + separador;
							break;
						case "@COMPASOC1": campo = campo + compasoc1 + separador;
							break;
						case "@COMPASOC2": campo = campo + compasoc2 + separador;
							break;
						case "@COMPASOC3": campo = campo + compasoc3 + separador;
							break;
						case "@COMPASOC4": campo = campo + compasoc4 + separador;
							break;
						case "@COMPASOC5": campo = campo + compasoc5 + separador;
							break;
						case "@TEXTO1": campo = campo + texto1 + separador;
							break;
						case "@TEXTO2": campo = campo + texto2 + separador;
							break;
						case "@TEXTO3": campo = campo + texto3 + separador;
							break;
						case "@TEXTO4": campo = campo + texto4 + separador;
							break;
						case "@TEXTO5": campo = campo + texto5 + separador;
							break;
						case "@TEXTO6": campo = campo + texto6 + separador;
							break;
						case "@TEXTO7": campo = campo + texto7 + separador;
							break;
						case "@TEXTO8": campo = campo + texto8 + separador;
							break;
						case "@TEXTO9": campo = campo + texto9 + separador;
							break;
						case "@TEXTO10": campo = campo + texto10 + separador;
                            break;
                        //German 20110715 - Tarea 0000151
                        case "@OBSERVACIONES": campo = campo + _datosPreparados.Observaciones + separador;
                            break;
                        //Fin German 20110715 - Tarea 0000151
                        //German 20120306 - Tarea 0000289
                        case "@REMITOSASOCIADOS": campo = campo + remitosAsociados + separador;
                            break;
                        case "@REMITOSASOCIADOS2": campo = campo + remitosAsociados2 + separador;
                            break;
                        //Fin German 20120306 - Tarea 0000289
						default: 
							if (mascara.Substring(0,1) == '#'.ToString())
							{
								string varAux = (mascara + "   ").Substring(1,3);
								if (this._datosPreparados.VariablesDeUsuario.Count == 0)
								{
									campo = " ";
								}
								else 
								{
									foreach(VariableAuxiliar var in this._datosPreparados.VariablesDeUsuario) 
									{
										if (var.Id == varAux.Trim()) 
										{							
											if (var.Valor.Trim() != "") 
											{
												if (MostrarTitulo) 
												{campo = campo + var.Descripcion +": " + var.Valor + " ";}
												else 
												{campo = campo + var.Valor + " ";}
											}
										}
									}
								}
							}
							else
							{
								campo = campo + mascara + separador;
							}
							
							break; 
					}
				}				
				Lineas.Add(campo.Trim());				
			}
			return Lineas;
		}

		private void DistribuyeLineas(ArrayList Lineas, ClienteFiscal clifis) 
		{
			byte VarUsados = 0;
			byte NumAsocUsados = 0;
			byte PiesUsados = 0;
			byte VarTotal = fiscal.LinVarCant;
			byte NumAsocTotal = fiscal.LinNumAsocCant; 
			byte PiesTotal = fiscal.LinPieCant;

			byte longLinFis = fiscal.LinVarLong;
			string longLinVar = Variables.GetValueString("Fiscal.Comprobante.LineasVariables.Longitud");
			int longLin = longLinVar == "-1" ? (int) longLinFis : Convert.ToInt32(longLinVar);

			byte longPieFis = fiscal.LinVarLong;			
			string longPieVar = Variables.GetValueString("Fiscal.Comprobante.Pie.Longitud");
			int longPie = longPieVar == "-1" ? (int) longPieFis : Convert.ToInt32(longPieVar);

			for (int i = 0; i < Lineas.Count; i++)  			 
			{
				string linea = Lineas[i].ToString();
				switch (i) 
				{
					case 0:
						clifis.Nombre = linea;
						break;
					case 1:
						clifis.Direccion = linea;
						break;
					default:
						if (VarUsados < VarTotal) 
						{
							if (linea.Length > longLin) 
							{linea = linea.Substring(0, longLin);}
							
							switch (VarUsados) 
							{								
								case 0: fiscal.LinVar1 = linea; break;
								case 1: fiscal.LinVar2 = linea; break;
								case 2: fiscal.LinVar3 = linea; break;
								case 3: fiscal.LinVar4 = linea; break;
								case 4: fiscal.LinVar5 = linea; break;
								case 5: fiscal.LinVar6 = linea; break;
								case 6: fiscal.LinVar7 = linea; break;								
							}
							VarUsados++;
						}
						else 
						{
							if (NumAsocUsados < NumAsocTotal) 
							{
								switch (NumAsocUsados) 
								{
									case 0: fiscal.NumAsoc1 = linea; break;
									case 1: fiscal.NumAsoc2 = linea; break;
									case 2: fiscal.NumAsoc3 = linea; break;
									case 3: fiscal.NumAsoc4 = linea; break;
								}
								NumAsocUsados++;
							}
							else 
							{
								if (PiesUsados < PiesTotal) 
								{
									switch (PiesUsados) 
									{
										case 0: fiscal.LinPie1 = Util.SubstringReplicate(linea,0,longPie); break;
										case 1: fiscal.LinPie2 = Util.SubstringReplicate(linea,0,longPie); break;
										case 2: fiscal.LinPie3 = Util.SubstringReplicate(linea,0,longPie); break;
										case 3: fiscal.LinPie4 = Util.SubstringReplicate(linea,0,longPie); break;
									}
									PiesUsados++;
								}
							}
						} //end if
						break;
				}
			}			
		}
		private string GetDetalleFormaDePago()
		{
			string cadena = "";
			cadena = "cheque Bco Provincia 1234.22";
			/*			ArrayList aValores = _datosPreparados.Valores;
						foreach(Valor _valor in aValores) 
						{					
							item.Descripcion = _valor.Comprobante + ":" + " " + Convert.ToString(Math.Round(_valor.MontoCotizado, 2));
							if (_subActiva) 
							{
								if (fiscal.GrabarItem(item))
								{MensajeInt = "Pago grabado " + _valor.Comprobante;}
								else 
								{MensajeInt = "No se pudo grabar el pago " + _valor.Comprobante;}					
							}
							else 
							{
								MensajeInt = "Pago grabado " + _valor.Comprobante;
							}
						}*/
			return cadena;
		}
		
		//German 20100618
		ArrayList fiscalItems = new ArrayList();
		//Fin German 20100618

		private void ImpresionItems()
		{			
			

			string debug = Variables.GetValueString("Fiscal.Debug.Codigo");
			if (debug.ToUpper() == "RompeAlImprimirItem".ToUpper()) 
			{
				MensajeInt = debug;
				throw (new Exception());
			}
			fiscal.InvertirCantidadMonto = Variables.GetValueBool("Fiscal.Item.InvertirCantidadMonto");												
			long auxlong = Variables.GetValueLong("Fiscal.Item.RedondeoPrecio");
			if (auxlong != long.MinValue)
				fiscal.RedondeoPrecio = auxlong;
			auxlong = Variables.GetValueLong("Fiscal.Item.RedondeoImpuesto");
			if (auxlong != long.MinValue)
				fiscal.RedondeoImpuesto =  auxlong;

			string textoAdicional = "";			

			ItemsComprobantes items = this._datosPreparados.Items;
			
			foreach (ItemComprobante itemComp in items)
			{									
				ItemFiscal item = new ItemFiscal();											
				item.Cantidad = itemComp.Cantidad;
				
				//Silvina 20100716 - Tarea 795
				ItemFiscal it = new ItemFiscal();			
				it.Cantidad = item.Cantidad;
				//Fin Silvina

				string Desc = Variables.GetValueString("Fiscal.Item.TipoDescripcion");
				string Descripcion = "";
				
				switch (Desc) 
				{
					case "DN": Descripcion = itemComp.Descripcion;
						break;	
						//German 20091022
					case "DC": 
						if(itemComp.IsDescripcionChanged && _datosPreparados.Items.ComprobanteDeVenta.State.ToUpper().Equals("NEW"))
						{
							Descripcion = itemComp.DescripcionLarga;
						}
						else
							Descripcion = itemComp.DescripcionCorta;
						break;
						//Fin German 20091022
					case "DL": Descripcion = itemComp.DescripcionLarga;
						break;
					default: Descripcion = itemComp.DescripcionCorta;
						break;
				}												
				
				//Silvina 20100716 - Tarea 795
				it.Descripcion = Descripcion;
				//Fin Silvina

				ArrayList ids = mz.erp.systemframework.Util.Parse(Variables.GetValueString("Fiscal.Item.OrdenCamposAuxiliares"),",");
				string separador = Variables.GetValueString("Fiscal.Item.Separador").Trim();
				string codigo = itemComp.Codigo;				

				string auxiliar = String.Empty; 
				foreach(string caux in ids) 
				{
					switch (caux.ToUpper().Trim())
					{
						case "C1": 
							if (itemComp.CampoAuxiliar1.Trim() != "") 
							{auxiliar = auxiliar + itemComp.CampoAuxiliar1.Trim() + separador;}
							break;
						case "C2": 
							if (itemComp.CampoAuxiliar2.Trim() != "") 
							{auxiliar = auxiliar + itemComp.CampoAuxiliar2.Trim() + separador;}
							break;
						case "C3": 
							if (itemComp.CampoAuxiliar3.Trim() != "") 
							{auxiliar = auxiliar + itemComp.CampoAuxiliar3.Trim() + separador;}
							break;
						case "C4": 
							if (itemComp.CampoAuxiliar4.Trim() != "") 
							{auxiliar = auxiliar + itemComp.CampoAuxiliar4.Trim() + separador;}
							break;
						case "C5": 
							if (itemComp.CampoAuxiliar5.Trim() != "") 
							{auxiliar = auxiliar + itemComp.CampoAuxiliar5.Trim() + separador;}
							break;
					}
				}
				if (_datosPreparados.PercibeIB && !itemComp.PercibeIB) 				
					textoAdicional = "BIEN DE USO";//despues pasar a variable				
				else
					textoAdicional = "";				

				string Impresion = Variables.GetValueString("Fiscal.Item.OrdenEnDescripcion");
				if (Impresion.Trim() == "") 
				{
					Descripcion = Descripcion + separador + codigo + separador + auxiliar + " " + textoAdicional;
				}
				else 
				{
					//Formato para variable Impresion = "@Codigo+@Descripcion";
					string descripcion = "";
					ArrayList array = mz.erp.systemframework.Util.Parse(Impresion,"+");
					foreach (string lineavar in array) 
					{							
						switch (lineavar.Trim().ToUpper()) 
						{									
							case "": descripcion = " ";
								break;						
							case "@CODIGO": 
								descripcion = descripcion + codigo + separador;
								break;
								/*case "@CODIGOSECUNDARIO": 
									item = item + codigoSecunddario + separador;
									break;*/
							case "@DESCRIPCION":
								descripcion = descripcion + Descripcion + separador;
								break;
							case "@AUXILIAR":
								descripcion = descripcion + auxiliar;
								break;
							case "@TEXTOADICIONAL":
								descripcion = descripcion + textoAdicional + separador;
								break;
						}						
					}				
					if (descripcion.Trim() != "") 
					{
						Descripcion = descripcion;						
					}					
				}

				item.IVA = GetIVA(itemComp);
				_ivaDefault = item.IVA;
				Impuestos imp = itemComp.ImpuestosDirectos;				
				ArrayList arrayII = mz.erp.systemframework.Util.Parse(Variables.GetValueString("Impuestos.II"),",");
                //German 20110602 - Tarea 0000149
                arrayII.AddRange(mz.erp.businessrules.tsy_Impuestos.GetListImpuestosInternosList());
                //Fin German 20110602 - Tarea 0000149
				item.ImpuestosInternos = imp.GetTotalImpuesto(arrayII);				

				//Establezco como se imprimen los descuentos
			{
				bool _aplicoDescuentosEnItem = Variables.GetValueBool("Fiscal.DescuentoEnItem");
				bool _discriminaDescuentoCuenta = Variables.GetValueBool("Productos.Precio.Bonificaciones.DiscriminarBonRecCuenta");
				bool _discriminaDescuentoProducto = Variables.GetValueBool("Productos.Precio.Bonificaciones.DiscriminarBonRecProducto");
				bool _discriminaDescuentoFinanciero = Variables.GetValueBool("Productos.Precio.Bonificaciones.DiscriminarBonRecFinancieros");
                //German 20110311 - Tarea 0000077

                /*
                 * Si es true, indica que al momento de imprimir un item se le pasa el precio sin impuestos 
                 * directos, de esta forma la fiscal calcula el neto.
                 * Solo se aplica a impresoras Hasar.
                 * 
                 */

                bool _precioBase = Variables.GetValueBool("Fiscal.Item.PrecioBase", true);
                //Fin German 20110311 - Tarea 0000077

                
                decimal pavada = itemComp.PrecioDeVentaBrutoOriginal;
					
					
				if (_aplicoDescuentosEnItem)
				{
                    //German 20110311 - Tarea 0000077
                    if (_precioBase)
                        item.Monto = itemComp.Precio;//Era el default
                    else
                        item.Monto = itemComp.PrecioConImpuestosDirectos;
                    //Fin German 20110311 - Tarea 0000077
					item.MontoDif = 0;
					item.Diferencia = 'D';
				}
				else
				{				
		
                     //German 20120131 - Tarea 0000269 -- Se agrega el if!! Es para que los prod con precios negativos salgan en el descuento general sin discriminar nada en el ITEM!
                    if (itemComp.Precio < 0)
                    {
                        //German 20110311 - Tarea 0000077
                        if (_precioBase)
                            item.Monto = itemComp.Precio;//Era el default
                        else
                            item.Monto = itemComp.PrecioConImpuestosDirectos;
                        //Fin German 20110311 - Tarea 0000077
                        item.MontoDif = 0;
                        item.Diferencia = 'D';
                    }
                    else
                    {
                        decimal montoTotalADiscriminar = 0;
                        decimal montoTotalAIncluir = 0;
                        if (_discriminaDescuentoCuenta)
                        {
                            montoTotalADiscriminar = itemComp.ImporteUnitarioSinImpBonificacionRecargoCuenta;
                        }
                        else
                        {
                            montoTotalAIncluir = itemComp.ImporteUnitarioSinImpBonificacionRecargoCuenta;
                        }
                        if (_discriminaDescuentoProducto)
                        {
                            montoTotalADiscriminar += itemComp.ImporteUnitarioSinImpBonificacionRecargoProducto;
                        }
                        else
                        {
                            montoTotalAIncluir += itemComp.ImporteUnitarioSinImpBonificacionRecargoProducto;
                        }
                        if (_discriminaDescuentoFinanciero)
                        {
                            montoTotalADiscriminar += itemComp.ImporteUnitarioSinImpBonificacionRecargoFinanciero;
                        }
                        else
                        {
                            montoTotalAIncluir += itemComp.ImporteUnitarioSinImpBonificacionRecargoFinanciero;
                        }

                        montoTotalADiscriminar += itemComp.PrecioDeVentaBruto - itemComp.PrecioDeVentaBrutoOriginal;
                        decimal montodif = montoTotalADiscriminar * itemComp.Cantidad;

                        if (montodif == 0)
                        {
                            item.Monto = itemComp.PrecioDeVentaBruto + montoTotalAIncluir;
                        }
                        else
                        {
                            item.Monto = itemComp.PrecioDeVentaBrutoOriginal + montoTotalAIncluir;
                        }

                        if (montodif < 0)
                        {
                            item.Diferencia = 'D';
                        }
                        else
                        {
                            item.Diferencia = 'R';
                        }
                        item.MontoDif = Math.Abs(montodif);
                    }
                    //German 20120131 - Tarea 0000269
				}
			}

				if (item.Diferencia == 'D')	
					item.DescripcionDif = "Descuento";
				else
					item.DescripcionDif = "Recargos";
				MensajeInt = "Imprimiendo item " + Convert.ToString(itemComp.Ordinal + 1) + " de " + _datosPreparados.Items.Count.ToString() + " " + Descripcion;

                /* Silvina 20111212 - Tarea 0000232 */
                if (item.Monto < 0)
                {
                    item.Monto = item.Monto * -1;
                    item.Signo = false;
                }
                /* Fin Silvina 20111212 - Tarea 0000232 */
			
				//monto 0
				if (_datosPreparados.TipoComprobante != "RM")
				{
					SubTotalFiscal st = new SubTotalFiscal(); 			
					fiscal.Subtotal(st);
					if (st.Total == 0 && item.Monto == 0) 
					{
						item.Monto = Convert.ToDecimal("0"+ Security.SeparadorDecimal +"01");
					}
				}

				if (debug.ToUpper() == "NoGrabaItem".ToUpper()) 
				{
					item.Monto = 0;
					item.IVA = 0;
				}


				/*if (!_itemConPrecioCero)
				{
					if (item.Monto == 0) 
					{
						//para no tener problemas por el separador de decimales de la configuracion regional en la maquina del usuario			
						item.Monto = Convert.ToDecimal("0"+ Security.SeparadorDecimal +"01"); 									
					}
				}*/

				if (_subActiva)
					GrabarItems2(item, Descripcion);
				//Silvina 20100716 - Tarea 795
				it.TextoFiscal = item.TextoFiscal;
                /* Silvina 20110704 - Tarea 0000136 */
                if (itemComp.PermiteCambio && (!_processManager.Process.ProcessName.Equals("ProcesoPrevenderVenderReserva") || !itemComp.Codigo.Equals(_codSeña)))
                /* Fin Silvina 20110704 - Tarea 0000136 */
				    fiscalItems.Add(it);
				//Fin Silvina

				//German  20100622
				//fiscalItems.Add(item);
				//Fin German  20100622
			}
		}
		
		private void ImpresionObservaciones() 
		{
			bool ImprimirObservaciones = Variables.GetValueBool("Fiscal.ObservacionEnItem");
			if 	(_datosPreparados.Observaciones != String.Empty && ImprimirObservaciones && _subActiva)
			{
				ItemFiscal item = new ItemFiscal();					
				item.Cantidad = 1;
                //German 20110606 - Tarea 0000153
                //item.Monto = 0;
				item.Monto = Convert.ToDecimal(0.01);
                item.IVA = 0;
				//item.IVA = _ivaDefault;
                //Fin German 20110606 - Tarea 0000153
				item.ImpuestosInternos = 0;
				item.Diferencia = 'D';								
				item.MontoDif = 0;
				item.DescripcionDif = String.Empty;

				string Descripcion = _datosPreparados.Observaciones;
				GrabarItems2(item, Descripcion);
			}
		}		
		private void ImpresionPercepciones()
		{
			if (_datosPreparados.ResumenDeImpuestos != null)
			{
				string listaIBstr = Variables.GetValueString("Impuestos.Lista.IB");
				ArrayList listaIB = Util.Parse(listaIBstr, ",");
				ArrayList listaIBDesc = new ArrayList();
				string Nombre = "";
				decimal Monto = 0;
				decimal Iva = 0;
				foreach (object ib in listaIB)
				{
					Nombre = businessrules.tsy_Impuestos.GetDescripcionCorta(Convert.ToString(ib));
					listaIBDesc.Add(Nombre);
				}						
				/*
				foreach (DataRow row in _datosPreparados.ResumenDeImpuestos.Rows)
				{
					if (listaIBDesc.Contains(row["DescripcionCorta"]))
					{					
						Nombre = Convert.ToString(row["DescripcionCorta"]);
						Monto = Convert.ToDecimal(row["Valor"]);
					}
				}
				*/
				//German 20090703  - Copiado del Codigo de MZ
				foreach (DataRow row in _datosPreparados.ResumenDeImpuestos.Rows)
				{
					if (listaIB.Contains(row["Key"]))
					{
                        //German 20120420 - Tarea 0000315
                        Nombre = "Percep. IIBB";//Convert.ToString(row["DescripcionCorta"]);
                        //Fin German 20120420 - Tarea 0000315
						Monto = Convert.ToDecimal(row["Valor"]);
					}
				}
				//Fin German 20090703  - Copiado del Codigo de MZ
				if (Monto > 0)
				{
					fiscal.Percepcion(Nombre, Monto, Iva);
				}
			}
		}

		private void GrabarItems2(ItemFiscal item, string Descripcion)
		{
			string longDescVar = Variables.GetValueString("Fiscal.Item.Descripcion.Longitud");
			byte longDesc = longDescVar == "-1" ? fiscal.LinItemLong : Convert.ToByte(longDescVar);

			string TextoFiscalSalida;
			string DescripcionSalida;
		
			int LongitudTextoFiscalMax = longDesc * 4;
			int LongitudItemFiscalMax = longDesc * 1;
			int LongitudTotal = LongitudTextoFiscalMax + LongitudItemFiscalMax;			
			double CantItemsDob = Convert.ToDouble(	Descripcion.Length ) / Convert.ToDouble( LongitudTotal );			
			CantItemsDob = Math.Ceiling(CantItemsDob);
			int CantItems = Convert.ToInt16( CantItemsDob );

			bool UnirItemConTextoFiscal = Variables.GetValueBool("Fiscal.Item.UnirItemConTextoFiscal", true);
			if (UnirItemConTextoFiscal)
			{
				for (int i = 0; i < CantItems; i++) 
				{
					string TextoAImprimir;
					if (Descripcion.Length > LongitudTotal*(i+1))
					{
						TextoAImprimir = Descripcion.Substring(i*LongitudTotal, LongitudTotal);					
					}
					else 
					{
						TextoAImprimir = Descripcion.Substring(i*LongitudTotal);
					}

					if (TextoAImprimir.Length > longDesc) 
					{
						int longRest = TextoAImprimir.Length - longDesc;
						TextoFiscalSalida = TextoAImprimir.Substring(0,longRest);
						DescripcionSalida = TextoAImprimir.Substring(longRest,TextoAImprimir.Length-longRest);
					}
					else 
					{
						TextoFiscalSalida = String.Empty;
						DescripcionSalida = TextoAImprimir;
					}					
					item.TextoFiscal = TextoFiscalSalida;								
					item.Descripcion = DescripcionSalida;

					bool itemOK = fiscal.GrabarItem(item);
					if (!itemOK)
					{
						_todosItemsOK = false;
					}

					//Reinicia las propiedades del objeto item para que si la descripcion es larga y hay que imprimir
					//varias líneas los montos no se dupliquen.
					item.Cantidad = 1;
					item.Monto = 0;				
					item.IVA = _ivaDefault;
					item.ImpuestosInternos = 0;
					item.Diferencia = 'D';								
					item.MontoDif = 0;
					item.DescripcionDif = String.Empty;
				}
			}
			else 
			{								
				item.TextoFiscal = String.Empty;
				if (Descripcion.Length <= longDesc)
					item.Descripcion = Descripcion;
				else
					item.Descripcion = Descripcion.Substring(0, longDesc);	
				
				bool itemOK = fiscal.GrabarItem(item);
				if (!itemOK)
				{
					_todosItemsOK = false;
				}
			}
				
		}
		private void PrevioCierre()
		{
			///Chequeo que el subtotal no sea 0. En caso contrario imprimo un item con precio 0.01
			SubTotalFiscal st = new SubTotalFiscal(); 			
			fiscal.Subtotal(st);
			if  (st.Total == 0) 
			{
				ItemFiscal item = new ItemFiscal();	
				item.Cantidad = 1;				
				item.Monto = Convert.ToDecimal("0"+ Security.SeparadorDecimal +"01");			
				item.IVA = _ivaDefault;
				item.ImpuestosInternos = 0;
				item.Diferencia = 'D';								
				item.MontoDif = 0;
				item.DescripcionDif = String.Empty;
				item.Descripcion = String.Empty;				
				bool itemOK = fiscal.GrabarItem(item);
				if (!itemOK)
				{
					_todosItemsOK = false;
				}			
			}	
			else
			{
				if (_informacionAdicional)
				{
					MensajeInt = String.Format("Neto: {0}", Convert.ToDecimal( st.Neto ));
					MensajeInt = String.Format("IVA: {0}", Convert.ToDecimal( st.Iva ));
					MensajeInt = String.Format("Total: {0}", Convert.ToDecimal( st.Total ));
				}				
			}

            decimal dif = Math.Abs(st.Total - _datosPreparados.Total);
			decimal difVar = Convert.ToDecimal(Variables.GetValueString("Fiscal.Comprobante.DiferenciaEnTotal"));
			bool cancelar = Variables.GetValueBool("Fiscal.Debug.CancelarAlCerrar", false);

			if (dif > difVar || cancelar)
			{
				_totalOK = false;
				MensajeInt = "TOTAL fiscal: " + Convert.ToString(st.Total);
				MensajeInt = "TOTAL a facturar: " + Convert.ToString(_datosPreparados.Total);

				fiscal.CancelarComp();								
			}
			else
			{
				if (dif > 0)
				{
					bool imprimirAjusteRedondeo = Variables.GetValueBool("Fiscal.Comprobante.RedondeoPorDiferencia",false);
					if (imprimirAjusteRedondeo)
					{
						decimal ajusteRedondeo = 0;
						char tipo;
						string leyenda = "Ajuste por redondeo";
						if (st.Total > _datosPreparados.Total)
						{					
							tipo = 'D';
						}
						else 
						{
							tipo = 'R';
						}						
						fiscal.GrabarDesctoGral( leyenda, dif, tipo );						
					}					
				}				
			}
		}

		private void Pagos() 
		{			
			ArrayList aValores = _datosPreparados.Valores;
			ArrayList aValores2 = new ArrayList();
			Valor valor;			

			int CantPagosVar = Convert.ToInt16(Variables.GetValueString("Fiscal.Comprobante.CantPagos"));
			int CantPagosFis = fiscal.LinPagos;
			int CantPagos = CantPagosVar == -1 ? CantPagosFis : CantPagosVar;

			decimal _montoAnt = 0;
			/*ArrayList en el que se almacena en la posicion 0 la propiedad Comprobante de la clase Valor.
			 * En la posicion 1 se almacena la propiedad MontoCotizado de la Clase Valor.En la posicion 2
			 * se almacena la propiedad Entidad.
			 * Objetivo: no modificar los objetos de tipo valor contenidos en aValores 
			 * * */
			ArrayList valorAux = new ArrayList();
			for (int i = 1; i <= aValores.Count; i++)  
			{				
				if(aValores[i-1] != null)
				{
					valor = (Valor) aValores[i-1];
					valorAux = new ArrayList();
					valorAux.Add(valor.Comprobante);
					valorAux.Add(valor.MontoCotizado);
					valorAux.Add(valor.Entidad);
					valorAux.Add(valor.Numero);
					if (i < CantPagos)
					{			
						aValores2.Add(valorAux);
					}
					else 
					{ 																				
						_montoAnt = valor.MontoCotizado + _montoAnt;
					}
				}
			}
			if (aValores.Count >= CantPagos) 
			{
				if(aValores[CantPagos-1] != null)
				{
					valor = (Valor) aValores[CantPagos-1];
					valorAux = new ArrayList();
					valorAux.Add("Otros");
					valorAux.Add(_montoAnt);
					valorAux.Add(valor.Entidad);
					valorAux.Add(valor.Numero);
					aValores2.Add(valorAux);
				}
			}

			if (_codCompTipo == 6) //RECIBO X 
			{			
				//fiscal.GrabarObservacionPago(_datosPreparados.Concepto);
				/*En el caso que sea necesario imprimir el concepto. Por ejemplo: "PAGO A CUENTA" es 
				 * necesario agregarlo como si fuera una forma de pago más. Por ejemplo se puede 
				 * instancias otro ItemFiscal más con monto 0.01 y al primer pago real restarle ese
				 * centavo. No hubo forma de imprimir un pago con monto cero. Posiblemente la OCX sea 
				 * quien realiza ese control en el momento de imprimir un item. Además el método que está
				 * comentado arriba: fiscal.GrabarObservacionPago(_datosPreparados.Concepto); tampoco
				 * funciona ya que no hay items grabados.*/			 

				decimal PagoRecibo = 0; 
				foreach(ArrayList _valorAux in aValores2) 
				{
					PagoRecibo = PagoRecibo + Convert.ToDecimal(_valorAux[1]);
				}
				//Cuando se graba un recibo en Hasar hay que mandarle los comandos de apertura
				//de comprobante fiscal. Por ahora quedan aca. Posiblemente y para abstraernos y de esta
				//diferencia y con la posibilidad de que otras controladores fiscales, por ej. epson
				//trabajen diferentes se podria colocar ese manejo dentro de FiscalMZ. 
				//Es decir que se llamaria a GrabarPago y este internamente se encargaria
				//de mandar los datos del cliente y abrir el comprobante Recibo X.																								  
				ItemFiscal item = new ItemFiscal();				
				item.Cantidad = 1;
				item.IVA = 0;
				item.Monto = PagoRecibo;
				foreach(ArrayList _valorAux in aValores2) 
				{					
					string Comprobante = Convert.ToString(_valorAux[0]);
					decimal MontoCotizado  = Convert.ToDecimal(_valorAux[1]);

					item.Descripcion = Comprobante + ":" + " " + Convert.ToString(Math.Round(MontoCotizado, 2));
					if (_subActiva) 
					{
						bool itemOK = fiscal.GrabarItem(item);
						if (itemOK)
						{							
							MensajeInt = "Pago grabado " + Comprobante;
						}
						else 
						{
							MensajeInt = "No se pudo grabar el pago " + Comprobante;
							_todosItemsOK = false;
						}
					}
					else 
					{
						MensajeInt = "Pago grabado " + Comprobante;
					}
				}
				if (_datosPreparados.Observaciones != String.Empty && _subActiva) 
				{
					fiscal.GrabarObservacionPago(_datosPreparados.Observaciones);
				}				
			}
			else 
			{
				foreach(ArrayList _valorAux in aValores2) 
				{
					string Comprobante = Convert.ToString(_valorAux[0]);
					decimal MontoCotizado  = Convert.ToDecimal(_valorAux[1]);
					string Entidad = Convert.ToString(_valorAux[2]);
					string Numero = Convert.ToString(_valorAux[3]);
					if (Comprobante == String.Empty) 
					{
						Comprobante = "Pago";	
					}

					if (_subActiva) 
					{						
						string Impresion = Variables.GetValueString("Fiscal.Pagos.OrdenCampos.Momentos." + this._datosPreparados.Momento);
						if (Impresion == "") 
						{
							Impresion = Variables.GetValueString("Fiscal.Pagos.OrdenCampos.Default");
						}
						//Formato para variable Impresion = "@Entidad+@Numero";
						string separador = " ";
						string campo = "";
						//los id de variables 
						ArrayList array = mz.erp.systemframework.Util.Parse(Impresion,"+");
						foreach (string lineavar in array) 
						{							
							switch (lineavar.Trim().ToUpper()) 
							{									
								case "": campo = " ";
									break;						
								case "@COMPROBANTE": 
									campo = campo + Comprobante + separador;
									break;
								case "@ENTIDAD": 
									campo = campo + Entidad + separador;
									break;
								case "@NUMERO":
									campo = campo + Numero + separador;
									break;
							}
							//DescripcionPago 
						}								

						string DescripcionPago = Comprobante + " " + Entidad;						
						if (campo.Trim() != "")
							DescripcionPago = campo;

						if (fiscal.GrabarPago(DescripcionPago, MontoCotizado)) 
						{MensajeInt = "Pago grabado " + Comprobante;}//estas son las propiedades para valores. Iguelmente revisar "monto"				
						else 
						{MensajeInt = "No se pudo grabar el pago " + Comprobante;}
					}
					else
					{MensajeInt = "Pago grabado " + Comprobante;}//estas son las propiedades para valores. Iguelmente revisar "monto"				
				}
			}					
			if (_subActiva)
			{
				SubTotalFiscal st = new SubTotalFiscal(); 
			
				fiscal.Subtotal(st);
				if (st.Total > st.Pagado) 
				{
					MensajeInt = "Pago grabado en cuenta corriente";
				}
				if ((st.Total > st.Pagado) && !fiscal.CuentaCorrienteAutomatica)
				{
					fiscal.GrabarPago("Cuenta Corriente", st.Total - st.Pagado);													
				}			
			}
		}
		private bool CierreComprobanteFiscal() 
		{	
			if (_subActiva) 
			{
				string strCopias = Variables.GetValueString("Fiscal.Copias.Momentos." + this._datosPreparados.Momento);
				if (strCopias != "") 
				{
					fiscal.Copias = Convert.ToByte(strCopias);
				}

				if (fiscal.CerrarComp()) 
				{
					if (_codCompTipo != 6) 
					{
						if(Variables.GetValueBool("Fiscal.Comprobantes.Transporte.ImporteUltimo"))
						{
							MensajeInt = fiscal.CompPuntoDeVenta + ' ' + fiscal.CompAbrev + ' ' + fiscal.CompClase.ToString() + ' ' + fiscal.CompNumeroH;
							this._numero = fiscal.CompClase.ToString() + '-' + fiscal.CompPuntoDeVenta + '-' + fiscal.CompNumeroH;				
						}
						else
						{
							MensajeInt = fiscal.CompPuntoDeVenta + ' ' + fiscal.CompAbrev + ' ' + fiscal.CompClase.ToString() + ' ' + fiscal.CompNumeroD;
							this._numero = fiscal.CompClase.ToString() + '-' + fiscal.CompPuntoDeVenta + '-' + fiscal.CompNumeroD;				
						}
						this._numeroDesde = fiscal.CompNumeroD;
						this._numeroHasta = fiscal.CompNumeroH;
						this._puntoVentaComp = fiscal.CompPuntoDeVenta;
						this._claseComp = fiscal.CompClase;
						this._actualizaNumeracion = false;	
						//German 20100622
						fiscal.ImprimirTicketDeCambio(fiscalItems);			
						//Fin German 20100622
			
					}
					else //RECIBO X 
					{					
						MensajeInt = this._datosPreparados.NroInterno;
						this._numero = this._datosPreparados.NroInterno;
						this._actualizaNumeracion = false;
					}
					return true;
				}
				return false;
			}				
			else return true;		
		}

		/*private bool Reimprimir()
		{
			this._copias = Convert.ToByte(fiscal.Copias);
			if ((fiscal.CompAbrev == "RM") && (this._copias > 0))
			{
				fiscal.Reimprimir(this._copias);
			}			
			return true;
		}*/
		
		private void CierreImpresoraFiscal() 
		{
			if (_subActiva)
				//German 20100618
				fiscal.CerrarImpFis(fiscalItems);			
				//Fin German 20100618
		}

		private void ReporteDatos(ReporteFiscal rf)
		{		
			MensajeInt = "Nro. de reporte: " + rf.NroReporte;
			MensajeInt = "Ult. comp. A: " + rf.UltA;
			MensajeInt = "Ult. comp. B: " + rf.UltB;
			MensajeInt = "Total ventas: " + rf.MontoVentas.ToString();
			decimal neto = rf.MontoVentas - rf.MontoIVA;
			MensajeInt = "Total neto: " + neto.ToString();
			MensajeInt = "Total IVA: " + rf.MontoIVA.ToString();
		}
		private void ChequearDatosCabecera() 
		{
			ConfiguracionImpresora ci = new ConfiguracionImpresora();
			fiscal.ObtenerConfiguracion(ci);						
			if (ci.Cabecera1.Trim() == String.Empty && ci.Cabecera2.Trim() == String.Empty)
			{
				string direccion = Variables.GetValueString("Fiscal.Empresa.Direccion");
				if (direccion.Trim() == String.Empty)
				{
					direccion = Variables.GetValueString("Sistema.DireccionEmpresa");
				}
				string telefono = Variables.GetValueString("Fiscal.Empresa.Telefono");
				if (telefono.Trim() == String.Empty)
				{
					telefono = Variables.GetValueString("Sistema.TelefonosEmpresa");
				}	
				
				ci.Cabecera1 = direccion;
				ci.Cabecera2 = telefono;
				fiscal.CargarConfiguracion(ci);
			}			
		}

		private byte GetTipoCliente() 
		{
			switch(_datosPreparados.CuentaCategoriaImpositiva)
			{
				case "RI": 
					return 1;
					break;
				case "EX":
					return 3;
					break;
				case "CF":
					return 5;
					break;
				case "MO":
					return 7;
					break;
				default : 
					return 0;
					break;						
			}			
		}

		private byte GetTipoDocumento() 
		{						
			//byte TipoDocumento = 0;
			if (this._datosPreparados.CuentaTipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.CUIT"))  
			{return 1;}

			if (this._datosPreparados.CuentaTipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.LE"))
			{return 2;}

			if (this._datosPreparados.CuentaTipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.LC")) 
			{return 3;}

			if (this._datosPreparados.CuentaTipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.DNI")) 
			{return 4;}
			
			if (this._datosPreparados.CuentaTipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.Pasaporte"))  
			{return 5;}

			if (this._datosPreparados.CuentaTipoDocumento == Variables.GetValueString("Cuentas.TipoDocumento.CI"))  
			{return 6;}
			
			return 0;
		}


		private byte GetTipoComprobante(string TipoComprobante) 
		{			
			switch (TipoComprobante)
			{
				case "FA": return 1;
					break;
				case "ND": return 2;
					break;
				case "NC": return 3;
					break;
				case "TI": return 4;
					break;
				case "TF": return 16;
					break;
				case "TINC": return 17;
					break;
				case "RM": return 7;
					break;
				case "RX": return 6;
					break;
				default: 
					return 0;
			}			
		}

		private decimal GetIVA(ItemComprobante itemComp) 			
		{			
			string cadenaIVAs = Variables.GetValueString("Impuestos.IVA");
			string[] IVAs = cadenaIVAs.Split(',');

			foreach (string IVA in IVAs) 
			{
				decimal valor = itemComp.GetAlicuota(IVA);
				if (valor != 0) 
				{
					return valor;
				}
			}
			return 0;
		}
		private void GrabaComprobanteAnulado() 
		{						
			string Numero = fiscal.CompClaseAnulado.ToString() + '-' + fiscal.CompPuntoDeVenta + '-' + fiscal.CompNumeroH;
			MensajeInt = Numero;
			string TipoComprobanteDestino = String.Empty;
			if (fiscal.CompClase == 'A') 
			{TipoComprobanteDestino = Variables.GetValue("Momentos.Anular.Comprobantes.A").ToString();}
			else 
			{TipoComprobanteDestino = Variables.GetValue("Momentos.Anular.Comprobantes.B").ToString();}					

			string Momento = businessrules.tsy_TiposDeComprobantes.GetByPk(TipoComprobanteDestino).Momento;													
			//ComprobanteDeVenta comprobante = new ComprobanteDeVenta("NEW", Momento, null, TipoComprobanteDestino);													
			ComprobanteDeVenta comprobante = new ComprobanteDeVenta();			
			comprobante.SetProcessManagerParent(_processManager);
			comprobante.SetTaskName(_taskName);
			comprobante.Init();
			comprobante.Anular(Numero, TipoComprobanteDestino);
		}
		/*
				si se lo usa al get saldo posterior _ctacte.GEtSaldoPosterior("momentos.procesoCuentaCorrienteCliente.Comprobantes")
				private string GetTextoSaldo() 
				{
					string resultado = "";
					CuentaCorriente _ctacte = Factory.GetCuentaCorriente(this._datosPreparados.CuentaIdCuenta);
					_ctacte.GetSaldoPosterior("");

					decimal saldo = Decimal.Round(_ctacte.SaldoPosterior,2);
			
					string TextoSaldo = Variables.GetValueString("Fiscal.Comprobante.Saldo").ToUpper();			
					string TextoSaldoAcreedor = "A la fecha del presente comprobante el cliente un saldo acreedor de $";
					string SinSaldo = Variables.GetValueString("Fiscal.Comprobante.SinSaldo").ToUpper();		
					bool ImprimeSaldo = Variables.GetValueBool("Fiscal.Comprobante.Momentos." + this._datosPreparados.Momento + ".ImprimirSaldo");
			
			
					if (ImprimeSaldo) 
					{
						if (saldo < 0) 
						{resultado = TextoSaldo + (Math.Abs(saldo)).ToString(); }
						else 
						{
							if (saldo > 0) 
							{
								resultado = TextoSaldoAcreedor + (Math.Abs(saldo)).ToString();
							}
							else 
							{resultado = SinSaldo;}					
						}
					}
					else 
					{resultado = "";}

					return resultado;
				}
		*/
		private void GetNumAsocs(ref string NumAsoc1, ref string NumAsoc2, ref string NumAsoc3, ref string NumAsoc4, ref string NumAsoc5) 
		{
			int CantAsoc = (this._datosPreparados.ComprobantesAsociados.Count <= fiscal.LinNumAsocCant ? this._datosPreparados.ComprobantesAsociados.Count: fiscal.LinNumAsocCant);
			
			if (fiscal.CompAbrev == "NC" || fiscal.CompAbrev == "RM" || fiscal.CompAbrev == "TINC") 
			{
				if (CantAsoc == 0) 
				{
					NumAsoc1 = "1"; //Busco el comprobante asociado como variable auxiliar si no la tengo como ComprobanteAsociado
					foreach(VariableAuxiliar var in _datosPreparados.VariablesDeUsuario) 
					{
						if (var.Id == Variables.GetValueString("Fiscal.VariablesAuxiliares.ComprobanteAsociado"))
						{							
							NumAsoc1 = var.Valor;							
						}
					}

					//NumAsoc2 = "1";
				}
				for (int i = 0; i < CantAsoc; i++)  			
				{
					//string tituloAsoc = "Comp.Asoc.: ";
					string tituloAsoc = "";
					string numAsoc = this._datosPreparados.ComprobantesAsociados[i].ToString();

					switch(i)  
					{
						case 0:
							NumAsoc1 = tituloAsoc + numAsoc;
							break;
						case 1:
							NumAsoc2 = tituloAsoc + numAsoc;
							break;
						case 2:
							NumAsoc3 = tituloAsoc + numAsoc;
							break;
						case 3:
							NumAsoc4 = tituloAsoc + numAsoc;
							break;					
						case 4:
							NumAsoc5 = tituloAsoc + numAsoc;
							break;	
					}
				}//end for
			}//end if
		}

		private bool ClienteVacio(string nombre) 
		{
			bool result = nombre == null || nombre == "0" || nombre.Trim() == String.Empty ||
				nombre.Replace("-","").Trim() == String.Empty;
			return result;
		}	
		private void GrabarClase()
		{
			mz.erp.commontypes.data.sy_VariablesPuestosDataset.sy_VariablesPuestosRow row = businessrules.sy_VariablesPuestos.GetByPk("Fiscal.UltimoComprobante.Clase", Security.IdEmpresa, Security.IdSucursal, Security.IdPuesto);						
			if (row != null)
			{
				row.Valor = fiscal.CompClase.ToString();
				businessrules.sy_VariablesPuestos.Update(row);
			}
		}
		private void GetClase() 
		{
			mz.erp.commontypes.data.sy_VariablesPuestosDataset.sy_VariablesPuestosRow row = businessrules.sy_VariablesPuestos.GetByPk("Fiscal.UltimoComprobante.Clase", Security.IdEmpresa, Security.IdSucursal, Security.IdPuesto);
			if (row != null) 
			{
				fiscal.CompClaseAnulado = Convert.ToChar(row.Valor);
			}
			else 
			{
				fiscal.CompClaseAnulado = '-';
			}
		}
	}
}

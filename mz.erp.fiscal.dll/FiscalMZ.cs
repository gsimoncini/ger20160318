//German 20110315 - Tarea 0000038//16-2-05 Agregar número de comprobante luego de la cancelación.
//16-2-05 Probar funcionamiento de ticket factura
//Ver descuentos/recargos en general

using System;
using FiscalPrinterLib;
using System.Reflection;
using System.Collections;
using FiscalMZ;


namespace ParaisoFiscal
{
	/// <summary>
	/// Descripción breve de Class1.
	/// </summary>

	public class ReporteFiscal 
	{
		public ReporteFiscal() 
		{
		}
		internal string _nroReporte;
		public string NroReporte{get {return _nroReporte;}}

		internal decimal _nroCanceladosDF = 0;
		public decimal NroCanceladosDF{get {return _nroCanceladosDF;}}

		internal decimal _nroEmitidosDNFH = 0;
		public decimal NroEmitidosDNFH{get {return _nroEmitidosDNFH;}}

		internal decimal _nroEmitidosDNF = 0;
		public decimal NroEmitidosDNF{get {return _nroEmitidosDNF;}}

		internal decimal _nroEmitidosDF = 0;
		public decimal NroEmitidosDF{get {return _nroEmitidosDF;}}

		internal string _ultA = "0";
		public string UltA{get {return _ultA;}}

		internal string _ultB = "0";
		public string UltB{get {return _ultB;}}

		internal string _ultRemito = "0";
		public string UltRemito{get {return _ultRemito;}}

		internal decimal _montoVentas = 0;
		public decimal MontoVentas{get {return _montoVentas;}}

		internal decimal _montoIVA = 0;
		public decimal MontoIVA{get {return _montoIVA;}}

		internal decimal _montoII = 0;
		public decimal MontoII{get {return _montoII;}}

		internal decimal _montoPercep = 0;
		public decimal MontoPercep{get {return _montoPercep;}}

		internal decimal _montoIVANi = 0;
		public decimal MontoIVANi{get {return _montoIVANi;}}

		internal string _ultNCA = "0";
		public string UltNCA{get {return _ultNCA;}}

		internal string _ultNCB = "0";
		public string UltNCB{get {return _ultNCB;}}

		internal decimal _montoNC = 0;
		public decimal MontoNC{get {return _montoNC;}}

		internal decimal _montoIVANC = 0;
		public decimal MontoIVANC{get {return _montoIVANC;}}

		internal decimal _montoIINC = 0;
		public decimal MontoIINC{get {return _montoIINC;}}

		internal decimal _montoPercepNC = 0;
		public decimal MontoPercepNC{get {return _montoPercepNC;}}

		internal decimal _montoIVANiNC = 0;
		public decimal MontoIVANiNC{get {return _montoIVANiNC;}}

		internal string _sucursal = String.Empty;
		public string Sucursal{get {return _sucursal;}}

		internal DateTime _fecha = DateTime.Now;
		public DateTime Fecha {get {return _fecha;}}		
	}

	public class SubTotalFiscal
	{
		public SubTotalFiscal()
		{
			_cantidad = 0;
			_total = 0;
			_iva = 0;
			_pagado = 0;
			_ivaNI = 0;
			_neto = 0;
			_saldo = 0;
		}
		internal decimal _cantidad;
		public decimal Cantidad	{get {return _cantidad;}}

		internal decimal _total;
		public decimal Total{get {return _total;}}

		internal decimal _iva;
		public decimal Iva{get {return _iva;}}

		internal decimal _pagado;
		public decimal Pagado{get {return _pagado;}}

		internal decimal _saldo;
		public decimal Saldo {get {return _total - _pagado;}}

		internal decimal _ivaNI;
		public decimal IvaNI{get {return _ivaNI;}}

		internal decimal _neto;
		public decimal Neto{get {return _neto;}}		
	}
	public class ItemFiscal 
	{
		public ItemFiscal() 
		{
			_descripcion = "-";
			_textoFiscal = String.Empty;
			_descripcionDif = String.Empty;
			_impuestosInternos = 0;
			_tasaAjusteVariable = 0;
			_montoDif = 0;
			_diferencia = ' ';
			_signo = true;
		}
		private string _textoFiscal;
		public string TextoFiscal
		{
			get {return _textoFiscal;}
			set {_textoFiscal = value;}
		}

		private string _descripcion;
		public string Descripcion
		{
			get {return _descripcion;}
			set {_descripcion = value;}
		}

		private string _descripcionDif;
		public string DescripcionDif
		{
			get {return _descripcionDif;}
			set {_descripcionDif = value;}
		}

		private decimal _cantidad;
		public decimal Cantidad
		{
			get {return _cantidad;}
			set {_cantidad = value;}
		}	

		private decimal _monto;
		public decimal Monto
		{
			get {return _monto;}
			set {_monto = value;}
		}

		private decimal _total;
		public decimal Total
		{
			get {return _cantidad * (_monto + _monto * _iva / 100) ;}
		}

		private decimal _montoIva;
		public decimal MontoIVA
		{
			get {return _montoIva;}
			set {_montoIva = value;}
		}

		private decimal _iva;
		public decimal IVA
		{
			get {return _iva;}
			set {_iva = value;}
		}

		private decimal _impuestosInternos;
		public decimal ImpuestosInternos
		{
			get {return _impuestosInternos;}
			set {_impuestosInternos = value;}
		}

		private decimal _tasaAjusteVariable;
		public decimal TasaAjusteVariable
		{
			get {return _tasaAjusteVariable;}
			set {_tasaAjusteVariable = value;}
		}

		private decimal _montoDif;
		public decimal MontoDif
		{
			get {return _montoDif;}
			set {_montoDif = value;}
		}

		private char _diferencia;
		public char Diferencia
		{
			get {return _diferencia;}
			set {_diferencia = value;}
		}

		private bool _signo;
		public bool Signo
		{
			get {return _signo;}
			set {_signo = value;}
		}

        /* Silvina 20110704 - Tarea 0000136 */
        private bool _permiteCambio = true;
		public bool PermiteCambio
		{
			get {return _permiteCambio;}
			set {_permiteCambio = value;}
		}
        /* Fin Silvina 20110704 - Tarea 0000136 */

	}

	public class ClienteFiscal
	{
		public ClienteFiscal(byte CodImpFis)
		{
			_nombre = String.Empty;
			_direccion = String.Empty;			
			_docTipo = 4;
			_docNumero = String.Empty;			
			_condIVA = 5;
			_grupoImpFis = Tablas.VerGrupo(CodImpFis);			
		}

		private byte _grupoImpFis;
		private string _nombre;
		private string _direccion;		
		private byte _docTipo;
		private string _docNumero;
		private byte _condIVA;

		public string Nombre
		{
			get {return _nombre;}
			set 
			{				
				_nombre = Rutinas.ArregloCadena(_grupoImpFis, value);
			}
		}
		public string Direccion
		{
			get {return _direccion;}
			set
			{ 
				_direccion = Rutinas.ArregloCadena(_grupoImpFis, value);
			}
		}

		public byte DocTipo
		{
			get {return _docTipo;}
			set {_docTipo = value;}
		}

		public string DocNumero
		{
			get {return _docNumero;}
			set {_docNumero = value;}
		}

		public byte CondIVA
		{
			get {return _condIVA;}
			set {_condIVA = value;}
		}
	}

	public class ConfiguracionImpresora 
	{
		public ConfiguracionImpresora() 
		{
		}
		internal string _cabecera1 = String.Empty;
		public string Cabecera1 
		{
			get {return _cabecera1;}
			set {_cabecera1 = value;}
		}

		internal string _cabecera2 = String.Empty;
		public string Cabecera2 
		{
			get {return _cabecera2;}
			set {_cabecera2 = value;}
		}
	}

	public class FiscalMZ
	{		
		public FiscalMZ()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//			
			Inicializar();
		}

		#region VariablesPrivadas
		private byte _grupoImpFis;		
		private byte _impFisCod;
		private byte _compCodigo;
		private byte _cliCodigo;		
		private byte _itemsImpresosOK = 0;
		private ClienteFiscal _cliente;
		
		//private HASARClass ImpFis1 = null;
        private HASARClass ImpFis1 = ImpFis.Hasar;
		private AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2 = new AxEPSON_Impresora_Fiscal.AxPrinterFiscal();
		
		private Caracteristicas ImpFisCaract = new Caracteristicas();
		decimal[,] matIVA = new  decimal[,] {{-1,0}, {-1,0}, {-1,0}, {-1,0}, {-1,0}};
	
		#endregion

		#region Propiedades		
		
		private string _mensaje;
		public string Mensaje {get {return Tablas.EstadoImpfis(_codMensaje);}}		

		public event EventHandler OnChangeEstado;

		private byte _codMensaje;

		private byte CodMensajeInt
		{
			set 
			{
				_codMensaje = value;
				if (OnChangeEstado != null) 
				{
					OnChangeEstado( this , new System.EventArgs());
				}				
			}
		}

		public byte CodMensaje 
		{ 
			get 
			{
				return _codMensaje;
			}
		}
		
		private bool _estadoCompAbierto;	
		public bool EstadoCompAbierto { get {return _estadoCompAbierto;}}

		private string _nombre;
		public string Nombre { get {return _nombre;}}		
		
		
		//CLIENTE
		private bool _soportaCliente;
		public bool SoportaCliente { get {return _soportaCliente;}}		

		private string _cliTipo;
		public string CliTipo { get {return _cliTipo;}}		

		//CARACTERISTICAS DE LA IMP.FIS.
		private byte _linVarCant;		
		public byte LinVarCant { get {return _linVarCant;}}
		private byte _linVarLong;		
		public byte LinVarLong { get {return _linVarLong;}}
		private byte _linNumAsocCant;
		public byte LinNumAsocCant { get {return _linNumAsocCant;}}
		private byte _linNumAsocLong;
		public byte LinNumAsocLong { get {return _linNumAsocLong;}}
		private byte _linTextoCant; //cantidad de líneas para texto fiscal
		public byte LinTextoCant { get {return _linTextoCant;}} 
		private byte _linTextoLong;
		public byte LinTextoLong { get {return _linTextoLong;}}
		private byte _linItemLong; //longitud para texto fiscal
		public byte LinItemLong { get {return _linItemLong;}}
		private byte _linPieCant;				
		public byte LinPieCant { get {return _linPieCant;}}

		private byte _linPagos; //Cantidad de formas de pagos para el comprobante incluido Cta/cte.
		public byte LinPagos { get {return _linPagos;}}
		private int _unidadesXArt; //Cantidad de unidades por artículo máximo
		public int UnidadesXArt { get {return _unidadesXArt;}}
		private bool _calcRboInterno; // Si la impresora fiscal es la que da el recibo interno.
		public bool CalcRboInterno { get {return _calcRboInterno;}}

		private byte _cantidadEnteros;
		public byte CantidadEnteros { get {return _cantidadEnteros;}}
		private byte _cantidadDecimales;
		public byte CantidadDecimales { get {return _cantidadDecimales;}}
		private sbyte _preciosEnteros;
		public sbyte PreciosEnteros { get {return _preciosEnteros;}}
		private byte _preciosDecimales;
		public byte PreciosDecimales { get {return _preciosDecimales;}}

        //German 20110311 - Tarea 0000077
        private bool _precioBase;
        public bool PrecioBase 
        {
            get { return _precioBase; }
            set { _precioBase = value; }
        }
        //Fin German 20110311 - Tarea 0000077
		private sbyte _impIntDecimales;
		public sbyte ImpIntDecimales { get {return _impIntDecimales;}}
		private byte _tasasIVAxFact;
		public byte TasasIVAxFact { get {return _tasasIVAxFact;}}

		private byte _percepXFact;
		public byte PercepXFact { get {return _percepXFact;}}
		private bool _vuelto;
		public bool Vuelto { get {return _vuelto;}}	 
		//Vuelto: bool //true cuando se supera el monto total la diferencia se agrega con el mensaje "Su vuelto"
		//Si es false lo pagado se iguala al monto total

		private bool _direccOblig;
		public bool DireccOblig { get {return _direccOblig;}}	 
		
		private bool _soportaCliTipo;
		public bool SoportaCliTipo { get {return _soportaCliTipo;}}	 

		private bool _soportaCompTipo;
		public bool SoportaCompTipo { get {return _soportaCompTipo;}}	 		

		private bool _cuentaCorrienteAutomatica;
		public bool CuentaCorrienteAutomatica { get {return _cuentaCorrienteAutomatica;}}	

		private string _compPuntoDeVenta;
		public string CompPuntoDeVenta 
		{
			get {return _compPuntoDeVenta;}
			set {_compPuntoDeVenta = value;}
		}

		private string _estadoFiscal;
		public string EstadoFiscal
		{ 
			get
			{
				try 
				{
					if (_estadoFiscal == null) 
					{
						return " ";
					}
					else 
					{
						return _estadoFiscal;
					}					
				}
				catch 
				{
					return " ";
				}
			}
		}	

		private string _compNumeroD;
		public string CompNumeroD { get {return _compNumeroD;}
            /* Silvina 20110704 - Tarea 0000136 */
            set { _compNumeroD = value; }
            /* Fin Silvina 20110704 - Tarea 0000136 */
        }		

		private string _compNumeroH;
		public string CompNumeroH { get {return _compNumeroH;}}

		private byte _compCodInterno;
		//public byte CompCodInterno { get {return _compCodInterno;}} //Codificación interno de tipo de comprobante de las OCX.

		private string _compNombre;
		public string CompNombre { get {return _compNombre;}}	 

		private string _compAbrev;
		public string CompAbrev { get {return _compAbrev;}}	 	
	
		private char _compClase;
		public char CompClase { get {return _compClase;}
            /* Silvina 20110704 - Tarea 0000136 */
            set {_compClase = value;}
            /* Fin Silvina 20110704 - Tarea 0000136 */
        }	

		private char _compClaseAnulado;
		public char CompClaseAnulado 
		{ 
			get {return _compClaseAnulado;}
			set { _compClaseAnulado = value;}
		}	 		

		private string _linVar1 = "";
		public string LinVar1 { set {_linVar1 = value;}}	 	

		private string _linVar2 = "";
		public string LinVar2 { set {_linVar2 = value;}}	 	

		private string _linVar3 = "";
		public string LinVar3 { set {_linVar3 = value;}}	 	

		private string _linVar4 = "";
		public string LinVar4 { set {_linVar4 = value;}}	 	

		private string _linVar5 = "";
		public string LinVar5 { set {_linVar5 = value;}}	 	

		private string _linVar6 = "";
		public string LinVar6 { set {_linVar6 = value;}}	 	

		private string _linVar7 = "";
		public string LinVar7 { set {_linVar7 = value;}}	 	

		private string _linPie1 = "";
		public string LinPie1 
		{
			get {return _linPie1;}
			set {_linPie1 = value;}
		}	 	

		private string _linPie2 = "";
		public string LinPie2 
		{
			get {return _linPie2;}
			set {_linPie2 = value;}
		}	 	

		private string _linPie3 = "";
		public string LinPie3
		{
			get {return _linPie3;}
			set {_linPie3 = value;}
		}	 	

		private string _linPie4 = "";
		public string LinPie4
		{
			get {return _linPie4;}
			set {_linPie4 = value;}
		}	

		private string _numAsoc1 = string.Empty;
		public string NumAsoc1 { set {_numAsoc1 = value;}}	 	

		private string _numAsoc2 = string.Empty;
		public string NumAsoc2 { set {_numAsoc2 = value;}}	 	

		private string _numAsoc3 = string.Empty;
		public string NumAsoc3 { set {_numAsoc3 = value;}}	 	

		private string _numAsoc4 = string.Empty;
		public string NumAsoc4 { set {_numAsoc4 = value;}}	 	

		private ulong _nroInterno;
		public ulong NroInterno { set {_nroInterno = value;}}

		private bool _descuentoEnItem;
		public bool DescuentoEnItem {set {_descuentoEnItem = value;}}

		private string _tipoLetra = "12";
		public string TipoLetra {set {_tipoLetra = value;}}

		private bool _informacionAdicional = false;
		public bool InformacionAdicional {set {_informacionAdicional = value;}}

		private bool _invertirCantidadMonto = false;
		public bool InvertirCantidadMonto 
		{
			set {_invertirCantidadMonto = value;}
			get {return _invertirCantidadMonto;}
		}

		private long _redondeoPrecio = 2;
		public long RedondeoPrecio 
		{
			set {_redondeoPrecio = value;}
			get {return _redondeoPrecio;}
		}

		private long _redondeoImpuesto = 4;
		public long RedondeoImpuesto 
		{
			set {_redondeoImpuesto = value;}
			get {return _redondeoImpuesto;}
		}

		private byte _copias = 1;
		public byte Copias 
		{
			set {_copias = value;}
			get {return _copias;}
		}

		private bool _necesitaCierre = false;
		public bool NecesitaCierre {get {return _necesitaCierre;}}

        /* Silvina 20100713 - Tarea 795 */

		private bool _imprimeTicketDeCambio = false;
		public bool ImprimeTicketDeCambio {
			get {return _imprimeTicketDeCambio;}
			set {_imprimeTicketDeCambio = value;}
		}

		private string _descripcionAdicionalTicketDeCambio = String.Empty;
		public string DescripcionAdicionalTicketDeCambio {
			get {return _descripcionAdicionalTicketDeCambio;}
			set {_descripcionAdicionalTicketDeCambio = value;}
		}

		/* Fin Silvina */
		#endregion

		private void Inicializar()
		{											
			_estadoCompAbierto = false;
		}

		public void Prueba() 
		{								
			Rutinas.IVALimpiarMat(matIVA);
			Rutinas.IVAIncluir(matIVA, 21, 100);			
			Rutinas.IVACalcDifGral(matIVA, 50);
		}

		public bool VerOpcImpFis(byte ImpFisCod, byte CompCodigo, byte CliCodigo)
		{				
			CodMensajeInt = 220;
			_impFisCod = ImpFisCod;
			_cliCodigo = CliCodigo;
			_compCodigo = CompCodigo;
			_grupoImpFis = Tablas.VerGrupo(ImpFisCod);

			if (_grupoImpFis == 0) { return false;}	
			if (! ImpFisCaract.Inicializar(_grupoImpFis, _impFisCod, _compCodigo, _cliCodigo) ) {return false;}
		
			_nombre = ImpFisCaract.Nombre;
			_compNombre = ImpFisCaract.CompNombre;

			_soportaCliente = ImpFisCaract.SoportaCliTipo;
			_cliTipo = ImpFisCaract.CliTipo;

			_soportaCompTipo = ImpFisCaract.SoportaCompTipo;
			_cuentaCorrienteAutomatica = ImpFisCaract.CuentaCorrienteAutomatica;

			_linVarCant = ImpFisCaract.LinVarCant;
			_linVarLong = ImpFisCaract.LinVarLong;
			_linNumAsocCant = ImpFisCaract.LinNumAsocCant;
			_linNumAsocLong = ImpFisCaract.LinNumAsocLong;
			_linTextoCant = ImpFisCaract.LinTextoCant;
			_linTextoLong = ImpFisCaract.LinTextoLong;
			_linItemLong = ImpFisCaract.LinItemLong;
			_linPieCant = ImpFisCaract.LinPieCant;
			_linPagos =  ImpFisCaract.LinPagos;
			_unidadesXArt = ImpFisCaract.UnidadesXArt;
			_calcRboInterno = ImpFisCaract.CalcRboInterno;
			_cantidadEnteros = ImpFisCaract.CantidadEnteros;
			_cantidadDecimales = ImpFisCaract.CantidadDecimales;
			_preciosEnteros = ImpFisCaract.PreciosEnteros;
			_preciosDecimales = ImpFisCaract.PreciosDecimales;
			_impIntDecimales = ImpFisCaract.ImpIntDecimales;
			_tasasIVAxFact = ImpFisCaract.TasasIVAxFact;
			_percepXFact = ImpFisCaract.PercepXFact;
			_vuelto = ImpFisCaract.Vuelto;
			_direccOblig = ImpFisCaract.DireccOblig;
			_cliTipo = ImpFisCaract.CliTipo;
			_soportaCliTipo = ImpFisCaract.SoportaCliTipo;
			_soportaCompTipo = ImpFisCaract.SoportaCompTipo;
			_compCodInterno = ImpFisCaract.CompCodInterno;
			_compNombre =  ImpFisCaract.CompNombre;		
			_compAbrev = ImpFisCaract.CompAbrev;				

			_compPuntoDeVenta = String.Empty;
			
			if (_cliCodigo == 1 || _cliCodigo == 2) 
			{ _compClase = 'A';	}
			else 
			{_compClase = 'B'; }		
			
			return true;
		}	

		public bool AbrirImpFis(byte Puerto, int Velocidad)
		{
			_mensaje = string.Empty;			
			CodMensajeInt = 221;
			
			switch (_grupoImpFis)
			{
				case 1:
					try 
					{						
						ImpFis1.Puerto = Puerto;            																					
						ImpFis1.Modelo = Tablas.ObtenerModelo(_impFisCod);						
						ImpFis1.DescripcionesLargas = false;
                        //German 20110311 - Tarea 0000077
                        //ImpFis1.PrecioBase = true;
                        ImpFis1.PrecioBase = _precioBase;
                        //Fin German 20110311 - Tarea 0000077
						ImpFis1.EventosIndividuales = true;
						ImpFis1.kIVA = false;
						ImpFis1.ImpuestoInternoFijo = true;
						//ImpFis1.ImpuestoInternoPorMonto = true;
						ImpFis1.UsarASCII = false;						
						AbrirImpFisInt(ImpFis1, Puerto, Velocidad);								
						if (AbrirImpFisIntCtrl(ImpFis1) == false) 
						{return false;}
						break;
					}
					catch
					{
						CodMensajeInt = 1;//Se da cuando la impre está apagada o el puerto ya estaba abierto
						return false;
					}					
				case 2:
					try 
					{								
						ImpFis2.CreateControl();						
						ImpFis2.MessagesOn = _informacionAdicional;
						ImpFis2.PortNumber = Puerto;
						if (Velocidad == 0) 
						{ImpFis2.BaudRate = ImpFisCaract.Velocidad.ToString();}
						else
						{ImpFis2.BaudRate = Velocidad.ToString();}
						
						if (AbrirImpFisIntCtrl(ImpFis2) == false) 
						{return false;}
						break;
					}
					catch (Exception e)
					{
						CodMensajeInt = 1;
						return false;
					}					

				default:
					CodMensajeInt = 2;
					return false;					
			}
			CodMensajeInt = 200;
			return true;
		}		

		public bool AbrirComp(byte CompCodigo, ulong NroComprobante, ClienteFiscal clifis)
		{
			CodMensajeInt = 222;
			_compCodigo = CompCodigo;
			_itemsImpresosOK = 0;
			//_nroComprobante = NroComprobante;						

			if (CompCodigo==5||CompCodigo==9||CompCodigo==10||CompCodigo==11||CompCodigo==12||CompCodigo==13)
			{			
				CodMensajeInt = 22;//Comprobantes no contemplados aún.
				return false;
			}

			try 
			{
				_cliente = clifis;
				switch (_grupoImpFis) 
				{
					case 1:										
						if (AbrirCompInt(ImpFis1) == false)
						{return false;}
						else 
						{break;}
					case 2:																
						if (AbrirCompInt(ImpFis2) == false)
						{return false;}
						else 
						{break;}
					default:
						CodMensajeInt = 23;
						return false;
				}
			}
			catch 
			{
				CodMensajeInt = 21;
				return false;
			}

			CodMensajeInt = 201; 
			return true;
		
		} //Fin de AbrirComp

		public bool GrabarItem(ItemFiscal item)			
		{		
			ItemFiscal item2 = new ItemFiscal();			
			item2.TextoFiscal = item.TextoFiscal;					
			item2.Descripcion = item.Descripcion.PadRight(_linTextoLong);
			item2.DescripcionDif = item.DescripcionDif;
			item2.Cantidad = item.Cantidad;
			item2.Monto = item.Monto;
			item2.IVA = item.IVA;
			item2.MontoIVA = item.Monto * item.IVA / 100;
			item2.ImpuestosInternos = item.ImpuestosInternos;
			item2.TasaAjusteVariable = item.TasaAjusteVariable;
			item2.MontoDif = item.MontoDif;
			item2.Diferencia = item.Diferencia;
			item2.Signo = item.Signo;




				
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (GrabarItemInt(ImpFis1, item2) == false)
						{return false;}
						else 
						{break;}
					case 2:

                    if (GrabarItemInt(ImpFis2, item2) == false)
                    {return false;}
                    else 
                    {break;}

                    default:
						CodMensajeInt = 44;
						return false;
				}						
			}
			catch 
			{
				CodMensajeInt = 45;
				return false;
			}

			CodMensajeInt = 202;
			return true;
		}

        //German 20120606 - Tarea 0000348
        public byte GrupoImpFis
        {
            get
            {
                return _grupoImpFis;
            }
        }
        //Fin German 20120606 - Tarea 0000348
	
		public bool GrabarDesctoGral(string Descripcion, decimal Monto, char Diferencia)
		{
			string DifNombre = (Diferencia == 'R' ? "recargo": "descuento");
            //German 20120131 - Tarea 0000269
            /*
			if (Monto <= 0) 
			{
				CodMensajeInt = (byte) (Diferencia == 'R' ? 61: 60);
				return false;
			}
            */
            //German 20120131 - Tarea 0000269
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (GrabarDesctoGralInt(ImpFis1, Descripcion, Monto, Diferencia) == false)
						{return false;}
						else 
						{break;}
					case 2:
                        //German 20120131 - Tarea 0000269
                        
                        if (Monto <= 0) 
                        {
                            CodMensajeInt = (byte) (Diferencia == 'R' ? 61: 60);
                            return false;
                        }
                        
                        //German 20120131 - Tarea 0000269
						if (GrabarDesctoGralInt(ImpFis2, Descripcion, Monto, Diferencia) == false)
						{return false;}
						else 
						{break;}
					default:
						CodMensajeInt = 67;
						return false;
				}
			}
			catch 
			{
				CodMensajeInt = 62;
				return false;
			}

			CodMensajeInt = (byte) (Diferencia == 'R' ? 210 : 203);			
			return true;			
		}

		public bool GrabarPago(string Descripcion, decimal Monto)
		{
			if (Monto <= 0) 
			{
				CodMensajeInt = 100;
				return false;
			}
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (GrabarPagoInt(ImpFis1, Descripcion, Monto) == false)
						{return false;}
						else 
						{break;}
					case 2:
						if (GrabarPagoInt(ImpFis2, Descripcion, Monto) == false)
						{return false;}
						else 
						{break;}

					default:
						CodMensajeInt = 104;
						return false;
				}
			}
			catch 
			{
				CodMensajeInt = 101;
				return false;
			}

			CodMensajeInt = 205;
			return true;			
		}
						
		public bool GrabarObservacionPago(string Descripcion) 
		{
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (GrabarObservacionPagoInt(ImpFis1, Descripcion) == false)
						{return false;}
						else 
						{break;}
					/*case 2:
						if (GrabarObservacionPagoInt(ImpFis2, Descripcion) == false)
						{return false;}
						else 
						{break;}*/

					default:
						CodMensajeInt = 110;
						return false;
				}
			}
			catch 
			{
				CodMensajeInt = 110;
				return false;
			}

			CodMensajeInt = 215;
			return true;			

		}
		public bool Subtotal(SubTotalFiscal SubTotal)
		{
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (SubtotalInt(ImpFis1, SubTotal) == false)
						{return false;}
						else 
						{break;}
					case 2:
						if (SubtotalInt(ImpFis2, SubTotal) == false)
						{return false;}
						else 
						{break;}

					default:
						CodMensajeInt = 116;
						return false;
				}
			}
			catch 			
			{
				CodMensajeInt = 117;
				return false;
			}

			//CodMensajeInt = 211;
			return true;
		}

		public bool Percepcion(string Nombre, decimal Monto, decimal Iva) 
		{
			if (Monto == 0) 
			{
				CodMensajeInt = 80;
				return false;
			}

			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (PercepcionInt(ImpFis1, Nombre, Monto, Iva) == false)
						{return false;}
						else 
						{break;}
					case 2:
						if (PercepcionInt(ImpFis2, Nombre, Monto, Iva) == false)
						{return false;}
						else 
						{break;}

					default:
						CodMensajeInt = 85;
						return false;
				}
			}
			catch 
			{
				CodMensajeInt = 81;
				return false;
			}

			CodMensajeInt = (byte) (Iva == 0 ? 204: 212);
			return true;
		}
		
		public bool CerrarComp()
		{
			CodMensajeInt = 225;
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (CerrarCompInt(ImpFis1) == false)
						{return false;}
						else 
						{break;}
					case 2:
						if (CerrarCompInt(ImpFis2) == false)
						{return false;}
						else 
						{break;}

					default:
						CodMensajeInt = 123;
						return false;
				}
			}
			catch 
			{
				CodMensajeInt = 123;
				return false;
			}
			CodMensajeInt = 206;
			return true;
		}

		//German 20100618
		//public bool CerrarImpFis()
		public bool CerrarImpFis(ArrayList ItemsFiscal)
		//Fin German 20100618
		{
			switch (_grupoImpFis) 
			{
				case 1:
					if (CerrarImpFisInt(ImpFis1) == false)
					{return false;}
					else 
					{break;}
				case 2:
					//German 20100618
					//if (CerrarImpFisInt(ImpFis2) == false)
					if (CerrarImpFisInt(ImpFis2, ItemsFiscal) == false)
					//Fin German 20100618
					{return false;}
					else 
					{break;}

			}
			CodMensajeInt = 207;
			return true;
		} //Fin de CerrarComp
	
		public bool CancelarComp() 
		{
			if (_estadoCompAbierto) 
			{CodMensajeInt = 223;}
			else
			{CodMensajeInt = 224;}

			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (CancelarCompInt(ImpFis1) == false)
						{return false;}
						else 
						{break;}
					case 2:
						if (CancelarCompInt(ImpFis2) == false)
						{return false;}
						else 
						{break;}

					default:
						CodMensajeInt = 161;
						return false;
				}
			}
			catch 
			{
				CodMensajeInt = 162;
				return false;
			}

			CodMensajeInt = 208;
			return true;

		}
		
		public bool Reporte(char Tipo, ReporteFiscal Reporte) 
		{
			if (Tipo != 'X' & Tipo != 'Z') 
			{
				CodMensajeInt = 180;
				return false;
			}

			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (ReporteInt(ImpFis1, Tipo, Reporte) == false)
						{return false;}
						else 
						{break;}
					case 2:
						if (ReporteInt(ImpFis2, Tipo, Reporte) == false) 
						{return false;}
						else 
						{break;}
				}
			}
			catch 
			{
				CodMensajeInt = 182;
				return false;
			}

			CodMensajeInt = (byte) (Tipo == 'X' ? 209: 213);			
			return true;
		}

		public bool ReporteAuditoria(int Numero)
		{
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (ReporteAuditoriaInt(ImpFis1, Numero) == false)
						{return false;}
						else 
						{break;}
					//case 2:
						/*if (ReporteAuditoriaInt(ImpFis2, Tipo, Reporte) == false) 
						{return false;}
						else 						
						{break;}*/		
				}
			}		
			catch 
			{
				CodMensajeInt = 182;
				return false;
			}

			CodMensajeInt = 214;
			return true;
		}

		public bool ReporteAuditoria(int NumeroDesde, int NumeroHasta, bool ReporteGlobal)
		{
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (ReporteAuditoriaInt(ImpFis1, NumeroDesde, NumeroHasta, ReporteGlobal) == false)
						{return false;}
						else 
						{break;}
					//dcase 2:
						/*if (ReporteAuditoriaInt(ImpFis2, Tipo, Reporte) == false) 
						{return false;}
						else 						
						{break;}*/		
				}
			}		
			catch 
			{
				CodMensajeInt = 182;
				return false;
			}

			CodMensajeInt = 214;
			return true;
		}

		public bool ReporteAuditoria(DateTime Fecha)
		{
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (ReporteAuditoriaInt(ImpFis1, Fecha) == false)
						{return false;}
						else 
						{break;}
					//case 2:
						/*if (ReporteAuditoriaInt(ImpFis2, Tipo, Reporte) == false) 
						{return false;}
						else 						
						{break;}*/		
				}
			}		
			catch 
			{
				CodMensajeInt = 182;
				return false;
			}

			CodMensajeInt = 214;
			return true;
		}

		public bool ReporteAuditoria(DateTime FechaDesde, DateTime FechaHasta, bool ReporteGlobal)
		{
			try 
			{
				switch (_grupoImpFis) 
				{
					case 1:
						if (ReporteAuditoriaInt(ImpFis1, FechaDesde, FechaHasta, ReporteGlobal) == false)
						{return false;}
						else 
						{break;}
					//case 2:
						/*if (ReporteAuditoriaInt(ImpFis2, Tipo, Reporte) == false) 
						{return false;}
						else 						
						{break;}*/		
				}
			}		
			catch 
			{
				CodMensajeInt = 182;
				return false;
			}

			CodMensajeInt = 214;
			return true;
		}


		/*public bool Reimprimir(byte Copias)  
		{
			switch (_grupoImpFis) 
			{
				case 1:
					if (ReimprimirInt(ImpFis1, Copias) == false)
					{return false;}
					else 
					{break;}				
					return false;
					break;

			}
			//CodMensajeInt = 207;
			return true;

		}*/
		public bool ObtenerConfiguracion(ConfiguracionImpresora ci)
		{
			switch (_grupoImpFis)
			{
				case 1:
					return ObtenerConfiguracionInt(ImpFis1, ci);
					break;
			}
			return false;
		}
		public bool CargarConfiguracion(ConfiguracionImpresora ci)
		{
			switch (_grupoImpFis)
			{
				case 1:
					return CargarConfiguracionInt(ImpFis1, ci);
					break;
			}
			return false;
		}		
		#region Rutinas Delphi sin PuntoNetear

		#endregion


#region Sobrecargas de AbrirImpFisInt
		private void AbrirImpFisInt(HASARClass ImpFis1, byte Puerto, int Velocidad)
		{			
			if ( Velocidad > 0 ) 
			{
				ImpFis1.Baudios = Velocidad;										
				try 
				{ImpFis1.Comenzar();}
				catch
				{
					ImpFis1.ReComenzar();					
					CodMensajeInt = 200;	
					//ImpFis1.CancelarComprobanteFiscal();
					if (ImpFis1.EstadoControlador == 3) 
					{
						_estadoCompAbierto = true;
					}
				}
			} 
			else
			{												
				try 
				{ImpFis1.AutodetectarControlador(Puerto);}
				catch
				{ImpFis1.ReComenzar();}													
				CodMensajeInt = 200;				
			} 			 
		}		
		#endregion

#region Sobrecargas de AbrirImpFisIntCtrl
		private bool AbrirImpFisIntCtrl(HASARClass ImpFis1) 
		{

            string cont = ImpFis1.ObtenerVersionDelControlador();
            string cont2 = ImpFisCaract.Nombre;
            if (! Rutinas.ModeloCorrecto(ImpFisCaract.Nombre, ImpFis1.ObtenerVersionDelControlador(), _impFisCod))			
			{CodMensajeInt = 2;}
			else
			{
				switch (ImpFis1.EstadoControlador )
				{
					case 0:
						CodMensajeInt = 3;
						break;
					case 1:						
						CodMensajeInt = 4;
						break;
					case 2: //RECEIPT_NOT_OPENED
						if (ImpFis1.get_IndicadorImpresora(4) || ImpFis1.get_IndicadorImpresora(8) )
						{
							CodMensajeInt =  (ImpFis1.get_IndicadorImpresora(4)) ? CodMensajeInt = 5: CodMensajeInt = 6;
							return false;
						}
						else 
						{
							CodMensajeInt = 200;																					
							try 
							{
								ImpFis1.Enviar("s");
								_compPuntoDeVenta = ImpFis1.get_Respuesta(7);
							}
							catch
							{_compPuntoDeVenta = "xxxx";}
							return true;
						}
						//break;
					case 9:
						CodMensajeInt = 9;
						break;
					case 3:
					case 4:
					case 5:
					case 6:
					case 10:
					case 12:
					case 13:
					case 17:
						CodMensajeInt = 20;						
						try 
						{
							ImpFis1.Enviar("s");
							_compPuntoDeVenta = ImpFis1.get_Respuesta(7);
						}
						catch
						{_compPuntoDeVenta = "xxxx";}
						_estadoCompAbierto = true;
						break;
					default:
						CodMensajeInt = 7;						
						break;
				} //del switch				
			}
			return false;
		}
			
		private bool AbrirImpFisIntCtrl(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2)
		{			
			string aux = "P";
			string estado = String.Empty;
			bool Abrio;
			if (_impFisCod == 14) 
			{
				ImpFis2.Status(ref aux);
				if (ImpFis2.PrinterStatus != "" && ImpFis2.FiscalStatus != "") 
				{Abrio = true;}
				else 
				{Abrio = false;}
			}	
			else 
			{
				estado = Estados.EnEstado(ImpFis2.FiscalStatus, 8).ToString();
				if (ImpFis2.Status(ref aux))
				{ Abrio = true;}
				else //No pudo abrir la impresora fiscal
				{
					aux = "D";
					ImpFis2.Status(ref aux);
					CodMensajeInt = 7;
					_estadoFiscal = ImpFis2.FiscalStatus;					
					Abrio = false;
				}
				//_estadoFiscal = ImpFis2.FiscalStatus;				
			}

			if (Abrio) 
			{
				if (! Rutinas.ModeloCorrecto(ImpFisCaract.Nombre, ImpFis2.AnswerField_13, _impFisCod))			
				{
					CodMensajeInt = 2;
					_estadoFiscal = ImpFis2.FiscalStatus;
					return false;
				}
				if (Estados.EnEstado(ImpFis2.FiscalStatus, 26)) //Se fija si hay un comprobante abierto
				{
					_estadoCompAbierto = true;		
					_compNumeroD = UltNroComp(_grupoImpFis, ImpFis2, _compAbrev, _compClase, _nroInterno, 1);
				}

				if (Estados.EnEstado(ImpFis2.FiscalStatus, 8)) //Se fija si necesita un cierre de jornada
				{
					CodMensajeInt = 8;
					_necesitaCierre = true;
					return true;
				}				

				ArrayList controles = new ArrayList();
				controles.Add("9");//Se fija si está desfiscalizada				
				controles.Add("13");//Si hay problemas con la batería
				controles.Add("10");//Comando no válida para el estado fiscal
				controles.Add("11");//Memoria fiscal llena
				controles.Add("12");//Memoria fiscal casi llena
				bool resultado = false;				
				int i = 0;
				byte codigo = 0;
				while (resultado == false & i < controles.Count)
				{
					codigo = Convert.ToByte(controles[i]);
					resultado = Estados.EnEstado(ImpFis2.FiscalStatus, codigo);
					i++;
				}				
				if (resultado == true) 
				{
					CodMensajeInt = codigo;
					_estadoFiscal = ImpFis2.FiscalStatus;
					return false;
				}
			}			
			else 
			{
				return false;
			}
			return true;
		}
		#endregion

#region Sobrecargas de AbrirCompInt
		private bool AbrirCompInt(HASARClass ImpFis1) 
		{			
			if (_linVar1 == null) {_linVar1 = String.Empty;}
			if (_linVar2 == null) {_linVar2 = String.Empty;}
			if (_linVar3 == null) {_linVar3 = String.Empty;}
			if (_linVar4 == null) {_linVar4 = String.Empty;}
			if (_linVar5 == null) {_linVar5 = String.Empty;}
			if (_linVar6 == null) {_linVar6 = String.Empty;}
			if (_linVar7 == null) {_linVar7 = String.Empty;}
			if (_linPie1 == null) {_linPie1 = String.Empty;}
			if (_linPie2 == null) {_linPie2 = String.Empty;}
			if (_linPie3 == null) {_linPie3 = String.Empty;}
			if (_linPie4 == null) {_linPie4 = String.Empty;}
			if (_numAsoc1 == null) {_numAsoc1 = String.Empty;}
			if (_numAsoc2 == null) {_numAsoc2 = String.Empty;}			

			ImpFis1.set_Encabezado(3, _linVar1);
			ImpFis1.set_Encabezado(4, _linVar2);
			ImpFis1.set_Encabezado(5, _linVar3);
			ImpFis1.set_Encabezado(11, _linPie1);
			ImpFis1.set_Encabezado(12, _linPie2);
			ImpFis1.set_Encabezado(13, _linPie3);
			ImpFis1.set_Encabezado(14, _linPie4);				
				
			TiposDeDocumento td = new TiposDeDocumento();
			td = Tablas.ObtenerTipoDocumentoInt(_cliente.DocTipo);

			TiposDeResponsabilidades ci = new TiposDeResponsabilidades();
			ci = Tablas.ObtenerCliTipoInt(_cliente.CondIVA);					

			if (_cliente.Nombre.Trim() == "")
				_cliente.Nombre = "-";
				
			ImpFis1.DatosCliente(_cliente.Nombre, _cliente.DocNumero, td, ci, _cliente.Direccion);

			if (ImpFis1.get_IndicadorFiscal(16) & //Si es TRUE los datos del cliente son inválido
				(_cliente.CondIVA != 5 || _compAbrev == "NC") ) 
			{
				//Los datos del cliente son obligatorios para Cond. Iva que no son
				//consumidor final o para Notas de crédito
				CodMensajeInt = 24;					
				return false;
			}
				
			if (ImpFis1.EstadoControlador != 2)
			{
				CodMensajeInt = 20;
				return false;
			}

			//A P E R T U R A     D E     C O M P R O B A N T E S
			
			if (_numAsoc1 != String.Empty) //Información de comprobante o remito asociado					
			{     
                //German 20110225 - Tarea 0000077
				//ImpFis1.set_InformacionRemito(1, _numAsoc1);					
                ImpFis1.set_DocumentoDeReferencia(1, _numAsoc1);					
                //Fin German 20110225 - Tarea 0000077
				if (_numAsoc2 != String.Empty) 
				{
                    //German 20110225 - Tarea 0000077
                    //ImpFis1.set_InformacionRemito(2, _numAsoc2);
                    ImpFis1.set_DocumentoDeReferencia(2, _numAsoc2);
                    //Fin German 20110225 - Tarea 0000077
				}
			} //else ... //No permite la impresión de la segunda línea si no usa primero la primero
					
			//TiposDeDocumento td = new TiposDeDocumento();
			//td = Tablas.ObtenerTipoDocumentoInt(cliente.DocTipo);

			switch (_compCodigo) 
			{
				case 1:
				case 2:
				case 4:
					DocumentosFiscales df = new DocumentosFiscales();
					df = Tablas.ObtenerDocumentosFiscales(_compCodInterno);
                    //German 20110310 - Tarea 0000077
                    //ImpFis1.AbrirComprobanteFiscal(df);
                    ImpFis1.AbrirComprobanteFiscal(df);
                    //Fin German 20110310 - Tarea 0000077
					break;
				case 3:
				case 7:
				case 9:					
					DocumentosNoFiscales dnf = new DocumentosNoFiscales();
					dnf = Tablas.ObtenerDocumentosNOFiscales(_compCodInterno);
                    //German 20110225 - Tarea 0000077
					//ImpFis1.AbrirComprobanteNoFiscalHomologado(dnf, "M.Z. Informática S.A.");					
                    ImpFis1.AbrirDNFH(dnf, "M.Z. Informática S.A.");
                    //Fin German 20110225 - Tarea 0000077
					break;
				case 5:
				case 6:
					if (_nroInterno != 0) 
					{						
						DocumentosNoFiscales dnfRec = new DocumentosNoFiscales();
						dnfRec = Tablas.ObtenerDocumentosNOFiscales(_compCodInterno);
                        //German 20110225 - Tarea 0000077
						//ImpFis1.AbrirComprobanteNoFiscalHomologado(dnfRec, _nroInterno);
                        ImpFis1.AbrirDNFH(dnfRec, _nroInterno);
                        //Fin German 20110225 - Tarea 0000077
					}
					else
					{
						CodMensajeInt = 25;
						return false;
					}
					break;
			}

			switch (ImpFis1.EstadoControlador) 
			{
				case 2:
					CodMensajeInt = 28;
					return false;
					break;

					//FA,ND,RE,TI, NC, RM abierto
				case 3:
				case 5:
				case 13:
				case 20:				
					_compNumeroD = UltNroComp(_grupoImpFis, ImpFis1, _compAbrev, _compClase, _nroInterno, 1);					
					return true;
			}
						
			/*                
							3,5,13,20:
							begin
									NroComprobante:= uRutinas.UltNroComp(prvGrupoImpFis, prvCompAbrev, prvCompClase, prvNroInterno, 1);
									result:= true;
									if prvCompCodTipo = 6
									then prvMensaje:= '  OK ' + prvCompNombre
									else prvMensaje:= '  OK ' + prvCompNombre + ' ' + prvCompClase;
							end;
							else prvMensaje:= 'No se pudo abrir el comprobante. Error ' + inttostr(glImpFis1.EstadoControlador);
							end;  //del case de nº de estado controlador}
			//                if result = false then exit;
					end; //del case Grupo 1

			*/

				
			return true;

		}
		
		private bool AbrirCompInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2)
		{			
			if (_compClase == 'A') 
			{
				Rutinas.IVALimpiarMat(matIVA); //cuando abre el comprobante
			}
			//A P E R T U R A     D E     C O M P R O B A N T E S
			

			try 
			{
				string action = "S";
				string number = "11";
				string texto = Rutinas.ArregloCadena(_grupoImpFis, _linPie1);
				ImpFis2.SetGetHeaderTrailer(ref action, ref number, ref texto);

				number = "12";
				texto = Rutinas.ArregloCadena(_grupoImpFis, _linPie2);
				ImpFis2.SetGetHeaderTrailer(ref action, ref number, ref texto);

				number = "13";
				texto = Rutinas.ArregloCadena(_grupoImpFis, _linPie3);
				ImpFis2.SetGetHeaderTrailer(ref action, ref number, ref texto);	
			}
			catch (Exception e) 
			{
			}

			string auxPaperType = "C"; //C (continuo) S (suelto)
			string auxCompClase = _compClase.ToString(); //A, B, C            
			string auxInvoiceType = String.Empty;
			if (_compAbrev == "TF") 
			{ auxInvoiceType = "T";} 
			else 
			{ 
				switch (_compAbrev) 
				{
					case "FA": auxInvoiceType = "F";break;
					case "ND": auxInvoiceType = "D";break;
					case "NC": auxInvoiceType = "N";break;
					case "RM": 
						auxInvoiceType = "E";
						auxCompClase = "X";
						break;
					case "CO": auxInvoiceType = "C";break;
					case "RE": auxInvoiceType = "L";break;
					case "TINC": auxInvoiceType = "M";break;
				}				
			}			

            string auxCopias = _copias.ToString();
            string auxTipoForm =  "F";
            string auxTipoLetra = _tipoLetra;			
            string auxCondIvaV = "I";
			string auxBienUso = "N";
			string auxCondIvaC = String.Empty;
			string auxCabecera1 = Rutinas.ArregloCadena(_grupoImpFis, _cliente.Nombre);
			string auxCabecera2 = Rutinas.ArregloCadena(_grupoImpFis, _cliente.Direccion);
			string auxTipoDoc = String.Empty;

			switch (_cliCodigo) 
			{
				case 1: auxCondIvaC = "I"; break;
				case 2: auxCondIvaC = "R"; break;
				case 3: auxCondIvaC = "E"; break;
				case 4: auxCondIvaC = "N"; break;
				case 5: auxCondIvaC = "F"; break;
				case 6:
					auxBienUso = "B";
					auxCondIvaC = "R"; 
					break;
				case 7: auxCondIvaC = "M"; break;
				case 8: auxCondIvaC = "S"; break;				
			}

			switch (_cliente.DocTipo) 
			{
				case 1: auxTipoDoc = "CUIT"; break;
                case 2: auxTipoDoc = "LE"; break;
                case 3: auxTipoDoc = "LC"; break;
                case 4: auxTipoDoc = "DNI"; break;
                case 5: auxTipoDoc = "Pasap."; break;
                case 6: auxTipoDoc = "CI"; break;
                case 7: auxTipoDoc = "--"; break;
			}

			string auxNumDoc = _cliente.DocNumero;
			string auxCabecera3 = _linVar1;
			string auxCabecera4 = _linVar2;
			string auxCabecera5 = _linVar3;			
			string auxCabecera6 = _numAsoc1;
			string auxCabecera7 = _numAsoc2;
			string auxTipoTabla = "C";			

			switch (_compAbrev) 
			{
				case "FA":
				case "TF":
				case "ND":				
				case "NC":				
				case "RM":	
				case "TINC":
					/*
					auxInvoiceType = "F";
					auxPaperType = "C";
					auxCompClase = "B";
					auxCopias = "1";
					auxTipoForm = "P";
					auxTipoLetra = "12";
					auxCondIvaV = "I";
					auxCondIvaC= "F";
					auxCabecera1 = "Nombre1";
					auxCabecera2 = "-";
					auxTipoDoc = "DNI";
                    auxNumDoc = "5445645";
					auxBienUso = "N";
					auxCabecera3 = "DomComprador1";
					auxCabecera4 = "DomComprador2";
					auxCabecera5 = "DomComprador3";
					auxCabecera6 = "001";
					auxCabecera7 = "001";
					auxTipoTabla = "C";
					*/
					if (ImpFis2.OpenInvoice(ref auxInvoiceType, ref auxPaperType, ref auxCompClase, ref auxCopias,
						ref auxTipoForm, ref auxTipoLetra, ref auxCondIvaV, ref auxCondIvaC,
						ref auxCabecera1, ref auxCabecera2, ref auxTipoDoc, ref auxNumDoc, ref auxBienUso,
						ref auxCabecera3, ref auxCabecera4, ref auxCabecera5, ref auxCabecera6, ref auxCabecera7, ref auxTipoTabla)) 
					
					
					{
						_compNumeroD = UltNroComp(_grupoImpFis, ImpFis2, _compAbrev, _compClase, _nroInterno, 1);																	
						break;						
					}
					else 
					{						
						if (Estados.EnEstado(ImpFis2.FiscalStatus, 26)) 
						{ 
							CodMensajeInt = 26;
							_estadoCompAbierto = true;
						} 
						else 
						{
							if (Estados.EnEstado(ImpFis2.FiscalStatus, 8)) 
							{ 
								CodMensajeInt = 8;
								_necesitaCierre = true;
							} 
							else 
							{
								if (Estados.EnEstado(ImpFis2.FiscalStatus, 24)) 
								{
									if (_compAbrev == "NC" || _compAbrev == "TINC") 
									{CodMensajeInt = 28;}			
									else
									{CodMensajeInt = 24;}
								}
								//Se fija si no hay errores en los datos del cliente
								else 
								{
									//Busca por otros errores posibles
									ArrayList controles = new ArrayList();								
									controles.Add("8");//Se fija si necesita un cierre de jornada				
									controles.Add("10");//Comando no válido para el estado fiscal
									bool resultado = false;				
									int i = 0;
									byte codigo = 0;
									while (resultado == false & i < controles.Count)
									{
										codigo = Convert.ToByte(controles[i]);
										resultado = Estados.EnEstado(ImpFis2.FiscalStatus, codigo);
										i++;
									}				
									if (resultado == true) 
									{
										CodMensajeInt = codigo;													
									}
									else 								
									{CodMensajeInt = 21;}
								}
							}
						}
						_estadoFiscal = ImpFis2.FiscalStatus;
						return false;
					}                                 
				case "TI":
				
					string StorageDataType = "C";
					if (ImpFis2.OpenTicket(ref StorageDataType))
					{
						_compNumeroD = UltNroComp(_grupoImpFis, ImpFis2, _compAbrev, _compClase, _nroInterno, 1);
					}
					else 
					{
						if (Estados.EnEstado(ImpFis2.FiscalStatus, 26)) 
						{
							CodMensajeInt = 26;
							_estadoCompAbierto = true;
						}
						else 
						{
							if (Estados.EnEstado(ImpFis2.FiscalStatus, 8)) 
							{ 
								CodMensajeInt = 8;
								_necesitaCierre = true;
							}
							else 
							{
								CodMensajeInt = 21;
							}							
						}
						_estadoFiscal = ImpFis2.FiscalStatus;
						return false;
					}
					break;								
				case "RX":				
					if (ImpFis2.OpenNoFiscal())  
					{
						_compNumeroD = UltNroComp(_grupoImpFis, ImpFis2, _compAbrev, _compClase, _nroInterno, 1);											
						break;						
					}
					else
					{
						if (Estados.EnEstado(ImpFis2.FiscalStatus, 27)) 
						{ 
							CodMensajeInt = 27;
							_estadoCompAbierto = true;
						} 
						else 
						{
							CodMensajeInt = 21;
						}
						
						_estadoFiscal = ImpFis2.FiscalStatus;
						return false;
					}
			}

			_estadoFiscal = ImpFis2.FiscalStatus;
			return true;
			
        /*{Acá debería responder el número de comprobante abierto
        salvo para Cotizaciones y Recibo X}
        {Si el comprobante es OS, RC, CO o RX se envia un Nro interno.}*/
		}
		
		#endregion
	
#region Sobrecargas de GrabarItemInt
		private bool GrabarItemInt(HASARClass ImpFis1, ItemFiscal item)  
		{									
			//German 20110311 - Tarea 0000077
            /*
            if (!ImpFis1.PrecioBase ) 
			{
				item.Monto = item.Monto * (1 + item.IVA / 100);
				item.MontoDif = item.MontoDif * (1 + item.IVA / 100);
			}
			*/
            //Fin German 20110311 - Tarea 0000077
			if (_descuentoEnItem) 
			{
				if (item.Diferencia == 'D') 
				{item.Monto = item.Monto - item.MontoDif / item.Cantidad;} //Incluye el descuento en el item.
				else 
				{item.Monto = item.Monto + item.MontoDif / item.Cantidad;} //Incluye el recargo en el item.
			}

			if (ImpFis1.EstadoControlador == 2)
			{
				CodMensajeInt = 40;
				return false;
			}
			item.Descripcion = Rutinas.ArregloCadenaArt(_grupoImpFis, item.Descripcion);			
			

			 if (item.TextoFiscal != String.Empty)//Impresión de texto fiscal
			{
				if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "NC") 
				{
					string[] vecRengl = new String[200];
					item.TextoFiscal = Rutinas.ArregloCadena(_grupoImpFis, item.TextoFiscal);
					Rutinas.SepTexto(item.TextoFiscal, _linTextoCant, _linTextoLong, ref vecRengl);
					int i = 0;
					while ((i <= _linTextoCant) & (vecRengl[i] != null))
					{
						ImpFis1.ImprimirTextoFiscal(vecRengl[i]);
						i++;
					}
				}
			}		

			if (item.ImpuestosInternos > 0) 
			{
				ImpFis1.ImpuestoInternoFijo = true;
				ImpFis1.ImpuestoInternoPorMonto = true;
			}

			//Impresión de item
			if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "NC"	|| _compAbrev == "RX" )
			{
                //German 20110411 - Tarea 0000071
                //German 20120131 - Tarea 0000269 - Compara con Signo, para que si signo = false no lo intente imprimir
				if (item.Cantidad > 0 && item.Signo)
                //German 20120131 - Tarea 0000269
                //if (item.Cantidad != 0)
                //Fin German 20110411 - Tarea 0000071

				{

                    switch (_compAbrev) 
					{
						case "FA":
						case "ND":
						case "NC":
						case "RX":  
							int intentos = 3;
							do
							{								
								ImpFis1.ImprimirItem(item.Descripcion, (double) item.Cantidad, (double) item.Monto, (double) item.IVA, (double) item.ImpuestosInternos);
								if (ImpFis1.HuboErrorFiscal) 								
									CodMensajeInt = 41;									
								intentos--;
							} while (ImpFis1.HuboErrorFiscal && intentos > 0);							
							break;							
					}
					if (_compAbrev == "RX") 
					{ ImpFis1.DetalleRecibo(item.Descripcion);}					

					if (ImpFis1.HuboErrorFiscal) 
					{
						SubTotalFiscal subtotal = new SubTotalFiscal();
						this.SubtotalInt(ImpFis1, subtotal);						
						if (subtotal.Total + item.Total >= 1000 )						
							CodMensajeInt = 48;						
						else 						
							CodMensajeInt = 41;						
						return false;
					}
					else 
					{
						_itemsImpresosOK++;//Item impreso
					}

					if (!_descuentoEnItem) //Define si el descuento va aparte del renglón del ítem.
					{
						if (item.MontoDif > 0 & item.DescripcionDif != String.Empty & (item.Diferencia == 'R' || item.Diferencia == 'D')) 
						{
							bool dif = item.Diferencia != 'R';
							if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "NC" || _compAbrev == "RX") 
							{
								item.DescripcionDif = Rutinas.ArregloCadena(_grupoImpFis, item.DescripcionDif);														
								ImpFis1.DescuentoUltimoItem(item.DescripcionDif, (double) item.MontoDif, dif);
							}						
						}
					}
				}
				else 
				{
                    //German 20120131 - Tarea 0000269 - Compara con Signo, para que si signo = true entonces vino al else pq cantidad <= 0
                    if (item.Signo)
                    {
                       
                        //Datos incorrectos para grabar el ítem
                        CodMensajeInt = 42;
                        return false;
                    }
                    //German 20120131 - Tarea 0000269
				}
			}//graba item de factura, nc, nd, rx
			else 
			{
				if (_compAbrev == "RM")
				{
					ImpFis1.ImprimirItemEnRemito(item.Descripcion, (double) item.Cantidad);
					if (ImpFis1.HuboErrorFiscal) 
					{
						CodMensajeInt = 43; //Error al grabar item en remito
						return false;
					}
					//else
					//{ CodMensajeInt = 202;}//Item impreso}
				}
			}
			return true;
		}

		private bool GrabarItemInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, ItemFiscal item)
		{
			if (_descuentoEnItem) 
			{
				if (item.Diferencia == 'D') 
				{item.Monto = item.Monto - item.MontoDif / item.Cantidad;} //Incluye el descuento en el item.
				else 
				{item.Monto = item.Monto + item.MontoDif / item.Cantidad;} //Incluye el recargo en el item.
			}
			
			decimal auxdecMonto;						
			decimal coeficiente = Convert.ToDecimal( Math.Pow(10, _redondeoPrecio) );
			int redondeoPrecio = Convert.ToInt32(_redondeoPrecio);
			int redondeoImpuesto = Convert.ToInt32(_redondeoImpuesto);
			
			if (_compClase == 'A') 
			{
                //German 20110106 - Tarea 0000148
				//auxdecMonto = Decimal.Truncate(Decimal.Round(item.Monto, redondeoPrecio)* coeficiente );
                auxdecMonto = Decimal.Round(item.Monto, redondeoPrecio);
                //Fin German 20110106 - Tarea 0000148
				//Antes {auxdecMonto = Decimal.Truncate(Decimal.Round(item.Monto,2) * 100  );}
			}
			else 
			{

                //German 20110106 - Tarea 0000148
                //decimal aux = Decimal.Round(item.Monto * (1 + item.IVA / 100) + item.ImpuestosInternos, redondeoPrecio);
                auxdecMonto = Decimal.Round(item.Monto * (1 + item.IVA / 100) + item.ImpuestosInternos, redondeoPrecio);
				//auxdecMonto = Decimal.Truncate(aux * coeficiente);
                //Fin German 20110106 - Tarea 0000148
				//Antes auxdecMonto = Decimal.Truncate(Decimal.Round(item.Monto * (1 + item.IVA / 100),2) * 100);
			}
			
			/*if (_compClase == 'A') 
			{auxdecMonto = Decimal.Round(item.Monto,4);}
			else  
			{auxdecMonto = Decimal.Round(item.Monto * (1 + item.IVA / 100),4);}*/
			
			decimal auxdecIva = Decimal.Truncate(Decimal.Round(item.IVA * 100, redondeoImpuesto));			
			string auxDescripcion = Rutinas.ArregloCadena(_grupoImpFis, item.Descripcion);
			string auxDescrip1 = String.Empty;
			string auxDescrip2 = String.Empty;
			string auxDescrip3 = String.Empty;
			string auxTipo = String.Empty;			
			string[] vecRengl = new String[200];

			if (item.TextoFiscal != String.Empty) //Impresión de texto fiscal
			{
				if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "NC" || _compAbrev == "TF"
					|| _compAbrev == "RM" || _compAbrev == "TINC") 
				{					
					item.TextoFiscal = Rutinas.ArregloCadena(_grupoImpFis, item.TextoFiscal);
					Rutinas.SepTexto(item.TextoFiscal, _linTextoCant, _linTextoLong, ref vecRengl);
					if (vecRengl[0] != null) {auxDescrip1 = vecRengl[0];}
					if (vecRengl[1] != null) {auxDescrip2 = vecRengl[1];}
					if (vecRengl[2] != null) {auxDescrip3 = vecRengl[2];}
				}
			}					
			
			
			//Impresión de item
			bool MontoOK = false;
			if (_compAbrev == "RM" || item.Monto > 0) 
			{
				MontoOK = true;
			}
			if (item.Cantidad > 0 & MontoOK)
			{
				if ((_compAbrev == "FA" || _compAbrev == "ND") & _compClase == 'A')
				{Rutinas.IVAIncluir(matIVA, item.IVA, item.Monto);}				

				decimal auxdecCantidad = 0;
				string auxCantidad = "";
				string auxMonto = "";
			
				bool InvertirCantidadMonto = _invertirCantidadMonto;
				if (InvertirCantidadMonto)
				{										
					auxdecCantidad = item.Cantidad * 100;					
					auxCantidad = auxdecMonto.ToString();						
					auxMonto = Convert.ToInt64(auxdecCantidad).ToString();				
				}
				else 
				{
					auxdecCantidad = item.Cantidad * 1000;					
					auxCantidad = Convert.ToInt64(auxdecCantidad).ToString();
                    //German 20110106 - Tarea 0000148
                    //auxMonto = auxdecMonto.ToString();						
                    auxMonto = mz.erp.systemframework.Util.FormatString(auxdecMonto, ".");
                    //Fin German 20110106 - Tarea 0000148

                }


				string auxIva = auxdecIva.ToString();
                /* Silvina 20111212 - Tarea 0000232 */
				string auxCalificador = item.Signo == true ? "M": "R"; 
                /* Fin Silvina 20111212 - Tarea 0000232 */

				// M: agrega mercaderia
				// m: anula item
				// R: bonificacion resta
				// r: anula bonificacion.
				string auxCultos = "0";
				string auxImpuestos = "0";				
				string auxTasaXXX = "0";				
				string auxImpIntFijo = "0";				
			
				decimal auxdecII = Decimal.Truncate(Decimal.Round(item.Cantidad * item.ImpuestosInternos * 100,redondeoImpuesto));				
					
				if (item.ImpuestosInternos != 0)
				{
					if (_compClase == 'A')
					{
				
						decimal aux = item.Monto / (item.Monto + item.ImpuestosInternos);
						long decimales = Convert.ToInt64(aux * 100000000); //multiplico para tener un número de 8 caracteres de ancho
						auxImpuestos = decimales.ToString();				
					}
					else 
					{
						if (InvertirCantidadMonto)
						{						
							decimal precioVenta = item.Monto + item.MontoIVA + item.ImpuestosInternos;
							decimal aux = item.MontoIVA / precioVenta;
							long decimales = Convert.ToInt64(aux * 100000000); //multiplico para tener un número de 8 caracteres de ancho											
							auxImpuestos = decimales.ToString();
						}
						else 
						{
							decimal aux = item.ImpuestosInternos;
							long decimales = Convert.ToInt64(aux * 100000000); //multiplico para tener un número de 8 caracteres de ancho					
							auxImpIntFijo = decimales.ToString();					
						}					
					}									
				}
				//@FACTITEM|00001|Producto A|00001000|00014000|2700|M|00001|90909090||||0000|000000000000000 

				if (! ImpFis2.CanDoLineItem()){ImpFis2.TransportClose(); ImpFis2.TransportOpen();	} //Verifica si necesita hacer transporte

				switch (_compAbrev) 
				{
					case "FA":
					case "ND":	
					case "NC":
					case "TF":
					case "RM":
					case "TINC":
                        //auxMonto = "3.583";
						if (ImpFis2.SendInvoiceItem(ref auxDescripcion, ref auxCantidad, ref auxMonto, ref auxIva, ref auxCalificador, ref auxCultos, ref auxImpuestos, ref auxDescrip1, ref auxDescrip2, ref auxDescrip3, ref auxTasaXXX, ref auxImpIntFijo))
						/// Fiscal1.SendInvoiceItem("ARTICULO 1",          "1000",           "100",      "2100",        "M",			"0",				 "0",			"EXTRA",		"EXTRA",		"EXTRA",			"1050",			"0")
						{
							/*if (ImpFis2.FiscalStatus == "3200") 
							{
								CodMensajeInt = 46;
								return false;
							}*/

							if (item.MontoDif > 0) 
							{
								auxCantidad = "1000";
								if (item.Signo) 
								{auxTipo = item.Diferencia == 'D' ? "R":"M";}
								else
								{auxTipo = item.Diferencia == 'D' ? "M":"R";}
								
								auxDescripcion = item.DescripcionDif;
								if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "NC") 
								{
									//REVISAR ACA EL NETO
								}																

								if (_compClase == 'A') 
								{auxdecMonto = Decimal.Truncate(Math.Round(item.MontoDif * 100,redondeoPrecio));}
								else 
								{auxdecMonto = Decimal.Truncate(Math.Round(item.MontoDif * (1 + auxdecIva / 100 / 100) * 100,redondeoPrecio));}

								auxMonto = Convert.ToString(auxdecMonto);
								auxCultos ="0";
								auxImpuestos = "0";
								auxTasaXXX = "0";
								auxImpIntFijo = "0";
								if ((_compAbrev == "FA") && (!_descuentoEnItem))
								{									
									if (! ImpFis2.CanDoLineItem()){ImpFis2.TransportClose(); ImpFis2.TransportOpen();	} //Verifica si necesita hacer transporte

									if (ImpFis2.SendInvoiceItem(ref auxDescripcion, ref auxCantidad, ref auxMonto, ref auxIva, ref auxTipo, ref auxCultos, ref auxImpuestos, ref auxDescrip1, ref auxDescrip2, ref auxDescrip3, ref auxTasaXXX, ref auxImpIntFijo))
									{
										return true;
									}									
								}
								return true;
							}
							else 
							{
								return true;
							}							
						}
						else 
						{
							if (_compAbrev == "RM" && Estados.EnEstado(ImpFis2.FiscalStatus, 47)) //Se necesita realizar transporte de factura cuando es remito
							{
								CodMensajeInt = 47;
								CerrarCompInt(ImpFis2);
								AbrirCompInt(ImpFis2);
								if (ImpFis2.SendInvoiceItem(ref auxDescripcion, ref auxCantidad, ref auxMonto, ref auxIva, ref auxCalificador, ref auxCultos, ref auxImpuestos, ref auxDescrip1, ref auxDescrip2, ref auxDescrip3, ref auxTasaXXX, ref auxImpIntFijo)) 
								{return true;}
								else
								{return false;}
							}
							else 
							{
								CodMensajeInt = 41;
								return false;
							}

							/*
							string pavada = ImpFis2.FiscalStatus;
							string pavada2 = ImpFis2.PrinterStatus;				
							ImpFis2.TransportClose(); ImpFis2.TransportOpen();
							return false;*/
						}
					case "TI":					
					
						string auxImpuestosPorc = "0";
						string auxImpuestosFijos = "0";
						if (ImpFis2.SendTicketItem(ref auxDescripcion, ref auxCantidad, ref auxMonto, ref auxIva, ref auxCalificador, ref auxCultos, ref auxImpuestosPorc, ref auxImpuestosFijos))
						{							
							CodMensajeInt = 202;
						}
						else 
						{
							CodMensajeInt = 41;
							return false;
						}

						break;					
					case "RX":					
						if (item.TextoFiscal != String.Empty) //Impresión de texto fiscal 
						{
							string Descripcion = Rutinas.ArregloCadena(_grupoImpFis, item.TextoFiscal);
							Rutinas.SepTexto(item.TextoFiscal, _linTextoCant, _linTextoLong, ref vecRengl);
							int i = 0;
							while ((i <= _linTextoCant) & (vecRengl[i] != null))
							{
								ImpFis2.SendNoFiscalText(ref vecRengl[i]);
								i++;
							}
							if (! ImpFis2.SendNoFiscalText(ref Descripcion)) 
							{
								CodMensajeInt = 41;
								return false;
							}
						}
						break;
					default:
						CodMensajeInt = 41;
						return false;
				}
			}
			else 
			{
				//Datos incorrectos para grabar el ítem				
				CodMensajeInt = 42;
				return false;
			}			
			return true;
		}
		
		#endregion

#region Sobrecargas de GrabarDesctoGralInt
		private bool GrabarDesctoGralInt(HASARClass ImpFis1, string DescripcionDif, decimal MontoDif, char Diferencia)
		{
			if (ImpFis1.EstadoControlador == 2) 
			{
				CodMensajeInt = 62;
				return false;
			}

			bool dif = Diferencia != 'R';
			if (_compAbrev == "FA" ||_compAbrev == "ND" || _compAbrev == "NC" || _compAbrev == "FA") 
			{
				DescripcionDif = Rutinas.ArregloCadena(_grupoImpFis, DescripcionDif);				
				ImpFis1.DescuentoGeneral(DescripcionDif, (double) (MontoDif), dif);	
				if (ImpFis1.HuboErrorFiscal) 
				{ 
					CodMensajeInt = (byte) (Diferencia == 'R' ? 66: 65);
					return false;
				}//No se pudo grabar el descto/recargo
				else
				{
					if (!(ImpFis1.EstadoControlador == 10 || ImpFis1.EstadoControlador == 10)) 
					{ 
						CodMensajeInt = (byte) (Diferencia == 'R' ? 66: 65);
						return false;
					}
					//ocurre cuando existe por lo menos un pago realizado					
				}
			}
			else 
			{ 
				CodMensajeInt = (byte) (Diferencia == 'R' ? 64: 63);
				return false;
				//Descuento/Recargo general no soportado para el comprobante abierto;}
			}
			return true;			
		}
	
		private bool GrabarDesctoGralInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, string DescripcionDif, decimal MontoDif, char Diferencia)
		{
			decimal auxdecMonto = 0;
			string auxDescripcion = DescripcionDif;			
			string auxTipo = Diferencia == 'R' ? "R": "D";
			
			if (_compClase == 'A') 
			{
				auxdecMonto = Rutinas.IVACalcDifGral(matIVA, MontoDif);
				auxdecMonto = auxdecMonto * 100;
				auxdecMonto = Decimal.Truncate(Decimal.Round(auxdecMonto,2));						
			}
			else 
			{
				auxdecMonto = MontoDif * 100;
				auxdecMonto = Decimal.Truncate(Decimal.Round(auxdecMonto,2));	
			}

			string auxMonto = auxdecMonto.ToString();
			
			if (! ImpFis2.SendInvoicePayment(ref auxDescripcion, ref auxMonto, ref auxTipo)) 
			{
				CodMensajeInt = (byte) (Diferencia == 'R' ? 66: 65); //No se pudo grabar el descto/recargo
				return false;
			}
			return true;
		}
	
		#endregion
	
#region Sobrecargas de GrabarPagoInt
		private bool GrabarPagoInt(HASARClass ImpFis1, string Descripcion, decimal Monto)
		{
			if (ImpFis1.EstadoControlador == 2)
			{
				CodMensajeInt = 101; //'No hay ningún comprobante abierto
				return false;
			}
			if (_compAbrev == "FA" ||_compAbrev == "ND" || _compAbrev == "NC" || _compAbrev == "RE") 
			{
				//German 20110225 - Tarea 0000077
                //ImpFis1.ImprimirPago(Descripcion, (double) Monto);
                object resto;
                ImpFis1.ImprimirPago(Descripcion, (double)Monto, null, out resto);
                //Fin German 20110225 - Tarea 0000077
				if (ImpFis1.HuboErrorFiscal)
				{
					CodMensajeInt = 102; //No se pudo grabar el pago
					return false;
				}
				else 
				{
                    //German 20110311 - Tarea 0000077
                    if (ImpFis1.EstadoControlador == 6 || ImpFis1.EstadoControlador == 7 || ImpFis1.EstadoControlador == 24)
                    //Fin German 20110311 - Tarea 0000077
					{
					}
					else 
					{
						CodMensajeInt = 102;//No se pudo grabar el pago;
						return false;
					}
				}
			}
			else 
			{
				CodMensajeInt = 103;
				return false;
			}
			return true;
		}
	
		private bool GrabarPagoInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, string Descripcion, decimal Monto)
		{
            //German 20120710 - Tarea 0000357
            decimal auxdecMonto = decimal.Truncate(Math.Round(Monto, 2) * 100);
            //Fin German 20120710 - Tarea 0000357
			string auxDescripcion = Rutinas.ArregloCadena(_grupoImpFis, Descripcion);
			string auxMonto = auxdecMonto.ToString();
			string auxTipo = "T";
			if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "TF" || _compAbrev == "NC" || _compAbrev == "TINC") 
			{
				if (! ImpFis2.SendInvoicePayment(ref auxDescripcion, ref auxMonto, ref auxTipo)) 
				{
					CodMensajeInt = 102;
					return false;
				}
			}
			else 
			{				
				if (_compAbrev == "TI" ) 
				{
					if (!ImpFis2.SendTicketPayment(ref auxDescripcion, ref auxMonto, ref auxTipo)) 
					{
						_codMensaje = 102;
						return false;
					}
				}
				else 
				{
					_codMensaje = 103;
					return false;
				}								
			}
			return true;
		}

		#endregion

		#region Sobrecargas de GrabarObservacionPagoInt
		private bool GrabarObservacionPagoInt(HASARClass ImpFis1, string Descripcion)
		{			
			if (ImpFis1.EstadoControlador == 2)
			{
				CodMensajeInt = 101; //'No hay ningún comprobante abierto
				return false;
			}
			if (_compAbrev == "RX") 
			{				
				ImpFis1.DetalleRecibo(Descripcion);
				if (ImpFis1.HuboErrorFiscal)
				{
					CodMensajeInt = 110; //No se pudo grabar la observación
					return false;
				}
				else 
				{
					if (ImpFis1.EstadoControlador == 12 || ImpFis1.EstadoControlador == 18) 
					{
					}
					else 
					{
						CodMensajeInt = 110;//No se pudo grabar el pago;
						return false;
					}
				}
			}
			else 
			{
				CodMensajeInt = 111;
				return false;
			}
			return true;
		}
	
		private bool GrabarObservacionPagoInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, string Descripcion)
		{
			/*decimal auxdecMonto = decimal.Truncate(Monto * 100);
			string auxDescripcion = Rutinas.ArregloCadena(_grupoImpFis, Descripcion);
			string auxMonto = auxdecMonto.ToString();
			string auxTipo = "T";
			if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "TF" || _compAbrev == "NC") 
			{
				if (! ImpFis2.SendInvoicePayment(ref auxDescripcion, ref auxMonto, ref auxTipo)) 
				{
					CodMensajeInt = 102;
					return false;
				}
			}
			else 
			{				
				if (_compAbrev == "TI" || _compAbrev == "TINC") 
				{
					if (!ImpFis2.SendTicketPayment(ref auxDescripcion, ref auxMonto, ref auxTipo)) 
					{
						_codMensaje = 102;
						return false;
					}
				}
				else 
				{
					_codMensaje = 103;
					return false;
				}								
			}
			return true;*/
			return false;
		}

		#endregion

		
#region Sobrecargas de SubtotalInt
		private bool SubtotalInt(HASARClass ImpFis1, SubTotalFiscal SubTotal) 
		{
            //German 20110311 - Tarea 0000077
			System.Collections.ArrayList estados = new System.Collections.ArrayList(new int[] {2,3,4,5,6,7,8,9,10,12,13,14,15,16,17,18,24});
            //Fin German 20110311 - Tarea 0000077
			try 
			{			
				if (estados.Contains(ImpFis1.EstadoControlador))
					//if (aux == 2 || aux == 3 || aux == 4 || aux == 5 || aux == 6 || aux == 7 || aux == 8 || aux == 9 || aux == 10 || aux == 12 || aux == 13 || aux == 14 || aux == 15 || aux == 16 || aux == 17 || aux == 18) 
				{
					try 
					{
                        //German 20110225 - Tarea 0000077
						//ImpFis1.Subtotal(true);
                        object CantidadItemsVendidos;
                        object MontoVentas;
                        object MontoIVA; 
                        object MontoPagado; 
                        object MontoIVANoInscripto;
                        object MontoImpuestosInternos;
                        ImpFis1.Subtotal(true, out CantidadItemsVendidos, out  MontoVentas, out MontoIVA, out MontoPagado, out MontoIVANoInscripto, out MontoImpuestosInternos);
                        //Fin German 20110225 - Tarea 0000077
						SubTotal._cantidad = Decimal.Parse(ImpFis1.get_Respuesta(3));
						/*SubTotal._iva = Decimal.Parse(ImpFis1.get_Respuesta(5)) / 100;
						SubTotal._ivaNI = Decimal.Parse(ImpFis1.get_Respuesta(7)) / 100;
						SubTotal._total = Decimal.Parse(ImpFis1.get_Respuesta(4)) / 100;
						SubTotal._pagado = Decimal.Parse(ImpFis1.get_Respuesta(6));*/
						SubTotal._iva = Convert.ToDecimal(ImpFis1.get_Respuesta(5));
							//Decimal.Parse() / 100;
						SubTotal._ivaNI = Convert.ToDecimal(ImpFis1.get_Respuesta(7));
							//Decimal.Parse() / 100;
						SubTotal._total = Convert.ToDecimal(ImpFis1.get_Respuesta(4));
							//Decimal.Parse() / 100;
						SubTotal._pagado = Convert.ToDecimal(ImpFis1.get_Respuesta(6));
							//Decimal.Parse();
						
						SubTotal._neto = SubTotal._total - SubTotal._iva;
					}
					catch //sucede cuando se consulta subtotal con comprobante cerrado.
					{
						SubTotal._cantidad = 0;
						SubTotal._iva = 0;
						SubTotal._ivaNI = 0;
						SubTotal._total = 0;
						SubTotal._pagado = 0;
						SubTotal._neto = 0;
					}
					return true;
				}
				else 
				{
					if (ImpFis1.EstadoControlador == 19 || ImpFis1.EstadoControlador == 20 || ImpFis1.EstadoControlador == 21) 
					{CodMensajeInt =  119;}//Subtotal no soportado para el comprobante abierto
					else 
					{CodMensajeInt = 118;}//Fallo en la impresora fiscal
					return false;
				}
			}
			catch 
			{
				CodMensajeInt = 117;//No hay comprobante abierto
				return false;
			}
		}
		//german 20090330
		private bool SubtotalInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, SubTotalFiscal SubTotal)
		{
			string aux = "N"; //Antes se pasaba P y por ende lo imprime luego de cada producto.
			//Fin German 20090330
			string aux2 = "Subtotal";

			try 
			{
				if (_compAbrev == "FA" || _compAbrev == "ND" || _compAbrev == "NC" || _compAbrev == "TF" || _compAbrev == "TINC") 
				{
					if (ImpFis2.GetInvoiceSubtotal(ref aux, ref aux2)) 
					{
						SubTotal._cantidad = 0;
						SubTotal._iva = Decimal.Parse(ImpFis2.AnswerField_6) / 100;
						SubTotal._ivaNI = 0;
						SubTotal._total = Decimal.Parse(ImpFis2.AnswerField_5) / 100;
						SubTotal._pagado = Decimal.Parse(ImpFis2.AnswerField_7) / 100;
						SubTotal._neto = Decimal.Parse(ImpFis2.AnswerField_10) / 100;					
					}
					else 
					{
						SubTotal._cantidad = 0;
						SubTotal._iva = 0;
						SubTotal._ivaNI = 0;
						SubTotal._total = 0;
						SubTotal._pagado = 0;
						SubTotal._neto = 0;
						_codMensaje = 117;
						return false;
					}
				}
				else 
				{
					if (_compAbrev == "TI" ) 
					{
						if (ImpFis2.GetTicketSubtotal(ref aux, ref aux2)) 
						{
							SubTotal._cantidad = 0;
							SubTotal._iva = Decimal.Parse(ImpFis2.AnswerField_6) / 100;
							SubTotal._ivaNI = 0;
							SubTotal._total = Decimal.Parse(ImpFis2.AnswerField_5) / 100;
							SubTotal._pagado = Decimal.Parse(ImpFis2.AnswerField_7) / 100;
							SubTotal._neto = Decimal.Parse(ImpFis2.AnswerField_10) / 100;
						}
					}
				}
			}

			catch //sucede cuando se consulta subtotal con comprobante cerrado.
			{
				SubTotal._cantidad = 0;
				SubTotal._iva = 0;
				SubTotal._ivaNI = 0;
				SubTotal._total = 0;
				SubTotal._pagado = 0;
				SubTotal._neto = 0;
				CodMensajeInt = 117;
				return false;
			}
			return true;
		}
		#endregion

#region Sobrecargas de PercepcionInt
		private bool PercepcionInt(HASARClass ImpFis1, string Nombre, decimal Monto, decimal Iva) 
		{
			//La percepción general se puede aplicar a comprobantes A y B
			//La percepción sobre un IVa se aplica solamente a comprobantes A
			if (ImpFis1.EstadoControlador == 2) 
			{
				CodMensajeInt = 81; //No hay ningún comprobante abierto
				return false; 
			}
			if (Iva == 0) 
			{ //Percepcíón general
				if (_compClase == 'A' || _compClase == 'B') 
				{
					ImpFis1.EspecificarPercepcionGlobal(Nombre, (double) Monto);
					if (ImpFis1.HuboErrorFiscal) 
					{
						CodMensajeInt = 82; //No se puede aplicar la percepción general
						return false; 
					}					
				}
				else 
				{
					CodMensajeInt = 82;
					return false; //No se puede aplicar la percepción general
				}
			}
			else 
			{//percepcion de IVA
				if (_compClase == 'A') 
				{
					ImpFis1.EspecificarPercepcionPorIVA(Nombre, (double) Monto, (double) Iva);
					if (ImpFis1.HuboErrorFiscal) 
					{
						CodMensajeInt = 83; //No se puede aplicar la percepción al IVA
						return false; 
					}					
				}
				else 
				{
					CodMensajeInt = 84;
					return false; //No se puede aplicar la percepción al IVA para facturas B
				}
			}
			return true;
		}

		private bool PercepcionInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, string Nombre, decimal Monto, decimal Iva)
		{
			
			//German 20091003
			Monto = Decimal.Round(Monto,2);
			decimal auxdecMonto = Monto * 100; //Esto es lo que estaba antes
			decimal auxdecIva = Iva * 100;
			string auxDescripcion = Nombre;
			//string auxMonto = auxdecMonto.ToString(); //Esto es lo que estaba antes
			string auxMonto = Convert.ToInt64(auxdecMonto).ToString(); 
			auxMonto = mz.erp.systemframework.Util.StrZero(auxMonto,8); //- No estaba asi - Fundamental el formato es 00000000 y divide por 100
			string auxTasa = auxdecIva.ToString();
			//Fin German 20091003

			//La percepción general se puede aplicar a comprobantes A y B
			//La percepción sobre un IVa se aplica solamente a comprobantes A

			if (Iva == 0) 
			{//Percepcíón general
				if (_compClase == 'A' || _compClase == 'B') 
				{
					//German 20091003
					string auxQualifier = "O"; //Esto es lo que estaba antes
					//auxMonto = "00000321"; // No estaba asi - Sacar de ultima
					//string auxQualifier = "T"; // No estaba asi - Sacar de ultima
					//auxTasa = "00000500"; //Harcoding - Ver como recuperarlo - No estaba asi - Sacar de ultima
					//Fin German 20091003
					if (! ImpFis2.SendInvoicePerception(ref auxDescripcion, ref auxQualifier, ref auxMonto, ref auxTasa)) 
					{
						CodMensajeInt = 82; //No se puede aplicar la percepción general
						return false; 
					}					
				}
				else 
				{
					CodMensajeInt = 82;
					return false; //No se puede aplicar la percepción general
				}
			}		
			else
			{//percepcion de IVA
				if (_compClase == 'A') 
				{
					string auxQualifier = "T";
					if (! ImpFis2.SendInvoicePerception(ref auxDescripcion, ref auxQualifier, ref auxMonto, ref auxTasa)) 
					{
						CodMensajeInt = 83; //No se puede aplicar la percepción al IVA
						return false; 
					}					
				}
				else 
				{
					CodMensajeInt = 84;
					return false; //No se puede aplicar la percepción al IVA para facturas B
				}
			}
			return true;
		}

		#endregion

#region Sobrecargas de CerrarCompInt
		private bool CerrarCompInt(HASARClass ImpFis1)  
		{
			try 
			{
				if (ImpFis1.EstadoControlador == 2)
				{
					CodMensajeInt = 120; //No hay ningún comprobante abierto
					return false;
				}
			}
			catch 
			{							
				CodMensajeInt = 120; //No hay ningún comprobante abierto
				return false;			
			}

			switch (_compCodigo) 
			{
				case 1:
				case 2:
				case 16:
                    //German 20110225 - Tarea 0000077
					//ImpFis1.CerrarComprobanteFiscal();
                    object Numero;
                    //German 20120410 - Tarea 0000310
                    //ImpFis1.CerrarComprobanteFiscal(_copias, out Numero);
                    ImpFis1.CerrarComprobanteFiscal(1, out Numero);
                    //Fin German 20120410 - Tarea 0000310
                    //Fin German 20110225 - Tarea 0000077
					break;
				case 3:
				case 6:
                case 7:
                    //German 20110225 - Tarea 0000077
					//ImpFis1.CerrarComprobanteNoFiscalHomologado();

                    //German 20120329 - Tarea 0000310
                    //ImpFis1.CerrarComprobanteNoFiscal();
                    object Numero1;
                    ImpFis1.CerrarDNFH(1, out Numero1);
                    //Fin German 20120329 - Tarea 0000310
                    //Fin German 20110225 - Tarea 0000077
					for (int i = 2;i<=Copias;i++) {ImpFis1.ReimprimirComprobante();}
					//Copias = 1 (se toma como la original). Si queremos que salga un duplicado tenemos
					//que poner Copias en 2
					
					break;
				default:
					CodMensajeInt = 121; //Operación no soportada para el comprobante
					return false;
			}

			if (_compCodigo == 7)//Es Remito
			{
				_compNumeroH = UltNroComp(_grupoImpFis, ImpFis1, _compAbrev, _compClase, _nroInterno, 1);
			}
			else
			{
				if (ImpFis1.HuboErrorFiscal) //se produce si quiero cerrar un comprobante sin grabar ítems o si quiero volver a cerrar un comprobante ya cerrado.
				{
					if (_itemsImpresosOK == 0) 
					{
						CodMensajeInt = 122; //No se puede cerrar el comprobante porque no hay ventas
					}
					else 
					{
						CodMensajeInt = 125; //No se puede cerrar el comprobante porque no hay ventas
					}
				
				
					return false;
				}
				else 
				{
					_compNumeroH = UltNroComp(_grupoImpFis, ImpFis1, _compAbrev, _compClase, _nroInterno, 1);
				}
			}
			
			return true;
			
		}
		private bool CerrarCompInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2)
		{
			string auxTipo = String.Empty;
			string auxLetra = _compClase.ToString();
			if (_compAbrev == "TF") 
			{ auxTipo = "T";} 
			else 
			{ 
				switch (_compAbrev) 
				{
					case "FA": auxTipo = "F";break;
					case "ND": auxTipo = "D";break;
					case "NC": auxTipo = "N";break;
					case "TINC": auxTipo = "M";break;
					case "RM": 
						auxTipo = "E";
						auxLetra = "X";
						break;
					case "CO": auxTipo = "C";break;
					case "RE": auxTipo = "L";break;
				}				
			}			

			switch (_compAbrev) 
			{
				case "FA":
				case "ND":				
				case "NC":
				case "TF":
				case "RM":	
				case "TINC":

					//German
					//string auxText = "textofinal";
					string auxText = "";
					//Fin German 
					string estado = ImpFis2.FiscalStatus;
					Console.WriteLine(estado);
					if (ImpFis2.CloseInvoice(ref auxTipo, ref auxLetra, ref auxText)) 
					{
						_compNumeroH = UltNroComp(_grupoImpFis, ImpFis2, _compAbrev, _compClase, _nroInterno, 1);
						break;
					}
					else 
					{
						estado = ImpFis2.FiscalStatus;
						Console.WriteLine(estado);
						CodMensajeInt = 124;
						return false;
					}				
				case "TI":
				
					if (ImpFis2.CloseTicket()) 
					{
						_compNumeroH = UltNroComp(_grupoImpFis, ImpFis2, _compAbrev, _compClase, _nroInterno, 1);
						break;	
					}
					else 
					{
						CodMensajeInt = 124;
						return false;
					}				
				case "RX":
					if (ImpFis2.CloseNoFiscal()) 
					{
						//_compNumeroH = UltNroComp(_grupoImpFis, _compAbrev, _compClase, _nroInterno, 2);
						break;
					}
					else 
					{
						CodMensajeInt = 124;
						return false;
					}
				default:
					CodMensajeInt = 121;
					return false;
			}
			return true;
		}

#endregion

#region Sobrecargas de CerrarImpFisInt
		private bool CerrarImpFisInt(HASARClass ImpFis1)  
		{
			try 
			{
				if (ImpFis1.EstadoControlador == 2)
				{ImpFis1.Finalizar();}
				else 
				{CodMensajeInt = 140;} //Impresora fiscal no se cerró								
				return true;
			}
			catch 
			{
				CodMensajeInt = 140; //Impresora fiscal no se cerró								
				return true;
			}			
		}				
		private bool CerrarImpFisInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, ArrayList ItemsFiscal)
		{	
			//German 20100618
			//Esto deberia ser configurable

			/* Silvina 20100713 - Tarea 795 */
			if (ImprimeTicketDeCambio )
			/* Fin Silvina */
				ImprimirTicketDeCambioInt(ItemsFiscal);
			//Fin German 20100618
			return true;
		}

		//German 20100622
		public void ImprimirTicketDeCambio(ArrayList ItemsFiscal)
			
		{
			switch (_grupoImpFis) 
			{
				case 1:break;
				case 2:
				{
                    /* Silvina 20100713 - Tarea 795 */
					if (ImprimeTicketDeCambio )
					{
						while (ItemsFiscal.Count > 3)
						{
							ArrayList itFis = new ArrayList();
							itFis.Add(ItemsFiscal[0]);
							itFis.Add(ItemsFiscal[1]);
							itFis.Add(ItemsFiscal[2]);
							
							ImprimirTicketDeCambioInt(itFis);
							ItemsFiscal.RemoveRange(0,3);
						}
						if (ItemsFiscal.Count > 0)
							ImprimirTicketDeCambioInt(ItemsFiscal);
					}
					/* Fin Silvina */
					break;
				}

			}
			
		} 
		//Fin German 20100622

		//German 20100618
		private bool ImprimirTicketDeCambioInt(ArrayList ItemsFiscal)
		{
			//Por ahora solo imprime los primeros 3 si es que existen, esto es solo para probar, mejorar codigo
			/*
			ParaisoFiscal.ProtocoloEpson CF = new ProtocoloEpson();
			CF.Conectar();
			string Desc1, Desc2, Desc3;
			ItemFiscal if1, if2, if3;
			if(ItemsFiscal.Count > 0)
			{
				if1 = (ItemFiscal)ItemsFiscal[0];
				Desc1 = if1.Descripcion;
			}
			else Desc1 = string.Empty;
			if(ItemsFiscal.Count > 1)
			{
				if2 = (ItemFiscal)ItemsFiscal[1];
				Desc2 = if2.Descripcion;
			}
			else Desc2 = string.Empty;
			if(ItemsFiscal.Count > 2)
			{
				if3 = (ItemFiscal)ItemsFiscal[2];
				Desc3 = if3.Descripcion;
			}
			else Desc3 = string.Empty;
			CF.TicketCambio("Los cambios se realizan","durante el primer mes","","","1",Desc1,"2",Desc2,"3",Desc3);
			*/
			ImpFis2.OpenNoFiscal();

			/* Silvina 20100712 - Tarea 795 */

			string vacio = string.Empty;
			ImpFis2.SendNoFiscalText(ref vacio);
			string titulo = "        *** TALON DE CAMBIO ***";
			ImpFis2.SendNoFiscalText(ref titulo);
			ImpFis2.SendNoFiscalText(ref vacio);
			string comp = "Ref. Original: TIQUET    " + CompClase.ToString() + '-' + CompPuntoDeVenta + '-' + CompNumeroD;
			ImpFis2.SendNoFiscalText(ref comp);
			ImpFis2.SendNoFiscalText(ref vacio);

			ItemFiscal if1, if2, if3;
			string Desc;

			string titulo2 = "Descripcion                     Cantidad";
			ImpFis2.SendNoFiscalText(ref titulo2);
			string sep = "----------------------------------------";
			ImpFis2.SendNoFiscalText(ref sep);
			string sub = string.Empty;
			foreach (ItemFiscal it in ItemsFiscal)
			{
				//if1 = (ItemFiscal)ItemsFiscal[0];
				Desc = it.TextoFiscal + it.Descripcion;
				while (Desc.Length > 30)
				{
					sub = Desc.Substring(0,30);
					ImpFis2.SendNoFiscalText(ref sub);
					Desc = Desc.Remove(0,30);
				}
				sub = Desc;
				sub = sub + Math.Round(it.Cantidad,2).ToString().PadLeft(40-sub.Length);
				ImpFis2.SendNoFiscalText(ref sub);
			}


			if (!DescripcionAdicionalTicketDeCambio.Equals(string.Empty))
			{
				ImpFis2.SendNoFiscalText(ref sep);
				string leyenda = DescripcionAdicionalTicketDeCambio;
				while (leyenda.Length > 40)
				{
					sub = leyenda.Substring(0,40);
					ImpFis2.SendNoFiscalText(ref sub);
					leyenda = leyenda.Remove(0,40);
				}
				ImpFis2.SendNoFiscalText(ref leyenda);
				ImpFis2.SendNoFiscalText(ref sep);
			}
			/* Fin Silvina */
			ImpFis2.CloseNoFiscal();
			return true;
		}
		//Fin German 20100618


#endregion

#region Sobrecargas de CancelarCompInt				
		private bool CancelarCompInt(HASARClass ImpFis1)  
		{
			int estado = ImpFis1.EstadoControlador;
			_compClaseAnulado = _compClase;	
			try 
			{
				if (ImpFis1.get_Respuesta(6) == "0100" )
				{ _compClaseAnulado = 'A'; } 
				else  
				{ _compClaseAnulado = 'B';	}//0200			
			}			
			catch{}

			try 
			{
				System.Collections.ArrayList estados = new System.Collections.ArrayList(new int[] {2,3,4,5,6,7,8,9,10,12,13,14,15,16,17,18,20});

				if (estados.Contains(ImpFis1.EstadoControlador)) 
				{
					_compNumeroD = UltNroComp(_grupoImpFis, ImpFis1, _compAbrev, _compClaseAnulado, _nroInterno, 1);
					_compNumeroH = _compNumeroD;
					ImpFis1.TratarDeCancelarTodo();					
					CodMensajeInt = 208;
					//if (ImpFis1.HuboErrorFiscal)
					//{
						//CodMensajeInt = 160; //No se pudo cancelar el comprobante
						//return false;
					//}
				}
				else 
				{
					CodMensajeInt = 160; //No se pudo cancelar el comprobante
					return false;
				}		
				return true;
			}
			catch  
			{
				CodMensajeInt = 160; //No se pudo cancelar el comprobante
				return false;
			}	
		}

		private bool CancelarCompInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2)
		{
			string auxDescripcion = "Cancelacion";
			string auxMonto = "0";
			string auxTipo = "C";			
			
			try 
			{
				if (_compClaseAnulado == 'A')
				{			
					_compNumeroD = ImpFis2.AnswerField_7;
					_compNumeroH = _compNumeroD;
				} 
				else  
				{ 				
					_compNumeroD = ImpFis2.AnswerField_5;
					_compNumeroH = _compNumeroD;
				}
			}			
			catch{}

			switch(_compAbrev) 
			{
				case "FA":
				case "NC":
				case "ND":
				case "TF":
				case "RM":
					if (ImpFis2.SendInvoicePayment(ref auxDescripcion, ref auxMonto, ref auxTipo))
					{
						_codMensaje = 208;					
					}
					else 
					{
						_codMensaje = 160;
						return false;
					}
					break;
				case "TI":	
				case "TINC":
					if (ImpFis2.SendTicketPayment(ref auxDescripcion, ref auxMonto, ref auxTipo)) 
					{
						_codMensaje = 208;
					}
					else 
					{
						_codMensaje = 160;
						return false;
					}
					break;
				default:
					_codMensaje = 163;
					return false;
			}
			return true;
		}

#endregion

#region Sobrecargas de ReporteInt						
		private bool ReporteInt(HASARClass ImpFis1, char Tipo, ReporteFiscal Reporte)  
		{
			_linVar1 = String.Empty;
			_linVar2 = String.Empty;
			_linVar3 = String.Empty;
			_linVar4 = String.Empty;
			_linVar5 = String.Empty;			
			_linVar6 = String.Empty;			
			_linVar7 = String.Empty;			
			_linPie1 = String.Empty;			
			_linPie2 = String.Empty;			
			_linPie3 = String.Empty;			
			_linPie4 = String.Empty;			
			_numAsoc1 = String.Empty;			
			_numAsoc2 = String.Empty;

			ImpFis1.set_Encabezado(3, _linVar1);
			ImpFis1.set_Encabezado(4, _linVar2);
			ImpFis1.set_Encabezado(5, _linVar3);
			ImpFis1.set_Encabezado(11, _linPie1);
			ImpFis1.set_Encabezado(12, _linPie2);
			ImpFis1.set_Encabezado(13, _linPie3);
			ImpFis1.set_Encabezado(14, _linPie4);	

			if (ImpFis1.EstadoControlador == 2) 
			{
				if (Tipo == 'X')
				{   
                    //German 20110225 - Tarea 0000077
                    //ImpFis1.ReporteX();

                    object NumeroReporteX;
                    object CantidadDFCancelados;
                    object CantidadDNFHEmitidos;
                    object CantidadDNFEmitidos;
                    object CantidadDFEmitidos;
                    object UltimoDocFiscalBC;
                    object UltimoDocFiscalA;
                    object MontoVentasDocFiscal;
                    object MontoIVADocFiscal;
                    object MontoImpInternosDocFiscal;
                    object MontoPercepcionesDocFiscal;
                    object MontoIVANoInscriptoDocFiscal;
                    object UltimaNotaCreditoBC;
                    object UltimaNotaCreditoA;
                    object MontoVentasNotaCredito;
                    object MontoIVANotaCredito;
                    object MontoImpInternosNotaCredito;
                    object MontoPercepcionesNotaCredito;
                    object MontoIVANoInscriptoNotaCredito;
                    object UltimoRemito;
                    object CantidadNCCanceladas;
                    object CantidadDFBCEmitidos;
                    object CantidadDFAEmitidos;
                    object CantidadNCBCEmitidas;
                    object CantidadNCAEmitidas;

                    ImpFis1.ReporteX(out  NumeroReporteX, out  CantidadDFCancelados, out  CantidadDNFHEmitidos, out  CantidadDNFEmitidos, out  CantidadDFEmitidos, out  UltimoDocFiscalBC, out  UltimoDocFiscalA, out  MontoVentasDocFiscal, out  MontoIVADocFiscal, out  MontoImpInternosDocFiscal, out  MontoPercepcionesDocFiscal, out  MontoIVANoInscriptoDocFiscal, out  UltimaNotaCreditoBC, out  UltimaNotaCreditoA, out  MontoVentasNotaCredito, out  MontoIVANotaCredito, out  MontoImpInternosNotaCredito, out  MontoPercepcionesNotaCredito, out  MontoIVANoInscriptoNotaCredito, out  UltimoRemito, out  CantidadNCCanceladas, out  CantidadDFBCEmitidos, out  CantidadDFAEmitidos, out  CantidadNCBCEmitidas, out  CantidadNCAEmitidas);
                    //Fin German 20110225 - Tarea 0000077
                }
				else
				{
                    //German 20110225 - Tarea 0000077
                    //ImpFis1.ReporteZ();

                    object NumeroZeta;
                    object CantidadDFCancelados;
                    object CantidadDNFHEmitidos;
                    object CantidadDNFEmitidos;
                    object CantidadDFEmitidos;
                    object UltimoDocFiscalBC;
                    object UltimoDocFiscalA;
                    object MontoVentasDocFiscal;
                    object MontoIVADocFiscal;
                    object MontoImpInternosDocFiscal;
                    object MontoPercepcionesDocFiscal;
                    object MontoIVANoInscriptoDocFiscal;
                    object UltimaNotaCreditoBC;
                    object UltimaNotaCreditoA;
                    object MontoVentasNotaCredito;
                    object MontoIVANotaCredito;
                    object MontoImpInternosNotaCredito;
                    object MontoPercepcionesNotaCredito;
                    object MontoIVANoInscriptoNotaCredito;
                    object UltimoRemito;
                    object CantidadNCCanceladas;
                    object CantidadDFBCEmitidos;
                    object CantidadDFAEmitidos;
                    object CantidadNCBCEmitidas;
                    object CantidadNCAEmitidas;
                    ImpFis1.ReporteZ(out  NumeroZeta, out  CantidadDFCancelados, out  CantidadDNFHEmitidos, out  CantidadDNFEmitidos, out  CantidadDFEmitidos, out  UltimoDocFiscalBC, out  UltimoDocFiscalA, out  MontoVentasDocFiscal, out  MontoIVADocFiscal, out  MontoImpInternosDocFiscal, out  MontoPercepcionesDocFiscal, out  MontoIVANoInscriptoDocFiscal, out  UltimaNotaCreditoBC, out  UltimaNotaCreditoA, out  MontoVentasNotaCredito, out  MontoIVANotaCredito, out  MontoImpInternosNotaCredito, out  MontoPercepcionesNotaCredito, out  MontoIVANoInscriptoNotaCredito, out  UltimoRemito, out  CantidadNCCanceladas, out  CantidadDFBCEmitidos, out  CantidadDFAEmitidos, out  CantidadNCBCEmitidas, out  CantidadNCAEmitidas);
                
                     //Fin German 20110225 - Tarea 0000077
                
                }
				ArrayList respuesta = new ArrayList();
				for (int i = 1; i<24; i++)
				{
					try {respuesta.Add(ImpFis1.get_Respuesta(i));}
					catch {	respuesta.Add("error");}					
				}
				Reporte._sucursal = _compPuntoDeVenta;				
				Reporte._fecha = ImpFis1.FechaHoraFiscal;
				Reporte._nroReporte = Convert.ToString(respuesta[2]);
				
				Reporte._nroCanceladosDF = Convert.ToDecimal(respuesta[3]);
				Reporte._nroEmitidosDNFH = Convert.ToDecimal(respuesta[4]);
				Reporte._nroEmitidosDNF = Convert.ToDecimal(respuesta[5]);
				Reporte._nroEmitidosDF = Convert.ToDecimal(respuesta[6]);

				Reporte._ultB = Convert.ToString(respuesta[8]);
				Reporte._ultA = Convert.ToString(respuesta[9]);
				Reporte._montoVentas = Convert.ToDecimal(respuesta[10]);
				Reporte._montoIVA = Convert.ToDecimal(respuesta[11]);
				Reporte._montoII = Convert.ToDecimal(respuesta[12]);
				Reporte._montoPercep = Convert.ToDecimal(respuesta[13]);
				Reporte._montoIVANi = Convert.ToDecimal(respuesta[14]);				
				Reporte._ultNCB = Convert.ToString(respuesta[15]);
				Reporte._ultNCA = Convert.ToString(respuesta[16]);
				Reporte._montoNC = Convert.ToDecimal(respuesta[17]);
				Reporte._montoIVANC = Convert.ToDecimal(respuesta[18]);
				Reporte._montoIINC = Convert.ToDecimal(respuesta[19]);
				Reporte._montoPercepNC = Convert.ToDecimal(respuesta[20]);
				Reporte._montoIVANiNC = Convert.ToDecimal(respuesta[21]);
				Reporte._ultRemito = Convert.ToString(respuesta[22]);										
			}
			else
			{
				CodMensajeInt = 181; //Ya hay un comprobante abierto
				return false;				
			}

			return true;
		}
		private bool ReporteInt(AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, char Tipo, ReporteFiscal Reporte)
		{
			string auxCloseType = String.Empty;
			string auxImpresion = String.Empty;
			string aux = "A";

			if (Tipo == 'X')
			{
				auxCloseType = "X";
				auxImpresion = "P";
			}
			else
			{
				auxCloseType = "Z";
				auxImpresion = "N";					
			}

			if (ImpFis2.CloseJournal(ref auxCloseType, ref auxImpresion)) 
			{
				Reporte._nroReporte = ImpFis2.AnswerField_3;
				Reporte._nroCanceladosDF = Decimal.Parse(ImpFis2.AnswerField_4);
				Reporte._nroEmitidosDNFH = Decimal.Parse(ImpFis2.AnswerField_5);
				Reporte._nroEmitidosDNF = Decimal.Parse(ImpFis2.AnswerField_6);
				Reporte._nroEmitidosDF = Decimal.Parse(ImpFis2.AnswerField_7);
				Reporte._ultA = ImpFis2.AnswerField_13;
				Reporte._ultB = ImpFis2.AnswerField_9;
				Reporte._montoVentas = Decimal.Parse(ImpFis2.AnswerField_10) / 100;
				Reporte._montoIVA = Decimal.Parse(ImpFis2.AnswerField_11) / 100;
				Reporte._montoII = 0;
				Reporte._montoPercep = Decimal.Parse(ImpFis2.AnswerField_12) / 100;
				Reporte._montoIVANi = 0;
				Reporte._ultNCB = "0";
				Reporte._ultNCA = "0";
				Reporte._montoNC = 0;
				Reporte._montoIVANC = 0;
				Reporte._montoIINC = 0;
				Reporte._montoPercepNC = 0;
				Reporte._montoIVANiNC = 0;
				Reporte._sucursal = _compPuntoDeVenta;
				
				ImpFis2.Status(ref aux);
				Reporte._ultRemito = ImpFis2.AnswerField_9;				
			}
			else 
			{				
				CodMensajeInt = (byte) (auxCloseType == "X" ? 183: 184);
				return false;
			}
			return true;			
		}

#endregion
	
#region Sobrecargas de ReporteAuditoriaInt
		private bool ReporteAuditoriaInt(HASARClass ImpFis1, int Numero)  
		{
			if (ImpFis1.EstadoControlador == 2) 
			{
                //German 20110225 - Tarea 0000077
				//ImpFis1.ReporteZIndividualPorNumero(Numero);

                object FechaZeta;
                object NumeroZeta;
                object UltimoDocFiscalBCut;
                object UltimoDocFiscalA;
                object MontoVentasDocFiscal;
                object MontoIVADocFiscal;
                object MontoImpInternosDocFiscal;
                object MontoPercepcionesDocFiscal;
                object MontoIVANoInscriptoDocFiscal;
                object UltimaNotaCreditoBC;
                object UltimaNotaCreditoA;
                object MontoVentasNotaCredito;
                object MontoIVANotaCredito;
                object MontoImpInternosNotaCredito;
                object MontoPercepcionesNotaCredito;
                object MontoIVANoInscriptoNotaCredito;
                object UltimoRemito;

                ImpFis1.ReporteZIndividualPorNumero( Numero, out  FechaZeta, out  NumeroZeta, out  UltimoDocFiscalBCut, out  UltimoDocFiscalA, out  MontoVentasDocFiscal, out  MontoIVADocFiscal, out  MontoImpInternosDocFiscal, out  MontoPercepcionesDocFiscal, out  MontoIVANoInscriptoDocFiscal, out  UltimaNotaCreditoBC, out  UltimaNotaCreditoA, out  MontoVentasNotaCredito, out  MontoIVANotaCredito, out  MontoImpInternosNotaCredito, out  MontoPercepcionesNotaCredito, out  MontoIVANoInscriptoNotaCredito, out  UltimoRemito);
                
                //Fin German 20110225 - Tarea 0000077
			}
			else
			{
				CodMensajeInt = 181; //Ya hay un comprobante abierto
				return false;				
			}

			return true;
		}
		private bool ReporteAuditoriaInt(HASARClass ImpFis1, int NumeroDesde, int NumeroHasta, bool ReporteGlobal)  
		{
			if (ImpFis1.EstadoControlador == 2) 
			{
				ImpFis1.ReporteZPorNumeros(NumeroDesde, NumeroHasta, ReporteGlobal);
			}
			else
			{
				CodMensajeInt = 181; //Ya hay un comprobante abierto
				return false;				
			}

			return true;
		}

		private bool ReporteAuditoriaInt(HASARClass ImpFis1, DateTime Fecha)  
		{
			if (ImpFis1.EstadoControlador == 2) 
			{
				//German 20110225 - Tarea 0000077
                //ImpFis1.ReporteZIndividualPorFecha(Fecha);

                object FechaZeta;
                object NumeroZeta;
                object UltimoDocFiscalBC;
                object UltimoDocFiscalA;
                object MontoVentasDocFiscal;
                object MontoIVADocFiscal;
                object MontoImpInternosDocFiscal;
                object MontoPercepcionesDocFiscal;
                object MontoIVANoInscriptoDocFiscal;
                object UltimaNotaCreditoBC;
                object UltimaNotaCreditoA;
                object MontoVentasNotaCredito;
                object MontoIVANotaCredito;
                object MontoImpInternosNotaCredito;
                object MontoPercepcionesNotaCredito;
                object MontoIVANoInscriptoNotaCredito;
                object UltimoRemito;

                ImpFis1.ReporteZIndividualPorFecha(Fecha, out  FechaZeta, out  NumeroZeta, out  UltimoDocFiscalBC, out  UltimoDocFiscalA, out  MontoVentasDocFiscal, out  MontoIVADocFiscal, out  MontoImpInternosDocFiscal, out  MontoPercepcionesDocFiscal, out  MontoIVANoInscriptoDocFiscal, out  UltimaNotaCreditoBC, out  UltimaNotaCreditoA, out  MontoVentasNotaCredito, out  MontoIVANotaCredito, out  MontoImpInternosNotaCredito, out  MontoPercepcionesNotaCredito, out  MontoIVANoInscriptoNotaCredito, out  UltimoRemito);

                //Fin German 20110225 - Tarea 0000077
			}
			else
			{
				CodMensajeInt = 181; //Ya hay un comprobante abierto
				return false;				
			}

			return true;
		}
		private bool ReporteAuditoriaInt(HASARClass ImpFis1, DateTime FechaDesde, DateTime FechaHasta, bool ReporteGlobal)  
		{
			if (ImpFis1.EstadoControlador == 2) 
			{
				ImpFis1.ReporteZPorFechas(FechaDesde, FechaHasta, ReporteGlobal);
			}
			else
			{
				CodMensajeInt = 181; //Ya hay un comprobante abierto
				return false;				
			}

			return true;
		}

#endregion
	
#region Sobrecargas de Reimpresion
private bool ReimprimirInt(HASARClass ImpFis1) 
{
	//for (int i = 2;i<=Copias;i++) {ImpFis1.ReimprimirComprobante();}
	ParametrosDeConfiguracion parametro = ParametrosDeConfiguracion.COPIAS_DOCUMENTOS;	
	string valor = _copias.ToString();
	ImpFis1.ConfigurarControlador(parametro, valor);
	ImpFis1.ReimprimirComprobante();	
	/*if (ImpFis1.HuboErrorFiscal )
	{
		return false;
	}
	if (ImpFis1.HuboFaltaPapel) 
	{
		return false;
	}
	if (ImpFis1.HuboErrorMecanico) 
	{
		return false;
	}*/
	return true;
}
#endregion

#region Sobrecargas de Informacion de configuracion
private bool ObtenerConfiguracionInt(HASARClass ImpFis1, ConfiguracionImpresora ci)  
{
	ci._cabecera1 = ImpFis1.get_Encabezado(1);
	ci._cabecera2 = ImpFis1.get_Encabezado(2);		
	return true;
}
#endregion
#region Sobrecargas de Carga de Informacion de configuracion
private bool CargarConfiguracionInt(HASARClass ImpFis1, ConfiguracionImpresora ci)  
{
	ImpFis1.set_Encabezado(1, ci.Cabecera1);
	ImpFis1.set_Encabezado(2, ci.Cabecera2);	
	return true;
}
#endregion
		
		private string UltNroComp(byte GrupoImpFis, HASARClass ImpFis, string CompAbrev, char CompClase, ulong NroInterno, byte vez) 
		{
			string NroComprobante = String.Empty;								
			
			ImpFis.PedidoDeStatus();
			if (CompAbrev == "FA" || CompAbrev == "ND") 
			{
				if (CompClase == 'A')
				{ 
                    //German 20110225 - Tarea 0000077
                    //NroComprobante = ImpFis.UltimaFactura.ToString();
                    NroComprobante = ImpFis.UltimoDocumentoFiscalA.ToString();
                    //Fin German 20110225 - Tarea 0000077
                }
				else 
				{
                    //German 20110225 - Tarea 0000077
                    //NroComprobante = ImpFis.UltimoTicket.ToString();
                    NroComprobante = ImpFis.UltimoDocumentoFiscalBC.ToString();
                    //Fin German 20110225 - Tarea 0000077
                }
				//'A': NroComprobante:= glImpFis1.UltimaFactura;
				//'B': NroComprobante:= glImpFis1.UltimoTicket;
			}
			if (CompAbrev == "NC") 
			{
				if (CompClase == 'A')
                { 
                    //German 20110225 - Tarea 0000077
                    //NroComprobante = ImpFis.get_Respuesta(8);
                    NroComprobante = ImpFis.UltimaNotaCreditoA.ToString();
                    //Fin German 20110225 - Tarea 0000077
                }
				else 
				{
                    //German 20110225 - Tarea 0000077
                    //NroComprobante = ImpFis1.get_Respuesta(7);
                    NroComprobante = ImpFis1.UltimaNotaCreditoBC.ToString();
                    //Fin German 20110225 - Tarea 0000077
                }
			}
			if (CompAbrev == "RM")
            {
                //German 20110225 - Tarea 0000077
                //NroComprobante = ImpFis1.get_Respuesta(9);
                NroComprobante = ImpFis1.UltimoRemito.ToString();
                //Fin German 20110225 - Tarea 0000077
            }
			return NroComprobante.PadLeft(8, '0');
		}
		private string UltNroComp(byte GrupoImpFis, AxEPSON_Impresora_Fiscal.AxPrinterFiscal ImpFis2, string CompAbrev, char CompClase, ulong NroInterno, byte vez) 
		{		
			string NroComprobante = String.Empty;
			string aux = "A";					
			ImpFis2.Status(ref aux);
			switch (CompAbrev) 
			{
				case "FA":
				case "ND":
					if (CompClase == 'A') 
					{
						if (vez == 1) 
						{NroComprobante = ImpFis2.AnswerField_7;}
						else
						{NroComprobante = ImpFis2.AnswerField_7;}
					}
					else
					{NroComprobante = ImpFis2.AnswerField_5;}
					break;
				case "NC":
					if (CompClase == 'A') 
					{NroComprobante = ImpFis2.AnswerField_11;}
					else
					{NroComprobante = ImpFis2.AnswerField_12;}
					break;
				case "TI":
					NroComprobante = ImpFis2.AnswerField_5;
					break;
				//German 20091007
				case "TF":
					if (CompClase == 'A') 
						NroComprobante = ImpFis2.AnswerField_7;
					else
						NroComprobante = ImpFis2.AnswerField_5;
					break;
				case "TINC":
					if (CompClase == 'A') 
						NroComprobante = ImpFis2.AnswerField_11;
					else
						NroComprobante = ImpFis2.AnswerField_12;
					break;
				//Fin German 20091007
				case "RX":
					NroComprobante = ImpFis2.AnswerField_8;
					break;
				case "RM":
					NroComprobante = ImpFis2.AnswerField_13;
					break;
			}		
			return NroComprobante;
		}

        /* Silvina 20110704 - Tarea 0000136 */
        public void ReimprimirTicketDeCambio(ArrayList Items, byte Puerto, int Velocidad)
        {
            _grupoImpFis = 2;
            ImprimeTicketDeCambio = true;
            bool Abrio = this.AbrirImpFis(Puerto, Velocidad);
            ImprimirTicketDeCambio(Items);         
        }
        /* Fin Silvina 20110704 - Tarea 0000136 */

	} //fin clase
}//fin espacio

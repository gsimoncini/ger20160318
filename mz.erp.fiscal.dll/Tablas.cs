using System;
using FiscalPrinterLib;
using mz.erp.systemframework;



namespace ParaisoFiscal
{
	/// <summary>
	/// Descripción breve de Tablas.
	/// </summary>
	public class Caracteristicas
	{

#region Propiedades
		
		private const byte _cliCantTipo = 10;
		//private const byte CantTipoDoc = 10;
		private const byte _compCantTipo = 15;

		private string _nombre;		
		public string Nombre { get {return _nombre;}}
		/*private byte _modelo;		
		public byte Modelo { get {return _modelo;}}*/

		private byte _linVarCant;		
		public byte LinVarCant { get {return _linVarCant;}}
		private byte _linVarLong;		
		public byte LinVarLong { get {return _linVarLong;}}
		private byte _linPieCant;				
		public byte LinPieCant { get {return _linPieCant;}}
		private byte _linPieLong;		
		public byte LinPieLong { get {return _linPieLong;}}

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

		private string _cliTipo;
		public string CliTipo { get {return _cliTipo;}}	 

		private bool _soportaCliTipo;
		public bool SoportaCliTipo { get {return _soportaCliTipo;}}	 

		private bool _soportaCompTipo;
		public bool SoportaCompTipo { get {return _soportaCompTipo;}}	 		

		private byte _compCodInterno;
		public byte CompCodInterno { get {return _compCodInterno;}} //Codificación interno de tipo de comprobante de las OCX.

		private string _compNombre;
		public string CompNombre { get {return _compNombre;}}	 

		private string _compAbrev;
		public string CompAbrev { get {return _compAbrev;}}

		private bool _cuentaCorrienteAutomatica;
		public bool CuentaCorrienteAutomatica {	get {return _cuentaCorrienteAutomatica;}}

		private int _velocidad; //Velocidad por defecto del controlador fiscal
		public int Velocidad { get {return _velocidad;}}
		

#endregion
		public Caracteristicas()
		{
		}
		public bool Inicializar(byte Grupo, byte CodImpFis, byte CodCompTipo, byte CodCliTipo)
		{
			_compNombre = Tablas.ObtenerCompNombre(CodCompTipo);
			_compAbrev = Tablas.ObtenerCompAbrev(CodCompTipo);
			_cliTipo = Tablas.ObtenerCliTipo(CodCliTipo) ;
			_compCodInterno = ObtenerCompCodInterno(Grupo, CodImpFis, CodCompTipo, CodCliTipo);				

			switch (Grupo)
			{
				case 1:											
					#region Carga variables grupo 1
					_linVarCant = 3;
					_linVarLong = 120;
					_linPieCant = 4;
					_linPieLong = 120;
					_linNumAsocCant = 2;
					_linNumAsocLong = 20;
					_linTextoCant = 15;
					_linTextoLong = 50;
					_linItemLong = 50;

					_linPagos = 4;
					_unidadesXArt = 999;
					_calcRboInterno = false; //El nro. de interno lo calcula la aplicacion cliente
					_cantidadEnteros = 3;
					_cantidadDecimales = 4;
					_preciosEnteros = -1; //Número negativo = numero desconocido.
					_preciosDecimales = 4;
					_impIntDecimales = 8;
					_tasasIVAxFact = 5;
					_percepXFact = 5;
					_vuelto = false;
					_velocidad = 9600;
					
					if (CodImpFis == 1 || CodImpFis == 2)
					{ _direccOblig = true;}
					else
					{ _direccOblig = false;}
								
					if (_compCodInterno > 0) 
					{ _soportaCompTipo = true; }
					else 
					{ _soportaCompTipo = false; }
					
					_soportaCliTipo = SoportaCliente(CodCliTipo);
					_cuentaCorrienteAutomatica = true;

					#endregion

					#region Nombres Impresoras fiscales grupo 1
					switch (CodImpFis)
					{
						case 1:	//ImpFis probada en sistemas.
							_nombre = "SMH/P-320F";							
							break;
						case 2:
							_nombre = "SMH/PJ-20F";
							break;
						case 3:
							_nombre = "HASAR SMH/P-321F";
							break;
						case 4:
							_nombre = "HASAR SMH/PL-8F";
							_velocidad = 19200;
							break;
						case 5:
							_nombre = "SMH/PL-614";
							break;
						case 6:
							_nombre = "SMH/PL-615";
							break;
						case 7:
							_nombre = "SMH/PL-PR4";
							break;
						case 8:
							_nombre = "SMH/PL-950";
							break;
						case 9:
							_nombre = "SMH/PL-951";
							break;				
						case 10:
							_nombre = "SMH/PL-262";
							break;
						case 20:
							_nombre = "HASAR SMH/P-322F";
							break;
						case 21:
							_nombre = "HASAR SMH/P-330F";
							break;
                        //German 20110225 - Tarea 0000077
                        case 22:
                            _nombre = "SMH/P-715F";
                            break;

                        //Fin German 20110225 - Tarea 0000077

					} //end del switch de nombre y modelo

					#endregion			 

					return true;//case del grupo 1
				case 2:
					#region Carga variables grupo 2

					switch (CodImpFis) 
					{
						case 11: 
						case 13:
						{
							_linVarCant = 3;
							_linVarLong = 40;
							_linPieCant = 3;
							_linPieLong = 80;
							_linNumAsocCant = 1;
							_linNumAsocLong = 40;
							_linTextoCant = 3;
							_linTextoLong = 43;
							_linItemLong = 43;
							//German
							//_linPagos = 4;
							_linPagos = 4;
							//Fin German
							break;
						}
						case 12: 
						{
							_linVarCant = 2;
							_linVarLong = 40;
							_linPieCant = 2;
							_linPieLong = 40;
							_linNumAsocCant = 1;
							_linNumAsocLong = 40;
							_linTextoCant = 3;
							_linTextoLong = 23;
							_linItemLong = 23;
							_linPagos = 4;
							break;
						}
						case 14: 
						{
							_linVarCant = 2;
							_linVarLong = 40;
							_linPieCant = 2;
							_linPieLong = 40;
							_linNumAsocCant = 2;
							_linNumAsocLong = 40;
							_linTextoLong = 25;
							_linItemLong = 18;
							_linTextoCant = 4;
							if (CodCompTipo == 16 || CodCompTipo == 17) 
							{_linPagos = 6;}
							else 
							{_linPagos = 5;}
							break;
						}
						default:
							_linVarCant = 2;
							_linVarLong = 40;
							_linPieCant = 2;
							_linPieLong = 40;
							_linNumAsocCant = 2;
							_linNumAsocLong = 40;
							_linTextoCant = 3;					
							_linVarCant = 2;
							_linVarLong = 40;
							_linTextoLong = 43;
							_linItemLong = 43;
							_linPagos = 4;
							break;
					}					
					
					_unidadesXArt = 50000;
					_calcRboInterno = true; //El nro. de interno lo calcula la aplicacion cliente
					_cantidadEnteros = 5;
					_cantidadDecimales = 3;
					_preciosEnteros = 7; 
					_preciosDecimales = 2;
					_impIntDecimales = -1;
					_tasasIVAxFact = 10;
					_percepXFact = 1;
					_vuelto = true;			
					_velocidad = 9600;
					_direccOblig = false;					
										
					if (_compCodInterno <= _compCantTipo & _compCodInterno > 0 & CodCompTipo > 0) 
					{ _soportaCompTipo = true; }
					else 
					{ _soportaCompTipo = false; }					

					_soportaCliTipo = SoportaCliente(CodCliTipo);
					_cuentaCorrienteAutomatica = false;

					#endregion

					#region Nombres Impresoras fiscales grupo 2
					switch (CodImpFis)
					{
						case 11:	//ImpFis probada en sistemas.
							_nombre = "LX-300F";
							break;
						case 12:	//ImpFis probada en sistemas.
							_nombre = "TM-U200";
							break;
						case 13:	//ImpFis probada en sistemas.
							_nombre = "LX-300F+";
							break;
						case 14:
							_nombre = "TM-U220";
							break;
					}
					#endregion			 

					return true;//case del grupo 2
				default: return false;
			}
		}	

		public bool SoportaCliente(byte CodCliTipo)
		{
			if (! (CodCliTipo > 0)) {return false;}
			if (! (CodCliTipo <= _cliCantTipo)) {return false;}
			return true;
		}

		private byte ObtenerCompCodInterno(byte grupo, byte CodImpFis, byte CodCompTipo, byte CodCliTipo)			
		{
			switch (grupo)
			{
				case 1:
					#region Codificación interna para nro. de comprobante. Grupo 1

                    //German 20110225 - Tarea 0000077
					if (CodCliTipo == 1 || CodCliTipo == 2) //RI y RNI
					{
                        if (CodImpFis != 22)//Para que sea compatible con la dd anterior, la 22 es la 715 que es tickeadora
                        {

                            switch (CodCompTipo)
                            {
                                case 1: return 65;//DocumentosFiscales.FACTURA_A
                                case 2: return 68;//DocumentosFiscales.NOTA_DEBITO_A
                                case 3: return 82;//DocumentosNOFiscales.NOTA_CREDITO_A
                                case 4: return 65;//DocumentosFiscales.FACTURA_A
                                case 5: return 97;//DocumentosFiscales.RECIBO_A
                            }

                        }
                        else //Es la tickeadora fiscal 715
                        {
                            switch (CodCompTipo)
                            {
                                case 1: return 48;//TICKET_FACTURA_A
                                case 2: return 50;//TICKET_NOTA_DEBITO_A 
                                case 3: return 52;//DocumentosNOFiscales.TICKET_NOTA_CREDITO_A
                                case 4: return 48;//TICKET_FACTURA_A
                                case 5: return 97;//DocumentosFiscales.RECIBO_A VER SI LO SOPORTA LA 715
                            }
                        }
					}
					else
					{
                        if (CodImpFis != 22)//Para que sea compatible con la dd anterior, la 22 es la 715 que es tickeadora
                        {
                            switch (CodCompTipo)
                            {
                                case 1: return 66;//DocumentosFiscales.FACTURA_B
                                case 2: return 69;//DocumentosFiscales.NOTA_DEBITO_B
                                case 3: return 83;//DocumentosNOFiscales.NOTA_CREDITO_B
                                case 4: return 66;//DocumentosFiscales.FACTURA_B
                                case 5: return 98;//DocumentosFiscales.RECIBO_B
                            }
                        }
                        else
                        {
                            switch (CodCompTipo)
                            {
                                case 1: return 49;//TICKET_FACTURA_B
                                case 2: return 51;//TICKET_NOTA_DEBITO_B
                                case 3: return 53;//DocumentosNOFiscales.TICKET_NOTA_CREDITO_B
                                case 4: return 49;//TICKET_FACTURA_B
                                case 5: return 98;//DocumentosFiscales.RECIBO_B VER SI LO SOPORTA LA 715
                            }
                        }
					}
                    //Fin German 20110225 - Tarea 0000077
				switch (CodCompTipo)
				{
					case 6: return 120;
					case 7: return 114;
					case 8: return 0;			
					case 9: return 115;
					case 10: return 117;
					case 11: return 116;
					case 12: return 0;
					case 13: return 0;
					case 14: return 0;
					case 15: return 85;
					default: return 0;
				}
				#endregion
				case 2:
					#region Codificación interna para nro. de comprobante. Grupo 2
					switch (CodCompTipo) 
					{ 
						case 1: 
						{
							switch (CodImpFis) 
							{
								case 11: return 1;
								case 12: return 0;
								case 13: return 1;
								case 14: return 0;
								default: return 0;
							}
						}
						case 2:  
						{
							switch (CodImpFis) 
							{
								case 11: return 1;
								case 12: return 0;
								case 13: return 1;
								case 14: return 0;
								default: return 0;
							}
						}
						case 3: 
						{
							switch (CodImpFis) 
							{
								case 11: return 0;
								case 12: return 0;
								case 13: return 1;
								case 14: return 0;
								default: return 0;
							}
						}
						case 4: 
						{
							switch (CodImpFis) 
							{
								case 12: return 1;
								case 14: return 1;
								default: return 0;
							}
						}
						case 5: return 0;
						case 6: return 1;
						case 7: 
						{
							switch (CodImpFis) 
							{
								case 11: return 0;
								case 12: return 0;
								case 13: return 1;
								default: return 0;
							}
						}
						case 8: 
						case 9: 
						case 10:
						case 11:
						case 12:
						case 13:
						case 14:
						case 15: 						
							return 0;							
						case 16: 
						{
							switch (CodImpFis) 
							{
								case 12: return 1;
								case 14: return 1;
								default: return 0;
							}
						}
						case 17: 
						{
							switch (CodImpFis) 
							{								
								case 14: return 1;
								default: return 0;
							}
						}

						default: return 0;
						break;
					}
				#endregion
				default: return 0;
			}
		}		
	}

	public class Tablas
	{
        //German 20110225 - Tarea 0000077
		//private const byte _cantImpFis = 21; //Cant. de impresoras fiscales;
        private const byte _cantImpFis = 22; //Cant. de impresoras fiscales;
        //Fin German 20110225 - Tarea 0000077
		public Tablas()
		{
		}

		public static string ObtenerCliTipo(byte CodCliTipo) 
		{
			switch (CodCliTipo)
			{
				case 1:	return "Responsable inscripto";
				case 2:	return "Responsable NO inscripto";
				case 3:	return "Responsable exento";
				case 4:	return "No responsable";
				case 5:	return "Consumidor final";
				case 6:	return "Bienes de uso";
				case 7:	return "Monotributo";
				case 8:	return "No categorizado";
				default: return String.Empty;
			}
		}

		public static string EstadoImpfis(byte Codigo) 
		{
		    string mensaje = "";
			switch (Codigo)
			{
				//mensajeES DE APERTURA DE IMPRESORA FISCAL				
				case 1:	mensaje = "Error al abrir el puerto"; break;
				case 2:	mensaje = "Código de impresora incorrecto"; break;
				case 3:	mensaje = "Memoria fiscal no formateada"; break;
				case 4:	mensaje = "Memoria fiscal no inicializada"; break;
				case 5:	mensaje = "ERROR mecánico de impresora. Verifique el papel"; break;
				case 6:	mensaje = "Impresora fuera de línea"; break;
				case 7:	mensaje = "No se pudo abrir la impresora"; break;
				case 8: mensaje = "Se necesita realizar cierre de la jornada fiscal"; break;
				case 9: mensaje = "Impresora fiscal desfiscalizada"; break;//No está en el manual pero salió este error con la ex fiscal de MZ que ya estaba desfiscalizada.
				case 10: mensaje = "Comando no válido para estado fiscal"; break;
				case 11: mensaje = "Memoria fiscal llena"; break;
				case 12: mensaje = "Memoria fiscal casi llena"; break;
				case 13: mensaje = "Poca batería"; break;
				case 14: mensaje = "Desbordamiento de totales"; break;

				//ERRORES DE APERTURA DE COMPROBANTE FISCAL
				case 20: mensaje = "Un comprobante se encuentra abierto"; break;
				case 21: mensaje = "No se pudo abrir el comprobante"; break;
				case 22: mensaje = "Comprobante no incorporado en el módulo"; break;
				case 23: mensaje = "Código de impresora incorrecto"; break;
				case 24: mensaje = "Datos inválidos en el cliente"; break;
				case 25: mensaje = "Nro de comprobante inválido para el comprobante"; break;
				case 26: mensaje = "Ya hay un comprobante abierto"; break;
				case 27: mensaje = "Ya hay un comprobante no fiscal abierto"; break;
				case 28: mensaje = "No se pudo abrir el comprobante. Revise el nro. de comprobante asociado."; break;

				//ERRORES DE GRABACION DE ITEM FISCAL
				case 40: mensaje = "No hay ningún comprobante abierto"; break;
				case 41: mensaje = "Error al grabar ítem"; break;
				case 42: mensaje = "Datos incorrectos para grabar el ítem"; break;
				case 43: mensaje = "ERROR al imprimir ítem en remito"; break;
				case 44: mensaje = "Código de impresora incorrecto";  break;
				case 45: mensaje = "No hay ningún comprobante abierto"; break;
				case 46: mensaje = "Comprobante cancelado por zonas"; break;
				case 47: mensaje = "Se necesita realizar transporte de factura"; break;
				case 48: mensaje = "ERROR al grabar item. Verifique el importe total"; break;

				//ERRORES DE DESCUENTOS/RECARGOS
				case 60: mensaje = "ERROR en el monto del descuento"; break;
				case 61: mensaje = "ERROR en el monto del recargo"; break;
				case 62: mensaje = "No hay ningún comprobante abierto"; break;
				case 63: mensaje = "Descuento general no soportado para el comprobante abierto"; break;
				case 64: mensaje = "Recargo general no soportado para el comprobante abierto"; break;
				case 65: mensaje = "No se pudo grabar el descuento"; break;
				case 66: mensaje = "No se pudo grabar el recargo"; break;
				case 67: mensaje = "Código de impresora incorrecto";  break;

				//ERRORES DE PERCEPCIONES
				case 80: mensaje = "No se pudo grabar la percepción por monto 0"; break;
				case 81: mensaje = "No hay ningún comprobante abierto"; break;
				case 82: mensaje = "No se puede aplicar la percepción general"; break;
				case 83: mensaje = "No se puede aplicar la percepción al IVA"; break;
				case 84: mensaje = "No se puede aplicar la percepción al IVA para facturas B"; break;
				case 85: mensaje = "Código de impresora incorrecto";  break;

				//ERRORES DE PAGOS
				case 100: mensaje = "No se pudo grabar el pago por monto 0"; break;
				case 101: mensaje = "No hay ningún comprobante abierto"; break;
				case 102: mensaje = "No se pudo grabar el pago"; break;	
				case 103: mensaje = "Pago no soportado para el comprobante abierto"; break;
				case 104: mensaje = "Código de impresora incorrecto"; break;

				//ERRORES DE OBSERVACIONES DE PAGOS
				case 110: mensaje = "No se pudo imprimir la observación del pago"; break;
				case 111: mensaje = "Observación no soportada para el comprobante abierto"; break;

				//ERRORES DE SUBTOTAL
				case 116: mensaje = "Código de impresora incorrecto";  break;
				case 117: mensaje = "No hay ningún comprobante abierto"; break;
				case 118: mensaje = "Fallo en la impresora fiscal"; break;
				case 119: mensaje = "Subtotal no soportado para el comprobante abierto"; break;

				//ERRORES DE CIERRE DE COMPROBANTE
				case 120: mensaje = "No hay ningún comprobante abierto"; break;
				case 121: mensaje = "Operación no soportada para el comprobante"; break;
				case 122: mensaje = "No se puede cerrar el comprobante porque no hay ventas"; break;
				case 123: mensaje = "Código de impresora incorrecto";  break;
				case 124: mensaje = "No se pudo cerrar el comprobante"; break;
				case 125: mensaje = "No se puede cerrar el comprobante. Verifique el importe total"; break;//Cuando el cliente no tiene cargado nro. de DNI y la venta es > 1000
 
				//ERRORES DE CIERRE DE IMPRESORA FISCAL				
				case 140: mensaje = "La impresora fiscal no se pudo cerrar"; break;

				//ERRORES DE CANCELACION
				case 160: mensaje = "No se pudo cancelar el comprobante"; break;
				case 161: mensaje = "Código de impresora incorrecto"; break;
				case 162: mensaje = "No hay ningún comprobante abierto"; break;
				case 163: mensaje = "Cancelación no soportada para el comprobante abierto"; break;

				//ERRORES DE REPORTES X y Z
				case 180: mensaje = "Tipo de reporte desconocido"; break;
				case 181: mensaje = "Ya hay un comprobante abierto"; break;
				case 182: mensaje = "No hay ningún comprobante abierto"; break;
				case 183: mensaje = "No se pudo generar el reporte X"; break;
				case 184: mensaje = "No se pudo generar el reporte Z"; break;
				case 185: mensaje = "No se pudo generar el reporte de auditoría"; break;

				//MENSAJES DE OK
				case 200: mensaje = "Impresora fiscal abierta"; break;
				case 201: mensaje = "Comprobante fiscal abierto"; break;
				case 202: mensaje = "Item impreso"; break;
				case 203: mensaje = "Descuento grabado"; break;
				case 204: mensaje = "Percepción grabada"; break;
				case 205: mensaje = "Pago grabado"; break;
				case 206: mensaje = "Comprobante cerrado."; break;
				case 207: mensaje = "Impresora cerrada"; break;
				case 208: mensaje = "Comprobante fiscal cancelado"; break;
				case 209: mensaje = "Reporte fiscal X emitido"; break;
				case 210: mensaje = "Recargo grabado"; break;
				case 211: mensaje = "Subtotal devuelto"; break;
				case 212: mensaje = "Percepción al IVA grabada"; break;
				case 213: mensaje = "Reporte fiscal Z emitido"; break;
				case 214: mensaje = "Reporte de auditoría emitido"; break;
				case 215: mensaje = "Observación de pago grabada"; break;

				case 220: mensaje = "Configurando impresora fiscal"; break;
				case 221: mensaje = "Abriendo impresora fiscal";break;
				case 222: mensaje = "Abriendo comprobante fiscal";break;
				case 223: mensaje = "Cancelando comprobante fiscal anterior";break;
				case 224: mensaje = "Cancelando comprobante fiscal";break;
				case 225: mensaje = "Cerrando comprobante fiscal";break;
				default: mensaje = String.Empty; break;				
			}
			if (Codigo < 200)
				mensaje = HTML.Bold(mensaje);
			return mensaje;
		}
		
		public static string ObtenerCompNombre(byte CodCompTipo)
		{
			switch (CodCompTipo)
			{
				case 1:	return "Factura";
				case 2: return "Nota de débito";
				case 3:	return "Nota de crédito";
				case 4: return "Ticket";
				case 5:	return "Recibo";
				case 6: return "Recibo X";
				case 7:	return "Remito";
				case 8: return "Presupuesto";
				case 9:	return "Orden de salida";
				case 10: return "Cotización";
				case 11: return "Resumen de cuenta";
				case 12: return "Voucher";
				case 13: return "Pagaré";
				case 14: return "Informe de auditoría";
				case 15: return "Cargo habitacion";
				case 16: return "Ticket factura";
				case 17: return "Ticket NC";
				default: return String.Empty;
			}
		}
		public static string ObtenerCompAbrev(byte CodCompTipo)
		{
			switch (CodCompTipo)
			{
				case 1:	return "FA";
				case 2: return "ND";
				case 3:	return "NC";
				case 4: return "TI";
				case 5:	return "RE";
				case 6: return "RX";
				case 7:	return "RM";
				case 8: return "PR";
				case 9:	return "OS";
				case 10: return "CO";
				case 11: return "RC";
				case 12: return "VO";
				case 13: return "PA";
				case 14: return "IA";
				case 15: return "CH";
				case 16: return "TF";
				case 17: return "TINC";
				default: return String.Empty;
			}
		}

		public static string ObtenerTipoDocumento(byte DocTipo)		
		{
			switch (DocTipo)
			{
				case 1:	return "C.U.I.T";
				case 2: return "L.E.";
				case 3:	return "L.C.";
				case 4: return "D.N.I.";
				case 5:	return "Pasaporte";
				case 6: return "C.I.";							
				default: return "Ninguno";
			}
		}

		public static byte VerGrupo(byte CodImpFis)
		{
			//para distinguir la OCX a utilizar de la impresora fiscal			

			if (CodImpFis > _cantImpFis)
			{
				return 0;
			}

			switch (CodImpFis)
			{

				case 1: 
				case 2: 
				case 3: return 1;
				case 4: return 1;
				//case 4: 1;
				//case 5: 1;
				//case 6: 1;
				//case 7: 1;
				//case 8: 1;
				//case 9: 1;
				//case 10: 1;
				case 11: return 2;
				case 12: return 2;
				case 13: return 2;
				case 14: return 2;
				//case 15: 1;
				case 20: return 1;
				case 21: return 1;
                //German 20110225 - Tarea 0000077
                case 22: return 1;
                //Fin German 20110225 - Tarea 0000077
				default: return 0;
			}			
			//Obtengo a qué grupo pertenece la impresora fiscal a utilizar						
		}
		public static ModelosDeImpresoras ObtenerModelo(byte CodImpFis) 
		{
			switch (CodImpFis) 
			{
				case 1: return ModelosDeImpresoras.MODELO_P320;
				case 3: return ModelosDeImpresoras.MODELO_P320; //Vale para la Hasar 321.
				case 4: return ModelosDeImpresoras.MODELO_PJ20;
				case 20: return ModelosDeImpresoras.MODELO_P320; //Vale para la Hasar 322.
				case 21: return ModelosDeImpresoras.MODELO_P320; //Vale para la Hasar 330?????????.
                //German 20110225 - Tarea 0000077
                case 22: return ModelosDeImpresoras.MODELO_715;
                //Fin German 20110225 - Tarea 0000077
				default: return 0;
			}			
		}
		public static TiposDeDocumento ObtenerTipoDocumentoInt(byte DocTipo) 
		{
			switch (DocTipo) 
			{					
				case 1:	return TiposDeDocumento.TIPO_CUIT;
				case 2: return TiposDeDocumento.TIPO_LE;
				case 3:	return TiposDeDocumento.TIPO_LC;
				case 4: return TiposDeDocumento.TIPO_DNI;
				case 5:	return TiposDeDocumento.TIPO_PASAPORTE;
				case 6: return TiposDeDocumento.TIPO_CI;
				default: return TiposDeDocumento.TIPO_NINGUNO;									
			}
		}
		public static TiposDeResponsabilidades ObtenerCliTipoInt(byte CodCliTipo) 
		{				
			switch (CodCliTipo)
			{
				case 1:	return TiposDeResponsabilidades.RESPONSABLE_INSCRIPTO;
				case 2:	return TiposDeResponsabilidades.RESPONSABLE_NO_INSCRIPTO;
				case 3:	return TiposDeResponsabilidades.RESPONSABLE_EXENTO;
				case 4:	return TiposDeResponsabilidades.NO_RESPONSABLE;				
				case 5:	return TiposDeResponsabilidades.CONSUMIDOR_FINAL;
				case 6:	return TiposDeResponsabilidades.BIENES_DE_USO;
				case 7:	return TiposDeResponsabilidades.MONOTRIBUTO;
				case 8:	return TiposDeResponsabilidades.NO_CATEGORIZADO;				
				default: return TiposDeResponsabilidades.CONSUMIDOR_FINAL;
			}									
		}
		public static DocumentosFiscales ObtenerDocumentosFiscales(byte CompCodInterno) 
		{
			switch (CompCodInterno) 
			{
				case 84: return DocumentosFiscales.TICKET_C;
				case 65: return DocumentosFiscales.FACTURA_A;
				case 66: return DocumentosFiscales.FACTURA_B;
				case 48: return DocumentosFiscales.TICKET_FACTURA_A;								
				case 49: return DocumentosFiscales.TICKET_FACTURA_B;
				case 97: return DocumentosFiscales.RECIBO_A;
				case 98: return DocumentosFiscales.RECIBO_B;
				case 68: return DocumentosFiscales.NOTA_DEBITO_A;
				case 69: return DocumentosFiscales.NOTA_DEBITO_B;
                //German 20110225 - Tarea 0000077
                case 50: return DocumentosFiscales.TICKET_NOTA_DEBITO_A;
				case 51: return DocumentosFiscales.TICKET_NOTA_DEBITO_B;
                //Fin German 20110225 - Tarea 0000077
                default: return DocumentosFiscales.FACTURA_B;
			}						
		}
		public static DocumentosNoFiscales ObtenerDocumentosNOFiscales(byte CompCodInterno) 
		{
			switch (CompCodInterno) 
			{
					case 85: return DocumentosNoFiscales.CARGO_HABITACION;
					case 117: return DocumentosNoFiscales.COTIZACION;
					case 82: return DocumentosNoFiscales.NOTA_CREDITO_A;
					case 83: return DocumentosNoFiscales.NOTA_CREDITO_B;

                    //German 20110225 - Tarea 0000077
                    case 52: return DocumentosNoFiscales.TICKET_NOTA_CREDITO_A;
					case 53: return DocumentosNoFiscales.TICKET_NOTA_CREDITO_B;
                    //Fin German 20110225 - Tarea 0000077

					case 115: return DocumentosNoFiscales.ORDEN_SALIDA;
					case 120: return DocumentosNoFiscales.RECIBO_X;
					case 114: return DocumentosNoFiscales.REMITO;
					case 116: return DocumentosNoFiscales.RESUMEN_CUENTA;				
				default: return DocumentosNoFiscales.REMITO;
			}						
		}
	}
}


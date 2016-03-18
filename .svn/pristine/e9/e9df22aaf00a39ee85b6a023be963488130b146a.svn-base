using System;
using System.Text;
using EpsonFPHostControlX;
using System.Runtime.InteropServices;

namespace ParaisoFiscal
{
	/// <summary>
	/// Descripción breve de ProtocoloEpson.
	/// </summary>
	public class ProtocoloEpson
	{
		private EpsonFPHostControl _LaImpresora;

		#region Acceso a la dll controladora del OCX

		[DllImport("protEpsonNuevo.dll", EntryPoint="dConectar")]  
        public static extern bool dConectar();
		[DllImport("protEpsonNuevo.dll", EntryPoint="dDesconectar")]  
        public static extern bool dDesconectar();
		[DllImport("protEpsonNuevo.dll", EntryPoint="dSaltoPagina")]  
        public static extern void dSaltoPagina();
		[DllImport("protEpsonNuevo.dll", EntryPoint="dCortarPapel")]  
		public static extern void dCortarPapel();
		[DllImport("protEpsonNuevo.dll", EntryPoint="dCancelarPago")]  
		public static extern void dCancelarPago();
		[DllImport("protEpsonNuevo.dll", EntryPoint="dTicketApertura")]  
		public static extern bool dTicketApertura();
        [DllImport("protEpsonNuevo.dll", EntryPoint="dTicketItem")]  
		public static extern bool dTicketItem (   string DescripcionItem
												, string Cantidad
												, string PrecioUnitario
												, string TasaIVA
												, string ImpuestoInterno
												, string CoeficienteImpInterno
												, string DescripcionExtra1
												, string DescripcionExtra2
												, string DescripcionExtra3
												, string DescripcionExtra4
												);
        [DllImport("protEpsonNuevo.dll", EntryPoint="dTicketPago")]
		public static extern bool dTicketPago ( string DescripcionPago
			                                   ,string Monto
 			                                   ,string DescripcionExtra
			                                   );
		[DllImport("protEpsonNuevo.dll", EntryPoint="dTicketCerrar")]
		public static extern bool dTicketCerrar(  string PosicionColaReemplazo1
										 	 	 ,string DescripcionColaReemplazo1
											 	 ,string PosicionColaReemplazo2
												 ,string DescripcionColaReemplazo2
												 ,string PosicionColaReemplazo3
												 ,string DescripcionColaReemplazo3
			                                    );
		
		[DllImport("protEpsonNuevo.dll", EntryPoint="dTicketFacturaApertura")]  
		public static extern bool dTicketFacturaApertura( string NombreCliente1
				                                  ,string NombreCliente2
				                                  ,string DomicilioCliente1
				                                  ,string DomicilioCliente2
				                                  ,string DomicilioCliente3
				                                  ,string DomicilioCliente4
				                                  ,string TipoDocumento
				                                  ,string NroDocumento
				                                  ,string ResponsabilidadIVA
				                                  ,string RemitoAsociado1
				                                  ,string RemitoAsociado2);
       [DllImport("protEpsonNuevo.dll", EntryPoint="dTicketFacturaItem")]  
		public static extern bool dTicketFacturaItem (   string DescripcionItem
												, string Cantidad
												, string PrecioUnitario
												, string TasaIVA
												, string ImpuestoInterno
												, string CoeficienteImpInterno
												, string DescripcionExtra1
												, string DescripcionExtra2
												, string DescripcionExtra3
												, string DescripcionExtra4
												);
        [DllImport("protEpsonNuevo.dll", EntryPoint="dTicketFacturaPago")]
		public static extern bool dTicketFacturaPago ( string DescripcionPago
			                                   ,string Monto
 			                                   ,string DescripcionExtra
			                                   );
		[DllImport("protEpsonNuevo.dll", EntryPoint="dTicketFacturaCerrar")]
		public static extern bool dTicketFacturaCerrar(  string PosicionColaReemplazo1
										 	 	 ,string DescripcionColaReemplazo1
											 	 ,string PosicionColaReemplazo2
												 ,string DescripcionColaReemplazo2
												 ,string PosicionColaReemplazo3
												 ,string DescripcionColaReemplazo3
			                                    );
       [DllImport("protEpsonNuevo.dll", EntryPoint="dTicketCambio")]
		public static extern bool dTicketCambio ( string DatosLibres1
										  		 ,string DatosLibres2
												 ,string DatosLibres3
												 ,string DatosLibres4
												 ,string PosicionColaReemplazo1
												 ,string DescripcionColaReemplazo1
												 ,string PosicionColaReemplazo2
												 ,string DescripcionColaReemplazo2
												 ,string PosicionColaReemplazo3
												 ,string DescripcionColaReemplazo3
		                                         );

		#endregion

		public ProtocoloEpson()
		{
			_LaImpresora = new EpsonFPHostControl ();
		}

		#region Propiedades
		public TxCommPort Puerto
		{
			get {return _LaImpresora.CommPort; }

  	        set
			{
		   	  _LaImpresora.CommPort = value;			    
			}
		}
		
		public TxBaudRate Velocidad
		{
			get {return _LaImpresora.BaudRate;}
			set 
			{
				_LaImpresora.BaudRate = value;
			}
		}

	    public TxFiscalState Estado
		{
			get {return _LaImpresora.State ;}
		}

		public TxProtocolType Protocolo
		{
			get {return _LaImpresora.ProtocolType; }
			set {_LaImpresora.ProtocolType = value;}
		}

		public TxErrorType UltimoError
		{
			get {return _LaImpresora.LastError;}
		}

		public int ConteoCamposExtra
		{
			get {return _LaImpresora.ExtraFieldsCount; }
		}

		public int EstatusFiscal
		{
			get {return _LaImpresora.FiscalStatus;}
		}

		public int CodigoRetorno
		{
			get {return _LaImpresora.ReturnCode;}
		}
		#endregion

		#region Metodos generales del controlador
	
		//Inicializo el dispositivo. En caso de error, devuelve false
		public bool Conectar() 
		{
			return dConectar();
		}


		//Cierra la conexión con el dispositivo. En caso de error, devuelve false
		public bool Desconectar()
		{
			return dDesconectar();
		}



		#region Indexado de tablas de configuración

		//Esto es a modo ayudamemoria, están indexadas las distintas velocidades reconocidas por el controlador
		public TxBaudRate Int2BaudRate (int valor )
		{
			switch (valor)
			{
					case 0: return TxBaudRate.br1200;
					break;
					case 1: return TxBaudRate.br2400;
					break;
					case 2: return TxBaudRate.br4800;
					break;
					case 3: return TxBaudRate.br9600;
					break;
					case 4: return TxBaudRate.br19200;
					break;
					case 5: return TxBaudRate.br38400;	
					break;
				    default: return TxBaudRate.br1200;
			}
		    
		}

		
		//Estn indexados los puertos reconocidos por el controlador
		public TxCommPort Int2CommPort (int valor)
		{
			switch (valor)
			{
				case 0: return TxCommPort.Com1;
				break;
				case 1: return TxCommPort.Com2;
				break;
				case 2: return TxCommPort.Com3;
				break;
				case 3: return TxCommPort.Com4;
				break;
				default: return TxCommPort.Com1; 
			}
		}


		public int Estado2Int (TxFiscalState valor)
		{
			switch (valor)
			{
				case TxFiscalState.EFP_S_Close: return  0;
				break;
				case TxFiscalState.EFP_S_Idle: return  1;
				break;
				case TxFiscalState.EFP_S_Busy: return 2;
				break;
				default: return 0;
			}
		}


		public int Error2Int (TxErrorType valor)
		{
			switch (valor)
			{
				case TxErrorType.EFP_Success: return  0;
				break;
				case TxErrorType.EFP_E_ComInUse: return 1;
				break;
				case TxErrorType.EFP_E_InvalidCom: return 2;
				break;
				case TxErrorType.EFP_E_ComAlreadyOpen: return 3;
				break;
				case TxErrorType.EFP_E_ComAlreadyClose: return 4;
				break;
				case TxErrorType.EFP_E_BadInitialization: return 5;
				break;
				case TxErrorType.EFP_E_ComClose: return 6;
				break;
				case TxErrorType.EFP_E_MaxDataLengthReached: return 7;
				break;
				case TxErrorType.EFP_E_InvalidDataInField: return 8;
				break;
				case TxErrorType.EFP_E_OperationInProgress: return 9;
				break;
				case TxErrorType.EFP_E_WriteError: return 10;
				break;
				case TxErrorType.EFP_E_ReadTimeOut: return 11;
				break;
				case TxErrorType.EFP_E_NackReceived: return 12;
				break;
				case TxErrorType.EFP_E_InvalidIndex: return 13;
				break;				
				default: return 0;
				break;					
			}
		}


		public TxProtocolType Int2Protocol (int valor)
		{
			switch (valor)
			{
				case 0: return TxProtocolType.protocol_Compatible;
					break;
				case 1: return TxProtocolType.protocol_Extended;
					break;
				default: return TxProtocolType.protocol_Compatible; 
			}
		}

  
		#endregion

		#endregion

  
		public void Cancelar ()
		{
            dCancelarPago();
		}
    
		public void SaltoPagina() 
		{ 
			dSaltoPagina();
		}


		public void CortarPapel() 
		{
			dCortarPapel();
		}
		#region Metodos usados en el Ticket de venta


		public bool TicketApertura ()
		{
			return dTicketApertura();
		}
		

		public bool TicketItem (  string DescripcionItem
		                    	, string Cantidad
			                    , string PrecioUnitario
			                    , string TasaIVA
			                    , string ImpuestoInterno
			                    , string CoeficienteImpInterno
			                    , string DescripcionExtra1
			                    , string DescripcionExtra2
			                    , string DescripcionExtra3
			                    , string DescripcionExtra4)
		{
 		    return dTicketItem (DescripcionItem, Cantidad, PrecioUnitario, TasaIVA, ImpuestoInterno, CoeficienteImpInterno
			                    , DescripcionExtra1, DescripcionExtra2, DescripcionExtra3, DescripcionExtra4);
		}


		public bool TicketPago ( string DescripcionPago
			                    ,string Monto
			                    ,string DescripcionExtra)		

		{
			return dTicketPago ( DescripcionPago, Monto, DescripcionExtra);

		}


		public bool TicketCerrar ( string PosicionColaReemplazo1
			                      ,string DescripcionColaReemplazo1
			                      ,string PosicionColaReemplazo2
			                      ,string DescripcionColaReemplazo2
			                      ,string PosicionColaReemplazo3
			                      ,string DescripcionColaReemplazo3)
		{
			return dTicketCerrar ( PosicionColaReemplazo1, DescripcionColaReemplazo1, PosicionColaReemplazo2
				                  , DescripcionColaReemplazo2, PosicionColaReemplazo3, DescripcionColaReemplazo3);
		}

        #endregion
	
		#region Metodos usados en el TicketFactura de venta


		public bool TicketFacturaApertura ( string NombreCliente1
									,string NombreCliente2
									,string DomicilioCliente1
									,string DomicilioCliente2
									,string DomicilioCliente3
									,string DomicilioCliente4
									,string TipoDocumento
									,string NroDocumento
									,string ResponsabilidadIVA
									,string RemitoAsociado1
									,string RemitoAsociado2)
		{
			return dTicketFacturaApertura(NombreCliente1, NombreCliente2, DomicilioCliente1, DomicilioCliente2, DomicilioCliente3
				                 , DomicilioCliente4, TipoDocumento, NroDocumento, ResponsabilidadIVA, RemitoAsociado1
				                 , RemitoAsociado2);
		}
		

		public bool TicketFacturaItem (  string DescripcionItem
		                    	, string Cantidad
			                    , string PrecioUnitario
			                    , string TasaIVA
			                    , string ImpuestoInterno
			                    , string CoeficienteImpInterno
			                    , string DescripcionExtra1
			                    , string DescripcionExtra2
			                    , string DescripcionExtra3
			                    , string DescripcionExtra4)
		{
 		    return dTicketFacturaItem (DescripcionItem, Cantidad, PrecioUnitario, TasaIVA, ImpuestoInterno, CoeficienteImpInterno
			                    , DescripcionExtra1, DescripcionExtra2, DescripcionExtra3, DescripcionExtra4);
		}


		public bool TicketFacturaPago ( string DescripcionPago
			                    ,string Monto
			                    ,string DescripcionExtra)		

		{
			return dTicketFacturaPago ( DescripcionPago, Monto, DescripcionExtra);

		}


		public bool TicketFacturaCerrar ( string PosicionColaReemplazo1
			                      ,string DescripcionColaReemplazo1
			                      ,string PosicionColaReemplazo2
			                      ,string DescripcionColaReemplazo2
			                      ,string PosicionColaReemplazo3
			                      ,string DescripcionColaReemplazo3)
		{
			return dTicketFacturaCerrar ( PosicionColaReemplazo1, DescripcionColaReemplazo1, PosicionColaReemplazo2
				                  , DescripcionColaReemplazo2, PosicionColaReemplazo3, DescripcionColaReemplazo3);
		}

        #endregion
		
		#region Metodos usados en el Ticket de Cambio
		public bool TicketCambio ( string DatosLibres1
			                      ,string DatosLibres2
			                      ,string DatosLibres3
			                      ,string DatosLibres4
			                      ,string PosicionColaReemplazo1
			                      ,string DescripcionColaReemplazo1
			                      ,string PosicionColaReemplazo2
			                      ,string DescripcionColaReemplazo2
			                      ,string PosicionColaReemplazo3
			                      ,string DescripcionColaReemplazo3)
		{
			return dTicketCambio (DatosLibres1, DatosLibres2, DatosLibres3, DatosLibres4, PosicionColaReemplazo1
				                 , DescripcionColaReemplazo1, PosicionColaReemplazo2, DescripcionColaReemplazo2
				                 , PosicionColaReemplazo3, DescripcionColaReemplazo3);
		}

		#endregion

	}
}

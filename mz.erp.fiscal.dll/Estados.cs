using System;

namespace ParaisoFiscal
{
	/// <summary>
	/// Descripción breve de Estados.
	/// </summary>
	public class Estados
	{
		public Estados()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static bool EnEstado(string EstadoImpFis, byte Estado)
		{			
			string Binario = String.Empty;
			string BinarioInv = String.Empty;

			if (EstadoImpFis == null) {return false;}

			EstadoImpFis = EstadoImpFis.ToUpper();

			for (int i = 0; i < EstadoImpFis.Length; i ++) 
			{Binario = Binario + Rutinas.HexToBin(EstadoImpFis[i]).ToString();}
			for (int i = 0; i < Binario.Length; i ++) 
			{BinarioInv = Binario[i].ToString() + BinarioInv;}
	
			switch (Estado) 
			{
				case 0: //Caso genérico que va a incluir todos los estados fiscales de la Epson
				{
					return false;
				}
				case 8: //necesita cierre de la jornada fiscal.
					bool necesitaCierre = (BinarioInv[11] == '1' & BinarioInv[6] == '0');
					return necesitaCierre;
				case 9: //impresora desfiscalizada.
					bool desfiscalizado = (BinarioInv[10] == '1' & BinarioInv[9] == '0');
					return desfiscalizado;
				case 10: //comando no valido para el estado fiscal.
					return (BinarioInv[5] == '1');
				case 24: //Campo de datos inválido
					return (BinarioInv[4] == '1');
				case 26: //Verifica si hay un comprobante abierto.
					return (BinarioInv[12] == '1');
				case 27: //Verifica si hay un comprobante no fiscal abierto.
					return (BinarioInv[13] == '1');
				case 47: //Verifica si se necesita realizar transporte de hoja
					bool transporte = (BinarioInv[11] == '1' & BinarioInv[6] == '1');
					return (transporte);

					
					/*
					 return (BinarioInv[12] == '1'); //documento fiscal abierto
					 return (BinarioInv[10] == '1'); //documento fiscal abierto
					 
					
                        1: mensaje:= 'Error de comprobación de memoria de trabajo';
                        2: mensaje:= 'Batería baja';
                        3: mensaje:= 'Comando no reconocido';                                               
                        
                        7: mensaje:= 'Memoria fiscal llena';
                        8: mensaje:= 'Memoria fiscal casi llena';
                        9:
                        if vecAux[10] = '1'
                        then mensaje:= 'Controlador fiscal desfiscalizado'
                        else mensaje:= 'Controlador fiscal OK';
                        10:
                        if vecAux[9] = '1'
                        then mensaje:= 'Impresora fiscal fiscalizada'
                        else mensaje:= 'Impresora fiscal bloqueada por software';
                        12: mensaje:= 'Documento fiscal abierto';
                        13: mensaje:= 'Documentos abierto emitido por rollo de papel';
                        14: mensaje:= ' '; //sin uso
                        15: mensaje:= 'Error fiscal';					 
					 
					 */
				default: return false;
			}						
		}
	}

}

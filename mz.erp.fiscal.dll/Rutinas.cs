using System;
using FiscalPrinterLib;
using mz.erp.systemframework;

namespace ParaisoFiscal
{
	/// <summary>
	///	Descripción breve de Rutinas.
	/// </summary>
	public class Rutinas
	{		
		public Rutinas()
		{
		}

		public static bool ModeloCorrecto(string NombrePRG, string NombreImpFis, byte CodImpFis)
		{									
			//string Nombre1 = NombrePRG;
			//string Nombre2 = NombreImpFis.PadRight(50,' ').Substring(0, NombrePRG.Length);						
			int long1 = NombrePRG.Length;
			int long2 = NombreImpFis.Length;

			int longitud = (long1 <= long2 ? long1: long2);
			string Nombre1 = NombrePRG.Substring(0, longitud);
			string Nombre2 = NombreImpFis.Substring(0, longitud);

			return (Nombre1 == Nombre2);
			//NombrePRG: es el nombre que le asignó la rutina fiscal (En Delphi era uTablas)
			//NombreImpFis es el nombre que se obtuvo directamente de la información de la impresora
		}

		public static string ArregloCadena(byte Grupo, string texto)
		{						
			/*texto = texto.Replace("\n", " ");
			texto = texto.Replace("\r", " ");
			texto = texto.Replace("\t", " ");			*/

			string textoNU = String.Empty;
			string caracter;

			switch (Grupo)
			{									
				case 1:				
					for (int i = 0; i < texto.Length; i ++) 
					{
						switch (texto[i]) 
						{
							case '½': caracter = "1/2"; break;
							case '¼': caracter = "1/4"; break;
							case 'á':
							case 'à':
							case 'ä': caracter = "a"; break;
							case 'é':
							case 'è':
							case 'ë': caracter = "e"; break;
							case 'í':
							case 'ì':
							case 'ï': caracter = "i"; break;
							case 'ó':
							case 'ò':
							case 'ö': caracter = "o"; break;
							case 'ú':
							case 'ù':
							case 'ü': caracter = "u"; break;
							case 'Á':
							case 'À':
							case 'Ä': caracter = "A"; break;	
							case 'É':
							case 'È':
							case 'Ë': caracter = "E"; break;
							case 'Í':
							case 'Ì':
							case 'Ï': caracter = "I"; break;
							case 'Ó':
							case 'Ò':
							case 'Ö': caracter = "O"; break;
							case 'Ú':
							case 'Ù':
							case 'Ü': caracter = "U"; break;	
							case 'ñ': caracter = "n"; break;		
							case 'Ñ':
							case '¥': caracter = "N"; break;	
							case '`':
							case '´': caracter = "'"; break;	
							case '§':
							case '²':
							case 'ª': caracter = "º"; break;								
							default:
								if ( texto[i] >= '!' & texto[i] <= '_' ||									
									texto[i] >= 'a' & texto[i] <= '~' ||
									texto[i] >= ' ' ||
									texto[i] >= 'º')

									caracter = texto[i].ToString();
								else 
								{
									caracter = "*";
								}	
								break;	
						}
						if (Util.Asc(caracter) < 32)
							caracter = "";
						textoNU = textoNU + caracter;
					}
					break;
				case 2:				
					for (int i = 0; i < texto.Length; i ++) 
					{
						switch (texto[i]) 
						{
							case '½': caracter = "1/2"; break;
							case '¼': caracter = "1/4"; break;
							case 'á':
							case 'à':
							case 'ä': caracter = "a"; break;
							case 'é':
							case 'è':
							case 'ë': caracter = "e"; break;
							case 'í':
							case 'ì':
							case 'ï': caracter = "i"; break;
							case 'ó':
							case 'ò':
							case 'ö': caracter = "o"; break;
							case 'ú':
							case 'ù':
							case 'ü': caracter = "u"; break;
							case 'Á':
							case 'À':
							case 'Ä': caracter = "A"; break;	
							case 'É':
							case 'È':
							case 'Ë': caracter = "E"; break;
							case 'Í':
							case 'Ì':
							case 'Ï': caracter = "I"; break;
							case 'Ó':
							case 'Ò':
							case 'Ö': caracter = "O"; break;
							case 'Ú':
							case 'Ù':
							case 'Ü': caracter = "U"; break;	
							case 'ñ': caracter = "n"; break;		
							case 'Ñ': caracter = "N"; break;	
							case '`':
							case '´': caracter = "'"; break;	
							case '§':
							case '²':
							case 'ª': caracter = "º"; break;	
							default:
								if ( texto[i] >= ' ' & texto[i] <= '~' )
								{
									caracter = texto[i].ToString();
								}				
								else 
								{
									caracter = "*";
								}	
								break;	
						}
						if (Util.Asc(caracter) < 32)
							caracter = "";
						textoNU = textoNU + caracter;
					}
					break;

				default: return texto;
			}					
			return textoNU;			
		}

		public static string ArregloCadenaArt(byte Grupo, string texto) 
		{
			/*texto = texto.Replace("\n", " ");
			texto = texto.Replace("\r", " ");
			texto = texto.Replace("\t", " ");*/
			string textoNU = String.Empty;
			string caracter;			

			switch (Grupo)
			{									
				case 1:				
					for (int i = 0; i < texto.Length; i ++) 
					{
						switch (texto[i]) 
						{
							case '¥': caracter = "Ñ"; break;	
							case '§': caracter = "º"; break;
							default:							
								caracter = texto[i].ToString();
								break;	
						}
						if (Util.Asc(caracter) < 32)
							caracter = "";
						textoNU = textoNU + caracter;
					}
					break;
			}
			return textoNU;
		}	

		public static void SepTexto(string TextoFiscal, byte renglones, byte longitud, ref string[] VectorRenglon)
		{			
			string texto = TextoFiscal;
			VectorRenglon = new string[200];
			string[] VectorPalabras = new string[200];			

			VectorPalabras = texto.Split(' ');

			string substr = String.Empty;
			byte renglon = 0;
			for (int i = 0; i < VectorPalabras.Length; i ++) 
			{				
				if ((substr.Length + 1 + VectorPalabras[i].Length) <= longitud - 1) 
				{
					if (substr == String.Empty) 
					{ substr = VectorPalabras[i];}
					else 
					{ substr = substr + ' ' + VectorPalabras[i];}
				}
				else
				{ 
					VectorRenglon[renglon] = substr;
					renglon++;
					substr = VectorPalabras[i];
				}									
			}
			if (substr != String.Empty) {VectorRenglon[renglon] = substr;}
		}	

		public static string HexToBin(char Hexadecimal) 
		{
			switch (Hexadecimal) 
			{
				case '0': return "0000";
				case '1': return "0001";
				case '2': return "0010";
				case '3': return "0011";
				case '4': return "0100";
				case '5': return "0101";
				case '6': return "0110";
				case '7': return "0111";
				case '8': return "1000";
				case '9': return "1001";
				case 'A': return "1010";
				case 'B': return "1011";
				case 'C': return "1100";
				case 'D': return "1101";
				case 'E': return "1110";
				case 'F': return "1111";
				default: return "0000";					
			}
		}

		public static void IVAIncluir(decimal[,] matIVA, decimal iva, decimal monto) 
		{
			
			int indice = 0;
			while ((matIVA[indice,0] != iva) & (matIVA[indice,0] != -1) & (indice < 5)) 
			{
				indice++;
			}
			if (indice < 5) 
			{
				if (matIVA[indice,0] == iva) 
				{matIVA[indice,1] = matIVA[indice,1] + monto;}
				else 
				{
					matIVA[indice,0] = iva;
					matIVA[indice,1] = monto;
				}

			}			
		}														   

		public static void IVALimpiarMat(decimal[,] MatIVA) 
		{
			MatIVA[0,0]= -1;
			MatIVA[0,1]= 0;
			MatIVA[1,0]= -1;
			MatIVA[1,1]= 0;
			MatIVA[2,0]= -1;
			MatIVA[2,1]= 0;
			MatIVA[3,0]= -1;
			MatIVA[3,1]= 0;
			MatIVA[4,0]= -1;
			MatIVA[4,1]= 0;			
		}
		public static decimal IVACalcDifGral(decimal[,] MatIVA, decimal MontoValor)
		{				
			decimal SumaTotal = 0;
			decimal NetoSuma = 0;
			decimal NetoParcial = 0;

			int indice = 0;
			while (MatIVA[indice,0] != -1) 
			{
				SumaTotal = SumaTotal + MatIVA[indice, 1];
				indice++;
			}

			indice = 0;
			while (MatIVA[indice,0] != -1) 
			{
				NetoParcial = MatIVA[indice,1] / SumaTotal * MontoValor / (1 + MatIVA[indice,0] / 100);
				NetoSuma = NetoSuma + NetoParcial;
				indice++;
			}	
			return NetoSuma;
		}
		/*
			Descuento/recargo general. 
			Calculo:  se calculo para cada uno de los ivas la incidencia de su subtotal sobre el total. 
			Sobre el porcentaje calculado se calcula el descuento/recargo gral. y se calcula su neto.. 
			Calcular cada uno de los netos para los distintos ivas y sumarlos.
			Ejemplo.
			Monto de descuento o recargo $11.12
			Subtotal
			245.11 (21%) -->  0.74 del total. Aplicado a 11.12 = 8.22 el neto de este es: 6.79
			86.02 (10.5%)-->  0.26 aplicado a 11.12 = 2.89 el neto de este es 2.61
			Total 331.13 (245.11+86.02)
			La suma es 9.40*/
		
	}
}

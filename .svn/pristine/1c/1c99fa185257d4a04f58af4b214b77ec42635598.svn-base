using System;
using System.Collections;
using System.Data;
using System.Text;
using System.IO;

namespace mz.erp.businessrules
{

	/// <summary>
	/// Descripción breve de BuildStreamReport.
	/// Se ocupa de crear los stream para luego ser impresos(teniendo o no un XML
	/// que defina la distribucion del texto). La información puede ingresar desde algun reportMatrixFactory
	/// </summary>
	public class BuildStreamReport
	{
	
		public Hashtable campos; 

		public BuildStreamReport()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
			campos = new Hashtable();
		}

		
		#region Metodos de Ancho y alto de hoja (dividirRenglon, truncar, superaAlto, etc...
		
			/// <summary> //ST 14/09/2005
			/// Descompone el renglon recibido como parametro en strings del ancho determinado por la diferencia entre los 
			/// dos ultimos parámetros (el método verifica que no se pase del ancho determinado por la var de config)
			/// Graficamente : arma una columna
			/// </summary>
			/// <param name="renglon">string a descomponer</param>
			/// <param name="posInicio">indica la posicion inicio desde la cual se empiezan a armar los renglones</param>
			/// <param name="posFin">indica la posicion final hasta se llenan los renglones</param>
			/// <returns>retorna un arrayList con los "renglones" en los que se descompuso el str</returns>		 
			public ArrayList DividirRenglon (string renglon, int posInicio, int posFin)
			{  
				ArrayList arreglo = new ArrayList();
				//int anchoHoja = Variables.GetValueString("System.Impresion.MatrizDePunto.AnchoContenido");
				int anchoHoja = 80;
				if ((posFin <= anchoHoja) && ((posFin - posInicio) < anchoHoja))
				{
					if (posInicio + renglon.Length > anchoHoja)
					{
						for (int i=0 ; i<= renglon.Length; i=i + (anchoHoja - posInicio))
						{
							arreglo.Add(renglon.Substring(i, anchoHoja - posInicio));
						}	
					}
					else 
					{	
						arreglo.Add(renglon);
					}
				}
				else 
				{
					//error porque se pasa del ancho determinado por la variable de configuracion
				}
				return arreglo;
			}


			/// <summary> //ST 13/09/2005
			/// Descompone el str recibido como parametro en strings de la cantidad de caracteres indicada por la variable 
			/// de config
			/// </summary>
			/// <param name="renglon">string a descomponer</param>
			/// <returns>retorna un arrayList con los "renglones" en los que se descompuso el str</returns>
			public ArrayList DividirRenglon (string renglon)
			{   //ojo ver el nombre real que se le pondra a la variable
				//int anchoHoja = (int) Variables.GetValueString("System.Impresion.MatrizDePunto.AnchoContenido");
				int anchoHoja = 80;
				ArrayList arreglo = new ArrayList();
				if (renglon.Length > anchoHoja)
				{
					for( int i=0 ; i <= renglon.Length; i= i + anchoHoja)
					{	
						arreglo.Add(renglon.Substring(i,anchoHoja)); 						
					}
				}
				else 
				{
					arreglo.Add(renglon);
				}
				return arreglo; 
			}


			/// <summary> //ST 13/09/2005
			/// Modifica el string pasado com parametro para que tenga el ancho indicado por la variable de configuracion
			/// </summary>
			/// <param name="renglon">es el string a modificar</param>
			/// <returns>el estring modificado</returns>
			public string TruncarRenglon (string renglon)
			{
				//int anchoHoja = (int) Variables.GetValueString("System.Impresion.MatrizDePunto.AnchoContenido");
				int anchoHoja = 80;
				return (renglon.Substring(0,anchoHoja));
			}


			/// <summary> //ST 13/09/2005
			/// Indica si la cantidad de renglones actuales supera o no el alto de la hoja configurado en la variable
			/// </summary>
			/// <param name="renglones">son todos los renglones que componen actualmente la hoja</param>
			/// <returns>retorna true si la cantidad de renglones supera el alto configurado para la hoja
			///			 retorna false en caso contrario.
			///	</returns>
			public bool SuperaAlto (ArrayList renglones)
			{   //ojo ver el nombre real que se le pondra a la variable
				//int altoHoja = (int) Variables.GetValueString("System.Impresion.MatrizDePunto.AltoContenido");
				int altoHoja = 66;
				return (renglones.Count > altoHoja);
				//seguidamente se deberia llamar a un metodo que corte la hoja.
			}
						

		#endregion

		#region Metodos para composicion de cabecera

		/// <summary>
		/// Define un campo o etiqueta con una posicion inicial y una final
		/// </summary>
		/// <param name="nombreCampo">nombre del campo o de la etiqueta</param>
		/// <param name="columnaIni">columna a partir de la cual se escribirá el string</param>
		/// <param name="renglonIni">renglon a partir del cual se escribirá el string </param>
		public void DefinirCampo (string NombreCampo, int ColumnaIni, int RenglonIni)
		{	
			System.Collections.ArrayList arreglo = new System.Collections.ArrayList(3);
			arreglo[1] = ColumnaIni;
			arreglo[2] = RenglonIni;
			arreglo[3] = null;
			campos.Add(NombreCampo, arreglo);
		}		

		/// <summary>
		/// Define un campo (o etiqueta) desde la posicion mas a  la izquierda y 
		/// a partir de el ultimo renglon insertado en la tabla hash.
		/// </summary>
		/// <param name="nombreCampo">es el nombre que describirá la etiqueta</param>
		public void DefinirCampo (string NombreCampo)
		{	
			System.Collections.ArrayList arreglo = new System.Collections.ArrayList(3);
			arreglo[1] = 0;
			arreglo[2] = UltimoRenglon() +1 ;//renglon siguiente al ultimo ocupado
			arreglo[3] = null;
			campos.Add(NombreCampo, arreglo);
		}		
		
		/// <summary>
		/// Define un campo (o etiqueta) desde la columna pasada como parametro
		/// en el ultimo renglon insertado en la tabla hash.
		/// ES DECIR PONE UNA COLUMNA AL LADO DE LA OTRA.
		/// </summary>
		/// <param name="NombreCampo">es el nombre que describirá la etiqueta</param>
		public void DefinirCampo (string NombreCampo, int ColumnaIni)
		{	
			System.Collections.ArrayList arreglo = new System.Collections.ArrayList(3);
			arreglo[1] = ColumnaIni;
			arreglo[2] = UltimoRenglon();
			arreglo[3] = null;
			campos.Add(NombreCampo, arreglo);
		}

		/// <summary>
		/// Recorre la tabla hash y retorna el nº del ultimo renglon "escrito"
		/// </summary>
		public int UltimoRenglon()
		{   
			int max = 0; 
			System.Collections.ICollection claves = campos.Keys;

			foreach(string clave in claves)
			{
				//string str = ;
				ArrayList aux = (ArrayList)campos[clave];
				if (( (int)aux[2]) > max) //campos[str] es un ArrayList
				{
					max = (int)aux[2];
				}
			}	
			return max;
		}
		

		/// <summary>
		/// Agrega un valor a un campo o etiqueta determinada
		/// </summary>
		/// <param name="NombreCampo">el campo que se buscara en la hash</param>
		/// <param name="ValorCampo">el valor que va a tomar ese campo en la hash</param>
		public void AddValorACampo (string NombreCampo, string ValorCampo)
		{
			/*System.Collections.ArrayList arreglo = campos[nombreCampo];
			arreglo[3] = valorCampo;
			campos[nombreCampo] = arreglo;*/
		}

		#endregion


		#region Metodos para composicion de items
			
		
		//por default deja 15 lineas para cabecera
		//arma una columna al lado de la otra
//0-10
//11-21
//12-22 ....  es solamente para probar
		public void DefinirRenglonDetalle ()
		{
			 
		}
		
		#endregion

	}




}

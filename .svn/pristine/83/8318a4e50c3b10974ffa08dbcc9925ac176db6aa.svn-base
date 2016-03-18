using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.IO;
using Janus.Windows.GridEX;

using Janus.Windows.Common;


namespace mz.erp.systemframework
{
	public class Util
	{						
		public Util()
		{
		}

        //German 20110106 - Tarea 0000148
        public static string FormatString(decimal monto, string separador)
        {
            decimal parteEntera = Math.Truncate(monto);
            decimal parteFraccionaria = monto - parteEntera;
            return Convert.ToString(parteEntera) + separador + Convert.ToString(parteFraccionaria).Substring(2);
        }
        //Fin German 20110106 - Tarea 0000148

		//German 20090407

		public static bool ContainsColumn(GridEX grid, string ColumnName)
		{
			foreach(GridEXColumn col in grid.RootTable.Columns)
			{
				if(col.Key.ToUpper().Equals(ColumnName.ToUpper()))
					return true;
			}
			return false;
		}

		//Fin German 20090407


		private static DateTime _hora = DateTime.Now;
		public static void InitTimer()
		{
			_hora = DateTime.Now;
		}

		public static string GetSeconds()
		{
			TimeSpan a =  DateTime.Now.Subtract(_hora);
			return Convert.ToString(a.Seconds);
		}

		public static string GetMilliseconds()
		{
			TimeSpan a =  DateTime.Now.Subtract(_hora);
			return Convert.ToString(a.Milliseconds);
		}
        /* Silvina 20110302 - Tarea 0000081 */
        public static string GetTotalMilliseconds()
        {
            TimeSpan a = DateTime.Now.Subtract(_hora);
            return Convert.ToString(a.TotalMilliseconds);
        }
        /* Fin Silvina */
		public static string RemoveZerosLeft(string cadena)
		{
			string result = string.Empty;
			bool ok = false;
			for(int i = 0 ; i < cadena.Length ; i++ )
			{

				if (!(cadena[i].Equals('0')) || ok)
				{
					ok = true;
					result = result + cadena[i];
				}
			}
			return result;
		}

		
		private static string _lastStringUid= null;

        //German 20110318 - Tarea 0000091
        private static long _lastLongUid = long.MinValue;
        //Fin German 20110318 - Tarea 0000091




		/// <summary>
		/// elimina los blancos de un string determinado
		/// </summary>
		public static string RemoveSpaces(string str)
		{
			string aux = str.Replace(" ", string.Empty);
			/*
			string aux = string.Empty;
			for(int i = 0 ; i < str.Length ; i++ )
			{
				if (!(str[i].Equals(" ")))
					aux = aux + str[i];
			}
			*/
			return aux;
		}

		public static string ToString(object valor ,SqlDbType sqlType)
		{
			try
			{
				switch(sqlType)
				{	
					case SqlDbType.VarChar:
					{
						return "'" + FormatString( valor.ToString()) + "'";
						break;
					}
					case SqlDbType.DateTime:
					{
					
					
					
						DateTime vaux = (DateTime)valor;
						string aux = FormatDateTime(valor);						
					
						return "'"+ aux + "'" ;
						break;
					}
					case SqlDbType.Timestamp:
					{
						//return Convert.ToBase64String((byte[])valor);

						return "NULL";									
						break;
					}
					case SqlDbType.UniqueIdentifier:
					{
						return "'" + valor.ToString() + "'";
						break;
					}
					case SqlDbType.Char:
					{
						return "'" + valor.ToString() + "'";
						break;
					}
					case SqlDbType.NChar:
					{
						return "'" + FormatString( valor.ToString()) + "'";
						break;
					}
					case SqlDbType.NVarChar:
					{
						return "'" + FormatString( valor.ToString()) + "'";
						break;
					}
					case SqlDbType.SmallDateTime:
					{
						return "'" + valor.ToString() + "'";
						break;
					}
					case SqlDbType.VarBinary:
					{
						return "'" + valor.ToString() + "'";
						break;
					}
					case SqlDbType.Bit:
					{
						if(valor.GetType() == typeof(System.Int32))
							return valor.ToString();
						else
						{
							System.Boolean val = (System.Boolean)valor;
							string aux =null;
							if(val) aux ="1";
							else aux = "0";
							return aux.ToString();
						}
					
						break;
					}

					case SqlDbType.Decimal :
					{
						return FormatDecimal(Convert.ToDecimal(valor));
						break;
					}
					default: 
					{
						return valor.ToString();
					}
				}
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("Valor :" + valor.ToString());
				Console.WriteLine("Tipo sql " + sqlType.ToString());
			}

			return null;
			

			
		}


		private static string FormatDecimal(decimal valor)
		{
			string valorAux = valor.ToString();
			string val = valorAux.Replace(",",".");
			int index = val.LastIndexOf(".");
			//valorAux[index] = ',';
			if(index >= 0)
			{
				val.Insert(index, ",");
				val.Remove(index + 1,1);
			}
			return val;

		}


		private static string FormatString(string valor)
		{
			string val = valor.Replace(";",",");
			string valAux = val.Replace("'"," ");
			return valAux;
		}

		private static string FormatDateTime(object valor)
		{
			DateTime valorDateTime = (DateTime) valor;
			int day = valorDateTime.Day;
			string days = null;
			string months = null;
			if(day < 10) days = "0" + day.ToString();
			else days = day.ToString();
			
			int month = valorDateTime.Month;
			if(month < 10 ) months = "0" + month.ToString();
			else  months = month.ToString();
			int year = valorDateTime.Year;
			int hour = valorDateTime.Hour;
			int minute = valorDateTime.Minute;
			int second = valorDateTime.Second;
			return year.ToString()+ months+  days+ " " + hour.ToString() +":"+ minute.ToString()+ ":" + second.ToString();				
		}


        //German 20110318 - Tarea 0000091
        public static long NewLongId()
        {

            if (_lastLongUid == long.MinValue)
                _lastLongUid = (long)new Random().Next();
            else
            {
                long val = Convert.ToInt64(_lastLongUid);
                val++;
                _lastLongUid = val;
            }
            return _lastLongUid;
        }
        //Fin German 20110318 - Tarea 0000091


    	public static string NewStringId()
		{
			
			if(_lastStringUid == null)
				_lastStringUid = ( string )new Random().Next().ToString();
			else 
			{
				long val = Convert.ToInt64(_lastStringUid);
				val++;
				_lastStringUid = val.ToString();
			}
			return _lastStringUid;
		}

		public static string Replicate(char caracter, int longitud) 
		{
			string cadena = "";
			for (int i = 0;i < longitud; i++) 
			{
				cadena = cadena + caracter.ToString();
			}
			return cadena;
		}

		public static string SubstringReplicate(string cadena, int startIndex, int length) 
		{
			//Esta rutina tiene la intención de mejorar el funcionamiento de String.Substring
			//ya que esta no funciona si la cadena es más corta que la longitud a recortar.
			cadena = cadena + Replicate(' ',length);
			return cadena.Substring(startIndex, length);
		}

		public static string ArregloCadena(string texto)
		{
			string textoNU = String.Empty;
			string caracter;
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
				textoNU = textoNU + caracter;
			}
			return textoNU;			
		}


		public static string ResourcePath()
		{				
			return Application.StartupPath;
		}

		public static ArrayList UpperCaseStringArrayCollection( ArrayList unArrayDeString)
		{
			for (int i=0;i<unArrayDeString.Count;i++)
			{
				unArrayDeString[i]=((string)unArrayDeString[i]).ToUpper();
			}
			return unArrayDeString;
		}

		public static object MinValue( Type myType )
		{
			if (myType == System.Type.GetType("System.Boolean")) return false;
			if (myType == System.Type.GetType("System.Byte")) return (Byte)0;
			if (myType == System.Type.GetType("System.Char")) return Char.Parse(" ");
			if (myType == System.Type.GetType("System.DateTime")) return DateTime.MinValue;
			if (myType == System.Type.GetType("System.Decimal")) return Decimal.MinValue;
			if (myType == System.Type.GetType("System.Double")) return Double.MinValue;
			if (myType == System.Type.GetType("System.Int16")) return Int16.MinValue;
			if (myType == System.Type.GetType("System.Int32")) return Int32.MinValue;
			if (myType == System.Type.GetType("System.Int64")) return Int64.MinValue;
			if (myType == System.Type.GetType("System.SByte")) return SByte.MinValue;
			if (myType == System.Type.GetType("System.Single")) return Single.MinValue;
			if (myType == System.Type.GetType("System.String")) return String.Empty;
			if (myType == System.Type.GetType("System.TimeSpan")) return TimeSpan.MinValue;
			if (myType == System.Type.GetType("System.UInt16")) return UInt16.MinValue;
			if (myType == System.Type.GetType("System.UInt32")) return UInt32.MinValue;
			if (myType == System.Type.GetType("System.UInt64")) return UInt64.MinValue;
			
			return null;
		}

		public static System.Data.SqlDbType GetSqlBbType(string sqlDbTypeString)
		{
			return (System.Data.SqlDbType)Enum.Parse(typeof (System.Data.SqlDbType),sqlDbTypeString);
		}

		public static object DefaultValue()
		{
			return null;
		}


		public static object DefaultValue( Type myType )
		{
			if (myType == System.Type.GetType("System.Boolean")) return false;
			if (myType == System.Type.GetType("System.Byte")) return (Byte)0;
			if (myType == System.Type.GetType("System.Char")) return Char.Parse(" ");
			if (myType == System.Type.GetType("System.DateTime")) return System.DBNull.Value;//DateTime.MinValue;
			if (myType == System.Type.GetType("System.Decimal")) return (Decimal)0;
			if (myType == System.Type.GetType("System.Double")) return (Double)0;
			if (myType == System.Type.GetType("System.Int16")) return (Int16)0;
			if (myType == System.Type.GetType("System.Int32")) return (Int32)0;
			if (myType == System.Type.GetType("System.Int64")) return (Int64)0;
			if (myType == System.Type.GetType("System.SByte")) return (SByte)0;
			if (myType == System.Type.GetType("System.Single")) return (Single)0;
			if (myType == System.Type.GetType("System.String")) return String.Empty;
			if (myType == System.Type.GetType("System.TimeSpan")) return TimeSpan.MinValue;
			if (myType == System.Type.GetType("System.UInt16")) return (UInt16)0;
			if (myType == System.Type.GetType("System.UInt32")) return (UInt32)0;
			if (myType == System.Type.GetType("System.UInt64")) return (UInt64)0;			
			if (myType == System.Type.GetType("System.UInt64")) return (UInt64)0;				
			if (myType == System.Type.GetType("System.Byte[]")) return new byte[0];
			return null;			
		}

		//Funcion que chequea que un string sea valido para un conjunto de caracteres
		public static bool IsValidString(string word, string charsValids)
		{
					
			//string charsValids="abcdefghijklmnñopqrestuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZáéíóúÁÉÍÓÚ._ ";
			int i=1;
			bool ok= true;
			while (i <= word.Length && ok)
			{
				char caracter=word[i-1];
				if (charsValids.IndexOf(caracter)  < 0) ok = false;
				else i++;
			}
			
			
			return ok;
		}

		public static bool IsValidNumeroDomicilio(string numero)
		{
			string charsValids="0123456789/snSN";
			return IsValidString(numero, charsValids);
		}
		public static bool IsValidEmail(string email)
		{
			string charsValidsUser="abcdefghijklmnñopqrstuvwxyz0123456789_";
			string charsValidsDomain="abcdefghijklmnñopqrstuvwxyz";
			if (email.Length == 0)
				return false;
			//chequea que el mail tenga por lo menos 6 caracteres que es el minimo permitido
			//que el simbolo arroba apareza solo una vez y que no aparezca ni al principio ni al
			//final
			if ((email.Length >= 6) && (Util.ocurrencesOf(email,'@') == 1) && (email.IndexOf('@')!=0) && (email.IndexOf('@')!=email.Length))
				if ((email.IndexOf('.') > 0) && (email[email.Length-1] != '.')) //no termina en punto
					if((email.IndexOf("'")<0) && (email.IndexOf(' ') < 0) && (email.IndexOf('$')<0) && (email.IndexOf(' ')<0)) //no hay caracteres invalidos
					{
						string nombreUsuario=email.Substring(0,email.IndexOf('@'));
						string dominio=email.Substring(email.IndexOf('@')+1,email.Length-nombreUsuario.Length-1);
						//chequeo que la cuanta tenga un nombre de usuario valido
						if (Util.IsValidString(nombreUsuario,charsValidsUser))
						{
							if(ocurrencesOf(dominio,'.')==1) //@dominio.tipoDom
							{
								string dom=dominio.Substring(0,dominio.IndexOf('.'));
								if(!Util.IsValidString(dom,charsValidsDomain)) return false;
								string tipoDom=dominio.Substring(dominio.IndexOf('.')+1,dominio.Length - dom.Length -1);
								if(!Util.IsValidString(tipoDom,charsValidsDomain)) return false;
								return true;
							}
							else
								if(ocurrencesOf(dominio,'.')==2) //@dominio.TipoDom.PaisDom
							{
								string dom=dominio.Substring(0,dominio.IndexOf('.'));
								if(!Util.IsValidString(dom,charsValidsDomain)) return false;
								string rest=dominio.Substring(dominio.IndexOf('.')+1,dominio.Length- dom.Length -1);
								string tipoDom=rest.Substring(0,rest.IndexOf('.'));
								if(!Util.IsValidString(tipoDom,charsValidsDomain)) return false;
								string paisDom=rest.Substring(rest.IndexOf('.')+1,rest.Length- tipoDom.Length -1);
								if(!Util.IsValidString(paisDom,charsValidsDomain)) return false;
								return true;
							
							}
						}
					}	

			return false;
		}
		public static string StrZero(object number, int longitud)
		{
			string aux = Convert.ToString( number ).Trim();
			string ceros = "";
			for(int i=1;i<=(longitud-aux.Length);i++)
			{
				ceros = ceros+ "0";
			}
			return ceros+aux;
		}

		public static string StcZero(string number, int longitud)
		{
			string aux = number.Substring(number.Length - longitud);
			
			int valor  = Convert.ToInt32(aux,10);
			valor ++;
			aux="";
			
			aux = Convert.ToString(valor);
			string aux1 = number.Substring(0,number.Length - longitud );
			string cadena = aux; 
			for (int i=0; i< longitud-aux.Length; i++)
			{
				cadena = '0' + cadena;
			}
			return aux1+cadena;		
		}

		/// <summary>
		/// Recorta el numero indicado a la cantidad de digitos menos significativos
		/// </summary>
		/*public static long MenosSignificativos(long number, int digitos) 
		{						
			string str = Convert.ToString(	number );
			if (str.Length <= digitos)
				return number;
			else 
			{
				string str2 = str.Substring(str.Length - digitos, digitos);
				long newnumber = Convert.ToInt64(str2);	
				return newnumber;
			}			
		}
		public static long MasSignificativos(long number, int digitos) 
		{						
			string str = Convert.ToString(	number );
			if (str.Length <= digitos)
				return number;
			else 
			{
				string str2 = str.Substring(str.Length - digitos, digitos);
				long newnumber = number - Convert.ToInt64(str2);				
				return newnumber;
			}			
		}*/

		public static long MaximoValor(int digitos) 
		{
			string cadena = "";
			for (int i=0; i< digitos; i++)
			{
				cadena = cadena + "9";
			}
			return Convert.ToInt64(cadena);
		}

		/// <summary>
		/// Genera un string a partir de una coleccion con un separador especificado
		/// </summary>
		public static string PackString(ArrayList arr, string separator)
		{
			string aux = string.Empty ;
			foreach(object o in arr)
			{
				aux = aux + Convert.ToString(o);
				aux = aux + separator;
			}
			if(aux != string.Empty)
				return aux.Remove(aux.Length - 1,1);
			else return string.Empty;
		}

		/// <summary>
		/// Genera un string a partir de una coleccion con coma como separador por defecto
		/// </summary>
		/// <param name="arr">Parametro arr</param>
		/// <returns>devuelve</returns>

		public static string PackString(ArrayList arr)
		{
			string aux = string.Empty ;
			string separator = ",";
			foreach(object o in arr)
			{
				aux = aux + Convert.ToString(o);
				aux = aux + separator;
			}
			if(aux != string.Empty)
				return aux.Remove(aux.Length - 1,1);
			else return string.Empty;
		}

		public static ArrayList Parse(string cadena, string separador)
		{
				string [] partes = cadena.Split(separador.ToCharArray());
				return new ArrayList(partes);
		}
		public static ArrayList Parse(string cadena)
		{
			string separador = ",";
			string [] partes = cadena.Split(separador.ToCharArray());
			return new ArrayList(partes);
		}
		/// <summary>
		/// Genera un arraylist dividiendo la cadena según la longitud definida
		/// </summary>
		public static ArrayList Parse(string cadena, int longitud)
		{			
			ArrayList array = new ArrayList();		
			while (cadena.Length > 0)
			{				
				if (longitud < cadena.Length)
				{
					array.Add(cadena.Substring(0,longitud));
					cadena = cadena.Remove(0, longitud);
				}
				else 
				{
					array.Add(cadena);
					cadena = "";
				}
			}
			return array;			
		}
		

		public static DateTime AddTime(DateTime date, DateTime fechaActual)
		{
			return new DateTime(date.Year, date.Month, date.Day, fechaActual.Hour, fechaActual.Minute, fechaActual.Second);
		}

		public static DateTime GetEndPriorDay(DateTime date)
		{
			DateTime date1 =  date.AddDays(-1);
			return new DateTime(date1.Year,date1.Month,date1.Day,23,59,59);

		}

		public static DateTime GetStartDay(DateTime date)
		{
			return new DateTime(date.Year,date.Month, date.Day,0,0,0);
		}

		public static DateTime GetEndDay(DateTime date)
		{
			return new DateTime(date.Year,date.Month,date.Day,23,59,59);
		}

		public static DateTime GetNextStartDay(DateTime date)
		{
			DateTime date1 = date.AddDays(1);
			return new DateTime(date1.Year,date1.Month,date1.Day,0,0,0);
		}

		public static bool CompareDates( DateTime firstDate, DateTime secondDate)
		{
			if ((firstDate.Day == secondDate.Day) && (firstDate.Month == secondDate.Month) && (firstDate.Year == secondDate.Year))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static string GetHour( DateTime fecha )
		{
			return StrZero( fecha.Hour , 2 )+":"+StrZero( fecha.Minute ,2);
		}

	

		private static int ocurrencesOf(string str, char c)
		{
			int cant=0;
			foreach (char ch in str)
			{
				if(ch==c) cant ++;
			}
			return cant;

		}
		public static string ConvertToString( ArrayList array )
		{
			string cadena = string.Empty;
			foreach( string item in array)
			{
				cadena= cadena+item+',';
			}
			return cadena;
		}

		/// <summary>
		/// Devuelve la cadena con un espacio adicional si ésta no es vacía y en caso contrario devuelve vacío.
		/// </summary>
		public static string CutSpace(string cadena)
		{
			return (cadena.Trim() == "" ? "": cadena.Trim() + " ");			
		}		

		//En VB clásico había dos funciones muy prácticas para muchos cometidos que permitían obtener el 
		//código ASCII de un caracter y viceversa, a partir de un código ASCII sacar el caracter que le 
		//correspondía. estas funciones se llamaban Asc y Chr respectivamente.
		//En C# no existen como tales, pero son muy fáciles de simular igualmente, así:
		///Hace falta poner using System.Text al principio para esta
		public static int Asc(string s)
		{
			return Encoding.ASCII.GetBytes(s)[0];
		}

		public static char Chr(int c)
		{
			return Convert.ToChar(c);
		}

		public static byte[] ImageToBytes(Image img)
		{
			string sTemp = Path.GetTempFileName();
			FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
			img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
			fs.Position = 0;
			//
			int imgLength = Convert.ToInt32(fs.Length);
			byte[] bytes = new byte[imgLength];
			fs.Read(bytes, 0, imgLength);
			fs.Close();
			return bytes;
		}

		public static Image BytesToImage(byte[] bytes)
		{
			if (bytes == null) return null;
			//
			MemoryStream ms = new MemoryStream(bytes);
			Bitmap bm = null;
			try
			{
				bm = new Bitmap(ms);
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.Message);
			}
			return bm;
		}
		
		public static string FillNumberWithZeros(string texto, string separator, int cant1, int cant2)
		{
			if ( ( texto == string.Empty ) || ( texto.Length  <= 3) )
				// texto = '' or texto = 'X--'
				return texto;
			else 
			{
				ArrayList partes = mz.erp.systemframework.Util.Parse(texto, separator);
				string cadena1 = mz.erp.systemframework.Util.StrZero(partes[1],cant1); //4
				string cadena2 = mz.erp.systemframework.Util.StrZero(partes[2],cant2); //8
				return partes[0]+separator+cadena1+separator+cadena2;
			}
		}

		
		public static void ReplaceNullDateWithDBNull(DataRow row, string campo)
		{
			if(row[campo].Equals(System.DBNull.Value))
				row[campo] = DateTime.MinValue;		
		}
		
		public static void ReplaceNullDateWithDBNull(DataTable data, string campo)
		{
			foreach( DataRow row in data.Rows )
			{
				if(row[campo].Equals(System.DBNull.Value))
					row[campo] = DateTime.MinValue;
			}
		} 
		
		public static void ReplaceNullDateWithDBNull(DataTable data, ICollection campos)
		{			
			foreach( string elem in campos )
			{
				ReplaceNullDateWithDBNull(data, elem);
			}
		}
        //Cristian Tarea 0000050 20110310
        /// <summary>
        /// Recalcula la fecha de fin para una consulta
        ///  en base a los dias posteriores
        /// </summary>
        /// <param name="fechaDesde">The fecha desde.</param>
        /// <param name="dias">cantidad de dias posteriores a la fecha desde.</param>
        /// <returns></returns>
        public static DateTime GenerateFechaHasta(DateTime fechaDesde, long dias)
        {
            DateTime fechaFin = new DateTime();
            if (!dias.Equals(long.MinValue))
              {fechaFin = fechaDesde.AddDays(dias);}
            else
              {fechaFin = fechaDesde;}
            return fechaFin;
        }
        //Fin Cristian
	}
	public class Cuit
	{
		public Cuit()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static bool Control(string codigo)
		{			
			//Acepta números de CUIT con o sin guiones.
			string SinGuiones;
			SinGuiones = SacarGuiones(codigo);
			return ControlInt(SinGuiones);
		}

		private static string SacarGuiones(string codigo)
		{
			string resultado=codigo.Replace("-","");
			//Debug.WriteLine(resultado);
			//Debug.WriteLine(Convert.ToInt16('_'));
			return resultado;			
		}

		private static bool ControlInt(string codigo)
		{
			int[,] mat = new int[,] {{5,0}, {4,0}, {3,0}, {2,0}, {7,0}, {6,0}, {5,0}, {4,0}, {3,0}, {2,0}};  
			string str = codigo;	
			//
			if(codigo.Length != 11) return false;
			char[] arrCuit = str.ToCharArray(0, 10);						
			char[] arrVerificador = str.ToCharArray(10,1);
			int Verificador = Convert.ToInt16(arrVerificador.GetValue(0).ToString());	
			
			for (int i=0; i < 10; i++) 			
			{
				mat[i,1] = Convert.ToInt16(arrCuit[i].ToString());				
			}
			
			int suma = 0;
			int resto = 0;
			int dif = 0;			

			for (int j=0; j < 10; j++) 
			{
				suma = suma + mat[j,0] * mat[j,1];
			}
			resto = suma % 11;
			dif = 11 - resto;
			if (dif > 9) 
			{
				dif = 0;
			}		
			return (dif == Verificador);		
		}
			
	}




	}


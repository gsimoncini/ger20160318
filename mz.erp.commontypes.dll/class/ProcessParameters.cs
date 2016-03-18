using System;
using System.Collections;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripción breve de ProcessParameters.
	/// </summary>
	public class ProcessParameters
	{
		public ProcessParameters()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static Hashtable ConvertToHash(string Tarea, string Propiedad, object Valor)
		{
			Hashtable parametros = new Hashtable();
			Hashtable valores = new Hashtable();
			valores.Add(Propiedad,Valor);
			parametros.Add(Tarea, valores);
			return parametros;
		}

		public static void GetInitialParameters(object sender, string Tarea, Hashtable Parametros)
		{			
			Hashtable table = Parametros;
			foreach(object key in table.Keys)
			{
				if (Tarea == Convert.ToString(key))				
				{
					Hashtable subtable = (Hashtable) table[key];			
					foreach(object subkey in subtable.Keys)
					{							
						string propiedad = Convert.ToString(subkey);
						string valor = Convert.ToString(subtable[subkey]);
							
						System.Type tipo = sender.GetType();						
						object objeto = tipo.InvokeMember(propiedad, System.Reflection.BindingFlags.SetProperty, null, sender, new object[]{subtable[subkey]});
					}
				}
			}
		}
	}
}

using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de VariablesListComparer.
	/// </summary>
	public class VariablesListComparer
	{
		public VariablesListComparer()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		

		public static ArrayList FilterArrayList(string ProcessName, string TaskName, string ColaVariable, string PropertyComparer, ArrayList data)
		{
			string aux = ColaVariable + ".MetodoDeComparacion";
			string metodoDeComparacion = Variables.GetValueString(ProcessName, TaskName, aux);
			string listaComparacion = Variables.GetValueString(ProcessName, TaskName, ColaVariable);
			ArrayList listaComparacionArrayList = mz.erp.systemframework.Util.Parse(listaComparacion, ",");
			if(metodoDeComparacion.Equals(string.Empty)) return data;
			return Comparer(PropertyComparer,data, metodoDeComparacion, listaComparacionArrayList);
		}

		public static ArrayList FilterArrayList(string Variable, string PropertyComparer, ArrayList data)
		{
			string aux = Variable + ".MetodoDeComparacion";
			string metodoDeComparacion = Variables.GetValueString(aux);
			string listaComparacion = Variables.GetValueString(Variable);
			ArrayList listaComparacionArrayList = mz.erp.systemframework.Util.Parse(listaComparacion, ",");
			if(metodoDeComparacion.Equals(string.Empty)) return data;
			return Comparer(PropertyComparer,data, metodoDeComparacion, listaComparacionArrayList);
		}
		
		public static DataTable FilterDataTable(string ProcessName, string TaskName, string ColaVariable, string PropertyComparer, DataTable data)
		{
			string aux = ColaVariable + ".MetodoDeComparacion";
			string metodoDeComparacion = Variables.GetValueString(ProcessName, TaskName, aux);
			string listaComparacion = Variables.GetValueString(ProcessName, TaskName, ColaVariable);
			ArrayList listaComparacionArrayList = mz.erp.systemframework.Util.Parse(listaComparacion, ",");
			if(metodoDeComparacion.Equals(string.Empty)) return data;
			return Comparer(PropertyComparer,data, metodoDeComparacion, listaComparacionArrayList);
		}

		public static DataTable FilterDataTable(string Variable, string PropertyComparer, DataTable data)
		{
			string aux = Variable + ".MetodoDeComparacion";
			string metodoDeComparacion = Variables.GetValueString(aux);
			string listaComparacion = Variables.GetValueString(Variable);
			ArrayList listaComparacionArrayList = mz.erp.systemframework.Util.Parse(listaComparacion, ",");
			if(metodoDeComparacion.Equals(string.Empty)) return data;
			return Comparer(PropertyComparer,data, metodoDeComparacion, listaComparacionArrayList);
		}

		public static DataTable FilterDataTable(string ProcessName, string TaskName, string ColaVariable, string PropertyComparer, DataTable data, string IdUsuario)
		{
			string aux = ColaVariable + ".MetodoDeComparacion";
			string metodoDeComparacion = Variables.GetVariablesUsuariosValueString("Momentos."+TaskName+"."+ProcessName+"."+aux,IdUsuario);
			string listaComparacion = Variables.GetVariablesUsuariosValueString("Momentos."+TaskName+"."+ProcessName+"."+ColaVariable,IdUsuario);
			ArrayList listaComparacionArrayList = mz.erp.systemframework.Util.Parse(listaComparacion, ",");
			if(metodoDeComparacion.Equals(string.Empty)) return data;
			return Comparer(PropertyComparer,data, metodoDeComparacion, listaComparacionArrayList);
		}

		private static DataTable Comparer( string PropertyComparer, DataTable data, string MetodoDeComparacion, ArrayList ListaComparacionArrayList)
		{
			DataTable result = new DataTable();
			result = data.Clone();
			if(MetodoDeComparacion.Equals("E"))
			{
				foreach(DataRow row in data.Rows)
				{
					string valueProp = Convert.ToString(row[PropertyComparer]);
					if(!ListaComparacionArrayList.Contains(valueProp))
					{
						result.ImportRow(row);
					}
				}
			}
			else
			{
				if(MetodoDeComparacion.Equals("I"))
				{
					foreach(DataRow row in data.Rows)
					{
						string valueProp = Convert.ToString(row[PropertyComparer]);
						if(ListaComparacionArrayList.Contains(valueProp))
						{
							result.ImportRow(row);
						}
					}
				}
			}
			return result;
		}

		private static ArrayList Comparer( string PropertyComparer, ArrayList data, string MetodoDeComparacion, ArrayList ListaComparacionArrayList)
		{
			ArrayList result = new ArrayList();
			if(MetodoDeComparacion.Equals("E"))
			{
				foreach(object obj in data)
				{
					string valueProp = Convert.ToString(obj.GetType().GetProperty(PropertyComparer).GetValue(obj, null));
					if(!ListaComparacionArrayList.Contains(valueProp))
					{
						result.Add(obj);
					}
				}
			}
			else
			{
				if(MetodoDeComparacion.Equals("I"))
				{
					foreach(object obj in data)
					{
						string valueProp = Convert.ToString(obj.GetType().GetProperty(PropertyComparer).GetValue(obj, null));
						if(ListaComparacionArrayList.Contains(valueProp))
						{
							result.Add(obj);
						}
					}
				}
			}
			return result;
		}
		
	}
}

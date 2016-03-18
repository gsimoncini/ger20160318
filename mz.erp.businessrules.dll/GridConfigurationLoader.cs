using System;
using System.Collections;
using System.Data;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de GridConfigurationLoader.
	/// </summary>
	public class GridConfigurationLoader
	{
		public GridConfigurationLoader()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static Hashtable LoadConfiguration(string GridName, long IdProceso, long IdTarea, string Formulario)
        {
			Hashtable result = new Hashtable();
			DataSet data = mz.erp.businessrules.tui_ConfiguracionGrillasUsuarios.GetList(Security.IdUsuario, IdProceso, IdTarea, GridName, null, null, Formulario);			
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string ColumnName = Convert.ToString(row["Campo"]);
				string Property = Convert.ToString(row["Propiedad"]);
				object Value = row["Valor"];
				if(!result.ContainsKey(ColumnName))
				{
					result.Add(ColumnName, new Hashtable());
				}
				Hashtable Properties = (Hashtable)result[ColumnName];
				Properties.Add(Property, Value);

			}
			data = mz.erp.businessrules.tui_ConfiguracionGrillasPerfiles.GetList(Security.IdPerfil, IdProceso, IdTarea, GridName, null, null, Formulario);
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string ColumnName = Convert.ToString(row["Campo"]);
				string Property = Convert.ToString(row["Propiedad"]);
				object Value = row["Valor"];
				if(!result.ContainsKey(ColumnName))
				{
					result.Add(ColumnName, new Hashtable());
				}
				Hashtable Properties = (Hashtable)result[ColumnName];
				if(!Properties.ContainsKey(Property))
					Properties.Add(Property, Value);

			}
			data = mz.erp.businessrules.tui_ConfiguracionGrillas.GetList(IdProceso, IdTarea, GridName, null, null, Formulario);
			foreach(DataRow row in data.Tables[0].Rows)
			{
				string ColumnName = Convert.ToString(row["Campo"]);
				string Property = Convert.ToString(row["Propiedad"]);
				object Value = row["ValorDefault"];
				if(!result.ContainsKey(ColumnName))
				{
					result.Add(ColumnName, new Hashtable());
				}
				Hashtable Properties = (Hashtable)result[ColumnName];
				if(!Properties.ContainsKey(Property))
					Properties.Add(Property, Value);

			}

            //Matias 20100727 - Tarea 21			
            // Tengo que tener las claves en UPPER; sino Codigo!=codigo, etc...)
            Hashtable resultUPPER = new Hashtable();
            foreach (string columnName in result.Keys)
            {
                if (!resultUPPER.ContainsKey(columnName.ToUpper()))
                    resultUPPER.Add(columnName.ToUpper(), null);
            }
            // Si la grilla tiene una columna con nombre, a bajo nivel, "Codigo"...
            // agrego a la grilla una nueva columna, no visible, con la key "CodigoNumericoInterno".
            if (resultUPPER.ContainsKey("CODIGO"))
            {
                string ColumnName = "CodigoNumericoInterno";
                result.Add(ColumnName, new Hashtable());
                Hashtable Properties = (Hashtable)result[ColumnName];
                Properties.Add("Alineacion", "Izquierda");
                Properties.Add("Ancho", 100);
                Properties.Add("CantidadMaximaLineas", 1);
                Properties.Add("Formato", "Entero");
                Properties.Add("Multilinea", false);
                Properties.Add("Orden", 90);
                Properties.Add("OrdenAgrupamiento", -1);
                Properties.Add("TipoColumna", "CuadroDeTexto");
                Properties.Add("TipoEdicion", "CuadroDeTexto");
                Properties.Add("Titulo", "Codigo Interno (Numerico)");
                Properties.Add("Visible", false);
            }
            //Fin Matias 20100727 - Tarea 21

			return result;
		}		
	}
}

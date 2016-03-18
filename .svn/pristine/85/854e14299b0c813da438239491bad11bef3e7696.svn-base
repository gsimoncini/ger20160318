using System;
using System.Data;
using System.Text.RegularExpressions;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tui_ConfiguracionGrillaEstilosCondicionalesDetEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstilosCondicionalesDetEx
	{
		#region Custom Members

		public static long GetIdCondicion(tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataTable table, long IdConfiguracion, string Columna, string Condicion, string Valor, string ValorColumna)
		{
			long IdCondicion = long.MinValue;
			bool existe = false;
			int i = 0;
			while(!existe && i < table.Rows.Count)
			{
				tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowT = (tui_ConfiguracionGrillaEstilosAplicablesUsuariosExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow)table.Rows[i];
				existe = rowT.IdConfiguracion == IdConfiguracion && rowT.Columna.Equals(Columna) && rowT.Condicion.Equals(Condicion) && ((rowT["ValorColumna"] == System.DBNull.Value && rowT.Valor.Equals(Valor)) ||(rowT["Valor"] == System.DBNull.Value && rowT.ValorColumna.Equals(ValorColumna)));
				if(existe)
					IdCondicion = rowT.IdCondicion;
				i++;
			}
			if(!existe)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row = tui_ConfiguracionGrillaEstilosCondicionalesDet.GetCondicion( IdConfiguracion, Columna, Condicion, Valor, ValorColumna);
				if(row != null)
					IdCondicion = row.IdCondicion;
				else
				{
					tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowU = tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetCondicion( IdConfiguracion, Columna, Condicion, Valor, ValorColumna);
					if(rowU != null)
						IdCondicion = rowU.IdCondicion;
					else
					{
						tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowP = tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetCondicion( IdConfiguracion, Columna, Condicion, Valor, ValorColumna);
						if(rowP != null)
							IdCondicion = rowP.IdCondicion;
					}
				}
			}
			return IdCondicion;

		}
		

		public static long GetIdCondicion(tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataTable table, long IdConfiguracion, string Columna, string Condicion, string Valor, string ValorColumna)
		{
			long IdCondicion = long.MinValue;
			bool existe = false;
			int i = 0;
			while(!existe && i < table.Rows.Count)
			{
				tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowT = (tui_ConfiguracionGrillaEstilosAplicablesPerfilesExDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow)table.Rows[i];
				existe = rowT.IdConfiguracion == IdConfiguracion && rowT.Columna.Equals(Columna) && rowT.Condicion.Equals(Condicion) && ((rowT["ValorColumna"] == System.DBNull.Value && rowT.Valor.Equals(Valor)) ||(rowT["Valor"] == System.DBNull.Value && rowT.ValorColumna.Equals(ValorColumna)));
				if(existe)
					IdCondicion = rowT.IdCondicion;
				i++;
			}
			if(!existe)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesDetDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetRow row = tui_ConfiguracionGrillaEstilosCondicionalesDet.GetCondicion( IdConfiguracion, Columna, Condicion, Valor, ValorColumna);
				if(row != null)
					IdCondicion = row.IdCondicion;
				else
				{
					tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetUsuariosRow rowU = tui_ConfiguracionGrillaEstilosCondicionalesDetUsuarios.GetCondicion( IdConfiguracion, Columna, Condicion, Valor, ValorColumna);
					if(rowU != null)
						IdCondicion = rowU.IdCondicion;
					else
					{
						tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesDetPerfilesRow rowP = tui_ConfiguracionGrillaEstilosCondicionalesDetPerfiles.GetCondicion( IdConfiguracion, Columna, Condicion, Valor, ValorColumna);
						if(rowP != null)
							IdCondicion = rowP.IdCondicion;
					}
				}
			}
			return IdCondicion;

		}
		
		#endregion

		public tui_ConfiguracionGrillaEstilosCondicionalesDetEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	}
}

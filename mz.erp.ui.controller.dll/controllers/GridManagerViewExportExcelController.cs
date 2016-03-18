using System;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de GridManagerViewExportExcelController.
	/// </summary>
	public class GridManagerViewExportExcelController
	{
		public GridManagerViewExportExcelController(string ProcessName, string TaskName)
		{
			_processName = ProcessName;
			_taskName = TaskName;
		}

		private string _processName = string.Empty;
		private string _taskName = string.Empty;

		public string Separator 
		{
			get
			{
				string aux = Variables.GetValueString(_processName, _taskName, "ExportarACSV.CaracterSeparador");
				if(aux == null || aux == string.Empty)
				{
					aux = Variables.GetValueString("Sistema.ExportarACSV.CaracterSeparador");
					return aux;
				}
				return string.Empty;
			
			}
		}


		public bool CanExportToExcel
		{
			get
			{
				return !Variables.GetValueBool("Sistema.ExportarACSV.Habilitado");
			}
		}


	}
}

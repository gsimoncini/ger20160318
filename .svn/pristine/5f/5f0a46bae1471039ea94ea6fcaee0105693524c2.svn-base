using System;
using System.Data;
using mz.erp.ui.controllers;
using System.Collections;

namespace mz.erp.ui.forms.classes
{
	public interface IGridManager
	{
	/*string GetLayout();
	DataTable GetList();*/

		void ConfigureGrid(string ProcessName, string TaskName, GridVariablesLoader loader);
		void SetValue(string ColumnName, object Value, string Condition);
		void InvertValue(string ColumnName);
		ArrayList GetLayoutProperties(string ExcludedColumns);
		void SetLayoutProperties(ArrayList GridLayoutProperties);
		void SaveLayoutProperties(ArrayList GridLayoutProperties,string ProcessName, string TaskName, string ExcludedColumns);
        bool SaveLayoutProperties(ArrayList GridLayoutProperties, string ProcessName, string TaskName, string ExcludedColumns, bool SavePerfil, bool SaveUser, bool ExportSQL, string pathFile); //Matias 20101005 - Tarea 898
        bool ExistsColumn(string ColumnName);

	}
}


using System;
using System.Data;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripción breve de AddColumn.
	/// </summary>
	public class AddColumn
	{
		public AddColumn()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataTable AddColumnToTable(DataTable table, string column, bool value)
		{						
			if( !table.Columns.Contains(column))
			{
				DataColumn col = new DataColumn(column, typeof(bool) );						
				table.Columns.Add(col);
			}

			foreach(DataRow row in table.Rows)
			{
				row[column] = value;
			}
			return table;
		}

		public static DataTable AddColumnToTable(DataTable table, string column, string value)
		{	
			if( !table.Columns.Contains(column))
			{		
				DataColumn col = new DataColumn(column, typeof(string) );						
				table.Columns.Add(col);
			}

			foreach(DataRow row in table.Rows)
			{
				row[column] = value;
			}
			return table;
		}

		public static DataTable AddColumnToTable(DataTable table, string column, DateTime value)
		{						
			if( !table.Columns.Contains(column))
			{
				DataColumn col = new DataColumn(column, typeof(System.DateTime) );						
				table.Columns.Add(col);
			}

			foreach(DataRow row in table.Rows)
			{
				row[column] = value;
			}
			return table;
		}

		public static DataTable AddColumnToTable(DataTable table, string column, decimal value)
		{						
			if( !table.Columns.Contains(column))
			{
				DataColumn col = new DataColumn(column, typeof(decimal) );						
				table.Columns.Add(col);
			}

			foreach(DataRow row in table.Rows)
			{
				row[column] = value;
			}
			return table;
		}

	}
}


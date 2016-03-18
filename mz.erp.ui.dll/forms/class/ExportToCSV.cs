using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using mz.erp.businessrules;
using System.Text;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de ExportToCSV.
	/// </summary>
	public class ExportToCSV
	{
		public ExportToCSV(string separator)
		{
			_separator = separator;
		}

		private string _separator = string.Empty;
			
		public void Export(System.Data.DataView source, string fileName, ArrayList columnsProperties)
		{

			StreamWriter SW;
			SW = new StreamWriter(fileName, false, new System.Text.UTF8Encoding());
			StringBuilder sb = new StringBuilder();
			ArrayList aux = new ArrayList();
			foreach(PropertiesColumn pc in columnsProperties)
			{
				if(pc.Visible)
				{
					aux.Add(pc);
					string parse = pc.ColumnCaption;
					parse = mz.erp.systemframework.Util.ArregloCadena(parse);
					//parse.Replace(_separator,"");
					parse.Trim(new char[]{_separator.ToCharArray()[0]});
					sb.Append( parse + _separator);
				}
			}
			sb.Append("\r\n");
			foreach(DataRowView x in source)
			{
				foreach(PropertiesColumn pc in aux)
				{
					if (source.Table.Columns.Contains(pc.ColumnName))
					{
						string parse = x.Row[pc.ColumnName].ToString();
						parse = mz.erp.systemframework.Util.ArregloCadena(parse);
						//parse.Replace(_separator,"");
						parse.Trim(new char[]{_separator.ToCharArray()[0]});
						sb.Append( parse + _separator);
					}
				}
				sb.Append("\r\n");
			}
			SW.Write(sb.ToString());
			SW.Close();
			try
			{
				System.Diagnostics.Process.Start("Excel.exe", fileName);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}

		}

	}
}

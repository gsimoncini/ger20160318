using System;
using System.Data;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de st_Equipo.
	/// </summary>
	public class st_Equipo
	{
		public st_Equipo()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static DataRow GetByPk(string IdEquipo)
		{
			DataRow row = mz.erp.dataaccess.st_Equipo.GetByPk(IdEquipo);
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;
		}
	}
}

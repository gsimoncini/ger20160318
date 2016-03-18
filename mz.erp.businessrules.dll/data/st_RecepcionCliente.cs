using System;
using System.Data;
using mz.erp.systemframework;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de st_RecepcionCliente.
	/// </summary>
	public class st_RecepcionCliente
	{
		public st_RecepcionCliente()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataRow GetByPk(string IdRecepcionCliente)
		{
			DataRow row = mz.erp.dataaccess.st_RecepcionCliente.GetByPk(IdRecepcionCliente);
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value && !dc.Caption.ToUpper().Equals("ROWID") && !dc.Caption.ToUpper().Equals("ULTIMAMODIFICACION"))
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;
		}
	}
}

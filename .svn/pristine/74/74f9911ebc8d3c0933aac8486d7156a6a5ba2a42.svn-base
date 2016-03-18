using System;
using System.Data;
using System.Collections;
using mz.erp.systemframework;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de ReporteCierreCaja.
	/// </summary>
	public class tfi_ReporteCierreCaja
	{
		public tfi_ReporteCierreCaja()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static System.Data.DataSet GetCierreCaja (string IdInstanciaCaja)
		{
			System.Data.DataSet data = mz.erp.dataaccess.reportes.tfi_ReporteCierreCaja.GetCierreCaja(IdInstanciaCaja);
			foreach (System.Data.DataTable tabla in data.Tables)
				foreach(System.Data.DataRow row  in tabla.Rows)
					foreach ( DataColumn dc in row.Table.Columns ) 
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
			return data;

		}
	}
}

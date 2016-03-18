using System;
using System.Data;
using System.Collections;
using mz.erp.systemframework;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de tsa_ReporteImpuestos.
	/// </summary>
	public class tsa_ReporteImpuestos
	{
		public tsa_ReporteImpuestos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}



		public static System.Data.DataSet GetList(DateTime fechaDesde, DateTime fechaHasta, ArrayList impuestos)
		{

			string CompDeVentas = Variables.GetValueString("Comprobantes.ComprobantesDeVenta");
			System.Data.DataSet data = mz.erp.dataaccess.reportes.tsa_ReporteImpuestos.GetList(fechaDesde, fechaHasta, impuestos,CompDeVentas);
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

		public static System.Data.DataSet GetLibroIVACompras(int AñoDesde, int MesDesde, int AñoHasta, int MesHasta, string ListaTiposDeComprobantes)
        {
			return mz.erp.dataaccess.reportes.tsa_ReporteImpuestos.GetLibroIVACompras(AñoDesde, MesDesde, AñoHasta, MesHasta, ListaTiposDeComprobantes);
		}
	}
}

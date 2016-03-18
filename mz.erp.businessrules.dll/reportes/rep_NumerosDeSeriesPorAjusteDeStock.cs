using System;
using System.Data;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_NumerosDeSeriesPorAjusteDeStock.
	/// </summary>
	public class rep_NumerosDeSeriesPorAjusteDeStock
	{
		public rep_NumerosDeSeriesPorAjusteDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataSet GetList(object obj)
		{
			DataRow row = (DataRow)obj;
			string IdMovimientoDeStock = Convert.ToString(row["IdMovimientoDeStock"]);
			return mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.GetList( IdMovimientoDeStock, null);
			
		}
	}
}

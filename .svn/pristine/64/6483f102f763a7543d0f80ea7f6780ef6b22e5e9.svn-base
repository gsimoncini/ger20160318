using System;
using System.Data;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_DetalleListadoDeComprasPorArt.
	/// </summary>
	public class rep_DetalleListadoDeComprasPorArt
	{
		public rep_DetalleListadoDeComprasPorArt()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataSet GetList(object obj)
		{
			DataRow row = (DataRow)obj;
			string IdComprobante = Convert.ToString(row["IdComprobante"]);
			string IdProducto = Convert.ToString(row["IdProducto"]);
			return mz.erp.dataaccess.reportes.rep_DetalleListadoDeComprasPorArt.GetList(IdComprobante, IdProducto);
		}
	}
}

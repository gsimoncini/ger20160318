using System;
using System.Data;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDePercepcionDeIngresosBrutos.
	/// </summary>
	public class rep_ListadoDePercepcionDeIngresosBrutos
	{
		public rep_ListadoDePercepcionDeIngresosBrutos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataTable GetList(DateTime fechaDesde, DateTime fechaHasta)
		{
			return mz.erp.dataaccess.reportes.rep_ListadoDePercepcionDeIngresosBrutos.GetList(fechaDesde, fechaHasta);
		}
	}
}

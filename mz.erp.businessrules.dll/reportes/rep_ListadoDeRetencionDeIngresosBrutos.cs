//German 20120412 - Tarea 0000286
using System;
using System.Data;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDePercepcionDeIngresosBrutos.
	/// </summary>
	public class rep_ListadoDeRetencionDeIngresosBrutos
	{
		public rep_ListadoDeRetencionDeIngresosBrutos()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static DataTable GetList(DateTime fechaDesde, DateTime fechaHasta)
		{
			return mz.erp.dataaccess.reportes.rep_ListadoDeRetencionDeIngresosBrutos.GetList(fechaDesde, fechaHasta);
		}
	}
}

//German 20120412 - Tarea 0000286
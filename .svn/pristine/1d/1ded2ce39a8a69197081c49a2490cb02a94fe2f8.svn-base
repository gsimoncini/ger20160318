using System;
using System.Data;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de Reporte_ComprobantesDeVenta.
	/// </summary>
	public class Reporte_ComprobantesDeVenta
	{
		public Reporte_ComprobantesDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable)
		{
			DataSet data = new DataSet();
			data = mz.erp.dataaccess.Reportes.tsa_ComprobantesDeVenta.GetList( data, null, IdCuenta, FechaDesde, FechaHasta, IdResponsable, Security.IdEmpresa, Security.IdSucursal );
			return data;
		}
	}
}

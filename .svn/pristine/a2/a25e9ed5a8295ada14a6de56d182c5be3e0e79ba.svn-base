using System;
using System.Data;
using System.Collections;
using mz.erp.systemframework;


namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de tsh_ReporteActualizacionPrecios.
	/// </summary>
	public class tsh_ReporteActualizacionPrecios
	{
		public tsh_ReporteActualizacionPrecios()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, long IdEmpresa, long IdSucursal)
		{
			return  mz.erp.dataaccess.reportes.tsh_ReporteActualizacionPrecios.GetList(FechaDesde, FechaHasta, Security.IdEmpresa, Security.IdSucursal);
			
		}
	}
}


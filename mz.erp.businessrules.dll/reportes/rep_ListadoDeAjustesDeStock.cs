using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeAjustesDeStock.
	/// </summary>
	public class rep_ListadoDeAjustesDeStock
	{
		public rep_ListadoDeAjustesDeStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Persona, string Producto, string TipoDeAjuste, long IdEmpresa, long IdSucursal )
		{
			return  mz.erp.dataaccess.reportes.rep_ListadoDeAjustesDeStock.GetList( FechaDesde, FechaHasta, Persona, Producto, TipoDeAjuste, IdEmpresa, IdSucursal );
		}
	
	}
}

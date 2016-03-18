using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeComprasPorArt.
	/// </summary>
	public class rep_ListadoDeComprasPorArt
	{
		public rep_ListadoDeComprasPorArt()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Producto, string IdProveedor,string Numero, string Aux1,long IdEmpresa, long IdSucursal )
		{
			string IdTiposDeComprobantes = Variables.GetValueString("ProcesoConsultarListadoDeComprasPorArt","ListarComprobantesDeCompra","ListaTiposDeComprobantes");
			return  mz.erp.dataaccess.reportes.rep_ListadoDeComprasPorArt.GetList( FechaDesde, FechaHasta, Producto, IdProveedor,Numero, Aux1,IdTiposDeComprobantes, IdEmpresa, IdSucursal );
		}
	}
}

using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeIngreso.
	/// </summary>
	public class rep_ListadoDeIngreso
	{
		public rep_ListadoDeIngreso()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Proveedor, string Responsable,string Numero, string Aux1, long IdEmpresa, long IdSucursal )
		{
			string IdTiposDeComprobantes = Variables.GetValueString("ProcesoConsultarListadoDeIngreso","ListarComprobantesDeCompra","ListaTiposDeComprobantes");
			return  mz.erp.dataaccess.reportes.rep_ListadoDeIngreso.GetList( FechaDesde, FechaHasta, Proveedor, Responsable,Numero,Aux1,IdTiposDeComprobantes, IdEmpresa, IdSucursal );
		}



	}
}

using System;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de tsa_ReporteDetalleComprobantesDeVenta.
	/// </summary>
	public class tsa_ReporteDetalleComprobantesDeVenta
	{
		public tsa_ReporteDetalleComprobantesDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		/*public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdComprobante)
		{
			System.Data.DataSet _data = new System.Data.DataSet();
			return  mz.erp.dataaccess.reportes.tsa_ReporteDetalleComprobantesDeVenta.GetList(_data, IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, Security.IdEmpresa, Security.IdSucursal, IdComprobante );
		}*/
		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante)
		{
			System.Data.DataSet _data = new System.Data.DataSet();
			return  mz.erp.dataaccess.reportes.tsa_ReporteDetalleComprobantesDeVenta.GetList(_data, IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, Security.IdEmpresa, Security.IdSucursal, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
		}


		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string IdJerarquia9, string IdJerarquia10, string IdJerarquia11, string IdJerarquia12, string IdJerarquia13, string IdJerarquia14, string IdJerarquia15, string IdJerarquia16, string NumeroDesde, string NumeroHasta)
		{
			return  GetList( IdCuenta, FechaDesde, FechaHasta, IdResponsable, IdTipoDeComprobante,  null, IdProducto, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8, IdJerarquia9, IdJerarquia10, IdJerarquia11, IdJerarquia12, IdJerarquia13, IdJerarquia14, IdJerarquia15, IdJerarquia16, NumeroDesde,NumeroHasta);
			
		}

		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdComprobante, string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string IdJerarquia9, string IdJerarquia10, string IdJerarquia11, string IdJerarquia12, string IdJerarquia13, string IdJerarquia14, string IdJerarquia15, string IdJerarquia16, string NumeroDesde, string NumeroHasta)
		{
			System.Data.DataSet _data = new System.Data.DataSet();
			return  mz.erp.dataaccess.reportes.tsa_ReporteDetalleComprobantesDeVenta.GetList(_data, IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, Security.IdEmpresa, Security.IdSucursal, IdComprobante, IdProducto, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8, IdJerarquia9, IdJerarquia10, IdJerarquia11, IdJerarquia12, IdJerarquia13, IdJerarquia14, IdJerarquia15, IdJerarquia16, NumeroDesde,NumeroHasta);
		}

	}
}

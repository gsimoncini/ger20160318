using System;
using System.Data;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de Reporte_ComprobantesDeVenta.
	/// </summary>
	public class tsa_ReporteComprobantesDeVenta
	{
		public tsa_ReporteComprobantesDeVenta()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		

		public static System.Data.DataSet GetVentasPorMedioDePago(  DateTime FechaDesde, DateTime FechaHasta, string ListaRecibos, string ListaRecibosAlContado, string ListaFacturasYNotasDeCreditos, string ListaDevolucionesPagos)
		{
			return mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetVentasPorMedioDePago( FechaDesde, FechaHasta, ListaRecibos, ListaRecibosAlContado, ListaFacturasYNotasDeCreditos, ListaDevolucionesPagos);
		}

		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, bool VerHTML, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			return GetList( IdCuenta,  FechaDesde,  FechaHasta,  IdResponsable,  IdTipoDeComprobante,  null, VerHTML, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);
		}

		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdComprobante, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			System.Data.DataSet _data = new DataSet();
			return  mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetList( _data, IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, Security.IdEmpresa, Security.IdSucursal , IdComprobante, false, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);
			
		}
		
		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdComprobante, bool VerHTML, string IdJerarquia1,string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			System.Data.DataSet _data = new DataSet();
			return  mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetList( _data, IdTipoDeComprobante, IdCuenta, FechaDesde, FechaHasta, IdResponsable, Security.IdEmpresa, Security.IdSucursal , IdComprobante, VerHTML, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);
			
		}

        //German 20120229 - Tarea 0000247
        public static System.Data.DataSet GetAcopios(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta)
        {
            System.Data.DataSet _data = new DataSet();
            return  mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetAcopios(_data, IdCuenta, FechaDesde, FechaHasta);
        }

        public static System.Data.DataSet GetDetalleAcopio(string IdComprobante)
        {
            System.Data.DataSet _data = new DataSet();
            return mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetDetalleAcopio(_data, IdComprobante);
        }
        //Fin German 20120229 - Tarea 0000247

        /* Silvina 20120420 - Tarea 0000294 */
        public static System.Data.DataSet GetListComisiones(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdJerarquiaProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
        {
            System.Data.DataSet _data = new DataSet();
            return mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetListComisiones(_data, IdCuenta, FechaDesde, FechaHasta, IdResponsable, IdTipoDeComprobante, IdJerarquiaProducto, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);
        }

        public static System.Data.DataSet GetListVentasPorVendedor(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string IdJerarquia9, string IdJerarquia10, string IdJerarquia11, string IdJerarquia12, string IdJerarquia13, string IdJerarquia14, string IdJerarquia15, string IdJerarquia16)
        {
            System.Data.DataSet _data = new DataSet();
            return mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetListVentasPorVendedor(_data, IdCuenta, FechaDesde, FechaHasta, IdResponsable, IdTipoDeComprobante, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8, IdJerarquia9, IdJerarquia10, IdJerarquia11, IdJerarquia12, IdJerarquia13, IdJerarquia14, IdJerarquia15, IdJerarquia16);
        }

        public static System.Data.DataSet GetListCobranzas(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string IdTipoDeComprobante, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
        {
            System.Data.DataSet _data = new DataSet();
            return mz.erp.dataaccess.reportes.tsa_ReporteComprobantesDeVenta.GetListCobranzas(_data, IdCuenta, FechaDesde, FechaHasta, IdResponsable, IdTipoDeComprobante, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);
        }

        /* Fin Silvina 20120420 - Tarea 0000294 */
	}
}

using System;
using System.Data;


namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de rep_ConsultarComprobantesDeCompra.
	/// </summary>
	public class rep_ConsultarComprobantesDeCompra
	{
		public rep_ConsultarComprobantesDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

        //Cristian -- Tarea 836
		public static DataSet GetList( string IdTipoDeComprobante, string IdProveedor,
            DateTime FechaDesde, DateTime FechaHasta, DateTime RegistracionDesde,DateTime RegistracionHasta, string IdResponsable, long IdEmpresa, long IdSucursal,
			string TiposDeComprobanteDestinoExcluidos)
		{	
			System.Data.DataSet _data = new DataSet();
			return mz.erp.dataaccess.reportes.rep_ConsultarComprobantesDeCompra.GetList(_data, IdTipoDeComprobante, IdProveedor,
					FechaDesde, FechaHasta, RegistracionDesde, RegistracionHasta, IdResponsable, IdEmpresa, IdSucursal, TiposDeComprobanteDestinoExcluidos);
		}


		public static DataSet GetListComprobantesPendientesDePreNotaDeDebito( string IdTipoDeComprobante, string IdProveedor, 
			DateTime FechaDesde, DateTime FechaHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string IdResponsable, long IdEmpresa, long IdSucursal,
			string TiposDeComprobanteDestinoExcluidos)
		{	
			System.Data.DataSet _data = new DataSet();
			return mz.erp.dataaccess.reportes.rep_ConsultarComprobantesDeCompra.GetListComprobantesPendientesDePreNotaDeDebito(_data, IdTipoDeComprobante, IdProveedor,
				FechaDesde, FechaHasta,RegistracionDesde, RegistracionHasta, IdResponsable, IdEmpresa, IdSucursal, TiposDeComprobanteDestinoExcluidos);
		}
        //Fin Tarea 836
    } 
    
}

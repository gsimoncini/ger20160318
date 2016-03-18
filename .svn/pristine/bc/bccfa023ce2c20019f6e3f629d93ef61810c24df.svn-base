using System;
using System.Collections;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.businessrules.reportes
{
	/// <summary>
	/// Descripción breve de ReportsFactory.
	/// </summary>
	public class ReportsFactory
	{
		public ReportsFactory()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		/*---------------------------------- CONSULTAS DE CAJA --------------------------------------*/
		
		public static System.Data.DataSet ConsultaPosicionDeCajaDetallado (string IdMonedaReferencia, string IdEntidades, string IdTDCompTesoreria, System.DateTime FechaDesde, System.DateTime FechaHasta,	string IdPersona, string Estado, string IdCajas, string EstadoCajas	)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeCajaDetallado	(IdMonedaReferencia, IdEntidades, IdTDCompTesoreria, FechaDesde, FechaHasta,IdPersona, Estado, IdCajas, EstadoCajas);
		}

		public static System.Data.DataSet ConsultaPosicionDeCajaDetalladoAnterior (string IdMonedaReferencia, string IdEntidades, string IdTDCompTesoreria, System.DateTime FechaDesde, System.DateTime FechaHasta,	string IdPersona, string Estado, string IdCajas, string EstadoCajas	)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeCajaDetalladoAnterior(IdMonedaReferencia, IdEntidades, IdTDCompTesoreria, FechaDesde, FechaHasta,IdPersona, Estado, IdCajas, EstadoCajas);
		}

		#region ConsultaCobranzasYPagos
		public static System.Data.DataSet ConsultaCobranzasYPagos(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultasCobranzasYPagos( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}

		public static System.Data.DataSet ConsultaCobranzasYPagosAbiertas(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultasCobranzasYPagosAbiertas( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}

		public static System.Data.DataSet ConsultaCobranzasYPagosCerradas(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultasCobranzasYPagosCerradas( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}

		public static System.Data.DataSet ConsultaCobranzasYPagosTodas(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultasCobranzasYPagosAbiertasCerradas( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}

		public static System.Data.DataSet ConsultaCobranzasYPagosFechaMovimiento(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultasCobranzasYPagosFechaMovimiento( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}

		#endregion

		public static System.Data.DataSet GetMovimientosDeCajaPosterioresA(System.DateTime fechaUltimoControlDeCaja, string IdInstanciaCaja)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetMovimientosDeCajaPosterioresA( fechaUltimoControlDeCaja, IdInstanciaCaja );
		}

		public static System.Data.DataSet ConsultaMovimientosDeCaja(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultasMovimientosDeCaja( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}
		public static System.Data.DataSet ConsultaDeCaja(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeCaja( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}

		public static System.Data.DataSet ConsultaDeCajaAnterior(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdResponsable, string IdTipo, string EstadoCajas)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeCajaAnterior( IdCaja, fechaApertura, fechaCierre, IdResponsable, IdTipo, EstadoCajas);
		}

		public static System.Data.DataSet ConsultaDeValoresCajas( string IdTDCompTesoreria, string IdInstanciaCaja	)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeValoresCajas(IdTDCompTesoreria, IdInstanciaCaja);
		}

		public static System.Data.DataSet ConsultaDeValoresCajasAnterior( string IdTDCompTesoreria, string IdInstanciaCaja	)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeValoresCajasAnterior(IdTDCompTesoreria, IdInstanciaCaja);
		}

		public static System.Data.DataSet ConsultaDeGastos(string IdCaja, System.DateTime fechaApertura, System.DateTime fechaCierre, string IdTipo)
		{
			return mz.erp.dataaccess.reportes.GenericReports.GetConsultaDeGastos( IdCaja, fechaApertura, fechaCierre,  IdTipo);
		}
		/*-------------------------------------------------------------------------------------------*/

		public static System.Data.DataSet ComprobantesDeCompraPorNumeroDeSerie(DateTime fechaDesde, DateTime fechaHasta, string NumeroDeSerie)
		{
			return  mz.erp.dataaccess.tpu_Comprobantes.ComprobantesDeCompraPorNumeroDeSerie( fechaDesde, fechaHasta, NumeroDeSerie);			
		}

		public static System.Data.DataSet ComprobantesPendientes( string idTiposDeComprobantes, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa)
		{
			return  mz.erp.dataaccess.tsa_ComprobantesEx.ComprobantesPendientes( idTiposDeComprobantes, idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa);			
		}

        //Cristian 20100920 Tarea 836
        public static System.Data.DataSet ComprobantesDeComprasPendientes(string tiposComprobantesOrigen, string tiposComprobantesDestino, string idProveedor, DateTime fechaDesdeEmision, DateTime fechaHastaEmision, DateTime DesdeRecepcion, DateTime HastaRecepcion, DateTime DesdeRegistracion, DateTime HastaRegistracion, string idResponsable, long idSucursal, long idEmpresa, bool VerHTML, string TiposComprobantesDestinoExcluidos)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ComprobantesPendientes( tiposComprobantesOrigen, tiposComprobantesDestino, idProveedor,  fechaDesdeEmision, fechaHastaEmision,  DesdeRecepcion, HastaRecepcion, DesdeRegistracion, HastaRegistracion, idResponsable, idSucursal, idEmpresa, VerHTML, TiposComprobantesDestinoExcluidos);			
		}
        //fin Cristian
        //Cristian Tarea 836
		public static System.Data.DataSet ListarComprobantesDeCompraPendientesPago( string tiposComprobantesOrigen, string idProveedor, DateTime fechaEmisionDesde, DateTime fechaEmisionHasta, DateTime fechaVencimientoDesde ,DateTime fechaVencimientoHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarComprobantesDeCompraPendientesPago( tiposComprobantesOrigen, idProveedor,  fechaEmisionDesde, fechaEmisionHasta, fechaVencimientoDesde, fechaVencimientoHasta, RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa, VerHTML, IdCuentaImputacion, IdSubCuentaImputacion);			
		}
        //Fin Cristian 836

        //Cristian tarea 836
        public static System.Data.DataSet ListarComprobantesDeCompraPendientes(string tiposComprobantesOrigen, string idProveedor, DateTime fechaDesde, DateTime fechaHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa, bool VerHTML, string TiposComprobantesDestinoExcluidos)
		{
            return mz.erp.dataaccess.tpu_ComprobantesEx.ListarComprobantesDeCompraPendientes(tiposComprobantesOrigen, idProveedor, fechaDesde, fechaHasta, RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa, VerHTML, TiposComprobantesDestinoExcluidos);			
		}
        //Fin tarea 836
        //Cristian 20100920 Tarea 836
		public static System.Data.DataSet ListarComprobantesDeCompra( string tiposComprobantesOrigen, string idProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa, bool VerHTML, string estados)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarComprobantesDeCompra( tiposComprobantesOrigen, idProveedor,  EmisionDesde, EmisionHasta,  RecepcionDesde, RecepcionHasta, RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa, VerHTML, estados);			
		}
        //Fin Cristian Tarea 836

		public static System.Data.DataSet ListarComprobantesDeCompraPendientes( string idProveedor, DateTime FechaDesde, DateTime FechaHasta, long idSucursal, long idEmpresa, bool VerHTML)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarComprobantesDeCompraPendientes( idProveedor,  FechaDesde, FechaHasta, idSucursal, idEmpresa, VerHTML);			
		}

		public static System.Data.DataSet ListarRetencionesProveedores( string NumeroRetencion, DateTime FechaRetencionDesde, DateTime FechaRetencionHasta, string IdTipoDeRetencion, string NumeroRecibo, DateTime FechaReciboDesde, DateTime FechaReciboHasta, string NumeroFactura, DateTime FechaFacturaDesde, DateTime FechaFacturaHasta, long idSucursal, long idEmpresa, bool VerHTML)
		{
			return  mz.erp.dataaccess.tpu_RetencionesEx.ListarRetencionesProveedores(NumeroRetencion, FechaRetencionDesde, FechaRetencionHasta, IdTipoDeRetencion, NumeroRecibo, FechaReciboDesde, FechaReciboHasta, NumeroFactura, FechaFacturaDesde, FechaFacturaHasta, idSucursal, idEmpresa, VerHTML);			
		}

        //Cristiah 20100920 Tarea 836
        public static System.Data.DataSet ListarDetalleComprobantesDeCompra(string tiposComprobantesOrigen, string idProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa, bool VerHTML, string estados, string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarDetalleComprobantesDeCompra( tiposComprobantesOrigen, idProveedor,  EmisionDesde, EmisionHasta,  RecepcionDesde, RecepcionHasta, RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa, VerHTML, estados, IdProducto, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);			
		}
        //Fin Tarea 836

        //Cristian Tarea 836
		public static System.Data.DataSet ListarComprobantesDeCompraCabecera( string tiposComprobantesOrigen, string idProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarComprobantesDeCompraCabecera( tiposComprobantesOrigen, idProveedor,  EmisionDesde, EmisionHasta, VencimientoDesde, VencimientoHasta, RecepcionDesde, RecepcionHasta, RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa, VerHTML, IdCuentaImputacion, IdSubCuentaImputacion);			
		}
        //Fin Tarea 836
        //Cristian Tarea 836
        public static System.Data.DataSet ListarComprobantesDeCompraCabeceraPendienteItems(string tiposComprobantesOrigen, string idProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa, bool VerHTML, string IdCuentaImputacion, string IdSubCuentaImputacion)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarComprobantesDeCompraCabeceraPendienteItems( tiposComprobantesOrigen, idProveedor,  EmisionDesde, EmisionHasta, VencimientoDesde, VencimientoHasta, RecepcionDesde, RecepcionHasta,RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa, VerHTML, IdCuentaImputacion, IdSubCuentaImputacion);			
		}
        //Fin Tarea 836
        //Cristian Tarea 836
        public static System.Data.DataSet ListarPreOrdenesDeCompraEditables(string idProveedor, DateTime fechaDesde, DateTime fechaHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarPreOrdenesDeCompraEditables( idProveedor,  fechaDesde, fechaHasta, RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa);			
		}
        //Fin Tarea 836
        //Cristian 20100920 tarea 836
        public static System.Data.DataSet ListarComprobanteDeCompraCabeceraEditables(string tiposComprobantesOrigen, string idProveedor, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, DateTime RecepcionDesde, DateTime RecepcionHasta, DateTime RegistracionDesde, DateTime RegistracionHasta, string idResponsable, long idSucursal, long idEmpresa)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.ListarComprobanteDeCompraCabeceraEditables( tiposComprobantesOrigen, idProveedor,  EmisionDesde, EmisionHasta, VencimientoDesde, VencimientoHasta, RecepcionDesde, RecepcionHasta, RegistracionDesde, RegistracionHasta, idResponsable, idSucursal, idEmpresa);			
		}
        //Fin Cristian tarea 836

		public static System.Data.DataSet DetalleComprobantesDeCompras (string idTiposDeComprobantes, string idProveedor, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa)
		{
			return  mz.erp.dataaccess.tpu_ComprobantesEx.DetalleComprobantesDeCompra( idTiposDeComprobantes, idProveedor,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa);			
		}
		/*
		public static System.Data.DataSet ComprobantesPendientesWF( string tiposComprobantesOrigen, string tiposComprobantesDestino, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, string tiposDeComprobanteDestinoExcluidos, bool verHTML)
		{						
			return  mz.erp.dataaccess.Workflow.ComprobantesPendientes( tiposComprobantesOrigen, tiposComprobantesDestino,idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, tiposDeComprobanteDestinoExcluidos, true);
		}
		*/

		public static System.Data.DataSet ComprobantesWF( string tiposComprobantesOrigen, string tiposComprobantesDestino, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, string tiposDeComprobanteDestinoExcluidos, bool verHTML)
		{						
			return  mz.erp.dataaccess.Workflow.Comprobantes( tiposComprobantesOrigen, tiposComprobantesDestino,idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, tiposDeComprobanteDestinoExcluidos, verHTML);
		}

		public static System.Data.DataSet ComprobantesPendientesWF( string tiposComprobantesOrigen, string tiposComprobantesDestino, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, string tiposDeComprobanteDestinoExcluidos, bool verHTML)
		{						
			return  mz.erp.dataaccess.Workflow.ComprobantesPendientes( tiposComprobantesOrigen, tiposComprobantesDestino,idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, tiposDeComprobanteDestinoExcluidos, verHTML);
		}

		public static System.Data.DataSet ComprobantesPendientesNumeroDeSerieWF( string tiposComprobantesOrigen, string tiposComprobantesDestino, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, string tiposDeComprobanteDestinoExcluidos, bool verHTML)
		{						
			return  mz.erp.dataaccess.Workflow.ComprobantesPendientesNumeroDeSerieWF( tiposComprobantesOrigen, tiposComprobantesDestino,idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, tiposDeComprobanteDestinoExcluidos, verHTML);
		}

		public static System.Data.DataSet ComprobantesPendientesNumeroDeSerieWFEx( string tiposComprobantesOrigen, string tiposComprobantesDestino, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, string tiposDeComprobanteDestinoExcluidos, bool verHTML)
		{						
			return  mz.erp.dataaccess.Workflow.ComprobantesPendientesNumeroDeSerieWFEx( tiposComprobantesOrigen, tiposComprobantesDestino,idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, tiposDeComprobanteDestinoExcluidos, verHTML);
		}


		public static System.Data.DataSet ComprobantesPendientesEntregasWF( string tiposComprobantesOrigen, string tiposComprobantesDestino, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, string tiposDeComprobanteDestinoExcluidos, bool verHTML)
		{						
			return  mz.erp.dataaccess.Workflow.ComprobantesPendientesEntregas( tiposComprobantesOrigen, tiposComprobantesDestino,idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, tiposDeComprobanteDestinoExcluidos, verHTML);
		}

		public static System.Data.DataSet ComprobantesEntregasWF( string tiposComprobantesOrigen, string tiposComprobantesDestino, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, string tiposDeComprobanteDestinoExcluidos, bool verHTML)
		{						
			return  mz.erp.dataaccess.Workflow.ComprobantesEntregas( tiposComprobantesOrigen, tiposComprobantesDestino,idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, tiposDeComprobanteDestinoExcluidos, verHTML);
		}



		public static System.Data.DataSet ListarComprobantesWF (string tiposComprobantesOrigen, string comprobante, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, bool verHTML, string ListaTiposDeComprobantesExcluidos)
		{
			return mz.erp.dataaccess.Workflow.ListarComprobantes(tiposComprobantesOrigen, comprobante, idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, verHTML,  ListaTiposDeComprobantesExcluidos);
		}

		public static System.Data.DataSet ListarComprobantesEntregasWF (string tiposComprobantesOrigen, string comprobante, string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string idResponsable, long idSucursal, long idEmpresa, bool verHTML, bool SoloPendientes, string ListaTiposDeComprobantesExcluidos, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			return mz.erp.dataaccess.Workflow.ListarComprobantesEntregas(tiposComprobantesOrigen, comprobante, idCuenta,  fechaDesde, fechaHasta, idResponsable, idSucursal, idEmpresa, verHTML, SoloPendientes, ListaTiposDeComprobantesExcluidos, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);
		}

		public static System.Data.DataTable ReparacionesPendientesWF(string IdOrdenReparacion,  string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string EstadoOrdenReparacion, bool EsEquipoNuevo)
		{			
			return  mz.erp.dataaccess.Workflow.ReparacionesPendientes(IdOrdenReparacion, idCuenta,  fechaDesde, fechaHasta, EstadoOrdenReparacion, EsEquipoNuevo);			
		}

		public static System.Data.DataTable ComprobantesConProductosPendientesDeNumeroDeSerie( DateTime fechaDesde, DateTime fechaHasta, string TiposDeComprobantesValidos, string EstadosDeStockValidos)
		{			
			return  mz.erp.dataaccess.Workflow.ComprobantesConProductosPendientesDeNumeroDeSerie(fechaDesde, fechaHasta, TiposDeComprobantesValidos, EstadosDeStockValidos);			
		}

		public static System.Data.DataTable ReparacionesAjustarStockDevolucion(string IdOrdenReparacion,  string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string EstadoOrdenReparacion)
		{			
			return  mz.erp.dataaccess.Workflow.ReparacionesAjustarStockDevolucion(IdOrdenReparacion, idCuenta,  fechaDesde, fechaHasta, EstadoOrdenReparacion);			
		}

		public static System.Data.DataTable ReparacionesAjustarStockTransferencia(string IdOrdenReparacion,  string idCuenta, DateTime fechaDesde, DateTime fechaHasta, string EstadoOrdenReparacion)
		{			
			return  mz.erp.dataaccess.Workflow.ReparacionesAjustarStockTransferencia(IdOrdenReparacion, idCuenta,  fechaDesde, fechaHasta, EstadoOrdenReparacion);			
		}

        /* Silvina 20111212 - Tarea 0000232 */
        public static System.Data.DataSet GetListPendientesReservas(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, DateTime FechaVencimientoDesde, DateTime FechaVencimientoHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML, long IdSucursal, long IdEmpresa)
        {
            return mz.erp.dataaccess.Workflow.GetListPendientesReservas(IdCuenta, FechaDesde, FechaHasta, FechaVencimientoDesde, FechaVencimientoHasta, IdResponsable, tiposComprobantesOrigen, tiposComprobantesDestino, tiposDeComprobanteDestinoExcluidos, VerHTML, IdSucursal, IdEmpresa);
        }
        /* Fin Silvina 20111212 - Tarea 0000232 */

		
	}
}

using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de Reporte_ComprobantesDeVenta.
	/// </summary>
	public class ComprobantesPendientesWF
	{
		public ComprobantesPendientesWF()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	
		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesWF( tiposComprobantesOrigen,tiposComprobantesDestino,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa,tiposDeComprobanteDestinoExcluidos, VerHTML);			
		}

		public static System.Data.DataSet GetListEx( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesWF( tiposComprobantesOrigen,tiposComprobantesDestino,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa,tiposDeComprobanteDestinoExcluidos, VerHTML);			
		}

		public static System.Data.DataSet GetListPendientesNumeroDeSerie( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesNumeroDeSerieWF( tiposComprobantesOrigen,tiposComprobantesDestino,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa,tiposDeComprobanteDestinoExcluidos, VerHTML);			
		}

		public static System.Data.DataSet GetListPendientesNumeroDeSerieEx( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesNumeroDeSerieWFEx( tiposComprobantesOrigen,tiposComprobantesDestino,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa,tiposDeComprobanteDestinoExcluidos, VerHTML);			
		}

		public static System.Data.DataSet GetListEntregas( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesPendientesEntregasWF( tiposComprobantesOrigen,tiposComprobantesDestino,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa,tiposDeComprobanteDestinoExcluidos, VerHTML);			
		}

		public static System.Data.DataSet GetListExEntregas( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesEntregasWF( tiposComprobantesOrigen,tiposComprobantesDestino,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa,tiposDeComprobanteDestinoExcluidos, VerHTML);			
		}

        /* Silvina 20111212 - Tarea 0000232 */
        public static System.Data.DataSet GetListPendientesReservas(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, DateTime FechaVencimientoDesde, DateTime FechaVencimientoHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
        {
            return mz.erp.businessrules.reportes.ReportsFactory.GetListPendientesReservas(IdCuenta, FechaDesde, FechaHasta, FechaVencimientoDesde, FechaVencimientoHasta, IdResponsable, tiposComprobantesOrigen, tiposComprobantesDestino, tiposDeComprobanteDestinoExcluidos, VerHTML, Security.IdSucursal, Security.IdEmpresa);
        }
        /* Fin Silvina 20111212 - Tarea 0000232 */

		private static string[] _fieldList=null;
		[ atMethodLayoutData ]
		public static string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",100 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",125) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true ) );
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emisión",150 ) );
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			if ( fl.Contains( "Sucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
			if ( fl.Contains( "Pendientes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "Pendientes", "Pendientes",true ) );
			
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}

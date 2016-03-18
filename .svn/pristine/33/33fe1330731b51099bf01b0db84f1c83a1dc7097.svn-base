using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ListarComprobantesPendientesWF.
	/// </summary>
	public class ListarComprobantesPendientesWF
	{
		public ListarComprobantesPendientesWF()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string comprobante, bool verHTML, string ListaTiposDeComprobantesExcluidos)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesWF( tiposComprobantesOrigen, comprobante ,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa, verHTML, ListaTiposDeComprobantesExcluidos);			
		}

		public static System.Data.DataSet GetListEntregas( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string comprobante, bool verHTML, bool SoloPendientes, string ListaTiposDeComprobantesExcluidos, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesEntregasWF( tiposComprobantesOrigen, comprobante ,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa, verHTML, SoloPendientes, ListaTiposDeComprobantesExcluidos, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8);			
		}

        // BORRAR LO DEJE SOLO DE PRUEBA
		/*public static System.Data.DataSet GetListEntregas( string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string comprobante, bool verHTML, bool SoloPendientes, string ListaTiposDeComprobantesExcluidos)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ListarComprobantesEntregasWF( tiposComprobantesOrigen, comprobante ,IdCuenta, FechaDesde, FechaHasta,  IdResponsable, Security.IdSucursal, Security.IdEmpresa, verHTML, SoloPendientes, ListaTiposDeComprobantesExcluidos,null,null,null,null,null,null,null,null);			
		}*/
		
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
			if ( fl.Contains( "Mes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Mes", "Mes",75 ) );
			if ( fl.Contains( "Ao" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ao", "Año",75 ) );
			if ( fl.Contains( "FechaCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCorta", "Fecha Corta",75 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true ) );
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emisión",150 ) );
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			if ( fl.Contains( "Sucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
			if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "Estado", "Estado",120 ) );
			if ( fl.Contains( "TextoHTML" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "textoHTML", true) );
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}


		public static string GetLayoutEntregas()
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
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Comprobante",150 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",100) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "F. Vencimiento",125 ) );
			if ( fl.Contains( "MesVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MesVencimiento", "Mes F. Venc.",75 ) );
			if ( fl.Contains( "DiaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DiaVencimiento", "Día F. Venc.",75 ) );
			if ( fl.Contains( "AoVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "AoVencimiento", "Año F. Venc.",75 ) );
			if ( fl.Contains( "FechaVencimientoCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimientoCorta", "F. Venc. Corta",75 ) );
			if ( fl.Contains( "Estado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "Estado", "Estado",100 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Cliente",200 ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true ) );
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emisión",150 ) );
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			if ( fl.Contains( "Sucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
			
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",125 ) );
			if ( fl.Contains( "Mes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Mes", "Mes",50 ) );
			if ( fl.Contains( "Ao" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ao", "Año",50 ) );
			if ( fl.Contains( "Dia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Dia", "Día",50 ) );
			if ( fl.Contains( "FechaCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCorta", "Fecha Corta",75 ) );
			
			if ( fl.Contains( "TextoHTML" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "textoHTML", true) );
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}


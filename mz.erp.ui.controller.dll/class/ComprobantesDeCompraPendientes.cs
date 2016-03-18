using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesDeCompraPendientes.
	/// </summary>
	public class ComprobantesDeCompraPendientes
	{
		public ComprobantesDeCompraPendientes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

        //Cristian 20100920 Tarea 836
		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( string IdProveedor, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, bool verHTML, string TiposComprobantesDestinoExcluidos)
		{
            return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesDeComprasPendientes(tiposComprobantesOrigen, tiposComprobantesDestino, IdProveedor, FechaDesde, FechaHasta, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, IdResponsable, Security.IdSucursal, Security.IdEmpresa, verHTML, TiposComprobantesDestinoExcluidos);
			
		}
        //Fin Cristtian Tarea 836

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
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Proveedor",200 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Nro Remito",150) );
			if ( fl.Contains( "Aux1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Aux1", "Nro Factura",150) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",150 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",true ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true ) );
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emision",150 ) );
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			if ( fl.Contains( "Sucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );
			if ( fl.Contains( "Pendientes" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "Pendientes", "Pendientes",true ) );
			if ( fl.Contains( "TextoHTML" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "textoHTML", true) );
			
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}

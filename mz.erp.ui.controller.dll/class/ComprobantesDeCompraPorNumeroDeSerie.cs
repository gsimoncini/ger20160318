using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesDeCompraPorNumeroDeSerie.
	/// </summary>
	public class ComprobantesDeCompraPorNumeroDeSerie
	{
		public ComprobantesDeCompraPorNumeroDeSerie()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta,string NumeroDeSerie)
		{
			return mz.erp.businessrules.reportes.ReportsFactory.ComprobantesDeCompraPorNumeroDeSerie(FechaDesde, FechaHasta, NumeroDeSerie);
			
		}

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
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",125) );
			
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Cód.",50 ) );
			if ( fl.Contains( "Producto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto",200 ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha Emision",125 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha Reg.",125 ) );
			if ( fl.Contains( "Proveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Proveedor", "Proveedor",200 ) );
			if ( fl.Contains( "NumeroDeSerie" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "NumeroDeSerie", "Nº De Serie",150 ) );
			if ( fl.Contains( "Aux1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Aux1", "Nº Factura",125) );
			
			
		
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
}

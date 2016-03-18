using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;


namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de ComprobantesConProductosPendientesDeNumeroDeSerie.
	/// </summary>
	public class ComprobantesConProductosPendientesDeNumeroDeSerie
	{
		public ComprobantesConProductosPendientesDeNumeroDeSerie()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		private static string[] _fieldList=null;
	
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
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante",100 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero",125) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",150 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",true ) );
			if ( fl.Contains( "Proveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Proveedor", "Proveedor",400 ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true ) );
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Resp.Emision",true ) );
			if ( fl.Contains( "Empresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Empresa", "Empresa",true ) );
			if ( fl.Contains( "Sucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sucursal", "Sucursal",true ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true ) );sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();		
		}
	}
	}


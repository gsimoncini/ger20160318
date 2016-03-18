using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using System;
using mz.erp.ui.controllers;

namespace mz.erp.ui.reportes
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


		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Proveedor ,string Responsable, string Numero, string Aux1)
		{			
			/*Por ahora harcodeado. Los tipos de comprobantes de los cuales sale el listado de compras por articulos se deberia obtener de una 
				 * Variable de Sistema o, cuando se pase a workflow, de la informacion del proceos al q pertenzca esta tarea.
				 * */

			return mz.erp.businessrules.reportes.rep_ListadoDeIngreso.GetList(FechaDesde, FechaHasta, Proveedor, Responsable,Numero,Aux1, Security.IdEmpresa, Security.IdSucursal);
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

			//estos son los campos q se vana  mostrar en la grilla
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++,  "Fecha", "Fecha De Compra",150) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Nºde Remito",100) );
			if ( fl.Contains( "NumeroFactura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "NumeroFactura", "Nº de Factura",100) );
			if ( fl.Contains( "IdProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedor", "IdProveedor",true) );
			if ( fl.Contains( "Proveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Proveedor", "Proveedor",150) );
			if ( fl.Contains( "SimboloTotalMonedaOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloTotalMonedaOrigen", "Mon." ,30) );
			if ( fl.Contains( "TotalCotizacionProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TotalCotizacionProveedor", "Total Prov",75) );
			if ( fl.Contains( "SimboloTotalMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloTotalMonedaCierre", "Mon." ,30) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "total", "Total Pesos",75) );
			if ( fl.Contains( "ValorCotizacionProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorCotizacionProveedor", "Cot." ,50) );
			if ( fl.Contains( "IdmonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaCierre", "idmonedaCierre",true) );
			if ( fl.Contains( "moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "moneda", "Moneda",true) );
			if ( fl.Contains( "idresponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IDResponsable", "idresponsable",true) );
			if ( fl.Contains( "responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable",true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true) );
			if ( fl.Contains( "TextoHTML" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TextoHTML", "textoHTML", true) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();	
		}
	}
}

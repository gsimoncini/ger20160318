using System;
using System.Text;
using System.Collections;
using System.Reflection;
using mz.erp.businessrules;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;

namespace mz.erp.ui.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoDeComprasPorArt.
	/// </summary>
	public class rep_ListadoDeComprasPorArt
	{
		public rep_ListadoDeComprasPorArt()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta , string Producto, string IdProveedor, string Numero, string Aux1)
		{			
			/*Por ahora harcodeado. Los tipos de comprobantes de los cuales sale el listado de compras por articulos se deberia obtener de una 
			 * Variable de Sistema o, cuando se pase a workflow, de la informacion del proceos al q pertenzca esta tarea.
			 * */
			return mz.erp.businessrules.reportes.rep_ListadoDeComprasPorArt.GetList( FechaDesde, FechaHasta, Producto, IdProveedor, Numero, Aux1 ,Security.IdEmpresa, Security.IdSucursal);
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

			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código",50) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción",300) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.",30,Types.Aligment.Far, Types.FormatDisplay.Default) );
			if ( fl.Contains( "PROVEEDOR" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Proveedor", "Proveedor",200) );
			if ( fl.Contains( "FECHA" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",100) );
			if ( fl.Contains( "NUMERO" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Nº Remito",100) );
			if ( fl.Contains( "NumeroFactura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "NumeroFactura", "Nº Factura",100) );
			if ( fl.Contains( "SimboloPrecioDeCostoMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloPrecioDeCostoMonedaCierre", "Mon." ,30) );
			if ( fl.Contains( "PrecioDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCosto", "P. Costo" ,75) );
			if ( fl.Contains( "SimboloPrecioDeCostoMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloPrecioDeCostoMonedaOrigen", "Mon." ,30) );
			if ( fl.Contains( "PrecioDeCostoCotizacionProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoCotizacionProveedor", "P. Costo Prov." ,75) );
			//if ( fl.Contains( "PrecioDeCostoCotizacionReferencia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoCotizacionReferencia", "Precio Dolares" ,false) );
			if ( fl.Contains( "idComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "idcomprobante", "Comprobante",true) );
			if ( fl.Contains( "ValorCotizacionProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorCotizacionProveedor", "Cot." ,50) );
			
			if ( fl.Contains( "IDPROVEEDOR" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "idproveedor", "idproveedor",true) );
			
			if ( fl.Contains( "TOTAL" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",true) );
			if ( fl.Contains( "IDMONEDACIERRE" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Idmonedacierre", "IdMonedacierre",true) );
			if ( fl.Contains( "MONEDA" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true) );
			if ( fl.Contains( "IDRESPONSABLE" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "idResponsable",true) );
			if ( fl.Contains( "RESPONSABLE" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable",false) );
			if ( fl.Contains( "Ordinal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ordinal", "Ordinal",true) );
			
			
			if ( fl.Contains( "CodigoSecundario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoSecundario", "Cod. Secundario",false) );
			
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "ImpuestosDirectos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ImpuestosDirectos", "Impuestos Directos",true) );
			if ( fl.Contains( "ImpuestosIndirectos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ImpuestosIndirectos", "Impuestos Indirectos",true) );
			if ( fl.Contains( "IdMonedaOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaOrigen", "IdMonedaOrigen",true) );
			if ( fl.Contains( "IdMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaCierre", "IdMonedaCierre",true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();	
		}


	}
}

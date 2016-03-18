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
	/// Descripción breve de rep_ListadoDeVentasPorProducto.
	/// </summary>
	public class rep_ListadoDeVentasPorProducto
	{
		public rep_ListadoDeVentasPorProducto()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	

		[ atMethodReportRefreshData ]
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta)
		{			
			return mz.erp.businessrules.reportes.rep_ListadoDeVentasPorProducto.GetList(FechaDesde, FechaHasta, Security.IdEmpresa, Security.IdSucursal);
		}

		/*
		public static System.Data.DataSet GetList( DateTime FechaDesde, DateTime FechaHasta, string Jerarquia)
		{			
			return mz.erp.businessrules.reportes.rep_ListadoDeIngreso.GetList(FechaDesde, FechaHasta, Jerarquia, Security.IdEmpresa, Security.IdSucursal);
		}
		*/

		
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

			if ( fl.Contains( "IDPRODUCTO" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++,  "IDPRODUCTO", "IDPRODUCTO",true) );
			if ( fl.Contains( "CODIGO" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CODIGO", "Código",false) );
			if ( fl.Contains( "DESCRIPCION" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DESCRIPCION", "Descripción",true) );
			if ( fl.Contains( "DESCRIPCIONCORTA" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DESCRIPCIONCORTA", "Descripción",true) );
			if ( fl.Contains( "DESCRIPCIONLARGA" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DESCRIPCIONLARGA", "Descripción",false) );
			if ( fl.Contains( "CANTIDAD" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CANTIDAD", "Cantidad",false) );
			if ( fl.Contains( "PRECIOFINAL" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PRECIOFINAL", "Precio Final",false) );
			if ( fl.Contains( "PrecioFinalSinCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalSinCotizacion", "Precio Final",true) );
			if ( fl.Contains( "PRECIOBRUTO" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PRECIOBRUTO", "Precio Bruto",false) );
			if ( fl.Contains( "PrecioBrutoSinCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioBrutoSinCotizacion", "Precio Bruto",true) );
			if ( fl.Contains( "PRECIONETO" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PRECIONETO", "Precio Neto",false) );
			if ( fl.Contains( "PrecioNetoSinCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioNetoSinCotizacion", "Precio Neto",true) );
			if ( fl.Contains( "PRECIODECOSTO" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PRECIODECOSTO", "Precio de costo",false) );
			if ( fl.Contains( "PrecioDeCostoSinCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoSinCotizacion", "Precio de costo",true) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();	
		}
	}
}

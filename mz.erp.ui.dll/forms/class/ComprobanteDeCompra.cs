using System;
using System.Data;
using System.Text;
using System.Collections;
    
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.ui.controls;
using mz.erp.ui.controllers;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms.classes
{
	/// <summary>
	/// Descripción breve de ComprobanteDeCompra.
	/// </summary>
	public class ComprobanteDeCompra
	{
		public ComprobanteDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static string GetLayoutDetallePedidoProductos( string[] _fieldList )
		{
			
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo", 70 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250 ) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.", 50 ) );
			if ( fl.Contains( "DescripcionLarga") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "DescripcionLarga","Descripcion Detallada",200,5 ));
			if ( fl.Contains( "PrecioDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCosto", "P.de Costo", 60,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "P.de Lista", 60,Types.Aligment.Far, Types.FormatDispaly.Money ) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public static string GetLayoutRelacionOrigenDestino( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;

			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "Tipo", 30 ) );
			if ( fl.Contains( "Numero") || _fieldList == null) sb.Append( LayoutBuilder.GetRow( i++, "Numero","Numero",150));
			if ( fl.Contains( "OrdinalOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OrdinalOrigen", "Ord", 20, true) );
			if ( fl.Contains( "CantidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadOrigen", "Pendiente", 60 ) );
			if ( fl.Contains( "CantidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadDestino", "Cantidad", 60 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 300 ) );
			if ( fl.Contains( "PrecioDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCosto", "Precio De Costo", 100,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
	}
}

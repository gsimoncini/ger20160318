namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.businessrules;
	/// <summary>
	/// Descripción breve de ComprobantesDeCompra.
	/// </summary>
	public class ComprobantesDeCompra : IDisposable
	{
		public ComprobantesDeCompra()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static string GetLayoutDetalle( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if (_fieldList != null )
			{
				fl.AddRange( _fieldList );
			}
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Selected" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Selected", " ", 50, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo", 75 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "DescripcionDetallada") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "DescripcionDetallada","Descripcion Detallada",200,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 500 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "DescripcionLarga") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "DescripcionLarga","Descripcion Detallada",400,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.", 50 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Precio L.", 50,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );
			if ( fl.Contains( "BonificacionPorcentual" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "BonificacionPorcentual", "Desc", 75,Types.Aligment.Far, Types.FormatDisplay.Percent,Types.EditType.NoEdit ) );
			if ( fl.Contains( "Precio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Precio", "Precio", 50,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );
			if ( fl.Contains( "SubTotalConImpuestosDirectos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubTotalImpuestosDirectos", "Subtotal c/Imp.D",75 ,Types.Aligment.Far, Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "PrecioConImpuestos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioConImpuestos", "P.c/Imp.Totales",75,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );	
			if ( fl.Contains( "SubTotalConImpuestos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubTotalConImpuestos", "Subtotal",75 ,Types.Aligment.Far, Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "SubTotalNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubTotalNeto", "Subt.Neto", 70 ,Types.Aligment.Far, Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "CampoAuxiliar1") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar1",Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta"),60,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "CampoAuxiliar2") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar2",Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta"),60,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "CampoAuxiliar3") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar3",Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta"),60,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "CampoAuxiliar4") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar4",Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta"),60,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "CampoAuxiliar5") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar5",Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta"),60,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "PrecioDeCostoMonedaProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCostoMonedaProveedor", "Precio", 75,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );
			if ( fl.Contains( "StockDisponible") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "StockDisponible","Stock",60,5 ,Types.EditType.NoEdit));
			
			
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
			/*
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "Tipo", 30, Types.EditType.NoEdit) );
			if ( fl.Contains( "Numero") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "Numero","Número",100, 5,Types.EditType.NoEdit));
			if ( fl.Contains( "Codigo") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "Codigo","Codigo",100, 5,Types.EditType.NoEdit));
			if ( fl.Contains( "OrdinalOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OrdinalOrigen", "OrdinalOrigen", 40, true) );
			if ( fl.Contains( "CantidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadOrigen", "Pendiente", 60, Types.EditType.NoEdit ) );
			if ( fl.Contains( "CantidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadDestino", "Cantidad", 60 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "Descripcion", "Descripción", 450, 5,Types.EditType.NoEdit ) );
			if ( fl.Contains( "Precio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Precio", "Precio", 60, Types.EditType.NoEdit) );
			if ( fl.Contains( "Visible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Visible", "Visible", true) );
			*/
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "Tipo", 30, Types.EditType.NoEdit) );
			if ( fl.Contains( "Numero") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "Numero","Número",100,5, Types.EditType.NoEdit));
			if ( fl.Contains( "OrdinalOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OrdinalOrigen", "OrdinalOrigen", 40, true) );
			if ( fl.Contains( "CantidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadOrigen", "Cant. Origen", 60, Types.EditType.NoEdit ) );
			if ( fl.Contains( "CantidadPendiente" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadPendiente", "Pendiente", 60, Types.EditType.NoEdit ) );
			if ( fl.Contains( "CantidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadDestino", "Cantidad", 60 ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código", 50, Types.EditType.NoEdit ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 450, Types.EditType.NoEdit ) );
			if ( fl.Contains( "Precio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Precio", "Precio", 60, Types.EditType.NoEdit) );
			if ( fl.Contains( "Visible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Visible", "Visible", true) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		public void Dispose() 
		{
		}
	}
}

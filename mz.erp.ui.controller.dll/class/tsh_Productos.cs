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

	public class tsh_Productos : IDisposable, IGridDocument
	{
	
		#region Custom Members
		public string GetLayoutBuscadorJerarquicoProductos()
		{
			/*
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			string etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			string etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			string etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			string etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			string etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
			
			bool HideCampoAux1 = etiquetaCampoAuxiliar1.Trim() == "" ? true : false;
			bool HideCampoAux2 = etiquetaCampoAuxiliar2.Trim() == "" ? true : false;
			bool HideCampoAux3 = etiquetaCampoAuxiliar3.Trim() == "" ? true : false;
			bool HideCampoAux4 = etiquetaCampoAuxiliar4.Trim() == "" ? true : false;
			bool HideCampoAux5 = etiquetaCampoAuxiliar5.Trim() == "" ? true : false;			

			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Tipo de Producto",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",50) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",300) );			
			//if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70, Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );


			//if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			
			//if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			//if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			if ( fl.Contains( "SimboloMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaOrigenPrecioDeVentaBruto", "Moneda",40) );
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );
			
			if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock", 65,Types.Aligment.Far,Types.FormatDisplay.Integer ));
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripcion Corta",true ) );
			if ( fl.Contains( "DescripcionLarga" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripcion Larga", true ) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", etiquetaCampoAuxiliar1,65, HideCampoAux1) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", etiquetaCampoAuxiliar2,65, HideCampoAux2) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", etiquetaCampoAuxiliar3,65, HideCampoAux3) );
			if ( fl.Contains( "CampoAuxiliar4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", etiquetaCampoAuxiliar4,65, HideCampoAux4) );
			if ( fl.Contains( "CampoAuxiliar5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", etiquetaCampoAuxiliar5,65, HideCampoAux5) );
			if ( fl.Contains( "StockMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMinimo", "StockMinimo",65, true) );
			if ( fl.Contains( "StockAntesMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockAntesMinimo", "StockAntesMinimo",65, true) );
			
			

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
			*/
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			bool wordwrap = Variables.GetValueBool("Productos.Busquedas.GrillaResultado.WordWrapDescripcionProducto");
			int  cantLineas = Convert.ToInt32(Variables.GetValueLong("Productos.Busquedas.GrillaResultado.WordWrapDescripcionProducto.CantidadLineas"));
			
			string etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			string etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			string etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			string etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			string etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
			
			bool HideCampoAux1 = etiquetaCampoAuxiliar1.Trim() == "" ? true : false;
			bool HideCampoAux2 = etiquetaCampoAuxiliar2.Trim() == "" ? true : false;
			bool HideCampoAux3 = etiquetaCampoAuxiliar3.Trim() == "" ? true : false;
			bool HideCampoAux4 = etiquetaCampoAuxiliar4.Trim() == "" ? true : false;
			bool HideCampoAux5 = etiquetaCampoAuxiliar5.Trim() == "" ? true : false;			

			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Tipo de Producto",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",50) );
			if(wordwrap)
				if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRowWordWrap(i++, "Descripcion", "Descripcion",430, cantLineas) );			
				else
					if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",430) );			
			
			if ( fl.Contains( "PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta", "Pcio bruto", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70, Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );


			if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			if ( fl.Contains( "PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			if ( fl.Contains( "SimboloMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaOrigenPrecioDeVentaBruto", "Moneda",40) );
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );
			
			if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock", 65,Types.Aligment.Far,Types.FormatDisplay.Integer ));
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripcion Corta",true ) );
			if ( fl.Contains( "DescripcionLarga" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripcion Larga", true ) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", etiquetaCampoAuxiliar1,65, HideCampoAux1) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", etiquetaCampoAuxiliar2,65, HideCampoAux2) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", etiquetaCampoAuxiliar3,65, HideCampoAux3) );
			if ( fl.Contains( "CampoAuxiliar4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", etiquetaCampoAuxiliar4,65, HideCampoAux4) );
			if ( fl.Contains( "CampoAuxiliar5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", etiquetaCampoAuxiliar5,65, HideCampoAux5) );
			if ( fl.Contains( "StockMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMinimo", "StockMinimo",65, true) );
			if ( fl.Contains( "StockAntesMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockAntesMinimo", "StockAntesMinimo",65, true) );
			
			

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}


		public string GetLayoutBuscadorProductos()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			bool wordwrap = Variables.GetValueBool("Productos.Busquedas.GrillaResultado.WordWrapDescripcionProducto");
			int  cantLineas = Convert.ToInt32(Variables.GetValueLong("Productos.Busquedas.GrillaResultado.WordWrapDescripcionProducto.CantidadLineas"));
			
			string etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			string etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			string etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			string etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			string etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
			
			bool HideCampoAux1 = etiquetaCampoAuxiliar1.Trim() == "" ? true : false;
			bool HideCampoAux2 = etiquetaCampoAuxiliar2.Trim() == "" ? true : false;
			bool HideCampoAux3 = etiquetaCampoAuxiliar3.Trim() == "" ? true : false;
			bool HideCampoAux4 = etiquetaCampoAuxiliar4.Trim() == "" ? true : false;
			bool HideCampoAux5 = etiquetaCampoAuxiliar5.Trim() == "" ? true : false;			

			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Tipo de Producto",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",50) );
			if(wordwrap)
				if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRowWordWrap(i++, "Descripcion", "Descripcion",430, cantLineas) );			
			else
				if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",430) );			
			
			if ( fl.Contains( "PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBrutoMonedaOrigenRecargoCondicionDeVenta", "Pcio bruto", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70, Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );


			if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			if ( fl.Contains( "PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaOrigenRecargoCondicionDeVenta", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			//if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			if ( fl.Contains( "SimboloMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaOrigenPrecioDeVentaBruto", "Moneda",40) );
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );
			
			if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock", 65,Types.Aligment.Far,Types.FormatDisplay.Integer ));
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripcion Corta",true ) );
			if ( fl.Contains( "DescripcionLarga" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripcion Larga", true ) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", etiquetaCampoAuxiliar1,65, HideCampoAux1) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", etiquetaCampoAuxiliar2,65, HideCampoAux2) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", etiquetaCampoAuxiliar3,65, HideCampoAux3) );
			if ( fl.Contains( "CampoAuxiliar4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", etiquetaCampoAuxiliar4,65, HideCampoAux4) );
			if ( fl.Contains( "CampoAuxiliar5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", etiquetaCampoAuxiliar5,65, HideCampoAux5) );
			if ( fl.Contains( "StockMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMinimo", "StockMinimo",65, true) );
			if ( fl.Contains( "StockAntesMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockAntesMinimo", "StockAntesMinimo",65, true) );
			
			

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		#endregion

		public tsh_Productos()
		{
		}

		public tsh_Productos( string[] fieldList )
		{
			_fieldList = fieldList;
		}

		[ atMethodLayoutData ]
		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			string etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
			string etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
			string etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
			string etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
			string etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
			
			bool HideCampoAux1 = etiquetaCampoAuxiliar1.Trim() == "" ? true : false;
			bool HideCampoAux2 = etiquetaCampoAuxiliar2.Trim() == "" ? true : false;
			bool HideCampoAux3 = etiquetaCampoAuxiliar3.Trim() == "" ? true : false;
			bool HideCampoAux4 = etiquetaCampoAuxiliar4.Trim() == "" ? true : false;
			bool HideCampoAux5 = etiquetaCampoAuxiliar5.Trim() == "" ? true : false;			

			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true) );
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Tipo de Producto",true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",50) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",300) );			
			//if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "Pcio bruto", 70, Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );


			//if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioDeVentaBrutoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			
			//if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioFinalEstimado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimado", "Pcio Imp", 70,Types.Aligment.Far ) );
			
			if ( fl.Contains( "DescripcionMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );

			//if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "PrecioFinalEstimadoMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioFinalEstimadoMonedaDestino", "Pcio Imp", 70,Types.Aligment.Far ) );
			if ( fl.Contains( "SimboloMonedaOrigenPrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SimboloMonedaOrigenPrecioDeVentaBruto", "Moneda",40) );
			if ( fl.Contains( "DescripcionMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMonedaOrigenPrecioDeVentaBruto", "Moneda",65) );
			
			if ( fl.Contains( "StockDisponible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockDisponible", "Stock", 65,Types.Aligment.Far,Types.FormatDisplay.Integer ));
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Descripcion Corta",true ) );
			if ( fl.Contains( "DescripcionLarga" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionLarga", "Descripcion Larga", true ) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", etiquetaCampoAuxiliar1,65, HideCampoAux1) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", etiquetaCampoAuxiliar2,65, HideCampoAux2) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", etiquetaCampoAuxiliar3,65, HideCampoAux3) );
			if ( fl.Contains( "CampoAuxiliar4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", etiquetaCampoAuxiliar4,65, HideCampoAux4) );
			if ( fl.Contains( "CampoAuxiliar5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", etiquetaCampoAuxiliar5,65, HideCampoAux5) );
			if ( fl.Contains( "StockMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockMinimo", "StockMinimo",65, true) );
			if ( fl.Contains( "StockAntesMinimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "StockAntesMinimo", "StockAntesMinimo",65, true) );
			
			

			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_Productos.GetList().tsh_Productos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_Productos.Update( ( tsh_ProductosDataset.tsh_ProductosDataTable )dataTable );
		}
		
		private string[] _fieldList;
		public string[] FieldList
		{
			get
			{
				return _fieldList;
			}
			set
			{
				_fieldList = value;
			}
		}

		[ SearchMember( "tsh_Productos" , Caption ="Productos") ]
		public static DataSet GetList( 
			[ SearchParameterInfo( "Descripcion", IsDescription = true) ] string Descripcion,
			[ SearchParameterInfo( "Codigo Secundario", CaptionVariable = "Productos.CodigoSecundario.Etiqueta") ] string CodigoSecundario, 
			[ SearchParameterInfo( "Codigo", IsAlternativePrimaryKey = true) ] string Codigo, 
			[ SearchParameterInfo( "Tipo de Producto") ] string IdTipoProducto,
			[ SearchParameterInfo( "Stock", IsSearch = false, Metodo = "GetCadenaStocks") ] string Stock,
			[ SearchParameterInfo( "Campos auxiliares", IsSearch = false, Metodo = "GetCamposAuxiliares") ] string CamposAuxiliares
			)
		{
			tsh_ProductosDataset data;
		
			//if(Variables.GetValueBool("Productos.Busquedas.BusquedaParcial"))
				data = mz.erp.businessrules.tsh_Productos.GetList( IdTipoProducto, Codigo, CodigoSecundario, null, Descripcion, null, null );
			//else
			//	data = mz.erp.businessrules.tsh_Productos.GetListEx( IdTipoProducto, Codigo, CodigoSecundario, Descripcion, null, null );			
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}

		[HierarchicalSearchMember(typeof (mz.erp.ui.controllers.tsh_JerarquiaAgrupProd))]
		public static DataTable HierarchicalSearch(string jerarquia)	
		{
			System.Data.DataTable tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(jerarquia, Security.IdSucursal, Security.IdEmpresa);
			return tabla;
		}
		/*public static DataTable HierarchicalSearch(string jerarquia, bool activo)	
		{
			System.Data.DataTable tabla = mz.erp.businessrules.tsh_ProductosEx.SearchProductByJerarquia(jerarquia, Security.IdSucursal, Security.IdEmpresa, activo);
			return tabla;
		}*/

		public static string GetCadenaStocks(string codigo) 
		{			
			string IdProducto = businessrules.tsh_Productos.GetPkByCodigo(codigo);
			string IdVisualizacionDeStock = Variables.GetValue("Stock.VisualizacionDeStock.Default").ToString();
			string IdEstadoDeStock = Variables.GetValue("Stock.EstadoDeStock.Default").ToString();				

			DataSet data = businessrules.Productos.GetStockSucursal(IdProducto, IdVisualizacionDeStock, IdEstadoDeStock);
			
			try 
			{
				string cadena = "";
				for (int i = 0; i < data.Tables[0].Rows.Count; i++) 
				{
					string sucursal = data.Tables[0].Rows[i]["Sucursal"].ToString();
					decimal DecStock = Convert.ToDecimal(data.Tables[0].Rows[i]["Cantidad"]);
					string stock = decimal.Round(DecStock,0).ToString();
					cadena = cadena + sucursal + ": " + stock + " ; ";
				}							
				return cadena;
			}
			catch (Exception e) 
			{
				return "";
			}			
		}		

		public static string GetCamposAuxiliares(string codigo) 
		{			
			string IdProducto = businessrules.tsh_Productos.GetPkByCodigo(codigo);
			Productos pro = new Productos(IdProducto);
			/*pro.NombreCampoAuxiliar1 = Variables.GetValue("Productos.CampoAuxiliar1.Etiqueta").ToString();
			pro.NombreCampoAuxiliar2 = Variables.GetValue("Productos.CampoAuxiliar2.Etiqueta").ToString();
			pro.NombreCampoAuxiliar3 = Variables.GetValue("Productos.CampoAuxiliar3.Etiqueta").ToString();
			pro.NombreCampoAuxiliar4 = Variables.GetValue("Productos.CampoAuxiliar4.Etiqueta").ToString();
			pro.NombreCampoAuxiliar5 = Variables.GetValue("Productos.CampoAuxiliar5.Etiqueta").ToString();*/
			
			string cadena = "";
			if (pro.CampoAuxiliar1.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar1 + ": " + pro.CampoAuxiliar1 + " ; ";}
			if (pro.CampoAuxiliar2.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar2 + ": " + pro.CampoAuxiliar2 + " ; ";}
			if (pro.CampoAuxiliar3.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar3 + ": " + pro.CampoAuxiliar3 + " ; ";}
			if (pro.CampoAuxiliar4.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar4 + ": " + pro.CampoAuxiliar4 + " ; ";}
			if (pro.CampoAuxiliar5.Trim() != "") 
			{cadena = cadena + pro.NombreCampoAuxiliar5 + ": " + pro.CampoAuxiliar5 + " ; ";}
			
			return cadena;
		}
	
		[ atAllowMultipleRows ]
		public static bool AllowMultipleSelect
		{
			get { return (true); }
		}
		[ atHierarchicalSearch ]
		public static bool AllowBusquedaJerarquica
		{
			get 
			{
				return Variables.GetValueBool("Productos.Comprobantes.BusquedaJerarquica"); 
			}
		}
		
		[ atOrderBy ]
		public static string DefaultOrderBy
		{
			get
			{
				return Variables.GetValueString("Productos.Busquedas.OrderBy");
			}
		}

		[ atFastSearch ]
		public static bool AllowFastSearch
		{
			get
			{
				return Variables.GetValueBool("Productos.Busquedas.FastSearch");
			}
		}


        //Matias 20100716 - Tarea 85
        [atOrdenarPor]
        public static string OrdenarPor
        {
            get
            {
                return Variables.GetValueString("Productos.Busquedas.OrdenarPor");
            }
        }
        //Fin Matias 20100716 - Tarea 85
			
	
	}
}


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
	

	public class ComprobantesDeVenta : IDisposable
	{
		public ComprobantesDeVenta()
		{
		}
		public static string GetLayoutVariables()
		{
			return GetLayoutVariables( null );
		}
		public static string GetLayoutVariables( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if (_fieldList != null )
			{
				fl.AddRange( _fieldList );
			}
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Id" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Id", "Id", true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",100  ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "Valor", "Valor",400,20 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		public static string GetLayoutDetalleCondicionDeVenta( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCuota" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuota", "Cuota",60 ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Vence", 150 ) );
			if ( fl.Contains( "Monto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Monto", "Monto",120 ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public static string GetLayoutResumenImpuestos( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Impuesto",200 ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor",70, Types.Aligment.Near, Types.FormatDisplay.Percent ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public static string GetLayoutImpuestos( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );

			Types.Aligment ali;
			
			if ( fl.Contains( "DescripcionCorta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionCorta", "Impuesto",170 ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor", 80, Types.Aligment.Far, Types.FormatDisplay.Money ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public static string GetLayoutDetalleProductos( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}


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

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo", 50 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "DescripcionDetallada") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "DescripcionDetallada","Descripcion Detallada",200,4 ,Types.EditType.NoEdit));
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 200 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "DescripcionLarga") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "DescripcionLarga","Descripcion Detallada",400,4 ,Types.EditType.NoEdit));
			//if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.", 50 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cant.", true) );
			//if ( fl.Contains( "UnidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadDestino", "U Destino", 70,Types.EditType.NoEdit ) );
			if ( fl.Contains( "UnidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadDestino", "U Destino",true) );
			if ( fl.Contains( "CantidadUnidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadUnidadOrigen", "Cant", 30 ) );
			//if ( fl.Contains( "UnidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadOrigen", "U Origen", 70 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "UnidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadOrigen", "U Origen", 70 ,true) );
			
			
			if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "P. Lista", 50,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );
			if ( fl.Contains( "Precio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Precio", "Precio", 50,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );			
			if ( fl.Contains( "SubTotalConImpuestosDirectos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubTotalImpuestosDirectos", "Subtotal c/Imp.D",75 ,Types.Aligment.Far, Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "PrecioConImpuestosDirectos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioConImpuestosDirectos", "P.c/Imp. Directos",75,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );	
			if ( fl.Contains( "PrecioConImpuestos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioConImpuestos", "P.c/Imp.Totales",75,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );
			if ( fl.Contains( "SubTotalConImpuestos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubTotalConImpuestos", "Subtotal",75 ,Types.Aligment.Far, Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "SubTotalNeto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SubTotalNeto", "Subt.Neto", 70 ,Types.Aligment.Far, Types.FormatDisplay.Money,Types.EditType.NoEdit) );
			if ( fl.Contains( "BonificacionPorcentual" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "BonificacionPorcentual", "% Desc", 50,Types.Aligment.Far, Types.FormatDisplay.Default,Types.EditType.NoEdit) );			

			if (!HideCampoAux1)
				if ( fl.Contains( "CampoAuxiliar1") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar1",etiquetaCampoAuxiliar1,60,5 ,Types.EditType.NoEdit));
			if (!HideCampoAux2)
				if ( fl.Contains( "CampoAuxiliar2") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar2",etiquetaCampoAuxiliar2,60,5 ,Types.EditType.NoEdit));
			if (!HideCampoAux3)
				if ( fl.Contains( "CampoAuxiliar3") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar3",etiquetaCampoAuxiliar3,60,5 ,Types.EditType.NoEdit));
			if (!HideCampoAux4)
				if ( fl.Contains( "CampoAuxiliar4") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar4",etiquetaCampoAuxiliar4,60,5 ,Types.EditType.NoEdit));
			if (!HideCampoAux5)
				if ( fl.Contains( "CampoAuxiliar5") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "CampoAuxiliar5",etiquetaCampoAuxiliar5,60,5 ,Types.EditType.NoEdit));
			
			sb.Append( LayoutBuilder.GetRow( i++, "Visible", "Visible", true) );			
			sb.Append( LayoutBuilder.GetFooter() );
			

			return sb.ToString();

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
			//if ( fl.Contains( "PrecioDeVentaBruto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeVentaBruto", "P.de Lista", 60,Types.Aligment.Far, Types.FormatDisplay.Money ) );
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

			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "Tipo", 30, Types.EditType.NoEdit) );
			if ( fl.Contains( "Numero") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "Numero","Número",100,5, Types.EditType.NoEdit));
			if ( fl.Contains( "OrdinalOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OrdinalOrigen", "OrdinalOrigen", 40, true) );
			if ( fl.Contains( "CantidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadOrigen", "Cant. Origen", 60, Types.EditType.NoEdit ) );
			if ( fl.Contains( "CantidadPendiente" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadPendiente", "Pendiente", 60, Types.EditType.NoEdit ) );
			if ( fl.Contains( "CantidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CantidadDestino", "Cantidad", 60 ) );
			if ( fl.Contains( "CodigoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoProducto", "Código", 50, Types.EditType.NoEdit ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 450, Types.EditType.NoEdit ) );
			if ( fl.Contains( "Precio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Precio", "Precio", 60, Types.EditType.NoEdit) );
			if ( fl.Contains( "Visible" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Visible", "Visible", true) );
			// ---- Matias - Tarea 204 - 20090722
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", "Campo Auxiliar1", 110, Types.EditType.NoEdit) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", "Campo Auxiliar2", 110, Types.EditType.NoEdit) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", "Campo Auxiliar3", 110, Types.EditType.NoEdit) );
			if ( fl.Contains( "CampoAuxiliar4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", "Campo Auxiliar4", 110, Types.EditType.NoEdit) );
			if ( fl.Contains( "CampoAuxiliar5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", "Campo Auxiliar5", 110, Types.EditType.NoEdit) );
			if ( fl.Contains( "CampoAuxiliar6" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar6", "Campo Auxiliar6", 110, Types.EditType.NoEdit) );

			if ( fl.Contains( "CodigoProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CodigoProveedor", "Código Proveedor", 100, Types.EditType.NoEdit ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", 100, Types.EditType.NoEdit ) );
			if ( fl.Contains( "FechaUltimaModificacionPrecioCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaUltimaModificacionPrecioCosto", "F.Ult.Modif.Precio Costo", 140, Types.EditType.NoEdit) );
			if ( fl.Contains( "FechaUltimaModificacionPrecioVenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaUltimaModificacionPrecioVenta", "F.Ult.Modif.Precio Venta", 140, Types.EditType.NoEdit) );
			// ---- FinMatias
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		
		public void Dispose()
		{
		}
		

				

		
	}
}



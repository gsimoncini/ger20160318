using System;
using System.Text;
using System.Collections;
using mz.erp.businessrules;

namespace mz.erp.ui.controllers
{
	/// <summary>
	/// Descripción breve de SeleccionarEstadoItems.
	/// </summary>
	public class SeleccionarEstadoItems: IDisposable
	{
		public SeleccionarEstadoItems()
		{
		}


		public static string GetLayoutProductos( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto", 50 ,true) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código", 50 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 200 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "DescripcionLarga") || _fieldList == null) sb.Append( LayoutBuilder.GetRowWordWrap( i++, "DescripcionLarga","Descripción Detallada",200,5 ,Types.EditType.NoEdit));
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad", 60 ,Types.EditType.NoEdit) );
			if ( fl.Contains( "FechaDeEntrega" ) || _fieldList == null )  sb.Append( LayoutBuilder.GetRow( i++, "FechaDeEntrega", "Fecha De Entrega", 100 , Types.Aligment.Center ,Types.FormatDisplay.DateTime, Types.EditType.CalendarCombo ) );
			if ( fl.Contains( "IdEstado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRowCombo( i++, "IdEstado", "Forma De Entrega", 100 , true) );
			
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

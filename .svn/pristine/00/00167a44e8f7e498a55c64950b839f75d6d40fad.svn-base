namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;
	using mz.erp.ui.controllers;

	public class Stock : IDisposable
	{
		public Stock()
		{
		}
		
		public static string GetLayoutStockSucursales( string[] _fieldList )
		{
			ArrayList fl = new ArrayList();
			if (_fieldList != null )
			{
				fl.AddRange( _fieldList );
			}
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );			
			
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Sucursal", 100 ) );
			if ( fl.Contains( "DescripcionDeposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionDeposito", "Depósito", 100 ) );
			if ( fl.Contains( "DescripcionSeccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionSeccion", "Sección", 100 ) );
			if ( fl.Contains( "Suma" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Suma", "Cantidad",60, Types.Aligment.Far, Types.FormatDisplay.Integer) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		public static string GetLayoutAjusteDeStock()
		{
			string[] _fieldList = new string[] {"Codigo","Descripcion","Cantidad"};

			ArrayList fl = new ArrayList();
			if (_fieldList != null )
			{
				fl.AddRange( _fieldList );
			}
			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Código", 100, Types.EditType.NoEdit) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 500, Types.EditType.NoEdit) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",60, Types.Aligment.Far, Types.FormatDisplay.Integer, Types.EditType.Custom) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}

		
		public void Dispose()
		{
		}
		
	}
}


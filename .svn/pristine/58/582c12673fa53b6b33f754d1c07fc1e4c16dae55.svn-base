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

	public class tfi_ValoresEx : IDisposable, IGridDocument
	{
		public tfi_ValoresEx()
		{
		}

		public tfi_ValoresEx( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
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
			
			if ( fl.Contains( "IdVariableAuxiliarTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariableAuxiliarTDCompTesoreria", "IdVariableAuxiliarTDCompTesoreria",true ) );
			if ( fl.Contains( "DescripcionComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionComprobante", "Comprobante",true ) );
			if ( fl.Contains( "DescripcionVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionVariable", "Descripcion Variable",250 ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor",250 ) );
						
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public string  GetLayoutValores()
		{


			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdValor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValor", "IdValor",true ) );
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "Comprobante",100 ) );
			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "Moneda",100) );
			if ( fl.Contains( "Monto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Monto", "Monto Moneda Origen",100,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "MontoCotizado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MontoCotizado", "Monto Cotizado" ,150,Types.Aligment.Far, Types.FormatDisplay.Money));
			
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante", true) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero",100 ) );
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "Entidad", 100 ) );
			if ( fl.Contains( "Entidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad",true) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",true) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",100 ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Fecha de Vencimiento",100 ) );
			
			if ( fl.Contains( "IdCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacion", "IdCotizacion",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}


		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_Valores.GetList().tfi_Valores;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_Valores.Update( ( tfi_ValoresDataset.tfi_ValoresDataTable )dataTable );
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

		[ SearchMember( "tfi_Valores" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdValor" ) ] string IdValor, 
			[ SearchParameterInfo( "IdTDCompTesoreria" ) ] string IdTDCompTesoreria, 
			[ SearchParameterInfo( "Numero" ) ] string Numero, 
			[ SearchParameterInfo( "IdEntidad" ) ] string IdEntidad, 
			[ SearchParameterInfo( "FechaVencimiento" ) ] DateTime FechaVencimiento, 
			[ SearchParameterInfo( "Valor" ) ] decimal Valor,
			[ SearchParameterInfo( "IdMoneda" ) ] string IdMoneda, 
			[ SearchParameterInfo( "IdCotizacionMoneda" ) ] string IdCotizacionMoneda
			)
		{
			tfi_ValoresExDataset data = mz.erp.businessrules.data.tfi_ValoresEx.GetList( IdValor, IdTDCompTesoreria, Numero, IdEntidad, /*System.DateTime.MinValue*/ FechaVencimiento, Valor , IdMoneda, IdCotizacionMoneda );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}



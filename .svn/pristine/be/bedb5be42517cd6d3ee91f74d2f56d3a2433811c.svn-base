namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

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

		public string GetLayoutVariablesAuxiliares()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdVariableAuxiliar" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariableAuxiliar", "IdVariableAuxiliar",true ) );
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria",true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion Variable",200 ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor",350 ) );
			if ( fl.Contains( "Tipo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Tipo", "Tipo",true ) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public string  GetLayoutValoresPagosCompras()
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
			
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria",true) );
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante",200,false) );
			if ( fl.Contains( "IdTipoDeRetencion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeRetencion", "Tipo Ret.",50,false) );

			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IDMoneda",true) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",100) );
			
			if ( fl.Contains( "Monto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Monto", "Monto",100,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "MontoCotizado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MontoCotizado", "Monto Cot." ,100,Types.Aligment.Far, Types.FormatDisplay.Money));
			if ( fl.Contains( "IdCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacion", "IdCotizacion",true ) );

			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",100 ) );
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "Entidad", 100, true ) );
			if ( fl.Contains( "Banco" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Banco", "Banco",100,false) );
			if ( fl.Contains( "CuentaBancaria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CuentaBancaria", "Cuenta Bancaria",100,false) );
			if ( fl.Contains( "Entidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad",false) );
			
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",100 ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Fecha de Acreditación",100 ) );
			
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
			
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria",true) );
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante",200,false) );

			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IDMoneda",true) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",100) );
			
			if ( fl.Contains( "Monto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Monto", "Monto",100,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "MontoCotizado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MontoCotizado", "Monto Cot." ,100,Types.Aligment.Far, Types.FormatDisplay.Money));
			if ( fl.Contains( "IdCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacion", "IdCotizacion",true ) );

			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número",100 ) );
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "Entidad", 100, true ) );
			if ( fl.Contains( "Banco" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Banco", "Banco",false) );
			if ( fl.Contains( "Entidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad",false) );
			
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",100 ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "Fecha de Acreditación",100 ) );
			
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



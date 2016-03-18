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

	public class tfi_CotizacionesMonedas : IDisposable, IGridDocument
	{
		public tfi_CotizacionesMonedas()
		{
		}

		public tfi_CotizacionesMonedas( string[] fieldList )
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
			
			if ( fl.Contains( "IdCotizacionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionMoneda", "IdCotizacionMoneda" ) );
			if ( fl.Contains( "IdMonedaOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaOrigen", "IdMonedaOrigen" ) );
			if ( fl.Contains( "IdMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaDestino", "IdMonedaDestino" ) );
			if ( fl.Contains( "FechaDeCambioInicio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaDeCambioInicio", "FechaDeCambioInicio" ) );
			if ( fl.Contains( "FechaDeCambioFin" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaDeCambioFin", "FechaDeCambioFin" ) );
			if ( fl.Contains( "IdFuenteDeCambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFuenteDeCambio", "IdFuenteDeCambio" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_CotizacionesMonedas.GetList().tfi_CotizacionesMonedas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_CotizacionesMonedas.Update( ( tfi_CotizacionesMonedasDataset.tfi_CotizacionesMonedasDataTable )dataTable );
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

		[ SearchMember( "tfi_CotizacionesMonedas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdCotizacionMoneda" ) ] string IdCotizacionMoneda, 
			[ SearchParameterInfo( "IdMonedaOrigen" ) ] string IdMonedaOrigen, 
			[ SearchParameterInfo( "IdMonedaDestino" ) ] string IdMonedaDestino, 
			[ SearchParameterInfo( "FechaDeCambioInicio" ) ] DateTime FechaDeCambioInicio, 
			[ SearchParameterInfo( "FechaDeCambioFin" ) ] DateTime FechaDeCambioFin, 
			[ SearchParameterInfo( "Valor" ) ] decimal Valor
			)
		{
			tfi_CotizacionesMonedasDataset data = mz.erp.businessrules.tfi_CotizacionesMonedas.GetList( IdCotizacionMoneda, IdMonedaOrigen, IdMonedaDestino, FechaDeCambioInicio, FechaDeCambioFin, Valor );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}

		public string  GetLayoutCotizaciones()
		{


			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdCotizacionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionMoneda", "IdCotizacionMoneda",true ) );
			if ( fl.Contains( "IdMonedaOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaOrigen", "IdMonedaOrigen", true ) );
			if ( fl.Contains( "Moneda Origen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda Origen", "Moneda Origen" ,100));
			if ( fl.Contains( "IdMonedaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaDestino", "IdMonedaDestino", true ) );
			if ( fl.Contains( "Moneda Destino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda Destino", "Moneda Destino" ,100));
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ,50,Types.Aligment.Far,Types.FormatDisplay.Money));
			
			if ( fl.Contains( "FechaDeCambioInicio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaDeCambioInicio", "Fecha De Cambio",100 ) );
			if ( fl.Contains( "IdFuenteDeCambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFuenteDeCambio", "IdFuenteDeCambio" ,true));
			if ( fl.Contains( "Funete De Cambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Funete De Cambio", "Fuente De Cambio" ) );
			



			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
	}
}


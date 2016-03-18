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

	public class tfi_Valores : IDisposable, IGridDocument
	{
		public tfi_Valores()
		{
		}

		public tfi_Valores( string[] fieldList )
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
			
			if ( fl.Contains( "IdValor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValor", "IdValor",true ) );
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria",true ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero",100 ) );
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "IdEntidad",true ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",100 ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "FechaVencimiento",150 ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor",50,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda",50) );
			if ( fl.Contains( "IdCotizacionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionMoneda", "IdCotizacionMoneda",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion", true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdCoexionUltimaModificacion" ,true) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			
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
			tfi_ValoresDataset data = mz.erp.businessrules.tfi_Valores.GetList( IdValor, IdTDCompTesoreria, Numero, IdEntidad, FechaVencimiento, Valor, IdMoneda, IdCotizacionMoneda ,string.Empty);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


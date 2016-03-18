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

	public class tsh_DetalleConversiones : IDisposable, IGridDocument
	{
		public tsh_DetalleConversiones()
		{
		}

		public tsh_DetalleConversiones( string[] fieldList )
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
			
			if ( fl.Contains( "IdConversion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConversion", "IdConversion" , true) );
			if ( fl.Contains( "IdUnidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUnidadOrigen", "Unidad Origen" ,100) );
			if ( fl.Contains( "IdUnidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUnidadDestino", "Unidad Destino" ,100) );
			if ( fl.Contains( "Ordinal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ordinal", "Ordinal", true ) );
			if ( fl.Contains( "ValorConversion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorConversion", "Valor", 50 ) );
			if ( fl.Contains( "FormulaConversion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FormulaConversion", "Formula",200 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion", true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion", true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" , true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion", true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" , true) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" , true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" , true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" , true) );
			if ( fl.Contains( "IsDefault" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IsDefault", "Default" ,50,Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}



		public string GetLayoutDetalle()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			
			if ( fl.Contains( "IdUnidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUnidadOrigen", "U Origen" ,true) );
			if ( fl.Contains( "IdUnidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdUnidadDestino", "U Destino" ,true) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Conversion" ,150) );
			if ( fl.Contains( "ValorSinConvertir" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorSinConvertir", "Valor a Convertir", 120) );
			if ( fl.Contains( "UnidadOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadOrigen", "U Origen" ,75) );
			if ( fl.Contains( "ValorConvertido" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorConvertido", "Valor Convertido", 120 ) );
			if ( fl.Contains( "UnidadDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UnidadDestino", "U Destino" ,75) );
			if ( fl.Contains( "Ordinal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ordinal", "Ordinal", true ) );
			if ( fl.Contains( "ValorConversion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorConversion", "Conversion", true ) );
			
			
			
			if ( fl.Contains( "Formula" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Formula", "Formula",true ) );

			
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_DetalleConversiones.GetList().tsh_DetalleConversiones;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_DetalleConversiones.Update( ( tsh_DetalleConversionesDataset.tsh_DetalleConversionesDataTable )dataTable );
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

		[ SearchMember( "tsh_DetalleConversiones" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdConversion" ) ] string IdConversion, 
			[ SearchParameterInfo( "IdUnidadOrigen" ) ] string IdUnidadOrigen, 
			[ SearchParameterInfo( "IdUnidadDestino" ) ] string IdUnidadDestino
			)
		{
			tsh_DetalleConversionesDataset data = mz.erp.businessrules.tsh_DetalleConversiones.GetList( IdConversion, IdUnidadOrigen, IdUnidadDestino );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}



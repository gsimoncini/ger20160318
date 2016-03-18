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
	using mz.erp.businessrules;
	using mz.erp.ui.controllers;

	public class tsa_BonificacionesEx : IDisposable, IGridDocument
	{
		public tsa_BonificacionesEx()
		{
		}

		public tsa_BonificacionesEx( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
		[ atMethodLayoutData ]
		public string GetLayoutBonif() 
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdBonificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdBonificacion", "Id" ,50, false) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción", 200, false ) );
			if ( fl.Contains( "IdTipoBonificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow(i++, "IdTipoBonificacion", "Tipo de bonificación" , 50, false) );			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
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
						
			if ( fl.Contains( "IdBonificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdBonificacion", "IdBonificacion" ,true) );			
			if ( fl.Contains( "Ordinal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Ordinal", "Ordinal",true ) );
			if ( fl.Contains( "Minimo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Minimo", "Minimo", false ) );
			if ( fl.Contains( "Maximo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Maximo", "Maximo", false ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor", false ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ,true) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ,true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ,true) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ,true) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return null;
		}
		
		public void Update( object dataTable )
		{
			//mz.erp.businessrules.tsa_BonificacionesEx.Update( ( tsa_BonificacionesDataset.tsa_BonificacionesDataTable )dataTable );
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

		[ SearchMember( "tsa_Bonificaciones" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "Id" , IsAlternativePrimaryKey = true ) ] string IdBonificacion, 
			[ SearchParameterInfo( "Descripción" , IsDescription = true )] string Descripcion, 
			[ SearchParameterInfo( "Tipo de bonificacion" ) ] string IdTipoBonificacion
			)
		{
			tsa_BonificacionesDataset data = mz.erp.businessrules.tsa_Bonificaciones.GetList( IdBonificacion, Descripcion, IdTipoBonificacion );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}



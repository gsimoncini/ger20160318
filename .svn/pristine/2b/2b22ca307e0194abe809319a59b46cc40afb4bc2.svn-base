namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tcs_Domicilios : IDisposable
	{
		public tcs_Domicilios()
		{
		}

		public tcs_Domicilios( string[] fieldList )
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
			if ( fl.Contains( "Checked" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Checked", "X" , 25, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			if ( fl.Contains( "TipoDomicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoDomicilio", "Tipo dom.",130 ) );
			if ( fl.Contains( "DomicilioTexto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DomicilioTexto", "Domicilio" , 300, Types.ColumnTypes.Text, Types.EditType.NoEdit ));
			if ( fl.Contains( "Calle" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Calle", "Calle" , 100 ));
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Número" , 70) );
			if ( fl.Contains( "Sector" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sector", "Sector", true ) );
			if ( fl.Contains( "Torre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Torre", "Torre", true ) );
			if ( fl.Contains( "Piso" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Piso", "Piso", true ) );
			if ( fl.Contains( "Departamento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Departamento", "Departamento" , true) );
			if ( fl.Contains( "Manzana" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Manzana", "Manzana", true ) );
			if ( fl.Contains( "IdDomicilio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDomicilio", "IdDomicilio", true ) );
		
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

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

		
		public void Dispose()
		{
		}
		
	}
}


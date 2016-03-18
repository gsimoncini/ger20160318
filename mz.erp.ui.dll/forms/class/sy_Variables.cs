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

	public class sy_Variables : IDisposable, IGridDocument
	{
		public sy_Variables()
		{
		}

		public sy_Variables( string[] fieldList )
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
			
			if ( fl.Contains( "IdVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariable", "IdVariable", 300) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 250) );
			if ( fl.Contains( "ValorDefault" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorDefault", "ValorDefault", 200) );
			if ( fl.Contains( "IdTipoVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoVariable", "IdTipoVariable", 100) );
			if ( fl.Contains( "Categoria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Categoria", "Categoria" ) );
			if ( fl.Contains( "Comentario" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentario", "Comentario" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		[ValueListGridMember]
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Variables.GetList().sy_Variables;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Variables.Update( ( sy_VariablesDataset.sy_VariablesDataTable )dataTable );
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

		[ SearchMember( "sy_Variables" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdVariable" ) ] string IdVariable
			)
		{
			sy_VariablesDataset data = mz.erp.businessrules.sy_Variables.GetList( IdVariable );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


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

	public class tlg_Zonas : IDisposable, IGridDocument
	{
		public tlg_Zonas()
		{
		}

		public tlg_Zonas( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		[ atMethodLayoutData ]
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
			
			if ( fl.Contains( "IdZona" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdZona", "IdZona" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción" ) );
			if ( fl.Contains( "Valor1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor1", "Valor 1" ) );
			if ( fl.Contains( "Valor2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor2", "Valor 2" ) );
			if ( fl.Contains( "Valor3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor3", "Valor 3" ) );
			if ( fl.Contains( "FormulaDeCalculo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FormulaDeCalculo", "Fórmula de Cálculo" ) );
			/*
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones" ) );
			*/
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tlg_Zonas.GetList().tlg_Zonas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tlg_Zonas.Update( ( tlg_ZonasDataset.tlg_ZonasDataTable )dataTable );
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

		[ SearchMember( "tlg_Zonas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdZona" ) ] string IdZona, 
[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
[ SearchParameterInfo( "Valor1" ) ] string Valor1, 
[ SearchParameterInfo( "Valor2" ) ] string Valor2, 
[ SearchParameterInfo( "Valor3" ) ] string Valor3
 )
		{
			tlg_ZonasDataset data = mz.erp.businessrules.tlg_Zonas.GetList( IdZona, Descripcion, Valor1, Valor2, Valor3 );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


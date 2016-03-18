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

	public class sy_Herramientas : IDisposable, IGridDocument
	{
		public sy_Herramientas()
		{
		}

		public sy_Herramientas( string[] fieldList )
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
			
			if ( fl.Contains( "IdHerramienta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHerramienta", "IdHerramienta" ) );
			if ( fl.Contains( "IdHerramientaPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdHerramientaPadre", "IdHerramientaPadre" ) );
			if ( fl.Contains( "Id" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Id", "Id" ) );
			if ( fl.Contains( "orden" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "orden", "orden" ) );
			if ( fl.Contains( "Habilitado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Habilitado", "Habilitado" ) );
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "Shortcut" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Shortcut", "Shortcut" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_Herramientas.GetList().sy_Herramientas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_Herramientas.Update( ( sy_HerramientasDataset.sy_HerramientasDataTable )dataTable );
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

		[ SearchMember( "sy_Herramientas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdHerramienta" ) ] long IdHerramienta, 
			[ SearchParameterInfo( "IdHerramientaPadre" ) ] long IdHerramientaPadre, 
			[ SearchParameterInfo( "Id" ) ] string Id, 
			[ SearchParameterInfo( "ShortCut" ) ] string ShortCut, 
			[ SearchParameterInfo( "orden" ) ] short orden, 
			[ SearchParameterInfo( "Habilitado" ) ] bool Habilitado
			)
		{
			sy_HerramientasDataset data = mz.erp.businessrules.sy_Herramientas.GetList( IdHerramienta, IdHerramientaPadre, Id, ShortCut, orden, Habilitado);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


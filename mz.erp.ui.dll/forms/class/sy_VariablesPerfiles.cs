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

	[ValueListGridAttributes("IdVariable",typeof(mz.erp.ui.forms.classes.sy_Variables),"IdVariable","IdVariable")] 
	[ValueListGridAttributes("IdPerfil",typeof(mz.erp.ui.forms.classes.sy_Perfiles),"IdPerfil","Descripcion")] 
	public class sy_VariablesPerfiles : IDisposable, IGridDocument
	{
	
		public sy_VariablesPerfiles()
		{
		}

		public sy_VariablesPerfiles( string[] fieldList )
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
			
			if ( fl.Contains( "IdVariable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdVariable", "Variable" ) );
			if ( fl.Contains( "IdPerfil" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPerfil", "Perfil" ) );
			if ( fl.Contains( "Valor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Valor", "Valor" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_VariablesPerfiles.GetList().sy_VariablesPerfiles;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_VariablesPerfiles.Update( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesDataTable )dataTable );
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

		[ SearchMember( "sy_VariablesPerfiles" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdVariable" ) ] string IdVariable, 
			[ SearchParameterInfo( "IdPerfil" ) ] long IdPerfil
			)
		{
			sy_VariablesPerfilesDataset data = mz.erp.businessrules.sy_VariablesPerfiles.GetList( IdVariable, IdPerfil );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}

		
	}
}


namespace mz.erp.ui
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;

	public class twf_Validaciones : IDisposable, IGridDocument
	{
		public twf_Validaciones()
		{
		}

		public twf_Validaciones( string[] fieldList )
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
			
			if ( fl.Contains( "IdValidacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValidacion", "IdValidacion" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Formula" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Formula", "Formula" ) );
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.twf_Validaciones.GetList().twf_Validaciones;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.twf_Validaciones.Update( ( twf_ValidacionesDataset.twf_ValidacionesDataTable )dataTable );
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

		[ SearchMember( "twf_Validaciones" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdValidacion" ) ] long IdValidacion, 
			[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
			[ SearchParameterInfo( "Formula" ) ] string Formula, 
			[ SearchParameterInfo( "IdConexion" ) ] long IdConexion, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "Observaciones" ) ] string Observaciones
			)
		{
			twf_ValidacionesDataset data = mz.erp.businessrules.twf_Validaciones.GetList( IdValidacion, Descripcion, Formula, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}



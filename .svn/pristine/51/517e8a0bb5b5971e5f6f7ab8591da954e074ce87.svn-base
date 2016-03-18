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

	public class twf_Dependencias : IDisposable, IGridDocument
	{
		public twf_Dependencias()
		{
		}

		public twf_Dependencias( string[] fieldList )
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
			
			if ( fl.Contains( "IdDependencia" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDependencia", "IdDependencia" ) );
			if ( fl.Contains( "IdCamino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCamino", "IdCamino" ) );
			if ( fl.Contains( "IdTarea" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTarea", "IdTarea" ) );
			if ( fl.Contains( "IdConexion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexion", "IdConexion" ) );
			if ( fl.Contains( "Orden" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Orden", "Orden" ) );
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
			return mz.erp.businessrules.twf_Dependencias.GetList().twf_Dependencias;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.twf_Dependencias.Update( ( twf_DependenciasDataset.twf_DependenciasDataTable )dataTable );
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

		[ SearchMember( "twf_Dependencias" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdDependencia" ) ] long IdDependencia, 
			[ SearchParameterInfo( "IdCamino" ) ] long IdCamino, 
			[ SearchParameterInfo( "IdTarea" ) ] long IdTarea, 
			[ SearchParameterInfo( "IdConexion" ) ] long IdConexion, 
			[ SearchParameterInfo( "Orden" ) ] short Orden, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "Observaciones" ) ] string Observaciones
			)
		{
			twf_DependenciasDataset data = mz.erp.businessrules.twf_Dependencias.GetList( IdDependencia, IdCamino, IdTarea, IdConexion, Orden, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


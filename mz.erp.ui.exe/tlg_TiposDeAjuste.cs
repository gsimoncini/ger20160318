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

	public class tlg_TiposDeAjuste : IDisposable, IGridDocument
	{
		public tlg_TiposDeAjuste()
		{
		}

		public tlg_TiposDeAjuste( string[] fieldList )
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
			
			if ( fl.Contains( "IdTipoAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoAjuste", "IdTipoAjuste" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdEstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEstadoDeStock", "IdEstadoDeStock" ) );
			if ( fl.Contains( "OldIdTipoAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OldIdTipoAjuste", "OldIdTipoAjuste" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{		
			
			return mz.erp.businessrules.tlg_TiposDeAjuste.GetList().tlg_TiposDeAjuste;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tlg_TiposDeAjuste.Update( ( tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteDataTable )dataTable );
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

		[ SearchMember( "tlg_TiposDeAjuste" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTipoAjuste" ) ] string IdTipoAjuste, 
			[ SearchParameterInfo( "Descripcion" ) ] string Descripcion, 
			[ SearchParameterInfo( "Sistema" ) ] bool Sistema, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa, 
			[ SearchParameterInfo( "IdEstadoDeStock" ) ] long IdEstadoDeStock, 
			[ SearchParameterInfo( "OldIdTipoAjuste" ) ] string OldIdTipoAjuste
			)
		{
			tlg_TiposDeAjusteDataset data = mz.erp.businessrules.tlg_TiposDeAjuste.GetList( IdTipoAjuste, Descripcion, Sistema, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa, IdEstadoDeStock, OldIdTipoAjuste );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


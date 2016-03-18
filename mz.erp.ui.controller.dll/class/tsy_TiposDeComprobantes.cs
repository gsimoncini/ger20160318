namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tsy_TiposDeComprobantes : IDisposable
	{
		public tsy_TiposDeComprobantes()
		{
		}

		public tsy_TiposDeComprobantes( string[] fieldList )
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
			
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "IdTipoDeComprobante",true  ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion", 200 ) );
			if ( fl.Contains( "Mascara" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Mascara", "Mascara",true ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public static DataTable GetList()
		{
			return mz.erp.businessrules.tsy_TiposDeComprobantes.GetList().tsy_TiposDeComprobantes;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsy_TiposDeComprobantes.Update( ( tsy_TiposDeComprobantesDataset.tsy_TiposDeComprobantesDataTable )dataTable );
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

		[ SearchMember( "tsy_TiposDeComprobantes" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTipoDeComprobante", IsAlternativePrimaryKey = true ) ] string IdTipoDeComprobante, 
			[ SearchParameterInfo( "Descripcion", IsDescription = true ) ] string Descripcion
			)
		{
			tsy_TiposDeComprobantesDataset data = mz.erp.businessrules.tsy_TiposDeComprobantes.GetList( IdTipoDeComprobante, Descripcion, true , int.MinValue,null);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


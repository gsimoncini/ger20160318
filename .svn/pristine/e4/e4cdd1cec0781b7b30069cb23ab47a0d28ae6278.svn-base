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


	public class tlg_TiposDeAjuste : IDisposable//, IGridDocument
	{
		public tlg_TiposDeAjuste()
		{
		}

		public tlg_TiposDeAjuste( string[] fieldList )
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
			
			if (mz.erp.businessrules.Security.PerteneceAPerfilSuperior)
			{
				if ( fl.Contains( "IdTipoAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoAjuste", "IdTipoAjuste") );
				if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema",50,Types.ColumnTypes.CheckBox) );
			}
			else
			{
				if ( fl.Contains( "IdTipoAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoAjuste", "IdTipoAjuste",true) );
				if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema",true) );
			}

			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción" ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",50, Types.ColumnTypes.CheckBox) );
			if ( fl.Contains( "Operacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Operacion", "Operación") );
			/*if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion", true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion", true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion", true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion", true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado", true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId", true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal", true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa", true ) );
			if ( fl.Contains( "IdEstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEstadoDeStock", "IdEstadoDeStock", true ) );
			if ( fl.Contains( "OldIdTipoAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "OldIdTipoAjuste", "OldIdTipoAjuste", true ) );
			*/
			if ( fl.Contains( "AfectaSeguimientoDeArticulosFisico" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "AfectaSeguimientoDeArticulosFisico", "AfectaSeguimientoDeArticulosFisico",50,Types.ColumnTypes.CheckBox) );

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public static DataTable GetList()
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
		public static DataSet GetList( 
			[ SearchParameterInfo( "IdTipoAjuste",IsAlternativePrimaryKey = true ) ] string IdTipoAjuste, 
			[ SearchParameterInfo( "Descripcion", IsDescription = true ) ] string Descripcion
			/*[ SearchParameterInfo( "Sistema" ) ] bool Sistema, 
			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal, 
			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa, 
			[ SearchParameterInfo( "IdEstadoDeStock" ) ] string IdEstadoDeStock, 
			[ SearchParameterInfo( "OldIdTipoAjuste" ) ] string OldIdTipoAjuste*/
			)
		{
			//tlg_TiposDeAjusteDataset data = mz.erp.businessrules.tlg_TiposDeAjuste.GetList( IdTipoAjuste, Descripcion, Sistema, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa, IdEstadoDeStock, OldIdTipoAjuste );
			if (mz.erp.businessrules.Security.PerteneceAPerfilSuperior)
			{
				tlg_TiposDeAjusteDataset data = mz.erp.businessrules.tlg_TiposDeAjuste.GetList( IdTipoAjuste, Descripcion);
				return ( DataSet )data;
			}
			else
			{			
				tlg_TiposDeAjusteDataset data = mz.erp.businessrules.tlg_TiposDeAjuste.GetListQueNoSeanDeSistema( IdTipoAjuste, Descripcion);
				return ( DataSet )data;
			}
		}
		
		public void Dispose()
		{
		}
		
	}
}


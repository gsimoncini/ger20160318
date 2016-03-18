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

	public class tfi_Entidades : IDisposable, IGridDocument
	{
		public tfi_Entidades()
		{
		}

		public tfi_Entidades( string[] fieldList )
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
			
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "IdEntidad", true ) );
			if ( fl.Contains( "Codigo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Codigo", "Codigo",150 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",200 ) );
			if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema",true ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha de Creacion",true ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "Ultima Modificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId", true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "Empresa",true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "Sucursal",true ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_Entidades.GetList().tfi_Entidades;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_Entidades.Update( ( tfi_EntidadesDataset.tfi_EntidadesDataTable )dataTable );
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


		[ SearchMember( "tfi_Entidades" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "Codigo", IsAlternativePrimaryKey=true ) ] string Codigo, 
			[ SearchParameterInfo( "Descripcion", IsDescription= true ) ] string Descripcion
			)
		{
			tfi_EntidadesDataset data = mz.erp.businessrules.tfi_Entidades.GetList( Codigo, Descripcion );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


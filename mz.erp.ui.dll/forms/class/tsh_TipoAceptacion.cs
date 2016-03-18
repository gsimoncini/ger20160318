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

	public class tsh_TipoAceptacion : IDisposable, IGridDocument
	{
		public tsh_TipoAceptacion()
		{
		}

		public tsh_TipoAceptacion( string[] fieldList )
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
			
			if ( fl.Contains( "IdTipoAceptacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoAceptacion", "IdTipoAceptacion" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Aux1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Aux1", "Aux1" ) );
			if ( fl.Contains( "Aux2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Aux2", "Aux2" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_TipoAceptacion.GetList().tsh_TipoAceptacion;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_TipoAceptacion.Update( ( tsh_TipoAceptacionDataset.tsh_TipoAceptacionDataTable )dataTable );
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

		/*[ SearchMember( "tsh_TipoAceptacion" ) ]
		public static DataSet GetList(  )
		{
			tsh_TipoAceptacionDataset data = mz.erp.businessrules.tsh_TipoAceptacion.GetList(  );
			return ( DataSet )data;
		}
		*/
		public void Dispose()
		{
		}
		
	}
}


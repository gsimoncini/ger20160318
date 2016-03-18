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

	public class tfi_TDCompTesoreria : IDisposable, IGridDocument
	{
		public tfi_TDCompTesoreria()
		{
		}

		public tfi_TDCompTesoreria( string[] fieldList )
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
			
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "Id",20, false ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción" ) );
			if ( fl.Contains( "Recargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Recargo", "% Rec.",50 ) );
//			if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema" ) );
			if ( fl.Contains( "Agrupado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Agrupado", "Agrupado" , 20, mz.erp.ui.controllers.Types.ColumnTypes.CheckBox ) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo" , 20, mz.erp.ui.controllers.Types.ColumnTypes.CheckBox ) );
//			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
//			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
//			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
//			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
//			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
//			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
//			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
//			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_TDCompTesoreria.GetList().tfi_TDCompTesoreria;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_TDCompTesoreria.Update( ( tfi_TDCompTesoreriaDataset.tfi_TDCompTesoreriaDataTable )dataTable );
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

		[ SearchMember( "tfi_TDCompTesoreria" ) ]
		public static DataSet GetList( 
			[ SearchParameterInfo( "Id", IsAlternativePrimaryKey = true ) ] string IdTDCompTesoreria, 
			[ SearchParameterInfo( "Descripción" , IsDescription = true ) ] string Descripcion ,
			[ SearchParameterInfo( "Activo" ) ] bool Activo 
//			[ SearchParameterInfo( "Sistema" ) ] bool Sistema, 
//			[ SearchParameterInfo( "Agrupado" ) ] bool Agrupado, 
//			[ SearchParameterInfo( "FechaCreacion" ) ] DateTime FechaCreacion, 
//			[ SearchParameterInfo( "IdConexionCreacion" ) ] long IdConexionCreacion, 
//			[ SearchParameterInfo( "UltimaModificacion" ) ] byte[] UltimaModificacion, 
//			[ SearchParameterInfo( "IdConexionUltimaModificacion" ) ] long IdConexionUltimaModificacion, 
//			[ SearchParameterInfo( "IdReservado" ) ] long IdReservado, 
//			[ SearchParameterInfo( "RowId" ) ] Guid RowId, 
//			[ SearchParameterInfo( "IdEmpresa" ) ] long IdEmpresa, 
//			[ SearchParameterInfo( "IdSucursal" ) ] long IdSucursal
			)
		{
//			tfi_TDCompTesoreriaDataset data = mz.erp.businessrules.tfi_TDCompTesoreria.GetList( IdTDCompTesoreria, Descripcion, Sistema, Agrupado, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal );
			tfi_TDCompTesoreriaDataset data = mz.erp.businessrules.tfi_TDCompTesoreria.GetListDescripcion( Descripcion, Activo);
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}



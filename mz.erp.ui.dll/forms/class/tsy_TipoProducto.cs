namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Collections;
	using System.Text;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controllers;

	public class tsy_TipoProducto : IDisposable, IGridDocument
	{
		public tsy_TipoProducto()
		{
		}
		
		public tsy_TipoProducto( string[] fieldList)
		{
			_fieldList = fieldList;
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
			
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "Id Tipo Producto",50 ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripción de caja",250 ) );
			if ( fl.Contains( "AfectaStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "AfectaStock", "Afecta Stock", 50, Types.ColumnTypes.CheckBox,Types.EditType.CheckBox) );
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo", 50, Types.ColumnTypes.CheckBox, Types.EditType.CheckBox) );
			/*if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );*/
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsy_TipoProducto.GetList().tsy_TipoProducto;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsy_TipoProducto.Update( ( tsy_TipoProductoDataset.tsy_TipoProductoDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}


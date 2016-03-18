namespace mz.erp.ui.controllers
{
	using System;
	using System.Collections;
	using System.Data;
	using System.Text;
	
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tsy_TipoProducto : IDisposable, IGridDocument
	{
		public tsy_TipoProducto()
		{
		}
		public tsy_TipoProducto(string[] fieldList)
		{
			_fieldList = fieldList;
		}
		
		private string[] _fieldList;
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
			
			if ( fl.Contains( "IdTipoProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoProducto", "IdTipoProducto",!fl.Contains( "IdTipoProducto" ) ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion",90 ) );
		
			
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


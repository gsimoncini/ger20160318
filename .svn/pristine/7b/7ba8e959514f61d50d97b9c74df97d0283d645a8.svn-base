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
	public class tpu_ProductosProveedores : IDisposable, IGridDocument
	{
		public tpu_ProductosProveedores()
		{
		}

		public tpu_ProductosProveedores( string[] fieldList )
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
			
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto" ) );
			if ( fl.Contains( "IdProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedor", "IdProveedor" ) );
			if ( fl.Contains( "PrecioCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioCosto", "PrecioCosto" ) );
			if ( fl.Contains( "Bonificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bonificacion", "Bonificacion" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_ProductosProveedores.GetList().tpu_ProductosProveedores;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_ProductosProveedores.Update( ( tpu_ProductosProveedoresDataset.tpu_ProductosProveedoresDataTable )dataTable );
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

		//[ SearchMember( "tpu_ProductosProveedores" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdProducto" ) ] string IdProducto, 
[ SearchParameterInfo( "IdProveedor" ) ] long IdProveedor
 )
		{
			tpu_ProductosProveedoresDataset data = mz.erp.businessrules.tpu_ProductosProveedores.GetList( IdProducto, IdProveedor );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


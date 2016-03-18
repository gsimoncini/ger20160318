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

	public class tsh_GruposProductos : IDisposable, IGridDocument
	{
		public tsh_GruposProductos()
		{
		}

		public tsh_GruposProductos( string[] fieldList )
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
			if ( fl.Contains( "IdPadre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPadre", "IdPadre" ) );
			if ( fl.Contains( "Orden" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Orden", "Orden" ) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad" ) );
			if ( fl.Contains( "BonificacionVisual" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "BonificacionVisual", "BonificacionVisual" ) );
			if ( fl.Contains( "FormulaDeCalculoCantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FormulaDeCalculoCantidad", "FormulaDeCalculoCantidad" ) );
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
			return mz.erp.businessrules.tsh_GruposProductos.GetList().tsh_GruposProductos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_GruposProductos.Update( ( tsh_GruposProductosDataset.tsh_GruposProductosDataTable )dataTable );
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

		[ SearchMember( "tsh_GruposProductos" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdProducto" ) ] string IdProducto, 
			[ SearchParameterInfo( "IdPadre" ) ] string IdPadre
			)
		{
			tsh_GruposProductosDataset data = mz.erp.businessrules.tsh_GruposProductos.GetList( IdProducto, IdPadre );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


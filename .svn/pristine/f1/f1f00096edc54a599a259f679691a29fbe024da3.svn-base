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
	using mz.erp.ui.controllers;

	public class tfi_ValorizacionStock : IDisposable, IGridDocument
	{
		public tfi_ValorizacionStock()
		{
		}

		public tfi_ValorizacionStock( string[] fieldList )
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
			
			if ( fl.Contains( "IdValorizacionStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValorizacionStock", "IdValorizacionStock" ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha" ) );
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto" ) );
			if ( fl.Contains( "IdDeposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDeposito", "IdDeposito" ) );
			if ( fl.Contains( "IdSeccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSeccion", "IdSeccion" ) );
			if ( fl.Contains( "IdEstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEstadoDeStock", "IdEstadoDeStock" ) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad" ) );
			if ( fl.Contains( "Costo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Costo", "Costo" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_ValorizacionStock.GetList().tfi_ValorizacionStock;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_ValorizacionStock.Update( ( tfi_ValorizacionStockDataset.tfi_ValorizacionStockDataTable )dataTable );
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

		[ SearchMember( "tfi_ValorizacionStock" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "Fecha" ) ] DateTime Fecha, 
			[ SearchParameterInfo( "IdProducto" ) ] string IdProducto, 
			[ SearchParameterInfo( "IdDeposito" ) ] string IdDeposito, 
			[ SearchParameterInfo( "IdSeccion" ) ] string IdSeccion, 
			[ SearchParameterInfo( "IdEstadoDeStock" ) ] string IdEstadoDeStock
			)
		{
			tfi_ValorizacionStockDataset data = mz.erp.businessrules.tfi_ValorizacionStock.GetList( Fecha, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


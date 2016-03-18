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

	public class tlg_MovimientosDeStock : IDisposable, IGridDocument
	{
		public tlg_MovimientosDeStock()
		{
		}

		public tlg_MovimientosDeStock( string[] fieldList )
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
			
			if ( fl.Contains( "IdMovimientoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMovimientoDeStock", "IdMovimientoDeStock",true ) );
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto",true ) );
			if ( fl.Contains( "Producto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Producto", "Producto",150 ) );
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad",100 ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha",100,Types.Aligment.Far ) );
			if ( fl.Contains( "Deposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Deposito", "Deposito",150 ) );
			if ( fl.Contains( "Seccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Seccion", "Seccion",150 ) );
			if ( fl.Contains( "IdDeposito" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdDeposito", "IdDeposito",true ) );
			if ( fl.Contains( "IdSeccion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSeccion", "IdSeccion",true ) );
			if ( fl.Contains( "IdEstadoDeStock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEstadoDeStock", "IdEstadoDeStock",true ) );
			if ( fl.Contains( "IdTipoDeAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeAjuste", "IdTipoDeAjuste",true ) );
			
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion",true ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion",true ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId",true ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal",true ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa",true ) );
			if ( fl.Contains( "Estado de Stock" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Estado de Stock", "Estado de Stock",200 ) );
			if ( fl.Contains( "Tipo de Ajuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Tipo de Ajuste", "Tipo de Ajuste",200 ) );
			

			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return null;//mz.erp.businessrules.tlg_MovimientosDeStock.GetList().tlg_MovimientosDeStock;
		}
		
		public void Update( object dataTable )
		{
			//mz.erp.businessrules.tlg_MovimientosDeStock.Update( ( tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable )dataTable );
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
		/*
		[ SearchMember( "tlg_MovimientosDeStock" ) ]		
		public static DataSet GetList()		
		{
			tlg_MovimientosDeStockDataset data = mz.erp.businessrules.tlg_MovimientosDeStock.GetList();
			return ( DataSet )data;
		}*/
	
		public void Dispose()
		{
		}
		
	}
}


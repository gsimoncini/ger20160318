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

	public class tfi_MovimientosDeCaja : IDisposable, IGridDocument
	{
		public tfi_MovimientosDeCaja()
		{
		}

		public tfi_MovimientosDeCaja( string[] fieldList )
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
			
			if ( fl.Contains( "IdMovimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMovimiento", "IdMovimiento" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdInstanciaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "IdInstanciaCaja" ) );
			if ( fl.Contains( "IdTipoDeMovimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeMovimiento", "IdTipoDeMovimiento" ) );
			if ( fl.Contains( "IdSubTipoMovimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSubTipoMovimiento", "IdSubTipoMovimiento" ) );
			if ( fl.Contains( "TipoComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TipoComprobante", "TipoComprobante" ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero" ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha" ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable" ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total" ) );
			if ( fl.Contains( "IdMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaCierre", "IdMonedaCierre" ) );
			if ( fl.Contains( "IdCotizacionCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionCierre", "IdCotizacionCierre" ) );
			if ( fl.Contains( "IdAceptacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdAceptacion", "IdAceptacion" ) );
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
			return mz.erp.businessrules.tfi_MovimientosDeCaja.GetList().tfi_MovimientosDeCaja;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_MovimientosDeCaja.Update( ( tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaDataTable )dataTable );
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

		[ SearchMember( "tfi_MovimientosDeCaja" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdInstanciaCaja" ) ] string IdInstanciaCaja, 
			[ SearchParameterInfo( "IdTipoDeMovimiento" ) ] string IdTipoDeMovimiento, 
			[ SearchParameterInfo( "IdSubTipoMovimiento" ) ] string IdSubTipoMovimiento, 
			[ SearchParameterInfo( "TipoComprobante" ) ] string TipoComprobante, 
			[ SearchParameterInfo( "Numero" ) ] string Numero, 
			[ SearchParameterInfo( "Fecha" ) ] DateTime Fecha, 
			[ SearchParameterInfo( "IdResponsable" ) ] string IdResponsable, 
			[ SearchParameterInfo( "Total" ) ] decimal Total, 
			[ SearchParameterInfo( "IdMonedaCierre" ) ] string IdMonedaCierre,
			[ SearchParameterInfo( "IdAceptacion" ) ] string IdAceptacion
			)
		{
			tfi_MovimientosDeCajaDataset data = mz.erp.businessrules.tfi_MovimientosDeCaja.GetList( IdInstanciaCaja, IdTipoDeMovimiento, IdSubTipoMovimiento, TipoComprobante, Numero, Fecha, IdResponsable, Total, IdMonedaCierre, IdAceptacion );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


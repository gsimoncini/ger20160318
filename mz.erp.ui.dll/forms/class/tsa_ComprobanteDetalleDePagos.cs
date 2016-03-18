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

	public class tsa_ComprobanteDetalleDePagos : IDisposable, IGridDocument
	{
		public tsa_ComprobanteDetalleDePagos()
		{
		}

		public tsa_ComprobanteDetalleDePagos( string[] fieldList )
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
			
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "IdTipoDeComprobante" ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero" ) );
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante" ) );
			if ( fl.Contains( "IdValor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdValor", "IdValor" ) );
			if ( fl.Contains( "Monto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Monto", "Monto" ) );
			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda" ) );
			if ( fl.Contains( "IdCotizaicon" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizaicon", "IdCotizaicon" ) );
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
			return mz.erp.businessrules.tsa_ComprobanteDetalleDePagos.GetList().tsa_ComprobanteDetalleDePagos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_ComprobanteDetalleDePagos.Update( ( tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosDataTable )dataTable );
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

		[ SearchMember( "tsa_ComprobanteDetalleDePagos" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTipoDeComprobante" ) ] string IdTipoDeComprobante, 
			[ SearchParameterInfo( "Numero" ) ] string Numero, 
			[ SearchParameterInfo( "IdComprobante" ) ] string IdComprobante, 
			[ SearchParameterInfo( "IdValor" ) ] string IdValor, 
			[ SearchParameterInfo( "Monto" ) ] decimal Monto
			)
		{
			tsa_ComprobanteDetalleDePagosDataset data = mz.erp.businessrules.tsa_ComprobanteDetalleDePagos.GetList( IdTipoDeComprobante, Numero, IdComprobante, IdValor, Monto );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}



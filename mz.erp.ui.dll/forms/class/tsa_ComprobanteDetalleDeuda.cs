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
	public class tsa_ComprobanteDetalleDeuda : IDisposable, IGridDocument
	{
		public tsa_ComprobanteDetalleDeuda()
		{
		}

		public tsa_ComprobanteDetalleDeuda( string[] fieldList )
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
			
			if ( fl.Contains( "IdComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobante", "IdComprobante" ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "IdTipoDeComprobante" ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero" ) );
			if ( fl.Contains( "FechaEmision" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaEmision", "FechaEmision" ) );
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "FechaVencimiento" ) );
			if ( fl.Contains( "Cuota" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cuota", "Cuota" ) );
			if ( fl.Contains( "Importe" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Importe", "Importe" ) );
			if ( fl.Contains( "Saldo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Saldo", "Saldo" ) );
			if ( fl.Contains( "IdMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaCierre", "IdMonedaCierre" ) );
			if ( fl.Contains( "IdCotizacionCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionCierre", "IdCotizacionCierre" ) );
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
			return mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetList().tsa_ComprobanteDetalleDeuda;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.Update( ( tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaDataTable )dataTable );
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

		/*[ SearchMember( "tsa_ComprobanteDetalleDeuda" ) ]
		public static DataSet GetList(  )
		{
			tsa_ComprobanteDetalleDeudaDataset data = mz.erp.businessrules.tsa_ComprobanteDetalleDeuda.GetList(  );
			return ( DataSet )data;
		}
		*/
		public void Dispose()
		{
		}
		
	}
}


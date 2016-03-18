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

	public class tsa_Comprobantes : IDisposable, IGridDocument
	{
		public tsa_Comprobantes()
		{
		}

		public tsa_Comprobantes( string[] fieldList )
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
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdInstanciaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "IdInstanciaCaja" ) );
			if ( fl.Contains( "IdTipoDeComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobante", "IdTipoDeComprobante" ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero" ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha" ) );
			if ( fl.Contains( "IdCuenta" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCuenta", "IdCuenta" ) );
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable" ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total" ) );
			if ( fl.Contains( "TotalConImpuestos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "TotalConImpuestos", "TotalConImpuestos" ) );
			if ( fl.Contains( "IdMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaCierre", "IdMonedaCierre" ) );
			if ( fl.Contains( "IdCotizacionCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionCierre", "IdCotizacionCierre" ) );
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
			return mz.erp.businessrules.tsa_Comprobantes.GetList().tsa_Comprobantes;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_Comprobantes.Update( ( tsa_ComprobantesDataset.tsa_ComprobantesDataTable )dataTable );
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

		/*[ SearchMember( "tsa_Comprobantes" ) ]
		public static DataSet GetList(  )
		{
			tsa_ComprobantesDataset data = mz.erp.businessrules.tsa_Comprobantes.GetList(  );
			return ( DataSet )data;
		}*/
		
		public void Dispose()
		{
		}
		
	}
}


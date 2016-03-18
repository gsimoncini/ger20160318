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

	public class tfi_InstanciasCajaCierres : IDisposable, IGridDocument
	{
		public tfi_InstanciasCajaCierres()
		{
		}

		public tfi_InstanciasCajaCierres( string[] fieldList )
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
			
			if ( fl.Contains( "IdInstanciaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "IdInstanciaCaja" ) );
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria" ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total" ) );
			if ( fl.Contains( "IdMonedaCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaCierre", "IdMonedaCierre" ) );
			if ( fl.Contains( "IdCotizacionCierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionCierre", "IdCotizacionCierre" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			//return mz.erp.businessrules.tfi_InstanciasCajaCierres.GetList().tfi_InstanciasCajaCierres;
			return null;
		}
		
		public void Update( object dataTable )
		{
		//	mz.erp.businessrules.tfi_InstanciasCajaCierres.Update( ( tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresDataTable )dataTable );
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

	[ SearchMember( "tfi_InstanciasCajaCierres" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdInstanciaCaja" ) ] string IdInstanciaCaja, 
			[ SearchParameterInfo( "IdTDCompTesoreria" ) ] string IdTDCompTesoreria, 
			[ SearchParameterInfo( "Total" ) ] decimal Total, 
			[ SearchParameterInfo( "IdMonedaCierre" ) ] string IdMonedaCierre, 
			[ SearchParameterInfo( "IdCotizacionCierre" ) ] string IdCotizacionCierre
			)
		{
		//	tfi_InstanciasCajaCierresDataset data = mz.erp.businessrules.tfi_InstanciasCajaCierres.GetList( IdInstanciaCaja, IdTDCompTesoreria, Total, IdMonedaCierre, IdCotizacionCierre );
		//	return ( DataSet )data;
		return null;
		}
		
		public void Dispose()
		{
		}
		
	}
}



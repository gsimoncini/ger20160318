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

	public class tsa_AplicacionPagos : IDisposable, IGridDocument
	{
		public tsa_AplicacionPagos()
		{
		}

		public tsa_AplicacionPagos( string[] fieldList )
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
			
			if ( fl.Contains( "IdTipoComprobanteOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoComprobanteOrigen", "IdTipoComprobanteOrigen" ) );
			if ( fl.Contains( "IdComprobanteOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobanteOrigen", "IdComprobanteOrigen" ) );
			if ( fl.Contains( "CuotaOrigen" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CuotaOrigen", "CuotaOrigen" ) );
			if ( fl.Contains( "Importe" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Importe", "Importe" ) );
			if ( fl.Contains( "IdTipoDeComprobanteDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoDeComprobanteDestino", "IdTipoDeComprobanteDestino" ) );
			if ( fl.Contains( "IdComprobanteDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdComprobanteDestino", "IdComprobanteDestino" ) );
			if ( fl.Contains( "CuotaDestino" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CuotaDestino", "CuotaDestino" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
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
			return mz.erp.businessrules.tsa_AplicacionPagos.GetList().tsa_AplicacionPagos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_AplicacionPagos.Update( ( tsa_AplicacionPagosDataset.tsa_AplicacionPagosDataTable )dataTable );
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

		[ SearchMember( "tsa_AplicacionPagos" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdComprobanteOrigen" ) ] string IdComprobanteOrigen, 
			[ SearchParameterInfo( "CuotaOrigen" ) ] short CuotaOrigen, 
			[ SearchParameterInfo( "Importe" ) ] decimal Importe, 
			[ SearchParameterInfo( "IdTipoDeComprobanteDestino" ) ] string IdTipoDeComprobanteDestino, 
			[ SearchParameterInfo( "IdComprobanteDestino" ) ] string IdComprobanteDestino, 
			[ SearchParameterInfo( "CuotaDestino" ) ] short CuotaDestino
			)
		{
			tsa_AplicacionPagosDataset data = mz.erp.businessrules.tsa_AplicacionPagos.GetList( IdComprobanteOrigen, CuotaOrigen, Importe, IdTipoDeComprobanteDestino, IdComprobanteDestino, CuotaDestino );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


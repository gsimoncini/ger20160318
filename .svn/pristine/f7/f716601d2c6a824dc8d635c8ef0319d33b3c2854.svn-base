namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	

	public class tpu_ProveedoresProductos : IDisposable, IGridDocument
	{
		public tpu_ProveedoresProductos()
		{
		}

		public tpu_ProveedoresProductos( string[] fieldList )
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
			
			if ( fl.Contains( "IdProveedor" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProveedor", "IdProveedor" ) );
			if ( fl.Contains( "IdProducto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdProducto", "IdProducto" ) );
			if ( fl.Contains( "PrecioDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "PrecioDeCosto", "PrecioDeCosto" ) );
			if ( fl.Contains( "IdMonedaPrecioDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMonedaPrecioDeCosto", "IdMonedaPrecioDeCosto" ) );
			if ( fl.Contains( "IdCotizacionPrecioDeCosto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionPrecioDeCosto", "IdCotizacionPrecioDeCosto" ) );
			if ( fl.Contains( "IdFuenteDeCambio" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFuenteDeCambio", "IdFuenteDeCambio" ) );
			if ( fl.Contains( "CampoAuxiliar1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar1", "CampoAuxiliar1" ) );
			if ( fl.Contains( "CampoAuxiliar2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar2", "CampoAuxiliar2" ) );
			if ( fl.Contains( "CampoAuxiliar3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar3", "CampoAuxiliar3" ) );
			if ( fl.Contains( "CampoAuxiliar4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar4", "CampoAuxiliar4" ) );
			if ( fl.Contains( "CampoAuxiliar5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "CampoAuxiliar5", "CampoAuxiliar5" ) );
			if ( fl.Contains( "Bonificacion1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bonificacion1", "Bonificacion1" ) );
			if ( fl.Contains( "Bonificacion2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bonificacion2", "Bonificacion2" ) );
			if ( fl.Contains( "Bonificacion3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bonificacion3", "Bonificacion3" ) );
			if ( fl.Contains( "Bonificacion4" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bonificacion4", "Bonificacion4" ) );
			if ( fl.Contains( "Bonificacion5" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Bonificacion5", "Bonificacion5" ) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones" ) );
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
			return mz.erp.businessrules.tpu_ProveedoresProductos.GetList().tpu_ProveedoresProductos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_ProveedoresProductos.Update( ( tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosDataTable )dataTable );
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

		[ SearchMember( "tpu_ProveedoresProductos" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdProveedor" ) ] string IdProveedor, 
			[ SearchParameterInfo( "IdProducto" ) ] string IdProducto, 
			[ SearchParameterInfo( "IdMonedaPrecioDeCosto" ) ] string IdMonedaPrecioDeCosto, 
			[ SearchParameterInfo( "IdCotizacionPrecioDeCosto" ) ] string IdCotizacionPrecioDeCosto, 
			[ SearchParameterInfo( "IdFuenteDeCambio" ) ] string IdFuenteDeCambio
			)
		{
			tpu_ProveedoresProductosDataset data = mz.erp.businessrules.tpu_ProveedoresProductos.GetList( IdProveedor, IdProducto, IdMonedaPrecioDeCosto, IdCotizacionPrecioDeCosto, IdFuenteDeCambio );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}



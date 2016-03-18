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
	
	public class tfi_InstanciasCaja : IDisposable, IGridDocument
	{
		public tfi_InstanciasCaja()
		{
		}

		#region Custom Membera
		
		public string GetLayoutCierre()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Cantidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cantidad", "Cantidad" ) );
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria", true ) );
			if ( fl.Contains( "Tipo de Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Tipo de Comprobante", "Tipo de Comprobante",150 ) );
			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda", true ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda", 150 ) );
			if ( fl.Contains( "IdCotizacionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionMoneda", "IdCotizacionMoneda", true ) );
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "IdEntidad", true ) );
			if ( fl.Contains( "Entidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad", 150 ) );
			//if ( fl.Contains( "Neto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Neto", "Neto" ) );
			if ( fl.Contains( "Neto" )            || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Neto", "Neto", 70, Types.Aligment.Far,Types.FormatDisplay.Money) );            
			//	if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			//	if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			//	if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			//	if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			//	if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		
		
		#endregion

		public tfi_InstanciasCaja( string[] fieldList )
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
			
			if ( fl.Contains( "IdInstanciaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "Instancia Nº",true ) );
			if ( fl.Contains( "IdCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCaja", "Caja Nº",75 ) );
			//if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			//	if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion de caja",150 ) );
			if ( fl.Contains( "Apertura" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Apertura", "Apertura",150 ) );
			if ( fl.Contains( "Cierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cierre", "Cierre",150, true ) );
			if ( fl.Contains( "Responsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Responsable", "Responsable",100) );			
			if ( fl.Contains( "IdResponsable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdResponsable", "IdResponsable",true) );			
			
			//	if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			//	if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			//	if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			//	if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			//	if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			//	if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		

		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_InstanciasCaja.GetList().tfi_InstanciasCaja;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_InstanciasCaja.Update( ( tfi_InstanciasCajaDataset.tfi_InstanciasCajaDataTable )dataTable );
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

		[ SearchMember( "tfi_InstanciasCaja" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdInstanciaCaja" ) ] string IdInstanciaCaja, 
			[ SearchParameterInfo( "IdCaja" ) ] string IdCaja, 
			[ SearchParameterInfo( "Apertura" ) ] DateTime Apertura, 
			[ SearchParameterInfo( "Cierre" ) ] DateTime Cierre,
			[ SearchParameterInfo( "IdResponsable" ) ] string IdResponsable
			)
		{
			tfi_InstanciasCajaDataset data = mz.erp.businessrules.tfi_InstanciasCaja.GetList( IdInstanciaCaja, IdCaja, Apertura, Cierre, IdResponsable );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		public string GetLayoutIngresosEgresos()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdInstanciaCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdInstanciaCaja", "IdInstanciaCaja",true ) );
			if ( fl.Contains( "IdBusqueda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdBusqueda", "IdBusqueda", true ) );
			if ( fl.Contains( "Tipo de Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Tipo de Comprobante", "Tipo de Comprobante",150 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero",100 ) );
			if ( fl.Contains( "Total" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Total", "Total",100,Types.Aligment.Far, Types.FormatDisplay.Money ) );
			if ( fl.Contains( "Moneda de Cierre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda de Cierre", "Moneda de Cierre",150 ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",150 ) );
			if ( fl.Contains( "SourceTable" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "SourceTable", "SourceTable", true ) );
			
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		public string GetLayoutDetalleValores()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "Comprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comprobante", "Comprobante",100 ) );
			if ( fl.Contains( "Moneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Moneda", "Moneda",75 ) );
			if ( fl.Contains( "Monto" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Monto", "Monto Moneda Origen",100,Types.Aligment.Far,Types.FormatDisplay.Money ) );
			if ( fl.Contains( "MontoCotizado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "MontoCotizado", "Monto Cotizado",100,Types.Aligment.Far,Types.FormatDisplay.Money  ) );
			if ( fl.Contains( "ValorCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "ValorCotizacion", "Valor de Cotizacion",100,Types.Aligment.Far,Types.FormatDisplay.Money  ) );
			if ( fl.Contains( "Fecha" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Fecha", "Fecha",150));																	
			if ( fl.Contains( "FechaVencimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaVencimiento", "FechaVencimiento",150 ) );
			if ( fl.Contains( "Numero" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Numero", "Numero",75 ) );
			if ( fl.Contains( "Entidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Entidad", "Entidad",75 ) );
			if ( fl.Contains( "IdCotizacionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacionMoneda", "IdCotizacionMoneda", true ) );
			
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

		


		
	}
}


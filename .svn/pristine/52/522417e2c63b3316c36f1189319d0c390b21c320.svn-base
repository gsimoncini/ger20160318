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
	using mz.erp.businessrules;
	using mz.erp.ui.controllers;



	public class tfi_FormasDePago : IDisposable, IGridDocument
	{
		public tfi_FormasDePago()
		{
		}

		public tfi_FormasDePago( string[] fieldList )
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
			
			if ( fl.Contains( "IdTDCompTesoreria" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDCompTesoreria", "IdTDCompTesoreria" ) );
			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda" ) );
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "IdEntidad" ) );
			if ( fl.Contains( "Cuotas" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cuotas", "Cuotas" ) );
			if ( fl.Contains( "Recargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Recargo", "Recargo" ) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "FechaCreacion" ) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "UltimaModificacion" ) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdFormaDePago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFormaDePago", "IdFormaDePago" ) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_FormasDePago.GetList().tfi_FormasDePago;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_FormasDePago.Update( ( tfi_FormasDePagoDataset.tfi_FormasDePagoDataTable )dataTable );
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

		[ SearchMember( "tfi_FormasDePago" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTDCompTesoreria" ) ] string IdTDCompTesoreria, 
			[ SearchParameterInfo( "IdMoneda" ) ] string IdMoneda, 
			[ SearchParameterInfo( "IdEntidad" ) ] string IdEntidad, 
			[ SearchParameterInfo( "Cuotas" ) ] short Cuotas
			)
		{
			tfi_FormasDePagoDataset data = mz.erp.businessrules.tfi_FormasDePago.GetList( IdTDCompTesoreria, IdMoneda, IdEntidad, Cuotas );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


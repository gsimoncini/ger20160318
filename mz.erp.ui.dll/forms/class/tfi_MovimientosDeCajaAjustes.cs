using System;

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

	public class tfi_MovimientosDeCajaAjustes : IDisposable, IGridDocument
	{
		public tfi_MovimientosDeCajaAjustes()
		{
		}

		public tfi_MovimientosDeCajaAjustes( string[] fieldList )
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
			
			if ( fl.Contains( "IdMovimientoDeCaja" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMovimientoDeCaja", "IdMovimientoDeCaja" ) );
			if ( fl.Contains( "IdMovimientoDeCajaAjuste" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMovimientoDeCajaAjuste", "IdMovimientoDeCajaAjuste" ) );
			if ( fl.Contains( "aux1" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "aux1", "aux1" ) );
			if ( fl.Contains( "aux2" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "aux2", "aux2" ) );
			if ( fl.Contains( "aux3" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "aux3", "aux3" ) );
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
			return mz.erp.businessrules.tfi_MovimientosDeCajaAjustes.GetList().tfi_MovimientosDeCajaAjustes;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_MovimientosDeCajaAjustes.Update( ( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesDataTable )dataTable );
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

		/*[ SearchMember( "tfi_MovimientosDeCajaAjustes" ) ]
		public static DataSet GetList(  )
		{
			tfi_MovimientosDeCajaAjustesDataset data = mz.erp.businessrules.tfi_MovimientosDeCajaAjustes.GetList(  );
			return ( DataSet )data;
		}
		*/
		public void Dispose()
		{
		}
		
	}
}

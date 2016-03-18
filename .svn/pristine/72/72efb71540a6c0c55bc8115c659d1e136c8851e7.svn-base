
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

	public class tsy_SubTipoMovimiento : IDisposable, IGridDocument
	{
		public tsy_SubTipoMovimiento()
		{
		}

		public tsy_SubTipoMovimiento( string[] fieldList )
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
			
			if ( fl.Contains( "IdSubTipoMovimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSubTipoMovimiento", "IdSubTipoMovimiento" ) );
			if ( fl.Contains( "IdTipoMovimiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTipoMovimiento", "IdTipoMovimiento" ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Descripcion" ) );
			if ( fl.Contains( "Sistema" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Sistema", "Sistema" ) );
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
			return mz.erp.businessrules.tsy_SubTipoMovimiento.GetList().tsy_SubTipoMovimiento;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsy_SubTipoMovimiento.Update( ( tsy_SubTipoMovimientoDataset.tsy_SubTipoMovimientoDataTable )dataTable );
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

		[ SearchMember( "tsy_SubTipoMovimiento" ) ]
		/*public static DataSet GetList(  )
		{
			tsy_SubTipoMovimientoDataset data = mz.erp.businessrules.tsy_SubTipoMovimiento.GetList(  );
			return ( DataSet )data;
		}
		*/
		public void Dispose()
		{
		}
		
	}
}